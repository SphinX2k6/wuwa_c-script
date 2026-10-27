using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FeedbackReward
{
	// Token: 0x02005A86 RID: 23174
	[NullableContext(1)]
	[Nullable(0)]
	public class FeedbackRewardMainView : UiViewBase
	{
		// Token: 0x0603AB28 RID: 240424 RVA: 0x00DFADE9 File Offset: 0x00DF8FE9
		public FeedbackRewardMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AB29 RID: 240425 RVA: 0x00DFAE14 File Offset: 0x00DF9014
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLeftBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRightBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickDetailBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603AB2A RID: 240426 RVA: 0x00DFB0F8 File Offset: 0x00DF92F8
		protected override UniTask OnBeforeStartAsync()
		{
			FeedbackRewardMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FeedbackRewardMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AB2B RID: 240427 RVA: 0x00DFB13B File Offset: 0x00DF933B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FeedbackRewardRefresh, new Action(this.FeedbackRewardRefresh));
		}

		// Token: 0x0603AB2C RID: 240428 RVA: 0x00DFB159 File Offset: 0x00DF9359
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FeedbackRewardRefresh, new Action(this.FeedbackRewardRefresh));
		}

		// Token: 0x0603AB2D RID: 240429 RVA: 0x00DFB178 File Offset: 0x00DF9378
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.RewardScrollView = new GenericScrollViewNew<RewardItem, int>(base.GetScrollViewWithScrollbar(15), new Func<RewardItem>(this.InitRewardItem), null, false, null);
			this.TaskLayout = new GenericLayout<TaskItem, int>(base.GetVerticalLayout(12), new Func<TaskItem>(this.InitTaskItem), null, false, true);
			foreach (int num in this.ShowRewardList)
			{
				if (FeedbackRewardModel.Instance.GetFeedbackRewardState(num) != EFeedbackRewardState.Claimed)
				{
					this.CurrentShowRewardIndex = this.ShowRewardList.IndexOf(num);
					break;
				}
			}
			this.RefreshRewardPanel();
			this.RefreshRewardLayout();
			this.RefreshTaskPanel();
		}

		// Token: 0x0603AB2E RID: 240430 RVA: 0x00DFB268 File Offset: 0x00DF9468
		private RewardItem InitRewardItem()
		{
			return new RewardItem();
		}

		// Token: 0x0603AB2F RID: 240431 RVA: 0x00DFB26F File Offset: 0x00DF946F
		private TaskItem InitTaskItem()
		{
			return new TaskItem();
		}

		// Token: 0x0603AB30 RID: 240432 RVA: 0x00DFB278 File Offset: 0x00DF9478
		private void RefreshRewardPanel()
		{
			int num = this.ShowRewardList[this.CurrentShowRewardIndex];
			GivebackScoreReward? givebackScoreRewardById = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(num);
			if (givebackScoreRewardById == null)
			{
				return;
			}
			string texturePath = StringUtils.IsEmpty(givebackScoreRewardById.Value.IconLarge) ? null : givebackScoreRewardById.Value.IconLarge;
			RewardPanel rewardPanelItem = this.RewardPanelItem;
			if (rewardPanelItem != null)
			{
				rewardPanelItem.RefreshItem(texturePath, new int?(givebackScoreRewardById.Value.PlayerTitleId));
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), givebackScoreRewardById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), givebackScoreRewardById.Value.DesText, Array.Empty<object>());
			base.GetButton(3).RootUIComp.Get().SetUIActive(givebackScoreRewardById.Value.ShowType != 1);
			base.GetButton(2).RootUIComp.Get().SetUIActive(this.CurrentShowRewardIndex < this.ShowRewardList.Count - 1);
			base.GetButton(1).RootUIComp.Get().SetUIActive(this.CurrentShowRewardIndex > 0);
			foreach (PageItem pageItem in this.PageList)
			{
				pageItem.RefreshItem(this.CurrentShowRewardIndex == this.PageList.IndexOf(pageItem));
			}
			EFeedbackRewardState feedbackRewardState = FeedbackRewardModel.Instance.GetFeedbackRewardState(num);
			base.GetItem(6).SetUIActive(feedbackRewardState == EFeedbackRewardState.Finish);
			base.GetItem(7).SetUIActive(feedbackRewardState == EFeedbackRewardState.Claimed);
			GenericScrollViewNew<RewardItem, int> rewardScrollView = this.RewardScrollView;
			foreach (RewardItem rewardItem in (((rewardScrollView != null) ? rewardScrollView.GetScrollItemList() : null) ?? new List<RewardItem>()))
			{
				rewardItem.SetPreviewVisible(rewardItem.RewardId == num);
			}
		}

		// Token: 0x0603AB31 RID: 240433 RVA: 0x00DFB4B4 File Offset: 0x00DF96B4
		private void RefreshRewardLayout()
		{
			GenericScrollViewNew<RewardItem, int> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView != null)
			{
				rewardScrollView.RefreshByData(this.RewardList, delegate
				{
					GenericScrollViewNew<RewardItem, int> rewardScrollView2 = this.RewardScrollView;
					List<RewardItem> list = ((rewardScrollView2 != null) ? rewardScrollView2.GetScrollItemList() : null) ?? new List<RewardItem>();
					bool flag = false;
					foreach (RewardItem rewardItem in list)
					{
						if (FeedbackRewardModel.Instance.GetFeedbackRewardState(rewardItem.RewardId) == EFeedbackRewardState.UnFinish && !flag)
						{
							GenericScrollViewNew<RewardItem, int> rewardScrollView3 = this.RewardScrollView;
							if (rewardScrollView3 != null)
							{
								rewardScrollView3.LateScrollTo(rewardItem.GetRootItem(), null, false);
							}
							flag = true;
						}
						rewardItem.SetPreviewVisible(rewardItem.RewardId == this.ShowRewardList[this.CurrentShowRewardIndex]);
					}
				}, false);
			}
			base.GetText(14).SetText(Math.Min(FeedbackRewardModel.Instance.CurrentPointCount, FeedbackRewardModel.Instance.MaxShowScore).ToString(), true);
		}

		// Token: 0x0603AB32 RID: 240434 RVA: 0x00DFB514 File Offset: 0x00DF9714
		private void RefreshTaskPanel()
		{
			base.GetArtText(11).SetText(FeedbackRewardModel.Instance.CurrentLoginDayCount.ToString());
			List<int> feedbackTaskList = FeedbackRewardModel.Instance.GetFeedbackTaskList();
			GenericLayout<TaskItem, int> taskLayout = this.TaskLayout;
			if (taskLayout == null)
			{
				return;
			}
			taskLayout.RefreshByData(feedbackTaskList, null, false);
		}

		// Token: 0x0603AB33 RID: 240435 RVA: 0x00DFB55C File Offset: 0x00DF975C
		private void OnClickLeftBtn()
		{
			if (this.CurrentShowRewardIndex <= 0)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_Left", false, null);
			}
			this.CurrentShowRewardIndex--;
		}

		// Token: 0x0603AB34 RID: 240436 RVA: 0x00DFB5A4 File Offset: 0x00DF97A4
		private void OnClickRightBtn()
		{
			if (this.CurrentShowRewardIndex >= this.ShowRewardList.Count - 1)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_Right", false, null);
			}
			this.CurrentShowRewardIndex++;
		}

		// Token: 0x0603AB35 RID: 240437 RVA: 0x00DFB5F8 File Offset: 0x00DF97F8
		private void OnClickDetailBtn()
		{
			int id = this.ShowRewardList[this.CurrentShowRewardIndex];
			GivebackScoreReward? givebackScoreRewardById = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(id);
			if (givebackScoreRewardById == null || givebackScoreRewardById.Value.SkipParam <= 0)
			{
				return;
			}
			if (givebackScoreRewardById.Value.ShowType == 3)
			{
				ItemController.Instance.OpenTitleTipsByItemId(givebackScoreRewardById.Value.SkipParam);
				return;
			}
			if (givebackScoreRewardById.Value.ShowType == 2)
			{
				UiManager.Instance.OpenView(EUiViewName.FlySkinShowView, givebackScoreRewardById.Value.SkipParam, null);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(givebackScoreRewardById.Value.SkipParam, true, null);
		}

		// Token: 0x0603AB36 RID: 240438 RVA: 0x00DFB6C0 File Offset: 0x00DF98C0
		private void FeedbackRewardRefresh()
		{
			foreach (int num in this.ShowRewardList)
			{
				if (FeedbackRewardModel.Instance.GetFeedbackRewardState(num) != EFeedbackRewardState.Claimed)
				{
					this.CurrentShowRewardIndex = this.ShowRewardList.IndexOf(num);
					break;
				}
			}
			this.RefreshRewardPanel();
			this.RefreshRewardLayout();
		}

		// Token: 0x0603AB37 RID: 240439 RVA: 0x00DFB73C File Offset: 0x00DF993C
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Item_Switch")
			{
				this.RefreshRewardPanel();
			}
		}

		// Token: 0x0401EA3A RID: 125498
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401EA3B RID: 125499
		private readonly List<PageItem> PageList = new List<PageItem>();

		// Token: 0x0401EA3C RID: 125500
		private List<int> RewardList = new List<int>();

		// Token: 0x0401EA3D RID: 125501
		private readonly List<int> ShowRewardList = new List<int>();

		// Token: 0x0401EA3E RID: 125502
		private int CurrentShowRewardIndex;

		// Token: 0x0401EA3F RID: 125503
		[Nullable(2)]
		private RewardPanel RewardPanelItem;

		// Token: 0x0401EA40 RID: 125504
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RewardItem, int> RewardScrollView;

		// Token: 0x0401EA41 RID: 125505
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TaskItem, int> TaskLayout;

		// Token: 0x0200BCBA RID: 48314
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04038EEC RID: 233196
			CaptionItem,
			// Token: 0x04038EED RID: 233197
			LeftBtn,
			// Token: 0x04038EEE RID: 233198
			RightBtn,
			// Token: 0x04038EEF RID: 233199
			DetailBtn,
			// Token: 0x04038EF0 RID: 233200
			RewardDesText,
			// Token: 0x04038EF1 RID: 233201
			RewardNameText,
			// Token: 0x04038EF2 RID: 233202
			CanGetItem,
			// Token: 0x04038EF3 RID: 233203
			HaveGetItem,
			// Token: 0x04038EF4 RID: 233204
			PageLayout,
			// Token: 0x04038EF5 RID: 233205
			PageItem,
			// Token: 0x04038EF6 RID: 233206
			RewardRootItem,
			// Token: 0x04038EF7 RID: 233207
			DayText,
			// Token: 0x04038EF8 RID: 233208
			TaskLayout,
			// Token: 0x04038EF9 RID: 233209
			TaskItem,
			// Token: 0x04038EFA RID: 233210
			PointText,
			// Token: 0x04038EFB RID: 233211
			RewardScrollView,
			// Token: 0x04038EFC RID: 233212
			RewardItem
		}
	}
}
