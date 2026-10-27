using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001C50 RID: 7248
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GachaAccumulateConfig : ConfigBase
{
	// Token: 0x0600DA9D RID: 55965 RVA: 0x0032C67C File Offset: 0x0032A87C
	public GachaAccumulate? GetGachaAccumulateConfig(int accumulateId)
	{
		return ConfigGachaAccumulateById.GetConfig(accumulateId, true);
	}

	// Token: 0x0600DA9E RID: 55966 RVA: 0x0032C688 File Offset: 0x0032A888
	public string GetGachaAccumulateTipsPrefabPath(int accumulateId)
	{
		return ConfigGachaAccumulateById.GetConfig(accumulateId, true).Value.TipsPrefabPath;
	}

	// Token: 0x0600DA9F RID: 55967 RVA: 0x0032C6AC File Offset: 0x0032A8AC
	public string GetGachaAccumulatePrefabPath(int accumulateId)
	{
		return ConfigGachaAccumulateById.GetConfig(accumulateId, true).Value.GachaAccumulatePrefabPath;
	}

	// Token: 0x0600DAA0 RID: 55968 RVA: 0x0032C6D0 File Offset: 0x0032A8D0
	public EGachaAccumulateShowType GetShowType(int accumulateId)
	{
		GachaAccumulate? config = ConfigGachaAccumulateById.GetConfig(accumulateId, true);
		if (config == null)
		{
			return EGachaAccumulateShowType.Default;
		}
		return (EGachaAccumulateShowType)config.GetValueOrDefault().ShowType;
	}

	// Token: 0x0600DAA1 RID: 55969 RVA: 0x0032C700 File Offset: 0x0032A900
	public int GetHelpId(int accumulateId)
	{
		if (ConfigGachaAccumulateById.GetConfig(accumulateId, true) == null)
		{
			return 0;
		}
		GachaAccumulate? gachaAccumulate;
		return gachaAccumulate.GetValueOrDefault().HelpId;
	}

	// Token: 0x0600DAA2 RID: 55970 RVA: 0x0032C72F File Offset: 0x0032A92F
	public SelectRolePerformance? GetSelectRolePerformanceConfig(int itemId)
	{
		return ConfigSelectRolePerformanceById.GetConfig(itemId, true);
	}

	// Token: 0x0600DAA3 RID: 55971 RVA: 0x0032C738 File Offset: 0x0032A938
	public SelectRoleItemPerformance? GetSelectRoleItemPerformance(int itemId)
	{
		return ConfigSelectRoleItemPerformanceById.GetConfig(itemId, true);
	}

	// Token: 0x170011DB RID: 4571
	// (get) Token: 0x0600DAA4 RID: 55972 RVA: 0x0032C741 File Offset: 0x0032A941
	public static GachaAccumulateConfig Instance
	{
		get
		{
			return GachaAccumulateConfig._Instance;
		}
	}

	// Token: 0x0600DAA5 RID: 55973 RVA: 0x0032C748 File Offset: 0x0032A948
	public static GachaAccumulateConfig GetOrCreateInstance()
	{
		if (GachaAccumulateConfig._Instance == null)
		{
			GachaAccumulateConfig.CreateInstance();
		}
		return GachaAccumulateConfig._Instance;
	}

	// Token: 0x0600DAA6 RID: 55974 RVA: 0x0032C75C File Offset: 0x0032A95C
	public static bool CreateInstance()
	{
		if (GachaAccumulateConfig._Instance != null)
		{
			return true;
		}
		GachaAccumulateConfig._Instance = new GachaAccumulateConfig();
		return true;
	}

	// Token: 0x0600DAA7 RID: 55975 RVA: 0x0032C772 File Offset: 0x0032A972
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DAA8 RID: 55976 RVA: 0x0032C774 File Offset: 0x0032A974
	public static void ResetStaticDefaultValue()
	{
		GachaAccumulateConfig._Instance = null;
	}

	// Token: 0x0600DAA9 RID: 55977 RVA: 0x0032C77C File Offset: 0x0032A97C
	static GachaAccumulateConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaAccumulateConfig.CreateStaticDefaultValue), new Action(GachaAccumulateConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006405 RID: 25605
	[Nullable(2)]
	private static GachaAccumulateConfig _Instance;
}
