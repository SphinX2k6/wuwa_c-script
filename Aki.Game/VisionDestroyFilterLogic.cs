using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D03 RID: 3331
[NullableContext(1)]
[Nullable(0)]
public class VisionDestroyFilterLogic
{
	// Token: 0x06008A0B RID: 35339 RVA: 0x0029D638 File Offset: 0x0029B838
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

	// Token: 0x06008A0C RID: 35340 RVA: 0x0029D668 File Offset: 0x0029B868
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

	// Token: 0x06008A0D RID: 35341 RVA: 0x0029D698 File Offset: 0x0029B898
	public static object GetPhantomRarity(object data, Dictionary<int, string> currentSelectMap)
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(VisionDestroyFilterLogic.GetDataConfigId(data)).PhantomItem.GetValueOrDefault().Rarity;
	}

	// Token: 0x06008A0E RID: 35342 RVA: 0x0029D6D0 File Offset: 0x0029B8D0
	public static object GetPhantomCost(object data, Dictionary<int, string> currentSelectMap)
	{
		int cost = PhantomBattleModel.Instance.GetPhantomDataBase(VisionDestroyFilterLogic.GetDataUniqueId(data)).GetCost();
		return PhantomBattleConfigDefine.COSTLIST.IndexOf(cost);
	}

	// Token: 0x06008A0F RID: 35343 RVA: 0x0029D704 File Offset: 0x0029B904
	public static object GetPhantomQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(VisionDestroyFilterLogic.GetDataConfigId(data)).PhantomItem.GetValueOrDefault().QualityId;
	}

	// Token: 0x06008A10 RID: 35344 RVA: 0x0029D73B File Offset: 0x0029B93B
	public static object GetVisionDestroyFetterGroup(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(VisionDestroyFilterLogic.GetDataUniqueId(data));
		return (phantomDataBase != null) ? phantomDataBase.GetFetterGroupId() : 0;
	}

	// Token: 0x06008A11 RID: 35345 RVA: 0x0029D760 File Offset: 0x0029B960
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
				bool ifPercentage = Array.IndexOf<int>(PhantomBattleConfig.Instance.GetVisionMainPercentageAttributeSortArray(), num) >= 0;
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
				bool ifPercentage2 = Array.IndexOf<int>(PhantomBattleConfig.Instance.GetVisionSubPercentageAttributeSortArray(), num) >= 0;
				int subAttributeKey = PhantomBattleModel.Instance.GetSubAttributeKey(num);
				visionAttribute = VisionDestroyFilterLogic.GetVisionAttribute(propData2, subAttributeKey, ifPercentage2);
			}
			else
			{
				List<PhantomSortStruct> propData3 = (phantomBattleData != null) ? phantomBattleData.GetMainPropArray() : null;
				bool ifPercentage3 = Array.IndexOf<int>(PhantomBattleConfig.Instance.GetVisionMainPercentageAttributeSortArray(), num) >= 0;
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

	// Token: 0x06008A12 RID: 35346 RVA: 0x0029D8E8 File Offset: 0x0029BAE8
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

	// Token: 0x06008A13 RID: 35347 RVA: 0x0029D95C File Offset: 0x0029BB5C
	public static object GetPhantomDeprecate(object data, Dictionary<int, string> currentSelectMap)
	{
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(VisionDestroyFilterLogic.GetDataUniqueId(data));
		if (phantomDataBase != null && phantomDataBase.GetIsLock())
		{
			return 2;
		}
		return ((phantomDataBase != null && phantomDataBase.GetIsDeprecated()) > false) ? 1 : 0;
	}

	// Token: 0x04005303 RID: 21251
	private const int SUBATTRIBUTEID = 23;

	// Token: 0x04005304 RID: 21252
	private const int COSTATTRIBUTEID = 1000;
}
