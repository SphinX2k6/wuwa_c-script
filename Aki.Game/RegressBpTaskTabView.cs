using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001486 RID: 5254
[NullableContext(1)]
[Nullable(0)]
public class RegressBpTaskTabView : UiTabViewBase, IRegressBpTabView
{
	// Token: 0x060094B9 RID: 38073 RVA: 0x00200B9D File Offset: 0x001FED9D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060094BA RID: 38074 RVA: 0x00200BD8 File Offset: 0x001FEDD8
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpTaskTabView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpTaskTabView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060094BB RID: 38075 RVA: 0x00200C1B File Offset: 0x001FEE1B
	public void OnClickBtnClaimAll()
	{
		ActivityRegressController.Instance.RequestClaimAllTaskReward();
	}

	// Token: 0x060094BC RID: 38076 RVA: 0x00200C27 File Offset: 0x001FEE27
	public void RefreshBtnClaimVisible(UUIItem uiItem)
	{
		uiItem.SetUIActive(ActivityRegressModel.Instance.ActivityData.HasReachableConstantTask());
	}

	// Token: 0x060094BD RID: 38077 RVA: 0x00200C3E File Offset: 0x001FEE3E
	protected override void OnBeforeShow()
	{
		this.RefreshView(true);
	}

	// Token: 0x060094BE RID: 38078 RVA: 0x00200C48 File Offset: 0x001FEE48
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

	// Token: 0x060094BF RID: 38079 RVA: 0x00200CEC File Offset: 0x001FEEEC
	private RegressBpTaskItem OnCreateTaskItem()
	{
		return new RegressBpTaskItem();
	}

	// Token: 0x060094C0 RID: 38080 RVA: 0x00200CF3 File Offset: 0x001FEEF3
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

	// Token: 0x040041E3 RID: 16867
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

	// Token: 0x040041E4 RID: 16868
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

	// Token: 0x040041E5 RID: 16869
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<RegressBpTaskItem, RegressQuest> TaskScrollView;

	// Token: 0x02007AAF RID: 31407
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040285D3 RID: 165331
		public const int MissionScroll = 0;

		// Token: 0x040285D4 RID: 165332
		public const int Item = 1;
	}
}
