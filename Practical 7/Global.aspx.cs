protected void Application_Start(object sender, EventArgs e)
{
    ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
        new ScriptResourceDefinition
        {
            Path = "~/Scripts/jquery-3.7.1.min.js", // Make sure this file exists
            DebugPath = "~/Scripts/jquery-3.7.1.js",
            CdnPath = "https://code.jquery.com/jquery-3.7.1.min.js",
            CdnDebugPath = "https://code.jquery.com/jquery-3.7.1.js",
            LoadSuccessExpression = "window.jQuery"
        });
}