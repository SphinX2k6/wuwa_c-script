using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000146 RID: 326
	public class PlatformReportTerminateGame : PlatformSdkReportBaseData
	{
		// Token: 0x06000A48 RID: 2632 RVA: 0x00044A0F File Offset: 0x00042C0F
		public PlatformReportTerminateGame()
		{
			this.event_id = 60101;
			this.event_name = "game_terminate";
		}
	}
}
