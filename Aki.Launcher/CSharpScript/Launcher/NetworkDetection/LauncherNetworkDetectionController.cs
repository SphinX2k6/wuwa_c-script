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
	// Token: 0x020001A8 RID: 424
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherNetworkDetectionController : Singleton
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x00049998 File Offset: 0x00047B98
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

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00049A7C File Offset: 0x00047C7C
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

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00049B30 File Offset: 0x00047D30
		private bool CheckDetectionConfig()
		{
			if (this.NetworkDetectionConfig == null)
			{
				LauncherLog.Instance.Debug("[网络检测]->没有拉取网络检测配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00049B60 File Offset: 0x00047D60
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

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00049BAC File Offset: 0x00047DAC
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

		// Token: 0x06000BBA RID: 3002 RVA: 0x00049BEC File Offset: 0x00047DEC
		public bool SkipDomainDetect()
		{
			string ip = this.NetworkDetectionConfig.ip;
			return ip == null || !ip.StartsWith("http");
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00049C18 File Offset: 0x00047E18
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

		// Token: 0x06000BBC RID: 3004 RVA: 0x00049C5B File Offset: 0x00047E5B
		public void ForceStopDomainDetect()
		{
			UKuroNetworkDetection.ResolveDomainFinish();
			if (this.OnResolveDomainName != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.OnResolveDomainName);
				this.OnResolveDomainName = null;
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00049C7C File Offset: 0x00047E7C
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

		// Token: 0x06000BBE RID: 3006 RVA: 0x00049CC0 File Offset: 0x00047EC0
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

		// Token: 0x06000BBF RID: 3007 RVA: 0x00049D03 File Offset: 0x00047F03
		public bool GetGateWayUdpCheckState()
		{
			return this.GateWayUdpCheckState;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00049D0C File Offset: 0x00047F0C
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

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00049D50 File Offset: 0x00047F50
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

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00049DEC File Offset: 0x00047FEC
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

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00049E30 File Offset: 0x00048030
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

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00049E74 File Offset: 0x00048074
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

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00049F74 File Offset: 0x00048174
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

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0004A074 File Offset: 0x00048274
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

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0004A0B8 File Offset: 0x000482B8
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

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0004A134 File Offset: 0x00048334
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

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0004A1A7 File Offset: 0x000483A7
		public bool IsGlobalPlayer()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0004A1C2 File Offset: 0x000483C2
		public void ReportDetectionLog(LauncherNetworkDetectionBaseLog logData)
		{
			HotPatchLogReport.Instance.ReportNetworkDetection(logData);
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0004A1CF File Offset: 0x000483CF
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

		// Token: 0x06000BCC RID: 3020 RVA: 0x0004A1F2 File Offset: 0x000483F2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0004A1F4 File Offset: 0x000483F4
		public static void ResetStaticDefaultValue()
		{
			LauncherNetworkDetectionController instance = LauncherNetworkDetectionController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherNetworkDetectionController._instance = null;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0004A20D File Offset: 0x0004840D
		static LauncherNetworkDetectionController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherNetworkDetectionController.CreateStaticDefaultValue), new Action(LauncherNetworkDetectionController.ResetStaticDefaultValue));
		}

		// Token: 0x0400074D RID: 1869
		private const int TIME_OUT = 2;

		// Token: 0x0400074E RID: 1870
		[Nullable(2)]
		private INetworkDetectionConfig NetworkDetectionConfig;

		// Token: 0x0400074F RID: 1871
		[Nullable(2)]
		private ILoginServersData LoginServersData;

		// Token: 0x04000750 RID: 1872
		[Nullable(2)]
		private Action<int> OnResolveDomainName;

		// Token: 0x04000751 RID: 1873
		[Nullable(2)]
		public INetworkDetectionPingResult PingResultCacheForLog;

		// Token: 0x04000752 RID: 1874
		[Nullable(2)]
		public ILoginNetworkDetectionConfig LoginNetworkDetectionConfig;

		// Token: 0x04000753 RID: 1875
		[Nullable(2)]
		private string GateWayUdpCheckUid;

		// Token: 0x04000754 RID: 1876
		private bool GateWayUdpCheckState;

		// Token: 0x04000755 RID: 1877
		[Nullable(2)]
		private static LauncherNetworkDetectionController _instance;
	}
}
