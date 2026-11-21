using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A4 RID: 18340
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScoreBelongHalfArea : IRewardExploreScoreBelongHalfArea
	{
		// Token: 0x17005D73 RID: 23923
		// (get) Token: 0x0602E170 RID: 188784 RVA: 0x00CDEF28 File Offset: 0x00CDD128
		// (set) Token: 0x0602E171 RID: 188785 RVA: 0x00CDEF30 File Offset: 0x00CDD130
		public List<IRewardExploreScoreBelongHalfAreaItem> ItemList { get; set; }

		// Token: 0x17005D74 RID: 23924
		// (get) Token: 0x0602E172 RID: 188786 RVA: 0x00CDEF39 File Offset: 0x00CDD139
		// (set) Token: 0x0602E173 RID: 188787 RVA: 0x00CDEF41 File Offset: 0x00CDD141
		public int FullScore { get; set; }

		// Token: 0x17005D75 RID: 23925
		// (get) Token: 0x0602E174 RID: 188788 RVA: 0x00CDEF4A File Offset: 0x00CDD14A
		// (set) Token: 0x0602E175 RID: 188789 RVA: 0x00CDEF52 File Offset: 0x00CDD152
		public bool IfNewRecord { get; set; }
	}
}
