using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001ADC RID: 6876
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchBuffUpdateActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC04 RID: 52228 RVA: 0x002E8FBB File Offset: 0x002E71BB
	public FloroRanchBuffUpdateActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.BuffData = actionData.BuffOpGroup;
	}

	// Token: 0x0600CC05 RID: 52229 RVA: 0x002E8FD0 File Offset: 0x002E71D0
	public override UniTask OnExecute()
	{
		FloroRanchBuffUpdateActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchBuffUpdateActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DC8 RID: 24008
	private readonly FRUnitBuffOperateActionGroup BuffData;
}
