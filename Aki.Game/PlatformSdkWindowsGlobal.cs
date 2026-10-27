using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000E5D RID: 3677
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkWindowsGlobal : PlatformSdkBase
{
	// Token: 0x06005944 RID: 22852 RVA: 0x00103A55 File Offset: 0x00101C55
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x06005945 RID: 22853 RVA: 0x00103A88 File Offset: 0x00101C88
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceInitDelegate.Clear();
		UKuroSDKManager.Get().AnnounceInitDelegate.Add(this.OnAnnounceInitCallBack);
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(this.AnnounceRedPointCallBack);
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
		UKuroSDKManager.Get().OnLoginDelegate.Clear();
		UKuroSDKManager.Get().OnLoginDelegate.Add(this.OnLoginCallBack);
	}

	// Token: 0x06005946 RID: 22854 RVA: 0x00103B2C File Offset: 0x00101D2C
	public void CustomerServiceResultCallBack(string result)
	{
		WindowsSdkCustomerServiceSt windowsSdkCustomerServiceSt = Json.Parse<WindowsSdkCustomerServiceSt>(result, null);
		WindowsSdkCustomerServiceContentSt windowsSdkCustomerServiceContentSt = Json.Parse<WindowsSdkCustomerServiceContentSt>(windowsSdkCustomerServiceSt.data, null);
		if (windowsSdkCustomerServiceSt != null)
		{
			this.CurrentCustomerShowState = (windowsSdkCustomerServiceContentSt.isreddot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06005947 RID: 22855 RVA: 0x00103B70 File Offset: 0x00101D70
	public override void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		OpenWebViewParamWindows openWebViewParamWindows = new OpenWebViewParamWindows();
		openWebViewParamWindows.title = title;
		openWebViewParamWindows.url = url;
		openWebViewParamWindows.transparent = transparent;
		openWebViewParamWindows.titlebar = transparent;
		openWebViewParamWindows.innerbrowser = true;
		openWebViewParamWindows.webAccelerated = webAccelerated;
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

	// Token: 0x06005948 RID: 22856 RVA: 0x00103C20 File Offset: 0x00101E20
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

	// Token: 0x06005949 RID: 22857 RVA: 0x00103C90 File Offset: 0x00101E90
	public override void SdkExit()
	{
		KuroApplication.ExitWithReason(false, "SdkExit");
	}

	// Token: 0x0600594A RID: 22858 RVA: 0x00103CA0 File Offset: 0x00101EA0
	public override void InitializePostWebView()
	{
		string currentSelectServerId = this.GetCurrentSelectServerId();
		string text = Json.Stringify<InitializePostWebViewParam>(new InitializePostWebViewParam
		{
			language = LanguageSystem.Instance.PackageLanguage,
			cdn = new string[]
			{
				PublicUtil.Instance.GetNoticeBaseUrl() + "/gamenotice/" + PublicUtil.Instance.GetGameId() + "/"
			},
			serverId = currentSelectServerId
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

	// Token: 0x0600594B RID: 22859 RVA: 0x00103D40 File Offset: 0x00101F40
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

	// Token: 0x0600594C RID: 22860 RVA: 0x00103D74 File Offset: 0x00101F74
	private string GetPaymentInfo(ISDKPayment payment, ISDKPayRole roleInfo)
	{
		return JsonSerializer.Serialize<PayInfoWindowsGlobal>(new PayInfoWindowsGlobal
		{
			roleId = roleInfo.roleId.ToString(),
			roleName = roleInfo.roleName.ToString(),
			serverId = roleInfo.serverId.ToString(),
			serverName = roleInfo.serverName.ToString(),
			cpOrder = payment.cpOrderId.ToString(),
			callbackUrl = payment.callbackUrl.ToString(),
			goodsId = payment.product_id.ToString(),
			productName = payment.goodsName.ToString(),
			goodsDesc = payment.goodsDesc.ToString(),
			currencyType = "USD",
			customMsg = roleInfo.roleId.ToString(),
			price = payment.price.ToString()
		}, KuroSdkJsonOptions.Unescaped);
	}

	// Token: 0x0600594D RID: 22861 RVA: 0x00103E58 File Offset: 0x00102058
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

	// Token: 0x0600594E RID: 22862 RVA: 0x00103EAC File Offset: 0x001020AC
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

	// Token: 0x0600594F RID: 22863 RVA: 0x00103EF4 File Offset: 0x001020F4
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

	// Token: 0x06005950 RID: 22864 RVA: 0x00103F3C File Offset: 0x0010213C
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

	// Token: 0x06005951 RID: 22865 RVA: 0x00103F84 File Offset: 0x00102184
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

	// Token: 0x06005952 RID: 22866 RVA: 0x00104074 File Offset: 0x00102274
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

	// Token: 0x06005953 RID: 22867 RVA: 0x00104174 File Offset: 0x00102374
	public override void OpenUserCenter()
	{
		UKuroSDKManager.BindAccount();
	}

	// Token: 0x06005954 RID: 22868 RVA: 0x0010417C File Offset: 0x0010237C
	public override void QueryProduct(string[] productList, string channelId)
	{
		string text = "";
		int num = productList.Length;
		for (int i = 0; i < num; i++)
		{
			text += productList[i];
			if (i != num - 1)
			{
				text += ",";
			}
		}
		UKuroSDKManager.QueryProductInfo(Json.Stringify<QueryProductInfoParamWindows>(new QueryProductInfoParamWindows
		{
			goodsIds = text,
			payChannel = channelId
		}, null) ?? "");
	}

	// Token: 0x06005955 RID: 22869 RVA: 0x001041E4 File Offset: 0x001023E4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected override QueryProductSt[] OnQueryProduct(string str)
	{
		WindowsSdkQueryProductSt windowsSdkQueryProductSt = Json.Parse<WindowsSdkQueryProductSt>(str, null);
		List<QueryProductSt> list = new List<QueryProductSt>();
		if (((windowsSdkQueryProductSt != null) ? windowsSdkQueryProductSt.data : null) != null)
		{
			foreach (WindowsSdkProductContentSt windowsSdkProductContentSt in windowsSdkQueryProductSt.data)
			{
				list.Add(new QueryProductSt
				{
					ChannelGoodId = windowsSdkProductContentSt.channelGoodsId,
					Currency = windowsSdkProductContentSt.currency,
					CurrencyCode = windowsSdkProductContentSt.currencyCode,
					GoodId = windowsSdkProductContentSt.goodsId,
					Name = windowsSdkProductContentSt.name,
					Price = new float?(windowsSdkProductContentSt.price)
				});
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005956 RID: 22870 RVA: 0x00104298 File Offset: 0x00102498
	public override void SetFont()
	{
		SetFontParamWindows setFontParamWindows = new SetFontParamWindows();
		string currentFontName = KuroSdkModel.Instance.GetCurrentFontName();
		setFontParamWindows.name = currentFontName;
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		setFontParamWindows.path = UBlueprintPathsLibrary.RootDir() + "Client/Binaries/Win64/ThirdParty/KrPcSdk_Global/" + deviceFontAsset;
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

	// Token: 0x06005957 RID: 22871 RVA: 0x00104329 File Offset: 0x00102529
	public override string GetChannelId()
	{
		return UKuroSDKManager.GetSdkParams("channel_id");
	}

	// Token: 0x06005958 RID: 22872 RVA: 0x00104335 File Offset: 0x00102535
	public override string GetChannelName()
	{
		return UKuroSDKManager.GetSdkParams("channel_name");
	}

	// Token: 0x06005959 RID: 22873 RVA: 0x00104341 File Offset: 0x00102541
	public override string GetGameId()
	{
		return UKuroSDKManager.GetSdkParams("project_id");
	}

	// Token: 0x0600595A RID: 22874 RVA: 0x0010434D File Offset: 0x0010254D
	public override string GetDid()
	{
		return UKuroSDKManager.GetSdkParams("did");
	}

	// Token: 0x0600595B RID: 22875 RVA: 0x00104359 File Offset: 0x00102559
	public override string GetAccessToken()
	{
		return UKuroSDKManager.GetSdkParams("token");
	}

	// Token: 0x0600595C RID: 22876 RVA: 0x00104368 File Offset: 0x00102568
	public override void SdkOpenUrlWnd(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true)
	{
		if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenTime = Time.Instance.Now;
		this.OpenWebView(title, url, isLandscape, transparent, webAccelerated, string.Empty);
	}

	// Token: 0x0600595D RID: 22877 RVA: 0x001043D9 File Offset: 0x001025D9
	public override bool GetProtocolState()
	{
		return true;
	}

	// Token: 0x0600595E RID: 22878 RVA: 0x001043DC File Offset: 0x001025DC
	protected override void OnPaymentCallBack(FPaymentStruct payment, string strResult, Action<bool, string> paymentFunction)
	{
		WindowsPaymentSt windowsPaymentSt = Json.Parse<WindowsPaymentSt>(strResult, null);
		bool arg = false;
		if (windowsPaymentSt != null && windowsPaymentSt.error == 0)
		{
			arg = true;
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "OnPaymentCallBack Windows Success", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		paymentFunction(arg, strResult);
	}

	// Token: 0x040028D6 RID: 10454
	private const int WEBVIEWCD = 5000;

	// Token: 0x040028D7 RID: 10455
	public readonly Action<string> OnAnnounceInitCallBack = delegate(string result)
	{
	};

	// Token: 0x040028D8 RID: 10456
	public readonly Action<string> AnnounceRedPointCallBack = delegate(string result)
	{
		WindowsSdkRedPointContentSt windowsSdkRedPointContentSt = Json.Parse<WindowsSdkRedPointContentSt>(Json.Parse<WindowsSdkRedPointSt>(result, null).data, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(windowsSdkRedPointContentSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	};

	// Token: 0x040028D9 RID: 10457
	public readonly Action<string> OnLoginCallBack = delegate(string result)
	{
	};
}
