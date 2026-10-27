using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200008C RID: 140
[NullableContext(1)]
[Nullable(0)]
public class Event<[Nullable(0)] TName, [Nullable(0)] TType> : IClear where TName : Enum where TType : Delegate
{
	// Token: 0x06000432 RID: 1074 RVA: 0x00018A7C File Offset: 0x00016C7C
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

	// Token: 0x06000433 RID: 1075 RVA: 0x00018AAC File Offset: 0x00016CAC
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

	// Token: 0x06000434 RID: 1076 RVA: 0x00018AE0 File Offset: 0x00016CE0
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

	// Token: 0x06000435 RID: 1077 RVA: 0x00018B01 File Offset: 0x00016D01
	public void AddHoldKeyHandle<[Nullable(0)] T>(TName name, object objectKey, object handle) where T : TName
	{
		this.AddHoldKeyValueToMapInternal<T>(name, handle, objectKey, this.HoldKeyHandles);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00018B12 File Offset: 0x00016D12
	public void RemoveHoldKeyHandle(TName name, object handle)
	{
		this.RemoveHoldKeyValueFromMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00018B22 File Offset: 0x00016D22
	[return: Nullable(2)]
	public object GetHoldKeyByHandle(TName name, object handle)
	{
		return this.GetHoldKeyValueOfMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00018B34 File Offset: 0x00016D34
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

	// Token: 0x06000439 RID: 1081 RVA: 0x00018B9F File Offset: 0x00016D9F
	public bool HasAny(TName name)
	{
		return this.Handles.ContainsKey(name) || this.PendingAddHandles.ContainsKey(name);
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00018BBD File Offset: 0x00016DBD
	public bool Add(TName name, TType handle)
	{
		return this.AddInternal(name, handle, EHandleType.Forever);
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00018BC8 File Offset: 0x00016DC8
	public bool Once(TName name, TType handle)
	{
		return this.AddInternal(name, handle, EHandleType.Once);
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00018BD3 File Offset: 0x00016DD3
	public bool Remove(TName name, TType handle)
	{
		return this.IsRegistered(name, handle) && this.RemoveInternal(name, handle);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00018BF4 File Offset: 0x00016DF4
	private bool IsRegistered(TName name, Delegate handle)
	{
		List<EventHandleEntry> handles;
		List<EventHandleEntry> handles2;
		return (this.Handles.TryGetValue(name, out handles) && handles.ContainsHandle(handle)) || (this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(name, out handles2) && handles2.ContainsHandle(handle));
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00018C40 File Offset: 0x00016E40
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

	// Token: 0x0600043F RID: 1087 RVA: 0x00018C94 File Offset: 0x00016E94
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

	// Token: 0x06000440 RID: 1088 RVA: 0x00018CE0 File Offset: 0x00016EE0
	public bool Emit(TName name)
	{
		return this.EmitInternal<EventArgs>(name, default(EventArgs), default(EventArgs));
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00018D0B File Offset: 0x00016F0B
	public bool Emit<[Nullable(2)] T1>(TName name, T1 p1)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1>(p1), p1);
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00018D20 File Offset: 0x00016F20
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2>(TName name, T1 p1, T2 p2)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2>(p1, p2), p1);
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00018D36 File Offset: 0x00016F36
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(TName name, T1 p1, T2 p2, T3 p3)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3>(p1, p2, p3), p1);
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00018D4E File Offset: 0x00016F4E
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(TName name, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4>(p1, p2, p3, p4), p1);
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00018D68 File Offset: 0x00016F68
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(TName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4, T5>(p1, p2, p3, p4, p5), p1);
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00018D84 File Offset: 0x00016F84
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(TName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4, T5, T6>(p1, p2, p3, p4, p5, p6), p1);
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00018DA4 File Offset: 0x00016FA4
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(TName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
	{
		return this.EmitInternal<T1>(name, new EventArgs<T1, T2, T3, T4, T5, T6, T7>(p1, p2, p3, p4, p5, p6, p7), p1);
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00018DD0 File Offset: 0x00016FD0
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

	// Token: 0x06000449 RID: 1097 RVA: 0x00019130 File Offset: 0x00017330
	private unsafe void ExecuteHandlesInternal<[Nullable(2)] T1>(TName name, List<EventHandleEntry> handles, [Nullable(new byte[]
	{
		2,
		1
	})] ConditionListener<T1> conditionListener, IEventArgs args, [Nullable(2)] T1 conditionParam)
	{
		Stat value = null;
		if (Stat.Enable && !EventConstant.NameStateMap.TryGetValue(name, out value))
		{
			EventConstant.NameStateMap[name] = value;
		}
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
				Stat stat = null;
				if (Stat.Enable)
				{
					EventConstant.HandleStatMap.TryGetValue(handle.Method, out stat);
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

	// Token: 0x0600044A RID: 1098 RVA: 0x000192C0 File Offset: 0x000174C0
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

	// Token: 0x0600044B RID: 1099 RVA: 0x000193E0 File Offset: 0x000175E0
	private static void SetupHandleStat(Delegate handle)
	{
		if (!Stat.Enable)
		{
			return;
		}
		MethodInfo method = handle.Method;
		if (EventConstant.HandleStatMap.ContainsKey(method))
		{
			return;
		}
		string name = method.Name;
		Stat value = null;
		string.IsNullOrEmpty(name);
		EventConstant.HandleStatMap[method] = value;
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00019424 File Offset: 0x00017624
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

	// Token: 0x0600044D RID: 1101 RVA: 0x0001949C File Offset: 0x0001769C
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

	// Token: 0x0600044E RID: 1102 RVA: 0x0001958C File Offset: 0x0001778C
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

	// Token: 0x0600044F RID: 1103 RVA: 0x000195F5 File Offset: 0x000177F5
	public bool IsEmitting(TName name)
	{
		return this.EmittingMaskSet.Contains(name);
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00019603 File Offset: 0x00017803
	private void SetEmitting(TName name, bool isEmitting)
	{
		if (isEmitting)
		{
			this.EmittingMaskSet.Add(name);
			return;
		}
		this.EmittingMaskSet.Remove(name);
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000451 RID: 1105 RVA: 0x00019623 File Offset: 0x00017823
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

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000452 RID: 1106 RVA: 0x0001963E File Offset: 0x0001783E
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

	// Token: 0x06000453 RID: 1107 RVA: 0x0001965C File Offset: 0x0001785C
	private bool CheckInPendingRemoveHandles(TName name, Delegate handle)
	{
		List<Delegate> valueOrDefault = this.PendingRemoveHandles.GetValueOrDefault(name);
		return valueOrDefault != null && valueOrDefault.Contains(handle);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00019684 File Offset: 0x00017884
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

	// Token: 0x06000455 RID: 1109 RVA: 0x000196B0 File Offset: 0x000178B0
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

	// Token: 0x06000456 RID: 1110 RVA: 0x000196E8 File Offset: 0x000178E8
	public bool AddWithCondition<[Nullable(2)] T1>(TName name, Delegate handle, T1 conditionParam)
	{
		return this.AddWithConditionInternal<T1>(name, handle, EHandleType.Forever, conditionParam);
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x000196F4 File Offset: 0x000178F4
	public bool OnceWithCondition<[Nullable(2)] T1>(TName name, Delegate handle, T1 conditionParam)
	{
		return this.AddWithConditionInternal<T1>(name, handle, EHandleType.Once, conditionParam);
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00019700 File Offset: 0x00017900
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

	// Token: 0x06000459 RID: 1113 RVA: 0x000197D4 File Offset: 0x000179D4
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

	// Token: 0x0600045A RID: 1114 RVA: 0x00019828 File Offset: 0x00017A28
	public bool RemoveWithCondition<[Nullable(2)] T1>(TName name, Delegate handle, T1 param)
	{
		ConditionListener<T1> conditionListener = this.GetConditionListener<T1>(name);
		return conditionListener != null && (conditionListener.Has(param, handle) || conditionListener.IsInPendingAdd(param, handle)) && this.RemoveWithConditionInternal<T1>(name, handle, param);
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00019860 File Offset: 0x00017A60
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

	// Token: 0x0600045C RID: 1116 RVA: 0x00019908 File Offset: 0x00017B08
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

	// Token: 0x040003E9 RID: 1001
	private readonly Dictionary<TName, List<EventHandleEntry>> Handles = new Dictionary<TName, List<EventHandleEntry>>();

	// Token: 0x040003EA RID: 1002
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<TName, List<EventHandleEntry>> PendingAddHandlesInternal;

	// Token: 0x040003EB RID: 1003
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<TName, List<Delegate>> PendingRemoveHandlesInternal;

	// Token: 0x040003EC RID: 1004
	private readonly HashSet<TName> EmittingMaskSet = new HashSet<TName>();

	// Token: 0x040003ED RID: 1005
	private readonly Dictionary<TName, Dictionary<object, object>> HoldKeyHandles = new Dictionary<TName, Dictionary<object, object>>();

	// Token: 0x040003EE RID: 1006
	private readonly Dictionary<TName, IConditionListener> ConditionHandles = new Dictionary<TName, IConditionListener>();
}
