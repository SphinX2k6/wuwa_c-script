using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Common.Event
{
	// Token: 0x02006417 RID: 25623
	[NullableContext(1)]
	[Nullable(0)]
	public class EventSystem : Singleton
	{
		// Token: 0x0603E2C0 RID: 254656 RVA: 0x0120FC6E File Offset: 0x0120DE6E
		public bool Has(EEventName name, Delegate handle)
		{
			return this.EventInstance.Has(name, handle);
		}

		// Token: 0x0603E2C1 RID: 254657 RVA: 0x0120FC7D File Offset: 0x0120DE7D
		public bool Has(EEventName name, Action handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C2 RID: 254658 RVA: 0x0120FC87 File Offset: 0x0120DE87
		public bool Has<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C3 RID: 254659 RVA: 0x0120FC91 File Offset: 0x0120DE91
		[NullableContext(2)]
		public bool Has<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C4 RID: 254660 RVA: 0x0120FC9B File Offset: 0x0120DE9B
		[NullableContext(2)]
		public bool Has<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C5 RID: 254661 RVA: 0x0120FCA5 File Offset: 0x0120DEA5
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C6 RID: 254662 RVA: 0x0120FCAF File Offset: 0x0120DEAF
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C7 RID: 254663 RVA: 0x0120FCB9 File Offset: 0x0120DEB9
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4, T5, T6>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C8 RID: 254664 RVA: 0x0120FCC3 File Offset: 0x0120DEC3
		[NullableContext(2)]
		public bool Has<T1, T2, T3, T4, T5, T6, T7>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.Has(name, handle);
		}

		// Token: 0x0603E2C9 RID: 254665 RVA: 0x0120FCCD File Offset: 0x0120DECD
		public bool HasAny(EEventName name)
		{
			return this.EventInstance.HasAny(name);
		}

		// Token: 0x0603E2CA RID: 254666 RVA: 0x0120FCDC File Offset: 0x0120DEDC
		public bool HasAnyWithTarget(object target, EEventName name)
		{
			Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
			return targetEvent != null && targetEvent.HasAny(name);
		}

		// Token: 0x0603E2CB RID: 254667 RVA: 0x0120FCFD File Offset: 0x0120DEFD
		public void RemoveTargetEvents(object target)
		{
			this.TargetEvents.Remove(target);
		}

		// Token: 0x0603E2CC RID: 254668 RVA: 0x0120FD0C File Offset: 0x0120DF0C
		public bool HasWithTarget(object target, EEventName name, Delegate handle)
		{
			Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
			return targetEvent != null && targetEvent.Has(name, handle);
		}

		// Token: 0x0603E2CD RID: 254669 RVA: 0x0120FD2E File Offset: 0x0120DF2E
		public bool HasWithTarget(object target, EEventName name, Action handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2CE RID: 254670 RVA: 0x0120FD39 File Offset: 0x0120DF39
		public bool HasWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2CF RID: 254671 RVA: 0x0120FD44 File Offset: 0x0120DF44
		public bool HasWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2D0 RID: 254672 RVA: 0x0120FD4F File Offset: 0x0120DF4F
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2D1 RID: 254673 RVA: 0x0120FD5A File Offset: 0x0120DF5A
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2D2 RID: 254674 RVA: 0x0120FD65 File Offset: 0x0120DF65
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2D3 RID: 254675 RVA: 0x0120FD70 File Offset: 0x0120DF70
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4, T5, T6>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2D4 RID: 254676 RVA: 0x0120FD7B File Offset: 0x0120DF7B
		[NullableContext(2)]
		public bool HasWithTarget<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.HasWithTarget(target, name, handle);
		}

		// Token: 0x0603E2D5 RID: 254677 RVA: 0x0120FD86 File Offset: 0x0120DF86
		public bool Add(EEventName name, Delegate handle)
		{
			return this.EventInstance.Add(name, handle);
		}

		// Token: 0x0603E2D6 RID: 254678 RVA: 0x0120FD95 File Offset: 0x0120DF95
		public bool Add(EEventName name, GenericEventHandler handle)
		{
			return this.EventInstance.Add(name, handle);
		}

		// Token: 0x0603E2D7 RID: 254679 RVA: 0x0120FDA4 File Offset: 0x0120DFA4
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

		// Token: 0x0603E2D8 RID: 254680 RVA: 0x0120FE1E File Offset: 0x0120E01E
		public bool AddWithTarget(object target, EEventName name, Delegate handle)
		{
			return this.GetOrCreateTargetEvent(target).Add(name, handle);
		}

		// Token: 0x0603E2D9 RID: 254681 RVA: 0x0120FE2E File Offset: 0x0120E02E
		public bool Once(EEventName name, Delegate handle)
		{
			return this.EventInstance.Once(name, handle);
		}

		// Token: 0x0603E2DA RID: 254682 RVA: 0x0120FE3D File Offset: 0x0120E03D
		public bool Once(EEventName name, Action handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x0603E2DB RID: 254683 RVA: 0x0120FE47 File Offset: 0x0120E047
		public bool Once<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x0603E2DC RID: 254684 RVA: 0x0120FE51 File Offset: 0x0120E051
		[NullableContext(2)]
		public bool Once<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x0603E2DD RID: 254685 RVA: 0x0120FE5B File Offset: 0x0120E05B
		[NullableContext(2)]
		public bool Once<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x0603E2DE RID: 254686 RVA: 0x0120FE65 File Offset: 0x0120E065
		[NullableContext(2)]
		public bool Once<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x0603E2DF RID: 254687 RVA: 0x0120FE6F File Offset: 0x0120E06F
		[NullableContext(2)]
		public bool Once<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.Once(name, handle);
		}

		// Token: 0x0603E2E0 RID: 254688 RVA: 0x0120FE79 File Offset: 0x0120E079
		public bool OnceWithTarget(object target, EEventName name, Delegate handle)
		{
			return this.GetOrCreateTargetEvent(target).Once(name, handle);
		}

		// Token: 0x0603E2E1 RID: 254689 RVA: 0x0120FE89 File Offset: 0x0120E089
		public bool OnceWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x0603E2E2 RID: 254690 RVA: 0x0120FE94 File Offset: 0x0120E094
		public bool OnceWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x0603E2E3 RID: 254691 RVA: 0x0120FE9F File Offset: 0x0120E09F
		[NullableContext(2)]
		public bool OnceWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x0603E2E4 RID: 254692 RVA: 0x0120FEAA File Offset: 0x0120E0AA
		[NullableContext(2)]
		public bool OnceWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x0603E2E5 RID: 254693 RVA: 0x0120FEB5 File Offset: 0x0120E0B5
		[NullableContext(2)]
		public bool OnceWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.OnceWithTarget(target, name, handle);
		}

		// Token: 0x0603E2E6 RID: 254694 RVA: 0x0120FEC0 File Offset: 0x0120E0C0
		public bool Remove(EEventName name, Delegate handle)
		{
			return this.EventInstance.Remove(name, handle);
		}

		// Token: 0x0603E2E7 RID: 254695 RVA: 0x0120FECF File Offset: 0x0120E0CF
		public bool Remove(EEventName name, GenericEventHandler handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2E8 RID: 254696 RVA: 0x0120FED9 File Offset: 0x0120E0D9
		public bool Remove(EEventName name, Action handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2E9 RID: 254697 RVA: 0x0120FEE3 File Offset: 0x0120E0E3
		public bool Remove<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2EA RID: 254698 RVA: 0x0120FEED File Offset: 0x0120E0ED
		[NullableContext(2)]
		public bool Remove<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2EB RID: 254699 RVA: 0x0120FEF7 File Offset: 0x0120E0F7
		[NullableContext(2)]
		public bool Remove<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2EC RID: 254700 RVA: 0x0120FF01 File Offset: 0x0120E101
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2ED RID: 254701 RVA: 0x0120FF0B File Offset: 0x0120E10B
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2EE RID: 254702 RVA: 0x0120FF15 File Offset: 0x0120E115
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4, T5, T6>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2EF RID: 254703 RVA: 0x0120FF1F File Offset: 0x0120E11F
		[NullableContext(2)]
		public bool Remove<T1, T2, T3, T4, T5, T6, T7>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.Remove(name, handle);
		}

		// Token: 0x0603E2F0 RID: 254704 RVA: 0x0120FF2C File Offset: 0x0120E12C
		public bool RemoveWithTarget(object target, EEventName name, Delegate handle)
		{
			Event<EEventName, Delegate> targetEvent = this.GetTargetEvent(target);
			return targetEvent != null && targetEvent.Remove(name, handle);
		}

		// Token: 0x0603E2F1 RID: 254705 RVA: 0x0120FF4E File Offset: 0x0120E14E
		public bool RemoveWithTarget(object target, EEventName name, Action handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F2 RID: 254706 RVA: 0x0120FF59 File Offset: 0x0120E159
		public bool RemoveWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F3 RID: 254707 RVA: 0x0120FF64 File Offset: 0x0120E164
		public bool RemoveWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F4 RID: 254708 RVA: 0x0120FF6F File Offset: 0x0120E16F
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F5 RID: 254709 RVA: 0x0120FF7A File Offset: 0x0120E17A
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F6 RID: 254710 RVA: 0x0120FF85 File Offset: 0x0120E185
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F7 RID: 254711 RVA: 0x0120FF90 File Offset: 0x0120E190
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4, T5, T6>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F8 RID: 254712 RVA: 0x0120FF9B File Offset: 0x0120E19B
		[NullableContext(2)]
		public bool RemoveWithTarget<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.RemoveWithTarget(target, name, handle);
		}

		// Token: 0x0603E2F9 RID: 254713 RVA: 0x0120FFA8 File Offset: 0x0120E1A8
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

		// Token: 0x0603E2FA RID: 254714 RVA: 0x0121005D File Offset: 0x0120E25D
		public bool RemoveWithTargetUseKey(object key, object target, EEventName name, Delegate handle)
		{
			return this.RemoveWithTargetUseKeyInternal(key, target, name, handle);
		}

		// Token: 0x0603E2FB RID: 254715 RVA: 0x0121006A File Offset: 0x0120E26A
		public bool RemoveWithTargetUseKey<[Nullable(2)] T1>(object key, object target, EEventName name, Action<T1> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x0603E2FC RID: 254716 RVA: 0x01210077 File Offset: 0x0120E277
		public bool RemoveWithTargetUseKey<[Nullable(2)] T1, [Nullable(2)] T2>(object key, object target, EEventName name, Action<T1, T2> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x0603E2FD RID: 254717 RVA: 0x01210084 File Offset: 0x0120E284
		public bool RemoveWithTargetUseKey<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object key, object target, EEventName name, Action<T1, T2, T3> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x0603E2FE RID: 254718 RVA: 0x01210091 File Offset: 0x0120E291
		[NullableContext(2)]
		public bool RemoveWithTargetUseKey<T1, T2, T3, T4>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x0603E2FF RID: 254719 RVA: 0x0121009E File Offset: 0x0120E29E
		[NullableContext(2)]
		public bool RemoveWithTargetUseKey<T1, T2, T3, T4, T5>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.RemoveWithTargetUseKey(key, target, name, handle);
		}

		// Token: 0x0603E300 RID: 254720 RVA: 0x012100AC File Offset: 0x0120E2AC
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

		// Token: 0x0603E301 RID: 254721 RVA: 0x0121012C File Offset: 0x0120E32C
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

		// Token: 0x0603E302 RID: 254722 RVA: 0x01210190 File Offset: 0x0120E390
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

		// Token: 0x0603E303 RID: 254723 RVA: 0x012101F4 File Offset: 0x0120E3F4
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

		// Token: 0x0603E304 RID: 254724 RVA: 0x01210258 File Offset: 0x0120E458
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

		// Token: 0x0603E305 RID: 254725 RVA: 0x012102C0 File Offset: 0x0120E4C0
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

		// Token: 0x0603E306 RID: 254726 RVA: 0x01210328 File Offset: 0x0120E528
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

		// Token: 0x0603E307 RID: 254727 RVA: 0x01210394 File Offset: 0x0120E594
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

		// Token: 0x0603E308 RID: 254728 RVA: 0x01210400 File Offset: 0x0120E600
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

		// Token: 0x0603E309 RID: 254729 RVA: 0x01210470 File Offset: 0x0120E670
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

		// Token: 0x0603E30A RID: 254730 RVA: 0x012104DC File Offset: 0x0120E6DC
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

		// Token: 0x0603E30B RID: 254731 RVA: 0x01210548 File Offset: 0x0120E748
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

		// Token: 0x0603E30C RID: 254732 RVA: 0x012105B8 File Offset: 0x0120E7B8
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

		// Token: 0x0603E30D RID: 254733 RVA: 0x01210628 File Offset: 0x0120E828
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

		// Token: 0x0603E30E RID: 254734 RVA: 0x0121069C File Offset: 0x0120E89C
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

		// Token: 0x0603E30F RID: 254735 RVA: 0x01210710 File Offset: 0x0120E910
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

		// Token: 0x0603E310 RID: 254736 RVA: 0x01210788 File Offset: 0x0120E988
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

		// Token: 0x0603E311 RID: 254737 RVA: 0x01210800 File Offset: 0x0120EA00
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

		// Token: 0x0603E312 RID: 254738 RVA: 0x01210840 File Offset: 0x0120EA40
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

		// Token: 0x0603E313 RID: 254739 RVA: 0x01210880 File Offset: 0x0120EA80
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

		// Token: 0x0603E314 RID: 254740 RVA: 0x012108C0 File Offset: 0x0120EAC0
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

		// Token: 0x0603E315 RID: 254741 RVA: 0x01210904 File Offset: 0x0120EB04
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

		// Token: 0x0603E316 RID: 254742 RVA: 0x01210948 File Offset: 0x0120EB48
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

		// Token: 0x0603E317 RID: 254743 RVA: 0x01210990 File Offset: 0x0120EB90
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

		// Token: 0x0603E318 RID: 254744 RVA: 0x012109D8 File Offset: 0x0120EBD8
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

		// Token: 0x0603E319 RID: 254745 RVA: 0x01210A04 File Offset: 0x0120EC04
		public bool Add(EEventName name, Action handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E31A RID: 254746 RVA: 0x01210A0E File Offset: 0x0120EC0E
		public bool Add<[Nullable(2)] T1>(EEventName name, Action<T1> handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E31B RID: 254747 RVA: 0x01210A18 File Offset: 0x0120EC18
		[NullableContext(2)]
		public bool Add<T1, T2>(EEventName name, [Nullable(1)] Action<T1, T2> handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E31C RID: 254748 RVA: 0x01210A22 File Offset: 0x0120EC22
		[NullableContext(2)]
		public bool Add<T1, T2, T3>(EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E31D RID: 254749 RVA: 0x01210A2C File Offset: 0x0120EC2C
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E31E RID: 254750 RVA: 0x01210A36 File Offset: 0x0120EC36
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4, T5>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E31F RID: 254751 RVA: 0x01210A40 File Offset: 0x0120EC40
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4, T5, T6>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E320 RID: 254752 RVA: 0x01210A4A File Offset: 0x0120EC4A
		[NullableContext(2)]
		public bool Add<T1, T2, T3, T4, T5, T6, T7>(EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.Add(name, handle);
		}

		// Token: 0x0603E321 RID: 254753 RVA: 0x01210A54 File Offset: 0x0120EC54
		public bool AddWithTarget(object target, EEventName name, Action handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E322 RID: 254754 RVA: 0x01210A5F File Offset: 0x0120EC5F
		public bool AddWithTarget<[Nullable(2)] T1>(object target, EEventName name, Action<T1> handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E323 RID: 254755 RVA: 0x01210A6A File Offset: 0x0120EC6A
		public bool AddWithTarget<[Nullable(2)] T1, [Nullable(2)] T2>(object target, EEventName name, Action<T1, T2> handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E324 RID: 254756 RVA: 0x01210A75 File Offset: 0x0120EC75
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3> handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E325 RID: 254757 RVA: 0x01210A80 File Offset: 0x0120EC80
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E326 RID: 254758 RVA: 0x01210A8B File Offset: 0x0120EC8B
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4, T5>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E327 RID: 254759 RVA: 0x01210A96 File Offset: 0x0120EC96
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4, T5, T6>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E328 RID: 254760 RVA: 0x01210AA1 File Offset: 0x0120ECA1
		[NullableContext(2)]
		public bool AddWithTarget<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.AddWithTarget(target, name, handle);
		}

		// Token: 0x0603E329 RID: 254761 RVA: 0x01210AAC File Offset: 0x0120ECAC
		public bool AddWithTargetUseHoldKey(object key, object target, EEventName name, Action handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E32A RID: 254762 RVA: 0x01210AB9 File Offset: 0x0120ECB9
		public bool AddWithTargetUseHoldKey<[Nullable(2)] T1>(object key, object target, EEventName name, Action<T1> handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E32B RID: 254763 RVA: 0x01210AC6 File Offset: 0x0120ECC6
		public bool AddWithTargetUseHoldKey<[Nullable(2)] T1, [Nullable(2)] T2>(object key, object target, EEventName name, Action<T1, T2> handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E32C RID: 254764 RVA: 0x01210AD3 File Offset: 0x0120ECD3
		public bool AddWithTargetUseHoldKey<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(object key, object target, EEventName name, Action<T1, T2, T3> handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E32D RID: 254765 RVA: 0x01210AE0 File Offset: 0x0120ECE0
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4> handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E32E RID: 254766 RVA: 0x01210AED File Offset: 0x0120ECED
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4, T5>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5> handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E32F RID: 254767 RVA: 0x01210AFA File Offset: 0x0120ECFA
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4, T5, T6>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6> handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E330 RID: 254768 RVA: 0x01210B07 File Offset: 0x0120ED07
		[NullableContext(2)]
		public bool AddWithTargetUseHoldKey<T1, T2, T3, T4, T5, T6, T7>([Nullable(1)] object key, [Nullable(1)] object target, EEventName name, [Nullable(1)] Action<T1, T2, T3, T4, T5, T6, T7> handle)
		{
			return this.AddWithTargetUseHoldKey(key, target, name, handle);
		}

		// Token: 0x0603E331 RID: 254769 RVA: 0x01210B14 File Offset: 0x0120ED14
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

		// Token: 0x0603E332 RID: 254770 RVA: 0x01210B68 File Offset: 0x0120ED68
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

		// Token: 0x0603E333 RID: 254771 RVA: 0x01210BBC File Offset: 0x0120EDBC
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

		// Token: 0x0603E334 RID: 254772 RVA: 0x01210C10 File Offset: 0x0120EE10
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

		// Token: 0x17007664 RID: 30308
		// (get) Token: 0x0603E335 RID: 254773 RVA: 0x01210C61 File Offset: 0x0120EE61
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

		// Token: 0x0603E336 RID: 254774 RVA: 0x01210C84 File Offset: 0x0120EE84
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E337 RID: 254775 RVA: 0x01210C86 File Offset: 0x0120EE86
		public static void ResetStaticDefaultValue()
		{
			EventSystem instance = EventSystem._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EventSystem._instance = null;
		}

		// Token: 0x0603E338 RID: 254776 RVA: 0x01210C9F File Offset: 0x0120EE9F
		static EventSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EventSystem.CreateStaticDefaultValue), new Action(EventSystem.ResetStaticDefaultValue));
		}

		// Token: 0x040211A9 RID: 135593
		private readonly Event<EEventName, Delegate> EventInstance = new Event<EEventName, Delegate>();

		// Token: 0x040211AA RID: 135594
		private readonly WeakMap<object, Event<EEventName, Delegate>> TargetEvents = new WeakMap<object, Event<EEventName, Delegate>>();

		// Token: 0x040211AB RID: 135595
		private readonly WeakMap<object, List<IEventSystemCacheKeyNode>> TargetToEventsKeyCache = new WeakMap<object, List<IEventSystemCacheKeyNode>>();

		// Token: 0x040211AC RID: 135596
		private readonly Stat RemoveStat = Stat.Create("EventSystem.RemoveWithTargetUseKey", "", "");

		// Token: 0x040211AD RID: 135597
		[Nullable(2)]
		private static EventSystem _instance;
	}
}
