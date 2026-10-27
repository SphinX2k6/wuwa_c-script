using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004624 RID: 17956
	[NullableContext(1)]
	[Nullable(0)]
	public class UiAsyncTask
	{
		// Token: 0x0602E422 RID: 189474 RVA: 0x00AB1E45 File Offset: 0x00AB0045
		public UiAsyncTask(string name, Func<UniTask> runHandle, [Nullable(2)] Action onTaskCancel = null)
		{
		}

		// Token: 0x170075DA RID: 30170
		// (get) Token: 0x0602E423 RID: 189475 RVA: 0x00AB1E6D File Offset: 0x00AB006D
		[Nullable(0)]
		public UniTask<bool> Promise
		{
			[NullableContext(0)]
			get
			{
				return this.TaskPromise.Promise;
			}
		}

		// Token: 0x170075DB RID: 30171
		// (get) Token: 0x0602E424 RID: 189476 RVA: 0x00AB1E7A File Offset: 0x00AB007A
		public EUiAsyncTaskStatus Status
		{
			get
			{
				return this.StatusInternal;
			}
		}

		// Token: 0x0602E425 RID: 189477 RVA: 0x00AB1E84 File Offset: 0x00AB0084
		public UniTask Run()
		{
			UiAsyncTask.<Run>d__11 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<UiAsyncTask.<Run>d__11>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0602E426 RID: 189478 RVA: 0x00AB1EC7 File Offset: 0x00AB00C7
		public void Cancel()
		{
			if (this.StatusInternal != EUiAsyncTaskStatus.Pending && this.StatusInternal != EUiAsyncTaskStatus.Running)
			{
				return;
			}
			this.Canceled = true;
			Action action = this.<onTaskCancel>P;
			if (action != null)
			{
				action();
			}
			EUiAsyncTaskStatus statusInternal = this.StatusInternal;
		}

		// Token: 0x04018D45 RID: 101701
		[CompilerGenerated]
		private Func<UniTask> <runHandle>P = runHandle;

		// Token: 0x04018D46 RID: 101702
		[Nullable(2)]
		[CompilerGenerated]
		private Action <onTaskCancel>P = onTaskCancel;

		// Token: 0x04018D47 RID: 101703
		private EUiAsyncTaskStatus StatusInternal;

		// Token: 0x04018D48 RID: 101704
		private bool Canceled;

		// Token: 0x04018D49 RID: 101705
		private readonly CustomPromise<bool> TaskPromise = new CustomPromise<bool>();

		// Token: 0x04018D4A RID: 101706
		public readonly string Name = name;
	}
}
