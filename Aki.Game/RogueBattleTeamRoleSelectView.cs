using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002778 RID: 10104
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleTeamRoleSelectView : UiViewBase
{
	// Token: 0x06014B59 RID: 84825 RVA: 0x0053DD1C File Offset: 0x0053BF1C
	public RogueBattleTeamRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014B5A RID: 84826 RVA: 0x0053DD54 File Offset: 0x0053BF54
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

	// Token: 0x06014B5B RID: 84827 RVA: 0x0053DE60 File Offset: 0x0053C060
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleTeamRoleSelectView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTeamRoleSelectView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014B5C RID: 84828 RVA: 0x0053DEA4 File Offset: 0x0053C0A4
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

	// Token: 0x06014B5D RID: 84829 RVA: 0x0053DF9C File Offset: 0x0053C19C
	private void OnBtnClose()
	{
		if (this.WaitClose)
		{
			return;
		}
		this.WaitClose = true;
		base.CloseMe(null);
	}

	// Token: 0x06014B5E RID: 84830 RVA: 0x0053DFB8 File Offset: 0x0053C1B8
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

	// Token: 0x06014B5F RID: 84831 RVA: 0x0053E024 File Offset: 0x0053C224
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

	// Token: 0x06014B60 RID: 84832 RVA: 0x0053E0BD File Offset: 0x0053C2BD
	private RogueBattleFilterDropDownItem CreateDropDownItem(UUIItem uiItem, RoleBondInfo data)
	{
		return new RogueBattleFilterDropDownItem(uiItem);
	}

	// Token: 0x06014B61 RID: 84833 RVA: 0x0053E0C5 File Offset: 0x0053C2C5
	private RogueBattleFilterDropDownTitle CreateTitleItem(UUIItem uiItem)
	{
		return new RogueBattleFilterDropDownTitle(uiItem);
	}

	// Token: 0x06014B62 RID: 84834 RVA: 0x0053E0D0 File Offset: 0x0053C2D0
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

	// Token: 0x06014B63 RID: 84835 RVA: 0x0053E1B2 File Offset: 0x0053C3B2
	private void OnDropDownSelectCall(int index, object _)
	{
		this.CurrentSelectBondIndex = index;
		this.RefreshRoleList();
	}

	// Token: 0x06014B64 RID: 84836 RVA: 0x0053E1C1 File Offset: 0x0053C3C1
	private RoleBondInfo GetDropDownTextId(object data)
	{
		return (RoleBondInfo)data;
	}

	// Token: 0x06014B65 RID: 84837 RVA: 0x0053E1CC File Offset: 0x0053C3CC
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

	// Token: 0x06014B66 RID: 84838 RVA: 0x0053E210 File Offset: 0x0053C410
	private List<IRogueBattleTeamRoleGridInfo> GetRoleListInfo()
	{
		List<IRogueBattleTeamRoleGridInfo> list = new List<IRogueBattleTeamRoleGridInfo>();
		List<int> recommendBondLinkRole = this.GetRecommendBondLinkRole();
		foreach (RoleDataBase roleDataBase in this.RoleList)
		{
			int dataId = roleDataBase.GetDataId();
			RoleBondInfo roleBondInfo = this.CurrentBondInfoList[this.CurrentSelectBondIndex];
			if (RoleSelectModel.Instance.GetRoleIndex(dataId) != 0 || roleBondInfo.ConfigId <= 0 || RogueBattleConfig.Instance.GetRogueResBondRole(roleDataBase.GetRoleId()).Value.BondIdsIter().Contains(roleBondInfo.ConfigId))
			{
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

	// Token: 0x06014B67 RID: 84839 RVA: 0x0053E344 File Offset: 0x0053C544
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

	// Token: 0x06014B68 RID: 84840 RVA: 0x0053E374 File Offset: 0x0053C574
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

	// Token: 0x06014B69 RID: 84841 RVA: 0x0053E3B9 File Offset: 0x0053C5B9
	private RogueBattleTeamRoleGrid OnGridProxyCreate()
	{
		RogueBattleTeamRoleGrid rogueBattleTeamRoleGrid = new RogueBattleTeamRoleGrid();
		rogueBattleTeamRoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		rogueBattleTeamRoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return rogueBattleTeamRoleGrid;
	}

	// Token: 0x06014B6A RID: 84842 RVA: 0x0053E3E4 File Offset: 0x0053C5E4
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

	// Token: 0x06014B6B RID: 84843 RVA: 0x0053E504 File Offset: 0x0053C704
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

	// Token: 0x06014B6C RID: 84844 RVA: 0x0053E544 File Offset: 0x0053C744
	public void OnRoleSelect(RoleDataBase roleData)
	{
		this.CurSelectRole = roleData;
		base.GetText(4).SetText(roleData.GetName(null), true);
		this.RefreshFetterIconList(roleData);
	}

	// Token: 0x06014B6D RID: 84845 RVA: 0x0053E57B File Offset: 0x0053C77B
	private RogueBattleRoleSelectFetterItem InitFetterIcon()
	{
		return new RogueBattleRoleSelectFetterItem
		{
			OnToggleClick = new Action<RoleBondInfo>(this.OnFetterIconToggleSelect)
		};
	}

	// Token: 0x06014B6E RID: 84846 RVA: 0x0053E594 File Offset: 0x0053C794
	private void OnFetterIconToggleSelect(RoleBondInfo bondInfo)
	{
		this.FetterIconLayout.DeselectCurrentGridProxy();
		this.FetterIconLayout.SelectGridProxyByKey(bondInfo.ConfigId, true);
		this.RefreshFetterDescList(bondInfo.ConfigId);
	}

	// Token: 0x06014B6F RID: 84847 RVA: 0x0053E5C4 File Offset: 0x0053C7C4
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

	// Token: 0x06014B70 RID: 84848 RVA: 0x0053E6DC File Offset: 0x0053C8DC
	private RogueBattleMapFetterInfoItem InitFetter()
	{
		return new RogueBattleMapFetterInfoItem();
	}

	// Token: 0x06014B71 RID: 84849 RVA: 0x0053E6E4 File Offset: 0x0053C8E4
	private void RefreshFetterDescList(int bondId)
	{
		RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(bondId);
		RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(bondId);
		List<IRogueBattleMapFetterInfo> list = new List<IRogueBattleMapFetterInfo>();
		List<DicIntInt> list2 = rogueResBond.Value.StarMapIter().ToList<DicIntInt>();
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

	// Token: 0x06014B72 RID: 84850 RVA: 0x0053E7F4 File Offset: 0x0053C9F4
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
			if (rogueResBondRole != null && rogueResBondRole.Value.BondIdsIter().Contains(num))
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

	// Token: 0x06014B73 RID: 84851 RVA: 0x0053EA58 File Offset: 0x0053CC58
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

	// Token: 0x06014B74 RID: 84852 RVA: 0x0053EABC File Offset: 0x0053CCBC
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

	// Token: 0x04009BD4 RID: 39892
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private CommonDropDown<RoleBondInfo, RoleBondInfo> CommonDropDown;

	// Token: 0x04009BD5 RID: 39893
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009BD6 RID: 39894
	[Nullable(2)]
	private ButtonItem ButtonConfirm;

	// Token: 0x04009BD7 RID: 39895
	[Nullable(2)]
	private ButtonItem ButtonRoleDetail;

	// Token: 0x04009BD8 RID: 39896
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RogueBattleTeamRoleGrid, IRogueBattleTeamRoleGridInfo> RoleScrollView;

	// Token: 0x04009BD9 RID: 39897
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RogueBattleRoleSelectFetterItem, RoleBondInfo> FetterIconLayout;

	// Token: 0x04009BDA RID: 39898
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RogueBattleMapFetterInfoItem, IRogueBattleMapFetterInfo> FetterLayout;

	// Token: 0x04009BDB RID: 39899
	private int FormationIndex = -1;

	// Token: 0x04009BDC RID: 39900
	private int CurrentSelectBondIndex = -1;

	// Token: 0x04009BDD RID: 39901
	private List<RoleBondInfo> CurrentBondInfoList = new List<RoleBondInfo>();

	// Token: 0x04009BDE RID: 39902
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x04009BDF RID: 39903
	private List<IRogueBattleTeamRoleGridInfo> RoleGridInfoList = new List<IRogueBattleTeamRoleGridInfo>();

	// Token: 0x04009BE0 RID: 39904
	[Nullable(2)]
	private RoleDataBase CurSelectRole;

	// Token: 0x04009BE1 RID: 39905
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<List<int>, UniTask> OnConfirm;

	// Token: 0x04009BE2 RID: 39906
	private bool WaitClose;

	// Token: 0x02008DDD RID: 36317
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402E085 RID: 188549
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<RoleBondInfo> <0>__SortRogueBattleRoleBondInfo;
	}
}
