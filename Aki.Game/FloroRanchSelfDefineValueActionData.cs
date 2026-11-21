using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA8 RID: 4008
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSelfDefineValueActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A03D RID: 41021 RVA: 0x002F4938 File Offset: 0x002F2B38
	public FloroRanchSelfDefineValueActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.SelfDefineValue;
	}

	// Token: 0x0600A03E RID: 41022 RVA: 0x002F4950 File Offset: 0x002F2B50
	public override UniTask OnExecute()
	{
		FloroRanchSelfDefineValueActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchSelfDefineValueActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005EA9 RID: 24233
	private readonly FRActionSelfDefineValue ActionData;
}
