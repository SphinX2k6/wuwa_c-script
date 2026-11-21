using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006D3 RID: 1747
	public readonly struct TaskAwaiter<[Nullable(2)] TResult> : ICriticalNotifyCompletion, INotifyCompletion, ITaskAwaiter
	{
		// Token: 0x060074A9 RID: 29865 RVA: 0x00115D7D File Offset: 0x00113F7D
		internal TaskAwaiter(Task<TResult> task)
		{
			this.m_task = task;
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060074AA RID: 29866 RVA: 0x00115D86 File Offset: 0x00113F86
		public bool IsCompleted
		{
			get
			{
				return this.m_task.IsCompleted;
			}
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x00115D93 File Offset: 0x00113F93
		[NullableContext(1)]
		public void OnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, true);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x00115DA3 File Offset: 0x00113FA3
		[NullableContext(1)]
		public void UnsafeOnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, false);
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x00115DB3 File Offset: 0x00113FB3
		[NullableContext(1)]
		[StackTraceHidden]
		public TResult GetResult()
		{
			TaskAwaiter.ValidateEnd(this.m_task, ConfigureAwaitOptions.None);
			return this.m_task.ResultOnSuccess;
		}

		// Token: 0x040014F6 RID: 5366
		private readonly Task<TResult> m_task;
	}
}
