using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002D2B RID: 11563
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeeklyChallengeConfig : ConfigBase
{
	// Token: 0x060184E2 RID: 99554 RVA: 0x006302A7 File Offset: 0x0062E4A7
	public WeeklyFrameHelp? GetPlayConfigById(int playId)
	{
		return ConfigWeeklyFrameHelpById.GetConfig(playId, true);
	}

	// Token: 0x060184E3 RID: 99555 RVA: 0x006302B0 File Offset: 0x0062E4B0
	[NullableContext(2)]
	public IReadOnlyList<WeeklyFrameAward> GetAllScoreRewardTasks()
	{
		return ConfigWeeklyFrameAwardAll.GetConfigList(true);
	}

	// Token: 0x060184E4 RID: 99556 RVA: 0x006302B8 File Offset: 0x0062E4B8
	public WeeklyFrameAward? GetScoreRewardTaskById(int taskId)
	{
		return ConfigWeeklyFrameAwardById.GetConfig(taskId, true);
	}

	// Token: 0x060184E5 RID: 99557 RVA: 0x006302C1 File Offset: 0x0062E4C1
	[NullableContext(2)]
	public IReadOnlyList<ActivityTab> GetAllActivityTabConfigs()
	{
		return ConfigActivityTabAll.GetConfigList(true);
	}

	// Token: 0x060184E6 RID: 99558 RVA: 0x006302C9 File Offset: 0x0062E4C9
	public ActivityTab? GetActivityTabByType(int type)
	{
		return ConfigActivityTabByType.GetConfig(type, true);
	}

	// Token: 0x170020C4 RID: 8388
	// (get) Token: 0x060184E7 RID: 99559 RVA: 0x006302D2 File Offset: 0x0062E4D2
	public static WeeklyChallengeConfig Instance
	{
		get
		{
			return WeeklyChallengeConfig._Instance;
		}
	}

	// Token: 0x060184E8 RID: 99560 RVA: 0x006302D9 File Offset: 0x0062E4D9
	public static WeeklyChallengeConfig GetOrCreateInstance()
	{
		if (WeeklyChallengeConfig._Instance == null)
		{
			WeeklyChallengeConfig.CreateInstance();
		}
		return WeeklyChallengeConfig._Instance;
	}

	// Token: 0x060184E9 RID: 99561 RVA: 0x006302ED File Offset: 0x0062E4ED
	public static bool CreateInstance()
	{
		if (WeeklyChallengeConfig._Instance != null)
		{
			return true;
		}
		WeeklyChallengeConfig._Instance = new WeeklyChallengeConfig();
		return true;
	}

	// Token: 0x060184EA RID: 99562 RVA: 0x00630303 File Offset: 0x0062E503
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060184EB RID: 99563 RVA: 0x00630305 File Offset: 0x0062E505
	public static void ResetStaticDefaultValue()
	{
		WeeklyChallengeConfig._Instance = null;
	}

	// Token: 0x060184EC RID: 99564 RVA: 0x0063030D File Offset: 0x0062E50D
	static WeeklyChallengeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyChallengeConfig.CreateStaticDefaultValue), new Action(WeeklyChallengeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B488 RID: 46216
	[Nullable(2)]
	private static WeeklyChallengeConfig _Instance;
}
