using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ocelot_demo_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            return "My name is shaun";
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            var employee = new Employee()
            {
                Id = 1,
                Name = "Shaun",
                Phone = "012547869"
            };
            return Ok(employee);
        }
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

    }
}
