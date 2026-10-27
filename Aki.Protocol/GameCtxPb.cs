using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A4 RID: 1700
	public sealed class GameCtxPb : IMessage<GameCtxPb>, IMessage, IEquatable<GameCtxPb>, IDeepCloneable<GameCtxPb>, IBufferMessage
	{
		// Token: 0x06009B8A RID: 39818 RVA: 0x001771D1 File Offset: 0x001753D1
		[NullableContext(1)]
		public static GameCtxPb Create()
		{
			return new GameCtxPb();
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06009B8B RID: 39819 RVA: 0x001771D8 File Offset: 0x001753D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06009B8C RID: 39820 RVA: 0x001771DB File Offset: 0x001753DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameCtxPb.Descriptor;
			}
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x001771E2 File Offset: 0x001753E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb()
		{
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x001771EC File Offset: 0x001753EC
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

		// Token: 0x06009B8F RID: 39823 RVA: 0x001779A0 File Offset: 0x00175BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb Clone()
		{
			return new GameCtxPb(this);
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06009B90 RID: 39824 RVA: 0x001779A8 File Offset: 0x00175BA8
		// (set) Token: 0x06009B91 RID: 39825 RVA: 0x001779B0 File Offset: 0x00175BB0
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

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06009B92 RID: 39826 RVA: 0x001779B9 File Offset: 0x00175BB9
		// (set) Token: 0x06009B93 RID: 39827 RVA: 0x001779D1 File Offset: 0x00175BD1
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

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06009B94 RID: 39828 RVA: 0x001779E7 File Offset: 0x00175BE7
		// (set) Token: 0x06009B95 RID: 39829 RVA: 0x001779FF File Offset: 0x00175BFF
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

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06009B96 RID: 39830 RVA: 0x00177A15 File Offset: 0x00175C15
		// (set) Token: 0x06009B97 RID: 39831 RVA: 0x00177A2D File Offset: 0x00175C2D
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

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06009B98 RID: 39832 RVA: 0x00177A43 File Offset: 0x00175C43
		// (set) Token: 0x06009B99 RID: 39833 RVA: 0x00177A5B File Offset: 0x00175C5B
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

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06009B9A RID: 39834 RVA: 0x00177A71 File Offset: 0x00175C71
		// (set) Token: 0x06009B9B RID: 39835 RVA: 0x00177A89 File Offset: 0x00175C89
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

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06009B9C RID: 39836 RVA: 0x00177A9F File Offset: 0x00175C9F
		// (set) Token: 0x06009B9D RID: 39837 RVA: 0x00177AB7 File Offset: 0x00175CB7
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

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06009B9E RID: 39838 RVA: 0x00177ACD File Offset: 0x00175CCD
		// (set) Token: 0x06009B9F RID: 39839 RVA: 0x00177AE5 File Offset: 0x00175CE5
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

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x06009BA0 RID: 39840 RVA: 0x00177AFB File Offset: 0x00175CFB
		// (set) Token: 0x06009BA1 RID: 39841 RVA: 0x00177B14 File Offset: 0x00175D14
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

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x00177B2B File Offset: 0x00175D2B
		// (set) Token: 0x06009BA3 RID: 39843 RVA: 0x00177B44 File Offset: 0x00175D44
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

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x06009BA4 RID: 39844 RVA: 0x00177B5B File Offset: 0x00175D5B
		// (set) Token: 0x06009BA5 RID: 39845 RVA: 0x00177B74 File Offset: 0x00175D74
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

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06009BA6 RID: 39846 RVA: 0x00177B8B File Offset: 0x00175D8B
		// (set) Token: 0x06009BA7 RID: 39847 RVA: 0x00177BA4 File Offset: 0x00175DA4
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

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06009BA8 RID: 39848 RVA: 0x00177BBB File Offset: 0x00175DBB
		// (set) Token: 0x06009BA9 RID: 39849 RVA: 0x00177BD4 File Offset: 0x00175DD4
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

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06009BAA RID: 39850 RVA: 0x00177BEB File Offset: 0x00175DEB
		// (set) Token: 0x06009BAB RID: 39851 RVA: 0x00177C04 File Offset: 0x00175E04
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

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06009BAC RID: 39852 RVA: 0x00177C1B File Offset: 0x00175E1B
		// (set) Token: 0x06009BAD RID: 39853 RVA: 0x00177C34 File Offset: 0x00175E34
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

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06009BAE RID: 39854 RVA: 0x00177C4B File Offset: 0x00175E4B
		// (set) Token: 0x06009BAF RID: 39855 RVA: 0x00177C64 File Offset: 0x00175E64
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

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06009BB0 RID: 39856 RVA: 0x00177C7B File Offset: 0x00175E7B
		// (set) Token: 0x06009BB1 RID: 39857 RVA: 0x00177C94 File Offset: 0x00175E94
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

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06009BB2 RID: 39858 RVA: 0x00177CAB File Offset: 0x00175EAB
		// (set) Token: 0x06009BB3 RID: 39859 RVA: 0x00177CC4 File Offset: 0x00175EC4
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

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06009BB4 RID: 39860 RVA: 0x00177CDB File Offset: 0x00175EDB
		// (set) Token: 0x06009BB5 RID: 39861 RVA: 0x00177CF4 File Offset: 0x00175EF4
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

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06009BB6 RID: 39862 RVA: 0x00177D0B File Offset: 0x00175F0B
		// (set) Token: 0x06009BB7 RID: 39863 RVA: 0x00177D24 File Offset: 0x00175F24
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

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06009BB8 RID: 39864 RVA: 0x00177D3B File Offset: 0x00175F3B
		// (set) Token: 0x06009BB9 RID: 39865 RVA: 0x00177D54 File Offset: 0x00175F54
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

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06009BBA RID: 39866 RVA: 0x00177D6B File Offset: 0x00175F6B
		// (set) Token: 0x06009BBB RID: 39867 RVA: 0x00177D84 File Offset: 0x00175F84
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

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06009BBC RID: 39868 RVA: 0x00177D9B File Offset: 0x00175F9B
		// (set) Token: 0x06009BBD RID: 39869 RVA: 0x00177DB4 File Offset: 0x00175FB4
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

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x06009BBE RID: 39870 RVA: 0x00177DCB File Offset: 0x00175FCB
		// (set) Token: 0x06009BBF RID: 39871 RVA: 0x00177DE4 File Offset: 0x00175FE4
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

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x06009BC0 RID: 39872 RVA: 0x00177DFB File Offset: 0x00175FFB
		// (set) Token: 0x06009BC1 RID: 39873 RVA: 0x00177E14 File Offset: 0x00176014
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

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06009BC2 RID: 39874 RVA: 0x00177E2B File Offset: 0x0017602B
		// (set) Token: 0x06009BC3 RID: 39875 RVA: 0x00177E44 File Offset: 0x00176044
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

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06009BC4 RID: 39876 RVA: 0x00177E5B File Offset: 0x0017605B
		// (set) Token: 0x06009BC5 RID: 39877 RVA: 0x00177E74 File Offset: 0x00176074
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

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06009BC6 RID: 39878 RVA: 0x00177E8B File Offset: 0x0017608B
		// (set) Token: 0x06009BC7 RID: 39879 RVA: 0x00177EA4 File Offset: 0x001760A4
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

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06009BC8 RID: 39880 RVA: 0x00177EBB File Offset: 0x001760BB
		// (set) Token: 0x06009BC9 RID: 39881 RVA: 0x00177ED4 File Offset: 0x001760D4
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

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06009BCA RID: 39882 RVA: 0x00177EEB File Offset: 0x001760EB
		// (set) Token: 0x06009BCB RID: 39883 RVA: 0x00177F04 File Offset: 0x00176104
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

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06009BCC RID: 39884 RVA: 0x00177F1B File Offset: 0x0017611B
		// (set) Token: 0x06009BCD RID: 39885 RVA: 0x00177F34 File Offset: 0x00176134
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

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06009BCE RID: 39886 RVA: 0x00177F4B File Offset: 0x0017614B
		// (set) Token: 0x06009BCF RID: 39887 RVA: 0x00177F64 File Offset: 0x00176164
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

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06009BD0 RID: 39888 RVA: 0x00177F7B File Offset: 0x0017617B
		// (set) Token: 0x06009BD1 RID: 39889 RVA: 0x00177F94 File Offset: 0x00176194
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

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x06009BD2 RID: 39890 RVA: 0x00177FAB File Offset: 0x001761AB
		// (set) Token: 0x06009BD3 RID: 39891 RVA: 0x00177FC4 File Offset: 0x001761C4
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

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06009BD4 RID: 39892 RVA: 0x00177FDB File Offset: 0x001761DB
		// (set) Token: 0x06009BD5 RID: 39893 RVA: 0x00177FF4 File Offset: 0x001761F4
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

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06009BD6 RID: 39894 RVA: 0x0017800B File Offset: 0x0017620B
		// (set) Token: 0x06009BD7 RID: 39895 RVA: 0x00178024 File Offset: 0x00176224
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

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06009BD8 RID: 39896 RVA: 0x0017803B File Offset: 0x0017623B
		// (set) Token: 0x06009BD9 RID: 39897 RVA: 0x00178054 File Offset: 0x00176254
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

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06009BDA RID: 39898 RVA: 0x0017806B File Offset: 0x0017626B
		// (set) Token: 0x06009BDB RID: 39899 RVA: 0x00178084 File Offset: 0x00176284
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

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06009BDC RID: 39900 RVA: 0x0017809B File Offset: 0x0017629B
		// (set) Token: 0x06009BDD RID: 39901 RVA: 0x001780B4 File Offset: 0x001762B4
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

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06009BDE RID: 39902 RVA: 0x001780CB File Offset: 0x001762CB
		// (set) Token: 0x06009BDF RID: 39903 RVA: 0x001780E4 File Offset: 0x001762E4
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

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06009BE0 RID: 39904 RVA: 0x001780FB File Offset: 0x001762FB
		// (set) Token: 0x06009BE1 RID: 39905 RVA: 0x00178114 File Offset: 0x00176314
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

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x06009BE2 RID: 39906 RVA: 0x0017812B File Offset: 0x0017632B
		// (set) Token: 0x06009BE3 RID: 39907 RVA: 0x00178144 File Offset: 0x00176344
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

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06009BE4 RID: 39908 RVA: 0x0017815B File Offset: 0x0017635B
		// (set) Token: 0x06009BE5 RID: 39909 RVA: 0x00178174 File Offset: 0x00176374
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

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06009BE6 RID: 39910 RVA: 0x0017818B File Offset: 0x0017638B
		// (set) Token: 0x06009BE7 RID: 39911 RVA: 0x001781A4 File Offset: 0x001763A4
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

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06009BE8 RID: 39912 RVA: 0x001781BB File Offset: 0x001763BB
		// (set) Token: 0x06009BE9 RID: 39913 RVA: 0x001781D4 File Offset: 0x001763D4
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

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06009BEA RID: 39914 RVA: 0x001781EB File Offset: 0x001763EB
		// (set) Token: 0x06009BEB RID: 39915 RVA: 0x00178204 File Offset: 0x00176404
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

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06009BEC RID: 39916 RVA: 0x0017821B File Offset: 0x0017641B
		// (set) Token: 0x06009BED RID: 39917 RVA: 0x00178234 File Offset: 0x00176434
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

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06009BEE RID: 39918 RVA: 0x0017824B File Offset: 0x0017644B
		// (set) Token: 0x06009BEF RID: 39919 RVA: 0x00178264 File Offset: 0x00176464
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

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06009BF0 RID: 39920 RVA: 0x0017827B File Offset: 0x0017647B
		// (set) Token: 0x06009BF1 RID: 39921 RVA: 0x00178294 File Offset: 0x00176494
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

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06009BF2 RID: 39922 RVA: 0x001782AB File Offset: 0x001764AB
		// (set) Token: 0x06009BF3 RID: 39923 RVA: 0x001782C4 File Offset: 0x001764C4
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

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06009BF4 RID: 39924 RVA: 0x001782DB File Offset: 0x001764DB
		// (set) Token: 0x06009BF5 RID: 39925 RVA: 0x001782F4 File Offset: 0x001764F4
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

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06009BF6 RID: 39926 RVA: 0x0017830B File Offset: 0x0017650B
		// (set) Token: 0x06009BF7 RID: 39927 RVA: 0x00178324 File Offset: 0x00176524
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

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06009BF8 RID: 39928 RVA: 0x0017833B File Offset: 0x0017653B
		// (set) Token: 0x06009BF9 RID: 39929 RVA: 0x00178354 File Offset: 0x00176554
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

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06009BFA RID: 39930 RVA: 0x0017836B File Offset: 0x0017656B
		// (set) Token: 0x06009BFB RID: 39931 RVA: 0x00178384 File Offset: 0x00176584
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

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06009BFC RID: 39932 RVA: 0x0017839B File Offset: 0x0017659B
		// (set) Token: 0x06009BFD RID: 39933 RVA: 0x001783B4 File Offset: 0x001765B4
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

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06009BFE RID: 39934 RVA: 0x001783CB File Offset: 0x001765CB
		// (set) Token: 0x06009BFF RID: 39935 RVA: 0x001783E4 File Offset: 0x001765E4
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

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06009C00 RID: 39936 RVA: 0x001783FB File Offset: 0x001765FB
		// (set) Token: 0x06009C01 RID: 39937 RVA: 0x00178414 File Offset: 0x00176614
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

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06009C02 RID: 39938 RVA: 0x0017842B File Offset: 0x0017662B
		// (set) Token: 0x06009C03 RID: 39939 RVA: 0x00178444 File Offset: 0x00176644
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

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06009C04 RID: 39940 RVA: 0x0017845B File Offset: 0x0017665B
		// (set) Token: 0x06009C05 RID: 39941 RVA: 0x00178474 File Offset: 0x00176674
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

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06009C06 RID: 39942 RVA: 0x0017848B File Offset: 0x0017668B
		// (set) Token: 0x06009C07 RID: 39943 RVA: 0x001784A4 File Offset: 0x001766A4
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

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06009C08 RID: 39944 RVA: 0x001784BB File Offset: 0x001766BB
		// (set) Token: 0x06009C09 RID: 39945 RVA: 0x001784D4 File Offset: 0x001766D4
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

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06009C0A RID: 39946 RVA: 0x001784EB File Offset: 0x001766EB
		// (set) Token: 0x06009C0B RID: 39947 RVA: 0x00178504 File Offset: 0x00176704
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

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06009C0C RID: 39948 RVA: 0x0017851B File Offset: 0x0017671B
		// (set) Token: 0x06009C0D RID: 39949 RVA: 0x00178534 File Offset: 0x00176734
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

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06009C0E RID: 39950 RVA: 0x0017854B File Offset: 0x0017674B
		// (set) Token: 0x06009C0F RID: 39951 RVA: 0x00178564 File Offset: 0x00176764
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

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06009C10 RID: 39952 RVA: 0x0017857B File Offset: 0x0017677B
		// (set) Token: 0x06009C11 RID: 39953 RVA: 0x00178594 File Offset: 0x00176794
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

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06009C12 RID: 39954 RVA: 0x001785AB File Offset: 0x001767AB
		// (set) Token: 0x06009C13 RID: 39955 RVA: 0x001785C4 File Offset: 0x001767C4
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

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06009C14 RID: 39956 RVA: 0x001785DB File Offset: 0x001767DB
		// (set) Token: 0x06009C15 RID: 39957 RVA: 0x001785F4 File Offset: 0x001767F4
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

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06009C16 RID: 39958 RVA: 0x0017860B File Offset: 0x0017680B
		// (set) Token: 0x06009C17 RID: 39959 RVA: 0x00178624 File Offset: 0x00176824
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

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06009C18 RID: 39960 RVA: 0x0017863B File Offset: 0x0017683B
		// (set) Token: 0x06009C19 RID: 39961 RVA: 0x00178657 File Offset: 0x00176857
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

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06009C1A RID: 39962 RVA: 0x00178671 File Offset: 0x00176871
		// (set) Token: 0x06009C1B RID: 39963 RVA: 0x0017868D File Offset: 0x0017688D
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

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06009C1C RID: 39964 RVA: 0x001786A7 File Offset: 0x001768A7
		// (set) Token: 0x06009C1D RID: 39965 RVA: 0x001786C3 File Offset: 0x001768C3
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

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06009C1E RID: 39966 RVA: 0x001786DD File Offset: 0x001768DD
		// (set) Token: 0x06009C1F RID: 39967 RVA: 0x001786F9 File Offset: 0x001768F9
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

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06009C20 RID: 39968 RVA: 0x00178713 File Offset: 0x00176913
		// (set) Token: 0x06009C21 RID: 39969 RVA: 0x0017872F File Offset: 0x0017692F
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

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06009C22 RID: 39970 RVA: 0x00178749 File Offset: 0x00176949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb.CtxInfoOneofCase CtxInfoCase
		{
			get
			{
				return this.ctxInfoCase_;
			}
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x00178751 File Offset: 0x00176951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCtxInfo()
		{
			this.ctxInfoCase_ = GameCtxPb.CtxInfoOneofCase.None;
			this.ctxInfo_ = null;
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x00178761 File Offset: 0x00176961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameCtxPb);
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x00178770 File Offset: 0x00176970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameCtxPb other)
		{
			return other != null && (other == this || (this.CtxType == other.CtxType && object.Equals(this.BehaviorTree, other.BehaviorTree) && object.Equals(this.Entity, other.Entity) && object.Equals(this.NormalInteract, other.NormalInteract) && object.Equals(this.DynamicInteract, other.DynamicInteract) && object.Equals(this.RandomInteract, other.RandomInteract) && object.Equals(this.StateChangeAction, other.StateChangeAction) && object.Equals(this.EntityGroupAction, other.EntityGroupAction) && object.Equals(this.EntityTrigger, other.EntityTrigger) && object.Equals(this.EntityLeaveTriggerCtx, other.EntityLeaveTriggerCtx) && object.Equals(this.EntityDestructible, other.EntityDestructible) && object.Equals(this.EntityTimelineTrack, other.EntityTimelineTrack) && object.Equals(this.LevelPlayOpenAction, other.LevelPlayOpenAction) && object.Equals(this.LevelPlayRewardAction, other.LevelPlayRewardAction) && object.Equals(this.QuestActiveAction, other.QuestActiveAction) && object.Equals(this.QuestAcceptAction, other.QuestAcceptAction) && object.Equals(this.QuestFinishAction, other.QuestFinishAction) && object.Equals(this.ChildQuestNodeEnterAction, other.ChildQuestNodeEnterAction) && object.Equals(this.ChildQuestNodeFinishAction, other.ChildQuestNodeFinishAction) && object.Equals(this.SuccessNodeAction, other.SuccessNodeAction) && object.Equals(this.FailedNodeAction, other.FailedNodeAction) && object.Equals(this.CompositionEnterAction, other.CompositionEnterAction) && object.Equals(this.EntityConditionListeningAction, other.EntityConditionListeningAction) && object.Equals(this.PlayFlowChildQuestNode, other.PlayFlowChildQuestNode) && object.Equals(this.HandInItemChildQuestNode, other.HandInItemChildQuestNode) && object.Equals(this.DoInteractChildQuestNode, other.DoInteractChildQuestNode) && object.Equals(this.ActionGroupNodeAction, other.ActionGroupNodeAction) && object.Equals(this.ExploreSkillPullGiantAction, other.ExploreSkillPullGiantAction) && object.Equals(this.LevelPlay, other.LevelPlay) && object.Equals(this.GmLevelAction, other.GmLevelAction) && object.Equals(this.LifeCycleCreateAction, other.LifeCycleCreateAction) && object.Equals(this.LifeCycleDestroyAction, other.LifeCycleDestroyAction) && object.Equals(this.FlowAction, other.FlowAction) && object.Equals(this.DailyQuestTerminateAction, other.DailyQuestTerminateAction) && object.Equals(this.EntityBeamReceiveAction, other.EntityBeamReceiveAction) && object.Equals(this.EntityGroupFailureAction, other.EntityGroupFailureAction) && object.Equals(this.StateChangeConditionAction, other.StateChangeConditionAction) && object.Equals(this.FlowStartTeleport, other.FlowStartTeleport) && object.Equals(this.LeaveInstEscAction, other.LeaveInstEscAction) && object.Equals(this.TrampleActive, other.TrampleActive) && object.Equals(this.TrampleDeActive, other.TrampleDeActive) && object.Equals(this.RenjuCompleteAction, other.RenjuCompleteAction) && object.Equals(this.JigsawFoundationMatchedAction, other.JigsawFoundationMatchedAction) && object.Equals(this.JigsawFoundationUnMatchedActionCtx, other.JigsawFoundationUnMatchedActionCtx) && object.Equals(this.HookLockPointAction, other.HookLockPointAction) && object.Equals(this.ClientTriggerAction, other.ClientTriggerAction) && object.Equals(this.ExploreSkillCustomAction, other.ExploreSkillCustomAction) && object.Equals(this.JigsawFoundationMatchedConditionAction, other.JigsawFoundationMatchedConditionAction) && object.Equals(this.LevelPlayDestroyAction, other.LevelPlayDestroyAction) && object.Equals(this.TemplateSpawnerAction, other.TemplateSpawnerAction) && object.Equals(this.QuestDestroyAction, other.QuestDestroyAction) && object.Equals(this.CompositionConditionEnterAction, other.CompositionConditionEnterAction) && object.Equals(this.TargetGearHitPartCtxAction, other.TargetGearHitPartCtxAction) && object.Equals(this.GlobalFix, other.GlobalFix) && object.Equals(this.StuckCheckCtxPb, other.StuckCheckCtxPb) && object.Equals(this.AfterConditionActionCtxPb, other.AfterConditionActionCtxPb) && object.Equals(this.MotorSliderCtxPb, other.MotorSliderCtxPb) && object.Equals(this.RollBlockGamePlayActionCtxPb, other.RollBlockGamePlayActionCtxPb) && object.Equals(this.TransferCtxPb, other.TransferCtxPb) && object.Equals(this.DynamicEntityRewardCtxPb, other.DynamicEntityRewardCtxPb) && object.Equals(this.BeamCastHitPlayerActionCtxPb, other.BeamCastHitPlayerActionCtxPb) && object.Equals(this.ExploreSkillAction, other.ExploreSkillAction) && object.Equals(this.PollutionRangeAction, other.PollutionRangeAction) && object.Equals(this.EntityQuickHackSkillAction, other.EntityQuickHackSkillAction) && object.Equals(this.RecallQuestActiveAction, other.RecallQuestActiveAction) && object.Equals(this.RecallQuestAcceptAction, other.RecallQuestAcceptAction) && object.Equals(this.RecallQuestFinishAction, other.RecallQuestFinishAction) && object.Equals(this.RecallQuestDestroyAction, other.RecallQuestDestroyAction) && object.Equals(this.EdDebugEnterAction, other.EdDebugEnterAction) && object.Equals(this.CasketTrigger, other.CasketTrigger) && object.Equals(this.FoundationOperateAction, other.FoundationOperateAction) && object.Equals(this.TargetGearActionByHitTypeAction, other.TargetGearActionByHitTypeAction) && object.Equals(this.LongPressInteractActionCtxPb, other.LongPressInteractActionCtxPb) && this.CtxInfoCase == other.CtxInfoCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x00178DA4 File Offset: 0x00176FA4
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

		// Token: 0x06009C27 RID: 39975 RVA: 0x001794BA File Offset: 0x001776BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x001794C7 File Offset: 0x001776C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x001794D0 File Offset: 0x001776D0
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

		// Token: 0x06009C2A RID: 39978 RVA: 0x00179E88 File Offset: 0x00178088
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

		// Token: 0x06009C2B RID: 39979 RVA: 0x0017A620 File Offset: 0x00178820
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

		// Token: 0x06009C2C RID: 39980 RVA: 0x0017B341 File Offset: 0x00179541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C2D RID: 39981 RVA: 0x0017B34C File Offset: 0x0017954C
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

		// Token: 0x04004968 RID: 18792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004969 RID: 18793
		public const int CtxTypeFieldNumber = 1;

		// Token: 0x0400496A RID: 18794
		private GameCtxType ctxType_;

		// Token: 0x0400496B RID: 18795
		public const int BehaviorTreeFieldNumber = 2;

		// Token: 0x0400496C RID: 18796
		public const int EntityFieldNumber = 3;

		// Token: 0x0400496D RID: 18797
		public const int NormalInteractFieldNumber = 4;

		// Token: 0x0400496E RID: 18798
		public const int DynamicInteractFieldNumber = 5;

		// Token: 0x0400496F RID: 18799
		public const int RandomInteractFieldNumber = 6;

		// Token: 0x04004970 RID: 18800
		public const int StateChangeActionFieldNumber = 7;

		// Token: 0x04004971 RID: 18801
		public const int EntityGroupActionFieldNumber = 8;

		// Token: 0x04004972 RID: 18802
		public const int EntityTriggerFieldNumber = 9;

		// Token: 0x04004973 RID: 18803
		public const int EntityLeaveTriggerCtxFieldNumber = 10;

		// Token: 0x04004974 RID: 18804
		public const int EntityDestructibleFieldNumber = 11;

		// Token: 0x04004975 RID: 18805
		public const int EntityTimelineTrackFieldNumber = 12;

		// Token: 0x04004976 RID: 18806
		public const int LevelPlayOpenActionFieldNumber = 13;

		// Token: 0x04004977 RID: 18807
		public const int LevelPlayRewardActionFieldNumber = 14;

		// Token: 0x04004978 RID: 18808
		public const int QuestActiveActionFieldNumber = 15;

		// Token: 0x04004979 RID: 18809
		public const int QuestAcceptActionFieldNumber = 16;

		// Token: 0x0400497A RID: 18810
		public const int QuestFinishActionFieldNumber = 17;

		// Token: 0x0400497B RID: 18811
		public const int ChildQuestNodeEnterActionFieldNumber = 18;

		// Token: 0x0400497C RID: 18812
		public const int ChildQuestNodeFinishActionFieldNumber = 19;

		// Token: 0x0400497D RID: 18813
		public const int SuccessNodeActionFieldNumber = 20;

		// Token: 0x0400497E RID: 18814
		public const int FailedNodeActionFieldNumber = 21;

		// Token: 0x0400497F RID: 18815
		public const int CompositionEnterActionFieldNumber = 22;

		// Token: 0x04004980 RID: 18816
		public const int EntityConditionListeningActionFieldNumber = 23;

		// Token: 0x04004981 RID: 18817
		public const int PlayFlowChildQuestNodeFieldNumber = 24;

		// Token: 0x04004982 RID: 18818
		public const int HandInItemChildQuestNodeFieldNumber = 25;

		// Token: 0x04004983 RID: 18819
		public const int DoInteractChildQuestNodeFieldNumber = 26;

		// Token: 0x04004984 RID: 18820
		public const int ActionGroupNodeActionFieldNumber = 27;

		// Token: 0x04004985 RID: 18821
		public const int ExploreSkillPullGiantActionFieldNumber = 28;

		// Token: 0x04004986 RID: 18822
		public const int LevelPlayFieldNumber = 29;

		// Token: 0x04004987 RID: 18823
		public const int GmLevelActionFieldNumber = 30;

		// Token: 0x04004988 RID: 18824
		public const int LifeCycleCreateActionFieldNumber = 31;

		// Token: 0x04004989 RID: 18825
		public const int LifeCycleDestroyActionFieldNumber = 32;

		// Token: 0x0400498A RID: 18826
		public const int FlowActionFieldNumber = 33;

		// Token: 0x0400498B RID: 18827
		public const int DailyQuestTerminateActionFieldNumber = 34;

		// Token: 0x0400498C RID: 18828
		public const int EntityBeamReceiveActionFieldNumber = 35;

		// Token: 0x0400498D RID: 18829
		public const int EntityGroupFailureActionFieldNumber = 36;

		// Token: 0x0400498E RID: 18830
		public const int StateChangeConditionActionFieldNumber = 37;

		// Token: 0x0400498F RID: 18831
		public const int FlowStartTeleportFieldNumber = 38;

		// Token: 0x04004990 RID: 18832
		public const int LeaveInstEscActionFieldNumber = 39;

		// Token: 0x04004991 RID: 18833
		public const int TrampleActiveFieldNumber = 40;

		// Token: 0x04004992 RID: 18834
		public const int TrampleDeActiveFieldNumber = 41;

		// Token: 0x04004993 RID: 18835
		public const int RenjuCompleteActionFieldNumber = 42;

		// Token: 0x04004994 RID: 18836
		public const int JigsawFoundationMatchedActionFieldNumber = 43;

		// Token: 0x04004995 RID: 18837
		public const int JigsawFoundationUnMatchedActionCtxFieldNumber = 44;

		// Token: 0x04004996 RID: 18838
		public const int HookLockPointActionFieldNumber = 45;

		// Token: 0x04004997 RID: 18839
		public const int ClientTriggerActionFieldNumber = 46;

		// Token: 0x04004998 RID: 18840
		public const int ExploreSkillCustomActionFieldNumber = 47;

		// Token: 0x04004999 RID: 18841
		public const int JigsawFoundationMatchedConditionActionFieldNumber = 48;

		// Token: 0x0400499A RID: 18842
		public const int LevelPlayDestroyActionFieldNumber = 49;

		// Token: 0x0400499B RID: 18843
		public const int TemplateSpawnerActionFieldNumber = 50;

		// Token: 0x0400499C RID: 18844
		public const int QuestDestroyActionFieldNumber = 51;

		// Token: 0x0400499D RID: 18845
		public const int CompositionConditionEnterActionFieldNumber = 52;

		// Token: 0x0400499E RID: 18846
		public const int TargetGearHitPartCtxActionFieldNumber = 53;

		// Token: 0x0400499F RID: 18847
		public const int GlobalFixFieldNumber = 54;

		// Token: 0x040049A0 RID: 18848
		public const int StuckCheckCtxPbFieldNumber = 55;

		// Token: 0x040049A1 RID: 18849
		public const int AfterConditionActionCtxPbFieldNumber = 56;

		// Token: 0x040049A2 RID: 18850
		public const int MotorSliderCtxPbFieldNumber = 58;

		// Token: 0x040049A3 RID: 18851
		public const int RollBlockGamePlayActionCtxPbFieldNumber = 59;

		// Token: 0x040049A4 RID: 18852
		public const int TransferCtxPbFieldNumber = 60;

		// Token: 0x040049A5 RID: 18853
		public const int DynamicEntityRewardCtxPbFieldNumber = 61;

		// Token: 0x040049A6 RID: 18854
		public const int BeamCastHitPlayerActionCtxPbFieldNumber = 62;

		// Token: 0x040049A7 RID: 18855
		public const int ExploreSkillActionFieldNumber = 63;

		// Token: 0x040049A8 RID: 18856
		public const int PollutionRangeActionFieldNumber = 64;

		// Token: 0x040049A9 RID: 18857
		public const int EntityQuickHackSkillActionFieldNumber = 65;

		// Token: 0x040049AA RID: 18858
		public const int RecallQuestActiveActionFieldNumber = 66;

		// Token: 0x040049AB RID: 18859
		public const int RecallQuestAcceptActionFieldNumber = 67;

		// Token: 0x040049AC RID: 18860
		public const int RecallQuestFinishActionFieldNumber = 68;

		// Token: 0x040049AD RID: 18861
		public const int RecallQuestDestroyActionFieldNumber = 69;

		// Token: 0x040049AE RID: 18862
		public const int EdDebugEnterActionFieldNumber = 3401;

		// Token: 0x040049AF RID: 18863
		public const int CasketTriggerFieldNumber = 3501;

		// Token: 0x040049B0 RID: 18864
		public const int FoundationOperateActionFieldNumber = 3502;

		// Token: 0x040049B1 RID: 18865
		public const int TargetGearActionByHitTypeActionFieldNumber = 3701;

		// Token: 0x040049B2 RID: 18866
		public const int LongPressInteractActionCtxPbFieldNumber = 3702;

		// Token: 0x040049B3 RID: 18867
		private object ctxInfo_;

		// Token: 0x040049B4 RID: 18868
		private GameCtxPb.CtxInfoOneofCase ctxInfoCase_;

		// Token: 0x020017C7 RID: 6087
		public enum CtxInfoOneofCase
		{
			// Token: 0x0400C713 RID: 50963
			None,
			// Token: 0x0400C714 RID: 50964
			BehaviorTree = 2,
			// Token: 0x0400C715 RID: 50965
			Entity,
			// Token: 0x0400C716 RID: 50966
			NormalInteract,
			// Token: 0x0400C717 RID: 50967
			DynamicInteract,
			// Token: 0x0400C718 RID: 50968
			RandomInteract,
			// Token: 0x0400C719 RID: 50969
			StateChangeAction,
			// Token: 0x0400C71A RID: 50970
			EntityGroupAction,
			// Token: 0x0400C71B RID: 50971
			EntityTrigger,
			// Token: 0x0400C71C RID: 50972
			EntityLeaveTriggerCtx,
			// Token: 0x0400C71D RID: 50973
			EntityDestructible,
			// Token: 0x0400C71E RID: 50974
			EntityTimelineTrack,
			// Token: 0x0400C71F RID: 50975
			LevelPlayOpenAction,
			// Token: 0x0400C720 RID: 50976
			LevelPlayRewardAction,
			// Token: 0x0400C721 RID: 50977
			QuestActiveAction,
			// Token: 0x0400C722 RID: 50978
			QuestAcceptAction,
			// Token: 0x0400C723 RID: 50979
			QuestFinishAction,
			// Token: 0x0400C724 RID: 50980
			ChildQuestNodeEnterAction,
			// Token: 0x0400C725 RID: 50981
			ChildQuestNodeFinishAction,
			// Token: 0x0400C726 RID: 50982
			SuccessNodeAction,
			// Token: 0x0400C727 RID: 50983
			FailedNodeAction,
			// Token: 0x0400C728 RID: 50984
			CompositionEnterAction,
			// Token: 0x0400C729 RID: 50985
			EntityConditionListeningAction,
			// Token: 0x0400C72A RID: 50986
			PlayFlowChildQuestNode,
			// Token: 0x0400C72B RID: 50987
			HandInItemChildQuestNode,
			// Token: 0x0400C72C RID: 50988
			DoInteractChildQuestNode,
			// Token: 0x0400C72D RID: 50989
			ActionGroupNodeAction,
			// Token: 0x0400C72E RID: 50990
			ExploreSkillPullGiantAction,
			// Token: 0x0400C72F RID: 50991
			LevelPlay,
			// Token: 0x0400C730 RID: 50992
			GmLevelAction,
			// Token: 0x0400C731 RID: 50993
			LifeCycleCreateAction,
			// Token: 0x0400C732 RID: 50994
			LifeCycleDestroyAction,
			// Token: 0x0400C733 RID: 50995
			FlowAction,
			// Token: 0x0400C734 RID: 50996
			DailyQuestTerminateAction,
			// Token: 0x0400C735 RID: 50997
			EntityBeamReceiveAction,
			// Token: 0x0400C736 RID: 50998
			EntityGroupFailureAction,
			// Token: 0x0400C737 RID: 50999
			StateChangeConditionAction,
			// Token: 0x0400C738 RID: 51000
			FlowStartTeleport,
			// Token: 0x0400C739 RID: 51001
			LeaveInstEscAction,
			// Token: 0x0400C73A RID: 51002
			TrampleActive,
			// Token: 0x0400C73B RID: 51003
			TrampleDeActive,
			// Token: 0x0400C73C RID: 51004
			RenjuCompleteAction,
			// Token: 0x0400C73D RID: 51005
			JigsawFoundationMatchedAction,
			// Token: 0x0400C73E RID: 51006
			JigsawFoundationUnMatchedActionCtx,
			// Token: 0x0400C73F RID: 51007
			HookLockPointAction,
			// Token: 0x0400C740 RID: 51008
			ClientTriggerAction,
			// Token: 0x0400C741 RID: 51009
			ExploreSkillCustomAction,
			// Token: 0x0400C742 RID: 51010
			JigsawFoundationMatchedConditionAction,
			// Token: 0x0400C743 RID: 51011
			LevelPlayDestroyAction,
			// Token: 0x0400C744 RID: 51012
			TemplateSpawnerAction,
			// Token: 0x0400C745 RID: 51013
			QuestDestroyAction,
			// Token: 0x0400C746 RID: 51014
			CompositionConditionEnterAction,
			// Token: 0x0400C747 RID: 51015
			TargetGearHitPartCtxAction,
			// Token: 0x0400C748 RID: 51016
			GlobalFix,
			// Token: 0x0400C749 RID: 51017
			StuckCheckCtxPb,
			// Token: 0x0400C74A RID: 51018
			AfterConditionActionCtxPb,
			// Token: 0x0400C74B RID: 51019
			MotorSliderCtxPb = 58,
			// Token: 0x0400C74C RID: 51020
			RollBlockGamePlayActionCtxPb,
			// Token: 0x0400C74D RID: 51021
			TransferCtxPb,
			// Token: 0x0400C74E RID: 51022
			DynamicEntityRewardCtxPb,
			// Token: 0x0400C74F RID: 51023
			BeamCastHitPlayerActionCtxPb,
			// Token: 0x0400C750 RID: 51024
			ExploreSkillAction,
			// Token: 0x0400C751 RID: 51025
			PollutionRangeAction,
			// Token: 0x0400C752 RID: 51026
			EntityQuickHackSkillAction,
			// Token: 0x0400C753 RID: 51027
			RecallQuestActiveAction,
			// Token: 0x0400C754 RID: 51028
			RecallQuestAcceptAction,
			// Token: 0x0400C755 RID: 51029
			RecallQuestFinishAction,
			// Token: 0x0400C756 RID: 51030
			RecallQuestDestroyAction,
			// Token: 0x0400C757 RID: 51031
			EdDebugEnterAction = 3401,
			// Token: 0x0400C758 RID: 51032
			CasketTrigger = 3501,
			// Token: 0x0400C759 RID: 51033
			FoundationOperateAction,
			// Token: 0x0400C75A RID: 51034
			TargetGearActionByHitTypeAction = 3701,
			// Token: 0x0400C75B RID: 51035
			LongPressInteractActionCtxPb
		}
	}
}
