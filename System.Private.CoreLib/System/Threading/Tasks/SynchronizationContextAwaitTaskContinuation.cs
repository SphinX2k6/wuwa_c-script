using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004CF RID: 1231
	internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x060046C7 RID: 18119 RVA: 0x000ECDA5 File Offset: 0x000EAFA5
		internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext) : base(action, flowExecutionContext)
		{
			this.m_syncContext = context;
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x000ECDB8 File Offset: 0x000EAFB8
		internal sealed override void Run(Task task, bool canInlineContinuationTask)
		{
			if (canInlineContinuationTask && this.m_syncContext == SynchronizationContext.Current)
			{
				base.RunCallback(AwaitTaskContinuation.GetInvokeActionCallback(), this.m_action, ref Task.t_currentTask);
				return;
			}
			TplEventSource log = TplEventSource.Log;
			if (log.IsEnabled())
			{
				this.m_continuationId = Task.NewId();
				log.AwaitTaskContinuationScheduled((task.ExecutingTaskScheduler ?? TaskScheduler.Default).Id, task.Id, this.m_continuationId);
			}
			base.RunCallback(SynchronizationContextAwaitTaskContinuation.GetPostActionCallback(), this, ref Task.t_currentTask);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x000ECE3C File Offset: 0x000EB03C
		private static void PostAction(object state)
		{
			SynchronizationContextAwaitTaskContinuation synchronizationContextAwaitTaskContinuation = (SynchronizationContextAwaitTaskContinuation)state;
			TplEventSource log = TplEventSource.Log;
			if (log.IsEnabled() && log.TasksSetActivityIds && synchronizationContextAwaitTaskContinuation.m_continuationId != 0)
			{
				synchronizationContextAwaitTaskContinuation.m_syncContext.Post(SynchronizationContextAwaitTaskContinuation.s_postCallback, SynchronizationContextAwaitTaskContinuation.GetActionLogDelegate(synchronizationContextAwaitTaskContinuation.m_continuationId, synchronizationContextAwaitTaskContinuation.m_action));
				return;
			}
			synchronizationContextAwaitTaskContinuation.m_syncContext.Post(SynchronizationContextAwaitTaskContinuation.s_postCallback, synchronizationContextAwaitTaskContinuation.m_action);
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x000ECEA6 File Offset: 0x000EB0A6
		private static Action GetActionLogDelegate(int continuationId, Action action)
		{
			return delegate()
			{
				Guid currentThreadActivityId;
				EventSource.SetCurrentThreadActivityId(TplEventSource.CreateGuidForTaskID(continuationId), out currentThreadActivityId);
				try
				{
					action();
				}
				finally
				{
					EventSource.SetCurrentThreadActivityId(currentThreadActivityId);
				}
			};
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x000ECEC6 File Offset: 0x000EB0C6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ContextCallback GetPostActionCallback()
		{
			ContextCallback result;
			if ((result = SynchronizationContextAwaitTaskContinuation.s_postActionCallback) == null)
			{
				ContextCallback contextCallback;
				if ((contextCallback = SynchronizationContextAwaitTaskContinuation.<>O.<0>__PostAction) == null)
				{
					contextCallback = (SynchronizationContextAwaitTaskContinuation.<>O.<0>__PostAction = new ContextCallback(SynchronizationContextAwaitTaskContinuation.PostAction));
				}
				result = (SynchronizationContextAwaitTaskContinuation.s_postActionCallback = contextCallback);
			}
			return result;
		}

		// Token: 0x04001097 RID: 4247
		private static readonly SendOrPostCallback s_postCallback = delegate(object state)
		{
			((Action)state)();
		};

		// Token: 0x04001098 RID: 4248
		private static ContextCallback s_postActionCallback;

		// Token: 0x04001099 RID: 4249
		private readonly SynchronizationContext m_syncContext;

		// Token: 0x020004D0 RID: 1232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400109A RID: 4250
			public static ContextCallback <0>__PostAction;
		}
	}
}
