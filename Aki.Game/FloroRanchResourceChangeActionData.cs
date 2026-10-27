using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE7 RID: 6887
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchResourceChangeActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC27 RID: 52263 RVA: 0x002E96DF File Offset: 0x002E78DF
	public FloroRanchResourceChangeActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ChangeData = actionData.ResourcesChange;
	}

	// Token: 0x0600CC28 RID: 52264 RVA: 0x002E96F4 File Offset: 0x002E78F4
	public override UniTask OnExecute()
	{
		FloroRanchResourceChangeActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchResourceChangeActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DD7 RID: 24023
	private readonly FRUnitResourcesChangeAction ChangeData;
}
