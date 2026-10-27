using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02002825 RID: 10277
[NullableContext(2)]
[Nullable(0)]
public class RoleDevViewModel
{
	// Token: 0x06015293 RID: 86675 RVA: 0x0055AFB8 File Offset: 0x005591B8
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

	// Token: 0x06015294 RID: 86676 RVA: 0x0055B118 File Offset: 0x00559318
	private void SortRoleDisplayModelList()
	{
		this.HotRoleDataListInternal.Sort((RoleDisplayModelBase a, RoleDisplayModelBase b) => RoleDevViewModel.<SortRoleDisplayModelList>g__GetSortId|11_0(a) - RoleDevViewModel.<SortRoleDisplayModelList>g__GetSortId|11_0(b));
	}

	// Token: 0x06015295 RID: 86677 RVA: 0x0055B144 File Offset: 0x00559344
	[NullableContext(1)]
	public void SetRoleDataList(List<RoleDataBase> dataList)
	{
		this.RoleDataListInternal = dataList;
	}

	// Token: 0x06015296 RID: 86678 RVA: 0x0055B150 File Offset: 0x00559350
	public void InitAllDevItemDataByRoleId(int roleId)
	{
		this.RoleDevRoleViewItemDataInternal = RoleDevRoleViewItemDataFactory.Create(roleId);
		this.RoleDevWeaponViewItemDataInternal = RoleDevWeaponViewItemDataFactory.Create(roleId, this);
		this.RoleDevSkillViewItemDataInternal = RoleDevSkillViewItemDataFactory.Create(roleId, this);
		this.RoleDevPhantomViewItemDataInternal = RoleDevPhantomViewItemDataFactory.Create(roleId, this);
		this.CreatedRoleIdSet.Add(roleId);
	}

