using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F76 RID: 8054
[NullableContext(1)]
[Nullable(0)]
public class MoonTogetherConfig : ConfigBase
{
	// Token: 0x06013EB9 RID: 81593 RVA: 0x005CF53E File Offset: 0x005CD73E
	[NullableContext(2)]
	public IReadOnlyList<MotorRoleCategory> GetRoleAreaList()
	{
		return ConfigMotorRoleCategoryAll.GetConfigList(true);
	}

	// Token: 0x06013EBA RID: 81594 RVA: 0x005CF546 File Offset: 0x005CD746
	public MotorRoleCategory? GetRoleAreaById(int areaId)
	{
		return ConfigMotorRoleCategoryById.GetConfig(areaId, true);
	}

	// Token: 0x06013EBB RID: 81595 RVA: 0x005CF54F File Offset: 0x005CD74F
	public VehicleRidingRoles? GetVehicleRidingRolesById(int roleId)
	{
		return ConfigVehicleRidingRolesById.GetConfig(roleId, true);
	}

	// Token: 0x17001E1D RID: 7709
	// (get) Token: 0x06013EBC RID: 81596 RVA: 0x005CF558 File Offset: 0x005CD758
	public static MoonTogetherConfig Instance
	{
		get
		{
			return MoonTogetherConfig._Instance;
		}
	}

	// Token: 0x06013EBD RID: 81597 RVA: 0x005CF55F File Offset: 0x005CD75F
	public static MoonTogetherConfig GetOrCreateInstance()
	{
		if (MoonTogetherConfig._Instance == null)
		{
			MoonTogetherConfig.CreateInstance();
		}
		return MoonTogetherConfig._Instance;
	}

	// Token: 0x06013EBE RID: 81598 RVA: 0x005CF573 File Offset: 0x005CD773
	public static bool CreateInstance()
	{
		if (MoonTogetherConfig._Instance != null)
		{
			return true;
		}
		MoonTogetherConfig._Instance = new MoonTogetherConfig();
		return true;
	}

	// Token: 0x06013EBF RID: 81599 RVA: 0x005CF589 File Offset: 0x005CD789
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013EC0 RID: 81600 RVA: 0x005CF58B File Offset: 0x005CD78B
	public static void ResetStaticDefaultValue()
	{
		MoonTogetherConfig._Instance = null;
	}

	// Token: 0x06013EC1 RID: 81601 RVA: 0x005CF593 File Offset: 0x005CD793
	static MoonTogetherConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonTogetherConfig.CreateStaticDefaultValue), new Action(MoonTogetherConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A9C8 RID: 43464
	[Nullable(2)]
	private static MoonTogetherConfig _Instance;
}
