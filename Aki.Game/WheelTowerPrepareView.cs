using System;
using System.Collections.Generic;
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

// Token: 0x02000ADD RID: 2781
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerPrepareView : UiViewBase
{
	// Token: 0x06007366 RID: 29542 RVA: 0x0023A085 File Offset: 0x00238285
	public WheelTowerPrepareView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007367 RID: 29543 RVA: 0x0023A090 File Offset: 0x00238290
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

	// Token: 0x06007368 RID: 29544 RVA: 0x0023A50D File Offset: 0x0023870D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06007369 RID: 29545 RVA: 0x0023A528 File Offset: 0x00238728
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600736A RID: 29546 RVA: 0x0023A544 File Offset: 0x00238744
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerPrepareView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerPrepareView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600736B RID: 29547 RVA: 0x0023A587 File Offset: 0x00238787
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

	// Token: 0x0600736C RID: 29548 RVA: 0x0023A5B8 File Offset: 0x002387B8
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

	// Token: 0x0600736D RID: 29549 RVA: 0x0023A664 File Offset: 0x00238864
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

	// Token: 0x0600736E RID: 29550 RVA: 0x0023A760 File Offset: 0x00238960
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

	// Token: 0x0600736F RID: 29551 RVA: 0x0023A89C File Offset: 0x00238A9C
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

	// Token: 0x06007370 RID: 29552 RVA: 0x0023A9D0 File Offset: 0x00238BD0
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

	// Token: 0x06007371 RID: 29553 RVA: 0x0023AAF0 File Offset: 0x00238CF0
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
				TagIdList = new List<int>(waveConfigById.Value.GetTagIdListArray() ?? Array.Empty<int>())
			});
		}
		GenericLayout<WheelTowerBossBuffSmallItem, int> bossBuffLayout = this.BossBuffLayout;
		if (bossBuffLayout != null)
		{
			bossBuffLayout.RefreshByData(new List<int>(waveConfigById.Value.GetShowBuffIdsArray() ?? Array.Empty<int>()), null, false);
		}
		GenericLayout<WheelTowerTeamFeatureItem, int> teamFeatureLayout = this.TeamFeatureLayout;
		if (teamFeatureLayout != null)
		{
			teamFeatureLayout.RefreshByData(new List<int>(waveConfigById.Value.GetRecommendTeamFeatureArray() ?? Array.Empty<int>()), null, false);
		}
		this.UpdateMultiDesc();
	}

	// Token: 0x06007372 RID: 29554 RVA: 0x0023AC24 File Offset: 0x00238E24
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

	// Token: 0x06007373 RID: 29555 RVA: 0x0023ACD8 File Offset: 0x00238ED8
	private void OnCloseBtnClick()
	{
		if (GameModeController.Instance.IsInInstance() && !UiManager.Instance.IsViewHide(EUiViewName.WheelTowerModeDetailView))
		{
			UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.WheelTowerModeDetailView, null, null, true);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06007374 RID: 29556 RVA: 0x0023AD28 File Offset: 0x00238F28
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

	// Token: 0x06007375 RID: 29557 RVA: 0x0023ADB4 File Offset: 0x00238FB4
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

	// Token: 0x06007376 RID: 29558 RVA: 0x0023AE34 File Offset: 0x00239034
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

	// Token: 0x06007377 RID: 29559 RVA: 0x0023AE7E File Offset: 0x0023907E
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

	// Token: 0x06007378 RID: 29560 RVA: 0x0023AE9C File Offset: 0x0023909C
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.WheelTowerTeamSelectView || viewName == EUiViewName.WheelTowerRecommendView || viewName == EUiViewName.RoleSkillBranchPopView)
		{
			this.RefreshSelectData();
		}
	}

	// Token: 0x06007379 RID: 29561 RVA: 0x0023AECB File Offset: 0x002390CB
	private WheelTowerSmallBossItem CreateBossItem()
	{
		WheelTowerSmallBossItem wheelTowerSmallBossItem = new WheelTowerSmallBossItem();
		wheelTowerSmallBossItem.SetClickCallback(new Action<int, int>(this.BossToggleClick));
		return wheelTowerSmallBossItem;
	}

	// Token: 0x0600737A RID: 29562 RVA: 0x0023AEE4 File Offset: 0x002390E4
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

	// Token: 0x0600737B RID: 29563 RVA: 0x0023AF18 File Offset: 0x00239118
	private void OnBtnSkillBranchPopClick()
	{
		RoleSkillBranchPopViewParams param = this.BuildSkillBranchPopViewParams();
		UiManager.Instance.OpenView(EUiViewName.RoleSkillBranchPopView, param, null);
	}

	// Token: 0x0600737C RID: 29564 RVA: 0x0023AF40 File Offset: 0x00239140
	private RoleSkillBranchPopViewParams BuildSkillBranchPopViewParams()
	{
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = new RoleSkillBranchPopViewParams();
		roleSkillBranchPopViewParams.Load(new int[][]
		{
			WheelTowerModel.Instance.SelectedRoleList.ToArray()
		});
		return roleSkillBranchPopViewParams;
	}

	// Token: 0x0600737D RID: 29565 RVA: 0x0023AF72 File Offset: 0x00239172
	private bool CheckHasSkillBranchInRoleEdit()
	{
		return WheelTowerModel.Instance.SelectedRoleList.Exists((int roleId) => RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(roleId) > -1);
	}

	// Token: 0x0600737E RID: 29566 RVA: 0x0023AFA4 File Offset: 0x002391A4
	private void UpdateSkillBranchBtn()
	{
		UUIItem uuiitem = base.GetButton(23).RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(this.CheckHasSkillBranchInRoleEdit());
	}

	// Token: 0x040048D9 RID: 18649
	private const string NormalTeamBgLightPath = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Normal/T_LevelModeNormalTeamBgLight.T_LevelModeNormalTeamBgLight";

	// Token: 0x040048DA RID: 18650
	private const string EndlessTeamBgLightPath = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Endless/T_LevelModeEndlessTeamBgLight.T_LevelModeEndlessTeamBgLight";

	// Token: 0x040048DB RID: 18651
	private const string TEXT_SCORE_MULTI_DESC = "NewTower_Scorept";

	// Token: 0x040048DC RID: 18652
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040048DD RID: 18653
	[Nullable(2)]
	private WheelTowerBossAttrItem AttrItem;

	// Token: 0x040048DE RID: 18654
	[Nullable(2)]
	private WheelTowerTeamInfoPanel TeamInfoPanel;

	// Token: 0x040048DF RID: 18655
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerSmallBossItem, IBossItemData> BossScrollView;

	// Token: 0x040048E0 RID: 18656
	[Nullable(2)]
	private WheelTowerBossHandBookButtonItem BossHandBookButtonItem;

	// Token: 0x040048E1 RID: 18657
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerBossBuffSmallItem, int> BossBuffLayout;

	// Token: 0x040048E2 RID: 18658
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerTeamFeatureItem, int> TeamFeatureLayout;
}
