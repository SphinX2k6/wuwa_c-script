using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200009D RID: 157
[NullableContext(1)]
[Nullable(0)]
internal static class EventHandleListExtensions
{
	// Token: 0x060004CE RID: 1230 RVA: 0x0001AE9C File Offset: 0x0001909C
	public static int IndexOfHandle(this List<EventHandleEntry> handles, Delegate handle)
	{
		ArgumentNullException.ThrowIfNull(handle, "handle");
		for (int i = 0; i < handles.Count; i++)
		{
			if (handles[i].Handle == handle)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0001AEDC File Offset: 0x000190DC
	public static bool ContainsHandle(this List<EventHandleEntry> handles, Delegate handle)
	{
		return handles.IndexOfHandle(handle) >= 0;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0001AEEC File Offset: 0x000190EC
	public static bool RemoveHandle(this List<EventHandleEntry> handles, Delegate handle)
	{
		int num = handles.IndexOfHandle(handle);
		if (num < 0)
		{
			return false;
		}
		handles.RemoveAt(num);
		return true;
	}
}
