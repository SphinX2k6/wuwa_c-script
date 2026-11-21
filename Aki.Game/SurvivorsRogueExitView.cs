using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020F1 RID: 8433
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueExitView : UiViewBase
{
	// Token: 0x06014AD8 RID: 84696 RVA: 0x00606506 File Offset: 0x00604706
	public SurvivorsRogueExitView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014AD9 RID: 84697 RVA: 0x00606510 File Offset: 0x00604710
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnSettle)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnExit))
		};
	}

	// Token: 0x06014ADA RID: 84698 RVA: 0x006065E8 File Offset: 0x006047E8
	protected override void OnStart()
	{
		ISurvivorsExitViewParams params_ = this.OpenParam as ISurvivorsExitViewParams;
		this.RefreshInfo(params_);
	}

	// Token: 0x06014ADB RID: 84699 RVA: 0x00606608 File Offset: 0x00604808
	private void RefreshInfo(ISurvivorsExitViewParams params_)
	{
		bool isExternal = params_.IsExternal;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "SurvivorsExitPopup_confirmText", new <>z__ReadOnlyArray<object>(new object[]
		{
			params_.Batch,
			params_.MaxBatch
		}));
		UUIText text = base.GetText(3);
		UUIText text2 = base.GetText(4);
		UUIText text3 = base.GetText(5);
		if (isExternal)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "SurvivorsExit_ExternalTitle", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(text2, "SurvivorsExit_ExternalTips", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(text3, "SurvivorsExit_ExternalBut2", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "SurvivorsExit_InternalTitle", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text2, "SurvivorsExit_InternalTips", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text3, "SurvivorsExit_InternalBut2", Array.Empty<object>());
	}

	// Token: 0x06014ADC RID: 84700 RVA: 0x006066F4 File Offset: 0x006048F4
	private void OnClickBtnSettle()
	{
		ISurvivorsExitViewParams survivorsExitViewParams = this.OpenParam as ISurvivorsExitViewParams;
		SurvivorsRogueController.Instance.RequestInstSettle(survivorsExitViewParams.IsExternal);
		base.CloseMe(null);
	}

	// Token: 0x06014ADD RID: 84701 RVA: 0x00606724 File Offset: 0x00604924
	private void OnClickBtnExit()
	{
		if (!(this.OpenParam as ISurvivorsExitViewParams).IsExternal)
		{
			SurvivorsRogueController.Instance.LeaveRogueInstance();
		}
		else
		{
			SurvivorsRogueController.Instance.RequestEnterInstByLevelInfo();
		}
		base.CloseMe(null);
	}
}
