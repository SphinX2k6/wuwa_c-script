using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002E4C RID: 11852
[NullableContext(1)]
[Nullable(0)]
public class TargetEmitter
{
	// Token: 0x06019495 RID: 103573 RVA: 0x0068209F File Offset: 0x0068029F
	public TargetEmitter(string name)
	{
		this.Name = name;
	}

	// Token: 0x06019496 RID: 103574 RVA: 0x006820C4 File Offset: 0x006802C4
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

	// Token: 0x06019497 RID: 103575 RVA: 0x0068211C File Offset: 0x0068031C
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

	// Token: 0x06019498 RID: 103576 RVA: 0x0068215C File Offset: 0x0068035C
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

	// Token: 0x06019499 RID: 103577 RVA: 0x006821C4 File Offset: 0x006803C4
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

	// Token: 0x0601949A RID: 103578 RVA: 0x00682230 File Offset: 0x00680430
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

	// Token: 0x0601949B RID: 103579 RVA: 0x0068229C File Offset: 0x0068049C
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

	// Token: 0x0601949C RID: 103580 RVA: 0x0068230C File Offset: 0x0068050C
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

	// Token: 0x0601949D RID: 103581 RVA: 0x0068237C File Offset: 0x0068057C
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

	// Token: 0x0601949E RID: 103582 RVA: 0x006823F0 File Offset: 0x006805F0
	public void Remove(object target, long key, Delegate callback)
	{
		this.MarkEnum(key);
		NumberEvent numberEvent;
		if (this.Emitters.TryGetValue(target, out numberEvent))
		{
			numberEvent.Remove(key, callback);
		}
	}

	// Token: 0x0400BC19 RID: 48153
	protected readonly WeakMap<object, NumberEvent> Emitters = new WeakMap<object, NumberEvent>();

	// Token: 0x0400BC1A RID: 48154
	private readonly Dictionary<long, string> EnumMapping = new Dictionary<long, string>();

	// Token: 0x0400BC1B RID: 48155
	private readonly string Name;
}
