using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Launcher.Platform;

// Token: 0x02000E41 RID: 3649
[NullableContext(1)]
[Nullable(0)]
public class PlatformCloudSdkBase : PlatformSdkWindows
{
	// Token: 0x060057C7 RID: 22471 RVA: 0x000FD190 File Offset: 0x000FB390
	public override void BindProtocolListener()
	{
	}

	// Token: 0x060057C8 RID: 22472 RVA: 0x000FD192 File Offset: 0x000FB392
	public override void BindShareResultListener()
	{
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnShareResult, new TCloudGameOnReceiveDataFunction(this.OnCloudShareResult));
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnSDKPayResult, new TCloudGameOnReceiveDataFunction(this.OnSdkPayResult));
	}

	// Token: 0x060057C9 RID: 22473 RVA: 0x000FD1C2 File Offset: 0x000FB3C2
	public override void KuroSdkBindRedPointFunction(Action<int> callBack)
	{
	}

	// Token: 0x060057CA RID: 22474 RVA: 0x000FD1C4 File Offset: 0x000FB3C4
	public override void KuroSdkExitBindFunction()
	{
	}

	// Token: 0x060057CB RID: 22475 RVA: 0x000FD1C6 File Offset: 0x000FB3C6
	public override void KuroSdkQueryProductBindFunction()
	{
	}

	// Token: 0x060057CC RID: 22476 RVA: 0x000FD1C8 File Offset: 0x000FB3C8
	public override void KuroDeepLinkBindFunction()
	{
	}

	// Token: 0x060057CD RID: 22477 RVA: 0x000FD1CA File Offset: 0x000FB3CA
	public override void KuroGameWinStateBindFunction()
	{
	}

	// Token: 0x060057CE RID: 22478 RVA: 0x000FD1CC File Offset: 0x000FB3CC
	public override void SdkLogout()
	{
	}

	// Token: 0x060057CF RID: 22479 RVA: 0x000FD1D0 File Offset: 0x000FB3D0
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

	// Token: 0x060057D0 RID: 22480 RVA: 0x000FD234 File Offset: 0x000FB434
	public override void SdkCreateRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.TL, "云游戏上报创建新角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string createRoleInfo = KuroSdkControllerTool.GetCreateRoleInfo();
			CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKCreateRole, createRoleInfo);
		}
	}

	// Token: 0x060057D1 RID: 22481 RVA: 0x000FD27C File Offset: 0x000FB47C
	public override void SdkSelectRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.TL, "云游戏上报选择新角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = KuroSdkControllerTool.GetRoleInfo();
			CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKSelectRole, roleInfo);
		}
	}

	// Token: 0x060057D2 RID: 22482 RVA: 0x000FD2C4 File Offset: 0x000FB4C4
	public override void SdkLevelUpRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.TL, "云游戏上报角色升级", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = KuroSdkControllerTool.GetRoleInfo();
			CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKLevelUpRole, roleInfo);
		}
	}

	// Token: 0x060057D3 RID: 22483 RVA: 0x000FD30C File Offset: 0x000FB50C
	public override void SdkOpenLoginWnd()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.RequestLogin);
		Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "请求重新下发缓存的SDK登录信息", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060057D4 RID: 22484 RVA: 0x000FD343 File Offset: 0x000FB543
	public override void OpenUserCenter()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.OpenUserCenter);
	}

	// Token: 0x060057D5 RID: 22485 RVA: 0x000FD350 File Offset: 0x000FB550
	public override void ShowAgreement()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.OpenAgreement);
	}

	// Token: 0x060057D6 RID: 22486 RVA: 0x000FD35D File Offset: 0x000FB55D
	public override void KuroOpenPrivacyClauseWnd()
	{
		CloudGameManager.Instance.SendData(ECloudGameSendData.OpenPrivacyClause);
	}

	// Token: 0x060057D7 RID: 22487 RVA: 0x000FD36C File Offset: 0x000FB56C
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
		string text = Json.Stringify<OpenPostWebViewParam>(openPostWebViewParam, null);
		Log instance3 = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "云游戏OpenPostWebView";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", text);
		instance3.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.OpenPostWebView, text);
	}

	// Token: 0x060057D8 RID: 22488 RVA: 0x000FD4EC File Offset: 0x000FB6EC
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

	// Token: 0x060057D9 RID: 22489 RVA: 0x000FD584 File Offset: 0x000FB784
	public override void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenTime = Time.Instance.Now;
		string text = Json.Stringify<OpenWebViewParamCloudGame>(new OpenWebViewParamCloudGame
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

	// Token: 0x060057DA RID: 22490 RVA: 0x000FD65F File Offset: 0x000FB85F
	public override void SdkOpenUrlWnd(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true)
	{
		this.OpenWebView(title, url, isLandscape, transparent, webAccelerated, string.Empty);
	}

	// Token: 0x060057DB RID: 22491 RVA: 0x000FD673 File Offset: 0x000FB873
	private void OnCloudShareResult(string resultJson)
	{
		if (Json.Decode<ShareResult>(resultJson, null).ErrorCode == 0)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x060057DC RID: 22492 RVA: 0x000FD6A8 File Offset: 0x000FB8A8
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

	// Token: 0x060057DD RID: 22493 RVA: 0x000FD748 File Offset: 0x000FB948
	public override void RecoverSdkData()
	{
		Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "PlatformCloudSdkBase.RecoverSdkData", default(ReadOnlySpan<ValueTuple<string, object>>));
		CloudGameManager.Instance.TryRequestGamePadDevice();
	}

	// Token: 0x0400287C RID: 10364
	private const int WEBVIEWCD = 5000;
}
