using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Net;

// Token: 0x020000B3 RID: 179
[NullableContext(1)]
[Nullable(0)]
public class NetInfo : Singleton
{
	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001E8F4 File Offset: 0x0001CAF4
	public float RttMs
	{
		get
		{
			return this.RttMsInternal;
		}
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0001E8FC File Offset: 0x0001CAFC
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

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001E951 File Offset: 0x0001CB51
	// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0001E959 File Offset: 0x0001CB59
	public string LoginTraceId { get; set; }

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001E962 File Offset: 0x0001CB62
	// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0001E96A File Offset: 0x0001CB6A
	public string Token { get; set; }

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001E973 File Offset: 0x0001CB73
	// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0001E97B File Offset: 0x0001CB7B
	public string DeviceId { get; set; }

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001E984 File Offset: 0x0001CB84
	// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0001E98C File Offset: 0x0001CB8C
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

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001E995 File Offset: 0x0001CB95
	// (set) Token: 0x060005AB RID: 1451 RVA: 0x0001E99D File Offset: 0x0001CB9D
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

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001E9A6 File Offset: 0x0001CBA6
	// (set) Token: 0x060005AD RID: 1453 RVA: 0x0001E9AE File Offset: 0x0001CBAE
	public int TcpRatio { get; set; }

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001E9B7 File Offset: 0x0001CBB7
	// (set) Token: 0x060005AF RID: 1455 RVA: 0x0001E9BF File Offset: 0x0001CBBF
	public int TcpRetry { get; set; }

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001E9C8 File Offset: 0x0001CBC8
	// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0001E9D0 File Offset: 0x0001CBD0
	public bool DisableCrc { get; set; }

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001E9D9 File Offset: 0x0001CBD9
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

	// Token: 0x060005B3 RID: 1459 RVA: 0x0001E9FC File Offset: 0x0001CBFC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0001E9FE File Offset: 0x0001CBFE
	public static void ResetStaticDefaultValue()
	{
		NetInfo instance = NetInfo._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		NetInfo._instance = null;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0001EA17 File Offset: 0x0001CC17
	static NetInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NetInfo.CreateStaticDefaultValue), new Action(NetInfo.ResetStaticDefaultValue));
	}

	// Token: 0x04000492 RID: 1170
	private float RttMsInternal;

	// Token: 0x0400049A RID: 1178
	public readonly int TcpMaxRetry = 1;

	// Token: 0x0400049C RID: 1180
	[Nullable(2)]
	private static NetInfo _instance;
}
