using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FAA RID: 4010
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchToyLevelUpActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A041 RID: 41025 RVA: 0x002F49EB File Offset: 0x002F2BEB
	public FloroRanchToyLevelUpActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.ToyLvUp;
	}

	// Token: 0x0600A042 RID: 41026 RVA: 0x002F4A00 File Offset: 0x002F2C00
	public override UniTask OnExecute()
	{
		FloroRanchToyLevelUpActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchToyLevelUpActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005EAB RID: 24235
	private readonly FRActionToyLvUp ActionData;
}
