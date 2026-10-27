using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EA3 RID: 7843
public class HonamiStoryItemSellValueItem : UiPanelBase
{
	// Token: 0x0600F0CE RID: 61646 RVA: 0x0039D460 File Offset: 0x0039B660
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600F0CF RID: 61647 RVA: 0x0039D49C File Offset: 0x0039B69C
	protected override void OnStart()
	{
		int activityId = HonamiStoryModel.Instance.ActivityId;
		int outCoinItemId = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(activityId).Value.OutCoinItemId;
		base.SetItemIcon(base.GetTexture(0), outCoinItemId, null, null);
	}

	// Token: 0x0600F0D0 RID: 61648 RVA: 0x0039D4EC File Offset: 0x0039B6EC
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

	// Token: 0x0200846C RID: 33900
	private enum EValue
	{
		// Token: 0x0402B19A RID: 176538
		Icon,
		// Token: 0x0402B19B RID: 176539
		Txt
	}
}
