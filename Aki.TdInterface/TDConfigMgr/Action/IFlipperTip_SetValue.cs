using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C0B RID: 7179
	public class IFlipperTip_SetValue
	{
		// Token: 0x04005DE5 RID: 24037
		public ECommonTipType Type;

		// Token: 0x04005DE6 RID: 24038
		public string TidMainText;

		// Token: 0x04005DE7 RID: 24039
		public string TidSubText;

		// Token: 0x04005DE8 RID: 24040
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04005DE9 RID: 24041
		[Nullable(2)]
		public string EdTidSubText;
	}
}
