using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DA2 RID: 15778
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePopularEntriesGroup : GridProxyAbstract<RoguelikeEntriesGroupData>
	{
		// Token: 0x06028580 RID: 165248 RVA: 0x00B4DD34 File Offset: 0x00B4BF34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028581 RID: 165249 RVA: 0x00B4DECC File Offset: 0x00B4C0CC
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikePopularEntriesGroup.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikePopularEntriesGroup.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028582 RID: 165250 RVA: 0x00B4DF10 File Offset: 0x00B4C110
		protected override void OnStart()
		{
			this.LayoutRow1 = new GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData>(base.GetHorizontalLayout(0), new Func<RoguelikePopularEntryItem>(this.CreateEntryItem), null, false, true);
			this.LayoutRow2 = new GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData>(base.GetHorizontalLayout(1), new Func<RoguelikePopularEntryItem>(this.CreateEntryItem), null, false, true);
			this.LayoutRow3 = new GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData>(base.GetHorizontalLayout(2), new Func<RoguelikePopularEntryItem>(this.CreateEntryItem), null, false, true);
		}

		// Token: 0x06028583 RID: 165251 RVA: 0x00B4DF80 File Offset: 0x00B4C180
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.ActiveStateChange = null;
				this.Data.FocusStateChange = null;
			}
		}

		// Token: 0x06028584 RID: 165252 RVA: 0x00B4DFA4 File Offset: 0x00B4C1A4
		[NullableContext(1)]
		public override UniTask RefreshAsync(RoguelikeEntriesGroupData data, bool isSelected, int gridIndex)
		{
			RoguelikePopularEntriesGroup.<RefreshAsync>d__14 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.gridIndex = gridIndex;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<RoguelikePopularEntriesGroup.<RefreshAsync>d__14>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028585 RID: 165253 RVA: 0x00B4DFF7 File Offset: 0x00B4C1F7
		[NullableContext(1)]
		private RoguelikePopularEntryItem CreateEntryItem()
		{
			return new RoguelikePopularEntryItem();
		}

		// Token: 0x06028586 RID: 165254 RVA: 0x00B4DFFE File Offset: 0x00B4C1FE
		[NullableContext(1)]
		private List<RoguelikePopularEntryItem> GetAllEntryItems()
		{
			List<RoguelikePopularEntryItem> list = new List<RoguelikePopularEntryItem>();
			list.AddRange(this.LayoutRow1.GetLayoutItemList());
			list.AddRange(this.LayoutRow2.GetLayoutItemList());
			list.AddRange(this.LayoutRow3.GetLayoutItemList());
			return list;
		}

		// Token: 0x06028587 RID: 165255 RVA: 0x00B4E038 File Offset: 0x00B4C238
		private void ActiveStateChange(bool isActive)
		{
			this.BarLevelSequencePlayer.StopPlayingSequence(false, true);
			this.BarLevelSequencePlayer.PlayOrReplaySequenceByName(isActive ? "Close" : "Start", false, null);
			foreach (RoguelikePopularEntryItem roguelikePopularEntryItem in this.GetAllEntryItems())
			{
				roguelikePopularEntryItem.SetActiveState(isActive);
			}
		}

		// Token: 0x06028588 RID: 165256 RVA: 0x00B4E0BC File Offset: 0x00B4C2BC
		private void FocusStateChange(bool isFocus)
		{
			foreach (RoguelikePopularEntryItem roguelikePopularEntryItem in this.GetAllEntryItems())
			{
				roguelikePopularEntryItem.SetFocusState(isFocus);
			}
		}

		// Token: 0x06028589 RID: 165257 RVA: 0x00B4E110 File Offset: 0x00B4C310
		[NullableContext(1)]
		public override object GetKey(RoguelikeEntriesGroupData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x04015EC1 RID: 89793
		private RoguelikeEntriesGroupData Data;

		// Token: 0x04015EC2 RID: 89794
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData> LayoutRow1;

		// Token: 0x04015EC3 RID: 89795
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData> LayoutRow2;

		// Token: 0x04015EC4 RID: 89796
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData> LayoutRow3;

		// Token: 0x04015EC5 RID: 89797
		private RoguelikePopularEntryItem EntryRow1;

		// Token: 0x04015EC6 RID: 89798
		private RoguelikePopularEntryItem EntryRow2;

		// Token: 0x04015EC7 RID: 89799
		private RoguelikePopularEntryItem EntryRow3;

		// Token: 0x04015EC8 RID: 89800
		private LevelSequencePlayer BarLevelSequencePlayer;

		// Token: 0x04015EC9 RID: 89801
		public Func<int, bool> IsLastGroup;

		// Token: 0x02009991 RID: 39313
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402FE1E RID: 196126
			public const int LayoutGroupRow1 = 0;

			// Token: 0x0402FE1F RID: 196127
			public const int LayoutGroupRow2 = 1;

			// Token: 0x0402FE20 RID: 196128
			public const int LayoutGroupRow3 = 2;

			// Token: 0x0402FE21 RID: 196129
			public const int LayoutItemRow1 = 3;

			// Token: 0x0402FE22 RID: 196130
			public const int LayoutItemRow2 = 4;

			// Token: 0x0402FE23 RID: 196131
			public const int LayoutItemRow3 = 5;

			// Token: 0x0402FE24 RID: 196132
			public const int ItemLine = 6;

			// Token: 0x0402FE25 RID: 196133
			public const int PanelValue = 7;

			// Token: 0x0402FE26 RID: 196134
			public const int TxtMultiplier = 8;

			// Token: 0x0402FE27 RID: 196135
			public const int PanelLock = 9;

			// Token: 0x0402FE28 RID: 196136
			public const int SpriteLock = 10;
		}
	}
}
