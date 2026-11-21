using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200516D RID: 20845
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTravelTaskView : UiViewBase
	{
		// Token: 0x0603410C RID: 213260 RVA: 0x00E90AF3 File Offset: 0x00E8ECF3
		public RoadBookTravelTaskView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0603410D RID: 213261 RVA: 0x00E90B1C File Offset: 0x00E8ED1C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIDynScrollViewComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIDynScrollViewComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0603410E RID: 213262 RVA: 0x00E90BC4 File Offset: 0x00E8EDC4
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookTravelTaskView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookTravelTaskView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603410F RID: 213263 RVA: 0x00E90C07 File Offset: 0x00E8EE07
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoadBookTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Add(EEventName.RoadBookTaskNavigationNext, new Action(this.OnRoadBookTaskNavigationNext));
		}

		// Token: 0x06034110 RID: 213264 RVA: 0x00E90C41 File Offset: 0x00E8EE41
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoadBookTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Remove(EEventName.RoadBookTaskNavigationNext, new Action(this.OnRoadBookTaskNavigationNext));
		}

		// Token: 0x06034111 RID: 213265 RVA: 0x00E90C7B File Offset: 0x00E8EE7B
		private AreaLayout CreateAreaLayoutItem(AreaLayoutItemData data, UUIItem uiItem, int index)
		{
			return new AreaLayout(this.ActivityBaseData);
		}

		// Token: 0x06034112 RID: 213266 RVA: 0x00E90C88 File Offset: 0x00E8EE88
		private RoadBookTabDynamicScrollItem CreateTabItem(RoadBookAreaData data, UUIItem uiItem, int index)
		{
			RoadBookTabDynamicScrollItem roadBookTabDynamicScrollItem = new RoadBookTabDynamicScrollItem(this.ActivityBaseData);
			roadBookTabDynamicScrollItem.BindSelectedCallBack(new Action<RoadBookAreaData, int>(this.TabSelectedCallBack));
			roadBookTabDynamicScrollItem.BindIsSelectedOn(new Func<RoadBookAreaData, int, bool>(this.IsSelectedOn));
			return roadBookTabDynamicScrollItem;
		}

		// Token: 0x06034113 RID: 213267 RVA: 0x00E90CB9 File Offset: 0x00E8EEB9
		protected override void OnStart()
		{
		}

		// Token: 0x06034114 RID: 213268 RVA: 0x00E90CBC File Offset: 0x00E8EEBC
		protected void OnRoadBookTaskNavigationNext()
		{
			AreaLayout scrollItemFromIndex = this.AreaLayoutList.GetScrollItemFromIndex(this.SelectedTabIndex);
			UUIItem uuiitem = (scrollItemFromIndex != null) ? scrollItemFromIndex.GetFirstItem() : null;
			if (uuiitem != null)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, false, false, false);
			}
		}

		// Token: 0x06034115 RID: 213269 RVA: 0x00E90CFC File Offset: 0x00E8EEFC
		protected void RefreshCurrent()
		{
			RewardPanel panelReward = this.PanelReward;
			if (panelReward != null)
			{
				panelReward.Refresh();
			}
			List<RoadBookAreaData> list = new List<RoadBookAreaData>();
			foreach (RoadBookAreaData roadBookAreaData in this.ActivityBaseData.GetAllAreaData())
			{
				if (roadBookAreaData.TravelTaskIdSet.Count > 0)
				{
					list.Add(roadBookAreaData);
				}
			}
			this.TabLayout.RefreshByData(list.ToArray(), false, false);
			List<AreaLayoutItemData> flatData = this.GetFlatData(list);
			this.AreaLayoutList.RefreshByData(flatData.ToArray(), false, false);
		}

		// Token: 0x06034116 RID: 213270 RVA: 0x00E90DA8 File Offset: 0x00E8EFA8
		private UniTask Refresh()
		{
			RoadBookTravelTaskView.<Refresh>d__21 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RoadBookTravelTaskView.<Refresh>d__21>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x06034117 RID: 213271 RVA: 0x00E90DEC File Offset: 0x00E8EFEC
		private List<AreaLayoutItemData> GetFlatData(List<RoadBookAreaData> areaDataList)
		{
			List<AreaLayoutItemData> list = new List<AreaLayoutItemData>();
			foreach (RoadBookAreaData roadBookAreaData in areaDataList)
			{
				list.Add(new AreaLayoutItemData(true, roadBookAreaData, null));
				if (roadBookAreaData.IsUnlock)
				{
					foreach (ActivityTaskData taskData in this.ActivityBaseData.GetAreaTaskDataList(roadBookAreaData.AreaId))
					{
						list.Add(new AreaLayoutItemData(false, roadBookAreaData, taskData));
					}
				}
			}
			return list;
		}

		// Token: 0x06034118 RID: 213272 RVA: 0x00E90EA8 File Offset: 0x00E8F0A8
		private void InitViewRelation(List<AreaLayoutItemData> flatDataList)
		{
			this.TabAnchorOffset.Clear();
			float height = base.GetUIDynScrollViewComponent(4).RootUIComp.Get().GetHeight();
			float spacingVertical = base.GetUIDynScrollViewComponent(4).SpacingVertical;
			float num = 0f;
			float num2 = 0f;
			this.TabAnchorOffset.Add(-2.1474836E+09f);
			for (int i = 0; i < flatDataList.Count; i++)
			{
				float y = this.AreaLayoutList.GetItemSizeFromData(flatDataList[i]).Y;
				if (i == flatDataList.Count - 1)
				{
					num += y;
					num2 += y;
				}
				else
				{
					num += y + spacingVertical;
					num2 += y + spacingVertical;
				}
				if (i > 0 && flatDataList[i].IsTitle)
				{
					this.TabAnchorOffset.Add(num - y);
					num2 = y;
				}
			}
			this.TabAnchorOffset.Add(2.1474836E+09f);
			if (num2 < height)
			{
				float value = height - num2;
				flatDataList[flatDataList.Count - 1].ExtraHeight = new float?(value);
			}
			this.MissionViewHeight = height;
		}

		// Token: 0x06034119 RID: 213273 RVA: 0x00E90FB9 File Offset: 0x00E8F1B9
		private void SelectTab(int index, bool bOn, bool bFireEvent)
		{
			RoadBookTabDynamicScrollItem scrollItemFromIndex = this.TabLayout.GetScrollItemFromIndex(index);
			if (scrollItemFromIndex == null)
			{
				return;
			}
			scrollItemFromIndex.SetSelected(bOn, bFireEvent);
		}

		// Token: 0x0603411A RID: 213274 RVA: 0x00E90FD4 File Offset: 0x00E8F1D4
		private void OnContentUpdate(FVector2D _)
		{
			if (this.InitRefresh)
			{
				return;
			}
			int displayGridStartIndex = this.TabLayout.GetDisplayGridStartIndex();
			int displayGridEndIndex = this.TabLayout.GetDisplayGridEndIndex();
			int num = this.FindTargetTabIndex();
			if (num != -1)
			{
				this.SelectTab(this.SelectedTabIndex, false, false);
				UUIDynScrollViewComponent uidynScrollViewComponent = base.GetUIDynScrollViewComponent(2);
				float anchorOffsetY = uidynScrollViewComponent.ContentUIItem.Get().GetAnchorOffsetY();
				float num2 = anchorOffsetY + uidynScrollViewComponent.RootUIComp.Get().Height;
				UUIItem grid = this.TabLayout.GetGrid(num);
				float anchorOffsetY2 = grid.GetAnchorOffsetY();
				if (num < displayGridStartIndex || num > displayGridEndIndex || -anchorOffsetY2 + grid.GetHeight() > num2 || -anchorOffsetY2 < anchorOffsetY)
				{
					float scrollProgress = (num == 0) ? 0f : ((float)(num + 1) / (float)(this.TabAnchorOffset.Count - 1));
					uidynScrollViewComponent.SetScrollProgress(scrollProgress);
				}
				this.SelectedTabIndex = num;
				this.SelectTab(this.SelectedTabIndex, true, false);
			}
		}

		// Token: 0x0603411B RID: 213275 RVA: 0x00E910C8 File Offset: 0x00E8F2C8
		private int FindTargetTabIndex()
		{
			float anchorOffsetY = base.GetUIDynScrollViewComponent(4).ContentUIItem.Get().GetAnchorOffsetY();
			if (this.TabAnchorOffset[this.SelectedTabIndex] < anchorOffsetY + this.MissionViewHeight && this.TabAnchorOffset[this.SelectedTabIndex + 1] > anchorOffsetY)
			{
				return -1;
			}
			int result = -1;
			if (((anchorOffsetY > this.TabAnchorOffset[this.SelectedTabIndex]) ? 1 : -1) > 0)
			{
				for (int i = this.SelectedTabIndex + 1; i < this.TabAnchorOffset.Count; i++)
				{
					if (this.TabAnchorOffset[i] <= anchorOffsetY + this.MissionViewHeight && anchorOffsetY < this.TabAnchorOffset[i + 1])
					{
						result = i;
						break;
					}
				}
			}
			else
			{
				for (int j = this.SelectedTabIndex - 1; j >= 0; j--)
				{
					if (this.TabAnchorOffset[j] <= anchorOffsetY + this.MissionViewHeight && anchorOffsetY < this.TabAnchorOffset[j + 1])
					{
						result = j;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0603411C RID: 213276 RVA: 0x00E911CF File Offset: 0x00E8F3CF
		private void TabSelectedCallBack(RoadBookAreaData tabData, int index)
		{
			if (index != this.SelectedTabIndex)
			{
				this.SelectTab(this.SelectedTabIndex, false, false);
			}
			this.SelectedTabIndex = index;
			base.GetUIDynScrollViewComponent(4).StopMovement();
			this.TabSelected(index);
		}

		// Token: 0x0603411D RID: 213277 RVA: 0x00E91204 File Offset: 0x00E8F404
		private void TabSelected(int index)
		{
			int itemIndex = this.AreaIndex2DynamicTitleIndex[index];
			base.GetUIDynScrollViewComponent(4).ScrollToItemIndex(itemIndex, true, 0f, false);
		}

		// Token: 0x0603411E RID: 213278 RVA: 0x00E91232 File Offset: 0x00E8F432
		private bool IsSelectedOn(RoadBookAreaData tabData, int index)
		{
			return this.SelectedTabIndex == index;
		}

		// Token: 0x0603411F RID: 213279 RVA: 0x00E91240 File Offset: 0x00E8F440
		public UniTask PlayStartSequence()
		{
			RoadBookTravelTaskView.<PlayStartSequence>d__30 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<RoadBookTravelTaskView.<PlayStartSequence>d__30>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06034120 RID: 213280 RVA: 0x00E91284 File Offset: 0x00E8F484
		public UniTask PlayCloseSequence()
		{
			RoadBookTravelTaskView.<PlayCloseSequence>d__31 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<RoadBookTravelTaskView.<PlayCloseSequence>d__31>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06034121 RID: 213281 RVA: 0x00E912C7 File Offset: 0x00E8F4C7
		private void SetDefault()
		{
			this.SelectTab(this.SelectedTabIndex, false, false);
			this.SelectedTabIndex = -1;
		}

		// Token: 0x06034122 RID: 213282 RVA: 0x00E912E0 File Offset: 0x00E8F4E0
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0401B929 RID: 112937
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401B92A RID: 112938
		private ActivityRoadBookData ActivityBaseData;

		// Token: 0x0401B92B RID: 112939
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<AreaLayout, AreaLayoutBaseItem, AreaLayoutItemData> AreaLayoutList;

		// Token: 0x0401B92C RID: 112940
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B92D RID: 112941
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<RoadBookTabDynamicScrollItem, RoadBookTabDynamicItem, RoadBookAreaData> TabLayout;

		// Token: 0x0401B92E RID: 112942
		[Nullable(2)]
		private RewardPanel PanelReward;

		// Token: 0x0401B92F RID: 112943
		private readonly List<float> TabAnchorOffset = new List<float>();

		// Token: 0x0401B930 RID: 112944
		private int SelectedTabIndex = -1;

		// Token: 0x0401B931 RID: 112945
		private bool InitRefresh;

		// Token: 0x0401B932 RID: 112946
		private float MissionViewHeight;

		// Token: 0x0401B933 RID: 112947
		private List<int> AreaIndex2DynamicTitleIndex = new List<int>();
	}
}
