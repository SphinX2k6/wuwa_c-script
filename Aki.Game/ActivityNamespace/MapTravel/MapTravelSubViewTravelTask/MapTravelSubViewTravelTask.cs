using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewTravelTask
{
	// Token: 0x02002F62 RID: 12130
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelSubViewTravelTask : UiPanelBase, IMapTravelSubViewInterface
	{
		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0601CBA0 RID: 117664 RVA: 0x008C47BB File Offset: 0x008C29BB
		// (set) Token: 0x0601CBA1 RID: 117665 RVA: 0x008C47C3 File Offset: 0x008C29C3
		public bool NeedDestroySelf { get; set; }

		// Token: 0x0601CBA2 RID: 117666 RVA: 0x008C47CC File Offset: 0x008C29CC
		public MapTravelSubViewTravelTask(ActivityMapTravelData ActivityBaseData)
		{
			this.ActivityBaseData = ActivityBaseData;
		}

		// Token: 0x0601CBA3 RID: 117667 RVA: 0x008C47F0 File Offset: 0x008C29F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601CBA4 RID: 117668 RVA: 0x008C4900 File Offset: 0x008C2B00
		protected override UniTask OnBeforeStartAsync()
		{
			MapTravelSubViewTravelTask.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBA5 RID: 117669 RVA: 0x008C4943 File Offset: 0x008C2B43
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.MapTravelTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Add(EEventName.MapTravelTaskNavigationNext, new Action(this.OnMapTravelTaskNavigationNext));
		}

		// Token: 0x0601CBA6 RID: 117670 RVA: 0x008C497D File Offset: 0x008C2B7D
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.MapTravelTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Remove(EEventName.MapTravelTaskNavigationNext, new Action(this.OnMapTravelTaskNavigationNext));
		}

		// Token: 0x0601CBA7 RID: 117671 RVA: 0x008C49B7 File Offset: 0x008C2BB7
		private AreaLayout InitItem()
		{
			return new AreaLayout(this.ActivityBaseData);
		}

		// Token: 0x0601CBA8 RID: 117672 RVA: 0x008C49C4 File Offset: 0x008C2BC4
		private MapTravelTabDynamicScrollItem CreateTabItem(MapTravelAreaData data, UUIItem uiItem, int index)
		{
			MapTravelTabDynamicScrollItem mapTravelTabDynamicScrollItem = new MapTravelTabDynamicScrollItem(this.ActivityBaseData);
			mapTravelTabDynamicScrollItem.BindSelectedCallBack(new Action<MapTravelAreaData, int>(this.TabSelectedCallBack));
			mapTravelTabDynamicScrollItem.BindIsSelectedOn(new Func<MapTravelAreaData, int, bool>(this.IsSelectedOn));
			return mapTravelTabDynamicScrollItem;
		}

		// Token: 0x0601CBA9 RID: 117673 RVA: 0x008C49F5 File Offset: 0x008C2BF5
		protected override void OnStart()
		{
		}

		// Token: 0x0601CBAA RID: 117674 RVA: 0x008C49F8 File Offset: 0x008C2BF8
		protected void OnMapTravelTaskNavigationNext()
		{
			UUIItem firstItem = this.AreaLayoutList.GetScrollItemByIndex(this.SelectedTabIndex).GetFirstItem();
			if (firstItem != null)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(firstItem, false, false, false);
			}
		}

		// Token: 0x0601CBAB RID: 117675 RVA: 0x008C4A30 File Offset: 0x008C2C30
		protected void RefreshCurrent()
		{
			RewardPanel panelReward = this.PanelReward;
			if (panelReward != null)
			{
				panelReward.Refresh();
			}
			List<MapTravelAreaData> list = this.ActivityBaseData.GetAllAreaData().FindAll((MapTravelAreaData data) => data.TravelTaskIdSet.Count > 0);
			this.TabLayout.RefreshByData(list.ToArray(), true, false);
			this.AreaLayoutList.RefreshByDataAsync(list, true);
		}

		// Token: 0x0601CBAC RID: 117676 RVA: 0x008C4AA0 File Offset: 0x008C2CA0
		private UniTask Refresh()
		{
			MapTravelSubViewTravelTask.<Refresh>d__24 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<Refresh>d__24>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBAD RID: 117677 RVA: 0x008C4AE4 File Offset: 0x008C2CE4
		private void InitViewRelation(List<MapTravelAreaData> areaDataList)
		{
			this.TabAnchorOffset.Clear();
			float height = base.GetScrollViewWithScrollbar(3).RootUIComp.Get().GetHeight();
			List<AreaLayout> scrollItemList = this.AreaLayoutList.GetScrollItemList();
			float num = 0f;
			float num2 = 0f;
			this.TabAnchorOffset.Add(-2147483647);
			for (int i = 0; i < scrollItemList.Count; i++)
			{
				if (i == scrollItemList.Count - 1)
				{
					num += scrollItemList[i].GetRootItem().GetHeight();
					num2 = scrollItemList[i].GetRootItem().GetHeight();
				}
				else
				{
					num += scrollItemList[i].GetRootItem().GetHeight() + 20f;
					this.TabAnchorOffset.Add((int)num);
				}
			}
			this.TabAnchorOffset.Add(int.MaxValue);
			if (num2 >= height)
			{
				float height2 = num2 % height;
				base.GetItem(5).SetHeight(height2);
			}
			else
			{
				float height3 = height - num2;
				base.GetItem(5).SetHeight(height3);
			}
			base.GetItem(5).SetHierarchyIndex(areaDataList.Count + 1);
		}

		// Token: 0x0601CBAE RID: 117678 RVA: 0x008C4C02 File Offset: 0x008C2E02
		private void SelectTab(int index, bool bOn, bool bFireEvent)
		{
			MapTravelTabDynamicScrollItem scrollItemFromIndex = this.TabLayout.GetScrollItemFromIndex(index);
			if (scrollItemFromIndex == null)
			{
				return;
			}
			scrollItemFromIndex.SetSelected(bOn, bFireEvent);
		}

		// Token: 0x0601CBAF RID: 117679 RVA: 0x008C4C1C File Offset: 0x008C2E1C
		private void OnContentUpdate(FVector2D _)
		{
			if (this.InitRefresh)
			{
				return;
			}
			float anchorOffsetY = base.GetItem(6).GetAnchorOffsetY();
			int displayGridStartIndex = this.TabLayout.GetDisplayGridStartIndex();
			int displayGridEndIndex = this.TabLayout.GetDisplayGridEndIndex();
			int i = 0;
			while (i < this.TabAnchorOffset.Count - 1)
			{
				if ((float)this.TabAnchorOffset[i] <= anchorOffsetY && anchorOffsetY < (float)this.TabAnchorOffset[i + 1])
				{
					if (i == this.SelectedTabIndex)
					{
						return;
					}
					this.SelectTab(this.SelectedTabIndex, false, false);
					if (i < displayGridStartIndex || i > displayGridEndIndex)
					{
						float scrollProgress = (i == 0) ? 0f : ((float)(i + 1) / (float)(this.TabAnchorOffset.Count - 1));
						base.GetUIDynScrollViewComponent(1).SetScrollProgress(scrollProgress);
					}
					this.SelectedTabIndex = i;
					this.SelectTab(this.SelectedTabIndex, true, false);
					return;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x0601CBB0 RID: 117680 RVA: 0x008C4CFA File Offset: 0x008C2EFA
		private void TabSelectedCallBack(MapTravelAreaData tabData, int index)
		{
			if (index != this.SelectedTabIndex)
			{
				this.SelectTab(this.SelectedTabIndex, false, false);
			}
			this.SelectedTabIndex = index;
			base.GetScrollViewWithScrollbar(3).StopMovement();
			this.TabSelected(index);
		}

		// Token: 0x0601CBB1 RID: 117681 RVA: 0x008C4D30 File Offset: 0x008C2F30
		private void TabSelected(int index)
		{
			int num = Math.Max(this.TabAnchorOffset[index], 0);
			base.GetItem(6).SetAnchorOffsetY((float)num);
		}

		// Token: 0x0601CBB2 RID: 117682 RVA: 0x008C4D5E File Offset: 0x008C2F5E
		private bool IsSelectedOn(MapTravelAreaData tabData, int index)
		{
			return this.SelectedTabIndex == index;
		}

		// Token: 0x0601CBB3 RID: 117683 RVA: 0x008C4D6C File Offset: 0x008C2F6C
		public UniTask PlayStartSequence()
		{
			MapTravelSubViewTravelTask.<PlayStartSequence>d__31 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<PlayStartSequence>d__31>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBB4 RID: 117684 RVA: 0x008C4DB0 File Offset: 0x008C2FB0
		public UniTask PlayCloseSequence()
		{
			MapTravelSubViewTravelTask.<PlayCloseSequence>d__32 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<PlayCloseSequence>d__32>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBB5 RID: 117685 RVA: 0x008C4DF3 File Offset: 0x008C2FF3
		private void SetDefault()
		{
			this.SelectTab(this.SelectedTabIndex, false, false);
			this.SelectedTabIndex = -1;
		}

		// Token: 0x0400F226 RID: 61990
		private const int LAYOUT_PADDING = 20;

		// Token: 0x0400F227 RID: 61991
		protected ActivityMapTravelData ActivityBaseData;

		// Token: 0x0400F229 RID: 61993
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<AreaLayout, MapTravelAreaData> AreaLayoutList;

		// Token: 0x0400F22A RID: 61994
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0400F22B RID: 61995
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<MapTravelTabDynamicScrollItem, MapTravelTabDynamicItem, MapTravelAreaData> TabLayout;

		// Token: 0x0400F22C RID: 61996
		[Nullable(2)]
		private RewardPanel PanelReward;

		// Token: 0x0400F22D RID: 61997
		private readonly List<int> TabAnchorOffset = new List<int>();

		// Token: 0x0400F22E RID: 61998
		private int SelectedTabIndex = -1;

		// Token: 0x0400F22F RID: 61999
		private bool InitRefresh;

		// Token: 0x02008BF1 RID: 35825
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402C547 RID: 181575
			public const int PanelTop = 0;

			// Token: 0x0402C548 RID: 181576
			public const int TabLayout = 1;

			// Token: 0x0402C549 RID: 181577
			public const int TabItem = 2;

			// Token: 0x0402C54A RID: 181578
			public const int ContentLayout = 3;

			// Token: 0x0402C54B RID: 181579
			public const int ContentItem = 4;

			// Token: 0x0402C54C RID: 181580
			public const int OccupiedItem = 5;

			// Token: 0x0402C54D RID: 181581
			public const int Content = 6;
		}
	}
}
