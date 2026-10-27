using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200065B RID: 1627
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangeAdsorptionFoundation_SetValue
	{
		// Token: 0x0400182E RID: 6190
		public EItemFoundation Type;

		// Token: 0x0400182F RID: 6191
		public ICategoryMatchingCondition Condition;

		// Token: 0x04001830 RID: 6192
		public IAdsorptionMatchingAnimation Animation;

		// Token: 0x04001831 RID: 6193
		[Nullable(2)]
		public ICategoryMatchingAnimation CategoryAnimation;

		// Token: 0x04001832 RID: 6194
		[Nullable(2)]
		public ICategoryMatchingSucceed Callback;
	}
}
