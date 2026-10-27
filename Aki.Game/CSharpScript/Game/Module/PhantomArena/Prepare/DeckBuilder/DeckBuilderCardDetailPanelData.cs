using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005190 RID: 20880
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardDetailPanelData : IDeckBuilderCardDetailPanelData
	{
		// Token: 0x1700814D RID: 33101
		// (get) Token: 0x06035665 RID: 218725 RVA: 0x00CA5FEA File Offset: 0x00CA41EA
		// (set) Token: 0x06035666 RID: 218726 RVA: 0x00CA5FF2 File Offset: 0x00CA41F2
		[Nullable(2)]
		public DeckInfo DeckInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700814E RID: 33102
		// (get) Token: 0x06035667 RID: 218727 RVA: 0x00CA5FFB File Offset: 0x00CA41FB
		// (set) Token: 0x06035668 RID: 218728 RVA: 0x00CA6003 File Offset: 0x00CA4203
		[Nullable(2)]
		public Action AddCardToDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700814F RID: 33103
		// (get) Token: 0x06035669 RID: 218729 RVA: 0x00CA600C File Offset: 0x00CA420C
		// (set) Token: 0x0603566A RID: 218730 RVA: 0x00CA6014 File Offset: 0x00CA4214
		[Nullable(2)]
		public Action RemoveCardFromDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008150 RID: 33104
		// (get) Token: 0x0603566B RID: 218731 RVA: 0x00CA601D File Offset: 0x00CA421D
		// (set) Token: 0x0603566C RID: 218732 RVA: 0x00CA6025 File Offset: 0x00CA4225
		public DetailViewCardItemData CardItemData { get; set; }

		// Token: 0x17008151 RID: 33105
		// (get) Token: 0x0603566D RID: 218733 RVA: 0x00CA602E File Offset: 0x00CA422E
		// (set) Token: 0x0603566E RID: 218734 RVA: 0x00CA6036 File Offset: 0x00CA4236
		public int[] EntryIdList { get; set; }

		// Token: 0x17008152 RID: 33106
		// (get) Token: 0x0603566F RID: 218735 RVA: 0x00CA603F File Offset: 0x00CA423F
		// (set) Token: 0x06035670 RID: 218736 RVA: 0x00CA6047 File Offset: 0x00CA4247
		public CardDetailItemData DetailItemData { get; set; }

		// Token: 0x17008153 RID: 33107
		// (get) Token: 0x06035671 RID: 218737 RVA: 0x00CA6050 File Offset: 0x00CA4250
		// (set) Token: 0x06035672 RID: 218738 RVA: 0x00CA6058 File Offset: 0x00CA4258
		public bool IsCardUnlocked { get; set; }

		// Token: 0x17008154 RID: 33108
		// (get) Token: 0x06035673 RID: 218739 RVA: 0x00CA6061 File Offset: 0x00CA4261
		// (set) Token: 0x06035674 RID: 218740 RVA: 0x00CA6069 File Offset: 0x00CA4269
		public int? CurrencyId { get; set; }

		// Token: 0x17008155 RID: 33109
		// (get) Token: 0x06035675 RID: 218741 RVA: 0x00CA6072 File Offset: 0x00CA4272
		// (set) Token: 0x06035676 RID: 218742 RVA: 0x00CA607A File Offset: 0x00CA427A
		public int? UnlockCost { get; set; }

		// Token: 0x17008156 RID: 33110
		// (get) Token: 0x06035677 RID: 218743 RVA: 0x00CA6083 File Offset: 0x00CA4283
		// (set) Token: 0x06035678 RID: 218744 RVA: 0x00CA608B File Offset: 0x00CA428B
		public int? CardLimit { get; set; }
	}
}
