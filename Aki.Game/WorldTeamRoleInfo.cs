using System;

// Token: 0x020022E1 RID: 8929
public class WorldTeamRoleInfo
{
	// Token: 0x06011957 RID: 72023 RVA: 0x0044F67D File Offset: 0x0044D87D
	public WorldTeamRoleInfo(int roleId, int roleSkinId, int roleLevel)
	{
		this.RoleIdInternal = roleId;
		this.RoleSkinIdInternal = roleSkinId;
		this.RoleLevelInternal = roleLevel;
	}

	// Token: 0x17001694 RID: 5780
	// (get) Token: 0x06011958 RID: 72024 RVA: 0x0044F69A File Offset: 0x0044D89A
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001695 RID: 5781
	// (get) Token: 0x06011959 RID: 72025 RVA: 0x0044F6A2 File Offset: 0x0044D8A2
	public int RoleSkinId
	{
		get
		{
			return this.RoleSkinIdInternal;
		}
	}

	// Token: 0x17001696 RID: 5782
	// (get) Token: 0x0601195A RID: 72026 RVA: 0x0044F6AA File Offset: 0x0044D8AA
	public int RoleLevel
	{
		get
		{
			return this.RoleLevelInternal;
		}
	}

	// Token: 0x04008574 RID: 34164
	private readonly int RoleIdInternal;

	// Token: 0x04008575 RID: 34165
	private readonly int RoleSkinIdInternal;

	// Token: 0x04008576 RID: 34166
	private readonly int RoleLevelInternal;
}
