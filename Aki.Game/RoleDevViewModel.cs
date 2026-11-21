using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02001DA0 RID: 7584
[NullableContext(2)]
[Nullable(0)]
public class RoleDevViewModel
{
	// Token: 0x06012C91 RID: 76945 RVA: 0x00585CCC File Offset: 0x00583ECC
	public void InitHotRoleDataList()
	{
		this.HotRoleDataListInternal.Clear();
		IReadOnlyList<IRoleDevProsConfig> allRoleDevProsListConfig = RoleDevConfig.Instance.GetAllRoleDevProsListConfig();
		foreach (IRoleDevProsConfig roleDevProsConfig in allRoleDevProsListConfig)
		{
			if (roleDevProsConfig.TypeId != 6 && roleDevProsConfig.TypeId != 0)
			{
				RoleDevUtils.IsProspectTimeValid(roleDevProsConfig.Id);
				RoleDevUtils.IsGachaValid(roleDevProsConfig.GachaId);
			}
		}
		List<int> list = new List<int>();
		foreach (IRoleDevProsConfig roleDevProsConfig2 in allRoleDevProsListConfig)
		{
			if (roleDevProsConfig2.TypeId != 6 && roleDevProsConfig2.TypeId != 0)
			{
				bool flag = RoleDevUtils.IsProspectTimeValid(roleDevProsConfig2.Id);
				bool flag2 = RoleDevUtils.IsGachaValid(roleDevProsConfig2.GachaId);
				if (flag || flag2)
				{
					list.Add(roleDevProsConfig2.Id);
				}
			}
		}
		List<RoleDisplayModelBase> list2 = new List<RoleDisplayModelBase>();
		foreach (int roleId in list)
		{
			list2.Add(RoleDisplayModelFactory.Instance.BuildRoleDisplayModel(roleId, false));
		}
		this.HotRoleDataListInternal.AddRange(list2);
		this.SortRoleDisplayModelList();
	}

	// Token: 0x06012C92 RID: 76946 RVA: 0x00585E2C File Offset: 0x0058402C
	private void SortRoleDisplayModelList()
	{
		this.HotRoleDataListInternal.Sort((RoleDisplayModelBase a, RoleDisplayModelBase b) => RoleDevViewModel.<SortRoleDisplayModelList>g__GetSortId|11_0(a) - RoleDevViewModel.<SortRoleDisplayModelList>g__GetSortId|11_0(b));
	}

	// Token: 0x06012C93 RID: 76947 RVA: 0x00585E58 File Offset: 0x00584058
	[NullableContext(1)]
	public void SetRoleDataList(List<RoleDataBase> dataList)
	{
		this.RoleDataListInternal = dataList;
	}

	// Token: 0x06012C94 RID: 76948 RVA: 0x00585E64 File Offset: 0x00584064
	public void InitAllDevItemDataByRoleId(int roleId)
	{
		this.RoleDevRoleViewItemDataInternal = RoleDevRoleViewItemDataFactory.Create(roleId);
		this.RoleDevWeaponViewItemDataInternal = RoleDevWeaponViewItemDataFactory.Create(roleId, this);
		this.RoleDevSkillViewItemDataInternal = RoleDevSkillViewItemDataFactory.Create(roleId, this);
		this.RoleDevPhantomViewItemDataInternal = RoleDevPhantomViewItemDataFactory.Create(roleId, this);
		this.CreatedRoleIdSet.Add(roleId);
	}

