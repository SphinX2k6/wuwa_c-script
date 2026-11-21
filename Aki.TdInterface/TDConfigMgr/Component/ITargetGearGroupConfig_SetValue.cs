using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007EE RID: 2030
	public class ITargetGearGroupConfig_SetValue
	{
		// Token: 0x04001D31 RID: 7473
		public List<int> Entitys;

		// Token: 0x04001D32 RID: 7474
		public ITargetGearGroupSuccessContdion SuccessCondition;

		// Token: 0x04001D33 RID: 7475
		public List<ITargetGearGroupFailureCondition> FailureConditions;

		// Token: 0x04001D34 RID: 7476
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ICheckGearHit> CheckGears;

		// Token: 0x04001D35 RID: 7477
		[Nullable(2)]
		public IGroupFinishConfig FinishConfig;
	}
}
