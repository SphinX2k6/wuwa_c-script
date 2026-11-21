using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A5 RID: 14757
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiSceneFormationRole : UiCameraTargetType
	{
		// Token: 0x06026016 RID: 155670 RVA: 0x00AAAB00 File Offset: 0x00AA8D00
		public UiCameraTargetTypeUiSceneFormationRole() : base(EUiCameraAnimationTargetType.UiSceneFormationRole)
		{
		}

		// Token: 0x06026017 RID: 155671 RVA: 0x00AAAB0A File Offset: 0x00AA8D0A
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			return UiSceneManager.Instance.GetCurrentSelectFormationRoleActor();
		}

		// Token: 0x06026018 RID: 155672 RVA: 0x00AAAB16 File Offset: 0x00AA8D16
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			TsUiSceneRoleActor currentSelectFormationRoleActor = UiSceneManager.Instance.GetCurrentSelectFormationRoleActor();
			if (currentSelectFormationRoleActor == null)
			{
				return null;
			}
			UiModelBase model = currentSelectFormationRoleActor.Model;
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

		// Token: 0x06026019 RID: 155673 RVA: 0x00AAAB44 File Offset: 0x00AA8D44
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			TsUiSceneRoleActor currentSelectFormationRoleActor = UiSceneManager.Instance.GetCurrentSelectFormationRoleActor();
			UiRoleDataComponent uiRoleDataComponent;
			if (currentSelectFormationRoleActor == null)
			{
				uiRoleDataComponent = null;
			}
			else
			{
				UiModelBase model = currentSelectFormationRoleActor.Model;
				uiRoleDataComponent = ((model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null);
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
