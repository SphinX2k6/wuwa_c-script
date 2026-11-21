using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02002202 RID: 8706
[NullableContext(2)]
[Nullable(0)]
public class UiFormationRoleLoadComponent : UiModelLoadComponent
{
	// Token: 0x060156B7 RID: 87735 RVA: 0x00638862 File Offset: 0x00636A62
	protected override void OnInit()
	{
		base.OnInit();
		this.UiRoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.UiFormationRoleDataComponent = base.Owner.CheckGetComponent<UiFormationRoleDataComponent>();
	}

	// Token: 0x060156B8 RID: 87736 RVA: 0x0063888C File Offset: 0x00636A8C
	protected override void OnEnd()
	{
		base.OnEnd();
	}

	// Token: 0x060156B9 RID: 87737 RVA: 0x00638894 File Offset: 0x00636A94
	public void LoadModelByRoleDataId(int roleDataId, int roleSkinId, bool waitMeshStreaming = false, Action loadFinishCallBack = null)
	{
		if (roleDataId == this.UiRoleDataComponent.RoleDataId)
		{
			UiRoleDataComponent uiRoleDataComponent = this.UiRoleDataComponent;
			int? num = (uiRoleDataComponent != null) ? new int?(uiRoleDataComponent.RoleSkinId) : null;
			if (roleSkinId == num.GetValueOrDefault() & num != null)
			{
				this.SetTeamRolePosition();
				if (loadFinishCallBack != null)
				{
					loadFinishCallBack();
				}
				return;
			}
		}
		RoleModel instance = RoleModel.Instance;
		if (((instance != null) ? instance.GetRoleDataById(roleDataId, true) : null) == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "LoadModelByRoleDataId 本机 RoleModel 查不到该角色,队友角色应走 LoadModelByRoleConfigId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleDataId", roleDataId);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (loadFinishCallBack != null)
			{
				loadFinishCallBack();
			}
			return;
		}
		this.UiRoleDataComponent.SetRoleDataId(roleDataId, roleSkinId);
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 0);
	}

	// Token: 0x060156BA RID: 87738 RVA: 0x00638960 File Offset: 0x00636B60
	public void LoadModelByRoleConfigId(int roleConfigId, int skinId, bool waitMeshStreaming = false, Action loadFinishCallBack = null)
	{
		int num = (skinId > 0 && RoleSkinModel.Instance.GetRoleSkinData(skinId) == null) ? 0 : skinId;
		if (roleConfigId == this.UiRoleDataComponent.RoleConfigId)
		{
			int num2 = num;
			UiRoleDataComponent uiRoleDataComponent = this.UiRoleDataComponent;
			int? num3 = (uiRoleDataComponent != null) ? new int?(uiRoleDataComponent.RoleSkinId) : null;
			if (num2 == num3.GetValueOrDefault() & num3 != null)
			{
				this.SetTeamRolePosition();
				if (loadFinishCallBack != null)
				{
					loadFinishCallBack();
				}
				return;
			}
		}
		this.UiRoleDataComponent.SetRoleConfigId(roleConfigId, num);
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 0);
	}

	// Token: 0x060156BB RID: 87739 RVA: 0x006389F8 File Offset: 0x00636BF8
	[NullableContext(1)]
	protected override string GetAnimClassPath()
	{
		return SkinConfig.Instance.GetRoleSkinConfig(this.UiRoleDataComponent.RoleSkinId).Value.UiTeamABP;
	}

	// Token: 0x060156BC RID: 87740 RVA: 0x00638A2A File Offset: 0x00636C2A
	protected override void FinishLoad()
	{
		this.SetTeamRolePosition();
		base.FinishLoad();
	}

	// Token: 0x060156BD RID: 87741 RVA: 0x00638A38 File Offset: 0x00636C38
	private void SetTeamRolePosition()
	{
		UiModelActorComponent uiModelActorComponent = this.UiModelActorComponent;
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			return;
		}
		ABP_TeamRole_Base_C teamRoleAnimInstance = this.GetTeamRoleAnimInstance(uskeletalMeshComponent);
		if (teamRoleAnimInstance == null)
		{
			return;
		}
		teamRoleAnimInstance.SetPosition(this.UiFormationRoleDataComponent.Position);
	}

	// Token: 0x060156BE RID: 87742 RVA: 0x00638A7C File Offset: 0x00636C7C
	[NullableContext(1)]
	[return: Nullable(2)]
	private ABP_TeamRole_Base_C GetTeamRoleAnimInstance(USkeletalMeshComponent meshComponent)
	{
		UAnimInstance linkedAnimGraphInstanceByTag = meshComponent.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE);
		if (UKuroStaticLibrary.IsObjectClassByName(linkedAnimGraphInstanceByTag, CharacterNameDefines.Instance.ABP_TEAM_ROLE_BASE))
		{
			return linkedAnimGraphInstanceByTag as ABP_TeamRole_Base_C;
		}
		UAnimInstance animInstance = meshComponent.GetAnimInstance();
		if (UKuroStaticLibrary.IsObjectClassByName(animInstance, CharacterNameDefines.Instance.ABP_TEAM_ROLE_BASE))
		{
			return animInstance as ABP_TeamRole_Base_C;
		}
		UAnimInstance uanimInstance = linkedAnimGraphInstanceByTag ?? animInstance;
		if (uanimInstance != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "编队角色动画蓝图不是ABP_TeamRole_Base_C或其子类";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AnimInstance", uanimInstance.GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return null;
	}

	// Token: 0x0400B58E RID: 46478
	private UiFormationRoleDataComponent UiFormationRoleDataComponent;

	// Token: 0x0400B58F RID: 46479
	private UiRoleDataComponent UiRoleDataComponent;
}
