using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000167 RID: 359
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportOpenPsnCheckOut : PlatformSdkReportBaseData
	{
		// Token: 0x06000A6B RID: 2667 RVA: 0x00044ECB File Offset: 0x000430CB
		public PlatformReportOpenPsnCheckOut()
		{
			this.event_id = 60156;
			this.event_name = "open_psncheckout";
		}

		// Token: 0x04000648 RID: 1608
		public string product_id = "";

		// Token: 0x04000649 RID: 1609
		public string goodsId = "";

		// Token: 0x0400064A RID: 1610
		public string psnenvlssuer = "";
	}
}
