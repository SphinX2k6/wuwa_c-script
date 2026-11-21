using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA3 RID: 4003
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEvolveUpdateActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A02D RID: 41005 RVA: 0x002F460B File Offset: 0x002F280B
	public FloroRanchEvolveUpdateActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.EvolveActionData = actionData.EvolveUpdate;
	}

	// Token: 0x0600A02E RID: 41006 RVA: 0x002F4620 File Offset: 0x002F2820
	public override UniTask OnExecute()
	{
		FloroRanchEvolveUpdateActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEvolveUpdateActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005EA2 RID: 24226
	private readonly FREvolveUpdateAction EvolveActionData;
}
