using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004795 RID: 18325
	public interface IExploreLevelRewardInfo : IRewardInfo
	{
		// Token: 0x17005D46 RID: 23878
		// (get) Token: 0x0602E10F RID: 188687
		// (set) Token: 0x0602E110 RID: 188688
		int CurrentExploreLevel { get; set; }

		// Token: 0x17005D47 RID: 23879
		// (get) Token: 0x0602E111 RID: 188689
		// (set) Token: 0x0602E112 RID: 188690
		int TargetExploreLevel { get; set; }
	}
}
