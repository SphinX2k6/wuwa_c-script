using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004168 RID: 16744
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderDeckSlotsPanelData : IDeckBuilderDeckSlotsPanelData
	{
		// Token: 0x17005539 RID: 21817
		// (get) Token: 0x0602A5D6 RID: 173526 RVA: 0x00BF3ED5 File Offset: 0x00BF20D5
		// (set) Token: 0x0602A5D7 RID: 173527 RVA: 0x00BF3EDD File Offset: 0x00BF20DD
		public DeckInfo DeckInfo { get; set; }

		// Token: 0x1700553A RID: 21818
		// (get) Token: 0x0602A5D8 RID: 173528 RVA: 0x00BF3EE6 File Offset: 0x00BF20E6
		// (set) Token: 0x0602A5D9 RID: 173529 RVA: 0x00BF3EEE File Offset: 0x00BF20EE
		public float? SlotLongPressStartTime { get; set; }

		// Token: 0x1700553B RID: 21819
		// (get) Token: 0x0602A5DA RID: 173530 RVA: 0x00BF3EF7 File Offset: 0x00BF20F7
		// (set) Token: 0x0602A5DB RID: 173531 RVA: 0x00BF3EFF File Offset: 0x00BF20FF
		public float? SlotLongPressEndTime { get; set; }

		// Token: 0x1700553C RID: 21820
		// (get) Token: 0x0602A5DC RID: 173532 RVA: 0x00BF3F08 File Offset: 0x00BF2108
		// (set) Token: 0x0602A5DD RID: 173533 RVA: 0x00BF3F10 File Offset: 0x00BF2110
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem> OnCoreSlotItemSortClick { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700553D RID: 21821
		// (get) Token: 0x0602A5DE RID: 173534 RVA: 0x00BF3F19 File Offset: 0x00BF2119
		// (set) Token: 0x0602A5DF RID: 173535 RVA: 0x00BF3F21 File Offset: 0x00BF2121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, float> OnCoreSlotItemLongPress { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700553E RID: 21822
		// (get) Token: 0x0602A5E0 RID: 173536 RVA: 0x00BF3F2A File Offset: 0x00BF212A
		// (set) Token: 0x0602A5E1 RID: 173537 RVA: 0x00BF3F32 File Offset: 0x00BF2132
		[Nullable(2)]
		public Action OnSlotItemLongPressEnd { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700553F RID: 21823
		// (get) Token: 0x0602A5E2 RID: 173538 RVA: 0x00BF3F3B File Offset: 0x00BF213B
		// (set) Token: 0x0602A5E3 RID: 173539 RVA: 0x00BF3F43 File Offset: 0x00BF2143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, EToggleState> OnCoreSlotItemToggleStateChange { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005540 RID: 21824
		// (get) Token: 0x0602A5E4 RID: 173540 RVA: 0x00BF3F4C File Offset: 0x00BF214C
		// (set) Token: 0x0602A5E5 RID: 173541 RVA: 0x00BF3F54 File Offset: 0x00BF2154
		public Func<DeckBuilderCardSlotItem, bool> CanCoreSlotItemToggleChange { get; set; }

		// Token: 0x17005541 RID: 21825
		// (get) Token: 0x0602A5E6 RID: 173542 RVA: 0x00BF3F5D File Offset: 0x00BF215D
		// (set) Token: 0x0602A5E7 RID: 173543 RVA: 0x00BF3F65 File Offset: 0x00BF2165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem> OnNormalSlotItemSortClick { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005542 RID: 21826
		// (get) Token: 0x0602A5E8 RID: 173544 RVA: 0x00BF3F6E File Offset: 0x00BF216E
		// (set) Token: 0x0602A5E9 RID: 173545 RVA: 0x00BF3F76 File Offset: 0x00BF2176
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, float> OnNormalSlotItemLongPress { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005543 RID: 21827
		// (get) Token: 0x0602A5EA RID: 173546 RVA: 0x00BF3F7F File Offset: 0x00BF217F
		// (set) Token: 0x0602A5EB RID: 173547 RVA: 0x00BF3F87 File Offset: 0x00BF2187
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, EToggleState> OnNormalSlotItemToggleStateChange { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005544 RID: 21828
		// (get) Token: 0x0602A5EC RID: 173548 RVA: 0x00BF3F90 File Offset: 0x00BF2190
		// (set) Token: 0x0602A5ED RID: 173549 RVA: 0x00BF3F98 File Offset: 0x00BF2198
		public Func<DeckBuilderCardSlotItem, bool> CanNormalSlotItemToggleChange { get; set; }

		// Token: 0x17005545 RID: 21829
		// (get) Token: 0x0602A5EE RID: 173550 RVA: 0x00BF3FA1 File Offset: 0x00BF21A1
		// (set) Token: 0x0602A5EF RID: 173551 RVA: 0x00BF3FA9 File Offset: 0x00BF21A9
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, EToggleState> OnFieldSlotItemToggleStateChange { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005546 RID: 21830
		// (get) Token: 0x0602A5F0 RID: 173552 RVA: 0x00BF3FB2 File Offset: 0x00BF21B2
		// (set) Token: 0x0602A5F1 RID: 173553 RVA: 0x00BF3FBA File Offset: 0x00BF21BA
		public Func<DeckBuilderCardSlotItem, bool> CanFieldSlotItemToggleChange { get; set; }

		// Token: 0x17005547 RID: 21831
		// (get) Token: 0x0602A5F2 RID: 173554 RVA: 0x00BF3FC3 File Offset: 0x00BF21C3
		// (set) Token: 0x0602A5F3 RID: 173555 RVA: 0x00BF3FCB File Offset: 0x00BF21CB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem> OnFieldCardItemEffectBtnClick { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005548 RID: 21832
		// (get) Token: 0x0602A5F4 RID: 173556 RVA: 0x00BF3FD4 File Offset: 0x00BF21D4
		// (set) Token: 0x0602A5F5 RID: 173557 RVA: 0x00BF3FDC File Offset: 0x00BF21DC
		[Nullable(2)]
		public Action<int> OnSlotCardPointEnterCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005549 RID: 21833
		// (get) Token: 0x0602A5F6 RID: 173558 RVA: 0x00BF3FE5 File Offset: 0x00BF21E5
		// (set) Token: 0x0602A5F7 RID: 173559 RVA: 0x00BF3FED File Offset: 0x00BF21ED
		[Nullable(2)]
		public Action OnSlotCardPointExitCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700554A RID: 21834
		// (get) Token: 0x0602A5F8 RID: 173560 RVA: 0x00BF3FF6 File Offset: 0x00BF21F6
		// (set) Token: 0x0602A5F9 RID: 173561 RVA: 0x00BF3FFE File Offset: 0x00BF21FE
		public CardSlotSortContext SortContext { get; set; }

		// Token: 0x1700554B RID: 21835
		// (get) Token: 0x0602A5FA RID: 173562 RVA: 0x00BF4007 File Offset: 0x00BF2207
		// (set) Token: 0x0602A5FB RID: 173563 RVA: 0x00BF400F File Offset: 0x00BF220F
		public bool ShowLocked { get; set; }

		// Token: 0x1700554C RID: 21836
		// (get) Token: 0x0602A5FC RID: 173564 RVA: 0x00BF4018 File Offset: 0x00BF2218
		// (set) Token: 0x0602A5FD RID: 173565 RVA: 0x00BF4020 File Offset: 0x00BF2220
		public bool ShowOutlook { get; set; }

		// Token: 0x1700554D RID: 21837
		// (get) Token: 0x0602A5FE RID: 173566 RVA: 0x00BF4029 File Offset: 0x00BF2229
		// (set) Token: 0x0602A5FF RID: 173567 RVA: 0x00BF4031 File Offset: 0x00BF2231
		public bool IsNeedFieldCard { get; set; }

		// Token: 0x1700554E RID: 21838
		// (get) Token: 0x0602A600 RID: 173568 RVA: 0x00BF403A File Offset: 0x00BF223A
		// (set) Token: 0x0602A601 RID: 173569 RVA: 0x00BF4042 File Offset: 0x00BF2242
		public bool IsNeedRequestCheckCardSkillUnlock { get; set; }
	}
}
