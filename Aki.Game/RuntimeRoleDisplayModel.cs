using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020027D4 RID: 10196
[NullableContext(2)]
[Nullable(0)]
public class RuntimeRoleDisplayModel : RoleDisplayModelBase
{
	// Token: 0x06014F42 RID: 85826 RVA: 0x00550EA8 File Offset: 0x0054F0A8
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

	// Token: 0x06014F43 RID: 85827 RVA: 0x00550F60 File Offset: 0x0054F160
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

	// Token: 0x17001B58 RID: 7000
	// (get) Token: 0x06014F44 RID: 85828 RVA: 0x00551006 File Offset: 0x0054F206
	public override ERoleDisplaySourceType SourceType
	{
		get
		{
			return ERoleDisplaySourceType.RuntimeData;
		}
	}

	// Token: 0x17001B59 RID: 7001
	// (get) Token: 0x06014F45 RID: 85829 RVA: 0x00551009 File Offset: 0x0054F209
	public override RoleDataBase OriginRoleData
	{
		get
		{
			return this.RoleDataInternal;
		}
	}

	// Token: 0x04009D9C RID: 40348
	private RoleDataBase RoleDataInternal;
}
