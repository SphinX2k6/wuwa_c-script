using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000667 RID: 1639
	[NullableContext(1)]
	[Nullable(0)]
	public struct AsyncTaskMethodBuilder
	{
		// Token: 0x06007335 RID: 29493 RVA: 0x00112918 File Offset: 0x00110B18
		public static AsyncTaskMethodBuilder Create()
		{
			return default(AsyncTaskMethodBuilder);
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x00112656 File Offset: 0x00110856
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x0011292E File Offset: 0x00110B2E
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			AsyncMethodBuilderCore.SetStateMachine(stateMachine, null);
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x00112937 File Offset: 0x00110B37
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x00112946 File Offset: 0x00110B46
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x00112955 File Offset: 0x00110B55
		public Task Task
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.m_task ?? this.InitializeTaskAsPromise();
			}
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x00112968 File Offset: 0x00110B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<VoidTaskResult> InitializeTaskAsPromise()
		{
			return this.m_task = new Task<VoidTaskResult>();
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x00112984 File Offset: 0x00110B84
		public void SetResult()
		{
			if (this.m_task == null)
			{
				this.m_task = Task.s_cachedCompleted;
				return;
			}
			AsyncTaskMethodBuilder<VoidTaskResult>.SetExistingTaskResult(this.m_task, default(VoidTaskResult));
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x001129B9 File Offset: 0x00110BB9
		public void SetException(Exception exception)
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.SetException(exception, ref this.m_task);
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x001129C7 File Offset: 0x00110BC7
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.SetNotificationForWaitCompletion(enabled, ref this.m_task);
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x001129D8 File Offset: 0x00110BD8
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

		// Token: 0x04001477 RID: 5239
		private Task<VoidTaskResult> m_task;
	}
}
