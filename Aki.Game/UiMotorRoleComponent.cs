using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002CA4 RID: 11428
[NullableContext(2)]
[Nullable(0)]
public class UiMotorRoleComponent : UiModelComponentBase, IUiModelVisible
{
	// Token: 0x06017E21 RID: 97825 RVA: 0x00612350 File Offset: 0x00610550
	protected override void OnInit()
	{
		this.RoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleOnMotor);
		this.RoleDataComponent = this.RoleActor.Model.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = this.RoleActor.Model.CheckGetComponent<UiModelDataComponent>();
		this.SetActive(false);
	}

	// Token: 0x06017E22 RID: 97826 RVA: 0x006123A4 File Offset: 0x006105A4
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnMotorModelStartLoad));
	}

	// Token: 0x06017E23 RID: 97827 RVA: 0x006123F8 File Offset: 0x006105F8
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnMotorModelStartLoad));
		this.CancelAnimLoad();
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.RoleActor);
	}

	// Token: 0x06017E24 RID: 97828 RVA: 0x00612460 File Offset: 0x00610660
	public void OnModelVisibleChange(bool visible)
	{
		if (this.ModelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			this.SetActive(false);
			return;
		}
		this.SetActive(visible);
	}

	// Token: 0x06017E25 RID: 97829 RVA: 0x0061247F File Offset: 0x0061067F
	private void OnMotorModelStartLoad()
	{
		this.Refresh();
	}

	// Token: 0x06017E26 RID: 97830 RVA: 0x00612488 File Offset: 0x00610688
	public void Refresh()
	{
		UiModelBase model = this.RoleActor.Model;
		UiMotorDataComponent motorDataComponent = base.Owner.CheckGetComponent<UiMotorDataComponent>();
		string animPath = motorDataComponent.GetAnimPath();
		if (string.IsNullOrEmpty(animPath))
		{
			return;
		}
		UiRoleLoadComponent loadComponent = model.CheckGetComponent<UiRoleLoadComponent>();
		this.CancelAnimLoad();
		this.LoadAnimByAnimPath(animPath, delegate(UAnimationAsset animAsset)
		{
			int roleId = motorDataComponent.GetRoleId();
			int roleSkinId = motorDataComponent.GetRoleSkinId();
			if (roleId == this.RoleDataComponent.RoleConfigId && roleSkinId == this.RoleDataComponent.RoleSkinId)
			{
				return;
			}
			this.SetActive(false);
			loadComponent.LoadModelByRoleConfigId(roleId, roleSkinId, true, delegate
			{
				UiModelDataComponent uiModelDataComponent = this.Owner.CheckGetComponent<UiModelDataComponent>();
				TsUiSceneRoleActor roleActor = this.RoleActor;
				UiModelActorComponent uiModelActorComponent;
				if (roleActor == null)
				{
					uiModelActorComponent = null;
				}
				else
				{
					UiModelBase model2 = roleActor.Model;
					uiModelActorComponent = ((model2 != null) ? model2.CheckGetComponent<UiModelActorComponent>() : null);
				}
				UiModelActorComponent uiModelActorComponent2 = uiModelActorComponent;
				if (((uiModelActorComponent2 != null) ? uiModelActorComponent2.Actor : null) != null)
				{
					FHitResult fhitResult = new FHitResult();
					SModelConfig modelConfig = ModelUtil.GetModelConfig(uiModelDataComponent.ModelConfigId);
					uiModelActorComponent2.Actor.D_K2_SetActorRelativeLocation(modelConfig.骑摩托位置偏移, false, ref fhitResult, false);
				}
				bool active = uiModelDataComponent != null && uiModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete;
				this.SetActive(active);
				TsUiSceneRoleActor roleActor2 = this.RoleActor;
				object obj;
				if (roleActor2 == null)
				{
					obj = null;
				}
				else
				{
					UiModelBase model3 = roleActor2.Model;
					obj = ((model3 != null) ? model3.CheckGetComponent<UiModelAnimationComponent>() : null);
				}
				object obj2 = obj;
				if (obj2 == null)
				{
					return;
				}
				obj2.PlayAnimation(animAsset, true);
			});
		});
	}

	// Token: 0x06017E27 RID: 97831 RVA: 0x006124FC File Offset: 0x006106FC
	public void SetActive(bool isActive)
	{
		if ((isActive && this.CurState == EMotorShowState.Showing) || (!isActive && this.CurState == EMotorShowState.Hidden))
		{
			return;
		}
		TsUiSceneRoleActor roleActor = this.RoleActor;
		object obj;
		if (roleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = roleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.SetVisible(isActive);
		}
		this.CurState = (isActive ? EMotorShowState.Showing : EMotorShowState.Hidden);
	}

	// Token: 0x06017E28 RID: 97832 RVA: 0x0061255A File Offset: 0x0061075A
	public void OnMotorMeshLoadComplete()
	{
		this.ExecuteAttachRoleToMotor();
		this.SetActive(this.ModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete);
	}

	// Token: 0x06017E29 RID: 97833 RVA: 0x00612578 File Offset: 0x00610778
	private void ExecuteAttachRoleToMotor()
	{
		UiModelActorComponent uiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		if (base.Owner.CheckGetComponent<UiModelDataComponent>().GetModelLoadState() == EUiModelLoadState.LoadComplete)
		{
			USkeletalMeshComponent mainMeshComponent = uiModelActorComponent.MainMeshComponent;
			TsUiSceneRoleActor roleActor = this.RoleActor;
			UiModelActorComponent uiModelActorComponent2;
			if (roleActor == null)
			{
				uiModelActorComponent2 = null;
			}
			else
			{
				UiModelBase model = roleActor.Model;
				uiModelActorComponent2 = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
			}
			UiModelActorComponent uiModelActorComponent3 = uiModelActorComponent2;
			if (uiModelActorComponent3 != null)
			{
				AActor actor = uiModelActorComponent3.Actor;
				if (actor != null)
				{
					actor.K2_AttachToComponent(mainMeshComponent, this.SocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, false, true);
				}
			}
			if (((uiModelActorComponent3 != null) ? uiModelActorComponent3.Actor : null) != null)
			{
				FRotator deltaRotation = new FRotator(0f, -90f, 0f);
				FHitResult fhitResult = new FHitResult();
				uiModelActorComponent3.Actor.K2_AddActorWorldRotation(deltaRotation, false, ref fhitResult, false);
				SModelConfig modelConfig = ModelUtil.GetModelConfig(base.Owner.CheckGetComponent<UiModelDataComponent>().ModelConfigId);
				uiModelActorComponent3.Actor.D_K2_SetActorRelativeLocation(modelConfig.骑摩托位置偏移, false, ref fhitResult, false);
			}
		}
	}

	// Token: 0x06017E2A RID: 97834 RVA: 0x00612658 File Offset: 0x00610858
	[NullableContext(1)]
	private void LoadAnimByAnimPath(string standAnim, Action<UAnimationAsset> finishCallBack)
	{
		this.AnimHandleId = ResourceSystem.Instance.LoadAsync<UAnimationAsset>(standAnim, delegate([Nullable(2)] UAnimationAsset asset, string _)
		{
			if (asset == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiModel;
				ELogAuthor author = ELogAuthor.BB;
				string message = "UiMotorRoleComponent LoadAnimByAnimPath animAsset is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("standAnim", standAnim);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			finishCallBack(asset);
		}, 100, "Ui.UiSceneModel");
	}

	// Token: 0x06017E2B RID: 97835 RVA: 0x006126A2 File Offset: 0x006108A2
	private void CancelAnimLoad()
	{
		if (this.AnimHandleId != UiModelResourcesManager.Instance.InvalidValue)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.AnimHandleId);
			this.AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;
		}
	}

	// Token: 0x0400B20D RID: 45581
	private TsUiSceneRoleActor RoleActor;

	// Token: 0x0400B20E RID: 45582
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B20F RID: 45583
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B210 RID: 45584
	private readonly FName SocketName = new FName("SeatProp01");

	// Token: 0x0400B211 RID: 45585
	private int AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;

	// Token: 0x0400B212 RID: 45586
	private EMotorShowState CurState;
}
