using System;
using System.Runtime.CompilerServices;

// Token: 0x02000092 RID: 146
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2> : IEventArgs
{
	// Token: 0x0600046B RID: 1131 RVA: 0x00019BFB File Offset: 0x00017DFB
	public EventArgs(T1 p1, T2 p2)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00019C0C File Offset: 0x00017E0C
	public bool Invoke(Enum name, Delegate handle)
	{
		Action<T1, T2> action = handle as Action<T1, T2>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P
			});
		}
		return true;
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00019C80 File Offset: 0x00017E80
	public bool Invoke(long name, Delegate handle)
	{
		Action<T1, T2> action = handle as Action<T1, T2>;
		if (action != null)
		{
			action(this.<p1>P, this.<p2>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1, T2>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P,
				this.<p2>P
			});
		}
		return true;
	}

	// Token: 0x040003F0 RID: 1008
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x040003F1 RID: 1009
	[CompilerGenerated]
	private readonly T2 <p2>P;
}
