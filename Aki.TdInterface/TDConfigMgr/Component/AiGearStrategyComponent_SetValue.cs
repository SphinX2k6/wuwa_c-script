using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200001C RID: 28
	public class AiGearStrategyComponent_SetValue
	{
		// Token: 0x04000060 RID: 96
		public bool? Disabled;

		// Token: 0x04000061 RID: 97
		public bool? EdIsLocked;

		// Token: 0x04000062 RID: 98
		[Nullable(1)]
		public IAiGearStrategy StrategyType;
	}
}