	// Token: 0x06012C95 RID: 76949 RVA: 0x00585EB4 File Offset: 0x005840B4
	public bool GetRoleSkillPlanState(int roleId)
	{
		bool result;
		if (this.RoleIdToSkillPlanStateMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return RoleDevUtils.GetDefaultSkillPlanByRoleId(roleId);
	}

	// Token: 0x06012C96 RID: 76950 RVA: 0x00585ED9 File Offset: 0x005840D9
	public void SetRoleSkillPlanState(int roleId, bool isPerfectPlan)
	{
		this.RoleIdToSkillPlanStateMap[roleId] = isPerfectPlan;
	}

	// Token: 0x06012C97 RID: 76951 RVA: 0x00585EE8 File Offset: 0x005840E8
	public ERoleDevWeaponTabType GetRoleWeaponTabType(int roleId)
	{
		ERoleDevWeaponTabType result;
		if (this.RoleIdToWeaponTabTypeMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return ERoleDevWeaponTabType.None;
	}

	// Token: 0x06012C98 RID: 76952 RVA: 0x00585F08 File Offset: 0x00584108
	public void SetRoleWeaponTabType(int roleId, ERoleDevWeaponTabType weaponTabType)
	{
		this.RoleIdToWeaponTabTypeMap[roleId] = weaponTabType;
	}

	// Token: 0x06012C99 RID: 76953 RVA: 0x00585F18 File Offset: 0x00584118
	public int GetRoleRecommendPlanId(int roleId)
	{
		int result;
		if (this.RoleIdToRecommendPlanIdMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x06012C9A RID: 76954 RVA: 0x00585F38 File Offset: 0x00584138
	public void SetRoleRecommendPlanId(int roleId, int recommendPlanId)
	{
		this.RoleIdToRecommendPlanIdMap[roleId] = recommendPlanId;
	}

	// Token: 0x17001C62 RID: 7266
	// (get) Token: 0x06012C9B RID: 76955 RVA: 0x00585F47 File Offset: 0x00584147
	[Nullable(1)]
	public List<RoleDataBase> RoleDataList
	{
		[NullableContext(1)]
		get
		{
			return this.RoleDataListInternal;
		}
	}

	// Token: 0x17001C63 RID: 7267
	// (get) Token: 0x06012C9C RID: 76956 RVA: 0x00585F4F File Offset: 0x0058414F
	public RoleDevRoleViewItemDataBase RoleDevRoleViewItemData
	{
		get
		{
			return this.RoleDevRoleViewItemDataInternal;
		}
	}

	// Token: 0x17001C64 RID: 7268
	// (get) Token: 0x06012C9D RID: 76957 RVA: 0x00585F57 File Offset: 0x00584157
	public RoleDevWeaponViewItemDataBase RoleDevWeaponViewItemData
	{
		get
		{
			return this.RoleDevWeaponViewItemDataInternal;
		}
	}

	// Token: 0x17001C65 RID: 7269
	// (get) Token: 0x06012C9E RID: 76958 RVA: 0x00585F5F File Offset: 0x0058415F
	public RoleDevPhantomViewItemDataBase RoleDevPhantomViewItemData
	{
		get
		{
			return this.RoleDevPhantomViewItemDataInternal;
		}
	}

	// Token: 0x17001C66 RID: 7270
	// (get) Token: 0x06012C9F RID: 76959 RVA: 0x00585F67 File Offset: 0x00584167
	public RoleDevSkillViewItemDataBase RoleDevSkillViewItemData
	{
		get
		{
			return this.RoleDevSkillViewItemDataInternal;
		}
	}

	// Token: 0x17001C67 RID: 7271
	// (get) Token: 0x06012CA0 RID: 76960 RVA: 0x00585F6F File Offset: 0x0058416F
	[Nullable(1)]
	public List<RoleDisplayModelBase> HotRoleDataList
	{
		[NullableContext(1)]
		get
		{
			return this.HotRoleDataListInternal;
		}
	}

	// Token: 0x06012CA1 RID: 76961 RVA: 0x00585F77 File Offset: 0x00584177
	public bool CheckRoleIdIsCreated(int roleId)
	{
		return this.CreatedRoleIdSet.Contains(roleId);
	}

	// Token: 0x06012CA3 RID: 76963 RVA: 0x00585FDD File Offset: 0x005841DD
	[NullableContext(1)]
	[CompilerGenerated]
	internal static int <SortRoleDisplayModelList>g__GetSortId|11_0(RoleDisplayModelBase item)
	{
		IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(item.Id);
		if (roleDevProsListConfig == null)
		{
			return int.MaxValue;
		}
		return roleDevProsListConfig.SortId;
	}

	// Token: 0x0400A269 RID: 41577
	[Nullable(1)]
	private List<RoleDataBase> RoleDataListInternal = new List<RoleDataBase>();

	// Token: 0x0400A26A RID: 41578
	[Nullable(1)]
	private readonly List<RoleDisplayModelBase> HotRoleDataListInternal = new List<RoleDisplayModelBase>();

	// Token: 0x0400A26B RID: 41579
	private RoleDevRoleViewItemDataBase RoleDevRoleViewItemDataInternal;

	// Token: 0x0400A26C RID: 41580
	private RoleDevWeaponViewItemDataBase RoleDevWeaponViewItemDataInternal;

	// Token: 0x0400A26D RID: 41581
	private RoleDevPhantomViewItemDataBase RoleDevPhantomViewItemDataInternal;

	// Token: 0x0400A26E RID: 41582
	private RoleDevSkillViewItemDataBase RoleDevSkillViewItemDataInternal;

	// Token: 0x0400A26F RID: 41583
	[Nullable(1)]
	private readonly HashSet<int> CreatedRoleIdSet = new HashSet<int>();

	// Token: 0x0400A270 RID: 41584
	[Nullable(1)]
	private readonly Dictionary<int, bool> RoleIdToSkillPlanStateMap = new Dictionary<int, bool>();

	// Token: 0x0400A271 RID: 41585
	[Nullable(1)]
	private readonly Dictionary<int, ERoleDevWeaponTabType> RoleIdToWeaponTabTypeMap = new Dictionary<int, ERoleDevWeaponTabType>();

	// Token: 0x0400A272 RID: 41586
	[Nullable(1)]
	private readonly Dictionary<int, int> RoleIdToRecommendPlanIdMap = new Dictionary<int, int>();
}
