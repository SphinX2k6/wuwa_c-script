using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200094F RID: 2383
public class ActivityRegressSignInSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x0600690D RID: 26893 RVA: 0x0020CF94 File Offset: 0x0020B194
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600690E RID: 26894 RVA: 0x0020CFF0 File Offset: 0x0020B1F0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressSignInSubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressSignInSubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600690F RID: 26895 RVA: 0x0020D033 File Offset: 0x0020B233
	protected override void OnAfterShow()
	{
		ActivityRegressModel.Instance.SetSignFirstShowTime();
	}

	// Token: 0x06006910 RID: 26896 RVA: 0x0020D040 File Offset: 0x0020B240
	protected override void OnUpdate(int subTabIndex)
	{
		this.ActivityRecallSignPanel.RefreshView();
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		base.GetItem(1).SetUIActive(grade == ERegressGrade.Normal);
		base.GetItem(2).SetUIActive(grade == ERegressGrade.Hyper);
	}

	// Token: 0x040042B2 RID: 17074
	[Nullable(2)]
	private ActivityRegressSignPanel ActivityRecallSignPanel;

	// Token: 0x02006C52 RID: 27730
	private class EComponents
	{
		// Token: 0x04023987 RID: 145799
		public const int SubPanel = 0;

		// Token: 0x04023988 RID: 145800
		public const int NormalBubble = 1;

		// Token: 0x04023989 RID: 145801
		public const int HyperBubble = 2;
	}
}
