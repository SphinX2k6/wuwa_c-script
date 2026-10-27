using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A2A RID: 10794
[NullableContext(1)]
[Nullable(0)]
public class MotorSkinBuyDetailView : UiTickViewBase
{
	// Token: 0x0601672E RID: 91950 RVA: 0x005AEA64 File Offset: 0x005ACC64
	public MotorSkinBuyDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601672F RID: 91951 RVA: 0x005AEA78 File Offset: 0x005ACC78
	[NullableContext(2)]
	public MotorSkinBuyDetailViewData GetViewData()
	{
		return this.ViewData;
	}

	// Token: 0x06016730 RID: 91952 RVA: 0x005AEA80 File Offset: 0x005ACC80
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

	// Token: 0x06016731 RID: 91953 RVA: 0x005AED88 File Offset: 0x005ACF88
	protected override UniTask OnBeforeStartAsync()
	{
		MotorSkinBuyDetailView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinBuyDetailView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016732 RID: 91954 RVA: 0x005AEDCC File Offset: 0x005ACFCC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06016733 RID: 91955 RVA: 0x005AEE30 File Offset: 0x005AD030
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06016734 RID: 91956 RVA: 0x005AEE94 File Offset: 0x005AD094
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

	// Token: 0x06016735 RID: 91957 RVA: 0x005AEFBD File Offset: 0x005AD1BD
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x06016736 RID: 91958 RVA: 0x005AEFC4 File Offset: 0x005AD1C4
	protected override void OnHandleLoadScene()
	{
		this.InitMotorModel();
		this.InitCameraInputData();
	}

	// Token: 0x06016737 RID: 91959 RVA: 0x005AEFD2 File Offset: 0x005AD1D2
	private void InitMotorModel()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
		this.HandleMotorShowByRewardList();
	}

	// Token: 0x06016738 RID: 91960 RVA: 0x005AEFE8 File Offset: 0x005AD1E8
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

