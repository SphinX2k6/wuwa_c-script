using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001581 RID: 5505
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LogReportConfig : ConfigBase
{
	// Token: 0x0600DCAB RID: 56491 RVA: 0x00416114 File Offset: 0x00414314
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

	// Token: 0x17001488 RID: 5256
	// (get) Token: 0x0600DCAC RID: 56492 RVA: 0x00416161 File Offset: 0x00414361
	public static LogReportConfig Instance
	{
		get
		{
			return LogReportConfig._Instance;
		}
	}

	// Token: 0x0600DCAD RID: 56493 RVA: 0x00416168 File Offset: 0x00414368
	public static LogReportConfig GetOrCreateInstance()
	{
		if (LogReportConfig._Instance == null)
		{
			LogReportConfig.CreateInstance();
		}
		return LogReportConfig._Instance;
	}

	// Token: 0x0600DCAE RID: 56494 RVA: 0x0041617C File Offset: 0x0041437C
	public static bool CreateInstance()
	{
		if (LogReportConfig._Instance != null)
		{
			return true;
		}
		LogReportConfig._Instance = new LogReportConfig();
		return true;
	}

	// Token: 0x0600DCAF RID: 56495 RVA: 0x00416192 File Offset: 0x00414392
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DCB0 RID: 56496 RVA: 0x00416194 File Offset: 0x00414394
	public static void ResetStaticDefaultValue()
	{
		LogReportConfig._Instance = null;
	}

	// Token: 0x0600DCB1 RID: 56497 RVA: 0x0041619C File Offset: 0x0041439C
	static LogReportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogReportConfig.CreateStaticDefaultValue), new Action(LogReportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007B16 RID: 31510
	[Nullable(2)]
	private static LogReportConfig _Instance;
}
