using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057BF RID: 22463
	public class ExploreLevelRewardInfo : RewardInfo, IExploreLevelRewardInfo, IRewardInfo
	{
		// Token: 0x17008980 RID: 35200
		// (get) Token: 0x06039203 RID: 233987 RVA: 0x00D8FF53 File Offset: 0x00D8E153
		// (set) Token: 0x06039204 RID: 233988 RVA: 0x00D8FF5B File Offset: 0x00D8E15B
		public int CurrentExploreLevel { get; set; }

		// Token: 0x17008981 RID: 35201
		// (get) Token: 0x06039205 RID: 233989 RVA: 0x00D8FF64 File Offset: 0x00D8E164
		// (set) Token: 0x06039206 RID: 233990 RVA: 0x00D8FF6C File Offset: 0x00D8E16C
		public int TargetExploreLevel { get; set; }
	}
}
