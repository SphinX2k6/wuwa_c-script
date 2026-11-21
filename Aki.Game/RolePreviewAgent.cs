using System;

// Token: 0x02001E68 RID: 7784
public class RolePreviewAgent : RoleViewAgent
{
	// Token: 0x0601341D RID: 78877 RVA: 0x005A08C6 File Offset: 0x0059EAC6
	public override ERoleSystemMode GetRoleSystemMode()
	{
		return ERoleSystemMode.Preview;
	}
}
