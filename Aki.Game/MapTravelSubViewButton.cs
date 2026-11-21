using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200078F RID: 1935
[NullableContext(1)]
[Nullable(0)]
public class MapTravelSubViewButton : UiPanelBase
{
	// Token: 0x060058B7 RID: 22711 RVA: 0x001CDA64 File Offset: 0x001CBC64
	public MapTravelSubViewButton(EMapTravelSubType type)
	{
		this.Type = type;
	}

	// Token: 0x060058B8 RID: 22712 RVA: 0x001CDA74 File Offset: 0x001CBC74
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

	// Token: 0x060058B9 RID: 22713 RVA: 0x001CDBBF File Offset: 0x001CBDBF
	public void SetNameTextId(string textId)
	{
		base.GetText(1).ShowTextNew(textId);
	}

	// Token: 0x060058BA RID: 22714 RVA: 0x001CDBCE File Offset: 0x001CBDCE
	public void SetItemDone(bool bVisible)
	{
		base.GetItem(7).SetUIActive(bVisible);
	}

	// Token: 0x060058BB RID: 22715 RVA: 0x001CDBDD File Offset: 0x001CBDDD
	public void SetItemNew(bool bVisible)
	{
		base.GetItem(8).SetUIActive(bVisible);
	}

	// Token: 0x060058BC RID: 22716 RVA: 0x001CDBEC File Offset: 0x001CBDEC
	public void SetProgressText(string text)
	{
		base.GetText(2).SetText(text, true);
	}

	// Token: 0x060058BD RID: 22717 RVA: 0x001CDBFC File Offset: 0x001CBDFC
	public void SetProgressTextChangeColor(bool bChange)
	{
		UUIText text = base.GetText(2);
		UUIItem uuiitem = text;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bChange, fcolor);
	}

	// Token: 0x060058BE RID: 22718 RVA: 0x001CDC26 File Offset: 0x001CBE26
	public void RefreshRedDot(bool bVisible)
	{
		base.GetItem(6).SetUIActive(bVisible);
	}

	// Token: 0x060058BF RID: 22719 RVA: 0x001CDC35 File Offset: 0x001CBE35
	public UUIItem GetIconItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x060058C0 RID: 22720 RVA: 0x001CDC3E File Offset: 0x001CBE3E
	public void SetFunction(Action<EMapTravelSubType> func)
	{
		this.ClickedFunc = func;
	}

	// Token: 0x060058C1 RID: 22721 RVA: 0x001CDC47 File Offset: 0x001CBE47
	private void OnClickedButton()
	{
		Action<EMapTravelSubType> clickedFunc = this.ClickedFunc;
		if (clickedFunc == null)
		{
			return;
		}
		clickedFunc(this.Type);
	}

	// Token: 0x04003C49 RID: 15433
	[Nullable(2)]
	private Action<EMapTravelSubType> ClickedFunc;

	// Token: 0x04003C4A RID: 15434
	private EMapTravelSubType Type;

	// Token: 0x02006A76 RID: 27254
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04023086 RID: 143494
		public const int Button = 0;

		// Token: 0x04023087 RID: 143495
		public const int TxtName = 1;

		// Token: 0x04023088 RID: 143496
		public const int TxtProgress = 2;

		// Token: 0x04023089 RID: 143497
		public const int TexBg = 3;

		// Token: 0x0402308A RID: 143498
		public const int TexIcon1 = 4;

		// Token: 0x0402308B RID: 143499
		public const int TexIcon2 = 5;

		// Token: 0x0402308C RID: 143500
		public const int RedDot = 6;

		// Token: 0x0402308D RID: 143501
		public const int ItemDone = 7;

		// Token: 0x0402308E RID: 143502
		public const int ItemNew = 8;
	}
}
