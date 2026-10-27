using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020011A9 RID: 4521
[NullableContext(1)]
[Nullable(0)]
public class ActivityBlackCoastData : ActivityBaseData
{
	// Token: 0x060077C8 RID: 30664 RVA: 0x00190C24 File Offset: 0x0018EE24
	protected override void OnInit(ActivityData data)
	{
		this.InitProgressReward();
		this.InitStages();
	}

	// Token: 0x060077C9 RID: 30665 RVA: 0x00190C34 File Offset: 0x0018EE34
	protected override void PhraseEx(ActivityData data)
	{
		BlackCoastThemeActivity blackCoastThemeActivityData = data.BlackCoastThemeActivityData;
		if (blackCoastThemeActivityData == null)
		{
			return;
		}
		this.StageUpdate(blackCoastThemeActivityData.Stages.ToArray<BlackCoastThemeStageInfo>());
		foreach (int num in blackCoastThemeActivityData.ActiveRewardedIds)
		{
			BlackCoastProgressRewardData progressRewardDataById = this.GetProgressRewardDataById(num);
			if (progressRewardDataById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[BlackCoastActivity] 奖励Id不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RewardId", num);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				progressRewardDataById.Achieved = true;
			}
		}
	}

	// Token: 0x060077CA RID: 30666 RVA: 0x00190CDC File Offset: 0x0018EEDC
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x060077CB RID: 30667 RVA: 0x00190CDF File Offset: 0x0018EEDF
	public override bool GetExDataRedPointShowState()
	{
		return this.RewardRedDotState();
	}

	// Token: 0x060077CC RID: 30668 RVA: 0x00190CE7 File Offset: 0x0018EEE7
	public bool RewardRedDotState()
	{
		return this.HasProgressRewardRedDot() || this.HasStageRewardRedDot() || this.HasAnyNewStageRedDot();
	}

