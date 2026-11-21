using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200065D RID: 1629
[NullableContext(1)]
[Nullable(0)]
public class ActivityBlackCoastData : ActivityBaseData
{
	// Token: 0x06004B5F RID: 19295 RVA: 0x00199800 File Offset: 0x00197A00
	protected override void OnInit(ActivityData data)
	{
		this.InitProgressReward();
		this.InitStages();
	}

	// Token: 0x06004B60 RID: 19296 RVA: 0x00199810 File Offset: 0x00197A10
	protected override void PhraseEx(ActivityData data)
	{
		BlackCoastThemeActivity blackCoastThemeActivityData = data.BlackCoastThemeActivityData;
		if (blackCoastThemeActivityData == null)
		{
			return;
		}
		this.StageUpdate(blackCoastThemeActivityData.Stages);
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

	// Token: 0x06004B61 RID: 19297 RVA: 0x001998B4 File Offset: 0x00197AB4
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06004B62 RID: 19298 RVA: 0x001998B7 File Offset: 0x00197AB7
	public override bool GetExDataRedPointShowState()
	{
		return this.RewardRedDotState();
	}

	// Token: 0x06004B63 RID: 19299 RVA: 0x001998BF File Offset: 0x00197ABF
	public bool RewardRedDotState()
	{
		return this.HasProgressRewardRedDot() || this.HasStageRewardRedDot() || this.HasAnyNewStageRedDot();
	}

	// Token: 0x06004B64 RID: 19300 RVA: 0x001998D9 File Offset: 0x00197AD9
	public int GetProgressItemCount()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.ProgressItemId, 0);
	}

	// Token: 0x06004B65 RID: 19301 RVA: 0x001998EC File Offset: 0x00197AEC
	public int GetProgressItemTotal()
	{
		return this.ProgressItemTotal;
	}

	// Token: 0x17000A63 RID: 2659
	// (get) Token: 0x06004B66 RID: 19302 RVA: 0x001998F4 File Offset: 0x00197AF4
	public int GetProgressItemId
	{
		get
		{
			return this.ProgressItemId;
		}
	}

	// Token: 0x06004B67 RID: 19303 RVA: 0x001998FC File Offset: 0x00197AFC
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

	// Token: 0x06004B68 RID: 19304 RVA: 0x001999F8 File Offset: 0x00197BF8
	private int SortRewardData(BlackCoastProgressRewardData a, BlackCoastProgressRewardData b)
	{
		return a.Goal - b.Goal;
	}

	// Token: 0x06004B69 RID: 19305 RVA: 0x00199A08 File Offset: 0x00197C08
	public BlackCoastProgressRewardData GetProgressRewardDataById(int id)
	{
		BlackCoastProgressRewardData result;
		this.ProgressRewardMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x06004B6A RID: 19306 RVA: 0x00199A25 File Offset: 0x00197C25
	public BlackCoastProgressRewardData[] GetAllProgressRewardData()
	{
		return NoLinq.OrderByToArray<BlackCoastProgressRewardData, int>(this.ProgressRewardMap.Values, (BlackCoastProgressRewardData data) => data.Goal);
	}

	// Token: 0x06004B6B RID: 19307 RVA: 0x00199A58 File Offset: 0x00197C58
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

	// Token: 0x06004B6C RID: 19308 RVA: 0x00199AA0 File Offset: 0x00197CA0
	public void SetProgressRewardDataGot(IReadOnlyList<int> ids)
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

	// Token: 0x06004B6D RID: 19309 RVA: 0x00199B0C File Offset: 0x00197D0C
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

	// Token: 0x06004B6E RID: 19310 RVA: 0x00199B6C File Offset: 0x00197D6C
	public void SetTaskRewardGot(int stageId, int taskId)
	{
		BlackCoastStageInfo blackCoastStageInfo;
		this.Stages.TryGetValue(stageId, out blackCoastStageInfo);
		blackCoastStageInfo.SetTaskRewardGot(taskId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004B6F RID: 19311 RVA: 0x00199BA8 File Offset: 0x00197DA8
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

	// Token: 0x06004B70 RID: 19312 RVA: 0x00199C0C File Offset: 0x00197E0C
	public BlackCoastStageInfo GetStageById(int stageId)
	{
		BlackCoastStageInfo result;
		this.Stages.TryGetValue(stageId, out result);
		return result;
	}

	// Token: 0x06004B71 RID: 19313 RVA: 0x00199C29 File Offset: 0x00197E29
	public BlackCoastStageInfo[] GetAllStages()
	{
		return NoLinq.OrderByToArray<BlackCoastStageInfo, int>(this.Stages.Values, (BlackCoastStageInfo stage) => stage.StageId);
	}

	// Token: 0x06004B72 RID: 19314 RVA: 0x00199C5A File Offset: 0x00197E5A
	public int[] GetAllStagesId()
	{
		int[] array = NoLinq.ToArray<int>(this.Stages.Keys);
		Array.Sort<int>(array);
		return array;
	}

	// Token: 0x06004B73 RID: 19315 RVA: 0x00199C74 File Offset: 0x00197E74
	public void StageUpdate(IReadOnlyList<BlackCoastThemeStageInfo> stageInfoList)
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

	// Token: 0x06004B74 RID: 19316 RVA: 0x00199D20 File Offset: 0x00197F20
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

	// Token: 0x06004B75 RID: 19317 RVA: 0x00199D80 File Offset: 0x00197F80
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

	// Token: 0x06004B76 RID: 19318 RVA: 0x00199DFC File Offset: 0x00197FFC
	public bool HasNewStageFlag(int stageId)
	{
		BlackCoastStageInfo blackCoastStageInfo;
		this.Stages.TryGetValue(stageId, out blackCoastStageInfo);
		return blackCoastStageInfo.StageState == EStageState.Active && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, stageId, 0, 0) == 0;
	}

	// Token: 0x06004B77 RID: 19319 RVA: 0x00199E3A File Offset: 0x0019803A
	public void SaveNewStageFlag(int stageId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, stageId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004B78 RID: 19320 RVA: 0x00199E68 File Offset: 0x00198068
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

	// Token: 0x06004B79 RID: 19321 RVA: 0x00199EDC File Offset: 0x001980DC
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

	// Token: 0x040037BA RID: 14266
	private Dictionary<int, BlackCoastProgressRewardData> ProgressRewardMap = new Dictionary<int, BlackCoastProgressRewardData>();

	// Token: 0x040037BB RID: 14267
	private Dictionary<int, BlackCoastStageInfo> Stages = new Dictionary<int, BlackCoastStageInfo>();

	// Token: 0x040037BC RID: 14268
	private int ProgressItemId;

	// Token: 0x040037BD RID: 14269
	private int ProgressItemTotal;
}
