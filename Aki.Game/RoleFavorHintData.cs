using System;
using Aki.Config;

// Token: 0x02001DD5 RID: 7637
public class RoleFavorHintData
{
	// Token: 0x06012E89 RID: 77449 RVA: 0x0058AD5D File Offset: 0x00588F5D
	public RoleFavorHintData(RoleInfo roleConfig, int exp)
	{
		this.RoleConfig = new RoleInfo?(roleConfig);
		this.Exp = exp;
	}

	// Token: 0x0400A2E9 RID: 41705
	public RoleInfo? RoleConfig;

	// Token: 0x0400A2EA RID: 41706
	public int Exp;
}
