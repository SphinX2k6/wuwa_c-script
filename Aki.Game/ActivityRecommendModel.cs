using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02001096 RID: 4246
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityRecommendModel : ModelBase
{
	// Token: 0x06006E8B RID: 28299 RVA: 0x0016884C File Offset: 0x00166A4C
	protected override bool OnInit()
	{
		ActivityRecommendConfig instance = ActivityRecommendConfig.Instance;
		this.CurrentGroupId = ((instance != null) ? instance.GetCurrentGroupId() : 0);
		this.LatestBranch = ConfigCommonParamById.GetIntConfig("LatestBranch").GetValueOrDefault();
		this.BranchOneMainLineQuestList = (ConfigCommonParamById.GetIntArrayConfig("BranchOneMainQuest") ?? new List<int>());
		this.BranchTwoMainLineQuestList = (ConfigCommonParamById.GetIntArrayConfig("BranchTwoMainQuest") ?? new List<int>());
		this.BranchThreeMainLineQuestList = (ConfigCommonParamById.GetIntArrayConfig("BranchThreeMainQuest") ?? new List<int>());
		return true;
	}

	// Token: 0x06006E8C RID: 28300 RVA: 0x001688D4 File Offset: 0x00166AD4
	protected override bool OnClear()
	{
		this.CurrentGroupId = 0;
		this.LatestBranch = 0;
		this.BranchOneMainLineQuestList = new List<int>();
		this.BranchTwoMainLineQuestList = new List<int>();
		this.BranchThreeMainLineQuestList = new List<int>();
		this.RecommendFallbackMap.Clear();
		this.RedDotStartTimeLatest = 0L;
		return true;
	}

	// Token: 0x06006E8D RID: 28301 RVA: 0x00168924 File Offset: 0x00166B24
	public void SetRecommendFallback(IReadOnlyList<ActivityRecommendOnePb> list)
	{
		this.RecommendFallbackMap.Clear();
		foreach (ActivityRecommendOnePb activityRecommendOnePb in list)
		{
			int activityId = activityRecommendOnePb.ActivityId;
			if (activityId != 0)
			{
				this.RecommendFallbackMap[activityId] = new ActivityRecommendModel.RecommendFallbackData
				{
					BeginShowTime = activityRecommendOnePb.BeginShowTime,
					BeginOpenTime = activityRecommendOnePb.BeginOpenTime
				};
			}
		}
	}

	// Token: 0x06006E8E RID: 28302 RVA: 0x001689AC File Offset: 0x00166BAC
	public void SetRedDotStartTimeLatest(long time)
	{
		this.RedDotStartTimeLatest = time;
	}

	// Token: 0x06006E8F RID: 28303 RVA: 0x001689B8 File Offset: 0x00166BB8
	public bool IsPeriodActivity(int activityId)
	{
		ActivityModel instance = ActivityModel.Instance;
		ActivityBaseData activityBaseData = (instance != null) ? instance.GetActivityById(activityId) : null;
		int? num = (activityBaseData != null) ? ((activityBaseData.LocalConfig != null) ? new int?(activityBaseData.LocalConfig.GetValueOrDefault().FilterTabType) : null) : null;
		int valueOrDefault;
		if (num == null)
		{
			ActivityConfig instance2 = ActivityConfig.Instance;
			Activity? activity;
			valueOrDefault = ((instance2 != null) ? ((instance2.GetActivityConfig(activityId) != null) ? new int?(activity.GetValueOrDefault().FilterTabType) : null) : null).GetValueOrDefault();
		}
		else
		{
			valueOrDefault = num.GetValueOrDefault();
		}
		return valueOrDefault == 3;
	}

	// Token: 0x06006E90 RID: 28304 RVA: 0x00168A74 File Offset: 0x00166C74
	public long? GetActivityPreOpenTime(int activityId)
	{
		ActivityModel instance = ActivityModel.Instance;
		if (((instance != null) ? instance.GetActivityById(activityId) : null) != null)
		{
			return null;
		}
		ActivityRecommendModel.RecommendFallbackData recommendFallbackData;
		if (!this.RecommendFallbackMap.TryGetValue(activityId, out recommendFallbackData))
		{
			return null;
		}
		if ((double)recommendFallbackData.BeginShowTime <= TimeUtil.Instance.GetServerTime())
		{
			return null;
		}
		return new long?(recommendFallbackData.BeginOpenTime);
	}

	// Token: 0x06006E91 RID: 28305 RVA: 0x00168AE4 File Offset: 0x00166CE4
	public List<int> GetRecommendDataList()
	{
		ActivityRecommendConfig instance = ActivityRecommendConfig.Instance;
		if (instance == null)
		{
			return new List<int>();
		}
		IEnumerable<ActivityRecommend> recommendListByGroup = instance.GetRecommendListByGroup(this.CurrentGroupId);
		ActivityRecommendModel.RecommendBuckets recommendBuckets = new ActivityRecommendModel.RecommendBuckets();
		foreach (ActivityRecommend recommend in recommendListByGroup)
		{
			this.ClassifyRecommend(recommend, recommendBuckets);
		}
		List<ActivityRecommend> activityCurrentUnFinishedList = recommendBuckets.ActivityCurrentUnFinishedList;
		List<ActivityRecommend> dailyUnFinishedList = recommendBuckets.DailyUnFinishedList;
		List<ActivityRecommend> weeklyUnFinishedList = recommendBuckets.WeeklyUnFinishedList;
		List<ActivityRecommend> periodUnFinishedList = recommendBuckets.PeriodUnFinishedList;
		List<ActivityRecommend> activityCurrentFinishedList = recommendBuckets.ActivityCurrentFinishedList;
		List<ActivityRecommend> dailyFinishedList = recommendBuckets.DailyFinishedList;
		List<ActivityRecommend> weeklyFinishedList = recommendBuckets.WeeklyFinishedList;
		List<ActivityRecommend> periodFinishedList = recommendBuckets.PeriodFinishedList;
		List<ActivityRecommendModel.PreOpenItem> preOpenList = recommendBuckets.PreOpenList;
		activityCurrentUnFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		dailyUnFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		weeklyUnFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		periodUnFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		activityCurrentFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		dailyFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		weeklyFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		periodFinishedList.Sort((ActivityRecommend a, ActivityRecommend b) => a.Sort - b.Sort);
		preOpenList.Sort(delegate(ActivityRecommendModel.PreOpenItem a, ActivityRecommendModel.PreOpenItem b)
		{
			if (a.PreOpenTime != b.PreOpenTime)
			{
				return a.PreOpenTime.CompareTo(b.PreOpenTime);
			}
			return a.Sort - b.Sort;
		});
		List<int> list = new List<int>();
		foreach (ActivityRecommend activityRecommend in activityCurrentUnFinishedList)
		{
			list.Add(activityRecommend.Id);
		}
		foreach (ActivityRecommend activityRecommend2 in dailyUnFinishedList)
		{
			list.Add(activityRecommend2.Id);
		}
		foreach (ActivityRecommend activityRecommend3 in weeklyUnFinishedList)
		{
			list.Add(activityRecommend3.Id);
		}
		foreach (ActivityRecommend activityRecommend4 in periodUnFinishedList)
		{
			list.Add(activityRecommend4.Id);
		}
		List<ActivityRecommend> list2 = new List<ActivityRecommend>(instance.GetRecommendByType(EActivityRecommendType.Area));
		list2.Sort(delegate(ActivityRecommend a, ActivityRecommend b)
		{
			if (a.Sort != b.Sort)
			{
				return a.Sort - b.Sort;
			}
			ExploreAreaData exploreAreaData2 = ExploreProgressModel.Instance.GetExploreAreaData(a.JumpParam);
			ExploreAreaData exploreAreaData3 = ExploreProgressModel.Instance.GetExploreAreaData(b.JumpParam);
			return ((exploreAreaData2 != null) ? exploreAreaData2.GetProgress() : 0) - ((exploreAreaData3 != null) ? exploreAreaData3.GetProgress() : 0);
		});
		ActivityRecommend? activityRecommend5 = null;
		foreach (ActivityRecommend value in list2)
		{
			ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(value.JumpParam);
			if (exploreAreaData == null || !exploreAreaData.IsReachMaxProgress)
			{
				activityRecommend5 = new ActivityRecommend?(value);
				break;
			}
		}
		if (activityRecommend5 != null)
		{
			list.Add(activityRecommend5.Value.Id);
		}
		foreach (ActivityRecommendModel.PreOpenItem preOpenItem in preOpenList)
		{
			list.Add(preOpenItem.Id);
		}
		foreach (ActivityRecommend activityRecommend6 in activityCurrentFinishedList)
		{
			list.Add(activityRecommend6.Id);
		}
		foreach (ActivityRecommend activityRecommend7 in dailyFinishedList)
		{
			list.Add(activityRecommend7.Id);
		}
		foreach (ActivityRecommend activityRecommend8 in weeklyFinishedList)
		{
			list.Add(activityRecommend8.Id);
		}
		foreach (ActivityRecommend activityRecommend9 in periodFinishedList)
		{
			list.Add(activityRecommend9.Id);
		}
		return list;
	}

	// Token: 0x06006E92 RID: 28306 RVA: 0x0016902C File Offset: 0x0016722C
	private void ClassifyRecommend(ActivityRecommend recommend, ActivityRecommendModel.RecommendBuckets buckets)
	{
		switch (recommend.Type)
		{
		case 2:
		case 3:
			this.ClassifyActivity(recommend, buckets);
			break;
		case 4:
			break;
		case 5:
			this.ClassifyDailyActivity(recommend, buckets);
			return;
		case 6:
			this.ClassifyWeeklyChallenge(recommend, buckets);
			return;
		default:
			return;
		}
	}

	// Token: 0x06006E93 RID: 28307 RVA: 0x00169078 File Offset: 0x00167278
	private void ClassifyDailyActivity(ActivityRecommend recommend, ActivityRecommendModel.RecommendBuckets buckets)
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.DailyActivity))
		{
			return;
		}
		DailyActivityModel instance = DailyActivityModel.Instance;
		((instance != null && instance.CheckIsFinish()) ? buckets.DailyFinishedList : buckets.DailyUnFinishedList).Add(recommend);
	}

	// Token: 0x06006E94 RID: 28308 RVA: 0x001690B4 File Offset: 0x001672B4
	private void ClassifyWeeklyChallenge(ActivityRecommend recommend, ActivityRecommendModel.RecommendBuckets buckets)
	{
		bool flag = FunctionModel.Instance.IsOpen(EFunctionType.WeeklyChallenge);
		WeeklyChallengeModel instance = WeeklyChallengeModel.Instance;
		int num = (instance != null) ? instance.WeeklyConfigId : 0;
		if (!flag || num == 0)
		{
			return;
		}
		WeeklyChallengeModel instance2 = WeeklyChallengeModel.Instance;
		((instance2 != null && instance2.CheckIsFinish()) ? buckets.WeeklyFinishedList : buckets.WeeklyUnFinishedList).Add(recommend);
	}

	// Token: 0x06006E95 RID: 28309 RVA: 0x00169110 File Offset: 0x00167310
	private void ClassifyActivity(ActivityRecommend recommend, ActivityRecommendModel.RecommendBuckets buckets)
	{
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(recommend.JumpParam);
		if (activityById == null || !activityById.CheckIfInShowTime())
		{
			long? activityPreOpenTime = this.GetActivityPreOpenTime(recommend.JumpParam);
			if (activityPreOpenTime != null)
			{
				buckets.PreOpenList.Add(new ActivityRecommendModel.PreOpenItem
				{
					Id = recommend.Id,
					Sort = recommend.Sort,
					PreOpenTime = activityPreOpenTime.Value
				});
			}
			return;
		}
		bool finishShowState = activityById.FinishShowState;
		if (this.IsPeriodActivity(recommend.JumpParam))
		{
			(finishShowState ? buckets.PeriodFinishedList : buckets.PeriodUnFinishedList).Add(recommend);
			return;
		}
		(finishShowState ? buckets.ActivityCurrentFinishedList : buckets.ActivityCurrentUnFinishedList).Add(recommend);
	}

	// Token: 0x06006E96 RID: 28310 RVA: 0x001691D8 File Offset: 0x001673D8
	public int GetCurrentMainLineQuest()
	{
		List<global::Quest> questsByType = QuestNewModel.Instance.GetQuestsByType(1);
		if (questsByType.Count > 0)
		{
			int result = 0;
			int num = 0;
			int num2 = 0;
			foreach (global::Quest quest in questsByType)
			{
				bool flag = this.BranchOneMainLineQuestList.Contains(quest.Id);
				bool flag2 = this.BranchTwoMainLineQuestList.Contains(quest.Id);
				bool flag3 = this.BranchThreeMainLineQuestList.Contains(quest.Id);
				if (!flag && !flag2 && !flag3)
				{
					return quest.Id;
				}
				if (flag3)
				{
					num2 = quest.Id;
				}
				if (flag2)
				{
					num = quest.Id;
				}
				if (flag)
				{
					result = quest.Id;
				}
			}
			if (num2 > 0)
			{
				return num2;
			}
			if (num > 0)
			{
				return num;
			}
			return result;
		}
		return 0;
	}

	// Token: 0x06006E97 RID: 28311 RVA: 0x001692D0 File Offset: 0x001674D0
	public ERegressBranchNumber GetCurrentMainLineBranch()
	{
		List<global::Quest> questsByType = QuestNewModel.Instance.GetQuestsByType(1);
		if (questsByType.Count > 0)
		{
			List<int> list = new List<int>();
			foreach (global::Quest quest in questsByType)
			{
				list.Add(quest.Id);
			}
			return this.GetBranchByQuestIds(list);
		}
		return this.GetBranchByQuestIds(QuestNewModel.Instance.FinishedMainQuests);
	}

	// Token: 0x06006E98 RID: 28312 RVA: 0x00169358 File Offset: 0x00167558
	private ERegressBranchNumber GetBranchByQuestIds(IReadOnlyList<int> questIds)
	{
		ERegressBranchNumber eregressBranchNumber = ERegressBranchNumber.BranchOne;
		foreach (int value in questIds)
		{
			if (!this.BranchOneMainLineQuestList.Contains(value))
			{
				if (this.BranchTwoMainLineQuestList.Contains(value))
				{
					if (eregressBranchNumber < ERegressBranchNumber.BranchTwo)
					{
						eregressBranchNumber = ERegressBranchNumber.BranchTwo;
					}
				}
				else
				{
					if (!this.BranchThreeMainLineQuestList.Contains(value))
					{
						return (ERegressBranchNumber)this.LatestBranch;
					}
					if (eregressBranchNumber < ERegressBranchNumber.BranchThree)
					{
						eregressBranchNumber = ERegressBranchNumber.BranchThree;
					}
				}
			}
		}
		return eregressBranchNumber;
	}

	// Token: 0x06006E99 RID: 28313 RVA: 0x001693E4 File Offset: 0x001675E4
	public List<TItem> GetDropPreviewRewardItemListForPreview(int dropId)
	{
		DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId);
		List<TItem> list = new List<TItem>();
		Dictionary<int, int> dictionary = (dropPackage != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
		if (dictionary != null && dictionary.Count > 0)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				list.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
			}
			return list;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ActivityRegress;
		ELogAuthor author = ELogAuthor.TZJ;
		string message = "活动推荐->掉落包预览道具不存在";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dropId", dropId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return list;
	}

	// Token: 0x06006E9A RID: 28314 RVA: 0x001694BC File Offset: 0x001676BC
	public bool IsEntryFirstClickRedDotShow()
	{
		ServerStorageLong serverStorageLong = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRecommend2) as ServerStorageLong;
		long valueOrDefault = ((serverStorageLong != null) ? serverStorageLong.Get() : null).GetValueOrDefault();
		long redDotStartTimeLatest = this.RedDotStartTimeLatest;
		return valueOrDefault != redDotStartTimeLatest && redDotStartTimeLatest > 0L;
	}

	// Token: 0x06006E9B RID: 28315 RVA: 0x00169508 File Offset: 0x00167708
	public void MarkEntryFirstClickRead()
	{
		if (this.RedDotStartTimeLatest <= 0L)
		{
			return;
		}
		ServerStorageLong serverStorageLong = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRecommend2) as ServerStorageLong;
		long? num = (serverStorageLong != null) ? serverStorageLong.Get() : null;
		long redDotStartTimeLatest = this.RedDotStartTimeLatest;
		if (num.GetValueOrDefault() == redDotStartTimeLatest & num != null)
		{
			return;
		}
		if (serverStorageLong != null)
		{
			serverStorageLong.Set(new long?(this.RedDotStartTimeLatest));
		}
	}

	// Token: 0x17000926 RID: 2342
	// (get) Token: 0x06006E9C RID: 28316 RVA: 0x00169577 File Offset: 0x00167777
	public static ActivityRecommendModel Instance
	{
		get
		{
			return ActivityRecommendModel._Instance;
		}
	}

	// Token: 0x06006E9D RID: 28317 RVA: 0x0016957E File Offset: 0x0016777E
	public static ActivityRecommendModel GetOrCreateInstance()
	{
		if (ActivityRecommendModel._Instance == null)
		{
			ActivityRecommendModel.CreateInstance();
		}
		return ActivityRecommendModel._Instance;
	}

	// Token: 0x06006E9E RID: 28318 RVA: 0x00169592 File Offset: 0x00167792
	public static bool CreateInstance()
	{
		if (ActivityRecommendModel._Instance != null)
		{
			return true;
		}
		ActivityRecommendModel._Instance = new ActivityRecommendModel();
		return true;
	}

	// Token: 0x06006E9F RID: 28319 RVA: 0x001695A8 File Offset: 0x001677A8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006EA0 RID: 28320 RVA: 0x001695AA File Offset: 0x001677AA
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendModel._Instance = null;
	}

	// Token: 0x06006EA1 RID: 28321 RVA: 0x001695B2 File Offset: 0x001677B2
	static ActivityRecommendModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendModel.CreateStaticDefaultValue), new Action(ActivityRecommendModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003335 RID: 13109
	private const int PERIOD_FILTER_TAB_TYPE = 3;

	// Token: 0x04003336 RID: 13110
	public int CurrentGroupId;

	// Token: 0x04003337 RID: 13111
	public int LatestBranch;

	// Token: 0x04003338 RID: 13112
	private IReadOnlyList<int> BranchOneMainLineQuestList = new List<int>();

	// Token: 0x04003339 RID: 13113
	private IReadOnlyList<int> BranchTwoMainLineQuestList = new List<int>();

	// Token: 0x0400333A RID: 13114
	private IReadOnlyList<int> BranchThreeMainLineQuestList = new List<int>();

	// Token: 0x0400333B RID: 13115
	private readonly Dictionary<int, ActivityRecommendModel.RecommendFallbackData> RecommendFallbackMap = new Dictionary<int, ActivityRecommendModel.RecommendFallbackData>();

	// Token: 0x0400333C RID: 13116
	private long RedDotStartTimeLatest;

	// Token: 0x0400333D RID: 13117
	[Nullable(2)]
	private static ActivityRecommendModel _Instance;

	// Token: 0x02007687 RID: 30343
	[NullableContext(0)]
	private struct RecommendFallbackData
	{
		// Token: 0x040271D4 RID: 160212
		public long BeginShowTime;

		// Token: 0x040271D5 RID: 160213
		public long BeginOpenTime;
	}

	// Token: 0x02007688 RID: 30344
	[NullableContext(0)]
	private struct PreOpenItem
	{
		// Token: 0x040271D6 RID: 160214
		public int Id;

		// Token: 0x040271D7 RID: 160215
		public int Sort;

		// Token: 0x040271D8 RID: 160216
		public long PreOpenTime;
	}

	// Token: 0x02007689 RID: 30345
	[Nullable(0)]
	private class RecommendBuckets
	{
		// Token: 0x040271D9 RID: 160217
		public readonly List<ActivityRecommend> ActivityCurrentUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271DA RID: 160218
		public readonly List<ActivityRecommend> DailyUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271DB RID: 160219
		public readonly List<ActivityRecommend> WeeklyUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271DC RID: 160220
		public readonly List<ActivityRecommend> PeriodUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271DD RID: 160221
		public readonly List<ActivityRecommend> ActivityCurrentFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271DE RID: 160222
		public readonly List<ActivityRecommend> DailyFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271DF RID: 160223
		public readonly List<ActivityRecommend> WeeklyFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271E0 RID: 160224
		public readonly List<ActivityRecommend> PeriodFinishedList = new List<ActivityRecommend>();

		// Token: 0x040271E1 RID: 160225
		public readonly List<ActivityRecommendModel.PreOpenItem> PreOpenList = new List<ActivityRecommendModel.PreOpenItem>();
	}
}
