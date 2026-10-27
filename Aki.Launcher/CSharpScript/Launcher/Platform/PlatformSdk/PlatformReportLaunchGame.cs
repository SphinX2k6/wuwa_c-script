using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000145 RID: 325
	public class PlatformReportLaunchGame : PlatformSdkReportBaseData
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x000449F1 File Offset: 0x00042BF1
		public PlatformReportLaunchGame()
		{
			this.event_id = 60100;
			this.event_name = "game_launch";
		}
	}
}
