using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001481 RID: 5249
[NullableContext(1)]
[Nullable(0)]
internal class RegressBpTabItem : CommonTabItemBase
{
	// Token: 0x06009488 RID: 38024 RVA: 0x001FFDC0 File Offset: 0x001FDFC0
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

	// Token: 0x06009489 RID: 38025 RVA: 0x001FFE6C File Offset: 0x001FE06C
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

	// Token: 0x0600948A RID: 38026 RVA: 0x001FFEDB File Offset: 0x001FE0DB
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(4), null, uId);
		}
	}

	// Token: 0x0600948B RID: 38027 RVA: 0x001FFF0A File Offset: 0x001FE10A
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600948C RID: 38028 RVA: 0x001FFF3A File Offset: 0x001FE13A
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600948D RID: 38029 RVA: 0x001FFF3C File Offset: 0x001FE13C
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600948E RID: 38030 RVA: 0x001FFF4F File Offset: 0x001FE14F
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600948F RID: 38031 RVA: 0x001FFF58 File Offset: 0x001FE158
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06009490 RID: 38032 RVA: 0x001FFF71 File Offset: 0x001FE171
	public override void OnSelected(bool fireEvent)
	{
		this.SelectedCallBack(base.GridIndex);
	}

	// Token: 0x06009491 RID: 38033 RVA: 0x001FFF84 File Offset: 0x001FE184
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06009492 RID: 38034 RVA: 0x001FFF8C File Offset: 0x001FE18C
	protected override void OnClear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x040041D8 RID: 16856
	private ERedDotName? RedDotName;

	// Token: 0x02007AA7 RID: 31399
	[NullableContext(0)]
	private class ETabItemComponents
	{
		// Token: 0x040285B0 RID: 165296
		public const int Toggle = 0;

		// Token: 0x040285B1 RID: 165297
		public const int TxtType = 1;

		// Token: 0x040285B2 RID: 165298
		public const int PanelUp = 2;

		// Token: 0x040285B3 RID: 165299
		public const int PanelFinish = 3;

		// Token: 0x040285B4 RID: 165300
		public const int PanelRedDot = 4;
	}
}
