using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200009C RID: 156
[NullableContext(1)]
[Nullable(0)]
public class NumberEvent : IStaticVariableResetter
{
	// Token: 0x06000490 RID: 1168 RVA: 0x0001A7AB File Offset: 0x000189AB
	static NumberEvent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NumberEvent.CreateStaticDefaultValue), new Action(NumberEvent.ResetStaticDefaultValue));
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001A7CA File Offset: 0x000189CA
	private static Dictionary<string, Stat> NameStateMap
	{
		get
		{
			return NumberEvent._nameStateMap;
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000492 RID: 1170 RVA: 0x0001A7D1 File Offset: 0x000189D1
	private static Dictionary<MethodInfo, Stat> HandleStatMap
	{
		get
		{
			return NumberEvent._handleStatMap;
		}
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x0001A7D8 File Offset: 0x000189D8
	private void AddHoldKeyValueToMapInternal(long name, object holdKey, object objectKey, Dictionary<long, Dictionary<object, object>> keyMap)
	{
		Dictionary<object, object> dictionary;
		if (!keyMap.TryGetValue(name, out dictionary))
		{
			dictionary = new Dictionary<object, object>();
			keyMap[name] = dictionary;
		}
		dictionary[objectKey] = holdKey;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0001A808 File Offset: 0x00018A08
	private void RemoveHoldKeyValueFromMapInternal(long name, object holdKey, Dictionary<long, Dictionary<object, object>> keyMap)
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

	// Token: 0x06000495 RID: 1173 RVA: 0x0001A83C File Offset: 0x00018A3C
	[return: Nullable(2)]
	private object GetHoldKeyValueOfMapInternal(long name, object holdKey, Dictionary<long, Dictionary<object, object>> keyMap)
	{
		Dictionary<object, object> dictionary;
		if (!keyMap.TryGetValue(name, out dictionary))
		{
			return null;
		}
		return dictionary.GetValueOrDefault(holdKey);
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x0001A85D File Offset: 0x00018A5D
	public void AddHoldKeyHandle(long name, object objectKey, object handle)
	{
		this.AddHoldKeyValueToMapInternal(name, handle, objectKey, this.HoldKeyHandles);
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x0001A86E File Offset: 0x00018A6E
	public void RemoveHoldKeyHandle(long name, object handle)
	{
		this.RemoveHoldKeyValueFromMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0001A87E File Offset: 0x00018A7E
	[return: Nullable(2)]
	public object GetHoldKeyByHandle(long name, object handle)
	{
		return this.GetHoldKeyValueOfMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0001A890 File Offset: 0x00018A90
	public bool Has(long name, Delegate handle)
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

	// Token: 0x0600049A RID: 1178 RVA: 0x0001A8EC File Offset: 0x00018AEC
	public bool HasAny(long name)
	{
		return this.Handles.ContainsKey(name) || this.PendingAddHandles.ContainsKey(name);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x0001A90A File Offset: 0x00018B0A
	public bool Add(long name, Delegate handle)
	{
		return this.AddInternal(name, handle, EHandleType.Forever);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x0001A915 File Offset: 0x00018B15
	public bool Once(long name, Delegate handle)
	{
		return this.AddInternal(name, handle, EHandleType.Once);
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x0001A920 File Offset: 0x00018B20
	public bool Remove(long name, Delegate handle)
	{
		return this.IsRegistered(name, handle) && this.RemoveInternal(name, handle);
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x0001A938 File Offset: 0x00018B38
	private bool IsRegistered(long name, Delegate handle)
	{
		List<EventHandleEntry> handles;
		List<EventHandleEntry> handles2;
		return (this.Handles.TryGetValue(name, out handles) && handles.ContainsHandle(handle)) || (this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(name, out handles2) && handles2.ContainsHandle(handle));
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x0001A984 File Offset: 0x00018B84
	public bool ClearObject(long name)
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

	// Token: 0x060004A0 RID: 1184 RVA: 0x0001A9D0 File Offset: 0x00018BD0
	public bool Emit(long name)
	{
		return this.EmitInternal(name, default(EventArgs));
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x0001A9F2 File Offset: 0x00018BF2
	public bool Emit<[Nullable(2)] T1>(long name, T1 p1)
	{
		return this.EmitInternal(name, new EventArgs<T1>(p1));
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x0001AA06 File Offset: 0x00018C06
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2>(long name, T1 p1, T2 p2)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2>(p1, p2));
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x0001AA1B File Offset: 0x00018C1B
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(long name, T1 p1, T2 p2, T3 p3)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2, T3>(p1, p2, p3));
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x0001AA32 File Offset: 0x00018C32
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(long name, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2, T3, T4>(p1, p2, p3, p4));
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x0001AA4B File Offset: 0x00018C4B
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(long name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2, T3, T4, T5>(p1, p2, p3, p4, p5));
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x0001AA68 File Offset: 0x00018C68
	private unsafe bool EmitInternal(long name, IEventArgs args)
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
		List<EventHandleEntry> list;
		if (this.Handles.TryGetValue(name, out list))
		{
			Stat value = null;
			if (Stat.Enable)
			{
				string key = name.ToString();
				if (!NumberEvent.NameStateMap.TryGetValue(key, out value))
				{
					NumberEvent.NameStateMap[key] = value;
				}
			}
			List<Delegate> list2 = null;
			foreach (EventHandleEntry eventHandleEntry in list)
			{
				Delegate handle = eventHandleEntry.Handle;
				if (list2 == null)
				{
					this.PendingRemoveHandles.TryGetValue(name, out list2);
				}
				if (list2 == null || !list2.Contains(handle))
				{
					if (eventHandleEntry.HandleType == EHandleType.Once)
					{
						this.RemoveInternal(name, handle);
					}
					Stat stat = null;
					if (Stat.Enable)
					{
						NumberEvent.HandleStatMap.TryGetValue(handle.Method, out stat);
					}
					try
					{
						args.Invoke(name, handle);
					}
					catch (Exception ex) when (1)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.LCC;
						string message2 = "事件处理方法执行异常";
						Exception error = ex;
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("name", name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("error", ex.Message);
						instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
				}
			}
		}
		this.SetEmitting(name, false);
		List<Delegate> list3;
		if (this.PendingRemoveHandles.TryGetValue(name, out list3))
		{
			foreach (Delegate handle2 in list3)
			{
				this.DoRemove(name, handle2);
			}
			list3.Clear();
			this.PendingRemoveHandles.Remove(name);
		}
		List<EventHandleEntry> list4;
		if (this.PendingAddHandles.TryGetValue(name, out list4))
		{
			foreach (EventHandleEntry eventHandleEntry2 in list4)
			{
				this.DoAdd(name, eventHandleEntry2.Handle, eventHandleEntry2.HandleType);
			}
			list4.Clear();
			this.PendingAddHandles.Remove(name);
		}
		return true;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x0001AD3C File Offset: 0x00018F3C
	private bool AddInternal(long name, Delegate handle, EHandleType handleType)
	{
		NumberEvent.SetupHandleStat(handle);
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

	// Token: 0x060004A8 RID: 1192 RVA: 0x0001AE38 File Offset: 0x00019038
	private static void SetupHandleStat(Delegate handle)
	{
		if (!Stat.Enable)
		{
			return;
		}
		MethodInfo method = handle.Method;
		if (NumberEvent.HandleStatMap.ContainsKey(method))
		{
			return;
		}
		string name = method.Name;
		Stat value = null;
		string.IsNullOrEmpty(name);
		NumberEvent.HandleStatMap[method] = value;
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x0001AE7C File Offset: 0x0001907C
	private bool DoAdd(long name, Delegate handle, EHandleType handleType)
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

	// Token: 0x060004AA RID: 1194 RVA: 0x0001AEF4 File Offset: 0x000190F4
	private bool RemoveInternal(long name, Delegate handle)
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

	// Token: 0x060004AB RID: 1195 RVA: 0x0001AFE4 File Offset: 0x000191E4
	private bool DoRemove(long name, Delegate handle)
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

	// Token: 0x060004AC RID: 1196 RVA: 0x0001B04D File Offset: 0x0001924D
	public bool IsEmitting(long name)
	{
		return this.EmittingMaskSet.Contains(name);
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0001B05B File Offset: 0x0001925B
	private void SetEmitting(long name, bool isEmitting)
	{
		if (isEmitting)
		{
			this.EmittingMaskSet.Add(name);
			return;
		}
		this.EmittingMaskSet.Remove(name);
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001B07B File Offset: 0x0001927B
	private Dictionary<long, List<EventHandleEntry>> PendingAddHandles
	{
		get
		{
			if (this.PendingAddHandlesInternal == null)
			{
				this.PendingAddHandlesInternal = new Dictionary<long, List<EventHandleEntry>>();
			}
			return this.PendingAddHandlesInternal;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060004AF RID: 1199 RVA: 0x0001B096 File Offset: 0x00019296
	private Dictionary<long, List<Delegate>> PendingRemoveHandles
	{
		get
		{
			if (this.PendingRemoveHandlesInternal == null)
			{
				this.PendingRemoveHandlesInternal = new Dictionary<long, List<Delegate>>();
			}
			return this.PendingRemoveHandlesInternal;
		}
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x0001B0B1 File Offset: 0x000192B1
	public static void CreateStaticDefaultValue()
	{
		NumberEvent._nameStateMap = new Dictionary<string, Stat>();
		NumberEvent._handleStatMap = new Dictionary<MethodInfo, Stat>();
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x0001B0C7 File Offset: 0x000192C7
	public static void ResetStaticDefaultValue()
	{
		NumberEvent._nameStateMap = null;
		NumberEvent._handleStatMap = null;
	}

	// Token: 0x04000410 RID: 1040
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, Stat> _nameStateMap;

	// Token: 0x04000411 RID: 1041
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<MethodInfo, Stat> _handleStatMap;

	// Token: 0x04000412 RID: 1042
	private readonly Dictionary<long, List<EventHandleEntry>> Handles = new Dictionary<long, List<EventHandleEntry>>();

	// Token: 0x04000413 RID: 1043
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, List<EventHandleEntry>> PendingAddHandlesInternal;

	// Token: 0x04000414 RID: 1044
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<long, List<Delegate>> PendingRemoveHandlesInternal;

	// Token: 0x04000415 RID: 1045
	private readonly HashSet<long> EmittingMaskSet = new HashSet<long>();

	// Token: 0x04000416 RID: 1046
	private readonly Dictionary<long, Dictionary<object, object>> HoldKeyHandles = new Dictionary<long, Dictionary<object, object>>();
}