	// Token: 0x06015297 RID: 86679 RVA: 0x0055B1A0 File Offset: 0x005593A0
	public bool GetRoleSkillPlanState(int roleId)
	{
		bool result;
		if (this.RoleIdToSkillPlanStateMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return RoleDevUtils.GetDefaultSkillPlanByRoleId(roleId);
	}

	// Token: 0x06015298 RID: 86680 RVA: 0x0055B1C5 File Offset: 0x005593C5
	public void SetRoleSkillPlanState(int roleId, bool isPerfectPlan)
	{
		this.RoleIdToSkillPlanStateMap[roleId] = isPerfectPlan;
	}

	// Token: 0x06015299 RID: 86681 RVA: 0x0055B1D4 File Offset: 0x005593D4
	public ERoleDevWeaponTabType GetRoleWeaponTabType(int roleId)
	{
		ERoleDevWeaponTabType result;
		if (this.RoleIdToWeaponTabTypeMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return ERoleDevWeaponTabType.None;
	}

	// Token: 0x0601529A RID: 86682 RVA: 0x0055B1F4 File Offset: 0x005593F4
	public void SetRoleWeaponTabType(int roleId, ERoleDevWeaponTabType weaponTabType)
	{
		this.RoleIdToWeaponTabTypeMap[roleId] = weaponTabType;
	}

	// Token: 0x0601529B RID: 86683 RVA: 0x0055B204 File Offset: 0x00559404
	public int GetRoleRecommendPlanId(int roleId)
	{
		int result;
		if (this.RoleIdToRecommendPlanIdMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x0601529C RID: 86684 RVA: 0x0055B224 File Offset: 0x00559424
	public void SetRoleRecommendPlanId(int roleId, int recommendPlanId)
	{
		this.RoleIdToRecommendPlanIdMap[roleId] = recommendPlanId;
	}

	// Token: 0x17001C0A RID: 7178
	// (get) Token: 0x0601529D RID: 86685 RVA: 0x0055B233 File Offset: 0x00559433
	[Nullable(1)]
	public List<RoleDataBase> RoleDataList
	{
		[NullableContext(1)]
		get
		{
			return this.RoleDataListInternal;
		}
	}

	// Token: 0x17001C0B RID: 7179
	// (get) Token: 0x0601529E RID: 86686 RVA: 0x0055B23B File Offset: 0x0055943B
	public RoleDevRoleViewItemDataBase RoleDevRoleViewItemData
	{
		get
		{
			return this.RoleDevRoleViewItemDataInternal;
		}
	}

	// Token: 0x17001C0C RID: 7180
	// (get) Token: 0x0601529F RID: 86687 RVA: 0x0055B243 File Offset: 0x00559443
	public RoleDevWeaponViewItemDataBase RoleDevWeaponViewItemData
	{
		get
		{
			return this.RoleDevWeaponViewItemDataInternal;
		}
	}

	// Token: 0x17001C0D RID: 7181
	// (get) Token: 0x060152A0 RID: 86688 RVA: 0x0055B24B File Offset: 0x0055944B
	public RoleDevPhantomViewItemDataBase RoleDevPhantomViewItemData
	{
		get
		{
			return this.RoleDevPhantomViewItemDataInternal;
		}
	}

	// Token: 0x17001C0E RID: 7182
	// (get) Token: 0x060152A1 RID: 86689 RVA: 0x0055B253 File Offset: 0x00559453
	public RoleDevSkillViewItemDataBase RoleDevSkillViewItemData
	{
		get
		{
			return this.RoleDevSkillViewItemDataInternal;
		}
	}

	// Token: 0x17001C0F RID: 7183
	// (get) Token: 0x060152A2 RID: 86690 RVA: 0x0055B25B File Offset: 0x0055945B
	[Nullable(1)]
	public List<RoleDisplayModelBase> HotRoleDataList
	{
		[NullableContext(1)]
		get
		{
			return this.HotRoleDataListInternal;
		}
	}

	// Token: 0x060152A3 RID: 86691 RVA: 0x0055B263 File Offset: 0x00559463
	public bool CheckRoleIdIsCreated(int roleId)
	{
		return this.CreatedRoleIdSet.Contains(roleId);
	}

	// Token: 0x060152A5 RID: 86693 RVA: 0x0055B2C9 File Offset: 0x005594C9
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

	// Token: 0x04009E80 RID: 40576
	[Nullable(1)]
	private List<RoleDataBase> RoleDataListInternal = new List<RoleDataBase>();

	// Token: 0x04009E81 RID: 40577
	[Nullable(1)]
	private readonly List<RoleDisplayModelBase> HotRoleDataListInternal = new List<RoleDisplayModelBase>();

	// Token: 0x04009E82 RID: 40578
	private RoleDevRoleViewItemDataBase RoleDevRoleViewItemDataInternal;

	// Token: 0x04009E83 RID: 40579
	private RoleDevWeaponViewItemDataBase RoleDevWeaponViewItemDataInternal;

	// Token: 0x04009E84 RID: 40580
	private RoleDevPhantomViewItemDataBase RoleDevPhantomViewItemDataInternal;

	// Token: 0x04009E85 RID: 40581
	private RoleDevSkillViewItemDataBase RoleDevSkillViewItemDataInternal;

	// Token: 0x04009E86 RID: 40582
	[Nullable(1)]
	private readonly HashSet<int> CreatedRoleIdSet = new HashSet<int>();

	// Token: 0x04009E87 RID: 40583
	[Nullable(1)]
	private readonly Dictionary<int, bool> RoleIdToSkillPlanStateMap = new Dictionary<int, bool>();

	// Token: 0x04009E88 RID: 40584
	[Nullable(1)]
	private readonly Dictionary<int, ERoleDevWeaponTabType> RoleIdToWeaponTabTypeMap = new Dictionary<int, ERoleDevWeaponTabType>();

	// Token: 0x04009E89 RID: 40585
	[Nullable(1)]
	private readonly Dictionary<int, int> RoleIdToRecommendPlanIdMap = new Dictionary<int, int>();
}
