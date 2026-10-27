using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002A25 RID: 10789
[NullableContext(1)]
[Nullable(0)]
public class FlySkinBuyDetailView : UiTickViewBase
{
	// Token: 0x060166D7 RID: 91863 RVA: 0x005AC001 File Offset: 0x005AA201
	public FlySkinBuyDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060166D8 RID: 91864 RVA: 0x005AC01C File Offset: 0x005AA21C
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
			new ValueTuple<int, Type>(46, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeftButton)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRightButton)),
			new ValueTuple<int, Delegate>(17, new Action(this.OnClickBuyButton)),
			new ValueTuple<int, Delegate>(8, new Action<EToggleState>(this.OnClickToggleLeft)),
			new ValueTuple<int, Delegate>(31, new Action<EToggleState>(this.OnClickToggleRight)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickOnlyUiToggle))
		};
	}

	// Token: 0x060166D9 RID: 91865 RVA: 0x005AC460 File Offset: 0x005AA660
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060166DA RID: 91866 RVA: 0x005AC4C4 File Offset: 0x005AA6C4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060166DB RID: 91867 RVA: 0x005AC528 File Offset: 0x005AA728
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseView));
		this.ViewData = (this.OpenParam as FlySkinBuyDetailViewData);
		this.CaptionItem.SetTitleLocalText(this.ViewData.GetPreviewTitle());
		this.CaptionItem.SetTitleIconByResourceId("FlySkinShopTitle_Icon");
		this.CaptionItem.SetHelpBtnActive(true);
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
		this.ItemLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(10), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		base.GetExtendToggle(8).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		base.GetExtendToggle(31).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		this.ResetCurrentFlySkinType();
		string stringConfig = ConfigCommonParamById.GetStringConfig("ShopPreviewGliderSkinIcon");
		string stringConfig2 = ConfigCommonParamById.GetStringConfig("ShopPreviewSoarWingSkinIcon");
		base.SetTextureByPath(stringConfig, base.GetTexture(34), null, null);
		base.SetTextureByPath(stringConfig2, base.GetTexture(36), null, null);
		string stringConfig3 = ConfigCommonParamById.GetStringConfig("ShopPreviewGliderSkinText");
		string stringConfig4 = ConfigCommonParamById.GetStringConfig("ShopPreviewSoarWingSkinText");
		LguiUtil.Instance.SetLocalTextNew(base.GetText(35), stringConfig3, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(37), stringConfig4, Array.Empty<object>());
		base.GetItem(7).SetUIActive(true);
		base.GetItem(25).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		UUIItem item = base.GetItem(45);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(46);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x060166DC RID: 91868 RVA: 0x005AC717 File Offset: 0x005AA917
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x060166DD RID: 91869 RVA: 0x005AC71E File Offset: 0x005AA91E
	protected override void OnHandleLoadScene()
	{
		this.InitGliderObserver();
		this.InitCameraInputData();
	}

	// Token: 0x060166DE RID: 91870 RVA: 0x005AC72C File Offset: 0x005AA92C
	private void InitGliderObserver()
	{
		UiSceneManager.Instance.InitGliderSkeletalHandle();
		SkeletalObserverHandle gliderSkeletalHandle = UiSceneManager.Instance.GetGliderSkeletalHandle();
		if (gliderSkeletalHandle == null)
		{
			return;
		}
		UiModelBase model = gliderSkeletalHandle.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.SetTransformByTag(FlySkinDefine.DEFAULT_FLY_SKIN_CASE);
		}
		this.GliderObserver = gliderSkeletalHandle;
	}

	// Token: 0x060166DF RID: 91871 RVA: 0x005AC77C File Offset: 0x005AA97C
	public void InitCameraInputData()
	{
		string rowName = "翱翔滑翔皮肤旋转查看";
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig(rowName);
		if (roleCameraConfig == null)
		{
			return;
		}
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		if (((gliderObserver != null) ? gliderObserver.Model : null) == null)
		{
			return;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(FlySkinDefine.flySkinTypeToCase[this.CurrentFlySkinType]).Value, ECollectActorType.UI);
		if (actorWithTag == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		UiCameraInputComponentData data = new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
		this.CameraInputComponent.CanCameraInput = false;
	}

	// Token: 0x060166E0 RID: 91872 RVA: 0x005AC832 File Offset: 0x005AAA32
	protected override void OnBeforeShow()
	{
		this.CanPushCamera = true;
		this.TryPushCamera();
		this.TryLoadModel();
		this.RefreshView();
	}

	// Token: 0x060166E1 RID: 91873 RVA: 0x005AC850 File Offset: 0x005AAA50
	private void RefreshView()
	{
		FlySkinBuyDetailViewData viewData = this.ViewData;
		ShopFlySkinData shopFlySkinData = (viewData != null) ? viewData.GetCurrentGoodsData() : null;
		FlySkinData flySkinData = (viewData != null) ? viewData.GetCurrentSkinData(this.CurrentFlySkinType) : null;
		if (viewData == null || shopFlySkinData == null || flySkinData == null)
		{
			return;
		}
		shopFlySkinData.GetCurrentGoodsData().SaveRemindState((long)TimeUtil.Instance.GetServerTime());
		bool uiactive = viewData != null && viewData.CheckIfHaveMutiGood();
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
		bool ifCanBuy = shopFlySkinData.GetIfCanBuy();
		base.GetText(15).SetUIActive(ifCanBuy);
		base.GetButton(17).RootUIComp.Get().SetUIActive(ifCanBuy);
		base.GetItem(27).SetUIActive(!ifCanBuy);
		bool uiactive2 = viewData.GetCurrentSkinData(this.CurrentFlySkinType).GetSkinGrade() == 1;
		base.GetItem(33).SetUIActive(uiactive2);
		base.GetItem(32).SetUIActive(uiactive2);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), flySkinData.GetTitleName(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), flySkinData.GetSubTitle(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), flySkinData.GetDesc(), Array.Empty<object>());
		base.SetTextureByPath(flySkinData.GetPreviewTextureInBuyView(), base.GetTexture(23), null, null);
		base.SetTextureByPath(flySkinData.GetBuyPreviewQualityBgPath(), base.GetTexture(22), null, null);
		string discountText = viewData.GetDiscountText();
		base.GetItem(18).SetUIActive(discountText != "");
		base.GetText(19).SetText(discountText, true);
		object discountTimeData = viewData.GetDiscountTimeData();
		if (discountTimeData == null)
		{
			base.GetItem(20).SetUIActive(false);
		}
		else
		{
			base.GetItem(20).SetUIActive(true);
			string text = discountTimeData as string;
			if (text != null)
			{
				UUIText text2 = base.GetText(21);
				if (text2 != null)
				{
					text2.SetText(text, true);
				}
			}
			else
			{
				CommonDefine.IRemainTime remainTime = discountTimeData as CommonDefine.IRemainTime;
				if (remainTime != null)
				{
					LguiUtil.Instance.SetLocalText(base.GetText(21), remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
				}
			}
		}
		bool ifDirect = viewData.GetIfDirect();
		IPriceData priceData = viewData.GetPriceData();
		base.GetTexture(14).SetUIActive(!ifDirect);
		if (ifDirect)
		{
			base.GetText(15).SetText(viewData.GetDirectPriceText(), true);
		}
		else if (priceData != null)
		{
			base.SetItemIcon(base.GetTexture(14), priceData.CurrencyId, null, null);
			base.GetText(15).SetText(priceData.NowPrice.ToString(), true);
		}
		int? num = (priceData != null) ? priceData.OriginalPrice : null;
		if (num == null || num.Value == 0)
		{
			base.GetText(16).SetUIActive(false);
		}
		else
		{
			base.GetText(16).SetUIActive(true);
			base.GetText(16).SetText("<s>" + num.Value.ToString() + "</s>", true);
		}
		base.GetExtendToggle(8).SetToggleState((this.CurrentFlySkinType == EFlySkinType.Paragliding) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		base.GetExtendToggle(31).SetToggleState((this.CurrentFlySkinType == EFlySkinType.SoarWing) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshExtraReward(this.ViewData);
	}

	// Token: 0x060166E2 RID: 91874 RVA: 0x005ACBE8 File Offset: 0x005AADE8
	[NullableContext(2)]
	private void RefreshExtraReward(FlySkinBuyDetailViewData data)
	{
		if (data == null)
		{
			return;
		}
		List<TItem> otherReward = data.GetCurrentGoodsData().GetOtherReward();
		List<SkinRewardData> list = new List<SkinRewardData>();
		foreach (TItem value in otherReward)
		{
			list.Add(new SkinRewardData
			{
				ItemData = new TItem?(value),
				FinishState = !data.GetCurrentGoodsData().GetIfCanBuy()
			});
		}
		GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout = this.ItemLayout;
		if (itemLayout != null)
		{
			itemLayout.SetActive(list.Count != 0);
		}
		base.GetItem(9).SetUIActive(list.Count != 0);
		GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout2 = this.ItemLayout;
		if (itemLayout2 == null)
		{
			return;
		}
		itemLayout2.RefreshByData(list, null, false);
	}

	// Token: 0x060166E3 RID: 91875 RVA: 0x005ACCB4 File Offset: 0x005AAEB4
	protected override void OnAfterShow()
	{
		this.InitGliderObserver();
		this.CanPushCamera = true;
		this.TryPushCamera();
		this.TryLoadModel();
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
	}

	// Token: 0x060166E4 RID: 91876 RVA: 0x005ACCE8 File Offset: 0x005AAEE8
	private void TryPushCamera()
	{
		if (!this.CanPushCamera)
		{
			return;
		}
		string flySkinModelCameraId = SkinConfig.Instance.GetFlySkinModelCameraId(this.CurrentFlySkinType);
		this.WaitCameraId = flySkinModelCameraId;
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(flySkinModelCameraId, true, true, "10010", false, null, null);
	}

	// Token: 0x060166E5 RID: 91877 RVA: 0x005ACD34 File Offset: 0x005AAF34
	public void TryLoadModel()
	{
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		UiModelBase uiModelBase = (gliderObserver != null) ? gliderObserver.Model : null;
		if (uiModelBase == null)
		{
			return;
		}
		string transformByTag = FlySkinDefine.flySkinTypeToCase[this.CurrentFlySkinType];
		if (!this.CanLoadModel)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
			UiModelActorComponent uiModelActorComponent = uiModelBase.CheckGetComponent<UiModelActorComponent>();
			if (uiModelActorComponent == null)
			{
				return;
			}
			uiModelActorComponent.SetTransformByTag(transformByTag);
			return;
		}
		else
		{
			SkinConfig instance = SkinConfig.Instance;
			EFlySkinType currentFlySkinType = this.CurrentFlySkinType;
			FlySkinConfig flySkinConfig = this.ViewData.GetCurrentSkinData(currentFlySkinType).GetFlySkinConfig();
			string standAnimPath = flySkinConfig.StandAnim;
			string flySkinSpawnEffectId = instance.GetFlySkinSpawnEffectId(currentFlySkinType);
			string flySkinSpawnMaterialController = instance.GetFlySkinSpawnMaterialController(currentFlySkinType);
			string effectPath = EffectUtil.GetEffectPath(flySkinSpawnEffectId);
			string changeMaterialControllerPath = EffectUtil.GetEffectPath(flySkinSpawnMaterialController);
			List<string> extraResourceList = new List<string>
			{
				standAnimPath,
				effectPath,
				changeMaterialControllerPath
			};
			UiModelLoadComponent loadComponent = uiModelBase.CheckGetComponent<UiModelLoadComponent>();
			if (loadComponent == null)
			{
				return;
			}
			UiModelActorComponent uiModelActorComponent2 = uiModelBase.CheckGetComponent<UiModelActorComponent>();
			if (uiModelActorComponent2 != null)
			{
				uiModelActorComponent2.SetTransformByTag(transformByTag);
			}
			Action loadFinishCallBack = delegate()
			{
				SkeletalObserverHandle gliderObserver2 = this.GliderObserver;
				UiModelBase uiModelBase2 = (gliderObserver2 != null) ? gliderObserver2.Model : null;
				if (uiModelBase2 == null)
				{
					return;
				}
				UiModelUtil.Instance.SetVisible(uiModelBase2, true);
				UiModelLoadComponent loadComponent = loadComponent;
				UAnimationAsset uanimationAsset = ((loadComponent != null) ? loadComponent.GetLoadedResource(standAnimPath) : null) as UAnimationAsset;
				if (uanimationAsset == null)
				{
					Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.CXJ, "[FlySkin] 商城飞行皮肤待机动画预加载失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				UiModelAnimationComponent uiModelAnimationComponent = uiModelBase2.CheckGetComponent<UiModelAnimationComponent>();
				if (uanimationAsset != null && uiModelAnimationComponent != null)
				{
					uiModelAnimationComponent.PlayAnimation(uanimationAsset, true);
				}
				UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = uiModelBase2.CheckGetComponent<UiModelRenderingMaterialComponent>();
				PD_CharacterControllerData_C pd_CharacterControllerData_C = loadComponent.GetLoadedResource(changeMaterialControllerPath) as PD_CharacterControllerData_C;
				if (pd_CharacterControllerData_C != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C);
				}
				UiModelUtil.Instance.PlayEffectOnRoot(uiModelBase2, "GliderEffect");
			};
			loadComponent.LoadModelByModelId(flySkinConfig.ModelId, true, loadFinishCallBack, extraResourceList);
			return;
		}
	}

	// Token: 0x060166E6 RID: 91878 RVA: 0x005ACE64 File Offset: 0x005AB064
	protected override void OnTick(float delta)
	{
		FlySkinBuyDetailViewData viewData = this.ViewData;
		PayShopGoods payShopGoods;
		if (viewData == null)
		{
			payShopGoods = null;
		}
		else
		{
			ShopFlySkinData currentGoodsData = viewData.GetCurrentGoodsData();
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

	// Token: 0x060166E7 RID: 91879 RVA: 0x005ACF6D File Offset: 0x005AB16D
	protected override void OnBeforeHide()
	{
		UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
		if (cameraInputComponent == null)
		{
			return;
		}
		cameraInputComponent.End();
	}

	// Token: 0x060166E8 RID: 91880 RVA: 0x005ACF7F File Offset: 0x005AB17F
	protected override void OnBeforeDestroy()
	{
		UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
		this.DestroyGliderObserver();
	}

	// Token: 0x060166E9 RID: 91881 RVA: 0x005ACF9B File Offset: 0x005AB19B
	private void DestroyGliderObserver()
	{
		UiSceneManager.Instance.DestroyGliderSkeletalHandle();
		this.GliderObserver = null;
	}

	// Token: 0x060166EA RID: 91882 RVA: 0x005ACFAE File Offset: 0x005AB1AE
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060166EB RID: 91883 RVA: 0x005ACFB7 File Offset: 0x005AB1B7
	private void OnClickToggleRight(EToggleState toggleState)
	{
		this.CurrentFlySkinType = EFlySkinType.SoarWing;
		base.GetExtendToggle(8).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.SwitchFlySkinType();
	}

	// Token: 0x060166EC RID: 91884 RVA: 0x005ACFD7 File Offset: 0x005AB1D7
	private void OnClickToggleLeft(EToggleState toggleState)
	{
		this.CurrentFlySkinType = EFlySkinType.Paragliding;
		base.GetExtendToggle(31).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.SwitchFlySkinType();
	}

	// Token: 0x060166ED RID: 91885 RVA: 0x005ACFF8 File Offset: 0x005AB1F8
	private void SwitchFlySkinType()
	{
		this.LastSwitchTime = 0.0;
		this.RefreshView();
		this.TryPushCamera();
		this.TryLoadModel();
		this.LastSwitchTime = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x060166EE RID: 91886 RVA: 0x005AD02C File Offset: 0x005AB22C
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
		UUIItem item = base.GetItem(46);
		if (item != null)
		{
			item.SetUIActive(state);
		}
		this.CameraInputComponent.CanCameraInput = state;
		this.TryPushCamera();
	}

	// Token: 0x060166EF RID: 91887 RVA: 0x005AD0EC File Offset: 0x005AB2EC
	private void OnClickBuyButton()
	{
		PayShopController.Instance.OpenBuySkinDetailView(this.ViewData.GetCurrentGoodsData().GetCurrentGoodsData());
	}

	// Token: 0x060166F0 RID: 91888 RVA: 0x005AD108 File Offset: 0x005AB308
	private void OnClickRightButton()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() - this.LastClickButtonTime < (double)SkinConfig.Instance.GetSkinDetailButtonGap())
		{
			return;
		}
		this.ViewData.SwitchToNextGoods();
		this.SwitchFlySkin();
	}

	// Token: 0x060166F1 RID: 91889 RVA: 0x005AD13A File Offset: 0x005AB33A
	private void OnClickLeftButton()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() - this.LastClickButtonTime < (double)SkinConfig.Instance.GetSkinDetailButtonGap())
		{
			return;
		}
		this.ViewData.SwitchToPreGoods();
		this.SwitchFlySkin();
	}

	// Token: 0x060166F2 RID: 91890 RVA: 0x005AD16C File Offset: 0x005AB36C
	private void SwitchFlySkin()
	{
		this.LastClickButtonTime = TimeUtil.Instance.GetServerTimeStamp();
		this.ResetCurrentFlySkinType();
		this.RefreshView();
		this.TryPushCamera();
		this.TryLoadModel();
		base.PlaySequence("Switch", null, true);
	}

	// Token: 0x060166F3 RID: 91891 RVA: 0x005AD1A3 File Offset: 0x005AB3A3
	private void ResetCurrentFlySkinType()
	{
		this.CurrentFlySkinType = EFlySkinType.Paragliding;
	}

	// Token: 0x060166F4 RID: 91892 RVA: 0x005AD1AC File Offset: 0x005AB3AC
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.HandleName == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
				this.TryLoadModel();
			}
		}
	}

	// Token: 0x060166F5 RID: 91893 RVA: 0x005AD1DD File Offset: 0x005AB3DD
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(318);
	}

	// Token: 0x060166F6 RID: 91894 RVA: 0x005AD1EE File Offset: 0x005AB3EE
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x060166F7 RID: 91895 RVA: 0x005AD1F8 File Offset: 0x005AB3F8
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		ShopFlySkinData currentGoodsData = this.ViewData.GetCurrentGoodsData();
		int? num = (currentGoodsData != null) ? new int?(currentGoodsData.GetCurrentGoodsData().GetGoodsId()) : null;
		if (!(goodsId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.RefreshView();
	}

	// Token: 0x060166F8 RID: 91896 RVA: 0x005AD24A File Offset: 0x005AB44A
	private bool CanToggleExecuteChange()
	{
		return TimeUtil.Instance.GetServerTimeStamp() - this.LastSwitchTime >= (double)SkinConfig.Instance.GetSkinDetailButtonSwitchGap();
	}

	// Token: 0x0400A6AE RID: 42670
	[Nullable(2)]
	private FlySkinBuyDetailViewData ViewData;

	// Token: 0x0400A6AF RID: 42671
	private EFlySkinType CurrentFlySkinType = EFlySkinType.Paragliding;

	// Token: 0x0400A6B0 RID: 42672
	private int CurrentPayItemId;

	// Token: 0x0400A6B1 RID: 42673
	[Nullable(2)]
	private SkeletalObserverHandle GliderObserver;

	// Token: 0x0400A6B2 RID: 42674
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0400A6B3 RID: 42675
	[Nullable(2)]
	private string WaitCameraId;

	// Token: 0x0400A6B4 RID: 42676
	private bool CanPushCamera;

	// Token: 0x0400A6B5 RID: 42677
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A6B6 RID: 42678
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

	// Token: 0x0400A6B7 RID: 42679
	private double LastClickButtonTime;

	// Token: 0x0400A6B8 RID: 42680
	private double LastSwitchTime;

	// Token: 0x0400A6B9 RID: 42681
	private bool CurrentDiscountState;

	// Token: 0x0400A6BA RID: 42682
	private bool CanLoadModel;

	// Token: 0x02009059 RID: 36953
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402EC00 RID: 191488
		CaptionItem,
		// Token: 0x0402EC01 RID: 191489
		OnlyUiToggle,
		// Token: 0x0402EC02 RID: 191490
		DetailIconButton,
		// Token: 0x0402EC03 RID: 191491
		ButtonLeft,
		// Token: 0x0402EC04 RID: 191492
		ButtonRight,
		// Token: 0x0402EC05 RID: 191493
		TitleText,
		// Token: 0x0402EC06 RID: 191494
		SubTitleText,
		// Token: 0x0402EC07 RID: 191495
		SwitchItem,
		// Token: 0x0402EC08 RID: 191496
		ToggleLeft,
		// Token: 0x0402EC09 RID: 191497
		ExtraRewardItem,
		// Token: 0x0402EC0A RID: 191498
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402EC0B RID: 191499
		RewardItem,
		// Token: 0x0402EC0C RID: 191500
		DescText,
		// Token: 0x0402EC0D RID: 191501
		NotHaveRoleItem,
		// Token: 0x0402EC0E RID: 191502
		BuyItemIcon,
		// Token: 0x0402EC0F RID: 191503
		NowPrice,
		// Token: 0x0402EC10 RID: 191504
		BeforePrice,
		// Token: 0x0402EC11 RID: 191505
		BuyButton,
		// Token: 0x0402EC12 RID: 191506
		DiscountItem,
		// Token: 0x0402EC13 RID: 191507
		DiscountText,
		// Token: 0x0402EC14 RID: 191508
		LeftTimeItem,
		// Token: 0x0402EC15 RID: 191509
		LeftTimeText,
		// Token: 0x0402EC16 RID: 191510
		QualityTexture,
		// Token: 0x0402EC17 RID: 191511
		ItemTexture,
		// Token: 0x0402EC18 RID: 191512
		FrameTexture,
		// Token: 0x0402EC19 RID: 191513
		WeaponRootItem,
		// Token: 0x0402EC1A RID: 191514
		WeaponTexture,
		// Token: 0x0402EC1B RID: 191515
		HaveItem,
		// Token: 0x0402EC1C RID: 191516
		HideUiParentItem,
		// Token: 0x0402EC1D RID: 191517
		DragComponent,
		// Token: 0x0402EC1E RID: 191518
		WeaponQualityTexture,
		// Token: 0x0402EC1F RID: 191519
		ToggleRight,
		// Token: 0x0402EC20 RID: 191520
		EffectItemB,
		// Token: 0x0402EC21 RID: 191521
		EffectItemA,
		// Token: 0x0402EC22 RID: 191522
		TextureToggleLeft,
		// Token: 0x0402EC23 RID: 191523
		TextToggleLeft,
		// Token: 0x0402EC24 RID: 191524
		TextureToggleRight,
		// Token: 0x0402EC25 RID: 191525
		TextToggleRight,
		// Token: 0x0402EC26 RID: 191526
		ItemGamePadKeyTipA = 45,
		// Token: 0x0402EC27 RID: 191527
		ItemGamePadKeyTipB
	}
}
