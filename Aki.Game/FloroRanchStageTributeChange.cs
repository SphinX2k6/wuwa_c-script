using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA9 RID: 4009
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchStageTributeChange : FloroRanchActionDataBase
{
	// Token: 0x0600A03F RID: 41023 RVA: 0x002F4993 File Offset: 0x002F2B93
	public FloroRanchStageTributeChange(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.TributeChange;
	}

	// Token: 0x0600A040 RID: 41024 RVA: 0x002F49A8 File Offset: 0x002F2BA8
	public override UniTask OnExecute()
	{
		FloroRanchStageTributeChange.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchStageTributeChange.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005EAA RID: 24234
	private readonly FRActionStageTributeChange ActionData;
}
