using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F5B RID: 3931
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ExploreProgressConfig : ConfigBase
{
	// Token: 0x06009DC2 RID: 40386 RVA: 0x002EC423 File Offset: 0x002EA623
	public ExploreProgress? GetExploreProgressConfigById(int id)
	{
		return ConfigExploreProgressById.GetConfig(id, true);
	}

	// Token: 0x06009DC3 RID: 40387 RVA: 0x002EC42C File Offset: 0x002EA62C
	public IReadOnlyList<ExploreProgress> GetExploreProgressConfigListByArea(int areaId)
	{
		return ConfigExploreProgressByArea.GetConfigList(areaId, true);
	}

	// Token: 0x06009DC4 RID: 40388 RVA: 0x002EC435 File Offset: 0x002EA635
	public IReadOnlyList<ExploreProgress> GetAllExploreProgressConfig()
	{
		return ConfigExploreProgressAll.GetConfigList(true);
	}

	// Token: 0x06009DC5 RID: 40389 RVA: 0x002EC43D File Offset: 0x002EA63D
	public IReadOnlyList<AreaTaskExplore> GetAreaMissionConfigByAreaId(int areaId)
	{
		return ConfigAreaTaskExploreByAreaId.GetConfigList(areaId, true);
	}

	// Token: 0x06009DC6 RID: 40390 RVA: 0x002EC446 File Offset: 0x002EA646
	public State? GetStateConfigByStateId(int stateId)
	{
		return ConfigStateByStateId.GetConfig(stateId, true);
	}

	// Token: 0x06009DC7 RID: 40391 RVA: 0x002EC44F File Offset: 0x002EA64F
	public IReadOnlyList<ExploreProgressReward> GetAreaStageAwardConfigByAreaId(int areaId)
	{
		return ConfigExploreProgressRewardByArea.GetConfigList(areaId, true);
	}

	// Token: 0x06009DC8 RID: 40392 RVA: 0x002EC458 File Offset: 0x002EA658
	public IReadOnlyList<ExploreProgressReward> GetAreaStageRewardConfigList()
	{
		return ConfigExploreProgressRewardAll.GetConfigList(true);
	}

	// Token: 0x06009DC9 RID: 40393 RVA: 0x002EC460 File Offset: 0x002EA660
	public ExploreType? GetExploreTypeByType(int type)
	{
		return ConfigExploreTypeByType.GetConfig(type, true);
	}

	// Token: 0x170010A7 RID: 4263
	// (get) Token: 0x06009DCA RID: 40394 RVA: 0x002EC469 File Offset: 0x002EA669
	[Nullable(1)]
	public static ExploreProgressConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ExploreProgressConfig._Instance;
		}
	}

	// Token: 0x06009DCB RID: 40395 RVA: 0x002EC470 File Offset: 0x002EA670
	[NullableContext(1)]
	public static ExploreProgressConfig GetOrCreateInstance()
	{
		if (ExploreProgressConfig._Instance == null)
		{
			ExploreProgressConfig.CreateInstance();
		}
		return ExploreProgressConfig._Instance;
	}

	// Token: 0x06009DCC RID: 40396 RVA: 0x002EC484 File Offset: 0x002EA684
	public static bool CreateInstance()
	{
		if (ExploreProgressConfig._Instance != null)
		{
			return true;
		}
		ExploreProgressConfig._Instance = new ExploreProgressConfig();
		return true;
	}

	// Token: 0x06009DCD RID: 40397 RVA: 0x002EC49A File Offset: 0x002EA69A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009DCE RID: 40398 RVA: 0x002EC49C File Offset: 0x002EA69C
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressConfig._Instance = null;
	}

	// Token: 0x06009DCF RID: 40399 RVA: 0x002EC4A4 File Offset: 0x002EA6A4
	static ExploreProgressConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressConfig.CreateStaticDefaultValue), new Action(ExploreProgressConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005DB5 RID: 23989
	private static ExploreProgressConfig _Instance;
}
