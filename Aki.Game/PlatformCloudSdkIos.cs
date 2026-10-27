using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x02000E46 RID: 3654
[NullableContext(1)]
[Nullable(0)]
public class PlatformCloudSdkIos : PlatformCloudSdkBase
{
	// Token: 0x060057ED RID: 22509 RVA: 0x000FD7C9 File Offset: 0x000FB9C9
	protected override void BindSpecialEvent()
	{
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnPostRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.AnnounceRedPointCallBack));
		CloudGameManager.Instance.BindFunction(ECloudGameReceiveDataKey.OnCustomerRedDotRefresh, new TCloudGameOnReceiveDataFunction(this.CustomerServiceResultCallBack));
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x000FD7FC File Offset: 0x000FB9FC
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

	// Token: 0x060057EF RID: 22511 RVA: 0x000FD868 File Offset: 0x000FBA68
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

	// Token: 0x060057F0 RID: 22512 RVA: 0x000FD910 File Offset: 0x000FBB10
	public override void SdkPay(ISDKPayment paymentInfo)
	{
		ISDKPayRole sdkPayRoleInfo = KuroSdkControllerTool.GetSdkPayRoleInfo();
		string paymentInfo2 = KuroSdkControllerTool.GetPaymentInfo(paymentInfo, sdkPayRoleInfo);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "IOSPayment";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("json", paymentInfo2);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CloudGameManager.Instance.SendDataByKey(ECloudGameSendData.SDKPay, paymentInfo2);
	}

	// Token: 0x060057F1 RID: 22513 RVA: 0x000FD964 File Offset: 0x000FBB64
	public override void InitializePostWebView()
	{
		string currentSelectServerId = this.GetCurrentSelectServerId();
		string text = Json.Stringify<InitializePostWebViewParam>(new InitializePostWebViewParam
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
