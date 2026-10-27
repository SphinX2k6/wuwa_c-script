using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FEF RID: 4079
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GolemHackingConfig : ConfigBase
{
	// Token: 0x060068CA RID: 26826 RVA: 0x0014DA70 File Offset: 0x0014BC70
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

	// Token: 0x17000879 RID: 2169
	// (get) Token: 0x060068CB RID: 26827 RVA: 0x0014DABE File Offset: 0x0014BCBE
	public static GolemHackingConfig Instance
	{
		get
		{
			return GolemHackingConfig._Instance;
		}
	}

	// Token: 0x060068CC RID: 26828 RVA: 0x0014DAC5 File Offset: 0x0014BCC5
	public static GolemHackingConfig GetOrCreateInstance()
	{
		if (GolemHackingConfig._Instance == null)
		{
			GolemHackingConfig.CreateInstance();
		}
		return GolemHackingConfig._Instance;
	}

	// Token: 0x060068CD RID: 26829 RVA: 0x0014DAD9 File Offset: 0x0014BCD9
	public static bool CreateInstance()
	{
		if (GolemHackingConfig._Instance != null)
		{
			return true;
		}
		GolemHackingConfig._Instance = new GolemHackingConfig();
		return true;
	}

	// Token: 0x060068CE RID: 26830 RVA: 0x0014DAEF File Offset: 0x0014BCEF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060068CF RID: 26831 RVA: 0x0014DAF1 File Offset: 0x0014BCF1
	public static void ResetStaticDefaultValue()
	{
		GolemHackingConfig._Instance = null;
	}

	// Token: 0x060068D0 RID: 26832 RVA: 0x0014DAF9 File Offset: 0x0014BCF9
	static GolemHackingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GolemHackingConfig.CreateStaticDefaultValue), new Action(GolemHackingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002FFA RID: 12282
	[Nullable(2)]
	private static GolemHackingConfig _Instance;
}
