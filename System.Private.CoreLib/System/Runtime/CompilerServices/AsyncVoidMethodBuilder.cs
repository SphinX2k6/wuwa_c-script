using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200066D RID: 1645
	[NullableContext(1)]
	[Nullable(0)]
	public struct AsyncVoidMethodBuilder
	{
		// Token: 0x06007375 RID: 29557 RVA: 0x001132EC File Offset: 0x001114EC
		public static AsyncVoidMethodBuilder Create()
		{
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			if (synchronizationContext != null)
			{
				synchronizationContext.OperationStarted();
			}
			return new AsyncVoidMethodBuilder
			{
				_synchronizationContext = synchronizationContext
			};
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x00112656 File Offset: 0x00110856
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x00113319 File Offset: 0x00111519
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this._builder.SetStateMachine(stateMachine);
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x00113327 File Offset: 0x00111527
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this._builder.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine);
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x00113336 File Offset: 0x00111536
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this._builder.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine);
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x00113348 File Offset: 0x00111548
		public void SetResult()
		{
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationEnd(this.Task.Id, AsyncCausalityStatus.Completed);
			}
			SynchronizationContext synchronizationContext = this._synchronizationContext;
			this._builder.SetResult();
			if (synchronizationContext != null)
			{
				AsyncVoidMethodBuilder.NotifySynchronizationContextOfCompletion(synchronizationContext);
			}
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x00113394 File Offset: 0x00111594
		public void SetException(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationEnd(this.Task.Id, AsyncCausalityStatus.Error);
			}
			SynchronizationContext synchronizationContext = this._synchronizationContext;
			if (synchronizationContext != null)
			{
				try
				{
					Task.ThrowAsync(exception, synchronizationContext);
					goto IL_4D;
				}
				finally
				{
					AsyncVoidMethodBuilder.NotifySynchronizationContextOfCompletion(synchronizationContext);
				}
			}
			Task.ThrowAsync(exception, null);
			IL_4D:
			this._builder.SetResult();
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0011340C File Offset: 0x0011160C
		private static void NotifySynchronizationContextOfCompletion(SynchronizationContext context)
		{
			try
			{
				context.OperationCompleted();
			}
			catch (Exception exception)
			{
				Task.ThrowAsync(exception, null);
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x0600737D RID: 29565 RVA: 0x0011343C File Offset: 0x0011163C
		private Task Task
		{
			get
			{
				return this._builder.Task;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600737E RID: 29566 RVA: 0x00113449 File Offset: 0x00111649
		internal object ObjectIdForDebugger
		{
			get
			{
				return this._builder.ObjectIdForDebugger;
			}
		}

		// Token: 0x04001480 RID: 5248
		private SynchronizationContext _synchronizationContext;

		// Token: 0x04001481 RID: 5249
		private AsyncTaskMethodBuilder _builder;
	}
}
