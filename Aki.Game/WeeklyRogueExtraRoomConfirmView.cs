using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022A8 RID: 8872
public class WeeklyRogueExtraRoomConfirmView : UiViewBase
{
	// Token: 0x06015E93 RID: 89747 RVA: 0x0065A5AD File Offset: 0x006587AD
	[NullableContext(1)]
	public WeeklyRogueExtraRoomConfirmView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015E94 RID: 89748 RVA: 0x0065A5B8 File Offset: 0x006587B8
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

	// Token: 0x06015E95 RID: 89749 RVA: 0x0065A690 File Offset: 0x00658890
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

	// Token: 0x06015E96 RID: 89750 RVA: 0x0065A712 File Offset: 0x00658912
	private void OnClickLeft()
	{
		Action cancelFunc = this.Data.CancelFunc;
		if (cancelFunc != null)
		{
			cancelFunc();
		}
		base.CloseMe(null);
	}

	// Token: 0x06015E97 RID: 89751 RVA: 0x0065A731 File Offset: 0x00658931
	private void OnClickRight()
	{
		Action confirmFunc = this.Data.ConfirmFunc;
		if (confirmFunc != null)
		{
			confirmFunc();
		}
		base.CloseMe(null);
	}

	// Token: 0x0400B84E RID: 47182
	[Nullable(1)]
	protected ExtraRoomTipsData Data;

	// Token: 0x02008507 RID: 34055
	private enum EComponents
	{
		// Token: 0x0402AE19 RID: 175641
		TxtDesc,
		// Token: 0x0402AE1A RID: 175642
		TxtCount,
		// Token: 0x0402AE1B RID: 175643
		PanelTips,
		// Token: 0x0402AE1C RID: 175644
		TxtTips,
		// Token: 0x0402AE1D RID: 175645
		BtnLeft,
		// Token: 0x0402AE1E RID: 175646
		BtnRight
	}
}
