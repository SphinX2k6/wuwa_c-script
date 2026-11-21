using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004C7 RID: 1223
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskCompletionSource
	{
		// Token: 0x06004696 RID: 18070 RVA: 0x000EC425 File Offset: 0x000EA625
		public TaskCompletionSource()
		{
			this._task = new Task();
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x000EC438 File Offset: 0x000EA638
		public TaskCompletionSource(TaskCreationOptions creationOptions) : this(null, creationOptions)
		{
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x000EC442 File Offset: 0x000EA642
		[NullableContext(2)]
		public TaskCompletionSource(object state) : this(state, TaskCreationOptions.None)
		{
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x000EC44C File Offset: 0x000EA64C
		[NullableContext(2)]
		public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
		{
			this._task = new Task(state, creationOptions, true);
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x000EC462 File Offset: 0x000EA662
		public Task Task
		{
			get
			{
				return this._task;
			}
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x000EC46A File Offset: 0x000EA66A
		public void SetException(Exception exception)
		{
			if (!this.TrySetException(exception))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x000EC47C File Offset: 0x000EA67C
		public void SetException(IEnumerable<Exception> exceptions)
		{
			if (!this.TrySetException(exceptions))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x000EC48E File Offset: 0x000EA68E
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

		// Token: 0x0600469E RID: 18078 RVA: 0x000EC4C4 File Offset: 0x000EA6C4
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

		// Token: 0x0600469F RID: 18079 RVA: 0x000EC560 File Offset: 0x000EA760
		public void SetResult()
		{
			if (!this.TrySetResult())
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x000EC571 File Offset: 0x000EA771
		public bool TrySetResult()
		{
			bool flag = this._task.TrySetResult();
			if (!flag)
			{
				this._task.SpinUntilCompleted();
			}
			return flag;
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x000EC58C File Offset: 0x000EA78C
		public void SetCanceled()
		{
			this.SetCanceled(default(CancellationToken));
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x000EC5A8 File Offset: 0x000EA7A8
		public void SetCanceled(CancellationToken cancellationToken)
		{
			if (!this.TrySetCanceled(cancellationToken))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x000EC5BC File Offset: 0x000EA7BC
		public bool TrySetCanceled()
		{
			return this.TrySetCanceled(default(CancellationToken));
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x000EC5D8 File Offset: 0x000EA7D8
		public bool TrySetCanceled(CancellationToken cancellationToken)
		{
			bool flag = this._task.TrySetCanceled(cancellationToken);
			if (!flag && !this._task.IsCompleted)
			{
				this._task.SpinUntilCompleted();
			}
			return flag;
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x000EC601 File Offset: 0x000EA801
		public void SetFromTask(Task completedTask)
		{
			if (!this.TrySetFromTask(completedTask))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x000EC614 File Offset: 0x000EA814
		public bool TrySetFromTask(Task completedTask)
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
				flag = this._task.TrySetResult();
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

		// Token: 0x0400108E RID: 4238
		private readonly Task _task;
	}
}
