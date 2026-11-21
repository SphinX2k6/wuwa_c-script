using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E4 RID: 1764
	public class IRagDollClimbingPoint_SetValue
	{
		// Token: 0x040019D0 RID: 6608
		public EHookInteractType Type;

		// Token: 0x040019D1 RID: 6609
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040019D2 RID: 6610
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040019D3 RID: 6611
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040019D4 RID: 6612
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040019D5 RID: 6613
		public bool? IsSummitPoint;
	}
}
