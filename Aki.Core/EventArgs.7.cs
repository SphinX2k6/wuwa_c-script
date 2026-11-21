using System;
using System.Runtime.CompilerServices;

// Token: 0x02000098 RID: 152
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6> : IEventArgs
{
	// Token: 0x060004B8 RID: 1208 RVA: 0x0001A85F File Offset: 0x00018A5F
	public EventArgs(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
		this.<p5>P = p5;
		this.<p6>P = p6;
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x0001A890 File Offset: 0x00018A90
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

	// Token: 0x060004BA RID: 1210 RVA: 0x0001A954 File Offset: 0x00018B54
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

	// Token: 0x0400040C RID: 1036
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x0400040D RID: 1037
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x0400040E RID: 1038
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x0400040F RID: 1039
	[CompilerGenerated]
	private readonly T4 <p4>P;

	// Token: 0x04000410 RID: 1040
	[CompilerGenerated]
	private readonly T5 <p5>P;

	// Token: 0x04000411 RID: 1041
	[CompilerGenerated]
	private readonly T6 <p6>P;
}
