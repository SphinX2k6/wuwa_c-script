using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

// Token: 0x02000903 RID: 2307
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressData : ActivityBaseData
{
	// Token: 0x17000CF5 RID: 3317
	// (get) Token: 0x060066B3 RID: 26291 RVA: 0x00202966 File Offset: 0x00200B66
	public int PrevBpExp
	{
		get
		{
			return this.PrevBpExpInternal;
		}
	}

	// Token: 0x060066B4 RID: 26292 RVA: 0x00202970 File Offset: 0x00200B70
	protected override void PhraseEx(ActivityData data)
	{
		this.RegressRawData = data.RegressData;
		if (this.RegressRawData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "回流活动-ActivityRegressData.PhraseEx()->";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("协议下发的活动数据没有回流活动相关的, data:", this.RegressRawData);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.RegressRawData.SignRewards == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ActivityRegress;
			ELogAuthor author2 = ELogAuthor.LRX;
			string message2 = "回流活动-ActivityRegressData.PhraseEx()->";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("协议下发的回流活动数据没有签到数据, data:", this.RegressRawData.SignRewards);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		if (this.RegressRawData.ActivityTasks == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.ActivityRegress;
			ELogAuthor author3 = ELogAuthor.LRX;
			string message3 = "回流活动-ActivityRegressData.PhraseEx()->";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("协议下发的回流活动数据没有任务数据, data:", this.RegressRawData.ActivityTasks);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		}
		if (this.RegressRawData.ScoreRewards == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.ActivityRegress;
			ELogAuthor author4 = ELogAuthor.LRX;
			string message4 = "回流活动-ActivityRegressData.PhraseEx()->";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("协议下发的回流活动数据没有已经领取的积分奖励, data:", this.RegressRawData.ScoreRewards);
			instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		}
		this.DisposableReward = this.RegressRawData.DisposableReward;
		this.CurrentUseTrialRole = this.RegressRawData.CurUseTrialRoleId;
		this.ParseTrialRoles(this.RegressRawData.RoleInfo);
		TrialRoleModel.Instance.SetCurUseTrialRole(this.CurrentUseTrialRole, this.RegressRawData.CurUseRoleInfo);
		this.EndOpenTimeInternal = this.RegressRawData.EndTime;
		this.EndShowTimeInternal = this.EndOpenTimeInternal;
		if (this.EndOpenTimeInternal == 0L)
		{
			base.ForceClose();
		}
		this.ActivityRecallDailyTaskRefreshTime = this.RegressRawData.NextRefreshTime;
		this.ActivityInternalTaskMap.Clear();
		foreach (ActivityTask activityTask in this.RegressRawData.ActivityTasks)
		{
			this.ActivityInternalTaskMap[activityTask.Id] = activityTask;
		}
		this.RefreshScoreRewardNeedScoreList();
		this.RefreshRegressTaskMapping();
		this.RefreshPrevBpExp();
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityRegressModel.Instance.ActivityId);
	}

	// Token: 0x060066B5 RID: 26293 RVA: 0x00202BB0 File Offset: 0x00200DB0
	private void ParseTrialRoles(RepeatedField<NewTrialRoleInfo> roleList)
	{
		List<ITrialRoleCreateData> list = new List<ITrialRoleCreateData>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (NewTrialRoleInfo newTrialRoleInfo in roleList)
		{
			list.Add(new TrialRoleCreateData
			{
				TrialRoleId = newTrialRoleInfo.TrialRoleId,
				IsUnlocked = true
			});
			TrialRoleConfig instance = TrialRoleConfig.Instance;
			int? num = (instance != null) ? instance.GetTrialRoleGroupId(newTrialRoleInfo.TrialRoleId) : null;
			if (num != null)
			{
				hashSet.Add(num.Value);
			}
		}
		TrialRoleConfig instance2 = TrialRoleConfig.Instance;
		Dictionary<int, List<TrialRoleInfo>> dictionary = (instance2 != null) ? instance2.GetTrialRoleAllConfigByType(ETrialRoleType.ReturnSupportTrial) : null;
		if (dictionary != null)
		{
			foreach (KeyValuePair<int, List<TrialRoleInfo>> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				List<TrialRoleInfo> value = keyValuePair.Value;
				if (!hashSet.Contains(key) && value.Count > 0)
				{
					list.Add(new TrialRoleCreateData
					{
						TrialRoleId = value[0].Id,
						IsUnlocked = false
					});
				}
			}
		}
		TrialRoleModel.Instance.AddTrialRoles(list);
	}

	// Token: 0x060066B6 RID: 26294 RVA: 0x00202D00 File Offset: 0x00200F00
	public EActivityRecallState GetActivityState()
	{
		if (!base.IsUnLock())
		{
			return EActivityRecallState.UnOpen;
		}
		if (this.RegressRawData == null || this.RegressRawData.EndTime == 0L)
		{
			return EActivityRecallState.UnOpen;
		}
		if (this.CheckIfInOpenTime())
		{
			return EActivityRecallState.Opening;
		}
		return EActivityRecallState.UnOpen;
	}

	// Token: 0x17000CF6 RID: 3318
	// (get) Token: 0x060066B7 RID: 26295 RVA: 0x00202D2E File Offset: 0x00200F2E
	// (set) Token: 0x060066B8 RID: 26296 RVA: 0x00202D45 File Offset: 0x00200F45
	public ERegressGrade Grade
	{
		get
		{
			if (this.RegressRawData != null)
			{
				return (ERegressGrade)this.RegressRawData.GradeId;
			}
			return ERegressGrade.None;
		}
		set
		{
			if (this.RegressRawData != null)
			{
				this.RegressRawData.GradeId = (int)value;
			}
		}
	}

	// Token: 0x060066B9 RID: 26297 RVA: 0x00202D5B File Offset: 0x00200F5B
	public override bool CheckIfInOpenTime()
	{
		return base.CheckIfInTimeInterval(base.BeginOpenTime, base.EndOpenTime);
	}

	// Token: 0x060066BA RID: 26298 RVA: 0x00202D70 File Offset: 0x00200F70
	public double GetActivityOpenTimeLeft()
	{
		long endOpenTime = base.EndOpenTime;
		return Math.Max(0.0, (double)endOpenTime - TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x060066BB RID: 26299 RVA: 0x00202D9F File Offset: 0x00200F9F
	public bool IsActivityOpen()
	{
		return this.GetActivityState() == EActivityRecallState.Opening;
	}

	// Token: 0x060066BC RID: 26300 RVA: 0x00202DAC File Offset: 0x00200FAC
	public ERegressRewardState GetSignRewardState(int day)
	{
		ActivityTask signRewardRawData = this.GetSignRewardRawData(day);
		if (signRewardRawData == null)
		{
			return ERegressRewardState.UnReach;
		}
		switch (signRewardRawData.Status)
		{
		case ActivityTaskState.ActivityTaskRunning:
			return ERegressRewardState.UnReach;
		case ActivityTaskState.ActivityTaskFinish:
			return ERegressRewardState.Reached;
		case ActivityTaskState.ActivityTaskTaken:
			return ERegressRewardState.Claim;
		default:
			return ERegressRewardState.UnReach;
		}
	}

	// Token: 0x060066BD RID: 26301 RVA: 0x00202DE8 File Offset: 0x00200FE8
	public bool HasSignRewardCanClaimed()
	{
		if (this.RegressRawData == null)
		{
			return false;
		}
		using (IEnumerator<ActivityTask> enumerator = this.RegressRawData.SignRewards.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060066BE RID: 26302 RVA: 0x00202E4C File Offset: 0x0020104C
	[NullableContext(2)]
	private ActivityTask GetSignRewardRawData(int day)
	{
		if (this.RegressRawData == null)
		{
			return null;
		}
		RepeatedField<ActivityTask> signRewards = this.RegressRawData.SignRewards;
		if (day - 1 < 0 || day - 1 >= signRewards.Count)
		{
			return null;
		}
		return signRewards[day - 1];
	}

	// Token: 0x060066BF RID: 26303 RVA: 0x00202E8C File Offset: 0x0020108C
	public bool CheckHaveTaskRewardCanGet()
	{
		if (this.GetRegressTaskProgressFloat01() >= 1.0)
		{
			return false;
		}
		if (this.RegressRawData == null)
		{
			return false;
		}
		using (IEnumerator<ActivityTask> enumerator = this.RegressRawData.ActivityTasks.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060066C0 RID: 26304 RVA: 0x00202F04 File Offset: 0x00201104
	public int GetSignRewardEntityId(int day)
	{
		ActivityTask signRewardRawData = this.GetSignRewardRawData(day);
		if (signRewardRawData == null)
		{
			return 0;
		}
		return signRewardRawData.Id;
	}

	// Token: 0x060066C1 RID: 26305 RVA: 0x00202F24 File Offset: 0x00201124
	[NullableContext(2)]
	private ActivityTask GetRawTaskData(int taskId)
	{
		ActivityTask result;
		if (!this.ActivityInternalTaskMap.TryGetValue(taskId, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "[回流活动]ActivityRegressData.GetRawTaskData->";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("获取回流任务数据失败, 服务器没下发该任务数据 taskId:", taskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x060066C2 RID: 26306 RVA: 0x00202F73 File Offset: 0x00201173
	public bool IsRegressTaskScoreOverExp()
	{
		return this.GetRegressTaskProgressFloat01() >= 1.0;
	}

	// Token: 0x060066C3 RID: 26307 RVA: 0x00202F8C File Offset: 0x0020118C
	[NullableContext(0)]
	public ValueTuple<int, int> GetTaskProgressTuple(int taskId)
	{
		ActivityTask rawTaskData = this.GetRawTaskData(taskId);
		if (rawTaskData == null)
		{
			return new ValueTuple<int, int>(0, 0);
		}
		int item = rawTaskData.Current;
		int target = rawTaskData.Target;
		return new ValueTuple<int, int>(item, target);
	}

	// Token: 0x060066C4 RID: 26308 RVA: 0x00202FC4 File Offset: 0x002011C4
	public ERegressRewardState GetTaskRewardState(int taskId)
	{
		ActivityTask rawTaskData = this.GetRawTaskData(taskId);
		if (rawTaskData == null)
		{
			return ERegressRewardState.UnReach;
		}
		switch (rawTaskData.Status)
		{
		case ActivityTaskState.ActivityTaskRunning:
			return ERegressRewardState.UnReach;
		case ActivityTaskState.ActivityTaskFinish:
			return ERegressRewardState.Reached;
		case ActivityTaskState.ActivityTaskTaken:
			return ERegressRewardState.Claim;
		default:
			return ERegressRewardState.UnReach;
		}
	}

	// Token: 0x060066C5 RID: 26309 RVA: 0x00203000 File Offset: 0x00201200
	public string GetNextRefreshTime()
	{
		long activityRecallDailyTaskRefreshTime = this.ActivityRecallDailyTaskRefreshTime;
		if (activityRecallDailyTaskRefreshTime == 0L)
		{
			return "";
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)activityRecallDailyTaskRefreshTime - serverTime, TimeUtil.Instance.TimeDeviation);
		CommonDefine.ETimeType value = (num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute;
		CommonDefine.ETimeType value2 = (num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second;
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2)).CountDownText ?? "";
	}

	// Token: 0x060066C6 RID: 26310 RVA: 0x00203088 File Offset: 0x00201288
	public override bool GetExDataRedPointShowState()
	{
		return this.IsActivityOpen() && (this.HasSignRewardCanClaimed() || this.CheckRegressScoreRewardReached() || this.CheckShowQuestionnaireRedDot() || this.CheckShopRedDot() || this.CheckTrialRoleRedDot() || this.CheckDisposableRewardRedDot() || this.HasReachableConstantTask() || this.CheckRegressRewardBtnReached());
	}

	// Token: 0x060066C7 RID: 26311 RVA: 0x002030DF File Offset: 0x002012DF
	public int GetBossDoubleDropCount()
	{
		RegressData regressRawData = this.RegressRawData;
		if (regressRawData == null)
		{
			return 0;
		}
		return regressRawData.BossDoubleCount;
	}

	// Token: 0x060066C8 RID: 26312 RVA: 0x002030F2 File Offset: 0x002012F2
	public int GetWeekDoubleDropCount()
	{
		RegressData regressRawData = this.RegressRawData;
		if (regressRawData == null)
		{
			return 0;
		}
		return regressRawData.WeekDoubleCount;
	}

	// Token: 0x060066C9 RID: 26313 RVA: 0x00203108 File Offset: 0x00201308
	public ERegressRewardState GetQuestionnaireRewardState(int id)
	{
		if (this.RegressRawData == null)
		{
			return ERegressRewardState.UnReach;
		}
		RepeatedField<QuestionTask> question = this.RegressRawData.Question;
		QuestionTask questionTask = null;
		foreach (QuestionTask questionTask2 in question)
		{
			if (questionTask2.Id == id)
			{
				questionTask = questionTask2;
				break;
			}
		}
		if (questionTask == null)
		{
			return ERegressRewardState.UnReach;
		}
		switch (questionTask.Status)
		{
		case ActivityTaskState.ActivityTaskRunning:
			return ERegressRewardState.UnReach;
		case ActivityTaskState.ActivityTaskFinish:
			return ERegressRewardState.Reached;
		case ActivityTaskState.ActivityTaskTaken:
			return ERegressRewardState.Claim;
		default:
			return ERegressRewardState.UnReach;
		}
	}

	// Token: 0x060066CA RID: 26314 RVA: 0x00203194 File Offset: 0x00201394
	public bool CheckShowQuestionnaireRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		foreach (ERegressQuestionnaireType type in this.CheckQuestionnaireTypes)
		{
			RegressInvestigation? regressQuestionnaireConfig = ActivityRegressConfig.Instance.GetRegressQuestionnaireConfig(type);
			if (regressQuestionnaireConfig != null && this.IsQuestionnaireUnlock(type) && this.GetQuestionnaireRewardState(regressQuestionnaireConfig.Value.Id) == ERegressRewardState.Reached)
			{
				return true;
			}
		}
		return this.CheckQuestionnaireFirstRedDot() || this.CheckSecondQuestionnaireFirstRedDot();
	}

	// Token: 0x060066CB RID: 26315 RVA: 0x00203238 File Offset: 0x00201438
	public bool CheckQuestionnaireFirstRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressQuestionnaireRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressQuestionnaireRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressQuestionnaireRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060066CC RID: 26316 RVA: 0x0020327C File Offset: 0x0020147C
	public bool CheckSecondQuestionnaireFirstRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		bool flag = this.IsQuestionnaireUnlock(ERegressQuestionnaireType.Type2);
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault() && flag;
	}

	// Token: 0x060066CD RID: 26317 RVA: 0x002032C9 File Offset: 0x002014C9
	public bool CheckDisposableRewardRedDot()
	{
		return !this.DisposableReward;
	}

	// Token: 0x060066CE RID: 26318 RVA: 0x002032D4 File Offset: 0x002014D4
	public void ResetQuestionnaireRedDot()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressQuestionnaireRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(false));
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(false));
	}

	// Token: 0x060066CF RID: 26319 RVA: 0x00203310 File Offset: 0x00201510
	public void SetQuestionnaireRedDotChecked()
	{
		if (this.CheckQuestionnaireFirstRedDot())
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressQuestionnaireRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
		}
		if (this.CheckSecondQuestionnaireFirstRedDot())
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
		}
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060066D0 RID: 26320 RVA: 0x0020338C File Offset: 0x0020158C
	public bool CheckShopRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressShopRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressShopRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressShopRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060066D1 RID: 26321 RVA: 0x002033CF File Offset: 0x002015CF
	public bool CheckTrialRoleRedDot()
	{
		return this.IsActivityOpen() && (this.CheckNewUnLockRole() || this.IsTrialRoleUpgradeRedPoint());
	}

	// Token: 0x060066D2 RID: 26322 RVA: 0x002033EC File Offset: 0x002015EC
	public bool CheckNewUnLockRole()
	{
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressTrialRoleRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressTrialRoleRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressTrialRoleRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060066D3 RID: 26323 RVA: 0x00203428 File Offset: 0x00201628
	public bool IsTrialRoleUpgradeRedPoint()
	{
		using (List<TrialRoleGroupData>.Enumerator enumerator = this.GetTrialRoleList().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CanUpgrade())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060066D4 RID: 26324 RVA: 0x00203484 File Offset: 0x00201684
	public List<TrialRoleGroupData> GetTrialRoleList()
	{
		return TrialRoleModel.Instance.GetDataListByType(ETrialRoleType.ReturnSupportTrial);
	}

	// Token: 0x060066D5 RID: 26325 RVA: 0x00203494 File Offset: 0x00201694
	public bool CheckDoubleDropRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressDoubleDropRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressDoubleDropRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressDoubleDropRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060066D6 RID: 26326 RVA: 0x002034D8 File Offset: 0x002016D8
	public bool CheckRecommendRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressRecommendRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressRecommendRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressRecommendRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060066D7 RID: 26327 RVA: 0x0020351C File Offset: 0x0020171C
	public bool CheckAdventureRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressAdventureRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressAdventureRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressAdventureRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060066D8 RID: 26328 RVA: 0x0020355F File Offset: 0x0020175F
	public void ResetShopRemindRedDot()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressShopRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(false));
	}

	// Token: 0x060066D9 RID: 26329 RVA: 0x00203580 File Offset: 0x00201780
	public void SetShopRedDotChecked()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressShopRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060066DA RID: 26330 RVA: 0x002035D0 File Offset: 0x002017D0
	public void SetTrialRoleRedDotChecked(bool value)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressTrialRoleRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(value));
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060066DB RID: 26331 RVA: 0x0020361F File Offset: 0x0020181F
	public void SetDoubleDropRedDotChecked()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressDoubleDropRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x060066DC RID: 26332 RVA: 0x0020364D File Offset: 0x0020184D
	public void SetRecommendRedDotChecked()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressRecommendRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x060066DD RID: 26333 RVA: 0x0020367B File Offset: 0x0020187B
	public void SetAdventureRedDotChecked()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressAdventureRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x060066DE RID: 26334 RVA: 0x002036AC File Offset: 0x002018AC
	[NullableContext(0)]
	public ValueTuple<int, int> GetShopIdAndTabIndex()
	{
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(859201);
		string text = (accessPathConfig != null) ? accessPathConfig.GetValueOrDefault().Val1 : null;
		string text2 = (accessPathConfig != null) ? accessPathConfig.GetValueOrDefault().Val2 : null;
		int item = (!string.IsNullOrEmpty(text)) ? int.Parse(text) : 0;
		int item2 = (!string.IsNullOrEmpty(text2)) ? int.Parse(text2) : 0;
		return new ValueTuple<int, int>(item, item2);
	}

	// Token: 0x060066DF RID: 26335 RVA: 0x0020372C File Offset: 0x0020192C
	public bool IsQuestionnaireUnlock(ERegressQuestionnaireType type)
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		if (type == ERegressQuestionnaireType.Type1)
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("RegressSecondAskSignDay");
		return intConfig != null && this.GetSignRewardState(intConfig.Value) == ERegressRewardState.Claim;
	}

	// Token: 0x060066E0 RID: 26336 RVA: 0x00203770 File Offset: 0x00201970
	public void SetQuestionnaireReached(int id)
	{
		if (this.RegressRawData == null)
		{
			return;
		}
		RepeatedField<QuestionTask> question = this.RegressRawData.Question;
		QuestionTask questionTask = null;
		foreach (QuestionTask questionTask2 in question)
		{
			if (questionTask2.Id == id)
			{
				questionTask = questionTask2;
				break;
			}
		}
		if (questionTask != null && questionTask.Status == ActivityTaskState.ActivityTaskRunning)
		{
			questionTask.Status = ActivityTaskState.ActivityTaskFinish;
		}
	}

	// Token: 0x060066E1 RID: 26337 RVA: 0x002037E8 File Offset: 0x002019E8
	public void RefreshRegressTaskMapping()
	{
		this.RegressTaskMapping.Clear();
		if (this.RegressRawData == null)
		{
			return;
		}
		foreach (ActivityTask activityTask in this.RegressRawData.ActivityTasks)
		{
			int id = activityTask.Id;
			RegressQuest? regressQuestConfig = ActivityRegressConfig.Instance.GetRegressQuestConfig(id);
			if (regressQuestConfig != null)
			{
				List<RegressQuest> list;
				if (!this.RegressTaskMapping.TryGetValue((ERegressTaskType)regressQuestConfig.Value.TaskType, out list))
				{
					list = new List<RegressQuest>();
					this.RegressTaskMapping[(ERegressTaskType)regressQuestConfig.Value.TaskType] = list;
				}
				list.Add(regressQuestConfig.Value);
			}
		}
	}

	// Token: 0x060066E2 RID: 26338 RVA: 0x002038B0 File Offset: 0x00201AB0
	[NullableContext(2)]
	public List<RegressQuest> GetRegressTaskListByType(ERegressTaskType taskType)
	{
		List<RegressQuest> result;
		if (this.RegressTaskMapping.TryGetValue(taskType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060066E3 RID: 26339 RVA: 0x002038D0 File Offset: 0x00201AD0
	public List<RegressQuest> GetAllRegressTaskList()
	{
		List<RegressQuest> list = new List<RegressQuest>();
		foreach (KeyValuePair<ERegressTaskType, List<RegressQuest>> keyValuePair in this.RegressTaskMapping)
		{
			list.AddRange(keyValuePair.Value);
		}
		return list;
	}

	// Token: 0x060066E4 RID: 26340 RVA: 0x00203930 File Offset: 0x00201B30
	public bool HasReachableTask(ERegressTaskType regressTaskType)
	{
		List<RegressQuest> regressTaskListByType = this.GetRegressTaskListByType(regressTaskType);
		if (regressTaskListByType == null)
		{
			return false;
		}
		foreach (RegressQuest regressQuest in regressTaskListByType)
		{
			if (this.GetTaskRewardState(regressQuest.Id) == ERegressRewardState.Reached)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060066E5 RID: 26341 RVA: 0x0020399C File Offset: 0x00201B9C
	public bool HasReachableConstantTask()
	{
		return this.GetRegressTaskProgressFloat01() < 1.0 && (this.HasReachableTask(ERegressTaskType.Constant) || this.HasReachableTask(ERegressTaskType.Daily) || this.HasReachableTask(ERegressTaskType.Once));
	}

	// Token: 0x060066E6 RID: 26342 RVA: 0x002039CC File Offset: 0x00201BCC
	public bool HasReachableCultivateTask()
	{
		return this.HasReachableTask(ERegressTaskType.Cultivate);
	}

	// Token: 0x060066E7 RID: 26343 RVA: 0x002039D8 File Offset: 0x00201BD8
	public double GetRegressTaskProgressFloat01()
	{
		ValueTuple<int, int> regressTaskProgressTuple = this.GetRegressTaskProgressTuple();
		int item = regressTaskProgressTuple.Item1;
		int item2 = regressTaskProgressTuple.Item2;
		if (item2 == 0)
		{
			return 0.0;
		}
		return Math.Truncate(Math.Min(1.0, (double)item / (double)item2) * 100.0) / 100.0;
	}

	// Token: 0x060066E8 RID: 26344 RVA: 0x00203A31 File Offset: 0x00201C31
	public int GetRegressTaskScore()
	{
		return this.GetRegressTaskProgressTuple().Item1;
	}

	// Token: 0x060066E9 RID: 26345 RVA: 0x00203A40 File Offset: 0x00201C40
	private bool IsGetScoreReward(int id)
	{
		if (this.RegressRawData == null)
		{
			return false;
		}
		using (IEnumerator<int> enumerator = this.RegressRawData.ScoreRewards.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == id)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060066EA RID: 26346 RVA: 0x00203AA0 File Offset: 0x00201CA0
	private bool IsGetPayScoreReward(int id)
	{
		if (this.RegressRawData == null)
		{
			return false;
		}
		using (IEnumerator<int> enumerator = this.RegressRawData.PayScoreRewards.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == id)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060066EB RID: 26347 RVA: 0x00203B00 File Offset: 0x00201D00
	public ERegressRewardState GetRegressTaskScoreRewardState(RegressBonusReward config)
	{
		if (this.IsGetScoreReward(config.Id))
		{
			return ERegressRewardState.Claim;
		}
		if (this.GetRegressTaskScore() >= config.NeedScore)
		{
			return ERegressRewardState.Reached;
		}
		return ERegressRewardState.UnReach;
	}

	// Token: 0x060066EC RID: 26348 RVA: 0x00203B25 File Offset: 0x00201D25
	public ERegressRewardState GetRegressTaskPayScoreRewardState(RegressBonusReward config)
	{
		if (this.IsGetPayScoreReward(config.Id))
		{
			return ERegressRewardState.Claim;
		}
		if (this.RegressRawData == null || !this.RegressRawData.PayRewardUnlock)
		{
			return ERegressRewardState.UnReach;
		}
		if (this.GetRegressTaskScore() >= config.NeedScore)
		{
			return ERegressRewardState.Reached;
		}
		return ERegressRewardState.UnReach;
	}

	// Token: 0x060066ED RID: 26349 RVA: 0x00203B64 File Offset: 0x00201D64
	public bool CheckRegressScoreRewardReached()
	{
		foreach (RegressBonusReward config in (ActivityRegressConfig.Instance.GetRegressBonusRewardConfigList(this.Grade) ?? new List<RegressBonusReward>()))
		{
			int regressTaskScoreRewardState = (int)this.GetRegressTaskScoreRewardState(config);
			ERegressRewardState regressTaskPayScoreRewardState = this.GetRegressTaskPayScoreRewardState(config);
			if (regressTaskScoreRewardState == 1 || regressTaskPayScoreRewardState == ERegressRewardState.Reached)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060066EE RID: 26350 RVA: 0x00203BDC File Offset: 0x00201DDC
	public void SetRegressScoreRewardReached(List<int> ids)
	{
		if (this.RegressRawData == null)
		{
			return;
		}
		foreach (int item in ids)
		{
			this.RegressRawData.ScoreRewards.Add(item);
		}
		if (this.RegressRawData.PayRewardUnlock)
		{
			foreach (int item2 in ids)
			{
				this.RegressRawData.PayScoreRewards.Add(item2);
			}
		}
	}

	// Token: 0x060066EF RID: 26351 RVA: 0x00203C94 File Offset: 0x00201E94
	public bool CheckRegressRewardBtnReached()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
	}

	// Token: 0x060066F0 RID: 26352 RVA: 0x00203CAE File Offset: 0x00201EAE
	public void SetRegressRewardBtnReached()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060066F1 RID: 26353 RVA: 0x00203CEC File Offset: 0x00201EEC
	[NullableContext(0)]
	public ValueTuple<int, int> GetRegressTaskProgressTuple()
	{
		int commonItemCount = InventoryModel.Instance.GetCommonItemCount(20, 0);
		IEnumerable<RegressBonusReward> enumerable = ActivityRegressConfig.Instance.GetRegressBonusRewardConfigList(this.Grade) ?? new List<RegressBonusReward>();
		int num = 0;
		foreach (RegressBonusReward regressBonusReward in enumerable)
		{
			num = Math.Max(regressBonusReward.NeedScore, num);
		}
		return new ValueTuple<int, int>(commonItemCount, num);
	}

	// Token: 0x060066F2 RID: 26354 RVA: 0x00203D6C File Offset: 0x00201F6C
	private void RefreshScoreRewardNeedScoreList()
	{
		this.ActivityScoreRewardTotalNeedScoreMap.Clear();
		foreach (RegressBonusReward regressBonusReward in (ActivityRegressConfig.Instance.GetRegressBonusRewardConfigList(this.Grade) ?? new List<RegressBonusReward>()))
		{
			this.ActivityScoreRewardTotalNeedScoreMap[regressBonusReward.Id] = regressBonusReward.NeedScore;
		}
	}

	// Token: 0x060066F3 RID: 26355 RVA: 0x00203DEC File Offset: 0x00201FEC
	public int GetTaskSortPriority(int taskId)
	{
		ActivityTask rawTaskData = this.GetRawTaskData(taskId);
		if (rawTaskData == null)
		{
			return 1;
		}
		switch (rawTaskData.Status)
		{
		case ActivityTaskState.ActivityTaskRunning:
			return 1;
		case ActivityTaskState.ActivityTaskFinish:
			return 0;
		case ActivityTaskState.ActivityTaskTaken:
			return 2;
		default:
			return 1;
		}
	}

	// Token: 0x060066F4 RID: 26356 RVA: 0x00203E28 File Offset: 0x00202028
	[NullableContext(0)]
	public ValueTuple<int, int> GetRegressTaskRelativeScore(RegressBonusReward config)
	{
		int regressTaskScore = this.GetRegressTaskScore();
		int key = config.Id - 1;
		int num = 0;
		int num2;
		if (this.ActivityScoreRewardTotalNeedScoreMap.TryGetValue(key, out num2))
		{
			num = num2;
		}
		int num3;
		if (!this.ActivityScoreRewardTotalNeedScoreMap.TryGetValue(config.Id, out num3))
		{
			num3 = 0;
		}
		int num4 = num3 - num;
		int item = 0;
		if (regressTaskScore > num)
		{
			if (regressTaskScore < num3)
			{
				item = regressTaskScore - num;
			}
			else
			{
				item = num4;
			}
		}
		return new ValueTuple<int, int>(item, num4);
	}

	// Token: 0x060066F5 RID: 26357 RVA: 0x00203E99 File Offset: 0x00202099
	public bool IsDoubleDropUnlock(EActivityRegressDoubleDropEntryType type)
	{
		if (type == EActivityRegressDoubleDropEntryType.WorldBoss)
		{
			RegressData regressRawData = this.RegressRawData;
			return regressRawData != null && regressRawData.BossDoubleUnLock;
		}
		if (type == EActivityRegressDoubleDropEntryType.WeeklyDungeon)
		{
			RegressData regressRawData2 = this.RegressRawData;
			return regressRawData2 != null && regressRawData2.WeekDoubleUnLock;
		}
		return false;
	}

	// Token: 0x060066F6 RID: 26358 RVA: 0x00203EC8 File Offset: 0x002020C8
	public void ResetDoubleDropFirstRedDot()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(false));
	}

	// Token: 0x060066F7 RID: 26359 RVA: 0x00203EE8 File Offset: 0x002020E8
	public void MarkDoubleDropFirstRedDotShown()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060066F8 RID: 26360 RVA: 0x00203F38 File Offset: 0x00202138
	public bool CheckDoubleDropFirstRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060066F9 RID: 26361 RVA: 0x00203F7C File Offset: 0x0020217C
	public int GetLevelByScore(int score)
	{
		IReadOnlyList<RegressBonusReward> sortedRegressBonusRewardConfigList = this.GetSortedRegressBonusRewardConfigList();
		int num = 0;
		int count = sortedRegressBonusRewardConfigList.Count;
		while (num < count && score >= sortedRegressBonusRewardConfigList[num].NeedScore)
		{
			num++;
		}
		return num;
	}

	// Token: 0x060066FA RID: 26362 RVA: 0x00203FB8 File Offset: 0x002021B8
	public IRegressLevelProgressData? GetLevelProgressDataByScore(int score)
	{
		IReadOnlyList<RegressBonusReward> sortedRegressBonusRewardConfigList = this.GetSortedRegressBonusRewardConfigList();
		int num = 0;
		int count = sortedRegressBonusRewardConfigList.Count;
		if (count == 0)
		{
			return null;
		}
		while (num < count && score >= sortedRegressBonusRewardConfigList[num].NeedScore)
		{
			num++;
		}
		if (num == count)
		{
			return new IRegressLevelProgressData?(new IRegressLevelProgressData
			{
				Level = num,
				MaxLevel = count,
				CurScore = sortedRegressBonusRewardConfigList[num - 1].NeedScore,
				NeedScore = sortedRegressBonusRewardConfigList[num - 1].NeedScore
			});
		}
		int num2 = (num > 0) ? sortedRegressBonusRewardConfigList[num - 1].NeedScore : 0;
		return new IRegressLevelProgressData?(new IRegressLevelProgressData
		{
			Level = num,
			MaxLevel = count,
			CurScore = score - num2,
			NeedScore = sortedRegressBonusRewardConfigList[num].NeedScore - num2
		});
	}

	// Token: 0x060066FB RID: 26363 RVA: 0x002040B0 File Offset: 0x002022B0
	public IRegressLevelProgressData GetCurLevelProgressData()
	{
		int commonItemCount = InventoryModel.Instance.GetCommonItemCount(20, 0);
		IRegressLevelProgressData? levelProgressDataByScore = this.GetLevelProgressDataByScore(commonItemCount);
		if (levelProgressDataByScore == null)
		{
			levelProgressDataByScore = new IRegressLevelProgressData?(new IRegressLevelProgressData
			{
				Level = 0,
				MaxLevel = 0,
				CurScore = 0,
				NeedScore = 0
			});
		}
		return levelProgressDataByScore.Value;
	}

	// Token: 0x060066FC RID: 26364 RVA: 0x00204113 File Offset: 0x00202313
	public bool IsPayRewardUnlock()
	{
		RegressData regressRawData = this.RegressRawData;
		return regressRawData != null && regressRawData.PayRewardUnlock;
	}

	// Token: 0x060066FD RID: 26365 RVA: 0x00204126 File Offset: 0x00202326
	public int GetMaxLevel()
	{
		return this.GetSortedRegressBonusRewardConfigList().Count;
	}

	// Token: 0x060066FE RID: 26366 RVA: 0x00204133 File Offset: 0x00202333
	public void SetPayRewardUnlock(bool value)
	{
		if (this.RegressRawData != null)
		{
			this.RegressRawData.PayRewardUnlock = value;
		}
	}

	// Token: 0x060066FF RID: 26367 RVA: 0x00204149 File Offset: 0x00202349
	public void ResetBpPayButtonRedDot()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressBpPayButtonRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(false));
	}

	// Token: 0x06006700 RID: 26368 RVA: 0x00204168 File Offset: 0x00202368
	public bool CheckBpPayButtonRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressBpPayButtonRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressBpPayButtonRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressBpPayButtonRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x06006701 RID: 26369 RVA: 0x002041AB File Offset: 0x002023AB
	public void SetBpPayButtonRedDotChecked()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressBpPayButtonRedDotCheckedInPeriod) as ServerStorageBoolean).Set(new bool?(true));
	}

	// Token: 0x06006702 RID: 26370 RVA: 0x002041C9 File Offset: 0x002023C9
	public void RefreshPrevBpExp()
	{
		this.PrevBpExpInternal = InventoryModel.Instance.GetCommonItemCount(20, 0);
	}

	// Token: 0x06006703 RID: 26371 RVA: 0x002041E0 File Offset: 0x002023E0
	public IReadOnlyList<RegressBonusReward> GetSortedRegressBonusRewardConfigList()
	{
		if (this.SortedRegressBonusRewardConfigList == null || this.SortedRegressBonusRewardConfigList.Count == 0)
		{
			IReadOnlyList<RegressBonusReward> collection = ActivityRegressConfig.Instance.GetRegressBonusRewardConfigList(this.Grade) ?? new List<RegressBonusReward>();
			this.SortedRegressBonusRewardConfigList = new List<RegressBonusReward>(collection);
			this.SortedRegressBonusRewardConfigList.Sort((RegressBonusReward a, RegressBonusReward b) => a.NeedScore - b.NeedScore);
		}
		return this.SortedRegressBonusRewardConfigList;
	}

	// Token: 0x040041A2 RID: 16802
	[Nullable(2)]
	private RegressData RegressRawData;

	// Token: 0x040041A3 RID: 16803
	private const int ACTIVITY_REGRESS_REWARD_BTN_CLICK_KEY = 100;

	// Token: 0x040041A4 RID: 16804
	private readonly Dictionary<int, ActivityTask> ActivityInternalTaskMap = new Dictionary<int, ActivityTask>();

	// Token: 0x040041A5 RID: 16805
	private readonly Dictionary<int, int> ActivityScoreRewardTotalNeedScoreMap = new Dictionary<int, int>();

	// Token: 0x040041A6 RID: 16806
	private long ActivityRecallDailyTaskRefreshTime;

	// Token: 0x040041A7 RID: 16807
	public int CurrentUseTrialRole;

	// Token: 0x040041A8 RID: 16808
	public bool DisposableReward;

	// Token: 0x040041A9 RID: 16809
	private int PrevBpExpInternal;

	// Token: 0x040041AA RID: 16810
	[Nullable(2)]
	private List<RegressBonusReward> SortedRegressBonusRewardConfigList;

	// Token: 0x040041AB RID: 16811
	private readonly List<ERegressQuestionnaireType> CheckQuestionnaireTypes = new List<ERegressQuestionnaireType>
	{
		ERegressQuestionnaireType.Type1,
		ERegressQuestionnaireType.Type2
	};

	// Token: 0x040041AC RID: 16812
	private readonly Dictionary<ERegressTaskType, List<RegressQuest>> RegressTaskMapping = new Dictionary<ERegressTaskType, List<RegressQuest>>();
}
