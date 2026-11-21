using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012FF RID: 4863
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackReturnDungeon_SetValue
	{
		// Token: 0x0400417B RID: 16763
		public int DungeonId;

		// Token: 0x0400417C RID: 16764
		public bool? IsRegroup;

		// Token: 0x0400417D RID: 16765
		public ITeleportTransitionType TransitionOption;

		// Token: 0x0400417E RID: 16766
		public string TidTip;

		// Token: 0x0400417F RID: 16767
		public string EdTidTip;
	}
}
