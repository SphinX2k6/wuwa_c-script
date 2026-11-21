using System;

// Token: 0x020017C5 RID: 6085
public class WorldTeamRoleInfo
{
	// Token: 0x0600EDEF RID: 60911 RVA: 0x0045C349 File Offset: 0x0045A549
	public WorldTeamRoleInfo(int roleId, int roleSkinId, int roleLevel)
	{
		this.RoleIdInternal = roleId;
		this.RoleSkinIdInternal = roleSkinId;
		this.RoleLevelInternal = roleLevel;
	}

	// Token: 0x170016CB RID: 5835
	// (get) Token: 0x0600EDF0 RID: 60912 RVA: 0x0045C366 File Offset: 0x0045A566
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x170016CC RID: 5836
	// (get) Token: 0x0600EDF1 RID: 60913 RVA: 0x0045C36E File Offset: 0x0045A56E
	public int RoleSkinId
	{
		get
		{
			return this.RoleSkinIdInternal;
		}
	}

	// Token: 0x170016CD RID: 5837
	// (get) Token: 0x0600EDF2 RID: 60914 RVA: 0x0045C376 File Offset: 0x0045A576
	public int RoleLevel
	{
		get
		{
			return this.RoleLevelInternal;
		}
	}

	// Token: 0x040086B2 RID: 34482
	private readonly int RoleIdInternal;

	// Token: 0x040086B3 RID: 34483
	private readonly int RoleSkinIdInternal;

	// Token: 0x040086B4 RID: 34484
	private readonly int RoleLevelInternal;
}
