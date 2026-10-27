using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012EC RID: 4844
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BuildingConfig : ConfigBase
{
	// Token: 0x060085D3 RID: 34259 RVA: 0x001C83EC File Offset: 0x001C65EC
	public IReadOnlyList<Building> GetBuildingAll()
	{
		IReadOnlyList<Building> configList = ConfigBuildingAll.GetConfigList(true);
		return configList ?? new List<Building>();
	}

	// Token: 0x060085D4 RID: 34260 RVA: 0x001C840C File Offset: 0x001C660C
	public Building GetBuildingById(int id)
	{
		return ConfigBuildingById.GetConfig(id, true).GetValueOrDefault();
	}

	// Token: 0x060085D5 RID: 34261 RVA: 0x001C8428 File Offset: 0x001C6628
	public BuildingUpGradeCurve GetBuildingUpGradeCurveByGroupIdAndLevel(int groupId, int level)
	{
		return ConfigBuildingUpGradeCurveByGroupIdAndLevel.GetConfig(groupId, level, true).GetValueOrDefault();
	}

	// Token: 0x060085D6 RID: 34262 RVA: 0x001C8448 File Offset: 0x001C6648
	public IReadOnlyList<BuildingUpGradeCurve> GetBuildingUpGradeCurveByGroupId(int groupId)
	{
		IReadOnlyList<BuildingUpGradeCurve> configList = ConfigBuildingUpGradeCurveByGroupId.GetConfigList(groupId, true);
		return configList ?? new List<BuildingUpGradeCurve>();
	}

	// Token: 0x17000B7A RID: 2938
	// (get) Token: 0x060085D7 RID: 34263 RVA: 0x001C8467 File Offset: 0x001C6667
	public static BuildingConfig Instance
	{
		get
		{
			return BuildingConfig._Instance;
		}
	}

	// Token: 0x060085D8 RID: 34264 RVA: 0x001C846E File Offset: 0x001C666E
	public static BuildingConfig GetOrCreateInstance()
	{
		if (BuildingConfig._Instance == null)
		{
			BuildingConfig.CreateInstance();
		}
		return BuildingConfig._Instance;
	}

	// Token: 0x060085D9 RID: 34265 RVA: 0x001C8482 File Offset: 0x001C6682
	public static bool CreateInstance()
	{
		if (BuildingConfig._Instance != null)
		{
			return true;
		}
		BuildingConfig._Instance = new BuildingConfig();
		return true;
	}

	// Token: 0x060085DA RID: 34266 RVA: 0x001C8498 File Offset: 0x001C6698
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060085DB RID: 34267 RVA: 0x001C849A File Offset: 0x001C669A
	public static void ResetStaticDefaultValue()
	{
		BuildingConfig._Instance = null;
	}

	// Token: 0x060085DC RID: 34268 RVA: 0x001C84A2 File Offset: 0x001C66A2
	static BuildingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuildingConfig.CreateStaticDefaultValue), new Action(BuildingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003C05 RID: 15365
	[Nullable(2)]
	private static BuildingConfig _Instance;
}
