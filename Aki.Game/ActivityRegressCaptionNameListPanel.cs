using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200148D RID: 5261
public class ActivityRegressCaptionNameListPanel : UiPanelBase
{
	// Token: 0x0600950A RID: 38154 RVA: 0x0020258C File Offset: 0x0020078C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600950B RID: 38155 RVA: 0x002025E8 File Offset: 0x002007E8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressCaptionNameListPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressCaptionNameListPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600950C RID: 38156 RVA: 0x0020262B File Offset: 0x0020082B
	protected override void OnAfterShow()
	{
	}

	// Token: 0x0600950D RID: 38157 RVA: 0x0020262D File Offset: 0x0020082D
	public void RefreshData(EActivityMainSubViewType subViewType)
	{
	}

	// Token: 0x040041F7 RID: 16887
	[Nullable(2)]
	private ActivityRecallCaptionPanel CaptionPanel;

	// Token: 0x02007ABA RID: 31418
	private class EActivityRegressCaptionNameListPanelComponents
	{
		// Token: 0x04028618 RID: 165400
		public const int Caption = 0;

		// Token: 0x04028619 RID: 165401
		public const int SvList = 1;

		// Token: 0x0402861A RID: 165402
		public const int List = 2;
	}
}
