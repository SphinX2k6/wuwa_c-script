using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020017FE RID: 6142
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PayItemController : UiControllerBase
{
	// Token: 0x0600F0BB RID: 61627 RVA: 0x0046B9FA File Offset: 0x00469BFA
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PayItemSuccessNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PayItemSuccessNotify payItemSuccessNotify = (PayItemSuccessNotify)msg;
			if (payItemSuccessNotify != null)
			{
				PayItemSuccess p = new PayItemSuccess
				{
					PayItemId = payItemSuccessNotify.Id,
					OrderId = payItemSuccessNotify.ReceiptId,
					ItemId = payItemSuccessNotify.ItemId,
					ItemCount = payItemSuccessNotify.ItemCount
				};
				EventSystem.Instance.Emit<PayItemSuccess>(EEventName.OnPayItemSuccess, p);
			}
			this.CutWaitPayResponseTimer();
			PayItemModel.Instance.CleanPayingItemName();
		});
		Net.Instance.Register(ENotifyMessageId.ResetSpecialBonusNotify, new Action<IMessage, Net.CallbackStatus>(this.ResetSpecialBonusNotify));
	}

	// Token: 0x0600F0BC RID: 61628 RVA: 0x0046BA34 File Offset: 0x00469C34
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ResetSpecialBonusNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PayItemSuccessNotify);
	}

	// Token: 0x0600F0BD RID: 61629 RVA: 0x0046BA58 File Offset: 0x00469C58
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.OnLoginSuccess));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x0600F0BE RID: 61630 RVA: 0x0046BABC File Offset: 0x00469CBC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, new Action(this.OnLoginSuccess));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x0600F0BF RID: 61631 RVA: 0x0046BB1D File Offset: 0x00469D1D
	private void OnLoginSuccess()
	{
		this.RequestSdkCheckout(ECheckoutReason.Login);
	}

	// Token: 0x0600F0C0 RID: 61632 RVA: 0x0046BB26 File Offset: 0x00469D26
	protected override bool OnClear()
	{
		this.CutWaitPayResponseTimer();
		return true;
	}

	// Token: 0x0600F0C1 RID: 61633 RVA: 0x0046BB30 File Offset: 0x00469D30
	[NullableContext(2)]
	private void ResetSpecialBonusNotify(IMessage msg, Net.CallbackStatus status)
	{
		ResetSpecialBonusNotify resetSpecialBonusNotify = (ResetSpecialBonusNotify)msg;
		PayItemModel.Instance.ResetSpecialBonus(resetSpecialBonusNotify.Ids);
	}

	// Token: 0x0600F0C2 RID: 61634 RVA: 0x0046BB54 File Offset: 0x00469D54
	private void SendBuyPayItemRequest(int payItemId)
	{
		PayItemRequest payItemRequest = PayItemRequest.Create();
		payItemRequest.Id = payItemId;
		payItemRequest.Version = PayItemModel.Instance.Version;
		PayItemModel.Instance.UpdatePayingItemName(payItemId);
		Net.Instance.Call(ERequestMessageId.PayItemRequest, payItemRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			PayItemResponse payItemResponse = (PayItemResponse)msg;
			if (payItemResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(payItemResponse.ErrorCode, 22536, null, true, true);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "PayShop:ShopItem 充值请求成功,调用SDK接口";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", payItemId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			ISDKPayment paymentInfo = PayItemModel.Instance.CreateSdkPayment(payItemId, payItemResponse.ReceiptId, payItemResponse.CallbackUrl);
			SdkPayGetServerBillEvent sdkPayGetServerBillEvent = new SdkPayGetServerBillEvent();
			sdkPayGetServerBillEvent.s_sdk_pay_order = payItemResponse.ReceiptId;
			LogReportController.Instance.LogReport(sdkPayGetServerBillEvent);
			KuroSdkController.Instance.SdkPay(paymentInfo);
		}, 0);
	}

	// Token: 0x0600F0C3 RID: 61635 RVA: 0x0046BBBD File Offset: 0x00469DBD
	private void CutWaitPayResponseTimer()
	{
		KuroSdkController.Instance.CancelCurrentWaitPayItemTimer(true);
	}

	// Token: 0x0600F0C4 RID: 61636 RVA: 0x0046BBCC File Offset: 0x00469DCC
	[NullableContext(0)]
	public UniTask<bool> QueryPayItemInfoAsync()
	{
		PayItemController.<QueryPayItemInfoAsync>d__11 <QueryPayItemInfoAsync>d__;
		<QueryPayItemInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<QueryPayItemInfoAsync>d__.<>4__this = this;
		<QueryPayItemInfoAsync>d__.<>1__state = -1;
		<QueryPayItemInfoAsync>d__.<>t__builder.Start<PayItemController.<QueryPayItemInfoAsync>d__11>(ref <QueryPayItemInfoAsync>d__);
		return <QueryPayItemInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F0C5 RID: 61637 RVA: 0x0046BC10 File Offset: 0x00469E10
	[NullableContext(0)]
	public UniTask<bool> SendPayItemInfoRequestAsync()
	{
		PayItemController.<SendPayItemInfoRequestAsync>d__12 <SendPayItemInfoRequestAsync>d__;
		<SendPayItemInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendPayItemInfoRequestAsync>d__.<>1__state = -1;
		<SendPayItemInfoRequestAsync>d__.<>t__builder.Start<PayItemController.<SendPayItemInfoRequestAsync>d__12>(ref <SendPayItemInfoRequestAsync>d__);
		return <SendPayItemInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F0C6 RID: 61638 RVA: 0x0046BC4C File Offset: 0x00469E4C
	[NullableContext(0)]
	public UniTask<bool> QueryProductInfoAsync([Nullable(1)] List<string> productIds)
	{
		PayItemController.<QueryProductInfoAsync>d__13 <QueryProductInfoAsync>d__;
		<QueryProductInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<QueryProductInfoAsync>d__.productIds = productIds;
		<QueryProductInfoAsync>d__.<>1__state = -1;
		<QueryProductInfoAsync>d__.<>t__builder.Start<PayItemController.<QueryProductInfoAsync>d__13>(ref <QueryProductInfoAsync>d__);
		return <QueryProductInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F0C7 RID: 61639 RVA: 0x0046BC90 File Offset: 0x00469E90
	public unsafe void SdkPayNew(string productId)
	{
		if (this.CheckoutDialogTimerHandle != null)
		{
			Log.Instance.Warn(ELogModule.Pay, ELogAuthor.TL, "SdkPayNew failed, duplicate pay request", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		string productLabelByGoodsId = PayItemModel.Instance.GetProductLabelByGoodsId(productId);
		if (productLabelByGoodsId == null)
		{
			Log.Instance.Error(ELogModule.Pay, ELogAuthor.TL, "SdkPayNew failed, psnProductLabel is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		string productChannelGoodsIdByGoodsId = PayItemModel.Instance.GetProductChannelGoodsIdByGoodsId(productId);
		bool flag = PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenCheckoutDialog(productLabelByGoodsId, productId, productChannelGoodsIdByGoodsId ?? "");
		if (!flag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Pay;
			ELogAuthor author = ELogAuthor.TL;
			string message = "SdkPayNew failed, OpenCheckoutDialog failed";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("psnProductId", productLabelByGoodsId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("result", flag);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.CheckoutDialogTimerHandle = TimerSystem.Instance.Forever(delegate(float _)
		{
			ESdkDialogResult esdkDialogResult = PlatformSdkManagerNew.Instance.GetPlatformSdk().PollCheckoutDialogResult();
			if (esdkDialogResult != ESdkDialogResult.Waiting)
			{
				if (esdkDialogResult == ESdkDialogResult.Yes)
				{
					this.RequestSdkCheckout(ECheckoutReason.AfterPay);
					if (this.CheckoutDialogTimerHandle != null)
					{
						TimerSystem.Instance.Remove(this.CheckoutDialogTimerHandle);
					}
					this.CheckoutDialogTimerHandle = null;
					EventSystem.Instance.Emit<ESdkDialogResult>(EEventName.SdkPayEnd, ESdkDialogResult.Yes);
					return;
				}
				if (this.CheckoutDialogTimerHandle != null)
				{
					TimerSystem.Instance.Remove(this.CheckoutDialogTimerHandle);
				}
				this.CheckoutDialogTimerHandle = null;
				EventSystem.Instance.Emit<ESdkDialogResult>(EEventName.SdkPayEnd, ESdkDialogResult.No);
			}
		}, 500f, 1f, null, null, true);
	}

	// Token: 0x0600F0C8 RID: 61640 RVA: 0x0046BDA8 File Offset: 0x00469FA8
	public void SdkPay(int payItemId)
	{
		if (this.CurrentBlockBetaState && FeatureRestrictionTemplate.TemplateForPioneerClient.Check())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BetaDisableCharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (this.CurrentBlockIosPayState && Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.IosCloseRecharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
			return;
		}
		if (!PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			this.SendBuyPayItemRequest(payItemId);
			return;
		}
		string productIdByPayItemId = PayItemConfig.Instance.GetProductIdByPayItemId(payItemId);
		if (productIdByPayItemId == null)
		{
			Log.Instance.Error(ELogModule.Pay, ELogAuthor.TL, "SdkPay failed, productId is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (((platformSdk != null) ? new bool?(platformSdk.NeedShowSdkProductInfoBeforePay()) : null).GetValueOrDefault())
		{
			DisplayProductInfo productInfoByGoodsId = PayItemModel.Instance.GetProductInfoByGoodsId(productIdByPayItemId);
			Action<string> onClickConfirmBtn = delegate(string id)
			{
				PayItemController.Instance.SdkPayNew(id);
			};
			SdkPayProductInformationViewData param = SdkPayProductInformationViewData.Create(productInfoByGoodsId.Name, productInfoByGoodsId.Desc, productIdByPayItemId, onClickConfirmBtn);
			UiManager.Instance.OpenView(EUiViewName.SdkPayProductInformationView, param, null);
			throw new NotImplementedException("SdkPay");
		}
		this.SdkPayNew(productIdByPayItemId);
	}

	// Token: 0x0600F0C9 RID: 61641 RVA: 0x0046BEF0 File Offset: 0x0046A0F0
	private string GetRoleId()
	{
		if (PlayerInfoModel.Instance.GetId() != null)
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int num = 0;
			if (!(id.GetValueOrDefault() == num & id != null))
			{
				return PlayerInfoModel.Instance.GetId().ToString();
			}
		}
		if (LoginModel.Instance.GetCreatePlayerId() != 0)
		{
			return LoginModel.Instance.GetCreatePlayerId().ToString();
		}
		return "";
	}

	// Token: 0x0600F0CA RID: 61642 RVA: 0x0046BF70 File Offset: 0x0046A170
	public void RequestSdkCheckout(ECheckoutReason reason)
	{
		if (!PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return;
		}
		if (LoginModel.Instance.SdkAccessToken == "")
		{
			return;
		}
		string roleId = this.GetRoleId();
		if (roleId == "")
		{
			return;
		}
		ISdkRequestCheckoutProductParam sdkRequestCheckoutProductParam = new ISdkRequestCheckoutProductParam
		{
			AccessToken = LoginModel.Instance.SdkAccessToken,
			ServerId = LoginModel.Instance.GetServerId(),
			ServerName = LoginModel.Instance.GetServerName(),
			RoleId = roleId,
			RoleName = FunctionModel.Instance.GetPlayerName()
		};
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Pay;
		ELogAuthor author = ELogAuthor.TL;
		string message = "RequestSdkCheckout SDK销单";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("param", sdkRequestCheckoutProductParam);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		PlatformSdkManagerNew.Instance.GetPlatformSdk().RequestCheckoutProduct(sdkRequestCheckoutProductParam, delegate(string msg, bool needReLogin, bool suc)
		{
			if (!suc)
			{
				if (needReLogin)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ServerMaintenance);
					confirmBoxDataNew.SetTextArgs(new string[]
					{
						msg
					});
					confirmBoxDataNew.SetCloseFunction(delegate
					{
						ReConnectController.Instance.Logout(ELogoutReason.SdkRenewAccessTokenFailed);
					});
					ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Pay;
				ELogAuthor author2 = ELogAuthor.TL;
				string message2 = "RequestSdkCheckout SDK销单";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("msg", msg);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}, reason);
	}

	// Token: 0x0600F0CB RID: 61643 RVA: 0x0046C05D File Offset: 0x0046A25D
	private void OnWorldDone()
	{
		if (FunctionModel.Instance.IsOpen(10010))
		{
			this.SendPayItemInfoRequestAsync();
		}
	}

	// Token: 0x0600F0CC RID: 61644 RVA: 0x0046C077 File Offset: 0x0046A277
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
		this.SendPayItemInfoRequestAsync();
	}

	// Token: 0x170016EC RID: 5868
	// (get) Token: 0x0600F0CD RID: 61645 RVA: 0x0046C08D File Offset: 0x0046A28D
	public static PayItemController Instance
	{
		get
		{
			return PayItemController._Instance;
		}
	}

	// Token: 0x0600F0CE RID: 61646 RVA: 0x0046C094 File Offset: 0x0046A294
	public static PayItemController GetOrCreateInstance()
	{
		if (PayItemController._Instance == null)
		{
			PayItemController.CreateInstance();
		}
		return PayItemController._Instance;
	}

	// Token: 0x0600F0CF RID: 61647 RVA: 0x0046C0A8 File Offset: 0x0046A2A8
	public static bool CreateInstance()
	{
		if (PayItemController._Instance != null)
		{
			return true;
		}
		PayItemController._Instance = new PayItemController();
		return true;
	}

	// Token: 0x0600F0D0 RID: 61648 RVA: 0x0046C0BE File Offset: 0x0046A2BE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F0D1 RID: 61649 RVA: 0x0046C0C0 File Offset: 0x0046A2C0
	public static void ResetStaticDefaultValue()
	{
		PayItemController._Instance = null;
	}

	// Token: 0x0600F0D2 RID: 61650 RVA: 0x0046C0C8 File Offset: 0x0046A2C8
	static PayItemController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayItemController.CreateStaticDefaultValue), new Action(PayItemController.ResetStaticDefaultValue));
	}

	// Token: 0x040087F8 RID: 34808
	public bool CurrentBlockIosPayState;

	// Token: 0x040087F9 RID: 34809
	public bool CurrentBlockBetaState = true;

	// Token: 0x040087FA RID: 34810
	[Nullable(2)]
	private TimerHandle CheckoutDialogTimerHandle;

	// Token: 0x040087FB RID: 34811
	[Nullable(2)]
	private static PayItemController _Instance;
}
