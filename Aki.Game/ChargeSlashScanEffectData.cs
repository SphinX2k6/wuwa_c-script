using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using UnrealEngine;

// Token: 0x020032AA RID: 12970
[NullableContext(1)]
[Nullable(0)]
public class ChargeSlashScanEffectData : IStaticVariableResetter
{
	// Token: 0x0601C11D RID: 114973 RVA: 0x007CE0F4 File Offset: 0x007CC2F4
	static ChargeSlashScanEffectData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChargeSlashScanEffectData.CreateStaticDefaultValue), new Action(ChargeSlashScanEffectData.ResetStaticDefaultValue));
	}

	// Token: 0x0601C11E RID: 114974 RVA: 0x007CE114 File Offset: 0x007CC314
	public ChargeSlashScanEffectData(int id, BP_DistortionWave_C actor, FVectorDouble loc)
	{
		this.Id = id;
		this.EffectActor = actor;
		this.CurLoc = new FVectorDouble?(loc);
		this.CurTime = 0f;
		this.CurRadius = 0.0;
	}

	// Token: 0x0601C11F RID: 114975 RVA: 0x007CE171 File Offset: 0x007CC371
	public bool Update(float delta)
	{
		return true;
	}

	// Token: 0x0601C120 RID: 114976 RVA: 0x007CE174 File Offset: 0x007CC374
	private static void InitSphereTrace()
	{
		ChargeSlashScanEffectData.SphereTrace = new UTraceSphereElement();
		ChargeSlashScanEffectData.SphereTrace.WorldContextObject = GlobalData.World;
		ChargeSlashScanEffectData.SphereTrace.bIsSingle = false;
		ChargeSlashScanEffectData.SphereTrace.bIgnoreSelf = true;
		ChargeSlashScanEffectData.SphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldDynamic);
		ChargeSlashScanEffectData.SphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
		ChargeSlashScanEffectData.SphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.KuroTrigger);
		ChargeSlashScanEffectData.SphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
		ChargeSlashScanEffectData.SphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
		if (ChargeSlashScanEffectData.Timer == null)
		{
			TimerSystemInstance instance = TimerSystem.Instance;
			TTimerAction action;
			if ((action = ChargeSlashScanEffectData.<>O.<0>__CheckAndReleaseActor) == null)
			{
				action = (ChargeSlashScanEffectData.<>O.<0>__CheckAndReleaseActor = new TTimerAction(ChargeSlashScanEffectData.CheckAndReleaseActor));
			}
			ChargeSlashScanEffectData.Timer = instance.Forever(action, 5000f, 1f, null, null, true);
		}
	}

	// Token: 0x0601C121 RID: 114977 RVA: 0x007CE239 File Offset: 0x007CC439
	private static void CheckAndReleaseActor(float delta)
	{
		if (ChargeSlashScanEffectData.UseTrace)
		{
			ChargeSlashScanEffectData.UseTrace = false;
			return;
		}
		if (ChargeSlashScanEffectData.SphereTrace != null)
		{
			ChargeSlashScanEffectData.SphereTrace.Dispose();
			ChargeSlashScanEffectData.SphereTrace = null;
		}
		TimerSystem.Instance.Remove(ChargeSlashScanEffectData.Timer);
		ChargeSlashScanEffectData.Timer = null;
	}

	// Token: 0x0601C122 RID: 114978 RVA: 0x007CE276 File Offset: 0x007CC476
	public static void CreateStaticDefaultValue()
	{
		ChargeSlashScanEffectData.SphereTrace = null;
		ChargeSlashScanEffectData.UseTrace = false;
		ChargeSlashScanEffectData.Timer = null;
	}

	// Token: 0x0601C123 RID: 114979 RVA: 0x007CE28A File Offset: 0x007CC48A
	public static void ResetStaticDefaultValue()
	{
		ChargeSlashScanEffectData.SphereTrace = null;
		ChargeSlashScanEffectData.UseTrace = false;
		ChargeSlashScanEffectData.Timer = null;
	}

	// Token: 0x0400DDE4 RID: 56804
	private const float SCAN_EFFECT_STOP_TIME = 1.6f;

	// Token: 0x0400DDE5 RID: 56805
	private const int TIMER_PERIOD = 5000;

	// Token: 0x0400DDE6 RID: 56806
	public int Id;

	// Token: 0x0400DDE7 RID: 56807
	[Nullable(2)]
	public BP_DistortionWave_C EffectActor;

	// Token: 0x0400DDE8 RID: 56808
	private readonly FVectorDouble? CurLoc;

	// Token: 0x0400DDE9 RID: 56809
	private float CurTime;

	// Token: 0x0400DDEA RID: 56810
	private double CurRadius;

	// Token: 0x0400DDEB RID: 56811
	private readonly HashSet<AActor> ScannedActor = new HashSet<AActor>();

	// Token: 0x0400DDEC RID: 56812
	private readonly HashSet<TsBaseCharacter> TsBaseCharSet = new HashSet<TsBaseCharacter>();

	// Token: 0x0400DDED RID: 56813
	[Nullable(2)]
	private static UTraceSphereElement SphereTrace;

	// Token: 0x0400DDEE RID: 56814
	private static bool UseTrace;

	// Token: 0x0400DDEF RID: 56815
	[Nullable(2)]
	private static TimerHandle Timer;

	// Token: 0x02009741 RID: 38721
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04030657 RID: 198231
		[Nullable(0)]
		public static TTimerAction <0>__CheckAndReleaseActor;
	}
}
