using System;
using System.Collections.Generic;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200092A RID: 2346
	internal sealed class NameInfo : ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo>
	{
		// Token: 0x06008DBC RID: 36284 RVA: 0x0015DA00 File Offset: 0x0015BC00
		internal static void ReserveEventIDsBelow(int eventId)
		{
			int num;
			int num2;
			do
			{
				num = NameInfo.lastIdentity;
				num2 = (NameInfo.lastIdentity & -16777216) + eventId;
				num2 = Math.Max(num2, num);
			}
			while (Interlocked.CompareExchange(ref NameInfo.lastIdentity, num2, num) != num);
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x0015DA38 File Offset: 0x0015BC38
		public NameInfo(string name, EventTags tags, int typeMetadataSize)
		{
			this.name = name;
			this.tags = (tags & (EventTags)268435455);
			this.identity = Interlocked.Increment(ref NameInfo.lastIdentity);
			int prefixSize = 0;
			Statics.EncodeTags((int)this.tags, ref prefixSize, null);
			this.nameMetadata = Statics.MetadataForString(name, prefixSize, 0, typeMetadataSize);
			prefixSize = 2;
			Statics.EncodeTags((int)this.tags, ref prefixSize, this.nameMetadata);
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x0015DAA3 File Offset: 0x0015BCA3
		public override int Compare(NameInfo other)
		{
			return this.Compare(other.name, other.tags);
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x0015DAB7 File Offset: 0x0015BCB7
		public override int Compare(KeyValuePair<string, EventTags> key)
		{
			return this.Compare(key.Key, key.Value & (EventTags)268435455);
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x0015DAD4 File Offset: 0x0015BCD4
		private int Compare(string otherName, EventTags otherTags)
		{
			int num = StringComparer.Ordinal.Compare(this.name, otherName);
			if (num == 0 && this.tags != otherTags)
			{
				num = ((this.tags < otherTags) ? -1 : 1);
			}
			return num;
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x0015DB10 File Offset: 0x0015BD10
		public unsafe IntPtr GetOrCreateEventHandle(EventProvider provider, TraceLoggingEventHandleTable eventHandleTable, EventDescriptor descriptor, TraceLoggingEventTypes eventTypes)
		{
			IntPtr intPtr;
			if ((intPtr = eventHandleTable[descriptor.EventId]) == IntPtr.Zero)
			{
				lock (eventHandleTable)
				{
					if ((intPtr = eventHandleTable[descriptor.EventId]) == IntPtr.Zero)
					{
						byte[] array = EventPipeMetadataGenerator.Instance.GenerateEventMetadata(descriptor.EventId, this.name, (EventKeywords)descriptor.Keywords, (EventLevel)descriptor.Level, (uint)descriptor.Version, (EventOpcode)descriptor.Opcode, eventTypes);
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
						intPtr = provider._eventProvider.DefineEventHandle((uint)descriptor.EventId, this.name, descriptor.Keywords, (uint)descriptor.Version, (uint)descriptor.Level, pMetadata, metadataLength);
						array2 = null;
						eventHandleTable.SetEventHandle(descriptor.EventId, intPtr);
					}
				}
			}
			return intPtr;
		}

		// Token: 0x04002104 RID: 8452
		private static int lastIdentity = 184549376;

		// Token: 0x04002105 RID: 8453
		internal readonly string name;

		// Token: 0x04002106 RID: 8454
		internal readonly EventTags tags;

		// Token: 0x04002107 RID: 8455
		internal readonly int identity;

		// Token: 0x04002108 RID: 8456
		internal readonly byte[] nameMetadata;
	}
}
