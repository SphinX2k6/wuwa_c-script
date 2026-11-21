using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008C0 RID: 2240
	[EventSource(Guid = "E13C0D23-CCBC-4E12-931B-D9CC2EEE27E4", Name = "Microsoft-Windows-DotNETRuntime")]
	[GeneratedCode("System.Private.CoreLib.Generators", "42.42.42.42")]
	internal sealed class NativeRuntimeEventSource : EventSource
	{
		// Token: 0x06008A3E RID: 35390
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogContentionLockCreated(IntPtr LockID, IntPtr AssociatedObjectID, ushort ClrInstanceID);

		// Token: 0x06008A3F RID: 35391
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogContentionStart(NativeRuntimeEventSource.ContentionFlagsMap ContentionFlags, ushort ClrInstanceID, IntPtr LockID, IntPtr AssociatedObjectID, ulong LockOwnerThreadID);

		// Token: 0x06008A40 RID: 35392
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogContentionStop(NativeRuntimeEventSource.ContentionFlagsMap ContentionFlags, ushort ClrInstanceID, double DurationNs);

		// Token: 0x06008A41 RID: 35393
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolWorkerThreadStart(uint ActiveWorkerThreadCount, uint RetiredWorkerThreadCount, ushort ClrInstanceID);

		// Token: 0x06008A42 RID: 35394
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolWorkerThreadStop(uint ActiveWorkerThreadCount, uint RetiredWorkerThreadCount, ushort ClrInstanceID);

		// Token: 0x06008A43 RID: 35395
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolWorkerThreadWait(uint ActiveWorkerThreadCount, uint RetiredWorkerThreadCount, ushort ClrInstanceID);

		// Token: 0x06008A44 RID: 35396
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolMinMaxThreads(ushort MinWorkerThreads, ushort MaxWorkerThreads, ushort MinIOCompletionThreads, ushort MaxIOCompletionThreads, ushort ClrInstanceID);

		// Token: 0x06008A45 RID: 35397
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolWorkerThreadAdjustmentSample(double Throughput, ushort ClrInstanceID);

		// Token: 0x06008A46 RID: 35398
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolWorkerThreadAdjustmentAdjustment(double AverageThroughput, uint NewWorkerThreadCount, NativeRuntimeEventSource.ThreadAdjustmentReasonMap Reason, ushort ClrInstanceID);

		// Token: 0x06008A47 RID: 35399
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolWorkerThreadAdjustmentStats(double Duration, double Throughput, double ThreadPoolWorkerThreadWait, double ThroughputWave, double ThroughputErrorEstimate, double AverageThroughputErrorEstimate, double ThroughputRatio, double Confidence, double NewControlSetting, ushort NewThreadWaveMagnitude, ushort ClrInstanceID);

		// Token: 0x06008A48 RID: 35400
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolIOEnqueue(IntPtr NativeOverlapped, IntPtr Overlapped, bool MultiDequeues, ushort ClrInstanceID);

		// Token: 0x06008A49 RID: 35401
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolIODequeue(IntPtr NativeOverlapped, IntPtr Overlapped, ushort ClrInstanceID);

		// Token: 0x06008A4A RID: 35402
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolWorkingThreadCount(uint Count, ushort ClrInstanceID);

		// Token: 0x06008A4B RID: 35403
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogThreadPoolIOPack(IntPtr NativeOverlapped, IntPtr Overlapped, ushort ClrInstanceID);

		// Token: 0x06008A4C RID: 35404
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogWaitHandleWaitStart(NativeRuntimeEventSource.WaitHandleWaitSourceMap WaitSource, IntPtr AssociatedObjectID, ushort ClrInstanceID);

		// Token: 0x06008A4D RID: 35405
		[NonEvent]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LogWaitHandleWaitStop(ushort ClrInstanceID);

		// Token: 0x06008A4E RID: 35406 RVA: 0x000C2E1D File Offset: 0x000C101D
		private NativeRuntimeEventSource(int _)
		{
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x0014ED7C File Offset: 0x0014CF7C
		[NonEvent]
		internal unsafe void ProcessEvent(uint eventID, uint osThreadID, DateTime timeStamp, Guid activityId, Guid childActivityId, ReadOnlySpan<byte> payload)
		{
			if (!System.Diagnostics.Tracing.EventSource.IsSupported)
			{
				return;
			}
			if ((ulong)eventID >= (ulong)((long)this.m_eventData.Length))
			{
				return;
			}
			object[] list = EventPipePayloadDecoder.DecodePayload(ref this.m_eventData[(int)eventID], payload);
			EventWrittenEventArgs eventCallbackArgs = new EventWrittenEventArgs(this, (int)eventID, &activityId, &childActivityId)
			{
				OSThreadId = (long)osThreadID,
				TimeStamp = timeStamp,
				Payload = new ReadOnlyCollection<object>(list)
			};
			base.DispatchToAllListeners(eventCallbackArgs);
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x0014EDE7 File Offset: 0x0014CFE7
		[Event(90, Level = EventLevel.Informational, Message = "LockID={0};\nAssociatedObjectID={1};\nClrInstanceID={2}", Task = (EventTask)8, Opcode = EventOpcode.Info, Version = 0, Keywords = (EventKeywords)16384L)]
		private void ContentionLockCreated(IntPtr LockID, IntPtr AssociatedObjectID, ushort ClrInstanceID = 0)
		{
			NativeRuntimeEventSource.LogContentionLockCreated(LockID, AssociatedObjectID, ClrInstanceID);
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x0014EDF1 File Offset: 0x0014CFF1
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ContentionLockCreated(Lock lockObj)
		{
			this.ContentionLockCreated(lockObj.LockIdForEvents, System.Diagnostics.Tracing.EventSource.ObjectIDForEvents(lockObj), 0);
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x0014EE06 File Offset: 0x0014D006
		[Event(81, Level = EventLevel.Informational, Message = "ContentionFlags={0};\nClrInstanceID={1};\nLockID={2};\nAssociatedObjectID={3}\nLockOwnerThreadID={4}", Task = (EventTask)8, Opcode = EventOpcode.Start, Version = 2, Keywords = (EventKeywords)16384L)]
		private void ContentionStart(NativeRuntimeEventSource.ContentionFlagsMap ContentionFlags, ushort ClrInstanceID, IntPtr LockID, IntPtr AssociatedObjectID, ulong LockOwnerThreadID)
		{
			NativeRuntimeEventSource.LogContentionStart(ContentionFlags, ClrInstanceID, LockID, AssociatedObjectID, LockOwnerThreadID);
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x0014EE14 File Offset: 0x0014D014
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ContentionStart(Lock lockObj)
		{
			this.ContentionStart(NativeRuntimeEventSource.ContentionFlagsMap.Managed, 0, lockObj.LockIdForEvents, System.Diagnostics.Tracing.EventSource.ObjectIDForEvents(lockObj), lockObj.OwningThreadId);
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x0014EE30 File Offset: 0x0014D030
		[Event(91, Level = EventLevel.Informational, Message = "ContentionFlags={0};\nClrInstanceID={1};\nDurationNs={2}", Task = (EventTask)8, Opcode = EventOpcode.Stop, Version = 1, Keywords = (EventKeywords)16384L)]
		private void ContentionStop(NativeRuntimeEventSource.ContentionFlagsMap ContentionFlags, ushort ClrInstanceID, double DurationNs)
		{
			NativeRuntimeEventSource.LogContentionStop(ContentionFlags, ClrInstanceID, DurationNs);
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x0014EE3A File Offset: 0x0014D03A
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ContentionStop(double durationNs)
		{
			this.ContentionStop(NativeRuntimeEventSource.ContentionFlagsMap.Managed, 0, durationNs);
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x0014EE45 File Offset: 0x0014D045
		[Event(50, Level = EventLevel.Informational, Message = "ActiveWorkerThreadCount={0};\nRetiredWorkerThreadCount={1};\nClrInstanceID={2}", Task = (EventTask)16, Opcode = EventOpcode.Start, Version = 0, Keywords = (EventKeywords)65536L)]
		public void ThreadPoolWorkerThreadStart(uint ActiveWorkerThreadCount, uint RetiredWorkerThreadCount = 0U, ushort ClrInstanceID = 0)
		{
			if (base.IsEnabled(EventLevel.Informational, (EventKeywords)65536L))
			{
				NativeRuntimeEventSource.LogThreadPoolWorkerThreadStart(ActiveWorkerThreadCount, RetiredWorkerThreadCount, ClrInstanceID);
			}
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x0014EE5E File Offset: 0x0014D05E
		[Event(51, Level = EventLevel.Informational, Message = "ActiveWorkerThreadCount={0};\nRetiredWorkerThreadCount={1};\nClrInstanceID={2}", Task = (EventTask)16, Opcode = EventOpcode.Stop, Version = 0, Keywords = (EventKeywords)65536L)]
		public void ThreadPoolWorkerThreadStop(uint ActiveWorkerThreadCount, uint RetiredWorkerThreadCount = 0U, ushort ClrInstanceID = 0)
		{
			if (base.IsEnabled(EventLevel.Informational, (EventKeywords)65536L))
			{
				NativeRuntimeEventSource.LogThreadPoolWorkerThreadStop(ActiveWorkerThreadCount, RetiredWorkerThreadCount, ClrInstanceID);
			}
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x0014EE77 File Offset: 0x0014D077
		[Event(57, Level = EventLevel.Informational, Message = "ActiveWorkerThreadCount={0};\nRetiredWorkerThreadCount={1};\nClrInstanceID={2}", Task = (EventTask)16, Opcode = (EventOpcode)90, Version = 0, Keywords = (EventKeywords)65536L)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ThreadPoolWorkerThreadWait(uint ActiveWorkerThreadCount, uint RetiredWorkerThreadCount = 0U, ushort ClrInstanceID = 0)
		{
			if (base.IsEnabled(EventLevel.Informational, (EventKeywords)65536L))
			{
				NativeRuntimeEventSource.LogThreadPoolWorkerThreadWait(ActiveWorkerThreadCount, RetiredWorkerThreadCount, ClrInstanceID);
			}
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x0014EE90 File Offset: 0x0014D090
		[Event(54, Level = EventLevel.Informational, Message = "Throughput={0};\nClrInstanceID={1}", Task = (EventTask)18, Opcode = (EventOpcode)100, Version = 0, Keywords = (EventKeywords)65536L)]
		public void ThreadPoolWorkerThreadAdjustmentSample(double Throughput, ushort ClrInstanceID = 0)
		{
			if (!base.IsEnabled(EventLevel.Informational, (EventKeywords)65536L))
			{
				return;
			}
			NativeRuntimeEventSource.LogThreadPoolWorkerThreadAdjustmentSample(Throughput, ClrInstanceID);
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x0014EEA9 File Offset: 0x0014D0A9
		[Event(55, Level = EventLevel.Informational, Message = "AverageThroughput={0};\nNewWorkerThreadCount={1};\nReason={2};\nClrInstanceID={3}", Task = (EventTask)18, Opcode = (EventOpcode)101, Version = 0, Keywords = (EventKeywords)65536L)]
		public void ThreadPoolWorkerThreadAdjustmentAdjustment(double AverageThroughput, uint NewWorkerThreadCount, NativeRuntimeEventSource.ThreadAdjustmentReasonMap Reason, ushort ClrInstanceID = 0)
		{
			if (!base.IsEnabled(EventLevel.Informational, (EventKeywords)65536L))
			{
				return;
			}
			NativeRuntimeEventSource.LogThreadPoolWorkerThreadAdjustmentAdjustment(AverageThroughput, NewWorkerThreadCount, Reason, ClrInstanceID);
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x0014EEC8 File Offset: 0x0014D0C8
		[Event(56, Level = EventLevel.Verbose, Message = "Duration={0};\nThroughput={1};\nThreadWave={2};\nThroughputWave={3};\nThroughputErrorEstimate={4};\nAverageThroughputErrorEstimate={5};\nThroughputRatio={6};\nConfidence={7};\nNewControlSetting={8};\nNewThreadWaveMagnitude={9};\nClrInstanceID={10}", Task = (EventTask)18, Opcode = (EventOpcode)102, Version = 0, Keywords = (EventKeywords)65536L)]
		public void ThreadPoolWorkerThreadAdjustmentStats(double Duration, double Throughput, double ThreadWave, double ThroughputWave, double ThroughputErrorEstimate, double AverageThroughputErrorEstimate, double ThroughputRatio, double Confidence, double NewControlSetting, ushort NewThreadWaveMagnitude, ushort ClrInstanceID = 0)
		{
			if (!base.IsEnabled(EventLevel.Verbose, (EventKeywords)65536L))
			{
				return;
			}
			NativeRuntimeEventSource.LogThreadPoolWorkerThreadAdjustmentStats(Duration, Throughput, ThreadWave, ThroughputWave, ThroughputErrorEstimate, AverageThroughputErrorEstimate, ThroughputRatio, Confidence, NewControlSetting, NewThreadWaveMagnitude, ClrInstanceID);
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x0014EEFD File Offset: 0x0014D0FD
		[Event(63, Level = EventLevel.Verbose, Message = "NativeOverlapped={0};\nOverlapped={1};\nMultiDequeues={2};\nClrInstanceID={3}", Task = (EventTask)23, Opcode = (EventOpcode)13, Version = 0, Keywords = (EventKeywords)2147549184L)]
		private void ThreadPoolIOEnqueue(IntPtr NativeOverlapped, IntPtr Overlapped, bool MultiDequeues, ushort ClrInstanceID = 0)
		{
			NativeRuntimeEventSource.LogThreadPoolIOEnqueue(NativeOverlapped, Overlapped, MultiDequeues, ClrInstanceID);
		}

		// Token: 0x06008A5D RID: 35421 RVA: 0x0014EF0C File Offset: 0x0014D10C
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void ThreadPoolIOEnqueue(NativeOverlapped* nativeOverlapped)
		{
			if (base.IsEnabled(EventLevel.Verbose, (EventKeywords)((ulong)-2147418112)))
			{
				IntPtr overlapped = ThreadPool.UseWindowsThreadPool ? ((IntPtr)0) : ((IntPtr)Overlapped.GetOverlappedFromNative(nativeOverlapped).GetHashCode());
				this.ThreadPoolIOEnqueue(nativeOverlapped, overlapped, false, 0);
			}
		}

		// Token: 0x06008A5E RID: 35422 RVA: 0x0014EF4A File Offset: 0x0014D14A
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ThreadPoolIOEnqueue(RegisteredWaitHandle registeredWaitHandle)
		{
			if (base.IsEnabled(EventLevel.Verbose, (EventKeywords)((ulong)-2147418112)))
			{
				this.ThreadPoolIOEnqueue((IntPtr)registeredWaitHandle.GetHashCode(), IntPtr.Zero, registeredWaitHandle.Repeating, 0);
			}
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x0014EF74 File Offset: 0x0014D174
		[Event(64, Level = EventLevel.Verbose, Message = "NativeOverlapped={0};\nOverlapped={1};\nClrInstanceID={2}", Task = (EventTask)23, Opcode = (EventOpcode)14, Version = 0, Keywords = (EventKeywords)2147549184L)]
		private void ThreadPoolIODequeue(IntPtr NativeOverlapped, IntPtr Overlapped, ushort ClrInstanceID = 0)
		{
			NativeRuntimeEventSource.LogThreadPoolIODequeue(NativeOverlapped, Overlapped, ClrInstanceID);
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x0014EF80 File Offset: 0x0014D180
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void ThreadPoolIODequeue(NativeOverlapped* nativeOverlapped)
		{
			if (base.IsEnabled(EventLevel.Verbose, (EventKeywords)((ulong)-2147418112)))
			{
				IntPtr overlapped = ThreadPool.UseWindowsThreadPool ? ((IntPtr)0) : ((IntPtr)Overlapped.GetOverlappedFromNative(nativeOverlapped).GetHashCode());
				this.ThreadPoolIODequeue(nativeOverlapped, overlapped, 0);
			}
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x0014EFBD File Offset: 0x0014D1BD
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ThreadPoolIODequeue(RegisteredWaitHandle registeredWaitHandle)
		{
			if (base.IsEnabled(EventLevel.Verbose, (EventKeywords)((ulong)-2147418112)))
			{
				this.ThreadPoolIODequeue((IntPtr)registeredWaitHandle.GetHashCode(), IntPtr.Zero, 0);
			}
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x0014EFE1 File Offset: 0x0014D1E1
		[Event(60, Level = EventLevel.Verbose, Message = "Count={0};\nClrInstanceID={1}", Task = (EventTask)22, Opcode = EventOpcode.Start, Version = 0, Keywords = (EventKeywords)65536L)]
		public void ThreadPoolWorkingThreadCount(uint Count, ushort ClrInstanceID = 0)
		{
			if (!base.IsEnabled(EventLevel.Verbose, (EventKeywords)65536L))
			{
				return;
			}
			NativeRuntimeEventSource.LogThreadPoolWorkingThreadCount(Count, ClrInstanceID);
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x0014EFFC File Offset: 0x0014D1FC
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void ThreadPoolIOPack(NativeOverlapped* nativeOverlapped)
		{
			if (base.IsEnabled(EventLevel.Verbose, (EventKeywords)65536L))
			{
				IntPtr overlapped = ThreadPool.UseWindowsThreadPool ? ((IntPtr)0) : ((IntPtr)Overlapped.GetOverlappedFromNative(nativeOverlapped).GetHashCode());
				this.ThreadPoolIOPack(nativeOverlapped, overlapped, 0);
			}
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x0014F039 File Offset: 0x0014D239
		[Event(65, Level = EventLevel.Verbose, Message = "NativeOverlapped={0};\nOverlapped={1};\nClrInstanceID={2}", Task = (EventTask)23, Opcode = (EventOpcode)15, Version = 0, Keywords = (EventKeywords)65536L)]
		private void ThreadPoolIOPack(IntPtr NativeOverlapped, IntPtr Overlapped, ushort ClrInstanceID = 0)
		{
			NativeRuntimeEventSource.LogThreadPoolIOPack(NativeOverlapped, Overlapped, ClrInstanceID);
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x0014F043 File Offset: 0x0014D243
		[Event(59, Level = EventLevel.Informational, Message = "MinWorkerThreads={0};\nMaxWorkerThreads={1};\nMinIOCompletionThreads={2};\nMaxIOCompletionThreads={3};\nClrInstanceID={4}", Task = (EventTask)38, Opcode = EventOpcode.Info, Version = 0, Keywords = (EventKeywords)65536L)]
		public void ThreadPoolMinMaxThreads(ushort MinWorkerThreads, ushort MaxWorkerThreads, ushort MinIOCompletionThreads, ushort MaxIOCompletionThreads, ushort ClrInstanceID = 0)
		{
			if (base.IsEnabled(EventLevel.Informational, (EventKeywords)65536L))
			{
				NativeRuntimeEventSource.LogThreadPoolMinMaxThreads(MinWorkerThreads, MaxWorkerThreads, MinIOCompletionThreads, MaxIOCompletionThreads, ClrInstanceID);
			}
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x0014F060 File Offset: 0x0014D260
		[Event(301, Level = EventLevel.Verbose, Message = "WaitSource={0};\nAssociatedObjectID={1};\nClrInstanceID={2}", Task = (EventTask)39, Opcode = EventOpcode.Start, Version = 0, Keywords = (EventKeywords)4398046511104L)]
		private void WaitHandleWaitStart(NativeRuntimeEventSource.WaitHandleWaitSourceMap WaitSource, IntPtr AssociatedObjectID, ushort ClrInstanceID = 0)
		{
			NativeRuntimeEventSource.LogWaitHandleWaitStart(WaitSource, AssociatedObjectID, ClrInstanceID);
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x0014F06A File Offset: 0x0014D26A
		[NonEvent]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WaitHandleWaitStart(NativeRuntimeEventSource.WaitHandleWaitSourceMap waitSource = NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown, object associatedObject = null)
		{
			this.WaitHandleWaitStart(waitSource, System.Diagnostics.Tracing.EventSource.ObjectIDForEvents(associatedObject), 0);
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x0014F07A File Offset: 0x0014D27A
		[Event(302, Level = EventLevel.Verbose, Message = "ClrInstanceID={0}", Task = (EventTask)39, Opcode = EventOpcode.Stop, Version = 0, Keywords = (EventKeywords)4398046511104L)]
		public void WaitHandleWaitStop(ushort ClrInstanceID = 0)
		{
			NativeRuntimeEventSource.LogWaitHandleWaitStop(ClrInstanceID);
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(1, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCStart_V2(uint Count, uint Depth, uint Reason, uint Type, ushort ClrInstanceID, ulong ClientSequenceNumber)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(2, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCEnd_V1(uint Count, uint Depth, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(3, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCRestartEEEnd_V1(ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(4, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCHeapStats_V2(ulong GenerationSize0, ulong TotalPromotedSize0, ulong GenerationSize1, ulong TotalPromotedSize1, ulong GenerationSize2, ulong TotalPromotedSize2, ulong GenerationSize3, ulong TotalPromotedSize3, ulong FinalizationPromotedSize, ulong FinalizationPromotedCount, uint PinnedObjectCount, uint SinkBlockCount, uint GCHandleCount, ushort ClrInstanceID, ulong GenerationSize4, ulong TotalPromotedSize4)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(5, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCCreateSegment_V1(ulong Address, ulong Size, uint Type, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(6, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCFreeSegment_V1(ulong Address, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(7, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCRestartEEBegin_V1(ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(8, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCSuspendEEEnd_V1(ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(9, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCSuspendEEBegin_V1(uint Reason, uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(10, Version = 4, Level = EventLevel.Verbose, Keywords = (EventKeywords)1L)]
		private void GCAllocationTick_V4(uint AllocationAmount, uint AllocationKind, ushort ClrInstanceID, ulong AllocationAmount64, IntPtr TypeID, string TypeName, uint HeapIndex, IntPtr Address, ulong ObjectSize)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(11, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)65537L)]
		private void GCCreateConcurrentThread_V1(ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(12, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)65537L)]
		private void GCTerminateConcurrentThread_V1(ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A75 RID: 35445 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(13, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCFinalizersEnd_V1(uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(14, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCFinalizersBegin_V1(ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(15, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)524288L)]
		private void BulkType(uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(16, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GCBulkRootEdge(uint Index, uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(17, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GCBulkRootConditionalWeakTableElementEdge(uint Index, uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(18, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GCBulkNode(uint Index, uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(19, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GCBulkEdge(uint Index, uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(20, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2097152L)]
		private void GCSampledObjectAllocationHigh(IntPtr Address, IntPtr TypeID, uint ObjectCountForTypeSample, ulong TotalSizeForTypeSample, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(21, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4194304L)]
		private void GCBulkSurvivingObjectRanges(uint Index, uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(22, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4194304L)]
		private void GCBulkMovedObjectRanges(uint Index, uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(23, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4194304L)]
		private void GCGenerationRange(byte Generation, IntPtr RangeStart, ulong RangeUsedLength, ulong RangeReservedLength, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(25, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCMarkStackRoots(uint HeapNum, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(26, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCMarkFinalizeQueueRoots(uint HeapNum, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(27, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCMarkHandles(uint HeapNum, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(28, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCMarkOlderGenerationRoots(uint HeapNum, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(29, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)1L)]
		private void FinalizeObject(IntPtr TypeID, IntPtr ObjectID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A85 RID: 35461 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(30, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2L)]
		private void SetGCHandle(IntPtr HandleID, IntPtr ObjectID, uint Kind, uint Generation, ulong AppDomainID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(31, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2L)]
		private void DestroyGCHandle(IntPtr HandleID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A87 RID: 35463 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(32, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)33554432L)]
		private void GCSampledObjectAllocationLow(IntPtr Address, IntPtr TypeID, uint ObjectCountForTypeSample, ulong TotalSizeForTypeSample, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(33, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)1L)]
		private void PinObjectAtGCTime(IntPtr HandleID, IntPtr ObjectID, ulong ObjectSize, string TypeName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(35, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCTriggered(uint Reason, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(36, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GCBulkRootCCW(uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A8B RID: 35467 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(37, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GCBulkRCW(uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(38, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GCBulkRootStaticVar(uint Count, ulong AppDomainID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(39, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)66060291L)]
		private void GCDynamicEvent(string Name, uint DataSize)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(40, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void WorkerThreadCreate(uint WorkerThreadCount, uint RetiredWorkerThreads)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(41, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void WorkerThreadTerminate(uint WorkerThreadCount, uint RetiredWorkerThreads)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(42, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void WorkerThreadRetire(uint WorkerThreadCount, uint RetiredWorkerThreads)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(43, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void WorkerThreadUnretire(uint WorkerThreadCount, uint RetiredWorkerThreads)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(44, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void IOThreadCreate_V1(uint IOThreadCount, uint RetiredIOThreads, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(45, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void IOThreadTerminate_V1(uint IOThreadCount, uint RetiredIOThreads, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(46, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void IOThreadRetire_V1(uint IOThreadCount, uint RetiredIOThreads, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(47, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void IOThreadUnretire_V1(uint IOThreadCount, uint RetiredIOThreads, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A96 RID: 35478 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(48, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void ThreadpoolSuspensionSuspendThread(uint ClrThreadID, uint CpuUtilization)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(49, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void ThreadpoolSuspensionResumeThread(uint ClrThreadID, uint CpuUtilization)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A98 RID: 35480 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(58, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)65536L)]
		private void YieldProcessorMeasurement(ushort ClrInstanceID, double NsPerYield, double EstablishedNsPerYield)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(70, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2147549184L)]
		private void ThreadCreating(IntPtr ID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(71, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2147549184L)]
		private void ThreadRunning(IntPtr ID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(72, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)274877906944L)]
		private void MethodDetails(ulong MethodID, ulong TypeID, uint MethodToken, uint TypeParameterCount, ulong LoaderModuleID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(73, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)549755813888L)]
		private void TypeLoadStart(uint TypeLoadStartID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(74, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)549755813888L)]
		private void TypeLoadStop(uint TypeLoadStartID, ushort ClrInstanceID, ushort LoadLevel, ulong TypeID, string TypeName)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(80, Version = 1, Level = EventLevel.Error, Keywords = (EventKeywords)8589967360L)]
		private void ExceptionThrown_V1(string ExceptionType, string ExceptionMessage, IntPtr ExceptionEIP, uint ExceptionHRESULT, ushort ExceptionFlags, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(250, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)32768L)]
		private void ExceptionCatchStart(ulong EntryEIP, ulong MethodID, string MethodName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(251, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)32768L)]
		private void ExceptionCatchStop()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(252, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)32768L)]
		private void ExceptionFinallyStart(ulong EntryEIP, ulong MethodID, string MethodName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(253, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)32768L)]
		private void ExceptionFinallyStop()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(254, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)32768L)]
		private void ExceptionFilterStart(ulong EntryEIP, ulong MethodID, string MethodName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(255, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)32768L)]
		private void ExceptionFilterStop()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(256, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)32768L)]
		private void ExceptionThrownStop()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(82, Version = 0, Level = EventLevel.LogAlways, Keywords = (EventKeywords)1073741824L)]
		private void CLRStackWalk(ushort ClrInstanceID, byte Reserved1, byte Reserved2, uint FrameCount)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(83, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2048L)]
		private void AppDomainMemAllocated(ulong AppDomainID, ulong Allocated, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(84, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2048L)]
		private void AppDomainMemSurvived(ulong AppDomainID, ulong Survived, ulong ProcessSurvived, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(85, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)67584L)]
		private void ThreadCreated(ulong ManagedThreadID, ulong AppDomainID, uint Flags, uint ManagedThreadIndex, uint OSThreadID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(86, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)67584L)]
		private void ThreadTerminated(ulong ManagedThreadID, ulong AppDomainID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(87, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)67584L)]
		private void ThreadDomainEnter(ulong ManagedThreadID, ulong AppDomainID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(88, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)8192L)]
		private void ILStubGenerated(ushort ClrInstanceID, ulong ModuleID, ulong StubMethodID, uint StubFlags, uint ManagedInteropMethodToken, string ManagedInteropMethodNamespace, string ManagedInteropMethodName, string ManagedInteropMethodSignature, string NativeMethodSignature, string StubMethodSignature, string StubMethodILCode)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(89, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)8192L)]
		private void ILStubCacheHit(ushort ClrInstanceID, ulong ModuleID, ulong StubMethodID, uint ManagedInteropMethodToken, string ManagedInteropMethodNamespace, string ManagedInteropMethodName, string ManagedInteropMethodSignature)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(135, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void DCStartCompleteV2()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(136, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void DCEndCompleteV2()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(137, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodDCStartV2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(138, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodDCEndV2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(139, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodDCStartVerboseV2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags, string MethodNamespace, string MethodName, string MethodSignature)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(140, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodDCEndVerboseV2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags, string MethodNamespace, string MethodName, string MethodSignature)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(141, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodLoad_V2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags, ushort ClrInstanceID, ulong ReJITID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(159, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)137438953472L)]
		private void R2RGetEntryPoint(ulong MethodID, string MethodNamespace, string MethodName, string MethodSignature, ulong EntryPoint, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(160, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)137438953472L)]
		private void R2RGetEntryPointStart(ulong MethodID, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(142, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodUnload_V2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags, ushort ClrInstanceID, ulong ReJITID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(143, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodLoadVerbose_V2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags, string MethodNamespace, string MethodName, string MethodSignature, ushort ClrInstanceID, ulong ReJITID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AB9 RID: 35513 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(144, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)48L)]
		private void MethodUnloadVerbose_V2(ulong MethodID, ulong ModuleID, ulong MethodStartAddress, uint MethodSize, uint MethodToken, uint MethodFlags, string MethodNamespace, string MethodName, string MethodSignature, ushort ClrInstanceID, ulong ReJITID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ABA RID: 35514 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(145, Version = 1, Level = EventLevel.Verbose, Keywords = (EventKeywords)16L)]
		private void MethodJittingStarted_V1(ulong MethodID, ulong ModuleID, uint MethodToken, uint MethodILSize, string MethodNamespace, string MethodName, string MethodSignature, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ABB RID: 35515 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(146, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)16L)]
		private void MethodJitMemoryAllocatedForCode(ulong MethodID, ulong ModuleID, ulong JitHotCodeRequestSize, ulong JitRODataRequestSize, ulong AllocatedSizeForJitCode, uint JitAllocFlag, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(185, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)4096L)]
		private void MethodJitInliningSucceeded(string MethodBeingCompiledNamespace, string MethodBeingCompiledName, string MethodBeingCompiledNameSignature, string InlinerNamespace, string InlinerName, string InlinerNameSignature, string InlineeNamespace, string InlineeName, string InlineeNameSignature, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(186, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)4096L)]
		private void MethodJitInliningFailedAnsi(string MethodBeingCompiledNamespace, string MethodBeingCompiledName, string MethodBeingCompiledNameSignature, string InlinerNamespace, string InlinerName, string InlinerNameSignature, string InlineeNamespace, string InlineeName, string InlineeNameSignature, bool FailAlways)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(188, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)4096L)]
		private void MethodJitTailCallSucceeded(string MethodBeingCompiledNamespace, string MethodBeingCompiledName, string MethodBeingCompiledNameSignature, string CallerNamespace, string CallerName, string CallerNameSignature, string CalleeNamespace, string CalleeName, string CalleeNameSignature, bool TailPrefix, uint TailCallType, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(189, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)4096L)]
		private void MethodJitTailCallFailedAnsi(string MethodBeingCompiledNamespace, string MethodBeingCompiledName, string MethodBeingCompiledNameSignature, string CallerNamespace, string CallerName, string CallerNameSignature, string CalleeNamespace, string CalleeName, string CalleeNameSignature, bool TailPrefix)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(190, Version = 1, Level = EventLevel.Verbose, Keywords = (EventKeywords)131072L)]
		private void MethodILToNativeMap_V1(ulong MethodID, ulong ReJITID, byte MethodExtent, ushort CountOfMapEntries)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(191, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)4096L)]
		private void MethodJitTailCallFailed(string MethodBeingCompiledNamespace, string MethodBeingCompiledName, string MethodBeingCompiledNameSignature, string CallerNamespace, string CallerName, string CallerNameSignature, string CalleeNamespace, string CalleeName, string CalleeNameSignature, bool TailPrefix, string FailReason, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(192, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)4096L)]
		private void MethodJitInliningFailed(string MethodBeingCompiledNamespace, string MethodBeingCompiledName, string MethodBeingCompiledNameSignature, string InlinerNamespace, string InlinerName, string InlinerNameSignature, string InlineeNamespace, string InlineeName, string InlineeNameSignature, bool FailAlways, string FailReason, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(149, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		private void ModuleDCStartV2(ulong ModuleID, ulong AssemblyID, uint ModuleFlags, uint Reserved1, string ModuleILPath, string ModuleNativePath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(150, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		private void ModuleDCEndV2(ulong ModuleID, ulong AssemblyID, uint ModuleFlags, uint Reserved1, string ModuleILPath, string ModuleNativePath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(151, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		private void DomainModuleLoad_V1(ulong ModuleID, ulong AssemblyID, ulong AppDomainID, uint ModuleFlags, uint Reserved1, string ModuleILPath, string ModuleNativePath, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(152, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)536870920L)]
		private void ModuleLoad_V2(ulong ModuleID, ulong AssemblyID, uint ModuleFlags, uint Reserved1, string ModuleILPath, string ModuleNativePath, ushort ClrInstanceID, Guid ManagedPdbSignature, uint ManagedPdbAge, string ManagedPdbBuildPath, Guid NativePdbSignature, uint NativePdbAge, string NativePdbBuildPath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(153, Version = 2, Level = EventLevel.Informational, Keywords = (EventKeywords)536870920L)]
		private void ModuleUnload_V2(ulong ModuleID, ulong AssemblyID, uint ModuleFlags, uint Reserved1, string ModuleILPath, string ModuleNativePath, ushort ClrInstanceID, Guid ManagedPdbSignature, uint ManagedPdbAge, string ManagedPdbBuildPath, Guid NativePdbSignature, uint NativePdbAge, string NativePdbBuildPath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(154, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		private void AssemblyLoad_V1(ulong AssemblyID, ulong AppDomainID, ulong BindingID, uint AssemblyFlags, string FullyQualifiedAssemblyName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(155, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		private void AssemblyUnload_V1(ulong AssemblyID, ulong AppDomainID, ulong BindingID, uint AssemblyFlags, string FullyQualifiedAssemblyName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(156, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		private void AppDomainLoad_V1(ulong AppDomainID, uint AppDomainFlags, string AppDomainName, uint AppDomainIndex, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(157, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		private void AppDomainUnload_V1(ulong AppDomainID, uint AppDomainFlags, string AppDomainName, uint AppDomainIndex, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(158, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)536870912L)]
		private void ModuleRangeLoad(ushort ClrInstanceID, ulong ModuleID, uint RangeBegin, uint RangeSize, byte RangeType)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(181, Version = 1, Level = EventLevel.Verbose, Keywords = (EventKeywords)1024L)]
		private void StrongNameVerificationStart_V1(uint VerificationFlags, uint ErrorCode, string FullyQualifiedAssemblyName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(182, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1024L)]
		private void StrongNameVerificationStop_V1(uint VerificationFlags, uint ErrorCode, string FullyQualifiedAssemblyName, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(183, Version = 1, Level = EventLevel.Verbose, Keywords = (EventKeywords)1024L)]
		private void AuthenticodeVerificationStart_V1(uint VerificationFlags, uint ErrorCode, string ModulePath, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(184, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)1024L)]
		private void AuthenticodeVerificationStop_V1(uint VerificationFlags, uint ErrorCode, string ModulePath, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(187, Version = 0, Level = EventLevel.Informational)]
		private void RuntimeInformationStart(ushort ClrInstanceID, ushort Sku, ushort BclMajorVersion, ushort BclMinorVersion, ushort BclBuildNumber, ushort BclQfeNumber, ushort VMMajorVersion, ushort VMMinorVersion, ushort VMBuildNumber, ushort VMQfeNumber, uint StartupFlags, byte StartupMode, string CommandLine, Guid ComObjectGuid, string RuntimeDllPath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(200, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)1L)]
		private void IncreaseMemoryPressure(ulong BytesAllocated, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(201, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)1L)]
		private void DecreaseMemoryPressure(ulong BytesFreed, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(202, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCMarkWithType(uint HeapNum, ushort ClrInstanceID, uint Type, ulong Bytes)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(203, Version = 2, Level = EventLevel.Verbose, Keywords = (EventKeywords)1L)]
		private void GCJoin_V2(uint Heap, uint JoinTime, uint JoinType, ushort ClrInstanceID, uint JoinID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(204, Version = 3, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCPerHeapHistory_V3(ushort ClrInstanceID, IntPtr FreeListAllocated, IntPtr FreeListRejected, IntPtr EndOfSegAllocated, IntPtr CondemnedAllocated, IntPtr PinnedAllocated, IntPtr PinnedAllocatedAdvance, uint RunningFreeListEfficiency, uint CondemnReasons0, uint CondemnReasons1, uint CompactMechanisms, uint ExpandMechanisms, uint HeapIndex, IntPtr ExtraGen0Commit, uint Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(205, Version = 4, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCGlobalHeapHistory_V4(ulong FinalYoungestDesired, int NumHeaps, uint CondemnedGeneration, uint Gen0ReductionCount, uint Reason, uint GlobalMechanisms, ushort ClrInstanceID, uint PauseMode, uint MemoryPressure, uint CondemnReasons0, uint CondemnReasons1, uint Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(206, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GenAwareBegin(uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(207, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1048576L)]
		private void GenAwareEnd(uint Count, ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(208, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void GCLOHCompact(ushort ClrInstanceID, ushort Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(209, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)1L)]
		private void GCFitBucketInfo(ushort ClrInstanceID, ushort BucketKind, ulong TotalSize, ushort Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(240, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4294967296L)]
		private void DebugIPCEventStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(241, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4294967296L)]
		private void DebugIPCEventEnd()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(242, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4294967296L)]
		private void DebugExceptionProcessingStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(243, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4294967296L)]
		private void DebugExceptionProcessingEnd()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(260, Version = 0, Level = EventLevel.Verbose, Keywords = (EventKeywords)17179869184L)]
		private void CodeSymbols(ulong ModuleId, ushort TotalChunks, ushort ChunkNumber, uint ChunkLength)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(270, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)34359738368L)]
		private void EventSource(int EventID, string EventName, string EventSourceName, string Payload)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(280, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)68719476736L)]
		private void TieredCompilationSettings(ushort ClrInstanceID, uint Flags)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(281, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)68719476736L)]
		private void TieredCompilationPause(ushort ClrInstanceID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(282, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)68719476736L)]
		private void TieredCompilationResume(ushort ClrInstanceID, uint NewMethodCount)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(283, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)68719476736L)]
		private void TieredCompilationBackgroundJitStart(ushort ClrInstanceID, uint PendingMethodCount)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(284, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)68719476736L)]
		private void TieredCompilationBackgroundJitStop(ushort ClrInstanceID, uint PendingMethodCount, uint JittedMethodCount)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(290, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void AssemblyLoadStart(ushort ClrInstanceID, string AssemblyName, string AssemblyPath, string RequestingAssembly, string AssemblyLoadContext, string RequestingAssemblyLoadContext)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE8 RID: 35560 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(291, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void AssemblyLoadStop(ushort ClrInstanceID, string AssemblyName, string AssemblyPath, string RequestingAssembly, string AssemblyLoadContext, string RequestingAssemblyLoadContext, bool Success, string ResultAssemblyName, string ResultAssemblyPath, bool Cached)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AE9 RID: 35561 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(292, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void ResolutionAttempted(ushort ClrInstanceID, string AssemblyName, ushort Stage, string AssemblyLoadContext, ushort Result, string ResultAssemblyName, string ResultAssemblyPath, string ErrorMessage)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(293, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void AssemblyLoadContextResolvingHandlerInvoked(ushort ClrInstanceID, string AssemblyName, string HandlerName, string AssemblyLoadContext, string ResultAssemblyName, string ResultAssemblyPath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(294, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void AppDomainAssemblyResolveHandlerInvoked(ushort ClrInstanceID, string AssemblyName, string HandlerName, string ResultAssemblyName, string ResultAssemblyPath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(295, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void AssemblyLoadFromResolveHandlerInvoked(ushort ClrInstanceID, string AssemblyName, bool IsTrackedLoad, string RequestingAssemblyPath, string ComputedRequestedAssemblyPath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(296, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void KnownPathProbed(ushort ClrInstanceID, string FilePath, ushort Source, int Result)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(297, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1099511627776L)]
		private void JitInstrumentationData(ushort ClrInstanceID, uint MethodFlags, uint DataSize, ulong MethodID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(298, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)1099511627776L)]
		private void JitInstrumentationDataVerbose(ushort ClrInstanceID, uint MethodFlags, uint DataSize, ulong MethodID, ulong ModuleID, uint MethodToken, string MethodNamespace, string MethodName, string MethodSignature)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(299, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)2199023255552L)]
		private void ProfilerMessage(ushort ClrInstanceID, string Message)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Event(300, Version = 0, Level = EventLevel.Informational, Keywords = (EventKeywords)536870912L)]
		private void ExecutionCheckpoint(ushort ClrInstanceID, string Name, long Timestamp)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x0014F084 File Offset: 0x0014D284
		private NativeRuntimeEventSource() : base(new Guid(3778809123U, 52412, 19986, 147, 27, 217, 204, 46, 238, 39, 228), "Microsoft-Windows-DotNETRuntime")
		{
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06008AF3 RID: 35571 RVA: 0x0014F0CF File Offset: 0x0014D2CF
		private protected unsafe override ReadOnlySpan<byte> ProviderMetadata
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E1C007C3B6F6C2B81928F31F257C669F2A5F9EF6F6BB84060C378045447C3D65), 34);
			}
		}

		// Token: 0x04001EB9 RID: 7865
		internal const string EventSourceName = "Microsoft-Windows-DotNETRuntime";

		// Token: 0x04001EBA RID: 7866
		public static readonly NativeRuntimeEventSource Log = new NativeRuntimeEventSource();

		// Token: 0x04001EBB RID: 7867
		private const ushort DefaultClrInstanceId = 0;

		// Token: 0x020008C1 RID: 2241
		private static class Messages
		{
			// Token: 0x04001EBC RID: 7868
			public const string ContentionLockCreated = "LockID={0};\nAssociatedObjectID={1};\nClrInstanceID={2}";

			// Token: 0x04001EBD RID: 7869
			public const string ContentionStart = "ContentionFlags={0};\nClrInstanceID={1};\nLockID={2};\nAssociatedObjectID={3}\nLockOwnerThreadID={4}";

			// Token: 0x04001EBE RID: 7870
			public const string ContentionStop = "ContentionFlags={0};\nClrInstanceID={1};\nDurationNs={2}";

			// Token: 0x04001EBF RID: 7871
			public const string WorkerThread = "ActiveWorkerThreadCount={0};\nRetiredWorkerThreadCount={1};\nClrInstanceID={2}";

			// Token: 0x04001EC0 RID: 7872
			public const string MinMaxThreads = "MinWorkerThreads={0};\nMaxWorkerThreads={1};\nMinIOCompletionThreads={2};\nMaxIOCompletionThreads={3};\nClrInstanceID={4}";

			// Token: 0x04001EC1 RID: 7873
			public const string WorkerThreadAdjustmentSample = "Throughput={0};\nClrInstanceID={1}";

			// Token: 0x04001EC2 RID: 7874
			public const string WorkerThreadAdjustmentAdjustment = "AverageThroughput={0};\nNewWorkerThreadCount={1};\nReason={2};\nClrInstanceID={3}";

			// Token: 0x04001EC3 RID: 7875
			public const string WorkerThreadAdjustmentStats = "Duration={0};\nThroughput={1};\nThreadWave={2};\nThroughputWave={3};\nThroughputErrorEstimate={4};\nAverageThroughputErrorEstimate={5};\nThroughputRatio={6};\nConfidence={7};\nNewControlSetting={8};\nNewThreadWaveMagnitude={9};\nClrInstanceID={10}";

			// Token: 0x04001EC4 RID: 7876
			public const string IOEnqueue = "NativeOverlapped={0};\nOverlapped={1};\nMultiDequeues={2};\nClrInstanceID={3}";

			// Token: 0x04001EC5 RID: 7877
			public const string IO = "NativeOverlapped={0};\nOverlapped={1};\nClrInstanceID={2}";

			// Token: 0x04001EC6 RID: 7878
			public const string WorkingThreadCount = "Count={0};\nClrInstanceID={1}";

			// Token: 0x04001EC7 RID: 7879
			public const string WaitHandleWaitStart = "WaitSource={0};\nAssociatedObjectID={1};\nClrInstanceID={2}";

			// Token: 0x04001EC8 RID: 7880
			public const string WaitHandleWaitStop = "ClrInstanceID={0}";
		}

		// Token: 0x020008C2 RID: 2242
		public static class Tasks
		{
			// Token: 0x04001EC9 RID: 7881
			public const EventTask Contention = (EventTask)8;

			// Token: 0x04001ECA RID: 7882
			public const EventTask ThreadPoolWorkerThread = (EventTask)16;

			// Token: 0x04001ECB RID: 7883
			public const EventTask ThreadPoolWorkerThreadAdjustment = (EventTask)18;

			// Token: 0x04001ECC RID: 7884
			public const EventTask ThreadPool = (EventTask)23;

			// Token: 0x04001ECD RID: 7885
			public const EventTask ThreadPoolWorkingThreadCount = (EventTask)22;

			// Token: 0x04001ECE RID: 7886
			public const EventTask ThreadPoolMinMaxThreads = (EventTask)38;

			// Token: 0x04001ECF RID: 7887
			public const EventTask WaitHandleWait = (EventTask)39;
		}

		// Token: 0x020008C3 RID: 2243
		public static class Opcodes
		{
			// Token: 0x04001ED0 RID: 7888
			public const EventOpcode LockCreated = (EventOpcode)11;

			// Token: 0x04001ED1 RID: 7889
			public const EventOpcode IOEnqueue = (EventOpcode)13;

			// Token: 0x04001ED2 RID: 7890
			public const EventOpcode IODequeue = (EventOpcode)14;

			// Token: 0x04001ED3 RID: 7891
			public const EventOpcode IOPack = (EventOpcode)15;

			// Token: 0x04001ED4 RID: 7892
			public const EventOpcode Wait = (EventOpcode)90;

			// Token: 0x04001ED5 RID: 7893
			public const EventOpcode Sample = (EventOpcode)100;

			// Token: 0x04001ED6 RID: 7894
			public const EventOpcode Adjustment = (EventOpcode)101;

			// Token: 0x04001ED7 RID: 7895
			public const EventOpcode Stats = (EventOpcode)102;
		}

		// Token: 0x020008C4 RID: 2244
		public enum ContentionFlagsMap : byte
		{
			// Token: 0x04001ED9 RID: 7897
			Managed,
			// Token: 0x04001EDA RID: 7898
			Native
		}

		// Token: 0x020008C5 RID: 2245
		public enum ThreadAdjustmentReasonMap : uint
		{
			// Token: 0x04001EDC RID: 7900
			Warmup,
			// Token: 0x04001EDD RID: 7901
			Initializing,
			// Token: 0x04001EDE RID: 7902
			RandomMove,
			// Token: 0x04001EDF RID: 7903
			ClimbingMove,
			// Token: 0x04001EE0 RID: 7904
			ChangePoint,
			// Token: 0x04001EE1 RID: 7905
			Stabilizing,
			// Token: 0x04001EE2 RID: 7906
			Starvation,
			// Token: 0x04001EE3 RID: 7907
			ThreadTimedOut,
			// Token: 0x04001EE4 RID: 7908
			CooperativeBlocking
		}

		// Token: 0x020008C6 RID: 2246
		public enum WaitHandleWaitSourceMap : byte
		{
			// Token: 0x04001EE6 RID: 7910
			Unknown,
			// Token: 0x04001EE7 RID: 7911
			MonitorWait
		}

		// Token: 0x020008C7 RID: 2247
		public static class Keywords
		{
			// Token: 0x04001EE8 RID: 7912
			public const EventKeywords GCKeyword = (EventKeywords)1L;

			// Token: 0x04001EE9 RID: 7913
			public const EventKeywords GCHandleKeyword = (EventKeywords)2L;

			// Token: 0x04001EEA RID: 7914
			public const EventKeywords AssemblyLoaderKeyword = (EventKeywords)4L;

			// Token: 0x04001EEB RID: 7915
			public const EventKeywords LoaderKeyword = (EventKeywords)8L;

			// Token: 0x04001EEC RID: 7916
			public const EventKeywords JitKeyword = (EventKeywords)16L;

			// Token: 0x04001EED RID: 7917
			public const EventKeywords NGenKeyword = (EventKeywords)32L;

			// Token: 0x04001EEE RID: 7918
			public const EventKeywords SecurityKeyword = (EventKeywords)1024L;

			// Token: 0x04001EEF RID: 7919
			public const EventKeywords AppDomainResourceManagementKeyword = (EventKeywords)2048L;

			// Token: 0x04001EF0 RID: 7920
			public const EventKeywords JitTracingKeyword = (EventKeywords)4096L;

			// Token: 0x04001EF1 RID: 7921
			public const EventKeywords InteropKeyword = (EventKeywords)8192L;

			// Token: 0x04001EF2 RID: 7922
			public const EventKeywords ContentionKeyword = (EventKeywords)16384L;

			// Token: 0x04001EF3 RID: 7923
			public const EventKeywords ExceptionKeyword = (EventKeywords)32768L;

			// Token: 0x04001EF4 RID: 7924
			public const EventKeywords ThreadingKeyword = (EventKeywords)65536L;

			// Token: 0x04001EF5 RID: 7925
			public const EventKeywords JittedMethodILToNativeMapKeyword = (EventKeywords)131072L;

			// Token: 0x04001EF6 RID: 7926
			public const EventKeywords TypeKeyword = (EventKeywords)524288L;

			// Token: 0x04001EF7 RID: 7927
			public const EventKeywords GCHeapDumpKeyword = (EventKeywords)1048576L;

			// Token: 0x04001EF8 RID: 7928
			public const EventKeywords GCSampledObjectAllocationHighKeyword = (EventKeywords)2097152L;

			// Token: 0x04001EF9 RID: 7929
			public const EventKeywords GCHeapSurvivalAndMovementKeyword = (EventKeywords)4194304L;

			// Token: 0x04001EFA RID: 7930
			public const EventKeywords ManagedHeapCollectKeyword = (EventKeywords)8388608L;

			// Token: 0x04001EFB RID: 7931
			public const EventKeywords GCHeapAndTypeNamesKeyword = (EventKeywords)16777216L;

			// Token: 0x04001EFC RID: 7932
			public const EventKeywords GCSampledObjectAllocationLowKeyword = (EventKeywords)33554432L;

			// Token: 0x04001EFD RID: 7933
			public const EventKeywords PerfTrackKeyword = (EventKeywords)536870912L;

			// Token: 0x04001EFE RID: 7934
			public const EventKeywords StackKeyword = (EventKeywords)1073741824L;

			// Token: 0x04001EFF RID: 7935
			public const EventKeywords ThreadTransferKeyword = (EventKeywords)2147483648L;

			// Token: 0x04001F00 RID: 7936
			public const EventKeywords DebuggerKeyword = (EventKeywords)4294967296L;

			// Token: 0x04001F01 RID: 7937
			public const EventKeywords MonitoringKeyword = (EventKeywords)8589934592L;

			// Token: 0x04001F02 RID: 7938
			public const EventKeywords CodeSymbolsKeyword = (EventKeywords)17179869184L;

			// Token: 0x04001F03 RID: 7939
			public const EventKeywords EventSourceKeyword = (EventKeywords)34359738368L;

			// Token: 0x04001F04 RID: 7940
			public const EventKeywords CompilationKeyword = (EventKeywords)68719476736L;

			// Token: 0x04001F05 RID: 7941
			public const EventKeywords CompilationDiagnosticKeyword = (EventKeywords)137438953472L;

			// Token: 0x04001F06 RID: 7942
			public const EventKeywords MethodDiagnosticKeyword = (EventKeywords)274877906944L;

			// Token: 0x04001F07 RID: 7943
			public const EventKeywords TypeDiagnosticKeyword = (EventKeywords)549755813888L;

			// Token: 0x04001F08 RID: 7944
			public const EventKeywords JitInstrumentationDataKeyword = (EventKeywords)1099511627776L;

			// Token: 0x04001F09 RID: 7945
			public const EventKeywords ProfilerKeyword = (EventKeywords)2199023255552L;

			// Token: 0x04001F0A RID: 7946
			public const EventKeywords WaitHandleKeyword = (EventKeywords)4398046511104L;
		}
	}
}
