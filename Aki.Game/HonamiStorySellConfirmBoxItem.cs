using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013B2 RID: 5042
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStorySellConfirmBoxItem : GridProxyAbstract<IHonamiStoryItemSellItemInfo>
{
	// Token: 0x0600C7DD RID: 51165 RVA: 0x003B7DD4 File Offset: 0x003B5FD4
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

	// Token: 0x0600C7DE RID: 51166 RVA: 0x003B7EA0 File Offset: 0x003B60A0
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
