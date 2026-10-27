using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001167 RID: 4455
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRoleSelectPanel : UiPanelBase
{
	// Token: 0x060075A6 RID: 30118 RVA: 0x00184ED0 File Offset: 0x001830D0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIMultiTemplateScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060075A7 RID: 30119 RVA: 0x00184F3C File Offset: 0x0018313C
	protected override void OnStart()
	{
		this.RoleMultiTemplateScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(0));
		UUIItem item = base.GetItem(1);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(item, new TUpdateDataListFunction<RoleDataBase>(this.OnFilterSort));
	}

	// Token: 0x060075A8 RID: 30120 RVA: 0x00184F7B File Offset: 0x0018317B
	protected override void OnBeforeDestroy()
	{
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.FilterSortEntrance = null;
	}

	// Token: 0x060075A9 RID: 30121 RVA: 0x00184F96 File Offset: 0x00183196
	public void Refresh(List<RoleDataBase> roleList)
	{
		this.RoleList = roleList;
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.UpdateData(EFilterSortGroupId.ShipTower, this.RoleList, Array.Empty<object>());
		}
		this.RefreshScroll();
	}

	// Token: 0x060075AA RID: 30122 RVA: 0x00184FC3 File Offset: 0x001831C3
	public void RefreshWithSelectedState(List<RoleDataBase> roleList)
	{
		this.RoleList = roleList;
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.UpdateData(EFilterSortGroupId.ShipTower, this.RoleList, Array.Empty<object>());
		}
		this.RefreshScroll();
	}

	// Token: 0x060075AB RID: 30123 RVA: 0x00184FF0 File Offset: 0x001831F0
	private void OnFilterSort(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
	{
		this.RoleList = dataList;
		if (operationType == EFilterSortType.Filter)
		{
			HashSet<int> hashSet = new HashSet<int>(from r in dataList
			select r.GetDataId());
			foreach (int item in this.SelectedConfigIds.ToList<int>())
			{
				if (!hashSet.Contains(item))
				{
					this.SelectedConfigIds.Remove(item);
				}
			}
		}
		this.RefreshScroll();
	}

	// Token: 0x060075AC RID: 30124 RVA: 0x00185094 File Offset: 0x00183294
	private void RefreshScroll()
	{
		this.DataList = this.BuildDataList();
		MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.DataList);
		multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
		multiTemplateScrollViewRefreshContext.PlayGridAnim = true;
		MultiTemplateScrollView roleMultiTemplateScrollView = this.RoleMultiTemplateScrollView;
		if (roleMultiTemplateScrollView == null)
		{
			return;
		}
		roleMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
	}

	// Token: 0x060075AD RID: 30125 RVA: 0x001850D8 File Offset: 0x001832D8
	public List<RoleDataBase> GetTrialRoleList()
	{
		return (from r in this.RoleList
		where r.IsTrialRole()
		select r).ToList<RoleDataBase>();
	}

	// Token: 0x060075AE RID: 30126 RVA: 0x0018510C File Offset: 0x0018330C
	[NullableContext(2)]
	public RoleDataBase FindRoleDataById(int configId)
	{
		return this.RoleList.Find((RoleDataBase r) => r.GetDataId() == configId);
	}

	// Token: 0x060075AF RID: 30127 RVA: 0x00185140 File Offset: 0x00183340
	private List<IMultiTemplateGridData> BuildDataList()
	{
		List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
		List<RoleDataBase> list2 = (from r in this.RoleList
		where r.IsTrialRole()
		select r).ToList<RoleDataBase>();
		List<RoleDataBase> list3 = (from r in this.RoleList
		where !r.IsTrialRole()
		select r).ToList<RoleDataBase>();
		if (list2.Count > 0)
		{
			list.Add(new RoleGroupTitleData
			{
				Data = new RoleGroupTitleData_Data
				{
					TitleTextId = "Morale_32_Role_TempRole_Title",
					TitleParam = list2.Count.ToString(),
					IsEmpty = false
				}
			});
			foreach (RoleDataBase roleData in list2)
			{
				list.Add(new RoleListData
				{
					Data = new BabelTowerRoleListItemData
					{
						RoleData = roleData,
						OwnerPanel = this
					}
				});
			}
		}
		if (list3.Count > 0)
		{
			list.Add(new RoleGroupTitleData
			{
				Data = new RoleGroupTitleData_Data
				{
					TitleTextId = "Morale_32_Role_MyRole_Title",
					TitleParam = list3.Count.ToString(),
					IsEmpty = false
				}
			});
			foreach (RoleDataBase roleData2 in list3)
			{
				list.Add(new RoleListData
				{
					Data = new BabelTowerRoleListItemData
					{
						RoleData = roleData2,
						OwnerPanel = this
					}
				});
			}
		}
		return list;
	}

	// Token: 0x060075B0 RID: 30128 RVA: 0x00185318 File Offset: 0x00183518
	public void RefreshRole(int roleId)
	{
		if (this.RoleList.FindIndex((RoleDataBase r) => r.GetDataId() == roleId) < 0)
		{
			return;
		}
		this.RefreshRoleGridProxy(roleId);
	}

	// Token: 0x060075B1 RID: 30129 RVA: 0x0018535C File Offset: 0x0018355C
	public int GetGridIndexByRoleId(int roleId)
	{
		for (int i = 0; i < this.DataList.Count; i++)
		{
			IMultiTemplateGridData multiTemplateGridData = this.DataList[i];
			if (multiTemplateGridData.GetTemplateIndex() == 1)
			{
				BabelTowerRoleListItemData data = ((RoleListData)multiTemplateGridData).Data;
				bool flag;
				if (data == null)
				{
					flag = false;
				}
				else
				{
					RoleDataBase roleData = data.RoleData;
					int? num = (roleData != null) ? new int?(roleData.GetDataId()) : null;
					flag = (num.GetValueOrDefault() == roleId & num != null);
				}
				if (flag)
				{
					return i;
				}
			}
		}
		return -1;
	}

	// Token: 0x060075B2 RID: 30130 RVA: 0x001853E0 File Offset: 0x001835E0
	public void RefreshRoleGridProxy(int roleId)
	{
		int gridIndexByRoleId = this.GetGridIndexByRoleId(roleId);
		if (gridIndexByRoleId < 0)
		{
			return;
		}
		MultiTemplateScrollView roleMultiTemplateScrollView = this.RoleMultiTemplateScrollView;
		if (roleMultiTemplateScrollView == null)
		{
			return;
		}
		roleMultiTemplateScrollView.RefreshProxyByData(gridIndexByRoleId, this.DataList[gridIndexByRoleId]);
	}

	// Token: 0x060075B3 RID: 30131 RVA: 0x00185418 File Offset: 0x00183618
	public void RefreshSelectedRoleGridProxies()
	{
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		for (int i = 0; i < this.DataList.Count; i++)
		{
			IMultiTemplateGridData multiTemplateGridData = this.DataList[i];
			if (multiTemplateGridData.GetTemplateIndex() == 1)
			{
				RoleListData roleListData = (RoleListData)multiTemplateGridData;
				BabelTowerRoleListItemData data = roleListData.Data;
				if (((data != null) ? data.RoleData : null) != null && selectedRoleSet.Contains(roleListData.Data.RoleData.GetDataId()))
				{
					MultiTemplateScrollView roleMultiTemplateScrollView = this.RoleMultiTemplateScrollView;
					if (roleMultiTemplateScrollView != null)
					{
						roleMultiTemplateScrollView.RefreshProxyByData(i, multiTemplateGridData);
					}
				}
			}
		}
	}

	// Token: 0x040035FD RID: 13821
	private const int MAX_SELECT_ROLE_COUNT = 3;

	// Token: 0x040035FE RID: 13822
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase, bool> OnRoleSelect;

	// Token: 0x040035FF RID: 13823
	[Nullable(2)]
	public Action OnMaxSelectReached;

	// Token: 0x04003600 RID: 13824
	[Nullable(2)]
	private MultiTemplateScrollView RoleMultiTemplateScrollView;

	// Token: 0x04003601 RID: 13825
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04003602 RID: 13826
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x04003603 RID: 13827
	private List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

	// Token: 0x04003604 RID: 13828
	public readonly HashSet<int> SelectedConfigIds = new HashSet<int>();

	// Token: 0x0200773A RID: 30522
	[NullableContext(0)]
	private class EComp
	{
		// Token: 0x0402754B RID: 161099
		public const int RoleScrollView = 0;

		// Token: 0x0402754C RID: 161100
		public const int SortFilter = 1;
	}
}
