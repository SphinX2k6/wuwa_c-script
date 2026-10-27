using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Core.Common;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020A5 RID: 8357
[NullableContext(1)]
[Nullable(0)]
public class LoginUdpDelay : IStaticVariableResetter
{
	// Token: 0x060107CE RID: 67534 RVA: 0x00406E40 File Offset: 0x00405040
	static LoginUdpDelay()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginUdpDelay.CreateStaticDefaultValue), new Action(LoginUdpDelay.ResetStaticDefaultValue));
	}

	// Token: 0x060107CF RID: 67535 RVA: 0x00406E5F File Offset: 0x0040505F
	public static void CreateStaticDefaultValue()
	{
		LoginUdpDelay.ClientIp = "anonymous";
		LoginUdpDelay.TraceId = "";
		LoginUdpDelay.UdpProbe = new List<ValueTuple<string, IUdpProbe>>();
	}

	// Token: 0x060107D0 RID: 67536 RVA: 0x00406E7F File Offset: 0x0040507F
	public static void ResetStaticDefaultValue()
	{
		LoginUdpDelay.ClientIp = "anonymous";
		LoginUdpDelay.TraceId = "";
		LoginUdpDelay.UdpRegionCfg = null;
		LoginUdpDelay.TimerId = null;
		LoginUdpDelay.UdpProbe = null;
	}

	// Token: 0x060107D1 RID: 67537 RVA: 0x00406EA7 File Offset: 0x004050A7
	private static bool IsIPv4(string address)
	{
		return new Regex("^(25[0-5]|2[0-4]\\d|1\\d{2}|[1-9]?\\d)(\\.(25[0-5]|2[0-4]\\d|1\\d{2}|[1-9]?\\d)){3}$").IsMatch(address);
	}

	// Token: 0x060107D2 RID: 67538 RVA: 0x00406EBC File Offset: 0x004050BC
	private static bool IsIPv6(string address)
	{
		if (string.IsNullOrEmpty(address))
		{
			return false;
		}
		if (address.Contains("."))
		{
			return false;
		}
		string[] array = address.Split(new string[]
		{
			"::"
		}, StringSplitOptions.None);
		if (array.Length > 2)
		{
			return false;
		}
		string text = array[0];
		string text2 = (array.Length > 1) ? array[1] : null;
		string[] array2 = (!string.IsNullOrEmpty(text)) ? text.Split(':', StringSplitOptions.None) : new string[0];
		string[] array3 = (!string.IsNullOrEmpty(text2)) ? text2.Split(':', StringSplitOptions.None) : new string[0];
		if (!array2.All(new Func<string, bool>(LoginUdpDelay.<IsIPv6>g__IsValidBlock|13_0)) || !array3.All(new Func<string, bool>(LoginUdpDelay.<IsIPv6>g__IsValidBlock|13_0)))
		{
			return false;
		}
		int num = array2.Length + array3.Length;
		if (text2 != null)
		{
			return num < 8;
		}
		return num == 8;
	}

	// Token: 0x060107D3 RID: 67539 RVA: 0x00406F89 File Offset: 0x00405189
	private static bool IsDomain(string address)
	{
		return new Regex("^(?=.{1,253}$)(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)+[a-zA-Z]{2,63}$").IsMatch(address);
	}

	// Token: 0x060107D4 RID: 67540 RVA: 0x00406F9B File Offset: 0x0040519B
	private static LoginUdpDelay.AddressType GetAddressType(string address)
	{
		address = address.Trim();
		if (string.IsNullOrEmpty(address))
		{
			return LoginUdpDelay.AddressType.Unknown;
		}
		if (LoginUdpDelay.IsIPv4(address))
		{
			return LoginUdpDelay.AddressType.IPv4;
		}
		if (LoginUdpDelay.IsIPv6(address))
		{
			return LoginUdpDelay.AddressType.IPv6;
		}
		if (LoginUdpDelay.IsDomain(address))
		{
			return LoginUdpDelay.AddressType.Domain;
		}
		return LoginUdpDelay.AddressType.Unknown;
	}

	// Token: 0x060107D5 RID: 67541 RVA: 0x00406FD0 File Offset: 0x004051D0
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private static UniTask<TArray<string>> GetDomianIp(string address)
	{
		LoginUdpDelay.<GetDomianIp>d__16 <GetDomianIp>d__;
		<GetDomianIp>d__.<>t__builder = AsyncUniTaskMethodBuilder<TArray<string>>.Create();
		<GetDomianIp>d__.address = address;
		<GetDomianIp>d__.<>1__state = -1;
		<GetDomianIp>d__.<>t__builder.Start<LoginUdpDelay.<GetDomianIp>d__16>(ref <GetDomianIp>d__);
		return <GetDomianIp>d__.<>t__builder.Task;
	}

	// Token: 0x060107D6 RID: 67542 RVA: 0x00407014 File Offset: 0x00405214
	[return: Nullable(new byte[]
	{
		0,
		1,
		0,
		1,
		1
	})]
	private static UniTask<List<ValueTuple<string, IUdpProbe>>> GetIP(List<IUdpProbe> address)
	{
		LoginUdpDelay.<GetIP>d__17 <GetIP>d__;
		<GetIP>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<ValueTuple<string, IUdpProbe>>>.Create();
		<GetIP>d__.address = address;
		<GetIP>d__.<>1__state = -1;
		<GetIP>d__.<>t__builder.Start<LoginUdpDelay.<GetIP>d__17>(ref <GetIP>d__);
		return <GetIP>d__.<>t__builder.Task;
	}

	// Token: 0x060107D7 RID: 67543 RVA: 0x00407058 File Offset: 0x00405258
	public static UniTask Start()
	{
		LoginUdpDelay.<Start>d__18 <Start>d__;
		<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Start>d__.<>1__state = -1;
		<Start>d__.<>t__builder.Start<LoginUdpDelay.<Start>d__18>(ref <Start>d__);
		return <Start>d__.<>t__builder.Task;
	}

	// Token: 0x060107D8 RID: 67544 RVA: 0x00407094 File Offset: 0x00405294
	private static UniTask InitClientIp()
	{
		LoginUdpDelay.<InitClientIp>d__19 <InitClientIp>d__;
		<InitClientIp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitClientIp>d__.<>1__state = -1;
		<InitClientIp>d__.<>t__builder.Start<LoginUdpDelay.<InitClientIp>d__19>(ref <InitClientIp>d__);
		return <InitClientIp>d__.<>t__builder.Task;
	}

	// Token: 0x060107D9 RID: 67545 RVA: 0x004070D0 File Offset: 0x004052D0
	private static UniTask InitProbeInfo()
	{
		LoginUdpDelay.<InitProbeInfo>d__20 <InitProbeInfo>d__;
		<InitProbeInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitProbeInfo>d__.<>1__state = -1;
		<InitProbeInfo>d__.<>t__builder.Start<LoginUdpDelay.<InitProbeInfo>d__20>(ref <InitProbeInfo>d__);
		return <InitProbeInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060107DA RID: 67546 RVA: 0x0040710C File Offset: 0x0040530C
	private static void InitTraceId()
	{
		SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
		LoginUdpDelay.TraceId = (((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "") + "_" + UKismetGuidLibrary.NewGuid().ToString();
	}

	// Token: 0x060107DB RID: 67547 RVA: 0x0040715A File Offset: 0x0040535A
	private static string GenUdpPayload(long ts)
	{
		return Json.Encode(new LoginUdpDelay.Payload
		{
			traceId = LoginUdpDelay.TraceId,
			clientIp = LoginUdpDelay.ClientIp,
			timestamp = ts
		}, null);
	}

	// Token: 0x060107DC RID: 67548 RVA: 0x00407184 File Offset: 0x00405384
	private static void SetTimer()
	{
		if (LoginUdpDelay.UdpRegionCfg == null)
		{
			return;
		}
		if (!LoginUdpDelay.UdpRegionCfg.ProbeOpen)
		{
			return;
		}
		if (LoginUdpDelay.TimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(LoginUdpDelay.TimerId);
			LoginUdpDelay.TimerId = null;
		}
		TTimerAction ttimerAction = delegate(float _)
		{
			using (List<ValueTuple<string, IUdpProbe>>.Enumerator enumerator = LoginUdpDelay.UdpProbe.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					LoginUdpDelay.<>c__DisplayClass24_0 CS$<>8__locals1 = new LoginUdpDelay.<>c__DisplayClass24_0();
					CS$<>8__locals1.srvInfo = enumerator.Current;
					CS$<>8__locals1.sendTs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
					string message = LoginUdpDelay.GenUdpPayload(CS$<>8__locals1.sendTs);
					UKuroUdp.SendUdpMessage(CS$<>8__locals1.srvInfo.Item2.ip, CS$<>8__locals1.srvInfo.Item2.port, message, 512, DelegateUtils.ToManualReleaseDelegate<FUdpDelegate>(new Action<bool, string>(CS$<>8__locals1.<SetTimer>g__udpCallback|1)));
				}
			}
		};
		ttimerAction(0f);
		LoginUdpDelay.TimerId = TimerSystem.RealTimeInstance.Forever(ttimerAction, (float)(LoginUdpDelay.UdpRegionCfg.ProbeInterval * 1000), 1f, null, null, false);
	}

	// Token: 0x060107DE RID: 67550 RVA: 0x0040721F File Offset: 0x0040541F
	[CompilerGenerated]
	internal static bool <IsIPv6>g__IsValidBlock|13_0(string s)
	{
		return s.Length > 0 && Regex.IsMatch(s, "^[0-9a-fA-F]{1,4}$");
	}

	// Token: 0x040079F4 RID: 31220
	private static string ClientIp;

	// Token: 0x040079F5 RID: 31221
	private static string TraceId;

	// Token: 0x040079F6 RID: 31222
	[Nullable(2)]
	private static IUdpRegion UdpRegionCfg;

	// Token: 0x040079F7 RID: 31223
	[Nullable(new byte[]
	{
		2,
		0,
		1,
		1
	})]
	private static List<ValueTuple<string, IUdpProbe>> UdpProbe;

	// Token: 0x040079F8 RID: 31224
	[Nullable(2)]
	private static TimerHandle TimerId;

	// Token: 0x040079F9 RID: 31225
	private const string CLIENT_IP_KEY = "clientIp";

	// Token: 0x040079FA RID: 31226
	private const int TEST_PORT = 5500;

	// Token: 0x040079FB RID: 31227
	private const string REPORT_KEY = "UDP_PROBE";

	// Token: 0x02008693 RID: 34451
	[NullableContext(0)]
	public enum AddressType
	{
		// Token: 0x0402BC91 RID: 179345
		IPv4,
		// Token: 0x0402BC92 RID: 179346
		IPv6,
		// Token: 0x0402BC93 RID: 179347
		Domain,
		// Token: 0x0402BC94 RID: 179348
		Unknown
	}

	// Token: 0x02008694 RID: 34452
	[Nullable(0)]
	[RequiredMember]
	public class Payload
	{
		// Token: 0x0604A990 RID: 305552 RVA: 0x0137B61E File Offset: 0x0137981E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Payload()
		{
		}

		// Token: 0x0402BC95 RID: 179349
		[RequiredMember]
		public string traceId;

		// Token: 0x0402BC96 RID: 179350
		[RequiredMember]
		public string clientIp;

		// Token: 0x0402BC97 RID: 179351
		[RequiredMember]
		public long timestamp;
	}
}
