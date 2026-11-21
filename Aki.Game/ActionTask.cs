using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AA6 RID: 10918
public class ActionTask : TaskBase
{
	// Token: 0x0601BBFD RID: 113661 RVA: 0x0088B5F9 File Offset: 0x008897F9
	[NullableContext(1)]
	public ActionTask(string name, Func<bool> runHandle, [Nullable(2)] Func<bool> initHandle = null, [Nullable(2)] Action<bool> finishedCallback = null) : base(name, initHandle, finishedCallback, null)
	{
		this.RunHandle = runHandle;
	}

	// Token: 0x0601BBFE RID: 113662 RVA: 0x0088B610 File Offset: 0x00889810
	protected override UniTask<bool> OnRun()
	{
		ActionTask.<OnRun>d__2 <OnRun>d__;
		<OnRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnRun>d__.<>4__this = this;
		<OnRun>d__.<>1__state = -1;
		<OnRun>d__.<>t__builder.Start<ActionTask.<OnRun>d__2>(ref <OnRun>d__);
		return <OnRun>d__.<>t__builder.Task;
	}

	// Token: 0x0400EFD5 RID: 61397
	[Nullable(1)]
	private readonly Func<bool> RunHandle;
}
