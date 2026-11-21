using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FA5 RID: 8101
[NullableContext(1)]
[Nullable(0)]
public class MotorSkinBuyDetailView : UiTickViewBase
{
	// Token: 0x06014134 RID: 82228 RVA: 0x005D9A60 File Offset: 0x005D7C60
	public MotorSkinBuyDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014135 RID: 82229 RVA: 0x005D9A74 File Offset: 0x005D7C74
	[NullableContext(2)]
	public MotorSkinBuyDetailViewData GetViewData()
	{
		return this.ViewData;
	}

	// Token: 0x06014136 RID: 82230 RVA: 0x005D9A7C File Offset: 0x005D7C7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickOnlyUiToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickBtnConfirmB));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014137 RID: 82231 RVA: 0x005D9D84 File Offset: 0x005D7F84
	protected override UniTask OnBeforeStartAsync()
	{
		MotorSkinBuyDetailView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinBuyDetailView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014138 RID: 82232 RVA: 0x005D9DC8 File Offset: 0x005D7FC8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06014139 RID: 82233 RVA: 0x005D9E2C File Offset: 0x005D802C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0601413A RID: 82234 RVA: 0x005D9E90 File Offset: 0x005D8090
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(2));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseView));
		this.ViewData = (this.OpenParam as MotorSkinBuyDetailViewData);
		this.CaptionItem.SetHelpBtnActive(true);
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(true);
		}
		this.MainRewardLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(8), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		this.ExRewardLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(10), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		ShopMotorSkinData currentGoodsData = this.ViewData.GetCurrentGoodsData();
		int? num;
		if (currentGoodsData == null)
		{
			num = null;
		}
		else
		{
			PayShopGoods currentGoodsData2 = currentGoodsData.GetCurrentGoodsData();
			num = ((currentGoodsData2 != null) ? new int?(currentGoodsData2.GetGoodsId()) : null);
		}
		int? num2 = num;
		this.CurrentGoodsId = num2.GetValueOrDefault();
		TotalTopUpPayAdditiveTagItem totalTopUpTagItem = this.TotalTopUpTagItem;
		if (totalTopUpTagItem == null)
		{
			return;
		}
		totalTopUpTagItem.RefreshByGoodsId(this.CurrentGoodsId);
	}

	// Token: 0x0601413B RID: 82235 RVA: 0x005D9FB9 File Offset: 0x005D81B9
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x0601413C RID: 82236 RVA: 0x005D9FC0 File Offset: 0x005D81C0
	protected override void OnHandleLoadScene()
	{
		this.InitMotorModel();
		this.InitCameraInputData();
	}

	// Token: 0x0601413D RID: 82237 RVA: 0x005D9FCE File Offset: 0x005D81CE
	private void InitMotorModel()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
		this.HandleMotorShowByRewardList();
	}

	// Token: 0x0601413E RID: 82238 RVA: 0x005D9FE4 File Offset: 0x005D81E4
	private void HandleMotorShowByRewardList()
	{
		MotorSkinBuyDetailViewData motorSkinBuyDetailViewData = this.OpenParam as MotorSkinBuyDetailViewData;
		List<TItem> list;
		if (motorSkinBuyDetailViewData == null)
		{
			list = null;
		}
		else
		{
			ShopMotorSkinData currentGoodsData = motorSkinBuyDetailViewData.GetCurrentGoodsData();
			list = ((currentGoodsData != null) ? currentGoodsData.GetMainReward() : null);
		}
		List<TItem> list2 = list ?? new List<TItem>();
		int num = 0;
		int frameId = 89400001;
		List<int> list3 = new List<int>();
		List<int> list4 = new List<int>();
		foreach (TItem titem in list2)
		{
			int itemId = titem.ItemData.ItemId;
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId));
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorSkinItem)
			{
				num = itemId;
			}
			else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorFrameItem)
			{
				frameId = itemId;
			}
			else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorStickerItem)
			{
				list3.Add(itemId);
			}
			else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorDecorationItem)
			{
				list4.Add(itemId);
			}
		}
		if (num != 0)
		{
			MotorcycleUiModelUtil.Instance.LoadMotorBySkinId(num, null);
			return;
		}
		MotorcycleUiModelParam param = new MotorcycleUiModelParam
		{
			FrameId = frameId,
			StickerIds = list3.ToArray(),
			DecorationIds = list4.ToArray()
		};
		MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
	}

	// Token: 0x0601413F RID: 82239 RVA: 0x005DA100 File Offset: 0x005D8300
	public void InitCameraInputData()
	{
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("摩托车贴纸商城");
		if (roleCameraConfig == null)
		{
			return;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("RoleCase").Value, ECollectActorType.UI);
		if (actorWithTag == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(0),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
	}

	// Token: 0x06014140 RID: 82240 RVA: 0x005DA185 File Offset: 0x005D8385
	protected override void OnBeforeShow()
	{
		MotorcycleUiModelUtil.Instance.SetSoarWingEnabled(true);
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
		this.HandleMotorShowByRewardList();
		this.RefreshView();
	}

	// Token: 0x06014141 RID: 82241 RVA: 0x005DA1AC File Offset: 0x005D83AC
	private void RefreshView()
	{
		MotorSkinBuyDetailViewData viewData = this.ViewData;
		ShopMotorSkinData shopMotorSkinData = (viewData != null) ? viewData.GetCurrentGoodsData() : null;
		MotorSkinData motorSkinData = (shopMotorSkinData != null) ? shopMotorSkinData.GetMotorSkinData() : null;
		if (viewData == null || shopMotorSkinData == null || motorSkinData == null)
		{
			return;
		}
		MotorSkinShow? motorSkinShow = motorSkinData.GetMotorSkinShow();
		if (motorSkinShow == null)
		{
			return;
		}
		shopMotorSkinData.GetCurrentGoodsData().SaveRemindState((long)TimeUtil.Instance.GetServerTime());
		bool ifCanBuy = shopMotorSkinData.GetIfCanBuy();
		base.GetText(15).SetUIActive(ifCanBuy);
		base.GetButton(13).RootUIComp.Get().SetUIActive(ifCanBuy);
		base.GetItem(17).SetUIActive(!ifCanBuy);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), motorSkinShow.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), motorSkinShow.Value.TypeDescription, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), motorSkinShow.Value.Desc ?? "", Array.Empty<object>());
		string discountText = viewData.GetDiscountText();
		base.GetText(16).SetUIActive(discountText != "");
		base.GetText(16).SetText(discountText, true);
		this.RefreshLeftTime(viewData);
		bool ifDirect = viewData.GetIfDirect();
		IPriceData priceData = viewData.GetPriceData();
		if (ifDirect)
		{
			base.GetText(15).SetText(viewData.GetDirectPriceText(), true);
		}
		else if (priceData != null)
		{
			base.GetText(15).SetText(priceData.NowPrice.ToString(), true);
		}
		int? num = (priceData != null) ? priceData.OriginalPrice : null;
		if (num != null)
		{
			base.GetText(15).SetText("<s>" + num.Value.ToString() + "</s>", true);
		}
		this.RefreshMainReward(this.ViewData);
		this.RefreshExtraReward(this.ViewData);
		if (ifCanBuy)
		{
			TotalTopUpPayAdditiveTagItem totalTopUpTagItem = this.TotalTopUpTagItem;
			if (totalTopUpTagItem == null)
			{
				return;
			}
			totalTopUpTagItem.RefreshByGoodsId(this.CurrentGoodsId);
			return;
		}
		else
		{
			TotalTopUpPayAdditiveTagItem totalTopUpTagItem2 = this.TotalTopUpTagItem;
			if (totalTopUpTagItem2 == null)
			{
				return;
			}
			totalTopUpTagItem2.SetUiActive(false);
			return;
		}
	}

	// Token: 0x06014142 RID: 82242 RVA: 0x005DA3E0 File Offset: 0x005D85E0
	private void RefreshLeftTime(MotorSkinBuyDetailViewData data)
	{
		ShopMotorSkinData currentGoodsData = data.GetCurrentGoodsData();
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double>? valueTuple = (currentGoodsData != null) ? new ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double>?(currentGoodsData.GetCurrentGoodsData().GetCountDownData()) : null;
		if (valueTuple == null)
		{
			return;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> value = valueTuple.Value;
		if (value.Item3 == 0.0)
		{
			base.GetItem(6).SetUIActive(false);
			return;
		}
		CommonDefine.IPayShowCountDownRemainTime item = value.Item2;
		base.GetItem(6).SetUIActive(true);
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime == null)
		{
			CommonDefine.IRemainTime remainTime = item as CommonDefine.IRemainTime;
			if (remainTime != null)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(7), remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
			}
			return;
		}
		UUIText text = base.GetText(7);
		if (text == null)
		{
			return;
		}
		text.SetText(payShowCountDownRemainTime.Value, true);
	}

	// Token: 0x06014143 RID: 82243 RVA: 0x005DA4B4 File Offset: 0x005D86B4
	[NullableContext(2)]
	private void RefreshMainReward(MotorSkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			return;
		}
		List<TItem> mainReward = data.GetCurrentGoodsData().GetMainReward();
		List<SkinRewardData> list = new List<SkinRewardData>();
		foreach (TItem value in mainReward)
		{
			list.Add(new SkinRewardData
			{
				ItemData = new TItem?(value),
				FinishState = !data.GetCurrentGoodsData().GetIfCanBuy()
			});
		}
		GenericLayout<SkinRewardItemGrid, SkinRewardData> mainRewardLayout = this.MainRewardLayout;
		if (mainRewardLayout == null)
		{
			return;
		}
		mainRewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06014144 RID: 82244 RVA: 0x005DA558 File Offset: 0x005D8758
	[NullableContext(2)]
	private void RefreshExtraReward(MotorSkinBuyDetailViewData data)
	{
		if (data == null || data.GetCurrentGoodsData() == null)
		{
			return;
		}
		TItem? otherReward = data.GetCurrentGoodsData().GetOtherReward();
		if (otherReward == null)
		{
			return;
		}
		SkinRewardData skinRewardData = new SkinRewardData();
		skinRewardData.ItemData = new TItem?(otherReward.Value);
		skinRewardData.FinishState = !data.GetCurrentGoodsData().GetIfCanBuy();
		GenericLayout<SkinRewardItemGrid, SkinRewardData> exRewardLayout = this.ExRewardLayout;
		if (exRewardLayout == null)
		{
			return;
		}
		exRewardLayout.RefreshByData(new List<SkinRewardData>
		{
			skinRewardData
		}, null, false);
	}

	// Token: 0x06014145 RID: 82245 RVA: 0x005DA5D1 File Offset: 0x005D87D1
	protected override void OnAfterShow()
	{
		this.CameraInputBinding.Bind();
	}

	// Token: 0x06014146 RID: 82246 RVA: 0x005DA5E0 File Offset: 0x005D87E0
	protected override void OnTick(float delta)
	{
		MotorSkinBuyDetailViewData viewData = this.ViewData;
		PayShopGoods payShopGoods;
		if (viewData == null)
		{
			payShopGoods = null;
		}
		else
		{
			ShopMotorSkinData currentGoodsData = viewData.GetCurrentGoodsData();
			payShopGoods = ((currentGoodsData != null) ? currentGoodsData.GetCurrentGoodsData() : null);
		}
		PayShopGoods payShopGoods2 = payShopGoods;
		if (payShopGoods2 == null)
		{
			return;
		}
		if (payShopGoods2.NeedDown())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
			Action value = delegate()
			{
				base.CloseMe(null);
			};
			confirmBoxDataNew.FunctionMap[1] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
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
				ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
				confirmBoxDataNew2.FunctionMap[2] = new Action(this.RefreshView);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
			}
		}
	}

	// Token: 0x06014147 RID: 82247 RVA: 0x005DA727 File Offset: 0x005D8927
	protected override void OnBeforeHide()
	{
		this.CameraInputBinding.Unbind();
		MotorcycleUiModelUtil.Instance.SetSoarWingEnabled(false);
		MotorcycleUiModelUtil.Instance.ClearMotorBuff();
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
	}

	// Token: 0x06014148 RID: 82248 RVA: 0x005DA754 File Offset: 0x005D8954
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x06014149 RID: 82249 RVA: 0x005DA760 File Offset: 0x005D8960
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601414A RID: 82250 RVA: 0x005DA769 File Offset: 0x005D8969
	private void OnClickBtnConfirmB()
	{
		PayShopController.Instance.OpenBuySkinDetailView(this.ViewData.GetCurrentGoodsData().GetCurrentGoodsData());
	}

	// Token: 0x0601414B RID: 82251 RVA: 0x005DA788 File Offset: 0x005D8988
	private void OnClickOnlyUiToggle(EToggleState toggleState)
	{
		this.IsObserving = !this.IsObserving;
		bool state = this.IsObserving;
		if (!state)
		{
			base.GetItem(3).SetUIActive(!state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
			return;
		}
		base.PlaySequence("UiOut", delegate
		{
			if (this.IsDestroyOrDestroying)
			{
				return;
			}
			this.GetItem(3).SetUIActive(!state);
		}, true);
	}

	// Token: 0x0601414C RID: 82252 RVA: 0x005DA81E File Offset: 0x005D8A1E
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetHandleName() == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
			}
		}
	}

	// Token: 0x0601414D RID: 82253 RVA: 0x005DA849 File Offset: 0x005D8A49
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(478);
	}

	// Token: 0x0601414E RID: 82254 RVA: 0x005DA85A File Offset: 0x005D8A5A
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x0601414F RID: 82255 RVA: 0x005DA864 File Offset: 0x005D8A64
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		ShopMotorSkinData currentGoodsData = this.ViewData.GetCurrentGoodsData();
		int? num = (currentGoodsData != null) ? new int?(currentGoodsData.GetCurrentGoodsData().GetGoodsId()) : null;
		if (!(goodsId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.RefreshView();
	}

	// Token: 0x0400AAB5 RID: 43701
	private const int DEFAULT_MOTOR_SKIN_ID = 89200000;

	// Token: 0x0400AAB6 RID: 43702
	private const string MOTORCYCLE_SHOP_ROOT_VIEW_CAMERA_CONFIG_ID = "摩托车贴纸商城";

	// Token: 0x0400AAB7 RID: 43703
	[Nullable(2)]
	private MotorSkinBuyDetailViewData ViewData;

	// Token: 0x0400AAB8 RID: 43704
	private int CurrentPayItemId;

	// Token: 0x0400AAB9 RID: 43705
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400AABA RID: 43706
	[Nullable(2)]
	private string WaitCameraId;

	// Token: 0x0400AABB RID: 43707
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AABC RID: 43708
	private bool CurrentDiscountState;

	// Token: 0x0400AABD RID: 43709
	private bool CanLoadModel;

	// Token: 0x0400AABE RID: 43710
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> MainRewardLayout;

	// Token: 0x0400AABF RID: 43711
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ExRewardLayout;

	// Token: 0x0400AAC0 RID: 43712
	private bool IsObserving;

	// Token: 0x0400AAC1 RID: 43713
	[Nullable(2)]
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x0400AAC2 RID: 43714
	private int CurrentGoodsId;

	// Token: 0x0400AAC3 RID: 43715
	private const int MOTOR_SHOP_HELP_ID = 478;

	// Token: 0x0400AAC4 RID: 43716
	private const int MOTOR_FIXED_FRAME_ID = 89400001;

	// Token: 0x020082AB RID: 33451
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A372 RID: 172914
		BtnMask,
		// Token: 0x0402A373 RID: 172915
		OnlyUiToggle,
		// Token: 0x0402A374 RID: 172916
		UiItemCaption,
		// Token: 0x0402A375 RID: 172917
		PanelHide,
		// Token: 0x0402A376 RID: 172918
		TxtTitle,
		// Token: 0x0402A377 RID: 172919
		TxtType,
		// Token: 0x0402A378 RID: 172920
		LeftTimeItem,
		// Token: 0x0402A379 RID: 172921
		LeftTimeText,
		// Token: 0x0402A37A RID: 172922
		MainRewardLayout,
		// Token: 0x0402A37B RID: 172923
		UiItemItemBaseB3,
		// Token: 0x0402A37C RID: 172924
		ExRewardLayout,
		// Token: 0x0402A37D RID: 172925
		UiItemItemBaseB4,
		// Token: 0x0402A37E RID: 172926
		TxtContent,
		// Token: 0x0402A37F RID: 172927
		BtnConfirmB,
		// Token: 0x0402A380 RID: 172928
		PanelHorizontalLayout,
		// Token: 0x0402A381 RID: 172929
		TxtPrice,
		// Token: 0x0402A382 RID: 172930
		DiscountText,
		// Token: 0x0402A383 RID: 172931
		PanelGot,
		// Token: 0x0402A384 RID: 172932
		PanelTagRoot
	}
}
