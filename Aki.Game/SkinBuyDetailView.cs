using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FAA RID: 8106
[NullableContext(2)]
[Nullable(0)]
public class SkinBuyDetailView : UiTickViewBase
{
	// Token: 0x06014189 RID: 82313 RVA: 0x005DC1BD File Offset: 0x005DA3BD
	[NullableContext(1)]
	public SkinBuyDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601418A RID: 82314 RVA: 0x005DC1C8 File Offset: 0x005DA3C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUITexture)),
			new ValueTuple<int, Type>(24, typeof(UUITexture)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUITexture)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(30, typeof(UUITexture)),
			new ValueTuple<int, Type>(31, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(32, typeof(UUIItem)),
			new ValueTuple<int, Type>(33, typeof(UUIItem)),
			new ValueTuple<int, Type>(34, typeof(UUITexture)),
			new ValueTuple<int, Type>(35, typeof(UUIText)),
			new ValueTuple<int, Type>(36, typeof(UUITexture)),
			new ValueTuple<int, Type>(37, typeof(UUIText)),
			new ValueTuple<int, Type>(38, typeof(UUIItem)),
			new ValueTuple<int, Type>(39, typeof(UUIItem)),
			new ValueTuple<int, Type>(40, typeof(UUIText)),
			new ValueTuple<int, Type>(41, typeof(UUITexture)),
			new ValueTuple<int, Type>(42, typeof(UUIText)),
			new ValueTuple<int, Type>(43, typeof(UUITexture)),
			new ValueTuple<int, Type>(44, typeof(UUIText)),
			new ValueTuple<int, Type>(45, typeof(UUIItem)),
			new ValueTuple<int, Type>(46, typeof(UUIItem)),
			new ValueTuple<int, Type>(47, typeof(UUIItem)),
			new ValueTuple<int, Type>(48, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(49, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(50, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickDetailIconButton)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeftButton)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRightButton)),
			new ValueTuple<int, Delegate>(17, new Action(this.OnClickBuyButton)),
			new ValueTuple<int, Delegate>(8, new Action<EToggleState>(this.OnClickToggleLeft)),
			new ValueTuple<int, Delegate>(31, new Action<EToggleState>(this.OnClickToggleRight)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickOnlyUiToggle)),
			new ValueTuple<int, Delegate>(48, new Action<EToggleState>(this.OnClickToggleMale)),
			new ValueTuple<int, Delegate>(49, new Action<EToggleState>(this.OnClickToggleFemale))
		};
	}

	// Token: 0x0601418B RID: 82315 RVA: 0x005DC754 File Offset: 0x005DA954
	protected override void OnAddEventListener()
	{
		UUIDraggableComponent draggable = base.GetDraggable(29);
		draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
		draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
		EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
		EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
		EventSystem.Instance.Add<string, float>(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnInputUiZoom));
		EventSystem.Instance.Add(EEventName.NavigationTriggerRoleReset, new Action(this.OnRightStickPress));
		InputDistributeController.Instance.BindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		EventSystem.Instance.Add<UiCameraHandleData, UiCameraHandleData, string>(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0601418C RID: 82316 RVA: 0x005DC8C4 File Offset: 0x005DAAC4
	protected void RemoveCameraEventListener()
	{
		UUIDraggableComponent draggable = base.GetDraggable(29);
		draggable.OnPointerBeginDragCallBack.Unbind();
		draggable.OnPointerDragCallBack.Unbind();
		draggable.OnPointerEndDragCallBack.Unbind();
		draggable.OnPointerScrollCallBack.Unbind();
		EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
		EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
		EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnInputUiZoom));
		EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleReset, new Action(this.OnRightStickPress));
		InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
		{
			0,
			1
		}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0601418D RID: 82317 RVA: 0x005DCA09 File Offset: 0x005DAC09
	[NullableContext(1)]
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x0601418E RID: 82318 RVA: 0x005DCA14 File Offset: 0x005DAC14
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		ShopSkinData currentGoodsData = this.ViewData.GetCurrentGoodsData();
		int? num = (currentGoodsData != null) ? new int?(currentGoodsData.GetCurrentGoodsData().GetGoodsId()) : null;
		if (!(goodsId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.RefreshView();
	}

	// Token: 0x0601418F RID: 82319 RVA: 0x005DCA66 File Offset: 0x005DAC66
	protected override void OnHandleLoadScene()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		object obj;
		if (tsUiSceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetTransformByTag("RoleCase");
	}

	// Token: 0x06014190 RID: 82320 RVA: 0x005DCA95 File Offset: 0x005DAC95
	[NullableContext(1)]
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.TouchMoved();
		}
	}

	// Token: 0x06014191 RID: 82321 RVA: 0x005DCAA8 File Offset: 0x005DACA8
	private void TouchMoved()
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
			this.UiCameraInputComponent.AddZoomInput(-fingerExpandCloseValue);
		}
	}

	// Token: 0x06014192 RID: 82322 RVA: 0x005DCADC File Offset: 0x005DACDC
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x06014193 RID: 82323 RVA: 0x005DCAF0 File Offset: 0x005DACF0
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1 || InputSettings.Instance.IsInputKeyDown("RightMouseButton"))
		{
			this.CurrentDragPosition = null;
			return;
		}
		FVector? currentDragPosition = this.CurrentDragPosition;
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		if (currentDragPosition == null)
		{
			return;
		}
		float num = this.CurrentDragPosition.Value.X - currentDragPosition.Value.X;
		float num2 = this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y;
		if (num != 0f)
		{
			this.UiCameraInputComponent.AddYawInput(num);
		}
		if (num2 != 0f)
		{
			this.UiCameraInputComponent.AddPitchInput(num2);
		}
	}

	// Token: 0x06014194 RID: 82324 RVA: 0x005DCBAE File Offset: 0x005DADAE
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = null;
	}

	// Token: 0x06014195 RID: 82325 RVA: 0x005DCBBC File Offset: 0x005DADBC
	private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
	{
		if (eventData.scrollAxisValue != 0f)
		{
			this.UiCameraInputComponent.AddZoomInput(-eventData.scrollAxisValue);
		}
	}

	// Token: 0x06014196 RID: 82326 RVA: 0x005DCBE0 File Offset: 0x005DADE0
	protected override void OnBeforeShow()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		UiModelBase uiModelBase = (tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null;
		if (uiModelBase != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, true);
		}
		string stringConfig = ConfigCommonParamById.GetStringConfig("ShopPreviewCharacterSkinIcon");
		string stringConfig2 = ConfigCommonParamById.GetStringConfig("ShopPreviewCharacterSkinPackIcon");
		base.SetTextureByPath(stringConfig, base.GetTexture(34), null, null);
		base.SetTextureByPath(stringConfig2, base.GetTexture(36), null, null);
		string stringConfig3 = ConfigCommonParamById.GetStringConfig("ShopPreviewCharacterSkinText");
		string stringConfig4 = ConfigCommonParamById.GetStringConfig("ShopPreviewCharacterSkinPackText");
		LguiUtil.Instance.SetLocalTextNew(base.GetText(35), stringConfig3, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(37), stringConfig4, Array.Empty<object>());
		UUIItem item = base.GetItem(45);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(46);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		this.RefreshView();
	}

	// Token: 0x06014197 RID: 82327 RVA: 0x005DCCD0 File Offset: 0x005DAED0
	protected override void OnAfterShow()
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x06014198 RID: 82328 RVA: 0x005DCCD8 File Offset: 0x005DAED8
	protected override void OnAfterHide()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		UiModelBase uiModelBase = (tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null;
		if (uiModelBase != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
		}
	}

	// Token: 0x06014199 RID: 82329 RVA: 0x005DCD08 File Offset: 0x005DAF08
	private void RefreshCameraRotationComponentByViewType()
	{
		if (UiCameraModel.Instance.IsPlayingAnimation())
		{
			return;
		}
		string configId = (this.CurrentSkinTypeIndex == 0) ? PayShopConfig.Instance.GetBuySkinDetailRoleCameraConfigId() : PayShopConfig.Instance.GetBuySkinDetailWeaponCameraConfigId();
		this.RefreshCameraRotationComponent(configId);
	}

	// Token: 0x0601419A RID: 82330 RVA: 0x005DCD48 File Offset: 0x005DAF48
	[NullableContext(1)]
	private void RefreshCameraRotationComponent(string configId)
	{
		UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
		this.UiCameraInputComponent = orCreateCamera.GetUiCameraComponent<UiCameraInputComponent>();
		this.UiCameraLogicComponent = orCreateCamera.GetUiCameraComponent<UiCameraLogicComponent>();
		int itemId = this.ViewData.GetCurrentSkinData().GetItemId();
		SUiRoleCameraSetting? roleCameraConfigBySkin = UiRoleCameraConfig.Instance.GetRoleCameraConfigBySkin(configId, itemId);
		if (roleCameraConfigBySkin == null)
		{
			return;
		}
		this.UiCameraLogicComponent.InitDataByConfig(roleCameraConfigBySkin.Value);
		this.UiCameraLogicComponent.SetNeedFloorReflection(true);
		FVectorDouble sourceLocation = this.TsUiSceneRoleActor.D_K2_GetActorLocation();
		int roleId = this.ViewData.GetCurrentSkinData().GetRoleId();
		if (roleId == 0)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return;
		}
		string roleBody = roleConfig.Value.RoleBody;
		SUiRoleCameraOffsetSetting? roleCameraOffsetConfig = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(roleBody);
		if (roleCameraOffsetConfig == null)
		{
			return;
		}
		this.UiCameraLogicComponent.UpdateData(sourceLocation, roleCameraOffsetConfig.Value.镜头浮动最大高度, roleCameraOffsetConfig.Value.镜头浮动最低高度, roleCameraOffsetConfig.Value.镜头浮动最长臂长, roleCameraOffsetConfig.Value.镜头浮动最短臂长);
		this.UiCameraInputComponent.Activate();
		this.UiCameraInputComponent.ResumeTick();
	}

	// Token: 0x0601419B RID: 82331 RVA: 0x005DCE75 File Offset: 0x005DB075
	private void OnInputUiLookUp(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddPitchInput(-value);
	}

	// Token: 0x0601419C RID: 82332 RVA: 0x005DCE99 File Offset: 0x005DB099
	private void OnInputUiTurn(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddYawInput(value);
	}

	// Token: 0x0601419D RID: 82333 RVA: 0x005DCEBC File Offset: 0x005DB0BC
	[NullableContext(1)]
	private void OnInputUiZoom(string axisName, float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddZoomInput(value);
	}

	// Token: 0x0601419E RID: 82334 RVA: 0x005DCEE0 File Offset: 0x005DB0E0
	private void OnRightStickPress()
	{
		UiCameraModel instance = UiCameraModel.Instance;
		UiCamera camera = instance.Camera;
		UiCameraHandleData lastHandleData = instance.GetLastHandleData();
		if (camera == null || !camera.IsEntered || camera.CurrentMode != EUiCameraMode.Normal || lastHandleData == null || lastHandleData.ShouldSkipApply())
		{
			return;
		}
		UiCameraNormalMode mode = camera.GetMode<UiCameraNormalMode>();
		if (mode.State != EUiCameraNormalState.Active || mode.IsInputBlocked || mode.TryGetLastAppliedData() != lastHandleData)
		{
			return;
		}
		if (camera.RefreshCameraActor())
		{
			UCineCameraComponent cineCameraComponent = camera.CineCameraComponent;
			if (cineCameraComponent != null && cineCameraComponent.IsValid())
			{
				if (!lastHandleData.Refresh(instance) || lastHandleData.GetUiCameraAnimationConfig() == null)
				{
					return;
				}
				if (!mode.PushCameraHandle(lastHandleData, lastHandleData, true, false, "1001", null))
				{
					Log.Instance.Warn(ELogModule.UiCamera, ELogAuthor.BB, "手柄重置皮肤预览Ui镜头失败，当前镜头不可重置", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
		}
	}

	// Token: 0x0601419F RID: 82335 RVA: 0x005DCFAC File Offset: 0x005DB1AC
	protected override void OnStart()
	{
		this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInSkinView);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.CloseView));
		this.ViewData = (this.OpenParam as SkinBuyDetailViewData);
		this.CaptionItem.SetTitleLocalText(this.ViewData.GetPreviewTitle());
		this.CaptionItem.SetTitleIconByResourceId("RoleSkinShopTitle_Icon");
		this.CaptionItem.SetHelpBtnActive(true);
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
		this.ItemLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(10), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		base.GetExtendToggle(8).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		base.GetExtendToggle(31).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		this.ResetCurrentSkinTypeIndex();
	}

	// Token: 0x060141A0 RID: 82336 RVA: 0x005DD0B2 File Offset: 0x005DB2B2
	private bool CanToggleExecuteChange()
	{
		return TimeUtil.Instance.GetServerTimeStamp() - this.LastSwitchTime >= (double)SkinConfig.Instance.GetSkinDetailButtonSwitchGap();
	}

	// Token: 0x060141A1 RID: 82337 RVA: 0x005DD0D5 File Offset: 0x005DB2D5
	[NullableContext(1)]
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x060141A2 RID: 82338 RVA: 0x005DD0DC File Offset: 0x005DB2DC
	protected override void OnBeforeHide()
	{
		this.RemoveCameraEventListener();
		this.UiCameraInputComponent.PauseTick();
	}

	// Token: 0x060141A3 RID: 82339 RVA: 0x005DD0EF File Offset: 0x005DB2EF
	protected override void OnBeforeDestroy()
	{
		UiCameraModel.Instance.GetOrCreateCamera();
		UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
		if (uiCameraInputComponent != null)
		{
			uiCameraInputComponent.Deactivate();
		}
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x060141A4 RID: 82340 RVA: 0x005DD128 File Offset: 0x005DB328
	private void RefreshRolePerformance()
	{
		int roleId = this.ViewData.GetCurrentSkinData().GetRoleId();
		if (roleId == 0)
		{
			return;
		}
		RoleController.Instance.RefreshUiSceneRoleActorByConfigId(roleId, this.ViewData.GetCurrentSkinData().GetItemId(), new Action(this.RefreshWeaponMesh));
		EventSystem.Instance.Emit(EEventName.OnSelectedRoleChanged);
	}

	// Token: 0x060141A5 RID: 82341 RVA: 0x005DD184 File Offset: 0x005DB384
	private void RefreshMontageByCurrentSkinType()
	{
		EPerformanceRoleState roleState = (this.CurrentSkinTypeIndex == 0) ? EPerformanceRoleState.Attribute_Perform : EPerformanceRoleState.Weapon;
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		object obj;
		if (tsUiSceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiRoleStateMachineComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetState(roleState, false, false, false);
	}

	// Token: 0x060141A6 RID: 82342 RVA: 0x005DD1CC File Offset: 0x005DB3CC
	private void RefreshWeaponMesh()
	{
		SkinBuyDetailView.<>c__DisplayClass42_0 CS$<>8__locals1 = new SkinBuyDetailView.<>c__DisplayClass42_0();
		SkinBuyDetailViewData viewData = this.ViewData;
		WeaponSkin? weaponSkin = (viewData != null) ? viewData.GetCurrentSkinData().GetSuitWeaponSkinConfig() : null;
		if (weaponSkin == null)
		{
			return;
		}
		SkinBuyDetailView.<>c__DisplayClass42_0 CS$<>8__locals2 = CS$<>8__locals1;
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		UiRoleWeaponComponent component;
		if (tsUiSceneRoleActor == null)
		{
			component = null;
		}
		else
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			component = ((model != null) ? model.CheckGetComponent<UiRoleWeaponComponent>() : null);
		}
		CS$<>8__locals2.component = component;
		if (CS$<>8__locals1.component == null)
		{
			return;
		}
		CS$<>8__locals1.component.ReplaceWeaponModel(weaponSkin.Value.Models(), delegate
		{
			UiRoleWeaponComponent component2 = CS$<>8__locals1.component;
			if (component2 != null)
			{
				component2.RefreshWeaponCase();
			}
			UiRoleWeaponComponent component3 = CS$<>8__locals1.component;
			if (component3 == null)
			{
				return;
			}
			component3.AttachWeaponToRole();
		});
	}

	// Token: 0x060141A7 RID: 82343 RVA: 0x005DD25C File Offset: 0x005DB45C
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060141A8 RID: 82344 RVA: 0x005DD265 File Offset: 0x005DB465
	protected override void OnHandleReleaseScene()
	{
		this.HandleReleaseScene();
	}

	// Token: 0x060141A9 RID: 82345 RVA: 0x005DD26D File Offset: 0x005DB46D
	private void HandleReleaseScene()
	{
	}

	// Token: 0x060141AA RID: 82346 RVA: 0x005DD270 File Offset: 0x005DB470
	private void OnClickToggleRight(EToggleState toggleState)
	{
		this.CurrentSkinTypeIndex = 1;
		this.RefreshMontageByCurrentSkinType();
		this.RefreshCameraBySkinType();
		this.LastSwitchTime = 0.0;
		base.GetExtendToggle(8).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.LastSwitchTime = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x060141AB RID: 82347 RVA: 0x005DD2C0 File Offset: 0x005DB4C0
	private void OnClickToggleLeft(EToggleState toggleState)
	{
		this.CurrentSkinTypeIndex = 0;
		this.RefreshMontageByCurrentSkinType();
		this.RefreshCameraBySkinType();
		this.LastSwitchTime = 0.0;
		base.GetExtendToggle(31).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.LastSwitchTime = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x060141AC RID: 82348 RVA: 0x005DD311 File Offset: 0x005DB511
	[NullableContext(1)]
	private void OnPlayCameraAnimationStart(UiCameraHandleData uiCameraHandleData, UiCameraHandleData cameraHandleData, string arg3)
	{
		UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
		if (uiCameraInputComponent == null)
		{
			return;
		}
		uiCameraInputComponent.PauseTick();
	}

	// Token: 0x060141AD RID: 82349 RVA: 0x005DD323 File Offset: 0x005DB523
	[NullableContext(1)]
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x060141AE RID: 82350 RVA: 0x005DD32C File Offset: 0x005DB52C
	private void RefreshCameraBySkinType()
	{
		if (this.CurrentSkinTypeIndex == 0)
		{
			UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", true);
			UiCameraHandleData lastHandleData = UiCameraModel.Instance.GetLastHandleData();
			if (lastHandleData != null)
			{
				UiCameraModel.Instance.PushCameraHandleByHandleName(lastHandleData.GetHandleName(), true, true, "1001", true, delegate(UiCameraDefine.IFinishData _)
				{
					UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", false);
				});
				return;
			}
		}
		else
		{
			UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", true);
			UiCameraHandleData lastHandleData2 = UiCameraModel.Instance.GetLastHandleData();
			if (lastHandleData2 != null)
			{
				UiCameraModel.Instance.PushCameraHandleByHandleName(lastHandleData2.GetHandleName(), true, true, "1001", true, delegate(UiCameraDefine.IFinishData _)
				{
					UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", false);
				});
			}
		}
	}

	// Token: 0x060141AF RID: 82351 RVA: 0x005DD3F1 File Offset: 0x005DB5F1
	private void OnClickToggleMale(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.ViewData != null)
		{
			this.ViewData.SwitchToNextSkinData();
			this.ResetCurrentSkinTypeIndex();
			this.RefreshView();
			this.RefreshCameraBySkinType();
		}
		base.PlaySequence("Switch", null, true);
	}

	// Token: 0x060141B0 RID: 82352 RVA: 0x005DD42A File Offset: 0x005DB62A
	private void OnClickToggleFemale(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.ViewData != null)
		{
			this.ViewData.SwitchToNextSkinData();
			this.ResetCurrentSkinTypeIndex();
			this.RefreshView();
			this.RefreshCameraBySkinType();
		}
		base.PlaySequence("Switch", null, true);
	}

	// Token: 0x060141B1 RID: 82353 RVA: 0x005DD464 File Offset: 0x005DB664
	private void OnClickOnlyUiToggle(EToggleState toggleState)
	{
		bool state = base.GetItem(28).bIsUIActive;
		if (!state)
		{
			base.GetItem(28).SetUIActive(!state);
			base.GetButton(2).RootUIComp.Get().SetUIActive(!state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
			return;
		}
		base.PlaySequence("UiOut", delegate
		{
			this.GetItem(28).SetUIActive(!state);
			this.GetButton(2).RootUIComp.Get().SetUIActive(!state);
		}, true);
	}

	// Token: 0x060141B2 RID: 82354 RVA: 0x005DD518 File Offset: 0x005DB718
	private void OnClickBuyButton()
	{
		if (!this.ViewData.GetCurrentSkinData().GetIfHaveRole())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.NoRoleBuySkin);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.StartBuyProcess);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.StartBuyProcess();
	}

	// Token: 0x060141B3 RID: 82355 RVA: 0x005DD56D File Offset: 0x005DB76D
	private void StartBuyProcess()
	{
		PayShopController.Instance.OpenBuySkinDetailView(this.ViewData.GetCurrentGoodsData().GetCurrentGoodsData());
	}

	// Token: 0x060141B4 RID: 82356 RVA: 0x005DD58C File Offset: 0x005DB78C
	private void OnClickRightButton()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() - this.LastClickButtonTime < (double)SkinConfig.Instance.GetSkinDetailButtonGap())
		{
			return;
		}
		this.LastClickButtonTime = TimeUtil.Instance.GetServerTimeStamp();
		if (this.ViewData != null)
		{
			this.ViewData.SwitchToNextGoods();
			this.ResetCurrentSkinTypeIndex();
			this.RefreshView();
			this.RefreshCameraBySkinType();
		}
		base.PlaySequence("Switch", null, true);
	}

	// Token: 0x060141B5 RID: 82357 RVA: 0x005DD5FC File Offset: 0x005DB7FC
	private void OnClickLeftButton()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() - this.LastClickButtonTime < (double)SkinConfig.Instance.GetSkinDetailButtonGap())
		{
			return;
		}
		this.LastClickButtonTime = TimeUtil.Instance.GetServerTimeStamp();
		if (this.ViewData != null)
		{
			this.ViewData.SwitchToPreGoods();
			this.ResetCurrentSkinTypeIndex();
			this.RefreshView();
			this.RefreshCameraBySkinType();
		}
		base.PlaySequence("Switch", null, true);
	}

	// Token: 0x060141B6 RID: 82358 RVA: 0x005DD66A File Offset: 0x005DB86A
	private void ResetCurrentSkinTypeIndex()
	{
		this.CurrentSkinTypeIndex = 0;
	}

	// Token: 0x060141B7 RID: 82359 RVA: 0x005DD673 File Offset: 0x005DB873
	private void OnClickDetailIconButton()
	{
		SkinController.Instance.OpenSkinShowView(this.ViewData.GetCurrentSkinData().GetItemId());
	}

	// Token: 0x060141B8 RID: 82360 RVA: 0x005DD690 File Offset: 0x005DB890
	private void RefreshView()
	{
		SkinBuyDetailViewData viewData = this.ViewData;
		if (viewData != null)
		{
			ShopSkinData currentGoodsData = viewData.GetCurrentGoodsData();
			if (currentGoodsData != null)
			{
				currentGoodsData.GetCurrentGoodsData().SaveRemindState((long)TimeUtil.Instance.GetServerTime());
			}
		}
		this.RefreshLeftButton(this.ViewData);
		this.RefreshRightButton(this.ViewData);
		this.RefreshSexPanel(this.ViewData);
		this.RefreshTitleText(this.ViewData);
		this.RefreshSubTitleText(this.ViewData);
		this.RefreshDescText(this.ViewData);
		this.RefreshSwitchItem(this.ViewData);
		this.RefreshRoleTexture(this.ViewData);
		this.RefreshWeaponTexture(this.ViewData);
		this.RefreshWeaponQualityTexture(this.ViewData);
		this.RefreshRoleQualityTexture(this.ViewData);
		this.RefreshDiscountText(this.ViewData);
		this.RefreshDiscountTime(this.ViewData);
		this.RefreshBuyItemIcon(this.ViewData);
		this.RefreshNowPriceText(this.ViewData);
		this.RefreshSourcePriceText(this.ViewData);
		this.RefreshPriceTextShowState(this.ViewData);
		this.RefreshBuyButtonState(this.ViewData);
		this.RefreshHaveItem(this.ViewData);
		this.RefreshNotHaveRoleItem(this.ViewData);
		this.RefreshExtraReward(this.ViewData);
		this.RefreshSwitchToggleByIndex();
		this.RefreshMontageByCurrentSkinType();
		this.RefreshRolePerformance();
		this.RefreshExtraRewardItem(this.ViewData);
		this.RefreshEffectItem(this.ViewData);
		this.RefreshCouponPrice(this.ViewData);
	}

	// Token: 0x060141B9 RID: 82361 RVA: 0x005DD7FC File Offset: 0x005DB9FC
	private void RefreshSwitchToggleByIndex()
	{
		base.GetExtendToggle(8).SetToggleState((this.CurrentSkinTypeIndex == 0) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		base.GetExtendToggle(31).SetToggleState((this.CurrentSkinTypeIndex == 1) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshMontageByCurrentSkinType();
	}

	// Token: 0x060141BA RID: 82362 RVA: 0x005DD84C File Offset: 0x005DBA4C
	private void RefreshDescText(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			base.GetText(12).SetText("", true);
			return;
		}
		string desc = data.GetCurrentSkinData().GetDesc();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), desc, Array.Empty<object>());
	}

	// Token: 0x060141BB RID: 82363 RVA: 0x005DD894 File Offset: 0x005DBA94
	private void RefreshTitleText(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			base.GetText(5).SetText("", true);
			return;
		}
		string titleName = data.GetCurrentSkinData().GetTitleName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), titleName, Array.Empty<object>());
	}

	// Token: 0x060141BC RID: 82364 RVA: 0x005DD8DC File Offset: 0x005DBADC
	private void RefreshSubTitleText(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			base.GetText(6).SetText("", true);
			return;
		}
		string subTitle = data.GetCurrentSkinData().GetSubTitle();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), subTitle, Array.Empty<object>());
	}

	// Token: 0x060141BD RID: 82365 RVA: 0x005DD924 File Offset: 0x005DBB24
	private void RefreshRightButton(SkinBuyDetailViewData data)
	{
		bool uiactive = data != null && data.CheckIfHaveMutiGood();
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060141BE RID: 82366 RVA: 0x005DD958 File Offset: 0x005DBB58
	private void RefreshLeftButton(SkinBuyDetailViewData data)
	{
		bool uiactive = data != null && data.CheckIfHaveMutiGood();
		base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060141BF RID: 82367 RVA: 0x005DD98C File Offset: 0x005DBB8C
	private void RefreshSwitchItem(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		bool ifNeedShowSwitchItem = data.GetIfNeedShowSwitchItem();
		base.GetItem(7).SetUIActive(ifNeedShowSwitchItem);
	}

	// Token: 0x060141C0 RID: 82368 RVA: 0x005DD9B4 File Offset: 0x005DBBB4
	private void RefreshRoleTexture(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		string buyPreviewRoleCardPath = data.GetCurrentSkinData().GetBuyPreviewRoleCardPath();
		base.SetTextureByPath(buyPreviewRoleCardPath, base.GetTexture(23), null, null);
	}

	// Token: 0x060141C1 RID: 82369 RVA: 0x005DD9EC File Offset: 0x005DBBEC
	private void RefreshRoleQualityTexture(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		string buyPreviewRoleQualityBgPath = data.GetCurrentSkinData().GetBuyPreviewRoleQualityBgPath();
		base.SetTextureByPath(buyPreviewRoleQualityBgPath, base.GetTexture(22), null, null);
	}

	// Token: 0x060141C2 RID: 82370 RVA: 0x005DDA24 File Offset: 0x005DBC24
	private void RefreshWeaponTexture(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			base.GetTexture(26).SetUIActive(false);
			return;
		}
		if (data.GetCurrentSkinData().GetSuitWeaponSkinId() > 0)
		{
			string suitWeaponPreviewTexturePath = data.GetCurrentSkinData().GetSuitWeaponPreviewTexturePath();
			base.SetTextureByPath(suitWeaponPreviewTexturePath, base.GetTexture(26), null, null);
			base.GetTexture(26).SetUIActive(true);
			return;
		}
		base.GetTexture(26).SetUIActive(false);
	}

	// Token: 0x060141C3 RID: 82371 RVA: 0x005DDA98 File Offset: 0x005DBC98
	private void RefreshWeaponQualityTexture(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			base.GetItem(25).SetUIActive(false);
			return;
		}
		if (data.GetCurrentSkinData().GetSuitWeaponSkinId() > 0)
		{
			FColor color = FColor.FromHex(data.GetCurrentSkinData().GetRoleSkinConfig().SuitWeaponSkinColor);
			base.GetTexture(30).SetColor(color);
			base.GetItem(25).SetUIActive(true);
			return;
		}
		base.GetItem(25).SetUIActive(false);
	}

	// Token: 0x060141C4 RID: 82372 RVA: 0x005DDB0C File Offset: 0x005DBD0C
	private void RefreshDiscountText(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			base.GetItem(18).SetUIActive(false);
			return;
		}
		string discountText = data.GetDiscountText();
		base.GetItem(18).SetUIActive(discountText != "");
		base.GetText(19).SetText(discountText, true);
	}

	// Token: 0x060141C5 RID: 82373 RVA: 0x005DDB5C File Offset: 0x005DBD5C
	private void RefreshDiscountTime(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			base.GetItem(20).SetUIActive(false);
			return;
		}
		object discountTimeData = data.GetDiscountTimeData();
		if (discountTimeData == null)
		{
			base.GetItem(20).SetUIActive(false);
			return;
		}
		base.GetItem(20).SetUIActive(true);
		UUIText text = base.GetText(21);
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = discountTimeData as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime != null)
		{
			text.SetText(payShowCountDownRemainTime.Value, true);
			return;
		}
		CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime> payShowCountDownRemainTime2 = discountTimeData as CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>;
		if (payShowCountDownRemainTime2 != null)
		{
			LguiUtil.Instance.SetLocalText(text, payShowCountDownRemainTime2.Value.TextId, new <>z__ReadOnlySingleElementList<object>(payShowCountDownRemainTime2.Value.TimeValue));
		}
	}

	// Token: 0x060141C6 RID: 82374 RVA: 0x005DDBF8 File Offset: 0x005DBDF8
	private void RefreshBuyItemIcon(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			base.GetTexture(14).SetUIActive(false);
			return;
		}
		bool ifDirect = data.GetIfDirect();
		base.GetTexture(14).SetUIActive(!ifDirect);
		if (!ifDirect)
		{
			IPriceData priceData = data.GetPriceData();
			if (priceData != null)
			{
				base.SetItemIcon(base.GetTexture(14), priceData.CurrencyId, null, null);
			}
		}
	}

	// Token: 0x060141C7 RID: 82375 RVA: 0x005DDC64 File Offset: 0x005DBE64
	private void RefreshSourcePriceText(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null || !data.GetCurrentGoodsData().GetIfCanBuy())
		{
			base.GetText(16).SetText("", true);
			return;
		}
		if (data.GetIfDirect())
		{
			base.GetText(16).SetText("", true);
			return;
		}
		IPriceData priceData = data.GetPriceData();
		if (priceData == null)
		{
			return;
		}
		int? originalPrice = priceData.OriginalPrice;
		if (originalPrice == null)
		{
			base.GetText(16).SetUIActive(false);
			return;
		}
		base.GetText(16).SetUIActive(true);
		base.GetText(16).SetText("<s>" + originalPrice.Value.ToString() + "</s>", true);
	}

	// Token: 0x060141C8 RID: 82376 RVA: 0x005DDD20 File Offset: 0x005DBF20
	private void RefreshNowPriceText(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			base.GetText(15).SetText("", true);
			return;
		}
		if (data.GetIfDirect())
		{
			string directPriceText = data.GetDirectPriceText();
			base.GetText(15).SetText(directPriceText, true);
			return;
		}
		IPriceData priceData = data.GetPriceData();
		if (priceData != null)
		{
			int nowPrice = priceData.NowPrice;
			base.GetText(15).SetText(nowPrice.ToString(), true);
		}
	}

	// Token: 0x060141C9 RID: 82377 RVA: 0x005DDD94 File Offset: 0x005DBF94
	private void RefreshPriceTextShowState(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			base.GetText(15).SetUIActive(false);
			return;
		}
		bool ifCanBuy = data.GetCurrentGoodsData().GetIfCanBuy();
		CommonItemData availableCouponItem = data.GetCurrentGoodsData().GetCurrentGoodsData().GetAvailableCouponItem();
		base.GetItem(38).SetUIActive(ifCanBuy && availableCouponItem == null);
		base.GetItem(39).SetUIActive(ifCanBuy && availableCouponItem != null);
	}

	// Token: 0x060141CA RID: 82378 RVA: 0x005DDE08 File Offset: 0x005DC008
	private void RefreshBuyButtonState(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			base.GetButton(17).RootUIComp.Get().SetUIActive(false);
			return;
		}
		bool ifCanBuy = data.GetCurrentGoodsData().GetIfCanBuy();
		base.GetButton(17).RootUIComp.Get().SetUIActive(ifCanBuy);
	}

	// Token: 0x060141CB RID: 82379 RVA: 0x005DDE64 File Offset: 0x005DC064
	private void RefreshHaveItem(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			base.GetItem(27).SetUIActive(false);
			return;
		}
		bool ifCanBuy = data.GetCurrentGoodsData().GetIfCanBuy();
		base.GetItem(27).SetUIActive(!ifCanBuy);
	}

	// Token: 0x060141CC RID: 82380 RVA: 0x005DDEA8 File Offset: 0x005DC0A8
	private void RefreshNotHaveRoleItem(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			base.GetItem(13).SetUIActive(false);
			return;
		}
		bool ifHaveSkinNeedRole = data.GetIfHaveSkinNeedRole();
		base.GetItem(13).SetUIActive(!ifHaveSkinNeedRole);
	}

	// Token: 0x060141CD RID: 82381 RVA: 0x005DDEE8 File Offset: 0x005DC0E8
	private void RefreshExtraReward(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		if (data.GetIsActivityReward())
		{
			TItem[] connectOtherReward = data.GetConnectOtherReward();
			List<SkinRewardData> list = new List<SkinRewardData>();
			foreach (TItem value in connectOtherReward)
			{
				list.Add(new SkinRewardData
				{
					ItemData = new TItem?(value),
					FinishState = (data.GetCurrentSkinData().GetItemCount() >= 1)
				});
			}
			GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout = this.ItemLayout;
			if (itemLayout != null)
			{
				itemLayout.SetActive(list.Count != 0);
			}
			GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout2 = this.ItemLayout;
			if (itemLayout2 == null)
			{
				return;
			}
			itemLayout2.RefreshByData(list, null, false);
			return;
		}
		else if (data.GetCurrentGoodsData() == null)
		{
			GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout3 = this.ItemLayout;
			if (itemLayout3 == null)
			{
				return;
			}
			itemLayout3.SetActive(false);
			return;
		}
		else
		{
			TItem[] otherReward = data.GetCurrentGoodsData().GetOtherReward();
			List<SkinRewardData> list2 = new List<SkinRewardData>();
			foreach (TItem value2 in otherReward)
			{
				list2.Add(new SkinRewardData
				{
					ItemData = new TItem?(value2),
					FinishState = !data.GetCurrentGoodsData().GetIfCanBuy()
				});
			}
			GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout4 = this.ItemLayout;
			if (itemLayout4 != null)
			{
				itemLayout4.SetActive(list2.Count != 0);
			}
			GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout5 = this.ItemLayout;
			if (itemLayout5 == null)
			{
				return;
			}
			itemLayout5.RefreshByData(list2, null, false);
			return;
		}
	}

	// Token: 0x060141CE RID: 82382 RVA: 0x005DE030 File Offset: 0x005DC230
	private void RefreshExtraRewardItem(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		if (data.GetIsActivityReward())
		{
			base.GetItem(9).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(50), "RoverSkinEvent_ExtraReward", Array.Empty<object>());
			return;
		}
		if (data.GetCurrentGoodsData() == null)
		{
			base.GetItem(9).SetUIActive(false);
			return;
		}
		base.GetItem(9).SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(50), "PrefabTextitem_RoleSkinExtraAcquisition_Text", Array.Empty<object>());
	}

	// Token: 0x060141CF RID: 82383 RVA: 0x005DE0B8 File Offset: 0x005DC2B8
	private void RefreshEffectItem(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			base.GetItem(33).SetUIActive(false);
			base.GetItem(32).SetUIActive(false);
			return;
		}
		bool uiactive = data.GetCurrentSkinData().GetSuitWeaponSkinId() > 0;
		base.GetItem(33).SetUIActive(uiactive);
		base.GetItem(32).SetUIActive(uiactive);
	}

	// Token: 0x060141D0 RID: 82384 RVA: 0x005DE118 File Offset: 0x005DC318
	private void RefreshCouponPrice(SkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			return;
		}
		if (data.GetIfDirect())
		{
			return;
		}
		CommonItemData availableCouponItem = data.GetCurrentGoodsData().GetCurrentGoodsData().GetAvailableCouponItem();
		if (availableCouponItem == null)
		{
			return;
		}
		IPriceData priceData = data.GetPriceData();
		if (priceData == null)
		{
			return;
		}
		int valueOrDefault = priceData.OriginalPrice.GetValueOrDefault();
		int availableCouponDiscount = data.GetCurrentGoodsData().GetCurrentGoodsData().GetAvailableCouponDiscount();
		int nowPrice = priceData.NowPrice;
		UUIText text = base.GetText(40);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(availableCouponDiscount);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIText text2 = base.GetText(42);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral("<s>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
		defaultInterpolatedStringHandler.AppendLiteral("</s>");
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetText(44).SetText(nowPrice.ToString(), true);
		base.SetItemIcon(base.GetTexture(41), availableCouponItem.GetConfigId(), null, null);
		base.SetItemIcon(base.GetTexture(43), priceData.CurrencyId, null, null);
	}

	// Token: 0x060141D1 RID: 82385 RVA: 0x005DE248 File Offset: 0x005DC448
	private void RefreshSexPanel(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			UUIItem item = base.GetItem(47);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			bool isActivityReward = data.GetIsActivityReward();
			UUIItem item2 = base.GetItem(47);
			if (item2 != null)
			{
				item2.SetUIActive(isActivityReward);
			}
			this.CaptionItem.SetHelpBtnActive(!isActivityReward);
			UUIExtendToggle extendToggle = base.GetExtendToggle(48);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState((data.GetIndex() == 0) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(49);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleStateForce((data.GetIndex() == 1) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
	}

	// Token: 0x060141D2 RID: 82386 RVA: 0x005DE2DC File Offset: 0x005DC4DC
	protected override void OnTick(float delta)
	{
		SkinBuyDetailViewData viewData = this.ViewData;
		PayShopGoods payShopGoods;
		if (viewData == null)
		{
			payShopGoods = null;
		}
		else
		{
			ShopSkinData currentGoodsData = viewData.GetCurrentGoodsData();
			payShopGoods = ((currentGoodsData != null) ? currentGoodsData.GetCurrentGoodsData() : null);
		}
		PayShopGoods payShopGoods2 = payShopGoods;
		if (payShopGoods2 == null)
		{
			return;
		}
		int currentPayItemId = this.CurrentPayItemId;
		PayShopGoodsData goodsData = payShopGoods2.GetGoodsData();
		int? num = (goodsData != null) ? new int?(goodsData.Id) : null;
		if (!(currentPayItemId == num.GetValueOrDefault() & num != null))
		{
			this.CurrentPayItemId = payShopGoods2.GetGoodsData().Id;
			this.CurrentDiscountState = payShopGoods2.HasDiscount();
			return;
		}
		bool flag = payShopGoods2.HasDiscount();
		if (this.CurrentDiscountState != flag)
		{
			int currentPayItemId2 = this.CurrentPayItemId;
			PayShopGoodsData goodsData2 = payShopGoods2.GetGoodsData();
			num = ((goodsData2 != null) ? new int?(goodsData2.Id) : null);
			if (currentPayItemId2 == num.GetValueOrDefault() & num != null)
			{
				this.CurrentDiscountState = flag;
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
				confirmBoxDataNew.FunctionMap[2] = new Action(this.RefreshView);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}
	}

	// Token: 0x060141D3 RID: 82387 RVA: 0x005DE3E5 File Offset: 0x005DC5E5
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(169);
	}

	// Token: 0x0400AAD6 RID: 43734
	private SkinBuyDetailViewData ViewData;

	// Token: 0x0400AAD7 RID: 43735
	private int CurrentSkinTypeIndex;

	// Token: 0x0400AAD8 RID: 43736
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AAD9 RID: 43737
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400AADA RID: 43738
	private FVector? CurrentDragPosition;

	// Token: 0x0400AADB RID: 43739
	private UiCameraInputComponent UiCameraInputComponent;

	// Token: 0x0400AADC RID: 43740
	private UiCameraLogicComponent UiCameraLogicComponent;

	// Token: 0x0400AADD RID: 43741
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

	// Token: 0x0400AADE RID: 43742
	private double LastClickButtonTime;

	// Token: 0x0400AADF RID: 43743
	private double LastSwitchTime;

	// Token: 0x0400AAE0 RID: 43744
	private bool CurrentDiscountState;

	// Token: 0x0400AAE1 RID: 43745
	private int CurrentPayItemId;

	// Token: 0x020082B7 RID: 33463
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A3D7 RID: 173015
		CaptionItem,
		// Token: 0x0402A3D8 RID: 173016
		OnlyUiToggle,
		// Token: 0x0402A3D9 RID: 173017
		DetailIconButton,
		// Token: 0x0402A3DA RID: 173018
		ButtonLeft,
		// Token: 0x0402A3DB RID: 173019
		ButtonRight,
		// Token: 0x0402A3DC RID: 173020
		TitleText,
		// Token: 0x0402A3DD RID: 173021
		SubTitleText,
		// Token: 0x0402A3DE RID: 173022
		SwitchItem,
		// Token: 0x0402A3DF RID: 173023
		ToggleLeft,
		// Token: 0x0402A3E0 RID: 173024
		ExtraRewardItem,
		// Token: 0x0402A3E1 RID: 173025
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402A3E2 RID: 173026
		RewardItem,
		// Token: 0x0402A3E3 RID: 173027
		DescText,
		// Token: 0x0402A3E4 RID: 173028
		NotHaveRoleItem,
		// Token: 0x0402A3E5 RID: 173029
		BuyItemIcon,
		// Token: 0x0402A3E6 RID: 173030
		NowPrice,
		// Token: 0x0402A3E7 RID: 173031
		BeforePrice,
		// Token: 0x0402A3E8 RID: 173032
		BuyButton,
		// Token: 0x0402A3E9 RID: 173033
		DiscountItem,
		// Token: 0x0402A3EA RID: 173034
		DiscountText,
		// Token: 0x0402A3EB RID: 173035
		LeftTimeItem,
		// Token: 0x0402A3EC RID: 173036
		LeftTimeText,
		// Token: 0x0402A3ED RID: 173037
		QualityTexture,
		// Token: 0x0402A3EE RID: 173038
		RoleTexture,
		// Token: 0x0402A3EF RID: 173039
		FrameTexture,
		// Token: 0x0402A3F0 RID: 173040
		WeaponRootItem,
		// Token: 0x0402A3F1 RID: 173041
		WeaponTexture,
		// Token: 0x0402A3F2 RID: 173042
		HaveItem,
		// Token: 0x0402A3F3 RID: 173043
		HideUiParentItem,
		// Token: 0x0402A3F4 RID: 173044
		DragComponent,
		// Token: 0x0402A3F5 RID: 173045
		WeaponQualityTexture,
		// Token: 0x0402A3F6 RID: 173046
		ToggleRight,
		// Token: 0x0402A3F7 RID: 173047
		EffectItemB,
		// Token: 0x0402A3F8 RID: 173048
		EffectItemA,
		// Token: 0x0402A3F9 RID: 173049
		TextureToggleLeft,
		// Token: 0x0402A3FA RID: 173050
		TextToggleLeft,
		// Token: 0x0402A3FB RID: 173051
		TextureToggleRight,
		// Token: 0x0402A3FC RID: 173052
		TextToggleRight,
		// Token: 0x0402A3FD RID: 173053
		ItemNonCouponPrice,
		// Token: 0x0402A3FE RID: 173054
		ItemCouponPrice,
		// Token: 0x0402A3FF RID: 173055
		TextCouponPrice,
		// Token: 0x0402A400 RID: 173056
		TextureCouponIcon,
		// Token: 0x0402A401 RID: 173057
		TextOriginPrice,
		// Token: 0x0402A402 RID: 173058
		TexturePriceIcon,
		// Token: 0x0402A403 RID: 173059
		TextCurPrice,
		// Token: 0x0402A404 RID: 173060
		ItemGamePadKeyTipA,
		// Token: 0x0402A405 RID: 173061
		ItemGamePadKeyTipB,
		// Token: 0x0402A406 RID: 173062
		ToggleLayout,
		// Token: 0x0402A407 RID: 173063
		ToggleMale,
		// Token: 0x0402A408 RID: 173064
		ToggleFemale,
		// Token: 0x0402A409 RID: 173065
		ExtraRewardText
	}
}
