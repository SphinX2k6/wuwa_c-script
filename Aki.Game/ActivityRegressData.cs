using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.SkipInterface;
using Google.Protobuf.Collections;

// Token: 0x0200144F RID: 5199
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressData : ActivityBaseData
{
	// Token: 0x17000CD5 RID: 3285
	// (get) Token: 0x0600931E RID: 37662 RVA: 0x001F9E1E File Offset: 0x001F801E
	public int PrevBpExp
	{
		get
		{
			return this.PrevBpExpInternal;
		}
	}

	// Token: 0x0600931F RID: 37663 RVA: 0x001F9E28 File Offset: 0x001F8028
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

	// Token: 0x06009320 RID: 37664 RVA: 0x001FA068 File Offset: 0x001F8268
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

	// Token: 0x06009321 RID: 37665 RVA: 0x001FA1B8 File Offset: 0x001F83B8
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

	// Token: 0x17000CD6 RID: 3286
	// (get) Token: 0x06009322 RID: 37666 RVA: 0x001FA1E6 File Offset: 0x001F83E6
	// (set) Token: 0x06009323 RID: 37667 RVA: 0x001FA1FD File Offset: 0x001F83FD
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

	// Token: 0x06009324 RID: 37668 RVA: 0x001FA213 File Offset: 0x001F8413
	public override bool CheckIfInOpenTime()
	{
		return base.CheckIfInTimeInterval(base.BeginOpenTime, base.EndOpenTime);
	}

	// Token: 0x06009325 RID: 37669 RVA: 0x001FA228 File Offset: 0x001F8428
	public double GetActivityOpenTimeLeft()
	{
		long endOpenTime = base.EndOpenTime;
		return Math.Max(0.0, (double)endOpenTime - TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x06009326 RID: 37670 RVA: 0x001FA257 File Offset: 0x001F8457
	public bool IsActivityOpen()
	{
		return this.GetActivityState() == EActivityRecallState.Opening;
	}

	// Token: 0x06009327 RID: 37671 RVA: 0x001FA264 File Offset: 0x001F8464
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

	// Token: 0x06009328 RID: 37672 RVA: 0x001FA2A0 File Offset: 0x001F84A0
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

	// Token: 0x06009329 RID: 37673 RVA: 0x001FA304 File Offset: 0x001F8504
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

	// Token: 0x0600932A RID: 37674 RVA: 0x001FA344 File Offset: 0x001F8544
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

	// Token: 0x0600932B RID: 37675 RVA: 0x001FA3BC File Offset: 0x001F85BC
	public int GetSignRewardEntityId(int day)
	{
		ActivityTask signRewardRawData = this.GetSignRewardRawData(day);
		if (signRewardRawData == null)
		{
			return 0;
		}
		return signRewardRawData.Id;
	}

	// Token: 0x0600932C RID: 37676 RVA: 0x001FA3DC File Offset: 0x001F85DC
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

	// Token: 0x0600932D RID: 37677 RVA: 0x001FA42B File Offset: 0x001F862B
	public bool IsRegressTaskScoreOverExp()
	{
		return this.GetRegressTaskProgressFloat01() >= 1.0;
	}

	// Token: 0x0600932E RID: 37678 RVA: 0x001FA444 File Offset: 0x001F8644
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

	// Token: 0x0600932F RID: 37679 RVA: 0x001FA47C File Offset: 0x001F867C
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

	// Token: 0x06009330 RID: 37680 RVA: 0x001FA4B8 File Offset: 0x001F86B8
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

	// Token: 0x06009331 RID: 37681 RVA: 0x001FA540 File Offset: 0x001F8740
	public override bool GetExDataRedPointShowState()
	{
		return this.IsActivityOpen() && (this.HasSignRewardCanClaimed() || this.CheckRegressScoreRewardReached() || this.CheckShowQuestionnaireRedDot() || this.CheckShopRedDot() || this.CheckTrialRoleRedDot() || this.CheckDisposableRewardRedDot() || this.HasReachableConstantTask() || this.CheckRegressRewardBtnReached());
	}

	// Token: 0x06009332 RID: 37682 RVA: 0x001FA597 File Offset: 0x001F8797
	public int GetBossDoubleDropCount()
	{
		RegressData regressRawData = this.RegressRawData;
		if (regressRawData == null)
		{
			return 0;
		}
		return regressRawData.BossDoubleCount;
	}

	// Token: 0x06009333 RID: 37683 RVA: 0x001FA5AA File Offset: 0x001F87AA
	public int GetWeekDoubleDropCount()
	{
		RegressData regressRawData = this.RegressRawData;
		if (regressRawData == null)
		{
			return 0;
		}
		return regressRawData.WeekDoubleCount;
	}

	// Token: 0x06009334 RID: 37684 RVA: 0x001FA5C0 File Offset: 0x001F87C0
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

	// Token: 0x06009335 RID: 37685 RVA: 0x001FA64C File Offset: 0x001F884C
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

	// Token: 0x06009336 RID: 37686 RVA: 0x001FA6F0 File Offset: 0x001F88F0
	public bool CheckQuestionnaireFirstRedDot()
	{
		return this.IsActivityOpen() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressQuestionnaireRedDotCheckedInPeriod, false);
	}

	// Token: 0x06009337 RID: 37687 RVA: 0x001FA708 File Offset: 0x001F8908
	public bool CheckSecondQuestionnaireFirstRedDot()
	{
		if (!this.IsActivityOpen())
		{
			return false;
		}
		bool flag = this.IsQuestionnaireUnlock(ERegressQuestionnaireType.Type2);
		return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod, false) && flag;
	}

	// Token: 0x06009338 RID: 37688 RVA: 0x001FA734 File Offset: 0x001F8934
	public bool CheckDisposableRewardRedDot()
	{
		return !this.DisposableReward;
	}

	// Token: 0x06009339 RID: 37689 RVA: 0x001FA73F File Offset: 0x001F893F
	public void ResetQuestionnaireRedDot()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressQuestionnaireRedDotCheckedInPeriod, false);
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod, false);
	}

	// Token: 0x0600933A RID: 37690 RVA: 0x001FA754 File Offset: 0x001F8954
	public void SetQuestionnaireRedDotChecked()
	{
		if (this.CheckQuestionnaireFirstRedDot())
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressQuestionnaireRedDotCheckedInPeriod, true);
		}
		if (this.CheckSecondQuestionnaireFirstRedDot())
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod, true);
		}
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600933B RID: 37691 RVA: 0x001FA7A9 File Offset: 0x001F89A9
	public bool CheckShopRedDot()
	{
		return this.IsActivityOpen() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressShopRedDotCheckedInPeriod, false);
	}

	// Token: 0x0600933C RID: 37692 RVA: 0x001FA7C0 File Offset: 0x001F89C0
	public bool CheckTrialRoleRedDot()
	{
		return this.IsActivityOpen() && (this.CheckNewUnLockRole() || this.IsTrialRoleUpgradeRedPoint());
	}

	// Token: 0x0600933D RID: 37693 RVA: 0x001FA7DC File Offset: 0x001F89DC
	public bool CheckNewUnLockRole()
	{
		return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressTrialRoleRedDotCheckedInPeriod, false);
	}

	// Token: 0x0600933E RID: 37694 RVA: 0x001FA7EC File Offset: 0x001F89EC
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

	// Token: 0x0600933F RID: 37695 RVA: 0x001FA848 File Offset: 0x001F8A48
	public List<TrialRoleGroupData> GetTrialRoleList()
	{
		return TrialRoleModel.Instance.GetDataListByType(ETrialRoleType.ReturnSupportTrial);
	}

	// Token: 0x06009340 RID: 37696 RVA: 0x001FA855 File Offset: 0x001F8A55
	public bool CheckDoubleDropRedDot()
	{
		return this.IsActivityOpen() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressDoubleDropRedDotCheckedInPeriod, false);
	}

	// Token: 0x06009341 RID: 37697 RVA: 0x001FA86C File Offset: 0x001F8A6C
	public bool CheckRecommendRedDot()
	{
		return this.IsActivityOpen() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressRecommendRedDotCheckedInPeriod, false);
	}

	// Token: 0x06009342 RID: 37698 RVA: 0x001FA883 File Offset: 0x001F8A83
	public bool CheckAdventureRedDot()
	{
		return this.IsActivityOpen() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressAdventureRedDotCheckedInPeriod, false);
	}

	// Token: 0x06009343 RID: 37699 RVA: 0x001FA89A File Offset: 0x001F8A9A
	public void ResetShopRemindRedDot()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressShopRedDotCheckedInPeriod, false);
	}

	// Token: 0x06009344 RID: 37700 RVA: 0x001FA8A5 File Offset: 0x001F8AA5
	public void SetShopRedDotChecked()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressShopRedDotCheckedInPeriod, true);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06009345 RID: 37701 RVA: 0x001FA8D6 File Offset: 0x001F8AD6
	public void SetTrialRoleRedDotChecked(bool value)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressTrialRoleRedDotCheckedInPeriod, value);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06009346 RID: 37702 RVA: 0x001FA907 File Offset: 0x001F8B07
	public void SetDoubleDropRedDotChecked()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressDoubleDropRedDotCheckedInPeriod, true);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x06009347 RID: 37703 RVA: 0x001FA922 File Offset: 0x001F8B22
	public void SetRecommendRedDotChecked()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressRecommendRedDotCheckedInPeriod, true);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x06009348 RID: 37704 RVA: 0x001FA93D File Offset: 0x001F8B3D
	public void SetAdventureRedDotChecked()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressAdventureRedDotCheckedInPeriod, true);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x06009349 RID: 37705 RVA: 0x001FA958 File Offset: 0x001F8B58
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

	// Token: 0x0600934A RID: 37706 RVA: 0x001FA9D8 File Offset: 0x001F8BD8
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

	// Token: 0x0600934B RID: 37707 RVA: 0x001FAA1C File Offset: 0x001F8C1C
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

	// Token: 0x0600934C RID: 37708 RVA: 0x001FAA94 File Offset: 0x001F8C94
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

	// Token: 0x0600934D RID: 37709 RVA: 0x001FAB5C File Offset: 0x001F8D5C
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

	// Token: 0x0600934E RID: 37710 RVA: 0x001FAB7C File Offset: 0x001F8D7C
	public List<RegressQuest> GetAllRegressTaskList()
	{
		List<RegressQuest> list = new List<RegressQuest>();
		foreach (KeyValuePair<ERegressTaskType, List<RegressQuest>> keyValuePair in this.RegressTaskMapping)
		{
			list.AddRange(keyValuePair.Value);
		}
		return list;
	}

	// Token: 0x0600934F RID: 37711 RVA: 0x001FABDC File Offset: 0x001F8DDC
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

	// Token: 0x06009350 RID: 37712 RVA: 0x001FAC48 File Offset: 0x001F8E48
	public bool HasReachableConstantTask()
	{
		return this.GetRegressTaskProgressFloat01() < 1.0 && (this.HasReachableTask(ERegressTaskType.Constant) || this.HasReachableTask(ERegressTaskType.Daily) || this.HasReachableTask(ERegressTaskType.Once));
	}

	// Token: 0x06009351 RID: 37713 RVA: 0x001FAC78 File Offset: 0x001F8E78
	public bool HasReachableCultivateTask()
	{
		return this.HasReachableTask(ERegressTaskType.Cultivate);
	}

	// Token: 0x06009352 RID: 37714 RVA: 0x001FAC84 File Offset: 0x001F8E84
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

	// Token: 0x06009353 RID: 37715 RVA: 0x001FACDD File Offset: 0x001F8EDD
	public int GetRegressTaskScore()
	{
		return this.GetRegressTaskProgressTuple().Item1;
	}

	// Token: 0x06009354 RID: 37716 RVA: 0x001FACEC File Offset: 0x001F8EEC
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

	// Token: 0x06009355 RID: 37717 RVA: 0x001FAD4C File Offset: 0x001F8F4C
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

	// Token: 0x06009356 RID: 37718 RVA: 0x001FADAC File Offset: 0x001F8FAC
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

	// Token: 0x06009357 RID: 37719 RVA: 0x001FADD1 File Offset: 0x001F8FD1
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

	// Token: 0x06009358 RID: 37720 RVA: 0x001FAE10 File Offset: 0x001F9010
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

	// Token: 0x06009359 RID: 37721 RVA: 0x001FAE88 File Offset: 0x001F9088
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

	// Token: 0x0600935A RID: 37722 RVA: 0x001FAF40 File Offset: 0x001F9140
	public bool CheckRegressRewardBtnReached()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
	}

	// Token: 0x0600935B RID: 37723 RVA: 0x001FAF5A File Offset: 0x001F915A
	public void SetRegressRewardBtnReached()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600935C RID: 37724 RVA: 0x001FAF98 File Offset: 0x001F9198
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

	// Token: 0x0600935D RID: 37725 RVA: 0x001FB018 File Offset: 0x001F9218
	private void RefreshScoreRewardNeedScoreList()
	{
		this.ActivityScoreRewardTotalNeedScoreMap.Clear();
		foreach (RegressBonusReward regressBonusReward in (ActivityRegressConfig.Instance.GetRegressBonusRewardConfigList(this.Grade) ?? new List<RegressBonusReward>()))
		{
			this.ActivityScoreRewardTotalNeedScoreMap[regressBonusReward.Id] = regressBonusReward.NeedScore;
		}
	}

	// Token: 0x0600935E RID: 37726 RVA: 0x001FB098 File Offset: 0x001F9298
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

	// Token: 0x0600935F RID: 37727 RVA: 0x001FB0D4 File Offset: 0x001F92D4
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

	// Token: 0x06009360 RID: 37728 RVA: 0x001FB145 File Offset: 0x001F9345
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

	// Token: 0x06009361 RID: 37729 RVA: 0x001FB174 File Offset: 0x001F9374
	public void ResetDoubleDropFirstRedDot()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod, false);
	}

	// Token: 0x06009362 RID: 37730 RVA: 0x001FB17F File Offset: 0x001F937F
	public void MarkDoubleDropFirstRedDotShown()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod, true);
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06009363 RID: 37731 RVA: 0x001FB1B0 File Offset: 0x001F93B0
	public bool CheckDoubleDropFirstRedDot()
	{
		return this.IsActivityOpen() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod, false);
	}

	// Token: 0x06009364 RID: 37732 RVA: 0x001FB1C8 File Offset: 0x001F93C8
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

	// Token: 0x06009365 RID: 37733 RVA: 0x001FB204 File Offset: 0x001F9404
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

	// Token: 0x06009366 RID: 37734 RVA: 0x001FB2FC File Offset: 0x001F94FC
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

	// Token: 0x06009367 RID: 37735 RVA: 0x001FB35F File Offset: 0x001F955F
	public bool IsPayRewardUnlock()
	{
		RegressData regressRawData = this.RegressRawData;
		return regressRawData != null && regressRawData.PayRewardUnlock;
	}

	// Token: 0x06009368 RID: 37736 RVA: 0x001FB372 File Offset: 0x001F9572
	public int GetMaxLevel()
	{
		return this.GetSortedRegressBonusRewardConfigList().Count;
	}

	// Token: 0x06009369 RID: 37737 RVA: 0x001FB37F File Offset: 0x001F957F
	public void SetPayRewardUnlock(bool value)
	{
		if (this.RegressRawData != null)
		{
			this.RegressRawData.PayRewardUnlock = value;
		}
	}

	// Token: 0x0600936A RID: 37738 RVA: 0x001FB395 File Offset: 0x001F9595
	public void ResetBpPayButtonRedDot()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressBpPayButtonRedDotCheckedInPeriod, false);
	}

	// Token: 0x0600936B RID: 37739 RVA: 0x001FB3A0 File Offset: 0x001F95A0
	public bool CheckBpPayButtonRedDot()
	{
		return this.IsActivityOpen() && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressBpPayButtonRedDotCheckedInPeriod, false);
	}

	// Token: 0x0600936C RID: 37740 RVA: 0x001FB3B7 File Offset: 0x001F95B7
	public void SetBpPayButtonRedDotChecked()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressBpPayButtonRedDotCheckedInPeriod, true);
	}

	// Token: 0x0600936D RID: 37741 RVA: 0x001FB3C2 File Offset: 0x001F95C2
	public void RefreshPrevBpExp()
	{
		this.PrevBpExpInternal = InventoryModel.Instance.GetCommonItemCount(20, 0);
	}

	// Token: 0x0600936E RID: 37742 RVA: 0x001FB3D8 File Offset: 0x001F95D8
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

	// Token: 0x0400410A RID: 16650
	[Nullable(2)]
	private RegressData RegressRawData;

	// Token: 0x0400410B RID: 16651
	private const int ACTIVITY_REGRESS_REWARD_BTN_CLICK_KEY = 100;

	// Token: 0x0400410C RID: 16652
	private readonly Dictionary<int, ActivityTask> ActivityInternalTaskMap = new Dictionary<int, ActivityTask>();

	// Token: 0x0400410D RID: 16653
	private readonly Dictionary<int, int> ActivityScoreRewardTotalNeedScoreMap = new Dictionary<int, int>();

	// Token: 0x0400410E RID: 16654
	private long ActivityRecallDailyTaskRefreshTime;

	// Token: 0x0400410F RID: 16655
	public int CurrentUseTrialRole;

	// Token: 0x04004110 RID: 16656
	public bool DisposableReward;

	// Token: 0x04004111 RID: 16657
	private int PrevBpExpInternal;

	// Token: 0x04004112 RID: 16658
	[Nullable(2)]
	private List<RegressBonusReward> SortedRegressBonusRewardConfigList;

	// Token: 0x04004113 RID: 16659
	private readonly List<ERegressQuestionnaireType> CheckQuestionnaireTypes = new List<ERegressQuestionnaireType>
	{
		ERegressQuestionnaireType.Type1,
		ERegressQuestionnaireType.Type2
	};

	// Token: 0x04004114 RID: 16660
	private readonly Dictionary<ERegressTaskType, List<RegressQuest>> RegressTaskMapping = new Dictionary<ERegressTaskType, List<RegressQuest>>();
}
