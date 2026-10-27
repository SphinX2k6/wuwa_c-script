using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000647 RID: 1607
	public class IRagDollClimbingPoint_SetValue
	{
		// Token: 0x040017DE RID: 6110
		public EHookInteractType Type;

		// Token: 0x040017DF RID: 6111
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040017E0 RID: 6112
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040017E1 RID: 6113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040017E2 RID: 6114
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040017E3 RID: 6115
		public bool? IsSummitPoint;
	}
}
