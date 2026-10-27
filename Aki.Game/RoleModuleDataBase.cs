using System;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020027B3 RID: 10163
public class RoleModuleDataBase
{
	// Token: 0x06014E6A RID: 85610 RVA: 0x0054EB10 File Offset: 0x0054CD10
	public RoleModuleDataBase(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06014E6B RID: 85611 RVA: 0x0054EB20 File Offset: 0x0054CD20
	protected RoleInfo GetRoleConfig()
	{
		return RoleConfig.Instance.GetRoleConfig(this.RoleId).Value;
	}

	// Token: 0x04009D05 RID: 40197
	protected int RoleId;
}
