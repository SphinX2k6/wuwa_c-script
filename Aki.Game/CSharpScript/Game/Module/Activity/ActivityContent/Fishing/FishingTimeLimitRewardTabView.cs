using System;
using System.Collections.Generic;
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
	// Token: 0x02005506 RID: 21766
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTimeLimitRewardTabView : UiTabViewBase
	{
		// Token: 0x06035F00 RID: 220928 RVA: 0x00F1054C File Offset: 0x00F0E74C
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

		// Token: 0x06035F01 RID: 220929 RVA: 0x00F1063C File Offset: 0x00F0E83C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTimeLimitRewardTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTimeLimitRewardTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035F02 RID: 220930 RVA: 0x00F10680 File Offset: 0x00F0E880
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

		// Token: 0x06035F03 RID: 220931 RVA: 0x00F106E7 File Offset: 0x00F0E8E7
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshCurrentTaskLayout));
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshProgressItem));
		}

		// Token: 0x06035F04 RID: 220932 RVA: 0x00F10724 File Offset: 0x00F0E924
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

		// Token: 0x06035F05 RID: 220933 RVA: 0x00F10760 File Offset: 0x00F0E960
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

		// Token: 0x06035F06 RID: 220934 RVA: 0x00F10799 File Offset: 0x00F0E999
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshCurrentTaskLayout));
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshProgressItem));
		}

		// Token: 0x06035F07 RID: 220935 RVA: 0x00F107D3 File Offset: 0x00F0E9D3
		private FishingRewardTargetTabItem TabItemProxyCreate()
		{
			return new FishingRewardTargetTabItem();
		}

		// Token: 0x06035F08 RID: 220936 RVA: 0x00F107DC File Offset: 0x00F0E9DC
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

		// Token: 0x06035F09 RID: 220937 RVA: 0x00F10878 File Offset: 0x00F0EA78
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

		// Token: 0x06035F0A RID: 220938 RVA: 0x00F108C9 File Offset: 0x00F0EAC9
		private FishingRewardTaskItem TaskItemProxyCreate()
		{
			return new FishingRewardTaskItem();
		}

		// Token: 0x06035F0B RID: 220939 RVA: 0x00F108D0 File Offset: 0x00F0EAD0
		private void RefreshCurrentTaskLayout()
		{
			foreach (FishingRewardTargetTabItem fishingRewardTargetTabItem in this.TabLayout.GetLayoutItemList())
			{
				fishingRewardTargetTabItem.RefreshRedDot();
			}
			this.RefreshTaskLayout(this.CurrentTabIndex, false);
		}

		// Token: 0x06035F0C RID: 220940 RVA: 0x00F10934 File Offset: 0x00F0EB34
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

		// Token: 0x06035F0D RID: 220941 RVA: 0x00F10984 File Offset: 0x00F0EB84
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

		// Token: 0x06035F0E RID: 220942 RVA: 0x00F10A88 File Offset: 0x00F0EC88
		private void TaskReceiveFunc(int taskId)
		{
			ActivityFishingController.FishingActivityLimitRewardRequest(taskId);
		}

		// Token: 0x06035F0F RID: 220943 RVA: 0x00F10A90 File Offset: 0x00F0EC90
		private void RefreshProgressItem()
		{
			FishingRewardProgressData[] allMilestoneReward = this.ActivityDataBase.GetAllMilestoneReward();
			int milestoneRewardMaxCount = this.ActivityDataBase.MilestoneRewardMaxCount;
			int milestoneRewardItemAccumulate = this.ActivityDataBase.MilestoneRewardItemAccumulate;
			this.ProgressItem.RefreshProgressItem(milestoneRewardItemAccumulate, milestoneRewardMaxCount, allMilestoneReward).Forget();
		}

		// Token: 0x06035F10 RID: 220944 RVA: 0x00F10AD4 File Offset: 0x00F0ECD4
		private void OnClickGetProgressReward()
		{
			int[] allAvailableGetMilestoneRewardIds = this.ActivityDataBase.GetAllAvailableGetMilestoneRewardIds();
			if (allAvailableGetMilestoneRewardIds.Length != 0)
			{
				ActivityFishingController.FishingActivityMilestoneRewardRequest(allAvailableGetMilestoneRewardIds);
			}
		}

		// Token: 0x0401C822 RID: 116770
		private GenericLayout<FishingRewardTargetTabItem, FishingRewardTargetTabData> TabLayout;

		// Token: 0x0401C823 RID: 116771
		private GenericScrollViewNew<FishingRewardTaskItem, FishingTaskData> TaskLayout;

		// Token: 0x0401C824 RID: 116772
		private ActivityWeaponDescribeComponent WeaponItem;

		// Token: 0x0401C825 RID: 116773
		private FishingRewardProgressPanel ProgressItem;

		// Token: 0x0401C826 RID: 116774
		private ActivityFishingData ActivityDataBase;

		// Token: 0x0401C827 RID: 116775
		private int CurrentTabIndex = -1;

		// Token: 0x0200B165 RID: 45413
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036DB0 RID: 224688
			public const int WeaponPreview = 0;

			// Token: 0x04036DB1 RID: 224689
			public const int TabLayout = 1;

			// Token: 0x04036DB2 RID: 224690
			public const int TabItem = 2;

			// Token: 0x04036DB3 RID: 224691
			public const int TaskLayout = 3;

			// Token: 0x04036DB4 RID: 224692
			public const int TaskItem = 4;

			// Token: 0x04036DB5 RID: 224693
			public const int ProgressItem = 5;
		}
	}
}
