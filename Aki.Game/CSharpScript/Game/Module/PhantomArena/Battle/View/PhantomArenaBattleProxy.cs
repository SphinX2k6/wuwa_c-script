using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.PhantomArena.Battle.Area;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand;
using CSharpScript.Game.Module.PhantomArena.Battle.Canvas;
using CSharpScript.Game.Module.PhantomArena.Battle.Dialog;
using CSharpScript.Game.Module.PhantomArena.Battle.Gamepad;
using CSharpScript.Game.Module.PhantomArena.Battle.Guide;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.Opponent;
using CSharpScript.Game.Module.PhantomArena.Battle.Process;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using CSharpScript.Game.Module.PhantomArena.Battle.View.BuffEffect;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Choose;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Discard;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Field;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02005245 RID: 21061
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleProxy
	{
		// Token: 0x06035CC5 RID: 220357 RVA: 0x00CBAA74 File Offset: 0x00CB8C74
		public PhantomArenaBattleProxy()
		{
			this.ProcessManager = new PhantomArenaProcessManager(this);
			this.BuffEffectManager = new PhantomArenaBuffEffectManager(this);
			this.GuideManager = new PhantomArenaBattleGuideManager(this);
			this.RoundOverCheck = new PhantomArenaRoundOverCheck(this);
			this.GamepadLogic = new PhantomArenaBattleViewGamepadLogic(this);
			this.ServerActionQueue = new PhantomArenaBattleServerActionQueue(this);
		}

		// Token: 0x06035CC6 RID: 220358 RVA: 0x00CBAB02 File Offset: 0x00CB8D02
		public void RegisterView(PhantomArenaBattleView view)
		{
			this.View = view;
		}

		// Token: 0x06035CC7 RID: 220359 RVA: 0x00CBAB0C File Offset: 0x00CB8D0C
		public void RefreshByWorldDone()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "世界加载完成,刷新界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			PhantomArenaBattleController.RequestPhantomBattleStart();
			this.Show(true);
		}

		// Token: 0x06035CC8 RID: 220360 RVA: 0x00CBAB44 File Offset: 0x00CB8D44
		public void Show(bool isFromWorldDone)
		{
			this.View.SetTimeEndBtnInteractive(false);
			this.View.RefreshOwnCardLibraryNum();
			this.View.RefreshOpponentCardLibraryNum();
			this.View.RefreshRoundNum();
			this.View.RefreshLimitText();
			this.OwnArea.RefreshAll(isFromWorldDone);
			this.OpponentArea.RefreshAll(isFromWorldDone);
			this.CardRecycle.RefreshCostNum();
		}

		// Token: 0x06035CC9 RID: 220361 RVA: 0x00CBABAC File Offset: 0x00CB8DAC
		public void Destroy()
		{
			this.ProcessManager.Clear();
			this.CanvasManager.ClearAreaCanvas();
			this.OpponentArea.Clear();
			this.DialogManager.Clear();
			PhantomArenaBattleModel.Instance.ClearWaitBattleData();
		}

		// Token: 0x06035CCA RID: 220362 RVA: 0x00CBABE4 File Offset: 0x00CB8DE4
		public UUIItem GetDragRootItem()
		{
			return this.View.GetDragRootItem();
		}

		// Token: 0x06035CCB RID: 220363 RVA: 0x00CBABF1 File Offset: 0x00CB8DF1
		public UUIItem GetOpponentCardLibraryItem()
		{
			return this.View.GetOpponentCardLibraryItem();
		}

		// Token: 0x06035CCC RID: 220364 RVA: 0x00CBABFE File Offset: 0x00CB8DFE
		public UUIItem GetSkillTriggerAttachItem()
		{
			return this.View.GetSkillTriggerAttachItem();
		}

		// Token: 0x06035CCD RID: 220365 RVA: 0x00CBAC0C File Offset: 0x00CB8E0C
		public UniTask PlayShowFieldEffect()
		{
			PhantomArenaBattleProxy.<PlayShowFieldEffect>d__33 <PlayShowFieldEffect>d__;
			<PlayShowFieldEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowFieldEffect>d__.<>4__this = this;
			<PlayShowFieldEffect>d__.<>1__state = -1;
			<PlayShowFieldEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<PlayShowFieldEffect>d__33>(ref <PlayShowFieldEffect>d__);
			return <PlayShowFieldEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035CCE RID: 220366 RVA: 0x00CBAC4F File Offset: 0x00CB8E4F
		public void ShowLine()
		{
		}

		// Token: 0x06035CCF RID: 220367 RVA: 0x00CBAC51 File Offset: 0x00CB8E51
		public void HideLine()
		{
		}

		// Token: 0x06035CD0 RID: 220368 RVA: 0x00CBAC53 File Offset: 0x00CB8E53
		public void SetCaptionItemActive(bool bActive)
		{
			this.View.SetCaptionItemActive(bActive);
		}

		// Token: 0x06035CD1 RID: 220369 RVA: 0x00CBAC61 File Offset: 0x00CB8E61
		public void ShowAddBuffEffect(EBuffShowType buffShowType, List<int> fightIdList)
		{
			this.OwnArea.FunctionalArea.ShowAddBuffEffect(buffShowType, fightIdList);
			this.OpponentArea.FunctionalArea.ShowAddBuffEffect(buffShowType, fightIdList);
		}

		// Token: 0x06035CD2 RID: 220370 RVA: 0x00CBAC88 File Offset: 0x00CB8E88
		public unsafe void RegisterCantDragReason(EPhantomArenaCantDragReason reason)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加不可拖动状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("状态", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("状态集合", this.InCantDragStateSet);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.InCantDragStateSet.Add(reason);
		}

		// Token: 0x06035CD3 RID: 220371 RVA: 0x00CBAD04 File Offset: 0x00CB8F04
		public unsafe void UnRegisterCantDragReason(EPhantomArenaCantDragReason reason)
		{
			this.InCantDragStateSet.Remove(reason);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "删除不可拖动状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("状态", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("状态集合", this.InCantDragStateSet);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06035CD4 RID: 220372 RVA: 0x00CBAD7E File Offset: 0x00CB8F7E
		public bool InCantDragState()
		{
			return this.InCantDragStateSet.Count > 0;
		}

		// Token: 0x06035CD5 RID: 220373 RVA: 0x00CBAD8E File Offset: 0x00CB8F8E
		public void SetSelectedCardId(int cardId, EPhantomArenaCardClickFromType fromType)
		{
			if (this.SelectedCardId == cardId && this.SelectedFrom == fromType)
			{
				return;
			}
			if (this.SelectedCardId != -1)
			{
				this.SetSelectedCardState(false);
			}
			this.SelectedCardId = cardId;
			this.SelectedFrom = fromType;
			this.SetSelectedCardState(true);
		}

		// Token: 0x06035CD6 RID: 220374 RVA: 0x00CBADC8 File Offset: 0x00CB8FC8
		public void CancelSelectedCard()
		{
			if (this.SelectedCardId != -1)
			{
				this.SetSelectedCardState(false);
			}
			this.SelectedCardId = -1;
			this.SelectedFrom = EPhantomArenaCardClickFromType.None;
		}

		// Token: 0x06035CD7 RID: 220375 RVA: 0x00CBADE8 File Offset: 0x00CB8FE8
		private void SetSelectedCardState(bool value)
		{
			if (this.SelectedFrom == EPhantomArenaCardClickFromType.OwnHand)
			{
				PhantomArenaHandCardProxy cardProxy = this.OwnArea.HandArea.GetCardProxy(this.SelectedCardId);
				if (cardProxy != null)
				{
					cardProxy.SetCardSelectedState(value);
				}
				return;
			}
			if (this.SelectedFrom == EPhantomArenaCardClickFromType.OwnFunctional)
			{
				PhantomArenaAreaProxyBase cardProxyByCardId = this.OwnArea.FunctionalArea.GetCardProxyByCardId(this.SelectedCardId);
				if (cardProxyByCardId != null)
				{
					cardProxyByCardId.SetCardSelectedState(value);
				}
				return;
			}
			if (this.SelectedFrom == EPhantomArenaCardClickFromType.OpponentFunctional)
			{
				OpponentFunctionAreaProxy cardProxyByCardId2 = this.OpponentArea.FunctionalArea.GetCardProxyByCardId(this.SelectedCardId);
				if (cardProxyByCardId2 != null)
				{
					cardProxyByCardId2.SetCardSelectedState(value);
				}
			}
		}

		// Token: 0x06035CD8 RID: 220376 RVA: 0x00CBAE78 File Offset: 0x00CB9078
		public void PlayRoundOverEffect()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "播放回合结束扫光效果", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.View.SetRoundEffectActive(true);
		}

		// Token: 0x06035CD9 RID: 220377 RVA: 0x00CBAEB0 File Offset: 0x00CB90B0
		public void HideRoundOverEffect()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "隐藏回合结束扫光效果", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.View.SetRoundEffectActive(false);
		}

		// Token: 0x06035CDA RID: 220378 RVA: 0x00CBAEE8 File Offset: 0x00CB90E8
		public bool CheckRepeatCondition()
		{
			PhantomArenaOwnData ownData = PhantomArenaBattleModel.Instance.OwnData;
			return (ownData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint) != 0 || ownData.HasFourCostInHand()) && ownData.GetHandCardIdList().Count != 0;
		}

		// Token: 0x06035CDB RID: 220379 RVA: 0x00CBAF23 File Offset: 0x00CB9123
		public UUIItem GetOwnCardLibraryItem()
		{
			return this.View.GetOwnCardLibraryItem();
		}

		// Token: 0x06035CDC RID: 220380 RVA: 0x00CBAF30 File Offset: 0x00CB9130
		public void ShowTimeStart()
		{
			this.UnRegisterCantDragReason(EPhantomArenaCantDragReason.EndTime);
			this.ServerActionQueue.PauseAction();
			this.RegisterCantDragReason(EPhantomArenaCantDragReason.NotInOwnTime);
			int round = PhantomArenaBattleModel.Instance.Round;
			int replaceNum = PhantomArenaBattleModel.Instance.ReplaceCardData.ReplaceNum;
			if (round == 1 && replaceNum != 0)
			{
				this.ProcessManager.SetState(EPlayingCardProcessState.OwnChangeCard);
				return;
			}
			this.ProcessManager.SetState(EPlayingCardProcessState.BothDrawCard);
		}

		// Token: 0x06035CDD RID: 220381 RVA: 0x00CBAF8F File Offset: 0x00CB918F
		public void ShowOwnChangeCard()
		{
			PhantomArenaBattleController.OpenPhantomArenaChangeCardView();
		}

		// Token: 0x06035CDE RID: 220382 RVA: 0x00CBAF98 File Offset: 0x00CB9198
		public UniTask ShowBothDrawCard()
		{
			PhantomArenaBattleProxy.<ShowBothDrawCard>d__50 <ShowBothDrawCard>d__;
			<ShowBothDrawCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowBothDrawCard>d__.<>4__this = this;
			<ShowBothDrawCard>d__.<>1__state = -1;
			<ShowBothDrawCard>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowBothDrawCard>d__50>(ref <ShowBothDrawCard>d__);
			return <ShowBothDrawCard>d__.<>t__builder.Task;
		}

		// Token: 0x06035CDF RID: 220383 RVA: 0x00CBAFDB File Offset: 0x00CB91DB
		public void ShowOpponentStartPanel()
		{
			PhantomArenaBattleController.OpenPhantomArenaStartView(new PhantomArenaStartViewData
			{
				ContentTextId = "PhantomBattle_1044",
				IsOwn = false,
				Callback = delegate
				{
					this.ProcessManager.SetState(EPlayingCardProcessState.OpponentPlaying);
				}
			});
		}

		// Token: 0x06035CE0 RID: 220384 RVA: 0x00CBB00C File Offset: 0x00CB920C
		public UniTask StartAiOperation()
		{
			PhantomArenaBattleProxy.<StartAiOperation>d__52 <StartAiOperation>d__;
			<StartAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartAiOperation>d__.<>4__this = this;
			<StartAiOperation>d__.<>1__state = -1;
			<StartAiOperation>d__.<>t__builder.Start<PhantomArenaBattleProxy.<StartAiOperation>d__52>(ref <StartAiOperation>d__);
			return <StartAiOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06035CE1 RID: 220385 RVA: 0x00CBB04F File Offset: 0x00CB924F
		public void ShowGameOver()
		{
			PhantomArenaBattleController.TriggerPhantomBattleBoardSettle();
			this.ServerActionQueue.ResumeAction().Forget();
		}

		// Token: 0x06035CE2 RID: 220386 RVA: 0x00CBB066 File Offset: 0x00CB9266
		public void ShowOwnStartPanel()
		{
			PhantomArenaBattleController.OpenPhantomArenaStartView(new PhantomArenaStartViewData
			{
				ContentTextId = "PhantomBattle_1045",
				IsOwn = true,
				Callback = delegate
				{
					this.ProcessManager.SetState(EPlayingCardProcessState.ShowOwnCoreCard);
				}
			});
		}

		// Token: 0x06035CE3 RID: 220387 RVA: 0x00CBB098 File Offset: 0x00CB9298
		public void ShowOwnCoreCard()
		{
			int round = PhantomArenaBattleModel.Instance.Round;
			PhantomArenaOwnData ownData = PhantomArenaBattleModel.Instance.OwnData;
			if (round == 1 && ownData.TaskData != null)
			{
				PhantomArenaBattleController.OpenPhantomArenaCoreCardView(delegate
				{
					this.OwnArea.RolePanel.ActiveIsFourCostShowInFirstTime();
					this.ProcessManager.SetState(EPlayingCardProcessState.OwnPlaying);
				});
				return;
			}
			if (ownData.CanShowFourCostView)
			{
				PhantomArenaBattleController.OpenPhantomArenaCoreCardView(delegate
				{
					ownData.CanShowFourCostView = false;
					this.OwnArea.HandArea.AddCard(new List<int>
					{
						ownData.CoreCardId
					}).Forget();
					this.ProcessManager.SetState(EPlayingCardProcessState.OwnPlaying);
				});
				return;
			}
			this.ProcessManager.SetState(EPlayingCardProcessState.OwnPlaying);
		}

		// Token: 0x06035CE4 RID: 220388 RVA: 0x00CBB11A File Offset: 0x00CB931A
		public void ShowOwnPlaying()
		{
			this.ServerActionQueue.ResumeAction().Forget();
			this.RoundOverCheck.StartCheck();
			this.View.SetTimeEndBtnInteractive(true);
			this.UnRegisterCantDragReason(EPhantomArenaCantDragReason.NotInOwnTime);
		}

		// Token: 0x06035CE5 RID: 220389 RVA: 0x00CBB14C File Offset: 0x00CB934C
		public UniTask RoundOver()
		{
			PhantomArenaBattleProxy.<RoundOver>d__57 <RoundOver>d__;
			<RoundOver>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoundOver>d__.<>4__this = this;
			<RoundOver>d__.<>1__state = -1;
			<RoundOver>d__.<>t__builder.Start<PhantomArenaBattleProxy.<RoundOver>d__57>(ref <RoundOver>d__);
			return <RoundOver>d__.<>t__builder.Task;
		}

		// Token: 0x06035CE6 RID: 220390 RVA: 0x00CBB18F File Offset: 0x00CB938F
		public void JumpLoading()
		{
			PhantomArenaBattleController.OpenPhantomArenaBattleLoading();
		}

		// Token: 0x06035CE7 RID: 220391 RVA: 0x00CBB196 File Offset: 0x00CB9396
		public void HideLayoutClick()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
			this.OwnArea.HideCardList();
		}

		// Token: 0x06035CE8 RID: 220392 RVA: 0x00CBB1AA File Offset: 0x00CB93AA
		public void CloseClick()
		{
			if (this.InCantDragStateSet.Contains(EPhantomArenaCantDragReason.EndTime))
			{
				return;
			}
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(delegate
			{
				this.GuideManager.TryExitCurrentGuide();
				PhantomArenaBattleModel.Instance.OnClickExitButtonConfirm();
			}, null, true);
		}

		// Token: 0x06035CE9 RID: 220393 RVA: 0x00CBB1D3 File Offset: 0x00CB93D3
		public void HelpClick()
		{
			if (this.InCantDragStateSet.Contains(EPhantomArenaCantDragReason.EndTime))
			{
				return;
			}
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				TutorialController.Instance.OpenExclusiveTutorial(EExclusiveTutorialType.PhantomArena);
				return;
			}
			TutorialController.Instance.OpenExclusiveTutorial(EExclusiveTutorialType.PhantomArenaNew);
		}

		// Token: 0x06035CEA RID: 220394 RVA: 0x00CBB20C File Offset: 0x00CB940C
		public void TimeEndClick()
		{
			if (this.InCantDragState())
			{
				return;
			}
			if (!this.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbEndTurn, Array.Empty<object>()))
			{
				return;
			}
			if (this.ServerActionQueue.InAction())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1189", Array.Empty<object>());
				return;
			}
			Action action = delegate()
			{
				this.GuideManager.FinishCurrentGuide();
				this.ProcessManager.SetState(EPlayingCardProcessState.TimeEnd);
			};
			if (!this.RoundOverCheck.HasAnyOperation && PhantomArenaBattleModel.Instance.IsNeedShowTimeEndConfirm)
			{
				PhantomArenaBattleController.Instance.ShowTimeEndConfirm(action);
				return;
			}
			action();
		}

		// Token: 0x06035CEB RID: 220395 RVA: 0x00CBB290 File Offset: 0x00CB9490
		public void OnOwnBattleStatusChange(IReadOnlyList<PhantomBattleRoleStatus> statusList)
		{
			foreach (PhantomBattleRoleStatus phantomBattleRoleStatus in statusList)
			{
				if (phantomBattleRoleStatus == PhantomBattleRoleStatus.PhantomBattleLife || phantomBattleRoleStatus == PhantomBattleRoleStatus.PhantomBattleMaxLife)
				{
					this.OwnArea.RolePanel.RefreshLifeNumWithEffect();
				}
				else if (phantomBattleRoleStatus == PhantomBattleRoleStatus.PhantomBattleCostPoint)
				{
					this.RoundOverCheck.RepeatCheck();
					this.CardRecycle.RefreshCostNum();
					this.OwnArea.HandArea.RefreshHandCardSequence();
					this.OwnArea.RolePanel.RefreshSkillEffect();
				}
			}
		}

		// Token: 0x06035CEC RID: 220396 RVA: 0x00CBB324 File Offset: 0x00CB9524
		public void OnOpponentBattleStatusChange(IReadOnlyList<PhantomBattleRoleStatus> statusList)
		{
			foreach (PhantomBattleRoleStatus phantomBattleRoleStatus in statusList)
			{
				if (phantomBattleRoleStatus == PhantomBattleRoleStatus.PhantomBattleLife || phantomBattleRoleStatus == PhantomBattleRoleStatus.PhantomBattleMaxLife)
				{
					this.OpponentArea.RefreshLifeNumWithEffect();
				}
			}
		}

		// Token: 0x06035CED RID: 220397 RVA: 0x00CBB378 File Offset: 0x00CB9578
		public void OnOwnCardLibraryChange()
		{
			this.View.RefreshOwnCardLibraryNum();
		}

		// Token: 0x06035CEE RID: 220398 RVA: 0x00CBB388 File Offset: 0x00CB9588
		public void OnOpponentHandCardChange()
		{
			int handCardNum = PhantomArenaBattleModel.Instance.OpponentData.HandCardNum;
			this.OpponentArea.HandArea.RefreshHandCardNum(handCardNum).Forget();
		}

		// Token: 0x06035CEF RID: 220399 RVA: 0x00CBB3BB File Offset: 0x00CB95BB
		public void OnOpponentCardLibraryChange()
		{
			this.View.RefreshOpponentCardLibraryNum();
		}

		// Token: 0x06035CF0 RID: 220400 RVA: 0x00CBB3C8 File Offset: 0x00CB95C8
		public void OnOwnHandCardAdd(IReadOnlyList<int> addCardList)
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "刷新手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OwnArea.HandArea.AddCard(addCardList.ToList<int>()).Forget();
		}

		// Token: 0x06035CF1 RID: 220401 RVA: 0x00CBB40F File Offset: 0x00CB960F
		public void OnTriggerSkillEffect()
		{
			this.ServerActionQueue.PushSkillEffectAction();
		}

		// Token: 0x06035CF2 RID: 220402 RVA: 0x00CBB41C File Offset: 0x00CB961C
		public void OnNotifyCardTaskData(bool isOwn)
		{
			if (isOwn)
			{
				this.OwnArea.RolePanel.RefreshTask();
				return;
			}
			this.OpponentArea.RolePanel.RefreshTask();
		}

		// Token: 0x06035CF3 RID: 220403 RVA: 0x00CBB442 File Offset: 0x00CB9642
		public void OnOwnHandCardRemove(IReadOnlyList<int> discardIdList)
		{
			this.OwnArea.HandArea.DiscardCard(this.View.GetOwnCardLibraryItem(), discardIdList.ToList<int>()).Forget();
		}

		// Token: 0x06035CF4 RID: 220404 RVA: 0x00CBB46C File Offset: 0x00CB966C
		public void OnCardAttrRefresh(int cardId)
		{
			if (this.TipsItem.IsInActive && this.TipsItem.GetCardId() == cardId)
			{
				this.TipsItem.RefreshContent();
			}
			this.OpponentArea.FunctionalArea.RefreshBattleCard(cardId);
			this.OwnArea.FunctionalArea.RefreshBattleCard(cardId);
			PhantomArenaFieldData fieldData = PhantomArenaBattleModel.Instance.OwnData.FieldData;
			int? num;
			if (fieldData == null)
			{
				num = null;
			}
			else
			{
				PhantomCardData cardData = fieldData.CardData;
				num = ((cardData != null) ? new int?(cardData.CardId) : null);
			}
			int? num2 = num;
			if (cardId == num2.GetValueOrDefault() & num2 != null)
			{
				this.OwnArea.RefreshFiledArea().Forget();
				return;
			}
			PhantomArenaFieldData fieldData2 = PhantomArenaBattleModel.Instance.OpponentData.FieldData;
			int? num3;
			if (fieldData2 == null)
			{
				num3 = null;
			}
			else
			{
				PhantomCardData cardData2 = fieldData2.CardData;
				num3 = ((cardData2 != null) ? new int?(cardData2.CardId) : null);
			}
			num2 = num3;
			if (cardId == num2.GetValueOrDefault() & num2 != null)
			{
				this.OpponentArea.RefreshFiledArea().Forget();
			}
		}

		// Token: 0x06035CF5 RID: 220405 RVA: 0x00CBB584 File Offset: 0x00CB9784
		public void OnCardFactorsRefresh(int cardId)
		{
			if (this.TipsItem.IsInActive && this.TipsItem.GetCardId() == cardId)
			{
				this.TipsItem.RefreshContent();
			}
			this.OpponentArea.FunctionalArea.RefreshBattleCard(cardId);
			this.OwnArea.FunctionalArea.RefreshBattleCard(cardId);
		}

		// Token: 0x06035CF6 RID: 220406 RVA: 0x00CBB5DC File Offset: 0x00CB97DC
		public void OnNotifyBattleCardChange(bool isOwn, int indexA, int indexB)
		{
			if (isOwn)
			{
				this.OwnArea.FunctionalArea.RefreshBattleCard(indexA);
				this.OwnArea.FunctionalArea.RefreshBattleCard(indexB);
				return;
			}
			this.OpponentArea.FunctionalArea.RefreshBattleCard(indexA);
			this.OpponentArea.FunctionalArea.RefreshBattleCard(indexB);
		}

		// Token: 0x06035CF7 RID: 220407 RVA: 0x00CBB631 File Offset: 0x00CB9831
		public void OnOwnBattleAttrChange(IReadOnlyList<PhantomBattleCardAttr> attrList)
		{
			if (attrList.Contains(PhantomBattleCardAttr.Defence))
			{
				this.OwnArea.RolePanel.RefreshShieldNum();
			}
		}

		// Token: 0x06035CF8 RID: 220408 RVA: 0x00CBB64C File Offset: 0x00CB984C
		public void OnOpponentBattleAttrChange(IReadOnlyList<PhantomBattleCardAttr> attrList)
		{
			if (attrList.Contains(PhantomBattleCardAttr.Defence))
			{
				this.OpponentArea.RolePanel.RefreshShieldNum();
			}
		}

		// Token: 0x06035CF9 RID: 220409 RVA: 0x00CBB667 File Offset: 0x00CB9867
		public void OnRefreshRound()
		{
			this.View.RefreshRoundNum();
		}

		// Token: 0x06035CFA RID: 220410 RVA: 0x00CBB674 File Offset: 0x00CB9874
		public void OnRefreshBattleCardNum()
		{
			this.View.RefreshLimitText();
		}

		// Token: 0x06035CFB RID: 220411 RVA: 0x00CBB684 File Offset: 0x00CB9884
		public void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (last == EInputControllerMainType.Gamepad)
			{
				this.GamepadLogic.ResetGamepadOperation();
			}
			bool isGamepad = now == EInputControllerMainType.Gamepad;
			this.OpponentArea.SwitchFieldState(isGamepad);
			this.OpponentArea.RolePanel.RefreshSkillState();
			this.OwnArea.SwitchFieldState(isGamepad);
		}

		// Token: 0x06035CFC RID: 220412 RVA: 0x00CBB6CD File Offset: 0x00CB98CD
		public void OnRefreshHandCardState()
		{
			this.OwnArea.HandArea.RefreshHandCardSequence();
		}

		// Token: 0x06035CFD RID: 220413 RVA: 0x00CBB6DF File Offset: 0x00CB98DF
		public void OnPhantomBattleBoardSettleNotify()
		{
			if (this.ProcessManager.IsNotInOwnPlaying)
			{
				return;
			}
			PhantomArenaBattleController.TriggerPhantomBattleBoardSettle();
		}

		// Token: 0x06035CFE RID: 220414 RVA: 0x00CBB6F4 File Offset: 0x00CB98F4
		public void OnOpponentSealFieldChange(int remainRound)
		{
			this.OpponentArea.RefreshFiledArea().Forget();
		}

		// Token: 0x06035CFF RID: 220415 RVA: 0x00CBB706 File Offset: 0x00CB9906
		public void OnOwnSealRecycleChange(int remainRound)
		{
		}

		// Token: 0x06035D00 RID: 220416 RVA: 0x00CBB708 File Offset: 0x00CB9908
		private void SetTipsActive(EPhantomArenaBattleShowTipsType showTipsType)
		{
			this.TipsItem.SetTipsActive(showTipsType == EPhantomArenaBattleShowTipsType.CardTips);
			this.DetailsTipsItem.SetTipsActive(showTipsType);
			this.SkillTipsItem.SetTipsActive(showTipsType == EPhantomArenaBattleShowTipsType.SkillTips);
		}

		// Token: 0x06035D01 RID: 220417 RVA: 0x00CBB734 File Offset: 0x00CB9934
		public void HideCardTips()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
			EventSystem.Instance.Emit<bool>(EEventName.OnPhantomArenaCardDetailShowHideChange, false);
		}

		// Token: 0x06035D02 RID: 220418 RVA: 0x00CBB74E File Offset: 0x00CB994E
		public void ShowCardTips(PhantomCardData cardData, bool isCardItemShow)
		{
			this.TipsItem.RefreshTips(cardData, isCardItemShow);
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.CardTips);
			EventSystem.Instance.Emit<bool>(EEventName.OnPhantomArenaCardDetailShowHideChange, true);
		}

		// Token: 0x06035D03 RID: 220419 RVA: 0x00CBB775 File Offset: 0x00CB9975
		public bool SwitchCardTips(PhantomCardData cardData)
		{
			if (this.TipsItem.IsInActive)
			{
				this.HideCardTips();
				return false;
			}
			this.ShowCardTips(cardData, true);
			return true;
		}

		// Token: 0x06035D04 RID: 220420 RVA: 0x00CBB798 File Offset: 0x00CB9998
		public void SwitchFourCostTips(bool isOwn, UUIItem triggerItem)
		{
			EPhantomArenaBattleDetailsTipsShowType ephantomArenaBattleDetailsTipsShowType = isOwn ? EPhantomArenaBattleDetailsTipsShowType.OwnFourCost : EPhantomArenaBattleDetailsTipsShowType.OpponentFourCost;
			if (this.DetailsTipsItem.IsInActive && ephantomArenaBattleDetailsTipsShowType == this.DetailsTipsItem.ShowType)
			{
				this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
				return;
			}
			EPhantomArenaBattleDetailsPositionType positionType = isOwn ? EPhantomArenaBattleDetailsPositionType.RightBottom : EPhantomArenaBattleDetailsPositionType.LeftTop;
			PhantomArenaBattleDetailsTipsData tipsPositionByTriggerItem = new PhantomArenaBattleDetailsTipsData
			{
				TriggerItem = triggerItem,
				PositionType = positionType,
				ShowType = ephantomArenaBattleDetailsTipsShowType
			};
			PhantomArenaCardTaskData taskData = isOwn ? PhantomArenaBattleModel.Instance.OwnData.TaskData : PhantomArenaBattleModel.Instance.OpponentData.TaskData;
			this.DetailsTipsItem.RefreshByTaskData(taskData);
			this.DetailsTipsItem.SetTipsPositionByTriggerItem(tipsPositionByTriggerItem);
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.DetailsTips);
		}

		// Token: 0x06035D05 RID: 220421 RVA: 0x00CBB836 File Offset: 0x00CB9A36
		public void ShowSkillTips(IPhantomArenaSkillData data, UUIItem attachItem)
		{
			this.SkillTipsItem.Refresh(data);
			this.SkillTipsItem.SetTipsPosition(attachItem, data.IsOwn);
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.SkillTips);
		}

		// Token: 0x06035D06 RID: 220422 RVA: 0x00CBB85D File Offset: 0x00CB9A5D
		public void HideSkillTips()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
		}

		// Token: 0x06035D07 RID: 220423 RVA: 0x00CBB868 File Offset: 0x00CB9A68
		public void ShowFiledTips(PhantomArenaFieldData fieldData, UUIItem triggerItem, bool isGamepad)
		{
			EPhantomArenaBattleDetailsTipsShowType ephantomArenaBattleDetailsTipsShowType = fieldData.IsOwn ? EPhantomArenaBattleDetailsTipsShowType.OwnField : EPhantomArenaBattleDetailsTipsShowType.OpponentField;
			if (this.DetailsTipsItem.IsInActive && ephantomArenaBattleDetailsTipsShowType == this.DetailsTipsItem.ShowType)
			{
				this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
				return;
			}
			EPhantomArenaBattleDetailsPositionType positionType;
			if (isGamepad)
			{
				positionType = (fieldData.IsOwn ? EPhantomArenaBattleDetailsPositionType.RightBottom : EPhantomArenaBattleDetailsPositionType.LeftTop);
			}
			else
			{
				positionType = (fieldData.IsOwn ? EPhantomArenaBattleDetailsPositionType.LeftBottom : EPhantomArenaBattleDetailsPositionType.RightTop);
			}
			PhantomArenaBattleDetailsTipsData tipsPositionByTriggerItem = new PhantomArenaBattleDetailsTipsData
			{
				TriggerItem = triggerItem,
				PositionType = positionType,
				ShowType = ephantomArenaBattleDetailsTipsShowType
			};
			this.DetailsTipsItem.RefreshByCardData(fieldData.CardData);
			this.DetailsTipsItem.SetTipsPositionByTriggerItem(tipsPositionByTriggerItem);
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.FieldDetailsTips);
		}

		// Token: 0x06035D08 RID: 220424 RVA: 0x00CBB903 File Offset: 0x00CB9B03
		public void HideFiledTips()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
		}

		// Token: 0x06035D09 RID: 220425 RVA: 0x00CBB90C File Offset: 0x00CB9B0C
		public UniTask StartTimeDrawCardTween()
		{
			PhantomArenaBattleProxy.<StartTimeDrawCardTween>d__93 <StartTimeDrawCardTween>d__;
			<StartTimeDrawCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartTimeDrawCardTween>d__.<>4__this = this;
			<StartTimeDrawCardTween>d__.<>1__state = -1;
			<StartTimeDrawCardTween>d__.<>t__builder.Start<PhantomArenaBattleProxy.<StartTimeDrawCardTween>d__93>(ref <StartTimeDrawCardTween>d__);
			return <StartTimeDrawCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x06035D0A RID: 220426 RVA: 0x00CBB950 File Offset: 0x00CB9B50
		public UniTask EndTimeDiscardCardTween()
		{
			PhantomArenaBattleProxy.<EndTimeDiscardCardTween>d__94 <EndTimeDiscardCardTween>d__;
			<EndTimeDiscardCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndTimeDiscardCardTween>d__.<>4__this = this;
			<EndTimeDiscardCardTween>d__.<>1__state = -1;
			<EndTimeDiscardCardTween>d__.<>t__builder.Start<PhantomArenaBattleProxy.<EndTimeDiscardCardTween>d__94>(ref <EndTimeDiscardCardTween>d__);
			return <EndTimeDiscardCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x17008255 RID: 33365
		// (get) Token: 0x06035D0B RID: 220427 RVA: 0x00CBB993 File Offset: 0x00CB9B93
		public bool IsInPanelInteract
		{
			get
			{
				return this.InPanelInteractType > EPhantomArenaBattlePanelInteractType.MainView;
			}
		}

		// Token: 0x06035D0C RID: 220428 RVA: 0x00CBB99E File Offset: 0x00CB9B9E
		public void SetInPanelInteractType(EPhantomArenaBattlePanelInteractType type)
		{
			this.InPanelInteractType = type;
			this.View.RefreshUiBlurBehaviour();
		}

		// Token: 0x06035D0D RID: 220429 RVA: 0x00CBB9B2 File Offset: 0x00CB9BB2
		public void SetIsMainInVisible(bool value)
		{
			this.IsMainInVisibleInternal = value;
			this.View.RefreshUiBlurBehaviour();
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirtyByGroupItem(this.View.GetRootItem());
		}

		// Token: 0x17008256 RID: 33366
		// (get) Token: 0x06035D0E RID: 220430 RVA: 0x00CBB9DB File Offset: 0x00CB9BDB
		public bool IsMainInVisible
		{
			get
			{
				return this.IsMainInVisibleInternal;
			}
		}

		// Token: 0x06035D0F RID: 220431 RVA: 0x00CBB9E4 File Offset: 0x00CB9BE4
		public UniTask ShowNpcFieldSealEffect()
		{
			PhantomArenaBattleProxy.<ShowNpcFieldSealEffect>d__101 <ShowNpcFieldSealEffect>d__;
			<ShowNpcFieldSealEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNpcFieldSealEffect>d__.<>4__this = this;
			<ShowNpcFieldSealEffect>d__.<>1__state = -1;
			<ShowNpcFieldSealEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowNpcFieldSealEffect>d__101>(ref <ShowNpcFieldSealEffect>d__);
			return <ShowNpcFieldSealEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035D10 RID: 220432 RVA: 0x00CBBA28 File Offset: 0x00CB9C28
		public UniTask ShowNpcFieldUnlockEffect()
		{
			PhantomArenaBattleProxy.<ShowNpcFieldUnlockEffect>d__102 <ShowNpcFieldUnlockEffect>d__;
			<ShowNpcFieldUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNpcFieldUnlockEffect>d__.<>4__this = this;
			<ShowNpcFieldUnlockEffect>d__.<>1__state = -1;
			<ShowNpcFieldUnlockEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowNpcFieldUnlockEffect>d__102>(ref <ShowNpcFieldUnlockEffect>d__);
			return <ShowNpcFieldUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035D11 RID: 220433 RVA: 0x00CBBA6C File Offset: 0x00CB9C6C
		public UniTask ShowOwnFieldSealEffect()
		{
			PhantomArenaBattleProxy.<ShowOwnFieldSealEffect>d__103 <ShowOwnFieldSealEffect>d__;
			<ShowOwnFieldSealEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowOwnFieldSealEffect>d__.<>4__this = this;
			<ShowOwnFieldSealEffect>d__.<>1__state = -1;
			<ShowOwnFieldSealEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowOwnFieldSealEffect>d__103>(ref <ShowOwnFieldSealEffect>d__);
			return <ShowOwnFieldSealEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035D12 RID: 220434 RVA: 0x00CBBAB0 File Offset: 0x00CB9CB0
		public UniTask ShowOwnFieldUnlockEffect()
		{
			PhantomArenaBattleProxy.<ShowOwnFieldUnlockEffect>d__104 <ShowOwnFieldUnlockEffect>d__;
			<ShowOwnFieldUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowOwnFieldUnlockEffect>d__.<>4__this = this;
			<ShowOwnFieldUnlockEffect>d__.<>1__state = -1;
			<ShowOwnFieldUnlockEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowOwnFieldUnlockEffect>d__104>(ref <ShowOwnFieldUnlockEffect>d__);
			return <ShowOwnFieldUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035D13 RID: 220435 RVA: 0x00CBBAF4 File Offset: 0x00CB9CF4
		public void FieldInteractClick(PhantomArenaFieldData fieldData, PhantomArenaFieldItem fieldItem)
		{
			PhantomCardData cardData = fieldData.CardData;
			if (cardData != null && cardData.IsNpcCard)
			{
				return;
			}
			if (this.InCantDragState())
			{
				return;
			}
			if (!this.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbUseFieldCardSkill, Array.Empty<object>()))
			{
				return;
			}
			if (fieldData.IsInSeal)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1133", Array.Empty<object>());
				return;
			}
			if (!fieldData.HasClickActiveSkill)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1132", Array.Empty<object>());
				return;
			}
			if (!fieldData.IsCanInteractive)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "使用领域";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("领域", fieldData.CardConfigId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OnHandleFiledClick(fieldData, fieldItem).Forget();
		}

		// Token: 0x06035D14 RID: 220436 RVA: 0x00CBBBB8 File Offset: 0x00CB9DB8
		public void FieldFinishSkillInteract(PhantomArenaFieldData fieldData)
		{
			PhantomArenaGuideCardSkillData phantomArenaGuideCardSkillData = new PhantomArenaGuideCardSkillData
			{
				CardId = fieldData.CardData.CardId
			};
			this.GuideManager.TryFinishGuideByType(EBvbPlayerOperationType.BvbUseFieldCardSkill, new object[]
			{
				EPhantomArenaSkillInteractExecuteResult.Success,
				phantomArenaGuideCardSkillData
			});
		}

		// Token: 0x06035D15 RID: 220437 RVA: 0x00CBBBFC File Offset: 0x00CB9DFC
		protected UniTask OnHandleFiledClick(PhantomArenaFieldData fieldData, PhantomArenaFieldItem fieldItem)
		{
			PhantomArenaBattleProxy.<OnHandleFiledClick>d__107 <OnHandleFiledClick>d__;
			<OnHandleFiledClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHandleFiledClick>d__.<>4__this = this;
			<OnHandleFiledClick>d__.fieldData = fieldData;
			<OnHandleFiledClick>d__.fieldItem = fieldItem;
			<OnHandleFiledClick>d__.<>1__state = -1;
			<OnHandleFiledClick>d__.<>t__builder.Start<PhantomArenaBattleProxy.<OnHandleFiledClick>d__107>(ref <OnHandleFiledClick>d__);
			return <OnHandleFiledClick>d__.<>t__builder.Task;
		}

		// Token: 0x06035D16 RID: 220438 RVA: 0x00CBBC4F File Offset: 0x00CB9E4F
		public void FieldPointerEnter(PhantomArenaFieldData fieldData, UUIItem attachItem, bool isGamepad)
		{
			this.ShowFiledTips(fieldData, attachItem, isGamepad);
		}

		// Token: 0x06035D17 RID: 220439 RVA: 0x00CBBC5A File Offset: 0x00CB9E5A
		public void FieldPointerExit()
		{
			this.HideFiledTips();
		}

		// Token: 0x0401C86B RID: 116843
		private PhantomArenaBattleView View;

		// Token: 0x0401C86C RID: 116844
		private int SelectedCardId = -1;

		// Token: 0x0401C86D RID: 116845
		private EPhantomArenaCardClickFromType SelectedFrom;

		// Token: 0x0401C86E RID: 116846
		public PopupCaptionItem CaptionItem;

		// Token: 0x0401C86F RID: 116847
		public PhantomArenaOwnArea OwnArea;

		// Token: 0x0401C870 RID: 116848
		public OpponentArea OpponentArea;

		// Token: 0x0401C871 RID: 116849
		public PhantomArenaCardRecycle CardRecycle;

		// Token: 0x0401C872 RID: 116850
		public PhantomArenaDiscardCardPanel DiscardPanel;

		// Token: 0x0401C873 RID: 116851
		public PhantomArenaChooseCardPanel ChooseCardPanel;

		// Token: 0x0401C874 RID: 116852
		public PhantomArenaSkillTriggerMask SkillTriggerMask;

		// Token: 0x0401C875 RID: 116853
		public PhantomArenaCanvasManager CanvasManager = new PhantomArenaCanvasManager();

		// Token: 0x0401C876 RID: 116854
		public PhantomArenaProcessManager ProcessManager;

		// Token: 0x0401C877 RID: 116855
		public PhantomArenaBuffEffectManager BuffEffectManager;

		// Token: 0x0401C878 RID: 116856
		public PhantomArenaBattleGuideManager GuideManager;

		// Token: 0x0401C879 RID: 116857
		public PhantomArenaBattleDialog DialogManager = new PhantomArenaBattleDialog();

		// Token: 0x0401C87A RID: 116858
		public PhantomArenaRoundOverCheck RoundOverCheck;

		// Token: 0x0401C87B RID: 116859
		public PhantomArenaBattleViewGamepadLogic GamepadLogic;

		// Token: 0x0401C87C RID: 116860
		public PhantomArenaBattleServerActionQueue ServerActionQueue;

		// Token: 0x0401C87D RID: 116861
		public PhantomArenaBanButtonFunctionModule BanButtonClickModule = new PhantomArenaBanButtonFunctionModule();

		// Token: 0x0401C87E RID: 116862
		protected HashSet<EPhantomArenaCantDragReason> InCantDragStateSet = new HashSet<EPhantomArenaCantDragReason>();

		// Token: 0x0401C87F RID: 116863
		public PhantomArenaBattleTips TipsItem;

		// Token: 0x0401C880 RID: 116864
		public PhantomArenaBattleDetailsTips DetailsTipsItem;

		// Token: 0x0401C881 RID: 116865
		public PhantomArenaBattleSkillTips SkillTipsItem;

		// Token: 0x0401C882 RID: 116866
		public EPhantomArenaBattlePanelInteractType InPanelInteractType;

		// Token: 0x0401C883 RID: 116867
		private bool IsMainInVisibleInternal;
	}
}
