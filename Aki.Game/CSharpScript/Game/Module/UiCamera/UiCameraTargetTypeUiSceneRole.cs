using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A7 RID: 14759
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiSceneRole : UiCameraTargetType
	{
		// Token: 0x0602601F RID: 155679 RVA: 0x00AAAC1B File Offset: 0x00AA8E1B
		public UiCameraTargetTypeUiSceneRole() : base(EUiCameraAnimationTargetType.UiSceneRole)
		{
		}

		// Token: 0x06026020 RID: 155680 RVA: 0x00AAAC24 File Offset: 0x00AA8E24
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			return UiSceneManager.Instance.GetRoleSystemRoleActor();
		}

		// Token: 0x06026021 RID: 155681 RVA: 0x00AAAC30 File Offset: 0x00AA8E30
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
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

		// Token: 0x06026022 RID: 155682 RVA: 0x00AAAC60 File Offset: 0x00AA8E60
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			IUiMorphData uiMorphData;
			if (roleSystemRoleActor == null)
			{
				uiMorphData = null;
			}
			else
			{
				UiModelBase model = roleSystemRoleActor.Model;
				if (model == null)
				{
					uiMorphData = null;
				}
				else
				{
					UiRoleMorphComponent component = model.GetComponent<UiRoleMorphComponent>();
					uiMorphData = ((component != null) ? component.GetCurrentMorphData() : null);
				}
			}
			IUiMorphData uiMorphData2 = uiMorphData;
			if (uiMorphData2 != null)
			{
				return uiMorphData2.RoleBody;
			}
			UiRoleDataComponent uiRoleDataComponent;
			if (roleSystemRoleActor == null)
			{
				uiRoleDataComponent = null;
			}
			else
			{
				UiModelBase model2 = roleSystemRoleActor.Model;
				uiRoleDataComponent = ((model2 != null) ? model2.CheckGetComponent<UiRoleDataComponent>() : null);
			}
			UiRoleDataComponent uiRoleDataComponent2 = uiRoleDataComponent;
			if (uiRoleDataComponent2 == null)
			{
				return null;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(uiRoleDataComponent2.RoleConfigId);
			if (roleConfig == null)
			{
				return null;
			}
			if (uiRoleDataComponent2.RoleSkinId <= 0)
			{
				return roleConfig.Value.RoleBody;
			}
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(uiRoleDataComponent2.RoleSkinId);
			if (roleSkinData == null)
			{
				return null;
			}
			return roleSkinData.GetRoleBody();
		}
	}
}
