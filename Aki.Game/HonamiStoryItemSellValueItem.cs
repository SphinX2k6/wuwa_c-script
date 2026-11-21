using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001365 RID: 4965
public class HonamiStoryItemSellValueItem : UiPanelBase
{
	// Token: 0x0600C4ED RID: 50413 RVA: 0x003A901C File Offset: 0x003A721C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600C4EE RID: 50414 RVA: 0x003A9058 File Offset: 0x003A7258
	protected override void OnStart()
	{
		int activityId = HonamiStoryModel.Instance.ActivityId;
		int outCoinItemId = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(activityId).Value.OutCoinItemId;
		base.SetItemIcon(base.GetTexture(0), outCoinItemId, null, null);
	}

	// Token: 0x0600C4EF RID: 50415 RVA: 0x003A90A8 File Offset: 0x003A72A8
	[NullableContext(1)]
	public void Refresh(HonamiStoryItemDataBase itemData)
	{
		int sellPrice = itemData.GetSellPrice();
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(HonamiStoryUtil.GetPriceNumFormat(sellPrice), true);
	}

	// Token: 0x020075F1 RID: 30193
	private enum EValue
	{
		// Token: 0x040264BE RID: 156862
		Icon,
		// Token: 0x040264BF RID: 156863
		Txt
	}
}
