using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02003533 RID: 13619
public class DelayTask : TaskBase
{
	// Token: 0x0601DED9 RID: 122585 RVA: 0x00863A73 File Offset: 0x00861C73
	[NullableContext(2)]
	public DelayTask([Nullable(1)] string name, Func<bool> runHandle = null, Func<bool> initHandle = null, int delay = 1000, Action<bool> finishedCallback = null) : base(name, initHandle, finishedCallback, null)
	{
		this.RunHandle = runHandle;
		this.DelayTime = Math.Max(delay, 20);
	}

	// Token: 0x0601DEDA RID: 122586 RVA: 0x00863AA4 File Offset: 0x00861CA4
	protected override UniTask<bool> OnRun()
	{
		DelayTask.<OnRun>d__5 <OnRun>d__;
		<OnRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnRun>d__.<>4__this = this;
		<OnRun>d__.<>1__state = -1;
		<OnRun>d__.<>t__builder.Start<DelayTask.<OnRun>d__5>(ref <OnRun>d__);
		return <OnRun>d__.<>t__builder.Task;
	}

	// Token: 0x0400EB1A RID: 60186
	private const int DEFAULT_DELAY_TIME = 1000;

	// Token: 0x0400EB1B RID: 60187
	[Nullable(2)]
	private readonly Func<bool> RunHandle;

	// Token: 0x0400EB1C RID: 60188
	private readonly int DelayTime;

	// Token: 0x0400EB1D RID: 60189
	[Nullable(1)]
	private readonly UniTaskCompletionSource<bool> DelayPromise = new UniTaskCompletionSource<bool>();
}
