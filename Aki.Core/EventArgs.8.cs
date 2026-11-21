using System;
using System.Runtime.CompilerServices;

// Token: 0x02000099 RID: 153
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7> : IEventArgs
{
	// Token: 0x060004BB RID: 1211 RVA: 0x0001AA17 File Offset: 0x00018C17
	public EventArgs(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
		this.<p5>P = p5;
		this.<p6>P = p6;
		this.<p7>P = p7;
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x0001AA50 File Offset: 0x00018C50
	public bool Invoke(Enum name, Delegate handle)
	{
		Action<T1, T2, T3, T4, T5, T6, T7> action = handle as Action<T1, T2, T3, T4, T5, T6, T7>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P, this.<p5>P, this.<p6>P, this.<p7>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4, T5, T6, T7>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P,
				this.<p5>P,
				this.<p6>P,
				this.<p7>P
			});
		}
		return true;
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x0001AB2C File Offset: 0x00018D2C
	public bool Invoke(long name, Delegate handle)
	{
		Action<T1, T2, T3, T4, T5, T6, T7> action = handle as Action<T1, T2, T3, T4, T5, T6, T7>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P, this.<p5>P, this.<p6>P, this.<p7>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4, T5, T6, T7>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P,
				this.<p5>P,
				this.<p6>P,
				this.<p7>P
			});
		}
		return true;
	}

	// Token: 0x04000412 RID: 1042
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000413 RID: 1043
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000414 RID: 1044
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x04000415 RID: 1045
	[CompilerGenerated]
	private readonly T4 <p4>P;

	// Token: 0x04000416 RID: 1046
	[CompilerGenerated]
	private readonly T5 <p5>P;

	// Token: 0x04000417 RID: 1047
	[CompilerGenerated]
	private readonly T6 <p6>P;

	// Token: 0x04000418 RID: 1048
	[CompilerGenerated]
	private readonly T7 <p7>P;
}
