using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A24 RID: 10788
[NullableContext(2)]
[Nullable(0)]
public class EquipBuffItemDetailView : UiViewBase
{
	// Token: 0x060166B5 RID: 91829 RVA: 0x005AB0FC File Offset: 0x005A92FC
	[NullableContext(1)]
	public EquipBuffItemDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060166B6 RID: 91830 RVA: 0x005AB180 File Offset: 0x005A9380
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
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
			new ValueTuple<int, Type>(43, typeof(UUITexture)),
			new ValueTuple<int, Type>(42, typeof(UUIText)),
			new ValueTuple<int, Type>(41, typeof(UUITexture)),
			new ValueTuple<int, Type>(44, typeof(UUIText)),
			new ValueTuple<int, Type>(45, typeof(UUIItem)),
			new ValueTuple<int, Type>(46, typeof(UUIItem)),
			new ValueTuple<int, Type>(47, typeof(UUIItem)),
			new ValueTuple<int, Type>(48, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(49, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(50, typeof(UUIText)),
			new ValueTuple<int, Type>(51, typeof(UUIItem)),
			new ValueTuple<int, Type>(52, typeof(UUIItem)),
			new ValueTuple<int, Type>(53, typeof(UUIItem))
		};
	}

	// Token: 0x060166B7 RID: 91831 RVA: 0x005AB66C File Offset: 0x005A986C
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
	}

	// Token: 0x060166B8 RID: 91832 RVA: 0x005AB7A4 File Offset: 0x005A99A4
	private void RemoveCameraEventListener()
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
	}

	// Token: 0x060166B9 RID: 91833 RVA: 0x005AB8B1 File Offset: 0x005A9AB1
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

	// Token: 0x060166BA RID: 91834 RVA: 0x005AB8E0 File Offset: 0x005A9AE0
	[NullableContext(1)]
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.TouchMoved();
		}
	}

	// Token: 0x060166BB RID: 91835 RVA: 0x005AB8F4 File Offset: 0x005A9AF4
	private void TouchMoved()
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
			this.UiCameraControlRotationComponent.AddZoomInput(-fingerExpandCloseValue);
		}
	}

	// Token: 0x060166BC RID: 91836 RVA: 0x005AB928 File Offset: 0x005A9B28
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x060166BD RID: 91837 RVA: 0x005AB93C File Offset: 0x005A9B3C
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

	// Token: 0x060166BE RID: 91838 RVA: 0x005AB9FA File Offset: 0x005A9BFA
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = null;
	}

	// Token: 0x060166BF RID: 91839 RVA: 0x005ABA08 File Offset: 0x005A9C08
	private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
	{
		if (eventData.scrollAxisValue != 0f)
		{
			this.UiCameraControlRotationComponent.AddZoomInput(-eventData.scrollAxisValue);
		}
	}

	// Token: 0x060166C0 RID: 91840 RVA: 0x005ABA2C File Offset: 0x005A9C2C
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
		foreach (int name in this.disableNodeList)
		{
			UUIItem item3 = base.GetItem(name);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
		}
	}

	// Token: 0x060166C1 RID: 91841 RVA: 0x005ABB74 File Offset: 0x005A9D74
	protected override void OnAfterShow()
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x060166C2 RID: 91842 RVA: 0x005ABB7C File Offset: 0x005A9D7C
	protected override void OnAfterHide()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		UiModelBase uiModelBase = (tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null;
		if (uiModelBase != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
		}
	}

	// Token: 0x060166C3 RID: 91843 RVA: 0x005ABBAC File Offset: 0x005A9DAC
	private void RefreshCameraRotationComponentByViewType()
	{
		if (UiCameraAnimationManager.Instance.IsPlayingAnimation())
		{
			return;
		}
		string configId = (this.CurrentSkinTypeIndex == 0) ? PayShopConfig.Instance.GetBuySkinDetailRoleCameraConfigId() : PayShopConfig.Instance.GetBuySkinDetailWeaponCameraConfigId();
		this.RefreshCameraRotationComponent(configId);
	}

	// Token: 0x060166C4 RID: 91844 RVA: 0x005ABBEC File Offset: 0x005A9DEC
	[NullableContext(1)]
	private void RefreshCameraRotationComponent(string configId)
	{
		UiCamera uiCamera = UiCameraManager.Get();
		this.UiCameraControlRotationComponent = (uiCamera.AddUiCameraComponent(typeof(UiCameraControlRotationComponent), false) as UiCameraControlRotationComponent);
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig(configId);
		this.UiCameraControlRotationComponent.InitDataByConfig(roleCameraConfig.Value);
		this.UiCameraControlRotationComponent.SetNeedFloorReflection(true);
		FVectorDouble sourceLocation = this.TsUiSceneRoleActor.D_K2_GetActorLocation();
		int roleId = this.ViewData.RoleSkinData.GetRoleId();
		string roleBody = RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleBody;
		SUiRoleCameraOffsetSetting? roleCameraOffsetConfig = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(roleBody);
		this.UiCameraControlRotationComponent.UpdateData(sourceLocation, roleCameraOffsetConfig.Value.镜头浮动最大高度, roleCameraOffsetConfig.Value.镜头浮动最低高度, roleCameraOffsetConfig.Value.镜头浮动最长臂长, roleCameraOffsetConfig.Value.镜头浮动最短臂长);
		this.UiCameraControlRotationComponent.Activate();
		this.UiCameraControlRotationComponent.ResumeTick();
	}

	// Token: 0x060166C5 RID: 91845 RVA: 0x005ABCE1 File Offset: 0x005A9EE1
	private void OnInputUiLookUp(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddPitchInput(-value);
	}

	// Token: 0x060166C6 RID: 91846 RVA: 0x005ABD05 File Offset: 0x005A9F05
	private void OnInputUiTurn(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddYawInput(value);
	}

	// Token: 0x060166C7 RID: 91847 RVA: 0x005ABD28 File Offset: 0x005A9F28
	[NullableContext(1)]
	private void OnInputUiZoom(string axisName, float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraControlRotationComponent.AddZoomInput(value);
	}

	// Token: 0x060166C8 RID: 91848 RVA: 0x005ABD4C File Offset: 0x005A9F4C
	private void OnRightStickPress()
	{
		UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
		if (lastHandleData != null)
		{
			UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(lastHandleData.HandleName, true, true, "1001", false, null, null);
		}
	}

	// Token: 0x060166C9 RID: 91849 RVA: 0x005ABD8C File Offset: 0x005A9F8C
	protected override void OnStart()
	{
		this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInEquipBuffItemPreview);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.CloseView));
		this.ViewData = (this.OpenParam as EquipBuffItemDetailViewData);
		this.CaptionItem.SetTitleLocalText("TotalTopUp_1003");
		this.CaptionItem.SetTitleIconByResourceId("EquipBuffItemDetailTitle_Icon");
		this.CaptionItem.SetHelpBtnActive(false);
		base.GetExtendToggle(8).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		base.GetExtendToggle(31).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		this.ResetCurrentSkinTypeIndex();
	}

	// Token: 0x060166CA RID: 91850 RVA: 0x005ABE53 File Offset: 0x005AA053
	private bool CanToggleExecuteChange()
	{
		return TimeUtil.Instance.GetServerTimeStamp() - (double)this.LastSwitchTime >= (double)SkinConfig.Instance.GetSkinDetailButtonSwitchGap();
	}

	// Token: 0x060166CB RID: 91851 RVA: 0x005ABE77 File Offset: 0x005AA077
	protected override void OnBeforeHide()
	{
		this.RemoveCameraEventListener();
		this.UiCameraControlRotationComponent.PauseTick();
	}

	// Token: 0x060166CC RID: 91852 RVA: 0x005ABE8A File Offset: 0x005AA08A
	protected override void OnBeforeDestroy()
	{
		UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x060166CD RID: 91853 RVA: 0x005ABEB8 File Offset: 0x005AA0B8
	private void RefreshRolePerformance()
	{
		int roleId = this.ViewData.RoleSkinData.GetRoleId();
		if (roleId > 0)
		{
			RoleController.Instance.RefreshUiSceneRoleActorByConfigId(roleId, this.ViewData.RoleSkinData.GetItemId(), delegate
			{
			});
		}
		EventSystem.Instance.Emit(EEventName.OnSelectedRoleChanged);
	}

	// Token: 0x060166CE RID: 91854 RVA: 0x005ABF24 File Offset: 0x005AA124
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060166CF RID: 91855 RVA: 0x005ABF2D File Offset: 0x005AA12D
	protected override void OnHandleReleaseScene()
	{
		this.HandleReleaseScene();
	}

	// Token: 0x060166D0 RID: 91856 RVA: 0x005ABF35 File Offset: 0x005AA135
	private void HandleReleaseScene()
	{
	}

	// Token: 0x060166D1 RID: 91857 RVA: 0x005ABF37 File Offset: 0x005AA137
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

	// Token: 0x060166D2 RID: 91858 RVA: 0x005ABF49 File Offset: 0x005AA149
	[NullableContext(1)]
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x060166D3 RID: 91859 RVA: 0x005ABF51 File Offset: 0x005AA151
	private void ResetCurrentSkinTypeIndex()
	{
		this.CurrentSkinTypeIndex = 0;
	}

	// Token: 0x060166D4 RID: 91860 RVA: 0x005ABF5A File Offset: 0x005AA15A
	private void RefreshView()
	{
		this.RefreshTitleText(this.ViewData);
		this.RefreshDescText(this.ViewData);
		this.RefreshRolePerformance();
	}

	// Token: 0x060166D5 RID: 91861 RVA: 0x005ABF7C File Offset: 0x005AA17C
	private void RefreshDescText(EquipBuffItemDetailViewData data)
	{
		if (data == null)
		{
			base.GetText(12).SetText("", true);
			return;
		}
		string description = data.Description;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), description, Array.Empty<object>());
	}

	// Token: 0x060166D6 RID: 91862 RVA: 0x005ABFC0 File Offset: 0x005AA1C0
	private void RefreshTitleText(EquipBuffItemDetailViewData data)
	{
		if (data == null)
		{
			base.GetText(5).SetText("", true);
			return;
		}
		string titleName = data.TitleName;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), titleName, Array.Empty<object>());
	}

	// Token: 0x0400A6A6 RID: 42662
	private EquipBuffItemDetailViewData ViewData;

	// Token: 0x0400A6A7 RID: 42663
	private int CurrentSkinTypeIndex;

	// Token: 0x0400A6A8 RID: 42664
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A6A9 RID: 42665
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400A6AA RID: 42666
	private FVector? CurrentDragPosition;

	// Token: 0x0400A6AB RID: 42667
	private UiCameraControlRotationComponent UiCameraControlRotationComponent;

	// Token: 0x0400A6AC RID: 42668
	private float LastSwitchTime;

	// Token: 0x0400A6AD RID: 42669
	[Nullable(1)]
	private readonly List<int> disableNodeList = new List<int>
	{
		6,
		7,
		9,
		50,
		13,
		47,
		51,
		52,
		53,
		8,
		31,
		3,
		4
	};

	// Token: 0x02009057 RID: 36951
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402EBC7 RID: 191431
		CaptionItem,
		// Token: 0x0402EBC8 RID: 191432
		OnlyUiToggle,
		// Token: 0x0402EBC9 RID: 191433
		DetailIconButton,
		// Token: 0x0402EBCA RID: 191434
		ButtonLeft,
		// Token: 0x0402EBCB RID: 191435
		ButtonRight,
		// Token: 0x0402EBCC RID: 191436
		TitleText,
		// Token: 0x0402EBCD RID: 191437
		SubTitleText,
		// Token: 0x0402EBCE RID: 191438
		SwitchItem,
		// Token: 0x0402EBCF RID: 191439
		ToggleLeft,
		// Token: 0x0402EBD0 RID: 191440
		ExtraRewardItem,
		// Token: 0x0402EBD1 RID: 191441
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402EBD2 RID: 191442
		RewardItem,
		// Token: 0x0402EBD3 RID: 191443
		DescText,
		// Token: 0x0402EBD4 RID: 191444
		NotHaveRoleItem,
		// Token: 0x0402EBD5 RID: 191445
		BuyItemIcon,
		// Token: 0x0402EBD6 RID: 191446
		NowPrice,
		// Token: 0x0402EBD7 RID: 191447
		BeforePrice,
		// Token: 0x0402EBD8 RID: 191448
		BuyButton,
		// Token: 0x0402EBD9 RID: 191449
		DiscountItem,
		// Token: 0x0402EBDA RID: 191450
		DiscountText,
		// Token: 0x0402EBDB RID: 191451
		LeftTimeItem,
		// Token: 0x0402EBDC RID: 191452
		LeftTimeText,
		// Token: 0x0402EBDD RID: 191453
		QualityTexture,
		// Token: 0x0402EBDE RID: 191454
		RoleTexture,
		// Token: 0x0402EBDF RID: 191455
		FrameTexture,
		// Token: 0x0402EBE0 RID: 191456
		WeaponRootItem,
		// Token: 0x0402EBE1 RID: 191457
		WeaponTexture,
		// Token: 0x0402EBE2 RID: 191458
		HaveItem,
		// Token: 0x0402EBE3 RID: 191459
		HideUiParentItem,
		// Token: 0x0402EBE4 RID: 191460
		DragComponent,
		// Token: 0x0402EBE5 RID: 191461
		WeaponQualityTexture,
		// Token: 0x0402EBE6 RID: 191462
		ToggleRight,
		// Token: 0x0402EBE7 RID: 191463
		EffectItemB,
		// Token: 0x0402EBE8 RID: 191464
		EffectItemA,
		// Token: 0x0402EBE9 RID: 191465
		TextureToggleLeft,
		// Token: 0x0402EBEA RID: 191466
		TextToggleLeft,
		// Token: 0x0402EBEB RID: 191467
		TextureToggleRight,
		// Token: 0x0402EBEC RID: 191468
		TextToggleRight,
		// Token: 0x0402EBED RID: 191469
		ItemNonCouponPrice,
		// Token: 0x0402EBEE RID: 191470
		ItemCouponPrice,
		// Token: 0x0402EBEF RID: 191471
		TextCouponPrice,
		// Token: 0x0402EBF0 RID: 191472
		TextureCouponIcon,
		// Token: 0x0402EBF1 RID: 191473
		TextOriginPrice,
		// Token: 0x0402EBF2 RID: 191474
		TexturePriceIcon,
		// Token: 0x0402EBF3 RID: 191475
		TextCurPrice,
		// Token: 0x0402EBF4 RID: 191476
		ItemGamePadKeyTipA,
		// Token: 0x0402EBF5 RID: 191477
		ItemGamePadKeyTipB,
		// Token: 0x0402EBF6 RID: 191478
		ToggleLayout,
		// Token: 0x0402EBF7 RID: 191479
		ToggleMale,
		// Token: 0x0402EBF8 RID: 191480
		ToggleFemale,
		// Token: 0x0402EBF9 RID: 191481
		ExtraRewardText,
		// Token: 0x0402EBFA RID: 191482
		ItemPanelBuy,
		// Token: 0x0402EBFB RID: 191483
		ItemPanelRole,
		// Token: 0x0402EBFC RID: 191484
		ItemPanelLeftDownBtn
	}
}
