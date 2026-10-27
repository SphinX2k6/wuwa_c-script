using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckDetail
{
	// Token: 0x0200517F RID: 20863
	[NullableContext(1)]
	public interface IPhantomArenaDeckDetailViewData
	{
		// Token: 0x17008123 RID: 33059
		// (get) Token: 0x060355B4 RID: 218548
		// (set) Token: 0x060355B5 RID: 218549
		DeckInfo DeckInfo { get; set; }

		// Token: 0x17008124 RID: 33060
		// (get) Token: 0x060355B6 RID: 218550
		// (set) Token: 0x060355B7 RID: 218551
		bool ShowLocked { get; set; }

		// Token: 0x17008125 RID: 33061
		// (get) Token: 0x060355B8 RID: 218552
		// (set) Token: 0x060355B9 RID: 218553
		int ActivityId { get; set; }

		// Token: 0x17008126 RID: 33062
		// (get) Token: 0x060355BA RID: 218554
		// (set) Token: 0x060355BB RID: 218555
		int? CurrencyId { get; set; }

		// Token: 0x17008127 RID: 33063
		// (get) Token: 0x060355BC RID: 218556
		// (set) Token: 0x060355BD RID: 218557
		int? CurCardId { get; set; }

		// Token: 0x17008128 RID: 33064
		// (get) Token: 0x060355BE RID: 218558
		// (set) Token: 0x060355BF RID: 218559
		DetailViewCardItemData CardItemData { get; set; }

		// Token: 0x17008129 RID: 33065
		// (get) Token: 0x060355C0 RID: 218560
		// (set) Token: 0x060355C1 RID: 218561
		CardDetailItemData DetailItemData { get; set; }

		// Token: 0x1700812A RID: 33066
		// (get) Token: 0x060355C2 RID: 218562
		// (set) Token: 0x060355C3 RID: 218563
		List<int> EntryList { get; set; }

		// Token: 0x1700812B RID: 33067
		// (get) Token: 0x060355C4 RID: 218564
		// (set) Token: 0x060355C5 RID: 218565
		bool? IsUnlock { get; set; }

		// Token: 0x1700812C RID: 33068
		// (get) Token: 0x060355C6 RID: 218566
		// (set) Token: 0x060355C7 RID: 218567
		bool? IsRecommend { get; set; }

		// Token: 0x1700812D RID: 33069
		// (get) Token: 0x060355C8 RID: 218568
		// (set) Token: 0x060355C9 RID: 218569
		Action<DeckInfo> SaveRecommendDeckCallback { get; set; }
	}
}
