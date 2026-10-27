using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200184A RID: 6218
[NullableContext(1)]
[Nullable(0)]
public class VisionDestroyFilterLogic
{
	// Token: 0x0600B622 RID: 46626 RVA: 0x00292F48 File Offset: 0x00291148
	private static int GetDataConfigId(object data)
	{
		PhantomItemData phantomItemData = data as PhantomItemData;
		if (phantomItemData != null)
		{
			return phantomItemData.GetConfigId();
		}
		ItemViewData itemViewData = data as ItemViewData;
		if (itemViewData != null)
		{
			return itemViewData.GetConfigId();
		}
		return 0;
	}

	// Token: 0x0600B623 RID: 46627 RVA: 0x00292F78 File Offset: 0x00291178
	private static int GetDataUniqueId(object data)
	{
		PhantomItemData phantomItemData = data as PhantomItemData;
		if (phantomItemData != null)
		{
			return phantomItemData.GetUniqueId();
		}
		ItemViewData itemViewData = data as ItemViewData;
		if (itemViewData != null)
		{
			return itemViewData.GetUniqueId();
		}
		return 0;
	}

	// Token: 0x0600B624 RID: 46628 RVA: 0x00292FA8 File Offset: 0x002911A8
	public static object GetPhantomRarity(object data, Dictionary<int, string> currentSelectMap)
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(VisionDestroyFilterLogic.GetDataConfigId(data)).PhantomItem.GetValueOrDefault().Rarity;
	}

	// Token: 0x0600B625 RID: 46629 RVA: 0x00292FE0 File Offset: 0x002911E0
	public static object GetPhantomCost(object data, Dictionary<int, string> currentSelectMap)
	{
		int cost = PhantomBattleModel.Instance.GetPhantomDataBase(VisionDestroyFilterLogic.GetDataUniqueId(data)).GetCost();
		return PhantomBattleConfigDefine.COSTLIST.IndexOf(cost);
	}

	// Token: 0x0600B626 RID: 46630 RVA: 0x00293014 File Offset: 0x00291214
	public static object GetPhantomQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(VisionDestroyFilterLogic.GetDataConfigId(data)).PhantomItem.GetValueOrDefault().QualityId;
	}

	// Token: 0x0600B627 RID: 46631 RVA: 0x0029304B File Offset: 0x0029124B
	public static object GetVisionDestroyFetterGroup(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(VisionDestroyFilterLogic.GetDataUniqueId(data));
		return (phantomDataBase != null) ? phantomDataBase.GetFetterGroupId() : 0;
	}

	// Token: 0x0600B628 RID: 46632 RVA: 0x00293070 File Offset: 0x00291270
	public static object GetVisionDestroyAttribute(object data, Dictionary<int, string> currentSelectMap)
	{
		List<int> list = new List<int>(currentSelectMap.Keys);
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomDataBase(VisionDestroyFilterLogic.GetDataUniqueId(data)) as PhantomBattleData;
		bool flag = false;
		foreach (int num in list)
		{
			int visionAttribute;
			if (num >= 1000)
			{
				List<PhantomSortStruct> propData = (phantomBattleData != null) ? phantomBattleData.GetMainPropArray() : null;
				bool ifPercentage = PhantomBattleConfig.Instance.GetVisionMainPercentageAttributeSortArray().Contains(num);
				int mainAttributeKey = PhantomBattleModel.Instance.GetMainAttributeKey(num);
				int mainAttributeCost = PhantomBattleModel.Instance.GetMainAttributeCost(num);
				if (phantomBattleData.GetCost() != mainAttributeCost)
				{
					continue;
				}
				visionAttribute = VisionDestroyFilterLogic.GetVisionAttribute(propData, mainAttributeKey, ifPercentage);
			}
			else if (num >= 23)
			{
				List<PhantomSortStruct> propData2 = (phantomBattleData != null) ? phantomBattleData.GetSubPropArray() : null;
				bool ifPercentage2 = PhantomBattleConfig.Instance.GetVisionSubPercentageAttributeSortArray().Contains(num);
				int subAttributeKey = PhantomBattleModel.Instance.GetSubAttributeKey(num);
				visionAttribute = VisionDestroyFilterLogic.GetVisionAttribute(propData2, subAttributeKey, ifPercentage2);
			}
			else
			{
				List<PhantomSortStruct> propData3 = (phantomBattleData != null) ? phantomBattleData.GetMainPropArray() : null;
				bool ifPercentage3 = PhantomBattleConfig.Instance.GetVisionMainPercentageAttributeSortArray().Contains(num);
				int mainAttributeKey2 = PhantomBattleModel.Instance.GetMainAttributeKey(num);
				visionAttribute = VisionDestroyFilterLogic.GetVisionAttribute(propData3, mainAttributeKey2, ifPercentage3);
			}
			if (visionAttribute > 0)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			return list.ToArray();
		}
		return new int[1];
	}

	// Token: 0x0600B629 RID: 46633 RVA: 0x002931D8 File Offset: 0x002913D8
	private static int GetVisionAttribute([Nullable(new byte[]
	{
		2,
		1
	})] List<PhantomSortStruct> propData, int propKey, bool ifPercentage = false)
	{
		if (propData == null)
		{
			return 0;
		}
		int count = propData.Count;
		for (int i = 0; i < count; i++)
		{
			if (propData[i].PhantomPropId == propKey)
			{
				if (ifPercentage && propData[i].IfPercentage)
				{
					return propData[i].Value;
				}
				if (!ifPercentage && !propData[i].IfPercentage)
				{
					return propData[i].Value;
				}
			}
		}
		return 0;
	}

	// Token: 0x0600B62A RID: 46634 RVA: 0x0029324C File Offset: 0x0029144C
	public static object GetPhantomDeprecate(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(VisionDestroyFilterLogic.GetDataUniqueId(data));
		if (phantomDataBase != null && phantomDataBase.GetIsLock())
		{
			return 2;
		}
		return ((phantomDataBase != null && phantomDataBase.GetIsDeprecated()) > false) ? 1 : 0;
	}

	// Token: 0x04005258 RID: 21080
	private const int SUBATTRIBUTEID = 23;

	// Token: 0x04005259 RID: 21081
	private const int COSTATTRIBUTEID = 1000;
}
