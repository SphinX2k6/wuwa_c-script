using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000690 RID: 1680
	public sealed class GameCtxPb : IMessage<GameCtxPb>, IMessage, IEquatable<GameCtxPb>, IDeepCloneable<GameCtxPb>, IBufferMessage
	{
		// Token: 0x06009A34 RID: 39476 RVA: 0x00174798 File Offset: 0x00172998
		[NullableContext(1)]
		public static GameCtxPb Create()
		{
			return new GameCtxPb();
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x0017479F File Offset: 0x0017299F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06009A36 RID: 39478 RVA: 0x001747A2 File Offset: 0x001729A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameCtxPb.Descriptor;
			}
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x001747A9 File Offset: 0x001729A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb()
		{
		}

		// Token: 0x06009A38 RID: 39480 RVA: 0x001747B4 File Offset: 0x001729B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb(GameCtxPb other) : this()
		{
			this.ctxType_ = other.ctxType_;
			GameCtxPb.CtxInfoOneofCase ctxInfoCase = other.CtxInfoCase;
			if (ctxInfoCase <= GameCtxPb.CtxInfoOneofCase.CasketTrigger)
			{
				switch (ctxInfoCase)
				{
				case GameCtxPb.CtxInfoOneofCase.BehaviorTree:
					this.BehaviorTree = other.BehaviorTree.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.Entity:
					this.Entity = other.Entity.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.NormalInteract:
					this.NormalInteract = other.NormalInteract.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.DynamicInteract:
					this.DynamicInteract = other.DynamicInteract.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.RandomInteract:
					this.RandomInteract = other.RandomInteract.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.StateChangeAction:
					this.StateChangeAction = other.StateChangeAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityGroupAction:
					this.EntityGroupAction = other.EntityGroupAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityTrigger:
					this.EntityTrigger = other.EntityTrigger.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx:
					this.EntityLeaveTriggerCtx = other.EntityLeaveTriggerCtx.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityDestructible:
					this.EntityDestructible = other.EntityDestructible.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack:
					this.EntityTimelineTrack = other.EntityTimelineTrack.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction:
					this.LevelPlayOpenAction = other.LevelPlayOpenAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction:
					this.LevelPlayRewardAction = other.LevelPlayRewardAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestActiveAction:
					this.QuestActiveAction = other.QuestActiveAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestAcceptAction:
					this.QuestAcceptAction = other.QuestAcceptAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestFinishAction:
					this.QuestFinishAction = other.QuestFinishAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction:
					this.ChildQuestNodeEnterAction = other.ChildQuestNodeEnterAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction:
					this.ChildQuestNodeFinishAction = other.ChildQuestNodeFinishAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.SuccessNodeAction:
					this.SuccessNodeAction = other.SuccessNodeAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.FailedNodeAction:
					this.FailedNodeAction = other.FailedNodeAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.CompositionEnterAction:
					this.CompositionEnterAction = other.CompositionEnterAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction:
					this.EntityConditionListeningAction = other.EntityConditionListeningAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode:
					this.PlayFlowChildQuestNode = other.PlayFlowChildQuestNode.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode:
					this.HandInItemChildQuestNode = other.HandInItemChildQuestNode.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode:
					this.DoInteractChildQuestNode = other.DoInteractChildQuestNode.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction:
					this.ActionGroupNodeAction = other.ActionGroupNodeAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction:
					this.ExploreSkillPullGiantAction = other.ExploreSkillPullGiantAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlay:
					this.LevelPlay = other.LevelPlay.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.GmLevelAction:
					this.GmLevelAction = other.GmLevelAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction:
					this.LifeCycleCreateAction = other.LifeCycleCreateAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction:
					this.LifeCycleDestroyAction = other.LifeCycleDestroyAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.FlowAction:
					this.FlowAction = other.FlowAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction:
					this.DailyQuestTerminateAction = other.DailyQuestTerminateAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction:
					this.EntityBeamReceiveAction = other.EntityBeamReceiveAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction:
					this.EntityGroupFailureAction = other.EntityGroupFailureAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction:
					this.StateChangeConditionAction = other.StateChangeConditionAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.FlowStartTeleport:
					this.FlowStartTeleport = other.FlowStartTeleport.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction:
					this.LeaveInstEscAction = other.LeaveInstEscAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.TrampleActive:
					this.TrampleActive = other.TrampleActive.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.TrampleDeActive:
					this.TrampleDeActive = other.TrampleDeActive.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction:
					this.RenjuCompleteAction = other.RenjuCompleteAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction:
					this.JigsawFoundationMatchedAction = other.JigsawFoundationMatchedAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx:
					this.JigsawFoundationUnMatchedActionCtx = other.JigsawFoundationUnMatchedActionCtx.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.HookLockPointAction:
					this.HookLockPointAction = other.HookLockPointAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.ClientTriggerAction:
					this.ClientTriggerAction = other.ClientTriggerAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction:
					this.ExploreSkillCustomAction = other.ExploreSkillCustomAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction:
					this.JigsawFoundationMatchedConditionAction = other.JigsawFoundationMatchedConditionAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction:
					this.LevelPlayDestroyAction = other.LevelPlayDestroyAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction:
					this.TemplateSpawnerAction = other.TemplateSpawnerAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestDestroyAction:
					this.QuestDestroyAction = other.QuestDestroyAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction:
					this.CompositionConditionEnterAction = other.CompositionConditionEnterAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction:
					this.TargetGearHitPartCtxAction = other.TargetGearHitPartCtxAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.GlobalFix:
					this.GlobalFix = other.GlobalFix.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb:
					this.StuckCheckCtxPb = other.StuckCheckCtxPb.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb:
					this.AfterConditionActionCtxPb = other.AfterConditionActionCtxPb.Clone();
					break;
				case (GameCtxPb.CtxInfoOneofCase)57:
					break;
				case GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb:
					this.MotorSliderCtxPb = other.MotorSliderCtxPb.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb:
					this.RollBlockGamePlayActionCtxPb = other.RollBlockGamePlayActionCtxPb.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.TransferCtxPb:
					this.TransferCtxPb = other.TransferCtxPb.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb:
					this.DynamicEntityRewardCtxPb = other.DynamicEntityRewardCtxPb.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb:
					this.BeamCastHitPlayerActionCtxPb = other.BeamCastHitPlayerActionCtxPb.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.ExploreSkillAction:
					this.ExploreSkillAction = other.ExploreSkillAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.PollutionRangeAction:
					this.PollutionRangeAction = other.PollutionRangeAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction:
					this.EntityQuickHackSkillAction = other.EntityQuickHackSkillAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction:
					this.RecallQuestActiveAction = other.RecallQuestActiveAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction:
					this.RecallQuestAcceptAction = other.RecallQuestAcceptAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction:
					this.RecallQuestFinishAction = other.RecallQuestFinishAction.Clone();
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction:
					this.RecallQuestDestroyAction = other.RecallQuestDestroyAction.Clone();
					break;
				default:
					if (ctxInfoCase != GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction)
					{
						if (ctxInfoCase == GameCtxPb.CtxInfoOneofCase.CasketTrigger)
						{
							this.CasketTrigger = other.CasketTrigger.Clone();
						}
					}
					else
					{
						this.EdDebugEnterAction = other.EdDebugEnterAction.Clone();
					}
					break;
				}
			}
			else if (ctxInfoCase != GameCtxPb.CtxInfoOneofCase.FoundationOperateAction)
			{
				if (ctxInfoCase != GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction)
				{
					if (ctxInfoCase == GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb)
					{
						this.LongPressInteractActionCtxPb = other.LongPressInteractActionCtxPb.Clone();
					}
				}
				else
				{
					this.TargetGearActionByHitTypeAction = other.TargetGearActionByHitTypeAction.Clone();
				}
			}
			else
			{
				this.FoundationOperateAction = other.FoundationOperateAction.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A39 RID: 39481 RVA: 0x00174F68 File Offset: 0x00173168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb Clone()
		{
			return new GameCtxPb(this);
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06009A3A RID: 39482 RVA: 0x00174F70 File Offset: 0x00173170
		// (set) Token: 0x06009A3B RID: 39483 RVA: 0x00174F78 File Offset: 0x00173178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxType CtxType
		{
			get
			{
				return this.ctxType_;
			}
			set
			{
				this.ctxType_ = value;
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06009A3C RID: 39484 RVA: 0x00174F81 File Offset: 0x00173181
		// (set) Token: 0x06009A3D RID: 39485 RVA: 0x00174F99 File Offset: 0x00173199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb BehaviorTree
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.BehaviorTree)
				{
					return null;
				}
				return (BehaviorTreeCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.BehaviorTree);
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06009A3E RID: 39486 RVA: 0x00174FAF File Offset: 0x001731AF
		// (set) Token: 0x06009A3F RID: 39487 RVA: 0x00174FC7 File Offset: 0x001731C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb Entity
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.Entity)
				{
					return null;
				}
				return (EntityCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.Entity);
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06009A40 RID: 39488 RVA: 0x00174FDD File Offset: 0x001731DD
		// (set) Token: 0x06009A41 RID: 39489 RVA: 0x00174FF5 File Offset: 0x001731F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalInteractCtxPb NormalInteract
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.NormalInteract)
				{
					return null;
				}
				return (NormalInteractCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.NormalInteract);
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06009A42 RID: 39490 RVA: 0x0017500B File Offset: 0x0017320B
		// (set) Token: 0x06009A43 RID: 39491 RVA: 0x00175023 File Offset: 0x00173223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractCtxPb DynamicInteract
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.DynamicInteract)
				{
					return null;
				}
				return (DynamicInteractCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.DynamicInteract);
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06009A44 RID: 39492 RVA: 0x00175039 File Offset: 0x00173239
		// (set) Token: 0x06009A45 RID: 39493 RVA: 0x00175051 File Offset: 0x00173251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomInteractCtxPb RandomInteract
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.RandomInteract)
				{
					return null;
				}
				return (RandomInteractCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.RandomInteract);
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06009A46 RID: 39494 RVA: 0x00175067 File Offset: 0x00173267
		// (set) Token: 0x06009A47 RID: 39495 RVA: 0x0017507F File Offset: 0x0017327F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeActionCtxPb StateChangeAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.StateChangeAction)
				{
					return null;
				}
				return (StateChangeActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.StateChangeAction);
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06009A48 RID: 39496 RVA: 0x00175095 File Offset: 0x00173295
		// (set) Token: 0x06009A49 RID: 39497 RVA: 0x001750AD File Offset: 0x001732AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupActionCtxPb EntityGroupAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityGroupAction)
				{
					return null;
				}
				return (EntityGroupActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityGroupAction);
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06009A4A RID: 39498 RVA: 0x001750C3 File Offset: 0x001732C3
		// (set) Token: 0x06009A4B RID: 39499 RVA: 0x001750DC File Offset: 0x001732DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTriggerCtxPb EntityTrigger
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityTrigger)
				{
					return null;
				}
				return (EntityTriggerCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityTrigger);
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06009A4C RID: 39500 RVA: 0x001750F3 File Offset: 0x001732F3
		// (set) Token: 0x06009A4D RID: 39501 RVA: 0x0017510C File Offset: 0x0017330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLeaveTriggerCtxPb EntityLeaveTriggerCtx
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx)
				{
					return null;
				}
				return (EntityLeaveTriggerCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx);
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06009A4E RID: 39502 RVA: 0x00175123 File Offset: 0x00173323
		// (set) Token: 0x06009A4F RID: 39503 RVA: 0x0017513C File Offset: 0x0017333C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestructibleCtxPb EntityDestructible
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityDestructible)
				{
					return null;
				}
				return (EntityDestructibleCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityDestructible);
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06009A50 RID: 39504 RVA: 0x00175153 File Offset: 0x00173353
		// (set) Token: 0x06009A51 RID: 39505 RVA: 0x0017516C File Offset: 0x0017336C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimelineTrackCtxPb EntityTimelineTrack
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack)
				{
					return null;
				}
				return (EntityTimelineTrackCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack);
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06009A52 RID: 39506 RVA: 0x00175183 File Offset: 0x00173383
		// (set) Token: 0x06009A53 RID: 39507 RVA: 0x0017519C File Offset: 0x0017339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenActionCtxPb LevelPlayOpenAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction)
				{
					return null;
				}
				return (LevelPlayOpenActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction);
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06009A54 RID: 39508 RVA: 0x001751B3 File Offset: 0x001733B3
		// (set) Token: 0x06009A55 RID: 39509 RVA: 0x001751CC File Offset: 0x001733CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardActionCtxPb LevelPlayRewardAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction)
				{
					return null;
				}
				return (LevelPlayRewardActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction);
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06009A56 RID: 39510 RVA: 0x001751E3 File Offset: 0x001733E3
		// (set) Token: 0x06009A57 RID: 39511 RVA: 0x001751FC File Offset: 0x001733FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActiveActionCtxPb QuestActiveAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.QuestActiveAction)
				{
					return null;
				}
				return (QuestActiveActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.QuestActiveAction);
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06009A58 RID: 39512 RVA: 0x00175213 File Offset: 0x00173413
		// (set) Token: 0x06009A59 RID: 39513 RVA: 0x0017522C File Offset: 0x0017342C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestAcceptActionCtxPb QuestAcceptAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.QuestAcceptAction)
				{
					return null;
				}
				return (QuestAcceptActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.QuestAcceptAction);
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06009A5A RID: 39514 RVA: 0x00175243 File Offset: 0x00173443
		// (set) Token: 0x06009A5B RID: 39515 RVA: 0x0017525C File Offset: 0x0017345C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionCtxPb QuestFinishAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.QuestFinishAction)
				{
					return null;
				}
				return (QuestFinishActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.QuestFinishAction);
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06009A5C RID: 39516 RVA: 0x00175273 File Offset: 0x00173473
		// (set) Token: 0x06009A5D RID: 39517 RVA: 0x0017528C File Offset: 0x0017348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeEnterActionCtxPb ChildQuestNodeEnterAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction)
				{
					return null;
				}
				return (ChildQuestNodeEnterActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction);
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06009A5E RID: 39518 RVA: 0x001752A3 File Offset: 0x001734A3
		// (set) Token: 0x06009A5F RID: 39519 RVA: 0x001752BC File Offset: 0x001734BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeFinishActionCtxPb ChildQuestNodeFinishAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction)
				{
					return null;
				}
				return (ChildQuestNodeFinishActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction);
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06009A60 RID: 39520 RVA: 0x001752D3 File Offset: 0x001734D3
		// (set) Token: 0x06009A61 RID: 39521 RVA: 0x001752EC File Offset: 0x001734EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SuccessNodeActionCtxPb SuccessNodeAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.SuccessNodeAction)
				{
					return null;
				}
				return (SuccessNodeActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.SuccessNodeAction);
			}
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06009A62 RID: 39522 RVA: 0x00175303 File Offset: 0x00173503
		// (set) Token: 0x06009A63 RID: 39523 RVA: 0x0017531C File Offset: 0x0017351C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailedNodeActionCtxPb FailedNodeAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.FailedNodeAction)
				{
					return null;
				}
				return (FailedNodeActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.FailedNodeAction);
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x06009A64 RID: 39524 RVA: 0x00175333 File Offset: 0x00173533
		// (set) Token: 0x06009A65 RID: 39525 RVA: 0x0017534C File Offset: 0x0017354C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionEnterActionCtxPb CompositionEnterAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.CompositionEnterAction)
				{
					return null;
				}
				return (CompositionEnterActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.CompositionEnterAction);
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x06009A66 RID: 39526 RVA: 0x00175363 File Offset: 0x00173563
		// (set) Token: 0x06009A67 RID: 39527 RVA: 0x0017537C File Offset: 0x0017357C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConditionListeningActionCtxPb EntityConditionListeningAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction)
				{
					return null;
				}
				return (EntityConditionListeningActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction);
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06009A68 RID: 39528 RVA: 0x00175393 File Offset: 0x00173593
		// (set) Token: 0x06009A69 RID: 39529 RVA: 0x001753AC File Offset: 0x001735AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayFlowChildQuestNodeCtxPb PlayFlowChildQuestNode
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode)
				{
					return null;
				}
				return (PlayFlowChildQuestNodeCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode);
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06009A6A RID: 39530 RVA: 0x001753C3 File Offset: 0x001735C3
		// (set) Token: 0x06009A6B RID: 39531 RVA: 0x001753DC File Offset: 0x001735DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemChildQuestNodeCtxPb HandInItemChildQuestNode
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode)
				{
					return null;
				}
				return (HandInItemChildQuestNodeCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode);
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06009A6C RID: 39532 RVA: 0x001753F3 File Offset: 0x001735F3
		// (set) Token: 0x06009A6D RID: 39533 RVA: 0x0017540C File Offset: 0x0017360C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoInteractChildQuestNodeCtxPb DoInteractChildQuestNode
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode)
				{
					return null;
				}
				return (DoInteractChildQuestNodeCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode);
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x06009A6E RID: 39534 RVA: 0x00175423 File Offset: 0x00173623
		// (set) Token: 0x06009A6F RID: 39535 RVA: 0x0017543C File Offset: 0x0017363C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupNodeActionCtxPb ActionGroupNodeAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction)
				{
					return null;
				}
				return (ActionGroupNodeActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction);
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x06009A70 RID: 39536 RVA: 0x00175453 File Offset: 0x00173653
		// (set) Token: 0x06009A71 RID: 39537 RVA: 0x0017546C File Offset: 0x0017366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantCtxPb ExploreSkillPullGiantAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction)
				{
					return null;
				}
				return (ExploreSkillPullGiantCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction);
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06009A72 RID: 39538 RVA: 0x00175483 File Offset: 0x00173683
		// (set) Token: 0x06009A73 RID: 39539 RVA: 0x0017549C File Offset: 0x0017369C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayCtxPb LevelPlay
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LevelPlay)
				{
					return null;
				}
				return (LevelPlayCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LevelPlay);
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x06009A74 RID: 39540 RVA: 0x001754B3 File Offset: 0x001736B3
		// (set) Token: 0x06009A75 RID: 39541 RVA: 0x001754CC File Offset: 0x001736CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionCtxPb GmLevelAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.GmLevelAction)
				{
					return null;
				}
				return (GmLevelActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.GmLevelAction);
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06009A76 RID: 39542 RVA: 0x001754E3 File Offset: 0x001736E3
		// (set) Token: 0x06009A77 RID: 39543 RVA: 0x001754FC File Offset: 0x001736FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentCreateCtxPb LifeCycleCreateAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction)
				{
					return null;
				}
				return (SceneItemLifeCycleComponentCreateCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction);
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06009A78 RID: 39544 RVA: 0x00175513 File Offset: 0x00173713
		// (set) Token: 0x06009A79 RID: 39545 RVA: 0x0017552C File Offset: 0x0017372C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentDestroyCtxPb LifeCycleDestroyAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction)
				{
					return null;
				}
				return (SceneItemLifeCycleComponentDestroyCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction);
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06009A7A RID: 39546 RVA: 0x00175543 File Offset: 0x00173743
		// (set) Token: 0x06009A7B RID: 39547 RVA: 0x0017555C File Offset: 0x0017375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionCtxPb FlowAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.FlowAction)
				{
					return null;
				}
				return (FlowActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.FlowAction);
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06009A7C RID: 39548 RVA: 0x00175573 File Offset: 0x00173773
		// (set) Token: 0x06009A7D RID: 39549 RVA: 0x0017558C File Offset: 0x0017378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestTerminateActionCtxPb DailyQuestTerminateAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction)
				{
					return null;
				}
				return (DailyQuestTerminateActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction);
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06009A7E RID: 39550 RVA: 0x001755A3 File Offset: 0x001737A3
		// (set) Token: 0x06009A7F RID: 39551 RVA: 0x001755BC File Offset: 0x001737BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveCtxPb EntityBeamReceiveAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction)
				{
					return null;
				}
				return (EntityBeamReceiveCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction);
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06009A80 RID: 39552 RVA: 0x001755D3 File Offset: 0x001737D3
		// (set) Token: 0x06009A81 RID: 39553 RVA: 0x001755EC File Offset: 0x001737EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupFailureActionCtxPb EntityGroupFailureAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction)
				{
					return null;
				}
				return (EntityGroupFailureActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction);
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06009A82 RID: 39554 RVA: 0x00175603 File Offset: 0x00173803
		// (set) Token: 0x06009A83 RID: 39555 RVA: 0x0017561C File Offset: 0x0017381C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeConditionActionCtxPb StateChangeConditionAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction)
				{
					return null;
				}
				return (StateChangeConditionActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction);
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06009A84 RID: 39556 RVA: 0x00175633 File Offset: 0x00173833
		// (set) Token: 0x06009A85 RID: 39557 RVA: 0x0017564C File Offset: 0x0017384C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartTeleportCtxPb FlowStartTeleport
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.FlowStartTeleport)
				{
					return null;
				}
				return (FlowStartTeleportCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.FlowStartTeleport);
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06009A86 RID: 39558 RVA: 0x00175663 File Offset: 0x00173863
		// (set) Token: 0x06009A87 RID: 39559 RVA: 0x0017567C File Offset: 0x0017387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstEscActionCtxPb LeaveInstEscAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction)
				{
					return null;
				}
				return (LeaveInstEscActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction);
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06009A88 RID: 39560 RVA: 0x00175693 File Offset: 0x00173893
		// (set) Token: 0x06009A89 RID: 39561 RVA: 0x001756AC File Offset: 0x001738AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleActiveCtxPb TrampleActive
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.TrampleActive)
				{
					return null;
				}
				return (TrampleActiveCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.TrampleActive);
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06009A8A RID: 39562 RVA: 0x001756C3 File Offset: 0x001738C3
		// (set) Token: 0x06009A8B RID: 39563 RVA: 0x001756DC File Offset: 0x001738DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleDeActiveCtxPb TrampleDeActive
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.TrampleDeActive)
				{
					return null;
				}
				return (TrampleDeActiveCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.TrampleDeActive);
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06009A8C RID: 39564 RVA: 0x001756F3 File Offset: 0x001738F3
		// (set) Token: 0x06009A8D RID: 39565 RVA: 0x0017570C File Offset: 0x0017390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuCompleteActionCtxPb RenjuCompleteAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction)
				{
					return null;
				}
				return (RenjuCompleteActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction);
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06009A8E RID: 39566 RVA: 0x00175723 File Offset: 0x00173923
		// (set) Token: 0x06009A8F RID: 39567 RVA: 0x0017573C File Offset: 0x0017393C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedActionCtxPb JigsawFoundationMatchedAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction)
				{
					return null;
				}
				return (JigsawFoundationMatchedActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction);
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06009A90 RID: 39568 RVA: 0x00175753 File Offset: 0x00173953
		// (set) Token: 0x06009A91 RID: 39569 RVA: 0x0017576C File Offset: 0x0017396C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationUnMatchedActionCtxPb JigsawFoundationUnMatchedActionCtx
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx)
				{
					return null;
				}
				return (JigsawFoundationUnMatchedActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx);
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06009A92 RID: 39570 RVA: 0x00175783 File Offset: 0x00173983
		// (set) Token: 0x06009A93 RID: 39571 RVA: 0x0017579C File Offset: 0x0017399C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointActionCtxPb HookLockPointAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.HookLockPointAction)
				{
					return null;
				}
				return (HookLockPointActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.HookLockPointAction);
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06009A94 RID: 39572 RVA: 0x001757B3 File Offset: 0x001739B3
		// (set) Token: 0x06009A95 RID: 39573 RVA: 0x001757CC File Offset: 0x001739CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerActionCtxPb ClientTriggerAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.ClientTriggerAction)
				{
					return null;
				}
				return (ClientTriggerActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.ClientTriggerAction);
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06009A96 RID: 39574 RVA: 0x001757E3 File Offset: 0x001739E3
		// (set) Token: 0x06009A97 RID: 39575 RVA: 0x001757FC File Offset: 0x001739FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomCtxPb ExploreSkillCustomAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction)
				{
					return null;
				}
				return (ExploreSkillCustomCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction);
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06009A98 RID: 39576 RVA: 0x00175813 File Offset: 0x00173A13
		// (set) Token: 0x06009A99 RID: 39577 RVA: 0x0017582C File Offset: 0x00173A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedConditionActionCtxPb JigsawFoundationMatchedConditionAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction)
				{
					return null;
				}
				return (JigsawFoundationMatchedConditionActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction);
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06009A9A RID: 39578 RVA: 0x00175843 File Offset: 0x00173A43
		// (set) Token: 0x06009A9B RID: 39579 RVA: 0x0017585C File Offset: 0x00173A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayDestroyActionCtxPb LevelPlayDestroyAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction)
				{
					return null;
				}
				return (LevelPlayDestroyActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction);
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06009A9C RID: 39580 RVA: 0x00175873 File Offset: 0x00173A73
		// (set) Token: 0x06009A9D RID: 39581 RVA: 0x0017588C File Offset: 0x00173A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerActionCtxPb TemplateSpawnerAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction)
				{
					return null;
				}
				return (TemplateSpawnerActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction);
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06009A9E RID: 39582 RVA: 0x001758A3 File Offset: 0x00173AA3
		// (set) Token: 0x06009A9F RID: 39583 RVA: 0x001758BC File Offset: 0x00173ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestDestroyActionCtxPb QuestDestroyAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.QuestDestroyAction)
				{
					return null;
				}
				return (QuestDestroyActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.QuestDestroyAction);
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06009AA0 RID: 39584 RVA: 0x001758D3 File Offset: 0x00173AD3
		// (set) Token: 0x06009AA1 RID: 39585 RVA: 0x001758EC File Offset: 0x00173AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionConditionEnterActionCtxPb CompositionConditionEnterAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction)
				{
					return null;
				}
				return (CompositionConditionEnterActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction);
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06009AA2 RID: 39586 RVA: 0x00175903 File Offset: 0x00173B03
		// (set) Token: 0x06009AA3 RID: 39587 RVA: 0x0017591C File Offset: 0x00173B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitPartCtxPb TargetGearHitPartCtxAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction)
				{
					return null;
				}
				return (TargetGearHitPartCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction);
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06009AA4 RID: 39588 RVA: 0x00175933 File Offset: 0x00173B33
		// (set) Token: 0x06009AA5 RID: 39589 RVA: 0x0017594C File Offset: 0x00173B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalFixCtxPb GlobalFix
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.GlobalFix)
				{
					return null;
				}
				return (GlobalFixCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.GlobalFix);
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06009AA6 RID: 39590 RVA: 0x00175963 File Offset: 0x00173B63
		// (set) Token: 0x06009AA7 RID: 39591 RVA: 0x0017597C File Offset: 0x00173B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StuckCheckCtxPb StuckCheckCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb)
				{
					return null;
				}
				return (StuckCheckCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb);
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x00175993 File Offset: 0x00173B93
		// (set) Token: 0x06009AA9 RID: 39593 RVA: 0x001759AC File Offset: 0x00173BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAfterConditionActionCtxPb AfterConditionActionCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb)
				{
					return null;
				}
				return (EntityAfterConditionActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb);
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x001759C3 File Offset: 0x00173BC3
		// (set) Token: 0x06009AAB RID: 39595 RVA: 0x001759DC File Offset: 0x00173BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderCtxPb MotorSliderCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb)
				{
					return null;
				}
				return (MotorSliderCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb);
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06009AAC RID: 39596 RVA: 0x001759F3 File Offset: 0x00173BF3
		// (set) Token: 0x06009AAD RID: 39597 RVA: 0x00175A0C File Offset: 0x00173C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayActionCtxPb RollBlockGamePlayActionCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb)
				{
					return null;
				}
				return (RollBlockGamePlayActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb);
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x06009AAE RID: 39598 RVA: 0x00175A23 File Offset: 0x00173C23
		// (set) Token: 0x06009AAF RID: 39599 RVA: 0x00175A3C File Offset: 0x00173C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferCtxPb TransferCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.TransferCtxPb)
				{
					return null;
				}
				return (TransferCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.TransferCtxPb);
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06009AB0 RID: 39600 RVA: 0x00175A53 File Offset: 0x00173C53
		// (set) Token: 0x06009AB1 RID: 39601 RVA: 0x00175A6C File Offset: 0x00173C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityRewardCtxPb DynamicEntityRewardCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb)
				{
					return null;
				}
				return (DynamicEntityRewardCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb);
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06009AB2 RID: 39602 RVA: 0x00175A83 File Offset: 0x00173C83
		// (set) Token: 0x06009AB3 RID: 39603 RVA: 0x00175A9C File Offset: 0x00173C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerActionCtxPb BeamCastHitPlayerActionCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb)
				{
					return null;
				}
				return (BeamCastHitPlayerActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb);
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06009AB4 RID: 39604 RVA: 0x00175AB3 File Offset: 0x00173CB3
		// (set) Token: 0x06009AB5 RID: 39605 RVA: 0x00175ACC File Offset: 0x00173CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionCtxPb ExploreSkillAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.ExploreSkillAction)
				{
					return null;
				}
				return (ExploreSkillActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.ExploreSkillAction);
			}
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06009AB6 RID: 39606 RVA: 0x00175AE3 File Offset: 0x00173CE3
		// (set) Token: 0x06009AB7 RID: 39607 RVA: 0x00175AFC File Offset: 0x00173CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeCtxPb PollutionRangeAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.PollutionRangeAction)
				{
					return null;
				}
				return (PlayEnterOrExitPollutionRangeCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.PollutionRangeAction);
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06009AB8 RID: 39608 RVA: 0x00175B13 File Offset: 0x00173D13
		// (set) Token: 0x06009AB9 RID: 39609 RVA: 0x00175B2C File Offset: 0x00173D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityQuickHackSkillCtxPb EntityQuickHackSkillAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction)
				{
					return null;
				}
				return (EntityQuickHackSkillCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction);
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x00175B43 File Offset: 0x00173D43
		// (set) Token: 0x06009ABB RID: 39611 RVA: 0x00175B5C File Offset: 0x00173D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActiveActionCtxPb RecallQuestActiveAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction)
				{
					return null;
				}
				return (RecallQuestActiveActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction);
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06009ABC RID: 39612 RVA: 0x00175B73 File Offset: 0x00173D73
		// (set) Token: 0x06009ABD RID: 39613 RVA: 0x00175B8C File Offset: 0x00173D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestAcceptActionCtxPb RecallQuestAcceptAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction)
				{
					return null;
				}
				return (RecallQuestAcceptActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction);
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06009ABE RID: 39614 RVA: 0x00175BA3 File Offset: 0x00173DA3
		// (set) Token: 0x06009ABF RID: 39615 RVA: 0x00175BBC File Offset: 0x00173DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionCtxPb RecallQuestFinishAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction)
				{
					return null;
				}
				return (RecallQuestFinishActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction);
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06009AC0 RID: 39616 RVA: 0x00175BD3 File Offset: 0x00173DD3
		// (set) Token: 0x06009AC1 RID: 39617 RVA: 0x00175BEC File Offset: 0x00173DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestDestroyActionCtxPb RecallQuestDestroyAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction)
				{
					return null;
				}
				return (RecallQuestDestroyActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction);
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06009AC2 RID: 39618 RVA: 0x00175C03 File Offset: 0x00173E03
		// (set) Token: 0x06009AC3 RID: 39619 RVA: 0x00175C1F File Offset: 0x00173E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdDebugEnterActionCtxPb EdDebugEnterAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction)
				{
					return null;
				}
				return (EdDebugEnterActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction);
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06009AC4 RID: 39620 RVA: 0x00175C39 File Offset: 0x00173E39
		// (set) Token: 0x06009AC5 RID: 39621 RVA: 0x00175C55 File Offset: 0x00173E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CasketTriggerCtxPb CasketTrigger
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.CasketTrigger)
				{
					return null;
				}
				return (CasketTriggerCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.CasketTrigger);
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06009AC6 RID: 39622 RVA: 0x00175C6F File Offset: 0x00173E6F
		// (set) Token: 0x06009AC7 RID: 39623 RVA: 0x00175C8B File Offset: 0x00173E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationOperateActionCtxPb FoundationOperateAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.FoundationOperateAction)
				{
					return null;
				}
				return (FoundationOperateActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.FoundationOperateAction);
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06009AC8 RID: 39624 RVA: 0x00175CA5 File Offset: 0x00173EA5
		// (set) Token: 0x06009AC9 RID: 39625 RVA: 0x00175CC1 File Offset: 0x00173EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearActionByHitTypeCtxPb TargetGearActionByHitTypeAction
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction)
				{
					return null;
				}
				return (TargetGearActionByHitTypeCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction);
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06009ACA RID: 39626 RVA: 0x00175CDB File Offset: 0x00173EDB
		// (set) Token: 0x06009ACB RID: 39627 RVA: 0x00175CF7 File Offset: 0x00173EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractActionCtxPb LongPressInteractActionCtxPb
		{
			get
			{
				if (this.ctxInfoCase_ != GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb)
				{
					return null;
				}
				return (LongPressInteractActionCtxPb)this.ctxInfo_;
			}
			set
			{
				this.ctxInfo_ = value;
				this.ctxInfoCase_ = ((value == null) ? GameCtxPb.CtxInfoOneofCase.None : GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb);
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06009ACC RID: 39628 RVA: 0x00175D11 File Offset: 0x00173F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb.CtxInfoOneofCase CtxInfoCase
		{
			get
			{
				return this.ctxInfoCase_;
			}
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x00175D19 File Offset: 0x00173F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCtxInfo()
		{
			this.ctxInfoCase_ = GameCtxPb.CtxInfoOneofCase.None;
			this.ctxInfo_ = null;
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x00175D29 File Offset: 0x00173F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameCtxPb);
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x00175D38 File Offset: 0x00173F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameCtxPb other)
		{
			return other != null && (other == this || (this.CtxType == other.CtxType && object.Equals(this.BehaviorTree, other.BehaviorTree) && object.Equals(this.Entity, other.Entity) && object.Equals(this.NormalInteract, other.NormalInteract) && object.Equals(this.DynamicInteract, other.DynamicInteract) && object.Equals(this.RandomInteract, other.RandomInteract) && object.Equals(this.StateChangeAction, other.StateChangeAction) && object.Equals(this.EntityGroupAction, other.EntityGroupAction) && object.Equals(this.EntityTrigger, other.EntityTrigger) && object.Equals(this.EntityLeaveTriggerCtx, other.EntityLeaveTriggerCtx) && object.Equals(this.EntityDestructible, other.EntityDestructible) && object.Equals(this.EntityTimelineTrack, other.EntityTimelineTrack) && object.Equals(this.LevelPlayOpenAction, other.LevelPlayOpenAction) && object.Equals(this.LevelPlayRewardAction, other.LevelPlayRewardAction) && object.Equals(this.QuestActiveAction, other.QuestActiveAction) && object.Equals(this.QuestAcceptAction, other.QuestAcceptAction) && object.Equals(this.QuestFinishAction, other.QuestFinishAction) && object.Equals(this.ChildQuestNodeEnterAction, other.ChildQuestNodeEnterAction) && object.Equals(this.ChildQuestNodeFinishAction, other.ChildQuestNodeFinishAction) && object.Equals(this.SuccessNodeAction, other.SuccessNodeAction) && object.Equals(this.FailedNodeAction, other.FailedNodeAction) && object.Equals(this.CompositionEnterAction, other.CompositionEnterAction) && object.Equals(this.EntityConditionListeningAction, other.EntityConditionListeningAction) && object.Equals(this.PlayFlowChildQuestNode, other.PlayFlowChildQuestNode) && object.Equals(this.HandInItemChildQuestNode, other.HandInItemChildQuestNode) && object.Equals(this.DoInteractChildQuestNode, other.DoInteractChildQuestNode) && object.Equals(this.ActionGroupNodeAction, other.ActionGroupNodeAction) && object.Equals(this.ExploreSkillPullGiantAction, other.ExploreSkillPullGiantAction) && object.Equals(this.LevelPlay, other.LevelPlay) && object.Equals(this.GmLevelAction, other.GmLevelAction) && object.Equals(this.LifeCycleCreateAction, other.LifeCycleCreateAction) && object.Equals(this.LifeCycleDestroyAction, other.LifeCycleDestroyAction) && object.Equals(this.FlowAction, other.FlowAction) && object.Equals(this.DailyQuestTerminateAction, other.DailyQuestTerminateAction) && object.Equals(this.EntityBeamReceiveAction, other.EntityBeamReceiveAction) && object.Equals(this.EntityGroupFailureAction, other.EntityGroupFailureAction) && object.Equals(this.StateChangeConditionAction, other.StateChangeConditionAction) && object.Equals(this.FlowStartTeleport, other.FlowStartTeleport) && object.Equals(this.LeaveInstEscAction, other.LeaveInstEscAction) && object.Equals(this.TrampleActive, other.TrampleActive) && object.Equals(this.TrampleDeActive, other.TrampleDeActive) && object.Equals(this.RenjuCompleteAction, other.RenjuCompleteAction) && object.Equals(this.JigsawFoundationMatchedAction, other.JigsawFoundationMatchedAction) && object.Equals(this.JigsawFoundationUnMatchedActionCtx, other.JigsawFoundationUnMatchedActionCtx) && object.Equals(this.HookLockPointAction, other.HookLockPointAction) && object.Equals(this.ClientTriggerAction, other.ClientTriggerAction) && object.Equals(this.ExploreSkillCustomAction, other.ExploreSkillCustomAction) && object.Equals(this.JigsawFoundationMatchedConditionAction, other.JigsawFoundationMatchedConditionAction) && object.Equals(this.LevelPlayDestroyAction, other.LevelPlayDestroyAction) && object.Equals(this.TemplateSpawnerAction, other.TemplateSpawnerAction) && object.Equals(this.QuestDestroyAction, other.QuestDestroyAction) && object.Equals(this.CompositionConditionEnterAction, other.CompositionConditionEnterAction) && object.Equals(this.TargetGearHitPartCtxAction, other.TargetGearHitPartCtxAction) && object.Equals(this.GlobalFix, other.GlobalFix) && object.Equals(this.StuckCheckCtxPb, other.StuckCheckCtxPb) && object.Equals(this.AfterConditionActionCtxPb, other.AfterConditionActionCtxPb) && object.Equals(this.MotorSliderCtxPb, other.MotorSliderCtxPb) && object.Equals(this.RollBlockGamePlayActionCtxPb, other.RollBlockGamePlayActionCtxPb) && object.Equals(this.TransferCtxPb, other.TransferCtxPb) && object.Equals(this.DynamicEntityRewardCtxPb, other.DynamicEntityRewardCtxPb) && object.Equals(this.BeamCastHitPlayerActionCtxPb, other.BeamCastHitPlayerActionCtxPb) && object.Equals(this.ExploreSkillAction, other.ExploreSkillAction) && object.Equals(this.PollutionRangeAction, other.PollutionRangeAction) && object.Equals(this.EntityQuickHackSkillAction, other.EntityQuickHackSkillAction) && object.Equals(this.RecallQuestActiveAction, other.RecallQuestActiveAction) && object.Equals(this.RecallQuestAcceptAction, other.RecallQuestAcceptAction) && object.Equals(this.RecallQuestFinishAction, other.RecallQuestFinishAction) && object.Equals(this.RecallQuestDestroyAction, other.RecallQuestDestroyAction) && object.Equals(this.EdDebugEnterAction, other.EdDebugEnterAction) && object.Equals(this.CasketTrigger, other.CasketTrigger) && object.Equals(this.FoundationOperateAction, other.FoundationOperateAction) && object.Equals(this.TargetGearActionByHitTypeAction, other.TargetGearActionByHitTypeAction) && object.Equals(this.LongPressInteractActionCtxPb, other.LongPressInteractActionCtxPb) && this.CtxInfoCase == other.CtxInfoCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x0017636C File Offset: 0x0017456C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CtxType != GameCtxType.BehaviorTree)
			{
				num ^= this.CtxType.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BehaviorTree)
			{
				num ^= this.BehaviorTree.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.Entity)
			{
				num ^= this.Entity.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.NormalInteract)
			{
				num ^= this.NormalInteract.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicInteract)
			{
				num ^= this.DynamicInteract.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RandomInteract)
			{
				num ^= this.RandomInteract.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeAction)
			{
				num ^= this.StateChangeAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupAction)
			{
				num ^= this.EntityGroupAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTrigger)
			{
				num ^= this.EntityTrigger.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx)
			{
				num ^= this.EntityLeaveTriggerCtx.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityDestructible)
			{
				num ^= this.EntityDestructible.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack)
			{
				num ^= this.EntityTimelineTrack.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction)
			{
				num ^= this.LevelPlayOpenAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction)
			{
				num ^= this.LevelPlayRewardAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestActiveAction)
			{
				num ^= this.QuestActiveAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestAcceptAction)
			{
				num ^= this.QuestAcceptAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestFinishAction)
			{
				num ^= this.QuestFinishAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction)
			{
				num ^= this.ChildQuestNodeEnterAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction)
			{
				num ^= this.ChildQuestNodeFinishAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.SuccessNodeAction)
			{
				num ^= this.SuccessNodeAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FailedNodeAction)
			{
				num ^= this.FailedNodeAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionEnterAction)
			{
				num ^= this.CompositionEnterAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction)
			{
				num ^= this.EntityConditionListeningAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode)
			{
				num ^= this.PlayFlowChildQuestNode.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode)
			{
				num ^= this.HandInItemChildQuestNode.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode)
			{
				num ^= this.DoInteractChildQuestNode.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction)
			{
				num ^= this.ActionGroupNodeAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction)
			{
				num ^= this.ExploreSkillPullGiantAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlay)
			{
				num ^= this.LevelPlay.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GmLevelAction)
			{
				num ^= this.GmLevelAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction)
			{
				num ^= this.LifeCycleCreateAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction)
			{
				num ^= this.LifeCycleDestroyAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowAction)
			{
				num ^= this.FlowAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction)
			{
				num ^= this.DailyQuestTerminateAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction)
			{
				num ^= this.EntityBeamReceiveAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction)
			{
				num ^= this.EntityGroupFailureAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction)
			{
				num ^= this.StateChangeConditionAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowStartTeleport)
			{
				num ^= this.FlowStartTeleport.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction)
			{
				num ^= this.LeaveInstEscAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleActive)
			{
				num ^= this.TrampleActive.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleDeActive)
			{
				num ^= this.TrampleDeActive.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction)
			{
				num ^= this.RenjuCompleteAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction)
			{
				num ^= this.JigsawFoundationMatchedAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx)
			{
				num ^= this.JigsawFoundationUnMatchedActionCtx.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HookLockPointAction)
			{
				num ^= this.HookLockPointAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ClientTriggerAction)
			{
				num ^= this.ClientTriggerAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction)
			{
				num ^= this.ExploreSkillCustomAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction)
			{
				num ^= this.JigsawFoundationMatchedConditionAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction)
			{
				num ^= this.LevelPlayDestroyAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction)
			{
				num ^= this.TemplateSpawnerAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestDestroyAction)
			{
				num ^= this.QuestDestroyAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction)
			{
				num ^= this.CompositionConditionEnterAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction)
			{
				num ^= this.TargetGearHitPartCtxAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GlobalFix)
			{
				num ^= this.GlobalFix.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb)
			{
				num ^= this.StuckCheckCtxPb.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb)
			{
				num ^= this.AfterConditionActionCtxPb.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb)
			{
				num ^= this.MotorSliderCtxPb.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb)
			{
				num ^= this.RollBlockGamePlayActionCtxPb.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TransferCtxPb)
			{
				num ^= this.TransferCtxPb.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb)
			{
				num ^= this.DynamicEntityRewardCtxPb.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb)
			{
				num ^= this.BeamCastHitPlayerActionCtxPb.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillAction)
			{
				num ^= this.ExploreSkillAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PollutionRangeAction)
			{
				num ^= this.PollutionRangeAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction)
			{
				num ^= this.EntityQuickHackSkillAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction)
			{
				num ^= this.RecallQuestActiveAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction)
			{
				num ^= this.RecallQuestAcceptAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction)
			{
				num ^= this.RecallQuestFinishAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction)
			{
				num ^= this.RecallQuestDestroyAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction)
			{
				num ^= this.EdDebugEnterAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CasketTrigger)
			{
				num ^= this.CasketTrigger.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FoundationOperateAction)
			{
				num ^= this.FoundationOperateAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction)
			{
				num ^= this.TargetGearActionByHitTypeAction.GetHashCode();
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb)
			{
				num ^= this.LongPressInteractActionCtxPb.GetHashCode();
			}
			num ^= (int)this.ctxInfoCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x00176A82 File Offset: 0x00174C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x00176A8F File Offset: 0x00174C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x00176A98 File Offset: 0x00174C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CtxType != GameCtxType.BehaviorTree)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.CtxType);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BehaviorTree)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BehaviorTree);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.Entity)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Entity);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.NormalInteract)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.NormalInteract);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicInteract)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DynamicInteract);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RandomInteract)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RandomInteract);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeAction)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.StateChangeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupAction)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.EntityGroupAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTrigger)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.EntityTrigger);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EntityLeaveTriggerCtx);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityDestructible)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.EntityDestructible);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EntityTimelineTrack);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.LevelPlayOpenAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.LevelPlayRewardAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestActiveAction)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.QuestActiveAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestAcceptAction)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.QuestAcceptAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestFinishAction)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.QuestFinishAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.ChildQuestNodeEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.ChildQuestNodeFinishAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.SuccessNodeAction)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.SuccessNodeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FailedNodeAction)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.FailedNodeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionEnterAction)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.CompositionEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.EntityConditionListeningAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.PlayFlowChildQuestNode);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.HandInItemChildQuestNode);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.DoInteractChildQuestNode);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.ActionGroupNodeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.ExploreSkillPullGiantAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlay)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.LevelPlay);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GmLevelAction)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.GmLevelAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.LifeCycleCreateAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.LifeCycleDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowAction)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.FlowAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.DailyQuestTerminateAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.EntityBeamReceiveAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.EntityGroupFailureAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.StateChangeConditionAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowStartTeleport)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.FlowStartTeleport);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.LeaveInstEscAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleActive)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.TrampleActive);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleDeActive)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.TrampleDeActive);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.RenjuCompleteAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.JigsawFoundationMatchedAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.JigsawFoundationUnMatchedActionCtx);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HookLockPointAction)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.HookLockPointAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ClientTriggerAction)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.ClientTriggerAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.ExploreSkillCustomAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction)
			{
				output.WriteRawTag(130, 3);
				output.WriteMessage(this.JigsawFoundationMatchedConditionAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.LevelPlayDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.TemplateSpawnerAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestDestroyAction)
			{
				output.WriteRawTag(154, 3);
				output.WriteMessage(this.QuestDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction)
			{
				output.WriteRawTag(162, 3);
				output.WriteMessage(this.CompositionConditionEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction)
			{
				output.WriteRawTag(170, 3);
				output.WriteMessage(this.TargetGearHitPartCtxAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GlobalFix)
			{
				output.WriteRawTag(178, 3);
				output.WriteMessage(this.GlobalFix);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.StuckCheckCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.AfterConditionActionCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.MotorSliderCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.RollBlockGamePlayActionCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TransferCtxPb)
			{
				output.WriteRawTag(226, 3);
				output.WriteMessage(this.TransferCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.DynamicEntityRewardCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.BeamCastHitPlayerActionCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillAction)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.ExploreSkillAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PollutionRangeAction)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.PollutionRangeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.EntityQuickHackSkillAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.RecallQuestActiveAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction)
			{
				output.WriteRawTag(154, 4);
				output.WriteMessage(this.RecallQuestAcceptAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction)
			{
				output.WriteRawTag(162, 4);
				output.WriteMessage(this.RecallQuestFinishAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.RecallQuestDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction)
			{
				output.WriteRawTag(202, 212, 1);
				output.WriteMessage(this.EdDebugEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CasketTrigger)
			{
				output.WriteRawTag(234, 218, 1);
				output.WriteMessage(this.CasketTrigger);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FoundationOperateAction)
			{
				output.WriteRawTag(242, 218, 1);
				output.WriteMessage(this.FoundationOperateAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction)
			{
				output.WriteRawTag(170, 231, 1);
				output.WriteMessage(this.TargetGearActionByHitTypeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb)
			{
				output.WriteRawTag(178, 231, 1);
				output.WriteMessage(this.LongPressInteractActionCtxPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x00177450 File Offset: 0x00175650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CtxType != GameCtxType.BehaviorTree)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CtxType);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BehaviorTree)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BehaviorTree);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.Entity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entity);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.NormalInteract)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NormalInteract);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicInteract)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DynamicInteract);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RandomInteract)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RandomInteract);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StateChangeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityGroupAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTrigger)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityTrigger);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityLeaveTriggerCtx);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityDestructible)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityDestructible);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityTimelineTrack);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelPlayOpenAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelPlayRewardAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestActiveAction)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QuestActiveAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestAcceptAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.QuestAcceptAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestFinishAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.QuestFinishAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChildQuestNodeEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChildQuestNodeFinishAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.SuccessNodeAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SuccessNodeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FailedNodeAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FailedNodeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionEnterAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CompositionEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityConditionListeningAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayFlowChildQuestNode);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HandInItemChildQuestNode);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DoInteractChildQuestNode);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionGroupNodeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExploreSkillPullGiantAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlay)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LevelPlay);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GmLevelAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GmLevelAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LifeCycleCreateAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LifeCycleDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FlowAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DailyQuestTerminateAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityBeamReceiveAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityGroupFailureAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.StateChangeConditionAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowStartTeleport)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FlowStartTeleport);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LeaveInstEscAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleActive)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TrampleActive);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleDeActive)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TrampleDeActive);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RenjuCompleteAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JigsawFoundationMatchedAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JigsawFoundationUnMatchedActionCtx);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HookLockPointAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HookLockPointAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ClientTriggerAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ClientTriggerAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExploreSkillCustomAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JigsawFoundationMatchedConditionAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LevelPlayDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TemplateSpawnerAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestDestroyAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.QuestDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CompositionConditionEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TargetGearHitPartCtxAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GlobalFix)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GlobalFix);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.StuckCheckCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AfterConditionActionCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorSliderCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RollBlockGamePlayActionCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TransferCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TransferCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DynamicEntityRewardCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BeamCastHitPlayerActionCtxPb);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExploreSkillAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PollutionRangeAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PollutionRangeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityQuickHackSkillAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RecallQuestActiveAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RecallQuestAcceptAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RecallQuestFinishAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RecallQuestDestroyAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.EdDebugEnterAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CasketTrigger)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.CasketTrigger);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FoundationOperateAction)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.FoundationOperateAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.TargetGearActionByHitTypeAction);
			}
			if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.LongPressInteractActionCtxPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x00177BE8 File Offset: 0x00175DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CtxType != GameCtxType.BehaviorTree)
			{
				this.CtxType = other.CtxType;
			}
			GameCtxPb.CtxInfoOneofCase ctxInfoCase = other.CtxInfoCase;
			if (ctxInfoCase <= GameCtxPb.CtxInfoOneofCase.CasketTrigger)
			{
				switch (ctxInfoCase)
				{
				case GameCtxPb.CtxInfoOneofCase.BehaviorTree:
					if (this.BehaviorTree == null)
					{
						this.BehaviorTree = new BehaviorTreeCtxPb();
					}
					this.BehaviorTree.MergeFrom(other.BehaviorTree);
					break;
				case GameCtxPb.CtxInfoOneofCase.Entity:
					if (this.Entity == null)
					{
						this.Entity = new EntityCtxPb();
					}
					this.Entity.MergeFrom(other.Entity);
					break;
				case GameCtxPb.CtxInfoOneofCase.NormalInteract:
					if (this.NormalInteract == null)
					{
						this.NormalInteract = new NormalInteractCtxPb();
					}
					this.NormalInteract.MergeFrom(other.NormalInteract);
					break;
				case GameCtxPb.CtxInfoOneofCase.DynamicInteract:
					if (this.DynamicInteract == null)
					{
						this.DynamicInteract = new DynamicInteractCtxPb();
					}
					this.DynamicInteract.MergeFrom(other.DynamicInteract);
					break;
				case GameCtxPb.CtxInfoOneofCase.RandomInteract:
					if (this.RandomInteract == null)
					{
						this.RandomInteract = new RandomInteractCtxPb();
					}
					this.RandomInteract.MergeFrom(other.RandomInteract);
					break;
				case GameCtxPb.CtxInfoOneofCase.StateChangeAction:
					if (this.StateChangeAction == null)
					{
						this.StateChangeAction = new StateChangeActionCtxPb();
					}
					this.StateChangeAction.MergeFrom(other.StateChangeAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityGroupAction:
					if (this.EntityGroupAction == null)
					{
						this.EntityGroupAction = new EntityGroupActionCtxPb();
					}
					this.EntityGroupAction.MergeFrom(other.EntityGroupAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityTrigger:
					if (this.EntityTrigger == null)
					{
						this.EntityTrigger = new EntityTriggerCtxPb();
					}
					this.EntityTrigger.MergeFrom(other.EntityTrigger);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx:
					if (this.EntityLeaveTriggerCtx == null)
					{
						this.EntityLeaveTriggerCtx = new EntityLeaveTriggerCtxPb();
					}
					this.EntityLeaveTriggerCtx.MergeFrom(other.EntityLeaveTriggerCtx);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityDestructible:
					if (this.EntityDestructible == null)
					{
						this.EntityDestructible = new EntityDestructibleCtxPb();
					}
					this.EntityDestructible.MergeFrom(other.EntityDestructible);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack:
					if (this.EntityTimelineTrack == null)
					{
						this.EntityTimelineTrack = new EntityTimelineTrackCtxPb();
					}
					this.EntityTimelineTrack.MergeFrom(other.EntityTimelineTrack);
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction:
					if (this.LevelPlayOpenAction == null)
					{
						this.LevelPlayOpenAction = new LevelPlayOpenActionCtxPb();
					}
					this.LevelPlayOpenAction.MergeFrom(other.LevelPlayOpenAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction:
					if (this.LevelPlayRewardAction == null)
					{
						this.LevelPlayRewardAction = new LevelPlayRewardActionCtxPb();
					}
					this.LevelPlayRewardAction.MergeFrom(other.LevelPlayRewardAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestActiveAction:
					if (this.QuestActiveAction == null)
					{
						this.QuestActiveAction = new QuestActiveActionCtxPb();
					}
					this.QuestActiveAction.MergeFrom(other.QuestActiveAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestAcceptAction:
					if (this.QuestAcceptAction == null)
					{
						this.QuestAcceptAction = new QuestAcceptActionCtxPb();
					}
					this.QuestAcceptAction.MergeFrom(other.QuestAcceptAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestFinishAction:
					if (this.QuestFinishAction == null)
					{
						this.QuestFinishAction = new QuestFinishActionCtxPb();
					}
					this.QuestFinishAction.MergeFrom(other.QuestFinishAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction:
					if (this.ChildQuestNodeEnterAction == null)
					{
						this.ChildQuestNodeEnterAction = new ChildQuestNodeEnterActionCtxPb();
					}
					this.ChildQuestNodeEnterAction.MergeFrom(other.ChildQuestNodeEnterAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction:
					if (this.ChildQuestNodeFinishAction == null)
					{
						this.ChildQuestNodeFinishAction = new ChildQuestNodeFinishActionCtxPb();
					}
					this.ChildQuestNodeFinishAction.MergeFrom(other.ChildQuestNodeFinishAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.SuccessNodeAction:
					if (this.SuccessNodeAction == null)
					{
						this.SuccessNodeAction = new SuccessNodeActionCtxPb();
					}
					this.SuccessNodeAction.MergeFrom(other.SuccessNodeAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.FailedNodeAction:
					if (this.FailedNodeAction == null)
					{
						this.FailedNodeAction = new FailedNodeActionCtxPb();
					}
					this.FailedNodeAction.MergeFrom(other.FailedNodeAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.CompositionEnterAction:
					if (this.CompositionEnterAction == null)
					{
						this.CompositionEnterAction = new CompositionEnterActionCtxPb();
					}
					this.CompositionEnterAction.MergeFrom(other.CompositionEnterAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction:
					if (this.EntityConditionListeningAction == null)
					{
						this.EntityConditionListeningAction = new EntityConditionListeningActionCtxPb();
					}
					this.EntityConditionListeningAction.MergeFrom(other.EntityConditionListeningAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode:
					if (this.PlayFlowChildQuestNode == null)
					{
						this.PlayFlowChildQuestNode = new PlayFlowChildQuestNodeCtxPb();
					}
					this.PlayFlowChildQuestNode.MergeFrom(other.PlayFlowChildQuestNode);
					break;
				case GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode:
					if (this.HandInItemChildQuestNode == null)
					{
						this.HandInItemChildQuestNode = new HandInItemChildQuestNodeCtxPb();
					}
					this.HandInItemChildQuestNode.MergeFrom(other.HandInItemChildQuestNode);
					break;
				case GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode:
					if (this.DoInteractChildQuestNode == null)
					{
						this.DoInteractChildQuestNode = new DoInteractChildQuestNodeCtxPb();
					}
					this.DoInteractChildQuestNode.MergeFrom(other.DoInteractChildQuestNode);
					break;
				case GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction:
					if (this.ActionGroupNodeAction == null)
					{
						this.ActionGroupNodeAction = new ActionGroupNodeActionCtxPb();
					}
					this.ActionGroupNodeAction.MergeFrom(other.ActionGroupNodeAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction:
					if (this.ExploreSkillPullGiantAction == null)
					{
						this.ExploreSkillPullGiantAction = new ExploreSkillPullGiantCtxPb();
					}
					this.ExploreSkillPullGiantAction.MergeFrom(other.ExploreSkillPullGiantAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlay:
					if (this.LevelPlay == null)
					{
						this.LevelPlay = new LevelPlayCtxPb();
					}
					this.LevelPlay.MergeFrom(other.LevelPlay);
					break;
				case GameCtxPb.CtxInfoOneofCase.GmLevelAction:
					if (this.GmLevelAction == null)
					{
						this.GmLevelAction = new GmLevelActionCtxPb();
					}
					this.GmLevelAction.MergeFrom(other.GmLevelAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction:
					if (this.LifeCycleCreateAction == null)
					{
						this.LifeCycleCreateAction = new SceneItemLifeCycleComponentCreateCtxPb();
					}
					this.LifeCycleCreateAction.MergeFrom(other.LifeCycleCreateAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction:
					if (this.LifeCycleDestroyAction == null)
					{
						this.LifeCycleDestroyAction = new SceneItemLifeCycleComponentDestroyCtxPb();
					}
					this.LifeCycleDestroyAction.MergeFrom(other.LifeCycleDestroyAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.FlowAction:
					if (this.FlowAction == null)
					{
						this.FlowAction = new FlowActionCtxPb();
					}
					this.FlowAction.MergeFrom(other.FlowAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction:
					if (this.DailyQuestTerminateAction == null)
					{
						this.DailyQuestTerminateAction = new DailyQuestTerminateActionCtxPb();
					}
					this.DailyQuestTerminateAction.MergeFrom(other.DailyQuestTerminateAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction:
					if (this.EntityBeamReceiveAction == null)
					{
						this.EntityBeamReceiveAction = new EntityBeamReceiveCtxPb();
					}
					this.EntityBeamReceiveAction.MergeFrom(other.EntityBeamReceiveAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction:
					if (this.EntityGroupFailureAction == null)
					{
						this.EntityGroupFailureAction = new EntityGroupFailureActionCtxPb();
					}
					this.EntityGroupFailureAction.MergeFrom(other.EntityGroupFailureAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction:
					if (this.StateChangeConditionAction == null)
					{
						this.StateChangeConditionAction = new StateChangeConditionActionCtxPb();
					}
					this.StateChangeConditionAction.MergeFrom(other.StateChangeConditionAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.FlowStartTeleport:
					if (this.FlowStartTeleport == null)
					{
						this.FlowStartTeleport = new FlowStartTeleportCtxPb();
					}
					this.FlowStartTeleport.MergeFrom(other.FlowStartTeleport);
					break;
				case GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction:
					if (this.LeaveInstEscAction == null)
					{
						this.LeaveInstEscAction = new LeaveInstEscActionCtxPb();
					}
					this.LeaveInstEscAction.MergeFrom(other.LeaveInstEscAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.TrampleActive:
					if (this.TrampleActive == null)
					{
						this.TrampleActive = new TrampleActiveCtxPb();
					}
					this.TrampleActive.MergeFrom(other.TrampleActive);
					break;
				case GameCtxPb.CtxInfoOneofCase.TrampleDeActive:
					if (this.TrampleDeActive == null)
					{
						this.TrampleDeActive = new TrampleDeActiveCtxPb();
					}
					this.TrampleDeActive.MergeFrom(other.TrampleDeActive);
					break;
				case GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction:
					if (this.RenjuCompleteAction == null)
					{
						this.RenjuCompleteAction = new RenjuCompleteActionCtxPb();
					}
					this.RenjuCompleteAction.MergeFrom(other.RenjuCompleteAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction:
					if (this.JigsawFoundationMatchedAction == null)
					{
						this.JigsawFoundationMatchedAction = new JigsawFoundationMatchedActionCtxPb();
					}
					this.JigsawFoundationMatchedAction.MergeFrom(other.JigsawFoundationMatchedAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx:
					if (this.JigsawFoundationUnMatchedActionCtx == null)
					{
						this.JigsawFoundationUnMatchedActionCtx = new JigsawFoundationUnMatchedActionCtxPb();
					}
					this.JigsawFoundationUnMatchedActionCtx.MergeFrom(other.JigsawFoundationUnMatchedActionCtx);
					break;
				case GameCtxPb.CtxInfoOneofCase.HookLockPointAction:
					if (this.HookLockPointAction == null)
					{
						this.HookLockPointAction = new HookLockPointActionCtxPb();
					}
					this.HookLockPointAction.MergeFrom(other.HookLockPointAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.ClientTriggerAction:
					if (this.ClientTriggerAction == null)
					{
						this.ClientTriggerAction = new ClientTriggerActionCtxPb();
					}
					this.ClientTriggerAction.MergeFrom(other.ClientTriggerAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction:
					if (this.ExploreSkillCustomAction == null)
					{
						this.ExploreSkillCustomAction = new ExploreSkillCustomCtxPb();
					}
					this.ExploreSkillCustomAction.MergeFrom(other.ExploreSkillCustomAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction:
					if (this.JigsawFoundationMatchedConditionAction == null)
					{
						this.JigsawFoundationMatchedConditionAction = new JigsawFoundationMatchedConditionActionCtxPb();
					}
					this.JigsawFoundationMatchedConditionAction.MergeFrom(other.JigsawFoundationMatchedConditionAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction:
					if (this.LevelPlayDestroyAction == null)
					{
						this.LevelPlayDestroyAction = new LevelPlayDestroyActionCtxPb();
					}
					this.LevelPlayDestroyAction.MergeFrom(other.LevelPlayDestroyAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction:
					if (this.TemplateSpawnerAction == null)
					{
						this.TemplateSpawnerAction = new TemplateSpawnerActionCtxPb();
					}
					this.TemplateSpawnerAction.MergeFrom(other.TemplateSpawnerAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.QuestDestroyAction:
					if (this.QuestDestroyAction == null)
					{
						this.QuestDestroyAction = new QuestDestroyActionCtxPb();
					}
					this.QuestDestroyAction.MergeFrom(other.QuestDestroyAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction:
					if (this.CompositionConditionEnterAction == null)
					{
						this.CompositionConditionEnterAction = new CompositionConditionEnterActionCtxPb();
					}
					this.CompositionConditionEnterAction.MergeFrom(other.CompositionConditionEnterAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction:
					if (this.TargetGearHitPartCtxAction == null)
					{
						this.TargetGearHitPartCtxAction = new TargetGearHitPartCtxPb();
					}
					this.TargetGearHitPartCtxAction.MergeFrom(other.TargetGearHitPartCtxAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.GlobalFix:
					if (this.GlobalFix == null)
					{
						this.GlobalFix = new GlobalFixCtxPb();
					}
					this.GlobalFix.MergeFrom(other.GlobalFix);
					break;
				case GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb:
					if (this.StuckCheckCtxPb == null)
					{
						this.StuckCheckCtxPb = new StuckCheckCtxPb();
					}
					this.StuckCheckCtxPb.MergeFrom(other.StuckCheckCtxPb);
					break;
				case GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb:
					if (this.AfterConditionActionCtxPb == null)
					{
						this.AfterConditionActionCtxPb = new EntityAfterConditionActionCtxPb();
					}
					this.AfterConditionActionCtxPb.MergeFrom(other.AfterConditionActionCtxPb);
					break;
				case (GameCtxPb.CtxInfoOneofCase)57:
					break;
				case GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb:
					if (this.MotorSliderCtxPb == null)
					{
						this.MotorSliderCtxPb = new MotorSliderCtxPb();
					}
					this.MotorSliderCtxPb.MergeFrom(other.MotorSliderCtxPb);
					break;
				case GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb:
					if (this.RollBlockGamePlayActionCtxPb == null)
					{
						this.RollBlockGamePlayActionCtxPb = new RollBlockGamePlayActionCtxPb();
					}
					this.RollBlockGamePlayActionCtxPb.MergeFrom(other.RollBlockGamePlayActionCtxPb);
					break;
				case GameCtxPb.CtxInfoOneofCase.TransferCtxPb:
					if (this.TransferCtxPb == null)
					{
						this.TransferCtxPb = new TransferCtxPb();
					}
					this.TransferCtxPb.MergeFrom(other.TransferCtxPb);
					break;
				case GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb:
					if (this.DynamicEntityRewardCtxPb == null)
					{
						this.DynamicEntityRewardCtxPb = new DynamicEntityRewardCtxPb();
					}
					this.DynamicEntityRewardCtxPb.MergeFrom(other.DynamicEntityRewardCtxPb);
					break;
				case GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb:
					if (this.BeamCastHitPlayerActionCtxPb == null)
					{
						this.BeamCastHitPlayerActionCtxPb = new BeamCastHitPlayerActionCtxPb();
					}
					this.BeamCastHitPlayerActionCtxPb.MergeFrom(other.BeamCastHitPlayerActionCtxPb);
					break;
				case GameCtxPb.CtxInfoOneofCase.ExploreSkillAction:
					if (this.ExploreSkillAction == null)
					{
						this.ExploreSkillAction = new ExploreSkillActionCtxPb();
					}
					this.ExploreSkillAction.MergeFrom(other.ExploreSkillAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.PollutionRangeAction:
					if (this.PollutionRangeAction == null)
					{
						this.PollutionRangeAction = new PlayEnterOrExitPollutionRangeCtxPb();
					}
					this.PollutionRangeAction.MergeFrom(other.PollutionRangeAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction:
					if (this.EntityQuickHackSkillAction == null)
					{
						this.EntityQuickHackSkillAction = new EntityQuickHackSkillCtxPb();
					}
					this.EntityQuickHackSkillAction.MergeFrom(other.EntityQuickHackSkillAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction:
					if (this.RecallQuestActiveAction == null)
					{
						this.RecallQuestActiveAction = new RecallQuestActiveActionCtxPb();
					}
					this.RecallQuestActiveAction.MergeFrom(other.RecallQuestActiveAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction:
					if (this.RecallQuestAcceptAction == null)
					{
						this.RecallQuestAcceptAction = new RecallQuestAcceptActionCtxPb();
					}
					this.RecallQuestAcceptAction.MergeFrom(other.RecallQuestAcceptAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction:
					if (this.RecallQuestFinishAction == null)
					{
						this.RecallQuestFinishAction = new RecallQuestFinishActionCtxPb();
					}
					this.RecallQuestFinishAction.MergeFrom(other.RecallQuestFinishAction);
					break;
				case GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction:
					if (this.RecallQuestDestroyAction == null)
					{
						this.RecallQuestDestroyAction = new RecallQuestDestroyActionCtxPb();
					}
					this.RecallQuestDestroyAction.MergeFrom(other.RecallQuestDestroyAction);
					break;
				default:
					if (ctxInfoCase != GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction)
					{
						if (ctxInfoCase == GameCtxPb.CtxInfoOneofCase.CasketTrigger)
						{
							if (this.CasketTrigger == null)
							{
								this.CasketTrigger = new CasketTriggerCtxPb();
							}
							this.CasketTrigger.MergeFrom(other.CasketTrigger);
						}
					}
					else
					{
						if (this.EdDebugEnterAction == null)
						{
							this.EdDebugEnterAction = new EdDebugEnterActionCtxPb();
						}
						this.EdDebugEnterAction.MergeFrom(other.EdDebugEnterAction);
					}
					break;
				}
			}
			else if (ctxInfoCase != GameCtxPb.CtxInfoOneofCase.FoundationOperateAction)
			{
				if (ctxInfoCase != GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction)
				{
					if (ctxInfoCase == GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb)
					{
						if (this.LongPressInteractActionCtxPb == null)
						{
							this.LongPressInteractActionCtxPb = new LongPressInteractActionCtxPb();
						}
						this.LongPressInteractActionCtxPb.MergeFrom(other.LongPressInteractActionCtxPb);
					}
				}
				else
				{
					if (this.TargetGearActionByHitTypeAction == null)
					{
						this.TargetGearActionByHitTypeAction = new TargetGearActionByHitTypeCtxPb();
					}
					this.TargetGearActionByHitTypeAction.MergeFrom(other.TargetGearActionByHitTypeAction);
				}
			}
			else
			{
				if (this.FoundationOperateAction == null)
				{
					this.FoundationOperateAction = new FoundationOperateActionCtxPb();
				}
				this.FoundationOperateAction.MergeFrom(other.FoundationOperateAction);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x00178909 File Offset: 0x00176B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x00178914 File Offset: 0x00176B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 290U)
				{
					if (num <= 146U)
					{
						if (num <= 74U)
						{
							if (num <= 34U)
							{
								if (num <= 18U)
								{
									if (num == 8U)
									{
										this.CtxType = (GameCtxType)input.ReadEnum();
										continue;
									}
									if (num == 18U)
									{
										BehaviorTreeCtxPb behaviorTreeCtxPb = new BehaviorTreeCtxPb();
										if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BehaviorTree)
										{
											behaviorTreeCtxPb.MergeFrom(this.BehaviorTree);
										}
										input.ReadMessage(behaviorTreeCtxPb);
										this.BehaviorTree = behaviorTreeCtxPb;
										continue;
									}
								}
								else
								{
									if (num == 26U)
									{
										EntityCtxPb entityCtxPb = new EntityCtxPb();
										if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.Entity)
										{
											entityCtxPb.MergeFrom(this.Entity);
										}
										input.ReadMessage(entityCtxPb);
										this.Entity = entityCtxPb;
										continue;
									}
									if (num == 34U)
									{
										NormalInteractCtxPb normalInteractCtxPb = new NormalInteractCtxPb();
										if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.NormalInteract)
										{
											normalInteractCtxPb.MergeFrom(this.NormalInteract);
										}
										input.ReadMessage(normalInteractCtxPb);
										this.NormalInteract = normalInteractCtxPb;
										continue;
									}
								}
							}
							else if (num <= 50U)
							{
								if (num == 42U)
								{
									DynamicInteractCtxPb dynamicInteractCtxPb = new DynamicInteractCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicInteract)
									{
										dynamicInteractCtxPb.MergeFrom(this.DynamicInteract);
									}
									input.ReadMessage(dynamicInteractCtxPb);
									this.DynamicInteract = dynamicInteractCtxPb;
									continue;
								}
								if (num == 50U)
								{
									RandomInteractCtxPb randomInteractCtxPb = new RandomInteractCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RandomInteract)
									{
										randomInteractCtxPb.MergeFrom(this.RandomInteract);
									}
									input.ReadMessage(randomInteractCtxPb);
									this.RandomInteract = randomInteractCtxPb;
									continue;
								}
							}
							else
							{
								if (num == 58U)
								{
									StateChangeActionCtxPb stateChangeActionCtxPb = new StateChangeActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeAction)
									{
										stateChangeActionCtxPb.MergeFrom(this.StateChangeAction);
									}
									input.ReadMessage(stateChangeActionCtxPb);
									this.StateChangeAction = stateChangeActionCtxPb;
									continue;
								}
								if (num == 66U)
								{
									EntityGroupActionCtxPb entityGroupActionCtxPb = new EntityGroupActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupAction)
									{
										entityGroupActionCtxPb.MergeFrom(this.EntityGroupAction);
									}
									input.ReadMessage(entityGroupActionCtxPb);
									this.EntityGroupAction = entityGroupActionCtxPb;
									continue;
								}
								if (num == 74U)
								{
									EntityTriggerCtxPb entityTriggerCtxPb = new EntityTriggerCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTrigger)
									{
										entityTriggerCtxPb.MergeFrom(this.EntityTrigger);
									}
									input.ReadMessage(entityTriggerCtxPb);
									this.EntityTrigger = entityTriggerCtxPb;
									continue;
								}
							}
						}
						else if (num <= 106U)
						{
							if (num <= 90U)
							{
								if (num == 82U)
								{
									EntityLeaveTriggerCtxPb entityLeaveTriggerCtxPb = new EntityLeaveTriggerCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityLeaveTriggerCtx)
									{
										entityLeaveTriggerCtxPb.MergeFrom(this.EntityLeaveTriggerCtx);
									}
									input.ReadMessage(entityLeaveTriggerCtxPb);
									this.EntityLeaveTriggerCtx = entityLeaveTriggerCtxPb;
									continue;
								}
								if (num == 90U)
								{
									EntityDestructibleCtxPb entityDestructibleCtxPb = new EntityDestructibleCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityDestructible)
									{
										entityDestructibleCtxPb.MergeFrom(this.EntityDestructible);
									}
									input.ReadMessage(entityDestructibleCtxPb);
									this.EntityDestructible = entityDestructibleCtxPb;
									continue;
								}
							}
							else
							{
								if (num == 98U)
								{
									EntityTimelineTrackCtxPb entityTimelineTrackCtxPb = new EntityTimelineTrackCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityTimelineTrack)
									{
										entityTimelineTrackCtxPb.MergeFrom(this.EntityTimelineTrack);
									}
									input.ReadMessage(entityTimelineTrackCtxPb);
									this.EntityTimelineTrack = entityTimelineTrackCtxPb;
									continue;
								}
								if (num == 106U)
								{
									LevelPlayOpenActionCtxPb levelPlayOpenActionCtxPb = new LevelPlayOpenActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayOpenAction)
									{
										levelPlayOpenActionCtxPb.MergeFrom(this.LevelPlayOpenAction);
									}
									input.ReadMessage(levelPlayOpenActionCtxPb);
									this.LevelPlayOpenAction = levelPlayOpenActionCtxPb;
									continue;
								}
							}
						}
						else if (num <= 122U)
						{
							if (num == 114U)
							{
								LevelPlayRewardActionCtxPb levelPlayRewardActionCtxPb = new LevelPlayRewardActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayRewardAction)
								{
									levelPlayRewardActionCtxPb.MergeFrom(this.LevelPlayRewardAction);
								}
								input.ReadMessage(levelPlayRewardActionCtxPb);
								this.LevelPlayRewardAction = levelPlayRewardActionCtxPb;
								continue;
							}
							if (num == 122U)
							{
								QuestActiveActionCtxPb questActiveActionCtxPb = new QuestActiveActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestActiveAction)
								{
									questActiveActionCtxPb.MergeFrom(this.QuestActiveAction);
								}
								input.ReadMessage(questActiveActionCtxPb);
								this.QuestActiveAction = questActiveActionCtxPb;
								continue;
							}
						}
						else
						{
							if (num == 130U)
							{
								QuestAcceptActionCtxPb questAcceptActionCtxPb = new QuestAcceptActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestAcceptAction)
								{
									questAcceptActionCtxPb.MergeFrom(this.QuestAcceptAction);
								}
								input.ReadMessage(questAcceptActionCtxPb);
								this.QuestAcceptAction = questAcceptActionCtxPb;
								continue;
							}
							if (num == 138U)
							{
								QuestFinishActionCtxPb questFinishActionCtxPb = new QuestFinishActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestFinishAction)
								{
									questFinishActionCtxPb.MergeFrom(this.QuestFinishAction);
								}
								input.ReadMessage(questFinishActionCtxPb);
								this.QuestFinishAction = questFinishActionCtxPb;
								continue;
							}
							if (num == 146U)
							{
								ChildQuestNodeEnterActionCtxPb childQuestNodeEnterActionCtxPb = new ChildQuestNodeEnterActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeEnterAction)
								{
									childQuestNodeEnterActionCtxPb.MergeFrom(this.ChildQuestNodeEnterAction);
								}
								input.ReadMessage(childQuestNodeEnterActionCtxPb);
								this.ChildQuestNodeEnterAction = childQuestNodeEnterActionCtxPb;
								continue;
							}
						}
					}
					else if (num <= 218U)
					{
						if (num <= 178U)
						{
							if (num <= 162U)
							{
								if (num == 154U)
								{
									ChildQuestNodeFinishActionCtxPb childQuestNodeFinishActionCtxPb = new ChildQuestNodeFinishActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ChildQuestNodeFinishAction)
									{
										childQuestNodeFinishActionCtxPb.MergeFrom(this.ChildQuestNodeFinishAction);
									}
									input.ReadMessage(childQuestNodeFinishActionCtxPb);
									this.ChildQuestNodeFinishAction = childQuestNodeFinishActionCtxPb;
									continue;
								}
								if (num == 162U)
								{
									SuccessNodeActionCtxPb successNodeActionCtxPb = new SuccessNodeActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.SuccessNodeAction)
									{
										successNodeActionCtxPb.MergeFrom(this.SuccessNodeAction);
									}
									input.ReadMessage(successNodeActionCtxPb);
									this.SuccessNodeAction = successNodeActionCtxPb;
									continue;
								}
							}
							else
							{
								if (num == 170U)
								{
									FailedNodeActionCtxPb failedNodeActionCtxPb = new FailedNodeActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FailedNodeAction)
									{
										failedNodeActionCtxPb.MergeFrom(this.FailedNodeAction);
									}
									input.ReadMessage(failedNodeActionCtxPb);
									this.FailedNodeAction = failedNodeActionCtxPb;
									continue;
								}
								if (num == 178U)
								{
									CompositionEnterActionCtxPb compositionEnterActionCtxPb = new CompositionEnterActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionEnterAction)
									{
										compositionEnterActionCtxPb.MergeFrom(this.CompositionEnterAction);
									}
									input.ReadMessage(compositionEnterActionCtxPb);
									this.CompositionEnterAction = compositionEnterActionCtxPb;
									continue;
								}
							}
						}
						else if (num <= 194U)
						{
							if (num == 186U)
							{
								EntityConditionListeningActionCtxPb entityConditionListeningActionCtxPb = new EntityConditionListeningActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityConditionListeningAction)
								{
									entityConditionListeningActionCtxPb.MergeFrom(this.EntityConditionListeningAction);
								}
								input.ReadMessage(entityConditionListeningActionCtxPb);
								this.EntityConditionListeningAction = entityConditionListeningActionCtxPb;
								continue;
							}
							if (num == 194U)
							{
								PlayFlowChildQuestNodeCtxPb playFlowChildQuestNodeCtxPb = new PlayFlowChildQuestNodeCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PlayFlowChildQuestNode)
								{
									playFlowChildQuestNodeCtxPb.MergeFrom(this.PlayFlowChildQuestNode);
								}
								input.ReadMessage(playFlowChildQuestNodeCtxPb);
								this.PlayFlowChildQuestNode = playFlowChildQuestNodeCtxPb;
								continue;
							}
						}
						else
						{
							if (num == 202U)
							{
								HandInItemChildQuestNodeCtxPb handInItemChildQuestNodeCtxPb = new HandInItemChildQuestNodeCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HandInItemChildQuestNode)
								{
									handInItemChildQuestNodeCtxPb.MergeFrom(this.HandInItemChildQuestNode);
								}
								input.ReadMessage(handInItemChildQuestNodeCtxPb);
								this.HandInItemChildQuestNode = handInItemChildQuestNodeCtxPb;
								continue;
							}
							if (num == 210U)
							{
								DoInteractChildQuestNodeCtxPb doInteractChildQuestNodeCtxPb = new DoInteractChildQuestNodeCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DoInteractChildQuestNode)
								{
									doInteractChildQuestNodeCtxPb.MergeFrom(this.DoInteractChildQuestNode);
								}
								input.ReadMessage(doInteractChildQuestNodeCtxPb);
								this.DoInteractChildQuestNode = doInteractChildQuestNodeCtxPb;
								continue;
							}
							if (num == 218U)
							{
								ActionGroupNodeActionCtxPb actionGroupNodeActionCtxPb = new ActionGroupNodeActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ActionGroupNodeAction)
								{
									actionGroupNodeActionCtxPb.MergeFrom(this.ActionGroupNodeAction);
								}
								input.ReadMessage(actionGroupNodeActionCtxPb);
								this.ActionGroupNodeAction = actionGroupNodeActionCtxPb;
								continue;
							}
						}
					}
					else if (num <= 250U)
					{
						if (num <= 234U)
						{
							if (num == 226U)
							{
								ExploreSkillPullGiantCtxPb exploreSkillPullGiantCtxPb = new ExploreSkillPullGiantCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillPullGiantAction)
								{
									exploreSkillPullGiantCtxPb.MergeFrom(this.ExploreSkillPullGiantAction);
								}
								input.ReadMessage(exploreSkillPullGiantCtxPb);
								this.ExploreSkillPullGiantAction = exploreSkillPullGiantCtxPb;
								continue;
							}
							if (num == 234U)
							{
								LevelPlayCtxPb levelPlayCtxPb = new LevelPlayCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlay)
								{
									levelPlayCtxPb.MergeFrom(this.LevelPlay);
								}
								input.ReadMessage(levelPlayCtxPb);
								this.LevelPlay = levelPlayCtxPb;
								continue;
							}
						}
						else
						{
							if (num == 242U)
							{
								GmLevelActionCtxPb gmLevelActionCtxPb = new GmLevelActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GmLevelAction)
								{
									gmLevelActionCtxPb.MergeFrom(this.GmLevelAction);
								}
								input.ReadMessage(gmLevelActionCtxPb);
								this.GmLevelAction = gmLevelActionCtxPb;
								continue;
							}
							if (num == 250U)
							{
								SceneItemLifeCycleComponentCreateCtxPb sceneItemLifeCycleComponentCreateCtxPb = new SceneItemLifeCycleComponentCreateCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleCreateAction)
								{
									sceneItemLifeCycleComponentCreateCtxPb.MergeFrom(this.LifeCycleCreateAction);
								}
								input.ReadMessage(sceneItemLifeCycleComponentCreateCtxPb);
								this.LifeCycleCreateAction = sceneItemLifeCycleComponentCreateCtxPb;
								continue;
							}
						}
					}
					else if (num <= 266U)
					{
						if (num == 258U)
						{
							SceneItemLifeCycleComponentDestroyCtxPb sceneItemLifeCycleComponentDestroyCtxPb = new SceneItemLifeCycleComponentDestroyCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LifeCycleDestroyAction)
							{
								sceneItemLifeCycleComponentDestroyCtxPb.MergeFrom(this.LifeCycleDestroyAction);
							}
							input.ReadMessage(sceneItemLifeCycleComponentDestroyCtxPb);
							this.LifeCycleDestroyAction = sceneItemLifeCycleComponentDestroyCtxPb;
							continue;
						}
						if (num == 266U)
						{
							FlowActionCtxPb flowActionCtxPb = new FlowActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowAction)
							{
								flowActionCtxPb.MergeFrom(this.FlowAction);
							}
							input.ReadMessage(flowActionCtxPb);
							this.FlowAction = flowActionCtxPb;
							continue;
						}
					}
					else
					{
						if (num == 274U)
						{
							DailyQuestTerminateActionCtxPb dailyQuestTerminateActionCtxPb = new DailyQuestTerminateActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DailyQuestTerminateAction)
							{
								dailyQuestTerminateActionCtxPb.MergeFrom(this.DailyQuestTerminateAction);
							}
							input.ReadMessage(dailyQuestTerminateActionCtxPb);
							this.DailyQuestTerminateAction = dailyQuestTerminateActionCtxPb;
							continue;
						}
						if (num == 282U)
						{
							EntityBeamReceiveCtxPb entityBeamReceiveCtxPb = new EntityBeamReceiveCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityBeamReceiveAction)
							{
								entityBeamReceiveCtxPb.MergeFrom(this.EntityBeamReceiveAction);
							}
							input.ReadMessage(entityBeamReceiveCtxPb);
							this.EntityBeamReceiveAction = entityBeamReceiveCtxPb;
							continue;
						}
						if (num == 290U)
						{
							EntityGroupFailureActionCtxPb entityGroupFailureActionCtxPb = new EntityGroupFailureActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityGroupFailureAction)
							{
								entityGroupFailureActionCtxPb.MergeFrom(this.EntityGroupFailureAction);
							}
							input.ReadMessage(entityGroupFailureActionCtxPb);
							this.EntityGroupFailureAction = entityGroupFailureActionCtxPb;
							continue;
						}
					}
				}
				else if (num <= 434U)
				{
					if (num <= 362U)
					{
						if (num <= 322U)
						{
							if (num <= 306U)
							{
								if (num == 298U)
								{
									StateChangeConditionActionCtxPb stateChangeConditionActionCtxPb = new StateChangeConditionActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StateChangeConditionAction)
									{
										stateChangeConditionActionCtxPb.MergeFrom(this.StateChangeConditionAction);
									}
									input.ReadMessage(stateChangeConditionActionCtxPb);
									this.StateChangeConditionAction = stateChangeConditionActionCtxPb;
									continue;
								}
								if (num == 306U)
								{
									FlowStartTeleportCtxPb flowStartTeleportCtxPb = new FlowStartTeleportCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FlowStartTeleport)
									{
										flowStartTeleportCtxPb.MergeFrom(this.FlowStartTeleport);
									}
									input.ReadMessage(flowStartTeleportCtxPb);
									this.FlowStartTeleport = flowStartTeleportCtxPb;
									continue;
								}
							}
							else
							{
								if (num == 314U)
								{
									LeaveInstEscActionCtxPb leaveInstEscActionCtxPb = new LeaveInstEscActionCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LeaveInstEscAction)
									{
										leaveInstEscActionCtxPb.MergeFrom(this.LeaveInstEscAction);
									}
									input.ReadMessage(leaveInstEscActionCtxPb);
									this.LeaveInstEscAction = leaveInstEscActionCtxPb;
									continue;
								}
								if (num == 322U)
								{
									TrampleActiveCtxPb trampleActiveCtxPb = new TrampleActiveCtxPb();
									if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleActive)
									{
										trampleActiveCtxPb.MergeFrom(this.TrampleActive);
									}
									input.ReadMessage(trampleActiveCtxPb);
									this.TrampleActive = trampleActiveCtxPb;
									continue;
								}
							}
						}
						else if (num <= 338U)
						{
							if (num == 330U)
							{
								TrampleDeActiveCtxPb trampleDeActiveCtxPb = new TrampleDeActiveCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TrampleDeActive)
								{
									trampleDeActiveCtxPb.MergeFrom(this.TrampleDeActive);
								}
								input.ReadMessage(trampleDeActiveCtxPb);
								this.TrampleDeActive = trampleDeActiveCtxPb;
								continue;
							}
							if (num == 338U)
							{
								RenjuCompleteActionCtxPb renjuCompleteActionCtxPb = new RenjuCompleteActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RenjuCompleteAction)
								{
									renjuCompleteActionCtxPb.MergeFrom(this.RenjuCompleteAction);
								}
								input.ReadMessage(renjuCompleteActionCtxPb);
								this.RenjuCompleteAction = renjuCompleteActionCtxPb;
								continue;
							}
						}
						else
						{
							if (num == 346U)
							{
								JigsawFoundationMatchedActionCtxPb jigsawFoundationMatchedActionCtxPb = new JigsawFoundationMatchedActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedAction)
								{
									jigsawFoundationMatchedActionCtxPb.MergeFrom(this.JigsawFoundationMatchedAction);
								}
								input.ReadMessage(jigsawFoundationMatchedActionCtxPb);
								this.JigsawFoundationMatchedAction = jigsawFoundationMatchedActionCtxPb;
								continue;
							}
							if (num == 354U)
							{
								JigsawFoundationUnMatchedActionCtxPb jigsawFoundationUnMatchedActionCtxPb = new JigsawFoundationUnMatchedActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationUnMatchedActionCtx)
								{
									jigsawFoundationUnMatchedActionCtxPb.MergeFrom(this.JigsawFoundationUnMatchedActionCtx);
								}
								input.ReadMessage(jigsawFoundationUnMatchedActionCtxPb);
								this.JigsawFoundationUnMatchedActionCtx = jigsawFoundationUnMatchedActionCtxPb;
								continue;
							}
							if (num == 362U)
							{
								HookLockPointActionCtxPb hookLockPointActionCtxPb = new HookLockPointActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.HookLockPointAction)
								{
									hookLockPointActionCtxPb.MergeFrom(this.HookLockPointAction);
								}
								input.ReadMessage(hookLockPointActionCtxPb);
								this.HookLockPointAction = hookLockPointActionCtxPb;
								continue;
							}
						}
					}
					else if (num <= 394U)
					{
						if (num <= 378U)
						{
							if (num == 370U)
							{
								ClientTriggerActionCtxPb clientTriggerActionCtxPb = new ClientTriggerActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ClientTriggerAction)
								{
									clientTriggerActionCtxPb.MergeFrom(this.ClientTriggerAction);
								}
								input.ReadMessage(clientTriggerActionCtxPb);
								this.ClientTriggerAction = clientTriggerActionCtxPb;
								continue;
							}
							if (num == 378U)
							{
								ExploreSkillCustomCtxPb exploreSkillCustomCtxPb = new ExploreSkillCustomCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillCustomAction)
								{
									exploreSkillCustomCtxPb.MergeFrom(this.ExploreSkillCustomAction);
								}
								input.ReadMessage(exploreSkillCustomCtxPb);
								this.ExploreSkillCustomAction = exploreSkillCustomCtxPb;
								continue;
							}
						}
						else
						{
							if (num == 386U)
							{
								JigsawFoundationMatchedConditionActionCtxPb jigsawFoundationMatchedConditionActionCtxPb = new JigsawFoundationMatchedConditionActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.JigsawFoundationMatchedConditionAction)
								{
									jigsawFoundationMatchedConditionActionCtxPb.MergeFrom(this.JigsawFoundationMatchedConditionAction);
								}
								input.ReadMessage(jigsawFoundationMatchedConditionActionCtxPb);
								this.JigsawFoundationMatchedConditionAction = jigsawFoundationMatchedConditionActionCtxPb;
								continue;
							}
							if (num == 394U)
							{
								LevelPlayDestroyActionCtxPb levelPlayDestroyActionCtxPb = new LevelPlayDestroyActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LevelPlayDestroyAction)
								{
									levelPlayDestroyActionCtxPb.MergeFrom(this.LevelPlayDestroyAction);
								}
								input.ReadMessage(levelPlayDestroyActionCtxPb);
								this.LevelPlayDestroyAction = levelPlayDestroyActionCtxPb;
								continue;
							}
						}
					}
					else if (num <= 410U)
					{
						if (num == 402U)
						{
							TemplateSpawnerActionCtxPb templateSpawnerActionCtxPb = new TemplateSpawnerActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TemplateSpawnerAction)
							{
								templateSpawnerActionCtxPb.MergeFrom(this.TemplateSpawnerAction);
							}
							input.ReadMessage(templateSpawnerActionCtxPb);
							this.TemplateSpawnerAction = templateSpawnerActionCtxPb;
							continue;
						}
						if (num == 410U)
						{
							QuestDestroyActionCtxPb questDestroyActionCtxPb = new QuestDestroyActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.QuestDestroyAction)
							{
								questDestroyActionCtxPb.MergeFrom(this.QuestDestroyAction);
							}
							input.ReadMessage(questDestroyActionCtxPb);
							this.QuestDestroyAction = questDestroyActionCtxPb;
							continue;
						}
					}
					else
					{
						if (num == 418U)
						{
							CompositionConditionEnterActionCtxPb compositionConditionEnterActionCtxPb = new CompositionConditionEnterActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CompositionConditionEnterAction)
							{
								compositionConditionEnterActionCtxPb.MergeFrom(this.CompositionConditionEnterAction);
							}
							input.ReadMessage(compositionConditionEnterActionCtxPb);
							this.CompositionConditionEnterAction = compositionConditionEnterActionCtxPb;
							continue;
						}
						if (num == 426U)
						{
							TargetGearHitPartCtxPb targetGearHitPartCtxPb = new TargetGearHitPartCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearHitPartCtxAction)
							{
								targetGearHitPartCtxPb.MergeFrom(this.TargetGearHitPartCtxAction);
							}
							input.ReadMessage(targetGearHitPartCtxPb);
							this.TargetGearHitPartCtxAction = targetGearHitPartCtxPb;
							continue;
						}
						if (num == 434U)
						{
							GlobalFixCtxPb globalFixCtxPb = new GlobalFixCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.GlobalFix)
							{
								globalFixCtxPb.MergeFrom(this.GlobalFix);
							}
							input.ReadMessage(globalFixCtxPb);
							this.GlobalFix = globalFixCtxPb;
							continue;
						}
					}
				}
				else if (num <= 514U)
				{
					if (num <= 474U)
					{
						if (num <= 450U)
						{
							if (num == 442U)
							{
								StuckCheckCtxPb stuckCheckCtxPb = new StuckCheckCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.StuckCheckCtxPb)
								{
									stuckCheckCtxPb.MergeFrom(this.StuckCheckCtxPb);
								}
								input.ReadMessage(stuckCheckCtxPb);
								this.StuckCheckCtxPb = stuckCheckCtxPb;
								continue;
							}
							if (num == 450U)
							{
								EntityAfterConditionActionCtxPb entityAfterConditionActionCtxPb = new EntityAfterConditionActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.AfterConditionActionCtxPb)
								{
									entityAfterConditionActionCtxPb.MergeFrom(this.AfterConditionActionCtxPb);
								}
								input.ReadMessage(entityAfterConditionActionCtxPb);
								this.AfterConditionActionCtxPb = entityAfterConditionActionCtxPb;
								continue;
							}
						}
						else
						{
							if (num == 466U)
							{
								MotorSliderCtxPb motorSliderCtxPb = new MotorSliderCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.MotorSliderCtxPb)
								{
									motorSliderCtxPb.MergeFrom(this.MotorSliderCtxPb);
								}
								input.ReadMessage(motorSliderCtxPb);
								this.MotorSliderCtxPb = motorSliderCtxPb;
								continue;
							}
							if (num == 474U)
							{
								RollBlockGamePlayActionCtxPb rollBlockGamePlayActionCtxPb = new RollBlockGamePlayActionCtxPb();
								if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RollBlockGamePlayActionCtxPb)
								{
									rollBlockGamePlayActionCtxPb.MergeFrom(this.RollBlockGamePlayActionCtxPb);
								}
								input.ReadMessage(rollBlockGamePlayActionCtxPb);
								this.RollBlockGamePlayActionCtxPb = rollBlockGamePlayActionCtxPb;
								continue;
							}
						}
					}
					else if (num <= 490U)
					{
						if (num == 482U)
						{
							TransferCtxPb transferCtxPb = new TransferCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TransferCtxPb)
							{
								transferCtxPb.MergeFrom(this.TransferCtxPb);
							}
							input.ReadMessage(transferCtxPb);
							this.TransferCtxPb = transferCtxPb;
							continue;
						}
						if (num == 490U)
						{
							DynamicEntityRewardCtxPb dynamicEntityRewardCtxPb = new DynamicEntityRewardCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.DynamicEntityRewardCtxPb)
							{
								dynamicEntityRewardCtxPb.MergeFrom(this.DynamicEntityRewardCtxPb);
							}
							input.ReadMessage(dynamicEntityRewardCtxPb);
							this.DynamicEntityRewardCtxPb = dynamicEntityRewardCtxPb;
							continue;
						}
					}
					else
					{
						if (num == 498U)
						{
							BeamCastHitPlayerActionCtxPb beamCastHitPlayerActionCtxPb = new BeamCastHitPlayerActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.BeamCastHitPlayerActionCtxPb)
							{
								beamCastHitPlayerActionCtxPb.MergeFrom(this.BeamCastHitPlayerActionCtxPb);
							}
							input.ReadMessage(beamCastHitPlayerActionCtxPb);
							this.BeamCastHitPlayerActionCtxPb = beamCastHitPlayerActionCtxPb;
							continue;
						}
						if (num == 506U)
						{
							ExploreSkillActionCtxPb exploreSkillActionCtxPb = new ExploreSkillActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.ExploreSkillAction)
							{
								exploreSkillActionCtxPb.MergeFrom(this.ExploreSkillAction);
							}
							input.ReadMessage(exploreSkillActionCtxPb);
							this.ExploreSkillAction = exploreSkillActionCtxPb;
							continue;
						}
						if (num == 514U)
						{
							PlayEnterOrExitPollutionRangeCtxPb playEnterOrExitPollutionRangeCtxPb = new PlayEnterOrExitPollutionRangeCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.PollutionRangeAction)
							{
								playEnterOrExitPollutionRangeCtxPb.MergeFrom(this.PollutionRangeAction);
							}
							input.ReadMessage(playEnterOrExitPollutionRangeCtxPb);
							this.PollutionRangeAction = playEnterOrExitPollutionRangeCtxPb;
							continue;
						}
					}
				}
				else if (num <= 554U)
				{
					if (num <= 530U)
					{
						if (num == 522U)
						{
							EntityQuickHackSkillCtxPb entityQuickHackSkillCtxPb = new EntityQuickHackSkillCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EntityQuickHackSkillAction)
							{
								entityQuickHackSkillCtxPb.MergeFrom(this.EntityQuickHackSkillAction);
							}
							input.ReadMessage(entityQuickHackSkillCtxPb);
							this.EntityQuickHackSkillAction = entityQuickHackSkillCtxPb;
							continue;
						}
						if (num == 530U)
						{
							RecallQuestActiveActionCtxPb recallQuestActiveActionCtxPb = new RecallQuestActiveActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestActiveAction)
							{
								recallQuestActiveActionCtxPb.MergeFrom(this.RecallQuestActiveAction);
							}
							input.ReadMessage(recallQuestActiveActionCtxPb);
							this.RecallQuestActiveAction = recallQuestActiveActionCtxPb;
							continue;
						}
					}
					else
					{
						if (num == 538U)
						{
							RecallQuestAcceptActionCtxPb recallQuestAcceptActionCtxPb = new RecallQuestAcceptActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestAcceptAction)
							{
								recallQuestAcceptActionCtxPb.MergeFrom(this.RecallQuestAcceptAction);
							}
							input.ReadMessage(recallQuestAcceptActionCtxPb);
							this.RecallQuestAcceptAction = recallQuestAcceptActionCtxPb;
							continue;
						}
						if (num == 546U)
						{
							RecallQuestFinishActionCtxPb recallQuestFinishActionCtxPb = new RecallQuestFinishActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestFinishAction)
							{
								recallQuestFinishActionCtxPb.MergeFrom(this.RecallQuestFinishAction);
							}
							input.ReadMessage(recallQuestFinishActionCtxPb);
							this.RecallQuestFinishAction = recallQuestFinishActionCtxPb;
							continue;
						}
						if (num == 554U)
						{
							RecallQuestDestroyActionCtxPb recallQuestDestroyActionCtxPb = new RecallQuestDestroyActionCtxPb();
							if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.RecallQuestDestroyAction)
							{
								recallQuestDestroyActionCtxPb.MergeFrom(this.RecallQuestDestroyAction);
							}
							input.ReadMessage(recallQuestDestroyActionCtxPb);
							this.RecallQuestDestroyAction = recallQuestDestroyActionCtxPb;
							continue;
						}
					}
				}
				else if (num <= 28010U)
				{
					if (num == 27210U)
					{
						EdDebugEnterActionCtxPb edDebugEnterActionCtxPb = new EdDebugEnterActionCtxPb();
						if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.EdDebugEnterAction)
						{
							edDebugEnterActionCtxPb.MergeFrom(this.EdDebugEnterAction);
						}
						input.ReadMessage(edDebugEnterActionCtxPb);
						this.EdDebugEnterAction = edDebugEnterActionCtxPb;
						continue;
					}
					if (num == 28010U)
					{
						CasketTriggerCtxPb casketTriggerCtxPb = new CasketTriggerCtxPb();
						if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.CasketTrigger)
						{
							casketTriggerCtxPb.MergeFrom(this.CasketTrigger);
						}
						input.ReadMessage(casketTriggerCtxPb);
						this.CasketTrigger = casketTriggerCtxPb;
						continue;
					}
				}
				else
				{
					if (num == 28018U)
					{
						FoundationOperateActionCtxPb foundationOperateActionCtxPb = new FoundationOperateActionCtxPb();
						if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.FoundationOperateAction)
						{
							foundationOperateActionCtxPb.MergeFrom(this.FoundationOperateAction);
						}
						input.ReadMessage(foundationOperateActionCtxPb);
						this.FoundationOperateAction = foundationOperateActionCtxPb;
						continue;
					}
					if (num == 29610U)
					{
						TargetGearActionByHitTypeCtxPb targetGearActionByHitTypeCtxPb = new TargetGearActionByHitTypeCtxPb();
						if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.TargetGearActionByHitTypeAction)
						{
							targetGearActionByHitTypeCtxPb.MergeFrom(this.TargetGearActionByHitTypeAction);
						}
						input.ReadMessage(targetGearActionByHitTypeCtxPb);
						this.TargetGearActionByHitTypeAction = targetGearActionByHitTypeCtxPb;
						continue;
					}
					if (num == 29618U)
					{
						LongPressInteractActionCtxPb longPressInteractActionCtxPb = new LongPressInteractActionCtxPb();
						if (this.ctxInfoCase_ == GameCtxPb.CtxInfoOneofCase.LongPressInteractActionCtxPb)
						{
							longPressInteractActionCtxPb.MergeFrom(this.LongPressInteractActionCtxPb);
						}
						input.ReadMessage(longPressInteractActionCtxPb);
						this.LongPressInteractActionCtxPb = longPressInteractActionCtxPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004961 RID: 18785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004962 RID: 18786
		public const int CtxTypeFieldNumber = 1;

		// Token: 0x04004963 RID: 18787
		private GameCtxType ctxType_;

		// Token: 0x04004964 RID: 18788
		public const int BehaviorTreeFieldNumber = 2;

		// Token: 0x04004965 RID: 18789
		public const int EntityFieldNumber = 3;

		// Token: 0x04004966 RID: 18790
		public const int NormalInteractFieldNumber = 4;

		// Token: 0x04004967 RID: 18791
		public const int DynamicInteractFieldNumber = 5;

		// Token: 0x04004968 RID: 18792
		public const int RandomInteractFieldNumber = 6;

		// Token: 0x04004969 RID: 18793
		public const int StateChangeActionFieldNumber = 7;

		// Token: 0x0400496A RID: 18794
		public const int EntityGroupActionFieldNumber = 8;

		// Token: 0x0400496B RID: 18795
		public const int EntityTriggerFieldNumber = 9;

		// Token: 0x0400496C RID: 18796
		public const int EntityLeaveTriggerCtxFieldNumber = 10;

		// Token: 0x0400496D RID: 18797
		public const int EntityDestructibleFieldNumber = 11;

		// Token: 0x0400496E RID: 18798
		public const int EntityTimelineTrackFieldNumber = 12;

		// Token: 0x0400496F RID: 18799
		public const int LevelPlayOpenActionFieldNumber = 13;

		// Token: 0x04004970 RID: 18800
		public const int LevelPlayRewardActionFieldNumber = 14;

		// Token: 0x04004971 RID: 18801
		public const int QuestActiveActionFieldNumber = 15;

		// Token: 0x04004972 RID: 18802
		public const int QuestAcceptActionFieldNumber = 16;

		// Token: 0x04004973 RID: 18803
		public const int QuestFinishActionFieldNumber = 17;

		// Token: 0x04004974 RID: 18804
		public const int ChildQuestNodeEnterActionFieldNumber = 18;

		// Token: 0x04004975 RID: 18805
		public const int ChildQuestNodeFinishActionFieldNumber = 19;

		// Token: 0x04004976 RID: 18806
		public const int SuccessNodeActionFieldNumber = 20;

		// Token: 0x04004977 RID: 18807
		public const int FailedNodeActionFieldNumber = 21;

		// Token: 0x04004978 RID: 18808
		public const int CompositionEnterActionFieldNumber = 22;

		// Token: 0x04004979 RID: 18809
		public const int EntityConditionListeningActionFieldNumber = 23;

		// Token: 0x0400497A RID: 18810
		public const int PlayFlowChildQuestNodeFieldNumber = 24;

		// Token: 0x0400497B RID: 18811
		public const int HandInItemChildQuestNodeFieldNumber = 25;

		// Token: 0x0400497C RID: 18812
		public const int DoInteractChildQuestNodeFieldNumber = 26;

		// Token: 0x0400497D RID: 18813
		public const int ActionGroupNodeActionFieldNumber = 27;

		// Token: 0x0400497E RID: 18814
		public const int ExploreSkillPullGiantActionFieldNumber = 28;

		// Token: 0x0400497F RID: 18815
		public const int LevelPlayFieldNumber = 29;

		// Token: 0x04004980 RID: 18816
		public const int GmLevelActionFieldNumber = 30;

		// Token: 0x04004981 RID: 18817
		public const int LifeCycleCreateActionFieldNumber = 31;

		// Token: 0x04004982 RID: 18818
		public const int LifeCycleDestroyActionFieldNumber = 32;

		// Token: 0x04004983 RID: 18819
		public const int FlowActionFieldNumber = 33;

		// Token: 0x04004984 RID: 18820
		public const int DailyQuestTerminateActionFieldNumber = 34;

		// Token: 0x04004985 RID: 18821
		public const int EntityBeamReceiveActionFieldNumber = 35;

		// Token: 0x04004986 RID: 18822
		public const int EntityGroupFailureActionFieldNumber = 36;

		// Token: 0x04004987 RID: 18823
		public const int StateChangeConditionActionFieldNumber = 37;

		// Token: 0x04004988 RID: 18824
		public const int FlowStartTeleportFieldNumber = 38;

		// Token: 0x04004989 RID: 18825
		public const int LeaveInstEscActionFieldNumber = 39;

		// Token: 0x0400498A RID: 18826
		public const int TrampleActiveFieldNumber = 40;

		// Token: 0x0400498B RID: 18827
		public const int TrampleDeActiveFieldNumber = 41;

		// Token: 0x0400498C RID: 18828
		public const int RenjuCompleteActionFieldNumber = 42;

		// Token: 0x0400498D RID: 18829
		public const int JigsawFoundationMatchedActionFieldNumber = 43;

		// Token: 0x0400498E RID: 18830
		public const int JigsawFoundationUnMatchedActionCtxFieldNumber = 44;

		// Token: 0x0400498F RID: 18831
		public const int HookLockPointActionFieldNumber = 45;

		// Token: 0x04004990 RID: 18832
		public const int ClientTriggerActionFieldNumber = 46;

		// Token: 0x04004991 RID: 18833
		public const int ExploreSkillCustomActionFieldNumber = 47;

		// Token: 0x04004992 RID: 18834
		public const int JigsawFoundationMatchedConditionActionFieldNumber = 48;

		// Token: 0x04004993 RID: 18835
		public const int LevelPlayDestroyActionFieldNumber = 49;

		// Token: 0x04004994 RID: 18836
		public const int TemplateSpawnerActionFieldNumber = 50;

		// Token: 0x04004995 RID: 18837
		public const int QuestDestroyActionFieldNumber = 51;

		// Token: 0x04004996 RID: 18838
		public const int CompositionConditionEnterActionFieldNumber = 52;

		// Token: 0x04004997 RID: 18839
		public const int TargetGearHitPartCtxActionFieldNumber = 53;

		// Token: 0x04004998 RID: 18840
		public const int GlobalFixFieldNumber = 54;

		// Token: 0x04004999 RID: 18841
		public const int StuckCheckCtxPbFieldNumber = 55;

		// Token: 0x0400499A RID: 18842
		public const int AfterConditionActionCtxPbFieldNumber = 56;

		// Token: 0x0400499B RID: 18843
		public const int MotorSliderCtxPbFieldNumber = 58;

		// Token: 0x0400499C RID: 18844
		public const int RollBlockGamePlayActionCtxPbFieldNumber = 59;

		// Token: 0x0400499D RID: 18845
		public const int TransferCtxPbFieldNumber = 60;

		// Token: 0x0400499E RID: 18846
		public const int DynamicEntityRewardCtxPbFieldNumber = 61;

		// Token: 0x0400499F RID: 18847
		public const int BeamCastHitPlayerActionCtxPbFieldNumber = 62;

		// Token: 0x040049A0 RID: 18848
		public const int ExploreSkillActionFieldNumber = 63;

		// Token: 0x040049A1 RID: 18849
		public const int PollutionRangeActionFieldNumber = 64;

		// Token: 0x040049A2 RID: 18850
		public const int EntityQuickHackSkillActionFieldNumber = 65;

		// Token: 0x040049A3 RID: 18851
		public const int RecallQuestActiveActionFieldNumber = 66;

		// Token: 0x040049A4 RID: 18852
		public const int RecallQuestAcceptActionFieldNumber = 67;

		// Token: 0x040049A5 RID: 18853
		public const int RecallQuestFinishActionFieldNumber = 68;

		// Token: 0x040049A6 RID: 18854
		public const int RecallQuestDestroyActionFieldNumber = 69;

		// Token: 0x040049A7 RID: 18855
		public const int EdDebugEnterActionFieldNumber = 3401;

		// Token: 0x040049A8 RID: 18856
		public const int CasketTriggerFieldNumber = 3501;

		// Token: 0x040049A9 RID: 18857
		public const int FoundationOperateActionFieldNumber = 3502;

		// Token: 0x040049AA RID: 18858
		public const int TargetGearActionByHitTypeActionFieldNumber = 3701;

		// Token: 0x040049AB RID: 18859
		public const int LongPressInteractActionCtxPbFieldNumber = 3702;

		// Token: 0x040049AC RID: 18860
		private object ctxInfo_;

		// Token: 0x040049AD RID: 18861
		private GameCtxPb.CtxInfoOneofCase ctxInfoCase_;

		// Token: 0x0200183F RID: 6207
		public enum CtxInfoOneofCase
		{
			// Token: 0x0400CC3E RID: 52286
			None,
			// Token: 0x0400CC3F RID: 52287
			BehaviorTree = 2,
			// Token: 0x0400CC40 RID: 52288
			Entity,
			// Token: 0x0400CC41 RID: 52289
			NormalInteract,
			// Token: 0x0400CC42 RID: 52290
			DynamicInteract,
			// Token: 0x0400CC43 RID: 52291
			RandomInteract,
			// Token: 0x0400CC44 RID: 52292
			StateChangeAction,
			// Token: 0x0400CC45 RID: 52293
			EntityGroupAction,
			// Token: 0x0400CC46 RID: 52294
			EntityTrigger,
			// Token: 0x0400CC47 RID: 52295
			EntityLeaveTriggerCtx,
			// Token: 0x0400CC48 RID: 52296
			EntityDestructible,
			// Token: 0x0400CC49 RID: 52297
			EntityTimelineTrack,
			// Token: 0x0400CC4A RID: 52298
			LevelPlayOpenAction,
			// Token: 0x0400CC4B RID: 52299
			LevelPlayRewardAction,
			// Token: 0x0400CC4C RID: 52300
			QuestActiveAction,
			// Token: 0x0400CC4D RID: 52301
			QuestAcceptAction,
			// Token: 0x0400CC4E RID: 52302
			QuestFinishAction,
			// Token: 0x0400CC4F RID: 52303
			ChildQuestNodeEnterAction,
			// Token: 0x0400CC50 RID: 52304
			ChildQuestNodeFinishAction,
			// Token: 0x0400CC51 RID: 52305
			SuccessNodeAction,
			// Token: 0x0400CC52 RID: 52306
			FailedNodeAction,
			// Token: 0x0400CC53 RID: 52307
			CompositionEnterAction,
			// Token: 0x0400CC54 RID: 52308
			EntityConditionListeningAction,
			// Token: 0x0400CC55 RID: 52309
			PlayFlowChildQuestNode,
			// Token: 0x0400CC56 RID: 52310
			HandInItemChildQuestNode,
			// Token: 0x0400CC57 RID: 52311
			DoInteractChildQuestNode,
			// Token: 0x0400CC58 RID: 52312
			ActionGroupNodeAction,
			// Token: 0x0400CC59 RID: 52313
			ExploreSkillPullGiantAction,
			// Token: 0x0400CC5A RID: 52314
			LevelPlay,
			// Token: 0x0400CC5B RID: 52315
			GmLevelAction,
			// Token: 0x0400CC5C RID: 52316
			LifeCycleCreateAction,
			// Token: 0x0400CC5D RID: 52317
			LifeCycleDestroyAction,
			// Token: 0x0400CC5E RID: 52318
			FlowAction,
			// Token: 0x0400CC5F RID: 52319
			DailyQuestTerminateAction,
			// Token: 0x0400CC60 RID: 52320
			EntityBeamReceiveAction,
			// Token: 0x0400CC61 RID: 52321
			EntityGroupFailureAction,
			// Token: 0x0400CC62 RID: 52322
			StateChangeConditionAction,
			// Token: 0x0400CC63 RID: 52323
			FlowStartTeleport,
			// Token: 0x0400CC64 RID: 52324
			LeaveInstEscAction,
			// Token: 0x0400CC65 RID: 52325
			TrampleActive,
			// Token: 0x0400CC66 RID: 52326
			TrampleDeActive,
			// Token: 0x0400CC67 RID: 52327
			RenjuCompleteAction,
			// Token: 0x0400CC68 RID: 52328
			JigsawFoundationMatchedAction,
			// Token: 0x0400CC69 RID: 52329
			JigsawFoundationUnMatchedActionCtx,
			// Token: 0x0400CC6A RID: 52330
			HookLockPointAction,
			// Token: 0x0400CC6B RID: 52331
			ClientTriggerAction,
			// Token: 0x0400CC6C RID: 52332
			ExploreSkillCustomAction,
			// Token: 0x0400CC6D RID: 52333
			JigsawFoundationMatchedConditionAction,
			// Token: 0x0400CC6E RID: 52334
			LevelPlayDestroyAction,
			// Token: 0x0400CC6F RID: 52335
			TemplateSpawnerAction,
			// Token: 0x0400CC70 RID: 52336
			QuestDestroyAction,
			// Token: 0x0400CC71 RID: 52337
			CompositionConditionEnterAction,
			// Token: 0x0400CC72 RID: 52338
			TargetGearHitPartCtxAction,
			// Token: 0x0400CC73 RID: 52339
			GlobalFix,
			// Token: 0x0400CC74 RID: 52340
			StuckCheckCtxPb,
			// Token: 0x0400CC75 RID: 52341
			AfterConditionActionCtxPb,
			// Token: 0x0400CC76 RID: 52342
			MotorSliderCtxPb = 58,
			// Token: 0x0400CC77 RID: 52343
			RollBlockGamePlayActionCtxPb,
			// Token: 0x0400CC78 RID: 52344
			TransferCtxPb,
			// Token: 0x0400CC79 RID: 52345
			DynamicEntityRewardCtxPb,
			// Token: 0x0400CC7A RID: 52346
			BeamCastHitPlayerActionCtxPb,
			// Token: 0x0400CC7B RID: 52347
			ExploreSkillAction,
			// Token: 0x0400CC7C RID: 52348
			PollutionRangeAction,
			// Token: 0x0400CC7D RID: 52349
			EntityQuickHackSkillAction,
			// Token: 0x0400CC7E RID: 52350
			RecallQuestActiveAction,
			// Token: 0x0400CC7F RID: 52351
			RecallQuestAcceptAction,
			// Token: 0x0400CC80 RID: 52352
			RecallQuestFinishAction,
			// Token: 0x0400CC81 RID: 52353
			RecallQuestDestroyAction,
			// Token: 0x0400CC82 RID: 52354
			EdDebugEnterAction = 3401,
			// Token: 0x0400CC83 RID: 52355
			CasketTrigger = 3501,
			// Token: 0x0400CC84 RID: 52356
			FoundationOperateAction,
			// Token: 0x0400CC85 RID: 52357
			TargetGearActionByHitTypeAction = 3701,
			// Token: 0x0400CC86 RID: 52358
			LongPressInteractActionCtxPb
		}
	}
}
