using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229D RID: 8861
	public class IVisionSettlementTip_SetValue
	{
		// Token: 0x04007361 RID: 29537
		public ECommonTipType Type;

		// Token: 0x04007362 RID: 29538
		public string TidMainText;

		// Token: 0x04007363 RID: 29539
		public string TidSubText;

		// Token: 0x04007364 RID: 29540
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04007365 RID: 29541
		[Nullable(2)]
		public string EdTidSubText;
	}
}
