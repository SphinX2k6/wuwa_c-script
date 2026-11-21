using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020000D7 RID: 215
[NullableContext(1)]
[Nullable(0)]
public class TimerSystemInstance
{
	// Token: 0x060006E3 RID: 1763 RVA: 0x0002386C File Offset: 0x00021A6C
	public unsafe void Tick(double delta)
	{
		double num = this.Now + delta;
		this.Now = num;
		PriorityQueue<Timer> queue = this.Queue;
		while (!queue.Empty)
		{
			Timer top = queue.Top;
			if (top == null || top.Next > num)
			{
				IL_104:
				while (!this.PendingRemoveQueue.IsEmpty)
				{
					ValueTuple<TimerHandle, string> valueTuple;
					if (this.PendingRemoveQueue.TryDequeue(out valueTuple))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Timer;
						ELogAuthor author = ELogAuthor.LFJW;
						string message = "移除TimerHandle已经被GC的定时器";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
						string item = "timer";
						TimerHandle item2 = valueTuple.Item1;
						ptr = new ValueTuple<string, object>(item, (item2 != null) ? new int?(item2.Id) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", valueTuple.Item2);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						this.Remove(valueTuple.Item1);
					}
				}
				return;
			}
			queue.Pop();
			if (top.State == EState.Normal)
			{
				if (top.Do())
				{
					queue.Push(top);
				}
				else
				{
					this.DoRemove(top);
				}
			}
		}
		goto IL_104;
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x0002398D File Offset: 0x00021B8D
	[NullableContext(2)]
	public bool Has(TimerHandle handle)
	{
		return handle != null && this.Timers.ContainsKey(handle.Id);
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x000239A5 File Offset: 0x00021BA5
	[NullableContext(2)]
	public TimerHandle Loop([Nullable(1)] TTimerAction action, float interval, int loop, float dilation = 1f, Stat stat = null, string reason = null, bool needCheckMaxInterval = true)
	{
		if (!TimerSystemInstance.CheckInterval((double)interval, reason, needCheckMaxInterval) || !TimerSystemInstance.CheckLoop(loop) || !TimerSystemInstance.CheckDilation(dilation))
		{
			return null;
		}
		return this.DoAdd(action, (double)interval, loop, dilation, stat, reason);
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x000239D7 File Offset: 0x00021BD7
	[NullableContext(2)]
	public TimerHandle Forever([Nullable(1)] TTimerAction action, float interval, float dilation = 1f, Stat stat = null, string reason = null, bool needCheckMaxInterval = true)
	{
		if (!TimerSystemInstance.CheckInterval((double)interval, reason, needCheckMaxInterval) || !TimerSystemInstance.CheckDilation(dilation))
		{
			return null;
		}
		return this.DoAdd(action, (double)interval, 0, dilation, stat, reason);
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x000239FF File Offset: 0x00021BFF
	[NullableContext(2)]
	public TimerHandle Delay([Nullable(1)] TTimerAction action, float interval, Stat stat = null, string reason = null, bool needCheckMaxInterval = true, float dilation = 1f)
	{
		if (!TimerSystemInstance.CheckInterval((double)interval, reason, needCheckMaxInterval) || !TimerSystemInstance.CheckDilation(dilation))
		{
			return null;
		}
		return this.DoAdd(action, (double)interval, 1, dilation, stat, reason);
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00023A28 File Offset: 0x00021C28
	[NullableContext(2)]
	public TimerHandle EmitOnTime([Nullable(1)] TTimerAction action, double emitTimeStamp, Stat stat = null, string reason = null, bool needCheckMaxInterval = true, float dilation = 1f)
	{
		double interval = emitTimeStamp - this.Now;
		if (!TimerSystemInstance.CheckInterval(interval, reason, needCheckMaxInterval) || !TimerSystemInstance.CheckDilation(dilation))
		{
			return null;
		}
		return this.DoAdd(action, interval, 1, dilation, stat, reason);
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00023A63 File Offset: 0x00021C63
	[NullableContext(2)]
	public TimerHandle Next([Nullable(1)] TTimerAction action, Stat stat = null, string reason = null)
	{
		return this.DoAdd(action, 1.0, 1, 1f, stat, reason);
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00023A7D File Offset: 0x00021C7D
	public void PendingRemove_FinalizerThread(TimerHandle handle, [Nullable(2)] string reason)
	{
		this.PendingRemoveQueue.Enqueue(new ValueTuple<TimerHandle, string>(handle, reason));
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00023A94 File Offset: 0x00021C94
	[NullableContext(2)]
	public bool Remove(TimerHandle handle)
	{
		if (handle != null)
		{
			Timer timer = this.Get(handle);
			return timer != null && this.DoRemove(timer);
		}
		return true;
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00023ABC File Offset: 0x00021CBC
	public bool IsPause(TimerHandle handle)
	{
		Timer timer = this.Get(handle);
		return timer != null && timer.State == EState.Pause;
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00023AE0 File Offset: 0x00021CE0
	public unsafe bool Pause(TimerHandle handle, [Nullable(2)] string reason = null)
	{
		Timer timer = this.Get(handle);
		if (timer == null)
		{
			return false;
		}
		if (timer.State != EState.Normal)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器已废弃或暂停";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", timer.State);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		Timer timer2 = timer.Copy();
		timer.State = EState.Trash;
		timer2.Next = (double)((float)(timer2.Next - this.Now));
		timer2.State = EState.Pause;
		this.Registry.Unregister(timer);
		this.Timers[handle.Id] = timer2;
		this.Registry.Register(timer2, handle, reason, this.DisposeHandle_FinalizerThread);
		return true;
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00023BCC File Offset: 0x00021DCC
	public unsafe bool Resume(TimerHandle handle)
	{
		Timer timer = this.Get(handle);
		if (timer == null)
		{
			return false;
		}
		if (timer.State != EState.Pause)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器已废弃或非暂停";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", timer.State);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		timer.Next = (double)((float)(timer.Next + this.Now));
		timer.State = EState.Normal;
		this.Queue.Push(timer);
		return true;
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00023C80 File Offset: 0x00021E80
	public unsafe bool ChangeInterval(TimerHandle handle, float interval, [Nullable(2)] string reason, bool needCheckMaxInterval = true)
	{
		if (!TimerSystemInstance.CheckInterval((double)interval, reason, needCheckMaxInterval))
		{
			return false;
		}
		Timer timer = this.Get(handle);
		if (timer == null)
		{
			return false;
		}
		if (timer.State == EState.Trash)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器已废弃";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("interval", interval);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (Math.Abs(timer.Interval - (double)interval) < 0.0010000000474974513)
		{
			return true;
		}
		double now = this.Now;
		if (timer.State == EState.Pause)
		{
			double num = timer.Next + (double)interval - timer.Interval;
			timer.Next = ((num < 0.0) ? 0.0 : num);
			timer.Interval = (double)interval;
			return true;
		}
		Timer timer2 = timer.Copy();
		timer.State = EState.Trash;
		double num2 = timer2.Next + (double)interval - timer2.Interval;
		timer2.Next = ((num2 < now) ? now : num2);
		timer2.Interval = (double)interval;
		this.Registry.Unregister(timer);
		this.Timers[handle.Id] = timer2;
		this.Queue.Push(timer2);
		this.Registry.Register(timer2, handle, reason, this.DisposeHandle_FinalizerThread);
		return true;
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00023DF0 File Offset: 0x00021FF0
	public unsafe bool ChangeDilation(TimerHandle handle, float dilation, [Nullable(2)] string reason = null)
	{
		if (!TimerSystemInstance.CheckDilation(dilation))
		{
			return false;
		}
		Timer timer = this.Get(handle);
		if (timer == null)
		{
			return false;
		}
		if (timer.State == EState.Trash)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器已废弃";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dilation", dilation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (Math.Abs(timer.Dilation - dilation) < 0.001f)
		{
			return true;
		}
		double now = this.Now;
		if (timer.State == EState.Pause)
		{
			timer.Next = timer.Next * (double)timer.Dilation / (double)dilation;
			timer.Dilation = dilation;
			return true;
		}
		Timer timer2 = timer.Copy();
		timer.State = EState.Trash;
		timer2.Next = now + (timer2.Next - now) * (double)timer2.Dilation / (double)dilation;
		timer2.Dilation = dilation;
		this.Registry.Unregister(timer);
		this.Timers[handle.Id] = timer2;
		this.Queue.Push(timer2);
		this.Registry.Register(timer2, handle, reason, this.DisposeHandle_FinalizerThread);
		return true;
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00023F38 File Offset: 0x00022138
	public float GetNextRemainTime(TimerHandle handle)
	{
		Timer timer = this.Get(handle);
		if (timer == null)
		{
			return -1f;
		}
		if (timer.State != EState.Normal)
		{
			return -1f;
		}
		return (float)(timer.Next - this.Now);
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00023F74 File Offset: 0x00022174
	[NullableContext(2)]
	public UniTask Wait(float delay, Stat stat = null)
	{
		UniTaskCompletionSource tcs = new UniTaskCompletionSource();
		this.Delay(delegate(float _)
		{
			tcs.TrySetResult();
		}, delay, stat, null, true, 1f);
		return tcs.Task;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00023FBC File Offset: 0x000221BC
	public void Clear()
	{
		foreach (KeyValuePair<int, Timer> keyValuePair in this.Timers)
		{
			Timer value = keyValuePair.Value;
			this.Registry.Unregister(value);
			value.State = EState.Trash;
			value.Clear();
		}
		this.Timers.Clear();
		this.Queue.Clear();
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00024040 File Offset: 0x00022240
	[return: Nullable(2)]
	private Timer Get(TimerHandle handle)
	{
		if (handle == null)
		{
			Log.Instance.Error(ELogModule.Timer, ELogAuthor.LCC, "计时器句柄为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.DoGet(handle.Id);
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x0002407C File Offset: 0x0002227C
	[NullableContext(2)]
	private Timer DoGet(int id)
	{
		if (id <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器句柄非法";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		Timer result;
		if (!this.Timers.TryGetValue(id, out result))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Timer;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "计时器句柄不存在";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return result;
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x000240F8 File Offset: 0x000222F8
	[NullableContext(2)]
	private TimerHandle DoAdd([Nullable(1)] TTimerAction action, double interval, int loop, float dilation, Stat stat, string reason)
	{
		if (action == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "定时器处理方法不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", action);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		Stat stat2 = null;
		if (stat == null && !this.StatWeakMap.TryGetValue(action.Method, out stat2))
		{
			stat2 = Stat.CreateWithStack("TimerAction", 2, 5);
			this.StatWeakMap.Add(action.Method, stat2);
		}
		double now = this.Now;
		TimerHandle timerHandle = new TimerHandle(this);
		Timer timer = new Timer(timerHandle.Id, action, interval, loop, dilation, timerHandle, stat ?? stat2, reason);
		timer.Now = now;
		timer.Next = now + interval / (double)dilation;
		this.Timers[timerHandle.Id] = timer;
		this.Queue.Push(timer);
		this.Registry.Register(timer, timerHandle, reason, this.DisposeHandle_FinalizerThread);
		return timerHandle;
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x000241DC File Offset: 0x000223DC
	private bool DoRemove(Timer timer)
	{
		this.Registry.Unregister(timer);
		timer.State = EState.Trash;
		timer.Clear();
		this.Timers.Remove(timer.Id);
		return true;
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x0002420C File Offset: 0x0002240C
	[NullableContext(2)]
	private unsafe static bool CheckInterval(double interval, string reason = null, bool needCheckMaxInterval = true)
	{
		if (interval < 20.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器间隔必须在合理范围内，请检查定时器间隔参数";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MIN_TIME", 20);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MAX_TIME", 180000);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("interval", interval);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		if (needCheckMaxInterval && interval > 180000.0)
		{
			if (reason != null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Timer;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message2 = "计时器间隔较长，此处显式打印辅助定位问题";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("MIN_TIME", 20);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("MAX_TIME", 180000);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("interval", interval);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("reason", reason);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			}
			else
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Timer;
				ELogAuthor author3 = ELogAuthor.LCC;
				string message3 = "计时器间隔必须在合理范围内，请联系 CC 确认时间是否合理";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("MIN_TIME", 20);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("MAX_TIME", 180000);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("interval", interval);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			}
			return true;
		}
		return true;
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000243DC File Offset: 0x000225DC
	private unsafe static bool CheckLoop(int loop)
	{
		if (loop <= 1 || loop > 10)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器次数必须在合理范围内，请检查定时器循环次数参数";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MAX_LOOP", 10);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("loop", loop);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		return true;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00024454 File Offset: 0x00022654
	private static bool CheckDilation(float dilation)
	{
		if (dilation <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Timer;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "计时器时间缩放不能小于等于 0 ，请检查定时器时间缩放参数";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dilation", dilation);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00024498 File Offset: 0x00022698
	public TimerSystemInstance()
	{
		Comparison<Timer> compare;
		if ((compare = TimerSystemInstance.<>O.<0>__Compare) == null)
		{
			compare = (TimerSystemInstance.<>O.<0>__Compare = new Comparison<Timer>(Timer.Compare));
		}
		this.Queue = new PriorityQueue<Timer>(compare);
		this.Stat = Stat.Create("TimerSystem.Tick", "", "");
		this.StatWeakMap = new Dictionary<MethodInfo, Stat>();
		this.PendingRemoveQueue = new ConcurrentQueue<ValueTuple<TimerHandle, string>>();
		this.Registry = new FinalizationRegistry<Timer, TimerHandle>();
		this.DisposeHandle_FinalizerThread = delegate(TimerHandle param, string newReason)
		{
			if (param != null)
			{
				param.PendingRemove_FinalizerThread(newReason);
			}
		};
		base..ctor();
	}

	// Token: 0x0400056B RID: 1387
	public const int MIN_TIME = 20;

	// Token: 0x0400056C RID: 1388
	public const int MAX_TIME = 180000;

	// Token: 0x0400056D RID: 1389
	public const int MAX_LOOP = 10;

	// Token: 0x0400056E RID: 1390
	public const int FOREVER = 0;

	// Token: 0x0400056F RID: 1391
	public double Now;

	// Token: 0x04000570 RID: 1392
	public Dictionary<int, Timer> Timers = new Dictionary<int, Timer>();

	// Token: 0x04000571 RID: 1393
	public PriorityQueue<Timer> Queue;

	// Token: 0x04000572 RID: 1394
	[Nullable(2)]
	public Stat Stat;

	// Token: 0x04000573 RID: 1395
	public Dictionary<MethodInfo, Stat> StatWeakMap;

	// Token: 0x04000574 RID: 1396
	[TupleElementNames(new string[]
	{
		"handle",
		"reason"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		2
	})]
	private readonly ConcurrentQueue<ValueTuple<TimerHandle, string>> PendingRemoveQueue;

	// Token: 0x04000575 RID: 1397
	private readonly FinalizationRegistry<Timer, TimerHandle> Registry;

	// Token: 0x04000576 RID: 1398
	[Nullable(2)]
	private readonly Action<TimerHandle, string> DisposeHandle_FinalizerThread;

	// Token: 0x020001D4 RID: 468
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040008A1 RID: 2209
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<Timer> <0>__Compare;
	}
}