	// Token: 0x060077CD RID: 30669 RVA: 0x00190D01 File Offset: 0x0018EF01
	public int GetProgressItemCount()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.ProgressItemId, 0);
	}

	// Token: 0x060077CE RID: 30670 RVA: 0x00190D14 File Offset: 0x0018EF14
	public int GetProgressItemTotal()
	{
		return this.ProgressItemTotal;
	}

	// Token: 0x17000A43 RID: 2627
	// (get) Token: 0x060077CF RID: 30671 RVA: 0x00190D1C File Offset: 0x0018EF1C
	public int GetProgressItemId
	{
		get
		{
			return this.ProgressItemId;
		}
	}

	// Token: 0x060077D0 RID: 30672 RVA: 0x00190D24 File Offset: 0x0018EF24
	public void InitProgressReward()
	{
		this.ProgressRewardMap.Clear();
		BlackCoastThemeConfig? activityConfig = ActivityBlackCoastConfig.Instance.GetActivityConfig(base.Id);
		if (activityConfig == null)
		{
			return;
		}
		this.ProgressItemId = activityConfig.Value.ItemId;
		foreach (BlackCoastThemeRewardRe blackCoastThemeRewardRe in ActivityBlackCoastConfig.Instance.GetAllRewardConfigByActivityId(base.Id))
		{
			BlackCoastProgressRewardData blackCoastProgressRewardData = new BlackCoastProgressRewardData();
			blackCoastProgressRewardData.Id = blackCoastThemeRewardRe.Id;
			blackCoastProgressRewardData.Goal = blackCoastThemeRewardRe.Active;
			blackCoastProgressRewardData.DropId = blackCoastThemeRewardRe.DropId;
			blackCoastProgressRewardData.GetCurrentGoal = new Func<int>(this.GetProgressItemCount);
			this.ProgressItemTotal = Math.Max(this.ProgressItemTotal, blackCoastProgressRewardData.Goal);
			this.ProgressRewardMap[blackCoastThemeRewardRe.Id] = blackCoastProgressRewardData;
		}
	}

	// Token: 0x060077D1 RID: 30673 RVA: 0x00190E20 File Offset: 0x0018F020
	private int SortRewardData(BlackCoastProgressRewardData a, BlackCoastProgressRewardData b)
	{
		return a.Goal - b.Goal;
	}

	// Token: 0x060077D2 RID: 30674 RVA: 0x00190E30 File Offset: 0x0018F030
	public BlackCoastProgressRewardData GetProgressRewardDataById(int id)
	{
		BlackCoastProgressRewardData result;
		this.ProgressRewardMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x060077D3 RID: 30675 RVA: 0x00190E4D File Offset: 0x0018F04D
	public BlackCoastProgressRewardData[] GetAllProgressRewardData()
	{
		return (from x in this.ProgressRewardMap.Values
		orderby x.Goal
		select x).ToArray<BlackCoastProgressRewardData>();
	}

	// Token: 0x060077D4 RID: 30676 RVA: 0x00190E84 File Offset: 0x0018F084
	public int[] GetAllAvailableProgressRewardIds()
	{
		List<int> list = new List<int>();
		foreach (BlackCoastProgressRewardData blackCoastProgressRewardData in this.GetAllProgressRewardData())
		{
			if (blackCoastProgressRewardData.GetState() == EActivityTaskState.FinishedAndUnclaimed)
			{
				list.Add(blackCoastProgressRewardData.Id);
			}
		}
		return list.ToArray();
	}

	// Token: 0x060077D5 RID: 30677 RVA: 0x00190ECC File Offset: 0x0018F0CC
	public void SetProgressRewardDataGot(int[] ids)
	{
		foreach (int id in ids)
		{
			BlackCoastProgressRewardData progressRewardDataById = this.GetProgressRewardDataById(id);
			if (progressRewardDataById != null)
			{
				progressRewardDataById.Achieved = true;
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060077D6 RID: 30678 RVA: 0x00190F18 File Offset: 0x0018F118
	public bool HasProgressRewardRedDot()
	{
		using (Dictionary<int, BlackCoastProgressRewardData>.ValueCollection.Enumerator enumerator = this.ProgressRewardMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetState() == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060077D7 RID: 30679 RVA: 0x00190F78 File Offset: 0x0018F178
	public void SetTaskRewardGot(int stageId, int taskId)
	{
		BlackCoastStageInfo blackCoastStageInfo;
		this.Stages.TryGetValue(stageId, out blackCoastStageInfo);
		blackCoastStageInfo.SetTaskRewardGot(taskId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060077D8 RID: 30680 RVA: 0x00190FB4 File Offset: 0x0018F1B4
	private void InitStages()
	{
		this.Stages.Clear();
		IReadOnlyList<BlackCoastThemeStageRe> allStageConfigByActivityId = ActivityBlackCoastConfig.Instance.GetAllStageConfigByActivityId(base.Id);
		for (int i = 0; i < allStageConfigByActivityId.Count; i++)
		{
			BlackCoastThemeStageRe blackCoastThemeStageRe = allStageConfigByActivityId[i];
			BlackCoastStageInfo value = new BlackCoastStageInfo(blackCoastThemeStageRe.Id, i);
			this.Stages[blackCoastThemeStageRe.Id] = value;
		}
	}

	// Token: 0x060077D9 RID: 30681 RVA: 0x00191018 File Offset: 0x0018F218
	public BlackCoastStageInfo GetStageById(int stageId)
	{
		BlackCoastStageInfo result;
		this.Stages.TryGetValue(stageId, out result);
		return result;
	}

	// Token: 0x060077DA RID: 30682 RVA: 0x00191035 File Offset: 0x0018F235
	public BlackCoastStageInfo[] GetAllStages()
	{
		return (from x in this.Stages.Values
		orderby x.StageId
		select x).ToArray<BlackCoastStageInfo>();
	}

	// Token: 0x060077DB RID: 30683 RVA: 0x0019106B File Offset: 0x0018F26B
	public int[] GetAllStagesId()
	{
		return (from x in this.Stages.Keys
		orderby x
		select x).ToArray<int>();
	}

	// Token: 0x060077DC RID: 30684 RVA: 0x001910A4 File Offset: 0x0018F2A4
	public void StageUpdate(BlackCoastThemeStageInfo[] stageInfoList)
	{
		foreach (BlackCoastThemeStageInfo blackCoastThemeStageInfo in stageInfoList)
		{
			BlackCoastStageInfo blackCoastStageInfo;
			this.Stages.TryGetValue(blackCoastThemeStageInfo.Id, out blackCoastStageInfo);
			if (blackCoastStageInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[BlackCoastActivity] 活动Stage不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", blackCoastThemeStageInfo.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				blackCoastStageInfo.StageUpdate(blackCoastThemeStageInfo);
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060077DD RID: 30685 RVA: 0x00191134 File Offset: 0x0018F334
	public bool HasStageRewardRedDot()
	{
		using (Dictionary<int, BlackCoastStageInfo>.ValueCollection.Enumerator enumerator = this.Stages.Values.GetEnumerator())
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

	// Token: 0x060077DE RID: 30686 RVA: 0x00191194 File Offset: 0x0018F394
	public bool HasAnyNewStageRedDot()
	{
		foreach (BlackCoastStageInfo blackCoastStageInfo in this.Stages.Values)
		{
			if (blackCoastStageInfo.StageState == EStageState.Active && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, blackCoastStageInfo.StageId, 0, 0) == 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060077DF RID: 30687 RVA: 0x00191210 File Offset: 0x0018F410
	public bool HasNewStageFlag(int stageId)
	{
		BlackCoastStageInfo blackCoastStageInfo;
		this.Stages.TryGetValue(stageId, out blackCoastStageInfo);
		return blackCoastStageInfo.StageState == EStageState.Active && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, stageId, 0, 0) == 0;
	}

	// Token: 0x060077E0 RID: 30688 RVA: 0x0019124E File Offset: 0x0018F44E
	public void SaveNewStageFlag(int stageId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, stageId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060077E1 RID: 30689 RVA: 0x0019127C File Offset: 0x0018F47C
	public int? GetCurrentLockQuestId()
	{
		BlackCoastStageInfo[] allStages = this.GetAllStages();
		int i = 0;
		while (i < allStages.Length)
		{
			BlackCoastStageInfo blackCoastStageInfo = allStages[i];
			if (!blackCoastStageInfo.IsUnlock)
			{
				BlackCoastThemeStageRe? stageConfig = ActivityBlackCoastConfig.Instance.GetStageConfig(blackCoastStageInfo.StageId);
				if (stageConfig == null)
				{
					return null;
				}
				return new int?(stageConfig.Value.QuestionId);
			}
			else
			{
				i++;
			}
		}
		return null;
	}

	// Token: 0x060077E2 RID: 30690 RVA: 0x001912F0 File Offset: 0x0018F4F0
	public WeaponTrialData[] GetPreviewWeaponDataList()
	{
		List<WeaponTrialData> list = new List<WeaponTrialData>();
		BlackCoastThemeConfig? activityConfig = ActivityBlackCoastConfig.Instance.GetActivityConfig(base.Id);
		if (activityConfig == null)
		{
			return list.ToArray();
		}
		for (int i = 0; i < activityConfig.Value.WeaponPreviewIdLength; i++)
		{
			int trialId = activityConfig.Value.WeaponPreviewId(i);
			WeaponTrialData weaponTrialData = new WeaponTrialData();
			weaponTrialData.SetTrialId(trialId, true);
			list.Add(weaponTrialData);
		}
		return list.ToArray();
	}

	// Token: 0x04003721 RID: 14113
	private Dictionary<int, BlackCoastProgressRewardData> ProgressRewardMap = new Dictionary<int, BlackCoastProgressRewardData>();

	// Token: 0x04003722 RID: 14114
	private Dictionary<int, BlackCoastStageInfo> Stages = new Dictionary<int, BlackCoastStageInfo>();

	// Token: 0x04003723 RID: 14115
	private int ProgressItemId;

	// Token: 0x04003724 RID: 14116
	private int ProgressItemTotal;
}
