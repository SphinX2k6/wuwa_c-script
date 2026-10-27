using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000193 RID: 403
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkServer : Singleton
	{
		// Token: 0x06000AD6 RID: 2774 RVA: 0x000454B0 File Offset: 0x000436B0
		public void SetLanguage(string lang)
		{
			this.Language = lang;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000454B9 File Offset: 0x000436B9
		public bool IsConnected
		{
			get
			{
				return this.ConnectData != null;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000454C4 File Offset: 0x000436C4
		public bool? IsReportEnable
		{
			get
			{
				IConnectResponseData connectData = this.ConnectData;
				if (connectData == null)
				{
					return null;
				}
				ClientSwitch clientSwitch = connectData.clientSwitch;
				if (clientSwitch == null)
				{
					return null;
				}
				return new bool?(clientSwitch.td);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00045504 File Offset: 0x00043704
		public bool? IsCustomerServiceEnable
		{
			get
			{
				IConnectResponseData connectData = this.ConnectData;
				if (connectData == null)
				{
					return null;
				}
				ClientSwitch clientSwitch = connectData.clientSwitch;
				if (clientSwitch == null)
				{
					return null;
				}
				return new bool?(clientSwitch.sobot);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00045544 File Offset: 0x00043744
		public bool? IsPsnLoginEnable
		{
			get
			{
				IConnectResponseData connectData = this.ConnectData;
				bool value;
				if (connectData == null)
				{
					value = false;
				}
				else
				{
					ThirdLogin thirdLogin = connectData.thirdLogin;
					int? num;
					if (thirdLogin == null)
					{
						num = null;
					}
					else
					{
						LoginElement psnLogin = thirdLogin.psnLogin;
						num = ((psnLogin != null) ? new int?(psnLogin.enabled) : null);
					}
					int? num2 = num;
					value = (num2.GetValueOrDefault() == 1);
				}
				return new bool?(value);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000455A0 File Offset: 0x000437A0
		public bool? IsPsnEmailLoginEnable
		{
			get
			{
				IConnectResponseData connectData = this.ConnectData;
				bool value;
				if (connectData == null)
				{
					value = false;
				}
				else
				{
					ThirdLogin thirdLogin = connectData.thirdLogin;
					int? num;
					if (thirdLogin == null)
					{
						num = null;
					}
					else
					{
						LoginElement psnEmailLogin = thirdLogin.psnEmailLogin;
						num = ((psnEmailLogin != null) ? new int?(psnEmailLogin.enabled) : null);
					}
					int? num2 = num;
					value = (num2.GetValueOrDefault() == 1);
				}
				return new bool?(value);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000455FC File Offset: 0x000437FC
		[NullableContext(2)]
		public string GetUserCenterUrl()
		{
			IConnectResponseData connectData = this.ConnectData;
			if (connectData == null)
			{
				return null;
			}
			ClientUrl clientUrl = connectData.clientUrl;
			if (clientUrl == null)
			{
				return null;
			}
			return clientUrl.accCenterUrl;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0004561A File Offset: 0x0004381A
		public void Initialize()
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0004561C File Offset: 0x0004381C
		public void InitCommonParam(string commonParam)
		{
			this.CommonParam = commonParam;
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.InitCommonParam";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CommonParam", this.CommonParam);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00045658 File Offset: 0x00043858
		public TMap<string, string> GenerateCommonHeader()
		{
			return new TMap<string, string>
			{
				{
					"Kr-Ver",
					PlatformSdkConfig.Instance.GetSdkServerVersion()
				},
				{
					"Content-Type",
					"application/x-www-form-urlencoded"
				},
				{
					"Accept-Language",
					this.Language
				}
			};
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00045698 File Offset: 0x00043898
		public TMap<string, string> GeneratePayHeader(string productId, string version, string sdkVersion)
		{
			return new TMap<string, string>
			{
				{
					"Content-Type",
					"application/x-www-form-urlencoded"
				},
				{
					"kuro_gid",
					PlatformSdkConfig.Instance.GetProjectId()
				},
				{
					"kuro_app_id",
					productId
				},
				{
					"kuro_version",
					version
				},
				{
					"kuro_sdk_version",
					sdkVersion
				},
				{
					"kuro_lang",
					this.Language
				}
			};
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00045704 File Offset: 0x00043904
		public void SwitchUrl()
		{
			this.IsUseSpareUrl = !this.IsUseSpareUrl;
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.SwitchUrl";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.IsUseSpareUrl", this.IsUseSpareUrl);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0004574D File Offset: 0x0004394D
		private bool CheckHttpSuccess(bool success, int httpCode)
		{
			return success && httpCode == 200;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0004575C File Offset: 0x0004395C
		private bool CheckHttpHasResult(string data)
		{
			return data.Length != 0 && !(data == "{}") && !(data == "[]");
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00045784 File Offset: 0x00043984
		public unsafe void Connect(string param, TSDKConnectCallback callback)
		{
			PlatformSdkServer.<>c__DisplayClass25_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass25_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			string text = PlatformSdkConfig.Instance.GetServerUrl(this.IsUseSpareUrl) + "/v2/sys/conf.lg";
			string text2 = this.CommonParam + param;
			TMap<string, string> item = this.GenerateCommonHeader();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.Connect";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("header", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("params", text2);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			UKuroHttp.Post(text, item, text2, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<Connect>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0004585C File Offset: 0x00043A5C
		private unsafe void LoginWithSpecifyUrl(string specifyUrl, string param, TSDKLoginCallback callback)
		{
			PlatformSdkServer.<>c__DisplayClass26_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass26_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			CS$<>8__locals1.specifyUrl = specifyUrl;
			if (!this.IsConnected)
			{
				LauncherLog.Instance.Error("[PlatformSdkNew]PlatformSdkServer.Login failed, not connect to server", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsLogining)
			{
				LauncherLog.Instance.Error("[PlatformSdkNew]PlatformSdkServer.Login duplicate call", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.IsLogining = true;
			string text = PlatformSdkConfig.Instance.GetServerUrl(this.IsUseSpareUrl) + CS$<>8__locals1.specifyUrl;
			string text2 = this.CommonParam + param;
			TMap<string, string> item = this.GenerateCommonHeader();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.Login";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("header", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("params", text2);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			PlatformReportLogin eventData = new PlatformReportLogin();
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
			UKuroHttp.Post(text, item, text2, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<LoginWithSpecifyUrl>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0004599D File Offset: 0x00043B9D
		public void Login(string param, TSDKLoginCallback callback)
		{
			this.LoginWithSpecifyUrl("/v2/login/third/psn.lg", param, callback);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000459AC File Offset: 0x00043BAC
		public void BindAccountThenLogin(string param, TSDKLoginCallback callback)
		{
			this.LoginWithSpecifyUrl("/v2/login/third/psnBind.lg", param, callback);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000459BC File Offset: 0x00043BBC
		public unsafe void GetAccessToken(string loginCode, TSDKGetAccessTokenCallback callback)
		{
			PlatformSdkServer.<>c__DisplayClass29_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass29_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			string clientId = PlatformSdkConfig.Instance.GetClientId();
			string clientSecret = PlatformSdkConfig.Instance.GetClientSecret();
			string commonParam = this.CommonParam;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(77, 3);
			defaultInterpolatedStringHandler.AppendLiteral("&code=");
			defaultInterpolatedStringHandler.AppendFormatted(loginCode);
			defaultInterpolatedStringHandler.AppendLiteral("&client_id=");
			defaultInterpolatedStringHandler.AppendFormatted(clientId);
			defaultInterpolatedStringHandler.AppendLiteral("&client_secret=");
			defaultInterpolatedStringHandler.AppendFormatted(clientSecret);
			defaultInterpolatedStringHandler.AppendLiteral("&grant_type=authorization_code&redirect_uri=1");
			string text = commonParam + defaultInterpolatedStringHandler.ToStringAndClear();
			string text2 = PlatformSdkConfig.Instance.GetServerUrl(this.IsUseSpareUrl) + "/v2/auth/getToken.lg";
			TMap<string, string> item = this.GenerateCommonHeader();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.GetAccessToken";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("header", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("params", text);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			UKuroHttp.Post(text2, item, text, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<GetAccessToken>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00045B08 File Offset: 0x00043D08
		public unsafe void GetSdkRelation(string param, TSDKQuerySdkBlockCallBack callBack)
		{
			PlatformSdkServer.<>c__DisplayClass30_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass30_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callBack = callBack;
			string text = this.CommonParam + param;
			string text2 = PlatformSdkConfig.Instance.GetServerUrl(this.IsUseSpareUrl) + "/v2/psn/block/states.lg";
			TMap<string, string> item = this.GenerateCommonHeader();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.GetSdkRelation";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("header", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("params", text);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			UKuroHttp.Post(text2, item, text, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<GetSdkRelation>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00045BE0 File Offset: 0x00043DE0
		public unsafe void RenewAccessToken(string access_token, TSDKRenewAccessTokenCallback callback)
		{
			PlatformSdkServer.<>c__DisplayClass31_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass31_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			string text = this.CommonParam + "&access_token=" + access_token;
			string text2 = PlatformSdkConfig.Instance.GetServerUrl(this.IsUseSpareUrl) + "/v2/heartbeat/tokenCheck.lg";
			TMap<string, string> item = this.GenerateCommonHeader();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.RenewAccessToken";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("header", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("params", text);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			PlatformReportSdkKeepAlive eventData = new PlatformReportSdkKeepAlive();
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
			UKuroHttp.Post(text2, item, text, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<RenewAccessToken>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00045CD4 File Offset: 0x00043ED4
		public unsafe void RequestEmailAddressCode(string param, TSdkRequestEmailCodeCallback callBack)
		{
			PlatformSdkServer.<>c__DisplayClass32_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass32_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callBack = callBack;
			string text = this.CommonParam + param;
			string text2 = PlatformSdkConfig.Instance.GetServerUrl(this.IsUseSpareUrl) + "/v2/email/psnLogin/send.lg";
			TMap<string, string> item = this.GenerateCommonHeader();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.RequestEmailAddressCode";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("header", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("params", text);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			PlatformReportClickSendCode eventData = new PlatformReportClickSendCode();
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
			UKuroHttp.Post(text2, item, text, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<RequestEmailAddressCode>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00045DC4 File Offset: 0x00043FC4
		public unsafe void QueryStoreProducts(TMap<string, string> payHeader, TSDKQueryGoodsCallback callback, params object[] keyValPairs)
		{
			PlatformSdkServer.<>c__DisplayClass33_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass33_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			string text = PlatformSdkConfig.Instance.GetPayUrl(this.IsUseSpareUrl) + "/api/v1/prop/query.lg";
			string text2 = SdkServerEncodeHelper.MarkData(keyValPairs);
			string text3 = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
			string clientId = PlatformSdkConfig.Instance.GetClientId();
			string projectId = PlatformSdkConfig.Instance.GetProjectId();
			string value = SdkServerEncodeHelper.MarkSign(clientId, new string[]
			{
				"pcode",
				projectId,
				"data",
				text2,
				"timestamp",
				text3
			});
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 4);
			defaultInterpolatedStringHandler.AppendLiteral("pcode=");
			defaultInterpolatedStringHandler.AppendFormatted(projectId);
			defaultInterpolatedStringHandler.AppendLiteral("&data=");
			defaultInterpolatedStringHandler.AppendFormatted(Uri.EscapeDataString(text2));
			defaultInterpolatedStringHandler.AppendLiteral("&sign=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("&timestamp=");
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			string text4 = defaultInterpolatedStringHandler.ToStringAndClear();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.QueryStoreProducts";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("url", payHeader);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("params", text4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("rawData", keyValPairs);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			UKuroHttp.Post(text, payHeader, text4, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<QueryStoreProducts>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00045F74 File Offset: 0x00044174
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			2,
			1
		})]
		public UniTask<ValueTuple<string, bool, List<IQueryGoodsResponseData>>> QueryStoreProductsAsync(TMap<string, string> payHeader, params object[] keyValPairs)
		{
			PlatformSdkServer.<QueryStoreProductsAsync>d__34 <QueryStoreProductsAsync>d__;
			<QueryStoreProductsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<string, bool, List<IQueryGoodsResponseData>>>.Create();
			<QueryStoreProductsAsync>d__.<>4__this = this;
			<QueryStoreProductsAsync>d__.payHeader = payHeader;
			<QueryStoreProductsAsync>d__.keyValPairs = keyValPairs;
			<QueryStoreProductsAsync>d__.<>1__state = -1;
			<QueryStoreProductsAsync>d__.<>t__builder.Start<PlatformSdkServer.<QueryStoreProductsAsync>d__34>(ref <QueryStoreProductsAsync>d__);
			return <QueryStoreProductsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00045FC8 File Offset: 0x000441C8
		public unsafe void RequestCheckoutProduct(ECheckoutReason reason, int env, TSdkCheckoutProductCallback callback, TMap<string, string> payHeader, params object[] keyValPairs)
		{
			PlatformSdkServer.<>c__DisplayClass35_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass35_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			CS$<>8__locals1.reason = reason;
			CS$<>8__locals1.env = env;
			string text = PlatformSdkConfig.Instance.GetPayUrl(this.IsUseSpareUrl) + "/api/v1/callback/psn";
			string text2 = SdkServerEncodeHelper.MarkData(keyValPairs);
			string text3 = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
			string clientId = PlatformSdkConfig.Instance.GetClientId();
			string projectId = PlatformSdkConfig.Instance.GetProjectId();
			string value = SdkServerEncodeHelper.MarkSign(clientId, new string[]
			{
				"pcode",
				projectId,
				"data",
				text2,
				"timestamp",
				text3
			});
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 4);
			defaultInterpolatedStringHandler.AppendLiteral("pcode=");
			defaultInterpolatedStringHandler.AppendFormatted(projectId);
			defaultInterpolatedStringHandler.AppendLiteral("&data=");
			defaultInterpolatedStringHandler.AppendFormatted(Uri.EscapeDataString(text2));
			defaultInterpolatedStringHandler.AppendLiteral("&sign=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("&timestamp=");
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			string text4 = defaultInterpolatedStringHandler.ToStringAndClear();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.RequestCheckoutProduct";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("productKey", clientId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("payHeader", payHeader);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("params", text4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("rawData", keyValPairs);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			PlatformReportUploadPsnBill platformReportUploadPsnBill = new PlatformReportUploadPsnBill();
			platformReportUploadPsnBill.psn_scene = this.GetReportScene(CS$<>8__locals1.reason);
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(platformReportUploadPsnBill);
			UKuroHttp.Post(text, payHeader, text4, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<RequestCheckoutProduct>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000461D0 File Offset: 0x000443D0
		private string GetReportScene(ECheckoutReason scene)
		{
			string result = "";
			if (scene == ECheckoutReason.Login)
			{
				result = "2";
			}
			else if (scene == ECheckoutReason.AfterPay)
			{
				result = "1";
			}
			else if (scene == ECheckoutReason.StopGame)
			{
				result = "3";
			}
			return result;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00046208 File Offset: 0x00044408
		public unsafe void RequestReportData(string accessToken, string param, TSdkReportCallBack callBack)
		{
			PlatformSdkServer.<>c__DisplayClass37_0 CS$<>8__locals1 = new PlatformSdkServer.<>c__DisplayClass37_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callBack = callBack;
			string specifyChar = "JRps7QAydqSkYFN-T4wnBDhKLr8H3.u69mG2WjPgOxco0avZE5IUflMVbtzeX1iC";
			string text = UKuroStaticLibrary.Base64EncodeWithSpecifyCharWithConvertToUTF8(param, specifyChar);
			text = text.Replace("=", "");
			string text2 = "rOLe" + param + "jar";
			string text3 = UKuroStaticLibrary.Md5HashUTF8String(text2).ToUpper();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]PlatformSdkServer.RequestReportData";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("param", param);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("r_role", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("signUpper", text3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("trySignStr", text2);
			instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
			defaultInterpolatedStringHandler.AppendLiteral("&access_token=");
			defaultInterpolatedStringHandler.AppendFormatted(accessToken);
			defaultInterpolatedStringHandler.AppendLiteral("&r_role=");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("&r_sign=");
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			string str = defaultInterpolatedStringHandler.ToStringAndClear();
			string text4 = this.CommonParam + str;
			string text5 = PlatformSdkConfig.Instance.GetServerUrl(this.IsUseSpareUrl) + "/v2/user/game/role.lg";
			TMap<string, string> item = this.GenerateCommonHeader();
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[PlatformSdkNew]PlatformSdkServer.RequestReportData";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("url", text5);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("header", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("params", text4);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			UKuroHttp.Post(text5, item, text4, DelegateUtils.ToManualReleaseDelegate<FHttpResponseHandle>(new Action<bool, int, string>(CS$<>8__locals1.<RequestReportData>g__ResponseCallBack|0)), 10f);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000463F4 File Offset: 0x000445F4
		public static PlatformSdkServer Instance
		{
			get
			{
				if (PlatformSdkServer._instance == null)
				{
					PlatformSdkServer._instance = new PlatformSdkServer();
					PlatformSdkServer._instance.OnInit();
				}
				return PlatformSdkServer._instance;
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00046417 File Offset: 0x00044617
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00046419 File Offset: 0x00044619
		public static void ResetStaticDefaultValue()
		{
			PlatformSdkServer instance = PlatformSdkServer._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PlatformSdkServer._instance = null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00046432 File Offset: 0x00044632
		static PlatformSdkServer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlatformSdkServer.CreateStaticDefaultValue), new Action(PlatformSdkServer.ResetStaticDefaultValue));
		}

		// Token: 0x040006D0 RID: 1744
		private const int HttpTimeout = 10;

		// Token: 0x040006D1 RID: 1745
		private bool IsUseSpareUrl;

		// Token: 0x040006D2 RID: 1746
		private string Language = "en";

		// Token: 0x040006D3 RID: 1747
		private string CommonParam = "";

		// Token: 0x040006D4 RID: 1748
		[Nullable(2)]
		private IConnectResponseData ConnectData;

		// Token: 0x040006D5 RID: 1749
		private bool IsLogining;

		// Token: 0x040006D6 RID: 1750
		[Nullable(2)]
		private static PlatformSdkServer _instance;
	}
}
