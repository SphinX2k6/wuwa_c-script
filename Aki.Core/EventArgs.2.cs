using System;
using System.Runtime.CompilerServices;

// Token: 0x02000093 RID: 147
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1> : IEventArgs
{
	// Token: 0x060004A9 RID: 1193 RVA: 0x0001A296 File Offset: 0x00018496
	public EventArgs(T1 p1)
	{
		this.<p1>P = p1;
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x0001A2A0 File Offset: 0x000184A0
	public bool Invoke(Enum name, Delegate handle)
	{
		Action<T1> action = handle as Action<T1>;
		if (action != null)
		{
			action(this.<p1>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P
			});
		}
		return true;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0001A300 File Offset: 0x00018500
	public bool Invoke(long name, Delegate handle)
	{
		Action<T1> action = handle as Action<T1>;
		if (action != null)
		{
			action(this.<p1>P);
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action<T1>), handle, name);
				return false;
			}
			genericEventHandler(new object[]
			{
				this.<p1>P
			});
		}
		return true;
	}

	// Token: 0x040003FD RID: 1021
	[CompilerGenerated]
	private readonly T1 <p1>P;
}
