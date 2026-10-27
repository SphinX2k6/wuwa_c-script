using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001ADA RID: 6874
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchActionStopActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CBF3 RID: 52211 RVA: 0x002E8C4D File Offset: 0x002E6E4D
	public FloroRanchActionStopActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.ActionStop;
	}

	// Token: 0x0600CBF4 RID: 52212 RVA: 0x002E8C64 File Offset: 0x002E6E64
	public override UniTask OnExecute()
	{
		FloroRanchActionStopActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchActionStopActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DC3 RID: 24003
	private readonly FRActionStop ActionData;
}
