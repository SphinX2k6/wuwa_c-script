using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E47 RID: 7751
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetSubScreenData_SetValue
	{
		// Token: 0x04006323 RID: 25379
		public IScreenType TargetScreen;

		// Token: 0x04006324 RID: 25380
		public ISubScreenConfig TargetSubScreenConfig;

		// Token: 0x04006325 RID: 25381
		public ISubScreenTransition Transition;
	}
}
