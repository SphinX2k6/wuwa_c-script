using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014B7 RID: 5303
public class ActivityRegressDoubleDropSubView : ActivityRegressTaskSubViewBase
{
	// Token: 0x06009640 RID: 38464 RVA: 0x00207080 File Offset: 0x00205280
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06009641 RID: 38465 RVA: 0x002070D0 File Offset: 0x002052D0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressDoubleDropSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressDoubleDropSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009642 RID: 38466 RVA: 0x00207113 File Offset: 0x00205313
	protected override void OnBeforeShow()
	{
		ActivityRegressModel.Instance.MarkDoubleDropReminderShown();
		ActivityRegressModel.Instance.ActivityData.MarkDoubleDropFirstRedDotShown();
	}

	// Token: 0x04004258 RID: 16984
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem1;

	// Token: 0x04004259 RID: 16985
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem2;

	// Token: 0x02007AEF RID: 31471
	private class EComponents
	{
		// Token: 0x0402870B RID: 165643
		public const int ChallengeItem1Root = 0;

		// Token: 0x0402870C RID: 165644
		public const int ChallengeItem2Root = 1;
	}
}
