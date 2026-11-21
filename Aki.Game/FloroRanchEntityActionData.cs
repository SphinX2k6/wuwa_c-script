using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA1 RID: 4001
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityActionData : FloroRanchAsyncActionBase
{
	// Token: 0x0600A023 RID: 40995 RVA: 0x002F4385 File Offset: 0x002F2585
	public FloroRanchEntityActionData(FRUnitOperate type, FloroRanchPlayUnit entityData)
	{
		this.OperateType = type;
		this.EntityData = entityData;
	}

	// Token: 0x0600A024 RID: 40996 RVA: 0x002F439C File Offset: 0x002F259C
	public override UniTask OnExecute()
	{
		FloroRanchEntityActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEntityActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600A025 RID: 40997 RVA: 0x002F43E0 File Offset: 0x002F25E0
	public UniTask AddEntityAction()
	{
		FloroRanchEntityActionData.<AddEntityAction>d__4 <AddEntityAction>d__;
		<AddEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddEntityAction>d__.<>4__this = this;
		<AddEntityAction>d__.<>1__state = -1;
		<AddEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<AddEntityAction>d__4>(ref <AddEntityAction>d__);
		return <AddEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600A026 RID: 40998 RVA: 0x002F4424 File Offset: 0x002F2624
	public UniTask RemoveEntityAction()
	{
		FloroRanchEntityActionData.<RemoveEntityAction>d__5 <RemoveEntityAction>d__;
		<RemoveEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RemoveEntityAction>d__.<>4__this = this;
		<RemoveEntityAction>d__.<>1__state = -1;
		<RemoveEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<RemoveEntityAction>d__5>(ref <RemoveEntityAction>d__);
		return <RemoveEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600A027 RID: 40999 RVA: 0x002F4468 File Offset: 0x002F2668
	public UniTask ChangeEntityAction()
	{
		FloroRanchEntityActionData.<ChangeEntityAction>d__6 <ChangeEntityAction>d__;
		<ChangeEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChangeEntityAction>d__.<>4__this = this;
		<ChangeEntityAction>d__.<>1__state = -1;
		<ChangeEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<ChangeEntityAction>d__6>(ref <ChangeEntityAction>d__);
		return <ChangeEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600A028 RID: 41000 RVA: 0x002F44AC File Offset: 0x002F26AC
	public UniTask ReplaceEntityAction()
	{
		FloroRanchEntityActionData.<ReplaceEntityAction>d__7 <ReplaceEntityAction>d__;
		<ReplaceEntityAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReplaceEntityAction>d__.<>4__this = this;
		<ReplaceEntityAction>d__.<>1__state = -1;
		<ReplaceEntityAction>d__.<>t__builder.Start<FloroRanchEntityActionData.<ReplaceEntityAction>d__7>(ref <ReplaceEntityAction>d__);
		return <ReplaceEntityAction>d__.<>t__builder.Task;
	}

	// Token: 0x04005E9E RID: 24222
	public readonly FloroRanchPlayUnit EntityData;

	// Token: 0x04005E9F RID: 24223
	public readonly FRUnitOperate OperateType;
}
