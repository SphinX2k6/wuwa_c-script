using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249E RID: 9374
	public class TeleportDungeon_SetValue
	{
		// Token: 0x040078D8 RID: 30936
		public int DungeonId;

		// Token: 0x040078D9 RID: 30937
		public bool IsRegroup;

		// Token: 0x040078DA RID: 30938
		public int? LocationEntityId;

		// Token: 0x040078DB RID: 30939
		[Nullable(2)]
		public ITeleportTransitionType TransitionOption;

		// Token: 0x040078DC RID: 30940
		public bool? IsNeedSecondaryConfirmation;

		// Token: 0x040078DD RID: 30941
		public bool? UseLocationEntityGravity;

		// Token: 0x040078DE RID: 30942
		public bool? ContinueSave;

		// Token: 0x040078DF RID: 30943
		public bool? IsBanMapSound;
	}
}
