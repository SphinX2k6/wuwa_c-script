using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002233 RID: 8755
	public class TeleportDungeon_SetValue
	{
		// Token: 0x0400728E RID: 29326
		public int DungeonId;

		// Token: 0x0400728F RID: 29327
		public bool IsRegroup;

		// Token: 0x04007290 RID: 29328
		public int? LocationEntityId;

		// Token: 0x04007291 RID: 29329
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;

		// Token: 0x04007292 RID: 29330
		public bool? IsNeedSecondaryConfirmation;

		// Token: 0x04007293 RID: 29331
		public bool? UseLocationEntityGravity;

		// Token: 0x04007294 RID: 29332
		public bool? ContinueSave;

		// Token: 0x04007295 RID: 29333
		public bool? IsBanMapSound;
	}
}
