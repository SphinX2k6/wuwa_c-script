using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005197 RID: 20887
	[NullableContext(1)]
	public interface IDeckBuilderDeckSlotsPanelData
	{
		// Token: 0x17008163 RID: 33123
		// (get) Token: 0x060356AF RID: 218799
		// (set) Token: 0x060356B0 RID: 218800
		DeckInfo DeckInfo { get; set; }

		// Token: 0x17008164 RID: 33124
		// (get) Token: 0x060356B1 RID: 218801
		// (set) Token: 0x060356B2 RID: 218802
		float? SlotLongPressStartTime { get; set; }

		// Token: 0x17008165 RID: 33125
		// (get) Token: 0x060356B3 RID: 218803
		// (set) Token: 0x060356B4 RID: 218804
		float? SlotLongPressEndTime { get; set; }

		// Token: 0x17008166 RID: 33126
		// (get) Token: 0x060356B5 RID: 218805
		// (set) Token: 0x060356B6 RID: 218806
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

		// Token: 0x17008167 RID: 33127
		// (get) Token: 0x060356B7 RID: 218807
		// (set) Token: 0x060356B8 RID: 218808
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

		// Token: 0x17008168 RID: 33128
		// (get) Token: 0x060356B9 RID: 218809
		// (set) Token: 0x060356BA RID: 218810
		[Nullable(2)]
		Action OnSlotItemLongPressEnd { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008169 RID: 33129
		// (get) Token: 0x060356BB RID: 218811
		// (set) Token: 0x060356BC RID: 218812
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

		// Token: 0x1700816A RID: 33130
		// (get) Token: 0x060356BD RID: 218813
		// (set) Token: 0x060356BE RID: 218814
		Func<DeckBuilderCardSlotItem, bool> CanCoreSlotItemToggleChange { get; set; }

		// Token: 0x1700816B RID: 33131
		// (get) Token: 0x060356BF RID: 218815
		// (set) Token: 0x060356C0 RID: 218816
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

		// Token: 0x1700816C RID: 33132
		// (get) Token: 0x060356C1 RID: 218817
		// (set) Token: 0x060356C2 RID: 218818
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

		// Token: 0x1700816D RID: 33133
		// (get) Token: 0x060356C3 RID: 218819
		// (set) Token: 0x060356C4 RID: 218820
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

		// Token: 0x1700816E RID: 33134
		// (get) Token: 0x060356C5 RID: 218821
		// (set) Token: 0x060356C6 RID: 218822
		Func<DeckBuilderCardSlotItem, bool> CanNormalSlotItemToggleChange { get; set; }

		// Token: 0x1700816F RID: 33135
		// (get) Token: 0x060356C7 RID: 218823
		// (set) Token: 0x060356C8 RID: 218824
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

		// Token: 0x17008170 RID: 33136
		// (get) Token: 0x060356C9 RID: 218825
		// (set) Token: 0x060356CA RID: 218826
		Func<DeckBuilderCardSlotItem, bool> CanFieldSlotItemToggleChange { get; set; }

		// Token: 0x17008171 RID: 33137
		// (get) Token: 0x060356CB RID: 218827
		// (set) Token: 0x060356CC RID: 218828
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

		// Token: 0x17008172 RID: 33138
		// (get) Token: 0x060356CD RID: 218829
		// (set) Token: 0x060356CE RID: 218830
		[Nullable(2)]
		Action<int> OnSlotCardPointEnterCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008173 RID: 33139
		// (get) Token: 0x060356CF RID: 218831
		// (set) Token: 0x060356D0 RID: 218832
		[Nullable(2)]
		Action OnSlotCardPointExitCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008174 RID: 33140
		// (get) Token: 0x060356D1 RID: 218833
		// (set) Token: 0x060356D2 RID: 218834
		CardSlotSortContext SortContext { get; set; }

		// Token: 0x17008175 RID: 33141
		// (get) Token: 0x060356D3 RID: 218835
		// (set) Token: 0x060356D4 RID: 218836
		bool ShowLocked { get; set; }

		// Token: 0x17008176 RID: 33142
		// (get) Token: 0x060356D5 RID: 218837
		// (set) Token: 0x060356D6 RID: 218838
		bool ShowOutlook { get; set; }

		// Token: 0x17008177 RID: 33143
		// (get) Token: 0x060356D7 RID: 218839
		// (set) Token: 0x060356D8 RID: 218840
		bool IsNeedFieldCard { get; set; }

		// Token: 0x17008178 RID: 33144
		// (get) Token: 0x060356D9 RID: 218841
		// (set) Token: 0x060356DA RID: 218842
		bool IsNeedRequestCheckCardSkillUnlock { get; set; }
	}
}
