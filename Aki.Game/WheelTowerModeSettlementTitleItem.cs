using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001604 RID: 5636
public class WheelTowerModeSettlementTitleItem : UiPanelBase
{
	// Token: 0x06009ED9 RID: 40665 RVA: 0x0022B888 File Offset: 0x00229A88
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009EDA RID: 40666 RVA: 0x0022B934 File Offset: 0x00229B34
	public void Refresh(bool isEndless)
	{
		base.GetTexture(0).SetUIActive(!isEndless);
		base.GetTexture(1).SetUIActive(isEndless);
		UUITexture texture = base.GetTexture(2);
		UUIText text = base.GetText(3);
		string textStringId = isEndless ? "WheelTowerModeTitle_Endless" : "WheelTowerModeTitle_Normal";
		if (texture != null)
		{
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isEndless, fcolor);
		}
		if (text != null)
		{
			UUIItem uuiitem2 = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem2.SetChangeColor(isEndless, fcolor);
		}
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}
}
