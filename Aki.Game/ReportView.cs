using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200275B RID: 10075
public class ReportView : UiViewBase
{
	// Token: 0x06014A9F RID: 84639 RVA: 0x0053A0F7 File Offset: 0x005382F7
	[NullableContext(1)]
	public ReportView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014AA0 RID: 84640 RVA: 0x0053A108 File Offset: 0x00538308
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

	// Token: 0x06014AA1 RID: 84641 RVA: 0x0053A1D0 File Offset: 0x005383D0
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

	// Token: 0x06014AA2 RID: 84642 RVA: 0x0053A27B File Offset: 0x0053847B
	protected override void OnBeforeDestroy()
	{
		if (this.ReportLayout != null)
		{
			this.ReportLayout.ClearGridProxies();
		}
	}

	// Token: 0x06014AA3 RID: 84643 RVA: 0x0053A290 File Offset: 0x00538490
	[NullableContext(1)]
	public ReportRowView CreateGrid()
	{
		ReportRowView reportRowView = new ReportRowView();
		reportRowView.SetToggleFunction(new Action<int>(this.OnToggleClick));
		return reportRowView;
	}

	// Token: 0x06014AA4 RID: 84644 RVA: 0x0053A2A9 File Offset: 0x005384A9
	private void OnClickCancelBtn()
	{
		UiManager.Instance.CloseView(EUiViewName.ReportView, null);
	}

	// Token: 0x06014AA5 RID: 84645 RVA: 0x0053A2BC File Offset: 0x005384BC
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

	// Token: 0x06014AA6 RID: 84646 RVA: 0x0053A307 File Offset: 0x00538507
	private void OnToggleClick(int id)
	{
		this.ReasonId = id;
	}

	// Token: 0x04009B53 RID: 39763
	[Nullable(2)]
	private ReportPersonInfo TargetPlayerInfo;

	// Token: 0x04009B54 RID: 39764
	private int ReasonId = -1;

	// Token: 0x04009B55 RID: 39765
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ReportRowView, ReportPlayerInfo> ReportLayout;

	// Token: 0x04009B56 RID: 39766
	[Nullable(2)]
	private IReadOnlyList<ReportPlayerInfo> ReportInfoList;

	// Token: 0x02008DC1 RID: 36289
	private static class EChildComponentType
	{
		// Token: 0x0402E016 RID: 188438
		public const int CancelBtn = 0;

		// Token: 0x0402E017 RID: 188439
		public const int ConfirmBtn = 1;

		// Token: 0x0402E018 RID: 188440
		public const int ReportInputBox = 2;

		// Token: 0x0402E019 RID: 188441
		public const int ReportContainer = 3;

		// Token: 0x0402E01A RID: 188442
		public const int ReportRowTemplate = 4;
	}
}
