using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000304 RID: 772
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkIosGlobal : PlatformSdkBase
{
	// Token: 0x06002C65 RID: 11365 RVA: 0x00108E0C File Offset: 0x0010700C
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("Sdkidfv", this.Getidfv());
		FCrashSightProxy.SetCustomData("SdkJyId", this.GetJyDid());
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x06002C66 RID: 11366 RVA: 0x00108E6C File Offset: 0x0010706C
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(this.AnnounceRedPointCallBack);
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06002C67 RID: 11367 RVA: 0x00108EC8 File Offset: 0x001070C8
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkIosGlobal.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkIosGlobal.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002C68 RID: 11368 RVA: 0x00108F00 File Offset: 0x00107100
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

	// Token: 0x06002C69 RID: 11369 RVA: 0x00108F94 File Offset: 0x00107194
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

	// Token: 0x06002C6A RID: 11370 RVA: 0x00108FC4 File Offset: 0x001071C4
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

	// Token: 0x06002C6B RID: 11371 RVA: 0x00108FF4 File Offset: 0x001071F4
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

	// Token: 0x06002C6C RID: 11372 RVA: 0x00109024 File Offset: 0x00107224
	private PlatformSdkIosGlobal.IUserInfo GetCacheUserInfo()
	{
		if (this.CacheUserInfo == null)
		{
			string sdkParams = UKuroSDKManager.GetSdkParams("");
			this.CacheUserInfo = Json.Parse<PlatformSdkIosGlobal.UserInfo>(sdkParams, null);
		}
		return this.CacheUserInfo;
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x00109058 File Offset: 0x00107258
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

	// Token: 0x06002C6E RID: 11374 RVA: 0x001090A0 File Offset: 0x001072A0
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

	// Token: 0x06002C6F RID: 11375 RVA: 0x00109160 File Offset: 0x00107360
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

	// Token: 0x06002C70 RID: 11376 RVA: 0x0010921C File Offset: 0x0010741C
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		ISDKPayRole sdkPayRoleInfo = this.GetSdkPayRoleInfo();
		string paymentInfo2 = this.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroPay;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, paymentInfo2);
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x00109244 File Offset: 0x00107444
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

	// Token: 0x06002C72 RID: 11378 RVA: 0x00109308 File Offset: 0x00107508
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

	// Token: 0x06002C73 RID: 11379 RVA: 0x001093F4 File Offset: 0x001075F4
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002C74 RID: 11380 RVA: 0x00109410 File Offset: 0x00107610
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x0010942C File Offset: 0x0010762C
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

	// Token: 0x06002C76 RID: 11382 RVA: 0x00109474 File Offset: 0x00107674
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

	// Token: 0x06002C77 RID: 11383 RVA: 0x00109518 File Offset: 0x00107718
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

	// Token: 0x06002C78 RID: 11384 RVA: 0x00109595 File Offset: 0x00107795
	public override void OpenExternalUrl(string url)
	{
		UKuroSDKManager.OpenDefaultWebView(url);
	}

	// Token: 0x06002C79 RID: 11385 RVA: 0x0010959D File Offset: 0x0010779D
	protected override int CurrentPlatformYearReviewTime()
	{
		return 3;
	}

	// Token: 0x06002C7A RID: 11386 RVA: 0x001095A0 File Offset: 0x001077A0
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

	// Token: 0x06002C7B RID: 11387 RVA: 0x001095CC File Offset: 0x001077CC
	protected override void BindExternalEvent()
	{
		this.KuroBindExternalLoginResult();
		base.KuroBindExternalAchievementWriteResult();
		base.KuroBindExternalAchievementQueryResult();
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x001095E0 File Offset: 0x001077E0
	public override void UnlockSdkTrophy(string id)
	{
		this.UpdateExternalAchievementProgress(id, 100);
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x001095EC File Offset: 0x001077EC
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
		UKuroSDKManager.WriteExternalAchievements(Json.Stringify(new SdkAchievementData
		{
			Achievements = new SdkAchievementContentData[]
			{
				sdkAchievementContentData
			}
		}, null) ?? "");
	}

	// Token: 0x0400293F RID: 10559
	private const int WEBVIEWCD = 5000;

	// Token: 0x04002940 RID: 10560
	private const int MAXREVIEWTIME = 3;

	// Token: 0x04002941 RID: 10561
	[Nullable(2)]
	private PlatformSdkIosGlobal.IUserInfo CacheUserInfo;

	// Token: 0x04002942 RID: 10562
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

	// Token: 0x02006664 RID: 26212
	private interface ISharePlatformContent
	{
		// Token: 0x17007785 RID: 30597
		// (get) Token: 0x0603EECD RID: 257741
		// (set) Token: 0x0603EECE RID: 257742
		string iconUrl { get; set; }

		// Token: 0x17007786 RID: 30598
		// (get) Token: 0x0603EECF RID: 257743
		// (set) Token: 0x0603EED0 RID: 257744
		string platform { get; set; }
	}

	// Token: 0x02006665 RID: 26213
	[Nullable(0)]
	private class SharePlatformContent : PlatformSdkIosGlobal.ISharePlatformContent
	{
		// Token: 0x17007787 RID: 30599
		// (get) Token: 0x0603EED1 RID: 257745 RVA: 0x01257DCE File Offset: 0x01255FCE
		// (set) Token: 0x0603EED2 RID: 257746 RVA: 0x01257DD6 File Offset: 0x01255FD6
		public string iconUrl { get; set; }

		// Token: 0x17007788 RID: 30600
		// (get) Token: 0x0603EED3 RID: 257747 RVA: 0x01257DDF File Offset: 0x01255FDF
		// (set) Token: 0x0603EED4 RID: 257748 RVA: 0x01257DE7 File Offset: 0x01255FE7
		public string platform { get; set; }
	}

	// Token: 0x02006666 RID: 26214
	private interface ISharePlatform
	{
		// Token: 0x17007789 RID: 30601
		// (get) Token: 0x0603EED6 RID: 257750
		// (set) Token: 0x0603EED7 RID: 257751
		string KROVERSEA_SDK_KEY_DATA { get; set; }

		// Token: 0x1700778A RID: 30602
		// (get) Token: 0x0603EED8 RID: 257752
		// (set) Token: 0x0603EED9 RID: 257753
		string KROVERSEA_SDK_KEY_REASON { get; set; }

		// Token: 0x1700778B RID: 30603
		// (get) Token: 0x0603EEDA RID: 257754
		// (set) Token: 0x0603EEDB RID: 257755
		int KROVERSEA_SDK_KEY_RESULT { get; set; }
	}

	// Token: 0x02006667 RID: 26215
	[Nullable(0)]
	private class SharePlatform : PlatformSdkIosGlobal.ISharePlatform
	{
		// Token: 0x1700778C RID: 30604
		// (get) Token: 0x0603EEDC RID: 257756 RVA: 0x01257DF8 File Offset: 0x01255FF8
		// (set) Token: 0x0603EEDD RID: 257757 RVA: 0x01257E00 File Offset: 0x01256000
		public string KROVERSEA_SDK_KEY_DATA { get; set; }

		// Token: 0x1700778D RID: 30605
		// (get) Token: 0x0603EEDE RID: 257758 RVA: 0x01257E09 File Offset: 0x01256009
		// (set) Token: 0x0603EEDF RID: 257759 RVA: 0x01257E11 File Offset: 0x01256011
		public string KROVERSEA_SDK_KEY_REASON { get; set; }

		// Token: 0x1700778E RID: 30606
		// (get) Token: 0x0603EEE0 RID: 257760 RVA: 0x01257E1A File Offset: 0x0125601A
		// (set) Token: 0x0603EEE1 RID: 257761 RVA: 0x01257E22 File Offset: 0x01256022
		public int KROVERSEA_SDK_KEY_RESULT { get; set; }
	}

	// Token: 0x02006668 RID: 26216
	[NullableContext(0)]
	private class IQueryProduct
	{
		// Token: 0x04021E85 RID: 138885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public PlatformSdkIosGlobal.QueryProductContent[] products;

		// Token: 0x04021E86 RID: 138886
		public int code;

		// Token: 0x04021E87 RID: 138887
		[Nullable(1)]
		public string msg;
	}

	// Token: 0x02006669 RID: 26217
	private interface IQueryProductContent
	{
		// Token: 0x1700778F RID: 30607
		// (get) Token: 0x0603EEE4 RID: 257764
		// (set) Token: 0x0603EEE5 RID: 257765
		string goodsId { get; set; }

		// Token: 0x17007790 RID: 30608
		// (get) Token: 0x0603EEE6 RID: 257766
		// (set) Token: 0x0603EEE7 RID: 257767
		string name { get; set; }

		// Token: 0x17007791 RID: 30609
		// (get) Token: 0x0603EEE8 RID: 257768
		// (set) Token: 0x0603EEE9 RID: 257769
		string desc { get; set; }

		// Token: 0x17007792 RID: 30610
		// (get) Token: 0x0603EEEA RID: 257770
		// (set) Token: 0x0603EEEB RID: 257771
		string currency { get; set; }

		// Token: 0x17007793 RID: 30611
		// (get) Token: 0x0603EEEC RID: 257772
		// (set) Token: 0x0603EEED RID: 257773
		float price { get; set; }
	}

	// Token: 0x0200666A RID: 26218
	[Nullable(0)]
	private class QueryProductContent : PlatformSdkIosGlobal.IQueryProductContent
	{
		// Token: 0x17007794 RID: 30612
		// (get) Token: 0x0603EEEE RID: 257774 RVA: 0x01257E3B File Offset: 0x0125603B
		// (set) Token: 0x0603EEEF RID: 257775 RVA: 0x01257E43 File Offset: 0x01256043
		public string goodsId { get; set; }

		// Token: 0x17007795 RID: 30613
		// (get) Token: 0x0603EEF0 RID: 257776 RVA: 0x01257E4C File Offset: 0x0125604C
		// (set) Token: 0x0603EEF1 RID: 257777 RVA: 0x01257E54 File Offset: 0x01256054
		public string name { get; set; }

		// Token: 0x17007796 RID: 30614
		// (get) Token: 0x0603EEF2 RID: 257778 RVA: 0x01257E5D File Offset: 0x0125605D
		// (set) Token: 0x0603EEF3 RID: 257779 RVA: 0x01257E65 File Offset: 0x01256065
		public string desc { get; set; }

		// Token: 0x17007797 RID: 30615
		// (get) Token: 0x0603EEF4 RID: 257780 RVA: 0x01257E6E File Offset: 0x0125606E
		// (set) Token: 0x0603EEF5 RID: 257781 RVA: 0x01257E76 File Offset: 0x01256076
		public string currency { get; set; }

		// Token: 0x17007798 RID: 30616
		// (get) Token: 0x0603EEF6 RID: 257782 RVA: 0x01257E7F File Offset: 0x0125607F
		// (set) Token: 0x0603EEF7 RID: 257783 RVA: 0x01257E87 File Offset: 0x01256087
		public float price { get; set; }
	}

	// Token: 0x0200666B RID: 26219
	private interface IUserInfo
	{
		// Token: 0x17007799 RID: 30617
		// (get) Token: 0x0603EEF9 RID: 257785
		// (set) Token: 0x0603EEFA RID: 257786
		string token { get; set; }

		// Token: 0x1700779A RID: 30618
		// (get) Token: 0x0603EEFB RID: 257787
		// (set) Token: 0x0603EEFC RID: 257788
		string userId { get; set; }

		// Token: 0x1700779B RID: 30619
		// (get) Token: 0x0603EEFD RID: 257789
		// (set) Token: 0x0603EEFE RID: 257790
		string userName { get; set; }

		// Token: 0x1700779C RID: 30620
		// (get) Token: 0x0603EEFF RID: 257791
		// (set) Token: 0x0603EF00 RID: 257792
		string extendParams { get; set; }

		// Token: 0x1700779D RID: 30621
		// (get) Token: 0x0603EF01 RID: 257793
		// (set) Token: 0x0603EF02 RID: 257794
		string channelId { get; set; }

		// Token: 0x1700779E RID: 30622
		// (get) Token: 0x0603EF03 RID: 257795
		// (set) Token: 0x0603EF04 RID: 257796
		string idfv { get; set; }

		// Token: 0x1700779F RID: 30623
		// (get) Token: 0x0603EF05 RID: 257797
		// (set) Token: 0x0603EF06 RID: 257798
		string jyDeviceId { get; set; }
	}

	// Token: 0x0200666C RID: 26220
	[Nullable(0)]
	private class UserInfo : PlatformSdkIosGlobal.IUserInfo
	{
		// Token: 0x170077A0 RID: 30624
		// (get) Token: 0x0603EF07 RID: 257799 RVA: 0x01257E98 File Offset: 0x01256098
		// (set) Token: 0x0603EF08 RID: 257800 RVA: 0x01257EA0 File Offset: 0x012560A0
		public string token { get; set; }

		// Token: 0x170077A1 RID: 30625
		// (get) Token: 0x0603EF09 RID: 257801 RVA: 0x01257EA9 File Offset: 0x012560A9
		// (set) Token: 0x0603EF0A RID: 257802 RVA: 0x01257EB1 File Offset: 0x012560B1
		public string userId { get; set; }

		// Token: 0x170077A2 RID: 30626
		// (get) Token: 0x0603EF0B RID: 257803 RVA: 0x01257EBA File Offset: 0x012560BA
		// (set) Token: 0x0603EF0C RID: 257804 RVA: 0x01257EC2 File Offset: 0x012560C2
		public string userName { get; set; }

		// Token: 0x170077A3 RID: 30627
		// (get) Token: 0x0603EF0D RID: 257805 RVA: 0x01257ECB File Offset: 0x012560CB
		// (set) Token: 0x0603EF0E RID: 257806 RVA: 0x01257ED3 File Offset: 0x012560D3
		public string extendParams { get; set; }

		// Token: 0x170077A4 RID: 30628
		// (get) Token: 0x0603EF0F RID: 257807 RVA: 0x01257EDC File Offset: 0x012560DC
		// (set) Token: 0x0603EF10 RID: 257808 RVA: 0x01257EE4 File Offset: 0x012560E4
		public string channelId { get; set; }

		// Token: 0x170077A5 RID: 30629
		// (get) Token: 0x0603EF11 RID: 257809 RVA: 0x01257EED File Offset: 0x012560ED
		// (set) Token: 0x0603EF12 RID: 257810 RVA: 0x01257EF5 File Offset: 0x012560F5
		public string idfv { get; set; }

		// Token: 0x170077A6 RID: 30630
		// (get) Token: 0x0603EF13 RID: 257811 RVA: 0x01257EFE File Offset: 0x012560FE
		// (set) Token: 0x0603EF14 RID: 257812 RVA: 0x01257F06 File Offset: 0x01256106
		public string jyDeviceId { get; set; }
	}

	// Token: 0x0200666D RID: 26221
	[NullableContext(0)]
	private class ISdkCustomerService
	{
		// Token: 0x04021E94 RID: 138900
		[Nullable(1)]
		public string cuid;

		// Token: 0x04021E95 RID: 138901
		public int isredot;
	}
}
