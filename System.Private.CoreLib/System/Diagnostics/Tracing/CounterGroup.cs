using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008CB RID: 2251
	[UnsupportedOSPlatform("browser")]
	internal sealed class CounterGroup
	{
		// Token: 0x06008B15 RID: 35605 RVA: 0x0014FA99 File Offset: 0x0014DC99
		internal CounterGroup(EventSource eventSource)
		{
			this._eventSource = eventSource;
			this._counters = new List<DiagnosticCounter>();
			this.RegisterCommandCallback();
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x0014FABC File Offset: 0x0014DCBC
		internal void Add(DiagnosticCounter eventCounter)
		{
			object obj = CounterGroup.s_counterGroupLock;
			lock (obj)
			{
				this._counters.Add(eventCounter);
			}
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x0014FB04 File Offset: 0x0014DD04
		internal void Remove(DiagnosticCounter eventCounter)
		{
			object obj = CounterGroup.s_counterGroupLock;
			lock (obj)
			{
				this._counters.Remove(eventCounter);
			}
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x0014FB4C File Offset: 0x0014DD4C
		private void RegisterCommandCallback()
		{
			this._eventSource.EventCommandExecuted += this.OnEventSourceCommand;
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x0014FB68 File Offset: 0x0014DD68
		private void OnEventSourceCommand(object sender, EventCommandEventArgs e)
		{
			object obj = CounterGroup.s_counterGroupLock;
			lock (obj)
			{
				if (e.Command == EventCommand.Enable)
				{
					string s;
					float num;
					if (e.Arguments.TryGetValue("EventCounterIntervalSec", out s) && float.TryParse(s, out num))
					{
						if (num <= 0f)
						{
							this.DisableTimer();
						}
						else
						{
							this.EnableTimer(num);
						}
					}
				}
				else if (!this._eventSource.IsEnabled())
				{
					this.DisableTimer();
				}
			}
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x0014FBF8 File Offset: 0x0014DDF8
		private static void EnsureEventSourceIndexAvailable(int eventSourceIndex)
		{
			if (CounterGroup.s_counterGroups == null)
			{
				CounterGroup.s_counterGroups = new WeakReference<CounterGroup>[eventSourceIndex + 1];
				return;
			}
			if (eventSourceIndex >= CounterGroup.s_counterGroups.Length)
			{
				WeakReference<CounterGroup>[] destinationArray = new WeakReference<CounterGroup>[eventSourceIndex + 1];
				Array.Copy(CounterGroup.s_counterGroups, destinationArray, CounterGroup.s_counterGroups.Length);
				CounterGroup.s_counterGroups = destinationArray;
			}
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x0014FC48 File Offset: 0x0014DE48
		internal static CounterGroup GetCounterGroup(EventSource eventSource)
		{
			object obj = CounterGroup.s_counterGroupLock;
			CounterGroup result;
			lock (obj)
			{
				int num = EventListener.EventSourceIndex(eventSource);
				CounterGroup.EnsureEventSourceIndexAvailable(num);
				WeakReference<CounterGroup> weakReference = CounterGroup.s_counterGroups[num];
				CounterGroup counterGroup;
				if (weakReference == null || !weakReference.TryGetTarget(out counterGroup))
				{
					counterGroup = new CounterGroup(eventSource);
					CounterGroup.s_counterGroups[num] = new WeakReference<CounterGroup>(counterGroup);
				}
				result = counterGroup;
			}
			return result;
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x0014FCC0 File Offset: 0x0014DEC0
		private void EnableTimer(float pollingIntervalInSeconds)
		{
			if (this._pollingIntervalInMilliseconds == 0 || pollingIntervalInSeconds * 1000f < (float)this._pollingIntervalInMilliseconds)
			{
				this._pollingIntervalInMilliseconds = (int)(pollingIntervalInSeconds * 1000f);
				this.HandleCountersReset();
				this._timeStampSinceCollectionStarted = DateTime.UtcNow;
				this._nextPollingTimeStamp = DateTime.UtcNow + new TimeSpan(0, 0, (int)pollingIntervalInSeconds);
				if (CounterGroup.s_pollingThread == null)
				{
					CounterGroup.s_pollingThreadSleepEvent = new AutoResetEvent(false);
					CounterGroup.s_counterGroupEnabledList = new List<CounterGroup>();
					ThreadStart start;
					if ((start = CounterGroup.<>O.<0>__PollForValues) == null)
					{
						start = (CounterGroup.<>O.<0>__PollForValues = new ThreadStart(CounterGroup.PollForValues));
					}
					CounterGroup.s_pollingThread = new Thread(start)
					{
						IsBackground = true,
						Name = ".NET Counter Poller"
					};
					CounterGroup.s_pollingThread.InternalUnsafeStart();
				}
				if (!CounterGroup.s_counterGroupEnabledList.Contains(this))
				{
					CounterGroup.s_counterGroupEnabledList.Add(this);
				}
				CounterGroup.s_pollingThreadSleepEvent.Set();
			}
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x0014FDA0 File Offset: 0x0014DFA0
		private void DisableTimer()
		{
			this._pollingIntervalInMilliseconds = 0;
			List<CounterGroup> list = CounterGroup.s_counterGroupEnabledList;
			if (list != null)
			{
				list.Remove(this);
			}
			if (CounterGroup.s_needsResetIncrementingPollingCounters.Count > 0)
			{
				foreach (DiagnosticCounter diagnosticCounter in this._counters)
				{
					IncrementingPollingCounter incrementingPollingCounter = diagnosticCounter as IncrementingPollingCounter;
					if (incrementingPollingCounter != null)
					{
						CounterGroup.s_needsResetIncrementingPollingCounters.Remove(incrementingPollingCounter);
					}
				}
			}
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x0014FE28 File Offset: 0x0014E028
		private void HandleCountersReset()
		{
			foreach (DiagnosticCounter diagnosticCounter in this._counters)
			{
				IncrementingEventCounter incrementingEventCounter = diagnosticCounter as IncrementingEventCounter;
				if (incrementingEventCounter != null)
				{
					incrementingEventCounter.UpdateMetric();
				}
				else
				{
					IncrementingPollingCounter incrementingPollingCounter = diagnosticCounter as IncrementingPollingCounter;
					if (incrementingPollingCounter != null)
					{
						CounterGroup.s_needsResetIncrementingPollingCounters.Add(incrementingPollingCounter);
					}
					else
					{
						EventCounter eventCounter = diagnosticCounter as EventCounter;
						if (eventCounter != null)
						{
							eventCounter.ResetStatistics();
						}
					}
				}
			}
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x0014FEB0 File Offset: 0x0014E0B0
		private void OnTimer()
		{
			if (this._eventSource.IsEnabled())
			{
				object obj = CounterGroup.s_counterGroupLock;
				DateTime utcNow;
				TimeSpan timeSpan;
				int pollingIntervalInMilliseconds;
				DiagnosticCounter[] array;
				lock (obj)
				{
					utcNow = DateTime.UtcNow;
					timeSpan = utcNow - this._timeStampSinceCollectionStarted;
					pollingIntervalInMilliseconds = this._pollingIntervalInMilliseconds;
					array = new DiagnosticCounter[this._counters.Count];
					this._counters.CopyTo(array);
				}
				DiagnosticCounter[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].WritePayload((float)timeSpan.TotalSeconds, pollingIntervalInMilliseconds);
				}
				obj = CounterGroup.s_counterGroupLock;
				lock (obj)
				{
					this._timeStampSinceCollectionStarted = utcNow;
					TimeSpan timeSpan2 = utcNow - this._nextPollingTimeStamp;
					timeSpan2 = (((double)this._pollingIntervalInMilliseconds > timeSpan2.TotalMilliseconds) ? TimeSpan.FromMilliseconds((long)this._pollingIntervalInMilliseconds, 0L) : timeSpan2);
					if (this._pollingIntervalInMilliseconds > 0)
					{
						this._nextPollingTimeStamp += TimeSpan.FromMilliseconds((double)this._pollingIntervalInMilliseconds * Math.Ceiling(timeSpan2.TotalMilliseconds / (double)this._pollingIntervalInMilliseconds));
					}
				}
			}
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x00150000 File Offset: 0x0014E200
		private static void PollForValues()
		{
			AutoResetEvent autoResetEvent = null;
			List<CounterGroup> list = new List<CounterGroup>();
			List<IncrementingPollingCounter> list2 = null;
			for (;;)
			{
				int num = int.MaxValue;
				object obj = CounterGroup.s_counterGroupLock;
				lock (obj)
				{
					autoResetEvent = CounterGroup.s_pollingThreadSleepEvent;
					foreach (CounterGroup counterGroup in CounterGroup.s_counterGroupEnabledList)
					{
						DateTime utcNow = DateTime.UtcNow;
						if (counterGroup._nextPollingTimeStamp < utcNow + new TimeSpan(0, 0, 0, 0, 1))
						{
							list.Add(counterGroup);
						}
						int val = (int)(counterGroup._nextPollingTimeStamp - utcNow).TotalMilliseconds;
						val = Math.Max(1, val);
						num = Math.Min(num, val);
					}
					if (CounterGroup.s_needsResetIncrementingPollingCounters.Count > 0)
					{
						list2 = CounterGroup.s_needsResetIncrementingPollingCounters;
						CounterGroup.s_needsResetIncrementingPollingCounters = new List<IncrementingPollingCounter>();
					}
				}
				if (list2 != null)
				{
					foreach (IncrementingPollingCounter incrementingPollingCounter in list2)
					{
						incrementingPollingCounter.UpdateMetric();
					}
					list2 = null;
				}
				foreach (CounterGroup counterGroup2 in list)
				{
					counterGroup2.OnTimer();
				}
				list.Clear();
				if (num == 2147483647)
				{
					num = -1;
				}
				if (autoResetEvent != null)
				{
					autoResetEvent.WaitOne(num);
				}
			}
		}

		// Token: 0x04001F1F RID: 7967
		private readonly EventSource _eventSource;

		// Token: 0x04001F20 RID: 7968
		private readonly List<DiagnosticCounter> _counters;

		// Token: 0x04001F21 RID: 7969
		private static readonly object s_counterGroupLock = new object();

		// Token: 0x04001F22 RID: 7970
		private static WeakReference<CounterGroup>[] s_counterGroups;

		// Token: 0x04001F23 RID: 7971
		private DateTime _timeStampSinceCollectionStarted;

		// Token: 0x04001F24 RID: 7972
		private int _pollingIntervalInMilliseconds;

		// Token: 0x04001F25 RID: 7973
		private DateTime _nextPollingTimeStamp;

		// Token: 0x04001F26 RID: 7974
		private static Thread s_pollingThread;

		// Token: 0x04001F27 RID: 7975
		private static AutoResetEvent s_pollingThreadSleepEvent;

		// Token: 0x04001F28 RID: 7976
		private static List<CounterGroup> s_counterGroupEnabledList;

		// Token: 0x04001F29 RID: 7977
		private static List<IncrementingPollingCounter> s_needsResetIncrementingPollingCounters = new List<IncrementingPollingCounter>();

		// Token: 0x020008CC RID: 2252
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04001F2A RID: 7978
			public static ThreadStart <0>__PollForValues;
		}
	}
}
