using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002054 RID: 8276
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSettlementTip_SetValue
	{
		// Token: 0x04006D58 RID: 27992
		public ECommonTipType Type;

		// Token: 0x04006D59 RID: 27993
		public string TidMainText;

		// Token: 0x04006D5A RID: 27994
		public string TidSubText;

		// Token: 0x04006D5B RID: 27995
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04006D5C RID: 27996
		[Nullable(2)]
		public string EdTidSubText;
	}
}
