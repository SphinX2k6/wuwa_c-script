using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;

// Token: 0x02000E0E RID: 3598
[NullableContext(1)]
[Nullable(0)]
public class KuroSdkControllerTool
{
	// Token: 0x0600567D RID: 22141 RVA: 0x000F98D4 File Offset: 0x000F7AD4
	public static string GetCreateRoleInfo()
	{
		RoleInfoSdk createRoleInfoData = KuroSdkControllerTool.GetCreateRoleInfoData();
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		return JsonSerializer.Serialize<RoleInfoSdk>(createRoleInfoData, options);
	}

	// Token: 0x0600567E RID: 22142 RVA: 0x000F9904 File Offset: 0x000F7B04
	public static RoleInfoSdk GetCreateRoleInfoData()
	{
		LoginModel instance = LoginModel.Instance;
		RoleInfoSdk roleInfoSdk = new RoleInfoSdk();
		roleInfoSdk.RoleId = KuroSdkControllerTool.GetRoleId();
		roleInfoSdk.RoleName = (instance.GetPlayerName() ?? "");
		roleInfoSdk.ServerId = (instance.GetServerId() ?? "");
		roleInfoSdk.ServerName = (instance.GetServerName() ?? "");
		roleInfoSdk.RoleLevel = "1";
		roleInfoSdk.VipLevel = "0";
		roleInfoSdk.PartyName = " ";
		roleInfoSdk.RoleCreateTime = ((instance.GetCreatePlayerTime() != 0.0) ? instance.GetCreatePlayerTime() : "");
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
		return roleInfoSdk;
	}

