using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200239D RID: 9117
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeekCardConfig : ConfigBase
{
	// Token: 0x060123BE RID: 74686 RVA: 0x0047E138 File Offset: 0x0047C338
	public WeekCard? GetConfig(int key)
	{
		WeekCard? config = ConfigWeekCardById.GetConfig(key, true);
		if (config == null)
		{
			return null;
		}
		return new WeekCard?(config.Value);
	}

	// Token: 0x060123BF RID: 74687 RVA: 0x0047E16C File Offset: 0x0047C36C
	public WeekCard? GetWeekConfigByPayGiftId(int giftId)
	{
		WeekCard? config = ConfigWeekCardByPayGiftId.GetConfig(giftId, true);
		if (config == null)
		{
			return null;
		}
		return new WeekCard?(config.Value);
	}

	// Token: 0x060123C0 RID: 74688 RVA: 0x0047E1A0 File Offset: 0x0047C3A0
	public WeekCardContent? GetContentConfig(int contentId)
	{
		WeekCardContent? config = ConfigWeekCardContentById.GetConfig(contentId, true);
		if (config == null)
		{
			return null;
		}
		return new WeekCardContent?(config.Value);
	}

	// Token: 0x060123C1 RID: 74689 RVA: 0x0047E1D4 File Offset: 0x0047C3D4
	public List<WeekCard> GetConfigListByKind(EWeekCardKind kind)
	{
		EWeekCardShowType showType = (kind == EWeekCardKind.NewPlayer) ? EWeekCardShowType.NewPlayer : EWeekCardShowType.Recommend;
		IReadOnlyList<WeekCard> configList = ConfigWeekCardAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<WeekCard>();
		}
		return (from config in configList
		where config.ShowType == (int)showType
		select config).ToList<WeekCard>();
	}

	// Token: 0x170017A3 RID: 6051
	// (get) Token: 0x060123C2 RID: 74690 RVA: 0x0047E21C File Offset: 0x0047C41C
	public static WeekCardConfig Instance
	{
		get
		{
			return WeekCardConfig._Instance;
		}
	}

	// Token: 0x060123C3 RID: 74691 RVA: 0x0047E223 File Offset: 0x0047C423
	public static WeekCardConfig GetOrCreateInstance()
	{
		if (WeekCardConfig._Instance == null)
		{
			WeekCardConfig.CreateInstance();
		}
		return WeekCardConfig._Instance;
	}

	// Token: 0x060123C4 RID: 74692 RVA: 0x0047E237 File Offset: 0x0047C437
	public static bool CreateInstance()
	{
		if (WeekCardConfig._Instance != null)
		{
			return true;
		}
		WeekCardConfig._Instance = new WeekCardConfig();
		return true;
	}

	// Token: 0x060123C5 RID: 74693 RVA: 0x0047E24D File Offset: 0x0047C44D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060123C6 RID: 74694 RVA: 0x0047E24F File Offset: 0x0047C44F
	public static void ResetStaticDefaultValue()
	{
		WeekCardConfig._Instance = null;
	}

	// Token: 0x060123C7 RID: 74695 RVA: 0x0047E257 File Offset: 0x0047C457
	static WeekCardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeekCardConfig.CreateStaticDefaultValue), new Action(WeekCardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040089C2 RID: 35266
	[Nullable(2)]
	private static WeekCardConfig _Instance;
}
