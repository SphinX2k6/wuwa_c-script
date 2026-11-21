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

// Token: 0x020002FF RID: 767
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkAndroidGlobal : PlatformSdkBase
{
	// Token: 0x06002BA6 RID: 11174 RVA: 0x00105EE0 File Offset: 0x001040E0
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(new Action<string>(this.AnnounceRedPointCallBack));
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x00105F41 File Offset: 0x00104141
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

	// Token: 0x06002BA8 RID: 11176 RVA: 0x00105F74 File Offset: 0x00104174
	public void AnnounceRedPointCallBack(string result)
	{
		PlatformSdkAndroidGlobal.AndroidSdkRePointSt androidSdkRePointSt = Json.Parse<PlatformSdkAndroidGlobal.AndroidSdkRePointSt>(result, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(androidSdkRePointSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06002BA9 RID: 11177 RVA: 0x00105FAC File Offset: 0x001041AC
	public void CustomerServiceResultCallBack(string result)
	{
		string[] array = result.Split(',', StringSplitOptions.None);
		if (array != null && array.Length > 1)
		{
			this.CurrentCustomerShowState = (int.Parse(array[1]) > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002BAA RID: 11178 RVA: 0x00105FF0 File Offset: 0x001041F0
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

	// Token: 0x06002BAB RID: 11179 RVA: 0x001060BC File Offset: 0x001042BC
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

	// Token: 0x06002BAC RID: 11180 RVA: 0x00106108 File Offset: 0x00104308
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

	// Token: 0x06002BAD RID: 11181 RVA: 0x001061D0 File Offset: 0x001043D0
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

	// Token: 0x06002BAE RID: 11182 RVA: 0x00106298 File Offset: 0x00104498
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

	// Token: 0x06002BAF RID: 11183 RVA: 0x00106344 File Offset: 0x00104544
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

	// Token: 0x06002BB0 RID: 11184 RVA: 0x001063CA File Offset: 0x001045CA
	public override string GetChannelId()
	{
		return this.GetSdkParamData("channelId");
	}

	// Token: 0x06002BB1 RID: 11185 RVA: 0x001063D7 File Offset: 0x001045D7
	public override string GetChannelName()
	{
		return this.GetSdkParamData("channelName");
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x001063E4 File Offset: 0x001045E4
	public override string GetDid()
	{
		return this.GetSdkParamData("did");
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x001063F1 File Offset: 0x001045F1
	public override string GetJyDid()
	{
		return this.GetSdkParamData("jyDid");
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x001063FE File Offset: 0x001045FE
	public override string GetAccessToken()
	{
		return this.GetSdkParamData("accessToken");
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x0010640C File Offset: 0x0010460C
	public override void SetFont()
	{
		SetFontParamAndroid setFontParamAndroid = new SetFontParamAndroid();
		setFontParamAndroid.fontType = "1";
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		setFontParamAndroid.fontPath = deviceFontAsset;
		UKuroSDKManager.SetFont(JsonSerializer.Serialize<SetFontParamAndroid>(setFontParamAndroid, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x0010644C File Offset: 0x0010464C
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

	// Token: 0x06002BB7 RID: 11191 RVA: 0x001064D4 File Offset: 0x001046D4
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
		UKuroSDKManager.QueryProductInfo(Json.Stringify(new QueryProductInfoParamAndroid
		{
			GoodIdList = text,
			ChannelId = channelId
		}, null));
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x00106534 File Offset: 0x00104734
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

	// Token: 0x06002BB9 RID: 11193 RVA: 0x00106568 File Offset: 0x00104768
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

	// Token: 0x06002BBA RID: 11194 RVA: 0x001065B0 File Offset: 0x001047B0
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

	// Token: 0x06002BBB RID: 11195 RVA: 0x00106700 File Offset: 0x00104900
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

	// Token: 0x06002BBC RID: 11196 RVA: 0x001067DC File Offset: 0x001049DC
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

	// Token: 0x06002BBD RID: 11197 RVA: 0x00106904 File Offset: 0x00104B04
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002BBE RID: 11198 RVA: 0x00106920 File Offset: 0x00104B20
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002BBF RID: 11199 RVA: 0x0010693C File Offset: 0x00104B3C
	protected override void OnShareResult(int code, string platform, string msg)
	{
		if (code == 0)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x06002BC0 RID: 11200 RVA: 0x00106964 File Offset: 0x00104B64
	protected override int CurrentPlatformYearReviewTime()
	{
		return 1;
	}

	// Token: 0x06002BC1 RID: 11201 RVA: 0x00106968 File Offset: 0x00104B68
	public override void UnlockSdkTrophy(string id)
	{
		UKuroSDKManager.CallPlugin(Json.Stringify(new GPUnlockAchievementData
		{
			func = "unlock",
			@params = new GPUnlockAchievementDataParams
			{
				achievement = id
			}
		}, null));
	}

	// Token: 0x06002BC2 RID: 11202 RVA: 0x001069A8 File Offset: 0x00104BA8
	public override void RecordEvents(List<SdkEventData> events)
	{
		if (events.Count == 0)
		{
			Log.Instance.Warn(ELogModule.KuroSdk, ELogAuthor.YZY, "游戏统计事件无效，取消整批上报 events.Count", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		PlatformSdkAndroidGlobal.GooglePlayRecordEventsRequest googlePlayRecordEventsRequest = new PlatformSdkAndroidGlobal.GooglePlayRecordEventsRequest();
		foreach (SdkEventData sdkEventData in events)
		{
			if (sdkEventData == null || string.IsNullOrWhiteSpace(sdkEventData.EventName) || sdkEventData.Properties == null || sdkEventData.Properties.Count == 0)
			{
				Log.Instance.Warn(ELogModule.KuroSdk, ELogAuthor.YZY, "游戏统计事件无效，取消整批上报", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (KeyValuePair<string, int> keyValuePair in sdkEventData.Properties)
			{
				string text;
				int num;
				keyValuePair.Deconstruct(out text, out num);
				string value = text;
				int num2 = num;
				if (string.IsNullOrWhiteSpace(value) || num2 < 0)
				{
					Log.Instance.Warn(ELogModule.KuroSdk, ELogAuthor.YZY, "游戏统计事件属性无效，取消整批上报", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
			}
			googlePlayRecordEventsRequest.@params.events.Add(new PlatformSdkAndroidGlobal.GooglePlayEventData
			{
				eventName = sdkEventData.EventName,
				properties = new Dictionary<string, int>(sdkEventData.Properties)
			});
		}
		string text2 = Json.Stringify(googlePlayRecordEventsRequest, null);
		if (!string.IsNullOrEmpty(text2))
		{
			UKuroSDKManager.CallPlugin(text2);
			UKuroSDKManager.CallPlugin(Json.Stringify(new PlatformSdkAndroidGlobal.GooglePlayRecordUploadRequest(), null));
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "RecordEvents";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", text2);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0400291D RID: 10525
	private const int WEBVIEWCD = 5000;

	// Token: 0x0400291E RID: 10526
	private const int GETINFODELAY = 10000;

	// Token: 0x0400291F RID: 10527
	private const int MAXREVIEWTIME = 1;

	// Token: 0x04002920 RID: 10528
	private readonly Dictionary<string, string> SdkParamCacheMap = new Dictionary<string, string>();

	// Token: 0x02006646 RID: 26182
	[NullableContext(0)]
	private class AndroidSdkRePointSt
	{
		// Token: 0x04021E49 RID: 138825
		public bool showRed;
	}

	// Token: 0x02006647 RID: 26183
	[Nullable(0)]
	private class IQueryProduct
	{
		// Token: 0x17007770 RID: 30576
		// (get) Token: 0x0603EE79 RID: 257657 RVA: 0x01257517 File Offset: 0x01255717
		// (set) Token: 0x0603EE7A RID: 257658 RVA: 0x0125751F File Offset: 0x0125571F
		public string goodsId { get; set; }

		// Token: 0x17007771 RID: 30577
		// (get) Token: 0x0603EE7B RID: 257659 RVA: 0x01257528 File Offset: 0x01255728
		// (set) Token: 0x0603EE7C RID: 257660 RVA: 0x01257530 File Offset: 0x01255730
		public string name { get; set; }

		// Token: 0x17007772 RID: 30578
		// (get) Token: 0x0603EE7D RID: 257661 RVA: 0x01257539 File Offset: 0x01255739
		// (set) Token: 0x0603EE7E RID: 257662 RVA: 0x01257541 File Offset: 0x01255741
		public string desc { get; set; }

		// Token: 0x17007773 RID: 30579
		// (get) Token: 0x0603EE7F RID: 257663 RVA: 0x0125754A File Offset: 0x0125574A
		// (set) Token: 0x0603EE80 RID: 257664 RVA: 0x01257552 File Offset: 0x01255752
		public string currency { get; set; }

		// Token: 0x17007774 RID: 30580
		// (get) Token: 0x0603EE81 RID: 257665 RVA: 0x0125755B File Offset: 0x0125575B
		// (set) Token: 0x0603EE82 RID: 257666 RVA: 0x01257563 File Offset: 0x01255763
		public float price { get; set; }
	}

	// Token: 0x02006648 RID: 26184
	[NullableContext(0)]
	private class ISharePlatformSt
	{
		// Token: 0x04021E4F RID: 138831
		[Nullable(1)]
		public string data = "";
	}

	// Token: 0x02006649 RID: 26185
	private interface ISharePlatform
	{
		// Token: 0x17007775 RID: 30581
		// (get) Token: 0x0603EE85 RID: 257669
		// (set) Token: 0x0603EE86 RID: 257670
		int platform { get; set; }

		// Token: 0x17007776 RID: 30582
		// (get) Token: 0x0603EE87 RID: 257671
		// (set) Token: 0x0603EE88 RID: 257672
		string iconUrl { get; set; }
	}

	// Token: 0x0200664A RID: 26186
	[Nullable(0)]
	private class SharePlatform : PlatformSdkAndroidGlobal.ISharePlatform
	{
		// Token: 0x17007777 RID: 30583
		// (get) Token: 0x0603EE89 RID: 257673 RVA: 0x01257587 File Offset: 0x01255787
		// (set) Token: 0x0603EE8A RID: 257674 RVA: 0x0125758F File Offset: 0x0125578F
		public int platform { get; set; }

		// Token: 0x17007778 RID: 30584
		// (get) Token: 0x0603EE8B RID: 257675 RVA: 0x01257598 File Offset: 0x01255798
		// (set) Token: 0x0603EE8C RID: 257676 RVA: 0x012575A0 File Offset: 0x012557A0
		public string iconUrl { get; set; }
	}

	// Token: 0x0200664B RID: 26187
	[Nullable(0)]
	private class GooglePlayEventData
	{
		// Token: 0x04021E52 RID: 138834
		public string eventName = "";

		// Token: 0x04021E53 RID: 138835
		public Dictionary<string, int> properties = new Dictionary<string, int>();
	}

	// Token: 0x0200664C RID: 26188
	[NullableContext(0)]
	private class GooglePlayRecordEventsParams
	{
		// Token: 0x04021E54 RID: 138836
		[Nullable(1)]
		public List<PlatformSdkAndroidGlobal.GooglePlayEventData> events = new List<PlatformSdkAndroidGlobal.GooglePlayEventData>();
	}

	// Token: 0x0200664D RID: 26189
	[Nullable(0)]
	private class GooglePlayRecordEventsRequest
	{
		// Token: 0x04021E55 RID: 138837
		public string func = "recordEvents";

		// Token: 0x04021E56 RID: 138838
		public PlatformSdkAndroidGlobal.GooglePlayRecordEventsParams @params = new PlatformSdkAndroidGlobal.GooglePlayRecordEventsParams();
	}

	// Token: 0x0200664E RID: 26190
	[NullableContext(0)]
	private class GooglePlayRecordUploadRequest
	{
		// Token: 0x04021E57 RID: 138839
		[Nullable(1)]
		public string func = "requestEventsUpload";
	}
}
