using System;
using System.Runtime.CompilerServices;

// Token: 0x02000097 RID: 151
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7> : IEventArgs
{
	// Token: 0x0600047A RID: 1146 RVA: 0x0001A2B3 File Offset: 0x000184B3
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

	// Token: 0x0600047B RID: 1147 RVA: 0x0001A2EC File Offset: 0x000184EC
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

	// Token: 0x0600047C RID: 1148 RVA: 0x0001A3C8 File Offset: 0x000185C8
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

	// Token: 0x04000404 RID: 1028
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000405 RID: 1029
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000406 RID: 1030
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x04000407 RID: 1031
	[CompilerGenerated]
	private readonly T4 <p4>P;

	// Token: 0x04000408 RID: 1032
	[CompilerGenerated]
	private readonly T5 <p5>P;

	// Token: 0x04000409 RID: 1033
	[CompilerGenerated]
	private readonly T6 <p6>P;

	// Token: 0x0400040A RID: 1034
	[CompilerGenerated]
	private readonly T7 <p7>P;
}
