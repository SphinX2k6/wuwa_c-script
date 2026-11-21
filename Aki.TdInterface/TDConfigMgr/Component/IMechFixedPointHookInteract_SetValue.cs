using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000548 RID: 1352
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechFixedPointHookInteract_SetValue
	{
		// Token: 0x040013F8 RID: 5112
		public EMechHookInteractType Type;

		// Token: 0x040013F9 RID: 5113
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040013FA RID: 5114
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040013FB RID: 5115
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040013FC RID: 5116
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040013FD RID: 5117
		public IMechBehaviorConfig MechBehaviorConfig;
	}
}
