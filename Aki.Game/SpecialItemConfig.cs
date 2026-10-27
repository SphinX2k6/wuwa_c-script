using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200201D RID: 8221
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SpecialItemConfig : ConfigBase
{
	// Token: 0x060101C3 RID: 65987 RVA: 0x003EC090 File Offset: 0x003EA290
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

	// Token: 0x060101C4 RID: 65988 RVA: 0x003EC0E8 File Offset: 0x003EA2E8
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

	// Token: 0x060101C5 RID: 65989 RVA: 0x003EC140 File Offset: 0x003EA340
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

	// Token: 0x170013AF RID: 5039
	// (get) Token: 0x060101C6 RID: 65990 RVA: 0x003EC196 File Offset: 0x003EA396
	public static SpecialItemConfig Instance
	{
		get
		{
			return SpecialItemConfig._Instance;
		}
	}

	// Token: 0x060101C7 RID: 65991 RVA: 0x003EC19D File Offset: 0x003EA39D
	public static SpecialItemConfig GetOrCreateInstance()
	{
		if (SpecialItemConfig._Instance == null)
		{
			SpecialItemConfig.CreateInstance();
		}
		return SpecialItemConfig._Instance;
	}

	// Token: 0x060101C8 RID: 65992 RVA: 0x003EC1B1 File Offset: 0x003EA3B1
	public static bool CreateInstance()
	{
		if (SpecialItemConfig._Instance != null)
		{
			return true;
		}
		SpecialItemConfig._Instance = new SpecialItemConfig();
		return true;
	}

	// Token: 0x060101C9 RID: 65993 RVA: 0x003EC1C7 File Offset: 0x003EA3C7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060101CA RID: 65994 RVA: 0x003EC1C9 File Offset: 0x003EA3C9
	public static void ResetStaticDefaultValue()
	{
		SpecialItemConfig._Instance = null;
	}

	// Token: 0x060101CB RID: 65995 RVA: 0x003EC1D1 File Offset: 0x003EA3D1
	static SpecialItemConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemConfig.CreateStaticDefaultValue), new Action(SpecialItemConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007744 RID: 30532
	[Nullable(2)]
	private static SpecialItemConfig _Instance;
}
