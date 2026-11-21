using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001837 RID: 6199
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PayGiftController : UiControllerBase
{
	// Token: 0x0600F4C0 RID: 62656 RVA: 0x004773D9 File Offset: 0x004755D9
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PayGiftSuccessNotify, new Action<IMessage, Net.CallbackStatus>(this.PayGiftSuccessNotify));
	}

	// Token: 0x0600F4C1 RID: 62657 RVA: 0x004773F7 File Offset: 0x004755F7
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PayGiftSuccessNotify);
	}

	// Token: 0x0600F4C2 RID: 62658 RVA: 0x00477409 File Offset: 0x00475609
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x0600F4C3 RID: 62659 RVA: 0x00477424 File Offset: 0x00475624
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x0600F4C4 RID: 62660 RVA: 0x0047743F File Offset: 0x0047563F
	private void OnSdkPayEnd(ESdkDialogResult result)
	{
		if (result == ESdkDialogResult.No)
		{
			PayShopModel.Instance.ConsoleExtraPerformancePayGiftId = 0;
		}
	}

	// Token: 0x0600F4C5 RID: 62661 RVA: 0x0047744F File Offset: 0x0047564F
	public void OnShopInfoNotify(PayShopInfoNotify message)
	{
		PayGiftModel.Instance.Version = message.PayGiftShopInfo.Version;
		PayGiftModel.Instance.InitDataByServer(message.PayGiftShopInfo.Gifts, false);
	}

	// Token: 0x0600F4C6 RID: 62662 RVA: 0x0047747C File Offset: 0x0047567C
	[NullableContext(2)]
	public void OnShopInfoReceive(PayGiftShopInfo message)
	{
		if (message != null)
		{
			PayGiftModel.Instance.Version = message.Version;
			PayGiftModel.Instance.InitDataByServer(message.Gifts, false);
		}
	}

	// Token: 0x0600F4C7 RID: 62663 RVA: 0x004774A4 File Offset: 0x004756A4
	[NullableContext(2)]
	private void PayGiftSuccessNotify(IMessage msg, Net.CallbackStatus status)
	{
		PayGiftSuccessNotify payGiftSuccessNotify = (PayGiftSuccessNotify)msg;
		KuroSdkController.Instance.CancelCurrentWaitPayItemTimer(true);
		PayItemSuccess p = new PayItemSuccess
		{
			PayItemId = payGiftSuccessNotify.Id,
			OrderId = payGiftSuccessNotify.ReceiptId,
			ItemId = payGiftSuccessNotify.ItemId,
			ItemCount = payGiftSuccessNotify.ItemCount
		};
		PayGiftModel.Instance.GetPayGiftDataById(payGiftSuccessNotify.PayGiftInfo.Id).Phrase(payGiftSuccessNotify.PayGiftInfo);
		KuroSdkReport.Instance.OnPayShopDirectBuy(payGiftSuccessNotify.Id);
		EventSystem.Instance.Emit<PayItemSuccess>(EEventName.OnPayItemSuccess, p);
	}

	// Token: 0x0600F4C8 RID: 62664 RVA: 0x0047753C File Offset: 0x0047573C
	public UniTask QueryPayGiftInfoAsync()
	{
		PayGiftController.<QueryPayGiftInfoAsync>d__8 <QueryPayGiftInfoAsync>d__;
		<QueryPayGiftInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryPayGiftInfoAsync>d__.<>1__state = -1;
		<QueryPayGiftInfoAsync>d__.<>t__builder.Start<PayGiftController.<QueryPayGiftInfoAsync>d__8>(ref <QueryPayGiftInfoAsync>d__);
		return <QueryPayGiftInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4C9 RID: 62665 RVA: 0x00477578 File Offset: 0x00475778
	[NullableContext(0)]
	public UniTask<bool> SendPayGiftInfoRequestAsync()
	{
		PayGiftController.<SendPayGiftInfoRequestAsync>d__9 <SendPayGiftInfoRequestAsync>d__;
		<SendPayGiftInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendPayGiftInfoRequestAsync>d__.<>1__state = -1;
		<SendPayGiftInfoRequestAsync>d__.<>t__builder.Start<PayGiftController.<SendPayGiftInfoRequestAsync>d__9>(ref <SendPayGiftInfoRequestAsync>d__);
		return <SendPayGiftInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4CA RID: 62666 RVA: 0x004775B4 File Offset: 0x004757B4
	public void SendPayGiftInfoRequest(bool needRefreshEvent = false)
	{
		PayGiftInfoRequest payGiftInfoRequest = PayGiftInfoRequest.Create();
		payGiftInfoRequest.Version = PayGiftModel.Instance.Version;
		Net.Instance.Call(ERequestMessageId.PayGiftInfoRequest, payGiftInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PayGiftInfoResponse payGiftInfoResponse = (PayGiftInfoResponse)msg;
			if (payGiftInfoResponse != null)
			{
				if (payGiftInfoResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(payGiftInfoResponse.ErrorCode, 21829, null, true, true);
				}
				if (payGiftInfoResponse.Version == "" || payGiftInfoResponse.Infos == null)
				{
					return;
				}
				PayGiftModel.Instance.Version = payGiftInfoResponse.Version;
				PayGiftModel.Instance.InitDataByServer(payGiftInfoResponse.Infos, needRefreshEvent);
				List<PayPackageData> dataList = PayGiftModel.Instance.GetDataList();
				List<string> list = new List<string>();
				foreach (PayPackageData payPackageData in dataList)
				{
					list.Add(payPackageData.ProductId);
				}
				PayItemController.Instance.QueryProductInfoAsync(list);
			}
		}, 0);
	}

	// Token: 0x0600F4CB RID: 62667 RVA: 0x00477604 File Offset: 0x00475804
	private void SendPayGiftRequest(int payGiftId)
	{
		PayGiftRequest payGiftRequest = PayGiftRequest.Create();
		payGiftRequest.Id = payGiftId;
		payGiftRequest.Version = PayGiftModel.Instance.Version;
		Net.Instance.Call(ERequestMessageId.PayGiftRequest, payGiftRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PayGiftResponse payGiftResponse = (PayGiftResponse)msg;
			PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(payGiftId);
			if (payGiftResponse.ErrorCode == ErrorCode.Success)
			{
				string itemName = ItemConfig.Instance.GetItemName(payShopGoodsById.GetGoodsData().ItemId);
				string itemDesc = ItemConfig.Instance.GetItemDesc(payShopGoodsById.GetGoodsData().ItemId);
				SdkPayGetServerBillEvent sdkPayGetServerBillEvent = new SdkPayGetServerBillEvent();
				sdkPayGetServerBillEvent.s_sdk_pay_order = payGiftResponse.ReceiptId;
				LogReportController.Instance.LogReport(sdkPayGetServerBillEvent);
				KuroSdkController.Instance.SdkPay(payShopGoodsById.GetGetPayGiftData().PayId, payGiftResponse.ReceiptId, itemName, itemDesc, payGiftResponse.CallbackUrl);
				return;
			}
			if (payGiftResponse.ErrorCode == ErrorCode.ErrPayShopDataChanged)
			{
				this.SendPayGiftInfoRequest(false);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(payGiftResponse.ErrorCode, 29388, null, true, true);
		}, 0);
	}

	// Token: 0x0600F4CC RID: 62668 RVA: 0x00477664 File Offset: 0x00475864
	public void SdkPay(int payGiftId)
	{
		if (PayItemController.Instance.CurrentBlockBetaState && CommonConfig.Instance.GetBetaBlockRecharge().GetValueOrDefault())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BetaDisableCharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (FeatureRestrictionTemplate.TemplateForPioneerClient.Check() && payGiftId == 42)
		{
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.BetaDisableCharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
			return;
		}
		if (PayItemController.Instance.CurrentBlockIosPayState && Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			ConfirmBoxDataNew confirmBoxDataNew3 = new ConfirmBoxDataNew(EConfirmBoxConfigId.IosCloseRecharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew3);
		}
		PayPackageData payGiftDataById = PayGiftModel.Instance.GetPayGiftDataById(payGiftId);
		if (payGiftDataById != null && payGiftDataById.NeedConsoleRulePrompt && Info.Instance.IsHomeConsolePlatform())
		{
			PayShopModel.Instance.ConsoleExtraPerformancePayGiftId = payGiftId;
		}
		else
		{
			PayShopModel.Instance.ConsoleExtraPerformancePayGiftId = 0;
		}
		if (!PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			this.SendPayGiftRequest(payGiftId);
			return;
		}
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(payGiftId);
		string text;
		if (payShopGoodsById == null)
		{
			text = null;
		}
		else
		{
			PayPackageData getPayGiftData = payShopGoodsById.GetGetPayGiftData();
			text = ((getPayGiftData != null) ? getPayGiftData.ProductId : null);
		}
		string text2 = text;
		if (text2 == null)
		{
			Log.Instance.Error(ELogModule.Pay, ELogAuthor.TL, "PayGiftController SdkPay failed, productId is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (((platformSdk != null) ? new bool?(platformSdk.NeedShowSdkProductInfoBeforePay()) : null).GetValueOrDefault())
		{
			DisplayProductInfo productInfoByGoodsId = PayItemModel.Instance.GetProductInfoByGoodsId(text2);
			Action<string> onClickConfirmBtn = delegate(string id)
			{
				PayItemController.Instance.SdkPayNew(id);
			};
			SdkPayProductInformationViewData param = SdkPayProductInformationViewData.Create(productInfoByGoodsId.Name, productInfoByGoodsId.Desc, text2, onClickConfirmBtn);
			UiManager.Instance.OpenView(EUiViewName.SdkPayProductInformationView, param, null);
			return;
		}
		PayItemController.Instance.SdkPayNew(text2);
	}

	// Token: 0x170017C6 RID: 6086
	// (get) Token: 0x0600F4CD RID: 62669 RVA: 0x00477835 File Offset: 0x00475A35
	public static PayGiftController Instance
	{
		get
		{
			return PayGiftController._Instance;
		}
	}

	// Token: 0x0600F4CE RID: 62670 RVA: 0x0047783C File Offset: 0x00475A3C
	public static PayGiftController GetOrCreateInstance()
	{
		if (PayGiftController._Instance == null)
		{
			PayGiftController.CreateInstance();
		}
		return PayGiftController._Instance;
	}

	// Token: 0x0600F4CF RID: 62671 RVA: 0x00477850 File Offset: 0x00475A50
	public static bool CreateInstance()
	{
		if (PayGiftController._Instance != null)
		{
			return true;
		}
		PayGiftController._Instance = new PayGiftController();
		return true;
	}

	// Token: 0x0600F4D0 RID: 62672 RVA: 0x00477866 File Offset: 0x00475A66
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F4D1 RID: 62673 RVA: 0x00477868 File Offset: 0x00475A68
	public static void ResetStaticDefaultValue()
	{
		PayGiftController._Instance = null;
	}

	// Token: 0x0600F4D2 RID: 62674 RVA: 0x00477870 File Offset: 0x00475A70
	static PayGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayGiftController.CreateStaticDefaultValue), new Action(PayGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x0400893B RID: 35131
	[Nullable(2)]
	private static PayGiftController _Instance;
}
