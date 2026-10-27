using System;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

// Token: 0x02000040 RID: 64
[NullableContext(1)]
[Nullable(0)]
public class Time : Singleton
{
	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000192 RID: 402 RVA: 0x0000A2EE File Offset: 0x000084EE
	public double ServerTimeStamp
	{
		get
		{
			return KuroTime.GetMilliseconds64() + this.ServerTimeStampOffsetInternal;
		}
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000A2FC File Offset: 0x000084FC
	public void SetServerTimeStamp(double serverTimeStampMs)
	{
		double num = serverTimeStampMs + (double)(NetInfo.Instance.RttMs / 2f) - KuroTime.GetMilliseconds64();
		this.ServerTimeStampOffsetInternal = num;
		if (this.LastServerTime == 0.0)
		{
			this.LastServerTime = num;
		}
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0000A342 File Offset: 0x00008542
	public void SetServerFlowTimeStamp(double flowTimeStampMs)
	{
		this.ServerFlowTimeStampOffsetInternal = flowTimeStampMs + (double)(NetInfo.Instance.RttMs / 2f) - this.FlowTime;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0000A364 File Offset: 0x00008564
	public void SyncTime(double serverTimeStampMs, double flowTimeStampMs, double serverCombatTimeOffsetMs, double serverStopTimeOffsetMs)
	{
		this.SetServerTimeStamp(serverTimeStampMs);
		this.SetServerTimeOffset(serverTimeStampMs - this.Now);
		this.SetServerStopTimeOffset(serverStopTimeOffsetMs);
		this.SetServerFlowTimeStamp(flowTimeStampMs);
		this.ServerCombatTimeOffsetInternal = serverCombatTimeOffsetMs;
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000196 RID: 406 RVA: 0x0000A391 File Offset: 0x00008591
	public float TimeDilation
	{
		get
		{
			return this.WorldTimeDilationInternal;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A399 File Offset: 0x00008599
	public float FlowTimeDilation
	{
		get
		{
			return this.FlowTimeDilationInternal;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000198 RID: 408 RVA: 0x0000A3A1 File Offset: 0x000085A1
	public double ServerStopTimeStamp
	{
		get
		{
			return this.ServerStopTimeStampOffsetInner + this.WorldTime + (double)(NetInfo.Instance.RttMs / 2f);
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A3C2 File Offset: 0x000085C2
	public float InverseSelfCenteredTimeDilation
	{
		get
		{
			return this.InverseSelfCenteredTimeDilationInternal;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600019A RID: 410 RVA: 0x0000A3CA File Offset: 0x000085CA
	public double ServerFlowTimeStamp
	{
		get
		{
			return this.ServerFlowTimeStampOffsetInternal + this.FlowTime + (double)(NetInfo.Instance.RttMs / 2f);
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A3EB File Offset: 0x000085EB
	public double ServerCombatStopTime
	{
		get
		{
			return Math.Floor(this.ServerCombatTimeOffsetInternal + this.FlowTime + (double)(NetInfo.Instance.RttMs / 2f));
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600019C RID: 412 RVA: 0x0000A411 File Offset: 0x00008611
	public double CombatServerTime
	{
		get
		{
			return (double)((long)Math.Floor(this.ServerTimeOffsetInternal + this.Now + (double)(NetInfo.Instance.RttMs / 2f)));
		}
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0000A439 File Offset: 0x00008639
	public void SetServerTimeOffset(double serverTimeOffsetMs)
	{
		this.ServerTimeOffsetInternal = serverTimeOffsetMs;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0000A442 File Offset: 0x00008642
	public void SetServerStopTimeOffset(double serverStopTimeOffsetMs)
	{
		this.ServerStopTimeStampOffsetInner = serverStopTimeOffsetMs;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000A44B File Offset: 0x0000864B
	public void SetTimeDilation(float timeDilation)
	{
		this.WorldTimeDilationInternal = timeDilation;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0000A454 File Offset: 0x00008654
	public void SetFlowTimeDilation(float timeDilation)
	{
		this.FlowTimeDilationInternal = timeDilation;
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000A45D File Offset: 0x0000865D
	public void SetInverseSelfCenteredTimeDilation(float timeDilation)
	{
		this.InverseSelfCenteredTimeDilationInternal = timeDilation;
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000A466 File Offset: 0x00008666
	public float DeltaTime
	{
		get
		{
			return this.DeltaTimeMsInternal;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000A46E File Offset: 0x0000866E
	public float DeltaTimeSeconds
	{
		get
		{
			return this.DeltaTimeMsInternal * 0.001f;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000A47C File Offset: 0x0000867C
	public int Frame
	{
		get
		{
			return this.FrameInternal;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000A484 File Offset: 0x00008684
	public double Now
	{
		get
		{
			return this.FrameNowInternal;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000A48C File Offset: 0x0000868C
	public double NowSeconds
	{
		get
		{
			return this.FrameNowInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000A49E File Offset: 0x0000869E
	public double PlayerTime
	{
		get
		{
			return this.FramePlayerTimeInternal;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000A4A6 File Offset: 0x000086A6
	public double PlayerTimeSeconds
	{
		get
		{
			return this.FramePlayerTimeInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000A4B8 File Offset: 0x000086B8
	public double WorldTime
	{
		get
		{
			return this.FrameWorldTimeInternal;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060001AA RID: 426 RVA: 0x0000A4C0 File Offset: 0x000086C0
	public double WorldTimeSeconds
	{
		get
		{
			return this.FrameWorldTimeInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060001AB RID: 427 RVA: 0x0000A4D2 File Offset: 0x000086D2
	public double PlayerWorldTime
	{
		get
		{
			return this.FramePlayerWorldTimeInternal;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001AC RID: 428 RVA: 0x0000A4DA File Offset: 0x000086DA
	public double PlayerWorldTimeSeconds
	{
		get
		{
			return this.FramePlayerWorldTimeInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A4EC File Offset: 0x000086EC
	public double FlowTime
	{
		get
		{
			return this.FrameFlowTimeInternal;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060001AE RID: 430 RVA: 0x0000A4F4 File Offset: 0x000086F4
	public double SystemNow
	{
		get
		{
			return this.SystemNowInternal;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060001AF RID: 431 RVA: 0x0000A4FC File Offset: 0x000086FC
	public double SystemNowSeconds
	{
		get
		{
			return this.SystemNowInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000A50E File Offset: 0x0000870E
	public bool IsAfterPrePhysicTick
	{
		get
		{
			return this.AfterTickFrameInternal == this.Frame;
		}
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0000A51E File Offset: 0x0000871E
	public void AfterTickPriority1(float delta)
	{
		this.AfterTickFrameInternal = this.FrameInternal;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0000A52C File Offset: 0x0000872C
	public void Initialize()
	{
		this.FrameInternal = 0;
		this.FrameNowInternal = 0.0;
		this.FrameWorldTimeInternal = 0.0;
		this.FrameFlowTimeInternal = 0.0;
		this.DeltaTimeMsInternal = 0f;
		this.SystemNowInternal = 0.0;
		this.SystemStart = (double)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		this.OriginTimeDilation = 1f;
		this.WorldTimeDilationInternal = 1f;
		this.FlowTimeDilationInternal = 1f;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0000A5BC File Offset: 0x000087BC
	public void Tick(float delta)
	{
		this.DeltaTimeMsInternal = delta;
		this.FrameInternal++;
		this.FrameNowInternal += (double)delta;
		this.FramePlayerTimeInternal += (double)delta * (double)this.InverseSelfCenteredTimeDilationInternal;
		this.FrameWorldTimeInternal += (double)delta * (double)this.WorldTimeDilationInternal;
		this.FramePlayerWorldTimeInternal += (double)delta * (double)this.WorldTimeDilationInternal * (double)this.InverseSelfCenteredTimeDilationInternal;
		this.FrameFlowTimeInternal += (double)delta * (double)this.WorldTimeDilationInternal * (double)this.FlowTimeDilationInternal;
		this.SystemNowInternal = (double)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - this.SystemStart;
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000A674 File Offset: 0x00008874
	public static Time Instance
	{
		get
		{
			if (Time._instance == null)
			{
				Time._instance = new Time();
				Time._instance.OnInit();
			}
			return Time._instance;
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0000A697 File Offset: 0x00008897
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0000A699 File Offset: 0x00008899
	public static void ResetStaticDefaultValue()
	{
		Time instance = Time._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Time._instance = null;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0000A6B2 File Offset: 0x000088B2
	static Time()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Time.CreateStaticDefaultValue), new Action(Time.ResetStaticDefaultValue));
	}

	// Token: 0x04000178 RID: 376
	private const float MsToSecond = 0.001f;

	// Token: 0x04000179 RID: 377
	private int FrameInternal;

	// Token: 0x0400017A RID: 378
	private double FrameNowInternal;

	// Token: 0x0400017B RID: 379
	private double FramePlayerTimeInternal;

	// Token: 0x0400017C RID: 380
	private double FrameWorldTimeInternal;

	// Token: 0x0400017D RID: 381
	private double FramePlayerWorldTimeInternal;

	// Token: 0x0400017E RID: 382
	private double FrameFlowTimeInternal;

	// Token: 0x0400017F RID: 383
	private float DeltaTimeMsInternal;

	// Token: 0x04000180 RID: 384
	private double SystemNowInternal;

	// Token: 0x04000181 RID: 385
	private double SystemStart;

	// Token: 0x04000182 RID: 386
	private double ServerTimeStampOffsetInternal;

	// Token: 0x04000183 RID: 387
	private double ServerFlowTimeStampOffsetInternal;

	// Token: 0x04000184 RID: 388
	private double ServerStopTimeStampOffsetInner;

	// Token: 0x04000185 RID: 389
	private double ServerTimeOffsetInternal;

	// Token: 0x04000186 RID: 390
	private double ServerCombatTimeOffsetInternal;

	// Token: 0x04000187 RID: 391
	private float WorldTimeDilationInternal = 1f;

	// Token: 0x04000188 RID: 392
	private float FlowTimeDilationInternal = 1f;

	// Token: 0x04000189 RID: 393
	private float InverseSelfCenteredTimeDilationInternal = 1f;

	// Token: 0x0400018A RID: 394
	public float OriginTimeDilation = 1f;

	// Token: 0x0400018B RID: 395
	public int LastPauseTimeFrame;

	// Token: 0x0400018C RID: 396
	public int LastResumeTimeFrame;

	// Token: 0x0400018D RID: 397
	public double LastServerTime;

	// Token: 0x0400018E RID: 398
	private int AfterTickFrameInternal;

	// Token: 0x0400018F RID: 399
	[Nullable(2)]
	private static Time _instance;
}
