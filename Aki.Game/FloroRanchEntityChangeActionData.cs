using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA2 RID: 4002
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityChangeActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A029 RID: 41001 RVA: 0x002F44F0 File Offset: 0x002F26F0
	public void InitActionData(FRUnitOperateActionGroup actionDataList)
	{
		this.ActionDataList.Clear();
		foreach (FRUnitOperateAction frunitOperateAction in actionDataList.Actions)
		{
			FloroRanchEntityActionData item = new FloroRanchEntityActionData(frunitOperateAction.OpType, frunitOperateAction.Phantom);
			this.ActionDataList.Add(item);
		}
	}

	// Token: 0x0600A02A RID: 41002 RVA: 0x002F4560 File Offset: 0x002F2760
	public FloroRanchEntityChangeActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData;
	}

	// Token: 0x0600A02B RID: 41003 RVA: 0x002F457C File Offset: 0x002F277C
	public override UniTask OnExecute()
	{
		FloroRanchEntityChangeActionData.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEntityChangeActionData.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600A02C RID: 41004 RVA: 0x002F45C0 File Offset: 0x002F27C0
	private UniTask ExecuteEntityAction(FloroRanchEntityActionData actionData)
	{
		FloroRanchEntityChangeActionData.<ExecuteEntityAction>d__5 <ExecuteEntityAction>d__;
		<ExecuteEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteEntityAction>d__.<>4__this = this;
		<ExecuteEntityAction>d__.actionData = actionData;
		<ExecuteEntityAction>d__.<>1__state = -1;
		<ExecuteEntityAction>d__.<>t__builder.Start<FloroRanchEntityChangeActionData.<ExecuteEntityAction>d__5>(ref <ExecuteEntityAction>d__);
		return <ExecuteEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x04005EA0 RID: 24224
	private readonly FloroRanchUnitActionMsg ActionData;

	// Token: 0x04005EA1 RID: 24225
	private readonly List<FloroRanchEntityActionData> ActionDataList = new List<FloroRanchEntityActionData>();
}
