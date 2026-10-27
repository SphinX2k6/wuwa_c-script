using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE0 RID: 6880
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEatActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC0C RID: 52236 RVA: 0x002E9117 File Offset: 0x002E7317
	public FloroRanchEatActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionDataList = actionData.UnitOpGroup;
	}

	// Token: 0x0600CC0D RID: 52237 RVA: 0x002E912C File Offset: 0x002E732C
	public override UniTask OnExecute()
	{
		FloroRanchEatActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEatActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DCC RID: 24012
	private readonly FRUnitOperateActionGroup ActionDataList;
}
