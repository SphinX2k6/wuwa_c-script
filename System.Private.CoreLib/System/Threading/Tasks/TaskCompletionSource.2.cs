using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004C8 RID: 1224
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskCompletionSource<[Nullable(2)] TResult>
	{
		// Token: 0x060046A7 RID: 18087 RVA: 0x000EC6B9 File Offset: 0x000EA8B9
		public TaskCompletionSource()
		{
			this._task = new Task<TResult>();
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x000EC6CC File Offset: 0x000EA8CC
		public TaskCompletionSource(TaskCreationOptions creationOptions) : this(null, creationOptions)
		{
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x000EC6D6 File Offset: 0x000EA8D6
		[NullableContext(2)]
		public TaskCompletionSource(object state) : this(state, TaskCreationOptions.None)
		{
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x000EC6E0 File Offset: 0x000EA8E0
		[NullableContext(2)]
		public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
		{
			this._task = new Task<TResult>(state, creationOptions);
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x000EC6F5 File Offset: 0x000EA8F5
		public Task<TResult> Task
		{
			get
			{
				return this._task;
			}
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x000EC6FD File Offset: 0x000EA8FD
		public void SetException(Exception exception)
		{
			if (!this.TrySetException(exception))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x000EC70F File Offset: 0x000EA90F
		public void SetException(IEnumerable<Exception> exceptions)
		{
			if (!this.TrySetException(exceptions))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x000EC721 File Offset: 0x000EA921
		public bool TrySetException(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			bool flag = this._task.TrySetException(exception);
			if (!flag && !this._task.IsCompleted)
			{
				this._task.SpinUntilCompleted();
			}
			return flag;
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x000EC754 File Offset: 0x000EA954
		public bool TrySetException(IEnumerable<Exception> exceptions)
		{
			if (exceptions == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exceptions);
			}
			List<Exception> list = new List<Exception>();
			foreach (Exception ex in exceptions)
			{
				if (ex == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.TaskCompletionSourceT_TrySetException_NullException, ExceptionArgument.exceptions);
				}
				list.Add(ex);
			}
			if (list.Count == 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.TaskCompletionSourceT_TrySetException_NoExceptions, ExceptionArgument.exceptions);
			}
			bool flag = this._task.TrySetException(list);
			if (!flag && !this._task.IsCompleted)
			{
				this._task.SpinUntilCompleted();
			}
			return flag;
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x000EC7F0 File Offset: 0x000EA9F0
		public void SetResult(TResult result)
		{
			if (!this.TrySetResult(result))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x000EC802 File Offset: 0x000EAA02
		public bool TrySetResult(TResult result)
		{
			bool flag = this._task.TrySetResult(result);
			if (!flag)
			{
				this._task.SpinUntilCompleted();
			}
			return flag;
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x000EC820 File Offset: 0x000EAA20
		public void SetCanceled()
		{
			this.SetCanceled(default(CancellationToken));
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x000EC83C File Offset: 0x000EAA3C
		public void SetCanceled(CancellationToken cancellationToken)
		{
			if (!this.TrySetCanceled(cancellationToken))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x000EC850 File Offset: 0x000EAA50
		public bool TrySetCanceled()
		{
			return this.TrySetCanceled(default(CancellationToken));
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x000EC86C File Offset: 0x000EAA6C
		public bool TrySetCanceled(CancellationToken cancellationToken)
		{
			bool flag = this._task.TrySetCanceled(cancellationToken);
			if (!flag && !this._task.IsCompleted)
			{
				this._task.SpinUntilCompleted();
			}
			return flag;
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x000EC895 File Offset: 0x000EAA95
		public void SetFromTask(Task<TResult> completedTask)
		{
			if (!this.TrySetFromTask(completedTask))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x000EC8A8 File Offset: 0x000EAAA8
		public bool TrySetFromTask(Task<TResult> completedTask)
		{
			ArgumentNullException.ThrowIfNull(completedTask, "completedTask");
			if (!completedTask.IsCompleted)
			{
				throw new ArgumentException(SR.Task_MustBeCompleted, "completedTask");
			}
			bool flag = false;
			switch (completedTask.Status)
			{
			case TaskStatus.RanToCompletion:
				flag = this._task.TrySetResult(completedTask.Result);
				break;
			case TaskStatus.Canceled:
				flag = this._task.TrySetCanceled(completedTask.CancellationToken, completedTask.GetCancellationExceptionDispatchInfo());
				break;
			case TaskStatus.Faulted:
				flag = this._task.TrySetException(completedTask.GetExceptionDispatchInfos());
				break;
			}
			if (!flag && !this._task.IsCompleted)
			{
				this._task.SpinUntilCompleted();
			}
			return flag;
		}

		// Token: 0x0400108F RID: 4239
		private readonly Task<TResult> _task;
	}
}
