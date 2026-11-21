using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FF RID: 22015
	public class IDollGrabInfiniteScoreRewardT
	{
		// Token: 0x17009DD2 RID: 40402
		// (get) Token: 0x06023173 RID: 143731 RVA: 0x004D49C4 File Offset: 0x004D2BC4
		// (set) Token: 0x06023174 RID: 143732 RVA: 0x004D49CC File Offset: 0x004D2BCC
		public int TargetScore { get; set; }

		// Token: 0x17009DD3 RID: 40403
		// (get) Token: 0x06023175 RID: 143733 RVA: 0x004D49D5 File Offset: 0x004D2BD5
		// (set) Token: 0x06023176 RID: 143734 RVA: 0x004D49DD File Offset: 0x004D2BDD
		public int RewardId { get; set; }

		// Token: 0x06023177 RID: 143735 RVA: 0x004D49E6 File Offset: 0x004D2BE6
		public IDollGrabInfiniteScoreRewardT()
		{
			this.TargetScore = 0;
			this.RewardId = 0;
		}
	}
}
