using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016B RID: 363
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportOpenPsnCheckOut : PlatformSdkReportBaseData
	{
		// Token: 0x06000A9F RID: 2719 RVA: 0x000472DF File Offset: 0x000454DF
		public PlatformReportOpenPsnCheckOut()
		{
			this.event_id = 60156;
			this.event_name = "open_psncheckout";
		}

		// Token: 0x04000683 RID: 1667
		public string product_id = "";

		// Token: 0x04000684 RID: 1668
		public string goodsId = "";

		// Token: 0x04000685 RID: 1669
		public string psnenvlssuer = "";
	}
}
