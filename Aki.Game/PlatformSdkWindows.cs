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

// Token: 0x02000E55 RID: 3669
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkWindows : PlatformSdkBase
{
	// Token: 0x06005922 RID: 22818 RVA: 0x00102E0D File Offset: 0x0010100D
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x06005923 RID: 22819 RVA: 0x00102E40 File Offset: 0x00101040
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

	// Token: 0x06005924 RID: 22820 RVA: 0x00102EEC File Offset: 0x001010EC
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

	// Token: 0x06005925 RID: 22821 RVA: 0x00102F94 File Offset: 0x00101194
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

	// Token: 0x06005926 RID: 22822 RVA: 0x00103004 File Offset: 0x00101204
	public virtual void AnnounceRedPointCallBack(string result)
	{
		PlatformSdkWindows.WindowsSdkRedPointContentSt windowsSdkRedPointContentSt = Json.Parse<PlatformSdkWindows.WindowsSdkRedPointContentSt>(Json.Parse<PlatformSdkWindows.WindowsSdkRedPointSt>(result, null).data, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(windowsSdkRedPointContentSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x00103044 File Offset: 0x00101244
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

	// Token: 0x06005928 RID: 22824 RVA: 0x00103088 File Offset: 0x00101288
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

	// Token: 0x06005929 RID: 22825 RVA: 0x00103108 File Offset: 0x00101308
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

	// Token: 0x0600592A RID: 22826 RVA: 0x00103262 File Offset: 0x00101462
	public override void SdkExit()
	{
		UKuroSDKManager.ShowExitGameDialog();
	}

	// Token: 0x0600592B RID: 22827 RVA: 0x0010326C File Offset: 0x0010146C
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
		string text = Json.Stringify<InitializePostWebViewParam>(new InitializePostWebViewParam
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

	// Token: 0x0600592C RID: 22828 RVA: 0x00103390 File Offset: 0x00101590
	public override string GetChannelId()
	{
		return UKuroSDKManager.GetSdkParams("channel_id");
	}

	// Token: 0x0600592D RID: 22829 RVA: 0x0010339C File Offset: 0x0010159C
	public override string GetChannelName()
	{
		return UKuroSDKManager.GetSdkParams("channel_name");
	}

	// Token: 0x0600592E RID: 22830 RVA: 0x001033A8 File Offset: 0x001015A8
	public override string GetGameId()
	{
		return UKuroSDKManager.GetSdkParams("project_id");
	}

	// Token: 0x0600592F RID: 22831 RVA: 0x001033B4 File Offset: 0x001015B4
	public override string GetDid()
	{
		return UKuroSDKManager.GetSdkParams("did");
	}

	// Token: 0x06005930 RID: 22832 RVA: 0x001033C0 File Offset: 0x001015C0
	public override string GetAccessToken()
	{
		return UKuroSDKManager.GetSdkParams("token");
	}

	// Token: 0x06005931 RID: 22833 RVA: 0x001033CC File Offset: 0x001015CC
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

	// Token: 0x06005932 RID: 22834 RVA: 0x00103400 File Offset: 0x00101600
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

	// Token: 0x06005933 RID: 22835 RVA: 0x00103434 File Offset: 0x00101634
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

	// Token: 0x06005934 RID: 22836 RVA: 0x0010353C File Offset: 0x0010173C
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

	// Token: 0x06005935 RID: 22837 RVA: 0x00103590 File Offset: 0x00101790
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

	// Token: 0x06005936 RID: 22838 RVA: 0x001035D8 File Offset: 0x001017D8
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

	// Token: 0x06005937 RID: 22839 RVA: 0x00103620 File Offset: 0x00101820
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

	// Token: 0x06005938 RID: 22840 RVA: 0x00103668 File Offset: 0x00101868
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

	// Token: 0x06005939 RID: 22841 RVA: 0x00103758 File Offset: 0x00101958
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

	// Token: 0x0600593A RID: 22842 RVA: 0x00103858 File Offset: 0x00101A58
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

	// Token: 0x0600593B RID: 22843 RVA: 0x001038EC File Offset: 0x00101AEC
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

	// Token: 0x040028BE RID: 10430
	private const int WEBVIEWCD = 5000;

	// Token: 0x040028BF RID: 10431
	public readonly Action<string> OnAnnounceInitCallBack = delegate(string result)
	{
	};

	// Token: 0x040028C0 RID: 10432
	public readonly Action<string> OnLoginCallBack = delegate(string result)
	{
	};

	// Token: 0x020074E3 RID: 29923
	[Nullable(0)]
	private class WindowsSdkRedPointSt
	{
		// Token: 0x04026B65 RID: 158565
		public string data;

		// Token: 0x04026B66 RID: 158566
		public int error;

		// Token: 0x04026B67 RID: 158567
		public string type;
	}

	// Token: 0x020074E4 RID: 29924
	[NullableContext(0)]
	private class WindowsSdkRedPointContentSt
	{
		// Token: 0x04026B68 RID: 158568
		public bool showRed;
	}

	// Token: 0x020074E5 RID: 29925
	[Nullable(0)]
	private class WindowsSdkCustomerServiceSt
	{
		// Token: 0x04026B69 RID: 158569
		public string data;

		// Token: 0x04026B6A RID: 158570
		public int error;

		// Token: 0x04026B6B RID: 158571
		public string type;
	}

	// Token: 0x020074E6 RID: 29926
	[NullableContext(0)]
	private class WindowsSdkCustomerServiceContentSt
	{
		// Token: 0x04026B6C RID: 158572
		public int cuid;

		// Token: 0x04026B6D RID: 158573
		public int isreddot;
	}

	// Token: 0x020074E7 RID: 29927
	[Nullable(0)]
	private class WindowsPaymentSt
	{
		// Token: 0x04026B6E RID: 158574
		public string data;

		// Token: 0x04026B6F RID: 158575
		public int error;

		// Token: 0x04026B70 RID: 158576
		public string type;
	}
}
