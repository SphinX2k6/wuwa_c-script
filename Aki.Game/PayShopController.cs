using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02002356 RID: 9046
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PayShopController : UiControllerBase
{
	// Token: 0x0601204B RID: 73803 RVA: 0x0046AEE8 File Offset: 0x004690E8
	protected override void OnRegisterNetEvent()
	{
		Net instance = Net.Instance;
		ENotifyMessageId id = ENotifyMessageId.PayShopInfoNotify;
		Action<IMessage, Net.CallbackStatus> callback;
		if ((callback = PayShopController.<>O.<0>__NotifyPayShopInfo) == null)
		{
			callback = (PayShopController.<>O.<0>__NotifyPayShopInfo = new Action<IMessage, Net.CallbackStatus>(PayShopController.NotifyPayShopInfo));
		}
		instance.Register(id, callback);
		Net instance2 = Net.Instance;
		ENotifyMessageId id2 = ENotifyMessageId.PayShopUnlockNotify;
		Action<IMessage, Net.CallbackStatus> callback2;
		if ((callback2 = PayShopController.<>O.<1>__NotifyPayShopUnlock) == null)
		{
			callback2 = (PayShopController.<>O.<1>__NotifyPayShopUnlock = new Action<IMessage, Net.CallbackStatus>(PayShopController.NotifyPayShopUnlock));
		}
		instance2.Register(id2, callback2);
		Net instance3 = Net.Instance;
		ENotifyMessageId id3 = ENotifyMessageId.PayShopDirectBuyNotify;
		Action<IMessage, Net.CallbackStatus> callback3;
		if ((callback3 = PayShopController.<>O.<2>__NotifyPayShopDirectBuy) == null)
		{
			callback3 = (PayShopController.<>O.<2>__NotifyPayShopDirectBuy = new Action<IMessage, Net.CallbackStatus>(PayShopController.NotifyPayShopDirectBuy));
		}
		instance3.Register(id3, callback3);
		Net instance4 = Net.Instance;
		ENotifyMessageId id4 = ENotifyMessageId.PayShopConditionFinishNotify;
		Action<IMessage, Net.CallbackStatus> callback4;
		if ((callback4 = PayShopController.<>O.<3>__NotifyPayShopConditionFinish) == null)
		{
			callback4 = (PayShopController.<>O.<3>__NotifyPayShopConditionFinish = new Action<IMessage, Net.CallbackStatus>(PayShopController.NotifyPayShopConditionFinish));
		}
		instance4.Register(id4, callback4);
	}

	// Token: 0x0601204C RID: 73804 RVA: 0x0046AFA4 File Offset: 0x004691A4
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PayShopInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PayShopUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PayShopDirectBuyNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PayShopConditionFinishNotify);
	}

	// Token: 0x0601204D RID: 73805 RVA: 0x0046AFF1 File Offset: 0x004691F1
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x0601204E RID: 73806 RVA: 0x0046B02B File Offset: 0x0046922B
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x0601204F RID: 73807 RVA: 0x0046B068 File Offset: 0x00469268
	[NullableContext(2)]
	private static void NotifyPayShopInfo(IMessage msg, Net.CallbackStatus _)
	{
		PayShopInfoNotify payShopInfoNotify = (PayShopInfoNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "PayShop:ShopItem NotifyPayShopInfo 接收到商品信息更新";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("version", payShopInfoNotify.Version);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RepeatedField<PayShopInfo> infos = payShopInfoNotify.Infos;
		PayShopModel.Instance.Version = payShopInfoNotify.Version;
		PayShopModel.Instance.SetPayShopInfoList(infos.ToList<PayShopInfo>());
		PayShopModel.Instance.SetPayShopTabData(payShopInfoNotify.PayShopTabConfigs.ToList<PayShopTabConfigInfo>());
		PayShopModel.Instance.SetPayShopRecommendData(payShopInfoNotify.PayShopRecommends.ToList<PayShopRecommendConfigInfo>());
		PayGiftController.Instance.OnShopInfoNotify(payShopInfoNotify);
	}

	// Token: 0x06012050 RID: 73808 RVA: 0x0046B104 File Offset: 0x00469304
	[NullableContext(2)]
	private static void NotifyPayShopUnlock(IMessage msg, Net.CallbackStatus _)
	{
		RepeatedField<int> unlockList = ((PayShopUnlockNotify)msg).UnlockList;
		PayShopModel.Instance.UnLockPayShopGoods(unlockList.ToList<int>());
	}

	// Token: 0x06012051 RID: 73809 RVA: 0x0046B130 File Offset: 0x00469330
	[NullableContext(2)]
	private static void NotifyPayShopConditionFinish(IMessage msg, Net.CallbackStatus _)
	{
		RepeatedField<Aki.Protocol.PayShopItem> items = ((PayShopConditionFinishNotify)msg).Items;
		PayShopModel.Instance.SetPayShopGoodsList(items.ToList<Aki.Protocol.PayShopItem>());
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.YZY, "PayShop:ShopItem NotifyPayShopConditionFinish 接收到商品信息更新", default(ReadOnlySpan<ValueTuple<string, object>>));
		EventSystem.Instance.Emit<List<Aki.Protocol.PayShopItem>>(EEventName.OnPayShopConditionFinish, items.ToList<Aki.Protocol.PayShopItem>());
	}

	// Token: 0x06012052 RID: 73810 RVA: 0x0046B18C File Offset: 0x0046938C
	[NullableContext(2)]
	private unsafe static void NotifyPayShopDirectBuy(IMessage msg, Net.CallbackStatus _)
	{
		PayShopDirectBuyNotify payShopDirectBuyNotify = (PayShopDirectBuyNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "PayShop:ShopItem NotifyPayShopDirectBuy 接收到直购结构";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", payShopDirectBuyNotify.ShopItemId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", payShopDirectBuyNotify.ItemCount);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		KuroSdkReport.Instance.OnPayShopDirectBuy(payShopDirectBuyNotify.ShopItemId);
		int shopItemId = payShopDirectBuyNotify.ShopItemId;
		if (payShopDirectBuyNotify.ShopItemId != 0)
		{
			PayShopModel.Instance.UpdatePayShopGoodsCount(payShopDirectBuyNotify.ShopItemId, payShopDirectBuyNotify.ItemCount);
		}
		if (payShopDirectBuyNotify.ShopItemId != 42 && payShopDirectBuyNotify.ShopItemId != 43 && payShopDirectBuyNotify.ShopItemId != 44)
		{
			int shopItemId2 = payShopDirectBuyNotify.ShopItemId;
		}
		EventSystem.Instance.Emit(EEventName.PayShopGoodsBuy);
	}

	// Token: 0x06012053 RID: 73811 RVA: 0x0046B274 File Offset: 0x00469474
	private void OnWorldDone()
	{
		if (FunctionModel.Instance.IsOpen(10010))
		{
			this.SendRequestPayShopInfo(false, 0);
		}
	}

	// Token: 0x06012054 RID: 73812 RVA: 0x0046B290 File Offset: 0x00469490
	private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
	{
		if (functionType != EFunctionType.Shop)
		{
			return;
		}
		if (!isOpen)
		{
			return;
		}
		this.SendRequestPayShopInfo(false, 0);
	}

	// Token: 0x06012055 RID: 73813 RVA: 0x0046B2A8 File Offset: 0x004694A8
	[NullableContext(0)]
	public UniTask<bool> SendRequestPayShopInfo(bool needErrorCode = true, int timeoutMs = 0)
	{
		PayShopController.<SendRequestPayShopInfo>d__10 <SendRequestPayShopInfo>d__;
		<SendRequestPayShopInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendRequestPayShopInfo>d__.needErrorCode = needErrorCode;
		<SendRequestPayShopInfo>d__.timeoutMs = timeoutMs;
		<SendRequestPayShopInfo>d__.<>1__state = -1;
		<SendRequestPayShopInfo>d__.<>t__builder.Start<PayShopController.<SendRequestPayShopInfo>d__10>(ref <SendRequestPayShopInfo>d__);
		return <SendRequestPayShopInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06012056 RID: 73814 RVA: 0x0046B2F4 File Offset: 0x004694F4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<PayShopUpdateResponse> SendRequestPayShopUpdateAsync(PayShopDefine.EPayShopTabType payShopId, bool isSwitch)
	{
		PayShopController.<SendRequestPayShopUpdateAsync>d__11 <SendRequestPayShopUpdateAsync>d__;
		<SendRequestPayShopUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<PayShopUpdateResponse>.Create();
		<SendRequestPayShopUpdateAsync>d__.<>4__this = this;
		<SendRequestPayShopUpdateAsync>d__.payShopId = payShopId;
		<SendRequestPayShopUpdateAsync>d__.isSwitch = isSwitch;
		<SendRequestPayShopUpdateAsync>d__.<>1__state = -1;
		<SendRequestPayShopUpdateAsync>d__.<>t__builder.Start<PayShopController.<SendRequestPayShopUpdateAsync>d__11>(ref <SendRequestPayShopUpdateAsync>d__);
		return <SendRequestPayShopUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012057 RID: 73815 RVA: 0x0046B348 File Offset: 0x00469548
	[NullableContext(2)]
	public unsafe void SendRequestPayShopUpdate(PayShopDefine.EPayShopTabType payShopId, bool isSwitch, Action<PayShopUpdateResponse> responseCallback = null)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:Root 请求刷新商城数据";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ShopId", payShopId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsSwitch", isSwitch);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		PayShopUpdateRequest payShopUpdateRequest = PayShopUpdateRequest.Create();
		payShopUpdateRequest.Id = (int)payShopId;
		Net.Instance.Call(ERequestMessageId.PayShopUpdateRequest, payShopUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PayShopUpdateResponse response = (PayShopUpdateResponse)msg;
			if (response == null)
			{
				Action<PayShopUpdateResponse> responseCallback2 = responseCallback;
				if (responseCallback2 == null)
				{
					return;
				}
				responseCallback2(null);
				return;
			}
			else if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				PayShopInfo payShopInfo = response.Info;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Shop;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "PayShop:Root 请求刷新商城数据成功";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ShopId", payShopId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("IsSwitch", isSwitch);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				PayShopModel.Instance.SetPayShopInfo(payShopInfo);
				bool ifNeedQueryProductInfoForce = PlatformSdkManagerNew.Instance.GetPlatformSdk().GetIfNeedQueryProductInfoForce();
				Action callback = delegate()
				{
					if (isSwitch)
					{
						EventSystem.Instance.Emit<PayShopDefine.EPayShopTabType>(EEventName.SwitchPayShopView, (PayShopDefine.EPayShopTabType)payShopInfo.Id);
					}
					else
					{
						EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, payShopInfo.Id, true);
					}
					Action<PayShopUpdateResponse> responseCallback4 = responseCallback;
					if (responseCallback4 == null)
					{
						return;
					}
					responseCallback4(response);
				};
				if (!ifNeedQueryProductInfoForce)
				{
					callback();
					return;
				}
				List<string> shopQueryProductIdArray = this.GetShopQueryProductIdArray(payShopId);
				if (shopQueryProductIdArray != null && shopQueryProductIdArray.Count > 0)
				{
					PayItemController.Instance.QueryProductInfoAsync(shopQueryProductIdArray).ContinueWith(delegate(bool _)
					{
						callback();
					});
					return;
				}
				callback();
				return;
			}
			else
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 22804, null, true, true);
				Action<PayShopUpdateResponse> responseCallback3 = responseCallback;
				if (responseCallback3 == null)
				{
					return;
				}
				responseCallback3(response);
				return;
			}
		}, 0);
	}

	// Token: 0x06012058 RID: 73816 RVA: 0x0046B410 File Offset: 0x00469610
	private List<string> GetShopQueryProductIdArray(PayShopDefine.EPayShopTabType payShopId)
	{
		List<string> list = new List<string>();
		if (payShopId == PayShopDefine.EPayShopTabType.Recharge)
		{
			foreach (PayItemData payItemData in PayItemModel.Instance.GetDataList())
			{
				list.Add(payItemData.ProductId);
			}
		}
		if (PayShopDefine.payGiftRoutedShopSet.Contains(payShopId))
		{
			foreach (PayPackageData payPackageData in PayGiftModel.Instance.GetPayGiftDataList())
			{
				list.Add(payPackageData.ProductId);
			}
		}
		return list;
	}

	// Token: 0x06012059 RID: 73817 RVA: 0x0046B4D4 File Offset: 0x004696D4
	public void OpenBuySkinDetailView(PayShopGoods good)
	{
		if (!good.IsDirect())
		{
			this.OpenBuyViewByGoodsId(good, null);
			return;
		}
		int id = good.GetGoodsData().Id;
		PayGiftController.Instance.SdkPay(id);
		OnOpenGiftPackageDetailsViewLogEvent onOpenGiftPackageDetailsViewLogEvent = new OnOpenGiftPackageDetailsViewLogEvent();
		onOpenGiftPackageDetailsViewLogEvent.i_id = id;
		onOpenGiftPackageDetailsViewLogEvent.i_shop_id = (int)good.PayShopId;
		onOpenGiftPackageDetailsViewLogEvent.i_tab_id = good.GetGoodsData().TabId;
		onOpenGiftPackageDetailsViewLogEvent.i_buy_through_third_party = ((good.IfPayGift() > false) ? 1 : 0);
		LogReportController.Instance.LogReport(onOpenGiftPackageDetailsViewLogEvent);
	}

	// Token: 0x0601205A RID: 73818 RVA: 0x0046B550 File Offset: 0x00469750
	public void SendRequestPayShopItemUpdate(int[] goodsIdList)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "PayShop:ShopItem 请求刷新商品列表";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("goodsIdList", goodsIdList);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		PayShopItemUpdateRequest payShopItemUpdateRequest = PayShopItemUpdateRequest.Create();
		payShopItemUpdateRequest.ShopItemIds.AddRange(goodsIdList);
		Net.Instance.Call(ERequestMessageId.PayShopItemUpdateRequest, payShopItemUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PayShopItemUpdateResponse payShopItemUpdateResponse = (PayShopItemUpdateResponse)msg;
			if (payShopItemUpdateResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				RepeatedField<Aki.Protocol.PayShopItem> items = payShopItemUpdateResponse.Items;
				PayShopModel.Instance.SetPayShopGoodsList(items.ToList<Aki.Protocol.PayShopItem>());
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(payShopItemUpdateResponse.ErrorCode, 27686, null, true, true);
		}, 0);
	}

	// Token: 0x0601205B RID: 73819 RVA: 0x0046B5C8 File Offset: 0x004697C8
	public unsafe void SendRequestPayShopBuy(int goodsId, int count = 1)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:ShopItem 请求购买商品";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", goodsId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Count", count);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		PayShopGoodsData goodsData = PayShopModel.Instance.GetPayShopGoods(goodsId).GetGoodsData();
		this.SendRequestPayShopNormalBuy(goodsId, count, goodsData);
	}

	// Token: 0x0601205C RID: 73820 RVA: 0x0046B64C File Offset: 0x0046984C
	protected unsafe void SendRequestPayShopNormalBuy(int goodsId, int buyCount, PayShopGoodsData payShopData)
	{
		PayShopBuyRequest payShopBuyRequest = PayShopBuyRequest.Create();
		payShopBuyRequest.Id = goodsId;
		payShopBuyRequest.Count = buyCount;
		payShopBuyRequest.Version = PayShopModel.Instance.Version;
		Net.Instance.Call(ERequestMessageId.PayShopBuyRequest, payShopBuyRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PayShopBuyResponse payShopBuyResponse = (PayShopBuyResponse)msg;
			if (payShopBuyResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Shop;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "PayShop:ShopItem 购买商品成功";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", goodsId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Count", buyCount);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				PayShopModel.Instance.UpdatePayShopGoodsCount(payShopBuyResponse.Id, payShopBuyResponse.Count);
				EventSystem.Instance.Emit(EEventName.PayShopGoodsBuy);
				return;
			}
			if (payShopBuyResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrPayShopDataChanged)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Shop;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "PayShop:ShopItem 商品数据不同步,通知versioncode变化";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", goodsId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Count", buyCount);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, payShopData.ShopId, false);
				EventSystem.Instance.Emit(EEventName.ShopVersionCodeChange);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(payShopBuyResponse.ErrorCode, 25381, null, true, true);
		}, 0);
	}

	// Token: 0x0601205D RID: 73821 RVA: 0x0046B6C0 File Offset: 0x004698C0
	public void ActivityPayShopBuyRequest(List<ActivityBuyItem> buyItems, [Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<bool, List<ActivityBuyItem>> callback = null)
	{
		if (buyItems.Count == 0)
		{
			return;
		}
		int id = buyItems[0].Id;
		PayShopGoodsData goodsData = PayShopModel.Instance.GetPayShopGoods(id).GetGoodsData();
		this.ActivityPayShopBuyRequestInternal(buyItems, goodsData, callback);
	}

	// Token: 0x0601205E RID: 73822 RVA: 0x0046B700 File Offset: 0x00469900
	private void ActivityPayShopBuyRequestInternal(List<ActivityBuyItem> buyItems, PayShopGoodsData payShopData, [Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<bool, List<ActivityBuyItem>> callback = null)
	{
		ActivityPayShopBuyRequest activityPayShopBuyRequest = Aki.Protocol.ActivityPayShopBuyRequest.Create();
		activityPayShopBuyRequest.BuyItems.AddRange(buyItems);
		activityPayShopBuyRequest.Version = PayShopModel.Instance.Version;
		Net.Instance.Call(ERequestMessageId.ActivityPayShopBuyRequest, activityPayShopBuyRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ActivityPayShopBuyResponse activityPayShopBuyResponse = (ActivityPayShopBuyResponse)msg;
			if (activityPayShopBuyResponse != null)
			{
				RepeatedField<ActivityBuyItem> buyItems2 = activityPayShopBuyResponse.BuyItems;
				bool flag = buyItems2.Count != buyItems.Count;
				if (flag)
				{
					Log.Instance.Info(ELogModule.Shop, ELogAuthor.LZK, "[PayShop] 部分活动商品购买失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					Log.Instance.Info(ELogModule.Shop, ELogAuthor.LZK, "[PayShop] 活动商品购买成功", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				foreach (ActivityBuyItem activityBuyItem in buyItems)
				{
					PayShopModel.Instance.UpdateActivityPayShopGoodsCount(activityBuyItem.Id, activityBuyItem.Count);
				}
				EventSystem.Instance.Emit<int, IReadOnlyList<ActivityBuyItem>, string>(EEventName.ActivityPayShopGoodsBuy, payShopData.ShopId, buyItems, PayShopModel.Instance.Version);
				if (flag)
				{
					List<ActivityBuyItem> list = new List<ActivityBuyItem>();
					foreach (ActivityBuyItem activityBuyItem2 in buyItems)
					{
						bool flag2 = false;
						using (IEnumerator<ActivityBuyItem> enumerator2 = buyItems2.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.Id == activityBuyItem2.Id)
								{
									flag2 = true;
									break;
								}
							}
						}
						if (!flag2)
						{
							list.Add(activityBuyItem2);
						}
					}
					Action<bool, List<ActivityBuyItem>> callback2 = callback;
					if (callback2 != null)
					{
						callback2(true, list);
					}
				}
				else
				{
					Action<bool, List<ActivityBuyItem>> callback3 = callback;
					if (callback3 != null)
					{
						callback3(true, null);
					}
				}
				if (activityPayShopBuyResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(activityPayShopBuyResponse.ErrorCode, 18847, null, true, true);
				}
				return;
			}
			Action<bool, List<ActivityBuyItem>> callback4 = callback;
			if (callback4 == null)
			{
				return;
			}
			callback4(false, null);
		}, 0);
	}

	// Token: 0x0601205F RID: 73823 RVA: 0x0046B76C File Offset: 0x0046996C
	public void OpenGiftDetailsView(PayShopGoods good)
	{
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShop:ShopItem 打开礼包界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		ExchangePopData exchangePopData = new ExchangePopData();
		exchangePopData.PayShopGoods = good;
		UiManager.Instance.OpenView(EUiViewName.GiftPackageDetailsView, exchangePopData, null);
		if (PayShopDefine.payGiftRoutedShopSet.Contains(good.PayShopId) || good.PayShopId == PayShopDefine.EPayShopTabType.SkinShop)
		{
			OnOpenGiftPackageDetailsViewLogEvent onOpenGiftPackageDetailsViewLogEvent = new OnOpenGiftPackageDetailsViewLogEvent();
			onOpenGiftPackageDetailsViewLogEvent.i_id = good.GetGoodsData().Id;
			onOpenGiftPackageDetailsViewLogEvent.i_shop_id = (int)good.PayShopId;
			onOpenGiftPackageDetailsViewLogEvent.i_tab_id = good.GetGoodsData().TabId;
			onOpenGiftPackageDetailsViewLogEvent.i_buy_through_third_party = ((good.IfPayGift() > false) ? 1 : 0);
			LogReportController.Instance.LogReport(onOpenGiftPackageDetailsViewLogEvent);
		}
	}

	// Token: 0x06012060 RID: 73824 RVA: 0x0046B81C File Offset: 0x00469A1C
	[NullableContext(2)]
	public void OpenExchangePopView(int goodsId, PayShopExchangeExtraData extraData = null)
	{
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShop:ShopItem 打开兑换界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		ExchangePopData exchangePopData = new ExchangePopData();
		PayShopGoods payShopGoods = PayShopModel.Instance.GetPayShopGoods(goodsId);
		exchangePopData.PayShopGoods = payShopGoods;
		exchangePopData.ShopItemResource = "UiItem_ShopItem";
		exchangePopData.GetMaxBuyCount = ((extraData != null) ? extraData.GetMaxBuyCount : null);
		exchangePopData.CheckIfCanBuy = ((extraData != null) ? extraData.CheckIfCanBuy : null);
		UiManager.Instance.OpenView(EUiViewName.ExchangePopView, exchangePopData, null);
		if ((payShopGoods != null && payShopGoods.PayShopId == PayShopDefine.EPayShopTabType.ExchangeEntry) || (payShopGoods != null && payShopGoods.PayShopId == PayShopDefine.EPayShopTabType.ActivityShop))
		{
			OnClickPayShopItemLogEvent onClickPayShopItemLogEvent = new OnClickPayShopItemLogEvent();
			onClickPayShopItemLogEvent.i_id = goodsId;
			onClickPayShopItemLogEvent.i_shop_id = (int)payShopGoods.PayShopId;
			onClickPayShopItemLogEvent.i_tab_id = payShopGoods.GetGoodsData().TabId;
			LogReportController.Instance.LogReport(onClickPayShopItemLogEvent);
		}
	}

	// Token: 0x06012061 RID: 73825 RVA: 0x0046B8EC File Offset: 0x00469AEC
	public void OpenBuyViewByGoodsId(PayShopGoods good, [Nullable(2)] PayShopExchangeExtraData extraData = null)
	{
		int id = good.GetGoodsData().Id;
		good.SaveRemindState((long)TimeUtil.Instance.GetServerTime());
		if (good.CheckIfMonthCardItem())
		{
			this.OpenGiftDetailsView(good);
			return;
		}
		if (good.GetGoodsData().GetRewardItemType().GetValueOrDefault() == InventoryDefine.EItemType.Gift)
		{
			int? giftId = good.GetGoodsData().GetGiftId();
			if (giftId != null)
			{
				GiftPackageConfig instance = GiftPackageConfig.Instance;
				GiftPackage? giftPackage = (instance != null) ? instance.GetGiftPackageConfig(giftId.Value) : null;
				if (giftPackage != null && giftPackage.GetValueOrDefault().Type == GiftType.Fixed)
				{
					this.OpenGiftDetailsView(good);
					return;
				}
			}
			this.OpenExchangePopView(id, extraData);
			return;
		}
		this.OpenExchangePopView(id, extraData);
	}

	// Token: 0x06012062 RID: 73826 RVA: 0x0046B9AE File Offset: 0x00469BAE
	[NullableContext(2)]
	public void OpenPayShopView(PayShopViewData data = null, TOpenViewCallBack finishCallback = null)
	{
		if (!FunctionModel.Instance.IsOpen(10010))
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PayShopRootView, data, finishCallback);
	}

	// Token: 0x06012063 RID: 73827 RVA: 0x0046B9E8 File Offset: 0x00469BE8
	public void OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType tab, int switchId)
	{
		if (!FunctionModel.Instance.IsOpen(10010))
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.PayShopRootView))
		{
			this.OpenPayShopView(new PayShopViewData
			{
				PayShopId = tab,
				SwitchId = new int?(switchId)
			}, null);
			return;
		}
		EventSystem.Instance.Emit<PayShopDefine.EPayShopTabType, int>(EEventName.SwitchPayShopTabItem, tab, switchId);
	}

	// Token: 0x06012064 RID: 73828 RVA: 0x0046BA60 File Offset: 0x00469C60
	public void OpenPayShopViewWithTabResolver(Func<PayShopJumpParam> tabResolver)
	{
		if (!FunctionModel.Instance.IsOpen(10010))
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.PayShopRootView))
		{
			this.OpenPayShopView(new PayShopViewData
			{
				JumpTabResolver = tabResolver
			}, null);
			return;
		}
		PayShopJumpParam payShopJumpParam = tabResolver();
		EventSystem.Instance.Emit<PayShopDefine.EPayShopTabType, int>(EEventName.SwitchPayShopTabItem, payShopJumpParam.PayShopId, payShopJumpParam.SwitchId);
	}

	// Token: 0x06012065 RID: 73829 RVA: 0x0046BAE0 File Offset: 0x00469CE0
	public void OpenPayShopViewToRecharge()
	{
		if (PayItemController.Instance.CurrentBlockBetaState && FeatureRestrictionTemplate.TemplateForPioneerClient.Check())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BetaDisableCharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (!UiManager.Instance.IsViewShow(EUiViewName.PayShopRootView))
		{
			this.OpenPayShopView(new PayShopViewData
			{
				PayShopId = PayShopDefine.EPayShopTabType.Recharge
			}, null);
			return;
		}
		EventSystem.Instance.Emit<PayShopDefine.EPayShopTabType, int>(EEventName.SwitchPayShopTabItem, PayShopDefine.EPayShopTabType.Recharge, 1);
	}

	// Token: 0x06012066 RID: 73830 RVA: 0x0046BB58 File Offset: 0x00469D58
	public void ClosePayShopGoodDetailPopView()
	{
		foreach (EUiViewName euiViewName in new List<EUiViewName>
		{
			EUiViewName.ExchangePopView,
			EUiViewName.GiftPackageDetailsView
		})
		{
			if (UiManager.Instance.IsViewOpen(euiViewName))
			{
				UiManager.Instance.CloseView(euiViewName, null);
			}
		}
	}

	// Token: 0x1700178F RID: 6031
	// (get) Token: 0x06012067 RID: 73831 RVA: 0x0046BBD4 File Offset: 0x00469DD4
	public static PayShopController Instance
	{
		get
		{
			return PayShopController._Instance;
		}
	}

	// Token: 0x06012068 RID: 73832 RVA: 0x0046BBDB File Offset: 0x00469DDB
	public static PayShopController GetOrCreateInstance()
	{
		if (PayShopController._Instance == null)
		{
			PayShopController.CreateInstance();
		}
		return PayShopController._Instance;
	}

	// Token: 0x06012069 RID: 73833 RVA: 0x0046BBEF File Offset: 0x00469DEF
	public static bool CreateInstance()
	{
		if (PayShopController._Instance != null)
		{
			return true;
		}
		PayShopController._Instance = new PayShopController();
		return true;
	}

	// Token: 0x0601206A RID: 73834 RVA: 0x0046BC05 File Offset: 0x00469E05
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601206B RID: 73835 RVA: 0x0046BC07 File Offset: 0x00469E07
	public static void ResetStaticDefaultValue()
	{
		PayShopController._Instance = null;
	}

	// Token: 0x0601206C RID: 73836 RVA: 0x0046BC0F File Offset: 0x00469E0F
	static PayShopController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayShopController.CreateStaticDefaultValue), new Action(PayShopController.ResetStaticDefaultValue));
	}

	// Token: 0x04008808 RID: 34824
	[Nullable(2)]
	private static PayShopController _Instance;

	// Token: 0x020088D8 RID: 35032
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402C790 RID: 182160
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__NotifyPayShopInfo;

		// Token: 0x0402C791 RID: 182161
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <1>__NotifyPayShopUnlock;

		// Token: 0x0402C792 RID: 182162
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <2>__NotifyPayShopDirectBuy;

		// Token: 0x0402C793 RID: 182163
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <3>__NotifyPayShopConditionFinish;
	}
}
