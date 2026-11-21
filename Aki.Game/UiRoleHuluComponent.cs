using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002208 RID: 8712
[NullableContext(2)]
[Nullable(0)]
public class UiRoleHuluComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect
{
	// Token: 0x060156D9 RID: 87769 RVA: 0x00638FCC File Offset: 0x006371CC
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
		this.HuluHandle = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.HuluOnRole);
		this.SetActive(false);
	}

	// Token: 0x060156DA RID: 87770 RVA: 0x00639030 File Offset: 0x00637230
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnUiRoleModelStartLoad));
		UiModelAnsControllerComponent ansControllerComponent = this.AnsControllerComponent;
		if (ansControllerComponent == null)
		{
			return;
		}
		ansControllerComponent.RegisterAnsTrigger(typeof(UiCalabashAnsContext), new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), null, null);
	}

	// Token: 0x060156DB RID: 87771 RVA: 0x006390B8 File Offset: 0x006372B8
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnUiRoleModelStartLoad));
		SkeletalObserverManager.DestroySkeletalObserver(this.HuluHandle);
	}

	// Token: 0x060156DC RID: 87772 RVA: 0x00639114 File Offset: 0x00637314
	[NullableContext(1)]
	public SkeletalObserverHandle GetHuluHandle()
	{
		return this.HuluHandle;
	}

	// Token: 0x060156DD RID: 87773 RVA: 0x0063911C File Offset: 0x0063731C
	public void OnModelVisibleChange(bool visible)
	{
		if (!visible && this.CurState == EHuluState.Showing)
		{
			this.SetActive(false);
		}
		this.AwaitVisible = new bool?(visible);
	}

	// Token: 0x060156DE RID: 87774 RVA: 0x0063913D File Offset: 0x0063733D
	private void OnUiRoleModelStartLoad()
	{
		this.Refresh();
	}

	// Token: 0x060156DF RID: 87775 RVA: 0x00639145 File Offset: 0x00637345
	public void OnModelDitherEffectChange(float value)
	{
		SkeletalObserverHandle huluHandle = this.HuluHandle;
		if (huluHandle == null)
		{
			return;
		}
		UiModelBase model = huluHandle.Model;
		if (model == null)
		{
			return;
		}
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		if (uiModelDataComponent == null)
		{
			return;
		}
		uiModelDataComponent.SetDitherEffect(value);
	}

	// Token: 0x060156E0 RID: 87776 RVA: 0x0063916C File Offset: 0x0063736C
	public void Refresh()
	{
		UiModelBase model = this.HuluHandle.Model;
		UiHuluSkinDataComponent uiHuluSkinDataComponent = model.CheckGetComponent<UiHuluSkinDataComponent>();
		if (uiHuluSkinDataComponent != null)
		{
			uiHuluSkinDataComponent.RefreshCurrentSkinData(this.RoleDataComponent.RoleConfigId);
		}
		int modelId = uiHuluSkinDataComponent.ModelId;
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		int num = modelId;
		int? num2 = (uiModelDataComponent != null) ? new int?(uiModelDataComponent.ModelConfigId) : null;
		if (num == num2.GetValueOrDefault() & num2 != null)
		{
			return;
		}
		UiModelLoadComponent uiModelLoadComponent = model.CheckGetComponent<UiModelLoadComponent>();
		if (uiModelLoadComponent == null)
		{
			return;
		}
		uiModelLoadComponent.LoadModelByModelId(modelId, false, null, null);
	}

	// Token: 0x060156E1 RID: 87777 RVA: 0x006391F4 File Offset: 0x006373F4
	public void SetActive(bool isActive)
	{
		if ((isActive && this.CurState == EHuluState.Showing) || (!isActive && this.CurState == EHuluState.Hidden))
		{
			return;
		}
		SkeletalObserverHandle huluHandle = this.HuluHandle;
		object obj;
		if (huluHandle == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = huluHandle.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.SetVisible(isActive);
		}
		this.CurState = (isActive ? EHuluState.Showing : EHuluState.Hidden);
	}

	// Token: 0x060156E2 RID: 87778 RVA: 0x00639254 File Offset: 0x00637454
	public void StartHuluRotate()
	{
		if (this.HuluHandle != null)
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("hulu_rotate_time");
			SkeletalObserverHandle huluHandle = this.HuluHandle;
			object obj;
			if (huluHandle == null)
			{
				obj = null;
			}
			else
			{
				UiModelBase model = huluHandle.Model;
				obj = ((model != null) ? model.CheckGetComponent<UiModelRotateComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.SetRotateParam((float)intConfig.Value, ERotateAxis.Roll, false);
			}
			if (obj2 == null)
			{
				return;
			}
			obj2.StartRotate();
		}
	}

	// Token: 0x060156E3 RID: 87779 RVA: 0x006392B4 File Offset: 0x006374B4
	public void AttachHuluToRole(FName socketName = default(FName))
	{
		if (socketName == default(FName))
		{
			socketName = CharacterNameDefines.Instance.HULU_CASE;
		}
		this.SocketName = socketName;
		this.ExecuteAttachHuluToRole();
	}

	// Token: 0x060156E4 RID: 87780 RVA: 0x006392EC File Offset: 0x006374EC
	private void ExecuteAttachHuluToRole()
	{
		if (this.ModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete)
		{
			USkeletalMeshComponent mainMeshComponent = this.ActorComponent.MainMeshComponent;
			SkeletalObserverHandle huluHandle = this.HuluHandle;
			object obj;
			if (huluHandle == null)
			{
				obj = null;
			}
			else
			{
				UiModelBase model = huluHandle.Model;
				obj = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				AActor actor = obj2.Actor;
				if (actor != null)
				{
					actor.K2_AttachToComponent(mainMeshComponent, this.SocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
				}
			}
			FHitResult fhitResult = new FHitResult();
			if (obj2 == null)
			{
				return;
			}
			AActor actor2 = obj2.Actor;
			if (actor2 == null)
			{
				return;
			}
			actor2.D_K2_SetActorRelativeTransform(MathUtils.Instance.DefaultTransformDouble, false, ref fhitResult, false);
		}
	}

	// Token: 0x060156E5 RID: 87781 RVA: 0x0063937C File Offset: 0x0063757C
	public void OnRoleMeshLoadComplete()
	{
		this.ExecuteAttachHuluToRole();
	}

	// Token: 0x060156E6 RID: 87782 RVA: 0x00639384 File Offset: 0x00637584
	[NullableContext(1)]
	public void OnAnsBegin(UiAnsContextBase ansContext)
	{
		UiCalabashAnsContext uiCalabashAnsContext = ansContext as UiCalabashAnsContext;
		bool valueOrDefault = this.AwaitVisible.GetValueOrDefault(true);
		this.SetActive(valueOrDefault);
		this.AwaitVisible = null;
		if (uiCalabashAnsContext.IsRotate)
		{
			this.StartHuluRotate();
		}
		FName socket = uiCalabashAnsContext.Socket;
		this.AttachHuluToRole(socket);
	}

	// Token: 0x060156E7 RID: 87783 RVA: 0x006393D2 File Offset: 0x006375D2
	[NullableContext(1)]
	public void OnAnsEnd(UiAnsContextBase ansContext)
	{
		SkeletalObserverHandle huluHandle = this.HuluHandle;
		object obj;
		if (huluHandle == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = huluHandle.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelRotateComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.StopRotate();
		}
		this.SetActive(false);
	}

	// Token: 0x0400B59A RID: 46490
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B59B RID: 46491
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B59C RID: 46492
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B59D RID: 46493
	private UiModelAnsControllerComponent AnsControllerComponent;

	// Token: 0x0400B59E RID: 46494
	private SkeletalObserverHandle HuluHandle;

	// Token: 0x0400B59F RID: 46495
	private FName SocketName = CharacterNameDefines.Instance.HULU_SOCKET_NAME;

	// Token: 0x0400B5A0 RID: 46496
	private EHuluState CurState;

	// Token: 0x0400B5A1 RID: 46497
	private bool? AwaitVisible;
}
