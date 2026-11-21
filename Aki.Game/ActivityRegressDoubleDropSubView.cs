using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200096B RID: 2411
public class ActivityRegressDoubleDropSubView : ActivityRegressTaskSubViewBase
{
	// Token: 0x060069D5 RID: 27093 RVA: 0x0020FFEC File Offset: 0x0020E1EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060069D6 RID: 27094 RVA: 0x0021003C File Offset: 0x0020E23C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressDoubleDropSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressDoubleDropSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060069D7 RID: 27095 RVA: 0x0021007F File Offset: 0x0020E27F
	protected override void OnBeforeShow()
	{
		ActivityRegressModel.Instance.MarkDoubleDropReminderShown();
		ActivityRegressModel.Instance.ActivityData.MarkDoubleDropFirstRedDotShown();
	}

	// Token: 0x040042F0 RID: 17136
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem1;

	// Token: 0x040042F1 RID: 17137
	[Nullable(2)]
	private ActivityRegressDoubleDropChallengeItem DoubleDropChallengeItem2;

	// Token: 0x02006C73 RID: 27763
	private class EComponents
	{
		// Token: 0x04023A25 RID: 145957
		public const int ChallengeItem1Root = 0;

		// Token: 0x04023A26 RID: 145958
		public const int ChallengeItem2Root = 1;
	}
}
