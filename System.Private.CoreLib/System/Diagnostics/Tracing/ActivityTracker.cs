using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008C8 RID: 2248
	internal sealed class ActivityTracker
	{
		// Token: 0x06008AF5 RID: 35573 RVA: 0x0014F0EC File Offset: 0x0014D2EC
		public void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options, bool useTplSource = true)
		{
			if (this.m_current == null)
			{
				if (this.m_checkedForEnable)
				{
					return;
				}
				this.m_checkedForEnable = true;
				if (useTplSource && TplEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)128L))
				{
					this.Enable();
				}
				if (this.m_current == null)
				{
					return;
				}
			}
			ActivityTracker.ActivityInfo value = this.m_current.Value;
			string text = ActivityTracker.NormalizeActivityName(providerName, activityName, task);
			TplEventSource tplEventSource = useTplSource ? TplEventSource.Log : null;
			bool flag = tplEventSource != null && tplEventSource.Debug;
			if (flag)
			{
				tplEventSource.DebugFacilityMessage("OnStartEnter", text);
				tplEventSource.DebugFacilityMessage("OnStartEnterActivityState", ActivityTracker.ActivityInfo.LiveActivities(value));
			}
			if (value != null)
			{
				if (value.m_level >= 100)
				{
					activityId = Guid.Empty;
					relatedActivityId = Guid.Empty;
					if (flag)
					{
						tplEventSource.DebugFacilityMessage("OnStartRET", "Fail");
					}
					return;
				}
				if ((options & EventActivityOptions.Recursive) == EventActivityOptions.None && ActivityTracker.FindActiveActivity(text, value) != null)
				{
					this.OnStop(providerName, activityName, task, ref activityId, true);
					value = this.m_current.Value;
				}
			}
			long uniqueId;
			if (value == null)
			{
				uniqueId = Interlocked.Increment(ref ActivityTracker.m_nextId);
			}
			else
			{
				uniqueId = Interlocked.Increment(ref value.m_lastChildID);
			}
			relatedActivityId = EventSource.CurrentThreadActivityId;
			ActivityTracker.ActivityInfo activityInfo = new ActivityTracker.ActivityInfo(text, uniqueId, value, relatedActivityId, options);
			this.m_current.Value = activityInfo;
			activityId = activityInfo.ActivityId;
			if (flag)
			{
				tplEventSource.DebugFacilityMessage("OnStartRetActivityState", ActivityTracker.ActivityInfo.LiveActivities(activityInfo));
				tplEventSource.DebugFacilityMessage1("OnStartRet", activityId.ToString(), relatedActivityId.ToString());
			}
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x0014F27C File Offset: 0x0014D47C
		public void OnStop(string providerName, string activityName, int task, ref Guid activityId, bool useTplSource = true)
		{
			if (this.m_current == null)
			{
				return;
			}
			string text = ActivityTracker.NormalizeActivityName(providerName, activityName, task);
			TplEventSource tplEventSource = useTplSource ? TplEventSource.Log : null;
			bool flag = tplEventSource != null && tplEventSource.Debug;
			if (flag)
			{
				tplEventSource.DebugFacilityMessage("OnStopEnter", text);
				tplEventSource.DebugFacilityMessage("OnStopEnterActivityState", ActivityTracker.ActivityInfo.LiveActivities(this.m_current.Value));
			}
			ActivityTracker.ActivityInfo activityInfo;
			for (;;)
			{
				ActivityTracker.ActivityInfo value = this.m_current.Value;
				activityInfo = null;
				ActivityTracker.ActivityInfo activityInfo2 = ActivityTracker.FindActiveActivity(text, value);
				if (activityInfo2 == null)
				{
					break;
				}
				activityId = activityInfo2.ActivityId;
				ActivityTracker.ActivityInfo activityInfo3 = value;
				while (activityInfo3 != activityInfo2 && activityInfo3 != null)
				{
					if (activityInfo3.m_stopped)
					{
						activityInfo3 = activityInfo3.m_creator;
					}
					else
					{
						if (activityInfo3.CanBeOrphan())
						{
							if (activityInfo == null)
							{
								activityInfo = activityInfo3;
							}
						}
						else
						{
							activityInfo3.m_stopped = true;
						}
						activityInfo3 = activityInfo3.m_creator;
					}
				}
				if (!Interlocked.Exchange<bool>(ref activityInfo2.m_stopped, true))
				{
					goto Block_11;
				}
			}
			activityId = Guid.Empty;
			if (flag)
			{
				tplEventSource.DebugFacilityMessage("OnStopRET", "Fail");
			}
			return;
			Block_11:
			if (activityInfo == null)
			{
				ActivityTracker.ActivityInfo activityInfo2;
				activityInfo = activityInfo2.m_creator;
			}
			this.m_current.Value = activityInfo;
			if (flag)
			{
				tplEventSource.DebugFacilityMessage("OnStopRetActivityState", ActivityTracker.ActivityInfo.LiveActivities(activityInfo));
				tplEventSource.DebugFacilityMessage("OnStopRet", activityId.ToString());
			}
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x0014F3CC File Offset: 0x0014D5CC
		public void Enable()
		{
			if (this.m_current == null)
			{
				try
				{
					this.m_current = new AsyncLocal<ActivityTracker.ActivityInfo>(new Action<AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo>>(this.ActivityChanging));
				}
				catch (NotImplementedException)
				{
					Debugger.Log(0, null, "Activity Enabled() called but AsyncLocals Not Supported (pre V4.6).  Ignoring Enable");
				}
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06008AF8 RID: 35576 RVA: 0x0014F41C File Offset: 0x0014D61C
		public static ActivityTracker Instance
		{
			get
			{
				return ActivityTracker.s_activityTrackerInstance;
			}
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x0014F424 File Offset: 0x0014D624
		private static ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation)
		{
			for (ActivityTracker.ActivityInfo activityInfo = startLocation; activityInfo != null; activityInfo = activityInfo.m_creator)
			{
				if (name == activityInfo.m_name && !activityInfo.m_stopped)
				{
					return activityInfo;
				}
			}
			return null;
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x0014F458 File Offset: 0x0014D658
		private static string NormalizeActivityName(string providerName, string activityName, int task)
		{
			if (activityName.EndsWith("Start", StringComparison.Ordinal))
			{
				ReadOnlySpan<char> str = providerName;
				ReadOnlySpan<char> readOnlySpan = activityName.AsSpan();
				ref ReadOnlySpan<char> ptr = ref readOnlySpan;
				int length = "Start".Length;
				return str + ptr.Slice(0, ptr.Length - length);
			}
			if (activityName.EndsWith("Stop", StringComparison.Ordinal))
			{
				ReadOnlySpan<char> str2 = providerName;
				ReadOnlySpan<char> readOnlySpan = activityName.AsSpan();
				ref ReadOnlySpan<char> ptr = ref readOnlySpan;
				int length = "Stop".Length;
				return str2 + ptr.Slice(0, ptr.Length - length);
			}
			if (task != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendFormatted(providerName);
				defaultInterpolatedStringHandler.AppendLiteral("task");
				defaultInterpolatedStringHandler.AppendFormatted<int>(task);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return providerName + activityName;
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x0014F518 File Offset: 0x0014D718
		private void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args)
		{
			ActivityTracker.ActivityInfo activityInfo = args.CurrentValue;
			ActivityTracker.ActivityInfo previousValue = args.PreviousValue;
			if (previousValue != null && previousValue.m_creator == activityInfo && (activityInfo == null || previousValue.m_activityIdToRestore != activityInfo.ActivityId))
			{
				EventSource.SetCurrentThreadActivityId(previousValue.m_activityIdToRestore);
				return;
			}
			while (activityInfo != null)
			{
				if (!activityInfo.m_stopped)
				{
					EventSource.SetCurrentThreadActivityId(activityInfo.ActivityId);
					return;
				}
				activityInfo = activityInfo.m_creator;
			}
			EventSource.SetCurrentThreadActivityId(Guid.Empty);
		}

		// Token: 0x04001F0B RID: 7947
		private AsyncLocal<ActivityTracker.ActivityInfo> m_current;

		// Token: 0x04001F0C RID: 7948
		private bool m_checkedForEnable;

		// Token: 0x04001F0D RID: 7949
		private static readonly ActivityTracker s_activityTrackerInstance = new ActivityTracker();

		// Token: 0x04001F0E RID: 7950
		private static long m_nextId;

		// Token: 0x020008C9 RID: 2249
		private sealed class ActivityInfo
		{
			// Token: 0x06008AFE RID: 35582 RVA: 0x0014F598 File Offset: 0x0014D798
			public ActivityInfo(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options)
			{
				this.m_name = name;
				this.m_eventOptions = options;
				this.m_creator = creator;
				this.m_uniqueId = uniqueId;
				this.m_level = ((creator != null) ? (creator.m_level + 1) : 0);
				this.m_activityIdToRestore = activityIDToRestore;
				this.CreateActivityPathGuid(out this.m_guid, out this.m_activityPathGuidOffset);
			}

			// Token: 0x17001268 RID: 4712
			// (get) Token: 0x06008AFF RID: 35583 RVA: 0x0014F5F6 File Offset: 0x0014D7F6
			public Guid ActivityId
			{
				get
				{
					return this.m_guid;
				}
			}

			// Token: 0x06008B00 RID: 35584 RVA: 0x0014F600 File Offset: 0x0014D800
			public static string Path(ActivityTracker.ActivityInfo activityInfo)
			{
				if (activityInfo == null)
				{
					return "";
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(ActivityTracker.ActivityInfo.Path(activityInfo.m_creator));
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<long>(activityInfo.m_uniqueId);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}

			// Token: 0x06008B01 RID: 35585 RVA: 0x0014F651 File Offset: 0x0014D851
			public override string ToString()
			{
				return this.m_name + "(" + ActivityTracker.ActivityInfo.Path(this) + (this.m_stopped ? ",DEAD)" : ")");
			}

			// Token: 0x06008B02 RID: 35586 RVA: 0x0014F67D File Offset: 0x0014D87D
			public static string LiveActivities(ActivityTracker.ActivityInfo list)
			{
				if (list == null)
				{
					return "";
				}
				return list.ToString() + ";" + ActivityTracker.ActivityInfo.LiveActivities(list.m_creator);
			}

			// Token: 0x06008B03 RID: 35587 RVA: 0x0014F6A3 File Offset: 0x0014D8A3
			public bool CanBeOrphan()
			{
				return (this.m_eventOptions & EventActivityOptions.Detachable) != EventActivityOptions.None;
			}

			// Token: 0x06008B04 RID: 35588 RVA: 0x0014F6B4 File Offset: 0x0014D8B4
			private unsafe void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset)
			{
				fixed (Guid* ptr = &idRet)
				{
					Guid* outPtr = ptr;
					int whereToAddId = 0;
					if (this.m_creator != null)
					{
						whereToAddId = this.m_creator.m_activityPathGuidOffset;
						idRet = this.m_creator.m_guid;
					}
					else
					{
						int id = 1;
						whereToAddId = ActivityTracker.ActivityInfo.AddIdToGuid(outPtr, whereToAddId, (uint)id, false);
					}
					activityPathGuidOffset = ActivityTracker.ActivityInfo.AddIdToGuid(outPtr, whereToAddId, (uint)this.m_uniqueId, false);
					if (12 < activityPathGuidOffset)
					{
						this.CreateOverflowGuid(outPtr);
					}
				}
			}

			// Token: 0x06008B05 RID: 35589 RVA: 0x0014F71C File Offset: 0x0014D91C
			private unsafe void CreateOverflowGuid(Guid* outPtr)
			{
				for (ActivityTracker.ActivityInfo creator = this.m_creator; creator != null; creator = creator.m_creator)
				{
					if (creator.m_activityPathGuidOffset <= 10)
					{
						uint id = (uint)Interlocked.Increment(ref creator.m_lastChildID);
						*outPtr = creator.m_guid;
						if (ActivityTracker.ActivityInfo.AddIdToGuid(outPtr, creator.m_activityPathGuidOffset, id, true) <= 12)
						{
							break;
						}
					}
				}
			}

			// Token: 0x06008B06 RID: 35590 RVA: 0x0014F774 File Offset: 0x0014D974
			private unsafe static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = false)
			{
				byte* ptr = (byte*)outPtr;
				byte* ptr2 = ptr + 12;
				ptr += whereToAddId;
				if (ptr2 == ptr)
				{
					return 13;
				}
				if (0U < id && id <= 10U && !overflow)
				{
					ActivityTracker.ActivityInfo.WriteNibble(ref ptr, ptr2, id);
				}
				else
				{
					uint num = 4U;
					if (id <= 255U)
					{
						num = 1U;
					}
					else if (id <= 65535U)
					{
						num = 2U;
					}
					else if (id <= 16777215U)
					{
						num = 3U;
					}
					if (overflow)
					{
						if (ptr2 == ptr + 2)
						{
							return 13;
						}
						ActivityTracker.ActivityInfo.WriteNibble(ref ptr, ptr2, 11U);
					}
					ActivityTracker.ActivityInfo.WriteNibble(ref ptr, ptr2, 12U + (num - 1U));
					if (ptr < ptr2 && *ptr != 0)
					{
						if (id < 4096U)
						{
							*ptr = (byte)(192U + (id >> 8));
							id &= 255U;
						}
						ptr++;
					}
					while (0U < num)
					{
						if (ptr2 == ptr)
						{
							ptr++;
							break;
						}
						*(ptr++) = (byte)id;
						id >>= 8;
						num -= 1U;
					}
				}
				*(int*)(outPtr + (IntPtr)3 * 4 / (IntPtr)sizeof(Guid)) = (int)(*(uint*)outPtr + *(uint*)(outPtr + 4 / sizeof(Guid)) + *(uint*)(outPtr + (IntPtr)2 * 4 / (IntPtr)sizeof(Guid)) + 1503500717U ^ (uint)Environment.ProcessId);
				return (int)((long)((byte*)ptr - (byte*)outPtr));
			}

			// Token: 0x06008B07 RID: 35591 RVA: 0x0014F86C File Offset: 0x0014DA6C
			private unsafe static void WriteNibble(ref byte* ptr, byte* endPtr, uint value)
			{
				if (*ptr != 0)
				{
					byte* ptr2 = ptr;
					ptr = ptr2 + 1;
					byte* ptr3 = ptr2;
					*ptr3 |= (byte)value;
					return;
				}
				*ptr = (byte)(value << 4);
			}

			// Token: 0x04001F0F RID: 7951
			internal readonly string m_name;

			// Token: 0x04001F10 RID: 7952
			private readonly long m_uniqueId;

			// Token: 0x04001F11 RID: 7953
			internal readonly Guid m_guid;

			// Token: 0x04001F12 RID: 7954
			internal readonly int m_activityPathGuidOffset;

			// Token: 0x04001F13 RID: 7955
			internal readonly int m_level;

			// Token: 0x04001F14 RID: 7956
			internal readonly EventActivityOptions m_eventOptions;

			// Token: 0x04001F15 RID: 7957
			internal long m_lastChildID;

			// Token: 0x04001F16 RID: 7958
			internal bool m_stopped;

			// Token: 0x04001F17 RID: 7959
			internal readonly ActivityTracker.ActivityInfo m_creator;

			// Token: 0x04001F18 RID: 7960
			internal readonly Guid m_activityIdToRestore;
		}
	}
}
