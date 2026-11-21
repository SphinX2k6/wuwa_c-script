using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AF4 RID: 2804
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerRoundSelectView : UiViewBase
{
	// Token: 0x060073C8 RID: 29640 RVA: 0x0023C497 File Offset: 0x0023A697
	[NullableContext(1)]
	public WheelTowerRoundSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060073C9 RID: 29641 RVA: 0x0023C4A0 File Offset: 0x0023A6A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickSwitchLeft));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickSwitchRight));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickStart));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnClickReset));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060073CA RID: 29642 RVA: 0x0023C810 File Offset: 0x0023AA10
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRoundSelectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRoundSelectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060073CB RID: 29643 RVA: 0x0023C854 File Offset: 0x0023AA54
	protected override void OnStart()
	{
		bool endlessMode = WheelTowerModel.Instance.EndlessMode;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(endlessMode);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(!endlessMode);
		}
		PopupCaptionItem caption = this.Caption;
		if (caption != null)
		{
			caption.SetCloseCallBack(new Action(this.OnClickClose));
		}
		PopupCaptionItem caption2 = this.Caption;
		if (caption2 != null)
		{
			caption2.SetTitleLocalText(endlessMode ? "WheelBattleMode_Endless" : "WheelBattleMode_Normal");
		}
		if (this.TeamItem != null)
		{
			this.TeamItem.ClickCallback = new Action(this.OnClickTeamItem);
		}
		UUIText text = base.GetText(14);
		if (text != null)
		{
			text.SetText(WheelTowerModel.Instance.GetTowerConfig().DefaultCostEnergy.ToString(), true);
		}
		this.RefreshAll();
		WheelTowerController.Instance.TryOpenOverridePopupView(new Action(this.RefreshAll));
		WheelTowerModel.Instance.ActivityData.RecordEnterLevel(endlessMode);
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.AddHomeBtnExtraCallback();
		if (endlessMode)
		{
			EventSystem.Instance.Emit(EEventName.OnEnterWheelTowerEndlessMode);
		}
	}

	// Token: 0x060073CC RID: 29644 RVA: 0x0023C975 File Offset: 0x0023AB75
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x060073CD RID: 29645 RVA: 0x0023C990 File Offset: 0x0023AB90
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x060073CE RID: 29646 RVA: 0x0023C9AB File Offset: 0x0023ABAB
	protected override void OnBeforeShow()
	{
		this.RefreshSelectData();
	}

	// Token: 0x060073CF RID: 29647 RVA: 0x0023C9B3 File Offset: 0x0023ABB3
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x060073D0 RID: 29648 RVA: 0x0023C9C5 File Offset: 0x0023ABC5
	private void RefreshAll()
	{
		this.InitAttachTab();
		this.RefreshSwitchButtonInteractive();
		this.RefreshResetRecordButtonInteractive();
		this.RefreshDefaultRound();
	}

	// Token: 0x060073D1 RID: 29649 RVA: 0x0023C9E0 File Offset: 0x0023ABE0
	private void RefreshDefaultRound()
	{
		int maxChallengeRound = WheelTowerModel.Instance.GetMaxChallengeRound(null);
		int num = maxChallengeRound;
		object openParam = this.OpenParam;
		if (openParam is int)
		{
			int value = (int)openParam;
			num = Math.Clamp(value, 0, maxChallengeRound);
		}
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView = this.RoundTabAttachView;
		if (roundTabAttachView != null)
		{
			roundTabAttachView.AttachToIndex(num, true);
		}
		this.RefreshRound(num, true);
	}

	// Token: 0x060073D2 RID: 29650 RVA: 0x0023CA40 File Offset: 0x0023AC40
	private void RefreshRound(int round, bool force = true)
	{
		if (!force && round == WheelTowerModel.Instance.SelectedRound)
		{
			return;
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}
		WheelTowerModel.Instance.UpdateSelectRound(round, force);
		this.RefreshSelectData();
		this.RefreshBossList(round);
		if (WheelTowerModel.Instance.EndlessMode)
		{
			int roundBossRound = WheelTowerModel.Instance.GetRoundBossRound(round);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "PrefabTextItem_414249711_Text", new <>z__ReadOnlySingleElementList<object>(roundBossRound));
		}
		else
		{
			UUIText text = base.GetText(17);
			if (text != null)
			{
				text.ShowTextNew("WheelTower_RoundSelect_NormalTips");
			}
		}
		RecordItem totalRecordItem = this.TotalRecordItem;
		if (totalRecordItem != null)
		{
			totalRecordItem.Refresh(true);
		}
		RecordItem currentRecordItem = this.CurrentRecordItem;
		if (currentRecordItem != null)
		{
			currentRecordItem.Refresh(false);
		}
		bool flag = WheelTowerModel.Instance.IsRoundChallenged(round, null);
		UUIText text2 = base.GetText(19);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(flag ? "WheelTower_RoundSelect_Retry" : "WheelTower_RoundSelect_Start");
	}

	// Token: 0x060073D3 RID: 29651 RVA: 0x0023CB48 File Offset: 0x0023AD48
	private void RefreshResetRecordButtonInteractive()
	{
		bool uiactive = WheelTowerModel.Instance.HasChallengeAnyRound(null);
		UUIButtonComponent button = base.GetButton(16);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(uiactive);
	}

	// Token: 0x060073D4 RID: 29652 RVA: 0x0023CB90 File Offset: 0x0023AD90
	private void RefreshSwitchButtonInteractive()
	{
		int maxChallengeRound = WheelTowerModel.Instance.GetMaxChallengeRound(null);
		UUIButtonComponent button = base.GetButton(4);
		if (button != null)
		{
			button.SetSelfInteractive(maxChallengeRound > 0);
		}
		UUIButtonComponent button2 = base.GetButton(5);
		if (button2 == null)
		{
			return;
		}
		button2.SetSelfInteractive(maxChallengeRound > 0);
	}

	// Token: 0x060073D5 RID: 29653 RVA: 0x0023CBDC File Offset: 0x0023ADDC
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
		WheelTowerBuffItem buffItem = this.BuffItem;
		if (buffItem != null)
		{
			buffItem.Refresh(WheelTowerModel.Instance.SelectedBuff);
		}
		WheelTowerTeamItem teamItem = this.TeamItem;
		if (teamItem != null)
		{
			teamItem.Refresh(list);
		}
		bool flag = WheelTowerModel.Instance.CheckSelectTeamIsFull();
		bool flag2 = WheelTowerModel.Instance.CheckSelectedIsConflict();
		UUIButtonComponent button = base.GetButton(15);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(flag && !flag2);
	}

	// Token: 0x060073D6 RID: 29654 RVA: 0x0023CCC0 File Offset: 0x0023AEC0
	private void RefreshBossList(int round)
	{
		List<IBossInfo> bossRoundInfo = WheelTowerModel.Instance.GetRoundBossInfo(round, null);
		int currentChallengeIndex = bossRoundInfo.FindIndex((IBossInfo info) => info.HpPercentage > 0.0);
		if (currentChallengeIndex < 0)
		{
			currentChallengeIndex = bossRoundInfo.Count - 1;
		}
		List<IBossInfo> prevRoundBossInfo = WheelTowerModel.Instance.GetPrevRoundBossInfo(round);
		List<IBossItemData> list = new List<IBossItemData>();
		for (int i = 0; i < bossRoundInfo.Count; i++)
		{
			list.Add(new BossItemData
			{
				BossInfo = bossRoundInfo[i],
				StartPercent = new float?((float)prevRoundBossInfo[i].HpPercentage)
			});
		}
		GenericScrollViewNew<WheelTowerBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView == null)
		{
			return;
		}
		bossScrollView.RefreshByData(list, delegate
		{
			GenericScrollViewNew<WheelTowerBossItem, IBossItemData> bossScrollView2 = this.BossScrollView;
			if (bossScrollView2 != null)
			{
				WheelTowerBossItem scrollItemByIndex = bossScrollView2.GetScrollItemByIndex(currentChallengeIndex);
				if (scrollItemByIndex != null)
				{
					scrollItemByIndex.SetCurrentChallenge(true);
				}
			}
			GenericScrollViewNew<WheelTowerBossItem, IBossItemData> bossScrollView3 = this.BossScrollView;
			if (bossScrollView3 != null)
			{
				bossScrollView3.ScrollToItemByKey(currentChallengeIndex);
			}
			this.OnClickBossButton(currentChallengeIndex, bossRoundInfo[currentChallengeIndex].WaveConfigId);
		}, false);
	}

	// Token: 0x060073D7 RID: 29655 RVA: 0x0023CDC1 File Offset: 0x0023AFC1
	[NullableContext(1)]
	private WheelTowerBossItem CreateBossItem()
	{
		WheelTowerBossItem wheelTowerBossItem = new WheelTowerBossItem();
		wheelTowerBossItem.SetClickCallback(new Action<int, int>(this.OnClickBossButton));
		return wheelTowerBossItem;
	}

	// Token: 0x060073D8 RID: 29656 RVA: 0x0023CDDC File Offset: 0x0023AFDC
	private void OnClickBossButton(int index, int bossId)
	{
		GenericScrollViewNew<WheelTowerBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView != null)
		{
			bossScrollView.SelectGridProxy(index, false);
		}
		NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(bossId);
		if (waveConfigById != null)
		{
			UUIText text = base.GetText(9);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(waveConfigById.Value.Desc);
		}
	}

	// Token: 0x060073D9 RID: 29657 RVA: 0x0023CE34 File Offset: 0x0023B034
	private void OnClickSwitchLeft()
	{
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView = this.RoundTabAttachView;
		if (roundTabAttachView != null && roundTabAttachView.MovingState())
		{
			return;
		}
		int maxChallengeRound = WheelTowerModel.Instance.GetMaxChallengeRound(null);
		int selectedRound = WheelTowerModel.Instance.SelectedRound;
		if (maxChallengeRound == 0)
		{
			this.TryAttachToIndex(0);
			return;
		}
		int num = selectedRound - 1;
		if (num < 0)
		{
			num += maxChallengeRound + 1;
		}
		this.TryAttachToIndex(num);
	}

	// Token: 0x060073DA RID: 29658 RVA: 0x0023CE98 File Offset: 0x0023B098
	private void OnClickSwitchRight()
	{
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView = this.RoundTabAttachView;
		if (roundTabAttachView != null && roundTabAttachView.MovingState())
		{
			return;
		}
		int maxChallengeRound = WheelTowerModel.Instance.GetMaxChallengeRound(null);
		int selectedRound = WheelTowerModel.Instance.SelectedRound;
		if (maxChallengeRound == 0)
		{
			this.TryAttachToIndex(0);
			return;
		}
		int index = (selectedRound + 1) % (maxChallengeRound + 1);
		this.TryAttachToIndex(index);
	}

	// Token: 0x060073DB RID: 29659 RVA: 0x0023CEF4 File Offset: 0x0023B0F4
	private void OnClickStart()
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

	// Token: 0x060073DC RID: 29660 RVA: 0x0023CF80 File Offset: 0x0023B180
	private void RequestChallenge()
	{
		WheelTowerController.Instance.RequestSelectedRoundChallenge();
		base.CloseMe(null);
	}

	// Token: 0x060073DD RID: 29661 RVA: 0x0023CF94 File Offset: 0x0023B194
	private void OnClickReset()
	{
		if (!WheelTowerModel.Instance.HasChallengeAnyRound(null))
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WheelTowerRoundResetAllConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			NewTowerClimbingLevelRecord currentLevelRecord = WheelTowerModel.Instance.GetCurrentLevelRecord(null);
			WheelTowerController.Instance.RequestResetLevelRecord(currentLevelRecord.LevelId).ContinueWith(new Action(this.RefreshAll)).Forget();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060073DE RID: 29662 RVA: 0x0023CFE6 File Offset: 0x0023B1E6
	private void OnClickClose()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			UiManager.Instance.OpenView(EUiViewName.WheelTowerModeSelectView, null, null);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060073DF RID: 29663 RVA: 0x0023D00D File Offset: 0x0023B20D
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

	// Token: 0x060073E0 RID: 29664 RVA: 0x0023D02C File Offset: 0x0023B22C
	private void InitAttachTab()
	{
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView = this.RoundTabAttachView;
		if (roundTabAttachView != null)
		{
			roundTabAttachView.SetControllerItem(base.GetItem(6));
		}
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView2 = this.RoundTabAttachView;
		if (roundTabAttachView2 != null)
		{
			roundTabAttachView2.CreateItems(base.GetItem(18).GetOwner(), 0f, new Func<AActor, int, int, RoundTab>(this.CreateTabItem), EAttachDirection.Horizontal);
		}
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView3 = this.RoundTabAttachView;
		if (roundTabAttachView3 != null)
		{
			roundTabAttachView3.SetIfNeedFakeItem(true);
		}
		UUIItem item = base.GetItem(18);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		int maxChallengeRound = WheelTowerModel.Instance.GetMaxChallengeRound(null);
		List<RoundTabData> list = new List<RoundTabData>();
		for (int i = 0; i <= maxChallengeRound; i++)
		{
			list.Add(new RoundTabData
			{
				Round = i,
				IsLock = false
			});
		}
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView4 = this.RoundTabAttachView;
		if (roundTabAttachView4 == null)
		{
			return;
		}
		roundTabAttachView4.ReloadView(list.Count, list.ToArray(), maxChallengeRound);
	}

	// Token: 0x060073E1 RID: 29665 RVA: 0x0023D103 File Offset: 0x0023B303
	[NullableContext(1)]
	private RoundTab CreateTabItem(AActor actor, int index, int showNum)
	{
		RoundTab roundTab = new RoundTab();
		roundTab.OnClickCallback = new Action<int>(this.OnToggleClick);
		roundTab.CreateThenShowByActor(actor, null);
		return roundTab;
	}

	// Token: 0x060073E2 RID: 29666 RVA: 0x0023D124 File Offset: 0x0023B324
	private void OnToggleClick(int round)
	{
		this.TryAttachToIndex(round);
	}

	// Token: 0x060073E3 RID: 29667 RVA: 0x0023D12D File Offset: 0x0023B32D
	private void TryAttachToIndex(int index)
	{
		NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView = this.RoundTabAttachView;
		if (roundTabAttachView == null || roundTabAttachView.GetCurrentSelectIndex() != index)
		{
			NoCircleAttachView<RoundTabData, RoundTab> roundTabAttachView2 = this.RoundTabAttachView;
			if (roundTabAttachView2 != null)
			{
				roundTabAttachView2.AttachToIndex(index, false);
			}
		}
		this.RefreshRound(index, false);
	}

	// Token: 0x060073E4 RID: 29668 RVA: 0x0023D164 File Offset: 0x0023B364
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.WheelTowerTeamSelectView)
		{
			this.RefreshSelectData();
		}
	}

	// Token: 0x060073E5 RID: 29669 RVA: 0x0023D179 File Offset: 0x0023B379
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			WheelTowerRoundSelectView.<>c.<<AddHomeBtnExtraCallback>b__37_0>d <<AddHomeBtnExtraCallback>b__37_0>d;
			<<AddHomeBtnExtraCallback>b__37_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__37_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__37_0>d.<>t__builder.Start<WheelTowerRoundSelectView.<>c.<<AddHomeBtnExtraCallback>b__37_0>d>(ref <<AddHomeBtnExtraCallback>b__37_0>d);
			return <<AddHomeBtnExtraCallback>b__37_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0400496A RID: 18794
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<RoundTabData, RoundTab> RoundTabAttachView;

	// Token: 0x0400496B RID: 18795
	private PopupCaptionItem Caption;

	// Token: 0x0400496C RID: 18796
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerBossItem, IBossItemData> BossScrollView;

	// Token: 0x0400496D RID: 18797
	private WheelTowerBuffItem BuffItem;

	// Token: 0x0400496E RID: 18798
	private WheelTowerTeamItem TeamItem;

	// Token: 0x0400496F RID: 18799
	private RecordItem TotalRecordItem;

	// Token: 0x04004970 RID: 18800
	private RecordItem CurrentRecordItem;

	// Token: 0x04004971 RID: 18801
	private LevelSequencePlayer SeqPlayer;
}
