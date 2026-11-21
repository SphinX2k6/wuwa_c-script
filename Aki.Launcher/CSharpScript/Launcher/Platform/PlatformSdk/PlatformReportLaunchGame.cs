using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000149 RID: 329
	public class PlatformReportLaunchGame : PlatformSdkReportBaseData
	{
		// Token: 0x06000A7B RID: 2683 RVA: 0x00046E05 File Offset: 0x00045005
		public PlatformReportLaunchGame()
		{
			this.event_id = 60100;
			this.event_name = "game_launch";
		}
	}
}
