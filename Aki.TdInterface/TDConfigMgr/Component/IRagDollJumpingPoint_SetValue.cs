using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E6 RID: 1766
	public class IRagDollJumpingPoint_SetValue
	{
		// Token: 0x040019E0 RID: 6624
		public EHookInteractType Type;

		// Token: 0x040019E1 RID: 6625
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040019E2 RID: 6626
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040019E3 RID: 6627
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040019E4 RID: 6628
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
