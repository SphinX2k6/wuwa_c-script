using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004D8 RID: 1240
	[NullableContext(1)]
	[Nullable(0)]
	public static class TaskExtensions
	{
		// Token: 0x060046F2 RID: 18162 RVA: 0x000ED67B File Offset: 0x000EB87B
		public static Task Unwrap(this Task<Task> task)
		{
			ArgumentNullException.ThrowIfNull(task, "task");
			Task result;
			if (task.IsCompletedSuccessfully)
			{
				if ((result = task.Result) == null)
				{
					return Task.FromCanceled(new CancellationToken(true));
				}
			}
			else
			{
				result = Task.CreateUnwrapPromise<VoidTaskResult>(task, false);
			}
			return result;
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x000ED6AD File Offset: 0x000EB8AD
		public static Task<TResult> Unwrap<[Nullable(2)] TResult>(this Task<Task<TResult>> task)
		{
			ArgumentNullException.ThrowIfNull(task, "task");
			Task<TResult> result;
			if (task.IsCompletedSuccessfully)
			{
				if ((result = task.Result) == null)
				{
					return Task.FromCanceled<TResult>(new CancellationToken(true));
				}
			}
			else
			{
				result = Task.CreateUnwrapPromise<TResult>(task, false);
			}
			return result;
		}
	}
}
