using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008D9 RID: 2265
	internal sealed class EventPipeEventDispatcher
	{
		// Token: 0x06008B81 RID: 35713 RVA: 0x00150F63 File Offset: 0x0014F163
		private EventPipeEventDispatcher()
		{
			this.m_RuntimeProviderID = EventPipeInternal.GetProvider("Microsoft-Windows-DotNETRuntime");
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x00150F94 File Offset: 0x0014F194
		internal void SendCommand(EventListener eventListener, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeywords)
		{
			object dispatchControlLock = this.m_dispatchControlLock;
			lock (dispatchControlLock)
			{
				if (command == EventCommand.Update && enable)
				{
					this.m_subscriptions[eventListener] = new EventPipeEventDispatcher.EventListenerSubscription(matchAnyKeywords, level);
				}
				else if (command == EventCommand.Update && !enable)
				{
					this.m_subscriptions.Remove(eventListener);
				}
				this.CommitDispatchConfiguration();
			}
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x00151008 File Offset: 0x0014F208
		private unsafe void CommitDispatchConfiguration()
		{
			this.SetStopDispatchTask();
			if (this.m_subscriptions.Count <= 0)
			{
				return;
			}
			EventKeywords eventKeywords = EventKeywords.None;
			EventLevel eventLevel = EventLevel.Critical;
			foreach (EventPipeEventDispatcher.EventListenerSubscription eventListenerSubscription in this.m_subscriptions.Values)
			{
				eventKeywords |= eventListenerSubscription.MatchAnyKeywords;
				if (eventLevel != EventLevel.LogAlways && (eventLevel < eventListenerSubscription.Level || eventListenerSubscription.Level == EventLevel.LogAlways))
				{
					eventLevel = eventListenerSubscription.Level;
				}
			}
			EventPipeProviderConfiguration[] providers = new EventPipeProviderConfiguration[]
			{
				new EventPipeProviderConfiguration("Microsoft-Windows-DotNETRuntime", (ulong)eventKeywords, (uint)eventLevel, null)
			};
			ulong num = EventPipeInternal.Enable(null, EventPipeSerializationFormat.NetTrace, 10U, providers);
			if (num == 0UL)
			{
				return;
			}
			EventPipeSessionInfo eventPipeSessionInfo;
			EventPipeInternal.GetSessionInfo(num, &eventPipeSessionInfo);
			DateTime syncTimeUtc = DateTime.FromFileTimeUtc(eventPipeSessionInfo.StartTimeAsUTCFileTime);
			long startTimeStamp = eventPipeSessionInfo.StartTimeStamp;
			long timeStampFrequency = eventPipeSessionInfo.TimeStampFrequency;
			Volatile.Write(ref this.m_sessionID, num);
			this.StartDispatchTask(num, syncTimeUtc, startTimeStamp, timeStampFrequency);
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x0015110C File Offset: 0x0014F30C
		private void StartDispatchTask(ulong sessionID, DateTime syncTimeUtc, long syncTimeQPC, long timeQPCFrequency)
		{
			this.m_dispatchTaskCancellationSource = new CancellationTokenSource();
			Task previousDispatchTask = this.m_dispatchTask;
			this.m_dispatchTask = Task.Factory.StartNew(delegate()
			{
				this.DispatchEventsToEventListeners(sessionID, syncTimeUtc, syncTimeQPC, timeQPCFrequency, previousDispatchTask, this.m_dispatchTaskCancellationSource.Token);
			}, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x00151181 File Offset: 0x0014F381
		private void SetStopDispatchTask()
		{
			CancellationTokenSource dispatchTaskCancellationSource = this.m_dispatchTaskCancellationSource;
			if (dispatchTaskCancellationSource == null || dispatchTaskCancellationSource.IsCancellationRequested)
			{
				return;
			}
			ulong sessionID = Volatile.Read(ref this.m_sessionID);
			this.m_dispatchTaskCancellationSource.Cancel();
			EventPipeInternal.SignalSession(sessionID);
			Volatile.Write(ref this.m_sessionID, 0UL);
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x001511C4 File Offset: 0x0014F3C4
		private unsafe void DispatchEventsToEventListeners(ulong sessionID, DateTime syncTimeUtc, long syncTimeQPC, long timeQPCFrequency, Task previousDispatchTask, CancellationToken token)
		{
			if (previousDispatchTask != null)
			{
				previousDispatchTask.Wait(CancellationToken.None);
			}
			while (!token.IsCancellationRequested)
			{
				bool flag = false;
				EventPipeEventInstanceData eventPipeEventInstanceData;
				while (!token.IsCancellationRequested && EventPipeInternal.GetNextEvent(sessionID, &eventPipeEventInstanceData))
				{
					flag = true;
					if (eventPipeEventInstanceData.ProviderID == this.m_RuntimeProviderID)
					{
						ReadOnlySpan<byte> payload = new ReadOnlySpan<byte>(eventPipeEventInstanceData.Payload, (int)eventPipeEventInstanceData.PayloadLength);
						DateTime timeStamp = EventPipeEventDispatcher.TimeStampToDateTime(eventPipeEventInstanceData.TimeStamp, syncTimeUtc, syncTimeQPC, timeQPCFrequency);
						NativeRuntimeEventSource.Log.ProcessEvent(eventPipeEventInstanceData.EventID, eventPipeEventInstanceData.ThreadID, timeStamp, eventPipeEventInstanceData.ActivityId, eventPipeEventInstanceData.ChildActivityId, payload);
					}
				}
				if (!token.IsCancellationRequested)
				{
					if (!flag)
					{
						EventPipeInternal.WaitForSessionSignal(sessionID, -1);
					}
					Thread.Sleep(10);
				}
			}
			SpinWait spinWait = default(SpinWait);
			while (Volatile.Read(ref this.m_sessionID) == sessionID)
			{
				spinWait.SpinOnce();
			}
			EventPipeInternal.Disable(sessionID);
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x001512A8 File Offset: 0x0014F4A8
		private static DateTime TimeStampToDateTime(long timeStamp, DateTime syncTimeUtc, long syncTimeQPC, long timeQPCFrequency)
		{
			if (timeStamp == 9223372036854775807L)
			{
				return DateTime.MaxValue;
			}
			long num = (long)((double)(timeStamp - syncTimeQPC) * 10000000.0 / (double)timeQPCFrequency) + syncTimeUtc.Ticks;
			if (num < 0L || 3155378975999999999L < num)
			{
				num = 3155378975999999999L;
			}
			return new DateTime(num, DateTimeKind.Utc);
		}

		// Token: 0x04001F6F RID: 8047
		internal static readonly EventPipeEventDispatcher Instance = new EventPipeEventDispatcher();

		// Token: 0x04001F70 RID: 8048
		private readonly IntPtr m_RuntimeProviderID;

		// Token: 0x04001F71 RID: 8049
		private ulong m_sessionID;

		// Token: 0x04001F72 RID: 8050
		private CancellationTokenSource m_dispatchTaskCancellationSource;

		// Token: 0x04001F73 RID: 8051
		private Task m_dispatchTask;

		// Token: 0x04001F74 RID: 8052
		private readonly object m_dispatchControlLock = new object();

		// Token: 0x04001F75 RID: 8053
		private readonly Dictionary<EventListener, EventPipeEventDispatcher.EventListenerSubscription> m_subscriptions = new Dictionary<EventListener, EventPipeEventDispatcher.EventListenerSubscription>();

		// Token: 0x020008DA RID: 2266
		internal sealed class EventListenerSubscription
		{
			// Token: 0x17001294 RID: 4756
			// (get) Token: 0x06008B89 RID: 35721 RVA: 0x00151310 File Offset: 0x0014F510
			internal EventKeywords MatchAnyKeywords { get; }

			// Token: 0x17001295 RID: 4757
			// (get) Token: 0x06008B8A RID: 35722 RVA: 0x00151318 File Offset: 0x0014F518
			internal EventLevel Level { get; }

			// Token: 0x06008B8B RID: 35723 RVA: 0x00151320 File Offset: 0x0014F520
			internal EventListenerSubscription(EventKeywords matchAnyKeywords, EventLevel level)
			{
				this.MatchAnyKeywords = matchAnyKeywords;
				this.Level = level;
			}
		}
	}
}
