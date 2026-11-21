using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000F9F RID: 3999
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEatActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A01D RID: 40989 RVA: 0x002F42AB File Offset: 0x002F24AB
	public FloroRanchEatActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionDataList = actionData.UnitOpGroup;
	}

	// Token: 0x0600A01E RID: 40990 RVA: 0x002F42C0 File Offset: 0x002F24C0
	public override UniTask OnExecute()
	{
		FloroRanchEatActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEatActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005E9B RID: 24219
	private readonly FRUnitOperateActionGroup ActionDataList;
}
