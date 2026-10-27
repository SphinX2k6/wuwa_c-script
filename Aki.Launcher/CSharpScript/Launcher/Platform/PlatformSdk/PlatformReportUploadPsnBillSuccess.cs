using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016A RID: 362
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportUploadPsnBillSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x00044F72 File Offset: 0x00043172
		public PlatformReportUploadPsnBillSuccess()
		{
			this.event_id = 60161;
			this.event_name = "upload_psnbill_succ";
		}

		// Token: 0x0400064F RID: 1615
		public string psn_scene = "";

		// Token: 0x04000650 RID: 1616
		public string psnenvlssuer = "";
	}
}
