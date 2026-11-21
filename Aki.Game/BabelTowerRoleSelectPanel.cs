using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200061B RID: 1563
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRoleSelectPanel : UiPanelBase
{
	// Token: 0x0600493D RID: 18749 RVA: 0x0018DA4C File Offset: 0x0018BC4C
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

	// Token: 0x0600493E RID: 18750 RVA: 0x0018DAB8 File Offset: 0x0018BCB8
	protected override void OnStart()
	{
		this.RoleMultiTemplateScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(0));
		UUIItem item = base.GetItem(1);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(item, new TUpdateDataListFunction<RoleDataBase>(this.OnFilterSort));
	}

	// Token: 0x0600493F RID: 18751 RVA: 0x0018DAF7 File Offset: 0x0018BCF7
	protected override void OnBeforeDestroy()
	{
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.FilterSortEntrance = null;
	}

	// Token: 0x06004940 RID: 18752 RVA: 0x0018DB12 File Offset: 0x0018BD12
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

	// Token: 0x06004941 RID: 18753 RVA: 0x0018DB3F File Offset: 0x0018BD3F
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

	// Token: 0x06004942 RID: 18754 RVA: 0x0018DB6C File Offset: 0x0018BD6C
	private void OnFilterSort(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
	{
		this.RoleList = dataList;
		if (operationType == EFilterSortType.Filter)
		{
			HashSet<int> hashSet = new HashSet<int>();
			for (int i = 0; i < dataList.Count; i++)
			{
				hashSet.Add(dataList[i].GetDataId());
			}
			int[] array = new int[this.SelectedConfigIds.Count];
			this.SelectedConfigIds.CopyTo(array);
			foreach (int item in array)
			{
				if (!hashSet.Contains(item))
				{
					this.SelectedConfigIds.Remove(item);
				}
			}
		}
		this.RefreshScroll();
	}

	// Token: 0x06004943 RID: 18755 RVA: 0x0018DC08 File Offset: 0x0018BE08
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

	// Token: 0x06004944 RID: 18756 RVA: 0x0018DC4C File Offset: 0x0018BE4C
	public List<RoleDataBase> GetTrialRoleList()
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			if (this.RoleList[i].IsTrialRole())
			{
				list.Add(this.RoleList[i]);
			}
		}
		return list;
	}

	// Token: 0x06004945 RID: 18757 RVA: 0x0018DC9C File Offset: 0x0018BE9C
	[NullableContext(2)]
	public RoleDataBase FindRoleDataById(int configId)
	{
		return this.RoleList.Find((RoleDataBase r) => r.GetDataId() == configId);
	}

	// Token: 0x06004946 RID: 18758 RVA: 0x0018DCD0 File Offset: 0x0018BED0
	private List<IMultiTemplateGridData> BuildDataList()
	{
		List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
		List<RoleDataBase> list2 = new List<RoleDataBase>();
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			if (this.RoleList[i].IsTrialRole())
			{
				list2.Add(this.RoleList[i]);
			}
		}
		List<RoleDataBase> list3 = new List<RoleDataBase>();
		for (int j = 0; j < this.RoleList.Count; j++)
		{
			if (!this.RoleList[j].IsTrialRole())
			{
				list3.Add(this.RoleList[j]);
			}
		}
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

	// Token: 0x06004947 RID: 18759 RVA: 0x0018DED0 File Offset: 0x0018C0D0
	public void RefreshRole(int roleId)
	{
		if (this.RoleList.FindIndex((RoleDataBase r) => r.GetDataId() == roleId) < 0)
		{
			return;
		}
		this.RefreshRoleGridProxy(roleId);
	}

	// Token: 0x06004948 RID: 18760 RVA: 0x0018DF14 File Offset: 0x0018C114
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

	// Token: 0x06004949 RID: 18761 RVA: 0x0018DF98 File Offset: 0x0018C198
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

	// Token: 0x0600494A RID: 18762 RVA: 0x0018DFD0 File Offset: 0x0018C1D0
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

	// Token: 0x04003696 RID: 13974
	private const int MAX_SELECT_ROLE_COUNT = 3;

	// Token: 0x04003697 RID: 13975
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase, bool> OnRoleSelect;

	// Token: 0x04003698 RID: 13976
	[Nullable(2)]
	public Action OnMaxSelectReached;

	// Token: 0x04003699 RID: 13977
	[Nullable(2)]
	private MultiTemplateScrollView RoleMultiTemplateScrollView;

	// Token: 0x0400369A RID: 13978
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x0400369B RID: 13979
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x0400369C RID: 13980
	private List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

	// Token: 0x0400369D RID: 13981
	public readonly HashSet<int> SelectedConfigIds = new HashSet<int>();

	// Token: 0x020068C8 RID: 26824
	[NullableContext(0)]
	private class EComp
	{
		// Token: 0x04022889 RID: 141449
		public const int RoleScrollView = 0;

		// Token: 0x0402288A RID: 141450
		public const int SortFilter = 1;
	}
}
