using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049A5 RID: 18853
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class ChildQuestNodeBase : BehaviorNodeBase
	{
		// Token: 0x0602F379 RID: 193401 RVA: 0x00D2AB58 File Offset: 0x00D28D58
		protected ChildQuestNodeBase(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x0602F37A RID: 193402 RVA: 0x00D2AB69 File Offset: 0x00D28D69
		public override EBtNode NodeType
		{
			get
			{
				return EBtNode.ChildQuest;
			}
		}

		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x0602F37B RID: 193403 RVA: 0x00D2AB6D File Offset: 0x00D28D6D
		protected virtual List<int> CorrelativeEntities
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F61 RID: 24417
		// (get) Token: 0x0602F37C RID: 193404 RVA: 0x00D2AB70 File Offset: 0x00D28D70
		public bool CanGiveUp
		{
			get
			{
				return this.ChildQuestStatus == ChildQuestNodeStatus.CqnsProgress;
			}
		}

		// Token: 0x17005F62 RID: 24418
		// (get) Token: 0x0602F37D RID: 193405 RVA: 0x00D2AB7B File Offset: 0x00D28D7B
		public bool InProgress
		{
			get
			{
				return this.ChildQuestStatus == ChildQuestNodeStatus.CqnsProgress;
			}
		}

		// Token: 0x17005F63 RID: 24419
		// (get) Token: 0x0602F37E RID: 193406 RVA: 0x00D2AB86 File Offset: 0x00D28D86
		public bool IsFinished
		{
			get
			{
				return this.ChildQuestStatus == ChildQuestNodeStatus.CqnsFinished;
			}
		}

		// Token: 0x17005F64 RID: 24420
		// (get) Token: 0x0602F37F RID: 193407 RVA: 0x00D2AB91 File Offset: 0x00D28D91
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

		// Token: 0x0602F380 RID: 193408 RVA: 0x00D2ABC4 File Offset: 0x00D28DC4
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

		// Token: 0x0602F381 RID: 193409 RVA: 0x00D2AC30 File Offset: 0x00D28E30
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

		// Token: 0x0602F382 RID: 193410 RVA: 0x00D2ACC0 File Offset: 0x00D28EC0
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

		// Token: 0x0602F383 RID: 193411 RVA: 0x00D2AD4D File Offset: 0x00D28F4D
		private void Start(ENodeStatusUpdateReason reason)
		{
			this.AddEventsOnChildQuestStart();
			this.OnStart(reason);
		}

		// Token: 0x0602F384 RID: 193412 RVA: 0x00D2AD5C File Offset: 0x00D28F5C
		private void Finish()
		{
			this.End(true);
		}

		// Token: 0x0602F385 RID: 193413 RVA: 0x00D2AD68 File Offset: 0x00D28F68
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

		// Token: 0x0602F386 RID: 193414 RVA: 0x00D2ADFA File Offset: 0x00D28FFA
		private void End(bool bFinished)
		{
			this.RemoveEventsOnChildQuestEnd();
			this.OnEnd(bFinished);
		}

		// Token: 0x0602F387 RID: 193415 RVA: 0x00D2AE0C File Offset: 0x00D2900C
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

		// Token: 0x0602F388 RID: 193416 RVA: 0x00D2AF55 File Offset: 0x00D29155
		protected virtual void OnStart(ENodeStatusUpdateReason reason)
		{
		}

		// Token: 0x0602F389 RID: 193417 RVA: 0x00D2AF57 File Offset: 0x00D29157
		protected virtual void OnEnd(bool bFinished)
		{
		}

		// Token: 0x0602F38A RID: 193418 RVA: 0x00D2AF59 File Offset: 0x00D29159
		protected virtual void AddEventsOnChildQuestStart()
		{
		}

		// Token: 0x0602F38B RID: 193419 RVA: 0x00D2AF5B File Offset: 0x00D2915B
		protected virtual void RemoveEventsOnChildQuestEnd()
		{
		}

		// Token: 0x0602F38C RID: 193420 RVA: 0x00D2AF60 File Offset: 0x00D29160
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

		// Token: 0x0602F38D RID: 193421 RVA: 0x00D2AFC6 File Offset: 0x00D291C6
		protected virtual void OnBeforeSubmit()
		{
			this.Submitting = true;
		}

		// Token: 0x0602F38E RID: 193422 RVA: 0x00D2AFCF File Offset: 0x00D291CF
		protected virtual void OnAfterSubmit(bool submitSuccess)
		{
			this.Submitting = false;
		}

		// Token: 0x0602F38F RID: 193423 RVA: 0x00D2AFD8 File Offset: 0x00D291D8
		protected virtual bool CheckCanSubmitAboutFocusMode()
		{
			return true;
		}

		// Token: 0x0602F390 RID: 193424 RVA: 0x00D2AFDB File Offset: 0x00D291DB
		protected virtual void BecauseOfFocusModeNoSubmit()
		{
		}

		// Token: 0x0602F391 RID: 193425 RVA: 0x00D2AFDD File Offset: 0x00D291DD
		public List<int> GetCorrelativeEntities()
		{
			return this.CorrelativeEntities;
		}

		// Token: 0x040190BA RID: 102586
		public EChildQuest ChildQuestType = EChildQuest.CheckEntityState;

		// Token: 0x040190BB RID: 102587
		public int CustomTrackIconId;

		// Token: 0x040190BC RID: 102588
		protected bool Submitting;

		// Token: 0x040190BD RID: 102589
		protected ChildQuestNodeStatus ChildQuestStatus;

		// Token: 0x040190BE RID: 102590
		public ITrackAreaText ModifyTrackAreaTextConfig;

		// Token: 0x040190BF RID: 102591
		public ITrackCustomBoard TrackCustomBoard;
	}
}
