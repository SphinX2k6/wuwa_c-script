using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015EF RID: 5615
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerRoleSelectPanel : UiPanelBase
{
	// Token: 0x06009E88 RID: 40584 RVA: 0x00229DA4 File Offset: 0x00227FA4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E89 RID: 40585 RVA: 0x00229E10 File Offset: 0x00228010
	protected override void OnStart()
	{
		this.RoleScroll = new GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch>(base.GetScrollViewWithScrollbar(0), new Func<WheelTowerRoleGridItem>(this.CreateWheelTowerRoleGridItem), null, false, null);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(1), new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
	}

	// Token: 0x06009E8A RID: 40586 RVA: 0x00229E5C File Offset: 0x0022805C
	protected override void OnBeforeDestroy()
	{
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.FilterSortEntrance = null;
	}

	// Token: 0x06009E8B RID: 40587 RVA: 0x00229E78 File Offset: 0x00228078
	public void Refresh()
	{
		List<RoleDataBase> dataList = (from roleId in RoleModel.Instance.GetRoleIdList()
		select RoleModel.Instance.GetRoleDataById(roleId, true)).ToList<RoleDataBase>();
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance == null)
		{
			return;
		}
		filterSortEntrance.UpdateData(EFilterSortGroupId.EditFormation, dataList, Array.Empty<object>());
	}

	// Token: 0x06009E8C RID: 40588 RVA: 0x00229ED0 File Offset: 0x002280D0
	public int GetFirstRoleId()
	{
		return this.FirstRoleId;
	}

	// Token: 0x06009E8D RID: 40589 RVA: 0x00229ED8 File Offset: 0x002280D8
	public void OnlyRefreshScroll()
	{
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> roleScroll = this.RoleScroll;
		if (roleScroll == null)
		{
			return;
		}
		GenericLayout<WheelTowerRoleGridItem, RoleDataWithBranch> genericLayout = roleScroll.GetGenericLayout();
		if (genericLayout == null)
		{
			return;
		}
		genericLayout.RefreshWithoutDataSync();
	}

	// Token: 0x06009E8E RID: 40590 RVA: 0x00229EF4 File Offset: 0x002280F4
	public void RefreshRoleSkillBranch(int roleId)
	{
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> roleScroll = this.RoleScroll;
		IReadOnlyList<RoleDataWithBranch> readOnlyList;
		if (roleScroll == null)
		{
			readOnlyList = null;
		}
		else
		{
			GenericLayout<WheelTowerRoleGridItem, RoleDataWithBranch> genericLayout = roleScroll.GetGenericLayout();
			readOnlyList = ((genericLayout != null) ? genericLayout.GetDatas() : null);
		}
		IReadOnlyList<RoleDataWithBranch> readOnlyList2 = readOnlyList;
		if (readOnlyList2 == null)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < readOnlyList2.Count; i++)
		{
			if (readOnlyList2[i].RoleId == roleId)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		RoleDataWithBranch roleDataWithBranch = readOnlyList2[num];
		int roleSkillBranchIdInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleDataWithBranch.RoleId);
		roleDataWithBranch.SkillBranchId = roleSkillBranchIdInCurrentGamePlay;
		roleDataWithBranch.SkillBranchIndex = ((roleDataWithBranch.RoleId > 0 && roleSkillBranchIdInCurrentGamePlay > 0) ? RoleModel.Instance.GetRoleBranchIndexById(roleDataWithBranch.RoleId, roleSkillBranchIdInCurrentGamePlay) : -1);
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> roleScroll2 = this.RoleScroll;
		if (roleScroll2 == null)
		{
			return;
		}
		WheelTowerRoleGridItem scrollItemByIndex = roleScroll2.GetScrollItemByIndex(num);
		if (scrollItemByIndex == null)
		{
			return;
		}
		scrollItemByIndex.Refresh(roleDataWithBranch, false, num);
	}

	// Token: 0x06009E8F RID: 40591 RVA: 0x00229FBA File Offset: 0x002281BA
	private WheelTowerRoleGridItem CreateWheelTowerRoleGridItem()
	{
		WheelTowerRoleGridItem wheelTowerRoleGridItem = new WheelTowerRoleGridItem();
		wheelTowerRoleGridItem.SetToggleClickCallback(new Action<int>(this.OnToggleClick));
		return wheelTowerRoleGridItem;
	}

	// Token: 0x06009E90 RID: 40592 RVA: 0x00229FD3 File Offset: 0x002281D3
	private void OnToggleClick(int roleId)
	{
		Action<int> onRoleSelect = this.OnRoleSelect;
		if (onRoleSelect != null)
		{
			onRoleSelect(roleId);
		}
		this.OnlyRefreshScroll();
	}

	// Token: 0x06009E91 RID: 40593 RVA: 0x00229FF0 File Offset: 0x002281F0
	private void UpdateRoleList(List<RoleDataBase> list, bool isShowText, EFilterSortType sortType)
	{
		List<int> list2 = new List<int>();
		Dictionary<int, int> tmpSelectedRoleMap = WheelTowerModel.Instance.TmpSelectedRoleMap;
		for (int i = 0; i < WheelTowerModel.Instance.GetTeamMaxRoleCount(); i++)
		{
			int num;
			if (tmpSelectedRoleMap.TryGetValue(i, out num) && num != 0)
			{
				list2.Add(num);
			}
		}
		List<int> list3 = new List<int>();
		foreach (RoleDataBase roleDataBase in list)
		{
			if (!list2.Contains(roleDataBase.GetRoleId()))
			{
				int roleEnergy = WheelTowerModel.Instance.SelectedEnergyInfo.GetRoleEnergy(roleDataBase.GetRoleId());
				if (roleEnergy >= 0)
				{
					if (roleEnergy == 0)
					{
						list3.Add(roleDataBase.GetRoleId());
					}
					else
					{
						list2.Add(roleDataBase.GetRoleId());
					}
				}
			}
		}
		list2.AddRange(list3);
		bool flag = list2.Count > 0;
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> roleScroll = this.RoleScroll;
		if (roleScroll != null)
		{
			if (roleScroll.ContentItem != null)
			{
				TWeakObjectPtr<UUIItem>? tweakObjectPtr;
				UUIItem uuiitem = tweakObjectPtr.GetValueOrDefault().Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag);
				}
			}
		}
		if (!flag)
		{
			return;
		}
		List<RoleDataWithBranch> list4 = new List<RoleDataWithBranch>();
		foreach (int roleId in list2)
		{
			list4.Add(new RoleDataWithBranch(roleId, RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId)));
		}
		this.FirstRoleId = list4[0].RoleId;
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> roleScroll2 = this.RoleScroll;
		if (roleScroll2 == null)
		{
			return;
		}
		roleScroll2.RefreshByData(list4, null, false);
	}

	// Token: 0x040046D3 RID: 18131
	[Nullable(2)]
	public Action<int> OnRoleSelect;

	// Token: 0x040046D4 RID: 18132
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> RoleScroll;

	// Token: 0x040046D5 RID: 18133
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x040046D6 RID: 18134
	private int FirstRoleId;
}
