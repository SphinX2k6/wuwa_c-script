using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004625 RID: 17957
	public class UiAsyncTaskManager
	{
		// Token: 0x0602E427 RID: 189479 RVA: 0x00AB1EFC File Offset: 0x00AB00FC
		public UniTask<bool> RunTask([Nullable(1)] UiAsyncTask task)
		{
			UiAsyncTaskManager.<RunTask>d__1 <RunTask>d__;
			<RunTask>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RunTask>d__.<>4__this = this;
			<RunTask>d__.task = task;
			<RunTask>d__.<>1__state = -1;
			<RunTask>d__.<>t__builder.Start<UiAsyncTaskManager.<RunTask>d__1>(ref <RunTask>d__);
			return <RunTask>d__.<>t__builder.Task;
		}

		// Token: 0x0602E428 RID: 189480 RVA: 0x00AB1F48 File Offset: 0x00AB0148
		public void CancelAllTask()
		{
			if (this.TaskQueueMap == null || this.TaskQueueMap.Count == 0)
			{
				return;
			}
			foreach (UiAsyncTaskQueue uiAsyncTaskQueue in this.TaskQueueMap.Values)
			{
				uiAsyncTaskQueue.Cancel();
			}
			this.TaskQueueMap.Clear();
		}

		// Token: 0x0602E429 RID: 189481 RVA: 0x00AB1FC0 File Offset: 0x00AB01C0
		[NullableContext(1)]
		public void CancelPendingByName(string name)
		{
			UiAsyncTaskQueue uiAsyncTaskQueue;
			if (this.TaskQueueMap.TryGetValue(name, out uiAsyncTaskQueue))
			{
				uiAsyncTaskQueue.CancelPending();
			}
		}

		// Token: 0x0602E42A RID: 189482 RVA: 0x00AB1FE3 File Offset: 0x00AB01E3
		[NullableContext(2)]
		public void LogInfo(string key)
		{
		}

		// Token: 0x04018D4B RID: 101707
		[Nullable(1)]
		private Dictionary<string, UiAsyncTaskQueue> TaskQueueMap;
	}
}
