using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200192D RID: 6445
	[NullableContext(1)]
	[Nullable(0)]
	public class IConditions_SetValue
	{
		// Token: 0x0400566E RID: 22126
		public string LogicOpType;

		// Token: 0x0400566F RID: 22127
		public List<ICondition> Conditions;
	}
}
