using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020004A4 RID: 1188
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GolemHackingConfig : ConfigBase
{
	// Token: 0x06003C62 RID: 15458 RVA: 0x00156334 File Offset: 0x00154534
	public DaemonHackConfigCsv? GetPlayConfig(int configId)
	{
		DaemonHackConfigCsv? config = ConfigDaemonHackConfigCsvById.GetConfig(configId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GolemHacking;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DaemonHackConfigCsv数据无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x1700089B RID: 2203
	// (get) Token: 0x06003C63 RID: 15459 RVA: 0x00156382 File Offset: 0x00154582
	public static GolemHackingConfig Instance
	{
		get
		{
			return GolemHackingConfig._Instance;
		}
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x00156389 File Offset: 0x00154589
	public static GolemHackingConfig GetOrCreateInstance()
	{
		if (GolemHackingConfig._Instance == null)
		{
			GolemHackingConfig.CreateInstance();
		}
		return GolemHackingConfig._Instance;
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x0015639D File Offset: 0x0015459D
	public static bool CreateInstance()
	{
		if (GolemHackingConfig._Instance != null)
		{
			return true;
		}
		GolemHackingConfig._Instance = new GolemHackingConfig();
		return true;
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x001563B3 File Offset: 0x001545B3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003C67 RID: 15463 RVA: 0x001563B5 File Offset: 0x001545B5
	public static void ResetStaticDefaultValue()
	{
		GolemHackingConfig._Instance = null;
	}

	// Token: 0x06003C68 RID: 15464 RVA: 0x001563BD File Offset: 0x001545BD
	static GolemHackingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GolemHackingConfig.CreateStaticDefaultValue), new Action(GolemHackingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003093 RID: 12435
	[Nullable(2)]
	private static GolemHackingConfig _Instance;
}
