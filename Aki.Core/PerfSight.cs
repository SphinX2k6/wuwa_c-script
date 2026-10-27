using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000C7 RID: 199
[NullableContext(1)]
[Nullable(0)]
public class PerfSight : Singleton
{
	// Token: 0x0600061F RID: 1567 RVA: 0x00020C94 File Offset: 0x0001EE94
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
		FKuroPerfSightHelper.SetFlameGraphQueueSize(20480);
		FKuroPerfSightHelper.SetFlameGraphDropThresholds(Info.Instance.IsPlayInEditor ? 100000 : 50000);
		if (!Info.Instance.IsPlayInEditor && !Info.Instance.IsPs5Platform())
		{
			FKuroPerfSightHelper.RegisterOnFrameBegin("FrameTime");
			FKuroPerfSightHelper.RegisterTickGroupEvent();
		}
		return true;
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00020D4A File Offset: 0x0001EF4A
	public void SetPcAppVersion(string version)
	{
		UPerfSightHelper.SetPCAppVersion(version);
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00020D52 File Offset: 0x0001EF52
	public void SetVersionIden(string version)
	{
		UPerfSightHelper.SetVersionIden(version);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00020D5A File Offset: 0x0001EF5A
	[NullableContext(2)]
	public void PostEvent(int key, string info = null)
	{
		UPerfSightHelper.PostEvent(key, info);
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00020D63 File Offset: 0x0001EF63
	public void MarkLevelLoad(string sceneName, int? quality = null)
	{
		UPerfSightHelper.MarkLevelLoad(sceneName, quality.GetValueOrDefault());
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00020D72 File Offset: 0x0001EF72
	public void MarkLevelFin()
	{
		UPerfSightHelper.MarkLevelFin();
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00020D79 File Offset: 0x0001EF79
	public void MarkLevelLoadCompleted()
	{
		UPerfSightHelper.MarkLevelLoadCompleted();
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00020D80 File Offset: 0x0001EF80
	public void SetUserId(string playerId)
	{
		UPerfSightHelper.SetUserId(playerId);
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00020D88 File Offset: 0x0001EF88
	[NullableContext(2)]
	public void PostNetworkLatency(int latency, string customInfo = null, string ipAddress = null)
	{
		UPerfSightHelper.PostNetworkLatency(latency, customInfo, ipAddress);
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000628 RID: 1576 RVA: 0x00020D92 File Offset: 0x0001EF92
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

	// Token: 0x06000629 RID: 1577 RVA: 0x00020DB5 File Offset: 0x0001EFB5
	public static void CreateStaticDefaultValue()
	{
		PerfSight.OnCreateStaticDefaultValue();
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00020DBC File Offset: 0x0001EFBC
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

	// Token: 0x0600062B RID: 1579 RVA: 0x00020DDA File Offset: 0x0001EFDA
	private static void OnCreateStaticDefaultValue()
	{
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00020DDC File Offset: 0x0001EFDC
	private static void OnResetStaticDefaultValue()
	{
		PerfSight.IsGlobalAreaHook = null;
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x00020DE4 File Offset: 0x0001EFE4
	static PerfSight()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerfSight.CreateStaticDefaultValue), new Action(PerfSight.ResetStaticDefaultValue));
	}

	// Token: 0x040004F6 RID: 1270
	public static Func<bool> IsGlobalAreaHook;

	// Token: 0x040004F7 RID: 1271
	private const bool DEBUG_LOG = false;

	// Token: 0x040004F8 RID: 1272
	private const string APP_ID_LOCAL = "688476493";

	// Token: 0x040004F9 RID: 1273
	private const string APP_ID_GLOBAL = "424155224";

	// Token: 0x040004FA RID: 1274
	public bool IsEnable = true;

	// Token: 0x040004FB RID: 1275
	[Nullable(2)]
	private static PerfSight _instance;
}
