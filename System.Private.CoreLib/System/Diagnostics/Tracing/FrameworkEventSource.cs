using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000907 RID: 2311
	[EventSource(Guid = "8E9F5090-2D75-4d03-8A81-E5AFBF85DAF1", Name = "System.Diagnostics.Eventing.FrameworkEventSource")]
	[GeneratedCode("System.Private.CoreLib.Generators", "42.42.42.42")]
	internal sealed class FrameworkEventSource : EventSource
	{
		// Token: 0x06008D1A RID: 36122 RVA: 0x000C2E1D File Offset: 0x000C101D
		private FrameworkEventSource(int _)
		{
		}

		// Token: 0x06008D1B RID: 36123 RVA: 0x0015B758 File Offset: 0x00159958
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[NonEvent]
		private unsafe void WriteEvent(int eventId, long arg1, int arg2, string arg3, bool arg4, int arg5, int arg6)
		{
			if (base.IsEnabled())
			{
				if (arg3 == null)
				{
					arg3 = "";
				}
				char* ptr;
				if (arg3 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg3.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = &arg1;
				ptr3->Size = 8;
				ptr3->Reserved = 0;
				ptr3[1].DataPointer = &arg2;
				ptr3[1].Size = 4;
				ptr3[1].Reserved = 0;
				ptr3[2].DataPointer = dataPointer;
				ptr3[2].Size = (arg3.Length + 1) * 2;
				ptr3[2].Reserved = 0;
				ptr3[3].DataPointer = &arg4;
				ptr3[3].Size = 4;
				ptr3[3].Reserved = 0;
				ptr3[4].DataPointer = &arg5;
				ptr3[4].Size = 4;
				ptr3[4].Reserved = 0;
				ptr3[5].DataPointer = &arg6;
				ptr3[5].Size = 4;
				ptr3[5].Reserved = 0;
				base.WriteEventCore(eventId, 6, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x0015B8C8 File Offset: 0x00159AC8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[NonEvent]
		private unsafe void WriteEvent(int eventId, long arg1, int arg2, string arg3)
		{
			if (base.IsEnabled())
			{
				if (arg3 == null)
				{
					arg3 = "";
				}
				char* ptr;
				if (arg3 == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = arg3.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->DataPointer = &arg1;
				ptr3->Size = 8;
				ptr3->Reserved = 0;
				ptr3[1].DataPointer = &arg2;
				ptr3[1].Size = 4;
				ptr3[1].Reserved = 0;
				ptr3[2].DataPointer = dataPointer;
				ptr3[2].Size = (arg3.Length + 1) * 2;
				ptr3[2].Reserved = 0;
				base.WriteEventCore(eventId, 3, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x0015B996 File Offset: 0x00159B96
		[Event(30, Level = EventLevel.Verbose, Keywords = (EventKeywords)18L)]
		public void ThreadPoolEnqueueWork(long workID)
		{
			base.WriteEvent(30, workID);
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x0015B9A1 File Offset: 0x00159BA1
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ThreadPoolEnqueueWorkObject(object workID)
		{
			this.ThreadPoolEnqueueWork((long)workID.GetHashCode());
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x0015B9B0 File Offset: 0x00159BB0
		[Event(31, Level = EventLevel.Verbose, Keywords = (EventKeywords)18L)]
		public void ThreadPoolDequeueWork(long workID)
		{
			base.WriteEvent(31, workID);
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x0015B9BB File Offset: 0x00159BBB
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ThreadPoolDequeueWorkObject(object workID)
		{
			this.ThreadPoolDequeueWork((long)workID.GetHashCode());
		}

		// Token: 0x06008D21 RID: 36129 RVA: 0x0015B9CA File Offset: 0x00159BCA
		[Event(150, Level = EventLevel.Informational, Keywords = (EventKeywords)16L, Task = (EventTask)3, Opcode = EventOpcode.Send)]
		public void ThreadTransferSend(long id, int kind, string info, bool multiDequeues, int intInfo1, int intInfo2)
		{
			this.WriteEvent(150, id, kind, info, multiDequeues, intInfo1, intInfo2);
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x0015B9E0 File Offset: 0x00159BE0
		[NonEvent]
		public void ThreadTransferSendObj(object id, int kind, string info, bool multiDequeues, int intInfo1, int intInfo2)
		{
			this.ThreadTransferSend((long)id.GetHashCode(), kind, info, multiDequeues, intInfo1, intInfo2);
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x0015B9F7 File Offset: 0x00159BF7
		[Event(151, Level = EventLevel.Informational, Keywords = (EventKeywords)16L, Task = (EventTask)3, Opcode = EventOpcode.Receive)]
		public void ThreadTransferReceive(long id, int kind, string info)
		{
			this.WriteEvent(151, id, kind, info);
		}

		// Token: 0x06008D24 RID: 36132 RVA: 0x0015BA07 File Offset: 0x00159C07
		[NonEvent]
		public void ThreadTransferReceiveObj(object id, int kind, string info)
		{
			this.ThreadTransferReceive((long)id.GetHashCode(), kind, info);
		}

		// Token: 0x06008D25 RID: 36133 RVA: 0x0015BA18 File Offset: 0x00159C18
		private FrameworkEventSource() : base(new Guid(2392805520U, 11637, 19715, 138, 129, 229, 175, 191, 133, 218, 241), "System.Diagnostics.Eventing.FrameworkEventSource")
		{
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06008D26 RID: 36134 RVA: 0x0015BA6C File Offset: 0x00159C6C
		private protected unsafe override ReadOnlySpan<byte> ProviderMetadata
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.8D5BDF3711F3634F3CEED3F62BDC8BC9E1CCD8F1B6240B8C89F1FF2E3FA6C0AB), 51);
			}
		}

		// Token: 0x04002059 RID: 8281
		private const string EventSourceSuppressMessage = "Parameters to this method are primitive and are trimmer safe";

		// Token: 0x0400205A RID: 8282
		public static readonly FrameworkEventSource Log = new FrameworkEventSource();

		// Token: 0x02000908 RID: 2312
		public static class Keywords
		{
			// Token: 0x0400205B RID: 8283
			public const EventKeywords ThreadPool = (EventKeywords)2L;

			// Token: 0x0400205C RID: 8284
			public const EventKeywords ThreadTransfer = (EventKeywords)16L;
		}

		// Token: 0x02000909 RID: 2313
		public static class Tasks
		{
			// Token: 0x0400205D RID: 8285
			public const EventTask ThreadTransfer = (EventTask)3;
		}
	}
}
