using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AA8 RID: 10920
public class DelayTask : TaskBase
{
	// Token: 0x0601BC01 RID: 113665 RVA: 0x0088B6AB File Offset: 0x008898AB
	[NullableContext(2)]
	public DelayTask([Nullable(1)] string name, Func<bool> runHandle = null, Func<bool> initHandle = null, int delay = 1000, Action<bool> finishedCallback = null) : base(name, initHandle, finishedCallback, null)
	{
		this.RunHandle = runHandle;
		this.DelayTime = Math.Max(delay, 20);
	}

	// Token: 0x0601BC02 RID: 113666 RVA: 0x0088B6DC File Offset: 0x008898DC
	protected override UniTask<bool> OnRun()
	{
		DelayTask.<OnRun>d__5 <OnRun>d__;
		<OnRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnRun>d__.<>4__this = this;
		<OnRun>d__.<>1__state = -1;
		<OnRun>d__.<>t__builder.Start<DelayTask.<OnRun>d__5>(ref <OnRun>d__);
		return <OnRun>d__.<>t__builder.Task;
	}

	// Token: 0x0400EFD7 RID: 61399
	private const int DEFAULT_DELAY_TIME = 1000;

	// Token: 0x0400EFD8 RID: 61400
	[Nullable(2)]
	private readonly Func<bool> RunHandle;

	// Token: 0x0400EFD9 RID: 61401
	private readonly int DelayTime;

	// Token: 0x0400EFDA RID: 61402
	[Nullable(1)]
	private readonly UniTaskCompletionSource<bool> DelayPromise = new UniTaskCompletionSource<bool>();
}
