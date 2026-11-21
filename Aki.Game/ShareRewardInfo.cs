using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ACA RID: 6858
public class ShareRewardInfo : UiPanelBase
{
	// Token: 0x06011033 RID: 69683 RVA: 0x004FF1A0 File Offset: 0x004FD3A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06011034 RID: 69684 RVA: 0x004FF1FC File Offset: 0x004FD3FC
	public void SetItemInfo(int id, int count)
	{
		base.GetText(1).SetText(count.ToString(), true);
		base.GetTexture(2).SetUIActive(false);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(id);
		if (itemConfigData == null)
		{
			return;
		}
		string icon = itemConfigData.Icon;
		base.SetTextureByPath(icon, base.GetTexture(2), null, delegate(bool _)
		{
			base.GetTexture(2).SetUIActive(true);
		});
	}

	// Token: 0x02007DA0 RID: 32160
	private enum EChildType
	{
		// Token: 0x04028ACD RID: 166605
		TxtTip,
		// Token: 0x04028ACE RID: 166606
		TxtCount,
		// Token: 0x04028ACF RID: 166607
		Icon
	}
}
