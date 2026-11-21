using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;

// Token: 0x02000B36 RID: 2870
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityModel : ModelBase
{
	// Token: 0x06007685 RID: 30341 RVA: 0x00248474 File Offset: 0x00246674
	protected override bool OnInit()
	{
		this.InitActivityLevelFuncMap();
		this.InitLangText();
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
		return true;
	}

	// Token: 0x06007686 RID: 30342 RVA: 0x002484A0 File Offset: 0x002466A0
	protected override bool OnClear()
	{
		foreach (TimerHandle handle in this.ActivityTimeStampHandleMap.Values)
		{
			TimerSystem.RealTimeInstance.Remove(handle);
		}
		this.ActivityTimeStampHandleMap.Clear();
		this.ActivityTimeStampSet.Clear();
		foreach (ActivityBaseData activityBaseData in this.ActivityMap.Values)
		{
			activityBaseData.UnRegisterEvents();
		}
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
		return true;
	}

	// Token: 0x06007687 RID: 30343 RVA: 0x00248574 File Offset: 0x00246774
	public void InitCache()
	{
		this.ActivityCache.InitData();
	}

	// Token: 0x06007688 RID: 30344 RVA: 0x00248584 File Offset: 0x00246784
	private void InitLangText()
	{
		if (StringUtils.IsEmpty(this.ActivityForeverTimeText))
		{
			this.ActivityForeverTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityForeverTip", null);
		}
		if (StringUtils.IsEmpty(this.ActivityCloseText))
		{
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("ActiveClose");
			this.ActivityCloseText = ConfigMultiTextLang.GetLocalTextNew(textContentIdById, null);
		}
		if (StringUtils.IsEmpty(this.ActivityCdTimeText))
		{
			this.ActivityCdTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityClosePanelTime", null);
		}
		if (StringUtils.IsEmpty(this.ActivityRemainTimeText))
		{
			this.ActivityRemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
		}
		if (StringUtils.IsEmpty(this.ActivityRemainingTimeReward))
		{
			this.ActivityRemainingTimeReward = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime_Reward_Text", null);
		}
	}

	// Token: 0x06007689 RID: 30345 RVA: 0x00248633 File Offset: 0x00246833
	protected void OnLanguageChange(string s, string s1)
	{
		this.ActivityForeverTimeText = "";
		this.ActivityCloseText = "";
		this.ActivityCdTimeText = "";
		this.ActivityRemainTimeText = "";
		this.ActivityRemainingTimeReward = "";
		this.InitLangText();
	}

	// Token: 0x0600768A RID: 30346 RVA: 0x00248674 File Offset: 0x00246874
	public unsafe void OnReceiveMessageData(IReadOnlyList<ActivityData> data)
	{
		foreach (KeyValuePair<int, ActivityBaseData> keyValuePair in this.ActivityMap)
		{
			keyValuePair.Value.ForceClose();
		}
		foreach (ActivityData activityData in data)
		{
			if (ActivityManager.GetActivityController(activityData.Type) != null)
			{
				try
				{
					ActivityBaseData orCreateActivity = this.GetOrCreateActivity(activityData);
					if (orCreateActivity != null)
					{
						orCreateActivity.Phrase(activityData);
					}
					continue;
				}
				catch (Exception ex)
				{
					this.OpenActivityErrorConfirmBox(activityData.Id, (int)activityData.Type);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Activity;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "[Activity]Phrase执行异常";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", activityData.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					continue;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Activity;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "尚未实现活动";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", activityData.Type);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (ActivityData activityData2 in data)
		{
			if (!dictionary.ContainsKey((int)activityData2.Type))
			{
				dictionary[(int)activityData2.Type] = new List<int>();
			}
			dictionary[(int)activityData2.Type].Add(activityData2.Id);
		}
		foreach (KeyValuePair<int, List<int>> keyValuePair2 in dictionary)
		{
			EventSystem.Instance.Emit<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, keyValuePair2.Key, keyValuePair2.Value);
		}
		this.RefreshShowingActivities();
		this.RefreshActivityFirstUnlockState();
		Log.Instance.Info(ELogModule.Activity, ELogAuthor.YYZ, "ActivityRequest 收到活动数据", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600768B RID: 30347 RVA: 0x002488F0 File Offset: 0x00246AF0
	public void OnReceiveActivityRead(int activityId)
	{
		ActivityBaseData activityBaseData;
		if (this.ActivityMap.TryGetValue(activityId, out activityBaseData))
		{
			activityBaseData.SetFirstOpenFalse();
		}
	}

	// Token: 0x0600768C RID: 30348 RVA: 0x00248914 File Offset: 0x00246B14
	public unsafe void OnActivityUpdate(IReadOnlyList<ActivityData> data)
	{
		foreach (ActivityData activityData in data)
		{
			if (ActivityManager.GetActivityController(activityData.Type) != null)
			{
				try
				{
					ActivityBaseData orCreateActivity = this.GetOrCreateActivity(activityData);
					if (orCreateActivity != null)
					{
						orCreateActivity.Phrase(activityData);
					}
					continue;
				}
				catch (Exception ex)
				{
					this.OpenActivityErrorConfirmBox(activityData.Id, (int)activityData.Type);
					if (ex != null)
					{
						Exception ex2 = ex;
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Activity;
						ELogAuthor author = ELogAuthor.YYZ;
						string message = "[Activity]Phrase执行异常";
						Exception error = ex2;
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", activityData.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex2.Message);
						instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Activity;
						ELogAuthor author2 = ELogAuthor.YYZ;
						string message2 = "[Activity]Phrase执行异常";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", activityData.Id);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					continue;
				}
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Activity;
			ELogAuthor author3 = ELogAuthor.YZY;
			string message3 = "尚未实现活动";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("type", activityData.Type);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (ActivityData activityData2 in data)
		{
			if (!dictionary.ContainsKey((int)activityData2.Type))
			{
				dictionary[(int)activityData2.Type] = new List<int>();
			}
			dictionary[(int)activityData2.Type].Add(activityData2.Id);
		}
		foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
		{
			EventSystem.Instance.Emit<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, keyValuePair.Key, keyValuePair.Value);
		}
		this.RefreshShowingActivities();
		if (GameModeModel.Instance.WorldDone)
		{
			this.RefreshActivityFirstUnlockState();
		}
		EventSystem.Instance.Emit(EEventName.OnActivityUpdate);
	}

	// Token: 0x0600768D RID: 30349 RVA: 0x00248BB0 File Offset: 0x00246DB0
	public void OnDisableActivity(IReadOnlyList<int> ids)
	{
		foreach (int key in ids)
		{
			ActivityBaseData activityBaseData;
			if (this.ActivityMap.TryGetValue(key, out activityBaseData))
			{
				activityBaseData.ActivityClose();
				activityBaseData.ForceClose();
			}
		}
		this.RefreshShowingActivities();
		EventSystem.Instance.Emit(EEventName.OnActivityUpdate);
	}

	// Token: 0x0600768E RID: 30350 RVA: 0x00248C24 File Offset: 0x00246E24
	[return: Nullable(2)]
	private unsafe ActivityBaseData GetOrCreateActivity(ActivityData data)
	{
		ActivityBaseData activityBaseData;
		if (this.ActivityMap.TryGetValue(data.Id, out activityBaseData))
		{
			return activityBaseData;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		long num = MathUtils.Instance.LongToBigInt(data.BeginShowTime);
		long num2 = MathUtils.Instance.LongToBigInt(data.BeginOpenTime);
		if (serverTime <= (double)num && serverTime <= (double)num2)
		{
			long checkTime = Math.Min(num2, num);
			this.SetActivityTimeCheck(checkTime, data.Id, true);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "活动待开启";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", data.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ShowTime", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OpenTime", num2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return null;
		}
		long val = MathUtils.Instance.LongToBigInt(data.EndShowTime);
		long val2 = MathUtils.Instance.LongToBigInt(data.EndOpenTime);
		long checkTime2 = Math.Max(val, val2);
		this.SetActivityTimeCheck(checkTime2, data.Id, false);
		activityBaseData = ActivityController.Instance.CreateActivityData(data);
		this.ActivityMap[data.Id] = activityBaseData;
		this.CurrentActivityIds.Add(data.Id);
		return activityBaseData;
	}

	// Token: 0x0600768F RID: 30351 RVA: 0x00248D8C File Offset: 0x00246F8C
	private void SetActivityTimeCheck(long checkTime, int activityId, bool isOpen)
	{
		if (this.ActivityTimeStampSet.Contains(checkTime))
		{
			return;
		}
		if ((double)checkTime < TimeUtil.Instance.GetServerTime())
		{
			return;
		}
		double num = MathUtils.Instance.GetRandomRange(0.0, 10.0) * (double)TimeUtil.Instance.InverseMillisecond;
		double emitTimeStamp = (double)(checkTime * (long)TimeUtil.Instance.InverseMillisecond) + num + 20.0;
		string reason = StringUtils.Format("活动开启关闭时间倒计时 [ActivityId:{0}, IsOpen:{1}]", new string[]
		{
			activityId.ToString(),
			isOpen.ToString()
		});
		TimerHandle timerHandle = TimerSystem.RealTimeInstance.EmitOnTime(delegate(float _)
		{
			this.ActivityTimeStampCheck(checkTime);
		}, emitTimeStamp, null, reason, true, 1f);
		if (timerHandle == null)
		{
			return;
		}
		this.ActivityTimeStampSet.Add(checkTime);
		this.ActivityTimeStampHandleMap[checkTime] = timerHandle;
	}

	// Token: 0x06007690 RID: 30352 RVA: 0x00248E90 File Offset: 0x00247090
	private void ActivityTimeStampCheck(long checkTime)
	{
		Log.Instance.Info(ELogModule.Activity, ELogAuthor.YYZ, "ActivityTimeStampCheck 活动开始结束时间检查", default(ReadOnlySpan<ValueTuple<string, object>>));
		ActivityController.Instance.RequestActivityData();
		TimerHandle handle;
		if (this.ActivityTimeStampHandleMap.TryGetValue(checkTime, out handle))
		{
			TimerSystem.RealTimeInstance.Remove(handle);
			this.ActivityTimeStampHandleMap.Remove(checkTime);
		}
		this.ActivityTimeStampSet.Remove(checkTime);
	}

	// Token: 0x06007691 RID: 30353 RVA: 0x00248EFD File Offset: 0x002470FD
	public bool GetIfFunctionOpen()
	{
		return FunctionModel.Instance.IsOpen(10053);
	}

	// Token: 0x06007692 RID: 30354 RVA: 0x00248F10 File Offset: 0x00247110
	private bool ShouldDefaultToNewbieTab()
	{
		ActivitySevenDaySignData newcomerSignInActivityData = this.GetNewcomerSignInActivityData();
		return newcomerSignInActivityData != null && !newcomerSignInActivityData.IsAllSignRewardReceived();
	}

	// Token: 0x06007693 RID: 30355 RVA: 0x00248F34 File Offset: 0x00247134
	[NullableContext(2)]
	private ActivitySevenDaySignData GetNewcomerSignInActivityData()
	{
		List<ActivityBaseData> activitiesByType = this.GetActivitiesByType(2);
		if (activitiesByType == null || activitiesByType.Count <= 0)
		{
			return null;
		}
		foreach (ActivityBaseData activityBaseData in activitiesByType)
		{
			ActivitySevenDaySignData activitySevenDaySignData = activityBaseData as ActivitySevenDaySignData;
			if (activitySevenDaySignData != null)
			{
				ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(activitySevenDaySignData.Id);
				if (activitySignById != null && activitySignById.GetValueOrDefault().Type == 3 && activitySevenDaySignData.CheckIfInOpenTime())
				{
					return activitySevenDaySignData;
				}
			}
		}
		return null;
	}

	// Token: 0x06007694 RID: 30356 RVA: 0x00248FDC File Offset: 0x002471DC
	private int? FindTabIdByFilterTabType(IActivityCategoryTabData[] tabDataList, int filterTabType)
	{
		Predicate<ActivityBaseData> <>9__0;
		foreach (IActivityCategoryTabData activityCategoryTabData in tabDataList)
		{
			if (!activityCategoryTabData.IsLineType && activityCategoryTabData.Id != null)
			{
				List<ActivityBaseData> activities = activityCategoryTabData.Activities;
				bool flag;
				if (activities == null)
				{
					flag = false;
				}
				else
				{
					Predicate<ActivityBaseData> match;
					if ((match = <>9__0) == null)
					{
						match = (<>9__0 = ((ActivityBaseData activity) => activity.LocalConfig != null && activity.LocalConfig.GetValueOrDefault().FilterTabType == filterTabType));
					}
					flag = activities.Exists(match);
				}
				if (flag)
				{
					return activityCategoryTabData.Id;
				}
			}
		}
		return null;
	}

	// Token: 0x06007695 RID: 30357 RVA: 0x0024906C File Offset: 0x0024726C
	public int? GetDefaultOpenTabId(IActivityCategoryTabData[] tabDataList)
	{
		if (tabDataList == null || tabDataList.Length == 0)
		{
			return null;
		}
		int filterTabType = this.ShouldDefaultToNewbieTab() ? 2 : 1;
		int? result = this.FindTabIdByFilterTabType(tabDataList, filterTabType);
		if (result != null)
		{
			return result;
		}
		foreach (IActivityCategoryTabData activityCategoryTabData in tabDataList)
		{
			if (!activityCategoryTabData.IsLineType)
			{
				return activityCategoryTabData.Id;
			}
		}
		return null;
	}

	// Token: 0x06007696 RID: 30358 RVA: 0x002490DF File Offset: 0x002472DF
	public bool GetIfShowActivity()
	{
		return this.GetIfFunctionOpen();
	}

	// Token: 0x06007697 RID: 30359 RVA: 0x002490EC File Offset: 0x002472EC
	public Dictionary<int, ActivityBaseData> GetAllActivityMap()
	{
		return this.ActivityMap;
	}

	// Token: 0x06007698 RID: 30360 RVA: 0x002490F4 File Offset: 0x002472F4
	[NullableContext(2)]
	public ActivityBaseData GetActivityById(int id)
	{
		ActivityBaseData result;
		if (!this.ActivityMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06007699 RID: 30361 RVA: 0x00249114 File Offset: 0x00247314
	public bool IsActivityOpen(int id)
	{
		ActivityBaseData activityBaseData;
		return this.ActivityMap.TryGetValue(id, out activityBaseData) && activityBaseData.CheckIfInShowTime();
	}

	// Token: 0x0600769A RID: 30362 RVA: 0x0024913C File Offset: 0x0024733C
	public List<ActivityBaseData> GetActivitiesByType(int type)
	{
		List<ActivityBaseData> list = new List<ActivityBaseData>();
		foreach (ActivityBaseData activityBaseData in this.ActivityMap.Values)
		{
			ActivityType type2 = activityBaseData.Type;
			if (activityBaseData.Type == (ActivityType)type)
			{
				list.Add(activityBaseData);
			}
		}
		return list;
	}

	// Token: 0x0600769B RID: 30363 RVA: 0x002491AC File Offset: 0x002473AC
	public List<ActivityBaseData> GetCurrentActivitiesByType(int type)
	{
		List<ActivityBaseData> list = new List<ActivityBaseData>();
		foreach (ActivityBaseData activityBaseData in this.CurrentShowingActivitiesMap.Values)
		{
			if (activityBaseData.Type == (ActivityType)type)
			{
				list.Add(activityBaseData);
			}
		}
		return list;
	}

	// Token: 0x0600769C RID: 30364 RVA: 0x00249214 File Offset: 0x00247414
	public List<ActivityBaseData> GetCurrentActivitiesByType(ActivityType type)
	{
		List<ActivityBaseData> list = new List<ActivityBaseData>();
		foreach (ActivityBaseData activityBaseData in this.CurrentShowingActivitiesMap.Values)
		{
			if (activityBaseData.Type == type)
			{
				list.Add(activityBaseData);
			}
		}
		return list;
	}

	// Token: 0x0600769D RID: 30365 RVA: 0x0024927C File Offset: 0x0024747C
	public List<ActivityBaseData> GetCurrentShowingActivities()
	{
		List<ActivityBaseData> list = new List<ActivityBaseData>(this.CurrentShowingActivitiesMap.Values);
		list.RemoveAll((ActivityBaseData data) => data.IsHiddenByConfig());
		foreach (ActivityBaseData activityBaseData in list)
		{
			activityBaseData.UpdateImportantBubble();
		}
		ActivityModel.SortActivityList<ActivityBaseData>(list);
		return list;
	}

	// Token: 0x0600769E RID: 30366 RVA: 0x00249308 File Offset: 0x00247508
	public bool IsHasShowingRecommendRecActivity()
	{
		foreach (ActivityBaseData activityBaseData in this.GetCurrentShowingActivities())
		{
			if (activityBaseData.LocalConfig != null && activityBaseData.LocalConfig.Value.IsTabEffectNotice)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600769F RID: 30367 RVA: 0x00249380 File Offset: 0x00247580
	private List<ActivityBaseData> GetDebugFilterActivityDataList()
	{
		List<ActivityBaseData> list = new List<ActivityBaseData>(this.CurrentShowingActivitiesMap.Values);
		if (this.DebugFilterMode)
		{
			list.RemoveAll((ActivityBaseData data) => !this.DebugFilterShowActivityIds.Contains(data.Id));
		}
		list.RemoveAll((ActivityBaseData data) => data.IsHiddenByConfig());
		return list;
	}

	// Token: 0x060076A0 RID: 30368 RVA: 0x002493E0 File Offset: 0x002475E0
	public bool HaveShowingActivity()
	{
		return this.GetCurrentShowingActivities().Count > 0;
	}

	// Token: 0x060076A1 RID: 30369 RVA: 0x002493F0 File Offset: 0x002475F0
	public bool GetIsActivityShowingByType(int type)
	{
		if (this.CurrentShowingActivitiesMap == null || this.CurrentShowingActivitiesMap.Count == 0)
		{
			return false;
		}
		using (Dictionary<int, ActivityBaseData>.ValueCollection.Enumerator enumerator = this.CurrentShowingActivitiesMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Type == (ActivityType)type)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060076A2 RID: 30370 RVA: 0x00249468 File Offset: 0x00247668
	public void RefreshShowingActivities()
	{
		this.CurrentRemoveActivities.Clear();
		this.CurrentAddActivities.Clear();
		foreach (KeyValuePair<int, ActivityBaseData> keyValuePair in this.ActivityMap)
		{
			ActivityBaseData value = keyValuePair.Value;
			bool flag = value.CheckIfInShowTime();
			if (this.CurrentShowingActivitiesMap.ContainsKey(value.Id) && !flag)
			{
				value.UnRegisterEvents();
				this.CurrentRemoveActivities.Add(value.Id);
				this.CurrentShowingActivitiesMap.Remove(value.Id);
			}
			else if (!this.CurrentShowingActivitiesMap.ContainsKey(value.Id) && flag)
			{
				this.CurrentAddActivities.Add(value.Id);
				this.CurrentShowingActivitiesMap[value.Id] = value;
			}
		}
		if (this.CurrentRemoveActivities.Count > 0)
		{
			EventSystem.Instance.Emit<IReadOnlySet<int>>(EEventName.OnActivityClose, this.CurrentRemoveActivities);
			EventSystem.Instance.Emit(EEventName.OnActivityUpdate);
		}
		if (this.CurrentAddActivities.Count > 0)
		{
			EventSystem.Instance.Emit<IReadOnlySet<int>>(EEventName.OnActivityOpen, this.CurrentAddActivities);
			EventSystem.Instance.Emit(EEventName.OnActivityUpdate);
		}
	}

	// Token: 0x060076A3 RID: 30371 RVA: 0x002495C8 File Offset: 0x002477C8
	private void RefreshActivityFirstUnlockState()
	{
		foreach (ActivityBaseData activityBaseData in this.GetCurrentShowingActivities())
		{
			int activityCacheData = this.GetActivityCacheData(activityBaseData.Id, 0, -100, 0, 0);
			if (activityBaseData.IsUnLock() && activityCacheData == 0)
			{
				IActivityControllerBase activityController = ActivityManager.GetActivityController(activityBaseData.Type);
				if (activityController != null)
				{
					activityController.OnActivityFirstUnlock(activityBaseData);
				}
				if (activityBaseData.TimeType == EActivityTimeType.TimeLimit && activityController != null)
				{
					activityController.OnShowActivityFirstUnlockView(activityBaseData);
				}
				this.SaveActivityData(activityBaseData.Id, -100, 0, 0, 1);
			}
		}
	}

	// Token: 0x060076A4 RID: 30372 RVA: 0x0024966C File Offset: 0x0024786C
	public void SaveActivityData(int activityId, int key1, int key2, int key3, int value)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		this.ActivityCache.SaveCacheData(activityById, key1, key2, key3, value);
	}

	// Token: 0x060076A5 RID: 30373 RVA: 0x00249694 File Offset: 0x00247894
	public int GetActivityCacheData(int activityId, int defaultValue, int key1, int key2, int key3)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		return this.ActivityCache.GetCacheData(activityById, defaultValue, key1, key2, key3);
	}

	// Token: 0x060076A6 RID: 30374 RVA: 0x002496BC File Offset: 0x002478BC
	public void SaveActivityDataByKey(int activityId, int key, int value)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		this.ActivityCache.SaveCacheDataByKey(activityById, key, value);
	}

	// Token: 0x060076A7 RID: 30375 RVA: 0x002496E0 File Offset: 0x002478E0
	public int GetActivityCacheDataByKey(int activityId, int defaultValue, int key)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		return this.ActivityCache.GetCacheDataByKey(activityById, defaultValue, key);
	}

	// Token: 0x060076A8 RID: 30376 RVA: 0x00249704 File Offset: 0x00247904
	public static void SortActivityList<[Nullable(0)] T>(List<T> activityDataList) where T : ActivityBaseData
	{
		foreach (T t in activityDataList)
		{
			t.CacheSortSinkState();
		}
		Comparison<T> comparison;
		if ((comparison = ActivityModel.<SortActivityList>O__51_0<T>.<0>__SortFunc) == null)
		{
			comparison = (ActivityModel.<SortActivityList>O__51_0<T>.<0>__SortFunc = new Comparison<T>(ActivityModel.SortFunc));
		}
		activityDataList.Sort(comparison);
	}

	// Token: 0x060076A9 RID: 30377 RVA: 0x00249778 File Offset: 0x00247978
	private static int SortFunc(ActivityBaseData a, ActivityBaseData b)
	{
		if (a.SortSinkStateCached != b.SortSinkStateCached)
		{
			if (!a.SortSinkStateCached)
			{
				return -1;
			}
			return 1;
		}
		else if (a.IsShowImportantBubble != b.IsShowImportantBubble)
		{
			if (!a.IsShowImportantBubble)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			if (a.IsShowImportantBubble && b.IsShowImportantBubble)
			{
				long bubbleEndShowTime = a.BubbleEndShowTime;
				long bubbleEndShowTime2 = b.BubbleEndShowTime;
				if (bubbleEndShowTime > 0L && bubbleEndShowTime2 > 0L && bubbleEndShowTime != bubbleEndShowTime2)
				{
					if (bubbleEndShowTime <= bubbleEndShowTime2)
					{
						return -1;
					}
					return 1;
				}
			}
			if (a.Sort != b.Sort)
			{
				return a.Sort - b.Sort;
			}
			if (a.BeginOpenTime == b.BeginOpenTime)
			{
				return a.Id - b.Id;
			}
			if (a.BeginOpenTime <= b.BeginOpenTime)
			{
				return -1;
			}
			return 1;
		}
	}

	// Token: 0x060076AA RID: 30378 RVA: 0x00249836 File Offset: 0x00247A36
	public bool GetActivityRedDotState(int activityId)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		return activityById != null && activityById.RedPointShowState;
	}

	// Token: 0x060076AB RID: 30379 RVA: 0x0024984A File Offset: 0x00247A4A
	public int GetActivityPermanentFilterId()
	{
		return this.ActivityPermanentFilterId;
	}

	// Token: 0x060076AC RID: 30380 RVA: 0x00249852 File Offset: 0x00247A52
	public void SetActivityPermanentFilterId(int value)
	{
		this.ActivityPermanentFilterId = value;
	}

	// Token: 0x060076AD RID: 30381 RVA: 0x0024985C File Offset: 0x00247A5C
	public void SendActivityViewOpenLogData(EActivityViewOpenType openType)
	{
		ActivityViewOpenLogData activityViewOpenLogData = new ActivityViewOpenLogData();
		activityViewOpenLogData.i_open_way = (int)openType;
		LogReportController.Instance.LogReport(activityViewOpenLogData);
	}

	// Token: 0x060076AE RID: 30382 RVA: 0x00249884 File Offset: 0x00247A84
	public void SendActivityTabViewOpenLogData(ActivityBaseData openData)
	{
		ActivityTabViewOpenLogData activityTabViewOpenLogData = new ActivityTabViewOpenLogData();
		double serverTime = TimeUtil.Instance.GetServerTime();
		double a = (openData.EndOpenTime == 0L) ? 0.0 : ((double)((int)openData.EndOpenTime) - serverTime);
		activityTabViewOpenLogData.i_activity_id = openData.Id;
		activityTabViewOpenLogData.i_activity_type = (int)openData.Type;
		activityTabViewOpenLogData.i_time_left = (int)Math.Round(a);
		activityTabViewOpenLogData.i_unlock = ((openData.IsUnLock() > false) ? 1 : 0);
		if (openData.TimeType == EActivityTimeType.Permanent)
		{
			activityTabViewOpenLogData.i_type = 3;
		}
		else
		{
			Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(openData.Id);
			if (activityConfig != null && activityConfig.GetValueOrDefault().FilterTabType == 1)
			{
				activityTabViewOpenLogData.i_type = 1;
			}
			else if (activityConfig != null && activityConfig.GetValueOrDefault().FilterTabType == 3)
			{
				activityTabViewOpenLogData.i_type = 2;
			}
		}
		if (activityTabViewOpenLogData.i_type == 0)
		{
			Log.Instance.Warn(ELogModule.Activity, ELogAuthor.LZK, "[活动埋点] 活动类型未定义，埋点记录为0. 活动Id: " + openData.Id.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		LogReportController.Instance.LogReport(activityTabViewOpenLogData);
	}

	// Token: 0x060076AF RID: 30383 RVA: 0x002499B0 File Offset: 0x00247BB0
	public ActivityViewJumpClickLogData GetDefaultActivityViewJumpClickLogData(ActivityBaseData openData)
	{
		ActivityViewJumpClickLogData activityViewJumpClickLogData = new ActivityViewJumpClickLogData();
		activityViewJumpClickLogData.i_activity_id = openData.Id;
		activityViewJumpClickLogData.i_activity_type = (int)openData.Type;
		switch (openData.GetActivityOpenStatus())
		{
		case EActivityOpenStatus.Unlocked:
			activityViewJumpClickLogData.i_unlock = 1;
			activityViewJumpClickLogData.i_scene = 3;
			break;
		case EActivityOpenStatus.PreGuideQuestPending:
			activityViewJumpClickLogData.i_unlock = 1;
			activityViewJumpClickLogData.i_scene = 2;
			break;
		case EActivityOpenStatus.CanPreOpen:
			activityViewJumpClickLogData.i_unlock = 3;
			activityViewJumpClickLogData.i_scene = 1;
			break;
		case EActivityOpenStatus.Locked:
			activityViewJumpClickLogData.i_unlock = 2;
			activityViewJumpClickLogData.i_scene = 3;
			break;
		}
		return activityViewJumpClickLogData;
	}

	// Token: 0x060076B0 RID: 30384 RVA: 0x00249A3C File Offset: 0x00247C3C
	public void SendActivityViewJumpClickLogData(ActivityBaseData openData)
	{
		ActivityViewJumpClickLogData defaultActivityViewJumpClickLogData = this.GetDefaultActivityViewJumpClickLogData(openData);
		LogReportController.Instance.LogReport(defaultActivityViewJumpClickLogData);
	}

	// Token: 0x060076B1 RID: 30385 RVA: 0x00249A5C File Offset: 0x00247C5C
	public void SendActivityViewJumpClickLogData(ActivityViewJumpClickLogData logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x060076B2 RID: 30386 RVA: 0x00249A6C File Offset: 0x00247C6C
	public void SendActivityLockConditionLogData(ActivityBaseData openData)
	{
		ActivityLockConditionClickLogData activityLockConditionClickLogData = new ActivityLockConditionClickLogData();
		activityLockConditionClickLogData.i_activity_id = openData.Id;
		activityLockConditionClickLogData.i_activity_type = (int)openData.Type;
		LogReportController.Instance.LogReport(activityLockConditionClickLogData);
	}

	// Token: 0x060076B3 RID: 30387 RVA: 0x00249AA4 File Offset: 0x00247CA4
	public void SendActivityFinishSinkLogData(ActivityBaseData activityData)
	{
		ActivityFinishSinkLogData activityFinishSinkLogData = new ActivityFinishSinkLogData();
		activityFinishSinkLogData.i_activity_id = activityData.Id;
		LogReportController.Instance.LogReport(activityFinishSinkLogData);
	}

	// Token: 0x060076B4 RID: 30388 RVA: 0x00249AD0 File Offset: 0x00247CD0
	public void SendActivityGotoClickLogData(int activityId, int type, int scene)
	{
		ActivityGotoClickLogData activityGotoClickLogData = new ActivityGotoClickLogData();
		activityGotoClickLogData.i_activity_id = activityId;
		activityGotoClickLogData.i_type = type;
		activityGotoClickLogData.i_scene = scene;
		LogReportController.Instance.LogReport(activityGotoClickLogData);
	}

	// Token: 0x060076B5 RID: 30389 RVA: 0x00249B04 File Offset: 0x00247D04
	private void InitActivityLevelFuncMap()
	{
		IActivityLevelFunc value = new IActivityLevelFunc
		{
			CheckIsActivityLevel = new Func<int, bool>(ActivityMowingController.Instance.CheckIsActivityLevel),
			GetLevelRecommendLevel = new Func<int, int, int>(ActivityMowingController.Instance.GetRecommendLevel)
		};
		this.ActivityLevelFuncMap[9] = value;
	}

	// Token: 0x060076B6 RID: 30390 RVA: 0x00249B54 File Offset: 0x00247D54
	public bool GetActivityLevelUnlockState(int type, int levelId)
	{
		IActivityControllerBase activityController = ActivityManager.GetActivityController(type);
		return activityController == null || activityController.GetActivityLevelUnlockState(levelId);
	}

	// Token: 0x060076B7 RID: 30391 RVA: 0x00249B74 File Offset: 0x00247D74
	public int GetActivityLevelRecommendLevel(int instanceId, int worldLevel, int activityType)
	{
		IActivityLevelFunc activityLevelFunc;
		if (this.ActivityLevelFuncMap.TryGetValue(activityType, out activityLevelFunc))
		{
			return activityLevelFunc.GetLevelRecommendLevel(instanceId, worldLevel);
		}
		return 0;
	}

	// Token: 0x060076B8 RID: 30392 RVA: 0x00249BA0 File Offset: 0x00247DA0
	[NullableContext(0)]
	public ValueTuple<bool, int> CheckActivityLevelBelongToType(int instanceId)
	{
		foreach (KeyValuePair<int, IActivityLevelFunc> keyValuePair in this.ActivityLevelFuncMap)
		{
			int key = keyValuePair.Key;
			bool flag = keyValuePair.Value.CheckIsActivityLevel(instanceId);
			if (flag)
			{
				return new ValueTuple<bool, int>(flag, key);
			}
		}
		return new ValueTuple<bool, int>(false, 0);
	}

	// Token: 0x060076B9 RID: 30393 RVA: 0x00249C20 File Offset: 0x00247E20
	public bool GetActivityMapMarkState(int type, int markId)
	{
		IActivityControllerBase activityController = ActivityManager.GetActivityController(type);
		return activityController != null && activityController.GetActivityMapMarkState(markId);
	}

	// Token: 0x060076BA RID: 30394 RVA: 0x00249C40 File Offset: 0x00247E40
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, string, long> GetTimeVisibleAndRemainTime(ActivityBaseData activityData, [Nullable(2)] string formationTimeText = null)
	{
		bool flag = activityData.CheckIfInShowTime();
		bool flag2 = activityData.CheckIfInOpenTime();
		if (!flag2 && !flag)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("ActiveClose"), null);
			return new ValueTuple<bool, string, long>(false, localTextNew, -1L);
		}
		long endOpenTime = activityData.EndOpenTime;
		long endShowTime = activityData.EndShowTime;
		long endLimitTime = activityData.EndLimitTime;
		string text = "";
		bool flag3 = true;
		long num = 0L;
		Activity? localConfig = activityData.LocalConfig;
		int num2 = (localConfig != null) ? localConfig.Value.TimeIsDisplay : 0;
		if (localConfig != null && localConfig.GetValueOrDefault().OpenType == 2)
		{
			bool flag4 = activityData.CheckIfInLimitTime();
			flag3 = (flag && flag4);
			if (flag3)
			{
				if (num2 == 1)
				{
					num = 0L;
					text = this.ActivityForeverTimeText;
				}
				else if (num2 == 0)
				{
					num = endLimitTime;
					text = this.ActivityRemainingTimeReward;
				}
			}
		}
		else if (localConfig != null && localConfig.GetValueOrDefault().OpenType == 1)
		{
			flag3 = (num2 == 1);
			text = this.ActivityForeverTimeText;
		}
		else if (localConfig != null && localConfig.GetValueOrDefault().OpenType == 0)
		{
			if (endOpenTime != 0L && endShowTime != 0L)
			{
				flag3 = true;
				num = (flag2 ? endOpenTime : endShowTime);
				text = (flag2 ? this.ActivityRemainTimeText : this.ActivityCdTimeText);
			}
			if (endOpenTime == 0L && endShowTime != 0L)
			{
				flag3 = true;
				num = endShowTime;
				text = this.ActivityCdTimeText;
			}
			if (endOpenTime == 0L && endShowTime == 0L)
			{
				flag3 = (num2 == 1);
				text = this.ActivityForeverTimeText;
			}
		}
		if (flag3 && num > 0L)
		{
			text = (this.GetRemainTimeText(num, formationTimeText ?? text) ?? "");
		}
		return new ValueTuple<bool, string, long>(flag3, text, num);
	}

	// Token: 0x060076BB RID: 30395 RVA: 0x00249E04 File Offset: 0x00248004
	public string GetRemainTimeText(long endTime, string text)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)endTime - serverTime, 1.0);
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> timeTypeData = this.GetTimeTypeData((long)num);
		string text2 = TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(timeTypeData.Item1), new CommonDefine.ETimeType?(timeTypeData.Item2)).CountDownText ?? "";
		return StringUtils.Format(text, new string[]
		{
			text2
		});
	}

	// Token: 0x060076BC RID: 30396 RVA: 0x00249E78 File Offset: 0x00248078
	[NullableContext(0)]
	private ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> GetTimeTypeData(long remainTime)
	{
		if (remainTime > 86400L)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
		}
		if (remainTime > 3600L)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Minute);
		}
		if (remainTime > 60L)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Second);
		}
		return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
	}

	// Token: 0x060076BD RID: 30397 RVA: 0x00249EB4 File Offset: 0x002480B4
	public List<IActivityConditionData> GetActivityConditionData(ActivityBaseData activityData)
	{
		List<IActivityConditionData> list = new List<IActivityConditionData>();
		int conditionGroupId;
		if (activityData.HasPreOpenCondition())
		{
			conditionGroupId = activityData.PreOpenConditionGroupId;
		}
		else
		{
			conditionGroupId = activityData.ConditionGroupId;
		}
		foreach (int conditionId in ConditionConfig.Instance.GetGroupConditionIds(conditionGroupId))
		{
			Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
			int accessType = -1;
			if (conditionConfig.Value.AccessId != 0)
			{
				accessType = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId).Value.SkipName;
			}
			ActivityConditionData item = new ActivityConditionData
			{
				ConditionId = conditionId,
				ConditionTextId = conditionConfig.Value.Description,
				IsFinished = activityData.IsActivityConditionFinished(conditionId),
				AccessId = conditionConfig.Value.AccessId,
				AccessType = accessType
			};
			list.Add(item);
		}
		list.Sort(new Comparison<IActivityConditionData>(this.SortConditionData));
		return list;
	}

	// Token: 0x060076BE RID: 30398 RVA: 0x00249FC4 File Offset: 0x002481C4
	private int SortConditionData(IActivityConditionData a, IActivityConditionData b)
	{
		int num = (a.IsFinished > false) ? 1 : 0;
		int num2 = (b.IsFinished > false) ? 1 : 0;
		if (num != num2)
		{
			return num - num2;
		}
		int[] array = new int[]
		{
			a.AccessType,
			b.AccessType
		};
		int[] array2 = new int[2];
		for (int i = 0; i < array.Length; i++)
		{
			int num3 = 2;
			int num4 = array[i];
			if (num4 != 7)
			{
				if (num4 == 16)
				{
					num3 = 1;
				}
			}
			else
			{
				num3 = 0;
			}
			array2[i] = num3;
		}
		return array2[0] - array2[1];
	}

	// Token: 0x060076BF RID: 30399 RVA: 0x0024A04A File Offset: 0x0024824A
	public bool CheckBubbleHasClicked(int activityId, EActivityBubbleType bubbleType)
	{
		return this.GetActivityCacheData(activityId, 0, 1011, (int)bubbleType, 0) == 1;
	}

	// Token: 0x060076C0 RID: 30400 RVA: 0x0024A05E File Offset: 0x0024825E
	public void SetBubbleHasClicked(int activityId, EActivityBubbleType bubbleType)
	{
		this.SaveActivityData(activityId, 1011, (int)bubbleType, 0, 1);
	}

	// Token: 0x060076C1 RID: 30401 RVA: 0x0024A06F File Offset: 0x0024826F
	[NullableContext(2)]
	private bool IsInTimeInterval(int[] interval, int numberDay)
	{
		return interval != null && interval.Length >= 1 && numberDay >= interval[0] && numberDay < interval[1];
	}

	// Token: 0x060076C2 RID: 30402 RVA: 0x0024A088 File Offset: 0x00248288
	public EActivityBubbleType GetBubbleTypeByTimeInterval(ActivityTimeShow timeShowConfig, int numberDay)
	{
		if (this.IsInTimeInterval(timeShowConfig.WhiteInterval(), numberDay))
		{
			return EActivityBubbleType.Normal;
		}
		if (this.IsInTimeInterval(timeShowConfig.YellowInterval(), numberDay))
		{
			return EActivityBubbleType.Remind;
		}
		if (this.IsInTimeInterval(timeShowConfig.RedInterval(), numberDay))
		{
			return EActivityBubbleType.Important;
		}
		return EActivityBubbleType.None;
	}

	// Token: 0x060076C3 RID: 30403 RVA: 0x0024A0C1 File Offset: 0x002482C1
	public void SetForceHideActivityTimeTextFlag(bool bVisible)
	{
		this.ForceHideActivityTimeTextFlag = bVisible;
	}

	// Token: 0x060076C4 RID: 30404 RVA: 0x0024A0CA File Offset: 0x002482CA
	public bool GetForceHideActivityTimeTextFlag()
	{
		return false;
	}

	// Token: 0x060076C5 RID: 30405 RVA: 0x0024A0D0 File Offset: 0x002482D0
	[NullableContext(2)]
	public void SetDebugFilterMode(bool bFilterOn, List<int> filterActivityIdList = null)
	{
		this.DebugFilterMode = bFilterOn;
		if (filterActivityIdList != null)
		{
			this.DebugFilterShowActivityIds = filterActivityIdList;
		}
		foreach (ActivityBaseData activityBaseData in this.CurrentShowingActivitiesMap.Values)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
		}
	}

	// Token: 0x060076C6 RID: 30406 RVA: 0x0024A148 File Offset: 0x00248348
	public void OpenActivityErrorConfirmBox(int activityId, int type)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
		string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("ActivityErrorTips", null) ?? "", new string[]
		{
			activityId.ToString(),
			type.ToString()
		});
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			text
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060076C7 RID: 30407 RVA: 0x0024A1AD File Offset: 0x002483AD
	public void SetDebugPermanentFilterVisible(bool bFilterOn)
	{
		this.DebugPermanentFilterVisible = bFilterOn;
	}

	// Token: 0x060076C8 RID: 30408 RVA: 0x0024A1B6 File Offset: 0x002483B6
	public bool GetDebugPermanentFilterVisible()
	{
		return this.DebugPermanentFilterVisible;
	}

	// Token: 0x17000DE4 RID: 3556
	// (get) Token: 0x060076C9 RID: 30409 RVA: 0x0024A1BE File Offset: 0x002483BE
	public static ActivityModel Instance
	{
		get
		{
			return ActivityModel._Instance;
		}
	}

	// Token: 0x060076CA RID: 30410 RVA: 0x0024A1C5 File Offset: 0x002483C5
	public static ActivityModel GetOrCreateInstance()
	{
		if (ActivityModel._Instance == null)
		{
			ActivityModel.CreateInstance();
		}
		return ActivityModel._Instance;
	}

	// Token: 0x060076CB RID: 30411 RVA: 0x0024A1D9 File Offset: 0x002483D9
	public static bool CreateInstance()
	{
		if (ActivityModel._Instance != null)
		{
			return true;
		}
		ActivityModel._Instance = new ActivityModel();
		return true;
	}

	// Token: 0x060076CC RID: 30412 RVA: 0x0024A1EF File Offset: 0x002483EF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060076CD RID: 30413 RVA: 0x0024A1F1 File Offset: 0x002483F1
	public static void ResetStaticDefaultValue()
	{
		ActivityModel._Instance = null;
	}

	// Token: 0x060076CE RID: 30414 RVA: 0x0024A1F9 File Offset: 0x002483F9
	static ActivityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityModel.CreateStaticDefaultValue), new Action(ActivityModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004AAC RID: 19116
	private const int ActivityRequestRandomDelaySeconds = 10;

	// Token: 0x04004AAD RID: 19117
	private readonly Dictionary<int, ActivityBaseData> ActivityMap = new Dictionary<int, ActivityBaseData>();

	// Token: 0x04004AAE RID: 19118
	private readonly List<int> CurrentActivityIds = new List<int>();

	// Token: 0x04004AAF RID: 19119
	private readonly ActivityCache ActivityCache = new ActivityCache();

	// Token: 0x04004AB0 RID: 19120
	private readonly HashSet<long> ActivityTimeStampSet = new HashSet<long>();

	// Token: 0x04004AB1 RID: 19121
	private readonly Dictionary<long, TimerHandle> ActivityTimeStampHandleMap = new Dictionary<long, TimerHandle>();

	// Token: 0x04004AB2 RID: 19122
	private string ActivityForeverTimeText = "";

	// Token: 0x04004AB3 RID: 19123
	private string ActivityCloseText = "";

	// Token: 0x04004AB4 RID: 19124
	private string ActivityCdTimeText = "";

	// Token: 0x04004AB5 RID: 19125
	private string ActivityRemainTimeText = "";

	// Token: 0x04004AB6 RID: 19126
	private string ActivityRemainingTimeReward = "";

	// Token: 0x04004AB7 RID: 19127
	private int ActivityPermanentFilterId = 999;

	// Token: 0x04004AB8 RID: 19128
	private bool DebugPermanentFilterVisible;

	// Token: 0x04004AB9 RID: 19129
	private readonly Dictionary<int, ActivityBaseData> CurrentShowingActivitiesMap = new Dictionary<int, ActivityBaseData>();

	// Token: 0x04004ABA RID: 19130
	private readonly HashSet<int> CurrentRemoveActivities = new HashSet<int>();

	// Token: 0x04004ABB RID: 19131
	private readonly HashSet<int> CurrentAddActivities = new HashSet<int>();

	// Token: 0x04004ABC RID: 19132
	private readonly Dictionary<int, IActivityLevelFunc> ActivityLevelFuncMap = new Dictionary<int, IActivityLevelFunc>();

	// Token: 0x04004ABD RID: 19133
	private bool ForceHideActivityTimeTextFlag;

	// Token: 0x04004ABE RID: 19134
	private bool DebugFilterMode;

	// Token: 0x04004ABF RID: 19135
	private List<int> DebugFilterShowActivityIds = new List<int>();

	// Token: 0x04004AC0 RID: 19136
	[Nullable(2)]
	private static ActivityModel _Instance;

	// Token: 0x02006DC7 RID: 28103
	[CompilerGenerated]
	private static class <SortActivityList>O__51_0<T> where T : ActivityBaseData
	{
		// Token: 0x04023F8A RID: 147338
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<T> <0>__SortFunc;
	}
}
