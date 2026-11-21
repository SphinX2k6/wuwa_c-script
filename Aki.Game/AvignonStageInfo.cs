using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x020005C1 RID: 1473
[NullableContext(1)]
[Nullable(0)]
public class AvignonStageInfo
{
	// Token: 0x170009BE RID: 2494
	// (get) Token: 0x060045A5 RID: 17829 RVA: 0x0017DDAE File Offset: 0x0017BFAE
	// (set) Token: 0x060045A6 RID: 17830 RVA: 0x0017DDB6 File Offset: 0x0017BFB6
	public int StageId { get; private set; }

	// Token: 0x170009BF RID: 2495
	// (get) Token: 0x060045A7 RID: 17831 RVA: 0x0017DDBF File Offset: 0x0017BFBF
	// (set) Token: 0x060045A8 RID: 17832 RVA: 0x0017DDC7 File Offset: 0x0017BFC7
	public int Index { get; private set; }

	// Token: 0x170009C0 RID: 2496
	// (get) Token: 0x060045A9 RID: 17833 RVA: 0x0017DDD0 File Offset: 0x0017BFD0
	public EStageState StageState
	{
		get
		{
			if (!this.IsUnlockInternal)
			{
				return EStageState.Lock;
			}
			using (Dictionary<int, AvignonTaskData>.ValueCollection.Enumerator enumerator = this.TaskMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsTaken)
					{
						return EStageState.Active;
					}
				}
			}
			return EStageState.Finished;
		}
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x0017DE38 File Offset: 0x0017C038
	public void UnlockStage()
	{
		this.IsUnlockInternal = true;
	}

	// Token: 0x170009C1 RID: 2497
	// (get) Token: 0x060045AB RID: 17835 RVA: 0x0017DE41 File Offset: 0x0017C041
	public bool IsUnlock
	{
		get
		{
			return this.StageState > EStageState.Lock;
		}
	}

	// Token: 0x060045AC RID: 17836 RVA: 0x0017DE4C File Offset: 0x0017C04C
	public AvignonStageInfo(int StageId, int Index)
	{
		this.StageId = StageId;
		this.Index = Index;
		AvignonConfig instance = AvignonConfig.Instance;
		IReadOnlyList<AvignonTask> readOnlyList = (instance != null) ? instance.GetAvignonTaskConfigByStageId(StageId) : null;
		if (readOnlyList != null)
		{
			foreach (AvignonTask avignonTask in readOnlyList)
			{
				AvignonTaskData avignonTaskData = new AvignonTaskData(avignonTask.TaskId);
				avignonTaskData.JumpId = avignonTask.JumpId;
				avignonTaskData.TitleTextId = avignonTask.TaskName;
				avignonTaskData.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(avignonTask.TaskReward);
				avignonTaskData.ReceiveDelegate = new Action<int>(this.RequestTaskReward);
				this.TaskMap.Add(avignonTask.TaskId, avignonTaskData);
			}
		}
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x0017DF28 File Offset: 0x0017C128
	public bool HasNewStageFlag()
	{
		if (this.StageState != EStageState.Active)
		{
			return false;
		}
		int avignonActivityId = AvignonModel.Instance.GetAvignonActivityId();
		return ActivityModel.Instance.GetActivityCacheData(avignonActivityId, 0, this.StageId, 0, 0) == 0;
	}

	// Token: 0x060045AE RID: 17838 RVA: 0x0017DF64 File Offset: 0x0017C164
	public bool GetRewardState()
	{
		if (this.StageState != EStageState.Active)
		{
			return false;
		}
		using (Dictionary<int, AvignonTaskData>.ValueCollection.Enumerator enumerator = this.TaskMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060045AF RID: 17839 RVA: 0x0017DFD0 File Offset: 0x0017C1D0
	public int GetTaskProgress()
	{
		int count = this.TaskMap.Count;
		int num = 0;
		using (Dictionary<int, AvignonTaskData>.ValueCollection.Enumerator enumerator = this.TaskMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsTaken)
				{
					num++;
				}
			}
		}
		return (int)Math.Ceiling((double)((float)num * 1f / (float)count) * 100.0);
	}

	// Token: 0x060045B0 RID: 17840 RVA: 0x0017E058 File Offset: 0x0017C258
	public List<AvignonTaskData> GetTaskList()
	{
		List<AvignonTaskData> list = new List<AvignonTaskData>(this.TaskMap.Values);
		list.Sort(new Comparison<AvignonTaskData>(this.TaskSort));
		return list;
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x0017E07C File Offset: 0x0017C27C
	private int TaskSort(AvignonTaskData a, AvignonTaskData b)
	{
		if (a.Status != b.Status)
		{
			return a.Status - b.Status;
		}
		return a.TaskId - b.TaskId;
	}

	// Token: 0x060045B2 RID: 17842 RVA: 0x0017E0A8 File Offset: 0x0017C2A8
	public string GetLockConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(AvignonConfig.Instance.GetStageConfigById(this.StageId).Value.OpenConditionId) ?? "";
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x0017E0E4 File Offset: 0x0017C2E4
	public unsafe void UpdateTask(ActivityTask taskInfo)
	{
		AvignonTaskData avignonTaskData;
		if (this.TaskMap.TryGetValue(taskInfo.Id, out avignonTaskData))
		{
			int isFinished = avignonTaskData.IsFinished ? 1 : 0;
			avignonTaskData.Current = taskInfo.Current;
			avignonTaskData.Target = taskInfo.Target;
			avignonTaskData.Status = TaskStateResolver.TaskState[taskInfo.Status];
			bool isFinished2 = avignonTaskData.IsFinished;
			if (isFinished == 0 && isFinished2)
			{
				this.OnStageTaskInfoChange(avignonTaskData.TaskId);
				return;
			}
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "[AvignonActivity] 活动Task不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("StageId", this.StageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TaskId", taskInfo.Id);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x0017E1BF File Offset: 0x0017C3BF
	public void SetTaskRewardGot(int taskId)
	{
		this.TaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
	}

	// Token: 0x060045B5 RID: 17845 RVA: 0x0017E1D4 File Offset: 0x0017C3D4
	private void OnStageTaskInfoChange(int taskId)
	{
		AvignonTaskData avignonTaskData = this.TaskMap[taskId];
		if (avignonTaskData.JumpId > 0)
		{
			AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(avignonTaskData.JumpId);
			if (accessPathConfig.Value.SkipName == 8)
			{
				int value = Convert.ToInt32(accessPathConfig.Value.Val1);
				MapModel.Instance.RemoveMapMarksByConfigId(new EMarkType?(EMarkType.Entity), new int?(value));
			}
		}
	}

	// Token: 0x060045B6 RID: 17846 RVA: 0x0017E245 File Offset: 0x0017C445
	private void RequestTaskReward(int taskId)
	{
		if (taskId <= 0)
		{
			return;
		}
		AvignonController.Instance.RequestTaskReward(taskId);
	}

	// Token: 0x04003574 RID: 13684
	public readonly Dictionary<int, AvignonTaskData> TaskMap = new Dictionary<int, AvignonTaskData>();

	// Token: 0x04003575 RID: 13685
	private bool IsUnlockInternal;
}
