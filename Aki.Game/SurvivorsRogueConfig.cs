using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020020FB RID: 8443
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SurvivorsRogueConfig : ConfigBase
{
	// Token: 0x06014B36 RID: 84790 RVA: 0x00607CAD File Offset: 0x00605EAD
	public SurvivorsActivityConfig? GetSurvivorsActivityConfigByActivityId(int activityId)
	{
		return ConfigSurvivorsActivityConfigByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06014B37 RID: 84791 RVA: 0x00607CB8 File Offset: 0x00605EB8
	public IReadOnlyList<SurvivorsLevel> GetAllSurvivorsLevelByActId(int actId)
	{
		IReadOnlyList<SurvivorsLevel> configList = ConfigSurvivorsLevelByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsLevel>();
	}

	// Token: 0x06014B38 RID: 84792 RVA: 0x00607CD7 File Offset: 0x00605ED7
	public SurvivorsLevel? GetSurvivorsLevel(int levelId)
	{
		return ConfigSurvivorsLevelById.GetConfig(levelId, true);
	}

	// Token: 0x06014B39 RID: 84793 RVA: 0x00607CE0 File Offset: 0x00605EE0
	public int GetMaxWaveNumByLevelId(int levelId)
	{
		IReadOnlyList<SurvivorsWave> configList = ConfigSurvivorsWaveByLevel.GetConfigList(levelId, true);
		if (configList == null)
		{
			return 0;
		}
		return configList.Count;
	}

	// Token: 0x06014B3A RID: 84794 RVA: 0x00607D00 File Offset: 0x00605F00
	public int GetWaveDuration(int levelId, int waveId)
	{
		IReadOnlyList<SurvivorsWave> configList = ConfigSurvivorsWaveByLevel.GetConfigList(levelId, true);
		if (configList == null)
		{
			return 0;
		}
		for (int i = 0; i < configList.Count; i++)
		{
			SurvivorsWave survivorsWave = configList[i];
			if (survivorsWave.Wave == waveId)
			{
				return survivorsWave.WaveTime;
			}
		}
		return 0;
	}

	// Token: 0x06014B3B RID: 84795 RVA: 0x00607D48 File Offset: 0x00605F48
	public int GetWaveType(int levelId, int waveId)
	{
		IReadOnlyList<SurvivorsWave> configList = ConfigSurvivorsWaveByLevel.GetConfigList(levelId, true);
		if (configList == null)
		{
			return 0;
		}
		for (int i = 0; i < configList.Count; i++)
		{
			SurvivorsWave survivorsWave = configList[i];
			if (survivorsWave.Wave == waveId)
			{
				return survivorsWave.WaveType;
			}
		}
		return 0;
	}

	// Token: 0x06014B3C RID: 84796 RVA: 0x00607D90 File Offset: 0x00605F90
	public bool IsBonusWave(int levelId, int waveId)
	{
		IReadOnlyList<SurvivorsWave> configList = ConfigSurvivorsWaveByLevel.GetConfigList(levelId, true);
		if (configList == null)
		{
			return false;
		}
		for (int i = 0; i < configList.Count; i++)
		{
			SurvivorsWave survivorsWave = configList[i];
			if (survivorsWave.Wave == waveId)
			{
				return survivorsWave.TreasurePoolLength > 0;
			}
		}
		return false;
	}

	// Token: 0x06014B3D RID: 84797 RVA: 0x00607DDC File Offset: 0x00605FDC
	public bool IsBoss(int templateId)
	{
		SurvivorsMonsterType? config = ConfigSurvivorsMonsterTypeByTemplateId.GetConfig(templateId, true);
		return config != null && config.Value.RiskType == 3;
	}

	// Token: 0x06014B3E RID: 84798 RVA: 0x00607E10 File Offset: 0x00606010
	public IReadOnlyList<SurvivorsRole> GetAllSurvivorsRoleByActId(int actId)
	{
		IReadOnlyList<SurvivorsRole> configList = ConfigSurvivorsRoleByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsRole>();
	}

	// Token: 0x06014B3F RID: 84799 RVA: 0x00607E2F File Offset: 0x0060602F
	public SurvivorsRole? GetSurvivorsRole(int roleId)
	{
		return ConfigSurvivorsRoleById.GetConfig(roleId, true);
	}

	// Token: 0x06014B40 RID: 84800 RVA: 0x00607E38 File Offset: 0x00606038
	public SurvivorsRoleLv? GetSurvivorsRoleLv(int lvId)
	{
		return ConfigSurvivorsRoleLvById.GetConfig(lvId, true);
	}

	// Token: 0x06014B41 RID: 84801 RVA: 0x00607E44 File Offset: 0x00606044
	public IReadOnlyList<SurvivorsRoleLv> GetSurvivorsRoleLvListByRoleId(int roleId)
	{
		IReadOnlyList<SurvivorsRoleLv> configList = ConfigSurvivorsRoleLvByRoleId.GetConfigList(roleId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsRoleLv>();
	}

	// Token: 0x06014B42 RID: 84802 RVA: 0x00607E63 File Offset: 0x00606063
	public SurvivorsRoleEvolve? GetSurvivorsRoleEvolve(int evolveId)
	{
		return ConfigSurvivorsRoleEvolveById.GetConfig(evolveId, true);
	}

	// Token: 0x06014B43 RID: 84803 RVA: 0x00607E6C File Offset: 0x0060606C
	public SurvivorsRoleEvolve? GetSurvivorsRoleDefaultEvolve(int roleId)
	{
		SurvivorsRole? survivorsRole = this.GetSurvivorsRole(roleId);
		if (survivorsRole == null)
		{
			return null;
		}
		int num = 0;
		int num2 = int.MaxValue;
		for (int i = 0; i < survivorsRole.Value.EvolveIdsLength; i++)
		{
			DicIntInt? dicIntInt = survivorsRole.Value.EvolveIds(i);
			if (dicIntInt != null && dicIntInt.Value.Value <= num2)
			{
				num2 = dicIntInt.Value.Value;
				num = dicIntInt.Value.Key;
			}
		}
		if (num == 0)
		{
			return null;
		}
		return this.GetSurvivorsRoleEvolve(num);
	}

	// Token: 0x06014B44 RID: 84804 RVA: 0x00607F24 File Offset: 0x00606124
	public IReadOnlyList<SurvivorsWeapon> GetAllSurvivorsWeaponByActId(int actId)
	{
		IReadOnlyList<SurvivorsWeapon> configList = ConfigSurvivorsWeaponByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsWeapon>();
	}

	// Token: 0x06014B45 RID: 84805 RVA: 0x00607F43 File Offset: 0x00606143
	public SurvivorsWeapon? GetSurvivorsWeapon(int weaponId)
	{
		return ConfigSurvivorsWeaponById.GetConfig(weaponId, true);
	}

	// Token: 0x06014B46 RID: 84806 RVA: 0x00607F4C File Offset: 0x0060614C
	public SurvivorsWeaponEvolve? GetSurvivorsWeaponDefaultEvolve(int weaponId)
	{
		SurvivorsWeapon? survivorsWeapon = this.GetSurvivorsWeapon(weaponId);
		if (survivorsWeapon == null)
		{
			return null;
		}
		int num = 0;
		int num2 = int.MaxValue;
		for (int i = 0; i < survivorsWeapon.Value.EvolveIdsLength; i++)
		{
			DicIntInt? dicIntInt = survivorsWeapon.Value.EvolveIds(i);
			if (dicIntInt != null && dicIntInt.Value.Value <= num2)
			{
				num2 = dicIntInt.Value.Value;
				num = dicIntInt.Value.Key;
			}
		}
		if (num == 0)
		{
			return null;
		}
		return this.GetSurvivorsWeaponEvolve(num);
	}

	// Token: 0x06014B47 RID: 84807 RVA: 0x00608001 File Offset: 0x00606201
	public SurvivorsWeaponLv? GetSurvivorsWeaponLv(int lvId)
	{
		return ConfigSurvivorsWeaponLvById.GetConfig(lvId, true);
	}

	// Token: 0x06014B48 RID: 84808 RVA: 0x0060800C File Offset: 0x0060620C
	public IReadOnlyList<SurvivorsWeaponLv> GetSurvivorsWeaponLvListByWeaponId(int weaponId)
	{
		IReadOnlyList<SurvivorsWeaponLv> configList = ConfigSurvivorsWeaponLvByWeaponId.GetConfigList(weaponId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsWeaponLv>();
	}

	// Token: 0x06014B49 RID: 84809 RVA: 0x0060802B File Offset: 0x0060622B
	public SurvivorsWeaponEvolve? GetSurvivorsWeaponEvolve(int evolveId)
	{
		return ConfigSurvivorsWeaponEvolveById.GetConfig(evolveId, true);
	}

	// Token: 0x06014B4A RID: 84810 RVA: 0x00608034 File Offset: 0x00606234
	public IReadOnlyList<SurvivorsTalentTree> GetAllTalentTreeNodeByActId(int actId)
	{
		IReadOnlyList<SurvivorsTalentTree> configList = ConfigSurvivorsTalentTreeByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsTalentTree>();
	}

	// Token: 0x06014B4B RID: 84811 RVA: 0x00608053 File Offset: 0x00606253
	public SurvivorsTalentTree? GetTalentTreeNode(int nodeId)
	{
		return ConfigSurvivorsTalentTreeById.GetConfig(nodeId, true);
	}

	// Token: 0x06014B4C RID: 84812 RVA: 0x0060805C File Offset: 0x0060625C
	public SurvivorsTalentEffect? GetTalentTreeEffect(int effectId)
	{
		return ConfigSurvivorsTalentEffectById.GetConfig(effectId, true);
	}

	// Token: 0x06014B4D RID: 84813 RVA: 0x00608068 File Offset: 0x00606268
	public IReadOnlyList<SurvivorsItem> GetAllSurvivorsItemByActId(int actId)
	{
		IReadOnlyList<SurvivorsItem> configList = ConfigSurvivorsItemByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsItem>();
	}

	// Token: 0x06014B4E RID: 84814 RVA: 0x00608087 File Offset: 0x00606287
	public SurvivorsItem? GetSurvivorsItem(int weaponId)
	{
		return ConfigSurvivorsItemById.GetConfig(weaponId, true);
	}

	// Token: 0x06014B4F RID: 84815 RVA: 0x00608090 File Offset: 0x00606290
	public SurvivorsQuality? GetQualityConfig(int qualityId)
	{
		return ConfigSurvivorsQualityById.GetConfig(qualityId, true);
	}

	// Token: 0x06014B50 RID: 84816 RVA: 0x00608099 File Offset: 0x00606299
	public SurvivorsProperty? GetPropertyConfig(int propertyId)
	{
		return ConfigSurvivorsPropertyById.GetConfig(propertyId, true);
	}

	// Token: 0x06014B51 RID: 84817 RVA: 0x006080A2 File Offset: 0x006062A2
	[NullableContext(2)]
	public IReadOnlyList<SkillGameplayButton> GetSkillButtonConfigByType(int type)
	{
		return ConfigSkillGameplayButtonByGameplayType.GetConfigList(type, true);
	}

	// Token: 0x06014B52 RID: 84818 RVA: 0x006080AC File Offset: 0x006062AC
	public SurvivorsCombo? GetComboConfig(int levelId)
	{
		SurvivorsLevel? survivorsLevel = this.GetSurvivorsLevel(levelId);
		if (survivorsLevel == null)
		{
			return null;
		}
		return ConfigSurvivorsComboById.GetConfig(survivorsLevel.Value.ComboCfgId, true);
	}

	// Token: 0x06014B53 RID: 84819 RVA: 0x006080E9 File Offset: 0x006062E9
	public SurvivorsTask? GetSurvivorsTask(int taskId)
	{
		return ConfigSurvivorsTaskById.GetConfig(taskId, true);
	}

	// Token: 0x06014B54 RID: 84820 RVA: 0x006080F4 File Offset: 0x006062F4
	public IReadOnlyList<SurvivorsTask> GetSurvivorsTaskByActId(int actId)
	{
		IReadOnlyList<SurvivorsTask> configList = ConfigSurvivorsTaskByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsTask>();
	}

	// Token: 0x06014B55 RID: 84821 RVA: 0x00608114 File Offset: 0x00606314
	public IReadOnlyList<SurvivorsScoreReward> GetAllSurvivorsScoreRewardByActId(int actId)
	{
		IReadOnlyList<SurvivorsScoreReward> configList = ConfigSurvivorsScoreRewardByActivity.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsScoreReward>();
	}

	// Token: 0x17001F1E RID: 7966
	// (get) Token: 0x06014B56 RID: 84822 RVA: 0x00608133 File Offset: 0x00606333
	public static SurvivorsRogueConfig Instance
	{
		get
		{
			return SurvivorsRogueConfig._Instance;
		}
	}

	// Token: 0x06014B57 RID: 84823 RVA: 0x0060813A File Offset: 0x0060633A
	public static SurvivorsRogueConfig GetOrCreateInstance()
	{
		if (SurvivorsRogueConfig._Instance == null)
		{
			SurvivorsRogueConfig.CreateInstance();
		}
		return SurvivorsRogueConfig._Instance;
	}

	// Token: 0x06014B58 RID: 84824 RVA: 0x0060814E File Offset: 0x0060634E
	public static bool CreateInstance()
	{
		if (SurvivorsRogueConfig._Instance != null)
		{
			return true;
		}
		SurvivorsRogueConfig._Instance = new SurvivorsRogueConfig();
		return true;
	}

	// Token: 0x06014B59 RID: 84825 RVA: 0x00608164 File Offset: 0x00606364
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014B5A RID: 84826 RVA: 0x00608166 File Offset: 0x00606366
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueConfig._Instance = null;
	}

	// Token: 0x06014B5B RID: 84827 RVA: 0x0060816E File Offset: 0x0060636E
	static SurvivorsRogueConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueConfig.CreateStaticDefaultValue), new Action(SurvivorsRogueConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B0B5 RID: 45237
	[Nullable(2)]
	private static SurvivorsRogueConfig _Instance;
}
