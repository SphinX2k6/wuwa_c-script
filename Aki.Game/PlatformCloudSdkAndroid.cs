using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x02000E40 RID: 3648
[NullableContext(1)]
[Nullable(0)]
public class PlatformCloudSdkAndroid : PlatformCloudSdkBase
{
	// Token: 0x060057BF RID: 22463 RVA: 0x000FCD12 File Offset: 0x000FAF12
	protected override void BindSpecialEvent()
	{
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnPostRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.AnnounceRedPointCallBack));
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnCustomerRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.CustomerServiceResultCallBack));
	}

	// Token: 0x060057C0 RID: 22464 RVA: 0x000FCD44 File Offset: 0x000FAF44
	public override void AnnounceRedPointCallBack(string result)
	{
		AndroidSdkRePointSt androidSdkRePointSt = Json.Parse<AndroidSdkRePointSt>(result, null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "公告红点";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", androidSdkRePointSt);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		KuroSdkController.Instance.SetPostWebViewRedPointState(androidSdkRePointSt.showRed);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x060057C1 RID: 22465 RVA: 0x000FCDA4 File Offset: 0x000FAFA4
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
		string text = JsonSerializer.Serialize<OpenCustomerServiceParamAndroid>(openCustomerServiceParamAndroid, KuroSdkJsonOptions.Unescaped);
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "AndroidCustomerService";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", text);
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.OpenCustomerService, text ?? "");
	}

	// Token: 0x060057C2 RID: 22466 RVA: 0x000FCE68 File Offset: 0x000FB068
	public unsafe override void SdkPay(ISDKPayment paymentInfo)
	{
		AndroidSdkPayRole sdkPayRoleInfo = this.GetSdkPayRoleInfo();
		string androidPaymentInfo = this.GetAndroidPaymentInfo(paymentInfo, sdkPayRoleInfo);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "AndroidPayment";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("json", androidPaymentInfo);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("paymentInfo", paymentInfo);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKPay, androidPaymentInfo);
	}

	// Token: 0x060057C3 RID: 22467 RVA: 0x000FCEE8 File Offset: 0x000FB0E8
	private AndroidSdkPayRole GetSdkPayRoleInfo()
	{
		FunctionModel instance = FunctionModel.Instance;
		LoginModel instance2 = LoginModel.Instance;
		AndroidSdkPayRole androidSdkPayRole = new AndroidSdkPayRole();
		androidSdkPayRole.roleId = this.GetRoleId();
		androidSdkPayRole.roleName = (instance.GetPlayerName() ?? "");
		int? playerLevel = instance.GetPlayerLevel();
		androidSdkPayRole.roleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "1");
		androidSdkPayRole.serverId = (instance2.GetServerId() ?? "");
		androidSdkPayRole.serverName = (instance2.GetServerName() ?? "");
		androidSdkPayRole.vipLevel = "0";
		androidSdkPayRole.partyName = " ";
		androidSdkPayRole.setBalanceLevelOne = "0";
		androidSdkPayRole.setBalanceLevelTwo = "0";
		return androidSdkPayRole;
	}

	// Token: 0x060057C4 RID: 22468 RVA: 0x000FCFB4 File Offset: 0x000FB1B4
	private string GetAndroidPaymentInfo(ISDKPayment payment, AndroidSdkPayRole roleInfo)
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
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "SdkJson";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sdkJson", text3);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return text3 ?? "";
	}

	// Token: 0x060057C5 RID: 22469 RVA: 0x000FD0EC File Offset: 0x000FB2EC
	public override void InitializePostWebView()
	{
		string currentSelectServerId = this.GetCurrentSelectServerId();
		string text = Json.Stringify<InitializePostWebViewParam>(new InitializePostWebViewParam
		{
			language = LanguageSystem.Instance.PackageLanguage,
			serverId = currentSelectServerId,
			cdn = new string[]
			{
				PublicUtil.Instance.GetNoticeBaseUrl() + "/gamenotice/" + PublicUtil.Instance.GetGameId()
			}
		}, null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "初始化公告";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.InitPostWebView, text);
	}
}
