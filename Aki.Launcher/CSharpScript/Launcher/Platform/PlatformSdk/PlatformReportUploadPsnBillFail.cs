using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016B RID: 363
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportUploadPsnBillFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x00044FA8 File Offset: 0x000431A8
		public PlatformReportUploadPsnBillFail()
		{
			this.event_id = 60162;
			this.event_name = "upload_psnbill_fail";
		}

		// Token: 0x04000651 RID: 1617
		public string psn_scene = "";

		// Token: 0x04000652 RID: 1618
		public string psnenvlssuer = "";

		// Token: 0x04000653 RID: 1619
		public string code = "";

		// Token: 0x04000654 RID: 1620
		public string msg = "";
	}
}
