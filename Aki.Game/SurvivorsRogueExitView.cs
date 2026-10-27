using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B75 RID: 11125
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueExitView : UiViewBase
{
	// Token: 0x060170A7 RID: 94375 RVA: 0x005D9996 File Offset: 0x005D7B96
	public SurvivorsRogueExitView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060170A8 RID: 94376 RVA: 0x005D99A0 File Offset: 0x005D7BA0
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

	// Token: 0x060170A9 RID: 94377 RVA: 0x005D9A78 File Offset: 0x005D7C78
	protected override void OnStart()
	{
		ISurvivorsExitViewParams params_ = this.OpenParam as ISurvivorsExitViewParams;
		this.RefreshInfo(params_);
	}

	// Token: 0x060170AA RID: 94378 RVA: 0x005D9A98 File Offset: 0x005D7C98
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

	// Token: 0x060170AB RID: 94379 RVA: 0x005D9B84 File Offset: 0x005D7D84
	private void OnClickBtnSettle()
	{
		ISurvivorsExitViewParams survivorsExitViewParams = this.OpenParam as ISurvivorsExitViewParams;
		SurvivorsRogueController.Instance.RequestInstSettle(survivorsExitViewParams.IsExternal);
		base.CloseMe(null);
	}

	// Token: 0x060170AC RID: 94380 RVA: 0x005D9BB4 File Offset: 0x005D7DB4
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
