using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x0200110D RID: 4365
[NullableContext(1)]
[Nullable(0)]
public class AvignonStageInfo
{
	// Token: 0x1700099E RID: 2462
	// (get) Token: 0x0600720F RID: 29199 RVA: 0x001753F2 File Offset: 0x001735F2
	// (set) Token: 0x06007210 RID: 29200 RVA: 0x001753FA File Offset: 0x001735FA
	public int StageId { get; private set; }

	// Token: 0x1700099F RID: 2463
	// (get) Token: 0x06007211 RID: 29201 RVA: 0x00175403 File Offset: 0x00173603
	// (set) Token: 0x06007212 RID: 29202 RVA: 0x0017540B File Offset: 0x0017360B
	public int Index { get; private set; }

	// Token: 0x170009A0 RID: 2464
	// (get) Token: 0x06007213 RID: 29203 RVA: 0x00175414 File Offset: 0x00173614
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

	// Token: 0x06007214 RID: 29204 RVA: 0x0017547C File Offset: 0x0017367C
	public void UnlockStage()
	{
		this.IsUnlockInternal = true;
	}

	// Token: 0x170009A1 RID: 2465
	// (get) Token: 0x06007215 RID: 29205 RVA: 0x00175485 File Offset: 0x00173685
	public bool IsUnlock
	{
		get
		{
			return this.StageState > EStageState.Lock;
		}
	}

	// Token: 0x06007216 RID: 29206 RVA: 0x00175490 File Offset: 0x00173690
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

	// Token: 0x06007217 RID: 29207 RVA: 0x0017556C File Offset: 0x0017376C
	public bool HasNewStageFlag()
	{
		if (this.StageState != EStageState.Active)
		{
			return false;
		}
		int avignonActivityId = AvignonModel.Instance.GetAvignonActivityId();
		return ActivityModel.Instance.GetActivityCacheData(avignonActivityId, 0, this.StageId, 0, 0) == 0;
	}

	// Token: 0x06007218 RID: 29208 RVA: 0x001755A8 File Offset: 0x001737A8
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

	// Token: 0x06007219 RID: 29209 RVA: 0x00175614 File Offset: 0x00173814
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

	// Token: 0x0600721A RID: 29210 RVA: 0x0017569C File Offset: 0x0017389C
	public List<AvignonTaskData> GetTaskList()
	{
		List<AvignonTaskData> list = new List<AvignonTaskData>(this.TaskMap.Values);
		list.Sort(new Comparison<AvignonTaskData>(this.TaskSort));
		return list;
	}

	// Token: 0x0600721B RID: 29211 RVA: 0x001756C0 File Offset: 0x001738C0
	private int TaskSort(AvignonTaskData a, AvignonTaskData b)
	{
		if (a.Status != b.Status)
		{
			return a.Status - b.Status;
		}
		return a.TaskId - b.TaskId;
	}

	// Token: 0x0600721C RID: 29212 RVA: 0x001756EC File Offset: 0x001738EC
	public string GetLockConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(AvignonConfig.Instance.GetStageConfigById(this.StageId).Value.OpenConditionId) ?? "";
	}

	// Token: 0x0600721D RID: 29213 RVA: 0x00175728 File Offset: 0x00173928
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

	// Token: 0x0600721E RID: 29214 RVA: 0x00175803 File Offset: 0x00173A03
	public void SetTaskRewardGot(int taskId)
	{
		this.TaskMap[taskId].Status = EActivityTaskState.FinishedAndClaimed;
	}

	// Token: 0x0600721F RID: 29215 RVA: 0x00175818 File Offset: 0x00173A18
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

	// Token: 0x06007220 RID: 29216 RVA: 0x00175889 File Offset: 0x00173A89
	private void RequestTaskReward(int taskId)
	{
		if (taskId <= 0)
		{
			return;
		}
		AvignonController.Instance.RequestTaskReward(taskId);
	}

	// Token: 0x040034DB RID: 13531
	public readonly Dictionary<int, AvignonTaskData> TaskMap = new Dictionary<int, AvignonTaskData>();

	// Token: 0x040034DC RID: 13532
	private bool IsUnlockInternal;
}
