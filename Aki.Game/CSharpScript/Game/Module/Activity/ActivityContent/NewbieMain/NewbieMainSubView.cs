using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x02006388 RID: 25480
	[NullableContext(1)]
	[Nullable(0)]
	public class NewbieMainSubView : ActivitySubViewBase
	{
		// Token: 0x06040122 RID: 262434 RVA: 0x00F80900 File Offset: 0x00F7EB00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040123 RID: 262435 RVA: 0x00F80A30 File Offset: 0x00F7EC30
		protected override UniTask OnBeforeStartAsync()
		{
			NewbieMainSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewbieMainSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040124 RID: 262436 RVA: 0x00F80A73 File Offset: 0x00F7EC73
		private NewbieMainRewardItem CreateRewardItem()
		{
			NewbieMainRewardItem newbieMainRewardItem = new NewbieMainRewardItem();
			newbieMainRewardItem.SetClickCallback(delegate(NewbieMainRewardItemData data)
			{
				this.GetRewardAsync(data);
			});
			return newbieMainRewardItem;
		}

		// Token: 0x06040125 RID: 262437 RVA: 0x00F80A8C File Offset: 0x00F7EC8C
		private NewbieMainTabItem CreateTabItem()
		{
			return new NewbieMainTabItem
			{
				OnClickTab = new Action<NewbieMainTabItemData>(this.OnClickTabCard)
			};
		}

		// Token: 0x06040126 RID: 262438 RVA: 0x00F80AA5 File Offset: 0x00F7ECA5
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnNewbieMainTaskUpdate, new Action(this.OnNewbieMainTaskUpdateHandler));
		}

		// Token: 0x06040127 RID: 262439 RVA: 0x00F80AC9 File Offset: 0x00F7ECC9
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnNewbieMainTaskUpdate, new Action(this.OnNewbieMainTaskUpdateHandler));
		}

		// Token: 0x06040128 RID: 262440 RVA: 0x00F80AED File Offset: 0x00F7ECED
		protected override void OnSequenceStart(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				GenericScrollViewNew<NewbieMainTabItem, NewbieMainTabItemData> tabScrollView = this.TabScrollView;
				if (tabScrollView == null)
				{
					return;
				}
				tabScrollView.PlayTurnAnimation();
			}
		}

		// Token: 0x06040129 RID: 262441 RVA: 0x00F80B0C File Offset: 0x00F7ED0C
		private void OnNewbieMainTaskUpdateHandler()
		{
			this.OnRefreshView();
		}

		// Token: 0x0604012A RID: 262442 RVA: 0x00F80B14 File Offset: 0x00F7ED14
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x0604012B RID: 262443 RVA: 0x00F80B1C File Offset: 0x00F7ED1C
		protected override void OnRefreshView()
		{
			if (this.ActivityBaseData == null)
			{
				return;
			}
			this.RefreshTitleText();
			this.RefreshActivityDescText();
			this.RefreshTimerText();
			this.UpdateTabDataList();
			this.UpdateRewardDataList();
			this.RefreshTabList();
			this.RefreshRewardList();
			this.RefreshCompletedCount();
		}

		// Token: 0x0604012C RID: 262444 RVA: 0x00F80B58 File Offset: 0x00F7ED58
		private void RefreshTitleText()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			string text = (activityBaseData != null) ? ((activityBaseData.LocalConfig != null) ? activityBaseData.LocalConfig.GetValueOrDefault().Title : null) : null;
			if (text != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), text, Array.Empty<object>());
			}
		}

		// Token: 0x0604012D RID: 262445 RVA: 0x00F80BAC File Offset: 0x00F7EDAC
		private void RefreshActivityDescText()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			string text = (activityBaseData != null) ? ((activityBaseData.LocalConfig != null) ? activityBaseData.LocalConfig.GetValueOrDefault().Desc : null) : null;
			if (text != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), text, Array.Empty<object>());
			}
		}

		// Token: 0x0604012E RID: 262446 RVA: 0x00F80C00 File Offset: 0x00F7EE00
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			base.GetText(7).SetUIActive(item);
			if (item)
			{
				base.GetText(7).SetText(item2, true);
			}
		}

		// Token: 0x0604012F RID: 262447 RVA: 0x00F80C3E File Offset: 0x00F7EE3E
		private void RefreshTabList()
		{
			GenericScrollViewNew<NewbieMainTabItem, NewbieMainTabItemData> tabScrollView = this.TabScrollView;
			if (tabScrollView == null)
			{
				return;
			}
			tabScrollView.RefreshByData(this.TabDataList, null, false);
		}

		// Token: 0x06040130 RID: 262448 RVA: 0x00F80C58 File Offset: 0x00F7EE58
		private List<NewbieMainTabItemData> BuildTabDisplayDataList()
		{
			if (this.ActivityBaseData == null)
			{
				return new List<NewbieMainTabItemData>();
			}
			NewbieMainData newbieMainData = this.ActivityBaseData as NewbieMainData;
			if (newbieMainData == null)
			{
				return new List<NewbieMainTabItemData>();
			}
			List<NewbieMainTabItemData> list = new List<NewbieMainTabItemData>();
			foreach (KeyValuePair<int, NewbieMainTabData> keyValuePair in newbieMainData.GetAllTabData())
			{
				int key = keyValuePair.Key;
				NewbieMainTabData value = keyValuePair.Value;
				NewbieMainActTab? tabById = NewbieMainConfig.Instance.GetTabById(key);
				if (tabById != null)
				{
					list.Add(new NewbieMainTabItemData
					{
						TabData = value,
						TabConfig = tabById.Value,
						ProgressingTask = null,
						State = ENewbieMainTabState.Lock,
						IsNew = false
					});
				}
			}
			list.Sort(delegate(NewbieMainTabItemData a, NewbieMainTabItemData b)
			{
				if (a.TabConfig.Type != b.TabConfig.Type)
				{
					return a.TabConfig.Type - b.TabConfig.Type;
				}
				return b.TabConfig.Id - a.TabConfig.Id;
			});
			NewbieMainTabItemData newbieMainTabItemData = list.Find((NewbieMainTabItemData d) => d.TabConfig.Type == 1);
			if (newbieMainTabItemData != null)
			{
				newbieMainTabItemData.IsNew = true;
			}
			return list;
		}

		// Token: 0x06040131 RID: 262449 RVA: 0x00F80D88 File Offset: 0x00F7EF88
		private void UpdateTabDataList()
		{
			if (this.ActivityBaseData == null)
			{
				return;
			}
			NewbieMainData newbieMainData = this.ActivityBaseData as NewbieMainData;
			if (newbieMainData == null)
			{
				return;
			}
			NewbieMainModel instance = NewbieMainModel.Instance;
			foreach (NewbieMainTabItemData newbieMainTabItemData in this.TabDataList)
			{
				NewbieMainTabData tabData = newbieMainData.GetTabData(newbieMainTabItemData.TabConfig.Id);
				if (tabData != null)
				{
					if (instance.IsAllTasksCompleted(newbieMainTabItemData.TabConfig.Id, tabData))
					{
						newbieMainTabItemData.State = (newbieMainTabItemData.TabConfig.IsEnd ? ENewbieMainTabState.Finished : ENewbieMainTabState.Completed);
						newbieMainTabItemData.ProgressingTask = null;
					}
					else if (newbieMainTabItemData.TabConfig.Type == 2)
					{
						newbieMainTabItemData.State = (instance.IsAllAcceptedTasksCompleted(newbieMainTabItemData.TabConfig.Id, tabData) ? ENewbieMainTabState.Completed : ENewbieMainTabState.InProgress);
						newbieMainTabItemData.ProgressingTask = null;
					}
					else if (instance.IsFirstQuestInActive(newbieMainTabItemData.TabConfig.Id))
					{
						newbieMainTabItemData.State = ENewbieMainTabState.Lock;
						newbieMainTabItemData.ProgressingTask = null;
						newbieMainTabItemData.ProgressingQuestId = 0;
					}
					else
					{
						NewbieMainTaskQuestInfo firstUncompletedTask = instance.GetFirstUncompletedTask(newbieMainTabItemData.TabConfig, tabData);
						newbieMainTabItemData.State = ENewbieMainTabState.InProgress;
						newbieMainTabItemData.ProgressingTask = ((firstUncompletedTask != null) ? new NewbieMainActTask?(firstUncompletedTask.Task) : null);
						newbieMainTabItemData.ProgressingQuestId = ((firstUncompletedTask != null) ? firstUncompletedTask.QuestId : 0);
					}
				}
			}
		}

		// Token: 0x06040132 RID: 262450 RVA: 0x00F80F14 File Offset: 0x00F7F114
		private void UpdateRewardDataList()
		{
			if (this.ActivityBaseData == null)
			{
				return;
			}
			NewbieMainData newbieMainData = this.ActivityBaseData as NewbieMainData;
			if (newbieMainData == null)
			{
				return;
			}
			int progressScore = newbieMainData.ProgressScore;
			foreach (NewbieMainRewardItemData newbieMainRewardItemData in this.RewardDataList)
			{
				if (newbieMainData.IsScoreRewardTaken(newbieMainRewardItemData.Id))
				{
					newbieMainRewardItemData.State = ENewbieScoreRewardState.Claimed;
					newbieMainRewardItemData.Progress = 1f;
				}
				else if (progressScore >= newbieMainRewardItemData.Score)
				{
					newbieMainRewardItemData.State = ENewbieScoreRewardState.Claimable;
					newbieMainRewardItemData.Progress = 1f;
				}
				else
				{
					newbieMainRewardItemData.State = ENewbieScoreRewardState.UnAchieved;
					int num = newbieMainRewardItemData.Score - newbieMainRewardItemData.SrcScore;
					newbieMainRewardItemData.Progress = ((num > 0) ? Math.Max(0f, (float)(progressScore - newbieMainRewardItemData.SrcScore) / (float)num) : 0f);
				}
			}
		}

		// Token: 0x06040133 RID: 262451 RVA: 0x00F81004 File Offset: 0x00F7F204
		private void OnClickTabCard(NewbieMainTabItemData tabItemData)
		{
			if (tabItemData.TabConfig.Type == 1)
			{
				this.HandleMainTabClick(tabItemData);
				return;
			}
			if (tabItemData.TabConfig.Type == 2)
			{
				this.HandleRoleTabClick(tabItemData);
			}
		}

		// Token: 0x06040134 RID: 262452 RVA: 0x00F81034 File Offset: 0x00F7F234
		private void HandleMainTabClick(NewbieMainTabItemData tabItemData)
		{
			if (tabItemData.State == ENewbieMainTabState.Finished)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("NewPlayer_TaskAwards_012", Array.Empty<object>());
				return;
			}
			if (tabItemData.State == ENewbieMainTabState.Completed)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("NewPlayer_TaskAwards_013", Array.Empty<object>());
				return;
			}
			if (tabItemData.State != ENewbieMainTabState.Lock)
			{
				if (tabItemData.ProgressingQuestId > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, tabItemData.ProgressingQuestId, null);
				}
				return;
			}
			int directTrainActivityId = tabItemData.TabConfig.DirectTrainActivityId;
			if (directTrainActivityId <= 0)
			{
				return;
			}
			DirectTrainModel instance = DirectTrainModel.Instance;
			DirectTrainSubActivityViewModel directTrainSubActivityViewModel = (instance != null) ? instance.BuildSubActivityViewModel(directTrainActivityId) : null;
			if (directTrainSubActivityViewModel == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DirectTrainDetailView, directTrainSubActivityViewModel, null);
		}

		// Token: 0x06040135 RID: 262453 RVA: 0x00F810E4 File Offset: 0x00F7F2E4
		private void HandleRoleTabClick(NewbieMainTabItemData tabItemData)
		{
			if (tabItemData.State == ENewbieMainTabState.Finished)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("NewPlayer_TaskAwards_015", Array.Empty<object>());
				return;
			}
			if (tabItemData.State == ENewbieMainTabState.Completed)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("NewPlayer_TaskAwards_014", Array.Empty<object>());
				return;
			}
			global::RoleQuest firstShowRoleQuest = ActivityRegressModel.Instance.GetFirstShowRoleQuest();
			if (firstShowRoleQuest == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("NewPlayer_TaskAwards_011", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, firstShowRoleQuest.Id, null);
		}

		// Token: 0x06040136 RID: 262454 RVA: 0x00F8116C File Offset: 0x00F7F36C
		private List<NewbieMainRewardItemData> BuildScoreRewardDisplayDataList()
		{
			if (this.ActivityBaseData == null)
			{
				return new List<NewbieMainRewardItemData>();
			}
			IReadOnlyList<NewbieMainActReward> rewardListByActivityId = NewbieMainConfig.Instance.GetRewardListByActivityId(this.ActivityBaseData.Id);
			if (rewardListByActivityId == null)
			{
				return new List<NewbieMainRewardItemData>();
			}
			List<NewbieMainRewardItemData> list = new List<NewbieMainRewardItemData>();
			foreach (NewbieMainActReward newbieMainActReward in rewardListByActivityId)
			{
				list.Add(new NewbieMainRewardItemData
				{
					Id = newbieMainActReward.Id,
					SrcScore = 0,
					Score = newbieMainActReward.Score,
					Progress = 0f,
					State = ENewbieScoreRewardState.UnAchieved,
					PreviewReward = this.GetDropPreviewReward(newbieMainActReward.DropId)
				});
			}
			list.Sort((NewbieMainRewardItemData a, NewbieMainRewardItemData b) => a.Score - b.Score);
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SrcScore = ((i > 0) ? list[i - 1].Score : 0);
			}
			return list;
		}

		// Token: 0x06040137 RID: 262455 RVA: 0x00F81290 File Offset: 0x00F7F490
		private TItem? GetDropPreviewReward(int dropId)
		{
			if (dropId <= 0)
			{
				return null;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
			if (dropPackagePreviewItemList == null || dropPackagePreviewItemList.Count == 0)
			{
				return null;
			}
			return new TItem?(dropPackagePreviewItemList[0]);
		}

		// Token: 0x06040138 RID: 262456 RVA: 0x00F812D8 File Offset: 0x00F7F4D8
		private void RefreshRewardList()
		{
			if (this.RewardScrollView == null)
			{
				return;
			}
			this.RewardScrollView.RefreshByData(this.RewardDataList, new Action(this.ScrollToFirstClaimableReward), false);
		}

		// Token: 0x06040139 RID: 262457 RVA: 0x00F81304 File Offset: 0x00F7F504
		private void ScrollToFirstClaimableReward()
		{
			int num = -1;
			for (int i = 0; i < this.RewardDataList.Count; i++)
			{
				if (this.RewardDataList[i].State == ENewbieScoreRewardState.Claimable)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				this.RewardScrollView.LateScrollToLeft(num);
			}
		}

		// Token: 0x0604013A RID: 262458 RVA: 0x00F81358 File Offset: 0x00F7F558
		private void GetRewardAsync(NewbieMainRewardItemData data)
		{
			if (this.ActivityBaseData == null)
			{
				return;
			}
			NewbieMainData newbieMainData = this.ActivityBaseData as NewbieMainData;
			if (newbieMainData == null)
			{
				return;
			}
			if (data.State != ENewbieScoreRewardState.Claimable)
			{
				if (data.PreviewReward != null)
				{
					ItemController.Instance.OpenItemTipsByItemId(data.PreviewReward.Value.ItemData.ItemId, true, null);
				}
				return;
			}
			List<int> list = new List<int>();
			foreach (NewbieMainRewardItemData newbieMainRewardItemData in this.RewardDataList)
			{
				if (newbieMainRewardItemData.State == ENewbieScoreRewardState.Claimable)
				{
					list.Add(newbieMainRewardItemData.Id);
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			NewbieMainController.RequestFetchScoreRewardAsync(newbieMainData.Id, list, delegate(bool success)
			{
				if (success)
				{
					this.OnRefreshView();
				}
			});
		}

		// Token: 0x0604013B RID: 262459 RVA: 0x00F81434 File Offset: 0x00F7F634
		private void RefreshCompletedCount()
		{
			if (this.ActivityBaseData == null)
			{
				return;
			}
			NewbieMainData newbieMainData = this.ActivityBaseData as NewbieMainData;
			if (newbieMainData == null)
			{
				return;
			}
			int progressScore = newbieMainData.ProgressScore;
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(progressScore.ToString(), true);
		}

		// Token: 0x0402163E RID: 136766
		private List<NewbieMainTabItemData> TabDataList = new List<NewbieMainTabItemData>();

		// Token: 0x0402163F RID: 136767
		private List<NewbieMainRewardItemData> RewardDataList = new List<NewbieMainRewardItemData>();

		// Token: 0x04021640 RID: 136768
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<NewbieMainRewardItem, NewbieMainRewardItemData> RewardScrollView;

		// Token: 0x04021641 RID: 136769
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<NewbieMainTabItem, NewbieMainTabItemData> TabScrollView;

		// Token: 0x0200C599 RID: 50585
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BA5F RID: 244319
			public const int TitleText = 0;

			// Token: 0x0403BA60 RID: 244320
			public const int ActivityDescText = 1;

			// Token: 0x0403BA61 RID: 244321
			public const int RewardCountText = 2;

			// Token: 0x0403BA62 RID: 244322
			public const int RewardScrollView = 3;

			// Token: 0x0403BA63 RID: 244323
			public const int RewardTemplateItem = 4;

			// Token: 0x0403BA64 RID: 244324
			public const int TabScrollView = 5;

			// Token: 0x0403BA65 RID: 244325
			public const int TabTemplateItem = 6;

			// Token: 0x0403BA66 RID: 244326
			public const int TimeText = 7;
		}
	}
}
