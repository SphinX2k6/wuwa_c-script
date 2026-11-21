using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020005C0 RID: 1472
[NullableContext(1)]
[Nullable(0)]
public class AvignonProtocolData : ActivityBaseData
{
	// Token: 0x06004597 RID: 17815 RVA: 0x0017DA15 File Offset: 0x0017BC15
	protected override void OnInit(ActivityData data)
	{
		this.InitStages();
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x0017DA20 File Offset: 0x0017BC20
	private void InitStages()
	{
		this.Stages.Clear();
		IReadOnlyList<AvignonStage> stageConfigAll = AvignonConfig.Instance.GetStageConfigAll();
		for (int i = 0; i < stageConfigAll.Count; i++)
		{
			AvignonStage avignonStage = stageConfigAll[i];
			AvignonStageInfo value = new AvignonStageInfo(avignonStage.Id, i);
			this.Stages[avignonStage.Id] = value;
		}
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x0017DA80 File Offset: 0x0017BC80
	protected override void PhraseEx(ActivityData data)
	{
		AvignonActivityInfo avignonActivityInfo = data.AvignonActivityInfo;
		if (avignonActivityInfo == null)
		{
			return;
		}
		foreach (ActivityTask taskInfo in avignonActivityInfo.ActivityTaskDatas.ActivityTasks)
		{
			this.UpdateTask(taskInfo);
		}
		foreach (int stageId in avignonActivityInfo.UnLockStepId)
		{
			this.UnlockStage(stageId);
		}
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x0017DB1C File Offset: 0x0017BD1C
	public void UpdateTask(ActivityTask taskInfo)
	{
		if (taskInfo == null || taskInfo.Id == 0)
		{
			return;
		}
		int stageIdByTaskId = this.GetStageIdByTaskId(taskInfo.Id);
		AvignonStageInfo avignonStageInfo;
		if (this.Stages.TryGetValue(stageIdByTaskId, out avignonStageInfo))
		{
			avignonStageInfo.UpdateTask(taskInfo);
		}
	}

	// Token: 0x0600459B RID: 17819 RVA: 0x0017DB5C File Offset: 0x0017BD5C
	public void UnlockStage(int stageId)
	{
		AvignonStageInfo avignonStageInfo;
		if (this.Stages.TryGetValue(stageId, out avignonStageInfo))
		{
			avignonStageInfo.UnlockStage();
		}
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x0017DB80 File Offset: 0x0017BD80
	public bool IsAllStagesUnlock()
	{
		using (Dictionary<int, AvignonStageInfo>.ValueCollection.Enumerator enumerator = this.Stages.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsUnlock)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x0017DBE0 File Offset: 0x0017BDE0
	public bool HasStageRewardRedDot()
	{
		using (Dictionary<int, AvignonStageInfo>.ValueCollection.Enumerator enumerator = this.Stages.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetRewardState())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600459E RID: 17822 RVA: 0x0017DC40 File Offset: 0x0017BE40
	public override bool GetExDataRedPointShowState()
	{
		bool flag = AvignonModel.Instance.CheckRedDot();
		return this.HasStageRewardRedDot() || flag;
	}

	// Token: 0x0600459F RID: 17823 RVA: 0x0017DC60 File Offset: 0x0017BE60
	public AvignonStageInfo GetStageInfo(int stageId)
	{
		AvignonStageInfo result;
		if (this.Stages.TryGetValue(stageId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060045A0 RID: 17824 RVA: 0x0017DC80 File Offset: 0x0017BE80
	public int[] GetAllStagesId()
	{
		List<int> list = new List<int>(this.Stages.Keys);
		list.Sort((int a, int b) => a - b);
		return list.ToArray();
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x0017DCBC File Offset: 0x0017BEBC
	public int? GetCurrentLockQuestId()
	{
		foreach (AvignonStageInfo avignonStageInfo in this.Stages.Values)
		{
			if (!avignonStageInfo.IsUnlock)
			{
				return new int?(AvignonConfig.Instance.GetStageConfigById(avignonStageInfo.StageId).Value.QuestionId);
			}
		}
		return null;
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x0017DD4C File Offset: 0x0017BF4C
	private int GetStageIdByTaskId(int taskId)
	{
		return AvignonConfig.Instance.GetAvignonTaskConfigByTaskId(taskId).Value.Step;
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x0017DD74 File Offset: 0x0017BF74
	public void TaskRewardGot(int taskId)
	{
		int stageIdByTaskId = this.GetStageIdByTaskId(taskId);
		this.Stages[stageIdByTaskId].SetTaskRewardGot(taskId);
	}

	// Token: 0x04003573 RID: 13683
	private readonly Dictionary<int, AvignonStageInfo> Stages = new Dictionary<int, AvignonStageInfo>();
}
