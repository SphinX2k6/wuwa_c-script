using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Core.Common;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200157C RID: 5500
[NullableContext(1)]
[Nullable(0)]
public class LoginUdpDelay : IStaticVariableResetter
{
	// Token: 0x0600DC3C RID: 56380 RVA: 0x00413454 File Offset: 0x00411654
	static LoginUdpDelay()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginUdpDelay.CreateStaticDefaultValue), new Action(LoginUdpDelay.ResetStaticDefaultValue));
	}

	// Token: 0x0600DC3D RID: 56381 RVA: 0x00413473 File Offset: 0x00411673
	public static void CreateStaticDefaultValue()
	{
		LoginUdpDelay.ClientIp = "anonymous";
		LoginUdpDelay.TraceId = "";
		LoginUdpDelay.UdpProbe = new List<ValueTuple<string, IUdpProbe>>();
	}

	// Token: 0x0600DC3E RID: 56382 RVA: 0x00413494 File Offset: 0x00411694
	public static void ResetStaticDefaultValue()
	{
		LoginUdpDelay.ProbeState = new ValueTuple<bool, int>(LoginUdpDelay.ProbeState.Item1, LoginUdpDelay.ProbeState.Item2 + 1);
		LoginUdpDelay.ClientIp = "anonymous";
		LoginUdpDelay.TraceId = "";
		LoginUdpDelay.UdpRegionCfg = null;
		LoginUdpDelay.TimerId = null;
		LoginUdpDelay.UdpProbe = null;
	}

	// Token: 0x0600DC3F RID: 56383 RVA: 0x004134E7 File Offset: 0x004116E7
	private static bool IsIPv4(string address)
	{
		return new Regex("^(25[0-5]|2[0-4]\\d|1\\d{2}|[1-9]?\\d)(\\.(25[0-5]|2[0-4]\\d|1\\d{2}|[1-9]?\\d)){3}$").IsMatch(address);
	}

	// Token: 0x0600DC40 RID: 56384 RVA: 0x004134FC File Offset: 0x004116FC
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
		string[] array4 = array2;
		for (int i = 0; i < array4.Length; i++)
		{
			if (!LoginUdpDelay.<IsIPv6>g__IsValidBlock|14_0(array4[i]))
			{
				return false;
			}
		}
		array4 = array3;
		for (int i = 0; i < array4.Length; i++)
		{
			if (!LoginUdpDelay.<IsIPv6>g__IsValidBlock|14_0(array4[i]))
			{
				return false;
			}
		}
		int num = array2.Length + array3.Length;
		if (text2 != null)
		{
			return num < 8;
		}
		return num == 8;
	}

	// Token: 0x0600DC41 RID: 56385 RVA: 0x004135E7 File Offset: 0x004117E7
	private static bool IsDomain(string address)
	{
		return new Regex("^(?=.{1,253}$)(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)+[a-zA-Z]{2,63}$").IsMatch(address);
	}

	// Token: 0x0600DC42 RID: 56386 RVA: 0x004135F9 File Offset: 0x004117F9
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

	// Token: 0x0600DC43 RID: 56387 RVA: 0x0041362C File Offset: 0x0041182C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private static UniTask<TArray<string>> GetDomianIp(string address)
	{
		LoginUdpDelay.<GetDomianIp>d__17 <GetDomianIp>d__;
		<GetDomianIp>d__.<>t__builder = AsyncUniTaskMethodBuilder<TArray<string>>.Create();
		<GetDomianIp>d__.address = address;
		<GetDomianIp>d__.<>1__state = -1;
		<GetDomianIp>d__.<>t__builder.Start<LoginUdpDelay.<GetDomianIp>d__17>(ref <GetDomianIp>d__);
		return <GetDomianIp>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC44 RID: 56388 RVA: 0x00413670 File Offset: 0x00411870
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
		LoginUdpDelay.<GetIP>d__18 <GetIP>d__;
		<GetIP>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<ValueTuple<string, IUdpProbe>>>.Create();
		<GetIP>d__.address = address;
		<GetIP>d__.<>1__state = -1;
		<GetIP>d__.<>t__builder.Start<LoginUdpDelay.<GetIP>d__18>(ref <GetIP>d__);
		return <GetIP>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC45 RID: 56389 RVA: 0x004136B4 File Offset: 0x004118B4
	public static UniTask Start()
	{
		LoginUdpDelay.<Start>d__19 <Start>d__;
		<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Start>d__.<>1__state = -1;
		<Start>d__.<>t__builder.Start<LoginUdpDelay.<Start>d__19>(ref <Start>d__);
		return <Start>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC46 RID: 56390 RVA: 0x004136F0 File Offset: 0x004118F0
	private static UniTask InitClientIp(int probeVersion)
	{
		LoginUdpDelay.<InitClientIp>d__20 <InitClientIp>d__;
		<InitClientIp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitClientIp>d__.probeVersion = probeVersion;
		<InitClientIp>d__.<>1__state = -1;
		<InitClientIp>d__.<>t__builder.Start<LoginUdpDelay.<InitClientIp>d__20>(ref <InitClientIp>d__);
		return <InitClientIp>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC47 RID: 56391 RVA: 0x00413734 File Offset: 0x00411934
	private static UniTask InitProbeInfo(int probeVersion)
	{
		LoginUdpDelay.<InitProbeInfo>d__21 <InitProbeInfo>d__;
		<InitProbeInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitProbeInfo>d__.probeVersion = probeVersion;
		<InitProbeInfo>d__.<>1__state = -1;
		<InitProbeInfo>d__.<>t__builder.Start<LoginUdpDelay.<InitProbeInfo>d__21>(ref <InitProbeInfo>d__);
		return <InitProbeInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC48 RID: 56392 RVA: 0x00413778 File Offset: 0x00411978
	private static void InitTraceId()
	{
		SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
		LoginUdpDelay.TraceId = (((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "") + "_" + UKismetGuidLibrary.NewGuid().ToString();
	}

	// Token: 0x0600DC49 RID: 56393 RVA: 0x004137C6 File Offset: 0x004119C6
	private static string GenUdpPayload(long ts)
	{
		return Json.Encode(new LoginUdpDelay.Payload
		{
			traceId = LoginUdpDelay.TraceId,
			clientIp = LoginUdpDelay.ClientIp,
			timestamp = ts
		}, null);
	}

	// Token: 0x0600DC4A RID: 56394 RVA: 0x004137F0 File Offset: 0x004119F0
	private static void SetTimer(int probeVersion)
	{
		if (probeVersion != LoginUdpDelay.ProbeState.Item2)
		{
			return;
		}
		if (LoginUdpDelay.UdpRegionCfg == null || !LoginUdpDelay.UdpRegionCfg.ProbeOpen)
		{
			return;
		}
		TTimerAction ttimerAction = delegate(float _)
		{
			LoginUdpDelay.ProbeRoundAsync(probeVersion).Forget();
		};
		ttimerAction(0f);
		LoginUdpDelay.TimerId = TimerSystem.RealTimeInstance.Forever(ttimerAction, (float)(LoginUdpDelay.UdpRegionCfg.ProbeInterval * 1000), 1f, null, null, false);
	}

	// Token: 0x0600DC4B RID: 56395 RVA: 0x00413874 File Offset: 0x00411A74
	private static UniTask ProbeRoundAsync(int probeVersion)
	{
		LoginUdpDelay.<ProbeRoundAsync>d__26 <ProbeRoundAsync>d__;
		<ProbeRoundAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ProbeRoundAsync>d__.probeVersion = probeVersion;
		<ProbeRoundAsync>d__.<>1__state = -1;
		<ProbeRoundAsync>d__.<>t__builder.Start<LoginUdpDelay.<ProbeRoundAsync>d__26>(ref <ProbeRoundAsync>d__);
		return <ProbeRoundAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC4D RID: 56397 RVA: 0x004138BF File Offset: 0x00411ABF
	[CompilerGenerated]
	internal static bool <IsIPv6>g__IsValidBlock|14_0(string s)
	{
		return s.Length > 0 && Regex.IsMatch(s, "^[0-9a-fA-F]{1,4}$");
	}

	// Token: 0x04007AF2 RID: 31474
	private static string ClientIp;

	// Token: 0x04007AF3 RID: 31475
	private static string TraceId;

	// Token: 0x04007AF4 RID: 31476
	[Nullable(2)]
	private static IUdpRegion UdpRegionCfg;

	// Token: 0x04007AF5 RID: 31477
	[Nullable(new byte[]
	{
		2,
		0,
		1,
		1
	})]
	private static List<ValueTuple<string, IUdpProbe>> UdpProbe;

	// Token: 0x04007AF6 RID: 31478
	[Nullable(2)]
	private static TimerHandle TimerId;

	// Token: 0x04007AF7 RID: 31479
	[TupleElementNames(new string[]
	{
		"RoundRunning",
		"Version"
	})]
	[Nullable(0)]
	private static ValueTuple<bool, int> ProbeState;

	// Token: 0x04007AF8 RID: 31480
	private const string CLIENT_IP_KEY = "clientIp";

	// Token: 0x04007AF9 RID: 31481
	private const int TEST_PORT = 5500;

	// Token: 0x04007AFA RID: 31482
	private const string REPORT_KEY = "UDP_PROBE";

	// Token: 0x0200781C RID: 30748
	[NullableContext(0)]
	public enum AddressType
	{
		// Token: 0x04026FA6 RID: 159654
		IPv4,
		// Token: 0x04026FA7 RID: 159655
		IPv6,
		// Token: 0x04026FA8 RID: 159656
		Domain,
		// Token: 0x04026FA9 RID: 159657
		Unknown
	}

	// Token: 0x0200781D RID: 30749
	[Nullable(0)]
	[RequiredMember]
	public class Payload
	{
		// Token: 0x06040D8B RID: 265611 RVA: 0x0131EB1E File Offset: 0x0131CD1E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Payload()
		{
		}

		// Token: 0x04026FAA RID: 159658
		[RequiredMember]
		public string traceId;

		// Token: 0x04026FAB RID: 159659
		[RequiredMember]
		public string clientIp;

		// Token: 0x04026FAC RID: 159660
		[RequiredMember]
		public long timestamp;
	}
}
