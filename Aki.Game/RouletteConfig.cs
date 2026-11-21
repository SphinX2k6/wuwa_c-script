using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001E7C RID: 7804
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RouletteConfig : ConfigBase
{
	// Token: 0x060134A7 RID: 79015 RVA: 0x005A3239 File Offset: 0x005A1439
	public ExploreTools? GetExploreConfigById(int id)
	{
		return ConfigExploreToolsByPhantomSkillId.GetConfig(id, true);
	}

	// Token: 0x060134A8 RID: 79016 RVA: 0x005A3242 File Offset: 0x005A1442
	public IReadOnlyList<ExploreRoulette> GetExploreRouletteConfig()
	{
		return ConfigExploreRouletteAll.GetConfigList(true) ?? new List<ExploreRoulette>();
	}

	// Token: 0x060134A9 RID: 79017 RVA: 0x005A3253 File Offset: 0x005A1453
	public IReadOnlyList<ExploreRouletteReplace> GetAllReplaceConfig()
	{
		return ConfigExploreRouletteReplaceAll.GetConfigList(true) ?? new List<ExploreRouletteReplace>();
	}

	// Token: 0x060134AA RID: 79018 RVA: 0x005A3264 File Offset: 0x005A1464
	public ExploreRouletteReplace? GetReplaceConfigById(int id)
	{
		return ConfigExploreRouletteReplaceById.GetConfig(id, true);
	}

	// Token: 0x060134AB RID: 79019 RVA: 0x005A326D File Offset: 0x005A146D
	public FuncMenuWheel? GetFuncConfigById(int id)
	{
		return ConfigFuncMenuWheelByFuncId.GetConfig(id, true);
	}

	// Token: 0x060134AC RID: 79020 RVA: 0x005A3276 File Offset: 0x005A1476
	[NullableContext(2)]
	public IReadOnlyList<ExploreTools> GetAllExploreConfig()
	{
		return ConfigExploreToolsAll.GetConfigList(true);
	}

	// Token: 0x060134AD RID: 79021 RVA: 0x005A327E File Offset: 0x005A147E
	[NullableContext(2)]
	public IReadOnlyList<FuncMenuWheel> GetAllFuncConfig()
	{
		return ConfigFuncMenuWheelAll.GetConfigList(true);
	}

	// Token: 0x060134AE RID: 79022 RVA: 0x005A3286 File Offset: 0x005A1486
	public string GetFuncMenuIconPathByConfig(FuncMenuWheel config)
	{
		if (config.UnlockCondition == 10001)
		{
			return FunctionConfig.Instance.GetRoleFunctionIconPath();
		}
		return config.FuncMenuIconPath;
	}

	// Token: 0x060134AF RID: 79023 RVA: 0x005A32A8 File Offset: 0x005A14A8
	public FuncMenuReplace? GetFuncReplaceConfig(int instSubType)
	{
		return ConfigFuncMenuReplaceInstSubType.GetConfig(instSubType, true);
	}

	// Token: 0x060134B0 RID: 79024 RVA: 0x005A32B1 File Offset: 0x005A14B1
	public FuncMenuReplace? GetFuncReplaceConfigById(int id)
	{
		return ConfigFuncMenuReplaceId.GetConfig(id, true);
	}

	// Token: 0x060134B1 RID: 79025 RVA: 0x005A32BA File Offset: 0x005A14BA
	public IReadOnlyList<FuncMenuReplace> GetAllFuncReplaceConfig()
	{
		return ConfigFuncMenuReplaceAll.GetConfigList(true) ?? new List<FuncMenuReplace>();
	}

	// Token: 0x060134B2 RID: 79026 RVA: 0x005A32CC File Offset: 0x005A14CC
	[NullableContext(2)]
	public string GetNameByPhantomSkillId(int phantomSkillId)
	{
		ExploreTools? config = ConfigExploreToolsByPhantomSkillId.GetConfig(phantomSkillId, true);
		if (config == null)
		{
			return null;
		}
		return ConfigMultiTextLang.GetLocalTextNew(config.Value.Name, null);
	}

	// Token: 0x060134B3 RID: 79027 RVA: 0x005A3304 File Offset: 0x005A1504
	[NullableContext(2)]
	public Dictionary<int, int> GetCostByPhantomSkillId(int phantomSkillId)
	{
		ExploreTools? config = ConfigExploreToolsByPhantomSkillId.GetConfig(phantomSkillId, true);
		if (config == null)
		{
			return null;
		}
		return config.Value.Cost();
	}

	// Token: 0x060134B4 RID: 79028 RVA: 0x005A3333 File Offset: 0x005A1533
	public ExploreRouletteType? GetExploreRouletteTypeById(int typeId)
	{
		return ConfigExploreRouletteTypeById.GetConfig(typeId, true);
	}

	// Token: 0x060134B5 RID: 79029 RVA: 0x005A333C File Offset: 0x005A153C
	public IReadOnlyList<ExploreRouletteType> GetAllRouletteTypeConfig()
	{
		return ConfigExploreRouletteTypeAll.GetConfigList(true) ?? new List<ExploreRouletteType>();
	}

	// Token: 0x060134B6 RID: 79030 RVA: 0x005A3350 File Offset: 0x005A1550
	public int GetTreasureBoxDetectorPlaceLimit()
	{
		return ConfigCommonParamById.GetIntConfig("TreasureBoxDetectionMaxNum").GetValueOrDefault();
	}

	// Token: 0x060134B7 RID: 79031 RVA: 0x005A3370 File Offset: 0x005A1570
	public int GetTempTeleporterPlaceLimit()
	{
		return ConfigCommonParamById.GetIntConfig("TemporaryTeleportCountLimit").GetValueOrDefault();
	}

	// Token: 0x060134B8 RID: 79032 RVA: 0x005A3390 File Offset: 0x005A1590
	public int GetSoundBoxPlaceLimit()
	{
		return ConfigCommonParamById.GetIntConfig("SoundBoxUseTimes").GetValueOrDefault();
	}

	// Token: 0x17001D69 RID: 7529
	// (get) Token: 0x060134B9 RID: 79033 RVA: 0x005A33AF File Offset: 0x005A15AF
	public static RouletteConfig Instance
	{
		get
		{
			return RouletteConfig._Instance;
		}
	}

	// Token: 0x060134BA RID: 79034 RVA: 0x005A33B6 File Offset: 0x005A15B6
	public static RouletteConfig GetOrCreateInstance()
	{
		if (RouletteConfig._Instance == null)
		{
			RouletteConfig.CreateInstance();
		}
		return RouletteConfig._Instance;
	}

	// Token: 0x060134BB RID: 79035 RVA: 0x005A33CA File Offset: 0x005A15CA
	public static bool CreateInstance()
	{
		if (RouletteConfig._Instance != null)
		{
			return true;
		}
		RouletteConfig._Instance = new RouletteConfig();
		return true;
	}

	// Token: 0x060134BC RID: 79036 RVA: 0x005A33E0 File Offset: 0x005A15E0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060134BD RID: 79037 RVA: 0x005A33E2 File Offset: 0x005A15E2
	public static void ResetStaticDefaultValue()
	{
		RouletteConfig._Instance = null;
	}

	// Token: 0x060134BE RID: 79038 RVA: 0x005A33EA File Offset: 0x005A15EA
	static RouletteConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteConfig.CreateStaticDefaultValue), new Action(RouletteConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A517 RID: 42263
	[Nullable(2)]
	private static RouletteConfig _Instance;
}
