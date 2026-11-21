using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D6 RID: 214
[NullableContext(2)]
[Nullable(0)]
public class Timer
{
	// Token: 0x060006DE RID: 1758 RVA: 0x00023638 File Offset: 0x00021838
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

	// Token: 0x060006DF RID: 1759 RVA: 0x000236A4 File Offset: 0x000218A4
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

	// Token: 0x060006E0 RID: 1760 RVA: 0x000237CC File Offset: 0x000219CC
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

	// Token: 0x060006E1 RID: 1761 RVA: 0x00023840 File Offset: 0x00021A40
	public void Clear()
	{
		this.Action = null;
		this.Handle = null;
		this.Stat = null;
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00023857 File Offset: 0x00021A57
	[NullableContext(1)]
	public static int Compare(Timer a, Timer b)
	{
		return a.Next.CompareTo(b.Next);
	}

	// Token: 0x0400055F RID: 1375
	public double Now;

	// Token: 0x04000560 RID: 1376
	public double Next;

	// Token: 0x04000561 RID: 1377
	private int Count;

	// Token: 0x04000562 RID: 1378
	public EState State;

	// Token: 0x04000563 RID: 1379
	public readonly int Id;

	// Token: 0x04000564 RID: 1380
	private TTimerAction Action;

	// Token: 0x04000565 RID: 1381
	public double Interval;

	// Token: 0x04000566 RID: 1382
	private readonly int Loop;

	// Token: 0x04000567 RID: 1383
	public float Dilation;

	// Token: 0x04000568 RID: 1384
	public TimerHandle Handle;

	// Token: 0x04000569 RID: 1385
	private Stat Stat;

	// Token: 0x0400056A RID: 1386
	public readonly string Reason;
}
