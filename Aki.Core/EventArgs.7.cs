using System;
using System.Runtime.CompilerServices;

// Token: 0x02000096 RID: 150
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6> : IEventArgs
{
	// Token: 0x06000477 RID: 1143 RVA: 0x0001A0FB File Offset: 0x000182FB
	public EventArgs(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
		this.<p5>P = p5;
		this.<p6>P = p6;
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0001A12C File Offset: 0x0001832C
	public bool Invoke(Enum name, Delegate handle)
	{
		Action<T1, T2, T3, T4, T5, T6> action = handle as Action<T1, T2, T3, T4, T5, T6>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P, this.<p5>P, this.<p6>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4, T5, T6>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P,
				this.<p5>P,
				this.<p6>P
			});
		}
		return true;
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0001A1F0 File Offset: 0x000183F0
	public bool Invoke(long name, Delegate handle)
	{
		Action<T1, T2, T3, T4, T5, T6> action = handle as Action<T1, T2, T3, T4, T5, T6>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P, this.<p5>P, this.<p6>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4, T5, T6>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P,
				this.<p5>P,
				this.<p6>P
			});
		}
		return true;
	}

	// Token: 0x040003FE RID: 1022
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x040003FF RID: 1023
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000400 RID: 1024
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x04000401 RID: 1025
	[CompilerGenerated]
	private readonly T4 <p4>P;

	// Token: 0x04000402 RID: 1026
	[CompilerGenerated]
	private readonly T5 <p5>P;

	// Token: 0x04000403 RID: 1027
	[CompilerGenerated]
	private readonly T6 <p6>P;
}
