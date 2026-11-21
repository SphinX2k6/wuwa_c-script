using System;
using System.Runtime.CompilerServices;

// Token: 0x02000096 RID: 150
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4> : IEventArgs
{
	// Token: 0x060004B2 RID: 1202 RVA: 0x0001A57F File Offset: 0x0001877F
	public EventArgs(T1 p1, T2 p2, T3 p3, T4 p4)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x0001A5A0 File Offset: 0x000187A0
	public bool Invoke(Enum name, Delegate handle)
	{
		Action<T1, T2, T3, T4> action = handle as Action<T1, T2, T3, T4>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P
			});
		}
		return true;
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x0001A63C File Offset: 0x0001883C
	public bool Invoke(long name, Delegate handle)
	{
		Action<T1, T2, T3, T4> action = handle as Action<T1, T2, T3, T4>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P, this.<p4>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3, T4>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P,
				this.<p4>P
			});
		}
		return true;
	}

	// Token: 0x04000403 RID: 1027
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000404 RID: 1028
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000405 RID: 1029
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x04000406 RID: 1030
	[CompilerGenerated]
	private readonly T4 <p4>P;
}
