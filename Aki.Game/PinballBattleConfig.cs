using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000E9F RID: 3743
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PinballBattleConfig : ConfigBase
{
	// Token: 0x06005C2F RID: 23599 RVA: 0x00110536 File Offset: 0x0010E736
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06005C30 RID: 23600 RVA: 0x00110539 File Offset: 0x0010E739
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06005C31 RID: 23601 RVA: 0x0011053C File Offset: 0x0010E73C
	public PinballWorldConfig? GetWorldConfig(int id)
	{
		return ConfigPinballWorldConfigById.GetConfig(id, true);
	}

	// Token: 0x06005C32 RID: 23602 RVA: 0x00110548 File Offset: 0x0010E748
	public PinballWorldConfig? GetWorldConfigByMapId(int mapId)
	{
		IReadOnlyList<PinballWorldConfig> configList = ConfigPinballWorldConfigByMapId.GetConfigList(mapId, true);
		if (configList != null)
		{
			return new PinballWorldConfig?(configList[0]);
		}
		return null;
	}

	// Token: 0x06005C33 RID: 23603 RVA: 0x00110576 File Offset: 0x0010E776
	public IReadOnlyList<PinballEntityTest> GetWorldEntities(int mapId)
	{
		return ConfigPinballEntityTestByMapId.GetConfigList(mapId, true);
	}

	// Token: 0x06005C34 RID: 23604 RVA: 0x0011057F File Offset: 0x0010E77F
	public PinballEntityTest? GetWorldEntityById(int configId)
	{
		return ConfigPinballEntityTestById.GetConfig(configId, true);
	}

	// Token: 0x06005C35 RID: 23605 RVA: 0x00110588 File Offset: 0x0010E788
	public PinballCreature? GetCreatureConfigById(int configId)
	{
		return ConfigPinballCreatureById.GetConfig(configId, true);
	}

	// Token: 0x06005C36 RID: 23606 RVA: 0x00110591 File Offset: 0x0010E791
	public IReadOnlyList<PinballCreature> GetAllCreatureConfigs()
	{
		return ConfigPinballCreatureAll.GetConfigList(true);
	}

	// Token: 0x06005C37 RID: 23607 RVA: 0x00110599 File Offset: 0x0010E799
	public IReadOnlyList<PinballDamage> GetAllDamageConfigs()
	{
		return ConfigPinballDamageAll.GetConfigList(true);
	}

	// Token: 0x06005C38 RID: 23608 RVA: 0x001105A1 File Offset: 0x0010E7A1
	public PinballAttr? GetAttrConfig(int attrId)
	{
		return ConfigPinballAttrById.GetConfig(attrId, true);
	}

	// Token: 0x06005C39 RID: 23609 RVA: 0x001105AA File Offset: 0x0010E7AA
	public IReadOnlyList<PinballAttr> GetAllAttrConfigs()
	{
		return ConfigPinballAttrAll.GetConfigList(true);
	}

	// Token: 0x06005C3A RID: 23610 RVA: 0x001105B2 File Offset: 0x0010E7B2
	public IReadOnlyList<PinballMonsterAttr> GetAllMonsterAttrConfigs()
	{
		return ConfigPinballMonsterAttrAll.GetConfigList(true);
	}

	// Token: 0x06005C3B RID: 23611 RVA: 0x001105BA File Offset: 0x0010E7BA
	public PinballRoleConfig? GetRoleConfig(int configId)
	{
		return ConfigPinballRoleConfigById.GetConfig(configId, true);
	}

	// Token: 0x06005C3C RID: 23612 RVA: 0x001105C3 File Offset: 0x0010E7C3
	public PinballRoleLevelConfig? GetLevelConfig(int groupId, int level)
	{
		return ConfigPinballRoleLevelConfigByGroupIdAndLevel.GetConfig(groupId, level, true);
	}

	// Token: 0x06005C3D RID: 23613 RVA: 0x001105CD File Offset: 0x0010E7CD
	public PinballRoleLevelConfig? GetRoleLevelConfig(int configId)
	{
		return ConfigPinballRoleLevelConfigById.GetConfig(configId, true);
	}

	// Token: 0x06005C3E RID: 23614 RVA: 0x001105D6 File Offset: 0x0010E7D6
	public PinballWeaponConfig? GetWeaponConfig(int configId)
	{
		return ConfigPinballWeaponConfigById.GetConfig(configId, true);
	}

	// Token: 0x06005C3F RID: 23615 RVA: 0x001105DF File Offset: 0x0010E7DF
	public PinballWeaponMainEntry? GetWeaponMainEntryConfig(int configId)
	{
		return ConfigPinballWeaponMainEntryById.GetConfig(configId, true);
	}

	// Token: 0x06005C40 RID: 23616 RVA: 0x001105E8 File Offset: 0x0010E7E8
	public PinballWeaponSubEntry? GetWeaponSubEntryConfig(int configId)
	{
		return ConfigPinballWeaponSubEntryById.GetConfig(configId, true);
	}

	// Token: 0x06005C41 RID: 23617 RVA: 0x001105F1 File Offset: 0x0010E7F1
	public PinballWeaponAttr? GetWeaponAttrConfig(int configId)
	{
		return ConfigPinballWeaponAttrById.GetConfig(configId, true);
	}

	// Token: 0x06005C42 RID: 23618 RVA: 0x001105FA File Offset: 0x0010E7FA
	public PinballCommonItem? GetCommonItemConfigByConfigId(int configId)
	{
		return ConfigPinballCommonItemById.GetConfig(configId, true);
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x00110603 File Offset: 0x0010E803
	public PinballDeathrattle? GetDeathrattleConfig(int configId)
	{
		return ConfigPinballDeathrattleById.GetConfig(configId, true);
	}

	// Token: 0x06005C44 RID: 23620 RVA: 0x0011060C File Offset: 0x0010E80C
	public PinballEffect? GetEffectConfig(int configId)
	{
		return ConfigPinballEffectById.GetConfig(configId, true);
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x06005C45 RID: 23621 RVA: 0x00110615 File Offset: 0x0010E815
	[Nullable(1)]
	public static PinballBattleConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PinballBattleConfig._Instance;
		}
	}

	// Token: 0x06005C46 RID: 23622 RVA: 0x0011061C File Offset: 0x0010E81C
	[NullableContext(1)]
	public static PinballBattleConfig GetOrCreateInstance()
	{
		if (PinballBattleConfig._Instance == null)
		{
			PinballBattleConfig.CreateInstance();
		}
		return PinballBattleConfig._Instance;
	}

	// Token: 0x06005C47 RID: 23623 RVA: 0x00110630 File Offset: 0x0010E830
	public static bool CreateInstance()
	{
		if (PinballBattleConfig._Instance != null)
		{
			return true;
		}
		PinballBattleConfig._Instance = new PinballBattleConfig();
		return true;
	}

	// Token: 0x06005C48 RID: 23624 RVA: 0x00110646 File Offset: 0x0010E846
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005C49 RID: 23625 RVA: 0x00110648 File Offset: 0x0010E848
	public static void ResetStaticDefaultValue()
	{
		PinballBattleConfig._Instance = null;
	}

	// Token: 0x06005C4A RID: 23626 RVA: 0x00110650 File Offset: 0x0010E850
	static PinballBattleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleConfig.CreateStaticDefaultValue), new Action(PinballBattleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002A2A RID: 10794
	private static PinballBattleConfig _Instance;
}
