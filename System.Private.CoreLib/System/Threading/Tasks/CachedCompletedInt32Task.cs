using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200048F RID: 1167
	internal struct CachedCompletedInt32Task
	{
		// Token: 0x0600445F RID: 17503 RVA: 0x000E4F3C File Offset: 0x000E313C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Task<int> GetTask(int result)
		{
			Task<int> task = this._task;
			if (task != null && task.Result == result)
			{
				return task;
			}
			return this._task = Task.FromResult<int>(result);
		}

		// Token: 0x04000FB0 RID: 4016
		private Task<int> _task;
	}
}
