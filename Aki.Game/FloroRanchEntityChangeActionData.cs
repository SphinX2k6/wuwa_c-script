using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE3 RID: 6883
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityChangeActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC18 RID: 52248 RVA: 0x002E935C File Offset: 0x002E755C
	public void InitActionData(FRUnitOperateActionGroup actionDataList)
	{
		this.ActionDataList.Clear();
		foreach (FRUnitOperateAction frunitOperateAction in actionDataList.Actions)
		{
			FloroRanchEntityActionData item = new FloroRanchEntityActionData(frunitOperateAction.OpType, frunitOperateAction.Phantom);
			this.ActionDataList.Add(item);
		}
	}

	// Token: 0x0600CC19 RID: 52249 RVA: 0x002E93CC File Offset: 0x002E75CC
	public FloroRanchEntityChangeActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData;
	}

	// Token: 0x0600CC1A RID: 52250 RVA: 0x002E93E8 File Offset: 0x002E75E8
	public override UniTask OnExecute()
	{
		FloroRanchEntityChangeActionData.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEntityChangeActionData.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC1B RID: 52251 RVA: 0x002E942C File Offset: 0x002E762C
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

	// Token: 0x04005DD1 RID: 24017
	private readonly FloroRanchUnitActionMsg ActionData;

	// Token: 0x04005DD2 RID: 24018
	private readonly List<FloroRanchEntityActionData> ActionDataList = new List<FloroRanchEntityActionData>();
}