	// Token: 0x0600567F RID: 22143 RVA: 0x000F9A54 File Offset: 0x000F7C54
	private static string GetRoleId()
	{
		if (PlayerInfoModel.Instance.GetId() != null)
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int num = 0;
			if (!(id.GetValueOrDefault() == num & id != null))
			{
				return PlayerInfoModel.Instance.GetId().ToString();
			}
		}
		LoginModel.Instance.GetCreatePlayerId();
		return LoginModel.Instance.GetCreatePlayerId().ToString();
	}

	// Token: 0x06005680 RID: 22144 RVA: 0x000F9ACC File Offset: 0x000F7CCC
	public static RoleInfoSdk GetRoleInfoData()
	{
		FunctionModel instance = FunctionModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		RoleInfoSdk roleInfoSdk = new RoleInfoSdk();
		roleInfoSdk.RoleId = KuroSdkControllerTool.GetRoleId();
		roleInfoSdk.RoleName = (instance.GetPlayerName() ?? "");
		roleInfoSdk.ServerId = (instance2.GetServerId() ?? "");
		roleInfoSdk.ServerName = (instance2.GetServerName() ?? "");
		int? playerLevel = instance.GetPlayerLevel();
		roleInfoSdk.RoleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1");
		roleInfoSdk.VipLevel = "0";
		roleInfoSdk.PartyName = " ";
		roleInfoSdk.RoleCreateTime = "";
		roleInfoSdk.BalanceLevelOne = instance.GetPlayerCashCoin();
		roleInfoSdk.BalanceLevelTwo = "0";
		roleInfoSdk.SumPay = "0";
		roleInfoSdk.gameName = "AKI";
		roleInfoSdk.gameVersion = "0.0.0";
		roleInfoSdk.RoleAvatar = "";
		SdkLoginConfig sdkLoginConfig = instance2.GetSdkLoginConfig();
		roleInfoSdk.ChannelUserId = ((((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) != null) ? instance2.GetSdkLoginConfig().Uid.ToString() : "0");
		SdkLoginConfig sdkLoginConfig2 = instance2.GetSdkLoginConfig();
		roleInfoSdk.GameUserId = ((((sdkLoginConfig2 != null) ? sdkLoginConfig2.UserName : null) != null) ? instance2.GetSdkLoginConfig().UserName.ToString() : "0");
		return roleInfoSdk;
	}

	// Token: 0x06005681 RID: 22145 RVA: 0x000F9C30 File Offset: 0x000F7E30
	public static string GetRoleInfo()
	{
		RoleInfoSdk roleInfoData = KuroSdkControllerTool.GetRoleInfoData();
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		return JsonSerializer.Serialize<RoleInfoSdk>(roleInfoData, options);
	}

	// Token: 0x06005682 RID: 22146 RVA: 0x000F9C60 File Offset: 0x000F7E60
	public static string GetPaymentInfo(ISDKPayment payment, ISDKPayRole roleInfo)
	{
		if (Info.Instance.PlatformType != ESourcePlatformType.Mac && Info.Instance.PlatformType != ESourcePlatformType.IOS && !CloudGameManager.Instance.IsCloudGame)
		{
			string text = JsonSerializer.Serialize<SdkPayObject>(new SdkPayObject
			{
				RoleInfo = roleInfo,
				OrderInfo = payment
			}, KuroSdkJsonOptions.Unescaped);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "SdkJson";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return text ?? "";
		}
		PayInfoMacIos payInfoMacIos = new PayInfoMacIos();
		payInfoMacIos.RoleId = roleInfo.roleId.ToString();
		payInfoMacIos.RoleName = roleInfo.roleName.ToString();
		payInfoMacIos.ServerId = roleInfo.serverId.ToString();
		payInfoMacIos.ServerName = roleInfo.serverName.ToString();
		payInfoMacIos.CpOrder = payment.cpOrderId.ToString();
		payInfoMacIos.CallbackUrl = payment.callbackUrl.ToString();
		payInfoMacIos.GamePropID = payment.product_id.ToString();
		payInfoMacIos.GoodsName = payment.goodsName.ToString();
		payInfoMacIos.GoodsDesc = payment.goodsDesc.ToString();
		payInfoMacIos.Price = payment.price.ToString();
		payInfoMacIos.GoodsCurrency = "";
		if (CloudGameManager.Instance.IsCloudGame)
		{
			JsonSerializerOptions options = new JsonSerializerOptions
			{
				IncludeFields = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			};
			return JsonSerializer.Serialize<PayInfoMacIos>(payInfoMacIos, options) ?? "";
		}
		return JsonSerializer.Serialize<PayInfoMacIos>(payInfoMacIos, KuroSdkJsonOptions.Unescaped) ?? "";
	}

	// Token: 0x06005683 RID: 22147 RVA: 0x000F9DEC File Offset: 0x000F7FEC
	public static ISDKPayment GetSdkPayProduct(int payId, string orderId, string name, string desc, string callBackUrl)
	{
		int? num;
		string extraParams = (PlayerInfoModel.Instance.GetId() != null) ? num.GetValueOrDefault().ToString() : null;
		string payIdAmount = RechargeModel.Instance.GetPayIdAmount(payId);
		string payIdProductId = RechargeModel.Instance.GetPayIdProductId(payId);
		return new SDKPayment
		{
			product_id = payIdProductId,
			cpOrderId = orderId,
			price = payIdAmount,
			goodsName = name,
			goodsDesc = desc,
			extraParams = extraParams,
			callbackUrl = callBackUrl,
			currency = ""
		};
	}

	// Token: 0x06005684 RID: 22148 RVA: 0x000F9E80 File Offset: 0x000F8080
	public static ISDKPayRole GetSdkPayRoleInfo()
	{
		FunctionModel instance = FunctionModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		int? playerLevel = instance.GetPlayerLevel();
		return new SDKPayRole
		{
			roleId = KuroSdkControllerTool.GetRoleId(),
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

	// Token: 0x06005685 RID: 22149 RVA: 0x000F9F44 File Offset: 0x000F8144
	[return: Nullable(2)]
	public static string GetSdkOpenUrlWndInfo(string title, string url)
	{
		OpenSdkUrlWndParam openSdkUrlWndParam = new OpenSdkUrlWndParam();
		openSdkUrlWndParam.title = title;
		openSdkUrlWndParam.wndUrl = url;
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
		string text = JsonSerializer.Serialize<OpenSdkUrlWndParam>(openSdkUrlWndParam, options);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SdkJson";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text ?? "");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return text;
	}
}
