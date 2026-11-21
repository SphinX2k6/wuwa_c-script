using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C77 RID: 7287
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleSelectView : UiViewBase
{
	// Token: 0x06012124 RID: 74020 RVA: 0x00550064 File Offset: 0x0054E264
	public MultiTeamRoleSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06012125 RID: 74021 RVA: 0x00550090 File Offset: 0x0054E290
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIMultiTemplateLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(25, typeof(UUIText)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(15, new Action(this.OnDetailClick)),
			new ValueTuple<int, Delegate>(18, new Action<EToggleState>(this.OnSkillModeToggleClick)),
			new ValueTuple<int, Delegate>(24, new Action(this.OnClickUnRecommendRoleBtn))
		};
	}

	// Token: 0x06012126 RID: 74022 RVA: 0x0055037C File Offset: 0x0054E57C
	protected override UniTask OnBeforeStartAsync()
	{
		MultiTeamRoleSelectView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MultiTeamRoleSelectView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012127 RID: 74023 RVA: 0x005503C0 File Offset: 0x0054E5C0
	protected override void OnStart()
	{
		this.DisplaySkillTypes = ConfigCommonParamById.GetIntArrayConfig("DisplaySkillTypes");
		MultiTeamRoleSelectData data = this.Data;
		if (((data != null) ? data.Tips : null) != null && !string.IsNullOrEmpty(this.Data.Tips))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(25), this.Data.Tips, Array.Empty<object>());
		}
		UUIButtonComponent button = base.GetButton(24);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				MultiTeamRoleSelectData data2 = this.Data;
				uuiitem.SetUIActive(data2 == null || data2.ShowUnRecommendBtn);
			}
		}
		MultiTeamRoleSelectData data3 = this.Data;
		if (((data3 != null) ? data3.ConfirmBtnText : null) != null && !string.IsNullOrEmpty(this.Data.ConfirmBtnText))
		{
			this.ConfirmBtn.SetLocalTextNew(this.Data.ConfirmBtnText, Array.Empty<object>());
		}
	}

	// Token: 0x06012128 RID: 74024 RVA: 0x0055049E File Offset: 0x0054E69E
	private MultiTeamRoleGrid InitRoleGrid()
	{
		return new MultiTeamRoleGrid();
	}

	// Token: 0x06012129 RID: 74025 RVA: 0x005504A5 File Offset: 0x0054E6A5
	private TeamRoleSkillItem InitSkillItem()
	{
		TeamRoleSkillItem teamRoleSkillItem = new TeamRoleSkillItem();
		teamRoleSkillItem.BindOnSkillStateChange(new Action<EToggleState, TeamRoleSkillData>(this.OnSkillItemStateChanged));
		return teamRoleSkillItem;
	}

	// Token: 0x0601212A RID: 74026 RVA: 0x005504C0 File Offset: 0x0054E6C0
	private void OnSkillModeToggleClick(EToggleState toggleState)
	{
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			RoleModel.Instance.IsShowMultiSkillDesc = (toggleState == EToggleState.ETT_Checked);
		}
		else
		{
			RoleModel.Instance.IsShowSkillResume = (toggleState == EToggleState.ETT_Checked);
		}
		if (this.SkillLayout == null || this.SkillDataList == null)
		{
			return;
		}
		int selectedGridIndex = this.SkillLayout.GetSelectedGridIndex();
		if (selectedGridIndex < 0 || selectedGridIndex >= this.SkillDataList.Count)
		{
			return;
		}
		this.RefreshSkillInfo(this.SkillDataList[selectedGridIndex]);
	}

	// Token: 0x0601212B RID: 74027 RVA: 0x00550538 File Offset: 0x0054E738
	private void OnClickUnRecommendRoleBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerTeamTipsConfirm);
		confirmBoxDataNew.FunctionMap.Add(0, delegate
		{
			ConfirmBoxController.Instance.CloseConfirmBoxView();
		});
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
	}

	// Token: 0x0601212C RID: 74028 RVA: 0x00550588 File Offset: 0x0054E788
	private void RefreshSkillModeToggle()
	{
		this.SkillDescType = RoleModel.Instance.GetRoleSkillDescType();
		UUIExtendToggle extendToggle = base.GetExtendToggle(18);
		if (extendToggle == null)
		{
			return;
		}
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			EToggleState state = RoleModel.Instance.IsShowMultiSkillDesc ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleState(state, false, false, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "MultiplayerSkillDescription_text", Array.Empty<object>());
			return;
		}
		EToggleState state2 = RoleModel.Instance.IsShowSkillResume ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		extendToggle.SetToggleState(state2, false, false, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "SkillBriefDescription_text", Array.Empty<object>());
	}

	// Token: 0x0601212D RID: 74029 RVA: 0x0055062C File Offset: 0x0054E82C
	private void ConfirmClick(int data)
	{
		MultiTeamRoleSelectData data2 = this.Data;
		Func<int[], bool> func = (data2 != null) ? data2.CanConfirmFunc : null;
		if (func != null && !func(this.CurrentSelectRoleList.ToArray()))
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int num in this.CurrentSelectRoleList.ToArray())
		{
			int? valueOrNull = this.CurrentSelectTagMap.GetValueOrNull(num);
			if (valueOrNull != null)
			{
				list.Add(valueOrNull.Value);
			}
			else if (RoleModel.Instance.IsRoleHasBranch(num))
			{
				list.Add(RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(num));
			}
			else
			{
				list.Add(0);
			}
		}
		MultiTeamRoleSelectData data3 = this.Data;
		if (data3 != null)
		{
			Action<int[], int[]> confirmCallBack = data3.ConfirmCallBack;
			if (confirmCallBack != null)
			{
				confirmCallBack(this.CurrentSelectRoleList.ToArray(), list.ToArray());
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x0601212E RID: 74030 RVA: 0x0055070C File Offset: 0x0054E90C
	protected void BackClick()
	{
		MultiTeamRoleSelectData data = this.Data;
		if (data != null)
		{
			Action backCallBack = data.BackCallBack;
			if (backCallBack != null)
			{
				backCallBack();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x0601212F RID: 74031 RVA: 0x00550734 File Offset: 0x0054E934
	private void OnSkillItemStateChanged(EToggleState state, TeamRoleSkillData data)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.SkillDataList == null || this.SkillLayout == null)
		{
			return;
		}
		int gridIndex = this.SkillDataList.IndexOf(data);
		this.SkillLayout.SelectGridProxy(gridIndex, false);
		this.RefreshSkillInfo(data);
	}

	// Token: 0x06012130 RID: 74032 RVA: 0x00550778 File Offset: 0x0054E978
	private unsafe void OnDetailClick()
	{
		int clickSelectRoleId = this.ClickSelectRoleId;
		List<int> list;
		if (clickSelectRoleId < 100000)
		{
			list = RoleModel.Instance.GetRoleIdList(null);
		}
		else
		{
			int num = 1;
			List<int> list2 = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list2, num);
			list = list2;
			Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
			int index = 0;
			*span[index] = clickSelectRoleId;
		}
		List<int> roleIdList = list;
		RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
		{
			AgentType = ERoleAgentType.Normal,
			SelectRoleId = new int?(clickSelectRoleId),
			RoleIdList = roleIdList,
			TeamPositionType = new ETeamPositionType?(ETeamPositionType.EditFormation),
			Source = new ERoleViewSource?(this.Data.RoleViewSource),
			FinishCallback = delegate(bool success, int _)
			{
				if (success)
				{
					EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
					EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
					EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSwitchTagChange));
				}
			}
		});
	}

	// Token: 0x06012131 RID: 74033 RVA: 0x00550824 File Offset: 0x0054EA24
	private void OnCloseView(EUiViewName viewName, int i)
	{
		if (viewName == EUiViewName.RoleRootView)
		{
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
			EventSystem.Instance.Remove(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSwitchTagChange));
			this.RefreshTagSwitchItem(this.ClickSelectRoleId);
			this.RefreshRoleLayout();
		}
	}

	// Token: 0x06012132 RID: 74034 RVA: 0x005508A1 File Offset: 0x0054EAA1
	private void OnRoleChangeEnd()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012133 RID: 74035 RVA: 0x005508AC File Offset: 0x0054EAAC
	private void OnRoleSwitchTagChange(int roleId)
	{
		if (this.CurrentSelectTagMap.GetValueOrNull(roleId) != null)
		{
			this.CurrentSelectTagMap[roleId] = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId);
		}
	}

	// Token: 0x06012134 RID: 74036 RVA: 0x005508E8 File Offset: 0x0054EAE8
	private void UpdateRoleList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType type)
	{
		if (this.Data == null)
		{
			return;
		}
		List<MultiTeamRoleData> multiTeamRoleDataList = this.Data.GetMultiTeamRoleDataList();
		this.CurrentFilterRoleList = list;
		foreach (MultiTeamRoleData multiTeamRoleData in multiTeamRoleDataList)
		{
			multiTeamRoleData.SetSortedRoleList(this.CurrentFilterRoleList);
		}
		this.RefreshNoneRoleTips();
		this.RefreshScrollViewItem();
		this.RefreshCurrentRoleInfo();
		this.RefreshRoleLayout();
	}

	// Token: 0x06012135 RID: 74037 RVA: 0x0055096C File Offset: 0x0054EB6C
	private void RefreshRoleLayout()
	{
		if (this.Data == null || this.RoleLayout == null)
		{
			return;
		}
		List<MultiTeamRoleData> multiTeamRoleDataList = this.Data.GetMultiTeamRoleDataList();
		List<MultiTeamRoleGridContentData> list = new List<MultiTeamRoleGridContentData>();
		foreach (MultiTeamRoleData multiTeamRoleData in multiTeamRoleDataList)
		{
			if (multiTeamRoleData.GetShowMultiTeamRoleGridDataList().Count != 0)
			{
				list.Add(new MultiTeamRoleGridContentData
				{
					Data = multiTeamRoleData,
					CurrentSelectedRoleList = this.CurrentSelectRoleList.ToArray(),
					CurrentSelectTagMap = this.CurrentSelectTagMap,
					OnToggleCallBack = new Action<MediumItemGridExtendCallback>(this.OnRoleGridToggle),
					CanExecuteChangeCallBack = new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeCallBack),
					ShowGridAnimation = this.NeedGridAnimation,
					IsSingleSelect = this.IsSingleSelectMode()
				});
			}
		}
		this.RoleLayout.RefreshByData(list, null, false);
		this.NeedGridAnimation = false;
	}

	// Token: 0x06012136 RID: 74038 RVA: 0x00550A6C File Offset: 0x0054EC6C
	private void OnRoleGridToggle(MediumItemGridExtendCallback data)
	{
		MultiTeamRoleGridData multiTeamRoleGridData = data.Data as MultiTeamRoleGridData;
		if (multiTeamRoleGridData == null || multiTeamRoleGridData.GetRole() == null)
		{
			return;
		}
		int dataId = multiTeamRoleGridData.GetRole().GetDataId();
		int num = this.CurrentSelectRoleList.IndexOf(dataId);
		this.ClickSelectRoleId = dataId;
		if (this.CurrentSelectRoleList.Contains(dataId))
		{
			this.CurrentSelectRoleList[num] = 0;
			if (num > 0)
			{
				this.CurrentSelectRoleId = this.CurrentSelectRoleList[num - 1];
			}
			else
			{
				this.CurrentSelectRoleId = 0;
			}
		}
		else if (this.IsSingleSelectMode())
		{
			this.CurrentSelectRoleList[0] = dataId;
			this.CurrentSelectRoleId = dataId;
		}
		else
		{
			for (int i = 0; i < this.CurrentSelectRoleList.Count; i++)
			{
				if (this.CurrentSelectRoleList[i] == 0)
				{
					this.CurrentSelectRoleList[i] = dataId;
					break;
				}
			}
			this.CurrentSelectRoleId = dataId;
		}
		this.RefreshCurrentRoleInfo();
		this.RefreshRoleLayout();
	}

	// Token: 0x06012137 RID: 74039 RVA: 0x00550B53 File Offset: 0x0054ED53
	private bool IsSingleSelectMode()
	{
		return this.Data != null && this.Data.IsSingleSelect && this.Data.TeamLength == 1;
	}

	// Token: 0x06012138 RID: 74040 RVA: 0x00550B7C File Offset: 0x0054ED7C
	private bool CanExecuteChangeCallBack(object data, bool isForceSelected, EToggleState state)
	{
		if (this.Data == null)
		{
			return false;
		}
		MultiTeamRoleGridData multiTeamRoleGridData = data as MultiTeamRoleGridData;
		if (multiTeamRoleGridData == null || multiTeamRoleGridData.GetRole() == null)
		{
			return false;
		}
		int dataId = multiTeamRoleGridData.GetRole().GetDataId();
		Func<int, int[], bool> ifCanSelectCheck = this.Data.IfCanSelectCheck;
		if (ifCanSelectCheck != null && !ifCanSelectCheck(dataId, this.CurrentSelectRoleList.ToArray()))
		{
			return false;
		}
		if (this.CurrentSelectRoleList.Contains(dataId) || this.IsSingleSelectMode())
		{
			return true;
		}
		int num = 0;
		using (List<int>.Enumerator enumerator = this.CurrentSelectRoleList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current != 0)
				{
					num++;
				}
			}
		}
		if (num >= this.Data.TeamLength)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BossRushMaxLength", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06012139 RID: 74041 RVA: 0x00550C5C File Offset: 0x0054EE5C
	protected override void OnBeforeShow()
	{
		if (this.Data == null || this.FilterSortEntrance == null)
		{
			return;
		}
		this.NeedGridAnimation = true;
		this.FilterSortEntrance.UpdateData(this.Data.UseWay.Value, this.Data.GetSourceRoleList(), Array.Empty<object>());
	}

	// Token: 0x0601213A RID: 74042 RVA: 0x00550CAC File Offset: 0x0054EEAC
	private void RefreshCurrentRoleInfo()
	{
		int roleId = 0;
		if (this.CurrentFilterRoleList.Count != 0)
		{
			roleId = this.ClickSelectRoleId;
		}
		this.CheckCurRoleIsDead(roleId);
		this.RefreshRoleInfo(roleId);
		this.RefreshTopItem(roleId);
		this.RefreshRoleInfoContent(roleId);
		this.RefreshDetailButton(roleId);
		this.RefreshEmptySelectItem(roleId);
		this.RefreshTabItem(roleId);
		this.RefreshTagSwitchItem(roleId);
	}

	// Token: 0x0601213B RID: 74043 RVA: 0x00550D08 File Offset: 0x0054EF08
	private void RefreshTopItem(int roleId)
	{
		bool uiactive = roleId != 0;
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0601213C RID: 74044 RVA: 0x00550D28 File Offset: 0x0054EF28
	private void RefreshDetailButton(int roleId)
	{
		bool flag;
		if (roleId != 0)
		{
			MultiTeamRoleSelectData data = this.Data;
			flag = (data == null || data.ShowDetailButton);
		}
		else
		{
			flag = false;
		}
		bool uiactive = flag;
		base.GetButton(15).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0601213D RID: 74045 RVA: 0x00550D6C File Offset: 0x0054EF6C
	private void RefreshRoleInfoContent(int roleId)
	{
		bool uiactive = roleId != 0;
		base.GetItem(9).SetUIActive(uiactive);
	}

	// Token: 0x0601213E RID: 74046 RVA: 0x00550D8C File Offset: 0x0054EF8C
	private void RefreshNoneRoleTips()
	{
		bool uiactive = this.CurrentFilterRoleList.Count == 0;
		base.GetItem(17).SetUIActive(uiactive);
	}

	// Token: 0x0601213F RID: 74047 RVA: 0x00550DB8 File Offset: 0x0054EFB8
	private void RefreshScrollViewItem()
	{
		bool uiactive = this.CurrentFilterRoleList.Count > 0;
		base.GetItem(20).SetUIActive(uiactive);
	}

	// Token: 0x06012140 RID: 74048 RVA: 0x00550DE4 File Offset: 0x0054EFE4
	private void RefreshEmptySelectItem(int roleId)
	{
		bool uiactive = this.CurrentFilterRoleList.Count > 0 && roleId == 0;
		base.GetItem(21).SetUIActive(uiactive);
	}

	// Token: 0x06012141 RID: 74049 RVA: 0x00550E18 File Offset: 0x0054F018
	private void RefreshTabItem(int roleId)
	{
		bool uiactive = roleId != 0;
		base.GetItem(22).SetUIActive(uiactive);
	}

	// Token: 0x06012142 RID: 74050 RVA: 0x00550E38 File Offset: 0x0054F038
	private void RefreshRoleInfo(int roleId)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) == "Switch")
		{
			this.LevelSequencePlayer.ReplaySequenceByKey("Switch");
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
			}
		}
		this.RefreshRoleName(roleId);
		this.RefreshRoleSkillInfo(roleId);
		this.RefreshRoleTagLayout(roleId);
		this.RefreshRoleUnRecommendLayout(roleId);
	}

	// Token: 0x06012143 RID: 74051 RVA: 0x00550EB4 File Offset: 0x0054F0B4
	private void RefreshRoleName(int roleId)
	{
		if (roleId == 0)
		{
			return;
		}
		RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(roleId);
		if (roleSkinDataByRoleId != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleSkinDataByRoleId.GetName(), Array.Empty<object>());
		}
	}

	// Token: 0x06012144 RID: 74052 RVA: 0x00550EF0 File Offset: 0x0054F0F0
	private void RefreshRoleSkillInfo(int roleId)
	{
		if (roleId == 0)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return;
		}
		IReadOnlyList<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleConfig.Value.SkillId);
		if (skillList == null || skillList.Count == 0)
		{
			return;
		}
		IReadOnlyList<Aki.Config.Skill> readOnlyList = null;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById != null)
		{
			RoleSkillData skillData = roleDataById.GetSkillData();
			if (skillData != null && skillData.HasAnySkillUpgrade())
			{
				readOnlyList = new List<Aki.Config.Skill>(skillList);
				for (int i = 0; i < readOnlyList.Count; i++)
				{
					int id = readOnlyList[i].Id;
					int skillIdAfterUpgrade = skillData.GetSkillIdAfterUpgrade(id);
					if (skillIdAfterUpgrade > 0)
					{
						Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillIdAfterUpgrade);
						if (skillConfigById != null)
						{
							((List<Aki.Config.Skill>)readOnlyList)[i] = skillConfigById.Value;
						}
					}
				}
			}
		}
		if (readOnlyList == null)
		{
			readOnlyList = skillList;
		}
		List<TeamRoleSkillData> skillDataList = new List<TeamRoleSkillData>();
		foreach (int num in this.DisplaySkillTypes)
		{
			foreach (Aki.Config.Skill skill in readOnlyList)
			{
				if (skill.SkillType == num)
				{
					TeamRoleSkillData teamRoleSkillData = new TeamRoleSkillData();
					teamRoleSkillData.SkillIcon = skill.Icon;
					teamRoleSkillData.SkillType = num;
					teamRoleSkillData.SkillName = skill.SkillName;
					teamRoleSkillData.SkillTagList = skill.SkillTagList();
					if (teamRoleSkillData.SkillTagList != null)
					{
						teamRoleSkillData.SkillTagList = (int[])teamRoleSkillData.SkillTagList.Clone();
					}
					teamRoleSkillData.SkillDesc = skill.SkillDescribe;
					string[] array = skill.SkillDetailNum();
					if (array != null)
					{
						teamRoleSkillData.SkillDescNum = (string[])array.Clone();
					}
					teamRoleSkillData.MultiSkillDesc = skill.MultiSkillDescribe;
					string[] array2 = skill.MultiSkillDetailNum();
					if (array2 != null)
					{
						teamRoleSkillData.MultiSkillDescNum = (string[])array2.Clone();
					}
					teamRoleSkillData.SkillResume = skill.SkillResume;
					string[] array3 = skill.SkillResumeNum();
					if (array3 != null)
					{
						teamRoleSkillData.SkillResumeNum = (string[])array3.Clone();
					}
					skillDataList.Add(teamRoleSkillData);
					break;
				}
			}
		}
		if (skillDataList.Count <= 0)
		{
			return;
		}
		this.SkillDataList = skillDataList;
		if (this.SkillLayout == null)
		{
			return;
		}
		this.SkillLayout.DeselectCurrentGridProxy();
		this.SkillLayout.RefreshByData(skillDataList, delegate
		{
			this.SkillLayout.SelectGridProxy(0, false);
			this.OnSkillItemStateChanged(EToggleState.ETT_Checked, skillDataList[0]);
		}, false);
	}

	// Token: 0x06012145 RID: 74053 RVA: 0x005511DC File Offset: 0x0054F3DC
	private void RefreshRoleTagLayout(int roleId)
	{
		if (roleId == 0 || this.RoleTagLayout == null)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return;
		}
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(roleConfig.Value);
		bool flag = roleTagByRoleInfo != null && roleTagByRoleInfo.Length != 0;
		base.GetMultiTemplateLayout(5).RootUIComp.Get().SetUIActive(flag);
		if (flag && roleTagByRoleInfo != null)
		{
			this.RoleTagLayout.RefreshByData(roleTagByRoleInfo, null, false);
		}
	}

	// Token: 0x06012146 RID: 74054 RVA: 0x00551257 File Offset: 0x0054F457
	private void RefreshRoleUnRecommendLayout(int roleId)
	{
		if (roleId == 0 || this.Data == null)
		{
			return;
		}
		base.GetItem(23).SetUIActive(this.Data.UnRecommendRole.Contains(roleId));
	}

	// Token: 0x06012147 RID: 74055 RVA: 0x00551284 File Offset: 0x0054F484
	private void CheckCurRoleIsDead(int roleId)
	{
		UUIText text = base.GetText(16);
		if (TowerModel.Instance.IsOpenFloorFormation())
		{
			text.SetUIActive(false);
			return;
		}
		MultiTeamRoleSelectData data = this.Data;
		bool flag;
		if (data == null)
		{
			flag = false;
		}
		else
		{
			Func<int, bool> isNeedRevive = data.IsNeedRevive;
			flag = ((isNeedRevive != null) ? new bool?(isNeedRevive(roleId)) : null).GetValueOrDefault();
		}
		if (flag)
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "EditBattleTeamNeedRevive", Array.Empty<object>());
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06012148 RID: 74056 RVA: 0x00551308 File Offset: 0x0054F508
	private void RefreshSkillInfo(TeamRoleSkillData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), data.SkillName, Array.Empty<object>());
		UUIText text = base.GetText(12);
		if (text == null)
		{
			return;
		}
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			if (RoleModel.Instance.IsShowMultiSkillDesc && !StringUtils.IsEmpty(data.MultiSkillDesc))
			{
				if (data.MultiSkillDescNum != null && data.MultiSkillDescNum.Length != 0)
				{
					LguiUtil.Instance.SetLocalTextNew(text, data.MultiSkillDesc, data.MultiSkillDescNum);
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text, data.MultiSkillDesc, Array.Empty<object>());
				}
			}
			else if (data.SkillDescNum != null && data.SkillDescNum.Length != 0)
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.SkillDesc, data.SkillDescNum);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.SkillDesc, Array.Empty<object>());
			}
		}
		else if (RoleModel.Instance.IsShowSkillResume && !StringUtils.IsEmpty(data.SkillResume))
		{
			if (data.SkillResumeNum != null && data.SkillResumeNum.Length != 0)
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.SkillResume, data.SkillResumeNum);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.SkillResume, Array.Empty<object>());
			}
		}
		else if (data.SkillDescNum != null && data.SkillDescNum.Length != 0)
		{
			LguiUtil.Instance.SetLocalTextNew(text, data.SkillDesc, data.SkillDescNum);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(text, data.SkillDesc, Array.Empty<object>());
		}
		if (StringUtils.IsEmpty(data.SkillTypeText))
		{
			string skillTypeNameLocalText = RoleSkillConfig.Instance.GetSkillTypeNameLocalText(data.SkillType);
			if (skillTypeNameLocalText != null && !string.IsNullOrEmpty(skillTypeNameLocalText))
			{
				base.GetText(11).SetText(skillTypeNameLocalText, true);
				return;
			}
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), data.SkillTypeText, Array.Empty<object>());
		}
	}

	// Token: 0x06012149 RID: 74057 RVA: 0x005514E8 File Offset: 0x0054F6E8
	private void RefreshTagSwitchItem(int roleId)
	{
		if (roleId == 0 || !this.Data.NeedShowTag)
		{
			base.GetItem(27).SetUIActive(false);
			return;
		}
		if (!RoleModel.Instance.IsRoleHasBranch(roleId))
		{
			base.GetItem(27).SetUIActive(false);
			return;
		}
		base.GetItem(27).SetUIActive(true);
		int skillBranchId;
		if (this.CurrentSelectTagMap.GetValueOrNull(roleId) != null)
		{
			skillBranchId = this.CurrentSelectTagMap.GetValueOrNull(roleId).Value;
		}
		else
		{
			skillBranchId = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId);
		}
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem != null)
		{
			skillBranchSwitchItem.SetActiveBranchIndex(RoleModel.Instance.GetRoleBranchIndexById(roleId, skillBranchId));
		}
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem2 = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem2 == null)
		{
			return;
		}
		skillBranchSwitchItem2.RefreshIcon(delegate(int index)
		{
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(roleId, index);
			SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
			if (skillBranchConfigById != null)
			{
				return skillBranchConfigById.Value.Icon;
			}
			return "";
		});
	}

	// Token: 0x0601214A RID: 74058 RVA: 0x005515E0 File Offset: 0x0054F7E0
	private void SwitchSkillBranchHandler(int skillBranch)
	{
		int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.ClickSelectRoleId, skillBranch);
		this.CurrentSelectTagMap[this.ClickSelectRoleId] = roleBranchIdByIndex;
		this.RefreshRoleLayout();
		if (RoleModel.Instance.IsInGamePlayRoleEdit)
		{
			RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(this.ClickSelectRoleId, roleBranchIdByIndex, true);
			return;
		}
		RoleController.Instance.RequestRoleSkillBranchModify(this.ClickSelectRoleId, roleBranchIdByIndex);
	}

	// Token: 0x04009D9C RID: 40348
	private IReadOnlyList<int> DisplaySkillTypes;

	// Token: 0x04009D9D RID: 40349
	private Dictionary<int, int> CurrentSelectTagMap = new Dictionary<int, int>();

	// Token: 0x04009D9E RID: 40350
	protected int CurrentSelectRoleId;

	// Token: 0x04009D9F RID: 40351
	private int ClickSelectRoleId;

	// Token: 0x04009DA0 RID: 40352
	private readonly List<int> CurrentSelectRoleList = new List<int>();

	// Token: 0x04009DA1 RID: 40353
	[Nullable(2)]
	private MultiTeamRoleSelectData Data;

	// Token: 0x04009DA2 RID: 40354
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04009DA3 RID: 40355
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagMediumIconItem, int> RoleTagLayout;

	// Token: 0x04009DA4 RID: 40356
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TeamRoleSkillItem, TeamRoleSkillData> SkillLayout;

	// Token: 0x04009DA5 RID: 40357
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MultiTeamRoleGrid, MultiTeamRoleGridContentData> RoleLayout;

	// Token: 0x04009DA6 RID: 40358
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04009DA7 RID: 40359
	[Nullable(2)]
	private TeamRoleSelectSkillBranchItem SkillBranchSwitchItem;

	// Token: 0x04009DA8 RID: 40360
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<TeamRoleSkillData> SkillDataList;

	// Token: 0x04009DA9 RID: 40361
	private ERoleSkillDescType SkillDescType;

	// Token: 0x04009DAA RID: 40362
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009DAB RID: 40363
	private List<RoleDataBase> CurrentFilterRoleList = new List<RoleDataBase>();

	// Token: 0x04009DAC RID: 40364
	private bool NeedGridAnimation;

	// Token: 0x04009DAD RID: 40365
	[Nullable(2)]
	private ButtonItem ConfirmBtn;

	// Token: 0x02007F77 RID: 32631
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040293D6 RID: 168918
		CaptionItem,
		// Token: 0x040293D7 RID: 168919
		SelectRoleVerticalLayout,
		// Token: 0x040293D8 RID: 168920
		LayoutItem,
		// Token: 0x040293D9 RID: 168921
		TopItem,
		// Token: 0x040293DA RID: 168922
		RoleNameText,
		// Token: 0x040293DB RID: 168923
		RoleTagContent,
		// Token: 0x040293DC RID: 168924
		SkillTagItem,
		// Token: 0x040293DD RID: 168925
		SkillContent,
		// Token: 0x040293DE RID: 168926
		SkillItem,
		// Token: 0x040293DF RID: 168927
		RoleInfoContent,
		// Token: 0x040293E0 RID: 168928
		SkillNameText,
		// Token: 0x040293E1 RID: 168929
		SkillTypeNameText,
		// Token: 0x040293E2 RID: 168930
		SkillInfoText,
		// Token: 0x040293E3 RID: 168931
		FilterSortEntrance,
		// Token: 0x040293E4 RID: 168932
		ConfirmButton,
		// Token: 0x040293E5 RID: 168933
		DetailButton,
		// Token: 0x040293E6 RID: 168934
		TipsText,
		// Token: 0x040293E7 RID: 168935
		NoneRoleTips,
		// Token: 0x040293E8 RID: 168936
		SkillModeToggle,
		// Token: 0x040293E9 RID: 168937
		SkillModeText,
		// Token: 0x040293EA RID: 168938
		ScrollViewItem,
		// Token: 0x040293EB RID: 168939
		EmptySelectItem,
		// Token: 0x040293EC RID: 168940
		TabItem,
		// Token: 0x040293ED RID: 168941
		UnRecommendRoleItem,
		// Token: 0x040293EE RID: 168942
		UnRecommendRoleBtn,
		// Token: 0x040293EF RID: 168943
		UnRecommendRoleText,
		// Token: 0x040293F0 RID: 168944
		TrailRoleItem,
		// Token: 0x040293F1 RID: 168945
		PanelTagSwitchItem,
		// Token: 0x040293F2 RID: 168946
		TagSwitchItem
	}
}
