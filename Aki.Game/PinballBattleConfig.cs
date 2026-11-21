using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000354 RID: 852
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PinballBattleConfig : ConfigBase
{
	// Token: 0x06002FC6 RID: 12230 RVA: 0x001181D2 File Offset: 0x001163D2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06002FC7 RID: 12231 RVA: 0x001181D5 File Offset: 0x001163D5
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06002FC8 RID: 12232 RVA: 0x001181D8 File Offset: 0x001163D8
	public PinballWorldConfig? GetWorldConfig(int id)
	{
		return ConfigPinballWorldConfigById.GetConfig(id, true);
	}

	// Token: 0x06002FC9 RID: 12233 RVA: 0x001181E4 File Offset: 0x001163E4
	public PinballWorldConfig? GetWorldConfigByMapId(int mapId)
	{
		IReadOnlyList<PinballWorldConfig> configList = ConfigPinballWorldConfigByMapId.GetConfigList(mapId, true);
		if (configList != null)
		{
			return new PinballWorldConfig?(configList[0]);
		}
		return null;
	}

	// Token: 0x06002FCA RID: 12234 RVA: 0x00118212 File Offset: 0x00116412
	public IReadOnlyList<PinballEntityTest> GetWorldEntities(int mapId)
	{
		return ConfigPinballEntityTestByMapId.GetConfigList(mapId, true);
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x0011821B File Offset: 0x0011641B
	public PinballEntityTest? GetWorldEntityById(int configId)
	{
		return ConfigPinballEntityTestById.GetConfig(configId, true);
	}

	// Token: 0x06002FCC RID: 12236 RVA: 0x00118224 File Offset: 0x00116424
	public PinballCreature? GetCreatureConfigById(int configId)
	{
		return ConfigPinballCreatureById.GetConfig(configId, true);
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x0011822D File Offset: 0x0011642D
	public IReadOnlyList<PinballCreature> GetAllCreatureConfigs()
	{
		return ConfigPinballCreatureAll.GetConfigList(true);
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x00118235 File Offset: 0x00116435
	public IReadOnlyList<PinballDamage> GetAllDamageConfigs()
	{
		return ConfigPinballDamageAll.GetConfigList(true);
	}

	// Token: 0x06002FCF RID: 12239 RVA: 0x0011823D File Offset: 0x0011643D
	public PinballAttr? GetAttrConfig(int attrId)
	{
		return ConfigPinballAttrById.GetConfig(attrId, true);
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x00118246 File Offset: 0x00116446
	public IReadOnlyList<PinballAttr> GetAllAttrConfigs()
	{
		return ConfigPinballAttrAll.GetConfigList(true);
	}

	// Token: 0x06002FD1 RID: 12241 RVA: 0x0011824E File Offset: 0x0011644E
	public IReadOnlyList<PinballMonsterAttr> GetAllMonsterAttrConfigs()
	{
		return ConfigPinballMonsterAttrAll.GetConfigList(true);
	}

	// Token: 0x06002FD2 RID: 12242 RVA: 0x00118256 File Offset: 0x00116456
	public PinballRoleConfig? GetRoleConfig(int configId)
	{
		return ConfigPinballRoleConfigById.GetConfig(configId, true);
	}

	// Token: 0x06002FD3 RID: 12243 RVA: 0x0011825F File Offset: 0x0011645F
	public PinballRoleLevelConfig? GetLevelConfig(int groupId, int level)
	{
		return ConfigPinballRoleLevelConfigByGroupIdAndLevel.GetConfig(groupId, level, true);
	}

	// Token: 0x06002FD4 RID: 12244 RVA: 0x00118269 File Offset: 0x00116469
	public PinballRoleLevelConfig? GetRoleLevelConfig(int configId)
	{
		return ConfigPinballRoleLevelConfigById.GetConfig(configId, true);
	}

	// Token: 0x06002FD5 RID: 12245 RVA: 0x00118272 File Offset: 0x00116472
	public PinballWeaponConfig? GetWeaponConfig(int configId)
	{
		return ConfigPinballWeaponConfigById.GetConfig(configId, true);
	}

	// Token: 0x06002FD6 RID: 12246 RVA: 0x0011827B File Offset: 0x0011647B
	public PinballWeaponMainEntry? GetWeaponMainEntryConfig(int configId)
	{
		return ConfigPinballWeaponMainEntryById.GetConfig(configId, true);
	}

	// Token: 0x06002FD7 RID: 12247 RVA: 0x00118284 File Offset: 0x00116484
	public PinballWeaponSubEntry? GetWeaponSubEntryConfig(int configId)
	{
		return ConfigPinballWeaponSubEntryById.GetConfig(configId, true);
	}

	// Token: 0x06002FD8 RID: 12248 RVA: 0x0011828D File Offset: 0x0011648D
	public PinballWeaponAttr? GetWeaponAttrConfig(int configId)
	{
		return ConfigPinballWeaponAttrById.GetConfig(configId, true);
	}

	// Token: 0x06002FD9 RID: 12249 RVA: 0x00118296 File Offset: 0x00116496
	public PinballCommonItem? GetCommonItemConfigByConfigId(int configId)
	{
		return ConfigPinballCommonItemById.GetConfig(configId, true);
	}

	// Token: 0x06002FDA RID: 12250 RVA: 0x0011829F File Offset: 0x0011649F
	public PinballDeathrattle? GetDeathrattleConfig(int configId)
	{
		return ConfigPinballDeathrattleById.GetConfig(configId, true);
	}

	// Token: 0x06002FDB RID: 12251 RVA: 0x001182A8 File Offset: 0x001164A8
	public PinballEffect? GetEffectConfig(int configId)
	{
		return ConfigPinballEffectById.GetConfig(configId, true);
	}

	// Token: 0x170006E8 RID: 1768
	// (get) Token: 0x06002FDC RID: 12252 RVA: 0x001182B1 File Offset: 0x001164B1
	[Nullable(1)]
	public static PinballBattleConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PinballBattleConfig._Instance;
		}
	}

	// Token: 0x06002FDD RID: 12253 RVA: 0x001182B8 File Offset: 0x001164B8
	[NullableContext(1)]
	public static PinballBattleConfig GetOrCreateInstance()
	{
		if (PinballBattleConfig._Instance == null)
		{
			PinballBattleConfig.CreateInstance();
		}
		return PinballBattleConfig._Instance;
	}

	// Token: 0x06002FDE RID: 12254 RVA: 0x001182CC File Offset: 0x001164CC
	public static bool CreateInstance()
	{
		if (PinballBattleConfig._Instance != null)
		{
			return true;
		}
		PinballBattleConfig._Instance = new PinballBattleConfig();
		return true;
	}

	// Token: 0x06002FDF RID: 12255 RVA: 0x001182E2 File Offset: 0x001164E2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002FE0 RID: 12256 RVA: 0x001182E4 File Offset: 0x001164E4
	public static void ResetStaticDefaultValue()
	{
		PinballBattleConfig._Instance = null;
	}

	// Token: 0x06002FE1 RID: 12257 RVA: 0x001182EC File Offset: 0x001164EC
	static PinballBattleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleConfig.CreateStaticDefaultValue), new Action(PinballBattleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002AC5 RID: 10949
	private static PinballBattleConfig _Instance;
}
