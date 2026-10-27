using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E6A RID: 3690
[NullableContext(1)]
[Nullable(0)]
public class PlatformXSXGlobal : PlatformSdkBase
{
	// Token: 0x0600596C RID: 22892 RVA: 0x001045D4 File Offset: 0x001027D4
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x0600596D RID: 22893 RVA: 0x00104608 File Offset: 0x00102808
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceInitDelegate.Clear();
		UKuroSDKManager.Get().AnnounceInitDelegate.Add(this.OnAnnounceInitCallBack);
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(new Action<string>(this.AnnounceRedPointCallBack));
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
		UKuroSDKManager.Get().OnLoginDelegate.Clear();
		UKuroSDKManager.Get().OnLoginDelegate.Add(new Action<string>(this.OnLoginCallBack));
		this.XboxGameInviteDelegate = DelegateUtils.ToManualReleaseDelegate<FOnXboxInviteReceivedDynamic>(new Action<FXboxInviteInfo>(this.OnXboxGameInvite));
		bool flag = UKuroStaticXSXLibrary.RegisterForXboxGameInviteEventWithCallback(this.XboxGameInviteDelegate);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "RegisterForXboxGameInviteEventWithCallback";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.QueryExternalAchievementDelegate = DelegateUtils.ToManualReleaseDelegate<FOnXboxAchievementsReceived>(new <>A{00000018}<bool, TArray<FXboxAchievementInfo>>(this.OnQueryExternalAchievement));
		UKuroStaticXSXLibrary.RegisterXboxAchievementsCallback(this.QueryExternalAchievementDelegate);
		this.CheckPermissionDelegate = DelegateUtils.ToManualReleaseDelegate<FOnXboxPermissionCheckResult>(new Action<FXboxPermissionCheckResult>(this.OnCheckPermission));
		this.InitXboxToken();
		this.QueryExternalAchievement();
		this.CacheBlockList();
	}

	// Token: 0x0600596E RID: 22894 RVA: 0x00104754 File Offset: 0x00102954
	public void AnnounceRedPointCallBack(string result)
	{
		XSXSdkRedPointContentSt xsxsdkRedPointContentSt = Json.Parse<XSXSdkRedPointContentSt>(Json.Parse<XSXSdkRedPointSt>(result, null).data, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(xsxsdkRedPointContentSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x0600596F RID: 22895 RVA: 0x00104794 File Offset: 0x00102994
	public void OnLoginCallBack(string result)
	{
		this.QueryExternalAchievement();
	}

	// Token: 0x06005970 RID: 22896 RVA: 0x0010479C File Offset: 0x0010299C
	public void CustomerServiceResultCallBack(string result)
	{
		XSXSdkCustomerServiceSt xsxsdkCustomerServiceSt = Json.Parse<XSXSdkCustomerServiceSt>(result, null);
		XSXSdkCustomerServiceContentSt xsxsdkCustomerServiceContentSt = Json.Parse<XSXSdkCustomerServiceContentSt>(xsxsdkCustomerServiceSt.data, null);
		if (xsxsdkCustomerServiceSt != null)
		{
			this.CurrentCustomerShowState = (xsxsdkCustomerServiceContentSt.isreddot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06005971 RID: 22897 RVA: 0x001047E0 File Offset: 0x001029E0
	public override void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier)
	{
		bool titlebar = false;
		if (transparent)
		{
			titlebar = true;
		}
		OpenWebViewParamWindows openWebViewParamWindows = new OpenWebViewParamWindows();
		openWebViewParamWindows.title = title;
		openWebViewParamWindows.url = url;
		openWebViewParamWindows.transparent = transparent;
		openWebViewParamWindows.titlebar = titlebar;
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
		UKuroSDKManager.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier, text);
	}

	// Token: 0x06005972 RID: 22898 RVA: 0x0010488C File Offset: 0x00102A8C
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

	// Token: 0x06005973 RID: 22899 RVA: 0x001048FC File Offset: 0x00102AFC
	public override void SdkExit()
	{
		KuroApplication.ExitWithReason(false, "SdkExit");
	}

	// Token: 0x06005974 RID: 22900 RVA: 0x0010490C File Offset: 0x00102B0C
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

	// Token: 0x06005975 RID: 22901 RVA: 0x001049AC File Offset: 0x00102BAC
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

	// Token: 0x06005976 RID: 22902 RVA: 0x001049DE File Offset: 0x00102BDE
	private string GetPaymentInfo(ISDKPayment payment, ISDKPayRole roleInfo)
	{
		return JsonSerializer.Serialize<PayInfoXSXGlobal>(new PayInfoXSXGlobal
		{
			goodsId = payment.product_id.ToString()
		}, KuroSdkJsonOptions.Unescaped);
	}

	// Token: 0x06005977 RID: 22903 RVA: 0x00104A00 File Offset: 0x00102C00
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

	// Token: 0x06005978 RID: 22904 RVA: 0x00104A54 File Offset: 0x00102C54
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

	// Token: 0x06005979 RID: 22905 RVA: 0x00104A9C File Offset: 0x00102C9C
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

	// Token: 0x0600597A RID: 22906 RVA: 0x00104AE4 File Offset: 0x00102CE4
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

	// Token: 0x0600597B RID: 22907 RVA: 0x00104B2C File Offset: 0x00102D2C
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

	// Token: 0x0600597C RID: 22908 RVA: 0x00104C1C File Offset: 0x00102E1C
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

	// Token: 0x0600597D RID: 22909 RVA: 0x00104D1C File Offset: 0x00102F1C
	public override void OpenUserCenter()
	{
		UKuroSDKManager.BindAccount();
	}

	// Token: 0x0600597E RID: 22910 RVA: 0x00104D24 File Offset: 0x00102F24
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

	// Token: 0x0600597F RID: 22911 RVA: 0x00104D8C File Offset: 0x00102F8C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected override QueryProductSt[] OnQueryProduct(string str)
	{
		XSXSdkQueryProductSt xsxsdkQueryProductSt = Json.Parse<XSXSdkQueryProductSt>(str, null);
		List<QueryProductSt> list = new List<QueryProductSt>();
		if (((xsxsdkQueryProductSt != null) ? xsxsdkQueryProductSt.data : null) != null)
		{
			foreach (XSXSdkProductContentSt xsxsdkProductContentSt in xsxsdkQueryProductSt.data)
			{
				list.Add(new QueryProductSt
				{
					ChannelGoodId = xsxsdkProductContentSt.channelGoodsId,
					Currency = xsxsdkProductContentSt.currency,
					CurrencyCode = xsxsdkProductContentSt.currencyCode,
					GoodId = xsxsdkProductContentSt.goodsId,
					Name = xsxsdkProductContentSt.name,
					Price = new float?(xsxsdkProductContentSt.price)
				});
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005980 RID: 22912 RVA: 0x00104E40 File Offset: 0x00103040
	public override void SetFont()
	{
		SetFontParamWindows setFontParamWindows = new SetFontParamWindows();
		string currentFontName = KuroSdkModel.Instance.GetCurrentFontName();
		setFontParamWindows.name = currentFontName;
		string text = KuroSdkModel.Instance.GetDeviceFontAsset();
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		if (Info.Instance.IsWinGDKPlatform())
		{
			text = UBlueprintPathsLibrary.RootDir() + "Client/Binaries/WinGDK/ThirdParty/KrXboxPcSdk_Global/" + text;
		}
		else
		{
			text = UBlueprintPathsLibrary.RootDir() + "Client/Binaries/XSX/ThirdParty/KrXsxSdk_Global/" + text;
		}
		setFontParamWindows.path = text;
		string text2 = JsonSerializer.Serialize<SetFontParamWindows>(setFontParamWindows, options);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SetFont";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", text2);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.SetFont(text2);
	}

	// Token: 0x06005981 RID: 22913 RVA: 0x00104EF2 File Offset: 0x001030F2
	public override string GetChannelId()
	{
		return UKuroSDKManager.GetSdkParams("channel_id");
	}

	// Token: 0x06005982 RID: 22914 RVA: 0x00104EFE File Offset: 0x001030FE
	public override string GetChannelName()
	{
		return UKuroSDKManager.GetSdkParams("channel_name");
	}

	// Token: 0x06005983 RID: 22915 RVA: 0x00104F0A File Offset: 0x0010310A
	public override string GetGameId()
	{
		return UKuroSDKManager.GetSdkParams("project_id");
	}

	// Token: 0x06005984 RID: 22916 RVA: 0x00104F16 File Offset: 0x00103116
	public override string GetDid()
	{
		return UKuroSDKManager.GetSdkParams("did");
	}

	// Token: 0x06005985 RID: 22917 RVA: 0x00104F22 File Offset: 0x00103122
	public override string GetAccessToken()
	{
		return UKuroSDKManager.GetSdkParams("token");
	}

	// Token: 0x06005986 RID: 22918 RVA: 0x00104F30 File Offset: 0x00103130
	public override void SdkOpenUrlWnd(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true)
	{
		if (this.LastOpenTime != 0.0 && Time.Instance.Now - this.LastOpenTime <= 5000.0)
		{
			GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
			return;
		}
		this.LastOpenTime = Time.Instance.Now;
		this.OpenWebView(title, url, isLandscape, transparent, webAccelerated, "");
	}

	// Token: 0x06005987 RID: 22919 RVA: 0x00104FA1 File Offset: 0x001031A1
	public override bool GetProtocolState()
	{
		return true;
	}

	// Token: 0x06005988 RID: 22920 RVA: 0x00104FA4 File Offset: 0x001031A4
	protected override void OnPaymentCallBack(FPaymentStruct payment, string strResult, Action<bool, string> paymentFunction)
	{
		XSXPaymentSt xsxpaymentSt = Json.Parse<XSXPaymentSt>(strResult, null);
		bool arg = false;
		if (xsxpaymentSt != null && xsxpaymentSt.error == 0)
		{
			arg = true;
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "OnPaymentCallBack Windows Success", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		paymentFunction(arg, strResult);
	}

	// Token: 0x06005989 RID: 22921 RVA: 0x00104FF4 File Offset: 0x001031F4
	private long GetCurrentUserHandle()
	{
		if (this.CurrentUserHandle != 0L)
		{
			return this.CurrentUserHandle;
		}
		long num = 0L;
		UKuroStaticXSXLibrary.GetXboxDefaultUserHandle(ref num);
		this.CurrentUserHandle = num;
		return num;
	}

	// Token: 0x0600598A RID: 22922 RVA: 0x00105024 File Offset: 0x00103224
	public override string GetThirdUserId()
	{
		return UKuroStaticXSXLibrary.GetXboxUserId(this.GetCurrentUserHandle()).UserId.ToString();
	}

	// Token: 0x0600598B RID: 22923 RVA: 0x00105049 File Offset: 0x00103249
	public override string GetOnlineId()
	{
		return UKuroStaticXSXLibrary.GetXboxGamertagForDisplay(this.GetCurrentUserHandle(), EXboxGamertagComponent.Classic).Gamertag;
	}

	// Token: 0x0600598C RID: 22924 RVA: 0x0010505C File Offset: 0x0010325C
	public override void OpenProfileCard(string xuid)
	{
		UKuroStaticXSXLibrary.ShowXboxPlayerProfileCard(this.GetCurrentUserHandle(), long.Parse(xuid));
	}

	// Token: 0x0600598D RID: 22925 RVA: 0x00105070 File Offset: 0x00103270
	private void CacheBlockList()
	{
		Action<FXboxAvoidListResult> callback = null;
		callback = delegate(FXboxAvoidListResult result)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "CacheBlockList";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			DelegateUtils.ReleaseManualReleaseDelegate(callback);
			int num = result.Xuids.Num();
			for (int i = 0; i < num; i++)
			{
				long num2 = result.Xuids.Get(i);
				this.BlockMap.TryAdd(num2.ToString(), true);
			}
		};
		FOnXboxAvoidListResult callback2 = DelegateUtils.ToManualReleaseDelegate<FOnXboxAvoidListResult>(callback);
		UKuroStaticXSXLibrary.GetXboxAvoidListAsync(this.GetCurrentUserHandle(), callback2);
	}

	// Token: 0x0600598E RID: 22926 RVA: 0x001050B9 File Offset: 0x001032B9
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public override UniTask<Dictionary<string, bool>> GetSdkBlockingUser()
	{
		return UniTask.FromResult<Dictionary<string, bool>>(this.BlockMap);
	}

	// Token: 0x0600598F RID: 22927 RVA: 0x001050C6 File Offset: 0x001032C6
	public override bool NeedCheckPlayOnly()
	{
		return true;
	}

	// Token: 0x06005990 RID: 22928 RVA: 0x001050C9 File Offset: 0x001032C9
	public override bool GetSdkFriendOnlyState()
	{
		return LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, false);
	}

	// Token: 0x06005991 RID: 22929 RVA: 0x001050D7 File Offset: 0x001032D7
	public override void SaveSdkFriendOnlyState(bool state)
	{
		LauncherStorageLib.Instance.SetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, state);
	}

	// Token: 0x06005992 RID: 22930 RVA: 0x001050E6 File Offset: 0x001032E6
	public override bool SupportSwitchFriendShowType()
	{
		return true;
	}

	// Token: 0x06005993 RID: 22931 RVA: 0x001050E9 File Offset: 0x001032E9
	public override bool NeedShowThirdPartyId()
	{
		return true;
	}

	// Token: 0x06005994 RID: 22932 RVA: 0x001050EC File Offset: 0x001032EC
	public override string CreatePlayerSession(string id)
	{
		return id;
	}

	// Token: 0x06005995 RID: 22933 RVA: 0x001050EF File Offset: 0x001032EF
	public override string GetSessionId(string playerSession)
	{
		return playerSession;
	}

	// Token: 0x06005996 RID: 22934 RVA: 0x001050F4 File Offset: 0x001032F4
	public unsafe override void SetMultiPlayerActivity(int currentPlayerCount, int maxPlayerCount, string playerSession, EXboxMultiplayerActivityJoinRestriction restriction)
	{
		string connectionString = "";
		string groupId = "";
		if (restriction != EXboxMultiplayerActivityJoinRestriction.Activity_InviteOnly)
		{
			connectionString = playerSession;
			groupId = "WutheringWaves" + playerSession;
		}
		string thirdUserId = this.GetThirdUserId();
		Action<bool> setMpCb = null;
		setMpCb = delegate(bool bSuccess)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.KuroSdk;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "CreateXboxMultiplayerActivityAsync";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bSuccess", bSuccess);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			DelegateUtils.ReleaseManualReleaseDelegate(setMpCb);
		};
		FOnXboxCallResult callback = DelegateUtils.ToManualReleaseDelegate<FOnXboxCallResult>(setMpCb);
		UKuroStaticXSXLibrary.SetXboxMultiplayerActivityAsync(this.GetCurrentUserHandle(), long.Parse(thirdUserId), connectionString, maxPlayerCount, currentPlayerCount, groupId, restriction, true, callback);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SetMultiPlayerActivity";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("currentPlayerCount", currentPlayerCount);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("maxPlayerCount", maxPlayerCount);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("playerSession", playerSession);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("restriction", restriction);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x06005997 RID: 22935 RVA: 0x001051FC File Offset: 0x001033FC
	public void GetMultiPlayerActivityInfo()
	{
		long currentUserHandle = this.GetCurrentUserHandle();
		string thirdUserId = this.GetThirdUserId();
		string text = "";
		int num = 0;
		int num2 = 0;
		string text2 = "";
		bool xboxMultiplayerActivity = UKuroStaticXSXLibrary.GetXboxMultiplayerActivity(currentUserHandle, long.Parse(thirdUserId), ref text, ref num, ref num2, ref text2);
		string item = text;
		int num3 = num;
		int num4 = num2;
		string item2 = text2;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "GetXboxMultiplayerActivityInfo";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("connectionString", item);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.KuroSdk;
		ELogAuthor author2 = ELogAuthor.YZY;
		string message2 = "GetXboxMultiplayerActivityInfo";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("maxPlayers", num3);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.KuroSdk;
		ELogAuthor author3 = ELogAuthor.YZY;
		string message3 = "GetXboxMultiplayerActivityInfo";
		ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("currentPlayers", num4);
		instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		Log instance4 = Log.Instance;
		ELogModule module4 = ELogModule.KuroSdk;
		ELogAuthor author4 = ELogAuthor.YZY;
		string message4 = "GetXboxMultiplayerActivityInfo";
		ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("groupId", item2);
		instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		Log instance5 = Log.Instance;
		ELogModule module5 = ELogModule.KuroSdk;
		ELogAuthor author5 = ELogAuthor.YZY;
		string message5 = "GetXboxMultiplayerActivityInfo";
		ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("result", xboxMultiplayerActivity);
		instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
	}

	// Token: 0x06005998 RID: 22936 RVA: 0x00105320 File Offset: 0x00103520
	public override void LeaveMultiPlayerActivity()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "LeaveMultiPlayerActivity", default(ReadOnlySpan<ValueTuple<string, object>>));
		Action<bool> deleteMpCb = null;
		deleteMpCb = delegate(bool bSuccess)
		{
			this.OnDeleteMultiPlayerActivityAsyncComplete(bSuccess);
			DelegateUtils.ReleaseManualReleaseDelegate(deleteMpCb);
		};
		FOnXboxCallResult callback = DelegateUtils.ToManualReleaseDelegate<FOnXboxCallResult>(deleteMpCb);
		UKuroStaticXSXLibrary.DeleteXboxMultiplayerActivityAsync(this.GetCurrentUserHandle(), callback);
	}

	// Token: 0x06005999 RID: 22937 RVA: 0x00105388 File Offset: 0x00103588
	private void OnDeleteMultiPlayerActivityAsyncComplete(bool bSuccess)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "LeaveMultiPlayerActivity";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bSuccess", bSuccess);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600599A RID: 22938 RVA: 0x001053C4 File Offset: 0x001035C4
	public override bool CheckPrivilege(ESdkPrivilege privilege)
	{
		bool flag;
		if (this.PrivilegeCacheMap.TryGetValue((int)privilege, out flag) && flag)
		{
			return true;
		}
		bool flag2 = false;
		EXboxUserPrivilege privilege2 = EXboxUserPrivilege.Multiplayer;
		if (privilege == ESdkPrivilege.Multiplayer)
		{
			flag2 = true;
			privilege2 = EXboxUserPrivilege.Multiplayer;
		}
		else if (privilege == ESdkPrivilege.Communications)
		{
			flag2 = true;
			privilege2 = EXboxUserPrivilege.Communications;
		}
		else if (privilege == ESdkPrivilege.UserGeneratedContent)
		{
			flag2 = true;
			privilege2 = EXboxUserPrivilege.UserGeneratedContent;
		}
		else if (privilege == ESdkPrivilege.CrossPlay)
		{
			flag2 = true;
			privilege2 = EXboxUserPrivilege.CrossPlay;
		}
		if (flag2)
		{
			bool bHasPrivilege = UKuroStaticXSXLibrary.CheckXboxPrivilege(this.GetCurrentUserHandle(), privilege2, EXboxUserPrivilegeOptions.None).bHasPrivilege;
			this.PrivilegeCacheMap[(int)privilege] = bHasPrivilege;
			return bHasPrivilege;
		}
		return true;
	}

	// Token: 0x0600599B RID: 22939 RVA: 0x0010543C File Offset: 0x0010363C
	public override bool ResolvePrivilege(ESdkPrivilege privilege)
	{
		if (privilege == ESdkPrivilege.Invalid)
		{
			return true;
		}
		bool flag;
		if (this.PrivilegeCacheMap.TryGetValue((int)privilege, out flag) && flag)
		{
			return true;
		}
		EXboxUserPrivilege privilege2 = EXboxUserPrivilege.Multiplayer;
		if (privilege == ESdkPrivilege.Multiplayer)
		{
			privilege2 = EXboxUserPrivilege.Multiplayer;
		}
		else if (privilege == ESdkPrivilege.Communications)
		{
			privilege2 = EXboxUserPrivilege.Communications;
		}
		else if (privilege == ESdkPrivilege.UserGeneratedContent)
		{
			privilege2 = EXboxUserPrivilege.UserGeneratedContent;
		}
		else if (privilege == ESdkPrivilege.CrossPlay)
		{
			privilege2 = EXboxUserPrivilege.CrossPlay;
		}
		bool flag2 = UKuroStaticXSXLibrary.ResolveXboxPrivilegeWithUi(this.GetCurrentUserHandle(), privilege2, EXboxUserPrivilegeOptions.None);
		if (flag2)
		{
			this.PrivilegeCacheMap[(int)privilege] = true;
		}
		return flag2;
	}

	// Token: 0x0600599C RID: 22940 RVA: 0x001054A4 File Offset: 0x001036A4
	public override void JoinSessionBindFunction(Action<string, string> callback)
	{
		this.JoinSessionCallback = callback;
		if (this.PendingJoinSessionInfo != null)
		{
			string userId = this.PendingJoinSessionInfo.userId;
			string playerSession = this.PendingJoinSessionInfo.playerSession;
			this.PendingJoinSessionInfo = null;
			this.JoinSessionCallback(userId, playerSession);
		}
	}

	// Token: 0x0600599D RID: 22941 RVA: 0x001054EC File Offset: 0x001036EC
	public override bool SupportSwitchFriendSearchByThirdPartyId()
	{
		return true;
	}

	// Token: 0x0600599E RID: 22942 RVA: 0x001054F0 File Offset: 0x001036F0
	public override void OnClear()
	{
		if (this.XboxGameInviteDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FXboxInviteInfo>(this.OnXboxGameInvite));
			this.XboxGameInviteDelegate = null;
		}
		UKuroStaticXSXLibrary.UnregisterFromXboxGameInviteEvent();
		if (this.QueryExternalAchievementDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new <>A{00000018}<bool, TArray<FXboxAchievementInfo>>(this.OnQueryExternalAchievement));
			this.QueryExternalAchievementDelegate = null;
		}
		UKuroStaticXSXLibrary.UnregisterXboxAchievementsCallback();
		if (this.CheckPermissionDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FXboxPermissionCheckResult>(this.OnCheckPermission));
			this.CheckPermissionDelegate = null;
		}
	}

	// Token: 0x0600599F RID: 22943 RVA: 0x00105568 File Offset: 0x00103768
	private void OnXboxGameInvite(FXboxInviteInfo info)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "XboxGameInviteCallback";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inviteInfo", info);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (info.bHasInvite)
		{
			string text = info.InvitedXuid.ToString();
			string connectionString = info.ConnectionString;
			if (this.JoinSessionCallback != null)
			{
				this.JoinSessionCallback(text, connectionString);
				return;
			}
			this.PendingJoinSessionInfo = new XboxPendingJoinSessionInfo();
			this.PendingJoinSessionInfo.userId = text;
			this.PendingJoinSessionInfo.playerSession = connectionString;
		}
	}

	// Token: 0x060059A0 RID: 22944 RVA: 0x001055F4 File Offset: 0x001037F4
	public new void QueryExternalAchievement()
	{
		long currentUserHandle = this.GetCurrentUserHandle();
		string thirdUserId = this.GetThirdUserId();
		UKuroStaticXSXLibrary.GetXboxAchievementsAsync(currentUserHandle, long.Parse(thirdUserId), EXboxAchievementType.All, false, EXboxAchievementOrderBy.DefaultOrder, 0, 0);
	}

	// Token: 0x060059A1 RID: 22945 RVA: 0x00105620 File Offset: 0x00103820
	private void OnQueryExternalAchievement(bool bSuccess, [Nullable(new byte[]
	{
		2,
		1
	})] in TArray<FXboxAchievementInfo> Achievements)
	{
		if (bSuccess && Achievements != null)
		{
			int num = Achievements.Num();
			for (int i = 0; i < num; i++)
			{
				FXboxAchievementInfo fxboxAchievementInfo = Achievements.Get(i);
				SdkAchievementContentData sdkAchievementContentData = new SdkAchievementContentData();
				sdkAchievementContentData.AchievementId = fxboxAchievementInfo.Id;
				sdkAchievementContentData.Progress = ((fxboxAchievementInfo.ProgressState == 1) ? 100 : 0);
				this.AchievementMap[fxboxAchievementInfo.Id] = sdkAchievementContentData;
			}
		}
	}

	// Token: 0x060059A2 RID: 22946 RVA: 0x0010568C File Offset: 0x0010388C
	public override void UnlockSdkTrophy(string id)
	{
		if (!this.AchievementMap.ContainsKey(id))
		{
			return;
		}
		if (this.AchievementMap[id].Progress == 100)
		{
			return;
		}
		long currentUserHandle = this.GetCurrentUserHandle();
		string thirdUserId = this.GetThirdUserId();
		UKuroStaticXSXLibrary.UpdateXboxAchievementAsync(currentUserHandle, long.Parse(thirdUserId), id, 100);
	}

	// Token: 0x060059A3 RID: 22947 RVA: 0x001056DC File Offset: 0x001038DC
	public override void UpdateRecentPlayer(string[] ids)
	{
		long userHandle = this.GetCurrentUserHandle();
		string thirdUserId = this.GetThirdUserId();
		TArray<FXboxRecentPlayerUpdate> tarray = new TArray<FXboxRecentPlayerUpdate>();
		foreach (string text in ids)
		{
			if (!(text == thirdUserId))
			{
				FXboxRecentPlayerUpdate fxboxRecentPlayerUpdate = new FXboxRecentPlayerUpdate();
				fxboxRecentPlayerUpdate.Xuid = long.Parse(text);
				tarray.Add(fxboxRecentPlayerUpdate);
			}
		}
		if (tarray.Num() == 0)
		{
			return;
		}
		Action<bool> recentCb = null;
		recentCb = delegate(bool bSuccess)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "UpdateXboxMultiplayerActivityRecentPlayersAsync";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bSuccess", bSuccess);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			DelegateUtils.ReleaseManualReleaseDelegate(recentCb);
			UKuroStaticXSXLibrary.FlushXboxMultiplayerActivityRecentPlayersAsync(userHandle);
		};
		FOnXboxCallResult callback = DelegateUtils.ToManualReleaseDelegate<FOnXboxCallResult>(recentCb);
		UKuroStaticXSXLibrary.UpdateXboxMultiplayerActivityRecentPlayersAsync(userHandle, tarray, callback);
	}

	// Token: 0x060059A4 RID: 22948 RVA: 0x00105788 File Offset: 0x00103988
	public override bool CheckIfSingleServerAfterSelect()
	{
		return Info.Instance.IsBuildShipping;
	}

	// Token: 0x060059A5 RID: 22949 RVA: 0x0010579C File Offset: 0x0010399C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public override UniTask<string> GetOnlyRegionInfo(ILoginInfo result)
	{
		PlatformXSXGlobal.<GetOnlyRegionInfo>d__70 <GetOnlyRegionInfo>d__;
		<GetOnlyRegionInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetOnlyRegionInfo>d__.result = result;
		<GetOnlyRegionInfo>d__.<>1__state = -1;
		<GetOnlyRegionInfo>d__.<>t__builder.Start<PlatformXSXGlobal.<GetOnlyRegionInfo>d__70>(ref <GetOnlyRegionInfo>d__);
		return <GetOnlyRegionInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060059A6 RID: 22950 RVA: 0x001057E0 File Offset: 0x001039E0
	[return: Nullable(0)]
	public override UniTask<bool> SaveSingleServerRegion(int loginType, string region, string userId, string userName, string token)
	{
		PlatformXSXGlobal.<SaveSingleServerRegion>d__71 <SaveSingleServerRegion>d__;
		<SaveSingleServerRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SaveSingleServerRegion>d__.loginType = loginType;
		<SaveSingleServerRegion>d__.region = region;
		<SaveSingleServerRegion>d__.userId = userId;
		<SaveSingleServerRegion>d__.userName = userName;
		<SaveSingleServerRegion>d__.token = token;
		<SaveSingleServerRegion>d__.<>1__state = -1;
		<SaveSingleServerRegion>d__.<>t__builder.Start<PlatformXSXGlobal.<SaveSingleServerRegion>d__71>(ref <SaveSingleServerRegion>d__);
		return <SaveSingleServerRegion>d__.<>t__builder.Task;
	}

	// Token: 0x060059A7 RID: 22951 RVA: 0x00105848 File Offset: 0x00103A48
	private void OnCheckPermission(FXboxPermissionCheckResult result)
	{
		ESdkPermission esdkPermission = this.ConvertPermissionToESdkPermission(result.Permission);
		string key = result.TargetXuid.ToString() + esdkPermission.ToString();
		Action<bool> action;
		if (this.PermissionCallBackMap.TryGetValue(key, out action))
		{
			action(result.bIsAllowed);
			this.PermissionCallBackMap.Remove(key);
		}
		List<XboxPermissionCheckResultSt> list;
		if (this.UserPermissionMap.TryGetValue(result.TargetXuid.ToString(), out list))
		{
			foreach (XboxPermissionCheckResultSt xboxPermissionCheckResultSt in list)
			{
				if (xboxPermissionCheckResultSt.Permission == esdkPermission)
				{
					xboxPermissionCheckResultSt.Result = result.bIsAllowed;
					break;
				}
			}
		}
	}

	// Token: 0x060059A8 RID: 22952 RVA: 0x00105920 File Offset: 0x00103B20
	public override void CheckPermission(string xuid, ESdkPermission permission, Action<bool> callback)
	{
		if (xuid == "")
		{
			callback(true);
			return;
		}
		List<XboxPermissionCheckResultSt> list;
		if (this.UserPermissionMap.TryGetValue(xuid, out list))
		{
			using (List<XboxPermissionCheckResultSt>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					XboxPermissionCheckResultSt xboxPermissionCheckResultSt = enumerator.Current;
					if (xboxPermissionCheckResultSt.Permission == permission)
					{
						callback(xboxPermissionCheckResultSt.Result);
						return;
					}
				}
				goto IL_7F;
			}
		}
		list = new List<XboxPermissionCheckResultSt>();
		this.UserPermissionMap[xuid] = list;
		IL_7F:
		XboxPermissionCheckResultSt xboxPermissionCheckResultSt2 = new XboxPermissionCheckResultSt();
		xboxPermissionCheckResultSt2.Permission = permission;
		xboxPermissionCheckResultSt2.Result = false;
		list.Add(xboxPermissionCheckResultSt2);
		this.PermissionCallBackMap[xuid + permission.ToString()] = callback;
		EXboxPermission permission2 = this.ConvertPermission(permission);
		UKuroStaticXSXLibrary.CheckXboxPermissionAsync(this.GetCurrentUserHandle(), long.Parse(xuid), permission2, this.CheckPermissionDelegate);
	}

	// Token: 0x060059A9 RID: 22953 RVA: 0x00105A18 File Offset: 0x00103C18
	private EXboxPermission ConvertPermission(ESdkPermission permission)
	{
		if (permission == ESdkPermission.CommunicateUsingText)
		{
			return EXboxPermission.CommunicateUsingText;
		}
		if (permission == ESdkPermission.CommunicateUsingVoice)
		{
			return EXboxPermission.CommunicateUsingVoice;
		}
		if (permission == ESdkPermission.ViewTargetProfile)
		{
			return EXboxPermission.ViewTargetProfile;
		}
		return EXboxPermission.CommunicateUsingText;
	}

	// Token: 0x060059AA RID: 22954 RVA: 0x00105A2C File Offset: 0x00103C2C
	private ESdkPermission ConvertPermissionToESdkPermission(EXboxPermission permission)
	{
		if (permission == EXboxPermission.CommunicateUsingText)
		{
			return ESdkPermission.CommunicateUsingText;
		}
		if (permission == EXboxPermission.CommunicateUsingVoice)
		{
			return ESdkPermission.CommunicateUsingVoice;
		}
		if (permission == EXboxPermission.ViewTargetProfile)
		{
			return ESdkPermission.ViewTargetProfile;
		}
		return ESdkPermission.CommunicateUsingText;
	}

	// Token: 0x060059AB RID: 22955 RVA: 0x00105A40 File Offset: 0x00103C40
	private void InitXboxToken()
	{
		this.QueryXboxToken(delegate(string token)
		{
			this.XboxToken = token;
		});
	}

	// Token: 0x060059AC RID: 22956 RVA: 0x00105A54 File Offset: 0x00103C54
	private void QueryXboxToken(Action<string> finishTokenCallBack)
	{
		long currentUserHandle = this.GetCurrentUserHandle();
		string url = "https://sdk-prod-cdn-aws.kurogame-service.com";
		Action<FXboxTokenAndSignatureResult> tokenCb = null;
		tokenCb = delegate(FXboxTokenAndSignatureResult result)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(tokenCb);
			if (result.bSuccess)
			{
				finishTokenCallBack(result.Token);
				return;
			}
			this.QueryXboxToken(finishTokenCallBack);
		};
		FOnXboxTokenAndSignatureResult callback = DelegateUtils.ToManualReleaseDelegate<FOnXboxTokenAndSignatureResult>(tokenCb);
		UKuroStaticXSXLibrary.GetXboxTokenAndSignatureAsync(currentUserHandle, url, callback);
	}

	// Token: 0x060059AD RID: 22957 RVA: 0x00105AAD File Offset: 0x00103CAD
	public override string GetExternalToken()
	{
		return this.XboxToken;
	}

	// Token: 0x060059AE RID: 22958 RVA: 0x00105AB8 File Offset: 0x00103CB8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public override UniTask<string> GetExternalCollectionId()
	{
		PlatformXSXGlobal.<GetExternalCollectionId>d__79 <GetExternalCollectionId>d__;
		<GetExternalCollectionId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetExternalCollectionId>d__.<>1__state = -1;
		<GetExternalCollectionId>d__.<>t__builder.Start<PlatformXSXGlobal.<GetExternalCollectionId>d__79>(ref <GetExternalCollectionId>d__);
		return <GetExternalCollectionId>d__.<>t__builder.Task;
	}

	// Token: 0x040028F9 RID: 10489
	private const int WEBVIEWCD = 5000;

	// Token: 0x040028FA RID: 10490
	private long CurrentUserHandle;

	// Token: 0x040028FB RID: 10491
	[Nullable(2)]
	private FOnXboxAchievementsReceived QueryExternalAchievementDelegate;

	// Token: 0x040028FC RID: 10492
	[Nullable(2)]
	private FOnXboxInviteReceivedDynamic XboxGameInviteDelegate;

	// Token: 0x040028FD RID: 10493
	[Nullable(2)]
	private FOnXboxPermissionCheckResult CheckPermissionDelegate;

	// Token: 0x040028FE RID: 10494
	private readonly Dictionary<int, bool> PrivilegeCacheMap = new Dictionary<int, bool>();

	// Token: 0x040028FF RID: 10495
	private readonly Dictionary<string, bool> BlockMap = new Dictionary<string, bool>();

	// Token: 0x04002900 RID: 10496
	private string XboxToken = "";

	// Token: 0x04002901 RID: 10497
	private readonly Dictionary<string, List<XboxPermissionCheckResultSt>> UserPermissionMap = new Dictionary<string, List<XboxPermissionCheckResultSt>>();

	// Token: 0x04002902 RID: 10498
	private readonly Dictionary<string, Action<bool>> PermissionCallBackMap = new Dictionary<string, Action<bool>>();

	// Token: 0x04002903 RID: 10499
	public readonly Action<string> OnAnnounceInitCallBack = delegate(string result)
	{
	};

	// Token: 0x04002904 RID: 10500
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, string> JoinSessionCallback;

	// Token: 0x04002905 RID: 10501
	[Nullable(2)]
	private XboxPendingJoinSessionInfo PendingJoinSessionInfo;
}
