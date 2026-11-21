using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200009B RID: 155
[NullableContext(1)]
[Nullable(0)]
public class ConditionListener<[Nullable(2)] TParamType> : IConditionListener
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001AC06 File Offset: 0x00018E06
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

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060004BF RID: 1215 RVA: 0x0001AC0E File Offset: 0x00018E0E
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

	// Token: 0x060004C0 RID: 1216 RVA: 0x0001AC16 File Offset: 0x00018E16
	public bool IsHandlesEmpty()
	{
		return this.Handles.Count == 0;
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x0001AC28 File Offset: 0x00018E28
	public bool Has(TParamType param, Delegate eventHandle)
	{
		List<EventHandleEntry> handles;
		return this.Handles.TryGetValue(param, out handles) && handles.ContainsHandle(eventHandle);
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0001AC50 File Offset: 0x00018E50
	public bool IsInPendingAdd(TParamType conditionParam, Delegate handle)
	{
		List<EventHandleEntry> handles;
		return this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(conditionParam, out handles) && handles.ContainsHandle(handle);
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0001AC80 File Offset: 0x00018E80
	public bool IsInPendingRemove(TParamType conditionParam, Delegate handle)
	{
		List<Delegate> list;
		return this.PendingRemoveHandlesInternal != null && this.PendingRemoveHandlesInternal.TryGetValue(conditionParam, out list) && list.Contains(handle);
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0001ACB0 File Offset: 0x00018EB0
	[return: Nullable(2)]
	public List<EventHandleEntry> GetHandlesByParam(TParamType param)
	{
		List<EventHandleEntry> result;
		this.Handles.TryGetValue(param, out result);
		return result;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x0001ACCD File Offset: 0x00018ECD
	public bool DeleteHandlesByParam(TParamType param)
	{
		return this.Handles.Remove(param);
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x0001ACDC File Offset: 0x00018EDC
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

	// Token: 0x060004C7 RID: 1223 RVA: 0x0001AD28 File Offset: 0x00018F28
	public bool Remove(TParamType param, Delegate eventHandle)
	{
		List<EventHandleEntry> handles;
		return this.Handles.TryGetValue(param, out handles) && handles.RemoveHandle(eventHandle);
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0001AD50 File Offset: 0x00018F50
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

	// Token: 0x060004C9 RID: 1225 RVA: 0x0001ADB0 File Offset: 0x00018FB0
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

	// Token: 0x060004CA RID: 1226 RVA: 0x0001AE0C File Offset: 0x0001900C
	public bool RemoveFromPendingAddHandles(TParamType conditionParam, Delegate handle)
	{
		List<EventHandleEntry> handles;
		return this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(conditionParam, out handles) && handles.RemoveHandle(handle);
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0001AE3C File Offset: 0x0001903C
	public bool RemoveFromPendingMoveHandles(TParamType conditionParam, Delegate handle)
	{
		List<Delegate> list;
		return this.PendingRemoveHandlesInternal != null && this.PendingRemoveHandlesInternal.TryGetValue(conditionParam, out list) && list.Remove(handle);
	}

	// Token: 0x04000419 RID: 1049
	private readonly Dictionary<TParamType, List<EventHandleEntry>> Handles = new Dictionary<TParamType, List<EventHandleEntry>>();

	// Token: 0x0400041A RID: 1050
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<TParamType, List<EventHandleEntry>> PendingAddHandlesInternal;

	// Token: 0x0400041B RID: 1051
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<TParamType, List<Delegate>> PendingRemoveHandlesInternal;
}
