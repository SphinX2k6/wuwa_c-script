using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A2C RID: 10796
[NullableContext(2)]
[Nullable(0)]
public class RoleOrnamentShowView : UiTickViewBase
{
	// Token: 0x17001DD7 RID: 7639
	// (get) Token: 0x0601674C RID: 91980 RVA: 0x005AF8D7 File Offset: 0x005ADAD7
	private bool IsBuyPreview
	{
		get
		{
			return this.ShopRoleOrnamentData != null;
		}
	}

	// Token: 0x0601674D RID: 91981 RVA: 0x005AF8E2 File Offset: 0x005ADAE2
	[NullableContext(1)]
	public RoleOrnamentShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601674E RID: 91982 RVA: 0x005AF8F8 File Offset: 0x005ADAF8
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
			new ValueTuple<int, Type>(45, typeof(UUIItem)),
			new ValueTuple<int, Type>(46, typeof(UUIItem)),
			new ValueTuple<int, Type>(51, typeof(UUIItem)),
			new ValueTuple<int, Type>(52, typeof(UUIItem)),
			new ValueTuple<int, Type>(53, typeof(UUIItem)),
			new ValueTuple<int, Type>(54, typeof(UUIItem)),
			new ValueTuple<int, Type>(55, typeof(UUITexture)),
			new ValueTuple<int, Type>(56, typeof(UUIItem)),
			new ValueTuple<int, Type>(57, typeof(UUIText)),
			new ValueTuple<int, Type>(58, typeof(UUIText)),
			new ValueTuple<int, Type>(60, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickOnlyUiToggle)),
			new ValueTuple<int, Delegate>(17, new Action(this.OnClickBuyButton))
		};
	}

	// Token: 0x0601674F RID: 91983 RVA: 0x005AFDAC File Offset: 0x005ADFAC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.OnPayShopGoodsBuy));
		EventSystem.Instance.Add(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06016750 RID: 91984 RVA: 0x005AFE10 File Offset: 0x005AE010
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.OnPayShopGoodsBuy));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06016751 RID: 91985 RVA: 0x005AFE74 File Offset: 0x005AE074
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		RoleOrnamentShowView.<OnHandlePostLoadSceneAsync>d__20 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<RoleOrnamentShowView.<OnHandlePostLoadSceneAsync>d__20>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016752 RID: 91986 RVA: 0x005AFEB8 File Offset: 0x005AE0B8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleOrnamentShowView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleOrnamentShowView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016753 RID: 91987 RVA: 0x005AFEFC File Offset: 0x005AE0FC
	protected override void OnStart()
	{
		this.InitData();
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseView));
		this.CaptionItem.SetTitleLocalText("UiDynamicTab_222_TabName");
		this.CaptionItem.SetTitleIcon("/Game/Aki/UI/UIResources/Common/Atlas/TabIcon/SP_IconRoleAccessoriesSkin.SP_IconRoleAccessoriesSkin");
		bool isBuyPreview = this.IsBuyPreview;
		this.CaptionItem.SetHelpBtnActive(isBuyPreview);
		this.CaptionItem.SetHomeBtnShowState(isBuyPreview);
		if (isBuyPreview)
		{
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
		}
		base.GetItem(7).SetUIActive(false);
		base.GetItem(25).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
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
		UUIItem item3 = base.GetItem(54);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIButtonComponent button2 = base.GetButton(4);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(51);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		base.GetItem(9).SetUIActive(false);
		base.GetTexture(55).SetUIActive(true);
		base.GetItem(56).SetUIActive(false);
		base.GetText(16).SetUIActive(false);
		base.GetItem(27).SetUIActive(false);
		base.GetButton(17).RootUIComp.Get().SetUIActive(false);
		this.ExtraRewardLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(10), new Func<SkinRewardItemGrid>(this.InitExtraRewardGridItem), null, false, true);
	}

	// Token: 0x06016754 RID: 91988 RVA: 0x005B00E7 File Offset: 0x005AE2E7
	[NullableContext(1)]
	private SkinRewardItemGrid InitExtraRewardGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x06016755 RID: 91989 RVA: 0x005B00F0 File Offset: 0x005AE2F0
	protected override void OnBeforeDestroy()
	{
		if (this.TsUiSceneRoleActor != null)
		{
			UiModelBase model = this.TsUiSceneRoleActor.Model;
			if (model != null)
			{
				UiModelUtil.RefreshRoleOrnaments(model, null, true);
			}
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		}
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x06016756 RID: 91990 RVA: 0x005B0134 File Offset: 0x005AE334
	protected override void OnHandleReleaseScene()
	{
		UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
	}

	// Token: 0x06016757 RID: 91991 RVA: 0x005B014C File Offset: 0x005AE34C
	protected override void OnBeforeShow()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		if (((tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null) != null)
		{
			UiModelUtil.Instance.SetVisible(this.TsUiSceneRoleActor.Model, true);
		}
		this.TryPushCamera(false);
		this.RefreshView();
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
		this.TryPlayRoleMontage();
	}

	// Token: 0x06016758 RID: 91992 RVA: 0x005B01AE File Offset: 0x005AE3AE
	protected override void OnAfterHide()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		if (((tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null) != null)
		{
			UiModelUtil.Instance.SetVisible(this.TsUiSceneRoleActor.Model, false);
		}
	}

	// Token: 0x06016759 RID: 91993 RVA: 0x005B01DB File Offset: 0x005AE3DB
	protected override void OnBeforeHide()
	{
		this.CameraInputComponent.End();
	}

	// Token: 0x0601675A RID: 91994 RVA: 0x005B01E8 File Offset: 0x005AE3E8
	private void InitData()
	{
		RoleOrnamentShowViewParams roleOrnamentShowViewParams = (RoleOrnamentShowViewParams)this.OpenParam;
		this.OrnamentId = roleOrnamentShowViewParams.OrnamentId;
		this.ShopRoleOrnamentData = roleOrnamentShowViewParams.BuyDetailData;
		int? skinId = roleOrnamentShowViewParams.SkinId;
		if (skinId != null)
		{
			this.SkinId = skinId.Value;
		}
		else
		{
			foreach (int num in RoleOrnamentModel.Instance.GetRoleOrnamentData(this.OrnamentId).GetRoleSkinIds())
			{
				int roleId = RoleSkinModel.Instance.GetRoleSkinData(num).GetRoleId();
				if (!RoleModel.Instance.IsMainRole(roleId))
				{
					skinId = new int?(num);
					break;
				}
				int num2 = roleId;
				int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
				if (num2 == curSelectMainRoleId.GetValueOrDefault() & curSelectMainRoleId != null)
				{
					skinId = new int?(num);
					break;
				}
			}
			int[] roleSkinIds;
			this.SkinId = (skinId ?? roleSkinIds[0]);
		}
		this.ResolvedRoleId = RoleSkinModel.Instance.GetRoleSkinData(this.SkinId).GetRoleId();
		if (roleOrnamentShowViewParams.SkinId == null && UiSceneManager.Instance.HasRoleSystemRoleActor())
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			UiRoleDataComponent uiRoleDataComponent;
			if (roleSystemRoleActor == null)
			{
				uiRoleDataComponent = null;
			}
			else
			{
				UiModelBase model = roleSystemRoleActor.Model;
				uiRoleDataComponent = ((model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null);
			}
			UiRoleDataComponent uiRoleDataComponent2 = uiRoleDataComponent;
			if (uiRoleDataComponent2 != null && uiRoleDataComponent2.RoleConfigId == this.ResolvedRoleId)
			{
				this.SkinId = uiRoleDataComponent2.RoleSkinId;
			}
		}
	}

	// Token: 0x0601675B RID: 91995 RVA: 0x005B0354 File Offset: 0x005AE554
	private void TryPushCamera(bool useBlend = true)
	{
		Ornament? ornamentConfig = RoleConfig.Instance.GetOrnamentConfig(this.OrnamentId);
		if (ornamentConfig == null)
		{
			return;
		}
		Ornament value = ornamentConfig.Value;
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(this.SkinId);
		if (roleSkinConfig == null)
		{
			return;
		}
		RoleSkin value2 = roleSkinConfig.Value;
		string text;
		if (this.IsHidingUi())
		{
			if (!RoleModel.Instance.IsMainRole(value2.RoleId))
			{
				text = (value.HideUiCamera(0) ?? string.Empty);
			}
			else
			{
				text = ((RoleConfig.Instance.GetMainRoleById(value2.RoleId).Value.Gender == 1) ? (value.HideUiCamera(0) ?? string.Empty) : (value.HideUiCamera(1) ?? string.Empty));
			}
		}
		else if (!RoleModel.Instance.IsMainRole(value2.RoleId))
		{
			text = (value.UiCamera(0) ?? string.Empty);
		}
		else
		{
			text = ((RoleConfig.Instance.GetMainRoleById(value2.RoleId).Value.Gender == 1) ? (value.UiCamera(0) ?? string.Empty) : (value.UiCamera(1) ?? string.Empty));
		}
		string viewName = "RoleOrnamentShowView";
		UiCameraHandleData uiCameraHandleData = UiCameraHandleData.NewByHandleName(text, null);
		uiCameraHandleData.ViewName = text;
		uiCameraHandleData.OwnerViewName = viewName;
		if (useBlend)
		{
			UiLayer.Instance.SetShowMaskLayer(viewName, true);
			UiCameraAnimationManager.Instance.PushCameraHandle(uiCameraHandleData, true, true, "1001", true, delegate(UiCameraAnimationDefine.IFinishData _)
			{
				UiLayer.Instance.SetShowMaskLayer(viewName, false);
			});
			return;
		}
		UiCameraAnimationManager.Instance.PushCameraHandle(uiCameraHandleData, false, false, null, false, null);
	}

	// Token: 0x0601675C RID: 91996 RVA: 0x005B0520 File Offset: 0x005AE720
	[NullableContext(1)]
	private IUiCameraInputComponentData GetCameraInputData()
	{
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(this.OrnamentId).Value;
		string text = this.IsHidingUi() ? value.HideUiCameraConfig : value.UiCameraConfig;
		if (string.IsNullOrEmpty(text))
		{
			text = PayShopConfig.Instance.GetBuySkinDetailRoleCameraConfigId();
		}
		string text2 = this.IsHidingUi() ? value.HideUiCameraOffsetConfig : value.UiCameraOffsetConfig;
		SUiRoleCameraSetting value2 = UiRoleCameraConfig.Instance.GetRoleCameraConfig(text).Value;
		SUiRoleCameraOffsetSetting? cameraOffsetConfig = null;
		if (!string.IsNullOrEmpty(text2))
		{
			SUiRoleCameraOffsetSetting? roleCameraOffsetConfig = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(text2);
			if (roleCameraOffsetConfig != null)
			{
				cameraOffsetConfig = new SUiRoleCameraOffsetSetting?(roleCameraOffsetConfig.Value);
			}
		}
		FVectorDouble fvectorDouble = this.TsUiSceneRoleActor.D_K2_GetActorLocation();
		return new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = value2,
			CameraOffsetConfig = cameraOffsetConfig,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x0601675D RID: 91997 RVA: 0x005B0614 File Offset: 0x005AE814
	private void InitCameraInputData()
	{
		IUiCameraInputComponentData cameraInputData = this.GetCameraInputData();
		this.CameraInputComponent.InitData(cameraInputData);
		this.CameraInputComponent.CanCameraInput = this.IsAllowCameraRotate();
	}

	// Token: 0x0601675E RID: 91998 RVA: 0x005B0648 File Offset: 0x005AE848
	private void UpdateCameraInputData()
	{
		IUiCameraInputComponentData cameraInputData = this.GetCameraInputData();
		this.CameraInputComponent.UpdateData(cameraInputData);
		this.CameraInputComponent.CanCameraInput = this.IsAllowCameraRotate();
	}

	// Token: 0x0601675F RID: 91999 RVA: 0x005B067C File Offset: 0x005AE87C
	private void RefreshView()
	{
		if (this.OrnamentId == 0)
		{
			return;
		}
		ShopRoleOrnamentData shopRoleOrnamentData = this.ShopRoleOrnamentData;
		if (shopRoleOrnamentData != null)
		{
			PayShopGoods payShopGoods = shopRoleOrnamentData.GetPayShopGoods();
			if (payShopGoods != null)
			{
				payShopGoods.SaveRemindState((long)TimeUtil.Instance.GetServerTime());
			}
		}
		RoleOrnamentData roleOrnamentData = RoleOrnamentModel.Instance.GetRoleOrnamentData(this.OrnamentId);
		base.GetItem(33).SetUIActive(false);
		base.GetItem(32).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), roleOrnamentData.GetName(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), roleOrnamentData.GetSubTitle(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), roleOrnamentData.GetBgDescription(), Array.Empty<object>());
		base.SetTextureByPath(roleOrnamentData.GetPreviewTextureInBuyView(), base.GetTexture(23), null, null);
		base.SetTextureByPath(roleOrnamentData.GetBuyPreviewQualityBgPath(), base.GetTexture(22), null, null);
		base.GetItem(18).SetUIActive(false);
		base.GetItem(20).SetUIActive(false);
		this.RefreshBuyPart();
		this.RefreshExtraReward();
		this.RefreshSellCountDown();
	}

	// Token: 0x06016760 RID: 92000 RVA: 0x005B07A8 File Offset: 0x005AE9A8
	private void RefreshExtraReward()
	{
		ShopRoleOrnamentData shopRoleOrnamentData = this.ShopRoleOrnamentData;
		List<ValueTuple<int, int>> list = (shopRoleOrnamentData != null) ? shopRoleOrnamentData.GetOtherRewardSimple() : null;
		List<SkinRewardData> list2 = new List<SkinRewardData>();
		if (list != null)
		{
			foreach (ValueTuple<int, int> valueTuple in list)
			{
				list2.Add(new SkinRewardData
				{
					ItemData = new TItem?(new TItem(new InventoryDefine.GetItemData(valueTuple.Item1, 0), valueTuple.Item2)),
					FinishState = (shopRoleOrnamentData != null && !shopRoleOrnamentData.GetIfCanBuy())
				});
			}
		}
		bool flag = list2.Count != 0;
		GenericLayout<SkinRewardItemGrid, SkinRewardData> extraRewardLayout = this.ExtraRewardLayout;
		if (extraRewardLayout != null)
		{
			extraRewardLayout.SetActive(flag);
		}
		base.GetItem(9).SetUIActive(flag);
		if (!flag)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(50), "PrefabTextitem_RoleSkinExtraAcquisition_Text", Array.Empty<object>());
		GenericLayout<SkinRewardItemGrid, SkinRewardData> extraRewardLayout2 = this.ExtraRewardLayout;
		if (extraRewardLayout2 == null)
		{
			return;
		}
		extraRewardLayout2.RefreshByData(list2, null, false);
	}

	// Token: 0x06016761 RID: 92001 RVA: 0x005B08B8 File Offset: 0x005AEAB8
	private void RefreshSellCountDown()
	{
		UUIItem item = base.GetItem(56);
		UUIText text = base.GetText(57);
		ShopRoleOrnamentData shopRoleOrnamentData = this.ShopRoleOrnamentData;
		if (shopRoleOrnamentData == null)
		{
			item.SetUIActive(false);
			return;
		}
		PayShopGoods currentGoodsData = shopRoleOrnamentData.GetCurrentGoodsData();
		if (currentGoodsData.HasDiscount() || !currentGoodsData.InUnPermanentSellTime())
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		text.SetUIActive(true);
		CommonDefine.IPayShowCountDownRemainTime endTimeRemainData = currentGoodsData.GetEndTimeRemainData();
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = endTimeRemainData as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime != null)
		{
			text.SetText(payShowCountDownRemainTime.Value, true);
			return;
		}
		CommonDefine.IRemainTime remainTime = endTimeRemainData as CommonDefine.IRemainTime;
		if (remainTime != null)
		{
			LguiUtil.Instance.SetLocalText(text, remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
		}
	}

	// Token: 0x06016762 RID: 92002 RVA: 0x005B096C File Offset: 0x005AEB6C
	private void RefreshOrnamentModel()
	{
		if (base.IsDestroyOrDestroying || this.TsUiSceneRoleActor == null)
		{
			return;
		}
		OrnamentModelContext[] contexts = new OrnamentModelContext[]
		{
			UiModelUtil.BuildOrnamentModelContext(this.SkinId, this.OrnamentId)
		};
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		if (model == null)
		{
			return;
		}
		UiRoleOrnamentComponent uiRoleOrnamentComponent = model.CheckGetComponent<UiRoleOrnamentComponent>();
		if (uiRoleOrnamentComponent == null)
		{
			return;
		}
		uiRoleOrnamentComponent.RefreshModels(contexts, false);
	}

	// Token: 0x06016763 RID: 92003 RVA: 0x005B09C8 File Offset: 0x005AEBC8
	private bool IsAllowCameraRotate()
	{
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(this.OrnamentId).Value;
		if (!this.IsHidingUi())
		{
			return value.AllowUiCameraRotate;
		}
		return value.AllowHideUiCameraRotate;
	}

	// Token: 0x06016764 RID: 92004 RVA: 0x005B0A05 File Offset: 0x005AEC05
	private bool IsHidingUi()
	{
		return base.GetExtendToggle(1).GetToggleState() == EToggleState.ETT_Checked;
	}

	// Token: 0x06016765 RID: 92005 RVA: 0x005B0A18 File Offset: 0x005AEC18
	private void TryPlayRoleMontage()
	{
		if (RoleConfig.Instance.GetOrnamentConfig(this.OrnamentId).Value.UiRoleState != 0)
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Favor, false, false, false);
			return;
		}
		RoleController.Instance.SetInstantAttributeBlend(RoleUtils.NeedInstantAttributeBlend(this.ResolvedRoleId));
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
	}

	// Token: 0x06016766 RID: 92006 RVA: 0x005B0A7A File Offset: 0x005AEC7A
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016767 RID: 92007 RVA: 0x005B0A84 File Offset: 0x005AEC84
	protected override void OnTick(float delta)
	{
		if (!this.IsBuyPreview)
		{
			return;
		}
		ShopRoleOrnamentData shopRoleOrnamentData = this.ShopRoleOrnamentData;
		PayShopGoods payShopGoods = (shopRoleOrnamentData != null) ? shopRoleOrnamentData.GetCurrentGoodsData() : null;
		if (payShopGoods == null)
		{
			return;
		}
		PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
		int num = (goodsData != null) ? goodsData.Id : 0;
		bool flag = payShopGoods.HasDiscount();
		bool flag2 = payShopGoods.InSellTime();
		if (this.CurrentPayItemId != num)
		{
			this.CurrentPayItemId = num;
			this.CurrentDiscountState = flag;
			this.CurrentInSellTime = flag2;
		}
		if (this.CurrentDiscountState == flag && this.CurrentInSellTime == flag2)
		{
			return;
		}
		this.CurrentDiscountState = flag;
		this.CurrentInSellTime = flag2;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			base.CloseMe(null);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06016768 RID: 92008 RVA: 0x005B0B44 File Offset: 0x005AED44
	private void OnClickOnlyUiToggle(EToggleState toggleState)
	{
		bool state = base.GetItem(28).bIsUIActive;
		if (!state)
		{
			base.GetItem(28).SetUIActive(!state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
		}
		else
		{
			base.PlaySequence("UiOut", delegate
			{
				if (this.IsDestroyOrDestroying)
				{
					return;
				}
				this.GetItem(28).SetUIActive(!state);
			}, true);
		}
		UUIItem item = base.GetItem(54);
		if (item != null)
		{
			item.SetUIActive(state);
		}
		this.TryPushCamera(true);
		this.UpdateCameraInputData();
	}

	// Token: 0x06016769 RID: 92009 RVA: 0x005B0BFC File Offset: 0x005AEDFC
	private bool GetIfHaveRoleForCurrentOrnament()
	{
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(this.SkinId);
		int? num = (roleSkinData != null) ? new int?(roleSkinData.GetRoleId()) : null;
		return num == null || RoleModel.Instance.GetRoleInstanceById(num.Value) != null;
	}

	// Token: 0x0601676A RID: 92010 RVA: 0x005B0C52 File Offset: 0x005AEE52
	[NullableContext(1)]
	private void StartBuyProcess(PayShopGoods goods)
	{
		if (goods.IfPayGift())
		{
			PayGiftController.Instance.SdkPay(goods.GetGoodsId());
			return;
		}
		PayShopController.Instance.OpenBuyViewByGoodsId(goods, null);
	}

	// Token: 0x0601676B RID: 92011 RVA: 0x005B0C7C File Offset: 0x005AEE7C
	private void RefreshBuyButtonState(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetButton(17).RootUIComp.Get().SetUIActive(false);
			return;
		}
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetButton(17).RootUIComp.Get().SetUIActive(ifCanBuy);
	}

	// Token: 0x0601676C RID: 92012 RVA: 0x005B0CCC File Offset: 0x005AEECC
	private void RefreshHaveItem(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetItem(27).SetUIActive(false);
			return;
		}
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetItem(27).SetUIActive(!ifCanBuy);
	}

	// Token: 0x0601676D RID: 92013 RVA: 0x005B0D04 File Offset: 0x005AEF04
	private void RefreshNotHaveRoleItem(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetItem(13).SetUIActive(false);
			return;
		}
		bool ifHaveRoleForCurrentOrnament = this.GetIfHaveRoleForCurrentOrnament();
		base.GetItem(13).SetUIActive(!ifHaveRoleForCurrentOrnament);
	}

	// Token: 0x0601676E RID: 92014 RVA: 0x005B0D3C File Offset: 0x005AEF3C
	private void RefreshBuyItemIcon()
	{
		UUITexture texture = base.GetTexture(14);
		if (texture == null || this.ShopRoleOrnamentData == null)
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			return;
		}
		bool ifDirect = this.ShopRoleOrnamentData.GetIfDirect();
		texture.SetUIActive(!ifDirect);
		if (!ifDirect)
		{
			IPriceData priceData = this.ShopRoleOrnamentData.GetPriceData();
			base.SetItemIcon(texture, priceData.CurrencyId, null, null);
		}
	}

	// Token: 0x0601676F RID: 92015 RVA: 0x005B0DA4 File Offset: 0x005AEFA4
	private void RefreshBuyPart()
	{
		if (this.ShopRoleOrnamentData == null)
		{
			base.GetItem(51).SetUIActive(false);
			return;
		}
		bool ifCanBuy = this.ShopRoleOrnamentData.GetIfCanBuy();
		base.GetItem(51).SetUIActive(ifCanBuy);
		this.RefreshBuyItemIcon();
		bool ifDirect = this.ShopRoleOrnamentData.GetIfDirect();
		base.GetText(58).SetUIActive(ifDirect);
		base.GetText(15).SetUIActive(true);
		if (ifDirect)
		{
			string directPriceText = this.ShopRoleOrnamentData.GetDirectPriceText();
			base.GetText(15).SetText(directPriceText, true);
		}
		else
		{
			IPriceData priceData = this.ShopRoleOrnamentData.GetPriceData();
			base.GetText(15).SetText(priceData.NowPrice.ToString(), true);
		}
		this.RefreshBuyButtonState(this.ShopRoleOrnamentData);
		this.RefreshHaveItem(this.ShopRoleOrnamentData);
		this.RefreshNotHaveRoleItem(this.ShopRoleOrnamentData);
		TotalTopUpPayAdditiveTagItem totalTopUpTagItem = this.TotalTopUpTagItem;
		if (totalTopUpTagItem == null)
		{
			return;
		}
		totalTopUpTagItem.RefreshByGoodsId(this.ShopRoleOrnamentData.GetCurrentGoodsData().GetGoodsId());
	}

	// Token: 0x06016770 RID: 92016 RVA: 0x005B0EA0 File Offset: 0x005AF0A0
	private void OnClickBuyButton()
	{
		ShopRoleOrnamentData shopRoleOrnamentData = this.ShopRoleOrnamentData;
		if (shopRoleOrnamentData == null || !shopRoleOrnamentData.GetIfCanBuy())
		{
			return;
		}
		PayShopGoods goods = shopRoleOrnamentData.GetPayShopGoods();
		goods.SaveRemindState((long)TimeUtil.Instance.GetServerTime());
		if (!this.GetIfHaveRoleForCurrentOrnament())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.NoRoleBuySkin);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.StartBuyProcess(goods);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.StartBuyProcess(goods);
	}

	// Token: 0x06016771 RID: 92017 RVA: 0x005B0F33 File Offset: 0x005AF133
	[NullableContext(1)]
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x06016772 RID: 92018 RVA: 0x005B0F3B File Offset: 0x005AF13B
	private void OnPayShopGoodsBuy()
	{
		this.RefreshView();
	}

	// Token: 0x06016773 RID: 92019 RVA: 0x005B0F44 File Offset: 0x005AF144
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		ShopRoleOrnamentData shopRoleOrnamentData = this.ShopRoleOrnamentData;
		int? num;
		if (shopRoleOrnamentData == null)
		{
			num = null;
		}
		else
		{
			PayShopGoods payShopGoods = shopRoleOrnamentData.GetPayShopGoods();
			num = ((payShopGoods != null) ? new int?(payShopGoods.GetGoodsId()) : null);
		}
		int? num2 = num;
		if (num2 != null)
		{
			int? num3 = num2;
			if (goodsId == num3.GetValueOrDefault() & num3 != null)
			{
				this.RefreshView();
				return;
			}
		}
	}

	// Token: 0x06016774 RID: 92020 RVA: 0x005B0FAB File Offset: 0x005AF1AB
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(627);
	}

	// Token: 0x0400A6DE RID: 42718
	private const int SHOP_HELP_ID = 627;

	// Token: 0x0400A6DF RID: 42719
	private int SkinId;

	// Token: 0x0400A6E0 RID: 42720
	private int OrnamentId;

	// Token: 0x0400A6E1 RID: 42721
	private int ResolvedRoleId;

	// Token: 0x0400A6E2 RID: 42722
	[Nullable(1)]
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0400A6E3 RID: 42723
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A6E4 RID: 42724
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400A6E5 RID: 42725
	private ShopRoleOrnamentData ShopRoleOrnamentData;

	// Token: 0x0400A6E6 RID: 42726
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ExtraRewardLayout;

	// Token: 0x0400A6E7 RID: 42727
	private int CurrentPayItemId;

	// Token: 0x0400A6E8 RID: 42728
	private bool CurrentDiscountState;

	// Token: 0x0400A6E9 RID: 42729
	private bool CurrentInSellTime;

	// Token: 0x0400A6EA RID: 42730
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x02009068 RID: 36968
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402EC96 RID: 191638
		CaptionItem,
		// Token: 0x0402EC97 RID: 191639
		OnlyUiToggle,
		// Token: 0x0402EC98 RID: 191640
		DetailIconButton,
		// Token: 0x0402EC99 RID: 191641
		ButtonLeft,
		// Token: 0x0402EC9A RID: 191642
		ButtonRight,
		// Token: 0x0402EC9B RID: 191643
		TitleText,
		// Token: 0x0402EC9C RID: 191644
		SubTitleText,
		// Token: 0x0402EC9D RID: 191645
		SwitchItem,
		// Token: 0x0402EC9E RID: 191646
		ToggleLeft,
		// Token: 0x0402EC9F RID: 191647
		ExtraRewardItem,
		// Token: 0x0402ECA0 RID: 191648
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402ECA1 RID: 191649
		RewardItem,
		// Token: 0x0402ECA2 RID: 191650
		DescText,
		// Token: 0x0402ECA3 RID: 191651
		NotHaveRoleItem,
		// Token: 0x0402ECA4 RID: 191652
		BuyItemIcon,
		// Token: 0x0402ECA5 RID: 191653
		NowPrice,
		// Token: 0x0402ECA6 RID: 191654
		BeforePrice,
		// Token: 0x0402ECA7 RID: 191655
		BuyButton,
		// Token: 0x0402ECA8 RID: 191656
		DiscountItem,
		// Token: 0x0402ECA9 RID: 191657
		DiscountText,
		// Token: 0x0402ECAA RID: 191658
		LeftTimeItem,
		// Token: 0x0402ECAB RID: 191659
		LeftTimeText,
		// Token: 0x0402ECAC RID: 191660
		QualityTexture,
		// Token: 0x0402ECAD RID: 191661
		ItemTexture,
		// Token: 0x0402ECAE RID: 191662
		FrameTexture,
		// Token: 0x0402ECAF RID: 191663
		WeaponRootItem,
		// Token: 0x0402ECB0 RID: 191664
		WeaponTexture,
		// Token: 0x0402ECB1 RID: 191665
		HaveItem,
		// Token: 0x0402ECB2 RID: 191666
		HideUiParentItem,
		// Token: 0x0402ECB3 RID: 191667
		DragComponent,
		// Token: 0x0402ECB4 RID: 191668
		WeaponQualityTexture,
		// Token: 0x0402ECB5 RID: 191669
		ToggleRight,
		// Token: 0x0402ECB6 RID: 191670
		EffectItemB,
		// Token: 0x0402ECB7 RID: 191671
		EffectItemA,
		// Token: 0x0402ECB8 RID: 191672
		TextureToggleLeft,
		// Token: 0x0402ECB9 RID: 191673
		TextToggleLeft,
		// Token: 0x0402ECBA RID: 191674
		TextureToggleRight,
		// Token: 0x0402ECBB RID: 191675
		TextToggleRight,
		// Token: 0x0402ECBC RID: 191676
		ItemGamePadKeyTipA = 45,
		// Token: 0x0402ECBD RID: 191677
		ItemGamePadKeyTipB,
		// Token: 0x0402ECBE RID: 191678
		ToggleLayout,
		// Token: 0x0402ECBF RID: 191679
		ToggleMale,
		// Token: 0x0402ECC0 RID: 191680
		ToggleFemale,
		// Token: 0x0402ECC1 RID: 191681
		ExtraRewardText,
		// Token: 0x0402ECC2 RID: 191682
		ItemBuyPanel,
		// Token: 0x0402ECC3 RID: 191683
		ItemRolePanel,
		// Token: 0x0402ECC4 RID: 191684
		ItemBottomLeftPanel,
		// Token: 0x0402ECC5 RID: 191685
		ItemGamePadKeyTipC,
		// Token: 0x0402ECC6 RID: 191686
		SpecialBgTexture,
		// Token: 0x0402ECC7 RID: 191687
		ItemCountDownPanel,
		// Token: 0x0402ECC8 RID: 191688
		TextCountDown,
		// Token: 0x0402ECC9 RID: 191689
		TextDirectTips,
		// Token: 0x0402ECCA RID: 191690
		ItemTagRoot = 60
	}
}
