using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AEA RID: 6890
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchStageTributeChange : FloroRanchActionDataBase
{
	// Token: 0x0600CC2E RID: 52270 RVA: 0x002E97FF File Offset: 0x002E79FF
	public FloroRanchStageTributeChange(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.TributeChange;
	}

	// Token: 0x0600CC2F RID: 52271 RVA: 0x002E9814 File Offset: 0x002E7A14
	public override UniTask OnExecute()
	{
		FloroRanchStageTributeChange.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchStageTributeChange.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DDB RID: 24027
	private readonly FRActionStageTributeChange ActionData;
}
