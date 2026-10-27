using System;
using System.Runtime.CompilerServices;

// Token: 0x02000095 RID: 149
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5> : IEventArgs
{
	// Token: 0x06000474 RID: 1140 RVA: 0x00019F73 File Offset: 0x00018173
	public EventArgs(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
		this.<p5>P = p5;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00019F9C File Offset: 0x0001819C
	public bool Invoke(Enum name, Delegate handle)
	{
		Action<T1, T2, T3, T4, T5> action = handle as Action<T1, T2, T3, T4, T5>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P, this.<p5>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4, T5>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P,
				this.<p5>P
			});
		}
		return true;
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x0001A04C File Offset: 0x0001824C
	public bool Invoke(long name, Delegate handle)
	{
		Action<T1, T2, T3, T4, T5> action = handle as Action<T1, T2, T3, T4, T5>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P, this.<p5>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4, T5>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P,
				this.<p5>P
			});
		}
		return true;
	}

	// Token: 0x040003F9 RID: 1017
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x040003FA RID: 1018
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x040003FB RID: 1019
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x040003FC RID: 1020
	[CompilerGenerated]
	private readonly T4 <p4>P;

	// Token: 0x040003FD RID: 1021
	[CompilerGenerated]
	private readonly T5 <p5>P;
}
