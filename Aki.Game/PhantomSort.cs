using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000D46 RID: 3398
[NullableContext(1)]
[Nullable(0)]
public class PhantomSort : CommonSort<EPhantomSortWayType>
{
	// Token: 0x06008BF6 RID: 35830 RVA: 0x002A5304 File Offset: 0x002A3504
	private int SortLevel(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			PhantomBattleModel instance = PhantomBattleModel.Instance;
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomBattleData phantomBattleData = instance.GetPhantomBattleData(uniqueId);
			PhantomBattleData phantomBattleData2 = instance.GetPhantomBattleData(uniqueId2);
			if (phantomBattleData.GetPhantomLevel() != phantomBattleData2.GetPhantomLevel())
			{
				return (phantomBattleData2.GetPhantomLevel() - phantomBattleData.GetPhantomLevel()) * (isAscending ? -1 : 1);
			}
			return 0;
		}
		else
		{
			IPhantomItemData phantomItemData = a as IPhantomItemData;
			IPhantomItemData phantomItemData2 = b as IPhantomItemData;
			if (phantomItemData == phantomItemData2)
			{
				return 0;
			}
			if (phantomItemData == null)
			{
				return 1;
			}
			if (phantomItemData2 == null)
			{
				return -1;
			}
			if (phantomItemData.Level != phantomItemData2.Level)
			{
				return (phantomItemData2.Level - phantomItemData.Level) * (isAscending ? -1 : 1);
			}
			return 0;
		}
	}

	// Token: 0x06008BF7 RID: 35831 RVA: 0x002A53FC File Offset: 0x002A35FC
	private int SortExp(object a, object b, bool isAscending, object[] param)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase.GetUniqueId());
		PhantomDataBase phantomDataBase2 = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase2.GetUniqueId());
		int num = 0;
		int num2 = 0;
		if (phantomDataBase != null)
		{
			num = phantomDataBase.GetExp();
		}
		else
		{
			IReadOnlyList<PhantomExpItem> phantomExpItemList = PhantomBattleConfig.Instance.GetPhantomExpItemList();
			int count = phantomExpItemList.Count;
			for (int i = 0; i < count; i++)
			{
				if (phantomExpItemList[i].ItemId == itemDataBase.GetConfigId())
				{
					num = phantomExpItemList[i].Exp;
					break;
				}
			}
		}
		if (phantomDataBase2 != null)
		{
			num2 = phantomDataBase2.GetExp();
		}
		else
		{
			IReadOnlyList<PhantomExpItem> phantomExpItemList2 = PhantomBattleConfig.Instance.GetPhantomExpItemList();
			int count2 = phantomExpItemList2.Count;
			for (int j = 0; j < count2; j++)
			{
				if (phantomExpItemList2[j].ItemId == itemDataBase2.GetConfigId())
				{
					num2 = phantomExpItemList2[j].Exp;
					break;
				}
			}
		}
		if (num != num2)
		{
			return (num2 - num) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008BF8 RID: 35832 RVA: 0x002A551C File Offset: 0x002A371C
	private int SortExpFirst(object a, object b, bool isAscending, object[] param)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		IReadOnlyList<PhantomExpItem> phantomExpItemList = PhantomBattleConfig.Instance.GetPhantomExpItemList();
		int count = phantomExpItemList.Count;
		bool flag = false;
		for (int i = 0; i < count; i++)
		{
			if (phantomExpItemList[i].ItemId == itemDataBase.GetConfigId())
			{
				flag = true;
				break;
			}
		}
		bool flag2 = false;
		for (int j = 0; j < count; j++)
		{
			if (phantomExpItemList[j].ItemId == itemDataBase2.GetConfigId())
			{
				flag2 = true;
				break;
			}
		}
		if (flag != flag2)
		{
			int num = (flag > false) ? 1 : 0;
			return ((flag2 > false) ? 1 : 0) - num;
		}
		return 0;
	}

	// Token: 0x06008BF9 RID: 35833 RVA: 0x002A55C4 File Offset: 0x002A37C4
	private int SortBreach(object a, object b, bool isAscending, object[] param)
	{
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			PhantomBattleModel instance = PhantomBattleModel.Instance;
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomBattleData phantomBattleData = instance.GetPhantomBattleData(uniqueId);
			PhantomDataBase phantomBattleData2 = instance.GetPhantomBattleData(uniqueId2);
			List<Aki.Protocol.PhantomPropInfo> phantomSubProp = phantomBattleData.GetPhantomSubProp();
			List<Aki.Protocol.PhantomPropInfo> phantomSubProp2 = phantomBattleData2.GetPhantomSubProp();
			int num = ((phantomSubProp != null && phantomSubProp.Count > 0) > false) ? 1 : 0;
			int num2 = ((phantomSubProp2 != null && phantomSubProp2.Count > 0) > false) ? 1 : 0;
			if (num != num2)
			{
				return (num2 - num) * (isAscending ? -1 : 1);
			}
			return 0;
		}
		else
		{
			IPhantomItemData phantomItemData = a as IPhantomItemData;
			IPhantomItemData phantomItemData2 = b as IPhantomItemData;
			if (phantomItemData == phantomItemData2)
			{
				return 0;
			}
			if (phantomItemData == null)
			{
				return 1;
			}
			if (phantomItemData2 == null)
			{
				return -1;
			}
			int num3 = (phantomItemData.IsBreach > false) ? 1 : 0;
			int num4 = (phantomItemData2.IsBreach > false) ? 1 : 0;
			if (num3 != num4)
			{
				return (num4 - num3) * (isAscending ? -1 : 1);
			}
			return 0;
		}
	}

	// Token: 0x06008BFA RID: 35834 RVA: 0x002A56E4 File Offset: 0x002A38E4
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		if (a is CommonItemData && b is CommonItemData)
		{
			return (((CommonItemData)b).GetQuality() - ((CommonItemData)a).GetQuality()) * (isAscending ? -1 : 1);
		}
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			PhantomBattleModel instance = PhantomBattleModel.Instance;
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomBattleData phantomBattleData = instance.GetPhantomBattleData(uniqueId);
			PhantomBattleData phantomBattleData2 = instance.GetPhantomBattleData(uniqueId2);
			if (phantomBattleData.GetQuality() != phantomBattleData2.GetQuality())
			{
				return (phantomBattleData2.GetQuality() - phantomBattleData.GetQuality()) * (isAscending ? -1 : 1);
			}
			return 0;
		}
		else
		{
			IPhantomItemData phantomItemData = a as IPhantomItemData;
			IPhantomItemData phantomItemData2 = b as IPhantomItemData;
			if (phantomItemData == phantomItemData2)
			{
				return 0;
			}
			if (phantomItemData == null)
			{
				return 1;
			}
			if (phantomItemData2 == null)
			{
				return -1;
			}
			if (phantomItemData.Quality != phantomItemData2.Quality)
			{
				return (phantomItemData2.Quality - phantomItemData.Quality) * (isAscending ? -1 : 1);
			}
			return 0;
		}
	}

	// Token: 0x06008BFB RID: 35835 RVA: 0x002A580C File Offset: 0x002A3A0C
	private int SortMonsterId(object a, object b, bool isAscending, object[] param)
	{
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			PhantomBattleModel instance = PhantomBattleModel.Instance;
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomBattleData phantomBattleData = instance.GetPhantomBattleData(uniqueId);
			PhantomBattleData phantomBattleData2 = instance.GetPhantomBattleData(uniqueId2);
			if (phantomBattleData.GetConfigId(false) != phantomBattleData2.GetConfigId(false))
			{
				return (phantomBattleData2.GetConfigId(false) - phantomBattleData.GetConfigId(false)) * (isAscending ? -1 : 1);
			}
			return 0;
		}
		else
		{
			IPhantomItemData phantomItemData = a as IPhantomItemData;
			IPhantomItemData phantomItemData2 = b as IPhantomItemData;
			if (phantomItemData == phantomItemData2)
			{
				return 0;
			}
			if (phantomItemData == null)
			{
				return 1;
			}
			if (phantomItemData2 == null)
			{
				return -1;
			}
			if (phantomItemData.MonsterId != phantomItemData2.MonsterId)
			{
				return (phantomItemData2.MonsterId - phantomItemData.MonsterId) * (isAscending ? -1 : 1);
			}
			return 0;
		}
	}

	// Token: 0x06008BFC RID: 35836 RVA: 0x002A5908 File Offset: 0x002A3B08
	private int SortUniqueId(object a, object b, bool isAscending, object[] param)
	{
		int sortIncrId = this.GetSortIncrId(a);
		int sortIncrId2 = this.GetSortIncrId(b);
		if (sortIncrId == 0 || sortIncrId2 == 0)
		{
			if (sortIncrId == sortIncrId2)
			{
				return 0;
			}
			if (sortIncrId != 0)
			{
				return -1;
			}
			return 1;
		}
		else
		{
			InventoryModel instance = InventoryModel.Instance;
			PhantomItemData phantomItemData = instance.GetPhantomItemData(sortIncrId);
			long num = (phantomItemData != null) ? phantomItemData.GetAddTime() : 0L;
			PhantomItemData phantomItemData2 = instance.GetPhantomItemData(sortIncrId2);
			long num2 = (phantomItemData2 != null) ? phantomItemData2.GetAddTime() : 0L;
			if (num != num2)
			{
				return ((num2 > num) ? 1 : -1) * (isAscending ? -1 : 1);
			}
			PhantomBattleModel instance2 = PhantomBattleModel.Instance;
			PhantomBattleData phantomBattleData = instance2.GetPhantomBattleData(sortIncrId);
			PhantomBattleData phantomBattleData2 = instance2.GetPhantomBattleData(sortIncrId2);
			if (phantomBattleData != null && phantomBattleData2 != null)
			{
				if (phantomBattleData.GetConfigId(false) != phantomBattleData2.GetConfigId(false))
				{
					return (phantomBattleData2.GetConfigId(false) - phantomBattleData.GetConfigId(false)) * (isAscending ? -1 : 1);
				}
				if (phantomBattleData.GetFetterGroupId() != phantomBattleData2.GetFetterGroupId())
				{
					return (phantomBattleData2.GetFetterGroupId() - phantomBattleData.GetFetterGroupId()) * (isAscending ? -1 : 1);
				}
				List<Aki.Protocol.PhantomPropInfo> phantomMainProp = phantomBattleData.GetPhantomMainProp();
				List<Aki.Protocol.PhantomPropInfo> phantomMainProp2 = phantomBattleData2.GetPhantomMainProp();
				int num3 = (phantomMainProp.Count > 0) ? phantomMainProp[0].PhantomPropId : 0;
				int num4 = (phantomMainProp2.Count > 0) ? phantomMainProp2[0].PhantomPropId : 0;
				if (num3 != num4)
				{
					return (num4 - num3) * (isAscending ? -1 : 1);
				}
			}
			if (sortIncrId != sortIncrId2)
			{
				return (sortIncrId2 - sortIncrId) * (isAscending ? -1 : 1);
			}
			return 0;
		}
	}

	// Token: 0x06008BFD RID: 35837 RVA: 0x002A5A64 File Offset: 0x002A3C64
	private int GetSortIncrId(object data)
	{
		ItemViewData itemViewData = data as ItemViewData;
		if (itemViewData != null)
		{
			return itemViewData.GetUniqueId();
		}
		PhantomItemData phantomItemData = data as PhantomItemData;
		if (phantomItemData != null)
		{
			return phantomItemData.GetUniqueId();
		}
		IPhantomItemData phantomItemData2 = data as IPhantomItemData;
		if (phantomItemData2 != null)
		{
			return phantomItemData2.Id;
		}
		return 0;
	}

	// Token: 0x06008BFE RID: 35838 RVA: 0x002A5AA8 File Offset: 0x002A3CA8
	private int GetPropValue(List<PhantomSortStruct> propData, int propKey, bool ifPercentage = false)
	{
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

	// Token: 0x06008BFF RID: 35839 RVA: 0x002A5B14 File Offset: 0x002A3D14
	private int SortMainLife(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 10002, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 10002, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C00 RID: 35840 RVA: 0x002A5B68 File Offset: 0x002A3D68
	private int SortMainLifePercentage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 10002, true);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 10002, true);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C01 RID: 35841 RVA: 0x002A5BBC File Offset: 0x002A3DBC
	private int SortMainAttack(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 10007, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 10007, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C02 RID: 35842 RVA: 0x002A5C10 File Offset: 0x002A3E10
	private int SortMainAttackPercentage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 10007, true);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 10007, true);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C03 RID: 35843 RVA: 0x002A5C64 File Offset: 0x002A3E64
	private int SortMainDefense(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 10010, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 10010, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C04 RID: 35844 RVA: 0x002A5CB8 File Offset: 0x002A3EB8
	private int SortMainDefensePercentage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 10010, true);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 10010, true);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C05 RID: 35845 RVA: 0x002A5D0C File Offset: 0x002A3F0C
	private int SortMainCrit(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 8, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 8, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C06 RID: 35846 RVA: 0x002A5D58 File Offset: 0x002A3F58
	private int SortMainCritDamage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 9, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 9, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C07 RID: 35847 RVA: 0x002A5DA4 File Offset: 0x002A3FA4
	private int SortMainTreat(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 35, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 35, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C08 RID: 35848 RVA: 0x002A5DF0 File Offset: 0x002A3FF0
	private int SortMainPhysicsDamage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 21, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 21, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C09 RID: 35849 RVA: 0x002A5E3C File Offset: 0x002A403C
	private int SortMainIceAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 22, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 22, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C0A RID: 35850 RVA: 0x002A5E88 File Offset: 0x002A4088
	private int SortMainFireAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 23, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 23, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C0B RID: 35851 RVA: 0x002A5ED4 File Offset: 0x002A40D4
	private int SortMainThunderAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 24, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 24, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C0C RID: 35852 RVA: 0x002A5F20 File Offset: 0x002A4120
	private int SortMainWindAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 25, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 25, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C0D RID: 35853 RVA: 0x002A5F6C File Offset: 0x002A416C
	private int SortMainLightAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 26, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 26, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C0E RID: 35854 RVA: 0x002A5FB8 File Offset: 0x002A41B8
	private int SortMainDarkAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 27, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 27, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C0F RID: 35855 RVA: 0x002A6004 File Offset: 0x002A4204
	private int SortMainEnergy(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.MainPropMap, 11, false);
		int propValue2 = this.GetPropValue(phantomItemData2.MainPropMap, 11, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C10 RID: 35856 RVA: 0x002A6050 File Offset: 0x002A4250
	private int SortSubLife(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 1, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 1, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C11 RID: 35857 RVA: 0x002A609C File Offset: 0x002A429C
	private int SortSubLifePercentage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 4, true);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 4, true);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C12 RID: 35858 RVA: 0x002A60E8 File Offset: 0x002A42E8
	private int SortSubAttack(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 2, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 2, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C13 RID: 35859 RVA: 0x002A6134 File Offset: 0x002A4334
	private int SortSubAttackPercentage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 5, true);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 5, true);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C14 RID: 35860 RVA: 0x002A6180 File Offset: 0x002A4380
	private int SortSubDefense(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 3, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 3, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C15 RID: 35861 RVA: 0x002A61CC File Offset: 0x002A43CC
	private int SortSubDefensePercentage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 6, true);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 6, true);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C16 RID: 35862 RVA: 0x002A6218 File Offset: 0x002A4418
	private int SortSubCrit(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 14, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 14, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C17 RID: 35863 RVA: 0x002A6264 File Offset: 0x002A4464
	private int SortSubCritDamage(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 15, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 15, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C18 RID: 35864 RVA: 0x002A62B0 File Offset: 0x002A44B0
	private int SortSubTreat(object a, object b, bool isAscending, object[] param)
	{
		return 0;
	}

	// Token: 0x06008C19 RID: 35865 RVA: 0x002A62B4 File Offset: 0x002A44B4
	private int SortSubWindAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 11, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 11, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C1A RID: 35866 RVA: 0x002A6300 File Offset: 0x002A4500
	private int SortSubLightAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 12, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 12, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C1B RID: 35867 RVA: 0x002A634C File Offset: 0x002A454C
	private int SortSubDarkAttr(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 13, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 13, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C1C RID: 35868 RVA: 0x002A6398 File Offset: 0x002A4598
	private int SortSubEnergy(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 13, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 13, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C1D RID: 35869 RVA: 0x002A63E4 File Offset: 0x002A45E4
	private int SortByEquipState(object a, object b, bool isAscending, object[] param)
	{
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomDataBase phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			PhantomBattleData phantomBattleData2 = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId2);
			int num = (phantomBattleData.GetEquipRoleId() > 0) ? 1 : 0;
			int num2 = (phantomBattleData2.GetEquipRoleId() > 0) ? 1 : 0;
			if (num != num2)
			{
				return (num - num2) * (isAscending ? -1 : 1);
			}
		}
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		if (phantomItemData == phantomItemData2)
		{
			return 0;
		}
		if (phantomItemData == null)
		{
			return 1;
		}
		if (phantomItemData2 == null)
		{
			return -1;
		}
		int num3 = (phantomItemData.Role > 0) ? 1 : 0;
		int num4 = (phantomItemData2.Role > 0) ? 1 : 0;
		if (num3 != num4)
		{
			return (num3 - num4) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C1E RID: 35870 RVA: 0x002A64E4 File Offset: 0x002A46E4
	private int SortByCurrentRole(object a, object b, bool isAscending, object[] param)
	{
		if (param.Length == 0)
		{
			return 0;
		}
		int num = (int)param[0];
		if (num <= 0)
		{
			return 0;
		}
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomDataBase phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			PhantomBattleData phantomBattleData2 = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId2);
			int num2 = (phantomBattleData.GetEquipRoleId() == num) ? 1 : 0;
			int num3 = (phantomBattleData2.GetEquipRoleId() == num) ? 1 : 0;
			if ((num2 == 1 || num3 == 1) && num2 != num3)
			{
				int num4 = num2 - num3;
				return -1 * num4;
			}
		}
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		if (phantomItemData == phantomItemData2)
		{
			return 0;
		}
		if (phantomItemData == null)
		{
			return 1;
		}
		if (phantomItemData2 == null)
		{
			return -1;
		}
		int num5 = (phantomItemData.Role == num) ? 1 : 0;
		int num6 = (phantomItemData2.Role == num) ? 1 : 0;
		if ((num5 == 1 || num6 == 1) && num5 != num6)
		{
			int num7 = num5 - num6;
			return -1 * num7;
		}
		return 0;
	}

	// Token: 0x06008C1F RID: 35871 RVA: 0x002A660C File Offset: 0x002A480C
	private int SortLock(object a, object b, bool isAscending, object[] param)
	{
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomDataBase phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			PhantomBattleData phantomBattleData2 = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId2);
			int num = (phantomBattleData.GetIsLock() > false) ? 1 : 0;
			int num2 = (phantomBattleData2.GetIsLock() > false) ? 1 : 0;
			if (num != num2)
			{
				return num - num2;
			}
		}
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		if (phantomItemData == phantomItemData2)
		{
			return 0;
		}
		if (phantomItemData == null)
		{
			return 1;
		}
		if (phantomItemData2 == null)
		{
			return -1;
		}
		int num3 = (phantomItemData.IsLock > false) ? 1 : 0;
		int num4 = (phantomItemData2.IsLock > false) ? 1 : 0;
		if (num3 != num4)
		{
			return -1 * (num3 - num4);
		}
		return 0;
	}

	// Token: 0x06008C20 RID: 35872 RVA: 0x002A66FC File Offset: 0x002A48FC
	private int SortDeprecateFirst(object a, object b, bool isAscending, object[] param)
	{
		return this.SortDeprecate(a, b, isAscending, null);
	}

	// Token: 0x06008C21 RID: 35873 RVA: 0x002A6708 File Offset: 0x002A4908
	private int SortDeprecateLast(object a, object b, bool isAscending, object[] param)
	{
		return this.SortDeprecate(a, b, isAscending, null) * -1;
	}

	// Token: 0x06008C22 RID: 35874 RVA: 0x002A6718 File Offset: 0x002A4918
	private int SortDeprecate(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomDataBase phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			PhantomBattleData phantomBattleData2 = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId2);
			int num = 1;
			int num2 = 0;
			int num3 = phantomBattleData.GetIsDeprecated() ? num : num2;
			int num4 = phantomBattleData2.GetIsDeprecated() ? num : num2;
			if (num3 != num4)
			{
				return (num4 - num3) * (isAscending ? 1 : -1);
			}
		}
		return 0;
	}

	// Token: 0x06008C23 RID: 35875 RVA: 0x002A67DC File Offset: 0x002A49DC
	private int SortRarity(object a, object b, bool isAscending, object[] param)
	{
		if ((a is ItemViewData && b is ItemViewData) || (a is PhantomItemData && b is PhantomItemData))
		{
			int uniqueId = (a is ItemViewData) ? ((ItemViewData)a).GetUniqueId() : ((PhantomItemData)a).GetUniqueId();
			int uniqueId2 = (b is ItemViewData) ? ((ItemViewData)b).GetUniqueId() : ((PhantomItemData)b).GetUniqueId();
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			PhantomDataBase phantomBattleData2 = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId2);
			int rarity = phantomBattleData.GetConfig().Rarity;
			int rarity2 = phantomBattleData2.GetConfig().Rarity;
			if (rarity != rarity2)
			{
				return (rarity - rarity2) * (isAscending ? 1 : -1);
			}
		}
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		if (phantomItemData == phantomItemData2)
		{
			return 0;
		}
		if (phantomItemData == null)
		{
			return 1;
		}
		if (phantomItemData2 == null)
		{
			return -1;
		}
		int rarity3 = phantomItemData.Rarity;
		int rarity4 = phantomItemData2.Rarity;
		if (rarity3 != rarity4)
		{
			return (rarity3 - rarity4) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x06008C24 RID: 35876 RVA: 0x002A68E0 File Offset: 0x002A4AE0
	private int SortSkin(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int[] monsterSkinListByMonsterId = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(phantomItemData.MonsterId);
		int num = (monsterSkinListByMonsterId != null) ? monsterSkinListByMonsterId.Length : 0;
		int[] monsterSkinListByMonsterId2 = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(phantomItemData2.MonsterId);
		int num2 = (monsterSkinListByMonsterId2 != null) ? monsterSkinListByMonsterId2.Length : 0;
		if (num != num2)
		{
			return (num2 - num) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C25 RID: 35877 RVA: 0x002A6940 File Offset: 0x002A4B40
	private int SortSubComboHurt(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 7, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 7, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C26 RID: 35878 RVA: 0x002A698C File Offset: 0x002A4B8C
	private int SortNormalHurt(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 8, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 8, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C27 RID: 35879 RVA: 0x002A69D8 File Offset: 0x002A4BD8
	private int SortChargeHurt(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 9, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 9, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C28 RID: 35880 RVA: 0x002A6A24 File Offset: 0x002A4C24
	private int SortComboReleaseHurt(object a, object b, bool isAscending, object[] param)
	{
		IPhantomItemData phantomItemData = a as IPhantomItemData;
		IPhantomItemData phantomItemData2 = b as IPhantomItemData;
		int propValue = this.GetPropValue(phantomItemData.SubPropMap, 10, false);
		int propValue2 = this.GetPropValue(phantomItemData2.SubPropMap, 10, false);
		if (propValue != propValue2)
		{
			return (propValue2 - propValue) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C29 RID: 35881 RVA: 0x002A6A70 File Offset: 0x002A4C70
	private int SortQualityDescend(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return this.SortQuality(a, b, false, null);
	}

	// Token: 0x06008C2A RID: 35882 RVA: 0x002A6A7C File Offset: 0x002A4C7C
	private int SortLevelAscend(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		int num = this.SortLevel(a, b, true, null);
		if (num != 0)
		{
			return num;
		}
		return this.SortGetExp(a, b, true, null);
	}

	// Token: 0x06008C2B RID: 35883 RVA: 0x002A6AA4 File Offset: 0x002A4CA4
	private int SortGetExp(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase.GetUniqueId());
		PhantomDataBase phantomDataBase2 = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase2.GetUniqueId());
		int num = 0;
		int num2 = 0;
		if (phantomDataBase != null)
		{
			num = phantomDataBase.GetEatFullExp();
		}
		else
		{
			IReadOnlyList<PhantomExpItem> phantomExpItemList = PhantomBattleConfig.Instance.GetPhantomExpItemList();
			int count = phantomExpItemList.Count;
			for (int i = 0; i < count; i++)
			{
				if (phantomExpItemList[i].ItemId == itemDataBase.GetConfigId())
				{
					num = phantomExpItemList[i].Exp;
					break;
				}
			}
		}
		if (phantomDataBase2 != null)
		{
			num2 = phantomDataBase2.GetEatFullExp();
		}
		else
		{
			IReadOnlyList<PhantomExpItem> phantomExpItemList2 = PhantomBattleConfig.Instance.GetPhantomExpItemList();
			int count2 = phantomExpItemList2.Count;
			for (int j = 0; j < count2; j++)
			{
				if (phantomExpItemList2[j].ItemId == itemDataBase2.GetConfigId())
				{
					num2 = phantomExpItemList2[j].Exp;
					break;
				}
			}
		}
		if (num != num2)
		{
			return (num2 - num) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C2C RID: 35884 RVA: 0x002A6BC4 File Offset: 0x002A4DC4
	private int SortIdentifyNum(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase.GetUniqueId());
		PhantomDataBase phantomDataBase2 = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase2.GetUniqueId());
		int num = phantomDataBase.GetCurrentIdentifyNum() - phantomDataBase2.GetCurrentIdentifyNum();
		if (!isAscending)
		{
			return -num;
		}
		return num;
	}

	// Token: 0x06008C2D RID: 35885 RVA: 0x002A6C14 File Offset: 0x002A4E14
	private int SortIdentifyNumDescend(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return this.SortIdentifyNum(a, b, false, null);
	}

	// Token: 0x06008C2E RID: 35886 RVA: 0x002A6C20 File Offset: 0x002A4E20
	private int SortNonEquipFirst(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase.GetUniqueId());
		PhantomDataBase phantomDataBase2 = PhantomBattleModel.Instance.GetPhantomDataBase(itemDataBase2.GetUniqueId());
		int equipRoleId = phantomDataBase.GetEquipRoleId();
		int equipRoleId2 = phantomDataBase2.GetEquipRoleId();
		if ((equipRoleId == 0 && equipRoleId2 == 0) || (equipRoleId != 0 && equipRoleId2 != 0))
		{
			return 0;
		}
		if (equipRoleId == 0)
		{
			return -1;
		}
		return 1;
	}

	// Token: 0x06008C2F RID: 35887 RVA: 0x002A6C80 File Offset: 0x002A4E80
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EPhantomSortWayType.Level, new TSortResult(this.SortLevel));
		this.SortMap.Add(EPhantomSortWayType.Breach, new TSortResult(this.SortBreach));
		this.SortMap.Add(EPhantomSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(EPhantomSortWayType.MonsterId, new TSortResult(this.SortMonsterId));
		this.SortMap.Add(EPhantomSortWayType.UniqueId, new TSortResult(this.SortUniqueId));
		this.SortMap.Add(EPhantomSortWayType.MainAttack, new TSortResult(this.SortMainAttack));
		this.SortMap.Add(EPhantomSortWayType.MainAttackPercentage, new TSortResult(this.SortMainAttackPercentage));
		this.SortMap.Add(EPhantomSortWayType.MainLife, new TSortResult(this.SortMainLife));
		this.SortMap.Add(EPhantomSortWayType.MainLifePercentage, new TSortResult(this.SortMainLifePercentage));
		this.SortMap.Add(EPhantomSortWayType.MainDefense, new TSortResult(this.SortMainDefense));
		this.SortMap.Add(EPhantomSortWayType.MainDefensePercentage, new TSortResult(this.SortMainDefensePercentage));
		this.SortMap.Add(EPhantomSortWayType.MainCrit, new TSortResult(this.SortMainCrit));
		this.SortMap.Add(EPhantomSortWayType.MainCritHurt, new TSortResult(this.SortMainCritDamage));
		this.SortMap.Add(EPhantomSortWayType.MainTreat, new TSortResult(this.SortMainTreat));
		this.SortMap.Add(EPhantomSortWayType.MainPhysicsHurt, new TSortResult(this.SortMainPhysicsDamage));
		this.SortMap.Add(EPhantomSortWayType.MainIceHurt, new TSortResult(this.SortMainIceAttr));
		this.SortMap.Add(EPhantomSortWayType.MainFireHurt, new TSortResult(this.SortMainFireAttr));
		this.SortMap.Add(EPhantomSortWayType.MainThunderHurt, new TSortResult(this.SortMainThunderAttr));
		this.SortMap.Add(EPhantomSortWayType.MainWindHurt, new TSortResult(this.SortMainWindAttr));
		this.SortMap.Add(EPhantomSortWayType.MainLightHurt, new TSortResult(this.SortMainLightAttr));
		this.SortMap.Add(EPhantomSortWayType.MainDarkHurt, new TSortResult(this.SortMainDarkAttr));
		this.SortMap.Add(EPhantomSortWayType.MainEnergy, new TSortResult(this.SortMainEnergy));
		this.SortMap.Add(EPhantomSortWayType.SubAttack, new TSortResult(this.SortSubAttack));
		this.SortMap.Add(EPhantomSortWayType.SubAttackPercentage, new TSortResult(this.SortSubAttackPercentage));
		this.SortMap.Add(EPhantomSortWayType.SubLife, new TSortResult(this.SortSubLife));
		this.SortMap.Add(EPhantomSortWayType.SubLifePercentage, new TSortResult(this.SortSubLifePercentage));
		this.SortMap.Add(EPhantomSortWayType.SubDefense, new TSortResult(this.SortSubDefense));
		this.SortMap.Add(EPhantomSortWayType.SubDefensePercentage, new TSortResult(this.SortSubDefensePercentage));
		this.SortMap.Add(EPhantomSortWayType.SubCrit, new TSortResult(this.SortSubCrit));
		this.SortMap.Add(EPhantomSortWayType.SubCritHurt, new TSortResult(this.SortSubCritDamage));
		this.SortMap.Add(EPhantomSortWayType.SubTreat, new TSortResult(this.SortSubTreat));
		this.SortMap.Add(EPhantomSortWayType.SubWindHurt, new TSortResult(this.SortSubWindAttr));
		this.SortMap.Add(EPhantomSortWayType.SubLightHurt, new TSortResult(this.SortSubLightAttr));
		this.SortMap.Add(EPhantomSortWayType.SubDarkHurt, new TSortResult(this.SortSubDarkAttr));
		this.SortMap.Add(EPhantomSortWayType.SubEnergy, new TSortResult(this.SortSubEnergy));
		this.SortMap.Add(EPhantomSortWayType.Exp, new TSortResult(this.SortExp));
		this.SortMap.Add(EPhantomSortWayType.ExpItem, new TSortResult(this.SortExpFirst));
		this.SortMap.Add(EPhantomSortWayType.EquipState, new TSortResult(this.SortByEquipState));
		this.SortMap.Add(EPhantomSortWayType.CurrentRoleEquip, new TSortResult(this.SortByCurrentRole));
		this.SortMap.Add(EPhantomSortWayType.Lock, new TSortResult(this.SortLock));
		this.SortMap.Add(EPhantomSortWayType.Rarity, new TSortResult(this.SortRarity));
		this.SortMap.Add(EPhantomSortWayType.Skin, new TSortResult(this.SortSkin));
		this.SortMap.Add(EPhantomSortWayType.SubComboHurt, new TSortResult(this.SortSubComboHurt));
		this.SortMap.Add(EPhantomSortWayType.SubNormalHurt, new TSortResult(this.SortNormalHurt));
		this.SortMap.Add(EPhantomSortWayType.SubChargeHurt, new TSortResult(this.SortChargeHurt));
		this.SortMap.Add(EPhantomSortWayType.SubComboReleaseHurt, new TSortResult(this.SortComboReleaseHurt));
		this.SortMap.Add(EPhantomSortWayType.DeprecateFirst, new TSortResult(this.SortDeprecateFirst));
		this.SortMap.Add(EPhantomSortWayType.DeprecateLast, new TSortResult(this.SortDeprecateLast));
		this.SortMap.Add(EPhantomSortWayType.QualityFiveFirst, new TSortResult(this.SortQualityDescend));
		this.SortMap.Add(EPhantomSortWayType.LevelOneFirst, new TSortResult(this.SortLevelAscend));
		this.SortMap.Add(EPhantomSortWayType.SortGetExp, new TSortResult(this.SortGetExp));
		this.SortMap.Add(EPhantomSortWayType.IdentifyNumHighFirst, new TSortResult(this.SortIdentifyNumDescend));
		this.SortMap.Add(EPhantomSortWayType.NonEquipFirst, new TSortResult(this.SortNonEquipFirst));
	}
}
