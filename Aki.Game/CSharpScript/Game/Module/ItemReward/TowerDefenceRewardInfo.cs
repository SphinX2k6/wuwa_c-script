using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004798 RID: 18328
	public class TowerDefenceRewardInfo : RewardInfo, ITowerDefenceRewardInfo, IRewardInfo
	{
		// Token: 0x17005D4D RID: 23885
		// (get) Token: 0x0602E11E RID: 188702 RVA: 0x00CDEDB5 File Offset: 0x00CDCFB5
		// (set) Token: 0x0602E11F RID: 188703 RVA: 0x00CDEDBD File Offset: 0x00CDCFBD
		public bool IsSuccess { get; set; }

		// Token: 0x17005D4E RID: 23886
		// (get) Token: 0x0602E120 RID: 188704 RVA: 0x00CDEDC6 File Offset: 0x00CDCFC6
		// (set) Token: 0x0602E121 RID: 188705 RVA: 0x00CDEDCE File Offset: 0x00CDCFCE
		public int Score { get; set; }

		// Token: 0x17005D4F RID: 23887
		// (get) Token: 0x0602E122 RID: 188706 RVA: 0x00CDEDD7 File Offset: 0x00CDCFD7
		// (set) Token: 0x0602E123 RID: 188707 RVA: 0x00CDEDDF File Offset: 0x00CDCFDF
		public int RecordScore { get; set; }
	}
}
