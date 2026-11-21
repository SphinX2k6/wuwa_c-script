using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02001D4C RID: 7500
[NullableContext(2)]
[Nullable(0)]
public class ForecastRoleDisplayModel : RoleDisplayModelBase
{
	// Token: 0x0601291D RID: 76061 RVA: 0x0057BA18 File Offset: 0x00579C18
	public void InitByRoleId(int roleId)
	{
		this.RoleIdInternal = roleId;
		ERoleTypeTag roleTypeTagByRoleId = RoleDevUtils.GetRoleTypeTagByRoleId(roleId);
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
		base.InitBase(new RoleDisplayModelBaseInitParams
		{
			Id = roleId,
			Name = roleDevProsProjectConfig.RoleName,
			SkinId = 0,
			ElementId = roleDevProsProjectConfig.ElementId,
			Level = 1,
			IsInTeam = false,
			IsTrial = false,
			IsNew = false,
			TypeTag = roleTypeTagByRoleId
		});
	}

	// Token: 0x17001B99 RID: 7065
	// (get) Token: 0x0601291E RID: 76062 RVA: 0x0057BA93 File Offset: 0x00579C93
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001B9A RID: 7066
	// (get) Token: 0x0601291F RID: 76063 RVA: 0x0057BA9B File Offset: 0x00579C9B
	public override ERoleDisplaySourceType SourceType
	{
		get
		{
			return ERoleDisplaySourceType.ForecastConfig;
		}
	}

	// Token: 0x17001B9B RID: 7067
	// (get) Token: 0x06012920 RID: 76064 RVA: 0x0057BA9E File Offset: 0x00579C9E
	public override RoleDataBase OriginRoleData
	{
		get
		{
			return null;
		}
	}

	// Token: 0x0400A172 RID: 41330
	private int RoleIdInternal;
}
