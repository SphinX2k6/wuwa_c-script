using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002901 RID: 10497
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RouletteConfig : ConfigBase
{
	// Token: 0x06015AA3 RID: 88739 RVA: 0x00578345 File Offset: 0x00576545
	public ExploreTools? GetExploreConfigById(int id)
	{
		return ConfigExploreToolsByPhantomSkillId.GetConfig(id, true);
	}

	// Token: 0x06015AA4 RID: 88740 RVA: 0x0057834E File Offset: 0x0057654E
	public IReadOnlyList<ExploreRoulette> GetExploreRouletteConfig()
	{
		return ConfigExploreRouletteAll.GetConfigList(true) ?? new List<ExploreRoulette>();
	}

	// Token: 0x06015AA5 RID: 88741 RVA: 0x0057835F File Offset: 0x0057655F
	public IReadOnlyList<ExploreRouletteReplace> GetAllReplaceConfig()
	{
		return ConfigExploreRouletteReplaceAll.GetConfigList(true) ?? new List<ExploreRouletteReplace>();
	}

	// Token: 0x06015AA6 RID: 88742 RVA: 0x00578370 File Offset: 0x00576570
	public ExploreRouletteReplace? GetReplaceConfigById(int id)
	{
		return ConfigExploreRouletteReplaceById.GetConfig(id, true);
	}

	// Token: 0x06015AA7 RID: 88743 RVA: 0x00578379 File Offset: 0x00576579
	public FuncMenuWheel? GetFuncConfigById(int id)
	{
		return ConfigFuncMenuWheelByFuncId.GetConfig(id, true);
	}

	// Token: 0x06015AA8 RID: 88744 RVA: 0x00578382 File Offset: 0x00576582
	[NullableContext(2)]
	public IReadOnlyList<ExploreTools> GetAllExploreConfig()
	{
		return ConfigExploreToolsAll.GetConfigList(true);
	}

	// Token: 0x06015AA9 RID: 88745 RVA: 0x0057838A File Offset: 0x0057658A
	[NullableContext(2)]
	public IReadOnlyList<FuncMenuWheel> GetAllFuncConfig()
	{
		return ConfigFuncMenuWheelAll.GetConfigList(true);
	}

	// Token: 0x06015AAA RID: 88746 RVA: 0x00578392 File Offset: 0x00576592
	public string GetFuncMenuIconPathByConfig(FuncMenuWheel config)
	{
		if (config.UnlockCondition == 10001)
		{
			return FunctionConfig.Instance.GetRoleFunctionIconPath();
		}
		return config.FuncMenuIconPath;
	}

	// Token: 0x06015AAB RID: 88747 RVA: 0x005783B4 File Offset: 0x005765B4
	public FuncMenuReplace? GetFuncReplaceConfig(int instSubType)
	{
		return ConfigFuncMenuReplaceInstSubType.GetConfig(instSubType, true);
	}

	// Token: 0x06015AAC RID: 88748 RVA: 0x005783BD File Offset: 0x005765BD
	public FuncMenuReplace? GetFuncReplaceConfigById(int id)
	{
		return ConfigFuncMenuReplaceId.GetConfig(id, true);
	}

	// Token: 0x06015AAD RID: 88749 RVA: 0x005783C6 File Offset: 0x005765C6
	public IReadOnlyList<FuncMenuReplace> GetAllFuncReplaceConfig()
	{
		return ConfigFuncMenuReplaceAll.GetConfigList(true) ?? new List<FuncMenuReplace>();
	}

	// Token: 0x06015AAE RID: 88750 RVA: 0x005783D8 File Offset: 0x005765D8
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

	// Token: 0x06015AAF RID: 88751 RVA: 0x00578410 File Offset: 0x00576610
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

	// Token: 0x06015AB0 RID: 88752 RVA: 0x0057843F File Offset: 0x0057663F
	public ExploreRouletteType? GetExploreRouletteTypeById(int typeId)
	{
		return ConfigExploreRouletteTypeById.GetConfig(typeId, true);
	}

	// Token: 0x06015AB1 RID: 88753 RVA: 0x00578448 File Offset: 0x00576648
	public IReadOnlyList<ExploreRouletteType> GetAllRouletteTypeConfig()
	{
		return ConfigExploreRouletteTypeAll.GetConfigList(true) ?? new List<ExploreRouletteType>();
	}

	// Token: 0x06015AB2 RID: 88754 RVA: 0x0057845C File Offset: 0x0057665C
	public int GetTreasureBoxDetectorPlaceLimit()
	{
		return ConfigCommonParamById.GetIntConfig("TreasureBoxDetectionMaxNum").GetValueOrDefault();
	}

	// Token: 0x06015AB3 RID: 88755 RVA: 0x0057847C File Offset: 0x0057667C
	public int GetTempTeleporterPlaceLimit()
	{
		return ConfigCommonParamById.GetIntConfig("TemporaryTeleportCountLimit").GetValueOrDefault();
	}

	// Token: 0x06015AB4 RID: 88756 RVA: 0x0057849C File Offset: 0x0057669C
	public int GetSoundBoxPlaceLimit()
	{
		return ConfigCommonParamById.GetIntConfig("SoundBoxUseTimes").GetValueOrDefault();
	}

	// Token: 0x17001D0F RID: 7439
	// (get) Token: 0x06015AB5 RID: 88757 RVA: 0x005784BB File Offset: 0x005766BB
	public static RouletteConfig Instance
	{
		get
		{
			return RouletteConfig._Instance;
		}
	}

	// Token: 0x06015AB6 RID: 88758 RVA: 0x005784C2 File Offset: 0x005766C2
	public static RouletteConfig GetOrCreateInstance()
	{
		if (RouletteConfig._Instance == null)
		{
			RouletteConfig.CreateInstance();
		}
		return RouletteConfig._Instance;
	}

	// Token: 0x06015AB7 RID: 88759 RVA: 0x005784D6 File Offset: 0x005766D6
	public static bool CreateInstance()
	{
		if (RouletteConfig._Instance != null)
		{
			return true;
		}
		RouletteConfig._Instance = new RouletteConfig();
		return true;
	}

	// Token: 0x06015AB8 RID: 88760 RVA: 0x005784EC File Offset: 0x005766EC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015AB9 RID: 88761 RVA: 0x005784EE File Offset: 0x005766EE
	public static void ResetStaticDefaultValue()
	{
		RouletteConfig._Instance = null;
	}

	// Token: 0x06015ABA RID: 88762 RVA: 0x005784F6 File Offset: 0x005766F6
	static RouletteConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteConfig.CreateStaticDefaultValue), new Action(RouletteConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A12C RID: 41260
	[Nullable(2)]
	private static RouletteConfig _Instance;
}
