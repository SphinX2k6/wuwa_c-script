using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02002457 RID: 9303
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VisionRecommendModel : ModelBase
{
	// Token: 0x06012A62 RID: 76386 RVA: 0x0049996C File Offset: 0x00497B6C
	protected override bool OnInit()
	{
		this.CostMap3012 = new Dictionary<int, int>
		{
			{
				3,
				0
			},
			{
				1,
				2
			}
		};
		this.CostMap3111 = new Dictionary<int, int>
		{
			{
				3,
				1
			},
			{
				1,
				1
			}
		};
		this.CostMap3210 = new Dictionary<int, int>
		{
			{
				3,
				2
			},
			{
				1,
				0
			}
		};
		this.RoleFetterRecommendMap = new Dictionary<int, List<VisionFetterRecommendInfo>>();
		this.RoleSystemFetterRecommendMap = new Dictionary<int, List<VisionFetterRecommendInfo>>();
		this.RoleUsageFetterRecommendMap = new Dictionary<int, List<VisionFetterRecommendInfo>>();
		this.RoleCostAttrRecommendMap = new Dictionary<int, Dictionary<int, VisionAttrRecommendInfo>>();
		this.SortMetricCache = new Dictionary<int, PhantomSortMetric>();
		this.CurrentSelectMainAttrArray = new List<VisionSelectRecommendData>();
		this.CurrentSelectSubAttrArray = new List<VisionSelectRecommendData>();
		this.NormalSortFuncList = new List<TPhantomSortFunction>();
		this.SpecialSortFuncList = new List<TPhantomSortFunction>();
		this.InitializeSortFunctions();
		return base.OnInit();
	}

	// Token: 0x06012A63 RID: 76387 RVA: 0x00499A3C File Offset: 0x00497C3C
	private void InitializeSortFunctions()
	{
		this.NormalSortFuncList.Add(new TPhantomSortFunction(this.SortByFetterGroupId));
		this.NormalSortFuncList.Add(new TPhantomSortFunction(this.SortByQuality));
		this.NormalSortFuncList.Add(new TPhantomSortFunction(this.SortByMainProp));
		this.NormalSortFuncList.Add(new TPhantomSortFunction(this.SortBySubProp));
		this.NormalSortFuncList.Add(new TPhantomSortFunction(this.SortByLevel));
		this.NormalSortFuncList.Add(new TPhantomSortFunction(this.SortByEquipState));
		this.NormalSortFuncList.Add(new TPhantomSortFunction(this.SortByConfigId));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortByGroupSpecial));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortByCost));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortByQuality));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortByMainProp));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortBySubProp));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortByLevel));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortByEquipState));
		this.SpecialSortFuncList.Add(new TPhantomSortFunction(this.SortByConfigId));
	}

	// Token: 0x06012A64 RID: 76388 RVA: 0x00499BA4 File Offset: 0x00497DA4
	public void OnRoleRecommendData(int roleId, PhantomFetterRecommendResponse data)
	{
		if (data == null || data.PhantomFetterRecommendInfos == null)
		{
			return;
		}
		List<VisionFetterRecommendInfo> list = new List<VisionFetterRecommendInfo>();
		foreach (PhantomFetterRecommendInfo data2 in data.PhantomFetterRecommendInfos)
		{
			VisionFetterRecommendInfo visionFetterRecommendInfo = new VisionFetterRecommendInfo();
			visionFetterRecommendInfo.Phrase(data2);
			list.Add(visionFetterRecommendInfo);
		}
		this.RoleFetterRecommendMap[roleId] = list;
		this.BuildRecommendLists(roleId, list);
	}

	// Token: 0x06012A65 RID: 76389 RVA: 0x00499C28 File Offset: 0x00497E28
	private void BuildRecommendLists(int roleId, List<VisionFetterRecommendInfo> rawList)
	{
		List<VisionFetterRecommendInfo> list = new List<VisionFetterRecommendInfo>();
		foreach (VisionFetterRecommendInfo visionFetterRecommendInfo in rawList)
		{
			if (visionFetterRecommendInfo.GetUsage() == 0)
			{
				list.Add(visionFetterRecommendInfo);
			}
		}
		list.Sort(delegate(VisionFetterRecommendInfo a, VisionFetterRecommendInfo b)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(a.GetRecommendFetterGroupId());
			PhantomFetterGroup fetterGroupById2 = PhantomBattleConfig.Instance.GetFetterGroupById(b.GetRecommendFetterGroupId());
			return fetterGroupById.SortId - fetterGroupById2.SortId;
		});
		this.RoleSystemFetterRecommendMap[roleId] = list;
		List<VisionFetterRecommendInfo> list2 = new List<VisionFetterRecommendInfo>();
		foreach (VisionFetterRecommendInfo visionFetterRecommendInfo2 in rawList)
		{
			if (visionFetterRecommendInfo2.GetUsage() != 0)
			{
				list2.Add(visionFetterRecommendInfo2);
			}
		}
		list2.Sort((VisionFetterRecommendInfo a, VisionFetterRecommendInfo b) => b.GetUsage() - a.GetUsage());
		this.RoleUsageFetterRecommendMap[roleId] = list2;
	}

	// Token: 0x06012A66 RID: 76390 RVA: 0x00499D38 File Offset: 0x00497F38
	public void OnRoleRecommendAttrData(int roleId, PhantomAttrRecommendResponse data)
	{
		if (data == null || data.CostPhantomAttrRecommendInfos == null)
		{
			return;
		}
		Dictionary<int, VisionAttrRecommendInfo> dictionary = new Dictionary<int, VisionAttrRecommendInfo>();
		foreach (CostPhantomAttrRecommendInfo costPhantomAttrRecommendInfo in data.CostPhantomAttrRecommendInfos)
		{
			VisionAttrRecommendInfo visionAttrRecommendInfo;
			if (!dictionary.TryGetValue(costPhantomAttrRecommendInfo.Cost, out visionAttrRecommendInfo))
			{
				visionAttrRecommendInfo = new VisionAttrRecommendInfo();
				dictionary[costPhantomAttrRecommendInfo.Cost] = visionAttrRecommendInfo;
			}
			foreach (PhantomAttrRecommendInfo data2 in costPhantomAttrRecommendInfo.MainAttrRecommendInfos)
			{
				AttrRecommendInfo attrRecommendInfo = new AttrRecommendInfo();
				attrRecommendInfo.Phrase(data2);
				visionAttrRecommendInfo.GetMainAttrRecommendInfo().Add(attrRecommendInfo);
			}
			foreach (PhantomAttrRecommendInfo data3 in costPhantomAttrRecommendInfo.ViceAttrRecommendInfos)
			{
				AttrRecommendInfo attrRecommendInfo2 = new AttrRecommendInfo();
				attrRecommendInfo2.Phrase(data3);
				visionAttrRecommendInfo.GetSubAttrRecommendInfo().Add(attrRecommendInfo2);
			}
			visionAttrRecommendInfo.BuildPlanLists();
		}
		this.RoleCostAttrRecommendMap[roleId] = dictionary;
	}

	// Token: 0x06012A67 RID: 76391 RVA: 0x00499E7C File Offset: 0x0049807C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionFetterRecommendInfo> GetRoleFetterRecommendInfo(int roleId)
	{
		List<VisionFetterRecommendInfo> result;
		if (this.RoleFetterRecommendMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06012A68 RID: 76392 RVA: 0x00499E9C File Offset: 0x0049809C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionFetterRecommendInfo> GetRoleSystemFetterRecommendList(int roleId)
	{
		List<VisionFetterRecommendInfo> result;
		if (this.RoleSystemFetterRecommendMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06012A69 RID: 76393 RVA: 0x00499EBC File Offset: 0x004980BC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionFetterRecommendInfo> GetRoleUsageFetterRecommendList(int roleId)
	{
		List<VisionFetterRecommendInfo> result;
		if (this.RoleUsageFetterRecommendMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06012A6A RID: 76394 RVA: 0x00499EDC File Offset: 0x004980DC
	[NullableContext(2)]
	public VisionAttrRecommendInfo GetRoleCostAttrRecommendInfo(int roleId, int cost)
	{
		Dictionary<int, VisionAttrRecommendInfo> dictionary;
		VisionAttrRecommendInfo result;
		if (this.RoleCostAttrRecommendMap.TryGetValue(roleId, out dictionary) && dictionary.TryGetValue(cost, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06012A6B RID: 76395 RVA: 0x00499F08 File Offset: 0x00498108
	public List<AttrRecommendInfo> GetRoleMainAttrRecommendListByPlan(int roleId, int cost, bool isOfficial)
	{
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = this.GetRoleCostAttrRecommendInfo(roleId, cost);
		if (roleCostAttrRecommendInfo == null)
		{
			return new List<AttrRecommendInfo>();
		}
		if (!isOfficial)
		{
			return roleCostAttrRecommendInfo.GetUsageMainAttrRecommendInfo();
		}
		return roleCostAttrRecommendInfo.GetOfficialMainAttrRecommendInfo();
	}

	// Token: 0x06012A6C RID: 76396 RVA: 0x00499F38 File Offset: 0x00498138
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, VisionAttrRecommendInfo> GetRoleAllAttrRecommendInfo(int roleId)
	{
		Dictionary<int, VisionAttrRecommendInfo> result;
		if (this.RoleCostAttrRecommendMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06012A6D RID: 76397 RVA: 0x00499F58 File Offset: 0x00498158
	public bool CheckVisionOneKeyEquipRedDot(int roleDataId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleDataId, true);
		if (roleDataById == null || roleDataById.IsTrialRole())
		{
			return false;
		}
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleDataId).GetIncrIdList();
		bool flag = false;
		int num = 0;
		foreach (int num2 in incrIdList)
		{
			if (num2 == 0)
			{
				flag = true;
			}
			else
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num2);
				if (phantomBattleData != null)
				{
					num += phantomBattleData.GetCost();
				}
			}
		}
		if (flag)
		{
			int num3 = PhantomBattleModel.Instance.GetMaxCost() - num;
			List<PhantomBattleData> allNotEquipPhantomList = this.GetAllNotEquipPhantomList(roleDataId);
			if (allNotEquipPhantomList != null)
			{
				foreach (PhantomBattleData phantomBattleData2 in allNotEquipPhantomList)
				{
					if (phantomBattleData2.GetEquipRoleId() != roleDataId && phantomBattleData2.GetCost() <= num3)
					{
						return true;
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06012A6E RID: 76398 RVA: 0x0049A068 File Offset: 0x00498268
	public int[] GetRecommendEquipUniqueIdListNew(int roleId, int firstVisionMonsterId, VisionFetterRecommendInfo recommendInfo)
	{
		int recommendFetterGroupId = recommendInfo.GetRecommendFetterGroupId();
		int specialFetterSubGroupId = recommendInfo.GetSpecialFetterSubGroupId();
		EFetterGroupType fetterType = recommendInfo.GetFetterType();
		int[] array = new int[5];
		List<IVisionFetterCount> fetterCountList = recommendInfo.GetFetterCountList();
		if (fetterCountList.Count == 3)
		{
			this.TryGetThreeGroupRecommendList(roleId, fetterCountList, array);
			return array;
		}
		List<PhantomBattleData> allNotEquipPhantomList = this.GetAllNotEquipPhantomList(roleId);
		if (allNotEquipPhantomList == null)
		{
			return array;
		}
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		TPhantomSortFunction item = delegate(PhantomBattleData a, PhantomBattleData b, int role, int fetterGroup, IReadOnlyList<int> equipIdNow, int? subGroupId)
		{
			bool flag = a.GetMonsterId(false) == firstVisionMonsterId;
			bool flag2 = b.GetMonsterId(false) == firstVisionMonsterId;
			if (flag && !flag2)
			{
				return -1;
			}
			if (flag2 && !flag)
			{
				return 1;
			}
			return 0;
		};
		this.SortPhantomByRule(allNotEquipPhantomList, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByFetterGroupId),
			item,
			new TPhantomSortFunction(this.SortByCost),
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByMainProp),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortBySubPropRecommendCount),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, recommendFetterGroupId, null);
		int cost = Math.Min(maxCost, 4);
		int costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(array, cost, allNotEquipPhantomList, false, new List<int>());
		int num = 0;
		if (costRecommendEquipUniqueId != 0)
		{
			num += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
			array[0] = costRecommendEquipUniqueId;
		}
		if (num >= maxCost || num == 0)
		{
			return array;
		}
		if (fetterType == EFetterGroupType.Special)
		{
			this.GetNewRecommendEquipUniqueIdList(roleId, recommendFetterGroupId, specialFetterSubGroupId, costRecommendEquipUniqueId, num, allNotEquipPhantomList, array, recommendInfo);
		}
		else
		{
			this.GetNewNormalRecommendEquipUniqueIdList(roleId, recommendFetterGroupId, costRecommendEquipUniqueId, num, recommendInfo, allNotEquipPhantomList, array);
		}
		return array;
	}

	// Token: 0x06012A6F RID: 76399 RVA: 0x0049A204 File Offset: 0x00498404
	private List<List<int>> GetOtherVisionCostPlans(int firstCost, VisionFetterRecommendInfo recommendInfo)
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		int visionRecommendRuleLevel = PhantomBattleConfig.Instance.GetVisionRecommendRuleLevel();
		if (calabashLevel < 2)
		{
			if (firstCost != 1)
			{
				return new List<List<int>>
				{
					new List<int>
					{
						1,
						1,
						1,
						1
					}
				};
			}
			return new List<List<int>>
			{
				new List<int>
				{
					PhantomBattleDefine.costListRecommendLowLevel[0],
					1,
					1,
					1
				}
			};
		}
		else
		{
			if (calabashLevel < visionRecommendRuleLevel)
			{
				List<int> list = new List<int>(PhantomBattleDefine.costListRecommendLowLevel);
				int num = list.IndexOf(firstCost);
				if (num >= 0)
				{
					list.RemoveAt(num);
				}
				else
				{
					list.RemoveAt(list.Count - 1);
				}
				list.Sort((int a, int b) => b - a);
				return new List<List<int>>
				{
					list
				};
			}
			List<ICostCombinationData> list2 = new List<ICostCombinationData>(recommendInfo.GetCostCombinations());
			list2.Sort((ICostCombinationData a, ICostCombinationData b) => b.Usage - a.Usage);
			List<List<int>> list3 = new List<List<int>>();
			foreach (ICostCombinationData costCombinationData in list2)
			{
				int num2 = costCombinationData.Costs.IndexOf(firstCost);
				if (num2 >= 0)
				{
					List<int> list4 = new List<int>(costCombinationData.Costs);
					list4.RemoveAt(num2);
					list3.Add(list4);
				}
			}
			return list3;
		}
	}

	// Token: 0x06012A70 RID: 76400 RVA: 0x0049A39C File Offset: 0x0049859C
	public int[] GetRecommendEquipUniqueIdList(int roleId, VisionFetterRecommendInfo recommendInfo)
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		int visionRecommendRuleLevel = PhantomBattleConfig.Instance.GetVisionRecommendRuleLevel();
		int[] costArray = PhantomBattleDefine.costListRecommendLowLevel;
		if (calabashLevel >= visionRecommendRuleLevel)
		{
			costArray = PhantomBattleDefine.costListRecommendHighLevel;
		}
		int recommendFetterGroupId = recommendInfo.GetRecommendFetterGroupId();
		int specialFetterSubGroupId = recommendInfo.GetSpecialFetterSubGroupId();
		EFetterGroupType fetterType = recommendInfo.GetFetterType();
		int[] array = new int[5];
		List<IVisionFetterCount> fetterCountList = recommendInfo.GetFetterCountList();
		if (fetterCountList.Count == 3)
		{
			this.TryGetThreeGroupRecommendList(roleId, fetterCountList, array);
			return array;
		}
		if (fetterType == EFetterGroupType.Special)
		{
			this.GetSpecialRecommendEquipUniqueIdList(roleId, recommendFetterGroupId, specialFetterSubGroupId, costArray, array);
		}
		else
		{
			this.GetNormalRecommendEquipUniqueIdList(roleId, recommendFetterGroupId, costArray, array);
		}
		return array;
	}

	// Token: 0x06012A71 RID: 76401 RVA: 0x0049A430 File Offset: 0x00498630
	private int[] GetSpecialRecommendEquipUniqueIdList(int roleId, int fetterGroupId, int fetterGroupSubId, int[] costArray, int[] uniqueIdList)
	{
		List<PhantomBattleData> allNotEquipPhantomList = this.GetAllNotEquipPhantomList(roleId);
		if (allNotEquipPhantomList == null)
		{
			return uniqueIdList;
		}
		this.SortPhantomByRule(allNotEquipPhantomList, this.SpecialSortFuncList, roleId, fetterGroupId, new int?(fetterGroupSubId));
		int num = 0;
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		int num2 = uniqueIdList.Length;
		int num3 = 0;
		while (num3 < num2 && num < maxCost)
		{
			int cost = costArray[num3];
			List<int> list;
			if (!this.CheckSpecialEnough(uniqueIdList))
			{
				list = new List<int>();
			}
			else
			{
				(list = new List<int>()).Add(fetterGroupId);
			}
			List<int> disableGroupIdList = list;
			int costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(uniqueIdList, cost, allNotEquipPhantomList, false, disableGroupIdList);
			if (costRecommendEquipUniqueId != 0)
			{
				num += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
				uniqueIdList[num3] = costRecommendEquipUniqueId;
			}
			num3++;
		}
		return uniqueIdList;
	}

	// Token: 0x06012A72 RID: 76402 RVA: 0x0049A4E0 File Offset: 0x004986E0
	private bool CheckSpecialEnough(int[] uniqueIdList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int num in uniqueIdList)
		{
			if (num > 0)
			{
				int fetterGroupId = PhantomBattleModel.Instance.GetPhantomBattleData(num).GetFetterGroupId();
				int num2;
				if (!dictionary.TryGetValue(fetterGroupId, out num2))
				{
					num2 = 0;
				}
				dictionary[fetterGroupId] = num2 + 1;
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (PhantomBattleConfig.Instance.GetFetterGroupById(key).FetterType == 1)
			{
				int fetterGroupMaxCountById = PhantomBattleConfig.Instance.GetFetterGroupMaxCountById(key);
				if (value >= fetterGroupMaxCountById)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06012A73 RID: 76403 RVA: 0x0049A5BC File Offset: 0x004987BC
	private int[] GetNormalRecommendEquipUniqueIdList(int roleId, int fetterGroupId, int[] costArray, int[] uniqueIdList)
	{
		List<PhantomBattleData> allNotEquipPhantomList = this.GetAllNotEquipPhantomList(roleId);
		if (allNotEquipPhantomList == null)
		{
			return uniqueIdList;
		}
		this.SortPhantomByRule(allNotEquipPhantomList, this.NormalSortFuncList, roleId, fetterGroupId, null);
		int num = uniqueIdList.Length;
		int num2 = 0;
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		int num3 = 0;
		while (num3 < num && num2 < maxCost)
		{
			int cost = costArray[num3];
			int costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(uniqueIdList, cost, allNotEquipPhantomList, true, new List<int>());
			if (costRecommendEquipUniqueId != 0)
			{
				num2 += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
				uniqueIdList[num3] = costRecommendEquipUniqueId;
			}
			num3++;
		}
		return uniqueIdList;
	}

	// Token: 0x06012A74 RID: 76404 RVA: 0x0049A650 File Offset: 0x00498850
	private int GetCostRecommendEquipUniqueId(int[] currentSelectUniqueIdArray, int cost, List<PhantomBattleData> unEquipVisionArray, bool needEqual, List<int> disableGroupIdList)
	{
		List<int> list = new List<int>();
		foreach (int uniqueId in currentSelectUniqueIdArray)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			if (phantomBattleData != null)
			{
				list.Add(phantomBattleData.GetMonsterId(false));
			}
		}
		int count = unEquipVisionArray.Count;
		int num = 0;
		List<int> list2 = new List<int>();
		for (int j = 0; j < count; j++)
		{
			PhantomBattleData phantomBattleData2 = unEquipVisionArray[j];
			if ((phantomBattleData2 == null || Array.IndexOf<int>(currentSelectUniqueIdArray, phantomBattleData2.GetUniqueId()) < 0) && !(needEqual ? (phantomBattleData2.GetCost() != cost) : (phantomBattleData2.GetCost() > cost)) && !disableGroupIdList.Contains(phantomBattleData2.GetFetterGroupId()))
			{
				int monsterId = phantomBattleData2.GetMonsterId(false);
				if (!list.Contains(monsterId))
				{
					num = phantomBattleData2.GetUniqueId();
					break;
				}
				list2.Add(phantomBattleData2.GetUniqueId());
			}
		}
		if (num == 0 && list2.Count > 0)
		{
			num = list2[0];
		}
		return num;
	}

	// Token: 0x06012A75 RID: 76405 RVA: 0x0049A754 File Offset: 0x00498954
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhantomBattleData> GetAllNotEquipPhantomList(int roleId)
	{
		List<PhantomItemData> phantomItemDataList = InventoryModel.Instance.GetPhantomItemDataList();
		if (phantomItemDataList.Count == 0)
		{
			return null;
		}
		List<PhantomBattleData> list = new List<PhantomBattleData>();
		foreach (PhantomItemData phantomItemData in phantomItemDataList)
		{
			if (!PhantomBattleModel.Instance.CheckPhantomIsEquip(phantomItemData.GetUniqueId()))
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(phantomItemData.GetUniqueId());
				list.Add(phantomBattleData);
			}
		}
		foreach (int uniqueId in PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList())
		{
			PhantomBattleData phantomBattleData2 = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			if (phantomBattleData2 != null)
			{
				list.Add(phantomBattleData2);
			}
		}
		return list;
	}

	// Token: 0x06012A76 RID: 76406 RVA: 0x0049A844 File Offset: 0x00498A44
	private int SortByFetterGroupId(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		bool flag = a.GetFetterGroupId() == fetterGroupId;
		bool flag2 = b.GetFetterGroupId() == fetterGroupId;
		if (flag && !flag2)
		{
			return -1;
		}
		if (flag2 && !flag)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06012A77 RID: 76407 RVA: 0x0049A878 File Offset: 0x00498A78
	private int SortByQuality(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		return b.GetQuality() - a.GetQuality();
	}

	// Token: 0x06012A78 RID: 76408 RVA: 0x0049A888 File Offset: 0x00498A88
	private int SortByMainProp(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		bool hasRecommendMainProp = this.SortMetricCache[a.GetUniqueId()].HasRecommendMainProp;
		bool hasRecommendMainProp2 = this.SortMetricCache[b.GetUniqueId()].HasRecommendMainProp;
		if (hasRecommendMainProp && !hasRecommendMainProp2)
		{
			return -1;
		}
		if (hasRecommendMainProp2 && !hasRecommendMainProp)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06012A79 RID: 76409 RVA: 0x0049A8D4 File Offset: 0x00498AD4
	private int SortBySubProp(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		bool hasRecommendSubProp = this.SortMetricCache[a.GetUniqueId()].HasRecommendSubProp;
		bool hasRecommendSubProp2 = this.SortMetricCache[b.GetUniqueId()].HasRecommendSubProp;
		if (hasRecommendSubProp && !hasRecommendSubProp2)
		{
			return -1;
		}
		if (hasRecommendSubProp2 && !hasRecommendSubProp)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06012A7A RID: 76410 RVA: 0x0049A920 File Offset: 0x00498B20
	private int SortBySubPropRecommendCount(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(roleId, a.GetCost());
		VisionRecommendModel.<>c__DisplayClass37_0 CS$<>8__locals1;
		CS$<>8__locals1.subRecommend = ((roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetSubAttrRecommendInfo() : null);
		if (CS$<>8__locals1.subRecommend == null || CS$<>8__locals1.subRecommend.Count == 0)
		{
			return 0;
		}
		int num = VisionRecommendModel.<SortBySubPropRecommendCount>g__CountMatch|37_0(this.SortMetricCache[a.GetUniqueId()].SubPropConfigs, ref CS$<>8__locals1);
		return VisionRecommendModel.<SortBySubPropRecommendCount>g__CountMatch|37_0(this.SortMetricCache[b.GetUniqueId()].SubPropConfigs, ref CS$<>8__locals1) - num;
	}

	// Token: 0x06012A7B RID: 76411 RVA: 0x0049A9A6 File Offset: 0x00498BA6
	private int SortByLevel(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		return b.GetPhantomLevel() - a.GetPhantomLevel();
	}

	// Token: 0x06012A7C RID: 76412 RVA: 0x0049A9B8 File Offset: 0x00498BB8
	private int SortByEquipState(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		bool flag = equipIdNow.Contains(a.GetUniqueId());
		bool flag2 = equipIdNow.Contains(b.GetUniqueId());
		if (flag && !flag2)
		{
			return -1;
		}
		if (flag2 && !flag)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06012A7D RID: 76413 RVA: 0x0049A9F2 File Offset: 0x00498BF2
	private int SortByConfigId(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		return b.GetConfigId(false) - a.GetConfigId(false);
	}

	// Token: 0x06012A7E RID: 76414 RVA: 0x0049AA04 File Offset: 0x00498C04
	private int GetGroupSpecialValue(PhantomBattleData data, int fetterGroupId, int? subGroupId)
	{
		int fetterGroupId2 = data.GetFetterGroupId();
		if (fetterGroupId2 == fetterGroupId)
		{
			return 2;
		}
		int num = fetterGroupId2;
		int? num2 = subGroupId;
		if (num == num2.GetValueOrDefault() & num2 != null)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06012A7F RID: 76415 RVA: 0x0049AA38 File Offset: 0x00498C38
	private int SortByGroupSpecial(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		int groupSpecialValue = this.GetGroupSpecialValue(a, fetterGroupId, subGroupId);
		return this.GetGroupSpecialValue(b, fetterGroupId, subGroupId) - groupSpecialValue;
	}

	// Token: 0x06012A80 RID: 76416 RVA: 0x0049AA60 File Offset: 0x00498C60
	private int SortByCost(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		int cost = a.GetCost();
		return b.GetCost() - cost;
	}

	// Token: 0x06012A81 RID: 76417 RVA: 0x0049AA7C File Offset: 0x00498C7C
	private int SortByGetTime(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		return b.GetIncrId() - a.GetIncrId();
	}

	// Token: 0x06012A82 RID: 76418 RVA: 0x0049AA8C File Offset: 0x00498C8C
	private int SortByMainPropUsage(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		int mainPropUsage = this.SortMetricCache[a.GetUniqueId()].MainPropUsage;
		int mainPropUsage2 = this.SortMetricCache[b.GetUniqueId()].MainPropUsage;
		if (mainPropUsage == 0 && mainPropUsage2 == 0)
		{
			return 0;
		}
		return mainPropUsage2 - mainPropUsage;
	}

	// Token: 0x06012A83 RID: 76419 RVA: 0x0049AAD4 File Offset: 0x00498CD4
	private int SortBySubPropUsage(PhantomBattleData a, PhantomBattleData b, int roleId, int fetterGroupId, IReadOnlyList<int> equipIdNow, int? subGroupId)
	{
		int subPropUsage = this.SortMetricCache[a.GetUniqueId()].SubPropUsage;
		int subPropUsage2 = this.SortMetricCache[b.GetUniqueId()].SubPropUsage;
		if (subPropUsage == 0 && subPropUsage2 == 0)
		{
			return 0;
		}
		return subPropUsage2 - subPropUsage;
	}

	// Token: 0x06012A84 RID: 76420 RVA: 0x0049AB1C File Offset: 0x00498D1C
	private int CalculateAttrUsageSum(List<int> attrIds, List<AttrRecommendInfo> recommendList)
	{
		if (attrIds.Count == 0 || recommendList.Count == 0)
		{
			return 0;
		}
		int num = 0;
		using (List<int>.Enumerator enumerator = attrIds.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int attrId = enumerator.Current;
				AttrRecommendInfo attrRecommendInfo = recommendList.Find((AttrRecommendInfo item) => item.GetAttrId() == attrId);
				if (attrRecommendInfo != null)
				{
					num += attrRecommendInfo.GetUsage();
				}
			}
		}
		return num;
	}

	// Token: 0x06012A85 RID: 76421 RVA: 0x0049ABA4 File Offset: 0x00498DA4
	private List<int> GetMainAttrIdsFromPhantom(PhantomBattleData phantom)
	{
		List<Aki.Protocol.PhantomPropInfo> phantomMainProp = phantom.GetPhantomMainProp();
		if (phantomMainProp.Count == 0)
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in phantomMainProp)
		{
			int phantomPropId = phantomPropInfo.PhantomPropId;
			if (phantomPropId != 0)
			{
				PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropId);
				if (phantomMainPropertyItemId.PropId == 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Phantom;
					ELogAuthor author = ELogAuthor.LJ;
					string message = "获取幻象主属性配置失败，请检查配置表";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mainPropId", phantomPropId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					list.Add(phantomMainPropertyItemId.PropId);
				}
			}
		}
		return list;
	}

	// Token: 0x06012A86 RID: 76422 RVA: 0x0049AC64 File Offset: 0x00498E64
	private List<int> GetSubAttrIdsFromPhantom(PhantomBattleData phantom)
	{
		List<Aki.Protocol.PhantomPropInfo> phantomSubProp = phantom.GetPhantomSubProp();
		List<int> list = new List<int>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in phantomSubProp)
		{
			int phantomPropId = phantomPropInfo.PhantomPropId;
			if (phantomPropId != 0)
			{
				PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropId);
				if (phantomSubPropertyById.PropId != 0)
				{
					list.Add(phantomSubPropertyById.PropId);
				}
			}
		}
		return list;
	}

	// Token: 0x06012A87 RID: 76423 RVA: 0x0049ACE4 File Offset: 0x00498EE4
	private void SortPhantomByRule(List<PhantomBattleData> dataList, List<TPhantomSortFunction> ruleList, int roleId, int fetterGroupId, int? subGroupId)
	{
		List<int> uniqueIdListNow = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList();
		this.BuildSortMetricCache(dataList, roleId);
		dataList.Sort(delegate(PhantomBattleData aData, PhantomBattleData bData)
		{
			foreach (TPhantomSortFunction tphantomSortFunction in ruleList)
			{
				int num = tphantomSortFunction(aData, bData, roleId, fetterGroupId, uniqueIdListNow, subGroupId);
				if (num != 0)
				{
					return num;
				}
			}
			return 0;
		});
		this.SortMetricCache.Clear();
	}

	// Token: 0x06012A88 RID: 76424 RVA: 0x0049AD5C File Offset: 0x00498F5C
	private void BuildSortMetricCache(List<PhantomBattleData> dataList, int roleId)
	{
		this.SortMetricCache.Clear();
		foreach (PhantomBattleData phantomBattleData in dataList)
		{
			VisionAttrRecommendInfo roleCostAttrRecommendInfo = this.GetRoleCostAttrRecommendInfo(roleId, phantomBattleData.GetCost());
			List<AttrRecommendInfo> list = ((roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetMainAttrRecommendInfo() : null) ?? new List<AttrRecommendInfo>();
			List<AttrRecommendInfo> list2 = ((roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetSubAttrRecommendInfo() : null) ?? new List<AttrRecommendInfo>();
			List<ValueTuple<int, int>> list3 = new List<ValueTuple<int, int>>();
			foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in phantomBattleData.GetPhantomSubProp())
			{
				PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo.PhantomPropId);
				list3.Add(new ValueTuple<int, int>(phantomSubPropertyById.AddType, phantomSubPropertyById.PropId));
			}
			bool hasRecommendMainProp = false;
			foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo2 in phantomBattleData.GetPhantomMainProp())
			{
				PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropInfo2.PhantomPropId);
				bool flag = false;
				foreach (AttrRecommendInfo attrRecommendInfo in list)
				{
					if (phantomMainPropertyItemId.AddType == attrRecommendInfo.GetAddType() && phantomMainPropertyItemId.PropId == attrRecommendInfo.GetAttrId())
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					hasRecommendMainProp = true;
					break;
				}
			}
			bool flag2 = false;
			foreach (ValueTuple<int, int> valueTuple in list3)
			{
				foreach (AttrRecommendInfo attrRecommendInfo2 in list2)
				{
					if (valueTuple.Item1 == attrRecommendInfo2.GetAddType() && valueTuple.Item2 == attrRecommendInfo2.GetAttrId())
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					break;
				}
			}
			int mainPropUsage = this.CalculateAttrUsageSum(this.GetMainAttrIdsFromPhantom(phantomBattleData), list);
			int subPropUsage = this.CalculateAttrUsageSum(this.GetSubAttrIdsFromPhantom(phantomBattleData), list2);
			this.SortMetricCache[phantomBattleData.GetUniqueId()] = new PhantomSortMetric
			{
				HasRecommendMainProp = hasRecommendMainProp,
				HasRecommendSubProp = flag2,
				MainPropUsage = mainPropUsage,
				SubPropUsage = subPropUsage,
				SubPropConfigs = list3
			};
		}
	}

	// Token: 0x06012A89 RID: 76425 RVA: 0x0049B064 File Offset: 0x00499264
	public List<VisionFetterDescData> GetFetterDescByRecommendInfo(VisionFetterRecommendInfo info)
	{
		List<VisionFetterDescData> list = new List<VisionFetterDescData>();
		foreach (IVisionFetterCount visionFetterCount in info.GetFetterCountList())
		{
			list.Add(new VisionFetterDescData
			{
				Key = visionFetterCount.Count,
				Value = visionFetterCount.FetterId
			});
		}
		return list;
	}

	// Token: 0x06012A8A RID: 76426 RVA: 0x0049B0DC File Offset: 0x004992DC
	private void TryGetThreeGroupRecommendList(int roleId, List<IVisionFetterCount> fetterList, int[] uniqueIdList)
	{
		int fetterMainGroup = 0;
		int num = 0;
		int num2 = 0;
		foreach (IVisionFetterCount visionFetterCount in fetterList)
		{
			if (visionFetterCount.Count == 1)
			{
				fetterMainGroup = visionFetterCount.GroupId;
			}
			else if (num == 0)
			{
				num = visionFetterCount.GroupId;
			}
			else if (num2 == 0)
			{
				num2 = visionFetterCount.GroupId;
			}
		}
		this.GetThreeRecommendEquipUniqueIdList(roleId, fetterMainGroup, num, num2, uniqueIdList);
	}

	// Token: 0x06012A8B RID: 76427 RVA: 0x0049B164 File Offset: 0x00499364
	private int[] GetThreeRecommendEquipUniqueIdList(int roleId, int fetterMainGroup, int fetterGroupIdA, int fetterGroupIdB, int[] uniqueIdList)
	{
		List<PhantomBattleData> allNotEquipPhantomList = this.GetAllNotEquipPhantomList(roleId);
		if (allNotEquipPhantomList == null)
		{
			return uniqueIdList;
		}
		int num = 0;
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		this.SortPhantomByRule(allNotEquipPhantomList, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByFetterGroupId),
			new TPhantomSortFunction(this.SortByMainProp),
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortBySubPropRecommendCount),
			new TPhantomSortFunction(this.SortByEquipState),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, fetterMainGroup, null);
		int costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(uniqueIdList, 4, allNotEquipPhantomList, true, new List<int>());
		if (costRecommendEquipUniqueId != 0)
		{
			num += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
			uniqueIdList[0] = costRecommendEquipUniqueId;
		}
		if (num >= maxCost)
		{
			return uniqueIdList;
		}
		List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>> list = this.BuildFetterCostPlanList();
		PhantomPools pools = this.CreateSortedPhantomPools(roleId, fetterGroupIdA, fetterGroupIdB, allNotEquipPhantomList);
		FetterPlanResult fetterPlanResult = null;
		foreach (ValueTuple<Dictionary<int, int>, Dictionary<int, int>> valueTuple in list)
		{
			Dictionary<int, int> item = valueTuple.Item1;
			Dictionary<int, int> item2 = valueTuple.Item2;
			FetterPlanResult fetterPlanResult2 = this.EvaluateSingleFetterPlan(item, item2, pools, costRecommendEquipUniqueId, num, maxCost);
			if (this.IsCandidatePlanBetter(fetterPlanResult2, fetterPlanResult, roleId))
			{
				fetterPlanResult = fetterPlanResult2;
			}
		}
		if (fetterPlanResult != null)
		{
			for (int i = 0; i < fetterPlanResult.SelectedList.Count; i++)
			{
				if (i < uniqueIdList.Length)
				{
					uniqueIdList[i] = fetterPlanResult.SelectedList[i];
				}
			}
		}
		return uniqueIdList;
	}

	// Token: 0x06012A8C RID: 76428 RVA: 0x0049B314 File Offset: 0x00499514
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>> BuildFetterCostPlanList()
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		if (calabashLevel < 2)
		{
			return new List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>>
			{
				new ValueTuple<Dictionary<int, int>, Dictionary<int, int>>(this.CostMap3012, this.CostMap3012)
			};
		}
		if (calabashLevel < 9)
		{
			return new List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>>
			{
				new ValueTuple<Dictionary<int, int>, Dictionary<int, int>>(this.CostMap3111, this.CostMap3012),
				new ValueTuple<Dictionary<int, int>, Dictionary<int, int>>(this.CostMap3012, this.CostMap3111)
			};
		}
		return new List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>>
		{
			new ValueTuple<Dictionary<int, int>, Dictionary<int, int>>(this.CostMap3111, this.CostMap3111),
			new ValueTuple<Dictionary<int, int>, Dictionary<int, int>>(this.CostMap3210, this.CostMap3012),
			new ValueTuple<Dictionary<int, int>, Dictionary<int, int>>(this.CostMap3012, this.CostMap3210)
		};
	}

	// Token: 0x06012A8D RID: 76429 RVA: 0x0049B3D0 File Offset: 0x004995D0
	private PhantomPools CreateSortedPhantomPools(int roleId, int fetterGroupIdA, int fetterGroupIdB, List<PhantomBattleData> notEquipPhantomList)
	{
		List<PhantomBattleData> list = notEquipPhantomList.FindAll((PhantomBattleData data) => data.GetFetterGroupId() == fetterGroupIdA);
		List<PhantomBattleData> list2 = list.FindAll((PhantomBattleData data) => data.GetIfHaveRecommendMainProp(roleId));
		List<PhantomBattleData> list3 = list.FindAll((PhantomBattleData data) => !data.GetIfHaveRecommendMainProp(roleId));
		List<PhantomBattleData> list4 = notEquipPhantomList.FindAll((PhantomBattleData data) => data.GetFetterGroupId() == fetterGroupIdB);
		List<PhantomBattleData> list5 = list4.FindAll((PhantomBattleData data) => data.GetIfHaveRecommendMainProp(roleId));
		List<PhantomBattleData> list6 = list4.FindAll((PhantomBattleData data) => !data.GetIfHaveRecommendMainProp(roleId));
		List<PhantomBattleData> list7 = notEquipPhantomList.FindAll((PhantomBattleData data) => data.GetFetterGroupId() != fetterGroupIdA && data.GetFetterGroupId() != fetterGroupIdB);
		this.SortPhantomByRule(list2, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByMainPropUsage),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortBySubPropRecommendCount),
			new TPhantomSortFunction(this.SortBySubPropUsage),
			new TPhantomSortFunction(this.SortByEquipState),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, fetterGroupIdA, null);
		this.SortPhantomByRule(list5, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByMainPropUsage),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortBySubPropRecommendCount),
			new TPhantomSortFunction(this.SortBySubPropUsage),
			new TPhantomSortFunction(this.SortByEquipState),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, fetterGroupIdB, null);
		this.SortPhantomByRule(list3, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortBySubPropRecommendCount),
			new TPhantomSortFunction(this.SortBySubPropUsage),
			new TPhantomSortFunction(this.SortByEquipState),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, fetterGroupIdA, null);
		this.SortPhantomByRule(list6, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortBySubPropRecommendCount),
			new TPhantomSortFunction(this.SortBySubPropUsage),
			new TPhantomSortFunction(this.SortByEquipState),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, fetterGroupIdB, null);
		this.SortPhantomByRule(list7, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, 0, null);
		return new PhantomPools
		{
			HighGroupA = list2,
			MidGroupA = list3,
			HighGroupB = list5,
			MidGroupB = list6,
			GroupC = list7
		};
	}

	// Token: 0x06012A8E RID: 76430 RVA: 0x0049B75C File Offset: 0x0049995C
	private FetterPlanResult EvaluateSingleFetterPlan(Dictionary<int, int> costMapA, Dictionary<int, int> costMapB, PhantomPools pools, int currentSelectUniqueId, int currentSelectCost, int maxCost)
	{
		int num = 0;
		List<int> list = new List<int>
		{
			currentSelectUniqueId
		};
		int num2 = currentSelectCost;
		foreach (ValueTuple<Dictionary<int, int>, List<PhantomBattleData>, List<PhantomBattleData>> valueTuple in new List<ValueTuple<Dictionary<int, int>, List<PhantomBattleData>, List<PhantomBattleData>>>
		{
			new ValueTuple<Dictionary<int, int>, List<PhantomBattleData>, List<PhantomBattleData>>(costMapA, pools.HighGroupA, pools.MidGroupA),
			new ValueTuple<Dictionary<int, int>, List<PhantomBattleData>, List<PhantomBattleData>>(costMapB, pools.HighGroupB, pools.MidGroupB)
		})
		{
			Dictionary<int, int> item = valueTuple.Item1;
			List<PhantomBattleData> item2 = valueTuple.Item2;
			List<PhantomBattleData> item3 = valueTuple.Item3;
			foreach (KeyValuePair<int, int> keyValuePair in item)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				int num3 = 0;
				while (num3 < value && num2 < maxCost)
				{
					int costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(list.ToArray(), key, item2, true, new List<int>());
					if (costRecommendEquipUniqueId != 0)
					{
						num++;
						num2 += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
						list.Add(costRecommendEquipUniqueId);
					}
					else
					{
						costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(list.ToArray(), key, item3, true, new List<int>());
						if (costRecommendEquipUniqueId != 0)
						{
							num2 += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
							list.Add(costRecommendEquipUniqueId);
						}
						else
						{
							costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(list.ToArray(), key, pools.GroupC, true, new List<int>());
							if (costRecommendEquipUniqueId != 0)
							{
								num -= 10;
								num2 += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
								list.Add(costRecommendEquipUniqueId);
							}
						}
					}
					num3++;
				}
			}
		}
		return new FetterPlanResult
		{
			Score = num,
			SelectedList = list
		};
	}

	// Token: 0x06012A8F RID: 76431 RVA: 0x0049B95C File Offset: 0x00499B5C
	private bool IsCandidatePlanBetter(FetterPlanResult candidate, [Nullable(2)] FetterPlanResult best, int roleId)
	{
		if (best == null)
		{
			return true;
		}
		if (candidate.Score != best.Score)
		{
			return candidate.Score > best.Score;
		}
		ValueTuple<int, int, int> valueTuple = this.ComputePlanTieMetrics(candidate.SelectedList, roleId);
		ValueTuple<int, int, int> valueTuple2 = this.ComputePlanTieMetrics(best.SelectedList, roleId);
		if (valueTuple.Item1 != valueTuple2.Item1)
		{
			return valueTuple.Item1 > valueTuple2.Item1;
		}
		if (valueTuple.Item2 != valueTuple2.Item2)
		{
			return valueTuple.Item2 > valueTuple2.Item2;
		}
		return valueTuple.Item3 != valueTuple2.Item3 && valueTuple.Item3 > valueTuple2.Item3;
	}

	// Token: 0x06012A90 RID: 76432 RVA: 0x0049BA00 File Offset: 0x00499C00
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"FiveStarCount",
		"TotalLevel",
		"SubPropHitCount"
	})]
	private ValueTuple<int, int, int> ComputePlanTieMetrics([Nullable(1)] List<int> selectedList, int roleId)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (int num4 in selectedList)
		{
			if (num4 > 0)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num4);
				if (phantomBattleData != null)
				{
					if (phantomBattleData.GetQuality() == 5)
					{
						num++;
					}
					num2 += phantomBattleData.GetPhantomLevel();
					num3 += this.GetPhantomSubPropRecommendHitCount(phantomBattleData, roleId);
				}
			}
		}
		return new ValueTuple<int, int, int>(num, num2, num3);
	}

	// Token: 0x06012A91 RID: 76433 RVA: 0x0049BA94 File Offset: 0x00499C94
	private int GetPhantomSubPropRecommendHitCount(PhantomBattleData data, int roleId)
	{
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = this.GetRoleCostAttrRecommendInfo(roleId, data.GetCost());
		List<AttrRecommendInfo> list = (roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetSubAttrRecommendInfo() : null;
		if (list == null || list.Count == 0)
		{
			return 0;
		}
		int num = 0;
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in data.GetPhantomSubProp())
		{
			PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo.PhantomPropId);
			foreach (AttrRecommendInfo attrRecommendInfo in list)
			{
				if (phantomSubPropertyById.AddType == attrRecommendInfo.GetAddType() && phantomSubPropertyById.PropId == attrRecommendInfo.GetAttrId())
				{
					num++;
					break;
				}
			}
		}
		return num;
	}

	// Token: 0x06012A92 RID: 76434 RVA: 0x0049BB7C File Offset: 0x00499D7C
	private int[] GetNewNormalRecommendEquipUniqueIdList(int roleId, int fetterGroupId, int firstSelectUniqueId, int currentSelectCost, VisionFetterRecommendInfo recommendInfo, List<PhantomBattleData> notEquipPhantomList, int[] uniqueIdList)
	{
		if (firstSelectUniqueId == 0)
		{
			return uniqueIdList;
		}
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		int num = currentSelectCost;
		int cost = PhantomBattleModel.Instance.GetPhantomBattleData(firstSelectUniqueId).GetCost();
		List<List<int>> otherVisionCostPlans = this.GetOtherVisionCostPlans(cost, recommendInfo);
		if (otherVisionCostPlans.Count == 0)
		{
			return uniqueIdList;
		}
		List<int> list = otherVisionCostPlans[0];
		this.SortPhantomByRule(notEquipPhantomList, new List<TPhantomSortFunction>
		{
			new TPhantomSortFunction(this.SortByFetterGroupId),
			new TPhantomSortFunction(this.SortByQuality),
			new TPhantomSortFunction(this.SortByMainProp),
			new TPhantomSortFunction(this.SortByLevel),
			new TPhantomSortFunction(this.SortBySubPropRecommendCount),
			new TPhantomSortFunction(this.SortBySubPropUsage),
			new TPhantomSortFunction(this.SortByGetTime)
		}, roleId, fetterGroupId, null);
		int num2 = uniqueIdList.Length;
		int num3 = 1;
		while (num3 < num2 && num < maxCost && num3 - 1 < list.Count)
		{
			int cost2 = list[num3 - 1];
			int costRecommendEquipUniqueId = this.GetCostRecommendEquipUniqueId(uniqueIdList, cost2, notEquipPhantomList, true, new List<int>());
			if (costRecommendEquipUniqueId != 0)
			{
				num += PhantomBattleModel.Instance.GetPhantomBattleData(costRecommendEquipUniqueId).GetCost();
				uniqueIdList[num3] = costRecommendEquipUniqueId;
			}
			num3++;
		}
		return uniqueIdList;
	}

	// Token: 0x06012A93 RID: 76435 RVA: 0x0049BCD0 File Offset: 0x00499ED0
	public int[] GetNewRecommendEquipUniqueIdList(int roleId, int fetterGroupId, int fetterGroupSubId, int firstSelectUniqueId, int currentSelectCost, List<PhantomBattleData> notEquipPhantomList, int[] uniqueIdList, VisionFetterRecommendInfo recommendInfo)
	{
		if (firstSelectUniqueId == 0)
		{
			return uniqueIdList;
		}
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		bool isSpecial = false;
		if (firstSelectUniqueId != 0)
		{
			int fetterGroupId2 = PhantomBattleModel.Instance.GetPhantomBattleData(firstSelectUniqueId).GetFetterGroupId();
			isSpecial = (PhantomBattleConfig.Instance.GetFetterGroupById(fetterGroupId2).FetterType == 1);
		}
		int cost = PhantomBattleModel.Instance.GetPhantomBattleData(firstSelectUniqueId).GetCost();
		List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>> list = this.BuildSpecialFetterCostPlanList(cost, isSpecial, fetterGroupId, recommendInfo);
		if (list.Count == 0)
		{
			return uniqueIdList;
		}
		PhantomPools pools = this.CreateSortedPhantomPools(roleId, fetterGroupId, fetterGroupSubId, notEquipPhantomList);
		FetterPlanResult fetterPlanResult = null;
		foreach (ValueTuple<Dictionary<int, int>, Dictionary<int, int>> valueTuple in list)
		{
			Dictionary<int, int> item = valueTuple.Item1;
			Dictionary<int, int> item2 = valueTuple.Item2;
			FetterPlanResult fetterPlanResult2 = this.EvaluateSingleFetterPlan(item, item2, pools, firstSelectUniqueId, currentSelectCost, maxCost);
			if (this.IsCandidatePlanBetter(fetterPlanResult2, fetterPlanResult, roleId))
			{
				fetterPlanResult = fetterPlanResult2;
			}
		}
		if (fetterPlanResult != null)
		{
			for (int i = 0; i < fetterPlanResult.SelectedList.Count; i++)
			{
				if (i < uniqueIdList.Length)
				{
					uniqueIdList[i] = fetterPlanResult.SelectedList[i];
				}
			}
		}
		return uniqueIdList;
	}

	// Token: 0x06012A94 RID: 76436 RVA: 0x0049BE04 File Offset: 0x0049A004
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>> BuildSpecialFetterCostPlanList(int firstCost, bool isSpecial, int fetterGroupId, VisionFetterRecommendInfo recommendInfo)
	{
		List<IVisionFetterCount> fetterCountList = recommendInfo.GetFetterCountList();
		int num = 0;
		foreach (IVisionFetterCount visionFetterCount in fetterCountList)
		{
			if (visionFetterCount.GroupId == fetterGroupId)
			{
				num = visionFetterCount.Count;
				break;
			}
		}
		int num2 = num - ((isSpecial > false) ? 1 : 0);
		List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>> list = new List<ValueTuple<Dictionary<int, int>, Dictionary<int, int>>>();
		if (num2 < 0)
		{
			return list;
		}
		List<List<int>> otherVisionCostPlans = this.GetOtherVisionCostPlans(firstCost, recommendInfo);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (List<int> list2 in otherVisionCostPlans)
		{
			if (num2 <= list2.Count)
			{
				foreach (ValueTuple<List<int>, List<int>> valueTuple in this.EnumerateCostSplits(list2, num2))
				{
					List<int> item = valueTuple.Item1;
					List<int> item2 = valueTuple.Item2;
					string item3 = string.Join<int>(",", item) + "|" + string.Join<int>(",", item2);
					if (!hashSet.Contains(item3))
					{
						hashSet.Add(item3);
						list.Add(new ValueTuple<Dictionary<int, int>, Dictionary<int, int>>(this.CostArrayToMap(item), this.CostArrayToMap(item2)));
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06012A95 RID: 76437 RVA: 0x0049BF78 File Offset: 0x0049A178
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private List<ValueTuple<List<int>, List<int>>> EnumerateCostSplits(List<int> costs, int aSlotCount)
	{
		VisionRecommendModel.<>c__DisplayClass66_0 CS$<>8__locals1;
		CS$<>8__locals1.aSlotCount = aSlotCount;
		CS$<>8__locals1.costs = costs;
		CS$<>8__locals1.n = CS$<>8__locals1.costs.Count;
		CS$<>8__locals1.result = new List<ValueTuple<List<int>, List<int>>>();
		CS$<>8__locals1.seen = new HashSet<string>();
		VisionRecommendModel.<EnumerateCostSplits>g__Pick|66_0(0, new List<int>(), ref CS$<>8__locals1);
		return CS$<>8__locals1.result;
	}

	// Token: 0x06012A96 RID: 76438 RVA: 0x0049BFD4 File Offset: 0x0049A1D4
	private Dictionary<int, int> CostArrayToMap(List<int> costs)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int key in costs)
		{
			int num;
			if (!dictionary.TryGetValue(key, out num))
			{
				num = 0;
			}
			dictionary[key] = num + 1;
		}
		return dictionary;
	}

	// Token: 0x17001833 RID: 6195
	// (get) Token: 0x06012A97 RID: 76439 RVA: 0x0049C03C File Offset: 0x0049A23C
	public static VisionRecommendModel Instance
	{
		get
		{
			return VisionRecommendModel._Instance;
		}
	}

	// Token: 0x06012A98 RID: 76440 RVA: 0x0049C043 File Offset: 0x0049A243
	public static VisionRecommendModel GetOrCreateInstance()
	{
		if (VisionRecommendModel._Instance == null)
		{
			VisionRecommendModel.CreateInstance();
		}
		return VisionRecommendModel._Instance;
	}

	// Token: 0x06012A99 RID: 76441 RVA: 0x0049C057 File Offset: 0x0049A257
	public static bool CreateInstance()
	{
		if (VisionRecommendModel._Instance != null)
		{
			return true;
		}
		VisionRecommendModel._Instance = new VisionRecommendModel();
		return true;
	}

	// Token: 0x06012A9A RID: 76442 RVA: 0x0049C06D File Offset: 0x0049A26D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012A9B RID: 76443 RVA: 0x0049C06F File Offset: 0x0049A26F
	public static void ResetStaticDefaultValue()
	{
		VisionRecommendModel._Instance = null;
	}

	// Token: 0x06012A9C RID: 76444 RVA: 0x0049C077 File Offset: 0x0049A277
	static VisionRecommendModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionRecommendModel.CreateStaticDefaultValue), new Action(VisionRecommendModel.ResetStaticDefaultValue));
	}

	// Token: 0x06012A9E RID: 76446 RVA: 0x0049C0A0 File Offset: 0x0049A2A0
	[CompilerGenerated]
	internal static int <SortBySubPropRecommendCount>g__CountMatch|37_0([TupleElementNames(new string[]
	{
		"AddType",
		"PropId"
	})] [Nullable(new byte[]
	{
		1,
		0
	})] List<ValueTuple<int, int>> configs, ref VisionRecommendModel.<>c__DisplayClass37_0 A_1)
	{
		int num = 0;
		foreach (ValueTuple<int, int> valueTuple in configs)
		{
			foreach (AttrRecommendInfo attrRecommendInfo in A_1.subRecommend)
			{
				if (valueTuple.Item1 == attrRecommendInfo.GetAddType() && valueTuple.Item2 == attrRecommendInfo.GetAttrId())
				{
					num++;
					break;
				}
			}
		}
		return num;
	}

	// Token: 0x06012A9F RID: 76447 RVA: 0x0049C14C File Offset: 0x0049A34C
	[CompilerGenerated]
	internal static void <EnumerateCostSplits>g__Pick|66_0(int start, List<int> picked, ref VisionRecommendModel.<>c__DisplayClass66_0 A_2)
	{
		if (picked.Count == A_2.aSlotCount)
		{
			HashSet<int> hashSet = new HashSet<int>(picked);
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < A_2.n; i++)
			{
				if (hashSet.Contains(i))
				{
					list.Add(A_2.costs[i]);
				}
				else
				{
					list2.Add(A_2.costs[i]);
				}
			}
			list.Sort((int x, int y) => y - x);
			list2.Sort((int x, int y) => y - x);
			string item = string.Join<int>(",", list) + "|" + string.Join<int>(",", list2);
			if (!A_2.seen.Contains(item))
			{
				A_2.seen.Add(item);
				A_2.result.Add(new ValueTuple<List<int>, List<int>>(list, list2));
			}
			return;
		}
		for (int j = start; j < A_2.n; j++)
		{
			picked.Add(j);
			VisionRecommendModel.<EnumerateCostSplits>g__Pick|66_0(j + 1, picked, ref A_2);
			picked.RemoveAt(picked.Count - 1);
		}
	}

	// Token: 0x04008C90 RID: 35984
	private Dictionary<int, int> CostMap3012;

	// Token: 0x04008C91 RID: 35985
	private Dictionary<int, int> CostMap3111;

	// Token: 0x04008C92 RID: 35986
	private Dictionary<int, int> CostMap3210;

	// Token: 0x04008C93 RID: 35987
	private const int FIRST_VISION_COST_LIMIT = 4;

	// Token: 0x04008C94 RID: 35988
	private const int CALABASH_LOW_LEVEL = 2;

	// Token: 0x04008C95 RID: 35989
	private Dictionary<int, List<VisionFetterRecommendInfo>> RoleFetterRecommendMap;

	// Token: 0x04008C96 RID: 35990
	private Dictionary<int, List<VisionFetterRecommendInfo>> RoleSystemFetterRecommendMap;

	// Token: 0x04008C97 RID: 35991
	private Dictionary<int, List<VisionFetterRecommendInfo>> RoleUsageFetterRecommendMap;

	// Token: 0x04008C98 RID: 35992
	private Dictionary<int, Dictionary<int, VisionAttrRecommendInfo>> RoleCostAttrRecommendMap;

	// Token: 0x04008C99 RID: 35993
	private Dictionary<int, PhantomSortMetric> SortMetricCache;

	// Token: 0x04008C9A RID: 35994
	public List<VisionSelectRecommendData> CurrentSelectMainAttrArray;

	// Token: 0x04008C9B RID: 35995
	public List<VisionSelectRecommendData> CurrentSelectSubAttrArray;

	// Token: 0x04008C9C RID: 35996
	[Nullable(2)]
	public VisionMainSelectPhantomData CurrentMainPhantom;

	// Token: 0x04008C9D RID: 35997
	private List<TPhantomSortFunction> NormalSortFuncList;

	// Token: 0x04008C9E RID: 35998
	private List<TPhantomSortFunction> SpecialSortFuncList;

	// Token: 0x04008C9F RID: 35999
	[Nullable(2)]
	private static VisionRecommendModel _Instance;
}
