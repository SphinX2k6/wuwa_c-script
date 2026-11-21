using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x02000660 RID: 1632
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastStageInfo
{
	// Token: 0x17000A64 RID: 2660
	// (get) Token: 0x06004B7E RID: 19326 RVA: 0x0019A004 File Offset: 0x00198204
	public EStageState StageState
	{
		get
		{
			if (!this.IsUnlockInternal)
			{
				return EStageState.Lock;
			}
			using (Dictionary<int, BlackCoastTaskData>.ValueCollection.Enumerator enumerator = this.TaskMap.Values.GetEnumerator())
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

	// Token: 0x17000A65 RID: 2661
	// (get) Token: 0x06004B7F RID: 19327 RVA: 0x0019A06C File Offset: 0x0019826C
	public bool IsUnlock
	{
		get
		{
			return this.StageState > EStageState.Lock;
		}
	}

	// Token: 0x17000A66 RID: 2662
	// (get) Token: 0x06004B80 RID: 19328 RVA: 0x0019A077 File Offset: 0x00198277
	// (set) Token: 0x06004B81 RID: 19329 RVA: 0x0019A07F File Offset: 0x0019827F
	public int StageId { get; private set; }

	// Token: 0x17000A67 RID: 2663
	// (get) Token: 0x06004B82 RID: 19330 RVA: 0x0019A088 File Offset: 0x00198288
	// (set) Token: 0x06004B83 RID: 19331 RVA: 0x0019A090 File Offset: 0x00198290
	public int Index { get; private set; }

	// Token: 0x06004B84 RID: 19332 RVA: 0x0019A09C File Offset: 0x0019829C
	public BlackCoastStageInfo(int stageId, int index)
	{
		this.StageId = stageId;
		this.Index = index;
		foreach (BlackCoastThemeTaskRe blackCoastThemeTaskRe in ActivityBlackCoastConfig.Instance.GetAllTaskConfigByStageId(this.StageId))
		{
			BlackCoastTaskData blackCoastTaskData = new BlackCoastTaskData(blackCoastThemeTaskRe.TaskId);
			blackCoastTaskData.JumpId = blackCoastThemeTaskRe.JumpId;
			blackCoastTaskData.SortId = blackCoastThemeTaskRe.SortId;
			blackCoastTaskData.TitleTextId = blackCoastThemeTaskRe.TaskName;
			blackCoastTaskData.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(blackCoastThemeTaskRe.DropId);
			blackCoastTaskData.ReceiveDelegate = new Action<int>(this.RequestTaskReward);
			this.TaskMap[blackCoastThemeTaskRe.TaskId] = blackCoastTaskData;
		}
	}

	// Token: 0x06004B85 RID: 19333 RVA: 0x0019A17C File Offset: 0x0019837C
	public string GetVideoSource()
	{
		return ActivityBlackCoastConfig.Instance.GetStageConfig(this.StageId).Value.VideoSource;
	}

	// Token: 0x06004B86 RID: 19334 RVA: 0x0019A1AC File Offset: 0x001983AC
	public bool GetRewardState()
	{
		using (Dictionary<int, BlackCoastTaskData>.ValueCollection.Enumerator enumerator = this.TaskMap.Values.GetEnumerator())
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

	// Token: 0x06004B87 RID: 19335 RVA: 0x0019A20C File Offset: 0x0019840C
	public int GetTaskProgress()
	{
		int count = this.TaskMap.Count;
		int num = 0;
		using (Dictionary<int, BlackCoastTaskData>.ValueCollection.Enumerator enumerator = this.TaskMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsTaken)
				{
					num++;
				}
			}
		}
		return (int)Math.Ceiling((double)((float)num * 1f / (float)count * 100f));
	}

	// Token: 0x06004B88 RID: 19336 RVA: 0x0019A290 File Offset: 0x00198490
	public List<BlackCoastTaskData> GetTaskList()
	{
		List<BlackCoastTaskData> list = new List<BlackCoastTaskData>(this.TaskMap.Values);
		NoLinq.SortStable<BlackCoastTaskData>(list, new Comparison<BlackCoastTaskData>(new BlackCoastStageInfo.TaskComparer().Compare));
		return list;
	}

	// Token: 0x06004B89 RID: 19337 RVA: 0x0019A2BC File Offset: 0x001984BC
	public string GetLockConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(ActivityBlackCoastConfig.Instance.GetStageConfig(this.StageId).Value.OpenConditionId) ?? "";
	}

	// Token: 0x06004B8A RID: 19338 RVA: 0x0019A2F8 File Offset: 0x001984F8
	public unsafe void StageUpdate(BlackCoastThemeStageInfo stageInfo)
	{
		foreach (ActivityTask activityTask in stageInfo.Tasks)
		{
			BlackCoastTaskData blackCoastTaskData;
			if (this.TaskMap.TryGetValue(activityTask.Id, out blackCoastTaskData))
			{
				int isFinished = blackCoastTaskData.IsFinished ? 1 : 0;
				blackCoastTaskData.Current = activityTask.Current;
				blackCoastTaskData.Target = activityTask.Target;
				blackCoastTaskData.Status = TaskStateResolver.TaskState[activityTask.Status];
				bool isFinished2 = blackCoastTaskData.IsFinished;
				if (isFinished == 0 && isFinished2)
				{
					this.OnStageTaskInfoChange(blackCoastTaskData.TaskId);
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[BlackCoastActivity] 活动Task不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("StageId", this.StageId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TaskId", activityTask.Id);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		this.IsUnlockInternal = true;
	}

	// Token: 0x06004B8B RID: 19339 RVA: 0x0019A41C File Offset: 0x0019861C
	public void SetTaskRewardGot(int taskId)
	{
		BlackCoastTaskData blackCoastTaskData;
		if (this.TaskMap.TryGetValue(taskId, out blackCoastTaskData))
		{
			blackCoastTaskData.Status = EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x06004B8C RID: 19340 RVA: 0x0019A440 File Offset: 0x00198640
	private void OnStageTaskInfoChange(int taskId)
	{
		BlackCoastTaskData blackCoastTaskData;
		if (this.TaskMap.TryGetValue(taskId, out blackCoastTaskData) && blackCoastTaskData.JumpId > 0)
		{
			AccessPath value = SkipInterfaceConfig.Instance.GetAccessPathConfig(blackCoastTaskData.JumpId).Value;
			if (value.SkipName == 8)
			{
				int value2 = int.Parse(value.Val1);
				MapModel.Instance.RemoveMapMarksByConfigId(new EMarkType?(EMarkType.Entity), new int?(value2));
			}
		}
	}

	// Token: 0x06004B8D RID: 19341 RVA: 0x0019A4AC File Offset: 0x001986AC
	private void RequestTaskReward(int taskId)
	{
		if (taskId == 0)
		{
			return;
		}
		ActivityBlackCoastController.Instance.RequestTaskReward(this.StageId, taskId);
	}

	// Token: 0x040037C8 RID: 14280
	public readonly Dictionary<int, BlackCoastTaskData> TaskMap = new Dictionary<int, BlackCoastTaskData>();

	// Token: 0x040037C9 RID: 14281
	private bool IsUnlockInternal;

	// Token: 0x02006917 RID: 26903
	[NullableContext(0)]
	private class TaskComparer : IComparer<BlackCoastTaskData>
	{
		// Token: 0x0603F42B RID: 259115 RVA: 0x012731A0 File Offset: 0x012713A0
		[NullableContext(1)]
		public int Compare(BlackCoastTaskData a, BlackCoastTaskData b)
		{
			if (a.Status != b.Status)
			{
				return a.Status - b.Status;
			}
			if (a.SortId != b.SortId)
			{
				return a.SortId - b.SortId;
			}
			return a.TaskId - b.TaskId;
		}
	}
}
