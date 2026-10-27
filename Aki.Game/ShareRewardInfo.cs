using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025DF RID: 9695
public class ShareRewardInfo : UiPanelBase
{
	// Token: 0x06013B51 RID: 80721 RVA: 0x004F0470 File Offset: 0x004EE670
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06013B52 RID: 80722 RVA: 0x004F04CC File Offset: 0x004EE6CC
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

	// Token: 0x02008C17 RID: 35863
	private enum EChildType
	{
		// Token: 0x0402D7B5 RID: 186293
		TxtTip,
		// Token: 0x0402D7B6 RID: 186294
		TxtCount,
		// Token: 0x0402D7B7 RID: 186295
		Icon
	}
}
