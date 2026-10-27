using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Core.Net;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056A7 RID: 22183
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGatewayController : UiControllerBase
	{
		// Token: 0x06038724 RID: 231204 RVA: 0x00D66CB0 File Offset: 0x00D64EB0
		public bool SupportIpv6Address()
		{
			TArray<string> tarray = new TArray<string>();
			UKuroStaticLibrary.GetLocalHostAddresses(ref tarray, false);
			if (tarray == null)
			{
				return false;
			}
			using (IEnumerator<string> enumerator = tarray.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Contains(':'))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06038725 RID: 231205 RVA: 0x00D66D14 File Offset: 0x00D64F14
		[return: Nullable(0)]
		public UniTask<bool> ConnectGateWay(string token, List<NetHostInfo> hostInfos, [Nullable(2)] GatewayLatencyConfigVo gatewayLatencyConfig)
		{
			LoginGatewayController.<ConnectGateWay>d__3 <ConnectGateWay>d__;
			<ConnectGateWay>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ConnectGateWay>d__.<>4__this = this;
			<ConnectGateWay>d__.token = token;
			<ConnectGateWay>d__.hostInfos = hostInfos;
			<ConnectGateWay>d__.gatewayLatencyConfig = gatewayLatencyConfig;
			<ConnectGateWay>d__.<>1__state = -1;
			<ConnectGateWay>d__.<>t__builder.Start<LoginGatewayController.<ConnectGateWay>d__3>(ref <ConnectGateWay>d__);
			return <ConnectGateWay>d__.<>t__builder.Task;
		}

		// Token: 0x06038726 RID: 231206 RVA: 0x00D66D70 File Offset: 0x00D64F70
		[return: Nullable(0)]
		public static UniTask<bool> ConnectGatewayWithoutDetection(string token, List<NetHostInfo> hostInfos)
		{
			LoginGatewayController.<ConnectGatewayWithoutDetection>d__4 <ConnectGatewayWithoutDetection>d__;
			<ConnectGatewayWithoutDetection>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ConnectGatewayWithoutDetection>d__.token = token;
			<ConnectGatewayWithoutDetection>d__.hostInfos = hostInfos;
			<ConnectGatewayWithoutDetection>d__.<>1__state = -1;
			<ConnectGatewayWithoutDetection>d__.<>t__builder.Start<LoginGatewayController.<ConnectGatewayWithoutDetection>d__4>(ref <ConnectGatewayWithoutDetection>d__);
			return <ConnectGatewayWithoutDetection>d__.<>t__builder.Task;
		}

		// Token: 0x06038727 RID: 231207 RVA: 0x00D66DBC File Offset: 0x00D64FBC
		[return: Nullable(0)]
		public static UniTask<bool> ConnectGateWayWithDetection(string token, List<NetHostInfo> hostInfos, GatewayLatencyConfigVo gatewayLatencyConfig)
		{
			LoginGatewayController.<ConnectGateWayWithDetection>d__5 <ConnectGateWayWithDetection>d__;
			<ConnectGateWayWithDetection>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ConnectGateWayWithDetection>d__.token = token;
			<ConnectGateWayWithDetection>d__.hostInfos = hostInfos;
			<ConnectGateWayWithDetection>d__.gatewayLatencyConfig = gatewayLatencyConfig;
			<ConnectGateWayWithDetection>d__.<>1__state = -1;
			<ConnectGateWayWithDetection>d__.<>t__builder.Start<LoginGatewayController.<ConnectGateWayWithDetection>d__5>(ref <ConnectGateWayWithDetection>d__);
			return <ConnectGateWayWithDetection>d__.<>t__builder.Task;
		}

		// Token: 0x06038728 RID: 231208 RVA: 0x00D66E10 File Offset: 0x00D65010
		[return: TupleElementNames(new string[]
		{
			"Host",
			"HasHttp"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private static ValueTuple<string, bool> RemoveHttpPrefix(string host)
		{
			if (host.StartsWith("http://"))
			{
				return new ValueTuple<string, bool>(host.Substring("http://".Length), true);
			}
			if (host.StartsWith("https://"))
			{
				return new ValueTuple<string, bool>(host.Substring("https://".Length), true);
			}
			return new ValueTuple<string, bool>(host, false);
		}

		// Token: 0x06038729 RID: 231209 RVA: 0x00D66E6C File Offset: 0x00D6506C
		private static bool IsIPv4(string host)
		{
			return Regex.IsMatch(host, "^(\\d{1,3}\\.){3}\\d{1,3}$");
		}

		// Token: 0x0603872A RID: 231210 RVA: 0x00D66E79 File Offset: 0x00D65079
		private static bool IsIPv6(string host)
		{
			return host.Contains(':') && !host.Contains("://");
		}

		// Token: 0x0603872B RID: 231211 RVA: 0x00D66E98 File Offset: 0x00D65098
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<string> ResolveHostToIp(string host)
		{
			LoginGatewayController.<ResolveHostToIp>d__9 <ResolveHostToIp>d__;
			<ResolveHostToIp>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<ResolveHostToIp>d__.host = host;
			<ResolveHostToIp>d__.<>1__state = -1;
			<ResolveHostToIp>d__.<>t__builder.Start<LoginGatewayController.<ResolveHostToIp>d__9>(ref <ResolveHostToIp>d__);
			return <ResolveHostToIp>d__.<>t__builder.Task;
		}

		// Token: 0x0603872C RID: 231212 RVA: 0x00D66EDC File Offset: 0x00D650DC
		[return: Nullable(0)]
		private static UniTask<bool> ConnectGateWayInternal(string token, string host, int port, bool showConfirmBox, bool pickByDetection, [Nullable(new byte[]
		{
			2,
			1
		})] List<LoginGateWayDetection> detections = null)
		{
			LoginGatewayController.<ConnectGateWayInternal>d__10 <ConnectGateWayInternal>d__;
			<ConnectGateWayInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ConnectGateWayInternal>d__.token = token;
			<ConnectGateWayInternal>d__.host = host;
			<ConnectGateWayInternal>d__.port = port;
			<ConnectGateWayInternal>d__.showConfirmBox = showConfirmBox;
			<ConnectGateWayInternal>d__.pickByDetection = pickByDetection;
			<ConnectGateWayInternal>d__.detections = detections;
			<ConnectGateWayInternal>d__.<>1__state = -1;
			<ConnectGateWayInternal>d__.<>t__builder.Start<LoginGatewayController.<ConnectGateWayInternal>d__10>(ref <ConnectGateWayInternal>d__);
			return <ConnectGateWayInternal>d__.<>t__builder.Task;
		}

		// Token: 0x1700878E RID: 34702
		// (get) Token: 0x0603872D RID: 231213 RVA: 0x00D66F49 File Offset: 0x00D65149
		public static LoginGatewayController Instance
		{
			get
			{
				return LoginGatewayController._Instance;
			}
		}

		// Token: 0x0603872E RID: 231214 RVA: 0x00D66F50 File Offset: 0x00D65150
		public static LoginGatewayController GetOrCreateInstance()
		{
			if (LoginGatewayController._Instance == null)
			{
				LoginGatewayController.CreateInstance();
			}
			return LoginGatewayController._Instance;
		}

		// Token: 0x0603872F RID: 231215 RVA: 0x00D66F64 File Offset: 0x00D65164
		public static bool CreateInstance()
		{
			if (LoginGatewayController._Instance != null)
			{
				return true;
			}
			LoginGatewayController._Instance = new LoginGatewayController();
			return true;
		}

		// Token: 0x06038730 RID: 231216 RVA: 0x00D66F7A File Offset: 0x00D6517A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038731 RID: 231217 RVA: 0x00D66F7C File Offset: 0x00D6517C
		public static void ResetStaticDefaultValue()
		{
			LoginGatewayController._Instance = null;
		}

		// Token: 0x06038732 RID: 231218 RVA: 0x00D66F84 File Offset: 0x00D65184
		static LoginGatewayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LoginGatewayController.CreateStaticDefaultValue), new Action(LoginGatewayController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DA3F RID: 121407
		private const string HTTP_PREFIX_STRING = "http://";

		// Token: 0x0401DA40 RID: 121408
		private const string HTTPS_PREFIX_STRING = "https://";

		// Token: 0x0401DA41 RID: 121409
		[Nullable(2)]
		private static LoginGatewayController _Instance;
	}
}
