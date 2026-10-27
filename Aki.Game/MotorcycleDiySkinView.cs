using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiModel.Struct;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022AE RID: 8878
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiySkinView : UiViewBase
{
	// Token: 0x06011646 RID: 71238 RVA: 0x004422F0 File Offset: 0x004404F0
	public MotorcycleDiySkinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011647 RID: 71239 RVA: 0x00442393 File Offset: 0x00440593
	protected override void OnBeforeCreate()
	{
		this.ModelInputBehavior = new UiBehaviorModelInput();
		base.AddUiBehavior(this.ModelInputBehavior);
	}

	// Token: 0x06011648 RID: 71240 RVA: 0x004423AC File Offset: 0x004405AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(13, new Action(this.OnBtnBackClick))
		};
	}

	// Token: 0x06011649 RID: 71241 RVA: 0x0044250C File Offset: 0x0044070C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiySkinView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiySkinView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601164A RID: 71242 RVA: 0x0044254F File Offset: 0x0044074F
	protected override void OnHandleLoadScene()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
	}

	// Token: 0x0601164B RID: 71243 RVA: 0x0044255D File Offset: 0x0044075D
	protected override void OnBeforeShow()
	{
		MotorcycleUiModelUtil.Instance.SetSoarWingEnabled(true);
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
		this.InitModelInputData();
		MotorcycleUiModelUtil.Instance.LoadMotorBySkinId(this.CurSkinId, delegate(UiModelBase _)
		{
			this.RefreshAutoRotateParam();
		});
		this.RefreshSkinTogItemsFromShop();
	}

	// Token: 0x0601164C RID: 71244 RVA: 0x004425A0 File Offset: 0x004407A0
	protected override void OnAfterShow()
	{
		this.ClearCloseRotationRollbackTimer();
		this.IsClosingWithRotate = false;
		UiModelControlRotateComponent controlRotateComponent = this.ControlRotateComponent;
		if (controlRotateComponent != null)
		{
			controlRotateComponent.Activate();
		}
		this.CaptureInitialMotorRotation();
		UiModelControlRotateComponent controlRotateComponent2 = this.ControlRotateComponent;
		if (controlRotateComponent2 != null)
		{
			controlRotateComponent2.Deactivate();
		}
		this.RefreshAutoRotateParam();
		MotorcycleUiModelUtil.Instance.SetAutoRotate(true);
	}

	// Token: 0x0601164D RID: 71245 RVA: 0x004425F4 File Offset: 0x004407F4
	protected override void OnBeforeHide()
	{
		this.ResetAutoRotateLocation();
		if (this.IsClosingWithRotate)
		{
			return;
		}
		this.ClearCloseRotationRollbackTimer();
		MotorcycleUiModelUtil.Instance.SetAutoRotate(false);
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
		MotorcycleUiModelUtil.Instance.SetSoarWingEnabled(false);
		UiModelControlRotateComponent controlRotateComponent = this.ControlRotateComponent;
		if (controlRotateComponent == null)
		{
			return;
		}
		controlRotateComponent.Deactivate();
	}

	// Token: 0x0601164E RID: 71246 RVA: 0x00442647 File Offset: 0x00440847
	protected override void OnHandleReleaseScene()
	{
		this.ClearCloseRotationRollbackTimer();
		this.ResetAutoRotateLocation();
		if (this.IsClosingWithRotate)
		{
			this.IsClosingWithRotate = false;
			UiModelControlRotateComponent controlRotateComponent = this.ControlRotateComponent;
			if (controlRotateComponent != null)
			{
				controlRotateComponent.Deactivate();
			}
		}
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0601164F RID: 71247 RVA: 0x00442680 File Offset: 0x00440880
	private void CaptureInitialMotorRotation()
	{
		AActor motorActor = this.GetMotorActor();
		if (motorActor == null)
		{
			return;
		}
		Rotator initialMotorRotator = this.InitialMotorRotator;
		FRotator frotator = motorActor.K2_GetActorRotation();
		initialMotorRotator.FromUeRotator(frotator);
	}

	// Token: 0x06011650 RID: 71248 RVA: 0x004426AC File Offset: 0x004408AC
	[NullableContext(2)]
	private AActor GetMotorActor()
	{
		UiModelBase motorModel = MotorcycleUiModelUtil.Instance.GetMotorModel();
		UiModelActorComponent uiModelActorComponent = (motorModel != null) ? motorModel.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent == null)
		{
			return null;
		}
		return uiModelActorComponent.Actor;
	}

	// Token: 0x06011651 RID: 71249 RVA: 0x004426D0 File Offset: 0x004408D0
	private void InitModelInputData()
	{
		UiModelBase motorModel = MotorcycleUiModelUtil.Instance.GetMotorModel();
		UiModelControlRotateComponent uiModelControlRotateComponent = (motorModel != null) ? motorModel.CheckGetComponent<UiModelControlRotateComponent>() : null;
		if (uiModelControlRotateComponent == null)
		{
			return;
		}
		SUiModelRotateSetting uiModelRotateSettings = ModelUtil.GetUiModelRotateSettings("摩托车皮肤旋转");
		if (uiModelRotateSettings == null)
		{
			return;
		}
		uiModelControlRotateComponent.InitDataByConfig(uiModelRotateSettings);
		UiModelInputData data = new UiModelInputData
		{
			DragComponent = base.GetDraggable(10),
			ModelBase = motorModel
		};
		UiBehaviorModelInput modelInputBehavior = this.ModelInputBehavior;
		if (modelInputBehavior != null)
		{
			modelInputBehavior.InitData(data);
		}
		if (this.ModelInputBehavior != null)
		{
			this.ModelInputBehavior.OnDragBegin = new Action(this.OnMotorModelDragBegin);
			this.ModelInputBehavior.OnDragEnd = new Action(this.OnMotorModelDragEnd);
			this.ModelInputBehavior.OnGamepadInputBegin = new Action(this.OnMotorModelDragBegin);
			this.ModelInputBehavior.OnGamepadInputEnd = new Action(this.OnMotorModelDragEnd);
		}
		this.ControlRotateComponent = uiModelControlRotateComponent;
	}

	// Token: 0x06011652 RID: 71250 RVA: 0x004427AD File Offset: 0x004409AD
	private void RefreshAutoRotateParam()
	{
		this.SetAutoRotateCenterCase(this.AutoRotateCenterCase);
		MotorcycleUiModelUtil.Instance.InitAutoRotateParam(this.AutoRotateDuration, ERotateAxis.Yaw, true);
	}

	// Token: 0x06011653 RID: 71251 RVA: 0x004427D0 File Offset: 0x004409D0
	private void SetAutoRotateCenterCase(string centerCase)
	{
		this.ResetAutoRotateLocation();
		UiModelBase motorModel = MotorcycleUiModelUtil.Instance.GetMotorModel();
		UiModelActorComponent uiModelActorComponent = (motorModel != null) ? motorModel.CheckGetComponent<UiModelActorComponent>() : null;
		AActor aactor = (uiModelActorComponent != null) ? uiModelActorComponent.Actor : null;
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		FName? dynamicFName = FNameUtil.GetDynamicFName(centerCase);
		AActor aactor2 = (dynamicFName == null) ? null : UKuroCollectActorComponent.GetActorWithTag(dynamicFName.Value, ECollectActorType.UI);
		if (aactor == null || uskeletalMeshComponent == null || aactor2 == null)
		{
			return;
		}
		global::Vector autoRotateActorLocation = this.AutoRotateActorLocation;
		FVectorDouble fvectorDouble = aactor.D_K2_GetActorLocation();
		autoRotateActorLocation.FromUeVector(fvectorDouble);
		global::Vector autoRotateMeshRelativeLocation = this.AutoRotateMeshRelativeLocation;
		FVector relativeLocation = uskeletalMeshComponent.RelativeLocation;
		autoRotateMeshRelativeLocation.FromUeVector(relativeLocation);
		global::Vector autoRotateCenterLocation = this.AutoRotateCenterLocation;
		fvectorDouble = aactor2.D_K2_GetActorLocation();
		autoRotateCenterLocation.FromUeVector(fvectorDouble);
		this.AutoRotateMeshRelativeLocation.Addition(this.AutoRotateActorLocation, this.AutoRotateMeshOffset);
		this.AutoRotateMeshOffset.Subtraction(this.AutoRotateCenterLocation, this.AutoRotateMeshOffset);
		aactor.D_K2_SetActorLocation(this.AutoRotateCenterLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
		uskeletalMeshComponent.K2_SetRelativeLocation(this.AutoRotateMeshOffset.ToUeVectorOld(), false, ref WorldGlobal.SweepHitResult, false);
		this.HasAutoRotateLocationCache = true;
	}

	// Token: 0x06011654 RID: 71252 RVA: 0x004428E8 File Offset: 0x00440AE8
	private void ResetAutoRotateLocation()
	{
		if (!this.HasAutoRotateLocationCache)
		{
			return;
		}
		UiModelBase motorModel = MotorcycleUiModelUtil.Instance.GetMotorModel();
		UiModelActorComponent uiModelActorComponent = (motorModel != null) ? motorModel.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent != null)
		{
			AActor actor = uiModelActorComponent.Actor;
			if (actor != null)
			{
				actor.D_K2_SetActorLocation(this.AutoRotateActorLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
			}
		}
		if (uiModelActorComponent != null)
		{
			USkeletalMeshComponent mainMeshComponent = uiModelActorComponent.MainMeshComponent;
			if (mainMeshComponent != null)
			{
				mainMeshComponent.K2_SetRelativeLocation(this.MeshDefaultRelativeLocation.ToUeVectorOld(), false, ref WorldGlobal.SweepHitResult, false);
			}
		}
		this.HasAutoRotateLocationCache = false;
	}

	// Token: 0x06011655 RID: 71253 RVA: 0x0044296E File Offset: 0x00440B6E
	private MotorcycleDiySkinListItem InitListItem()
	{
		return new MotorcycleDiySkinListItem();
	}

	// Token: 0x06011656 RID: 71254 RVA: 0x00442978 File Offset: 0x00440B78
	private List<MotorcycleDiySkinListItemData> GetCustomizeDataList(bool isBuy)
	{
		List<MotorcycleDiySkinListItemData> list = new List<MotorcycleDiySkinListItemData>();
		int canCustomizeNum = 0;
		int canCustomizeNum2 = 0;
		int canCustomizeNum3 = 0;
		if (!isBuy)
		{
			canCustomizeNum = 1;
			canCustomizeNum2 = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART.Length;
			canCustomizeNum3 = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART.Length;
		}
		list.Add(new MotorcycleDiySkinListItemData(EOutlookType.Frame, canCustomizeNum));
		list.Add(new MotorcycleDiySkinListItemData(EOutlookType.Sticker, canCustomizeNum2));
		list.Add(new MotorcycleDiySkinListItemData(EOutlookType.Decoration, canCustomizeNum3));
		return list;
	}

	// Token: 0x06011657 RID: 71255 RVA: 0x004429CC File Offset: 0x00440BCC
	private void RefreshCurSkinInfo()
	{
		bool flag = MotorcycleDiyModel.Instance.HasSkin(this.CurSkinId);
		bool flag2 = MotorcycleDiyModel.Instance.GetEquippedSkinId() == this.CurSkinId;
		MotorSkin? motorSkinConfig = MotorDiyConfig.Instance.GetMotorSkinConfig(this.CurSkinId);
		base.GetItem(11).SetUIActive(!flag);
		ButtonItem confirmBtnItem = this.ConfirmBtnItem;
		if (confirmBtnItem != null)
		{
			confirmBtnItem.SetUiActive(flag);
		}
		if (motorSkinConfig != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), motorSkinConfig.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), motorSkinConfig.Value.BgDescription, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), motorSkinConfig.Value.TypeDescription, Array.Empty<object>());
			if (!flag)
			{
				MotorcycleDiySkinObtainItem obtainItem = this.ObtainItem;
				if (obtainItem != null)
				{
					obtainItem.Refresh(motorSkinConfig.Value.GetItemAccessArray());
				}
			}
		}
		ButtonItem confirmBtnItem2 = this.ConfirmBtnItem;
		if (confirmBtnItem2 != null)
		{
			confirmBtnItem2.SetEnableClick(!flag2);
		}
		ButtonItem confirmBtnItem3 = this.ConfirmBtnItem;
		if (confirmBtnItem3 == null)
		{
			return;
		}
		confirmBtnItem3.SetLocalTextNew(flag2 ? "MotorSkin_OnUse" : "MotorSkin_UseButton", Array.Empty<object>());
	}

	// Token: 0x06011658 RID: 71256 RVA: 0x00442B0C File Offset: 0x00440D0C
	private void RefreshSkinTogItems(bool isInit = false)
	{
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		int equippedSkinId = instance.GetEquippedSkinId();
		IReadOnlyList<MotorSkin> allMotorSkinList = MotorDiyConfig.Instance.GetAllMotorSkinList();
		MotorcycleDiySkinTogItem[] array = new MotorcycleDiySkinTogItem[]
		{
			this.NormalSkinTogItem,
			this.BuySkinTogItem
		};
		int num = 0;
		while (num < allMotorSkinList.Count && num < array.Length)
		{
			MotorcycleDiySkinTogItem motorcycleDiySkinTogItem = array[num];
			if (motorcycleDiySkinTogItem != null)
			{
				MotorSkin motorSkin = allMotorSkinList[num];
				bool flag = instance.HasSkin(motorSkin.Id);
				bool flag2 = equippedSkinId == motorSkin.Id;
				bool redDotVisible = instance.RedDotHasNewItem(motorSkin.Id);
				motorcycleDiySkinTogItem.Refresh(motorSkin.Id);
				motorcycleDiySkinTogItem.SetEquippedStatus(flag2);
				motorcycleDiySkinTogItem.SetLockedStatus(!flag);
				motorcycleDiySkinTogItem.SetRedDotVisible(redDotVisible);
				if (isInit)
				{
					this.CurSkinId = equippedSkinId;
					EToggleState state = flag2 ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
					motorcycleDiySkinTogItem.SetToggleStateForce(state, false);
				}
			}
			num++;
		}
	}

	// Token: 0x06011659 RID: 71257 RVA: 0x00442BF4 File Offset: 0x00440DF4
	private void RefreshSkinTogItemsFromShop()
	{
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		if (this.AcquireJumpSkinId == this.CurSkinId && instance.HasSkin(this.CurSkinId))
		{
			instance.CheckRedDotForAnyItem(this.CurSkinId);
			this.AcquireJumpSkinId = 0;
		}
		this.RefreshSkinTogItems(false);
	}

	// Token: 0x0601165A RID: 71258 RVA: 0x00442C40 File Offset: 0x00440E40
	private void TryCloseWithRotationRollback()
	{
		if (this.IsClosingWithRotate)
		{
			return;
		}
		this.IsClosingWithRotate = true;
		MotorcycleUiModelUtil.Instance.SetAutoRotate(false);
		MotorcycleUiModelUtil.Instance.SetSoarWingEnabled(false);
		UiModelControlRotateComponent controlRotateComponent = this.ControlRotateComponent;
		if (controlRotateComponent != null)
		{
			controlRotateComponent.Deactivate();
		}
		this.ResetAutoRotateLocation();
		if (!this.StartCloseRotationRollback())
		{
			this.IsClosingWithRotate = false;
		}
		int equippedSkinId = MotorcycleDiyModel.Instance.GetEquippedSkinId();
		MotorcycleUiModelUtil.Instance.LoadMotorBySkinId(equippedSkinId, delegate(UiModelBase _)
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x0601165B RID: 71259 RVA: 0x00442CBB File Offset: 0x00440EBB
	private void OnCloseRotationRollbackDone()
	{
		this.ClearCloseRotationRollbackTimer();
		this.IsClosingWithRotate = false;
	}

	// Token: 0x0601165C RID: 71260 RVA: 0x00442CCC File Offset: 0x00440ECC
	private bool StartCloseRotationRollback()
	{
		AActor motorActor = this.GetMotorActor();
		if (motorActor == null || this.CloseRotationRollbackDuration <= 0f)
		{
			return false;
		}
		Rotator rollbackStartRotator = this.RollbackStartRotator;
		FRotator frotator = motorActor.K2_GetActorRotation();
		rollbackStartRotator.FromUeRotator(frotator);
		this.RollbackElapsed = 0f;
		this.ClearCloseRotationRollbackTimer();
		this.RollbackTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.UpdateCloseRotationRollback), 20f, 1f, null, "MotorcycleDiySkinView.CloseRotationRollback", true);
		return this.RollbackTimerHandle != null;
	}

	// Token: 0x0601165D RID: 71261 RVA: 0x00442D50 File Offset: 0x00440F50
	private void UpdateCloseRotationRollback(float delta)
	{
		AActor motorActor = this.GetMotorActor();
		if (motorActor == null)
		{
			this.OnCloseRotationRollbackDone();
			return;
		}
		this.RollbackElapsed += delta / 1000f;
		float num = MathUtils.Instance.Clamp(this.RollbackElapsed / this.CloseRotationRollbackDuration, 0f, 1f);
		Rotator.Lerp(this.RollbackStartRotator, this.InitialMotorRotator, this.EaseOutCubic(num), this.RollbackTempRotator);
		motorActor.K2_SetActorRotation(this.RollbackTempRotator.ToUeRotator(), false);
		if (num >= 1f)
		{
			this.OnCloseRotationRollbackDone();
		}
	}

	// Token: 0x0601165E RID: 71262 RVA: 0x00442DE4 File Offset: 0x00440FE4
	private void ClearCloseRotationRollbackTimer()
	{
		TimerHandle rollbackTimerHandle = this.RollbackTimerHandle;
		if (rollbackTimerHandle != null && TimerSystem.Instance.Has(rollbackTimerHandle))
		{
			TimerSystem.Instance.Remove(rollbackTimerHandle);
		}
		this.RollbackTimerHandle = null;
	}

	// Token: 0x0601165F RID: 71263 RVA: 0x00442E1C File Offset: 0x0044101C
	private float EaseOutCubic(float ratio)
	{
		float num = 1f - ratio;
		return 1f - num * num * num;
	}

	// Token: 0x06011660 RID: 71264 RVA: 0x00442E3C File Offset: 0x0044103C
	private void OnMotorModelDragBegin()
	{
		if (this.IsClosingWithRotate)
		{
			return;
		}
		MotorcycleUiModelUtil.Instance.SetAutoRotate(false);
		UiModelControlRotateComponent controlRotateComponent = this.ControlRotateComponent;
		if (controlRotateComponent == null)
		{
			return;
		}
		controlRotateComponent.ResumeFromCurrentActorRotation();
	}

	// Token: 0x06011661 RID: 71265 RVA: 0x00442E62 File Offset: 0x00441062
	private void OnMotorModelDragEnd()
	{
		if (this.IsClosingWithRotate)
		{
			return;
		}
		UiModelControlRotateComponent controlRotateComponent = this.ControlRotateComponent;
		if (controlRotateComponent != null)
		{
			controlRotateComponent.Deactivate();
		}
		MotorcycleUiModelUtil.Instance.SetAutoRotate(true);
	}

	// Token: 0x06011662 RID: 71266 RVA: 0x00442E89 File Offset: 0x00441089
	private void OnClickConfirm()
	{
		if (MotorcycleDiyModel.Instance.IsEquipFrameLockedByPlayer())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorSkin_Tips03", Array.Empty<object>());
			return;
		}
		MotorcycleDiyController.Instance.EquipMotorSkinRequest(this.CurSkinId, delegate
		{
			this.RefreshSkinTogItems(false);
			this.RefreshCurSkinInfo();
			MotorSkin? motorSkinConfig = MotorDiyConfig.Instance.GetMotorSkinConfig(this.CurSkinId);
			if (motorSkinConfig != null)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(motorSkinConfig.Value.Name, null);
				ScrollingTipsController.Instance.ShowTipsByTextId("MotorSkin_Tips01", new object[]
				{
					localTextNew
				});
			}
		});
	}

	// Token: 0x06011663 RID: 71267 RVA: 0x00442EC8 File Offset: 0x004410C8
	private bool OnExecuteChangeSkinToggle(int skinId)
	{
		return skinId != this.CurSkinId;
	}

	// Token: 0x06011664 RID: 71268 RVA: 0x00442ED6 File Offset: 0x004410D6
	private void OnClickObtain()
	{
		this.AcquireJumpSkinId = this.CurSkinId;
	}

	// Token: 0x06011665 RID: 71269 RVA: 0x00442EE4 File Offset: 0x004410E4
	private void OnTogNormalSkinClick(int skinId)
	{
		MotorcycleDiySkinTogItem buySkinTogItem = this.BuySkinTogItem;
		if (buySkinTogItem != null)
		{
			buySkinTogItem.SetToggleStateForce(EToggleState.ETT_UnChecked, false);
		}
		GenericLayout<MotorcycleDiySkinListItem, MotorcycleDiySkinListItemData> customizeLayout = this.CustomizeLayout;
		if (customizeLayout != null)
		{
			customizeLayout.RefreshByData(this.NormalCustomizeDataList, null, false);
		}
		this.CurSkinId = skinId;
		this.ResetAutoRotateLocation();
		MotorcycleUiModelUtil.Instance.LoadMotorBySkinId(skinId, delegate(UiModelBase _)
		{
			this.RefreshAutoRotateParam();
		});
		this.RefreshCurSkinInfo();
	}

	// Token: 0x06011666 RID: 71270 RVA: 0x00442F48 File Offset: 0x00441148
	private void OnTogBuySkinClick(int skinId)
	{
		MotorcycleDiySkinTogItem normalSkinTogItem = this.NormalSkinTogItem;
		if (normalSkinTogItem != null)
		{
			normalSkinTogItem.SetToggleStateForce(EToggleState.ETT_UnChecked, false);
		}
		GenericLayout<MotorcycleDiySkinListItem, MotorcycleDiySkinListItemData> customizeLayout = this.CustomizeLayout;
		if (customizeLayout != null)
		{
			customizeLayout.RefreshByData(this.BuyCustomizeDataList, null, false);
		}
		this.CurSkinId = skinId;
		this.ResetAutoRotateLocation();
		MotorcycleUiModelUtil.Instance.LoadMotorBySkinId(skinId, delegate(UiModelBase _)
		{
			this.RefreshAutoRotateParam();
		});
		this.RefreshCurSkinInfo();
		MotorcycleDiySkinTogItem buySkinTogItem = this.BuySkinTogItem;
		if (buySkinTogItem != null)
		{
			buySkinTogItem.SetRedDotVisible(false);
		}
		MotorcycleDiyModel.Instance.CheckRedDotForAnyItem(skinId);
	}

	// Token: 0x06011667 RID: 71271 RVA: 0x00442FC8 File Offset: 0x004411C8
	private void OnBtnBackClick()
	{
		this.TryCloseWithRotationRollback();
	}

	// Token: 0x04008426 RID: 33830
	[Nullable(2)]
	private MotorcycleDiySkinTogItem NormalSkinTogItem;

	// Token: 0x04008427 RID: 33831
	[Nullable(2)]
	private MotorcycleDiySkinTogItem BuySkinTogItem;

	// Token: 0x04008428 RID: 33832
	[Nullable(2)]
	private MotorcycleDiySkinObtainItem ObtainItem;

	// Token: 0x04008429 RID: 33833
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x0400842A RID: 33834
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiySkinListItem, MotorcycleDiySkinListItemData> CustomizeLayout;

	// Token: 0x0400842B RID: 33835
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400842C RID: 33836
	[Nullable(2)]
	private UiBehaviorModelInput ModelInputBehavior;

	// Token: 0x0400842D RID: 33837
	[Nullable(2)]
	protected UiModelControlRotateComponent ControlRotateComponent;

	// Token: 0x0400842E RID: 33838
	private int CurSkinId;

	// Token: 0x0400842F RID: 33839
	private int AcquireJumpSkinId;

	// Token: 0x04008430 RID: 33840
	private readonly List<MotorcycleDiySkinListItemData> NormalCustomizeDataList = new List<MotorcycleDiySkinListItemData>();

	// Token: 0x04008431 RID: 33841
	private readonly List<MotorcycleDiySkinListItemData> BuyCustomizeDataList = new List<MotorcycleDiySkinListItemData>();

	// Token: 0x04008432 RID: 33842
	private float CloseRotationRollbackDuration = 0.6f;

	// Token: 0x04008433 RID: 33843
	private float AutoRotateDuration = 10f;

	// Token: 0x04008434 RID: 33844
	private string AutoRotateCenterCase = "FreeCase";

	// Token: 0x04008435 RID: 33845
	private bool IsClosingWithRotate;

	// Token: 0x04008436 RID: 33846
	private readonly Rotator InitialMotorRotator = Rotator.Create();

	// Token: 0x04008437 RID: 33847
	private readonly Rotator RollbackStartRotator = Rotator.Create();

	// Token: 0x04008438 RID: 33848
	private readonly Rotator RollbackTempRotator = Rotator.Create();

	// Token: 0x04008439 RID: 33849
	private float RollbackElapsed;

	// Token: 0x0400843A RID: 33850
	[Nullable(2)]
	private TimerHandle RollbackTimerHandle;

	// Token: 0x0400843B RID: 33851
	private readonly global::Vector AutoRotateActorLocation = global::Vector.Create();

	// Token: 0x0400843C RID: 33852
	private readonly global::Vector AutoRotateMeshRelativeLocation = global::Vector.Create();

	// Token: 0x0400843D RID: 33853
	private readonly global::Vector AutoRotateCenterLocation = global::Vector.Create();

	// Token: 0x0400843E RID: 33854
	private readonly global::Vector AutoRotateMeshOffset = global::Vector.Create();

	// Token: 0x0400843F RID: 33855
	private readonly global::Vector MeshDefaultRelativeLocation = global::Vector.Create();

	// Token: 0x04008440 RID: 33856
	private bool HasAutoRotateLocationCache;

	// Token: 0x02008819 RID: 34841
	[NullableContext(0)]
	private class EMotorDiySkinComponent
	{
		// Token: 0x0402C3A0 RID: 181152
		public const int CaptionItem = 0;

		// Token: 0x0402C3A1 RID: 181153
		public const int DefaultSkinToggle = 1;

		// Token: 0x0402C3A2 RID: 181154
		public const int BuySkinToggle = 2;

		// Token: 0x0402C3A3 RID: 181155
		public const int TxtSkinName = 3;

		// Token: 0x0402C3A4 RID: 181156
		public const int TxtSkinDesc = 4;

		// Token: 0x0402C3A5 RID: 181157
		public const int CustomizeLayout = 5;

		// Token: 0x0402C3A6 RID: 181158
		public const int CustomizeItem = 6;

		// Token: 0x0402C3A7 RID: 181159
		public const int Deprecated = 7;

		// Token: 0x0402C3A8 RID: 181160
		public const int ObtainItem = 8;

		// Token: 0x0402C3A9 RID: 181161
		public const int BtnConfirm = 9;

		// Token: 0x0402C3AA RID: 181162
		public const int DragComponent = 10;

		// Token: 0x0402C3AB RID: 181163
		public const int ObtainParentItem = 11;

		// Token: 0x0402C3AC RID: 181164
		public const int TxtSkinTypeDescription = 12;

		// Token: 0x0402C3AD RID: 181165
		public const int BtnBack = 13;
	}
}
