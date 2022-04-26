using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DemoApp01.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProjectDetails : ControllerBase
    {
        private static readonly string[] ProjectName = new[]
        {
            "ProjectOne", "ProjectTwo", "ProjectThree", "ProjectFour","ProjectFive"
        };

        private readonly ILogger<ProblemDetails>? logger;

        public int Name { get; private set; }
        public string? Discription { get; private set; }
        public DateTime Date { get; private set; }

        [HttpGet(Name = "ProjectDetails")]
        public IEnumerable<ProjectDetails> Get()
        {
            return Enumerable.Range(1, 4).Select(index => new ProjectDetails
              {
                Name = Random.Shared.Next(ProjectName.Length),
                Discription = "Discribing this side of the world!",
                Date = DateTime.Now.AddDays(index),    
                })
                .ToArray();
        }
       
    }
}
