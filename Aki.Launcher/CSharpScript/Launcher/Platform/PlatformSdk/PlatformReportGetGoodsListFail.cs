using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000167 RID: 359
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportGetGoodsListFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A9B RID: 2715 RVA: 0x00047230 File Offset: 0x00045430
		public PlatformReportGetGoodsListFail()
		{
			this.event_id = 60152;
			this.event_name = "get_goodsidlist_fail";
		}

		// Token: 0x0400067D RID: 1661
		public string code = "";

		// Token: 0x0400067E RID: 1662
		public string msg = "";
	}
}
