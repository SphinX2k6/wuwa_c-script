using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020018A1 RID: 6305
[NullableContext(1)]
[Nullable(0)]
public class SortLogic
{
	// Token: 0x0600B889 RID: 47241 RVA: 0x0029E2BC File Offset: 0x0029C4BC
	public SortLogic()
	{
		this.DataMapInternal = new Dictionary<ESortDataType, CommonSort>
		{
			{
				ESortDataType.Role,
				new RoleSort()
			},
			{
				ESortDataType.Weapon,
				new WeaponSort()
			},
			{
				ESortDataType.ItemData,
				new ItemSort()
			},
			{
				ESortDataType.Phantom,
				new PhantomSort()
			},
			{
				ESortDataType.Cook,
				new CookSort()
			},
			{
				ESortDataType.Reagent,
				new ComposeSort()
			},
			{
				ESortDataType.Structure,
				new ComposeStructureSort()
			},
			{
				ESortDataType.Purification,
				new ComposePurificationSort()
			},
			{
				ESortDataType.Forging,
				new ForgingSort()
			},
			{
				ESortDataType.Calabash,
				new CalabashCollectSort()
			},
			{
				ESortDataType.AssemblyGrid,
				new AssemblyGridSort()
			},
			{
				ESortDataType.VisionFetter,
				new VisionFetterSort()
			},
			{
				ESortDataType.AdventureGuide,
				new AdventureGuideSort()
			},
			{
				ESortDataType.ComposeExchange,
				new ComposeExchangeSort()
			},
			{
				ESortDataType.Attribute,
				new PhantomSort()
			},
			{
				ESortDataType.FishingItem,
				new FishingItemSort()
			},
			{
				ESortDataType.DangoAbyssPlugin,
				new DangoAbyssPluginItemSort()
			},
			{
				ESortDataType.MonsterHandBook,
				new MonsterHandBookSort()
			},
			{
				ESortDataType.WeaponHandBook,
				new WeaponHandBookSort()
			},
			{
				ESortDataType.WeaponSkinHandBook,
				new WeaponSkinHandBookSort()
			},
			{
				ESortDataType.PinballFormation,
				new PinballFormationSort()
			},
			{
				ESortDataType.PinballWeapon,
				new PinballWeaponSort()
			},
			{
				ESortDataType.PinballRoleSelect,
				new PinballRoleSelectSort()
			},
			{
				ESortDataType.PinballWeaponEquip,
				new PinballWeaponEquipSort()
			}
		};
	}

	// Token: 0x0600B88A RID: 47242 RVA: 0x0029E40C File Offset: 0x0029C60C
	public void SortDataList<[Nullable(2)] T>(List<T> dataList, int configId, SortResultData resultData, params object[] parameters)
	{
		Sort? sortConfig = SortConfig.Instance.GetSortConfig(configId);
		HashSet<int> allSelectRuleSet = resultData.GetAllSelectRuleSet();
		bool isAscending = resultData.GetIsAscending();
		ESortDataType dataId = (ESortDataType)sortConfig.Value.DataId;
		this.SortDataByData<T>(dataList, dataId, allSelectRuleSet, isAscending, parameters);
	}

	// Token: 0x0600B88B RID: 47243 RVA: 0x0029E450 File Offset: 0x0029C650
	public void SortDataByData<[Nullable(2)] T>(List<T> dataList, ESortDataType dataType, HashSet<int> ruleIdSet, bool isAscending, params object[] parameters)
	{
		CommonSort sortClass = this.DataMapInternal[dataType];
		sortClass.InitSortMap();
		dataList.Sort(delegate(T aData, T bData)
		{
			foreach (int ruleId in ruleIdSet)
			{
				TSortResult sortFunctionByRuleId = sortClass.GetSortFunctionByRuleId(ruleId);
				if (sortFunctionByRuleId != null)
				{
					int num = sortFunctionByRuleId(aData, bData, isAscending, parameters);
					if (num != 0)
					{
						return num;
					}
				}
			}
			return 0;
		});
	}

	// Token: 0x0400538F RID: 21391
	private readonly Dictionary<ESortDataType, CommonSort> DataMapInternal;
}
