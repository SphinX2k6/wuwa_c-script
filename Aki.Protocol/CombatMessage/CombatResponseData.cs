using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001708 RID: 5896
	public sealed class CombatResponseData : IMessage<CombatResponseData>, IMessage, IEquatable<CombatResponseData>, IDeepCloneable<CombatResponseData>, IBufferMessage
	{
		// Token: 0x0601D8F2 RID: 121074 RVA: 0x00451FBF File Offset: 0x004501BF
		[NullableContext(1)]
		public static CombatResponseData Create()
		{
			return new CombatResponseData();
		}

		// Token: 0x17006471 RID: 25713
		// (get) Token: 0x0601D8F3 RID: 121075 RVA: 0x00451FC6 File Offset: 0x004501C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006472 RID: 25714
		// (get) Token: 0x0601D8F4 RID: 121076 RVA: 0x00451FC9 File Offset: 0x004501C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatResponseData.Descriptor;
			}
		}

		// Token: 0x0601D8F5 RID: 121077 RVA: 0x00451FD0 File Offset: 0x004501D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData()
		{
		}

		// Token: 0x0601D8F6 RID: 121078 RVA: 0x00451FD8 File Offset: 0x004501D8
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

		// Token: 0x0601D8F7 RID: 121079 RVA: 0x0045276B File Offset: 0x0045096B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData Clone()
		{
			return new CombatResponseData(this);
		}

		// Token: 0x17006473 RID: 25715
		// (get) Token: 0x0601D8F8 RID: 121080 RVA: 0x00452773 File Offset: 0x00450973
		// (set) Token: 0x0601D8F9 RID: 121081 RVA: 0x0045277B File Offset: 0x0045097B
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

		// Token: 0x17006474 RID: 25716
		// (get) Token: 0x0601D8FA RID: 121082 RVA: 0x00452784 File Offset: 0x00450984
		// (set) Token: 0x0601D8FB RID: 121083 RVA: 0x0045278C File Offset: 0x0045098C
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

		// Token: 0x17006475 RID: 25717
		// (get) Token: 0x0601D8FC RID: 121084 RVA: 0x00452795 File Offset: 0x00450995
		// (set) Token: 0x0601D8FD RID: 121085 RVA: 0x004527AD File Offset: 0x004509AD
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

		// Token: 0x17006476 RID: 25718
		// (get) Token: 0x0601D8FE RID: 121086 RVA: 0x004527C3 File Offset: 0x004509C3
		// (set) Token: 0x0601D8FF RID: 121087 RVA: 0x004527DB File Offset: 0x004509DB
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

		// Token: 0x17006477 RID: 25719
		// (get) Token: 0x0601D900 RID: 121088 RVA: 0x004527F1 File Offset: 0x004509F1
		// (set) Token: 0x0601D901 RID: 121089 RVA: 0x00452809 File Offset: 0x00450A09
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

		// Token: 0x17006478 RID: 25720
		// (get) Token: 0x0601D902 RID: 121090 RVA: 0x0045281F File Offset: 0x00450A1F
		// (set) Token: 0x0601D903 RID: 121091 RVA: 0x00452837 File Offset: 0x00450A37
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

		// Token: 0x17006479 RID: 25721
		// (get) Token: 0x0601D904 RID: 121092 RVA: 0x0045284D File Offset: 0x00450A4D
		// (set) Token: 0x0601D905 RID: 121093 RVA: 0x00452865 File Offset: 0x00450A65
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

		// Token: 0x1700647A RID: 25722
		// (get) Token: 0x0601D906 RID: 121094 RVA: 0x0045287B File Offset: 0x00450A7B
		// (set) Token: 0x0601D907 RID: 121095 RVA: 0x00452893 File Offset: 0x00450A93
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

		// Token: 0x1700647B RID: 25723
		// (get) Token: 0x0601D908 RID: 121096 RVA: 0x004528A9 File Offset: 0x00450AA9
		// (set) Token: 0x0601D909 RID: 121097 RVA: 0x004528C2 File Offset: 0x00450AC2
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

		// Token: 0x1700647C RID: 25724
		// (get) Token: 0x0601D90A RID: 121098 RVA: 0x004528D9 File Offset: 0x00450AD9
		// (set) Token: 0x0601D90B RID: 121099 RVA: 0x004528F2 File Offset: 0x00450AF2
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

		// Token: 0x1700647D RID: 25725
		// (get) Token: 0x0601D90C RID: 121100 RVA: 0x00452909 File Offset: 0x00450B09
		// (set) Token: 0x0601D90D RID: 121101 RVA: 0x00452922 File Offset: 0x00450B22
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

		// Token: 0x1700647E RID: 25726
		// (get) Token: 0x0601D90E RID: 121102 RVA: 0x00452939 File Offset: 0x00450B39
		// (set) Token: 0x0601D90F RID: 121103 RVA: 0x00452952 File Offset: 0x00450B52
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

		// Token: 0x1700647F RID: 25727
		// (get) Token: 0x0601D910 RID: 121104 RVA: 0x00452969 File Offset: 0x00450B69
		// (set) Token: 0x0601D911 RID: 121105 RVA: 0x00452982 File Offset: 0x00450B82
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

		// Token: 0x17006480 RID: 25728
		// (get) Token: 0x0601D912 RID: 121106 RVA: 0x00452999 File Offset: 0x00450B99
		// (set) Token: 0x0601D913 RID: 121107 RVA: 0x004529B2 File Offset: 0x00450BB2
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

		// Token: 0x17006481 RID: 25729
		// (get) Token: 0x0601D914 RID: 121108 RVA: 0x004529C9 File Offset: 0x00450BC9
		// (set) Token: 0x0601D915 RID: 121109 RVA: 0x004529E2 File Offset: 0x00450BE2
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

		// Token: 0x17006482 RID: 25730
		// (get) Token: 0x0601D916 RID: 121110 RVA: 0x004529F9 File Offset: 0x00450BF9
		// (set) Token: 0x0601D917 RID: 121111 RVA: 0x00452A12 File Offset: 0x00450C12
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

		// Token: 0x17006483 RID: 25731
		// (get) Token: 0x0601D918 RID: 121112 RVA: 0x00452A29 File Offset: 0x00450C29
		// (set) Token: 0x0601D919 RID: 121113 RVA: 0x00452A42 File Offset: 0x00450C42
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

		// Token: 0x17006484 RID: 25732
		// (get) Token: 0x0601D91A RID: 121114 RVA: 0x00452A59 File Offset: 0x00450C59
		// (set) Token: 0x0601D91B RID: 121115 RVA: 0x00452A72 File Offset: 0x00450C72
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

		// Token: 0x17006485 RID: 25733
		// (get) Token: 0x0601D91C RID: 121116 RVA: 0x00452A89 File Offset: 0x00450C89
		// (set) Token: 0x0601D91D RID: 121117 RVA: 0x00452AA2 File Offset: 0x00450CA2
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

		// Token: 0x17006486 RID: 25734
		// (get) Token: 0x0601D91E RID: 121118 RVA: 0x00452AB9 File Offset: 0x00450CB9
		// (set) Token: 0x0601D91F RID: 121119 RVA: 0x00452AD2 File Offset: 0x00450CD2
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

		// Token: 0x17006487 RID: 25735
		// (get) Token: 0x0601D920 RID: 121120 RVA: 0x00452AE9 File Offset: 0x00450CE9
		// (set) Token: 0x0601D921 RID: 121121 RVA: 0x00452B02 File Offset: 0x00450D02
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

		// Token: 0x17006488 RID: 25736
		// (get) Token: 0x0601D922 RID: 121122 RVA: 0x00452B19 File Offset: 0x00450D19
		// (set) Token: 0x0601D923 RID: 121123 RVA: 0x00452B32 File Offset: 0x00450D32
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

		// Token: 0x17006489 RID: 25737
		// (get) Token: 0x0601D924 RID: 121124 RVA: 0x00452B49 File Offset: 0x00450D49
		// (set) Token: 0x0601D925 RID: 121125 RVA: 0x00452B62 File Offset: 0x00450D62
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

		// Token: 0x1700648A RID: 25738
		// (get) Token: 0x0601D926 RID: 121126 RVA: 0x00452B79 File Offset: 0x00450D79
		// (set) Token: 0x0601D927 RID: 121127 RVA: 0x00452B92 File Offset: 0x00450D92
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

		// Token: 0x1700648B RID: 25739
		// (get) Token: 0x0601D928 RID: 121128 RVA: 0x00452BA9 File Offset: 0x00450DA9
		// (set) Token: 0x0601D929 RID: 121129 RVA: 0x00452BC2 File Offset: 0x00450DC2
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

		// Token: 0x1700648C RID: 25740
		// (get) Token: 0x0601D92A RID: 121130 RVA: 0x00452BD9 File Offset: 0x00450DD9
		// (set) Token: 0x0601D92B RID: 121131 RVA: 0x00452BF2 File Offset: 0x00450DF2
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

		// Token: 0x1700648D RID: 25741
		// (get) Token: 0x0601D92C RID: 121132 RVA: 0x00452C09 File Offset: 0x00450E09
		// (set) Token: 0x0601D92D RID: 121133 RVA: 0x00452C22 File Offset: 0x00450E22
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

		// Token: 0x1700648E RID: 25742
		// (get) Token: 0x0601D92E RID: 121134 RVA: 0x00452C39 File Offset: 0x00450E39
		// (set) Token: 0x0601D92F RID: 121135 RVA: 0x00452C52 File Offset: 0x00450E52
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

		// Token: 0x1700648F RID: 25743
		// (get) Token: 0x0601D930 RID: 121136 RVA: 0x00452C69 File Offset: 0x00450E69
		// (set) Token: 0x0601D931 RID: 121137 RVA: 0x00452C82 File Offset: 0x00450E82
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

		// Token: 0x17006490 RID: 25744
		// (get) Token: 0x0601D932 RID: 121138 RVA: 0x00452C99 File Offset: 0x00450E99
		// (set) Token: 0x0601D933 RID: 121139 RVA: 0x00452CB2 File Offset: 0x00450EB2
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

		// Token: 0x17006491 RID: 25745
		// (get) Token: 0x0601D934 RID: 121140 RVA: 0x00452CC9 File Offset: 0x00450EC9
		// (set) Token: 0x0601D935 RID: 121141 RVA: 0x00452CE2 File Offset: 0x00450EE2
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

		// Token: 0x17006492 RID: 25746
		// (get) Token: 0x0601D936 RID: 121142 RVA: 0x00452CF9 File Offset: 0x00450EF9
		// (set) Token: 0x0601D937 RID: 121143 RVA: 0x00452D12 File Offset: 0x00450F12
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

		// Token: 0x17006493 RID: 25747
		// (get) Token: 0x0601D938 RID: 121144 RVA: 0x00452D29 File Offset: 0x00450F29
		// (set) Token: 0x0601D939 RID: 121145 RVA: 0x00452D42 File Offset: 0x00450F42
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

		// Token: 0x17006494 RID: 25748
		// (get) Token: 0x0601D93A RID: 121146 RVA: 0x00452D59 File Offset: 0x00450F59
		// (set) Token: 0x0601D93B RID: 121147 RVA: 0x00452D72 File Offset: 0x00450F72
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

		// Token: 0x17006495 RID: 25749
		// (get) Token: 0x0601D93C RID: 121148 RVA: 0x00452D89 File Offset: 0x00450F89
		// (set) Token: 0x0601D93D RID: 121149 RVA: 0x00452DA2 File Offset: 0x00450FA2
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

		// Token: 0x17006496 RID: 25750
		// (get) Token: 0x0601D93E RID: 121150 RVA: 0x00452DB9 File Offset: 0x00450FB9
		// (set) Token: 0x0601D93F RID: 121151 RVA: 0x00452DD2 File Offset: 0x00450FD2
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

		// Token: 0x17006497 RID: 25751
		// (get) Token: 0x0601D940 RID: 121152 RVA: 0x00452DE9 File Offset: 0x00450FE9
		// (set) Token: 0x0601D941 RID: 121153 RVA: 0x00452E02 File Offset: 0x00451002
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

		// Token: 0x17006498 RID: 25752
		// (get) Token: 0x0601D942 RID: 121154 RVA: 0x00452E19 File Offset: 0x00451019
		// (set) Token: 0x0601D943 RID: 121155 RVA: 0x00452E32 File Offset: 0x00451032
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

		// Token: 0x17006499 RID: 25753
		// (get) Token: 0x0601D944 RID: 121156 RVA: 0x00452E49 File Offset: 0x00451049
		// (set) Token: 0x0601D945 RID: 121157 RVA: 0x00452E62 File Offset: 0x00451062
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

		// Token: 0x1700649A RID: 25754
		// (get) Token: 0x0601D946 RID: 121158 RVA: 0x00452E79 File Offset: 0x00451079
		// (set) Token: 0x0601D947 RID: 121159 RVA: 0x00452E92 File Offset: 0x00451092
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

		// Token: 0x1700649B RID: 25755
		// (get) Token: 0x0601D948 RID: 121160 RVA: 0x00452EA9 File Offset: 0x004510A9
		// (set) Token: 0x0601D949 RID: 121161 RVA: 0x00452EC2 File Offset: 0x004510C2
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

		// Token: 0x1700649C RID: 25756
		// (get) Token: 0x0601D94A RID: 121162 RVA: 0x00452ED9 File Offset: 0x004510D9
		// (set) Token: 0x0601D94B RID: 121163 RVA: 0x00452EF2 File Offset: 0x004510F2
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

		// Token: 0x1700649D RID: 25757
		// (get) Token: 0x0601D94C RID: 121164 RVA: 0x00452F09 File Offset: 0x00451109
		// (set) Token: 0x0601D94D RID: 121165 RVA: 0x00452F22 File Offset: 0x00451122
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

		// Token: 0x1700649E RID: 25758
		// (get) Token: 0x0601D94E RID: 121166 RVA: 0x00452F39 File Offset: 0x00451139
		// (set) Token: 0x0601D94F RID: 121167 RVA: 0x00452F52 File Offset: 0x00451152
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

		// Token: 0x1700649F RID: 25759
		// (get) Token: 0x0601D950 RID: 121168 RVA: 0x00452F69 File Offset: 0x00451169
		// (set) Token: 0x0601D951 RID: 121169 RVA: 0x00452F82 File Offset: 0x00451182
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

		// Token: 0x170064A0 RID: 25760
		// (get) Token: 0x0601D952 RID: 121170 RVA: 0x00452F99 File Offset: 0x00451199
		// (set) Token: 0x0601D953 RID: 121171 RVA: 0x00452FB2 File Offset: 0x004511B2
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

		// Token: 0x170064A1 RID: 25761
		// (get) Token: 0x0601D954 RID: 121172 RVA: 0x00452FC9 File Offset: 0x004511C9
		// (set) Token: 0x0601D955 RID: 121173 RVA: 0x00452FE2 File Offset: 0x004511E2
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

		// Token: 0x170064A2 RID: 25762
		// (get) Token: 0x0601D956 RID: 121174 RVA: 0x00452FF9 File Offset: 0x004511F9
		// (set) Token: 0x0601D957 RID: 121175 RVA: 0x00453012 File Offset: 0x00451212
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

		// Token: 0x170064A3 RID: 25763
		// (get) Token: 0x0601D958 RID: 121176 RVA: 0x00453029 File Offset: 0x00451229
		// (set) Token: 0x0601D959 RID: 121177 RVA: 0x00453042 File Offset: 0x00451242
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

		// Token: 0x170064A4 RID: 25764
		// (get) Token: 0x0601D95A RID: 121178 RVA: 0x00453059 File Offset: 0x00451259
		// (set) Token: 0x0601D95B RID: 121179 RVA: 0x00453072 File Offset: 0x00451272
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

		// Token: 0x170064A5 RID: 25765
		// (get) Token: 0x0601D95C RID: 121180 RVA: 0x00453089 File Offset: 0x00451289
		// (set) Token: 0x0601D95D RID: 121181 RVA: 0x004530A2 File Offset: 0x004512A2
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

		// Token: 0x170064A6 RID: 25766
		// (get) Token: 0x0601D95E RID: 121182 RVA: 0x004530B9 File Offset: 0x004512B9
		// (set) Token: 0x0601D95F RID: 121183 RVA: 0x004530D2 File Offset: 0x004512D2
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

		// Token: 0x170064A7 RID: 25767
		// (get) Token: 0x0601D960 RID: 121184 RVA: 0x004530E9 File Offset: 0x004512E9
		// (set) Token: 0x0601D961 RID: 121185 RVA: 0x00453102 File Offset: 0x00451302
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

		// Token: 0x170064A8 RID: 25768
		// (get) Token: 0x0601D962 RID: 121186 RVA: 0x00453119 File Offset: 0x00451319
		// (set) Token: 0x0601D963 RID: 121187 RVA: 0x00453132 File Offset: 0x00451332
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

		// Token: 0x170064A9 RID: 25769
		// (get) Token: 0x0601D964 RID: 121188 RVA: 0x00453149 File Offset: 0x00451349
		// (set) Token: 0x0601D965 RID: 121189 RVA: 0x00453162 File Offset: 0x00451362
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

		// Token: 0x170064AA RID: 25770
		// (get) Token: 0x0601D966 RID: 121190 RVA: 0x00453179 File Offset: 0x00451379
		// (set) Token: 0x0601D967 RID: 121191 RVA: 0x00453192 File Offset: 0x00451392
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

		// Token: 0x170064AB RID: 25771
		// (get) Token: 0x0601D968 RID: 121192 RVA: 0x004531A9 File Offset: 0x004513A9
		// (set) Token: 0x0601D969 RID: 121193 RVA: 0x004531C2 File Offset: 0x004513C2
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

		// Token: 0x170064AC RID: 25772
		// (get) Token: 0x0601D96A RID: 121194 RVA: 0x004531D9 File Offset: 0x004513D9
		// (set) Token: 0x0601D96B RID: 121195 RVA: 0x004531F2 File Offset: 0x004513F2
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

		// Token: 0x170064AD RID: 25773
		// (get) Token: 0x0601D96C RID: 121196 RVA: 0x00453209 File Offset: 0x00451409
		// (set) Token: 0x0601D96D RID: 121197 RVA: 0x00453222 File Offset: 0x00451422
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

		// Token: 0x170064AE RID: 25774
		// (get) Token: 0x0601D96E RID: 121198 RVA: 0x00453239 File Offset: 0x00451439
		// (set) Token: 0x0601D96F RID: 121199 RVA: 0x00453252 File Offset: 0x00451452
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

		// Token: 0x170064AF RID: 25775
		// (get) Token: 0x0601D970 RID: 121200 RVA: 0x00453269 File Offset: 0x00451469
		// (set) Token: 0x0601D971 RID: 121201 RVA: 0x00453282 File Offset: 0x00451482
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

		// Token: 0x170064B0 RID: 25776
		// (get) Token: 0x0601D972 RID: 121202 RVA: 0x00453299 File Offset: 0x00451499
		// (set) Token: 0x0601D973 RID: 121203 RVA: 0x004532B2 File Offset: 0x004514B2
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

		// Token: 0x170064B1 RID: 25777
		// (get) Token: 0x0601D974 RID: 121204 RVA: 0x004532C9 File Offset: 0x004514C9
		// (set) Token: 0x0601D975 RID: 121205 RVA: 0x004532E2 File Offset: 0x004514E2
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

		// Token: 0x170064B2 RID: 25778
		// (get) Token: 0x0601D976 RID: 121206 RVA: 0x004532F9 File Offset: 0x004514F9
		// (set) Token: 0x0601D977 RID: 121207 RVA: 0x00453312 File Offset: 0x00451512
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

		// Token: 0x170064B3 RID: 25779
		// (get) Token: 0x0601D978 RID: 121208 RVA: 0x00453329 File Offset: 0x00451529
		// (set) Token: 0x0601D979 RID: 121209 RVA: 0x00453342 File Offset: 0x00451542
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

		// Token: 0x170064B4 RID: 25780
		// (get) Token: 0x0601D97A RID: 121210 RVA: 0x00453359 File Offset: 0x00451559
		// (set) Token: 0x0601D97B RID: 121211 RVA: 0x00453372 File Offset: 0x00451572
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

		// Token: 0x170064B5 RID: 25781
		// (get) Token: 0x0601D97C RID: 121212 RVA: 0x00453389 File Offset: 0x00451589
		// (set) Token: 0x0601D97D RID: 121213 RVA: 0x004533A2 File Offset: 0x004515A2
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

		// Token: 0x170064B6 RID: 25782
		// (get) Token: 0x0601D97E RID: 121214 RVA: 0x004533B9 File Offset: 0x004515B9
		// (set) Token: 0x0601D97F RID: 121215 RVA: 0x004533D2 File Offset: 0x004515D2
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

		// Token: 0x170064B7 RID: 25783
		// (get) Token: 0x0601D980 RID: 121216 RVA: 0x004533E9 File Offset: 0x004515E9
		// (set) Token: 0x0601D981 RID: 121217 RVA: 0x00453402 File Offset: 0x00451602
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

		// Token: 0x170064B8 RID: 25784
		// (get) Token: 0x0601D982 RID: 121218 RVA: 0x00453419 File Offset: 0x00451619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601D983 RID: 121219 RVA: 0x00453421 File Offset: 0x00451621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatResponseData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601D984 RID: 121220 RVA: 0x00453431 File Offset: 0x00451631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatResponseData);
		}

		// Token: 0x0601D985 RID: 121221 RVA: 0x00453440 File Offset: 0x00451640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatResponseData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.RequestId == other.RequestId && object.Equals(this.CreateBulletResponse, other.CreateBulletResponse) && object.Equals(this.DestroyBulletResponse, other.DestroyBulletResponse) && object.Equals(this.DamageExecuteResponse, other.DamageExecuteResponse) && object.Equals(this.ApplyGameplayEffectResponse, other.ApplyGameplayEffectResponse) && object.Equals(this.RemoveGameplayEffectResponse, other.RemoveGameplayEffectResponse) && object.Equals(this.HitResponse, other.HitResponse) && object.Equals(this.HitEndResponse, other.HitEndResponse) && object.Equals(this.SkillResponse, other.SkillResponse) && object.Equals(this.UseSkillResponse, other.UseSkillResponse) && object.Equals(this.EndSkillResponse, other.EndSkillResponse) && object.Equals(this.PartUpdateResponse, other.PartUpdateResponse) && object.Equals(this.MaterialResponse, other.MaterialResponse) && object.Equals(this.GameplayCueResponse, other.GameplayCueResponse) && object.Equals(this.EntityIsVisibleResponse, other.EntityIsVisibleResponse) && object.Equals(this.SwitchCharacterStateResponse, other.SwitchCharacterStateResponse) && object.Equals(this.LogicStateInitResponse, other.LogicStateInitResponse) && object.Equals(this.SwitchLogicStateResponse, other.SwitchLogicStateResponse) && object.Equals(this.AnimationStateChangedResponse, other.AnimationStateChangedResponse) && object.Equals(this.AnimationStateInitResponse, other.AnimationStateInitResponse) && object.Equals(this.ModifyBulletParamsResponse, other.ModifyBulletParamsResponse) && object.Equals(this.DrownResponse, other.DrownResponse) && object.Equals(this.OrderApplyBuffResponse, other.OrderApplyBuffResponse) && object.Equals(this.OrderRemoveBuffResponse, other.OrderRemoveBuffResponse) && object.Equals(this.ActivateBuffResponse, other.ActivateBuffResponse) && object.Equals(this.OrderRemoveBuffByTagsResponse, other.OrderRemoveBuffByTagsResponse) && object.Equals(this.AiInformationResponse, other.AiInformationResponse) && object.Equals(this.ToughCalcExtraRatioChangeResponse, other.ToughCalcExtraRatioChangeResponse) && object.Equals(this.BattleStateChangeResponse, other.BattleStateChangeResponse) && object.Equals(this.AnimationGameplayTagResponse, other.AnimationGameplayTagResponse) && object.Equals(this.BoneVisibleChangeResponse, other.BoneVisibleChangeResponse) && object.Equals(this.AiBlackboardsResponse, other.AiBlackboardsResponse) && object.Equals(this.AiBlackboardCdResponse, other.AiBlackboardCdResponse) && object.Equals(this.AiHateResponse, other.AiHateResponse) && object.Equals(this.MonsterBoomResponse, other.MonsterBoomResponse) && object.Equals(this.CaughtResponse, other.CaughtResponse) && object.Equals(this.EntityStaticHookMoveResponse, other.EntityStaticHookMoveResponse) && object.Equals(this.ChangeStateResponse, other.ChangeStateResponse) && object.Equals(this.ChangeStateConfirmResponse, other.ChangeStateConfirmResponse) && object.Equals(this.FsmConditionPassResponse, other.FsmConditionPassResponse) && object.Equals(this.BuffStackCountResponse, other.BuffStackCountResponse) && object.Equals(this.ANStartResponse, other.ANStartResponse) && object.Equals(this.UseSkillFailResponse, other.UseSkillFailResponse) && object.Equals(this.EnterViewDirectionResponse, other.EnterViewDirectionResponse) && object.Equals(this.ExitViewDirectionResponse, other.ExitViewDirectionResponse) && object.Equals(this.PassiveSkillAddResponse, other.PassiveSkillAddResponse) && object.Equals(this.InterruptSkillInDelayResponse, other.InterruptSkillInDelayResponse) && object.Equals(this.TriggerExitSkillResponse, other.TriggerExitSkillResponse) && object.Equals(this.ActorVisibleResponse, other.ActorVisibleResponse) && object.Equals(this.BuffEffectResponse, other.BuffEffectResponse) && object.Equals(this.FragileChangeResponse, other.FragileChangeResponse) && object.Equals(this.RTimeStopResponse, other.RTimeStopResponse) && object.Equals(this.DrownEndTeleportResponse, other.DrownEndTeleportResponse) && object.Equals(this.MonsterDrownResponse, other.MonsterDrownResponse) && object.Equals(this.PassiveSkillRemoveResponse, other.PassiveSkillRemoveResponse) && object.Equals(this.RTimeStopInstResponse, other.RTimeStopInstResponse) && object.Equals(this.FsmStateBehaviorResponse, other.FsmStateBehaviorResponse) && object.Equals(this.FsmPlayMontageResponse, other.FsmPlayMontageResponse) && object.Equals(this.RTimeStopAnimResponse, other.RTimeStopAnimResponse) && object.Equals(this.SwitchRoleResponse, other.SwitchRoleResponse) && object.Equals(this.GameplayTagResponse, other.GameplayTagResponse) && object.Equals(this.ExecuteQteResponse, other.ExecuteQteResponse) && object.Equals(this.CombineEntitiesResponse, other.CombineEntitiesResponse) && object.Equals(this.DissolveCombineRelationResponse, other.DissolveCombineRelationResponse) && object.Equals(this.ClientCurrentRoleReportResponse, other.ClientCurrentRoleReportResponse) && object.Equals(this.GaSwitchCommonEnemyProCampResponse, other.GaSwitchCommonEnemyProCampResponse) && object.Equals(this.ChangeSummonEntityStateResponse, other.ChangeSummonEntityStateResponse) && object.Equals(this.CombatDataMaxResponse, other.CombatDataMaxResponse) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D986 RID: 121222 RVA: 0x00453A20 File Offset: 0x00451C20
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

		// Token: 0x0601D987 RID: 121223 RVA: 0x004540C0 File Offset: 0x004522C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D988 RID: 121224 RVA: 0x004540CD File Offset: 0x004522CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D989 RID: 121225 RVA: 0x004540D8 File Offset: 0x004522D8
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

		// Token: 0x0601D98A RID: 121226 RVA: 0x004549E0 File Offset: 0x00452BE0
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

		// Token: 0x0601D98B RID: 121227 RVA: 0x00455100 File Offset: 0x00453300
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

		// Token: 0x0601D98C RID: 121228 RVA: 0x00455DB1 File Offset: 0x00453FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D98D RID: 121229 RVA: 0x00455DBC File Offset: 0x00453FBC
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

		// Token: 0x0400C831 RID: 51249
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C832 RID: 51250
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C833 RID: 51251
		private CombatCommon combatCommon_;

		// Token: 0x0400C834 RID: 51252
		public const int RequestIdFieldNumber = 2;

		// Token: 0x0400C835 RID: 51253
		private int requestId_;

		// Token: 0x0400C836 RID: 51254
		public const int CreateBulletResponseFieldNumber = 3;

		// Token: 0x0400C837 RID: 51255
		public const int DestroyBulletResponseFieldNumber = 4;

		// Token: 0x0400C838 RID: 51256
		public const int DamageExecuteResponseFieldNumber = 5;

		// Token: 0x0400C839 RID: 51257
		public const int ApplyGameplayEffectResponseFieldNumber = 6;

		// Token: 0x0400C83A RID: 51258
		public const int RemoveGameplayEffectResponseFieldNumber = 7;

		// Token: 0x0400C83B RID: 51259
		public const int HitResponseFieldNumber = 8;

		// Token: 0x0400C83C RID: 51260
		public const int HitEndResponseFieldNumber = 9;

		// Token: 0x0400C83D RID: 51261
		public const int SkillResponseFieldNumber = 10;

		// Token: 0x0400C83E RID: 51262
		public const int UseSkillResponseFieldNumber = 11;

		// Token: 0x0400C83F RID: 51263
		public const int EndSkillResponseFieldNumber = 12;

		// Token: 0x0400C840 RID: 51264
		public const int PartUpdateResponseFieldNumber = 13;

		// Token: 0x0400C841 RID: 51265
		public const int MaterialResponseFieldNumber = 14;

		// Token: 0x0400C842 RID: 51266
		public const int GameplayCueResponseFieldNumber = 15;

		// Token: 0x0400C843 RID: 51267
		public const int EntityIsVisibleResponseFieldNumber = 16;

		// Token: 0x0400C844 RID: 51268
		public const int SwitchCharacterStateResponseFieldNumber = 17;

		// Token: 0x0400C845 RID: 51269
		public const int LogicStateInitResponseFieldNumber = 18;

		// Token: 0x0400C846 RID: 51270
		public const int SwitchLogicStateResponseFieldNumber = 19;

		// Token: 0x0400C847 RID: 51271
		public const int AnimationStateChangedResponseFieldNumber = 20;

		// Token: 0x0400C848 RID: 51272
		public const int AnimationStateInitResponseFieldNumber = 21;

		// Token: 0x0400C849 RID: 51273
		public const int ModifyBulletParamsResponseFieldNumber = 22;

		// Token: 0x0400C84A RID: 51274
		public const int DrownResponseFieldNumber = 23;

		// Token: 0x0400C84B RID: 51275
		public const int OrderApplyBuffResponseFieldNumber = 24;

		// Token: 0x0400C84C RID: 51276
		public const int OrderRemoveBuffResponseFieldNumber = 25;

		// Token: 0x0400C84D RID: 51277
		public const int ActivateBuffResponseFieldNumber = 26;

		// Token: 0x0400C84E RID: 51278
		public const int OrderRemoveBuffByTagsResponseFieldNumber = 27;

		// Token: 0x0400C84F RID: 51279
		public const int AiInformationResponseFieldNumber = 28;

		// Token: 0x0400C850 RID: 51280
		public const int ToughCalcExtraRatioChangeResponseFieldNumber = 29;

		// Token: 0x0400C851 RID: 51281
		public const int BattleStateChangeResponseFieldNumber = 30;

		// Token: 0x0400C852 RID: 51282
		public const int AnimationGameplayTagResponseFieldNumber = 31;

		// Token: 0x0400C853 RID: 51283
		public const int BoneVisibleChangeResponseFieldNumber = 32;

		// Token: 0x0400C854 RID: 51284
		public const int AiBlackboardsResponseFieldNumber = 33;

		// Token: 0x0400C855 RID: 51285
		public const int AiBlackboardCdResponseFieldNumber = 34;

		// Token: 0x0400C856 RID: 51286
		public const int AiHateResponseFieldNumber = 35;

		// Token: 0x0400C857 RID: 51287
		public const int MonsterBoomResponseFieldNumber = 36;

		// Token: 0x0400C858 RID: 51288
		public const int CaughtResponseFieldNumber = 37;

		// Token: 0x0400C859 RID: 51289
		public const int EntityStaticHookMoveResponseFieldNumber = 38;

		// Token: 0x0400C85A RID: 51290
		public const int ChangeStateResponseFieldNumber = 39;

		// Token: 0x0400C85B RID: 51291
		public const int ChangeStateConfirmResponseFieldNumber = 40;

		// Token: 0x0400C85C RID: 51292
		public const int FsmConditionPassResponseFieldNumber = 41;

		// Token: 0x0400C85D RID: 51293
		public const int BuffStackCountResponseFieldNumber = 42;

		// Token: 0x0400C85E RID: 51294
		public const int ANStartResponseFieldNumber = 43;

		// Token: 0x0400C85F RID: 51295
		public const int UseSkillFailResponseFieldNumber = 44;

		// Token: 0x0400C860 RID: 51296
		public const int EnterViewDirectionResponseFieldNumber = 45;

		// Token: 0x0400C861 RID: 51297
		public const int ExitViewDirectionResponseFieldNumber = 46;

		// Token: 0x0400C862 RID: 51298
		public const int PassiveSkillAddResponseFieldNumber = 47;

		// Token: 0x0400C863 RID: 51299
		public const int InterruptSkillInDelayResponseFieldNumber = 49;

		// Token: 0x0400C864 RID: 51300
		public const int TriggerExitSkillResponseFieldNumber = 50;

		// Token: 0x0400C865 RID: 51301
		public const int ActorVisibleResponseFieldNumber = 55;

		// Token: 0x0400C866 RID: 51302
		public const int BuffEffectResponseFieldNumber = 56;

		// Token: 0x0400C867 RID: 51303
		public const int FragileChangeResponseFieldNumber = 57;

		// Token: 0x0400C868 RID: 51304
		public const int RTimeStopResponseFieldNumber = 58;

		// Token: 0x0400C869 RID: 51305
		public const int DrownEndTeleportResponseFieldNumber = 59;

		// Token: 0x0400C86A RID: 51306
		public const int MonsterDrownResponseFieldNumber = 60;

		// Token: 0x0400C86B RID: 51307
		public const int PassiveSkillRemoveResponseFieldNumber = 61;

		// Token: 0x0400C86C RID: 51308
		public const int RTimeStopInstResponseFieldNumber = 62;

		// Token: 0x0400C86D RID: 51309
		public const int FsmStateBehaviorResponseFieldNumber = 63;

		// Token: 0x0400C86E RID: 51310
		public const int FsmPlayMontageResponseFieldNumber = 64;

		// Token: 0x0400C86F RID: 51311
		public const int RTimeStopAnimResponseFieldNumber = 65;

		// Token: 0x0400C870 RID: 51312
		public const int SwitchRoleResponseFieldNumber = 66;

		// Token: 0x0400C871 RID: 51313
		public const int GameplayTagResponseFieldNumber = 67;

		// Token: 0x0400C872 RID: 51314
		public const int ExecuteQteResponseFieldNumber = 68;

		// Token: 0x0400C873 RID: 51315
		public const int CombineEntitiesResponseFieldNumber = 69;

		// Token: 0x0400C874 RID: 51316
		public const int DissolveCombineRelationResponseFieldNumber = 70;

		// Token: 0x0400C875 RID: 51317
		public const int ClientCurrentRoleReportResponseFieldNumber = 71;

		// Token: 0x0400C876 RID: 51318
		public const int GaSwitchCommonEnemyProCampResponseFieldNumber = 72;

		// Token: 0x0400C877 RID: 51319
		public const int ChangeSummonEntityStateResponseFieldNumber = 73;

		// Token: 0x0400C878 RID: 51320
		public const int CombatDataMaxResponseFieldNumber = 100;

		// Token: 0x0400C879 RID: 51321
		private object message_;

		// Token: 0x0400C87A RID: 51322
		private CombatResponseData.MessageOneofCase messageCase_;

		// Token: 0x02001AA4 RID: 6820
		public enum MessageOneofCase
		{
			// Token: 0x0400D13A RID: 53562
			None,
			// Token: 0x0400D13B RID: 53563
			CreateBulletResponse = 3,
			// Token: 0x0400D13C RID: 53564
			DestroyBulletResponse,
			// Token: 0x0400D13D RID: 53565
			DamageExecuteResponse,
			// Token: 0x0400D13E RID: 53566
			ApplyGameplayEffectResponse,
			// Token: 0x0400D13F RID: 53567
			RemoveGameplayEffectResponse,
			// Token: 0x0400D140 RID: 53568
			HitResponse,
			// Token: 0x0400D141 RID: 53569
			HitEndResponse,
			// Token: 0x0400D142 RID: 53570
			SkillResponse,
			// Token: 0x0400D143 RID: 53571
			UseSkillResponse,
			// Token: 0x0400D144 RID: 53572
			EndSkillResponse,
			// Token: 0x0400D145 RID: 53573
			PartUpdateResponse,
			// Token: 0x0400D146 RID: 53574
			MaterialResponse,
			// Token: 0x0400D147 RID: 53575
			GameplayCueResponse,
			// Token: 0x0400D148 RID: 53576
			EntityIsVisibleResponse,
			// Token: 0x0400D149 RID: 53577
			SwitchCharacterStateResponse,
			// Token: 0x0400D14A RID: 53578
			LogicStateInitResponse,
			// Token: 0x0400D14B RID: 53579
			SwitchLogicStateResponse,
			// Token: 0x0400D14C RID: 53580
			AnimationStateChangedResponse,
			// Token: 0x0400D14D RID: 53581
			AnimationStateInitResponse,
			// Token: 0x0400D14E RID: 53582
			ModifyBulletParamsResponse,
			// Token: 0x0400D14F RID: 53583
			DrownResponse,
			// Token: 0x0400D150 RID: 53584
			OrderApplyBuffResponse,
			// Token: 0x0400D151 RID: 53585
			OrderRemoveBuffResponse,
			// Token: 0x0400D152 RID: 53586
			ActivateBuffResponse,
			// Token: 0x0400D153 RID: 53587
			OrderRemoveBuffByTagsResponse,
			// Token: 0x0400D154 RID: 53588
			AiInformationResponse,
			// Token: 0x0400D155 RID: 53589
			ToughCalcExtraRatioChangeResponse,
			// Token: 0x0400D156 RID: 53590
			BattleStateChangeResponse,
			// Token: 0x0400D157 RID: 53591
			AnimationGameplayTagResponse,
			// Token: 0x0400D158 RID: 53592
			BoneVisibleChangeResponse,
			// Token: 0x0400D159 RID: 53593
			AiBlackboardsResponse,
			// Token: 0x0400D15A RID: 53594
			AiBlackboardCdResponse,
			// Token: 0x0400D15B RID: 53595
			AiHateResponse,
			// Token: 0x0400D15C RID: 53596
			MonsterBoomResponse,
			// Token: 0x0400D15D RID: 53597
			CaughtResponse,
			// Token: 0x0400D15E RID: 53598
			EntityStaticHookMoveResponse,
			// Token: 0x0400D15F RID: 53599
			ChangeStateResponse,
			// Token: 0x0400D160 RID: 53600
			ChangeStateConfirmResponse,
			// Token: 0x0400D161 RID: 53601
			FsmConditionPassResponse,
			// Token: 0x0400D162 RID: 53602
			BuffStackCountResponse,
			// Token: 0x0400D163 RID: 53603
			ANStartResponse,
			// Token: 0x0400D164 RID: 53604
			UseSkillFailResponse,
			// Token: 0x0400D165 RID: 53605
			EnterViewDirectionResponse,
			// Token: 0x0400D166 RID: 53606
			ExitViewDirectionResponse,
			// Token: 0x0400D167 RID: 53607
			PassiveSkillAddResponse,
			// Token: 0x0400D168 RID: 53608
			InterruptSkillInDelayResponse = 49,
			// Token: 0x0400D169 RID: 53609
			TriggerExitSkillResponse,
			// Token: 0x0400D16A RID: 53610
			ActorVisibleResponse = 55,
			// Token: 0x0400D16B RID: 53611
			BuffEffectResponse,
			// Token: 0x0400D16C RID: 53612
			FragileChangeResponse,
			// Token: 0x0400D16D RID: 53613
			RTimeStopResponse,
			// Token: 0x0400D16E RID: 53614
			DrownEndTeleportResponse,
			// Token: 0x0400D16F RID: 53615
			MonsterDrownResponse,
			// Token: 0x0400D170 RID: 53616
			PassiveSkillRemoveResponse,
			// Token: 0x0400D171 RID: 53617
			RTimeStopInstResponse,
			// Token: 0x0400D172 RID: 53618
			FsmStateBehaviorResponse,
			// Token: 0x0400D173 RID: 53619
			FsmPlayMontageResponse,
			// Token: 0x0400D174 RID: 53620
			RTimeStopAnimResponse,
			// Token: 0x0400D175 RID: 53621
			SwitchRoleResponse,
			// Token: 0x0400D176 RID: 53622
			GameplayTagResponse,
			// Token: 0x0400D177 RID: 53623
			ExecuteQteResponse,
			// Token: 0x0400D178 RID: 53624
			CombineEntitiesResponse,
			// Token: 0x0400D179 RID: 53625
			DissolveCombineRelationResponse,
			// Token: 0x0400D17A RID: 53626
			ClientCurrentRoleReportResponse,
			// Token: 0x0400D17B RID: 53627
			GaSwitchCommonEnemyProCampResponse,
			// Token: 0x0400D17C RID: 53628
			ChangeSummonEntityStateResponse,
			// Token: 0x0400D17D RID: 53629
			CombatDataMaxResponse = 100
		}
	}
}
