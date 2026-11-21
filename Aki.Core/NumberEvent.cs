using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200009E RID: 158
[NullableContext(1)]
[Nullable(0)]
public class NumberEvent : IStaticVariableResetter
{
	// Token: 0x060004D1 RID: 1233 RVA: 0x0001AF0F File Offset: 0x0001910F
	static NumberEvent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NumberEvent.CreateStaticDefaultValue), new Action(NumberEvent.ResetStaticDefaultValue));
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0001AF2E File Offset: 0x0001912E
	private static Dictionary<string, Stat> NameStateMap
	{
		get
		{
			return NumberEvent._nameStateMap;
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0001AF35 File Offset: 0x00019135
	private static Dictionary<MethodInfo, Stat> HandleStatMap
	{
		get
		{
			return NumberEvent._handleStatMap;
		}
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x0001AF3C File Offset: 0x0001913C
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

	// Token: 0x060004D5 RID: 1237 RVA: 0x0001AF6C File Offset: 0x0001916C
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

	// Token: 0x060004D6 RID: 1238 RVA: 0x0001AFA0 File Offset: 0x000191A0
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

	// Token: 0x060004D7 RID: 1239 RVA: 0x0001AFC1 File Offset: 0x000191C1
	public void AddHoldKeyHandle(long name, object objectKey, object handle)
	{
		this.AddHoldKeyValueToMapInternal(name, handle, objectKey, this.HoldKeyHandles);
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0001AFD2 File Offset: 0x000191D2
	public void RemoveHoldKeyHandle(long name, object handle)
	{
		this.RemoveHoldKeyValueFromMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0001AFE2 File Offset: 0x000191E2
	[return: Nullable(2)]
	public object GetHoldKeyByHandle(long name, object handle)
	{
		return this.GetHoldKeyValueOfMapInternal(name, handle, this.HoldKeyHandles);
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x0001AFF4 File Offset: 0x000191F4
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

	// Token: 0x060004DB RID: 1243 RVA: 0x0001B050 File Offset: 0x00019250
	public bool HasAny(long name)
	{
		return this.Handles.ContainsKey(name) || this.PendingAddHandles.ContainsKey(name);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x0001B06E File Offset: 0x0001926E
	public bool Add(long name, Delegate handle)
	{
		return this.AddInternal(name, handle, EHandleType.Forever);
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0001B079 File Offset: 0x00019279
	public bool Once(long name, Delegate handle)
	{
		return this.AddInternal(name, handle, EHandleType.Once);
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0001B084 File Offset: 0x00019284
	public bool Remove(long name, Delegate handle)
	{
		return this.IsRegistered(name, handle) && this.RemoveInternal(name, handle);
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0001B09C File Offset: 0x0001929C
	private bool IsRegistered(long name, Delegate handle)
	{
		List<EventHandleEntry> handles;
		List<EventHandleEntry> handles2;
		return (this.Handles.TryGetValue(name, out handles) && handles.ContainsHandle(handle)) || (this.PendingAddHandlesInternal != null && this.PendingAddHandlesInternal.TryGetValue(name, out handles2) && handles2.ContainsHandle(handle));
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x0001B0E8 File Offset: 0x000192E8
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

	// Token: 0x060004E1 RID: 1249 RVA: 0x0001B134 File Offset: 0x00019334
	public bool Emit(long name)
	{
		return this.EmitInternal(name, default(EventArgs));
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x0001B156 File Offset: 0x00019356
	public bool Emit<[Nullable(2)] T1>(long name, T1 p1)
	{
		return this.EmitInternal(name, new EventArgs<T1>(p1));
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0001B16A File Offset: 0x0001936A
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2>(long name, T1 p1, T2 p2)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2>(p1, p2));
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x0001B17F File Offset: 0x0001937F
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(long name, T1 p1, T2 p2, T3 p3)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2, T3>(p1, p2, p3));
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x0001B196 File Offset: 0x00019396
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(long name, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2, T3, T4>(p1, p2, p3, p4));
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x0001B1AF File Offset: 0x000193AF
	public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(long name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		return this.EmitInternal(name, new EventArgs<T1, T2, T3, T4, T5>(p1, p2, p3, p4, p5));
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x0001B1CC File Offset: 0x000193CC
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

	// Token: 0x060004E8 RID: 1256 RVA: 0x0001B458 File Offset: 0x00019658
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

	// Token: 0x060004E9 RID: 1257 RVA: 0x0001B554 File Offset: 0x00019754
	private static void SetupHandleStat(Delegate handle)
	{
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0001B564 File Offset: 0x00019764
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

	// Token: 0x060004EB RID: 1259 RVA: 0x0001B5DC File Offset: 0x000197DC
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

	// Token: 0x060004EC RID: 1260 RVA: 0x0001B6CC File Offset: 0x000198CC
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

	// Token: 0x060004ED RID: 1261 RVA: 0x0001B735 File Offset: 0x00019935
	public bool IsEmitting(long name)
	{
		return this.EmittingMaskSet.Contains(name);
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0001B743 File Offset: 0x00019943
	private void SetEmitting(long name, bool isEmitting)
	{
		if (isEmitting)
		{
			this.EmittingMaskSet.Add(name);
			return;
		}
		this.EmittingMaskSet.Remove(name);
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060004EF RID: 1263 RVA: 0x0001B763 File Offset: 0x00019963
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

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001B77E File Offset: 0x0001997E
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

	// Token: 0x060004F1 RID: 1265 RVA: 0x0001B799 File Offset: 0x00019999
	public static void CreateStaticDefaultValue()
	{
		NumberEvent._nameStateMap = new Dictionary<string, Stat>();
		NumberEvent._handleStatMap = new Dictionary<MethodInfo, Stat>();
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0001B7AF File Offset: 0x000199AF
	public static void ResetStaticDefaultValue()
	{
		NumberEvent._nameStateMap = null;
		NumberEvent._handleStatMap = null;
	}

	// Token: 0x0400041E RID: 1054
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, Stat> _nameStateMap;

	// Token: 0x0400041F RID: 1055
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<MethodInfo, Stat> _handleStatMap;

	// Token: 0x04000420 RID: 1056
	private readonly Dictionary<long, List<EventHandleEntry>> Handles = new Dictionary<long, List<EventHandleEntry>>();

	// Token: 0x04000421 RID: 1057
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, List<EventHandleEntry>> PendingAddHandlesInternal;

	// Token: 0x04000422 RID: 1058
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<long, List<Delegate>> PendingRemoveHandlesInternal;

	// Token: 0x04000423 RID: 1059
	private readonly HashSet<long> EmittingMaskSet = new HashSet<long>();

	// Token: 0x04000424 RID: 1060
	private readonly Dictionary<long, Dictionary<object, object>> HoldKeyHandles = new Dictionary<long, Dictionary<object, object>>();
}
