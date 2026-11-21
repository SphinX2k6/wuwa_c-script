using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000306 RID: 774
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkMacGlobal : PlatformSdkBase
{
	// Token: 0x06002C89 RID: 11401 RVA: 0x001099B4 File Offset: 0x00107BB4
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		if (KuroSdkController.Instance.CanUseSdk() && UKuroLauncherLibrary.IsFirstIntoLauncher())
		{
			UKuroSDKManager.PostSplashScreenEndSuccess();
		}
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x00109A09 File Offset: 0x00107C09
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x00109A38 File Offset: 0x00107C38
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkMacGlobal.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkMacGlobal.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x00109A70 File Offset: 0x00107C70
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		OpenCustomerServiceParamMac openCustomerServiceParamMac = new OpenCustomerServiceParamMac();
		openCustomerServiceParamMac.islogin = ((instance.IsSdkLoggedIn() > false) ? 1 : 0);
		openCustomerServiceParamMac.from = fromType;
		openCustomerServiceParamMac.RoleId = this.GetCustomServerRoleId();
		openCustomerServiceParamMac.RoleName = instance2.GetAccountName(true);
		openCustomerServiceParamMac.ServerId = (instance.GetServerId() ?? "");
		openCustomerServiceParamMac.ServerName = (instance.GetServerName() ?? "");
		int? playerLevel = instance2.GetPlayerLevel();
		openCustomerServiceParamMac.RoleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "");
		openCustomerServiceParamMac.ExtendsInfo = this.GetCustomServerExtendsInfo();
		UKuroSDKManager.OpenCustomerService(JsonSerializer.Serialize<OpenCustomerServiceParamMac>(openCustomerServiceParamMac, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x00109B38 File Offset: 0x00107D38
	public override string GetChannelId()
	{
		PlatformSdkMacGlobal.IUserInfo cacheUserInfo = this.GetCacheUserInfo();
		if (cacheUserInfo != null && cacheUserInfo.channelId != null)
		{
			return cacheUserInfo.channelId;
		}
		return "";
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x00109B64 File Offset: 0x00107D64
	private PlatformSdkMacGlobal.IUserInfo GetCacheUserInfo()
	{
		if (this.CacheUserInfo == null)
		{
			string sdkParams = UKuroSDKManager.GetSdkParams("");
			this.CacheUserInfo = Json.Parse<PlatformSdkMacGlobal.UserInfo>(sdkParams, null);
		}
		return this.CacheUserInfo;
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x00109B98 File Offset: 0x00107D98
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

	// Token: 0x06002C90 RID: 11408 RVA: 0x00109BE0 File Offset: 0x00107DE0
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

	// Token: 0x06002C91 RID: 11409 RVA: 0x00109C28 File Offset: 0x00107E28
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
			PlatformSdkMacGlobal.IQueryProduct queryProduct = Json.Parse<PlatformSdkMacGlobal.IQueryProduct>(array[1], null);
			if (((queryProduct != null) ? queryProduct.products : null) != null)
			{
				foreach (PlatformSdkMacGlobal.QueryProductContent queryProductContent in queryProduct.products)
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

	// Token: 0x06002C92 RID: 11410 RVA: 0x00109CEC File Offset: 0x00107EEC
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		ISDKPayRole sdkPayRoleInfo = this.GetSdkPayRoleInfo();
		string paymentInfo2 = this.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroPay;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, paymentInfo2);
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x00109D14 File Offset: 0x00107F14
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

	// Token: 0x06002C94 RID: 11412 RVA: 0x00109DD8 File Offset: 0x00107FD8
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

	// Token: 0x06002C95 RID: 11413 RVA: 0x00109EC4 File Offset: 0x001080C4
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

	// Token: 0x06002C96 RID: 11414 RVA: 0x00109F41 File Offset: 0x00108141
	public override void SdkExit()
	{
		UKuroSDKManager.ShowExitGameDialog();
	}

	// Token: 0x04002944 RID: 10564
	private const int WEBVIEWCD = 5000;

	// Token: 0x04002945 RID: 10565
	[Nullable(2)]
	private PlatformSdkMacGlobal.IUserInfo CacheUserInfo;

	// Token: 0x02006671 RID: 26225
	private interface IUserInfo
	{
		// Token: 0x170077A7 RID: 30631
		// (get) Token: 0x0603EF1D RID: 257821
		// (set) Token: 0x0603EF1E RID: 257822
		string token { get; set; }

		// Token: 0x170077A8 RID: 30632
		// (get) Token: 0x0603EF1F RID: 257823
		// (set) Token: 0x0603EF20 RID: 257824
		string userId { get; set; }

		// Token: 0x170077A9 RID: 30633
		// (get) Token: 0x0603EF21 RID: 257825
		// (set) Token: 0x0603EF22 RID: 257826
		string userName { get; set; }

		// Token: 0x170077AA RID: 30634
		// (get) Token: 0x0603EF23 RID: 257827
		// (set) Token: 0x0603EF24 RID: 257828
		string extendParams { get; set; }

		// Token: 0x170077AB RID: 30635
		// (get) Token: 0x0603EF25 RID: 257829
		// (set) Token: 0x0603EF26 RID: 257830
		string channelId { get; set; }
	}

	// Token: 0x02006672 RID: 26226
	[Nullable(0)]
	private class UserInfo : PlatformSdkMacGlobal.IUserInfo
	{
		// Token: 0x170077AC RID: 30636
		// (get) Token: 0x0603EF27 RID: 257831 RVA: 0x01257FCD File Offset: 0x012561CD
		// (set) Token: 0x0603EF28 RID: 257832 RVA: 0x01257FD5 File Offset: 0x012561D5
		public string token { get; set; } = "";

		// Token: 0x170077AD RID: 30637
		// (get) Token: 0x0603EF29 RID: 257833 RVA: 0x01257FDE File Offset: 0x012561DE
		// (set) Token: 0x0603EF2A RID: 257834 RVA: 0x01257FE6 File Offset: 0x012561E6
		public string userId { get; set; } = "";

		// Token: 0x170077AE RID: 30638
		// (get) Token: 0x0603EF2B RID: 257835 RVA: 0x01257FEF File Offset: 0x012561EF
		// (set) Token: 0x0603EF2C RID: 257836 RVA: 0x01257FF7 File Offset: 0x012561F7
		public string userName { get; set; } = "";

		// Token: 0x170077AF RID: 30639
		// (get) Token: 0x0603EF2D RID: 257837 RVA: 0x01258000 File Offset: 0x01256200
		// (set) Token: 0x0603EF2E RID: 257838 RVA: 0x01258008 File Offset: 0x01256208
		public string extendParams { get; set; } = "";

		// Token: 0x170077B0 RID: 30640
		// (get) Token: 0x0603EF2F RID: 257839 RVA: 0x01258011 File Offset: 0x01256211
		// (set) Token: 0x0603EF30 RID: 257840 RVA: 0x01258019 File Offset: 0x01256219
		public string channelId { get; set; } = "";
	}

	// Token: 0x02006673 RID: 26227
	[NullableContext(0)]
	private class IQueryProduct
	{
		// Token: 0x04021EA0 RID: 138912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public PlatformSdkMacGlobal.QueryProductContent[] products;

		// Token: 0x04021EA1 RID: 138913
		public int code;

		// Token: 0x04021EA2 RID: 138914
		[Nullable(1)]
		public string msg = "";
	}

	// Token: 0x02006674 RID: 26228
	private interface IQueryProductContent
	{
		// Token: 0x170077B1 RID: 30641
		// (get) Token: 0x0603EF33 RID: 257843
		// (set) Token: 0x0603EF34 RID: 257844
		string goodsId { get; set; }

		// Token: 0x170077B2 RID: 30642
		// (get) Token: 0x0603EF35 RID: 257845
		// (set) Token: 0x0603EF36 RID: 257846
		string name { get; set; }

		// Token: 0x170077B3 RID: 30643
		// (get) Token: 0x0603EF37 RID: 257847
		// (set) Token: 0x0603EF38 RID: 257848
		string desc { get; set; }

		// Token: 0x170077B4 RID: 30644
		// (get) Token: 0x0603EF39 RID: 257849
		// (set) Token: 0x0603EF3A RID: 257850
		string currency { get; set; }

		// Token: 0x170077B5 RID: 30645
		// (get) Token: 0x0603EF3B RID: 257851
		// (set) Token: 0x0603EF3C RID: 257852
		float price { get; set; }
	}

	// Token: 0x02006675 RID: 26229
	[Nullable(0)]
	private class QueryProductContent : PlatformSdkMacGlobal.IQueryProductContent
	{
		// Token: 0x170077B6 RID: 30646
		// (get) Token: 0x0603EF3D RID: 257853 RVA: 0x01258074 File Offset: 0x01256274
		// (set) Token: 0x0603EF3E RID: 257854 RVA: 0x0125807C File Offset: 0x0125627C
		public string goodsId { get; set; } = "";

		// Token: 0x170077B7 RID: 30647
		// (get) Token: 0x0603EF3F RID: 257855 RVA: 0x01258085 File Offset: 0x01256285
		// (set) Token: 0x0603EF40 RID: 257856 RVA: 0x0125808D File Offset: 0x0125628D
		public string name { get; set; } = "";

		// Token: 0x170077B8 RID: 30648
		// (get) Token: 0x0603EF41 RID: 257857 RVA: 0x01258096 File Offset: 0x01256296
		// (set) Token: 0x0603EF42 RID: 257858 RVA: 0x0125809E File Offset: 0x0125629E
		public string desc { get; set; } = "";

		// Token: 0x170077B9 RID: 30649
		// (get) Token: 0x0603EF43 RID: 257859 RVA: 0x012580A7 File Offset: 0x012562A7
		// (set) Token: 0x0603EF44 RID: 257860 RVA: 0x012580AF File Offset: 0x012562AF
		public string currency { get; set; } = "";

		// Token: 0x170077BA RID: 30650
		// (get) Token: 0x0603EF45 RID: 257861 RVA: 0x012580B8 File Offset: 0x012562B8
		// (set) Token: 0x0603EF46 RID: 257862 RVA: 0x012580C0 File Offset: 0x012562C0
		public float price { get; set; }
	}

	// Token: 0x02006676 RID: 26230
	[NullableContext(0)]
	private class ISdkCustomerService
	{
		// Token: 0x04021EA8 RID: 138920
		[Nullable(1)]
		public string cuid = "";

		// Token: 0x04021EA9 RID: 138921
		public int isredot;
	}
}
