using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001EF0 RID: 7920
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStorySellConfirmBoxItem : GridProxyAbstract<IHonamiStoryItemSellItemInfo>
{
	// Token: 0x0600F3BE RID: 62398 RVA: 0x003AC2D8 File Offset: 0x003AA4D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F3BF RID: 62399 RVA: 0x003AC3A4 File Offset: 0x003AA5A4
	public override void Refresh(IHonamiStoryItemSellItemInfo data, bool isSelected, int gridIndex)
	{
		HonamiStoryItemDataBase itemData = data.ItemData;
		string name = itemData.GetName();
		string text = ConfigMultiTextLang.GetLocalTextNew(name, null) ?? name;
		int number = data.Number;
		if (number > 1)
		{
			text = text + " x" + number.ToString();
		}
		base.GetText(2).SetText(text, true);
		base.GetText(3).SetText((number * itemData.GetSellPrice()).ToString(), true);
		UUITexture texture = base.GetTexture(1);
		base.SetItemIcon(texture, itemData.GetItemId(), null, null);
		int activityId = HonamiStoryModel.Instance.ActivityId;
		HonamiStoryActivity? honamiStoryActivityConfig = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(activityId);
		base.SetItemIcon(base.GetTexture(4), honamiStoryActivityConfig.Value.OutCoinItemId, null, null);
	}
}
