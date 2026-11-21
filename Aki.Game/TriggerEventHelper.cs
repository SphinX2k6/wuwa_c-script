using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002555 RID: 9557
[NullableContext(1)]
[Nullable(0)]
public class TriggerEventHelper : IStaticVariableResetter
{
	// Token: 0x060179BE RID: 96702 RVA: 0x006F94C6 File Offset: 0x006F76C6
	static TriggerEventHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TriggerEventHelper.CreateStaticDefaultValue), new Action(TriggerEventHelper.ResetStaticDefaultValue));
	}

	// Token: 0x17002482 RID: 9346
	// (get) Token: 0x060179BF RID: 96703 RVA: 0x006F94E5 File Offset: 0x006F76E5
	private static WeakMap<object, Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>>> ForwardListenerMapAccessor
	{
		get
		{
			return TriggerEventHelper.ForwardListenerMap;
		}
	}

	// Token: 0x060179C0 RID: 96704 RVA: 0x006F94EC File Offset: 0x006F76EC
	public static void CreateStaticDefaultValue()
	{
		TriggerEventHelper.ForwardListenerMap = new WeakMap<object, Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>>>();
	}

	// Token: 0x060179C1 RID: 96705 RVA: 0x006F94F8 File Offset: 0x006F76F8
	public static void ResetStaticDefaultValue()
	{
		TriggerEventHelper.ForwardListenerMap = null;
	}

	// Token: 0x060179C2 RID: 96706 RVA: 0x006F9500 File Offset: 0x006F7700
	public static void AddWithTarget(object entity, EEventName eventName, Delegate listener)
	{
		EventSystem.Instance.AddWithTarget(entity, eventName, listener);
		Action<EEventName, IReadOnlyList<object>> action = delegate(EEventName originalEventName, IReadOnlyList<object> args)
		{
			if (originalEventName != eventName)
			{
				return;
			}
			Delegate listener2 = listener;
			object[] array = args as object[];
			listener2.DynamicInvoke((array != null) ? array : new List<object>(args).ToArray());
		};
		Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>> dictionary;
		if (!TriggerEventHelper.ForwardListenerMapAccessor.TryGetValue(entity, out dictionary))
		{
			dictionary = new Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>>();
			TriggerEventHelper.ForwardListenerMapAccessor.Set(entity, dictionary);
		}
		Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>> dictionary2;
		if (!dictionary.TryGetValue(eventName, out dictionary2))
		{
			dictionary2 = new Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>();
			dictionary[eventName] = dictionary2;
		}
		dictionary2[listener] = action;
		EventSystem.Instance.AddWithTarget<EEventName, IReadOnlyList<object>>(entity, EEventName.FollowShooterForwardEvent, action);
	}

	// Token: 0x060179C3 RID: 96707 RVA: 0x006F95A8 File Offset: 0x006F77A8
	public static void RemoveWithTarget(object entity, EEventName eventName, Delegate listener)
	{
		EventSystem.Instance.RemoveWithTarget(entity, eventName, listener);
		Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>> dictionary;
		if (!TriggerEventHelper.ForwardListenerMapAccessor.TryGetValue(entity, out dictionary))
		{
			return;
		}
		Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>> dictionary2;
		if (!dictionary.TryGetValue(eventName, out dictionary2))
		{
			return;
		}
		Action<EEventName, IReadOnlyList<object>> handle;
		if (!dictionary2.TryGetValue(listener, out handle))
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<EEventName, IReadOnlyList<object>>(entity, EEventName.FollowShooterForwardEvent, handle);
		dictionary2.Remove(listener);
		if (dictionary2.Count == 0)
		{
			dictionary.Remove(eventName);
		}
		if (dictionary.Count == 0)
		{
			TriggerEventHelper.ForwardListenerMapAccessor.Remove(entity);
		}
	}

	// Token: 0x060179C4 RID: 96708 RVA: 0x006F9626 File Offset: 0x006F7826
	public static bool HasWithTarget(object entity, EEventName eventName, Delegate listener)
	{
		return EventSystem.Instance.HasWithTarget(entity, eventName, listener);
	}

	// Token: 0x0400C8C4 RID: 51396
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1,
		1,
		1,
		1
	})]
	private static WeakMap<object, Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>>> ForwardListenerMap;
}
