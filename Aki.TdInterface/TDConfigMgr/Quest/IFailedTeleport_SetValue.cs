using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001090 RID: 4240
	public class IFailedTeleport_SetValue
	{
		// Token: 0x04003825 RID: 14373
		public PosA Position;

		// Token: 0x04003826 RID: 14374
		public int? PositionEntityId;

		// Token: 0x04003827 RID: 14375
		public bool IsConfirm;

		// Token: 0x04003828 RID: 14376
		public int ConfirmId;

		// Token: 0x04003829 RID: 14377
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;

		// Token: 0x0400382A RID: 14378
		public bool? GravityFlip;
	}
}
