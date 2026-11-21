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
	// Token: 0x02004A62 RID: 19042
	[NullableContext(1)]
	[Nullable(0)]
	public class FeedbackRewardMainView : UiViewBase
	{
		// Token: 0x0602FA71 RID: 195185 RVA: 0x00D4B37D File Offset: 0x00D4957D
		public FeedbackRewardMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FA72 RID: 195186 RVA: 0x00D4B3A8 File Offset: 0x00D495A8
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

		// Token: 0x0602FA73 RID: 195187 RVA: 0x00D4B68C File Offset: 0x00D4988C
		protected override UniTask OnBeforeStartAsync()
		{
			FeedbackRewardMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FeedbackRewardMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA74 RID: 195188 RVA: 0x00D4B6CF File Offset: 0x00D498CF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FeedbackRewardRefresh, new Action(this.FeedbackRewardRefresh));
		}

		// Token: 0x0602FA75 RID: 195189 RVA: 0x00D4B6ED File Offset: 0x00D498ED
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FeedbackRewardRefresh, new Action(this.FeedbackRewardRefresh));
		}

		// Token: 0x0602FA76 RID: 195190 RVA: 0x00D4B70C File Offset: 0x00D4990C
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

		// Token: 0x0602FA77 RID: 195191 RVA: 0x00D4B7FC File Offset: 0x00D499FC
		private RewardItem InitRewardItem()
		{
			return new RewardItem();
		}

		// Token: 0x0602FA78 RID: 195192 RVA: 0x00D4B803 File Offset: 0x00D49A03
		private TaskItem InitTaskItem()
		{
			return new TaskItem();
		}

		// Token: 0x0602FA79 RID: 195193 RVA: 0x00D4B80C File Offset: 0x00D49A0C
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

		// Token: 0x0602FA7A RID: 195194 RVA: 0x00D4BA48 File Offset: 0x00D49C48
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

		// Token: 0x0602FA7B RID: 195195 RVA: 0x00D4BAA8 File Offset: 0x00D49CA8
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

		// Token: 0x0602FA7C RID: 195196 RVA: 0x00D4BAF0 File Offset: 0x00D49CF0
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

		// Token: 0x0602FA7D RID: 195197 RVA: 0x00D4BB38 File Offset: 0x00D49D38
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

		// Token: 0x0602FA7E RID: 195198 RVA: 0x00D4BB8C File Offset: 0x00D49D8C
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
			ItemController.Instance.OpenItemTipsByItemId(givebackScoreRewardById.Value.SkipParam, true, null, false);
		}

		// Token: 0x0602FA7F RID: 195199 RVA: 0x00D4BC54 File Offset: 0x00D49E54
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

		// Token: 0x0602FA80 RID: 195200 RVA: 0x00D4BCD0 File Offset: 0x00D49ED0
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Item_Switch")
			{
				this.RefreshRewardPanel();
			}
		}

		// Token: 0x040194E1 RID: 103649
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040194E2 RID: 103650
		private readonly List<PageItem> PageList = new List<PageItem>();

		// Token: 0x040194E3 RID: 103651
		private List<int> RewardList = new List<int>();

		// Token: 0x040194E4 RID: 103652
		private readonly List<int> ShowRewardList = new List<int>();

		// Token: 0x040194E5 RID: 103653
		private int CurrentShowRewardIndex;

		// Token: 0x040194E6 RID: 103654
		[Nullable(2)]
		private RewardPanel RewardPanelItem;

		// Token: 0x040194E7 RID: 103655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RewardItem, int> RewardScrollView;

		// Token: 0x040194E8 RID: 103656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TaskItem, int> TaskLayout;

		// Token: 0x0200A6C3 RID: 42691
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x040338B7 RID: 211127
			CaptionItem,
			// Token: 0x040338B8 RID: 211128
			LeftBtn,
			// Token: 0x040338B9 RID: 211129
			RightBtn,
			// Token: 0x040338BA RID: 211130
			DetailBtn,
			// Token: 0x040338BB RID: 211131
			RewardDesText,
			// Token: 0x040338BC RID: 211132
			RewardNameText,
			// Token: 0x040338BD RID: 211133
			CanGetItem,
			// Token: 0x040338BE RID: 211134
			HaveGetItem,
			// Token: 0x040338BF RID: 211135
			PageLayout,
			// Token: 0x040338C0 RID: 211136
			PageItem,
			// Token: 0x040338C1 RID: 211137
			RewardRootItem,
			// Token: 0x040338C2 RID: 211138
			DayText,
			// Token: 0x040338C3 RID: 211139
			TaskLayout,
			// Token: 0x040338C4 RID: 211140
			TaskItem,
			// Token: 0x040338C5 RID: 211141
			PointText,
			// Token: 0x040338C6 RID: 211142
			RewardScrollView,
			// Token: 0x040338C7 RID: 211143
			RewardItem
		}
	}
}
