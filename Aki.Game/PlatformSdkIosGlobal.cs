using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000E4F RID: 3663
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkIosGlobal : PlatformSdkBase
{
	// Token: 0x060058CF RID: 22735 RVA: 0x00101198 File Offset: 0x000FF398
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("Sdkidfv", this.Getidfv());
		FCrashSightProxy.SetCustomData("SdkJyId", this.GetJyDid());
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x060058D0 RID: 22736 RVA: 0x001011F8 File Offset: 0x000FF3F8
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(this.AnnounceRedPointCallBack);
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x060058D1 RID: 22737 RVA: 0x00101254 File Offset: 0x000FF454
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkIosGlobal.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkIosGlobal.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x060058D2 RID: 22738 RVA: 0x0010128C File Offset: 0x000FF48C
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		UKuroSDKManager.OpenCustomerService(JsonSerializer.Serialize<OpenCustomerServiceParamIos>(new OpenCustomerServiceParamIos
		{
			islogin = ((instance.IsSdkLoggedIn() > false) ? 1 : 0),
			from = fromType,
			RoleId = this.GetCustomServerRoleId(),
			RoleName = instance2.GetAccountName(true),
			ServerId = instance.GetServerId(),
			ServerName = instance.GetServerName(),
			RoleLevel = instance2.GetPlayerLevel().GetValueOrDefault(),
			ExtendsInfo = this.GetCustomServerExtendsInfo()
		}, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x060058D3 RID: 22739 RVA: 0x00101320 File Offset: 0x000FF520
	public override string GetChannelId()
	{
		PlatformSdkIosGlobal.IUserInfo cacheUserInfo = this.GetCacheUserInfo();
		if (cacheUserInfo == null || cacheUserInfo.channelId == null)
		{
			return "";
		}
		if (cacheUserInfo == null)
		{
			return null;
		}
		return cacheUserInfo.channelId;
	}

	// Token: 0x060058D4 RID: 22740 RVA: 0x00101350 File Offset: 0x000FF550
	private string Getidfv()
	{
		PlatformSdkIosGlobal.IUserInfo cacheUserInfo = this.GetCacheUserInfo();
		if (cacheUserInfo == null || cacheUserInfo.idfv == null)
		{
			return "";
		}
		if (cacheUserInfo == null)
		{
			return null;
		}
		return cacheUserInfo.idfv;
	}

	// Token: 0x060058D5 RID: 22741 RVA: 0x00101380 File Offset: 0x000FF580
	public override string GetJyDid()
	{
		PlatformSdkIosGlobal.IUserInfo cacheUserInfo = this.GetCacheUserInfo();
		if (cacheUserInfo == null || cacheUserInfo.jyDeviceId == null)
		{
			return "";
		}
		if (cacheUserInfo == null)
		{
			return null;
		}
		return cacheUserInfo.jyDeviceId;
	}

	// Token: 0x060058D6 RID: 22742 RVA: 0x001013B0 File Offset: 0x000FF5B0
	private PlatformSdkIosGlobal.IUserInfo GetCacheUserInfo()
	{
		if (this.CacheUserInfo == null)
		{
			string sdkParams = UKuroSDKManager.GetSdkParams("");
			this.CacheUserInfo = Json.Parse<PlatformSdkIosGlobal.UserInfo>(sdkParams, null);
		}
		return this.CacheUserInfo;
	}

	// Token: 0x060058D7 RID: 22743 RVA: 0x001013E4 File Offset: 0x000FF5E4
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
		UKuroSDKManager.QueryProductInfo(text);
	}

	// Token: 0x060058D8 RID: 22744 RVA: 0x0010142C File Offset: 0x000FF62C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected override QueryProductSt[] OnQueryProduct(string str)
	{
		string[] array = str.Split('|', StringSplitOptions.None);
		List<QueryProductSt> list = new List<QueryProductSt>();
		if (array != null && array.Length != 0)
		{
			PlatformSdkIosGlobal.IQueryProduct queryProduct = Json.Parse<PlatformSdkIosGlobal.IQueryProduct>(array[1], null);
			PlatformSdkIosGlobal.QueryProductContent[] array2 = (queryProduct != null) ? queryProduct.products : null;
			if (array2 != null)
			{
				foreach (PlatformSdkIosGlobal.QueryProductContent queryProductContent in array2)
				{
					list.Add(new QueryProductSt
					{
						Currency = queryProductContent.currency,
						GoodId = queryProductContent.goodsId,
						Name = queryProductContent.name,
						Desc = queryProductContent.desc,
						Price = new float?(queryProductContent.price)
					});
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x060058D9 RID: 22745 RVA: 0x001014EC File Offset: 0x000FF6EC
	protected override void OnGetSharePlatform(string str)
	{
		PlatformSdkIosGlobal.SharePlatform sharePlatform = Json.Parse<PlatformSdkIosGlobal.SharePlatform>(str, null);
		if (sharePlatform.KROVERSEA_SDK_KEY_RESULT == 0)
		{
			PlatformSdkIosGlobal.SharePlatformContent[] array = Json.Parse<PlatformSdkIosGlobal.SharePlatformContent[]>(sharePlatform.KROVERSEA_SDK_KEY_DATA, null);
			List<SharePlatformSt> shareResult = new List<SharePlatformSt>();
			if (array != null)
			{
				foreach (PlatformSdkIosGlobal.SharePlatformContent sharePlatformContent in array)
				{
					SharePlatformSt sharePlatformSt = new SharePlatformSt();
					sharePlatformSt.IconUrl = sharePlatformContent.iconUrl;
					sharePlatformSt.PlatformId = sharePlatformContent.platform.ToString();
					shareResult.Add(sharePlatformSt);
				}
			}
			this.GetSharePlatformCallBackList.ForEach(delegate(Action<SharePlatformSt[]> value)
			{
				value(shareResult.ToArray());
			});
			this.GetSharePlatformCallBackList = new List<Action<SharePlatformSt[]>>();
		}
		base.OnGetSharePlatform(str);
	}

	// Token: 0x060058DA RID: 22746 RVA: 0x001015A8 File Offset: 0x000FF7A8
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		ISDKPayRole sdkPayRoleInfo = this.GetSdkPayRoleInfo();
		string paymentInfo2 = this.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroPay;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, paymentInfo2);
	}

	// Token: 0x060058DB RID: 22747 RVA: 0x001015D0 File Offset: 0x000FF7D0
	private ISDKPayRole GetSdkPayRoleInfo()
	{
		FunctionModel instance = FunctionModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		int? playerLevel = instance.GetPlayerLevel();
		return new SDKPayRole
		{
			roleId = this.GetRoleId(),
			roleName = (instance.GetPlayerName() ?? ""),
			roleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1"),
			serverId = (instance2.GetServerId() ?? ""),
			serverName = (instance2.GetServerName() ?? ""),
			vipLevel = "0",
			partyName = " ",
			setBalanceLevelOne = 0,
			setBalanceLevelTwo = 0
		};
	}

	// Token: 0x060058DC RID: 22748 RVA: 0x00101694 File Offset: 0x000FF894
	private string GetPaymentInfo(ISDKPayment payment, ISDKPayRole roleInfo)
	{
		return JsonSerializer.Serialize<PayInfoMacIosGlobal>(new PayInfoMacIosGlobal
		{
			RoleId = roleInfo.roleId.ToString(),
			RoleName = roleInfo.roleName.ToString(),
			ServerId = roleInfo.serverId.ToString(),
			ServerName = roleInfo.serverName.ToString(),
			CpOrder = payment.cpOrderId.ToString(),
			CallbackUrl = payment.callbackUrl.ToString(),
			GamePropID = payment.product_id.ToString(),
			GoodsName = payment.goodsName.ToString(),
			GoodsDesc = payment.goodsDesc.ToString(),
			Price = payment.price.ToString(),
			GoodsCurrency = "USD",
			ExtraParams = roleInfo.roleId.ToString()
		}, KuroSdkJsonOptions.Unescaped) ?? "";
	}

	// Token: 0x060058DD RID: 22749 RVA: 0x00101780 File Offset: 0x000FF980
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x060058DE RID: 22750 RVA: 0x0010179C File Offset: 0x000FF99C
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x060058DF RID: 22751 RVA: 0x001017B8 File Offset: 0x000FF9B8
	public override void SetFont()
	{
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SetFont";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fontPath", deviceFontAsset);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.SetFont(deviceFontAsset);
	}

	// Token: 0x060058E0 RID: 22752 RVA: 0x00101800 File Offset: 0x000FFA00
	protected unsafe override void OnShareResult(int code, string platform, string msg)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "OnShareResult";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("code", code);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("platform", platform);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("msg", msg);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (code == 1)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x060058E1 RID: 22753 RVA: 0x001018A4 File Offset: 0x000FFAA4
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

	// Token: 0x060058E2 RID: 22754 RVA: 0x00101921 File Offset: 0x000FFB21
	public override void OpenExternalUrl(string url)
	{
		UKuroSDKManager.OpenDefaultWebView(url);
	}

	// Token: 0x060058E3 RID: 22755 RVA: 0x00101929 File Offset: 0x000FFB29
	protected override int CurrentPlatformYearReviewTime()
	{
		return 3;
	}

	// Token: 0x060058E4 RID: 22756 RVA: 0x0010192C File Offset: 0x000FFB2C
	protected unsafe void KuroBindExternalLoginResult()
	{
		UKuroSDKManager.Get().ExternalLoginCallBack.Clear();
		UKuroSDKManager.Get().ExternalLoginCallBack.Add(delegate(bool result, string msg)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "ShowExternalLoginUI";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("result", result);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("msg", msg);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (result)
			{
				this.ExternalLoginState = true;
				base.QueryExternalAchievement();
			}
			this.ExternalLoginState = result;
		});
	}

	// Token: 0x060058E5 RID: 22757 RVA: 0x00101958 File Offset: 0x000FFB58
	protected override void BindExternalEvent()
	{
		this.KuroBindExternalLoginResult();
		base.KuroBindExternalAchievementWriteResult();
		base.KuroBindExternalAchievementQueryResult();
	}

	// Token: 0x060058E6 RID: 22758 RVA: 0x0010196C File Offset: 0x000FFB6C
	public override void UnlockSdkTrophy(string id)
	{
		this.UpdateExternalAchievementProgress(id, 100);
	}

	// Token: 0x060058E7 RID: 22759 RVA: 0x00101978 File Offset: 0x000FFB78
	public void UpdateExternalAchievementProgress(string achievementName, int progress)
	{
		if (!this.ExternalLoginState)
		{
			return;
		}
		if ((this.AchievementMap.ContainsKey(achievementName) ? this.AchievementMap[achievementName].Progress : 0) >= 100)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "UpdateExternalAchievementProgress";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("achievementName", achievementName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		SdkAchievementContentData sdkAchievementContentData = new SdkAchievementContentData();
		sdkAchievementContentData.AchievementId = achievementName;
		sdkAchievementContentData.Progress = progress;
		UKuroSDKManager.WriteExternalAchievements(Json.Stringify<SdkAchievementData>(new SdkAchievementData
		{
			Achievements = new SdkAchievementContentData[]
			{
				sdkAchievementContentData
			}
		}, null) ?? "");
	}

	// Token: 0x040028A4 RID: 10404
	private const int WEBVIEWCD = 5000;

	// Token: 0x040028A5 RID: 10405
	private const int MAXREVIEWTIME = 3;

	// Token: 0x040028A6 RID: 10406
	[Nullable(2)]
	private PlatformSdkIosGlobal.IUserInfo CacheUserInfo;

	// Token: 0x040028A7 RID: 10407
	public readonly Action<string> AnnounceRedPointCallBack = delegate(string result)
	{
		if (result.Contains("showRed") && (result.Contains("1") || result.Contains("YES")))
		{
			KuroSdkController.Instance.SetPostWebViewRedPointState(true);
			EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
			return;
		}
		KuroSdkController.Instance.SetPostWebViewRedPointState(false);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	};

	// Token: 0x020074D0 RID: 29904
	private interface ISharePlatformContent
	{
		// Token: 0x17009FE7 RID: 40935
		// (get) Token: 0x06048A6D RID: 297581
		// (set) Token: 0x06048A6E RID: 297582
		string iconUrl { get; set; }

		// Token: 0x17009FE8 RID: 40936
		// (get) Token: 0x06048A6F RID: 297583
		// (set) Token: 0x06048A70 RID: 297584
		string platform { get; set; }
	}

	// Token: 0x020074D1 RID: 29905
	[Nullable(0)]
	private class SharePlatformContent : PlatformSdkIosGlobal.ISharePlatformContent
	{
		// Token: 0x17009FE9 RID: 40937
		// (get) Token: 0x06048A71 RID: 297585 RVA: 0x012B4A66 File Offset: 0x012B2C66
		// (set) Token: 0x06048A72 RID: 297586 RVA: 0x012B4A6E File Offset: 0x012B2C6E
		public string iconUrl { get; set; }

		// Token: 0x17009FEA RID: 40938
		// (get) Token: 0x06048A73 RID: 297587 RVA: 0x012B4A77 File Offset: 0x012B2C77
		// (set) Token: 0x06048A74 RID: 297588 RVA: 0x012B4A7F File Offset: 0x012B2C7F
		public string platform { get; set; }
	}

	// Token: 0x020074D2 RID: 29906
	private interface ISharePlatform
	{
		// Token: 0x17009FEB RID: 40939
		// (get) Token: 0x06048A76 RID: 297590
		// (set) Token: 0x06048A77 RID: 297591
		string KROVERSEA_SDK_KEY_DATA { get; set; }

		// Token: 0x17009FEC RID: 40940
		// (get) Token: 0x06048A78 RID: 297592
		// (set) Token: 0x06048A79 RID: 297593
		string KROVERSEA_SDK_KEY_REASON { get; set; }

		// Token: 0x17009FED RID: 40941
		// (get) Token: 0x06048A7A RID: 297594
		// (set) Token: 0x06048A7B RID: 297595
		int KROVERSEA_SDK_KEY_RESULT { get; set; }
	}

	// Token: 0x020074D3 RID: 29907
	[Nullable(0)]
	private class SharePlatform : PlatformSdkIosGlobal.ISharePlatform
	{
		// Token: 0x17009FEE RID: 40942
		// (get) Token: 0x06048A7C RID: 297596 RVA: 0x012B4A90 File Offset: 0x012B2C90
		// (set) Token: 0x06048A7D RID: 297597 RVA: 0x012B4A98 File Offset: 0x012B2C98
		public string KROVERSEA_SDK_KEY_DATA { get; set; }

		// Token: 0x17009FEF RID: 40943
		// (get) Token: 0x06048A7E RID: 297598 RVA: 0x012B4AA1 File Offset: 0x012B2CA1
		// (set) Token: 0x06048A7F RID: 297599 RVA: 0x012B4AA9 File Offset: 0x012B2CA9
		public string KROVERSEA_SDK_KEY_REASON { get; set; }

		// Token: 0x17009FF0 RID: 40944
		// (get) Token: 0x06048A80 RID: 297600 RVA: 0x012B4AB2 File Offset: 0x012B2CB2
		// (set) Token: 0x06048A81 RID: 297601 RVA: 0x012B4ABA File Offset: 0x012B2CBA
		public int KROVERSEA_SDK_KEY_RESULT { get; set; }
	}

	// Token: 0x020074D4 RID: 29908
	[NullableContext(0)]
	private class IQueryProduct
	{
		// Token: 0x04026B40 RID: 158528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public PlatformSdkIosGlobal.QueryProductContent[] products;

		// Token: 0x04026B41 RID: 158529
		public int code;

		// Token: 0x04026B42 RID: 158530
		[Nullable(1)]
		public string msg;
	}

	// Token: 0x020074D5 RID: 29909
	private interface IQueryProductContent
	{
		// Token: 0x17009FF1 RID: 40945
		// (get) Token: 0x06048A84 RID: 297604
		// (set) Token: 0x06048A85 RID: 297605
		string goodsId { get; set; }

		// Token: 0x17009FF2 RID: 40946
		// (get) Token: 0x06048A86 RID: 297606
		// (set) Token: 0x06048A87 RID: 297607
		string name { get; set; }

		// Token: 0x17009FF3 RID: 40947
		// (get) Token: 0x06048A88 RID: 297608
		// (set) Token: 0x06048A89 RID: 297609
		string desc { get; set; }

		// Token: 0x17009FF4 RID: 40948
		// (get) Token: 0x06048A8A RID: 297610
		// (set) Token: 0x06048A8B RID: 297611
		string currency { get; set; }

		// Token: 0x17009FF5 RID: 40949
		// (get) Token: 0x06048A8C RID: 297612
		// (set) Token: 0x06048A8D RID: 297613
		float price { get; set; }
	}

	// Token: 0x020074D6 RID: 29910
	[Nullable(0)]
	private class QueryProductContent : PlatformSdkIosGlobal.IQueryProductContent
	{
		// Token: 0x17009FF6 RID: 40950
		// (get) Token: 0x06048A8E RID: 297614 RVA: 0x012B4AD3 File Offset: 0x012B2CD3
		// (set) Token: 0x06048A8F RID: 297615 RVA: 0x012B4ADB File Offset: 0x012B2CDB
		public string goodsId { get; set; }

		// Token: 0x17009FF7 RID: 40951
		// (get) Token: 0x06048A90 RID: 297616 RVA: 0x012B4AE4 File Offset: 0x012B2CE4
		// (set) Token: 0x06048A91 RID: 297617 RVA: 0x012B4AEC File Offset: 0x012B2CEC
		public string name { get; set; }

		// Token: 0x17009FF8 RID: 40952
		// (get) Token: 0x06048A92 RID: 297618 RVA: 0x012B4AF5 File Offset: 0x012B2CF5
		// (set) Token: 0x06048A93 RID: 297619 RVA: 0x012B4AFD File Offset: 0x012B2CFD
		public string desc { get; set; }

		// Token: 0x17009FF9 RID: 40953
		// (get) Token: 0x06048A94 RID: 297620 RVA: 0x012B4B06 File Offset: 0x012B2D06
		// (set) Token: 0x06048A95 RID: 297621 RVA: 0x012B4B0E File Offset: 0x012B2D0E
		public string currency { get; set; }

		// Token: 0x17009FFA RID: 40954
		// (get) Token: 0x06048A96 RID: 297622 RVA: 0x012B4B17 File Offset: 0x012B2D17
		// (set) Token: 0x06048A97 RID: 297623 RVA: 0x012B4B1F File Offset: 0x012B2D1F
		public float price { get; set; }
	}

	// Token: 0x020074D7 RID: 29911
	private interface IUserInfo
	{
		// Token: 0x17009FFB RID: 40955
		// (get) Token: 0x06048A99 RID: 297625
		// (set) Token: 0x06048A9A RID: 297626
		string token { get; set; }

		// Token: 0x17009FFC RID: 40956
		// (get) Token: 0x06048A9B RID: 297627
		// (set) Token: 0x06048A9C RID: 297628
		string userId { get; set; }

		// Token: 0x17009FFD RID: 40957
		// (get) Token: 0x06048A9D RID: 297629
		// (set) Token: 0x06048A9E RID: 297630
		string userName { get; set; }

		// Token: 0x17009FFE RID: 40958
		// (get) Token: 0x06048A9F RID: 297631
		// (set) Token: 0x06048AA0 RID: 297632
		string extendParams { get; set; }

		// Token: 0x17009FFF RID: 40959
		// (get) Token: 0x06048AA1 RID: 297633
		// (set) Token: 0x06048AA2 RID: 297634
		string channelId { get; set; }

		// Token: 0x1700A000 RID: 40960
		// (get) Token: 0x06048AA3 RID: 297635
		// (set) Token: 0x06048AA4 RID: 297636
		string idfv { get; set; }

		// Token: 0x1700A001 RID: 40961
		// (get) Token: 0x06048AA5 RID: 297637
		// (set) Token: 0x06048AA6 RID: 297638
		string jyDeviceId { get; set; }
	}

	// Token: 0x020074D8 RID: 29912
	[Nullable(0)]
	private class UserInfo : PlatformSdkIosGlobal.IUserInfo
	{
		// Token: 0x1700A002 RID: 40962
		// (get) Token: 0x06048AA7 RID: 297639 RVA: 0x012B4B30 File Offset: 0x012B2D30
		// (set) Token: 0x06048AA8 RID: 297640 RVA: 0x012B4B38 File Offset: 0x012B2D38
		public string token { get; set; }

		// Token: 0x1700A003 RID: 40963
		// (get) Token: 0x06048AA9 RID: 297641 RVA: 0x012B4B41 File Offset: 0x012B2D41
		// (set) Token: 0x06048AAA RID: 297642 RVA: 0x012B4B49 File Offset: 0x012B2D49
		public string userId { get; set; }

		// Token: 0x1700A004 RID: 40964
		// (get) Token: 0x06048AAB RID: 297643 RVA: 0x012B4B52 File Offset: 0x012B2D52
		// (set) Token: 0x06048AAC RID: 297644 RVA: 0x012B4B5A File Offset: 0x012B2D5A
		public string userName { get; set; }

		// Token: 0x1700A005 RID: 40965
		// (get) Token: 0x06048AAD RID: 297645 RVA: 0x012B4B63 File Offset: 0x012B2D63
		// (set) Token: 0x06048AAE RID: 297646 RVA: 0x012B4B6B File Offset: 0x012B2D6B
		public string extendParams { get; set; }

		// Token: 0x1700A006 RID: 40966
		// (get) Token: 0x06048AAF RID: 297647 RVA: 0x012B4B74 File Offset: 0x012B2D74
		// (set) Token: 0x06048AB0 RID: 297648 RVA: 0x012B4B7C File Offset: 0x012B2D7C
		public string channelId { get; set; }

		// Token: 0x1700A007 RID: 40967
		// (get) Token: 0x06048AB1 RID: 297649 RVA: 0x012B4B85 File Offset: 0x012B2D85
		// (set) Token: 0x06048AB2 RID: 297650 RVA: 0x012B4B8D File Offset: 0x012B2D8D
		public string idfv { get; set; }

		// Token: 0x1700A008 RID: 40968
		// (get) Token: 0x06048AB3 RID: 297651 RVA: 0x012B4B96 File Offset: 0x012B2D96
		// (set) Token: 0x06048AB4 RID: 297652 RVA: 0x012B4B9E File Offset: 0x012B2D9E
		public string jyDeviceId { get; set; }
	}

	// Token: 0x020074D9 RID: 29913
	[NullableContext(0)]
	private class ISdkCustomerService
	{
		// Token: 0x04026B4F RID: 158543
		[Nullable(1)]
		public string cuid;

		// Token: 0x04026B50 RID: 158544
		public int isredot;
	}
}
