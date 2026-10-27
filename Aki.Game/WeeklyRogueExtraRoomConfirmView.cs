using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D4E RID: 11598
public class WeeklyRogueExtraRoomConfirmView : UiViewBase
{
	// Token: 0x060185F1 RID: 99825 RVA: 0x0063459D File Offset: 0x0063279D
	[NullableContext(1)]
	public WeeklyRogueExtraRoomConfirmView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060185F2 RID: 99826 RVA: 0x006345A8 File Offset: 0x006327A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickLeft)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickRight))
		};
	}

	// Token: 0x060185F3 RID: 99827 RVA: 0x00634680 File Offset: 0x00632880
	protected override void OnStart()
	{
		ExtraRoomTipsData extraRoomTipsData = this.OpenParam as ExtraRoomTipsData;
		if (extraRoomTipsData == null)
		{
			return;
		}
		this.Data = extraRoomTipsData;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WeRogueScorePopupText", new <>z__ReadOnlyArray<object>(new object[]
		{
			extraRoomTipsData.CurScore,
			extraRoomTipsData.MaxScore
		}));
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClickLeft));
	}

	// Token: 0x060185F4 RID: 99828 RVA: 0x00634702 File Offset: 0x00632902
	private void OnClickLeft()
	{
		Action cancelFunc = this.Data.CancelFunc;
		if (cancelFunc != null)
		{
			cancelFunc();
		}
		base.CloseMe(null);
	}

	// Token: 0x060185F5 RID: 99829 RVA: 0x00634721 File Offset: 0x00632921
	private void OnClickRight()
	{
		Action confirmFunc = this.Data.ConfirmFunc;
		if (confirmFunc != null)
		{
			confirmFunc();
		}
		base.CloseMe(null);
	}

	// Token: 0x0400B4D9 RID: 46297
	[Nullable(1)]
	protected ExtraRoomTipsData Data;

	// Token: 0x020092E0 RID: 37600
	private enum EComponents
	{
		// Token: 0x0402F791 RID: 194449
		TxtDesc,
		// Token: 0x0402F792 RID: 194450
		TxtCount,
		// Token: 0x0402F793 RID: 194451
		PanelTips,
		// Token: 0x0402F794 RID: 194452
		TxtTips,
		// Token: 0x0402F795 RID: 194453
		BtnLeft,
		// Token: 0x0402F796 RID: 194454
		BtnRight
	}
}
