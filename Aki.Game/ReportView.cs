using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C46 RID: 7238
public class ReportView : UiViewBase
{
	// Token: 0x06011F82 RID: 73602 RVA: 0x00548F8B File Offset: 0x0054718B
	[NullableContext(1)]
	public ReportView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011F83 RID: 73603 RVA: 0x00548F9C File Offset: 0x0054719C
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUITextInputComponent)),
			new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x06011F84 RID: 73604 RVA: 0x00549064 File Offset: 0x00547264
	protected override void OnStart()
	{
		this.TargetPlayerInfo = (this.OpenParam as ReportPersonInfo);
		this.ReportInfoList = ReportConfig.Instance.GetReportConfigList();
		if (this.ReportInfoList == null)
		{
			this.ReportInfoList = Array.Empty<ReportPlayerInfo>();
		}
		this.ReportLayout = new LoopScrollView<ReportRowView, ReportPlayerInfo>(base.GetLoopScrollViewComponent(3), (AUIBaseActor)base.GetItem(4).GetOwner(), new Func<ReportRowView>(this.CreateGrid), false);
		if (this.ReportInfoList.Count > 0)
		{
			this.ReasonId = this.ReportInfoList[0].Id;
		}
		this.ReportLayout.ReloadData(this.ReportInfoList, false);
	}

	// Token: 0x06011F85 RID: 73605 RVA: 0x0054910F File Offset: 0x0054730F
	protected override void OnBeforeDestroy()
	{
		if (this.ReportLayout != null)
		{
			this.ReportLayout.ClearGridProxies();
		}
	}

	// Token: 0x06011F86 RID: 73606 RVA: 0x00549124 File Offset: 0x00547324
	[NullableContext(1)]
	public ReportRowView CreateGrid()
	{
		ReportRowView reportRowView = new ReportRowView();
		reportRowView.SetToggleFunction(new Action<int>(this.OnToggleClick));
		return reportRowView;
	}

	// Token: 0x06011F87 RID: 73607 RVA: 0x0054913D File Offset: 0x0054733D
	private void OnClickCancelBtn()
	{
		UiManager.Instance.CloseView(EUiViewName.ReportView, null);
	}

	// Token: 0x06011F88 RID: 73608 RVA: 0x00549150 File Offset: 0x00547350
	private void OnClickConfirmBtn()
	{
		UUITextInputComponent inputText = base.GetInputText(2);
		if (this.ReasonId == -1)
		{
			ScrollingTipsController.Instance.ShowTipsById("ReportReasonNotSelect", Array.Empty<object>());
			return;
		}
		ReportController.ReportPlayerRequest(this.TargetPlayerInfo, this.ReasonId, inputText.GetText(), null);
	}

	// Token: 0x06011F89 RID: 73609 RVA: 0x0054919B File Offset: 0x0054739B
	private void OnToggleClick(int id)
	{
		this.ReasonId = id;
	}

	// Token: 0x04009CAC RID: 40108
	[Nullable(2)]
	private ReportPersonInfo TargetPlayerInfo;

	// Token: 0x04009CAD RID: 40109
	private int ReasonId = -1;

	// Token: 0x04009CAE RID: 40110
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ReportRowView, ReportPlayerInfo> ReportLayout;

	// Token: 0x04009CAF RID: 40111
	[Nullable(2)]
	private IReadOnlyList<ReportPlayerInfo> ReportInfoList;

	// Token: 0x02007F4A RID: 32586
	private static class EChildComponentType
	{
		// Token: 0x0402932D RID: 168749
		public const int CancelBtn = 0;

		// Token: 0x0402932E RID: 168750
		public const int ConfirmBtn = 1;

		// Token: 0x0402932F RID: 168751
		public const int ReportInputBox = 2;

		// Token: 0x04029330 RID: 168752
		public const int ReportContainer = 3;

		// Token: 0x04029331 RID: 168753
		public const int ReportRowTemplate = 4;
	}
}
