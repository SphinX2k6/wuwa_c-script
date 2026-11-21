using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Launcher.NetworkDetection;

// Token: 0x02000901 RID: 2305
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ActivityRegressConfig : ConfigBase
{
	// Token: 0x0600665C RID: 26204 RVA: 0x00200AE4 File Offset: 0x001FECE4
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

	// Token: 0x0600665D RID: 26205 RVA: 0x00200BB4 File Offset: 0x001FEDB4
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

	// Token: 0x0600665E RID: 26206 RVA: 0x00200C54 File Offset: 0x001FEE54
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

	// Token: 0x0600665F RID: 26207 RVA: 0x00200CD0 File Offset: 0x001FEED0
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

	// Token: 0x06006660 RID: 26208 RVA: 0x00200D28 File Offset: 0x001FEF28
	public RegressQuest? GetRegressQuestConfig(int taskId)
	{
		RegressQuest? config = ConfigRegressQuestById.GetConfig(taskId, true);
		if (config != null)
		{
			return new RegressQuest?(config.Value);
		}
		return null;
	}

	// Token: 0x06006661 RID: 26209 RVA: 0x00200D5C File Offset: 0x001FEF5C
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

	// Token: 0x06006662 RID: 26210 RVA: 0x00200DC8 File Offset: 0x001FEFC8
	[NullableContext(0)]
	public ValueTuple<RegressEntry?, RegressEntry?> GetRegressRoleEntryConfigTuple()
	{
		List<RegressEntry?> sortedOpenRegressEntryConfigList = this.GetSortedOpenRegressEntryConfigList();
		return new ValueTuple<RegressEntry?, RegressEntry?>(sortedOpenRegressEntryConfigList[0], sortedOpenRegressEntryConfigList[1]);
	}

	// Token: 0x06006663 RID: 26211 RVA: 0x00200DF0 File Offset: 0x001FEFF0
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

	// Token: 0x06006664 RID: 26212 RVA: 0x00200E80 File Offset: 0x001FF080
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

	// Token: 0x06006665 RID: 26213 RVA: 0x00200EFC File Offset: 0x001FF0FC
	public RegressEntry? GetRegressEntrySingleConfigByType(EActivityRegressEntranceType entryType)
	{
		List<RegressEntry> regressEntryConfigByType = this.GetRegressEntryConfigByType(entryType);
		if (regressEntryConfigByType == null || regressEntryConfigByType.Count == 0)
		{
			return null;
		}
		return new RegressEntry?(regressEntryConfigByType[0]);
	}

	// Token: 0x06006666 RID: 26214 RVA: 0x00200F34 File Offset: 0x001FF134
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
		return new List<RegressEntry>(configList);
	}

	// Token: 0x06006667 RID: 26215 RVA: 0x00200FC0 File Offset: 0x001FF1C0
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

	// Token: 0x06006668 RID: 26216 RVA: 0x002010B0 File Offset: 0x001FF2B0
	public RegressDoubleDrop? GetDoubleDropConfig(ERegressGrade grade)
	{
		RegressDoubleDrop? config = ConfigRegressDoubleDropByGrade.GetConfig((int)grade, true);
		if (config != null)
		{
			return new RegressDoubleDrop?(config.Value);
		}
		return null;
	}

	// Token: 0x06006669 RID: 26217 RVA: 0x002010E4 File Offset: 0x001FF2E4
	public ConditionGroup? GetConditionGroup(int conditionId)
	{
		ConditionGroup? config = ConfigConditionGroupById.GetConfig(conditionId, true);
		if (config != null)
		{
			return new ConditionGroup?(config.Value);
		}
		return null;
	}

	// Token: 0x0600666A RID: 26218 RVA: 0x00201118 File Offset: 0x001FF318
	public RegressRecommend? GetRegressRecommend(int id)
	{
		RegressRecommend? config = ConfigRegressRecommendById.GetConfig(id, true);
		if (config != null)
		{
			return new RegressRecommend?(config.Value);
		}
		return null;
	}

	// Token: 0x0600666B RID: 26219 RVA: 0x0020114C File Offset: 0x001FF34C
	public IReadOnlyList<RegressRecommend> GetAllRegressRecommend()
	{
		return ConfigRegressRecommendAll.GetConfigList(true);
	}

	// Token: 0x0600666C RID: 26220 RVA: 0x00201154 File Offset: 0x001FF354
	public IReadOnlyList<RegressRecommend> GetRegressRecommendByType(ERegressRecommendType type)
	{
		return ConfigRegressRecommendByType.GetConfigList((int)type, true);
	}

	// Token: 0x0600666D RID: 26221 RVA: 0x0020115D File Offset: 0x001FF35D
	public IReadOnlyList<RegressRecommend> GetRegressRecommendByGroup(int groupId)
	{
		return ConfigRegressRecommendByActivityGroup.GetConfigList(groupId, true);
	}

	// Token: 0x0600666E RID: 26222 RVA: 0x00201168 File Offset: 0x001FF368
	public RegressDisposableReward? GetRegressDisposableReward(int id)
	{
		RegressDisposableReward? config = ConfigRegressDisposableRewardById.GetConfig(id, true);
		if (config != null)
		{
			return new RegressDisposableReward?(config.Value);
		}
		return null;
	}

	// Token: 0x0600666F RID: 26223 RVA: 0x0020119C File Offset: 0x001FF39C
	public GachaRoleDevelopIns? GetGachaRoleDevelopIns(int id)
	{
		GachaRoleDevelopIns? config = ConfigGachaRoleDevelopInsById.GetConfig(id, true);
		if (config != null)
		{
			return new GachaRoleDevelopIns?(config.Value);
		}
		return null;
	}

	// Token: 0x06006670 RID: 26224 RVA: 0x002011D0 File Offset: 0x001FF3D0
	public IReadOnlyList<GachaRoleDevelopIns> GetGachaRoleDevelopInsByRoleId(int roleId)
	{
		return ConfigGachaRoleDevelopInsByRoleId.GetConfigList(roleId, true);
	}

	// Token: 0x06006671 RID: 26225 RVA: 0x002011DC File Offset: 0x001FF3DC
	public GachaRoleDevelopIns? GetGachaRoleDevelopInsByDungeonId(int dungeon)
	{
		GachaRoleDevelopIns? config = ConfigGachaRoleDevelopInsByDungeonDetection.GetConfig(dungeon, true);
		if (config != null)
		{
			return new GachaRoleDevelopIns?(config.Value);
		}
		return null;
	}

	// Token: 0x06006672 RID: 26226 RVA: 0x00201210 File Offset: 0x001FF410
	public IReadOnlyList<RegressTrialRole> GetTrialRoleAll()
	{
		return ConfigRegressTrialRoleAll.GetConfigList(true);
	}

	// Token: 0x06006673 RID: 26227 RVA: 0x00201218 File Offset: 0x001FF418
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

	// Token: 0x17000CF3 RID: 3315
	// (get) Token: 0x06006674 RID: 26228 RVA: 0x002012AC File Offset: 0x001FF4AC
	[Nullable(1)]
	public static ActivityRegressConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ActivityRegressConfig._Instance;
		}
	}

	// Token: 0x06006675 RID: 26229 RVA: 0x002012B3 File Offset: 0x001FF4B3
	[NullableContext(1)]
	public static ActivityRegressConfig GetOrCreateInstance()
	{
		if (ActivityRegressConfig._Instance == null)
		{
			ActivityRegressConfig.CreateInstance();
		}
		return ActivityRegressConfig._Instance;
	}

	// Token: 0x06006676 RID: 26230 RVA: 0x002012C7 File Offset: 0x001FF4C7
	public static bool CreateInstance()
	{
		if (ActivityRegressConfig._Instance != null)
		{
			return true;
		}
		ActivityRegressConfig._Instance = new ActivityRegressConfig();
		return true;
	}

	// Token: 0x06006677 RID: 26231 RVA: 0x002012DD File Offset: 0x001FF4DD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006678 RID: 26232 RVA: 0x002012DF File Offset: 0x001FF4DF
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressConfig._Instance = null;
	}

	// Token: 0x06006679 RID: 26233 RVA: 0x002012E7 File Offset: 0x001FF4E7
	static ActivityRegressConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressConfig.CreateStaticDefaultValue), new Action(ActivityRegressConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400419E RID: 16798
	private static ActivityRegressConfig _Instance;
}
