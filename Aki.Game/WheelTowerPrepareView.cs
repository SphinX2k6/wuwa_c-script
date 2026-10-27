using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02001625 RID: 5669
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerPrepareView : UiViewBase
{
	// Token: 0x06009F88 RID: 40840 RVA: 0x00230239 File Offset: 0x0022E439
	public WheelTowerPrepareView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009F89 RID: 40841 RVA: 0x00230244 File Offset: 0x0022E444
	protected unsafe override void OnRegisterComponent()
	{
		int num = 30;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnStartBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(23, new Action(this.OnBtnSkillBranchPopClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009F8A RID: 40842 RVA: 0x002306C1 File Offset: 0x0022E8C1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06009F8B RID: 40843 RVA: 0x002306DC File Offset: 0x0022E8DC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06009F8C RID: 40844 RVA: 0x002306F8 File Offset: 0x0022E8F8
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerPrepareView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerPrepareView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F8D RID: 40845 RVA: 0x0023073B File Offset: 0x0022E93B
	protected override void OnBeforeShow()
	{
		WheelTowerBossHandBookButtonItem bossHandBookButtonItem = this.BossHandBookButtonItem;
		if (bossHandBookButtonItem != null)
		{
			bossHandBookButtonItem.RefreshRedDot();
		}
		this.RefreshView();
		WheelTowerController.Instance.TryOpenOverridePopupView(delegate
		{
			WheelTowerModel instance = WheelTowerModel.Instance;
			instance.UpdateSelectRound(instance.SelectedRound, true);
			this.RefreshView();
		});
	}

	// Token: 0x06009F8E RID: 40846 RVA: 0x0023076C File Offset: 0x0022E96C
	private void InitSkillBranch()
	{
		RoleModel.Instance.StartGamePlayRoleEdit(ESkillBranchCacheType.WheelTower);
		WheelTowerModel instance = WheelTowerModel.Instance;
		int selectedRound = instance.SelectedRound;
		RepeatedField<TeamChallengeInfo> teamChallengeInfos = instance.GetCurrentLevelRecord(null).TeamChallengeInfos;
		if (selectedRound < 0 || selectedRound >= teamChallengeInfos.Count)
		{
			return;
		}
		foreach (RoleSaveInfo roleSaveInfo in teamChallengeInfos[selectedRound].RoleSaveInfos)
		{
			if (roleSaveInfo.SkillBranchId > 0)
			{
				RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(roleSaveInfo.RoleId, roleSaveInfo.SkillBranchId, false);
			}
		}
	}

	// Token: 0x06009F8F RID: 40847 RVA: 0x00230818 File Offset: 0x0022EA18
	private void RefreshView()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		int totalScore = instance.GetTotalScore();
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText(totalScore.ToString(), true);
		}
		this.RefreshScoreLevel((int)instance.GetTotalScoreLevel(totalScore, null, null));
		int selectedRound = instance.SelectedRound;
		int roundScore = instance.GetRoundScore(selectedRound);
		UUIText text2 = base.GetText(5);
		if (text2 != null)
		{
			text2.SetText(roundScore.ToString(), true);
		}
		bool endlessMode = instance.EndlessMode;
		UUIText text3 = base.GetText(6);
		if (text3 != null)
		{
			text3.SetUIActive(endlessMode);
		}
		int roundBossRound = instance.GetRoundBossRound(selectedRound);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "WheelTower_Endless_CurProgress", new <>z__ReadOnlySingleElementList<object>(roundBossRound));
		string textStringId = endlessMode ? "WheelTower_BossListTitle_Endless" : "WheelTower_BossListTitle_Normal";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), textStringId, Array.Empty<object>());
		this.RefreshSelectData();
		this.RefreshBossList();
	}

	// Token: 0x06009F90 RID: 40848 RVA: 0x00230914 File Offset: 0x0022EB14
	private void RefreshScoreLevel(int scoreLevel)
	{
		NewTowerScoreLevel? scoreLevelConfigById = WheelTowerConfig.Instance.GetScoreLevelConfigById(scoreLevel);
		if (scoreLevelConfigById == null)
		{
			return;
		}
		base.SetTextureByPath(scoreLevelConfigById.Value.Icon, base.GetTexture(3), null, null);
		UUITexture texture = base.GetTexture(15);
		if (texture != null)
		{
			texture.SetColor(FColor.FromHex(scoreLevelConfigById.Value.CircleColor));
		}
		UUITexture texture2 = base.GetTexture(16);
		if (texture2 != null)
		{
			texture2.SetColor(FColor.FromHex(scoreLevelConfigById.Value.CircleColor));
		}
		UUITexture texture3 = base.GetTexture(17);
		if (texture3 != null)
		{
			texture3.SetColor(FColor.FromHex(scoreLevelConfigById.Value.BgColor));
		}
		UUITexture texture4 = base.GetTexture(18);
		if (texture4 != null)
		{
			texture4.SetColor(FColor.FromHex(scoreLevelConfigById.Value.BgLightColor));
		}
		bool flag = scoreLevel == 7;
		UUITexture texture5 = base.GetTexture(18);
		if (texture5 != null)
		{
			texture5.SetUIActive(!flag);
		}
		UUITexture texture6 = base.GetTexture(19);
		if (texture6 != null)
		{
			texture6.SetUIActive(flag);
		}
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetColor(FColor.FromHex(scoreLevelConfigById.Value.TextColor));
	}

	// Token: 0x06009F91 RID: 40849 RVA: 0x00230A50 File Offset: 0x0022EC50
	private void RefreshSelectData()
	{
		List<int> selectedRoleList = WheelTowerModel.Instance.SelectedRoleList;
		List<RoleDataWithBranch> list = new List<RoleDataWithBranch>();
		for (int i = 0; i < WheelTowerModel.Instance.GetTeamMaxRoleCount(); i++)
		{
			list.Add(new RoleDataWithBranch(0, 0));
		}
		for (int j = 0; j < selectedRoleList.Count; j++)
		{
			int roleId = selectedRoleList[j];
			int roleSkillBranchIdInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId);
			list[j] = new RoleDataWithBranch(roleId, roleSkillBranchIdInCurrentGamePlay);
		}
		WheelTowerTeamInfoPanel teamInfoPanel = this.TeamInfoPanel;
		if (teamInfoPanel != null)
		{
			teamInfoPanel.RefreshRoleList(list);
		}
		WheelTowerTeamInfoPanel teamInfoPanel2 = this.TeamInfoPanel;
		if (teamInfoPanel2 != null)
		{
			teamInfoPanel2.RefreshBuff(WheelTowerModel.Instance.SelectedBuff);
		}
		this.UpdateSkillBranchBtn();
		bool flag = WheelTowerModel.Instance.CheckSelectTeamIsFull();
		bool flag2 = WheelTowerModel.Instance.CheckSelectedIsConflict();
		UUIButtonComponent button = base.GetButton(13);
		if (button != null)
		{
			button.SetSelfInteractive(flag && !flag2);
		}
		int num = (selectedRoleList.Count > 0) ? WheelTowerModel.Instance.GetRoleCost(selectedRoleList[0]) : WheelTowerModel.Instance.GetTowerConfig().DefaultCostEnergy;
		UUIText text = base.GetText(22);
		if (text == null)
		{
			return;
		}
		text.SetText(num.ToString(), true);
	}

	// Token: 0x06009F92 RID: 40850 RVA: 0x00230B84 File Offset: 0x0022ED84
	private void RefreshBossList()
	{
		int selectedRound = WheelTowerModel.Instance.SelectedRound;
		List<IBossInfo> bossList = WheelTowerModel.Instance.GetRoundBossInfo(selectedRound, null);
		List<IBossInfo> prevRoundBossInfo = WheelTowerModel.Instance.GetPrevRoundBossInfo(selectedRound);
		List<IBossItemData> list = new List<IBossItemData>();
		for (int i = 0; i < bossList.Count; i++)
		{
			list.Add(new BossItemData
			{
				BossInfo = bossList[i],
				StartPercent = new float?((float)prevRoundBossInfo[i].HpPercentage)
			});
		}
		int currentChallengeIndex = bossList.FindIndex((IBossInfo info) => info.HpPercentage > 0.0);
		if (currentChallengeIndex < 0)
		{
			currentChallengeIndex = bossList.Count - 1;
		}
		GenericScrollViewNew<WheelTowerSmallBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView != null)
		{
			bossScrollView.SelectGridProxy(-1, false);
		}
		GenericScrollViewNew<WheelTowerSmallBossItem, IBossItemData> bossScrollView2 = this.BossScrollView;
		if (bossScrollView2 == null)
		{
			return;
		}
		bossScrollView2.RefreshByData(list, delegate
		{
			if (currentChallengeIndex >= 0 && currentChallengeIndex < bossList.Count)
			{
				this.BossToggleClick(currentChallengeIndex, bossList[currentChallengeIndex].WaveConfigId);
			}
		}, false);
	}

	// Token: 0x06009F93 RID: 40851 RVA: 0x00230CA4 File Offset: 0x0022EEA4
	private void RefreshBossInfo(int bossId)
	{
		WheelTowerModel.Instance.SelectedBossId = bossId;
		NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(bossId);
		if (waveConfigById == null)
		{
			return;
		}
		base.SetTextureByPath(waveConfigById.Value.MonsterPortrait, base.GetTexture(1), null, null);
		WheelTowerBossAttrItem attrItem = this.AttrItem;
		if (attrItem != null)
		{
			attrItem.Refresh(new WheelTowerBossAttrData
			{
				AttrName = waveConfigById.Value.Name,
				AttrLevel = waveConfigById.Value.MonsterLevel,
				ElementId = waveConfigById.Value.ElementId,
				TagIdList = (waveConfigById.Value.GetTagIdListArray() ?? Array.Empty<int>()).ToList<int>()
			});
		}
		GenericLayout<WheelTowerBossBuffSmallItem, int> bossBuffLayout = this.BossBuffLayout;
		if (bossBuffLayout != null)
		{
			bossBuffLayout.RefreshByData((waveConfigById.Value.GetShowBuffIdsArray() ?? Array.Empty<int>()).ToList<int>(), null, false);
		}
		GenericLayout<WheelTowerTeamFeatureItem, int> teamFeatureLayout = this.TeamFeatureLayout;
		if (teamFeatureLayout != null)
		{
			teamFeatureLayout.RefreshByData((waveConfigById.Value.GetRecommendTeamFeatureArray() ?? Array.Empty<int>()).ToList<int>(), null, false);
		}
		this.UpdateMultiDesc();
	}

	// Token: 0x06009F94 RID: 40852 RVA: 0x00230DD8 File Offset: 0x0022EFD8
	private void UpdateMultiDesc()
	{
		int selectedBossId = WheelTowerModel.Instance.SelectedBossId;
		if (selectedBossId <= 0)
		{
			UUIItem item = base.GetItem(27);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(selectedBossId);
			if (waveConfigById != null)
			{
				float damegaRateShow = waveConfigById.Value.DamegaRateShow;
				bool flag = damegaRateShow > 0f;
				UUIItem item2 = base.GetItem(27);
				if (item2 != null)
				{
					item2.SetUIActive(flag);
				}
				if (flag)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(28), "NewTower_Scorept", new <>z__ReadOnlySingleElementList<object>(damegaRateShow.ToString("F2")));
				}
				return;
			}
			UUIItem item3 = base.GetItem(27);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06009F95 RID: 40853 RVA: 0x00230E8C File Offset: 0x0022F08C
	private void OnCloseBtnClick()
	{
		if (GameModeController.Instance.IsInInstance() && !UiManager.Instance.IsViewHide(EUiViewName.WheelTowerModeDetailView))
		{
			UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.WheelTowerModeDetailView, null, null, true);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06009F96 RID: 40854 RVA: 0x00230EDC File Offset: 0x0022F0DC
	private void OnStartBtnClick()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		if (!instance.CheckSelectedRoleEnergyEnough())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("WheelBattleTips_NoFatiguevalue", Array.Empty<object>());
			return;
		}
		if (!instance.CheckBuffIsSelected())
		{
			ConfirmBoxController.Instance.ShowConfirmBoxNew(new ConfirmBoxDataNew(EConfirmBoxConfigId.WheelTowerTeamBuffNotSelectTips));
			return;
		}
		if (instance.CheckSelectedIsConflict())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WheelTowerSelectConflictConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.RequestChallenge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.RequestChallenge();
	}

	// Token: 0x06009F97 RID: 40855 RVA: 0x00230F68 File Offset: 0x0022F168
	private void RequestChallenge()
	{
		RoleModel.Instance.ClearGamePlayRoleEdit(ESkillBranchCacheType.WheeTowerLoading);
		foreach (int roleId in WheelTowerModel.Instance.SelectedRoleList)
		{
			int roleSkillBranchIdInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId);
			RoleModel.Instance.SetRoleSkillBranchGamePlayCache(roleId, roleSkillBranchIdInCurrentGamePlay, ESkillBranchCacheType.WheeTowerLoading);
		}
		WheelTowerController.Instance.RequestSelectedRoundChallenge();
	}

	// Token: 0x06009F98 RID: 40856 RVA: 0x00230FE8 File Offset: 0x0022F1E8
	private void BossToggleClick(int index, int bossId)
	{
		GenericScrollViewNew<WheelTowerSmallBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView != null)
		{
			bossScrollView.SelectGridProxy(index, false);
		}
		this.RefreshBossInfo(bossId);
		WheelTowerModel instance = WheelTowerModel.Instance;
		WheelTowerBossHandBookButtonItem bossHandBookButtonItem = this.BossHandBookButtonItem;
		if (bossHandBookButtonItem == null)
		{
			return;
		}
		bossHandBookButtonItem.SetJumpInfo(bossId, instance.SelectedRound, instance.EndlessMode);
	}

	// Token: 0x06009F99 RID: 40857 RVA: 0x00231032 File Offset: 0x0022F232
	private void OnClickTeamItem()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerTeamSelectView, null, delegate(bool isSuccess, int viewId)
		{
			if (isSuccess)
			{
				base.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06009F9A RID: 40858 RVA: 0x00231050 File Offset: 0x0022F250
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.WheelTowerTeamSelectView || viewName == EUiViewName.WheelTowerRecommendView || viewName == EUiViewName.RoleSkillBranchPopView)
		{
			this.RefreshSelectData();
		}
	}

	// Token: 0x06009F9B RID: 40859 RVA: 0x0023107F File Offset: 0x0022F27F
	private WheelTowerSmallBossItem CreateBossItem()
	{
		WheelTowerSmallBossItem wheelTowerSmallBossItem = new WheelTowerSmallBossItem();
		wheelTowerSmallBossItem.SetClickCallback(new Action<int, int>(this.BossToggleClick));
		return wheelTowerSmallBossItem;
	}

	// Token: 0x06009F9C RID: 40860 RVA: 0x00231098 File Offset: 0x0022F298
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			WheelTowerPrepareView.<>c.<<AddHomeBtnExtraCallback>b__30_0>d <<AddHomeBtnExtraCallback>b__30_0>d;
			<<AddHomeBtnExtraCallback>b__30_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__30_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__30_0>d.<>t__builder.Start<WheelTowerPrepareView.<>c.<<AddHomeBtnExtraCallback>b__30_0>d>(ref <<AddHomeBtnExtraCallback>b__30_0>d);
			return <<AddHomeBtnExtraCallback>b__30_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06009F9D RID: 40861 RVA: 0x002310CC File Offset: 0x0022F2CC
	private void OnBtnSkillBranchPopClick()
	{
		RoleSkillBranchPopViewParams param = this.BuildSkillBranchPopViewParams();
		UiManager.Instance.OpenView(EUiViewName.RoleSkillBranchPopView, param, null);
	}

	// Token: 0x06009F9E RID: 40862 RVA: 0x002310F4 File Offset: 0x0022F2F4
	private RoleSkillBranchPopViewParams BuildSkillBranchPopViewParams()
	{
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = new RoleSkillBranchPopViewParams();
		roleSkillBranchPopViewParams.Load(new int[][]
		{
			WheelTowerModel.Instance.SelectedRoleList.ToArray()
		});
		return roleSkillBranchPopViewParams;
	}

	// Token: 0x06009F9F RID: 40863 RVA: 0x00231126 File Offset: 0x0022F326
	private bool CheckHasSkillBranchInRoleEdit()
	{
		return WheelTowerModel.Instance.SelectedRoleList.Any((int roleId) => RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(roleId) > -1);
	}

	// Token: 0x06009FA0 RID: 40864 RVA: 0x00231158 File Offset: 0x0022F358
	private void UpdateSkillBranchBtn()
	{
		UUIItem uuiitem = base.GetButton(23).RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(this.CheckHasSkillBranchInRoleEdit());
	}

	// Token: 0x04004833 RID: 18483
	private const string NormalTeamBgLightPath = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Normal/T_LevelModeNormalTeamBgLight.T_LevelModeNormalTeamBgLight";

	// Token: 0x04004834 RID: 18484
	private const string EndlessTeamBgLightPath = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Endless/T_LevelModeEndlessTeamBgLight.T_LevelModeEndlessTeamBgLight";

	// Token: 0x04004835 RID: 18485
	private const string TEXT_SCORE_MULTI_DESC = "NewTower_Scorept";

	// Token: 0x04004836 RID: 18486
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004837 RID: 18487
	[Nullable(2)]
	private WheelTowerBossAttrItem AttrItem;

	// Token: 0x04004838 RID: 18488
	[Nullable(2)]
	private WheelTowerTeamInfoPanel TeamInfoPanel;

	// Token: 0x04004839 RID: 18489
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerSmallBossItem, IBossItemData> BossScrollView;

	// Token: 0x0400483A RID: 18490
	[Nullable(2)]
	private WheelTowerBossHandBookButtonItem BossHandBookButtonItem;

	// Token: 0x0400483B RID: 18491
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerBossBuffSmallItem, int> BossBuffLayout;

	// Token: 0x0400483C RID: 18492
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerTeamFeatureItem, int> TeamFeatureLayout;
}
