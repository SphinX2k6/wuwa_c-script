using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012DB RID: 4827
[NullableContext(1)]
[Nullable(0)]
public class MapTravelSubViewButton : UiPanelBase
{
	// Token: 0x0600851C RID: 34076 RVA: 0x001C4C08 File Offset: 0x001C2E08
	public MapTravelSubViewButton(EMapTravelSubType type)
	{
		this.Type = type;
	}

	// Token: 0x0600851D RID: 34077 RVA: 0x001C4C18 File Offset: 0x001C2E18
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600851E RID: 34078 RVA: 0x001C4D63 File Offset: 0x001C2F63
	public void SetNameTextId(string textId)
	{
		base.GetText(1).ShowTextNew(textId);
	}

	// Token: 0x0600851F RID: 34079 RVA: 0x001C4D72 File Offset: 0x001C2F72
	public void SetItemDone(bool bVisible)
	{
		base.GetItem(7).SetUIActive(bVisible);
	}

	// Token: 0x06008520 RID: 34080 RVA: 0x001C4D81 File Offset: 0x001C2F81
	public void SetItemNew(bool bVisible)
	{
		base.GetItem(8).SetUIActive(bVisible);
	}

	// Token: 0x06008521 RID: 34081 RVA: 0x001C4D90 File Offset: 0x001C2F90
	public void SetProgressText(string text)
	{
		base.GetText(2).SetText(text, true);
	}

	// Token: 0x06008522 RID: 34082 RVA: 0x001C4DA0 File Offset: 0x001C2FA0
	public void SetProgressTextChangeColor(bool bChange)
	{
		UUIText text = base.GetText(2);
		UUIItem uuiitem = text;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bChange, fcolor);
	}

	// Token: 0x06008523 RID: 34083 RVA: 0x001C4DCA File Offset: 0x001C2FCA
	public void RefreshRedDot(bool bVisible)
	{
		base.GetItem(6).SetUIActive(bVisible);
	}

	// Token: 0x06008524 RID: 34084 RVA: 0x001C4DD9 File Offset: 0x001C2FD9
	public UUIItem GetIconItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x06008525 RID: 34085 RVA: 0x001C4DE2 File Offset: 0x001C2FE2
	public void SetFunction(Action<EMapTravelSubType> func)
	{
		this.ClickedFunc = func;
	}

	// Token: 0x06008526 RID: 34086 RVA: 0x001C4DEB File Offset: 0x001C2FEB
	private void OnClickedButton()
	{
		Action<EMapTravelSubType> clickedFunc = this.ClickedFunc;
		if (clickedFunc == null)
		{
			return;
		}
		clickedFunc(this.Type);
	}

	// Token: 0x04003BB1 RID: 15281
	[Nullable(2)]
	private Action<EMapTravelSubType> ClickedFunc;

	// Token: 0x04003BB2 RID: 15282
	private EMapTravelSubType Type;

	// Token: 0x020078EC RID: 30956
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027D58 RID: 163160
		public const int Button = 0;

		// Token: 0x04027D59 RID: 163161
		public const int TxtName = 1;

		// Token: 0x04027D5A RID: 163162
		public const int TxtProgress = 2;

		// Token: 0x04027D5B RID: 163163
		public const int TexBg = 3;

		// Token: 0x04027D5C RID: 163164
		public const int TexIcon1 = 4;

		// Token: 0x04027D5D RID: 163165
		public const int TexIcon2 = 5;

		// Token: 0x04027D5E RID: 163166
		public const int RedDot = 6;

		// Token: 0x04027D5F RID: 163167
		public const int ItemDone = 7;

		// Token: 0x04027D60 RID: 163168
		public const int ItemNew = 8;
	}
}
