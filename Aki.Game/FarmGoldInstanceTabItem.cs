using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200071B RID: 1819
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FarmGoldInstanceTabItem : GridProxyAbstract<FarmGoldLevelData>
{
	// Token: 0x060053D9 RID: 21465 RVA: 0x001BB054 File Offset: 0x001B9254
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x001BB1E3 File Offset: 0x001B93E3
	private void OnClickItem(EToggleState toggleState)
	{
		Action<FarmGoldLevelData, int> callback = this.Callback;
		if (callback == null)
		{
			return;
		}
		callback(this.Data, base.GridIndex);
	}

	// Token: 0x060053DB RID: 21467 RVA: 0x001BB201 File Offset: 0x001B9401
	public void SetClickCallback(Action<FarmGoldLevelData, int> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x060053DC RID: 21468 RVA: 0x001BB20C File Offset: 0x001B940C
	public override void Refresh(FarmGoldLevelData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.GetText(0).SetText((gridIndex + 1).ToString(), true);
		base.GetText(1).SetText(data.GetNameText(), true);
		base.GetItem(4).SetUIActive(!data.GetIsOpen());
		base.GetItem(5).SetUIActive(data.GetRedDotState());
		this.RefreshSubTitle();
		this.SetToggleState(isSelected);
	}

	// Token: 0x060053DD RID: 21469 RVA: 0x001BB280 File Offset: 0x001B9480
	private void RefreshSubTitle()
	{
		FarmGoldLevelData data = this.Data;
		if (!data.GetIsOpen())
		{
			string unlockTimeText = data.GetUnlockTimeText();
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			text.SetText(unlockTimeText, true);
			return;
		}
		else
		{
			string subTitleText = data.GetSubTitleText();
			UUIText text2 = base.GetText(8);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(subTitleText, true);
			return;
		}
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x001BB2D4 File Offset: 0x001B94D4
	private void RefreshSubTitleValueText(bool isSelected)
	{
		if (this.Data != null)
		{
			FarmGoldLevelData data = this.Data;
			if (((data != null) ? new bool?(data.GetIsOpen()) : null) ?? true)
			{
				bool flag = this.Data.GetPoint() == 0;
				base.GetText(2).SetUIActive(!flag);
				base.GetText(9).SetUIActive(flag);
				if (flag)
				{
					base.GetText(9).SetText("0", true);
					return;
				}
				string subTitleValueText = this.Data.GetSubTitleValueText(isSelected);
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(subTitleValueText, true);
				return;
			}
		}
		base.GetText(2).SetUIActive(false);
		base.GetText(9).SetUIActive(false);
	}

	// Token: 0x060053DF RID: 21471 RVA: 0x001BB39C File Offset: 0x001B959C
	private void SetToggleState(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(7).SetToggleState(state, false, false, false);
		this.RefreshSubTitleValueText(isSelected);
	}

	// Token: 0x060053E0 RID: 21472 RVA: 0x001BB3C9 File Offset: 0x001B95C9
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x060053E1 RID: 21473 RVA: 0x001BB3D2 File Offset: 0x001B95D2
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04003AD4 RID: 15060
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<FarmGoldLevelData, int> Callback;

	// Token: 0x04003AD5 RID: 15061
	[Nullable(2)]
	private FarmGoldLevelData Data;

	// Token: 0x02006A09 RID: 27145
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022E6D RID: 142957
		NumText,
		// Token: 0x04022E6E RID: 142958
		TitleText,
		// Token: 0x04022E6F RID: 142959
		SubTitleValueText,
		// Token: 0x04022E70 RID: 142960
		FinishItem,
		// Token: 0x04022E71 RID: 142961
		LockItem,
		// Token: 0x04022E72 RID: 142962
		RedDotItem,
		// Token: 0x04022E73 RID: 142963
		TabItem,
		// Token: 0x04022E74 RID: 142964
		ToggleItem,
		// Token: 0x04022E75 RID: 142965
		SubTitleText,
		// Token: 0x04022E76 RID: 142966
		SubTitleValueZeroText
	}
}
