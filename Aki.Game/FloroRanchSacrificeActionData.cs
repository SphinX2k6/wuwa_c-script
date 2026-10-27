using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE8 RID: 6888
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSacrificeActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC29 RID: 52265 RVA: 0x002E9737 File Offset: 0x002E7937
	public FloroRanchSacrificeActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.SacrificeData = actionData.SacrificeAction;
	}

	// Token: 0x0600CC2A RID: 52266 RVA: 0x002E974C File Offset: 0x002E794C
	public override UniTask OnExecute()
	{
		FloroRanchSacrificeActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchSacrificeActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC2B RID: 52267 RVA: 0x002E978F File Offset: 0x002E798F
	protected override void OnExit()
	{
		if (this.GroupActionData != null)
		{
			this.GroupActionData.Exit();
		}
	}

	// Token: 0x04005DD8 RID: 24024
	private readonly FRSacrifice SacrificeData;

	// Token: 0x04005DD9 RID: 24025
	private FloroRanchGroupActionData GroupActionData;
}
