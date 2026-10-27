using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02002CA9 RID: 11433
[NullableContext(2)]
[Nullable(0)]
public class UiFormationRoleLoadComponent : UiModelLoadComponent
{
	// Token: 0x06017E43 RID: 97859 RVA: 0x00612CDE File Offset: 0x00610EDE
	protected override void OnInit()
	{
		base.OnInit();
		this.UiRoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.UiFormationRoleDataComponent = base.Owner.CheckGetComponent<UiFormationRoleDataComponent>();
	}

	// Token: 0x06017E44 RID: 97860 RVA: 0x00612D08 File Offset: 0x00610F08
	protected override void OnEnd()
	{
		base.OnEnd();
	}

	// Token: 0x06017E45 RID: 97861 RVA: 0x00612D10 File Offset: 0x00610F10
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

	// Token: 0x06017E46 RID: 97862 RVA: 0x00612DDC File Offset: 0x00610FDC
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

	// Token: 0x06017E47 RID: 97863 RVA: 0x00612E74 File Offset: 0x00611074
	[NullableContext(1)]
	protected override string GetAnimClassPath()
	{
		return SkinConfig.Instance.GetRoleSkinConfig(this.UiRoleDataComponent.RoleSkinId).Value.UiTeamABP;
	}

	// Token: 0x06017E48 RID: 97864 RVA: 0x00612EA6 File Offset: 0x006110A6
	protected override void FinishLoad()
	{
		this.SetTeamRolePosition();
		base.FinishLoad();
	}

	// Token: 0x06017E49 RID: 97865 RVA: 0x00612EB4 File Offset: 0x006110B4
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

	// Token: 0x06017E4A RID: 97866 RVA: 0x00612EF8 File Offset: 0x006110F8
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

	// Token: 0x0400B223 RID: 45603
	private UiFormationRoleDataComponent UiFormationRoleDataComponent;

	// Token: 0x0400B224 RID: 45604
	private UiRoleDataComponent UiRoleDataComponent;
}
