using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Launcher.NetworkDetection;

// Token: 0x0200144D RID: 5197
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ActivityRegressConfig : ConfigBase
{
	// Token: 0x060092C7 RID: 37575 RVA: 0x001F7FA8 File Offset: 0x001F61A8
	public unsafe IReadOnlyList<RegressSignReward> GetRegressSignRewards(int activityId, ERegressGrade grade)
	{
		IReadOnlyList<RegressSignReward> configList = ConfigRegressSignRewardByGradeAndActivityId.GetConfigList((int)grade, activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "回归活动->获取回流签到奖励配置失败,请检查配置表RegressSignReward";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId:", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("grade:", grade);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		List<RegressSignReward> list = new List<RegressSignReward>();
		IReadOnlyList<RegressSignReward> readOnlyList = configList;
		foreach (RegressSignReward item in (readOnlyList ?? Array.Empty<RegressSignReward>()))
		{
			if (item.Version > 0)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x060092C8 RID: 37576 RVA: 0x001F8078 File Offset: 0x001F6278
	public unsafe RegressInvestigation? GetRegressQuestionnaireConfig(ERegressQuestionnaireType type)
	{
		bool flag = LauncherNetworkDetectionController.Instance.IsGlobalPlayer();
		RegressInvestigation? config = ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.GetConfig((int)type, flag, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "回归活动->获取回流调查问卷配置失败,请检查配置表RegressInvestigation";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type:", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ifGlobal:", flag);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return new RegressInvestigation?(config.Value);
	}

	// Token: 0x060092C9 RID: 37577 RVA: 0x001F8118 File Offset: 0x001F6318
	public IReadOnlyList<RegressBase> GetRegressBaseConfigListByType(EActivityRegressEntranceType entryType)
	{
		if (entryType == EActivityRegressEntranceType.NewRole2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "[回流活动]ActivityRecallConfig.GetRecallBaseConfigByType->";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("获取回流基础配置失败,请检查传入参数,请传入新角色1类型来获取配置，EntryType:", entryType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		IReadOnlyList<RegressBase> configList = ConfigRegressBaseByEntryType.GetConfigList((int)entryType, true);
		if (configList == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ActivityRegress;
			ELogAuthor author2 = ELogAuthor.LRX;
			string message2 = "[回流活动]ActivityRecallConfig.GetRecallBaseConfigByType->";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("获取回流基础配置失败,请检查配置表RegressBase: entryType:", entryType);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return configList;
	}

	// Token: 0x060092CA RID: 37578 RVA: 0x001F8194 File Offset: 0x001F6394
	public RewardConfig? GetRewardConfig(int rewardGroupId)
	{
		RewardConfig? config = ConfigRewardConfigById.GetConfig(rewardGroupId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "[回流活动]ActivityRecallConfig.GetRewardConfig->";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("获取回归奖励配置失败,请检查配置表奖励档次|RewardConfig: rewardGroupId:", rewardGroupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060092CB RID: 37579 RVA: 0x001F81EC File Offset: 0x001F63EC
	public RegressQuest? GetRegressQuestConfig(int taskId)
	{
		RegressQuest? config = ConfigRegressQuestById.GetConfig(taskId, true);
		if (config != null)
		{
			return new RegressQuest?(config.Value);
		}
		return null;
	}

	// Token: 0x060092CC RID: 37580 RVA: 0x001F8220 File Offset: 0x001F6420
	public IReadOnlyList<RegressBonusReward> GetRegressBonusRewardConfigList(ERegressGrade grade)
	{
		IReadOnlyList<RegressBonusReward> configList = ConfigRegressBonusRewardByGrade.GetConfigList((int)grade, true);
		List<RegressBonusReward> list = new List<RegressBonusReward>();
		IReadOnlyList<RegressBonusReward> readOnlyList = configList;
		foreach (RegressBonusReward item in (readOnlyList ?? Array.Empty<RegressBonusReward>()))
		{
			if (item.Version > 0)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x060092CD RID: 37581 RVA: 0x001F828C File Offset: 0x001F648C
	[NullableContext(0)]
	public ValueTuple<RegressEntry?, RegressEntry?> GetRegressRoleEntryConfigTuple()
	{
		List<RegressEntry?> sortedOpenRegressEntryConfigList = this.GetSortedOpenRegressEntryConfigList();
		return new ValueTuple<RegressEntry?, RegressEntry?>(sortedOpenRegressEntryConfigList[0], sortedOpenRegressEntryConfigList[1]);
	}

	// Token: 0x060092CE RID: 37582 RVA: 0x001F82B4 File Offset: 0x001F64B4
	[NullableContext(1)]
	public List<RegressEntry?> GetSortedOpenRegressEntryConfigList()
	{
		List<RegressEntry> regressEntryConfigByType = this.GetRegressEntryConfigByType(EActivityRegressEntranceType.NewRole1);
		if (regressEntryConfigByType == null)
		{
			return new List<RegressEntry?>();
		}
		List<RegressEntry?> list = new List<RegressEntry?>();
		foreach (RegressEntry value in regressEntryConfigByType)
		{
			list.Add(new RegressEntry?(value));
		}
		list.Sort(delegate(RegressEntry? config1, RegressEntry? config2)
		{
			if (config1 == null || config2 == null)
			{
				int num = ((config1 != null) > false) ? 1 : 0;
				return (((config2 != null) > false) ? 1 : 0) - num;
			}
			int num2 = (ActivityRegressModel.Instance.CheckIfEntryOpen(config1.Value).Item1 > false) ? 1 : 0;
			int num3 = (ActivityRegressModel.Instance.CheckIfEntryOpen(config2.Value).Item1 > false) ? 1 : 0;
			if (num3 == num2)
			{
				return config1.Value.Id - config2.Value.Id;
			}
			return num3 - num2;
		});
		return list;
	}

	// Token: 0x060092CF RID: 37583 RVA: 0x001F8344 File Offset: 0x001F6544
	[NullableContext(1)]
	public List<RegressBase?> GetSortedOpenRegressBaseConfigList()
	{
		IReadOnlyList<RegressBase> lastestRegressBaseConfigList = ActivityRegressModel.Instance.GetLastestRegressBaseConfigList(EActivityRegressEntranceType.NewRole1);
		if (lastestRegressBaseConfigList == null)
		{
			return new List<RegressBase?>();
		}
		List<RegressBase?> list = new List<RegressBase?>();
		foreach (RegressBase regressBase in lastestRegressBaseConfigList)
		{
			if (ActivityRegressModel.Instance.CheckIfEntryOpen(regressBase).Item1)
			{
				list.Add(new RegressBase?(regressBase));
			}
		}
		return list;
	}

	// Token: 0x060092D0 RID: 37584 RVA: 0x001F83C0 File Offset: 0x001F65C0
	public RegressEntry? GetRegressEntrySingleConfigByType(EActivityRegressEntranceType entryType)
	{
		List<RegressEntry> regressEntryConfigByType = this.GetRegressEntryConfigByType(entryType);
		if (regressEntryConfigByType == null || regressEntryConfigByType.Count == 0)
		{
			return null;
		}
		return new RegressEntry?(regressEntryConfigByType[0]);
	}

	// Token: 0x060092D1 RID: 37585 RVA: 0x001F83F8 File Offset: 0x001F65F8
	[NullableContext(1)]
	public List<RegressEntry> GetRegressEntryConfigByType(EActivityRegressEntranceType entryType)
	{
		if (entryType == EActivityRegressEntranceType.NewRole2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "[回流活动]ActivityRecallConfig.GetRegressEntryConfigByType->";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("获取回流配置失败,请检查传入参数,请传入新角色1类型来获取配置,RegressEntry:entryType:", entryType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<RegressEntry>();
		}
		IReadOnlyList<RegressEntry> configList = ConfigRegressEntryByEntryType.GetConfigList((int)entryType, true);
		if (configList == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ActivityRegress;
			ELogAuthor author2 = ELogAuthor.LRX;
			string message2 = "[回流活动]ActivityRecallConfig.GetRegressEntryConfigByType->";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("获取回流配置失败,请检查配置表RegressEntry: entryType:", entryType);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return new List<RegressEntry>();
		}
		return configList.ToList<RegressEntry>();
	}

	// Token: 0x060092D2 RID: 37586 RVA: 0x001F8484 File Offset: 0x001F6684
	[NullableContext(1)]
	public List<RegressEntry> GetUnlockRegressEntryViewConfigList()
	{
		List<RegressEntry> list = new List<RegressEntry>();
		RegressEntry? regressEntrySingleConfigByType = this.GetRegressEntrySingleConfigByType(EActivityRegressEntranceType.NewMainLine);
		if (regressEntrySingleConfigByType != null)
		{
			list.Add(regressEntrySingleConfigByType.Value);
		}
		RegressEntry? regressEntrySingleConfigByType2 = this.GetRegressEntrySingleConfigByType(EActivityRegressEntranceType.NewArea);
		if (regressEntrySingleConfigByType2 != null)
		{
			list.Add(regressEntrySingleConfigByType2.Value);
		}
		ValueTuple<RegressEntry?, RegressEntry?> regressRoleEntryConfigTuple = this.GetRegressRoleEntryConfigTuple();
		RegressEntry? item = regressRoleEntryConfigTuple.Item1;
		RegressEntry? item2 = regressRoleEntryConfigTuple.Item2;
		bool flag = false;
		if (item != null)
		{
			flag = ActivityRegressModel.Instance.CheckIfEntryOpen(item.Value).Item1;
		}
		bool flag2 = false;
		if (item2 != null)
		{
			flag2 = ActivityRegressModel.Instance.CheckIfEntryOpen(item2.Value).Item1;
		}
		if (flag || flag2)
		{
			if (flag && item != null)
			{
				list.Add(item.Value);
			}
			if (!flag && flag2 && item2 != null)
			{
				list.Add(item2.Value);
			}
		}
		return list;
	}

	// Token: 0x060092D3 RID: 37587 RVA: 0x001F8574 File Offset: 0x001F6774
	public RegressDoubleDrop? GetDoubleDropConfig(ERegressGrade grade)
	{
		RegressDoubleDrop? config = ConfigRegressDoubleDropByGrade.GetConfig((int)grade, true);
		if (config != null)
		{
			return new RegressDoubleDrop?(config.Value);
		}
		return null;
	}

	// Token: 0x060092D4 RID: 37588 RVA: 0x001F85A8 File Offset: 0x001F67A8
	public ConditionGroup? GetConditionGroup(int conditionId)
	{
		ConditionGroup? config = ConfigConditionGroupById.GetConfig(conditionId, true);
		if (config != null)
		{
			return new ConditionGroup?(config.Value);
		}
		return null;
	}

	// Token: 0x060092D5 RID: 37589 RVA: 0x001F85DC File Offset: 0x001F67DC
	public RegressRecommend? GetRegressRecommend(int id)
	{
		RegressRecommend? config = ConfigRegressRecommendById.GetConfig(id, true);
		if (config != null)
		{
			return new RegressRecommend?(config.Value);
		}
		return null;
	}

	// Token: 0x060092D6 RID: 37590 RVA: 0x001F8610 File Offset: 0x001F6810
	public IReadOnlyList<RegressRecommend> GetAllRegressRecommend()
	{
		return ConfigRegressRecommendAll.GetConfigList(true);
	}

	// Token: 0x060092D7 RID: 37591 RVA: 0x001F8618 File Offset: 0x001F6818
	public IReadOnlyList<RegressRecommend> GetRegressRecommendByType(ERegressRecommendType type)
	{
		return ConfigRegressRecommendByType.GetConfigList((int)type, true);
	}

	// Token: 0x060092D8 RID: 37592 RVA: 0x001F8621 File Offset: 0x001F6821
	public IReadOnlyList<RegressRecommend> GetRegressRecommendByGroup(int groupId)
	{
		return ConfigRegressRecommendByActivityGroup.GetConfigList(groupId, true);
	}

	// Token: 0x060092D9 RID: 37593 RVA: 0x001F862C File Offset: 0x001F682C
	public RegressDisposableReward? GetRegressDisposableReward(int id)
	{
		RegressDisposableReward? config = ConfigRegressDisposableRewardById.GetConfig(id, true);
		if (config != null)
		{
			return new RegressDisposableReward?(config.Value);
		}
		return null;
	}

	// Token: 0x060092DA RID: 37594 RVA: 0x001F8660 File Offset: 0x001F6860
	public GachaRoleDevelopIns? GetGachaRoleDevelopIns(int id)
	{
		GachaRoleDevelopIns? config = ConfigGachaRoleDevelopInsById.GetConfig(id, true);
		if (config != null)
		{
			return new GachaRoleDevelopIns?(config.Value);
		}
		return null;
	}

	// Token: 0x060092DB RID: 37595 RVA: 0x001F8694 File Offset: 0x001F6894
	public IReadOnlyList<GachaRoleDevelopIns> GetGachaRoleDevelopInsByRoleId(int roleId)
	{
		return ConfigGachaRoleDevelopInsByRoleId.GetConfigList(roleId, true);
	}

	// Token: 0x060092DC RID: 37596 RVA: 0x001F86A0 File Offset: 0x001F68A0
	public GachaRoleDevelopIns? GetGachaRoleDevelopInsByDungeonId(int dungeon)
	{
		GachaRoleDevelopIns? config = ConfigGachaRoleDevelopInsByDungeonDetection.GetConfig(dungeon, true);
		if (config != null)
		{
			return new GachaRoleDevelopIns?(config.Value);
		}
		return null;
	}

	// Token: 0x060092DD RID: 37597 RVA: 0x001F86D4 File Offset: 0x001F68D4
	public IReadOnlyList<RegressTrialRole> GetTrialRoleAll()
	{
		return ConfigRegressTrialRoleAll.GetConfigList(true);
	}

	// Token: 0x060092DE RID: 37598 RVA: 0x001F86DC File Offset: 0x001F68DC
	[NullableContext(1)]
	public Dictionary<int, string> GetTrialRoleUnlockDesc()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		foreach (RegressTrialRole regressTrialRole in (this.GetTrialRoleAll() ?? new List<RegressTrialRole>()))
		{
			ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(regressTrialRole.ConditionGroup);
			if (conditionGroupConfig != null)
			{
				string hintText = conditionGroupConfig.Value.HintText;
				dictionary[regressTrialRole.TrialRoleGroupId] = hintText;
			}
		}
		return dictionary;
	}

	// Token: 0x17000CD3 RID: 3283
	// (get) Token: 0x060092DF RID: 37599 RVA: 0x001F8770 File Offset: 0x001F6970
	[Nullable(1)]
	public static ActivityRegressConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ActivityRegressConfig._Instance;
		}
	}

	// Token: 0x060092E0 RID: 37600 RVA: 0x001F8777 File Offset: 0x001F6977
	[NullableContext(1)]
	public static ActivityRegressConfig GetOrCreateInstance()
	{
		if (ActivityRegressConfig._Instance == null)
		{
			ActivityRegressConfig.CreateInstance();
		}
		return ActivityRegressConfig._Instance;
	}

	// Token: 0x060092E1 RID: 37601 RVA: 0x001F878B File Offset: 0x001F698B
	public static bool CreateInstance()
	{
		if (ActivityRegressConfig._Instance != null)
		{
			return true;
		}
		ActivityRegressConfig._Instance = new ActivityRegressConfig();
		return true;
	}

	// Token: 0x060092E2 RID: 37602 RVA: 0x001F87A1 File Offset: 0x001F69A1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060092E3 RID: 37603 RVA: 0x001F87A3 File Offset: 0x001F69A3
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressConfig._Instance = null;
	}

	// Token: 0x060092E4 RID: 37604 RVA: 0x001F87AB File Offset: 0x001F69AB
	static ActivityRegressConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressConfig.CreateStaticDefaultValue), new Action(ActivityRegressConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004106 RID: 16646
	private static ActivityRegressConfig _Instance;
}
