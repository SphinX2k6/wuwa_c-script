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

// Token: 0x02002170 RID: 8560
[NullableContext(1)]
[Nullable(0)]
public class TowerFormationRoleScrollItem : UiPanelBase
{
	// Token: 0x06015026 RID: 86054 RVA: 0x0061F05C File Offset: 0x0061D25C
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

	// Token: 0x06015027 RID: 86055 RVA: 0x0061F0A7 File Offset: 0x0061D2A7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06015028 RID: 86056 RVA: 0x0061F0E0 File Offset: 0x0061D2E0
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

	// Token: 0x06015029 RID: 86057 RVA: 0x0061F15E File Offset: 0x0061D35E
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

	// Token: 0x0601502A RID: 86058 RVA: 0x0061F194 File Offset: 0x0061D394
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

	// Token: 0x0601502B RID: 86059 RVA: 0x0061F240 File Offset: 0x0061D440
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

	// Token: 0x0601502C RID: 86060 RVA: 0x0061F29A File Offset: 0x0061D49A
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

	// Token: 0x0601502D RID: 86061 RVA: 0x0061F2C4 File Offset: 0x0061D4C4
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

	// Token: 0x0601502E RID: 86062 RVA: 0x0061F3F8 File Offset: 0x0061D5F8
	private TowerFormationRoleGrid OnGridProxyCreate()
	{
		TowerFormationRoleGrid towerFormationRoleGrid = new TowerFormationRoleGrid();
		towerFormationRoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		towerFormationRoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return towerFormationRoleGrid;
	}

	// Token: 0x0601502F RID: 86063 RVA: 0x0061F424 File Offset: 0x0061D624
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

	// Token: 0x06015030 RID: 86064 RVA: 0x0061F534 File Offset: 0x0061D734
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

	// Token: 0x06015031 RID: 86065 RVA: 0x0061F55C File Offset: 0x0061D75C
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

	// Token: 0x06015032 RID: 86066 RVA: 0x0061F58C File Offset: 0x0061D78C
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

	// Token: 0x06015033 RID: 86067 RVA: 0x0061F5E8 File Offset: 0x0061D7E8
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			list.Add(this.RoleList[i].GetDataId());
		}
		return list;
	}

	// Token: 0x06015034 RID: 86068 RVA: 0x0061F629 File Offset: 0x0061D829
	protected override void OnBeforeDestroy()
	{
		this.FilterComponent = null;
		this.RoleScrollView = null;
	}

	// Token: 0x0400B2E9 RID: 45801
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterComponent;

	// Token: 0x0400B2EA RID: 45802
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerFormationRoleGrid, RoleDataBase> RoleScrollView;

	// Token: 0x0400B2EB RID: 45803
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x0400B2EC RID: 45804
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RoleSelectCallBack;

	// Token: 0x020083F7 RID: 33783
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A94A RID: 174410
		RoleScroll,
		// Token: 0x0402A94B RID: 174411
		FilterItem
	}
}
