using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000309 RID: 777
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkOpenHarmony : PlatformSdkBase
{
	// Token: 0x06002C9A RID: 11418 RVA: 0x0010A02C File Offset: 0x0010822C
	[return: Nullable(2)]
	protected override string ParseGameWindowStateStatusJson(string result)
	{
		OpenHarmonyGameWindowStateData openHarmonyGameWindowStateData = JsonSerializer.Deserialize<OpenHarmonyGameWindowStateData>(result, new JsonSerializerOptions
		{
			IncludeFields = true,
			NumberHandling = JsonNumberHandling.AllowReadingFromString
		});
		if (openHarmonyGameWindowStateData == null)
		{
			return null;
		}
		if (openHarmonyGameWindowStateData.status == null)
		{
			return null;
		}
		return openHarmonyGameWindowStateData.status.GetValueOrDefault().ToString();
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x0010A078 File Offset: 0x00108278
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(new Action<string>(this.AnnounceRedPointCallBack));
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x0010A0D9 File Offset: 0x001082D9
	protected override void OnInit()
	{
		UKuroSDKManager.GetBasicInfo().bIsValid = false;
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
			FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
			FCrashSightProxy.SetCustomData("SdkOaid", this.GetOaid());
			FCrashSightProxy.SetCustomData("SdkJyId", this.GetJyDid());
			FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
		}, 10000f, null, null, true, 1f);
	}

	// Token: 0x06002C9D RID: 11421 RVA: 0x0010A10C File Offset: 0x0010830C
	public void AnnounceRedPointCallBack(string result)
	{
		AndroidSdkRePointSt androidSdkRePointSt = Json.Parse<AndroidSdkRePointSt>(result, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(androidSdkRePointSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06002C9E RID: 11422 RVA: 0x0010A144 File Offset: 0x00108344
	public void CustomerServiceResultCallBack(string result)
	{
		string[] array = result.Split(',', StringSplitOptions.None);
		if (array != null && array.Length > 1)
		{
			this.CurrentCustomerShowState = (int.Parse(array[1]) > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002C9F RID: 11423 RVA: 0x0010A188 File Offset: 0x00108388
	public override void SdkOpenUrlWnd(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true)
	{
		if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenTime = Time.Instance.Now;
		OpenWebViewParamAndroid openWebViewParamAndroid = new OpenWebViewParamAndroid();
		openWebViewParamAndroid.title = title;
		openWebViewParamAndroid.url = url;
		openWebViewParamAndroid.isLandscape = isLandscape;
		openWebViewParamAndroid.transparent = transparent;
		openWebViewParamAndroid.webAccelerated = webAccelerated;
		openWebViewParamAndroid.identifier = "Default";
		openWebViewParamAndroid.showInDialog = false;
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		string data = JsonSerializer.Serialize<OpenWebViewParamAndroid>(openWebViewParamAndroid, options);
		UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, "Default", data);
	}

	// Token: 0x06002CA0 RID: 11424 RVA: 0x0010A254 File Offset: 0x00108454
	public override void OpenFeedback()
	{
		IFeedBackData feedBackUrl = BaseConfigController.Instance.GetFeedBackUrl();
		if (feedBackUrl == null)
		{
			return;
		}
		string feedBackOpenUrl = this.GetFeedBackOpenUrl();
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			UKismetSystemLibrary.LaunchURL(feedBackOpenUrl);
			return;
		}
		this.OpenWebView(feedBackUrl.title, feedBackOpenUrl, true, false, true, "Default");
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x0010A2A0 File Offset: 0x001084A0
	public override void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenTime = Time.Instance.Now;
		OpenWebViewParamAndroid openWebViewParamAndroid = new OpenWebViewParamAndroid();
		openWebViewParamAndroid.title = title;
		openWebViewParamAndroid.url = url;
		openWebViewParamAndroid.isLandscape = isLandscape;
		openWebViewParamAndroid.transparent = transparent;
		openWebViewParamAndroid.webAccelerated = webAccelerated;
		openWebViewParamAndroid.identifier = identifier;
		openWebViewParamAndroid.showInDialog = false;
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		string data = JsonSerializer.Serialize<OpenWebViewParamAndroid>(openWebViewParamAndroid, options);
		UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, data);
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x0010A366 File Offset: 0x00108566
	public override void CloseWebView(string identifier)
	{
		UKuroSDKManager.CloseWebView(JsonSerializer.Serialize<Dictionary<string, string>>(new Dictionary<string, string>
		{
			{
				"identifier",
				identifier
			}
		}, null));
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x0010A384 File Offset: 0x00108584
	[NullableContext(2)]
	private OpenHarmonySdkParam GetSdkParamCache()
	{
		if (this.SdkParamCache == null)
		{
			string sdkParams = UKuroSDKManager.GetSdkParams("");
			this.SdkParamCache = Json.Parse<OpenHarmonySdkParam>(sdkParams, null);
			if (this.SdkParamCache == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.KuroSdk;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "GetSdkParamData parse failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", sdkParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return this.SdkParamCache;
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x0010A3E6 File Offset: 0x001085E6
	public override string GetChannelId()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.channelId : null) ?? "";
	}

	// Token: 0x06002CA5 RID: 11429 RVA: 0x0010A403 File Offset: 0x00108603
	public override string GetGameId()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.gameId : null) ?? "";
	}

	// Token: 0x06002CA6 RID: 11430 RVA: 0x0010A420 File Offset: 0x00108620
	public override string GetChannelName()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.channelName : null) ?? "";
	}

	// Token: 0x06002CA7 RID: 11431 RVA: 0x0010A43D File Offset: 0x0010863D
	public override string GetDid()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.did : null) ?? "";
	}

	// Token: 0x06002CA8 RID: 11432 RVA: 0x0010A45A File Offset: 0x0010865A
	public override string GetAppChannelId()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.appChannelId : null) ?? "";
	}

	// Token: 0x06002CA9 RID: 11433 RVA: 0x0010A477 File Offset: 0x00108677
	public override string GetOaid()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.oaid : null) ?? "";
	}

	// Token: 0x06002CAA RID: 11434 RVA: 0x0010A494 File Offset: 0x00108694
	public override string GetJyDid()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.jyDid : null) ?? "";
	}

	// Token: 0x06002CAB RID: 11435 RVA: 0x0010A4B1 File Offset: 0x001086B1
	public override string GetAccessToken()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.accessToken : null) ?? "";
	}

	// Token: 0x06002CAC RID: 11436 RVA: 0x0010A4D0 File Offset: 0x001086D0
	public override void SetFont()
	{
		SetFontParamOpenHarmony setFontParamOpenHarmony = new SetFontParamOpenHarmony();
		string currentFontName = KuroSdkModel.Instance.GetCurrentFontName();
		string fontPath = "Font/" + KuroSdkModel.Instance.GetDeviceFontAsset();
		setFontParamOpenHarmony.fontName = currentFontName;
		setFontParamOpenHarmony.fontPath = fontPath;
		string text = JsonSerializer.Serialize<SetFontParamOpenHarmony>(setFontParamOpenHarmony, KuroSdkJsonOptions.Unescaped);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SetFont";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.SetFont(text);
	}

	// Token: 0x06002CAD RID: 11437 RVA: 0x0010A548 File Offset: 0x00108748
	protected override string GetCustomServerExtendsInfo()
	{
		return JsonSerializer.Serialize<OpenCustomerServiceExtendsInfoData[]>(new OpenCustomerServiceExtendsInfoData[]
		{
			new OpenCustomerServiceExtendsInfoData
			{
				key = "version",
				label = "version",
				value = BaseConfigController.Instance.GetP4Version()
			}
		}, KuroSdkJsonOptions.Unescaped);
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x0010A598 File Offset: 0x00108798
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		OpenCustomerServiceParamOpenHarmony openCustomerServiceParamOpenHarmony = new OpenCustomerServiceParamOpenHarmony();
		openCustomerServiceParamOpenHarmony.IsLogin = (instance.IsSdkLoggedIn() ? "1" : "0");
		int num = (int)fromType;
		openCustomerServiceParamOpenHarmony.FromLogin = num.ToString();
		openCustomerServiceParamOpenHarmony.RoleId = this.GetCustomServerRoleId();
		openCustomerServiceParamOpenHarmony.ServerId = (instance.GetServerId() ?? "");
		openCustomerServiceParamOpenHarmony.IsLandscape = "1";
		openCustomerServiceParamOpenHarmony.ExtendsInfo = (Json.Parse<OpenCustomerServiceExtendsInfoData[]>(this.GetCustomServerExtendsInfo(), null) ?? Array.Empty<OpenCustomerServiceExtendsInfoData>());
		UKuroSDKManager.OpenCustomerService(JsonSerializer.Serialize<OpenCustomerServiceParamOpenHarmony>(openCustomerServiceParamOpenHarmony, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x06002CAF RID: 11439 RVA: 0x0010A630 File Offset: 0x00108830
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			AndroidSdkPayRole sdkPayRoleInfo = this.GetSdkPayRoleInfo();
			string paymentInfo2 = this.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
			UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroPay;
			UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, paymentInfo2);
		}
	}

	// Token: 0x06002CB0 RID: 11440 RVA: 0x0010A664 File Offset: 0x00108864
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

	// Token: 0x06002CB1 RID: 11441 RVA: 0x0010A6AC File Offset: 0x001088AC
	public string GetCreateRoleInfo()
	{
		LoginModel instance = LoginModel.Instance;
		RoleInfoSdk roleInfoSdk = new RoleInfoSdk();
		roleInfoSdk.RoleId = this.GetRoleId();
		roleInfoSdk.RoleName = (instance.GetPlayerName() ?? "");
		roleInfoSdk.ServerId = (instance.GetServerId() ?? "");
		roleInfoSdk.ServerName = (instance.GetServerName() ?? "");
		roleInfoSdk.RoleLevel = "1";
		roleInfoSdk.VipLevel = "0";
		roleInfoSdk.PartyName = " ";
		double createPlayerTime = instance.GetCreatePlayerTime();
		roleInfoSdk.RoleCreateTime = ((createPlayerTime != 0.0) ? createPlayerTime.ToString() : "0");
		roleInfoSdk.BalanceLevelOne = "0";
		roleInfoSdk.BalanceLevelTwo = "0";
		roleInfoSdk.SumPay = "0";
		roleInfoSdk.gameName = "AKI";
		roleInfoSdk.gameVersion = "0.0.0";
		roleInfoSdk.RoleAvatar = "";
		SdkLoginConfig sdkLoginConfig = instance.GetSdkLoginConfig();
		roleInfoSdk.ChannelUserId = (((sdkLoginConfig != null) ? sdkLoginConfig.Uid.ToString() : null) ?? "0");
		SdkLoginConfig sdkLoginConfig2 = instance.GetSdkLoginConfig();
		roleInfoSdk.GameUserId = (((sdkLoginConfig2 != null) ? sdkLoginConfig2.UserName.ToString() : null) ?? "0");
		return JsonSerializer.Serialize<RoleInfoSdk>(roleInfoSdk, KuroSdkJsonOptions.Unescaped) ?? "";
	}

	// Token: 0x06002CB2 RID: 11442 RVA: 0x0010A7F8 File Offset: 0x001089F8
	private AndroidSdkPayRole GetSdkPayRoleInfo()
	{
		FunctionModel instance = FunctionModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		AndroidSdkPayRole androidSdkPayRole = new AndroidSdkPayRole();
		androidSdkPayRole.roleId = this.GetRoleId();
		androidSdkPayRole.roleName = (instance.GetPlayerName() ?? "");
		int? playerLevel = instance.GetPlayerLevel();
		androidSdkPayRole.roleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1");
		androidSdkPayRole.serverId = (instance2.GetServerId() ?? "");
		androidSdkPayRole.serverName = (instance2.GetServerName() ?? "");
		androidSdkPayRole.vipLevel = "0";
		androidSdkPayRole.partyName = " ";
		androidSdkPayRole.setBalanceLevelOne = "0";
		androidSdkPayRole.setBalanceLevelTwo = "0";
		return androidSdkPayRole;
	}

	// Token: 0x06002CB3 RID: 11443 RVA: 0x0010A8C4 File Offset: 0x00108AC4
	private string GetPaymentInfo(ISDKPayment payment, AndroidSdkPayRole roleInfo)
	{
		PayInfoAndroid payInfoAndroid = new PayInfoAndroid();
		payInfoAndroid.cpOrderId = payment.cpOrderId.ToString();
		string callbackUrl = payment.callbackUrl;
		payInfoAndroid.callbackUrl = (((callbackUrl != null) ? callbackUrl.ToString() : null) ?? "");
		payInfoAndroid.product_id = payment.product_id.ToString();
		payInfoAndroid.goodsName = payment.goodsName.ToString();
		payInfoAndroid.goodsDesc = payment.goodsDesc.ToString();
		payInfoAndroid.currency = payment.currency.ToString();
		string extraParams = payment.extraParams;
		payInfoAndroid.extraParams = ((extraParams != null) ? extraParams.ToString() : null);
		string text = JsonSerializer.Serialize<PayInfoAndroid>(payInfoAndroid, KuroSdkJsonOptions.Unescaped);
		text = text.Replace("}", ",");
		text += StringUtils.Format("\"price\":{0}", new string[]
		{
			payment.price.ToString()
		});
		text += "}";
		string text2 = JsonSerializer.Serialize<AndroidSdkPayRole>(roleInfo, KuroSdkJsonOptions.Unescaped);
		string text3 = StringUtils.Format("{\"RoleInfo\":{0},\"OrderInfo\":{1}}", new string[]
		{
			text2,
			text
		});
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SdkJson";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text3);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return text3 ?? "";
	}

	// Token: 0x06002CB4 RID: 11444 RVA: 0x0010AA08 File Offset: 0x00108C08
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002CB5 RID: 11445 RVA: 0x0010AA24 File Offset: 0x00108C24
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002CB6 RID: 11446 RVA: 0x0010AA40 File Offset: 0x00108C40
	protected override void OnShareResult(int code, string platform, string msg)
	{
		if (code == 0)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x04002956 RID: 10582
	private const int WEBVIEWCD = 5000;

	// Token: 0x04002957 RID: 10583
	private const int GETINFODELAY = 10000;

	// Token: 0x04002958 RID: 10584
	[Nullable(2)]
	private OpenHarmonySdkParam SdkParamCache;
}
