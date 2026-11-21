using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046C6 RID: 18118
	public interface IKurotatoShopSelectCardData
	{
		// Token: 0x17005BAA RID: 23466
		// (get) Token: 0x0602D8B6 RID: 186550
		// (set) Token: 0x0602D8B7 RID: 186551
		int Id { get; set; }

		// Token: 0x17005BAB RID: 23467
		// (get) Token: 0x0602D8B8 RID: 186552
		// (set) Token: 0x0602D8B9 RID: 186553
		int SelectionId { get; set; }

		// Token: 0x17005BAC RID: 23468
		// (get) Token: 0x0602D8BA RID: 186554
		// (set) Token: 0x0602D8BB RID: 186555
		EKurotatoCardType CardType { get; set; }

		// Token: 0x17005BAD RID: 23469
		// (get) Token: 0x0602D8BC RID: 186556
		// (set) Token: 0x0602D8BD RID: 186557
		int OriginalCost { get; set; }

		// Token: 0x17005BAE RID: 23470
		// (get) Token: 0x0602D8BE RID: 186558
		// (set) Token: 0x0602D8BF RID: 186559
		int Cost { get; set; }

		// Token: 0x17005BAF RID: 23471
		// (get) Token: 0x0602D8C0 RID: 186560
		// (set) Token: 0x0602D8C1 RID: 186561
		bool IsLock { get; set; }

		// Token: 0x17005BB0 RID: 23472
		// (get) Token: 0x0602D8C2 RID: 186562
		// (set) Token: 0x0602D8C3 RID: 186563
		bool HasBuy { get; set; }

		// Token: 0x17005BB1 RID: 23473
		// (get) Token: 0x0602D8C4 RID: 186564
		// (set) Token: 0x0602D8C5 RID: 186565
		bool IsRecommend { get; set; }
	}
}
