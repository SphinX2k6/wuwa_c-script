using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200089E RID: 2206
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PinballConfig : ConfigBase
{
	// Token: 0x06006392 RID: 25490 RVA: 0x001FB1C1 File Offset: 0x001F93C1
	public PinballActivity? GetPinballActivityConfigByActivityId(int activityId)
	{
		return ConfigPinballActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06006393 RID: 25491 RVA: 0x001FB1CA File Offset: 0x001F93CA
	public PinballRoleConfig? GetPinballRoleConfigById(int id)
	{
		return ConfigPinballRoleConfigById.GetConfig(id, true);
	}

	// Token: 0x06006394 RID: 25492 RVA: 0x001FB1D4 File Offset: 0x001F93D4
	public int[] GetPinballRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (PinballRoleConfig pinballRoleConfig in (ConfigPinballRoleConfigAll.GetConfigList(true) ?? Array.Empty<PinballRoleConfig>()))
		{
			list.Add(pinballRoleConfig.Id);
		}
		return list.ToArray();
	}

	// Token: 0x06006395 RID: 25493 RVA: 0x001FB23C File Offset: 0x001F943C
	public PinballChapterConfig? GetPinballChapterConfigById(int chapter)
	{
		return ConfigPinballChapterConfigById.GetConfig(chapter, true);
	}

	// Token: 0x06006396 RID: 25494 RVA: 0x001FB245 File Offset: 0x001F9445
	public PinballLevelConfig? GetPinballLevelConfigById(int id)
	{
		return ConfigPinballLevelConfigById.GetConfig(id, true);
	}

	// Token: 0x06006397 RID: 25495 RVA: 0x001FB24E File Offset: 0x001F944E
	public IReadOnlyList<PinballDailyConfig> GetAllPinballDailyConfigList()
	{
		return ConfigPinballDailyConfigAll.GetConfigList(true) ?? Array.Empty<PinballDailyConfig>();
	}

	// Token: 0x06006398 RID: 25496 RVA: 0x001FB25F File Offset: 0x001F945F
	public PinballLevelTarget? GetPinballLevelTargetConfigById(int targetId)
	{
		return ConfigPinballLevelTargetById.GetConfig(targetId, true);
	}

	// Token: 0x06006399 RID: 25497 RVA: 0x001FB268 File Offset: 0x001F9468
	public PinballLevelConfig? GetPinballLevelConfigByRoleId(int roleId)
	{
		return ConfigPinballLevelConfigByShowRoleId.GetConfig(roleId, true);
	}

	// Token: 0x0600639A RID: 25498 RVA: 0x001FB271 File Offset: 0x001F9471
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

	// Token: 0x0600639B RID: 25499 RVA: 0x001FB29E File Offset: 0x001F949E
	public PinballBuffConfig? GetPinballBuffConfigById(int buffId)
	{
		return ConfigPinballBuffConfigById.GetConfig(buffId, true);
	}

	// Token: 0x0600639C RID: 25500 RVA: 0x001FB2A8 File Offset: 0x001F94A8
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

	// Token: 0x0600639D RID: 25501 RVA: 0x001FB308 File Offset: 0x001F9508
	public PinballWeaponConfig? GetPinballWeaponConfigById(int id)
	{
		return ConfigPinballWeaponConfigById.GetConfig(id, true);
	}

	// Token: 0x0600639E RID: 25502 RVA: 0x001FB311 File Offset: 0x001F9511
	public PinballMonster? GetPinballMonsterConfigById(int id)
	{
		return ConfigPinballMonsterById.GetConfig(id, true);
	}

	// Token: 0x0600639F RID: 25503 RVA: 0x001FB31A File Offset: 0x001F951A
	public PinballMonsterType? GetPinballMonsterTypeConfigById(int id)
	{
		return ConfigPinballMonsterTypeById.GetConfig(id, true);
	}

	// Token: 0x060063A0 RID: 25504 RVA: 0x001FB323 File Offset: 0x001F9523
	public PinballWeaponMainEntry? GetPinballWeaponMainEntryConfigById(int id)
	{
		return ConfigPinballWeaponMainEntryById.GetConfig(id, true);
	}

	// Token: 0x060063A1 RID: 25505 RVA: 0x001FB32C File Offset: 0x001F952C
	public PinballWeaponSubEntry? GetPinballWeaponSubEntryConfigById(int id)
	{
		return ConfigPinballWeaponSubEntryById.GetConfig(id, true);
	}

	// Token: 0x060063A2 RID: 25506 RVA: 0x001FB335 File Offset: 0x001F9535
	public PinballWeaponAttr? GetPinballWeaponAttrConfigById(int id)
	{
		return ConfigPinballWeaponAttrById.GetConfig(id, true);
	}

	// Token: 0x060063A3 RID: 25507 RVA: 0x001FB33E File Offset: 0x001F953E
	public PinballWeaponQuality? GetPinballWeaponQualityConfigById(int qualityId)
	{
		return ConfigPinballWeaponQualityById.GetConfig(qualityId, true);
	}

	// Token: 0x060063A4 RID: 25508 RVA: 0x001FB348 File Offset: 0x001F9548
	public PinballWeaponType? GetPinballWeaponTypeConfigById(int typeId)
	{
		PinballWeaponType? config = ConfigPinballWeaponTypeById.GetConfig(typeId, true);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x060063A5 RID: 25509 RVA: 0x001FB374 File Offset: 0x001F9574
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

	// Token: 0x060063A6 RID: 25510 RVA: 0x001FB3A3 File Offset: 0x001F95A3
	public PinballBdConfig? GetPinballRoleBdConfigById(int bdId)
	{
		return ConfigPinballBdConfigById.GetConfig(bdId, true);
	}

	// Token: 0x060063A7 RID: 25511 RVA: 0x001FB3AC File Offset: 0x001F95AC
	[NullableContext(2)]
	public IReadOnlyList<PinballRoleConfig> GetPinballRoleConfigListByActivityId(int activityId)
	{
		return ConfigPinballRoleConfigByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x060063A8 RID: 25512 RVA: 0x001FB3B5 File Offset: 0x001F95B5
	public PinballRoleLevelConfig? GetPinballRoleLevelConfigByGroupIdAndLevel(int groupId, int level)
	{
		return ConfigPinballRoleLevelConfigByGroupIdAndLevel.GetConfig(groupId, level, true);
	}

	// Token: 0x060063A9 RID: 25513 RVA: 0x001FB3BF File Offset: 0x001F95BF
	[NullableContext(2)]
	public IReadOnlyList<PinballRoleLevelConfig> GetPinballRoleLevelConfigListByGroupId(int groupId)
	{
		return ConfigPinballRoleLevelConfigByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x060063AA RID: 25514 RVA: 0x001FB3C8 File Offset: 0x001F95C8
	public PinballAttr? GetPinballRoleAttrConfigById(int id)
	{
		return ConfigPinballAttrById.GetConfig(id, true);
	}

	// Token: 0x060063AB RID: 25515 RVA: 0x001FB3D1 File Offset: 0x001F95D1
	public PinballPropertyIndex? GetPinballPropertyIndexConfigById(int id)
	{
		return ConfigPinballPropertyIndexById.GetConfig(id, true);
	}

	// Token: 0x060063AC RID: 25516 RVA: 0x001FB3DA File Offset: 0x001F95DA
	public PinballClassConfig? GetPinballClassConfigById(int id)
	{
		return ConfigPinballClassConfigById.GetConfig(id, true);
	}

	// Token: 0x060063AD RID: 25517 RVA: 0x001FB3E3 File Offset: 0x001F95E3
	public PinballSkillDisplayConfig? GetPinballSkillDisplayConfigById(int id)
	{
		return ConfigPinballSkillDisplayConfigById.GetConfig(id, true);
	}

	// Token: 0x060063AE RID: 25518 RVA: 0x001FB3EC File Offset: 0x001F95EC
	public PinballTask? GetPinballTaskConfigById(int id)
	{
		return ConfigPinballTaskById.GetConfig(id, true);
	}

	// Token: 0x060063AF RID: 25519 RVA: 0x001FB3F5 File Offset: 0x001F95F5
	public PinballRank? GetPinballRankConfigByTower(int towerLevel)
	{
		return ConfigPinballRankByTower.GetConfig(towerLevel, true);
	}

	// Token: 0x060063B0 RID: 25520 RVA: 0x001FB3FE File Offset: 0x001F95FE
	public PinballRank? GetPinballRankConfigById(int id)
	{
		return ConfigPinballRankById.GetConfig(id, true);
	}

	// Token: 0x060063B1 RID: 25521 RVA: 0x001FB407 File Offset: 0x001F9607
	[NullableContext(2)]
	public IReadOnlyList<PinballRank> GetAllPinballRankConfigList()
	{
		return ConfigPinballRankAll.GetConfigList(true);
	}

	// Token: 0x060063B2 RID: 25522 RVA: 0x001FB40F File Offset: 0x001F960F
	public PinballBdConfig? GetPinballBdConfigById(int id)
	{
		return ConfigPinballBdConfigById.GetConfig(id, true);
	}

	// Token: 0x060063B3 RID: 25523 RVA: 0x001FB418 File Offset: 0x001F9618
	[NullableContext(2)]
	public IReadOnlyList<PinballWaveConfig> GetPinballWaveConfigListByLevel(int level)
	{
		return ConfigPinballWaveConfigByLevel.GetConfigList(level, true);
	}

	// Token: 0x060063B4 RID: 25524 RVA: 0x001FB421 File Offset: 0x001F9621
	public PinballSpawnConfig? GetPinballSpawnConfigById(int id)
	{
		return ConfigPinballSpawnConfigById.GetConfig(id, true);
	}

	// Token: 0x060063B5 RID: 25525 RVA: 0x001FB42A File Offset: 0x001F962A
	public PinballMonsterSkillDisplay? GetPinballMonsterSkillDisplayConfigById(int id)
	{
		return ConfigPinballMonsterSkillDisplayById.GetConfig(id, true);
	}

	// Token: 0x060063B6 RID: 25526 RVA: 0x001FB433 File Offset: 0x001F9633
	public PinballMonsterRiskType? GetPinballMonsterRiskTypeConfigById(int riskTypeId)
	{
		return ConfigPinballMonsterRiskTypeById.GetConfig(riskTypeId, true);
	}

	// Token: 0x060063B7 RID: 25527 RVA: 0x001FB43C File Offset: 0x001F963C
	public PinballAvgStyleConfig? GetPinballAvgStyleConfigById(int style)
	{
		return ConfigPinballAvgStyleConfigById.GetConfig(style, true);
	}

	// Token: 0x17000C29 RID: 3113
	// (get) Token: 0x060063B8 RID: 25528 RVA: 0x001FB445 File Offset: 0x001F9645
	public static PinballConfig Instance
	{
		get
		{
			return PinballConfig._Instance;
		}
	}

	// Token: 0x060063B9 RID: 25529 RVA: 0x001FB44C File Offset: 0x001F964C
	public static PinballConfig GetOrCreateInstance()
	{
		if (PinballConfig._Instance == null)
		{
			PinballConfig.CreateInstance();
		}
		return PinballConfig._Instance;
	}

	// Token: 0x060063BA RID: 25530 RVA: 0x001FB460 File Offset: 0x001F9660
	public static bool CreateInstance()
	{
		if (PinballConfig._Instance != null)
		{
			return true;
		}
		PinballConfig._Instance = new PinballConfig();
		return true;
	}

	// Token: 0x060063BB RID: 25531 RVA: 0x001FB476 File Offset: 0x001F9676
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060063BC RID: 25532 RVA: 0x001FB478 File Offset: 0x001F9678
	public static void ResetStaticDefaultValue()
	{
		PinballConfig._Instance = null;
	}

	// Token: 0x060063BD RID: 25533 RVA: 0x001FB480 File Offset: 0x001F9680
	static PinballConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballConfig.CreateStaticDefaultValue), new Action(PinballConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004041 RID: 16449
	[Nullable(2)]
	private static PinballConfig _Instance;
}
