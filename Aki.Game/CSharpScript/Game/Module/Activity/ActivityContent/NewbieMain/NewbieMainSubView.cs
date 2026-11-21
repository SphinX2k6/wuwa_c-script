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
	// Token: 0x02005306 RID: 21254
	[NullableContext(1)]
	[Nullable(0)]
	public class NewbieMainSubView : ActivitySubViewBase
	{
		// Token: 0x06034DE3 RID: 216547 RVA: 0x00EC7864 File Offset: 0x00EC5A64
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

		// Token: 0x06034DE4 RID: 216548 RVA: 0x00EC7994 File Offset: 0x00EC5B94
		protected override UniTask OnBeforeStartAsync()
		{
			NewbieMainSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewbieMainSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034DE5 RID: 216549 RVA: 0x00EC79D7 File Offset: 0x00EC5BD7
		private NewbieMainRewardItem CreateRewardItem()
		{
			NewbieMainRewardItem newbieMainRewardItem = new NewbieMainRewardItem();
			newbieMainRewardItem.SetClickCallback(delegate(NewbieMainRewardItemData data)
			{
				this.GetRewardAsync(data);
			});
			return newbieMainRewardItem;
		}

		// Token: 0x06034DE6 RID: 216550 RVA: 0x00EC79F0 File Offset: 0x00EC5BF0
		private NewbieMainTabItem CreateTabItem()
		{
			return new NewbieMainTabItem
			{
				OnClickTab = new Action<NewbieMainTabItemData>(this.OnClickTabCard)
			};
		}

		// Token: 0x06034DE7 RID: 216551 RVA: 0x00EC7A09 File Offset: 0x00EC5C09
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnNewbieMainTaskUpdate, new Action(this.OnNewbieMainTaskUpdateHandler));
		}

		// Token: 0x06034DE8 RID: 216552 RVA: 0x00EC7A2D File Offset: 0x00EC5C2D
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnNewbieMainTaskUpdate, new Action(this.OnNewbieMainTaskUpdateHandler));
		}

		// Token: 0x06034DE9 RID: 216553 RVA: 0x00EC7A51 File Offset: 0x00EC5C51
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

		// Token: 0x06034DEA RID: 216554 RVA: 0x00EC7A70 File Offset: 0x00EC5C70
		private void OnNewbieMainTaskUpdateHandler()
		{
			this.OnRefreshView();
		}

		// Token: 0x06034DEB RID: 216555 RVA: 0x00EC7A78 File Offset: 0x00EC5C78
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06034DEC RID: 216556 RVA: 0x00EC7A80 File Offset: 0x00EC5C80
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

		// Token: 0x06034DED RID: 216557 RVA: 0x00EC7ABC File Offset: 0x00EC5CBC
		private void RefreshTitleText()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			string text = (activityBaseData != null) ? ((activityBaseData.LocalConfig != null) ? activityBaseData.LocalConfig.GetValueOrDefault().Title : null) : null;
			if (text != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), text, Array.Empty<object>());
			}
		}

		// Token: 0x06034DEE RID: 216558 RVA: 0x00EC7B10 File Offset: 0x00EC5D10
		private void RefreshActivityDescText()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			string text = (activityBaseData != null) ? ((activityBaseData.LocalConfig != null) ? activityBaseData.LocalConfig.GetValueOrDefault().Desc : null) : null;
			if (text != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), text, Array.Empty<object>());
			}
		}

		// Token: 0x06034DEF RID: 216559 RVA: 0x00EC7B64 File Offset: 0x00EC5D64
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

		// Token: 0x06034DF0 RID: 216560 RVA: 0x00EC7BA2 File Offset: 0x00EC5DA2
		private void RefreshTabList()
		{
			GenericScrollViewNew<NewbieMainTabItem, NewbieMainTabItemData> tabScrollView = this.TabScrollView;
			if (tabScrollView == null)
			{
				return;
			}
			tabScrollView.RefreshByData(this.TabDataList, null, false);
		}

		// Token: 0x06034DF1 RID: 216561 RVA: 0x00EC7BBC File Offset: 0x00EC5DBC
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

		// Token: 0x06034DF2 RID: 216562 RVA: 0x00EC7CEC File Offset: 0x00EC5EEC
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

		// Token: 0x06034DF3 RID: 216563 RVA: 0x00EC7E78 File Offset: 0x00EC6078
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

		// Token: 0x06034DF4 RID: 216564 RVA: 0x00EC7F68 File Offset: 0x00EC6168
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

		// Token: 0x06034DF5 RID: 216565 RVA: 0x00EC7F98 File Offset: 0x00EC6198
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

		// Token: 0x06034DF6 RID: 216566 RVA: 0x00EC8048 File Offset: 0x00EC6248
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

		// Token: 0x06034DF7 RID: 216567 RVA: 0x00EC80D0 File Offset: 0x00EC62D0
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

		// Token: 0x06034DF8 RID: 216568 RVA: 0x00EC81F4 File Offset: 0x00EC63F4
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

		// Token: 0x06034DF9 RID: 216569 RVA: 0x00EC823C File Offset: 0x00EC643C
		private void RefreshRewardList()
		{
			if (this.RewardScrollView == null)
			{
				return;
			}
			this.RewardScrollView.RefreshByData(this.RewardDataList, new Action(this.ScrollToFirstClaimableReward), false);
		}

		// Token: 0x06034DFA RID: 216570 RVA: 0x00EC8268 File Offset: 0x00EC6468
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

		// Token: 0x06034DFB RID: 216571 RVA: 0x00EC82BC File Offset: 0x00EC64BC
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
					ItemController.Instance.OpenItemTipsByItemId(data.PreviewReward.Value.ItemData.ItemId, true, null, false);
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

		// Token: 0x06034DFC RID: 216572 RVA: 0x00EC8398 File Offset: 0x00EC6598
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

		// Token: 0x0401BF6D RID: 114541
		private List<NewbieMainTabItemData> TabDataList = new List<NewbieMainTabItemData>();

		// Token: 0x0401BF6E RID: 114542
		private List<NewbieMainRewardItemData> RewardDataList = new List<NewbieMainRewardItemData>();

		// Token: 0x0401BF6F RID: 114543
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<NewbieMainRewardItem, NewbieMainRewardItemData> RewardScrollView;

		// Token: 0x0401BF70 RID: 114544
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<NewbieMainTabItem, NewbieMainTabItemData> TabScrollView;

		// Token: 0x0200AF80 RID: 44928
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040363C1 RID: 222145
			public const int TitleText = 0;

			// Token: 0x040363C2 RID: 222146
			public const int ActivityDescText = 1;

			// Token: 0x040363C3 RID: 222147
			public const int RewardCountText = 2;

			// Token: 0x040363C4 RID: 222148
			public const int RewardScrollView = 3;

			// Token: 0x040363C5 RID: 222149
			public const int RewardTemplateItem = 4;

			// Token: 0x040363C6 RID: 222150
			public const int TabScrollView = 5;

			// Token: 0x040363C7 RID: 222151
			public const int TabTemplateItem = 6;

			// Token: 0x040363C8 RID: 222152
			public const int TimeText = 7;
		}
	}
}
