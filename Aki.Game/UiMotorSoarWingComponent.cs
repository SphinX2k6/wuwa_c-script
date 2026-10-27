using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002CA6 RID: 11430
[NullableContext(2)]
[Nullable(0)]
public class UiMotorSoarWingComponent : UiModelComponentBase
{
	// Token: 0x06017E2D RID: 97837 RVA: 0x00612700 File Offset: 0x00610900
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.MotorDataComponent = base.Owner.CheckGetComponent<UiMotorDataComponent>();
		this.SoarWingHandle = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.MotorSoarWingOnMotor);
		this.SetActive(false);
	}

	// Token: 0x06017E2E RID: 97838 RVA: 0x00612754 File Offset: 0x00610954
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnUiMotorModelStartLoad));
	}

	// Token: 0x06017E2F RID: 97839 RVA: 0x006127A8 File Offset: 0x006109A8
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

	// Token: 0x06017E30 RID: 97840 RVA: 0x00612819 File Offset: 0x00610A19
	private bool IsMotorLoadComplete()
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		return modelDataComponent != null && modelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete;
	}

	// Token: 0x06017E31 RID: 97841 RVA: 0x0061282F File Offset: 0x00610A2F
	public void TrySetActive(bool isActive)
	{
		if (isActive && (!this.IsMotorLoadComplete() || !this.CanShowMotorSoarWing))
		{
			return;
		}
		this.SetActive(isActive);
	}

	// Token: 0x06017E32 RID: 97842 RVA: 0x0061284C File Offset: 0x00610A4C
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

	// Token: 0x06017E33 RID: 97843 RVA: 0x006128AA File Offset: 0x00610AAA
	public void SetSoarWingId(int soarWingId)
	{
		this.SoarWingId = soarWingId;
	}

	// Token: 0x06017E34 RID: 97844 RVA: 0x006128B3 File Offset: 0x00610AB3
	public void SetCanShowSoarWing(bool canShow)
	{
		this.CanShowMotorSoarWing = canShow;
	}

	// Token: 0x06017E35 RID: 97845 RVA: 0x006128BC File Offset: 0x00610ABC
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

	// Token: 0x06017E36 RID: 97846 RVA: 0x0061295D File Offset: 0x00610B5D
	public void RefreshCurSoarWing()
	{
		this.RefreshSoarWing(this.SoarWingId);
	}

	// Token: 0x06017E37 RID: 97847 RVA: 0x0061296B File Offset: 0x00610B6B
	[NullableContext(1)]
	private SDecorationConfig GetSoarWingConfig(int configId)
	{
		return DataTableUtil.GetDataTableRowFromName<SDecorationConfig>(EDataTable.DecorationConfig, configId.ToString());
	}

	// Token: 0x06017E38 RID: 97848 RVA: 0x0061297C File Offset: 0x00610B7C
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

	// Token: 0x06017E39 RID: 97849 RVA: 0x00612AAC File Offset: 0x00610CAC
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

	// Token: 0x06017E3A RID: 97850 RVA: 0x00612B48 File Offset: 0x00610D48
	private void OnMotorMeshLoadComplete()
	{
		this.TrySetActive(true);
		this.SpawnSoarWingEffects(this.SoarWingId);
	}

	// Token: 0x06017E3B RID: 97851 RVA: 0x00612B5D File Offset: 0x00610D5D
	private void OnUiMotorModelStartLoad()
	{
		this.SetActive(false);
		this.RefreshSoarWing(this.SoarWingId);
	}

	// Token: 0x0400B217 RID: 45591
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B218 RID: 45592
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B219 RID: 45593
	private UiMotorDataComponent MotorDataComponent;

	// Token: 0x0400B21A RID: 45594
	private SkeletalObserverHandle SoarWingHandle;

	// Token: 0x0400B21B RID: 45595
	private ESoaringWingState CurState;

	// Token: 0x0400B21C RID: 45596
	private int SoarWingId;

	// Token: 0x0400B21D RID: 45597
	private bool CanShowMotorSoarWing;

	// Token: 0x0400B21E RID: 45598
	[Nullable(1)]
	private readonly HashSet<int> SoarWingEffectHandleSet = new HashSet<int>();
}
