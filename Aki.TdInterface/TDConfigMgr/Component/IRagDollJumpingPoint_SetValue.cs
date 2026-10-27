using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000649 RID: 1609
	public class IRagDollJumpingPoint_SetValue
	{
		// Token: 0x040017EE RID: 6126
		public EHookInteractType Type;

		// Token: 0x040017EF RID: 6127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040017F0 RID: 6128
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040017F1 RID: 6129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040017F2 RID: 6130
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;
	}
}
