using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200066C RID: 1644
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Auto)]
	public struct AsyncValueTaskMethodBuilder<[Nullable(2)] TResult>
	{
		// Token: 0x0600736B RID: 29547 RVA: 0x001131F0 File Offset: 0x001113F0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static AsyncValueTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncValueTaskMethodBuilder<TResult>);
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x00112656 File Offset: 0x00110856
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x0011292E File Offset: 0x00110B2E
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			AsyncMethodBuilderCore.SetStateMachine(stateMachine, null);
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x00113206 File Offset: 0x00111406
		public void SetResult(TResult result)
		{
			if (this.m_task == null)
			{
				this._result = result;
				this.m_task = AsyncValueTaskMethodBuilder<TResult>.s_syncSuccessSentinel;
				return;
			}
			AsyncTaskMethodBuilder<TResult>.SetExistingTaskResult(this.m_task, result);
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x0011322F File Offset: 0x0011142F
		public void SetException(Exception exception)
		{
			AsyncTaskMethodBuilder<TResult>.SetException(exception, ref this.m_task);
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06007370 RID: 29552 RVA: 0x00113240 File Offset: 0x00111440
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTask<TResult> Task
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				if (this.m_task == AsyncValueTaskMethodBuilder<TResult>.s_syncSuccessSentinel)
				{
					return new ValueTask<TResult>(this._result);
				}
				Task<TResult> task;
				if ((task = this.m_task) == null)
				{
					task = (this.m_task = new Task<TResult>());
				}
				return new ValueTask<TResult>(task);
			}
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x00113283 File Offset: 0x00111483
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<TResult>.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x00113292 File Offset: 0x00111492
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<TResult>.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06007373 RID: 29555 RVA: 0x001132A4 File Offset: 0x001114A4
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

		// Token: 0x0400147D RID: 5245
		internal static readonly Task<TResult> s_syncSuccessSentinel = new Task<TResult>(default(TResult));

		// Token: 0x0400147E RID: 5246
		private Task<TResult> m_task;

		// Token: 0x0400147F RID: 5247
		private TResult _result;
	}
}
