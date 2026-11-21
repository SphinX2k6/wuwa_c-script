using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA7 RID: 4007
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSacrificeActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A03A RID: 41018 RVA: 0x002F48CB File Offset: 0x002F2ACB
	public FloroRanchSacrificeActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.SacrificeData = actionData.SacrificeAction;
	}

	// Token: 0x0600A03B RID: 41019 RVA: 0x002F48E0 File Offset: 0x002F2AE0
	public override UniTask OnExecute()
	{
		FloroRanchSacrificeActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchSacrificeActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600A03C RID: 41020 RVA: 0x002F4923 File Offset: 0x002F2B23
	protected override void OnExit()
	{
		if (this.GroupActionData != null)
		{
			this.GroupActionData.Exit();
		}
	}

	// Token: 0x04005EA7 RID: 24231
	private readonly FRSacrifice SacrificeData;

	// Token: 0x04005EA8 RID: 24232
	private FloroRanchGroupActionData GroupActionData;
}
