using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020008F1 RID: 2289
public class ActivityRegressDoubleDropView : ActivityRegressMainSubViewBase
{
	// Token: 0x060065E2 RID: 26082 RVA: 0x001FD785 File Offset: 0x001FB985
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x060065E3 RID: 26083 RVA: 0x001FD78D File Offset: 0x001FB98D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060065E4 RID: 26084 RVA: 0x001FD7C8 File Offset: 0x001FB9C8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressDoubleDropView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressDoubleDropView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060065E5 RID: 26085 RVA: 0x001FD80B File Offset: 0x001FBA0B
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		ActivityRegressModel.Instance.MarkDoubleDropReminderShown();
		ActivityRegressModel.Instance.ActivityData.MarkDoubleDropFirstRedDotShown();
	}

	// Token: 0x0400415D RID: 16733
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem1;

	// Token: 0x0400415E RID: 16734
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem2;

	// Token: 0x02006BEE RID: 27630
	private class EComponents
	{
		// Token: 0x0402379B RID: 145307
		public const int ChallengeItem1Root = 0;

		// Token: 0x0402379C RID: 145308
		public const int ChallengeItem2Root = 1;
	}
}
