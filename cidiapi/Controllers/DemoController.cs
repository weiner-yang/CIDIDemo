using Microsoft.AspNetCore.Mvc;

namespace cidiapi.Controllers
{
    [ApiController]
    public class DemoController : ControllerBase
    {
        public DemoController(ILogger<DemoController> logger)
        {
        }

        [HttpGet]
        [Route("api/[controller]/GetName/{name}")]
        public string Get(string name)
        {
            return name;
        }
    }
}