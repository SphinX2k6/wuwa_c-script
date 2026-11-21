using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200014A RID: 330
	public class PlatformReportTerminateGame : PlatformSdkReportBaseData
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x00046E23 File Offset: 0x00045023
		public PlatformReportTerminateGame()
		{
			this.event_id = 60101;
			this.event_name = "game_terminate";
		}
	}
}
