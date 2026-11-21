using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000661 RID: 1633
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Auto)]
	public struct AsyncIteratorMethodBuilder
	{
		// Token: 0x06007321 RID: 29473 RVA: 0x00112640 File Offset: 0x00110840
		public static AsyncIteratorMethodBuilder Create()
		{
			return default(AsyncIteratorMethodBuilder);
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x00112656 File Offset: 0x00110856
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void MoveNext<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x0011265E File Offset: 0x0011085E
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x0011266D File Offset: 0x0011086D
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x0011267C File Offset: 0x0011087C
		public void Complete()
		{
			if (this.m_task == null)
			{
				this.m_task = Task.s_cachedCompleted;
				return;
			}
			AsyncTaskMethodBuilder<VoidTaskResult>.SetExistingTaskResult(this.m_task, default(VoidTaskResult));
			IAsyncStateMachineBox asyncStateMachineBox = this.m_task as IAsyncStateMachineBox;
			if (asyncStateMachineBox != null)
			{
				asyncStateMachineBox.ClearStateUponCompletion();
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06007326 RID: 29478 RVA: 0x001126C8 File Offset: 0x001108C8
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

		// Token: 0x04001472 RID: 5234
		private Task<VoidTaskResult> m_task;
	}
}
