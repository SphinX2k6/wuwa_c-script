using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02000EAD RID: 3757
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DailyActivityModel : ModelBase
{
	// Token: 0x1700105B RID: 4187
	// (get) Token: 0x06009634 RID: 38452 RVA: 0x002C7FEE File Offset: 0x002C61EE
	public int ActivityValue
	{
		get
		{
			return this.Activity;
		}
	}

	// Token: 0x1700105C RID: 4188
	// (get) Token: 0x06009635 RID: 38453 RVA: 0x002C7FF6 File Offset: 0x002C61F6
	public int ActivityMaxValue
	{
		get
		{
			return this.MaxActivity;
		}
	}

	// Token: 0x1700105D RID: 4189
	// (get) Token: 0x06009636 RID: 38454 RVA: 0x002C7FFE File Offset: 0x002C61FE
	public Dictionary<int, DailyActivityDefine.IActivityGoalData> DailyActivityGoalMap
	{
		get
		{
			return this.GoalDataMap;
		}
	}

	// Token: 0x1700105E RID: 4190
	// (get) Token: 0x06009637 RID: 38455 RVA: 0x002C8006 File Offset: 0x002C6206
	public List<DailyActiveTaskData> DailyActivityTaskList
	{
		get
		{
			return this.TaskDataList;
		}
	}

	// Token: 0x1700105F RID: 4191
	// (get) Token: 0x06009638 RID: 38456 RVA: 0x002C800E File Offset: 0x002C620E
	public long DayEndTime
	{
		get
		{
			return this.DayEnd;
		}
	}

	// Token: 0x17001060 RID: 4192
	// (get) Token: 0x06009639 RID: 38457 RVA: 0x002C8016 File Offset: 0x002C6216
	// (set) Token: 0x0600963A RID: 38458 RVA: 0x002C801E File Offset: 0x002C621E
	[Nullable(2)]
	public RewardPopupData RewardData
	{
		[NullableContext(2)]
		get
		{
			return this.RewardPopupData;
		}
		[NullableContext(2)]
		set
		{
			this.RewardPopupData = value;
		}
	}

	// Token: 0x0600963B RID: 38459 RVA: 0x002C8027 File Offset: 0x002C6227
	public bool ShouldShowLivenessRewardDoubleTag(int itemConfigId)
	{
		return itemConfigId == 1 && this.IsUnionExpDoubleBonusActive();
	}

	// Token: 0x0600963C RID: 38460 RVA: 0x002C8035 File Offset: 0x002C6235
	public bool IsUnionExpDoubleBonusActive()
	{
		return this.GetUnionExpDoubleBonusEndTime() > 0L;
	}

	// Token: 0x0600963D RID: 38461 RVA: 0x002C8044 File Offset: 0x002C6244
	public long GetUnionExpDoubleBonusEndTime()
	{
		List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.NewPlayerSupportActivityV2);
		double serverTime = TimeUtil.Instance.GetServerTime();
		long num = 0L;
		foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
		{
			ActivityNewPlayerSupportActivityV2Data activityNewPlayerSupportActivityV2Data = activityBaseData as ActivityNewPlayerSupportActivityV2Data;
			if (activityNewPlayerSupportActivityV2Data != null && activityNewPlayerSupportActivityV2Data.CheckIfInShowTime())
			{
				long nbLivenessEndShowTime = activityNewPlayerSupportActivityV2Data.NbLivenessEndShowTime;
				if (nbLivenessEndShowTime > 0L && serverTime < (double)nbLivenessEndShowTime && nbLivenessEndShowTime > num)
				{
					num = nbLivenessEndShowTime;
				}
			}
		}
		return num;
	}

	// Token: 0x0600963E RID: 38462 RVA: 0x002C80D4 File Offset: 0x002C62D4
	public bool TryGetActiveLivenessUnionExpBonusSplitRule(out DailyActivityModel.LivenessUnionExpBonusSplitRule rule)
	{
		rule = default(DailyActivityModel.LivenessUnionExpBonusSplitRule);
		if (!this.IsUnionExpDoubleBonusActive())
		{
			return false;
		}
		rule = new DailyActivityModel.LivenessUnionExpBonusSplitRule
		{
			BonusPercent = 50
		};
		return true;
	}

	// Token: 0x0600963F RID: 38463 RVA: 0x002C810C File Offset: 0x002C630C
	[NullableContext(2)]
	public string GetUnionExpDoubleBonusRemainArgForBanner()
	{
		long unionExpDoubleBonusEndTime = this.GetUnionExpDoubleBonusEndTime();
		if (unionExpDoubleBonusEndTime <= 0L)
		{
			return null;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)unionExpDoubleBonusEndTime - serverTime, 0.0);
		if (num <= 0.0)
		{
			return null;
		}
		if (num <= TimeUtil.Instance.Minute)
		{
			return ConfigMultiTextLang.GetLocalTextNew("Text_RefreshText_Text01", null) ?? "";
		}
		CommonDefine.ETimeType value = (num >= 86400.0) ? CommonDefine.ETimeType.Day : ((num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
		CommonDefine.ETimeType value2 = (num >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2)).CountDownText ?? "";
	}

	// Token: 0x06009640 RID: 38464 RVA: 0x002C81DC File Offset: 0x002C63DC
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06009641 RID: 38465 RVA: 0x002C81DF File Offset: 0x002C63DF
	public void EmitDailyActivityStateCheck()
	{
		EventSystem.Instance.Emit(EEventName.DailyActivityStateNotify);
	}

	// Token: 0x06009642 RID: 38466 RVA: 0x002C81F1 File Offset: 0x002C63F1
	public int? GetWeeklyChallengeRefreshTime()
	{
		return ((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Get(999);
	}

	// Token: 0x06009643 RID: 38467 RVA: 0x002C820E File Offset: 0x002C640E
	public void SetWeeklyChallengeRefreshTime(int time)
	{
		((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Set(999, time);
	}

	// Token: 0x06009644 RID: 38468 RVA: 0x002C822C File Offset: 0x002C642C
	public int? GetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab tab)
	{
		return ((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Get((int)tab);
	}

	// Token: 0x06009645 RID: 38469 RVA: 0x002C8245 File Offset: 0x002C6445
	public void SetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab tab, int time)
	{
		((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Set((int)tab, time);
	}

	// Token: 0x06009646 RID: 38470 RVA: 0x002C8260 File Offset: 0x002C6460
	public void MarkWeeklyPlayOpened()
	{
		long weeklyEndTime = WeeklyChallengeModel.Instance.WeeklyEndTime;
		if (weeklyEndTime <= 0L)
		{
			return;
		}
		if ((long)this.GetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab.Weekly).GetValueOrDefault() == weeklyEndTime)
		{
			return;
		}
		this.SetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab.Weekly, (int)weeklyEndTime);
		EventSystem.Instance.Emit(EEventName.WeeklyChallengeRefreshRedDotChanged);
	}

	// Token: 0x06009647 RID: 38471 RVA: 0x002C82AC File Offset: 0x002C64AC
	public void InitGoalData()
	{
		this.GoalDataMap = new Dictionary<int, DailyActivityDefine.IActivityGoalData>();
		IReadOnlyList<Liveness> allActivityGoalData = DailyActivityConfig.Instance.GetAllActivityGoalData();
		foreach (Liveness liveness in allActivityGoalData)
		{
			Dictionary<int, int> dropShowInfo = DailyActivityConfig.Instance.GetDropShowInfo(liveness.DropId);
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in dropShowInfo)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				list.Add(new TItem(new InventoryDefine.GetItemData(key, 0), value));
			}
			ActivityGoalData value2 = new ActivityGoalData
			{
				Id = liveness.Id,
				Goal = liveness.Goal,
				Rewards = list,
				Achieved = false,
				State = EDailyActiveState.Unfinished
			};
			this.GoalDataMap.Add(liveness.Id, value2);
		}
		this.MaxActivity = allActivityGoalData[allActivityGoalData.Count - 1].Goal;
	}

	// Token: 0x06009648 RID: 38472 RVA: 0x002C83E8 File Offset: 0x002C65E8
	public List<int> GetCanRewardIdList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, DailyActivityDefine.IActivityGoalData> keyValuePair in this.DailyActivityGoalMap)
		{
			if (keyValuePair.Value.State == EDailyActiveState.FinishedAndNotTaken)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x06009649 RID: 38473 RVA: 0x002C8458 File Offset: 0x002C6658
	public void RefreshActivityInfo(int[] goalIds)
	{
		foreach (int key in goalIds)
		{
			DailyActivityDefine.IActivityGoalData activityGoalData;
			if (this.GoalDataMap.TryGetValue(key, out activityGoalData))
			{
				activityGoalData.Achieved = true;
				activityGoalData.State = this.GetActivityGoalState(activityGoalData.Goal, true);
			}
		}
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.DailyActivityRewardTake, goalIds);
		this.EmitDailyActivityStateCheck();
	}

	// Token: 0x0600964A RID: 38474 RVA: 0x002C84BC File Offset: 0x002C66BC
	public void RefreshActivityValue(int value)
	{
		this.Activity = value;
		foreach (KeyValuePair<int, DailyActivityDefine.IActivityGoalData> keyValuePair in this.GoalDataMap)
		{
			DailyActivityDefine.IActivityGoalData value2 = keyValuePair.Value;
			value2.State = this.GetActivityGoalState(value2.Goal, value2.Achieved);
		}
		EventSystem.Instance.Emit<int>(EEventName.DailyActivityValueChange, this.Activity);
		this.EmitDailyActivityStateCheck();
	}

	// Token: 0x0600964B RID: 38475 RVA: 0x002C854C File Offset: 0x002C674C
	public List<TItem> GetActivityRewardById(int id)
	{
		return this.GoalDataMap[id].Rewards;
	}

	// Token: 0x0600964C RID: 38476 RVA: 0x002C8560 File Offset: 0x002C6760
	public void RefreshDailyActivityData(LivenessInfo activityInfo)
	{
		this.Activity = ((activityInfo != null) ? activityInfo.LivenessCount : 0);
		this.DayEnd = ((activityInfo != null) ? activityInfo.DayEnd : 0L);
		foreach (KeyValuePair<int, DailyActivityDefine.IActivityGoalData> keyValuePair in this.GoalDataMap)
		{
			DailyActivityDefine.IActivityGoalData value = keyValuePair.Value;
			bool flag = activityInfo.RewardedLiveness.Contains(value.Id);
			value.Achieved = flag;
			value.State = this.GetActivityGoalState(value.Goal, flag);
		}
		this.AreaId = activityInfo.AreaId;
		this.TaskDataList.Clear();
		foreach (Aki.Protocol.LivenessTask livenessTask in activityInfo.Tasks)
		{
			DailyActiveTaskData dailyActiveTaskData = new DailyActiveTaskData();
			dailyActiveTaskData.TaskId = new int?(livenessTask.Id);
			dailyActiveTaskData.CurrentProgress = new int?(livenessTask.Current);
			dailyActiveTaskData.TargetProgress = new int?(livenessTask.Target);
			dailyActiveTaskData.IsFunctionUnlock = livenessTask.IsConditionUnlock;
			if (!livenessTask.IsFinished)
			{
				dailyActiveTaskData.TaskState = EDailyActiveState.Unfinished;
			}
			else if (!livenessTask.IsTaken)
			{
				dailyActiveTaskData.TaskState = EDailyActiveState.FinishedAndNotTaken;
			}
			else
			{
				dailyActiveTaskData.TaskState = EDailyActiveState.FinishedAndTaken;
			}
			Aki.Config.LivenessTask value2 = DailyActivityConfig.Instance.GetActivityTaskConfigById(livenessTask.Id).Value;
			dailyActiveTaskData.Sort = value2.SortRank;
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair2 in value2.TaskReward())
			{
				int num;
				int num2;
				keyValuePair2.Deconstruct(out num, out num2);
				int itemId = num;
				int count = num2;
				list.Add(new TItem(new InventoryDefine.GetItemData(itemId, 0), count));
			}
			dailyActiveTaskData.RewardItemList = list;
			this.TaskDataList.Add(dailyActiveTaskData);
		}
		this.SortTaskDataList();
		EventSystem.Instance.Emit(EEventName.DailyActivityRefresh);
		this.EmitDailyActivityStateCheck();
	}

	// Token: 0x0600964D RID: 38477 RVA: 0x002C87C8 File Offset: 0x002C69C8
	public void UpdateDailyActivityData(LivenessInfo activityInfo)
	{
		this.Activity = ((activityInfo != null) ? activityInfo.LivenessCount : 0);
		foreach (int key in activityInfo.RewardedLiveness)
		{
			DailyActivityDefine.IActivityGoalData activityGoalData;
			if (this.GoalDataMap.TryGetValue(key, out activityGoalData))
			{
				activityGoalData.Achieved = true;
				activityGoalData.State = this.GetActivityGoalState(activityGoalData.Goal, true);
			}
		}
		this.AreaId = activityInfo.AreaId;
		foreach (Aki.Protocol.LivenessTask livenessTask in activityInfo.Tasks)
		{
			DailyActiveTaskData dailyActiveTaskData = null;
			foreach (DailyActiveTaskData dailyActiveTaskData2 in this.TaskDataList)
			{
				int? taskId = dailyActiveTaskData2.TaskId;
				int id = livenessTask.Id;
				if (taskId.GetValueOrDefault() == id & taskId != null)
				{
					dailyActiveTaskData = dailyActiveTaskData2;
					break;
				}
			}
			dailyActiveTaskData.CurrentProgress = new int?(livenessTask.Current);
			if (!livenessTask.IsFinished)
			{
				dailyActiveTaskData.TaskState = EDailyActiveState.Unfinished;
			}
			else if (!livenessTask.IsTaken)
			{
				dailyActiveTaskData.TaskState = EDailyActiveState.FinishedAndNotTaken;
			}
			else
			{
				dailyActiveTaskData.TaskState = EDailyActiveState.FinishedAndTaken;
			}
		}
		this.SortTaskDataList();
		EventSystem.Instance.Emit(EEventName.DailyActivityTaskUpdate);
		this.EmitDailyActivityStateCheck();
	}

	// Token: 0x0600964E RID: 38478 RVA: 0x002C895C File Offset: 0x002C6B5C
	public void SortTaskDataList()
	{
		this.TaskDataList.Sort(delegate(DailyActiveTaskData a, DailyActiveTaskData b)
		{
			if (a.TaskState != b.TaskState)
			{
				return a.TaskState - b.TaskState;
			}
			if (a.Sort == b.Sort)
			{
				return a.TaskId.Value - b.TaskId.Value;
			}
			return a.Sort - b.Sort;
		});
	}

	// Token: 0x0600964F RID: 38479 RVA: 0x002C8988 File Offset: 0x002C6B88
	public EDailyActiveState GetActivityGoalState(int goalValue, bool isClaimed)
	{
		EDailyActiveState result = EDailyActiveState.Unfinished;
		if (isClaimed)
		{
			result = EDailyActiveState.FinishedAndTaken;
		}
		else if (this.ActivityValue >= goalValue)
		{
			result = EDailyActiveState.FinishedAndNotTaken;
		}
		return result;
	}

	// Token: 0x06009650 RID: 38480 RVA: 0x002C89AC File Offset: 0x002C6BAC
	private bool CheckIsTaskRewardWaitTake()
	{
		if (this.Activity >= this.MaxActivity)
		{
			return false;
		}
		using (List<DailyActiveTaskData>.Enumerator enumerator = this.DailyActivityTaskList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.TaskState == EDailyActiveState.FinishedAndNotTaken)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06009651 RID: 38481 RVA: 0x002C8A18 File Offset: 0x002C6C18
	private bool CheckIsActivityRewardWaitTake()
	{
		bool result = false;
		foreach (KeyValuePair<int, DailyActivityDefine.IActivityGoalData> keyValuePair in this.GoalDataMap)
		{
			if (keyValuePair.Value.State == EDailyActiveState.FinishedAndNotTaken)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x06009652 RID: 38482 RVA: 0x002C8A7C File Offset: 0x002C6C7C
	public bool CheckIsRewardWaitTake()
	{
		return this.CheckIsTaskRewardWaitTake() || this.CheckIsActivityRewardWaitTake();
	}

	// Token: 0x06009653 RID: 38483 RVA: 0x002C8A8E File Offset: 0x002C6C8E
	public bool CheckIsFinish()
	{
		return this.Activity >= this.MaxActivity;
	}

	// Token: 0x06009654 RID: 38484 RVA: 0x002C8AA4 File Offset: 0x002C6CA4
	public int GetLastNotTaken()
	{
		int result = 0;
		List<int> list = new List<int>(this.DailyActivityGoalMap.Keys);
		for (int i = list.Count - 1; i >= 0; i--)
		{
			int key = list[i];
			DailyActivityDefine.IActivityGoalData activityGoalData;
			if (this.DailyActivityGoalMap.TryGetValue(key, out activityGoalData) && activityGoalData.State == EDailyActiveState.FinishedAndNotTaken)
			{
				result = i + 1;
				break;
			}
		}
		return result;
	}

	// Token: 0x17001061 RID: 4193
	// (get) Token: 0x06009655 RID: 38485 RVA: 0x002C8B00 File Offset: 0x002C6D00
	public static DailyActivityModel Instance
	{
		get
		{
			return DailyActivityModel._Instance;
		}
	}

	// Token: 0x06009656 RID: 38486 RVA: 0x002C8B07 File Offset: 0x002C6D07
	public static DailyActivityModel GetOrCreateInstance()
	{
		if (DailyActivityModel._Instance == null)
		{
			DailyActivityModel.CreateInstance();
		}
		return DailyActivityModel._Instance;
	}

	// Token: 0x06009657 RID: 38487 RVA: 0x002C8B1B File Offset: 0x002C6D1B
	public static bool CreateInstance()
	{
		if (DailyActivityModel._Instance != null)
		{
			return true;
		}
		DailyActivityModel._Instance = new DailyActivityModel();
		return true;
	}

	// Token: 0x06009658 RID: 38488 RVA: 0x002C8B31 File Offset: 0x002C6D31
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009659 RID: 38489 RVA: 0x002C8B33 File Offset: 0x002C6D33
	public static void ResetStaticDefaultValue()
	{
		DailyActivityModel._Instance = null;
	}

	// Token: 0x0600965A RID: 38490 RVA: 0x002C8B3B File Offset: 0x002C6D3B
	static DailyActivityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyActivityModel.CreateStaticDefaultValue), new Action(DailyActivityModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005A35 RID: 23093
	private int Activity;

	// Token: 0x04005A36 RID: 23094
	private int MaxActivity;

	// Token: 0x04005A37 RID: 23095
	private Dictionary<int, DailyActivityDefine.IActivityGoalData> GoalDataMap = new Dictionary<int, DailyActivityDefine.IActivityGoalData>();

	// Token: 0x04005A38 RID: 23096
	private List<DailyActiveTaskData> TaskDataList = new List<DailyActiveTaskData>();

	// Token: 0x04005A39 RID: 23097
	private long DayEnd;

	// Token: 0x04005A3A RID: 23098
	[Nullable(2)]
	private RewardPopupData RewardPopupData;

	// Token: 0x04005A3B RID: 23099
	public int AreaId;

	// Token: 0x04005A3C RID: 23100
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RewardItemData> ShowRewardList;

	// Token: 0x04005A3D RID: 23101
	[Nullable(2)]
	private static DailyActivityModel _Instance;

	// Token: 0x020070B5 RID: 28853
	[NullableContext(0)]
	public readonly struct LivenessUnionExpBonusSplitRule
	{
		// Token: 0x17007803 RID: 30723
		// (get) Token: 0x060400FB RID: 262395 RVA: 0x012C1D85 File Offset: 0x012BFF85
		// (set) Token: 0x060400FC RID: 262396 RVA: 0x012C1D8D File Offset: 0x012BFF8D
		public int BonusPercent { get; set; }
	}
}
