using System;
using System.Runtime.CompilerServices;

// Token: 0x02000091 RID: 145
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventArgs<[Nullable(2)] T1> : IEventArgs
{
	// Token: 0x06000468 RID: 1128 RVA: 0x00019B32 File Offset: 0x00017D32
	public EventArgs(T1 p1)
	{
		this.<p1>P = p1;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00019B3C File Offset: 0x00017D3C
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

	// Token: 0x0600046A RID: 1130 RVA: 0x00019B9C File Offset: 0x00017D9C
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

	// Token: 0x040003EF RID: 1007
	[CompilerGenerated]
	private readonly T1 <p1>P;
}
