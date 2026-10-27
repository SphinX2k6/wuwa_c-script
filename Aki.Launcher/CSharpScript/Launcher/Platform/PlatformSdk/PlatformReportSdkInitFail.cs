using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200014E RID: 334
	public class PlatformReportSdkInitFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A50 RID: 2640 RVA: 0x00044B0A File Offset: 0x00042D0A
		public PlatformReportSdkInitFail()
		{
			this.event_id = 60110;
			this.event_name = "krsdk_init_fail";
		}

		// Token: 0x04000635 RID: 1589
		[Nullable(1)]
		public string code = "";
	}
}
