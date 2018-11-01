    using Microsoft.AspNetCore.Mvc;
    namespace Portfolio.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            
            [HttpGet]
            [Route("")]
            public ViewResult Index()
            {
                return View();
            }

            [HttpGet]
            [Route("projects/")]
            public ViewResult Projects()
            {
                return View("Projects");
            }

            [HttpGet]
            [Route("contact/")]
            public ViewResult Contact()
            {
                return View("Contact");
            }
       
        }
    }
