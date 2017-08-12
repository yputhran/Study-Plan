using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyPlan.Startup))]
namespace StudyPlan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
