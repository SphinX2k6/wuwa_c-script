using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA4 RID: 4004
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchFusionActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A02F RID: 41007 RVA: 0x002F4663 File Offset: 0x002F2863
	public FloroRanchFusionActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.FusionActionData = actionData.MixAction;
	}

	// Token: 0x0600A030 RID: 41008 RVA: 0x002F4678 File Offset: 0x002F2878
	public override UniTask OnExecute()
	{
		FloroRanchFusionActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchFusionActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005EA3 RID: 24227
	private readonly FRMixAction FusionActionData;
}
