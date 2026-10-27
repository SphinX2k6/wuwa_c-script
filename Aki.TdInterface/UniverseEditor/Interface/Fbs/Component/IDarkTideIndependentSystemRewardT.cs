using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005076 RID: 20598
	public class IDarkTideIndependentSystemRewardT
	{
		// Token: 0x17009571 RID: 38257
		// (get) Token: 0x06021055 RID: 135253 RVA: 0x004965D7 File Offset: 0x004947D7
		// (set) Token: 0x06021056 RID: 135254 RVA: 0x004965DF File Offset: 0x004947DF
		public EIndependentSystemRewardType Type { get; set; }

		// Token: 0x17009572 RID: 38258
		// (get) Token: 0x06021057 RID: 135255 RVA: 0x004965E8 File Offset: 0x004947E8
		// (set) Token: 0x06021058 RID: 135256 RVA: 0x004965F0 File Offset: 0x004947F0
		public int RewardId { get; set; }

		// Token: 0x17009573 RID: 38259
		// (get) Token: 0x06021059 RID: 135257 RVA: 0x004965F9 File Offset: 0x004947F9
		// (set) Token: 0x0602105A RID: 135258 RVA: 0x00496601 File Offset: 0x00494801
		public List<int> RewardIdList { get; set; }

		// Token: 0x17009574 RID: 38260
		// (get) Token: 0x0602105B RID: 135259 RVA: 0x0049660A File Offset: 0x0049480A
		// (set) Token: 0x0602105C RID: 135260 RVA: 0x00496612 File Offset: 0x00494812
		public byte NullMask { get; set; }

		// Token: 0x0602105D RID: 135261 RVA: 0x0049661B File Offset: 0x0049481B
		public IDarkTideIndependentSystemRewardT()
		{
			this.Type = EIndependentSystemRewardType.DarkTide;
			this.RewardId = 0;
			this.RewardIdList = null;
			this.NullMask = 0;
		}
	}
}
