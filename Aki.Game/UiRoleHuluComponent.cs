using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002CAF RID: 11439
[NullableContext(2)]
[Nullable(0)]
public class UiRoleHuluComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect
{
	// Token: 0x06017E65 RID: 97893 RVA: 0x00613448 File Offset: 0x00611648
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
		this.HuluHandle = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.HuluOnRole);
		this.SetActive(false);
	}

	// Token: 0x06017E66 RID: 97894 RVA: 0x006134AC File Offset: 0x006116AC
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnUiRoleModelStartLoad));
		UiModelAnsControllerComponent ansControllerComponent = this.AnsControllerComponent;
		if (ansControllerComponent == null)
		{
			return;
		}
		ansControllerComponent.RegisterAnsTrigger("UiCalabashAnsContext", new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), null, null);
	}

	// Token: 0x06017E67 RID: 97895 RVA: 0x0061352C File Offset: 0x0061172C
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnUiRoleModelStartLoad));
		SkeletalObserverManager.DestroySkeletalObserver(this.HuluHandle);
	}

	// Token: 0x06017E68 RID: 97896 RVA: 0x00613588 File Offset: 0x00611788
	[NullableContext(1)]
	public SkeletalObserverHandle GetHuluHandle()
	{
		return this.HuluHandle;
	}

	// Token: 0x06017E69 RID: 97897 RVA: 0x00613590 File Offset: 0x00611790
	public void OnModelVisibleChange(bool visible)
	{
		if (!visible && this.CurState == EHuluState.Showing)
		{
			this.SetActive(false);
		}
		this.AwaitVisible = new bool?(visible);
	}

	// Token: 0x06017E6A RID: 97898 RVA: 0x006135B1 File Offset: 0x006117B1
	private void OnUiRoleModelStartLoad()
	{
		this.Refresh();
	}

	// Token: 0x06017E6B RID: 97899 RVA: 0x006135B9 File Offset: 0x006117B9
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

	// Token: 0x06017E6C RID: 97900 RVA: 0x006135E0 File Offset: 0x006117E0
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

	// Token: 0x06017E6D RID: 97901 RVA: 0x00613668 File Offset: 0x00611868
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

	// Token: 0x06017E6E RID: 97902 RVA: 0x006136C8 File Offset: 0x006118C8
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

	// Token: 0x06017E6F RID: 97903 RVA: 0x00613728 File Offset: 0x00611928
	public void AttachHuluToRole(FName socketName = default(FName))
	{
		if (socketName == default(FName))
		{
			socketName = CharacterNameDefines.Instance.HULU_CASE;
		}
		this.SocketName = socketName;
		this.ExecuteAttachHuluToRole();
	}

	// Token: 0x06017E70 RID: 97904 RVA: 0x00613760 File Offset: 0x00611960
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

	// Token: 0x06017E71 RID: 97905 RVA: 0x006137F0 File Offset: 0x006119F0
	public void OnRoleMeshLoadComplete()
	{
		this.ExecuteAttachHuluToRole();
	}

	// Token: 0x06017E72 RID: 97906 RVA: 0x006137F8 File Offset: 0x006119F8
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

	// Token: 0x06017E73 RID: 97907 RVA: 0x00613846 File Offset: 0x00611A46
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

	// Token: 0x0400B22F RID: 45615
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B230 RID: 45616
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B231 RID: 45617
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B232 RID: 45618
	private UiModelAnsControllerComponent AnsControllerComponent;

	// Token: 0x0400B233 RID: 45619
	private SkeletalObserverHandle HuluHandle;

	// Token: 0x0400B234 RID: 45620
	private FName SocketName = CharacterNameDefines.Instance.HULU_SOCKET_NAME;

	// Token: 0x0400B235 RID: 45621
	private EHuluState CurState;

	// Token: 0x0400B236 RID: 45622
	private bool? AwaitVisible;
}
