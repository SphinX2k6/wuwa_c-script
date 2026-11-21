using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004E6 RID: 1254
	[EventSource(Name = "System.Threading.Tasks.TplEventSource", Guid = "2e5dba47-a3d2-4d16-8ee0-6671ffdcd7b5")]
	[GeneratedCode("System.Private.CoreLib.Generators", "42.42.42.42")]
	internal sealed class TplEventSource : EventSource
	{
		// Token: 0x06004797 RID: 18327 RVA: 0x000EEB80 File Offset: 0x000ECD80
		protected override void OnEventCommand(EventCommandEventArgs command)
		{
			if (base.IsEnabled(EventLevel.Informational, (EventKeywords)128L))
			{
				ActivityTracker.Instance.Enable();
			}
			else
			{
				this.TasksSetActivityIds = base.IsEnabled(EventLevel.Informational, (EventKeywords)65536L);
			}
			this.Debug = base.IsEnabled(EventLevel.Informational, (EventKeywords)131072L);
			this.DebugActivityId = base.IsEnabled(EventLevel.Informational, (EventKeywords)262144L);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x000C2E1D File Offset: 0x000C101D
		private TplEventSource(int _)
		{
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x000EEBE4 File Offset: 0x000ECDE4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(7, Task = (EventTask)6, Version = 1, Opcode = EventOpcode.Send, Level = EventLevel.Informational, Keywords = (EventKeywords)3L, Message = "Task {2} scheduled to TaskScheduler {0}.")]
		public unsafe void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions, int appDomain = 1)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)3L))
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->Size = 4;
				ptr->DataPointer = &OriginatingTaskSchedulerID;
				ptr->Reserved = 0;
				ptr[1].Size = 4;
				ptr[1].DataPointer = &OriginatingTaskID;
				ptr[1].Reserved = 0;
				ptr[2].Size = 4;
				ptr[2].DataPointer = &TaskID;
				ptr[2].Reserved = 0;
				ptr[3].Size = 4;
				ptr[3].DataPointer = &CreatingTaskID;
				ptr[3].Reserved = 0;
				ptr[4].Size = 4;
				ptr[4].DataPointer = &TaskCreationOptions;
				ptr[4].Reserved = 0;
				ptr[5].Size = 4;
				ptr[5].DataPointer = &appDomain;
				ptr[5].Reserved = 0;
				if (this.TasksSetActivityIds)
				{
					Guid guid = TplEventSource.CreateGuidForTaskID(TaskID);
					base.WriteEventWithRelatedActivityIdCore(7, &guid, 6, ptr);
					return;
				}
				base.WriteEventCore(7, 6, ptr);
			}
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x000EED52 File Offset: 0x000ECF52
		[Event(8, Level = EventLevel.Informational, Keywords = (EventKeywords)2L, Message = "Task {2} executing.")]
		public void TaskStarted(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			if (base.IsEnabled(EventLevel.Informational, (EventKeywords)2L))
			{
				base.WriteEvent(8, OriginatingTaskSchedulerID, OriginatingTaskID, TaskID);
			}
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x000EED6C File Offset: 0x000ECF6C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(9, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)64L, Message = "Task {2} completed.")]
		public unsafe void TaskCompleted(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, bool IsExceptional)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)2L))
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(EventSource.EventData))];
				int num = (IsExceptional > false) ? 1 : 0;
				ptr->Size = 4;
				ptr->DataPointer = &OriginatingTaskSchedulerID;
				ptr->Reserved = 0;
				ptr[1].Size = 4;
				ptr[1].DataPointer = &OriginatingTaskID;
				ptr[1].Reserved = 0;
				ptr[2].Size = 4;
				ptr[2].DataPointer = &TaskID;
				ptr[2].Reserved = 0;
				ptr[3].Size = 4;
				ptr[3].DataPointer = &num;
				ptr[3].Reserved = 0;
				base.WriteEventCore(9, 4, ptr);
			}
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x000EEE5C File Offset: 0x000ED05C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(10, Version = 3, Task = (EventTask)4, Opcode = EventOpcode.Send, Level = EventLevel.Informational, Keywords = (EventKeywords)3L, Message = "Beginning wait ({3}) on Task {2}.")]
		public unsafe void TaskWaitBegin(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, TplEventSource.TaskWaitBehavior Behavior, int ContinueWithTaskID)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)3L))
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->Size = 4;
				ptr->DataPointer = &OriginatingTaskSchedulerID;
				ptr->Reserved = 0;
				ptr[1].Size = 4;
				ptr[1].DataPointer = &OriginatingTaskID;
				ptr[1].Reserved = 0;
				ptr[2].Size = 4;
				ptr[2].DataPointer = &TaskID;
				ptr[2].Reserved = 0;
				ptr[3].Size = 4;
				ptr[3].DataPointer = &Behavior;
				ptr[3].Reserved = 0;
				ptr[4].Size = 4;
				ptr[4].DataPointer = &ContinueWithTaskID;
				ptr[4].Reserved = 0;
				if (this.TasksSetActivityIds)
				{
					Guid guid = TplEventSource.CreateGuidForTaskID(TaskID);
					base.WriteEventWithRelatedActivityIdCore(10, &guid, 5, ptr);
					return;
				}
				base.WriteEventCore(10, 5, ptr);
			}
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x000EEF97 File Offset: 0x000ED197
		[Event(11, Level = EventLevel.Verbose, Keywords = (EventKeywords)2L, Message = "Ending wait on Task {2}.")]
		public void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Verbose, (EventKeywords)2L))
			{
				base.WriteEvent(11, OriginatingTaskSchedulerID, OriginatingTaskID, TaskID);
			}
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x000EEFB7 File Offset: 0x000ED1B7
		[Event(13, Level = EventLevel.Verbose, Keywords = (EventKeywords)64L)]
		public void TaskWaitContinuationComplete(int TaskID)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Verbose, (EventKeywords)64L))
			{
				base.WriteEvent(13, TaskID);
			}
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x000EEFD6 File Offset: 0x000ED1D6
		[Event(19, Level = EventLevel.Verbose, Keywords = (EventKeywords)2L)]
		public void TaskWaitContinuationStarted(int TaskID)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Verbose, (EventKeywords)2L))
			{
				base.WriteEvent(19, TaskID);
			}
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x000EEFF4 File Offset: 0x000ED1F4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(12, Task = (EventTask)7, Opcode = EventOpcode.Send, Level = EventLevel.Informational, Keywords = (EventKeywords)3L)]
		public unsafe void AwaitTaskContinuationScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ContinueWithTaskId)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)3L))
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->Size = 4;
				ptr->DataPointer = &OriginatingTaskSchedulerID;
				ptr->Reserved = 0;
				ptr[1].Size = 4;
				ptr[1].DataPointer = &OriginatingTaskID;
				ptr[1].Reserved = 0;
				ptr[2].Size = 4;
				ptr[2].DataPointer = &ContinueWithTaskId;
				ptr[2].Reserved = 0;
				if (this.TasksSetActivityIds)
				{
					Guid guid = TplEventSource.CreateGuidForTaskID(ContinueWithTaskId);
					base.WriteEventWithRelatedActivityIdCore(12, &guid, 3, ptr);
					return;
				}
				base.WriteEventCore(12, 3, ptr);
			}
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x000EF0C8 File Offset: 0x000ED2C8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(14, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		public unsafe void TraceOperationBegin(int TaskID, string OperationName, long RelatedContext)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)8L))
			{
				char* ptr;
				if (OperationName == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = OperationName.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* dataPointer = ptr;
				EventSource.EventData* ptr3 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr3->Size = 4;
				ptr3->DataPointer = &TaskID;
				ptr3->Reserved = 0;
				ptr3[1].Size = (OperationName.Length + 1) * 2;
				ptr3[1].DataPointer = dataPointer;
				ptr3[1].Reserved = 0;
				ptr3[2].Size = 8;
				ptr3[2].DataPointer = &RelatedContext;
				ptr3[2].Reserved = 0;
				base.WriteEventCore(14, 3, ptr3);
				char* ptr2 = null;
			}
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x000EF197 File Offset: 0x000ED397
		[Event(16, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)16L)]
		public void TraceOperationRelation(int TaskID, CausalityRelation Relation)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
			{
				base.WriteEvent(16, TaskID, (int)Relation);
			}
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x000EF1B7 File Offset: 0x000ED3B7
		[Event(15, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)8L)]
		public void TraceOperationEnd(int TaskID, AsyncCausalityStatus Status)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)8L))
			{
				base.WriteEvent(15, TaskID, (int)Status);
			}
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x000EF1D6 File Offset: 0x000ED3D6
		[Event(17, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)32L)]
		public void TraceSynchronousWorkBegin(int TaskID, CausalitySynchronousWork Work)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)32L))
			{
				base.WriteEvent(17, TaskID, (int)Work);
			}
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x000EF1F8 File Offset: 0x000ED3F8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:UnrecognizedReflectionPattern", Justification = "Parameters to this method are primitive and are trimmer safe")]
		[Event(18, Version = 1, Level = EventLevel.Informational, Keywords = (EventKeywords)32L)]
		public unsafe void TraceSynchronousWorkEnd(CausalitySynchronousWork Work)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Informational, (EventKeywords)32L))
			{
				EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(EventSource.EventData))];
				ptr->Size = 4;
				ptr->DataPointer = &Work;
				ptr->Reserved = 0;
				base.WriteEventCore(18, 1, ptr);
			}
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x000EF246 File Offset: 0x000ED446
		[NonEvent]
		public void RunningContinuation(int TaskID, object Object)
		{
			this.RunningContinuation(TaskID, (long)EventSource.ObjectIDForEvents(Object));
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x000EF256 File Offset: 0x000ED456
		[Event(20, Keywords = (EventKeywords)131072L)]
		private void RunningContinuation(int TaskID, long Object)
		{
			if (this.Debug)
			{
				base.WriteEvent(20, (long)TaskID, Object);
			}
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x000EF26B File Offset: 0x000ED46B
		[NonEvent]
		public void RunningContinuationList(int TaskID, int Index, object Object)
		{
			this.RunningContinuationList(TaskID, Index, (long)EventSource.ObjectIDForEvents(Object));
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x000EF27C File Offset: 0x000ED47C
		[Event(21, Keywords = (EventKeywords)131072L)]
		public void RunningContinuationList(int TaskID, int Index, long Object)
		{
			if (this.Debug)
			{
				base.WriteEvent(21, (long)TaskID, (long)Index, Object);
			}
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x000EF293 File Offset: 0x000ED493
		[Event(23, Keywords = (EventKeywords)131072L)]
		public void DebugFacilityMessage(string Facility, string Message)
		{
			base.WriteEvent(23, Facility, Message);
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x000EF29F File Offset: 0x000ED49F
		[Event(24, Keywords = (EventKeywords)131072L)]
		public void DebugFacilityMessage1(string Facility, string Message, string Value1)
		{
			base.WriteEvent(24, Facility, Message, Value1);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x000EF2AC File Offset: 0x000ED4AC
		[Event(25, Keywords = (EventKeywords)262144L)]
		public void SetActivityId(Guid NewId)
		{
			if (this.DebugActivityId)
			{
				base.WriteEvent(25, new EventSource.EventSourcePrimitive[]
				{
					NewId
				});
			}
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x000EF2D1 File Offset: 0x000ED4D1
		[Event(26, Keywords = (EventKeywords)131072L)]
		public void NewID(int TaskID)
		{
			if (this.Debug)
			{
				base.WriteEvent(26, TaskID);
			}
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x000EF2E4 File Offset: 0x000ED4E4
		[NonEvent]
		public void IncompleteAsyncMethod(IAsyncStateMachineBox stateMachineBox)
		{
			if (base.IsEnabled() && base.IsEnabled(EventLevel.Warning, (EventKeywords)256L))
			{
				IAsyncStateMachine stateMachineObject = stateMachineBox.GetStateMachineObject();
				if (stateMachineObject != null)
				{
					string asyncStateMachineDescription = AsyncMethodBuilderCore.GetAsyncStateMachineDescription(stateMachineObject);
					this.IncompleteAsyncMethod(asyncStateMachineDescription);
				}
			}
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x000EF320 File Offset: 0x000ED520
		[Event(27, Level = EventLevel.Warning, Keywords = (EventKeywords)256L)]
		private void IncompleteAsyncMethod(string stateMachineDescription)
		{
			base.WriteEvent(27, stateMachineDescription);
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x000EF32C File Offset: 0x000ED52C
		internal static Guid CreateGuidForTaskID(int taskID)
		{
			int processId = Environment.ProcessId;
			return new Guid(taskID, 1, 0, (byte)processId, (byte)(processId >> 8), (byte)(processId >> 16), (byte)(processId >> 24), byte.MaxValue, 220, 215, 181);
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x000EF36C File Offset: 0x000ED56C
		private TplEventSource() : base(new Guid(777894471U, 41938, 19734, 142, 224, 102, 113, byte.MaxValue, 220, 215, 181), "System.Threading.Tasks.TplEventSource")
		{
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x000EF3BA File Offset: 0x000ED5BA
		private protected unsafe override ReadOnlySpan<byte> ProviderMetadata
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B47DA652F541E3726603EC891F0F25927C8C3D9DC33A59BCF0BD66B01BEC5EAF), 40);
			}
		}

		// Token: 0x040010C8 RID: 4296
		private const string EventSourceSuppressMessage = "Parameters to this method are primitive and are trimmer safe";

		// Token: 0x040010C9 RID: 4297
		internal bool TasksSetActivityIds;

		// Token: 0x040010CA RID: 4298
		internal bool Debug;

		// Token: 0x040010CB RID: 4299
		private bool DebugActivityId;

		// Token: 0x040010CC RID: 4300
		private const int DefaultAppDomainID = 1;

		// Token: 0x040010CD RID: 4301
		public static readonly TplEventSource Log = new TplEventSource();

		// Token: 0x040010CE RID: 4302
		private const int TASKSCHEDULED_ID = 7;

		// Token: 0x040010CF RID: 4303
		private const int TASKSTARTED_ID = 8;

		// Token: 0x040010D0 RID: 4304
		private const int TASKCOMPLETED_ID = 9;

		// Token: 0x040010D1 RID: 4305
		private const int TASKWAITBEGIN_ID = 10;

		// Token: 0x040010D2 RID: 4306
		private const int TASKWAITEND_ID = 11;

		// Token: 0x040010D3 RID: 4307
		private const int AWAITTASKCONTINUATIONSCHEDULED_ID = 12;

		// Token: 0x040010D4 RID: 4308
		private const int TASKWAITCONTINUATIONCOMPLETE_ID = 13;

		// Token: 0x040010D5 RID: 4309
		private const int TASKWAITCONTINUATIONSTARTED_ID = 19;

		// Token: 0x040010D6 RID: 4310
		private const int TRACEOPERATIONSTART_ID = 14;

		// Token: 0x040010D7 RID: 4311
		private const int TRACEOPERATIONSTOP_ID = 15;

		// Token: 0x040010D8 RID: 4312
		private const int TRACEOPERATIONRELATION_ID = 16;

		// Token: 0x040010D9 RID: 4313
		private const int TRACESYNCHRONOUSWORKSTART_ID = 17;

		// Token: 0x040010DA RID: 4314
		private const int TRACESYNCHRONOUSWORKSTOP_ID = 18;

		// Token: 0x020004E7 RID: 1255
		public enum TaskWaitBehavior
		{
			// Token: 0x040010DC RID: 4316
			Synchronous = 1,
			// Token: 0x040010DD RID: 4317
			Asynchronous
		}

		// Token: 0x020004E8 RID: 1256
		public static class Tasks
		{
			// Token: 0x040010DE RID: 4318
			public const EventTask Loop = (EventTask)1;

			// Token: 0x040010DF RID: 4319
			public const EventTask Invoke = (EventTask)2;

			// Token: 0x040010E0 RID: 4320
			public const EventTask TaskExecute = (EventTask)3;

			// Token: 0x040010E1 RID: 4321
			public const EventTask TaskWait = (EventTask)4;

			// Token: 0x040010E2 RID: 4322
			public const EventTask ForkJoin = (EventTask)5;

			// Token: 0x040010E3 RID: 4323
			public const EventTask TaskScheduled = (EventTask)6;

			// Token: 0x040010E4 RID: 4324
			public const EventTask AwaitTaskContinuationScheduled = (EventTask)7;

			// Token: 0x040010E5 RID: 4325
			public const EventTask TraceOperation = (EventTask)8;

			// Token: 0x040010E6 RID: 4326
			public const EventTask TraceSynchronousWork = (EventTask)9;
		}

		// Token: 0x020004E9 RID: 1257
		public static class Keywords
		{
			// Token: 0x040010E7 RID: 4327
			public const EventKeywords TaskTransfer = (EventKeywords)1L;

			// Token: 0x040010E8 RID: 4328
			public const EventKeywords Tasks = (EventKeywords)2L;

			// Token: 0x040010E9 RID: 4329
			public const EventKeywords Parallel = (EventKeywords)4L;

			// Token: 0x040010EA RID: 4330
			public const EventKeywords AsyncCausalityOperation = (EventKeywords)8L;

			// Token: 0x040010EB RID: 4331
			public const EventKeywords AsyncCausalityRelation = (EventKeywords)16L;

			// Token: 0x040010EC RID: 4332
			public const EventKeywords AsyncCausalitySynchronousWork = (EventKeywords)32L;

			// Token: 0x040010ED RID: 4333
			public const EventKeywords TaskStops = (EventKeywords)64L;

			// Token: 0x040010EE RID: 4334
			public const EventKeywords TasksFlowActivityIds = (EventKeywords)128L;

			// Token: 0x040010EF RID: 4335
			public const EventKeywords AsyncMethod = (EventKeywords)256L;

			// Token: 0x040010F0 RID: 4336
			public const EventKeywords TasksSetActivityIds = (EventKeywords)65536L;

			// Token: 0x040010F1 RID: 4337
			public const EventKeywords Debug = (EventKeywords)131072L;

			// Token: 0x040010F2 RID: 4338
			public const EventKeywords DebugActivityId = (EventKeywords)262144L;
		}
	}
}
