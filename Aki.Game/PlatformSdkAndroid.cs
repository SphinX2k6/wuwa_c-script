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

// Token: 0x02000E49 RID: 3657
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkAndroid : PlatformSdkBase
{
	// Token: 0x060057FA RID: 22522 RVA: 0x000FDC5C File Offset: 0x000FBE5C
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(new Action<string>(this.AnnounceRedPointCallBack));
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x060057FB RID: 22523 RVA: 0x000FDCBD File Offset: 0x000FBEBD
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

	// Token: 0x060057FC RID: 22524 RVA: 0x000FDCF0 File Offset: 0x000FBEF0
	public void AnnounceRedPointCallBack(string result)
	{
		AndroidSdkRePointSt androidSdkRePointSt = Json.Parse<AndroidSdkRePointSt>(result, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(androidSdkRePointSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x060057FD RID: 22525 RVA: 0x000FDD28 File Offset: 0x000FBF28
	public void CustomerServiceResultCallBack(string result)
	{
		string[] array = result.Split(',', StringSplitOptions.None);
		if (array != null && array.Length > 1)
		{
			this.CurrentCustomerShowState = (int.Parse(array[1]) > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x060057FE RID: 22526 RVA: 0x000FDD6C File Offset: 0x000FBF6C
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

	// Token: 0x060057FF RID: 22527 RVA: 0x000FDE38 File Offset: 0x000FC038
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

	// Token: 0x06005800 RID: 22528 RVA: 0x000FDE84 File Offset: 0x000FC084
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

	// Token: 0x06005801 RID: 22529 RVA: 0x000FDF4C File Offset: 0x000FC14C
	private string GetSdkParamData(string needParam)
	{
		if (this.SdkParamCacheMap.Count == 0)
		{
			string[] array = UKuroSDKManager.GetSdkParams("").Split(',', StringSplitOptions.None);
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string[] array2 = array[i].Split('=', StringSplitOptions.None);
				if (array2.Length == 2)
				{
					this.SdkParamCacheMap[array2[0]] = array2[1];
				}
			}
		}
		string text;
		if (this.SdkParamCacheMap.TryGetValue(needParam, out text) && text != null && !StringUtils.IsEmpty(text))
		{
			return text;
		}
		return "";
	}

	// Token: 0x06005802 RID: 22530 RVA: 0x000FDFD2 File Offset: 0x000FC1D2
	public override string GetChannelId()
	{
		return this.GetSdkParamData("channelId");
	}

	// Token: 0x06005803 RID: 22531 RVA: 0x000FDFDF File Offset: 0x000FC1DF
	public override string GetGameId()
	{
		return this.GetSdkParamData("gameId");
	}

	// Token: 0x06005804 RID: 22532 RVA: 0x000FDFEC File Offset: 0x000FC1EC
	public override string GetChannelName()
	{
		return this.GetSdkParamData("channelName");
	}

	// Token: 0x06005805 RID: 22533 RVA: 0x000FDFF9 File Offset: 0x000FC1F9
	public override string GetDid()
	{
		return this.GetSdkParamData("did");
	}

	// Token: 0x06005806 RID: 22534 RVA: 0x000FE006 File Offset: 0x000FC206
	public override string GetAppChannelId()
	{
		return this.GetSdkParamData("appChannelId");
	}

	// Token: 0x06005807 RID: 22535 RVA: 0x000FE013 File Offset: 0x000FC213
	public override string GetOaid()
	{
		return this.GetSdkParamData("oaid");
	}

	// Token: 0x06005808 RID: 22536 RVA: 0x000FE020 File Offset: 0x000FC220
	public override string GetJyDid()
	{
		return this.GetSdkParamData("jyDid");
	}

	// Token: 0x06005809 RID: 22537 RVA: 0x000FE02D File Offset: 0x000FC22D
	public override string GetAccessToken()
	{
		return this.GetSdkParamData("accessToken");
	}

	// Token: 0x0600580A RID: 22538 RVA: 0x000FE03C File Offset: 0x000FC23C
	public override void SetFont()
	{
		SetFontParamAndroid setFontParamAndroid = new SetFontParamAndroid();
		setFontParamAndroid.fontType = "1";
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		setFontParamAndroid.fontPath = deviceFontAsset;
		string text = JsonSerializer.Serialize<SetFontParamAndroid>(setFontParamAndroid, KuroSdkJsonOptions.Unescaped);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SetFont";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.SetFont(text);
	}

	// Token: 0x0600580B RID: 22539 RVA: 0x000FE0A4 File Offset: 0x000FC2A4
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		OpenCustomerServiceParamAndroid openCustomerServiceParamAndroid = new OpenCustomerServiceParamAndroid();
		openCustomerServiceParamAndroid.IsLogin = (instance.IsSdkLoggedIn() ? "1" : "0");
		int num = (int)fromType;
		openCustomerServiceParamAndroid.FromLogin = num.ToString();
		openCustomerServiceParamAndroid.RoleId = this.GetCustomServerRoleId();
		openCustomerServiceParamAndroid.ServerId = (instance.GetServerId() ?? "");
		openCustomerServiceParamAndroid.IsLandscape = "0";
		openCustomerServiceParamAndroid.ExtendsInfo = this.GetCustomServerExtendsInfo();
		UKuroSDKManager.OpenCustomerService(JsonSerializer.Serialize<OpenCustomerServiceParamAndroid>(openCustomerServiceParamAndroid, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x0600580C RID: 22540 RVA: 0x000FE12C File Offset: 0x000FC32C
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

	// Token: 0x0600580D RID: 22541 RVA: 0x000FE160 File Offset: 0x000FC360
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

	// Token: 0x0600580E RID: 22542 RVA: 0x000FE1A8 File Offset: 0x000FC3A8
	public string GetCreateRoleInfo()
	{
		LoginModel instance = LoginModel.Instance;
		RoleInfoSdk roleInfoSdk = new RoleInfoSdk();
		roleInfoSdk.RoleId = this.GetRoleId();
		roleInfoSdk.RoleName = ((instance.GetPlayerName() != null) ? instance.GetPlayerName() : "");
		roleInfoSdk.ServerId = ((instance.GetServerId() != null) ? instance.GetServerId() : "");
		roleInfoSdk.ServerName = ((instance.GetServerName() != null) ? instance.GetServerName() : "");
		roleInfoSdk.RoleLevel = "1";
		roleInfoSdk.VipLevel = "0";
		roleInfoSdk.PartyName = " ";
		roleInfoSdk.RoleCreateTime = instance.GetCreatePlayerTime().ToString();
		roleInfoSdk.BalanceLevelOne = "0";
		roleInfoSdk.BalanceLevelTwo = "0";
		roleInfoSdk.SumPay = "0";
		roleInfoSdk.gameName = "AKI";
		roleInfoSdk.gameVersion = "0.0.0";
		roleInfoSdk.RoleAvatar = "";
		SdkLoginConfig sdkLoginConfig = instance.GetSdkLoginConfig();
		roleInfoSdk.ChannelUserId = ((((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) != null) ? instance.GetSdkLoginConfig().Uid.ToString() : "0");
		SdkLoginConfig sdkLoginConfig2 = instance.GetSdkLoginConfig();
		roleInfoSdk.GameUserId = ((((sdkLoginConfig2 != null) ? sdkLoginConfig2.UserName : null) != null) ? instance.GetSdkLoginConfig().UserName.ToString() : "0");
		return JsonSerializer.Serialize<RoleInfoSdk>(roleInfoSdk, KuroSdkJsonOptions.Unescaped) ?? "";
	}

	// Token: 0x0600580F RID: 22543 RVA: 0x000FE30C File Offset: 0x000FC50C
	private AndroidSdkPayRole GetSdkPayRoleInfo()
	{
		FunctionModel instance = FunctionModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		AndroidSdkPayRole androidSdkPayRole = new AndroidSdkPayRole();
		androidSdkPayRole.roleId = this.GetRoleId();
		androidSdkPayRole.roleName = ((instance.GetPlayerName() != null) ? instance.GetPlayerName() : "");
		int? playerLevel = instance.GetPlayerLevel();
		androidSdkPayRole.roleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1");
		androidSdkPayRole.serverId = ((instance2.GetServerId() != null) ? instance2.GetServerId() : "");
		androidSdkPayRole.serverName = ((instance2.GetServerName() != null) ? instance2.GetServerName() : "");
		androidSdkPayRole.vipLevel = "0";
		androidSdkPayRole.partyName = " ";
		androidSdkPayRole.setBalanceLevelOne = "0";
		androidSdkPayRole.setBalanceLevelTwo = "0";
		return androidSdkPayRole;
	}

	// Token: 0x06005810 RID: 22544 RVA: 0x000FE3E8 File Offset: 0x000FC5E8
	private string GetPaymentInfo(ISDKPayment payment, AndroidSdkPayRole roleInfo)
	{
		PayInfoAndroid payInfoAndroid = new PayInfoAndroid();
		payInfoAndroid.cpOrderId = payment.cpOrderId.ToString();
		payInfoAndroid.callbackUrl = payment.callbackUrl.ToString();
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

	// Token: 0x06005811 RID: 22545 RVA: 0x000FE51C File Offset: 0x000FC71C
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x06005812 RID: 22546 RVA: 0x000FE538 File Offset: 0x000FC738
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x06005813 RID: 22547 RVA: 0x000FE554 File Offset: 0x000FC754
	protected override void OnShareResult(int code, string platform, string msg)
	{
		if (code == 0)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x04002881 RID: 10369
	private const int WEBVIEWCD = 5000;

	// Token: 0x04002882 RID: 10370
	private const int GETINFODELAY = 10000;

	// Token: 0x04002883 RID: 10371
	private readonly Dictionary<string, string> SdkParamCacheMap = new Dictionary<string, string>();
}
