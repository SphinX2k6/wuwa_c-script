using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020020AA RID: 8362
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LogReportConfig : ConfigBase
{
	// Token: 0x0601083B RID: 67643 RVA: 0x00409A0C File Offset: 0x00407C0C
	public BeginnerGuide? GetBeginnerGuideConfig(int id)
	{
		BeginnerGuide? config = ConfigBeginnerGuideById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LogReport;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "新手打点表分表BeginnerGuide配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x1700145B RID: 5211
	// (get) Token: 0x0601083C RID: 67644 RVA: 0x00409A59 File Offset: 0x00407C59
	public static LogReportConfig Instance
	{
		get
		{
			return LogReportConfig._Instance;
		}
	}

	// Token: 0x0601083D RID: 67645 RVA: 0x00409A60 File Offset: 0x00407C60
	public static LogReportConfig GetOrCreateInstance()
	{
		if (LogReportConfig._Instance == null)
		{
			LogReportConfig.CreateInstance();
		}
		return LogReportConfig._Instance;
	}

	// Token: 0x0601083E RID: 67646 RVA: 0x00409A74 File Offset: 0x00407C74
	public static bool CreateInstance()
	{
		if (LogReportConfig._Instance != null)
		{
			return true;
		}
		LogReportConfig._Instance = new LogReportConfig();
		return true;
	}

	// Token: 0x0601083F RID: 67647 RVA: 0x00409A8A File Offset: 0x00407C8A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010840 RID: 67648 RVA: 0x00409A8C File Offset: 0x00407C8C
	public static void ResetStaticDefaultValue()
	{
		LogReportConfig._Instance = null;
	}

	// Token: 0x06010841 RID: 67649 RVA: 0x00409A94 File Offset: 0x00407C94
	static LogReportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogReportConfig.CreateStaticDefaultValue), new Action(LogReportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007A18 RID: 31256
	[Nullable(2)]
	private static LogReportConfig _Instance;
}
