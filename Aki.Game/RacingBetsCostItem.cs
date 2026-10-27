using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200270D RID: 9997
public class RacingBetsCostItem : UiPanelBase
{
	// Token: 0x060147E2 RID: 83938 RVA: 0x0052CE1C File Offset: 0x0052B01C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x060147E3 RID: 83939 RVA: 0x0052CE78 File Offset: 0x0052B078
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

	// Token: 0x02008D5B RID: 36187
	private enum EComponent
	{
		// Token: 0x0402DDEC RID: 187884
		TipsItem,
		// Token: 0x0402DDED RID: 187885
		CostText,
		// Token: 0x0402DDEE RID: 187886
		CostIcon
	}
}
