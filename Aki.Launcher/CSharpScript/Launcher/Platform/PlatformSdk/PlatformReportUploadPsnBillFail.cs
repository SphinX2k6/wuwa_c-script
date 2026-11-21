using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016F RID: 367
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportUploadPsnBillFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000AA3 RID: 2723 RVA: 0x000473BC File Offset: 0x000455BC
		public PlatformReportUploadPsnBillFail()
		{
			this.event_id = 60162;
			this.event_name = "upload_psnbill_fail";
		}

		// Token: 0x0400068C RID: 1676
		public string psn_scene = "";

		// Token: 0x0400068D RID: 1677
		public string psnenvlssuer = "";

		// Token: 0x0400068E RID: 1678
		public string code = "";

		// Token: 0x0400068F RID: 1679
		public string msg = "";
	}
}
