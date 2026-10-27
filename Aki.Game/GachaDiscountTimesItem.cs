using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C7F RID: 7295
public class GachaDiscountTimesItem : UiPanelBase
{
	// Token: 0x0600DBFC RID: 56316 RVA: 0x0033378C File Offset: 0x0033198C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600DBFD RID: 56317 RVA: 0x00333838 File Offset: 0x00331A38
	[NullableContext(1)]
	public void Refresh(GachaDiscountInfo info)
	{
		int usedTimes = info.UsedTimes;
		int limitTimes = info.LimitTimes;
		int num = Math.Max(0, limitTimes - usedTimes);
		bool flag = num > 0;
		int num2 = (info.Times > 0) ? info.Times : 1;
		int num3 = num / num2;
		base.GetSprite(1).SetUIActive(flag);
		base.GetSprite(0).SetUIActive(!flag);
		UUIText text = base.GetText(2);
		UUIText text2 = base.GetText(3);
		text.useChangeColor = flag;
		text2.useChangeColor = flag;
		string text3 = (info.Times == 1) ? "DiscountCount_1" : ((info.Times == 10) ? "DiscountCount_2" : "");
		if (!string.IsNullOrEmpty(text3))
		{
			LguiUtil.Instance.SetLocalTextNew(text, text3, Array.Empty<object>());
		}
		else
		{
			text.SetText("", true);
		}
		LguiUtil.Instance.SetLocalTextNew(text2, "DiscountCount_Num", new <>z__ReadOnlySingleElementList<object>(num3.ToString()));
	}

	// Token: 0x02008242 RID: 33346
	private enum EComponent
	{
		// Token: 0x0402A7F8 RID: 174072
		SpritePointDisable,
		// Token: 0x0402A7F9 RID: 174073
		SpritePointActive,
		// Token: 0x0402A7FA RID: 174074
		TextDescription,
		// Token: 0x0402A7FB RID: 174075
		TextValue
	}
}
