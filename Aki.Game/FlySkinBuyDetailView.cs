using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02001FA0 RID: 8096
[NullableContext(1)]
[Nullable(0)]
public class FlySkinBuyDetailView : UiTickViewBase
{
	// Token: 0x060140DD RID: 82141 RVA: 0x005D7071 File Offset: 0x005D5271
	public FlySkinBuyDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060140DE RID: 82142 RVA: 0x005D708C File Offset: 0x005D528C
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

	// Token: 0x060140DF RID: 82143 RVA: 0x005D74D0 File Offset: 0x005D56D0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060140E0 RID: 82144 RVA: 0x005D7534 File Offset: 0x005D5734
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060140E1 RID: 82145 RVA: 0x005D7598 File Offset: 0x005D5798
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

	// Token: 0x060140E2 RID: 82146 RVA: 0x005D7787 File Offset: 0x005D5987
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x060140E3 RID: 82147 RVA: 0x005D778E File Offset: 0x005D598E
	protected override void OnHandleLoadScene()
	{
		this.InitGliderObserver();
		this.InitCameraInputData();
	}

	// Token: 0x060140E4 RID: 82148 RVA: 0x005D779C File Offset: 0x005D599C
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

	// Token: 0x060140E5 RID: 82149 RVA: 0x005D77EC File Offset: 0x005D59EC
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
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
	}

	// Token: 0x060140E6 RID: 82150 RVA: 0x005D7896 File Offset: 0x005D5A96
	protected override void OnBeforeShow()
	{
		this.CanPushCamera = true;
		this.TryPushCamera();
		this.TryLoadModel();
		this.RefreshView();
	}

	// Token: 0x060140E7 RID: 82151 RVA: 0x005D78B4 File Offset: 0x005D5AB4
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

	// Token: 0x060140E8 RID: 82152 RVA: 0x005D7C4C File Offset: 0x005D5E4C
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

	// Token: 0x060140E9 RID: 82153 RVA: 0x005D7D18 File Offset: 0x005D5F18
	protected override void OnAfterShow()
	{
		this.InitGliderObserver();
		this.CanPushCamera = true;
		this.TryPushCamera();
		this.TryLoadModel();
	}

	// Token: 0x060140EA RID: 82154 RVA: 0x005D7D34 File Offset: 0x005D5F34
	private void TryPushCamera()
	{
		if (!this.CanPushCamera)
		{
			return;
		}
		string flySkinModelCameraId = SkinConfig.Instance.GetFlySkinModelCameraId(this.CurrentFlySkinType);
		this.WaitCameraId = flySkinModelCameraId;
		UiCameraModel.Instance.PushCameraHandleByHandleName(flySkinModelCameraId, true, true, "10010", false, null);
	}

	// Token: 0x060140EB RID: 82155 RVA: 0x005D7D78 File Offset: 0x005D5F78
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

	// Token: 0x060140EC RID: 82156 RVA: 0x005D7EA8 File Offset: 0x005D60A8
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

	// Token: 0x060140ED RID: 82157 RVA: 0x005D7FB1 File Offset: 0x005D61B1
	protected override void OnBeforeHide()
	{
		UiCameraInputBinding cameraInputBinding = this.CameraInputBinding;
		if (cameraInputBinding == null)
		{
			return;
		}
		cameraInputBinding.Unbind();
	}

	// Token: 0x060140EE RID: 82158 RVA: 0x005D7FC3 File Offset: 0x005D61C3
	protected override void OnBeforeDestroy()
	{
		this.DestroyGliderObserver();
	}

	// Token: 0x060140EF RID: 82159 RVA: 0x005D7FCB File Offset: 0x005D61CB
	private void DestroyGliderObserver()
	{
		UiSceneManager.Instance.DestroyGliderSkeletalHandle();
		this.GliderObserver = null;
	}

	// Token: 0x060140F0 RID: 82160 RVA: 0x005D7FDE File Offset: 0x005D61DE
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060140F1 RID: 82161 RVA: 0x005D7FE7 File Offset: 0x005D61E7
	private void OnClickToggleRight(EToggleState toggleState)
	{
		this.CurrentFlySkinType = EFlySkinType.SoarWing;
		base.GetExtendToggle(8).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.SwitchFlySkinType();
	}

	// Token: 0x060140F2 RID: 82162 RVA: 0x005D8007 File Offset: 0x005D6207
	private void OnClickToggleLeft(EToggleState toggleState)
	{
		this.CurrentFlySkinType = EFlySkinType.Paragliding;
		base.GetExtendToggle(31).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.SwitchFlySkinType();
	}

	// Token: 0x060140F3 RID: 82163 RVA: 0x005D8028 File Offset: 0x005D6228
	private void SwitchFlySkinType()
	{
		this.LastSwitchTime = 0.0;
		this.RefreshView();
		this.TryLoadModel();
		this.TryPushCamera();
		this.LastSwitchTime = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x060140F4 RID: 82164 RVA: 0x005D805C File Offset: 0x005D625C
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
		if (state)
		{
			this.CameraInputBinding.Bind();
		}
		else
		{
			this.CameraInputBinding.Unbind();
		}
		this.TryPushCamera();
	}

	// Token: 0x060140F5 RID: 82165 RVA: 0x005D812B File Offset: 0x005D632B
	private void OnClickBuyButton()
	{
		PayShopController.Instance.OpenBuySkinDetailView(this.ViewData.GetCurrentGoodsData().GetCurrentGoodsData());
	}

	// Token: 0x060140F6 RID: 82166 RVA: 0x005D8147 File Offset: 0x005D6347
	private void OnClickRightButton()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() - this.LastClickButtonTime < (double)SkinConfig.Instance.GetSkinDetailButtonGap())
		{
			return;
		}
		this.ViewData.SwitchToNextGoods();
		this.SwitchFlySkin();
	}

	// Token: 0x060140F7 RID: 82167 RVA: 0x005D8179 File Offset: 0x005D6379
	private void OnClickLeftButton()
	{
		if (TimeUtil.Instance.GetServerTimeStamp() - this.LastClickButtonTime < (double)SkinConfig.Instance.GetSkinDetailButtonGap())
		{
			return;
		}
		this.ViewData.SwitchToPreGoods();
		this.SwitchFlySkin();
	}

	// Token: 0x060140F8 RID: 82168 RVA: 0x005D81AB File Offset: 0x005D63AB
	private void SwitchFlySkin()
	{
		this.LastClickButtonTime = TimeUtil.Instance.GetServerTimeStamp();
		this.ResetCurrentFlySkinType();
		this.RefreshView();
		this.TryPushCamera();
		this.TryLoadModel();
		base.PlaySequence("Switch", null, true);
	}

	// Token: 0x060140F9 RID: 82169 RVA: 0x005D81E2 File Offset: 0x005D63E2
	private void ResetCurrentFlySkinType()
	{
		this.CurrentFlySkinType = EFlySkinType.Paragliding;
	}

	// Token: 0x060140FA RID: 82170 RVA: 0x005D81EB File Offset: 0x005D63EB
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetHandleName() == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
				this.TryLoadModel();
			}
		}
	}

	// Token: 0x060140FB RID: 82171 RVA: 0x005D821C File Offset: 0x005D641C
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(318);
	}

	// Token: 0x060140FC RID: 82172 RVA: 0x005D822D File Offset: 0x005D642D
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x060140FD RID: 82173 RVA: 0x005D8238 File Offset: 0x005D6438
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

	// Token: 0x060140FE RID: 82174 RVA: 0x005D828A File Offset: 0x005D648A
	private bool CanToggleExecuteChange()
	{
		return TimeUtil.Instance.GetServerTimeStamp() - this.LastSwitchTime >= (double)SkinConfig.Instance.GetSkinDetailButtonSwitchGap();
	}

	// Token: 0x0400AA98 RID: 43672
	[Nullable(2)]
	private FlySkinBuyDetailViewData ViewData;

	// Token: 0x0400AA99 RID: 43673
	private EFlySkinType CurrentFlySkinType = EFlySkinType.Paragliding;

	// Token: 0x0400AA9A RID: 43674
	private int CurrentPayItemId;

	// Token: 0x0400AA9B RID: 43675
	[Nullable(2)]
	private SkeletalObserverHandle GliderObserver;

	// Token: 0x0400AA9C RID: 43676
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400AA9D RID: 43677
	[Nullable(2)]
	private string WaitCameraId;

	// Token: 0x0400AA9E RID: 43678
	private bool CanPushCamera;

	// Token: 0x0400AA9F RID: 43679
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AAA0 RID: 43680
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

	// Token: 0x0400AAA1 RID: 43681
	private double LastClickButtonTime;

	// Token: 0x0400AAA2 RID: 43682
	private double LastSwitchTime;

	// Token: 0x0400AAA3 RID: 43683
	private bool CurrentDiscountState;

	// Token: 0x0400AAA4 RID: 43684
	private bool CanLoadModel;

	// Token: 0x020082A0 RID: 33440
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A2F8 RID: 172792
		CaptionItem,
		// Token: 0x0402A2F9 RID: 172793
		OnlyUiToggle,
		// Token: 0x0402A2FA RID: 172794
		DetailIconButton,
		// Token: 0x0402A2FB RID: 172795
		ButtonLeft,
		// Token: 0x0402A2FC RID: 172796
		ButtonRight,
		// Token: 0x0402A2FD RID: 172797
		TitleText,
		// Token: 0x0402A2FE RID: 172798
		SubTitleText,
		// Token: 0x0402A2FF RID: 172799
		SwitchItem,
		// Token: 0x0402A300 RID: 172800
		ToggleLeft,
		// Token: 0x0402A301 RID: 172801
		ExtraRewardItem,
		// Token: 0x0402A302 RID: 172802
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402A303 RID: 172803
		RewardItem,
		// Token: 0x0402A304 RID: 172804
		DescText,
		// Token: 0x0402A305 RID: 172805
		NotHaveRoleItem,
		// Token: 0x0402A306 RID: 172806
		BuyItemIcon,
		// Token: 0x0402A307 RID: 172807
		NowPrice,
		// Token: 0x0402A308 RID: 172808
		BeforePrice,
		// Token: 0x0402A309 RID: 172809
		BuyButton,
		// Token: 0x0402A30A RID: 172810
		DiscountItem,
		// Token: 0x0402A30B RID: 172811
		DiscountText,
		// Token: 0x0402A30C RID: 172812
		LeftTimeItem,
		// Token: 0x0402A30D RID: 172813
		LeftTimeText,
		// Token: 0x0402A30E RID: 172814
		QualityTexture,
		// Token: 0x0402A30F RID: 172815
		ItemTexture,
		// Token: 0x0402A310 RID: 172816
		FrameTexture,
		// Token: 0x0402A311 RID: 172817
		WeaponRootItem,
		// Token: 0x0402A312 RID: 172818
		WeaponTexture,
		// Token: 0x0402A313 RID: 172819
		HaveItem,
		// Token: 0x0402A314 RID: 172820
		HideUiParentItem,
		// Token: 0x0402A315 RID: 172821
		DragComponent,
		// Token: 0x0402A316 RID: 172822
		WeaponQualityTexture,
		// Token: 0x0402A317 RID: 172823
		ToggleRight,
		// Token: 0x0402A318 RID: 172824
		EffectItemB,
		// Token: 0x0402A319 RID: 172825
		EffectItemA,
		// Token: 0x0402A31A RID: 172826
		TextureToggleLeft,
		// Token: 0x0402A31B RID: 172827
		TextToggleLeft,
		// Token: 0x0402A31C RID: 172828
		TextureToggleRight,
		// Token: 0x0402A31D RID: 172829
		TextToggleRight,
		// Token: 0x0402A31E RID: 172830
		ItemGamePadKeyTipA = 45,
		// Token: 0x0402A31F RID: 172831
		ItemGamePadKeyTipB
	}
}
