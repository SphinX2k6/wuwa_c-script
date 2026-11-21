using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000935 RID: 2357
[NullableContext(1)]
[Nullable(0)]
internal class RegressBpTabItem : CommonTabItemBase
{
	// Token: 0x0600681D RID: 26653 RVA: 0x00208D24 File Offset: 0x00206F24
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick))
		};
	}

	// Token: 0x0600681E RID: 26654 RVA: 0x00208DD0 File Offset: 0x00206FD0
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		CommonTabData data2 = data.Data;
		string text2;
		if (data2 == null)
		{
			text2 = null;
		}
		else
		{
			CommonTabTitleData titleData = data2.GetTitleData();
			text2 = ((titleData != null) ? titleData.TextId : null);
		}
		text.ShowTextNew(text2 ?? "");
		this.UnBindRedDot();
		if (data.RedDotName != null)
		{
			this.BindRedDot(data.RedDotName.Value, data.RedDotUid.GetValueOrDefault());
		}
	}

	// Token: 0x0600681F RID: 26655 RVA: 0x00208E3F File Offset: 0x0020703F
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(4), null, uId);
		}
	}

	// Token: 0x06006820 RID: 26656 RVA: 0x00208E6E File Offset: 0x0020706E
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x06006821 RID: 26657 RVA: 0x00208E9E File Offset: 0x0020709E
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06006822 RID: 26658 RVA: 0x00208EA0 File Offset: 0x002070A0
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06006823 RID: 26659 RVA: 0x00208EB3 File Offset: 0x002070B3
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06006824 RID: 26660 RVA: 0x00208EBC File Offset: 0x002070BC
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06006825 RID: 26661 RVA: 0x00208ED5 File Offset: 0x002070D5
	public override void OnSelected(bool fireEvent)
	{
		this.SelectedCallBack(base.GridIndex);
	}

	// Token: 0x06006826 RID: 26662 RVA: 0x00208EE8 File Offset: 0x002070E8
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06006827 RID: 26663 RVA: 0x00208EF0 File Offset: 0x002070F0
	protected override void OnClear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x04004270 RID: 17008
	private ERedDotName? RedDotName;

	// Token: 0x02006C2B RID: 27691
	[NullableContext(0)]
	private class ETabItemComponents
	{
		// Token: 0x040238CA RID: 145610
		public const int Toggle = 0;

		// Token: 0x040238CB RID: 145611
		public const int TxtType = 1;

		// Token: 0x040238CC RID: 145612
		public const int PanelUp = 2;

		// Token: 0x040238CD RID: 145613
		public const int PanelFinish = 3;

		// Token: 0x040238CE RID: 145614
		public const int PanelRedDot = 4;
	}
}
