using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004158 RID: 16728
	[NullableContext(1)]
	public interface IDeckBuilderCardDetailPanelData
	{
		// Token: 0x17005503 RID: 21763
		// (get) Token: 0x0602A51D RID: 173341
		[Nullable(2)]
		DeckInfo DeckInfo { [NullableContext(2)] get; }

		// Token: 0x17005504 RID: 21764
		// (get) Token: 0x0602A51E RID: 173342
		[Nullable(2)]
		Action AddCardToDeck { [NullableContext(2)] get; }

		// Token: 0x17005505 RID: 21765
		// (get) Token: 0x0602A51F RID: 173343
		[Nullable(2)]
		Action RemoveCardFromDeck { [NullableContext(2)] get; }

		// Token: 0x17005506 RID: 21766
		// (get) Token: 0x0602A520 RID: 173344
		DetailViewCardItemData CardItemData { get; }

		// Token: 0x17005507 RID: 21767
		// (get) Token: 0x0602A521 RID: 173345
		int[] EntryIdList { get; }

		// Token: 0x17005508 RID: 21768
		// (get) Token: 0x0602A522 RID: 173346
		CardDetailItemData DetailItemData { get; }

		// Token: 0x17005509 RID: 21769
		// (get) Token: 0x0602A523 RID: 173347
		bool IsCardUnlocked { get; }

		// Token: 0x1700550A RID: 21770
		// (get) Token: 0x0602A524 RID: 173348
		int? CurrencyId { get; }

		// Token: 0x1700550B RID: 21771
		// (get) Token: 0x0602A525 RID: 173349
		int? UnlockCost { get; }

		// Token: 0x1700550C RID: 21772
		// (get) Token: 0x0602A526 RID: 173350
		int? CardLimit { get; }
	}
}
