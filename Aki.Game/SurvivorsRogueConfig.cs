using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002B7F RID: 11135
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SurvivorsRogueConfig : ConfigBase
{
	// Token: 0x06017105 RID: 94469 RVA: 0x005DB11A File Offset: 0x005D931A
	public SurvivorsActivityConfig? GetSurvivorsActivityConfigByActivityId(int activityId)
	{
		return ConfigSurvivorsActivityConfigByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06017106 RID: 94470 RVA: 0x005DB124 File Offset: 0x005D9324
	public IReadOnlyList<SurvivorsLevel> GetAllSurvivorsLevelByActId(int actId)
	{
		IReadOnlyList<SurvivorsLevel> configList = ConfigSurvivorsLevelByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsLevel>();
	}

	// Token: 0x06017107 RID: 94471 RVA: 0x005DB143 File Offset: 0x005D9343
	public SurvivorsLevel? GetSurvivorsLevel(int levelId)
	{
		return ConfigSurvivorsLevelById.GetConfig(levelId, true);
	}

	// Token: 0x06017108 RID: 94472 RVA: 0x005DB14C File Offset: 0x005D934C
	public int GetMaxWaveNumByLevelId(int levelId)
	{
		IReadOnlyList<SurvivorsWave> configList = ConfigSurvivorsWaveByLevel.GetConfigList(levelId, true);
		if (configList == null)
		{
			return 0;
		}
		return configList.Count;
	}

	// Token: 0x06017109 RID: 94473 RVA: 0x005DB16C File Offset: 0x005D936C
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

	// Token: 0x0601710A RID: 94474 RVA: 0x005DB1B4 File Offset: 0x005D93B4
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

	// Token: 0x0601710B RID: 94475 RVA: 0x005DB1FC File Offset: 0x005D93FC
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

	// Token: 0x0601710C RID: 94476 RVA: 0x005DB248 File Offset: 0x005D9448
	public bool IsBoss(int templateId)
	{
		SurvivorsMonsterType? config = ConfigSurvivorsMonsterTypeByTemplateId.GetConfig(templateId, true);
		return config != null && config.Value.RiskType == 3;
	}

	// Token: 0x0601710D RID: 94477 RVA: 0x005DB27C File Offset: 0x005D947C
	public IReadOnlyList<SurvivorsRole> GetAllSurvivorsRoleByActId(int actId)
	{
		IReadOnlyList<SurvivorsRole> configList = ConfigSurvivorsRoleByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsRole>();
	}

	// Token: 0x0601710E RID: 94478 RVA: 0x005DB29B File Offset: 0x005D949B
	public SurvivorsRole? GetSurvivorsRole(int roleId)
	{
		return ConfigSurvivorsRoleById.GetConfig(roleId, true);
	}

	// Token: 0x0601710F RID: 94479 RVA: 0x005DB2A4 File Offset: 0x005D94A4
	public SurvivorsRoleLv? GetSurvivorsRoleLv(int lvId)
	{
		return ConfigSurvivorsRoleLvById.GetConfig(lvId, true);
	}

	// Token: 0x06017110 RID: 94480 RVA: 0x005DB2B0 File Offset: 0x005D94B0
	public IReadOnlyList<SurvivorsRoleLv> GetSurvivorsRoleLvListByRoleId(int roleId)
	{
		IReadOnlyList<SurvivorsRoleLv> configList = ConfigSurvivorsRoleLvByRoleId.GetConfigList(roleId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsRoleLv>();
	}

	// Token: 0x06017111 RID: 94481 RVA: 0x005DB2CF File Offset: 0x005D94CF
	public SurvivorsRoleEvolve? GetSurvivorsRoleEvolve(int evolveId)
	{
		return ConfigSurvivorsRoleEvolveById.GetConfig(evolveId, true);
	}

	// Token: 0x06017112 RID: 94482 RVA: 0x005DB2D8 File Offset: 0x005D94D8
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

	// Token: 0x06017113 RID: 94483 RVA: 0x005DB390 File Offset: 0x005D9590
	public IReadOnlyList<SurvivorsWeapon> GetAllSurvivorsWeaponByActId(int actId)
	{
		IReadOnlyList<SurvivorsWeapon> configList = ConfigSurvivorsWeaponByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsWeapon>();
	}

	// Token: 0x06017114 RID: 94484 RVA: 0x005DB3AF File Offset: 0x005D95AF
	public SurvivorsWeapon? GetSurvivorsWeapon(int weaponId)
	{
		return ConfigSurvivorsWeaponById.GetConfig(weaponId, true);
	}

	// Token: 0x06017115 RID: 94485 RVA: 0x005DB3B8 File Offset: 0x005D95B8
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

	// Token: 0x06017116 RID: 94486 RVA: 0x005DB46D File Offset: 0x005D966D
	public SurvivorsWeaponLv? GetSurvivorsWeaponLv(int lvId)
	{
		return ConfigSurvivorsWeaponLvById.GetConfig(lvId, true);
	}

	// Token: 0x06017117 RID: 94487 RVA: 0x005DB478 File Offset: 0x005D9678
	public IReadOnlyList<SurvivorsWeaponLv> GetSurvivorsWeaponLvListByWeaponId(int weaponId)
	{
		IReadOnlyList<SurvivorsWeaponLv> configList = ConfigSurvivorsWeaponLvByWeaponId.GetConfigList(weaponId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsWeaponLv>();
	}

	// Token: 0x06017118 RID: 94488 RVA: 0x005DB497 File Offset: 0x005D9697
	public SurvivorsWeaponEvolve? GetSurvivorsWeaponEvolve(int evolveId)
	{
		return ConfigSurvivorsWeaponEvolveById.GetConfig(evolveId, true);
	}

	// Token: 0x06017119 RID: 94489 RVA: 0x005DB4A0 File Offset: 0x005D96A0
	public IReadOnlyList<SurvivorsTalentTree> GetAllTalentTreeNodeByActId(int actId)
	{
		IReadOnlyList<SurvivorsTalentTree> configList = ConfigSurvivorsTalentTreeByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsTalentTree>();
	}

	// Token: 0x0601711A RID: 94490 RVA: 0x005DB4BF File Offset: 0x005D96BF
	public SurvivorsTalentTree? GetTalentTreeNode(int nodeId)
	{
		return ConfigSurvivorsTalentTreeById.GetConfig(nodeId, true);
	}

	// Token: 0x0601711B RID: 94491 RVA: 0x005DB4C8 File Offset: 0x005D96C8
	public SurvivorsTalentEffect? GetTalentTreeEffect(int effectId)
	{
		return ConfigSurvivorsTalentEffectById.GetConfig(effectId, true);
	}

	// Token: 0x0601711C RID: 94492 RVA: 0x005DB4D4 File Offset: 0x005D96D4
	public IReadOnlyList<SurvivorsItem> GetAllSurvivorsItemByActId(int actId)
	{
		IReadOnlyList<SurvivorsItem> configList = ConfigSurvivorsItemByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsItem>();
	}

	// Token: 0x0601711D RID: 94493 RVA: 0x005DB4F3 File Offset: 0x005D96F3
	public SurvivorsItem? GetSurvivorsItem(int weaponId)
	{
		return ConfigSurvivorsItemById.GetConfig(weaponId, true);
	}

	// Token: 0x0601711E RID: 94494 RVA: 0x005DB4FC File Offset: 0x005D96FC
	public SurvivorsQuality? GetQualityConfig(int qualityId)
	{
		return ConfigSurvivorsQualityById.GetConfig(qualityId, true);
	}

	// Token: 0x0601711F RID: 94495 RVA: 0x005DB505 File Offset: 0x005D9705
	public SurvivorsProperty? GetPropertyConfig(int propertyId)
	{
		return ConfigSurvivorsPropertyById.GetConfig(propertyId, true);
	}

	// Token: 0x06017120 RID: 94496 RVA: 0x005DB50E File Offset: 0x005D970E
	[NullableContext(2)]
	public IReadOnlyList<SkillGameplayButton> GetSkillButtonConfigByType(int type)
	{
		return ConfigSkillGameplayButtonByGameplayType.GetConfigList(type, true);
	}

	// Token: 0x06017121 RID: 94497 RVA: 0x005DB518 File Offset: 0x005D9718
	public SurvivorsCombo? GetComboConfig(int levelId)
	{
		SurvivorsLevel? survivorsLevel = this.GetSurvivorsLevel(levelId);
		if (survivorsLevel == null)
		{
			return null;
		}
		return ConfigSurvivorsComboById.GetConfig(survivorsLevel.Value.ComboCfgId, true);
	}

	// Token: 0x06017122 RID: 94498 RVA: 0x005DB555 File Offset: 0x005D9755
	public SurvivorsTask? GetSurvivorsTask(int taskId)
	{
		return ConfigSurvivorsTaskById.GetConfig(taskId, true);
	}

	// Token: 0x06017123 RID: 94499 RVA: 0x005DB560 File Offset: 0x005D9760
	public IReadOnlyList<SurvivorsTask> GetSurvivorsTaskByActId(int actId)
	{
		IReadOnlyList<SurvivorsTask> configList = ConfigSurvivorsTaskByActivityId.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsTask>();
	}

	// Token: 0x06017124 RID: 94500 RVA: 0x005DB580 File Offset: 0x005D9780
	public IReadOnlyList<SurvivorsScoreReward> GetAllSurvivorsScoreRewardByActId(int actId)
	{
		IReadOnlyList<SurvivorsScoreReward> configList = ConfigSurvivorsScoreRewardByActivity.GetConfigList(actId, true);
		if (configList != null)
		{
			return configList;
		}
		return new List<SurvivorsScoreReward>();
	}

	// Token: 0x17001EC6 RID: 7878
	// (get) Token: 0x06017125 RID: 94501 RVA: 0x005DB59F File Offset: 0x005D979F
	public static SurvivorsRogueConfig Instance
	{
		get
		{
			return SurvivorsRogueConfig._Instance;
		}
	}

	// Token: 0x06017126 RID: 94502 RVA: 0x005DB5A6 File Offset: 0x005D97A6
	public static SurvivorsRogueConfig GetOrCreateInstance()
	{
		if (SurvivorsRogueConfig._Instance == null)
		{
			SurvivorsRogueConfig.CreateInstance();
		}
		return SurvivorsRogueConfig._Instance;
	}

	// Token: 0x06017127 RID: 94503 RVA: 0x005DB5BA File Offset: 0x005D97BA
	public static bool CreateInstance()
	{
		if (SurvivorsRogueConfig._Instance != null)
		{
			return true;
		}
		SurvivorsRogueConfig._Instance = new SurvivorsRogueConfig();
		return true;
	}

	// Token: 0x06017128 RID: 94504 RVA: 0x005DB5D0 File Offset: 0x005D97D0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017129 RID: 94505 RVA: 0x005DB5D2 File Offset: 0x005D97D2
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueConfig._Instance = null;
	}

	// Token: 0x0601712A RID: 94506 RVA: 0x005DB5DA File Offset: 0x005D97DA
	static SurvivorsRogueConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueConfig.CreateStaticDefaultValue), new Action(SurvivorsRogueConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400ACAE RID: 44206
	[Nullable(2)]
	private static SurvivorsRogueConfig _Instance;
}
