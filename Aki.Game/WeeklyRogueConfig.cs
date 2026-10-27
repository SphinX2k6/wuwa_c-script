using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002D5B RID: 11611
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeeklyRogueConfig : ConfigBase
{
	// Token: 0x0601867A RID: 99962 RVA: 0x00636F2C File Offset: 0x0063512C
	public RogueWeeklyParam? GetWeeklyRogueParam(int id)
	{
		return ConfigRogueWeeklyParamById.GetConfig(id, true);
	}

	// Token: 0x0601867B RID: 99963 RVA: 0x00636F35 File Offset: 0x00635135
	public RogueWeeklyRoomType? GetRogueWeeklyRoomType(int id)
	{
		return ConfigRogueWeeklyRoomTypeById.GetConfig(id, true);
	}

	// Token: 0x0601867C RID: 99964 RVA: 0x00636F3E File Offset: 0x0063513E
	public RogueWeeklyBuffPool? GetRogueWeeklyBuffPool(int id)
	{
		return ConfigRogueWeeklyBuffPoolById.GetConfig(id, true);
	}

	// Token: 0x0601867D RID: 99965 RVA: 0x00636F47 File Offset: 0x00635147
	[NullableContext(2)]
	public IReadOnlyList<RogueWeeklyBuffPool> GetRogueWeeklyBuffPoolByRelatedArtifactId(int artifactId)
	{
		return ConfigRogueWeeklyBuffPoolByRelatedArtifactId.GetConfigList(artifactId, true);
	}

	// Token: 0x0601867E RID: 99966 RVA: 0x00636F50 File Offset: 0x00635150
	public RogueWeekQualityConfig? GetRogueWeeklyQualityConfig(int id)
	{
		return ConfigRogueWeekQualityConfigById.GetConfig(id, true);
	}

	// Token: 0x0601867F RID: 99967 RVA: 0x00636F59 File Offset: 0x00635159
	public RogueWeeklyReward? GetRogueWeeklyRewardConfig(int id)
	{
		return ConfigRogueWeeklyRewardById.GetConfig(id, true);
	}

	// Token: 0x06018680 RID: 99968 RVA: 0x00636F62 File Offset: 0x00635162
	public RogueWeeklyCycle? GetRogueWeeklyCycleConfig(int id)
	{
		return ConfigRogueWeeklyCycleById.GetConfig(id, true);
	}

	// Token: 0x06018681 RID: 99969 RVA: 0x00636F6B File Offset: 0x0063516B
	public RogueWeeklyRoomType? GetRoomTypeConfig(int id)
	{
		return ConfigRogueWeeklyRoomTypeById.GetConfig(id, true);
	}

	// Token: 0x06018682 RID: 99970 RVA: 0x00636F74 File Offset: 0x00635174
	public RogueWeeklyRoomPool? GetRoomPoolConfig(int id)
	{
		return ConfigRogueWeeklyRoomPoolById.GetConfig(id, true);
	}

	// Token: 0x06018683 RID: 99971 RVA: 0x00636F7D File Offset: 0x0063517D
	public RogueWeekTag? GetRogueWeekTagConfig(int id)
	{
		return ConfigRogueWeekTagById.GetConfig(id, true);
	}

	// Token: 0x06018684 RID: 99972 RVA: 0x00636F86 File Offset: 0x00635186
	public RogueWeeklyBF? GetBlackFlowerConfig(int id)
	{
		return ConfigRogueWeeklyBFById.GetConfig(id, true);
	}

	// Token: 0x06018685 RID: 99973 RVA: 0x00636F90 File Offset: 0x00635190
	public IReadOnlyList<RogueWeeklyBF> GetBlackFlowerConfigAll()
	{
		IReadOnlyList<RogueWeeklyBF> configList = ConfigRogueWeeklyBFAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<RogueWeeklyBF>();
		}
		return configList;
	}

	// Token: 0x170020E6 RID: 8422
	// (get) Token: 0x06018686 RID: 99974 RVA: 0x00636FAE File Offset: 0x006351AE
	public static WeeklyRogueConfig Instance
	{
		get
		{
			return WeeklyRogueConfig._Instance;
		}
	}

	// Token: 0x06018687 RID: 99975 RVA: 0x00636FB5 File Offset: 0x006351B5
	public static WeeklyRogueConfig GetOrCreateInstance()
	{
		if (WeeklyRogueConfig._Instance == null)
		{
			WeeklyRogueConfig.CreateInstance();
		}
		return WeeklyRogueConfig._Instance;
	}

	// Token: 0x06018688 RID: 99976 RVA: 0x00636FC9 File Offset: 0x006351C9
	public static bool CreateInstance()
	{
		if (WeeklyRogueConfig._Instance != null)
		{
			return true;
		}
		WeeklyRogueConfig._Instance = new WeeklyRogueConfig();
		return true;
	}

	// Token: 0x06018689 RID: 99977 RVA: 0x00636FDF File Offset: 0x006351DF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601868A RID: 99978 RVA: 0x00636FE1 File Offset: 0x006351E1
	public static void ResetStaticDefaultValue()
	{
		WeeklyRogueConfig._Instance = null;
	}

	// Token: 0x0601868B RID: 99979 RVA: 0x00636FE9 File Offset: 0x006351E9
	static WeeklyRogueConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyRogueConfig.CreateStaticDefaultValue), new Action(WeeklyRogueConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B505 RID: 46341
	[Nullable(2)]
	private static WeeklyRogueConfig _Instance;
}
