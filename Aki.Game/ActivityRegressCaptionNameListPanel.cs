using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000941 RID: 2369
public class ActivityRegressCaptionNameListPanel : UiPanelBase
{
	// Token: 0x0600689F RID: 26783 RVA: 0x0020B4F4 File Offset: 0x002096F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060068A0 RID: 26784 RVA: 0x0020B550 File Offset: 0x00209750
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressCaptionNameListPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressCaptionNameListPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060068A1 RID: 26785 RVA: 0x0020B593 File Offset: 0x00209793
	protected override void OnAfterShow()
	{
	}

	// Token: 0x060068A2 RID: 26786 RVA: 0x0020B595 File Offset: 0x00209795
	public void RefreshData(EActivityMainSubViewType subViewType)
	{
	}

	// Token: 0x0400428F RID: 17039
	[Nullable(2)]
	private ActivityRecallCaptionPanel CaptionPanel;

	// Token: 0x02006C3E RID: 27710
	private class EActivityRegressCaptionNameListPanelComponents
	{
		// Token: 0x04023932 RID: 145714
		public const int Caption = 0;

		// Token: 0x04023933 RID: 145715
		public const int SvList = 1;

		// Token: 0x04023934 RID: 145716
		public const int List = 2;
	}
}
