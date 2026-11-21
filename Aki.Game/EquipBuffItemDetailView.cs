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
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F9F RID: 8095
[NullableContext(2)]
[Nullable(0)]
public class EquipBuffItemDetailView : UiViewBase
{
	// Token: 0x060140BB RID: 82107 RVA: 0x005D60D8 File Offset: 0x005D42D8
	[NullableContext(1)]
	public EquipBuffItemDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060140BC RID: 82108 RVA: 0x005D615C File Offset: 0x005D435C
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

	// Token: 0x060140BD RID: 82109 RVA: 0x005D6648 File Offset: 0x005D4848
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

	// Token: 0x060140BE RID: 82110 RVA: 0x005D6780 File Offset: 0x005D4980
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

	// Token: 0x060140BF RID: 82111 RVA: 0x005D688D File Offset: 0x005D4A8D
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

	// Token: 0x060140C0 RID: 82112 RVA: 0x005D68BC File Offset: 0x005D4ABC
	[NullableContext(1)]
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.TouchMoved();
		}
	}

	// Token: 0x060140C1 RID: 82113 RVA: 0x005D68D0 File Offset: 0x005D4AD0
	private void TouchMoved()
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
			this.UiCameraInputComponent.AddZoomInput(-fingerExpandCloseValue);
		}
	}

	// Token: 0x060140C2 RID: 82114 RVA: 0x005D6904 File Offset: 0x005D4B04
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x060140C3 RID: 82115 RVA: 0x005D6918 File Offset: 0x005D4B18
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

	// Token: 0x060140C4 RID: 82116 RVA: 0x005D69D6 File Offset: 0x005D4BD6
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		this.CurrentDragPosition = null;
	}

	// Token: 0x060140C5 RID: 82117 RVA: 0x005D69E4 File Offset: 0x005D4BE4
	private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
	{
		if (eventData.scrollAxisValue != 0f)
		{
			this.UiCameraInputComponent.AddZoomInput(-eventData.scrollAxisValue);
		}
	}

	// Token: 0x060140C6 RID: 82118 RVA: 0x005D6A08 File Offset: 0x005D4C08
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

	// Token: 0x060140C7 RID: 82119 RVA: 0x005D6B50 File Offset: 0x005D4D50
	protected override void OnAfterShow()
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x060140C8 RID: 82120 RVA: 0x005D6B58 File Offset: 0x005D4D58
	protected override void OnAfterHide()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		UiModelBase uiModelBase = (tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null;
		if (uiModelBase != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
		}
	}

	// Token: 0x060140C9 RID: 82121 RVA: 0x005D6B88 File Offset: 0x005D4D88
	private void RefreshCameraRotationComponentByViewType()
	{
		if (UiCameraModel.Instance.IsPlayingAnimation())
		{
			return;
		}
		string configId = (this.CurrentSkinTypeIndex == 0) ? PayShopConfig.Instance.GetBuySkinDetailRoleCameraConfigId() : PayShopConfig.Instance.GetBuySkinDetailWeaponCameraConfigId();
		this.RefreshCameraRotationComponent(configId);
	}

	// Token: 0x060140CA RID: 82122 RVA: 0x005D6BC8 File Offset: 0x005D4DC8
	[NullableContext(1)]
	private void RefreshCameraRotationComponent(string configId)
	{
		UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
		this.UiCameraInputComponent = orCreateCamera.GetUiCameraComponent<UiCameraInputComponent>();
		this.UiCameraLogicComponent = orCreateCamera.GetUiCameraComponent<UiCameraLogicComponent>();
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig(configId);
		this.UiCameraLogicComponent.InitDataByConfig(roleCameraConfig.Value);
		this.UiCameraLogicComponent.SetNeedFloorReflection(true);
		FVectorDouble sourceLocation = this.TsUiSceneRoleActor.D_K2_GetActorLocation();
		int roleId = this.ViewData.RoleSkinData.GetRoleId();
		string roleBody = RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleBody;
		SUiRoleCameraOffsetSetting? roleCameraOffsetConfig = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(roleBody);
		this.UiCameraLogicComponent.UpdateData(sourceLocation, roleCameraOffsetConfig.Value.镜头浮动最大高度, roleCameraOffsetConfig.Value.镜头浮动最低高度, roleCameraOffsetConfig.Value.镜头浮动最长臂长, roleCameraOffsetConfig.Value.镜头浮动最短臂长);
		this.UiCameraInputComponent.Activate();
		this.UiCameraInputComponent.ResumeTick();
	}

	// Token: 0x060140CB RID: 82123 RVA: 0x005D6CBE File Offset: 0x005D4EBE
	private void OnInputUiLookUp(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddPitchInput(-value);
	}

	// Token: 0x060140CC RID: 82124 RVA: 0x005D6CE2 File Offset: 0x005D4EE2
	private void OnInputUiTurn(float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddYawInput(value);
	}

	// Token: 0x060140CD RID: 82125 RVA: 0x005D6D05 File Offset: 0x005D4F05
	[NullableContext(1)]
	private void OnInputUiZoom(string axisName, float value)
	{
		if (value == 0f || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.UiCameraInputComponent.AddZoomInput(value);
	}

	// Token: 0x060140CE RID: 82126 RVA: 0x005D6D28 File Offset: 0x005D4F28
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
					Log.Instance.Warn(ELogModule.UiCamera, ELogAuthor.BB, "手柄重置装备效果预览Ui镜头失败，当前镜头不可重置", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
		}
	}

	// Token: 0x060140CF RID: 82127 RVA: 0x005D6DF4 File Offset: 0x005D4FF4
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

	// Token: 0x060140D0 RID: 82128 RVA: 0x005D6EBB File Offset: 0x005D50BB
	private bool CanToggleExecuteChange()
	{
		return TimeUtil.Instance.GetServerTimeStamp() - (double)this.LastSwitchTime >= (double)SkinConfig.Instance.GetSkinDetailButtonSwitchGap();
	}

	// Token: 0x060140D1 RID: 82129 RVA: 0x005D6EDF File Offset: 0x005D50DF
	protected override void OnBeforeHide()
	{
		this.RemoveCameraEventListener();
		this.UiCameraInputComponent.PauseTick();
	}

	// Token: 0x060140D2 RID: 82130 RVA: 0x005D6EF2 File Offset: 0x005D50F2
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

	// Token: 0x060140D3 RID: 82131 RVA: 0x005D6F28 File Offset: 0x005D5128
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

	// Token: 0x060140D4 RID: 82132 RVA: 0x005D6F94 File Offset: 0x005D5194
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060140D5 RID: 82133 RVA: 0x005D6F9D File Offset: 0x005D519D
	protected override void OnHandleReleaseScene()
	{
		this.HandleReleaseScene();
	}

	// Token: 0x060140D6 RID: 82134 RVA: 0x005D6FA5 File Offset: 0x005D51A5
	private void HandleReleaseScene()
	{
	}

	// Token: 0x060140D7 RID: 82135 RVA: 0x005D6FA7 File Offset: 0x005D51A7
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

	// Token: 0x060140D8 RID: 82136 RVA: 0x005D6FB9 File Offset: 0x005D51B9
	[NullableContext(1)]
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		this.RefreshCameraRotationComponentByViewType();
	}

	// Token: 0x060140D9 RID: 82137 RVA: 0x005D6FC1 File Offset: 0x005D51C1
	private void ResetCurrentSkinTypeIndex()
	{
		this.CurrentSkinTypeIndex = 0;
	}

	// Token: 0x060140DA RID: 82138 RVA: 0x005D6FCA File Offset: 0x005D51CA
	private void RefreshView()
	{
		this.RefreshTitleText(this.ViewData);
		this.RefreshDescText(this.ViewData);
		this.RefreshRolePerformance();
	}

	// Token: 0x060140DB RID: 82139 RVA: 0x005D6FEC File Offset: 0x005D51EC
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

	// Token: 0x060140DC RID: 82140 RVA: 0x005D7030 File Offset: 0x005D5230
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

	// Token: 0x0400AA8F RID: 43663
	private EquipBuffItemDetailViewData ViewData;

	// Token: 0x0400AA90 RID: 43664
	private int CurrentSkinTypeIndex;

	// Token: 0x0400AA91 RID: 43665
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AA92 RID: 43666
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400AA93 RID: 43667
	private FVector? CurrentDragPosition;

	// Token: 0x0400AA94 RID: 43668
	private UiCameraInputComponent UiCameraInputComponent;

	// Token: 0x0400AA95 RID: 43669
	private UiCameraLogicComponent UiCameraLogicComponent;

	// Token: 0x0400AA96 RID: 43670
	private float LastSwitchTime;

	// Token: 0x0400AA97 RID: 43671
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

	// Token: 0x0200829E RID: 33438
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A2BF RID: 172735
		CaptionItem,
		// Token: 0x0402A2C0 RID: 172736
		OnlyUiToggle,
		// Token: 0x0402A2C1 RID: 172737
		DetailIconButton,
		// Token: 0x0402A2C2 RID: 172738
		ButtonLeft,
		// Token: 0x0402A2C3 RID: 172739
		ButtonRight,
		// Token: 0x0402A2C4 RID: 172740
		TitleText,
		// Token: 0x0402A2C5 RID: 172741
		SubTitleText,
		// Token: 0x0402A2C6 RID: 172742
		SwitchItem,
		// Token: 0x0402A2C7 RID: 172743
		ToggleLeft,
		// Token: 0x0402A2C8 RID: 172744
		ExtraRewardItem,
		// Token: 0x0402A2C9 RID: 172745
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402A2CA RID: 172746
		RewardItem,
		// Token: 0x0402A2CB RID: 172747
		DescText,
		// Token: 0x0402A2CC RID: 172748
		NotHaveRoleItem,
		// Token: 0x0402A2CD RID: 172749
		BuyItemIcon,
		// Token: 0x0402A2CE RID: 172750
		NowPrice,
		// Token: 0x0402A2CF RID: 172751
		BeforePrice,
		// Token: 0x0402A2D0 RID: 172752
		BuyButton,
		// Token: 0x0402A2D1 RID: 172753
		DiscountItem,
		// Token: 0x0402A2D2 RID: 172754
		DiscountText,
		// Token: 0x0402A2D3 RID: 172755
		LeftTimeItem,
		// Token: 0x0402A2D4 RID: 172756
		LeftTimeText,
		// Token: 0x0402A2D5 RID: 172757
		QualityTexture,
		// Token: 0x0402A2D6 RID: 172758
		RoleTexture,
		// Token: 0x0402A2D7 RID: 172759
		FrameTexture,
		// Token: 0x0402A2D8 RID: 172760
		WeaponRootItem,
		// Token: 0x0402A2D9 RID: 172761
		WeaponTexture,
		// Token: 0x0402A2DA RID: 172762
		HaveItem,
		// Token: 0x0402A2DB RID: 172763
		HideUiParentItem,
		// Token: 0x0402A2DC RID: 172764
		DragComponent,
		// Token: 0x0402A2DD RID: 172765
		WeaponQualityTexture,
		// Token: 0x0402A2DE RID: 172766
		ToggleRight,
		// Token: 0x0402A2DF RID: 172767
		EffectItemB,
		// Token: 0x0402A2E0 RID: 172768
		EffectItemA,
		// Token: 0x0402A2E1 RID: 172769
		TextureToggleLeft,
		// Token: 0x0402A2E2 RID: 172770
		TextToggleLeft,
		// Token: 0x0402A2E3 RID: 172771
		TextureToggleRight,
		// Token: 0x0402A2E4 RID: 172772
		TextToggleRight,
		// Token: 0x0402A2E5 RID: 172773
		ItemNonCouponPrice,
		// Token: 0x0402A2E6 RID: 172774
		ItemCouponPrice,
		// Token: 0x0402A2E7 RID: 172775
		TextCouponPrice,
		// Token: 0x0402A2E8 RID: 172776
		TextureCouponIcon,
		// Token: 0x0402A2E9 RID: 172777
		TextOriginPrice,
		// Token: 0x0402A2EA RID: 172778
		TexturePriceIcon,
		// Token: 0x0402A2EB RID: 172779
		TextCurPrice,
		// Token: 0x0402A2EC RID: 172780
		ItemGamePadKeyTipA,
		// Token: 0x0402A2ED RID: 172781
		ItemGamePadKeyTipB,
		// Token: 0x0402A2EE RID: 172782
		ToggleLayout,
		// Token: 0x0402A2EF RID: 172783
		ToggleMale,
		// Token: 0x0402A2F0 RID: 172784
		ToggleFemale,
		// Token: 0x0402A2F1 RID: 172785
		ExtraRewardText,
		// Token: 0x0402A2F2 RID: 172786
		ItemPanelBuy,
		// Token: 0x0402A2F3 RID: 172787
		ItemPanelRole,
		// Token: 0x0402A2F4 RID: 172788
		ItemPanelLeftDownBtn
	}
}
