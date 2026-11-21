using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006BB RID: 1723
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Auto)]
	public struct PoolingAsyncValueTaskMethodBuilder
	{
		// Token: 0x06007446 RID: 29766 RVA: 0x00115250 File Offset: 0x00113450
		public static PoolingAsyncValueTaskMethodBuilder Create()
		{
			return default(PoolingAsyncValueTaskMethodBuilder);
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x00112656 File Offset: 0x00110856
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x0011292E File Offset: 0x00110B2E
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			AsyncMethodBuilderCore.SetStateMachine(stateMachine, null);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00115268 File Offset: 0x00113468
		public void SetResult()
		{
			if (this.m_task == null)
			{
				this.m_task = PoolingAsyncValueTaskMethodBuilder.s_syncSuccessSentinel;
				return;
			}
			this.m_task.SetResult(default(VoidTaskResult));
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x0011529D File Offset: 0x0011349D
		public void SetException(Exception exception)
		{
			PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.SetException(exception, ref this.m_task);
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x0600744B RID: 29771 RVA: 0x001152AC File Offset: 0x001134AC
		public ValueTask Task
		{
			get
			{
				if (this.m_task == PoolingAsyncValueTaskMethodBuilder.s_syncSuccessSentinel)
				{
					return default(ValueTask);
				}
				PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.StateMachineBox stateMachineBox;
				if ((stateMachineBox = this.m_task) == null)
				{
					stateMachineBox = (this.m_task = PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.CreateWeaklyTypedStateMachineBox());
				}
				PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.StateMachineBox stateMachineBox2 = stateMachineBox;
				return new ValueTask(stateMachineBox2, stateMachineBox2.Version);
			}
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x001152F5 File Offset: 0x001134F5
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x00115304 File Offset: 0x00113504
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x040014D7 RID: 5335
		private static readonly PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.StateMachineBox s_syncSuccessSentinel = PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.s_syncSuccessSentinel;

		// Token: 0x040014D8 RID: 5336
		private PoolingAsyncValueTaskMethodBuilder<VoidTaskResult>.StateMachineBox m_task;
	}
}
