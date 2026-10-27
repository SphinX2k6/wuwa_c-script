using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE2 RID: 6882
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityActionData : FloroRanchAsyncActionBase
{
	// Token: 0x0600CC12 RID: 52242 RVA: 0x002E91F1 File Offset: 0x002E73F1
	public FloroRanchEntityActionData(FRUnitOperate type, FloroRanchPlayUnit entityData)
	{
		this.OperateType = type;
		this.EntityData = entityData;
	}

	// Token: 0x0600CC13 RID: 52243 RVA: 0x002E9208 File Offset: 0x002E7408
	public override UniTask OnExecute()
	{
		FloroRanchEntityActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEntityActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC14 RID: 52244 RVA: 0x002E924C File Offset: 0x002E744C
	public UniTask AddEntityAction()
	{
		FloroRanchEntityActionData.<AddEntityAction>d__4 <AddEntityAction>d__;
		<AddEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddEntityAction>d__.<>4__this = this;
		<AddEntityAction>d__.<>1__state = -1;
		<AddEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<AddEntityAction>d__4>(ref <AddEntityAction>d__);
		return <AddEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC15 RID: 52245 RVA: 0x002E9290 File Offset: 0x002E7490
	public UniTask RemoveEntityAction()
	{
		FloroRanchEntityActionData.<RemoveEntityAction>d__5 <RemoveEntityAction>d__;
		<RemoveEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RemoveEntityAction>d__.<>4__this = this;
		<RemoveEntityAction>d__.<>1__state = -1;
		<RemoveEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<RemoveEntityAction>d__5>(ref <RemoveEntityAction>d__);
		return <RemoveEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC16 RID: 52246 RVA: 0x002E92D4 File Offset: 0x002E74D4
	public UniTask ChangeEntityAction()
	{
		FloroRanchEntityActionData.<ChangeEntityAction>d__6 <ChangeEntityAction>d__;
		<ChangeEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChangeEntityAction>d__.<>4__this = this;
		<ChangeEntityAction>d__.<>1__state = -1;
		<ChangeEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<ChangeEntityAction>d__6>(ref <ChangeEntityAction>d__);
		return <ChangeEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC17 RID: 52247 RVA: 0x002E9318 File Offset: 0x002E7518
	public UniTask ReplaceEntityAction()
	{
		FloroRanchEntityActionData.<ReplaceEntityAction>d__7 <ReplaceEntityAction>d__;
		<ReplaceEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReplaceEntityAction>d__.<>4__this = this;
		<ReplaceEntityAction>d__.<>1__state = -1;
		<ReplaceEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<ReplaceEntityAction>d__7>(ref <ReplaceEntityAction>d__);
		return <ReplaceEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x04005DCF RID: 24015
	public readonly FloroRanchPlayUnit EntityData;

	// Token: 0x04005DD0 RID: 24016
	public readonly FRUnitOperate OperateType;
}
