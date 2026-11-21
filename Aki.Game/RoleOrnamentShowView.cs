using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FA7 RID: 8103
[NullableContext(2)]
[Nullable(0)]
public class RoleOrnamentShowView : UiTickViewBase, IUiViewCameraBehavior
{
	// Token: 0x17001E2F RID: 7727
	// (get) Token: 0x06014152 RID: 82258 RVA: 0x005DA8C7 File Offset: 0x005D8AC7
	private bool IsBuyPreview
	{
		get
		{
			return this.ShopRoleOrnamentData != null;
		}
	}

	// Token: 0x06014153 RID: 82259 RVA: 0x005DA8D2 File Offset: 0x005D8AD2
	[NullableContext(1)]
	public RoleOrnamentShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014154 RID: 82260 RVA: 0x005DA8E8 File Offset: 0x005D8AE8
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		IReadOnlyList<UiCameraHandleData> normalHandleStack = UiCameraModel.Instance.NormalHandleStack;
		for (int i = 0; i < normalHandleStack.Count; i++)
		{
			int? viewId2 = normalHandleStack[i].GetViewId();
			if (viewId2.GetValueOrDefault() == viewId & viewId2 != null)
			{
				return;
			}
		}
		UiCameraHandleData uiCameraHandleData = this.CreateCameraHandleData();
		if (uiCameraHandleData == null)
		{
			return;
		}
		uiCameraHandleData.SetViewId(new int?(viewId));
		UiCameraModel.Instance.PushCameraHandle(uiCameraHandleData, false, false, null, false, null);
	}

	// Token: 0x06014155 RID: 82261 RVA: 0x005DA95F File Offset: 0x005D8B5F
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PopCameraHandleByCloseView(viewName, nextViewName, closeViewId, operationType);
	}

	// Token: 0x06014156 RID: 82262 RVA: 0x005DA970 File Offset: 0x005D8B70
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

	// Token: 0x06014157 RID: 82263 RVA: 0x005DAE24 File Offset: 0x005D9024
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.OnPayShopGoodsBuy));
		EventSystem.Instance.Add(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06014158 RID: 82264 RVA: 0x005DAE88 File Offset: 0x005D9088
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.OnPayShopGoodsBuy));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06014159 RID: 82265 RVA: 0x005DAEEC File Offset: 0x005D90EC
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		RoleOrnamentShowView.<OnHandlePostLoadSceneAsync>d__22 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<RoleOrnamentShowView.<OnHandlePostLoadSceneAsync>d__22>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601415A RID: 82266 RVA: 0x005DAF30 File Offset: 0x005D9130
	protected override UniTask OnBeforeStartAsync()
	{
		RoleOrnamentShowView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleOrnamentShowView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601415B RID: 82267 RVA: 0x005DAF74 File Offset: 0x005D9174
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

	// Token: 0x0601415C RID: 82268 RVA: 0x005DB15F File Offset: 0x005D935F
	[NullableContext(1)]
	private SkinRewardItemGrid InitExtraRewardGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x0601415D RID: 82269 RVA: 0x005DB168 File Offset: 0x005D9368
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

	// Token: 0x0601415E RID: 82270 RVA: 0x005DB1AC File Offset: 0x005D93AC
	protected override void OnHandleReleaseScene()
	{
	}

	// Token: 0x0601415F RID: 82271 RVA: 0x005DB1B0 File Offset: 0x005D93B0
	protected override void OnBeforeShow()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		if (((tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null) != null)
		{
			UiModelUtil.Instance.SetVisible(this.TsUiSceneRoleActor.Model, true);
		}
		this.RefreshView();
		if (this.IsAllowCameraRotate())
		{
			this.CameraInputBinding.Bind();
		}
		this.TryPlayRoleMontage();
	}

	// Token: 0x06014160 RID: 82272 RVA: 0x005DB207 File Offset: 0x005D9407
	protected override void OnAfterHide()
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		if (((tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null) != null)
		{
			UiModelUtil.Instance.SetVisible(this.TsUiSceneRoleActor.Model, false);
		}
	}

	// Token: 0x06014161 RID: 82273 RVA: 0x005DB234 File Offset: 0x005D9434
	protected override void OnBeforeHide()
	{
		this.CameraInputBinding.Unbind();
	}

	// Token: 0x06014162 RID: 82274 RVA: 0x005DB244 File Offset: 0x005D9444
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

	// Token: 0x06014163 RID: 82275 RVA: 0x005DB3B0 File Offset: 0x005D95B0
	private void TryPushCamera()
	{
		UiCameraHandleData uiCameraHandleData = this.CreateCameraHandleData();
		if (uiCameraHandleData == null)
		{
			return;
		}
		uiCameraHandleData.SetViewId(new int?(base.GetViewId()));
		string viewName = "RoleOrnamentShowView";
		UiLayer.Instance.SetShowMaskLayer(viewName, true);
		UiCameraModel.Instance.PushCameraHandle(uiCameraHandleData, true, true, "1001", true, delegate(UiCameraDefine.IFinishData _)
		{
			UiLayer.Instance.SetShowMaskLayer(viewName, false);
		});
	}

	// Token: 0x06014164 RID: 82276 RVA: 0x005DB41C File Offset: 0x005D961C
	private UiCameraHandleData CreateCameraHandleData()
	{
		Ornament? ornamentConfig = RoleConfig.Instance.GetOrnamentConfig(this.OrnamentId);
		if (ornamentConfig == null)
		{
			return null;
		}
		Ornament value = ornamentConfig.Value;
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(this.SkinId);
		if (roleSkinConfig == null)
		{
			return null;
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
		return UiCameraUtil.CreateHandleData(text, text);
	}

	// Token: 0x06014165 RID: 82277 RVA: 0x005DB570 File Offset: 0x005D9770
	[NullableContext(1)]
	private UiCameraInputBindingData GetCameraInputData()
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
		return new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = value2,
			CameraOffsetConfig = cameraOffsetConfig,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x06014166 RID: 82278 RVA: 0x005DB664 File Offset: 0x005D9864
	private void InitCameraInputData()
	{
		UiCameraInputBindingData cameraInputData = this.GetCameraInputData();
		this.CameraInputBinding.Configure(cameraInputData);
	}

	// Token: 0x06014167 RID: 82279 RVA: 0x005DB684 File Offset: 0x005D9884
	private void UpdateCameraInputData()
	{
		UiCameraInputBindingData cameraInputData = this.GetCameraInputData();
		this.CameraInputBinding.Configure(cameraInputData);
		if (this.IsAllowCameraRotate())
		{
			this.CameraInputBinding.Bind();
			return;
		}
		this.CameraInputBinding.Unbind();
	}

	// Token: 0x06014168 RID: 82280 RVA: 0x005DB6C4 File Offset: 0x005D98C4
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

	// Token: 0x06014169 RID: 82281 RVA: 0x005DB7F0 File Offset: 0x005D99F0
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

	// Token: 0x0601416A RID: 82282 RVA: 0x005DB900 File Offset: 0x005D9B00
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

	// Token: 0x0601416B RID: 82283 RVA: 0x005DB9B4 File Offset: 0x005D9BB4
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

	// Token: 0x0601416C RID: 82284 RVA: 0x005DBA10 File Offset: 0x005D9C10
	private bool IsAllowCameraRotate()
	{
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(this.OrnamentId).Value;
		if (!this.IsHidingUi())
		{
			return value.AllowUiCameraRotate;
		}
		return value.AllowHideUiCameraRotate;
	}

	// Token: 0x0601416D RID: 82285 RVA: 0x005DBA4D File Offset: 0x005D9C4D
	private bool IsHidingUi()
	{
		return base.GetExtendToggle(1).GetToggleState() == EToggleState.ETT_Checked;
	}

	// Token: 0x0601416E RID: 82286 RVA: 0x005DBA60 File Offset: 0x005D9C60
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

	// Token: 0x0601416F RID: 82287 RVA: 0x005DBAC2 File Offset: 0x005D9CC2
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014170 RID: 82288 RVA: 0x005DBACC File Offset: 0x005D9CCC
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

	// Token: 0x06014171 RID: 82289 RVA: 0x005DBB8C File Offset: 0x005D9D8C
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
		this.TryPushCamera();
		this.UpdateCameraInputData();
	}

	// Token: 0x06014172 RID: 82290 RVA: 0x005DBC44 File Offset: 0x005D9E44
	private bool GetIfHaveRoleForCurrentOrnament()
	{
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(this.SkinId);
		int? num = (roleSkinData != null) ? new int?(roleSkinData.GetRoleId()) : null;
		return num == null || RoleModel.Instance.GetRoleInstanceById(num.Value) != null;
	}

	// Token: 0x06014173 RID: 82291 RVA: 0x005DBC9A File Offset: 0x005D9E9A
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

	// Token: 0x06014174 RID: 82292 RVA: 0x005DBCC4 File Offset: 0x005D9EC4
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

	// Token: 0x06014175 RID: 82293 RVA: 0x005DBD14 File Offset: 0x005D9F14
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

	// Token: 0x06014176 RID: 82294 RVA: 0x005DBD4C File Offset: 0x005D9F4C
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

	// Token: 0x06014177 RID: 82295 RVA: 0x005DBD84 File Offset: 0x005D9F84
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

	// Token: 0x06014178 RID: 82296 RVA: 0x005DBDEC File Offset: 0x005D9FEC
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

	// Token: 0x06014179 RID: 82297 RVA: 0x005DBEE8 File Offset: 0x005DA0E8
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

	// Token: 0x0601417A RID: 82298 RVA: 0x005DBF7B File Offset: 0x005DA17B
	[NullableContext(1)]
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x0601417B RID: 82299 RVA: 0x005DBF83 File Offset: 0x005DA183
	private void OnPayShopGoodsBuy()
	{
		this.RefreshView();
	}

	// Token: 0x0601417C RID: 82300 RVA: 0x005DBF8C File Offset: 0x005DA18C
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

	// Token: 0x0601417D RID: 82301 RVA: 0x005DBFF3 File Offset: 0x005DA1F3
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(627);
	}

	// Token: 0x0400AAC8 RID: 43720
	private const int SHOP_HELP_ID = 627;

	// Token: 0x0400AAC9 RID: 43721
	private int SkinId;

	// Token: 0x0400AACA RID: 43722
	private int OrnamentId;

	// Token: 0x0400AACB RID: 43723
	private int ResolvedRoleId;

	// Token: 0x0400AACC RID: 43724
	[Nullable(1)]
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400AACD RID: 43725
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AACE RID: 43726
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400AACF RID: 43727
	private ShopRoleOrnamentData ShopRoleOrnamentData;

	// Token: 0x0400AAD0 RID: 43728
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ExtraRewardLayout;

	// Token: 0x0400AAD1 RID: 43729
	private int CurrentPayItemId;

	// Token: 0x0400AAD2 RID: 43730
	private bool CurrentDiscountState;

	// Token: 0x0400AAD3 RID: 43731
	private bool CurrentInSellTime;

	// Token: 0x0400AAD4 RID: 43732
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x020082AF RID: 33455
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A38E RID: 172942
		CaptionItem,
		// Token: 0x0402A38F RID: 172943
		OnlyUiToggle,
		// Token: 0x0402A390 RID: 172944
		DetailIconButton,
		// Token: 0x0402A391 RID: 172945
		ButtonLeft,
		// Token: 0x0402A392 RID: 172946
		ButtonRight,
		// Token: 0x0402A393 RID: 172947
		TitleText,
		// Token: 0x0402A394 RID: 172948
		SubTitleText,
		// Token: 0x0402A395 RID: 172949
		SwitchItem,
		// Token: 0x0402A396 RID: 172950
		ToggleLeft,
		// Token: 0x0402A397 RID: 172951
		ExtraRewardItem,
		// Token: 0x0402A398 RID: 172952
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402A399 RID: 172953
		RewardItem,
		// Token: 0x0402A39A RID: 172954
		DescText,
		// Token: 0x0402A39B RID: 172955
		NotHaveRoleItem,
		// Token: 0x0402A39C RID: 172956
		BuyItemIcon,
		// Token: 0x0402A39D RID: 172957
		NowPrice,
		// Token: 0x0402A39E RID: 172958
		BeforePrice,
		// Token: 0x0402A39F RID: 172959
		BuyButton,
		// Token: 0x0402A3A0 RID: 172960
		DiscountItem,
		// Token: 0x0402A3A1 RID: 172961
		DiscountText,
		// Token: 0x0402A3A2 RID: 172962
		LeftTimeItem,
		// Token: 0x0402A3A3 RID: 172963
		LeftTimeText,
		// Token: 0x0402A3A4 RID: 172964
		QualityTexture,
		// Token: 0x0402A3A5 RID: 172965
		ItemTexture,
		// Token: 0x0402A3A6 RID: 172966
		FrameTexture,
		// Token: 0x0402A3A7 RID: 172967
		WeaponRootItem,
		// Token: 0x0402A3A8 RID: 172968
		WeaponTexture,
		// Token: 0x0402A3A9 RID: 172969
		HaveItem,
		// Token: 0x0402A3AA RID: 172970
		HideUiParentItem,
		// Token: 0x0402A3AB RID: 172971
		DragComponent,
		// Token: 0x0402A3AC RID: 172972
		WeaponQualityTexture,
		// Token: 0x0402A3AD RID: 172973
		ToggleRight,
		// Token: 0x0402A3AE RID: 172974
		EffectItemB,
		// Token: 0x0402A3AF RID: 172975
		EffectItemA,
		// Token: 0x0402A3B0 RID: 172976
		TextureToggleLeft,
		// Token: 0x0402A3B1 RID: 172977
		TextToggleLeft,
		// Token: 0x0402A3B2 RID: 172978
		TextureToggleRight,
		// Token: 0x0402A3B3 RID: 172979
		TextToggleRight,
		// Token: 0x0402A3B4 RID: 172980
		ItemGamePadKeyTipA = 45,
		// Token: 0x0402A3B5 RID: 172981
		ItemGamePadKeyTipB,
		// Token: 0x0402A3B6 RID: 172982
		ToggleLayout,
		// Token: 0x0402A3B7 RID: 172983
		ToggleMale,
		// Token: 0x0402A3B8 RID: 172984
		ToggleFemale,
		// Token: 0x0402A3B9 RID: 172985
		ExtraRewardText,
		// Token: 0x0402A3BA RID: 172986
		ItemBuyPanel,
		// Token: 0x0402A3BB RID: 172987
		ItemRolePanel,
		// Token: 0x0402A3BC RID: 172988
		ItemBottomLeftPanel,
		// Token: 0x0402A3BD RID: 172989
		ItemGamePadKeyTipC,
		// Token: 0x0402A3BE RID: 172990
		SpecialBgTexture,
		// Token: 0x0402A3BF RID: 172991
		ItemCountDownPanel,
		// Token: 0x0402A3C0 RID: 172992
		TextCountDown,
		// Token: 0x0402A3C1 RID: 172993
		TextDirectTips,
		// Token: 0x0402A3C2 RID: 172994
		ItemTagRoot = 60
	}
}
