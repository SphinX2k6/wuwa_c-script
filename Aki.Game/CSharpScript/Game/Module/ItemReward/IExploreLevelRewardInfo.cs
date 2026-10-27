using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057BE RID: 22462
	public interface IExploreLevelRewardInfo : IRewardInfo
	{
		// Token: 0x1700897E RID: 35198
		// (get) Token: 0x060391FF RID: 233983
		// (set) Token: 0x06039200 RID: 233984
		int CurrentExploreLevel { get; set; }

		// Token: 0x1700897F RID: 35199
		// (get) Token: 0x06039201 RID: 233985
		// (set) Token: 0x06039202 RID: 233986
		int TargetExploreLevel { get; set; }
	}
}
