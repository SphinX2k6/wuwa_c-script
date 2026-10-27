using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;

// Token: 0x0200183D RID: 6205
public class ItemFilter : CommonFilter
{
	// Token: 0x0600B5EE RID: 46574 RVA: 0x00292464 File Offset: 0x00290664
	[NullableContext(1)]
	private object GetPhantomItemId(object data, Dictionary<int, string> currentSelectMap)
	{
		global::ItemViewData itemViewData = (global::ItemViewData)data;
		int configId = itemViewData.GetConfigId();
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(configId)) != InventoryDefine.EItemDataType.PhantomItem)
		{
			return null;
		}
		int uniqueId = itemViewData.GetUniqueId();
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
		if (phantomBattleData == null)
		{
			return null;
		}
		return phantomBattleData.GetMonsterId(false);
	}

	// Token: 0x0600B5EF RID: 46575 RVA: 0x002924B8 File Offset: 0x002906B8
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Phantom, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity1, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity2, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity3, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity4, new TFilterConfig(this.GetPhantomItemId));
	}
}
