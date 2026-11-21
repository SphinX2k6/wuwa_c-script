using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000550 RID: 1360
	public class IMechPullHookInteract_SetValue
	{
		// Token: 0x04001426 RID: 5158
		public EMechHookInteractType Type;

		// Token: 0x04001427 RID: 5159
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001428 RID: 5160
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001429 RID: 5161
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x0400142A RID: 5162
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x0400142B RID: 5163
		public bool? IsPlayPullProgress;

		// Token: 0x0400142C RID: 5164
		public float? PullMoveSpeed;

		// Token: 0x0400142D RID: 5165
		public bool? IsFixedWhenNotMech;

		// Token: 0x0400142E RID: 5166
		public bool? DisableAreaEffect;

		// Token: 0x0400142F RID: 5167
		public bool? DisableCollectEffect;
	}
}
