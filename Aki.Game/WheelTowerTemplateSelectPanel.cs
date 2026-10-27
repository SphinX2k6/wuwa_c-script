using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015FE RID: 5630
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerTemplateSelectPanel : UiPanelBase
{
	// Token: 0x06009EC8 RID: 40648 RVA: 0x0022B07C File Offset: 0x0022927C
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

	// Token: 0x06009EC9 RID: 40649 RVA: 0x0022B0E8 File Offset: 0x002292E8
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch>(base.GetScrollViewWithScrollbar(0), new Func<WheelTowerRoleGridItem>(this.CreateWheelTowerRoleGridItem), null, false, null);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(1), new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
	}

	// Token: 0x06009ECA RID: 40650 RVA: 0x0022B134 File Offset: 0x00229334
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

	// Token: 0x06009ECB RID: 40651 RVA: 0x0022B18C File Offset: 0x0022938C
	public int GetFirstRoleId()
	{
		return this.FirstRoleId;
	}

	// Token: 0x06009ECC RID: 40652 RVA: 0x0022B194 File Offset: 0x00229394
	public void OnlyRefreshScroll()
	{
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		GenericLayout<WheelTowerRoleGridItem, RoleDataWithBranch> genericLayout = scrollView.GetGenericLayout();
		if (genericLayout == null)
		{
			return;
		}
		genericLayout.RefreshWithoutDataSync();
	}

	// Token: 0x06009ECD RID: 40653 RVA: 0x0022B1B0 File Offset: 0x002293B0
	public void RefreshRoleSkillBranch(int roleId)
	{
		if (roleId <= 0)
		{
			return;
		}
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> scrollView = this.ScrollView;
		IReadOnlyList<RoleDataWithBranch> readOnlyList;
		if (scrollView == null)
		{
			readOnlyList = null;
		}
		else
		{
			GenericLayout<WheelTowerRoleGridItem, RoleDataWithBranch> genericLayout = scrollView.GetGenericLayout();
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
		int roleSkillBranchIdInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId);
		roleDataWithBranch.SkillBranchId = roleSkillBranchIdInCurrentGamePlay;
		roleDataWithBranch.SkillBranchIndex = ((roleDataWithBranch.RoleId > 0 && roleSkillBranchIdInCurrentGamePlay > 0) ? RoleModel.Instance.GetRoleBranchIndexById(roleId, roleSkillBranchIdInCurrentGamePlay) : -1);
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> scrollView2 = this.ScrollView;
		if (scrollView2 == null)
		{
			return;
		}
		WheelTowerRoleGridItem scrollItemByIndex = scrollView2.GetScrollItemByIndex(num);
		if (scrollItemByIndex == null)
		{
			return;
		}
		scrollItemByIndex.Refresh(roleDataWithBranch, false, num);
	}

	// Token: 0x06009ECE RID: 40654 RVA: 0x0022B271 File Offset: 0x00229471
	private WheelTowerRoleGridItem CreateWheelTowerRoleGridItem()
	{
		WheelTowerRoleGridItem wheelTowerRoleGridItem = new WheelTowerRoleGridItem();
		wheelTowerRoleGridItem.SetToggleClickCallback(new Action<int>(this.OnToggleClick));
		return wheelTowerRoleGridItem;
	}

	// Token: 0x06009ECF RID: 40655 RVA: 0x0022B28A File Offset: 0x0022948A
	private void OnToggleClick(int roleId)
	{
		Action<int> onTemplateSelect = this.OnTemplateSelect;
		if (onTemplateSelect != null)
		{
			onTemplateSelect(roleId);
		}
		this.OnlyRefreshScroll();
	}

	// Token: 0x06009ED0 RID: 40656 RVA: 0x0022B2A4 File Offset: 0x002294A4
	private void UpdateRoleList(List<RoleDataBase> list, bool isShowText, EFilterSortType sortType)
	{
		List<int> list2 = new List<int>();
		Dictionary<int, int> tmpSelectedRoleMap = WheelTowerModel.Instance.TmpSelectedRoleMap;
		for (int i = 0; i < WheelTowerModel.Instance.GetTeamMaxRoleCount(); i++)
		{
			int item;
			if (tmpSelectedRoleMap.TryGetValue(i, out item))
			{
				list2.Add(item);
			}
		}
		List<int> list3 = new List<int>();
		foreach (RoleDataBase roleDataBase in list)
		{
			int templateRoleId = WheelTowerModel.Instance.GetTemplateRoleId(roleDataBase.GetRoleId());
			if (templateRoleId != 0 && !list2.Contains(templateRoleId))
			{
				int roleEnergy = WheelTowerModel.Instance.SelectedEnergyInfo.GetRoleEnergy(roleDataBase.GetRoleId());
				if (roleEnergy >= 0)
				{
					if (roleEnergy == 0)
					{
						list3.Add(templateRoleId);
					}
					else
					{
						list2.Add(templateRoleId);
					}
				}
			}
		}
		list2.AddRange(list3);
		bool flag = list2.Count > 0;
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> scrollView = this.ScrollView;
		if (scrollView != null)
		{
			if (scrollView.ContentItem != null)
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
		GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> scrollView2 = this.ScrollView;
		if (scrollView2 == null)
		{
			return;
		}
		scrollView2.RefreshByData(list4, null, false);
	}

	// Token: 0x04004709 RID: 18185
	[Nullable(2)]
	public Action<int> OnTemplateSelect;

	// Token: 0x0400470A RID: 18186
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> ScrollView;

	// Token: 0x0400470B RID: 18187
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x0400470C RID: 18188
	private int FirstRoleId;
}
