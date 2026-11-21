using System;
using System.Runtime.CompilerServices;

// Token: 0x0200166B RID: 5739
[NullableContext(1)]
[Nullable(0)]
public class ThinkingAnalyticsReporter : Singleton
{
	// Token: 0x0600DF6D RID: 57197 RVA: 0x0041991B File Offset: 0x00417B1B
	public void Init()
	{
		RealThinkingAnalyticsReporter.Instance.Init();
		RealKRAnalyticsReporter.Instance.Init();
	}

	// Token: 0x0600DF6E RID: 57198 RVA: 0x00419931 File Offset: 0x00417B31
	public void Report(string key, string jsonLog)
	{
		RealThinkingAnalyticsReporter.Instance.Report(key, jsonLog);
		RealKRAnalyticsReporter.Instance.Report(key, jsonLog);
	}

	// Token: 0x1700155D RID: 5469
	// (get) Token: 0x0600DF6F RID: 57199 RVA: 0x0041994B File Offset: 0x00417B4B
	public static ThinkingAnalyticsReporter Instance
	{
		get
		{
			if (ThinkingAnalyticsReporter._instance == null)
			{
				ThinkingAnalyticsReporter._instance = new ThinkingAnalyticsReporter();
				ThinkingAnalyticsReporter._instance.OnInit();
			}
			return ThinkingAnalyticsReporter._instance;
		}
	}

	// Token: 0x0600DF70 RID: 57200 RVA: 0x0041996E File Offset: 0x00417B6E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DF71 RID: 57201 RVA: 0x00419970 File Offset: 0x00417B70
	public static void ResetStaticDefaultValue()
	{
		ThinkingAnalyticsReporter instance = ThinkingAnalyticsReporter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ThinkingAnalyticsReporter._instance = null;
	}

	// Token: 0x0600DF72 RID: 57202 RVA: 0x00419989 File Offset: 0x00417B89
	static ThinkingAnalyticsReporter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ThinkingAnalyticsReporter.CreateStaticDefaultValue), new Action(ThinkingAnalyticsReporter.ResetStaticDefaultValue));
	}

	// Token: 0x04008044 RID: 32836
	[Nullable(2)]
	private static ThinkingAnalyticsReporter _instance;
}
