using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Launcher.Platform;

// Token: 0x020002F6 RID: 758
[NullableContext(1)]
[Nullable(0)]
public class PlatformCloudSdkBase : PlatformSdkWindows
{
	// Token: 0x06002B57 RID: 11095 RVA: 0x00104A80 File Offset: 0x00102C80
	public override void BindProtocolListener()
	{
	}

	// Token: 0x06002B58 RID: 11096 RVA: 0x00104A82 File Offset: 0x00102C82
	public override void BindShareResultListener()
	{
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnShareResult, new TCloudGameOnReceiveDataFunction(this.OnCloudShareResult));
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnSDKPayResult, new TCloudGameOnReceiveDataFunction(this.OnSdkPayResult));
	}

	// Token: 0x06002B59 RID: 11097 RVA: 0x00104AB2 File Offset: 0x00102CB2
	public override void KuroSdkBindRedPointFunction(Action<int> callBack)
	{
	}

	// Token: 0x06002B5A RID: 11098 RVA: 0x00104AB4 File Offset: 0x00102CB4
	public override void KuroSdkExitBindFunction()
	{
	}

	// Token: 0x06002B5B RID: 11099 RVA: 0x00104AB6 File Offset: 0x00102CB6
	public override void KuroSdkQueryProductBindFunction()
	{
	}

	// Token: 0x06002B5C RID: 11100 RVA: 0x00104AB8 File Offset: 0x00102CB8
	public override void KuroDeepLinkBindFunction()
	{
	}

	// Token: 0x06002B5D RID: 11101 RVA: 0x00104ABA File Offset: 0x00102CBA
	public override void KuroGameWinStateBindFunction()
	{
	}

	// Token: 0x06002B5E RID: 11102 RVA: 0x00104ABC File Offset: 0x00102CBC
	public override void SdkLogout()
	{
	}

	// Token: 0x06002B5F RID: 11103 RVA: 0x00104AC0 File Offset: 0x00102CC0
	public override void SdkLogin()
	{
		if (CloudGameManagerLauncher.Instance.IsPreLaunch)
		{
			Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.TL, "请求下发缓存的SDK登录信息 预启动跳过重复流程", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CloudGameManager.Instance.SendData(ECloudGameSendData.RequestLogin);
		Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "请求下发缓存的SDK登录信息", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06002B60 RID: 11104 RVA: 0x00104B24 File Offset: 0x00102D24
	public override void SdkCreateRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.TL, "云游戏上报创建新角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string createRoleInfo = KuroSdkControllerTool.GetCreateRoleInfo();
			CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKCreateRole, createRoleInfo);
		}
	}

	// Token: 0x06002B61 RID: 11105 RVA: 0x00104B6C File Offset: 0x00102D6C
	public override void SdkSelectRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.TL, "云游戏上报选择新角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = KuroSdkControllerTool.GetRoleInfo();
			CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKSelectRole, roleInfo);
		}
	}

	// Token: 0x06002B62 RID: 11106 RVA: 0x00104BB4 File Offset: 0x00102DB4
	public override void SdkLevelUpRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.TL, "云游戏上报角色升级", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = KuroSdkControllerTool.GetRoleInfo();
			CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKLevelUpRole, roleInfo);
		}
	}

	// Token: 0x06002B63 RID: 11107 RVA: 0x00104BFC File Offset: 0x00102DFC
	public override void SdkOpenLoginWnd()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.RequestLogin);
		Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "请求重新下发缓存的SDK登录信息", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06002B64 RID: 11108 RVA: 0x00104C33 File Offset: 0x00102E33
	public override void OpenUserCenter()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.OpenUserCenter);
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x00104C40 File Offset: 0x00102E40
	public override void ShowAgreement()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.OpenAgreement);
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x00104C4D File Offset: 0x00102E4D
	public override void KuroOpenPrivacyClauseWnd()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.OpenPrivacyClause);
	}

	// Token: 0x06002B67 RID: 11111 RVA: 0x00104C5C File Offset: 0x00102E5C
	public override void OpenPostWebView()
	{
		if (this.LastOpenPostViewTime != 0.0 && Time.Instance.Now - this.LastOpenPostViewTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenPostViewTime = Time.Instance.Now;
		Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "打开公告", default(ReadOnlySpan<ValueTuple<string, object>>));
		FunctionModel instance = FunctionModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		string type = KuroSdkController.Instance.GetIfGlobalSdk() ? "global" : "cn";
		OpenPostWebViewParam openPostWebViewParam = new OpenPostWebViewParam();
		openPostWebViewParam.playerId = ((instance2.GetId() == null) ? "0" : instance2.GetId().ToString());
		int? playerLevel = instance.GetPlayerLevel();
		openPostWebViewParam.playerLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1");
		openPostWebViewParam.language = LanguageSystem.Instance.PackageLanguage;
		openPostWebViewParam.extend = "extend";
		openPostWebViewParam.gameOrientation = "2";
		openPostWebViewParam.type = type;
		string text = Json.Stringify(openPostWebViewParam, null);
		Log instance3 = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "云游戏OpenPostWebView";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", text);
		instance3.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.OpenPostWebView, text);
	}

	// Token: 0x06002B68 RID: 11112 RVA: 0x00104DDC File Offset: 0x00102FDC
	public override void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkIos.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkIos.ISdkCustomerService>(result, null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "当前客服红点数量";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("num", result);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (sdkCustomerService != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CloudGame;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "当前客服红点数量";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("num", sdkCustomerService.isredot);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x00104E74 File Offset: 0x00103074
	public override void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenTime = Time.Instance.Now;
		string text = Json.Stringify(new OpenWebViewParamCloudGame
		{
			title = title,
			url = url,
			transparent = transparent,
			webAccelerated = webAccelerated,
			isLandscape = isLandscape,
			identifier = identifier
		}, KuroSdkJsonOptions.Unescaped);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "OpenWebView";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text ?? "");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.OpenWebView, text);
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x00104F4F File Offset: 0x0010314F
	public override void SdkOpenUrlWnd(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true)
	{
		this.OpenWebView(title, url, isLandscape, transparent, webAccelerated, string.Empty);
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x00104F63 File Offset: 0x00103163
	private void OnCloudShareResult(string resultJson)
	{
		if (Json.Decode<ShareResult>(resultJson, null).ErrorCode == 0)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x00104F98 File Offset: 0x00103198
	private void OnSdkPayResult(string resultJson)
	{
		CloudSDKPayResult cloudSDKPayResult = Json.Decode<CloudSDKPayResult>(resultJson, null);
		KuroSdkController.Instance.OnSdkPayEnd(cloudSDKPayResult.paymentType == 1, "");
		if (cloudSDKPayResult.paymentType == 1)
		{
			SuccessSdkPayEvent successSdkPayEvent = new SuccessSdkPayEvent();
			successSdkPayEvent.s_sdk_pay_order = KuroSdkModel.Instance.CurrentPayingOrderId;
			LogReportController.Instance.LogReport(successSdkPayEvent);
		}
		else
		{
			FailSdkPayEvent failSdkPayEvent = new FailSdkPayEvent();
			failSdkPayEvent.s_sdk_pay_order = KuroSdkModel.Instance.CurrentPayingOrderId;
			failSdkPayEvent.s_reason = ((cloudSDKPayResult.paymentType == 3) ? "cancel" : "fail");
			LogReportController.Instance.LogReport(failSdkPayEvent);
		}
		KuroSdkReport.Instance.OnSdkPay();
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x00105038 File Offset: 0x00103238
	public override void RecoverSdkData()
	{
		Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "PlatformCloudSdkBase.RecoverSdkData", default(ReadOnlySpan<ValueTuple<string, object>>));
		CloudGameManager.Instance.TryRequestGamePadDevice();
	}

	// Token: 0x04002915 RID: 10517
	private const int WEBVIEWCD = 5000;
}
