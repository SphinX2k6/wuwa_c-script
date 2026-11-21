using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004C5 RID: 1221
	internal static class TaskCache
	{
		// Token: 0x0600468C RID: 18060 RVA: 0x000EC334 File Offset: 0x000EA534
		internal static Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			return new Task<TResult>(false, result, (TaskCreationOptions)16384, default(CancellationToken));
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x000EC358 File Offset: 0x000EA558
		private static Task<int>[] CreateInt32Tasks()
		{
			Task<int>[] array = new Task<int>[10];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = TaskCache.CreateCacheableTask<int>(i + -1);
			}
			return array;
		}

		// Token: 0x0400108A RID: 4234
		internal static readonly Task<bool> s_trueTask = TaskCache.CreateCacheableTask<bool>(true);

		// Token: 0x0400108B RID: 4235
		internal static readonly Task<bool> s_falseTask = TaskCache.CreateCacheableTask<bool>(false);

		// Token: 0x0400108C RID: 4236
		internal static readonly Task<int>[] s_int32Tasks = TaskCache.CreateInt32Tasks();
	}
}
