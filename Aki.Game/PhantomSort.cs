using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200188D RID: 6285
[NullableContext(1)]
[Nullable(0)]
public class PhantomSort : CommonSort<EPhantomSortWayType>
{
	// Token: 0x0600B80D RID: 47117 RVA: 0x0029ABEC File Offset: 0x00298DEC
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

	// Token: 0x0600B80E RID: 47118 RVA: 0x0029ACE4 File Offset: 0x00298EE4
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

	// Token: 0x0600B80F RID: 47119 RVA: 0x0029AE04 File Offset: 0x00299004
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

	// Token: 0x0600B810 RID: 47120 RVA: 0x0029AEAC File Offset: 0x002990AC
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

	// Token: 0x0600B811 RID: 47121 RVA: 0x0029AFCC File Offset: 0x002991CC
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

	// Token: 0x0600B812 RID: 47122 RVA: 0x0029B0F4 File Offset: 0x002992F4
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

	// Token: 0x0600B813 RID: 47123 RVA: 0x0029B1F0 File Offset: 0x002993F0
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

	// Token: 0x0600B814 RID: 47124 RVA: 0x0029B34C File Offset: 0x0029954C
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

	// Token: 0x0600B815 RID: 47125 RVA: 0x0029B390 File Offset: 0x00299590
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

	// Token: 0x0600B816 RID: 47126 RVA: 0x0029B3FC File Offset: 0x002995FC
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

	// Token: 0x0600B817 RID: 47127 RVA: 0x0029B450 File Offset: 0x00299650
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

	// Token: 0x0600B818 RID: 47128 RVA: 0x0029B4A4 File Offset: 0x002996A4
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

	// Token: 0x0600B819 RID: 47129 RVA: 0x0029B4F8 File Offset: 0x002996F8
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

	// Token: 0x0600B81A RID: 47130 RVA: 0x0029B54C File Offset: 0x0029974C
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

	// Token: 0x0600B81B RID: 47131 RVA: 0x0029B5A0 File Offset: 0x002997A0
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

	// Token: 0x0600B81C RID: 47132 RVA: 0x0029B5F4 File Offset: 0x002997F4
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

	// Token: 0x0600B81D RID: 47133 RVA: 0x0029B640 File Offset: 0x00299840
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

	// Token: 0x0600B81E RID: 47134 RVA: 0x0029B68C File Offset: 0x0029988C
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

	// Token: 0x0600B81F RID: 47135 RVA: 0x0029B6D8 File Offset: 0x002998D8
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

	// Token: 0x0600B820 RID: 47136 RVA: 0x0029B724 File Offset: 0x00299924
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

	// Token: 0x0600B821 RID: 47137 RVA: 0x0029B770 File Offset: 0x00299970
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

	// Token: 0x0600B822 RID: 47138 RVA: 0x0029B7BC File Offset: 0x002999BC
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

	// Token: 0x0600B823 RID: 47139 RVA: 0x0029B808 File Offset: 0x00299A08
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

	// Token: 0x0600B824 RID: 47140 RVA: 0x0029B854 File Offset: 0x00299A54
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

	// Token: 0x0600B825 RID: 47141 RVA: 0x0029B8A0 File Offset: 0x00299AA0
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

	// Token: 0x0600B826 RID: 47142 RVA: 0x0029B8EC File Offset: 0x00299AEC
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

	// Token: 0x0600B827 RID: 47143 RVA: 0x0029B938 File Offset: 0x00299B38
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

	// Token: 0x0600B828 RID: 47144 RVA: 0x0029B984 File Offset: 0x00299B84
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

	// Token: 0x0600B829 RID: 47145 RVA: 0x0029B9D0 File Offset: 0x00299BD0
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

	// Token: 0x0600B82A RID: 47146 RVA: 0x0029BA1C File Offset: 0x00299C1C
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

	// Token: 0x0600B82B RID: 47147 RVA: 0x0029BA68 File Offset: 0x00299C68
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

