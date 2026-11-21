using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004160 RID: 16736
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardDetailPanelData : IDeckBuilderCardDetailPanelData
	{
		// Token: 0x1700550D RID: 21773
		// (get) Token: 0x0602A560 RID: 173408 RVA: 0x00BF359E File Offset: 0x00BF179E
		// (set) Token: 0x0602A561 RID: 173409 RVA: 0x00BF35A6 File Offset: 0x00BF17A6
		[Nullable(2)]
		public DeckInfo DeckInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700550E RID: 21774
		// (get) Token: 0x0602A562 RID: 173410 RVA: 0x00BF35AF File Offset: 0x00BF17AF
		// (set) Token: 0x0602A563 RID: 173411 RVA: 0x00BF35B7 File Offset: 0x00BF17B7
		[Nullable(2)]
		public Action AddCardToDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700550F RID: 21775
		// (get) Token: 0x0602A564 RID: 173412 RVA: 0x00BF35C0 File Offset: 0x00BF17C0
		// (set) Token: 0x0602A565 RID: 173413 RVA: 0x00BF35C8 File Offset: 0x00BF17C8
		[Nullable(2)]
		public Action RemoveCardFromDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005510 RID: 21776
		// (get) Token: 0x0602A566 RID: 173414 RVA: 0x00BF35D1 File Offset: 0x00BF17D1
		// (set) Token: 0x0602A567 RID: 173415 RVA: 0x00BF35D9 File Offset: 0x00BF17D9
		public DetailViewCardItemData CardItemData { get; set; }

		// Token: 0x17005511 RID: 21777
		// (get) Token: 0x0602A568 RID: 173416 RVA: 0x00BF35E2 File Offset: 0x00BF17E2
		// (set) Token: 0x0602A569 RID: 173417 RVA: 0x00BF35EA File Offset: 0x00BF17EA
		public int[] EntryIdList { get; set; }

		// Token: 0x17005512 RID: 21778
		// (get) Token: 0x0602A56A RID: 173418 RVA: 0x00BF35F3 File Offset: 0x00BF17F3
		// (set) Token: 0x0602A56B RID: 173419 RVA: 0x00BF35FB File Offset: 0x00BF17FB
		public CardDetailItemData DetailItemData { get; set; }

		// Token: 0x17005513 RID: 21779
		// (get) Token: 0x0602A56C RID: 173420 RVA: 0x00BF3604 File Offset: 0x00BF1804
		// (set) Token: 0x0602A56D RID: 173421 RVA: 0x00BF360C File Offset: 0x00BF180C
		public bool IsCardUnlocked { get; set; }

		// Token: 0x17005514 RID: 21780
		// (get) Token: 0x0602A56E RID: 173422 RVA: 0x00BF3615 File Offset: 0x00BF1815
		// (set) Token: 0x0602A56F RID: 173423 RVA: 0x00BF361D File Offset: 0x00BF181D
		public int? CurrencyId { get; set; }

		// Token: 0x17005515 RID: 21781
		// (get) Token: 0x0602A570 RID: 173424 RVA: 0x00BF3626 File Offset: 0x00BF1826
		// (set) Token: 0x0602A571 RID: 173425 RVA: 0x00BF362E File Offset: 0x00BF182E
		public int? UnlockCost { get; set; }

		// Token: 0x17005516 RID: 21782
		// (get) Token: 0x0602A572 RID: 173426 RVA: 0x00BF3637 File Offset: 0x00BF1837
		// (set) Token: 0x0602A573 RID: 173427 RVA: 0x00BF363F File Offset: 0x00BF183F
		public int? CardLimit { get; set; }
	}
}
