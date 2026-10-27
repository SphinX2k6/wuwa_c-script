using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002C42 RID: 11330
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiSceneRole : UiCameraTargetTypeBase
{
	// Token: 0x06017A12 RID: 96786 RVA: 0x006033D3 File Offset: 0x006015D3
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		return UiSceneManager.Instance.GetRoleSystemRoleActor();
	}

	// Token: 0x06017A13 RID: 96787 RVA: 0x006033E0 File Offset: 0x006015E0
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		if (roleSystemRoleActor == null)
		{
			return null;
		}
		UiModelBase model = roleSystemRoleActor.Model;
		UiRoleMorphComponent uiRoleMorphComponent = (model != null) ? model.GetComponent<UiRoleMorphComponent>() : null;
		IUiMorphData uiMorphData = (uiRoleMorphComponent != null) ? uiRoleMorphComponent.GetCurrentMorphData() : null;
		if (uiMorphData != null)
		{
			return uiMorphData.RoleBody;
		}
		UiModelBase model2 = roleSystemRoleActor.Model;
		UiRoleDataComponent uiRoleDataComponent = (model2 != null) ? model2.CheckGetComponent<UiRoleDataComponent>() : null;
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
		return RoleSkinModel.Instance.GetRoleSkinData(roleSkinId).GetRoleBody();
	}

	// Token: 0x06017A14 RID: 96788 RVA: 0x00603484 File Offset: 0x00601684
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		if (roleSystemRoleActor == null)
		{
			return null;
		}
		UiModelBase model = roleSystemRoleActor.Model;
		if (model == null)
		{
			return null;
		}
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent == null)
		{
			return null;
		}
		return uiModelActorComponent.MainMeshComponent;
	}
}
