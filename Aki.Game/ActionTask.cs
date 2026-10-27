using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02003531 RID: 13617
public class ActionTask : TaskBase
{
	// Token: 0x0601DED5 RID: 122581 RVA: 0x008639C1 File Offset: 0x00861BC1
	[NullableContext(1)]
	public ActionTask(string name, Func<bool> runHandle, [Nullable(2)] Func<bool> initHandle = null, [Nullable(2)] Action<bool> finishedCallback = null) : base(name, initHandle, finishedCallback, null)
	{
		this.RunHandle = runHandle;
	}

	// Token: 0x0601DED6 RID: 122582 RVA: 0x008639D8 File Offset: 0x00861BD8
	protected override UniTask<bool> OnRun()
	{
		ActionTask.<OnRun>d__2 <OnRun>d__;
		<OnRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnRun>d__.<>4__this = this;
		<OnRun>d__.<>1__state = -1;
		<OnRun>d__.<>t__builder.Start<ActionTask.<OnRun>d__2>(ref <OnRun>d__);
		return <OnRun>d__.<>t__builder.Task;
	}

	// Token: 0x0400EB18 RID: 60184
	[Nullable(1)]
	private readonly Func<bool> RunHandle;
}
