using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200168A RID: 5770
[NullableContext(1)]
[Nullable(0)]
public class AdventureGuideConfig : ConfigBase
{
	// Token: 0x0600A3A3 RID: 41891 RVA: 0x0024344B File Offset: 0x0024164B
	public AdventureGuideConfig()
	{
		this.PreOpenDetectionMap = new Dictionary<int, List<PreOpenDetection>>();
		this.LevelPlayNightMareConfigMapping = new Dictionary<int, ILevelPlayNightMareConfigData>();
	}

	// Token: 0x0600A3A4 RID: 41892 RVA: 0x0024346C File Offset: 0x0024166C
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

	// Token: 0x0600A3A5 RID: 41893 RVA: 0x00243570 File Offset: 0x00241770
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

	// Token: 0x0600A3A6 RID: 41894 RVA: 0x002435E0 File Offset: 0x002417E0
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

	// Token: 0x0600A3A7 RID: 41895 RVA: 0x00243620 File Offset: 0x00241820
	public AdventureTask? GetAdventureTaskConfig(int taskId)
	{
		AdventureTask? config = ConfigAdventureTaskById.GetConfig(taskId, true);
		if (config != null)
		{
			return new AdventureTask?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3A8 RID: 41896 RVA: 0x00243654 File Offset: 0x00241854
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

	// Token: 0x0600A3A9 RID: 41897 RVA: 0x00243670 File Offset: 0x00241870
	public Dictionary<int, int> GetDropShowInfo(int id)
	{
		DropPackage? config = ConfigDropPackageById.GetConfig(id, true);
		if (config != null)
		{
			return config.Value.DropPreview();
		}
		return new Dictionary<int, int>();
	}

	// Token: 0x0600A3AA RID: 41898 RVA: 0x002436A4 File Offset: 0x002418A4
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

	// Token: 0x0600A3AB RID: 41899 RVA: 0x0024377C File Offset: 0x0024197C
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

	// Token: 0x0600A3AC RID: 41900 RVA: 0x00243820 File Offset: 0x00241A20
	public AdventureTaskChapter? GetChapterAdventureConfig(int chapter)
	{
		AdventureTaskChapter? config = ConfigAdventureTaskChapterById.GetConfig(chapter, true);
		if (config != null)
		{
			return new AdventureTaskChapter?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3AD RID: 41901 RVA: 0x00243854 File Offset: 0x00241A54
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

	// Token: 0x0600A3AE RID: 41902 RVA: 0x00243870 File Offset: 0x00241A70
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

	// Token: 0x0600A3AF RID: 41903 RVA: 0x0024388C File Offset: 0x00241A8C
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

	// Token: 0x0600A3B0 RID: 41904 RVA: 0x002438A8 File Offset: 0x00241AA8
	public MonsterDetection? GetMonsterDetectionConfById(int id)
	{
		MonsterDetection? config = ConfigMonsterDetectionById.GetConfig(id, true);
		if (config != null)
		{
			return new MonsterDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3B1 RID: 41905 RVA: 0x002438DC File Offset: 0x00241ADC
	public DungeonDetection? GetDungeonDetectionConfById(int id)
	{
		DungeonDetection? config = ConfigDungeonDetectionById.GetConfig(id, true);
		if (config != null)
		{
			return new DungeonDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3B2 RID: 41906 RVA: 0x00243910 File Offset: 0x00241B10
	public SilentAreaDetection? GetSilentAreaDetectionConfById(int id)
	{
		SilentAreaDetection? config = ConfigSilentAreaDetectionById.GetConfig(id, true);
		if (config != null)
		{
			return new SilentAreaDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3B3 RID: 41907 RVA: 0x00243944 File Offset: 0x00241B44
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

	// Token: 0x0600A3B4 RID: 41908 RVA: 0x00243998 File Offset: 0x00241B98
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

	// Token: 0x0600A3B5 RID: 41909 RVA: 0x00243A20 File Offset: 0x00241C20
	public string GetSecondaryGuideDataTextById(int id)
	{
		SecondaryGuideData? config = ConfigSecondaryGuideDataById.GetConfig(id, true);
		if (config != null)
		{
			return config.Value.Text;
		}
		return "";
	}

	// Token: 0x0600A3B6 RID: 41910 RVA: 0x00243A54 File Offset: 0x00241C54
	public SecondaryGuideData? GetSecondaryGuideDataConf(int id)
	{
		SecondaryGuideData? config = ConfigSecondaryGuideDataById.GetConfig(id, true);
		if (config != null)
		{
			return new SecondaryGuideData?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3B7 RID: 41911 RVA: 0x00243A88 File Offset: 0x00241C88
	public string GetLocalFilterTextById(int id)
	{
		SecondaryGuideData? config = ConfigSecondaryGuideDataById.GetConfig(id, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.Text, null) ?? "";
		}
		return "";
	}

	// Token: 0x0600A3B8 RID: 41912 RVA: 0x00243ACC File Offset: 0x00241CCC
	public PreOpenDetection? GetPreOpenDetectionConfById(int detectionId)
	{
		PreOpenDetection? config = ConfigPreOpenDetectionById.GetConfig(detectionId, true);
		if (config != null)
		{
			return new PreOpenDetection?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3B9 RID: 41913 RVA: 0x00243B00 File Offset: 0x00241D00
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

	// Token: 0x0600A3BA RID: 41914 RVA: 0x00243B1C File Offset: 0x00241D1C
	public DetectionDropDownType? GetDropDownConfig(int type)
	{
		DetectionDropDownType? config = ConfigDetectionDropDownTypeById.GetConfig(type, true);
		if (config != null)
		{
			return new DetectionDropDownType?(config.Value);
		}
		return null;
	}

	// Token: 0x0600A3BB RID: 41915 RVA: 0x00243B50 File Offset: 0x00241D50
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

	// Token: 0x0600A3BC RID: 41916 RVA: 0x00243B70 File Offset: 0x00241D70
	public DetectionTitlePanel? GetDetectionTitlePanelConfig(int detectionTitlePanelId)
	{
		DetectionTitlePanel? config = ConfigDetectionTitlePanelById.GetConfig(detectionTitlePanelId, true);
		if (config != null)
		{
			return new DetectionTitlePanel?(config.Value);
		}
		return null;
	}

	// Token: 0x17000DCB RID: 3531
	// (get) Token: 0x0600A3BD RID: 41917 RVA: 0x00243BA4 File Offset: 0x00241DA4
	public static AdventureGuideConfig Instance
	{
		get
		{
			return AdventureGuideConfig._Instance;
		}
	}

	// Token: 0x0600A3BE RID: 41918 RVA: 0x00243BAB File Offset: 0x00241DAB
	public static AdventureGuideConfig GetOrCreateInstance()
	{
		if (AdventureGuideConfig._Instance == null)
		{
			AdventureGuideConfig.CreateInstance();
		}
		return AdventureGuideConfig._Instance;
	}

	// Token: 0x0600A3BF RID: 41919 RVA: 0x00243BBF File Offset: 0x00241DBF
	public static bool CreateInstance()
	{
		if (AdventureGuideConfig._Instance != null)
		{
			return true;
		}
		AdventureGuideConfig._Instance = new AdventureGuideConfig();
		return true;
	}

	// Token: 0x0600A3C0 RID: 41920 RVA: 0x00243BD5 File Offset: 0x00241DD5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A3C1 RID: 41921 RVA: 0x00243BD7 File Offset: 0x00241DD7
	public static void ResetStaticDefaultValue()
	{
		AdventureGuideConfig._Instance = null;
	}

	// Token: 0x0600A3C2 RID: 41922 RVA: 0x00243BDF File Offset: 0x00241DDF
	static AdventureGuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdventureGuideConfig.CreateStaticDefaultValue), new Action(AdventureGuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004A4D RID: 19021
	private readonly Dictionary<int, List<PreOpenDetection>> PreOpenDetectionMap;

	// Token: 0x04004A4E RID: 19022
	private readonly Dictionary<int, ILevelPlayNightMareConfigData> LevelPlayNightMareConfigMapping;

	// Token: 0x04004A4F RID: 19023
	[Nullable(2)]
	private static AdventureGuideConfig _Instance;
}
