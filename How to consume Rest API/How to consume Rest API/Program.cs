using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_consume_Rest_API
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiCallHelper apiCallHelper = new ApiCallHelper();

            // Get API call
            var response = apiCallHelper.CallToAPI("APIURL", null, MethodType.GET, true, null, false);
            var data = JsonConvert.DeserializeObject<Project>(response.Result);
            Console.WriteLine(data);

            // POST API call
            Project project = new Project() { ProjectName = "NewProject" };
            var objToPost = JsonConvert.SerializeObject(project);

             response = apiCallHelper.CallToAPI("APIURL", objToPost, MethodType.POST, true, null, false);
             Console.WriteLine(response.Result);

            Console.ReadKey();
        }
    }
    public class Project
    {
        public string ProjectName { get; set; }
    }
}


