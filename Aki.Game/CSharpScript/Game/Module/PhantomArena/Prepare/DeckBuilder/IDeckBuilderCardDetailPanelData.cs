using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005188 RID: 20872
	[NullableContext(1)]
	public interface IDeckBuilderCardDetailPanelData
	{
		// Token: 0x17008143 RID: 33091
		// (get) Token: 0x06035622 RID: 218658
		[Nullable(2)]
		DeckInfo DeckInfo { [NullableContext(2)] get; }

		// Token: 0x17008144 RID: 33092
		// (get) Token: 0x06035623 RID: 218659
		[Nullable(2)]
		Action AddCardToDeck { [NullableContext(2)] get; }

		// Token: 0x17008145 RID: 33093
		// (get) Token: 0x06035624 RID: 218660
		[Nullable(2)]
		Action RemoveCardFromDeck { [NullableContext(2)] get; }

		// Token: 0x17008146 RID: 33094
		// (get) Token: 0x06035625 RID: 218661
		DetailViewCardItemData CardItemData { get; }

		// Token: 0x17008147 RID: 33095
		// (get) Token: 0x06035626 RID: 218662
		int[] EntryIdList { get; }

		// Token: 0x17008148 RID: 33096
		// (get) Token: 0x06035627 RID: 218663
		CardDetailItemData DetailItemData { get; }

		// Token: 0x17008149 RID: 33097
		// (get) Token: 0x06035628 RID: 218664
		bool IsCardUnlocked { get; }

		// Token: 0x1700814A RID: 33098
		// (get) Token: 0x06035629 RID: 218665
		int? CurrencyId { get; }

		// Token: 0x1700814B RID: 33099
		// (get) Token: 0x0603562A RID: 218666
		int? UnlockCost { get; }

		// Token: 0x1700814C RID: 33100
		// (get) Token: 0x0603562B RID: 218667
		int? CardLimit { get; }
	}
}
