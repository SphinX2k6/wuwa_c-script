using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE9 RID: 6889
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSelfDefineValueActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC2C RID: 52268 RVA: 0x002E97A4 File Offset: 0x002E79A4
	public FloroRanchSelfDefineValueActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.SelfDefineValue;
	}

	// Token: 0x0600CC2D RID: 52269 RVA: 0x002E97BC File Offset: 0x002E79BC
	public override UniTask OnExecute()
	{
		FloroRanchSelfDefineValueActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchSelfDefineValueActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DDA RID: 24026
	private readonly FRActionSelfDefineValue ActionData;
}
