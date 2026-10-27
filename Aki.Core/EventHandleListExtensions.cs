using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200009B RID: 155
[NullableContext(1)]
[Nullable(0)]
internal static class EventHandleListExtensions
{
	// Token: 0x0600048D RID: 1165 RVA: 0x0001A738 File Offset: 0x00018938
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

	// Token: 0x0600048E RID: 1166 RVA: 0x0001A778 File Offset: 0x00018978
	public static bool ContainsHandle(this List<EventHandleEntry> handles, Delegate handle)
	{
		return handles.IndexOfHandle(handle) >= 0;
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x0001A788 File Offset: 0x00018988
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
