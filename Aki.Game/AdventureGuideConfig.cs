using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000B42 RID: 2882
[NullableContext(1)]
[Nullable(0)]
public class AdventureGuideConfig : ConfigBase
{
	// Token: 0x06007781 RID: 30593 RVA: 0x0024D4B3 File Offset: 0x0024B6B3
	public AdventureGuideConfig()
	{
		this.PreOpenDetectionMap = new Dictionary<int, List<PreOpenDetection>>();
		this.LevelPlayNightMareConfigMapping = new Dictionary<int, ILevelPlayNightMareConfigData>();
	}

	// Token: 0x06007782 RID: 30594 RVA: 0x0024D4D4 File Offset: 0x0024B6D4
	protected override bool OnInit()
	{
		IReadOnlyList<PreOpenDetection> preOpenDetectionConfAll = this.GetPreOpenDetectionConfAll();
		if (preOpenDetectionConfAll != null)
		{
			foreach (PreOpenDetection item in preOpenDetectionConfAll)
			{
				if (!this.PreOpenDetectionMap.ContainsKey(item.DetectionId))
				{
					this.PreOpenDetectionMap.Add(item.DetectionId, new List<PreOpenDetection>());
				}
				this.PreOpenDetectionMap[item.DetectionId].Add(item);
			}
		}
		IReadOnlyList<LevelPlayInfoMappingConfig> configList = ConfigLevelPlayInfoMappingConfigAll.GetConfigList(true);
		if (configList != null)
		{
			IReadOnlyList<LevelPlayInfoMappingConfig> readOnlyList = configList;
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				LevelPlayInfoMappingConfig levelPlayInfoMappingConfig = readOnlyList[i];
				if (levelPlayInfoMappingConfig.Type == 2)
				{
					LevelPlayNightMareConfigData levelPlayNightMareConfigData = Json.Decode<LevelPlayNightMareConfigData>(levelPlayInfoMappingConfig.Data, null);
					if (levelPlayNightMareConfigData != null && !this.LevelPlayNightMareConfigMapping.ContainsKey(levelPlayNightMareConfigData.LevelPlayId))
					{
						this.LevelPlayNightMareConfigMapping.Add(levelPlayNightMareConfigData.LevelPlayId, levelPlayNightMareConfigData);
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06007783 RID: 30595 RVA: 0x0024D5D8 File Offset: 0x0024B7D8
	public List<PreOpenDetection> GetPreOpenDetectionConfListByDetectionId(int detectionId, ESoundAreaDataType soundAreaDataType)
	{
		List<PreOpenDetection> list = new List<PreOpenDetection>();
		List<PreOpenDetection> list2;
		if (this.PreOpenDetectionMap.TryGetValue(detectionId, out list2))
		{
			foreach (PreOpenDetection item in list2)
			{
				if (item.SoundAreaType == (int)soundAreaDataType)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06007784 RID: 30596 RVA: 0x0024D648 File Offset: 0x0024B848
	public List<PreOpenDetection> GetPreOpenDetectionConfList(int detectionId, ESoundAreaDataType soundAreaDataType, int preOpenDetectionId)
	{
		List<PreOpenDetection> preOpenDetectionConfListByDetectionId = this.GetPreOpenDetectionConfListByDetectionId(detectionId, soundAreaDataType);
		if (preOpenDetectionConfListByDetectionId.Count == 0 && preOpenDetectionId != 0)
		{
			PreOpenDetection? preOpenDetectionConfById = this.GetPreOpenDetectionConfById(preOpenDetectionId);
			if (preOpenDetectionConfById != null)
			{
				preOpenDetectionConfListByDetectionId.Add(preOpenDetectionConfById.Value);
			}
		}
		return preOpenDetectionConfListByDetectionId;
	}

	// Token: 0x06007785 RID: 30597 RVA: 0x0024D688 File Offset: 0x0024B888
	public AdventureTask? GetAdventureTaskConfig(int taskId)
	{
		AdventureTask? config = ConfigAdventureTaskById.GetConfig(taskId, true);
		if (config != null)
		{
			return new AdventureTask?(config.Value);
		}
		return null;
	}

	// Token: 0x06007786 RID: 30598 RVA: 0x0024D6BC File Offset: 0x0024B8BC
	[NullableContext(2)]
	public IReadOnlyList<AdventureTask> GetAllAdventureTaskConfig()
	{
		IReadOnlyList<AdventureTask> configList = ConfigAdventureTaskAll.GetConfigList(true);
		if (configList != null)
		{
			return configList;
		}
		return null;
	}

	// Token: 0x06007787 RID: 30599 RVA: 0x0024D6D8 File Offset: 0x0024B8D8
	public Dictionary<int, int> GetDropShowInfo(int id)
	{
		DropPackage? config = ConfigDropPackageById.GetConfig(id, true);
		if (config != null)
		{
			return config.Value.DropPreview();
		}
		return new Dictionary<int, int>();
	}

	// Token: 0x06007788 RID: 30600 RVA: 0x0024D70C File Offset: 0x0024B90C
	public Dictionary<int, int> GetShowReward(Dictionary<int, int> showRewardMap, int? level = null)
	{
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		int num = 0;
		if (level != null)
		{
			if (!showRewardMap.TryGetValue(level.Value, out num))
			{
				for (int i = level.Value - 1; i >= 0; i--)
				{
					if (showRewardMap.TryGetValue(i, out num))
					{
						break;
					}
				}
			}
		}
		else if (!showRewardMap.TryGetValue(curWorldLevel, out num))
		{
			int num2 = curWorldLevel - 1;
			while (num2 >= 0 && !showRewardMap.TryGetValue(num2, out num))
			{
				num2--;
			}
		}
		if (num > 0)
		{
			DropPackage? config = ConfigDropPackageById.GetConfig(num, true);
			if (config != null)
			{
				return config.Value.DropPreview();
			}
		}
		int p0Id;
		if (showRewardMap.TryGetValue(1, out p0Id))
		{
			DropPackage? config2 = ConfigDropPackageById.GetConfig(p0Id, true);
			if (config2 != null)
			{
				return config2.Value.DropPreview();
			}
		}
		return new Dictionary<int, int>();
	}

	// Token: 0x06007789 RID: 30601 RVA: 0x0024D7E4 File Offset: 0x0024B9E4
	[NullableContext(2)]
	public Dictionary<int, int> GetNightMareShowReward(Dictionary<int, int> showRewardMap)
	{
		if (showRewardMap == null || showRewardMap.Count <= 0)
		{
			return null;
		}
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		int num = 0;
		if (!showRewardMap.TryGetValue(calabashLevel, out num))
		{
			int num2 = calabashLevel - 1;
			while (num2 >= 0 && !showRewardMap.TryGetValue(num2, out num))
			{
				num2--;
			}
		}
		if (num > 0)
		{
			DropPackage? config = ConfigDropPackageById.GetConfig(num, true);
			if (config != null)
			{
				return config.Value.DropPreview();
			}
		}
		int p0Id;
		if (showRewardMap.TryGetValue(1, out p0Id))
		{
			DropPackage? config2 = ConfigDropPackageById.GetConfig(p0Id, true);
			if (config2 != null)
			{
				return config2.Value.DropPreview();
			}
		}
		return null;
	}

	// Token: 0x0600778A RID: 30602 RVA: 0x0024D888 File Offset: 0x0024BA88
	public AdventureTaskChapter? GetChapterAdventureConfig(int chapter)
	{
		AdventureTaskChapter? config = ConfigAdventureTaskChapterById.GetConfig(chapter, true);
		if (config != null)
		{
			return new AdventureTaskChapter?(config.Value);
		}
		return null;
	}

	// Token: 0x0600778B RID: 30603 RVA: 0x0024D8BC File Offset: 0x0024BABC
	[NullableContext(2)]
	public IReadOnlyList<MonsterDetection> GetAllMonsterDetection()
	{
		IReadOnlyList<MonsterDetection> configList = ConfigMonsterDetectionAll.GetConfigList(true);
		if (configList != null)
		{
			return configList;
		}
		return null;
	}

	// Token: 0x0600778C RID: 30604 RVA: 0x0024D8D8 File Offset: 0x0024BAD8
	[NullableContext(2)]
	public IReadOnlyList<DungeonDetection> GetAllDungeonDetection()
	{
		IReadOnlyList<DungeonDetection> configList = ConfigDungeonDetectionAll.GetConfigList(true);
		if (configList != null)
		{
			return configList;
		}
		return null;
	}

	// Token: 0x0600778D RID: 30605 RVA: 0x0024D8F4 File Offset: 0x0024BAF4
	[NullableContext(2)]
	public IReadOnlyList<SilentAreaDetection> GetAllSilentAreaDetection()
	{
		IReadOnlyList<SilentAreaDetection> configList = ConfigSilentAreaDetectionAll.GetConfigList(true);
		if (configList != null)
		{
			return configList;
		}
		return null;
	}

	// Token: 0x0600778E RID: 30606 RVA: 0x0024D910 File Offset: 0x0024BB10
	public MonsterDetection? GetMonsterDetectionConfById(int id)
	{
		MonsterDetection? config = ConfigMonsterDetectionById.GetConfig(id, true);
		if (config != null)
		{
			return new MonsterDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x0600778F RID: 30607 RVA: 0x0024D944 File Offset: 0x0024BB44
	public DungeonDetection? GetDungeonDetectionConfById(int id)
	{
		DungeonDetection? config = ConfigDungeonDetectionById.GetConfig(id, true);
		if (config != null)
		{
			return new DungeonDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x06007790 RID: 30608 RVA: 0x0024D978 File Offset: 0x0024BB78
	public SilentAreaDetection? GetSilentAreaDetectionConfById(int id)
	{
		SilentAreaDetection? config = ConfigSilentAreaDetectionById.GetConfig(id, true);
		if (config != null)
		{
			return new SilentAreaDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x06007791 RID: 30609 RVA: 0x0024D9AC File Offset: 0x0024BBAC
	public int GetMaxChapter()
	{
		IReadOnlyList<AdventureTaskChapter> configList = ConfigAdventureTaskChapterAll.GetConfigList(true);
		if (configList == null)
		{
			return 0;
		}
		List<AdventureTaskChapter> list = new List<AdventureTaskChapter>(configList);
		list.Sort((AdventureTaskChapter a, AdventureTaskChapter b) => b.Id - a.Id);
		return list[0].Id;
	}

	// Token: 0x06007792 RID: 30610 RVA: 0x0024DA00 File Offset: 0x0024BC00
	public int GetMaxDungeonLevel(int enterId)
	{
		InstanceDungeonEntrance? config = ConfigInstanceDungeonEntranceById.GetConfig(enterId, true);
		if (config == null)
		{
			return 0;
		}
		int num = 0;
		int[] array = config.Value.InstanceDungeonList();
		for (int i = 0; i < array.Length; i++)
		{
			InstanceDungeon? config2 = ConfigInstanceDungeonById.GetConfig(array[i], true);
			if (config2 != null)
			{
				int num2 = config2.Value.DifficultyLevel()[config2.Value.DifficultyLevel().Length - 1];
				if (num2 > num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06007793 RID: 30611 RVA: 0x0024DA88 File Offset: 0x0024BC88
	public string GetSecondaryGuideDataTextById(int id)
	{
		SecondaryGuideData? config = ConfigSecondaryGuideDataById.GetConfig(id, true);
		if (config != null)
		{
			return config.Value.Text;
		}
		return "";
	}

	// Token: 0x06007794 RID: 30612 RVA: 0x0024DABC File Offset: 0x0024BCBC
	public SecondaryGuideData? GetSecondaryGuideDataConf(int id)
	{
		SecondaryGuideData? config = ConfigSecondaryGuideDataById.GetConfig(id, true);
		if (config != null)
		{
			return new SecondaryGuideData?(config.Value);
		}
		return null;
	}

	// Token: 0x06007795 RID: 30613 RVA: 0x0024DAF0 File Offset: 0x0024BCF0
	public string GetLocalFilterTextById(int id)
	{
		SecondaryGuideData? config = ConfigSecondaryGuideDataById.GetConfig(id, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.Text, null) ?? "";
		}
		return "";
	}

	// Token: 0x06007796 RID: 30614 RVA: 0x0024DB34 File Offset: 0x0024BD34
	public PreOpenDetection? GetPreOpenDetectionConfById(int detectionId)
	{
		PreOpenDetection? config = ConfigPreOpenDetectionById.GetConfig(detectionId, true);
		if (config != null)
		{
			return new PreOpenDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x06007797 RID: 30615 RVA: 0x0024DB68 File Offset: 0x0024BD68
	[NullableContext(2)]
	public IReadOnlyList<PreOpenDetection> GetPreOpenDetectionConfAll()
	{
		IReadOnlyList<PreOpenDetection> configList = ConfigPreOpenDetectionAll.GetConfigList(true);
		if (configList != null)
		{
			return configList;
		}
		return null;
	}

	// Token: 0x06007798 RID: 30616 RVA: 0x0024DB84 File Offset: 0x0024BD84
	public DetectionDropDownType? GetDropDownConfig(int type)
	{
		DetectionDropDownType? config = ConfigDetectionDropDownTypeById.GetConfig(type, true);
		if (config != null)
		{
			return new DetectionDropDownType?(config.Value);
		}
		return null;
	}

	// Token: 0x06007799 RID: 30617 RVA: 0x0024DBB8 File Offset: 0x0024BDB8
	[NullableContext(2)]
	public ILevelPlayNightMareConfigData GetLevelPlayNightMareConfig(int levelPlayNightMareId)
	{
		ILevelPlayNightMareConfigData result;
		if (this.LevelPlayNightMareConfigMapping.TryGetValue(levelPlayNightMareId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600779A RID: 30618 RVA: 0x0024DBD8 File Offset: 0x0024BDD8
	public DetectionTitlePanel? GetDetectionTitlePanelConfig(int detectionTitlePanelId)
	{
		DetectionTitlePanel? config = ConfigDetectionTitlePanelById.GetConfig(detectionTitlePanelId, true);
		if (config != null)
		{
			return new DetectionTitlePanel?(config.Value);
		}
		return null;
	}

	// Token: 0x17000DEC RID: 3564
	// (get) Token: 0x0600779B RID: 30619 RVA: 0x0024DC0C File Offset: 0x0024BE0C
	public static AdventureGuideConfig Instance
	{
		get
		{
			return AdventureGuideConfig._Instance;
		}
	}

	// Token: 0x0600779C RID: 30620 RVA: 0x0024DC13 File Offset: 0x0024BE13
	public static AdventureGuideConfig GetOrCreateInstance()
	{
		if (AdventureGuideConfig._Instance == null)
		{
			AdventureGuideConfig.CreateInstance();
		}
		return AdventureGuideConfig._Instance;
	}

	// Token: 0x0600779D RID: 30621 RVA: 0x0024DC27 File Offset: 0x0024BE27
	public static bool CreateInstance()
	{
		if (AdventureGuideConfig._Instance != null)
		{
			return true;
		}
		AdventureGuideConfig._Instance = new AdventureGuideConfig();
		return true;
	}

	// Token: 0x0600779E RID: 30622 RVA: 0x0024DC3D File Offset: 0x0024BE3D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600779F RID: 30623 RVA: 0x0024DC3F File Offset: 0x0024BE3F
	public static void ResetStaticDefaultValue()
	{
		AdventureGuideConfig._Instance = null;
	}

	// Token: 0x060077A0 RID: 30624 RVA: 0x0024DC47 File Offset: 0x0024BE47
	static AdventureGuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdventureGuideConfig.CreateStaticDefaultValue), new Action(AdventureGuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004AF4 RID: 19188
	private readonly Dictionary<int, List<PreOpenDetection>> PreOpenDetectionMap;

	// Token: 0x04004AF5 RID: 19189
	private readonly Dictionary<int, ILevelPlayNightMareConfigData> LevelPlayNightMareConfigMapping;

	// Token: 0x04004AF6 RID: 19190
	[Nullable(2)]
	private static AdventureGuideConfig _Instance;
}
