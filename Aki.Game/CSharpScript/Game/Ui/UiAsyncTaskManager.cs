using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200354E RID: 13646
	public class UiAsyncTaskManager
	{
		// Token: 0x06022B1C RID: 142108 RVA: 0x009DE5F0 File Offset: 0x009DC7F0
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

		// Token: 0x06022B1D RID: 142109 RVA: 0x009DE63C File Offset: 0x009DC83C
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

		// Token: 0x06022B1E RID: 142110 RVA: 0x009DE6B4 File Offset: 0x009DC8B4
		[NullableContext(1)]
		public void CancelPendingByName(string name)
		{
			UiAsyncTaskQueue uiAsyncTaskQueue;
			if (this.TaskQueueMap.TryGetValue(name, out uiAsyncTaskQueue))
			{
				uiAsyncTaskQueue.CancelPending();
			}
		}

		// Token: 0x06022B1F RID: 142111 RVA: 0x009DE6D7 File Offset: 0x009DC8D7
		[NullableContext(2)]
		public void LogInfo(string key)
		{
		}

		// Token: 0x0401338A RID: 78730
		[Nullable(1)]
		private Dictionary<string, UiAsyncTaskQueue> TaskQueueMap;
	}
}
