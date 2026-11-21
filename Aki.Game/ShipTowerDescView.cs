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

// Token: 0x02001F26 RID: 7974
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerDescView : UiViewBase
{
	// Token: 0x06013BD9 RID: 80857 RVA: 0x005C2729 File Offset: 0x005C0929
	public ShipTowerDescView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001DF5 RID: 7669
	// (get) Token: 0x06013BDA RID: 80858 RVA: 0x005C2732 File Offset: 0x005C0932
	// (set) Token: 0x06013BDB RID: 80859 RVA: 0x005C273E File Offset: 0x005C093E
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

	// Token: 0x06013BDC RID: 80860 RVA: 0x005C274C File Offset: 0x005C094C
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

	// Token: 0x06013BDD RID: 80861 RVA: 0x005C293C File Offset: 0x005C0B3C
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

	// Token: 0x06013BDE RID: 80862 RVA: 0x005C29BC File Offset: 0x005C0BBC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerDescView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerDescView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013BDF RID: 80863 RVA: 0x005C2A00 File Offset: 0x005C0C00
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

	// Token: 0x06013BE0 RID: 80864 RVA: 0x005C2AB4 File Offset: 0x005C0CB4
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

	// Token: 0x06013BE1 RID: 80865 RVA: 0x005C2B08 File Offset: 0x005C0D08
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.ShipTowerStageUpdate, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerSureResetStage, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerSureCoverChallenge, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Add<int>(EEventName.ShipTowerTeamRecommendApplyFinish, new Action<int>(this.EventShipTowerTeamRecommendApplyFinish));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06013BE2 RID: 80866 RVA: 0x005C2BA4 File Offset: 0x005C0DA4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ShipTowerStageUpdate, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Remove(EEventName.ShipTowerSureResetStage, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Remove(EEventName.ShipTowerSureCoverChallenge, new Action<int>(this.CheckUpdateStageData));
		EventSystem.Instance.Remove(EEventName.ShipTowerTeamRecommendApplyFinish, new Action<int>(this.EventShipTowerTeamRecommendApplyFinish));
		EventSystem.Instance.Remove(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06013BE3 RID: 80867 RVA: 0x005C2C40 File Offset: 0x005C0E40
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

	// Token: 0x06013BE4 RID: 80868 RVA: 0x005C2CD3 File Offset: 0x005C0ED3
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

	// Token: 0x06013BE5 RID: 80869 RVA: 0x005C2CF8 File Offset: 0x005C0EF8
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

	// Token: 0x06013BE6 RID: 80870 RVA: 0x005C2D48 File Offset: 0x005C0F48
	private void UpdateChallengeType()
	{
		this.ChallengeBtnType = (this.StageData.CanReset() ? EShipTowerDescBtnType.AgainChallenge : EShipTowerDescBtnType.StartChallenge);
	}

	// Token: 0x06013BE7 RID: 80871 RVA: 0x005C2D6E File Offset: 0x005C0F6E
	private void OnBtnMaskClick()
	{
		this.ShowLeftPanel();
	}

	// Token: 0x06013BE8 RID: 80872 RVA: 0x005C2D76 File Offset: 0x005C0F76
	private void OnBtnResetClick()
	{
		ShipTowerModel.Instance.OpenViewReset(new ShipTowerResetViewParams
		{
			StageData = this.StageData
		});
	}

	// Token: 0x06013BE9 RID: 80873 RVA: 0x005C2D93 File Offset: 0x005C0F93
	private void OnBtnChallengeClick()
	{
		this.StageData.StartChallenge();
	}

	// Token: 0x06013BEA RID: 80874 RVA: 0x005C2DA4 File Offset: 0x005C0FA4
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

	// Token: 0x06013BEB RID: 80875 RVA: 0x005C2E6C File Offset: 0x005C106C
	private void OnBtnAgainChallengeClick()
	{
		this.StageData.StartChallenge();
	}

	// Token: 0x06013BEC RID: 80876 RVA: 0x005C2E7A File Offset: 0x005C107A
	private void OnBtnTeamRecommendClick()
	{
		this.StageData.OpenViewTeamRecommend();
	}

	// Token: 0x06013BED RID: 80877 RVA: 0x005C2E88 File Offset: 0x005C1088
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

	// Token: 0x06013BEE RID: 80878 RVA: 0x005C2F04 File Offset: 0x005C1104
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

	// Token: 0x06013BEF RID: 80879 RVA: 0x005C2F80 File Offset: 0x005C1180
	private void UpdateRoleDetailBtn()
	{
		ShipTowerTeamPanel teamPanel = this.TeamPanel;
		List<int> list = (teamPanel != null) ? teamPanel.GetRoleIdList() : null;
		this.UpdateBtnInfo(this.BtnA, EShipTowerDescBtnType.RoleDetail, list != null && list.Count > 0);
	}

	// Token: 0x06013BF0 RID: 80880 RVA: 0x005C2FBC File Offset: 0x005C11BC
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

	// Token: 0x06013BF1 RID: 80881 RVA: 0x005C3048 File Offset: 0x005C1248
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

	// Token: 0x06013BF2 RID: 80882 RVA: 0x005C30A0 File Offset: 0x005C12A0
	[NullableContext(2)]
	private UUIItem GetTeamEmptyItem()
	{
		return base.GetItem(12);
	}

	// Token: 0x06013BF3 RID: 80883 RVA: 0x005C30AC File Offset: 0x005C12AC
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

	// Token: 0x06013BF4 RID: 80884 RVA: 0x005C3128 File Offset: 0x005C1328
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

	// Token: 0x06013BF5 RID: 80885 RVA: 0x005C315D File Offset: 0x005C135D
	private ShipTowerDescTeamItem CreateDescTeamItem()
	{
		return new ShipTowerDescTeamItem
		{
			RoleClickCallBack = new Action<ShipTowerTeamData>(this.OnRoleClick),
			BuffClickCallBack = new Action<ShipTowerTeamData>(this.OnBuffClick),
			MechanismClickCallBack = new Action<ShipTowerTeamData>(this.OnMechanismClick)
		};
	}

	// Token: 0x06013BF6 RID: 80886 RVA: 0x005C319A File Offset: 0x005C139A
	public void OnRoleClick(ShipTowerTeamData data)
	{
		this.SelectedTeamData = data;
		this.SelectTeamDataRoleUpdate();
		this.ShowTeamPanel();
	}

	// Token: 0x06013BF7 RID: 80887 RVA: 0x005C31B0 File Offset: 0x005C13B0
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

	// Token: 0x06013BF8 RID: 80888 RVA: 0x005C3208 File Offset: 0x005C1408
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

	// Token: 0x06013BF9 RID: 80889 RVA: 0x005C3284 File Offset: 0x005C1484
	private void OnMechanismClick(ShipTowerTeamData teamData)
	{
		this.StageData.OpenViewMonsterDesc(new int?(teamData.InstId));
	}

	// Token: 0x06013BFA RID: 80890 RVA: 0x005C329C File Offset: 0x005C149C
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

	// Token: 0x06013BFB RID: 80891 RVA: 0x005C32F0 File Offset: 0x005C14F0
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

	// Token: 0x06013BFC RID: 80892 RVA: 0x005C339C File Offset: 0x005C159C
	private void SetBtnText(ButtonItem btn, string textKey)
	{
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(textKey, textKey);
		btn.SetText(multiTextByKey);
	}

	// Token: 0x06013BFD RID: 80893 RVA: 0x005C33C0 File Offset: 0x005C15C0
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

	// Token: 0x06013BFE RID: 80894 RVA: 0x005C344C File Offset: 0x005C164C
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

	// Token: 0x06013BFF RID: 80895 RVA: 0x005C3554 File Offset: 0x005C1754
	private void OnRoleListUpdate()
	{
		if (!this.IsShowTeamPanel)
		{
			return;
		}
		this.UpdateRoleDetailBtn();
	}

	// Token: 0x06013C00 RID: 80896 RVA: 0x005C3565 File Offset: 0x005C1765
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

	// Token: 0x06013C01 RID: 80897 RVA: 0x005C358C File Offset: 0x005C178C
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

	// Token: 0x06013C02 RID: 80898 RVA: 0x005C35EC File Offset: 0x005C17EC
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

	// Token: 0x06013C03 RID: 80899 RVA: 0x005C3688 File Offset: 0x005C1888
	private void OnBtnSkillBranchClick()
	{
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = this.BuildSkillBranchPopViewParams();
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams2 = roleSkillBranchPopViewParams;
		ShipTowerTeamData selectedTeamData = this.SelectedTeamData;
		roleSkillBranchPopViewParams2.PreferredTabIndex = ((selectedTeamData != null) ? new int?(selectedTeamData.Index) : null);
		UiManager.Instance.OpenView(EUiViewName.RoleSkillBranchPopView, roleSkillBranchPopViewParams, null);
	}

	// Token: 0x06013C04 RID: 80900 RVA: 0x005C36D4 File Offset: 0x005C18D4
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

	// Token: 0x06013C05 RID: 80901 RVA: 0x005C37C4 File Offset: 0x005C19C4
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

	// Token: 0x06013C06 RID: 80902 RVA: 0x005C3870 File Offset: 0x005C1A70
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

	// Token: 0x06013C07 RID: 80903 RVA: 0x005C38A4 File Offset: 0x005C1AA4
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

	// Token: 0x0400A8BB RID: 43195
	private ShipTowerStageData StageData;

	// Token: 0x0400A8BC RID: 43196
	[Nullable(2)]
	private ShipTowerTeamPanel TeamPanel;

	// Token: 0x0400A8BD RID: 43197
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A8BE RID: 43198
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerDescTeamItem, ShipTowerTeamData> DescTeamScroll;

	// Token: 0x0400A8BF RID: 43199
	[Nullable(2)]
	private ShipTowerDescLeftPanel DescLeftPanel;

	// Token: 0x0400A8C0 RID: 43200
	private ButtonItem BtnA;

	// Token: 0x0400A8C1 RID: 43201
	private ButtonItem BtnB;

	// Token: 0x0400A8C2 RID: 43202
	[Nullable(2)]
	private ShipTowerTeamData SelectedTeamData;

	// Token: 0x0400A8C3 RID: 43203
	[Nullable(2)]
	public RoleDataBase SelectedLeftRoleData;

	// Token: 0x0400A8C4 RID: 43204
	private EShipTowerDescBtnType ChallengeBtnType;

	// Token: 0x0400A8C5 RID: 43205
	private int? RoleDetailMainRoleId;

	// Token: 0x02008206 RID: 33286
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029FDC RID: 171996
		public const int ItemCaption = 0;

		// Token: 0x04029FDD RID: 171997
		public const int ItemRootLeft = 1;

		// Token: 0x04029FDE RID: 171998
		public const int ScrollBarRight = 2;

		// Token: 0x04029FDF RID: 171999
		public const int BtnMask = 3;

		// Token: 0x04029FE0 RID: 172000
		public const int BtnReset = 4;

		// Token: 0x04029FE1 RID: 172001
		public const int BtnChallenge = 5;

		// Token: 0x04029FE2 RID: 172002
		public const int BtnTeamRecommend = 6;

		// Token: 0x04029FE3 RID: 172003
		public const int ItemRootTeam = 7;

		// Token: 0x04029FE4 RID: 172004
		public const int ItemMaskSet = 8;

		// Token: 0x04029FE5 RID: 172005
		public const int ItemMaskTeam = 9;

		// Token: 0x04029FE6 RID: 172006
		public const int BtnMask2 = 10;

		// Token: 0x04029FE7 RID: 172007
		public const int ItemTeam = 11;

		// Token: 0x04029FE8 RID: 172008
		public const int ItemTeamNull = 12;

		// Token: 0x04029FE9 RID: 172009
		public const int ExchangeTeamButton = 13;

		// Token: 0x04029FEA RID: 172010
		public const int BtnSkillBranch = 14;
	}
}
