using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005A07 RID: 23047
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlMainBattlePanel : BattleChildViewPanel
	{
		// Token: 0x0603A6A5 RID: 239269 RVA: 0x00DE54C8 File Offset: 0x00DE36C8
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

		// Token: 0x0603A6A6 RID: 239270 RVA: 0x00DE5970 File Offset: 0x00DE3B70
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlMainBattlePanel.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlMainBattlePanel.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A6A7 RID: 239271 RVA: 0x00DE59B4 File Offset: 0x00DE3BB4
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

		// Token: 0x0603A6A8 RID: 239272 RVA: 0x00DE5A48 File Offset: 0x00DE3C48
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

		// Token: 0x0603A6A9 RID: 239273 RVA: 0x00DE5A78 File Offset: 0x00DE3C78
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

		// Token: 0x0603A6AA RID: 239274 RVA: 0x00DE5AA4 File Offset: 0x00DE3CA4
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

		// Token: 0x0603A6AB RID: 239275 RVA: 0x00DE5B00 File Offset: 0x00DE3D00
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

		// Token: 0x0603A6AC RID: 239276 RVA: 0x00DE5C44 File Offset: 0x00DE3E44
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

		// Token: 0x0603A6AD RID: 239277 RVA: 0x00DE5D88 File Offset: 0x00DE3F88
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

		// Token: 0x0603A6AE RID: 239278 RVA: 0x00DE5EE8 File Offset: 0x00DE40E8
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

		// Token: 0x0603A6AF RID: 239279 RVA: 0x00DE5F82 File Offset: 0x00DE4182
		private void CloseBuffDetailViewIfOpen()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.DangoBrawlBuffDetailView))
			{
				UiManager.Instance.CloseView(EUiViewName.DangoBrawlBuffDetailView, null);
			}
		}

		// Token: 0x0603A6B0 RID: 239280 RVA: 0x00DE5FA8 File Offset: 0x00DE41A8
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

		// Token: 0x0603A6B1 RID: 239281 RVA: 0x00DE6010 File Offset: 0x00DE4210
		private UniTask RefreshEventInfoPanel()
		{
			DangoBrawlMainBattlePanel.<RefreshEventInfoPanel>d__38 <RefreshEventInfoPanel>d__;
			<RefreshEventInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEventInfoPanel>d__.<>4__this = this;
			<RefreshEventInfoPanel>d__.<>1__state = -1;
			<RefreshEventInfoPanel>d__.<>t__builder.Start<DangoBrawlMainBattlePanel.<RefreshEventInfoPanel>d__38>(ref <RefreshEventInfoPanel>d__);
			return <RefreshEventInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603A6B2 RID: 239282 RVA: 0x00DE6054 File Offset: 0x00DE4254
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

		// Token: 0x0603A6B3 RID: 239283 RVA: 0x00DE60A0 File Offset: 0x00DE42A0
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

		// Token: 0x0603A6B4 RID: 239284 RVA: 0x00DE6110 File Offset: 0x00DE4310
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

		// Token: 0x0603A6B5 RID: 239285 RVA: 0x00DE61CC File Offset: 0x00DE43CC
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

		// Token: 0x0603A6B6 RID: 239286 RVA: 0x00DE6238 File Offset: 0x00DE4438
		private void BindBuffDetailViewCallbacks()
		{
			this.SelfBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnSelfOpenBuffDetailView);
			this.SelfDeBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnSelfOpenBuffDetailView);
			this.OpponentBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnOpponentOpenBuffDetailView);
			this.OpponentDeBuffListItem.OnOpenDetailView = new Action<EDangoBrawlBuffType, int>(this.OnOpponentOpenBuffDetailView);
		}

		// Token: 0x0603A6B7 RID: 239287 RVA: 0x00DE62A4 File Offset: 0x00DE44A4
		private void OpenBuffDetailView(EDangoBrawlBuffDetailSide side, EDangoBrawlBuffType jumpType, int selectId)
		{
			DangoBrawlBuffDetailViewOpenData param = this.CreateBuffDetailOpenData(side, jumpType, selectId);
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlBuffDetailView, param, null);
		}

		// Token: 0x0603A6B8 RID: 239288 RVA: 0x00DE62CC File Offset: 0x00DE44CC
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

		// Token: 0x0603A6B9 RID: 239289 RVA: 0x00DE6308 File Offset: 0x00DE4508
		[NullableContext(1)]
		private DangoBrawlBuffSideDetailData BuildSideDetailData(EDangoBrawlBuffDetailSide targetSide, EDangoBrawlBuffDetailSide initialSide, EDangoBrawlBuffType jumpType, int selectedConfigId)
		{
			bool flag = targetSide == EDangoBrawlBuffDetailSide.Self;
			DangoBrawlBattleBuffListItem dangoBrawlBattleBuffListItem = flag ? this.SelfBuffListItem : this.OpponentBuffListItem;
			DangoBrawlBattleBuffListItem dangoBrawlBattleBuffListItem2 = flag ? this.SelfDeBuffListItem : this.OpponentDeBuffListItem;
			bool flag2 = initialSide == targetSide;
			int selectId = (flag2 && jumpType == EDangoBrawlBuffType.Buff) ? selectedConfigId : 0;
			int selectId2 = (flag2 && jumpType == EDangoBrawlBuffType.DeBuff) ? selectedConfigId : 0;
			IEnumerable<DangoBrawlBattleBuffDetailItemData> first = dangoBrawlBattleBuffListItem.BuildBuffDetailDataList(selectId);
			List<DangoBrawlBattleBuffDetailItemData> second = dangoBrawlBattleBuffListItem2.BuildBuffDetailDataList(selectId2);
			List<DangoBrawlBattleBuffDetailItemData> buffDetailDataList = (from data in first.Concat(second)
			orderby data.BaseData.SortIndex
			select data).ToList<DangoBrawlBattleBuffDetailItemData>();
			ValueTuple<string, string> valueTuple = this.BuildRoleSideInfo(flag);
			return new DangoBrawlBuffSideDetailData
			{
				RoleNameKey = valueTuple.Item1,
				RoleIcon = valueTuple.Item2,
				BuffDetailDataList = buffDetailDataList
			};
		}

		// Token: 0x0603A6BA RID: 239290 RVA: 0x00DE63CC File Offset: 0x00DE45CC
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

		// Token: 0x0603A6BB RID: 239291 RVA: 0x00DE6498 File Offset: 0x00DE4698
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

		// Token: 0x0603A6BC RID: 239292 RVA: 0x00DE6518 File Offset: 0x00DE4718
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

		// Token: 0x0603A6BD RID: 239293 RVA: 0x00DE6593 File Offset: 0x00DE4793
		private void OnClickedBuffDetail1()
		{
		}

		// Token: 0x0603A6BE RID: 239294 RVA: 0x00DE6595 File Offset: 0x00DE4795
		private void OnClickedBuffDetail2()
		{
		}

		// Token: 0x0603A6BF RID: 239295 RVA: 0x00DE6597 File Offset: 0x00DE4797
		private void OnClickedSpecItemL()
		{
		}

		// Token: 0x0603A6C0 RID: 239296 RVA: 0x00DE6599 File Offset: 0x00DE4799
		private void OnClickedBuffDetail3()
		{
		}

		// Token: 0x0603A6C1 RID: 239297 RVA: 0x00DE659B File Offset: 0x00DE479B
		private void OnClickedBuffDetail4()
		{
		}

		// Token: 0x0603A6C2 RID: 239298 RVA: 0x00DE659D File Offset: 0x00DE479D
		private void OnClickedSpecItemR()
		{
		}

		// Token: 0x0603A6C3 RID: 239299 RVA: 0x00DE659F File Offset: 0x00DE479F
		private void OnTogglePause(EToggleState state)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPause(state == EToggleState.ETT_Checked);
		}

		// Token: 0x0603A6C4 RID: 239300 RVA: 0x00DE65BC File Offset: 0x00DE47BC
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

		// Token: 0x0603A6C5 RID: 239301 RVA: 0x00DE660C File Offset: 0x00DE480C
		private void OnToggleDetail(EToggleState state)
		{
			DangoBrawlBattleLogPanel battleLogPanel = this.BattleLogPanel;
			if (battleLogPanel == null)
			{
				return;
			}
			battleLogPanel.SetActiveByToggle(state == EToggleState.ETT_Checked);
		}

		// Token: 0x0603A6C6 RID: 239302 RVA: 0x00DE6622 File Offset: 0x00DE4822
		private void OnClickedCloseMask()
		{
			this.HideAllTips();
		}

		// Token: 0x0603A6C7 RID: 239303 RVA: 0x00DE662A File Offset: 0x00DE482A
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

		// Token: 0x0603A6C8 RID: 239304 RVA: 0x00DE6645 File Offset: 0x00DE4845
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

		// Token: 0x0603A6C9 RID: 239305 RVA: 0x00DE6660 File Offset: 0x00DE4860
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

		// Token: 0x0603A6CA RID: 239306 RVA: 0x00DE66E4 File Offset: 0x00DE48E4
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

		// Token: 0x0603A6CB RID: 239307 RVA: 0x00DE6735 File Offset: 0x00DE4935
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

		// Token: 0x0603A6CC RID: 239308 RVA: 0x00DE6760 File Offset: 0x00DE4960
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

		// Token: 0x0603A6CD RID: 239309 RVA: 0x00DE67BE File Offset: 0x00DE49BE
		private void OnDangoBrawlBattleLogChanged(bool isSelf, bool isHeal)
		{
			DangoBrawlBattleLogPanel battleLogPanel = this.BattleLogPanel;
			if (battleLogPanel == null)
			{
				return;
			}
			battleLogPanel.RefreshOnEmit(isSelf, isHeal);
		}

		// Token: 0x0603A6CE RID: 239310 RVA: 0x00DE67D4 File Offset: 0x00DE49D4
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

		// Token: 0x0603A6CF RID: 239311 RVA: 0x00DE6818 File Offset: 0x00DE4A18
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

		// Token: 0x0603A6D0 RID: 239312 RVA: 0x00DE68C1 File Offset: 0x00DE4AC1
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

		// Token: 0x0603A6D1 RID: 239313 RVA: 0x00DE68D8 File Offset: 0x00DE4AD8
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

		// Token: 0x0603A6D2 RID: 239314 RVA: 0x00DE69EC File Offset: 0x00DE4BEC
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

		// Token: 0x0603A6D3 RID: 239315 RVA: 0x00DE6A88 File Offset: 0x00DE4C88
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

		// Token: 0x0603A6D4 RID: 239316 RVA: 0x00DE6AF4 File Offset: 0x00DE4CF4
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

		// Token: 0x0603A6D5 RID: 239317 RVA: 0x00DE6B61 File Offset: 0x00DE4D61
		private void OnSelfOpenBuffDetailView(EDangoBrawlBuffType type, int id)
		{
			this.OpenBuffDetailView(EDangoBrawlBuffDetailSide.Self, type, id);
		}

		// Token: 0x0603A6D6 RID: 239318 RVA: 0x00DE6B6C File Offset: 0x00DE4D6C
		private void OnOpponentOpenBuffDetailView(EDangoBrawlBuffType type, int id)
		{
			this.OpenBuffDetailView(EDangoBrawlBuffDetailSide.Opponent, type, id);
		}

		// Token: 0x0603A6D7 RID: 239319 RVA: 0x00DE6B78 File Offset: 0x00DE4D78
		public UUIItem GetTogDetailItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(17);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.RootUIComp.Get();
		}

		// Token: 0x0603A6D8 RID: 239320 RVA: 0x00DE6BA0 File Offset: 0x00DE4DA0
		private void OnRoundSettleUiStateChanged(bool show)
		{
			if (!show)
			{
				this.RefreshRoundSettleHideFlags();
			}
			this.SetRoundSettleHideButtonsVisible(!show);
		}

		// Token: 0x0603A6D9 RID: 239321 RVA: 0x00DE6BB5 File Offset: 0x00DE4DB5
		private void OnRoundSettleClosed()
		{
			this.SetRoundSettleHideButtonsVisible(false);
		}

		// Token: 0x0603A6DA RID: 239322 RVA: 0x00DE6BC0 File Offset: 0x00DE4DC0
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

		// Token: 0x0603A6DB RID: 239323 RVA: 0x00DE6C48 File Offset: 0x00DE4E48
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

		// Token: 0x0603A6DC RID: 239324 RVA: 0x00DE6C90 File Offset: 0x00DE4E90
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

		// Token: 0x0603A6DD RID: 239325 RVA: 0x00DE6E03 File Offset: 0x00DE5003
		private void OnClickedRoundSettleRecover()
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlRoundSettleRecover);
		}

		// Token: 0x0603A6DE RID: 239326 RVA: 0x00DE6E15 File Offset: 0x00DE5015
		private void OnClickedRoundSettleNextRound()
		{
			if (this.CanEnterAdditionalRound)
			{
				this.ShowConfirmBoxToAdditionalRound();
				return;
			}
			this.RequestFightOverFromHide(false, false).Forget();
		}

		// Token: 0x0603A6DF RID: 239327 RVA: 0x00DE6E33 File Offset: 0x00DE5033
		private void OnClickedRoundSettleLeave()
		{
			if (this.CanEnterAdditionalRound || this.IsLastRoundWin)
			{
				this.RequestFightOverFromHide(false, false).Forget();
				return;
			}
			this.ShowConfirmBoxToFinalSettle();
		}

		// Token: 0x0603A6E0 RID: 239328 RVA: 0x00DE6E5C File Offset: 0x00DE505C
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

		// Token: 0x0603A6E1 RID: 239329 RVA: 0x00DE6EA0 File Offset: 0x00DE50A0
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

		// Token: 0x0603A6E2 RID: 239330 RVA: 0x00DE6EE4 File Offset: 0x00DE50E4
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

		// Token: 0x0603A6E3 RID: 239331 RVA: 0x00DE6F38 File Offset: 0x00DE5138
		private static void CloseRoundSettleView()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			bool valueOrDefault = ((battleManager != null) ? battleManager.IsWin : null).GetValueOrDefault();
			UiManager.Instance.CloseView(valueOrDefault ? EUiViewName.DangoBrawlRoundSuccessSettleView : EUiViewName.DangoBrawlRoundFailureSettleView, null);
		}

		// Token: 0x0401E71D RID: 124701
		private const int TICK_INTERVAL = 20;

		// Token: 0x0401E71E RID: 124702
		private const int BACKPACK_GRID_SIZE = 88;

		// Token: 0x0401E71F RID: 124703
		private DangoBrawlHpBarItem SelfHpBar;

		// Token: 0x0401E720 RID: 124704
		private DangoBrawlHpBarItem OpponentHpBar;

		// Token: 0x0401E721 RID: 124705
		private DangoBrawlPlayRateButton SpeedButton;

		// Token: 0x0401E722 RID: 124706
		private DangoBrawlBattleLogPanel BattleLogPanel;

		// Token: 0x0401E723 RID: 124707
		private DangoBrawlBattleBackpackPanel BackpackSelf;

		// Token: 0x0401E724 RID: 124708
		private DangoBrawlBattleBackpackPanel BackpackOpponent;

		// Token: 0x0401E725 RID: 124709
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401E726 RID: 124710
		private ButtonItem NextRoundInHideButton;

		// Token: 0x0401E727 RID: 124711
		private ButtonItem LeaveInHideButton;

		// Token: 0x0401E728 RID: 124712
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E729 RID: 124713
		private DangoBrawlBattleBuffListItem SelfBuffListItem;

		// Token: 0x0401E72A RID: 124714
		private DangoBrawlBattleBuffListItem SelfDeBuffListItem;

		// Token: 0x0401E72B RID: 124715
		private DangoBrawlBattleBuffListItem OpponentBuffListItem;

		// Token: 0x0401E72C RID: 124716
		private DangoBrawlBattleBuffListItem OpponentDeBuffListItem;

		// Token: 0x0401E72D RID: 124717
		private DangoBrawlEventInfoPanel SelfEventInfoPanel;

		// Token: 0x0401E72E RID: 124718
		private TimerHandle FightingTickHandle;

		// Token: 0x0401E72F RID: 124719
		private bool IsBackpackLoading;

		// Token: 0x0401E730 RID: 124720
		private Dictionary<int, int> PendingItemCdUpdate;

		// Token: 0x0401E731 RID: 124721
		private bool HasClosedBuffDetailOnFightOver;

		// Token: 0x0401E732 RID: 124722
		private bool CanEnterAdditionalRound;

		// Token: 0x0401E733 RID: 124723
		private bool IsAddRoundSettle;

		// Token: 0x0401E734 RID: 124724
		private bool IsLastRoundWin;

		// Token: 0x0401E735 RID: 124725
		private bool IsLastRound;

		// Token: 0x0200BC5C RID: 48220
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04038D3B RID: 232763
			BtnClose,
			// Token: 0x04038D3C RID: 232764
			TxtRoundNum,
			// Token: 0x04038D3D RID: 232765
			TxtTime,
			// Token: 0x04038D3E RID: 232766
			PanelBackpackBrawlHp,
			// Token: 0x04038D3F RID: 232767
			BtnBuffDetail1,
			// Token: 0x04038D40 RID: 232768
			BtnBuffDetail2,
			// Token: 0x04038D41 RID: 232769
			EventInfoPanelL,
			// Token: 0x04038D42 RID: 232770
			PanelOffsetL,
			// Token: 0x04038D43 RID: 232771
			TxtWeightNumSelf,
			// Token: 0x04038D44 RID: 232772
			PanelBackpackBrawlHp2,
			// Token: 0x04038D45 RID: 232773
			BtnBuffDetail3,
			// Token: 0x04038D46 RID: 232774
			BtnBuffDetail4,
			// Token: 0x04038D47 RID: 232775
			EventInfoPanelR,
			// Token: 0x04038D48 RID: 232776
			PanelOffsetR,
			// Token: 0x04038D49 RID: 232777
			TxtWeightNumOpponent,
			// Token: 0x04038D4A RID: 232778
			TogPause,
			// Token: 0x04038D4B RID: 232779
			BtnSpeed,
			// Token: 0x04038D4C RID: 232780
			TogDetail,
			// Token: 0x04038D4D RID: 232781
			PanelInfo,
			// Token: 0x04038D4E RID: 232782
			PanelTiredTips,
			// Token: 0x04038D4F RID: 232783
			BtnCloseMask,
			// Token: 0x04038D50 RID: 232784
			BackpackBrawlTips,
			// Token: 0x04038D51 RID: 232785
			BtnRecoverByRoundSettle,
			// Token: 0x04038D52 RID: 232786
			BtnNextRoundInHideByRoundSettle,
			// Token: 0x04038D53 RID: 232787
			BtnLeaveInHideByRoundSettle
		}
	}
}
