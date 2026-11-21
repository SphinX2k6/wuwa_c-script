using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008EA RID: 2282
	[NullableContext(2)]
	[Nullable(0)]
	[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
	public class EventSource : IDisposable
	{
		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06008BE6 RID: 35814 RVA: 0x00153927 File Offset: 0x00151B27
		internal static bool IsSupported { get; }

		// Token: 0x06008BE7 RID: 35815 RVA: 0x00153930 File Offset: 0x00151B30
		private static bool InitializeIsSupported()
		{
			bool flag;
			return !AppContext.TryGetSwitch("System.Diagnostics.Tracing.EventSource.IsSupported", out flag) || flag;
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06008BE8 RID: 35816 RVA: 0x0015394E File Offset: 0x00151B4E
		internal static bool IsMeterSupported { get; }

		// Token: 0x06008BE9 RID: 35817 RVA: 0x00153958 File Offset: 0x00151B58
		private static bool InitializeIsMeterSupported()
		{
			bool flag;
			return !AppContext.TryGetSwitch("System.Diagnostics.Metrics.Meter.IsSupported", out flag) || flag;
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06008BEA RID: 35818 RVA: 0x00153976 File Offset: 0x00151B76
		[Nullable(1)]
		public string Name
		{
			[NullableContext(1)]
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06008BEB RID: 35819 RVA: 0x0015397E File Offset: 0x00151B7E
		public Guid Guid
		{
			get
			{
				return this.m_guid;
			}
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x00153986 File Offset: 0x00151B86
		public bool IsEnabled()
		{
			return this.m_eventSourceEnabled;
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x0015398E File Offset: 0x00151B8E
		public bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			return this.IsEnabled(level, keywords, EventChannel.None);
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x00153999 File Offset: 0x00151B99
		public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel)
		{
			return this.IsEnabled() && this.IsEnabledCommon(this.m_eventSourceEnabled, this.m_level, this.m_matchAnyKeyword, level, keywords, channel);
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06008BEF RID: 35823 RVA: 0x001539C5 File Offset: 0x00151BC5
		public EventSourceSettings Settings
		{
			get
			{
				return this.m_config;
			}
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x001539D0 File Offset: 0x00151BD0
		[NullableContext(1)]
		public static Guid GetGuid(Type eventSourceType)
		{
			ArgumentNullException.ThrowIfNull(eventSourceType, "eventSourceType");
			EventSourceAttribute eventSourceAttribute = (EventSourceAttribute)EventSource.GetCustomAttributeHelper(eventSourceType, typeof(EventSourceAttribute), EventManifestOptions.None);
			string name = eventSourceType.Name;
			if (eventSourceAttribute != null)
			{
				Guid result;
				if (eventSourceAttribute.Guid != null && Guid.TryParse(eventSourceAttribute.Guid, out result))
				{
					return result;
				}
				if (eventSourceAttribute.Name != null)
				{
					name = eventSourceAttribute.Name;
				}
			}
			if (name == null)
			{
				throw new ArgumentException(SR.Argument_InvalidTypeName, "eventSourceType");
			}
			return EventSource.GenerateGuidFromName(name.ToUpperInvariant());
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x00153A4F File Offset: 0x00151C4F
		[NullableContext(1)]
		public static string GetName(Type eventSourceType)
		{
			return EventSource.GetName(eventSourceType, EventManifestOptions.None);
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x00153A58 File Offset: 0x00151C58
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2114:ReflectionToDynamicallyAccessedMembers", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which has dynamically accessed members requirements, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		public static string GenerateManifest([Nullable(1)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type eventSourceType, string assemblyPathToIncludeInManifest)
		{
			return EventSource.GenerateManifest(eventSourceType, assemblyPathToIncludeInManifest, EventManifestOptions.None);
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x00153A64 File Offset: 0x00151C64
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2114:ReflectionToDynamicallyAccessedMembers", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which has dynamically accessed members requirements, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		public static string GenerateManifest([Nullable(1)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type eventSourceType, string assemblyPathToIncludeInManifest, EventManifestOptions flags)
		{
			if (!EventSource.IsSupported)
			{
				return null;
			}
			ArgumentNullException.ThrowIfNull(eventSourceType, "eventSourceType");
			byte[] array = EventSource.CreateManifestAndDescriptors(eventSourceType, assemblyPathToIncludeInManifest, null, flags);
			if (array != null)
			{
				return Encoding.UTF8.GetString(array, 0, array.Length);
			}
			return null;
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x00153AA4 File Offset: 0x00151CA4
		[NullableContext(1)]
		public static IEnumerable<EventSource> GetSources()
		{
			if (!EventSource.IsSupported)
			{
				return Array.Empty<EventSource>();
			}
			List<EventSource> list = new List<EventSource>();
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				using (List<WeakReference<EventSource>>.Enumerator enumerator = EventListener.s_EventSources.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						EventSource eventSource;
						if (enumerator.Current.TryGetTarget(out eventSource) && !eventSource.IsDisposed)
						{
							list.Add(eventSource);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x00153B44 File Offset: 0x00151D44
		[NullableContext(1)]
		public static void SendCommand(EventSource eventSource, EventCommand command, [Nullable(new byte[]
		{
			2,
			1,
			2
		})] IDictionary<string, string> commandArguments)
		{
			if (!EventSource.IsSupported)
			{
				return;
			}
			ArgumentNullException.ThrowIfNull(eventSource, "eventSource");
			if (command <= EventCommand.Update && command != EventCommand.SendManifest)
			{
				throw new ArgumentException(SR.EventSource_InvalidCommand, "command");
			}
			eventSource.SendCommand(null, EventProviderType.ETW, 0, command, true, EventLevel.LogAlways, EventKeywords.None, commandArguments);
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x00153B8B File Offset: 0x00151D8B
		public Exception ConstructionException
		{
			get
			{
				return this.m_constructionException;
			}
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x00153B94 File Offset: 0x00151D94
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetTrait(string key)
		{
			if (this.m_traits != null)
			{
				for (int i = 0; i < this.m_traits.Length - 1; i += 2)
				{
					if (this.m_traits[i] == key)
					{
						return this.m_traits[i + 1];
					}
				}
			}
			return null;
		}

		// Token: 0x06008BF8 RID: 35832 RVA: 0x00153BDA File Offset: 0x00151DDA
		[NullableContext(1)]
		public override string ToString()
		{
			if (!EventSource.IsSupported)
			{
				return base.ToString();
			}
			return SR.Format(SR.EventSource_ToString, this.Name, this.Guid);
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06008BF9 RID: 35833 RVA: 0x00153C08 File Offset: 0x00151E08
		// (remove) Token: 0x06008BFA RID: 35834 RVA: 0x00153C53 File Offset: 0x00151E53
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event EventHandler<EventCommandEventArgs> EventCommandExecuted
		{
			add
			{
				if (value == null)
				{
					return;
				}
				this.m_eventCommandExecuted = (EventHandler<EventCommandEventArgs>)Delegate.Combine(this.m_eventCommandExecuted, value);
				if (this.m_completelyInited)
				{
					for (EventCommandEventArgs eventCommandEventArgs = this.m_deferredCommands; eventCommandEventArgs != null; eventCommandEventArgs = eventCommandEventArgs.nextCommand)
					{
						value(this, eventCommandEventArgs);
					}
				}
			}
			remove
			{
				this.m_eventCommandExecuted = (EventHandler<EventCommandEventArgs>)Delegate.Remove(this.m_eventCommandExecuted, value);
			}
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x00153C6C File Offset: 0x00151E6C
		public static void SetCurrentThreadActivityId(Guid activityId)
		{
			if (!EventSource.IsSupported)
			{
				return;
			}
			TplEventSource log = TplEventSource.Log;
			if (log != null)
			{
				log.SetActivityId(activityId);
			}
			EventPipeEventProvider.EventActivityIdControl(Interop.Advapi32.ActivityControl.EVENT_ACTIVITY_CTRL_SET_ID, ref activityId);
			Interop.Advapi32.EventActivityIdControl(Interop.Advapi32.ActivityControl.EVENT_ACTIVITY_CTRL_SET_ID, ref activityId);
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x00153C9C File Offset: 0x00151E9C
		public static Guid CurrentThreadActivityId
		{
			get
			{
				if (!EventSource.IsSupported)
				{
					return default(Guid);
				}
				Guid result = default(Guid);
				Interop.Advapi32.EventActivityIdControl(Interop.Advapi32.ActivityControl.EVENT_ACTIVITY_CTRL_GET_ID, ref result);
				return result;
			}
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x00153CCC File Offset: 0x00151ECC
		public static void SetCurrentThreadActivityId(Guid activityId, out Guid oldActivityThatWillContinue)
		{
			if (!EventSource.IsSupported)
			{
				oldActivityThatWillContinue = default(Guid);
				return;
			}
			oldActivityThatWillContinue = activityId;
			EventPipeEventProvider.EventActivityIdControl(Interop.Advapi32.ActivityControl.EVENT_ACTIVITY_CTRL_SET_ID, ref oldActivityThatWillContinue);
			Interop.Advapi32.EventActivityIdControl(Interop.Advapi32.ActivityControl.EVENT_ACTIVITY_CTRL_GET_SET_ID, ref oldActivityThatWillContinue);
			TplEventSource log = TplEventSource.Log;
			if (log == null)
			{
				return;
			}
			log.SetActivityId(activityId);
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x00153D04 File Offset: 0x00151F04
		protected EventSource() : this(EventSourceSettings.EtwManifestEventFormat)
		{
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x00153D0D File Offset: 0x00151F0D
		protected EventSource(bool throwOnEventWriteErrors) : this(EventSourceSettings.EtwManifestEventFormat | (throwOnEventWriteErrors ? EventSourceSettings.ThrowOnEventWriteErrors : EventSourceSettings.Default))
		{
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x00153D1E File Offset: 0x00151F1E
		protected EventSource(EventSourceSettings settings) : this(settings, null)
		{
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x00153D28 File Offset: 0x00151F28
		protected EventSource(EventSourceSettings settings, [Nullable(new byte[]
		{
			2,
			1
		})] params string[] traits)
		{
			this.m_writeEventStringEventHandle = IntPtr.Zero;
			base..ctor();
			if (EventSource.IsSupported)
			{
				this.m_eventHandleTable = new TraceLoggingEventHandleTable();
				this.m_config = EventSource.ValidateSettings(settings);
				Type type = base.GetType();
				Guid guid = EventSource.GetGuid(type);
				string name = EventSource.GetName(type);
				this.Initialize(guid, name, traits);
			}
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x00153D80 File Offset: 0x00151F80
		private unsafe void DefineEventPipeEvents()
		{
			if (this.SelfDescribingEvents)
			{
				return;
			}
			int num = this.m_eventData.Length;
			for (int i = 0; i < num; i++)
			{
				uint eventId = (uint)this.m_eventData[i].Descriptor.EventId;
				if (eventId != 0U)
				{
					byte[] array = EventPipeMetadataGenerator.Instance.GenerateEventMetadata(this.m_eventData[i]);
					uint metadataLength = (uint)((array != null) ? array.Length : 0);
					string name = this.m_eventData[i].Name;
					long keywords = this.m_eventData[i].Descriptor.Keywords;
					uint version = (uint)this.m_eventData[i].Descriptor.Version;
					uint level = (uint)this.m_eventData[i].Descriptor.Level;
					byte[] array2;
					byte* pMetadata;
					if ((array2 = array) == null || array2.Length == 0)
					{
						pMetadata = null;
					}
					else
					{
						pMetadata = &array2[0];
					}
					IntPtr eventHandle = this.m_eventPipeProvider._eventProvider.DefineEventHandle(eventId, name, keywords, version, level, pMetadata, metadataLength);
					this.m_eventData[i].EventHandle = eventHandle;
					array2 = null;
				}
			}
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(1)]
		protected virtual void OnEventCommand(EventCommandEventArgs command)
		{
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x00153EAF File Offset: 0x001520AF
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected void WriteEvent(int eventId)
		{
			this.WriteEventCore(eventId, 0, null);
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x00153EBC File Offset: 0x001520BC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, int arg1)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->DataPointer = &arg1;
				ptr->Size = 4;
				ptr->Reserved = 0;
				this.WriteEventCore(eventId, 1, ptr);
			}
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x00153F00 File Offset: 0x00152100
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, int arg1, int arg2)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->DataPointer = &arg1;
				ptr->Size = 4;
				ptr->Reserved = 0;
				ptr[1].DataPointer = &arg2;
				ptr[1].Size = 4;
				ptr[1].Reserved = 0;
				this.WriteEventCore(eventId, 2, ptr);
			}
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x00153F70 File Offset: 0x00152170
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, int arg1, int arg2, int arg3)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->DataPointer = &arg1;
				ptr->Size = 4;
				ptr->Reserved = 0;
				ptr[1].DataPointer = &arg2;
				ptr[1].Size = 4;
				ptr[1].Reserved = 0;
				ptr[2].DataPointer = &arg3;
				ptr[2].Size = 4;
				ptr[2].Reserved = 0;
				this.WriteEventCore(eventId, 3, ptr);
			}
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x00154018 File Offset: 0x00152218
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, long arg1)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->DataPointer = &arg1;
				ptr->Size = 8;
				ptr->Reserved = 0;
				this.WriteEventCore(eventId, 1, ptr);
			}
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x0015405C File Offset: 0x0015225C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, long arg1, long arg2)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->DataPointer = &arg1;
				ptr->Size = 8;
				ptr->Reserved = 0;
				ptr[1].DataPointer = &arg2;
				ptr[1].Size = 8;
				ptr[1].Reserved = 0;
				this.WriteEventCore(eventId, 2, ptr);
			}
		}

		// Token: 0x06008C0A RID: 35850 RVA: 0x001540CC File Offset: 0x001522CC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, long arg1, long arg2, long arg3)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->DataPointer = &arg1;
				ptr->Size = 8;
				ptr->Reserved = 0;
				ptr[1].DataPointer = &arg2;
				ptr[1].Size = 8;
				ptr[1].Reserved = 0;
				ptr[2].DataPointer = &arg3;
				ptr[2].Size = 8;
				ptr[2].Reserved = 0;
				this.WriteEventCore(eventId, 3, ptr);
			}
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x00154174 File Offset: 0x00152374
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, string arg1)
		{
			if (this.IsEnabled())
			{
				if (arg1 == null)
				{
					arg1 = "";
				}
				char* ptr;
				if (arg1 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg1.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = dataPointer;
				ptr3->Size = (arg1.Length + 1) * 2;
				ptr3->Reserved = 0;
				this.WriteEventCore(eventId, 1, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x001541DC File Offset: 0x001523DC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, string arg1, string arg2)
		{
			if (this.IsEnabled())
			{
				if (arg1 == null)
				{
					arg1 = "";
				}
				if (arg2 == null)
				{
					arg2 = "";
				}
				char* ptr;
				if (arg1 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg1.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				char* ptr3;
				if (arg2 == null)
				{
					ptr3 = null;
				}
				else
				{
					fixed (char* ptr4 = arg2.GetPinnableReference())
					{
						ptr3 = ptr4;
					}
				}
				char* dataPointer2 = ptr3;
				EventSource.EventData* ptr5 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr5->DataPointer = dataPointer;
				ptr5->Size = (arg1.Length + 1) * 2;
				ptr5->Reserved = 0;
				ptr5[1].DataPointer = dataPointer2;
				ptr5[1].Size = (arg2.Length + 1) * 2;
				ptr5[1].Reserved = 0;
				this.WriteEventCore(eventId, 2, ptr5);
				char* ptr4 = null;
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x001542A0 File Offset: 0x001524A0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			if (this.IsEnabled())
			{
				if (arg1 == null)
				{
					arg1 = "";
				}
				if (arg2 == null)
				{
					arg2 = "";
				}
				if (arg3 == null)
				{
					arg3 = "";
				}
				char* ptr;
				if (arg1 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg1.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				char* ptr3;
				if (arg2 == null)
				{
					ptr3 = null;
				}
				else
				{
					fixed (char* ptr4 = arg2.GetPinnableReference())
					{
						ptr3 = ptr4;
					}
				}
				char* dataPointer2 = ptr3;
				char* ptr5;
				if (arg3 == null)
				{
					ptr5 = null;
				}
				else
				{
					fixed (char* ptr6 = arg3.GetPinnableReference())
					{
						ptr5 = ptr6;
					}
				}
				char* dataPointer3 = ptr5;
				EventSource.EventData* ptr7 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr7->DataPointer = dataPointer;
				ptr7->Size = (arg1.Length + 1) * 2;
				ptr7->Reserved = 0;
				ptr7[1].DataPointer = dataPointer2;
				ptr7[1].Size = (arg2.Length + 1) * 2;
				ptr7[1].Reserved = 0;
				ptr7[2].DataPointer = dataPointer3;
				ptr7[2].Size = (arg3.Length + 1) * 2;
				ptr7[2].Reserved = 0;
				this.WriteEventCore(eventId, 3, ptr7);
				char* ptr6 = null;
				char* ptr4 = null;
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x001543C8 File Offset: 0x001525C8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, string arg1, int arg2)
		{
			if (this.IsEnabled())
			{
				if (arg1 == null)
				{
					arg1 = "";
				}
				char* ptr;
				if (arg1 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg1.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = dataPointer;
				ptr3->Size = (arg1.Length + 1) * 2;
				ptr3->Reserved = 0;
				ptr3[1].DataPointer = &arg2;
				ptr3[1].Size = 4;
				ptr3[1].Reserved = 0;
				this.WriteEventCore(eventId, 2, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x0015445C File Offset: 0x0015265C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, string arg1, int arg2, int arg3)
		{
			if (this.IsEnabled())
			{
				if (arg1 == null)
				{
					arg1 = "";
				}
				char* ptr;
				if (arg1 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg1.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = dataPointer;
				ptr3->Size = (arg1.Length + 1) * 2;
				ptr3->Reserved = 0;
				ptr3[1].DataPointer = &arg2;
				ptr3[1].Size = 4;
				ptr3[1].Reserved = 0;
				ptr3[2].DataPointer = &arg3;
				ptr3[2].Size = 4;
				ptr3[2].Reserved = 0;
				this.WriteEventCore(eventId, 3, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x00154528 File Offset: 0x00152728
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, string arg1, long arg2)
		{
			if (this.IsEnabled())
			{
				if (arg1 == null)
				{
					arg1 = "";
				}
				char* ptr;
				if (arg1 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg1.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = dataPointer;
				ptr3->Size = (arg1.Length + 1) * 2;
				ptr3->Reserved = 0;
				ptr3[1].DataPointer = &arg2;
				ptr3[1].Size = 8;
				ptr3[1].Reserved = 0;
				this.WriteEventCore(eventId, 2, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x001545BC File Offset: 0x001527BC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, long arg1, string arg2)
		{
			if (this.IsEnabled())
			{
				if (arg2 == null)
				{
					arg2 = "";
				}
				char* ptr;
				if (arg2 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg2.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = &arg1;
				ptr3->Size = 8;
				ptr3->Reserved = 0;
				ptr3[1].DataPointer = dataPointer;
				ptr3[1].Size = (arg2.Length + 1) * 2;
				ptr3[1].Reserved = 0;
				this.WriteEventCore(eventId, 2, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x00154650 File Offset: 0x00152850
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, int arg1, string arg2)
		{
			if (this.IsEnabled())
			{
				if (arg2 == null)
				{
					arg2 = "";
				}
				char* ptr;
				if (arg2 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg2.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = &arg1;
				ptr3->Size = 4;
				ptr3->Reserved = 0;
				ptr3[1].DataPointer = dataPointer;
				ptr3[1].Size = (arg2.Length + 1) * 2;
				ptr3[1].Reserved = 0;
				this.WriteEventCore(eventId, 2, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008C13 RID: 35859 RVA: 0x001546E4 File Offset: 0x001528E4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, byte[] arg1)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventSource.EventData))];
				if (arg1 == null || arg1.Length == 0)
				{
					int num = 0;
					ptr->DataPointer = &num;
					ptr->Size = 4;
					ptr->Reserved = 0;
					ptr[1].DataPointer = &num;
					ptr[1].Size = 0;
					ptr[1].Reserved = 0;
					this.WriteEventCore(eventId, 2, ptr);
					return;
				}
				int size = arg1.Length;
				fixed (byte* ptr2 = &arg1[0])
				{
					byte* dataPointer = ptr2;
					ptr->DataPointer = &size;
					ptr->Size = 4;
					ptr->Reserved = 0;
					ptr[1].DataPointer = dataPointer;
					ptr[1].Size = size;
					ptr[1].Reserved = 0;
					this.WriteEventCore(eventId, 2, ptr);
				}
			}
		}

		// Token: 0x06008C14 RID: 35860 RVA: 0x001547C0 File Offset: 0x001529C0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected unsafe void WriteEvent(int eventId, long arg1, byte[] arg2)
		{
			if (this.IsEnabled())
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->DataPointer = &arg1;
				ptr->Size = 8;
				ptr->Reserved = 0;
				if (arg2 == null || arg2.Length == 0)
				{
					int num = 0;
					ptr[1].DataPointer = &num;
					ptr[1].Size = 4;
					ptr[1].Reserved = 0;
					ptr[2].DataPointer = &num;
					ptr[2].Size = 0;
					ptr[2].Reserved = 0;
					this.WriteEventCore(eventId, 3, ptr);
					return;
				}
				int size = arg2.Length;
				fixed (byte* ptr2 = &arg2[0])
				{
					byte* dataPointer = ptr2;
					ptr[1].DataPointer = &size;
					ptr[1].Size = 4;
					ptr[1].Reserved = 0;
					ptr[2].DataPointer = dataPointer;
					ptr[2].Size = size;
					ptr[2].Reserved = 0;
					this.WriteEventCore(eventId, 3, ptr);
				}
			}
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x001548EC File Offset: 0x00152AEC
		internal unsafe static IntPtr ObjectIDForEvents(object o)
		{
			return *(IntPtr*)(&o);
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x001548F2 File Offset: 0x00152AF2
		[NullableContext(0)]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		[CLSCompliant(false)]
		protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
			this.WriteEventWithRelatedActivityIdCore(eventId, null, eventDataCount, data);
		}

		// Token: 0x06008C17 RID: 35863 RVA: 0x00154900 File Offset: 0x00152B00
		[NullableContext(0)]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		[CLSCompliant(false)]
		protected unsafe void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data)
		{
			if (this.IsEnabled())
			{
				try
				{
					ref EventSource.EventMetadata ptr = ref this.m_eventData[eventId];
					EventOpcode opcode = (EventOpcode)ptr.Descriptor.Opcode;
					Guid* ptr2 = null;
					Guid empty = Guid.Empty;
					Guid empty2 = Guid.Empty;
					if (opcode != EventOpcode.Info && relatedActivityId == null && (ptr.ActivityOptions & EventActivityOptions.Disable) == EventActivityOptions.None)
					{
						if (opcode == EventOpcode.Start)
						{
							this.m_activityTracker.OnStart(this.m_name, ptr.Name, ptr.Descriptor.Task, ref empty, ref empty2, ptr.ActivityOptions, true);
						}
						else if (opcode == EventOpcode.Stop)
						{
							this.m_activityTracker.OnStop(this.m_name, ptr.Name, ptr.Descriptor.Task, ref empty, true);
						}
						if (empty != Guid.Empty)
						{
							ptr2 = &empty;
						}
						if (empty2 != Guid.Empty)
						{
							relatedActivityId = &empty2;
						}
					}
					if (!this.SelfDescribingEvents)
					{
						if (ptr.EnabledForETW && !this.m_etwProvider.WriteEvent(ref ptr.Descriptor, ptr.EventHandle, ptr2, relatedActivityId, eventDataCount, data))
						{
							this.ThrowEventSourceException(ptr.Name, null);
						}
						if (ptr.EnabledForEventPipe && !this.m_eventPipeProvider.WriteEvent(ref ptr.Descriptor, ptr.EventHandle, ptr2, relatedActivityId, eventDataCount, data))
						{
							this.ThrowEventSourceException(ptr.Name, null);
						}
					}
					else if (ptr.EnabledForETW || ptr.EnabledForEventPipe)
					{
						EventSourceOptions eventSourceOptions = new EventSourceOptions
						{
							Keywords = (EventKeywords)ptr.Descriptor.Keywords,
							Level = (EventLevel)ptr.Descriptor.Level,
							Opcode = (EventOpcode)ptr.Descriptor.Opcode
						};
						this.WriteMultiMerge(ptr.Name, ref eventSourceOptions, ptr.TraceLoggingEventTypes, ptr2, relatedActivityId, data);
					}
					if (this.m_Dispatchers != null && ptr.EnabledForAnyListener && base.GetType() != typeof(NativeRuntimeEventSource))
					{
						EventWrittenEventArgs eventCallbackArgs = new EventWrittenEventArgs(this, eventId, ptr2, relatedActivityId);
						this.WriteToAllListeners(eventCallbackArgs, eventDataCount, data);
					}
				}
				catch (Exception ex)
				{
					if (ex is EventSourceException)
					{
						throw;
					}
					this.ThrowEventSourceException(this.m_eventData[eventId].Name, ex);
				}
			}
		}

		// Token: 0x06008C18 RID: 35864 RVA: 0x00154B48 File Offset: 0x00152D48
		[NullableContext(1)]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		protected void WriteEvent(int eventId, params EventSource.EventSourcePrimitive[] args)
		{
			object[] array = new object[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				array[i] = args[i].Value;
			}
			this.WriteEventVarargs(eventId, null, array);
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x00154B85 File Offset: 0x00152D85
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		protected void WriteEvent(int eventId, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			this.WriteEventVarargs(eventId, null, args);
		}

		// Token: 0x06008C1A RID: 35866 RVA: 0x00154B91 File Offset: 0x00152D91
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		protected unsafe void WriteEventWithRelatedActivityId(int eventId, Guid relatedActivityId, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			this.WriteEventVarargs(eventId, &relatedActivityId, args);
		}

		// Token: 0x06008C1B RID: 35867 RVA: 0x00154B9E File Offset: 0x00152D9E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x00154BB0 File Offset: 0x00152DB0
		protected virtual void Dispose(bool disposing)
		{
			if (!EventSource.IsSupported)
			{
				return;
			}
			if (disposing)
			{
				if (this.m_eventSourceEnabled)
				{
					try
					{
						this.SendManifest(this.m_rawManifest);
					}
					catch
					{
					}
					this.m_eventSourceEnabled = false;
				}
				if (this.m_etwProvider != null)
				{
					this.m_etwProvider.Dispose();
					this.m_etwProvider = null;
				}
				if (this.m_eventPipeProvider != null)
				{
					this.m_eventPipeProvider.Dispose();
					this.m_eventPipeProvider = null;
				}
			}
			this.m_eventSourceEnabled = false;
			this.m_eventSourceDisposed = true;
		}

		// Token: 0x06008C1D RID: 35869 RVA: 0x00154C48 File Offset: 0x00152E48
		~EventSource()
		{
			this.Dispose(false);
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x00154C78 File Offset: 0x00152E78
		private unsafe void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, IntPtr eventHandle, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
		{
			bool flag = this.m_etwProvider == null;
			if (this.m_etwProvider != null && !this.m_etwProvider.WriteEventRaw(ref eventDescriptor, eventHandle, activityID, relatedActivityID, dataCount, data))
			{
				this.ThrowEventSourceException(eventName, null);
			}
			bool flag2 = flag & this.m_eventPipeProvider == null;
			if (this.m_eventPipeProvider != null && !this.m_eventPipeProvider.WriteEventRaw(ref eventDescriptor, eventHandle, activityID, relatedActivityID, dataCount, data))
			{
				this.ThrowEventSourceException(eventName, null);
			}
			if (flag2)
			{
				this.ThrowEventSourceException(eventName, null);
			}
		}

		// Token: 0x06008C1F RID: 35871 RVA: 0x00154CFC File Offset: 0x00152EFC
		internal EventSource(Guid eventSourceGuid, string eventSourceName) : this(eventSourceGuid, eventSourceName, EventSourceSettings.EtwManifestEventFormat, null)
		{
		}

		// Token: 0x06008C20 RID: 35872 RVA: 0x00154D08 File Offset: 0x00152F08
		internal EventSource(Guid eventSourceGuid, string eventSourceName, EventSourceSettings settings, string[] traits = null)
		{
			this.m_writeEventStringEventHandle = IntPtr.Zero;
			base..ctor();
			if (EventSource.IsSupported)
			{
				this.m_eventHandleTable = new TraceLoggingEventHandleTable();
				this.m_config = EventSource.ValidateSettings(settings);
				this.Initialize(eventSourceGuid, eventSourceName, traits);
			}
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x00154D44 File Offset: 0x00152F44
		private unsafe void Initialize(Guid eventSourceGuid, string eventSourceName, string[] traits)
		{
			try
			{
				this.m_traits = traits;
				if (this.m_traits != null && this.m_traits.Length % 2 != 0)
				{
					throw new ArgumentException(SR.EventSource_TraitEven, "traits");
				}
				if (eventSourceGuid == Guid.Empty)
				{
					throw new ArgumentException(SR.EventSource_NeedGuid);
				}
				if (eventSourceName == null)
				{
					throw new ArgumentException(SR.EventSource_NeedName);
				}
				this.m_name = eventSourceName;
				this.m_guid = eventSourceGuid;
				this.m_activityTracker = ActivityTracker.Instance;
				if (this.ProviderMetadata.Length == 0)
				{
					this.InitializeProviderMetadata();
				}
				Func<EventSource> eventSourceFactory = () => this;
				EventSource.OverrideEventProvider overrideEventProvider = EventSourceInitHelper.TryGetPreregisteredEtwProvider(eventSourceGuid);
				if (overrideEventProvider == null)
				{
					overrideEventProvider = new EventSource.OverrideEventProvider(eventSourceFactory, EventProviderType.ETW);
					overrideEventProvider.Register(eventSourceGuid, eventSourceName);
					if (this.Name != "System.Diagnostics.Eventing.FrameworkEventSource" || Environment.IsWindows8OrAbove)
					{
						ReadOnlySpan<byte> providerMetadata = this.ProviderMetadata;
						try
						{
							fixed (byte* ptr = providerMetadata.GetPinnableReference())
							{
								byte* data = ptr;
								overrideEventProvider.SetInformation(Interop.Advapi32.EVENT_INFO_CLASS.SetTraits, (void*)data, (uint)providerMetadata.Length);
							}
						}
						finally
						{
							byte* ptr = null;
						}
					}
				}
				EventSource.OverrideEventProvider overrideEventProvider2 = EventSourceInitHelper.TryGetPreregisteredEventPipeProvider(eventSourceName);
				if (overrideEventProvider2 == null)
				{
					overrideEventProvider2 = new EventSource.OverrideEventProvider(eventSourceFactory, EventProviderType.EventPipe);
					overrideEventProvider2.Register(eventSourceGuid, eventSourceName);
				}
				EventListener.AddEventSource(this);
				this.m_etwProvider = overrideEventProvider;
				this.m_eventPipeProvider = overrideEventProvider2;
			}
			catch (Exception ex)
			{
				if (this.m_constructionException == null)
				{
					this.m_constructionException = ex;
				}
				this.ReportOutOfBandMessage("ERROR: Exception during construction of EventSource " + this.Name + ": " + ex.Message);
			}
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				for (EventCommandEventArgs eventCommandEventArgs = this.m_deferredCommands; eventCommandEventArgs != null; eventCommandEventArgs = eventCommandEventArgs.nextCommand)
				{
					this.DoCommand(eventCommandEventArgs);
				}
				if (this.m_constructionException == null)
				{
					this.m_completelyInited = true;
				}
			}
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x00154F44 File Offset: 0x00153144
		private static string GetName(Type eventSourceType, EventManifestOptions flags)
		{
			ArgumentNullException.ThrowIfNull(eventSourceType, "eventSourceType");
			EventSourceAttribute eventSourceAttribute = (EventSourceAttribute)EventSource.GetCustomAttributeHelper(eventSourceType, typeof(EventSourceAttribute), flags);
			if (eventSourceAttribute != null && eventSourceAttribute.Name != null)
			{
				return eventSourceAttribute.Name;
			}
			return eventSourceType.Name;
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x00154F8C File Offset: 0x0015318C
		private unsafe static Guid GenerateGuidFromName(string name)
		{
			ReadOnlySpan<byte> input = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.BABB0FF3A59F6738CDF14170DA56230D6528DC9D619C5860288B86A4E3B29D63), 16);
			byte[] bytes = Encoding.BigEndianUnicode.GetBytes(name);
			Sha1ForNonSecretPurposes sha1ForNonSecretPurposes = default(Sha1ForNonSecretPurposes);
			sha1ForNonSecretPurposes.Start();
			sha1ForNonSecretPurposes.Append(input);
			sha1ForNonSecretPurposes.Append(bytes);
			Array.Resize<byte>(ref bytes, 16);
			sha1ForNonSecretPurposes.Finish(bytes);
			bytes[7] = ((bytes[7] & 15) | 80);
			return new Guid(bytes);
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x00155000 File Offset: 0x00153200
		private unsafe static void DecodeObjects(object[] decodedObjects, Type[] parameterTypes, EventSource.EventData* data)
		{
			int i = 0;
			while (i < decodedObjects.Length)
			{
				IntPtr dataPointer = data->DataPointer;
				Type type = parameterTypes[i];
				if (type == typeof(string))
				{
					goto IL_233;
				}
				object obj;
				if (type == typeof(int))
				{
					obj = *dataPointer;
				}
				else
				{
					TypeCode typeCode = Type.GetTypeCode(type);
					int size = data->Size;
					if (size == 4)
					{
						if (typeCode - TypeCode.SByte <= 4)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.UInt32)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.Single)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.Boolean)
						{
							obj = (*dataPointer == 1);
							goto IL_250;
						}
						if (type == typeof(byte[]))
						{
							data++;
							goto IL_1FF;
						}
						if (8 != 4)
						{
							goto IL_1ED;
						}
					}
					if (size <= 2)
					{
						if (typeCode == TypeCode.Byte)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.SByte)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.Int16)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.UInt16)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.Char)
						{
							obj = (char)(*dataPointer);
							goto IL_250;
						}
						goto IL_1ED;
					}
					else if (size == 8)
					{
						if (typeCode == TypeCode.Int64)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.UInt64)
						{
							obj = (ulong)(*dataPointer);
							goto IL_250;
						}
						if (typeCode == TypeCode.Double)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (typeCode == TypeCode.DateTime)
						{
							obj = DateTime.FromFileTimeUtc(*dataPointer);
							goto IL_250;
						}
						if (type == typeof(IntPtr))
						{
							obj = *dataPointer;
							goto IL_250;
						}
						goto IL_1ED;
					}
					else
					{
						if (typeCode == TypeCode.Decimal)
						{
							obj = *dataPointer;
							goto IL_250;
						}
						if (type == typeof(Guid))
						{
							obj = *dataPointer;
							goto IL_250;
						}
						goto IL_1ED;
					}
					IL_1FF:
					if (data->Size == 0)
					{
						obj = Array.Empty<byte>();
						goto IL_250;
					}
					byte[] array = new byte[data->Size];
					Marshal.Copy(data->DataPointer, array, 0, array.Length);
					obj = array;
					goto IL_250;
					IL_1ED:
					if (!(type != typeof(byte*)))
					{
						goto IL_1FF;
					}
					goto IL_233;
				}
				IL_250:
				decodedObjects[i] = obj;
				i++;
				data++;
				continue;
				IL_233:
				obj = ((dataPointer == IntPtr.Zero) ? null : new string(dataPointer, 0, (data->Size >> 1) - 1));
				goto IL_250;
			}
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x00155278 File Offset: 0x00153478
		[Conditional("DEBUG")]
		private unsafe static void AssertValidString(EventSource.EventData* data)
		{
			char* dataPointer = data->DataPointer;
			int num = data->Size / 2 - 1;
			for (int i = 0; i < num; i++)
			{
			}
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x001552A4 File Offset: 0x001534A4
		private EventDispatcher GetDispatcher(EventListener listener)
		{
			EventDispatcher eventDispatcher;
			for (eventDispatcher = this.m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
			{
				if (eventDispatcher.m_Listener == listener)
				{
					return eventDispatcher;
				}
			}
			return eventDispatcher;
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x001552D4 File Offset: 0x001534D4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		private unsafe void WriteEventVarargs(int eventId, Guid* childActivityID, object[] args)
		{
			if (this.IsEnabled())
			{
				try
				{
					ref EventSource.EventMetadata ptr = ref this.m_eventData[eventId];
					if (childActivityID != null && !ptr.HasRelatedActivityID)
					{
						throw new ArgumentException(SR.EventSource_NoRelatedActivityId);
					}
					this.LogEventArgsMismatches(eventId, args);
					Guid* ptr2 = null;
					Guid empty = Guid.Empty;
					Guid empty2 = Guid.Empty;
					EventOpcode opcode = (EventOpcode)ptr.Descriptor.Opcode;
					EventActivityOptions activityOptions = ptr.ActivityOptions;
					if (childActivityID == null && (activityOptions & EventActivityOptions.Disable) == EventActivityOptions.None)
					{
						if (opcode == EventOpcode.Start)
						{
							this.m_activityTracker.OnStart(this.m_name, ptr.Name, ptr.Descriptor.Task, ref empty, ref empty2, ptr.ActivityOptions, true);
						}
						else if (opcode == EventOpcode.Stop)
						{
							this.m_activityTracker.OnStop(this.m_name, ptr.Name, ptr.Descriptor.Task, ref empty, true);
						}
						if (empty != Guid.Empty)
						{
							ptr2 = &empty;
						}
						if (empty2 != Guid.Empty)
						{
							childActivityID = &empty2;
						}
					}
					if (ptr.EnabledForETW || ptr.EnabledForEventPipe)
					{
						if (!this.SelfDescribingEvents)
						{
							if (!this.m_etwProvider.WriteEvent(ref ptr.Descriptor, ptr.EventHandle, ptr2, childActivityID, args))
							{
								this.ThrowEventSourceException(ptr.Name, null);
							}
							if (!this.m_eventPipeProvider.WriteEvent(ref ptr.Descriptor, ptr.EventHandle, ptr2, childActivityID, args))
							{
								this.ThrowEventSourceException(ptr.Name, null);
							}
						}
						else
						{
							EventSourceOptions eventSourceOptions = new EventSourceOptions
							{
								Keywords = (EventKeywords)ptr.Descriptor.Keywords,
								Level = (EventLevel)ptr.Descriptor.Level,
								Opcode = (EventOpcode)ptr.Descriptor.Opcode
							};
							this.WriteMultiMerge(ptr.Name, ref eventSourceOptions, ptr.TraceLoggingEventTypes, ptr2, childActivityID, args);
						}
					}
					if (this.m_Dispatchers != null && ptr.EnabledForAnyListener)
					{
						if (!LocalAppContextSwitches.PreserveEventListenerObjectIdentity)
						{
							args = this.SerializeEventArgs(eventId, args);
						}
						EventWrittenEventArgs eventCallbackArgs = new EventWrittenEventArgs(this, eventId, ptr2, childActivityID)
						{
							Payload = new ReadOnlyCollection<object>(args)
						};
						this.DispatchToAllListeners(eventCallbackArgs);
					}
				}
				catch (Exception ex)
				{
					if (ex is EventSourceException)
					{
						throw;
					}
					this.ThrowEventSourceException(this.m_eventData[eventId].Name, ex);
				}
			}
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x00155528 File Offset: 0x00153728
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		private object[] SerializeEventArgs(int eventId, object[] args)
		{
			TraceLoggingEventTypes traceLoggingEventTypes = this.m_eventData[eventId].TraceLoggingEventTypes;
			int num = Math.Min(traceLoggingEventTypes.typeInfos.Length, args.Length);
			object[] array = new object[traceLoggingEventTypes.typeInfos.Length];
			for (int i = 0; i < num; i++)
			{
				array[i] = traceLoggingEventTypes.typeInfos[i].GetData(args[i]);
			}
			return array;
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x00155588 File Offset: 0x00153788
		private void LogEventArgsMismatches(int eventId, object[] args)
		{
			ParameterInfo[] parameters = this.m_eventData[eventId].Parameters;
			if (args.Length != parameters.Length)
			{
				this.ReportOutOfBandMessage(SR.Format(SR.EventSource_EventParametersMismatch, eventId, args.Length, parameters.Length));
				return;
			}
			for (int i = 0; i < args.Length; i++)
			{
				Type parameterType = parameters[i].ParameterType;
				object obj = args[i];
				if ((obj != null && !parameterType.IsAssignableFrom(obj.GetType())) || (obj == null && parameterType.IsValueType && (!parameterType.IsGenericType || !(parameterType.GetGenericTypeDefinition() == typeof(Nullable<>)))))
				{
					this.ReportOutOfBandMessage(SR.Format(SR.EventSource_VarArgsParameterMismatch, eventId, parameters[i].Name));
					return;
				}
			}
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x00155650 File Offset: 0x00153850
		private unsafe void WriteToAllListeners(EventWrittenEventArgs eventCallbackArgs, int eventDataCount, EventSource.EventData* data)
		{
			ref EventSource.EventMetadata ptr = ref this.m_eventData[eventCallbackArgs.EventId];
			if (eventDataCount != ptr.EventListenerParameterCount)
			{
				this.ReportOutOfBandMessage(SR.Format(SR.EventSource_EventParametersMismatch, eventCallbackArgs.EventId, eventDataCount, ptr.Parameters.Length));
			}
			if (eventDataCount == 0)
			{
				eventCallbackArgs.Payload = ReadOnlyCollection<object>.Empty;
			}
			else
			{
				object[] array = new object[Math.Min(eventDataCount, ptr.Parameters.Length)];
				if (ptr.AllParametersAreString)
				{
					int i = 0;
					while (i < array.Length)
					{
						IntPtr dataPointer = data->DataPointer;
						array[i] = ((dataPointer == IntPtr.Zero) ? null : new string(dataPointer, 0, (data->Size >> 1) - 1));
						i++;
						data++;
					}
				}
				else if (ptr.AllParametersAreInt32)
				{
					int j = 0;
					while (j < array.Length)
					{
						array[j] = *data->DataPointer;
						j++;
						data++;
					}
				}
				else
				{
					EventSource.DecodeObjects(array, ptr.ParameterTypes, data);
				}
				eventCallbackArgs.Payload = new ReadOnlyCollection<object>(array);
			}
			this.DispatchToAllListeners(eventCallbackArgs);
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x00155770 File Offset: 0x00153970
		internal void DispatchToAllListeners(EventWrittenEventArgs eventCallbackArgs)
		{
			int eventId = eventCallbackArgs.EventId;
			Exception ex = null;
			for (EventDispatcher eventDispatcher = this.m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
			{
				if (eventId == -1 || eventDispatcher.m_EventEnabled[eventId])
				{
					try
					{
						eventDispatcher.m_Listener.OnEventWritten(eventCallbackArgs);
					}
					catch (Exception ex2)
					{
						this.ReportOutOfBandMessage("ERROR: Exception during EventSource.OnEventWritten: " + ex2.Message);
						ex = ex2;
					}
				}
			}
			if (ex != null && this.ThrowOnEventWriteErrors)
			{
				throw new EventSourceException(ex);
			}
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x001557F8 File Offset: 0x001539F8
		private unsafe void WriteEventString(string msgString)
		{
			if (this.m_etwProvider == null & this.m_eventPipeProvider == null)
			{
				return;
			}
			EventLevel eventLevel = EventLevel.LogAlways;
			long keywords = -1L;
			if (this.SelfDescribingEvents)
			{
				EventSourceOptions eventSourceOptions = new EventSourceOptions
				{
					Keywords = (EventKeywords)keywords,
					Level = eventLevel
				};
				TraceLoggingEventTypes eventTypes = EventSource.<WriteEventString>g__GetTrimSafeTraceLoggingEventTypes|111_0();
				this.WriteMultiMergeInner("EventSourceMessage", ref eventSourceOptions, eventTypes, null, null, new object[]
				{
					msgString
				});
				return;
			}
			if (this.m_rawManifest == null && this.m_outOfBandMessageCount == 1)
			{
				ManifestBuilder manifestBuilder = new ManifestBuilder(this.Name, this.Guid, this.Name, null, EventManifestOptions.None);
				manifestBuilder.StartEvent("EventSourceMessage", new EventAttribute(0)
				{
					Level = eventLevel,
					Task = (EventTask)65534
				});
				manifestBuilder.AddEventParameter(typeof(string), "message");
				manifestBuilder.EndEvent();
				this.SendManifest(manifestBuilder.CreateManifest());
			}
			char* ptr;
			if (msgString == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = msgString.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = ptr;
			EventDescriptor eventDescriptor = new EventDescriptor(0, 0, 0, (byte)eventLevel, 0, 0, keywords);
			EventProvider.EventData eventData = default(EventProvider.EventData);
			eventData.Ptr = ptr3;
			eventData.Size = (uint)(2 * (msgString.Length + 1));
			eventData.Reserved = 0U;
			EventSource.OverrideEventProvider etwProvider = this.m_etwProvider;
			if (etwProvider != null)
			{
				etwProvider.WriteEvent(ref eventDescriptor, IntPtr.Zero, null, null, 1, &eventData);
			}
			if (this.m_eventPipeProvider != null)
			{
				if (this.m_writeEventStringEventHandle == IntPtr.Zero)
				{
					if (this.m_createEventLock == null)
					{
						Interlocked.CompareExchange(ref this.m_createEventLock, new object(), null);
					}
					object createEventLock = this.m_createEventLock;
					lock (createEventLock)
					{
						if (this.m_writeEventStringEventHandle == IntPtr.Zero)
						{
							string eventName = "EventSourceMessage";
							EventParameterInfo eventParameterInfo = default(EventParameterInfo);
							eventParameterInfo.SetInfo("message", typeof(string), null);
							byte[] array = EventPipeMetadataGenerator.Instance.GenerateMetadata(0, eventName, keywords, (uint)eventLevel, 0U, EventOpcode.Info, new EventParameterInfo[]
							{
								eventParameterInfo
							});
							uint metadataLength = (uint)((array != null) ? array.Length : 0);
							byte[] array2;
							byte* pMetadata;
							if ((array2 = array) == null || array2.Length == 0)
							{
								pMetadata = null;
							}
							else
							{
								pMetadata = &array2[0];
							}
							this.m_writeEventStringEventHandle = this.m_eventPipeProvider._eventProvider.DefineEventHandle(0U, eventName, keywords, 0U, (uint)eventLevel, pMetadata, metadataLength);
							array2 = null;
						}
					}
				}
				this.m_eventPipeProvider.WriteEvent(ref eventDescriptor, this.m_writeEventStringEventHandle, null, null, 1, &eventData);
			}
			char* ptr2 = null;
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x00155A8C File Offset: 0x00153C8C
		private void WriteStringToAllListeners(string eventName, string msg)
		{
			EventWrittenEventArgs eventWrittenEventArgs = new EventWrittenEventArgs(this, 0);
			eventWrittenEventArgs.EventName = eventName;
			eventWrittenEventArgs.Message = msg;
			eventWrittenEventArgs.Payload = new ReadOnlyCollection<object>(new object[]
			{
				msg
			});
			EventWrittenEventArgs eventWrittenEventArgs2 = eventWrittenEventArgs;
			ReadOnlyCollection<string> payloadNames;
			if ((payloadNames = EventSource.s_errorPayloadNames) == null)
			{
				payloadNames = (EventSource.s_errorPayloadNames = new ReadOnlyCollection<string>(new string[]
				{
					"message"
				}));
			}
			eventWrittenEventArgs2.PayloadNames = payloadNames;
			EventWrittenEventArgs eventData = eventWrittenEventArgs;
			for (EventDispatcher eventDispatcher = this.m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
			{
				bool flag = false;
				if (eventDispatcher.m_EventEnabled == null)
				{
					flag = true;
				}
				else
				{
					for (int i = 0; i < eventDispatcher.m_EventEnabled.Length; i++)
					{
						if (eventDispatcher.m_EventEnabled[i])
						{
							flag = true;
							break;
						}
					}
				}
				try
				{
					if (flag)
					{
						eventDispatcher.m_Listener.OnEventWritten(eventData);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x00155B5C File Offset: 0x00153D5C
		private bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword)
		{
			if (!enable)
			{
				return false;
			}
			EventLevel level = (EventLevel)this.m_eventData[eventNum].Descriptor.Level;
			EventKeywords eventKeywords = (EventKeywords)(this.m_eventData[eventNum].Descriptor.Keywords & (long)(~(long)SessionMask.All.ToEventKeywords()));
			EventChannel channel = (EventChannel)this.m_eventData[eventNum].Descriptor.Channel;
			return this.IsEnabledCommon(enable, currentLevel, currentMatchAnyKeyword, level, eventKeywords, channel);
		}

		// Token: 0x06008C2F RID: 35887 RVA: 0x00155BD8 File Offset: 0x00153DD8
		private bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel)
		{
			if (!enabled)
			{
				return false;
			}
			if (currentLevel != EventLevel.LogAlways && currentLevel < eventLevel)
			{
				return false;
			}
			if (currentMatchAnyKeyword != EventKeywords.None && eventKeywords != EventKeywords.None)
			{
				if (eventChannel != EventChannel.None && this.m_channelData != null && this.m_channelData.Length > (int)eventChannel)
				{
					EventKeywords eventKeywords2 = (EventKeywords)(this.m_channelData[(int)eventChannel] | (ulong)eventKeywords);
					if (eventKeywords2 != EventKeywords.None && (eventKeywords2 & currentMatchAnyKeyword) == EventKeywords.None)
					{
						return false;
					}
				}
				else if ((eventKeywords & currentMatchAnyKeyword) == EventKeywords.None)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x00155C3C File Offset: 0x00153E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ThrowEventSourceException(string eventName, Exception innerEx = null)
		{
			if (EventSource.m_EventSourceExceptionRecurenceCount > 0)
			{
				return;
			}
			try
			{
				EventSource.m_EventSourceExceptionRecurenceCount += 1;
				string text = "EventSourceException";
				if (eventName != null)
				{
					text = text + " while processing event \"" + eventName + "\"";
				}
				switch (EventProvider.GetLastWriteEventError())
				{
				case EventProvider.WriteEventErrorCode.NoFreeBuffers:
					this.ReportOutOfBandMessage(text + ": " + SR.EventSource_NoFreeBuffers);
					if (this.ThrowOnEventWriteErrors)
					{
						throw new EventSourceException(SR.EventSource_NoFreeBuffers, innerEx);
					}
					break;
				case EventProvider.WriteEventErrorCode.EventTooBig:
					this.ReportOutOfBandMessage(text + ": " + SR.EventSource_EventTooBig);
					if (this.ThrowOnEventWriteErrors)
					{
						throw new EventSourceException(SR.EventSource_EventTooBig, innerEx);
					}
					break;
				case EventProvider.WriteEventErrorCode.NullInput:
					this.ReportOutOfBandMessage(text + ": " + SR.EventSource_NullInput);
					if (this.ThrowOnEventWriteErrors)
					{
						throw new EventSourceException(SR.EventSource_NullInput, innerEx);
					}
					break;
				case EventProvider.WriteEventErrorCode.TooManyArgs:
					this.ReportOutOfBandMessage(text + ": " + SR.EventSource_TooManyArgs);
					if (this.ThrowOnEventWriteErrors)
					{
						throw new EventSourceException(SR.EventSource_TooManyArgs, innerEx);
					}
					break;
				default:
					if (innerEx != null)
					{
						innerEx = innerEx.GetBaseException();
						string[] array = new string[5];
						array[0] = text;
						array[1] = ": ";
						int num = 2;
						Type type = innerEx.GetType();
						array[num] = ((type != null) ? type.ToString() : null);
						array[3] = ":";
						array[4] = innerEx.Message;
						this.ReportOutOfBandMessage(string.Concat(array));
					}
					else
					{
						this.ReportOutOfBandMessage(text);
					}
					if (this.ThrowOnEventWriteErrors)
					{
						throw new EventSourceException(innerEx);
					}
					break;
				}
			}
			finally
			{
				EventSource.m_EventSourceExceptionRecurenceCount -= 1;
			}
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x00155DE4 File Offset: 0x00153FE4
		internal static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName)
		{
			if (opcode == EventOpcode.Info && eventName != null)
			{
				if (eventName.EndsWith("Start", StringComparison.Ordinal))
				{
					return EventOpcode.Start;
				}
				if (eventName.EndsWith("Stop", StringComparison.Ordinal))
				{
					return EventOpcode.Stop;
				}
			}
			return opcode;
		}

		// Token: 0x06008C32 RID: 35890 RVA: 0x00155E10 File Offset: 0x00154010
		internal void SendCommand(EventListener listener, EventProviderType eventProviderType, int perEventSourceSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments)
		{
			if (!EventSource.IsSupported)
			{
				return;
			}
			EventCommandEventArgs eventCommandEventArgs = new EventCommandEventArgs(command, commandArguments, this, listener, eventProviderType, perEventSourceSessionId, enable, level, matchAnyKeyword);
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				if (this.m_completelyInited)
				{
					this.m_deferredCommands = null;
					this.DoCommand(eventCommandEventArgs);
				}
				else if (this.m_deferredCommands == null)
				{
					this.m_deferredCommands = eventCommandEventArgs;
				}
				else
				{
					EventCommandEventArgs eventCommandEventArgs2 = this.m_deferredCommands;
					while (eventCommandEventArgs2.nextCommand != null)
					{
						eventCommandEventArgs2 = eventCommandEventArgs2.nextCommand;
					}
					eventCommandEventArgs2.nextCommand = eventCommandEventArgs;
				}
			}
		}

		// Token: 0x06008C33 RID: 35891 RVA: 0x00155EB0 File Offset: 0x001540B0
		internal void DoCommand(EventCommandEventArgs commandArgs)
		{
			if (!EventSource.IsSupported)
			{
				return;
			}
			if (this.m_etwProvider == null)
			{
				return;
			}
			if (this.m_eventPipeProvider == null)
			{
				return;
			}
			this.m_outOfBandMessageCount = 0;
			try
			{
				this.EnsureDescriptorsInitialized();
				commandArgs.dispatcher = this.GetDispatcher(commandArgs.listener);
				if (commandArgs.dispatcher == null && commandArgs.listener != null)
				{
					throw new ArgumentException(SR.EventSource_ListenerNotFound);
				}
				if (commandArgs.Arguments == null)
				{
					commandArgs.Arguments = new Dictionary<string, string>();
				}
				if (commandArgs.Command == EventCommand.Update)
				{
					for (int i = 0; i < this.m_eventData.Length; i++)
					{
						this.EnableEventForDispatcher(commandArgs.dispatcher, commandArgs.eventProviderType, i, this.IsEnabledByDefault(i, commandArgs.enable, commandArgs.level, commandArgs.matchAnyKeyword));
					}
					if (commandArgs.enable)
					{
						if (!this.m_eventSourceEnabled)
						{
							this.m_level = commandArgs.level;
							this.m_matchAnyKeyword = commandArgs.matchAnyKeyword;
						}
						else
						{
							if (commandArgs.level > this.m_level)
							{
								this.m_level = commandArgs.level;
							}
							if (commandArgs.matchAnyKeyword == EventKeywords.None)
							{
								this.m_matchAnyKeyword = EventKeywords.None;
							}
							else if (this.m_matchAnyKeyword != EventKeywords.None)
							{
								this.m_matchAnyKeyword |= commandArgs.matchAnyKeyword;
							}
						}
					}
					bool flag = commandArgs.perEventSourceSessionId >= 0;
					if (commandArgs.perEventSourceSessionId == 0 && !commandArgs.enable)
					{
						flag = false;
					}
					if (commandArgs.listener == null)
					{
						if (!flag)
						{
							commandArgs.perEventSourceSessionId = -commandArgs.perEventSourceSessionId;
						}
						commandArgs.perEventSourceSessionId--;
					}
					commandArgs.Command = (flag ? EventCommand.Enable : EventCommand.Disable);
					if (flag && commandArgs.dispatcher == null && !this.SelfDescribingEvents)
					{
						this.SendManifest(this.m_rawManifest);
					}
					if (commandArgs.enable)
					{
						this.m_eventSourceEnabled = true;
					}
					if (!commandArgs.enable)
					{
						for (int j = 0; j < this.m_eventData.Length; j++)
						{
							bool enabledForAnyListener = false;
							for (EventDispatcher eventDispatcher = this.m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
							{
								if (eventDispatcher.m_EventEnabled[j])
								{
									enabledForAnyListener = true;
									break;
								}
							}
							this.m_eventData[j].EnabledForAnyListener = enabledForAnyListener;
						}
						if (!this.AnyEventEnabled())
						{
							this.m_level = EventLevel.LogAlways;
							this.m_matchAnyKeyword = EventKeywords.None;
							this.m_eventSourceEnabled = false;
						}
					}
					this.OnEventCommand(commandArgs);
					EventHandler<EventCommandEventArgs> eventCommandExecuted = this.m_eventCommandExecuted;
					if (eventCommandExecuted != null)
					{
						eventCommandExecuted(this, commandArgs);
					}
				}
				else
				{
					if (commandArgs.Command == EventCommand.SendManifest && this.m_rawManifest != null)
					{
						this.SendManifest(this.m_rawManifest);
					}
					this.OnEventCommand(commandArgs);
					EventHandler<EventCommandEventArgs> eventCommandExecuted2 = this.m_eventCommandExecuted;
					if (eventCommandExecuted2 != null)
					{
						eventCommandExecuted2(this, commandArgs);
					}
				}
			}
			catch (Exception ex)
			{
				this.ReportOutOfBandMessage("ERROR: Exception in Command Processing for EventSource " + this.Name + ": " + ex.Message);
			}
		}

		// Token: 0x06008C34 RID: 35892 RVA: 0x0015618C File Offset: 0x0015438C
		internal bool EnableEventForDispatcher(EventDispatcher dispatcher, EventProviderType eventProviderType, int eventId, bool value)
		{
			if (!EventSource.IsSupported)
			{
				return false;
			}
			if (dispatcher == null)
			{
				if (eventId >= this.m_eventData.Length)
				{
					return false;
				}
				if (this.m_etwProvider != null && eventProviderType == EventProviderType.ETW)
				{
					this.m_eventData[eventId].EnabledForETW = value;
				}
				if (this.m_eventPipeProvider != null && eventProviderType == EventProviderType.EventPipe)
				{
					this.m_eventData[eventId].EnabledForEventPipe = value;
				}
			}
			else
			{
				if (eventId >= dispatcher.m_EventEnabled.Length)
				{
					return false;
				}
				dispatcher.m_EventEnabled[eventId] = value;
				if (value)
				{
					this.m_eventData[eventId].EnabledForAnyListener = true;
				}
			}
			return true;
		}

		// Token: 0x06008C35 RID: 35893 RVA: 0x0015622C File Offset: 0x0015442C
		private bool AnyEventEnabled()
		{
			for (int i = 0; i < this.m_eventData.Length; i++)
			{
				if (this.m_eventData[i].EnabledForETW || this.m_eventData[i].EnabledForAnyListener || this.m_eventData[i].EnabledForEventPipe)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06008C36 RID: 35894 RVA: 0x00156290 File Offset: 0x00154490
		private bool IsDisposed
		{
			get
			{
				return this.m_eventSourceDisposed;
			}
		}

		// Token: 0x06008C37 RID: 35895 RVA: 0x00156298 File Offset: 0x00154498
		private void EnsureDescriptorsInitialized()
		{
			if (this.m_eventData == null)
			{
				this.m_rawManifest = EventSource.CreateManifestAndDescriptors(base.GetType(), this.Name, this, EventManifestOptions.None);
				if (!EventSource.AllowDuplicateSourceNames)
				{
					using (List<WeakReference<EventSource>>.Enumerator enumerator = EventListener.s_EventSources.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							EventSource eventSource;
							if (enumerator.Current.TryGetTarget(out eventSource) && eventSource.Guid == this.m_guid && !eventSource.IsDisposed && eventSource != this)
							{
								throw new ArgumentException(SR.Format(SR.EventSource_EventSourceGuidInUse, this.m_guid));
							}
						}
					}
				}
				for (EventDispatcher eventDispatcher = this.m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
				{
					EventDispatcher eventDispatcher2 = eventDispatcher;
					if (eventDispatcher2.m_EventEnabled == null)
					{
						eventDispatcher2.m_EventEnabled = new bool[this.m_eventData.Length];
					}
				}
				this.DefineEventPipeEvents();
			}
		}

		// Token: 0x06008C38 RID: 35896 RVA: 0x00156390 File Offset: 0x00154590
		private unsafe void SendManifest(byte[] rawManifest)
		{
			if (rawManifest == null)
			{
				return;
			}
			fixed (byte[] array = rawManifest)
			{
				byte* ptr;
				if (rawManifest == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				EventDescriptor eventDescriptor = new EventDescriptor(65534, 1, 0, 0, 254, 65534, 72057594037927935L);
				ManifestEnvelope manifestEnvelope = default(ManifestEnvelope);
				manifestEnvelope.Format = ManifestEnvelope.ManifestFormats.SimpleXmlFormat;
				manifestEnvelope.MajorVersion = 1;
				manifestEnvelope.MinorVersion = 0;
				manifestEnvelope.Magic = 91;
				int i = rawManifest.Length;
				manifestEnvelope.ChunkNumber = 0;
				EventProvider.EventData* ptr2 = stackalloc EventProvider.EventData[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(EventProvider.EventData))];
				ptr2->Ptr = &manifestEnvelope;
				ptr2->Size = (uint)sizeof(ManifestEnvelope);
				ptr2->Reserved = 0U;
				ptr2[1].Ptr = ptr;
				ptr2[1].Reserved = 0U;
				int num = 63232;
				for (;;)
				{
					IL_C7:
					manifestEnvelope.TotalChunks = (ushort)((i + (num - 1)) / num);
					while (i > 0)
					{
						ptr2[1].Size = (uint)Math.Min(i, num);
						if (this.m_etwProvider != null && !this.m_etwProvider.WriteEvent(ref eventDescriptor, IntPtr.Zero, null, null, 2, ptr2))
						{
							if (EventProvider.GetLastWriteEventError() == EventProvider.WriteEventErrorCode.EventTooBig && manifestEnvelope.ChunkNumber == 0 && num > 256)
							{
								num /= 2;
								goto IL_C7;
							}
							goto IL_13D;
						}
						else
						{
							i -= num;
							ptr2[1].Ptr += (ulong)num;
							manifestEnvelope.ChunkNumber += 1;
							if (manifestEnvelope.ChunkNumber % 5 == 0)
							{
								Thread.Sleep(15);
							}
						}
					}
					goto IL_195;
				}
				IL_13D:
				if (this.ThrowOnEventWriteErrors)
				{
					this.ThrowEventSourceException("SendManifest", null);
				}
				IL_195:;
			}
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x00156534 File Offset: 0x00154734
		internal static bool IsCustomAttributeDefinedHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = EventManifestOptions.None)
		{
			if (!member.Module.Assembly.ReflectionOnly && (flags & EventManifestOptions.AllowEventSourceOverride) == EventManifestOptions.None)
			{
				return member.IsDefined(attributeType, false);
			}
			foreach (CustomAttributeData customAttributeData in CustomAttributeData.GetCustomAttributes(member))
			{
				if (EventSource.AttributeTypeNamesMatch(attributeType, customAttributeData.Constructor.ReflectedType))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x001565B4 File Offset: 0x001547B4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2114:ReflectionToDynamicallyAccessedMembers", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which has dynamically accessed members requirements, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		internal static Attribute GetCustomAttributeHelper(MemberInfo member, [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)515)] Type attributeType, EventManifestOptions flags = EventManifestOptions.None)
		{
			if (!member.Module.Assembly.ReflectionOnly && (flags & EventManifestOptions.AllowEventSourceOverride) == EventManifestOptions.None)
			{
				return member.GetCustomAttribute(attributeType, false);
			}
			foreach (CustomAttributeData customAttributeData in CustomAttributeData.GetCustomAttributes(member))
			{
				if (EventSource.AttributeTypeNamesMatch(attributeType, customAttributeData.Constructor.ReflectedType))
				{
					Attribute attribute = null;
					if (customAttributeData.ConstructorArguments.Count == 1)
					{
						attribute = (Attribute)Activator.CreateInstance(attributeType, new object[]
						{
							customAttributeData.ConstructorArguments[0].Value
						});
					}
					else if (customAttributeData.ConstructorArguments.Count == 0)
					{
						attribute = (Attribute)Activator.CreateInstance(attributeType);
					}
					if (attribute != null)
					{
						foreach (CustomAttributeNamedArgument customAttributeNamedArgument in customAttributeData.NamedArguments)
						{
							PropertyInfo property = attributeType.GetProperty(customAttributeNamedArgument.MemberInfo.Name, BindingFlags.Instance | BindingFlags.Public);
							object obj = customAttributeNamedArgument.TypedValue.Value;
							if (property.PropertyType.IsEnum)
							{
								string value = obj.ToString();
								obj = Enum.Parse(property.PropertyType, value);
							}
							property.SetValue(attribute, obj, null);
						}
						return attribute;
					}
				}
			}
			return null;
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x00156748 File Offset: 0x00154948
		private static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType)
		{
			return attributeType == reflectedAttributeType || string.Equals(attributeType.FullName, reflectedAttributeType.FullName, StringComparison.Ordinal) || (string.Equals(attributeType.Name, reflectedAttributeType.Name, StringComparison.Ordinal) && attributeType.Namespace.EndsWith("Diagnostics.Tracing", StringComparison.Ordinal) && reflectedAttributeType.Namespace.EndsWith("Diagnostics.Tracing", StringComparison.Ordinal));
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x001567B0 File Offset: 0x001549B0
		private static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly)
		{
			Type type = eventSourceType;
			if (type.BaseType == null)
			{
				return null;
			}
			do
			{
				type = type.BaseType;
			}
			while (type != null && type.IsAbstract);
			if (type != null)
			{
				if (!allowEventSourceOverride)
				{
					if ((reflectionOnly && type.FullName != typeof(EventSource).FullName) || (!reflectionOnly && type != typeof(EventSource)))
					{
						return null;
					}
				}
				else if (type.Name != "EventSource")
				{
					return null;
				}
			}
			return type;
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x00156840 File Offset: 0x00154A40
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2114:ReflectionToDynamicallyAccessedMembers", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which has dynamically accessed members requirements, but its use of this method satisfies these requirements because it passes in the result of GetType with the same annotations.")]
		private unsafe static byte[] CreateManifestAndDescriptors([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = EventManifestOptions.None)
		{
			ManifestBuilder manifestBuilder = null;
			bool flag = source == null || !source.SelfDescribingEvents;
			Exception ex = null;
			byte[] array = null;
			if (eventSourceType.IsAbstract && (flags & EventManifestOptions.Strict) == EventManifestOptions.None)
			{
				return null;
			}
			try
			{
				MethodInfo[] methods = eventSourceType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				int num = 1;
				EventSource.EventMetadata[] array2 = null;
				Dictionary<string, string> dictionary = null;
				if (source != null || (flags & EventManifestOptions.Strict) != EventManifestOptions.None)
				{
					array2 = new EventSource.EventMetadata[methods.Length + 1];
					array2[0].Name = "";
				}
				ResourceManager resources = null;
				EventSourceAttribute eventSourceAttribute = (EventSourceAttribute)EventSource.GetCustomAttributeHelper(eventSourceType, typeof(EventSourceAttribute), flags);
				if (eventSourceAttribute != null && eventSourceAttribute.LocalizationResources != null)
				{
					resources = new ResourceManager(eventSourceAttribute.LocalizationResources, eventSourceType.Assembly);
				}
				if (((source != null) ? source.GetType() : null) == typeof(NativeRuntimeEventSource))
				{
					manifestBuilder = new ManifestBuilder(resources, flags);
					flag = false;
				}
				else
				{
					string providerName = ((source != null) ? source.Name : null) ?? EventSource.GetName(eventSourceType, flags);
					Guid providerGuid = (source != null) ? source.Guid : EventSource.GetGuid(eventSourceType);
					manifestBuilder = new ManifestBuilder(providerName, providerGuid, eventSourceDllName, resources, flags);
				}
				manifestBuilder.StartEvent("EventSourceMessage", new EventAttribute(0)
				{
					Level = EventLevel.LogAlways,
					Task = (EventTask)65534
				});
				manifestBuilder.AddEventParameter(typeof(string), "message");
				manifestBuilder.EndEvent();
				if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None)
				{
					if (!(EventSource.GetEventSourceBaseType(eventSourceType, (flags & EventManifestOptions.AllowEventSourceOverride) > EventManifestOptions.None, eventSourceType.Assembly.ReflectionOnly) != null))
					{
						manifestBuilder.ManifestError(SR.EventSource_TypeMustDeriveFromEventSource, false);
					}
					if (!eventSourceType.IsAbstract && !eventSourceType.IsSealed)
					{
						manifestBuilder.ManifestError(SR.EventSource_TypeMustBeSealedOrAbstract, false);
					}
				}
				<>y__InlineArray3<string> <>y__InlineArray = default(<>y__InlineArray3<string>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<string>, string>(ref <>y__InlineArray, 0) = "Keywords";
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<string>, string>(ref <>y__InlineArray, 1) = "Tasks";
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<string>, string>(ref <>y__InlineArray, 2) = "Opcodes";
				ReadOnlySpan<string> readOnlySpan = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<string>, string>(<>y__InlineArray, 3);
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					string text = *readOnlySpan[i];
					Type nestedType = eventSourceType.GetNestedType(text);
					if (nestedType != null)
					{
						if (eventSourceType.IsAbstract)
						{
							manifestBuilder.ManifestError(SR.Format(SR.EventSource_AbstractMustNotDeclareKTOC, nestedType.Name), false);
						}
						else
						{
							foreach (FieldInfo staticField in nestedType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
							{
								EventSource.AddProviderEnumKind(manifestBuilder, staticField, text);
							}
						}
					}
				}
				manifestBuilder.AddKeyword("Session3", 17592186044416UL);
				manifestBuilder.AddKeyword("Session2", 35184372088832UL);
				manifestBuilder.AddKeyword("Session1", 70368744177664UL);
				manifestBuilder.AddKeyword("Session0", 140737488355328UL);
				if (eventSourceType != typeof(EventSource))
				{
					foreach (MethodInfo methodInfo in methods)
					{
						if (!methodInfo.IsStatic)
						{
							EventAttribute eventAttribute = (EventAttribute)EventSource.GetCustomAttributeHelper(methodInfo, typeof(EventAttribute), flags);
							if (eventSourceType.IsAbstract)
							{
								if (eventAttribute != null)
								{
									manifestBuilder.ManifestError(SR.Format(SR.EventSource_AbstractMustNotDeclareEventMethods, methodInfo.Name, eventAttribute.EventId), false);
								}
							}
							else
							{
								if (eventAttribute == null)
								{
									if (methodInfo.ReturnType != typeof(void) || methodInfo.IsVirtual || EventSource.IsCustomAttributeDefinedHelper(methodInfo, typeof(NonEventAttribute), flags))
									{
										goto IL_643;
									}
									eventAttribute = new EventAttribute(num);
								}
								else if (eventAttribute.EventId <= 0)
								{
									manifestBuilder.ManifestError(SR.EventSource_NeedPositiveId, true);
									goto IL_643;
								}
								if (methodInfo.Name.LastIndexOf('.') >= 0)
								{
									manifestBuilder.ManifestError(SR.Format(SR.EventSource_EventMustNotBeExplicitImplementation, methodInfo.Name, eventAttribute.EventId), false);
								}
								num++;
								string name = methodInfo.Name;
								if (eventAttribute.Opcode == EventOpcode.Info)
								{
									bool flag2 = eventAttribute.Task == EventTask.None;
									if (flag2)
									{
										eventAttribute.Task = (EventTask)65534 - eventAttribute.EventId;
									}
									if (!eventAttribute.IsOpcodeSet)
									{
										eventAttribute.Opcode = EventSource.GetOpcodeWithDefault(EventOpcode.Info, name);
									}
									if (flag2)
									{
										if (eventAttribute.Opcode == EventOpcode.Start)
										{
											if (name.EndsWith("Start", StringComparison.Ordinal))
											{
												string text2 = name;
												int i = "Start".Length;
												string name2 = text2.Substring(0, text2.Length - i);
												manifestBuilder.AddTask(name2, (int)eventAttribute.Task);
											}
										}
										else if (eventAttribute.Opcode == EventOpcode.Stop)
										{
											int num2 = eventAttribute.EventId - 1;
											if (array2 != null && num2 < array2.Length)
											{
												EventSource.EventMetadata eventMetadata = array2[num2];
												if (eventMetadata.Descriptor.Opcode == 1 && eventMetadata.Name.EndsWith("Start", StringComparison.Ordinal) && name.EndsWith("Stop", StringComparison.Ordinal))
												{
													ReadOnlySpan<char> readOnlySpan2 = eventMetadata.Name.AsSpan();
													ref ReadOnlySpan<char> ptr = ref readOnlySpan2;
													int i = "Start".Length;
													ReadOnlySpan<char> span = ptr.Slice(0, ptr.Length - i);
													ReadOnlySpan<char> readOnlySpan3 = name.AsSpan();
													ptr = ref readOnlySpan3;
													i = "Stop".Length;
													if (span.SequenceEqual(ptr.Slice(0, ptr.Length - i)))
													{
														eventAttribute.Task = (EventTask)eventMetadata.Descriptor.Task;
														flag2 = false;
													}
												}
											}
											if (flag2 && (flags & EventManifestOptions.Strict) != EventManifestOptions.None)
											{
												throw new ArgumentException(SR.EventSource_StopsFollowStarts);
											}
										}
									}
								}
								ParameterInfo[] parameters = methodInfo.GetParameters();
								bool hasRelatedActivityID = EventSource.RemoveFirstArgIfRelatedActivityId(ref parameters);
								if (source == null || !source.SelfDescribingEvents)
								{
									manifestBuilder.StartEvent(name, eventAttribute);
									for (int l = 0; l < parameters.Length; l++)
									{
										manifestBuilder.AddEventParameter(parameters[l].ParameterType, parameters[l].Name);
									}
									manifestBuilder.EndEvent();
								}
								if (source != null || (flags & EventManifestOptions.Strict) != EventManifestOptions.None)
								{
									EventSource.DebugCheckEvent(ref dictionary, array2, methodInfo, eventAttribute, manifestBuilder, flags);
									if (eventAttribute.Channel != EventChannel.None)
									{
										eventAttribute.Keywords |= (EventKeywords)manifestBuilder.GetChannelKeyword(eventAttribute.Channel, (ulong)eventAttribute.Keywords);
									}
									if (manifestBuilder.HasResources)
									{
										string key = "event_" + name;
										string localizedMessage = manifestBuilder.GetLocalizedMessage(key, CultureInfo.CurrentUICulture, false);
										if (localizedMessage != null)
										{
											eventAttribute.Message = localizedMessage;
										}
									}
									EventSource.AddEventDescriptor(ref array2, name, eventAttribute, parameters, hasRelatedActivityID);
								}
							}
						}
						IL_643:;
					}
				}
				NameInfo.ReserveEventIDsBelow(num);
				if (source != null)
				{
					EventSource.TrimEventDescriptors(ref array2);
					source.m_eventData = array2;
					source.m_channelData = manifestBuilder.GetChannelData();
				}
				if (!eventSourceType.IsAbstract && (source == null || !source.SelfDescribingEvents))
				{
					flag = ((flags & EventManifestOptions.OnlyIfNeededForRegistration) == EventManifestOptions.None || manifestBuilder.GetChannelData().Length != 0);
					if (!flag && (flags & EventManifestOptions.Strict) == EventManifestOptions.None)
					{
						return null;
					}
					array = manifestBuilder.CreateManifest();
					array = ((array.Length != 0) ? array : null);
				}
			}
			catch (Exception ex2)
			{
				if ((flags & EventManifestOptions.Strict) == EventManifestOptions.None)
				{
					throw;
				}
				ex = ex2;
			}
			if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None && ((manifestBuilder != null && manifestBuilder.Errors.Count > 0) || ex != null))
			{
				string text3 = string.Empty;
				if (manifestBuilder != null && manifestBuilder.Errors.Count > 0)
				{
					bool flag3 = true;
					using (IEnumerator<string> enumerator = manifestBuilder.Errors.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string str = enumerator.Current;
							if (!flag3)
							{
								text3 += "\r\n";
							}
							flag3 = false;
							text3 += str;
						}
						goto IL_76A;
					}
				}
				text3 = "Unexpected error: " + ex.Message;
				IL_76A:
				throw new ArgumentException(text3, ex);
			}
			if (!flag)
			{
				return null;
			}
			return array;
		}

		// Token: 0x06008C3E RID: 35902 RVA: 0x00157000 File Offset: 0x00155200
		private static bool RemoveFirstArgIfRelatedActivityId(ref ParameterInfo[] args)
		{
			if (args.Length != 0 && args[0].ParameterType == typeof(Guid) && string.Equals(args[0].Name, "relatedActivityId", StringComparison.OrdinalIgnoreCase))
			{
				ParameterInfo[] array = new ParameterInfo[args.Length - 1];
				Array.Copy(args, 1, array, 0, args.Length - 1);
				args = array;
				return true;
			}
			return false;
		}

		// Token: 0x06008C3F RID: 35903 RVA: 0x00157064 File Offset: 0x00155264
		private static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind)
		{
			bool reflectionOnly = staticField.Module.Assembly.ReflectionOnly;
			Type fieldType = staticField.FieldType;
			if ((!reflectionOnly && fieldType == typeof(EventOpcode)) || EventSource.AttributeTypeNamesMatch(fieldType, typeof(EventOpcode)))
			{
				if (!(providerEnumKind != "Opcodes"))
				{
					int value = (int)staticField.GetRawConstantValue();
					manifest.AddOpcode(staticField.Name, value);
					return;
				}
			}
			else
			{
				if ((reflectionOnly || !(fieldType == typeof(EventTask))) && !EventSource.AttributeTypeNamesMatch(fieldType, typeof(EventTask)))
				{
					if ((!reflectionOnly && fieldType == typeof(EventKeywords)) || EventSource.AttributeTypeNamesMatch(fieldType, typeof(EventKeywords)))
					{
						if (providerEnumKind != "Keywords")
						{
							goto IL_107;
						}
						ulong value2 = (ulong)((long)staticField.GetRawConstantValue());
						manifest.AddKeyword(staticField.Name, value2);
					}
					return;
				}
				if (!(providerEnumKind != "Tasks"))
				{
					int value3 = (int)staticField.GetRawConstantValue();
					manifest.AddTask(staticField.Name, value3);
					return;
				}
			}
			IL_107:
			manifest.ManifestError(SR.Format(SR.EventSource_EnumKindMismatch, staticField.FieldType.Name, providerEnumKind), false);
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x00157198 File Offset: 0x00155398
		private static void AddEventDescriptor([NotNull] ref EventSource.EventMetadata[] eventData, string eventName, EventAttribute eventAttribute, ParameterInfo[] eventParameters, bool hasRelatedActivityID)
		{
			if (eventData.Length <= eventAttribute.EventId)
			{
				EventSource.EventMetadata[] array = new EventSource.EventMetadata[Math.Max(eventData.Length + 16, eventAttribute.EventId + 1)];
				Array.Copy(eventData, array, eventData.Length);
				eventData = array;
			}
			ref EventSource.EventMetadata ptr = ref eventData[eventAttribute.EventId];
			ptr.Descriptor = new EventDescriptor(eventAttribute.EventId, eventAttribute.Version, (byte)eventAttribute.Channel, (byte)eventAttribute.Level, (byte)eventAttribute.Opcode, (int)eventAttribute.Task, (long)(eventAttribute.Keywords | (EventKeywords)SessionMask.All.ToEventKeywords()));
			ptr.Tags = eventAttribute.Tags;
			ptr.Name = eventName;
			ptr.Parameters = eventParameters;
			ptr.Message = eventAttribute.Message;
			ptr.ActivityOptions = eventAttribute.ActivityOptions;
			ptr.HasRelatedActivityID = hasRelatedActivityID;
			ptr.EventHandle = IntPtr.Zero;
			int num = eventParameters.Length;
			bool allParametersAreInt = true;
			bool allParametersAreString = true;
			for (int i = 0; i < eventParameters.Length; i++)
			{
				Type parameterType = eventParameters[i].ParameterType;
				if (parameterType == typeof(string))
				{
					allParametersAreInt = false;
				}
				else if (parameterType == typeof(int) || (parameterType.IsEnum && Type.GetTypeCode(parameterType.GetEnumUnderlyingType()) <= TypeCode.UInt32))
				{
					allParametersAreString = false;
				}
				else
				{
					if (parameterType == typeof(byte[]))
					{
						num++;
					}
					allParametersAreInt = false;
					allParametersAreString = false;
				}
			}
			ptr.AllParametersAreInt32 = allParametersAreInt;
			ptr.AllParametersAreString = allParametersAreString;
			ptr.EventListenerParameterCount = num;
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x00157318 File Offset: 0x00155518
		private static void TrimEventDescriptors(ref EventSource.EventMetadata[] eventData)
		{
			int num = eventData.Length;
			while (0 < num)
			{
				num--;
				if (eventData[num].Descriptor.EventId != 0)
				{
					break;
				}
			}
			if (eventData.Length - num > 2)
			{
				EventSource.EventMetadata[] array = new EventSource.EventMetadata[num + 1];
				Array.Copy(eventData, array, array.Length);
				eventData = array;
			}
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00157368 File Offset: 0x00155568
		internal void AddListener(EventListener listener)
		{
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				bool[] eventEnabled = null;
				if (this.m_eventData != null)
				{
					eventEnabled = new bool[this.m_eventData.Length];
				}
				this.m_Dispatchers = new EventDispatcher(this.m_Dispatchers, eventEnabled, listener);
				listener.OnEventSourceCreated(this);
			}
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x001573DC File Offset: 0x001555DC
		private static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, EventSource.EventMetadata[] eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options)
		{
			int eventId = eventAttribute.EventId;
			string name = method.Name;
			int helperCallFirstArg = EventSource.GetHelperCallFirstArg(method);
			if (helperCallFirstArg >= 0 && eventId != helperCallFirstArg)
			{
				manifest.ManifestError(SR.Format(SR.EventSource_MismatchIdToWriteEvent, name, eventId, helperCallFirstArg), true);
			}
			if (eventId < eventData.Length && eventData[eventId].Descriptor.EventId != 0)
			{
				manifest.ManifestError(SR.Format(SR.EventSource_EventIdReused, name, eventId), true);
			}
			for (int i = 0; i < eventData.Length; i++)
			{
				if (eventData[i].Name != null && eventData[i].Descriptor.Task == (int)eventAttribute.Task && (EventOpcode)eventData[i].Descriptor.Opcode == eventAttribute.Opcode)
				{
					manifest.ManifestError(SR.Format(SR.EventSource_TaskOpcodePairReused, new object[]
					{
						name,
						eventId,
						eventData[i].Name,
						i
					}), false);
					if ((options & EventManifestOptions.Strict) == EventManifestOptions.None)
					{
						break;
					}
				}
			}
			if (eventAttribute.Opcode != EventOpcode.Info)
			{
				bool flag = false;
				if (eventAttribute.Task == EventTask.None)
				{
					flag = true;
				}
				else
				{
					EventTask eventTask = (EventTask)65534 - eventId;
					if (eventAttribute.Opcode != EventOpcode.Start && eventAttribute.Opcode != EventOpcode.Stop && eventAttribute.Task == eventTask)
					{
						flag = true;
					}
				}
				if (flag)
				{
					manifest.ManifestError(SR.Format(SR.EventSource_EventMustHaveTaskIfNonDefaultOpcode, name, eventId), false);
				}
			}
			if (eventsByName == null)
			{
				eventsByName = new Dictionary<string, string>();
			}
			if (eventsByName.ContainsKey(name))
			{
				manifest.ManifestError(SR.Format(SR.EventSource_EventNameReused, name), true);
			}
			eventsByName[name] = name;
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x0015757C File Offset: 0x0015577C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The method calls MethodBase.GetMethodBody. Trimming application can change IL of various methodswhich can lead to change of behavior. This method only uses this to validate usage of event source APIs.In the worst case it will not be able to determine the value it's looking for and will not performany validation.")]
		private static int GetHelperCallFirstArg(MethodInfo method)
		{
			byte[] ilasByteArray = method.GetMethodBody().GetILAsByteArray();
			int num = -1;
			for (int i = 0; i < ilasByteArray.Length; i++)
			{
				byte b = ilasByteArray[i];
				if (b <= 110)
				{
					switch (b)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
					case 20:
					case 37:
						break;
					case 14:
					case 16:
						i++;
						break;
					case 15:
					case 17:
					case 18:
					case 19:
					case 33:
					case 34:
					case 35:
					case 36:
					case 38:
					case 39:
					case 41:
					case 42:
					case 43:
					case 46:
					case 47:
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
						return -1;
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:
					case 30:
						if (i > 0 && ilasByteArray[i - 1] == 2)
						{
							num = (int)(ilasByteArray[i] - 22);
						}
						break;
					case 31:
						if (i > 0 && ilasByteArray[i - 1] == 2)
						{
							num = (int)ilasByteArray[i + 1];
						}
						i++;
						break;
					case 32:
						i += 4;
						break;
					case 40:
						i += 4;
						if (num >= 0)
						{
							for (int j = i + 1; j < ilasByteArray.Length; j++)
							{
								if (ilasByteArray[j] == 42)
								{
									return num;
								}
								if (ilasByteArray[j] != 0)
								{
									break;
								}
							}
						}
						num = -1;
						break;
					case 44:
					case 45:
						num = -1;
						i++;
						break;
					case 57:
					case 58:
						num = -1;
						i += 4;
						break;
					default:
						if (b - 103 > 3 && b - 109 > 1)
						{
							return -1;
						}
						break;
					}
				}
				else if (b - 140 > 1)
				{
					if (b != 162)
					{
						if (b != 254)
						{
							return -1;
						}
						i++;
						if (i >= ilasByteArray.Length || ilasByteArray[i] >= 6)
						{
							return -1;
						}
					}
				}
				else
				{
					i += 4;
				}
			}
			return -1;
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x00157784 File Offset: 0x00155984
		internal void ReportOutOfBandMessage(string msg)
		{
			try
			{
				if (this.m_outOfBandMessageCount < 15)
				{
					this.m_outOfBandMessageCount += 1;
				}
				else
				{
					if (this.m_outOfBandMessageCount == 16)
					{
						return;
					}
					this.m_outOfBandMessageCount = 16;
					msg = "Reached message limit.   End of EventSource error messages.";
				}
				Debugger.Log(0, null, "EventSource Error: " + msg + "\r\n");
				this.WriteEventString(msg);
				this.WriteStringToAllListeners("EventSourceMessage", msg);
			}
			catch
			{
			}
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x00157808 File Offset: 0x00155A08
		private static EventSourceSettings ValidateSettings(EventSourceSettings settings)
		{
			if ((settings & (EventSourceSettings.EtwManifestEventFormat | EventSourceSettings.EtwSelfDescribingEventFormat)) == (EventSourceSettings.EtwManifestEventFormat | EventSourceSettings.EtwSelfDescribingEventFormat))
			{
				throw new ArgumentException(SR.EventSource_InvalidEventFormat, "settings");
			}
			if ((settings & (EventSourceSettings.EtwManifestEventFormat | EventSourceSettings.EtwSelfDescribingEventFormat)) == EventSourceSettings.Default)
			{
				settings |= EventSourceSettings.EtwSelfDescribingEventFormat;
			}
			return settings;
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06008C47 RID: 35911 RVA: 0x0015782E File Offset: 0x00155A2E
		private bool ThrowOnEventWriteErrors
		{
			get
			{
				return (this.m_config & EventSourceSettings.ThrowOnEventWriteErrors) > EventSourceSettings.Default;
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06008C48 RID: 35912 RVA: 0x0015783B File Offset: 0x00155A3B
		private bool SelfDescribingEvents
		{
			get
			{
				return (this.m_config & EventSourceSettings.EtwSelfDescribingEventFormat) > EventSourceSettings.Default;
			}
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x00157848 File Offset: 0x00155A48
		internal static void InitializeDefaultEventSources()
		{
			if (!EventSource.IsSupported)
			{
				return;
			}
			NativeRuntimeEventSource log = NativeRuntimeEventSource.Log;
			RuntimeEventSource log2 = RuntimeEventSource.Log;
			if (EventSource.IsMeterSupported)
			{
				Guid id = new Guid("20752bc4-c151-50f5-f27b-df92d8af5a61");
				string name = "System.Diagnostics.Metrics";
				Func<EventSource> eventSourceFactory;
				if ((eventSourceFactory = EventSource.<>O.<0>__GetMetricsEventSource) == null)
				{
					eventSourceFactory = (EventSource.<>O.<0>__GetMetricsEventSource = new Func<EventSource>(EventSourceInitHelper.GetMetricsEventSource));
				}
				EventSourceInitHelper.PreregisterEventProviders(id, name, eventSourceFactory);
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06008C4A RID: 35914 RVA: 0x0015789F File Offset: 0x00155A9F
		[Nullable(0)]
		private protected virtual ReadOnlySpan<byte> ProviderMetadata
		{
			get
			{
				return this.m_providerMetadata;
			}
		}

		// Token: 0x06008C4B RID: 35915 RVA: 0x001578AC File Offset: 0x00155AAC
		[NullableContext(1)]
		public EventSource(string eventSourceName) : this(eventSourceName, EventSourceSettings.EtwSelfDescribingEventFormat)
		{
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x001578B6 File Offset: 0x00155AB6
		[NullableContext(1)]
		public EventSource(string eventSourceName, EventSourceSettings config) : this(eventSourceName, config, null)
		{
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x001578C1 File Offset: 0x00155AC1
		[NullableContext(1)]
		public EventSource(string eventSourceName, EventSourceSettings config, [Nullable(new byte[]
		{
			2,
			1
		})] params string[] traits)
		{
			if (eventSourceName == null)
			{
				throw new ArgumentNullException("eventSourceName");
			}
			this..ctor(EventSource.GenerateGuidFromName(eventSourceName.ToUpperInvariant()), eventSourceName, config, traits);
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x001578E8 File Offset: 0x00155AE8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		public void Write(string eventName)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			EventSourceOptions eventSourceOptions = default(EventSourceOptions);
			this.WriteImpl(eventName, ref eventSourceOptions, null, null, null, SimpleEventTypes<EmptyStruct>.Instance);
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x00157919 File Offset: 0x00155B19
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		public void Write(string eventName, EventSourceOptions options)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			this.WriteImpl(eventName, ref options, null, null, null, SimpleEventTypes<EmptyStruct>.Instance);
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x00157938 File Offset: 0x00155B38
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public void Write<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(string eventName, [Nullable(1)] T data)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			EventSourceOptions eventSourceOptions = default(EventSourceOptions);
			this.WriteImpl(eventName, ref eventSourceOptions, data, null, null, SimpleEventTypes<T>.Instance);
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x0015796E File Offset: 0x00155B6E
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public void Write<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(string eventName, EventSourceOptions options, [Nullable(1)] T data)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			this.WriteImpl(eventName, ref options, data, null, null, SimpleEventTypes<T>.Instance);
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x00157991 File Offset: 0x00155B91
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public void Write<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(string eventName, ref EventSourceOptions options, [Nullable(1)] ref T data)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			this.WriteImpl(eventName, ref options, data, null, null, SimpleEventTypes<T>.Instance);
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x001579B8 File Offset: 0x00155BB8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
		[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public unsafe void Write<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(string eventName, ref EventSourceOptions options, ref Guid activityId, ref Guid relatedActivityId, [Nullable(1)] ref T data)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			fixed (Guid* ptr = &activityId)
			{
				Guid* pActivityId = ptr;
				fixed (Guid* ptr2 = &relatedActivityId)
				{
					Guid* ptr3 = ptr2;
					this.WriteImpl(eventName, ref options, data, pActivityId, (relatedActivityId == Guid.Empty) ? null : ptr3, SimpleEventTypes<T>.Instance);
					ptr = null;
				}
				return;
			}
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x00157A14 File Offset: 0x00155C14
		private unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params object[] values)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			byte level = ((options.valuesSet & 4) != 0) ? options.level : eventTypes.level;
			EventKeywords keywords = ((options.valuesSet & 1) != 0) ? options.keywords : eventTypes.keywords;
			if (this.IsEnabled((EventLevel)level, keywords))
			{
				this.WriteMultiMergeInner(eventName, ref options, eventTypes, activityID, childActivityID, values);
			}
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x00157A78 File Offset: 0x00155C78
		private unsafe void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params object[] values)
		{
			byte level = ((options.valuesSet & 4) != 0) ? options.level : eventTypes.level;
			byte opcode = ((options.valuesSet & 8) != 0) ? options.opcode : eventTypes.opcode;
			EventTags tags = ((options.valuesSet & 2) != 0) ? options.tags : eventTypes.Tags;
			EventKeywords keywords = ((options.valuesSet & 1) != 0) ? options.keywords : eventTypes.keywords;
			NameInfo nameInfo = eventTypes.GetNameInfo(eventName ?? eventTypes.Name, tags);
			if (nameInfo == null)
			{
				return;
			}
			int identity = nameInfo.identity;
			EventDescriptor descriptor = new EventDescriptor(identity, level, opcode, (long)keywords);
			IntPtr orCreateEventHandle = nameInfo.GetOrCreateEventHandle(this.m_eventPipeProvider, this.m_eventHandleTable, descriptor, eventTypes);
			int pinCount = eventTypes.pinCount;
			byte* scratch = stackalloc byte[(UIntPtr)eventTypes.scratchSize];
			EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)(eventTypes.dataCount + 3)) * (UIntPtr)sizeof(EventSource.EventData))];
			for (int i = 0; i < eventTypes.dataCount + 3; i++)
			{
				ptr[i] = default(EventSource.EventData);
			}
			GCHandle* ptr2 = stackalloc GCHandle[checked(unchecked((UIntPtr)pinCount) * (UIntPtr)sizeof(GCHandle))];
			for (int j = 0; j < pinCount; j++)
			{
				ptr2[j] = default(GCHandle);
			}
			ReadOnlySpan<byte> providerMetadata = this.ProviderMetadata;
			byte[] array;
			byte[] array2;
			fixed (byte* pinnableReference = providerMetadata.GetPinnableReference())
			{
				byte* pointer = pinnableReference;
				byte* pointer2;
				if ((array = nameInfo.nameMetadata) == null || array.Length == 0)
				{
					pointer2 = null;
				}
				else
				{
					pointer2 = &array[0];
				}
				byte* pointer3;
				if ((array2 = eventTypes.typeMetadata) == null || array2.Length == 0)
				{
					pointer3 = null;
				}
				else
				{
					pointer3 = &array2[0];
				}
				ptr->SetMetadata(pointer, providerMetadata.Length, 2);
				ptr[1].SetMetadata(pointer2, nameInfo.nameMetadata.Length, 1);
				ptr[2].SetMetadata(pointer3, eventTypes.typeMetadata.Length, 1);
				try
				{
					DataCollector.ThreadInstance.Enable(scratch, eventTypes.scratchSize, ptr + 3, eventTypes.dataCount, ptr2, pinCount);
					for (int k = 0; k < eventTypes.typeInfos.Length; k++)
					{
						TraceLoggingTypeInfo traceLoggingTypeInfo = eventTypes.typeInfos[k];
						traceLoggingTypeInfo.WriteData(traceLoggingTypeInfo.PropertyValueFactory(values[k]));
					}
					this.WriteEventRaw(eventName, ref descriptor, orCreateEventHandle, activityID, childActivityID, (int)((long)(DataCollector.ThreadInstance.Finish() - ptr)), ptr);
				}
				finally
				{
					EventSource.WriteCleanup(ptr2, pinCount);
				}
			}
			array = null;
			array2 = null;
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x00157D04 File Offset: 0x00155F04
		internal unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventSource.EventData* data)
		{
			if (!this.IsEnabled())
			{
				return;
			}
			fixed (EventSourceOptions* ptr = &options)
			{
				EventDescriptor descriptor;
				NameInfo nameInfo = this.UpdateDescriptor(eventName, eventTypes, ref options, out descriptor);
				if (nameInfo == null)
				{
					return;
				}
				IntPtr orCreateEventHandle = nameInfo.GetOrCreateEventHandle(this.m_eventPipeProvider, this.m_eventHandleTable, descriptor, eventTypes);
				int num = eventTypes.dataCount + eventTypes.typeInfos.Length * 2 + 3;
				EventSource.EventData* ptr2 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)num) * (UIntPtr)sizeof(EventSource.EventData))];
				for (int i = 0; i < num; i++)
				{
					ptr2[i] = default(EventSource.EventData);
				}
				ReadOnlySpan<byte> providerMetadata = this.ProviderMetadata;
				byte[] array;
				byte[] array2;
				fixed (byte* pinnableReference = providerMetadata.GetPinnableReference())
				{
					byte* pointer = pinnableReference;
					byte* pointer2;
					if ((array = nameInfo.nameMetadata) == null || array.Length == 0)
					{
						pointer2 = null;
					}
					else
					{
						pointer2 = &array[0];
					}
					byte* pointer3;
					if ((array2 = eventTypes.typeMetadata) == null || array2.Length == 0)
					{
						pointer3 = null;
					}
					else
					{
						pointer3 = &array2[0];
					}
					ptr2->SetMetadata(pointer, providerMetadata.Length, 2);
					ptr2[1].SetMetadata(pointer2, nameInfo.nameMetadata.Length, 1);
					ptr2[2].SetMetadata(pointer3, eventTypes.typeMetadata.Length, 1);
					int num2 = 3;
					for (int j = 0; j < eventTypes.typeInfos.Length; j++)
					{
						ptr2[num2].m_Ptr = data[j].m_Ptr;
						ptr2[num2].m_Size = data[j].m_Size;
						if (data[j].m_Size == 4 && eventTypes.typeInfos[j].DataType == typeof(bool))
						{
							ptr2[num2].m_Size = 1;
						}
						num2++;
					}
					this.WriteEventRaw(eventName, ref descriptor, orCreateEventHandle, activityID, childActivityID, num2, ptr2);
				}
				array = null;
				array2 = null;
			}
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x00157F00 File Offset: 0x00156100
		private unsafe void WriteImpl(string eventName, ref EventSourceOptions options, object data, Guid* pActivityId, Guid* pRelatedActivityId, TraceLoggingEventTypes eventTypes)
		{
			try
			{
				try
				{
					fixed (EventSourceOptions* ptr = &options)
					{
						options.Opcode = (options.IsOpcodeSet ? options.Opcode : EventSource.GetOpcodeWithDefault(options.Opcode, eventName));
						EventDescriptor descriptor;
						NameInfo nameInfo = this.UpdateDescriptor(eventName, eventTypes, ref options, out descriptor);
						if (nameInfo != null)
						{
							IntPtr orCreateEventHandle = nameInfo.GetOrCreateEventHandle(this.m_eventPipeProvider, this.m_eventHandleTable, descriptor, eventTypes);
							int pinCount = eventTypes.pinCount;
							byte* scratch = stackalloc byte[(UIntPtr)eventTypes.scratchSize];
							EventSource.EventData* ptr2 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)(eventTypes.dataCount + 3)) * (UIntPtr)sizeof(EventSource.EventData))];
							for (int i = 0; i < eventTypes.dataCount + 3; i++)
							{
								ptr2[i] = default(EventSource.EventData);
							}
							GCHandle* ptr3 = stackalloc GCHandle[checked(unchecked((UIntPtr)pinCount) * (UIntPtr)sizeof(GCHandle))];
							for (int j = 0; j < pinCount; j++)
							{
								ptr3[j] = default(GCHandle);
							}
							ReadOnlySpan<byte> providerMetadata = this.ProviderMetadata;
							try
							{
								fixed (byte* ptr4 = providerMetadata.GetPinnableReference())
								{
									byte* pointer = ptr4;
									byte[] array;
									byte* pointer2;
									if ((array = nameInfo.nameMetadata) == null || array.Length == 0)
									{
										pointer2 = null;
									}
									else
									{
										pointer2 = &array[0];
									}
									byte[] array2;
									byte* pointer3;
									if ((array2 = eventTypes.typeMetadata) == null || array2.Length == 0)
									{
										pointer3 = null;
									}
									else
									{
										pointer3 = &array2[0];
									}
									ptr2->SetMetadata(pointer, providerMetadata.Length, 2);
									ptr2[1].SetMetadata(pointer2, nameInfo.nameMetadata.Length, 1);
									ptr2[2].SetMetadata(pointer3, eventTypes.typeMetadata.Length, 1);
									EventOpcode opcode = (EventOpcode)descriptor.Opcode;
									Guid empty = Guid.Empty;
									Guid empty2 = Guid.Empty;
									if (pActivityId == null && pRelatedActivityId == null && (options.ActivityOptions & EventActivityOptions.Disable) == EventActivityOptions.None)
									{
										if (opcode == EventOpcode.Start)
										{
											this.m_activityTracker.OnStart(this.m_name, eventName, 0, ref empty, ref empty2, options.ActivityOptions, true);
										}
										else if (opcode == EventOpcode.Stop)
										{
											this.m_activityTracker.OnStop(this.m_name, eventName, 0, ref empty, true);
										}
										if (empty != Guid.Empty)
										{
											pActivityId = &empty;
										}
										if (empty2 != Guid.Empty)
										{
											pRelatedActivityId = &empty2;
										}
									}
									try
									{
										DataCollector.ThreadInstance.Enable(scratch, eventTypes.scratchSize, ptr2 + 3, eventTypes.dataCount, ptr3, pinCount);
										TraceLoggingTypeInfo traceLoggingTypeInfo = eventTypes.typeInfos[0];
										traceLoggingTypeInfo.WriteData(traceLoggingTypeInfo.PropertyValueFactory(data));
										this.WriteEventRaw(eventName, ref descriptor, orCreateEventHandle, pActivityId, pRelatedActivityId, (int)((long)(DataCollector.ThreadInstance.Finish() - ptr2)), ptr2);
										if (this.m_Dispatchers != null)
										{
											EventPayload payload = (EventPayload)eventTypes.typeInfos[0].GetData(data);
											this.WriteToAllListeners(eventName, ref descriptor, nameInfo.tags, pActivityId, pRelatedActivityId, payload);
										}
									}
									catch (Exception ex)
									{
										if (ex is EventSourceException)
										{
											throw;
										}
										this.ThrowEventSourceException(eventName, ex);
									}
									finally
									{
										EventSource.WriteCleanup(ptr3, pinCount);
									}
								}
							}
							finally
							{
								byte* ptr4 = null;
								byte[] array = null;
								byte[] array2 = null;
							}
						}
					}
				}
				finally
				{
					EventSourceOptions* ptr = null;
				}
			}
			catch (Exception ex2)
			{
				if (ex2 is EventSourceException)
				{
					throw;
				}
				this.ThrowEventSourceException(eventName, ex2);
			}
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x0015828C File Offset: 0x0015648C
		private unsafe void WriteToAllListeners(string eventName, ref EventDescriptor eventDescriptor, EventTags tags, Guid* pActivityId, Guid* pChildActivityId, EventPayload payload)
		{
			EventWrittenEventArgs eventWrittenEventArgs = new EventWrittenEventArgs(this, -1, pActivityId, pChildActivityId)
			{
				EventName = eventName,
				Level = (EventLevel)eventDescriptor.Level,
				Keywords = (EventKeywords)eventDescriptor.Keywords,
				Opcode = (EventOpcode)eventDescriptor.Opcode,
				Tags = tags
			};
			if (payload != null)
			{
				eventWrittenEventArgs.Payload = new ReadOnlyCollection<object>((IList<object>)payload.Values);
				eventWrittenEventArgs.PayloadNames = new ReadOnlyCollection<string>((IList<string>)payload.Keys);
			}
			this.DispatchToAllListeners(eventWrittenEventArgs);
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x00158310 File Offset: 0x00156510
		[NonEvent]
		private unsafe static void WriteCleanup(GCHandle* pPins, int cPins)
		{
			DataCollector.ThreadInstance.Disable();
			for (int i = 0; i < cPins; i++)
			{
				if (pPins[i].IsAllocated)
				{
					pPins[i].Free();
				}
			}
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x00158358 File Offset: 0x00156558
		private void InitializeProviderMetadata()
		{
			if (this.ProviderMetadata.Length > 0)
			{
				return;
			}
			if (this.m_traits != null)
			{
				List<byte> list = new List<byte>(100);
				for (int i = 0; i < this.m_traits.Length - 1; i += 2)
				{
					if (this.m_traits[i].StartsWith("ETW_", StringComparison.Ordinal))
					{
						ReadOnlySpan<char> readOnlySpan = this.m_traits[i].AsSpan(4);
						byte item;
						if (!byte.TryParse(readOnlySpan, out item))
						{
							if (!readOnlySpan.SequenceEqual("GROUP".AsSpan()))
							{
								throw new ArgumentException(SR.Format(SR.EventSource_UnknownEtwTrait, readOnlySpan.ToString()), "traits");
							}
							item = 1;
						}
						string value = this.m_traits[i + 1];
						int count = list.Count;
						list.Add(0);
						list.Add(0);
						list.Add(item);
						int num = EventSource.AddValueToMetaData(list, value) + 3;
						list[count] = (byte)num;
						list[count + 1] = (byte)(num >> 8);
					}
				}
				byte[] array = Statics.MetadataForString(this.Name, 0, list.Count, 0);
				int num2 = array.Length - list.Count;
				foreach (byte b in list)
				{
					array[num2++] = b;
				}
				this.m_providerMetadata = array;
				return;
			}
			this.m_providerMetadata = Statics.MetadataForString(this.Name, 0, 0, 0);
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x001584EC File Offset: 0x001566EC
		private static int AddValueToMetaData(List<byte> metaData, string value)
		{
			if (value.Length == 0)
			{
				return 0;
			}
			int count = metaData.Count;
			char c = value[0];
			if (c == '@')
			{
				metaData.AddRange(Encoding.UTF8.GetBytes(value.Substring(1)));
			}
			else if (c == '{')
			{
				metaData.AddRange(new Guid(value).ToByteArray());
			}
			else if (c == '#')
			{
				for (int i = 1; i < value.Length; i++)
				{
					if (value[i] != ' ')
					{
						if (i + 1 >= value.Length)
						{
							throw new ArgumentException(SR.EventSource_EvenHexDigits, "traits");
						}
						metaData.Add((byte)(EventSource.HexDigit(value[i]) * 16 + EventSource.HexDigit(value[i + 1])));
						i++;
					}
				}
			}
			else
			{
				if ('A' > c && ' ' != c)
				{
					throw new ArgumentException(SR.Format(SR.EventSource_IllegalValue, value), "traits");
				}
				metaData.AddRange(Encoding.UTF8.GetBytes(value));
			}
			return metaData.Count - count;
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x001585F4 File Offset: 0x001567F4
		private static int HexDigit(char c)
		{
			if ('0' <= c && c <= '9')
			{
				return (int)(c - '0');
			}
			if ('a' <= c)
			{
				c -= ' ';
			}
			if ('A' <= c && c <= 'F')
			{
				return (int)(c - 'A' + '\n');
			}
			throw new ArgumentException(SR.Format(SR.EventSource_BadHexDigit, c), "traits");
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x00158648 File Offset: 0x00156848
		private NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor)
		{
			NameInfo nameInfo = null;
			int traceloggingId = 0;
			byte level = ((options.valuesSet & 4) != 0) ? options.level : eventInfo.level;
			byte opcode = ((options.valuesSet & 8) != 0) ? options.opcode : eventInfo.opcode;
			EventTags tags = ((options.valuesSet & 2) != 0) ? options.tags : eventInfo.Tags;
			EventKeywords keywords = ((options.valuesSet & 1) != 0) ? options.keywords : eventInfo.keywords;
			if (this.IsEnabled((EventLevel)level, keywords))
			{
				nameInfo = eventInfo.GetNameInfo(name ?? eventInfo.Name, tags);
				traceloggingId = nameInfo.identity;
			}
			descriptor = new EventDescriptor(traceloggingId, level, opcode, (long)keywords);
			return nameInfo;
		}

		// Token: 0x06008C5E RID: 35934 RVA: 0x001586F8 File Offset: 0x001568F8
		// Note: this type is marked as 'beforefieldinit'.
		static EventSource()
		{
			bool flag;
			EventSource.AllowDuplicateSourceNames = (AppContext.TryGetSwitch("System.Diagnostics.Tracing.EventSource.AllowDuplicateSourceNames", out flag) && flag);
			EventSource.IsSupported = EventSource.InitializeIsSupported();
			EventSource.IsMeterSupported = EventSource.InitializeIsMeterSupported();
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x00158730 File Offset: 0x00156930
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The call to TraceLoggingEventTypes with the below parameter values are trim safe")]
		internal static TraceLoggingEventTypes <WriteEventString>g__GetTrimSafeTraceLoggingEventTypes|111_0()
		{
			return new TraceLoggingEventTypes("EventSourceMessage", EventTags.None, new Type[]
			{
				typeof(string)
			});
		}

		// Token: 0x04001FAE RID: 8110
		private string m_name;

		// Token: 0x04001FAF RID: 8111
		internal int m_id;

		// Token: 0x04001FB0 RID: 8112
		private Guid m_guid;

		// Token: 0x04001FB1 RID: 8113
		internal volatile EventSource.EventMetadata[] m_eventData;

		// Token: 0x04001FB2 RID: 8114
		private volatile byte[] m_rawManifest;

		// Token: 0x04001FB3 RID: 8115
		private EventHandler<EventCommandEventArgs> m_eventCommandExecuted;

		// Token: 0x04001FB4 RID: 8116
		private readonly EventSourceSettings m_config;

		// Token: 0x04001FB5 RID: 8117
		private bool m_eventSourceDisposed;

		// Token: 0x04001FB6 RID: 8118
		private bool m_eventSourceEnabled;

		// Token: 0x04001FB7 RID: 8119
		internal EventLevel m_level;

		// Token: 0x04001FB8 RID: 8120
		internal EventKeywords m_matchAnyKeyword;

		// Token: 0x04001FB9 RID: 8121
		internal volatile EventDispatcher m_Dispatchers;

		// Token: 0x04001FBA RID: 8122
		private volatile EventSource.OverrideEventProvider m_etwProvider;

		// Token: 0x04001FBB RID: 8123
		private object m_createEventLock;

		// Token: 0x04001FBC RID: 8124
		private IntPtr m_writeEventStringEventHandle;

		// Token: 0x04001FBD RID: 8125
		private volatile EventSource.OverrideEventProvider m_eventPipeProvider;

		// Token: 0x04001FBE RID: 8126
		private bool m_completelyInited;

		// Token: 0x04001FBF RID: 8127
		private Exception m_constructionException;

		// Token: 0x04001FC0 RID: 8128
		private byte m_outOfBandMessageCount;

		// Token: 0x04001FC1 RID: 8129
		private EventCommandEventArgs m_deferredCommands;

		// Token: 0x04001FC2 RID: 8130
		private string[] m_traits;

		// Token: 0x04001FC3 RID: 8131
		[ThreadStatic]
		private static byte m_EventSourceExceptionRecurenceCount;

		// Token: 0x04001FC4 RID: 8132
		internal volatile ulong[] m_channelData;

		// Token: 0x04001FC5 RID: 8133
		private ActivityTracker m_activityTracker;

		// Token: 0x04001FC6 RID: 8134
		internal const string ActivityStartSuffix = "Start";

		// Token: 0x04001FC7 RID: 8135
		internal const string ActivityStopSuffix = "Stop";

		// Token: 0x04001FC8 RID: 8136
		internal const string DuplicateSourceNamesSwitch = "System.Diagnostics.Tracing.EventSource.AllowDuplicateSourceNames";

		// Token: 0x04001FC9 RID: 8137
		private static readonly bool AllowDuplicateSourceNames;

		// Token: 0x04001FCC RID: 8140
		private const DynamicallyAccessedMemberTypes ManifestMemberTypes = DynamicallyAccessedMemberTypes.All;

		// Token: 0x04001FCD RID: 8141
		private static ReadOnlyCollection<string> s_errorPayloadNames;

		// Token: 0x04001FCE RID: 8142
		private byte[] m_providerMetadata;

		// Token: 0x04001FCF RID: 8143
		private const string EventSourceRequiresUnreferenceMessage = "EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type";

		// Token: 0x04001FD0 RID: 8144
		private const string EventSourceSuppressMessage = "Parameters to this method are primitive and are trimmer safe";

		// Token: 0x04001FD1 RID: 8145
		private readonly TraceLoggingEventHandleTable m_eventHandleTable;

		// Token: 0x020008EB RID: 2283
		[Nullable(0)]
		public readonly struct EventSourcePrimitive
		{
			// Token: 0x06008C61 RID: 35937 RVA: 0x00158750 File Offset: 0x00156950
			private EventSourcePrimitive(object value)
			{
				this.Value = value;
			}

			// Token: 0x06008C62 RID: 35938 RVA: 0x00158759 File Offset: 0x00156959
			public static implicit operator EventSource.EventSourcePrimitive(bool value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C63 RID: 35939 RVA: 0x00158766 File Offset: 0x00156966
			public static implicit operator EventSource.EventSourcePrimitive(byte value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C64 RID: 35940 RVA: 0x00158773 File Offset: 0x00156973
			public static implicit operator EventSource.EventSourcePrimitive(short value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C65 RID: 35941 RVA: 0x00158780 File Offset: 0x00156980
			public static implicit operator EventSource.EventSourcePrimitive(int value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C66 RID: 35942 RVA: 0x0015878D File Offset: 0x0015698D
			public static implicit operator EventSource.EventSourcePrimitive(long value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C67 RID: 35943 RVA: 0x0015879A File Offset: 0x0015699A
			[CLSCompliant(false)]
			public static implicit operator EventSource.EventSourcePrimitive(sbyte value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C68 RID: 35944 RVA: 0x001587A7 File Offset: 0x001569A7
			[CLSCompliant(false)]
			public static implicit operator EventSource.EventSourcePrimitive(ushort value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C69 RID: 35945 RVA: 0x001587B4 File Offset: 0x001569B4
			[CLSCompliant(false)]
			public static implicit operator EventSource.EventSourcePrimitive(uint value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C6A RID: 35946 RVA: 0x001587C1 File Offset: 0x001569C1
			[CLSCompliant(false)]
			public static implicit operator EventSource.EventSourcePrimitive(ulong value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C6B RID: 35947 RVA: 0x001587CE File Offset: 0x001569CE
			[CLSCompliant(false)]
			public static implicit operator EventSource.EventSourcePrimitive(UIntPtr value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C6C RID: 35948 RVA: 0x001587DB File Offset: 0x001569DB
			public static implicit operator EventSource.EventSourcePrimitive(float value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C6D RID: 35949 RVA: 0x001587E8 File Offset: 0x001569E8
			public static implicit operator EventSource.EventSourcePrimitive(double value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C6E RID: 35950 RVA: 0x001587F5 File Offset: 0x001569F5
			public static implicit operator EventSource.EventSourcePrimitive(decimal value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C6F RID: 35951 RVA: 0x00158802 File Offset: 0x00156A02
			public static implicit operator EventSource.EventSourcePrimitive(string value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C70 RID: 35952 RVA: 0x00158802 File Offset: 0x00156A02
			public static implicit operator EventSource.EventSourcePrimitive(byte[] value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C71 RID: 35953 RVA: 0x0015880A File Offset: 0x00156A0A
			public static implicit operator EventSource.EventSourcePrimitive(Guid value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C72 RID: 35954 RVA: 0x00158817 File Offset: 0x00156A17
			public static implicit operator EventSource.EventSourcePrimitive(DateTime value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C73 RID: 35955 RVA: 0x00158824 File Offset: 0x00156A24
			public static implicit operator EventSource.EventSourcePrimitive(IntPtr value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C74 RID: 35956 RVA: 0x00158831 File Offset: 0x00156A31
			public static implicit operator EventSource.EventSourcePrimitive(char value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x06008C75 RID: 35957 RVA: 0x00158802 File Offset: 0x00156A02
			[NullableContext(1)]
			public static implicit operator EventSource.EventSourcePrimitive(Enum value)
			{
				return new EventSource.EventSourcePrimitive(value);
			}

			// Token: 0x04001FD2 RID: 8146
			internal readonly object Value;
		}

		// Token: 0x020008EC RID: 2284
		[NullableContext(0)]
		protected internal struct EventData
		{
			// Token: 0x170012A7 RID: 4775
			// (get) Token: 0x06008C76 RID: 35958 RVA: 0x0015883E File Offset: 0x00156A3E
			// (set) Token: 0x06008C77 RID: 35959 RVA: 0x00158847 File Offset: 0x00156A47
			public IntPtr DataPointer
			{
				get
				{
					return (IntPtr)((UIntPtr)this.m_Ptr);
				}
				set
				{
					this.m_Ptr = (ulong)value;
				}
			}

			// Token: 0x170012A8 RID: 4776
			// (get) Token: 0x06008C78 RID: 35960 RVA: 0x00158851 File Offset: 0x00156A51
			// (set) Token: 0x06008C79 RID: 35961 RVA: 0x00158859 File Offset: 0x00156A59
			public int Size
			{
				get
				{
					return this.m_Size;
				}
				set
				{
					this.m_Size = value;
				}
			}

			// Token: 0x170012A9 RID: 4777
			// (get) Token: 0x06008C7A RID: 35962 RVA: 0x00158862 File Offset: 0x00156A62
			// (set) Token: 0x06008C7B RID: 35963 RVA: 0x0015886A File Offset: 0x00156A6A
			internal int Reserved
			{
				get
				{
					return this.m_Reserved;
				}
				set
				{
					this.m_Reserved = value;
				}
			}

			// Token: 0x06008C7C RID: 35964 RVA: 0x00158873 File Offset: 0x00156A73
			internal unsafe void SetMetadata(byte* pointer, int size, int reserved)
			{
				this.m_Ptr = pointer;
				this.m_Size = size;
				this.m_Reserved = reserved;
			}

			// Token: 0x04001FD3 RID: 8147
			internal ulong m_Ptr;

			// Token: 0x04001FD4 RID: 8148
			internal int m_Size;

			// Token: 0x04001FD5 RID: 8149
			internal int m_Reserved;
		}

		// Token: 0x020008ED RID: 2285
		internal sealed class OverrideEventProvider : EventProvider
		{
			// Token: 0x06008C7D RID: 35965 RVA: 0x0015888B File Offset: 0x00156A8B
			public OverrideEventProvider(Func<EventSource> eventSourceFactory, EventProviderType providerType) : base(providerType)
			{
				this._eventSourceFactory = eventSourceFactory;
				this._eventProviderType = providerType;
			}

			// Token: 0x06008C7E RID: 35966 RVA: 0x001588A4 File Offset: 0x00156AA4
			internal override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId)
			{
				EventListener listener = null;
				EventSource eventSource = this._eventSourceFactory();
				if (eventSource == null)
				{
					return;
				}
				eventSource.SendCommand(listener, this._eventProviderType, perEventSourceSessionId, (EventCommand)command, base.IsEnabled(), base.Level, base.MatchAnyKeyword, arguments);
			}

			// Token: 0x04001FD6 RID: 8150
			private readonly Func<EventSource> _eventSourceFactory;

			// Token: 0x04001FD7 RID: 8151
			private readonly EventProviderType _eventProviderType;
		}

		// Token: 0x020008EE RID: 2286
		internal struct EventMetadata
		{
			// Token: 0x170012AA RID: 4778
			// (get) Token: 0x06008C7F RID: 35967 RVA: 0x001588E4 File Offset: 0x00156AE4
			public TraceLoggingEventTypes TraceLoggingEventTypes
			{
				[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2112:ReflectionToRequiresUnreferencedCode", Justification = "EnsureDescriptorsInitialized's use of GetType preserves this method which requires unreferenced code, but EnsureDescriptorsInitialized does not access this member and is safe to call.")]
				[RequiresUnreferencedCode("EventSource will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
				get
				{
					if (this._traceLoggingEventTypes == null)
					{
						TraceLoggingEventTypes value = new TraceLoggingEventTypes(this.Name, this.Tags, this.Parameters);
						Interlocked.CompareExchange<TraceLoggingEventTypes>(ref this._traceLoggingEventTypes, value, null);
					}
					return this._traceLoggingEventTypes;
				}
			}

			// Token: 0x170012AB RID: 4779
			// (get) Token: 0x06008C80 RID: 35968 RVA: 0x00158928 File Offset: 0x00156B28
			public ReadOnlyCollection<string> ParameterNames
			{
				get
				{
					if (this._parameterNames == null)
					{
						ParameterInfo[] parameters = this.Parameters;
						string[] array = new string[parameters.Length];
						for (int i = 0; i < array.Length; i++)
						{
							array[i] = parameters[i].Name;
						}
						this._parameterNames = new ReadOnlyCollection<string>(array);
					}
					return this._parameterNames;
				}
			}

			// Token: 0x170012AC RID: 4780
			// (get) Token: 0x06008C81 RID: 35969 RVA: 0x00158978 File Offset: 0x00156B78
			public Type[] ParameterTypes
			{
				get
				{
					Type[] result;
					if ((result = this._parameterTypes) == null)
					{
						result = (this._parameterTypes = EventSource.EventMetadata.<get_ParameterTypes>g__GetParameterTypes|22_0(this.Parameters));
					}
					return result;
				}
			}

			// Token: 0x06008C82 RID: 35970 RVA: 0x001589A4 File Offset: 0x00156BA4
			[CompilerGenerated]
			internal static Type[] <get_ParameterTypes>g__GetParameterTypes|22_0(ParameterInfo[] parameters)
			{
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = parameters[i].ParameterType;
				}
				return array;
			}

			// Token: 0x04001FD8 RID: 8152
			public EventDescriptor Descriptor;

			// Token: 0x04001FD9 RID: 8153
			public IntPtr EventHandle;

			// Token: 0x04001FDA RID: 8154
			public EventTags Tags;

			// Token: 0x04001FDB RID: 8155
			public bool EnabledForAnyListener;

			// Token: 0x04001FDC RID: 8156
			public bool EnabledForETW;

			// Token: 0x04001FDD RID: 8157
			public bool EnabledForEventPipe;

			// Token: 0x04001FDE RID: 8158
			public bool HasRelatedActivityID;

			// Token: 0x04001FDF RID: 8159
			public string Name;

			// Token: 0x04001FE0 RID: 8160
			public string Message;

			// Token: 0x04001FE1 RID: 8161
			public ParameterInfo[] Parameters;

			// Token: 0x04001FE2 RID: 8162
			public int EventListenerParameterCount;

			// Token: 0x04001FE3 RID: 8163
			public bool AllParametersAreString;

			// Token: 0x04001FE4 RID: 8164
			public bool AllParametersAreInt32;

			// Token: 0x04001FE5 RID: 8165
			public EventActivityOptions ActivityOptions;

			// Token: 0x04001FE6 RID: 8166
			private TraceLoggingEventTypes _traceLoggingEventTypes;

			// Token: 0x04001FE7 RID: 8167
			private ReadOnlyCollection<string> _parameterNames;

			// Token: 0x04001FE8 RID: 8168
			private Type[] _parameterTypes;
		}

		// Token: 0x020008EF RID: 2287
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04001FE9 RID: 8169
			public static Func<EventSource> <0>__GetMetricsEventSource;
		}
	}
}
