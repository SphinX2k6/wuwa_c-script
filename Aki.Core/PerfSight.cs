using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x020000C9 RID: 201
[NullableContext(1)]
[Nullable(0)]
public class PerfSight : Singleton
{
	// Token: 0x06000660 RID: 1632 RVA: 0x000211C0 File Offset: 0x0001F3C0
	public bool Initialize()
	{
		if (!this.IsEnable)
		{
			return true;
		}
		Func<bool> isGlobalAreaHook = PerfSight.IsGlobalAreaHook;
		bool flag = isGlobalAreaHook != null && isGlobalAreaHook();
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			if (flag)
			{
				UPerfSightHelper.SetPCServerURL("pc.perfsight.wetest.net");
			}
			else
			{
				UPerfSightHelper.SetPCServerURL("pc.perfsight.qq.com");
			}
		}
		if (flag)
		{
			UPerfSightHelper.InitContext("424155224");
		}
		else
		{
			UPerfSightHelper.InitContext("688476493");
		}
		return true;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00021228 File Offset: 0x0001F428
	public void SetPcAppVersion(string version)
	{
		UPerfSightHelper.SetPCAppVersion(version);
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00021230 File Offset: 0x0001F430
	public void SetVersionIden(string version)
	{
		UPerfSightHelper.SetVersionIden(version);
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00021238 File Offset: 0x0001F438
	[NullableContext(2)]
	public void PostEvent(int key, string info = null)
	{
		UPerfSightHelper.PostEvent(key, info);
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00021241 File Offset: 0x0001F441
	public void MarkLevelLoad(string sceneName, int? quality = null)
	{
		UPerfSightHelper.MarkLevelLoad(sceneName, quality.GetValueOrDefault());
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00021250 File Offset: 0x0001F450
	public void MarkLevelFin()
	{
		UPerfSightHelper.MarkLevelFin();
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00021257 File Offset: 0x0001F457
	public void MarkLevelLoadCompleted()
	{
		UPerfSightHelper.MarkLevelLoadCompleted();
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0002125E File Offset: 0x0001F45E
	public void SetUserId(string playerId)
	{
		UPerfSightHelper.SetUserId(playerId);
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00021266 File Offset: 0x0001F466
	[NullableContext(2)]
	public void PostNetworkLatency(int latency, string customInfo = null, string ipAddress = null)
	{
		UPerfSightHelper.PostNetworkLatency(latency, customInfo, ipAddress);
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000669 RID: 1641 RVA: 0x00021270 File Offset: 0x0001F470
	public static PerfSight Instance
	{
		get
		{
			if (PerfSight._instance == null)
			{
				PerfSight._instance = new PerfSight();
				PerfSight._instance.OnInit();
			}
			return PerfSight._instance;
		}
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00021293 File Offset: 0x0001F493
	public static void CreateStaticDefaultValue()
	{
		PerfSight.OnCreateStaticDefaultValue();
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0002129A File Offset: 0x0001F49A
	public static void ResetStaticDefaultValue()
	{
		PerfSight instance = PerfSight._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		PerfSight._instance = null;
		PerfSight.OnResetStaticDefaultValue();
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x000212B8 File Offset: 0x0001F4B8
	private static void OnCreateStaticDefaultValue()
	{
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x000212BA File Offset: 0x0001F4BA
	private static void OnResetStaticDefaultValue()
	{
		PerfSight.IsGlobalAreaHook = null;
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x000212C2 File Offset: 0x0001F4C2
	static PerfSight()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerfSight.CreateStaticDefaultValue), new Action(PerfSight.ResetStaticDefaultValue));
	}

	// Token: 0x04000504 RID: 1284
	public static Func<bool> IsGlobalAreaHook;

	// Token: 0x04000505 RID: 1285
	private const bool DEBUG_LOG = false;

	// Token: 0x04000506 RID: 1286
	private const string APP_ID_LOCAL = "688476493";

	// Token: 0x04000507 RID: 1287
	private const string APP_ID_GLOBAL = "424155224";

	// Token: 0x04000508 RID: 1288
	public bool IsEnable = true;

	// Token: 0x04000509 RID: 1289
	[Nullable(2)]
	private static PerfSight _instance;
}
