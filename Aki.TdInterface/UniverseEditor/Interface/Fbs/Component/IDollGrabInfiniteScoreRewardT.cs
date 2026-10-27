using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200509A RID: 20634
	public class IDollGrabInfiniteScoreRewardT
	{
		// Token: 0x170095E5 RID: 38373
		// (get) Token: 0x0602121F RID: 135711 RVA: 0x0049AA38 File Offset: 0x00498C38
		// (set) Token: 0x06021220 RID: 135712 RVA: 0x0049AA40 File Offset: 0x00498C40
		public int TargetScore { get; set; }

		// Token: 0x170095E6 RID: 38374
		// (get) Token: 0x06021221 RID: 135713 RVA: 0x0049AA49 File Offset: 0x00498C49
		// (set) Token: 0x06021222 RID: 135714 RVA: 0x0049AA51 File Offset: 0x00498C51
		public int RewardId { get; set; }

		// Token: 0x06021223 RID: 135715 RVA: 0x0049AA5A File Offset: 0x00498C5A
		public IDollGrabInfiniteScoreRewardT()
		{
			this.TargetScore = 0;
			this.RewardId = 0;
		}
	}
}
