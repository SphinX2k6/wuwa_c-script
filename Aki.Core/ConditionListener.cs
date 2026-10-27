using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000099 RID: 153
[NullableContext(1)]
[Nullable(0)]
public class ConditionListener<[Nullable(2)] TParamType> : IConditionListener
{
	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600047D RID: 1149 RVA: 0x0001A4A2 File Offset: 0x000186A2
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<TParamType, List<EventHandleEntry>> PendingAddHandles
	{
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		get
		{
			return this.PendingAddHandlesInternal;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001A4AA File Offset: 0x000186AA
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public Dictionary<TParamType, List<Delegate>> PendingRemoveHandles
	{
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		get
		{
			return this.PendingRemoveHandlesInternal;
		}
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x0001A4B2 File Offset: 0x000186B2
	public bool IsHandlesEmpty()
	{
		return this.Handles.Count == 0;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0001A4C4 File Offset: 0x000186C4
	public bool Has(TParamType param, Delegate eventHandle)
	{
		List<EventHandleEntry> handles;
		return this.Handles.TryGetValue(param, out handles) && handles.ContainsHandle(eventHandle);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x0001A4EC File Offset: 0x000186EC
	public bool IsInPendingAdd(TParamType conditionParam, Delegate handle)
	{
		List<EventHandleEntry> handles;
		return this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(conditionParam, out handles) && handles.ContainsHandle(handle);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x0001A51C File Offset: 0x0001871C
	public bool IsInPendingRemove(TParamType conditionParam, Delegate handle)
	{
		List<Delegate> list;
		return this.PendingRemoveHandlesInternal != null && this.PendingRemoveHandlesInternal.TryGetValue(conditionParam, out list) && list.Contains(handle);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x0001A54C File Offset: 0x0001874C
	[return: Nullable(2)]
	public List<EventHandleEntry> GetHandlesByParam(TParamType param)
	{
		List<EventHandleEntry> result;
		this.Handles.TryGetValue(param, out result);
		return result;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0001A569 File Offset: 0x00018769
	public bool DeleteHandlesByParam(TParamType param)
	{
		return this.Handles.Remove(param);
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x0001A578 File Offset: 0x00018778
	public bool Add(TParamType param, Delegate eventHandle, EHandleType handleType)
	{
		List<EventHandleEntry> list;
		if (!this.Handles.TryGetValue(param, out list))
		{
			list = new List<EventHandleEntry>();
			this.Handles[param] = list;
		}
		if (list.ContainsHandle(eventHandle))
		{
			return false;
		}
		list.Add(new EventHandleEntry(eventHandle, handleType));
		return true;
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x0001A5C4 File Offset: 0x000187C4
	public bool Remove(TParamType param, Delegate eventHandle)
	{
		List<EventHandleEntry> handles;
		return this.Handles.TryGetValue(param, out handles) && handles.RemoveHandle(eventHandle);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x0001A5EC File Offset: 0x000187EC
	public bool AddToPendingAddHandles(TParamType conditionParam, Delegate handle, EHandleType handleType)
	{
		if (this.PendingAddHandlesInternal == null)
		{
			this.PendingAddHandlesInternal = new Dictionary<TParamType, List<EventHandleEntry>>();
		}
		List<EventHandleEntry> list;
		if (this.PendingAddHandlesInternal.TryGetValue(conditionParam, out list) && list.ContainsHandle(handle))
		{
			return false;
		}
		if (list == null)
		{
			list = new List<EventHandleEntry>();
			this.PendingAddHandlesInternal[conditionParam] = list;
		}
		list.Add(new EventHandleEntry(handle, handleType));
		return true;
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x0001A64C File Offset: 0x0001884C
	public bool AddToPendingRemoveHandles(TParamType conditionParam, Delegate handle)
	{
		if (this.PendingRemoveHandlesInternal == null)
		{
			this.PendingRemoveHandlesInternal = new Dictionary<TParamType, List<Delegate>>();
		}
		List<Delegate> list;
		if (this.PendingRemoveHandlesInternal.TryGetValue(conditionParam, out list) && list.Contains(handle))
		{
			return false;
		}
		if (list == null)
		{
			list = new List<Delegate>();
			this.PendingRemoveHandlesInternal[conditionParam] = list;
		}
		list.Add(handle);
		return true;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x0001A6A8 File Offset: 0x000188A8
	public bool RemoveFromPendingAddHandles(TParamType conditionParam, Delegate handle)
	{
		List<EventHandleEntry> handles;
		return this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(conditionParam, out handles) && handles.RemoveHandle(handle);
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0001A6D8 File Offset: 0x000188D8
	public bool RemoveFromPendingMoveHandles(TParamType conditionParam, Delegate handle)
	{
		List<Delegate> list;
		return this.PendingRemoveHandlesInternal != null && this.PendingRemoveHandlesInternal.TryGetValue(conditionParam, out list) && list.Remove(handle);
	}

	// Token: 0x0400040B RID: 1035
	private readonly Dictionary<TParamType, List<EventHandleEntry>> Handles = new Dictionary<TParamType, List<EventHandleEntry>>();

	// Token: 0x0400040C RID: 1036
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<TParamType, List<EventHandleEntry>> PendingAddHandlesInternal;

	// Token: 0x0400040D RID: 1037
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<TParamType, List<Delegate>> PendingRemoveHandlesInternal;
}
