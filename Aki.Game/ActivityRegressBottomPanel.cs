using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200148C RID: 5260
public class ActivityRegressBottomPanel : UiPanelBase
{
	// Token: 0x06009502 RID: 38146 RVA: 0x00202498 File Offset: 0x00200698
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06009503 RID: 38147 RVA: 0x002024F4 File Offset: 0x002006F4
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(2);
		this.ButtonItemInternal = new ButtonItem(item);
		this.ButtonItemInternal.SetFunction(new Action<int>(this.OnConfirmBtnClick));
	}

	// Token: 0x06009504 RID: 38148 RVA: 0x00202532 File Offset: 0x00200732
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.ButtonItemInternal.BindRedDot(ERedDotName.ActivityRecallTaskEntry, 0);
	}

	// Token: 0x06009505 RID: 38149 RVA: 0x0020254B File Offset: 0x0020074B
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.ButtonItemInternal.UnBindRedDot();
	}

	// Token: 0x06009506 RID: 38150 RVA: 0x0020255E File Offset: 0x0020075E
	private void OnConfirmBtnClick(int _)
	{
		TRegressOnClickCallback onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x06009507 RID: 38151 RVA: 0x00202570 File Offset: 0x00200770
	[NullableContext(1)]
	public void BindCallback(TRegressOnClickCallback onCallback)
	{
		this.OnClickCallback = onCallback;
	}

	// Token: 0x06009508 RID: 38152 RVA: 0x00202579 File Offset: 0x00200779
	public void UnBindCallBack()
	{
		this.OnClickCallback = null;
	}

	// Token: 0x040041F5 RID: 16885
	[Nullable(2)]
	private TRegressOnClickCallback OnClickCallback;

	// Token: 0x040041F6 RID: 16886
	[Nullable(2)]
	private ButtonItem ButtonItemInternal;

	// Token: 0x02007AB9 RID: 31417
	private class EComponents
	{
		// Token: 0x04028615 RID: 165397
		public const int PnlDoubleTips = 0;

		// Token: 0x04028616 RID: 165398
		public const int PnlTxt = 1;

		// Token: 0x04028617 RID: 165399
		public const int BtnConfirmB2 = 2;
	}
}
