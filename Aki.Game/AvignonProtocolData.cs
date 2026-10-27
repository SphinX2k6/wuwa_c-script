using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200110C RID: 4364
[NullableContext(1)]
[Nullable(0)]
public class AvignonProtocolData : ActivityBaseData
{
	// Token: 0x06007201 RID: 29185 RVA: 0x00175059 File Offset: 0x00173259
	protected override void OnInit(ActivityData data)
	{
		this.InitStages();
	}

	// Token: 0x06007202 RID: 29186 RVA: 0x00175064 File Offset: 0x00173264
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

	// Token: 0x06007203 RID: 29187 RVA: 0x001750C4 File Offset: 0x001732C4
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

	// Token: 0x06007204 RID: 29188 RVA: 0x00175160 File Offset: 0x00173360
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

	// Token: 0x06007205 RID: 29189 RVA: 0x001751A0 File Offset: 0x001733A0
	public void UnlockStage(int stageId)
	{
		AvignonStageInfo avignonStageInfo;
		if (this.Stages.TryGetValue(stageId, out avignonStageInfo))
		{
			avignonStageInfo.UnlockStage();
		}
	}

	// Token: 0x06007206 RID: 29190 RVA: 0x001751C4 File Offset: 0x001733C4
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

	// Token: 0x06007207 RID: 29191 RVA: 0x00175224 File Offset: 0x00173424
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

	// Token: 0x06007208 RID: 29192 RVA: 0x00175284 File Offset: 0x00173484
	public override bool GetExDataRedPointShowState()
	{
		bool flag = AvignonModel.Instance.CheckRedDot();
		return this.HasStageRewardRedDot() || flag;
	}

	// Token: 0x06007209 RID: 29193 RVA: 0x001752A4 File Offset: 0x001734A4
	public AvignonStageInfo GetStageInfo(int stageId)
	{
		AvignonStageInfo result;
		if (this.Stages.TryGetValue(stageId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600720A RID: 29194 RVA: 0x001752C4 File Offset: 0x001734C4
	public int[] GetAllStagesId()
	{
		List<int> list = new List<int>(this.Stages.Keys);
		list.Sort((int a, int b) => a - b);
		return list.ToArray();
	}

	// Token: 0x0600720B RID: 29195 RVA: 0x00175300 File Offset: 0x00173500
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

	// Token: 0x0600720C RID: 29196 RVA: 0x00175390 File Offset: 0x00173590
	private int GetStageIdByTaskId(int taskId)
	{
		return AvignonConfig.Instance.GetAvignonTaskConfigByTaskId(taskId).Value.Step;
	}

	// Token: 0x0600720D RID: 29197 RVA: 0x001753B8 File Offset: 0x001735B8
	public void TaskRewardGot(int taskId)
	{
		int stageIdByTaskId = this.GetStageIdByTaskId(taskId);
		this.Stages[stageIdByTaskId].SetTaskRewardGot(taskId);
	}

	// Token: 0x040034DA RID: 13530
	private readonly Dictionary<int, AvignonStageInfo> Stages = new Dictionary<int, AvignonStageInfo>();
}
