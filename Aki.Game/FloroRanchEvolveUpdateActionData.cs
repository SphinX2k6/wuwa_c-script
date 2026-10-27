using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE4 RID: 6884
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEvolveUpdateActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC1C RID: 52252 RVA: 0x002E9477 File Offset: 0x002E7677
	public FloroRanchEvolveUpdateActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.EvolveActionData = actionData.EvolveUpdate;
	}

	// Token: 0x0600CC1D RID: 52253 RVA: 0x002E948C File Offset: 0x002E768C
	public override UniTask OnExecute()
	{
		FloroRanchEvolveUpdateActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEvolveUpdateActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DD3 RID: 24019
	private readonly FREvolveUpdateAction EvolveActionData;
}
