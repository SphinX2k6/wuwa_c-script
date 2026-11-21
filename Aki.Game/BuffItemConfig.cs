using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.World.Model;

// Token: 0x02000BCC RID: 3020
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BuffItemConfig : ConfigBase
{
	// Token: 0x06007E14 RID: 32276 RVA: 0x0026E1B8 File Offset: 0x0026C3B8
	public Damage? GetDamageConfig(int entityId, int damageId)
	{
		DamageModel instance = DamageModel.Instance;
		if (instance == null)
		{
			return null;
		}
		return instance.GetDamageConfigById((long)damageId);
	}

	// Token: 0x06007E15 RID: 32277 RVA: 0x0026E1E0 File Offset: 0x0026C3E0
	[NullableContext(2)]
	public Buff[] GetBuffItemBuffConfig(int itemConfigId)
	{
		BuffItem? buffItemConfig = this.GetBuffItemConfig(itemConfigId);
		if (buffItemConfig == null || buffItemConfig.Value.BuffsLength == 0)
		{
			return null;
		}
		List<Buff> list = new List<Buff>();
		long[] buffsArray = buffItemConfig.Value.GetBuffsArray();
		for (int i = 0; i < buffsArray.Length; i++)
		{
			Buff? config = ConfigBuffById.GetConfig(buffsArray[i], true);
			if (config != null)
			{
				list.Add(config.Value);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06007E16 RID: 32278 RVA: 0x0026E261 File Offset: 0x0026C461
	public Buff? GetBuffConfig(int entityId, long buffId)
	{
		return ConfigBuffById.GetConfig(buffId, true);
	}

	// Token: 0x06007E17 RID: 32279 RVA: 0x0026E26C File Offset: 0x0026C46C
	[return: Nullable(2)]
	public Buff[] GetBuffConfigs(int entityId, IList<long> buffs)
	{
		if (buffs.Count == 0)
		{
			return null;
		}
		List<Buff> list = new List<Buff>();
		foreach (long p0Id in buffs)
		{
			Buff? config = ConfigBuffById.GetConfig(p0Id, true);
			if (config != null)
			{
				list.Add(config.Value);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06007E18 RID: 32280 RVA: 0x0026E2E0 File Offset: 0x0026C4E0
	public bool IsResurrectionItem(int itemConfigId)
	{
		Buff[] buffItemBuffConfig = this.GetBuffItemBuffConfig(itemConfigId);
		if (buffItemBuffConfig == null)
		{
			return false;
		}
		foreach (Buff buff in buffItemBuffConfig)
		{
			if (buff.ExtraEffectID == 101)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007E19 RID: 32281 RVA: 0x0026E320 File Offset: 0x0026C520
	public bool IsTeamBuffItem(int itemConfigId)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(itemConfigId, true);
		if (config == null)
		{
			return false;
		}
		if (!config.Value.IsBuffItem)
		{
			return false;
		}
		BuffItem? buffItemConfig = this.GetBuffItemConfig(itemConfigId);
		return buffItemConfig != null && buffItemConfig.Value.Share;
	}

	// Token: 0x06007E1A RID: 32282 RVA: 0x0026E378 File Offset: 0x0026C578
	public int GetBuffItemTotalCdTime(int itemConfigId)
	{
		BuffItem? buffItemConfig = this.GetBuffItemConfig(itemConfigId);
		if (buffItemConfig == null)
		{
			return 0;
		}
		int publicCdGroup = buffItemConfig.Value.PublicCdGroup;
		if (publicCdGroup > 0)
		{
			BuffItemCdGroup? buffItemCdGroup = this.GetBuffItemCdGroup(publicCdGroup);
			if (buffItemCdGroup != null)
			{
				return buffItemCdGroup.Value.CoolDownTime;
			}
		}
		return buffItemConfig.Value.Cd;
	}

	// Token: 0x06007E1B RID: 32283 RVA: 0x0026E3DD File Offset: 0x0026C5DD
	public BuffItem? GetBuffItemConfig(int itemConfigId)
	{
		return ConfigBuffItemById.GetConfig(itemConfigId, true);
	}

	// Token: 0x06007E1C RID: 32284 RVA: 0x0026E3E6 File Offset: 0x0026C5E6
	[NullableContext(2)]
	public IReadOnlyList<BuffItem> GetBuffItemConfigByPublicCdGroup(int publicCdGroup)
	{
		return ConfigBuffItemByPublicCdGroup.GetConfigList(publicCdGroup, true);
	}

	// Token: 0x06007E1D RID: 32285 RVA: 0x0026E3EF File Offset: 0x0026C5EF
	public BuffItemCdGroup? GetBuffItemCdGroup(int publicCdGroup)
	{
		return ConfigBuffItemCdGroupById.GetConfig(publicCdGroup, true);
	}

	// Token: 0x06007E1E RID: 32286 RVA: 0x0026E3F8 File Offset: 0x0026C5F8
	public bool IsBuffItem(int itemConfigId)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(itemConfigId, true);
		return config != null && config.Value.IsBuffItem && this.GetBuffItemConfig(itemConfigId) != null;
	}

	// Token: 0x06007E1F RID: 32287 RVA: 0x0026E43C File Offset: 0x0026C63C
	public bool IsEquipBuffItem(int itemConfigId)
	{
		return ConfigItemInfoById.GetConfig(itemConfigId, true) != null && this.GetBuffEquipItemByItemId(itemConfigId).Count > 0;
	}

	// Token: 0x06007E20 RID: 32288 RVA: 0x0026E46B File Offset: 0x0026C66B
	public IReadOnlyList<BuffEquipItem> GetBuffEquipItemByRoleId(int roleId)
	{
		return ConfigBuffEquipItemByRoleId.GetConfigList(roleId, true) ?? Array.Empty<BuffEquipItem>();
	}

	// Token: 0x06007E21 RID: 32289 RVA: 0x0026E47D File Offset: 0x0026C67D
	public IReadOnlyList<BuffEquipItem> GetBuffEquipItemByItemId(int itemConfigId)
	{
		return ConfigBuffEquipItemByItemId.GetConfigList(itemConfigId, true) ?? Array.Empty<BuffEquipItem>();
	}

	// Token: 0x06007E22 RID: 32290 RVA: 0x0026E490 File Offset: 0x0026C690
	public int GetBuffEquipItemCategory(int itemConfigId)
	{
		IReadOnlyList<BuffEquipItem> buffEquipItemByItemId = this.GetBuffEquipItemByItemId(itemConfigId);
		if (buffEquipItemByItemId.Count > 0)
		{
			return buffEquipItemByItemId[0].WearPos;
		}
		return 0;
	}

	// Token: 0x17000E25 RID: 3621
	// (get) Token: 0x06007E23 RID: 32291 RVA: 0x0026E4BF File Offset: 0x0026C6BF
	public static BuffItemConfig Instance
	{
		get
		{
			return BuffItemConfig._Instance;
		}
	}

	// Token: 0x06007E24 RID: 32292 RVA: 0x0026E4C6 File Offset: 0x0026C6C6
	public static BuffItemConfig GetOrCreateInstance()
	{
		if (BuffItemConfig._Instance == null)
		{
			BuffItemConfig.CreateInstance();
		}
		return BuffItemConfig._Instance;
	}

	// Token: 0x06007E25 RID: 32293 RVA: 0x0026E4DA File Offset: 0x0026C6DA
	public static bool CreateInstance()
	{
		if (BuffItemConfig._Instance != null)
		{
			return true;
		}
		BuffItemConfig._Instance = new BuffItemConfig();
		return true;
	}

	// Token: 0x06007E26 RID: 32294 RVA: 0x0026E4F0 File Offset: 0x0026C6F0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007E27 RID: 32295 RVA: 0x0026E4F2 File Offset: 0x0026C6F2
	public static void ResetStaticDefaultValue()
	{
		BuffItemConfig._Instance = null;
	}

	// Token: 0x06007E28 RID: 32296 RVA: 0x0026E4FA File Offset: 0x0026C6FA
	static BuffItemConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffItemConfig.CreateStaticDefaultValue), new Action(BuffItemConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004DF6 RID: 19958
	[Nullable(2)]
	private static BuffItemConfig _Instance;
}
