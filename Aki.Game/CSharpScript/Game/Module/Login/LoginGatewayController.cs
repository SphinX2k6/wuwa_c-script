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
	// Token: 0x0200467D RID: 18045
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGatewayController : UiControllerBase
	{
		// Token: 0x0602D621 RID: 185889 RVA: 0x00CB4E04 File Offset: 0x00CB3004
		public bool SupportIpv6Address()
		{
			TArray<string> tarray = new TArray<string>();
			UKuroStaticLibrary.GetLocalHostAddresses(ref tarray, false);
			if (tarray == null)
			{
				return false;
			}
			using (TArray<string>.Enumerator enumerator = tarray.GetEnumerator())
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

		// Token: 0x0602D622 RID: 185890 RVA: 0x00CB4E70 File Offset: 0x00CB3070
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

		// Token: 0x0602D623 RID: 185891 RVA: 0x00CB4ECC File Offset: 0x00CB30CC
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

		// Token: 0x0602D624 RID: 185892 RVA: 0x00CB4F18 File Offset: 0x00CB3118
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

		// Token: 0x0602D625 RID: 185893 RVA: 0x00CB4F6C File Offset: 0x00CB316C
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

		// Token: 0x0602D626 RID: 185894 RVA: 0x00CB4FC8 File Offset: 0x00CB31C8
		private static bool IsIPv4(string host)
		{
			return Regex.IsMatch(host, "^(\\d{1,3}\\.){3}\\d{1,3}$");
		}

		// Token: 0x0602D627 RID: 185895 RVA: 0x00CB4FD5 File Offset: 0x00CB31D5
		private static bool IsIPv6(string host)
		{
			return host.Contains(':') && !host.Contains("://");
		}

		// Token: 0x0602D628 RID: 185896 RVA: 0x00CB4FF4 File Offset: 0x00CB31F4
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

		// Token: 0x0602D629 RID: 185897 RVA: 0x00CB5038 File Offset: 0x00CB3238
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

		// Token: 0x17005B55 RID: 23381
		// (get) Token: 0x0602D62A RID: 185898 RVA: 0x00CB50A5 File Offset: 0x00CB32A5
		public static LoginGatewayController Instance
		{
			get
			{
				return LoginGatewayController._Instance;
			}
		}

		// Token: 0x0602D62B RID: 185899 RVA: 0x00CB50AC File Offset: 0x00CB32AC
		public static LoginGatewayController GetOrCreateInstance()
		{
			if (LoginGatewayController._Instance == null)
			{
				LoginGatewayController.CreateInstance();
			}
			return LoginGatewayController._Instance;
		}

		// Token: 0x0602D62C RID: 185900 RVA: 0x00CB50C0 File Offset: 0x00CB32C0
		public static bool CreateInstance()
		{
			if (LoginGatewayController._Instance != null)
			{
				return true;
			}
			LoginGatewayController._Instance = new LoginGatewayController();
			return true;
		}

		// Token: 0x0602D62D RID: 185901 RVA: 0x00CB50D6 File Offset: 0x00CB32D6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D62E RID: 185902 RVA: 0x00CB50D8 File Offset: 0x00CB32D8
		public static void ResetStaticDefaultValue()
		{
			LoginGatewayController._Instance = null;
		}

		// Token: 0x0602D62F RID: 185903 RVA: 0x00CB50E0 File Offset: 0x00CB32E0
		static LoginGatewayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LoginGatewayController.CreateStaticDefaultValue), new Action(LoginGatewayController.ResetStaticDefaultValue));
		}

		// Token: 0x040184CA RID: 99530
		private const string HTTP_PREFIX_STRING = "http://";

		// Token: 0x040184CB RID: 99531
		private const string HTTPS_PREFIX_STRING = "https://";

		// Token: 0x040184CC RID: 99532
		[Nullable(2)]
		private static LoginGatewayController _Instance;
	}
}
