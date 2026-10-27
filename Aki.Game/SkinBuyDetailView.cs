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
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A2F RID: 10799
[NullableContext(2)]
[Nullable(0)]
public class SkinBuyDetailView : UiTickViewBase
{
	// Token: 0x06016780 RID: 92032 RVA: 0x005B1175 File Offset: 0x005AF375
	[NullableContext(1)]
	public SkinBuyDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016781 RID: 92033 RVA: 0x005B1180 File Offset: 0x005AF380
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

	// Token: 0x06016782 RID: 92034 RVA: 0x005B170C File Offset: 0x005AF90C
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

	// Token: 0x06016783 RID: 92035 RVA: 0x005B187C File Offset: 0x005AFA7C
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

	// Token: 0x06016784 RID: 92036 RVA: 0x005B19C1 File Offset: 0x005AFBC1
	[NullableContext(1)]
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x06016785 RID: 92037 RVA: 0x005B19CC File Offset: 0x005AFBCC
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

	// Token: 0x06016786 RID: 92038 RVA: 0x005B1A1E File Offset: 0x005AFC1E
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

	// Token: 0x06016787 RID: 92039 RVA: 0x005B1A4D File Offset: 0x005AFC4D
	[NullableContext(1)]
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.TouchMoved();
		}
	}

	// Token: 0x06016788 RID: 92040 RVA: 0x005B1A60 File Offset: 0x005AFC60
	private void TouchMoved()
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
			this.UiCameraControlRotationComponent.AddZoomInput(-fingerExpandCloseValue);
		}
	}

	// Token: 0x06016789 RID: 92041 RVA: 0x005B1A94 File Offset: 0x005AFC94
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x0601678A RID: 92042 RVA: 0x005B1AA8 File Offset: 0x005AFCA8
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
			this.UiCameraControlRotationComponent.AddYawInput(num);
		}
		if (num2 != 0f)
		{
			this.UiCameraControlRotationComponent.AddPitchInput(num2);
		}
	}

	// Token: 0x0601678B RID: 92043 RVA: 0x005B1B66 File Offset: 0x005AFD66
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = null;
	}

	// Token: 0x0601678C RID: 92044 RVA: 0x005B1B74 File Offset: 0x005AFD74
	private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
	{
		if (eventData.scrollAxisValue != 0f)
		{
			this.UiCameraControlRotationComponent.AddZoomInput(-eventData.scrollAxisValue);
		}
	}

	// Token: 0x0601678D RID: 92045 RVA: 0x005B1B98 File Offset: 0x005AFD98
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

	// Token: 0x0601678E RID: 92046 RVA: 0x005B1C88 File Offset: 0x005AFE88
	protected override void OnAfterShow()
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x0601678F RID: 92047 RVA: 0x005B1C90 File Offset: 0x005AFE90
	protected override void OnAfterHide()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		UiModelBase uiModelBase = (tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null;
		if (uiModelBase != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
		}
	}

	// Token: 0x06016790 RID: 92048 RVA: 0x005B1CC0 File Offset: 0x005AFEC0
	private void RefreshCameraRotationComponentByViewType()
	{
		if (UiCameraAnimationManager.Instance.IsPlayingAnimation())
		{
			return;
		}
		string configId = (this.CurrentSkinTypeIndex == 0) ? PayShopConfig.Instance.GetBuySkinDetailRoleCameraConfigId() : PayShopConfig.Instance.GetBuySkinDetailWeaponCameraConfigId();
		this.RefreshCameraRotationComponent(configId);
	}

	// Token: 0x06016791 RID: 92049 RVA: 0x005B1D00 File Offset: 0x005AFF00
	[NullableContext(1)]
	private void RefreshCameraRotationComponent(string configId)
	{
		UiCamera uiCamera = UiCameraManager.Get();
		this.UiCameraControlRotationComponent = (uiCamera.AddUiCameraComponent(typeof(UiCameraControlRotationComponent), false) as UiCameraControlRotationComponent);
		int itemId = this.ViewData.GetCurrentSkinData().GetItemId();
		SUiRoleCameraSetting? roleCameraConfigBySkin = UiRoleCameraConfig.Instance.GetRoleCameraConfigBySkin(configId, itemId);
		if (roleCameraConfigBySkin == null)
		{
			return;
		}
		this.UiCameraControlRotationComponent.InitDataByConfig(roleCameraConfigBySkin.Value);
		this.UiCameraControlRotationComponent.SetNeedFloorReflection(true);
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
		this.UiCameraControlRotationComponent.UpdateData(sourceLocation, roleCameraOffsetConfig.Value.镜头浮动最大高度, roleCameraOffsetConfig.Value.镜头浮动最低高度, roleCameraOffsetConfig.Value.镜头浮动最长臂长, roleCameraOffsetConfig.Value.镜头浮动最短臂长);
		this.UiCameraControlRotationComponent.Activate();
		this.UiCameraControlRotationComponent.ResumeTick();
	}

	// Token: 0x06016792 RID: 92050 RVA: 0x005B1E2C File Offset: 0x005B002C
	private void OnInputUiLookUp(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddPitchInput(-value);
	}

	// Token: 0x06016793 RID: 92051 RVA: 0x005B1E50 File Offset: 0x005B0050
	private void OnInputUiTurn(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddYawInput(value);
	}

	// Token: 0x06016794 RID: 92052 RVA: 0x005B1E73 File Offset: 0x005B0073
	[NullableContext(1)]
	private void OnInputUiZoom(string axisName, float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddZoomInput(value);
	}

	// Token: 0x06016795 RID: 92053 RVA: 0x005B1E98 File Offset: 0x005B0098
	private void OnRightStickPress()
	{
		UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
		if (lastHandleData != null)
		{
			UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(lastHandleData.HandleName, true, true, "1001", false, null, null);
		}
	}

	// Token: 0x06016796 RID: 92054 RVA: 0x005B1ED8 File Offset: 0x005B00D8
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

	// Token: 0x06016797 RID: 92055 RVA: 0x005B1FDE File Offset: 0x005B01DE
	private bool CanToggleExecuteChange()
	{
		return TimeUtil.Instance.GetServerTimeStamp() - this.LastSwitchTime >= (double)SkinConfig.Instance.GetSkinDetailButtonSwitchGap();
	}

	// Token: 0x06016798 RID: 92056 RVA: 0x005B2001 File Offset: 0x005B0201
	[NullableContext(1)]
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x06016799 RID: 92057 RVA: 0x005B2008 File Offset: 0x005B0208
	protected override void OnBeforeHide()
	{
		this.RemoveCameraEventListener();
		this.UiCameraControlRotationComponent.PauseTick();
	}

	// Token: 0x0601679A RID: 92058 RVA: 0x005B201B File Offset: 0x005B021B
	protected override void OnBeforeDestroy()
	{
		UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x0601679B RID: 92059 RVA: 0x005B204C File Offset: 0x005B024C
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

	// Token: 0x0601679C RID: 92060 RVA: 0x005B20A8 File Offset: 0x005B02A8
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

	// Token: 0x0601679D RID: 92061 RVA: 0x005B20F0 File Offset: 0x005B02F0
	private void RefreshWeaponMesh()
	{
		SkinBuyDetailView.<>c__DisplayClass41_0 CS$<>8__locals1 = new SkinBuyDetailView.<>c__DisplayClass41_0();
		SkinBuyDetailViewData viewData = this.ViewData;
		WeaponSkin? weaponSkin = (viewData != null) ? viewData.GetCurrentSkinData().GetSuitWeaponSkinConfig() : null;
		if (weaponSkin == null)
		{
			return;
		}
		SkinBuyDetailView.<>c__DisplayClass41_0 CS$<>8__locals2 = CS$<>8__locals1;
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

	// Token: 0x0601679E RID: 92062 RVA: 0x005B2180 File Offset: 0x005B0380
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601679F RID: 92063 RVA: 0x005B2189 File Offset: 0x005B0389
	protected override void OnHandleReleaseScene()
	{
		this.HandleReleaseScene();
	}

	// Token: 0x060167A0 RID: 92064 RVA: 0x005B2191 File Offset: 0x005B0391
	private void HandleReleaseScene()
	{
	}

	// Token: 0x060167A1 RID: 92065 RVA: 0x005B2194 File Offset: 0x005B0394
	private void OnClickToggleRight(EToggleState toggleState)
	{
		this.CurrentSkinTypeIndex = 1;
		this.RefreshMontageByCurrentSkinType();
		this.RefreshCameraBySkinType();
		this.LastSwitchTime = 0.0;
		base.GetExtendToggle(8).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.LastSwitchTime = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x060167A2 RID: 92066 RVA: 0x005B21E4 File Offset: 0x005B03E4
	private void OnClickToggleLeft(EToggleState toggleState)
	{
		this.CurrentSkinTypeIndex = 0;
		this.RefreshMontageByCurrentSkinType();
		this.RefreshCameraBySkinType();
		this.LastSwitchTime = 0.0;
		base.GetExtendToggle(31).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.LastSwitchTime = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x060167A3 RID: 92067 RVA: 0x005B2235 File Offset: 0x005B0435
	[NullableContext(1)]
	private void OnPlayCameraAnimationStart(UiCameraHandleData uiCameraHandleData, UiCameraHandleData cameraHandleData, string arg3)
	{
		UiCameraControlRotationComponent uiCameraControlRotationComponent = this.UiCameraControlRotationComponent;
		if (uiCameraControlRotationComponent == null)
		{
			return;
		}
		uiCameraControlRotationComponent.PauseTick();
	}

	// Token: 0x060167A4 RID: 92068 RVA: 0x005B2247 File Offset: 0x005B0447
	[NullableContext(1)]
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x060167A5 RID: 92069 RVA: 0x005B2250 File Offset: 0x005B0450
	private void RefreshCameraBySkinType()
	{
		if (this.CurrentSkinTypeIndex == 0)
		{
			UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", true);
			UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
			if (lastHandleData != null)
			{
				UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(lastHandleData.HandleName, true, true, "1001", true, delegate(UiCameraAnimationDefine.IFinishData _)
				{
					UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", false);
				}, null);
				return;
			}
		}
		else
		{
			UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", true);
			UiCameraHandleData lastHandleData2 = UiCameraAnimationManager.Instance.GetLastHandleData();
			if (lastHandleData2 != null)
			{
				UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(lastHandleData2.HandleName, true, true, "1001", true, delegate(UiCameraAnimationDefine.IFinishData _)
				{
					UiLayer.Instance.SetShowMaskLayer("SkinBuyDetailView", false);
				}, null);
			}
		}
	}

	// Token: 0x060167A6 RID: 92070 RVA: 0x005B2327 File Offset: 0x005B0527
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

	// Token: 0x060167A7 RID: 92071 RVA: 0x005B2360 File Offset: 0x005B0560
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

	// Token: 0x060167A8 RID: 92072 RVA: 0x005B239C File Offset: 0x005B059C
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

	// Token: 0x060167A9 RID: 92073 RVA: 0x005B2450 File Offset: 0x005B0650
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

	// Token: 0x060167AA RID: 92074 RVA: 0x005B24A5 File Offset: 0x005B06A5
	private void StartBuyProcess()
	{
		PayShopController.Instance.OpenBuySkinDetailView(this.ViewData.GetCurrentGoodsData().GetCurrentGoodsData());
	}

	// Token: 0x060167AB RID: 92075 RVA: 0x005B24C4 File Offset: 0x005B06C4
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

	// Token: 0x060167AC RID: 92076 RVA: 0x005B2534 File Offset: 0x005B0734
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

	// Token: 0x060167AD RID: 92077 RVA: 0x005B25A2 File Offset: 0x005B07A2
	private void ResetCurrentSkinTypeIndex()
	{
		this.CurrentSkinTypeIndex = 0;
	}

	// Token: 0x060167AE RID: 92078 RVA: 0x005B25AB File Offset: 0x005B07AB
	private void OnClickDetailIconButton()
	{
		SkinController.Instance.OpenSkinShowView(this.ViewData.GetCurrentSkinData().GetItemId());
	}

	// Token: 0x060167AF RID: 92079 RVA: 0x005B25C8 File Offset: 0x005B07C8
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

	// Token: 0x060167B0 RID: 92080 RVA: 0x005B2734 File Offset: 0x005B0934
	private void RefreshSwitchToggleByIndex()
	{
		base.GetExtendToggle(8).SetToggleState((this.CurrentSkinTypeIndex == 0) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		base.GetExtendToggle(31).SetToggleState((this.CurrentSkinTypeIndex == 1) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshMontageByCurrentSkinType();
	}

	// Token: 0x060167B1 RID: 92081 RVA: 0x005B2784 File Offset: 0x005B0984
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

	// Token: 0x060167B2 RID: 92082 RVA: 0x005B27CC File Offset: 0x005B09CC
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

	// Token: 0x060167B3 RID: 92083 RVA: 0x005B2814 File Offset: 0x005B0A14
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

	// Token: 0x060167B4 RID: 92084 RVA: 0x005B285C File Offset: 0x005B0A5C
	private void RefreshRightButton(SkinBuyDetailViewData data)
	{
		bool uiactive = data != null && data.CheckIfHaveMutiGood();
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060167B5 RID: 92085 RVA: 0x005B2890 File Offset: 0x005B0A90
	private void RefreshLeftButton(SkinBuyDetailViewData data)
	{
		bool uiactive = data != null && data.CheckIfHaveMutiGood();
		base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060167B6 RID: 92086 RVA: 0x005B28C4 File Offset: 0x005B0AC4
	private void RefreshSwitchItem(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		bool ifNeedShowSwitchItem = data.GetIfNeedShowSwitchItem();
		base.GetItem(7).SetUIActive(ifNeedShowSwitchItem);
	}

	// Token: 0x060167B7 RID: 92087 RVA: 0x005B28EC File Offset: 0x005B0AEC
	private void RefreshRoleTexture(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		string buyPreviewRoleCardPath = data.GetCurrentSkinData().GetBuyPreviewRoleCardPath();
		base.SetTextureByPath(buyPreviewRoleCardPath, base.GetTexture(23), null, null);
	}

	// Token: 0x060167B8 RID: 92088 RVA: 0x005B2924 File Offset: 0x005B0B24
	private void RefreshRoleQualityTexture(SkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		string buyPreviewRoleQualityBgPath = data.GetCurrentSkinData().GetBuyPreviewRoleQualityBgPath();
		base.SetTextureByPath(buyPreviewRoleQualityBgPath, base.GetTexture(22), null, null);
	}

	// Token: 0x060167B9 RID: 92089 RVA: 0x005B295C File Offset: 0x005B0B5C
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

	// Token: 0x060167BA RID: 92090 RVA: 0x005B29D0 File Offset: 0x005B0BD0
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

	// Token: 0x060167BB RID: 92091 RVA: 0x005B2A44 File Offset: 0x005B0C44
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

	// Token: 0x060167BC RID: 92092 RVA: 0x005B2A94 File Offset: 0x005B0C94
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

	// Token: 0x060167BD RID: 92093 RVA: 0x005B2B30 File Offset: 0x005B0D30
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

	// Token: 0x060167BE RID: 92094 RVA: 0x005B2B9C File Offset: 0x005B0D9C
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

	// Token: 0x060167BF RID: 92095 RVA: 0x005B2C58 File Offset: 0x005B0E58
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

	// Token: 0x060167C0 RID: 92096 RVA: 0x005B2CCC File Offset: 0x005B0ECC
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

	// Token: 0x060167C1 RID: 92097 RVA: 0x005B2D40 File Offset: 0x005B0F40
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

	// Token: 0x060167C2 RID: 92098 RVA: 0x005B2D9C File Offset: 0x005B0F9C
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

	// Token: 0x060167C3 RID: 92099 RVA: 0x005B2DE0 File Offset: 0x005B0FE0
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

	// Token: 0x060167C4 RID: 92100 RVA: 0x005B2E20 File Offset: 0x005B1020
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

	// Token: 0x060167C5 RID: 92101 RVA: 0x005B2F68 File Offset: 0x005B1168
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

	// Token: 0x060167C6 RID: 92102 RVA: 0x005B2FF0 File Offset: 0x005B11F0
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

	// Token: 0x060167C7 RID: 92103 RVA: 0x005B3050 File Offset: 0x005B1250
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

	// Token: 0x060167C8 RID: 92104 RVA: 0x005B3180 File Offset: 0x005B1380
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

	// Token: 0x060167C9 RID: 92105 RVA: 0x005B3214 File Offset: 0x005B1414
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

	// Token: 0x060167CA RID: 92106 RVA: 0x005B331D File Offset: 0x005B151D
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(169);
	}

	// Token: 0x0400A6EC RID: 42732
	private SkinBuyDetailViewData ViewData;

	// Token: 0x0400A6ED RID: 42733
	private int CurrentSkinTypeIndex;

	// Token: 0x0400A6EE RID: 42734
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A6EF RID: 42735
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400A6F0 RID: 42736
	private FVector? CurrentDragPosition;

	// Token: 0x0400A6F1 RID: 42737
	private UiCameraControlRotationComponent UiCameraControlRotationComponent;

	// Token: 0x0400A6F2 RID: 42738
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

	// Token: 0x0400A6F3 RID: 42739
	private double LastClickButtonTime;

	// Token: 0x0400A6F4 RID: 42740
	private double LastSwitchTime;

	// Token: 0x0400A6F5 RID: 42741
	private bool CurrentDiscountState;

	// Token: 0x0400A6F6 RID: 42742
	private int CurrentPayItemId;

	// Token: 0x02009070 RID: 36976
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ECDF RID: 191711
		CaptionItem,
		// Token: 0x0402ECE0 RID: 191712
		OnlyUiToggle,
		// Token: 0x0402ECE1 RID: 191713
		DetailIconButton,
		// Token: 0x0402ECE2 RID: 191714
		ButtonLeft,
		// Token: 0x0402ECE3 RID: 191715
		ButtonRight,
		// Token: 0x0402ECE4 RID: 191716
		TitleText,
		// Token: 0x0402ECE5 RID: 191717
		SubTitleText,
		// Token: 0x0402ECE6 RID: 191718
		SwitchItem,
		// Token: 0x0402ECE7 RID: 191719
		ToggleLeft,
		// Token: 0x0402ECE8 RID: 191720
		ExtraRewardItem,
		// Token: 0x0402ECE9 RID: 191721
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402ECEA RID: 191722
		RewardItem,
		// Token: 0x0402ECEB RID: 191723
		DescText,
		// Token: 0x0402ECEC RID: 191724
		NotHaveRoleItem,
		// Token: 0x0402ECED RID: 191725
		BuyItemIcon,
		// Token: 0x0402ECEE RID: 191726
		NowPrice,
		// Token: 0x0402ECEF RID: 191727
		BeforePrice,
		// Token: 0x0402ECF0 RID: 191728
		BuyButton,
		// Token: 0x0402ECF1 RID: 191729
		DiscountItem,
		// Token: 0x0402ECF2 RID: 191730
		DiscountText,
		// Token: 0x0402ECF3 RID: 191731
		LeftTimeItem,
		// Token: 0x0402ECF4 RID: 191732
		LeftTimeText,
		// Token: 0x0402ECF5 RID: 191733
		QualityTexture,
		// Token: 0x0402ECF6 RID: 191734
		RoleTexture,
		// Token: 0x0402ECF7 RID: 191735
		FrameTexture,
		// Token: 0x0402ECF8 RID: 191736
		WeaponRootItem,
		// Token: 0x0402ECF9 RID: 191737
		WeaponTexture,
		// Token: 0x0402ECFA RID: 191738
		HaveItem,
		// Token: 0x0402ECFB RID: 191739
		HideUiParentItem,
		// Token: 0x0402ECFC RID: 191740
		DragComponent,
		// Token: 0x0402ECFD RID: 191741
		WeaponQualityTexture,
		// Token: 0x0402ECFE RID: 191742
		ToggleRight,
		// Token: 0x0402ECFF RID: 191743
		EffectItemB,
		// Token: 0x0402ED00 RID: 191744
		EffectItemA,
		// Token: 0x0402ED01 RID: 191745
		TextureToggleLeft,
		// Token: 0x0402ED02 RID: 191746
		TextToggleLeft,
		// Token: 0x0402ED03 RID: 191747
		TextureToggleRight,
		// Token: 0x0402ED04 RID: 191748
		TextToggleRight,
		// Token: 0x0402ED05 RID: 191749
		ItemNonCouponPrice,
		// Token: 0x0402ED06 RID: 191750
		ItemCouponPrice,
		// Token: 0x0402ED07 RID: 191751
		TextCouponPrice,
		// Token: 0x0402ED08 RID: 191752
		TextureCouponIcon,
		// Token: 0x0402ED09 RID: 191753
		TextOriginPrice,
		// Token: 0x0402ED0A RID: 191754
		TexturePriceIcon,
		// Token: 0x0402ED0B RID: 191755
		TextCurPrice,
		// Token: 0x0402ED0C RID: 191756
		ItemGamePadKeyTipA,
		// Token: 0x0402ED0D RID: 191757
		ItemGamePadKeyTipB,
		// Token: 0x0402ED0E RID: 191758
		ToggleLayout,
		// Token: 0x0402ED0F RID: 191759
		ToggleMale,
		// Token: 0x0402ED10 RID: 191760
		ToggleFemale,
		// Token: 0x0402ED11 RID: 191761
		ExtraRewardText
	}
}
