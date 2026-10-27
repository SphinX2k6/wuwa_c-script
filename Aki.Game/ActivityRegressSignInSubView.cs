using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200149B RID: 5275
public class ActivityRegressSignInSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x06009578 RID: 38264 RVA: 0x0020402C File Offset: 0x0020222C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06009579 RID: 38265 RVA: 0x00204088 File Offset: 0x00202288
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressSignInSubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressSignInSubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600957A RID: 38266 RVA: 0x002040CB File Offset: 0x002022CB
	protected override void OnAfterShow()
	{
		ActivityRegressModel.Instance.SetSignFirstShowTime();
	}

	// Token: 0x0600957B RID: 38267 RVA: 0x002040D8 File Offset: 0x002022D8
	protected override void OnUpdate(int subTabIndex)
	{
		this.ActivityRecallSignPanel.RefreshView();
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		base.GetItem(1).SetUIActive(grade == ERegressGrade.Normal);
		base.GetItem(2).SetUIActive(grade == ERegressGrade.Hyper);
	}

	// Token: 0x0400421A RID: 16922
	[Nullable(2)]
	private ActivityRegressSignPanel ActivityRecallSignPanel;

	// Token: 0x02007ACE RID: 31438
	private class EComponents
	{
		// Token: 0x0402866D RID: 165485
		public const int SubPanel = 0;

		// Token: 0x0402866E RID: 165486
		public const int NormalBubble = 1;

		// Token: 0x0402866F RID: 165487
		public const int HyperBubble = 2;
	}
}
