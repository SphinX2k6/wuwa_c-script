using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000F9E RID: 3998
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDebugInfoActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A01B RID: 40987 RVA: 0x002F4253 File Offset: 0x002F2453
	public FloroRanchDebugInfoActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.DebugInfo = actionData.ActionInfo;
	}

	// Token: 0x0600A01C RID: 40988 RVA: 0x002F4268 File Offset: 0x002F2468
	public override UniTask OnExecute()
	{
		FloroRanchDebugInfoActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchDebugInfoActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005E9A RID: 24218
	private readonly FRDebugActionInfo DebugInfo;
}
