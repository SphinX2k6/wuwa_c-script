using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE8 RID: 19176
	public interface IRewardData
	{
		// Token: 0x1700604F RID: 24655
		// (get) Token: 0x0602FF7E RID: 196478
		// (set) Token: 0x0602FF7F RID: 196479
		int RewardId { get; set; }

		// Token: 0x17006050 RID: 24656
		// (get) Token: 0x0602FF80 RID: 196480
		// (set) Token: 0x0602FF81 RID: 196481
		int Count { get; set; }

		// Token: 0x17006051 RID: 24657
		// (get) Token: 0x0602FF82 RID: 196482
		// (set) Token: 0x0602FF83 RID: 196483
		bool IsGet { get; set; }
	}
}