	// Token: 0x06016739 RID: 91961 RVA: 0x005AF104 File Offset: 0x005AD304
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
		UiCameraInputComponentData data = new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(0),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
	}

	// Token: 0x0601673A RID: 91962 RVA: 0x005AF189 File Offset: 0x005AD389
	protected override void OnBeforeShow()
	{
		MotorcycleUiModelUtil.Instance.SetSoarWingEnabled(true);
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
		this.HandleMotorShowByRewardList();
		this.RefreshView();
	}

	// Token: 0x0601673B RID: 91963 RVA: 0x005AF1B0 File Offset: 0x005AD3B0
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

	// Token: 0x0601673C RID: 91964 RVA: 0x005AF3E4 File Offset: 0x005AD5E4
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

	// Token: 0x0601673D RID: 91965 RVA: 0x005AF4B8 File Offset: 0x005AD6B8
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

	// Token: 0x0601673E RID: 91966 RVA: 0x005AF55C File Offset: 0x005AD75C
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

	// Token: 0x0601673F RID: 91967 RVA: 0x005AF5D5 File Offset: 0x005AD7D5
	protected override void OnAfterShow()
	{
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
	}

	// Token: 0x06016740 RID: 91968 RVA: 0x005AF5F0 File Offset: 0x005AD7F0
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

	// Token: 0x06016741 RID: 91969 RVA: 0x005AF737 File Offset: 0x005AD937
	protected override void OnBeforeHide()
	{
		this.CameraInputComponent.End();
		MotorcycleUiModelUtil.Instance.SetSoarWingEnabled(false);
		MotorcycleUiModelUtil.Instance.ClearMotorBuff();
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
	}

	// Token: 0x06016742 RID: 91970 RVA: 0x005AF764 File Offset: 0x005AD964
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x06016743 RID: 91971 RVA: 0x005AF770 File Offset: 0x005AD970
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016744 RID: 91972 RVA: 0x005AF779 File Offset: 0x005AD979
	private void OnClickBtnConfirmB()
	{
		PayShopController.Instance.OpenBuySkinDetailView(this.ViewData.GetCurrentGoodsData().GetCurrentGoodsData());
	}

	// Token: 0x06016745 RID: 91973 RVA: 0x005AF798 File Offset: 0x005AD998
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

	// Token: 0x06016746 RID: 91974 RVA: 0x005AF82E File Offset: 0x005ADA2E
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.HandleName == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
			}
		}
	}

	// Token: 0x06016747 RID: 91975 RVA: 0x005AF859 File Offset: 0x005ADA59
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(478);
	}

	// Token: 0x06016748 RID: 91976 RVA: 0x005AF86A File Offset: 0x005ADA6A
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		this.RefreshView();
	}

	// Token: 0x06016749 RID: 91977 RVA: 0x005AF874 File Offset: 0x005ADA74
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

	// Token: 0x0400A6CB RID: 42699
	private const int DEFAULT_MOTOR_SKIN_ID = 89200000;

	// Token: 0x0400A6CC RID: 42700
	private const string MOTORCYCLE_SHOP_ROOT_VIEW_CAMERA_CONFIG_ID = "摩托车贴纸商城";

	// Token: 0x0400A6CD RID: 42701
	[Nullable(2)]
	private MotorSkinBuyDetailViewData ViewData;

	// Token: 0x0400A6CE RID: 42702
	private int CurrentPayItemId;

	// Token: 0x0400A6CF RID: 42703
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0400A6D0 RID: 42704
	[Nullable(2)]
	private string WaitCameraId;

	// Token: 0x0400A6D1 RID: 42705
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A6D2 RID: 42706
	private bool CurrentDiscountState;

	// Token: 0x0400A6D3 RID: 42707
	private bool CanLoadModel;

	// Token: 0x0400A6D4 RID: 42708
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> MainRewardLayout;

	// Token: 0x0400A6D5 RID: 42709
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ExRewardLayout;

	// Token: 0x0400A6D6 RID: 42710
	private bool IsObserving;

	// Token: 0x0400A6D7 RID: 42711
	[Nullable(2)]
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x0400A6D8 RID: 42712
	private int CurrentGoodsId;

	// Token: 0x0400A6D9 RID: 42713
	private const int MOTOR_SHOP_HELP_ID = 478;

	// Token: 0x0400A6DA RID: 42714
	private const int MOTOR_FIXED_FRAME_ID = 89400001;

	// Token: 0x02009064 RID: 36964
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402EC7A RID: 191610
		BtnMask,
		// Token: 0x0402EC7B RID: 191611
		OnlyUiToggle,
		// Token: 0x0402EC7C RID: 191612
		UiItemCaption,
		// Token: 0x0402EC7D RID: 191613
		PanelHide,
		// Token: 0x0402EC7E RID: 191614
		TxtTitle,
		// Token: 0x0402EC7F RID: 191615
		TxtType,
		// Token: 0x0402EC80 RID: 191616
		LeftTimeItem,
		// Token: 0x0402EC81 RID: 191617
		LeftTimeText,
		// Token: 0x0402EC82 RID: 191618
		MainRewardLayout,
		// Token: 0x0402EC83 RID: 191619
		UiItemItemBaseB3,
		// Token: 0x0402EC84 RID: 191620
		ExRewardLayout,
		// Token: 0x0402EC85 RID: 191621
		UiItemItemBaseB4,
		// Token: 0x0402EC86 RID: 191622
		TxtContent,
		// Token: 0x0402EC87 RID: 191623
		BtnConfirmB,
		// Token: 0x0402EC88 RID: 191624
		PanelHorizontalLayout,
		// Token: 0x0402EC89 RID: 191625
		TxtPrice,
		// Token: 0x0402EC8A RID: 191626
		DiscountText,
		// Token: 0x0402EC8B RID: 191627
		PanelGot,
		// Token: 0x0402EC8C RID: 191628
		PanelTagRoot
	}
}
