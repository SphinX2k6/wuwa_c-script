using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000940 RID: 2368
public class ActivityRegressBottomPanel : UiPanelBase
{
	// Token: 0x06006897 RID: 26775 RVA: 0x0020B400 File Offset: 0x00209600
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06006898 RID: 26776 RVA: 0x0020B45C File Offset: 0x0020965C
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(2);
		this.ButtonItemInternal = new ButtonItem(item);
		this.ButtonItemInternal.SetFunction(new Action<int>(this.OnConfirmBtnClick));
	}

	// Token: 0x06006899 RID: 26777 RVA: 0x0020B49A File Offset: 0x0020969A
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.ButtonItemInternal.BindRedDot(ERedDotName.ActivityRecallTaskEntry, 0);
	}

	// Token: 0x0600689A RID: 26778 RVA: 0x0020B4B3 File Offset: 0x002096B3
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.ButtonItemInternal.UnBindRedDot();
	}

	// Token: 0x0600689B RID: 26779 RVA: 0x0020B4C6 File Offset: 0x002096C6
	private void OnConfirmBtnClick(int _)
	{
		TRegressOnClickCallback onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x0600689C RID: 26780 RVA: 0x0020B4D8 File Offset: 0x002096D8
	[NullableContext(1)]
	public void BindCallback(TRegressOnClickCallback onCallback)
	{
		this.OnClickCallback = onCallback;
	}

	// Token: 0x0600689D RID: 26781 RVA: 0x0020B4E1 File Offset: 0x002096E1
	public void UnBindCallBack()
	{
		this.OnClickCallback = null;
	}

	// Token: 0x0400428D RID: 17037
	[Nullable(2)]
	private TRegressOnClickCallback OnClickCallback;

	// Token: 0x0400428E RID: 17038
	[Nullable(2)]
	private ButtonItem ButtonItemInternal;

	// Token: 0x02006C3D RID: 27709
	private class EComponents
	{
		// Token: 0x0402392F RID: 145711
		public const int PnlDoubleTips = 0;

		// Token: 0x04023930 RID: 145712
		public const int PnlTxt = 1;

		// Token: 0x04023931 RID: 145713
		public const int BtnConfirmB2 = 2;
	}
}
