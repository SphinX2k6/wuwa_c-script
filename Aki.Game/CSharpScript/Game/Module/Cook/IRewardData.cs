using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B07 RID: 23303
	public interface IRewardData
	{
		// Token: 0x17008C75 RID: 35957
		// (get) Token: 0x0603B00C RID: 241676
		// (set) Token: 0x0603B00D RID: 241677
		int RewardId { get; set; }

		// Token: 0x17008C76 RID: 35958
		// (get) Token: 0x0603B00E RID: 241678
		// (set) Token: 0x0603B00F RID: 241679
		int Count { get; set; }

		// Token: 0x17008C77 RID: 35959
		// (get) Token: 0x0603B010 RID: 241680
		// (set) Token: 0x0603B011 RID: 241681
		bool IsGet { get; set; }
	}
}
