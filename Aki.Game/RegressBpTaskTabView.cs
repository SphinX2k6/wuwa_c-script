using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200093A RID: 2362
[NullableContext(1)]
[Nullable(0)]
public class RegressBpTaskTabView : UiTabViewBase, IRegressBpTabView
{
	// Token: 0x0600684E RID: 26702 RVA: 0x00209B05 File Offset: 0x00207D05
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600684F RID: 26703 RVA: 0x00209B40 File Offset: 0x00207D40
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpTaskTabView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpTaskTabView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006850 RID: 26704 RVA: 0x00209B83 File Offset: 0x00207D83
	public void OnClickBtnClaimAll()
	{
		ActivityRegressController.Instance.RequestClaimAllTaskReward();
	}

	// Token: 0x06006851 RID: 26705 RVA: 0x00209B8F File Offset: 0x00207D8F
	public void RefreshBtnClaimVisible(UUIItem uiItem)
	{
		uiItem.SetUIActive(ActivityRegressModel.Instance.ActivityData.HasReachableConstantTask());
	}

	// Token: 0x06006852 RID: 26706 RVA: 0x00209BA6 File Offset: 0x00207DA6
	protected override void OnBeforeShow()
	{
		this.RefreshView(true);
	}

	// Token: 0x06006853 RID: 26707 RVA: 0x00209BB0 File Offset: 0x00207DB0
	public void RefreshView(bool playAnim = false)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		if (this.TaskScrollView == null || activityData == null)
		{
			return;
		}
		List<RegressQuest> list = new List<RegressQuest>();
		ERegressTaskType[] array = new ERegressTaskType[]
		{
			ERegressTaskType.Constant,
			ERegressTaskType.Daily,
			ERegressTaskType.Once
		};
		for (int i = 0; i < array.Length; i++)
		{
			List<RegressQuest> regressTaskListByType = activityData.GetRegressTaskListByType(array[i]);
			if (regressTaskListByType != null && regressTaskListByType.Count > 0)
			{
				for (int j = 0; j < regressTaskListByType.Count; j++)
				{
					list.Add(regressTaskListByType[j]);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		this.SortTask(list);
		this.TaskScrollView.RefreshByData(list, false, null, playAnim);
	}

	// Token: 0x06006854 RID: 26708 RVA: 0x00209C54 File Offset: 0x00207E54
	private RegressBpTaskItem OnCreateTaskItem()
	{
		return new RegressBpTaskItem();
	}

	// Token: 0x06006855 RID: 26709 RVA: 0x00209C5B File Offset: 0x00207E5B
	private void SortTask(List<RegressQuest> taskList)
	{
		taskList.Sort(delegate(RegressQuest a, RegressQuest b)
		{
			ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(a.Id);
			ERegressRewardState taskRewardState2 = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(b.Id);
			if (taskRewardState != taskRewardState2)
			{
				return RegressBpTaskTabView.RegressTaskRewardStateSortRecord[taskRewardState] - RegressBpTaskTabView.RegressTaskRewardStateSortRecord[taskRewardState2];
			}
			ERegressTaskType taskType = (ERegressTaskType)a.TaskType;
			ERegressTaskType taskType2 = (ERegressTaskType)b.TaskType;
			if (taskType != taskType2)
			{
				return RegressBpTaskTabView.RegressTaskTypeSortRecord[taskType] - RegressBpTaskTabView.RegressTaskTypeSortRecord[taskType2];
			}
			return a.Id - b.Id;
		});
	}

	// Token: 0x0400427B RID: 17019
	private static readonly Dictionary<ERegressTaskType, int> RegressTaskTypeSortRecord = new Dictionary<ERegressTaskType, int>
	{
		{
			ERegressTaskType.Constant,
			1
		},
		{
			ERegressTaskType.Daily,
			0
		},
		{
			ERegressTaskType.Cultivate,
			2
		},
		{
			ERegressTaskType.Once,
			3
		}
	};

	// Token: 0x0400427C RID: 17020
	private static readonly Dictionary<ERegressRewardState, int> RegressTaskRewardStateSortRecord = new Dictionary<ERegressRewardState, int>
	{
		{
			ERegressRewardState.UnReach,
			1
		},
		{
			ERegressRewardState.Reached,
			0
		},
		{
			ERegressRewardState.Claim,
			2
		}
	};

	// Token: 0x0400427D RID: 17021
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<RegressBpTaskItem, RegressQuest> TaskScrollView;

	// Token: 0x02006C33 RID: 27699
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040238ED RID: 145645
		public const int MissionScroll = 0;

		// Token: 0x040238EE RID: 145646
		public const int Item = 1;
	}
}
