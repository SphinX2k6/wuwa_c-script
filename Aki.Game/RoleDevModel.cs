using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using Google.Protobuf.Collections;

// Token: 0x02001D8B RID: 7563
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleDevModel : ModelBase
{
	// Token: 0x17001C28 RID: 7208
	// (get) Token: 0x06012AE3 RID: 76515 RVA: 0x0057FB07 File Offset: 0x0057DD07
	// (set) Token: 0x06012AE4 RID: 76516 RVA: 0x0057FB0F File Offset: 0x0057DD0F
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

	// Token: 0x06012AE5 RID: 76517 RVA: 0x0057FB18 File Offset: 0x0057DD18
	public RoleDevModel()
	{
		this.HotRoleDataListInternal = new List<RoleDisplayModelBase>();
	}

	// Token: 0x06012AE6 RID: 76518 RVA: 0x0057FB38 File Offset: 0x0057DD38
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

	// Token: 0x06012AE7 RID: 76519 RVA: 0x0057FBAF File Offset: 0x0057DDAF
	public void UpdateDevTargetRoleId(int roleId)
	{
		this.DevTargetRoleIdInternal = roleId;
	}

	// Token: 0x17001C29 RID: 7209
	// (get) Token: 0x06012AE8 RID: 76520 RVA: 0x0057FBB8 File Offset: 0x0057DDB8
	public int DevTargetRoleId
	{
		get
		{
			return this.DevTargetRoleIdInternal;
		}
	}

	// Token: 0x06012AE9 RID: 76521 RVA: 0x0057FBC0 File Offset: 0x0057DDC0
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

	// Token: 0x17001C2A RID: 7210
	// (get) Token: 0x06012AEA RID: 76522 RVA: 0x0057FC24 File Offset: 0x0057DE24
	public bool IsConfigDataInitialized
	{
		get
		{
			return (RoleDevConfig.Instance.GetAllRoleDevProsListConfig() ?? Array.Empty<IRoleDevProsConfig>()).Count > 0;
		}
	}

	// Token: 0x17001C2B RID: 7211
	// (get) Token: 0x06012AEB RID: 76523 RVA: 0x0057FC41 File Offset: 0x0057DE41
	public List<RoleDisplayModelBase> HotRoleDataList
	{
		get
		{
			return this.HotRoleDataListInternal;
		}
	}

	// Token: 0x17001C2C RID: 7212
	// (get) Token: 0x06012AEC RID: 76524 RVA: 0x0057FC49 File Offset: 0x0057DE49
	public static RoleDevModel Instance
	{
		get
		{
			return RoleDevModel._Instance;
		}
	}

	// Token: 0x06012AED RID: 76525 RVA: 0x0057FC50 File Offset: 0x0057DE50
	public static RoleDevModel GetOrCreateInstance()
	{
		if (RoleDevModel._Instance == null)
		{
			RoleDevModel.CreateInstance();
		}
		return RoleDevModel._Instance;
	}

	// Token: 0x06012AEE RID: 76526 RVA: 0x0057FC64 File Offset: 0x0057DE64
	public static bool CreateInstance()
	{
		if (RoleDevModel._Instance != null)
		{
			return true;
		}
		RoleDevModel._Instance = new RoleDevModel();
		return true;
	}

	// Token: 0x06012AEF RID: 76527 RVA: 0x0057FC7A File Offset: 0x0057DE7A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012AF0 RID: 76528 RVA: 0x0057FC7C File Offset: 0x0057DE7C
	public static void ResetStaticDefaultValue()
	{
		RoleDevModel._Instance = null;
	}

	// Token: 0x06012AF1 RID: 76529 RVA: 0x0057FC84 File Offset: 0x0057DE84
	static RoleDevModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDevModel.CreateStaticDefaultValue), new Action(RoleDevModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A218 RID: 41496
	private readonly List<RoleDisplayModelBase> HotRoleDataListInternal;

	// Token: 0x0400A219 RID: 41497
	private int DevTargetRoleIdInternal;

	// Token: 0x0400A21A RID: 41498
	private string VersionInternal = string.Empty;

	// Token: 0x0400A21B RID: 41499
	[Nullable(2)]
	private static RoleDevModel _Instance;
}
