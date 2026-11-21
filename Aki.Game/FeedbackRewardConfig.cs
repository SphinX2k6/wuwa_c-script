using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F91 RID: 3985
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FeedbackRewardConfig : ConfigBase
{
	// Token: 0x06009FC5 RID: 40901 RVA: 0x002F3195 File Offset: 0x002F1395
	public GivebackScoreReward? GetGivebackScoreRewardById(int id)
	{
		return ConfigGivebackScoreRewardById.GetConfig(id, true);
	}

	// Token: 0x06009FC6 RID: 40902 RVA: 0x002F319E File Offset: 0x002F139E
	[NullableContext(2)]
	public IReadOnlyList<GivebackScoreReward> GetGivebackScoreRewardAll()
	{
		return ConfigGivebackScoreRewardAll.GetConfigList(true);
	}

	// Token: 0x06009FC7 RID: 40903 RVA: 0x002F31A6 File Offset: 0x002F13A6
	public GivebackTask? GetGivebackTaskById(int id)
	{
		return ConfigGivebackTaskByTaskId.GetConfig(id, true);
	}

	// Token: 0x06009FC8 RID: 40904 RVA: 0x002F31AF File Offset: 0x002F13AF
	[NullableContext(2)]
	public IReadOnlyList<GivebackTask> GetGivebackTaskAll()
	{
		return ConfigGivebackTaskAll.GetConfigList(true);
	}

	// Token: 0x170010F8 RID: 4344
	// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x002F31B7 File Offset: 0x002F13B7
	public static FeedbackRewardConfig Instance
	{
		get
		{
			return FeedbackRewardConfig._Instance;
		}
	}

	// Token: 0x06009FCA RID: 40906 RVA: 0x002F31BE File Offset: 0x002F13BE
	public static FeedbackRewardConfig GetOrCreateInstance()
	{
		if (FeedbackRewardConfig._Instance == null)
		{
			FeedbackRewardConfig.CreateInstance();
		}
		return FeedbackRewardConfig._Instance;
	}

	// Token: 0x06009FCB RID: 40907 RVA: 0x002F31D2 File Offset: 0x002F13D2
	public static bool CreateInstance()
	{
		if (FeedbackRewardConfig._Instance != null)
		{
			return true;
		}
		FeedbackRewardConfig._Instance = new FeedbackRewardConfig();
		return true;
	}

	// Token: 0x06009FCC RID: 40908 RVA: 0x002F31E8 File Offset: 0x002F13E8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009FCD RID: 40909 RVA: 0x002F31EA File Offset: 0x002F13EA
	public static void ResetStaticDefaultValue()
	{
		FeedbackRewardConfig._Instance = null;
	}

	// Token: 0x06009FCE RID: 40910 RVA: 0x002F31F2 File Offset: 0x002F13F2
	static FeedbackRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeedbackRewardConfig.CreateStaticDefaultValue), new Action(FeedbackRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005E7C RID: 24188
	[Nullable(2)]
	private static FeedbackRewardConfig _Instance;
}
