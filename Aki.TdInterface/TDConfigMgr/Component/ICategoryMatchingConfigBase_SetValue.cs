using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000222 RID: 546
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingConfigBase_SetValue
	{
		// Token: 0x040009C3 RID: 2499
		public ICategoryMatchingCondition Condition;

		// Token: 0x040009C4 RID: 2500
		public ICategoryMatchingAnimationBase Animation;

		// Token: 0x040009C5 RID: 2501
		public ICategoryMatchingSucceedBase Callback;
	}
}
