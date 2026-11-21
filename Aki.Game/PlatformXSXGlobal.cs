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

// Token: 0x0200031F RID: 799
[NullableContext(1)]
[Nullable(0)]
public class PlatformXSXGlobal : PlatformSdkBase
{
	// Token: 0x06002D03 RID: 11523 RVA: 0x0010C294 File Offset: 0x0010A494
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x06002D04 RID: 11524 RVA: 0x0010C2C8 File Offset: 0x0010A4C8
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

	// Token: 0x06002D05 RID: 11525 RVA: 0x0010C414 File Offset: 0x0010A614
	public void AnnounceRedPointCallBack(string result)
	{
		XSXSdkRedPointContentSt xsxsdkRedPointContentSt = Json.Parse<XSXSdkRedPointContentSt>(Json.Parse<XSXSdkRedPointSt>(result, null).data, null);
		KuroSdkController.Instance.SetPostWebViewRedPointState(xsxsdkRedPointContentSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06002D06 RID: 11526 RVA: 0x0010C454 File Offset: 0x0010A654
	public void OnLoginCallBack(string result)
	{
		this.QueryExternalAchievement();
	}

	// Token: 0x06002D07 RID: 11527 RVA: 0x0010C45C File Offset: 0x0010A65C
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

	// Token: 0x06002D08 RID: 11528 RVA: 0x0010C4A0 File Offset: 0x0010A6A0
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

	// Token: 0x06002D09 RID: 11529 RVA: 0x0010C54C File Offset: 0x0010A74C
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

	// Token: 0x06002D0A RID: 11530 RVA: 0x0010C5BC File Offset: 0x0010A7BC
	public override void SdkExit()
	{
		KuroApplication.ExitWithReason(false, "SdkExit");
	}

	// Token: 0x06002D0B RID: 11531 RVA: 0x0010C5CC File Offset: 0x0010A7CC
	public override void InitializePostWebView()
	{
		string currentSelectServerId = this.GetCurrentSelectServerId();
		string text = Json.Stringify(new InitializePostWebViewParam
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

	// Token: 0x06002D0C RID: 11532 RVA: 0x0010C66C File Offset: 0x0010A86C
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

	// Token: 0x06002D0D RID: 11533 RVA: 0x0010C69E File Offset: 0x0010A89E
	private string GetPaymentInfo(ISDKPayment payment, ISDKPayRole roleInfo)
	{
		return JsonSerializer.Serialize<PayInfoXSXGlobal>(new PayInfoXSXGlobal
		{
			goodsId = payment.product_id.ToString()
		}, KuroSdkJsonOptions.Unescaped);
	}

	// Token: 0x06002D0E RID: 11534 RVA: 0x0010C6C0 File Offset: 0x0010A8C0
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

	// Token: 0x06002D0F RID: 11535 RVA: 0x0010C714 File Offset: 0x0010A914
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

	// Token: 0x06002D10 RID: 11536 RVA: 0x0010C75C File Offset: 0x0010A95C
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

	// Token: 0x06002D11 RID: 11537 RVA: 0x0010C7A4 File Offset: 0x0010A9A4
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

	// Token: 0x06002D12 RID: 11538 RVA: 0x0010C7EC File Offset: 0x0010A9EC
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

	// Token: 0x06002D13 RID: 11539 RVA: 0x0010C8DC File Offset: 0x0010AADC
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

	// Token: 0x06002D14 RID: 11540 RVA: 0x0010C9DC File Offset: 0x0010ABDC
	public override void OpenUserCenter()
	{
		UKuroSDKManager.BindAccount();
	}

	// Token: 0x06002D15 RID: 11541 RVA: 0x0010C9E4 File Offset: 0x0010ABE4
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
		UKuroSDKManager.QueryProductInfo(Json.Stringify(new QueryProductInfoParamWindows
		{
			goodsIds = text,
			payChannel = channelId
		}, null) ?? "");
	}

	// Token: 0x06002D16 RID: 11542 RVA: 0x0010CA4C File Offset: 0x0010AC4C
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

	// Token: 0x06002D17 RID: 11543 RVA: 0x0010CB00 File Offset: 0x0010AD00
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

	// Token: 0x06002D18 RID: 11544 RVA: 0x0010CBB2 File Offset: 0x0010ADB2
	public override string GetChannelId()
	{
		return UKuroSDKManager.GetSdkParams("channel_id");
	}

	// Token: 0x06002D19 RID: 11545 RVA: 0x0010CBBE File Offset: 0x0010ADBE
	public override string GetChannelName()
	{
		return UKuroSDKManager.GetSdkParams("channel_name");
	}

	// Token: 0x06002D1A RID: 11546 RVA: 0x0010CBCA File Offset: 0x0010ADCA
	public override string GetGameId()
	{
		return UKuroSDKManager.GetSdkParams("project_id");
	}

	// Token: 0x06002D1B RID: 11547 RVA: 0x0010CBD6 File Offset: 0x0010ADD6
	public override string GetDid()
	{
		return UKuroSDKManager.GetSdkParams("did");
	}

	// Token: 0x06002D1C RID: 11548 RVA: 0x0010CBE2 File Offset: 0x0010ADE2
	public override string GetAccessToken()
	{
		return UKuroSDKManager.GetSdkParams("token");
	}

	// Token: 0x06002D1D RID: 11549 RVA: 0x0010CBF0 File Offset: 0x0010ADF0
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

	// Token: 0x06002D1E RID: 11550 RVA: 0x0010CC61 File Offset: 0x0010AE61
	public override bool GetProtocolState()
	{
		return true;
	}

	// Token: 0x06002D1F RID: 11551 RVA: 0x0010CC64 File Offset: 0x0010AE64
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

	// Token: 0x06002D20 RID: 11552 RVA: 0x0010CCB4 File Offset: 0x0010AEB4
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

	// Token: 0x06002D21 RID: 11553 RVA: 0x0010CCE4 File Offset: 0x0010AEE4
	public override string GetThirdUserId()
	{
		return UKuroStaticXSXLibrary.GetXboxUserId(this.GetCurrentUserHandle()).UserId.ToString();
	}

	// Token: 0x06002D22 RID: 11554 RVA: 0x0010CD09 File Offset: 0x0010AF09
	public override string GetOnlineId()
	{
		return UKuroStaticXSXLibrary.GetXboxGamertagForDisplay(this.GetCurrentUserHandle(), EXboxGamertagComponent.Classic).Gamertag;
	}

	// Token: 0x06002D23 RID: 11555 RVA: 0x0010CD1C File Offset: 0x0010AF1C
	public override void OpenProfileCard(string xuid)
	{
		UKuroStaticXSXLibrary.ShowXboxPlayerProfileCard(this.GetCurrentUserHandle(), long.Parse(xuid));
	}

	// Token: 0x06002D24 RID: 11556 RVA: 0x0010CD30 File Offset: 0x0010AF30
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

	// Token: 0x06002D25 RID: 11557 RVA: 0x0010CD79 File Offset: 0x0010AF79
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

	// Token: 0x06002D26 RID: 11558 RVA: 0x0010CD86 File Offset: 0x0010AF86
	public override bool NeedCheckPlayOnly()
	{
		return true;
	}

	// Token: 0x06002D27 RID: 11559 RVA: 0x0010CD89 File Offset: 0x0010AF89
	public override bool GetSdkFriendOnlyState()
	{
		return LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, false);
	}

	// Token: 0x06002D28 RID: 11560 RVA: 0x0010CD97 File Offset: 0x0010AF97
	public override void SaveSdkFriendOnlyState(bool state)
	{
		LauncherStorageLib.Instance.SetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, state);
	}

	// Token: 0x06002D29 RID: 11561 RVA: 0x0010CDA6 File Offset: 0x0010AFA6
	public override bool SupportSwitchFriendShowType()
	{
		return true;
	}

	// Token: 0x06002D2A RID: 11562 RVA: 0x0010CDA9 File Offset: 0x0010AFA9
	public override bool NeedShowThirdPartyId()
	{
		return true;
	}

	// Token: 0x06002D2B RID: 11563 RVA: 0x0010CDAC File Offset: 0x0010AFAC
	public override string CreatePlayerSession(string id)
	{
		return id;
	}

	// Token: 0x06002D2C RID: 11564 RVA: 0x0010CDAF File Offset: 0x0010AFAF
	public override string GetSessionId(string playerSession)
	{
		return playerSession;
	}

	// Token: 0x06002D2D RID: 11565 RVA: 0x0010CDB4 File Offset: 0x0010AFB4
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

	// Token: 0x06002D2E RID: 11566 RVA: 0x0010CEBC File Offset: 0x0010B0BC
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

	// Token: 0x06002D2F RID: 11567 RVA: 0x0010CFE0 File Offset: 0x0010B1E0
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

	// Token: 0x06002D30 RID: 11568 RVA: 0x0010D048 File Offset: 0x0010B248
	private void OnDeleteMultiPlayerActivityAsyncComplete(bool bSuccess)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "LeaveMultiPlayerActivity";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bSuccess", bSuccess);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06002D31 RID: 11569 RVA: 0x0010D084 File Offset: 0x0010B284
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

	// Token: 0x06002D32 RID: 11570 RVA: 0x0010D0FC File Offset: 0x0010B2FC
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

	// Token: 0x06002D33 RID: 11571 RVA: 0x0010D164 File Offset: 0x0010B364
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

	// Token: 0x06002D34 RID: 11572 RVA: 0x0010D1AC File Offset: 0x0010B3AC
	public override bool SupportSwitchFriendSearchByThirdPartyId()
	{
		return true;
	}

	// Token: 0x06002D35 RID: 11573 RVA: 0x0010D1B0 File Offset: 0x0010B3B0
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

	// Token: 0x06002D36 RID: 11574 RVA: 0x0010D228 File Offset: 0x0010B428
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

	// Token: 0x06002D37 RID: 11575 RVA: 0x0010D2B4 File Offset: 0x0010B4B4
	public new void QueryExternalAchievement()
	{
		long currentUserHandle = this.GetCurrentUserHandle();
		string thirdUserId = this.GetThirdUserId();
		UKuroStaticXSXLibrary.GetXboxAchievementsAsync(currentUserHandle, long.Parse(thirdUserId), EXboxAchievementType.All, false, EXboxAchievementOrderBy.DefaultOrder, 0, 0);
	}

	// Token: 0x06002D38 RID: 11576 RVA: 0x0010D2E0 File Offset: 0x0010B4E0
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

	// Token: 0x06002D39 RID: 11577 RVA: 0x0010D34C File Offset: 0x0010B54C
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

	// Token: 0x06002D3A RID: 11578 RVA: 0x0010D39C File Offset: 0x0010B59C
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

	// Token: 0x06002D3B RID: 11579 RVA: 0x0010D448 File Offset: 0x0010B648
	public override bool CheckIfSingleServerAfterSelect()
	{
		return true;
	}

	// Token: 0x06002D3C RID: 11580 RVA: 0x0010D44C File Offset: 0x0010B64C
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

	// Token: 0x06002D3D RID: 11581 RVA: 0x0010D490 File Offset: 0x0010B690
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

	// Token: 0x06002D3E RID: 11582 RVA: 0x0010D4F8 File Offset: 0x0010B6F8
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

	// Token: 0x06002D3F RID: 11583 RVA: 0x0010D5D0 File Offset: 0x0010B7D0
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

	// Token: 0x06002D40 RID: 11584 RVA: 0x0010D6C8 File Offset: 0x0010B8C8
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

	// Token: 0x06002D41 RID: 11585 RVA: 0x0010D6DC File Offset: 0x0010B8DC
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

	// Token: 0x06002D42 RID: 11586 RVA: 0x0010D6F0 File Offset: 0x0010B8F0
	private void InitXboxToken()
	{
		this.QueryXboxToken(delegate(string token)
		{
			this.XboxToken = token;
		});
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x0010D704 File Offset: 0x0010B904
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

	// Token: 0x06002D44 RID: 11588 RVA: 0x0010D75D File Offset: 0x0010B95D
	public override string GetExternalToken()
	{
		return this.XboxToken;
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x0010D768 File Offset: 0x0010B968
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

	// Token: 0x04002994 RID: 10644
	private const int WEBVIEWCD = 5000;

	// Token: 0x04002995 RID: 10645
	private long CurrentUserHandle;

	// Token: 0x04002996 RID: 10646
	[Nullable(2)]
	private FOnXboxAchievementsReceived QueryExternalAchievementDelegate;

	// Token: 0x04002997 RID: 10647
	[Nullable(2)]
	private FOnXboxInviteReceivedDynamic XboxGameInviteDelegate;

	// Token: 0x04002998 RID: 10648
	[Nullable(2)]
	private FOnXboxPermissionCheckResult CheckPermissionDelegate;

	// Token: 0x04002999 RID: 10649
	private readonly Dictionary<int, bool> PrivilegeCacheMap = new Dictionary<int, bool>();

	// Token: 0x0400299A RID: 10650
	private readonly Dictionary<string, bool> BlockMap = new Dictionary<string, bool>();

	// Token: 0x0400299B RID: 10651
	private string XboxToken = "";

	// Token: 0x0400299C RID: 10652
	private readonly Dictionary<string, List<XboxPermissionCheckResultSt>> UserPermissionMap = new Dictionary<string, List<XboxPermissionCheckResultSt>>();

	// Token: 0x0400299D RID: 10653
	private readonly Dictionary<string, Action<bool>> PermissionCallBackMap = new Dictionary<string, Action<bool>>();

	// Token: 0x0400299E RID: 10654
	public readonly Action<string> OnAnnounceInitCallBack = delegate(string result)
	{
	};

	// Token: 0x0400299F RID: 10655
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, string> JoinSessionCallback;

	// Token: 0x040029A0 RID: 10656
	[Nullable(2)]
	private XboxPendingJoinSessionInfo PendingJoinSessionInfo;
}
