using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002285 RID: 8837
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeeklyChallengeConfig : ConfigBase
{
	// Token: 0x06015D84 RID: 89476 RVA: 0x006562BB File Offset: 0x006544BB
	public WeeklyFrameHelp? GetPlayConfigById(int playId)
	{
		return ConfigWeeklyFrameHelpById.GetConfig(playId, true);
	}

	// Token: 0x06015D85 RID: 89477 RVA: 0x006562C4 File Offset: 0x006544C4
	[NullableContext(2)]
	public IReadOnlyList<WeeklyFrameAward> GetAllScoreRewardTasks()
	{
		return ConfigWeeklyFrameAwardAll.GetConfigList(true);
	}

	// Token: 0x06015D86 RID: 89478 RVA: 0x006562CC File Offset: 0x006544CC
	public WeeklyFrameAward? GetScoreRewardTaskById(int taskId)
	{
		return ConfigWeeklyFrameAwardById.GetConfig(taskId, true);
	}

	// Token: 0x06015D87 RID: 89479 RVA: 0x006562D5 File Offset: 0x006544D5
	[NullableContext(2)]
	public IReadOnlyList<ActivityTab> GetAllActivityTabConfigs()
	{
		return ConfigActivityTabAll.GetConfigList(true);
	}

	// Token: 0x06015D88 RID: 89480 RVA: 0x006562DD File Offset: 0x006544DD
	public ActivityTab? GetActivityTabByType(int type)
	{
		return ConfigActivityTabByType.GetConfig(type, true);
	}

	// Token: 0x1700211F RID: 8479
	// (get) Token: 0x06015D89 RID: 89481 RVA: 0x006562E6 File Offset: 0x006544E6
	public static WeeklyChallengeConfig Instance
	{
		get
		{
			return WeeklyChallengeConfig._Instance;
		}
	}

	// Token: 0x06015D8A RID: 89482 RVA: 0x006562ED File Offset: 0x006544ED
	public static WeeklyChallengeConfig GetOrCreateInstance()
	{
		if (WeeklyChallengeConfig._Instance == null)
		{
			WeeklyChallengeConfig.CreateInstance();
		}
		return WeeklyChallengeConfig._Instance;
	}

	// Token: 0x06015D8B RID: 89483 RVA: 0x00656301 File Offset: 0x00654501
	public static bool CreateInstance()
	{
		if (WeeklyChallengeConfig._Instance != null)
		{
			return true;
		}
		WeeklyChallengeConfig._Instance = new WeeklyChallengeConfig();
		return true;
	}

	// Token: 0x06015D8C RID: 89484 RVA: 0x00656317 File Offset: 0x00654517
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015D8D RID: 89485 RVA: 0x00656319 File Offset: 0x00654519
	public static void ResetStaticDefaultValue()
	{
		WeeklyChallengeConfig._Instance = null;
	}

	// Token: 0x06015D8E RID: 89486 RVA: 0x00656321 File Offset: 0x00654521
	static WeeklyChallengeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyChallengeConfig.CreateStaticDefaultValue), new Action(WeeklyChallengeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B7FD RID: 47101
	[Nullable(2)]
	private static WeeklyChallengeConfig _Instance;
}
