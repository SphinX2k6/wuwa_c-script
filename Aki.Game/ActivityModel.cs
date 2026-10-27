using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;

// Token: 0x0200167E RID: 5758
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityModel : ModelBase
{
	// Token: 0x0600A2A7 RID: 41639 RVA: 0x0023E5C4 File Offset: 0x0023C7C4
	protected override bool OnInit()
	{
		this.InitActivityLevelFuncMap();
		this.InitLangText();
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
		return true;
	}

	// Token: 0x0600A2A8 RID: 41640 RVA: 0x0023E5F0 File Offset: 0x0023C7F0
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

	// Token: 0x0600A2A9 RID: 41641 RVA: 0x0023E6C4 File Offset: 0x0023C8C4
	public void InitCache()
	{
		this.ActivityCache.InitData();
	}

	// Token: 0x0600A2AA RID: 41642 RVA: 0x0023E6D4 File Offset: 0x0023C8D4
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

	// Token: 0x0600A2AB RID: 41643 RVA: 0x0023E783 File Offset: 0x0023C983
	protected void OnLanguageChange(string s, string s1)
	{
		this.ActivityForeverTimeText = "";
		this.ActivityCloseText = "";
		this.ActivityCdTimeText = "";
		this.ActivityRemainTimeText = "";
		this.ActivityRemainingTimeReward = "";
		this.InitLangText();
	}

	// Token: 0x0600A2AC RID: 41644 RVA: 0x0023E7C4 File Offset: 0x0023C9C4
	public unsafe void OnReceiveMessageData(ActivityData[] data)
	{
		foreach (KeyValuePair<int, ActivityBaseData> keyValuePair in this.ActivityMap)
		{
			keyValuePair.Value.ForceClose();
		}
		ActivityData[] array = data;
		int i = 0;
		while (i < array.Length)
		{
			ActivityData activityData = array[i];
			if (ActivityManager.GetActivityController(activityData.Type) != null)
			{
				try
				{
					ActivityBaseData orCreateActivity = this.GetOrCreateActivity(activityData);
					if (orCreateActivity != null)
					{
						orCreateActivity.Phrase(activityData);
					}
					goto IL_12F;
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
					goto IL_12F;
				}
				goto IL_FA;
			}
			goto IL_FA;
			IL_12F:
			i++;
			continue;
			IL_FA:
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Activity;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "尚未实现活动";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", activityData.Type);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			goto IL_12F;
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

	// Token: 0x0600A2AD RID: 41645 RVA: 0x0023EA0C File Offset: 0x0023CC0C
	public void OnReceiveActivityRead(int activityId)
	{
		ActivityBaseData activityBaseData;
		if (this.ActivityMap.TryGetValue(activityId, out activityBaseData))
		{
			activityBaseData.SetFirstOpenFalse();
		}
	}

	// Token: 0x0600A2AE RID: 41646 RVA: 0x0023EA30 File Offset: 0x0023CC30
	public unsafe void OnActivityUpdate(ActivityData[] data)
	{
		ActivityData[] array = data;
		int i = 0;
		while (i < array.Length)
		{
			ActivityData activityData = array[i];
			if (ActivityManager.GetActivityController(activityData.Type) != null)
			{
				try
				{
					ActivityBaseData orCreateActivity = this.GetOrCreateActivity(activityData);
					if (orCreateActivity != null)
					{
						orCreateActivity.Phrase(activityData);
					}
					goto IL_132;
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
					goto IL_132;
				}
				goto IL_FD;
			}
			goto IL_FD;
			IL_132:
			i++;
			continue;
			IL_FD:
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Activity;
			ELogAuthor author3 = ELogAuthor.YZY;
			string message3 = "尚未实现活动";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("type", activityData.Type);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			goto IL_132;
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

	// Token: 0x0600A2AF RID: 41647 RVA: 0x0023EC6C File Offset: 0x0023CE6C
	public void OnDisableActivity(int[] ids)
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

	// Token: 0x0600A2B0 RID: 41648 RVA: 0x0023ECC0 File Offset: 0x0023CEC0
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

	// Token: 0x0600A2B1 RID: 41649 RVA: 0x0023EE28 File Offset: 0x0023D028
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
		long num = checkTime * (long)TimeUtil.Instance.InverseMillisecond + 20L;
		string reason = StringUtils.Format("活动开启关闭时间倒计时 [ActivityId:{0}, IsOpen:{1}]", new string[]
		{
			activityId.ToString(),
			isOpen.ToString()
		});
		TimerHandle timerHandle = TimerSystem.RealTimeInstance.EmitOnTime(delegate(float _)
		{
			this.ActivityTimeStampCheck(checkTime);
		}, (double)num, null, reason, true, 1f);
		if (timerHandle == null)
		{
			return;
		}
		this.ActivityTimeStampSet.Add(checkTime);
		this.ActivityTimeStampHandleMap[checkTime] = timerHandle;
	}

	// Token: 0x0600A2B2 RID: 41650 RVA: 0x0023EEF8 File Offset: 0x0023D0F8
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

	// Token: 0x0600A2B3 RID: 41651 RVA: 0x0023EF65 File Offset: 0x0023D165
	public bool GetIfFunctionOpen()
	{
		return FunctionModel.Instance.IsOpen(10053);
	}

	// Token: 0x0600A2B4 RID: 41652 RVA: 0x0023EF78 File Offset: 0x0023D178
	private bool ShouldDefaultToNewbieTab()
	{
		ActivitySevenDaySignData newcomerSignInActivityData = this.GetNewcomerSignInActivityData();
		return newcomerSignInActivityData != null && !newcomerSignInActivityData.IsAllSignRewardReceived();
	}

	// Token: 0x0600A2B5 RID: 41653 RVA: 0x0023EF9C File Offset: 0x0023D19C
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

	// Token: 0x0600A2B6 RID: 41654 RVA: 0x0023F044 File Offset: 0x0023D244
	private int? FindTabIdByFilterTabType(IActivityCategoryTabData[] tabDataList, int filterTabType)
	{
		Func<ActivityBaseData, bool> <>9__0;
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
					Func<ActivityBaseData, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((ActivityBaseData activity) => activity.LocalConfig != null && activity.LocalConfig.GetValueOrDefault().FilterTabType == filterTabType));
					}
					flag = activities.Any(predicate);
				}
				if (flag)
				{
					return activityCategoryTabData.Id;
				}
			}
		}
		return null;
	}

	// Token: 0x0600A2B7 RID: 41655 RVA: 0x0023F0D4 File Offset: 0x0023D2D4
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

	// Token: 0x0600A2B8 RID: 41656 RVA: 0x0023F147 File Offset: 0x0023D347
	public bool GetIfShowActivity()
	{
		return this.GetIfFunctionOpen();
	}

	// Token: 0x0600A2B9 RID: 41657 RVA: 0x0023F154 File Offset: 0x0023D354
	public Dictionary<int, ActivityBaseData> GetAllActivityMap()
	{
		return this.ActivityMap;
	}

	// Token: 0x0600A2BA RID: 41658 RVA: 0x0023F15C File Offset: 0x0023D35C
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

	// Token: 0x0600A2BB RID: 41659 RVA: 0x0023F17C File Offset: 0x0023D37C
	public bool IsActivityOpen(int id)
	{
		ActivityBaseData activityBaseData;
		return this.ActivityMap.TryGetValue(id, out activityBaseData) && activityBaseData.CheckIfInShowTime();
	}

	// Token: 0x0600A2BC RID: 41660 RVA: 0x0023F1A4 File Offset: 0x0023D3A4
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

	// Token: 0x0600A2BD RID: 41661 RVA: 0x0023F214 File Offset: 0x0023D414
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

	// Token: 0x0600A2BE RID: 41662 RVA: 0x0023F27C File Offset: 0x0023D47C
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

	// Token: 0x0600A2BF RID: 41663 RVA: 0x0023F2E4 File Offset: 0x0023D4E4
	public List<ActivityBaseData> GetCurrentShowingActivities()
	{
		List<ActivityBaseData> list = new List<ActivityBaseData>(this.CurrentShowingActivitiesMap.Values);
		list = (from data in list
		where !data.IsHiddenByConfig()
		select data).ToList<ActivityBaseData>();
		foreach (ActivityBaseData activityBaseData in list)
		{
			activityBaseData.UpdateImportantBubble();
		}
		ActivityModel.SortActivityList<ActivityBaseData>(list);
		return list;
	}

	// Token: 0x0600A2C0 RID: 41664 RVA: 0x0023F374 File Offset: 0x0023D574
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

	// Token: 0x0600A2C1 RID: 41665 RVA: 0x0023F3EC File Offset: 0x0023D5EC
	private List<ActivityBaseData> GetDebugFilterActivityDataList()
	{
		List<ActivityBaseData> source = new List<ActivityBaseData>(this.CurrentShowingActivitiesMap.Values);
		if (this.DebugFilterMode)
		{
			source = (from data in source
			where this.DebugFilterShowActivityIds.Contains(data.Id)
			select data).ToList<ActivityBaseData>();
		}
		return (from data in source
		where !data.IsHiddenByConfig()
		select data).ToList<ActivityBaseData>();
	}

	// Token: 0x0600A2C2 RID: 41666 RVA: 0x0023F456 File Offset: 0x0023D656
	public bool HaveShowingActivity()
	{
		return this.GetCurrentShowingActivities().Count > 0;
	}

	// Token: 0x0600A2C3 RID: 41667 RVA: 0x0023F468 File Offset: 0x0023D668
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

	// Token: 0x0600A2C4 RID: 41668 RVA: 0x0023F4E0 File Offset: 0x0023D6E0
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

	// Token: 0x0600A2C5 RID: 41669 RVA: 0x0023F640 File Offset: 0x0023D840
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

	// Token: 0x0600A2C6 RID: 41670 RVA: 0x0023F6E4 File Offset: 0x0023D8E4
	public void SaveActivityData(int activityId, int key1, int key2, int key3, int value)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		this.ActivityCache.SaveCacheData(activityById, key1, key2, key3, value);
	}

	// Token: 0x0600A2C7 RID: 41671 RVA: 0x0023F70C File Offset: 0x0023D90C
	public int GetActivityCacheData(int activityId, int defaultValue, int key1, int key2, int key3)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		return this.ActivityCache.GetCacheData(activityById, defaultValue, key1, key2, key3);
	}

	// Token: 0x0600A2C8 RID: 41672 RVA: 0x0023F734 File Offset: 0x0023D934
	public void SaveActivityDataByKey(int activityId, int key, int value)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		this.ActivityCache.SaveCacheDataByKey(activityById, key, value);
	}

	// Token: 0x0600A2C9 RID: 41673 RVA: 0x0023F758 File Offset: 0x0023D958
	public int GetActivityCacheDataByKey(int activityId, int defaultValue, int key)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		return this.ActivityCache.GetCacheDataByKey(activityById, defaultValue, key);
	}

	// Token: 0x0600A2CA RID: 41674 RVA: 0x0023F77C File Offset: 0x0023D97C
	public static void SortActivityList<[Nullable(0)] T>(List<T> activityDataList) where T : ActivityBaseData
	{
		foreach (T t in activityDataList)
		{
			t.CacheSortSinkState();
		}
		Comparison<T> comparison;
		if ((comparison = ActivityModel.<SortActivityList>O__50_0<T>.<0>__SortFunc) == null)
		{
			comparison = (ActivityModel.<SortActivityList>O__50_0<T>.<0>__SortFunc = new Comparison<T>(ActivityModel.SortFunc));
		}
		activityDataList.Sort(comparison);
	}

	// Token: 0x0600A2CB RID: 41675 RVA: 0x0023F7F0 File Offset: 0x0023D9F0
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

	// Token: 0x0600A2CC RID: 41676 RVA: 0x0023F8AE File Offset: 0x0023DAAE
	public bool GetActivityRedDotState(int activityId)
	{
		ActivityBaseData activityById = this.GetActivityById(activityId);
		return activityById != null && activityById.RedPointShowState;
	}

	// Token: 0x0600A2CD RID: 41677 RVA: 0x0023F8C2 File Offset: 0x0023DAC2
	public int GetActivityPermanentFilterId()
	{
		return this.ActivityPermanentFilterId;
	}

	// Token: 0x0600A2CE RID: 41678 RVA: 0x0023F8CA File Offset: 0x0023DACA
	public void SetActivityPermanentFilterId(int value)
	{
		this.ActivityPermanentFilterId = value;
	}

	// Token: 0x0600A2CF RID: 41679 RVA: 0x0023F8D4 File Offset: 0x0023DAD4
	public void SendActivityViewOpenLogData(EActivityViewOpenType openType)
	{
		ActivityViewOpenLogData activityViewOpenLogData = new ActivityViewOpenLogData();
		activityViewOpenLogData.i_open_way = (int)openType;
		LogReportController.Instance.LogReport(activityViewOpenLogData);
	}

	// Token: 0x0600A2D0 RID: 41680 RVA: 0x0023F8FC File Offset: 0x0023DAFC
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

	// Token: 0x0600A2D1 RID: 41681 RVA: 0x0023FA28 File Offset: 0x0023DC28
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

	// Token: 0x0600A2D2 RID: 41682 RVA: 0x0023FAB4 File Offset: 0x0023DCB4
	public void SendActivityViewJumpClickLogData(ActivityBaseData openData)
	{
		ActivityViewJumpClickLogData defaultActivityViewJumpClickLogData = this.GetDefaultActivityViewJumpClickLogData(openData);
		LogReportController.Instance.LogReport(defaultActivityViewJumpClickLogData);
	}

	// Token: 0x0600A2D3 RID: 41683 RVA: 0x0023FAD4 File Offset: 0x0023DCD4
	public void SendActivityViewJumpClickLogData(ActivityViewJumpClickLogData logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0600A2D4 RID: 41684 RVA: 0x0023FAE4 File Offset: 0x0023DCE4
	public void SendActivityLockConditionLogData(ActivityBaseData openData)
	{
		ActivityLockConditionClickLogData activityLockConditionClickLogData = new ActivityLockConditionClickLogData();
		activityLockConditionClickLogData.i_activity_id = openData.Id;
		activityLockConditionClickLogData.i_activity_type = (int)openData.Type;
		LogReportController.Instance.LogReport(activityLockConditionClickLogData);
	}

	// Token: 0x0600A2D5 RID: 41685 RVA: 0x0023FB1C File Offset: 0x0023DD1C
	public void SendActivityFinishSinkLogData(ActivityBaseData activityData)
	{
		ActivityFinishSinkLogData activityFinishSinkLogData = new ActivityFinishSinkLogData();
		activityFinishSinkLogData.i_activity_id = activityData.Id;
		LogReportController.Instance.LogReport(activityFinishSinkLogData);
	}

	// Token: 0x0600A2D6 RID: 41686 RVA: 0x0023FB48 File Offset: 0x0023DD48
	public void SendActivityGotoClickLogData(int activityId, int type, int scene)
	{
		ActivityGotoClickLogData activityGotoClickLogData = new ActivityGotoClickLogData();
		activityGotoClickLogData.i_activity_id = activityId;
		activityGotoClickLogData.i_type = type;
		activityGotoClickLogData.i_scene = scene;
		LogReportController.Instance.LogReport(activityGotoClickLogData);
	}

	// Token: 0x0600A2D7 RID: 41687 RVA: 0x0023FB7C File Offset: 0x0023DD7C
	private void InitActivityLevelFuncMap()
	{
		IActivityLevelFunc value = new IActivityLevelFunc
		{
			CheckIsActivityLevel = new Func<int, bool>(ActivityMowingController.Instance.CheckIsActivityLevel),
			GetLevelRecommendLevel = new Func<int, int, int>(ActivityMowingController.Instance.GetRecommendLevel)
		};
		this.ActivityLevelFuncMap[9] = value;
	}

	// Token: 0x0600A2D8 RID: 41688 RVA: 0x0023FBCC File Offset: 0x0023DDCC
	public bool GetActivityLevelUnlockState(int type, int levelId)
	{
		IActivityControllerBase activityController = ActivityManager.GetActivityController(type);
		return activityController == null || activityController.GetActivityLevelUnlockState(levelId);
	}

	// Token: 0x0600A2D9 RID: 41689 RVA: 0x0023FBEC File Offset: 0x0023DDEC
	public int GetActivityLevelRecommendLevel(int instanceId, int worldLevel, int activityType)
	{
		IActivityLevelFunc activityLevelFunc;
		if (this.ActivityLevelFuncMap.TryGetValue(activityType, out activityLevelFunc))
		{
			return activityLevelFunc.GetLevelRecommendLevel(instanceId, worldLevel);
		}
		return 0;
	}

	// Token: 0x0600A2DA RID: 41690 RVA: 0x0023FC18 File Offset: 0x0023DE18
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

	// Token: 0x0600A2DB RID: 41691 RVA: 0x0023FC98 File Offset: 0x0023DE98
	public bool GetActivityMapMarkState(int type, int markId)
	{
		IActivityControllerBase activityController = ActivityManager.GetActivityController(type);
		return activityController != null && activityController.GetActivityMapMarkState(markId);
	}

	// Token: 0x0600A2DC RID: 41692 RVA: 0x0023FCB8 File Offset: 0x0023DEB8
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

	// Token: 0x0600A2DD RID: 41693 RVA: 0x0023FE7C File Offset: 0x0023E07C
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

	// Token: 0x0600A2DE RID: 41694 RVA: 0x0023FEF0 File Offset: 0x0023E0F0
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

	// Token: 0x0600A2DF RID: 41695 RVA: 0x0023FF2C File Offset: 0x0023E12C
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

	// Token: 0x0600A2E0 RID: 41696 RVA: 0x0024003C File Offset: 0x0023E23C
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

	// Token: 0x0600A2E1 RID: 41697 RVA: 0x002400C2 File Offset: 0x0023E2C2
	public bool CheckBubbleHasClicked(int activityId, EActivityBubbleType bubbleType)
	{
		return this.GetActivityCacheData(activityId, 0, 1011, (int)bubbleType, 0) == 1;
	}

	// Token: 0x0600A2E2 RID: 41698 RVA: 0x002400D6 File Offset: 0x0023E2D6
	public void SetBubbleHasClicked(int activityId, EActivityBubbleType bubbleType)
	{
		this.SaveActivityData(activityId, 1011, (int)bubbleType, 0, 1);
	}

	// Token: 0x0600A2E3 RID: 41699 RVA: 0x002400E7 File Offset: 0x0023E2E7
	[NullableContext(2)]
	private bool IsInTimeInterval(int[] interval, int numberDay)
	{
		return interval != null && interval.Length >= 1 && numberDay >= interval[0] && numberDay < interval[1];
	}

	// Token: 0x0600A2E4 RID: 41700 RVA: 0x00240100 File Offset: 0x0023E300
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

	// Token: 0x0600A2E5 RID: 41701 RVA: 0x00240139 File Offset: 0x0023E339
	public void SetForceHideActivityTimeTextFlag(bool bVisible)
	{
		this.ForceHideActivityTimeTextFlag = bVisible;
	}

	// Token: 0x0600A2E6 RID: 41702 RVA: 0x00240142 File Offset: 0x0023E342
	public bool GetForceHideActivityTimeTextFlag()
	{
		return false;
	}

	// Token: 0x0600A2E7 RID: 41703 RVA: 0x00240148 File Offset: 0x0023E348
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

	// Token: 0x0600A2E8 RID: 41704 RVA: 0x002401C0 File Offset: 0x0023E3C0
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

	// Token: 0x0600A2E9 RID: 41705 RVA: 0x00240225 File Offset: 0x0023E425
	public void SetDebugPermanentFilterVisible(bool bFilterOn)
	{
		this.DebugPermanentFilterVisible = bFilterOn;
	}

	// Token: 0x0600A2EA RID: 41706 RVA: 0x0024022E File Offset: 0x0023E42E
	public bool GetDebugPermanentFilterVisible()
	{
		return this.DebugPermanentFilterVisible;
	}

	// Token: 0x17000DC3 RID: 3523
	// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x00240236 File Offset: 0x0023E436
	public static ActivityModel Instance
	{
		get
		{
			return ActivityModel._Instance;
		}
	}

	// Token: 0x0600A2EC RID: 41708 RVA: 0x0024023D File Offset: 0x0023E43D
	public static ActivityModel GetOrCreateInstance()
	{
		if (ActivityModel._Instance == null)
		{
			ActivityModel.CreateInstance();
		}
		return ActivityModel._Instance;
	}

	// Token: 0x0600A2ED RID: 41709 RVA: 0x00240251 File Offset: 0x0023E451
	public static bool CreateInstance()
	{
		if (ActivityModel._Instance != null)
		{
			return true;
		}
		ActivityModel._Instance = new ActivityModel();
		return true;
	}

	// Token: 0x0600A2EE RID: 41710 RVA: 0x00240267 File Offset: 0x0023E467
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A2EF RID: 41711 RVA: 0x00240269 File Offset: 0x0023E469
	public static void ResetStaticDefaultValue()
	{
		ActivityModel._Instance = null;
	}

	// Token: 0x0600A2F0 RID: 41712 RVA: 0x00240271 File Offset: 0x0023E471
	static ActivityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityModel.CreateStaticDefaultValue), new Action(ActivityModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004A06 RID: 18950
	private readonly Dictionary<int, ActivityBaseData> ActivityMap = new Dictionary<int, ActivityBaseData>();

	// Token: 0x04004A07 RID: 18951
	private readonly List<int> CurrentActivityIds = new List<int>();

	// Token: 0x04004A08 RID: 18952
	private readonly ActivityCache ActivityCache = new ActivityCache();

	// Token: 0x04004A09 RID: 18953
	private readonly HashSet<long> ActivityTimeStampSet = new HashSet<long>();

	// Token: 0x04004A0A RID: 18954
	private readonly Dictionary<long, TimerHandle> ActivityTimeStampHandleMap = new Dictionary<long, TimerHandle>();

	// Token: 0x04004A0B RID: 18955
	private string ActivityForeverTimeText = "";

	// Token: 0x04004A0C RID: 18956
	private string ActivityCloseText = "";

	// Token: 0x04004A0D RID: 18957
	private string ActivityCdTimeText = "";

	// Token: 0x04004A0E RID: 18958
	private string ActivityRemainTimeText = "";

	// Token: 0x04004A0F RID: 18959
	private string ActivityRemainingTimeReward = "";

	// Token: 0x04004A10 RID: 18960
	private int ActivityPermanentFilterId = 999;

	// Token: 0x04004A11 RID: 18961
	private bool DebugPermanentFilterVisible;

	// Token: 0x04004A12 RID: 18962
	private readonly Dictionary<int, ActivityBaseData> CurrentShowingActivitiesMap = new Dictionary<int, ActivityBaseData>();

	// Token: 0x04004A13 RID: 18963
	private readonly HashSet<int> CurrentRemoveActivities = new HashSet<int>();

	// Token: 0x04004A14 RID: 18964
	private readonly HashSet<int> CurrentAddActivities = new HashSet<int>();

	// Token: 0x04004A15 RID: 18965
	private readonly Dictionary<int, IActivityLevelFunc> ActivityLevelFuncMap = new Dictionary<int, IActivityLevelFunc>();

	// Token: 0x04004A16 RID: 18966
	private bool ForceHideActivityTimeTextFlag;

	// Token: 0x04004A17 RID: 18967
	private bool DebugFilterMode;

	// Token: 0x04004A18 RID: 18968
	private List<int> DebugFilterShowActivityIds = new List<int>();

	// Token: 0x04004A19 RID: 18969
	[Nullable(2)]
	private static ActivityModel _Instance;

	// Token: 0x02007C40 RID: 31808
	[CompilerGenerated]
	private static class <SortActivityList>O__50_0<T> where T : ActivityBaseData
	{
		// Token: 0x04028C59 RID: 167001
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<T> <0>__SortFunc;
	}
}
