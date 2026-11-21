using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A5 RID: 18341
	[NullableContext(1)]
	public interface IRewardExploreScoreBelongHalfAreaItem
	{
		// Token: 0x17005D76 RID: 23926
		// (get) Token: 0x0602E177 RID: 188791
		// (set) Token: 0x0602E178 RID: 188792
		string Target { get; set; }

		// Token: 0x17005D77 RID: 23927
		// (get) Token: 0x0602E179 RID: 188793
		// (set) Token: 0x0602E17A RID: 188794
		string DescriptionTextId { get; set; }

		// Token: 0x17005D78 RID: 23928
		// (get) Token: 0x0602E17B RID: 188795
		// (set) Token: 0x0602E17C RID: 188796
		ETeamBelong Belong { get; set; }
	}
}
