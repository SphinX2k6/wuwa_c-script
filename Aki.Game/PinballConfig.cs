using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020013EA RID: 5098
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PinballConfig : ConfigBase
{
	// Token: 0x06008FFD RID: 36861 RVA: 0x001F2685 File Offset: 0x001F0885
	public PinballActivity? GetPinballActivityConfigByActivityId(int activityId)
	{
		return ConfigPinballActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06008FFE RID: 36862 RVA: 0x001F268E File Offset: 0x001F088E
	public PinballRoleConfig? GetPinballRoleConfigById(int id)
	{
		return ConfigPinballRoleConfigById.GetConfig(id, true);
	}

	// Token: 0x06008FFF RID: 36863 RVA: 0x001F2698 File Offset: 0x001F0898
	public int[] GetPinballRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (PinballRoleConfig pinballRoleConfig in (ConfigPinballRoleConfigAll.GetConfigList(true) ?? Array.Empty<PinballRoleConfig>()))
		{
			list.Add(pinballRoleConfig.Id);
		}
		return list.ToArray();
	}

	// Token: 0x06009000 RID: 36864 RVA: 0x001F2700 File Offset: 0x001F0900
	public PinballChapterConfig? GetPinballChapterConfigById(int chapter)
	{
		return ConfigPinballChapterConfigById.GetConfig(chapter, true);
	}

	// Token: 0x06009001 RID: 36865 RVA: 0x001F2709 File Offset: 0x001F0909
	public PinballLevelConfig? GetPinballLevelConfigById(int id)
	{
		return ConfigPinballLevelConfigById.GetConfig(id, true);
	}

	// Token: 0x06009002 RID: 36866 RVA: 0x001F2712 File Offset: 0x001F0912
	public IReadOnlyList<PinballDailyConfig> GetAllPinballDailyConfigList()
	{
		return ConfigPinballDailyConfigAll.GetConfigList(true) ?? Array.Empty<PinballDailyConfig>();
	}

	// Token: 0x06009003 RID: 36867 RVA: 0x001F2723 File Offset: 0x001F0923
	public PinballLevelTarget? GetPinballLevelTargetConfigById(int targetId)
	{
		return ConfigPinballLevelTargetById.GetConfig(targetId, true);
	}

	// Token: 0x06009004 RID: 36868 RVA: 0x001F272C File Offset: 0x001F092C
	public PinballLevelConfig? GetPinballLevelConfigByRoleId(int roleId)
	{
		return ConfigPinballLevelConfigByShowRoleId.GetConfig(roleId, true);
	}

	// Token: 0x06009005 RID: 36869 RVA: 0x001F2735 File Offset: 0x001F0935
	public string CovertOptionIndexToText(int optionIndex)
	{
		switch (optionIndex)
		{
		case 0:
			return "A.";
		case 1:
			return "B.";
		case 2:
			return "C.";
		default:
			return "";
		}
	}

	// Token: 0x06009006 RID: 36870 RVA: 0x001F2762 File Offset: 0x001F0962
	public PinballBuffConfig? GetPinballBuffConfigById(int buffId)
	{
		return ConfigPinballBuffConfigById.GetConfig(buffId, true);
	}

	// Token: 0x06009007 RID: 36871 RVA: 0x001F276C File Offset: 0x001F096C
	public int[] GetPinballBroadcastBuffIdAll()
	{
		IEnumerable<PinballBuffConfig> configList = ConfigPinballBuffConfigAll.GetConfigList(true);
		List<int> list = new List<int>();
		foreach (PinballBuffConfig pinballBuffConfig in configList)
		{
			list.Add(pinballBuffConfig.BuffId);
		}
		return list.ToArray();
	}

	// Token: 0x06009008 RID: 36872 RVA: 0x001F27CC File Offset: 0x001F09CC
	public PinballWeaponConfig? GetPinballWeaponConfigById(int id)
	{
		return ConfigPinballWeaponConfigById.GetConfig(id, true);
	}

	// Token: 0x06009009 RID: 36873 RVA: 0x001F27D5 File Offset: 0x001F09D5
	public PinballMonster? GetPinballMonsterConfigById(int id)
	{
		return ConfigPinballMonsterById.GetConfig(id, true);
	}

	// Token: 0x0600900A RID: 36874 RVA: 0x001F27DE File Offset: 0x001F09DE
	public PinballMonsterType? GetPinballMonsterTypeConfigById(int id)
	{
		return ConfigPinballMonsterTypeById.GetConfig(id, true);
	}

	// Token: 0x0600900B RID: 36875 RVA: 0x001F27E7 File Offset: 0x001F09E7
	public PinballWeaponMainEntry? GetPinballWeaponMainEntryConfigById(int id)
	{
		return ConfigPinballWeaponMainEntryById.GetConfig(id, true);
	}

	// Token: 0x0600900C RID: 36876 RVA: 0x001F27F0 File Offset: 0x001F09F0
	public PinballWeaponSubEntry? GetPinballWeaponSubEntryConfigById(int id)
	{
		return ConfigPinballWeaponSubEntryById.GetConfig(id, true);
	}

	// Token: 0x0600900D RID: 36877 RVA: 0x001F27F9 File Offset: 0x001F09F9
	public PinballWeaponAttr? GetPinballWeaponAttrConfigById(int id)
	{
		return ConfigPinballWeaponAttrById.GetConfig(id, true);
	}

	// Token: 0x0600900E RID: 36878 RVA: 0x001F2802 File Offset: 0x001F0A02
	public PinballWeaponQuality? GetPinballWeaponQualityConfigById(int qualityId)
	{
		return ConfigPinballWeaponQualityById.GetConfig(qualityId, true);
	}

	// Token: 0x0600900F RID: 36879 RVA: 0x001F280C File Offset: 0x001F0A0C
	public PinballWeaponType? GetPinballWeaponTypeConfigById(int typeId)
	{
		PinballWeaponType? config = ConfigPinballWeaponTypeById.GetConfig(typeId, true);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x06009010 RID: 36880 RVA: 0x001F2838 File Offset: 0x001F0A38
	[NullableContext(2)]
	public string GetPinballWeaponTypeName(int typeId)
	{
		PinballWeaponType? config = ConfigPinballWeaponTypeById.GetConfig(typeId, true);
		if (config == null)
		{
			return null;
		}
		return config.Value.Name;
	}

	// Token: 0x06009011 RID: 36881 RVA: 0x001F2867 File Offset: 0x001F0A67
	public PinballBdConfig? GetPinballRoleBdConfigById(int bdId)
	{
		return ConfigPinballBdConfigById.GetConfig(bdId, true);
	}

	// Token: 0x06009012 RID: 36882 RVA: 0x001F2870 File Offset: 0x001F0A70
	[NullableContext(2)]
	public IReadOnlyList<PinballRoleConfig> GetPinballRoleConfigListByActivityId(int activityId)
	{
		return ConfigPinballRoleConfigByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x06009013 RID: 36883 RVA: 0x001F2879 File Offset: 0x001F0A79
	public PinballRoleLevelConfig? GetPinballRoleLevelConfigByGroupIdAndLevel(int groupId, int level)
	{
		return ConfigPinballRoleLevelConfigByGroupIdAndLevel.GetConfig(groupId, level, true);
	}

	// Token: 0x06009014 RID: 36884 RVA: 0x001F2883 File Offset: 0x001F0A83
	[NullableContext(2)]
	public IReadOnlyList<PinballRoleLevelConfig> GetPinballRoleLevelConfigListByGroupId(int groupId)
	{
		return ConfigPinballRoleLevelConfigByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x06009015 RID: 36885 RVA: 0x001F288C File Offset: 0x001F0A8C
	public PinballAttr? GetPinballRoleAttrConfigById(int id)
	{
		return ConfigPinballAttrById.GetConfig(id, true);
	}

	// Token: 0x06009016 RID: 36886 RVA: 0x001F2895 File Offset: 0x001F0A95
	public PinballPropertyIndex? GetPinballPropertyIndexConfigById(int id)
	{
		return ConfigPinballPropertyIndexById.GetConfig(id, true);
	}

	// Token: 0x06009017 RID: 36887 RVA: 0x001F289E File Offset: 0x001F0A9E
	public PinballClassConfig? GetPinballClassConfigById(int id)
	{
		return ConfigPinballClassConfigById.GetConfig(id, true);
	}

	// Token: 0x06009018 RID: 36888 RVA: 0x001F28A7 File Offset: 0x001F0AA7
	public PinballSkillDisplayConfig? GetPinballSkillDisplayConfigById(int id)
	{
		return ConfigPinballSkillDisplayConfigById.GetConfig(id, true);
	}

	// Token: 0x06009019 RID: 36889 RVA: 0x001F28B0 File Offset: 0x001F0AB0
	public PinballTask? GetPinballTaskConfigById(int id)
	{
		return ConfigPinballTaskById.GetConfig(id, true);
	}

	// Token: 0x0600901A RID: 36890 RVA: 0x001F28B9 File Offset: 0x001F0AB9
	public PinballRank? GetPinballRankConfigByTower(int towerLevel)
	{
		return ConfigPinballRankByTower.GetConfig(towerLevel, true);
	}

	// Token: 0x0600901B RID: 36891 RVA: 0x001F28C2 File Offset: 0x001F0AC2
	public PinballRank? GetPinballRankConfigById(int id)
	{
		return ConfigPinballRankById.GetConfig(id, true);
	}

	// Token: 0x0600901C RID: 36892 RVA: 0x001F28CB File Offset: 0x001F0ACB
	[NullableContext(2)]
	public IReadOnlyList<PinballRank> GetAllPinballRankConfigList()
	{
		return ConfigPinballRankAll.GetConfigList(true);
	}

	// Token: 0x0600901D RID: 36893 RVA: 0x001F28D3 File Offset: 0x001F0AD3
	public PinballBdConfig? GetPinballBdConfigById(int id)
	{
		return ConfigPinballBdConfigById.GetConfig(id, true);
	}

	// Token: 0x0600901E RID: 36894 RVA: 0x001F28DC File Offset: 0x001F0ADC
	[NullableContext(2)]
	public IReadOnlyList<PinballWaveConfig> GetPinballWaveConfigListByLevel(int level)
	{
		return ConfigPinballWaveConfigByLevel.GetConfigList(level, true);
	}

	// Token: 0x0600901F RID: 36895 RVA: 0x001F28E5 File Offset: 0x001F0AE5
	public PinballSpawnConfig? GetPinballSpawnConfigById(int id)
	{
		return ConfigPinballSpawnConfigById.GetConfig(id, true);
	}

	// Token: 0x06009020 RID: 36896 RVA: 0x001F28EE File Offset: 0x001F0AEE
	public PinballMonsterSkillDisplay? GetPinballMonsterSkillDisplayConfigById(int id)
	{
		return ConfigPinballMonsterSkillDisplayById.GetConfig(id, true);
	}

	// Token: 0x06009021 RID: 36897 RVA: 0x001F28F7 File Offset: 0x001F0AF7
	public PinballMonsterRiskType? GetPinballMonsterRiskTypeConfigById(int riskTypeId)
	{
		return ConfigPinballMonsterRiskTypeById.GetConfig(riskTypeId, true);
	}

	// Token: 0x06009022 RID: 36898 RVA: 0x001F2900 File Offset: 0x001F0B00
	public PinballAvgStyleConfig? GetPinballAvgStyleConfigById(int style)
	{
		return ConfigPinballAvgStyleConfigById.GetConfig(style, true);
	}

	// Token: 0x17000C09 RID: 3081
	// (get) Token: 0x06009023 RID: 36899 RVA: 0x001F2909 File Offset: 0x001F0B09
	public static PinballConfig Instance
	{
		get
		{
			return PinballConfig._Instance;
		}
	}

	// Token: 0x06009024 RID: 36900 RVA: 0x001F2910 File Offset: 0x001F0B10
	public static PinballConfig GetOrCreateInstance()
	{
		if (PinballConfig._Instance == null)
		{
			PinballConfig.CreateInstance();
		}
		return PinballConfig._Instance;
	}

	// Token: 0x06009025 RID: 36901 RVA: 0x001F2924 File Offset: 0x001F0B24
	public static bool CreateInstance()
	{
		if (PinballConfig._Instance != null)
		{
			return true;
		}
		PinballConfig._Instance = new PinballConfig();
		return true;
	}

	// Token: 0x06009026 RID: 36902 RVA: 0x001F293A File Offset: 0x001F0B3A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009027 RID: 36903 RVA: 0x001F293C File Offset: 0x001F0B3C
	public static void ResetStaticDefaultValue()
	{
		PinballConfig._Instance = null;
	}

	// Token: 0x06009028 RID: 36904 RVA: 0x001F2944 File Offset: 0x001F0B44
	static PinballConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballConfig.CreateStaticDefaultValue), new Action(PinballConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003FA9 RID: 16297
	[Nullable(2)]
	private static PinballConfig _Instance;
}
