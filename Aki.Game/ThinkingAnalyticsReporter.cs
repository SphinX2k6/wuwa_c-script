using System;
using System.Runtime.CompilerServices;

// Token: 0x02002187 RID: 8583
[NullableContext(1)]
[Nullable(0)]
public class ThinkingAnalyticsReporter : Singleton
{
	// Token: 0x06010ADC RID: 68316 RVA: 0x0040D03F File Offset: 0x0040B23F
	public void Init()
	{
		RealThinkingAnalyticsReporter.Instance.Init();
		RealKRAnalyticsReporter.Instance.Init();
	}

	// Token: 0x06010ADD RID: 68317 RVA: 0x0040D055 File Offset: 0x0040B255
	public void Report(string key, string jsonLog)
	{
		RealThinkingAnalyticsReporter.Instance.Report(key, jsonLog);
		RealKRAnalyticsReporter.Instance.Report(key, jsonLog);
	}

	// Token: 0x17001526 RID: 5414
	// (get) Token: 0x06010ADE RID: 68318 RVA: 0x0040D06F File Offset: 0x0040B26F
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

	// Token: 0x06010ADF RID: 68319 RVA: 0x0040D092 File Offset: 0x0040B292
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010AE0 RID: 68320 RVA: 0x0040D094 File Offset: 0x0040B294
	public static void ResetStaticDefaultValue()
	{
		ThinkingAnalyticsReporter instance = ThinkingAnalyticsReporter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ThinkingAnalyticsReporter._instance = null;
	}

	// Token: 0x06010AE1 RID: 68321 RVA: 0x0040D0AD File Offset: 0x0040B2AD
	static ThinkingAnalyticsReporter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ThinkingAnalyticsReporter.CreateStaticDefaultValue), new Action(ThinkingAnalyticsReporter.ResetStaticDefaultValue));
	}

	// Token: 0x04007EFD RID: 32509
	[Nullable(2)]
	private static ThinkingAnalyticsReporter _instance;
}
