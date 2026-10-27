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

// Token: 0x02000E54 RID: 3668
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkOpenHarmony : PlatformSdkBase
{
	// Token: 0x06005904 RID: 22788 RVA: 0x001023B8 File Offset: 0x001005B8
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(new Action<string>(this.AnnounceRedPointCallBack));
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x00102419 File Offset: 0x00100619
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

	// Token: 0x06005906 RID: 22790 RVA: 0x0010244C File Offset: 0x0010064C
	public void AnnounceRedPointCallBack(string result)
	{
		AndroidSdkRePointSt androidSdkRePointSt = Json.Parse<AndroidSdkRePointSt>(result, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(androidSdkRePointSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x00102484 File Offset: 0x00100684
	public void CustomerServiceResultCallBack(string result)
	{
		string[] array = result.Split(',', StringSplitOptions.None);
		if (array != null && array.Length > 1)
		{
			this.CurrentCustomerShowState = (int.Parse(array[1]) > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x001024C8 File Offset: 0x001006C8
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

	// Token: 0x06005909 RID: 22793 RVA: 0x00102594 File Offset: 0x00100794
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

	// Token: 0x0600590A RID: 22794 RVA: 0x001025E0 File Offset: 0x001007E0
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

	// Token: 0x0600590B RID: 22795 RVA: 0x001026A6 File Offset: 0x001008A6
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

	// Token: 0x0600590C RID: 22796 RVA: 0x001026C4 File Offset: 0x001008C4
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

	// Token: 0x0600590D RID: 22797 RVA: 0x00102726 File Offset: 0x00100926
	public override string GetChannelId()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.channelId : null) ?? "";
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x00102743 File Offset: 0x00100943
	public override string GetGameId()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.gameId : null) ?? "";
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x00102760 File Offset: 0x00100960
	public override string GetChannelName()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.channelName : null) ?? "";
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x0010277D File Offset: 0x0010097D
	public override string GetDid()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.did : null) ?? "";
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x0010279A File Offset: 0x0010099A
	public override string GetAppChannelId()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.appChannelId : null) ?? "";
	}

	// Token: 0x06005912 RID: 22802 RVA: 0x001027B7 File Offset: 0x001009B7
	public override string GetOaid()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.oaid : null) ?? "";
	}

	// Token: 0x06005913 RID: 22803 RVA: 0x001027D4 File Offset: 0x001009D4
	public override string GetJyDid()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.jyDid : null) ?? "";
	}

	// Token: 0x06005914 RID: 22804 RVA: 0x001027F1 File Offset: 0x001009F1
	public override string GetAccessToken()
	{
		OpenHarmonySdkParam sdkParamCache = this.GetSdkParamCache();
		return ((sdkParamCache != null) ? sdkParamCache.accessToken : null) ?? "";
	}

	// Token: 0x06005915 RID: 22805 RVA: 0x00102810 File Offset: 0x00100A10
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

	// Token: 0x06005916 RID: 22806 RVA: 0x00102888 File Offset: 0x00100A88
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

	// Token: 0x06005917 RID: 22807 RVA: 0x001028D8 File Offset: 0x00100AD8
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

	// Token: 0x06005918 RID: 22808 RVA: 0x00102970 File Offset: 0x00100B70
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

	// Token: 0x06005919 RID: 22809 RVA: 0x001029A4 File Offset: 0x00100BA4
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

	// Token: 0x0600591A RID: 22810 RVA: 0x001029EC File Offset: 0x00100BEC
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

	// Token: 0x0600591B RID: 22811 RVA: 0x00102B38 File Offset: 0x00100D38
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

	// Token: 0x0600591C RID: 22812 RVA: 0x00102C04 File Offset: 0x00100E04
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

	// Token: 0x0600591D RID: 22813 RVA: 0x00102D48 File Offset: 0x00100F48
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x00102D64 File Offset: 0x00100F64
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x0600591F RID: 22815 RVA: 0x00102D80 File Offset: 0x00100F80
	protected override void OnShareResult(int code, string platform, string msg)
	{
		if (code == 0)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x040028BB RID: 10427
	private const int WEBVIEWCD = 5000;

	// Token: 0x040028BC RID: 10428
	private const int GETINFODELAY = 10000;

	// Token: 0x040028BD RID: 10429
	[Nullable(2)]
	private OpenHarmonySdkParam SdkParamCache;
}
