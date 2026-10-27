using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200168C RID: 5772
	public sealed class CombatResponseData : IMessage<CombatResponseData>, IMessage, IEquatable<CombatResponseData>, IDeepCloneable<CombatResponseData>, IBufferMessage
	{
		// Token: 0x0601CE27 RID: 118311 RVA: 0x00436413 File Offset: 0x00434613
		[NullableContext(1)]
		public static CombatResponseData Create()
		{
			return new CombatResponseData();
		}

		// Token: 0x170061CE RID: 25038
		// (get) Token: 0x0601CE28 RID: 118312 RVA: 0x0043641A File Offset: 0x0043461A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061CF RID: 25039
		// (get) Token: 0x0601CE29 RID: 118313 RVA: 0x0043641D File Offset: 0x0043461D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatResponseData.Descriptor;
			}
		}

		// Token: 0x0601CE2A RID: 118314 RVA: 0x00436424 File Offset: 0x00434624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData()
		{
		}

		// Token: 0x0601CE2B RID: 118315 RVA: 0x0043642C File Offset: 0x0043462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData(CombatResponseData other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.requestId_ = other.requestId_;
			switch (other.MessageCase)
			{
			case CombatResponseData.MessageOneofCase.CreateBulletResponse:
				this.CreateBulletResponse = other.CreateBulletResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.DestroyBulletResponse:
				this.DestroyBulletResponse = other.DestroyBulletResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.DamageExecuteResponse:
				this.DamageExecuteResponse = other.DamageExecuteResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse:
				this.ApplyGameplayEffectResponse = other.ApplyGameplayEffectResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse:
				this.RemoveGameplayEffectResponse = other.RemoveGameplayEffectResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.HitResponse:
				this.HitResponse = other.HitResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.HitEndResponse:
				this.HitEndResponse = other.HitEndResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.SkillResponse:
				this.SkillResponse = other.SkillResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.UseSkillResponse:
				this.UseSkillResponse = other.UseSkillResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.EndSkillResponse:
				this.EndSkillResponse = other.EndSkillResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.PartUpdateResponse:
				this.PartUpdateResponse = other.PartUpdateResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.MaterialResponse:
				this.MaterialResponse = other.MaterialResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.GameplayCueResponse:
				this.GameplayCueResponse = other.GameplayCueResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.EntityIsVisibleResponse:
				this.EntityIsVisibleResponse = other.EntityIsVisibleResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse:
				this.SwitchCharacterStateResponse = other.SwitchCharacterStateResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.LogicStateInitResponse:
				this.LogicStateInitResponse = other.LogicStateInitResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.SwitchLogicStateResponse:
				this.SwitchLogicStateResponse = other.SwitchLogicStateResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.AnimationStateChangedResponse:
				this.AnimationStateChangedResponse = other.AnimationStateChangedResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.AnimationStateInitResponse:
				this.AnimationStateInitResponse = other.AnimationStateInitResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse:
				this.ModifyBulletParamsResponse = other.ModifyBulletParamsResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.DrownResponse:
				this.DrownResponse = other.DrownResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.OrderApplyBuffResponse:
				this.OrderApplyBuffResponse = other.OrderApplyBuffResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse:
				this.OrderRemoveBuffResponse = other.OrderRemoveBuffResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ActivateBuffResponse:
				this.ActivateBuffResponse = other.ActivateBuffResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse:
				this.OrderRemoveBuffByTagsResponse = other.OrderRemoveBuffByTagsResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.AiInformationResponse:
				this.AiInformationResponse = other.AiInformationResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse:
				this.ToughCalcExtraRatioChangeResponse = other.ToughCalcExtraRatioChangeResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.BattleStateChangeResponse:
				this.BattleStateChangeResponse = other.BattleStateChangeResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse:
				this.AnimationGameplayTagResponse = other.AnimationGameplayTagResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse:
				this.BoneVisibleChangeResponse = other.BoneVisibleChangeResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.AiBlackboardsResponse:
				this.AiBlackboardsResponse = other.AiBlackboardsResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.AiBlackboardCdResponse:
				this.AiBlackboardCdResponse = other.AiBlackboardCdResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.AiHateResponse:
				this.AiHateResponse = other.AiHateResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.MonsterBoomResponse:
				this.MonsterBoomResponse = other.MonsterBoomResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.CaughtResponse:
				this.CaughtResponse = other.CaughtResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse:
				this.EntityStaticHookMoveResponse = other.EntityStaticHookMoveResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ChangeStateResponse:
				this.ChangeStateResponse = other.ChangeStateResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse:
				this.ChangeStateConfirmResponse = other.ChangeStateConfirmResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.FsmConditionPassResponse:
				this.FsmConditionPassResponse = other.FsmConditionPassResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.BuffStackCountResponse:
				this.BuffStackCountResponse = other.BuffStackCountResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ANStartResponse:
				this.ANStartResponse = other.ANStartResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.UseSkillFailResponse:
				this.UseSkillFailResponse = other.UseSkillFailResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.EnterViewDirectionResponse:
				this.EnterViewDirectionResponse = other.EnterViewDirectionResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ExitViewDirectionResponse:
				this.ExitViewDirectionResponse = other.ExitViewDirectionResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.PassiveSkillAddResponse:
				this.PassiveSkillAddResponse = other.PassiveSkillAddResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse:
				this.InterruptSkillInDelayResponse = other.InterruptSkillInDelayResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.TriggerExitSkillResponse:
				this.TriggerExitSkillResponse = other.TriggerExitSkillResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ActorVisibleResponse:
				this.ActorVisibleResponse = other.ActorVisibleResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.BuffEffectResponse:
				this.BuffEffectResponse = other.BuffEffectResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.FragileChangeResponse:
				this.FragileChangeResponse = other.FragileChangeResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.RTimeStopResponse:
				this.RTimeStopResponse = other.RTimeStopResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.DrownEndTeleportResponse:
				this.DrownEndTeleportResponse = other.DrownEndTeleportResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.MonsterDrownResponse:
				this.MonsterDrownResponse = other.MonsterDrownResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse:
				this.PassiveSkillRemoveResponse = other.PassiveSkillRemoveResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.RTimeStopInstResponse:
				this.RTimeStopInstResponse = other.RTimeStopInstResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse:
				this.FsmStateBehaviorResponse = other.FsmStateBehaviorResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.FsmPlayMontageResponse:
				this.FsmPlayMontageResponse = other.FsmPlayMontageResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.RTimeStopAnimResponse:
				this.RTimeStopAnimResponse = other.RTimeStopAnimResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.SwitchRoleResponse:
				this.SwitchRoleResponse = other.SwitchRoleResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.GameplayTagResponse:
				this.GameplayTagResponse = other.GameplayTagResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ExecuteQteResponse:
				this.ExecuteQteResponse = other.ExecuteQteResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.CombineEntitiesResponse:
				this.CombineEntitiesResponse = other.CombineEntitiesResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse:
				this.DissolveCombineRelationResponse = other.DissolveCombineRelationResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse:
				this.ClientCurrentRoleReportResponse = other.ClientCurrentRoleReportResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse:
				this.GaSwitchCommonEnemyProCampResponse = other.GaSwitchCommonEnemyProCampResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse:
				this.ChangeSummonEntityStateResponse = other.ChangeSummonEntityStateResponse.Clone();
				break;
			case CombatResponseData.MessageOneofCase.CombatDataMaxResponse:
				this.CombatDataMaxResponse = other.CombatDataMaxResponse.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CE2C RID: 118316 RVA: 0x00436BBF File Offset: 0x00434DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData Clone()
		{
			return new CombatResponseData(this);
		}

		// Token: 0x170061D0 RID: 25040
		// (get) Token: 0x0601CE2D RID: 118317 RVA: 0x00436BC7 File Offset: 0x00434DC7
		// (set) Token: 0x0601CE2E RID: 118318 RVA: 0x00436BCF File Offset: 0x00434DCF
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

		// Token: 0x170061D1 RID: 25041
		// (get) Token: 0x0601CE2F RID: 118319 RVA: 0x00436BD8 File Offset: 0x00434DD8
		// (set) Token: 0x0601CE30 RID: 118320 RVA: 0x00436BE0 File Offset: 0x00434DE0
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

		// Token: 0x170061D2 RID: 25042
		// (get) Token: 0x0601CE31 RID: 118321 RVA: 0x00436BE9 File Offset: 0x00434DE9
		// (set) Token: 0x0601CE32 RID: 118322 RVA: 0x00436C01 File Offset: 0x00434E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletResponse CreateBulletResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.CreateBulletResponse)
				{
					return null;
				}
				return (CreateBulletResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.CreateBulletResponse);
			}
		}

		// Token: 0x170061D3 RID: 25043
		// (get) Token: 0x0601CE33 RID: 118323 RVA: 0x00436C17 File Offset: 0x00434E17
		// (set) Token: 0x0601CE34 RID: 118324 RVA: 0x00436C2F File Offset: 0x00434E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletResponse DestroyBulletResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.DestroyBulletResponse)
				{
					return null;
				}
				return (DestroyBulletResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.DestroyBulletResponse);
			}
		}

		// Token: 0x170061D4 RID: 25044
		// (get) Token: 0x0601CE35 RID: 118325 RVA: 0x00436C45 File Offset: 0x00434E45
		// (set) Token: 0x0601CE36 RID: 118326 RVA: 0x00436C5D File Offset: 0x00434E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteResponse DamageExecuteResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.DamageExecuteResponse)
				{
					return null;
				}
				return (DamageExecuteResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.DamageExecuteResponse);
			}
		}

		// Token: 0x170061D5 RID: 25045
		// (get) Token: 0x0601CE37 RID: 118327 RVA: 0x00436C73 File Offset: 0x00434E73
		// (set) Token: 0x0601CE38 RID: 118328 RVA: 0x00436C8B File Offset: 0x00434E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectResponse ApplyGameplayEffectResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse)
				{
					return null;
				}
				return (ApplyGameplayEffectResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse);
			}
		}

		// Token: 0x170061D6 RID: 25046
		// (get) Token: 0x0601CE39 RID: 118329 RVA: 0x00436CA1 File Offset: 0x00434EA1
		// (set) Token: 0x0601CE3A RID: 118330 RVA: 0x00436CB9 File Offset: 0x00434EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectResponse RemoveGameplayEffectResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse)
				{
					return null;
				}
				return (RemoveGameplayEffectResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse);
			}
		}

		// Token: 0x170061D7 RID: 25047
		// (get) Token: 0x0601CE3B RID: 118331 RVA: 0x00436CCF File Offset: 0x00434ECF
		// (set) Token: 0x0601CE3C RID: 118332 RVA: 0x00436CE7 File Offset: 0x00434EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitResponse HitResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.HitResponse)
				{
					return null;
				}
				return (HitResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.HitResponse);
			}
		}

		// Token: 0x170061D8 RID: 25048
		// (get) Token: 0x0601CE3D RID: 118333 RVA: 0x00436CFD File Offset: 0x00434EFD
		// (set) Token: 0x0601CE3E RID: 118334 RVA: 0x00436D16 File Offset: 0x00434F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndResponse HitEndResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.HitEndResponse)
				{
					return null;
				}
				return (HitEndResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.HitEndResponse);
			}
		}

		// Token: 0x170061D9 RID: 25049
		// (get) Token: 0x0601CE3F RID: 118335 RVA: 0x00436D2D File Offset: 0x00434F2D
		// (set) Token: 0x0601CE40 RID: 118336 RVA: 0x00436D46 File Offset: 0x00434F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillResponse SkillResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.SkillResponse)
				{
					return null;
				}
				return (SkillResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.SkillResponse);
			}
		}

		// Token: 0x170061DA RID: 25050
		// (get) Token: 0x0601CE41 RID: 118337 RVA: 0x00436D5D File Offset: 0x00434F5D
		// (set) Token: 0x0601CE42 RID: 118338 RVA: 0x00436D76 File Offset: 0x00434F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillResponse UseSkillResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.UseSkillResponse)
				{
					return null;
				}
				return (UseSkillResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.UseSkillResponse);
			}
		}

		// Token: 0x170061DB RID: 25051
		// (get) Token: 0x0601CE43 RID: 118339 RVA: 0x00436D8D File Offset: 0x00434F8D
		// (set) Token: 0x0601CE44 RID: 118340 RVA: 0x00436DA6 File Offset: 0x00434FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillResponse EndSkillResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.EndSkillResponse)
				{
					return null;
				}
				return (EndSkillResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.EndSkillResponse);
			}
		}

		// Token: 0x170061DC RID: 25052
		// (get) Token: 0x0601CE45 RID: 118341 RVA: 0x00436DBD File Offset: 0x00434FBD
		// (set) Token: 0x0601CE46 RID: 118342 RVA: 0x00436DD6 File Offset: 0x00434FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateResponse PartUpdateResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.PartUpdateResponse)
				{
					return null;
				}
				return (PartUpdateResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.PartUpdateResponse);
			}
		}

		// Token: 0x170061DD RID: 25053
		// (get) Token: 0x0601CE47 RID: 118343 RVA: 0x00436DED File Offset: 0x00434FED
		// (set) Token: 0x0601CE48 RID: 118344 RVA: 0x00436E06 File Offset: 0x00435006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialResponse MaterialResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.MaterialResponse)
				{
					return null;
				}
				return (MaterialResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.MaterialResponse);
			}
		}

		// Token: 0x170061DE RID: 25054
		// (get) Token: 0x0601CE49 RID: 118345 RVA: 0x00436E1D File Offset: 0x0043501D
		// (set) Token: 0x0601CE4A RID: 118346 RVA: 0x00436E36 File Offset: 0x00435036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueResponse GameplayCueResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.GameplayCueResponse)
				{
					return null;
				}
				return (GameplayCueResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.GameplayCueResponse);
			}
		}

		// Token: 0x170061DF RID: 25055
		// (get) Token: 0x0601CE4B RID: 118347 RVA: 0x00436E4D File Offset: 0x0043504D
		// (set) Token: 0x0601CE4C RID: 118348 RVA: 0x00436E66 File Offset: 0x00435066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleResponse EntityIsVisibleResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.EntityIsVisibleResponse)
				{
					return null;
				}
				return (EntityIsVisibleResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.EntityIsVisibleResponse);
			}
		}

		// Token: 0x170061E0 RID: 25056
		// (get) Token: 0x0601CE4D RID: 118349 RVA: 0x00436E7D File Offset: 0x0043507D
		// (set) Token: 0x0601CE4E RID: 118350 RVA: 0x00436E96 File Offset: 0x00435096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateResponse SwitchCharacterStateResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse)
				{
					return null;
				}
				return (SwitchCharacterStateResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse);
			}
		}

		// Token: 0x170061E1 RID: 25057
		// (get) Token: 0x0601CE4F RID: 118351 RVA: 0x00436EAD File Offset: 0x004350AD
		// (set) Token: 0x0601CE50 RID: 118352 RVA: 0x00436EC6 File Offset: 0x004350C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitResponse LogicStateInitResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.LogicStateInitResponse)
				{
					return null;
				}
				return (LogicStateInitResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.LogicStateInitResponse);
			}
		}

		// Token: 0x170061E2 RID: 25058
		// (get) Token: 0x0601CE51 RID: 118353 RVA: 0x00436EDD File Offset: 0x004350DD
		// (set) Token: 0x0601CE52 RID: 118354 RVA: 0x00436EF6 File Offset: 0x004350F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateResponse SwitchLogicStateResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.SwitchLogicStateResponse)
				{
					return null;
				}
				return (SwitchLogicStateResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.SwitchLogicStateResponse);
			}
		}

		// Token: 0x170061E3 RID: 25059
		// (get) Token: 0x0601CE53 RID: 118355 RVA: 0x00436F0D File Offset: 0x0043510D
		// (set) Token: 0x0601CE54 RID: 118356 RVA: 0x00436F26 File Offset: 0x00435126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedResponse AnimationStateChangedResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.AnimationStateChangedResponse)
				{
					return null;
				}
				return (AnimationStateChangedResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.AnimationStateChangedResponse);
			}
		}

		// Token: 0x170061E4 RID: 25060
		// (get) Token: 0x0601CE55 RID: 118357 RVA: 0x00436F3D File Offset: 0x0043513D
		// (set) Token: 0x0601CE56 RID: 118358 RVA: 0x00436F56 File Offset: 0x00435156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitResponse AnimationStateInitResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.AnimationStateInitResponse)
				{
					return null;
				}
				return (AnimationStateInitResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.AnimationStateInitResponse);
			}
		}

		// Token: 0x170061E5 RID: 25061
		// (get) Token: 0x0601CE57 RID: 118359 RVA: 0x00436F6D File Offset: 0x0043516D
		// (set) Token: 0x0601CE58 RID: 118360 RVA: 0x00436F86 File Offset: 0x00435186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsResponse ModifyBulletParamsResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse)
				{
					return null;
				}
				return (ModifyBulletParamsResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse);
			}
		}

		// Token: 0x170061E6 RID: 25062
		// (get) Token: 0x0601CE59 RID: 118361 RVA: 0x00436F9D File Offset: 0x0043519D
		// (set) Token: 0x0601CE5A RID: 118362 RVA: 0x00436FB6 File Offset: 0x004351B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownResponse DrownResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.DrownResponse)
				{
					return null;
				}
				return (DrownResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.DrownResponse);
			}
		}

		// Token: 0x170061E7 RID: 25063
		// (get) Token: 0x0601CE5B RID: 118363 RVA: 0x00436FCD File Offset: 0x004351CD
		// (set) Token: 0x0601CE5C RID: 118364 RVA: 0x00436FE6 File Offset: 0x004351E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffResponse OrderApplyBuffResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.OrderApplyBuffResponse)
				{
					return null;
				}
				return (OrderApplyBuffResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.OrderApplyBuffResponse);
			}
		}

		// Token: 0x170061E8 RID: 25064
		// (get) Token: 0x0601CE5D RID: 118365 RVA: 0x00436FFD File Offset: 0x004351FD
		// (set) Token: 0x0601CE5E RID: 118366 RVA: 0x00437016 File Offset: 0x00435216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffResponse OrderRemoveBuffResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse)
				{
					return null;
				}
				return (OrderRemoveBuffResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse);
			}
		}

		// Token: 0x170061E9 RID: 25065
		// (get) Token: 0x0601CE5F RID: 118367 RVA: 0x0043702D File Offset: 0x0043522D
		// (set) Token: 0x0601CE60 RID: 118368 RVA: 0x00437046 File Offset: 0x00435246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffResponse ActivateBuffResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ActivateBuffResponse)
				{
					return null;
				}
				return (ActivateBuffResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ActivateBuffResponse);
			}
		}

		// Token: 0x170061EA RID: 25066
		// (get) Token: 0x0601CE61 RID: 118369 RVA: 0x0043705D File Offset: 0x0043525D
		// (set) Token: 0x0601CE62 RID: 118370 RVA: 0x00437076 File Offset: 0x00435276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsResponse OrderRemoveBuffByTagsResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse)
				{
					return null;
				}
				return (OrderRemoveBuffByTagsResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse);
			}
		}

		// Token: 0x170061EB RID: 25067
		// (get) Token: 0x0601CE63 RID: 118371 RVA: 0x0043708D File Offset: 0x0043528D
		// (set) Token: 0x0601CE64 RID: 118372 RVA: 0x004370A6 File Offset: 0x004352A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationResponse AiInformationResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.AiInformationResponse)
				{
					return null;
				}
				return (AiInformationResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.AiInformationResponse);
			}
		}

		// Token: 0x170061EC RID: 25068
		// (get) Token: 0x0601CE65 RID: 118373 RVA: 0x004370BD File Offset: 0x004352BD
		// (set) Token: 0x0601CE66 RID: 118374 RVA: 0x004370D6 File Offset: 0x004352D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeResponse ToughCalcExtraRatioChangeResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse)
				{
					return null;
				}
				return (ToughCalcExtraRatioChangeResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse);
			}
		}

		// Token: 0x170061ED RID: 25069
		// (get) Token: 0x0601CE67 RID: 118375 RVA: 0x004370ED File Offset: 0x004352ED
		// (set) Token: 0x0601CE68 RID: 118376 RVA: 0x00437106 File Offset: 0x00435306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeResponse BattleStateChangeResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.BattleStateChangeResponse)
				{
					return null;
				}
				return (BattleStateChangeResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.BattleStateChangeResponse);
			}
		}

		// Token: 0x170061EE RID: 25070
		// (get) Token: 0x0601CE69 RID: 118377 RVA: 0x0043711D File Offset: 0x0043531D
		// (set) Token: 0x0601CE6A RID: 118378 RVA: 0x00437136 File Offset: 0x00435336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagResponse AnimationGameplayTagResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse)
				{
					return null;
				}
				return (AnimationGameplayTagResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse);
			}
		}

		// Token: 0x170061EF RID: 25071
		// (get) Token: 0x0601CE6B RID: 118379 RVA: 0x0043714D File Offset: 0x0043534D
		// (set) Token: 0x0601CE6C RID: 118380 RVA: 0x00437166 File Offset: 0x00435366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeResponse BoneVisibleChangeResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse)
				{
					return null;
				}
				return (BoneVisibleChangeResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse);
			}
		}

		// Token: 0x170061F0 RID: 25072
		// (get) Token: 0x0601CE6D RID: 118381 RVA: 0x0043717D File Offset: 0x0043537D
		// (set) Token: 0x0601CE6E RID: 118382 RVA: 0x00437196 File Offset: 0x00435396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsResponse AiBlackboardsResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.AiBlackboardsResponse)
				{
					return null;
				}
				return (AiBlackboardsResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.AiBlackboardsResponse);
			}
		}

		// Token: 0x170061F1 RID: 25073
		// (get) Token: 0x0601CE6F RID: 118383 RVA: 0x004371AD File Offset: 0x004353AD
		// (set) Token: 0x0601CE70 RID: 118384 RVA: 0x004371C6 File Offset: 0x004353C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdResponse AiBlackboardCdResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.AiBlackboardCdResponse)
				{
					return null;
				}
				return (AiBlackboardCdResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.AiBlackboardCdResponse);
			}
		}

		// Token: 0x170061F2 RID: 25074
		// (get) Token: 0x0601CE71 RID: 118385 RVA: 0x004371DD File Offset: 0x004353DD
		// (set) Token: 0x0601CE72 RID: 118386 RVA: 0x004371F6 File Offset: 0x004353F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateResponse AiHateResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.AiHateResponse)
				{
					return null;
				}
				return (AiHateResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.AiHateResponse);
			}
		}

		// Token: 0x170061F3 RID: 25075
		// (get) Token: 0x0601CE73 RID: 118387 RVA: 0x0043720D File Offset: 0x0043540D
		// (set) Token: 0x0601CE74 RID: 118388 RVA: 0x00437226 File Offset: 0x00435426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomResponse MonsterBoomResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.MonsterBoomResponse)
				{
					return null;
				}
				return (MonsterBoomResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.MonsterBoomResponse);
			}
		}

		// Token: 0x170061F4 RID: 25076
		// (get) Token: 0x0601CE75 RID: 118389 RVA: 0x0043723D File Offset: 0x0043543D
		// (set) Token: 0x0601CE76 RID: 118390 RVA: 0x00437256 File Offset: 0x00435456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtResponse CaughtResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.CaughtResponse)
				{
					return null;
				}
				return (CaughtResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.CaughtResponse);
			}
		}

		// Token: 0x170061F5 RID: 25077
		// (get) Token: 0x0601CE77 RID: 118391 RVA: 0x0043726D File Offset: 0x0043546D
		// (set) Token: 0x0601CE78 RID: 118392 RVA: 0x00437286 File Offset: 0x00435486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveResponse EntityStaticHookMoveResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse)
				{
					return null;
				}
				return (EntityStaticHookMoveResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse);
			}
		}

		// Token: 0x170061F6 RID: 25078
		// (get) Token: 0x0601CE79 RID: 118393 RVA: 0x0043729D File Offset: 0x0043549D
		// (set) Token: 0x0601CE7A RID: 118394 RVA: 0x004372B6 File Offset: 0x004354B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateResponse ChangeStateResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ChangeStateResponse)
				{
					return null;
				}
				return (ChangeStateResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ChangeStateResponse);
			}
		}

		// Token: 0x170061F7 RID: 25079
		// (get) Token: 0x0601CE7B RID: 118395 RVA: 0x004372CD File Offset: 0x004354CD
		// (set) Token: 0x0601CE7C RID: 118396 RVA: 0x004372E6 File Offset: 0x004354E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmResponse ChangeStateConfirmResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse)
				{
					return null;
				}
				return (ChangeStateConfirmResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse);
			}
		}

		// Token: 0x170061F8 RID: 25080
		// (get) Token: 0x0601CE7D RID: 118397 RVA: 0x004372FD File Offset: 0x004354FD
		// (set) Token: 0x0601CE7E RID: 118398 RVA: 0x00437316 File Offset: 0x00435516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassResponse FsmConditionPassResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.FsmConditionPassResponse)
				{
					return null;
				}
				return (FsmConditionPassResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.FsmConditionPassResponse);
			}
		}

		// Token: 0x170061F9 RID: 25081
		// (get) Token: 0x0601CE7F RID: 118399 RVA: 0x0043732D File Offset: 0x0043552D
		// (set) Token: 0x0601CE80 RID: 118400 RVA: 0x00437346 File Offset: 0x00435546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountResponse BuffStackCountResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.BuffStackCountResponse)
				{
					return null;
				}
				return (BuffStackCountResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.BuffStackCountResponse);
			}
		}

		// Token: 0x170061FA RID: 25082
		// (get) Token: 0x0601CE81 RID: 118401 RVA: 0x0043735D File Offset: 0x0043555D
		// (set) Token: 0x0601CE82 RID: 118402 RVA: 0x00437376 File Offset: 0x00435576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartResponse ANStartResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ANStartResponse)
				{
					return null;
				}
				return (ANStartResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ANStartResponse);
			}
		}

		// Token: 0x170061FB RID: 25083
		// (get) Token: 0x0601CE83 RID: 118403 RVA: 0x0043738D File Offset: 0x0043558D
		// (set) Token: 0x0601CE84 RID: 118404 RVA: 0x004373A6 File Offset: 0x004355A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailResponse UseSkillFailResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.UseSkillFailResponse)
				{
					return null;
				}
				return (UseSkillFailResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.UseSkillFailResponse);
			}
		}

		// Token: 0x170061FC RID: 25084
		// (get) Token: 0x0601CE85 RID: 118405 RVA: 0x004373BD File Offset: 0x004355BD
		// (set) Token: 0x0601CE86 RID: 118406 RVA: 0x004373D6 File Offset: 0x004355D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionResponse EnterViewDirectionResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.EnterViewDirectionResponse)
				{
					return null;
				}
				return (EnterViewDirectionResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.EnterViewDirectionResponse);
			}
		}

		// Token: 0x170061FD RID: 25085
		// (get) Token: 0x0601CE87 RID: 118407 RVA: 0x004373ED File Offset: 0x004355ED
		// (set) Token: 0x0601CE88 RID: 118408 RVA: 0x00437406 File Offset: 0x00435606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionResponse ExitViewDirectionResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ExitViewDirectionResponse)
				{
					return null;
				}
				return (ExitViewDirectionResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ExitViewDirectionResponse);
			}
		}

		// Token: 0x170061FE RID: 25086
		// (get) Token: 0x0601CE89 RID: 118409 RVA: 0x0043741D File Offset: 0x0043561D
		// (set) Token: 0x0601CE8A RID: 118410 RVA: 0x00437436 File Offset: 0x00435636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddResponse PassiveSkillAddResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.PassiveSkillAddResponse)
				{
					return null;
				}
				return (PassiveSkillAddResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.PassiveSkillAddResponse);
			}
		}

		// Token: 0x170061FF RID: 25087
		// (get) Token: 0x0601CE8B RID: 118411 RVA: 0x0043744D File Offset: 0x0043564D
		// (set) Token: 0x0601CE8C RID: 118412 RVA: 0x00437466 File Offset: 0x00435666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayResponse InterruptSkillInDelayResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse)
				{
					return null;
				}
				return (InterruptSkillInDelayResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse);
			}
		}

		// Token: 0x17006200 RID: 25088
		// (get) Token: 0x0601CE8D RID: 118413 RVA: 0x0043747D File Offset: 0x0043567D
		// (set) Token: 0x0601CE8E RID: 118414 RVA: 0x00437496 File Offset: 0x00435696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillResponse TriggerExitSkillResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.TriggerExitSkillResponse)
				{
					return null;
				}
				return (TriggerExitSkillResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.TriggerExitSkillResponse);
			}
		}

		// Token: 0x17006201 RID: 25089
		// (get) Token: 0x0601CE8F RID: 118415 RVA: 0x004374AD File Offset: 0x004356AD
		// (set) Token: 0x0601CE90 RID: 118416 RVA: 0x004374C6 File Offset: 0x004356C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleResponse ActorVisibleResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ActorVisibleResponse)
				{
					return null;
				}
				return (ActorVisibleResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ActorVisibleResponse);
			}
		}

		// Token: 0x17006202 RID: 25090
		// (get) Token: 0x0601CE91 RID: 118417 RVA: 0x004374DD File Offset: 0x004356DD
		// (set) Token: 0x0601CE92 RID: 118418 RVA: 0x004374F6 File Offset: 0x004356F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectResponse BuffEffectResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.BuffEffectResponse)
				{
					return null;
				}
				return (BuffEffectResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.BuffEffectResponse);
			}
		}

		// Token: 0x17006203 RID: 25091
		// (get) Token: 0x0601CE93 RID: 118419 RVA: 0x0043750D File Offset: 0x0043570D
		// (set) Token: 0x0601CE94 RID: 118420 RVA: 0x00437526 File Offset: 0x00435726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeResponse FragileChangeResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.FragileChangeResponse)
				{
					return null;
				}
				return (FragileChangeResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.FragileChangeResponse);
			}
		}

		// Token: 0x17006204 RID: 25092
		// (get) Token: 0x0601CE95 RID: 118421 RVA: 0x0043753D File Offset: 0x0043573D
		// (set) Token: 0x0601CE96 RID: 118422 RVA: 0x00437556 File Offset: 0x00435756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopResponse RTimeStopResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.RTimeStopResponse)
				{
					return null;
				}
				return (RTimeStopResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.RTimeStopResponse);
			}
		}

		// Token: 0x17006205 RID: 25093
		// (get) Token: 0x0601CE97 RID: 118423 RVA: 0x0043756D File Offset: 0x0043576D
		// (set) Token: 0x0601CE98 RID: 118424 RVA: 0x00437586 File Offset: 0x00435786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportResponse DrownEndTeleportResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.DrownEndTeleportResponse)
				{
					return null;
				}
				return (DrownEndTeleportResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.DrownEndTeleportResponse);
			}
		}

		// Token: 0x17006206 RID: 25094
		// (get) Token: 0x0601CE99 RID: 118425 RVA: 0x0043759D File Offset: 0x0043579D
		// (set) Token: 0x0601CE9A RID: 118426 RVA: 0x004375B6 File Offset: 0x004357B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownResponse MonsterDrownResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.MonsterDrownResponse)
				{
					return null;
				}
				return (MonsterDrownResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.MonsterDrownResponse);
			}
		}

		// Token: 0x17006207 RID: 25095
		// (get) Token: 0x0601CE9B RID: 118427 RVA: 0x004375CD File Offset: 0x004357CD
		// (set) Token: 0x0601CE9C RID: 118428 RVA: 0x004375E6 File Offset: 0x004357E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveResponse PassiveSkillRemoveResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse)
				{
					return null;
				}
				return (PassiveSkillRemoveResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse);
			}
		}

		// Token: 0x17006208 RID: 25096
		// (get) Token: 0x0601CE9D RID: 118429 RVA: 0x004375FD File Offset: 0x004357FD
		// (set) Token: 0x0601CE9E RID: 118430 RVA: 0x00437616 File Offset: 0x00435816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstResponse RTimeStopInstResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.RTimeStopInstResponse)
				{
					return null;
				}
				return (RTimeStopInstResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.RTimeStopInstResponse);
			}
		}

		// Token: 0x17006209 RID: 25097
		// (get) Token: 0x0601CE9F RID: 118431 RVA: 0x0043762D File Offset: 0x0043582D
		// (set) Token: 0x0601CEA0 RID: 118432 RVA: 0x00437646 File Offset: 0x00435846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorResponse FsmStateBehaviorResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse)
				{
					return null;
				}
				return (FsmStateBehaviorResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse);
			}
		}

		// Token: 0x1700620A RID: 25098
		// (get) Token: 0x0601CEA1 RID: 118433 RVA: 0x0043765D File Offset: 0x0043585D
		// (set) Token: 0x0601CEA2 RID: 118434 RVA: 0x00437676 File Offset: 0x00435876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageResponse FsmPlayMontageResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.FsmPlayMontageResponse)
				{
					return null;
				}
				return (FsmPlayMontageResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.FsmPlayMontageResponse);
			}
		}

		// Token: 0x1700620B RID: 25099
		// (get) Token: 0x0601CEA3 RID: 118435 RVA: 0x0043768D File Offset: 0x0043588D
		// (set) Token: 0x0601CEA4 RID: 118436 RVA: 0x004376A6 File Offset: 0x004358A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimResponse RTimeStopAnimResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.RTimeStopAnimResponse)
				{
					return null;
				}
				return (RTimeStopAnimResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.RTimeStopAnimResponse);
			}
		}

		// Token: 0x1700620C RID: 25100
		// (get) Token: 0x0601CEA5 RID: 118437 RVA: 0x004376BD File Offset: 0x004358BD
		// (set) Token: 0x0601CEA6 RID: 118438 RVA: 0x004376D6 File Offset: 0x004358D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleResponse SwitchRoleResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.SwitchRoleResponse)
				{
					return null;
				}
				return (SwitchRoleResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.SwitchRoleResponse);
			}
		}

		// Token: 0x1700620D RID: 25101
		// (get) Token: 0x0601CEA7 RID: 118439 RVA: 0x004376ED File Offset: 0x004358ED
		// (set) Token: 0x0601CEA8 RID: 118440 RVA: 0x00437706 File Offset: 0x00435906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagResponse GameplayTagResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.GameplayTagResponse)
				{
					return null;
				}
				return (GameplayTagResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.GameplayTagResponse);
			}
		}

		// Token: 0x1700620E RID: 25102
		// (get) Token: 0x0601CEA9 RID: 118441 RVA: 0x0043771D File Offset: 0x0043591D
		// (set) Token: 0x0601CEAA RID: 118442 RVA: 0x00437736 File Offset: 0x00435936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteResponse ExecuteQteResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ExecuteQteResponse)
				{
					return null;
				}
				return (ExecuteQteResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ExecuteQteResponse);
			}
		}

		// Token: 0x1700620F RID: 25103
		// (get) Token: 0x0601CEAB RID: 118443 RVA: 0x0043774D File Offset: 0x0043594D
		// (set) Token: 0x0601CEAC RID: 118444 RVA: 0x00437766 File Offset: 0x00435966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesResponse CombineEntitiesResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.CombineEntitiesResponse)
				{
					return null;
				}
				return (CombineEntitiesResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.CombineEntitiesResponse);
			}
		}

		// Token: 0x17006210 RID: 25104
		// (get) Token: 0x0601CEAD RID: 118445 RVA: 0x0043777D File Offset: 0x0043597D
		// (set) Token: 0x0601CEAE RID: 118446 RVA: 0x00437796 File Offset: 0x00435996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationResponse DissolveCombineRelationResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse)
				{
					return null;
				}
				return (DissolveCombineRelationResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse);
			}
		}

		// Token: 0x17006211 RID: 25105
		// (get) Token: 0x0601CEAF RID: 118447 RVA: 0x004377AD File Offset: 0x004359AD
		// (set) Token: 0x0601CEB0 RID: 118448 RVA: 0x004377C6 File Offset: 0x004359C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportResponse ClientCurrentRoleReportResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse)
				{
					return null;
				}
				return (ClientCurrentRoleReportResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse);
			}
		}

		// Token: 0x17006212 RID: 25106
		// (get) Token: 0x0601CEB1 RID: 118449 RVA: 0x004377DD File Offset: 0x004359DD
		// (set) Token: 0x0601CEB2 RID: 118450 RVA: 0x004377F6 File Offset: 0x004359F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampResponse GaSwitchCommonEnemyProCampResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse)
				{
					return null;
				}
				return (GaSwitchCommonEnemyProCampResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse);
			}
		}

		// Token: 0x17006213 RID: 25107
		// (get) Token: 0x0601CEB3 RID: 118451 RVA: 0x0043780D File Offset: 0x00435A0D
		// (set) Token: 0x0601CEB4 RID: 118452 RVA: 0x00437826 File Offset: 0x00435A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateResponse ChangeSummonEntityStateResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse)
				{
					return null;
				}
				return (ChangeSummonEntityStateResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse);
			}
		}

		// Token: 0x17006214 RID: 25108
		// (get) Token: 0x0601CEB5 RID: 118453 RVA: 0x0043783D File Offset: 0x00435A3D
		// (set) Token: 0x0601CEB6 RID: 118454 RVA: 0x00437856 File Offset: 0x00435A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxResponse CombatDataMaxResponse
		{
			get
			{
				if (this.messageCase_ != CombatResponseData.MessageOneofCase.CombatDataMaxResponse)
				{
					return null;
				}
				return (CombatDataMaxResponse)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatResponseData.MessageOneofCase.None : CombatResponseData.MessageOneofCase.CombatDataMaxResponse);
			}
		}

		// Token: 0x17006215 RID: 25109
		// (get) Token: 0x0601CEB7 RID: 118455 RVA: 0x0043786D File Offset: 0x00435A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601CEB8 RID: 118456 RVA: 0x00437875 File Offset: 0x00435A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatResponseData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601CEB9 RID: 118457 RVA: 0x00437885 File Offset: 0x00435A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatResponseData);
		}

		// Token: 0x0601CEBA RID: 118458 RVA: 0x00437894 File Offset: 0x00435A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatResponseData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.RequestId == other.RequestId && object.Equals(this.CreateBulletResponse, other.CreateBulletResponse) && object.Equals(this.DestroyBulletResponse, other.DestroyBulletResponse) && object.Equals(this.DamageExecuteResponse, other.DamageExecuteResponse) && object.Equals(this.ApplyGameplayEffectResponse, other.ApplyGameplayEffectResponse) && object.Equals(this.RemoveGameplayEffectResponse, other.RemoveGameplayEffectResponse) && object.Equals(this.HitResponse, other.HitResponse) && object.Equals(this.HitEndResponse, other.HitEndResponse) && object.Equals(this.SkillResponse, other.SkillResponse) && object.Equals(this.UseSkillResponse, other.UseSkillResponse) && object.Equals(this.EndSkillResponse, other.EndSkillResponse) && object.Equals(this.PartUpdateResponse, other.PartUpdateResponse) && object.Equals(this.MaterialResponse, other.MaterialResponse) && object.Equals(this.GameplayCueResponse, other.GameplayCueResponse) && object.Equals(this.EntityIsVisibleResponse, other.EntityIsVisibleResponse) && object.Equals(this.SwitchCharacterStateResponse, other.SwitchCharacterStateResponse) && object.Equals(this.LogicStateInitResponse, other.LogicStateInitResponse) && object.Equals(this.SwitchLogicStateResponse, other.SwitchLogicStateResponse) && object.Equals(this.AnimationStateChangedResponse, other.AnimationStateChangedResponse) && object.Equals(this.AnimationStateInitResponse, other.AnimationStateInitResponse) && object.Equals(this.ModifyBulletParamsResponse, other.ModifyBulletParamsResponse) && object.Equals(this.DrownResponse, other.DrownResponse) && object.Equals(this.OrderApplyBuffResponse, other.OrderApplyBuffResponse) && object.Equals(this.OrderRemoveBuffResponse, other.OrderRemoveBuffResponse) && object.Equals(this.ActivateBuffResponse, other.ActivateBuffResponse) && object.Equals(this.OrderRemoveBuffByTagsResponse, other.OrderRemoveBuffByTagsResponse) && object.Equals(this.AiInformationResponse, other.AiInformationResponse) && object.Equals(this.ToughCalcExtraRatioChangeResponse, other.ToughCalcExtraRatioChangeResponse) && object.Equals(this.BattleStateChangeResponse, other.BattleStateChangeResponse) && object.Equals(this.AnimationGameplayTagResponse, other.AnimationGameplayTagResponse) && object.Equals(this.BoneVisibleChangeResponse, other.BoneVisibleChangeResponse) && object.Equals(this.AiBlackboardsResponse, other.AiBlackboardsResponse) && object.Equals(this.AiBlackboardCdResponse, other.AiBlackboardCdResponse) && object.Equals(this.AiHateResponse, other.AiHateResponse) && object.Equals(this.MonsterBoomResponse, other.MonsterBoomResponse) && object.Equals(this.CaughtResponse, other.CaughtResponse) && object.Equals(this.EntityStaticHookMoveResponse, other.EntityStaticHookMoveResponse) && object.Equals(this.ChangeStateResponse, other.ChangeStateResponse) && object.Equals(this.ChangeStateConfirmResponse, other.ChangeStateConfirmResponse) && object.Equals(this.FsmConditionPassResponse, other.FsmConditionPassResponse) && object.Equals(this.BuffStackCountResponse, other.BuffStackCountResponse) && object.Equals(this.ANStartResponse, other.ANStartResponse) && object.Equals(this.UseSkillFailResponse, other.UseSkillFailResponse) && object.Equals(this.EnterViewDirectionResponse, other.EnterViewDirectionResponse) && object.Equals(this.ExitViewDirectionResponse, other.ExitViewDirectionResponse) && object.Equals(this.PassiveSkillAddResponse, other.PassiveSkillAddResponse) && object.Equals(this.InterruptSkillInDelayResponse, other.InterruptSkillInDelayResponse) && object.Equals(this.TriggerExitSkillResponse, other.TriggerExitSkillResponse) && object.Equals(this.ActorVisibleResponse, other.ActorVisibleResponse) && object.Equals(this.BuffEffectResponse, other.BuffEffectResponse) && object.Equals(this.FragileChangeResponse, other.FragileChangeResponse) && object.Equals(this.RTimeStopResponse, other.RTimeStopResponse) && object.Equals(this.DrownEndTeleportResponse, other.DrownEndTeleportResponse) && object.Equals(this.MonsterDrownResponse, other.MonsterDrownResponse) && object.Equals(this.PassiveSkillRemoveResponse, other.PassiveSkillRemoveResponse) && object.Equals(this.RTimeStopInstResponse, other.RTimeStopInstResponse) && object.Equals(this.FsmStateBehaviorResponse, other.FsmStateBehaviorResponse) && object.Equals(this.FsmPlayMontageResponse, other.FsmPlayMontageResponse) && object.Equals(this.RTimeStopAnimResponse, other.RTimeStopAnimResponse) && object.Equals(this.SwitchRoleResponse, other.SwitchRoleResponse) && object.Equals(this.GameplayTagResponse, other.GameplayTagResponse) && object.Equals(this.ExecuteQteResponse, other.ExecuteQteResponse) && object.Equals(this.CombineEntitiesResponse, other.CombineEntitiesResponse) && object.Equals(this.DissolveCombineRelationResponse, other.DissolveCombineRelationResponse) && object.Equals(this.ClientCurrentRoleReportResponse, other.ClientCurrentRoleReportResponse) && object.Equals(this.GaSwitchCommonEnemyProCampResponse, other.GaSwitchCommonEnemyProCampResponse) && object.Equals(this.ChangeSummonEntityStateResponse, other.ChangeSummonEntityStateResponse) && object.Equals(this.CombatDataMaxResponse, other.CombatDataMaxResponse) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEBB RID: 118459 RVA: 0x00437E74 File Offset: 0x00436074
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
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CreateBulletResponse)
			{
				num ^= this.CreateBulletResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DestroyBulletResponse)
			{
				num ^= this.DestroyBulletResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DamageExecuteResponse)
			{
				num ^= this.DamageExecuteResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse)
			{
				num ^= this.ApplyGameplayEffectResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse)
			{
				num ^= this.RemoveGameplayEffectResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitResponse)
			{
				num ^= this.HitResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitEndResponse)
			{
				num ^= this.HitEndResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SkillResponse)
			{
				num ^= this.SkillResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillResponse)
			{
				num ^= this.UseSkillResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EndSkillResponse)
			{
				num ^= this.EndSkillResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PartUpdateResponse)
			{
				num ^= this.PartUpdateResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MaterialResponse)
			{
				num ^= this.MaterialResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayCueResponse)
			{
				num ^= this.GameplayCueResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityIsVisibleResponse)
			{
				num ^= this.EntityIsVisibleResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse)
			{
				num ^= this.SwitchCharacterStateResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.LogicStateInitResponse)
			{
				num ^= this.LogicStateInitResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchLogicStateResponse)
			{
				num ^= this.SwitchLogicStateResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateChangedResponse)
			{
				num ^= this.AnimationStateChangedResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateInitResponse)
			{
				num ^= this.AnimationStateInitResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse)
			{
				num ^= this.ModifyBulletParamsResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownResponse)
			{
				num ^= this.DrownResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderApplyBuffResponse)
			{
				num ^= this.OrderApplyBuffResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse)
			{
				num ^= this.OrderRemoveBuffResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActivateBuffResponse)
			{
				num ^= this.ActivateBuffResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse)
			{
				num ^= this.OrderRemoveBuffByTagsResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiInformationResponse)
			{
				num ^= this.AiInformationResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse)
			{
				num ^= this.ToughCalcExtraRatioChangeResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BattleStateChangeResponse)
			{
				num ^= this.BattleStateChangeResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse)
			{
				num ^= this.AnimationGameplayTagResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse)
			{
				num ^= this.BoneVisibleChangeResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardsResponse)
			{
				num ^= this.AiBlackboardsResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardCdResponse)
			{
				num ^= this.AiBlackboardCdResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiHateResponse)
			{
				num ^= this.AiHateResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterBoomResponse)
			{
				num ^= this.MonsterBoomResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CaughtResponse)
			{
				num ^= this.CaughtResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse)
			{
				num ^= this.EntityStaticHookMoveResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateResponse)
			{
				num ^= this.ChangeStateResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse)
			{
				num ^= this.ChangeStateConfirmResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmConditionPassResponse)
			{
				num ^= this.FsmConditionPassResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffStackCountResponse)
			{
				num ^= this.BuffStackCountResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ANStartResponse)
			{
				num ^= this.ANStartResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillFailResponse)
			{
				num ^= this.UseSkillFailResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EnterViewDirectionResponse)
			{
				num ^= this.EnterViewDirectionResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExitViewDirectionResponse)
			{
				num ^= this.ExitViewDirectionResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillAddResponse)
			{
				num ^= this.PassiveSkillAddResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse)
			{
				num ^= this.InterruptSkillInDelayResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.TriggerExitSkillResponse)
			{
				num ^= this.TriggerExitSkillResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActorVisibleResponse)
			{
				num ^= this.ActorVisibleResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffEffectResponse)
			{
				num ^= this.BuffEffectResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FragileChangeResponse)
			{
				num ^= this.FragileChangeResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopResponse)
			{
				num ^= this.RTimeStopResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownEndTeleportResponse)
			{
				num ^= this.DrownEndTeleportResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterDrownResponse)
			{
				num ^= this.MonsterDrownResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse)
			{
				num ^= this.PassiveSkillRemoveResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopInstResponse)
			{
				num ^= this.RTimeStopInstResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse)
			{
				num ^= this.FsmStateBehaviorResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmPlayMontageResponse)
			{
				num ^= this.FsmPlayMontageResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopAnimResponse)
			{
				num ^= this.RTimeStopAnimResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchRoleResponse)
			{
				num ^= this.SwitchRoleResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayTagResponse)
			{
				num ^= this.GameplayTagResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExecuteQteResponse)
			{
				num ^= this.ExecuteQteResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombineEntitiesResponse)
			{
				num ^= this.CombineEntitiesResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse)
			{
				num ^= this.DissolveCombineRelationResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse)
			{
				num ^= this.ClientCurrentRoleReportResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse)
			{
				num ^= this.GaSwitchCommonEnemyProCampResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse)
			{
				num ^= this.ChangeSummonEntityStateResponse.GetHashCode();
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombatDataMaxResponse)
			{
				num ^= this.CombatDataMaxResponse.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CEBC RID: 118460 RVA: 0x00438514 File Offset: 0x00436714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CEBD RID: 118461 RVA: 0x00438521 File Offset: 0x00436721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEBE RID: 118462 RVA: 0x0043852C File Offset: 0x0043672C
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
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CreateBulletResponse)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CreateBulletResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DestroyBulletResponse)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.DestroyBulletResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DamageExecuteResponse)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DamageExecuteResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ApplyGameplayEffectResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RemoveGameplayEffectResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitResponse)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.HitResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitEndResponse)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HitEndResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SkillResponse)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillResponse)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UseSkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EndSkillResponse)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EndSkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PartUpdateResponse)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PartUpdateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MaterialResponse)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MaterialResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayCueResponse)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GameplayCueResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityIsVisibleResponse)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.EntityIsVisibleResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.SwitchCharacterStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.LogicStateInitResponse)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.LogicStateInitResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchLogicStateResponse)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.SwitchLogicStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateChangedResponse)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.AnimationStateChangedResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateInitResponse)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.AnimationStateInitResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.ModifyBulletParamsResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownResponse)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.DrownResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderApplyBuffResponse)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.OrderApplyBuffResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.OrderRemoveBuffResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActivateBuffResponse)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.ActivateBuffResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.OrderRemoveBuffByTagsResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiInformationResponse)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.AiInformationResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.ToughCalcExtraRatioChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BattleStateChangeResponse)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.BattleStateChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.AnimationGameplayTagResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.BoneVisibleChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardsResponse)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.AiBlackboardsResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardCdResponse)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.AiBlackboardCdResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiHateResponse)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.AiHateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterBoomResponse)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.MonsterBoomResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CaughtResponse)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.CaughtResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.EntityStaticHookMoveResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateResponse)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.ChangeStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.ChangeStateConfirmResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmConditionPassResponse)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.FsmConditionPassResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffStackCountResponse)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.BuffStackCountResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ANStartResponse)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.ANStartResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillFailResponse)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.UseSkillFailResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EnterViewDirectionResponse)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.EnterViewDirectionResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExitViewDirectionResponse)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.ExitViewDirectionResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillAddResponse)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.PassiveSkillAddResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.InterruptSkillInDelayResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.TriggerExitSkillResponse)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.TriggerExitSkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActorVisibleResponse)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.ActorVisibleResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffEffectResponse)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.BuffEffectResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FragileChangeResponse)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.FragileChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopResponse)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.RTimeStopResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownEndTeleportResponse)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.DrownEndTeleportResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterDrownResponse)
			{
				output.WriteRawTag(226, 3);
				output.WriteMessage(this.MonsterDrownResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.PassiveSkillRemoveResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopInstResponse)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.RTimeStopInstResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.FsmStateBehaviorResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmPlayMontageResponse)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.FsmPlayMontageResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopAnimResponse)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.RTimeStopAnimResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchRoleResponse)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.SwitchRoleResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayTagResponse)
			{
				output.WriteRawTag(154, 4);
				output.WriteMessage(this.GameplayTagResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExecuteQteResponse)
			{
				output.WriteRawTag(162, 4);
				output.WriteMessage(this.ExecuteQteResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombineEntitiesResponse)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.CombineEntitiesResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse)
			{
				output.WriteRawTag(178, 4);
				output.WriteMessage(this.DissolveCombineRelationResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.ClientCurrentRoleReportResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.GaSwitchCommonEnemyProCampResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse)
			{
				output.WriteRawTag(202, 4);
				output.WriteMessage(this.ChangeSummonEntityStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombatDataMaxResponse)
			{
				output.WriteRawTag(162, 6);
				output.WriteMessage(this.CombatDataMaxResponse);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CEBF RID: 118463 RVA: 0x00438E34 File Offset: 0x00437034
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
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CreateBulletResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CreateBulletResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DestroyBulletResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DestroyBulletResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DamageExecuteResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageExecuteResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApplyGameplayEffectResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveGameplayEffectResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitEndResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitEndResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SkillResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EndSkillResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndSkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PartUpdateResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartUpdateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MaterialResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MaterialResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayCueResponse)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameplayCueResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityIsVisibleResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityIsVisibleResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchCharacterStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.LogicStateInitResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LogicStateInitResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchLogicStateResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchLogicStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateChangedResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateChangedResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateInitResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateInitResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParamsResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderApplyBuffResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderApplyBuffResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActivateBuffResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActivateBuffResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffByTagsResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiInformationResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiInformationResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ToughCalcExtraRatioChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BattleStateChangeResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BattleStateChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationGameplayTagResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardsResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardsResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardCdResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardCdResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiHateResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiHateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterBoomResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterBoomResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CaughtResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CaughtResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityStaticHookMoveResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateConfirmResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmConditionPassResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmConditionPassResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffStackCountResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffStackCountResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ANStartResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ANStartResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillFailResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.UseSkillFailResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.EnterViewDirectionResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EnterViewDirectionResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExitViewDirectionResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExitViewDirectionResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillAddResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillAddResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InterruptSkillInDelayResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.TriggerExitSkillResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TriggerExitSkillResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActorVisibleResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActorVisibleResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffEffectResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffEffectResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FragileChangeResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FragileChangeResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownEndTeleportResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownEndTeleportResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterDrownResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterDrownResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillRemoveResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopInstResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopInstResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmStateBehaviorResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmPlayMontageResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmPlayMontageResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopAnimResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopAnimResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchRoleResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchRoleResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayTagResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GameplayTagResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExecuteQteResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExecuteQteResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombineEntitiesResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombineEntitiesResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DissolveCombineRelationResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ClientCurrentRoleReportResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GaSwitchCommonEnemyProCampResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeSummonEntityStateResponse);
			}
			if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombatDataMaxResponse)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombatDataMaxResponse);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CEC0 RID: 118464 RVA: 0x00439554 File Offset: 0x00437754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatResponseData other)
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
			case CombatResponseData.MessageOneofCase.CreateBulletResponse:
				if (this.CreateBulletResponse == null)
				{
					this.CreateBulletResponse = new CreateBulletResponse();
				}
				this.CreateBulletResponse.MergeFrom(other.CreateBulletResponse);
				break;
			case CombatResponseData.MessageOneofCase.DestroyBulletResponse:
				if (this.DestroyBulletResponse == null)
				{
					this.DestroyBulletResponse = new DestroyBulletResponse();
				}
				this.DestroyBulletResponse.MergeFrom(other.DestroyBulletResponse);
				break;
			case CombatResponseData.MessageOneofCase.DamageExecuteResponse:
				if (this.DamageExecuteResponse == null)
				{
					this.DamageExecuteResponse = new DamageExecuteResponse();
				}
				this.DamageExecuteResponse.MergeFrom(other.DamageExecuteResponse);
				break;
			case CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse:
				if (this.ApplyGameplayEffectResponse == null)
				{
					this.ApplyGameplayEffectResponse = new ApplyGameplayEffectResponse();
				}
				this.ApplyGameplayEffectResponse.MergeFrom(other.ApplyGameplayEffectResponse);
				break;
			case CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse:
				if (this.RemoveGameplayEffectResponse == null)
				{
					this.RemoveGameplayEffectResponse = new RemoveGameplayEffectResponse();
				}
				this.RemoveGameplayEffectResponse.MergeFrom(other.RemoveGameplayEffectResponse);
				break;
			case CombatResponseData.MessageOneofCase.HitResponse:
				if (this.HitResponse == null)
				{
					this.HitResponse = new HitResponse();
				}
				this.HitResponse.MergeFrom(other.HitResponse);
				break;
			case CombatResponseData.MessageOneofCase.HitEndResponse:
				if (this.HitEndResponse == null)
				{
					this.HitEndResponse = new HitEndResponse();
				}
				this.HitEndResponse.MergeFrom(other.HitEndResponse);
				break;
			case CombatResponseData.MessageOneofCase.SkillResponse:
				if (this.SkillResponse == null)
				{
					this.SkillResponse = new SkillResponse();
				}
				this.SkillResponse.MergeFrom(other.SkillResponse);
				break;
			case CombatResponseData.MessageOneofCase.UseSkillResponse:
				if (this.UseSkillResponse == null)
				{
					this.UseSkillResponse = new UseSkillResponse();
				}
				this.UseSkillResponse.MergeFrom(other.UseSkillResponse);
				break;
			case CombatResponseData.MessageOneofCase.EndSkillResponse:
				if (this.EndSkillResponse == null)
				{
					this.EndSkillResponse = new EndSkillResponse();
				}
				this.EndSkillResponse.MergeFrom(other.EndSkillResponse);
				break;
			case CombatResponseData.MessageOneofCase.PartUpdateResponse:
				if (this.PartUpdateResponse == null)
				{
					this.PartUpdateResponse = new PartUpdateResponse();
				}
				this.PartUpdateResponse.MergeFrom(other.PartUpdateResponse);
				break;
			case CombatResponseData.MessageOneofCase.MaterialResponse:
				if (this.MaterialResponse == null)
				{
					this.MaterialResponse = new MaterialResponse();
				}
				this.MaterialResponse.MergeFrom(other.MaterialResponse);
				break;
			case CombatResponseData.MessageOneofCase.GameplayCueResponse:
				if (this.GameplayCueResponse == null)
				{
					this.GameplayCueResponse = new GameplayCueResponse();
				}
				this.GameplayCueResponse.MergeFrom(other.GameplayCueResponse);
				break;
			case CombatResponseData.MessageOneofCase.EntityIsVisibleResponse:
				if (this.EntityIsVisibleResponse == null)
				{
					this.EntityIsVisibleResponse = new EntityIsVisibleResponse();
				}
				this.EntityIsVisibleResponse.MergeFrom(other.EntityIsVisibleResponse);
				break;
			case CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse:
				if (this.SwitchCharacterStateResponse == null)
				{
					this.SwitchCharacterStateResponse = new SwitchCharacterStateResponse();
				}
				this.SwitchCharacterStateResponse.MergeFrom(other.SwitchCharacterStateResponse);
				break;
			case CombatResponseData.MessageOneofCase.LogicStateInitResponse:
				if (this.LogicStateInitResponse == null)
				{
					this.LogicStateInitResponse = new LogicStateInitResponse();
				}
				this.LogicStateInitResponse.MergeFrom(other.LogicStateInitResponse);
				break;
			case CombatResponseData.MessageOneofCase.SwitchLogicStateResponse:
				if (this.SwitchLogicStateResponse == null)
				{
					this.SwitchLogicStateResponse = new SwitchLogicStateResponse();
				}
				this.SwitchLogicStateResponse.MergeFrom(other.SwitchLogicStateResponse);
				break;
			case CombatResponseData.MessageOneofCase.AnimationStateChangedResponse:
				if (this.AnimationStateChangedResponse == null)
				{
					this.AnimationStateChangedResponse = new AnimationStateChangedResponse();
				}
				this.AnimationStateChangedResponse.MergeFrom(other.AnimationStateChangedResponse);
				break;
			case CombatResponseData.MessageOneofCase.AnimationStateInitResponse:
				if (this.AnimationStateInitResponse == null)
				{
					this.AnimationStateInitResponse = new AnimationStateInitResponse();
				}
				this.AnimationStateInitResponse.MergeFrom(other.AnimationStateInitResponse);
				break;
			case CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse:
				if (this.ModifyBulletParamsResponse == null)
				{
					this.ModifyBulletParamsResponse = new ModifyBulletParamsResponse();
				}
				this.ModifyBulletParamsResponse.MergeFrom(other.ModifyBulletParamsResponse);
				break;
			case CombatResponseData.MessageOneofCase.DrownResponse:
				if (this.DrownResponse == null)
				{
					this.DrownResponse = new DrownResponse();
				}
				this.DrownResponse.MergeFrom(other.DrownResponse);
				break;
			case CombatResponseData.MessageOneofCase.OrderApplyBuffResponse:
				if (this.OrderApplyBuffResponse == null)
				{
					this.OrderApplyBuffResponse = new OrderApplyBuffResponse();
				}
				this.OrderApplyBuffResponse.MergeFrom(other.OrderApplyBuffResponse);
				break;
			case CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse:
				if (this.OrderRemoveBuffResponse == null)
				{
					this.OrderRemoveBuffResponse = new OrderRemoveBuffResponse();
				}
				this.OrderRemoveBuffResponse.MergeFrom(other.OrderRemoveBuffResponse);
				break;
			case CombatResponseData.MessageOneofCase.ActivateBuffResponse:
				if (this.ActivateBuffResponse == null)
				{
					this.ActivateBuffResponse = new ActivateBuffResponse();
				}
				this.ActivateBuffResponse.MergeFrom(other.ActivateBuffResponse);
				break;
			case CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse:
				if (this.OrderRemoveBuffByTagsResponse == null)
				{
					this.OrderRemoveBuffByTagsResponse = new OrderRemoveBuffByTagsResponse();
				}
				this.OrderRemoveBuffByTagsResponse.MergeFrom(other.OrderRemoveBuffByTagsResponse);
				break;
			case CombatResponseData.MessageOneofCase.AiInformationResponse:
				if (this.AiInformationResponse == null)
				{
					this.AiInformationResponse = new AiInformationResponse();
				}
				this.AiInformationResponse.MergeFrom(other.AiInformationResponse);
				break;
			case CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse:
				if (this.ToughCalcExtraRatioChangeResponse == null)
				{
					this.ToughCalcExtraRatioChangeResponse = new ToughCalcExtraRatioChangeResponse();
				}
				this.ToughCalcExtraRatioChangeResponse.MergeFrom(other.ToughCalcExtraRatioChangeResponse);
				break;
			case CombatResponseData.MessageOneofCase.BattleStateChangeResponse:
				if (this.BattleStateChangeResponse == null)
				{
					this.BattleStateChangeResponse = new BattleStateChangeResponse();
				}
				this.BattleStateChangeResponse.MergeFrom(other.BattleStateChangeResponse);
				break;
			case CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse:
				if (this.AnimationGameplayTagResponse == null)
				{
					this.AnimationGameplayTagResponse = new AnimationGameplayTagResponse();
				}
				this.AnimationGameplayTagResponse.MergeFrom(other.AnimationGameplayTagResponse);
				break;
			case CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse:
				if (this.BoneVisibleChangeResponse == null)
				{
					this.BoneVisibleChangeResponse = new BoneVisibleChangeResponse();
				}
				this.BoneVisibleChangeResponse.MergeFrom(other.BoneVisibleChangeResponse);
				break;
			case CombatResponseData.MessageOneofCase.AiBlackboardsResponse:
				if (this.AiBlackboardsResponse == null)
				{
					this.AiBlackboardsResponse = new AiBlackboardsResponse();
				}
				this.AiBlackboardsResponse.MergeFrom(other.AiBlackboardsResponse);
				break;
			case CombatResponseData.MessageOneofCase.AiBlackboardCdResponse:
				if (this.AiBlackboardCdResponse == null)
				{
					this.AiBlackboardCdResponse = new AiBlackboardCdResponse();
				}
				this.AiBlackboardCdResponse.MergeFrom(other.AiBlackboardCdResponse);
				break;
			case CombatResponseData.MessageOneofCase.AiHateResponse:
				if (this.AiHateResponse == null)
				{
					this.AiHateResponse = new AiHateResponse();
				}
				this.AiHateResponse.MergeFrom(other.AiHateResponse);
				break;
			case CombatResponseData.MessageOneofCase.MonsterBoomResponse:
				if (this.MonsterBoomResponse == null)
				{
					this.MonsterBoomResponse = new MonsterBoomResponse();
				}
				this.MonsterBoomResponse.MergeFrom(other.MonsterBoomResponse);
				break;
			case CombatResponseData.MessageOneofCase.CaughtResponse:
				if (this.CaughtResponse == null)
				{
					this.CaughtResponse = new CaughtResponse();
				}
				this.CaughtResponse.MergeFrom(other.CaughtResponse);
				break;
			case CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse:
				if (this.EntityStaticHookMoveResponse == null)
				{
					this.EntityStaticHookMoveResponse = new EntityStaticHookMoveResponse();
				}
				this.EntityStaticHookMoveResponse.MergeFrom(other.EntityStaticHookMoveResponse);
				break;
			case CombatResponseData.MessageOneofCase.ChangeStateResponse:
				if (this.ChangeStateResponse == null)
				{
					this.ChangeStateResponse = new ChangeStateResponse();
				}
				this.ChangeStateResponse.MergeFrom(other.ChangeStateResponse);
				break;
			case CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse:
				if (this.ChangeStateConfirmResponse == null)
				{
					this.ChangeStateConfirmResponse = new ChangeStateConfirmResponse();
				}
				this.ChangeStateConfirmResponse.MergeFrom(other.ChangeStateConfirmResponse);
				break;
			case CombatResponseData.MessageOneofCase.FsmConditionPassResponse:
				if (this.FsmConditionPassResponse == null)
				{
					this.FsmConditionPassResponse = new FsmConditionPassResponse();
				}
				this.FsmConditionPassResponse.MergeFrom(other.FsmConditionPassResponse);
				break;
			case CombatResponseData.MessageOneofCase.BuffStackCountResponse:
				if (this.BuffStackCountResponse == null)
				{
					this.BuffStackCountResponse = new BuffStackCountResponse();
				}
				this.BuffStackCountResponse.MergeFrom(other.BuffStackCountResponse);
				break;
			case CombatResponseData.MessageOneofCase.ANStartResponse:
				if (this.ANStartResponse == null)
				{
					this.ANStartResponse = new ANStartResponse();
				}
				this.ANStartResponse.MergeFrom(other.ANStartResponse);
				break;
			case CombatResponseData.MessageOneofCase.UseSkillFailResponse:
				if (this.UseSkillFailResponse == null)
				{
					this.UseSkillFailResponse = new UseSkillFailResponse();
				}
				this.UseSkillFailResponse.MergeFrom(other.UseSkillFailResponse);
				break;
			case CombatResponseData.MessageOneofCase.EnterViewDirectionResponse:
				if (this.EnterViewDirectionResponse == null)
				{
					this.EnterViewDirectionResponse = new EnterViewDirectionResponse();
				}
				this.EnterViewDirectionResponse.MergeFrom(other.EnterViewDirectionResponse);
				break;
			case CombatResponseData.MessageOneofCase.ExitViewDirectionResponse:
				if (this.ExitViewDirectionResponse == null)
				{
					this.ExitViewDirectionResponse = new ExitViewDirectionResponse();
				}
				this.ExitViewDirectionResponse.MergeFrom(other.ExitViewDirectionResponse);
				break;
			case CombatResponseData.MessageOneofCase.PassiveSkillAddResponse:
				if (this.PassiveSkillAddResponse == null)
				{
					this.PassiveSkillAddResponse = new PassiveSkillAddResponse();
				}
				this.PassiveSkillAddResponse.MergeFrom(other.PassiveSkillAddResponse);
				break;
			case CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse:
				if (this.InterruptSkillInDelayResponse == null)
				{
					this.InterruptSkillInDelayResponse = new InterruptSkillInDelayResponse();
				}
				this.InterruptSkillInDelayResponse.MergeFrom(other.InterruptSkillInDelayResponse);
				break;
			case CombatResponseData.MessageOneofCase.TriggerExitSkillResponse:
				if (this.TriggerExitSkillResponse == null)
				{
					this.TriggerExitSkillResponse = new TriggerExitSkillResponse();
				}
				this.TriggerExitSkillResponse.MergeFrom(other.TriggerExitSkillResponse);
				break;
			case CombatResponseData.MessageOneofCase.ActorVisibleResponse:
				if (this.ActorVisibleResponse == null)
				{
					this.ActorVisibleResponse = new ActorVisibleResponse();
				}
				this.ActorVisibleResponse.MergeFrom(other.ActorVisibleResponse);
				break;
			case CombatResponseData.MessageOneofCase.BuffEffectResponse:
				if (this.BuffEffectResponse == null)
				{
					this.BuffEffectResponse = new BuffEffectResponse();
				}
				this.BuffEffectResponse.MergeFrom(other.BuffEffectResponse);
				break;
			case CombatResponseData.MessageOneofCase.FragileChangeResponse:
				if (this.FragileChangeResponse == null)
				{
					this.FragileChangeResponse = new FragileChangeResponse();
				}
				this.FragileChangeResponse.MergeFrom(other.FragileChangeResponse);
				break;
			case CombatResponseData.MessageOneofCase.RTimeStopResponse:
				if (this.RTimeStopResponse == null)
				{
					this.RTimeStopResponse = new RTimeStopResponse();
				}
				this.RTimeStopResponse.MergeFrom(other.RTimeStopResponse);
				break;
			case CombatResponseData.MessageOneofCase.DrownEndTeleportResponse:
				if (this.DrownEndTeleportResponse == null)
				{
					this.DrownEndTeleportResponse = new DrownEndTeleportResponse();
				}
				this.DrownEndTeleportResponse.MergeFrom(other.DrownEndTeleportResponse);
				break;
			case CombatResponseData.MessageOneofCase.MonsterDrownResponse:
				if (this.MonsterDrownResponse == null)
				{
					this.MonsterDrownResponse = new MonsterDrownResponse();
				}
				this.MonsterDrownResponse.MergeFrom(other.MonsterDrownResponse);
				break;
			case CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse:
				if (this.PassiveSkillRemoveResponse == null)
				{
					this.PassiveSkillRemoveResponse = new PassiveSkillRemoveResponse();
				}
				this.PassiveSkillRemoveResponse.MergeFrom(other.PassiveSkillRemoveResponse);
				break;
			case CombatResponseData.MessageOneofCase.RTimeStopInstResponse:
				if (this.RTimeStopInstResponse == null)
				{
					this.RTimeStopInstResponse = new RTimeStopInstResponse();
				}
				this.RTimeStopInstResponse.MergeFrom(other.RTimeStopInstResponse);
				break;
			case CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse:
				if (this.FsmStateBehaviorResponse == null)
				{
					this.FsmStateBehaviorResponse = new FsmStateBehaviorResponse();
				}
				this.FsmStateBehaviorResponse.MergeFrom(other.FsmStateBehaviorResponse);
				break;
			case CombatResponseData.MessageOneofCase.FsmPlayMontageResponse:
				if (this.FsmPlayMontageResponse == null)
				{
					this.FsmPlayMontageResponse = new FsmPlayMontageResponse();
				}
				this.FsmPlayMontageResponse.MergeFrom(other.FsmPlayMontageResponse);
				break;
			case CombatResponseData.MessageOneofCase.RTimeStopAnimResponse:
				if (this.RTimeStopAnimResponse == null)
				{
					this.RTimeStopAnimResponse = new RTimeStopAnimResponse();
				}
				this.RTimeStopAnimResponse.MergeFrom(other.RTimeStopAnimResponse);
				break;
			case CombatResponseData.MessageOneofCase.SwitchRoleResponse:
				if (this.SwitchRoleResponse == null)
				{
					this.SwitchRoleResponse = new SwitchRoleResponse();
				}
				this.SwitchRoleResponse.MergeFrom(other.SwitchRoleResponse);
				break;
			case CombatResponseData.MessageOneofCase.GameplayTagResponse:
				if (this.GameplayTagResponse == null)
				{
					this.GameplayTagResponse = new GameplayTagResponse();
				}
				this.GameplayTagResponse.MergeFrom(other.GameplayTagResponse);
				break;
			case CombatResponseData.MessageOneofCase.ExecuteQteResponse:
				if (this.ExecuteQteResponse == null)
				{
					this.ExecuteQteResponse = new ExecuteQteResponse();
				}
				this.ExecuteQteResponse.MergeFrom(other.ExecuteQteResponse);
				break;
			case CombatResponseData.MessageOneofCase.CombineEntitiesResponse:
				if (this.CombineEntitiesResponse == null)
				{
					this.CombineEntitiesResponse = new CombineEntitiesResponse();
				}
				this.CombineEntitiesResponse.MergeFrom(other.CombineEntitiesResponse);
				break;
			case CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse:
				if (this.DissolveCombineRelationResponse == null)
				{
					this.DissolveCombineRelationResponse = new DissolveCombineRelationResponse();
				}
				this.DissolveCombineRelationResponse.MergeFrom(other.DissolveCombineRelationResponse);
				break;
			case CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse:
				if (this.ClientCurrentRoleReportResponse == null)
				{
					this.ClientCurrentRoleReportResponse = new ClientCurrentRoleReportResponse();
				}
				this.ClientCurrentRoleReportResponse.MergeFrom(other.ClientCurrentRoleReportResponse);
				break;
			case CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse:
				if (this.GaSwitchCommonEnemyProCampResponse == null)
				{
					this.GaSwitchCommonEnemyProCampResponse = new GaSwitchCommonEnemyProCampResponse();
				}
				this.GaSwitchCommonEnemyProCampResponse.MergeFrom(other.GaSwitchCommonEnemyProCampResponse);
				break;
			case CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse:
				if (this.ChangeSummonEntityStateResponse == null)
				{
					this.ChangeSummonEntityStateResponse = new ChangeSummonEntityStateResponse();
				}
				this.ChangeSummonEntityStateResponse.MergeFrom(other.ChangeSummonEntityStateResponse);
				break;
			case CombatResponseData.MessageOneofCase.CombatDataMaxResponse:
				if (this.CombatDataMaxResponse == null)
				{
					this.CombatDataMaxResponse = new CombatDataMaxResponse();
				}
				this.CombatDataMaxResponse.MergeFrom(other.CombatDataMaxResponse);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CEC1 RID: 118465 RVA: 0x0043A205 File Offset: 0x00438405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CEC2 RID: 118466 RVA: 0x0043A210 File Offset: 0x00438410
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
										CreateBulletResponse createBulletResponse = new CreateBulletResponse();
										if (this.messageCase_ == CombatResponseData.MessageOneofCase.CreateBulletResponse)
										{
											createBulletResponse.MergeFrom(this.CreateBulletResponse);
										}
										input.ReadMessage(createBulletResponse);
										this.CreateBulletResponse = createBulletResponse;
										continue;
									}
									if (num == 34U)
									{
										DestroyBulletResponse destroyBulletResponse = new DestroyBulletResponse();
										if (this.messageCase_ == CombatResponseData.MessageOneofCase.DestroyBulletResponse)
										{
											destroyBulletResponse.MergeFrom(this.DestroyBulletResponse);
										}
										input.ReadMessage(destroyBulletResponse);
										this.DestroyBulletResponse = destroyBulletResponse;
										continue;
									}
								}
							}
							else if (num <= 50U)
							{
								if (num == 42U)
								{
									DamageExecuteResponse damageExecuteResponse = new DamageExecuteResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.DamageExecuteResponse)
									{
										damageExecuteResponse.MergeFrom(this.DamageExecuteResponse);
									}
									input.ReadMessage(damageExecuteResponse);
									this.DamageExecuteResponse = damageExecuteResponse;
									continue;
								}
								if (num == 50U)
								{
									ApplyGameplayEffectResponse applyGameplayEffectResponse = new ApplyGameplayEffectResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.ApplyGameplayEffectResponse)
									{
										applyGameplayEffectResponse.MergeFrom(this.ApplyGameplayEffectResponse);
									}
									input.ReadMessage(applyGameplayEffectResponse);
									this.ApplyGameplayEffectResponse = applyGameplayEffectResponse;
									continue;
								}
							}
							else
							{
								if (num == 58U)
								{
									RemoveGameplayEffectResponse removeGameplayEffectResponse = new RemoveGameplayEffectResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.RemoveGameplayEffectResponse)
									{
										removeGameplayEffectResponse.MergeFrom(this.RemoveGameplayEffectResponse);
									}
									input.ReadMessage(removeGameplayEffectResponse);
									this.RemoveGameplayEffectResponse = removeGameplayEffectResponse;
									continue;
								}
								if (num == 66U)
								{
									HitResponse hitResponse = new HitResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitResponse)
									{
										hitResponse.MergeFrom(this.HitResponse);
									}
									input.ReadMessage(hitResponse);
									this.HitResponse = hitResponse;
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
									HitEndResponse hitEndResponse = new HitEndResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.HitEndResponse)
									{
										hitEndResponse.MergeFrom(this.HitEndResponse);
									}
									input.ReadMessage(hitEndResponse);
									this.HitEndResponse = hitEndResponse;
									continue;
								}
								if (num == 82U)
								{
									SkillResponse skillResponse = new SkillResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.SkillResponse)
									{
										skillResponse.MergeFrom(this.SkillResponse);
									}
									input.ReadMessage(skillResponse);
									this.SkillResponse = skillResponse;
									continue;
								}
							}
							else
							{
								if (num == 90U)
								{
									UseSkillResponse useSkillResponse = new UseSkillResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillResponse)
									{
										useSkillResponse.MergeFrom(this.UseSkillResponse);
									}
									input.ReadMessage(useSkillResponse);
									this.UseSkillResponse = useSkillResponse;
									continue;
								}
								if (num == 98U)
								{
									EndSkillResponse endSkillResponse = new EndSkillResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.EndSkillResponse)
									{
										endSkillResponse.MergeFrom(this.EndSkillResponse);
									}
									input.ReadMessage(endSkillResponse);
									this.EndSkillResponse = endSkillResponse;
									continue;
								}
							}
						}
						else if (num <= 114U)
						{
							if (num == 106U)
							{
								PartUpdateResponse partUpdateResponse = new PartUpdateResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.PartUpdateResponse)
								{
									partUpdateResponse.MergeFrom(this.PartUpdateResponse);
								}
								input.ReadMessage(partUpdateResponse);
								this.PartUpdateResponse = partUpdateResponse;
								continue;
							}
							if (num == 114U)
							{
								MaterialResponse materialResponse = new MaterialResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.MaterialResponse)
								{
									materialResponse.MergeFrom(this.MaterialResponse);
								}
								input.ReadMessage(materialResponse);
								this.MaterialResponse = materialResponse;
								continue;
							}
						}
						else
						{
							if (num == 122U)
							{
								GameplayCueResponse gameplayCueResponse = new GameplayCueResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayCueResponse)
								{
									gameplayCueResponse.MergeFrom(this.GameplayCueResponse);
								}
								input.ReadMessage(gameplayCueResponse);
								this.GameplayCueResponse = gameplayCueResponse;
								continue;
							}
							if (num == 130U)
							{
								EntityIsVisibleResponse entityIsVisibleResponse = new EntityIsVisibleResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityIsVisibleResponse)
								{
									entityIsVisibleResponse.MergeFrom(this.EntityIsVisibleResponse);
								}
								input.ReadMessage(entityIsVisibleResponse);
								this.EntityIsVisibleResponse = entityIsVisibleResponse;
								continue;
							}
							if (num == 138U)
							{
								SwitchCharacterStateResponse switchCharacterStateResponse = new SwitchCharacterStateResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchCharacterStateResponse)
								{
									switchCharacterStateResponse.MergeFrom(this.SwitchCharacterStateResponse);
								}
								input.ReadMessage(switchCharacterStateResponse);
								this.SwitchCharacterStateResponse = switchCharacterStateResponse;
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
									LogicStateInitResponse logicStateInitResponse = new LogicStateInitResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.LogicStateInitResponse)
									{
										logicStateInitResponse.MergeFrom(this.LogicStateInitResponse);
									}
									input.ReadMessage(logicStateInitResponse);
									this.LogicStateInitResponse = logicStateInitResponse;
									continue;
								}
								if (num == 154U)
								{
									SwitchLogicStateResponse switchLogicStateResponse = new SwitchLogicStateResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchLogicStateResponse)
									{
										switchLogicStateResponse.MergeFrom(this.SwitchLogicStateResponse);
									}
									input.ReadMessage(switchLogicStateResponse);
									this.SwitchLogicStateResponse = switchLogicStateResponse;
									continue;
								}
							}
							else
							{
								if (num == 162U)
								{
									AnimationStateChangedResponse animationStateChangedResponse = new AnimationStateChangedResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateChangedResponse)
									{
										animationStateChangedResponse.MergeFrom(this.AnimationStateChangedResponse);
									}
									input.ReadMessage(animationStateChangedResponse);
									this.AnimationStateChangedResponse = animationStateChangedResponse;
									continue;
								}
								if (num == 170U)
								{
									AnimationStateInitResponse animationStateInitResponse = new AnimationStateInitResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationStateInitResponse)
									{
										animationStateInitResponse.MergeFrom(this.AnimationStateInitResponse);
									}
									input.ReadMessage(animationStateInitResponse);
									this.AnimationStateInitResponse = animationStateInitResponse;
									continue;
								}
							}
						}
						else if (num <= 186U)
						{
							if (num == 178U)
							{
								ModifyBulletParamsResponse modifyBulletParamsResponse = new ModifyBulletParamsResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.ModifyBulletParamsResponse)
								{
									modifyBulletParamsResponse.MergeFrom(this.ModifyBulletParamsResponse);
								}
								input.ReadMessage(modifyBulletParamsResponse);
								this.ModifyBulletParamsResponse = modifyBulletParamsResponse;
								continue;
							}
							if (num == 186U)
							{
								DrownResponse drownResponse = new DrownResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownResponse)
								{
									drownResponse.MergeFrom(this.DrownResponse);
								}
								input.ReadMessage(drownResponse);
								this.DrownResponse = drownResponse;
								continue;
							}
						}
						else
						{
							if (num == 194U)
							{
								OrderApplyBuffResponse orderApplyBuffResponse = new OrderApplyBuffResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderApplyBuffResponse)
								{
									orderApplyBuffResponse.MergeFrom(this.OrderApplyBuffResponse);
								}
								input.ReadMessage(orderApplyBuffResponse);
								this.OrderApplyBuffResponse = orderApplyBuffResponse;
								continue;
							}
							if (num == 202U)
							{
								OrderRemoveBuffResponse orderRemoveBuffResponse = new OrderRemoveBuffResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffResponse)
								{
									orderRemoveBuffResponse.MergeFrom(this.OrderRemoveBuffResponse);
								}
								input.ReadMessage(orderRemoveBuffResponse);
								this.OrderRemoveBuffResponse = orderRemoveBuffResponse;
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
								ActivateBuffResponse activateBuffResponse = new ActivateBuffResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActivateBuffResponse)
								{
									activateBuffResponse.MergeFrom(this.ActivateBuffResponse);
								}
								input.ReadMessage(activateBuffResponse);
								this.ActivateBuffResponse = activateBuffResponse;
								continue;
							}
							if (num == 218U)
							{
								OrderRemoveBuffByTagsResponse orderRemoveBuffByTagsResponse = new OrderRemoveBuffByTagsResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.OrderRemoveBuffByTagsResponse)
								{
									orderRemoveBuffByTagsResponse.MergeFrom(this.OrderRemoveBuffByTagsResponse);
								}
								input.ReadMessage(orderRemoveBuffByTagsResponse);
								this.OrderRemoveBuffByTagsResponse = orderRemoveBuffByTagsResponse;
								continue;
							}
						}
						else
						{
							if (num == 226U)
							{
								AiInformationResponse aiInformationResponse = new AiInformationResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiInformationResponse)
								{
									aiInformationResponse.MergeFrom(this.AiInformationResponse);
								}
								input.ReadMessage(aiInformationResponse);
								this.AiInformationResponse = aiInformationResponse;
								continue;
							}
							if (num == 234U)
							{
								ToughCalcExtraRatioChangeResponse toughCalcExtraRatioChangeResponse = new ToughCalcExtraRatioChangeResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.ToughCalcExtraRatioChangeResponse)
								{
									toughCalcExtraRatioChangeResponse.MergeFrom(this.ToughCalcExtraRatioChangeResponse);
								}
								input.ReadMessage(toughCalcExtraRatioChangeResponse);
								this.ToughCalcExtraRatioChangeResponse = toughCalcExtraRatioChangeResponse;
								continue;
							}
						}
					}
					else if (num <= 250U)
					{
						if (num == 242U)
						{
							BattleStateChangeResponse battleStateChangeResponse = new BattleStateChangeResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.BattleStateChangeResponse)
							{
								battleStateChangeResponse.MergeFrom(this.BattleStateChangeResponse);
							}
							input.ReadMessage(battleStateChangeResponse);
							this.BattleStateChangeResponse = battleStateChangeResponse;
							continue;
						}
						if (num == 250U)
						{
							AnimationGameplayTagResponse animationGameplayTagResponse = new AnimationGameplayTagResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.AnimationGameplayTagResponse)
							{
								animationGameplayTagResponse.MergeFrom(this.AnimationGameplayTagResponse);
							}
							input.ReadMessage(animationGameplayTagResponse);
							this.AnimationGameplayTagResponse = animationGameplayTagResponse;
							continue;
						}
					}
					else
					{
						if (num == 258U)
						{
							BoneVisibleChangeResponse boneVisibleChangeResponse = new BoneVisibleChangeResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.BoneVisibleChangeResponse)
							{
								boneVisibleChangeResponse.MergeFrom(this.BoneVisibleChangeResponse);
							}
							input.ReadMessage(boneVisibleChangeResponse);
							this.BoneVisibleChangeResponse = boneVisibleChangeResponse;
							continue;
						}
						if (num == 266U)
						{
							AiBlackboardsResponse aiBlackboardsResponse = new AiBlackboardsResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardsResponse)
							{
								aiBlackboardsResponse.MergeFrom(this.AiBlackboardsResponse);
							}
							input.ReadMessage(aiBlackboardsResponse);
							this.AiBlackboardsResponse = aiBlackboardsResponse;
							continue;
						}
						if (num == 274U)
						{
							AiBlackboardCdResponse aiBlackboardCdResponse = new AiBlackboardCdResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiBlackboardCdResponse)
							{
								aiBlackboardCdResponse.MergeFrom(this.AiBlackboardCdResponse);
							}
							input.ReadMessage(aiBlackboardCdResponse);
							this.AiBlackboardCdResponse = aiBlackboardCdResponse;
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
									AiHateResponse aiHateResponse = new AiHateResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.AiHateResponse)
									{
										aiHateResponse.MergeFrom(this.AiHateResponse);
									}
									input.ReadMessage(aiHateResponse);
									this.AiHateResponse = aiHateResponse;
									continue;
								}
								if (num == 290U)
								{
									MonsterBoomResponse monsterBoomResponse = new MonsterBoomResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterBoomResponse)
									{
										monsterBoomResponse.MergeFrom(this.MonsterBoomResponse);
									}
									input.ReadMessage(monsterBoomResponse);
									this.MonsterBoomResponse = monsterBoomResponse;
									continue;
								}
							}
							else
							{
								if (num == 298U)
								{
									CaughtResponse caughtResponse = new CaughtResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.CaughtResponse)
									{
										caughtResponse.MergeFrom(this.CaughtResponse);
									}
									input.ReadMessage(caughtResponse);
									this.CaughtResponse = caughtResponse;
									continue;
								}
								if (num == 306U)
								{
									EntityStaticHookMoveResponse entityStaticHookMoveResponse = new EntityStaticHookMoveResponse();
									if (this.messageCase_ == CombatResponseData.MessageOneofCase.EntityStaticHookMoveResponse)
									{
										entityStaticHookMoveResponse.MergeFrom(this.EntityStaticHookMoveResponse);
									}
									input.ReadMessage(entityStaticHookMoveResponse);
									this.EntityStaticHookMoveResponse = entityStaticHookMoveResponse;
									continue;
								}
							}
						}
						else if (num <= 322U)
						{
							if (num == 314U)
							{
								ChangeStateResponse changeStateResponse = new ChangeStateResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateResponse)
								{
									changeStateResponse.MergeFrom(this.ChangeStateResponse);
								}
								input.ReadMessage(changeStateResponse);
								this.ChangeStateResponse = changeStateResponse;
								continue;
							}
							if (num == 322U)
							{
								ChangeStateConfirmResponse changeStateConfirmResponse = new ChangeStateConfirmResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeStateConfirmResponse)
								{
									changeStateConfirmResponse.MergeFrom(this.ChangeStateConfirmResponse);
								}
								input.ReadMessage(changeStateConfirmResponse);
								this.ChangeStateConfirmResponse = changeStateConfirmResponse;
								continue;
							}
						}
						else
						{
							if (num == 330U)
							{
								FsmConditionPassResponse fsmConditionPassResponse = new FsmConditionPassResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmConditionPassResponse)
								{
									fsmConditionPassResponse.MergeFrom(this.FsmConditionPassResponse);
								}
								input.ReadMessage(fsmConditionPassResponse);
								this.FsmConditionPassResponse = fsmConditionPassResponse;
								continue;
							}
							if (num == 338U)
							{
								BuffStackCountResponse buffStackCountResponse = new BuffStackCountResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffStackCountResponse)
								{
									buffStackCountResponse.MergeFrom(this.BuffStackCountResponse);
								}
								input.ReadMessage(buffStackCountResponse);
								this.BuffStackCountResponse = buffStackCountResponse;
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
								ANStartResponse anstartResponse = new ANStartResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.ANStartResponse)
								{
									anstartResponse.MergeFrom(this.ANStartResponse);
								}
								input.ReadMessage(anstartResponse);
								this.ANStartResponse = anstartResponse;
								continue;
							}
							if (num == 354U)
							{
								UseSkillFailResponse useSkillFailResponse = new UseSkillFailResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.UseSkillFailResponse)
								{
									useSkillFailResponse.MergeFrom(this.UseSkillFailResponse);
								}
								input.ReadMessage(useSkillFailResponse);
								this.UseSkillFailResponse = useSkillFailResponse;
								continue;
							}
						}
						else
						{
							if (num == 362U)
							{
								EnterViewDirectionResponse enterViewDirectionResponse = new EnterViewDirectionResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.EnterViewDirectionResponse)
								{
									enterViewDirectionResponse.MergeFrom(this.EnterViewDirectionResponse);
								}
								input.ReadMessage(enterViewDirectionResponse);
								this.EnterViewDirectionResponse = enterViewDirectionResponse;
								continue;
							}
							if (num == 370U)
							{
								ExitViewDirectionResponse exitViewDirectionResponse = new ExitViewDirectionResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExitViewDirectionResponse)
								{
									exitViewDirectionResponse.MergeFrom(this.ExitViewDirectionResponse);
								}
								input.ReadMessage(exitViewDirectionResponse);
								this.ExitViewDirectionResponse = exitViewDirectionResponse;
								continue;
							}
						}
					}
					else if (num <= 394U)
					{
						if (num == 378U)
						{
							PassiveSkillAddResponse passiveSkillAddResponse = new PassiveSkillAddResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillAddResponse)
							{
								passiveSkillAddResponse.MergeFrom(this.PassiveSkillAddResponse);
							}
							input.ReadMessage(passiveSkillAddResponse);
							this.PassiveSkillAddResponse = passiveSkillAddResponse;
							continue;
						}
						if (num == 394U)
						{
							InterruptSkillInDelayResponse interruptSkillInDelayResponse = new InterruptSkillInDelayResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.InterruptSkillInDelayResponse)
							{
								interruptSkillInDelayResponse.MergeFrom(this.InterruptSkillInDelayResponse);
							}
							input.ReadMessage(interruptSkillInDelayResponse);
							this.InterruptSkillInDelayResponse = interruptSkillInDelayResponse;
							continue;
						}
					}
					else
					{
						if (num == 402U)
						{
							TriggerExitSkillResponse triggerExitSkillResponse = new TriggerExitSkillResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.TriggerExitSkillResponse)
							{
								triggerExitSkillResponse.MergeFrom(this.TriggerExitSkillResponse);
							}
							input.ReadMessage(triggerExitSkillResponse);
							this.TriggerExitSkillResponse = triggerExitSkillResponse;
							continue;
						}
						if (num == 442U)
						{
							ActorVisibleResponse actorVisibleResponse = new ActorVisibleResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.ActorVisibleResponse)
							{
								actorVisibleResponse.MergeFrom(this.ActorVisibleResponse);
							}
							input.ReadMessage(actorVisibleResponse);
							this.ActorVisibleResponse = actorVisibleResponse;
							continue;
						}
						if (num == 450U)
						{
							BuffEffectResponse buffEffectResponse = new BuffEffectResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.BuffEffectResponse)
							{
								buffEffectResponse.MergeFrom(this.BuffEffectResponse);
							}
							input.ReadMessage(buffEffectResponse);
							this.BuffEffectResponse = buffEffectResponse;
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
								FragileChangeResponse fragileChangeResponse = new FragileChangeResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.FragileChangeResponse)
								{
									fragileChangeResponse.MergeFrom(this.FragileChangeResponse);
								}
								input.ReadMessage(fragileChangeResponse);
								this.FragileChangeResponse = fragileChangeResponse;
								continue;
							}
							if (num == 466U)
							{
								RTimeStopResponse rtimeStopResponse = new RTimeStopResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopResponse)
								{
									rtimeStopResponse.MergeFrom(this.RTimeStopResponse);
								}
								input.ReadMessage(rtimeStopResponse);
								this.RTimeStopResponse = rtimeStopResponse;
								continue;
							}
						}
						else
						{
							if (num == 474U)
							{
								DrownEndTeleportResponse drownEndTeleportResponse = new DrownEndTeleportResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.DrownEndTeleportResponse)
								{
									drownEndTeleportResponse.MergeFrom(this.DrownEndTeleportResponse);
								}
								input.ReadMessage(drownEndTeleportResponse);
								this.DrownEndTeleportResponse = drownEndTeleportResponse;
								continue;
							}
							if (num == 482U)
							{
								MonsterDrownResponse monsterDrownResponse = new MonsterDrownResponse();
								if (this.messageCase_ == CombatResponseData.MessageOneofCase.MonsterDrownResponse)
								{
									monsterDrownResponse.MergeFrom(this.MonsterDrownResponse);
								}
								input.ReadMessage(monsterDrownResponse);
								this.MonsterDrownResponse = monsterDrownResponse;
								continue;
							}
						}
					}
					else if (num <= 498U)
					{
						if (num == 490U)
						{
							PassiveSkillRemoveResponse passiveSkillRemoveResponse = new PassiveSkillRemoveResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.PassiveSkillRemoveResponse)
							{
								passiveSkillRemoveResponse.MergeFrom(this.PassiveSkillRemoveResponse);
							}
							input.ReadMessage(passiveSkillRemoveResponse);
							this.PassiveSkillRemoveResponse = passiveSkillRemoveResponse;
							continue;
						}
						if (num == 498U)
						{
							RTimeStopInstResponse rtimeStopInstResponse = new RTimeStopInstResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopInstResponse)
							{
								rtimeStopInstResponse.MergeFrom(this.RTimeStopInstResponse);
							}
							input.ReadMessage(rtimeStopInstResponse);
							this.RTimeStopInstResponse = rtimeStopInstResponse;
							continue;
						}
					}
					else
					{
						if (num == 506U)
						{
							FsmStateBehaviorResponse fsmStateBehaviorResponse = new FsmStateBehaviorResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmStateBehaviorResponse)
							{
								fsmStateBehaviorResponse.MergeFrom(this.FsmStateBehaviorResponse);
							}
							input.ReadMessage(fsmStateBehaviorResponse);
							this.FsmStateBehaviorResponse = fsmStateBehaviorResponse;
							continue;
						}
						if (num == 514U)
						{
							FsmPlayMontageResponse fsmPlayMontageResponse = new FsmPlayMontageResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.FsmPlayMontageResponse)
							{
								fsmPlayMontageResponse.MergeFrom(this.FsmPlayMontageResponse);
							}
							input.ReadMessage(fsmPlayMontageResponse);
							this.FsmPlayMontageResponse = fsmPlayMontageResponse;
							continue;
						}
						if (num == 522U)
						{
							RTimeStopAnimResponse rtimeStopAnimResponse = new RTimeStopAnimResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.RTimeStopAnimResponse)
							{
								rtimeStopAnimResponse.MergeFrom(this.RTimeStopAnimResponse);
							}
							input.ReadMessage(rtimeStopAnimResponse);
							this.RTimeStopAnimResponse = rtimeStopAnimResponse;
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
							SwitchRoleResponse switchRoleResponse = new SwitchRoleResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.SwitchRoleResponse)
							{
								switchRoleResponse.MergeFrom(this.SwitchRoleResponse);
							}
							input.ReadMessage(switchRoleResponse);
							this.SwitchRoleResponse = switchRoleResponse;
							continue;
						}
						if (num == 538U)
						{
							GameplayTagResponse gameplayTagResponse = new GameplayTagResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.GameplayTagResponse)
							{
								gameplayTagResponse.MergeFrom(this.GameplayTagResponse);
							}
							input.ReadMessage(gameplayTagResponse);
							this.GameplayTagResponse = gameplayTagResponse;
							continue;
						}
					}
					else
					{
						if (num == 546U)
						{
							ExecuteQteResponse executeQteResponse = new ExecuteQteResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.ExecuteQteResponse)
							{
								executeQteResponse.MergeFrom(this.ExecuteQteResponse);
							}
							input.ReadMessage(executeQteResponse);
							this.ExecuteQteResponse = executeQteResponse;
							continue;
						}
						if (num == 554U)
						{
							CombineEntitiesResponse combineEntitiesResponse = new CombineEntitiesResponse();
							if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombineEntitiesResponse)
							{
								combineEntitiesResponse.MergeFrom(this.CombineEntitiesResponse);
							}
							input.ReadMessage(combineEntitiesResponse);
							this.CombineEntitiesResponse = combineEntitiesResponse;
							continue;
						}
					}
				}
				else if (num <= 570U)
				{
					if (num == 562U)
					{
						DissolveCombineRelationResponse dissolveCombineRelationResponse = new DissolveCombineRelationResponse();
						if (this.messageCase_ == CombatResponseData.MessageOneofCase.DissolveCombineRelationResponse)
						{
							dissolveCombineRelationResponse.MergeFrom(this.DissolveCombineRelationResponse);
						}
						input.ReadMessage(dissolveCombineRelationResponse);
						this.DissolveCombineRelationResponse = dissolveCombineRelationResponse;
						continue;
					}
					if (num == 570U)
					{
						ClientCurrentRoleReportResponse clientCurrentRoleReportResponse = new ClientCurrentRoleReportResponse();
						if (this.messageCase_ == CombatResponseData.MessageOneofCase.ClientCurrentRoleReportResponse)
						{
							clientCurrentRoleReportResponse.MergeFrom(this.ClientCurrentRoleReportResponse);
						}
						input.ReadMessage(clientCurrentRoleReportResponse);
						this.ClientCurrentRoleReportResponse = clientCurrentRoleReportResponse;
						continue;
					}
				}
				else
				{
					if (num == 578U)
					{
						GaSwitchCommonEnemyProCampResponse gaSwitchCommonEnemyProCampResponse = new GaSwitchCommonEnemyProCampResponse();
						if (this.messageCase_ == CombatResponseData.MessageOneofCase.GaSwitchCommonEnemyProCampResponse)
						{
							gaSwitchCommonEnemyProCampResponse.MergeFrom(this.GaSwitchCommonEnemyProCampResponse);
						}
						input.ReadMessage(gaSwitchCommonEnemyProCampResponse);
						this.GaSwitchCommonEnemyProCampResponse = gaSwitchCommonEnemyProCampResponse;
						continue;
					}
					if (num == 586U)
					{
						ChangeSummonEntityStateResponse changeSummonEntityStateResponse = new ChangeSummonEntityStateResponse();
						if (this.messageCase_ == CombatResponseData.MessageOneofCase.ChangeSummonEntityStateResponse)
						{
							changeSummonEntityStateResponse.MergeFrom(this.ChangeSummonEntityStateResponse);
						}
						input.ReadMessage(changeSummonEntityStateResponse);
						this.ChangeSummonEntityStateResponse = changeSummonEntityStateResponse;
						continue;
					}
					if (num == 802U)
					{
						CombatDataMaxResponse combatDataMaxResponse = new CombatDataMaxResponse();
						if (this.messageCase_ == CombatResponseData.MessageOneofCase.CombatDataMaxResponse)
						{
							combatDataMaxResponse.MergeFrom(this.CombatDataMaxResponse);
						}
						input.ReadMessage(combatDataMaxResponse);
						this.CombatDataMaxResponse = combatDataMaxResponse;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C306 RID: 49926
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C307 RID: 49927
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C308 RID: 49928
		private CombatCommon combatCommon_;

		// Token: 0x0400C309 RID: 49929
		public const int RequestIdFieldNumber = 2;

		// Token: 0x0400C30A RID: 49930
		private int requestId_;

		// Token: 0x0400C30B RID: 49931
		public const int CreateBulletResponseFieldNumber = 3;

		// Token: 0x0400C30C RID: 49932
		public const int DestroyBulletResponseFieldNumber = 4;

		// Token: 0x0400C30D RID: 49933
		public const int DamageExecuteResponseFieldNumber = 5;

		// Token: 0x0400C30E RID: 49934
		public const int ApplyGameplayEffectResponseFieldNumber = 6;

		// Token: 0x0400C30F RID: 49935
		public const int RemoveGameplayEffectResponseFieldNumber = 7;

		// Token: 0x0400C310 RID: 49936
		public const int HitResponseFieldNumber = 8;

		// Token: 0x0400C311 RID: 49937
		public const int HitEndResponseFieldNumber = 9;

		// Token: 0x0400C312 RID: 49938
		public const int SkillResponseFieldNumber = 10;

		// Token: 0x0400C313 RID: 49939
		public const int UseSkillResponseFieldNumber = 11;

		// Token: 0x0400C314 RID: 49940
		public const int EndSkillResponseFieldNumber = 12;

		// Token: 0x0400C315 RID: 49941
		public const int PartUpdateResponseFieldNumber = 13;

		// Token: 0x0400C316 RID: 49942
		public const int MaterialResponseFieldNumber = 14;

		// Token: 0x0400C317 RID: 49943
		public const int GameplayCueResponseFieldNumber = 15;

		// Token: 0x0400C318 RID: 49944
		public const int EntityIsVisibleResponseFieldNumber = 16;

		// Token: 0x0400C319 RID: 49945
		public const int SwitchCharacterStateResponseFieldNumber = 17;

		// Token: 0x0400C31A RID: 49946
		public const int LogicStateInitResponseFieldNumber = 18;

		// Token: 0x0400C31B RID: 49947
		public const int SwitchLogicStateResponseFieldNumber = 19;

		// Token: 0x0400C31C RID: 49948
		public const int AnimationStateChangedResponseFieldNumber = 20;

		// Token: 0x0400C31D RID: 49949
		public const int AnimationStateInitResponseFieldNumber = 21;

		// Token: 0x0400C31E RID: 49950
		public const int ModifyBulletParamsResponseFieldNumber = 22;

		// Token: 0x0400C31F RID: 49951
		public const int DrownResponseFieldNumber = 23;

		// Token: 0x0400C320 RID: 49952
		public const int OrderApplyBuffResponseFieldNumber = 24;

		// Token: 0x0400C321 RID: 49953
		public const int OrderRemoveBuffResponseFieldNumber = 25;

		// Token: 0x0400C322 RID: 49954
		public const int ActivateBuffResponseFieldNumber = 26;

		// Token: 0x0400C323 RID: 49955
		public const int OrderRemoveBuffByTagsResponseFieldNumber = 27;

		// Token: 0x0400C324 RID: 49956
		public const int AiInformationResponseFieldNumber = 28;

		// Token: 0x0400C325 RID: 49957
		public const int ToughCalcExtraRatioChangeResponseFieldNumber = 29;

		// Token: 0x0400C326 RID: 49958
		public const int BattleStateChangeResponseFieldNumber = 30;

		// Token: 0x0400C327 RID: 49959
		public const int AnimationGameplayTagResponseFieldNumber = 31;

		// Token: 0x0400C328 RID: 49960
		public const int BoneVisibleChangeResponseFieldNumber = 32;

		// Token: 0x0400C329 RID: 49961
		public const int AiBlackboardsResponseFieldNumber = 33;

		// Token: 0x0400C32A RID: 49962
		public const int AiBlackboardCdResponseFieldNumber = 34;

		// Token: 0x0400C32B RID: 49963
		public const int AiHateResponseFieldNumber = 35;

		// Token: 0x0400C32C RID: 49964
		public const int MonsterBoomResponseFieldNumber = 36;

		// Token: 0x0400C32D RID: 49965
		public const int CaughtResponseFieldNumber = 37;

		// Token: 0x0400C32E RID: 49966
		public const int EntityStaticHookMoveResponseFieldNumber = 38;

		// Token: 0x0400C32F RID: 49967
		public const int ChangeStateResponseFieldNumber = 39;

		// Token: 0x0400C330 RID: 49968
		public const int ChangeStateConfirmResponseFieldNumber = 40;

		// Token: 0x0400C331 RID: 49969
		public const int FsmConditionPassResponseFieldNumber = 41;

		// Token: 0x0400C332 RID: 49970
		public const int BuffStackCountResponseFieldNumber = 42;

		// Token: 0x0400C333 RID: 49971
		public const int ANStartResponseFieldNumber = 43;

		// Token: 0x0400C334 RID: 49972
		public const int UseSkillFailResponseFieldNumber = 44;

		// Token: 0x0400C335 RID: 49973
		public const int EnterViewDirectionResponseFieldNumber = 45;

		// Token: 0x0400C336 RID: 49974
		public const int ExitViewDirectionResponseFieldNumber = 46;

		// Token: 0x0400C337 RID: 49975
		public const int PassiveSkillAddResponseFieldNumber = 47;

		// Token: 0x0400C338 RID: 49976
		public const int InterruptSkillInDelayResponseFieldNumber = 49;

		// Token: 0x0400C339 RID: 49977
		public const int TriggerExitSkillResponseFieldNumber = 50;

		// Token: 0x0400C33A RID: 49978
		public const int ActorVisibleResponseFieldNumber = 55;

		// Token: 0x0400C33B RID: 49979
		public const int BuffEffectResponseFieldNumber = 56;

		// Token: 0x0400C33C RID: 49980
		public const int FragileChangeResponseFieldNumber = 57;

		// Token: 0x0400C33D RID: 49981
		public const int RTimeStopResponseFieldNumber = 58;

		// Token: 0x0400C33E RID: 49982
		public const int DrownEndTeleportResponseFieldNumber = 59;

		// Token: 0x0400C33F RID: 49983
		public const int MonsterDrownResponseFieldNumber = 60;

		// Token: 0x0400C340 RID: 49984
		public const int PassiveSkillRemoveResponseFieldNumber = 61;

		// Token: 0x0400C341 RID: 49985
		public const int RTimeStopInstResponseFieldNumber = 62;

		// Token: 0x0400C342 RID: 49986
		public const int FsmStateBehaviorResponseFieldNumber = 63;

		// Token: 0x0400C343 RID: 49987
		public const int FsmPlayMontageResponseFieldNumber = 64;

		// Token: 0x0400C344 RID: 49988
		public const int RTimeStopAnimResponseFieldNumber = 65;

		// Token: 0x0400C345 RID: 49989
		public const int SwitchRoleResponseFieldNumber = 66;

		// Token: 0x0400C346 RID: 49990
		public const int GameplayTagResponseFieldNumber = 67;

		// Token: 0x0400C347 RID: 49991
		public const int ExecuteQteResponseFieldNumber = 68;

		// Token: 0x0400C348 RID: 49992
		public const int CombineEntitiesResponseFieldNumber = 69;

		// Token: 0x0400C349 RID: 49993
		public const int DissolveCombineRelationResponseFieldNumber = 70;

		// Token: 0x0400C34A RID: 49994
		public const int ClientCurrentRoleReportResponseFieldNumber = 71;

		// Token: 0x0400C34B RID: 49995
		public const int GaSwitchCommonEnemyProCampResponseFieldNumber = 72;

		// Token: 0x0400C34C RID: 49996
		public const int ChangeSummonEntityStateResponseFieldNumber = 73;

		// Token: 0x0400C34D RID: 49997
		public const int CombatDataMaxResponseFieldNumber = 100;

		// Token: 0x0400C34E RID: 49998
		private object message_;

		// Token: 0x0400C34F RID: 49999
		private CombatResponseData.MessageOneofCase messageCase_;

		// Token: 0x02001A02 RID: 6658
		public enum MessageOneofCase
		{
			// Token: 0x0400CBD0 RID: 52176
			None,
			// Token: 0x0400CBD1 RID: 52177
			CreateBulletResponse = 3,
			// Token: 0x0400CBD2 RID: 52178
			DestroyBulletResponse,
			// Token: 0x0400CBD3 RID: 52179
			DamageExecuteResponse,
			// Token: 0x0400CBD4 RID: 52180
			ApplyGameplayEffectResponse,
			// Token: 0x0400CBD5 RID: 52181
			RemoveGameplayEffectResponse,
			// Token: 0x0400CBD6 RID: 52182
			HitResponse,
			// Token: 0x0400CBD7 RID: 52183
			HitEndResponse,
			// Token: 0x0400CBD8 RID: 52184
			SkillResponse,
			// Token: 0x0400CBD9 RID: 52185
			UseSkillResponse,
			// Token: 0x0400CBDA RID: 52186
			EndSkillResponse,
			// Token: 0x0400CBDB RID: 52187
			PartUpdateResponse,
			// Token: 0x0400CBDC RID: 52188
			MaterialResponse,
			// Token: 0x0400CBDD RID: 52189
			GameplayCueResponse,
			// Token: 0x0400CBDE RID: 52190
			EntityIsVisibleResponse,
			// Token: 0x0400CBDF RID: 52191
			SwitchCharacterStateResponse,
			// Token: 0x0400CBE0 RID: 52192
			LogicStateInitResponse,
			// Token: 0x0400CBE1 RID: 52193
			SwitchLogicStateResponse,
			// Token: 0x0400CBE2 RID: 52194
			AnimationStateChangedResponse,
			// Token: 0x0400CBE3 RID: 52195
			AnimationStateInitResponse,
			// Token: 0x0400CBE4 RID: 52196
			ModifyBulletParamsResponse,
			// Token: 0x0400CBE5 RID: 52197
			DrownResponse,
			// Token: 0x0400CBE6 RID: 52198
			OrderApplyBuffResponse,
			// Token: 0x0400CBE7 RID: 52199
			OrderRemoveBuffResponse,
			// Token: 0x0400CBE8 RID: 52200
			ActivateBuffResponse,
			// Token: 0x0400CBE9 RID: 52201
			OrderRemoveBuffByTagsResponse,
			// Token: 0x0400CBEA RID: 52202
			AiInformationResponse,
			// Token: 0x0400CBEB RID: 52203
			ToughCalcExtraRatioChangeResponse,
			// Token: 0x0400CBEC RID: 52204
			BattleStateChangeResponse,
			// Token: 0x0400CBED RID: 52205
			AnimationGameplayTagResponse,
			// Token: 0x0400CBEE RID: 52206
			BoneVisibleChangeResponse,
			// Token: 0x0400CBEF RID: 52207
			AiBlackboardsResponse,
			// Token: 0x0400CBF0 RID: 52208
			AiBlackboardCdResponse,
			// Token: 0x0400CBF1 RID: 52209
			AiHateResponse,
			// Token: 0x0400CBF2 RID: 52210
			MonsterBoomResponse,
			// Token: 0x0400CBF3 RID: 52211
			CaughtResponse,
			// Token: 0x0400CBF4 RID: 52212
			EntityStaticHookMoveResponse,
			// Token: 0x0400CBF5 RID: 52213
			ChangeStateResponse,
			// Token: 0x0400CBF6 RID: 52214
			ChangeStateConfirmResponse,
			// Token: 0x0400CBF7 RID: 52215
			FsmConditionPassResponse,
			// Token: 0x0400CBF8 RID: 52216
			BuffStackCountResponse,
			// Token: 0x0400CBF9 RID: 52217
			ANStartResponse,
			// Token: 0x0400CBFA RID: 52218
			UseSkillFailResponse,
			// Token: 0x0400CBFB RID: 52219
			EnterViewDirectionResponse,
			// Token: 0x0400CBFC RID: 52220
			ExitViewDirectionResponse,
			// Token: 0x0400CBFD RID: 52221
			PassiveSkillAddResponse,
			// Token: 0x0400CBFE RID: 52222
			InterruptSkillInDelayResponse = 49,
			// Token: 0x0400CBFF RID: 52223
			TriggerExitSkillResponse,
			// Token: 0x0400CC00 RID: 52224
			ActorVisibleResponse = 55,
			// Token: 0x0400CC01 RID: 52225
			BuffEffectResponse,
			// Token: 0x0400CC02 RID: 52226
			FragileChangeResponse,
			// Token: 0x0400CC03 RID: 52227
			RTimeStopResponse,
			// Token: 0x0400CC04 RID: 52228
			DrownEndTeleportResponse,
			// Token: 0x0400CC05 RID: 52229
			MonsterDrownResponse,
			// Token: 0x0400CC06 RID: 52230
			PassiveSkillRemoveResponse,
			// Token: 0x0400CC07 RID: 52231
			RTimeStopInstResponse,
			// Token: 0x0400CC08 RID: 52232
			FsmStateBehaviorResponse,
			// Token: 0x0400CC09 RID: 52233
			FsmPlayMontageResponse,
			// Token: 0x0400CC0A RID: 52234
			RTimeStopAnimResponse,
			// Token: 0x0400CC0B RID: 52235
			SwitchRoleResponse,
			// Token: 0x0400CC0C RID: 52236
			GameplayTagResponse,
			// Token: 0x0400CC0D RID: 52237
			ExecuteQteResponse,
			// Token: 0x0400CC0E RID: 52238
			CombineEntitiesResponse,
			// Token: 0x0400CC0F RID: 52239
			DissolveCombineRelationResponse,
			// Token: 0x0400CC10 RID: 52240
			ClientCurrentRoleReportResponse,
			// Token: 0x0400CC11 RID: 52241
			GaSwitchCommonEnemyProCampResponse,
			// Token: 0x0400CC12 RID: 52242
			ChangeSummonEntityStateResponse,
			// Token: 0x0400CC13 RID: 52243
			CombatDataMaxResponse = 100
		}
	}
}
