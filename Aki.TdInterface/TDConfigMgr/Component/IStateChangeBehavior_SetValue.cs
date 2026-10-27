using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070A RID: 1802
	public class IStateChangeBehavior_SetValue
	{
		// Token: 0x04001A3F RID: 6719
		[Nullable(1)]
		public string State;

		// Token: 0x04001A40 RID: 6720
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Action;

		// Token: 0x04001A41 RID: 6721
		[Nullable(2)]
		public IDelayChangeState DelayChangeState;

		// Token: 0x04001A42 RID: 6722
		public bool? PendingConditionAvailable;

		// Token: 0x04001A43 RID: 6723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IConditionAction> ConditionAction;
	}
}
