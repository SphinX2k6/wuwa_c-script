using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Net;

// Token: 0x020000B5 RID: 181
[NullableContext(1)]
[Nullable(0)]
public class NetInfo : Singleton
{
	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001EF98 File Offset: 0x0001D198
	public float RttMs
	{
		get
		{
			return this.RttMsInternal;
		}
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0001EFA0 File Offset: 0x0001D1A0
	public void SetRttMs(int rttMs)
	{
		if ((float)rttMs < this.RttMsInternal)
		{
			this.RttMsInternal = (float)rttMs;
		}
		else
		{
			this.RttMsInternal = this.RttMsInternal * 0.9f + (float)rttMs * 0.1f;
		}
		if (PerfSight.Instance.IsEnable)
		{
			PerfSight.Instance.PostNetworkLatency(rttMs, null, null);
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001EFF5 File Offset: 0x0001D1F5
	// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0001EFFD File Offset: 0x0001D1FD
	public string LoginTraceId { get; set; }

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001F006 File Offset: 0x0001D206
	// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0001F00E File Offset: 0x0001D20E
	public string Token { get; set; }

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001F017 File Offset: 0x0001D217
	// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0001F01F File Offset: 0x0001D21F
	public string DeviceId { get; set; }

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0001F028 File Offset: 0x0001D228
	// (set) Token: 0x060005EA RID: 1514 RVA: 0x0001F030 File Offset: 0x0001D230
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<NetHostInfo> UdpHosts { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001F039 File Offset: 0x0001D239
	// (set) Token: 0x060005EC RID: 1516 RVA: 0x0001F041 File Offset: 0x0001D241
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<NetHostInfo> TcpHosts { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001F04A File Offset: 0x0001D24A
	// (set) Token: 0x060005EE RID: 1518 RVA: 0x0001F052 File Offset: 0x0001D252
	public int TcpRatio { get; set; }

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001F05B File Offset: 0x0001D25B
	// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0001F063 File Offset: 0x0001D263
	public int TcpRetry { get; set; }

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001F06C File Offset: 0x0001D26C
	// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0001F074 File Offset: 0x0001D274
	public bool DisableCrc { get; set; }

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001F07D File Offset: 0x0001D27D
	public static NetInfo Instance
	{
		get
		{
			if (NetInfo._instance == null)
			{
				NetInfo._instance = new NetInfo();
				NetInfo._instance.OnInit();
			}
			return NetInfo._instance;
		}
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0001F0A0 File Offset: 0x0001D2A0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0001F0A2 File Offset: 0x0001D2A2
	public static void ResetStaticDefaultValue()
	{
		NetInfo instance = NetInfo._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		NetInfo._instance = null;
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0001F0BB File Offset: 0x0001D2BB
	static NetInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NetInfo.CreateStaticDefaultValue), new Action(NetInfo.ResetStaticDefaultValue));
	}

	// Token: 0x040004A0 RID: 1184
	private float RttMsInternal;

	// Token: 0x040004A8 RID: 1192
	public readonly int TcpMaxRetry = 1;

	// Token: 0x040004AA RID: 1194
	[Nullable(2)]
	private static NetInfo _instance;
}
