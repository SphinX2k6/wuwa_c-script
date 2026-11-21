using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.DangoBrawl.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl
{
	// Token: 0x020049E3 RID: 18915
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlMainBattlePanel : BattleChildViewPanel
	{
		// Token: 0x0602F5EE RID: 194030 RVA: 0x00D35A84 File Offset: 0x00D33C84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 8;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedBuffDetail1));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedBuffDetail2));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickedBuffDetail3));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickedBuffDetail4));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action<EToggleState>(this.OnToggleDetail));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClickedCloseMask));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnClickedRoundSettleRecover));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602F5EF RID: 194031 RVA: 0x00D35F2C File Offset: 0x00D3412C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlMainBattlePanel.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlMainBattlePanel.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F5F0 RID: 194032 RVA: 0x00D35F70 File Offset: 0x00D34170
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer = null;
			}
			Log.Instance.Info(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[DangoBrawlMainBattlePanel] OnBeforeDestroy", default(ReadOnlySpan<ValueTuple<string, object>>));
			UUIExtendToggle extendToggle = base.GetExtendToggle(15);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnTogglePause));
				extendToggle.CanExecuteChange.Unbind();
			}
			if (this.FightingTickHandle != null)
			{
				DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
				if (battleManager != null)
				{
					battleManager.UnregisterFightingTickCallback(this.FightingTickHandle);
				}
				this.FightingTickHandle = null;
			}
		}

		// Token: 0x0602F5F1 RID: 194033 RVA: 0x00D36004 File Offset: 0x00D34204
		protected override void OnBeforeShow()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager != null)
			{
				battleManager.SetIsPause(false);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(15);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602F5F2 RID: 194034 RVA: 0x00D36034 File Offset: 0x00D34234
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			this.RefreshInfoOnShow();
			this.OnBattleTimerInit();
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.SetRoundSettleHideButtonsVisible(false);
		}

		// Token: 0x0602F5F3 RID: 194035 RVA: 0x00D36060 File Offset: 0x00D34260
		protected override void OnHideBattleChildViewPanel()
		{
			this.RefreshInfoOnHide();
			this.HideAllTips();
			this.CloseBuffDetailViewIfOpen();
			this.SetRoundSettleHideButtonsVisible(false);
			DangoBrawlModel.Instance.ResetPlayRate();
			if (this.FightingTickHandle != null)
			{
				DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
				if (battleManager != null)
				{
					battleManager.UnregisterFightingTickCallback(this.FightingTickHandle);
				}
				this.FightingTickHandle = null;
			}
		}

		// Token: 0x0602F5F4 RID: 194036 RVA: 0x00D360BC File Offset: 0x00D342BC
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<bool, bool>(EEventName.OnDangoBrawlEntityCreate, new Action<bool, bool>(this.OnDangoBrawlEntityCreate));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlFightingTimerInit, new Action(this.OnBattleTimerInit));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlFatigueFirstTriggered, new Action(this.OnFatigueFirstTriggered));
			EventSystem.Instance.Add<bool, bool>(EEventName.OnDangoBrawlBattleLogChanged, new Action<bool, bool>(this.OnDangoBrawlBattleLogChanged));
			EventSystem.Instance.Add<BuffVisualDelta>(EEventName.OnDangoBrawlBattleBuffVisualCue, new Action<BuffVisualDelta>(this.OnBuffVisualCue));
			EventSystem.Instance.Add<DangoBrawlDamageEvent, int>(EEventName.OnDangoBrawlDamageUiText, new Action<DangoBrawlDamageEvent, int>(this.OnDamageUiText));
			EventSystem.Instance.Add<int, int>(EEventName.OnDangoBrawlItemCdUpdate, new Action<int, int>(this.OnItemCdUpdate));
			EventSystem.Instance.Add<DangoBrawlItemUIEffectData>(EEventName.OnDangoBrawlItemUIEffectShow, new Action<DangoBrawlItemUIEffectData>(this.OnItemUIEffectShow));
			EventSystem.Instance.Add<int, int>(EEventName.OnDangoBrawlWeaponStop, new Action<int, int>(this.OnWeaponStop));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlRoundSettleStateChanged, new Action<bool>(this.OnRoundSettleUiStateChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlRoundSettleClosed, new Action(this.OnRoundSettleClosed));
		}

		// Token: 0x0602F5F5 RID: 194037 RVA: 0x00D36200 File Offset: 0x00D34400
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlEntityCreate, new Action<bool, bool>(this.OnDangoBrawlEntityCreate));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlFightingTimerInit, new Action(this.OnBattleTimerInit));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlFatigueFirstTriggered, new Action(this.OnFatigueFirstTriggered));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBattleLogChanged, new Action<bool, bool>(this.OnDangoBrawlBattleLogChanged));
			EventSystem.Instance.Remove<BuffVisualDelta>(EEventName.OnDangoBrawlBattleBuffVisualCue, new Action<BuffVisualDelta>(this.OnBuffVisualCue));
			EventSystem.Instance.Remove<DangoBrawlDamageEvent, int>(EEventName.OnDangoBrawlDamageUiText, new Action<DangoBrawlDamageEvent, int>(this.OnDamageUiText));
			EventSystem.Instance.Remove<int, int>(EEventName.OnDangoBrawlItemCdUpdate, new Action<int, int>(this.OnItemCdUpdate));
			EventSystem.Instance.Remove<DangoBrawlItemUIEffectData>(EEventName.OnDangoBrawlItemUIEffectShow, new Action<DangoBrawlItemUIEffectData>(this.OnItemUIEffectShow));
			EventSystem.Instance.Remove<int, int>(EEventName.OnDangoBrawlWeaponStop, new Action<int, int>(this.OnWeaponStop));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlRoundSettleStateChanged, new Action<bool>(this.OnRoundSettleUiStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlRoundSettleClosed, new Action(this.OnRoundSettleClosed));
		}

		// Token: 0x0602F5F6 RID: 194038 RVA: 0x00D36344 File Offset: 0x00D34544
		protected void RefreshInfoOnShow()
		{
			this.HideAllTips();
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DangoBrawlGeneral_1008", new <>z__ReadOnlySingleElementList<object>(battleManager.Round));
			DangoBrawlHpBarItem selfHpBar = this.SelfHpBar;
			if (selfHpBar != null)
			{
				selfHpBar.RefreshBind();
			}
			DangoBrawlHpBarItem opponentHpBar = this.OpponentHpBar;
			if (opponentHpBar != null)
			{
				opponentHpBar.RefreshBind();
			}
			DangoBrawlPlayRateButton speedButton = this.SpeedButton;
			if (speedButton != null)
			{
				speedButton.RefreshPlayRateShow();
			}
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			ActivityDangoBrawlData activityDangoBrawlData = (instance != null) ? instance.MyActivityData : null;
			int? num;
			if (activityDangoBrawlData == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlBackpackData bagpackData = activityDangoBrawlData.BagpackData;
				num = ((bagpackData != null) ? new int?(bagpackData.GetCurrentWeight()) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			int curCost = (((activityDangoBrawlData != null) ? activityDangoBrawlData.OpponentBackPackServerData : null) != null) ? DangoBrawlUtil.GetBackpackCurCost(activityDangoBrawlData.OpponentBackPackServerData) : 0;
			UUIText text = base.GetText(8);
			if (text != null)
			{
				text.SetText(this.BuildWeightText(valueOrDefault, true), true);
			}
			UUIText text2 = base.GetText(14);
			if (text2 != null)
			{
				text2.SetText(this.BuildWeightText(curCost, false), true);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(17);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			DangoBrawlBattleLogPanel battleLogPanel = this.BattleLogPanel;
			if (battleLogPanel != null)
			{
				battleLogPanel.OnShowInit();
			}
			this.HasClosedBuffDetailOnFightOver = false;
			this.RestoreBuffListOnShow();
			this.RefreshBackpackThenCD(activityDangoBrawlData).Forget();
		}

		// Token: 0x0602F5F7 RID: 194039 RVA: 0x00D364A4 File Offset: 0x00D346A4
		private void RestoreBuffListOnShow()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			DangoBrawlBattleReportPlayer dangoBrawlBattleReportPlayer = (battleManager != null) ? battleManager.BattleReportPlayer : null;
			List<BuffInfo> buffs = (dangoBrawlBattleReportPlayer != null) ? dangoBrawlBattleReportPlayer.BuffManager.GetCurrentBuffs(true) : new List<BuffInfo>();
			List<BuffInfo> buffs2 = (dangoBrawlBattleReportPlayer != null) ? dangoBrawlBattleReportPlayer.BuffManager.GetCurrentBuffs(false) : new List<BuffInfo>();
			DangoBrawlBattleBuffListItem selfBuffListItem = this.SelfBuffListItem;
			if (selfBuffListItem != null)
			{
				selfBuffListItem.RestoreFromSnapshot(buffs);
			}
			DangoBrawlBattleBuffListItem selfDeBuffListItem = this.SelfDeBuffListItem;
			if (selfDeBuffListItem != null)
			{
				selfDeBuffListItem.RestoreFromSnapshot(buffs);
			}
			DangoBrawlBattleBuffListItem opponentBuffListItem = this.OpponentBuffListItem;
			if (opponentBuffListItem != null)
			{
				opponentBuffListItem.RestoreFromSnapshot(buffs2);
			}
			DangoBrawlBattleBuffListItem opponentDeBuffListItem = this.OpponentDeBuffListItem;
			if (opponentDeBuffListItem == null)
			{
				return;
			}
			opponentDeBuffListItem.RestoreFromSnapshot(buffs2);
		}

		// Token: 0x0602F5F8 RID: 194040 RVA: 0x00D3653E File Offset: 0x00D3473E
		private void CloseBuffDetailViewIfOpen()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.DangoBrawlBuffDetailView))
			{
				UiManager.Instance.CloseView(EUiViewName.DangoBrawlBuffDetailView, null);
			}
		}

		// Token: 0x0602F5F9 RID: 194041 RVA: 0x00D36564 File Offset: 0x00D34764
		private void TryCloseBuffDetailOnFightOver()
		{
			if (this.HasClosedBuffDetailOnFightOver)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			bool? flag;
			if (battleManager == null)
			{
				flag = null;
			}
			else
			{
				DangoBrawlBattleReportPlayer battleReportPlayer = battleManager.BattleReportPlayer;
				flag = ((battleReportPlayer != null) ? new bool?(battleReportPlayer.IsFightOver()) : null);
			}
			bool? flag2 = flag;
			if (!flag2.GetValueOrDefault())
			{
				return;
			}
			this.HasClosedBuffDetailOnFightOver = true;
			this.CloseBuffDetailViewIfOpen();
		}

		// Token: 0x0602F5FA RID: 194042 RVA: 0x00D365CC File Offset: 0x00D347CC
		private UniTask RefreshEventInfoPanel()
		{
			DangoBrawlMainBattlePanel.<RefreshEventInfoPanel>d__38 <RefreshEventInfoPanel>d__;
			<RefreshEventInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEventInfoPanel>d__.<>4__this = this;
			<RefreshEventInfoPanel>d__.<>1__state = -1;
			<RefreshEventInfoPanel>d__.<>t__builder.Start<DangoBrawlMainBattlePanel.<RefreshEventInfoPanel>d__38>(ref <RefreshEventInfoPanel>d__);
			return <RefreshEventInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602F5FB RID: 194043 RVA: 0x00D36610 File Offset: 0x00D34810
		private UniTask RefreshBackpackThenCD(ActivityDangoBrawlData actData)
		{
			DangoBrawlMainBattlePanel.<RefreshBackpackThenCD>d__39 <RefreshBackpackThenCD>d__;
			<RefreshBackpackThenCD>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBackpackThenCD>d__.<>4__this = this;
			<RefreshBackpackThenCD>d__.actData = actData;
			<RefreshBackpackThenCD>d__.<>1__state = -1;
			<RefreshBackpackThenCD>d__.<>t__builder.Start<DangoBrawlMainBattlePanel.<RefreshBackpackThenCD>d__39>(ref <RefreshBackpackThenCD>d__);
			return <RefreshBackpackThenCD>d__.<>t__builder.Task;
		}

		// Token: 0x0602F5FC RID: 194044 RVA: 0x00D3665C File Offset: 0x00D3485C
		private void FlushPendingItemCdUpdate()
		{
			if (this.PendingItemCdUpdate == null)
			{
				return;
			}
			foreach (KeyValuePair<int, int> keyValuePair in this.PendingItemCdUpdate)
			{
				this.OnItemCdUpdate(keyValuePair.Key, keyValuePair.Value);
			}
			this.PendingItemCdUpdate = null;
		}

		// Token: 0x0602F5FD RID: 194045 RVA: 0x00D366CC File Offset: 0x00D348CC
		private void RefreshInfoOnHide()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			bool flag;
			if (battleManager == null)
			{
				flag = false;
			}
			else
			{
				DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
				flag = (((battleFsm != null) ? new EDangoBrawlFsmState?(battleFsm.GetCurrentStateType()) : null).GetValueOrDefault() == EDangoBrawlFsmState.FightingState);
			}
			if (!flag)
			{
				DangoBrawlBattleBackpackPanel backpackSelf = this.BackpackSelf;
				if (backpackSelf != null)
				{
					backpackSelf.ClearCdSnapshots();
				}
				DangoBrawlBattleBackpackPanel backpackOpponent = this.BackpackOpponent;
				if (backpackOpponent != null)
				{
					backpackOpponent.ClearCdSnapshots();
				}
			}
			else if (!this.IsBackpackLoading)
			{
				DangoBrawlBattleBackpackPanel backpackSelf2 = this.BackpackSelf;
				if (backpackSelf2 != null)
				{
					backpackSelf2.CaptureCdSnapshots();
				}
				DangoBrawlBattleBackpackPanel backpackOpponent2 = this.BackpackOpponent;
				if (backpackOpponent2 != null)
				{
					backpackOpponent2.CaptureCdSnapshots();
				}
			}
			DangoBrawlBattleBackpackPanel backpackSelf3 = this.BackpackSelf;
			if (backpackSelf3 != null)
			{
				backpackSelf3.UnRegisterTimerHandle();
			}
			DangoBrawlBattleBackpackPanel backpackOpponent3 = this.BackpackOpponent;
			if (backpackOpponent3 == null)
			{
				return;
			}
			backpackOpponent3.UnRegisterTimerHandle();
		}

		// Token: 0x0602F5FE RID: 194046 RVA: 0x00D36788 File Offset: 0x00D34988
		[NullableContext(1)]
		private string BuildWeightText(int curCost, bool isSelf)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			ActivityGameplayEntity activityGameplayEntity = (battleManager != null) ? battleManager.GetEntity(isSelf) : null;
			DangoAttributeComponent dangoAttributeComponent = (activityGameplayEntity != null) ? activityGameplayEntity.GetComponent<DangoAttributeComponent>() : null;
			int value = (dangoAttributeComponent != null) ? dangoAttributeComponent.GetAttribute(2) : 0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(curCost);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602F5FF RID: 194047 RVA: 0x00D367F4 File Offset: 0x00D349F4
		private void BindBuffDetailViewCallbacks()
		{
			this.SelfBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnSelfOpenBuffDetailView);
			this.SelfDeBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnSelfOpenBuffDetailView);
			this.OpponentBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnOpponentOpenBuffDetailView);
			this.OpponentDeBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnOpponentOpenBuffDetailView);
		}

		// Token: 0x0602F600 RID: 194048 RVA: 0x00D36860 File Offset: 0x00D34A60
		private void OpenBuffDetailView(EDangoBrawlBuffDetailSide side, EDangoBrawlBuffType jumpType, int selectId)
		{
			DangoBrawlBuffDetailViewOpenData param = this.CreateBuffDetailOpenData(side, jumpType, selectId);
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlBuffDetailView, param, null);
		}

		// Token: 0x0602F601 RID: 194049 RVA: 0x00D36888 File Offset: 0x00D34A88
		[NullableContext(1)]
		private DangoBrawlBuffDetailViewOpenData CreateBuffDetailOpenData(EDangoBrawlBuffDetailSide initialSide, EDangoBrawlBuffType jumpType, int selectedConfigId)
		{
			return new DangoBrawlBuffDetailViewOpenData
			{
				InitialSide = initialSide,
				JumpBuffType = jumpType,
				SelectedConfigId = selectedConfigId,
				SelfSide = this.BuildSideDetailData(EDangoBrawlBuffDetailSide.Self, initialSide, jumpType, selectedConfigId),
				OpponentSide = this.BuildSideDetailData(EDangoBrawlBuffDetailSide.Opponent, initialSide, jumpType, selectedConfigId)
			};
		}

		// Token: 0x0602F602 RID: 194050 RVA: 0x00D368C4 File Offset: 0x00D34AC4
		[NullableContext(1)]
		private DangoBrawlBuffSideDetailData BuildSideDetailData(EDangoBrawlBuffDetailSide targetSide, EDangoBrawlBuffDetailSide initialSide, EDangoBrawlBuffType jumpType, int selectedConfigId)
		{
			bool flag = targetSide == EDangoBrawlBuffDetailSide.Self;
			DangoBrawlBattleBuffListItem dangoBrawlBattleBuffListItem = flag ? this.SelfBuffListItem : this.OpponentBuffListItem;
			DangoBrawlBattleBuffListItem dangoBrawlBattleBuffListItem2 = flag ? this.SelfDeBuffListItem : this.OpponentDeBuffListItem;
			bool flag2 = initialSide == targetSide;
			int selectId = (flag2 && jumpType == EDangoBrawlBuffType.Buff) ? selectedConfigId : 0;
			int selectId2 = (flag2 && jumpType == EDangoBrawlBuffType.DeBuff) ? selectedConfigId : 0;
			List<DangoBrawlBattleBuffDetailItemData> list = dangoBrawlBattleBuffListItem.BuildBuffDetailDataList(selectId);
			List<DangoBrawlBattleBuffDetailItemData> list2 = dangoBrawlBattleBuffListItem2.BuildBuffDetailDataList(selectId2);
			List<DangoBrawlBattleBuffDetailItemData> list3 = new List<DangoBrawlBattleBuffDetailItemData>(list.Count + list2.Count);
			list3.AddRange(list);
			list3.AddRange(list2);
			NoLinq.SortStable<DangoBrawlBattleBuffDetailItemData>(list3, (DangoBrawlBattleBuffDetailItemData left, DangoBrawlBattleBuffDetailItemData right) => left.BaseData.SortIndex.CompareTo(right.BaseData.SortIndex));
			ValueTuple<string, string> valueTuple = this.BuildRoleSideInfo(flag);
			return new DangoBrawlBuffSideDetailData
			{
				RoleNameKey = valueTuple.Item1,
				RoleIcon = valueTuple.Item2,
				BuffDetailDataList = list3
			};
		}

		// Token: 0x0602F603 RID: 194051 RVA: 0x00D369A8 File Offset: 0x00D34BA8
		[return: TupleElementNames(new string[]
		{
			"RoleNameKey",
			"RoleIcon"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<string, string> BuildRoleSideInfo(bool isSelf)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return new ValueTuple<string, string>(string.Empty, string.Empty);
			}
			int dangoId = battleManager.GetDangoId(isSelf);
			if (isSelf)
			{
				DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(dangoId);
				if (roleConfigById == null)
				{
					return new ValueTuple<string, string>(string.Empty, string.Empty);
				}
				return new ValueTuple<string, string>(roleConfigById.Value.Name, roleConfigById.Value.RoleBuffIcon);
			}
			else
			{
				DangoBrawlOpponent? opponentConfigById = DangoBrawlConfig.Instance.GetOpponentConfigById(dangoId);
				if (opponentConfigById == null)
				{
					return new ValueTuple<string, string>(string.Empty, string.Empty);
				}
				return new ValueTuple<string, string>(opponentConfigById.Value.Name, opponentConfigById.Value.RoleBuffIcon);
			}
		}

		// Token: 0x0602F604 RID: 194052 RVA: 0x00D36A74 File Offset: 0x00D34C74
		[NullableContext(1)]
		[return: Nullable(2)]
		private DangoBrawlBattleBuffListItem ResolveBuffListItem(BuffVisualDelta delta)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return null;
			}
			bool isSelfByFighterUid = battleManager.GetIsSelfByFighterUid(delta.TargetFighterUId);
			DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(delta.BuffConfigId);
			if (buffConfigById == null)
			{
				return null;
			}
			bool flag = buffConfigById.Value.BuffType == 2;
			if (isSelfByFighterUid)
			{
				if (!flag)
				{
					return this.SelfBuffListItem;
				}
				return this.SelfDeBuffListItem;
			}
			else
			{
				if (!flag)
				{
					return this.OpponentBuffListItem;
				}
				return this.OpponentDeBuffListItem;
			}
		}

		// Token: 0x0602F605 RID: 194053 RVA: 0x00D36AF4 File Offset: 0x00D34CF4
		private void OnClickedClose()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			EDangoBrawlFsmState? edangoBrawlFsmState;
			if (battleManager == null)
			{
				edangoBrawlFsmState = null;
			}
			else
			{
				DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
				edangoBrawlFsmState = ((battleFsm != null) ? new EDangoBrawlFsmState?(battleFsm.GetCurrentStateType()) : null);
			}
			EDangoBrawlFsmState? edangoBrawlFsmState2 = edangoBrawlFsmState;
			if (edangoBrawlFsmState2.GetValueOrDefault() == EDangoBrawlFsmState.RoundSettle)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlGeneral_1028", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlPauseView, EDangoBrawlPauseViewFrom.BattlePanel, null);
		}

		// Token: 0x0602F606 RID: 194054 RVA: 0x00D36B6F File Offset: 0x00D34D6F
		private void OnClickedBuffDetail1()
		{
		}

		// Token: 0x0602F607 RID: 194055 RVA: 0x00D36B71 File Offset: 0x00D34D71
		private void OnClickedBuffDetail2()
		{
		}

		// Token: 0x0602F608 RID: 194056 RVA: 0x00D36B73 File Offset: 0x00D34D73
		private void OnClickedSpecItemL()
		{
		}

		// Token: 0x0602F609 RID: 194057 RVA: 0x00D36B75 File Offset: 0x00D34D75
		private void OnClickedBuffDetail3()
		{
		}

		// Token: 0x0602F60A RID: 194058 RVA: 0x00D36B77 File Offset: 0x00D34D77
		private void OnClickedBuffDetail4()
		{
		}

		// Token: 0x0602F60B RID: 194059 RVA: 0x00D36B79 File Offset: 0x00D34D79
		private void OnClickedSpecItemR()
		{
		}

		// Token: 0x0602F60C RID: 194060 RVA: 0x00D36B7B File Offset: 0x00D34D7B
		private void OnTogglePause(EToggleState state)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPause(state == EToggleState.ETT_Checked);
		}

		// Token: 0x0602F60D RID: 194061 RVA: 0x00D36B98 File Offset: 0x00D34D98
		private bool CanTogglePause()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return false;
			}
			DangoBrawlFsm battleFsm = battleManager.GetBattleFsm();
			bool flag = battleFsm != null && battleFsm.GetCurrentStateType() == EDangoBrawlFsmState.FightingState;
			DangoBrawlBattleReportPlayer battleReportPlayer = battleManager.BattleReportPlayer;
			bool flag2 = battleReportPlayer != null && battleReportPlayer.IsFightOver();
			return flag && !flag2;
		}

		// Token: 0x0602F60E RID: 194062 RVA: 0x00D36BE8 File Offset: 0x00D34DE8
		private void OnToggleDetail(EToggleState state)
		{
			DangoBrawlBattleLogPanel battleLogPanel = this.BattleLogPanel;
			if (battleLogPanel == null)
			{
				return;
			}
			battleLogPanel.SetActiveByToggle(state == EToggleState.ETT_Checked);
		}

		// Token: 0x0602F60F RID: 194063 RVA: 0x00D36BFE File Offset: 0x00D34DFE
		private void OnClickedCloseMask()
		{
			this.HideAllTips();
		}

		// Token: 0x0602F610 RID: 194064 RVA: 0x00D36C06 File Offset: 0x00D34E06
		[NullableContext(1)]
		private void OnSelfBackpackItemClick(UUIItem gridItem, DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlBattleBackpackPanel backpackOpponent = this.BackpackOpponent;
			if (backpackOpponent != null)
			{
				backpackOpponent.ClearItemSelected();
			}
			this.RefreshBackpackItemTips(gridItem, itemData);
		}

		// Token: 0x0602F611 RID: 194065 RVA: 0x00D36C21 File Offset: 0x00D34E21
		[NullableContext(1)]
		private void OnOpponentBackpackItemClick(UUIItem gridItem, DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlBattleBackpackPanel backpackSelf = this.BackpackSelf;
			if (backpackSelf != null)
			{
				backpackSelf.ClearItemSelected();
			}
			this.RefreshBackpackItemTips(gridItem, itemData);
		}

		// Token: 0x0602F612 RID: 194066 RVA: 0x00D36C3C File Offset: 0x00D34E3C
		[NullableContext(1)]
		private void RefreshBackpackItemTips(UUIItem gridItem, DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.Refresh(new DangoBrawlItemTipsData
				{
					ItemId = itemData.MyConfigId,
					From = EDangoBrawlItemTipsFrom.Battle,
					ShowCombine = new bool?(false),
					GridItem = gridItem,
					GridSize = new float?((float)88),
					OperationMode = EDangoBrawlTipsOperationMode.Selected,
					ItemLeftTopPos = new PanelPos?(itemData.MyLeftTopPos)
				});
			}
			DangoBrawlItemTipsBase itemTips2 = this.ItemTips;
			if (itemTips2 == null)
			{
				return;
			}
			itemTips2.SetTipsVisible(true);
		}

		// Token: 0x0602F613 RID: 194067 RVA: 0x00D36CC0 File Offset: 0x00D34EC0
		private void HideAllTips()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.SetTipsVisible(false);
			}
			DangoBrawlEventInfoPanel selfEventInfoPanel = this.SelfEventInfoPanel;
			if (selfEventInfoPanel != null)
			{
				selfEventInfoPanel.HideTips();
			}
			DangoBrawlBattleBackpackPanel backpackSelf = this.BackpackSelf;
			if (backpackSelf != null)
			{
				backpackSelf.ClearItemSelected();
			}
			DangoBrawlBattleBackpackPanel backpackOpponent = this.BackpackOpponent;
			if (backpackOpponent == null)
			{
				return;
			}
			backpackOpponent.ClearItemSelected();
		}

		// Token: 0x0602F614 RID: 194068 RVA: 0x00D36D11 File Offset: 0x00D34F11
		private void OnDangoBrawlEntityCreate(bool selfCreate, bool opponentCreate)
		{
			if (selfCreate)
			{
				DangoBrawlHpBarItem selfHpBar = this.SelfHpBar;
				if (selfHpBar != null)
				{
					selfHpBar.RefreshBind();
				}
			}
			if (opponentCreate)
			{
				DangoBrawlHpBarItem opponentHpBar = this.OpponentHpBar;
				if (opponentHpBar == null)
				{
					return;
				}
				opponentHpBar.RefreshBind();
			}
		}

		// Token: 0x0602F615 RID: 194069 RVA: 0x00D36D3C File Offset: 0x00D34F3C
		private void OnFatigueFirstTriggered()
		{
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			DangoBrawlHpBarItem selfHpBar = this.SelfHpBar;
			if (selfHpBar != null)
			{
				selfHpBar.OnBeginFatigue();
			}
			DangoBrawlHpBarItem opponentHpBar = this.OpponentHpBar;
			if (opponentHpBar != null)
			{
				opponentHpBar.OnBeginFatigue();
			}
			this.LevelSequencePlayer.PlayLevelSequenceByName("TiredTips", false, null, false);
		}

		// Token: 0x0602F616 RID: 194070 RVA: 0x00D36D9A File Offset: 0x00D34F9A
		private void OnDangoBrawlBattleLogChanged(bool isSelf, bool isHeal)
		{
			DangoBrawlBattleLogPanel battleLogPanel = this.BattleLogPanel;
			if (battleLogPanel == null)
			{
				return;
			}
			battleLogPanel.RefreshOnEmit(isSelf, isHeal);
		}

		// Token: 0x0602F617 RID: 194071 RVA: 0x00D36DB0 File Offset: 0x00D34FB0
		private void OnBattleTimerInit()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			if (this.FightingTickHandle != null)
			{
				return;
			}
			this.FightingTickHandle = battleManager.RegisterFightingTickCallback(new TTimerAction(this.OnTickFighting), 20f);
		}

		// Token: 0x0602F618 RID: 194072 RVA: 0x00D36DF4 File Offset: 0x00D34FF4
		private void OnTickFighting(float delta)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlFightingClock dangoBrawlFightingClock = (battleManager != null) ? battleManager.FightingClock : null;
			if (dangoBrawlFightingClock == null)
			{
				return;
			}
			DangoBrawlBattleManager battleManager2 = DangoBrawlModel.Instance.GetBattleManager(true);
			bool? flag;
			if (battleManager2 == null)
			{
				flag = null;
			}
			else
			{
				DangoBrawlBattleReportPlayer battleReportPlayer = battleManager2.BattleReportPlayer;
				flag = ((battleReportPlayer != null) ? new bool?(battleReportPlayer.IsFightOver()) : null);
			}
			bool? flag2 = flag;
			if (flag2.GetValueOrDefault())
			{
				this.TryCloseBuffDetailOnFightOver();
				return;
			}
			string newText = ((int)Math.Floor((double)(dangoBrawlFightingClock.Elapsed / 1000f))).ToString().PadLeft(2, '0');
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0602F619 RID: 194073 RVA: 0x00D36E9D File Offset: 0x00D3509D
		[NullableContext(1)]
		private void OnBuffVisualCue(BuffVisualDelta visualDelta)
		{
			DangoBrawlBattleBuffListItem dangoBrawlBattleBuffListItem = this.ResolveBuffListItem(visualDelta);
			if (dangoBrawlBattleBuffListItem == null)
			{
				return;
			}
			dangoBrawlBattleBuffListItem.Refresh(visualDelta);
		}

		// Token: 0x0602F61A RID: 194074 RVA: 0x00D36EB4 File Offset: 0x00D350B4
		[NullableContext(1)]
		private unsafe void OnDamageUiText(DangoBrawlDamageEvent evt, int uiDamageConfigId)
		{
			if (evt.SourceItemUid == 0)
			{
				if (evt.Source != EDangoBrawlDamageSource.BuffGain)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DangoBrawl;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "[OnDamageUiText] UI飘字缺少来源道具 UID(SourceItemUid=0)，无法定位 UIItem";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("source", evt.Source);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uiDamageConfigId", uiDamageConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("targetFighterUid", evt.TargetFighterUid);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			bool isSelfByFighterUid = battleManager.GetIsSelfByFighterUid(evt.SourceFighterUid);
			EDangoBrawlDamageSource source = evt.Source;
			bool flag = source - EDangoBrawlDamageSource.Heal <= 3;
			bool isCure = flag;
			DangoBrawlBattleBackpackPanel dangoBrawlBattleBackpackPanel = isSelfByFighterUid ? this.BackpackSelf : this.BackpackOpponent;
			if (dangoBrawlBattleBackpackPanel == null)
			{
				return;
			}
			dangoBrawlBattleBackpackPanel.ShowItemDamageText(evt.SourceItemUid, uiDamageConfigId, isSelfByFighterUid, evt.Value, evt.IsCrit, isCure);
		}

		// Token: 0x0602F61B RID: 194075 RVA: 0x00D36FC8 File Offset: 0x00D351C8
		private void OnItemCdUpdate(int itemUid, int nextReadyMs)
		{
			if (DangoBrawlUtil.IsBagItemByUid(itemUid))
			{
				return;
			}
			if (this.IsBackpackLoading)
			{
				if (this.PendingItemCdUpdate == null)
				{
					this.PendingItemCdUpdate = new Dictionary<int, int>();
				}
				this.PendingItemCdUpdate[itemUid] = nextReadyMs;
				return;
			}
			DangoBrawlBattleBackpackPanel backpackSelf = this.BackpackSelf;
			bool flag = backpackSelf != null && backpackSelf.OnItemCdUpdate(itemUid, nextReadyMs);
			DangoBrawlBattleBackpackPanel backpackOpponent = this.BackpackOpponent;
			bool flag2 = backpackOpponent != null && backpackOpponent.OnItemCdUpdate(itemUid, nextReadyMs);
			if (!flag && !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[OnItemCdUpdate] 未找到对应道具 UID";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemUid", itemUid);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602F61C RID: 194076 RVA: 0x00D37064 File Offset: 0x00D35264
		private void OnWeaponStop(int itemUid, int stopMs)
		{
			DangoBrawlBattleBackpackPanel backpackSelf = this.BackpackSelf;
			bool flag = backpackSelf != null && backpackSelf.OnWeaponStop(itemUid, stopMs);
			DangoBrawlBattleBackpackPanel backpackOpponent = this.BackpackOpponent;
			bool flag2 = backpackOpponent != null && backpackOpponent.OnWeaponStop(itemUid, stopMs);
			if (!flag && !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[OnWeaponStop] 未找到对应道具 UID";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemUid", itemUid);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602F61D RID: 194077 RVA: 0x00D370D0 File Offset: 0x00D352D0
		private void OnItemUIEffectShow(DangoBrawlItemUIEffectData data)
		{
			DangoBrawlBattleBackpackPanel backpackSelf = this.BackpackSelf;
			bool flag = backpackSelf != null && backpackSelf.OnItemEffectShow(data);
			DangoBrawlBattleBackpackPanel backpackOpponent = this.BackpackOpponent;
			bool flag2 = backpackOpponent != null && backpackOpponent.OnItemEffectShow(data);
			if (!flag && !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[OnItemUIEffectShow] 未找到对应道具 UID";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemUid", data.ItemUId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602F61E RID: 194078 RVA: 0x00D3713D File Offset: 0x00D3533D
		private void OnSelfOpenBuffDetailView(EDangoBrawlBuffType type, int id)
		{
			this.OpenBuffDetailView(EDangoBrawlBuffDetailSide.Self, type, id);
		}

		// Token: 0x0602F61F RID: 194079 RVA: 0x00D37148 File Offset: 0x00D35348
		private void OnOpponentOpenBuffDetailView(EDangoBrawlBuffType type, int id)
		{
			this.OpenBuffDetailView(EDangoBrawlBuffDetailSide.Opponent, type, id);
		}

		// Token: 0x0602F620 RID: 194080 RVA: 0x00D37154 File Offset: 0x00D35354
		public UUIItem GetTogDetailItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(17);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.RootUIComp.Get();
		}

		// Token: 0x0602F621 RID: 194081 RVA: 0x00D3717C File Offset: 0x00D3537C
		private void OnRoundSettleUiStateChanged(bool show)
		{
			if (!show)
			{
				this.RefreshRoundSettleHideFlags();
			}
			this.SetRoundSettleHideButtonsVisible(!show);
		}

		// Token: 0x0602F622 RID: 194082 RVA: 0x00D37191 File Offset: 0x00D35391
		private void OnRoundSettleClosed()
		{
			this.SetRoundSettleHideButtonsVisible(false);
		}

		// Token: 0x0602F623 RID: 194083 RVA: 0x00D3719C File Offset: 0x00D3539C
		private void SetRoundSettleHideButtonsVisible(bool visible)
		{
			UUIButtonComponent button = base.GetButton(22);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(visible);
				}
			}
			ButtonItem nextRoundInHideButton = this.NextRoundInHideButton;
			if (nextRoundInHideButton != null)
			{
				nextRoundInHideButton.SetUiActive(visible);
			}
			bool flag = this.IsAddRoundSettle || this.CanEnterAdditionalRound;
			bool uiActive = visible && flag && !this.IsLastRound;
			ButtonItem leaveInHideButton = this.LeaveInHideButton;
			if (leaveInHideButton != null)
			{
				leaveInHideButton.SetUiActive(uiActive);
			}
			if (visible)
			{
				this.RefreshNextRoundInHideButtonText();
			}
		}

		// Token: 0x0602F624 RID: 194084 RVA: 0x00D37224 File Offset: 0x00D35424
		private void RefreshNextRoundInHideButtonText()
		{
			string textId = "DangoBrawlBattleUIText_059";
			if (this.IsLastRoundWin)
			{
				textId = "DangoBrawlBattleUIText_061";
			}
			else if (this.CanEnterAdditionalRound)
			{
				textId = "DangoBrawlBattleUIText_060";
			}
			ButtonItem nextRoundInHideButton = this.NextRoundInHideButton;
			if (nextRoundInHideButton == null)
			{
				return;
			}
			nextRoundInHideButton.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x0602F625 RID: 194085 RVA: 0x00D3726C File Offset: 0x00D3546C
		private void RefreshRoundSettleHideFlags()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			DangoBrawlInstBaseNotify dangoBrawlInstBaseNotify = (myActivityData != null) ? myActivityData.InstBase : null;
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById((dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.ChallengeId : 0);
			bool valueOrDefault = ((battleManager != null) ? battleManager.IsWin : null).GetValueOrDefault();
			int num = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.WinCount : 0;
			int num2 = (dangoBrawlInstBaseNotify != null) ? dangoBrawlInstBaseNotify.LoseCount : 0;
			int num3 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().AdditionRound : 0;
			int num4 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().WinCount : 0;
			int num5 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().HpCount : 0;
			int num6 = valueOrDefault ? (num + 1) : num;
			int num7 = valueOrDefault ? num2 : (num2 + 1);
			bool flag = num6 >= num4;
			bool flag2 = num >= num4 && num3 > 0;
			this.IsAddRoundSettle = (flag && flag2);
			bool flag3 = flag && !flag2;
			this.CanEnterAdditionalRound = (num3 > 0 && flag3);
			this.IsLastRoundWin = (valueOrDefault && num6 >= num4 + num3);
			this.IsLastRound = (this.IsLastRoundWin || num7 >= num5 || (battleManager != null && battleManager.IsFinalRound()));
		}

		// Token: 0x0602F626 RID: 194086 RVA: 0x00D373DF File Offset: 0x00D355DF
		private void OnClickedRoundSettleRecover()
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlRoundSettleRecover);
		}

		// Token: 0x0602F627 RID: 194087 RVA: 0x00D373F1 File Offset: 0x00D355F1
		private void OnClickedRoundSettleNextRound()
		{
			if (this.CanEnterAdditionalRound)
			{
				this.ShowConfirmBoxToAdditionalRound();
				return;
			}
			this.RequestFightOverFromHide(false, false).Forget();
		}

		// Token: 0x0602F628 RID: 194088 RVA: 0x00D3740F File Offset: 0x00D3560F
		private void OnClickedRoundSettleLeave()
		{
			if (this.CanEnterAdditionalRound || this.IsLastRoundWin)
			{
				this.RequestFightOverFromHide(false, false).Forget();
				return;
			}
			this.ShowConfirmBoxToFinalSettle();
		}

		// Token: 0x0602F629 RID: 194089 RVA: 0x00D37438 File Offset: 0x00D35638
		private void ShowConfirmBoxToAdditionalRound()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlEnterAdditionalConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.RequestFightOverFromHide(true, false).Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602F62A RID: 194090 RVA: 0x00D3747C File Offset: 0x00D3567C
		private void ShowConfirmBoxToFinalSettle()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlEnterFinalSettleConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.RequestFightOverFromHide(false, true).Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602F62B RID: 194091 RVA: 0x00D374C0 File Offset: 0x00D356C0
		private UniTask RequestFightOverFromHide(bool isAdditionalRound = false, bool needDirectEnterSettle = false)
		{
			DangoBrawlMainBattlePanel.<RequestFightOverFromHide>d__87 <RequestFightOverFromHide>d__;
			<RequestFightOverFromHide>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestFightOverFromHide>d__.<>4__this = this;
			<RequestFightOverFromHide>d__.isAdditionalRound = isAdditionalRound;
			<RequestFightOverFromHide>d__.needDirectEnterSettle = needDirectEnterSettle;
			<RequestFightOverFromHide>d__.<>1__state = -1;
			<RequestFightOverFromHide>d__.<>t__builder.Start<DangoBrawlMainBattlePanel.<RequestFightOverFromHide>d__87>(ref <RequestFightOverFromHide>d__);
			return <RequestFightOverFromHide>d__.<>t__builder.Task;
		}

		// Token: 0x0602F62C RID: 194092 RVA: 0x00D37514 File Offset: 0x00D35714
		private static void CloseRoundSettleView()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			bool valueOrDefault = ((battleManager != null) ? battleManager.IsWin : null).GetValueOrDefault();
			UiManager.Instance.CloseView(valueOrDefault ? EUiViewName.DangoBrawlRoundSuccessSettleView : EUiViewName.DangoBrawlRoundFailureSettleView, null);
		}

		// Token: 0x040191C4 RID: 102852
		private const int TICK_INTERVAL = 20;

		// Token: 0x040191C5 RID: 102853
		private const int BACKPACK_GRID_SIZE = 88;

		// Token: 0x040191C6 RID: 102854
		private DangoBrawlHpBarItem SelfHpBar;

		// Token: 0x040191C7 RID: 102855
		private DangoBrawlHpBarItem OpponentHpBar;

		// Token: 0x040191C8 RID: 102856
		private DangoBrawlPlayRateButton SpeedButton;

		// Token: 0x040191C9 RID: 102857
		private DangoBrawlBattleLogPanel BattleLogPanel;

		// Token: 0x040191CA RID: 102858
		private DangoBrawlBattleBackpackPanel BackpackSelf;

		// Token: 0x040191CB RID: 102859
		private DangoBrawlBattleBackpackPanel BackpackOpponent;

		// Token: 0x040191CC RID: 102860
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x040191CD RID: 102861
		private ButtonItem NextRoundInHideButton;

		// Token: 0x040191CE RID: 102862
		private ButtonItem LeaveInHideButton;

		// Token: 0x040191CF RID: 102863
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040191D0 RID: 102864
		private DangoBrawlBattleBuffListItem SelfBuffListItem;

		// Token: 0x040191D1 RID: 102865
		private DangoBrawlBattleBuffListItem SelfDeBuffListItem;

		// Token: 0x040191D2 RID: 102866
		private DangoBrawlBattleBuffListItem OpponentBuffListItem;

		// Token: 0x040191D3 RID: 102867
		private DangoBrawlBattleBuffListItem OpponentDeBuffListItem;

		// Token: 0x040191D4 RID: 102868
		private DangoBrawlEventInfoPanel SelfEventInfoPanel;

		// Token: 0x040191D5 RID: 102869
		private TimerHandle FightingTickHandle;

		// Token: 0x040191D6 RID: 102870
		private bool IsBackpackLoading;

		// Token: 0x040191D7 RID: 102871
		private Dictionary<int, int> PendingItemCdUpdate;

		// Token: 0x040191D8 RID: 102872
		private bool HasClosedBuffDetailOnFightOver;

		// Token: 0x040191D9 RID: 102873
		private bool CanEnterAdditionalRound;

		// Token: 0x040191DA RID: 102874
		private bool IsAddRoundSettle;

		// Token: 0x040191DB RID: 102875
		private bool IsLastRoundWin;

		// Token: 0x040191DC RID: 102876
		private bool IsLastRound;

		// Token: 0x0200A665 RID: 42597
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04033707 RID: 210695
			BtnClose,
			// Token: 0x04033708 RID: 210696
			TxtRoundNum,
			// Token: 0x04033709 RID: 210697
			TxtTime,
			// Token: 0x0403370A RID: 210698
			PanelBackpackBrawlHp,
			// Token: 0x0403370B RID: 210699
			BtnBuffDetail1,
			// Token: 0x0403370C RID: 210700
			BtnBuffDetail2,
			// Token: 0x0403370D RID: 210701
			EventInfoPanelL,
			// Token: 0x0403370E RID: 210702
			PanelOffsetL,
			// Token: 0x0403370F RID: 210703
			TxtWeightNumSelf,
			// Token: 0x04033710 RID: 210704
			PanelBackpackBrawlHp2,
			// Token: 0x04033711 RID: 210705
			BtnBuffDetail3,
			// Token: 0x04033712 RID: 210706
			BtnBuffDetail4,
			// Token: 0x04033713 RID: 210707
			EventInfoPanelR,
			// Token: 0x04033714 RID: 210708
			PanelOffsetR,
			// Token: 0x04033715 RID: 210709
			TxtWeightNumOpponent,
			// Token: 0x04033716 RID: 210710
			TogPause,
			// Token: 0x04033717 RID: 210711
			BtnSpeed,
			// Token: 0x04033718 RID: 210712
			TogDetail,
			// Token: 0x04033719 RID: 210713
			PanelInfo,
			// Token: 0x0403371A RID: 210714
			PanelTiredTips,
			// Token: 0x0403371B RID: 210715
			BtnCloseMask,
			// Token: 0x0403371C RID: 210716
			BackpackBrawlTips,
			// Token: 0x0403371D RID: 210717
			BtnRecoverByRoundSettle,
			// Token: 0x0403371E RID: 210718
			BtnNextRoundInHideByRoundSettle,
			// Token: 0x0403371F RID: 210719
			BtnLeaveInHideByRoundSettle
		}
	}
}
