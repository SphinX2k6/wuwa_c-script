using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016C RID: 364
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportClosePsnCheckOut : PlatformSdkReportBaseData
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x0004731E File Offset: 0x0004551E
		public PlatformReportClosePsnCheckOut()
		{
			this.event_id = 60157;
			this.event_name = "close_psncheckout";
		}

		// Token: 0x04000686 RID: 1670
		public string product_id = "";

		// Token: 0x04000687 RID: 1671
		public string goodsId = "";

		// Token: 0x04000688 RID: 1672
		public string psnenvlssuer = "";
	}
}
