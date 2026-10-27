using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001603 RID: 5635
public class WheelTowerModeTitleItem : UiPanelBase
{
	// Token: 0x06009ED6 RID: 40662 RVA: 0x0022B788 File Offset: 0x00229988
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009ED7 RID: 40663 RVA: 0x0022B814 File Offset: 0x00229A14
	public void Refresh(bool isEndless)
	{
		base.GetTexture(0).SetUIActive(!isEndless);
		base.GetTexture(1).SetUIActive(isEndless);
		UUIText text = base.GetText(2);
		string textStringId = isEndless ? "WheelTowerModeTitle_Endless" : "WheelTowerModeTitle_Normal";
		if (text != null)
		{
			UUIItem uuiitem = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(isEndless, fcolor);
		}
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}
}
