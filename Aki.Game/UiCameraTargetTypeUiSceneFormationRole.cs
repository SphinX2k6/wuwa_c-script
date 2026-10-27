using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002C3F RID: 11327
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiSceneFormationRole : UiCameraTargetTypeBase
{
	// Token: 0x06017A06 RID: 96774 RVA: 0x00603248 File Offset: 0x00601448
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		return UiSceneManager.Instance.GetCurrentSelectFormationRoleActor();
	}

	// Token: 0x06017A07 RID: 96775 RVA: 0x00603254 File Offset: 0x00601454
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		TsUiSceneRoleActor currentSelectFormationRoleActor = UiSceneManager.Instance.GetCurrentSelectFormationRoleActor();
		if (currentSelectFormationRoleActor == null)
		{
			return null;
		}
		UiModelBase model = currentSelectFormationRoleActor.Model;
		UiRoleDataComponent uiRoleDataComponent = (model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null;
		if (uiRoleDataComponent == null)
		{
			return null;
		}
		int roleConfigId = uiRoleDataComponent.RoleConfigId;
		int roleSkinId = uiRoleDataComponent.RoleSkinId;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
		if (roleConfig == null)
		{
			return null;
		}
		if (roleSkinId <= 0)
		{
			return roleConfig.Value.RoleBody;
		}
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(roleSkinId);
		if (roleSkinData == null)
		{
			return null;
		}
		return roleSkinData.GetRoleBody();
	}

	// Token: 0x06017A08 RID: 96776 RVA: 0x006032DC File Offset: 0x006014DC
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		TsUiSceneRoleActor currentSelectFormationRoleActor = UiSceneManager.Instance.GetCurrentSelectFormationRoleActor();
		if (currentSelectFormationRoleActor == null)
		{
			return null;
		}
		UiModelBase model = currentSelectFormationRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent == null)
		{
			return null;
		}
		return uiModelActorComponent.MainMeshComponent;
	}
}
