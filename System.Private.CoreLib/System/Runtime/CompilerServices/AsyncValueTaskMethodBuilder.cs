using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200066B RID: 1643
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Auto)]
	public struct AsyncValueTaskMethodBuilder
	{
		// Token: 0x06007361 RID: 29537 RVA: 0x00113100 File Offset: 0x00111300
		public static AsyncValueTaskMethodBuilder Create()
		{
			return default(AsyncValueTaskMethodBuilder);
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x00112656 File Offset: 0x00110856
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x0011292E File Offset: 0x00110B2E
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			AsyncMethodBuilderCore.SetStateMachine(stateMachine, null);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x00113118 File Offset: 0x00111318
		public void SetResult()
		{
			if (this.m_task == null)
			{
				this.m_task = AsyncValueTaskMethodBuilder.s_syncSuccessSentinel;
				return;
			}
			AsyncTaskMethodBuilder<VoidTaskResult>.SetExistingTaskResult(this.m_task, default(VoidTaskResult));
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x0011314D File Offset: 0x0011134D
		public void SetException(Exception exception)
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.SetException(exception, ref this.m_task);
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06007366 RID: 29542 RVA: 0x0011315C File Offset: 0x0011135C
		public ValueTask Task
		{
			get
			{
				if (this.m_task == AsyncValueTaskMethodBuilder.s_syncSuccessSentinel)
				{
					return default(ValueTask);
				}
				Task<VoidTaskResult> task;
				if ((task = this.m_task) == null)
				{
					task = (this.m_task = new Task<VoidTaskResult>());
				}
				return new ValueTask(task);
			}
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x0011319D File Offset: 0x0011139D
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x001131AC File Offset: 0x001113AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06007369 RID: 29545 RVA: 0x001131BC File Offset: 0x001113BC
		internal object ObjectIdForDebugger
		{
			get
			{
				Task<VoidTaskResult> result;
				if ((result = this.m_task) == null)
				{
					result = (this.m_task = AsyncTaskMethodBuilder<VoidTaskResult>.CreateWeaklyTypedStateMachineBox());
				}
				return result;
			}
		}

		// Token: 0x0400147B RID: 5243
		private static readonly Task<VoidTaskResult> s_syncSuccessSentinel = AsyncValueTaskMethodBuilder<VoidTaskResult>.s_syncSuccessSentinel;

		// Token: 0x0400147C RID: 5244
		private Task<VoidTaskResult> m_task;
	}
}
