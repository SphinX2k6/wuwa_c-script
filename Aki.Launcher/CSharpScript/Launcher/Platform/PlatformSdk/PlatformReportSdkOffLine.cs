using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000164 RID: 356
	public class PlatformReportSdkOffLine : PlatformSdkReportBaseData
	{
		// Token: 0x06000A98 RID: 2712 RVA: 0x000471B5 File Offset: 0x000453B5
		public PlatformReportSdkOffLine()
		{
			this.event_id = 60142;
			this.event_name = "sdkaccount_offline";
		}

		// Token: 0x04000678 RID: 1656
		[Nullable(1)]
		public string offline_type = "";
	}
}
