using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001AC RID: 428
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherNetworkDetectionController : Singleton
	{
		// Token: 0x06000BEC RID: 3052 RVA: 0x0004C188 File Offset: 0x0004A388
		public unsafe bool SetDetectionConfig(ILoginServersData data)
		{
			if (this.LoginServersData != data)
			{
				string detectionConfig = UKuroNetworkDetection.GetDetectionConfig(data.name);
				try
				{
					INetworkDetectionConfig networkDetectionConfig = LauncherJson.Parse<INetworkDetectionConfig>(detectionConfig, new JsonSerializerOptions
					{
						PropertyNameCaseInsensitive = true
					});
					if (networkDetectionConfig != null && this.CheckDetectionConfigEntryValidate(data, networkDetectionConfig, true))
					{
						this.LoginServersData = data;
						this.NetworkDetectionConfig = networkDetectionConfig;
						return true;
					}
					return false;
				}
				catch (Exception ex)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "网络检测->SetDetectionConfig执行异常";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("loginServersData", data);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("detectionConfigJson", detectionConfig);
					instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return false;
				}
				return true;
			}
			return true;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0004C26C File Offset: 0x0004A46C
		private unsafe bool CheckDetectionConfigEntryValidate(ILoginServersData data, INetworkDetectionConfig detectionConfig, bool log = false)
		{
			string pingUrl = detectionConfig.PingUrl;
			int[] udpPort = detectionConfig.UdpPort;
			if (string.IsNullOrEmpty(pingUrl) || udpPort == null || udpPort.Length == 0)
			{
				if (log)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "网络检测->SetDetectionConfig执行异常,检测条目配置缺失";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("loginServersData", data);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("detectionConfig", detectionConfig);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pingUrl", pingUrl);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("udpPortArray", udpPort);
					instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0004C320 File Offset: 0x0004A520
		private bool CheckDetectionConfig()
		{
			if (this.NetworkDetectionConfig == null)
			{
				LauncherLog.Instance.Debug("[网络检测]->没有拉取网络检测配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0004C350 File Offset: 0x0004A550
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<INetworkDetectionResult> StartDetection(INetworkDetectionEntry entry)
		{
			LauncherNetworkDetectionController.<StartDetection>d__11 <StartDetection>d__;
			<StartDetection>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionResult>.Create();
			<StartDetection>d__.<>4__this = this;
			<StartDetection>d__.entry = entry;
			<StartDetection>d__.<>1__state = -1;
			<StartDetection>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartDetection>d__11>(ref <StartDetection>d__);
			return <StartDetection>d__.<>t__builder.Task;
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0004C39C File Offset: 0x0004A59C
		public INetworkDetectionResult StartProxyDetect()
		{
			string currentProxyAddress = UKuroNetworkDetection.GetCurrentProxyAddress();
			bool flag = string.IsNullOrEmpty(currentProxyAddress);
			return new INetworkDetectionProxyResult
			{
				Success = flag,
				Address = currentProxyAddress,
				Code = new int?(flag ? 0 : -1)
			};
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0004C3DC File Offset: 0x0004A5DC
		public bool SkipDomainDetect()
		{
			string ip = this.NetworkDetectionConfig.ip;
			return ip == null || !ip.StartsWith("http");
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0004C408 File Offset: 0x0004A608
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<INetworkDetectionResult> StartDomainDetect()
		{
			LauncherNetworkDetectionController.<StartDomainDetect>d__14 <StartDomainDetect>d__;
			<StartDomainDetect>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionResult>.Create();
			<StartDomainDetect>d__.<>4__this = this;
			<StartDomainDetect>d__.<>1__state = -1;
			<StartDomainDetect>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartDomainDetect>d__14>(ref <StartDomainDetect>d__);
			return <StartDomainDetect>d__.<>t__builder.Task;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0004C44B File Offset: 0x0004A64B
		public void ForceStopDomainDetect()
		{
			UKuroNetworkDetection.ResolveDomainFinish();
			if (this.OnResolveDomainName != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.OnResolveDomainName);
				this.OnResolveDomainName = null;
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0004C46C File Offset: 0x0004A66C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<INetworkDetectionPingResult> StartPingDetect()
		{
			LauncherNetworkDetectionController.<StartPingDetect>d__16 <StartPingDetect>d__;
			<StartPingDetect>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionPingResult>.Create();
			<StartPingDetect>d__.<>4__this = this;
			<StartPingDetect>d__.<>1__state = -1;
			<StartPingDetect>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartPingDetect>d__16>(ref <StartPingDetect>d__);
			return <StartPingDetect>d__.<>t__builder.Task;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0004C4B0 File Offset: 0x0004A6B0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<INetworkDetectionHttpResult> StartHttpsDetect()
		{
			LauncherNetworkDetectionController.<StartHttpsDetect>d__17 <StartHttpsDetect>d__;
			<StartHttpsDetect>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionHttpResult>.Create();
			<StartHttpsDetect>d__.<>4__this = this;
			<StartHttpsDetect>d__.<>1__state = -1;
			<StartHttpsDetect>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartHttpsDetect>d__17>(ref <StartHttpsDetect>d__);
			return <StartHttpsDetect>d__.<>t__builder.Task;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0004C4F3 File Offset: 0x0004A6F3
		public bool GetGateWayUdpCheckState()
		{
			return this.GateWayUdpCheckState;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0004C4FC File Offset: 0x0004A6FC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<INetworkDetectionResult> StartUdpDetect()
		{
			LauncherNetworkDetectionController.<StartUdpDetect>d__19 <StartUdpDetect>d__;
			<StartUdpDetect>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionResult>.Create();
			<StartUdpDetect>d__.<>4__this = this;
			<StartUdpDetect>d__.<>1__state = -1;
			<StartUdpDetect>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartUdpDetect>d__19>(ref <StartUdpDetect>d__);
			return <StartUdpDetect>d__.<>t__builder.Task;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0004C540 File Offset: 0x0004A740
		public unsafe void SetGateWayCheckInfo([Nullable(2)] ILoginNetworkDetectionConfig data, string uid)
		{
			if (data != null)
			{
				if (data.Hosts.TrueForAll((string host) => !string.IsNullOrEmpty(host)))
				{
					this.LoginNetworkDetectionConfig = data;
				}
			}
			this.GateWayUdpCheckUid = uid;
			LauncherLog instance = LauncherLog.Instance;
			string message = "[网络检测]->设置网关检测信息";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("data", data);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uid", uid);
			instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0004C5DC File Offset: 0x0004A7DC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<INetworkDetectionResult> StartGateWayUdpReachable()
		{
			LauncherNetworkDetectionController.<StartGateWayUdpReachable>d__21 <StartGateWayUdpReachable>d__;
			<StartGateWayUdpReachable>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionResult>.Create();
			<StartGateWayUdpReachable>d__.<>4__this = this;
			<StartGateWayUdpReachable>d__.<>1__state = -1;
			<StartGateWayUdpReachable>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartGateWayUdpReachable>d__21>(ref <StartGateWayUdpReachable>d__);
			return <StartGateWayUdpReachable>d__.<>t__builder.Task;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0004C620 File Offset: 0x0004A820
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<INetworkDetectionResult> StartUdpCheckPingUrlList()
		{
			LauncherNetworkDetectionController.<StartUdpCheckPingUrlList>d__22 <StartUdpCheckPingUrlList>d__;
			<StartUdpCheckPingUrlList>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionResult>.Create();
			<StartUdpCheckPingUrlList>d__.<>4__this = this;
			<StartUdpCheckPingUrlList>d__.<>1__state = -1;
			<StartUdpCheckPingUrlList>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartUdpCheckPingUrlList>d__22>(ref <StartUdpCheckPingUrlList>d__);
			return <StartUdpCheckPingUrlList>d__.<>t__builder.Task;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0004C664 File Offset: 0x0004A864
		private unsafe void CheckGateWayDdpReachable(List<string> urlList, int index, int[] udpPortArray, string payload, Action<bool, int> callBack)
		{
			LauncherNetworkDetectionController.<>c__DisplayClass23_0 CS$<>8__locals1 = new LauncherNetworkDetectionController.<>c__DisplayClass23_0();
			CS$<>8__locals1.index = index;
			CS$<>8__locals1.urlList = urlList;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.udpPortArray = udpPortArray;
			CS$<>8__locals1.payload = payload;
			CS$<>8__locals1.callBack = callBack;
			string text = CS$<>8__locals1.urlList[CS$<>8__locals1.index];
			if (text != null)
			{
				FTestUdpResultDelegate resultDelegate = DelegateUtils.ToManualReleaseDelegate<FTestUdpResultDelegate>(new Action<int, int>(CS$<>8__locals1.<CheckGateWayDdpReachable>g__CheckCallback|0));
				TArray<int> tarray = new TArray<int>();
				foreach (int value in CS$<>8__locals1.udpPortArray)
				{
					tarray.Add(value);
				}
				LauncherLog instance = LauncherLog.Instance;
				string message = "[网络检测]->网关Udp端口检测";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("payload", CS$<>8__locals1.payload);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				UKuroNetworkDetection.GatewayUdpReachable(text, tarray, CS$<>8__locals1.payload, resultDelegate);
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0004C764 File Offset: 0x0004A964
		private unsafe void CheckDetectUdp(List<string> urlList, int index, int[] udpPortArray, Action<bool, int> callBack)
		{
			LauncherNetworkDetectionController.<>c__DisplayClass24_0 CS$<>8__locals1 = new LauncherNetworkDetectionController.<>c__DisplayClass24_0();
			CS$<>8__locals1.index = index;
			CS$<>8__locals1.urlList = urlList;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.udpPortArray = udpPortArray;
			CS$<>8__locals1.callBack = callBack;
			CS$<>8__locals1.url = CS$<>8__locals1.urlList[CS$<>8__locals1.index];
			if (CS$<>8__locals1.url != null)
			{
				FTestUdpResultDelegate resultDelegate = DelegateUtils.ToManualReleaseDelegate<FTestUdpResultDelegate>(new Action<int, int>(CS$<>8__locals1.<CheckDetectUdp>g__CheckCallback|0));
				TArray<int> tarray = new TArray<int>();
				foreach (int value in CS$<>8__locals1.udpPortArray)
				{
					tarray.Add(value);
				}
				LauncherLog instance = LauncherLog.Instance;
				string message = "[网络检测]->UdpPort检测";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", CS$<>8__locals1.url);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("portUeArray", tarray);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				UKuroNetworkDetection.TestUdpReachable(CS$<>8__locals1.url, tarray, resultDelegate);
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0004C864 File Offset: 0x0004AA64
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<INetworkDetectionResult> StartTraceRouteDetect()
		{
			LauncherNetworkDetectionController.<StartTraceRouteDetect>d__25 <StartTraceRouteDetect>d__;
			<StartTraceRouteDetect>d__.<>t__builder = AsyncUniTaskMethodBuilder<INetworkDetectionResult>.Create();
			<StartTraceRouteDetect>d__.<>4__this = this;
			<StartTraceRouteDetect>d__.<>1__state = -1;
			<StartTraceRouteDetect>d__.<>t__builder.Start<LauncherNetworkDetectionController.<StartTraceRouteDetect>d__25>(ref <StartTraceRouteDetect>d__);
			return <StartTraceRouteDetect>d__.<>t__builder.Task;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0004C8A8 File Offset: 0x0004AAA8
		private void CheckLoginUrlReachable(List<string> loginUrlList, int index, Action<bool> callBack)
		{
			LauncherNetworkDetectionController.<>c__DisplayClass26_0 CS$<>8__locals1 = new LauncherNetworkDetectionController.<>c__DisplayClass26_0();
			CS$<>8__locals1.index = index;
			CS$<>8__locals1.loginUrlList = loginUrlList;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callBack = callBack;
			CS$<>8__locals1.url = CS$<>8__locals1.loginUrlList[CS$<>8__locals1.index];
			if (CS$<>8__locals1.url != null)
			{
				string target = this.ExtractDomain(CS$<>8__locals1.url);
				FTracerouteDelegate callback = DelegateUtils.ToManualReleaseDelegate<FTracerouteDelegate>(new Action<bool>(CS$<>8__locals1.<CheckLoginUrlReachable>g__CheckCallback|0));
				new UKuroTraceroute().Traceroute(target, callback);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0004C924 File Offset: 0x0004AB24
		private string ExtractDomain(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return "";
			}
			string text = input.Trim();
			text = Regex.Replace(text, "^[a-zA-Z][a-zA-Z0-9+.-]*:\\/\\/", "");
			text = Regex.Split(text, "[/?#]")[0];
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			text = Regex.Replace(text, ":\\d+$", "");
			return Regex.Replace(text, "^www\\.", "", RegexOptions.IgnoreCase);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0004C997 File Offset: 0x0004AB97
		public bool IsGlobalPlayer()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0004C9B2 File Offset: 0x0004ABB2
		public void ReportDetectionLog(LauncherNetworkDetectionBaseLog logData)
		{
			HotPatchLogReport.Instance.ReportNetworkDetection(logData);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0004C9BF File Offset: 0x0004ABBF
		public static LauncherNetworkDetectionController Instance
		{
			get
			{
				if (LauncherNetworkDetectionController._instance == null)
				{
					LauncherNetworkDetectionController._instance = new LauncherNetworkDetectionController();
					LauncherNetworkDetectionController._instance.OnInit();
				}
				return LauncherNetworkDetectionController._instance;
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0004C9E2 File Offset: 0x0004ABE2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		public static void ResetStaticDefaultValue()
		{
			LauncherNetworkDetectionController instance = LauncherNetworkDetectionController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherNetworkDetectionController._instance = null;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0004C9FD File Offset: 0x0004ABFD
		static LauncherNetworkDetectionController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherNetworkDetectionController.CreateStaticDefaultValue), new Action(LauncherNetworkDetectionController.ResetStaticDefaultValue));
		}

		// Token: 0x0400078A RID: 1930
		private const int TIME_OUT = 2;

		// Token: 0x0400078B RID: 1931
		[Nullable(2)]
		private INetworkDetectionConfig NetworkDetectionConfig;

		// Token: 0x0400078C RID: 1932
		[Nullable(2)]
		private ILoginServersData LoginServersData;

		// Token: 0x0400078D RID: 1933
		[Nullable(2)]
		private Action<int> OnResolveDomainName;

		// Token: 0x0400078E RID: 1934
		[Nullable(2)]
		public INetworkDetectionPingResult PingResultCacheForLog;

		// Token: 0x0400078F RID: 1935
		[Nullable(2)]
		public ILoginNetworkDetectionConfig LoginNetworkDetectionConfig;

		// Token: 0x04000790 RID: 1936
		[Nullable(2)]
		private string GateWayUdpCheckUid;

		// Token: 0x04000791 RID: 1937
		private bool GateWayUdpCheckState;

		// Token: 0x04000792 RID: 1938
		[Nullable(2)]
		private static LauncherNetworkDetectionController _instance;
	}
}
