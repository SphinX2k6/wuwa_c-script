using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007AB RID: 1963
	public class IStateChangeBehavior_SetValue
	{
		// Token: 0x04001C3E RID: 7230
		public string State;

		// Token: 0x04001C3F RID: 7231
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Action;

		// Token: 0x04001C40 RID: 7232
		[Nullable(2)]
		public IDelayChangeState DelayChangeState;

		// Token: 0x04001C41 RID: 7233
		public bool? PendingConditionAvailable;

		// Token: 0x04001C42 RID: 7234
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IConditionAction> ConditionAction;
	}
}
