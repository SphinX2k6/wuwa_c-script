using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.World.Model;

// Token: 0x02001714 RID: 5908
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BuffItemConfig : ConfigBase
{
	// Token: 0x0600AA31 RID: 43569 RVA: 0x00263C68 File Offset: 0x00261E68
	public Damage? GetDamageConfig(int entityId, int damageId)
	{
		DamageModel instance = DamageModel.Instance;
		if (instance == null)
		{
			return null;
		}
		return instance.GetDamageConfigById((long)damageId);
	}

	// Token: 0x0600AA32 RID: 43570 RVA: 0x00263C90 File Offset: 0x00261E90
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

	// Token: 0x0600AA33 RID: 43571 RVA: 0x00263D11 File Offset: 0x00261F11
	public Buff? GetBuffConfig(int entityId, long buffId)
	{
		return ConfigBuffById.GetConfig(buffId, true);
	}

	// Token: 0x0600AA34 RID: 43572 RVA: 0x00263D1C File Offset: 0x00261F1C
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

	// Token: 0x0600AA35 RID: 43573 RVA: 0x00263D90 File Offset: 0x00261F90
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

	// Token: 0x0600AA36 RID: 43574 RVA: 0x00263DD0 File Offset: 0x00261FD0
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

	// Token: 0x0600AA37 RID: 43575 RVA: 0x00263E28 File Offset: 0x00262028
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

	// Token: 0x0600AA38 RID: 43576 RVA: 0x00263E8D File Offset: 0x0026208D
	public BuffItem? GetBuffItemConfig(int itemConfigId)
	{
		return ConfigBuffItemById.GetConfig(itemConfigId, true);
	}

	// Token: 0x0600AA39 RID: 43577 RVA: 0x00263E96 File Offset: 0x00262096
	[NullableContext(2)]
	public IReadOnlyList<BuffItem> GetBuffItemConfigByPublicCdGroup(int publicCdGroup)
	{
		return ConfigBuffItemByPublicCdGroup.GetConfigList(publicCdGroup, true);
	}

	// Token: 0x0600AA3A RID: 43578 RVA: 0x00263E9F File Offset: 0x0026209F
	public BuffItemCdGroup? GetBuffItemCdGroup(int publicCdGroup)
	{
		return ConfigBuffItemCdGroupById.GetConfig(publicCdGroup, true);
	}

	// Token: 0x0600AA3B RID: 43579 RVA: 0x00263EA8 File Offset: 0x002620A8
	public bool IsBuffItem(int itemConfigId)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(itemConfigId, true);
		return config != null && config.Value.IsBuffItem && this.GetBuffItemConfig(itemConfigId) != null;
	}

	// Token: 0x0600AA3C RID: 43580 RVA: 0x00263EEC File Offset: 0x002620EC
	public bool IsEquipBuffItem(int itemConfigId)
	{
		return ConfigItemInfoById.GetConfig(itemConfigId, true) != null && this.GetBuffEquipItemByItemId(itemConfigId).Count > 0;
	}

	// Token: 0x0600AA3D RID: 43581 RVA: 0x00263F1B File Offset: 0x0026211B
	public IReadOnlyList<BuffEquipItem> GetBuffEquipItemByRoleId(int roleId)
	{
		return ConfigBuffEquipItemByRoleId.GetConfigList(roleId, true) ?? Array.Empty<BuffEquipItem>();
	}

	// Token: 0x0600AA3E RID: 43582 RVA: 0x00263F2D File Offset: 0x0026212D
	public IReadOnlyList<BuffEquipItem> GetBuffEquipItemByItemId(int itemConfigId)
	{
		return ConfigBuffEquipItemByItemId.GetConfigList(itemConfigId, true) ?? Array.Empty<BuffEquipItem>();
	}

	// Token: 0x0600AA3F RID: 43583 RVA: 0x00263F40 File Offset: 0x00262140
	public int GetBuffEquipItemCategory(int itemConfigId)
	{
		IReadOnlyList<BuffEquipItem> buffEquipItemByItemId = this.GetBuffEquipItemByItemId(itemConfigId);
		if (buffEquipItemByItemId.Count > 0)
		{
			return buffEquipItemByItemId[0].WearPos;
		}
		return 0;
	}

	// Token: 0x17000E04 RID: 3588
	// (get) Token: 0x0600AA40 RID: 43584 RVA: 0x00263F6F File Offset: 0x0026216F
	public static BuffItemConfig Instance
	{
		get
		{
			return BuffItemConfig._Instance;
		}
	}

	// Token: 0x0600AA41 RID: 43585 RVA: 0x00263F76 File Offset: 0x00262176
	public static BuffItemConfig GetOrCreateInstance()
	{
		if (BuffItemConfig._Instance == null)
		{
			BuffItemConfig.CreateInstance();
		}
		return BuffItemConfig._Instance;
	}

	// Token: 0x0600AA42 RID: 43586 RVA: 0x00263F8A File Offset: 0x0026218A
	public static bool CreateInstance()
	{
		if (BuffItemConfig._Instance != null)
		{
			return true;
		}
		BuffItemConfig._Instance = new BuffItemConfig();
		return true;
	}

	// Token: 0x0600AA43 RID: 43587 RVA: 0x00263FA0 File Offset: 0x002621A0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AA44 RID: 43588 RVA: 0x00263FA2 File Offset: 0x002621A2
	public static void ResetStaticDefaultValue()
	{
		BuffItemConfig._Instance = null;
	}

	// Token: 0x0600AA45 RID: 43589 RVA: 0x00263FAA File Offset: 0x002621AA
	static BuffItemConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffItemConfig.CreateStaticDefaultValue), new Action(BuffItemConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004D4E RID: 19790
	[Nullable(2)]
	private static BuffItemConfig _Instance;
}
