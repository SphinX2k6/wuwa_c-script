using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200052F RID: 1327
	public class IMotorPullInteract_SetValue
	{
		// Token: 0x0400137A RID: 4986
		public EHookInteractType Type;

		// Token: 0x0400137B RID: 4987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x0400137C RID: 4988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x0400137D RID: 4989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x0400137E RID: 4990
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x0400137F RID: 4991
		public bool? IsPlayPullProgress;

		// Token: 0x04001380 RID: 4992
		public float? PullMoveSpeed;

		// Token: 0x04001381 RID: 4993
		public bool? IsFixedWhenNotRide;

		// Token: 0x04001382 RID: 4994
		public bool? DisableAreaEffect;

		// Token: 0x04001383 RID: 4995
		public bool? DisableCollectEffect;
	}
}
