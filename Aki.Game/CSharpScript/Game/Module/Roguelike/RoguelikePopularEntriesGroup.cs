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
	// Token: 0x02004DD9 RID: 19929
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePopularEntriesGroup : GridProxyAbstract<RoguelikeEntriesGroupData>
	{
		// Token: 0x06033715 RID: 210709 RVA: 0x00C04824 File Offset: 0x00C02A24
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

		// Token: 0x06033716 RID: 210710 RVA: 0x00C049BC File Offset: 0x00C02BBC
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikePopularEntriesGroup.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikePopularEntriesGroup.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033717 RID: 210711 RVA: 0x00C04A00 File Offset: 0x00C02C00
		protected override void OnStart()
		{
			this.LayoutRow1 = new GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData>(base.GetHorizontalLayout(0), new Func<RoguelikePopularEntryItem>(this.CreateEntryItem), null, false, true);
			this.LayoutRow2 = new GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData>(base.GetHorizontalLayout(1), new Func<RoguelikePopularEntryItem>(this.CreateEntryItem), null, false, true);
			this.LayoutRow3 = new GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData>(base.GetHorizontalLayout(2), new Func<RoguelikePopularEntryItem>(this.CreateEntryItem), null, false, true);
		}

		// Token: 0x06033718 RID: 210712 RVA: 0x00C04A70 File Offset: 0x00C02C70
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.ActiveStateChange = null;
				this.Data.FocusStateChange = null;
			}
		}

		// Token: 0x06033719 RID: 210713 RVA: 0x00C04A94 File Offset: 0x00C02C94
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

		// Token: 0x0603371A RID: 210714 RVA: 0x00C04AE7 File Offset: 0x00C02CE7
		[NullableContext(1)]
		private RoguelikePopularEntryItem CreateEntryItem()
		{
			return new RoguelikePopularEntryItem();
		}

		// Token: 0x0603371B RID: 210715 RVA: 0x00C04AEE File Offset: 0x00C02CEE
		[NullableContext(1)]
		private List<RoguelikePopularEntryItem> GetAllEntryItems()
		{
			List<RoguelikePopularEntryItem> list = new List<RoguelikePopularEntryItem>();
			list.AddRange(this.LayoutRow1.GetLayoutItemList());
			list.AddRange(this.LayoutRow2.GetLayoutItemList());
			list.AddRange(this.LayoutRow3.GetLayoutItemList());
			return list;
		}

		// Token: 0x0603371C RID: 210716 RVA: 0x00C04B28 File Offset: 0x00C02D28
		private void ActiveStateChange(bool isActive)
		{
			this.BarLevelSequencePlayer.StopPlayingSequence(false, true);
			this.BarLevelSequencePlayer.PlayOrReplaySequenceByName(isActive ? "Close" : "Start", false, null);
			foreach (RoguelikePopularEntryItem roguelikePopularEntryItem in this.GetAllEntryItems())
			{
				roguelikePopularEntryItem.SetActiveState(isActive);
			}
		}

		// Token: 0x0603371D RID: 210717 RVA: 0x00C04BAC File Offset: 0x00C02DAC
		private void FocusStateChange(bool isFocus)
		{
			foreach (RoguelikePopularEntryItem roguelikePopularEntryItem in this.GetAllEntryItems())
			{
				roguelikePopularEntryItem.SetFocusState(isFocus);
			}
		}

		// Token: 0x0603371E RID: 210718 RVA: 0x00C04C00 File Offset: 0x00C02E00
		[NullableContext(1)]
		public override object GetKey(RoguelikeEntriesGroupData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0401B4EE RID: 111854
		private RoguelikeEntriesGroupData Data;

		// Token: 0x0401B4EF RID: 111855
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData> LayoutRow1;

		// Token: 0x0401B4F0 RID: 111856
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData> LayoutRow2;

		// Token: 0x0401B4F1 RID: 111857
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePopularEntryItem, RoguelikeEntryData> LayoutRow3;

		// Token: 0x0401B4F2 RID: 111858
		private RoguelikePopularEntryItem EntryRow1;

		// Token: 0x0401B4F3 RID: 111859
		private RoguelikePopularEntryItem EntryRow2;

		// Token: 0x0401B4F4 RID: 111860
		private RoguelikePopularEntryItem EntryRow3;

		// Token: 0x0401B4F5 RID: 111861
		private LevelSequencePlayer BarLevelSequencePlayer;

		// Token: 0x0401B4F6 RID: 111862
		public Func<int, bool> IsLastGroup;

		// Token: 0x0200AF5C RID: 44892
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040353EB RID: 218091
			public const int LayoutGroupRow1 = 0;

			// Token: 0x040353EC RID: 218092
			public const int LayoutGroupRow2 = 1;

			// Token: 0x040353ED RID: 218093
			public const int LayoutGroupRow3 = 2;

			// Token: 0x040353EE RID: 218094
			public const int LayoutItemRow1 = 3;

			// Token: 0x040353EF RID: 218095
			public const int LayoutItemRow2 = 4;

			// Token: 0x040353F0 RID: 218096
			public const int LayoutItemRow3 = 5;

			// Token: 0x040353F1 RID: 218097
			public const int ItemLine = 6;

			// Token: 0x040353F2 RID: 218098
			public const int PanelValue = 7;

			// Token: 0x040353F3 RID: 218099
			public const int TxtMultiplier = 8;

			// Token: 0x040353F4 RID: 218100
			public const int PanelLock = 9;

			// Token: 0x040353F5 RID: 218101
			public const int SpriteLock = 10;
		}
	}
}
