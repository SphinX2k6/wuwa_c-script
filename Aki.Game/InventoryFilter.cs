using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;

// Token: 0x02000CF5 RID: 3317
[NullableContext(1)]
[Nullable(0)]
public class InventoryFilter : CommonFilter
{
	// Token: 0x060089D2 RID: 35282 RVA: 0x0029C8BD File Offset: 0x0029AABD
	private object GetItemQualityId(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((global::ItemViewData)data).GetQuality();
	}

	// Token: 0x060089D3 RID: 35283 RVA: 0x0029C8D0 File Offset: 0x0029AAD0
	private object GetWeaponTypeId(object data, Dictionary<int, string> currentSelectMap)
	{
		global::ItemViewData itemViewData = (global::ItemViewData)data;
		int configId = itemViewData.GetConfigId();
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(configId)) != InventoryDefine.EItemDataType.WeaponItem)
		{
			return null;
		}
		int uniqueId = itemViewData.GetUniqueId();
		WeaponItemData weaponItemData = InventoryModel.Instance.GetWeaponItemData(uniqueId);
		if (weaponItemData == null)
		{
			return null;
		}
		return weaponItemData.GetConfig().As<WeaponConf>().Value.WeaponType;
	}

	// Token: 0x060089D4 RID: 35284 RVA: 0x0029C93C File Offset: 0x0029AB3C
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

	// Token: 0x060089D5 RID: 35285 RVA: 0x0029C990 File Offset: 0x0029AB90
	private bool GetSelectOnState(object data)
	{
		global::ItemViewData itemViewData = (global::ItemViewData)data;
		bool selectOn = itemViewData.GetSelectOn();
		bool flag = itemViewData.GetItemOperationType() == ItemViewDefine.EItemOperationMode.Destruction;
		return selectOn && flag;
	}

	// Token: 0x060089D6 RID: 35286 RVA: 0x0029C9B8 File Offset: 0x0029ABB8
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.ItemQuality, new TFilterConfig(this.GetItemQualityId));
		this.FilterMap.Add(FilterDefine.EFilterType.Weapon, new TFilterConfig(this.GetWeaponTypeId));
		this.FilterMap.Add(FilterDefine.EFilterType.Phantom, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity1, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity2, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity3, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity4, new TFilterConfig(this.GetPhantomItemId));
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap = this.FilterMap;
		FilterDefine.EFilterType key = FilterDefine.EFilterType.PhantomRarity;
		TFilterConfig value;
		if ((value = InventoryFilter.<>O.<0>__GetPhantomRarity) == null)
		{
			value = (InventoryFilter.<>O.<0>__GetPhantomRarity = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomRarity));
		}
		filterMap.Add(key, value);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap2 = this.FilterMap;
		FilterDefine.EFilterType key2 = FilterDefine.EFilterType.VisionDestroyCost;
		TFilterConfig value2;
		if ((value2 = InventoryFilter.<>O.<1>__GetPhantomCost) == null)
		{
			value2 = (InventoryFilter.<>O.<1>__GetPhantomCost = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomCost));
		}
		filterMap2.Add(key2, value2);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap3 = this.FilterMap;
		FilterDefine.EFilterType key3 = FilterDefine.EFilterType.VisionDestroyQuality;
		TFilterConfig value3;
		if ((value3 = InventoryFilter.<>O.<2>__GetPhantomQuality) == null)
		{
			value3 = (InventoryFilter.<>O.<2>__GetPhantomQuality = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomQuality));
		}
		filterMap3.Add(key3, value3);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap4 = this.FilterMap;
		FilterDefine.EFilterType key4 = FilterDefine.EFilterType.VisionDestroyFetterGroup;
		TFilterConfig value4;
		if ((value4 = InventoryFilter.<>O.<3>__GetVisionDestroyFetterGroup) == null)
		{
			value4 = (InventoryFilter.<>O.<3>__GetVisionDestroyFetterGroup = new TFilterConfig(VisionDestroyFilterLogic.GetVisionDestroyFetterGroup));
		}
		filterMap4.Add(key4, value4);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap5 = this.FilterMap;
		FilterDefine.EFilterType key5 = FilterDefine.EFilterType.VisionDestroyAttribute;
		TFilterConfig value5;
		if ((value5 = InventoryFilter.<>O.<4>__GetVisionDestroyAttribute) == null)
		{
			value5 = (InventoryFilter.<>O.<4>__GetVisionDestroyAttribute = new TFilterConfig(VisionDestroyFilterLogic.GetVisionDestroyAttribute));
		}
		filterMap5.Add(key5, value5);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap6 = this.FilterMap;
		FilterDefine.EFilterType key6 = FilterDefine.EFilterType.PhantomDeprecate;
		TFilterConfig value6;
		if ((value6 = InventoryFilter.<>O.<5>__GetPhantomDeprecate) == null)
		{
			value6 = (InventoryFilter.<>O.<5>__GetPhantomDeprecate = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomDeprecate));
		}
		filterMap6.Add(key6, value6);
	}

	// Token: 0x060089D7 RID: 35287 RVA: 0x0029CB62 File Offset: 0x0029AD62
	public override TDefaultFilter[] DefaultFilterList()
	{
		return new TDefaultFilter[]
		{
			new TDefaultFilter(this.GetSelectOnState)
		};
	}

	// Token: 0x02006F9B RID: 28571
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04024776 RID: 149366
		[Nullable(0)]
		public static TFilterConfig <0>__GetPhantomRarity;

		// Token: 0x04024777 RID: 149367
		[Nullable(0)]
		public static TFilterConfig <1>__GetPhantomCost;

		// Token: 0x04024778 RID: 149368
		[Nullable(0)]
		public static TFilterConfig <2>__GetPhantomQuality;

		// Token: 0x04024779 RID: 149369
		[Nullable(0)]
		public static TFilterConfig <3>__GetVisionDestroyFetterGroup;

		// Token: 0x0402477A RID: 149370
		[Nullable(0)]
		public static TFilterConfig <4>__GetVisionDestroyAttribute;

		// Token: 0x0402477B RID: 149371
		[Nullable(0)]
		public static TFilterConfig <5>__GetPhantomDeprecate;
	}
}
