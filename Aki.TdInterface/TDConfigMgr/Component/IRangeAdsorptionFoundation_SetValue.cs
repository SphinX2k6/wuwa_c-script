using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F8 RID: 1784
	public class IRangeAdsorptionFoundation_SetValue
	{
		// Token: 0x04001A20 RID: 6688
		public EItemFoundation Type;

		// Token: 0x04001A21 RID: 6689
		public ICategoryMatchingCondition Condition;

		// Token: 0x04001A22 RID: 6690
		public IAdsorptionMatchingAnimation Animation;

		// Token: 0x04001A23 RID: 6691
		[Nullable(2)]
		public ICategoryMatchingAnimation CategoryAnimation;

		// Token: 0x04001A24 RID: 6692
		[Nullable(2)]
		public ICategoryMatchingSucceed Callback;
	}
}
