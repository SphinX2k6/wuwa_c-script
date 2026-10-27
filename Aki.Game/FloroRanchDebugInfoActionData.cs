using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001ADF RID: 6879
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDebugInfoActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC0A RID: 52234 RVA: 0x002E90BF File Offset: 0x002E72BF
	public FloroRanchDebugInfoActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.DebugInfo = actionData.ActionInfo;
	}

	// Token: 0x0600CC0B RID: 52235 RVA: 0x002E90D4 File Offset: 0x002E72D4
	public override UniTask OnExecute()
	{
		FloroRanchDebugInfoActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchDebugInfoActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DCB RID: 24011
	private readonly FRDebugActionInfo DebugInfo;
}
