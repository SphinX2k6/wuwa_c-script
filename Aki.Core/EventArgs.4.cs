using System;
using System.Runtime.CompilerServices;

// Token: 0x02000093 RID: 147
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IEventArgs
{
	// Token: 0x0600046E RID: 1134 RVA: 0x00019CF3 File Offset: 0x00017EF3
	public EventArgs(T1 p1, T2 p2, T3 p3)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00019D0C File Offset: 0x00017F0C
	public bool Invoke(Enum name, Delegate handle)
	{
		Action<T1, T2, T3> action = handle as Action<T1, T2, T3>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P
			});
		}
		return true;
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00019D94 File Offset: 0x00017F94
	public bool Invoke(long name, Delegate handle)
	{
		Action<T1, T2, T3> action = handle as Action<T1, T2, T3>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P, this.<p3>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2, T3>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P,
				this.<p3>P
			});
		}
		return true;
	}

	// Token: 0x040003F2 RID: 1010
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x040003F3 RID: 1011
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x040003F4 RID: 1012
	[CompilerGenerated]
	private readonly T3 <p3>P;
}
