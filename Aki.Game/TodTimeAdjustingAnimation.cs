using System;
using System.Runtime.CompilerServices;

// Token: 0x02002130 RID: 8496
[NullableContext(1)]
[Nullable(0)]
public class TodTimeAdjustingAnimation
{
	// Token: 0x06014D4E RID: 85326 RVA: 0x0060DED0 File Offset: 0x0060C0D0
	public TodTimeAdjustingAnimation(double maxV, double a, Action<double> onPlaying, Action onFinished)
	{
		this.MaxV = maxV;
		this.A = a;
		this.OnPlaying = onPlaying;
		this.OnFinished = onFinished;
	}

	// Token: 0x17001FAE RID: 8110
	// (get) Token: 0x06014D4F RID: 85327 RVA: 0x0060DF1E File Offset: 0x0060C11E
	public bool IsPlaying
	{
		get
		{
			return this.StartSecond >= 0.0;
		}
	}

	// Token: 0x17001FAF RID: 8111
	// (get) Token: 0x06014D50 RID: 85328 RVA: 0x0060DF34 File Offset: 0x0060C134
	public bool IsFinished
	{
		get
		{
			return this.IsPlaying && this.StartSecond >= this.ToSecond;
		}
	}

	// Token: 0x06014D51 RID: 85329 RVA: 0x0060DF51 File Offset: 0x0060C151
	private void Finish()
	{
		this.Stop();
		this.OnFinished();
	}

	// Token: 0x06014D52 RID: 85330 RVA: 0x0060DF64 File Offset: 0x0060C164
	public void Play(double fromSecond, double toSecond)
	{
		this.Stop();
		this.StartSecond = fromSecond;
		this.ToSecond = toSecond;
		double num = this.MaxV / this.A;
		this.DeAccelerateDistance = Math.Abs(this.GetTimeDistance() - 0.5 * this.A * num * num);
	}

	// Token: 0x06014D53 RID: 85331 RVA: 0x0060DFB9 File Offset: 0x0060C1B9
	private double GetTimeDistance()
	{
		return this.ToSecond - this.StartSecond;
	}

	// Token: 0x06014D54 RID: 85332 RVA: 0x0060DFC8 File Offset: 0x0060C1C8
	public void Tick(double deltaMillionSecond)
	{
		if (!this.IsPlaying)
		{
			return;
		}
		if (this.IsFinished)
		{
			this.Finish();
			return;
		}
		double num = deltaMillionSecond / 1000.0;
		this.CurrentRunTime += num;
		if (this.CurrentAddDistance >= this.DeAccelerateDistance)
		{
			this.DeAccelerateTime += num;
			this.CurrentSpeed = this.CurrentMoveSpeedMax - this.DeAccelerateTime * this.A;
			if (this.CurrentSpeed <= 10000.0)
			{
				this.CurrentSpeed = 10000.0;
			}
		}
		else
		{
			this.CurrentSpeed = this.CurrentRunTime * this.A;
			if (this.CurrentSpeed >= this.MaxV)
			{
				this.CurrentSpeed = this.MaxV;
				this.CurrentMoveSpeedMax = this.MaxV;
			}
			this.CurrentMoveSpeedMax = this.CurrentSpeed;
		}
		double num2 = num * this.CurrentSpeed;
		this.CurrentAddDistance += num2;
		this.StartSecond += num2;
		if (this.IsFinished)
		{
			this.StartSecond = this.ToSecond;
		}
		this.OnPlaying(this.StartSecond);
	}

	// Token: 0x06014D55 RID: 85333 RVA: 0x0060E0F0 File Offset: 0x0060C2F0
	public void Stop()
	{
		this.CurrentSpeed = 0.0;
		this.CurrentRunTime = 0.0;
		this.StartSecond = -1.0;
		this.ToSecond = -1.0;
		this.DeAccelerateTime = 0.0;
		this.CurrentAddDistance = 0.0;
		this.DeAccelerateDistance = 0.0;
		this.CurrentMoveSpeedMax = 0.0;
	}

	// Token: 0x06014D56 RID: 85334 RVA: 0x0060E178 File Offset: 0x0060C378
	public unsafe void DebugPrint()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TimeOfDay;
		ELogAuthor author = ELogAuthor.TL;
		string message = "TodTimeAdjustingAnimation";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.MaxV", this.MaxV);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.A", this.A);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("this.StartSecond", this.StartSecond);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("this.ToSecond", this.ToSecond);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x0400B1A4 RID: 45476
	private readonly double MaxV;

	// Token: 0x0400B1A5 RID: 45477
	private readonly double A;

	// Token: 0x0400B1A6 RID: 45478
	private readonly Action<double> OnPlaying;

	// Token: 0x0400B1A7 RID: 45479
	private readonly Action OnFinished;

	// Token: 0x0400B1A8 RID: 45480
	private double CurrentSpeed;

	// Token: 0x0400B1A9 RID: 45481
	private double CurrentRunTime;

	// Token: 0x0400B1AA RID: 45482
	private double CurrentAddDistance;

	// Token: 0x0400B1AB RID: 45483
	private double StartSecond = -1.0;

	// Token: 0x0400B1AC RID: 45484
	private double ToSecond = -1.0;

	// Token: 0x0400B1AD RID: 45485
	private double DeAccelerateDistance;

	// Token: 0x0400B1AE RID: 45486
	private double DeAccelerateTime;

	// Token: 0x0400B1AF RID: 45487
	private double CurrentMoveSpeedMax;
}
