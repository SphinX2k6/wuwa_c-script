using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using FilterDefine;

// Token: 0x02001849 RID: 6217
[NullableContext(1)]
[Nullable(0)]
public class VisionDestroyFilter : CommonFilter
{
	// Token: 0x0600B61B RID: 46619 RVA: 0x00292C74 File Offset: 0x00290E74
	protected object GetPhantomItemId(object data, Dictionary<int, string> currentSelectMap)
	{
		ItemViewData itemViewData = (ItemViewData)data;
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(itemViewData.GetConfigId()).PhantomItem.Value.MonsterId;
	}

	// Token: 0x0600B61C RID: 46620 RVA: 0x00292CB4 File Offset: 0x00290EB4
	private object GetPhantomFirstMainProp(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomItemData phantomItemData = (PhantomItemData)data;
		int phantomPropId = PhantomBattleModel.Instance.GetPhantomDataBase(phantomItemData.GetUniqueId()).GetPhantomFirstMainProp().PhantomPropId;
		PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropId);
		int addType = phantomMainPropertyItemId.AddType;
		int propId = phantomMainPropertyItemId.PropId;
		return PhantomBattleModel.Instance.GetSortRuleIdByPropIndex(propId, addType);
	}

	// Token: 0x0600B61D RID: 46621 RVA: 0x00292D14 File Offset: 0x00290F14
	private object GetPhantomCost(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomItemData phantomItemData = (PhantomItemData)data;
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(phantomItemData.GetUniqueId());
		return (phantomDataBase != null) ? phantomDataBase.GetCost() : 0;
	}

	// Token: 0x0600B61E RID: 46622 RVA: 0x00292D4C File Offset: 0x00290F4C
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Phantom, new TFilterConfig(this.GetPhantomItemId));
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap = this.FilterMap;
		FilterDefine.EFilterType key = FilterDefine.EFilterType.PhantomRarity;
		TFilterConfig value;
		if ((value = VisionDestroyFilter.<>O.<0>__GetPhantomRarity) == null)
		{
			value = (VisionDestroyFilter.<>O.<0>__GetPhantomRarity = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomRarity));
		}
		filterMap.Add(key, value);
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity1, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity2, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity3, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity4, new TFilterConfig(this.GetPhantomItemId));
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap2 = this.FilterMap;
		FilterDefine.EFilterType key2 = FilterDefine.EFilterType.VisionDestroyCost;
		TFilterConfig value2;
		if ((value2 = VisionDestroyFilter.<>O.<1>__GetPhantomCost) == null)
		{
			value2 = (VisionDestroyFilter.<>O.<1>__GetPhantomCost = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomCost));
		}
		filterMap2.Add(key2, value2);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap3 = this.FilterMap;
		FilterDefine.EFilterType key3 = FilterDefine.EFilterType.VisionDestroyQuality;
		TFilterConfig value3;
		if ((value3 = VisionDestroyFilter.<>O.<2>__GetPhantomQuality) == null)
		{
			value3 = (VisionDestroyFilter.<>O.<2>__GetPhantomQuality = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomQuality));
		}
		filterMap3.Add(key3, value3);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap4 = this.FilterMap;
		FilterDefine.EFilterType key4 = FilterDefine.EFilterType.VisionDestroyFetterGroup;
		TFilterConfig value4;
		if ((value4 = VisionDestroyFilter.<>O.<3>__GetVisionDestroyFetterGroup) == null)
		{
			value4 = (VisionDestroyFilter.<>O.<3>__GetVisionDestroyFetterGroup = new TFilterConfig(VisionDestroyFilterLogic.GetVisionDestroyFetterGroup));
		}
		filterMap4.Add(key4, value4);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap5 = this.FilterMap;
		FilterDefine.EFilterType key5 = FilterDefine.EFilterType.VisionDestroyAttribute;
		TFilterConfig value5;
		if ((value5 = VisionDestroyFilter.<>O.<4>__GetVisionDestroyAttribute) == null)
		{
			value5 = (VisionDestroyFilter.<>O.<4>__GetVisionDestroyAttribute = new TFilterConfig(VisionDestroyFilterLogic.GetVisionDestroyAttribute));
		}
		filterMap5.Add(key5, value5);
		Dictionary<FilterDefine.EFilterType, TFilterConfig> filterMap6 = this.FilterMap;
		FilterDefine.EFilterType key6 = FilterDefine.EFilterType.PhantomDeprecate;
		TFilterConfig value6;
		if ((value6 = VisionDestroyFilter.<>O.<5>__GetPhantomDeprecate) == null)
		{
			value6 = (VisionDestroyFilter.<>O.<5>__GetPhantomDeprecate = new TFilterConfig(VisionDestroyFilterLogic.GetPhantomDeprecate));
		}
		filterMap6.Add(key6, value6);
		this.FilterMap.Add(FilterDefine.EFilterType.PhantomManageFirstMainProp, new TFilterConfig(this.GetPhantomFirstMainProp));
		this.FilterMap.Add(FilterDefine.EFilterType.PhantomManageCost, new TFilterConfig(this.GetPhantomCost));
	}

	// Token: 0x0600B61F RID: 46623 RVA: 0x00292EF8 File Offset: 0x002910F8
	private bool GetSelectOnState(object data)
	{
		PhantomItemData phantomItemData = (PhantomItemData)data;
		HashSet<int> phantomManageSelectSet = InventoryModel.Instance.GetPhantomManageSelectSet();
		return phantomManageSelectSet != null && phantomManageSelectSet.Contains(phantomItemData.GetUniqueId());
	}

	// Token: 0x0600B620 RID: 46624 RVA: 0x00292F27 File Offset: 0x00291127
	public override TDefaultFilter[] DefaultFilterList()
	{
		return new TDefaultFilter[]
		{
			new TDefaultFilter(this.GetSelectOnState)
		};
	}

	// Token: 0x02007E16 RID: 32278
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04029451 RID: 169041
		[Nullable(0)]
		public static TFilterConfig <0>__GetPhantomRarity;

		// Token: 0x04029452 RID: 169042
		[Nullable(0)]
		public static TFilterConfig <1>__GetPhantomCost;

		// Token: 0x04029453 RID: 169043
		[Nullable(0)]
		public static TFilterConfig <2>__GetPhantomQuality;

		// Token: 0x04029454 RID: 169044
		[Nullable(0)]
		public static TFilterConfig <3>__GetVisionDestroyFetterGroup;

		// Token: 0x04029455 RID: 169045
		[Nullable(0)]
		public static TFilterConfig <4>__GetVisionDestroyAttribute;

		// Token: 0x04029456 RID: 169046
		[Nullable(0)]
		public static TFilterConfig <5>__GetPhantomDeprecate;
	}
}
