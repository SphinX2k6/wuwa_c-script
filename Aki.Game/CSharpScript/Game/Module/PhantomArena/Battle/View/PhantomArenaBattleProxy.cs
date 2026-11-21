using System;
using System.Collections.Generic;
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
	// Token: 0x02004215 RID: 16917
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleProxy
	{
		// Token: 0x0602ABC0 RID: 175040 RVA: 0x00C080B4 File Offset: 0x00C062B4
		public PhantomArenaBattleProxy()
		{
			this.ProcessManager = new PhantomArenaProcessManager(this);
			this.BuffEffectManager = new PhantomArenaBuffEffectManager(this);
			this.GuideManager = new PhantomArenaBattleGuideManager(this);
			this.RoundOverCheck = new PhantomArenaRoundOverCheck(this);
			this.GamepadLogic = new PhantomArenaBattleViewGamepadLogic(this);
			this.ServerActionQueue = new PhantomArenaBattleServerActionQueue(this);
		}

		// Token: 0x0602ABC1 RID: 175041 RVA: 0x00C08142 File Offset: 0x00C06342
		public void RegisterView(PhantomArenaBattleView view)
		{
			this.View = view;
		}

		// Token: 0x0602ABC2 RID: 175042 RVA: 0x00C0814C File Offset: 0x00C0634C
		public void RefreshByWorldDone()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "世界加载完成,刷新界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			PhantomArenaBattleController.RequestPhantomBattleStart();
			this.Show(true);
		}

		// Token: 0x0602ABC3 RID: 175043 RVA: 0x00C08184 File Offset: 0x00C06384
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

		// Token: 0x0602ABC4 RID: 175044 RVA: 0x00C081EC File Offset: 0x00C063EC
		public void Destroy()
		{
			this.ProcessManager.Clear();
			this.CanvasManager.ClearAreaCanvas();
			this.OpponentArea.Clear();
			this.DialogManager.Clear();
			PhantomArenaBattleModel.Instance.ClearWaitBattleData();
		}

		// Token: 0x0602ABC5 RID: 175045 RVA: 0x00C08224 File Offset: 0x00C06424
		public UUIItem GetDragRootItem()
		{
			return this.View.GetDragRootItem();
		}

		// Token: 0x0602ABC6 RID: 175046 RVA: 0x00C08231 File Offset: 0x00C06431
		public UUIItem GetOpponentCardLibraryItem()
		{
			return this.View.GetOpponentCardLibraryItem();
		}

		// Token: 0x0602ABC7 RID: 175047 RVA: 0x00C0823E File Offset: 0x00C0643E
		public UUIItem GetSkillTriggerAttachItem()
		{
			return this.View.GetSkillTriggerAttachItem();
		}

		// Token: 0x0602ABC8 RID: 175048 RVA: 0x00C0824C File Offset: 0x00C0644C
		public UniTask PlayShowFieldEffect()
		{
			PhantomArenaBattleProxy.<PlayShowFieldEffect>d__33 <PlayShowFieldEffect>d__;
			<PlayShowFieldEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowFieldEffect>d__.<>4__this = this;
			<PlayShowFieldEffect>d__.<>1__state = -1;
			<PlayShowFieldEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<PlayShowFieldEffect>d__33>(ref <PlayShowFieldEffect>d__);
			return <PlayShowFieldEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABC9 RID: 175049 RVA: 0x00C0828F File Offset: 0x00C0648F
		public void ShowLine()
		{
		}

		// Token: 0x0602ABCA RID: 175050 RVA: 0x00C08291 File Offset: 0x00C06491
		public void HideLine()
		{
		}

		// Token: 0x0602ABCB RID: 175051 RVA: 0x00C08293 File Offset: 0x00C06493
		public void SetCaptionItemActive(bool bActive)
		{
			this.View.SetCaptionItemActive(bActive);
		}

		// Token: 0x0602ABCC RID: 175052 RVA: 0x00C082A1 File Offset: 0x00C064A1
		public void ShowAddBuffEffect(EBuffShowType buffShowType, List<int> fightIdList)
		{
			this.OwnArea.FunctionalArea.ShowAddBuffEffect(buffShowType, fightIdList);
			this.OpponentArea.FunctionalArea.ShowAddBuffEffect(buffShowType, fightIdList);
		}

		// Token: 0x0602ABCD RID: 175053 RVA: 0x00C082C8 File Offset: 0x00C064C8
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

		// Token: 0x0602ABCE RID: 175054 RVA: 0x00C08344 File Offset: 0x00C06544
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

		// Token: 0x0602ABCF RID: 175055 RVA: 0x00C083BE File Offset: 0x00C065BE
		public bool InCantDragState()
		{
			return this.InCantDragStateSet.Count > 0;
		}

		// Token: 0x0602ABD0 RID: 175056 RVA: 0x00C083CE File Offset: 0x00C065CE
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

		// Token: 0x0602ABD1 RID: 175057 RVA: 0x00C08408 File Offset: 0x00C06608
		public void CancelSelectedCard()
		{
			if (this.SelectedCardId != -1)
			{
				this.SetSelectedCardState(false);
			}
			this.SelectedCardId = -1;
			this.SelectedFrom = EPhantomArenaCardClickFromType.None;
		}

		// Token: 0x0602ABD2 RID: 175058 RVA: 0x00C08428 File Offset: 0x00C06628
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

		// Token: 0x0602ABD3 RID: 175059 RVA: 0x00C084B8 File Offset: 0x00C066B8
		public void PlayRoundOverEffect()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "播放回合结束扫光效果", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.View.SetRoundEffectActive(true);
		}

		// Token: 0x0602ABD4 RID: 175060 RVA: 0x00C084F0 File Offset: 0x00C066F0
		public void HideRoundOverEffect()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "隐藏回合结束扫光效果", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.View.SetRoundEffectActive(false);
		}

		// Token: 0x0602ABD5 RID: 175061 RVA: 0x00C08528 File Offset: 0x00C06728
		public bool CheckRepeatCondition()
		{
			PhantomArenaOwnData ownData = PhantomArenaBattleModel.Instance.OwnData;
			return (ownData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint) != 0 || ownData.HasFourCostInHand()) && ownData.GetHandCardIdList().Count != 0;
		}

		// Token: 0x0602ABD6 RID: 175062 RVA: 0x00C08563 File Offset: 0x00C06763
		public UUIItem GetOwnCardLibraryItem()
		{
			return this.View.GetOwnCardLibraryItem();
		}

		// Token: 0x0602ABD7 RID: 175063 RVA: 0x00C08570 File Offset: 0x00C06770
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

		// Token: 0x0602ABD8 RID: 175064 RVA: 0x00C085CF File Offset: 0x00C067CF
		public void ShowOwnChangeCard()
		{
			PhantomArenaBattleController.OpenPhantomArenaChangeCardView();
		}

		// Token: 0x0602ABD9 RID: 175065 RVA: 0x00C085D8 File Offset: 0x00C067D8
		public UniTask ShowBothDrawCard()
		{
			PhantomArenaBattleProxy.<ShowBothDrawCard>d__50 <ShowBothDrawCard>d__;
			<ShowBothDrawCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowBothDrawCard>d__.<>4__this = this;
			<ShowBothDrawCard>d__.<>1__state = -1;
			<ShowBothDrawCard>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowBothDrawCard>d__50>(ref <ShowBothDrawCard>d__);
			return <ShowBothDrawCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABDA RID: 175066 RVA: 0x00C0861B File Offset: 0x00C0681B
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

		// Token: 0x0602ABDB RID: 175067 RVA: 0x00C0864C File Offset: 0x00C0684C
		public UniTask StartAiOperation()
		{
			PhantomArenaBattleProxy.<StartAiOperation>d__52 <StartAiOperation>d__;
			<StartAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartAiOperation>d__.<>4__this = this;
			<StartAiOperation>d__.<>1__state = -1;
			<StartAiOperation>d__.<>t__builder.Start<PhantomArenaBattleProxy.<StartAiOperation>d__52>(ref <StartAiOperation>d__);
			return <StartAiOperation>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABDC RID: 175068 RVA: 0x00C0868F File Offset: 0x00C0688F
		public void ShowGameOver()
		{
			PhantomArenaBattleController.TriggerPhantomBattleBoardSettle();
			this.ServerActionQueue.ResumeAction().Forget();
		}

		// Token: 0x0602ABDD RID: 175069 RVA: 0x00C086A6 File Offset: 0x00C068A6
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

		// Token: 0x0602ABDE RID: 175070 RVA: 0x00C086D8 File Offset: 0x00C068D8
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

		// Token: 0x0602ABDF RID: 175071 RVA: 0x00C0875A File Offset: 0x00C0695A
		public void ShowOwnPlaying()
		{
			this.ServerActionQueue.ResumeAction().Forget();
			this.RoundOverCheck.StartCheck();
			this.View.SetTimeEndBtnInteractive(true);
			this.UnRegisterCantDragReason(EPhantomArenaCantDragReason.NotInOwnTime);
		}

		// Token: 0x0602ABE0 RID: 175072 RVA: 0x00C0878C File Offset: 0x00C0698C
		public UniTask RoundOver()
		{
			PhantomArenaBattleProxy.<RoundOver>d__57 <RoundOver>d__;
			<RoundOver>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoundOver>d__.<>4__this = this;
			<RoundOver>d__.<>1__state = -1;
			<RoundOver>d__.<>t__builder.Start<PhantomArenaBattleProxy.<RoundOver>d__57>(ref <RoundOver>d__);
			return <RoundOver>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABE1 RID: 175073 RVA: 0x00C087CF File Offset: 0x00C069CF
		public void JumpLoading()
		{
			PhantomArenaBattleController.OpenPhantomArenaBattleLoading();
		}

		// Token: 0x0602ABE2 RID: 175074 RVA: 0x00C087D6 File Offset: 0x00C069D6
		public void HideLayoutClick()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
			this.OwnArea.HideCardList();
		}

		// Token: 0x0602ABE3 RID: 175075 RVA: 0x00C087EA File Offset: 0x00C069EA
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

		// Token: 0x0602ABE4 RID: 175076 RVA: 0x00C08813 File Offset: 0x00C06A13
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

		// Token: 0x0602ABE5 RID: 175077 RVA: 0x00C0884C File Offset: 0x00C06A4C
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

		// Token: 0x0602ABE6 RID: 175078 RVA: 0x00C088D0 File Offset: 0x00C06AD0
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

		// Token: 0x0602ABE7 RID: 175079 RVA: 0x00C08964 File Offset: 0x00C06B64
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

		// Token: 0x0602ABE8 RID: 175080 RVA: 0x00C089B8 File Offset: 0x00C06BB8
		public void OnOwnCardLibraryChange()
		{
			this.View.RefreshOwnCardLibraryNum();
		}

		// Token: 0x0602ABE9 RID: 175081 RVA: 0x00C089C8 File Offset: 0x00C06BC8
		public void OnOpponentHandCardChange()
		{
			int handCardNum = PhantomArenaBattleModel.Instance.OpponentData.HandCardNum;
			this.OpponentArea.HandArea.RefreshHandCardNum(handCardNum).Forget();
		}

		// Token: 0x0602ABEA RID: 175082 RVA: 0x00C089FB File Offset: 0x00C06BFB
		public void OnOpponentCardLibraryChange()
		{
			this.View.RefreshOpponentCardLibraryNum();
		}

		// Token: 0x0602ABEB RID: 175083 RVA: 0x00C08A08 File Offset: 0x00C06C08
		public void OnOwnHandCardAdd(IReadOnlyList<int> addCardList)
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "刷新手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OwnArea.HandArea.AddCard(new List<int>(addCardList)).Forget();
		}

		// Token: 0x0602ABEC RID: 175084 RVA: 0x00C08A4F File Offset: 0x00C06C4F
		public void OnTriggerSkillEffect()
		{
			this.ServerActionQueue.PushSkillEffectAction();
		}

		// Token: 0x0602ABED RID: 175085 RVA: 0x00C08A5C File Offset: 0x00C06C5C
		public void OnNotifyCardTaskData(bool isOwn)
		{
			if (isOwn)
			{
				this.OwnArea.RolePanel.RefreshTask();
				return;
			}
			this.OpponentArea.RolePanel.RefreshTask();
		}

		// Token: 0x0602ABEE RID: 175086 RVA: 0x00C08A82 File Offset: 0x00C06C82
		public void OnOwnHandCardRemove(IReadOnlyList<int> discardIdList)
		{
			this.OwnArea.HandArea.DiscardCard(this.View.GetOwnCardLibraryItem(), new List<int>(discardIdList)).Forget();
		}

		// Token: 0x0602ABEF RID: 175087 RVA: 0x00C08AAC File Offset: 0x00C06CAC
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

		// Token: 0x0602ABF0 RID: 175088 RVA: 0x00C08BC4 File Offset: 0x00C06DC4
		public void OnCardFactorsRefresh(int cardId)
		{
			if (this.TipsItem.IsInActive && this.TipsItem.GetCardId() == cardId)
			{
				this.TipsItem.RefreshContent();
			}
			this.OpponentArea.FunctionalArea.RefreshBattleCard(cardId);
			this.OwnArea.FunctionalArea.RefreshBattleCard(cardId);
		}

		// Token: 0x0602ABF1 RID: 175089 RVA: 0x00C08C1C File Offset: 0x00C06E1C
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

		// Token: 0x0602ABF2 RID: 175090 RVA: 0x00C08C74 File Offset: 0x00C06E74
		public void OnOwnBattleAttrChange(IReadOnlyList<PhantomBattleCardAttr> attrList)
		{
			bool flag = false;
			for (int i = 0; i < attrList.Count; i++)
			{
				if (attrList[i] == PhantomBattleCardAttr.Defence)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.OwnArea.RolePanel.RefreshShieldNum();
			}
		}

		// Token: 0x0602ABF3 RID: 175091 RVA: 0x00C08CB8 File Offset: 0x00C06EB8
		public void OnOpponentBattleAttrChange(IReadOnlyList<PhantomBattleCardAttr> attrList)
		{
			bool flag = false;
			for (int i = 0; i < attrList.Count; i++)
			{
				if (attrList[i] == PhantomBattleCardAttr.Defence)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.OpponentArea.RolePanel.RefreshShieldNum();
			}
		}

		// Token: 0x0602ABF4 RID: 175092 RVA: 0x00C08CF9 File Offset: 0x00C06EF9
		public void OnRefreshRound()
		{
			this.View.RefreshRoundNum();
		}

		// Token: 0x0602ABF5 RID: 175093 RVA: 0x00C08D06 File Offset: 0x00C06F06
		public void OnRefreshBattleCardNum()
		{
			this.View.RefreshLimitText();
		}

		// Token: 0x0602ABF6 RID: 175094 RVA: 0x00C08D14 File Offset: 0x00C06F14
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

		// Token: 0x0602ABF7 RID: 175095 RVA: 0x00C08D5D File Offset: 0x00C06F5D
		public void OnRefreshHandCardState()
		{
			this.OwnArea.HandArea.RefreshHandCardSequence();
		}

		// Token: 0x0602ABF8 RID: 175096 RVA: 0x00C08D6F File Offset: 0x00C06F6F
		public void OnPhantomBattleBoardSettleNotify()
		{
			if (this.ProcessManager.IsNotInOwnPlaying)
			{
				return;
			}
			PhantomArenaBattleController.TriggerPhantomBattleBoardSettle();
		}

		// Token: 0x0602ABF9 RID: 175097 RVA: 0x00C08D84 File Offset: 0x00C06F84
		public void OnOpponentSealFieldChange(int remainRound)
		{
			this.OpponentArea.RefreshFiledArea().Forget();
		}

		// Token: 0x0602ABFA RID: 175098 RVA: 0x00C08D96 File Offset: 0x00C06F96
		public void OnOwnSealRecycleChange(int remainRound)
		{
		}

		// Token: 0x0602ABFB RID: 175099 RVA: 0x00C08D98 File Offset: 0x00C06F98
		private void SetTipsActive(EPhantomArenaBattleShowTipsType showTipsType)
		{
			this.TipsItem.SetTipsActive(showTipsType == EPhantomArenaBattleShowTipsType.CardTips);
			this.DetailsTipsItem.SetTipsActive(showTipsType);
			this.SkillTipsItem.SetTipsActive(showTipsType == EPhantomArenaBattleShowTipsType.SkillTips);
		}

		// Token: 0x0602ABFC RID: 175100 RVA: 0x00C08DC4 File Offset: 0x00C06FC4
		public void HideCardTips()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
			EventSystem.Instance.Emit<bool>(EEventName.OnPhantomArenaCardDetailShowHideChange, false);
		}

		// Token: 0x0602ABFD RID: 175101 RVA: 0x00C08DDE File Offset: 0x00C06FDE
		public void ShowCardTips(PhantomCardData cardData, bool isCardItemShow)
		{
			this.TipsItem.RefreshTips(cardData, isCardItemShow);
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.CardTips);
			EventSystem.Instance.Emit<bool>(EEventName.OnPhantomArenaCardDetailShowHideChange, true);
		}

		// Token: 0x0602ABFE RID: 175102 RVA: 0x00C08E05 File Offset: 0x00C07005
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

		// Token: 0x0602ABFF RID: 175103 RVA: 0x00C08E28 File Offset: 0x00C07028
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

		// Token: 0x0602AC00 RID: 175104 RVA: 0x00C08EC6 File Offset: 0x00C070C6
		public void ShowSkillTips(IPhantomArenaSkillData data, UUIItem attachItem)
		{
			this.SkillTipsItem.Refresh(data);
			this.SkillTipsItem.SetTipsPosition(attachItem, data.IsOwn);
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.SkillTips);
		}

		// Token: 0x0602AC01 RID: 175105 RVA: 0x00C08EED File Offset: 0x00C070ED
		public void HideSkillTips()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
		}

		// Token: 0x0602AC02 RID: 175106 RVA: 0x00C08EF8 File Offset: 0x00C070F8
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

		// Token: 0x0602AC03 RID: 175107 RVA: 0x00C08F93 File Offset: 0x00C07193
		public void HideFiledTips()
		{
			this.SetTipsActive(EPhantomArenaBattleShowTipsType.None);
		}

		// Token: 0x0602AC04 RID: 175108 RVA: 0x00C08F9C File Offset: 0x00C0719C
		public UniTask StartTimeDrawCardTween()
		{
			PhantomArenaBattleProxy.<StartTimeDrawCardTween>d__93 <StartTimeDrawCardTween>d__;
			<StartTimeDrawCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartTimeDrawCardTween>d__.<>4__this = this;
			<StartTimeDrawCardTween>d__.<>1__state = -1;
			<StartTimeDrawCardTween>d__.<>t__builder.Start<PhantomArenaBattleProxy.<StartTimeDrawCardTween>d__93>(ref <StartTimeDrawCardTween>d__);
			return <StartTimeDrawCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC05 RID: 175109 RVA: 0x00C08FE0 File Offset: 0x00C071E0
		public UniTask EndTimeDiscardCardTween()
		{
			PhantomArenaBattleProxy.<EndTimeDiscardCardTween>d__94 <EndTimeDiscardCardTween>d__;
			<EndTimeDiscardCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndTimeDiscardCardTween>d__.<>4__this = this;
			<EndTimeDiscardCardTween>d__.<>1__state = -1;
			<EndTimeDiscardCardTween>d__.<>t__builder.Start<PhantomArenaBattleProxy.<EndTimeDiscardCardTween>d__94>(ref <EndTimeDiscardCardTween>d__);
			return <EndTimeDiscardCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x17005615 RID: 22037
		// (get) Token: 0x0602AC06 RID: 175110 RVA: 0x00C09023 File Offset: 0x00C07223
		public bool IsInPanelInteract
		{
			get
			{
				return this.InPanelInteractType > EPhantomArenaBattlePanelInteractType.MainView;
			}
		}

		// Token: 0x0602AC07 RID: 175111 RVA: 0x00C0902E File Offset: 0x00C0722E
		public void SetInPanelInteractType(EPhantomArenaBattlePanelInteractType type)
		{
			this.InPanelInteractType = type;
			this.View.RefreshUiBlurBehaviour();
		}

		// Token: 0x0602AC08 RID: 175112 RVA: 0x00C09042 File Offset: 0x00C07242
		public void SetIsMainInVisible(bool value)
		{
			this.IsMainInVisibleInternal = value;
			this.View.RefreshUiBlurBehaviour();
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirtyByGroupItem(this.View.GetRootItem());
		}

		// Token: 0x17005616 RID: 22038
		// (get) Token: 0x0602AC09 RID: 175113 RVA: 0x00C0906B File Offset: 0x00C0726B
		public bool IsMainInVisible
		{
			get
			{
				return this.IsMainInVisibleInternal;
			}
		}

		// Token: 0x0602AC0A RID: 175114 RVA: 0x00C09074 File Offset: 0x00C07274
		public UniTask ShowNpcFieldSealEffect()
		{
			PhantomArenaBattleProxy.<ShowNpcFieldSealEffect>d__101 <ShowNpcFieldSealEffect>d__;
			<ShowNpcFieldSealEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNpcFieldSealEffect>d__.<>4__this = this;
			<ShowNpcFieldSealEffect>d__.<>1__state = -1;
			<ShowNpcFieldSealEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowNpcFieldSealEffect>d__101>(ref <ShowNpcFieldSealEffect>d__);
			return <ShowNpcFieldSealEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC0B RID: 175115 RVA: 0x00C090B8 File Offset: 0x00C072B8
		public UniTask ShowNpcFieldUnlockEffect()
		{
			PhantomArenaBattleProxy.<ShowNpcFieldUnlockEffect>d__102 <ShowNpcFieldUnlockEffect>d__;
			<ShowNpcFieldUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNpcFieldUnlockEffect>d__.<>4__this = this;
			<ShowNpcFieldUnlockEffect>d__.<>1__state = -1;
			<ShowNpcFieldUnlockEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowNpcFieldUnlockEffect>d__102>(ref <ShowNpcFieldUnlockEffect>d__);
			return <ShowNpcFieldUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC0C RID: 175116 RVA: 0x00C090FC File Offset: 0x00C072FC
		public UniTask ShowOwnFieldSealEffect()
		{
			PhantomArenaBattleProxy.<ShowOwnFieldSealEffect>d__103 <ShowOwnFieldSealEffect>d__;
			<ShowOwnFieldSealEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowOwnFieldSealEffect>d__.<>4__this = this;
			<ShowOwnFieldSealEffect>d__.<>1__state = -1;
			<ShowOwnFieldSealEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowOwnFieldSealEffect>d__103>(ref <ShowOwnFieldSealEffect>d__);
			return <ShowOwnFieldSealEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC0D RID: 175117 RVA: 0x00C09140 File Offset: 0x00C07340
		public UniTask ShowOwnFieldUnlockEffect()
		{
			PhantomArenaBattleProxy.<ShowOwnFieldUnlockEffect>d__104 <ShowOwnFieldUnlockEffect>d__;
			<ShowOwnFieldUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowOwnFieldUnlockEffect>d__.<>4__this = this;
			<ShowOwnFieldUnlockEffect>d__.<>1__state = -1;
			<ShowOwnFieldUnlockEffect>d__.<>t__builder.Start<PhantomArenaBattleProxy.<ShowOwnFieldUnlockEffect>d__104>(ref <ShowOwnFieldUnlockEffect>d__);
			return <ShowOwnFieldUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC0E RID: 175118 RVA: 0x00C09184 File Offset: 0x00C07384
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

		// Token: 0x0602AC0F RID: 175119 RVA: 0x00C09248 File Offset: 0x00C07448
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

		// Token: 0x0602AC10 RID: 175120 RVA: 0x00C0928C File Offset: 0x00C0748C
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

		// Token: 0x0602AC11 RID: 175121 RVA: 0x00C092DF File Offset: 0x00C074DF
		public void FieldPointerEnter(PhantomArenaFieldData fieldData, UUIItem attachItem, bool isGamepad)
		{
			this.ShowFiledTips(fieldData, attachItem, isGamepad);
		}

		// Token: 0x0602AC12 RID: 175122 RVA: 0x00C092EA File Offset: 0x00C074EA
		public void FieldPointerExit()
		{
			this.HideFiledTips();
		}

		// Token: 0x040172A0 RID: 94880
		private PhantomArenaBattleView View;

		// Token: 0x040172A1 RID: 94881
		private int SelectedCardId = -1;

		// Token: 0x040172A2 RID: 94882
		private EPhantomArenaCardClickFromType SelectedFrom;

		// Token: 0x040172A3 RID: 94883
		public PopupCaptionItem CaptionItem;

		// Token: 0x040172A4 RID: 94884
		public PhantomArenaOwnArea OwnArea;

		// Token: 0x040172A5 RID: 94885
		public OpponentArea OpponentArea;

		// Token: 0x040172A6 RID: 94886
		public PhantomArenaCardRecycle CardRecycle;

		// Token: 0x040172A7 RID: 94887
		public PhantomArenaDiscardCardPanel DiscardPanel;

		// Token: 0x040172A8 RID: 94888
		public PhantomArenaChooseCardPanel ChooseCardPanel;

		// Token: 0x040172A9 RID: 94889
		public PhantomArenaSkillTriggerMask SkillTriggerMask;

		// Token: 0x040172AA RID: 94890
		public PhantomArenaCanvasManager CanvasManager = new PhantomArenaCanvasManager();

		// Token: 0x040172AB RID: 94891
		public PhantomArenaProcessManager ProcessManager;

		// Token: 0x040172AC RID: 94892
		public PhantomArenaBuffEffectManager BuffEffectManager;

		// Token: 0x040172AD RID: 94893
		public PhantomArenaBattleGuideManager GuideManager;

		// Token: 0x040172AE RID: 94894
		public PhantomArenaBattleDialog DialogManager = new PhantomArenaBattleDialog();

		// Token: 0x040172AF RID: 94895
		public PhantomArenaRoundOverCheck RoundOverCheck;

		// Token: 0x040172B0 RID: 94896
		public PhantomArenaBattleViewGamepadLogic GamepadLogic;

		// Token: 0x040172B1 RID: 94897
		public PhantomArenaBattleServerActionQueue ServerActionQueue;

		// Token: 0x040172B2 RID: 94898
		public PhantomArenaBanButtonFunctionModule BanButtonClickModule = new PhantomArenaBanButtonFunctionModule();

		// Token: 0x040172B3 RID: 94899
		protected HashSet<EPhantomArenaCantDragReason> InCantDragStateSet = new HashSet<EPhantomArenaCantDragReason>();

		// Token: 0x040172B4 RID: 94900
		public PhantomArenaBattleTips TipsItem;

		// Token: 0x040172B5 RID: 94901
		public PhantomArenaBattleDetailsTips DetailsTipsItem;

		// Token: 0x040172B6 RID: 94902
		public PhantomArenaBattleSkillTips SkillTipsItem;

		// Token: 0x040172B7 RID: 94903
		public EPhantomArenaBattlePanelInteractType InPanelInteractType;

		// Token: 0x040172B8 RID: 94904
		private bool IsMainInVisibleInternal;
	}
}
