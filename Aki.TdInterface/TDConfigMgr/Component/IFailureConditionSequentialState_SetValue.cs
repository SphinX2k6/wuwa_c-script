using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036F RID: 879
	public class IFailureConditionSequentialState_SetValue
	{
		// Token: 0x04000E57 RID: 3671
		public ETargetGearGroupFailureCondition Type;

		// Token: 0x04000E58 RID: 3672
		[Nullable(1)]
		public List<int> Order;
	}
}
