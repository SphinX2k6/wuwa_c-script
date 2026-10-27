using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using Google.Protobuf.Collections;

// Token: 0x02002810 RID: 10256
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleDevModel : ModelBase
{
	// Token: 0x17001BD0 RID: 7120
	// (get) Token: 0x060150E3 RID: 86243 RVA: 0x00554D07 File Offset: 0x00552F07
	// (set) Token: 0x060150E4 RID: 86244 RVA: 0x00554D0F File Offset: 0x00552F0F
	public string Version
	{
		get
		{
			return this.VersionInternal;
		}
		set
		{
			this.VersionInternal = value;
		}
	}

	// Token: 0x060150E5 RID: 86245 RVA: 0x00554D18 File Offset: 0x00552F18
	public RoleDevModel()
	{
		this.HotRoleDataListInternal = new List<RoleDisplayModelBase>();
	}

	// Token: 0x060150E6 RID: 86246 RVA: 0x00554D38 File Offset: 0x00552F38
	public void UpdateRoleDevConfig(RoleDevelopConfigs configs)
	{
		RepeatedField<RoleDevPropsConfig> devPropsList = configs.DevPropsList;
		if (devPropsList != null && devPropsList.Count > 0)
		{
			RoleDevConfig.Instance.UpdateDevProsListConfig(devPropsList);
		}
		if (configs.DevTargetRole > 0)
		{
			this.DevTargetRoleIdInternal = configs.DevTargetRole;
		}
		RepeatedField<RoleDevPropsProjectConfig> devPropsProjectList = configs.DevPropsProjectList;
		if (devPropsProjectList != null && devPropsProjectList.Count > 0)
		{
			RoleDevConfig.Instance.UpdateDevPropsProjectConfig(devPropsProjectList);
		}
		if (!string.IsNullOrEmpty(configs.Version))
		{
			this.Version = configs.Version;
		}
	}

	// Token: 0x060150E7 RID: 86247 RVA: 0x00554DAF File Offset: 0x00552FAF
	public void UpdateDevTargetRoleId(int roleId)
	{
		this.DevTargetRoleIdInternal = roleId;
	}

	// Token: 0x17001BD1 RID: 7121
	// (get) Token: 0x060150E8 RID: 86248 RVA: 0x00554DB8 File Offset: 0x00552FB8
	public int DevTargetRoleId
	{
		get
		{
			return this.DevTargetRoleIdInternal;
		}
	}

	// Token: 0x060150E9 RID: 86249 RVA: 0x00554DC0 File Offset: 0x00552FC0
	[NullableContext(2)]
	public IRoleDevProsConfig GetRoleDevPropsConfig(int configId)
	{
		foreach (IRoleDevProsConfig roleDevProsConfig in (RoleDevConfig.Instance.GetAllRoleDevProsListConfig() ?? Array.Empty<IRoleDevProsConfig>()))
		{
			if (roleDevProsConfig.Id == configId)
			{
				return roleDevProsConfig;
			}
		}
		return null;
	}

	// Token: 0x17001BD2 RID: 7122
	// (get) Token: 0x060150EA RID: 86250 RVA: 0x00554E24 File Offset: 0x00553024
	public bool IsConfigDataInitialized
	{
		get
		{
			return (RoleDevConfig.Instance.GetAllRoleDevProsListConfig() ?? Array.Empty<IRoleDevProsConfig>()).Count > 0;
		}
	}

	// Token: 0x17001BD3 RID: 7123
	// (get) Token: 0x060150EB RID: 86251 RVA: 0x00554E41 File Offset: 0x00553041
	public List<RoleDisplayModelBase> HotRoleDataList
	{
		get
		{
			return this.HotRoleDataListInternal;
		}
	}

	// Token: 0x17001BD4 RID: 7124
	// (get) Token: 0x060150EC RID: 86252 RVA: 0x00554E49 File Offset: 0x00553049
	public static RoleDevModel Instance
	{
		get
		{
			return RoleDevModel._Instance;
		}
	}

	// Token: 0x060150ED RID: 86253 RVA: 0x00554E50 File Offset: 0x00553050
	public static RoleDevModel GetOrCreateInstance()
	{
		if (RoleDevModel._Instance == null)
		{
			RoleDevModel.CreateInstance();
		}
		return RoleDevModel._Instance;
	}

	// Token: 0x060150EE RID: 86254 RVA: 0x00554E64 File Offset: 0x00553064
	public static bool CreateInstance()
	{
		if (RoleDevModel._Instance != null)
		{
			return true;
		}
		RoleDevModel._Instance = new RoleDevModel();
		return true;
	}

	// Token: 0x060150EF RID: 86255 RVA: 0x00554E7A File Offset: 0x0055307A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060150F0 RID: 86256 RVA: 0x00554E7C File Offset: 0x0055307C
	public static void ResetStaticDefaultValue()
	{
		RoleDevModel._Instance = null;
	}

	// Token: 0x060150F1 RID: 86257 RVA: 0x00554E84 File Offset: 0x00553084
	static RoleDevModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDevModel.CreateStaticDefaultValue), new Action(RoleDevModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009E2F RID: 40495
	private readonly List<RoleDisplayModelBase> HotRoleDataListInternal;

	// Token: 0x04009E30 RID: 40496
	private int DevTargetRoleIdInternal;

	// Token: 0x04009E31 RID: 40497
	private string VersionInternal = string.Empty;

	// Token: 0x04009E32 RID: 40498
	[Nullable(2)]
	private static RoleDevModel _Instance;
}
