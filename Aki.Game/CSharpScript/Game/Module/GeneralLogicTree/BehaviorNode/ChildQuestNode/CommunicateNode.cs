using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049A7 RID: 18855
	public class CommunicateNode : ChildQuestNodeBase
	{
		// Token: 0x0602F39E RID: 193438 RVA: 0x00D2B213 File Offset: 0x00D29413
		public CommunicateNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F39F RID: 193439 RVA: 0x00D2B21C File Offset: 0x00D2941C
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IReceiveTelecomChildQuestCondition receiveTelecomChildQuestCondition = childQuestBtNode.Condition as IReceiveTelecomChildQuestCondition;
			if (receiveTelecomChildQuestCondition == null)
			{
				return false;
			}
			this.CommunicateId = receiveTelecomChildQuestCondition.TelecomId;
			return true;
		}

		// Token: 0x0602F3A0 RID: 193440 RVA: 0x00D2B260 File Offset: 0x00D29460
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			base.OnStart(reason);
			this.AddedRedDot = false;
			EventSystem.Instance.Add<int>(EEventName.CommunicateFinished, new Action<int>(this.OnCommunicateFinished));
			EventSystem.Instance.Add<int>(EEventName.CommunicateAgain, new Action<int>(this.OnCommunicateAgain));
			EventSystem.Instance.Add<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnLogicTreeTrackUpdate));
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnBattleViewShow));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add(EEventName.ChangeMode, new Action(this.OnChangeMode));
			if (this.CheckCanSubmitAboutFocusMode())
			{
				this.OpenCommunicate();
			}
		}

		// Token: 0x0602F3A1 RID: 193441 RVA: 0x00D2B330 File Offset: 0x00D29530
		protected override void OnEnd(bool bFinished)
		{
			EventSystem.Instance.Remove<int>(EEventName.CommunicateFinished, new Action<int>(this.OnCommunicateFinished));
			EventSystem.Instance.Remove<int>(EEventName.CommunicateAgain, new Action<int>(this.OnCommunicateAgain));
			EventSystem.Instance.Remove<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnLogicTreeTrackUpdate));
			EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnBattleViewShow));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.ChangeMode, new Action(this.OnChangeMode));
			base.OnEnd(bFinished);
		}

		// Token: 0x0602F3A2 RID: 193442 RVA: 0x00D2B3E9 File Offset: 0x00D295E9
		private void OnCommunicateFinished(int communicateId)
		{
			if (communicateId != this.CommunicateId)
			{
				return;
			}
			this.Blackboard.RemoveTag(EBehaviorTreeTag.CanCommunicateAgain, "");
			this.SubmitNode(null);
		}

		// Token: 0x0602F3A3 RID: 193443 RVA: 0x00D2B40D File Offset: 0x00D2960D
		private void OnCommunicateAgain(int communicateId)
		{
			if (communicateId != this.CommunicateId)
			{
				return;
			}
			this.OpenCommunicate();
		}

		// Token: 0x0602F3A4 RID: 193444 RVA: 0x00D2B420 File Offset: 0x00D29620
		private void OnLogicTreeTrackUpdate(BtType btType, long? treeIncId)
		{
			long? num = treeIncId;
			long treeIncId2 = base.TreeIncId;
			if (!(num.GetValueOrDefault() == treeIncId2 & num != null))
			{
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.BattleView))
			{
				return;
			}
			this.TriggerTrack = this.Blackboard.IsTracking;
		}

		// Token: 0x0602F3A5 RID: 193445 RVA: 0x00D2B46E File Offset: 0x00D2966E
		private void OnBattleViewShow()
		{
			if (this.TriggerTrack && !UiManager.Instance.IsViewShow(EUiViewName.CommunicateView))
			{
				this.OpenCommunicate();
				this.TriggerTrack = false;
			}
		}

		// Token: 0x0602F3A6 RID: 193446 RVA: 0x00D2B498 File Offset: 0x00D29698
		private void OnCloseView(EUiViewName viewName, int _)
		{
			if (viewName != EUiViewName.CommunicateView)
			{
				return;
			}
			if (this.ChildQuestStatus != ChildQuestNodeStatus.CqnsProgress)
			{
				return;
			}
			this.Blackboard.AddTag(EBehaviorTreeTag.CanCommunicateAgain, "");
			if (!this.AddedRedDot && this.BtType == BtType.Quest)
			{
				this.AddedRedDot = true;
				QuestNewController.Instance.RedDotRequest(base.TreeConfigId, EQuestRedDotOperate.Add);
			}
		}

		// Token: 0x0602F3A7 RID: 193447 RVA: 0x00D2B4F7 File Offset: 0x00D296F7
		private void OpenCommunicate()
		{
			this.Blackboard.RemoveTag(EBehaviorTreeTag.CanCommunicateAgain, "");
			UiManager.Instance.OpenView(EUiViewName.CommunicateView, this.CommunicateId, null);
		}

		// Token: 0x0602F3A8 RID: 193448 RVA: 0x00D2B525 File Offset: 0x00D29725
		private void OnChangeMode()
		{
			UiManager.Instance.CloseView(EUiViewName.CommunicateView, null);
		}

		// Token: 0x0602F3A9 RID: 193449 RVA: 0x00D2B537 File Offset: 0x00D29737
		protected override bool CheckCanSubmitAboutFocusMode()
		{
			return this.BtType != BtType.Quest || !QuestNewModel.Instance.CheckNeedBanQuestPushByFocusMode(base.TreeConfigId);
		}

		// Token: 0x0602F3AA RID: 193450 RVA: 0x00D2B557 File Offset: 0x00D29757
		protected override void BecauseOfFocusModeNoSubmit()
		{
			this.TriggerTrack = this.Blackboard.IsTracking;
		}

		// Token: 0x040190C3 RID: 102595
		public int CommunicateId;

		// Token: 0x040190C4 RID: 102596
		private bool TriggerTrack;

		// Token: 0x040190C5 RID: 102597
		private bool AddedRedDot;
	}
}
