using System;
using System.Runtime.CompilerServices;

// Token: 0x02000094 RID: 148
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4> : IEventArgs
{
	// Token: 0x06000471 RID: 1137 RVA: 0x00019E1B File Offset: 0x0001801B
	public EventArgs(T1 p1, T2 p2, T3 p3, T4 p4)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00019E3C File Offset: 0x0001803C
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

	// Token: 0x06000473 RID: 1139 RVA: 0x00019ED8 File Offset: 0x000180D8
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

	// Token: 0x040003F5 RID: 1013
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x040003F6 RID: 1014
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x040003F7 RID: 1015
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x040003F8 RID: 1016
	[CompilerGenerated]
	private readonly T4 <p4>P;
}
