using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

// Token: 0x02002289 RID: 8841
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeeklyChallengeModel : ModelBase
{
	// Token: 0x17002124 RID: 8484
	// (get) Token: 0x06015DA7 RID: 89511 RVA: 0x0065651D File Offset: 0x0065471D
	public int WeeklyConfigId
	{
		get
		{
			return this.ConfigId;
		}
	}

	// Token: 0x17002125 RID: 8485
	// (get) Token: 0x06015DA8 RID: 89512 RVA: 0x00656525 File Offset: 0x00654725
	public List<int> WeeklyPlayIds
	{
		get
		{
			return new List<int>(this.WeeklyPlayDataMap.Keys);
		}
	}

	// Token: 0x17002126 RID: 8486
	// (get) Token: 0x06015DA9 RID: 89513 RVA: 0x00656537 File Offset: 0x00654737
	public long WeeklyBeginTime
	{
		get
		{
			return this.BeginTime;
		}
	}

	// Token: 0x17002127 RID: 8487
	// (get) Token: 0x06015DAA RID: 89514 RVA: 0x0065653F File Offset: 0x0065473F
	public long WeeklyEndTime
	{
		get
		{
			return this.EndTime;
		}
	}

	// Token: 0x17002128 RID: 8488
	// (get) Token: 0x06015DAB RID: 89515 RVA: 0x00656547 File Offset: 0x00654747
	public int WeeklyCurrentScore
	{
		get
		{
			return this.CurrentScore;
		}
	}

	// Token: 0x17002129 RID: 8489
	// (get) Token: 0x06015DAC RID: 89516 RVA: 0x0065654F File Offset: 0x0065474F
	public List<int> WeeklyClaimedScoreTaskIds
	{
		get
		{
			return this.ClaimedScoreTaskIds;
		}
	}

	// Token: 0x1700212A RID: 8490
	// (get) Token: 0x06015DAD RID: 89517 RVA: 0x00656557 File Offset: 0x00654757
	public int WeeklyWorldLevel
	{
		get
		{
			return this.WorldLevel;
		}
	}

	// Token: 0x1700212B RID: 8491
	// (get) Token: 0x06015DAE RID: 89518 RVA: 0x0065655F File Offset: 0x0065475F
	public int WeeklyMaxScore
	{
		get
		{
			return this.ScoreMax;
		}
	}

	// Token: 0x1700212C RID: 8492
	// (get) Token: 0x06015DAF RID: 89519 RVA: 0x00656567 File Offset: 0x00654767
	public IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> WeeklyGoalMap
	{
		get
		{
			return this.ScoreGoalMap;
		}
	}

	// Token: 0x06015DB0 RID: 89520 RVA: 0x0065656F File Offset: 0x0065476F
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		return true;
	}

	// Token: 0x06015DB1 RID: 89521 RVA: 0x0065658E File Offset: 0x0065478E
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		return true;
	}

	// Token: 0x06015DB2 RID: 89522 RVA: 0x006565B0 File Offset: 0x006547B0
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

	// Token: 0x06015DB3 RID: 89523 RVA: 0x00656634 File Offset: 0x00654834
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

	// Token: 0x06015DB4 RID: 89524 RVA: 0x0065679C File Offset: 0x0065499C
	private void RefreshGoalMapClaimedState()
	{
		foreach (DailyActivityDefine.IActivityGoalData activityGoalData in this.ScoreGoalMap.Values)
		{
			bool flag = this.ClaimedScoreTaskIds.Contains(activityGoalData.Id);
			activityGoalData.Achieved = flag;
			activityGoalData.State = this.GetGoalState(activityGoalData.Goal, flag);
		}
	}

	// Token: 0x06015DB5 RID: 89525 RVA: 0x0065681C File Offset: 0x00654A1C
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

	// Token: 0x06015DB6 RID: 89526 RVA: 0x00656830 File Offset: 0x00654A30
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

	// Token: 0x06015DB7 RID: 89527 RVA: 0x006568A0 File Offset: 0x00654AA0
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

	// Token: 0x06015DB8 RID: 89528 RVA: 0x00656928 File Offset: 0x00654B28
	[NullableContext(2)]
	public global::WeeklyPlayData GetWeeklyPlayData(int playId)
	{
		return this.WeeklyPlayDataMap.GetValueOrDefault(playId);
	}

	// Token: 0x06015DB9 RID: 89529 RVA: 0x00656938 File Offset: 0x00654B38
	private bool CheckIsSaved(Aki.Protocol.WeeklyPlayData data)
	{
		ActivityType type = data.Type;
		if (type != ActivityType.RogueWeekly)
		{
			return type == ActivityType.FloroRanchActivity && data.FloroFarmPlayData != null && data.FloroFarmPlayData.HasRecord;
		}
		return data.RogueWeeklyPlayData != null && data.RogueWeeklyPlayData.HasRecord;
	}

	// Token: 0x06015DBA RID: 89530 RVA: 0x00656988 File Offset: 0x00654B88
	public List<TItem> GetRewardById(int id)
	{
		DailyActivityDefine.IActivityGoalData activityGoalData;
		if (!this.ScoreGoalMap.TryGetValue(id, out activityGoalData))
		{
			return new List<TItem>();
		}
		return activityGoalData.Rewards;
	}

	// Token: 0x06015DBB RID: 89531 RVA: 0x006569B4 File Offset: 0x00654BB4
	private int GetScoreId()
	{
		return ConfigCommonParamById.GetIntConfig("WeeklyChallengeScoreId").GetValueOrDefault();
	}

	// Token: 0x06015DBC RID: 89532 RVA: 0x006569D4 File Offset: 0x00654BD4
	public string GetWeeklyScoreStr()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentScore);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ScoreMax);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06015DBD RID: 89533 RVA: 0x00656A18 File Offset: 0x00654C18
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

	// Token: 0x06015DBE RID: 89534 RVA: 0x00656ABC File Offset: 0x00654CBC
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

	// Token: 0x06015DBF RID: 89535 RVA: 0x00656B4C File Offset: 0x00654D4C
	public bool IsScoreTaskClaimed(int taskId)
	{
		return this.ClaimedScoreTaskIds.Contains(taskId);
	}

	// Token: 0x06015DC0 RID: 89536 RVA: 0x00656B5C File Offset: 0x00654D5C
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

	// Token: 0x06015DC1 RID: 89537 RVA: 0x00656BE4 File Offset: 0x00654DE4
	public bool CheckIsFinish()
	{
		return this.ConfigId == 0 || this.ScoreMax <= 0 || this.CurrentScore >= this.ScoreMax;
	}

	// Token: 0x06015DC2 RID: 89538 RVA: 0x00656C0C File Offset: 0x00654E0C
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

	// Token: 0x06015DC3 RID: 89539 RVA: 0x00656C65 File Offset: 0x00654E65
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		if (configId == this.GetScoreId())
		{
			this.RefreshCurrentScore();
		}
	}

	// Token: 0x06015DC4 RID: 89540 RVA: 0x00656C78 File Offset: 0x00654E78
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

	// Token: 0x1700212D RID: 8493
	// (get) Token: 0x06015DC5 RID: 89541 RVA: 0x00656CD6 File Offset: 0x00654ED6
	public static WeeklyChallengeModel Instance
	{
		get
		{
			return WeeklyChallengeModel._Instance;
		}
	}

	// Token: 0x06015DC6 RID: 89542 RVA: 0x00656CDD File Offset: 0x00654EDD
	public static WeeklyChallengeModel GetOrCreateInstance()
	{
		if (WeeklyChallengeModel._Instance == null)
		{
			WeeklyChallengeModel.CreateInstance();
		}
		return WeeklyChallengeModel._Instance;
	}

	// Token: 0x06015DC7 RID: 89543 RVA: 0x00656CF1 File Offset: 0x00654EF1
	public static bool CreateInstance()
	{
		if (WeeklyChallengeModel._Instance != null)
		{
			return true;
		}
		WeeklyChallengeModel._Instance = new WeeklyChallengeModel();
		return true;
	}

	// Token: 0x06015DC8 RID: 89544 RVA: 0x00656D07 File Offset: 0x00654F07
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015DC9 RID: 89545 RVA: 0x00656D09 File Offset: 0x00654F09
	public static void ResetStaticDefaultValue()
	{
		WeeklyChallengeModel._Instance = null;
	}

	// Token: 0x06015DCA RID: 89546 RVA: 0x00656D11 File Offset: 0x00654F11
	static WeeklyChallengeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyChallengeModel.CreateStaticDefaultValue), new Action(WeeklyChallengeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B803 RID: 47107
	private int ConfigId;

	// Token: 0x0400B804 RID: 47108
	private long BeginTime;

	// Token: 0x0400B805 RID: 47109
	private long EndTime;

	// Token: 0x0400B806 RID: 47110
	private List<int> ClaimedScoreTaskIds = new List<int>();

	// Token: 0x0400B807 RID: 47111
	private int WorldLevel;

	// Token: 0x0400B808 RID: 47112
	private int LastInitWorldLevel = -1;

	// Token: 0x0400B809 RID: 47113
	private int CurrentScore;

	// Token: 0x0400B80A RID: 47114
	private int ScoreMax;

	// Token: 0x0400B80B RID: 47115
	private readonly Dictionary<int, DailyActivityDefine.IActivityGoalData> ScoreGoalMap = new Dictionary<int, DailyActivityDefine.IActivityGoalData>();

	// Token: 0x0400B80C RID: 47116
	private readonly Dictionary<int, global::WeeklyPlayData> WeeklyPlayDataMap = new Dictionary<int, global::WeeklyPlayData>();

	// Token: 0x0400B80D RID: 47117
	[Nullable(2)]
	private static WeeklyChallengeModel _Instance;
}
