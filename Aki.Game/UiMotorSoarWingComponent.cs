using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021FF RID: 8703
[NullableContext(2)]
[Nullable(0)]
public class UiMotorSoarWingComponent : UiModelComponentBase
{
	// Token: 0x060156A1 RID: 87713 RVA: 0x00638284 File Offset: 0x00636484
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.MotorDataComponent = base.Owner.CheckGetComponent<UiMotorDataComponent>();
		this.SoarWingHandle = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.MotorSoarWingOnMotor);
		this.SetActive(false);
	}

	// Token: 0x060156A2 RID: 87714 RVA: 0x006382D8 File Offset: 0x006364D8
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnUiMotorModelStartLoad));
	}

	// Token: 0x060156A3 RID: 87715 RVA: 0x0063832C File Offset: 0x0063652C
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnUiMotorModelStartLoad));
		this.DestroySoarWingEffects();
		if (this.SoarWingHandle != null)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.SoarWingHandle);
			this.SoarWingHandle = null;
		}
	}

	// Token: 0x060156A4 RID: 87716 RVA: 0x0063839D File Offset: 0x0063659D
	private bool IsMotorLoadComplete()
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		return modelDataComponent != null && modelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete;
	}

	// Token: 0x060156A5 RID: 87717 RVA: 0x006383B3 File Offset: 0x006365B3
	public void TrySetActive(bool isActive)
	{
		if (isActive && (!this.IsMotorLoadComplete() || !this.CanShowMotorSoarWing))
		{
			return;
		}
		this.SetActive(isActive);
	}

	// Token: 0x060156A6 RID: 87718 RVA: 0x006383D0 File Offset: 0x006365D0
	public void SetActive(bool isActive)
	{
		if ((isActive && this.CurState == ESoaringWingState.Showing) || (!isActive && this.CurState == ESoaringWingState.Hidden))
		{
			return;
		}
		SkeletalObserverHandle soarWingHandle = this.SoarWingHandle;
		object obj;
		if (soarWingHandle == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = soarWingHandle.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.SetVisible(isActive);
		}
		this.CurState = (isActive ? ESoaringWingState.Showing : ESoaringWingState.Hidden);
	}

	// Token: 0x060156A7 RID: 87719 RVA: 0x0063842E File Offset: 0x0063662E
	public void SetSoarWingId(int soarWingId)
	{
		this.SoarWingId = soarWingId;
	}

	// Token: 0x060156A8 RID: 87720 RVA: 0x00638437 File Offset: 0x00636637
	public void SetCanShowSoarWing(bool canShow)
	{
		this.CanShowMotorSoarWing = canShow;
	}

	// Token: 0x060156A9 RID: 87721 RVA: 0x00638440 File Offset: 0x00636640
	public void RefreshSoarWing(int soarWingId)
	{
		if (!this.CanShowMotorSoarWing)
		{
			this.SetActive(false);
			this.DestroySoarWingEffects();
			return;
		}
		this.DestroySoarWingEffects();
		SkeletalObserverHandle soarWingHandle = this.SoarWingHandle;
		UiModelBase uiModelBase = (soarWingHandle != null) ? soarWingHandle.Model : null;
		UiDecorationLoadComponent uiDecorationLoadComponent = (uiModelBase != null) ? uiModelBase.CheckGetComponent<UiDecorationLoadComponent>() : null;
		if (uiDecorationLoadComponent == null || this.ActorComponent == null)
		{
			return;
		}
		uiDecorationLoadComponent.SetAttachActorComponent(this.ActorComponent);
		uiDecorationLoadComponent.SetAttachSkinId(this.MotorDataComponent.GetSkinId());
		uiDecorationLoadComponent.LoadModelByModelId(soarWingId, 0, false, delegate
		{
			this.TrySetActive(true);
			this.SpawnSoarWingEffects(soarWingId);
		}, null, false);
	}

	// Token: 0x060156AA RID: 87722 RVA: 0x006384E1 File Offset: 0x006366E1
	public void RefreshCurSoarWing()
	{
		this.RefreshSoarWing(this.SoarWingId);
	}

	// Token: 0x060156AB RID: 87723 RVA: 0x006384EF File Offset: 0x006366EF
	[NullableContext(1)]
	private SDecorationConfig GetSoarWingConfig(int configId)
	{
		return DataTableUtil.GetDataTableRowFromName<SDecorationConfig>(EDataTable.DecorationConfig, configId.ToString());
	}

	// Token: 0x060156AC RID: 87724 RVA: 0x00638500 File Offset: 0x00636700
	private void SpawnSoarWingEffects(int soarWingId)
	{
		if (!this.CanShowMotorSoarWing || soarWingId <= 0 || this.SoarWingEffectHandleSet.Count > 0)
		{
			return;
		}
		SDecorationConfig soarWingConfig = this.GetSoarWingConfig(soarWingId);
		if (soarWingConfig.Effects.Num() <= 0)
		{
			return;
		}
		SkeletalObserverHandle soarWingHandle = this.SoarWingHandle;
		USkeletalMeshComponent uskeletalMeshComponent;
		if (soarWingHandle == null)
		{
			uskeletalMeshComponent = null;
		}
		else
		{
			UiModelBase model = soarWingHandle.Model;
			if (model == null)
			{
				uskeletalMeshComponent = null;
			}
			else
			{
				UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
				uskeletalMeshComponent = ((uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null);
			}
		}
		USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
		if (uskeletalMeshComponent2 == null)
		{
			return;
		}
		SkeletalObserverHandle soarWingHandle2 = this.SoarWingHandle;
		UiModelEffectComponent uiModelEffectComponent;
		if (soarWingHandle2 == null)
		{
			uiModelEffectComponent = null;
		}
		else
		{
			UiModelBase model2 = soarWingHandle2.Model;
			uiModelEffectComponent = ((model2 != null) ? model2.CheckGetComponent<UiModelEffectComponent>() : null);
		}
		UiModelEffectComponent uiModelEffectComponent2 = uiModelEffectComponent;
		if (uiModelEffectComponent2 == null)
		{
			return;
		}
		for (int i = 0; i < soarWingConfig.Effects.Num(); i++)
		{
			SDecorationConfig_Effect sdecorationConfig_Effect = soarWingConfig.Effects.Get(i);
			UiModelEffectPlayContext context = new UiModelEffectPlayContext
			{
				EffectPath = sdecorationConfig_Effect.EffectData.ToAssetPathName(),
				AttachTargetComponent = uskeletalMeshComponent2,
				Transform = MathUtils.Instance.DefaultTransformDouble,
				SocketName = (FNameUtil.GetDynamicFName(sdecorationConfig_Effect.EffectSocketName) ?? FNameUtil.EMPTY)
			};
			int item = uiModelEffectComponent2.PlayEffectByContext(context);
			this.SoarWingEffectHandleSet.Add(item);
		}
	}

	// Token: 0x060156AD RID: 87725 RVA: 0x00638630 File Offset: 0x00636830
	private void DestroySoarWingEffects()
	{
		if (this.SoarWingEffectHandleSet.Count <= 0)
		{
			return;
		}
		SkeletalObserverHandle soarWingHandle = this.SoarWingHandle;
		UiModelEffectComponent uiModelEffectComponent;
		if (soarWingHandle == null)
		{
			uiModelEffectComponent = null;
		}
		else
		{
			UiModelBase model = soarWingHandle.Model;
			uiModelEffectComponent = ((model != null) ? model.CheckGetComponent<UiModelEffectComponent>() : null);
		}
		UiModelEffectComponent uiModelEffectComponent2 = uiModelEffectComponent;
		if (uiModelEffectComponent2 == null)
		{
			this.SoarWingEffectHandleSet.Clear();
			return;
		}
		foreach (int effectHandle in this.SoarWingEffectHandleSet)
		{
			uiModelEffectComponent2.StopEffect(effectHandle, true);
		}
		this.SoarWingEffectHandleSet.Clear();
	}

	// Token: 0x060156AE RID: 87726 RVA: 0x006386CC File Offset: 0x006368CC
	private void OnMotorMeshLoadComplete()
	{
		this.TrySetActive(true);
		this.SpawnSoarWingEffects(this.SoarWingId);
	}

	// Token: 0x060156AF RID: 87727 RVA: 0x006386E1 File Offset: 0x006368E1
	private void OnUiMotorModelStartLoad()
	{
		this.SetActive(false);
		this.RefreshSoarWing(this.SoarWingId);
	}

	// Token: 0x0400B582 RID: 46466
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B583 RID: 46467
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B584 RID: 46468
	private UiMotorDataComponent MotorDataComponent;

	// Token: 0x0400B585 RID: 46469
	private SkeletalObserverHandle SoarWingHandle;

	// Token: 0x0400B586 RID: 46470
	private ESoaringWingState CurState;

	// Token: 0x0400B587 RID: 46471
	private int SoarWingId;

	// Token: 0x0400B588 RID: 46472
	private bool CanShowMotorSoarWing;

	// Token: 0x0400B589 RID: 46473
	[Nullable(1)]
	private readonly HashSet<int> SoarWingEffectHandleSet = new HashSet<int>();
}
