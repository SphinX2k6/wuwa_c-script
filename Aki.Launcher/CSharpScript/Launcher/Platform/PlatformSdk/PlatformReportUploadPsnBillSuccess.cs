using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016E RID: 366
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportUploadPsnBillSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00047386 File Offset: 0x00045586
		public PlatformReportUploadPsnBillSuccess()
		{
			this.event_id = 60161;
			this.event_name = "upload_psnbill_succ";
		}

		// Token: 0x0400068A RID: 1674
		public string psn_scene = "";

		// Token: 0x0400068B RID: 1675
		public string psnenvlssuer = "";
	}
}
