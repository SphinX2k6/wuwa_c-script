using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029AB RID: 10667
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerDescView : UiViewBase
{
	// Token: 0x060161D3 RID: 90579 RVA: 0x00597769 File Offset: 0x00595969
	public ShipTowerDescView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001D9C RID: 7580
	// (get) Token: 0x060161D4 RID: 90580 RVA: 0x00597772 File Offset: 0x00595972
	// (set) Token: 0x060161D5 RID: 90581 RVA: 0x0059777E File Offset: 0x0059597E
	private bool IsShowTeamPanel
	{
		get
		{
			return ShipTowerModel.Instance.IsShowLeftTeamPanel;
		}
		set
		{
			ShipTowerModel.Instance.IsShowLeftTeamPanel = value;
		}
	}

	// Token: 0x060161D6 RID: 90582 RVA: 0x0059778C File Offset: 0x0059598C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnBtnMaskClick)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnBtnMaskClick)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnBtnTeamRecommendClick)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnExchangeTeamClick)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnBtnSkillBranchClick))
		};
	}

	// Token: 0x060161D7 RID: 90583 RVA: 0x0059797C File Offset: 0x00595B7C
	private void InitDataParam()
	{
		ShipTowerDescViewParams shipTowerDescViewParams = this.OpenParam as ShipTowerDescViewParams;
		this.StageData = ShipTowerModel.Instance.GetStageDataById(shipTowerDescViewParams.StageId);
		if (shipTowerDescViewParams.ApplyTeamEditStageId != null && shipTowerDescViewParams.ApplyTeamEditStageId.Value != 0)
		{
			this.StageData.CopyTeamRoleToEdit(shipTowerDescViewParams.ApplyTeamEditStageId.Value);
		}
		else if (!shipTowerDescViewParams.IsOpenCover.GetValueOrDefault())
		{
			this.StageData.UpdateToEdit();
		}
		this.IsShowTeamPanel = false;
	}

	// Token: 0x060161D8 RID: 90584 RVA: 0x005979FC File Offset: 0x00595BFC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerDescView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerDescView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060161D9 RID: 90585 RVA: 0x00597A40 File Offset: 0x00595C40
	protected override void OnStart()
	{
		this.CheckInitDataParam();
		RoleModel.Instance.StartGamePlayRoleEdit(ESkillBranchCacheType.ShipTower);
		foreach (ShipTowerTeamData shipTowerTeamData in this.StageData.TeamDataList)
		{
			foreach (ShipTowerRoleData shipTowerRoleData in shipTowerTeamData.RoleList)
			{
				RoleModel.Instance.SetRoleSkillBranchGamePlayCache(shipTowerRoleData.RoleId, shipTowerRoleData.SkillBranchId, ESkillBranchCacheType.ShipTower);
			}
		}
	}

	// Token: 0x060161DA RID: 90586 RVA: 0x00597AF4 File Offset: 0x00595CF4
	private void CheckInitDataParam()
	{
		ShipTowerDescViewParams shipTowerDescViewParams = this.OpenParam as ShipTowerDescViewParams;
		if (((shipTowerDescViewParams != null) ? shipTowerDescViewParams.IsOpenCover : null).GetValueOrDefault())
		{
			ShipTowerModel.Instance.OpenViewCover(new ShipTowerCoverViewParams
			{
				StageData = this.StageData
			});
		}
	}

	// Token: 0x060161DB RID: 90587 RVA: 0x00597B48 File Offset: 0x00595D48
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.ShipTowerStageUpdate, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerSureResetStage, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerSureCoverChallenge, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerTeamRecommendApplyFinish, new Action<int>(this.EventShipTowerTeamRecommendApplyFinish));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060161DC RID: 90588 RVA: 0x00597BE4 File Offset: 0x00595DE4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ShipTowerStageUpdate, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Remove(EEventName.ShipTowerSureResetStage, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Remove(EEventName.ShipTowerSureCoverChallenge, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Remove(EEventName.ShipTowerTeamRecommendApplyFinish, new Action<int>(this.EventShipTowerTeamRecommendApplyFinish));
		EventSystem.Instance.Remove(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060161DD RID: 90589 RVA: 0x00597C80 File Offset: 0x00595E80
	protected override void OnBeforeShow()
	{
		if (this.RoleDetailMainRoleId != null)
		{
			int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
			int value = this.RoleDetailMainRoleId.Value;
			if (!(curSelectMainRoleId.GetValueOrDefault() == value & curSelectMainRoleId != null))
			{
				this.RoleDetailMainRoleId = null;
				this.StageData.UpdateMainRoleToEdit();
				this.SelectTeamDataRoleUpdate();
				ShipTowerTeamPanel teamPanel = this.TeamPanel;
				if (teamPanel != null)
				{
					teamPanel.UpdateRoleListByMainRoleChange();
				}
			}
		}
		this.UpdateData();
		if (!this.StageData.ProtoIsPassed)
		{
			base.PlaySequence("Tips", null, false);
		}
	}

	// Token: 0x060161DE RID: 90590 RVA: 0x00597D13 File Offset: 0x00595F13
	protected override void OnBeforeDestroy()
	{
		if (ShipTowerModel.Instance.ChallengeStageData != this.StageData)
		{
			ShipTowerStageData stageData = this.StageData;
			if (stageData == null)
			{
				return;
			}
			stageData.UpdateToEdit();
		}
	}

	// Token: 0x060161DF RID: 90591 RVA: 0x00597D38 File Offset: 0x00595F38
	private void UpdateData()
	{
		this.UpdateChallengeType();
		GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
		if (descTeamScroll != null)
		{
			descTeamScroll.RefreshByData(this.StageData.TeamDataList, null, true);
		}
		if (this.IsShowTeamPanel)
		{
			this.ShowTeamPanel();
		}
		else
		{
			this.ShowLeftPanel();
		}
		this.UpdateSkillBranchBtn();
	}

	// Token: 0x060161E0 RID: 90592 RVA: 0x00597D88 File Offset: 0x00595F88
	private void UpdateChallengeType()
	{
		this.ChallengeBtnType = (this.StageData.CanReset() ? EShipTowerDescBtnType.AgainChallenge : EShipTowerDescBtnType.StartChallenge);
	}

	// Token: 0x060161E1 RID: 90593 RVA: 0x00597DAE File Offset: 0x00595FAE
	private void OnBtnMaskClick()
	{
		this.ShowLeftPanel();
	}

	// Token: 0x060161E2 RID: 90594 RVA: 0x00597DB6 File Offset: 0x00595FB6
	private void OnBtnResetClick()
	{
		ShipTowerModel.Instance.OpenViewReset(new ShipTowerResetViewParams
		{
			StageData = this.StageData
		});
	}

	// Token: 0x060161E3 RID: 90595 RVA: 0x00597DD3 File Offset: 0x00595FD3
	private void OnBtnChallengeClick()
	{
		this.StageData.StartChallenge();
	}

	// Token: 0x060161E4 RID: 90596 RVA: 0x00597DE4 File Offset: 0x00595FE4
	private void OnBtnRoleDetailClick()
	{
		ShipTowerTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.UpdateRoleListFilter();
		}
		ShipTowerTeamPanel teamPanel2 = this.TeamPanel;
		List<int> list = (teamPanel2 != null) ? teamPanel2.GetRoleIdList() : null;
		if (list == null || list.Count == 0)
		{
			return;
		}
		int? roleDetailMainRoleId = null;
		foreach (int num in list)
		{
			if (RoleModel.Instance.IsMainRole(num))
			{
				roleDetailMainRoleId = new int?(num);
				break;
			}
		}
		this.RoleDetailMainRoleId = roleDetailMainRoleId;
		RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
		{
			AgentType = ERoleAgentType.Normal,
			RoleIdList = list,
			TeamPositionType = new ETeamPositionType?(ETeamPositionType.EditFormation)
		});
	}

	// Token: 0x060161E5 RID: 90597 RVA: 0x00597EAC File Offset: 0x005960AC
	private void OnBtnAgainChallengeClick()
	{
		this.StageData.StartChallenge();
	}

	// Token: 0x060161E6 RID: 90598 RVA: 0x00597EBA File Offset: 0x005960BA
	private void OnBtnTeamRecommendClick()
	{
		this.StageData.OpenViewTeamRecommend();
	}

	// Token: 0x060161E7 RID: 90599 RVA: 0x00597EC8 File Offset: 0x005960C8
	private void OnExchangeTeamClick()
	{
		this.StageData.ExchangeTeamData();
		this.UpdateData();
		int id = this.StageData.Id;
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.ShipTowerExchangeInstId, null);
		if (hashSet != null && hashSet.Contains(id))
		{
			return;
		}
		if (hashSet != null)
		{
			hashSet.Add(id);
		}
		else
		{
			hashSet = new HashSet<int>
			{
				id
			};
		}
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.ShipTowerExchangeInstId, hashSet);
		ShipTowerSwitch shipTowerSwitch = new ShipTowerSwitch();
		shipTowerSwitch.i_inst_id = id;
		LogReportController.Instance.LogReport(shipTowerSwitch);
	}

	// Token: 0x060161E8 RID: 90600 RVA: 0x00597F44 File Offset: 0x00596144
	private void ShowTeamPanel()
	{
		if (!this.IsShowTeamPanel)
		{
			base.PlaySequence("Team", null, false);
		}
		this.IsShowTeamPanel = true;
		ShipTowerDescLeftPanel descLeftPanel = this.DescLeftPanel;
		if (descLeftPanel != null)
		{
			descLeftPanel.SetActive(false);
		}
		ShipTowerTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.UpdateViewAndShow(this.SelectedTeamData);
		}
		this.UpdateRoleDetailBtn();
		this.UpdateBtnInfo(this.BtnB, this.ChallengeBtnType, this.StageData.IsUnLocked());
		this.SetBtnMaskActive(true);
	}

	// Token: 0x060161E9 RID: 90601 RVA: 0x00597FC0 File Offset: 0x005961C0
	private void UpdateRoleDetailBtn()
	{
		ShipTowerTeamPanel teamPanel = this.TeamPanel;
		List<int> list = (teamPanel != null) ? teamPanel.GetRoleIdList() : null;
		this.UpdateBtnInfo(this.BtnA, EShipTowerDescBtnType.RoleDetail, list != null && list.Count > 0);
	}

	// Token: 0x060161EA RID: 90602 RVA: 0x00597FFC File Offset: 0x005961FC
	private void ShowLeftPanel()
	{
		this.IsShowTeamPanel = false;
		ShipTowerTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.SetActive(false);
		}
		ShipTowerDescLeftPanel descLeftPanel = this.DescLeftPanel;
		if (descLeftPanel != null)
		{
			descLeftPanel.UpdateViewAndShow(this.StageData);
		}
		this.UpdateBtnInfo(this.BtnA, EShipTowerDescBtnType.Reset, this.StageData.CanReset());
		this.UpdateBtnInfo(this.BtnB, this.ChallengeBtnType, this.StageData.IsUnLocked());
		this.SetBtnMaskActive(false);
		UUIItem teamEmptyItem = this.GetTeamEmptyItem();
		if (teamEmptyItem == null)
		{
			return;
		}
		teamEmptyItem.SetUIActive(false);
	}

	// Token: 0x060161EB RID: 90603 RVA: 0x00598088 File Offset: 0x00596288
	private void SetBtnMaskActive(bool active)
	{
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(active);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(active);
		}
		if (this.SelectedTeamData == null)
		{
			return;
		}
		if (active)
		{
			this.NormalOtherTeam();
			return;
		}
		ShipTowerDescTeamItem selectDescTeamItem = this.GetSelectDescTeamItem();
		if (selectDescTeamItem == null)
		{
			return;
		}
		selectDescTeamItem.SetTeamToggleIsSelect(false);
	}

	// Token: 0x060161EC RID: 90604 RVA: 0x005980E0 File Offset: 0x005962E0
	[NullableContext(2)]
	private UUIItem GetTeamEmptyItem()
	{
		return base.GetItem(12);
	}

	// Token: 0x060161ED RID: 90605 RVA: 0x005980EC File Offset: 0x005962EC
	private void NormalOtherTeam()
	{
		for (int i = 0; i < this.StageData.TeamDataList.Count; i++)
		{
			int num = i;
			ShipTowerTeamData selectedTeamData = this.SelectedTeamData;
			int? num2 = (selectedTeamData != null) ? new int?(selectedTeamData.Index) : null;
			if (!(num == num2.GetValueOrDefault() & num2 != null))
			{
				GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
				ShipTowerDescTeamItem shipTowerDescTeamItem = (descTeamScroll != null) ? descTeamScroll.GetScrollItemByIndex(i) : null;
				if (shipTowerDescTeamItem != null)
				{
					shipTowerDescTeamItem.SetTeamToggleIsSelect(false);
				}
			}
		}
	}

	// Token: 0x060161EE RID: 90606 RVA: 0x00598168 File Offset: 0x00596368
	[NullableContext(2)]
	private ShipTowerDescTeamItem GetSelectDescTeamItem()
	{
		if (this.SelectedTeamData == null)
		{
			return null;
		}
		int index = this.SelectedTeamData.Index;
		GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
		if (descTeamScroll == null)
		{
			return null;
		}
		return descTeamScroll.GetScrollItemByIndex(index);
	}

	// Token: 0x060161EF RID: 90607 RVA: 0x0059819D File Offset: 0x0059639D
	private ShipTowerDescTeamItem CreateDescTeamItem()
	{
		return new ShipTowerDescTeamItem
		{
			RoleClickCallBack = new Action<ShipTowerTeamData>(this.OnRoleClick),
			BuffClickCallBack = new Action<ShipTowerTeamData>(this.OnBuffClick),
			MechanismClickCallBack = new Action<ShipTowerTeamData>(this.OnMechanismClick)
		};
	}

	// Token: 0x060161F0 RID: 90608 RVA: 0x005981DC File Offset: 0x005963DC
	public void OnRoleClick(ShipTowerTeamData data)
	{
		ShipTowerTeamData selectedTeamData = this.SelectedTeamData;
		int? num = (selectedTeamData != null) ? new int?(selectedTeamData.Index) : null;
		int index = data.Index;
		if (!(num.GetValueOrDefault() == index & num != null))
		{
			this.SelectedTeamData = data;
			this.SelectTeamDataRoleUpdate();
		}
		this.ShowTeamPanel();
	}

	// Token: 0x060161F1 RID: 90609 RVA: 0x00598238 File Offset: 0x00596438
	private void SelectTeamDataRoleUpdate()
	{
		if (this.SelectedTeamData == null)
		{
			return;
		}
		this.SelectedTeamData.UpdateRoleListToRoleSelectModel();
		this.StageData.UpdateCurSelectTeamIndex(this.SelectedTeamData.Index);
		this.StageData.UpdateOtherTeamRoleToModel(this.SelectedTeamData.Index);
		this.StageData.UpdateAllTeamRoleToModel();
	}

	// Token: 0x060161F2 RID: 90610 RVA: 0x00598290 File Offset: 0x00596490
	private void OnBuffClick(ShipTowerTeamData teamData)
	{
		ShipTowerModel instance = ShipTowerModel.Instance;
		ShipTowerBuffViewParams shipTowerBuffViewParams = new ShipTowerBuffViewParams();
		ShipTowerBuffData buffDataEdit = teamData.BuffDataEdit;
		shipTowerBuffViewParams.BuffId = ((buffDataEdit != null) ? new int?(buffDataEdit.Id) : null);
		shipTowerBuffViewParams.StageId = new int?(this.StageData.Id);
		shipTowerBuffViewParams.OperationType = new EShipTowerBuffOperationType?(EShipTowerBuffOperationType.Use);
		shipTowerBuffViewParams.TeamData = teamData;
		shipTowerBuffViewParams.OnUseBuff = new Action<ShipTowerBuffData, ShipTowerTeamData>(this.OnUseBuff);
		instance.OpenViewBuff(shipTowerBuffViewParams);
	}

	// Token: 0x060161F3 RID: 90611 RVA: 0x0059830C File Offset: 0x0059650C
	private void OnMechanismClick(ShipTowerTeamData teamData)
	{
		this.StageData.OpenViewMonsterDesc(new int?(teamData.InstId));
	}

	// Token: 0x060161F4 RID: 90612 RVA: 0x00598324 File Offset: 0x00596524
	private void OnUseBuff(ShipTowerBuffData buffData, [Nullable(2)] ShipTowerTeamData teamData)
	{
		if (teamData != null)
		{
			teamData.UseBuff(buffData);
		}
		int index = (teamData != null) ? teamData.Index : -1;
		GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
		if (descTeamScroll != null)
		{
			ShipTowerDescTeamItem scrollItemByIndex = descTeamScroll.GetScrollItemByIndex(index);
			if (scrollItemByIndex != null)
			{
				scrollItemByIndex.UpdateBuff();
			}
		}
		UiManager.Instance.CloseView(EUiViewName.ShipTowerBuffView, null);
	}

	// Token: 0x060161F5 RID: 90613 RVA: 0x00598378 File Offset: 0x00596578
	private void UpdateBtnInfo(ButtonItem btn, EShipTowerDescBtnType btnType, bool isShow = true)
	{
		btn.SetActive(isShow);
		if (!isShow)
		{
			return;
		}
		switch (btnType)
		{
		case EShipTowerDescBtnType.StartChallenge:
			this.SetBtnText(btn, "GhostShipBtn_Text2");
			btn.SetFunction(delegate(int _)
			{
				this.OnBtnChallengeClick();
			});
			return;
		case EShipTowerDescBtnType.AgainChallenge:
			this.SetBtnText(btn, "GhostShipBtn_Text4");
			btn.SetFunction(delegate(int _)
			{
				this.OnBtnAgainChallengeClick();
			});
			return;
		case EShipTowerDescBtnType.Reset:
			this.SetBtnText(btn, "GhostShipBtn_Text3");
			btn.SetFunction(delegate(int _)
			{
				this.OnBtnResetClick();
			});
			return;
		case EShipTowerDescBtnType.RoleDetail:
			this.SetBtnText(btn, "GhostShipBtn_Text1");
			btn.SetFunction(delegate(int _)
			{
				this.OnBtnRoleDetailClick();
			});
			return;
		default:
			return;
		}
	}

	// Token: 0x060161F6 RID: 90614 RVA: 0x00598424 File Offset: 0x00596624
	private void SetBtnText(ButtonItem btn, string textKey)
	{
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(textKey, textKey);
		btn.SetText(multiTextByKey);
	}

	// Token: 0x060161F7 RID: 90615 RVA: 0x00598448 File Offset: 0x00596648
	private void OnRoleSelect(RoleDataBase roleData)
	{
		this.SelectedLeftRoleData = roleData;
		if (this.SelectedTeamData == null)
		{
			return;
		}
		int index = this.SelectedTeamData.Index;
		int dataId = roleData.GetDataId();
		bool flag = ShipTowerModel.Instance.IsOtherTeamRoleData(dataId);
		this.SelectedTeamData.UpdateRoleListByModel();
		if (flag)
		{
			this.StageData.UpdateOtherTeamRoleRepeat(index, new int?(dataId));
		}
		this.StageData.UpdateAllTeamRoleToModel();
		GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
		if (descTeamScroll != null)
		{
			descTeamScroll.RefreshByData(this.StageData.TeamDataList, null, false);
		}
		this.UpdateSkillBranchBtn();
	}

	// Token: 0x060161F8 RID: 90616 RVA: 0x005984D4 File Offset: 0x005966D4
	private void OnRoleTeamSelect(FormationData formationData)
	{
		if (this.SelectedTeamData == null)
		{
			return;
		}
		int index = this.SelectedTeamData.Index;
		ShipTowerTeamData shipTowerTeamData = this.StageData.TeamDataList[index];
		foreach (ShipTowerRoleData shipTowerRoleData in shipTowerTeamData.RoleList)
		{
			if (RoleModel.Instance.IsRoleHasBranch(shipTowerRoleData.RoleIdEdit))
			{
				int roleCurrentBranchId = RoleModel.Instance.GetRoleCurrentBranchId(shipTowerRoleData.RoleIdEdit);
				RoleModel.Instance.SetRoleSkillBranchGamePlayCache(shipTowerRoleData.RoleIdEdit, roleCurrentBranchId, ESkillBranchCacheType.ShipTower);
			}
		}
		shipTowerTeamData.UpdateRoleListByFormationData(formationData);
		this.StageData.UpdateOtherTeamRoleRepeat(index, null);
		this.StageData.UpdateAllTeamRoleToModel();
		ShipTowerTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.OnlyUpdateTeamList();
		}
		GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
		if (descTeamScroll != null)
		{
			descTeamScroll.RefreshByData(this.StageData.TeamDataList, null, false);
		}
		this.UpdateSkillBranchBtn();
	}

	// Token: 0x060161F9 RID: 90617 RVA: 0x005985DC File Offset: 0x005967DC
	private void OnRoleListUpdate()
	{
		if (!this.IsShowTeamPanel)
		{
			return;
		}
		this.UpdateRoleDetailBtn();
	}

	// Token: 0x060161FA RID: 90618 RVA: 0x005985ED File Offset: 0x005967ED
	private void CheckUpdateStageData(int id)
	{
		if (this.StageData.Id != id)
		{
			return;
		}
		if (this.SelectedTeamData != null)
		{
			this.SelectTeamDataRoleUpdate();
		}
		this.UpdateData();
	}

	// Token: 0x060161FB RID: 90619 RVA: 0x00598614 File Offset: 0x00596814
	private void EventShipTowerTeamRecommendApplyFinish(int id)
	{
		if (this.StageData.Id != id)
		{
			return;
		}
		if (this.IsShowTeamPanel && this.SelectedTeamData != null)
		{
			this.SelectedTeamData.UpdateRoleListToRoleSelectModel();
			this.StageData.UpdateOtherTeamRoleToModel(this.SelectedTeamData.Index);
			this.StageData.UpdateAllTeamRoleToModel();
		}
		this.UpdateData();
	}

	// Token: 0x060161FC RID: 90620 RVA: 0x00598674 File Offset: 0x00596874
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		string a = configParams[0];
		if (!(a == "TabCompRight"))
		{
			if (!(a == "Desc") && !(a == "Item") && !(a == "TeamAndItem") && !(a == "TeamAndItemOuter"))
			{
				return null;
			}
			int index;
			if (configParams.Length != 2 || !int.TryParse(configParams[1], out index))
			{
				return null;
			}
			GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
			ShipTowerDescTeamItem shipTowerDescTeamItem = (descTeamScroll != null) ? descTeamScroll.GetScrollItemByIndex(index) : null;
			if (shipTowerDescTeamItem == null)
			{
				return null;
			}
			return shipTowerDescTeamItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			ShipTowerTeamPanel teamPanel = this.TeamPanel;
			if (teamPanel == null)
			{
				return null;
			}
			return teamPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x060161FD RID: 90621 RVA: 0x00598710 File Offset: 0x00596910
	private void OnBtnSkillBranchClick()
	{
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = this.BuildSkillBranchPopViewParams();
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams2 = roleSkillBranchPopViewParams;
		ShipTowerTeamData selectedTeamData = this.SelectedTeamData;
		roleSkillBranchPopViewParams2.PreferredTabIndex = ((selectedTeamData != null) ? new int?(selectedTeamData.Index) : null);
		UiManager.Instance.OpenView(EUiViewName.RoleSkillBranchPopView, roleSkillBranchPopViewParams, null);
	}

	// Token: 0x060161FE RID: 90622 RVA: 0x0059875C File Offset: 0x0059695C
	private RoleSkillBranchPopViewParams BuildSkillBranchPopViewParams()
	{
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = new RoleSkillBranchPopViewParams();
		List<List<int>> list = new List<List<int>>();
		foreach (ShipTowerTeamData shipTowerTeamData in this.StageData.TeamDataList)
		{
			List<int> list2 = new List<int>();
			foreach (ShipTowerRoleData shipTowerRoleData in shipTowerTeamData.GetUseRoleList())
			{
				list2.Add(shipTowerRoleData.RoleIdEdit);
			}
			list.Add(list2);
		}
		int[][] array = new int[list.Count][];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = list[i].ToArray();
		}
		roleSkillBranchPopViewParams.Load(array);
		return roleSkillBranchPopViewParams;
	}

	// Token: 0x060161FF RID: 90623 RVA: 0x0059884C File Offset: 0x00596A4C
	private bool CheckHasSkillBranchInRoleEdit()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.StageData.TeamDataList)
		{
			foreach (ShipTowerRoleData shipTowerRoleData in shipTowerTeamData.GetUseRoleList())
			{
				if (shipTowerRoleData.RoleIdEdit > 0 && RoleModel.Instance.IsRoleHasBranch(shipTowerRoleData.RoleIdEdit))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06016200 RID: 90624 RVA: 0x005988F8 File Offset: 0x00596AF8
	private void UpdateSkillBranchBtn()
	{
		bool uiactive = this.CheckHasSkillBranchInRoleEdit();
		UUIButtonComponent button = base.GetButton(14);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06016201 RID: 90625 RVA: 0x0059892C File Offset: 0x00596B2C
	private void OnRoleSkillBranchChanged(int roleId)
	{
		ShipTowerTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.RefreshRole(roleId);
		}
		GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> descTeamScroll = this.DescTeamScroll;
		if (descTeamScroll == null)
		{
			return;
		}
		descTeamScroll.RefreshByData(this.StageData.TeamDataList, null, false);
	}

	// Token: 0x0400A4D1 RID: 42193
	private ShipTowerStageData StageData;

	// Token: 0x0400A4D2 RID: 42194
	[Nullable(2)]
	private ShipTowerTeamPanel TeamPanel;

	// Token: 0x0400A4D3 RID: 42195
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A4D4 RID: 42196
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> DescTeamScroll;

	// Token: 0x0400A4D5 RID: 42197
	[Nullable(2)]
	private ShipTowerDescLeftPanel DescLeftPanel;

	// Token: 0x0400A4D6 RID: 42198
	private ButtonItem BtnA;

	// Token: 0x0400A4D7 RID: 42199
	private ButtonItem BtnB;

	// Token: 0x0400A4D8 RID: 42200
	[Nullable(2)]
	private ShipTowerTeamData SelectedTeamData;

	// Token: 0x0400A4D9 RID: 42201
	[Nullable(2)]
	public RoleDataBase SelectedLeftRoleData;

	// Token: 0x0400A4DA RID: 42202
	private EShipTowerDescBtnType ChallengeBtnType;

	// Token: 0x0400A4DB RID: 42203
	private int? RoleDetailMainRoleId;

	// Token: 0x02008FBD RID: 36797
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E8DD RID: 190685
		public const int ItemCaption = 0;

		// Token: 0x0402E8DE RID: 190686
		public const int ItemRootLeft = 1;

		// Token: 0x0402E8DF RID: 190687
		public const int ScrollBarRight = 2;

		// Token: 0x0402E8E0 RID: 190688
		public const int BtnMask = 3;

		// Token: 0x0402E8E1 RID: 190689
		public const int BtnReset = 4;

		// Token: 0x0402E8E2 RID: 190690
		public const int BtnChallenge = 5;

		// Token: 0x0402E8E3 RID: 190691
		public const int BtnTeamRecommend = 6;

		// Token: 0x0402E8E4 RID: 190692
		public const int ItemRootTeam = 7;

		// Token: 0x0402E8E5 RID: 190693
		public const int ItemMaskSet = 8;

		// Token: 0x0402E8E6 RID: 190694
		public const int ItemMaskTeam = 9;

		// Token: 0x0402E8E7 RID: 190695
		public const int BtnMask2 = 10;

		// Token: 0x0402E8E8 RID: 190696
		public const int ItemTeam = 11;

		// Token: 0x0402E8E9 RID: 190697
		public const int ItemTeamNull = 12;

		// Token: 0x0402E8EA RID: 190698
		public const int ExchangeTeamButton = 13;

		// Token: 0x0402E8EB RID: 190699
		public const int BtnSkillBranch = 14;
	}
}
