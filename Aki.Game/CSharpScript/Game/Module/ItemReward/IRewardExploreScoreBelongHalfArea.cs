using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057CC RID: 22476
	[NullableContext(1)]
	public interface IRewardExploreScoreBelongHalfArea
	{
		// Token: 0x170089A6 RID: 35238
		// (get) Token: 0x06039256 RID: 234070
		// (set) Token: 0x06039257 RID: 234071
		List<IRewardExploreScoreBelongHalfAreaItem> ItemList { get; set; }

		// Token: 0x170089A7 RID: 35239
		// (get) Token: 0x06039258 RID: 234072
		// (set) Token: 0x06039259 RID: 234073
		int FullScore { get; set; }

		// Token: 0x170089A8 RID: 35240
		// (get) Token: 0x0603925A RID: 234074
		// (set) Token: 0x0603925B RID: 234075
		bool IfNewRecord { get; set; }
	}
}
