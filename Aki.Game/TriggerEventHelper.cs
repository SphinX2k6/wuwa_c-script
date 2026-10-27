using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002FFF RID: 12287
[NullableContext(1)]
[Nullable(0)]
public class TriggerEventHelper : IStaticVariableResetter
{
	// Token: 0x0601A082 RID: 106626 RVA: 0x006D132F File Offset: 0x006CF52F
	static TriggerEventHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TriggerEventHelper.CreateStaticDefaultValue), new Action(TriggerEventHelper.ResetStaticDefaultValue));
	}

	// Token: 0x170023C0 RID: 9152
	// (get) Token: 0x0601A083 RID: 106627 RVA: 0x006D134E File Offset: 0x006CF54E
	private static WeakMap<object, Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>>> ForwardListenerMapAccessor
	{
		get
		{
			return TriggerEventHelper.ForwardListenerMap;
		}
	}

	// Token: 0x0601A084 RID: 106628 RVA: 0x006D1355 File Offset: 0x006CF555
	public static void CreateStaticDefaultValue()
	{
		TriggerEventHelper.ForwardListenerMap = new WeakMap<object, Dictionary<EEventName, Dictionary<Delegate, Action<EEventName, IReadOnlyList<object>>>>>();
	}

	// Token: 0x0601A085 RID: 106629 RVA: 0x006D1361 File Offset: 0x006CF561
	public static void ResetStaticDefaultValue()
	{
		TriggerEventHelper.ForwardListenerMap = null;
	}

	// Token: 0x0601A086 RID: 106630 RVA: 0x006D136C File Offset: 0x006CF56C
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

	// Token: 0x0601A087 RID: 106631 RVA: 0x006D1414 File Offset: 0x006CF614
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

	// Token: 0x0601A088 RID: 106632 RVA: 0x006D1492 File Offset: 0x006CF692
	public static bool HasWithTarget(object entity, EEventName eventName, Delegate listener)
	{
		return EventSystem.Instance.HasWithTarget(entity, eventName, listener);
	}

	// Token: 0x0400C4F8 RID: 50424
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
