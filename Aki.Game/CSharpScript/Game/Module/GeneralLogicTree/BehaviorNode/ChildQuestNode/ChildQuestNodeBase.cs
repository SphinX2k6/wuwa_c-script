using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059CC RID: 22988
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class ChildQuestNodeBase : BehaviorNodeBase
	{
		// Token: 0x0603A452 RID: 238674 RVA: 0x00DDB2D0 File Offset: 0x00DD94D0
		protected ChildQuestNodeBase(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17008B92 RID: 35730
		// (get) Token: 0x0603A453 RID: 238675 RVA: 0x00DDB2E1 File Offset: 0x00DD94E1
		public override EBtNode NodeType
		{
			get
			{
				return EBtNode.ChildQuest;
			}
		}

		// Token: 0x17008B93 RID: 35731
		// (get) Token: 0x0603A454 RID: 238676 RVA: 0x00DDB2E5 File Offset: 0x00DD94E5
		protected virtual List<int> CorrelativeEntities
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008B94 RID: 35732
		// (get) Token: 0x0603A455 RID: 238677 RVA: 0x00DDB2E8 File Offset: 0x00DD94E8
		public bool CanGiveUp
		{
			get
			{
				return this.ChildQuestStatus == ChildQuestNodeStatus.CqnsProgress;
			}
		}

		// Token: 0x17008B95 RID: 35733
		// (get) Token: 0x0603A456 RID: 238678 RVA: 0x00DDB2F3 File Offset: 0x00DD94F3
		public bool InProgress
		{
			get
			{
				return this.ChildQuestStatus == ChildQuestNodeStatus.CqnsProgress;
			}
		}

		// Token: 0x17008B96 RID: 35734
		// (get) Token: 0x0603A457 RID: 238679 RVA: 0x00DDB2FE File Offset: 0x00DD94FE
		public bool IsFinished
		{
			get
			{
				return this.ChildQuestStatus == ChildQuestNodeStatus.CqnsFinished;
			}
		}

		// Token: 0x17008B97 RID: 35735
		// (get) Token: 0x0603A458 RID: 238680 RVA: 0x00DDB309 File Offset: 0x00DD9509
		public ITrackLevelPlay TrackLevelPlay
		{
			get
			{
				ITrackTarget trackTarget = this.TrackTarget;
				if (trackTarget != null && trackTarget.TrackType.Type == Aki.TDConfigMgr.Quest.ETrackType.LevelPlay)
				{
					return this.TrackTarget.TrackType as ITrackLevelPlay;
				}
				return null;
			}
		}

		// Token: 0x0603A459 RID: 238681 RVA: 0x00DDB33C File Offset: 0x00DD953C
		[NullableContext(1)]
		public override void Init(Blackboard blackBoard, ENodeStatusUpdateReason reason, global::NodeInfo data, IBtNode config, BtType btType)
		{
			IChildQuestBtNode childQuestBtNode = config as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return;
			}
			base.Init(blackBoard, reason, data, config, btType);
			this.ChildQuestStatus = ChildQuestNodeStatus.CqnsNotActive;
			this.CustomTrackIconId = childQuestBtNode.CustomIcon.GetValueOrDefault();
			ChildQuestNodeInfo childQuestNodeInfo = data.Info.ChildQuestNodeInfo;
			if (childQuestNodeInfo != null)
			{
				this.UpdateChildQuestStatus(childQuestNodeInfo.Status, reason);
				base.UpdateProgress(childQuestNodeInfo.Progress);
			}
		}

		// Token: 0x0603A45A RID: 238682 RVA: 0x00DDB3A8 File Offset: 0x00DD95A8
		public void UpdateChildQuestStatus(ChildQuestNodeStatus status, ENodeStatusUpdateReason reason)
		{
			ChildQuestNodeStatus childQuestStatus = this.ChildQuestStatus;
			this.ChildQuestStatus = status;
			if (childQuestStatus == this.ChildQuestStatus)
			{
				return;
			}
			if (status != ChildQuestNodeStatus.CqnsProgress)
			{
				if (status == ChildQuestNodeStatus.CqnsFinished)
				{
					this.Finish();
				}
			}
			else
			{
				this.Start(reason);
			}
			EventSystem.Instance.Emit<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeChildQuestNodeStatusChange, this.Context, childQuestStatus, status, reason);
			EventSystem.Instance.EmitWithTarget<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus, ENodeStatusUpdateReason>(this.Blackboard, EEventName.OnLogicTreeChildQuestNodeStatusChange, this.Context, childQuestStatus, status, reason);
			EventSystem.Instance.Emit<GeneralContext, ChildQuestNodeStatus, ChildQuestNodeStatus>(EEventName.AfterLogicTreeChildQuestNodeStatusChange, this.Context, childQuestStatus, status);
		}

		// Token: 0x0603A45B RID: 238683 RVA: 0x00DDB438 File Offset: 0x00DD9638
		protected override void OnNodeActive()
		{
			this.AddTag(EBehaviorTreeTag.CanShow, base.NodeId.ToString());
			if (this.ModifyTrackAreaTextConfig != null)
			{
				Blackboard blackboard = this.Blackboard;
				if (blackboard != null)
				{
					blackboard.AddModifyTrackAreaConfig(base.NodeId, this.ModifyTrackAreaTextConfig);
				}
			}
			ITrackLevelPlay trackLevelPlay = this.TrackLevelPlay;
			if (trackLevelPlay != null)
			{
				GeneralLogicTreeModel.Instance.AddLevelPlayTrackBinding(base.NodeId, base.TreeIncId, trackLevelPlay.LevelPlayId);
				Blackboard blackboard2 = this.Blackboard;
				if (blackboard2 == null)
				{
					return;
				}
				blackboard2.AddTag(EBehaviorTreeTag.BindingLevelPlayTrack, base.NodeId.ToString());
			}
		}

		// Token: 0x0603A45C RID: 238684 RVA: 0x00DDB4C5 File Offset: 0x00DD96C5
		private void Start(ENodeStatusUpdateReason reason)
		{
			this.AddEventsOnChildQuestStart();
			this.OnStart(reason);
		}

		// Token: 0x0603A45D RID: 238685 RVA: 0x00DDB4D4 File Offset: 0x00DD96D4
		private void Finish()
		{
			this.End(true);
		}

		// Token: 0x0603A45E RID: 238686 RVA: 0x00DDB4E0 File Offset: 0x00DD96E0
		protected override void OnNodeDeActive(bool success)
		{
			this.RemoveTag(EBehaviorTreeTag.CanShow, base.NodeId.ToString());
			if (!success)
			{
				this.End(false);
				this.ChildQuestStatus = ChildQuestNodeStatus.CqnsNotActive;
			}
			if (this.ModifyTrackAreaTextConfig != null)
			{
				Blackboard blackboard = this.Blackboard;
				if (blackboard != null)
				{
					blackboard.RemoveModifyTrackAreaConfig(base.NodeId);
				}
			}
			ITrackLevelPlay trackLevelPlay = this.TrackLevelPlay;
			if (trackLevelPlay != null)
			{
				GeneralLogicTreeModel.Instance.RemoveLevelPlayTrackBinding(base.TreeIncId, trackLevelPlay.LevelPlayId);
				Blackboard blackboard2 = this.Blackboard;
				if (blackboard2 == null)
				{
					return;
				}
				blackboard2.RemoveTag(EBehaviorTreeTag.BindingLevelPlayTrack, base.NodeId.ToString());
			}
		}

		// Token: 0x0603A45F RID: 238687 RVA: 0x00DDB572 File Offset: 0x00DD9772
		private void End(bool bFinished)
		{
			this.RemoveEventsOnChildQuestEnd();
			this.OnEnd(bFinished);
		}

		// Token: 0x0603A460 RID: 238688 RVA: 0x00DDB584 File Offset: 0x00DD9784
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			this.ChildQuestType = childQuestBtNode.Condition.Type;
			if (childQuestBtNode.HideTip.GetValueOrDefault())
			{
				this.AddTag(EBehaviorTreeTag.HideQuestUpdateTips, "");
			}
			if (childQuestBtNode.HideUiExceptTaskList.GetValueOrDefault())
			{
				this.AddTag(EBehaviorTreeTag.HideTrackExpression, "");
				this.AddTag(EBehaviorTreeTag.HideQuestUpdateTips, "");
			}
			if (childQuestBtNode.HideUi.GetValueOrDefault())
			{
				this.AddTag(EBehaviorTreeTag.HideTrackExpression, "");
				this.AddTag(EBehaviorTreeTag.HideQuestUpdateTips, "");
				this.AddTag(EBehaviorTreeTag.HideInAllView, "");
			}
			if (childQuestBtNode.ShowNavigation.GetValueOrDefault())
			{
				this.AddTag(EBehaviorTreeTag.ShowNavigation, "");
				this.NavigationStyle = childQuestBtNode.NavigationStyle.GetValueOrDefault();
			}
			if (childQuestBtNode.AlwaysShowNavigation.GetValueOrDefault())
			{
				this.AddTag(EBehaviorTreeTag.AlwaysShowNavigation, "");
			}
			this.TrackTarget = childQuestBtNode.TrackTarget;
			this.TrackTextConfig = childQuestBtNode.TidTip;
			this.MultiTrackText = PublicUtil.Instance.GetConfigTextByKey(this.TrackTextConfig);
			this.ModifyTrackAreaTextConfig = childQuestBtNode.ModifyTrackAreaText;
			this.ShowTipBeforeEnterActions = childQuestBtNode.ShowTipBeforeEnterActions.GetValueOrDefault();
			this.TrackCustomBoard = childQuestBtNode.TrackCustomBoard;
			return true;
		}

		// Token: 0x0603A461 RID: 238689 RVA: 0x00DDB6CD File Offset: 0x00DD98CD
		protected virtual void OnStart(ENodeStatusUpdateReason reason)
		{
		}

		// Token: 0x0603A462 RID: 238690 RVA: 0x00DDB6CF File Offset: 0x00DD98CF
		protected virtual void OnEnd(bool bFinished)
		{
		}

		// Token: 0x0603A463 RID: 238691 RVA: 0x00DDB6D1 File Offset: 0x00DD98D1
		protected virtual void AddEventsOnChildQuestStart()
		{
		}

		// Token: 0x0603A464 RID: 238692 RVA: 0x00DDB6D3 File Offset: 0x00DD98D3
		protected virtual void RemoveEventsOnChildQuestEnd()
		{
		}

		// Token: 0x0603A465 RID: 238693 RVA: 0x00DDB6D8 File Offset: 0x00DD98D8
		protected virtual void SubmitNode(GeneralLogicTreeNodeExtraInfo parkourInfo = null)
		{
			if (this.Blackboard.ContainTag(EBehaviorTreeTag.RollbackWaiting))
			{
				return;
			}
			if (this.Submitting)
			{
				return;
			}
			if (this.Blackboard.IsSuspend())
			{
				return;
			}
			if (!this.CheckCanSubmitAboutFocusMode())
			{
				this.BecauseOfFocusModeNoSubmit();
				return;
			}
			this.OnBeforeSubmit();
			GeneralLogicTreeController.Instance.RequestSubmitNode(this.Context, new Action<bool>(this.OnAfterSubmit), parkourInfo);
		}

		// Token: 0x0603A466 RID: 238694 RVA: 0x00DDB73E File Offset: 0x00DD993E
		protected virtual void OnBeforeSubmit()
		{
			this.Submitting = true;
		}

		// Token: 0x0603A467 RID: 238695 RVA: 0x00DDB747 File Offset: 0x00DD9947
		protected virtual void OnAfterSubmit(bool submitSuccess)
		{
			this.Submitting = false;
		}

		// Token: 0x0603A468 RID: 238696 RVA: 0x00DDB750 File Offset: 0x00DD9950
		protected virtual bool CheckCanSubmitAboutFocusMode()
		{
			return true;
		}

		// Token: 0x0603A469 RID: 238697 RVA: 0x00DDB753 File Offset: 0x00DD9953
		protected virtual void BecauseOfFocusModeNoSubmit()
		{
		}

		// Token: 0x0603A46A RID: 238698 RVA: 0x00DDB755 File Offset: 0x00DD9955
		public List<int> GetCorrelativeEntities()
		{
			return this.CorrelativeEntities;
		}

		// Token: 0x0401E61B RID: 124443
		public EChildQuest ChildQuestType = EChildQuest.CheckEntityState;

		// Token: 0x0401E61C RID: 124444
		public int CustomTrackIconId;

		// Token: 0x0401E61D RID: 124445
		protected bool Submitting;

		// Token: 0x0401E61E RID: 124446
		protected ChildQuestNodeStatus ChildQuestStatus;

		// Token: 0x0401E61F RID: 124447
		public ITrackAreaText ModifyTrackAreaTextConfig;

		// Token: 0x0401E620 RID: 124448
		public ITrackCustomBoard TrackCustomBoard;
	}
}
