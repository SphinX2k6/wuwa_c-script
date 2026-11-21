using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020022B5 RID: 8885
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeeklyRogueConfig : ConfigBase
{
	// Token: 0x06015F1C RID: 89884 RVA: 0x0065CF3C File Offset: 0x0065B13C
	public RogueWeeklyParam? GetWeeklyRogueParam(int id)
	{
		return ConfigRogueWeeklyParamById.GetConfig(id, true);
	}

	// Token: 0x06015F1D RID: 89885 RVA: 0x0065CF45 File Offset: 0x0065B145
	public RogueWeeklyRoomType? GetRogueWeeklyRoomType(int id)
	{
		return ConfigRogueWeeklyRoomTypeById.GetConfig(id, true);
	}

	// Token: 0x06015F1E RID: 89886 RVA: 0x0065CF4E File Offset: 0x0065B14E
	public RogueWeeklyBuffPool? GetRogueWeeklyBuffPool(int id)
	{
		return ConfigRogueWeeklyBuffPoolById.GetConfig(id, true);
	}

	// Token: 0x06015F1F RID: 89887 RVA: 0x0065CF57 File Offset: 0x0065B157
	[NullableContext(2)]
	public IReadOnlyList<RogueWeeklyBuffPool> GetRogueWeeklyBuffPoolByRelatedArtifactId(int artifactId)
	{
		return ConfigRogueWeeklyBuffPoolByRelatedArtifactId.GetConfigList(artifactId, true);
	}

	// Token: 0x06015F20 RID: 89888 RVA: 0x0065CF60 File Offset: 0x0065B160
	public RogueWeekQualityConfig? GetRogueWeeklyQualityConfig(int id)
	{
		return ConfigRogueWeekQualityConfigById.GetConfig(id, true);
	}

	// Token: 0x06015F21 RID: 89889 RVA: 0x0065CF69 File Offset: 0x0065B169
	public RogueWeeklyReward? GetRogueWeeklyRewardConfig(int id)
	{
		return ConfigRogueWeeklyRewardById.GetConfig(id, true);
	}

	// Token: 0x06015F22 RID: 89890 RVA: 0x0065CF72 File Offset: 0x0065B172
	public RogueWeeklyCycle? GetRogueWeeklyCycleConfig(int id)
	{
		return ConfigRogueWeeklyCycleById.GetConfig(id, true);
	}

	// Token: 0x06015F23 RID: 89891 RVA: 0x0065CF7B File Offset: 0x0065B17B
	public RogueWeeklyRoomType? GetRoomTypeConfig(int id)
	{
		return ConfigRogueWeeklyRoomTypeById.GetConfig(id, true);
	}

	// Token: 0x06015F24 RID: 89892 RVA: 0x0065CF84 File Offset: 0x0065B184
	public RogueWeeklyRoomPool? GetRoomPoolConfig(int id)
	{
		return ConfigRogueWeeklyRoomPoolById.GetConfig(id, true);
	}

	// Token: 0x06015F25 RID: 89893 RVA: 0x0065CF8D File Offset: 0x0065B18D
	public RogueWeekTag? GetRogueWeekTagConfig(int id)
	{
		return ConfigRogueWeekTagById.GetConfig(id, true);
	}

	// Token: 0x06015F26 RID: 89894 RVA: 0x0065CF96 File Offset: 0x0065B196
	public RogueWeeklyBF? GetBlackFlowerConfig(int id)
	{
		return ConfigRogueWeeklyBFById.GetConfig(id, true);
	}

	// Token: 0x06015F27 RID: 89895 RVA: 0x0065CFA0 File Offset: 0x0065B1A0
	public IReadOnlyList<RogueWeeklyBF> GetBlackFlowerConfigAll()
	{
		IReadOnlyList<RogueWeeklyBF> configList = ConfigRogueWeeklyBFAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<RogueWeeklyBF>();
		}
		return configList;
	}

	// Token: 0x17002141 RID: 8513
	// (get) Token: 0x06015F28 RID: 89896 RVA: 0x0065CFBE File Offset: 0x0065B1BE
	public static WeeklyRogueConfig Instance
	{
		get
		{
			return WeeklyRogueConfig._Instance;
		}
	}

	// Token: 0x06015F29 RID: 89897 RVA: 0x0065CFC5 File Offset: 0x0065B1C5
	public static WeeklyRogueConfig GetOrCreateInstance()
	{
		if (WeeklyRogueConfig._Instance == null)
		{
			WeeklyRogueConfig.CreateInstance();
		}
		return WeeklyRogueConfig._Instance;
	}

	// Token: 0x06015F2A RID: 89898 RVA: 0x0065CFD9 File Offset: 0x0065B1D9
	public static bool CreateInstance()
	{
		if (WeeklyRogueConfig._Instance != null)
		{
			return true;
		}
		WeeklyRogueConfig._Instance = new WeeklyRogueConfig();
		return true;
	}

	// Token: 0x06015F2B RID: 89899 RVA: 0x0065CFEF File Offset: 0x0065B1EF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015F2C RID: 89900 RVA: 0x0065CFF1 File Offset: 0x0065B1F1
	public static void ResetStaticDefaultValue()
	{
		WeeklyRogueConfig._Instance = null;
	}

	// Token: 0x06015F2D RID: 89901 RVA: 0x0065CFF9 File Offset: 0x0065B1F9
	static WeeklyRogueConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyRogueConfig.CreateStaticDefaultValue), new Action(WeeklyRogueConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B87A RID: 47226
	[Nullable(2)]
	private static WeeklyRogueConfig _Instance;
}
