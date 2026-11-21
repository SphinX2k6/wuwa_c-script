using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x020002FC RID: 764
[NullableContext(1)]
[Nullable(0)]
public class PlatformCloudSdkWeb : PlatformCloudSdkBase
{
	// Token: 0x06002B83 RID: 11139 RVA: 0x001052FD File Offset: 0x001034FD
	protected override void BindSpecialEvent()
	{
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnPostRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.AnnounceRedPointCallBack));
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnCustomerRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x00105330 File Offset: 0x00103530
	public override void AnnounceRedPointCallBack(string result)
	{
		if (result.Contains("showRed") && (result.Contains("1") || result.Contains("YES")))
		{
			KuroSdkController.Instance.SetPostWebViewRedPointState(true);
			EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
			return;
		}
		KuroSdkController.Instance.SetPostWebViewRedPointState(false);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x0010539C File Offset: 0x0010359C
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		string text = JsonSerializer.Serialize<OpenCustomerServiceParamIos>(new OpenCustomerServiceParamIos
		{
			islogin = ((instance.IsSdkLoggedIn() > false) ? 1 : 0),
			from = fromType,
			RoleId = this.GetCustomServerRoleId(),
			RoleName = instance2.GetAccountName(true),
			ServerId = instance.GetServerId(),
			ServerName = instance.GetServerName(),
			RoleLevel = instance2.GetPlayerLevel().GetValueOrDefault(),
			ExtendsInfo = this.GetCustomServerExtendsInfo()
		}, KuroSdkJsonOptions.Unescaped);
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.OpenCustomerService, text ?? "");
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x00105444 File Offset: 0x00103644
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		ISDKPayRole sdkPayRoleInfo = KuroSdkControllerTool.GetSdkPayRoleInfo();
		string paymentInfo2 = KuroSdkControllerTool.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "WebPayment";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", paymentInfo2);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKPay, paymentInfo2);
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x00105498 File Offset: 0x00103698
	public override void InitializePostWebView()
	{
		string currentSelectServerId = this.GetCurrentSelectServerId();
		string text = Json.Stringify(new InitializePostWebViewParam
		{
			language = LanguageSystem.Instance.PackageLanguage,
			serverId = currentSelectServerId,
			cdn = new string[]
			{
				PublicUtil.Instance.GetNoticeBaseUrl() + "/gamenotice/" + PublicUtil.Instance.GetGameId() + "/"
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
