using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000668 RID: 1640
	[NullableContext(1)]
	[Nullable(0)]
	public struct AsyncTaskMethodBuilder<[Nullable(2)] TResult>
	{
		// Token: 0x06007340 RID: 29504 RVA: 0x00112A00 File Offset: 0x00110C00
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static AsyncTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncTaskMethodBuilder<TResult>);
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x00112656 File Offset: 0x00110856
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x00112A16 File Offset: 0x00110C16
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			AsyncMethodBuilderCore.SetStateMachine(stateMachine, this.m_task);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00112A24 File Offset: 0x00110C24
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<TResult>.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x00112A34 File Offset: 0x00110C34
		internal static void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine, ref Task<TResult> taskField) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				ref TAwaiter ptr = ref awaiter;
				if (default(TAwaiter) == null)
				{
					TAwaiter tawaiter = awaiter;
					ptr = ref tawaiter;
				}
				ptr.OnCompleted(AsyncTaskMethodBuilder<TResult>.GetStateMachineBox<TStateMachine>(ref stateMachine, ref taskField).MoveNextAction);
			}
			catch (Exception exception)
			{
				System.Threading.Tasks.Task.ThrowAsync(exception, null);
			}
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x00112A8C File Offset: 0x00110C8C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<TResult>.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x00112A9C File Offset: 0x00110C9C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine, [NotNull] ref Task<TResult> taskField) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			IAsyncStateMachineBox stateMachineBox = AsyncTaskMethodBuilder<TResult>.GetStateMachineBox<TStateMachine>(ref stateMachine, ref taskField);
			AsyncTaskMethodBuilder<TResult>.AwaitUnsafeOnCompleted<TAwaiter>(ref awaiter, stateMachineBox);
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x00112AB8 File Offset: 0x00110CB8
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		internal static void AwaitUnsafeOnCompleted<TAwaiter>(ref TAwaiter awaiter, IAsyncStateMachineBox box) where TAwaiter : ICriticalNotifyCompletion
		{
			if (default(TAwaiter) != null && awaiter is ITaskAwaiter)
			{
				TaskAwaiter.UnsafeOnCompletedInternal(Unsafe.As<TAwaiter, TaskAwaiter>(ref awaiter).m_task, box, true);
				return;
			}
			if (default(TAwaiter) != null && awaiter is IConfiguredTaskAwaiter)
			{
				ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter ptr = ref Unsafe.As<TAwaiter, ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>(ref awaiter);
				TaskAwaiter.UnsafeOnCompletedInternal(ptr.m_task, box, (ptr.m_options & ConfigureAwaitOptions.ContinueOnCapturedContext) > ConfigureAwaitOptions.None);
				return;
			}
			if (default(TAwaiter) != null && awaiter is IStateMachineBoxAwareAwaiter)
			{
				try
				{
					((IStateMachineBoxAwareAwaiter)((object)awaiter)).AwaitUnsafeOnCompleted(box);
					return;
				}
				catch (Exception exception)
				{
					System.Threading.Tasks.Task.ThrowAsync(exception, null);
					return;
				}
			}
			try
			{
				ref TAwaiter ptr2 = ref awaiter;
				if (default(TAwaiter) == null)
				{
					TAwaiter tawaiter = awaiter;
					ptr2 = ref tawaiter;
				}
				ptr2.UnsafeOnCompleted(box.MoveNextAction);
			}
			catch (Exception exception2)
			{
				System.Threading.Tasks.Task.ThrowAsync(exception2, null);
			}
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00112BD0 File Offset: 0x00110DD0
		private unsafe static IAsyncStateMachineBox GetStateMachineBox<TStateMachine>(ref TStateMachine stateMachine, [NotNull] ref Task<TResult> taskField) where TStateMachine : IAsyncStateMachine
		{
			ExecutionContext executionContext = ExecutionContext.Capture();
			AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine> asyncStateMachineBox = taskField as AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine>;
			IAsyncStateMachineBox result;
			if (asyncStateMachineBox != null)
			{
				if (*asyncStateMachineBox.Context != executionContext)
				{
					*asyncStateMachineBox.Context = executionContext;
				}
				result = asyncStateMachineBox;
			}
			else
			{
				AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<IAsyncStateMachine> asyncStateMachineBox2 = taskField as AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<IAsyncStateMachine>;
				if (asyncStateMachineBox2 != null)
				{
					if (asyncStateMachineBox2.StateMachine == null)
					{
						Debugger.NotifyOfCrossThreadDependency();
						asyncStateMachineBox2.StateMachine = stateMachine;
					}
					*asyncStateMachineBox2.Context = executionContext;
					result = asyncStateMachineBox2;
				}
				else
				{
					Debugger.NotifyOfCrossThreadDependency();
					AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine> asyncStateMachineBox3 = AsyncMethodBuilderCore.TrackAsyncMethodCompletion ? AsyncTaskMethodBuilder<TResult>.CreateDebugFinalizableAsyncStateMachineBox<TStateMachine>() : new AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine>();
					taskField = asyncStateMachineBox3;
					asyncStateMachineBox3.StateMachine = stateMachine;
					*asyncStateMachineBox3.Context = executionContext;
					if (TplEventSource.Log.IsEnabled())
					{
						AsyncMethodBuilderCore.LogTraceOperationBegin(asyncStateMachineBox3, stateMachine.GetType());
					}
					if (System.Threading.Tasks.Task.s_asyncDebuggingEnabled)
					{
						System.Threading.Tasks.Task.AddToActiveTasks(asyncStateMachineBox3);
					}
					result = asyncStateMachineBox3;
				}
			}
			return result;
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x00112CA2 File Offset: 0x00110EA2
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine> CreateDebugFinalizableAsyncStateMachineBox<TStateMachine>() where TStateMachine : IAsyncStateMachine
		{
			return new AsyncTaskMethodBuilder<TResult>.DebugFinalizableAsyncStateMachineBox<TStateMachine>();
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x0600734A RID: 29514 RVA: 0x00112CA9 File Offset: 0x00110EA9
		public Task<TResult> Task
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.m_task ?? this.InitializeTaskAsPromise();
			}
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00112CBC File Offset: 0x00110EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<TResult> InitializeTaskAsPromise()
		{
			return this.m_task = new Task<TResult>();
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x00112CD7 File Offset: 0x00110ED7
		internal static Task<TResult> CreateWeaklyTypedStateMachineBox()
		{
			if (!AsyncMethodBuilderCore.TrackAsyncMethodCompletion)
			{
				return new AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<IAsyncStateMachine>();
			}
			return AsyncTaskMethodBuilder<TResult>.CreateDebugFinalizableAsyncStateMachineBox<IAsyncStateMachine>();
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x00112CEB File Offset: 0x00110EEB
		public void SetResult(TResult result)
		{
			if (this.m_task == null)
			{
				this.m_task = System.Threading.Tasks.Task.FromResult<TResult>(result);
				return;
			}
			AsyncTaskMethodBuilder<TResult>.SetExistingTaskResult(this.m_task, result);
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x00112D0E File Offset: 0x00110F0E
		internal static void SetExistingTaskResult(Task<TResult> task, TResult result)
		{
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationEnd(task.Id, AsyncCausalityStatus.Completed);
			}
			if (!task.TrySetResult(result))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x00112D3D File Offset: 0x00110F3D
		public void SetException(Exception exception)
		{
			AsyncTaskMethodBuilder<TResult>.SetException(exception, ref this.m_task);
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x00112D4C File Offset: 0x00110F4C
		internal static void SetException(Exception exception, ref Task<TResult> taskField)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			Task<TResult> task;
			if ((task = taskField) == null)
			{
				Task<TResult> task2;
				taskField = (task2 = new Task<TResult>());
				task = task2;
			}
			Task<TResult> task3 = task;
			OperationCanceledException ex = exception as OperationCanceledException;
			if (!((ex != null) ? task3.TrySetCanceled(ex.CancellationToken, ex) : task3.TrySetException(exception)))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x00112D9D File Offset: 0x00110F9D
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			AsyncTaskMethodBuilder<TResult>.SetNotificationForWaitCompletion(enabled, ref this.m_task);
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x00112DAC File Offset: 0x00110FAC
		internal static void SetNotificationForWaitCompletion(bool enabled, [NotNull] ref Task<TResult> taskField)
		{
			Task<TResult> task;
			if ((task = taskField) == null)
			{
				Task<TResult> task2;
				taskField = (task2 = AsyncTaskMethodBuilder<TResult>.CreateWeaklyTypedStateMachineBox());
				task = task2;
			}
			task.SetNotificationForWaitCompletion(enabled);
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06007353 RID: 29523 RVA: 0x00112DD0 File Offset: 0x00110FD0
		internal object ObjectIdForDebugger
		{
			get
			{
				Task<TResult> result;
				if ((result = this.m_task) == null)
				{
					result = (this.m_task = AsyncTaskMethodBuilder<TResult>.CreateWeaklyTypedStateMachineBox());
				}
				return result;
			}
		}

		// Token: 0x04001478 RID: 5240
		private Task<TResult> m_task;

		// Token: 0x02000669 RID: 1641
		private sealed class DebugFinalizableAsyncStateMachineBox<TStateMachine> : AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine> where TStateMachine : IAsyncStateMachine
		{
			// Token: 0x06007354 RID: 29524 RVA: 0x00112DF8 File Offset: 0x00110FF8
			~DebugFinalizableAsyncStateMachineBox()
			{
				if (!base.IsCompleted)
				{
					TplEventSource.Log.IncompleteAsyncMethod(this);
				}
			}
		}

		// Token: 0x0200066A RID: 1642
		[DebuggerDisplay("{DebuggerDisplay,nq}")]
		private class AsyncStateMachineBox<TStateMachine> : Task<TResult>, IAsyncStateMachineBox where TStateMachine : IAsyncStateMachine
		{
			// Token: 0x06007356 RID: 29526 RVA: 0x00112E3C File Offset: 0x0011103C
			private static void ExecutionContextCallback(object s)
			{
				Unsafe.As<AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine>>(s).StateMachine.MoveNext();
			}

			// Token: 0x06007357 RID: 29527 RVA: 0x00112E54 File Offset: 0x00111054
			public AsyncStateMachineBox()
			{
				this.m_stateFlags |= 2048;
			}

			// Token: 0x17000E20 RID: 3616
			// (get) Token: 0x06007358 RID: 29528 RVA: 0x00112E74 File Offset: 0x00111074
			private string DebuggerDisplay
			{
				get
				{
					string text2;
					if (!(typeof(TStateMachine) != typeof(IAsyncStateMachine)))
					{
						ref TStateMachine ptr = ref this.StateMachine;
						TStateMachine tstateMachine = default(TStateMachine);
						string text;
						if (tstateMachine == null)
						{
							tstateMachine = this.StateMachine;
							ptr = ref tstateMachine;
							if (tstateMachine == null)
							{
								text = null;
								goto IL_50;
							}
						}
						text = ptr.ToString();
						IL_50:
						text2 = (text ?? "IAsyncStateMachine");
					}
					else
					{
						text2 = typeof(TStateMachine).Name;
					}
					string value = text2;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (!base.IsCompletedSuccessfully || !(typeof(TResult) != typeof(VoidTaskResult)))
					{
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
						defaultInterpolatedStringHandler.AppendLiteral("Id = ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(base.Id);
						defaultInterpolatedStringHandler.AppendLiteral(", Status = ");
						defaultInterpolatedStringHandler.AppendFormatted<TaskStatus>(base.Status);
						defaultInterpolatedStringHandler.AppendLiteral(", Method = ");
						defaultInterpolatedStringHandler.AppendFormatted(value);
						return defaultInterpolatedStringHandler.ToStringAndClear();
					}
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 4);
					defaultInterpolatedStringHandler.AppendLiteral("Id = ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(base.Id);
					defaultInterpolatedStringHandler.AppendLiteral(", Status = ");
					defaultInterpolatedStringHandler.AppendFormatted<TaskStatus>(base.Status);
					defaultInterpolatedStringHandler.AppendLiteral(", Method = ");
					defaultInterpolatedStringHandler.AppendFormatted(value);
					defaultInterpolatedStringHandler.AppendLiteral(", Result = ");
					defaultInterpolatedStringHandler.AppendFormatted<TResult>(this.m_result);
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}

			// Token: 0x17000E21 RID: 3617
			// (get) Token: 0x06007359 RID: 29529 RVA: 0x00112FD8 File Offset: 0x001111D8
			public Action MoveNextAction
			{
				get
				{
					Delegate @delegate;
					if ((@delegate = this.m_action) == null)
					{
						@delegate = (this.m_action = new Action(this.MoveNext));
					}
					return (Action)@delegate;
				}
			}

			// Token: 0x17000E22 RID: 3618
			// (get) Token: 0x0600735A RID: 29530 RVA: 0x0011300A File Offset: 0x0011120A
			public ref ExecutionContext Context
			{
				get
				{
					return Unsafe.As<object, ExecutionContext>(ref this.m_stateObject);
				}
			}

			// Token: 0x0600735B RID: 29531 RVA: 0x00113017 File Offset: 0x00111217
			internal sealed override void ExecuteFromThreadPool(Thread threadPoolThread)
			{
				this.MoveNext(threadPoolThread);
			}

			// Token: 0x0600735C RID: 29532 RVA: 0x00113020 File Offset: 0x00111220
			public void MoveNext()
			{
				this.MoveNext(null);
			}

			// Token: 0x0600735D RID: 29533 RVA: 0x0011302C File Offset: 0x0011122C
			private unsafe void MoveNext(Thread threadPoolThread)
			{
				bool flag = TplEventSource.Log.IsEnabled();
				if (flag)
				{
					TplEventSource.Log.TraceSynchronousWorkBegin(base.Id, CausalitySynchronousWork.Execution);
				}
				ExecutionContext executionContext = *this.Context;
				if (executionContext == null)
				{
					this.StateMachine.MoveNext();
				}
				else if (threadPoolThread == null)
				{
					ExecutionContext.RunInternal(executionContext, AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine>.s_callback, this);
				}
				else
				{
					ExecutionContext.RunFromThreadPoolDispatchLoop(threadPoolThread, executionContext, AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine>.s_callback, this);
				}
				if (base.IsCompleted)
				{
					this.ClearStateUponCompletion();
				}
				if (flag)
				{
					TplEventSource.Log.TraceSynchronousWorkEnd(CausalitySynchronousWork.Execution);
				}
			}

			// Token: 0x0600735E RID: 29534 RVA: 0x001130AE File Offset: 0x001112AE
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void ClearStateUponCompletion()
			{
				if (System.Threading.Tasks.Task.s_asyncDebuggingEnabled)
				{
					System.Threading.Tasks.Task.RemoveFromActiveTasks(this);
				}
				this.StateMachine = default(TStateMachine);
				*this.Context = null;
				if (AsyncMethodBuilderCore.TrackAsyncMethodCompletion)
				{
					GC.SuppressFinalize(this);
				}
			}

			// Token: 0x0600735F RID: 29535 RVA: 0x001130DE File Offset: 0x001112DE
			IAsyncStateMachine IAsyncStateMachineBox.GetStateMachineObject()
			{
				return this.StateMachine;
			}

			// Token: 0x04001479 RID: 5241
			private static readonly ContextCallback s_callback = new ContextCallback(AsyncTaskMethodBuilder<TResult>.AsyncStateMachineBox<TStateMachine>.ExecutionContextCallback);

			// Token: 0x0400147A RID: 5242
			public TStateMachine StateMachine;
		}
	}
}
