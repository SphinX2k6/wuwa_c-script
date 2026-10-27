using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C3 RID: 4547
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackReturnDungeon_SetValue
	{
		// Token: 0x04003E0D RID: 15885
		public int DungeonId;

		// Token: 0x04003E0E RID: 15886
		public bool? IsRegroup;

		// Token: 0x04003E0F RID: 15887
		public ITeleportTransitionType TransitionOption;

		// Token: 0x04003E10 RID: 15888
		public string TidTip;

		// Token: 0x04003E11 RID: 15889
		public string EdTidTip;
	}
}
