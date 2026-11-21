using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BF8 RID: 7160
public class RacingBetsCostItem : UiPanelBase
{
	// Token: 0x06011CC4 RID: 72900 RVA: 0x0053BB38 File Offset: 0x00539D38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06011CC5 RID: 72901 RVA: 0x0053BB94 File Offset: 0x00539D94
	public void RefreshUi(int itemId, int count)
	{
		InventoryConfig instance = InventoryConfig.Instance;
		ItemConfig itemConfig = (instance != null) ? instance.GetItemConfigData(itemId) : null;
		if (itemConfig == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(itemConfig.Icon, base.GetTexture(2), null);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(count.ToString(), true);
	}

	// Token: 0x02007EE4 RID: 32484
	private enum EComponent
	{
		// Token: 0x04029103 RID: 168195
		TipsItem,
		// Token: 0x04029104 RID: 168196
		CostText,
		// Token: 0x04029105 RID: 168197
		CostIcon
	}
}
