using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000161 RID: 353
	public class PlatformReportGetGoodsList : PlatformSdkReportBaseData
	{
		// Token: 0x06000A65 RID: 2661 RVA: 0x00044DCA File Offset: 0x00042FCA
		public PlatformReportGetGoodsList()
		{
			this.event_id = 60150;
			this.event_name = "get_goodsidlist";
		}

		// Token: 0x0400063E RID: 1598
		[Nullable(1)]
		public string goodsid = "";

		// Token: 0x0400063F RID: 1599
		public int goodsid_count;
	}
}
