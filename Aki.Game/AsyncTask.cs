using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02003532 RID: 13618
public class AsyncTask : TaskBase
{
	// Token: 0x0601DED7 RID: 122583 RVA: 0x00863A1B File Offset: 0x00861C1B
	[NullableContext(2)]
	public AsyncTask([Nullable(1)] string name, [Nullable(new byte[]
	{
		1,
		0
	})] Func<UniTask<bool>> runHandle, Func<bool> initHandle = null, Action<bool> finishedCallback = null, TaskInterruptOptions interruptOptions = null) : base(name, initHandle, finishedCallback, interruptOptions)
	{
		this.RunHandle = runHandle;
	}

	// Token: 0x0601DED8 RID: 122584 RVA: 0x00863A30 File Offset: 0x00861C30
	protected override UniTask<bool> OnRun()
	{
		AsyncTask.<OnRun>d__2 <OnRun>d__;
		<OnRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnRun>d__.<>4__this = this;
		<OnRun>d__.<>1__state = -1;
		<OnRun>d__.<>t__builder.Start<AsyncTask.<OnRun>d__2>(ref <OnRun>d__);
		return <OnRun>d__.<>t__builder.Task;
	}

	// Token: 0x0400EB19 RID: 60185
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly Func<UniTask<bool>> RunHandle;
}
