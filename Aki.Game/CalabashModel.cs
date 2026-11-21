using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02000BF5 RID: 3061
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class CalabashModel : ModelBase
{
	// Token: 0x06007FC6 RID: 32710 RVA: 0x00272834 File Offset: 0x00270A34
	public CalabashModel()
	{
		this.UnlockTipsList = new List<VisionUnlockQualityData>();
	}

	// Token: 0x06007FC7 RID: 32711 RVA: 0x00272848 File Offset: 0x00270A48
	protected override bool OnInit()
	{
		this.DirectionalFusionTimeMax = ConfigCommonParamById.GetIntConfig("PhantomDirectRefiningWeekTimes").Value;
		this.DirectionalFusionTargetFetterGroup = 1;
		return true;
	}

	// Token: 0x06007FC8 RID: 32712 RVA: 0x00272875 File Offset: 0x00270A75
	private void InitCalabashInstance()
	{
		this.CalabashInstance = new CalabashInstance();
		this.InitCalabashDevelopRewardData();
		this.InitMonsterIdRecord();
	}

	// Token: 0x06007FC9 RID: 32713 RVA: 0x00272890 File Offset: 0x00270A90
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

	// Token: 0x06007FCA RID: 32714 RVA: 0x00272934 File Offset: 0x00270B34
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

	// Token: 0x06007FCB RID: 32715 RVA: 0x002729C8 File Offset: 0x00270BC8
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

	// Token: 0x06007FCC RID: 32716 RVA: 0x00272A40 File Offset: 0x00270C40
	private int SortByDevelopRewardSortId(CalabashDevelopRewardData a, CalabashDevelopRewardData b)
	{
		return a.DevelopReward.SortId - b.DevelopReward.SortId;
	}

	// Token: 0x06007FCD RID: 32717 RVA: 0x00272A59 File Offset: 0x00270C59
	public void SetCalabashInstanceBaseInfo(CalabashMsg baseInfo)
	{
		if (this.CalabashInstance == null)
		{
			this.InitCalabashInstance();
		}
		this.CalabashInstance.SetBaseInfo(baseInfo);
	}

	// Token: 0x06007FCE RID: 32718 RVA: 0x00272A75 File Offset: 0x00270C75
	public void SetCalabashInstanceConfigInfo(CalabashCfg configInfo)
	{
		if (this.CalabashInstance == null)
		{
			this.InitCalabashInstance();
		}
		this.CalabashInstance.SetConfigInfo(configInfo);
	}

	// Token: 0x06007FCF RID: 32719 RVA: 0x00272A94 File Offset: 0x00270C94
	public void InitMonsterIdRecord()
	{
		this.MonsterIdRecordList = (LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.CalabashCollect, null) ?? new List<int>());
		this.MonsterIdRecordSet = new HashSet<int>();
		foreach (int item in this.MonsterIdRecordList)
		{
			this.MonsterIdRecordSet.Add(item);
		}
	}

	// Token: 0x06007FD0 RID: 32720 RVA: 0x00272B10 File Offset: 0x00270D10
	public void SetCalabashLevel(int level)
	{
		this.CalabashInstance.CalabashCurrentLevel = level;
		EventSystem.Instance.Emit(EEventName.CalabashLevelUpdate);
	}

	// Token: 0x06007FD1 RID: 32721 RVA: 0x00272B2E File Offset: 0x00270D2E
	public int GetCalabashLevel()
	{
		return this.CalabashInstance.CalabashCurrentLevel;
	}

	// Token: 0x06007FD2 RID: 32722 RVA: 0x00272B3B File Offset: 0x00270D3B
	public int GetCalabashMaxLevel()
	{
		return this.CalabashInstance.CalabashMaxLevel;
	}

	// Token: 0x06007FD3 RID: 32723 RVA: 0x00272B48 File Offset: 0x00270D48
	public int GetIdentifyGuaranteeCount()
	{
		return this.CalabashInstance.IdentifyGuaranteeCount;
	}

	// Token: 0x06007FD4 RID: 32724 RVA: 0x00272B55 File Offset: 0x00270D55
	public int GetLowCostIdentifyGuaranteeCount()
	{
		return this.CalabashInstance.LowCostIdentifyGuaranteeCount;
	}

	// Token: 0x06007FD5 RID: 32725 RVA: 0x00272B64 File Offset: 0x00270D64
	public int GetLeftIntensifyCaptureGuarantee()
	{
		int calabashCurrentLevel = this.CalabashInstance.CalabashCurrentLevel;
		CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(calabashCurrentLevel);
		int num = (calabashConfigByLevel != null) ? calabashConfigByLevel.GetValueOrDefault().IntensifyCaptureGuarantee : 0;
		int identifyGuaranteeCount = this.GetIdentifyGuaranteeCount();
		return Math.Max(num - identifyGuaranteeCount, 0);
	}

	// Token: 0x06007FD6 RID: 32726 RVA: 0x00272BB4 File Offset: 0x00270DB4
	public int GetLeftLowCostIntensifyCaptureGuarantee()
	{
		int calabashCurrentLevel = this.CalabashInstance.CalabashCurrentLevel;
		CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(calabashCurrentLevel);
		int num = (calabashConfigByLevel != null) ? calabashConfigByLevel.GetValueOrDefault().LowCostIntensifyCaptureGuarantee : 0;
		int lowCostIdentifyGuaranteeCount = this.GetLowCostIdentifyGuaranteeCount();
		return Math.Max(num - lowCostIdentifyGuaranteeCount, 0);
	}

	// Token: 0x06007FD7 RID: 32727 RVA: 0x00272C03 File Offset: 0x00270E03
	public void SetCurrentExp(int curExp)
	{
		this.CalabashInstance.CalabashCurrentExp = curExp;
	}

	// Token: 0x06007FD8 RID: 32728 RVA: 0x00272C11 File Offset: 0x00270E11
	public int GetCurrentExp()
	{
		return this.CalabashInstance.CalabashCurrentExp;
	}

	// Token: 0x06007FD9 RID: 32729 RVA: 0x00272C1E File Offset: 0x00270E1E
	public void SetUnlockCalabashDevelopReward(CalabashDevelopInfo developReward)
	{
		this.CalabashInstance.SetUnlockCalabashDevelopReward(developReward);
	}

	// Token: 0x06007FDA RID: 32730 RVA: 0x00272C2C File Offset: 0x00270E2C
	public Dictionary<int, List<ICalabashDevelopConditionState>> GetUnlockCalabashDevelopRewards()
	{
		return this.CalabashInstance.GetUnlockCalabashDevelopRewards();
	}

	// Token: 0x06007FDB RID: 32731 RVA: 0x00272C3C File Offset: 0x00270E3C
	public bool CheckCalabashMonsterUnlocked(int monsterId)
	{
		CalabashDevelopRewardData calabashDevelopRewardData;
		return this.CalabashDevelopRewardDataMap.TryGetValue(monsterId, out calabashDevelopRewardData) && calabashDevelopRewardData.UnlockData;
	}

	// Token: 0x06007FDC RID: 32732 RVA: 0x00272C61 File Offset: 0x00270E61
	public string GetMonsterName(string id)
	{
		return "CalabashCatchGain_" + id;
	}

	// Token: 0x06007FDD RID: 32733 RVA: 0x00272C70 File Offset: 0x00270E70
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

	// Token: 0x06007FDE RID: 32734 RVA: 0x00272D18 File Offset: 0x00270F18
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

	// Token: 0x06007FDF RID: 32735 RVA: 0x00272D9C File Offset: 0x00270F9C
	public int GetCalabashAllSchedule()
	{
		int num = 0;
		foreach (CalabashDevelopRewardData calabashDevelopRewardData in this.CalabashDevelopRewardDataMap.Values)
		{
			num += calabashDevelopRewardData.RewardSumNumData;
		}
		return num;
	}

	// Token: 0x06007FE0 RID: 32736 RVA: 0x00272DFC File Offset: 0x00270FFC
	public int GetCalabashOwnSchedule()
	{
		int num = 0;
		foreach (CalabashDevelopRewardData calabashDevelopRewardData in this.CalabashDevelopRewardDataMap.Values)
		{
			num += calabashDevelopRewardData.UnlockSize;
		}
		return num;
	}

	// Token: 0x17000E81 RID: 3713
	// (get) Token: 0x06007FE1 RID: 32737 RVA: 0x00272E5C File Offset: 0x0027105C
	// (set) Token: 0x06007FE2 RID: 32738 RVA: 0x00272E64 File Offset: 0x00271064
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

	// Token: 0x17000E82 RID: 3714
	// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x00272E6D File Offset: 0x0027106D
	public List<VisionUnlockQualityData> CalabashUnlockTipsList
	{
		get
		{
			return this.UnlockTipsList;
		}
	}

	// Token: 0x06007FE4 RID: 32740 RVA: 0x00272E78 File Offset: 0x00271078
	public void AddCalabashUnlockTipsList(int monsterItemId, int unlockQuality)
	{
		VisionUnlockQualityData visionUnlockQualityData = new VisionUnlockQualityData();
		visionUnlockQualityData.MonsterItemId = monsterItemId;
		visionUnlockQualityData.UnlockQuality = unlockQuality;
		this.UnlockTipsList.Add(visionUnlockQualityData);
	}

	// Token: 0x06007FE5 RID: 32741 RVA: 0x00272EA5 File Offset: 0x002710A5
	public void SetCalabashLevelsReward(List<int> levelList)
	{
		this.CalabashInstance.SetRewardedLevelsSet(levelList);
		EventSystem.Instance.Emit(EEventName.GetCalabashReward);
	}

	// Token: 0x06007FE6 RID: 32742 RVA: 0x00272EC4 File Offset: 0x002710C4
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

	// Token: 0x06007FE7 RID: 32743 RVA: 0x00272F18 File Offset: 0x00271118
	public int GetMaxExpByLevel(int level)
	{
		return CalabashConfig.Instance.GetCalabashConfigByLevel(level).Value.LevelUpExp;
	}

	// Token: 0x06007FE8 RID: 32744 RVA: 0x00272F40 File Offset: 0x00271140
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

	// Token: 0x06007FE9 RID: 32745 RVA: 0x00272F68 File Offset: 0x00271168
	public bool IsLimitToLevelUp(int level)
	{
		if (level != this.CalabashInstance.CalabashCurrentLevel)
		{
			return false;
		}
		CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(level);
		return this.CalabashInstance.CalabashCurrentExp >= calabashConfigByLevel.Value.LevelUpExp;
	}

	// Token: 0x06007FEA RID: 32746 RVA: 0x00272FB0 File Offset: 0x002711B0
	public int GetCatchGainByLevel(int level)
	{
		return this.CalabashInstance.GetCatchGainByLevel(level).GetValueOrDefault();
	}

	// Token: 0x06007FEB RID: 32747 RVA: 0x00272FD4 File Offset: 0x002711D4
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

	// Token: 0x06007FEC RID: 32748 RVA: 0x0027300E File Offset: 0x0027120E
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

	// Token: 0x06007FED RID: 32749 RVA: 0x00273048 File Offset: 0x00271248
	public bool CheckMonsterIdInRecord(int monsterId)
	{
		return this.MonsterIdRecordSet.Contains(monsterId);
	}

	// Token: 0x06007FEE RID: 32750 RVA: 0x00273058 File Offset: 0x00271258
	public void CheckSimpleStateSave()
	{
		if (LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.CalabashCollectIsSimpleDetail, null) == null)
		{
			this.SaveIfSimpleState(true);
		}
	}

	// Token: 0x06007FEF RID: 32751 RVA: 0x00273088 File Offset: 0x00271288
	public bool GetIfSimpleState()
	{
		return LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.CalabashCollectIsSimpleDetail, null).GetValueOrDefault();
	}

	// Token: 0x06007FF0 RID: 32752 RVA: 0x002730B0 File Offset: 0x002712B0
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

	// Token: 0x06007FF1 RID: 32753 RVA: 0x0027310C File Offset: 0x0027130C
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

	// Token: 0x06007FF2 RID: 32754 RVA: 0x00273204 File Offset: 0x00271404
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

	// Token: 0x06007FF3 RID: 32755 RVA: 0x00273279 File Offset: 0x00271479
	public void GmClearData()
	{
		this.UnlockTipsList.Clear();
	}

	// Token: 0x06007FF4 RID: 32756 RVA: 0x00273288 File Offset: 0x00271488
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
			if (Array.IndexOf<int>(refineRecommend.FetterArray(), fetter) >= 0)
			{
				int[] array = refineRecommend.PropertyArray();
				int[] array2 = new int[array.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = array[i];
				}
				return array2;
			}
		}
		return new int[0];
	}

	// Token: 0x06007FF5 RID: 32757 RVA: 0x00273360 File Offset: 0x00271560
	public void ClearOnlyShowData()
	{
		this.OnlyShowBattleFettersTab = false;
		this.OnlyMonsterCostShowMaxLevel = null;
	}

	// Token: 0x06007FF6 RID: 32758 RVA: 0x00273375 File Offset: 0x00271575
	public void SetDirectionalFusionTargetFetter(int fetterId)
	{
		this.DirectionalFusionTargetFetterGroup = fetterId;
		EventSystem.Instance.Emit(EEventName.SelectDirectionalFusionTarget);
	}

	// Token: 0x17000E83 RID: 3715
	// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x0027338E File Offset: 0x0027158E
	public static CalabashModel Instance
	{
		get
		{
			return CalabashModel._Instance;
		}
	}

	// Token: 0x06007FF8 RID: 32760 RVA: 0x00273395 File Offset: 0x00271595
	public static CalabashModel GetOrCreateInstance()
	{
		if (CalabashModel._Instance == null)
		{
			CalabashModel.CreateInstance();
		}
		return CalabashModel._Instance;
	}

	// Token: 0x06007FF9 RID: 32761 RVA: 0x002733A9 File Offset: 0x002715A9
	public static bool CreateInstance()
	{
		if (CalabashModel._Instance != null)
		{
			return true;
		}
		CalabashModel._Instance = new CalabashModel();
		return true;
	}

	// Token: 0x06007FFA RID: 32762 RVA: 0x002733BF File Offset: 0x002715BF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007FFB RID: 32763 RVA: 0x002733C1 File Offset: 0x002715C1
	public static void ResetStaticDefaultValue()
	{
		CalabashModel._Instance = null;
	}

	// Token: 0x06007FFC RID: 32764 RVA: 0x002733C9 File Offset: 0x002715C9
	static CalabashModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashModel.CreateStaticDefaultValue), new Action(CalabashModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004EAC RID: 20140
	public bool OnlyShowBattleFettersTab;

	// Token: 0x04004EAD RID: 20141
	public int? OnlyMonsterCostShowMaxLevel;

	// Token: 0x04004EAE RID: 20142
	[Nullable(2)]
	public int[] OnlyShowPhantomFetterGroupIdList;

	// Token: 0x04004EAF RID: 20143
	[Nullable(2)]
	private CalabashInstance CalabashInstanceInternal;

	// Token: 0x04004EB0 RID: 20144
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, CalabashDevelopRewardData> CalabashDevelopRewardDataMap;

	// Token: 0x04004EB1 RID: 20145
	[Nullable(2)]
	private HashSet<int> MonsterIdRecordSet;

	// Token: 0x04004EB2 RID: 20146
	[Nullable(2)]
	private List<int> MonsterIdRecordList;

	// Token: 0x04004EB3 RID: 20147
	public bool HideVisionRecoveryConfirmBox;

	// Token: 0x04004EB4 RID: 20148
	public bool IsNeedRefineSubConfirmBox;

	// Token: 0x04004EB5 RID: 20149
	public int DirectionalFusionTime;

	// Token: 0x04004EB6 RID: 20150
	public int DirectionalFusionTimeMax;

	// Token: 0x04004EB7 RID: 20151
	public int DirectionalFusionTargetFetterGroup;

	// Token: 0x04004EB8 RID: 20152
	private readonly List<VisionUnlockQualityData> UnlockTipsList;

	// Token: 0x04004EB9 RID: 20153
	[Nullable(2)]
	private static CalabashModel _Instance;
}
