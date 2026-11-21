using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckDetail
{
	// Token: 0x0200414F RID: 16719
	[NullableContext(1)]
	public interface IPhantomArenaDeckDetailViewData
	{
		// Token: 0x170054E3 RID: 21731
		// (get) Token: 0x0602A4AF RID: 173231
		// (set) Token: 0x0602A4B0 RID: 173232
		DeckInfo DeckInfo { get; set; }

		// Token: 0x170054E4 RID: 21732
		// (get) Token: 0x0602A4B1 RID: 173233
		// (set) Token: 0x0602A4B2 RID: 173234
		bool ShowLocked { get; set; }

		// Token: 0x170054E5 RID: 21733
		// (get) Token: 0x0602A4B3 RID: 173235
		// (set) Token: 0x0602A4B4 RID: 173236
		int ActivityId { get; set; }

		// Token: 0x170054E6 RID: 21734
		// (get) Token: 0x0602A4B5 RID: 173237
		// (set) Token: 0x0602A4B6 RID: 173238
		int? CurrencyId { get; set; }

		// Token: 0x170054E7 RID: 21735
		// (get) Token: 0x0602A4B7 RID: 173239
		// (set) Token: 0x0602A4B8 RID: 173240
		int? CurCardId { get; set; }

		// Token: 0x170054E8 RID: 21736
		// (get) Token: 0x0602A4B9 RID: 173241
		// (set) Token: 0x0602A4BA RID: 173242
		DetailViewCardItemData CardItemData { get; set; }

		// Token: 0x170054E9 RID: 21737
		// (get) Token: 0x0602A4BB RID: 173243
		// (set) Token: 0x0602A4BC RID: 173244
		CardDetailItemData DetailItemData { get; set; }

		// Token: 0x170054EA RID: 21738
		// (get) Token: 0x0602A4BD RID: 173245
		// (set) Token: 0x0602A4BE RID: 173246
		List<int> EntryList { get; set; }

		// Token: 0x170054EB RID: 21739
		// (get) Token: 0x0602A4BF RID: 173247
		// (set) Token: 0x0602A4C0 RID: 173248
		bool? IsUnlock { get; set; }

		// Token: 0x170054EC RID: 21740
		// (get) Token: 0x0602A4C1 RID: 173249
		// (set) Token: 0x0602A4C2 RID: 173250
		bool? IsRecommend { get; set; }

		// Token: 0x170054ED RID: 21741
		// (get) Token: 0x0602A4C3 RID: 173251
		// (set) Token: 0x0602A4C4 RID: 173252
		Action<DeckInfo> SaveRecommendDeckCallback { get; set; }
	}
}
