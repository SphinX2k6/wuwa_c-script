using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000596 RID: 1430
	public class IMotorPullInteract_SetValue
	{
		// Token: 0x040014E4 RID: 5348
		public EHookInteractType Type;

		// Token: 0x040014E5 RID: 5349
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040014E6 RID: 5350
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040014E7 RID: 5351
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040014E8 RID: 5352
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040014E9 RID: 5353
		public bool? IsPlayPullProgress;

		// Token: 0x040014EA RID: 5354
		public float? PullMoveSpeed;

		// Token: 0x040014EB RID: 5355
		public bool? IsFixedWhenNotRide;

		// Token: 0x040014EC RID: 5356
		public bool? DisableAreaEffect;

		// Token: 0x040014ED RID: 5357
		public bool? DisableCollectEffect;
	}
}
