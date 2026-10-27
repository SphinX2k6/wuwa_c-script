using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002E4D RID: 11853
[NullableContext(1)]
[Nullable(0)]
public class AbilityEventInstance
{
	// Token: 0x0601949F RID: 103583 RVA: 0x00682420 File Offset: 0x00680620
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

	// Token: 0x060194A0 RID: 103584 RVA: 0x00682480 File Offset: 0x00680680
	public void Emit(object target, EAbilityEventName eventType, long key)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit(target, key);
		}
	}

	// Token: 0x060194A1 RID: 103585 RVA: 0x006824A8 File Offset: 0x006806A8
	public void Emit<[Nullable(2)] T1>(object target, EAbilityEventName eventType, long key, T1 arg1)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1>(target, key, arg1);
		}
	}

	// Token: 0x060194A2 RID: 103586 RVA: 0x006824D0 File Offset: 0x006806D0
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2>(target, key, arg1, arg2);
		}
	}

	// Token: 0x060194A3 RID: 103587 RVA: 0x006824FC File Offset: 0x006806FC
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2, T3 arg3)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2, T3>(target, key, arg1, arg2, arg3);
		}
	}

	// Token: 0x060194A4 RID: 103588 RVA: 0x00682528 File Offset: 0x00680728
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2, T3, T4>(target, key, arg1, arg2, arg3, arg4);
		}
	}

	// Token: 0x060194A5 RID: 103589 RVA: 0x00682558 File Offset: 0x00680758
	public void Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(object target, EAbilityEventName eventType, long key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Emit<T1, T2, T3, T4, T5>(target, key, arg1, arg2, arg3, arg4, arg5);
		}
	}

	// Token: 0x060194A6 RID: 103590 RVA: 0x00682588 File Offset: 0x00680788
	public void Remove(object target, EAbilityEventName eventType, long key, Delegate callback)
	{
		TargetEmitter targetEmitter;
		if (this.EmitterHolders.TryGetValue(eventType, out targetEmitter))
		{
			targetEmitter.Remove(target, key, callback);
		}
	}

	// Token: 0x0400BC1C RID: 48156
	private readonly Dictionary<EAbilityEventName, TargetEmitter> EmitterHolders = new Dictionary<EAbilityEventName, TargetEmitter>();
}
