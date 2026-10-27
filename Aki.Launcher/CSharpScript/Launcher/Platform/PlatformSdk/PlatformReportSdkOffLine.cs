using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000160 RID: 352
	public class PlatformReportSdkOffLine : PlatformSdkReportBaseData
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00044DA1 File Offset: 0x00042FA1
		public PlatformReportSdkOffLine()
		{
			this.event_id = 60142;
			this.event_name = "sdkaccount_offline";
		}

		// Token: 0x0400063D RID: 1597
		[Nullable(1)]
		public string offline_type = "";
	}
}
