using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using UnrealEngine;

// Token: 0x0200281B RID: 10267
[NullableContext(1)]
[Nullable(0)]
public class ChargeSlashScanEffectData : IStaticVariableResetter
{
	// Token: 0x06019D55 RID: 105813 RVA: 0x007F52C4 File Offset: 0x007F34C4
	static ChargeSlashScanEffectData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChargeSlashScanEffectData.CreateStaticDefaultValue), new Action(ChargeSlashScanEffectData.ResetStaticDefaultValue));
	}

	// Token: 0x06019D56 RID: 105814 RVA: 0x007F52E4 File Offset: 0x007F34E4
	public ChargeSlashScanEffectData(int id, BP_DistortionWave_C actor, FVectorDouble loc)
	{
		this.Id = id;
		this.EffectActor = actor;
		this.CurLoc = new FVectorDouble?(loc);
		this.CurTime = 0f;
		this.CurRadius = 0.0;
	}

	// Token: 0x06019D57 RID: 105815 RVA: 0x007F5341 File Offset: 0x007F3541
	public bool Update(float delta)
	{
		return true;
	}

	// Token: 0x06019D58 RID: 105816 RVA: 0x007F5344 File Offset: 0x007F3544
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

	// Token: 0x06019D59 RID: 105817 RVA: 0x007F5409 File Offset: 0x007F3609
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

	// Token: 0x06019D5A RID: 105818 RVA: 0x007F5446 File Offset: 0x007F3646
	public static void CreateStaticDefaultValue()
	{
		ChargeSlashScanEffectData.SphereTrace = null;
		ChargeSlashScanEffectData.UseTrace = false;
		ChargeSlashScanEffectData.Timer = null;
	}

	// Token: 0x06019D5B RID: 105819 RVA: 0x007F545A File Offset: 0x007F365A
	public static void ResetStaticDefaultValue()
	{
		ChargeSlashScanEffectData.SphereTrace = null;
		ChargeSlashScanEffectData.UseTrace = false;
		ChargeSlashScanEffectData.Timer = null;
	}

	// Token: 0x0400E28A RID: 57994
	private const float SCAN_EFFECT_STOP_TIME = 1.6f;

	// Token: 0x0400E28B RID: 57995
	private const int TIMER_PERIOD = 5000;

	// Token: 0x0400E28C RID: 57996
	public int Id;

	// Token: 0x0400E28D RID: 57997
	[Nullable(2)]
	public BP_DistortionWave_C EffectActor;

	// Token: 0x0400E28E RID: 57998
	private readonly FVectorDouble? CurLoc;

	// Token: 0x0400E28F RID: 57999
	private float CurTime;

	// Token: 0x0400E290 RID: 58000
	private double CurRadius;

	// Token: 0x0400E291 RID: 58001
	private readonly HashSet<AActor> ScannedActor = new HashSet<AActor>();

	// Token: 0x0400E292 RID: 58002
	private readonly HashSet<TsBaseCharacter> TsBaseCharSet = new HashSet<TsBaseCharacter>();

	// Token: 0x0400E293 RID: 58003
	[Nullable(2)]
	private static UTraceSphereElement SphereTrace;

	// Token: 0x0400E294 RID: 58004
	private static bool UseTrace;

	// Token: 0x0400E295 RID: 58005
	[Nullable(2)]
	private static TimerHandle Timer;

	// Token: 0x02008968 RID: 35176
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BCEE RID: 179438
		[Nullable(0)]
		public static TTimerAction <0>__CheckAndReleaseActor;
	}
}
