using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006588 RID: 25992
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTimeLimitRewardTabView : UiTabViewBase
	{
		// Token: 0x0604123B RID: 266811 RVA: 0x00FC9594 File Offset: 0x00FC7794
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604123C RID: 266812 RVA: 0x00FC9684 File Offset: 0x00FC7884
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTimeLimitRewardTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTimeLimitRewardTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604123D RID: 266813 RVA: 0x00FC96C8 File Offset: 0x00FC78C8
		protected override void OnStart()
		{
			FishingActivity activityConfig = this.ActivityDataBase.GetActivityConfig();
			WeaponTrialData weaponTrialData = new WeaponTrialData();
			weaponTrialData.SetTrialId(activityConfig.PreviewWeaponId, true);
			this.WeaponItem.Refresh(weaponTrialData.GetItemId(), false);
			this.WeaponItem.SetLookButtonVisible(true);
			this.WeaponItem.BindWeaponPreviewFunction(new int[]
			{
				activityConfig.PreviewWeaponId
			}, 0);
		}

		// Token: 0x0604123E RID: 266814 RVA: 0x00FC972F File Offset: 0x00FC792F
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshCurrentTaskLayout));
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshProgressItem));
		}

		// Token: 0x0604123F RID: 266815 RVA: 0x00FC976C File Offset: 0x00FC796C
		protected override void OnBeforeShow()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06041240 RID: 266816 RVA: 0x00FC97A8 File Offset: 0x00FC79A8
		protected override void OnBeforeHide()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06041241 RID: 266817 RVA: 0x00FC97E1 File Offset: 0x00FC79E1
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshCurrentTaskLayout));
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshProgressItem));
		}

		// Token: 0x06041242 RID: 266818 RVA: 0x00FC981B File Offset: 0x00FC7A1B
		private FishingRewardTargetTabItem TabItemProxyCreate()
		{
			return new FishingRewardTargetTabItem();
		}

		// Token: 0x06041243 RID: 266819 RVA: 0x00FC9824 File Offset: 0x00FC7A24
		private List<FishingRewardTargetTabData> CreateTabItemDataList(IEnumerable<FishingActivityGroup> tabList)
		{
			List<FishingRewardTargetTabData> list = new List<FishingRewardTargetTabData>();
			int num = 0;
			foreach (FishingActivityGroup fishingActivityGroup in tabList)
			{
				list.Add(new FishingRewardTargetTabData
				{
					NameTextId = fishingActivityGroup.GroupName,
					Index = num,
					ClickedCallback = new Action<int>(this.TabCallBack),
					RefreshRedDot = ((int tabIndex) => this.ActivityDataBase.GetTimeLimitTasksRedDotStateByGroupId(tabIndex))
				});
				num++;
			}
			return list;
		}

		// Token: 0x06041244 RID: 266820 RVA: 0x00FC98C0 File Offset: 0x00FC7AC0
		private void TabCallBack(int index)
		{
			if (this.CurrentTabIndex != index && this.CurrentTabIndex != -1)
			{
				FishingRewardTargetTabItem layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex(this.CurrentTabIndex);
				if (layoutItemByIndex != null)
				{
					layoutItemByIndex.SetToggleState(false, false);
				}
			}
			this.CurrentTabIndex = index;
			this.RefreshTaskLayout(this.CurrentTabIndex, true);
		}

		// Token: 0x06041245 RID: 266821 RVA: 0x00FC9911 File Offset: 0x00FC7B11
		private FishingRewardTaskItem TaskItemProxyCreate()
		{
			return new FishingRewardTaskItem();
		}

		// Token: 0x06041246 RID: 266822 RVA: 0x00FC9918 File Offset: 0x00FC7B18
		private void RefreshCurrentTaskLayout()
		{
			foreach (FishingRewardTargetTabItem fishingRewardTargetTabItem in this.TabLayout.GetLayoutItemList())
			{
				fishingRewardTargetTabItem.RefreshRedDot();
			}
			this.RefreshTaskLayout(this.CurrentTabIndex, false);
		}

		// Token: 0x06041247 RID: 266823 RVA: 0x00FC997C File Offset: 0x00FC7B7C
		private void RefreshTaskLayout(int tabIndex, bool reset)
		{
			ActivityTaskData[] timeLimitTasksByGroupId = this.ActivityDataBase.GetTimeLimitTasksByGroupId(tabIndex + 1);
			this.TaskLayout.RefreshByData(this.CreateTaskDataList(timeLimitTasksByGroupId), delegate
			{
				if (reset)
				{
					this.TaskLayout.ScrollToTop(0);
				}
			}, true);
		}

		// Token: 0x06041248 RID: 266824 RVA: 0x00FC99CC File Offset: 0x00FC7BCC
		private List<FishingTaskData> CreateTaskDataList(IEnumerable<ActivityTaskData> taskDataList)
		{
			List<FishingTaskData> list = new List<FishingTaskData>();
			foreach (ActivityTaskData activityTaskData in taskDataList)
			{
				FishingActivityLimitTask? fishingActivityLimitTask = FishingConfig.Instance.GetFishingActivityLimitTask(activityTaskData.Id);
				list.Add(new FishingTaskData
				{
					TaskId = activityTaskData.Id,
					Status = activityTaskData.Status,
					Current = activityTaskData.Current,
					Target = activityTaskData.Target,
					JumpId = fishingActivityLimitTask.Value.JumpId,
					TitleTextId = fishingActivityLimitTask.Value.TaskName,
					RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(fishingActivityLimitTask.Value.DropId),
					ReceiveDelegate = new Action<int>(this.TaskReceiveFunc)
				});
			}
			return list;
		}

		// Token: 0x06041249 RID: 266825 RVA: 0x00FC9AD0 File Offset: 0x00FC7CD0
		private void TaskReceiveFunc(int taskId)
		{
			ActivityFishingController.FishingActivityLimitRewardRequest(taskId);
		}

		// Token: 0x0604124A RID: 266826 RVA: 0x00FC9AD8 File Offset: 0x00FC7CD8
		private void RefreshProgressItem()
		{
			FishingRewardProgressData[] allMilestoneReward = this.ActivityDataBase.GetAllMilestoneReward();
			int milestoneRewardMaxCount = this.ActivityDataBase.MilestoneRewardMaxCount;
			int milestoneRewardItemAccumulate = this.ActivityDataBase.MilestoneRewardItemAccumulate;
			this.ProgressItem.RefreshProgressItem(milestoneRewardItemAccumulate, milestoneRewardMaxCount, allMilestoneReward).Forget();
		}

		// Token: 0x0604124B RID: 266827 RVA: 0x00FC9B1C File Offset: 0x00FC7D1C
		private void OnClickGetProgressReward()
		{
			int[] allAvailableGetMilestoneRewardIds = this.ActivityDataBase.GetAllAvailableGetMilestoneRewardIds();
			if (allAvailableGetMilestoneRewardIds.Length != 0)
			{
				ActivityFishingController.FishingActivityMilestoneRewardRequest(allAvailableGetMilestoneRewardIds.ToList<int>());
			}
		}

		// Token: 0x04021EF1 RID: 138993
		private GenericLayout<FishingRewardTargetTabItem, FishingRewardTargetTabData> TabLayout;

		// Token: 0x04021EF2 RID: 138994
		private GenericScrollViewNew<FishingRewardTaskItem, FishingTaskData> TaskLayout;

		// Token: 0x04021EF3 RID: 138995
		private ActivityWeaponDescribeComponent WeaponItem;

		// Token: 0x04021EF4 RID: 138996
		private FishingRewardProgressPanel ProgressItem;

		// Token: 0x04021EF5 RID: 138997
		private ActivityFishingData ActivityDataBase;

		// Token: 0x04021EF6 RID: 138998
		private int CurrentTabIndex = -1;

		// Token: 0x0200C780 RID: 51072
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403C45F RID: 246879
			public const int WeaponPreview = 0;

			// Token: 0x0403C460 RID: 246880
			public const int TabLayout = 1;

			// Token: 0x0403C461 RID: 246881
			public const int TabItem = 2;

			// Token: 0x0403C462 RID: 246882
			public const int TaskLayout = 3;

			// Token: 0x0403C463 RID: 246883
			public const int TaskItem = 4;

			// Token: 0x0403C464 RID: 246884
			public const int ProgressItem = 5;
		}
	}
}
