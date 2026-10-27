using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200278E RID: 10126
[NullableContext(1)]
[Nullable(0)]
public class QuickRoleSelectView : UiViewBase
{
	// Token: 0x06014C62 RID: 85090 RVA: 0x00542609 File Offset: 0x00540809
	public QuickRoleSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014C63 RID: 85091 RVA: 0x00542614 File Offset: 0x00540814
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIInteractionGroup)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.ConfirmClick)),
			new ValueTuple<int, Delegate>(4, new Action(this.BackClick)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnDetailClick))
		};
	}

	// Token: 0x06014C64 RID: 85092 RVA: 0x005427EC File Offset: 0x005409EC
	private void ConfirmClick()
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
		QuickRoleSelectViewData data = this.Data;
		Func<int[], bool> func = (data != null) ? data.CanConfirm : null;
		if (func != null && !func(list.ToArray()))
		{
			return;
		}
		QuickRoleSelectViewData data2 = this.Data;
		if (((data2 != null) ? data2.OnWaitLoadingConfirm : null) == null)
		{
			EventSystem.Instance.Emit(EEventName.TowerDefenseBeforeConfirmQuickRoleSelect);
			QuickRoleSelectViewData data3 = this.Data;
			if (data3 != null)
			{
				Action<int[]> onConfirm = data3.OnConfirm;
				if (onConfirm != null)
				{
					onConfirm(list.ToArray());
				}
			}
			EventSystem.Instance.Emit(EEventName.TowerDefenseBeforeConfirmQuickRoleSelect);
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			return;
		}
		this.ShowLoading();
		QuickRoleSelectViewData data4 = this.Data;
		if (data4 == null)
		{
			return;
		}
		data4.OnWaitLoadingConfirm(list).ContinueWith(delegate()
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x06014C65 RID: 85093 RVA: 0x005428F0 File Offset: 0x00540AF0
	private void ShowLoading()
	{
		if (this.DelayLoadingTimer == null)
		{
			base.GetItem(14).SetUIActive(true);
			this.DelayLoadingTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UUIButtonComponent button = base.GetButton(4);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				UUIItem item = base.GetItem(13);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UiSequencePlayer loadingSequencePlayer = this.LoadingSequencePlayer;
				if (loadingSequencePlayer == null)
				{
					return;
				}
				loadingSequencePlayer.PlaySequence("Progressing", false, null);
			}, 500f, null, null, true, 1f);
		}
		if (this.AutoCloseTimer == null)
		{
			this.AutoCloseTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiManager.Instance.ResetToBattleView(null);
			}, 30000f, null, null, true, 1f);
		}
	}

	// Token: 0x06014C66 RID: 85094 RVA: 0x00542980 File Offset: 0x00540B80
	private void BackClick()
	{
		QuickRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action onBack = data.OnBack;
			if (onBack != null)
			{
				onBack();
			}
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x06014C67 RID: 85095 RVA: 0x005429B4 File Offset: 0x00540BB4
	private unsafe void OnDetailClick()
	{
		int num = this.LastAddFormationRoleId;
		List<int> list = RoleSelectModel.Instance.SelectedRoleSet.ToList<int>();
		if (list.Count > 0 && num == 0)
		{
			List<int> list2 = list;
			num = list2[list2.Count - 1];
		}
		List<int> list3;
		if (num < 100000)
		{
			list3 = RoleModel.Instance.GetRoleIdList();
		}
		else
		{
			int num2 = 1;
			List<int> list4 = new List<int>(num2);
			CollectionsMarshal.SetCount<int>(list4, num2);
			list3 = list4;
			Span<int> span = CollectionsMarshal.AsSpan<int>(list4);
			int index = 0;
			*span[index] = num;
		}
		List<int> roleIdList = list3;
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, num, roleIdList, null, delegate(bool success, int _)
		{
			if (success)
			{
				EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
				EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
				RoleModel.Instance.StartRecordRoleSkillBranchChangeRequest();
			}
		});
	}

	// Token: 0x06014C68 RID: 85096 RVA: 0x00542A50 File Offset: 0x00540C50
	private void OnCloseView(EUiViewName viewName, int i)
	{
		if (viewName == EUiViewName.RoleRootView)
		{
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
			List<int> list = RoleModel.Instance.StopRecordRoleSkillBranchChangeRequest();
			if (list.Count > 0 && this.RoleScrollView != null && this.RoleList != null)
			{
				for (int j = 0; j < list.Count; j++)
				{
					int num = list[j];
					for (int k = 0; k < this.RoleList.Count; k++)
					{
						if (this.RoleList[k].GetDataId() == num)
						{
							this.RoleScrollView.RefreshGridProxy(k);
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06014C69 RID: 85097 RVA: 0x00542B17 File Offset: 0x00540D17
	private void OnRoleChangeEnd()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014C6A RID: 85098 RVA: 0x00542B20 File Offset: 0x00540D20
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as QuickRoleSelectViewData);
		this.RoleScrollView = new LoopScrollView<TeamRoleGrid, RoleDataBase>(base.GetLoopScrollViewComponent(1), base.GetItem(10).GetOwner() as AUIBaseActor, new Func<TeamRoleGrid>(this.OnGridProxyCreate), false);
		this.LoadingSequencePlayer = new UiSequencePlayer(base.GetItem(13));
		UUIText text = base.GetText(15);
		if (text != null)
		{
			text.SetUIActive(MowingTowerModel.Instance.CurrentOptionArea != -1);
		}
		int[] addLevel = MowingTowerModel.Instance.AddLevel;
		if (addLevel != null && addLevel.Length != 0)
		{
			int num = addLevel[0];
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "MowTower_LevelTips", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num
			}));
		}
		bool flag = this.Data != null && !string.IsNullOrEmpty(this.Data.YellowTipText);
		base.GetButton(12).RootUIComp.Get().SetUIActive(this.Data.ShowDetailButton && !flag);
		UUIItem item = base.GetItem(16);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (this.Data != null && !string.IsNullOrEmpty(this.Data.YellowTipText))
		{
			UUIText text2 = base.GetText(17);
			if (text2 != null)
			{
				text2.SetText(this.Data.YellowTipText, true);
			}
		}
		this.RefreshRoleList();
	}

	// Token: 0x06014C6B RID: 85099 RVA: 0x00542C90 File Offset: 0x00540E90
	protected void RefreshRoleList()
	{
		QuickRoleSelectViewData data = this.Data;
		this.RoleList = ((data != null) ? data.RoleList : null);
		QuickRoleSelectViewData data2 = this.Data;
		int[] array = (data2 != null) ? data2.SelectedRoleList : null;
		RoleSelectModel.Instance.ClearData();
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		if (array != null && this.RoleList != null)
		{
			int num = 1;
			while (num <= 3 && num <= array.Length)
			{
				int num2 = array[num - 1];
				foreach (RoleDataBase roleDataBase in this.RoleList)
				{
					if (roleDataBase.GetDataId() == num2)
					{
						roleIndexMap[num] = roleDataBase;
						selectedRoleSet.Add(roleDataBase.GetDataId());
						break;
					}
				}
				num++;
			}
		}
		if (this.Data == null || this.Data.UseWay == null || this.RoleList == null)
		{
			return;
		}
		UUIItem item = base.GetItem(8);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(item, new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
		this.RoleList.Sort((RoleDataBase a, RoleDataBase b) => b.GetRoleConfig().Priority - a.GetRoleConfig().Priority);
		this.FilterSortEntrance.UpdateData(this.Data.UseWay.Value, this.RoleList, Array.Empty<object>());
		base.GetItem(5).SetUIActive(false);
		base.GetText(9).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "FastFormation_Finish", Array.Empty<object>());
		this.RefreshConfirmBtn();
	}

	// Token: 0x06014C6C RID: 85100 RVA: 0x00542E48 File Offset: 0x00541048
	protected override void OnBeforeDestroy()
	{
		QuickRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action onHideFinish = data.OnHideFinish;
			if (onHideFinish != null)
			{
				onHideFinish();
			}
		}
		this.Data = null;
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.FilterSortEntrance = null;
		LoopScrollView<TeamRoleGrid, RoleDataBase> roleScrollView = this.RoleScrollView;
		if (roleScrollView != null)
		{
			roleScrollView.ClearGridProxies();
		}
		this.RoleScrollView = null;
		List<RoleDataBase> roleList = this.RoleList;
		if (roleList != null)
		{
			roleList.Clear();
		}
		this.RoleList = null;
		if (this.DelayLoadingTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.DelayLoadingTimer);
			this.DelayLoadingTimer = null;
		}
		if (this.AutoCloseTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoCloseTimer);
			this.AutoCloseTimer = null;
		}
	}

	// Token: 0x06014C6D RID: 85101 RVA: 0x00542F01 File Offset: 0x00541101
	private TeamRoleGrid OnGridProxyCreate()
	{
		TeamRoleGrid teamRoleGrid = new TeamRoleGrid();
		teamRoleGrid.IsShowGray = new Func<int, bool>(this.IsShowGray);
		teamRoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		teamRoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
		return teamRoleGrid;
	}

	// Token: 0x06014C6E RID: 85102 RVA: 0x00542F3F File Offset: 0x0054113F
	protected bool IsShowGray(int roleId)
	{
		QuickRoleSelectViewData data = this.Data;
		return data == null || !data.CanUseSpecialTrialRole || !RoleUtils.IsSpecialTrialRole(roleId);
	}

	// Token: 0x06014C6F RID: 85103 RVA: 0x00542F60 File Offset: 0x00541160
	protected void ToggleFunction(MediumItemGridExtendCallback @params)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		RoleDataBase roleDataBase = @params.Data as RoleDataBase;
		if (roleDataBase == null)
		{
			return;
		}
		if (@params.State == EToggleState.ETT_UnChecked)
		{
			using (List<KeyValuePair<int, RoleDataBase>>.Enumerator enumerator = roleIndexMap.ToList<KeyValuePair<int, RoleDataBase>>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, RoleDataBase> keyValuePair = enumerator.Current;
					if (keyValuePair.Value == roleDataBase)
					{
						roleIndexMap.Remove(keyValuePair.Key);
						selectedRoleSet.Remove(roleDataBase.GetDataId());
						this.LastAddFormationRoleId = 0;
						break;
					}
				}
				goto IL_D4;
			}
		}
		if (@params.State == EToggleState.ETT_Checked)
		{
			for (int i = 1; i <= 3; i++)
			{
				if (!roleIndexMap.ContainsKey(i))
				{
					roleIndexMap[i] = roleDataBase;
					selectedRoleSet.Add(roleDataBase.GetDataId());
					this.LastAddFormationRoleId = roleDataBase.GetDataId();
					break;
				}
			}
		}
		IL_D4:
		if (this.RoleList == null || this.RoleScrollView == null)
		{
			return;
		}
		int gridIndex = this.RoleList.IndexOf(roleDataBase);
		this.RoleScrollView.RefreshGridProxy(gridIndex);
		this.RefreshConfirmBtn();
	}

	// Token: 0x06014C70 RID: 85104 RVA: 0x00543084 File Offset: 0x00541284
	private void RefreshConfirmBtn()
	{
		if (this.Data == null || !this.Data.IsNeedChangeBtnState || this.Data.CanConfirm == null)
		{
			return;
		}
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
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(this.Data.CanConfirm(list.ToArray()));
	}

	// Token: 0x06014C71 RID: 85105 RVA: 0x00543110 File Offset: 0x00541310
	protected virtual bool CanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		RoleDataBase roleDataBase = data as RoleDataBase;
		if (roleDataBase == null)
		{
			return false;
		}
		int roleId = roleDataBase.GetRoleId();
		List<int> otherHalfAreaRoleList = MowingTowerModel.Instance.OtherHalfAreaRoleList;
		if (otherHalfAreaRoleList != null && otherHalfAreaRoleList.Contains(roleId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("EditBattleTeamCannotSwitchOtherArea", Array.Empty<object>());
			return false;
		}
		if (RoleSelectModel.Instance.RoleIndexMap.Count >= 3)
		{
			QuickRoleSelectViewData data2 = this.Data;
			if (((data2 != null) ? data2.OnRoleSelectFull : null) != null)
			{
				QuickRoleSelectViewData data3 = this.Data;
				if (data3 != null)
				{
					data3.OnRoleSelectFull();
				}
			}
			else
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			}
			return false;
		}
		QuickRoleSelectViewData data4 = this.Data;
		if ((data4 == null || !data4.CanUseSpecialTrialRole) && RoleUtils.IsSpecialTrialRole(roleDataBase.GetDataId()))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_1024721374_Text", Array.Empty<object>());
			return false;
		}
		QuickRoleSelectViewData data5 = this.Data;
		Func<int, int[], bool> func = (data5 != null) ? data5.CanSelectRole : null;
		if (func != null)
		{
			int[] arg = RoleSelectModel.Instance.SelectedRoleSet.ToArray<int>();
			if (!func(roleDataBase.GetDataId(), arg))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014C72 RID: 85106 RVA: 0x0054322C File Offset: 0x0054142C
	private void UpdateRoleList(List<RoleDataBase> list, bool isShowText, EFilterSortType type)
	{
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
		foreach (RoleDataBase item2 in list)
		{
			if (!list2.Contains(item2))
			{
				list2.Add(item2);
			}
		}
		bool flag = list2.Count > 0;
		base.GetItem(11).SetUIActive(!flag);
		base.GetButton(3).RootUIComp.Get().SetUIActive(flag);
		bool flag2 = this.Data != null && !string.IsNullOrEmpty(this.Data.YellowTipText);
		base.GetItem(16).SetUIActive(flag2 && flag);
		base.GetButton(12).RootUIComp.Get().SetUIActive(this.Data.ShowDetailButton && !flag2 && flag);
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(flag);
		if (!flag)
		{
			return;
		}
		if (this.RoleScrollView == null || this.RoleList == null)
		{
			return;
		}
		this.RoleScrollView.RefreshByData(list2, false, null, false);
		foreach (RoleDataBase roleDataBase in roleIndexMap.Values)
		{
			int num = this.RoleList.IndexOf(roleDataBase);
			int num2 = list2.IndexOf(roleDataBase);
			if (this.RoleScrollView.StartGridIndex >= 0 && num != num2 && num < this.RoleScrollView.GetDisplayGridEndIndex())
			{
				RoleSelectModel.Instance.SelectedRoleSet.Remove(roleDataBase.GetDataId());
				TeamRoleGrid teamRoleGrid = this.RoleScrollView.UnsafeGetGridProxy(num, false);
				if (teamRoleGrid != null)
				{
					teamRoleGrid.OnDeselected(false);
				}
			}
		}
		foreach (RoleDataBase roleDataBase2 in roleIndexMap.Values)
		{
			int gridIndex = list2.IndexOf(roleDataBase2);
			RoleSelectModel.Instance.SelectedRoleSet.Add(roleDataBase2.GetDataId());
			TeamRoleGrid teamRoleGrid2 = this.RoleScrollView.UnsafeGetGridProxy(gridIndex, false);
			if (teamRoleGrid2 != null)
			{
				teamRoleGrid2.OnForceSelected();
			}
		}
		this.RoleList = list2;
	}

	// Token: 0x04009C58 RID: 40024
	[Nullable(2)]
	protected QuickRoleSelectViewData Data;

	// Token: 0x04009C59 RID: 40025
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04009C5A RID: 40026
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<TeamRoleGrid, RoleDataBase> RoleScrollView;

	// Token: 0x04009C5B RID: 40027
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<RoleDataBase> RoleList;

	// Token: 0x04009C5C RID: 40028
	[Nullable(2)]
	protected TimerHandle DelayLoadingTimer;

	// Token: 0x04009C5D RID: 40029
	[Nullable(2)]
	protected TimerHandle AutoCloseTimer;

	// Token: 0x04009C5E RID: 40030
	[Nullable(2)]
	protected UiSequencePlayer LoadingSequencePlayer;

	// Token: 0x04009C5F RID: 40031
	private int LastAddFormationRoleId;

	// Token: 0x02008DF5 RID: 36341
	[NullableContext(0)]
	public enum EComponentType
	{
		// Token: 0x0402E0EB RID: 188651
		ConfirmButtonInteractionGroup,
		// Token: 0x0402E0EC RID: 188652
		RoleScroll,
		// Token: 0x0402E0ED RID: 188653
		ConfirmText,
		// Token: 0x0402E0EE RID: 188654
		ConfirmButton,
		// Token: 0x0402E0EF RID: 188655
		CloseButton,
		// Token: 0x0402E0F0 RID: 188656
		BottomGroup,
		// Token: 0x0402E0F1 RID: 188657
		TeamRoleOne,
		// Token: 0x0402E0F2 RID: 188658
		TeamRoleTwo,
		// Token: 0x0402E0F3 RID: 188659
		FilterSortEntrance,
		// Token: 0x0402E0F4 RID: 188660
		TipsText,
		// Token: 0x0402E0F5 RID: 188661
		RoleItem,
		// Token: 0x0402E0F6 RID: 188662
		NoneRoleTips,
		// Token: 0x0402E0F7 RID: 188663
		DetailButton,
		// Token: 0x0402E0F8 RID: 188664
		LoadingItem,
		// Token: 0x0402E0F9 RID: 188665
		DisableClickMask,
		// Token: 0x0402E0FA RID: 188666
		BottomTipsText,
		// Token: 0x0402E0FB RID: 188667
		ItemYellowTipPanel,
		// Token: 0x0402E0FC RID: 188668
		TextYellowTip
	}
}
