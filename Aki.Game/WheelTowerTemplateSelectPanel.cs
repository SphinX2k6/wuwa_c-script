using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000AB6 RID: 2742
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerTemplateSelectPanel : UiPanelBase
{
	// Token: 0x060072A6 RID: 29350 RVA: 0x00234E54 File Offset: 0x00233054
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

	// Token: 0x060072A7 RID: 29351 RVA: 0x00234EC0 File Offset: 0x002330C0
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch>(base.GetScrollViewWithScrollbar(0), new Func<WheelTowerRoleGridItem>(this.CreateWheelTowerRoleGridItem), null, false, null);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(1), new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
	}

	// Token: 0x060072A8 RID: 29352 RVA: 0x00234F0C File Offset: 0x0023310C
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

	// Token: 0x060072A9 RID: 29353 RVA: 0x00234F8C File Offset: 0x0023318C
	public int GetFirstRoleId()
	{
		return this.FirstRoleId;
	}

	// Token: 0x060072AA RID: 29354 RVA: 0x00234F94 File Offset: 0x00233194
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

	// Token: 0x060072AB RID: 29355 RVA: 0x00234FB0 File Offset: 0x002331B0
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

	// Token: 0x060072AC RID: 29356 RVA: 0x00235071 File Offset: 0x00233271
	private WheelTowerRoleGridItem CreateWheelTowerRoleGridItem()
	{
		WheelTowerRoleGridItem wheelTowerRoleGridItem = new WheelTowerRoleGridItem();
		wheelTowerRoleGridItem.SetToggleClickCallback(new Action<int>(this.OnToggleClick));
		return wheelTowerRoleGridItem;
	}

	// Token: 0x060072AD RID: 29357 RVA: 0x0023508A File Offset: 0x0023328A
	private void OnToggleClick(int roleId)
	{
		Action<int> onTemplateSelect = this.OnTemplateSelect;
		if (onTemplateSelect != null)
		{
			onTemplateSelect(roleId);
		}
		this.OnlyRefreshScroll();
	}

	// Token: 0x060072AE RID: 29358 RVA: 0x002350A4 File Offset: 0x002332A4
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

	// Token: 0x040047AF RID: 18351
	[Nullable(2)]
	public Action<int> OnTemplateSelect;

	// Token: 0x040047B0 RID: 18352
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerRoleGridItem, RoleDataWithBranch> ScrollView;

	// Token: 0x040047B1 RID: 18353
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x040047B2 RID: 18354
	private int FirstRoleId;
}
