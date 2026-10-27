using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200143D RID: 5181
public class ActivityRegressDoubleDropView : ActivityRegressMainSubViewBase
{
	// Token: 0x0600924D RID: 37453 RVA: 0x001F4C49 File Offset: 0x001F2E49
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x0600924E RID: 37454 RVA: 0x001F4C51 File Offset: 0x001F2E51
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600924F RID: 37455 RVA: 0x001F4C8C File Offset: 0x001F2E8C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressDoubleDropView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressDoubleDropView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009250 RID: 37456 RVA: 0x001F4CCF File Offset: 0x001F2ECF
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		ActivityRegressModel.Instance.MarkDoubleDropReminderShown();
		ActivityRegressModel.Instance.ActivityData.MarkDoubleDropFirstRedDotShown();
	}

	// Token: 0x040040C5 RID: 16581
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem1;

	// Token: 0x040040C6 RID: 16582
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem2;

	// Token: 0x02007A6A RID: 31338
	private class EComponents
	{
		// Token: 0x04028481 RID: 164993
		public const int ChallengeItem1Root = 0;

		// Token: 0x04028482 RID: 164994
		public const int ChallengeItem2Root = 1;
	}
}
