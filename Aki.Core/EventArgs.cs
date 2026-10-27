using System;
using System.Runtime.CompilerServices;

// Token: 0x02000090 RID: 144
public readonly struct EventArgs : IEventArgs
{
	// Token: 0x06000466 RID: 1126 RVA: 0x00019A9C File Offset: 0x00017C9C
	[NullableContext(1)]
	public bool Invoke(Enum name, Delegate handle)
	{
		Action action = handle as Action;
		if (action != null)
		{
			action();
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action), handle, name);
				return false;
			}
			genericEventHandler(Array.Empty<object>());
		}
		return true;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00019AE8 File Offset: 0x00017CE8
	[NullableContext(1)]
	public bool Invoke(long name, Delegate handle)
	{
		Action action = handle as Action;
		if (action != null)
		{
			action();
		}
		else
		{
			GenericEventHandler genericEventHandler = handle as GenericEventHandler;
			if (genericEventHandler == null)
			{
				EventArgsUtils.CastFail(typeof(Action), handle, name);
				return false;
			}
			genericEventHandler(Array.Empty<object>());
		}
		return true;
	}
}
