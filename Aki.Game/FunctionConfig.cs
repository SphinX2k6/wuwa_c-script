using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001104 RID: 4356
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FunctionConfig : ConfigBase
{
	// Token: 0x0600AE59 RID: 44633 RVA: 0x0033680D File Offset: 0x00334A0D
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600AE5A RID: 44634 RVA: 0x00336810 File Offset: 0x00334A10
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600AE5B RID: 44635 RVA: 0x00336813 File Offset: 0x00334A13
	[NullableContext(2)]
	public IReadOnlyList<PlayerExp> GetRangePlayerExpConfig(int sourceLevel, int targetLevel)
	{
		return ConfigPlayerExpByPlayerLevelArea.GetConfigList(sourceLevel, targetLevel, true);
	}

	// Token: 0x0600AE5C RID: 44636 RVA: 0x0033681D File Offset: 0x00334A1D
	public PlayerExp? GetPlayerLevelConfig(int playerLevel)
	{
		return ConfigPlayerExpByPlayerLevel.GetConfig(playerLevel, true);
	}

	// Token: 0x0600AE5D RID: 44637 RVA: 0x00336826 File Offset: 0x00334A26
	[NullableContext(2)]
	public IReadOnlyList<FunctionMenu> GetAllFunctionList()
	{
		return ConfigFunctionMenuAll.GetConfigList(true);
	}

	// Token: 0x0600AE5E RID: 44638 RVA: 0x0033682E File Offset: 0x00334A2E
	public FunctionMenu? GetFunctionConfig(int functionId)
	{
		return ConfigFunctionMenuByFunctionId.GetConfig(functionId, true);
	}

	// Token: 0x0600AE5F RID: 44639 RVA: 0x00336837 File Offset: 0x00334A37
	public FunctionCondition? GetFunctionCondition(int functionId)
	{
		return ConfigFunctionConditionByFunctionId.GetConfig(functionId, true);
	}

	// Token: 0x0600AE60 RID: 44640 RVA: 0x00336840 File Offset: 0x00334A40
	public int GetDifferenceExp(int sourceLevel, int sourceExp, int targetLevel, int targetExp)
	{
		int num = 0;
		IReadOnlyList<PlayerExp> configList = ConfigPlayerExpByPlayerLevelArea.GetConfigList(sourceLevel, targetLevel, true);
		if (configList != null)
		{
			foreach (PlayerExp playerExp in configList)
			{
				num += playerExp.LevelExp;
			}
		}
		return num - sourceExp + targetExp;
	}

	// Token: 0x0600AE61 RID: 44641 RVA: 0x003368A0 File Offset: 0x00334AA0
	[NullableContext(2)]
	public string GetFunctionIconPath(int functionId)
	{
		FunctionMenu? functionConfig = this.GetFunctionConfig(functionId);
		if (functionConfig == null)
		{
			return null;
		}
		if (functionId == 10001)
		{
			return this.GetRoleFunctionIconPath();
		}
		return functionConfig.Value.FunctionIcon;
	}

	// Token: 0x0600AE62 RID: 44642 RVA: 0x003368E0 File Offset: 0x00334AE0
	public string GetRoleFunctionIconPath()
	{
		bool sex = WorldLevelModel.Instance.Sex != 0;
		string resourceId = "SP_FuncIconRole";
		if (!sex)
		{
			resourceId = "SP_FuncIconRole2";
		}
		return UiResourceConfig.Instance.GetResourcePath(resourceId);
	}

	// Token: 0x0600AE63 RID: 44643 RVA: 0x00336910 File Offset: 0x00334B10
	public string GetFightIconResonancePath()
	{
		bool sex = WorldLevelModel.Instance.Sex != 0;
		string resourceId = "SP_FightIconResonance";
		if (!sex)
		{
			resourceId = "SP_FightIconResonance2";
		}
		return UiResourceConfig.Instance.GetResourcePath(resourceId);
	}

	// Token: 0x170011FD RID: 4605
	// (get) Token: 0x0600AE64 RID: 44644 RVA: 0x00336940 File Offset: 0x00334B40
	public static FunctionConfig Instance
	{
		get
		{
			return FunctionConfig._Instance;
		}
	}

	// Token: 0x0600AE65 RID: 44645 RVA: 0x00336947 File Offset: 0x00334B47
	public static FunctionConfig GetOrCreateInstance()
	{
		if (FunctionConfig._Instance == null)
		{
			FunctionConfig.CreateInstance();
		}
		return FunctionConfig._Instance;
	}

	// Token: 0x0600AE66 RID: 44646 RVA: 0x0033695B File Offset: 0x00334B5B
	public static bool CreateInstance()
	{
		if (FunctionConfig._Instance != null)
		{
			return true;
		}
		FunctionConfig._Instance = new FunctionConfig();
		return true;
	}

	// Token: 0x0600AE67 RID: 44647 RVA: 0x00336971 File Offset: 0x00334B71
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AE68 RID: 44648 RVA: 0x00336973 File Offset: 0x00334B73
	public static void ResetStaticDefaultValue()
	{
		FunctionConfig._Instance = null;
	}

	// Token: 0x0600AE69 RID: 44649 RVA: 0x0033697B File Offset: 0x00334B7B
	static FunctionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FunctionConfig.CreateStaticDefaultValue), new Action(FunctionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006432 RID: 25650
	[Nullable(2)]
	private static FunctionConfig _Instance;
}
