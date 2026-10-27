using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000371 RID: 881
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureStateTrigger_SetValue
	{
		// Token: 0x04000E5D RID: 3677
		public List<IEntityGroupFailureCondition> FailureConditions;

		// Token: 0x04000E5E RID: 3678
		public IOperationsAfterEntityGroupFailure FailureOperations;
	}
}
