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

// Token: 0x02000E4A RID: 3658
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkAndroidGlobal : PlatformSdkBase
{
	// Token: 0x06005816 RID: 22550 RVA: 0x000FE5F0 File Offset: 0x000FC7F0
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(new Action<string>(this.AnnounceRedPointCallBack));
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06005817 RID: 22551 RVA: 0x000FE651 File Offset: 0x000FC851
	protected override void OnInit()
	{
		UKuroSDKManager.GetBasicInfo().bIsValid = false;
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
			FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
			FCrashSightProxy.SetCustomData("SdkJyId", this.GetJyDid());
			FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
		}, 10000f, null, null, true, 1f);
	}

	// Token: 0x06005818 RID: 22552 RVA: 0x000FE684 File Offset: 0x000FC884
	public void AnnounceRedPointCallBack(string result)
	{
		PlatformSdkAndroidGlobal.AndroidSdkRePointSt androidSdkRePointSt = Json.Parse<PlatformSdkAndroidGlobal.AndroidSdkRePointSt>(result, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(androidSdkRePointSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06005819 RID: 22553 RVA: 0x000FE6BC File Offset: 0x000FC8BC
	public void CustomerServiceResultCallBack(string result)
	{
		string[] array = result.Split(',', StringSplitOptions.None);
		if (array != null && array.Length > 1)
		{
			this.CurrentCustomerShowState = (int.Parse(array[1]) > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x0600581A RID: 22554 RVA: 0x000FE700 File Offset: 0x000FC900
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

	// Token: 0x0600581B RID: 22555 RVA: 0x000FE7CC File Offset: 0x000FC9CC
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

	// Token: 0x0600581C RID: 22556 RVA: 0x000FE818 File Offset: 0x000FCA18
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

	// Token: 0x0600581D RID: 22557 RVA: 0x000FE8E0 File Offset: 0x000FCAE0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected override QueryProductSt[] OnQueryProduct(string str)
	{
		string[] array = str.Split('|', StringSplitOptions.None);
		List<QueryProductSt> list = new List<QueryProductSt>();
		if (array != null && array.Length > 1 && array[0] == "success")
		{
			PlatformSdkAndroidGlobal.IQueryProduct[] array2 = Json.Parse<PlatformSdkAndroidGlobal.IQueryProduct[]>(array[1], null);
			if (array2 != null)
			{
				foreach (PlatformSdkAndroidGlobal.IQueryProduct queryProduct in array2)
				{
					list.Add(new QueryProductSt
					{
						Currency = queryProduct.currency,
						GoodId = queryProduct.goodsId,
						Name = queryProduct.name,
						Desc = queryProduct.desc,
						Price = new float?(queryProduct.price)
					});
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600581E RID: 22558 RVA: 0x000FE9A8 File Offset: 0x000FCBA8
	protected override void OnGetSharePlatform(string str)
	{
		PlatformSdkAndroidGlobal.SharePlatform[] array = Json.Parse<PlatformSdkAndroidGlobal.SharePlatform[]>(Json.Parse<PlatformSdkAndroidGlobal.ISharePlatformSt>(str, null).data, null);
		List<SharePlatformSt> shareResult = new List<SharePlatformSt>();
		if (array != null)
		{
			foreach (PlatformSdkAndroidGlobal.SharePlatform sharePlatform in array)
			{
				SharePlatformSt sharePlatformSt = new SharePlatformSt();
				sharePlatformSt.IconUrl = sharePlatform.iconUrl;
				sharePlatformSt.PlatformId = sharePlatform.platform.ToString();
				shareResult.Add(sharePlatformSt);
			}
		}
		this.GetSharePlatformCallBackList.ForEach(delegate(Action<SharePlatformSt[]> value)
		{
			value(shareResult.ToArray());
		});
		this.GetSharePlatformCallBackList.Clear();
		base.OnGetSharePlatform(str);
	}

	// Token: 0x0600581F RID: 22559 RVA: 0x000FEA54 File Offset: 0x000FCC54
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

	// Token: 0x06005820 RID: 22560 RVA: 0x000FEADA File Offset: 0x000FCCDA
	public override string GetChannelId()
	{
		return this.GetSdkParamData("channelId");
	}

	// Token: 0x06005821 RID: 22561 RVA: 0x000FEAE7 File Offset: 0x000FCCE7
	public override string GetChannelName()
	{
		return this.GetSdkParamData("channelName");
	}

	// Token: 0x06005822 RID: 22562 RVA: 0x000FEAF4 File Offset: 0x000FCCF4
	public override string GetDid()
	{
		return this.GetSdkParamData("did");
	}

	// Token: 0x06005823 RID: 22563 RVA: 0x000FEB01 File Offset: 0x000FCD01
	public override string GetJyDid()
	{
		return this.GetSdkParamData("jyDid");
	}

	// Token: 0x06005824 RID: 22564 RVA: 0x000FEB0E File Offset: 0x000FCD0E
	public override string GetAccessToken()
	{
		return this.GetSdkParamData("accessToken");
	}

	// Token: 0x06005825 RID: 22565 RVA: 0x000FEB1C File Offset: 0x000FCD1C
	public override void SetFont()
	{
		SetFontParamAndroid setFontParamAndroid = new SetFontParamAndroid();
		setFontParamAndroid.fontType = "1";
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		setFontParamAndroid.fontPath = deviceFontAsset;
		UKuroSDKManager.SetFont(JsonSerializer.Serialize<SetFontParamAndroid>(setFontParamAndroid, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x06005826 RID: 22566 RVA: 0x000FEB5C File Offset: 0x000FCD5C
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

	// Token: 0x06005827 RID: 22567 RVA: 0x000FEBE4 File Offset: 0x000FCDE4
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
		UKuroSDKManager.QueryProductInfo(Json.Stringify<QueryProductInfoParamAndroid>(new QueryProductInfoParamAndroid
		{
			GoodIdList = text,
			ChannelId = channelId
		}, null));
	}

	// Token: 0x06005828 RID: 22568 RVA: 0x000FEC44 File Offset: 0x000FCE44
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

	// Token: 0x06005829 RID: 22569 RVA: 0x000FEC78 File Offset: 0x000FCE78
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

	// Token: 0x0600582A RID: 22570 RVA: 0x000FECC0 File Offset: 0x000FCEC0
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

	// Token: 0x0600582B RID: 22571 RVA: 0x000FEE10 File Offset: 0x000FD010
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

	// Token: 0x0600582C RID: 22572 RVA: 0x000FEEEC File Offset: 0x000FD0EC
	private string GetPaymentInfo(ISDKPayment payment, AndroidSdkPayRole roleInfo)
	{
		string text = JsonSerializer.Serialize<PayInfoAndroid>(new PayInfoAndroid
		{
			cpOrderId = payment.cpOrderId.ToString(),
			callbackUrl = payment.callbackUrl.ToString(),
			product_id = payment.product_id.ToString(),
			goodsName = payment.goodsName.ToString(),
			goodsDesc = payment.goodsDesc.ToString(),
			currency = "USD",
			extraParams = roleInfo.roleId.ToString()
		}, KuroSdkJsonOptions.Unescaped);
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

	// Token: 0x0600582D RID: 22573 RVA: 0x000FF014 File Offset: 0x000FD214
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x0600582E RID: 22574 RVA: 0x000FF030 File Offset: 0x000FD230
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x0600582F RID: 22575 RVA: 0x000FF04C File Offset: 0x000FD24C
	protected override void OnShareResult(int code, string platform, string msg)
	{
		if (code == 0)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x06005830 RID: 22576 RVA: 0x000FF074 File Offset: 0x000FD274
	protected override int CurrentPlatformYearReviewTime()
	{
		return 1;
	}

	// Token: 0x04002884 RID: 10372
	private const int WEBVIEWCD = 5000;

	// Token: 0x04002885 RID: 10373
	private const int GETINFODELAY = 10000;

	// Token: 0x04002886 RID: 10374
	private const int MAXREVIEWTIME = 1;

	// Token: 0x04002887 RID: 10375
	private readonly Dictionary<string, string> SdkParamCacheMap = new Dictionary<string, string>();

	// Token: 0x020074B6 RID: 29878
	[NullableContext(0)]
	private class AndroidSdkRePointSt
	{
		// Token: 0x04026B0A RID: 158474
		public bool showRed;
	}

	// Token: 0x020074B7 RID: 29879
	[Nullable(0)]
	private class IQueryProduct
	{
		// Token: 0x17009FD2 RID: 40914
		// (get) Token: 0x06048A1D RID: 297501 RVA: 0x012B4263 File Offset: 0x012B2463
		// (set) Token: 0x06048A1E RID: 297502 RVA: 0x012B426B File Offset: 0x012B246B
		public string goodsId { get; set; }

		// Token: 0x17009FD3 RID: 40915
		// (get) Token: 0x06048A1F RID: 297503 RVA: 0x012B4274 File Offset: 0x012B2474
		// (set) Token: 0x06048A20 RID: 297504 RVA: 0x012B427C File Offset: 0x012B247C
		public string name { get; set; }

		// Token: 0x17009FD4 RID: 40916
		// (get) Token: 0x06048A21 RID: 297505 RVA: 0x012B4285 File Offset: 0x012B2485
		// (set) Token: 0x06048A22 RID: 297506 RVA: 0x012B428D File Offset: 0x012B248D
		public string desc { get; set; }

		// Token: 0x17009FD5 RID: 40917
		// (get) Token: 0x06048A23 RID: 297507 RVA: 0x012B4296 File Offset: 0x012B2496
		// (set) Token: 0x06048A24 RID: 297508 RVA: 0x012B429E File Offset: 0x012B249E
		public string currency { get; set; }

		// Token: 0x17009FD6 RID: 40918
		// (get) Token: 0x06048A25 RID: 297509 RVA: 0x012B42A7 File Offset: 0x012B24A7
		// (set) Token: 0x06048A26 RID: 297510 RVA: 0x012B42AF File Offset: 0x012B24AF
		public float price { get; set; }
	}

	// Token: 0x020074B8 RID: 29880
	[NullableContext(0)]
	private class ISharePlatformSt
	{
		// Token: 0x04026B10 RID: 158480
		[Nullable(1)]
		public string data = "";
	}

	// Token: 0x020074B9 RID: 29881
	private interface ISharePlatform
	{
		// Token: 0x17009FD7 RID: 40919
		// (get) Token: 0x06048A29 RID: 297513
		// (set) Token: 0x06048A2A RID: 297514
		int platform { get; set; }

		// Token: 0x17009FD8 RID: 40920
		// (get) Token: 0x06048A2B RID: 297515
		// (set) Token: 0x06048A2C RID: 297516
		string iconUrl { get; set; }
	}

	// Token: 0x020074BA RID: 29882
	[Nullable(0)]
	private class SharePlatform : PlatformSdkAndroidGlobal.ISharePlatform
	{
		// Token: 0x17009FD9 RID: 40921
		// (get) Token: 0x06048A2D RID: 297517 RVA: 0x012B42D3 File Offset: 0x012B24D3
		// (set) Token: 0x06048A2E RID: 297518 RVA: 0x012B42DB File Offset: 0x012B24DB
		public int platform { get; set; }

		// Token: 0x17009FDA RID: 40922
		// (get) Token: 0x06048A2F RID: 297519 RVA: 0x012B42E4 File Offset: 0x012B24E4
		// (set) Token: 0x06048A30 RID: 297520 RVA: 0x012B42EC File Offset: 0x012B24EC
		public string iconUrl { get; set; }
	}
}
