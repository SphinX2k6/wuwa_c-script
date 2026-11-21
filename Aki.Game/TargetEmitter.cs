using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020023A8 RID: 9128
[NullableContext(1)]
[Nullable(0)]
public class TargetEmitter
{
	// Token: 0x06016D73 RID: 93555 RVA: 0x006A842B File Offset: 0x006A662B
	public TargetEmitter(string name)
	{
		this.Name = name;
	}

	// Token: 0x06016D74 RID: 93556 RVA: 0x006A8450 File Offset: 0x006A6650
	private void MarkEnum(long key)
	{
		if (!this.EnumMapping.ContainsKey(key))
		{
			Dictionary<long, string> enumMapping = this.EnumMapping;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(this.Name);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<long>(key);
			enumMapping[key] = defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	// Token: 0x06016D75 RID: 93557 RVA: 0x006A84A8 File Offset: 0x006A66A8
	public void Add(object target, long key, Delegate callback)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (!this.Emitters.TryGetValue(target, out numberEvent))
		{
			numberEvent = new NumberEvent();
			this.Emitters.Set(target, numberEvent);
		}
		numberEvent.Add(key, callback);
	}

	// Token: 0x06016D76 RID: 93558 RVA: 0x006A84E8 File Offset: 0x006A66E8
	public void Emit(object target, long key)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			if (numberEvent.IsEmitting(key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "技能事件重复发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this.EnumMapping[key]);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			numberEvent.Emit(key);
		}
	}

	// Token: 0x06016D77 RID: 93559 RVA: 0x006A8550 File Offset: 0x006A6750
	public void Emit<[Nullable(2)] T1>(object target, long key, T1 p1)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			if (numberEvent.IsEmitting(key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "技能事件重复发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this.EnumMapping[key]);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			numberEvent.Emit<T1>(key, p1);
		}
	}

	// Token: 0x06016D78 RID: 93560 RVA: 0x006A85BC File Offset: 0x006A67BC
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2>(object target, long key, T1 p1, T2 p2)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			if (numberEvent.IsEmitting(key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "技能事件重复发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this.EnumMapping[key]);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			numberEvent.Emit<T1, T2>(key, p1, p2);
		}
	}

	// Token: 0x06016D79 RID: 93561 RVA: 0x006A8628 File Offset: 0x006A6828
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object target, long key, T1 p1, T2 p2, T3 p3)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			if (numberEvent.IsEmitting(key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "技能事件重复发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this.EnumMapping[key]);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			numberEvent.Emit<T1, T2, T3>(key, p1, p2, p3);
		}
	}

	// Token: 0x06016D7A RID: 93562 RVA: 0x006A8698 File Offset: 0x006A6898
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(object target, long key, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			if (numberEvent.IsEmitting(key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "技能事件重复发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this.EnumMapping[key]);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			numberEvent.Emit<T1, T2, T3, T4>(key, p1, p2, p3, p4);
		}
	}

	// Token: 0x06016D7B RID: 93563 RVA: 0x006A8708 File Offset: 0x006A6908
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(object target, long key, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			if (numberEvent.IsEmitting(key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "技能事件重复发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this.EnumMapping[key]);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			numberEvent.Emit<T1, T2, T3, T4, T5>(key, p1, p2, p3, p4, p5);
		}
	}

	// Token: 0x06016D7C RID: 93564 RVA: 0x006A877C File Offset: 0x006A697C
	public void Remove(object target, long key, Delegate callback)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			numberEvent.Remove(key, callback);
		}
	}

	// Token: 0x0400BFAD RID: 49069
	protected readonly WeakMap<object, NumberEvent> Emitters = new WeakMap<object, NumberEvent>();

	// Token: 0x0400BFAE RID: 49070
	private readonly Dictionary<long, string> EnumMapping = new Dictionary<long, string>();

	// Token: 0x0400BFAF RID: 49071
	private readonly string Name;
}
