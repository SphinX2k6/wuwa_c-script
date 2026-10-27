using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Common.Event
{
	// Token: 0x02007298 RID: 29336
	[NullableContext(1)]
	[Nullable(0)]
	public class EventSystem : Singleton
	{
		// Token: 0x06047EEA RID: 294634 RVA: 0x0126E2A8 File Offset: 0x0126C4A8
		public bool Has(EEventName name, Delegate handle)
		{
			return this.EventInstance.Has(name, handle);
		}

		// Token: 0x06047EEB RID: 294635 RVA: 0x0126E2B7 File Offset: 0x0126C4B7
		public bool Has(EEventName name, Action handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EEC RID: 294636 RVA: 0x0126E2C1 File Offset: 0x0126C4C1
		public bool Has<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EED RID: 294637 RVA: 0x0126E2CB File Offset: 0x0126C4CB
		[NullableContext(2)]
		public bool Has<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EEE RID: 294638 RVA: 0x0126E2D5 File Offset: 0x0126C4D5
		[NullableContext(2)]
		public bool Has<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EEF RID: 294639 RVA: 0x0126E2DF File Offset: 0x0126C4DF
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EF0 RID: 294640 RVA: 0x0126E2E9 File Offset: 0x0126C4E9
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EF1 RID: 294641 RVA: 0x0126E2F3 File Offset: 0x0126C4F3
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4, T5, T6>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EF2 RID: 294642 RVA: 0x0126E2FD File Offset: 0x0126C4FD
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4, T5, T6, T7>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x06047EF3 RID: 294643 RVA: 0x0126E307 File Offset: 0x0126C507
		public bool HasAny(EEventName name)
		{
			return this.EventInstance.HasAny(name);
		}

		// Token: 0x06047EF4 RID: 294644 RVA: 0x0126E318 File Offset: 0x0126C518
		public bool HasAnyWithTarget(object target, EEventName name)
		{
			Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
			return targetEvent != null && targetEvent.HasAny(name);
		}

		// Token: 0x06047EF5 RID: 294645 RVA: 0x0126E339 File Offset: 0x0126C539
		public void RemoveTargetEvents(object target)
		{
			this.TargetEvents.Remove(target);
		}

		// Token: 0x06047EF6 RID: 294646 RVA: 0x0126E348 File Offset: 0x0126C548
		public bool HasWithTarget(object target, EEventName name, Delegate handle)
		{
			Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
			return targetEvent != null && targetEvent.Has(name, handle);
		}

		// Token: 0x06047EF7 RID: 294647 RVA: 0x0126E36A File Offset: 0x0126C56A
		public bool HasWithTarget(object target, EEventName name, Action handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EF8 RID: 294648 RVA: 0x0126E375 File Offset: 0x0126C575
		public bool HasWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EF9 RID: 294649 RVA: 0x0126E380 File Offset: 0x0126C580
		public bool HasWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EFA RID: 294650 RVA: 0x0126E38B File Offset: 0x0126C58B
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EFB RID: 294651 RVA: 0x0126E396 File Offset: 0x0126C596
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EFC RID: 294652 RVA: 0x0126E3A1 File Offset: 0x0126C5A1
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EFD RID: 294653 RVA: 0x0126E3AC File Offset: 0x0126C5AC
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4, T5, T6>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EFE RID: 294654 RVA: 0x0126E3B7 File Offset: 0x0126C5B7
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x06047EFF RID: 294655 RVA: 0x0126E3C2 File Offset: 0x0126C5C2
		public bool Add(EEventName name, Delegate handle)
		{
			return this.EventInstance.Add(name, handle);
		}

		// Token: 0x06047F00 RID: 294656 RVA: 0x0126E3D1 File Offset: 0x0126C5D1
		public bool Add(EEventName name, GenericEventHandler handle)
		{
			return this.EventInstance.Add(name, handle);
		}

		// Token: 0x06047F01 RID: 294657 RVA: 0x0126E3E0 File Offset: 0x0126C5E0
		public bool AddWithTargetUseHoldKey(object key, object target, EEventName name, Delegate handle)
		{
			Event<EEventName, Delegate> orCreateTargetEvent = this.GetOrCreateTargetEvent(target);
			if (!orCreateTargetEvent.Add(name, handle))
			{
				return false;
			}
			List<IEventSystemCacheKeyNode> list;
			this.TargetToEventsKeyCache.TryGetValue(key, out list);
			if (list == null)
			{
				list = new List<IEventSystemCacheKeyNode>();
				this.TargetToEventsKeyCache.Set(key, list);
			}
			orCreateTargetEvent.AddHoldKeyHandle<EEventName>(name, key, handle);
			list.Add(new EventSystemCacheKeyNode
			{
				Key = key,
				Handle = handle,
				Target = target,
				EventName = name
			});
			return true;
		}

		// Token: 0x06047F02 RID: 294658 RVA: 0x0126E45A File Offset: 0x0126C65A
		public bool AddWithTarget(object target, EEventName name, Delegate handle)
		{
			return this.GetOrCreateTargetEvent(target).Add(name, handle);
		}

		// Token: 0x06047F03 RID: 294659 RVA: 0x0126E46A File Offset: 0x0126C66A
		public bool Once(EEventName name, Delegate handle)
		{
			return this.EventInstance.Once(name, handle);
		}

		// Token: 0x06047F04 RID: 294660 RVA: 0x0126E479 File Offset: 0x0126C679
		public bool Once(EEventName name, Action handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x06047F05 RID: 294661 RVA: 0x0126E483 File Offset: 0x0126C683
		public bool Once<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x06047F06 RID: 294662 RVA: 0x0126E48D File Offset: 0x0126C68D
		[NullableContext(2)]
		public bool Once<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x06047F07 RID: 294663 RVA: 0x0126E497 File Offset: 0x0126C697
		[NullableContext(2)]
		public bool Once<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x06047F08 RID: 294664 RVA: 0x0126E4A1 File Offset: 0x0126C6A1
		[NullableContext(2)]
		public bool Once<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x06047F09 RID: 294665 RVA: 0x0126E4AB File Offset: 0x0126C6AB
		[NullableContext(2)]
		public bool Once<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x06047F0A RID: 294666 RVA: 0x0126E4B5 File Offset: 0x0126C6B5
		public bool OnceWithTarget(object target, EEventName name, Delegate handle)
		{
			return this.GetOrCreateTargetEvent(target).Once(name, handle);
		}

		// Token: 0x06047F0B RID: 294667 RVA: 0x0126E4C5 File Offset: 0x0126C6C5
		public bool OnceWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x06047F0C RID: 294668 RVA: 0x0126E4D0 File Offset: 0x0126C6D0
		public bool OnceWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x06047F0D RID: 294669 RVA: 0x0126E4DB File Offset: 0x0126C6DB
		[NullableContext(2)]
		public bool OnceWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x06047F0E RID: 294670 RVA: 0x0126E4E6 File Offset: 0x0126C6E6
		[NullableContext(2)]
		public bool OnceWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x06047F0F RID: 294671 RVA: 0x0126E4F1 File Offset: 0x0126C6F1
		[NullableContext(2)]
		public bool OnceWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x06047F10 RID: 294672 RVA: 0x0126E4FC File Offset: 0x0126C6FC
		public bool Remove(EEventName name, Delegate handle)
		{
			bool result = this.EventInstance.Remove(name, handle);
			if (!this.EventInstance.HasAny(name) && this.BridgeActionNames.Contains(name))
			{
				this.BridgeActionNames.Remove(name);
				EventSystemBridge.UnregisterEvent((uint)name);
			}
			return result;
		}

		// Token: 0x06047F11 RID: 294673 RVA: 0x0126E53A File Offset: 0x0126C73A
		public bool Remove(EEventName name, GenericEventHandler handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F12 RID: 294674 RVA: 0x0126E544 File Offset: 0x0126C744
		public bool Remove(EEventName name, Action handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F13 RID: 294675 RVA: 0x0126E54E File Offset: 0x0126C74E
		public bool Remove<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F14 RID: 294676 RVA: 0x0126E558 File Offset: 0x0126C758
		[NullableContext(2)]
		public bool Remove<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F15 RID: 294677 RVA: 0x0126E562 File Offset: 0x0126C762
		[NullableContext(2)]
		public bool Remove<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F16 RID: 294678 RVA: 0x0126E56C File Offset: 0x0126C76C
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F17 RID: 294679 RVA: 0x0126E576 File Offset: 0x0126C776
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F18 RID: 294680 RVA: 0x0126E580 File Offset: 0x0126C780
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4, T5, T6>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F19 RID: 294681 RVA: 0x0126E58A File Offset: 0x0126C78A
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4, T5, T6, T7>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x06047F1A RID: 294682 RVA: 0x0126E594 File Offset: 0x0126C794
		public bool RemoveWithTarget(object target, EEventName name, Delegate handle)
		{
			Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
			if (targetEvent != null)
			{
				if (Info.Instance.IsBuildDevelopmentOrDebug)
				{
					object holdKeyByHandle = targetEvent.GetHoldKeyByHandle(name, handle);
					if (holdKeyByHandle != null)
					{
						EventSystem.Instance.RemoveWithTargetUseKeyInternal(holdKeyByHandle, target, name, handle);
						targetEvent.RemoveHoldKeyHandle(name, handle);
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Event;
						ELogAuthor author = ELogAuthor.HJJ;
						string message = "事件系统调用错误,请使用[RemoveWithTargetUseKey]";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("target", target);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return true;
					}
				}
				return targetEvent.Remove(name, handle);
			}
			return false;
		}

		// Token: 0x06047F1B RID: 294683 RVA: 0x0126E60D File Offset: 0x0126C80D
		public bool RemoveWithTarget(object target, EEventName name, Action handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F1C RID: 294684 RVA: 0x0126E618 File Offset: 0x0126C818
		public bool RemoveWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F1D RID: 294685 RVA: 0x0126E623 File Offset: 0x0126C823
		public bool RemoveWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F1E RID: 294686 RVA: 0x0126E62E File Offset: 0x0126C82E
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F1F RID: 294687 RVA: 0x0126E639 File Offset: 0x0126C839
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F20 RID: 294688 RVA: 0x0126E644 File Offset: 0x0126C844
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F21 RID: 294689 RVA: 0x0126E64F File Offset: 0x0126C84F
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4, T5, T6>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F22 RID: 294690 RVA: 0x0126E65A File Offset: 0x0126C85A
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x06047F23 RID: 294691 RVA: 0x0126E668 File Offset: 0x0126C868
		private bool RemoveWithTargetUseKeyInternal(object key, object target, EEventName name, Delegate handle)
		{
			List<IEventSystemCacheKeyNode> list;
			this.TargetToEventsKeyCache.TryGetValue(key, out list);
			if (list == null)
			{
				return false;
			}
			for (int i = 0; i < list.Count; i++)
			{
				IEventSystemCacheKeyNode eventSystemCacheKeyNode = list[i];
				if (eventSystemCacheKeyNode.Handle == handle && eventSystemCacheKeyNode.EventName.Equals(name) && eventSystemCacheKeyNode.Target == target)
				{
					list.RemoveAt(i);
					Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
					if (targetEvent != null)
					{
						targetEvent.Remove(name, handle);
						targetEvent.RemoveHoldKeyHandle(name, handle);
					}
					if (list.Count == 0)
					{
						this.TargetToEventsKeyCache.Remove(key);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06047F24 RID: 294692 RVA: 0x0126E71D File Offset: 0x0126C91D
		public bool RemoveWithTargetUseKey(object key, object target, EEventName name, Delegate handle)
		{
			return this.RemoveWithTargetUseKeyInternal(key, target, name, handle);
		}

		// Token: 0x06047F25 RID: 294693 RVA: 0x0126E72A File Offset: 0x0126C92A
		public bool RemoveWithTargetUseKey<[Nullable(2)] T1>(object key, object target, EEventName name, Action<T1> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x06047F26 RID: 294694 RVA: 0x0126E737 File Offset: 0x0126C937
		public bool RemoveWithTargetUseKey<[Nullable(2)] T1, [Nullable(2)] T2>(object key, object target, EEventName name, Action<T1, T2> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x06047F27 RID: 294695 RVA: 0x0126E744 File Offset: 0x0126C944
		public bool RemoveWithTargetUseKey<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object key, object target, EEventName name, Action<T1, T2, T3> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x06047F28 RID: 294696 RVA: 0x0126E751 File Offset: 0x0126C951
		[NullableContext(2)]
		public bool RemoveWithTargetUseKey<T1, T2, T3, T4>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x06047F29 RID: 294697 RVA: 0x0126E75E File Offset: 0x0126C95E
		[NullableContext(2)]
		public bool RemoveWithTargetUseKey<T1, T2, T3, T4, T5>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x06047F2A RID: 294698 RVA: 0x0126E76C File Offset: 0x0126C96C
		public bool RemoveAllTargetUseKey(object key)
		{
			List<IEventSystemCacheKeyNode> list;
			this.TargetToEventsKeyCache.TryGetValue(key, out list);
			if (list == null)
			{
				return false;
			}
			for (int i = 0; i < list.Count; i++)
			{
				IEventSystemCacheKeyNode eventSystemCacheKeyNode = list[i];
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(eventSystemCacheKeyNode.Target);
				if (targetEvent != null)
				{
					targetEvent.Remove(eventSystemCacheKeyNode.EventName, eventSystemCacheKeyNode.Handle);
					targetEvent.RemoveHoldKeyHandle(eventSystemCacheKeyNode.EventName, eventSystemCacheKeyNode.Handle);
				}
			}
			this.TargetToEventsKeyCache.Remove(key);
			return true;
		}

		// Token: 0x06047F2B RID: 294699 RVA: 0x0126E7EC File Offset: 0x0126C9EC
		public bool Emit(EEventName name)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit(name);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F2C RID: 294700 RVA: 0x0126E850 File Offset: 0x0126CA50
		public bool Emit<[Nullable(2)] T1>(EEventName name, T1 p1)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit<T1>(name, p1);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit<T>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F2D RID: 294701 RVA: 0x0126E8B4 File Offset: 0x0126CAB4
		public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2>(EEventName name, T1 p1, T2 p2)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit<T1, T2>(name, p1, p2);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit<T1,T2>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F2E RID: 294702 RVA: 0x0126E918 File Offset: 0x0126CB18
		public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(EEventName name, T1 p1, T2 p2, T3 p3)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit<T1, T2, T3>(name, p1, p2, p3);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit<T1,T2,T3>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F2F RID: 294703 RVA: 0x0126E980 File Offset: 0x0126CB80
		public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(EEventName name, T1 p1, T2 p2, T3 p3, T4 p4)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit<T1, T2, T3, T4>(name, p1, p2, p3, p4);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit<T1,T2,T3,T4>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F30 RID: 294704 RVA: 0x0126E9E8 File Offset: 0x0126CBE8
		public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(EEventName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit<T1, T2, T3, T4, T5>(name, p1, p2, p3, p4, p5);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit<T1,T2,T3,T4,T5>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F31 RID: 294705 RVA: 0x0126EA54 File Offset: 0x0126CC54
		public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(EEventName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit<T1, T2, T3, T4, T5, T6>(name, p1, p2, p3, p4, p5, p6);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit<T1,T2,T3,T4,T5,T6>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F32 RID: 294706 RVA: 0x0126EAC0 File Offset: 0x0126CCC0
		public bool Emit<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(EEventName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
		{
			bool result;
			try
			{
				result = this.EventInstance.Emit<T1, T2, T3, T4, T5, T6, T7>(name, p1, p2, p3, p4, p5, p6, p7);
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::Emit<T1,T2,T3,T4,T5,T6,T7>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F33 RID: 294707 RVA: 0x0126EB30 File Offset: 0x0126CD30
		public bool EmitWithTarget(object target, EEventName name)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit(name));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F34 RID: 294708 RVA: 0x0126EB9C File Offset: 0x0126CD9C
		public bool EmitWithTarget<[Nullable(2)] T1>(object target, EEventName name, T1 p1)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit<T1>(name, p1));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget<T1>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F35 RID: 294709 RVA: 0x0126EC08 File Offset: 0x0126CE08
		public bool EmitWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, T1 p1, T2 p2)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit<T1, T2>(name, p1, p2));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget<T1,T2>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F36 RID: 294710 RVA: 0x0126EC78 File Offset: 0x0126CE78
		public bool EmitWithTarget<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object target, EEventName name, T1 p1, T2 p2, T3 p3)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit<T1, T2, T3>(name, p1, p2, p3));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget<T1,T2,T3>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F37 RID: 294711 RVA: 0x0126ECE8 File Offset: 0x0126CEE8
		public bool EmitWithTarget<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(object target, EEventName name, T1 p1, T2 p2, T3 p3, T4 p4)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit<T1, T2, T3, T4>(name, p1, p2, p3, p4));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget<T1,T2,T3,T4>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F38 RID: 294712 RVA: 0x0126ED5C File Offset: 0x0126CF5C
		public bool EmitWithTarget<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(object target, EEventName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit<T1, T2, T3, T4, T5>(name, p1, p2, p3, p4, p5));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget<T1,T2,T3,T4,T5>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F39 RID: 294713 RVA: 0x0126EDD0 File Offset: 0x0126CFD0
		public bool EmitWithTarget<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(object target, EEventName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit<T1, T2, T3, T4, T5, T6>(name, p1, p2, p3, p4, p5, p6));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget<T1,T2,T3,T4,T5,T6>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F3A RID: 294714 RVA: 0x0126EE48 File Offset: 0x0126D048
		public bool EmitWithTarget<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(object target, EEventName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
		{
			bool result;
			try
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				result = (targetEvent != null && targetEvent.Emit<T1, T2, T3, T4, T5, T6, T7>(name, p1, p2, p3, p4, p5, p6, p7));
			}
			catch (Exception error) when (1)
			{
				Log.Instance.ErrorWithStack(ELogModule.Event, ELogAuthor.WLJ, "[EventSystem::EmitWithTarget<T1,T2,T3,T4,T5,T6,T7>]throw exception", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = false;
			}
			return result;
		}

		// Token: 0x06047F3B RID: 294715 RVA: 0x0126EEC0 File Offset: 0x0126D0C0
		public void EmitWithTargets([Nullable(new byte[]
		{
			2,
			1
		})] object[] targetList, EEventName name)
		{
			if (targetList == null || targetList.Length == 0)
			{
				return;
			}
			foreach (object target in targetList)
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				if (targetEvent != null)
				{
					targetEvent.Emit(name);
				}
			}
		}

		// Token: 0x06047F3C RID: 294716 RVA: 0x0126EF00 File Offset: 0x0126D100
		public void EmitWithTargets<[Nullable(2)] T1>([Nullable(new byte[]
		{
			2,
			1
		})] object[] targetList, EEventName name, T1 p1)
		{
			if (targetList == null || targetList.Length == 0)
			{
				return;
			}
			foreach (object target in targetList)
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				if (targetEvent != null)
				{
					targetEvent.Emit<T1>(name, p1);
				}
			}
		}

		// Token: 0x06047F3D RID: 294717 RVA: 0x0126EF40 File Offset: 0x0126D140
		public void EmitWithTargets<[Nullable(2)] T1, [Nullable(2)] T2>([Nullable(new byte[]
		{
			2,
			1
		})] object[] targetList, EEventName name, T1 p1, T2 p2)
		{
			if (targetList == null || targetList.Length == 0)
			{
				return;
			}
			foreach (object target in targetList)
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				if (targetEvent != null)
				{
					targetEvent.Emit<T1, T2>(name, p1, p2);
				}
			}
		}

		// Token: 0x06047F3E RID: 294718 RVA: 0x0126EF80 File Offset: 0x0126D180
		public void EmitWithTargets<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>([Nullable(new byte[]
		{
			2,
			1
		})] object[] targetList, EEventName name, T1 p1, T2 p2, T3 p3)
		{
			if (targetList == null || targetList.Length == 0)
			{
				return;
			}
			foreach (object target in targetList)
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				if (targetEvent != null)
				{
					targetEvent.Emit<T1, T2, T3>(name, p1, p2, p3);
				}
			}
		}

		// Token: 0x06047F3F RID: 294719 RVA: 0x0126EFC4 File Offset: 0x0126D1C4
		public void EmitWithTargets<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>([Nullable(new byte[]
		{
			2,
			1
		})] object[] targetList, EEventName name, T1 p1, T2 p2, T3 p3, T4 p4)
		{
			if (targetList == null || targetList.Length == 0)
			{
				return;
			}
			foreach (object target in targetList)
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				if (targetEvent != null)
				{
					targetEvent.Emit<T1, T2, T3, T4>(name, p1, p2, p3, p4);
				}
			}
		}

		// Token: 0x06047F40 RID: 294720 RVA: 0x0126F008 File Offset: 0x0126D208
		public void EmitWithTargets<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>([Nullable(new byte[]
		{
			2,
			1
		})] object[] targetList, EEventName name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
		{
			if (targetList == null || targetList.Length == 0)
			{
				return;
			}
			foreach (object target in targetList)
			{
				Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
				if (targetEvent != null)
				{
					targetEvent.Emit<T1, T2, T3, T4, T5>(name, p1, p2, p3, p4, p5);
				}
			}
		}

		// Token: 0x06047F41 RID: 294721 RVA: 0x0126F050 File Offset: 0x0126D250
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private Event<EEventName, Delegate> GetTargetEvent(object target)
		{
			if (target == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "事件系统目标不存在，请检查目标";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("target", target);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			Event<EEventName, Delegate> result;
			this.TargetEvents.TryGetValue(target, out result);
			return result;
		}

		// Token: 0x06047F42 RID: 294722 RVA: 0x0126F098 File Offset: 0x0126D298
		private Event<EEventName, Delegate> GetOrCreateTargetEvent(object target)
		{
			Event<EEventName, Delegate> @event = this.GetTargetEvent(target);
			if (@event == null)
			{
				@event = new Event<EEventName, Delegate>();
				this.TargetEvents.Set(target, @event);
			}
			return @event;
		}

		// Token: 0x06047F43 RID: 294723 RVA: 0x0126F0C4 File Offset: 0x0126D2C4
		public bool Add(EEventName name, Action handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint> eventAction;
				if ((eventAction = EventSystem.<>O.<0>__EmitFromBridge) == null)
				{
					eventAction = (EventSystem.<>O.<0>__EmitFromBridge = new Action<uint>(EventSystem.EmitFromBridge));
				}
				EventSystemBridge.RegisterEvent((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F44 RID: 294724 RVA: 0x0126F100 File Offset: 0x0126D300
		public bool Add<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint, T1> eventAction;
				if ((eventAction = EventSystem.<Add>O__96_0<T1>.<0>__EmitFromBridge) == null)
				{
					Action<uint, T1> action = EventSystem.<Add>O__96_0<T1>.<0>__EmitFromBridge = new Action<uint, T1>(EventSystem.EmitFromBridge<T1>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEvent<T1>((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F45 RID: 294725 RVA: 0x0126F148 File Offset: 0x0126D348
		[NullableContext(2)]
		public bool Add<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint, T1, T2> eventAction;
				if ((eventAction = EventSystem.<Add>O__97_0<T1, T2>.<0>__EmitFromBridge) == null)
				{
					Action<uint, T1, T2> action = EventSystem.<Add>O__97_0<T1, T2>.<0>__EmitFromBridge = new Action<uint, T1, T2>(EventSystem.EmitFromBridge<T1, T2>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEvent<T1, T2>((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F46 RID: 294726 RVA: 0x0126F190 File Offset: 0x0126D390
		[NullableContext(2)]
		public bool Add<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint, T1, T2, T3> eventAction;
				if ((eventAction = EventSystem.<Add>O__98_0<T1, T2, T3>.<0>__EmitFromBridge) == null)
				{
					Action<uint, T1, T2, T3> action = EventSystem.<Add>O__98_0<T1, T2, T3>.<0>__EmitFromBridge = new Action<uint, T1, T2, T3>(EventSystem.EmitFromBridge<T1, T2, T3>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEvent<T1, T2, T3>((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F47 RID: 294727 RVA: 0x0126F1D8 File Offset: 0x0126D3D8
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint, T1, T2, T3, T4> eventAction;
				if ((eventAction = EventSystem.<Add>O__99_0<T1, T2, T3, T4>.<0>__EmitFromBridge) == null)
				{
					Action<uint, T1, T2, T3, T4> action = EventSystem.<Add>O__99_0<T1, T2, T3, T4>.<0>__EmitFromBridge = new Action<uint, T1, T2, T3, T4>(EventSystem.EmitFromBridge<T1, T2, T3, T4>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEvent<T1, T2, T3, T4>((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F48 RID: 294728 RVA: 0x0126F220 File Offset: 0x0126D420
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint, T1, T2, T3, T4, T5> eventAction;
				if ((eventAction = EventSystem.<Add>O__100_0<T1, T2, T3, T4, T5>.<0>__EmitFromBridge) == null)
				{
					Action<uint, T1, T2, T3, T4, T5> action = EventSystem.<Add>O__100_0<T1, T2, T3, T4, T5>.<0>__EmitFromBridge = new Action<uint, T1, T2, T3, T4, T5>(EventSystem.EmitFromBridge<T1, T2, T3, T4, T5>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEvent<T1, T2, T3, T4, T5>((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F49 RID: 294729 RVA: 0x0126F268 File Offset: 0x0126D468
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4, T5, T6>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint, T1, T2, T3, T4, T5, T6> eventAction;
				if ((eventAction = EventSystem.<Add>O__101_0<T1, T2, T3, T4, T5, T6>.<0>__EmitFromBridge) == null)
				{
					Action<uint, T1, T2, T3, T4, T5, T6> action = EventSystem.<Add>O__101_0<T1, T2, T3, T4, T5, T6>.<0>__EmitFromBridge = new Action<uint, T1, T2, T3, T4, T5, T6>(EventSystem.EmitFromBridge<T1, T2, T3, T4, T5, T6>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEvent<T1, T2, T3, T4, T5, T6>((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F4A RID: 294730 RVA: 0x0126F2B0 File Offset: 0x0126D4B0
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4, T5, T6, T7>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			if (this.BridgeActionNames.Add(name))
			{
				Action<uint, T1, T2, T3, T4, T5, T6, T7> eventAction;
				if ((eventAction = EventSystem.<Add>O__102_0<T1, T2, T3, T4, T5, T6, T7>.<0>__EmitFromBridge) == null)
				{
					Action<uint, T1, T2, T3, T4, T5, T6, T7> action = EventSystem.<Add>O__102_0<T1, T2, T3, T4, T5, T6, T7>.<0>__EmitFromBridge = new Action<uint, T1, T2, T3, T4, T5, T6, T7>(EventSystem.EmitFromBridge<T1, T2, T3, T4, T5, T6, T7>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEvent<T1, T2, T3, T4, T5, T6, T7>((uint)name, eventAction);
			}
			return this.Add(name, handle);
		}

		// Token: 0x06047F4B RID: 294731 RVA: 0x0126F2F8 File Offset: 0x0126D4F8
		public bool AddWithTarget(object target, EEventName name, Action handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int> eventAction;
				if ((eventAction = EventSystem.<>O.<1>__EmitWithTargetFromBridge) == null)
				{
					eventAction = (EventSystem.<>O.<1>__EmitWithTargetFromBridge = new Action<uint, int>(EventSystem.EmitWithTargetFromBridge));
				}
				EventSystemBridge.RegisterEventWithTarget((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F4C RID: 294732 RVA: 0x0126F348 File Offset: 0x0126D548
		public bool AddWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1> eventAction;
				if ((eventAction = EventSystem.<AddWithTarget>O__104_0<T1>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1> action = EventSystem.<AddWithTarget>O__104_0<T1>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1>(EventSystem.EmitWithTargetFromBridge<T1>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1>((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F4D RID: 294733 RVA: 0x0126F398 File Offset: 0x0126D598
		public bool AddWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2> eventAction;
				if ((eventAction = EventSystem.<AddWithTarget>O__105_0<T1, T2>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2> action = EventSystem.<AddWithTarget>O__105_0<T1, T2>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2>(EventSystem.EmitWithTargetFromBridge<T1, T2>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2>((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F4E RID: 294734 RVA: 0x0126F3E8 File Offset: 0x0126D5E8
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3> eventAction;
				if ((eventAction = EventSystem.<AddWithTarget>O__106_0<T1, T2, T3>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3> action = EventSystem.<AddWithTarget>O__106_0<T1, T2, T3>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3>((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F4F RID: 294735 RVA: 0x0126F438 File Offset: 0x0126D638
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4> eventAction;
				if ((eventAction = EventSystem.<AddWithTarget>O__107_0<T1, T2, T3, T4>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4> action = EventSystem.<AddWithTarget>O__107_0<T1, T2, T3, T4>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4>((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F50 RID: 294736 RVA: 0x0126F488 File Offset: 0x0126D688
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4, T5> eventAction;
				if ((eventAction = EventSystem.<AddWithTarget>O__108_0<T1, T2, T3, T4, T5>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4, T5> action = EventSystem.<AddWithTarget>O__108_0<T1, T2, T3, T4, T5>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4, T5>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4, T5>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4, T5>((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F51 RID: 294737 RVA: 0x0126F4D8 File Offset: 0x0126D6D8
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4, T5, T6>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4, T5, T6> eventAction;
				if ((eventAction = EventSystem.<AddWithTarget>O__109_0<T1, T2, T3, T4, T5, T6>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4, T5, T6> action = EventSystem.<AddWithTarget>O__109_0<T1, T2, T3, T4, T5, T6>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4, T5, T6>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4, T5, T6>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4, T5, T6>((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F52 RID: 294738 RVA: 0x0126F528 File Offset: 0x0126D728
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4, T5, T6> eventAction;
				if ((eventAction = EventSystem.<AddWithTarget>O__110_0<T1, T2, T3, T4, T5, T6, T7>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4, T5, T6> action = EventSystem.<AddWithTarget>O__110_0<T1, T2, T3, T4, T5, T6, T7>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4, T5, T6>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4, T5, T6>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4, T5, T6>((uint)name, eventAction);
			}
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x06047F53 RID: 294739 RVA: 0x0126F578 File Offset: 0x0126D778
		public bool AddWithTargetUseHoldKey(object key, object target, EEventName name, Action handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int> eventAction;
				if ((eventAction = EventSystem.<>O.<1>__EmitWithTargetFromBridge) == null)
				{
					eventAction = (EventSystem.<>O.<1>__EmitWithTargetFromBridge = new Action<uint, int>(EventSystem.EmitWithTargetFromBridge));
				}
				EventSystemBridge.RegisterEventWithTarget((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F54 RID: 294740 RVA: 0x0126F5C8 File Offset: 0x0126D7C8
		public bool AddWithTargetUseHoldKey<[Nullable(2)] T1>(object key, object target, EEventName name, Action<T1> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1> eventAction;
				if ((eventAction = EventSystem.<AddWithTargetUseHoldKey>O__112_0<T1>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1> action = EventSystem.<AddWithTargetUseHoldKey>O__112_0<T1>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1>(EventSystem.EmitWithTargetFromBridge<T1>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1>((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F55 RID: 294741 RVA: 0x0126F61C File Offset: 0x0126D81C
		public bool AddWithTargetUseHoldKey<[Nullable(2)] T1, [Nullable(2)] T2>(object key, object target, EEventName name, Action<T1, T2> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2> eventAction;
				if ((eventAction = EventSystem.<AddWithTargetUseHoldKey>O__113_0<T1, T2>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2> action = EventSystem.<AddWithTargetUseHoldKey>O__113_0<T1, T2>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2>(EventSystem.EmitWithTargetFromBridge<T1, T2>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2>((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F56 RID: 294742 RVA: 0x0126F670 File Offset: 0x0126D870
		public bool AddWithTargetUseHoldKey<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object key, object target, EEventName name, Action<T1, T2, T3> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3> eventAction;
				if ((eventAction = EventSystem.<AddWithTargetUseHoldKey>O__114_0<T1, T2, T3>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3> action = EventSystem.<AddWithTargetUseHoldKey>O__114_0<T1, T2, T3>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3>((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F57 RID: 294743 RVA: 0x0126F6C4 File Offset: 0x0126D8C4
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4> eventAction;
				if ((eventAction = EventSystem.<AddWithTargetUseHoldKey>O__115_0<T1, T2, T3, T4>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4> action = EventSystem.<AddWithTargetUseHoldKey>O__115_0<T1, T2, T3, T4>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4>((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F58 RID: 294744 RVA: 0x0126F718 File Offset: 0x0126D918
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4, T5>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4, T5> eventAction;
				if ((eventAction = EventSystem.<AddWithTargetUseHoldKey>O__116_0<T1, T2, T3, T4, T5>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4, T5> action = EventSystem.<AddWithTargetUseHoldKey>O__116_0<T1, T2, T3, T4, T5>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4, T5>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4, T5>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4, T5>((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F59 RID: 294745 RVA: 0x0126F76C File Offset: 0x0126D96C
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4, T5, T6>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4, T5, T6> eventAction;
				if ((eventAction = EventSystem.<AddWithTargetUseHoldKey>O__117_0<T1, T2, T3, T4, T5, T6>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4, T5, T6> action = EventSystem.<AddWithTargetUseHoldKey>O__117_0<T1, T2, T3, T4, T5, T6>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4, T5, T6>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4, T5, T6>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4, T5, T6>((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F5A RID: 294746 RVA: 0x0126F7C0 File Offset: 0x0126D9C0
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			if (target is Entity && this.BridgeActionWithTargetNames.Add(name))
			{
				Action<uint, int, T1, T2, T3, T4, T5, T6, T7> eventAction;
				if ((eventAction = EventSystem.<AddWithTargetUseHoldKey>O__118_0<T1, T2, T3, T4, T5, T6, T7>.<0>__EmitWithTargetFromBridge) == null)
				{
					Action<uint, int, T1, T2, T3, T4, T5, T6, T7> action = EventSystem.<AddWithTargetUseHoldKey>O__118_0<T1, T2, T3, T4, T5, T6, T7>.<0>__EmitWithTargetFromBridge = new Action<uint, int, T1, T2, T3, T4, T5, T6, T7>(EventSystem.EmitWithTargetFromBridge<T1, T2, T3, T4, T5, T6, T7>);
					eventAction = action;
				}
				EventSystemBridge.RegisterEventWithTarget<T1, T2, T3, T4, T5, T6, T7>((uint)name, eventAction);
			}
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x06047F5B RID: 294747 RVA: 0x0126F811 File Offset: 0x0126DA11
		private static void EmitFromBridge(uint name)
		{
			EventSystem.Instance.EventInstance.Emit((EEventName)name);
		}

		// Token: 0x06047F5C RID: 294748 RVA: 0x0126F824 File Offset: 0x0126DA24
		private static void EmitFromBridge<[Nullable(2)] T1>(uint name, T1 p1)
		{
			EventSystem.Instance.EventInstance.Emit<T1>((EEventName)name, p1);
		}

		// Token: 0x06047F5D RID: 294749 RVA: 0x0126F838 File Offset: 0x0126DA38
		private static void EmitFromBridge<[Nullable(2)] T1, [Nullable(2)] T2>(uint name, T1 p1, T2 p2)
		{
			EventSystem.Instance.EventInstance.Emit<T1, T2>((EEventName)name, p1, p2);
		}

		// Token: 0x06047F5E RID: 294750 RVA: 0x0126F84D File Offset: 0x0126DA4D
		private static void EmitFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(uint name, T1 p1, T2 p2, T3 p3)
		{
			EventSystem.Instance.EventInstance.Emit<T1, T2, T3>((EEventName)name, p1, p2, p3);
		}

		// Token: 0x06047F5F RID: 294751 RVA: 0x0126F863 File Offset: 0x0126DA63
		private static void EmitFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(uint name, T1 p1, T2 p2, T3 p3, T4 p4)
		{
			EventSystem.Instance.EventInstance.Emit<T1, T2, T3, T4>((EEventName)name, p1, p2, p3, p4);
		}

		// Token: 0x06047F60 RID: 294752 RVA: 0x0126F87B File Offset: 0x0126DA7B
		private static void EmitFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(uint name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
		{
			EventSystem.Instance.EventInstance.Emit<T1, T2, T3, T4, T5>((EEventName)name, p1, p2, p3, p4, p5);
		}

		// Token: 0x06047F61 RID: 294753 RVA: 0x0126F895 File Offset: 0x0126DA95
		private static void EmitFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(uint name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
		{
			EventSystem.Instance.EventInstance.Emit<T1, T2, T3, T4, T5, T6>((EEventName)name, p1, p2, p3, p4, p5, p6);
		}

		// Token: 0x06047F62 RID: 294754 RVA: 0x0126F8B4 File Offset: 0x0126DAB4
		private static void EmitFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(uint name, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
		{
			EventSystem.Instance.EventInstance.Emit<T1, T2, T3, T4, T5, T6, T7>((EEventName)name, p1, p2, p3, p4, p5, p6, p7);
		}

		// Token: 0x06047F63 RID: 294755 RVA: 0x0126F8E0 File Offset: 0x0126DAE0
		private static void EmitWithTargetFromBridge(uint name, int targetId)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit((EEventName)name);
			}
		}

		// Token: 0x06047F64 RID: 294756 RVA: 0x0126F914 File Offset: 0x0126DB14
		private static void EmitWithTargetFromBridge<[Nullable(2)] T1>(uint name, int targetId, T1 p1)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit<T1>((EEventName)name, p1);
			}
		}

		// Token: 0x06047F65 RID: 294757 RVA: 0x0126F948 File Offset: 0x0126DB48
		private static void EmitWithTargetFromBridge<[Nullable(2)] T1, [Nullable(2)] T2>(uint name, int targetId, T1 p1, T2 p2)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit<T1, T2>((EEventName)name, p1, p2);
			}
		}

		// Token: 0x06047F66 RID: 294758 RVA: 0x0126F980 File Offset: 0x0126DB80
		private static void EmitWithTargetFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(uint name, int targetId, T1 p1, T2 p2, T3 p3)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit<T1, T2, T3>((EEventName)name, p1, p2, p3);
			}
		}

		// Token: 0x06047F67 RID: 294759 RVA: 0x0126F9B8 File Offset: 0x0126DBB8
		private static void EmitWithTargetFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(uint name, int targetId, T1 p1, T2 p2, T3 p3, T4 p4)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit<T1, T2, T3, T4>((EEventName)name, p1, p2, p3, p4);
			}
		}

		// Token: 0x06047F68 RID: 294760 RVA: 0x0126F9F4 File Offset: 0x0126DBF4
		private static void EmitWithTargetFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(uint name, int targetId, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit<T1, T2, T3, T4, T5>((EEventName)name, p1, p2, p3, p4, p5);
			}
		}

		// Token: 0x06047F69 RID: 294761 RVA: 0x0126FA30 File Offset: 0x0126DC30
		private static void EmitWithTargetFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(uint name, int targetId, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit<T1, T2, T3, T4, T5, T6>((EEventName)name, p1, p2, p3, p4, p5, p6);
			}
		}

		// Token: 0x06047F6A RID: 294762 RVA: 0x0126FA70 File Offset: 0x0126DC70
		private static void EmitWithTargetFromBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(uint name, int targetId, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(targetId);
			if (entity != null)
			{
				Event<EEventName, Delegate> targetEvent = EventSystem.Instance.GetTargetEvent(entity);
				if (targetEvent == null)
				{
					return;
				}
				targetEvent.Emit<T1, T2, T3, T4, T5, T6, T7>((EEventName)name, p1, p2, p3, p4, p5, p6, p7);
			}
		}

		// Token: 0x06047F6B RID: 294763 RVA: 0x0126FAB0 File Offset: 0x0126DCB0
		public bool AddWithCondition<[Nullable(2)] T1>(EEventName name, Action<T1> handle, T1 conditionParam)
		{
			if (conditionParam == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "添加条件监听事件时，条件参数为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return this.EventInstance.AddWithCondition<T1>(name, handle, conditionParam);
		}

		// Token: 0x06047F6C RID: 294764 RVA: 0x0126FB04 File Offset: 0x0126DD04
		public bool OnceWithCondition<[Nullable(2)] T1>(EEventName name, Action<T1> handle, T1 conditionParam)
		{
			if (conditionParam == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "添加一次性条件监听事件时，条件参数为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return this.EventInstance.OnceWithCondition<T1>(name, handle, conditionParam);
		}

		// Token: 0x06047F6D RID: 294765 RVA: 0x0126FB58 File Offset: 0x0126DD58
		public bool RemoveWithCondition<[Nullable(2)] T1>(EEventName name, Action<T1> handle, T1 conditionParam)
		{
			if (conditionParam == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "移除条件监听事件时，条件参数为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return this.EventInstance.RemoveWithCondition<T1>(name, handle, conditionParam);
		}

		// Token: 0x06047F6E RID: 294766 RVA: 0x0126FBAC File Offset: 0x0126DDAC
		public bool HasWithCondition<[Nullable(2)] T1>(EEventName name, Action<T1> handle, T1 conditionParam)
		{
			if (conditionParam == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "检查条件监听事件时，条件参数为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return this.EventInstance.HasWithCondition<T1>(name, handle, conditionParam);
		}

		// Token: 0x17009F02 RID: 40706
		// (get) Token: 0x06047F6F RID: 294767 RVA: 0x0126FBFD File Offset: 0x0126DDFD
		public static EventSystem Instance
		{
			get
			{
				if (EventSystem._instance == null)
				{
					EventSystem._instance = new EventSystem();
					EventSystem._instance.OnInit();
				}
				return EventSystem._instance;
			}
		}

		// Token: 0x06047F70 RID: 294768 RVA: 0x0126FC20 File Offset: 0x0126DE20
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047F71 RID: 294769 RVA: 0x0126FC22 File Offset: 0x0126DE22
		public static void ResetStaticDefaultValue()
		{
			EventSystem instance = EventSystem._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EventSystem._instance = null;
		}

		// Token: 0x06047F72 RID: 294770 RVA: 0x0126FC3B File Offset: 0x0126DE3B
		static EventSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EventSystem.CreateStaticDefaultValue), new Action(EventSystem.ResetStaticDefaultValue));
		}

		// Token: 0x04025ED4 RID: 155348
		private readonly HashSet<EEventName> BridgeActionNames = new HashSet<EEventName>();

		// Token: 0x04025ED5 RID: 155349
		private readonly HashSet<EEventName> BridgeActionWithTargetNames = new HashSet<EEventName>();

		// Token: 0x04025ED6 RID: 155350
		private readonly Event<EEventName, Delegate> EventInstance = new Event<EEventName, Delegate>();

		// Token: 0x04025ED7 RID: 155351
		private readonly WeakMap<object, Event<EEventName, Delegate>> TargetEvents = new WeakMap<object, Event<EEventName, Delegate>>();

		// Token: 0x04025ED8 RID: 155352
		private readonly WeakMap<object, List<IEventSystemCacheKeyNode>> TargetToEventsKeyCache = new WeakMap<object, List<IEventSystemCacheKeyNode>>();

		// Token: 0x04025ED9 RID: 155353
		private readonly Stat RemoveStat = Stat.Create("EventSystem.RemoveWithTargetUseKey", "", "");

		// Token: 0x04025EDA RID: 155354
		[Nullable(2)]
		private static EventSystem _instance;

		// Token: 0x0200CFA4 RID: 53156
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E770 RID: 255856
			[Nullable(0)]
			public static Action<uint> <0>__EmitFromBridge;

			// Token: 0x0403E771 RID: 255857
			[Nullable(0)]
			public static Action<uint, int> <1>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFA5 RID: 53157
		[CompilerGenerated]
		private static class <Add>O__100_0<T1, T2, T3, T4, T5>
		{
			// Token: 0x0403E772 RID: 255858
			[Nullable(0)]
			public static Action<uint, T1, T2, T3, T4, T5> <0>__EmitFromBridge;
		}

		// Token: 0x0200CFA6 RID: 53158
		[CompilerGenerated]
		private static class <Add>O__101_0<T1, T2, T3, T4, T5, T6>
		{
			// Token: 0x0403E773 RID: 255859
			[Nullable(0)]
			public static Action<uint, T1, T2, T3, T4, T5, T6> <0>__EmitFromBridge;
		}

		// Token: 0x0200CFA7 RID: 53159
		[CompilerGenerated]
		private static class <Add>O__102_0<T1, T2, T3, T4, T5, T6, T7>
		{
			// Token: 0x0403E774 RID: 255860
			[Nullable(0)]
			public static Action<uint, T1, T2, T3, T4, T5, T6, T7> <0>__EmitFromBridge;
		}

		// Token: 0x0200CFA8 RID: 53160
		[CompilerGenerated]
		private static class <Add>O__96_0<T1>
		{
			// Token: 0x0403E775 RID: 255861
			[Nullable(0)]
			public static Action<uint, T1> <0>__EmitFromBridge;
		}

		// Token: 0x0200CFA9 RID: 53161
		[CompilerGenerated]
		private static class <Add>O__97_0<T1, T2>
		{
			// Token: 0x0403E776 RID: 255862
			[Nullable(0)]
			public static Action<uint, T1, T2> <0>__EmitFromBridge;
		}

		// Token: 0x0200CFAA RID: 53162
		[CompilerGenerated]
		private static class <Add>O__98_0<T1, T2, T3>
		{
			// Token: 0x0403E777 RID: 255863
			[Nullable(0)]
			public static Action<uint, T1, T2, T3> <0>__EmitFromBridge;
		}

		// Token: 0x0200CFAB RID: 53163
		[CompilerGenerated]
		private static class <Add>O__99_0<T1, T2, T3, T4>
		{
			// Token: 0x0403E778 RID: 255864
			[Nullable(0)]
			public static Action<uint, T1, T2, T3, T4> <0>__EmitFromBridge;
		}

		// Token: 0x0200CFAC RID: 53164
		[CompilerGenerated]
		private static class <AddWithTarget>O__104_0<T1>
		{
			// Token: 0x0403E779 RID: 255865
			[Nullable(0)]
			public static Action<uint, int, T1> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFAD RID: 53165
		[CompilerGenerated]
		private static class <AddWithTarget>O__105_0<T1, T2>
		{
			// Token: 0x0403E77A RID: 255866
			[Nullable(0)]
			public static Action<uint, int, T1, T2> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFAE RID: 53166
		[CompilerGenerated]
		private static class <AddWithTarget>O__106_0<T1, T2, T3>
		{
			// Token: 0x0403E77B RID: 255867
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFAF RID: 53167
		[CompilerGenerated]
		private static class <AddWithTarget>O__107_0<T1, T2, T3, T4>
		{
			// Token: 0x0403E77C RID: 255868
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB0 RID: 53168
		[CompilerGenerated]
		private static class <AddWithTarget>O__108_0<T1, T2, T3, T4, T5>
		{
			// Token: 0x0403E77D RID: 255869
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4, T5> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB1 RID: 53169
		[CompilerGenerated]
		private static class <AddWithTarget>O__109_0<T1, T2, T3, T4, T5, T6>
		{
			// Token: 0x0403E77E RID: 255870
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4, T5, T6> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB2 RID: 53170
		[CompilerGenerated]
		private static class <AddWithTarget>O__110_0<T1, T2, T3, T4, T5, T6, T7>
		{
			// Token: 0x0403E77F RID: 255871
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4, T5, T6> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB3 RID: 53171
		[CompilerGenerated]
		private static class <AddWithTargetUseHoldKey>O__112_0<T1>
		{
			// Token: 0x0403E780 RID: 255872
			[Nullable(0)]
			public static Action<uint, int, T1> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB4 RID: 53172
		[CompilerGenerated]
		private static class <AddWithTargetUseHoldKey>O__113_0<T1, T2>
		{
			// Token: 0x0403E781 RID: 255873
			[Nullable(0)]
			public static Action<uint, int, T1, T2> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB5 RID: 53173
		[CompilerGenerated]
		private static class <AddWithTargetUseHoldKey>O__114_0<T1, T2, T3>
		{
			// Token: 0x0403E782 RID: 255874
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB6 RID: 53174
		[CompilerGenerated]
		private static class <AddWithTargetUseHoldKey>O__115_0<T1, T2, T3, T4>
		{
			// Token: 0x0403E783 RID: 255875
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB7 RID: 53175
		[CompilerGenerated]
		private static class <AddWithTargetUseHoldKey>O__116_0<T1, T2, T3, T4, T5>
		{
			// Token: 0x0403E784 RID: 255876
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4, T5> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB8 RID: 53176
		[CompilerGenerated]
		private static class <AddWithTargetUseHoldKey>O__117_0<T1, T2, T3, T4, T5, T6>
		{
			// Token: 0x0403E785 RID: 255877
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4, T5, T6> <0>__EmitWithTargetFromBridge;
		}

		// Token: 0x0200CFB9 RID: 53177
		[CompilerGenerated]
		private static class <AddWithTargetUseHoldKey>O__118_0<T1, T2, T3, T4, T5, T6, T7>
		{
			// Token: 0x0403E786 RID: 255878
			[Nullable(0)]
			public static Action<uint, int, T1, T2, T3, T4, T5, T6, T7> <0>__EmitWithTargetFromBridge;
		}
	}
}
