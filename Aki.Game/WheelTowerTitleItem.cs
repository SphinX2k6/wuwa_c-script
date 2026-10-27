using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200160A RID: 5642
public class WheelTowerTitleItem : UiPanelBase
{
	// Token: 0x06009EEA RID: 40682 RVA: 0x0022BF98 File Offset: 0x0022A198
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009EEB RID: 40683 RVA: 0x0022C064 File Offset: 0x0022A264
	protected override void OnBeforeShow()
	{
		object openParam = this.OpenParam;
		bool flag;
		bool flag2;
		if (openParam is bool)
		{
			flag = (bool)openParam;
			flag2 = true;
		}
		else
		{
			flag2 = false;
		}
		bool flag3 = flag2 && flag;
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetUIActive(flag3);
		}
		UUITexture texture2 = base.GetTexture(1);
		if (texture2 != null)
		{
			texture2.SetUIActive(!flag3);
		}
		string textStringId = flag3 ? "WheelTowerModeTitle_Endless" : "WheelTowerModeTitle_Normal";
		UUIText text = base.GetText(2);
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag3;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUITexture texture3 = base.GetTexture(3);
		if (texture3 != null)
		{
			texture3.SetUIActive(flag3);
		}
		UUITexture texture4 = base.GetTexture(4);
		if (texture4 == null)
		{
			return;
		}
		texture4.SetUIActive(!flag3);
	}
}
