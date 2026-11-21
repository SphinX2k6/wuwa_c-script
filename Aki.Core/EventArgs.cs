using System;
using System.Runtime.CompilerServices;

// Token: 0x02000092 RID: 146
public readonly struct EventArgs : IEventArgs
{
	// Token: 0x060004A7 RID: 1191 RVA: 0x0001A200 File Offset: 0x00018400
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

	// Token: 0x060004A8 RID: 1192 RVA: 0x0001A24C File Offset: 0x0001844C
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
