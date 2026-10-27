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

// Token: 0x020019EE RID: 6638
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DailyActivityModel : ModelBase
{
	// Token: 0x17001036 RID: 4150
	// (get) Token: 0x0600C227 RID: 49703 RVA: 0x002BD016 File Offset: 0x002BB216
	public int ActivityValue
	{
		get
		{
			return this.Activity;
		}
	}

	// Token: 0x17001037 RID: 4151
	// (get) Token: 0x0600C228 RID: 49704 RVA: 0x002BD01E File Offset: 0x002BB21E
	public int ActivityMaxValue
	{
		get
		{
			return this.MaxActivity;
		}
	}

	// Token: 0x17001038 RID: 4152
	// (get) Token: 0x0600C229 RID: 49705 RVA: 0x002BD026 File Offset: 0x002BB226
	public Dictionary<int, DailyActivityDefine.IActivityGoalData> DailyActivityGoalMap
	{
		get
		{
			return this.GoalDataMap;
		}
	}

	// Token: 0x17001039 RID: 4153
	// (get) Token: 0x0600C22A RID: 49706 RVA: 0x002BD02E File Offset: 0x002BB22E
	public List<DailyActiveTaskData> DailyActivityTaskList
	{
		get
		{
			return this.TaskDataList;
		}
	}

	// Token: 0x1700103A RID: 4154
	// (get) Token: 0x0600C22B RID: 49707 RVA: 0x002BD036 File Offset: 0x002BB236
	public long DayEndTime
	{
		get
		{
			return this.DayEnd;
		}
	}

	// Token: 0x1700103B RID: 4155
	// (get) Token: 0x0600C22C RID: 49708 RVA: 0x002BD03E File Offset: 0x002BB23E
	// (set) Token: 0x0600C22D RID: 49709 RVA: 0x002BD046 File Offset: 0x002BB246
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

	// Token: 0x0600C22E RID: 49710 RVA: 0x002BD04F File Offset: 0x002BB24F
	public bool ShouldShowLivenessRewardDoubleTag(int itemConfigId)
	{
		return itemConfigId == 1 && this.IsUnionExpDoubleBonusActive();
	}

	// Token: 0x0600C22F RID: 49711 RVA: 0x002BD05D File Offset: 0x002BB25D
	public bool IsUnionExpDoubleBonusActive()
	{
		return this.GetUnionExpDoubleBonusEndTime() > 0L;
	}

	// Token: 0x0600C230 RID: 49712 RVA: 0x002BD06C File Offset: 0x002BB26C
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

	// Token: 0x0600C231 RID: 49713 RVA: 0x002BD0FC File Offset: 0x002BB2FC
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

	// Token: 0x0600C232 RID: 49714 RVA: 0x002BD134 File Offset: 0x002BB334
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

	// Token: 0x0600C233 RID: 49715 RVA: 0x002BD204 File Offset: 0x002BB404
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600C234 RID: 49716 RVA: 0x002BD207 File Offset: 0x002BB407
	public void EmitDailyActivityStateCheck()
	{
		EventSystem.Instance.Emit(EEventName.DailyActivityStateNotify);
	}

	// Token: 0x0600C235 RID: 49717 RVA: 0x002BD219 File Offset: 0x002BB419
	public int? GetWeeklyChallengeRefreshTime()
	{
		return ((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Get(999);
	}

	// Token: 0x0600C236 RID: 49718 RVA: 0x002BD236 File Offset: 0x002BB436
	public void SetWeeklyChallengeRefreshTime(int time)
	{
		((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Set(999, time);
	}

	// Token: 0x0600C237 RID: 49719 RVA: 0x002BD254 File Offset: 0x002BB454
	public int? GetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab tab)
	{
		return ((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Get((int)tab);
	}

	// Token: 0x0600C238 RID: 49720 RVA: 0x002BD26D File Offset: 0x002BB46D
	public void SetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab tab, int time)
	{
		((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenDailyActivityTab)).Set((int)tab, time);
	}

	// Token: 0x0600C239 RID: 49721 RVA: 0x002BD288 File Offset: 0x002BB488
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

	// Token: 0x0600C23A RID: 49722 RVA: 0x002BD2D4 File Offset: 0x002BB4D4
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

	// Token: 0x0600C23B RID: 49723 RVA: 0x002BD410 File Offset: 0x002BB610
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

	// Token: 0x0600C23C RID: 49724 RVA: 0x002BD480 File Offset: 0x002BB680
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

	// Token: 0x0600C23D RID: 49725 RVA: 0x002BD4E4 File Offset: 0x002BB6E4
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

	// Token: 0x0600C23E RID: 49726 RVA: 0x002BD574 File Offset: 0x002BB774
	public List<TItem> GetActivityRewardById(int id)
	{
		return this.GoalDataMap[id].Rewards;
	}

	// Token: 0x0600C23F RID: 49727 RVA: 0x002BD588 File Offset: 0x002BB788
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

	// Token: 0x0600C240 RID: 49728 RVA: 0x002BD7F0 File Offset: 0x002BB9F0
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

	// Token: 0x0600C241 RID: 49729 RVA: 0x002BD984 File Offset: 0x002BBB84
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

	// Token: 0x0600C242 RID: 49730 RVA: 0x002BD9B0 File Offset: 0x002BBBB0
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

	// Token: 0x0600C243 RID: 49731 RVA: 0x002BD9D4 File Offset: 0x002BBBD4
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

	// Token: 0x0600C244 RID: 49732 RVA: 0x002BDA40 File Offset: 0x002BBC40
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

	// Token: 0x0600C245 RID: 49733 RVA: 0x002BDAA4 File Offset: 0x002BBCA4
	public bool CheckIsRewardWaitTake()
	{
		return this.CheckIsTaskRewardWaitTake() || this.CheckIsActivityRewardWaitTake();
	}

	// Token: 0x0600C246 RID: 49734 RVA: 0x002BDAB6 File Offset: 0x002BBCB6
	public bool CheckIsFinish()
	{
		return this.Activity >= this.MaxActivity;
	}

	// Token: 0x0600C247 RID: 49735 RVA: 0x002BDACC File Offset: 0x002BBCCC
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

	// Token: 0x1700103C RID: 4156
	// (get) Token: 0x0600C248 RID: 49736 RVA: 0x002BDB28 File Offset: 0x002BBD28
	public static DailyActivityModel Instance
	{
		get
		{
			return DailyActivityModel._Instance;
		}
	}

	// Token: 0x0600C249 RID: 49737 RVA: 0x002BDB2F File Offset: 0x002BBD2F
	public static DailyActivityModel GetOrCreateInstance()
	{
		if (DailyActivityModel._Instance == null)
		{
			DailyActivityModel.CreateInstance();
		}
		return DailyActivityModel._Instance;
	}

	// Token: 0x0600C24A RID: 49738 RVA: 0x002BDB43 File Offset: 0x002BBD43
	public static bool CreateInstance()
	{
		if (DailyActivityModel._Instance != null)
		{
			return true;
		}
		DailyActivityModel._Instance = new DailyActivityModel();
		return true;
	}

	// Token: 0x0600C24B RID: 49739 RVA: 0x002BDB59 File Offset: 0x002BBD59
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C24C RID: 49740 RVA: 0x002BDB5B File Offset: 0x002BBD5B
	public static void ResetStaticDefaultValue()
	{
		DailyActivityModel._Instance = null;
	}

	// Token: 0x0600C24D RID: 49741 RVA: 0x002BDB63 File Offset: 0x002BBD63
	static DailyActivityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyActivityModel.CreateStaticDefaultValue), new Action(DailyActivityModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005966 RID: 22886
	private int Activity;

	// Token: 0x04005967 RID: 22887
	private int MaxActivity;

	// Token: 0x04005968 RID: 22888
	private Dictionary<int, DailyActivityDefine.IActivityGoalData> GoalDataMap = new Dictionary<int, DailyActivityDefine.IActivityGoalData>();

	// Token: 0x04005969 RID: 22889
	private List<DailyActiveTaskData> TaskDataList = new List<DailyActiveTaskData>();

	// Token: 0x0400596A RID: 22890
	private long DayEnd;

	// Token: 0x0400596B RID: 22891
	[Nullable(2)]
	private RewardPopupData RewardPopupData;

	// Token: 0x0400596C RID: 22892
	public int AreaId;

	// Token: 0x0400596D RID: 22893
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RewardItemData> ShowRewardList;

	// Token: 0x0400596E RID: 22894
	[Nullable(2)]
	private static DailyActivityModel _Instance;

	// Token: 0x02007F26 RID: 32550
	[NullableContext(0)]
	public readonly struct LivenessUnionExpBonusSplitRule
	{
		// Token: 0x1700A065 RID: 41061
		// (get) Token: 0x06049CDD RID: 302301 RVA: 0x0131E889 File Offset: 0x0131CA89
		// (set) Token: 0x06049CDE RID: 302302 RVA: 0x0131E891 File Offset: 0x0131CA91
		public int BonusPercent { get; set; }
	}
}
