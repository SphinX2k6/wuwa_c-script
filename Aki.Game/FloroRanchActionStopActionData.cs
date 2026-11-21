using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000F99 RID: 3993
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchActionStopActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A004 RID: 40964 RVA: 0x002F3DE1 File Offset: 0x002F1FE1
	public FloroRanchActionStopActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.ActionStop;
	}

	// Token: 0x0600A005 RID: 40965 RVA: 0x002F3DF8 File Offset: 0x002F1FF8
	public override UniTask OnExecute()
	{
		FloroRanchActionStopActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchActionStopActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005E92 RID: 24210
	private readonly FRActionStop ActionData;
}
