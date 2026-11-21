using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000247 RID: 583
	public class ICategoryMatchingConfig_SetValue
	{
		// Token: 0x04000A41 RID: 2625
		public ICategoryMatchingCondition Condition;

		// Token: 0x04000A42 RID: 2626
		public ICategoryMatchingAnimation Animation;

		// Token: 0x04000A43 RID: 2627
		public ICategoryMatchingSucceed Callback;

		// Token: 0x04000A44 RID: 2628
		[Nullable(2)]
		public IItemLockingConfig ItemLockingConfig;
	}
}
