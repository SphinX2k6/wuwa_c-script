using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057CE RID: 22478
	[NullableContext(1)]
	public interface IRewardExploreScoreBelongHalfAreaItem
	{
		// Token: 0x170089AC RID: 35244
		// (get) Token: 0x06039263 RID: 234083
		// (set) Token: 0x06039264 RID: 234084
		string Target { get; set; }

		// Token: 0x170089AD RID: 35245
		// (get) Token: 0x06039265 RID: 234085
		// (set) Token: 0x06039266 RID: 234086
		string DescriptionTextId { get; set; }

		// Token: 0x170089AE RID: 35246
		// (get) Token: 0x06039267 RID: 234087
		// (set) Token: 0x06039268 RID: 234088
		ETeamBelong Belong { get; set; }
	}
}
