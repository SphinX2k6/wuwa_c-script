using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016D RID: 365
	public class PlatformReportUploadPsnBill : PlatformSdkReportBaseData
	{
		// Token: 0x06000AA1 RID: 2721 RVA: 0x0004735D File Offset: 0x0004555D
		public PlatformReportUploadPsnBill()
		{
			this.event_id = 60160;
			this.event_name = "upload_psnbill";
		}

		// Token: 0x04000689 RID: 1673
		[Nullable(1)]
		public string psn_scene = "";
	}
}
