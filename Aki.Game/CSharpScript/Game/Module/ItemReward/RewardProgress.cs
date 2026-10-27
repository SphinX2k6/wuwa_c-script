using System;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C5 RID: 22469
	public class RewardProgress : IRewardProgress
	{
		// Token: 0x17008997 RID: 35223
		// (get) Token: 0x06039234 RID: 234036 RVA: 0x00D90026 File Offset: 0x00D8E226
		// (set) Token: 0x06039235 RID: 234037 RVA: 0x00D9002E File Offset: 0x00D8E22E
		public int FromProgress { get; set; }

		// Token: 0x17008998 RID: 35224
		// (get) Token: 0x06039236 RID: 234038 RVA: 0x00D90037 File Offset: 0x00D8E237
		// (set) Token: 0x06039237 RID: 234039 RVA: 0x00D9003F File Offset: 0x00D8E23F
		public int ToProgress { get; set; }

		// Token: 0x17008999 RID: 35225
		// (get) Token: 0x06039238 RID: 234040 RVA: 0x00D90048 File Offset: 0x00D8E248
		// (set) Token: 0x06039239 RID: 234041 RVA: 0x00D90050 File Offset: 0x00D8E250
		public int MaxProgress { get; set; }
	}
}
