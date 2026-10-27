using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x020027D1 RID: 10193
[NullableContext(2)]
[Nullable(0)]
public class ForecastRoleDisplayModel : RoleDisplayModelBase
{
	// Token: 0x06014F1D RID: 85789 RVA: 0x00550CA8 File Offset: 0x0054EEA8
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

	// Token: 0x17001B41 RID: 6977
	// (get) Token: 0x06014F1E RID: 85790 RVA: 0x00550D23 File Offset: 0x0054EF23
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001B42 RID: 6978
	// (get) Token: 0x06014F1F RID: 85791 RVA: 0x00550D2B File Offset: 0x0054EF2B
	public override ERoleDisplaySourceType SourceType
	{
		get
		{
			return ERoleDisplaySourceType.ForecastConfig;
		}
	}

	// Token: 0x17001B43 RID: 6979
	// (get) Token: 0x06014F20 RID: 85792 RVA: 0x00550D2E File Offset: 0x0054EF2E
	public override RoleDataBase OriginRoleData
	{
		get
		{
			return null;
		}
	}

	// Token: 0x04009D89 RID: 40329
	private int RoleIdInternal;
}
