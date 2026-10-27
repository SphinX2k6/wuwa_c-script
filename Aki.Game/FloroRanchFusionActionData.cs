using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE5 RID: 6885
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchFusionActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC1E RID: 52254 RVA: 0x002E94CF File Offset: 0x002E76CF
	public FloroRanchFusionActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.FusionActionData = actionData.MixAction;
	}

	// Token: 0x0600CC1F RID: 52255 RVA: 0x002E94E4 File Offset: 0x002E76E4
	public override UniTask OnExecute()
	{
		FloroRanchFusionActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchFusionActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DD4 RID: 24020
	private readonly FRMixAction FusionActionData;
}
