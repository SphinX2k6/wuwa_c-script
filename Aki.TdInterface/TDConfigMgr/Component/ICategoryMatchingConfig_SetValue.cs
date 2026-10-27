using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000220 RID: 544
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingConfig_SetValue
	{
		// Token: 0x040009B7 RID: 2487
		public ICategoryMatchingCondition Condition;

		// Token: 0x040009B8 RID: 2488
		public ICategoryMatchingAnimation Animation;

		// Token: 0x040009B9 RID: 2489
		public ICategoryMatchingSucceed Callback;

		// Token: 0x040009BA RID: 2490
		[Nullable(2)]
		public IItemLockingConfig ItemLockingConfig;
	}
}
