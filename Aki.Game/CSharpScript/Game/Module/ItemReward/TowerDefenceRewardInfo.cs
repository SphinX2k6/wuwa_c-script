using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C1 RID: 22465
	public class TowerDefenceRewardInfo : RewardInfo, ITowerDefenceRewardInfo, IRewardInfo
	{
		// Token: 0x17008985 RID: 35205
		// (get) Token: 0x0603920E RID: 233998 RVA: 0x00D8FF7D File Offset: 0x00D8E17D
		// (set) Token: 0x0603920F RID: 233999 RVA: 0x00D8FF85 File Offset: 0x00D8E185
		public bool IsSuccess { get; set; }

		// Token: 0x17008986 RID: 35206
		// (get) Token: 0x06039210 RID: 234000 RVA: 0x00D8FF8E File Offset: 0x00D8E18E
		// (set) Token: 0x06039211 RID: 234001 RVA: 0x00D8FF96 File Offset: 0x00D8E196
		public int Score { get; set; }

		// Token: 0x17008987 RID: 35207
		// (get) Token: 0x06039212 RID: 234002 RVA: 0x00D8FF9F File Offset: 0x00D8E19F
		// (set) Token: 0x06039213 RID: 234003 RVA: 0x00D8FFA7 File Offset: 0x00D8E1A7
		public int RecordScore { get; set; }
	}
}
