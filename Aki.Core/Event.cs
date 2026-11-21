using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200008E RID: 142
[NullableContext(1)]
[Nullable(0)]
public class Event<[Nullable(0)] TName, [Nullable(0)] TType> : IClear where TName : Enum where TType : Delegate
{
	// Token: 0x06000473 RID: 1139 RVA: 0x00019274 File Offset: 0x00017474
	private void AddHoldKeyValueToMapInternal<[Nullable(0)] T>(TName name, object holdKey, object objectKey, Dictionary<TName, Dictionary<object, object>> keyMap) where T : TName
	{
		Dictionary<object, object> dictionary;
		if (!keyMap.TryGetValue(name, out dictionary))
		{
			dictionary = new Dictionary<object, object>();
			keyMap[name] = dictionary;
		}
		dictionary[objectKey] = holdKey;
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x000192A4 File Offset: 0x000174A4
	private void RemoveHoldKeyValueFromMapInternal(TName name, object holdKey, Dictionary<TName, Dictionary<object, object>> keyMap)
	{
		Dictionary<object, object> dictionary;
		if (!keyMap.TryGetValue(name, out dictionary))
		{
			return;
		}
		dictionary.Remove(holdKey);
		if (dictionary.Count == 0)
		{
			keyMap.Remove(name);
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000192D8 File Offset: 0x000174D8
	[return: Nullable(2)]
	private object GetHoldKeyValueOfMapInternal(TName name, object holdKey, Dictionary<TName, Dictionary<object, object>> keyMap)
	{
		Dictionary<object, object> dictionary;
		if (!keyMap.TryGetValue(name, out dictionary))
		{
			return null;
		}
		return dictionary.GetValueOrDefault(holdKey);
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x000192F9 File Offset: 0x000174F9
	public void AddHoldKeyHandle<[Nullable(0)] T>(TName name, object objectKey, object handle) where T : TName
	{
		this.AddHoldKeyValueToMapInternal<T>(name, handle, objectKey, this.HoldKeyHandles);
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0001930A File Offset: 0x0001750A
	public void RemoveHoldKeyHandle(TName name, object handle)
	{
		this.RemoveHoldKeyValueFromMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0001931A File Offset: 0x0001751A
	[return: Nullable(2)]
	public object GetHoldKeyByHandle(TName name, object handle)
	{
		return this.GetHoldKeyValueOfMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0001932C File Offset: 0x0001752C
	public bool Has(TName name, TType handle)
	{
		List<EventHandleEntry> handles;
		if (this.Handles.TryGetValue(name, out handles) && handles.ContainsHandle(handle))
		{
			List<Delegate> list;
			return !this.PendingRemoveHandles.TryGetValue(name, out list) || !list.Contains(handle);
		}
		List<EventHandleEntry> handles2;
		return this.PendingAddHandles.TryGetValue(name, out handles2) && handles2.ContainsHandle(handle);
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00019397 File Offset: 0x00017597
	public bool HasAny(TName name)
	{
		return this.Handles.ContainsKey(name) || this.PendingAddHandles.ContainsKey(name);
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x000193B5 File Offset: 0x000175B5
	public bool Add(TName name, TType handle)
	{
		return this.AddInternal(name, handle, EHandleType.Forever);
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x000193C0 File Offset: 0x000175C0
	public bool Once(TName name, TType handle)
	{
		return this.AddInternal(name, handle, EHandleType.Once);
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x000193CB File Offset: 0x000175CB
	public bool Remove(TName name, TType handle)
	{
		return this.IsRegistered(name, handle) && this.RemoveInternal(name, handle);
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x000193EC File Offset: 0x000175EC
	private bool IsRegistered(TName name, Delegate handle)
	{
		List<EventHandleEntry> handles;
		List<EventHandleEntry> handles2;
		return (this.Handles.TryGetValue(name, out handles) && handles.ContainsHandle(handle)) || (this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(name, out handles2) && handles2.ContainsHandle(handle));
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00019438 File Offset: 0x00017638
	public bool ClearObject()
	{
		this.Handles.Clear();
		Dictionary<TName, List<EventHandleEntry>> pendingAddHandlesInternal = this.PendingAddHandlesInternal;
		if (pendingAddHandlesInternal != null)
		{
			pendingAddHandlesInternal.Clear();
		}
		Dictionary<TName, List<Delegate>> pendingRemoveHandlesInternal = this.PendingRemoveHandlesInternal;
		if (pendingRemoveHandlesInternal != null)
		{
			pendingRemoveHandlesInternal.Clear();
		}
		this.EmittingMaskSet.Clear();
		this.HoldKeyHandles.Clear();
		return true;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0001948C File Offset: 0x0001768C
	public bool ClearObject(TName name)
	{
		List<EventHandleEntry> list;
		if (!this.Handles.TryGetValue(name, out list))
		{
			return true;
		}
		foreach (EventHandleEntry eventHandleEntry in list.ToArray())
		{
			this.RemoveInternal(name, eventHandleEntry.Handle);
		}
		return true;
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000194D8 File Offset: 0x000176D8
	public bool Emit(TName name)
	{
		return this.EmitInternal<EventArgs>(name, default(EventArgs), default(EventArgs));
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00019503 File Offset: 0x00017703
	public bool Emit<[Nullable(2)] T1>(TName name, T1 p1)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1>(p1), p1);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00019518 File Offset: 0x00017718
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2>(TName name, T1 p1, T2 p2)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2>(p1, p2), p1);
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0001952E File Offset: 0x0001772E
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(TName name, T1 p1, T2 p2, T3 p3)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3>(p1, p2, p3), p1);
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00019546 File Offset: 0x00017746
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(TName name, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4>(p1, p2, p3, p4), p1);
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00019560 File Offset: 0x00017760
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(TName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4, T5>(p1, p2, p3, p4, p5), p1);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x0001957C File Offset: 0x0001777C
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(TName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4, T5, T6>(p1, p2, p3, p4, p5, p6), p1);
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x0001959C File Offset: 0x0001779C
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(TName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4, T5, T6, T7>(p1, p2, p3, p4, p5, p6, p7), p1);
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x000195C8 File Offset: 0x000177C8
	private unsafe bool EmitInternal<[Nullable(2)] T1>(TName name, IEventArgs args, [Nullable(2)] T1 conditionParam)
	{
		if (this.IsEmitting(name))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "事件重复派发，请检查事件链是否产生循环调用";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("emittingEventInSet", this.EmittingMaskSet);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		this.SetEmitting(name, true);
		ConditionListener<T1> conditionListener = this.GetConditionListener<T1>(name);
		if (conditionListener != null && conditionParam != null)
		{
			List<EventHandleEntry> handlesByParam = conditionListener.GetHandlesByParam(conditionParam);
			if (handlesByParam != null)
			{
				this.ExecuteHandlesInternal<T1>(name, handlesByParam, conditionListener, args, conditionParam);
				if (handlesByParam.Count == 0)
				{
					conditionListener.DeleteHandlesByParam(conditionParam);
				}
			}
		}
		List<EventHandleEntry> list;
		if (this.Handles.TryGetValue(name, out list))
		{
			this.ExecuteHandlesInternal<T1>(name, list, null, args, default(T1));
			if (list.Count == 0)
			{
				this.Handles.Remove(name);
			}
		}
		this.SetEmitting(name, false);
		List<Delegate> list2;
		if (this.PendingRemoveHandles.TryGetValue(name, out list2))
		{
			foreach (Delegate handle in list2)
			{
				this.DoRemove(name, handle);
			}
			list2.Clear();
			this.PendingRemoveHandles.Remove(name);
		}
		List<EventHandleEntry> list3;
		if (this.PendingAddHandles.TryGetValue(name, out list3))
		{
			foreach (EventHandleEntry eventHandleEntry in list3)
			{
				this.DoAdd(name, eventHandleEntry.Handle, eventHandleEntry.HandleType);
			}
			list3.Clear();
			this.PendingAddHandles.Remove(name);
		}
		if (conditionListener != null)
		{
			if (conditionListener.PendingRemoveHandles != null && conditionListener.PendingRemoveHandles.Count > 0)
			{
				foreach (KeyValuePair<T1, List<Delegate>> keyValuePair in conditionListener.PendingRemoveHandles)
				{
					foreach (Delegate handle2 in keyValuePair.Value)
					{
						this.DoRemoveWithCondition<T1>(name, keyValuePair.Key, handle2);
					}
				}
				conditionListener.PendingRemoveHandles.Clear();
			}
			if (conditionListener.PendingAddHandles != null && conditionListener.PendingAddHandles.Count > 0)
			{
				foreach (KeyValuePair<T1, List<EventHandleEntry>> keyValuePair2 in conditionListener.PendingAddHandles)
				{
					foreach (EventHandleEntry eventHandleEntry2 in keyValuePair2.Value)
					{
						this.DoAddWithCondition<T1>(name, conditionListener, eventHandleEntry2.Handle, eventHandleEntry2.HandleType, keyValuePair2.Key);
					}
				}
				conditionListener.PendingAddHandles.Clear();
			}
			if (conditionListener.IsHandlesEmpty())
			{
				this.ConditionHandles.Remove(name);
			}
		}
		return true;
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00019928 File Offset: 0x00017B28
	private unsafe void ExecuteHandlesInternal<[Nullable(2)] T1>(TName name, List<EventHandleEntry> handles, [Nullable(new byte[]
	{
		2,
		1
	})] ConditionListener<T1> conditionListener, IEventArgs args, [Nullable(2)] T1 conditionParam)
	{
		foreach (EventHandleEntry eventHandleEntry in handles)
		{
			Delegate handle = eventHandleEntry.Handle;
			if (!((conditionListener != null) ? conditionListener.IsInPendingRemove(conditionParam, handle) : this.CheckInPendingRemoveHandles(name, handle)))
			{
				if (eventHandleEntry.HandleType == EHandleType.Once)
				{
					if (conditionListener != null)
					{
						this.RemoveWithConditionInternal<T1>(name, handle, conditionParam);
					}
					else
					{
						this.RemoveInternal(name, handle);
					}
				}
				try
				{
					args.Invoke(name, handle);
				}
				catch (Exception ex) when (1)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Event;
					ELogAuthor author = ELogAuthor.LCC;
					string message = "事件处理方法执行异常";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00019A58 File Offset: 0x00017C58
	private bool AddInternal(TName name, TType handle, EHandleType handleType)
	{
		Event<TName, TType>.SetupHandleStat(handle);
		if (!this.IsEmitting(name))
		{
			return this.DoAdd(name, handle, handleType);
		}
		List<EventHandleEntry> handles;
		if (this.Handles.TryGetValue(name, out handles) && handles.ContainsHandle(handle))
		{
			List<Delegate> list;
			if (!this.PendingRemoveHandles.TryGetValue(name, out list) || !list.Contains(handle))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "事件已存在，请检查同一个事件名同一个处理函数的注册逻辑";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			list.Remove(handle);
			return true;
		}
		else
		{
			List<EventHandleEntry> list2;
			if (this.PendingAddHandles.TryGetValue(name, out list2) && list2.ContainsHandle(handle))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message2 = "事件重复注册在待修改列表，请检查同一个事件名同一个处理函数的注册逻辑";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", name);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (list2 == null)
			{
				list2 = new List<EventHandleEntry>();
				this.PendingAddHandles[name] = list2;
			}
			list2.Add(new EventHandleEntry(handle, handleType));
			return true;
		}
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00019B78 File Offset: 0x00017D78
	private static void SetupHandleStat(Delegate handle)
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00019B88 File Offset: 0x00017D88
	private bool DoAdd(TName name, Delegate handle, EHandleType handleType)
	{
		List<EventHandleEntry> list;
		if (!this.Handles.TryGetValue(name, out list))
		{
			list = new List<EventHandleEntry>();
			this.Handles[name] = list;
		}
		else if (list.ContainsHandle(handle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "事件重复注册，请检查同一个事件名同一个处理函数的注册逻辑";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		list.Add(new EventHandleEntry(handle, handleType));
		return true;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00019C00 File Offset: 0x00017E00
	private bool RemoveInternal(TName name, Delegate handle)
	{
		if (!this.IsEmitting(name))
		{
			return this.DoRemove(name, handle);
		}
		List<EventHandleEntry> handles;
		if (!this.Handles.TryGetValue(name, out handles) || !handles.ContainsHandle(handle))
		{
			List<EventHandleEntry> handles2;
			if (!this.PendingAddHandles.TryGetValue(name, out handles2) || !handles2.ContainsHandle(handle))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "事件不存在，请检查同一个事件名同一个处理函数的移除逻辑";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			handles2.RemoveHandle(handle);
			return true;
		}
		else
		{
			List<Delegate> list;
			if (this.PendingRemoveHandles.TryGetValue(name, out list) && list.Contains(handle))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message2 = "事件重复移除在待移除列表，请检查同一个事件名同一个处理函数的移除逻辑";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", name);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (list == null)
			{
				list = new List<Delegate>();
				this.PendingRemoveHandles[name] = list;
			}
			list.Add(handle);
			return true;
		}
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00019CF0 File Offset: 0x00017EF0
	private bool DoRemove(TName name, Delegate handle)
	{
		List<EventHandleEntry> list;
		if (!this.Handles.TryGetValue(name, out list) || !list.RemoveHandle(handle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "事件不存在，请检查同一个事件名同一个处理函数的移除逻辑";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (list.Count == 0)
		{
			this.Handles.Remove(name);
		}
		return true;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00019D59 File Offset: 0x00017F59
	public bool IsEmitting(TName name)
	{
		return this.EmittingMaskSet.Contains(name);
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00019D67 File Offset: 0x00017F67
	private void SetEmitting(TName name, bool isEmitting)
	{
		if (isEmitting)
		{
			this.EmittingMaskSet.Add(name);
			return;
		}
		this.EmittingMaskSet.Remove(name);
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000492 RID: 1170 RVA: 0x00019D87 File Offset: 0x00017F87
	private Dictionary<TName, List<EventHandleEntry>> PendingAddHandles
	{
		get
		{
			if (this.PendingAddHandlesInternal == null)
			{
				this.PendingAddHandlesInternal = new Dictionary<TName, List<EventHandleEntry>>();
			}
			return this.PendingAddHandlesInternal;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000493 RID: 1171 RVA: 0x00019DA2 File Offset: 0x00017FA2
	private Dictionary<TName, List<Delegate>> PendingRemoveHandles
	{
		get
		{
			if (this.PendingRemoveHandlesInternal == null)
			{
				this.PendingRemoveHandlesInternal = new Dictionary<TName, List<Delegate>>();
			}
			return this.PendingRemoveHandlesInternal;
		}
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00019DC0 File Offset: 0x00017FC0
	private bool CheckInPendingRemoveHandles(TName name, Delegate handle)
	{
		List<Delegate> valueOrDefault = this.PendingRemoveHandles.GetValueOrDefault(name);
		return valueOrDefault != null && valueOrDefault.Contains(handle);
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00019DE8 File Offset: 0x00017FE8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public ConditionListener<T> GetConditionListener<[Nullable(2)] T>(TName name)
	{
		IConditionListener conditionListener;
		if (this.ConditionHandles.TryGetValue(name, out conditionListener))
		{
			ConditionListener<T> conditionListener2 = conditionListener as ConditionListener<T>;
			if (conditionListener2 != null)
			{
				return conditionListener2;
			}
		}
		return null;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00019E14 File Offset: 0x00018014
	public bool HasWithCondition<[Nullable(2)] T1>(TName name, Delegate handle, T1 param)
	{
		ConditionListener<T1> conditionListener = this.GetConditionListener<T1>(name);
		if (conditionListener == null)
		{
			return false;
		}
		if (conditionListener.Has(param, handle))
		{
			return !conditionListener.IsInPendingRemove(param, handle);
		}
		return conditionListener.IsInPendingAdd(param, handle);
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00019E4C File Offset: 0x0001804C
	public bool AddWithCondition<[Nullable(2)] T1>(TName name, Delegate handle, T1 conditionParam)
	{
		return this.AddWithConditionInternal<T1>(name, handle, EHandleType.Forever, conditionParam);
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00019E58 File Offset: 0x00018058
	public bool OnceWithCondition<[Nullable(2)] T1>(TName name, Delegate handle, T1 conditionParam)
	{
		return this.AddWithConditionInternal<T1>(name, handle, EHandleType.Once, conditionParam);
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00019E64 File Offset: 0x00018064
	private bool AddWithConditionInternal<[Nullable(2)] T1>(TName name, Delegate handle, EHandleType handleType, T1 param)
	{
		Event<TName, TType>.SetupHandleStat(handle);
		IConditionListener value;
		if (!this.ConditionHandles.TryGetValue(name, out value))
		{
			value = new ConditionListener<T1>();
			this.ConditionHandles[name] = value;
		}
		ConditionListener<T1> conditionListener = this.GetConditionListener<T1>(name);
		if (!this.IsEmitting(name))
		{
			return this.DoAddWithCondition<T1>(name, conditionListener, handle, handleType, param);
		}
		if (conditionListener.Has(param, handle))
		{
			bool flag = conditionListener.RemoveFromPendingMoveHandles(param, handle);
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "条件事件已存在，请检查同一个事件名同一个处理函数的注册逻辑";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return flag;
		}
		bool flag2 = conditionListener.AddToPendingAddHandles(param, handle, handleType);
		if (!flag2)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Event;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "条件事件重复注册在待修改列表，请检查同一个事件名同一个处理函数的注册逻辑";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", name);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return flag2;
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00019F38 File Offset: 0x00018138
	private bool DoAddWithCondition<[Nullable(2)] T1>(TName name, ConditionListener<T1> conditionListener, Delegate handle, EHandleType handleType, T1 param)
	{
		if (conditionListener.Has(param, handle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "事件重复注册，请检查同一个事件名同一个处理函数的注册逻辑";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		conditionListener.Add(param, handle, handleType);
		return true;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00019F8C File Offset: 0x0001818C
	public bool RemoveWithCondition<[Nullable(2)] T1>(TName name, Delegate handle, T1 param)
	{
		ConditionListener<T1> conditionListener = this.GetConditionListener<T1>(name);
		return conditionListener != null && (conditionListener.Has(param, handle) || conditionListener.IsInPendingAdd(param, handle)) && this.RemoveWithConditionInternal<T1>(name, handle, param);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00019FC4 File Offset: 0x000181C4
	private bool RemoveWithConditionInternal<[Nullable(2)] T1>(TName name, Delegate handle, T1 param)
	{
		if (!this.IsEmitting(name))
		{
			return this.DoRemoveWithCondition<T1>(name, param, handle);
		}
		ConditionListener<T1> conditionListener = this.GetConditionListener<T1>(name);
		if (conditionListener == null)
		{
			return true;
		}
		if (!conditionListener.Has(param, handle))
		{
			bool flag = conditionListener.RemoveFromPendingAddHandles(param, handle);
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "事件不存在，请检查同一个事件名同一个处理函数的移除逻辑";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return flag;
		}
		bool flag2 = conditionListener.AddToPendingRemoveHandles(param, handle);
		if (!flag2)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Event;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "事件重复移除在待移除列表，请检查同一个事件名同一个处理函数的移除逻辑";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", name);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return flag2;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x0001A06C File Offset: 0x0001826C
	private bool DoRemoveWithCondition<[Nullable(2)] T1>(TName name, T1 param, Delegate handle)
	{
		ConditionListener<T1> conditionListener = this.GetConditionListener<T1>(name);
		if (conditionListener == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "事件不存在，请检查同一个事件名同一个处理函数的移除逻辑";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		bool flag = conditionListener.Remove(param, handle);
		if (!flag)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Event;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "事件条件不存在，请检查同一个事件名同一个处理函数的移除逻辑";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", name);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return flag;
	}

	// Token: 0x040003F7 RID: 1015
	private readonly Dictionary<TName, List<EventHandleEntry>> Handles = new Dictionary<TName, List<EventHandleEntry>>();

	// Token: 0x040003F8 RID: 1016
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<TName, List<EventHandleEntry>> PendingAddHandlesInternal;

	// Token: 0x040003F9 RID: 1017
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<TName, List<Delegate>> PendingRemoveHandlesInternal;

	// Token: 0x040003FA RID: 1018
	private readonly HashSet<TName> EmittingMaskSet = new HashSet<TName>();

	// Token: 0x040003FB RID: 1019
	private readonly Dictionary<TName, Dictionary<object, object>> HoldKeyHandles = new Dictionary<TName, Dictionary<object, object>>();

	// Token: 0x040003FC RID: 1020
	private readonly Dictionary<TName, IConditionListener> ConditionHandles = new Dictionary<TName, IConditionListener>();
}
