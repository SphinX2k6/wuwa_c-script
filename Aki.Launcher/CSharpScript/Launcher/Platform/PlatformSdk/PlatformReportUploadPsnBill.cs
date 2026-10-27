using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000169 RID: 361
	public class PlatformReportUploadPsnBill : PlatformSdkReportBaseData
	{
		// Token: 0x06000A6D RID: 2669 RVA: 0x00044F49 File Offset: 0x00043149
		public PlatformReportUploadPsnBill()
		{
			this.event_id = 60160;
			this.event_name = "upload_psnbill";
		}

		// Token: 0x0400064E RID: 1614
		[Nullable(1)]
		public string psn_scene = "";
	}
}
