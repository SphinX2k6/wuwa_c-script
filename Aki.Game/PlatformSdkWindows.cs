using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x0200030A RID: 778
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkWindows : PlatformSdkBase
{
	// Token: 0x06002CB9 RID: 11449 RVA: 0x0010AACD File Offset: 0x00108CCD
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x0010AB00 File Offset: 0x00108D00
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceInitDelegate.Clear();
		UKuroSDKManager.Get().AnnounceInitDelegate.Add(this.OnAnnounceInitCallBack);
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(new Action<string>(this.AnnounceRedPointCallBack));
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
		UKuroSDKManager.Get().OnLoginDelegate.Clear();
		UKuroSDKManager.Get().OnLoginDelegate.Add(this.OnLoginCallBack);
	}

	// Token: 0x06002CBB RID: 11451 RVA: 0x0010ABAC File Offset: 0x00108DAC
	public override void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		OpenWebViewParamWindows openWebViewParamWindows = new OpenWebViewParamWindows();
		openWebViewParamWindows.title = title;
		openWebViewParamWindows.url = url;
		openWebViewParamWindows.transparent = transparent;
		openWebViewParamWindows.webAccelerated = webAccelerated;
		openWebViewParamWindows.innerbrowser = true;
		openWebViewParamWindows.identifier = identifier;
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		string text = JsonSerializer.Serialize<OpenWebViewParamWindows>(openWebViewParamWindows, options);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "OpenWebView";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text ?? "");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, text ?? "");
	}

	// Token: 0x06002CBC RID: 11452 RVA: 0x0010AC54 File Offset: 0x00108E54
	[return: Nullable(2)]
	public override string GetSdkOpenUrlWndInfo(string title, string url)
	{
		OpenSdkUrlWndParamWindows openSdkUrlWndParamWindows = new OpenSdkUrlWndParamWindows();
		openSdkUrlWndParamWindows.title = title;
		openSdkUrlWndParamWindows.url = url;
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		string text = JsonSerializer.Serialize<OpenSdkUrlWndParamWindows>(openSdkUrlWndParamWindows, options);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SdkJson";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text ?? "");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return text;
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x0010ACC4 File Offset: 0x00108EC4
	public virtual void AnnounceRedPointCallBack(string result)
	{
		PlatformSdkWindows.WindowsSdkRedPointContentSt windowsSdkRedPointContentSt = Json.Parse<PlatformSdkWindows.WindowsSdkRedPointContentSt>(Json.Parse<PlatformSdkWindows.WindowsSdkRedPointSt>(result, null).data, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(windowsSdkRedPointContentSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06002CBE RID: 11454 RVA: 0x0010AD04 File Offset: 0x00108F04
	public virtual void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkWindows.WindowsSdkCustomerServiceSt windowsSdkCustomerServiceSt = Json.Parse<PlatformSdkWindows.WindowsSdkCustomerServiceSt>(result, null);
		PlatformSdkWindows.WindowsSdkCustomerServiceContentSt windowsSdkCustomerServiceContentSt = Json.Parse<PlatformSdkWindows.WindowsSdkCustomerServiceContentSt>(windowsSdkCustomerServiceSt.data, null);
		if (windowsSdkCustomerServiceSt != null)
		{
			this.CurrentCustomerShowState = (windowsSdkCustomerServiceContentSt.isreddot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002CBF RID: 11455 RVA: 0x0010AD48 File Offset: 0x00108F48
	public override void SdkOpenUrlWnd(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true)
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
			{
				GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
				return;
			}
			this.LastOpenTime = Time.Instance.Now;
			this.OpenWebView(title, url, isLandscape, transparent, webAccelerated, string.Empty);
		}
	}

	// Token: 0x06002CC0 RID: 11456 RVA: 0x0010ADC8 File Offset: 0x00108FC8
	public override void OpenFeedback()
	{
		IFeedBackData feedBackUrl = BaseConfigController.Instance.GetFeedBackUrl();
		if (feedBackUrl == null)
		{
			return;
		}
		string url = feedBackUrl.url;
		LoginModel instance = LoginModel.Instance;
		FunctionModel instance2 = FunctionModel.Instance;
		string text;
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			text = "0";
		}
		else
		{
			SdkLoginConfig sdkLoginConfig = instance.GetSdkLoginConfig();
			text = (((sdkLoginConfig != null) ? sdkLoginConfig.Token : null) ?? "0");
		}
		string text2 = text;
		string text3;
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			text3 = "0";
		}
		else
		{
			SdkLoginConfig sdkLoginConfig2 = instance.GetSdkLoginConfig();
			text3 = (((sdkLoginConfig2 != null) ? sdkLoginConfig2.Uid : null) ?? "0");
		}
		string text4 = text3;
		SdkLoginConfig sdkLoginConfig3 = instance.GetSdkLoginConfig();
		string text5;
		if (((sdkLoginConfig3 != null) ? sdkLoginConfig3.UserName : null) == null)
		{
			text5 = "";
		}
		else
		{
			SdkLoginConfig sdkLoginConfig4 = instance.GetSdkLoginConfig();
			text5 = (((sdkLoginConfig4 != null) ? sdkLoginConfig4.UserName : null) ?? "");
		}
		string text6 = text5;
		string url2 = StringUtils.Format(this.FeedBackSt, new string[]
		{
			url,
			text2,
			instance.GetServerId().ToString(),
			text4,
			text6,
			instance2.GetPlayerName().ToString(),
			FunctionModel.Instance.PlayerId.ToString(),
			LanguageSystem.Instance.PackageLanguage
		});
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			UKismetSystemLibrary.LaunchURL(url2);
			return;
		}
		KuroSdkController.Instance.OpenWebView(feedBackUrl.title, url2, true, true, true, "Default");
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x0010AF22 File Offset: 0x00109122
	public override void SdkExit()
	{
		UKuroSDKManager.ShowExitGameDialog();
	}

	// Token: 0x06002CC2 RID: 11458 RVA: 0x0010AF2C File Offset: 0x0010912C
	public override void InitializePostWebView()
	{
		List<ILoginServersData> loginServersByClientRegion = LoginServerModel.Instance.GetLoginServersByClientRegion();
		if (loginServersByClientRegion == null)
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "没有登录服务器信息", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "serverId", default(ReadOnlySpan<ValueTuple<string, object>>));
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, loginServersByClientRegion[0].id, default(ReadOnlySpan<ValueTuple<string, object>>));
		string text = Json.Stringify(new InitializePostWebViewParam
		{
			language = LanguageSystem.Instance.PackageLanguage,
			cdn = new string[]
			{
				PublicUtil.Instance.GetNoticeBaseUrl() + "/gamenotice/" + PublicUtil.Instance.GetGameId() + "/"
			},
			serverId = ((loginServersByClientRegion[0].id == null) ? "1013" : loginServersByClientRegion[0].id)
		}, null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "初始化公告";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroInitializePostWebView;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, text);
	}

	// Token: 0x06002CC3 RID: 11459 RVA: 0x0010B050 File Offset: 0x00109250
	public override string GetChannelId()
	{
		return UKuroSDKManager.GetSdkParams("channel_id");
	}

	// Token: 0x06002CC4 RID: 11460 RVA: 0x0010B05C File Offset: 0x0010925C
	public override string GetChannelName()
	{
		return UKuroSDKManager.GetSdkParams("channel_name");
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x0010B068 File Offset: 0x00109268
	public override string GetGameId()
	{
		return UKuroSDKManager.GetSdkParams("project_id");
	}

	// Token: 0x06002CC6 RID: 11462 RVA: 0x0010B074 File Offset: 0x00109274
	public override string GetDid()
	{
		return UKuroSDKManager.GetSdkParams("did");
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x0010B080 File Offset: 0x00109280
	public override string GetAccessToken()
	{
		return UKuroSDKManager.GetSdkParams("token");
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x0010B08C File Offset: 0x0010928C
	public override SdkAgreementLinkData[] GetAgreement()
	{
		SdkAgreementLinkData[] result = new SdkAgreementLinkData[0];
		string sdkParams = UKuroSDKManager.GetSdkParams("game_init_agreement");
		if (!KuroSdkController.Instance.GetIfGlobalSdk())
		{
			result = Json.Parse<SdkAgreementLinkData[]>(sdkParams, null);
		}
		return result;
	}

	// Token: 0x06002CC9 RID: 11465 RVA: 0x0010B0C0 File Offset: 0x001092C0
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			ISDKPayRole sdkPayRoleInfo = KuroSdkControllerTool.GetSdkPayRoleInfo();
			string paymentInfo2 = this.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroPay;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, paymentInfo2);
		}
	}

	// Token: 0x06002CCA RID: 11466 RVA: 0x0010B0F4 File Offset: 0x001092F4
	private string GetPaymentInfo(ISDKPayment payment, ISDKPayRole roleInfo)
	{
		return JsonSerializer.Serialize<PayInfoWindows>(new PayInfoWindows
		{
			roleId = roleInfo.roleId.ToString(),
			roleName = roleInfo.roleName.ToString(),
			serverId = roleInfo.serverId.ToString(),
			serverName = roleInfo.serverName.ToString(),
			cpOrderId = payment.cpOrderId.ToString(),
			callbackUrl = payment.callbackUrl.ToString(),
			product_id = payment.product_id.ToString(),
			goodsName = payment.goodsName.ToString(),
			goodsDesc = payment.goodsDesc.ToString(),
			currency = "",
			extraParams = ""
		}, KuroSdkJsonOptions.Unescaped).Replace("}", ",") + StringUtils.Format("\"price\":{0}", new string[]
		{
			payment.price.ToString()
		}) + "}";
	}

	// Token: 0x06002CCB RID: 11467 RVA: 0x0010B1FC File Offset: 0x001093FC
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		UKuroSDKManager.OpenCustomerService(JsonSerializer.Serialize<OpenCustomerServiceParamWindows>(new OpenCustomerServiceParamWindows
		{
			islogin = instance.IsSdkLoggedIn(),
			from = fromType,
			roleId = this.GetCustomServerRoleId(),
			extendsInfo = this.GetCustomServerExtendsInfo()
		}, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x06002CCC RID: 11468 RVA: 0x0010B250 File Offset: 0x00109450
	public override void SdkSelectRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "上报选择角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = this.GetRoleInfo();
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKSelectedRole;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, roleInfo);
		}
	}

	// Token: 0x06002CCD RID: 11469 RVA: 0x0010B298 File Offset: 0x00109498
	public override void SdkCreateRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "上报创建新角色", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string createRoleInfo = this.GetCreateRoleInfo();
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKCreateRole;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, createRoleInfo);
		}
	}

	// Token: 0x06002CCE RID: 11470 RVA: 0x0010B2E0 File Offset: 0x001094E0
	public override void SdkLevelUpRole()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "上报角色升级", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string roleInfo = this.GetRoleInfo();
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroSDKUpgradeRole;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, roleInfo);
		}
	}

	// Token: 0x06002CCF RID: 11471 RVA: 0x0010B328 File Offset: 0x00109528
	private string GetCreateRoleInfo()
	{
		LoginModel instance = LoginModel.Instance;
		RoleInfoWindows roleInfoWindows = new RoleInfoWindows();
		roleInfoWindows.roleId = this.GetRoleId();
		roleInfoWindows.roleName = (instance.GetPlayerName() ?? "");
		roleInfoWindows.serverId = (instance.GetServerId() ?? "");
		roleInfoWindows.serverName = (instance.GetServerName() ?? "");
		roleInfoWindows.roleLevel = "1";
		roleInfoWindows.vipLevel = "0";
		roleInfoWindows.partyName = " ";
		roleInfoWindows.roleCreateTime = ((instance.GetCreatePlayerTime() != 0.0) ? instance.GetCreatePlayerTime().ToString() : "");
		roleInfoWindows.setBalanceLevelOne = "0";
		roleInfoWindows.setBalanceLevelTwo = "0";
		roleInfoWindows.setSumPay = "0";
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		return JsonSerializer.Serialize<RoleInfoWindows>(roleInfoWindows, options);
	}

	// Token: 0x06002CD0 RID: 11472 RVA: 0x0010B418 File Offset: 0x00109618
	private string GetRoleInfo()
	{
		FunctionModel instance = FunctionModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		RoleInfoWindows roleInfoWindows = new RoleInfoWindows();
		roleInfoWindows.roleId = this.GetRoleId();
		roleInfoWindows.roleName = (instance.GetPlayerName() ?? "");
		roleInfoWindows.serverId = (instance2.GetServerId() ?? "");
		roleInfoWindows.serverName = (instance2.GetServerName() ?? "");
		int? playerLevel = instance.GetPlayerLevel();
		roleInfoWindows.roleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1");
		roleInfoWindows.vipLevel = "0";
		roleInfoWindows.partyName = " ";
		roleInfoWindows.roleCreateTime = "";
		roleInfoWindows.setBalanceLevelOne = instance.GetPlayerCashCoin();
		roleInfoWindows.setBalanceLevelTwo = "0";
		roleInfoWindows.setSumPay = "0";
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		return JsonSerializer.Serialize<RoleInfoWindows>(roleInfoWindows, options);
	}

	// Token: 0x06002CD1 RID: 11473 RVA: 0x0010B518 File Offset: 0x00109718
	public override void SetFont()
	{
		SetFontParamWindows setFontParamWindows = new SetFontParamWindows();
		string currentFontName = KuroSdkModel.Instance.GetCurrentFontName();
		setFontParamWindows.name = currentFontName;
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		setFontParamWindows.path = UBlueprintPathsLibrary.RootDir() + "Client/Binaries/Win64/ThirdParty/KrPcSdk_Mainland/" + deviceFontAsset;
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		string text = JsonSerializer.Serialize<SetFontParamWindows>(setFontParamWindows, options);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SetFont";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.SetFont(text);
	}

	// Token: 0x06002CD2 RID: 11474 RVA: 0x0010B5AC File Offset: 0x001097AC
	protected override void OnPaymentCallBack(FPaymentStruct payment, string strResult, Action<bool, string> paymentFunction)
	{
		PlatformSdkWindows.WindowsPaymentSt windowsPaymentSt = Json.Parse<PlatformSdkWindows.WindowsPaymentSt>(strResult, null);
		bool arg = false;
		if (windowsPaymentSt != null && windowsPaymentSt.error == 0)
		{
			arg = true;
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "OnPaymentCallBack Windows Success", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		paymentFunction(arg, strResult);
	}

	// Token: 0x04002959 RID: 10585
	private const int WEBVIEWCD = 5000;

	// Token: 0x0400295A RID: 10586
	public readonly Action<string> OnAnnounceInitCallBack = delegate(string result)
	{
	};

	// Token: 0x0400295B RID: 10587
	public readonly Action<string> OnLoginCallBack = delegate(string result)
	{
	};

	// Token: 0x02006677 RID: 26231
	[Nullable(0)]
	private class WindowsSdkRedPointSt
	{
		// Token: 0x04021EAA RID: 138922
		public string data;

		// Token: 0x04021EAB RID: 138923
		public int error;

		// Token: 0x04021EAC RID: 138924
		public string type;
	}

	// Token: 0x02006678 RID: 26232
	[NullableContext(0)]
	private class WindowsSdkRedPointContentSt
	{
		// Token: 0x04021EAD RID: 138925
		public bool showRed;
	}

	// Token: 0x02006679 RID: 26233
	[Nullable(0)]
	private class WindowsSdkCustomerServiceSt
	{
		// Token: 0x04021EAE RID: 138926
		public string data;

		// Token: 0x04021EAF RID: 138927
		public int error;

		// Token: 0x04021EB0 RID: 138928
		public string type;
	}

	// Token: 0x0200667A RID: 26234
	[NullableContext(0)]
	private class WindowsSdkCustomerServiceContentSt
	{
		// Token: 0x04021EB1 RID: 138929
		public int cuid;

		// Token: 0x04021EB2 RID: 138930
		public int isreddot;
	}

	// Token: 0x0200667B RID: 26235
	[Nullable(0)]
	private class WindowsPaymentSt
	{
		// Token: 0x04021EB3 RID: 138931
		public string data;

		// Token: 0x04021EB4 RID: 138932
		public int error;

		// Token: 0x04021EB5 RID: 138933
		public string type;
	}
}
