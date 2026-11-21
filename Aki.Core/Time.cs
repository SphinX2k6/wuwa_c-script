using System;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

// Token: 0x02000040 RID: 64
[NullableContext(1)]
[Nullable(0)]
public class Time : Singleton
{
	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000193 RID: 403 RVA: 0x00009FCF File Offset: 0x000081CF
	public double ServerTimeStamp
	{
		get
		{
			return KuroTime.GetMilliseconds64() + this.ServerTimeStampOffsetInternal;
		}
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00009FE0 File Offset: 0x000081E0
	public void SetServerTimeStamp(double serverTimeStampMs)
	{
		double num = serverTimeStampMs + (double)(NetInfo.Instance.RttMs / 2f) - KuroTime.GetMilliseconds64();
		this.ServerTimeStampOffsetInternal = num;
		if (this.LastServerTime == 0.0)
		{
			this.LastServerTime = num;
		}
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0000A026 File Offset: 0x00008226
	public void SetServerFlowTimeStamp(double flowTimeStampMs)
	{
		this.ServerFlowTimeStampOffsetInternal = flowTimeStampMs + (double)(NetInfo.Instance.RttMs / 2f) - this.FlowTime;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0000A048 File Offset: 0x00008248
	public void SyncTime(double serverTimeStampMs, double flowTimeStampMs, double serverCombatTimeOffsetMs, double serverStopTimeOffsetMs)
	{
		this.SetServerTimeStamp(serverTimeStampMs);
		this.SetServerTimeOffset(serverTimeStampMs - this.Now);
		this.SetServerStopTimeOffset(serverStopTimeOffsetMs);
		this.SetServerFlowTimeStamp(flowTimeStampMs);
		this.ServerCombatTimeOffsetInternal = serverCombatTimeOffsetMs;
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A075 File Offset: 0x00008275
	public float TimeDilation
	{
		get
		{
			return this.WorldTimeDilationInternal;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000198 RID: 408 RVA: 0x0000A07D File Offset: 0x0000827D
	public float FlowTimeDilation
	{
		get
		{
			return this.FlowTimeDilationInternal;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A085 File Offset: 0x00008285
	public double ServerStopTimeStamp
	{
		get
		{
			return this.ServerStopTimeStampOffsetInner + this.WorldTime + (double)(NetInfo.Instance.RttMs / 2f);
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600019A RID: 410 RVA: 0x0000A0A6 File Offset: 0x000082A6
	public float InverseSelfCenteredTimeDilation
	{
		get
		{
			return this.InverseSelfCenteredTimeDilationInternal;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A0AE File Offset: 0x000082AE
	public double ServerFlowTimeStamp
	{
		get
		{
			return this.ServerFlowTimeStampOffsetInternal + this.FlowTime + (double)(NetInfo.Instance.RttMs / 2f);
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600019C RID: 412 RVA: 0x0000A0CF File Offset: 0x000082CF
	public double ServerCombatStopTime
	{
		get
		{
			return Math.Floor(this.ServerCombatTimeOffsetInternal + this.FlowTime + (double)(NetInfo.Instance.RttMs / 2f));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600019D RID: 413 RVA: 0x0000A0F5 File Offset: 0x000082F5
	public double CombatServerTime
	{
		get
		{
			return (double)((long)Math.Floor(this.ServerTimeOffsetInternal + this.Now + (double)(NetInfo.Instance.RttMs / 2f)));
		}
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0000A11D File Offset: 0x0000831D
	public void SetServerTimeOffset(double serverTimeOffsetMs)
	{
		this.ServerTimeOffsetInternal = serverTimeOffsetMs;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000A126 File Offset: 0x00008326
	public void SetServerStopTimeOffset(double serverStopTimeOffsetMs)
	{
		this.ServerStopTimeStampOffsetInner = serverStopTimeOffsetMs;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0000A12F File Offset: 0x0000832F
	public void SetTimeDilation(float timeDilation)
	{
		this.WorldTimeDilationInternal = timeDilation;
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000A138 File Offset: 0x00008338
	public void SetFlowTimeDilation(float timeDilation)
	{
		this.FlowTimeDilationInternal = timeDilation;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0000A141 File Offset: 0x00008341
	public void SetInverseSelfCenteredTimeDilation(float timeDilation)
	{
		this.InverseSelfCenteredTimeDilationInternal = timeDilation;
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000A14A File Offset: 0x0000834A
	public float DeltaTime
	{
		get
		{
			return this.DeltaTimeMsInternal;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000A152 File Offset: 0x00008352
	public float DeltaTimeSeconds
	{
		get
		{
			return this.DeltaTimeMsInternal * 0.001f;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000A160 File Offset: 0x00008360
	public int Frame
	{
		get
		{
			return this.FrameInternal;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000A168 File Offset: 0x00008368
	public double Now
	{
		get
		{
			return this.FrameNowInternal;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000A170 File Offset: 0x00008370
	public double NowSeconds
	{
		get
		{
			return this.FrameNowInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000A182 File Offset: 0x00008382
	public double PlayerTime
	{
		get
		{
			return this.FramePlayerTimeInternal;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000A18A File Offset: 0x0000838A
	public double PlayerTimeSeconds
	{
		get
		{
			return this.FramePlayerTimeInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060001AA RID: 426 RVA: 0x0000A19C File Offset: 0x0000839C
	public double WorldTime
	{
		get
		{
			return this.FrameWorldTimeInternal;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060001AB RID: 427 RVA: 0x0000A1A4 File Offset: 0x000083A4
	public double WorldTimeSeconds
	{
		get
		{
			return this.FrameWorldTimeInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060001AC RID: 428 RVA: 0x0000A1B6 File Offset: 0x000083B6
	public double PlayerWorldTime
	{
		get
		{
			return this.FramePlayerWorldTimeInternal;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A1BE File Offset: 0x000083BE
	public double PlayerWorldTimeSeconds
	{
		get
		{
			return this.FramePlayerWorldTimeInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001AE RID: 430 RVA: 0x0000A1D0 File Offset: 0x000083D0
	public double FlowTime
	{
		get
		{
			return this.FrameFlowTimeInternal;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060001AF RID: 431 RVA: 0x0000A1D8 File Offset: 0x000083D8
	public double SystemNow
	{
		get
		{
			return this.SystemNowInternal;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000A1E0 File Offset: 0x000083E0
	public double SystemNowSeconds
	{
		get
		{
			return this.SystemNowInternal * 0.0010000000474974513;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000A1F2 File Offset: 0x000083F2
	public bool IsAfterPrePhysicTick
	{
		get
		{
			return this.AfterTickFrameInternal == this.Frame;
		}
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0000A202 File Offset: 0x00008402
	public void AfterTickPriority1(float delta)
	{
		this.AfterTickFrameInternal = this.FrameInternal;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0000A210 File Offset: 0x00008410
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

	// Token: 0x060001B4 RID: 436 RVA: 0x0000A2A0 File Offset: 0x000084A0
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

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000A358 File Offset: 0x00008558
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

	// Token: 0x060001B6 RID: 438 RVA: 0x0000A37B File Offset: 0x0000857B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0000A37D File Offset: 0x0000857D
	public static void ResetStaticDefaultValue()
	{
		Time instance = Time._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Time._instance = null;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0000A396 File Offset: 0x00008596
	static Time()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Time.CreateStaticDefaultValue), new Action(Time.ResetStaticDefaultValue));
	}

	// Token: 0x0400017A RID: 378
	private const float MsToSecond = 0.001f;

	// Token: 0x0400017B RID: 379
	private int FrameInternal;

	// Token: 0x0400017C RID: 380
	private double FrameNowInternal;

	// Token: 0x0400017D RID: 381
	private double FramePlayerTimeInternal;

	// Token: 0x0400017E RID: 382
	private double FrameWorldTimeInternal;

	// Token: 0x0400017F RID: 383
	private double FramePlayerWorldTimeInternal;

	// Token: 0x04000180 RID: 384
	private double FrameFlowTimeInternal;

	// Token: 0x04000181 RID: 385
	private float DeltaTimeMsInternal;

	// Token: 0x04000182 RID: 386
	private double SystemNowInternal;

	// Token: 0x04000183 RID: 387
	private double SystemStart;

	// Token: 0x04000184 RID: 388
	private double ServerTimeStampOffsetInternal;

	// Token: 0x04000185 RID: 389
	private double ServerFlowTimeStampOffsetInternal;

	// Token: 0x04000186 RID: 390
	private double ServerStopTimeStampOffsetInner;

	// Token: 0x04000187 RID: 391
	private double ServerTimeOffsetInternal;

	// Token: 0x04000188 RID: 392
	private double ServerCombatTimeOffsetInternal;

	// Token: 0x04000189 RID: 393
	private float WorldTimeDilationInternal = 1f;

	// Token: 0x0400018A RID: 394
	private float FlowTimeDilationInternal = 1f;

	// Token: 0x0400018B RID: 395
	private float InverseSelfCenteredTimeDilationInternal = 1f;

	// Token: 0x0400018C RID: 396
	public float OriginTimeDilation = 1f;

	// Token: 0x0400018D RID: 397
	public int LastPauseTimeFrame;

	// Token: 0x0400018E RID: 398
	public int LastResumeTimeFrame;

	// Token: 0x0400018F RID: 399
	public double LastServerTime;

	// Token: 0x04000190 RID: 400
	private int AfterTickFrameInternal;

	// Token: 0x04000191 RID: 401
	[Nullable(2)]
	private static Time _instance;
}
