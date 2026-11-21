using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014F0 RID: 5360
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SpecialItemConfig : ConfigBase
{
	// Token: 0x0600D62B RID: 54827 RVA: 0x003F8688 File Offset: 0x003F6888
	public SpecialItem? GetConfig(int configId)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(configId, true);
		if (config == null || !config.Value.SpecialItem)
		{
			return null;
		}
		SpecialItem? config2 = ConfigSpecialItemById.GetConfig(configId, true);
		if (config2 == null)
		{
			return null;
		}
		return config2;
	}

	// Token: 0x0600D62C RID: 54828 RVA: 0x003F86E0 File Offset: 0x003F68E0
	public List<int> GetAllowTagIds(int configId)
	{
		SpecialItem? config = ConfigSpecialItemById.GetConfig(configId, true);
		List<int> list = new List<int>();
		foreach (string tagName in config.Value.AllowTags())
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
			list.Add(tagIdByName);
		}
		return list;
	}

	// Token: 0x0600D62D RID: 54829 RVA: 0x003F8738 File Offset: 0x003F6938
	public List<int> GetBanTagIds(int configId)
	{
		SpecialItem? config = ConfigSpecialItemById.GetConfig(configId, true);
		List<int> list = new List<int>();
		foreach (string tagName in config.Value.BanTags())
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
			list.Add(tagIdByName);
		}
		return list;
	}

	// Token: 0x170013DC RID: 5084
	// (get) Token: 0x0600D62E RID: 54830 RVA: 0x003F878E File Offset: 0x003F698E
	public static SpecialItemConfig Instance
	{
		get
		{
			return SpecialItemConfig._Instance;
		}
	}

	// Token: 0x0600D62F RID: 54831 RVA: 0x003F8795 File Offset: 0x003F6995
	public static SpecialItemConfig GetOrCreateInstance()
	{
		if (SpecialItemConfig._Instance == null)
		{
			SpecialItemConfig.CreateInstance();
		}
		return SpecialItemConfig._Instance;
	}

	// Token: 0x0600D630 RID: 54832 RVA: 0x003F87A9 File Offset: 0x003F69A9
	public static bool CreateInstance()
	{
		if (SpecialItemConfig._Instance != null)
		{
			return true;
		}
		SpecialItemConfig._Instance = new SpecialItemConfig();
		return true;
	}

	// Token: 0x0600D631 RID: 54833 RVA: 0x003F87BF File Offset: 0x003F69BF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D632 RID: 54834 RVA: 0x003F87C1 File Offset: 0x003F69C1
	public static void ResetStaticDefaultValue()
	{
		SpecialItemConfig._Instance = null;
	}

	// Token: 0x0600D633 RID: 54835 RVA: 0x003F87C9 File Offset: 0x003F69C9
	static SpecialItemConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemConfig.CreateStaticDefaultValue), new Action(SpecialItemConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400782D RID: 30765
	[Nullable(2)]
	private static SpecialItemConfig _Instance;
}