	// Token: 0x0600B82C RID: 47148 RVA: 0x0029BAB4 File Offset: 0x00299CB4
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

	// Token: 0x0600B82D RID: 47149 RVA: 0x0029BB00 File Offset: 0x00299D00
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

	// Token: 0x0600B82E RID: 47150 RVA: 0x0029BB4C File Offset: 0x00299D4C
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

	// Token: 0x0600B82F RID: 47151 RVA: 0x0029BB98 File Offset: 0x00299D98
	private int SortSubTreat(object a, object b, bool isAscending, object[] param)
	{
		return 0;
	}

	// Token: 0x0600B830 RID: 47152 RVA: 0x0029BB9C File Offset: 0x00299D9C
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

	// Token: 0x0600B831 RID: 47153 RVA: 0x0029BBE8 File Offset: 0x00299DE8
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

	// Token: 0x0600B832 RID: 47154 RVA: 0x0029BC34 File Offset: 0x00299E34
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

	// Token: 0x0600B833 RID: 47155 RVA: 0x0029BC80 File Offset: 0x00299E80
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

	// Token: 0x0600B834 RID: 47156 RVA: 0x0029BCCC File Offset: 0x00299ECC
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

	// Token: 0x0600B835 RID: 47157 RVA: 0x0029BDCC File Offset: 0x00299FCC
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

	// Token: 0x0600B836 RID: 47158 RVA: 0x0029BEF4 File Offset: 0x0029A0F4
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

	// Token: 0x0600B837 RID: 47159 RVA: 0x0029BFE4 File Offset: 0x0029A1E4
	private int SortDeprecateFirst(object a, object b, bool isAscending, object[] param)
	{
		return this.SortDeprecate(a, b, isAscending, null);
	}

	// Token: 0x0600B838 RID: 47160 RVA: 0x0029BFF0 File Offset: 0x0029A1F0
	private int SortDeprecateLast(object a, object b, bool isAscending, object[] param)
	{
		return this.SortDeprecate(a, b, isAscending, null) * -1;
	}

	// Token: 0x0600B839 RID: 47161 RVA: 0x0029C000 File Offset: 0x0029A200
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

	// Token: 0x0600B83A RID: 47162 RVA: 0x0029C0C4 File Offset: 0x0029A2C4
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

	// Token: 0x0600B83B RID: 47163 RVA: 0x0029C1C8 File Offset: 0x0029A3C8
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

	// Token: 0x0600B83C RID: 47164 RVA: 0x0029C228 File Offset: 0x0029A428
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

	// Token: 0x0600B83D RID: 47165 RVA: 0x0029C274 File Offset: 0x0029A474
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

	// Token: 0x0600B83E RID: 47166 RVA: 0x0029C2C0 File Offset: 0x0029A4C0
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

	// Token: 0x0600B83F RID: 47167 RVA: 0x0029C30C File Offset: 0x0029A50C
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

	// Token: 0x0600B840 RID: 47168 RVA: 0x0029C358 File Offset: 0x0029A558
	private int SortQualityDescend(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return this.SortQuality(a, b, false, null);
	}

	// Token: 0x0600B841 RID: 47169 RVA: 0x0029C364 File Offset: 0x0029A564
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

	// Token: 0x0600B842 RID: 47170 RVA: 0x0029C38C File Offset: 0x0029A58C
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

	// Token: 0x0600B843 RID: 47171 RVA: 0x0029C4AC File Offset: 0x0029A6AC
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

	// Token: 0x0600B844 RID: 47172 RVA: 0x0029C4FC File Offset: 0x0029A6FC
	private int SortIdentifyNumDescend(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return this.SortIdentifyNum(a, b, false, null);
	}

	// Token: 0x0600B845 RID: 47173 RVA: 0x0029C508 File Offset: 0x0029A708
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

	// Token: 0x0600B846 RID: 47174 RVA: 0x0029C568 File Offset: 0x0029A768
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
