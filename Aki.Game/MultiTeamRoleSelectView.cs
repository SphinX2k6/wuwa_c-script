using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x0200278C RID: 10124
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleSelectView : UiViewBase
{
	// Token: 0x06014C3A RID: 85050 RVA: 0x0054106A File Offset: 0x0053F26A
	public MultiTeamRoleSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014C3B RID: 85051 RVA: 0x00541094 File Offset: 0x0053F294
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

	// Token: 0x06014C3C RID: 85052 RVA: 0x00541380 File Offset: 0x0053F580
	protected override UniTask OnBeforeStartAsync()
	{
		MultiTeamRoleSelectView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MultiTeamRoleSelectView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014C3D RID: 85053 RVA: 0x005413C4 File Offset: 0x0053F5C4
	protected override void OnStart()
	{
		this.DisplaySkillTypes = ConfigCommonParamById.GetIntArrayConfig("DisplaySkillTypes");
		MultiTeamRoleSelectData data = this.Data;
		if (((data != null) ? data.Tips : null) != null && !string.IsNullOrEmpty(this.Data.Tips))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(25), this.Data.Tips, Array.Empty<object>());
		}
		MultiTeamRoleSelectData data2 = this.Data;
		if (((data2 != null) ? data2.ConfirmBtnText : null) != null && !string.IsNullOrEmpty(this.Data.ConfirmBtnText))
		{
			this.ConfirmBtn.SetLocalTextNew(this.Data.ConfirmBtnText, Array.Empty<object>());
		}
	}

	// Token: 0x06014C3E RID: 85054 RVA: 0x0054146A File Offset: 0x0053F66A
	private MultiTeamRoleGrid InitRoleGrid()
	{
		return new MultiTeamRoleGrid();
	}

	// Token: 0x06014C3F RID: 85055 RVA: 0x00541471 File Offset: 0x0053F671
	private TeamRoleSkillItem InitSkillItem()
	{
		TeamRoleSkillItem teamRoleSkillItem = new TeamRoleSkillItem();
		teamRoleSkillItem.BindOnSkillStateChange(new Action<EToggleState, TeamRoleSkillData>(this.OnSkillItemStateChanged));
		return teamRoleSkillItem;
	}

	// Token: 0x06014C40 RID: 85056 RVA: 0x0054148C File Offset: 0x0053F68C
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

	// Token: 0x06014C41 RID: 85057 RVA: 0x00541504 File Offset: 0x0053F704
	private void OnClickUnRecommendRoleBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerTeamTipsConfirm);
		confirmBoxDataNew.FunctionMap.Add(0, delegate
		{
			ConfirmBoxController.Instance.CloseConfirmBoxView();
		});
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
	}

	// Token: 0x06014C42 RID: 85058 RVA: 0x00541554 File Offset: 0x0053F754
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

	// Token: 0x06014C43 RID: 85059 RVA: 0x005415F8 File Offset: 0x0053F7F8
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

	// Token: 0x06014C44 RID: 85060 RVA: 0x005416D8 File Offset: 0x0053F8D8
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

	// Token: 0x06014C45 RID: 85061 RVA: 0x00541700 File Offset: 0x0053F900
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

	// Token: 0x06014C46 RID: 85062 RVA: 0x00541744 File Offset: 0x0053F944
	private unsafe void OnDetailClick()
	{
		int clickSelectRoleId = this.ClickSelectRoleId;
		List<int> list;
		if (clickSelectRoleId < 100000)
		{
			list = RoleModel.Instance.GetRoleIdList();
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

	// Token: 0x06014C47 RID: 85063 RVA: 0x005417F0 File Offset: 0x0053F9F0
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

	// Token: 0x06014C48 RID: 85064 RVA: 0x0054186D File Offset: 0x0053FA6D
	private void OnRoleChangeEnd()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014C49 RID: 85065 RVA: 0x00541878 File Offset: 0x0053FA78
	private void OnRoleSwitchTagChange(int roleId)
	{
		if (this.CurrentSelectTagMap.GetValueOrNull(roleId) != null)
		{
			this.CurrentSelectTagMap[roleId] = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId);
		}
	}

	// Token: 0x06014C4A RID: 85066 RVA: 0x005418B4 File Offset: 0x0053FAB4
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

	// Token: 0x06014C4B RID: 85067 RVA: 0x00541938 File Offset: 0x0053FB38
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
					ShowGridAnimation = this.NeedGridAnimation
				});
			}
		}
		this.RoleLayout.RefreshByData(list, null, false);
		this.NeedGridAnimation = false;
	}

	// Token: 0x06014C4C RID: 85068 RVA: 0x00541A24 File Offset: 0x0053FC24
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

	// Token: 0x06014C4D RID: 85069 RVA: 0x00541AF0 File Offset: 0x0053FCF0
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
		if (this.CurrentSelectRoleList.Contains(dataId))
		{
			return true;
		}
		if (this.CurrentSelectRoleList.Count((int value) => value != 0) >= this.Data.TeamLength)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BossRushMaxLength", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06014C4E RID: 85070 RVA: 0x00541BAC File Offset: 0x0053FDAC
	protected override void OnBeforeShow()
	{
		if (this.Data == null || this.FilterSortEntrance == null)
		{
			return;
		}
		this.NeedGridAnimation = true;
		this.FilterSortEntrance.UpdateData(this.Data.UseWay.Value, this.Data.GetSourceRoleList(), Array.Empty<object>());
	}

	// Token: 0x06014C4F RID: 85071 RVA: 0x00541BFC File Offset: 0x0053FDFC
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

	// Token: 0x06014C50 RID: 85072 RVA: 0x00541C58 File Offset: 0x0053FE58
	private void RefreshTopItem(int roleId)
	{
		bool uiactive = roleId != 0;
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x06014C51 RID: 85073 RVA: 0x00541C78 File Offset: 0x0053FE78
	private void RefreshDetailButton(int roleId)
	{
		bool uiactive = roleId != 0;
		base.GetButton(15).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06014C52 RID: 85074 RVA: 0x00541CA8 File Offset: 0x0053FEA8
	private void RefreshRoleInfoContent(int roleId)
	{
		bool uiactive = roleId != 0;
		base.GetItem(9).SetUIActive(uiactive);
	}

	// Token: 0x06014C53 RID: 85075 RVA: 0x00541CC8 File Offset: 0x0053FEC8
	private void RefreshNoneRoleTips()
	{
		bool uiactive = this.CurrentFilterRoleList.Count == 0;
		base.GetItem(17).SetUIActive(uiactive);
	}

	// Token: 0x06014C54 RID: 85076 RVA: 0x00541CF4 File Offset: 0x0053FEF4
	private void RefreshScrollViewItem()
	{
		bool uiactive = this.CurrentFilterRoleList.Count > 0;
		base.GetItem(20).SetUIActive(uiactive);
	}

	// Token: 0x06014C55 RID: 85077 RVA: 0x00541D20 File Offset: 0x0053FF20
	private void RefreshEmptySelectItem(int roleId)
	{
		bool uiactive = this.CurrentFilterRoleList.Count > 0 && roleId == 0;
		base.GetItem(21).SetUIActive(uiactive);
	}

	// Token: 0x06014C56 RID: 85078 RVA: 0x00541D54 File Offset: 0x0053FF54
	private void RefreshTabItem(int roleId)
	{
		bool uiactive = roleId != 0;
		base.GetItem(22).SetUIActive(uiactive);
	}

	// Token: 0x06014C57 RID: 85079 RVA: 0x00541D74 File Offset: 0x0053FF74
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

	// Token: 0x06014C58 RID: 85080 RVA: 0x00541DF0 File Offset: 0x0053FFF0
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

	// Token: 0x06014C59 RID: 85081 RVA: 0x00541E2C File Offset: 0x0054002C
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
						teamRoleSkillData.SkillTagList = teamRoleSkillData.SkillTagList.ToArray<int>();
					}
					teamRoleSkillData.SkillDesc = skill.SkillDescribe;
					string[] array = skill.SkillDetailNum();
					if (array != null)
					{
						teamRoleSkillData.SkillDescNum = array.ToArray<string>();
					}
					teamRoleSkillData.MultiSkillDesc = skill.MultiSkillDescribe;
					string[] array2 = skill.MultiSkillDetailNum();
					if (array2 != null)
					{
						teamRoleSkillData.MultiSkillDescNum = array2.ToArray<string>();
					}
					teamRoleSkillData.SkillResume = skill.SkillResume;
					string[] array3 = skill.SkillResumeNum();
					if (array3 != null)
					{
						teamRoleSkillData.SkillResumeNum = array3.ToArray<string>();
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

	// Token: 0x06014C5A RID: 85082 RVA: 0x00542104 File Offset: 0x00540304
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
			this.RoleTagLayout.RefreshByData(roleTagByRoleInfo.ToList<int>(), null, false);
		}
	}

	// Token: 0x06014C5B RID: 85083 RVA: 0x00542184 File Offset: 0x00540384
	private void RefreshRoleUnRecommendLayout(int roleId)
	{
		if (roleId == 0 || this.Data == null)
		{
			return;
		}
		base.GetItem(23).SetUIActive(this.Data.UnRecommendRole.Contains(roleId));
	}

	// Token: 0x06014C5C RID: 85084 RVA: 0x005421B0 File Offset: 0x005403B0
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

	// Token: 0x06014C5D RID: 85085 RVA: 0x00542234 File Offset: 0x00540434
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

	// Token: 0x06014C5E RID: 85086 RVA: 0x00542414 File Offset: 0x00540614
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

	// Token: 0x06014C5F RID: 85087 RVA: 0x0054250C File Offset: 0x0054070C
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

	// Token: 0x04009C38 RID: 39992
	private IReadOnlyList<int> DisplaySkillTypes;

	// Token: 0x04009C39 RID: 39993
	private Dictionary<int, int> CurrentSelectTagMap = new Dictionary<int, int>();

	// Token: 0x04009C3A RID: 39994
	protected int CurrentSelectRoleId;

	// Token: 0x04009C3B RID: 39995
	private int ClickSelectRoleId;

	// Token: 0x04009C3C RID: 39996
	private readonly List<int> CurrentSelectRoleList = new List<int>();

	// Token: 0x04009C3D RID: 39997
	[Nullable(2)]
	private MultiTeamRoleSelectData Data;

	// Token: 0x04009C3E RID: 39998
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04009C3F RID: 39999
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagMediumIconItem, int> RoleTagLayout;

	// Token: 0x04009C40 RID: 40000
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TeamRoleSkillItem, TeamRoleSkillData> SkillLayout;

	// Token: 0x04009C41 RID: 40001
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MultiTeamRoleGrid, MultiTeamRoleGridContentData> RoleLayout;

	// Token: 0x04009C42 RID: 40002
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04009C43 RID: 40003
	[Nullable(2)]
	private TeamRoleSelectSkillBranchItem SkillBranchSwitchItem;

	// Token: 0x04009C44 RID: 40004
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<TeamRoleSkillData> SkillDataList;

	// Token: 0x04009C45 RID: 40005
	private ERoleSkillDescType SkillDescType;

	// Token: 0x04009C46 RID: 40006
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009C47 RID: 40007
	private List<RoleDataBase> CurrentFilterRoleList = new List<RoleDataBase>();

	// Token: 0x04009C48 RID: 40008
	private bool NeedGridAnimation;

	// Token: 0x04009C49 RID: 40009
	[Nullable(2)]
	private ButtonItem ConfirmBtn;

	// Token: 0x02008DF0 RID: 36336
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E0C2 RID: 188610
		CaptionItem,
		// Token: 0x0402E0C3 RID: 188611
		SelectRoleVerticalLayout,
		// Token: 0x0402E0C4 RID: 188612
		LayoutItem,
		// Token: 0x0402E0C5 RID: 188613
		TopItem,
		// Token: 0x0402E0C6 RID: 188614
		RoleNameText,
		// Token: 0x0402E0C7 RID: 188615
		RoleTagContent,
		// Token: 0x0402E0C8 RID: 188616
		SkillTagItem,
		// Token: 0x0402E0C9 RID: 188617
		SkillContent,
		// Token: 0x0402E0CA RID: 188618
		SkillItem,
		// Token: 0x0402E0CB RID: 188619
		RoleInfoContent,
		// Token: 0x0402E0CC RID: 188620
		SkillNameText,
		// Token: 0x0402E0CD RID: 188621
		SkillTypeNameText,
		// Token: 0x0402E0CE RID: 188622
		SkillInfoText,
		// Token: 0x0402E0CF RID: 188623
		FilterSortEntrance,
		// Token: 0x0402E0D0 RID: 188624
		ConfirmButton,
		// Token: 0x0402E0D1 RID: 188625
		DetailButton,
		// Token: 0x0402E0D2 RID: 188626
		TipsText,
		// Token: 0x0402E0D3 RID: 188627
		NoneRoleTips,
		// Token: 0x0402E0D4 RID: 188628
		SkillModeToggle,
		// Token: 0x0402E0D5 RID: 188629
		SkillModeText,
		// Token: 0x0402E0D6 RID: 188630
		ScrollViewItem,
		// Token: 0x0402E0D7 RID: 188631
		EmptySelectItem,
		// Token: 0x0402E0D8 RID: 188632
		TabItem,
		// Token: 0x0402E0D9 RID: 188633
		UnRecommendRoleItem,
		// Token: 0x0402E0DA RID: 188634
		UnRecommendRoleBtn,
		// Token: 0x0402E0DB RID: 188635
		UnRecommendRoleText,
		// Token: 0x0402E0DC RID: 188636
		TrailRoleItem,
		// Token: 0x0402E0DD RID: 188637
		PanelTagSwitchItem,
		// Token: 0x0402E0DE RID: 188638
		TagSwitchItem
	}
}
