using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059CE RID: 22990
	public class CommunicateNode : ChildQuestNodeBase
	{
		// Token: 0x0603A477 RID: 238711 RVA: 0x00DDB98B File Offset: 0x00DD9B8B
		public CommunicateNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A478 RID: 238712 RVA: 0x00DDB994 File Offset: 0x00DD9B94
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

		// Token: 0x0603A479 RID: 238713 RVA: 0x00DDB9D8 File Offset: 0x00DD9BD8
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

		// Token: 0x0603A47A RID: 238714 RVA: 0x00DDBAA8 File Offset: 0x00DD9CA8
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

		// Token: 0x0603A47B RID: 238715 RVA: 0x00DDBB61 File Offset: 0x00DD9D61
		private void OnCommunicateFinished(int communicateId)
		{
			if (communicateId != this.CommunicateId)
			{
				return;
			}
			this.Blackboard.RemoveTag(EBehaviorTreeTag.CanCommunicateAgain, "");
			this.SubmitNode(null);
		}

		// Token: 0x0603A47C RID: 238716 RVA: 0x00DDBB85 File Offset: 0x00DD9D85
		private void OnCommunicateAgain(int communicateId)
		{
			if (communicateId != this.CommunicateId)
			{
				return;
			}
			this.OpenCommunicate();
		}

		// Token: 0x0603A47D RID: 238717 RVA: 0x00DDBB98 File Offset: 0x00DD9D98
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

		// Token: 0x0603A47E RID: 238718 RVA: 0x00DDBBE6 File Offset: 0x00DD9DE6
		private void OnBattleViewShow()
		{
			if (this.TriggerTrack && !UiManager.Instance.IsViewShow(EUiViewName.CommunicateView))
			{
				this.OpenCommunicate();
				this.TriggerTrack = false;
			}
		}

		// Token: 0x0603A47F RID: 238719 RVA: 0x00DDBC10 File Offset: 0x00DD9E10
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

		// Token: 0x0603A480 RID: 238720 RVA: 0x00DDBC6F File Offset: 0x00DD9E6F
		private void OpenCommunicate()
		{
			this.Blackboard.RemoveTag(EBehaviorTreeTag.CanCommunicateAgain, "");
			UiManager.Instance.OpenView(EUiViewName.CommunicateView, this.CommunicateId, null);
		}

		// Token: 0x0603A481 RID: 238721 RVA: 0x00DDBC9D File Offset: 0x00DD9E9D
		private void OnChangeMode()
		{
			UiManager.Instance.CloseView(EUiViewName.CommunicateView, null);
		}

		// Token: 0x0603A482 RID: 238722 RVA: 0x00DDBCAF File Offset: 0x00DD9EAF
		protected override bool CheckCanSubmitAboutFocusMode()
		{
			return this.BtType != BtType.Quest || !QuestNewModel.Instance.CheckNeedBanQuestPushByFocusMode(base.TreeConfigId);
		}

		// Token: 0x0603A483 RID: 238723 RVA: 0x00DDBCCF File Offset: 0x00DD9ECF
		protected override void BecauseOfFocusModeNoSubmit()
		{
			this.TriggerTrack = this.Blackboard.IsTracking;
		}

		// Token: 0x0401E624 RID: 124452
		public int CommunicateId;

		// Token: 0x0401E625 RID: 124453
		private bool TriggerTrack;

		// Token: 0x0401E626 RID: 124454
		private bool AddedRedDot;
	}
}
