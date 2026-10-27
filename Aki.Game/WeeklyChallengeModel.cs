using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

// Token: 0x02002D2F RID: 11567
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeeklyChallengeModel : ModelBase
{
	// Token: 0x170020C9 RID: 8393
	// (get) Token: 0x06018505 RID: 99589 RVA: 0x00630509 File Offset: 0x0062E709
	public int WeeklyConfigId
	{
		get
		{
			return this.ConfigId;
		}
	}

	// Token: 0x170020CA RID: 8394
	// (get) Token: 0x06018506 RID: 99590 RVA: 0x00630511 File Offset: 0x0062E711
	public List<int> WeeklyPlayIds
	{
		get
		{
			return new List<int>(this.WeeklyPlayDataMap.Keys);
		}
	}

	// Token: 0x170020CB RID: 8395
	// (get) Token: 0x06018507 RID: 99591 RVA: 0x00630523 File Offset: 0x0062E723
	public long WeeklyBeginTime
	{
		get
		{
			return this.BeginTime;
		}
	}

	// Token: 0x170020CC RID: 8396
	// (get) Token: 0x06018508 RID: 99592 RVA: 0x0063052B File Offset: 0x0062E72B
	public long WeeklyEndTime
	{
		get
		{
			return this.EndTime;
		}
	}

	// Token: 0x170020CD RID: 8397
	// (get) Token: 0x06018509 RID: 99593 RVA: 0x00630533 File Offset: 0x0062E733
	public int WeeklyCurrentScore
	{
		get
		{
			return this.CurrentScore;
		}
	}

	// Token: 0x170020CE RID: 8398
	// (get) Token: 0x0601850A RID: 99594 RVA: 0x0063053B File Offset: 0x0062E73B
	public List<int> WeeklyClaimedScoreTaskIds
	{
		get
		{
			return this.ClaimedScoreTaskIds;
		}
	}

	// Token: 0x170020CF RID: 8399
	// (get) Token: 0x0601850B RID: 99595 RVA: 0x00630543 File Offset: 0x0062E743
	public int WeeklyWorldLevel
	{
		get
		{
			return this.WorldLevel;
		}
	}

	// Token: 0x170020D0 RID: 8400
	// (get) Token: 0x0601850C RID: 99596 RVA: 0x0063054B File Offset: 0x0062E74B
	public int WeeklyMaxScore
	{
		get
		{
			return this.ScoreMax;
		}
	}

	// Token: 0x170020D1 RID: 8401
	// (get) Token: 0x0601850D RID: 99597 RVA: 0x00630553 File Offset: 0x0062E753
	public IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> WeeklyGoalMap
	{
		get
		{
			return this.ScoreGoalMap;
		}
	}

	// Token: 0x0601850E RID: 99598 RVA: 0x0063055B File Offset: 0x0062E75B
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		return true;
	}

	// Token: 0x0601850F RID: 99599 RVA: 0x0063057A File Offset: 0x0062E77A
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		return true;
	}

	// Token: 0x06018510 RID: 99600 RVA: 0x0063059C File Offset: 0x0062E79C
	public void RefreshData(WeeklyFrameworkInfo info)
	{
		this.ConfigId = info.ConfigId;
		this.BeginTime = info.BeginTime;
		this.EndTime = info.EndTime;
		this.ClaimedScoreTaskIds = new List<int>(info.ScoreTasks);
		this.WorldLevel = info.WorldLevel;
		this.RefreshWeeklyPlayData(info.WeeklyPlayDatas);
		this.InitGoalData();
		this.RefreshGoalMapClaimedState();
		this.RefreshCurrentScore();
		this.ReportEndTimeRefreshLogEvent();
		EventSystem.Instance.Emit(EEventName.WeeklyChallengeRefresh);
	}

	// Token: 0x06018511 RID: 99601 RVA: 0x00630620 File Offset: 0x0062E820
	public void InitGoalData()
	{
		if (this.ScoreGoalMap.Count != 0 && this.LastInitWorldLevel == this.WorldLevel)
		{
			foreach (DailyActivityDefine.IActivityGoalData activityGoalData in this.ScoreGoalMap.Values)
			{
				activityGoalData.Achieved = false;
				activityGoalData.State = EDailyActiveState.Unfinished;
			}
			return;
		}
		this.ScoreGoalMap.Clear();
		WeeklyChallengeConfig instance = WeeklyChallengeConfig.Instance;
		IReadOnlyList<WeeklyFrameAward> readOnlyList = (instance != null) ? instance.GetAllScoreRewardTasks() : null;
		if (readOnlyList == null || readOnlyList.Count == 0)
		{
			return;
		}
		foreach (WeeklyFrameAward weeklyFrameAward in readOnlyList)
		{
			List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(weeklyFrameAward.DropId, new int?(this.WorldLevel));
			ActivityGoalData value = new ActivityGoalData
			{
				Id = weeklyFrameAward.Id,
				Goal = weeklyFrameAward.Score,
				Rewards = exchangeRewardPreviewRewardList,
				Achieved = false,
				State = EDailyActiveState.Unfinished
			};
			this.ScoreGoalMap[weeklyFrameAward.Id] = value;
		}
		this.ScoreMax = readOnlyList[readOnlyList.Count - 1].Score;
		this.LastInitWorldLevel = this.WorldLevel;
	}

	// Token: 0x06018512 RID: 99602 RVA: 0x00630788 File Offset: 0x0062E988
	private void RefreshGoalMapClaimedState()
	{
		foreach (DailyActivityDefine.IActivityGoalData activityGoalData in this.ScoreGoalMap.Values)
		{
			bool flag = this.ClaimedScoreTaskIds.Contains(activityGoalData.Id);
			activityGoalData.Achieved = flag;
			activityGoalData.State = this.GetGoalState(activityGoalData.Goal, flag);
		}
	}

	// Token: 0x06018513 RID: 99603 RVA: 0x00630808 File Offset: 0x0062EA08
	public EDailyActiveState GetGoalState(int goalScore, bool isClaimed)
	{
		if (isClaimed)
		{
			return EDailyActiveState.FinishedAndTaken;
		}
		if (this.CurrentScore >= goalScore)
		{
			return EDailyActiveState.FinishedAndNotTaken;
		}
		return EDailyActiveState.Unfinished;
	}

	// Token: 0x06018514 RID: 99604 RVA: 0x0063081C File Offset: 0x0062EA1C
	public List<int> GetCanRewardIdList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, DailyActivityDefine.IActivityGoalData> keyValuePair in this.ScoreGoalMap)
		{
			if (keyValuePair.Value.State == EDailyActiveState.FinishedAndNotTaken)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x06018515 RID: 99605 RVA: 0x0063088C File Offset: 0x0062EA8C
	private void RefreshWeeklyPlayData(RepeatedField<Aki.Protocol.WeeklyPlayData> dataList)
	{
		this.WeeklyPlayDataMap.Clear();
		foreach (Aki.Protocol.WeeklyPlayData weeklyPlayData in dataList)
		{
			this.WeeklyPlayDataMap[weeklyPlayData.Id] = new global::WeeklyPlayData
			{
				PlayId = weeklyPlayData.Id,
				Type = weeklyPlayData.Type,
				HasRecord = this.CheckIsSaved(weeklyPlayData)
			};
		}
	}

	// Token: 0x06018516 RID: 99606 RVA: 0x00630914 File Offset: 0x0062EB14
	[NullableContext(2)]
	public global::WeeklyPlayData GetWeeklyPlayData(int playId)
	{
		return this.WeeklyPlayDataMap.GetValueOrDefault(playId);
	}

	// Token: 0x06018517 RID: 99607 RVA: 0x00630924 File Offset: 0x0062EB24
	private bool CheckIsSaved(Aki.Protocol.WeeklyPlayData data)
	{
		ActivityType type = data.Type;
		if (type != ActivityType.RogueWeekly)
		{
			return type == ActivityType.FloroRanchActivity && data.FloroFarmPlayData != null && data.FloroFarmPlayData.HasRecord;
		}
		return data.RogueWeeklyPlayData != null && data.RogueWeeklyPlayData.HasRecord;
	}

	// Token: 0x06018518 RID: 99608 RVA: 0x00630974 File Offset: 0x0062EB74
	public List<TItem> GetRewardById(int id)
	{
		DailyActivityDefine.IActivityGoalData activityGoalData;
		if (!this.ScoreGoalMap.TryGetValue(id, out activityGoalData))
		{
			return new List<TItem>();
		}
		return activityGoalData.Rewards;
	}

	// Token: 0x06018519 RID: 99609 RVA: 0x006309A0 File Offset: 0x0062EBA0
	private int GetScoreId()
	{
		return ConfigCommonParamById.GetIntConfig("WeeklyChallengeScoreId").GetValueOrDefault();
	}

	// Token: 0x0601851A RID: 99610 RVA: 0x006309C0 File Offset: 0x0062EBC0
	public string GetWeeklyScoreStr()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentScore);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ScoreMax);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0601851B RID: 99611 RVA: 0x00630A04 File Offset: 0x0062EC04
	public void RefreshCurrentScore()
	{
		int scoreId = this.GetScoreId();
		if (scoreId <= 0)
		{
			return;
		}
		InventoryModel instance = InventoryModel.Instance;
		this.CurrentScore = ((instance != null) ? instance.GetItemCountByConfigId(scoreId, 0) : 0);
		foreach (DailyActivityDefine.IActivityGoalData activityGoalData in this.ScoreGoalMap.Values)
		{
			if (!activityGoalData.Achieved)
			{
				activityGoalData.State = this.GetGoalState(activityGoalData.Goal, false);
			}
		}
		EventSystem.Instance.Emit(EEventName.WeeklyChallengeScoreChanged);
	}

	// Token: 0x0601851C RID: 99612 RVA: 0x00630AA8 File Offset: 0x0062ECA8
	public void OnScoreTasksClaimed(List<int> taskIds)
	{
		foreach (int num in taskIds)
		{
			if (!this.ClaimedScoreTaskIds.Contains(num))
			{
				this.ClaimedScoreTaskIds.Add(num);
			}
			DailyActivityDefine.IActivityGoalData activityGoalData;
			if (this.ScoreGoalMap.TryGetValue(num, out activityGoalData))
			{
				activityGoalData.Achieved = true;
				activityGoalData.State = EDailyActiveState.FinishedAndTaken;
			}
		}
		EventSystem.Instance.Emit(EEventName.WeeklyChallengeRewardStateChanged);
	}

	// Token: 0x0601851D RID: 99613 RVA: 0x00630B38 File Offset: 0x0062ED38
	public bool IsScoreTaskClaimed(int taskId)
	{
		return this.ClaimedScoreTaskIds.Contains(taskId);
	}

	// Token: 0x0601851E RID: 99614 RVA: 0x00630B48 File Offset: 0x0062ED48
	public bool CheckIsRewardWaitTake()
	{
		if (this.ConfigId == 0)
		{
			return false;
		}
		WeeklyChallengeConfig instance = WeeklyChallengeConfig.Instance;
		IReadOnlyList<WeeklyFrameAward> readOnlyList = (instance != null) ? instance.GetAllScoreRewardTasks() : null;
		if (readOnlyList == null)
		{
			return false;
		}
		foreach (WeeklyFrameAward weeklyFrameAward in readOnlyList)
		{
			if (this.CurrentScore >= weeklyFrameAward.Score && !this.IsScoreTaskClaimed(weeklyFrameAward.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601851F RID: 99615 RVA: 0x00630BD0 File Offset: 0x0062EDD0
	public bool CheckIsFinish()
	{
		return this.ConfigId == 0 || this.ScoreMax <= 0 || this.CurrentScore >= this.ScoreMax;
	}

	// Token: 0x06018520 RID: 99616 RVA: 0x00630BF8 File Offset: 0x0062EDF8
	public int GetLastNotTaken()
	{
		int result = 0;
		List<int> list = new List<int>(this.ScoreGoalMap.Keys);
		for (int i = list.Count - 1; i >= 0; i--)
		{
			DailyActivityDefine.IActivityGoalData activityGoalData;
			if (this.ScoreGoalMap.TryGetValue(list[i], out activityGoalData) && activityGoalData.State == EDailyActiveState.FinishedAndNotTaken)
			{
				result = i + 1;
				break;
			}
		}
		return result;
	}

	// Token: 0x06018521 RID: 99617 RVA: 0x00630C51 File Offset: 0x0062EE51
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		if (configId == this.GetScoreId())
		{
			this.RefreshCurrentScore();
		}
	}

	// Token: 0x06018522 RID: 99618 RVA: 0x00630C64 File Offset: 0x0062EE64
	public void ReportEndTimeRefreshLogEvent()
	{
		int? weeklyChallengeRefreshTime = DailyActivityModel.Instance.GetWeeklyChallengeRefreshTime();
		int num = (int)this.WeeklyEndTime;
		int num2 = num;
		int? num3 = weeklyChallengeRefreshTime;
		if (!(num2 == num3.GetValueOrDefault() & num3 != null))
		{
			WeeklyChallengeEndTimeRefreshLogEvent weeklyChallengeEndTimeRefreshLogEvent = new WeeklyChallengeEndTimeRefreshLogEvent();
			weeklyChallengeEndTimeRefreshLogEvent.i_season_id = this.WeeklyConfigId;
			LogReportController.Instance.LogReport(weeklyChallengeEndTimeRefreshLogEvent);
			DailyActivityModel.Instance.SetWeeklyChallengeRefreshTime(num);
		}
	}

	// Token: 0x170020D2 RID: 8402
	// (get) Token: 0x06018523 RID: 99619 RVA: 0x00630CC2 File Offset: 0x0062EEC2
	public static WeeklyChallengeModel Instance
	{
		get
		{
			return WeeklyChallengeModel._Instance;
		}
	}

	// Token: 0x06018524 RID: 99620 RVA: 0x00630CC9 File Offset: 0x0062EEC9
	public static WeeklyChallengeModel GetOrCreateInstance()
	{
		if (WeeklyChallengeModel._Instance == null)
		{
			WeeklyChallengeModel.CreateInstance();
		}
		return WeeklyChallengeModel._Instance;
	}

	// Token: 0x06018525 RID: 99621 RVA: 0x00630CDD File Offset: 0x0062EEDD
	public static bool CreateInstance()
	{
		if (WeeklyChallengeModel._Instance != null)
		{
			return true;
		}
		WeeklyChallengeModel._Instance = new WeeklyChallengeModel();
		return true;
	}

	// Token: 0x06018526 RID: 99622 RVA: 0x00630CF3 File Offset: 0x0062EEF3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018527 RID: 99623 RVA: 0x00630CF5 File Offset: 0x0062EEF5
	public static void ResetStaticDefaultValue()
	{
		WeeklyChallengeModel._Instance = null;
	}

	// Token: 0x06018528 RID: 99624 RVA: 0x00630CFD File Offset: 0x0062EEFD
	static WeeklyChallengeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyChallengeModel.CreateStaticDefaultValue), new Action(WeeklyChallengeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B48E RID: 46222
	private int ConfigId;

	// Token: 0x0400B48F RID: 46223
	private long BeginTime;

	// Token: 0x0400B490 RID: 46224
	private long EndTime;

	// Token: 0x0400B491 RID: 46225
	private List<int> ClaimedScoreTaskIds = new List<int>();

	// Token: 0x0400B492 RID: 46226
	private int WorldLevel;

	// Token: 0x0400B493 RID: 46227
	private int LastInitWorldLevel = -1;

	// Token: 0x0400B494 RID: 46228
	private int CurrentScore;

	// Token: 0x0400B495 RID: 46229
	private int ScoreMax;

	// Token: 0x0400B496 RID: 46230
	private readonly Dictionary<int, DailyActivityDefine.IActivityGoalData> ScoreGoalMap = new Dictionary<int, DailyActivityDefine.IActivityGoalData>();

	// Token: 0x0400B497 RID: 46231
	private readonly Dictionary<int, global::WeeklyPlayData> WeeklyPlayDataMap = new Dictionary<int, global::WeeklyPlayData>();

	// Token: 0x0400B498 RID: 46232
	[Nullable(2)]
	private static WeeklyChallengeModel _Instance;
}
