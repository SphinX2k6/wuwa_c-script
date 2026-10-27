using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000E51 RID: 3665
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkMacGlobal : PlatformSdkBase
{
	// Token: 0x060058F3 RID: 22771 RVA: 0x00101D40 File Offset: 0x000FFF40
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

	// Token: 0x060058F4 RID: 22772 RVA: 0x00101D95 File Offset: 0x000FFF95
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x00101DC4 File Offset: 0x000FFFC4
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkMacGlobal.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkMacGlobal.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x060058F6 RID: 22774 RVA: 0x00101DFC File Offset: 0x000FFFFC
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

	// Token: 0x060058F7 RID: 22775 RVA: 0x00101EC4 File Offset: 0x001000C4
	public override string GetChannelId()
	{
		PlatformSdkMacGlobal.IUserInfo cacheUserInfo = this.GetCacheUserInfo();
		if (cacheUserInfo != null && cacheUserInfo.channelId != null)
		{
			return cacheUserInfo.channelId;
		}
		return "";
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x00101EF0 File Offset: 0x001000F0
	private PlatformSdkMacGlobal.IUserInfo GetCacheUserInfo()
	{
		if (this.CacheUserInfo == null)
		{
			string sdkParams = UKuroSDKManager.GetSdkParams("");
			this.CacheUserInfo = Json.Parse<PlatformSdkMacGlobal.UserInfo>(sdkParams, null);
		}
		return this.CacheUserInfo;
	}

	// Token: 0x060058F9 RID: 22777 RVA: 0x00101F24 File Offset: 0x00100124
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

	// Token: 0x060058FA RID: 22778 RVA: 0x00101F6C File Offset: 0x0010016C
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

	// Token: 0x060058FB RID: 22779 RVA: 0x00101FB4 File Offset: 0x001001B4
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

	// Token: 0x060058FC RID: 22780 RVA: 0x00102078 File Offset: 0x00100278
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		ISDKPayRole sdkPayRoleInfo = this.GetSdkPayRoleInfo();
		string paymentInfo2 = this.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
		UKuroSDKEventType ukuroSDKEventType = UKuroSDKEventType.KuroPay;
		UKuroSDKManager.KuroSDKEvent(ukuroSDKEventType, paymentInfo2);
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x001020A0 File Offset: 0x001002A0
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

	// Token: 0x060058FE RID: 22782 RVA: 0x00102164 File Offset: 0x00100364
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

	// Token: 0x060058FF RID: 22783 RVA: 0x00102250 File Offset: 0x00100450
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

	// Token: 0x06005900 RID: 22784 RVA: 0x001022CD File Offset: 0x001004CD
	public override void SdkExit()
	{
		UKuroSDKManager.ShowExitGameDialog();
	}

	// Token: 0x040028A9 RID: 10409
	private const int WEBVIEWCD = 5000;

	// Token: 0x040028AA RID: 10410
	[Nullable(2)]
	private PlatformSdkMacGlobal.IUserInfo CacheUserInfo;

	// Token: 0x020074DD RID: 29917
	private interface IUserInfo
	{
		// Token: 0x1700A009 RID: 40969
		// (get) Token: 0x06048ABD RID: 297661
		// (set) Token: 0x06048ABE RID: 297662
		string token { get; set; }

		// Token: 0x1700A00A RID: 40970
		// (get) Token: 0x06048ABF RID: 297663
		// (set) Token: 0x06048AC0 RID: 297664
		string userId { get; set; }

		// Token: 0x1700A00B RID: 40971
		// (get) Token: 0x06048AC1 RID: 297665
		// (set) Token: 0x06048AC2 RID: 297666
		string userName { get; set; }

		// Token: 0x1700A00C RID: 40972
		// (get) Token: 0x06048AC3 RID: 297667
		// (set) Token: 0x06048AC4 RID: 297668
		string extendParams { get; set; }

		// Token: 0x1700A00D RID: 40973
		// (get) Token: 0x06048AC5 RID: 297669
		// (set) Token: 0x06048AC6 RID: 297670
		string channelId { get; set; }
	}

	// Token: 0x020074DE RID: 29918
	[Nullable(0)]
	private class UserInfo : PlatformSdkMacGlobal.IUserInfo
	{
		// Token: 0x1700A00E RID: 40974
		// (get) Token: 0x06048AC7 RID: 297671 RVA: 0x012B4C65 File Offset: 0x012B2E65
		// (set) Token: 0x06048AC8 RID: 297672 RVA: 0x012B4C6D File Offset: 0x012B2E6D
		public string token { get; set; } = "";

		// Token: 0x1700A00F RID: 40975
		// (get) Token: 0x06048AC9 RID: 297673 RVA: 0x012B4C76 File Offset: 0x012B2E76
		// (set) Token: 0x06048ACA RID: 297674 RVA: 0x012B4C7E File Offset: 0x012B2E7E
		public string userId { get; set; } = "";

		// Token: 0x1700A010 RID: 40976
		// (get) Token: 0x06048ACB RID: 297675 RVA: 0x012B4C87 File Offset: 0x012B2E87
		// (set) Token: 0x06048ACC RID: 297676 RVA: 0x012B4C8F File Offset: 0x012B2E8F
		public string userName { get; set; } = "";

		// Token: 0x1700A011 RID: 40977
		// (get) Token: 0x06048ACD RID: 297677 RVA: 0x012B4C98 File Offset: 0x012B2E98
		// (set) Token: 0x06048ACE RID: 297678 RVA: 0x012B4CA0 File Offset: 0x012B2EA0
		public string extendParams { get; set; } = "";

		// Token: 0x1700A012 RID: 40978
		// (get) Token: 0x06048ACF RID: 297679 RVA: 0x012B4CA9 File Offset: 0x012B2EA9
		// (set) Token: 0x06048AD0 RID: 297680 RVA: 0x012B4CB1 File Offset: 0x012B2EB1
		public string channelId { get; set; } = "";
	}

	// Token: 0x020074DF RID: 29919
	[NullableContext(0)]
	private class IQueryProduct
	{
		// Token: 0x04026B5B RID: 158555
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public PlatformSdkMacGlobal.QueryProductContent[] products;

		// Token: 0x04026B5C RID: 158556
		public int code;

		// Token: 0x04026B5D RID: 158557
		[Nullable(1)]
		public string msg = "";
	}

	// Token: 0x020074E0 RID: 29920
	private interface IQueryProductContent
	{
		// Token: 0x1700A013 RID: 40979
		// (get) Token: 0x06048AD3 RID: 297683
		// (set) Token: 0x06048AD4 RID: 297684
		string goodsId { get; set; }

		// Token: 0x1700A014 RID: 40980
		// (get) Token: 0x06048AD5 RID: 297685
		// (set) Token: 0x06048AD6 RID: 297686
		string name { get; set; }

		// Token: 0x1700A015 RID: 40981
		// (get) Token: 0x06048AD7 RID: 297687
		// (set) Token: 0x06048AD8 RID: 297688
		string desc { get; set; }

		// Token: 0x1700A016 RID: 40982
		// (get) Token: 0x06048AD9 RID: 297689
		// (set) Token: 0x06048ADA RID: 297690
		string currency { get; set; }

		// Token: 0x1700A017 RID: 40983
		// (get) Token: 0x06048ADB RID: 297691
		// (set) Token: 0x06048ADC RID: 297692
		float price { get; set; }
	}

	// Token: 0x020074E1 RID: 29921
	[Nullable(0)]
	private class QueryProductContent : PlatformSdkMacGlobal.IQueryProductContent
	{
		// Token: 0x1700A018 RID: 40984
		// (get) Token: 0x06048ADD RID: 297693 RVA: 0x012B4D0C File Offset: 0x012B2F0C
		// (set) Token: 0x06048ADE RID: 297694 RVA: 0x012B4D14 File Offset: 0x012B2F14
		public string goodsId { get; set; } = "";

		// Token: 0x1700A019 RID: 40985
		// (get) Token: 0x06048ADF RID: 297695 RVA: 0x012B4D1D File Offset: 0x012B2F1D
		// (set) Token: 0x06048AE0 RID: 297696 RVA: 0x012B4D25 File Offset: 0x012B2F25
		public string name { get; set; } = "";

		// Token: 0x1700A01A RID: 40986
		// (get) Token: 0x06048AE1 RID: 297697 RVA: 0x012B4D2E File Offset: 0x012B2F2E
		// (set) Token: 0x06048AE2 RID: 297698 RVA: 0x012B4D36 File Offset: 0x012B2F36
		public string desc { get; set; } = "";

		// Token: 0x1700A01B RID: 40987
		// (get) Token: 0x06048AE3 RID: 297699 RVA: 0x012B4D3F File Offset: 0x012B2F3F
		// (set) Token: 0x06048AE4 RID: 297700 RVA: 0x012B4D47 File Offset: 0x012B2F47
		public string currency { get; set; } = "";

		// Token: 0x1700A01C RID: 40988
		// (get) Token: 0x06048AE5 RID: 297701 RVA: 0x012B4D50 File Offset: 0x012B2F50
		// (set) Token: 0x06048AE6 RID: 297702 RVA: 0x012B4D58 File Offset: 0x012B2F58
		public float price { get; set; }
	}

	// Token: 0x020074E2 RID: 29922
	[NullableContext(0)]
	private class ISdkCustomerService
	{
		// Token: 0x04026B63 RID: 158563
		[Nullable(1)]
		public string cuid = "";

		// Token: 0x04026B64 RID: 158564
		public int isredot;
	}
}
