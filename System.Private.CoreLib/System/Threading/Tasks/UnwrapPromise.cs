using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004C0 RID: 1216
	internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction
	{
		// Token: 0x06004672 RID: 18034 RVA: 0x000EBDEC File Offset: 0x000E9FEC
		public UnwrapPromise(Task outerTask, bool lookForOce) : base(null, outerTask.CreationOptions & TaskCreationOptions.AttachedToParent)
		{
			this._lookForOce = lookForOce;
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationBegin(base.Id, "Task.Unwrap", 0L);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(this);
			}
			if (outerTask.IsCompleted)
			{
				this.ProcessCompletedOuterTask(outerTask);
				return;
			}
			outerTask.AddCompletionAction(this, false);
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x000EBE58 File Offset: 0x000EA058
		public void Invoke(Task completingTask)
		{
			if (RuntimeHelpers.TryEnsureSufficientExecutionStack())
			{
				this.InvokeCore(completingTask);
				return;
			}
			this.InvokeCoreAsync(completingTask);
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x000EBE70 File Offset: 0x000EA070
		private void InvokeCore(Task completingTask)
		{
			byte state = this._state;
			if (state == 0)
			{
				this.ProcessCompletedOuterTask(completingTask);
				return;
			}
			if (state != 1)
			{
				return;
			}
			this.TrySetFromTask(completingTask, false);
			this._state = 2;
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x000EBEA4 File Offset: 0x000EA0A4
		private void InvokeCoreAsync(Task completingTask)
		{
			ThreadPool.UnsafeQueueUserWorkItem(delegate(object state)
			{
				TupleSlim<UnwrapPromise<TResult>, Task> tupleSlim = (TupleSlim<UnwrapPromise<TResult>, Task>)state;
				tupleSlim.Item1.InvokeCore(tupleSlim.Item2);
			}, new TupleSlim<UnwrapPromise<TResult>, Task>(this, completingTask));
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x000EBED4 File Offset: 0x000EA0D4
		private void ProcessCompletedOuterTask(Task task)
		{
			this._state = 1;
			TaskStatus status = task.Status;
			if (status != TaskStatus.RanToCompletion)
			{
				if (status - TaskStatus.Canceled <= 1)
				{
					this.TrySetFromTask(task, this._lookForOce);
					return;
				}
			}
			else
			{
				Task<Task<TResult>> task2 = task as Task<Task<TResult>>;
				this.ProcessInnerTask((task2 != null) ? task2.Result : ((Task<Task>)task).Result);
			}
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x000EBF2C File Offset: 0x000EA12C
		private bool TrySetFromTask(Task task, bool lookForOce)
		{
			if (TplEventSource.Log.IsEnabled())
			{
				TplEventSource.Log.TraceOperationRelation(base.Id, CausalityRelation.Join);
			}
			bool result = false;
			switch (task.Status)
			{
			case TaskStatus.RanToCompletion:
			{
				if (TplEventSource.Log.IsEnabled())
				{
					TplEventSource.Log.TraceOperationEnd(base.Id, AsyncCausalityStatus.Completed);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(this);
				}
				Task<TResult> task2 = task as Task<TResult>;
				result = base.TrySetResult((task2 != null) ? task2.Result : default(TResult));
				break;
			}
			case TaskStatus.Canceled:
				result = base.TrySetCanceled(task.CancellationToken, task.GetCancellationExceptionDispatchInfo());
				break;
			case TaskStatus.Faulted:
			{
				List<ExceptionDispatchInfo> exceptionDispatchInfos = task.GetExceptionDispatchInfos();
				ExceptionDispatchInfo exceptionDispatchInfo;
				if (lookForOce && exceptionDispatchInfos.Count > 0 && (exceptionDispatchInfo = exceptionDispatchInfos[0]) != null)
				{
					OperationCanceledException ex = exceptionDispatchInfo.SourceException as OperationCanceledException;
					if (ex != null)
					{
						result = base.TrySetCanceled(ex.CancellationToken, exceptionDispatchInfo);
						break;
					}
				}
				result = base.TrySetException(exceptionDispatchInfos);
				break;
			}
			}
			return result;
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x000EC02C File Offset: 0x000EA22C
		private void ProcessInnerTask(Task task)
		{
			if (task == null)
			{
				base.TrySetCanceled(default(CancellationToken));
				this._state = 2;
				return;
			}
			if (task.IsCompleted)
			{
				this.TrySetFromTask(task, false);
				this._state = 2;
				return;
			}
			task.AddCompletionAction(this, false);
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x000070DD File Offset: 0x000052DD
		public bool InvokeMayRunArbitraryCode
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0400107C RID: 4220
		private byte _state;

		// Token: 0x0400107D RID: 4221
		private readonly bool _lookForOce;
	}
}
