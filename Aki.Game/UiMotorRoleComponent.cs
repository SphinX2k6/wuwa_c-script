using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021FD RID: 8701
[NullableContext(2)]
[Nullable(0)]
public class UiMotorRoleComponent : UiModelComponentBase, IUiModelVisible
{
	// Token: 0x06015695 RID: 87701 RVA: 0x00637ED4 File Offset: 0x006360D4
	protected override void OnInit()
	{
		this.RoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleOnMotor);
		this.RoleDataComponent = this.RoleActor.Model.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = this.RoleActor.Model.CheckGetComponent<UiModelDataComponent>();
		this.SetActive(false);
	}

	// Token: 0x06015696 RID: 87702 RVA: 0x00637F28 File Offset: 0x00636128
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnMotorModelStartLoad));
	}

	// Token: 0x06015697 RID: 87703 RVA: 0x00637F7C File Offset: 0x0063617C
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnMotorModelStartLoad));
		this.CancelAnimLoad();
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.RoleActor);
	}

	// Token: 0x06015698 RID: 87704 RVA: 0x00637FE4 File Offset: 0x006361E4
	public void OnModelVisibleChange(bool visible)
	{
		if (this.ModelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			this.SetActive(false);
			return;
		}
		this.SetActive(visible);
	}

	// Token: 0x06015699 RID: 87705 RVA: 0x00638003 File Offset: 0x00636203
	private void OnMotorModelStartLoad()
	{
		this.Refresh();
	}

	// Token: 0x0601569A RID: 87706 RVA: 0x0063800C File Offset: 0x0063620C
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

	// Token: 0x0601569B RID: 87707 RVA: 0x00638080 File Offset: 0x00636280
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

	// Token: 0x0601569C RID: 87708 RVA: 0x006380DE File Offset: 0x006362DE
	public void OnMotorMeshLoadComplete()
	{
		this.ExecuteAttachRoleToMotor();
		this.SetActive(this.ModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete);
	}

	// Token: 0x0601569D RID: 87709 RVA: 0x006380FC File Offset: 0x006362FC
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

	// Token: 0x0601569E RID: 87710 RVA: 0x006381DC File Offset: 0x006363DC
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

	// Token: 0x0601569F RID: 87711 RVA: 0x00638226 File Offset: 0x00636426
	private void CancelAnimLoad()
	{
		if (this.AnimHandleId != UiModelResourcesManager.Instance.InvalidValue)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.AnimHandleId);
			this.AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;
		}
	}

	// Token: 0x0400B578 RID: 46456
	private TsUiSceneRoleActor RoleActor;

	// Token: 0x0400B579 RID: 46457
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B57A RID: 46458
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B57B RID: 46459
	private readonly FName SocketName = new FName("SeatProp01");

	// Token: 0x0400B57C RID: 46460
	private int AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;

	// Token: 0x0400B57D RID: 46461
	private EMotorShowState CurState;
}
