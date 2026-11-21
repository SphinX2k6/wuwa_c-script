using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA6 RID: 4006
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchResourceChangeActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A038 RID: 41016 RVA: 0x002F4873 File Offset: 0x002F2A73
	public FloroRanchResourceChangeActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ChangeData = actionData.ResourcesChange;
	}

	// Token: 0x0600A039 RID: 41017 RVA: 0x002F4888 File Offset: 0x002F2A88
	public override UniTask OnExecute()
	{
		FloroRanchResourceChangeActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchResourceChangeActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005EA6 RID: 24230
	private readonly FRUnitResourcesChangeAction ChangeData;
}
