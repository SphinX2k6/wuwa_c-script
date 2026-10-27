using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AEC RID: 6892
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchWageSettleAction : FloroRanchAsyncActionBase
{
	// Token: 0x0600CC32 RID: 52274 RVA: 0x002E98AF File Offset: 0x002E7AAF
	public FloroRanchWageSettleAction(FloroRanchWageSettleTask wageSettleData)
	{
		this.WageSettleData = wageSettleData;
	}

	// Token: 0x0600CC33 RID: 52275 RVA: 0x002E98C0 File Offset: 0x002E7AC0
	public override UniTask OnExecute()
	{
		FloroRanchWageSettleAction.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchWageSettleAction.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC34 RID: 52276 RVA: 0x002E9904 File Offset: 0x002E7B04
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

	// Token: 0x04005DDD RID: 24029
	private readonly FloroRanchWageSettleTask WageSettleData;
}
