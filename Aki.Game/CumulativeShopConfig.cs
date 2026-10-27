using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020011FF RID: 4607
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class CumulativeShopConfig : ConfigBase
{
	// Token: 0x06007B43 RID: 31555 RVA: 0x0019FB8C File Offset: 0x0019DD8C
	public ConsumptiveTask? GetCumulativeShopTaskConfig(int taskId)
	{
		return ConfigConsumptiveTaskById.GetConfig(taskId, true);
	}

	// Token: 0x06007B44 RID: 31556 RVA: 0x0019FB95 File Offset: 0x0019DD95
	public ConsumptiveTaskTab? GetCumulativeShopTaskTabConfig(int tabId)
	{
		return ConfigConsumptiveTaskTabById.GetConfig(tabId, true);
	}

	// Token: 0x17000A8A RID: 2698
	// (get) Token: 0x06007B45 RID: 31557 RVA: 0x0019FB9E File Offset: 0x0019DD9E
	public static CumulativeShopConfig Instance
	{
		get
		{
			return CumulativeShopConfig._Instance;
		}
	}

	// Token: 0x06007B46 RID: 31558 RVA: 0x0019FBA5 File Offset: 0x0019DDA5
	public static CumulativeShopConfig GetOrCreateInstance()
	{
		if (CumulativeShopConfig._Instance == null)
		{
			CumulativeShopConfig.CreateInstance();
		}
		return CumulativeShopConfig._Instance;
	}

	// Token: 0x06007B47 RID: 31559 RVA: 0x0019FBB9 File Offset: 0x0019DDB9
	public static bool CreateInstance()
	{
		if (CumulativeShopConfig._Instance != null)
		{
			return true;
		}
		CumulativeShopConfig._Instance = new CumulativeShopConfig();
		return true;
	}

	// Token: 0x06007B48 RID: 31560 RVA: 0x0019FBCF File Offset: 0x0019DDCF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007B49 RID: 31561 RVA: 0x0019FBD1 File Offset: 0x0019DDD1
	public static void ResetStaticDefaultValue()
	{
		CumulativeShopConfig._Instance = null;
	}

	// Token: 0x06007B4A RID: 31562 RVA: 0x0019FBD9 File Offset: 0x0019DDD9
	static CumulativeShopConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CumulativeShopConfig.CreateStaticDefaultValue), new Action(CumulativeShopConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003864 RID: 14436
	[Nullable(2)]
	private static CumulativeShopConfig _Instance;
}
