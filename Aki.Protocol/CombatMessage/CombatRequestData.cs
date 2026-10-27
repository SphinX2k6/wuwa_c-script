using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200168B RID: 5771
	public sealed class CombatRequestData : IMessage<CombatRequestData>, IMessage, IEquatable<CombatRequestData>, IDeepCloneable<CombatRequestData>, IBufferMessage
	{
		// Token: 0x0601CD8B RID: 118155 RVA: 0x0043141D File Offset: 0x0042F61D
		[NullableContext(1)]
		public static CombatRequestData Create()
		{
			return new CombatRequestData();
		}

		// Token: 0x17006186 RID: 24966
		// (get) Token: 0x0601CD8C RID: 118156 RVA: 0x00431424 File Offset: 0x0042F624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006187 RID: 24967
		// (get) Token: 0x0601CD8D RID: 118157 RVA: 0x00431427 File Offset: 0x0042F627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatRequestData.Descriptor;
			}
		}

		// Token: 0x0601CD8E RID: 118158 RVA: 0x0043142E File Offset: 0x0042F62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData()
		{
		}

		// Token: 0x0601CD8F RID: 118159 RVA: 0x00431438 File Offset: 0x0042F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData(CombatRequestData other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.requestId_ = other.requestId_;
			switch (other.MessageCase)
			{
			case CombatRequestData.MessageOneofCase.CreateBulletRequest:
				this.CreateBulletRequest = other.CreateBulletRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DestroyBulletRequest:
				this.DestroyBulletRequest = other.DestroyBulletRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DamageExecuteRequest:
				this.DamageExecuteRequest = other.DamageExecuteRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest:
				this.ApplyGameplayEffectRequest = other.ApplyGameplayEffectRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest:
				this.RemoveGameplayEffectRequest = other.RemoveGameplayEffectRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.HitRequest:
				this.HitRequest = other.HitRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.HitEndRequest:
				this.HitEndRequest = other.HitEndRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SkillRequest:
				this.SkillRequest = other.SkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.UseSkillRequest:
				this.UseSkillRequest = other.UseSkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EndSkillRequest:
				this.EndSkillRequest = other.EndSkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.PartUpdateRequest:
				this.PartUpdateRequest = other.PartUpdateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.MaterialRequest:
				this.MaterialRequest = other.MaterialRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.GameplayCueRequest:
				this.GameplayCueRequest = other.GameplayCueRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EntityIsVisibleRequest:
				this.EntityIsVisibleRequest = other.EntityIsVisibleRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest:
				this.SwitchCharacterStateRequest = other.SwitchCharacterStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.LogicStateInitRequest:
				this.LogicStateInitRequest = other.LogicStateInitRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SwitchLogicStateRequest:
				this.SwitchLogicStateRequest = other.SwitchLogicStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateChangedRequest:
				this.AnimationStateChangedRequest = other.AnimationStateChangedRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateInitRequest:
				this.AnimationStateInitRequest = other.AnimationStateInitRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest:
				this.ModifyBulletParamsRequest = other.ModifyBulletParamsRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DrownRequest:
				this.DrownRequest = other.DrownRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.OrderApplyBuffRequest:
				this.OrderApplyBuffRequest = other.OrderApplyBuffRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest:
				this.OrderRemoveBuffRequest = other.OrderRemoveBuffRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ActivateBuffRequest:
				this.ActivateBuffRequest = other.ActivateBuffRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest:
				this.OrderRemoveBuffByTagsRequest = other.OrderRemoveBuffByTagsRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiInformationRequest:
				this.AiInformationRequest = other.AiInformationRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest:
				this.ToughCalcExtraRatioChangeRequest = other.ToughCalcExtraRatioChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BattleStateChangeRequest:
				this.BattleStateChangeRequest = other.BattleStateChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest:
				this.AnimationGameplayTagRequest = other.AnimationGameplayTagRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest:
				this.BoneVisibleChangeRequest = other.BoneVisibleChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardsRequest:
				this.AiBlackboardsRequest = other.AiBlackboardsRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardCdRequest:
				this.AiBlackboardCdRequest = other.AiBlackboardCdRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiHateRequest:
				this.AiHateRequest = other.AiHateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.MonsterBoomRequest:
				this.MonsterBoomRequest = other.MonsterBoomRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.CaughtRequest:
				this.CaughtRequest = other.CaughtRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest:
				this.EntityStaticHookMoveRequest = other.EntityStaticHookMoveRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateRequest:
				this.ChangeStateRequest = other.ChangeStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest:
				this.ChangeStateConfirmRequest = other.ChangeStateConfirmRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FsmConditionPassRequest:
				this.FsmConditionPassRequest = other.FsmConditionPassRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BuffStackCountRequest:
				this.BuffStackCountRequest = other.BuffStackCountRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ANStartRequest:
				this.ANStartRequest = other.ANStartRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.UseSkillFailRequest:
				this.UseSkillFailRequest = other.UseSkillFailRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EnterViewDirectionRequest:
				this.EnterViewDirectionRequest = other.EnterViewDirectionRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ExitViewDirectionRequest:
				this.ExitViewDirectionRequest = other.ExitViewDirectionRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillAddRequest:
				this.PassiveSkillAddRequest = other.PassiveSkillAddRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest:
				this.InterruptSkillInDelayRequest = other.InterruptSkillInDelayRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.TriggerExitSkillRequest:
				this.TriggerExitSkillRequest = other.TriggerExitSkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ActorVisibleRequest:
				this.ActorVisibleRequest = other.ActorVisibleRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BuffEffectRequest:
				this.BuffEffectRequest = other.BuffEffectRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FragileChangeRequest:
				this.FragileChangeRequest = other.FragileChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopRequest:
				this.RTimeStopRequest = other.RTimeStopRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DrownEndTeleportRequest:
				this.DrownEndTeleportRequest = other.DrownEndTeleportRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.MonsterDrownRequest:
				this.MonsterDrownRequest = other.MonsterDrownRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest:
				this.PassiveSkillRemoveRequest = other.PassiveSkillRemoveRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopInstRequest:
				this.RTimeStopInstRequest = other.RTimeStopInstRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest:
				this.FsmStateBehaviorRequest = other.FsmStateBehaviorRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FsmPlayMontageRequest:
				this.FsmPlayMontageRequest = other.FsmPlayMontageRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopAnimRequest:
				this.RTimeStopAnimRequest = other.RTimeStopAnimRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SwitchRoleRequest:
				this.SwitchRoleRequest = other.SwitchRoleRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.GameplayTagRequest:
				this.GameplayTagRequest = other.GameplayTagRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ExecuteQteRequest:
				this.ExecuteQteRequest = other.ExecuteQteRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.CombineEntitiesRequest:
				this.CombineEntitiesRequest = other.CombineEntitiesRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest:
				this.DissolveCombineRelationRequest = other.DissolveCombineRelationRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest:
				this.ClientCurrentRoleReportRequest = other.ClientCurrentRoleReportRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest:
				this.GaSwitchCommonEnemyProCampRequest = other.GaSwitchCommonEnemyProCampRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest:
				this.ChangeSummonEntityStateRequest = other.ChangeSummonEntityStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest:
				this.CombatMaxCaseMessageRequest = other.CombatMaxCaseMessageRequest.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD90 RID: 118160 RVA: 0x00431BC7 File Offset: 0x0042FDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData Clone()
		{
			return new CombatRequestData(this);
		}

		// Token: 0x17006188 RID: 24968
		// (get) Token: 0x0601CD91 RID: 118161 RVA: 0x00431BCF File Offset: 0x0042FDCF
		// (set) Token: 0x0601CD92 RID: 118162 RVA: 0x00431BD7 File Offset: 0x0042FDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17006189 RID: 24969
		// (get) Token: 0x0601CD93 RID: 118163 RVA: 0x00431BE0 File Offset: 0x0042FDE0
		// (set) Token: 0x0601CD94 RID: 118164 RVA: 0x00431BE8 File Offset: 0x0042FDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RequestId
		{
			get
			{
				return this.requestId_;
			}
			set
			{
				this.requestId_ = value;
			}
		}

		// Token: 0x1700618A RID: 24970
		// (get) Token: 0x0601CD95 RID: 118165 RVA: 0x00431BF1 File Offset: 0x0042FDF1
		// (set) Token: 0x0601CD96 RID: 118166 RVA: 0x00431C09 File Offset: 0x0042FE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletRequest CreateBulletRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CreateBulletRequest)
				{
					return null;
				}
				return (CreateBulletRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CreateBulletRequest);
			}
		}

		// Token: 0x1700618B RID: 24971
		// (get) Token: 0x0601CD97 RID: 118167 RVA: 0x00431C1F File Offset: 0x0042FE1F
		// (set) Token: 0x0601CD98 RID: 118168 RVA: 0x00431C37 File Offset: 0x0042FE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest DestroyBulletRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DestroyBulletRequest)
				{
					return null;
				}
				return (DestroyBulletRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DestroyBulletRequest);
			}
		}

		// Token: 0x1700618C RID: 24972
		// (get) Token: 0x0601CD99 RID: 118169 RVA: 0x00431C4D File Offset: 0x0042FE4D
		// (set) Token: 0x0601CD9A RID: 118170 RVA: 0x00431C65 File Offset: 0x0042FE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteRequest DamageExecuteRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DamageExecuteRequest)
				{
					return null;
				}
				return (DamageExecuteRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DamageExecuteRequest);
			}
		}

		// Token: 0x1700618D RID: 24973
		// (get) Token: 0x0601CD9B RID: 118171 RVA: 0x00431C7B File Offset: 0x0042FE7B
		// (set) Token: 0x0601CD9C RID: 118172 RVA: 0x00431C93 File Offset: 0x0042FE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectRequest ApplyGameplayEffectRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
				{
					return null;
				}
				return (ApplyGameplayEffectRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest);
			}
		}

		// Token: 0x1700618E RID: 24974
		// (get) Token: 0x0601CD9D RID: 118173 RVA: 0x00431CA9 File Offset: 0x0042FEA9
		// (set) Token: 0x0601CD9E RID: 118174 RVA: 0x00431CC1 File Offset: 0x0042FEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest RemoveGameplayEffectRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
				{
					return null;
				}
				return (RemoveGameplayEffectRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest);
			}
		}

		// Token: 0x1700618F RID: 24975
		// (get) Token: 0x0601CD9F RID: 118175 RVA: 0x00431CD7 File Offset: 0x0042FED7
		// (set) Token: 0x0601CDA0 RID: 118176 RVA: 0x00431CEF File Offset: 0x0042FEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest HitRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.HitRequest)
				{
					return null;
				}
				return (HitRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.HitRequest);
			}
		}

		// Token: 0x17006190 RID: 24976
		// (get) Token: 0x0601CDA1 RID: 118177 RVA: 0x00431D05 File Offset: 0x0042FF05
		// (set) Token: 0x0601CDA2 RID: 118178 RVA: 0x00431D1E File Offset: 0x0042FF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest HitEndRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.HitEndRequest)
				{
					return null;
				}
				return (HitEndRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.HitEndRequest);
			}
		}

		// Token: 0x17006191 RID: 24977
		// (get) Token: 0x0601CDA3 RID: 118179 RVA: 0x00431D35 File Offset: 0x0042FF35
		// (set) Token: 0x0601CDA4 RID: 118180 RVA: 0x00431D4E File Offset: 0x0042FF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest SkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SkillRequest)
				{
					return null;
				}
				return (SkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SkillRequest);
			}
		}

		// Token: 0x17006192 RID: 24978
		// (get) Token: 0x0601CDA5 RID: 118181 RVA: 0x00431D65 File Offset: 0x0042FF65
		// (set) Token: 0x0601CDA6 RID: 118182 RVA: 0x00431D7E File Offset: 0x0042FF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillRequest UseSkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.UseSkillRequest)
				{
					return null;
				}
				return (UseSkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.UseSkillRequest);
			}
		}

		// Token: 0x17006193 RID: 24979
		// (get) Token: 0x0601CDA7 RID: 118183 RVA: 0x00431D95 File Offset: 0x0042FF95
		// (set) Token: 0x0601CDA8 RID: 118184 RVA: 0x00431DAE File Offset: 0x0042FFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillRequest EndSkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EndSkillRequest)
				{
					return null;
				}
				return (EndSkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EndSkillRequest);
			}
		}

		// Token: 0x17006194 RID: 24980
		// (get) Token: 0x0601CDA9 RID: 118185 RVA: 0x00431DC5 File Offset: 0x0042FFC5
		// (set) Token: 0x0601CDAA RID: 118186 RVA: 0x00431DDE File Offset: 0x0042FFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest PartUpdateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.PartUpdateRequest)
				{
					return null;
				}
				return (PartUpdateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.PartUpdateRequest);
			}
		}

		// Token: 0x17006195 RID: 24981
		// (get) Token: 0x0601CDAB RID: 118187 RVA: 0x00431DF5 File Offset: 0x0042FFF5
		// (set) Token: 0x0601CDAC RID: 118188 RVA: 0x00431E0E File Offset: 0x0043000E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest MaterialRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.MaterialRequest)
				{
					return null;
				}
				return (MaterialRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.MaterialRequest);
			}
		}

		// Token: 0x17006196 RID: 24982
		// (get) Token: 0x0601CDAD RID: 118189 RVA: 0x00431E25 File Offset: 0x00430025
		// (set) Token: 0x0601CDAE RID: 118190 RVA: 0x00431E3E File Offset: 0x0043003E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest GameplayCueRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.GameplayCueRequest)
				{
					return null;
				}
				return (GameplayCueRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.GameplayCueRequest);
			}
		}

		// Token: 0x17006197 RID: 24983
		// (get) Token: 0x0601CDAF RID: 118191 RVA: 0x00431E55 File Offset: 0x00430055
		// (set) Token: 0x0601CDB0 RID: 118192 RVA: 0x00431E6E File Offset: 0x0043006E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest EntityIsVisibleRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
				{
					return null;
				}
				return (EntityIsVisibleRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EntityIsVisibleRequest);
			}
		}

		// Token: 0x17006198 RID: 24984
		// (get) Token: 0x0601CDB1 RID: 118193 RVA: 0x00431E85 File Offset: 0x00430085
		// (set) Token: 0x0601CDB2 RID: 118194 RVA: 0x00431E9E File Offset: 0x0043009E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateRequest SwitchCharacterStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
				{
					return null;
				}
				return (SwitchCharacterStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest);
			}
		}

		// Token: 0x17006199 RID: 24985
		// (get) Token: 0x0601CDB3 RID: 118195 RVA: 0x00431EB5 File Offset: 0x004300B5
		// (set) Token: 0x0601CDB4 RID: 118196 RVA: 0x00431ECE File Offset: 0x004300CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitRequest LogicStateInitRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.LogicStateInitRequest)
				{
					return null;
				}
				return (LogicStateInitRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.LogicStateInitRequest);
			}
		}

		// Token: 0x1700619A RID: 24986
		// (get) Token: 0x0601CDB5 RID: 118197 RVA: 0x00431EE5 File Offset: 0x004300E5
		// (set) Token: 0x0601CDB6 RID: 118198 RVA: 0x00431EFE File Offset: 0x004300FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest SwitchLogicStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
				{
					return null;
				}
				return (SwitchLogicStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SwitchLogicStateRequest);
			}
		}

		// Token: 0x1700619B RID: 24987
		// (get) Token: 0x0601CDB7 RID: 118199 RVA: 0x00431F15 File Offset: 0x00430115
		// (set) Token: 0x0601CDB8 RID: 118200 RVA: 0x00431F2E File Offset: 0x0043012E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest AnimationStateChangedRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
				{
					return null;
				}
				return (AnimationStateChangedRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AnimationStateChangedRequest);
			}
		}

		// Token: 0x1700619C RID: 24988
		// (get) Token: 0x0601CDB9 RID: 118201 RVA: 0x00431F45 File Offset: 0x00430145
		// (set) Token: 0x0601CDBA RID: 118202 RVA: 0x00431F5E File Offset: 0x0043015E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitRequest AnimationStateInitRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
				{
					return null;
				}
				return (AnimationStateInitRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AnimationStateInitRequest);
			}
		}

		// Token: 0x1700619D RID: 24989
		// (get) Token: 0x0601CDBB RID: 118203 RVA: 0x00431F75 File Offset: 0x00430175
		// (set) Token: 0x0601CDBC RID: 118204 RVA: 0x00431F8E File Offset: 0x0043018E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest ModifyBulletParamsRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
				{
					return null;
				}
				return (ModifyBulletParamsRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest);
			}
		}

		// Token: 0x1700619E RID: 24990
		// (get) Token: 0x0601CDBD RID: 118205 RVA: 0x00431FA5 File Offset: 0x004301A5
		// (set) Token: 0x0601CDBE RID: 118206 RVA: 0x00431FBE File Offset: 0x004301BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest DrownRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DrownRequest)
				{
					return null;
				}
				return (DrownRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DrownRequest);
			}
		}

		// Token: 0x1700619F RID: 24991
		// (get) Token: 0x0601CDBF RID: 118207 RVA: 0x00431FD5 File Offset: 0x004301D5
		// (set) Token: 0x0601CDC0 RID: 118208 RVA: 0x00431FEE File Offset: 0x004301EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest OrderApplyBuffRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
				{
					return null;
				}
				return (OrderApplyBuffRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.OrderApplyBuffRequest);
			}
		}

		// Token: 0x170061A0 RID: 24992
		// (get) Token: 0x0601CDC1 RID: 118209 RVA: 0x00432005 File Offset: 0x00430205
		// (set) Token: 0x0601CDC2 RID: 118210 RVA: 0x0043201E File Offset: 0x0043021E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest OrderRemoveBuffRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
				{
					return null;
				}
				return (OrderRemoveBuffRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest);
			}
		}

		// Token: 0x170061A1 RID: 24993
		// (get) Token: 0x0601CDC3 RID: 118211 RVA: 0x00432035 File Offset: 0x00430235
		// (set) Token: 0x0601CDC4 RID: 118212 RVA: 0x0043204E File Offset: 0x0043024E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest ActivateBuffRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ActivateBuffRequest)
				{
					return null;
				}
				return (ActivateBuffRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ActivateBuffRequest);
			}
		}

		// Token: 0x170061A2 RID: 24994
		// (get) Token: 0x0601CDC5 RID: 118213 RVA: 0x00432065 File Offset: 0x00430265
		// (set) Token: 0x0601CDC6 RID: 118214 RVA: 0x0043207E File Offset: 0x0043027E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest OrderRemoveBuffByTagsRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
				{
					return null;
				}
				return (OrderRemoveBuffByTagsRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest);
			}
		}

		// Token: 0x170061A3 RID: 24995
		// (get) Token: 0x0601CDC7 RID: 118215 RVA: 0x00432095 File Offset: 0x00430295
		// (set) Token: 0x0601CDC8 RID: 118216 RVA: 0x004320AE File Offset: 0x004302AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest AiInformationRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiInformationRequest)
				{
					return null;
				}
				return (AiInformationRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiInformationRequest);
			}
		}

		// Token: 0x170061A4 RID: 24996
		// (get) Token: 0x0601CDC9 RID: 118217 RVA: 0x004320C5 File Offset: 0x004302C5
		// (set) Token: 0x0601CDCA RID: 118218 RVA: 0x004320DE File Offset: 0x004302DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest ToughCalcExtraRatioChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
				{
					return null;
				}
				return (ToughCalcExtraRatioChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest);
			}
		}

		// Token: 0x170061A5 RID: 24997
		// (get) Token: 0x0601CDCB RID: 118219 RVA: 0x004320F5 File Offset: 0x004302F5
		// (set) Token: 0x0601CDCC RID: 118220 RVA: 0x0043210E File Offset: 0x0043030E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest BattleStateChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
				{
					return null;
				}
				return (BattleStateChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BattleStateChangeRequest);
			}
		}

		// Token: 0x170061A6 RID: 24998
		// (get) Token: 0x0601CDCD RID: 118221 RVA: 0x00432125 File Offset: 0x00430325
		// (set) Token: 0x0601CDCE RID: 118222 RVA: 0x0043213E File Offset: 0x0043033E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest AnimationGameplayTagRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
				{
					return null;
				}
				return (AnimationGameplayTagRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest);
			}
		}

		// Token: 0x170061A7 RID: 24999
		// (get) Token: 0x0601CDCF RID: 118223 RVA: 0x00432155 File Offset: 0x00430355
		// (set) Token: 0x0601CDD0 RID: 118224 RVA: 0x0043216E File Offset: 0x0043036E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest BoneVisibleChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
				{
					return null;
				}
				return (BoneVisibleChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest);
			}
		}

		// Token: 0x170061A8 RID: 25000
		// (get) Token: 0x0601CDD1 RID: 118225 RVA: 0x00432185 File Offset: 0x00430385
		// (set) Token: 0x0601CDD2 RID: 118226 RVA: 0x0043219E File Offset: 0x0043039E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest AiBlackboardsRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
				{
					return null;
				}
				return (AiBlackboardsRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiBlackboardsRequest);
			}
		}

		// Token: 0x170061A9 RID: 25001
		// (get) Token: 0x0601CDD3 RID: 118227 RVA: 0x004321B5 File Offset: 0x004303B5
		// (set) Token: 0x0601CDD4 RID: 118228 RVA: 0x004321CE File Offset: 0x004303CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest AiBlackboardCdRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
				{
					return null;
				}
				return (AiBlackboardCdRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiBlackboardCdRequest);
			}
		}

		// Token: 0x170061AA RID: 25002
		// (get) Token: 0x0601CDD5 RID: 118229 RVA: 0x004321E5 File Offset: 0x004303E5
		// (set) Token: 0x0601CDD6 RID: 118230 RVA: 0x004321FE File Offset: 0x004303FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest AiHateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiHateRequest)
				{
					return null;
				}
				return (AiHateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiHateRequest);
			}
		}

		// Token: 0x170061AB RID: 25003
		// (get) Token: 0x0601CDD7 RID: 118231 RVA: 0x00432215 File Offset: 0x00430415
		// (set) Token: 0x0601CDD8 RID: 118232 RVA: 0x0043222E File Offset: 0x0043042E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest MonsterBoomRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.MonsterBoomRequest)
				{
					return null;
				}
				return (MonsterBoomRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.MonsterBoomRequest);
			}
		}

		// Token: 0x170061AC RID: 25004
		// (get) Token: 0x0601CDD9 RID: 118233 RVA: 0x00432245 File Offset: 0x00430445
		// (set) Token: 0x0601CDDA RID: 118234 RVA: 0x0043225E File Offset: 0x0043045E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest CaughtRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CaughtRequest)
				{
					return null;
				}
				return (CaughtRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CaughtRequest);
			}
		}

		// Token: 0x170061AD RID: 25005
		// (get) Token: 0x0601CDDB RID: 118235 RVA: 0x00432275 File Offset: 0x00430475
		// (set) Token: 0x0601CDDC RID: 118236 RVA: 0x0043228E File Offset: 0x0043048E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest EntityStaticHookMoveRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
				{
					return null;
				}
				return (EntityStaticHookMoveRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest);
			}
		}

		// Token: 0x170061AE RID: 25006
		// (get) Token: 0x0601CDDD RID: 118237 RVA: 0x004322A5 File Offset: 0x004304A5
		// (set) Token: 0x0601CDDE RID: 118238 RVA: 0x004322BE File Offset: 0x004304BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest ChangeStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ChangeStateRequest)
				{
					return null;
				}
				return (ChangeStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ChangeStateRequest);
			}
		}

		// Token: 0x170061AF RID: 25007
		// (get) Token: 0x0601CDDF RID: 118239 RVA: 0x004322D5 File Offset: 0x004304D5
		// (set) Token: 0x0601CDE0 RID: 118240 RVA: 0x004322EE File Offset: 0x004304EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest ChangeStateConfirmRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
				{
					return null;
				}
				return (ChangeStateConfirmRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest);
			}
		}

		// Token: 0x170061B0 RID: 25008
		// (get) Token: 0x0601CDE1 RID: 118241 RVA: 0x00432305 File Offset: 0x00430505
		// (set) Token: 0x0601CDE2 RID: 118242 RVA: 0x0043231E File Offset: 0x0043051E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassRequest FsmConditionPassRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
				{
					return null;
				}
				return (FsmConditionPassRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FsmConditionPassRequest);
			}
		}

		// Token: 0x170061B1 RID: 25009
		// (get) Token: 0x0601CDE3 RID: 118243 RVA: 0x00432335 File Offset: 0x00430535
		// (set) Token: 0x0601CDE4 RID: 118244 RVA: 0x0043234E File Offset: 0x0043054E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest BuffStackCountRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BuffStackCountRequest)
				{
					return null;
				}
				return (BuffStackCountRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BuffStackCountRequest);
			}
		}

		// Token: 0x170061B2 RID: 25010
		// (get) Token: 0x0601CDE5 RID: 118245 RVA: 0x00432365 File Offset: 0x00430565
		// (set) Token: 0x0601CDE6 RID: 118246 RVA: 0x0043237E File Offset: 0x0043057E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest ANStartRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ANStartRequest)
				{
					return null;
				}
				return (ANStartRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ANStartRequest);
			}
		}

		// Token: 0x170061B3 RID: 25011
		// (get) Token: 0x0601CDE7 RID: 118247 RVA: 0x00432395 File Offset: 0x00430595
		// (set) Token: 0x0601CDE8 RID: 118248 RVA: 0x004323AE File Offset: 0x004305AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest UseSkillFailRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.UseSkillFailRequest)
				{
					return null;
				}
				return (UseSkillFailRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.UseSkillFailRequest);
			}
		}

		// Token: 0x170061B4 RID: 25012
		// (get) Token: 0x0601CDE9 RID: 118249 RVA: 0x004323C5 File Offset: 0x004305C5
		// (set) Token: 0x0601CDEA RID: 118250 RVA: 0x004323DE File Offset: 0x004305DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest EnterViewDirectionRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
				{
					return null;
				}
				return (EnterViewDirectionRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EnterViewDirectionRequest);
			}
		}

		// Token: 0x170061B5 RID: 25013
		// (get) Token: 0x0601CDEB RID: 118251 RVA: 0x004323F5 File Offset: 0x004305F5
		// (set) Token: 0x0601CDEC RID: 118252 RVA: 0x0043240E File Offset: 0x0043060E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest ExitViewDirectionRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
				{
					return null;
				}
				return (ExitViewDirectionRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ExitViewDirectionRequest);
			}
		}

		// Token: 0x170061B6 RID: 25014
		// (get) Token: 0x0601CDED RID: 118253 RVA: 0x00432425 File Offset: 0x00430625
		// (set) Token: 0x0601CDEE RID: 118254 RVA: 0x0043243E File Offset: 0x0043063E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest PassiveSkillAddRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
				{
					return null;
				}
				return (PassiveSkillAddRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.PassiveSkillAddRequest);
			}
		}

		// Token: 0x170061B7 RID: 25015
		// (get) Token: 0x0601CDEF RID: 118255 RVA: 0x00432455 File Offset: 0x00430655
		// (set) Token: 0x0601CDF0 RID: 118256 RVA: 0x0043246E File Offset: 0x0043066E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest InterruptSkillInDelayRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
				{
					return null;
				}
				return (InterruptSkillInDelayRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest);
			}
		}

		// Token: 0x170061B8 RID: 25016
		// (get) Token: 0x0601CDF1 RID: 118257 RVA: 0x00432485 File Offset: 0x00430685
		// (set) Token: 0x0601CDF2 RID: 118258 RVA: 0x0043249E File Offset: 0x0043069E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest TriggerExitSkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
				{
					return null;
				}
				return (TriggerExitSkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.TriggerExitSkillRequest);
			}
		}

		// Token: 0x170061B9 RID: 25017
		// (get) Token: 0x0601CDF3 RID: 118259 RVA: 0x004324B5 File Offset: 0x004306B5
		// (set) Token: 0x0601CDF4 RID: 118260 RVA: 0x004324CE File Offset: 0x004306CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest ActorVisibleRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ActorVisibleRequest)
				{
					return null;
				}
				return (ActorVisibleRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ActorVisibleRequest);
			}
		}

		// Token: 0x170061BA RID: 25018
		// (get) Token: 0x0601CDF5 RID: 118261 RVA: 0x004324E5 File Offset: 0x004306E5
		// (set) Token: 0x0601CDF6 RID: 118262 RVA: 0x004324FE File Offset: 0x004306FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest BuffEffectRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BuffEffectRequest)
				{
					return null;
				}
				return (BuffEffectRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BuffEffectRequest);
			}
		}

		// Token: 0x170061BB RID: 25019
		// (get) Token: 0x0601CDF7 RID: 118263 RVA: 0x00432515 File Offset: 0x00430715
		// (set) Token: 0x0601CDF8 RID: 118264 RVA: 0x0043252E File Offset: 0x0043072E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest FragileChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FragileChangeRequest)
				{
					return null;
				}
				return (FragileChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FragileChangeRequest);
			}
		}

		// Token: 0x170061BC RID: 25020
		// (get) Token: 0x0601CDF9 RID: 118265 RVA: 0x00432545 File Offset: 0x00430745
		// (set) Token: 0x0601CDFA RID: 118266 RVA: 0x0043255E File Offset: 0x0043075E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest RTimeStopRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RTimeStopRequest)
				{
					return null;
				}
				return (RTimeStopRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RTimeStopRequest);
			}
		}

		// Token: 0x170061BD RID: 25021
		// (get) Token: 0x0601CDFB RID: 118267 RVA: 0x00432575 File Offset: 0x00430775
		// (set) Token: 0x0601CDFC RID: 118268 RVA: 0x0043258E File Offset: 0x0043078E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest DrownEndTeleportRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
				{
					return null;
				}
				return (DrownEndTeleportRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DrownEndTeleportRequest);
			}
		}

		// Token: 0x170061BE RID: 25022
		// (get) Token: 0x0601CDFD RID: 118269 RVA: 0x004325A5 File Offset: 0x004307A5
		// (set) Token: 0x0601CDFE RID: 118270 RVA: 0x004325BE File Offset: 0x004307BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest MonsterDrownRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.MonsterDrownRequest)
				{
					return null;
				}
				return (MonsterDrownRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.MonsterDrownRequest);
			}
		}

		// Token: 0x170061BF RID: 25023
		// (get) Token: 0x0601CDFF RID: 118271 RVA: 0x004325D5 File Offset: 0x004307D5
		// (set) Token: 0x0601CE00 RID: 118272 RVA: 0x004325EE File Offset: 0x004307EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest PassiveSkillRemoveRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
				{
					return null;
				}
				return (PassiveSkillRemoveRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest);
			}
		}

		// Token: 0x170061C0 RID: 25024
		// (get) Token: 0x0601CE01 RID: 118273 RVA: 0x00432605 File Offset: 0x00430805
		// (set) Token: 0x0601CE02 RID: 118274 RVA: 0x0043261E File Offset: 0x0043081E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest RTimeStopInstRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
				{
					return null;
				}
				return (RTimeStopInstRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RTimeStopInstRequest);
			}
		}

		// Token: 0x170061C1 RID: 25025
		// (get) Token: 0x0601CE03 RID: 118275 RVA: 0x00432635 File Offset: 0x00430835
		// (set) Token: 0x0601CE04 RID: 118276 RVA: 0x0043264E File Offset: 0x0043084E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest FsmStateBehaviorRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
				{
					return null;
				}
				return (FsmStateBehaviorRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest);
			}
		}

		// Token: 0x170061C2 RID: 25026
		// (get) Token: 0x0601CE05 RID: 118277 RVA: 0x00432665 File Offset: 0x00430865
		// (set) Token: 0x0601CE06 RID: 118278 RVA: 0x0043267E File Offset: 0x0043087E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest FsmPlayMontageRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
				{
					return null;
				}
				return (FsmPlayMontageRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FsmPlayMontageRequest);
			}
		}

		// Token: 0x170061C3 RID: 25027
		// (get) Token: 0x0601CE07 RID: 118279 RVA: 0x00432695 File Offset: 0x00430895
		// (set) Token: 0x0601CE08 RID: 118280 RVA: 0x004326AE File Offset: 0x004308AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest RTimeStopAnimRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
				{
					return null;
				}
				return (RTimeStopAnimRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RTimeStopAnimRequest);
			}
		}

		// Token: 0x170061C4 RID: 25028
		// (get) Token: 0x0601CE09 RID: 118281 RVA: 0x004326C5 File Offset: 0x004308C5
		// (set) Token: 0x0601CE0A RID: 118282 RVA: 0x004326DE File Offset: 0x004308DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleRequest SwitchRoleRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SwitchRoleRequest)
				{
					return null;
				}
				return (SwitchRoleRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SwitchRoleRequest);
			}
		}

		// Token: 0x170061C5 RID: 25029
		// (get) Token: 0x0601CE0B RID: 118283 RVA: 0x004326F5 File Offset: 0x004308F5
		// (set) Token: 0x0601CE0C RID: 118284 RVA: 0x0043270E File Offset: 0x0043090E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest GameplayTagRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.GameplayTagRequest)
				{
					return null;
				}
				return (GameplayTagRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.GameplayTagRequest);
			}
		}

		// Token: 0x170061C6 RID: 25030
		// (get) Token: 0x0601CE0D RID: 118285 RVA: 0x00432725 File Offset: 0x00430925
		// (set) Token: 0x0601CE0E RID: 118286 RVA: 0x0043273E File Offset: 0x0043093E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest ExecuteQteRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ExecuteQteRequest)
				{
					return null;
				}
				return (ExecuteQteRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ExecuteQteRequest);
			}
		}

		// Token: 0x170061C7 RID: 25031
		// (get) Token: 0x0601CE0F RID: 118287 RVA: 0x00432755 File Offset: 0x00430955
		// (set) Token: 0x0601CE10 RID: 118288 RVA: 0x0043276E File Offset: 0x0043096E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest CombineEntitiesRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
				{
					return null;
				}
				return (CombineEntitiesRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CombineEntitiesRequest);
			}
		}

		// Token: 0x170061C8 RID: 25032
		// (get) Token: 0x0601CE11 RID: 118289 RVA: 0x00432785 File Offset: 0x00430985
		// (set) Token: 0x0601CE12 RID: 118290 RVA: 0x0043279E File Offset: 0x0043099E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest DissolveCombineRelationRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
				{
					return null;
				}
				return (DissolveCombineRelationRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest);
			}
		}

		// Token: 0x170061C9 RID: 25033
		// (get) Token: 0x0601CE13 RID: 118291 RVA: 0x004327B5 File Offset: 0x004309B5
		// (set) Token: 0x0601CE14 RID: 118292 RVA: 0x004327CE File Offset: 0x004309CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest ClientCurrentRoleReportRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
				{
					return null;
				}
				return (ClientCurrentRoleReportRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest);
			}
		}

		// Token: 0x170061CA RID: 25034
		// (get) Token: 0x0601CE15 RID: 118293 RVA: 0x004327E5 File Offset: 0x004309E5
		// (set) Token: 0x0601CE16 RID: 118294 RVA: 0x004327FE File Offset: 0x004309FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest GaSwitchCommonEnemyProCampRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
				{
					return null;
				}
				return (GaSwitchCommonEnemyProCampRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest);
			}
		}

		// Token: 0x170061CB RID: 25035
		// (get) Token: 0x0601CE17 RID: 118295 RVA: 0x00432815 File Offset: 0x00430A15
		// (set) Token: 0x0601CE18 RID: 118296 RVA: 0x0043282E File Offset: 0x00430A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest ChangeSummonEntityStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
				{
					return null;
				}
				return (ChangeSummonEntityStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest);
			}
		}

		// Token: 0x170061CC RID: 25036
		// (get) Token: 0x0601CE19 RID: 118297 RVA: 0x00432845 File Offset: 0x00430A45
		// (set) Token: 0x0601CE1A RID: 118298 RVA: 0x0043285E File Offset: 0x00430A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest CombatMaxCaseMessageRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
				{
					return null;
				}
				return (CombatMaxCaseMessageRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest);
			}
		}

		// Token: 0x170061CD RID: 25037
		// (get) Token: 0x0601CE1B RID: 118299 RVA: 0x00432875 File Offset: 0x00430A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601CE1C RID: 118300 RVA: 0x0043287D File Offset: 0x00430A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatRequestData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601CE1D RID: 118301 RVA: 0x0043288D File Offset: 0x00430A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatRequestData);
		}

		// Token: 0x0601CE1E RID: 118302 RVA: 0x0043289C File Offset: 0x00430A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatRequestData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.RequestId == other.RequestId && object.Equals(this.CreateBulletRequest, other.CreateBulletRequest) && object.Equals(this.DestroyBulletRequest, other.DestroyBulletRequest) && object.Equals(this.DamageExecuteRequest, other.DamageExecuteRequest) && object.Equals(this.ApplyGameplayEffectRequest, other.ApplyGameplayEffectRequest) && object.Equals(this.RemoveGameplayEffectRequest, other.RemoveGameplayEffectRequest) && object.Equals(this.HitRequest, other.HitRequest) && object.Equals(this.HitEndRequest, other.HitEndRequest) && object.Equals(this.SkillRequest, other.SkillRequest) && object.Equals(this.UseSkillRequest, other.UseSkillRequest) && object.Equals(this.EndSkillRequest, other.EndSkillRequest) && object.Equals(this.PartUpdateRequest, other.PartUpdateRequest) && object.Equals(this.MaterialRequest, other.MaterialRequest) && object.Equals(this.GameplayCueRequest, other.GameplayCueRequest) && object.Equals(this.EntityIsVisibleRequest, other.EntityIsVisibleRequest) && object.Equals(this.SwitchCharacterStateRequest, other.SwitchCharacterStateRequest) && object.Equals(this.LogicStateInitRequest, other.LogicStateInitRequest) && object.Equals(this.SwitchLogicStateRequest, other.SwitchLogicStateRequest) && object.Equals(this.AnimationStateChangedRequest, other.AnimationStateChangedRequest) && object.Equals(this.AnimationStateInitRequest, other.AnimationStateInitRequest) && object.Equals(this.ModifyBulletParamsRequest, other.ModifyBulletParamsRequest) && object.Equals(this.DrownRequest, other.DrownRequest) && object.Equals(this.OrderApplyBuffRequest, other.OrderApplyBuffRequest) && object.Equals(this.OrderRemoveBuffRequest, other.OrderRemoveBuffRequest) && object.Equals(this.ActivateBuffRequest, other.ActivateBuffRequest) && object.Equals(this.OrderRemoveBuffByTagsRequest, other.OrderRemoveBuffByTagsRequest) && object.Equals(this.AiInformationRequest, other.AiInformationRequest) && object.Equals(this.ToughCalcExtraRatioChangeRequest, other.ToughCalcExtraRatioChangeRequest) && object.Equals(this.BattleStateChangeRequest, other.BattleStateChangeRequest) && object.Equals(this.AnimationGameplayTagRequest, other.AnimationGameplayTagRequest) && object.Equals(this.BoneVisibleChangeRequest, other.BoneVisibleChangeRequest) && object.Equals(this.AiBlackboardsRequest, other.AiBlackboardsRequest) && object.Equals(this.AiBlackboardCdRequest, other.AiBlackboardCdRequest) && object.Equals(this.AiHateRequest, other.AiHateRequest) && object.Equals(this.MonsterBoomRequest, other.MonsterBoomRequest) && object.Equals(this.CaughtRequest, other.CaughtRequest) && object.Equals(this.EntityStaticHookMoveRequest, other.EntityStaticHookMoveRequest) && object.Equals(this.ChangeStateRequest, other.ChangeStateRequest) && object.Equals(this.ChangeStateConfirmRequest, other.ChangeStateConfirmRequest) && object.Equals(this.FsmConditionPassRequest, other.FsmConditionPassRequest) && object.Equals(this.BuffStackCountRequest, other.BuffStackCountRequest) && object.Equals(this.ANStartRequest, other.ANStartRequest) && object.Equals(this.UseSkillFailRequest, other.UseSkillFailRequest) && object.Equals(this.EnterViewDirectionRequest, other.EnterViewDirectionRequest) && object.Equals(this.ExitViewDirectionRequest, other.ExitViewDirectionRequest) && object.Equals(this.PassiveSkillAddRequest, other.PassiveSkillAddRequest) && object.Equals(this.InterruptSkillInDelayRequest, other.InterruptSkillInDelayRequest) && object.Equals(this.TriggerExitSkillRequest, other.TriggerExitSkillRequest) && object.Equals(this.ActorVisibleRequest, other.ActorVisibleRequest) && object.Equals(this.BuffEffectRequest, other.BuffEffectRequest) && object.Equals(this.FragileChangeRequest, other.FragileChangeRequest) && object.Equals(this.RTimeStopRequest, other.RTimeStopRequest) && object.Equals(this.DrownEndTeleportRequest, other.DrownEndTeleportRequest) && object.Equals(this.MonsterDrownRequest, other.MonsterDrownRequest) && object.Equals(this.PassiveSkillRemoveRequest, other.PassiveSkillRemoveRequest) && object.Equals(this.RTimeStopInstRequest, other.RTimeStopInstRequest) && object.Equals(this.FsmStateBehaviorRequest, other.FsmStateBehaviorRequest) && object.Equals(this.FsmPlayMontageRequest, other.FsmPlayMontageRequest) && object.Equals(this.RTimeStopAnimRequest, other.RTimeStopAnimRequest) && object.Equals(this.SwitchRoleRequest, other.SwitchRoleRequest) && object.Equals(this.GameplayTagRequest, other.GameplayTagRequest) && object.Equals(this.ExecuteQteRequest, other.ExecuteQteRequest) && object.Equals(this.CombineEntitiesRequest, other.CombineEntitiesRequest) && object.Equals(this.DissolveCombineRelationRequest, other.DissolveCombineRelationRequest) && object.Equals(this.ClientCurrentRoleReportRequest, other.ClientCurrentRoleReportRequest) && object.Equals(this.GaSwitchCommonEnemyProCampRequest, other.GaSwitchCommonEnemyProCampRequest) && object.Equals(this.ChangeSummonEntityStateRequest, other.ChangeSummonEntityStateRequest) && object.Equals(this.CombatMaxCaseMessageRequest, other.CombatMaxCaseMessageRequest) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE1F RID: 118303 RVA: 0x00432E7C File Offset: 0x0043107C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.RequestId != 0)
			{
				num ^= this.RequestId.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
			{
				num ^= this.CreateBulletRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
			{
				num ^= this.DestroyBulletRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
			{
				num ^= this.DamageExecuteRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
			{
				num ^= this.ApplyGameplayEffectRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
			{
				num ^= this.RemoveGameplayEffectRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
			{
				num ^= this.HitRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
			{
				num ^= this.HitEndRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
			{
				num ^= this.SkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
			{
				num ^= this.UseSkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
			{
				num ^= this.EndSkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
			{
				num ^= this.PartUpdateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
			{
				num ^= this.MaterialRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
			{
				num ^= this.GameplayCueRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
			{
				num ^= this.EntityIsVisibleRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
			{
				num ^= this.SwitchCharacterStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
			{
				num ^= this.LogicStateInitRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
			{
				num ^= this.SwitchLogicStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
			{
				num ^= this.AnimationStateChangedRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
			{
				num ^= this.AnimationStateInitRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
			{
				num ^= this.ModifyBulletParamsRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
			{
				num ^= this.DrownRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
			{
				num ^= this.OrderApplyBuffRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
			{
				num ^= this.OrderRemoveBuffRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
			{
				num ^= this.ActivateBuffRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
			{
				num ^= this.OrderRemoveBuffByTagsRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
			{
				num ^= this.AiInformationRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
			{
				num ^= this.ToughCalcExtraRatioChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
			{
				num ^= this.BattleStateChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
			{
				num ^= this.AnimationGameplayTagRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
			{
				num ^= this.BoneVisibleChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
			{
				num ^= this.AiBlackboardsRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
			{
				num ^= this.AiBlackboardCdRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
			{
				num ^= this.AiHateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
			{
				num ^= this.MonsterBoomRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
			{
				num ^= this.CaughtRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
			{
				num ^= this.EntityStaticHookMoveRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
			{
				num ^= this.ChangeStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
			{
				num ^= this.ChangeStateConfirmRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
			{
				num ^= this.FsmConditionPassRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
			{
				num ^= this.BuffStackCountRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
			{
				num ^= this.ANStartRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
			{
				num ^= this.UseSkillFailRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
			{
				num ^= this.EnterViewDirectionRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
			{
				num ^= this.ExitViewDirectionRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
			{
				num ^= this.PassiveSkillAddRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
			{
				num ^= this.InterruptSkillInDelayRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
			{
				num ^= this.TriggerExitSkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
			{
				num ^= this.ActorVisibleRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
			{
				num ^= this.BuffEffectRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
			{
				num ^= this.FragileChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
			{
				num ^= this.RTimeStopRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
			{
				num ^= this.DrownEndTeleportRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
			{
				num ^= this.MonsterDrownRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
			{
				num ^= this.PassiveSkillRemoveRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
			{
				num ^= this.RTimeStopInstRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
			{
				num ^= this.FsmStateBehaviorRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
			{
				num ^= this.FsmPlayMontageRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
			{
				num ^= this.RTimeStopAnimRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
			{
				num ^= this.SwitchRoleRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
			{
				num ^= this.GameplayTagRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
			{
				num ^= this.ExecuteQteRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
			{
				num ^= this.CombineEntitiesRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
			{
				num ^= this.DissolveCombineRelationRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
			{
				num ^= this.ClientCurrentRoleReportRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
			{
				num ^= this.GaSwitchCommonEnemyProCampRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
			{
				num ^= this.ChangeSummonEntityStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
			{
				num ^= this.CombatMaxCaseMessageRequest.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CE20 RID: 118304 RVA: 0x0043351C File Offset: 0x0043171C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE21 RID: 118305 RVA: 0x00433529 File Offset: 0x00431729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE22 RID: 118306 RVA: 0x00433534 File Offset: 0x00431734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.RequestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RequestId);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CreateBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.DestroyBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DamageExecuteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ApplyGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RemoveGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.HitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HitEndRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UseSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EndSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PartUpdateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MaterialRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GameplayCueRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.EntityIsVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.SwitchCharacterStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.LogicStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.SwitchLogicStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.AnimationStateChangedRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.AnimationStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.ModifyBulletParamsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.DrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.OrderApplyBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.OrderRemoveBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.ActivateBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.OrderRemoveBuffByTagsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.AiInformationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.ToughCalcExtraRatioChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.BattleStateChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.AnimationGameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.BoneVisibleChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.AiBlackboardsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.AiBlackboardCdRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.AiHateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.MonsterBoomRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.CaughtRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.EntityStaticHookMoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.ChangeStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.ChangeStateConfirmRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.FsmConditionPassRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.BuffStackCountRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.ANStartRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.UseSkillFailRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.EnterViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.ExitViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.PassiveSkillAddRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.InterruptSkillInDelayRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.TriggerExitSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.ActorVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.BuffEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.FragileChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.RTimeStopRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.DrownEndTeleportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
			{
				output.WriteRawTag(226, 3);
				output.WriteMessage(this.MonsterDrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.PassiveSkillRemoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.RTimeStopInstRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.FsmStateBehaviorRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.FsmPlayMontageRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.RTimeStopAnimRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.SwitchRoleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
			{
				output.WriteRawTag(154, 4);
				output.WriteMessage(this.GameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
			{
				output.WriteRawTag(162, 4);
				output.WriteMessage(this.ExecuteQteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.CombineEntitiesRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
			{
				output.WriteRawTag(178, 4);
				output.WriteMessage(this.DissolveCombineRelationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.ClientCurrentRoleReportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.GaSwitchCommonEnemyProCampRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
			{
				output.WriteRawTag(202, 4);
				output.WriteMessage(this.ChangeSummonEntityStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
			{
				output.WriteRawTag(154, 6);
				output.WriteMessage(this.CombatMaxCaseMessageRequest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE23 RID: 118307 RVA: 0x00433E3C File Offset: 0x0043203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.RequestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestId);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CreateBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DestroyBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageExecuteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApplyGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitEndRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartUpdateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MaterialRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameplayCueRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityIsVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchCharacterStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LogicStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchLogicStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateChangedRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParamsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderApplyBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActivateBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffByTagsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiInformationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ToughCalcExtraRatioChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BattleStateChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationGameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardCdRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiHateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterBoomRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CaughtRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityStaticHookMoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateConfirmRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmConditionPassRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffStackCountRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ANStartRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.UseSkillFailRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EnterViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExitViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillAddRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InterruptSkillInDelayRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TriggerExitSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActorVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FragileChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownEndTeleportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterDrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillRemoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopInstRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmStateBehaviorRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmPlayMontageRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopAnimRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchRoleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExecuteQteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombineEntitiesRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DissolveCombineRelationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ClientCurrentRoleReportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GaSwitchCommonEnemyProCampRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeSummonEntityStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombatMaxCaseMessageRequest);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CE24 RID: 118308 RVA: 0x0043455C File Offset: 0x0043275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatRequestData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.RequestId != 0)
			{
				this.RequestId = other.RequestId;
			}
			switch (other.MessageCase)
			{
			case CombatRequestData.MessageOneofCase.CreateBulletRequest:
				if (this.CreateBulletRequest == null)
				{
					this.CreateBulletRequest = new CreateBulletRequest();
				}
				this.CreateBulletRequest.MergeFrom(other.CreateBulletRequest);
				break;
			case CombatRequestData.MessageOneofCase.DestroyBulletRequest:
				if (this.DestroyBulletRequest == null)
				{
					this.DestroyBulletRequest = new DestroyBulletRequest();
				}
				this.DestroyBulletRequest.MergeFrom(other.DestroyBulletRequest);
				break;
			case CombatRequestData.MessageOneofCase.DamageExecuteRequest:
				if (this.DamageExecuteRequest == null)
				{
					this.DamageExecuteRequest = new DamageExecuteRequest();
				}
				this.DamageExecuteRequest.MergeFrom(other.DamageExecuteRequest);
				break;
			case CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest:
				if (this.ApplyGameplayEffectRequest == null)
				{
					this.ApplyGameplayEffectRequest = new ApplyGameplayEffectRequest();
				}
				this.ApplyGameplayEffectRequest.MergeFrom(other.ApplyGameplayEffectRequest);
				break;
			case CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest:
				if (this.RemoveGameplayEffectRequest == null)
				{
					this.RemoveGameplayEffectRequest = new RemoveGameplayEffectRequest();
				}
				this.RemoveGameplayEffectRequest.MergeFrom(other.RemoveGameplayEffectRequest);
				break;
			case CombatRequestData.MessageOneofCase.HitRequest:
				if (this.HitRequest == null)
				{
					this.HitRequest = new HitRequest();
				}
				this.HitRequest.MergeFrom(other.HitRequest);
				break;
			case CombatRequestData.MessageOneofCase.HitEndRequest:
				if (this.HitEndRequest == null)
				{
					this.HitEndRequest = new HitEndRequest();
				}
				this.HitEndRequest.MergeFrom(other.HitEndRequest);
				break;
			case CombatRequestData.MessageOneofCase.SkillRequest:
				if (this.SkillRequest == null)
				{
					this.SkillRequest = new SkillRequest();
				}
				this.SkillRequest.MergeFrom(other.SkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.UseSkillRequest:
				if (this.UseSkillRequest == null)
				{
					this.UseSkillRequest = new UseSkillRequest();
				}
				this.UseSkillRequest.MergeFrom(other.UseSkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.EndSkillRequest:
				if (this.EndSkillRequest == null)
				{
					this.EndSkillRequest = new EndSkillRequest();
				}
				this.EndSkillRequest.MergeFrom(other.EndSkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.PartUpdateRequest:
				if (this.PartUpdateRequest == null)
				{
					this.PartUpdateRequest = new PartUpdateRequest();
				}
				this.PartUpdateRequest.MergeFrom(other.PartUpdateRequest);
				break;
			case CombatRequestData.MessageOneofCase.MaterialRequest:
				if (this.MaterialRequest == null)
				{
					this.MaterialRequest = new MaterialRequest();
				}
				this.MaterialRequest.MergeFrom(other.MaterialRequest);
				break;
			case CombatRequestData.MessageOneofCase.GameplayCueRequest:
				if (this.GameplayCueRequest == null)
				{
					this.GameplayCueRequest = new GameplayCueRequest();
				}
				this.GameplayCueRequest.MergeFrom(other.GameplayCueRequest);
				break;
			case CombatRequestData.MessageOneofCase.EntityIsVisibleRequest:
				if (this.EntityIsVisibleRequest == null)
				{
					this.EntityIsVisibleRequest = new EntityIsVisibleRequest();
				}
				this.EntityIsVisibleRequest.MergeFrom(other.EntityIsVisibleRequest);
				break;
			case CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest:
				if (this.SwitchCharacterStateRequest == null)
				{
					this.SwitchCharacterStateRequest = new SwitchCharacterStateRequest();
				}
				this.SwitchCharacterStateRequest.MergeFrom(other.SwitchCharacterStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.LogicStateInitRequest:
				if (this.LogicStateInitRequest == null)
				{
					this.LogicStateInitRequest = new LogicStateInitRequest();
				}
				this.LogicStateInitRequest.MergeFrom(other.LogicStateInitRequest);
				break;
			case CombatRequestData.MessageOneofCase.SwitchLogicStateRequest:
				if (this.SwitchLogicStateRequest == null)
				{
					this.SwitchLogicStateRequest = new SwitchLogicStateRequest();
				}
				this.SwitchLogicStateRequest.MergeFrom(other.SwitchLogicStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateChangedRequest:
				if (this.AnimationStateChangedRequest == null)
				{
					this.AnimationStateChangedRequest = new AnimationStateChangedRequest();
				}
				this.AnimationStateChangedRequest.MergeFrom(other.AnimationStateChangedRequest);
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateInitRequest:
				if (this.AnimationStateInitRequest == null)
				{
					this.AnimationStateInitRequest = new AnimationStateInitRequest();
				}
				this.AnimationStateInitRequest.MergeFrom(other.AnimationStateInitRequest);
				break;
			case CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest:
				if (this.ModifyBulletParamsRequest == null)
				{
					this.ModifyBulletParamsRequest = new ModifyBulletParamsRequest();
				}
				this.ModifyBulletParamsRequest.MergeFrom(other.ModifyBulletParamsRequest);
				break;
			case CombatRequestData.MessageOneofCase.DrownRequest:
				if (this.DrownRequest == null)
				{
					this.DrownRequest = new DrownRequest();
				}
				this.DrownRequest.MergeFrom(other.DrownRequest);
				break;
			case CombatRequestData.MessageOneofCase.OrderApplyBuffRequest:
				if (this.OrderApplyBuffRequest == null)
				{
					this.OrderApplyBuffRequest = new OrderApplyBuffRequest();
				}
				this.OrderApplyBuffRequest.MergeFrom(other.OrderApplyBuffRequest);
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest:
				if (this.OrderRemoveBuffRequest == null)
				{
					this.OrderRemoveBuffRequest = new OrderRemoveBuffRequest();
				}
				this.OrderRemoveBuffRequest.MergeFrom(other.OrderRemoveBuffRequest);
				break;
			case CombatRequestData.MessageOneofCase.ActivateBuffRequest:
				if (this.ActivateBuffRequest == null)
				{
					this.ActivateBuffRequest = new ActivateBuffRequest();
				}
				this.ActivateBuffRequest.MergeFrom(other.ActivateBuffRequest);
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest:
				if (this.OrderRemoveBuffByTagsRequest == null)
				{
					this.OrderRemoveBuffByTagsRequest = new OrderRemoveBuffByTagsRequest();
				}
				this.OrderRemoveBuffByTagsRequest.MergeFrom(other.OrderRemoveBuffByTagsRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiInformationRequest:
				if (this.AiInformationRequest == null)
				{
					this.AiInformationRequest = new AiInformationRequest();
				}
				this.AiInformationRequest.MergeFrom(other.AiInformationRequest);
				break;
			case CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest:
				if (this.ToughCalcExtraRatioChangeRequest == null)
				{
					this.ToughCalcExtraRatioChangeRequest = new ToughCalcExtraRatioChangeRequest();
				}
				this.ToughCalcExtraRatioChangeRequest.MergeFrom(other.ToughCalcExtraRatioChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.BattleStateChangeRequest:
				if (this.BattleStateChangeRequest == null)
				{
					this.BattleStateChangeRequest = new BattleStateChangeRequest();
				}
				this.BattleStateChangeRequest.MergeFrom(other.BattleStateChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest:
				if (this.AnimationGameplayTagRequest == null)
				{
					this.AnimationGameplayTagRequest = new AnimationGameplayTagRequest();
				}
				this.AnimationGameplayTagRequest.MergeFrom(other.AnimationGameplayTagRequest);
				break;
			case CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest:
				if (this.BoneVisibleChangeRequest == null)
				{
					this.BoneVisibleChangeRequest = new BoneVisibleChangeRequest();
				}
				this.BoneVisibleChangeRequest.MergeFrom(other.BoneVisibleChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardsRequest:
				if (this.AiBlackboardsRequest == null)
				{
					this.AiBlackboardsRequest = new AiBlackboardsRequest();
				}
				this.AiBlackboardsRequest.MergeFrom(other.AiBlackboardsRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardCdRequest:
				if (this.AiBlackboardCdRequest == null)
				{
					this.AiBlackboardCdRequest = new AiBlackboardCdRequest();
				}
				this.AiBlackboardCdRequest.MergeFrom(other.AiBlackboardCdRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiHateRequest:
				if (this.AiHateRequest == null)
				{
					this.AiHateRequest = new AiHateRequest();
				}
				this.AiHateRequest.MergeFrom(other.AiHateRequest);
				break;
			case CombatRequestData.MessageOneofCase.MonsterBoomRequest:
				if (this.MonsterBoomRequest == null)
				{
					this.MonsterBoomRequest = new MonsterBoomRequest();
				}
				this.MonsterBoomRequest.MergeFrom(other.MonsterBoomRequest);
				break;
			case CombatRequestData.MessageOneofCase.CaughtRequest:
				if (this.CaughtRequest == null)
				{
					this.CaughtRequest = new CaughtRequest();
				}
				this.CaughtRequest.MergeFrom(other.CaughtRequest);
				break;
			case CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest:
				if (this.EntityStaticHookMoveRequest == null)
				{
					this.EntityStaticHookMoveRequest = new EntityStaticHookMoveRequest();
				}
				this.EntityStaticHookMoveRequest.MergeFrom(other.EntityStaticHookMoveRequest);
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateRequest:
				if (this.ChangeStateRequest == null)
				{
					this.ChangeStateRequest = new ChangeStateRequest();
				}
				this.ChangeStateRequest.MergeFrom(other.ChangeStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest:
				if (this.ChangeStateConfirmRequest == null)
				{
					this.ChangeStateConfirmRequest = new ChangeStateConfirmRequest();
				}
				this.ChangeStateConfirmRequest.MergeFrom(other.ChangeStateConfirmRequest);
				break;
			case CombatRequestData.MessageOneofCase.FsmConditionPassRequest:
				if (this.FsmConditionPassRequest == null)
				{
					this.FsmConditionPassRequest = new FsmConditionPassRequest();
				}
				this.FsmConditionPassRequest.MergeFrom(other.FsmConditionPassRequest);
				break;
			case CombatRequestData.MessageOneofCase.BuffStackCountRequest:
				if (this.BuffStackCountRequest == null)
				{
					this.BuffStackCountRequest = new BuffStackCountRequest();
				}
				this.BuffStackCountRequest.MergeFrom(other.BuffStackCountRequest);
				break;
			case CombatRequestData.MessageOneofCase.ANStartRequest:
				if (this.ANStartRequest == null)
				{
					this.ANStartRequest = new ANStartRequest();
				}
				this.ANStartRequest.MergeFrom(other.ANStartRequest);
				break;
			case CombatRequestData.MessageOneofCase.UseSkillFailRequest:
				if (this.UseSkillFailRequest == null)
				{
					this.UseSkillFailRequest = new UseSkillFailRequest();
				}
				this.UseSkillFailRequest.MergeFrom(other.UseSkillFailRequest);
				break;
			case CombatRequestData.MessageOneofCase.EnterViewDirectionRequest:
				if (this.EnterViewDirectionRequest == null)
				{
					this.EnterViewDirectionRequest = new EnterViewDirectionRequest();
				}
				this.EnterViewDirectionRequest.MergeFrom(other.EnterViewDirectionRequest);
				break;
			case CombatRequestData.MessageOneofCase.ExitViewDirectionRequest:
				if (this.ExitViewDirectionRequest == null)
				{
					this.ExitViewDirectionRequest = new ExitViewDirectionRequest();
				}
				this.ExitViewDirectionRequest.MergeFrom(other.ExitViewDirectionRequest);
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillAddRequest:
				if (this.PassiveSkillAddRequest == null)
				{
					this.PassiveSkillAddRequest = new PassiveSkillAddRequest();
				}
				this.PassiveSkillAddRequest.MergeFrom(other.PassiveSkillAddRequest);
				break;
			case CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest:
				if (this.InterruptSkillInDelayRequest == null)
				{
					this.InterruptSkillInDelayRequest = new InterruptSkillInDelayRequest();
				}
				this.InterruptSkillInDelayRequest.MergeFrom(other.InterruptSkillInDelayRequest);
				break;
			case CombatRequestData.MessageOneofCase.TriggerExitSkillRequest:
				if (this.TriggerExitSkillRequest == null)
				{
					this.TriggerExitSkillRequest = new TriggerExitSkillRequest();
				}
				this.TriggerExitSkillRequest.MergeFrom(other.TriggerExitSkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.ActorVisibleRequest:
				if (this.ActorVisibleRequest == null)
				{
					this.ActorVisibleRequest = new ActorVisibleRequest();
				}
				this.ActorVisibleRequest.MergeFrom(other.ActorVisibleRequest);
				break;
			case CombatRequestData.MessageOneofCase.BuffEffectRequest:
				if (this.BuffEffectRequest == null)
				{
					this.BuffEffectRequest = new BuffEffectRequest();
				}
				this.BuffEffectRequest.MergeFrom(other.BuffEffectRequest);
				break;
			case CombatRequestData.MessageOneofCase.FragileChangeRequest:
				if (this.FragileChangeRequest == null)
				{
					this.FragileChangeRequest = new FragileChangeRequest();
				}
				this.FragileChangeRequest.MergeFrom(other.FragileChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopRequest:
				if (this.RTimeStopRequest == null)
				{
					this.RTimeStopRequest = new RTimeStopRequest();
				}
				this.RTimeStopRequest.MergeFrom(other.RTimeStopRequest);
				break;
			case CombatRequestData.MessageOneofCase.DrownEndTeleportRequest:
				if (this.DrownEndTeleportRequest == null)
				{
					this.DrownEndTeleportRequest = new DrownEndTeleportRequest();
				}
				this.DrownEndTeleportRequest.MergeFrom(other.DrownEndTeleportRequest);
				break;
			case CombatRequestData.MessageOneofCase.MonsterDrownRequest:
				if (this.MonsterDrownRequest == null)
				{
					this.MonsterDrownRequest = new MonsterDrownRequest();
				}
				this.MonsterDrownRequest.MergeFrom(other.MonsterDrownRequest);
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest:
				if (this.PassiveSkillRemoveRequest == null)
				{
					this.PassiveSkillRemoveRequest = new PassiveSkillRemoveRequest();
				}
				this.PassiveSkillRemoveRequest.MergeFrom(other.PassiveSkillRemoveRequest);
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopInstRequest:
				if (this.RTimeStopInstRequest == null)
				{
					this.RTimeStopInstRequest = new RTimeStopInstRequest();
				}
				this.RTimeStopInstRequest.MergeFrom(other.RTimeStopInstRequest);
				break;
			case CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest:
				if (this.FsmStateBehaviorRequest == null)
				{
					this.FsmStateBehaviorRequest = new FsmStateBehaviorRequest();
				}
				this.FsmStateBehaviorRequest.MergeFrom(other.FsmStateBehaviorRequest);
				break;
			case CombatRequestData.MessageOneofCase.FsmPlayMontageRequest:
				if (this.FsmPlayMontageRequest == null)
				{
					this.FsmPlayMontageRequest = new FsmPlayMontageRequest();
				}
				this.FsmPlayMontageRequest.MergeFrom(other.FsmPlayMontageRequest);
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopAnimRequest:
				if (this.RTimeStopAnimRequest == null)
				{
					this.RTimeStopAnimRequest = new RTimeStopAnimRequest();
				}
				this.RTimeStopAnimRequest.MergeFrom(other.RTimeStopAnimRequest);
				break;
			case CombatRequestData.MessageOneofCase.SwitchRoleRequest:
				if (this.SwitchRoleRequest == null)
				{
					this.SwitchRoleRequest = new SwitchRoleRequest();
				}
				this.SwitchRoleRequest.MergeFrom(other.SwitchRoleRequest);
				break;
			case CombatRequestData.MessageOneofCase.GameplayTagRequest:
				if (this.GameplayTagRequest == null)
				{
					this.GameplayTagRequest = new GameplayTagRequest();
				}
				this.GameplayTagRequest.MergeFrom(other.GameplayTagRequest);
				break;
			case CombatRequestData.MessageOneofCase.ExecuteQteRequest:
				if (this.ExecuteQteRequest == null)
				{
					this.ExecuteQteRequest = new ExecuteQteRequest();
				}
				this.ExecuteQteRequest.MergeFrom(other.ExecuteQteRequest);
				break;
			case CombatRequestData.MessageOneofCase.CombineEntitiesRequest:
				if (this.CombineEntitiesRequest == null)
				{
					this.CombineEntitiesRequest = new CombineEntitiesRequest();
				}
				this.CombineEntitiesRequest.MergeFrom(other.CombineEntitiesRequest);
				break;
			case CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest:
				if (this.DissolveCombineRelationRequest == null)
				{
					this.DissolveCombineRelationRequest = new DissolveCombineRelationRequest();
				}
				this.DissolveCombineRelationRequest.MergeFrom(other.DissolveCombineRelationRequest);
				break;
			case CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest:
				if (this.ClientCurrentRoleReportRequest == null)
				{
					this.ClientCurrentRoleReportRequest = new ClientCurrentRoleReportRequest();
				}
				this.ClientCurrentRoleReportRequest.MergeFrom(other.ClientCurrentRoleReportRequest);
				break;
			case CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest:
				if (this.GaSwitchCommonEnemyProCampRequest == null)
				{
					this.GaSwitchCommonEnemyProCampRequest = new GaSwitchCommonEnemyProCampRequest();
				}
				this.GaSwitchCommonEnemyProCampRequest.MergeFrom(other.GaSwitchCommonEnemyProCampRequest);
				break;
			case CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest:
				if (this.ChangeSummonEntityStateRequest == null)
				{
					this.ChangeSummonEntityStateRequest = new ChangeSummonEntityStateRequest();
				}
				this.ChangeSummonEntityStateRequest.MergeFrom(other.ChangeSummonEntityStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest:
				if (this.CombatMaxCaseMessageRequest == null)
				{
					this.CombatMaxCaseMessageRequest = new CombatMaxCaseMessageRequest();
				}
				this.CombatMaxCaseMessageRequest.MergeFrom(other.CombatMaxCaseMessageRequest);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CE25 RID: 118309 RVA: 0x00435209 File Offset: 0x00433409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE26 RID: 118310 RVA: 0x00435214 File Offset: 0x00433414
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
				if (num <= 274U)
				{
					if (num <= 138U)
					{
						if (num <= 66U)
						{
							if (num <= 34U)
							{
								if (num <= 16U)
								{
									if (num == 10U)
									{
										if (this.combatCommon_ == null)
										{
											this.CombatCommon = new CombatCommon();
										}
										input.ReadMessage(this.CombatCommon);
										continue;
									}
									if (num == 16U)
									{
										this.RequestId = input.ReadInt32();
										continue;
									}
								}
								else
								{
									if (num == 26U)
									{
										CreateBulletRequest createBulletRequest = new CreateBulletRequest();
										if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
										{
											createBulletRequest.MergeFrom(this.CreateBulletRequest);
										}
										input.ReadMessage(createBulletRequest);
										this.CreateBulletRequest = createBulletRequest;
										continue;
									}
									if (num == 34U)
									{
										DestroyBulletRequest destroyBulletRequest = new DestroyBulletRequest();
										if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
										{
											destroyBulletRequest.MergeFrom(this.DestroyBulletRequest);
										}
										input.ReadMessage(destroyBulletRequest);
										this.DestroyBulletRequest = destroyBulletRequest;
										continue;
									}
								}
							}
							else if (num <= 50U)
							{
								if (num == 42U)
								{
									DamageExecuteRequest damageExecuteRequest = new DamageExecuteRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
									{
										damageExecuteRequest.MergeFrom(this.DamageExecuteRequest);
									}
									input.ReadMessage(damageExecuteRequest);
									this.DamageExecuteRequest = damageExecuteRequest;
									continue;
								}
								if (num == 50U)
								{
									ApplyGameplayEffectRequest applyGameplayEffectRequest = new ApplyGameplayEffectRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
									{
										applyGameplayEffectRequest.MergeFrom(this.ApplyGameplayEffectRequest);
									}
									input.ReadMessage(applyGameplayEffectRequest);
									this.ApplyGameplayEffectRequest = applyGameplayEffectRequest;
									continue;
								}
							}
							else
							{
								if (num == 58U)
								{
									RemoveGameplayEffectRequest removeGameplayEffectRequest = new RemoveGameplayEffectRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
									{
										removeGameplayEffectRequest.MergeFrom(this.RemoveGameplayEffectRequest);
									}
									input.ReadMessage(removeGameplayEffectRequest);
									this.RemoveGameplayEffectRequest = removeGameplayEffectRequest;
									continue;
								}
								if (num == 66U)
								{
									HitRequest hitRequest = new HitRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
									{
										hitRequest.MergeFrom(this.HitRequest);
									}
									input.ReadMessage(hitRequest);
									this.HitRequest = hitRequest;
									continue;
								}
							}
						}
						else if (num <= 98U)
						{
							if (num <= 82U)
							{
								if (num == 74U)
								{
									HitEndRequest hitEndRequest = new HitEndRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
									{
										hitEndRequest.MergeFrom(this.HitEndRequest);
									}
									input.ReadMessage(hitEndRequest);
									this.HitEndRequest = hitEndRequest;
									continue;
								}
								if (num == 82U)
								{
									SkillRequest skillRequest = new SkillRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
									{
										skillRequest.MergeFrom(this.SkillRequest);
									}
									input.ReadMessage(skillRequest);
									this.SkillRequest = skillRequest;
									continue;
								}
							}
							else
							{
								if (num == 90U)
								{
									UseSkillRequest useSkillRequest = new UseSkillRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
									{
										useSkillRequest.MergeFrom(this.UseSkillRequest);
									}
									input.ReadMessage(useSkillRequest);
									this.UseSkillRequest = useSkillRequest;
									continue;
								}
								if (num == 98U)
								{
									EndSkillRequest endSkillRequest = new EndSkillRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
									{
										endSkillRequest.MergeFrom(this.EndSkillRequest);
									}
									input.ReadMessage(endSkillRequest);
									this.EndSkillRequest = endSkillRequest;
									continue;
								}
							}
						}
						else if (num <= 114U)
						{
							if (num == 106U)
							{
								PartUpdateRequest partUpdateRequest = new PartUpdateRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
								{
									partUpdateRequest.MergeFrom(this.PartUpdateRequest);
								}
								input.ReadMessage(partUpdateRequest);
								this.PartUpdateRequest = partUpdateRequest;
								continue;
							}
							if (num == 114U)
							{
								MaterialRequest materialRequest = new MaterialRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
								{
									materialRequest.MergeFrom(this.MaterialRequest);
								}
								input.ReadMessage(materialRequest);
								this.MaterialRequest = materialRequest;
								continue;
							}
						}
						else
						{
							if (num == 122U)
							{
								GameplayCueRequest gameplayCueRequest = new GameplayCueRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
								{
									gameplayCueRequest.MergeFrom(this.GameplayCueRequest);
								}
								input.ReadMessage(gameplayCueRequest);
								this.GameplayCueRequest = gameplayCueRequest;
								continue;
							}
							if (num == 130U)
							{
								EntityIsVisibleRequest entityIsVisibleRequest = new EntityIsVisibleRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
								{
									entityIsVisibleRequest.MergeFrom(this.EntityIsVisibleRequest);
								}
								input.ReadMessage(entityIsVisibleRequest);
								this.EntityIsVisibleRequest = entityIsVisibleRequest;
								continue;
							}
							if (num == 138U)
							{
								SwitchCharacterStateRequest switchCharacterStateRequest = new SwitchCharacterStateRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
								{
									switchCharacterStateRequest.MergeFrom(this.SwitchCharacterStateRequest);
								}
								input.ReadMessage(switchCharacterStateRequest);
								this.SwitchCharacterStateRequest = switchCharacterStateRequest;
								continue;
							}
						}
					}
					else if (num <= 202U)
					{
						if (num <= 170U)
						{
							if (num <= 154U)
							{
								if (num == 146U)
								{
									LogicStateInitRequest logicStateInitRequest = new LogicStateInitRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
									{
										logicStateInitRequest.MergeFrom(this.LogicStateInitRequest);
									}
									input.ReadMessage(logicStateInitRequest);
									this.LogicStateInitRequest = logicStateInitRequest;
									continue;
								}
								if (num == 154U)
								{
									SwitchLogicStateRequest switchLogicStateRequest = new SwitchLogicStateRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
									{
										switchLogicStateRequest.MergeFrom(this.SwitchLogicStateRequest);
									}
									input.ReadMessage(switchLogicStateRequest);
									this.SwitchLogicStateRequest = switchLogicStateRequest;
									continue;
								}
							}
							else
							{
								if (num == 162U)
								{
									AnimationStateChangedRequest animationStateChangedRequest = new AnimationStateChangedRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
									{
										animationStateChangedRequest.MergeFrom(this.AnimationStateChangedRequest);
									}
									input.ReadMessage(animationStateChangedRequest);
									this.AnimationStateChangedRequest = animationStateChangedRequest;
									continue;
								}
								if (num == 170U)
								{
									AnimationStateInitRequest animationStateInitRequest = new AnimationStateInitRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
									{
										animationStateInitRequest.MergeFrom(this.AnimationStateInitRequest);
									}
									input.ReadMessage(animationStateInitRequest);
									this.AnimationStateInitRequest = animationStateInitRequest;
									continue;
								}
							}
						}
						else if (num <= 186U)
						{
							if (num == 178U)
							{
								ModifyBulletParamsRequest modifyBulletParamsRequest = new ModifyBulletParamsRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
								{
									modifyBulletParamsRequest.MergeFrom(this.ModifyBulletParamsRequest);
								}
								input.ReadMessage(modifyBulletParamsRequest);
								this.ModifyBulletParamsRequest = modifyBulletParamsRequest;
								continue;
							}
							if (num == 186U)
							{
								DrownRequest drownRequest = new DrownRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
								{
									drownRequest.MergeFrom(this.DrownRequest);
								}
								input.ReadMessage(drownRequest);
								this.DrownRequest = drownRequest;
								continue;
							}
						}
						else
						{
							if (num == 194U)
							{
								OrderApplyBuffRequest orderApplyBuffRequest = new OrderApplyBuffRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
								{
									orderApplyBuffRequest.MergeFrom(this.OrderApplyBuffRequest);
								}
								input.ReadMessage(orderApplyBuffRequest);
								this.OrderApplyBuffRequest = orderApplyBuffRequest;
								continue;
							}
							if (num == 202U)
							{
								OrderRemoveBuffRequest orderRemoveBuffRequest = new OrderRemoveBuffRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
								{
									orderRemoveBuffRequest.MergeFrom(this.OrderRemoveBuffRequest);
								}
								input.ReadMessage(orderRemoveBuffRequest);
								this.OrderRemoveBuffRequest = orderRemoveBuffRequest;
								continue;
							}
						}
					}
					else if (num <= 234U)
					{
						if (num <= 218U)
						{
							if (num == 210U)
							{
								ActivateBuffRequest activateBuffRequest = new ActivateBuffRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
								{
									activateBuffRequest.MergeFrom(this.ActivateBuffRequest);
								}
								input.ReadMessage(activateBuffRequest);
								this.ActivateBuffRequest = activateBuffRequest;
								continue;
							}
							if (num == 218U)
							{
								OrderRemoveBuffByTagsRequest orderRemoveBuffByTagsRequest = new OrderRemoveBuffByTagsRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
								{
									orderRemoveBuffByTagsRequest.MergeFrom(this.OrderRemoveBuffByTagsRequest);
								}
								input.ReadMessage(orderRemoveBuffByTagsRequest);
								this.OrderRemoveBuffByTagsRequest = orderRemoveBuffByTagsRequest;
								continue;
							}
						}
						else
						{
							if (num == 226U)
							{
								AiInformationRequest aiInformationRequest = new AiInformationRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
								{
									aiInformationRequest.MergeFrom(this.AiInformationRequest);
								}
								input.ReadMessage(aiInformationRequest);
								this.AiInformationRequest = aiInformationRequest;
								continue;
							}
							if (num == 234U)
							{
								ToughCalcExtraRatioChangeRequest toughCalcExtraRatioChangeRequest = new ToughCalcExtraRatioChangeRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
								{
									toughCalcExtraRatioChangeRequest.MergeFrom(this.ToughCalcExtraRatioChangeRequest);
								}
								input.ReadMessage(toughCalcExtraRatioChangeRequest);
								this.ToughCalcExtraRatioChangeRequest = toughCalcExtraRatioChangeRequest;
								continue;
							}
						}
					}
					else if (num <= 250U)
					{
						if (num == 242U)
						{
							BattleStateChangeRequest battleStateChangeRequest = new BattleStateChangeRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
							{
								battleStateChangeRequest.MergeFrom(this.BattleStateChangeRequest);
							}
							input.ReadMessage(battleStateChangeRequest);
							this.BattleStateChangeRequest = battleStateChangeRequest;
							continue;
						}
						if (num == 250U)
						{
							AnimationGameplayTagRequest animationGameplayTagRequest = new AnimationGameplayTagRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
							{
								animationGameplayTagRequest.MergeFrom(this.AnimationGameplayTagRequest);
							}
							input.ReadMessage(animationGameplayTagRequest);
							this.AnimationGameplayTagRequest = animationGameplayTagRequest;
							continue;
						}
					}
					else
					{
						if (num == 258U)
						{
							BoneVisibleChangeRequest boneVisibleChangeRequest = new BoneVisibleChangeRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
							{
								boneVisibleChangeRequest.MergeFrom(this.BoneVisibleChangeRequest);
							}
							input.ReadMessage(boneVisibleChangeRequest);
							this.BoneVisibleChangeRequest = boneVisibleChangeRequest;
							continue;
						}
						if (num == 266U)
						{
							AiBlackboardsRequest aiBlackboardsRequest = new AiBlackboardsRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
							{
								aiBlackboardsRequest.MergeFrom(this.AiBlackboardsRequest);
							}
							input.ReadMessage(aiBlackboardsRequest);
							this.AiBlackboardsRequest = aiBlackboardsRequest;
							continue;
						}
						if (num == 274U)
						{
							AiBlackboardCdRequest aiBlackboardCdRequest = new AiBlackboardCdRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
							{
								aiBlackboardCdRequest.MergeFrom(this.AiBlackboardCdRequest);
							}
							input.ReadMessage(aiBlackboardCdRequest);
							this.AiBlackboardCdRequest = aiBlackboardCdRequest;
							continue;
						}
					}
				}
				else if (num <= 450U)
				{
					if (num <= 338U)
					{
						if (num <= 306U)
						{
							if (num <= 290U)
							{
								if (num == 282U)
								{
									AiHateRequest aiHateRequest = new AiHateRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
									{
										aiHateRequest.MergeFrom(this.AiHateRequest);
									}
									input.ReadMessage(aiHateRequest);
									this.AiHateRequest = aiHateRequest;
									continue;
								}
								if (num == 290U)
								{
									MonsterBoomRequest monsterBoomRequest = new MonsterBoomRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
									{
										monsterBoomRequest.MergeFrom(this.MonsterBoomRequest);
									}
									input.ReadMessage(monsterBoomRequest);
									this.MonsterBoomRequest = monsterBoomRequest;
									continue;
								}
							}
							else
							{
								if (num == 298U)
								{
									CaughtRequest caughtRequest = new CaughtRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
									{
										caughtRequest.MergeFrom(this.CaughtRequest);
									}
									input.ReadMessage(caughtRequest);
									this.CaughtRequest = caughtRequest;
									continue;
								}
								if (num == 306U)
								{
									EntityStaticHookMoveRequest entityStaticHookMoveRequest = new EntityStaticHookMoveRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
									{
										entityStaticHookMoveRequest.MergeFrom(this.EntityStaticHookMoveRequest);
									}
									input.ReadMessage(entityStaticHookMoveRequest);
									this.EntityStaticHookMoveRequest = entityStaticHookMoveRequest;
									continue;
								}
							}
						}
						else if (num <= 322U)
						{
							if (num == 314U)
							{
								ChangeStateRequest changeStateRequest = new ChangeStateRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
								{
									changeStateRequest.MergeFrom(this.ChangeStateRequest);
								}
								input.ReadMessage(changeStateRequest);
								this.ChangeStateRequest = changeStateRequest;
								continue;
							}
							if (num == 322U)
							{
								ChangeStateConfirmRequest changeStateConfirmRequest = new ChangeStateConfirmRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
								{
									changeStateConfirmRequest.MergeFrom(this.ChangeStateConfirmRequest);
								}
								input.ReadMessage(changeStateConfirmRequest);
								this.ChangeStateConfirmRequest = changeStateConfirmRequest;
								continue;
							}
						}
						else
						{
							if (num == 330U)
							{
								FsmConditionPassRequest fsmConditionPassRequest = new FsmConditionPassRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
								{
									fsmConditionPassRequest.MergeFrom(this.FsmConditionPassRequest);
								}
								input.ReadMessage(fsmConditionPassRequest);
								this.FsmConditionPassRequest = fsmConditionPassRequest;
								continue;
							}
							if (num == 338U)
							{
								BuffStackCountRequest buffStackCountRequest = new BuffStackCountRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
								{
									buffStackCountRequest.MergeFrom(this.BuffStackCountRequest);
								}
								input.ReadMessage(buffStackCountRequest);
								this.BuffStackCountRequest = buffStackCountRequest;
								continue;
							}
						}
					}
					else if (num <= 370U)
					{
						if (num <= 354U)
						{
							if (num == 346U)
							{
								ANStartRequest anstartRequest = new ANStartRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
								{
									anstartRequest.MergeFrom(this.ANStartRequest);
								}
								input.ReadMessage(anstartRequest);
								this.ANStartRequest = anstartRequest;
								continue;
							}
							if (num == 354U)
							{
								UseSkillFailRequest useSkillFailRequest = new UseSkillFailRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
								{
									useSkillFailRequest.MergeFrom(this.UseSkillFailRequest);
								}
								input.ReadMessage(useSkillFailRequest);
								this.UseSkillFailRequest = useSkillFailRequest;
								continue;
							}
						}
						else
						{
							if (num == 362U)
							{
								EnterViewDirectionRequest enterViewDirectionRequest = new EnterViewDirectionRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
								{
									enterViewDirectionRequest.MergeFrom(this.EnterViewDirectionRequest);
								}
								input.ReadMessage(enterViewDirectionRequest);
								this.EnterViewDirectionRequest = enterViewDirectionRequest;
								continue;
							}
							if (num == 370U)
							{
								ExitViewDirectionRequest exitViewDirectionRequest = new ExitViewDirectionRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
								{
									exitViewDirectionRequest.MergeFrom(this.ExitViewDirectionRequest);
								}
								input.ReadMessage(exitViewDirectionRequest);
								this.ExitViewDirectionRequest = exitViewDirectionRequest;
								continue;
							}
						}
					}
					else if (num <= 394U)
					{
						if (num == 378U)
						{
							PassiveSkillAddRequest passiveSkillAddRequest = new PassiveSkillAddRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
							{
								passiveSkillAddRequest.MergeFrom(this.PassiveSkillAddRequest);
							}
							input.ReadMessage(passiveSkillAddRequest);
							this.PassiveSkillAddRequest = passiveSkillAddRequest;
							continue;
						}
						if (num == 394U)
						{
							InterruptSkillInDelayRequest interruptSkillInDelayRequest = new InterruptSkillInDelayRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
							{
								interruptSkillInDelayRequest.MergeFrom(this.InterruptSkillInDelayRequest);
							}
							input.ReadMessage(interruptSkillInDelayRequest);
							this.InterruptSkillInDelayRequest = interruptSkillInDelayRequest;
							continue;
						}
					}
					else
					{
						if (num == 402U)
						{
							TriggerExitSkillRequest triggerExitSkillRequest = new TriggerExitSkillRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
							{
								triggerExitSkillRequest.MergeFrom(this.TriggerExitSkillRequest);
							}
							input.ReadMessage(triggerExitSkillRequest);
							this.TriggerExitSkillRequest = triggerExitSkillRequest;
							continue;
						}
						if (num == 442U)
						{
							ActorVisibleRequest actorVisibleRequest = new ActorVisibleRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
							{
								actorVisibleRequest.MergeFrom(this.ActorVisibleRequest);
							}
							input.ReadMessage(actorVisibleRequest);
							this.ActorVisibleRequest = actorVisibleRequest;
							continue;
						}
						if (num == 450U)
						{
							BuffEffectRequest buffEffectRequest = new BuffEffectRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
							{
								buffEffectRequest.MergeFrom(this.BuffEffectRequest);
							}
							input.ReadMessage(buffEffectRequest);
							this.BuffEffectRequest = buffEffectRequest;
							continue;
						}
					}
				}
				else if (num <= 522U)
				{
					if (num <= 482U)
					{
						if (num <= 466U)
						{
							if (num == 458U)
							{
								FragileChangeRequest fragileChangeRequest = new FragileChangeRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
								{
									fragileChangeRequest.MergeFrom(this.FragileChangeRequest);
								}
								input.ReadMessage(fragileChangeRequest);
								this.FragileChangeRequest = fragileChangeRequest;
								continue;
							}
							if (num == 466U)
							{
								RTimeStopRequest rtimeStopRequest = new RTimeStopRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
								{
									rtimeStopRequest.MergeFrom(this.RTimeStopRequest);
								}
								input.ReadMessage(rtimeStopRequest);
								this.RTimeStopRequest = rtimeStopRequest;
								continue;
							}
						}
						else
						{
							if (num == 474U)
							{
								DrownEndTeleportRequest drownEndTeleportRequest = new DrownEndTeleportRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
								{
									drownEndTeleportRequest.MergeFrom(this.DrownEndTeleportRequest);
								}
								input.ReadMessage(drownEndTeleportRequest);
								this.DrownEndTeleportRequest = drownEndTeleportRequest;
								continue;
							}
							if (num == 482U)
							{
								MonsterDrownRequest monsterDrownRequest = new MonsterDrownRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
								{
									monsterDrownRequest.MergeFrom(this.MonsterDrownRequest);
								}
								input.ReadMessage(monsterDrownRequest);
								this.MonsterDrownRequest = monsterDrownRequest;
								continue;
							}
						}
					}
					else if (num <= 498U)
					{
						if (num == 490U)
						{
							PassiveSkillRemoveRequest passiveSkillRemoveRequest = new PassiveSkillRemoveRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
							{
								passiveSkillRemoveRequest.MergeFrom(this.PassiveSkillRemoveRequest);
							}
							input.ReadMessage(passiveSkillRemoveRequest);
							this.PassiveSkillRemoveRequest = passiveSkillRemoveRequest;
							continue;
						}
						if (num == 498U)
						{
							RTimeStopInstRequest rtimeStopInstRequest = new RTimeStopInstRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
							{
								rtimeStopInstRequest.MergeFrom(this.RTimeStopInstRequest);
							}
							input.ReadMessage(rtimeStopInstRequest);
							this.RTimeStopInstRequest = rtimeStopInstRequest;
							continue;
						}
					}
					else
					{
						if (num == 506U)
						{
							FsmStateBehaviorRequest fsmStateBehaviorRequest = new FsmStateBehaviorRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
							{
								fsmStateBehaviorRequest.MergeFrom(this.FsmStateBehaviorRequest);
							}
							input.ReadMessage(fsmStateBehaviorRequest);
							this.FsmStateBehaviorRequest = fsmStateBehaviorRequest;
							continue;
						}
						if (num == 514U)
						{
							FsmPlayMontageRequest fsmPlayMontageRequest = new FsmPlayMontageRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
							{
								fsmPlayMontageRequest.MergeFrom(this.FsmPlayMontageRequest);
							}
							input.ReadMessage(fsmPlayMontageRequest);
							this.FsmPlayMontageRequest = fsmPlayMontageRequest;
							continue;
						}
						if (num == 522U)
						{
							RTimeStopAnimRequest rtimeStopAnimRequest = new RTimeStopAnimRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
							{
								rtimeStopAnimRequest.MergeFrom(this.RTimeStopAnimRequest);
							}
							input.ReadMessage(rtimeStopAnimRequest);
							this.RTimeStopAnimRequest = rtimeStopAnimRequest;
							continue;
						}
					}
				}
				else if (num <= 554U)
				{
					if (num <= 538U)
					{
						if (num == 530U)
						{
							SwitchRoleRequest switchRoleRequest = new SwitchRoleRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
							{
								switchRoleRequest.MergeFrom(this.SwitchRoleRequest);
							}
							input.ReadMessage(switchRoleRequest);
							this.SwitchRoleRequest = switchRoleRequest;
							continue;
						}
						if (num == 538U)
						{
							GameplayTagRequest gameplayTagRequest = new GameplayTagRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
							{
								gameplayTagRequest.MergeFrom(this.GameplayTagRequest);
							}
							input.ReadMessage(gameplayTagRequest);
							this.GameplayTagRequest = gameplayTagRequest;
							continue;
						}
					}
					else
					{
						if (num == 546U)
						{
							ExecuteQteRequest executeQteRequest = new ExecuteQteRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
							{
								executeQteRequest.MergeFrom(this.ExecuteQteRequest);
							}
							input.ReadMessage(executeQteRequest);
							this.ExecuteQteRequest = executeQteRequest;
							continue;
						}
						if (num == 554U)
						{
							CombineEntitiesRequest combineEntitiesRequest = new CombineEntitiesRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
							{
								combineEntitiesRequest.MergeFrom(this.CombineEntitiesRequest);
							}
							input.ReadMessage(combineEntitiesRequest);
							this.CombineEntitiesRequest = combineEntitiesRequest;
							continue;
						}
					}
				}
				else if (num <= 570U)
				{
					if (num == 562U)
					{
						DissolveCombineRelationRequest dissolveCombineRelationRequest = new DissolveCombineRelationRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
						{
							dissolveCombineRelationRequest.MergeFrom(this.DissolveCombineRelationRequest);
						}
						input.ReadMessage(dissolveCombineRelationRequest);
						this.DissolveCombineRelationRequest = dissolveCombineRelationRequest;
						continue;
					}
					if (num == 570U)
					{
						ClientCurrentRoleReportRequest clientCurrentRoleReportRequest = new ClientCurrentRoleReportRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
						{
							clientCurrentRoleReportRequest.MergeFrom(this.ClientCurrentRoleReportRequest);
						}
						input.ReadMessage(clientCurrentRoleReportRequest);
						this.ClientCurrentRoleReportRequest = clientCurrentRoleReportRequest;
						continue;
					}
				}
				else
				{
					if (num == 578U)
					{
						GaSwitchCommonEnemyProCampRequest gaSwitchCommonEnemyProCampRequest = new GaSwitchCommonEnemyProCampRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
						{
							gaSwitchCommonEnemyProCampRequest.MergeFrom(this.GaSwitchCommonEnemyProCampRequest);
						}
						input.ReadMessage(gaSwitchCommonEnemyProCampRequest);
						this.GaSwitchCommonEnemyProCampRequest = gaSwitchCommonEnemyProCampRequest;
						continue;
					}
					if (num == 586U)
					{
						ChangeSummonEntityStateRequest changeSummonEntityStateRequest = new ChangeSummonEntityStateRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
						{
							changeSummonEntityStateRequest.MergeFrom(this.ChangeSummonEntityStateRequest);
						}
						input.ReadMessage(changeSummonEntityStateRequest);
						this.ChangeSummonEntityStateRequest = changeSummonEntityStateRequest;
						continue;
					}
					if (num == 794U)
					{
						CombatMaxCaseMessageRequest combatMaxCaseMessageRequest = new CombatMaxCaseMessageRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
						{
							combatMaxCaseMessageRequest.MergeFrom(this.CombatMaxCaseMessageRequest);
						}
						input.ReadMessage(combatMaxCaseMessageRequest);
						this.CombatMaxCaseMessageRequest = combatMaxCaseMessageRequest;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C2BC RID: 49852
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C2BD RID: 49853
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C2BE RID: 49854
		private CombatCommon combatCommon_;

		// Token: 0x0400C2BF RID: 49855
		public const int RequestIdFieldNumber = 2;

		// Token: 0x0400C2C0 RID: 49856
		private int requestId_;

		// Token: 0x0400C2C1 RID: 49857
		public const int CreateBulletRequestFieldNumber = 3;

		// Token: 0x0400C2C2 RID: 49858
		public const int DestroyBulletRequestFieldNumber = 4;

		// Token: 0x0400C2C3 RID: 49859
		public const int DamageExecuteRequestFieldNumber = 5;

		// Token: 0x0400C2C4 RID: 49860
		public const int ApplyGameplayEffectRequestFieldNumber = 6;

		// Token: 0x0400C2C5 RID: 49861
		public const int RemoveGameplayEffectRequestFieldNumber = 7;

		// Token: 0x0400C2C6 RID: 49862
		public const int HitRequestFieldNumber = 8;

		// Token: 0x0400C2C7 RID: 49863
		public const int HitEndRequestFieldNumber = 9;

		// Token: 0x0400C2C8 RID: 49864
		public const int SkillRequestFieldNumber = 10;

		// Token: 0x0400C2C9 RID: 49865
		public const int UseSkillRequestFieldNumber = 11;

		// Token: 0x0400C2CA RID: 49866
		public const int EndSkillRequestFieldNumber = 12;

		// Token: 0x0400C2CB RID: 49867
		public const int PartUpdateRequestFieldNumber = 13;

		// Token: 0x0400C2CC RID: 49868
		public const int MaterialRequestFieldNumber = 14;

		// Token: 0x0400C2CD RID: 49869
		public const int GameplayCueRequestFieldNumber = 15;

		// Token: 0x0400C2CE RID: 49870
		public const int EntityIsVisibleRequestFieldNumber = 16;

		// Token: 0x0400C2CF RID: 49871
		public const int SwitchCharacterStateRequestFieldNumber = 17;

		// Token: 0x0400C2D0 RID: 49872
		public const int LogicStateInitRequestFieldNumber = 18;

		// Token: 0x0400C2D1 RID: 49873
		public const int SwitchLogicStateRequestFieldNumber = 19;

		// Token: 0x0400C2D2 RID: 49874
		public const int AnimationStateChangedRequestFieldNumber = 20;

		// Token: 0x0400C2D3 RID: 49875
		public const int AnimationStateInitRequestFieldNumber = 21;

		// Token: 0x0400C2D4 RID: 49876
		public const int ModifyBulletParamsRequestFieldNumber = 22;

		// Token: 0x0400C2D5 RID: 49877
		public const int DrownRequestFieldNumber = 23;

		// Token: 0x0400C2D6 RID: 49878
		public const int OrderApplyBuffRequestFieldNumber = 24;

		// Token: 0x0400C2D7 RID: 49879
		public const int OrderRemoveBuffRequestFieldNumber = 25;

		// Token: 0x0400C2D8 RID: 49880
		public const int ActivateBuffRequestFieldNumber = 26;

		// Token: 0x0400C2D9 RID: 49881
		public const int OrderRemoveBuffByTagsRequestFieldNumber = 27;

		// Token: 0x0400C2DA RID: 49882
		public const int AiInformationRequestFieldNumber = 28;

		// Token: 0x0400C2DB RID: 49883
		public const int ToughCalcExtraRatioChangeRequestFieldNumber = 29;

		// Token: 0x0400C2DC RID: 49884
		public const int BattleStateChangeRequestFieldNumber = 30;

		// Token: 0x0400C2DD RID: 49885
		public const int AnimationGameplayTagRequestFieldNumber = 31;

		// Token: 0x0400C2DE RID: 49886
		public const int BoneVisibleChangeRequestFieldNumber = 32;

		// Token: 0x0400C2DF RID: 49887
		public const int AiBlackboardsRequestFieldNumber = 33;

		// Token: 0x0400C2E0 RID: 49888
		public const int AiBlackboardCdRequestFieldNumber = 34;

		// Token: 0x0400C2E1 RID: 49889
		public const int AiHateRequestFieldNumber = 35;

		// Token: 0x0400C2E2 RID: 49890
		public const int MonsterBoomRequestFieldNumber = 36;

		// Token: 0x0400C2E3 RID: 49891
		public const int CaughtRequestFieldNumber = 37;

		// Token: 0x0400C2E4 RID: 49892
		public const int EntityStaticHookMoveRequestFieldNumber = 38;

		// Token: 0x0400C2E5 RID: 49893
		public const int ChangeStateRequestFieldNumber = 39;

		// Token: 0x0400C2E6 RID: 49894
		public const int ChangeStateConfirmRequestFieldNumber = 40;

		// Token: 0x0400C2E7 RID: 49895
		public const int FsmConditionPassRequestFieldNumber = 41;

		// Token: 0x0400C2E8 RID: 49896
		public const int BuffStackCountRequestFieldNumber = 42;

		// Token: 0x0400C2E9 RID: 49897
		public const int ANStartRequestFieldNumber = 43;

		// Token: 0x0400C2EA RID: 49898
		public const int UseSkillFailRequestFieldNumber = 44;

		// Token: 0x0400C2EB RID: 49899
		public const int EnterViewDirectionRequestFieldNumber = 45;

		// Token: 0x0400C2EC RID: 49900
		public const int ExitViewDirectionRequestFieldNumber = 46;

		// Token: 0x0400C2ED RID: 49901
		public const int PassiveSkillAddRequestFieldNumber = 47;

		// Token: 0x0400C2EE RID: 49902
		public const int InterruptSkillInDelayRequestFieldNumber = 49;

		// Token: 0x0400C2EF RID: 49903
		public const int TriggerExitSkillRequestFieldNumber = 50;

		// Token: 0x0400C2F0 RID: 49904
		public const int ActorVisibleRequestFieldNumber = 55;

		// Token: 0x0400C2F1 RID: 49905
		public const int BuffEffectRequestFieldNumber = 56;

		// Token: 0x0400C2F2 RID: 49906
		public const int FragileChangeRequestFieldNumber = 57;

		// Token: 0x0400C2F3 RID: 49907
		public const int RTimeStopRequestFieldNumber = 58;

		// Token: 0x0400C2F4 RID: 49908
		public const int DrownEndTeleportRequestFieldNumber = 59;

		// Token: 0x0400C2F5 RID: 49909
		public const int MonsterDrownRequestFieldNumber = 60;

		// Token: 0x0400C2F6 RID: 49910
		public const int PassiveSkillRemoveRequestFieldNumber = 61;

		// Token: 0x0400C2F7 RID: 49911
		public const int RTimeStopInstRequestFieldNumber = 62;

		// Token: 0x0400C2F8 RID: 49912
		public const int FsmStateBehaviorRequestFieldNumber = 63;

		// Token: 0x0400C2F9 RID: 49913
		public const int FsmPlayMontageRequestFieldNumber = 64;

		// Token: 0x0400C2FA RID: 49914
		public const int RTimeStopAnimRequestFieldNumber = 65;

		// Token: 0x0400C2FB RID: 49915
		public const int SwitchRoleRequestFieldNumber = 66;

		// Token: 0x0400C2FC RID: 49916
		public const int GameplayTagRequestFieldNumber = 67;

		// Token: 0x0400C2FD RID: 49917
		public const int ExecuteQteRequestFieldNumber = 68;

		// Token: 0x0400C2FE RID: 49918
		public const int CombineEntitiesRequestFieldNumber = 69;

		// Token: 0x0400C2FF RID: 49919
		public const int DissolveCombineRelationRequestFieldNumber = 70;

		// Token: 0x0400C300 RID: 49920
		public const int ClientCurrentRoleReportRequestFieldNumber = 71;

		// Token: 0x0400C301 RID: 49921
		public const int GaSwitchCommonEnemyProCampRequestFieldNumber = 72;

		// Token: 0x0400C302 RID: 49922
		public const int ChangeSummonEntityStateRequestFieldNumber = 73;

		// Token: 0x0400C303 RID: 49923
		public const int CombatMaxCaseMessageRequestFieldNumber = 99;

		// Token: 0x0400C304 RID: 49924
		private object message_;

		// Token: 0x0400C305 RID: 49925
		private CombatRequestData.MessageOneofCase messageCase_;

		// Token: 0x02001A01 RID: 6657
		public enum MessageOneofCase
		{
			// Token: 0x0400CB8B RID: 52107
			None,
			// Token: 0x0400CB8C RID: 52108
			CreateBulletRequest = 3,
			// Token: 0x0400CB8D RID: 52109
			DestroyBulletRequest,
			// Token: 0x0400CB8E RID: 52110
			DamageExecuteRequest,
			// Token: 0x0400CB8F RID: 52111
			ApplyGameplayEffectRequest,
			// Token: 0x0400CB90 RID: 52112
			RemoveGameplayEffectRequest,
			// Token: 0x0400CB91 RID: 52113
			HitRequest,
			// Token: 0x0400CB92 RID: 52114
			HitEndRequest,
			// Token: 0x0400CB93 RID: 52115
			SkillRequest,
			// Token: 0x0400CB94 RID: 52116
			UseSkillRequest,
			// Token: 0x0400CB95 RID: 52117
			EndSkillRequest,
			// Token: 0x0400CB96 RID: 52118
			PartUpdateRequest,
			// Token: 0x0400CB97 RID: 52119
			MaterialRequest,
			// Token: 0x0400CB98 RID: 52120
			GameplayCueRequest,
			// Token: 0x0400CB99 RID: 52121
			EntityIsVisibleRequest,
			// Token: 0x0400CB9A RID: 52122
			SwitchCharacterStateRequest,
			// Token: 0x0400CB9B RID: 52123
			LogicStateInitRequest,
			// Token: 0x0400CB9C RID: 52124
			SwitchLogicStateRequest,
			// Token: 0x0400CB9D RID: 52125
			AnimationStateChangedRequest,
			// Token: 0x0400CB9E RID: 52126
			AnimationStateInitRequest,
			// Token: 0x0400CB9F RID: 52127
			ModifyBulletParamsRequest,
			// Token: 0x0400CBA0 RID: 52128
			DrownRequest,
			// Token: 0x0400CBA1 RID: 52129
			OrderApplyBuffRequest,
			// Token: 0x0400CBA2 RID: 52130
			OrderRemoveBuffRequest,
			// Token: 0x0400CBA3 RID: 52131
			ActivateBuffRequest,
			// Token: 0x0400CBA4 RID: 52132
			OrderRemoveBuffByTagsRequest,
			// Token: 0x0400CBA5 RID: 52133
			AiInformationRequest,
			// Token: 0x0400CBA6 RID: 52134
			ToughCalcExtraRatioChangeRequest,
			// Token: 0x0400CBA7 RID: 52135
			BattleStateChangeRequest,
			// Token: 0x0400CBA8 RID: 52136
			AnimationGameplayTagRequest,
			// Token: 0x0400CBA9 RID: 52137
			BoneVisibleChangeRequest,
			// Token: 0x0400CBAA RID: 52138
			AiBlackboardsRequest,
			// Token: 0x0400CBAB RID: 52139
			AiBlackboardCdRequest,
			// Token: 0x0400CBAC RID: 52140
			AiHateRequest,
			// Token: 0x0400CBAD RID: 52141
			MonsterBoomRequest,
			// Token: 0x0400CBAE RID: 52142
			CaughtRequest,
			// Token: 0x0400CBAF RID: 52143
			EntityStaticHookMoveRequest,
			// Token: 0x0400CBB0 RID: 52144
			ChangeStateRequest,
			// Token: 0x0400CBB1 RID: 52145
			ChangeStateConfirmRequest,
			// Token: 0x0400CBB2 RID: 52146
			FsmConditionPassRequest,
			// Token: 0x0400CBB3 RID: 52147
			BuffStackCountRequest,
			// Token: 0x0400CBB4 RID: 52148
			ANStartRequest,
			// Token: 0x0400CBB5 RID: 52149
			UseSkillFailRequest,
			// Token: 0x0400CBB6 RID: 52150
			EnterViewDirectionRequest,
			// Token: 0x0400CBB7 RID: 52151
			ExitViewDirectionRequest,
			// Token: 0x0400CBB8 RID: 52152
			PassiveSkillAddRequest,
			// Token: 0x0400CBB9 RID: 52153
			InterruptSkillInDelayRequest = 49,
			// Token: 0x0400CBBA RID: 52154
			TriggerExitSkillRequest,
			// Token: 0x0400CBBB RID: 52155
			ActorVisibleRequest = 55,
			// Token: 0x0400CBBC RID: 52156
			BuffEffectRequest,
			// Token: 0x0400CBBD RID: 52157
			FragileChangeRequest,
			// Token: 0x0400CBBE RID: 52158
			RTimeStopRequest,
			// Token: 0x0400CBBF RID: 52159
			DrownEndTeleportRequest,
			// Token: 0x0400CBC0 RID: 52160
			MonsterDrownRequest,
			// Token: 0x0400CBC1 RID: 52161
			PassiveSkillRemoveRequest,
			// Token: 0x0400CBC2 RID: 52162
			RTimeStopInstRequest,
			// Token: 0x0400CBC3 RID: 52163
			FsmStateBehaviorRequest,
			// Token: 0x0400CBC4 RID: 52164
			FsmPlayMontageRequest,
			// Token: 0x0400CBC5 RID: 52165
			RTimeStopAnimRequest,
			// Token: 0x0400CBC6 RID: 52166
			SwitchRoleRequest,
			// Token: 0x0400CBC7 RID: 52167
			GameplayTagRequest,
			// Token: 0x0400CBC8 RID: 52168
			ExecuteQteRequest,
			// Token: 0x0400CBC9 RID: 52169
			CombineEntitiesRequest,
			// Token: 0x0400CBCA RID: 52170
			DissolveCombineRelationRequest,
			// Token: 0x0400CBCB RID: 52171
			ClientCurrentRoleReportRequest,
			// Token: 0x0400CBCC RID: 52172
			GaSwitchCommonEnemyProCampRequest,
			// Token: 0x0400CBCD RID: 52173
			ChangeSummonEntityStateRequest,
			// Token: 0x0400CBCE RID: 52174
			CombatMaxCaseMessageRequest = 99
		}
	}
}
