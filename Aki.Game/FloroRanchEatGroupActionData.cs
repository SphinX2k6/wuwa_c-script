using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA0 RID: 4000
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEatGroupActionData : FloroRanchActionDataBase
{
	// Token: 0x0600A01F RID: 40991 RVA: 0x002F4303 File Offset: 0x002F2503
	public FloroRanchEatGroupActionData(FloroRanchUnitActionMsg actionData) : base(actionData)
	{
		this.EatingActionGroupData = actionData.EatingGroup;
	}

	// Token: 0x0600A020 RID: 40992 RVA: 0x002F4318 File Offset: 0x002F2518
	public override UniTask OnExecute()
	{
		FloroRanchEatGroupActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchEatGroupActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600A021 RID: 40993 RVA: 0x002F435B File Offset: 0x002F255B
	protected override void OnPause()
	{
		if (this.GroupActionData != null)
		{
			this.GroupActionData.Pause();
		}
	}

	// Token: 0x0600A022 RID: 40994 RVA: 0x002F4370 File Offset: 0x002F2570
	protected override void OnResume()
	{
		if (this.GroupActionData != null)
		{
			this.GroupActionData.Resume();
		}
	}

	// Token: 0x04005E9C RID: 24220
	private readonly FRUnitEatingActionGroup EatingActionGroupData;

	// Token: 0x04005E9D RID: 24221
	private FloroRanchGroupActionData GroupActionData;
}
