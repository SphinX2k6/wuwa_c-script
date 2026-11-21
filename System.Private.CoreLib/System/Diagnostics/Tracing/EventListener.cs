using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F2 RID: 2290
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class EventListener : IDisposable
	{
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06008C89 RID: 35977 RVA: 0x00158C58 File Offset: 0x00156E58
		// (remove) Token: 0x06008C8A RID: 35978 RVA: 0x00158C79 File Offset: 0x00156E79
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event EventHandler<EventSourceCreatedEventArgs> EventSourceCreated
		{
			add
			{
				this.CallBackForExistingEventSources(false, value);
				this._EventSourceCreated = (EventHandler<EventSourceCreatedEventArgs>)Delegate.Combine(this._EventSourceCreated, value);
			}
			remove
			{
				this._EventSourceCreated = (EventHandler<EventSourceCreatedEventArgs>)Delegate.Remove(this._EventSourceCreated, value);
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06008C8B RID: 35979 RVA: 0x00158C94 File Offset: 0x00156E94
		// (remove) Token: 0x06008C8C RID: 35980 RVA: 0x00158CCC File Offset: 0x00156ECC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event EventHandler<EventWrittenEventArgs> EventWritten;

		// Token: 0x06008C8D RID: 35981 RVA: 0x00158D01 File Offset: 0x00156F01
		protected EventListener()
		{
			this.CallBackForExistingEventSources(true, delegate(object obj, EventSourceCreatedEventArgs args)
			{
				args.EventSource.AddListener((EventListener)obj);
			});
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x00158D30 File Offset: 0x00156F30
		public virtual void Dispose()
		{
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				if (EventListener.s_Listeners != null)
				{
					if (this == EventListener.s_Listeners)
					{
						EventListener listenerToRemove = EventListener.s_Listeners;
						EventListener.s_Listeners = this.m_Next;
						EventListener.RemoveReferencesToListenerInEventSources(listenerToRemove);
					}
					else
					{
						EventListener eventListener = EventListener.s_Listeners;
						EventListener next;
						for (;;)
						{
							next = eventListener.m_Next;
							if (next == null)
							{
								break;
							}
							if (next == this)
							{
								goto Block_6;
							}
							eventListener = next;
						}
						goto IL_78;
						Block_6:
						eventListener.m_Next = next.m_Next;
						EventListener.RemoveReferencesToListenerInEventSources(next);
					}
				}
			}
			IL_78:
			EventPipeEventDispatcher.Instance.SendCommand(this, EventCommand.Update, false, EventLevel.LogAlways, EventKeywords.None);
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x00158DD8 File Offset: 0x00156FD8
		public void EnableEvents(EventSource eventSource, EventLevel level)
		{
			this.EnableEvents(eventSource, level, EventKeywords.None);
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00158DE4 File Offset: 0x00156FE4
		public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword)
		{
			this.EnableEvents(eventSource, level, matchAnyKeyword, null);
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x00158DF0 File Offset: 0x00156FF0
		public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword, [Nullable(new byte[]
		{
			2,
			1,
			2
		})] IDictionary<string, string> arguments)
		{
			ArgumentNullException.ThrowIfNull(eventSource, "eventSource");
			eventSource.SendCommand(this, EventProviderType.None, 0, EventCommand.Update, true, level, matchAnyKeyword, arguments);
			if (eventSource.GetType() == typeof(NativeRuntimeEventSource))
			{
				EventPipeEventDispatcher.Instance.SendCommand(this, EventCommand.Update, true, level, matchAnyKeyword);
			}
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x00158E40 File Offset: 0x00157040
		public void DisableEvents(EventSource eventSource)
		{
			ArgumentNullException.ThrowIfNull(eventSource, "eventSource");
			eventSource.SendCommand(this, EventProviderType.None, 0, EventCommand.Update, false, EventLevel.LogAlways, EventKeywords.None, null);
			if (eventSource.GetType() == typeof(NativeRuntimeEventSource))
			{
				EventPipeEventDispatcher.Instance.SendCommand(this, EventCommand.Update, false, EventLevel.LogAlways, EventKeywords.None);
			}
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x00158E8E File Offset: 0x0015708E
		protected internal static int EventSourceIndex(EventSource eventSource)
		{
			return eventSource.m_id;
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x00158E98 File Offset: 0x00157098
		protected internal virtual void OnEventSourceCreated(EventSource eventSource)
		{
			EventHandler<EventSourceCreatedEventArgs> eventSourceCreated = this._EventSourceCreated;
			if (eventSourceCreated != null)
			{
				eventSourceCreated(this, new EventSourceCreatedEventArgs
				{
					EventSource = eventSource
				});
			}
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x00158EC4 File Offset: 0x001570C4
		protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData)
		{
			EventHandler<EventWrittenEventArgs> eventWritten = this.EventWritten;
			if (eventWritten == null)
			{
				return;
			}
			eventWritten(this, eventData);
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x00158ED8 File Offset: 0x001570D8
		internal static void AddEventSource(EventSource newEventSource)
		{
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				int num = -1;
				if (EventListener.s_EventSources.Count % 64 == 63)
				{
					int num2 = EventListener.s_EventSources.Count;
					while (0 < num2)
					{
						num2--;
						WeakReference<EventSource> weakReference = EventListener.s_EventSources[num2];
						EventSource eventSource;
						if (!weakReference.TryGetTarget(out eventSource))
						{
							num = num2;
							weakReference.SetTarget(newEventSource);
							break;
						}
					}
				}
				if (num < 0)
				{
					num = EventListener.s_EventSources.Count;
					EventListener.s_EventSources.Add(new WeakReference<EventSource>(newEventSource));
				}
				newEventSource.m_id = num;
				for (EventListener next = EventListener.s_Listeners; next != null; next = next.m_Next)
				{
					newEventSource.AddListener(next);
				}
			}
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x00158FA4 File Offset: 0x001571A4
		internal static void DisposeOnShutdown()
		{
			List<EventSource> list = new List<EventSource>();
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				using (List<WeakReference<EventSource>>.Enumerator enumerator = EventListener.s_EventSources.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						EventSource item;
						if (enumerator.Current.TryGetTarget(out item))
						{
							list.Add(item);
						}
					}
				}
			}
			foreach (EventSource eventSource in list)
			{
				eventSource.Dispose();
			}
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x00159068 File Offset: 0x00157268
		private static void CallDisableEventsIfNecessary(EventDispatcher eventDispatcher, EventSource eventSource)
		{
			if (eventDispatcher.m_EventEnabled == null)
			{
				return;
			}
			for (int i = 0; i < eventDispatcher.m_EventEnabled.Length; i++)
			{
				if (eventDispatcher.m_EventEnabled[i])
				{
					eventDispatcher.m_Listener.DisableEvents(eventSource);
				}
			}
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x001590A8 File Offset: 0x001572A8
		private static void RemoveReferencesToListenerInEventSources(EventListener listenerToRemove)
		{
			WeakReference<EventSource>[] array = EventListener.s_EventSources.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				EventSource eventSource;
				if (array[i].TryGetTarget(out eventSource))
				{
					for (EventDispatcher eventDispatcher = eventSource.m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
					{
						if (eventDispatcher.m_Listener == listenerToRemove)
						{
							EventListener.CallDisableEventsIfNecessary(eventDispatcher, eventSource);
						}
					}
				}
			}
			using (List<WeakReference<EventSource>>.Enumerator enumerator = EventListener.s_EventSources.GetEnumerator())
			{
				IL_D5:
				while (enumerator.MoveNext())
				{
					EventSource eventSource2;
					if (enumerator.Current.TryGetTarget(out eventSource2) && eventSource2.m_Dispatchers != null)
					{
						if (eventSource2.m_Dispatchers.m_Listener == listenerToRemove)
						{
							eventSource2.m_Dispatchers = eventSource2.m_Dispatchers.m_Next;
						}
						else
						{
							EventDispatcher eventDispatcher2 = eventSource2.m_Dispatchers;
							EventDispatcher next;
							for (;;)
							{
								next = eventDispatcher2.m_Next;
								if (next == null)
								{
									goto IL_D5;
								}
								if (next.m_Listener == listenerToRemove)
								{
									break;
								}
								eventDispatcher2 = next;
							}
							eventDispatcher2.m_Next = next.m_Next;
						}
					}
				}
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06008C9A RID: 35994 RVA: 0x001591B8 File Offset: 0x001573B8
		internal static object EventListenersLock
		{
			get
			{
				if (EventListener.s_EventSources == null)
				{
					Interlocked.CompareExchange<List<WeakReference<EventSource>>>(ref EventListener.s_EventSources, new List<WeakReference<EventSource>>(2), null);
				}
				return EventListener.s_EventSources;
			}
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x001591D8 File Offset: 0x001573D8
		private void CallBackForExistingEventSources(bool addToListenersList, EventHandler<EventSourceCreatedEventArgs> callback)
		{
			EventSourceInitHelper.EnsurePreregisteredEventSourcesExist();
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				if (EventListener.s_CreatingListener)
				{
					throw new InvalidOperationException(SR.EventSource_ListenerCreatedInsideCallback);
				}
				try
				{
					EventListener.s_CreatingListener = true;
					if (addToListenersList)
					{
						this.m_Next = EventListener.s_Listeners;
						EventListener.s_Listeners = this;
					}
					if (callback != null)
					{
						WeakReference<EventSource>[] array = EventListener.s_EventSources.ToArray();
						for (int i = 0; i < array.Length; i++)
						{
							EventSource eventSource;
							if (array[i].TryGetTarget(out eventSource))
							{
								callback(this, new EventSourceCreatedEventArgs
								{
									EventSource = eventSource
								});
							}
						}
					}
				}
				finally
				{
					EventListener.s_CreatingListener = false;
				}
			}
		}

		// Token: 0x04001FF2 RID: 8178
		[CompilerGenerated]
		private EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated;

		// Token: 0x04001FF4 RID: 8180
		internal volatile EventListener m_Next;

		// Token: 0x04001FF5 RID: 8181
		internal static EventListener s_Listeners;

		// Token: 0x04001FF6 RID: 8182
		internal static List<WeakReference<EventSource>> s_EventSources;

		// Token: 0x04001FF7 RID: 8183
		private static bool s_CreatingListener;
	}
}
