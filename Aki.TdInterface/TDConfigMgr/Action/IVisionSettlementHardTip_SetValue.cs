using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002052 RID: 8274
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSettlementHardTip_SetValue
	{
		// Token: 0x04006D51 RID: 27985
		public ECommonTipType Type;

		// Token: 0x04006D52 RID: 27986
		public string TidMainText;

		// Token: 0x04006D53 RID: 27987
		public string TidSubText;

		// Token: 0x04006D54 RID: 27988
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04006D55 RID: 27989
		[Nullable(2)]
		public string EdTidSubText;
	}
}
