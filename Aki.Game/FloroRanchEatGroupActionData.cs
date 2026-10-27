using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE1 RID: 6881
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEatGroupActionData : FloroRanchActionDataBase
{
	// Token: 0x0600CC0E RID: 52238 RVA: 0x002E916F File Offset: 0x002E736F
	public FloroRanchEatGroupActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.EatingActionGroupData = actionData.EatingGroup;
	}

	// Token: 0x0600CC0F RID: 52239 RVA: 0x002E9184 File Offset: 0x002E7384
	public override UniTask OnExecute()
	{
		FloroRanchEatGroupActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEatGroupActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC10 RID: 52240 RVA: 0x002E91C7 File Offset: 0x002E73C7
	protected override void OnPause()
	{
		if (this.GroupActionData != null)
		{
			this.GroupActionData.Pause();
		}
	}

	// Token: 0x0600CC11 RID: 52241 RVA: 0x002E91DC File Offset: 0x002E73DC
	protected override void OnResume()
	{
		if (this.GroupActionData != null)
		{
			this.GroupActionData.Resume();
		}
	}

	// Token: 0x04005DCD RID: 24013
	private readonly FRUnitEatingActionGroup EatingActionGroupData;

	// Token: 0x04005DCE RID: 24014
	private FloroRanchGroupActionData GroupActionData;
}
