using System;
using System.Runtime.CompilerServices;

// Token: 0x02000094 RID: 148
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1, [Nullable(2)] T2> : IEventArgs
{
	// Token: 0x060004AC RID: 1196 RVA: 0x0001A35F File Offset: 0x0001855F
	public EventArgs(T1 p1, T2 p2)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0001A370 File Offset: 0x00018570
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

	// Token: 0x060004AE RID: 1198 RVA: 0x0001A3E4 File Offset: 0x000185E4
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

	// Token: 0x040003FE RID: 1022
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x040003FF RID: 1023
	[CompilerGenerated]
	private readonly T2 <p2>P;
}
