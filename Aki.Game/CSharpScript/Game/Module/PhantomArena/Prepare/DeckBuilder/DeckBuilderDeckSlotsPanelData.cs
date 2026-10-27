using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005198 RID: 20888
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderDeckSlotsPanelData : IDeckBuilderDeckSlotsPanelData
	{
		// Token: 0x17008179 RID: 33145
		// (get) Token: 0x060356DB RID: 218843 RVA: 0x00CA6921 File Offset: 0x00CA4B21
		// (set) Token: 0x060356DC RID: 218844 RVA: 0x00CA6929 File Offset: 0x00CA4B29
		public DeckInfo DeckInfo { get; set; }

		// Token: 0x1700817A RID: 33146
		// (get) Token: 0x060356DD RID: 218845 RVA: 0x00CA6932 File Offset: 0x00CA4B32
		// (set) Token: 0x060356DE RID: 218846 RVA: 0x00CA693A File Offset: 0x00CA4B3A
		public float? SlotLongPressStartTime { get; set; }

		// Token: 0x1700817B RID: 33147
		// (get) Token: 0x060356DF RID: 218847 RVA: 0x00CA6943 File Offset: 0x00CA4B43
		// (set) Token: 0x060356E0 RID: 218848 RVA: 0x00CA694B File Offset: 0x00CA4B4B
		public float? SlotLongPressEndTime { get; set; }

		// Token: 0x1700817C RID: 33148
		// (get) Token: 0x060356E1 RID: 218849 RVA: 0x00CA6954 File Offset: 0x00CA4B54
		// (set) Token: 0x060356E2 RID: 218850 RVA: 0x00CA695C File Offset: 0x00CA4B5C
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

		// Token: 0x1700817D RID: 33149
		// (get) Token: 0x060356E3 RID: 218851 RVA: 0x00CA6965 File Offset: 0x00CA4B65
		// (set) Token: 0x060356E4 RID: 218852 RVA: 0x00CA696D File Offset: 0x00CA4B6D
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

		// Token: 0x1700817E RID: 33150
		// (get) Token: 0x060356E5 RID: 218853 RVA: 0x00CA6976 File Offset: 0x00CA4B76
		// (set) Token: 0x060356E6 RID: 218854 RVA: 0x00CA697E File Offset: 0x00CA4B7E
		[Nullable(2)]
		public Action OnSlotItemLongPressEnd { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700817F RID: 33151
		// (get) Token: 0x060356E7 RID: 218855 RVA: 0x00CA6987 File Offset: 0x00CA4B87
		// (set) Token: 0x060356E8 RID: 218856 RVA: 0x00CA698F File Offset: 0x00CA4B8F
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

		// Token: 0x17008180 RID: 33152
		// (get) Token: 0x060356E9 RID: 218857 RVA: 0x00CA6998 File Offset: 0x00CA4B98
		// (set) Token: 0x060356EA RID: 218858 RVA: 0x00CA69A0 File Offset: 0x00CA4BA0
		public Func<DeckBuilderCardSlotItem, bool> CanCoreSlotItemToggleChange { get; set; }

		// Token: 0x17008181 RID: 33153
		// (get) Token: 0x060356EB RID: 218859 RVA: 0x00CA69A9 File Offset: 0x00CA4BA9
		// (set) Token: 0x060356EC RID: 218860 RVA: 0x00CA69B1 File Offset: 0x00CA4BB1
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

		// Token: 0x17008182 RID: 33154
		// (get) Token: 0x060356ED RID: 218861 RVA: 0x00CA69BA File Offset: 0x00CA4BBA
		// (set) Token: 0x060356EE RID: 218862 RVA: 0x00CA69C2 File Offset: 0x00CA4BC2
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

		// Token: 0x17008183 RID: 33155
		// (get) Token: 0x060356EF RID: 218863 RVA: 0x00CA69CB File Offset: 0x00CA4BCB
		// (set) Token: 0x060356F0 RID: 218864 RVA: 0x00CA69D3 File Offset: 0x00CA4BD3
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

		// Token: 0x17008184 RID: 33156
		// (get) Token: 0x060356F1 RID: 218865 RVA: 0x00CA69DC File Offset: 0x00CA4BDC
		// (set) Token: 0x060356F2 RID: 218866 RVA: 0x00CA69E4 File Offset: 0x00CA4BE4
		public Func<DeckBuilderCardSlotItem, bool> CanNormalSlotItemToggleChange { get; set; }

		// Token: 0x17008185 RID: 33157
		// (get) Token: 0x060356F3 RID: 218867 RVA: 0x00CA69ED File Offset: 0x00CA4BED
		// (set) Token: 0x060356F4 RID: 218868 RVA: 0x00CA69F5 File Offset: 0x00CA4BF5
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

		// Token: 0x17008186 RID: 33158
		// (get) Token: 0x060356F5 RID: 218869 RVA: 0x00CA69FE File Offset: 0x00CA4BFE
		// (set) Token: 0x060356F6 RID: 218870 RVA: 0x00CA6A06 File Offset: 0x00CA4C06
		public Func<DeckBuilderCardSlotItem, bool> CanFieldSlotItemToggleChange { get; set; }

		// Token: 0x17008187 RID: 33159
		// (get) Token: 0x060356F7 RID: 218871 RVA: 0x00CA6A0F File Offset: 0x00CA4C0F
		// (set) Token: 0x060356F8 RID: 218872 RVA: 0x00CA6A17 File Offset: 0x00CA4C17
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

		// Token: 0x17008188 RID: 33160
		// (get) Token: 0x060356F9 RID: 218873 RVA: 0x00CA6A20 File Offset: 0x00CA4C20
		// (set) Token: 0x060356FA RID: 218874 RVA: 0x00CA6A28 File Offset: 0x00CA4C28
		[Nullable(2)]
		public Action<int> OnSlotCardPointEnterCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008189 RID: 33161
		// (get) Token: 0x060356FB RID: 218875 RVA: 0x00CA6A31 File Offset: 0x00CA4C31
		// (set) Token: 0x060356FC RID: 218876 RVA: 0x00CA6A39 File Offset: 0x00CA4C39
		[Nullable(2)]
		public Action OnSlotCardPointExitCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700818A RID: 33162
		// (get) Token: 0x060356FD RID: 218877 RVA: 0x00CA6A42 File Offset: 0x00CA4C42
		// (set) Token: 0x060356FE RID: 218878 RVA: 0x00CA6A4A File Offset: 0x00CA4C4A
		public CardSlotSortContext SortContext { get; set; }

		// Token: 0x1700818B RID: 33163
		// (get) Token: 0x060356FF RID: 218879 RVA: 0x00CA6A53 File Offset: 0x00CA4C53
		// (set) Token: 0x06035700 RID: 218880 RVA: 0x00CA6A5B File Offset: 0x00CA4C5B
		public bool ShowLocked { get; set; }

		// Token: 0x1700818C RID: 33164
		// (get) Token: 0x06035701 RID: 218881 RVA: 0x00CA6A64 File Offset: 0x00CA4C64
		// (set) Token: 0x06035702 RID: 218882 RVA: 0x00CA6A6C File Offset: 0x00CA4C6C
		public bool ShowOutlook { get; set; }

		// Token: 0x1700818D RID: 33165
		// (get) Token: 0x06035703 RID: 218883 RVA: 0x00CA6A75 File Offset: 0x00CA4C75
		// (set) Token: 0x06035704 RID: 218884 RVA: 0x00CA6A7D File Offset: 0x00CA4C7D
		public bool IsNeedFieldCard { get; set; }

		// Token: 0x1700818E RID: 33166
		// (get) Token: 0x06035705 RID: 218885 RVA: 0x00CA6A86 File Offset: 0x00CA4C86
		// (set) Token: 0x06035706 RID: 218886 RVA: 0x00CA6A8E File Offset: 0x00CA4C8E
		public bool IsNeedRequestCheckCardSkillUnlock { get; set; }
	}
}
