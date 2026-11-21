using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000947 RID: 2375
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTabItemPanel : CommonTabItemBase
{
	// Token: 0x060068CB RID: 26827 RVA: 0x0020BEAC File Offset: 0x0020A0AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060068CC RID: 26828 RVA: 0x0020BFD6 File Offset: 0x0020A1D6
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		base.GetItem(2).SetUIActive(false);
		base.GetSprite(0).SetUIActive(true);
	}

	// Token: 0x060068CD RID: 26829 RVA: 0x0020C00C File Offset: 0x0020A20C
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon() ?? string.Empty);
			CommonTabTitleData titleData = data.Data.GetTitleData();
			this.UpdateTitle(((titleData != null) ? titleData.TextId : null) ?? string.Empty);
			this.UnBindRedDot();
			if (data.RedDotName != null)
			{
				this.BindRedDot(data.RedDotName.Value, data.RedDotUid.GetValueOrDefault());
			}
		}
	}

	// Token: 0x060068CE RID: 26830 RVA: 0x0020C090 File Offset: 0x0020A290
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x060068CF RID: 26831 RVA: 0x0020C0A9 File Offset: 0x0020A2A9
	public override void OnSelected(bool fireEvent)
	{
		this.SelectedCallBack(base.GridIndex);
	}

	// Token: 0x060068D0 RID: 26832 RVA: 0x0020C0BC File Offset: 0x0020A2BC
	protected override void OnUpdateTabIcon(string iconPath)
	{
		if (string.IsNullOrEmpty(iconPath))
		{
			return;
		}
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
	}

	// Token: 0x060068D1 RID: 26833 RVA: 0x0020C0F8 File Offset: 0x0020A2F8
	public void UpdateTitle(string textId)
	{
		UUIText text = base.GetText(5);
		LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
	}

	// Token: 0x060068D2 RID: 26834 RVA: 0x0020C120 File Offset: 0x0020A320
	protected void RefreshTransition(bool _)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x060068D3 RID: 26835 RVA: 0x0020C14A File Offset: 0x0020A34A
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x060068D4 RID: 26836 RVA: 0x0020C15D File Offset: 0x0020A35D
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x060068D5 RID: 26837 RVA: 0x0020C166 File Offset: 0x0020A366
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060068D6 RID: 26838 RVA: 0x0020C16E File Offset: 0x0020A36E
	protected override void OnClear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060068D7 RID: 26839 RVA: 0x0020C176 File Offset: 0x0020A376
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, uId);
	}

	// Token: 0x060068D8 RID: 26840 RVA: 0x0020C198 File Offset: 0x0020A398
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0400429C RID: 17052
	protected ERedDotName? RedDotName;

	// Token: 0x02006C47 RID: 27719
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023955 RID: 145749
		public const int Icon = 0;

		// Token: 0x04023956 RID: 145750
		public const int Toggle = 1;

		// Token: 0x04023957 RID: 145751
		public const int RedDot = 2;

		// Token: 0x04023958 RID: 145752
		public const int SprIcon = 3;

		// Token: 0x04023959 RID: 145753
		public const int SprSubIcon = 4;

		// Token: 0x0402395A RID: 145754
		public const int TxtName = 5;
	}
}
