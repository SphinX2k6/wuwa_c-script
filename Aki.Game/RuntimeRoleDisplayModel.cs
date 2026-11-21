using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D4F RID: 7503
[NullableContext(2)]
[Nullable(0)]
public class RuntimeRoleDisplayModel : RoleDisplayModelBase
{
	// Token: 0x06012942 RID: 76098 RVA: 0x0057BC18 File Offset: 0x00579E18
	[NullableContext(1)]
	public void InitByRoleData(RoleDataBase data)
	{
		int dataId = data.GetDataId();
		bool isInTeam = SceneTeamModel.Instance.GetTeamItem((long)dataId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId
		}) != null;
		ERoleTypeTag roleTypeTagByRoleId = RoleDevUtils.GetRoleTypeTagByRoleId(dataId);
		RoleInfo roleConfig = data.GetRoleConfig();
		base.InitBase(new RoleDisplayModelBaseInitParams
		{
			Id = dataId,
			Name = ConfigMultiTextLang.GetLocalTextNew(roleConfig.Name, null),
			SkinId = data.GetRoleSkinId(),
			ElementId = roleConfig.ElementId,
			Level = data.GetLevelData().GetLevel(),
			IsInTeam = isInTeam,
			IsTrial = false,
			IsNew = data.GetIsNew(),
			TypeTag = roleTypeTagByRoleId
		});
		this.RoleDataInternal = data;
	}

	// Token: 0x06012943 RID: 76099 RVA: 0x0057BCD0 File Offset: 0x00579ED0
	public void InitByRoleId(int roleId)
	{
		bool isInTeam = SceneTeamModel.Instance.GetTeamItem((long)roleId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId
		}) != null;
		ERoleTypeTag roleTypeTagByRoleId = RoleDevUtils.GetRoleTypeTagByRoleId(roleId);
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleId).Value;
		base.InitBase(new RoleDisplayModelBaseInitParams
		{
			Id = roleId,
			Name = ConfigMultiTextLang.GetLocalTextNew(value.Name, null),
			SkinId = value.SkinId,
			ElementId = value.ElementId,
			Level = 0,
			IsInTeam = isInTeam,
			IsTrial = false,
			IsNew = false,
			TypeTag = roleTypeTagByRoleId
		});
	}

	// Token: 0x17001BB0 RID: 7088
	// (get) Token: 0x06012944 RID: 76100 RVA: 0x0057BD76 File Offset: 0x00579F76
	public override ERoleDisplaySourceType SourceType
	{
		get
		{
			return ERoleDisplaySourceType.RuntimeData;
		}
	}

	// Token: 0x17001BB1 RID: 7089
	// (get) Token: 0x06012945 RID: 76101 RVA: 0x0057BD79 File Offset: 0x00579F79
	public override RoleDataBase OriginRoleData
	{
		get
		{
			return this.RoleDataInternal;
		}
	}

	// Token: 0x0400A185 RID: 41349
	private RoleDataBase RoleDataInternal;
}
