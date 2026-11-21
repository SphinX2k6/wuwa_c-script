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

// Token: 0x02001792 RID: 6034
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiySkinView : UiViewBase
{
	// Token: 0x0600EADE RID: 60126 RVA: 0x0044EEE0 File Offset: 0x0044D0E0
	public MotorcycleDiySkinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EADF RID: 60127 RVA: 0x0044EF83 File Offset: 0x0044D183
	protected override void OnBeforeCreate()
	{
		this.ModelInputBehavior = new UiBehaviorModelInput();
		base.AddUiBehavior(this.ModelInputBehavior);
	}

	// Token: 0x0600EAE0 RID: 60128 RVA: 0x0044EF9C File Offset: 0x0044D19C
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

	// Token: 0x0600EAE1 RID: 60129 RVA: 0x0044F0FC File Offset: 0x0044D2FC
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiySkinView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiySkinView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EAE2 RID: 60130 RVA: 0x0044F13F File Offset: 0x0044D33F
	protected override void OnHandleLoadScene()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
	}

	// Token: 0x0600EAE3 RID: 60131 RVA: 0x0044F14D File Offset: 0x0044D34D
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

	// Token: 0x0600EAE4 RID: 60132 RVA: 0x0044F190 File Offset: 0x0044D390
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

	// Token: 0x0600EAE5 RID: 60133 RVA: 0x0044F1E4 File Offset: 0x0044D3E4
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

	// Token: 0x0600EAE6 RID: 60134 RVA: 0x0044F237 File Offset: 0x0044D437
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

	// Token: 0x0600EAE7 RID: 60135 RVA: 0x0044F270 File Offset: 0x0044D470
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

	// Token: 0x0600EAE8 RID: 60136 RVA: 0x0044F29C File Offset: 0x0044D49C
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

	// Token: 0x0600EAE9 RID: 60137 RVA: 0x0044F2C0 File Offset: 0x0044D4C0
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

	// Token: 0x0600EAEA RID: 60138 RVA: 0x0044F39D File Offset: 0x0044D59D
	private void RefreshAutoRotateParam()
	{
		this.SetAutoRotateCenterCase(this.AutoRotateCenterCase);
		MotorcycleUiModelUtil.Instance.InitAutoRotateParam(this.AutoRotateDuration, ERotateAxis.Yaw, true);
	}

	// Token: 0x0600EAEB RID: 60139 RVA: 0x0044F3C0 File Offset: 0x0044D5C0
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

	// Token: 0x0600EAEC RID: 60140 RVA: 0x0044F4D8 File Offset: 0x0044D6D8
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

	// Token: 0x0600EAED RID: 60141 RVA: 0x0044F55E File Offset: 0x0044D75E
	private MotorcycleDiySkinListItem InitListItem()
	{
		return new MotorcycleDiySkinListItem();
	}

	// Token: 0x0600EAEE RID: 60142 RVA: 0x0044F568 File Offset: 0x0044D768
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

	// Token: 0x0600EAEF RID: 60143 RVA: 0x0044F5BC File Offset: 0x0044D7BC
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

	// Token: 0x0600EAF0 RID: 60144 RVA: 0x0044F6FC File Offset: 0x0044D8FC
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

	// Token: 0x0600EAF1 RID: 60145 RVA: 0x0044F7E4 File Offset: 0x0044D9E4
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

	// Token: 0x0600EAF2 RID: 60146 RVA: 0x0044F830 File Offset: 0x0044DA30
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

	// Token: 0x0600EAF3 RID: 60147 RVA: 0x0044F8AB File Offset: 0x0044DAAB
	private void OnCloseRotationRollbackDone()
	{
		this.ClearCloseRotationRollbackTimer();
		this.IsClosingWithRotate = false;
	}

	// Token: 0x0600EAF4 RID: 60148 RVA: 0x0044F8BC File Offset: 0x0044DABC
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

	// Token: 0x0600EAF5 RID: 60149 RVA: 0x0044F940 File Offset: 0x0044DB40
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

	// Token: 0x0600EAF6 RID: 60150 RVA: 0x0044F9D4 File Offset: 0x0044DBD4
	private void ClearCloseRotationRollbackTimer()
	{
		TimerHandle rollbackTimerHandle = this.RollbackTimerHandle;
		if (rollbackTimerHandle != null && TimerSystem.Instance.Has(rollbackTimerHandle))
		{
			TimerSystem.Instance.Remove(rollbackTimerHandle);
		}
		this.RollbackTimerHandle = null;
	}

	// Token: 0x0600EAF7 RID: 60151 RVA: 0x0044FA0C File Offset: 0x0044DC0C
	private float EaseOutCubic(float ratio)
	{
		float num = 1f - ratio;
		return 1f - num * num * num;
	}

	// Token: 0x0600EAF8 RID: 60152 RVA: 0x0044FA2C File Offset: 0x0044DC2C
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

	// Token: 0x0600EAF9 RID: 60153 RVA: 0x0044FA52 File Offset: 0x0044DC52
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

	// Token: 0x0600EAFA RID: 60154 RVA: 0x0044FA79 File Offset: 0x0044DC79
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

	// Token: 0x0600EAFB RID: 60155 RVA: 0x0044FAB8 File Offset: 0x0044DCB8
	private bool OnExecuteChangeSkinToggle(int skinId)
	{
		return skinId != this.CurSkinId;
	}

	// Token: 0x0600EAFC RID: 60156 RVA: 0x0044FAC6 File Offset: 0x0044DCC6
	private void OnClickObtain()
	{
		this.AcquireJumpSkinId = this.CurSkinId;
	}

	// Token: 0x0600EAFD RID: 60157 RVA: 0x0044FAD4 File Offset: 0x0044DCD4
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

	// Token: 0x0600EAFE RID: 60158 RVA: 0x0044FB38 File Offset: 0x0044DD38
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

	// Token: 0x0600EAFF RID: 60159 RVA: 0x0044FBB8 File Offset: 0x0044DDB8
	private void OnBtnBackClick()
	{
		this.TryCloseWithRotationRollback();
	}

	// Token: 0x04008564 RID: 34148
	[Nullable(2)]
	private MotorcycleDiySkinTogItem NormalSkinTogItem;

	// Token: 0x04008565 RID: 34149
	[Nullable(2)]
	private MotorcycleDiySkinTogItem BuySkinTogItem;

	// Token: 0x04008566 RID: 34150
	[Nullable(2)]
	private MotorcycleDiySkinObtainItem ObtainItem;

	// Token: 0x04008567 RID: 34151
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04008568 RID: 34152
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiySkinListItem, MotorcycleDiySkinListItemData> CustomizeLayout;

	// Token: 0x04008569 RID: 34153
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400856A RID: 34154
	[Nullable(2)]
	private UiBehaviorModelInput ModelInputBehavior;

	// Token: 0x0400856B RID: 34155
	[Nullable(2)]
	protected UiModelControlRotateComponent ControlRotateComponent;

	// Token: 0x0400856C RID: 34156
	private int CurSkinId;

	// Token: 0x0400856D RID: 34157
	private int AcquireJumpSkinId;

	// Token: 0x0400856E RID: 34158
	private readonly List<MotorcycleDiySkinListItemData> NormalCustomizeDataList = new List<MotorcycleDiySkinListItemData>();

	// Token: 0x0400856F RID: 34159
	private readonly List<MotorcycleDiySkinListItemData> BuyCustomizeDataList = new List<MotorcycleDiySkinListItemData>();

	// Token: 0x04008570 RID: 34160
	private float CloseRotationRollbackDuration = 0.6f;

	// Token: 0x04008571 RID: 34161
	private float AutoRotateDuration = 10f;

	// Token: 0x04008572 RID: 34162
	private string AutoRotateCenterCase = "FreeCase";

	// Token: 0x04008573 RID: 34163
	private bool IsClosingWithRotate;

	// Token: 0x04008574 RID: 34164
	private readonly Rotator InitialMotorRotator = Rotator.Create();

	// Token: 0x04008575 RID: 34165
	private readonly Rotator RollbackStartRotator = Rotator.Create();

	// Token: 0x04008576 RID: 34166
	private readonly Rotator RollbackTempRotator = Rotator.Create();

	// Token: 0x04008577 RID: 34167
	private float RollbackElapsed;

	// Token: 0x04008578 RID: 34168
	[Nullable(2)]
	private TimerHandle RollbackTimerHandle;

	// Token: 0x04008579 RID: 34169
	private readonly global::Vector AutoRotateActorLocation = global::Vector.Create();

	// Token: 0x0400857A RID: 34170
	private readonly global::Vector AutoRotateMeshRelativeLocation = global::Vector.Create();

	// Token: 0x0400857B RID: 34171
	private readonly global::Vector AutoRotateCenterLocation = global::Vector.Create();

	// Token: 0x0400857C RID: 34172
	private readonly global::Vector AutoRotateMeshOffset = global::Vector.Create();

	// Token: 0x0400857D RID: 34173
	private readonly global::Vector MeshDefaultRelativeLocation = global::Vector.Create();

	// Token: 0x0400857E RID: 34174
	private bool HasAutoRotateLocationCache;

	// Token: 0x0200799E RID: 31134
	[NullableContext(0)]
	private class EMotorDiySkinComponent
	{
		// Token: 0x040276A7 RID: 161447
		public const int CaptionItem = 0;

		// Token: 0x040276A8 RID: 161448
		public const int DefaultSkinToggle = 1;

		// Token: 0x040276A9 RID: 161449
		public const int BuySkinToggle = 2;

		// Token: 0x040276AA RID: 161450
		public const int TxtSkinName = 3;

		// Token: 0x040276AB RID: 161451
		public const int TxtSkinDesc = 4;

		// Token: 0x040276AC RID: 161452
		public const int CustomizeLayout = 5;

		// Token: 0x040276AD RID: 161453
		public const int CustomizeItem = 6;

		// Token: 0x040276AE RID: 161454
		public const int Deprecated = 7;

		// Token: 0x040276AF RID: 161455
		public const int ObtainItem = 8;

		// Token: 0x040276B0 RID: 161456
		public const int BtnConfirm = 9;

		// Token: 0x040276B1 RID: 161457
		public const int DragComponent = 10;

		// Token: 0x040276B2 RID: 161458
		public const int ObtainParentItem = 11;

		// Token: 0x040276B3 RID: 161459
		public const int TxtSkinTypeDescription = 12;

		// Token: 0x040276B4 RID: 161460
		public const int BtnBack = 13;
	}
}
