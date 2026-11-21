using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000F9B RID: 3995
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchBuffUpdateActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A015 RID: 40981 RVA: 0x002F414F File Offset: 0x002F234F
	public FloroRanchBuffUpdateActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.BuffData = actionData.BuffOpGroup;
	}

	// Token: 0x0600A016 RID: 40982 RVA: 0x002F4164 File Offset: 0x002F2364
	public override UniTask OnExecute()
	{
		FloroRanchBuffUpdateActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchBuffUpdateActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005E97 RID: 24215
	private readonly FRUnitBuffOperateActionGroup BuffData;
}
