using System;
using System.Runtime.CompilerServices;

// Token: 0x02002BB4 RID: 11188
[NullableContext(1)]
[Nullable(0)]
public class TodTimeAdjustingAnimation
{
	// Token: 0x0601731D RID: 95005 RVA: 0x005E12FC File Offset: 0x005DF4FC
	public TodTimeAdjustingAnimation(double maxV, double a, Action<double> onPlaying, Action onFinished)
	{
		this.MaxV = maxV;
		this.A = a;
		this.OnPlaying = onPlaying;
		this.OnFinished = onFinished;
	}

	// Token: 0x17001F56 RID: 8022
	// (get) Token: 0x0601731E RID: 95006 RVA: 0x005E134A File Offset: 0x005DF54A
	public bool IsPlaying
	{
		get
		{
			return this.StartSecond >= 0.0;
		}
	}

	// Token: 0x17001F57 RID: 8023
	// (get) Token: 0x0601731F RID: 95007 RVA: 0x005E1360 File Offset: 0x005DF560
	public bool IsFinished
	{
		get
		{
			return this.IsPlaying && this.StartSecond >= this.ToSecond;
		}
	}

	// Token: 0x06017320 RID: 95008 RVA: 0x005E137D File Offset: 0x005DF57D
	private void Finish()
	{
		this.Stop();
		this.OnFinished();
	}

	// Token: 0x06017321 RID: 95009 RVA: 0x005E1390 File Offset: 0x005DF590
	public void Play(double fromSecond, double toSecond)
	{
		this.Stop();
		this.StartSecond = fromSecond;
		this.ToSecond = toSecond;
		double num = this.MaxV / this.A;
		this.DeAccelerateDistance = Math.Abs(this.GetTimeDistance() - 0.5 * this.A * num * num);
	}

	// Token: 0x06017322 RID: 95010 RVA: 0x005E13E5 File Offset: 0x005DF5E5
	private double GetTimeDistance()
	{
		return this.ToSecond - this.StartSecond;
	}

	// Token: 0x06017323 RID: 95011 RVA: 0x005E13F4 File Offset: 0x005DF5F4
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

	// Token: 0x06017324 RID: 95012 RVA: 0x005E151C File Offset: 0x005DF71C
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

	// Token: 0x06017325 RID: 95013 RVA: 0x005E15A4 File Offset: 0x005DF7A4
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

	// Token: 0x0400AD9D RID: 44445
	private readonly double MaxV;

	// Token: 0x0400AD9E RID: 44446
	private readonly double A;

	// Token: 0x0400AD9F RID: 44447
	private readonly Action<double> OnPlaying;

	// Token: 0x0400ADA0 RID: 44448
	private readonly Action OnFinished;

	// Token: 0x0400ADA1 RID: 44449
	private double CurrentSpeed;

	// Token: 0x0400ADA2 RID: 44450
	private double CurrentRunTime;

	// Token: 0x0400ADA3 RID: 44451
	private double CurrentAddDistance;

	// Token: 0x0400ADA4 RID: 44452
	private double StartSecond = -1.0;

	// Token: 0x0400ADA5 RID: 44453
	private double ToSecond = -1.0;

	// Token: 0x0400ADA6 RID: 44454
	private double DeAccelerateDistance;

	// Token: 0x0400ADA7 RID: 44455
	private double DeAccelerateTime;

	// Token: 0x0400ADA8 RID: 44456
	private double CurrentMoveSpeedMax;
}
