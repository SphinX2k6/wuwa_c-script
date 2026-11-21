using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200110F RID: 4367
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GachaAccumulateConfig : ConfigBase
{
	// Token: 0x0600AEB3 RID: 44723 RVA: 0x00337A84 File Offset: 0x00335C84
	public GachaAccumulate? GetGachaAccumulateConfig(int accumulateId)
	{
		return ConfigGachaAccumulateById.GetConfig(accumulateId, true);
	}

	// Token: 0x0600AEB4 RID: 44724 RVA: 0x00337A90 File Offset: 0x00335C90
	public string GetGachaAccumulateTipsPrefabPath(int accumulateId)
	{
		return ConfigGachaAccumulateById.GetConfig(accumulateId, true).Value.TipsPrefabPath;
	}

	// Token: 0x0600AEB5 RID: 44725 RVA: 0x00337AB4 File Offset: 0x00335CB4
	public string GetGachaAccumulatePrefabPath(int accumulateId)
	{
		return ConfigGachaAccumulateById.GetConfig(accumulateId, true).Value.GachaAccumulatePrefabPath;
	}

	// Token: 0x0600AEB6 RID: 44726 RVA: 0x00337AD8 File Offset: 0x00335CD8
	public EGachaAccumulateShowType GetShowType(int accumulateId)
	{
		GachaAccumulate? config = ConfigGachaAccumulateById.GetConfig(accumulateId, true);
		if (config == null)
		{
			return EGachaAccumulateShowType.Default;
		}
		return (EGachaAccumulateShowType)config.GetValueOrDefault().ShowType;
	}

	// Token: 0x0600AEB7 RID: 44727 RVA: 0x00337B08 File Offset: 0x00335D08
	public int GetHelpId(int accumulateId)
	{
		if (ConfigGachaAccumulateById.GetConfig(accumulateId, true) == null)
		{
			return 0;
		}
		GachaAccumulate? gachaAccumulate;
		return gachaAccumulate.GetValueOrDefault().HelpId;
	}

	// Token: 0x0600AEB8 RID: 44728 RVA: 0x00337B37 File Offset: 0x00335D37
	public SelectRolePerformance? GetSelectRolePerformanceConfig(int itemId)
	{
		return ConfigSelectRolePerformanceById.GetConfig(itemId, true);
	}

	// Token: 0x0600AEB9 RID: 44729 RVA: 0x00337B40 File Offset: 0x00335D40
	public SelectRoleItemPerformance? GetSelectRoleItemPerformance(int itemId)
	{
		return ConfigSelectRoleItemPerformanceById.GetConfig(itemId, true);
	}

	// Token: 0x17001201 RID: 4609
	// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x00337B49 File Offset: 0x00335D49
	public static GachaAccumulateConfig Instance
	{
		get
		{
			return GachaAccumulateConfig._Instance;
		}
	}

	// Token: 0x0600AEBB RID: 44731 RVA: 0x00337B50 File Offset: 0x00335D50
	public static GachaAccumulateConfig GetOrCreateInstance()
	{
		if (GachaAccumulateConfig._Instance == null)
		{
			GachaAccumulateConfig.CreateInstance();
		}
		return GachaAccumulateConfig._Instance;
	}

	// Token: 0x0600AEBC RID: 44732 RVA: 0x00337B64 File Offset: 0x00335D64
	public static bool CreateInstance()
	{
		if (GachaAccumulateConfig._Instance != null)
		{
			return true;
		}
		GachaAccumulateConfig._Instance = new GachaAccumulateConfig();
		return true;
	}

	// Token: 0x0600AEBD RID: 44733 RVA: 0x00337B7A File Offset: 0x00335D7A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AEBE RID: 44734 RVA: 0x00337B7C File Offset: 0x00335D7C
	public static void ResetStaticDefaultValue()
	{
		GachaAccumulateConfig._Instance = null;
	}

	// Token: 0x0600AEBF RID: 44735 RVA: 0x00337B84 File Offset: 0x00335D84
	static GachaAccumulateConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaAccumulateConfig.CreateStaticDefaultValue), new Action(GachaAccumulateConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040064D7 RID: 25815
	[Nullable(2)]
	private static GachaAccumulateConfig _Instance;
}
