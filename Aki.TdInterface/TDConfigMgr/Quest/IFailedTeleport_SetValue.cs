using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F66 RID: 3942
	public class IFailedTeleport_SetValue
	{
		// Token: 0x040034F4 RID: 13556
		[Nullable(1)]
		public PosA Position;

		// Token: 0x040034F5 RID: 13557
		public int? PositionEntityId;

		// Token: 0x040034F6 RID: 13558
		public bool IsConfirm;

		// Token: 0x040034F7 RID: 13559
		public int ConfirmId;

		// Token: 0x040034F8 RID: 13560
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;

		// Token: 0x040034F9 RID: 13561
		public bool? GravityFlip;
	}
}
