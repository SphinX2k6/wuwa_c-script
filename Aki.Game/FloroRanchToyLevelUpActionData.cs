using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AEB RID: 6891
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchToyLevelUpActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC30 RID: 52272 RVA: 0x002E9857 File Offset: 0x002E7A57
	public FloroRanchToyLevelUpActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.ActionData = actionData.ToyLvUp;
	}

	// Token: 0x0600CC31 RID: 52273 RVA: 0x002E986C File Offset: 0x002E7A6C
	public override UniTask OnExecute()
	{
		FloroRanchToyLevelUpActionData.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchToyLevelUpActionData.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DDC RID: 24028
	private readonly FRActionToyLvUp ActionData;
}
