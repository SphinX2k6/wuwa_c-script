using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001882 RID: 6274
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeekCardConfig : ConfigBase
{
	// Token: 0x0600F870 RID: 63600 RVA: 0x0048B578 File Offset: 0x00489778
	public WeekCard? GetConfig(int key)
	{
		WeekCard? config = ConfigWeekCardById.GetConfig(key, true);
		if (config == null)
		{
			return null;
		}
		return new WeekCard?(config.Value);
	}

	// Token: 0x0600F871 RID: 63601 RVA: 0x0048B5AC File Offset: 0x004897AC
	public WeekCard? GetWeekConfigByPayGiftId(int giftId)
	{
		WeekCard? config = ConfigWeekCardByPayGiftId.GetConfig(giftId, true);
		if (config == null)
		{
			return null;
		}
		return new WeekCard?(config.Value);
	}

	// Token: 0x0600F872 RID: 63602 RVA: 0x0048B5E0 File Offset: 0x004897E0
	public WeekCardContent? GetContentConfig(int contentId)
	{
		WeekCardContent? config = ConfigWeekCardContentById.GetConfig(contentId, true);
		if (config == null)
		{
			return null;
		}
		return new WeekCardContent?(config.Value);
	}

	// Token: 0x0600F873 RID: 63603 RVA: 0x0048B614 File Offset: 0x00489814
	public List<WeekCard> GetConfigListByKind(EWeekCardKind kind)
	{
		EWeekCardShowType eweekCardShowType = (kind == EWeekCardKind.NewPlayer) ? EWeekCardShowType.NewPlayer : EWeekCardShowType.Recommend;
		IReadOnlyList<WeekCard> configList = ConfigWeekCardAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<WeekCard>();
		}
		List<WeekCard> list = new List<WeekCard>();
		foreach (WeekCard item in configList)
		{
			if (item.ShowType == (int)eweekCardShowType)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x170017DD RID: 6109
	// (get) Token: 0x0600F874 RID: 63604 RVA: 0x0048B688 File Offset: 0x00489888
	public static WeekCardConfig Instance
	{
		get
		{
			return WeekCardConfig._Instance;
		}
	}

	// Token: 0x0600F875 RID: 63605 RVA: 0x0048B68F File Offset: 0x0048988F
	public static WeekCardConfig GetOrCreateInstance()
	{
		if (WeekCardConfig._Instance == null)
		{
			WeekCardConfig.CreateInstance();
		}
		return WeekCardConfig._Instance;
	}

	// Token: 0x0600F876 RID: 63606 RVA: 0x0048B6A3 File Offset: 0x004898A3
	public static bool CreateInstance()
	{
		if (WeekCardConfig._Instance != null)
		{
			return true;
		}
		WeekCardConfig._Instance = new WeekCardConfig();
		return true;
	}

	// Token: 0x0600F877 RID: 63607 RVA: 0x0048B6B9 File Offset: 0x004898B9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F878 RID: 63608 RVA: 0x0048B6BB File Offset: 0x004898BB
	public static void ResetStaticDefaultValue()
	{
		WeekCardConfig._Instance = null;
	}

	// Token: 0x0600F879 RID: 63609 RVA: 0x0048B6C3 File Offset: 0x004898C3
	static WeekCardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeekCardConfig.CreateStaticDefaultValue), new Action(WeekCardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008B09 RID: 35593
	[Nullable(2)]
	private static WeekCardConfig _Instance;
}
