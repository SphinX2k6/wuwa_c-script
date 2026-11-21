using System;
using System.Runtime.CompilerServices;

// Token: 0x02000095 RID: 149
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IEventArgs
{
	// Token: 0x060004AF RID: 1199 RVA: 0x0001A457 File Offset: 0x00018657
	public EventArgs(T1 p1, T2 p2, T3 p3)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x0001A470 File Offset: 0x00018670
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

	// Token: 0x060004B1 RID: 1201 RVA: 0x0001A4F8 File Offset: 0x000186F8
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

	// Token: 0x04000400 RID: 1024
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000401 RID: 1025
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000402 RID: 1026
	[CompilerGenerated]
	private readonly T3 <p3>P;
}
