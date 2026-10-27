using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020029FB RID: 10747
[NullableContext(1)]
[Nullable(0)]
public class MoonTogetherConfig : ConfigBase
{
	// Token: 0x060164B2 RID: 91314 RVA: 0x005A4566 File Offset: 0x005A2766
	[NullableContext(2)]
	public IReadOnlyList<MotorRoleCategory> GetRoleAreaList()
	{
		return ConfigMotorRoleCategoryAll.GetConfigList(true);
	}

	// Token: 0x060164B3 RID: 91315 RVA: 0x005A456E File Offset: 0x005A276E
	public MotorRoleCategory? GetRoleAreaById(int areaId)
	{
		return ConfigMotorRoleCategoryById.GetConfig(areaId, true);
	}

	// Token: 0x060164B4 RID: 91316 RVA: 0x005A4577 File Offset: 0x005A2777
	public VehicleRidingRoles? GetVehicleRidingRolesById(int roleId)
	{
		return ConfigVehicleRidingRolesById.GetConfig(roleId, true);
	}

	// Token: 0x17001DC4 RID: 7620
	// (get) Token: 0x060164B5 RID: 91317 RVA: 0x005A4580 File Offset: 0x005A2780
	public static MoonTogetherConfig Instance
	{
		get
		{
			return MoonTogetherConfig._Instance;
		}
	}

	// Token: 0x060164B6 RID: 91318 RVA: 0x005A4587 File Offset: 0x005A2787
	public static MoonTogetherConfig GetOrCreateInstance()
	{
		if (MoonTogetherConfig._Instance == null)
		{
			MoonTogetherConfig.CreateInstance();
		}
		return MoonTogetherConfig._Instance;
	}

	// Token: 0x060164B7 RID: 91319 RVA: 0x005A459B File Offset: 0x005A279B
	public static bool CreateInstance()
	{
		if (MoonTogetherConfig._Instance != null)
		{
			return true;
		}
		MoonTogetherConfig._Instance = new MoonTogetherConfig();
		return true;
	}

	// Token: 0x060164B8 RID: 91320 RVA: 0x005A45B1 File Offset: 0x005A27B1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060164B9 RID: 91321 RVA: 0x005A45B3 File Offset: 0x005A27B3
	public static void ResetStaticDefaultValue()
	{
		MoonTogetherConfig._Instance = null;
	}

	// Token: 0x060164BA RID: 91322 RVA: 0x005A45BB File Offset: 0x005A27BB
	static MoonTogetherConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonTogetherConfig.CreateStaticDefaultValue), new Action(MoonTogetherConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A5DE RID: 42462
	[Nullable(2)]
	private static MoonTogetherConfig _Instance;
}
