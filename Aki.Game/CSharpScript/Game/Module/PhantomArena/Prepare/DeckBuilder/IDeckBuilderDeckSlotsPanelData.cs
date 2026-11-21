using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004167 RID: 16743
	[NullableContext(1)]
	public interface IDeckBuilderDeckSlotsPanelData
	{
		// Token: 0x17005523 RID: 21795
		// (get) Token: 0x0602A5AA RID: 173482
		// (set) Token: 0x0602A5AB RID: 173483
		DeckInfo DeckInfo { get; set; }

		// Token: 0x17005524 RID: 21796
		// (get) Token: 0x0602A5AC RID: 173484
		// (set) Token: 0x0602A5AD RID: 173485
		float? SlotLongPressStartTime { get; set; }

		// Token: 0x17005525 RID: 21797
		// (get) Token: 0x0602A5AE RID: 173486
		// (set) Token: 0x0602A5AF RID: 173487
		float? SlotLongPressEndTime { get; set; }

		// Token: 0x17005526 RID: 21798
		// (get) Token: 0x0602A5B0 RID: 173488
		// (set) Token: 0x0602A5B1 RID: 173489
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem> OnCoreSlotItemSortClick { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005527 RID: 21799
		// (get) Token: 0x0602A5B2 RID: 173490
		// (set) Token: 0x0602A5B3 RID: 173491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem, float> OnCoreSlotItemLongPress { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005528 RID: 21800
		// (get) Token: 0x0602A5B4 RID: 173492
		// (set) Token: 0x0602A5B5 RID: 173493
		[Nullable(2)]
		Action OnSlotItemLongPressEnd { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005529 RID: 21801
		// (get) Token: 0x0602A5B6 RID: 173494
		// (set) Token: 0x0602A5B7 RID: 173495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem, EToggleState> OnCoreSlotItemToggleStateChange { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700552A RID: 21802
		// (get) Token: 0x0602A5B8 RID: 173496
		// (set) Token: 0x0602A5B9 RID: 173497
		Func<DeckBuilderCardSlotItem, bool> CanCoreSlotItemToggleChange { get; set; }

		// Token: 0x1700552B RID: 21803
		// (get) Token: 0x0602A5BA RID: 173498
		// (set) Token: 0x0602A5BB RID: 173499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem> OnNormalSlotItemSortClick { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700552C RID: 21804
		// (get) Token: 0x0602A5BC RID: 173500
		// (set) Token: 0x0602A5BD RID: 173501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem, float> OnNormalSlotItemLongPress { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700552D RID: 21805
		// (get) Token: 0x0602A5BE RID: 173502
		// (set) Token: 0x0602A5BF RID: 173503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem, EToggleState> OnNormalSlotItemToggleStateChange { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700552E RID: 21806
		// (get) Token: 0x0602A5C0 RID: 173504
		// (set) Token: 0x0602A5C1 RID: 173505
		Func<DeckBuilderCardSlotItem, bool> CanNormalSlotItemToggleChange { get; set; }

		// Token: 0x1700552F RID: 21807
		// (get) Token: 0x0602A5C2 RID: 173506
		// (set) Token: 0x0602A5C3 RID: 173507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem, EToggleState> OnFieldSlotItemToggleStateChange { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005530 RID: 21808
		// (get) Token: 0x0602A5C4 RID: 173508
		// (set) Token: 0x0602A5C5 RID: 173509
		Func<DeckBuilderCardSlotItem, bool> CanFieldSlotItemToggleChange { get; set; }

		// Token: 0x17005531 RID: 21809
		// (get) Token: 0x0602A5C6 RID: 173510
		// (set) Token: 0x0602A5C7 RID: 173511
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<DeckBuilderCardSlotItem> OnFieldCardItemEffectBtnClick { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005532 RID: 21810
		// (get) Token: 0x0602A5C8 RID: 173512
		// (set) Token: 0x0602A5C9 RID: 173513
		[Nullable(2)]
		Action<int> OnSlotCardPointEnterCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005533 RID: 21811
		// (get) Token: 0x0602A5CA RID: 173514
		// (set) Token: 0x0602A5CB RID: 173515
		[Nullable(2)]
		Action OnSlotCardPointExitCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005534 RID: 21812
		// (get) Token: 0x0602A5CC RID: 173516
		// (set) Token: 0x0602A5CD RID: 173517
		CardSlotSortContext SortContext { get; set; }

		// Token: 0x17005535 RID: 21813
		// (get) Token: 0x0602A5CE RID: 173518
		// (set) Token: 0x0602A5CF RID: 173519
		bool ShowLocked { get; set; }

		// Token: 0x17005536 RID: 21814
		// (get) Token: 0x0602A5D0 RID: 173520
		// (set) Token: 0x0602A5D1 RID: 173521
		bool ShowOutlook { get; set; }

		// Token: 0x17005537 RID: 21815
		// (get) Token: 0x0602A5D2 RID: 173522
		// (set) Token: 0x0602A5D3 RID: 173523
		bool IsNeedFieldCard { get; set; }

		// Token: 0x17005538 RID: 21816
		// (get) Token: 0x0602A5D4 RID: 173524
		// (set) Token: 0x0602A5D5 RID: 173525
		bool IsNeedRequestCheckCardSkillUnlock { get; set; }
	}
}
