using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000AA7 RID: 2727
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerRoleSelectPanel : UiPanelBase
{
	// Token: 0x06007266 RID: 29286 RVA: 0x00233B54 File Offset: 0x00231D54
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

	// Token: 0x06007267 RID: 29287 RVA: 0x00233BC0 File Offset: 0x00231DC0
	protected override void OnStart()
	{
		this.RoleScroll = new GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch>(base.GetScrollViewWithScrollbar(0), new Func<WheelTowerRoleGridItem>(this.CreateWheelTowerRoleGridItem), null, false, null);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(1), new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
	}

	// Token: 0x06007268 RID: 29288 RVA: 0x00233C0C File Offset: 0x00231E0C
	protected override void OnBeforeDestroy()
	{
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.FilterSortEntrance = null;
	}

	// Token: 0x06007269 RID: 29289 RVA: 0x00233C28 File Offset: 0x00231E28
	public void Refresh()
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (int id in RoleModel.Instance.GetRoleIdList(null))
		{
			list.Add(RoleModel.Instance.GetRoleDataById(id, true));
		}
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance == null)
		{
			return;
		}
		filterSortEntrance.UpdateData(EFilterSortGroupId.EditFormation, list, Array.Empty<object>());
	}

	// Token: 0x0600726A RID: 29290 RVA: 0x00233CA8 File Offset: 0x00231EA8
	public int GetFirstRoleId()
	{
		return this.FirstRoleId;
	}

	// Token: 0x0600726B RID: 29291 RVA: 0x00233CB0 File Offset: 0x00231EB0
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

	// Token: 0x0600726C RID: 29292 RVA: 0x00233CCC File Offset: 0x00231ECC
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

	// Token: 0x0600726D RID: 29293 RVA: 0x00233D92 File Offset: 0x00231F92
	private WheelTowerRoleGridItem CreateWheelTowerRoleGridItem()
	{
		WheelTowerRoleGridItem wheelTowerRoleGridItem = new WheelTowerRoleGridItem();
		wheelTowerRoleGridItem.SetToggleClickCallback(new Action<int>(this.OnToggleClick));
		return wheelTowerRoleGridItem;
	}

	// Token: 0x0600726E RID: 29294 RVA: 0x00233DAB File Offset: 0x00231FAB
	private void OnToggleClick(int roleId)
	{
		Action<int> onRoleSelect = this.OnRoleSelect;
		if (onRoleSelect != null)
		{
			onRoleSelect(roleId);
		}
		this.OnlyRefreshScroll();
	}

	// Token: 0x0600726F RID: 29295 RVA: 0x00233DC8 File Offset: 0x00231FC8
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

	// Token: 0x04004779 RID: 18297
	[Nullable(2)]
	public Action<int> OnRoleSelect;

	// Token: 0x0400477A RID: 18298
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> RoleScroll;

	// Token: 0x0400477B RID: 18299
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x0400477C RID: 18300
	private int FirstRoleId;
}
