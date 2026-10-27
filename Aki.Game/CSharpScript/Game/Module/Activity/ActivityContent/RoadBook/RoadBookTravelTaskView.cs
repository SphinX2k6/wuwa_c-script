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
	// Token: 0x020061EF RID: 25071
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTravelTaskView : UiViewBase
	{
		// Token: 0x0603F44B RID: 259147 RVA: 0x00F49B9B File Offset: 0x00F47D9B
		public RoadBookTravelTaskView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0603F44C RID: 259148 RVA: 0x00F49BC4 File Offset: 0x00F47DC4
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

		// Token: 0x0603F44D RID: 259149 RVA: 0x00F49C6C File Offset: 0x00F47E6C
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookTravelTaskView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookTravelTaskView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F44E RID: 259150 RVA: 0x00F49CAF File Offset: 0x00F47EAF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoadBookTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Add(EEventName.RoadBookTaskNavigationNext, new Action(this.OnRoadBookTaskNavigationNext));
		}

		// Token: 0x0603F44F RID: 259151 RVA: 0x00F49CE9 File Offset: 0x00F47EE9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoadBookTaskRefresh, new Action(this.RefreshCurrent));
			EventSystem.Instance.Remove(EEventName.RoadBookTaskNavigationNext, new Action(this.OnRoadBookTaskNavigationNext));
		}

		// Token: 0x0603F450 RID: 259152 RVA: 0x00F49D23 File Offset: 0x00F47F23
		private AreaLayout CreateAreaLayoutItem(AreaLayoutItemData data, UUIItem uiItem, int index)
		{
			return new AreaLayout(this.ActivityBaseData);
		}

		// Token: 0x0603F451 RID: 259153 RVA: 0x00F49D30 File Offset: 0x00F47F30
		private RoadBookTabDynamicScrollItem CreateTabItem(RoadBookAreaData data, UUIItem uiItem, int index)
		{
			RoadBookTabDynamicScrollItem roadBookTabDynamicScrollItem = new RoadBookTabDynamicScrollItem(this.ActivityBaseData);
			roadBookTabDynamicScrollItem.BindSelectedCallBack(new Action<RoadBookAreaData, int>(this.TabSelectedCallBack));
			roadBookTabDynamicScrollItem.BindIsSelectedOn(new Func<RoadBookAreaData, int, bool>(this.IsSelectedOn));
			return roadBookTabDynamicScrollItem;
		}

		// Token: 0x0603F452 RID: 259154 RVA: 0x00F49D61 File Offset: 0x00F47F61
		protected override void OnStart()
		{
		}

		// Token: 0x0603F453 RID: 259155 RVA: 0x00F49D64 File Offset: 0x00F47F64
		protected void OnRoadBookTaskNavigationNext()
		{
			AreaLayout scrollItemFromIndex = this.AreaLayoutList.GetScrollItemFromIndex(this.SelectedTabIndex);
			UUIItem uuiitem = (scrollItemFromIndex != null) ? scrollItemFromIndex.GetFirstItem() : null;
			if (uuiitem != null)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, false, false, false);
			}
		}

		// Token: 0x0603F454 RID: 259156 RVA: 0x00F49DA4 File Offset: 0x00F47FA4
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

		// Token: 0x0603F455 RID: 259157 RVA: 0x00F49E50 File Offset: 0x00F48050
		private UniTask Refresh()
		{
			RoadBookTravelTaskView.<Refresh>d__21 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RoadBookTravelTaskView.<Refresh>d__21>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0603F456 RID: 259158 RVA: 0x00F49E94 File Offset: 0x00F48094
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

		// Token: 0x0603F457 RID: 259159 RVA: 0x00F49F50 File Offset: 0x00F48150
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

		// Token: 0x0603F458 RID: 259160 RVA: 0x00F4A061 File Offset: 0x00F48261
		private void SelectTab(int index, bool bOn, bool bFireEvent)
		{
			RoadBookTabDynamicScrollItem scrollItemFromIndex = this.TabLayout.GetScrollItemFromIndex(index);
			if (scrollItemFromIndex == null)
			{
				return;
			}
			scrollItemFromIndex.SetSelected(bOn, bFireEvent);
		}

		// Token: 0x0603F459 RID: 259161 RVA: 0x00F4A07C File Offset: 0x00F4827C
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

		// Token: 0x0603F45A RID: 259162 RVA: 0x00F4A170 File Offset: 0x00F48370
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

		// Token: 0x0603F45B RID: 259163 RVA: 0x00F4A277 File Offset: 0x00F48477
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

		// Token: 0x0603F45C RID: 259164 RVA: 0x00F4A2AC File Offset: 0x00F484AC
		private void TabSelected(int index)
		{
			int itemIndex = this.AreaIndex2DynamicTitleIndex[index];
			base.GetUIDynScrollViewComponent(4).ScrollToItemIndex(itemIndex, true, 0f, false);
		}

		// Token: 0x0603F45D RID: 259165 RVA: 0x00F4A2DA File Offset: 0x00F484DA
		private bool IsSelectedOn(RoadBookAreaData tabData, int index)
		{
			return this.SelectedTabIndex == index;
		}

		// Token: 0x0603F45E RID: 259166 RVA: 0x00F4A2E8 File Offset: 0x00F484E8
		public UniTask PlayStartSequence()
		{
			RoadBookTravelTaskView.<PlayStartSequence>d__30 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<RoadBookTravelTaskView.<PlayStartSequence>d__30>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603F45F RID: 259167 RVA: 0x00F4A32C File Offset: 0x00F4852C
		public UniTask PlayCloseSequence()
		{
			RoadBookTravelTaskView.<PlayCloseSequence>d__31 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<RoadBookTravelTaskView.<PlayCloseSequence>d__31>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603F460 RID: 259168 RVA: 0x00F4A36F File Offset: 0x00F4856F
		private void SetDefault()
		{
			this.SelectTab(this.SelectedTabIndex, false, false);
			this.SelectedTabIndex = -1;
		}

		// Token: 0x0603F461 RID: 259169 RVA: 0x00F4A388 File Offset: 0x00F48588
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x04020FFA RID: 135162
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x04020FFB RID: 135163
		private ActivityRoadBookData ActivityBaseData;

		// Token: 0x04020FFC RID: 135164
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<AreaLayout, AreaLayoutBaseItem, AreaLayoutItemData> AreaLayoutList;

		// Token: 0x04020FFD RID: 135165
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04020FFE RID: 135166
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<RoadBookTabDynamicScrollItem, RoadBookTabDynamicItem, RoadBookAreaData> TabLayout;

		// Token: 0x04020FFF RID: 135167
		[Nullable(2)]
		private RewardPanel PanelReward;

		// Token: 0x04021000 RID: 135168
		private readonly List<float> TabAnchorOffset = new List<float>();

		// Token: 0x04021001 RID: 135169
		private int SelectedTabIndex = -1;

		// Token: 0x04021002 RID: 135170
		private bool InitRefresh;

		// Token: 0x04021003 RID: 135171
		private float MissionViewHeight;

		// Token: 0x04021004 RID: 135172
		private List<int> AreaIndex2DynamicTitleIndex = new List<int>();
	}
}
