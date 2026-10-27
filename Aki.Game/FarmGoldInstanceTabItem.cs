using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001267 RID: 4711
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FarmGoldInstanceTabItem : GridProxyAbstract<FarmGoldLevelData>
{
	// Token: 0x06008042 RID: 32834 RVA: 0x001B2384 File Offset: 0x001B0584
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

	// Token: 0x06008043 RID: 32835 RVA: 0x001B2513 File Offset: 0x001B0713
	private void OnClickItem(EToggleState toggleState)
	{
		Action<FarmGoldLevelData, int> callback = this.Callback;
		if (callback == null)
		{
			return;
		}
		callback(this.Data, base.GridIndex);
	}

	// Token: 0x06008044 RID: 32836 RVA: 0x001B2531 File Offset: 0x001B0731
	public void SetClickCallback(Action<FarmGoldLevelData, int> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x06008045 RID: 32837 RVA: 0x001B253C File Offset: 0x001B073C
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

	// Token: 0x06008046 RID: 32838 RVA: 0x001B25B0 File Offset: 0x001B07B0
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

	// Token: 0x06008047 RID: 32839 RVA: 0x001B2604 File Offset: 0x001B0804
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

	// Token: 0x06008048 RID: 32840 RVA: 0x001B26CC File Offset: 0x001B08CC
	private void SetToggleState(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(7).SetToggleState(state, false, false, false);
		this.RefreshSubTitleValueText(isSelected);
	}

	// Token: 0x06008049 RID: 32841 RVA: 0x001B26F9 File Offset: 0x001B08F9
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600804A RID: 32842 RVA: 0x001B2702 File Offset: 0x001B0902
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04003A3C RID: 14908
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<FarmGoldLevelData, int> Callback;

	// Token: 0x04003A3D RID: 14909
	[Nullable(2)]
	private FarmGoldLevelData Data;

	// Token: 0x0200787E RID: 30846
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027B3C RID: 162620
		NumText,
		// Token: 0x04027B3D RID: 162621
		TitleText,
		// Token: 0x04027B3E RID: 162622
		SubTitleValueText,
		// Token: 0x04027B3F RID: 162623
		FinishItem,
		// Token: 0x04027B40 RID: 162624
		LockItem,
		// Token: 0x04027B41 RID: 162625
		RedDotItem,
		// Token: 0x04027B42 RID: 162626
		TabItem,
		// Token: 0x04027B43 RID: 162627
		ToggleItem,
		// Token: 0x04027B44 RID: 162628
		SubTitleText,
		// Token: 0x04027B45 RID: 162629
		SubTitleValueZeroText
	}
}
