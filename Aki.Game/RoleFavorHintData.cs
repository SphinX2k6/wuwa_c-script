using System;
using Aki.Config;

// Token: 0x0200285A RID: 10330
public class RoleFavorHintData
{
	// Token: 0x0601548B RID: 87179 RVA: 0x00560001 File Offset: 0x0055E201
	public RoleFavorHintData(RoleInfo roleConfig, int exp)
	{
		this.RoleConfig = new RoleInfo?(roleConfig);
		this.Exp = exp;
	}

	// Token: 0x04009F00 RID: 40704
	public RoleInfo? RoleConfig;

	// Token: 0x04009F01 RID: 40705
	public int Exp;
}
