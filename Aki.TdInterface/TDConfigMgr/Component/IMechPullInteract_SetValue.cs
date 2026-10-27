using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F1 RID: 1265
	public class IMechPullInteract_SetValue
	{
		// Token: 0x040012D5 RID: 4821
		public EHookInteractType Type;

		// Token: 0x040012D6 RID: 4822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040012D7 RID: 4823
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040012D8 RID: 4824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040012D9 RID: 4825
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040012DA RID: 4826
		public bool? IsPlayPullProgress;

		// Token: 0x040012DB RID: 4827
		public float? PullMoveSpeed;

		// Token: 0x040012DC RID: 4828
		public bool? IsFixedWhenNotMech;

		// Token: 0x040012DD RID: 4829
		public bool? DisableAreaEffect;

		// Token: 0x040012DE RID: 4830
		public bool? DisableCollectEffect;
	}
}
