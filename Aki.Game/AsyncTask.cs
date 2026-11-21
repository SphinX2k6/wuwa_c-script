using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AA7 RID: 10919
public class AsyncTask : TaskBase
{
	// Token: 0x0601BBFF RID: 113663 RVA: 0x0088B653 File Offset: 0x00889853
	[NullableContext(2)]
	public AsyncTask([Nullable(1)] string name, [Nullable(new byte[]
	{
		1,
		0
	})] Func<UniTask<bool>> runHandle, Func<bool> initHandle = null, Action<bool> finishedCallback = null, TaskInterruptOptions interruptOptions = null) : base(name, initHandle, finishedCallback, interruptOptions)
	{
		this.RunHandle = runHandle;
	}

	// Token: 0x0601BC00 RID: 113664 RVA: 0x0088B668 File Offset: 0x00889868
	protected override UniTask<bool> OnRun()
	{
		AsyncTask.<OnRun>d__2 <OnRun>d__;
		<OnRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnRun>d__.<>4__this = this;
		<OnRun>d__.<>1__state = -1;
		<OnRun>d__.<>t__builder.Start<AsyncTask.<OnRun>d__2>(ref <OnRun>d__);
		return <OnRun>d__.<>t__builder.Task;
	}

	// Token: 0x0400EFD6 RID: 61398
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly Func<UniTask<bool>> RunHandle;
}
