using Microsoft.AspNetCore.Mvc;

namespace Doingsomething.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        // GET: HomeController
        public IActionResult Index()
        {
            return View();
        }

    }
}
