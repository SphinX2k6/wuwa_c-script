using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200074D RID: 1869
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetGearGroupConfig_SetValue
	{
		// Token: 0x04001B2C RID: 6956
		public List<int> Entitys;

		// Token: 0x04001B2D RID: 6957
		public ITargetGearGroupSuccessContdion SuccessCondition;

		// Token: 0x04001B2E RID: 6958
		public List<ITargetGearGroupFailureCondition> FailureConditions;

		// Token: 0x04001B2F RID: 6959
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICheckGearHit> CheckGears;

		// Token: 0x04001B30 RID: 6960
		[Nullable(2)]
		public IGroupFinishConfig FinishConfig;
	}
}
