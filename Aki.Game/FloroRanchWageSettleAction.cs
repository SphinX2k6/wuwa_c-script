using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FAB RID: 4011
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchWageSettleAction : FloroRanchAsyncActionBase
{
	// Token: 0x0600A043 RID: 41027 RVA: 0x002F4A43 File Offset: 0x002F2C43
	public FloroRanchWageSettleAction(FloroRanchWageSettleTask wageSettleData)
	{
		this.WageSettleData = wageSettleData;
	}

	// Token: 0x0600A044 RID: 41028 RVA: 0x002F4A54 File Offset: 0x002F2C54
	public override UniTask OnExecute()
	{
		FloroRanchWageSettleAction.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchWageSettleAction.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600A045 RID: 41029 RVA: 0x002F4A98 File Offset: 0x002F2C98
	private UniTask ExecuteWageSettle(FRUnitResourcesChangeAction changeData)
	{
		FloroRanchWageSettleAction.<ExecuteWageSettle>d__3 <ExecuteWageSettle>d__;
		<ExecuteWageSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteWageSettle>d__.<>4__this = this;
		<ExecuteWageSettle>d__.changeData = changeData;
		<ExecuteWageSettle>d__.<>1__state = -1;
		<ExecuteWageSettle>d__.<>t__builder.Start<FloroRanchWageSettleAction.<ExecuteWageSettle>d__3>(ref <ExecuteWageSettle>d__);
		return <ExecuteWageSettle>d__.<>t__builder.Task;
	}

	// Token: 0x04005EAC RID: 24236
	private readonly FloroRanchWageSettleTask WageSettleData;
}
