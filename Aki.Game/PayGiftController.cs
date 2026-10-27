using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002352 RID: 9042
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PayGiftController : UiControllerBase
{
	// Token: 0x06012010 RID: 73744 RVA: 0x0046A311 File Offset: 0x00468511
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PayGiftSuccessNotify, new Action<IMessage, Net.CallbackStatus>(this.PayGiftSuccessNotify));
	}

	// Token: 0x06012011 RID: 73745 RVA: 0x0046A32F File Offset: 0x0046852F
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PayGiftSuccessNotify);
	}

	// Token: 0x06012012 RID: 73746 RVA: 0x0046A341 File Offset: 0x00468541
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x06012013 RID: 73747 RVA: 0x0046A35C File Offset: 0x0046855C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x06012014 RID: 73748 RVA: 0x0046A377 File Offset: 0x00468577
	private void OnSdkPayEnd(ESdkDialogResult result)
	{
		if (result == ESdkDialogResult.No)
		{
			PayShopModel.Instance.ConsoleExtraPerformancePayGiftId = 0;
		}
	}

	// Token: 0x06012015 RID: 73749 RVA: 0x0046A387 File Offset: 0x00468587
	public void OnShopInfoNotify(PayShopInfoNotify message)
	{
		PayGiftModel.Instance.Version = message.PayGiftShopInfo.Version;
		PayGiftModel.Instance.InitDataByServer(message.PayGiftShopInfo.Gifts.ToList<PayGiftInfo>(), false);
	}

	// Token: 0x06012016 RID: 73750 RVA: 0x0046A3B9 File Offset: 0x004685B9
	[NullableContext(2)]
	public void OnShopInfoReceive(PayGiftShopInfo message)
	{
		if (message != null)
		{
			PayGiftModel.Instance.Version = message.Version;
			PayGiftModel.Instance.InitDataByServer(message.Gifts.ToList<PayGiftInfo>(), false);
		}
	}

	// Token: 0x06012017 RID: 73751 RVA: 0x0046A3E4 File Offset: 0x004685E4
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

	// Token: 0x06012018 RID: 73752 RVA: 0x0046A47C File Offset: 0x0046867C
	public UniTask QueryPayGiftInfoAsync()
	{
		PayGiftController.<QueryPayGiftInfoAsync>d__8 <QueryPayGiftInfoAsync>d__;
		<QueryPayGiftInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryPayGiftInfoAsync>d__.<>1__state = -1;
		<QueryPayGiftInfoAsync>d__.<>t__builder.Start<PayGiftController.<QueryPayGiftInfoAsync>d__8>(ref <QueryPayGiftInfoAsync>d__);
		return <QueryPayGiftInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012019 RID: 73753 RVA: 0x0046A4B8 File Offset: 0x004686B8
	[NullableContext(0)]
	public UniTask<bool> SendPayGiftInfoRequestAsync()
	{
		PayGiftController.<SendPayGiftInfoRequestAsync>d__9 <SendPayGiftInfoRequestAsync>d__;
		<SendPayGiftInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendPayGiftInfoRequestAsync>d__.<>1__state = -1;
		<SendPayGiftInfoRequestAsync>d__.<>t__builder.Start<PayGiftController.<SendPayGiftInfoRequestAsync>d__9>(ref <SendPayGiftInfoRequestAsync>d__);
		return <SendPayGiftInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601201A RID: 73754 RVA: 0x0046A4F4 File Offset: 0x004686F4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(payGiftInfoResponse.ErrorCode, 25815, null, true, true);
				}
				if (payGiftInfoResponse.Version == "" || payGiftInfoResponse.Infos == null)
				{
					return;
				}
				PayGiftModel.Instance.Version = payGiftInfoResponse.Version;
				PayGiftModel.Instance.InitDataByServer(payGiftInfoResponse.Infos.ToList<PayGiftInfo>(), needRefreshEvent);
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

	// Token: 0x0601201B RID: 73755 RVA: 0x0046A544 File Offset: 0x00468744
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(payGiftResponse.ErrorCode, 20285, null, true, true);
		}, 0);
	}

	// Token: 0x0601201C RID: 73756 RVA: 0x0046A5A4 File Offset: 0x004687A4
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

	// Token: 0x1700178C RID: 6028
	// (get) Token: 0x0601201D RID: 73757 RVA: 0x0046A775 File Offset: 0x00468975
	public static PayGiftController Instance
	{
		get
		{
			return PayGiftController._Instance;
		}
	}

	// Token: 0x0601201E RID: 73758 RVA: 0x0046A77C File Offset: 0x0046897C
	public static PayGiftController GetOrCreateInstance()
	{
		if (PayGiftController._Instance == null)
		{
			PayGiftController.CreateInstance();
		}
		return PayGiftController._Instance;
	}

	// Token: 0x0601201F RID: 73759 RVA: 0x0046A790 File Offset: 0x00468990
	public static bool CreateInstance()
	{
		if (PayGiftController._Instance != null)
		{
			return true;
		}
		PayGiftController._Instance = new PayGiftController();
		return true;
	}

	// Token: 0x06012020 RID: 73760 RVA: 0x0046A7A6 File Offset: 0x004689A6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012021 RID: 73761 RVA: 0x0046A7A8 File Offset: 0x004689A8
	public static void ResetStaticDefaultValue()
	{
		PayGiftController._Instance = null;
	}

	// Token: 0x06012022 RID: 73762 RVA: 0x0046A7B0 File Offset: 0x004689B0
	static PayGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayGiftController.CreateStaticDefaultValue), new Action(PayGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x040087F8 RID: 34808
	[Nullable(2)]
	private static PayGiftController _Instance;
}
