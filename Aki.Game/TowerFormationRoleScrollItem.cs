using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BF5 RID: 11253
[NullableContext(1)]
[Nullable(0)]
public class TowerFormationRoleScrollItem : UiPanelBase
{
	// Token: 0x060175F5 RID: 95733 RVA: 0x005F2520 File Offset: 0x005F0720
	public UniTask Init(UUIItem item)
	{
		TowerFormationRoleScrollItem.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TowerFormationRoleScrollItem.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060175F6 RID: 95734 RVA: 0x005F256B File Offset: 0x005F076B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060175F7 RID: 95735 RVA: 0x005F25A4 File Offset: 0x005F07A4
	protected override void OnStart()
	{
		this.RoleList = new List<RoleDataBase>(RoleModel.Instance.GetRoleList());
		this.RoleScrollView = new GenericScrollViewNew<TowerFormationRoleGrid, RoleDataBase>(base.GetScrollViewWithScrollbar(0), new Func<TowerFormationRoleGrid>(this.OnGridProxyCreate), null, false, null);
		this.FilterComponent = new FilterSortEntrance<RoleDataBase>(base.GetItem(1), new TUpdateDataListFunction<RoleDataBase>(this.OnFilterSort));
		FilterSortEntrance<RoleDataBase> filterComponent = this.FilterComponent;
		if (filterComponent == null)
		{
			return;
		}
		filterComponent.UpdateData(EFilterSortGroupId.TowerFormation, this.RoleList, Array.Empty<object>());
	}

	// Token: 0x060175F8 RID: 95736 RVA: 0x005F2622 File Offset: 0x005F0822
	public void RebuildRoleList()
	{
		this.RoleList = new List<RoleDataBase>(RoleModel.Instance.GetRoleList());
		FilterSortEntrance<RoleDataBase> filterComponent = this.FilterComponent;
		if (filterComponent == null)
		{
			return;
		}
		filterComponent.UpdateData(EFilterSortGroupId.TowerFormation, this.RoleList, Array.Empty<object>());
	}

	// Token: 0x060175F9 RID: 95737 RVA: 0x005F2658 File Offset: 0x005F0858
	public bool IsRoleListStale()
	{
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		if (roleList.Length != this.RoleList.Count)
		{
			return true;
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (RoleDataBase roleDataBase in this.RoleList)
		{
			hashSet.Add(roleDataBase.GetDataId());
		}
		foreach (RoleInstance roleInstance in roleList)
		{
			if (!hashSet.Contains(roleInstance.GetDataId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060175FA RID: 95738 RVA: 0x005F2704 File Offset: 0x005F0904
	public void UpdateRoleListFilter()
	{
		int filterId = FilterConfig.Instance.GetFilterId(EFilterSortGroupId.TowerFormation);
		if (filterId > 0)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnFilterDataUpdate, filterId);
			return;
		}
		this.RoleList = this.SortSelectedFirst(this.RoleList);
		GenericScrollViewNew<TowerFormationRoleGrid, RoleDataBase> roleScrollView = this.RoleScrollView;
		if (roleScrollView == null)
		{
			return;
		}
		roleScrollView.RefreshByData(this.RoleList, null, false);
	}

	// Token: 0x060175FB RID: 95739 RVA: 0x005F275E File Offset: 0x005F095E
	private void OnFilterSort(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
	{
		this.RoleList = this.SortSelectedFirst(dataList);
		GenericScrollViewNew<TowerFormationRoleGrid, RoleDataBase> roleScrollView = this.RoleScrollView;
		if (roleScrollView == null)
		{
			return;
		}
		roleScrollView.RefreshByData(this.RoleList, null, false);
	}

	// Token: 0x060175FC RID: 95740 RVA: 0x005F2788 File Offset: 0x005F0988
	private List<RoleDataBase> SortSelectedFirst(List<RoleDataBase> list)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		Dictionary<int, int> slotOfRole = new Dictionary<int, int>();
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in roleIndexMap)
		{
			slotOfRole[keyValuePair.Value.GetDataId()] = keyValuePair.Key;
		}
		TowerModel instance = TowerModel.Instance;
		List<RoleDataBase> list2 = new List<RoleDataBase>();
		List<RoleDataBase> list3 = new List<RoleDataBase>();
		List<RoleDataBase> list4 = new List<RoleDataBase>();
		foreach (RoleDataBase roleDataBase in list)
		{
			if (slotOfRole.ContainsKey(roleDataBase.GetDataId()))
			{
				list2.Add(roleDataBase);
			}
			else if (instance.IsRoleCostEnough(roleDataBase.GetDataId()))
			{
				list3.Add(roleDataBase);
			}
			else
			{
				list4.Add(roleDataBase);
			}
		}
		list2.Sort((RoleDataBase a, RoleDataBase b) => slotOfRole[a.GetDataId()] - slotOfRole[b.GetDataId()]);
		list2.AddRange(list3);
		list2.AddRange(list4);
		return list2;
	}

	// Token: 0x060175FD RID: 95741 RVA: 0x005F28BC File Offset: 0x005F0ABC
	private TowerFormationRoleGrid OnGridProxyCreate()
	{
		TowerFormationRoleGrid towerFormationRoleGrid = new TowerFormationRoleGrid();
		towerFormationRoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		towerFormationRoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return towerFormationRoleGrid;
	}

	// Token: 0x060175FE RID: 95742 RVA: 0x005F28E8 File Offset: 0x005F0AE8
	protected void ToggleFunction(MediumItemGridExtendCallback params_)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		RoleDataBase roleDataBase = (RoleDataBase)params_.Data;
		bool flag = params_.State == EToggleState.ETT_Checked;
		if (flag)
		{
			for (int i = 1; i <= 3; i++)
			{
				if (!roleIndexMap.ContainsKey(i))
				{
					roleIndexMap[i] = roleDataBase;
					selectedRoleSet.Add(roleDataBase.GetDataId());
					break;
				}
			}
		}
		else
		{
			foreach (KeyValuePair<int, RoleDataBase> keyValuePair in roleIndexMap)
			{
				if (keyValuePair.Value == roleDataBase)
				{
					roleIndexMap.Remove(keyValuePair.Key);
					selectedRoleSet.Remove(roleDataBase.GetDataId());
					break;
				}
			}
		}
		int num = this.RoleList.IndexOf(roleDataBase);
		Action<RoleDataBase> roleSelectCallBack = this.RoleSelectCallBack;
		if (roleSelectCallBack != null)
		{
			roleSelectCallBack(roleDataBase);
		}
		TowerFormationRoleGrid scrollItemByIndex = this.RoleScrollView.GetScrollItemByIndex(num);
		if (scrollItemByIndex == null)
		{
			return;
		}
		scrollItemByIndex.Refresh(roleDataBase, flag, num);
	}

	// Token: 0x060175FF RID: 95743 RVA: 0x005F29F8 File Offset: 0x005F0BF8
	protected bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		if (this.RoleIsFull())
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06017600 RID: 95744 RVA: 0x005F2A20 File Offset: 0x005F0C20
	private bool RoleIsFull()
	{
		for (int i = 1; i <= 3; i++)
		{
			if (!RoleSelectModel.Instance.RoleIndexMap.ContainsKey(i))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06017601 RID: 95745 RVA: 0x005F2A50 File Offset: 0x005F0C50
	public void RefreshRole(int roleId)
	{
		int num = this.RoleList.FindIndex((RoleDataBase roleData) => roleData.GetDataId() == roleId);
		if (num < 0)
		{
			return;
		}
		TowerFormationRoleGrid scrollItemByIndex = this.RoleScrollView.GetScrollItemByIndex(num);
		if (scrollItemByIndex == null)
		{
			return;
		}
		scrollItemByIndex.Refresh(this.RoleList[num], false, num);
	}

	// Token: 0x06017602 RID: 95746 RVA: 0x005F2AAC File Offset: 0x005F0CAC
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			list.Add(this.RoleList[i].GetDataId());
		}
		return list;
	}

	// Token: 0x06017603 RID: 95747 RVA: 0x005F2AED File Offset: 0x005F0CED
	protected override void OnBeforeDestroy()
	{
		this.FilterComponent = null;
		this.RoleScrollView = null;
	}

	// Token: 0x0400AEE4 RID: 44772
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterComponent;

	// Token: 0x0400AEE5 RID: 44773
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerFormationRoleGrid, RoleDataBase> RoleScrollView;

	// Token: 0x0400AEE6 RID: 44774
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x0400AEE7 RID: 44775
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RoleSelectCallBack;

	// Token: 0x020091B4 RID: 37300
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F249 RID: 193097
		RoleScroll,
		// Token: 0x0402F24A RID: 193098
		FilterItem
	}
}
