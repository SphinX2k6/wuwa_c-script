using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B08 RID: 23304
	public class RewardData : IRewardData
	{
		// Token: 0x17008C78 RID: 35960
		// (get) Token: 0x0603B012 RID: 241682 RVA: 0x00E11136 File Offset: 0x00E0F336
		// (set) Token: 0x0603B013 RID: 241683 RVA: 0x00E1113E File Offset: 0x00E0F33E
		public int RewardId { get; set; }

		// Token: 0x17008C79 RID: 35961
		// (get) Token: 0x0603B014 RID: 241684 RVA: 0x00E11147 File Offset: 0x00E0F347
		// (set) Token: 0x0603B015 RID: 241685 RVA: 0x00E1114F File Offset: 0x00E0F34F
		public int Count { get; set; }

		// Token: 0x17008C7A RID: 35962
		// (get) Token: 0x0603B016 RID: 241686 RVA: 0x00E11158 File Offset: 0x00E0F358
		// (set) Token: 0x0603B017 RID: 241687 RVA: 0x00E11160 File Offset: 0x00E0F360
		public bool IsGet { get; set; }
	}
}
