using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001ADD RID: 6877
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchChangePointActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC06 RID: 52230 RVA: 0x002E9013 File Offset: 0x002E7213
	public FloroRanchChangePointActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.ChangePointAction;
	}

	// Token: 0x0600CC07 RID: 52231 RVA: 0x002E9028 File Offset: 0x002E7228
	public override UniTask OnExecute()
	{
		FloroRanchChangePointActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchChangePointActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DC9 RID: 24009
	private readonly FRChangePointAction ActionData;
}
