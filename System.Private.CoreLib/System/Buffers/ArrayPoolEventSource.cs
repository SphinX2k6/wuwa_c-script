using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

namespace System.Buffers
{
	// Token: 0x0200033F RID: 831
	[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
	[GeneratedCode("System.Private.CoreLib.Generators", "42.42.42.42")]
	internal sealed class ArrayPoolEventSource : EventSource
	{
		// Token: 0x06003A95 RID: 14997 RVA: 0x000C2E1D File Offset: 0x000C101D
		private ArrayPoolEventSource(int _)
		{
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x000C2E28 File Offset: 0x000C1028
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(1, Level = EventLevel.Verbose)]
		internal unsafe void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId)
		{
			EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(EventSource.EventData))];
			ptr->Size = 4;
			ptr->DataPointer = &bufferId;
			ptr->Reserved = 0;
			ptr[1].Size = 4;
			ptr[1].DataPointer = &bufferSize;
			ptr[1].Reserved = 0;
			ptr[2].Size = 4;
			ptr[2].DataPointer = &poolId;
			ptr[2].Reserved = 0;
			ptr[3].Size = 4;
			ptr[3].DataPointer = &bucketId;
			ptr[3].Reserved = 0;
			base.WriteEventCore(1, 4, ptr);
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x000C2EF8 File Offset: 0x000C10F8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(2, Level = EventLevel.Informational)]
		internal unsafe void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason)
		{
			EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(EventSource.EventData))];
			ptr->Size = 4;
			ptr->DataPointer = &bufferId;
			ptr->Reserved = 0;
			ptr[1].Size = 4;
			ptr[1].DataPointer = &bufferSize;
			ptr[1].Reserved = 0;
			ptr[2].Size = 4;
			ptr[2].DataPointer = &poolId;
			ptr[2].Reserved = 0;
			ptr[3].Size = 4;
			ptr[3].DataPointer = &bucketId;
			ptr[3].Reserved = 0;
			ptr[4].Size = 4;
			ptr[4].DataPointer = &reason;
			ptr[4].Reserved = 0;
			base.WriteEventCore(2, 5, ptr);
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x000C2FFC File Offset: 0x000C11FC
		[Event(3, Level = EventLevel.Verbose)]
		internal void BufferReturned(int bufferId, int bufferSize, int poolId)
		{
			base.WriteEvent(3, bufferId, bufferSize, poolId);
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x000C3008 File Offset: 0x000C1208
		[Event(4, Level = EventLevel.Informational)]
		internal void BufferTrimmed(int bufferId, int bufferSize, int poolId)
		{
			base.WriteEvent(4, bufferId, bufferSize, poolId);
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x000C3014 File Offset: 0x000C1214
		[Event(5, Level = EventLevel.Informational)]
		internal void BufferTrimPoll(int milliseconds, int pressure)
		{
			base.WriteEvent(5, milliseconds, pressure);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x000C3020 File Offset: 0x000C1220
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(6, Level = EventLevel.Informational)]
		internal unsafe void BufferDropped(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferDroppedReason reason)
		{
			EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(EventSource.EventData))];
			ptr->Size = 4;
			ptr->DataPointer = &bufferId;
			ptr->Reserved = 0;
			ptr[1].Size = 4;
			ptr[1].DataPointer = &bufferSize;
			ptr[1].Reserved = 0;
			ptr[2].Size = 4;
			ptr[2].DataPointer = &poolId;
			ptr[2].Reserved = 0;
			ptr[3].Size = 4;
			ptr[3].DataPointer = &bucketId;
			ptr[3].Reserved = 0;
			ptr[4].Size = 4;
			ptr[4].DataPointer = &reason;
			ptr[4].Reserved = 0;
			base.WriteEventCore(6, 5, ptr);
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x000C3124 File Offset: 0x000C1324
		private ArrayPoolEventSource() : base(new Guid(140948152, 23791, 23993, 38, 18, 12, 15, 253, 129, 74, 68), "System.Buffers.ArrayPoolEventSource")
		{
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06003A9D RID: 15005 RVA: 0x000C3166 File Offset: 0x000C1366
		private protected unsafe override ReadOnlySpan<byte> ProviderMetadata
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.BDC6017FA1DC8EA922762ACBB66B7B75F7AD9C6A26978066D5522C095ECAFD73), 38);
			}
		}

		// Token: 0x04000C31 RID: 3121
		private const string EventSourceSuppressMessage = "Parameters to this method are primitive and are trimmer safe";

		// Token: 0x04000C32 RID: 3122
		internal static readonly ArrayPoolEventSource Log = new ArrayPoolEventSource();

		// Token: 0x04000C33 RID: 3123
		internal const int NoBucketId = -1;

		// Token: 0x02000340 RID: 832
		internal enum BufferAllocatedReason
		{
			// Token: 0x04000C35 RID: 3125
			Pooled,
			// Token: 0x04000C36 RID: 3126
			OverMaximumSize,
			// Token: 0x04000C37 RID: 3127
			PoolExhausted
		}

		// Token: 0x02000341 RID: 833
		internal enum BufferDroppedReason
		{
			// Token: 0x04000C39 RID: 3129
			Full,
			// Token: 0x04000C3A RID: 3130
			OverMaximumSize
		}
	}
}
