using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02001C63 RID: 7267
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleTeamRoleSelectView : UiViewBase
{
	// Token: 0x0601203C RID: 73788 RVA: 0x0054CB2C File Offset: 0x0054AD2C
	public RogueBattleTeamRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601203D RID: 73789 RVA: 0x0054CB64 File Offset: 0x0054AD64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
	}

	// Token: 0x0601203E RID: 73790 RVA: 0x0054CC70 File Offset: 0x0054AE70
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleTeamRoleSelectView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTeamRoleSelectView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601203F RID: 73791 RVA: 0x0054CCB4 File Offset: 0x0054AEB4
	protected override void OnStart()
	{
		RogueResFormation formationDataByIndex = RogueBattleModel.Instance.GetFormationDataByIndex(this.FormationIndex);
		this.RoleList = RogueBattleModel.Instance.GetRoleList();
		this.RoleList.Sort((RoleDataBase a, RoleDataBase b) => b.GetRoleConfig().Priority - a.GetRoleConfig().Priority);
		RepeatedField<int> roleId = formationDataByIndex.RoleId;
		RoleSelectModel.Instance.ClearData();
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		int num = 1;
		while (num <= 3 && num <= roleId.Count)
		{
			int num2 = roleId[num - 1];
			foreach (RoleDataBase roleDataBase in this.RoleList)
			{
				if (roleDataBase.GetDataId() == num2)
				{
					roleIndexMap[num] = roleDataBase;
					break;
				}
			}
			num++;
		}
		this.InitDropDown();
		RogueBattleModel.Instance.SetRogueResNewRoleFlag(false);
	}

	// Token: 0x06012040 RID: 73792 RVA: 0x0054CDAC File Offset: 0x0054AFAC
	private void OnBtnClose()
	{
		if (this.WaitClose)
		{
			return;
		}
		this.WaitClose = true;
		base.CloseMe(null);
	}

	// Token: 0x06012041 RID: 73793 RVA: 0x0054CDC8 File Offset: 0x0054AFC8
	private void OnClickConfirm(int _)
	{
		if (this.WaitClose)
		{
			return;
		}
		List<int> currentSelectRoleList = this.GetCurrentSelectRoleList();
		if (currentSelectRoleList.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RogueBattle_TeamEmpty_QuickSelect", Array.Empty<object>());
			return;
		}
		this.WaitClose = true;
		if (this.OnConfirm != null)
		{
			this.OnConfirm(currentSelectRoleList).Forget();
			base.CloseMe(null);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06012042 RID: 73794 RVA: 0x0054CE34 File Offset: 0x0054B034
	private unsafe void OnClickRoleDetail(int _)
	{
		if (this.WaitClose)
		{
			return;
		}
		if (this.CurSelectRole == null)
		{
			return;
		}
		bool flag = this.CurSelectRole.IsTrialRole();
		int num = this.CurSelectRole.GetDataId();
		if (!flag)
		{
			RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(num);
			if (rogueResBondRole != null)
			{
				num = rogueResBondRole.Value.TrialRoleId;
			}
		}
		RoleController instance = RoleController.Instance;
		ERoleAgentType agentType = ERoleAgentType.Preview;
		int selectRoleId = 0;
		int num2 = 1;
		List<int> list = new List<int>(num2);
		CollectionsMarshal.SetCount<int>(list, num2);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int index = 0;
		*span[index] = num;
		instance.OpenRoleMainView(agentType, selectRoleId, list, new EUiTabViewName?(EUiTabViewName.RoleSkillTabView), null);
	}

	// Token: 0x06012043 RID: 73795 RVA: 0x0054CECD File Offset: 0x0054B0CD
	private RogueBattleFilterDropDownItem CreateDropDownItem(UUIItem uiItem, RoleBondInfo data)
	{
		return new RogueBattleFilterDropDownItem(uiItem);
	}

	// Token: 0x06012044 RID: 73796 RVA: 0x0054CED5 File Offset: 0x0054B0D5
	private RogueBattleFilterDropDownTitle CreateTitleItem(UUIItem uiItem)
	{
		return new RogueBattleFilterDropDownTitle(uiItem);
	}

	// Token: 0x06012045 RID: 73797 RVA: 0x0054CEE0 File Offset: 0x0054B0E0
	private void InitDropDown()
	{
		this.CurrentBondInfoList.Clear();
		this.CurrentBondInfoList.AddRange(RogueBattleModel.Instance.GetAllOwnedRoleBondData());
		List<RoleBondInfo> currentBondInfoList = this.CurrentBondInfoList;
		Comparison<RoleBondInfo> comparison;
		if ((comparison = RogueBattleTeamRoleSelectView.<>O.<0>__SortRogueBattleRoleBondInfo) == null)
		{
			comparison = (RogueBattleTeamRoleSelectView.<>O.<0>__SortRogueBattleRoleBondInfo = new Comparison<RoleBondInfo>(RogueBattleDefine.SortRogueBattleRoleBondInfo));
		}
		currentBondInfoList.Sort(comparison);
		RoleBondInfo item = new RoleBondInfo
		{
			ConfigId = 0,
			CurStar = 0,
			TargetStar = 0,
			Level = 0
		};
		this.CurrentBondInfoList.Insert(0, item);
		this.CurrentSelectBondIndex = 0;
		this.CommonDropDown.SetOnSelectCall(new Action<int, RoleBondInfo>(this.OnDropDownSelectCall));
		this.CommonDropDown.SetShowType(ECommonDropDownShowType.Down);
		this.CommonDropDown.InitScroll(this.CurrentBondInfoList, new Func<RoleBondInfo, RoleBondInfo>(this.GetDropDownTextId), this.CurrentSelectBondIndex, true);
		this.CommonDropDown.SetSelectedIndex(this.CurrentSelectBondIndex, true);
	}

	// Token: 0x06012046 RID: 73798 RVA: 0x0054CFC2 File Offset: 0x0054B1C2
	private void OnDropDownSelectCall(int index, object _)
	{
		this.CurrentSelectBondIndex = index;
		this.RefreshRoleList();
	}

	// Token: 0x06012047 RID: 73799 RVA: 0x0054CFD1 File Offset: 0x0054B1D1
	private RoleBondInfo GetDropDownTextId(object data)
	{
		return (RoleBondInfo)data;
	}

	// Token: 0x06012048 RID: 73800 RVA: 0x0054CFDC File Offset: 0x0054B1DC
	private List<int> GetCurrentSelectRoleList()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		List<int> list = new List<int>();
		for (int i = 1; i <= 3; i++)
		{
			RoleDataBase roleDataBase;
			if (roleIndexMap.TryGetValue(i, out roleDataBase))
			{
				list.Add(roleDataBase.GetDataId());
			}
		}
		return list;
	}

	// Token: 0x06012049 RID: 73801 RVA: 0x0054D020 File Offset: 0x0054B220
	private List<IRogueBattleTeamRoleGridInfo> GetRoleListInfo()
	{
		List<IRogueBattleTeamRoleGridInfo> list = new List<IRogueBattleTeamRoleGridInfo>();
		List<int> recommendBondLinkRole = this.GetRecommendBondLinkRole();
		foreach (RoleDataBase roleDataBase in this.RoleList)
		{
			int dataId = roleDataBase.GetDataId();
			RoleBondInfo roleBondInfo = this.CurrentBondInfoList[this.CurrentSelectBondIndex];
			if (RoleSelectModel.Instance.GetRoleIndex(dataId) == 0 && roleBondInfo.ConfigId > 0)
			{
				RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(roleDataBase.GetRoleId());
				bool flag = false;
				using (IEnumerator<int> enumerator2 = rogueResBondRole.Value.BondIdsIter().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == roleBondInfo.ConfigId)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(dataId);
			RogueBattleTeamRoleGridInfo item = new RogueBattleTeamRoleGridInfo
			{
				RoleData = roleDataBase,
				RoleStarLv = roleInfoById.Level,
				FormationIndex = this.FormationIndex,
				IsLinkOn = recommendBondLinkRole.Contains(dataId)
			};
			list.Add(item);
		}
		int noPositionSort = 4;
		list.Sort(delegate(IRogueBattleTeamRoleGridInfo a, IRogueBattleTeamRoleGridInfo b)
		{
			int num = RoleSelectModel.Instance.GetRoleIndex(a.RoleData.GetDataId());
			if (num == 0)
			{
				num = noPositionSort;
			}
			int num2 = RoleSelectModel.Instance.GetRoleIndex(b.RoleData.GetDataId());
			if (num2 == 0)
			{
				num2 = noPositionSort;
			}
			if (num == num2)
			{
				return b.RoleStarLv - a.RoleStarLv;
			}
			return num - num2;
		});
		return list;
	}

	// Token: 0x0601204A RID: 73802 RVA: 0x0054D18C File Offset: 0x0054B38C
	private int GetIndexByRoleData(List<IRogueBattleTeamRoleGridInfo> infoList, RoleDataBase roleData)
	{
		for (int i = 0; i < infoList.Count; i++)
		{
			if (infoList[i].RoleData == roleData)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0601204B RID: 73803 RVA: 0x0054D1BC File Offset: 0x0054B3BC
	private void RefreshRoleList()
	{
		List<IRogueBattleTeamRoleGridInfo> newRoleListInfo = this.GetRoleListInfo();
		this.RoleScrollView.RefreshByData(newRoleListInfo, false, delegate
		{
			RoleDataBase roleData = newRoleListInfo[0].RoleData;
			Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
			foreach (RoleDataBase roleDataBase in roleIndexMap.Values)
			{
				int indexByRoleData = this.GetIndexByRoleData(this.RoleGridInfoList, roleDataBase);
				int indexByRoleData2 = this.GetIndexByRoleData(newRoleListInfo, roleDataBase);
				if (this.RoleScrollView.StartGridIndex >= 0 && indexByRoleData != indexByRoleData2)
				{
					RoleSelectModel.Instance.SelectedRoleSet.Remove(roleDataBase.GetDataId());
					if (this.RoleScrollView.IsGridDisplaying(indexByRoleData))
					{
						RogueBattleTeamRoleGrid rogueBattleTeamRoleGrid = this.RoleScrollView.UnsafeGetGridProxy(indexByRoleData, false);
						if (rogueBattleTeamRoleGrid != null)
						{
							rogueBattleTeamRoleGrid.OnForceSelected(false);
						}
					}
				}
			}
			foreach (RoleDataBase roleDataBase2 in roleIndexMap.Values)
			{
				int indexByRoleData3 = this.GetIndexByRoleData(newRoleListInfo, roleDataBase2);
				RoleSelectModel.Instance.SelectedRoleSet.Add(roleDataBase2.GetDataId());
				if (this.RoleScrollView.IsGridDisplaying(indexByRoleData3))
				{
					RogueBattleTeamRoleGrid rogueBattleTeamRoleGrid2 = this.RoleScrollView.UnsafeGetGridProxy(indexByRoleData3, false);
					if (rogueBattleTeamRoleGrid2 != null)
					{
						rogueBattleTeamRoleGrid2.OnForceSelected(true);
					}
				}
			}
			this.RoleGridInfoList = newRoleListInfo;
			if (this.CurSelectRole != null && this.GetIndexByRoleData(newRoleListInfo, this.CurSelectRole) >= 0)
			{
				return;
			}
			this.OnRoleSelect(roleData);
		}, true);
	}

	// Token: 0x0601204C RID: 73804 RVA: 0x0054D201 File Offset: 0x0054B401
	private RogueBattleTeamRoleGrid OnGridProxyCreate()
	{
		RogueBattleTeamRoleGrid rogueBattleTeamRoleGrid = new RogueBattleTeamRoleGrid();
		rogueBattleTeamRoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		rogueBattleTeamRoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return rogueBattleTeamRoleGrid;
	}

	// Token: 0x0601204D RID: 73805 RVA: 0x0054D22C File Offset: 0x0054B42C
	private void ToggleFunction(MediumItemGridExtendCallback param)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		IRogueBattleTeamRoleGridInfo rogueBattleTeamRoleGridInfo = (IRogueBattleTeamRoleGridInfo)param.Data;
		RoleDataBase roleData = rogueBattleTeamRoleGridInfo.RoleData;
		if (param.State == EToggleState.ETT_UnChecked)
		{
			int? num = null;
			foreach (KeyValuePair<int, RoleDataBase> keyValuePair in roleIndexMap)
			{
				if (keyValuePair.Value == roleData)
				{
					num = new int?(keyValuePair.Key);
					break;
				}
			}
			if (num != null)
			{
				roleIndexMap.Remove(num.Value);
				selectedRoleSet.Remove(roleData.GetDataId());
			}
		}
		else if (param.State == EToggleState.ETT_Checked)
		{
			for (int i = 1; i <= 3; i++)
			{
				if (!roleIndexMap.ContainsKey(i))
				{
					roleIndexMap[i] = roleData;
					selectedRoleSet.Add(roleData.GetDataId());
					break;
				}
			}
		}
		int gridIndex = this.RoleGridInfoList.IndexOf(rogueBattleTeamRoleGridInfo);
		this.RoleScrollView.RefreshGridProxy(gridIndex);
		this.OnRoleSelect(roleData);
	}

	// Token: 0x0601204E RID: 73806 RVA: 0x0054D34C File Offset: 0x0054B54C
	[NullableContext(2)]
	private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		if (this.WaitClose)
		{
			return false;
		}
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		if (RoleSelectModel.Instance.RoleIndexMap.Count >= 3)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0601204F RID: 73807 RVA: 0x0054D38C File Offset: 0x0054B58C
	public void OnRoleSelect(RoleDataBase roleData)
	{
		this.CurSelectRole = roleData;
		base.GetText(4).SetText(roleData.GetName(null), true);
		this.RefreshFetterIconList(roleData);
	}

	// Token: 0x06012050 RID: 73808 RVA: 0x0054D3C3 File Offset: 0x0054B5C3
	private RogueBattleRoleSelectFetterItem InitFetterIcon()
	{
		return new RogueBattleRoleSelectFetterItem
		{
			OnToggleClick = new Action<RoleBondInfo>(this.OnFetterIconToggleSelect)
		};
	}

	// Token: 0x06012051 RID: 73809 RVA: 0x0054D3DC File Offset: 0x0054B5DC
	private void OnFetterIconToggleSelect(RoleBondInfo bondInfo)
	{
		this.FetterIconLayout.DeselectCurrentGridProxy();
		this.FetterIconLayout.SelectGridProxyByKey(bondInfo.ConfigId, true);
		this.RefreshFetterDescList(bondInfo.ConfigId);
	}

	// Token: 0x06012052 RID: 73810 RVA: 0x0054D40C File Offset: 0x0054B60C
	private void RefreshFetterIconList(RoleDataBase roleData)
	{
		RoleBondInfo roleBondInfo = this.CurrentBondInfoList[this.CurrentSelectBondIndex];
		int selectBondId = roleBondInfo.ConfigId;
		bool hasBondId = false;
		this.FetterIconLayout.DeselectCurrentGridProxy();
		RoleInfo roleConfig = roleData.GetRoleConfig();
		RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(roleConfig.Id);
		List<RoleBondInfo> list = new List<RoleBondInfo>();
		foreach (int num in rogueResBondRole.Value.BondIdsIter())
		{
			RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(num);
			if (selectBondId == num)
			{
				hasBondId = true;
			}
			list.Add(roleBondDataById);
		}
		List<RoleBondInfo> list2 = list;
		Comparison<RoleBondInfo> comparison;
		if ((comparison = RogueBattleTeamRoleSelectView.<>O.<0>__SortRogueBattleRoleBondInfo) == null)
		{
			comparison = (RogueBattleTeamRoleSelectView.<>O.<0>__SortRogueBattleRoleBondInfo = new Comparison<RoleBondInfo>(RogueBattleDefine.SortRogueBattleRoleBondInfo));
		}
		list2.Sort(comparison);
		this.FetterIconLayout.RefreshByData(list, delegate
		{
			if (hasBondId)
			{
				this.FetterIconLayout.SelectGridProxyByKey(selectBondId, true);
				return;
			}
			this.FetterIconLayout.SelectGridProxy(0, true);
		}, false);
	}

	// Token: 0x06012053 RID: 73811 RVA: 0x0054D524 File Offset: 0x0054B724
	private RogueBattleMapFetterInfoItem InitFetter()
	{
		return new RogueBattleMapFetterInfoItem();
	}

	// Token: 0x06012054 RID: 73812 RVA: 0x0054D52C File Offset: 0x0054B72C
	private void RefreshFetterDescList(int bondId)
	{
		RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(bondId);
		RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(bondId);
		List<IRogueBattleMapFetterInfo> list = new List<IRogueBattleMapFetterInfo>();
		List<DicIntInt> list2 = new List<DicIntInt>(rogueResBond.Value.StarMapIter());
		list2.Sort((DicIntInt a, DicIntInt b) => a.Key - b.Key);
		if (list2.Count > 0)
		{
			foreach (DicIntInt dicIntInt in list2)
			{
				int key = dicIntInt.Key;
				RogueBattleMapFetterInfo item = new RogueBattleMapFetterInfo
				{
					ConfigId = bondId,
					Level = key,
					IsReached = (key <= roleBondDataById.Level)
				};
				list.Add(item);
			}
			this.FetterLayout.SetActive(true);
			this.FetterLayout.RefreshByData(list, null, false);
			return;
		}
		this.FetterLayout.SetActive(false);
	}

	// Token: 0x06012055 RID: 73813 RVA: 0x0054D63C File Offset: 0x0054B83C
	private List<int> GetRecommendBondLinkRole()
	{
		List<int> list = new List<int>();
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		List<RoleDataBase> list2 = new List<RoleDataBase>();
		for (int i = 1; i <= 3; i++)
		{
			RoleDataBase item;
			if (roleIndexMap.TryGetValue(i, out item))
			{
				list2.Add(item);
			}
		}
		if (RogueBattleModel.Instance.GetLinkIdByRoleList(list2) > 0)
		{
			return list;
		}
		int num = 0;
		List<RoleBondInfo> allOwnedRoleBondData = RogueBattleModel.Instance.GetAllOwnedRoleBondData();
		Comparison<RoleBondInfo> comparison;
		if ((comparison = RogueBattleTeamRoleSelectView.<>O.<0>__SortRogueBattleRoleBondInfo) == null)
		{
			comparison = (RogueBattleTeamRoleSelectView.<>O.<0>__SortRogueBattleRoleBondInfo = new Comparison<RoleBondInfo>(RogueBattleDefine.SortRogueBattleRoleBondInfo));
		}
		allOwnedRoleBondData.Sort(comparison);
		foreach (RoleBondInfo roleBondInfo in allOwnedRoleBondData)
		{
			if (RogueBattleModel.Instance.IsBondLinkCanActivate(roleBondInfo.ConfigId))
			{
				num = roleBondInfo.ConfigId;
				break;
			}
		}
		if (num == 0)
		{
			return list;
		}
		int num2 = 0;
		for (int j = 0; j < this.CurrentBondInfoList.Count; j++)
		{
			if (num == this.CurrentBondInfoList[j].ConfigId)
			{
				num2 = j;
				break;
			}
		}
		if (this.CurrentSelectBondIndex != 0 && this.CurrentSelectBondIndex != num2)
		{
			return list;
		}
		RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(num);
		List<<RogueBattleTeamRoleSelectView>F80CE81D4B03EE93209CC78036A5B3988832147CE112EDE2DFB122AA61A0AD205__RecommendRoleIdInfo> list3 = new List<<RogueBattleTeamRoleSelectView>F80CE81D4B03EE93209CC78036A5B3988832147CE112EDE2DFB122AA61A0AD205__RecommendRoleIdInfo>();
		foreach (RoleDataBase roleDataBase in this.RoleList)
		{
			int dataId = roleDataBase.GetDataId();
			RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(roleDataBase.GetRoleId());
			bool flag = false;
			if (rogueResBondRole != null)
			{
				using (IEnumerator<int> enumerator3 = rogueResBondRole.Value.BondIdsIter().GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						if (enumerator3.Current == num)
						{
							flag = true;
							break;
						}
					}
				}
			}
			if (flag)
			{
				RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(dataId);
				<RogueBattleTeamRoleSelectView>F80CE81D4B03EE93209CC78036A5B3988832147CE112EDE2DFB122AA61A0AD205__RecommendRoleIdInfo item2 = new <RogueBattleTeamRoleSelectView>F80CE81D4B03EE93209CC78036A5B3988832147CE112EDE2DFB122AA61A0AD205__RecommendRoleIdInfo
				{
					RoleId = dataId,
					RoleStarLv = roleInfoById.Level
				};
				list3.Add(item2);
			}
		}
		list3.Sort((<RogueBattleTeamRoleSelectView>F80CE81D4B03EE93209CC78036A5B3988832147CE112EDE2DFB122AA61A0AD205__RecommendRoleIdInfo a, <RogueBattleTeamRoleSelectView>F80CE81D4B03EE93209CC78036A5B3988832147CE112EDE2DFB122AA61A0AD205__RecommendRoleIdInfo b) => b.RoleStarLv - a.RoleStarLv);
		int num3 = 0;
		while (num3 < rogueResBond.Value.ActLinkNum && num3 <= list3.Count)
		{
			list.Add(list3[num3].RoleId);
			num3++;
		}
		return list;
	}

	// Token: 0x06012056 RID: 73814 RVA: 0x0054D8D8 File Offset: 0x0054BAD8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num;
		if (configParams.Length != 0 && int.TryParse(configParams[0], out num) && num != 0)
		{
			UUIItem scrollItemByRoleId = this.GetScrollItemByRoleId(num);
			if (scrollItemByRoleId != null)
			{
				return new UUIItem[]
				{
					scrollItemByRoleId,
					scrollItemByRoleId
				};
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Guide;
		ELogAuthor author = ELogAuthor.TZJ;
		string message = "聚焦引导extraParam项配置有误";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06012057 RID: 73815 RVA: 0x0054D93C File Offset: 0x0054BB3C
	[NullableContext(2)]
	private UUIItem GetScrollItemByRoleId(int roleId)
	{
		int index = this.RoleGridInfoList.FindIndex((IRogueBattleTeamRoleGridInfo info) => info.RoleData.GetRoleId() == roleId);
		if (index < 0)
		{
			return null;
		}
		LoopScrollView<RogueBattleTeamRoleGrid, IRogueBattleTeamRoleGridInfo> roleScrollView = this.RoleScrollView;
		UUIItem result = (roleScrollView != null) ? roleScrollView.GetGrid(index) : null;
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			this.RoleScrollView.ScrollToGridIndex(index, false);
		}, null, null);
		return result;
	}

	// Token: 0x04009D2C RID: 40236
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private CommonDropDown<RoleBondInfo, RoleBondInfo> CommonDropDown;

	// Token: 0x04009D2D RID: 40237
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009D2E RID: 40238
	[Nullable(2)]
	private ButtonItem ButtonConfirm;

	// Token: 0x04009D2F RID: 40239
	[Nullable(2)]
	private ButtonItem ButtonRoleDetail;

	// Token: 0x04009D30 RID: 40240
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RogueBattleTeamRoleGrid, IRogueBattleTeamRoleGridInfo> RoleScrollView;

	// Token: 0x04009D31 RID: 40241
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RogueBattleRoleSelectFetterItem, RoleBondInfo> FetterIconLayout;

	// Token: 0x04009D32 RID: 40242
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RogueBattleMapFetterInfoItem, IRogueBattleMapFetterInfo> FetterLayout;

	// Token: 0x04009D33 RID: 40243
	private int FormationIndex = -1;

	// Token: 0x04009D34 RID: 40244
	private int CurrentSelectBondIndex = -1;

	// Token: 0x04009D35 RID: 40245
	private List<RoleBondInfo> CurrentBondInfoList = new List<RoleBondInfo>();

	// Token: 0x04009D36 RID: 40246
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x04009D37 RID: 40247
	private List<IRogueBattleTeamRoleGridInfo> RoleGridInfoList = new List<IRogueBattleTeamRoleGridInfo>();

	// Token: 0x04009D38 RID: 40248
	[Nullable(2)]
	private RoleDataBase CurSelectRole;

	// Token: 0x04009D39 RID: 40249
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<List<int>, UniTask> OnConfirm;

	// Token: 0x04009D3A RID: 40250
	private bool WaitClose;

	// Token: 0x02007F64 RID: 32612
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04029399 RID: 168857
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<RoleBondInfo> <0>__SortRogueBattleRoleBondInfo;
	}
}
