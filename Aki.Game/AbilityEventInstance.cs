using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020023A9 RID: 9129
[NullableContext(1)]
[Nullable(0)]
public class AbilityEventInstance
{
	// Token: 0x06016D7D RID: 93565 RVA: 0x006A87AC File Offset: 0x006A69AC
	public void Add(object target, EAbilityEventName eventType, long key, Delegate callback)
	{
		TargetEmitter targetEmitter;
		if (!this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Event");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)eventType);
			targetEmitter = new TargetEmitter(defaultInterpolatedStringHandler.ToStringAndClear());
			this.EmitterHolders[eventType] = targetEmitter;
		}
		targetEmitter.Add(target, key, callback);
	}

	// Token: 0x06016D7E RID: 93566 RVA: 0x006A880C File Offset: 0x006A6A0C
	public void Emit(object target, EAbilityEventName eventType, long key)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit(target, key);
		}
	}

	// Token: 0x06016D7F RID: 93567 RVA: 0x006A8834 File Offset: 0x006A6A34
	public void Emit<[Nullable(2)] T1>(object target, EAbilityEventName eventType, long key, T1 arg1)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1>(target, key, arg1);
		}
	}

	// Token: 0x06016D80 RID: 93568 RVA: 0x006A885C File Offset: 0x006A6A5C
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2>(target, key, arg1, arg2);
		}
	}

	// Token: 0x06016D81 RID: 93569 RVA: 0x006A8888 File Offset: 0x006A6A88
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2, T3 arg3)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2, T3>(target, key, arg1, arg2, arg3);
		}
	}

	// Token: 0x06016D82 RID: 93570 RVA: 0x006A88B4 File Offset: 0x006A6AB4
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2, T3, T4>(target, key, arg1, arg2, arg3, arg4);
		}
	}

	// Token: 0x06016D83 RID: 93571 RVA: 0x006A88E4 File Offset: 0x006A6AE4
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2, T3, T4, T5>(target, key, arg1, arg2, arg3, arg4, arg5);
		}
	}

	// Token: 0x06016D84 RID: 93572 RVA: 0x006A8914 File Offset: 0x006A6B14
	public void Remove(object target, EAbilityEventName eventType, long key, Delegate callback)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Remove(target, key, callback);
		}
	}

	// Token: 0x06016D85 RID: 93573 RVA: 0x006A893B File Offset: 0x006A6B3B
	public bool HasListener(EAbilityEventName eventType)
	{
		return this.EmitterHolders.ContainsKey(eventType);
	}

	// Token: 0x0400BFB0 RID: 49072
	private readonly Dictionary<EAbilityEventName, TargetEmitter> EmitterHolders = new Dictionary<EAbilityEventName, TargetEmitter>();
}
