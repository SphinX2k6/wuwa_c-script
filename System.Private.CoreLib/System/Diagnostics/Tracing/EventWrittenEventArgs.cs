using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F6 RID: 2294
	[NullableContext(2)]
	[Nullable(0)]
	public class EventWrittenEventArgs : EventArgs
	{
		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06008CA9 RID: 36009 RVA: 0x001593B9 File Offset: 0x001575B9
		private ref EventSource.EventMetadata Metadata
		{
			get
			{
				return ref this.EventSource.m_eventData[this.EventId];
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06008CAA RID: 36010 RVA: 0x001593D3 File Offset: 0x001575D3
		// (set) Token: 0x06008CAB RID: 36011 RVA: 0x00159401 File Offset: 0x00157601
		public string EventName
		{
			get
			{
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				string result;
				if ((result = ((moreInfo != null) ? moreInfo.EventName : null)) == null)
				{
					if (this.EventId > 0)
					{
						return this.Metadata.Name;
					}
					result = null;
				}
				return result;
			}
			internal set
			{
				this.MoreInfo.EventName = value;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06008CAC RID: 36012 RVA: 0x0015940F File Offset: 0x0015760F
		public int EventId { get; }

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06008CAD RID: 36013 RVA: 0x00159417 File Offset: 0x00157617
		public Guid ActivityId
		{
			get
			{
				if (this._activityId == Guid.Empty)
				{
					this._activityId = EventSource.CurrentThreadActivityId;
				}
				return this._activityId;
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06008CAE RID: 36014 RVA: 0x0015943C File Offset: 0x0015763C
		public Guid RelatedActivityId
		{
			get
			{
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				if (moreInfo == null)
				{
					return default(Guid);
				}
				return moreInfo.RelatedActivityId;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06008CAF RID: 36015 RVA: 0x00159462 File Offset: 0x00157662
		// (set) Token: 0x06008CB0 RID: 36016 RVA: 0x0015946A File Offset: 0x0015766A
		public ReadOnlyCollection<object> Payload { get; internal set; }

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x00159473 File Offset: 0x00157673
		// (set) Token: 0x06008CB2 RID: 36018 RVA: 0x001594A1 File Offset: 0x001576A1
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public ReadOnlyCollection<string> PayloadNames
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				ReadOnlyCollection<string> result;
				if ((result = ((moreInfo != null) ? moreInfo.PayloadNames : null)) == null)
				{
					if (this.EventId > 0)
					{
						return this.Metadata.ParameterNames;
					}
					result = null;
				}
				return result;
			}
			internal set
			{
				this.MoreInfo.PayloadNames = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x001594AF File Offset: 0x001576AF
		[Nullable(1)]
		public EventSource EventSource { [NullableContext(1)] get; }

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06008CB4 RID: 36020 RVA: 0x001594B7 File Offset: 0x001576B7
		// (set) Token: 0x06008CB5 RID: 36021 RVA: 0x001594E5 File Offset: 0x001576E5
		public EventKeywords Keywords
		{
			get
			{
				if (this.EventId > 0)
				{
					return (EventKeywords)this.Metadata.Descriptor.Keywords;
				}
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				if (moreInfo == null)
				{
					return EventKeywords.None;
				}
				return moreInfo.Keywords;
			}
			internal set
			{
				this.MoreInfo.Keywords = value;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06008CB6 RID: 36022 RVA: 0x001594F3 File Offset: 0x001576F3
		// (set) Token: 0x06008CB7 RID: 36023 RVA: 0x00159520 File Offset: 0x00157720
		public EventOpcode Opcode
		{
			get
			{
				if (this.EventId > 0)
				{
					return (EventOpcode)this.Metadata.Descriptor.Opcode;
				}
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				if (moreInfo == null)
				{
					return EventOpcode.Info;
				}
				return moreInfo.Opcode;
			}
			internal set
			{
				this.MoreInfo.Opcode = value;
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06008CB8 RID: 36024 RVA: 0x0015952E File Offset: 0x0015772E
		public EventTask Task
		{
			get
			{
				if (this.EventId > 0)
				{
					return (EventTask)this.Metadata.Descriptor.Task;
				}
				return EventTask.None;
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06008CB9 RID: 36025 RVA: 0x0015954B File Offset: 0x0015774B
		// (set) Token: 0x06008CBA RID: 36026 RVA: 0x00159573 File Offset: 0x00157773
		public EventTags Tags
		{
			get
			{
				if (this.EventId > 0)
				{
					return this.Metadata.Tags;
				}
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				if (moreInfo == null)
				{
					return EventTags.None;
				}
				return moreInfo.Tags;
			}
			internal set
			{
				this.MoreInfo.Tags = value;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06008CBB RID: 36027 RVA: 0x00159581 File Offset: 0x00157781
		// (set) Token: 0x06008CBC RID: 36028 RVA: 0x001595AF File Offset: 0x001577AF
		public string Message
		{
			get
			{
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				string result;
				if ((result = ((moreInfo != null) ? moreInfo.Message : null)) == null)
				{
					if (this.EventId > 0)
					{
						return this.Metadata.Message;
					}
					result = null;
				}
				return result;
			}
			internal set
			{
				this.MoreInfo.Message = value;
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06008CBD RID: 36029 RVA: 0x001595BD File Offset: 0x001577BD
		public EventChannel Channel
		{
			get
			{
				if (this.EventId > 0)
				{
					return (EventChannel)this.Metadata.Descriptor.Channel;
				}
				return EventChannel.None;
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06008CBE RID: 36030 RVA: 0x001595DA File Offset: 0x001577DA
		public byte Version
		{
			get
			{
				if (this.EventId > 0)
				{
					return this.Metadata.Descriptor.Version;
				}
				return 0;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06008CBF RID: 36031 RVA: 0x001595F7 File Offset: 0x001577F7
		// (set) Token: 0x06008CC0 RID: 36032 RVA: 0x00159624 File Offset: 0x00157824
		public EventLevel Level
		{
			get
			{
				if (this.EventId > 0)
				{
					return (EventLevel)this.Metadata.Descriptor.Level;
				}
				EventWrittenEventArgs.MoreEventInfo moreInfo = this._moreInfo;
				if (moreInfo == null)
				{
					return EventLevel.LogAlways;
				}
				return moreInfo.Level;
			}
			internal set
			{
				this.MoreInfo.Level = value;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x00159634 File Offset: 0x00157834
		// (set) Token: 0x06008CC2 RID: 36034 RVA: 0x0015966B File Offset: 0x0015786B
		public long OSThreadId
		{
			get
			{
				ref long? ptr = ref this.MoreInfo.OsThreadId;
				if (ptr == null)
				{
					ptr = new long?((long)Thread.CurrentOSThreadId);
				}
				return ptr.Value;
			}
			internal set
			{
				this.MoreInfo.OsThreadId = new long?(value);
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06008CC3 RID: 36035 RVA: 0x0015967E File Offset: 0x0015787E
		// (set) Token: 0x06008CC4 RID: 36036 RVA: 0x00159686 File Offset: 0x00157886
		public DateTime TimeStamp { get; internal set; }

		// Token: 0x06008CC5 RID: 36037 RVA: 0x0015968F File Offset: 0x0015788F
		internal EventWrittenEventArgs(EventSource eventSource, int eventId)
		{
			this.EventSource = eventSource;
			this.EventId = eventId;
			this.TimeStamp = DateTime.UtcNow;
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x001596B0 File Offset: 0x001578B0
		internal unsafe EventWrittenEventArgs(EventSource eventSource, int eventId, Guid* pActivityID, Guid* pChildActivityID) : this(eventSource, eventId)
		{
			if (pActivityID != null)
			{
				this._activityId = *pActivityID;
			}
			if (pChildActivityID != null)
			{
				this.MoreInfo.RelatedActivityId = *pChildActivityID;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06008CC7 RID: 36039 RVA: 0x001596E4 File Offset: 0x001578E4
		[Nullable(1)]
		private EventWrittenEventArgs.MoreEventInfo MoreInfo
		{
			get
			{
				EventWrittenEventArgs.MoreEventInfo result;
				if ((result = this._moreInfo) == null)
				{
					result = (this._moreInfo = new EventWrittenEventArgs.MoreEventInfo());
				}
				return result;
			}
		}

		// Token: 0x04002007 RID: 8199
		private Guid _activityId;

		// Token: 0x0400200B RID: 8203
		private EventWrittenEventArgs.MoreEventInfo _moreInfo;

		// Token: 0x020008F7 RID: 2295
		private sealed class MoreEventInfo
		{
			// Token: 0x0400200C RID: 8204
			public string Message;

			// Token: 0x0400200D RID: 8205
			public string EventName;

			// Token: 0x0400200E RID: 8206
			public ReadOnlyCollection<string> PayloadNames;

			// Token: 0x0400200F RID: 8207
			public Guid RelatedActivityId;

			// Token: 0x04002010 RID: 8208
			public long? OsThreadId;

			// Token: 0x04002011 RID: 8209
			public EventTags Tags;

			// Token: 0x04002012 RID: 8210
			public EventOpcode Opcode;

			// Token: 0x04002013 RID: 8211
			public EventLevel Level;

			// Token: 0x04002014 RID: 8212
			public EventKeywords Keywords;
		}
	}
}
