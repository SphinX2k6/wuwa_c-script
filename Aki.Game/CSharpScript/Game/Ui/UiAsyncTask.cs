using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200354D RID: 13645
	[NullableContext(1)]
	[Nullable(0)]
	public class UiAsyncTask
	{
		// Token: 0x06022B17 RID: 142103 RVA: 0x009DE539 File Offset: 0x009DC739
		public UiAsyncTask(string name, Func<UniTask> runHandle, [Nullable(2)] Action onTaskCancel = null)
		{
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x06022B18 RID: 142104 RVA: 0x009DE561 File Offset: 0x009DC761
		[Nullable(0)]
		public UniTask<bool> Promise
		{
			[NullableContext(0)]
			get
			{
				return this.TaskPromise.Promise;
			}
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x06022B19 RID: 142105 RVA: 0x009DE56E File Offset: 0x009DC76E
		public EUiAsyncTaskStatus Status
		{
			get
			{
				return this.StatusInternal;
			}
		}

		// Token: 0x06022B1A RID: 142106 RVA: 0x009DE578 File Offset: 0x009DC778
		public UniTask Run()
		{
			UiAsyncTask.<Run>d__11 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<UiAsyncTask.<Run>d__11>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x06022B1B RID: 142107 RVA: 0x009DE5BB File Offset: 0x009DC7BB
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

		// Token: 0x04013384 RID: 78724
		[CompilerGenerated]
		private Func<UniTask> <runHandle>P = runHandle;

		// Token: 0x04013385 RID: 78725
		[Nullable(2)]
		[CompilerGenerated]
		private Action <onTaskCancel>P = onTaskCancel;

		// Token: 0x04013386 RID: 78726
		private EUiAsyncTaskStatus StatusInternal;

		// Token: 0x04013387 RID: 78727
		private bool Canceled;

		// Token: 0x04013388 RID: 78728
		private readonly CustomPromise<bool> TaskPromise = new CustomPromise<bool>();

		// Token: 0x04013389 RID: 78729
		public readonly string Name = name;
	}
}
