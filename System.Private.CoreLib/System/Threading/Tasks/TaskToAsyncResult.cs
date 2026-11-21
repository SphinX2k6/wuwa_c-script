using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004F0 RID: 1264
	[NullableContext(1)]
	[Nullable(0)]
	public static class TaskToAsyncResult
	{
		// Token: 0x060047ED RID: 18413 RVA: 0x000EFE8C File Offset: 0x000EE08C
		public static IAsyncResult Begin(Task task, [Nullable(2)] AsyncCallback callback, [Nullable(2)] object state)
		{
			ArgumentNullException.ThrowIfNull(task, "task");
			return new TaskToAsyncResult.TaskAsyncResult(task, state, callback);
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x000EFEA4 File Offset: 0x000EE0A4
		public static void End(IAsyncResult asyncResult)
		{
			TaskToAsyncResult.Unwrap(asyncResult).GetAwaiter().GetResult();
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x000EFEC4 File Offset: 0x000EE0C4
		public static TResult End<[Nullable(2)] TResult>(IAsyncResult asyncResult)
		{
			return TaskToAsyncResult.Unwrap<TResult>(asyncResult).GetAwaiter().GetResult();
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x000EFEE4 File Offset: 0x000EE0E4
		public static Task Unwrap(IAsyncResult asyncResult)
		{
			ArgumentNullException.ThrowIfNull(asyncResult, "asyncResult");
			TaskToAsyncResult.TaskAsyncResult taskAsyncResult = asyncResult as TaskToAsyncResult.TaskAsyncResult;
			Task task = (taskAsyncResult != null) ? taskAsyncResult._task : null;
			if (task == null)
			{
				throw new ArgumentException(null, "asyncResult");
			}
			return task;
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x000EFF12 File Offset: 0x000EE112
		public static Task<TResult> Unwrap<[Nullable(2)] TResult>(IAsyncResult asyncResult)
		{
			ArgumentNullException.ThrowIfNull(asyncResult, "asyncResult");
			TaskToAsyncResult.TaskAsyncResult taskAsyncResult = asyncResult as TaskToAsyncResult.TaskAsyncResult;
			Task<TResult> task = ((taskAsyncResult != null) ? taskAsyncResult._task : null) as Task<TResult>;
			if (task == null)
			{
				throw new ArgumentException(null, "asyncResult");
			}
			return task;
		}

		// Token: 0x020004F1 RID: 1265
		private sealed class TaskAsyncResult : IAsyncResult
		{
			// Token: 0x060047F2 RID: 18418 RVA: 0x000EFF48 File Offset: 0x000EE148
			internal TaskAsyncResult(Task task, object state, AsyncCallback callback)
			{
				this._task = task;
				this.AsyncState = state;
				if (task.IsCompleted)
				{
					this.CompletedSynchronously = 1;
					if (callback != null)
					{
						callback(this);
						return;
					}
				}
				else if (callback != null)
				{
					this._callback = callback;
					this._task.ConfigureAwait(false).GetAwaiter().OnCompleted(delegate
					{
						this._callback(this);
					});
				}
			}

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x060047F3 RID: 18419 RVA: 0x000EFFB5 File Offset: 0x000EE1B5
			public object AsyncState { get; }

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x060047F4 RID: 18420 RVA: 0x000EFFBD File Offset: 0x000EE1BD
			public bool CompletedSynchronously { get; }

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x060047F5 RID: 18421 RVA: 0x000EFFC5 File Offset: 0x000EE1C5
			public bool IsCompleted
			{
				get
				{
					return this._task.IsCompleted;
				}
			}

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x060047F6 RID: 18422 RVA: 0x000EFFD2 File Offset: 0x000EE1D2
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return ((IAsyncResult)this._task).AsyncWaitHandle;
				}
			}

			// Token: 0x04001104 RID: 4356
			internal readonly Task _task;

			// Token: 0x04001105 RID: 4357
			private readonly AsyncCallback _callback;
		}
	}
}
