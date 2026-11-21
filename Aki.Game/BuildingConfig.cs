using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020007A0 RID: 1952
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BuildingConfig : ConfigBase
{
	// Token: 0x0600596E RID: 22894 RVA: 0x001D1258 File Offset: 0x001CF458
	public IReadOnlyList<Building> GetBuildingAll()
	{
		IReadOnlyList<Building> configList = ConfigBuildingAll.GetConfigList(true);
		return configList ?? new List<Building>();
	}

	// Token: 0x0600596F RID: 22895 RVA: 0x001D1278 File Offset: 0x001CF478
	public Building GetBuildingById(int id)
	{
		return ConfigBuildingById.GetConfig(id, true).GetValueOrDefault();
	}

	// Token: 0x06005970 RID: 22896 RVA: 0x001D1294 File Offset: 0x001CF494
	public BuildingUpGradeCurve GetBuildingUpGradeCurveByGroupIdAndLevel(int groupId, int level)
	{
		return ConfigBuildingUpGradeCurveByGroupIdAndLevel.GetConfig(groupId, level, true).GetValueOrDefault();
	}

	// Token: 0x06005971 RID: 22897 RVA: 0x001D12B4 File Offset: 0x001CF4B4
	public IReadOnlyList<BuildingUpGradeCurve> GetBuildingUpGradeCurveByGroupId(int groupId)
	{
		IReadOnlyList<BuildingUpGradeCurve> configList = ConfigBuildingUpGradeCurveByGroupId.GetConfigList(groupId, true);
		return configList ?? new List<BuildingUpGradeCurve>();
	}

	// Token: 0x17000B9A RID: 2970
	// (get) Token: 0x06005972 RID: 22898 RVA: 0x001D12D3 File Offset: 0x001CF4D3
	public static BuildingConfig Instance
	{
		get
		{
			return BuildingConfig._Instance;
		}
	}

	// Token: 0x06005973 RID: 22899 RVA: 0x001D12DA File Offset: 0x001CF4DA
	public static BuildingConfig GetOrCreateInstance()
	{
		if (BuildingConfig._Instance == null)
		{
			BuildingConfig.CreateInstance();
		}
		return BuildingConfig._Instance;
	}

	// Token: 0x06005974 RID: 22900 RVA: 0x001D12EE File Offset: 0x001CF4EE
	public static bool CreateInstance()
	{
		if (BuildingConfig._Instance != null)
		{
			return true;
		}
		BuildingConfig._Instance = new BuildingConfig();
		return true;
	}

	// Token: 0x06005975 RID: 22901 RVA: 0x001D1304 File Offset: 0x001CF504
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005976 RID: 22902 RVA: 0x001D1306 File Offset: 0x001CF506
	public static void ResetStaticDefaultValue()
	{
		BuildingConfig._Instance = null;
	}

	// Token: 0x06005977 RID: 22903 RVA: 0x001D130E File Offset: 0x001CF50E
	static BuildingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuildingConfig.CreateStaticDefaultValue), new Action(BuildingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003C9D RID: 15517
	[Nullable(2)]
	private static BuildingConfig _Instance;
}
