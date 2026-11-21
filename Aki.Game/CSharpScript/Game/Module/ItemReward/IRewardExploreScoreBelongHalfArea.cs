using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A3 RID: 18339
	[NullableContext(1)]
	public interface IRewardExploreScoreBelongHalfArea
	{
		// Token: 0x17005D70 RID: 23920
		// (get) Token: 0x0602E16A RID: 188778
		// (set) Token: 0x0602E16B RID: 188779
		List<IRewardExploreScoreBelongHalfAreaItem> ItemList { get; set; }

		// Token: 0x17005D71 RID: 23921
		// (get) Token: 0x0602E16C RID: 188780
		// (set) Token: 0x0602E16D RID: 188781
		int FullScore { get; set; }

		// Token: 0x17005D72 RID: 23922
		// (get) Token: 0x0602E16E RID: 188782
		// (set) Token: 0x0602E16F RID: 188783
		bool IfNewRecord { get; set; }
	}
}
