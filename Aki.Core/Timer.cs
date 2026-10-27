using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D4 RID: 212
[NullableContext(2)]
[Nullable(0)]
public class Timer
{
	// Token: 0x0600069D RID: 1693 RVA: 0x00023068 File Offset: 0x00021268
	public Timer(int id, TTimerAction action, double interval, int loop, float dilation, TimerHandle handle, Stat stat, string reason)
	{
		this.Id = id;
		this.Action = action;
		this.Interval = interval;
		this.Loop = loop;
		this.Dilation = dilation;
		this.Handle = handle;
		this.Stat = stat;
		this.Reason = reason;
		this.Next = this.Now + this.Interval / (double)this.Dilation;
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x000230D4 File Offset: 0x000212D4
	public unsafe bool Do()
	{
		double next = this.Next;
		float delta = (float)(next - this.Now);
		Stat stat = this.Stat;
		this.Now = next;
		this.Next = next + this.Interval / (double)this.Dilation;
		this.Count++;
		try
		{
			this.Handle = null;
			this.Action(delta);
		}
		catch (Exception ex) when (1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "定时器执行异常";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", this.Reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return this.Loop == 0 || this.Count < this.Loop;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x000231FC File Offset: 0x000213FC
	[NullableContext(1)]
	public Timer Copy()
	{
		this.Handle = null;
		return new Timer(this.Id, this.Action, this.Interval, this.Loop, this.Dilation, null, this.Stat, this.Reason)
		{
			Now = this.Now,
			Next = this.Next,
			Count = this.Count,
			State = this.State
		};
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00023270 File Offset: 0x00021470
	public void Clear()
	{
		this.Action = null;
		this.Handle = null;
		this.Stat = null;
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00023287 File Offset: 0x00021487
	[NullableContext(1)]
	public static int Compare(Timer a, Timer b)
	{
		return a.Next.CompareTo(b.Next);
	}

	// Token: 0x04000550 RID: 1360
	public double Now;

	// Token: 0x04000551 RID: 1361
	public double Next;

	// Token: 0x04000552 RID: 1362
	private int Count;

	// Token: 0x04000553 RID: 1363
	public EState State;

	// Token: 0x04000554 RID: 1364
	public readonly int Id;

	// Token: 0x04000555 RID: 1365
	private TTimerAction Action;

	// Token: 0x04000556 RID: 1366
	public double Interval;

	// Token: 0x04000557 RID: 1367
	private readonly int Loop;

	// Token: 0x04000558 RID: 1368
	public float Dilation;

	// Token: 0x04000559 RID: 1369
	public TimerHandle Handle;

	// Token: 0x0400055A RID: 1370
	private Stat Stat;

	// Token: 0x0400055B RID: 1371
	public readonly string Reason;
}
