using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DFC RID: 7676
	public class IMoraleAreaTip_SetValue
	{
		// Token: 0x040062D2 RID: 25298
		public ECommonTipType Type;

		// Token: 0x040062D3 RID: 25299
		public string TidAreaNameText;

		// Token: 0x040062D4 RID: 25300
		public string TidRecommendText;

		// Token: 0x040062D5 RID: 25301
		public EMoraleAreaType AreaType;

		// Token: 0x040062D6 RID: 25302
		public EMoraleUiType? UiType;

		// Token: 0x040062D7 RID: 25303
		[Nullable(2)]
		public string EdTidAreaNameText;

		// Token: 0x040062D8 RID: 25304
		[Nullable(2)]
		public string EdTidRecommendText;
	}
}
