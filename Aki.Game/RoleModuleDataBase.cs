using System;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D2E RID: 7470
public class RoleModuleDataBase
{
	// Token: 0x06012869 RID: 75881 RVA: 0x00579838 File Offset: 0x00577A38
	public RoleModuleDataBase(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0601286A RID: 75882 RVA: 0x00579848 File Offset: 0x00577A48
	protected RoleInfo GetRoleConfig()
	{
		return RoleConfig.Instance.GetRoleConfig(this.RoleId).Value;
	}

	// Token: 0x0400A0E8 RID: 41192
	protected int RoleId;
}
