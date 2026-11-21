using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046C0 RID: 18112
	public interface IKurotatoCardItemData
	{
		// Token: 0x17005B90 RID: 23440
		// (get) Token: 0x0602D87F RID: 186495
		// (set) Token: 0x0602D880 RID: 186496
		int Id { get; set; }

		// Token: 0x17005B91 RID: 23441
		// (get) Token: 0x0602D881 RID: 186497
		// (set) Token: 0x0602D882 RID: 186498
		int SelectionId { get; set; }

		// Token: 0x17005B92 RID: 23442
		// (get) Token: 0x0602D883 RID: 186499
		// (set) Token: 0x0602D884 RID: 186500
		int Cost { get; set; }

		// Token: 0x17005B93 RID: 23443
		// (get) Token: 0x0602D885 RID: 186501
		// (set) Token: 0x0602D886 RID: 186502
		EKurotatoCardType CardType { get; set; }

		// Token: 0x17005B94 RID: 23444
		// (get) Token: 0x0602D887 RID: 186503
		// (set) Token: 0x0602D888 RID: 186504
		bool HasBuy { get; set; }

		// Token: 0x17005B95 RID: 23445
		// (get) Token: 0x0602D889 RID: 186505
		// (set) Token: 0x0602D88A RID: 186506
		bool IsRecommend { get; set; }

		// Token: 0x17005B96 RID: 23446
		// (get) Token: 0x0602D88B RID: 186507
		// (set) Token: 0x0602D88C RID: 186508
		bool HasLock { get; set; }

		// Token: 0x17005B97 RID: 23447
		// (get) Token: 0x0602D88D RID: 186509
		// (set) Token: 0x0602D88E RID: 186510
		bool ShowLock { get; set; }
	}
}
