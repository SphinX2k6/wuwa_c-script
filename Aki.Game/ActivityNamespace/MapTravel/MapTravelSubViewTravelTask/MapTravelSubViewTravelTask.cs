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
	// Token: 0x020044D5 RID: 17621
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelSubViewTravelTask : UiPanelBase, IMapTravelSubViewInterface
	{
		// Token: 0x170073A3 RID: 29603
		// (get) Token: 0x0602D662 RID: 185954 RVA: 0x00A3EB5B File Offset: 0x00A3CD5B
		// (set) Token: 0x0602D663 RID: 185955 RVA: 0x00A3EB63 File Offset: 0x00A3CD63
		public bool NeedDestroySelf { get; set; }

		// Token: 0x0602D664 RID: 185956 RVA: 0x00A3EB6C File Offset: 0x00A3CD6C
		public MapTravelSubViewTravelTask(ActivityMapTravelData ActivityBaseData)
		{
			this.ActivityBaseData = ActivityBaseData;
		}

		// Token: 0x0602D665 RID: 185957 RVA: 0x00A3EB90 File Offset: 0x00A3CD90
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

		// Token: 0x0602D666 RID: 185958 RVA: 0x00A3ECA0 File Offset: 0x00A3CEA0
		protected override UniTask OnBeforeStartAsync()
		{
			MapTravelSubViewTravelTask.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D667 RID: 185959 RVA: 0x00A3ECE3 File Offset: 0x00A3CEE3
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.MapTravelTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Add(EEventName.MapTravelTaskNavigationNext, new Action(this.OnMapTravelTaskNavigationNext));
		}

		// Token: 0x0602D668 RID: 185960 RVA: 0x00A3ED1D File Offset: 0x00A3CF1D
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.MapTravelTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Remove(EEventName.MapTravelTaskNavigationNext, new Action(this.OnMapTravelTaskNavigationNext));
		}

		// Token: 0x0602D669 RID: 185961 RVA: 0x00A3ED57 File Offset: 0x00A3CF57
		private AreaLayout InitItem()
		{
			return new AreaLayout(this.ActivityBaseData);
		}

		// Token: 0x0602D66A RID: 185962 RVA: 0x00A3ED64 File Offset: 0x00A3CF64
		private MapTravelTabDynamicScrollItem CreateTabItem(MapTravelAreaData data, UUIItem uiItem, int index)
		{
			MapTravelTabDynamicScrollItem mapTravelTabDynamicScrollItem = new MapTravelTabDynamicScrollItem(this.ActivityBaseData);
			mapTravelTabDynamicScrollItem.BindSelectedCallBack(new Action<MapTravelAreaData, int>(this.TabSelectedCallBack));
			mapTravelTabDynamicScrollItem.BindIsSelectedOn(new Func<MapTravelAreaData, int, bool>(this.IsSelectedOn));
			return mapTravelTabDynamicScrollItem;
		}

		// Token: 0x0602D66B RID: 185963 RVA: 0x00A3ED95 File Offset: 0x00A3CF95
		protected override void OnStart()
		{
		}

		// Token: 0x0602D66C RID: 185964 RVA: 0x00A3ED98 File Offset: 0x00A3CF98
		protected void OnMapTravelTaskNavigationNext()
		{
			UUIItem firstItem = this.AreaLayoutList.GetScrollItemByIndex(this.SelectedTabIndex).GetFirstItem();
			if (firstItem != null)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(firstItem, false, false, false);
			}
		}

		// Token: 0x0602D66D RID: 185965 RVA: 0x00A3EDD0 File Offset: 0x00A3CFD0
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

		// Token: 0x0602D66E RID: 185966 RVA: 0x00A3EE40 File Offset: 0x00A3D040
		private UniTask Refresh()
		{
			MapTravelSubViewTravelTask.<Refresh>d__24 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<Refresh>d__24>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0602D66F RID: 185967 RVA: 0x00A3EE84 File Offset: 0x00A3D084
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

		// Token: 0x0602D670 RID: 185968 RVA: 0x00A3EFA2 File Offset: 0x00A3D1A2
		private void SelectTab(int index, bool bOn, bool bFireEvent)
		{
			MapTravelTabDynamicScrollItem scrollItemFromIndex = this.TabLayout.GetScrollItemFromIndex(index);
			if (scrollItemFromIndex == null)
			{
				return;
			}
			scrollItemFromIndex.SetSelected(bOn, bFireEvent);
		}

		// Token: 0x0602D671 RID: 185969 RVA: 0x00A3EFBC File Offset: 0x00A3D1BC
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

		// Token: 0x0602D672 RID: 185970 RVA: 0x00A3F09A File Offset: 0x00A3D29A
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

		// Token: 0x0602D673 RID: 185971 RVA: 0x00A3F0D0 File Offset: 0x00A3D2D0
		private void TabSelected(int index)
		{
			int num = Math.Max(this.TabAnchorOffset[index], 0);
			base.GetItem(6).SetAnchorOffsetY((float)num);
		}

		// Token: 0x0602D674 RID: 185972 RVA: 0x00A3F0FE File Offset: 0x00A3D2FE
		private bool IsSelectedOn(MapTravelAreaData tabData, int index)
		{
			return this.SelectedTabIndex == index;
		}

		// Token: 0x0602D675 RID: 185973 RVA: 0x00A3F10C File Offset: 0x00A3D30C
		public UniTask PlayStartSequence()
		{
			MapTravelSubViewTravelTask.<PlayStartSequence>d__31 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<PlayStartSequence>d__31>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602D676 RID: 185974 RVA: 0x00A3F150 File Offset: 0x00A3D350
		public UniTask PlayCloseSequence()
		{
			MapTravelSubViewTravelTask.<PlayCloseSequence>d__32 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewTravelTask.<PlayCloseSequence>d__32>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602D677 RID: 185975 RVA: 0x00A3F193 File Offset: 0x00A3D393
		private void SetDefault()
		{
			this.SelectTab(this.SelectedTabIndex, false, false);
			this.SelectedTabIndex = -1;
		}

		// Token: 0x0401847E RID: 99454
		private const int LAYOUT_PADDING = 20;

		// Token: 0x0401847F RID: 99455
		protected ActivityMapTravelData ActivityBaseData;

		// Token: 0x04018481 RID: 99457
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<AreaLayout, MapTravelAreaData> AreaLayoutList;

		// Token: 0x04018482 RID: 99458
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018483 RID: 99459
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<MapTravelTabDynamicScrollItem, MapTravelTabDynamicItem, MapTravelAreaData> TabLayout;

		// Token: 0x04018484 RID: 99460
		[Nullable(2)]
		private RewardPanel PanelReward;

		// Token: 0x04018485 RID: 99461
		private readonly List<int> TabAnchorOffset = new List<int>();

		// Token: 0x04018486 RID: 99462
		private int SelectedTabIndex = -1;

		// Token: 0x04018487 RID: 99463
		private bool InitRefresh;

		// Token: 0x0200A71B RID: 42779
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04032779 RID: 206713
			public const int PanelTop = 0;

			// Token: 0x0403277A RID: 206714
			public const int TabLayout = 1;

			// Token: 0x0403277B RID: 206715
			public const int TabItem = 2;

			// Token: 0x0403277C RID: 206716
			public const int ContentLayout = 3;

			// Token: 0x0403277D RID: 206717
			public const int ContentItem = 4;

			// Token: 0x0403277E RID: 206718
			public const int OccupiedItem = 5;

			// Token: 0x0403277F RID: 206719
			public const int Content = 6;
		}
	}
}
