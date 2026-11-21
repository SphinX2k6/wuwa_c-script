using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004796 RID: 18326
	public class ExploreLevelRewardInfo : RewardInfo, IExploreLevelRewardInfo, IRewardInfo
	{
		// Token: 0x17005D48 RID: 23880
		// (get) Token: 0x0602E113 RID: 188691 RVA: 0x00CDED8B File Offset: 0x00CDCF8B
		// (set) Token: 0x0602E114 RID: 188692 RVA: 0x00CDED93 File Offset: 0x00CDCF93
		public int CurrentExploreLevel { get; set; }

		// Token: 0x17005D49 RID: 23881
		// (get) Token: 0x0602E115 RID: 188693 RVA: 0x00CDED9C File Offset: 0x00CDCF9C
		// (set) Token: 0x0602E116 RID: 188694 RVA: 0x00CDEDA4 File Offset: 0x00CDCFA4
		public int TargetExploreLevel { get; set; }
	}
}
