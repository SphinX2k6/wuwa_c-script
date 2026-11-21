using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004797 RID: 18327
	public interface ITowerDefenceRewardInfo : IRewardInfo
	{
		// Token: 0x17005D4A RID: 23882
		// (get) Token: 0x0602E118 RID: 188696
		// (set) Token: 0x0602E119 RID: 188697
		bool IsSuccess { get; set; }

		// Token: 0x17005D4B RID: 23883
		// (get) Token: 0x0602E11A RID: 188698
		// (set) Token: 0x0602E11B RID: 188699
		int Score { get; set; }

		// Token: 0x17005D4C RID: 23884
		// (get) Token: 0x0602E11C RID: 188700
		// (set) Token: 0x0602E11D RID: 188701
		int RecordScore { get; set; }
	}
}
