using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A9C RID: 6812
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ExploreProgressConfig : ConfigBase
{
	// Token: 0x0600C9B1 RID: 51633 RVA: 0x002E12CF File Offset: 0x002DF4CF
	public ExploreProgress? GetExploreProgressConfigById(int id)
	{
		return ConfigExploreProgressById.GetConfig(id, true);
	}

	// Token: 0x0600C9B2 RID: 51634 RVA: 0x002E12D8 File Offset: 0x002DF4D8
	public IReadOnlyList<ExploreProgress> GetExploreProgressConfigListByArea(int areaId)
	{
		return ConfigExploreProgressByArea.GetConfigList(areaId, true);
	}

	// Token: 0x0600C9B3 RID: 51635 RVA: 0x002E12E1 File Offset: 0x002DF4E1
	public IReadOnlyList<ExploreProgress> GetAllExploreProgressConfig()
	{
		return ConfigExploreProgressAll.GetConfigList(true);
	}

	// Token: 0x0600C9B4 RID: 51636 RVA: 0x002E12E9 File Offset: 0x002DF4E9
	public IReadOnlyList<AreaTaskExplore> GetAreaMissionConfigByAreaId(int areaId)
	{
		return ConfigAreaTaskExploreByAreaId.GetConfigList(areaId, true);
	}

	// Token: 0x0600C9B5 RID: 51637 RVA: 0x002E12F2 File Offset: 0x002DF4F2
	public State? GetStateConfigByStateId(int stateId)
	{
		return ConfigStateByStateId.GetConfig(stateId, true);
	}

	// Token: 0x0600C9B6 RID: 51638 RVA: 0x002E12FB File Offset: 0x002DF4FB
	public IReadOnlyList<ExploreProgressReward> GetAreaStageAwardConfigByAreaId(int areaId)
	{
		return ConfigExploreProgressRewardByArea.GetConfigList(areaId, true);
	}

	// Token: 0x0600C9B7 RID: 51639 RVA: 0x002E1304 File Offset: 0x002DF504
	public IReadOnlyList<ExploreProgressReward> GetAreaStageRewardConfigList()
	{
		return ConfigExploreProgressRewardAll.GetConfigList(true);
	}

	// Token: 0x0600C9B8 RID: 51640 RVA: 0x002E130C File Offset: 0x002DF50C
	public ExploreType? GetExploreTypeByType(int type)
	{
		return ConfigExploreTypeByType.GetConfig(type, true);
	}

	// Token: 0x17001082 RID: 4226
	// (get) Token: 0x0600C9B9 RID: 51641 RVA: 0x002E1315 File Offset: 0x002DF515
	[Nullable(1)]
	public static ExploreProgressConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ExploreProgressConfig._Instance;
		}
	}

	// Token: 0x0600C9BA RID: 51642 RVA: 0x002E131C File Offset: 0x002DF51C
	[NullableContext(1)]
	public static ExploreProgressConfig GetOrCreateInstance()
	{
		if (ExploreProgressConfig._Instance == null)
		{
			ExploreProgressConfig.CreateInstance();
		}
		return ExploreProgressConfig._Instance;
	}

	// Token: 0x0600C9BB RID: 51643 RVA: 0x002E1330 File Offset: 0x002DF530
	public static bool CreateInstance()
	{
		if (ExploreProgressConfig._Instance != null)
		{
			return true;
		}
		ExploreProgressConfig._Instance = new ExploreProgressConfig();
		return true;
	}

	// Token: 0x0600C9BC RID: 51644 RVA: 0x002E1346 File Offset: 0x002DF546
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C9BD RID: 51645 RVA: 0x002E1348 File Offset: 0x002DF548
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressConfig._Instance = null;
	}

	// Token: 0x0600C9BE RID: 51646 RVA: 0x002E1350 File Offset: 0x002DF550
	static ExploreProgressConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressConfig.CreateStaticDefaultValue), new Action(ExploreProgressConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005CE6 RID: 23782
	private static ExploreProgressConfig _Instance;
}
