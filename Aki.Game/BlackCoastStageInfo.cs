using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x020011AC RID: 4524
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastStageInfo
{
	// Token: 0x17000A44 RID: 2628
	// (get) Token: 0x060077E7 RID: 30695 RVA: 0x00191418 File Offset: 0x0018F618
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

	// Token: 0x17000A45 RID: 2629
	// (get) Token: 0x060077E8 RID: 30696 RVA: 0x00191480 File Offset: 0x0018F680
	public bool IsUnlock
	{
		get
		{
			return this.StageState > EStageState.Lock;
		}
	}

	// Token: 0x17000A46 RID: 2630
	// (get) Token: 0x060077E9 RID: 30697 RVA: 0x0019148B File Offset: 0x0018F68B
	// (set) Token: 0x060077EA RID: 30698 RVA: 0x00191493 File Offset: 0x0018F693
	public int StageId { get; private set; }

	// Token: 0x17000A47 RID: 2631
	// (get) Token: 0x060077EB RID: 30699 RVA: 0x0019149C File Offset: 0x0018F69C
	// (set) Token: 0x060077EC RID: 30700 RVA: 0x001914A4 File Offset: 0x0018F6A4
	public int Index { get; private set; }

	// Token: 0x060077ED RID: 30701 RVA: 0x001914B0 File Offset: 0x0018F6B0
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

	// Token: 0x060077EE RID: 30702 RVA: 0x00191590 File Offset: 0x0018F790
	public string GetVideoSource()
	{
		return ActivityBlackCoastConfig.Instance.GetStageConfig(this.StageId).Value.VideoSource;
	}

	// Token: 0x060077EF RID: 30703 RVA: 0x001915C0 File Offset: 0x0018F7C0
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

	// Token: 0x060077F0 RID: 30704 RVA: 0x00191620 File Offset: 0x0018F820
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

	// Token: 0x060077F1 RID: 30705 RVA: 0x001916A4 File Offset: 0x0018F8A4
	public List<BlackCoastTaskData> GetTaskList()
	{
		return this.TaskMap.Values.OrderBy((BlackCoastTaskData task) => task, new BlackCoastStageInfo.TaskComparer()).ToList<BlackCoastTaskData>();
	}

	// Token: 0x060077F2 RID: 30706 RVA: 0x001916E0 File Offset: 0x0018F8E0
	public string GetLockConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(ActivityBlackCoastConfig.Instance.GetStageConfig(this.StageId).Value.OpenConditionId) ?? "";
	}

	// Token: 0x060077F3 RID: 30707 RVA: 0x0019171C File Offset: 0x0018F91C
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

	// Token: 0x060077F4 RID: 30708 RVA: 0x00191840 File Offset: 0x0018FA40
	public void SetTaskRewardGot(int taskId)
	{
		BlackCoastTaskData blackCoastTaskData;
		if (this.TaskMap.TryGetValue(taskId, out blackCoastTaskData))
		{
			blackCoastTaskData.Status = EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x060077F5 RID: 30709 RVA: 0x00191864 File Offset: 0x0018FA64
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

	// Token: 0x060077F6 RID: 30710 RVA: 0x001918D0 File Offset: 0x0018FAD0
	private void RequestTaskReward(int taskId)
	{
		if (taskId == 0)
		{
			return;
		}
		ActivityBlackCoastController.Instance.RequestTaskReward(this.StageId, taskId);
	}

	// Token: 0x0400372F RID: 14127
	public readonly Dictionary<int, BlackCoastTaskData> TaskMap = new Dictionary<int, BlackCoastTaskData>();

	// Token: 0x04003730 RID: 14128
	private bool IsUnlockInternal;

	// Token: 0x0200778A RID: 30602
	[NullableContext(0)]
	private class TaskComparer : IComparer<BlackCoastTaskData>
	{
		// Token: 0x06048FE9 RID: 298985 RVA: 0x012CFF28 File Offset: 0x012CE128
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
