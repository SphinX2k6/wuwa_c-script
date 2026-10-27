using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001C45 RID: 7237
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FunctionConfig : ConfigBase
{
	// Token: 0x0600DA43 RID: 55875 RVA: 0x0032B401 File Offset: 0x00329601
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600DA44 RID: 55876 RVA: 0x0032B404 File Offset: 0x00329604
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600DA45 RID: 55877 RVA: 0x0032B407 File Offset: 0x00329607
	[NullableContext(2)]
	public IReadOnlyList<PlayerExp> GetRangePlayerExpConfig(int sourceLevel, int targetLevel)
	{
		return ConfigPlayerExpByPlayerLevelArea.GetConfigList(sourceLevel, targetLevel, true);
	}

	// Token: 0x0600DA46 RID: 55878 RVA: 0x0032B411 File Offset: 0x00329611
	public PlayerExp? GetPlayerLevelConfig(int playerLevel)
	{
		return ConfigPlayerExpByPlayerLevel.GetConfig(playerLevel, true);
	}

	// Token: 0x0600DA47 RID: 55879 RVA: 0x0032B41A File Offset: 0x0032961A
	[NullableContext(2)]
	public IReadOnlyList<FunctionMenu> GetAllFunctionList()
	{
		return ConfigFunctionMenuAll.GetConfigList(true);
	}

	// Token: 0x0600DA48 RID: 55880 RVA: 0x0032B422 File Offset: 0x00329622
	public FunctionMenu? GetFunctionConfig(int functionId)
	{
		return ConfigFunctionMenuByFunctionId.GetConfig(functionId, true);
	}

	// Token: 0x0600DA49 RID: 55881 RVA: 0x0032B42B File Offset: 0x0032962B
	public FunctionCondition? GetFunctionCondition(int functionId)
	{
		return ConfigFunctionConditionByFunctionId.GetConfig(functionId, true);
	}

	// Token: 0x0600DA4A RID: 55882 RVA: 0x0032B434 File Offset: 0x00329634
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

	// Token: 0x0600DA4B RID: 55883 RVA: 0x0032B494 File Offset: 0x00329694
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

	// Token: 0x0600DA4C RID: 55884 RVA: 0x0032B4D4 File Offset: 0x003296D4
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

	// Token: 0x0600DA4D RID: 55885 RVA: 0x0032B504 File Offset: 0x00329704
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

	// Token: 0x170011D7 RID: 4567
	// (get) Token: 0x0600DA4E RID: 55886 RVA: 0x0032B534 File Offset: 0x00329734
	public static FunctionConfig Instance
	{
		get
		{
			return FunctionConfig._Instance;
		}
	}

	// Token: 0x0600DA4F RID: 55887 RVA: 0x0032B53B File Offset: 0x0032973B
	public static FunctionConfig GetOrCreateInstance()
	{
		if (FunctionConfig._Instance == null)
		{
			FunctionConfig.CreateInstance();
		}
		return FunctionConfig._Instance;
	}

	// Token: 0x0600DA50 RID: 55888 RVA: 0x0032B54F File Offset: 0x0032974F
	public static bool CreateInstance()
	{
		if (FunctionConfig._Instance != null)
		{
			return true;
		}
		FunctionConfig._Instance = new FunctionConfig();
		return true;
	}

	// Token: 0x0600DA51 RID: 55889 RVA: 0x0032B565 File Offset: 0x00329765
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA52 RID: 55890 RVA: 0x0032B567 File Offset: 0x00329767
	public static void ResetStaticDefaultValue()
	{
		FunctionConfig._Instance = null;
	}

	// Token: 0x0600DA53 RID: 55891 RVA: 0x0032B56F File Offset: 0x0032976F
	static FunctionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FunctionConfig.CreateStaticDefaultValue), new Action(FunctionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006360 RID: 25440
	[Nullable(2)]
	private static FunctionConfig _Instance;
}
