using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015D4 RID: 5588
public class WheelTowerSeasonRewardInfoItem : UiPanelBase
{
	// Token: 0x06009E2F RID: 40495 RVA: 0x002271AC File Offset: 0x002253AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E30 RID: 40496 RVA: 0x00227238 File Offset: 0x00225438
	[NullableContext(2)]
	public void Refresh(TItem data, string previewIcon = null)
	{
		string path;
		if (!string.IsNullOrEmpty(previewIcon))
		{
			path = previewIcon;
		}
		else
		{
			int itemId = data.ItemData.ItemId;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData == null)
			{
				return;
			}
			path = itemConfigData.Icon;
		}
		base.SetTextureByPath(path, base.GetTexture(0), null, null);
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
		base.SetTextureByPath(path, base.GetTexture(2), null, null);
	}
}
