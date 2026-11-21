using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200054A RID: 1354
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityRecommendModel : ModelBase
{
	// Token: 0x06004220 RID: 16928 RVA: 0x00171180 File Offset: 0x0016F380
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

	// Token: 0x06004221 RID: 16929 RVA: 0x00171208 File Offset: 0x0016F408
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

	// Token: 0x06004222 RID: 16930 RVA: 0x00171258 File Offset: 0x0016F458
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

	// Token: 0x06004223 RID: 16931 RVA: 0x001712E0 File Offset: 0x0016F4E0
	public void SetRedDotStartTimeLatest(long time)
	{
		this.RedDotStartTimeLatest = time;
	}

	// Token: 0x06004224 RID: 16932 RVA: 0x001712EC File Offset: 0x0016F4EC
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

	// Token: 0x06004225 RID: 16933 RVA: 0x001713A8 File Offset: 0x0016F5A8
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

	// Token: 0x06004226 RID: 16934 RVA: 0x00171418 File Offset: 0x0016F618
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

	// Token: 0x06004227 RID: 16935 RVA: 0x00171960 File Offset: 0x0016FB60
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

	// Token: 0x06004228 RID: 16936 RVA: 0x001719AC File Offset: 0x0016FBAC
	private void ClassifyDailyActivity(ActivityRecommend recommend, ActivityRecommendModel.RecommendBuckets buckets)
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.DailyActivity))
		{
			return;
		}
		DailyActivityModel instance = DailyActivityModel.Instance;
		((instance != null && instance.CheckIsFinish()) ? buckets.DailyFinishedList : buckets.DailyUnFinishedList).Add(recommend);
	}

	// Token: 0x06004229 RID: 16937 RVA: 0x001719E8 File Offset: 0x0016FBE8
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

	// Token: 0x0600422A RID: 16938 RVA: 0x00171A44 File Offset: 0x0016FC44
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

	// Token: 0x0600422B RID: 16939 RVA: 0x00171B0C File Offset: 0x0016FD0C
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
				bool flag = ActivityRecommendModel.ContainsQuestId(this.BranchOneMainLineQuestList, quest.Id);
				bool flag2 = ActivityRecommendModel.ContainsQuestId(this.BranchTwoMainLineQuestList, quest.Id);
				bool flag3 = ActivityRecommendModel.ContainsQuestId(this.BranchThreeMainLineQuestList, quest.Id);
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

	// Token: 0x0600422C RID: 16940 RVA: 0x00171C04 File Offset: 0x0016FE04
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

	// Token: 0x0600422D RID: 16941 RVA: 0x00171C8C File Offset: 0x0016FE8C
	private static bool ContainsQuestId(IReadOnlyList<int> questIdList, int questId)
	{
		for (int i = 0; i < questIdList.Count; i++)
		{
			if (questIdList[i] == questId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600422E RID: 16942 RVA: 0x00171CB8 File Offset: 0x0016FEB8
	private ERegressBranchNumber GetBranchByQuestIds(IReadOnlyList<int> questIds)
	{
		ERegressBranchNumber eregressBranchNumber = ERegressBranchNumber.BranchOne;
		foreach (int questId in questIds)
		{
			if (!ActivityRecommendModel.ContainsQuestId(this.BranchOneMainLineQuestList, questId))
			{
				if (ActivityRecommendModel.ContainsQuestId(this.BranchTwoMainLineQuestList, questId))
				{
					if (eregressBranchNumber < ERegressBranchNumber.BranchTwo)
					{
						eregressBranchNumber = ERegressBranchNumber.BranchTwo;
					}
				}
				else
				{
					if (!ActivityRecommendModel.ContainsQuestId(this.BranchThreeMainLineQuestList, questId))
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

	// Token: 0x0600422F RID: 16943 RVA: 0x00171D44 File Offset: 0x0016FF44
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

	// Token: 0x06004230 RID: 16944 RVA: 0x00171E1C File Offset: 0x0017001C
	public bool IsEntryFirstClickRedDotShow()
	{
		ServerStorageLong serverStorageLong = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRecommend2) as ServerStorageLong;
		long valueOrDefault = ((serverStorageLong != null) ? serverStorageLong.Get() : null).GetValueOrDefault();
		long redDotStartTimeLatest = this.RedDotStartTimeLatest;
		return valueOrDefault != redDotStartTimeLatest && redDotStartTimeLatest > 0L;
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x00171E68 File Offset: 0x00170068
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

	// Token: 0x17000946 RID: 2374
	// (get) Token: 0x06004232 RID: 16946 RVA: 0x00171ED7 File Offset: 0x001700D7
	public static ActivityRecommendModel Instance
	{
		get
		{
			return ActivityRecommendModel._Instance;
		}
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x00171EDE File Offset: 0x001700DE
	public static ActivityRecommendModel GetOrCreateInstance()
	{
		if (ActivityRecommendModel._Instance == null)
		{
			ActivityRecommendModel.CreateInstance();
		}
		return ActivityRecommendModel._Instance;
	}

	// Token: 0x06004234 RID: 16948 RVA: 0x00171EF2 File Offset: 0x001700F2
	public static bool CreateInstance()
	{
		if (ActivityRecommendModel._Instance != null)
		{
			return true;
		}
		ActivityRecommendModel._Instance = new ActivityRecommendModel();
		return true;
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x00171F08 File Offset: 0x00170108
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x00171F0A File Offset: 0x0017010A
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendModel._Instance = null;
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x00171F12 File Offset: 0x00170112
	static ActivityRecommendModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendModel.CreateStaticDefaultValue), new Action(ActivityRecommendModel.ResetStaticDefaultValue));
	}

	// Token: 0x040033CE RID: 13262
	private const int PERIOD_FILTER_TAB_TYPE = 3;

	// Token: 0x040033CF RID: 13263
	public int CurrentGroupId;

	// Token: 0x040033D0 RID: 13264
	public int LatestBranch;

	// Token: 0x040033D1 RID: 13265
	private IReadOnlyList<int> BranchOneMainLineQuestList = new List<int>();

	// Token: 0x040033D2 RID: 13266
	private IReadOnlyList<int> BranchTwoMainLineQuestList = new List<int>();

	// Token: 0x040033D3 RID: 13267
	private IReadOnlyList<int> BranchThreeMainLineQuestList = new List<int>();

	// Token: 0x040033D4 RID: 13268
	private readonly Dictionary<int, ActivityRecommendModel.RecommendFallbackData> RecommendFallbackMap = new Dictionary<int, ActivityRecommendModel.RecommendFallbackData>();

	// Token: 0x040033D5 RID: 13269
	private long RedDotStartTimeLatest;

	// Token: 0x040033D6 RID: 13270
	[Nullable(2)]
	private static ActivityRecommendModel _Instance;

	// Token: 0x0200681B RID: 26651
	[NullableContext(0)]
	private struct RecommendFallbackData
	{
		// Token: 0x0402251F RID: 140575
		public long BeginShowTime;

		// Token: 0x04022520 RID: 140576
		public long BeginOpenTime;
	}

	// Token: 0x0200681C RID: 26652
	[NullableContext(0)]
	private struct PreOpenItem
	{
		// Token: 0x04022521 RID: 140577
		public int Id;

		// Token: 0x04022522 RID: 140578
		public int Sort;

		// Token: 0x04022523 RID: 140579
		public long PreOpenTime;
	}

	// Token: 0x0200681D RID: 26653
	[Nullable(0)]
	private class RecommendBuckets
	{
		// Token: 0x04022524 RID: 140580
		public readonly List<ActivityRecommend> ActivityCurrentUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x04022525 RID: 140581
		public readonly List<ActivityRecommend> DailyUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x04022526 RID: 140582
		public readonly List<ActivityRecommend> WeeklyUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x04022527 RID: 140583
		public readonly List<ActivityRecommend> PeriodUnFinishedList = new List<ActivityRecommend>();

		// Token: 0x04022528 RID: 140584
		public readonly List<ActivityRecommend> ActivityCurrentFinishedList = new List<ActivityRecommend>();

		// Token: 0x04022529 RID: 140585
		public readonly List<ActivityRecommend> DailyFinishedList = new List<ActivityRecommend>();

		// Token: 0x0402252A RID: 140586
		public readonly List<ActivityRecommend> WeeklyFinishedList = new List<ActivityRecommend>();

		// Token: 0x0402252B RID: 140587
		public readonly List<ActivityRecommend> PeriodFinishedList = new List<ActivityRecommend>();

		// Token: 0x0402252C RID: 140588
		public readonly List<ActivityRecommendModel.PreOpenItem> PreOpenList = new List<ActivityRecommendModel.PreOpenItem>();
	}
}
