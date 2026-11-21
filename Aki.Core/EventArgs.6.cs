using System;
using System.Runtime.CompilerServices;

// Token: 0x02000097 RID: 151
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5> : IEventArgs
{
	// Token: 0x060004B5 RID: 1205 RVA: 0x0001A6D7 File Offset: 0x000188D7
	public EventArgs(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
		this.<p5>P = p5;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x0001A700 File Offset: 0x00018900
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

	// Token: 0x060004B7 RID: 1207 RVA: 0x0001A7B0 File Offset: 0x000189B0
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

	// Token: 0x04000407 RID: 1031
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000408 RID: 1032
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000409 RID: 1033
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x0400040A RID: 1034
	[CompilerGenerated]
	private readonly T4 <p4>P;

	// Token: 0x0400040B RID: 1035
	[CompilerGenerated]
	private readonly T5 <p5>P;
}
