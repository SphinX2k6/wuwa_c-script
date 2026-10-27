using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200014C RID: 332
	public class PlatformReportSdkKeepAlive : PlatformSdkReportBaseData
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x00044ACE File Offset: 0x00042CCE
		public PlatformReportSdkKeepAlive()
		{
			this.event_id = 60108;
			this.event_name = "sdk_keepalive";
		}
	}
}
