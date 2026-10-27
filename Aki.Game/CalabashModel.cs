using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x0200173C RID: 5948
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class CalabashModel : ModelBase
{
	// Token: 0x0600ABDF RID: 43999 RVA: 0x00268420 File Offset: 0x00266620
	public CalabashModel()
	{
		this.UnlockTipsList = new List<VisionUnlockQualityData>();
	}

	// Token: 0x0600ABE0 RID: 44000 RVA: 0x00268434 File Offset: 0x00266634
	protected override bool OnInit()
	{
		this.DirectionalFusionTimeMax = ConfigCommonParamById.GetIntConfig("PhantomDirectRefiningWeekTimes").Value;
		this.DirectionalFusionTargetFetterGroup = 1;
		return true;
	}

	// Token: 0x0600ABE1 RID: 44001 RVA: 0x00268461 File Offset: 0x00266661
	private void InitCalabashInstance()
	{
		this.CalabashInstance = new CalabashInstance();
		this.InitCalabashDevelopRewardData();
		this.InitMonsterIdRecord();
	}

	// Token: 0x0600ABE2 RID: 44002 RVA: 0x0026847C File Offset: 0x0026667C
	private void InitCalabashDevelopRewardData()
	{
		IEnumerable<CalabashDevelopReward> calabashDevelopList = CalabashConfig.Instance.GetCalabashDevelopList();
		if (this.CalabashDevelopRewardDataMap == null)
		{
			this.CalabashDevelopRewardDataMap = new Dictionary<int, CalabashDevelopRewardData>();
		}
		foreach (CalabashDevelopReward developReward in calabashDevelopList)
		{
			Aki.Config.MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(developReward.MonsterInfoId);
			CalabashDevelopRewardData value = new CalabashDevelopRewardData(developReward, monsterInfoConfig.Value.Name);
			if (developReward.IsShow)
			{
				this.CalabashDevelopRewardDataMap[developReward.MonsterId] = value;
			}
		}
	}

	// Token: 0x0600ABE3 RID: 44003 RVA: 0x00268520 File Offset: 0x00266720
	public void UpdateCalabashDevelopRewardData()
	{
		foreach (KeyValuePair<int, List<ICalabashDevelopConditionState>> keyValuePair in this.GetUnlockCalabashDevelopRewards())
		{
			CalabashDevelopRewardData calabashDevelopRewardData = this.CalabashDevelopRewardDataMap[keyValuePair.Key];
			calabashDevelopRewardData.UnlockData = true;
			calabashDevelopRewardData.SetUnlockConditionMap(keyValuePair.Value);
			calabashDevelopRewardData.RewardNumData = keyValuePair.Value.Count;
		}
		EventSystem.Instance.Emit(EEventName.HasCalabashExp);
	}

	// Token: 0x0600ABE4 RID: 44004 RVA: 0x002685B4 File Offset: 0x002667B4
	public CalabashDevelopRewardData[] GetCalabashDevelopRewardSortData()
	{
		List<CalabashDevelopRewardData> list = new List<CalabashDevelopRewardData>();
		foreach (CalabashDevelopRewardData item in this.CalabashDevelopRewardDataMap.Values)
		{
			list.Add(item);
		}
		list.Sort(new Comparison<CalabashDevelopRewardData>(this.SortByDevelopRewardSortId));
		return list.ToArray();
	}

	// Token: 0x0600ABE5 RID: 44005 RVA: 0x0026862C File Offset: 0x0026682C
	private int SortByDevelopRewardSortId(CalabashDevelopRewardData a, CalabashDevelopRewardData b)
	{
		return a.DevelopReward.SortId - b.DevelopReward.SortId;
	}

	// Token: 0x0600ABE6 RID: 44006 RVA: 0x00268645 File Offset: 0x00266845
	public void SetCalabashInstanceBaseInfo(CalabashMsg baseInfo)
	{
		if (this.CalabashInstance == null)
		{
			this.InitCalabashInstance();
		}
		this.CalabashInstance.SetBaseInfo(baseInfo);
	}

	// Token: 0x0600ABE7 RID: 44007 RVA: 0x00268661 File Offset: 0x00266861
	public void SetCalabashInstanceConfigInfo(CalabashCfg configInfo)
	{
		if (this.CalabashInstance == null)
		{
			this.InitCalabashInstance();
		}
		this.CalabashInstance.SetConfigInfo(configInfo);
	}

	// Token: 0x0600ABE8 RID: 44008 RVA: 0x00268680 File Offset: 0x00266880
	public void InitMonsterIdRecord()
	{
		this.MonsterIdRecordList = (LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.CalabashCollect, null) ?? new List<int>());
		this.MonsterIdRecordSet = new HashSet<int>();
		foreach (int item in this.MonsterIdRecordList)
		{
			this.MonsterIdRecordSet.Add(item);
		}
	}

	// Token: 0x0600ABE9 RID: 44009 RVA: 0x002686FC File Offset: 0x002668FC
	public void SetCalabashLevel(int level)
	{
		this.CalabashInstance.CalabashCurrentLevel = level;
		EventSystem.Instance.Emit(EEventName.CalabashLevelUpdate);
	}

	// Token: 0x0600ABEA RID: 44010 RVA: 0x0026871A File Offset: 0x0026691A
	public int GetCalabashLevel()
	{
		return this.CalabashInstance.CalabashCurrentLevel;
	}

	// Token: 0x0600ABEB RID: 44011 RVA: 0x00268727 File Offset: 0x00266927
	public int GetCalabashMaxLevel()
	{
		return this.CalabashInstance.CalabashMaxLevel;
	}

	// Token: 0x0600ABEC RID: 44012 RVA: 0x00268734 File Offset: 0x00266934
	public int GetIdentifyGuaranteeCount()
	{
		return this.CalabashInstance.IdentifyGuaranteeCount;
	}

	// Token: 0x0600ABED RID: 44013 RVA: 0x00268741 File Offset: 0x00266941
	public int GetLowCostIdentifyGuaranteeCount()
	{
		return this.CalabashInstance.LowCostIdentifyGuaranteeCount;
	}

	// Token: 0x0600ABEE RID: 44014 RVA: 0x00268750 File Offset: 0x00266950
	public int GetLeftIntensifyCaptureGuarantee()
	{
		int calabashCurrentLevel = this.CalabashInstance.CalabashCurrentLevel;
		CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(calabashCurrentLevel);
		int num = (calabashConfigByLevel != null) ? calabashConfigByLevel.GetValueOrDefault().IntensifyCaptureGuarantee : 0;
		int identifyGuaranteeCount = this.GetIdentifyGuaranteeCount();
		return Math.Max(num - identifyGuaranteeCount, 0);
	}

	// Token: 0x0600ABEF RID: 44015 RVA: 0x002687A0 File Offset: 0x002669A0
	public int GetLeftLowCostIntensifyCaptureGuarantee()
	{
		int calabashCurrentLevel = this.CalabashInstance.CalabashCurrentLevel;
		CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(calabashCurrentLevel);
		int num = (calabashConfigByLevel != null) ? calabashConfigByLevel.GetValueOrDefault().IntensifyCaptureGuarantee : 0;
		int lowCostIdentifyGuaranteeCount = this.GetLowCostIdentifyGuaranteeCount();
		return Math.Max(num - lowCostIdentifyGuaranteeCount, 0);
	}

	// Token: 0x0600ABF0 RID: 44016 RVA: 0x002687EF File Offset: 0x002669EF
	public void SetCurrentExp(int curExp)
	{
		this.CalabashInstance.CalabashCurrentExp = curExp;
	}

	// Token: 0x0600ABF1 RID: 44017 RVA: 0x002687FD File Offset: 0x002669FD
	public int GetCurrentExp()
	{
		return this.CalabashInstance.CalabashCurrentExp;
	}

	// Token: 0x0600ABF2 RID: 44018 RVA: 0x0026880A File Offset: 0x00266A0A
	public void SetUnlockCalabashDevelopReward(CalabashDevelopInfo developReward)
	{
		this.CalabashInstance.SetUnlockCalabashDevelopReward(developReward);
	}

	// Token: 0x0600ABF3 RID: 44019 RVA: 0x00268818 File Offset: 0x00266A18
	public Dictionary<int, List<ICalabashDevelopConditionState>> GetUnlockCalabashDevelopRewards()
	{
		return this.CalabashInstance.GetUnlockCalabashDevelopRewards();
	}

	// Token: 0x0600ABF4 RID: 44020 RVA: 0x00268828 File Offset: 0x00266A28
	public bool CheckCalabashMonsterUnlocked(int monsterId)
	{
		CalabashDevelopRewardData calabashDevelopRewardData;
		return this.CalabashDevelopRewardDataMap.TryGetValue(monsterId, out calabashDevelopRewardData) && calabashDevelopRewardData.UnlockData;
	}

	// Token: 0x0600ABF5 RID: 44021 RVA: 0x0026884D File Offset: 0x00266A4D
	public string GetMonsterName(string id)
	{
		return "CalabashCatchGain_" + id;
	}

	// Token: 0x0600ABF6 RID: 44022 RVA: 0x0026885C File Offset: 0x00266A5C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public ICalabashDevelopRewardInfoData[] GetCalabashDevelopRewardInfoData(int id)
	{
		CalabashDevelopRewardData calabashDevelopRewardData;
		if (!this.CalabashDevelopRewardDataMap.TryGetValue(id, out calabashDevelopRewardData))
		{
			return null;
		}
		List<ICalabashDevelopRewardInfoData> list = new List<ICalabashDevelopRewardInfoData>();
		foreach (int id2 in calabashDevelopRewardData.DevelopReward.DevelopCondition())
		{
			CalabashDevelopCondition calabashConditionById = CalabashConfig.Instance.GetCalabashConditionById(id2);
			bool flag;
			bool isUnlock = calabashDevelopRewardData.GetUnlockConditionMap().TryGetValue(calabashConditionById.Id, out flag) > false;
			CalabashDevelopRewardInfoData item = new CalabashDevelopRewardInfoData
			{
				IsUnlock = isUnlock,
				Info = calabashConditionById.Description,
				Num = CalabashConfig.Instance.GetCalabashConditionRewardExp(calabashConditionById)
			};
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600ABF7 RID: 44023 RVA: 0x00268904 File Offset: 0x00266B04
	public unsafe int GetCalabashDevelopRewardExpByMonsterId(int monsterId)
	{
		int num = 0;
		CalabashDevelopRewardData calabashDevelopRewardData;
		if (!this.CalabashDevelopRewardDataMap.TryGetValue(monsterId, out calabashDevelopRewardData))
		{
			return num;
		}
		Span<int> developConditionBytes = calabashDevelopRewardData.DevelopReward.GetDevelopConditionBytes();
		for (int i = 0; i < developConditionBytes.Length; i++)
		{
			int id = *developConditionBytes[i];
			CalabashDevelopCondition calabashConditionById = CalabashConfig.Instance.GetCalabashConditionById(id);
			bool flag;
			if (calabashDevelopRewardData.GetUnlockConditionMap().TryGetValue(calabashConditionById.Id, out flag) && flag)
			{
				num += CalabashConfig.Instance.GetCalabashConditionRewardExp(calabashConditionById);
			}
		}
		return num;
	}

	// Token: 0x0600ABF8 RID: 44024 RVA: 0x00268988 File Offset: 0x00266B88
	public int GetCalabashAllSchedule()
	{
		int num = 0;
		foreach (CalabashDevelopRewardData calabashDevelopRewardData in this.CalabashDevelopRewardDataMap.Values)
		{
			num += calabashDevelopRewardData.RewardSumNumData;
		}
		return num;
	}

	// Token: 0x0600ABF9 RID: 44025 RVA: 0x002689E8 File Offset: 0x00266BE8
	public int GetCalabashOwnSchedule()
	{
		int num = 0;
		foreach (CalabashDevelopRewardData calabashDevelopRewardData in this.CalabashDevelopRewardDataMap.Values)
		{
			num += calabashDevelopRewardData.UnlockSize;
		}
		return num;
	}

	// Token: 0x17000E5E RID: 3678
	// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x00268A48 File Offset: 0x00266C48
	// (set) Token: 0x0600ABFB RID: 44027 RVA: 0x00268A50 File Offset: 0x00266C50
	public CalabashInstance CalabashInstance
	{
		get
		{
			return this.CalabashInstanceInternal;
		}
		set
		{
			this.CalabashInstanceInternal = value;
		}
	}

	// Token: 0x17000E5F RID: 3679
	// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x00268A59 File Offset: 0x00266C59
	public List<VisionUnlockQualityData> CalabashUnlockTipsList
	{
		get
		{
			return this.UnlockTipsList;
		}
	}

	// Token: 0x0600ABFD RID: 44029 RVA: 0x00268A64 File Offset: 0x00266C64
	public void AddCalabashUnlockTipsList(int monsterItemId, int unlockQuality)
	{
		VisionUnlockQualityData visionUnlockQualityData = new VisionUnlockQualityData();
		visionUnlockQualityData.MonsterItemId = monsterItemId;
		visionUnlockQualityData.UnlockQuality = unlockQuality;
		this.UnlockTipsList.Add(visionUnlockQualityData);
	}

	// Token: 0x0600ABFE RID: 44030 RVA: 0x00268A91 File Offset: 0x00266C91
	public void SetCalabashLevelsReward(List<int> levelList)
	{
		this.CalabashInstance.SetRewardedLevelsSet(levelList);
		EventSystem.Instance.Emit(EEventName.GetCalabashReward);
	}

	// Token: 0x0600ABFF RID: 44031 RVA: 0x00268AB0 File Offset: 0x00266CB0
	public int GetCurrentExpByLevel(int level)
	{
		if (level < this.CalabashInstance.CalabashCurrentLevel)
		{
			return CalabashConfig.Instance.GetCalabashConfigByLevel(level).Value.LevelUpExp;
		}
		if (level == this.CalabashInstance.CalabashCurrentLevel)
		{
			return this.CalabashInstance.CalabashCurrentExp;
		}
		return 0;
	}

	// Token: 0x0600AC00 RID: 44032 RVA: 0x00268B04 File Offset: 0x00266D04
	public int GetMaxExpByLevel(int level)
	{
		return CalabashConfig.Instance.GetCalabashConfigByLevel(level).Value.LevelUpExp;
	}

	// Token: 0x0600AC01 RID: 44033 RVA: 0x00268B2C File Offset: 0x00266D2C
	public ECalabashRewardState GetReceiveRewardStateByLevel(int level)
	{
		if (level == 0)
		{
			return ECalabashRewardState.None;
		}
		if (this.CalabashInstance.IsRewardedByLevel(level))
		{
			return ECalabashRewardState.HasReceived;
		}
		if (level > this.CalabashInstance.CalabashCurrentLevel)
		{
			return ECalabashRewardState.CantReceive;
		}
		return ECalabashRewardState.CanReceive;
	}

	// Token: 0x0600AC02 RID: 44034 RVA: 0x00268B54 File Offset: 0x00266D54
	public bool IsLimitToLevelUp(int level)
	{
		if (level != this.CalabashInstance.CalabashCurrentLevel)
		{
			return false;
		}
		CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(level);
		return this.CalabashInstance.CalabashCurrentExp >= calabashConfigByLevel.Value.LevelUpExp;
	}

	// Token: 0x0600AC03 RID: 44035 RVA: 0x00268B9C File Offset: 0x00266D9C
	public int GetCatchGainByLevel(int level)
	{
		return this.CalabashInstance.GetCatchGainByLevel(level).GetValueOrDefault();
	}

	// Token: 0x0600AC04 RID: 44036 RVA: 0x00268BC0 File Offset: 0x00266DC0
	public bool CheckCanReceiveReward()
	{
		if (this.CalabashInstance == null)
		{
			return false;
		}
		for (int i = 1; i <= this.CalabashInstance.CalabashCurrentLevel; i++)
		{
			if (this.GetReceiveRewardStateByLevel(i) == ECalabashRewardState.CanReceive)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600AC05 RID: 44037 RVA: 0x00268BFA File Offset: 0x00266DFA
	public bool RecordMonsterId(int monsterId)
	{
		HashSet<int> monsterIdRecordSet = this.MonsterIdRecordSet;
		if (monsterIdRecordSet != null && monsterIdRecordSet.Add(monsterId))
		{
			List<int> monsterIdRecordList = this.MonsterIdRecordList;
			if (monsterIdRecordList != null)
			{
				monsterIdRecordList.Add(monsterId);
			}
			LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.CalabashCollect, this.MonsterIdRecordList);
			return true;
		}
		return false;
	}

	// Token: 0x0600AC06 RID: 44038 RVA: 0x00268C34 File Offset: 0x00266E34
	public bool CheckMonsterIdInRecord(int monsterId)
	{
		return this.MonsterIdRecordSet.Contains(monsterId);
	}

	// Token: 0x0600AC07 RID: 44039 RVA: 0x00268C44 File Offset: 0x00266E44
	public void CheckSimpleStateSave()
	{
		if (LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.CalabashCollectIsSimpleDetail, null) == null)
		{
			this.SaveIfSimpleState(true);
		}
	}

	// Token: 0x0600AC08 RID: 44040 RVA: 0x00268C74 File Offset: 0x00266E74
	public bool GetIfSimpleState()
	{
		return LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.CalabashCollectIsSimpleDetail, null).GetValueOrDefault();
	}

	// Token: 0x0600AC09 RID: 44041 RVA: 0x00268C9C File Offset: 0x00266E9C
	public void SaveIfSimpleState(bool state)
	{
		bool? player = LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.CalabashCollectIsSimpleDetail, null);
		if (player != null)
		{
			bool? flag = player;
			if (flag.GetValueOrDefault() == state & flag != null)
			{
				return;
			}
		}
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.CalabashCollectIsSimpleDetail, state);
		EventSystem.Instance.Emit(EEventName.ChangeCalabashCollectSimplyState);
	}

	// Token: 0x0600AC0A RID: 44042 RVA: 0x00268CF8 File Offset: 0x00266EF8
	public UiDynamicTab[] GetViewTabList()
	{
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.CalabashRootView);
		if (this.OnlyShowBattleFettersTab)
		{
			List<UiDynamicTab> list = new List<UiDynamicTab>();
			foreach (UiDynamicTab item in viewTabList)
			{
				if (item.ChildViewName == EUiTabViewName.PhantomBattleFettersTabView.ToString())
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}
		List<UiDynamicTab> list2 = new List<UiDynamicTab>();
		foreach (UiDynamicTab item2 in viewTabList)
		{
			if (FunctionModel.Instance.IsOpen(item2.FunctionId))
			{
				list2.Add(item2);
			}
		}
		return list2.ToArray();
	}

	// Token: 0x0600AC0B RID: 44043 RVA: 0x00268DF0 File Offset: 0x00266FF0
	public PhantomFetterGroup[] GetPhantomFetterGroupList()
	{
		if (!this.OnlyShowBattleFettersTab)
		{
			return ConfigCommon.ToList<PhantomFetterGroup>(PhantomBattleConfig.Instance.GetPhantomFetterGroupList()).ToArray();
		}
		List<PhantomFetterGroup> list = new List<PhantomFetterGroup>();
		int[] array = this.OnlyShowPhantomFetterGroupIdList ?? new int[0];
		for (int i = 0; i < array.Length; i++)
		{
			PhantomFetterGroup? config = ConfigPhantomFetterGroupById.GetConfig(array[i], true);
			if (config != null)
			{
				list.Add(config.Value);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600AC0C RID: 44044 RVA: 0x00268E65 File Offset: 0x00267065
	public void GmClearData()
	{
		this.UnlockTipsList.Clear();
	}

	// Token: 0x0600AC0D RID: 44045 RVA: 0x00268E74 File Offset: 0x00267074
	public int[] GetVisionRefineRecommendAttributes(int cost, int fetter)
	{
		IReadOnlyList<RefineRecommend> configList = ConfigRefineRecommendByCost.GetConfigList(cost, true);
		if (configList.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "获取洗炼推荐配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cost", cost);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new int[0];
		}
		foreach (RefineRecommend refineRecommend in configList)
		{
			if (refineRecommend.FetterArray().Contains(fetter))
			{
				return refineRecommend.PropertyArray().ToArray<int>();
			}
		}
		return new int[0];
	}

	// Token: 0x0600AC0E RID: 44046 RVA: 0x00268F24 File Offset: 0x00267124
	public void ClearOnlyShowData()
	{
		this.OnlyShowBattleFettersTab = false;
		this.OnlyMonsterCostShowMaxLevel = null;
	}

	// Token: 0x0600AC0F RID: 44047 RVA: 0x00268F39 File Offset: 0x00267139
	public void SetDirectionalFusionTargetFetter(int fetterId)
	{
		this.DirectionalFusionTargetFetterGroup = fetterId;
		EventSystem.Instance.Emit(EEventName.SelectDirectionalFusionTarget);
	}

	// Token: 0x17000E60 RID: 3680
	// (get) Token: 0x0600AC10 RID: 44048 RVA: 0x00268F52 File Offset: 0x00267152
	public static CalabashModel Instance
	{
		get
		{
			return CalabashModel._Instance;
		}
	}

	// Token: 0x0600AC11 RID: 44049 RVA: 0x00268F59 File Offset: 0x00267159
	public static CalabashModel GetOrCreateInstance()
	{
		if (CalabashModel._Instance == null)
		{
			CalabashModel.CreateInstance();
		}
		return CalabashModel._Instance;
	}

	// Token: 0x0600AC12 RID: 44050 RVA: 0x00268F6D File Offset: 0x0026716D
	public static bool CreateInstance()
	{
		if (CalabashModel._Instance != null)
		{
			return true;
		}
		CalabashModel._Instance = new CalabashModel();
		return true;
	}

	// Token: 0x0600AC13 RID: 44051 RVA: 0x00268F83 File Offset: 0x00267183
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AC14 RID: 44052 RVA: 0x00268F85 File Offset: 0x00267185
	public static void ResetStaticDefaultValue()
	{
		CalabashModel._Instance = null;
	}

	// Token: 0x0600AC15 RID: 44053 RVA: 0x00268F8D File Offset: 0x0026718D
	static CalabashModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashModel.CreateStaticDefaultValue), new Action(CalabashModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004E03 RID: 19971
	public bool OnlyShowBattleFettersTab;

	// Token: 0x04004E04 RID: 19972
	public int? OnlyMonsterCostShowMaxLevel;

	// Token: 0x04004E05 RID: 19973
	[Nullable(2)]
	public int[] OnlyShowPhantomFetterGroupIdList;

	// Token: 0x04004E06 RID: 19974
	[Nullable(2)]
	private CalabashInstance CalabashInstanceInternal;

	// Token: 0x04004E07 RID: 19975
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, CalabashDevelopRewardData> CalabashDevelopRewardDataMap;

	// Token: 0x04004E08 RID: 19976
	[Nullable(2)]
	private HashSet<int> MonsterIdRecordSet;

	// Token: 0x04004E09 RID: 19977
	[Nullable(2)]
	private List<int> MonsterIdRecordList;

	// Token: 0x04004E0A RID: 19978
	public bool HideVisionRecoveryConfirmBox;

	// Token: 0x04004E0B RID: 19979
	public bool IsNeedRefineSubConfirmBox;

	// Token: 0x04004E0C RID: 19980
	public int DirectionalFusionTime;

	// Token: 0x04004E0D RID: 19981
	public int DirectionalFusionTimeMax;

	// Token: 0x04004E0E RID: 19982
	public int DirectionalFusionTargetFetterGroup;

	// Token: 0x04004E0F RID: 19983
	private readonly List<VisionUnlockQualityData> UnlockTipsList;

	// Token: 0x04004E10 RID: 19984
	[Nullable(2)]
	private static CalabashModel _Instance;
}
