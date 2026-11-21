using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020006B3 RID: 1715
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class CumulativeShopConfig : ConfigBase
{
	// Token: 0x06004ED9 RID: 20185 RVA: 0x001A8844 File Offset: 0x001A6A44
	public ConsumptiveTask? GetCumulativeShopTaskConfig(int taskId)
	{
		return ConfigConsumptiveTaskById.GetConfig(taskId, true);
	}

	// Token: 0x06004EDA RID: 20186 RVA: 0x001A884D File Offset: 0x001A6A4D
	public ConsumptiveTaskTab? GetCumulativeShopTaskTabConfig(int tabId)
	{
		return ConfigConsumptiveTaskTabById.GetConfig(tabId, true);
	}

	// Token: 0x17000AAA RID: 2730
	// (get) Token: 0x06004EDB RID: 20187 RVA: 0x001A8856 File Offset: 0x001A6A56
	public static CumulativeShopConfig Instance
	{
		get
		{
			return CumulativeShopConfig._Instance;
		}
	}

	// Token: 0x06004EDC RID: 20188 RVA: 0x001A885D File Offset: 0x001A6A5D
	public static CumulativeShopConfig GetOrCreateInstance()
	{
		if (CumulativeShopConfig._Instance == null)
		{
			CumulativeShopConfig.CreateInstance();
		}
		return CumulativeShopConfig._Instance;
	}

	// Token: 0x06004EDD RID: 20189 RVA: 0x001A8871 File Offset: 0x001A6A71
	public static bool CreateInstance()
	{
		if (CumulativeShopConfig._Instance != null)
		{
			return true;
		}
		CumulativeShopConfig._Instance = new CumulativeShopConfig();
		return true;
	}

	// Token: 0x06004EDE RID: 20190 RVA: 0x001A8887 File Offset: 0x001A6A87
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004EDF RID: 20191 RVA: 0x001A8889 File Offset: 0x001A6A89
	public static void ResetStaticDefaultValue()
	{
		CumulativeShopConfig._Instance = null;
	}

	// Token: 0x06004EE0 RID: 20192 RVA: 0x001A8891 File Offset: 0x001A6A91
	static CumulativeShopConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CumulativeShopConfig.CreateStaticDefaultValue), new Action(CumulativeShopConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040038FD RID: 14589
	[Nullable(2)]
	private static CumulativeShopConfig _Instance;
}
