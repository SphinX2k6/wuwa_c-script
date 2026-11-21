using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Aki.Protocol.Debug;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001703 RID: 5891
	public sealed class CombatNotifyData : IMessage<CombatNotifyData>, IMessage, IEquatable<CombatNotifyData>, IDeepCloneable<CombatNotifyData>, IBufferMessage
	{
		// Token: 0x0601D6E4 RID: 120548 RVA: 0x0044216D File Offset: 0x0044036D
		[NullableContext(1)]
		public static CombatNotifyData Create()
		{
			return new CombatNotifyData();
		}

		// Token: 0x17006388 RID: 25480
		// (get) Token: 0x0601D6E5 RID: 120549 RVA: 0x00442174 File Offset: 0x00440374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006389 RID: 25481
		// (get) Token: 0x0601D6E6 RID: 120550 RVA: 0x00442177 File Offset: 0x00440377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatNotifyData.Descriptor;
			}
		}

		// Token: 0x0601D6E7 RID: 120551 RVA: 0x0044217E File Offset: 0x0044037E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData()
		{
		}

		// Token: 0x0601D6E8 RID: 120552 RVA: 0x00442188 File Offset: 0x00440388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData(CombatNotifyData other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			switch (other.MessageCase)
			{
			case CombatNotifyData.MessageOneofCase.CreateBulletNotify:
				this.CreateBulletNotify = other.CreateBulletNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.DestroyBulletNotify:
				this.DestroyBulletNotify = other.DestroyBulletNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.DamageExecuteNotify:
				this.DamageExecuteNotify = other.DamageExecuteNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify:
				this.ApplyGameplayEffectNotify = other.ApplyGameplayEffectNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify:
				this.RemoveGameplayEffectNotify = other.RemoveGameplayEffectNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.HitNotify:
				this.HitNotify = other.HitNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.SkillNotify:
				this.SkillNotify = other.SkillNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.UseSkillNotify:
				this.UseSkillNotify = other.UseSkillNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.EndSkillNotify:
				this.EndSkillNotify = other.EndSkillNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify:
				this.EntityLoadCompleteNotify = other.EntityLoadCompleteNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.PartUpdateNotify:
				this.PartUpdateNotify = other.PartUpdateNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.PartComponentInitNotify:
				this.PartComponentInitNotify = other.PartComponentInitNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.MaterialNotify:
				this.MaterialNotify = other.MaterialNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.GameplayCueNotify:
				this.GameplayCueNotify = other.GameplayCueNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify:
				this.EntityIsVisibleNotify = other.EntityIsVisibleNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify:
				this.SwitchCharacterStateNotify = other.SwitchCharacterStateNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify:
				this.PlayerRebackSceneNotify = other.PlayerRebackSceneNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.LogicStateInitNotify:
				this.LogicStateInitNotify = other.LogicStateInitNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify:
				this.SwitchLogicStateNotify = other.SwitchLogicStateNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AttributeChangedNotify:
				this.AttributeChangedNotify = other.AttributeChangedNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify:
				this.AnimationStateChangedNotify = other.AnimationStateChangedNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AnimationStateInitNotify:
				this.AnimationStateInitNotify = other.AnimationStateInitNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify:
				this.ModifyBulletParamsNotify = other.ModifyBulletParamsNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.DrownNotify:
				this.DrownNotify = other.DrownNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify:
				this.OrderApplyBuffNotify = other.OrderApplyBuffNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify:
				this.OrderRemoveBuffNotify = other.OrderRemoveBuffNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ActivateBuffNotify:
				this.ActivateBuffNotify = other.ActivateBuffNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify:
				this.OrderRemoveBuffByTagsNotify = other.OrderRemoveBuffByTagsNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AiInformationNotify:
				this.AiInformationNotify = other.AiInformationNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.BattleStateChangeNotify:
				this.BattleStateChangeNotify = other.BattleStateChangeNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify:
				this.AnimationGameplayTagNotify = other.AnimationGameplayTagNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify:
				this.BoneVisibleChangeNotify = other.BoneVisibleChangeNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify:
				this.AiBlackboardCdNotify = other.AiBlackboardCdNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.CaughtNotify:
				this.CaughtNotify = other.CaughtNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify:
				this.EntityStaticHookMoveNotify = other.EntityStaticHookMoveNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ChangeStateNotify:
				this.ChangeStateNotify = other.ChangeStateNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify:
				this.ChangeStateConfirmNotify = other.ChangeStateConfirmNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.BuffStackCountNotify:
				this.BuffStackCountNotify = other.BuffStackCountNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.MontagePlayNotify:
				this.MontagePlayNotify = other.MontagePlayNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ANStartNotify:
				this.ANStartNotify = other.ANStartNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.FsmResetNotify:
				this.FsmResetNotify = other.FsmResetNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.DamageRecordNotify:
				this.DamageRecordNotify = other.DamageRecordNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AiHateNotify:
				this.AiHateNotify = other.AiHateNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.FsmBlackboardNotify:
				this.FsmBlackboardNotify = other.FsmBlackboardNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify:
				this.CharacterBattleStateChangeNotify = other.CharacterBattleStateChangeNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify:
				this.ApplyBuffS2CRequestNotify = other.ApplyBuffS2CRequestNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify:
				this.RemoveBuffS2CRequestNotify = other.RemoveBuffS2CRequestNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ActorVisibleNotify:
				this.ActorVisibleNotify = other.ActorVisibleNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify:
				this.RecoverPropChangedNotify = other.RecoverPropChangedNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify:
				this.RemoveBuffByIdS2CRequestNotify = other.RemoveBuffByIdS2CRequestNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ShieldUpdateNotify:
				this.ShieldUpdateNotify = other.ShieldUpdateNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify:
				this.PlayerBattleStateChangeNotify = other.PlayerBattleStateChangeNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify:
				this.FsmCustomBlackboardNotify = other.FsmCustomBlackboardNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify:
				this.PassiveSkillAddNotify = other.PassiveSkillAddNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify:
				this.PassiveSkillRemoveNotify = other.PassiveSkillRemoveNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ExecuteQteNotify:
				this.ExecuteQteNotify = other.ExecuteQteNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify:
				this.ModifyEntityCampNotify = other.ModifyEntityCampNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify:
				this.AddCombineEntitiesRelationNotify = other.AddCombineEntitiesRelationNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify:
				this.RemoveCombineRelationNotify = other.RemoveCombineRelationNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.TestDamageRecordNotify:
				this.TestDamageRecordNotify = other.TestDamageRecordNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.BuffDurationNotify:
				this.BuffDurationNotify = other.BuffDurationNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify:
				this.EntityLivingStatusNotify = other.EntityLivingStatusNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.NewLinkNotify:
				this.NewLinkNotify = other.NewLinkNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify:
				this.ApplyBuffFailedNotify = other.ApplyBuffFailedNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.PackAnimChangedNotify:
				this.PackAnimChangedNotify = other.PackAnimChangedNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.VisionTriggerNotify:
				this.VisionTriggerNotify = other.VisionTriggerNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify:
				this.RemoveBuffByServerIdS2CRequestNotify = other.RemoveBuffByServerIdS2CRequestNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.TransformBuffStackNotify:
				this.TransformBuffStackNotify = other.TransformBuffStackNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify:
				this.MotorSummonAndRideNotify = other.MotorSummonAndRideNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.BulletPatternNotify:
				this.BulletPatternNotify = other.BulletPatternNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify:
				this.FsmMontageDurationNotify = other.FsmMontageDurationNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.CombatValNotify:
				this.CombatValNotify = other.CombatValNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify:
				this.CombatValDecayBeginNotify = other.CombatValDecayBeginNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.SquadPropChangedNotify:
				this.SquadPropChangedNotify = other.SquadPropChangedNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.DamageShowNotify:
				this.DamageShowNotify = other.DamageShowNotify.Clone();
				break;
			case CombatNotifyData.MessageOneofCase.CombatDataMaxNotify:
				this.CombatDataMaxNotify = other.CombatDataMaxNotify.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D6E9 RID: 120553 RVA: 0x004429D9 File Offset: 0x00440BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData Clone()
		{
			return new CombatNotifyData(this);
		}

		// Token: 0x1700638A RID: 25482
		// (get) Token: 0x0601D6EA RID: 120554 RVA: 0x004429E1 File Offset: 0x00440BE1
		// (set) Token: 0x0601D6EB RID: 120555 RVA: 0x004429E9 File Offset: 0x00440BE9
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

		// Token: 0x1700638B RID: 25483
		// (get) Token: 0x0601D6EC RID: 120556 RVA: 0x004429F2 File Offset: 0x00440BF2
		// (set) Token: 0x0601D6ED RID: 120557 RVA: 0x00442A0A File Offset: 0x00440C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletNotify CreateBulletNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.CreateBulletNotify)
				{
					return null;
				}
				return (CreateBulletNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.CreateBulletNotify);
			}
		}

		// Token: 0x1700638C RID: 25484
		// (get) Token: 0x0601D6EE RID: 120558 RVA: 0x00442A20 File Offset: 0x00440C20
		// (set) Token: 0x0601D6EF RID: 120559 RVA: 0x00442A38 File Offset: 0x00440C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletNotify DestroyBulletNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.DestroyBulletNotify)
				{
					return null;
				}
				return (DestroyBulletNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.DestroyBulletNotify);
			}
		}

		// Token: 0x1700638D RID: 25485
		// (get) Token: 0x0601D6F0 RID: 120560 RVA: 0x00442A4E File Offset: 0x00440C4E
		// (set) Token: 0x0601D6F1 RID: 120561 RVA: 0x00442A66 File Offset: 0x00440C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteNotify DamageExecuteNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.DamageExecuteNotify)
				{
					return null;
				}
				return (DamageExecuteNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.DamageExecuteNotify);
			}
		}

		// Token: 0x1700638E RID: 25486
		// (get) Token: 0x0601D6F2 RID: 120562 RVA: 0x00442A7C File Offset: 0x00440C7C
		// (set) Token: 0x0601D6F3 RID: 120563 RVA: 0x00442A94 File Offset: 0x00440C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectNotify ApplyGameplayEffectNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify)
				{
					return null;
				}
				return (ApplyGameplayEffectNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify);
			}
		}

		// Token: 0x1700638F RID: 25487
		// (get) Token: 0x0601D6F4 RID: 120564 RVA: 0x00442AAA File Offset: 0x00440CAA
		// (set) Token: 0x0601D6F5 RID: 120565 RVA: 0x00442AC2 File Offset: 0x00440CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectNotify RemoveGameplayEffectNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify)
				{
					return null;
				}
				return (RemoveGameplayEffectNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify);
			}
		}

		// Token: 0x17006390 RID: 25488
		// (get) Token: 0x0601D6F6 RID: 120566 RVA: 0x00442AD8 File Offset: 0x00440CD8
		// (set) Token: 0x0601D6F7 RID: 120567 RVA: 0x00442AF0 File Offset: 0x00440CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitNotify HitNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.HitNotify)
				{
					return null;
				}
				return (HitNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.HitNotify);
			}
		}

		// Token: 0x17006391 RID: 25489
		// (get) Token: 0x0601D6F8 RID: 120568 RVA: 0x00442B06 File Offset: 0x00440D06
		// (set) Token: 0x0601D6F9 RID: 120569 RVA: 0x00442B1E File Offset: 0x00440D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNotify SkillNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.SkillNotify)
				{
					return null;
				}
				return (SkillNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.SkillNotify);
			}
		}

		// Token: 0x17006392 RID: 25490
		// (get) Token: 0x0601D6FA RID: 120570 RVA: 0x00442B34 File Offset: 0x00440D34
		// (set) Token: 0x0601D6FB RID: 120571 RVA: 0x00442B4D File Offset: 0x00440D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillNotify UseSkillNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.UseSkillNotify)
				{
					return null;
				}
				return (UseSkillNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.UseSkillNotify);
			}
		}

		// Token: 0x17006393 RID: 25491
		// (get) Token: 0x0601D6FC RID: 120572 RVA: 0x00442B64 File Offset: 0x00440D64
		// (set) Token: 0x0601D6FD RID: 120573 RVA: 0x00442B7D File Offset: 0x00440D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillNotify EndSkillNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.EndSkillNotify)
				{
					return null;
				}
				return (EndSkillNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.EndSkillNotify);
			}
		}

		// Token: 0x17006394 RID: 25492
		// (get) Token: 0x0601D6FE RID: 120574 RVA: 0x00442B94 File Offset: 0x00440D94
		// (set) Token: 0x0601D6FF RID: 120575 RVA: 0x00442BAD File Offset: 0x00440DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLoadCompleteNotify EntityLoadCompleteNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify)
				{
					return null;
				}
				return (EntityLoadCompleteNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify);
			}
		}

		// Token: 0x17006395 RID: 25493
		// (get) Token: 0x0601D700 RID: 120576 RVA: 0x00442BC4 File Offset: 0x00440DC4
		// (set) Token: 0x0601D701 RID: 120577 RVA: 0x00442BDD File Offset: 0x00440DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateNotify PartUpdateNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.PartUpdateNotify)
				{
					return null;
				}
				return (PartUpdateNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.PartUpdateNotify);
			}
		}

		// Token: 0x17006396 RID: 25494
		// (get) Token: 0x0601D702 RID: 120578 RVA: 0x00442BF4 File Offset: 0x00440DF4
		// (set) Token: 0x0601D703 RID: 120579 RVA: 0x00442C0D File Offset: 0x00440E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitNotify PartComponentInitNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.PartComponentInitNotify)
				{
					return null;
				}
				return (PartComponentInitNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.PartComponentInitNotify);
			}
		}

		// Token: 0x17006397 RID: 25495
		// (get) Token: 0x0601D704 RID: 120580 RVA: 0x00442C24 File Offset: 0x00440E24
		// (set) Token: 0x0601D705 RID: 120581 RVA: 0x00442C3D File Offset: 0x00440E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialNotify MaterialNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.MaterialNotify)
				{
					return null;
				}
				return (MaterialNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.MaterialNotify);
			}
		}

		// Token: 0x17006398 RID: 25496
		// (get) Token: 0x0601D706 RID: 120582 RVA: 0x00442C54 File Offset: 0x00440E54
		// (set) Token: 0x0601D707 RID: 120583 RVA: 0x00442C6D File Offset: 0x00440E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueNotify GameplayCueNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.GameplayCueNotify)
				{
					return null;
				}
				return (GameplayCueNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.GameplayCueNotify);
			}
		}

		// Token: 0x17006399 RID: 25497
		// (get) Token: 0x0601D708 RID: 120584 RVA: 0x00442C84 File Offset: 0x00440E84
		// (set) Token: 0x0601D709 RID: 120585 RVA: 0x00442C9D File Offset: 0x00440E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleNotify EntityIsVisibleNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify)
				{
					return null;
				}
				return (EntityIsVisibleNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify);
			}
		}

		// Token: 0x1700639A RID: 25498
		// (get) Token: 0x0601D70A RID: 120586 RVA: 0x00442CB4 File Offset: 0x00440EB4
		// (set) Token: 0x0601D70B RID: 120587 RVA: 0x00442CCD File Offset: 0x00440ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateNotify SwitchCharacterStateNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify)
				{
					return null;
				}
				return (SwitchCharacterStateNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify);
			}
		}

		// Token: 0x1700639B RID: 25499
		// (get) Token: 0x0601D70C RID: 120588 RVA: 0x00442CE4 File Offset: 0x00440EE4
		// (set) Token: 0x0601D70D RID: 120589 RVA: 0x00442CFD File Offset: 0x00440EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRebackSceneNotify PlayerRebackSceneNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify)
				{
					return null;
				}
				return (PlayerRebackSceneNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify);
			}
		}

		// Token: 0x1700639C RID: 25500
		// (get) Token: 0x0601D70E RID: 120590 RVA: 0x00442D14 File Offset: 0x00440F14
		// (set) Token: 0x0601D70F RID: 120591 RVA: 0x00442D2D File Offset: 0x00440F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitNotify LogicStateInitNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.LogicStateInitNotify)
				{
					return null;
				}
				return (LogicStateInitNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.LogicStateInitNotify);
			}
		}

		// Token: 0x1700639D RID: 25501
		// (get) Token: 0x0601D710 RID: 120592 RVA: 0x00442D44 File Offset: 0x00440F44
		// (set) Token: 0x0601D711 RID: 120593 RVA: 0x00442D5D File Offset: 0x00440F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateNotify SwitchLogicStateNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify)
				{
					return null;
				}
				return (SwitchLogicStateNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify);
			}
		}

		// Token: 0x1700639E RID: 25502
		// (get) Token: 0x0601D712 RID: 120594 RVA: 0x00442D74 File Offset: 0x00440F74
		// (set) Token: 0x0601D713 RID: 120595 RVA: 0x00442D8D File Offset: 0x00440F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedNotify AttributeChangedNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AttributeChangedNotify)
				{
					return null;
				}
				return (AttributeChangedNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AttributeChangedNotify);
			}
		}

		// Token: 0x1700639F RID: 25503
		// (get) Token: 0x0601D714 RID: 120596 RVA: 0x00442DA4 File Offset: 0x00440FA4
		// (set) Token: 0x0601D715 RID: 120597 RVA: 0x00442DBD File Offset: 0x00440FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedNotify AnimationStateChangedNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify)
				{
					return null;
				}
				return (AnimationStateChangedNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify);
			}
		}

		// Token: 0x170063A0 RID: 25504
		// (get) Token: 0x0601D716 RID: 120598 RVA: 0x00442DD4 File Offset: 0x00440FD4
		// (set) Token: 0x0601D717 RID: 120599 RVA: 0x00442DED File Offset: 0x00440FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitNotify AnimationStateInitNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AnimationStateInitNotify)
				{
					return null;
				}
				return (AnimationStateInitNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AnimationStateInitNotify);
			}
		}

		// Token: 0x170063A1 RID: 25505
		// (get) Token: 0x0601D718 RID: 120600 RVA: 0x00442E04 File Offset: 0x00441004
		// (set) Token: 0x0601D719 RID: 120601 RVA: 0x00442E1D File Offset: 0x0044101D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsNotify ModifyBulletParamsNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify)
				{
					return null;
				}
				return (ModifyBulletParamsNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify);
			}
		}

		// Token: 0x170063A2 RID: 25506
		// (get) Token: 0x0601D71A RID: 120602 RVA: 0x00442E34 File Offset: 0x00441034
		// (set) Token: 0x0601D71B RID: 120603 RVA: 0x00442E4D File Offset: 0x0044104D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownNotify DrownNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.DrownNotify)
				{
					return null;
				}
				return (DrownNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.DrownNotify);
			}
		}

		// Token: 0x170063A3 RID: 25507
		// (get) Token: 0x0601D71C RID: 120604 RVA: 0x00442E64 File Offset: 0x00441064
		// (set) Token: 0x0601D71D RID: 120605 RVA: 0x00442E7D File Offset: 0x0044107D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffNotify OrderApplyBuffNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify)
				{
					return null;
				}
				return (OrderApplyBuffNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify);
			}
		}

		// Token: 0x170063A4 RID: 25508
		// (get) Token: 0x0601D71E RID: 120606 RVA: 0x00442E94 File Offset: 0x00441094
		// (set) Token: 0x0601D71F RID: 120607 RVA: 0x00442EAD File Offset: 0x004410AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffNotify OrderRemoveBuffNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify)
				{
					return null;
				}
				return (OrderRemoveBuffNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify);
			}
		}

		// Token: 0x170063A5 RID: 25509
		// (get) Token: 0x0601D720 RID: 120608 RVA: 0x00442EC4 File Offset: 0x004410C4
		// (set) Token: 0x0601D721 RID: 120609 RVA: 0x00442EDD File Offset: 0x004410DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffNotify ActivateBuffNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ActivateBuffNotify)
				{
					return null;
				}
				return (ActivateBuffNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ActivateBuffNotify);
			}
		}

		// Token: 0x170063A6 RID: 25510
		// (get) Token: 0x0601D722 RID: 120610 RVA: 0x00442EF4 File Offset: 0x004410F4
		// (set) Token: 0x0601D723 RID: 120611 RVA: 0x00442F0D File Offset: 0x0044110D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsNotify OrderRemoveBuffByTagsNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify)
				{
					return null;
				}
				return (OrderRemoveBuffByTagsNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify);
			}
		}

		// Token: 0x170063A7 RID: 25511
		// (get) Token: 0x0601D724 RID: 120612 RVA: 0x00442F24 File Offset: 0x00441124
		// (set) Token: 0x0601D725 RID: 120613 RVA: 0x00442F3D File Offset: 0x0044113D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationNotify AiInformationNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AiInformationNotify)
				{
					return null;
				}
				return (AiInformationNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AiInformationNotify);
			}
		}

		// Token: 0x170063A8 RID: 25512
		// (get) Token: 0x0601D726 RID: 120614 RVA: 0x00442F54 File Offset: 0x00441154
		// (set) Token: 0x0601D727 RID: 120615 RVA: 0x00442F6D File Offset: 0x0044116D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeNotify BattleStateChangeNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.BattleStateChangeNotify)
				{
					return null;
				}
				return (BattleStateChangeNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.BattleStateChangeNotify);
			}
		}

		// Token: 0x170063A9 RID: 25513
		// (get) Token: 0x0601D728 RID: 120616 RVA: 0x00442F84 File Offset: 0x00441184
		// (set) Token: 0x0601D729 RID: 120617 RVA: 0x00442F9D File Offset: 0x0044119D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagNotify AnimationGameplayTagNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify)
				{
					return null;
				}
				return (AnimationGameplayTagNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify);
			}
		}

		// Token: 0x170063AA RID: 25514
		// (get) Token: 0x0601D72A RID: 120618 RVA: 0x00442FB4 File Offset: 0x004411B4
		// (set) Token: 0x0601D72B RID: 120619 RVA: 0x00442FCD File Offset: 0x004411CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeNotify BoneVisibleChangeNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify)
				{
					return null;
				}
				return (BoneVisibleChangeNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify);
			}
		}

		// Token: 0x170063AB RID: 25515
		// (get) Token: 0x0601D72C RID: 120620 RVA: 0x00442FE4 File Offset: 0x004411E4
		// (set) Token: 0x0601D72D RID: 120621 RVA: 0x00442FFD File Offset: 0x004411FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdNotify AiBlackboardCdNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify)
				{
					return null;
				}
				return (AiBlackboardCdNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify);
			}
		}

		// Token: 0x170063AC RID: 25516
		// (get) Token: 0x0601D72E RID: 120622 RVA: 0x00443014 File Offset: 0x00441214
		// (set) Token: 0x0601D72F RID: 120623 RVA: 0x0044302D File Offset: 0x0044122D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtNotify CaughtNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.CaughtNotify)
				{
					return null;
				}
				return (CaughtNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.CaughtNotify);
			}
		}

		// Token: 0x170063AD RID: 25517
		// (get) Token: 0x0601D730 RID: 120624 RVA: 0x00443044 File Offset: 0x00441244
		// (set) Token: 0x0601D731 RID: 120625 RVA: 0x0044305D File Offset: 0x0044125D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify EntityStaticHookMoveNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify)
				{
					return null;
				}
				return (EntityStaticHookMoveNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify);
			}
		}

		// Token: 0x170063AE RID: 25518
		// (get) Token: 0x0601D732 RID: 120626 RVA: 0x00443074 File Offset: 0x00441274
		// (set) Token: 0x0601D733 RID: 120627 RVA: 0x0044308D File Offset: 0x0044128D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateNotify ChangeStateNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ChangeStateNotify)
				{
					return null;
				}
				return (ChangeStateNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ChangeStateNotify);
			}
		}

		// Token: 0x170063AF RID: 25519
		// (get) Token: 0x0601D734 RID: 120628 RVA: 0x004430A4 File Offset: 0x004412A4
		// (set) Token: 0x0601D735 RID: 120629 RVA: 0x004430BD File Offset: 0x004412BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmNotify ChangeStateConfirmNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify)
				{
					return null;
				}
				return (ChangeStateConfirmNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify);
			}
		}

		// Token: 0x170063B0 RID: 25520
		// (get) Token: 0x0601D736 RID: 120630 RVA: 0x004430D4 File Offset: 0x004412D4
		// (set) Token: 0x0601D737 RID: 120631 RVA: 0x004430ED File Offset: 0x004412ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountNotify BuffStackCountNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.BuffStackCountNotify)
				{
					return null;
				}
				return (BuffStackCountNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.BuffStackCountNotify);
			}
		}

		// Token: 0x170063B1 RID: 25521
		// (get) Token: 0x0601D738 RID: 120632 RVA: 0x00443104 File Offset: 0x00441304
		// (set) Token: 0x0601D739 RID: 120633 RVA: 0x0044311D File Offset: 0x0044131D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayNotify MontagePlayNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.MontagePlayNotify)
				{
					return null;
				}
				return (MontagePlayNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.MontagePlayNotify);
			}
		}

		// Token: 0x170063B2 RID: 25522
		// (get) Token: 0x0601D73A RID: 120634 RVA: 0x00443134 File Offset: 0x00441334
		// (set) Token: 0x0601D73B RID: 120635 RVA: 0x0044314D File Offset: 0x0044134D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartNotify ANStartNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ANStartNotify)
				{
					return null;
				}
				return (ANStartNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ANStartNotify);
			}
		}

		// Token: 0x170063B3 RID: 25523
		// (get) Token: 0x0601D73C RID: 120636 RVA: 0x00443164 File Offset: 0x00441364
		// (set) Token: 0x0601D73D RID: 120637 RVA: 0x0044317D File Offset: 0x0044137D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmResetNotify FsmResetNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.FsmResetNotify)
				{
					return null;
				}
				return (FsmResetNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.FsmResetNotify);
			}
		}

		// Token: 0x170063B4 RID: 25524
		// (get) Token: 0x0601D73E RID: 120638 RVA: 0x00443194 File Offset: 0x00441394
		// (set) Token: 0x0601D73F RID: 120639 RVA: 0x004431AD File Offset: 0x004413AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordNotify DamageRecordNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.DamageRecordNotify)
				{
					return null;
				}
				return (DamageRecordNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.DamageRecordNotify);
			}
		}

		// Token: 0x170063B5 RID: 25525
		// (get) Token: 0x0601D740 RID: 120640 RVA: 0x004431C4 File Offset: 0x004413C4
		// (set) Token: 0x0601D741 RID: 120641 RVA: 0x004431DD File Offset: 0x004413DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateNotify AiHateNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AiHateNotify)
				{
					return null;
				}
				return (AiHateNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AiHateNotify);
			}
		}

		// Token: 0x170063B6 RID: 25526
		// (get) Token: 0x0601D742 RID: 120642 RVA: 0x004431F4 File Offset: 0x004413F4
		// (set) Token: 0x0601D743 RID: 120643 RVA: 0x0044320D File Offset: 0x0044140D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmBlackboardNotify FsmBlackboardNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.FsmBlackboardNotify)
				{
					return null;
				}
				return (FsmBlackboardNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.FsmBlackboardNotify);
			}
		}

		// Token: 0x170063B7 RID: 25527
		// (get) Token: 0x0601D744 RID: 120644 RVA: 0x00443224 File Offset: 0x00441424
		// (set) Token: 0x0601D745 RID: 120645 RVA: 0x0044323D File Offset: 0x0044143D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateChangeNotify CharacterBattleStateChangeNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify)
				{
					return null;
				}
				return (CharacterBattleStateChangeNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify);
			}
		}

		// Token: 0x170063B8 RID: 25528
		// (get) Token: 0x0601D746 RID: 120646 RVA: 0x00443254 File Offset: 0x00441454
		// (set) Token: 0x0601D747 RID: 120647 RVA: 0x0044326D File Offset: 0x0044146D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cRequestNotify ApplyBuffS2CRequestNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify)
				{
					return null;
				}
				return (ApplyBuffS2cRequestNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify);
			}
		}

		// Token: 0x170063B9 RID: 25529
		// (get) Token: 0x0601D748 RID: 120648 RVA: 0x00443284 File Offset: 0x00441484
		// (set) Token: 0x0601D749 RID: 120649 RVA: 0x0044329D File Offset: 0x0044149D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cRequestNotify RemoveBuffS2CRequestNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify)
				{
					return null;
				}
				return (RemoveBuffS2cRequestNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify);
			}
		}

		// Token: 0x170063BA RID: 25530
		// (get) Token: 0x0601D74A RID: 120650 RVA: 0x004432B4 File Offset: 0x004414B4
		// (set) Token: 0x0601D74B RID: 120651 RVA: 0x004432CD File Offset: 0x004414CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleNotify ActorVisibleNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ActorVisibleNotify)
				{
					return null;
				}
				return (ActorVisibleNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ActorVisibleNotify);
			}
		}

		// Token: 0x170063BB RID: 25531
		// (get) Token: 0x0601D74C RID: 120652 RVA: 0x004432E4 File Offset: 0x004414E4
		// (set) Token: 0x0601D74D RID: 120653 RVA: 0x004432FD File Offset: 0x004414FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverPropChangedNotify RecoverPropChangedNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify)
				{
					return null;
				}
				return (RecoverPropChangedNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify);
			}
		}

		// Token: 0x170063BC RID: 25532
		// (get) Token: 0x0601D74E RID: 120654 RVA: 0x00443314 File Offset: 0x00441514
		// (set) Token: 0x0601D74F RID: 120655 RVA: 0x0044332D File Offset: 0x0044152D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cRequestNotify RemoveBuffByIdS2CRequestNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify)
				{
					return null;
				}
				return (RemoveBuffByIdS2cRequestNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify);
			}
		}

		// Token: 0x170063BD RID: 25533
		// (get) Token: 0x0601D750 RID: 120656 RVA: 0x00443344 File Offset: 0x00441544
		// (set) Token: 0x0601D751 RID: 120657 RVA: 0x0044335D File Offset: 0x0044155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateNotify ShieldUpdateNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ShieldUpdateNotify)
				{
					return null;
				}
				return (ShieldUpdateNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ShieldUpdateNotify);
			}
		}

		// Token: 0x170063BE RID: 25534
		// (get) Token: 0x0601D752 RID: 120658 RVA: 0x00443374 File Offset: 0x00441574
		// (set) Token: 0x0601D753 RID: 120659 RVA: 0x0044338D File Offset: 0x0044158D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBattleStateChangeNotify PlayerBattleStateChangeNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify)
				{
					return null;
				}
				return (PlayerBattleStateChangeNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify);
			}
		}

		// Token: 0x170063BF RID: 25535
		// (get) Token: 0x0601D754 RID: 120660 RVA: 0x004433A4 File Offset: 0x004415A4
		// (set) Token: 0x0601D755 RID: 120661 RVA: 0x004433BD File Offset: 0x004415BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardNotify FsmCustomBlackboardNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify)
				{
					return null;
				}
				return (FsmCustomBlackboardNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify);
			}
		}

		// Token: 0x170063C0 RID: 25536
		// (get) Token: 0x0601D756 RID: 120662 RVA: 0x004433D4 File Offset: 0x004415D4
		// (set) Token: 0x0601D757 RID: 120663 RVA: 0x004433ED File Offset: 0x004415ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddNotify PassiveSkillAddNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify)
				{
					return null;
				}
				return (PassiveSkillAddNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify);
			}
		}

		// Token: 0x170063C1 RID: 25537
		// (get) Token: 0x0601D758 RID: 120664 RVA: 0x00443404 File Offset: 0x00441604
		// (set) Token: 0x0601D759 RID: 120665 RVA: 0x0044341D File Offset: 0x0044161D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveNotify PassiveSkillRemoveNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify)
				{
					return null;
				}
				return (PassiveSkillRemoveNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify);
			}
		}

		// Token: 0x170063C2 RID: 25538
		// (get) Token: 0x0601D75A RID: 120666 RVA: 0x00443434 File Offset: 0x00441634
		// (set) Token: 0x0601D75B RID: 120667 RVA: 0x0044344D File Offset: 0x0044164D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteNotify ExecuteQteNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ExecuteQteNotify)
				{
					return null;
				}
				return (ExecuteQteNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ExecuteQteNotify);
			}
		}

		// Token: 0x170063C3 RID: 25539
		// (get) Token: 0x0601D75C RID: 120668 RVA: 0x00443464 File Offset: 0x00441664
		// (set) Token: 0x0601D75D RID: 120669 RVA: 0x0044347D File Offset: 0x0044167D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyEntityCampNotify ModifyEntityCampNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify)
				{
					return null;
				}
				return (ModifyEntityCampNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify);
			}
		}

		// Token: 0x170063C4 RID: 25540
		// (get) Token: 0x0601D75E RID: 120670 RVA: 0x00443494 File Offset: 0x00441694
		// (set) Token: 0x0601D75F RID: 120671 RVA: 0x004434AD File Offset: 0x004416AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCombineEntitiesRelationNotify AddCombineEntitiesRelationNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify)
				{
					return null;
				}
				return (AddCombineEntitiesRelationNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify);
			}
		}

		// Token: 0x170063C5 RID: 25541
		// (get) Token: 0x0601D760 RID: 120672 RVA: 0x004434C4 File Offset: 0x004416C4
		// (set) Token: 0x0601D761 RID: 120673 RVA: 0x004434DD File Offset: 0x004416DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveCombineRelationNotify RemoveCombineRelationNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify)
				{
					return null;
				}
				return (RemoveCombineRelationNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify);
			}
		}

		// Token: 0x170063C6 RID: 25542
		// (get) Token: 0x0601D762 RID: 120674 RVA: 0x004434F4 File Offset: 0x004416F4
		// (set) Token: 0x0601D763 RID: 120675 RVA: 0x0044350D File Offset: 0x0044170D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordNotify TestDamageRecordNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.TestDamageRecordNotify)
				{
					return null;
				}
				return (TestDamageRecordNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.TestDamageRecordNotify);
			}
		}

		// Token: 0x170063C7 RID: 25543
		// (get) Token: 0x0601D764 RID: 120676 RVA: 0x00443524 File Offset: 0x00441724
		// (set) Token: 0x0601D765 RID: 120677 RVA: 0x0044353D File Offset: 0x0044173D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffDurationNotify BuffDurationNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.BuffDurationNotify)
				{
					return null;
				}
				return (BuffDurationNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.BuffDurationNotify);
			}
		}

		// Token: 0x170063C8 RID: 25544
		// (get) Token: 0x0601D766 RID: 120678 RVA: 0x00443554 File Offset: 0x00441754
		// (set) Token: 0x0601D767 RID: 120679 RVA: 0x0044356D File Offset: 0x0044176D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLivingStatusNotify EntityLivingStatusNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify)
				{
					return null;
				}
				return (EntityLivingStatusNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify);
			}
		}

		// Token: 0x170063C9 RID: 25545
		// (get) Token: 0x0601D768 RID: 120680 RVA: 0x00443584 File Offset: 0x00441784
		// (set) Token: 0x0601D769 RID: 120681 RVA: 0x0044359D File Offset: 0x0044179D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkNotify NewLinkNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.NewLinkNotify)
				{
					return null;
				}
				return (NewLinkNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.NewLinkNotify);
			}
		}

		// Token: 0x170063CA RID: 25546
		// (get) Token: 0x0601D76A RID: 120682 RVA: 0x004435B4 File Offset: 0x004417B4
		// (set) Token: 0x0601D76B RID: 120683 RVA: 0x004435CD File Offset: 0x004417CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffFailedNotify ApplyBuffFailedNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify)
				{
					return null;
				}
				return (ApplyBuffFailedNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify);
			}
		}

		// Token: 0x170063CB RID: 25547
		// (get) Token: 0x0601D76C RID: 120684 RVA: 0x004435E4 File Offset: 0x004417E4
		// (set) Token: 0x0601D76D RID: 120685 RVA: 0x004435FD File Offset: 0x004417FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PackAnimChangedNotify PackAnimChangedNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.PackAnimChangedNotify)
				{
					return null;
				}
				return (PackAnimChangedNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.PackAnimChangedNotify);
			}
		}

		// Token: 0x170063CC RID: 25548
		// (get) Token: 0x0601D76E RID: 120686 RVA: 0x00443614 File Offset: 0x00441814
		// (set) Token: 0x0601D76F RID: 120687 RVA: 0x0044362D File Offset: 0x0044182D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerNotify VisionTriggerNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.VisionTriggerNotify)
				{
					return null;
				}
				return (VisionTriggerNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.VisionTriggerNotify);
			}
		}

		// Token: 0x170063CD RID: 25549
		// (get) Token: 0x0601D770 RID: 120688 RVA: 0x00443644 File Offset: 0x00441844
		// (set) Token: 0x0601D771 RID: 120689 RVA: 0x0044365D File Offset: 0x0044185D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByServerIdS2cRequestNotify RemoveBuffByServerIdS2CRequestNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify)
				{
					return null;
				}
				return (RemoveBuffByServerIdS2cRequestNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify);
			}
		}

		// Token: 0x170063CE RID: 25550
		// (get) Token: 0x0601D772 RID: 120690 RVA: 0x00443674 File Offset: 0x00441874
		// (set) Token: 0x0601D773 RID: 120691 RVA: 0x0044368D File Offset: 0x0044188D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransformBuffStackNotify TransformBuffStackNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.TransformBuffStackNotify)
				{
					return null;
				}
				return (TransformBuffStackNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.TransformBuffStackNotify);
			}
		}

		// Token: 0x170063CF RID: 25551
		// (get) Token: 0x0601D774 RID: 120692 RVA: 0x004436A4 File Offset: 0x004418A4
		// (set) Token: 0x0601D775 RID: 120693 RVA: 0x004436BD File Offset: 0x004418BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRideNotify MotorSummonAndRideNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify)
				{
					return null;
				}
				return (MotorSummonAndRideNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify);
			}
		}

		// Token: 0x170063D0 RID: 25552
		// (get) Token: 0x0601D776 RID: 120694 RVA: 0x004436D4 File Offset: 0x004418D4
		// (set) Token: 0x0601D777 RID: 120695 RVA: 0x004436ED File Offset: 0x004418ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternNotify BulletPatternNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.BulletPatternNotify)
				{
					return null;
				}
				return (BulletPatternNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.BulletPatternNotify);
			}
		}

		// Token: 0x170063D1 RID: 25553
		// (get) Token: 0x0601D778 RID: 120696 RVA: 0x00443704 File Offset: 0x00441904
		// (set) Token: 0x0601D779 RID: 120697 RVA: 0x0044371D File Offset: 0x0044191D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmMontageDurationNotify FsmMontageDurationNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify)
				{
					return null;
				}
				return (FsmMontageDurationNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify);
			}
		}

		// Token: 0x170063D2 RID: 25554
		// (get) Token: 0x0601D77A RID: 120698 RVA: 0x00443734 File Offset: 0x00441934
		// (set) Token: 0x0601D77B RID: 120699 RVA: 0x0044374D File Offset: 0x0044194D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValNotify CombatValNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.CombatValNotify)
				{
					return null;
				}
				return (CombatValNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.CombatValNotify);
			}
		}

		// Token: 0x170063D3 RID: 25555
		// (get) Token: 0x0601D77C RID: 120700 RVA: 0x00443764 File Offset: 0x00441964
		// (set) Token: 0x0601D77D RID: 120701 RVA: 0x0044377D File Offset: 0x0044197D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValDecayBeginNotify CombatValDecayBeginNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify)
				{
					return null;
				}
				return (CombatValDecayBeginNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify);
			}
		}

		// Token: 0x170063D4 RID: 25556
		// (get) Token: 0x0601D77E RID: 120702 RVA: 0x00443794 File Offset: 0x00441994
		// (set) Token: 0x0601D77F RID: 120703 RVA: 0x004437AD File Offset: 0x004419AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropChangedNotify SquadPropChangedNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.SquadPropChangedNotify)
				{
					return null;
				}
				return (SquadPropChangedNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.SquadPropChangedNotify);
			}
		}

		// Token: 0x170063D5 RID: 25557
		// (get) Token: 0x0601D780 RID: 120704 RVA: 0x004437C4 File Offset: 0x004419C4
		// (set) Token: 0x0601D781 RID: 120705 RVA: 0x004437DD File Offset: 0x004419DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageShowNotify DamageShowNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.DamageShowNotify)
				{
					return null;
				}
				return (DamageShowNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.DamageShowNotify);
			}
		}

		// Token: 0x170063D6 RID: 25558
		// (get) Token: 0x0601D782 RID: 120706 RVA: 0x004437F4 File Offset: 0x004419F4
		// (set) Token: 0x0601D783 RID: 120707 RVA: 0x0044380D File Offset: 0x00441A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxNotify CombatDataMaxNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.CombatDataMaxNotify)
				{
					return null;
				}
				return (CombatDataMaxNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.CombatDataMaxNotify);
			}
		}

		// Token: 0x170063D7 RID: 25559
		// (get) Token: 0x0601D784 RID: 120708 RVA: 0x00443824 File Offset: 0x00441A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601D785 RID: 120709 RVA: 0x0044382C File Offset: 0x00441A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatNotifyData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601D786 RID: 120710 RVA: 0x0044383C File Offset: 0x00441A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatNotifyData);
		}

		// Token: 0x0601D787 RID: 120711 RVA: 0x0044384C File Offset: 0x00441A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatNotifyData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.CreateBulletNotify, other.CreateBulletNotify) && object.Equals(this.DestroyBulletNotify, other.DestroyBulletNotify) && object.Equals(this.DamageExecuteNotify, other.DamageExecuteNotify) && object.Equals(this.ApplyGameplayEffectNotify, other.ApplyGameplayEffectNotify) && object.Equals(this.RemoveGameplayEffectNotify, other.RemoveGameplayEffectNotify) && object.Equals(this.HitNotify, other.HitNotify) && object.Equals(this.SkillNotify, other.SkillNotify) && object.Equals(this.UseSkillNotify, other.UseSkillNotify) && object.Equals(this.EndSkillNotify, other.EndSkillNotify) && object.Equals(this.EntityLoadCompleteNotify, other.EntityLoadCompleteNotify) && object.Equals(this.PartUpdateNotify, other.PartUpdateNotify) && object.Equals(this.PartComponentInitNotify, other.PartComponentInitNotify) && object.Equals(this.MaterialNotify, other.MaterialNotify) && object.Equals(this.GameplayCueNotify, other.GameplayCueNotify) && object.Equals(this.EntityIsVisibleNotify, other.EntityIsVisibleNotify) && object.Equals(this.SwitchCharacterStateNotify, other.SwitchCharacterStateNotify) && object.Equals(this.PlayerRebackSceneNotify, other.PlayerRebackSceneNotify) && object.Equals(this.LogicStateInitNotify, other.LogicStateInitNotify) && object.Equals(this.SwitchLogicStateNotify, other.SwitchLogicStateNotify) && object.Equals(this.AttributeChangedNotify, other.AttributeChangedNotify) && object.Equals(this.AnimationStateChangedNotify, other.AnimationStateChangedNotify) && object.Equals(this.AnimationStateInitNotify, other.AnimationStateInitNotify) && object.Equals(this.ModifyBulletParamsNotify, other.ModifyBulletParamsNotify) && object.Equals(this.DrownNotify, other.DrownNotify) && object.Equals(this.OrderApplyBuffNotify, other.OrderApplyBuffNotify) && object.Equals(this.OrderRemoveBuffNotify, other.OrderRemoveBuffNotify) && object.Equals(this.ActivateBuffNotify, other.ActivateBuffNotify) && object.Equals(this.OrderRemoveBuffByTagsNotify, other.OrderRemoveBuffByTagsNotify) && object.Equals(this.AiInformationNotify, other.AiInformationNotify) && object.Equals(this.BattleStateChangeNotify, other.BattleStateChangeNotify) && object.Equals(this.AnimationGameplayTagNotify, other.AnimationGameplayTagNotify) && object.Equals(this.BoneVisibleChangeNotify, other.BoneVisibleChangeNotify) && object.Equals(this.AiBlackboardCdNotify, other.AiBlackboardCdNotify) && object.Equals(this.CaughtNotify, other.CaughtNotify) && object.Equals(this.EntityStaticHookMoveNotify, other.EntityStaticHookMoveNotify) && object.Equals(this.ChangeStateNotify, other.ChangeStateNotify) && object.Equals(this.ChangeStateConfirmNotify, other.ChangeStateConfirmNotify) && object.Equals(this.BuffStackCountNotify, other.BuffStackCountNotify) && object.Equals(this.MontagePlayNotify, other.MontagePlayNotify) && object.Equals(this.ANStartNotify, other.ANStartNotify) && object.Equals(this.FsmResetNotify, other.FsmResetNotify) && object.Equals(this.DamageRecordNotify, other.DamageRecordNotify) && object.Equals(this.AiHateNotify, other.AiHateNotify) && object.Equals(this.FsmBlackboardNotify, other.FsmBlackboardNotify) && object.Equals(this.CharacterBattleStateChangeNotify, other.CharacterBattleStateChangeNotify) && object.Equals(this.ApplyBuffS2CRequestNotify, other.ApplyBuffS2CRequestNotify) && object.Equals(this.RemoveBuffS2CRequestNotify, other.RemoveBuffS2CRequestNotify) && object.Equals(this.ActorVisibleNotify, other.ActorVisibleNotify) && object.Equals(this.RecoverPropChangedNotify, other.RecoverPropChangedNotify) && object.Equals(this.RemoveBuffByIdS2CRequestNotify, other.RemoveBuffByIdS2CRequestNotify) && object.Equals(this.ShieldUpdateNotify, other.ShieldUpdateNotify) && object.Equals(this.PlayerBattleStateChangeNotify, other.PlayerBattleStateChangeNotify) && object.Equals(this.FsmCustomBlackboardNotify, other.FsmCustomBlackboardNotify) && object.Equals(this.PassiveSkillAddNotify, other.PassiveSkillAddNotify) && object.Equals(this.PassiveSkillRemoveNotify, other.PassiveSkillRemoveNotify) && object.Equals(this.ExecuteQteNotify, other.ExecuteQteNotify) && object.Equals(this.ModifyEntityCampNotify, other.ModifyEntityCampNotify) && object.Equals(this.AddCombineEntitiesRelationNotify, other.AddCombineEntitiesRelationNotify) && object.Equals(this.RemoveCombineRelationNotify, other.RemoveCombineRelationNotify) && object.Equals(this.TestDamageRecordNotify, other.TestDamageRecordNotify) && object.Equals(this.BuffDurationNotify, other.BuffDurationNotify) && object.Equals(this.EntityLivingStatusNotify, other.EntityLivingStatusNotify) && object.Equals(this.NewLinkNotify, other.NewLinkNotify) && object.Equals(this.ApplyBuffFailedNotify, other.ApplyBuffFailedNotify) && object.Equals(this.PackAnimChangedNotify, other.PackAnimChangedNotify) && object.Equals(this.VisionTriggerNotify, other.VisionTriggerNotify) && object.Equals(this.RemoveBuffByServerIdS2CRequestNotify, other.RemoveBuffByServerIdS2CRequestNotify) && object.Equals(this.TransformBuffStackNotify, other.TransformBuffStackNotify) && object.Equals(this.MotorSummonAndRideNotify, other.MotorSummonAndRideNotify) && object.Equals(this.BulletPatternNotify, other.BulletPatternNotify) && object.Equals(this.FsmMontageDurationNotify, other.FsmMontageDurationNotify) && object.Equals(this.CombatValNotify, other.CombatValNotify) && object.Equals(this.CombatValDecayBeginNotify, other.CombatValDecayBeginNotify) && object.Equals(this.SquadPropChangedNotify, other.SquadPropChangedNotify) && object.Equals(this.DamageShowNotify, other.DamageShowNotify) && object.Equals(this.CombatDataMaxNotify, other.CombatDataMaxNotify) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D788 RID: 120712 RVA: 0x00443ED8 File Offset: 0x004420D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CreateBulletNotify)
			{
				num ^= this.CreateBulletNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DestroyBulletNotify)
			{
				num ^= this.DestroyBulletNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageExecuteNotify)
			{
				num ^= this.DamageExecuteNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify)
			{
				num ^= this.ApplyGameplayEffectNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify)
			{
				num ^= this.RemoveGameplayEffectNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.HitNotify)
			{
				num ^= this.HitNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SkillNotify)
			{
				num ^= this.SkillNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.UseSkillNotify)
			{
				num ^= this.UseSkillNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EndSkillNotify)
			{
				num ^= this.EndSkillNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify)
			{
				num ^= this.EntityLoadCompleteNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartUpdateNotify)
			{
				num ^= this.PartUpdateNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartComponentInitNotify)
			{
				num ^= this.PartComponentInitNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MaterialNotify)
			{
				num ^= this.MaterialNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.GameplayCueNotify)
			{
				num ^= this.GameplayCueNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify)
			{
				num ^= this.EntityIsVisibleNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify)
			{
				num ^= this.SwitchCharacterStateNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify)
			{
				num ^= this.PlayerRebackSceneNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.LogicStateInitNotify)
			{
				num ^= this.LogicStateInitNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify)
			{
				num ^= this.SwitchLogicStateNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AttributeChangedNotify)
			{
				num ^= this.AttributeChangedNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify)
			{
				num ^= this.AnimationStateChangedNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateInitNotify)
			{
				num ^= this.AnimationStateInitNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify)
			{
				num ^= this.ModifyBulletParamsNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DrownNotify)
			{
				num ^= this.DrownNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify)
			{
				num ^= this.OrderApplyBuffNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify)
			{
				num ^= this.OrderRemoveBuffNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActivateBuffNotify)
			{
				num ^= this.ActivateBuffNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify)
			{
				num ^= this.OrderRemoveBuffByTagsNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiInformationNotify)
			{
				num ^= this.AiInformationNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BattleStateChangeNotify)
			{
				num ^= this.BattleStateChangeNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify)
			{
				num ^= this.AnimationGameplayTagNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify)
			{
				num ^= this.BoneVisibleChangeNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify)
			{
				num ^= this.AiBlackboardCdNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CaughtNotify)
			{
				num ^= this.CaughtNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify)
			{
				num ^= this.EntityStaticHookMoveNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateNotify)
			{
				num ^= this.ChangeStateNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify)
			{
				num ^= this.ChangeStateConfirmNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffStackCountNotify)
			{
				num ^= this.BuffStackCountNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MontagePlayNotify)
			{
				num ^= this.MontagePlayNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ANStartNotify)
			{
				num ^= this.ANStartNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmResetNotify)
			{
				num ^= this.FsmResetNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageRecordNotify)
			{
				num ^= this.DamageRecordNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiHateNotify)
			{
				num ^= this.AiHateNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmBlackboardNotify)
			{
				num ^= this.FsmBlackboardNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify)
			{
				num ^= this.CharacterBattleStateChangeNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify)
			{
				num ^= this.ApplyBuffS2CRequestNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify)
			{
				num ^= this.RemoveBuffS2CRequestNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActorVisibleNotify)
			{
				num ^= this.ActorVisibleNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify)
			{
				num ^= this.RecoverPropChangedNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify)
			{
				num ^= this.RemoveBuffByIdS2CRequestNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ShieldUpdateNotify)
			{
				num ^= this.ShieldUpdateNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify)
			{
				num ^= this.PlayerBattleStateChangeNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify)
			{
				num ^= this.FsmCustomBlackboardNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify)
			{
				num ^= this.PassiveSkillAddNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify)
			{
				num ^= this.PassiveSkillRemoveNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ExecuteQteNotify)
			{
				num ^= this.ExecuteQteNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify)
			{
				num ^= this.ModifyEntityCampNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify)
			{
				num ^= this.AddCombineEntitiesRelationNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify)
			{
				num ^= this.RemoveCombineRelationNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TestDamageRecordNotify)
			{
				num ^= this.TestDamageRecordNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffDurationNotify)
			{
				num ^= this.BuffDurationNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify)
			{
				num ^= this.EntityLivingStatusNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.NewLinkNotify)
			{
				num ^= this.NewLinkNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify)
			{
				num ^= this.ApplyBuffFailedNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PackAnimChangedNotify)
			{
				num ^= this.PackAnimChangedNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.VisionTriggerNotify)
			{
				num ^= this.VisionTriggerNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify)
			{
				num ^= this.RemoveBuffByServerIdS2CRequestNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TransformBuffStackNotify)
			{
				num ^= this.TransformBuffStackNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify)
			{
				num ^= this.MotorSummonAndRideNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BulletPatternNotify)
			{
				num ^= this.BulletPatternNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify)
			{
				num ^= this.FsmMontageDurationNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValNotify)
			{
				num ^= this.CombatValNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify)
			{
				num ^= this.CombatValDecayBeginNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SquadPropChangedNotify)
			{
				num ^= this.SquadPropChangedNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageShowNotify)
			{
				num ^= this.DamageShowNotify.GetHashCode();
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatDataMaxNotify)
			{
				num ^= this.CombatDataMaxNotify.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D789 RID: 120713 RVA: 0x00444636 File Offset: 0x00442836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D78A RID: 120714 RVA: 0x00444643 File Offset: 0x00442843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D78B RID: 120715 RVA: 0x0044464C File Offset: 0x0044284C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CreateBulletNotify)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CreateBulletNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DestroyBulletNotify)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.DestroyBulletNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageExecuteNotify)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.DamageExecuteNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ApplyGameplayEffectNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RemoveGameplayEffectNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.HitNotify)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.HitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SkillNotify)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SkillNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.UseSkillNotify)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.UseSkillNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EndSkillNotify)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EndSkillNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.EntityLoadCompleteNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartUpdateNotify)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PartUpdateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartComponentInitNotify)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PartComponentInitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MaterialNotify)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.MaterialNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.GameplayCueNotify)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.GameplayCueNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.EntityIsVisibleNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.SwitchCharacterStateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.PlayerRebackSceneNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.LogicStateInitNotify)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.LogicStateInitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.SwitchLogicStateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AttributeChangedNotify)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.AttributeChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.AnimationStateChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateInitNotify)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.AnimationStateInitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.ModifyBulletParamsNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DrownNotify)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.DrownNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.OrderApplyBuffNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.OrderRemoveBuffNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActivateBuffNotify)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.ActivateBuffNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.OrderRemoveBuffByTagsNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiInformationNotify)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.AiInformationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BattleStateChangeNotify)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.BattleStateChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.AnimationGameplayTagNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.BoneVisibleChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.AiBlackboardCdNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CaughtNotify)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.CaughtNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.EntityStaticHookMoveNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateNotify)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.ChangeStateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.ChangeStateConfirmNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffStackCountNotify)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.BuffStackCountNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MontagePlayNotify)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.MontagePlayNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ANStartNotify)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.ANStartNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmResetNotify)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.FsmResetNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageRecordNotify)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.DamageRecordNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiHateNotify)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.AiHateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmBlackboardNotify)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.FsmBlackboardNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify)
			{
				output.WriteRawTag(130, 3);
				output.WriteMessage(this.CharacterBattleStateChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify)
			{
				output.WriteRawTag(170, 3);
				output.WriteMessage(this.ApplyBuffS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify)
			{
				output.WriteRawTag(178, 3);
				output.WriteMessage(this.RemoveBuffS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActorVisibleNotify)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.ActorVisibleNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.RecoverPropChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.RemoveBuffByIdS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ShieldUpdateNotify)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.ShieldUpdateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.PlayerBattleStateChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.FsmCustomBlackboardNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.PassiveSkillAddNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.PassiveSkillRemoveNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ExecuteQteNotify)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.ExecuteQteNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.ModifyEntityCampNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify)
			{
				output.WriteRawTag(178, 4);
				output.WriteMessage(this.AddCombineEntitiesRelationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.RemoveCombineRelationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TestDamageRecordNotify)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.TestDamageRecordNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffDurationNotify)
			{
				output.WriteRawTag(202, 4);
				output.WriteMessage(this.BuffDurationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify)
			{
				output.WriteRawTag(210, 4);
				output.WriteMessage(this.EntityLivingStatusNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.NewLinkNotify)
			{
				output.WriteRawTag(218, 4);
				output.WriteMessage(this.NewLinkNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify)
			{
				output.WriteRawTag(226, 4);
				output.WriteMessage(this.ApplyBuffFailedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PackAnimChangedNotify)
			{
				output.WriteRawTag(234, 4);
				output.WriteMessage(this.PackAnimChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.VisionTriggerNotify)
			{
				output.WriteRawTag(242, 4);
				output.WriteMessage(this.VisionTriggerNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify)
			{
				output.WriteRawTag(250, 4);
				output.WriteMessage(this.RemoveBuffByServerIdS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TransformBuffStackNotify)
			{
				output.WriteRawTag(130, 5);
				output.WriteMessage(this.TransformBuffStackNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify)
			{
				output.WriteRawTag(138, 5);
				output.WriteMessage(this.MotorSummonAndRideNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BulletPatternNotify)
			{
				output.WriteRawTag(146, 5);
				output.WriteMessage(this.BulletPatternNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify)
			{
				output.WriteRawTag(154, 5);
				output.WriteMessage(this.FsmMontageDurationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValNotify)
			{
				output.WriteRawTag(170, 5);
				output.WriteMessage(this.CombatValNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify)
			{
				output.WriteRawTag(178, 5);
				output.WriteMessage(this.CombatValDecayBeginNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SquadPropChangedNotify)
			{
				output.WriteRawTag(186, 5);
				output.WriteMessage(this.SquadPropChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageShowNotify)
			{
				output.WriteRawTag(194, 5);
				output.WriteMessage(this.DamageShowNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatDataMaxNotify)
			{
				output.WriteRawTag(162, 6);
				output.WriteMessage(this.CombatDataMaxNotify);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D78C RID: 120716 RVA: 0x00445068 File Offset: 0x00443268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CreateBulletNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CreateBulletNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DestroyBulletNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DestroyBulletNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageExecuteNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageExecuteNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApplyGameplayEffectNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveGameplayEffectNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.HitNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SkillNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.UseSkillNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EndSkillNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndSkillNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityLoadCompleteNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartUpdateNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartUpdateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartComponentInitNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartComponentInitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MaterialNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MaterialNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.GameplayCueNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GameplayCueNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityIsVisibleNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchCharacterStateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayerRebackSceneNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.LogicStateInitNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LogicStateInitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchLogicStateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AttributeChangedNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AttributeChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateInitNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateInitNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParamsNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DrownNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderApplyBuffNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActivateBuffNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActivateBuffNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffByTagsNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiInformationNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiInformationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BattleStateChangeNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BattleStateChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationGameplayTagNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardCdNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CaughtNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CaughtNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityStaticHookMoveNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateConfirmNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffStackCountNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffStackCountNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MontagePlayNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MontagePlayNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ANStartNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ANStartNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmResetNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmResetNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageRecordNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DamageRecordNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiHateNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiHateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmBlackboardNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmBlackboardNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CharacterBattleStateChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ApplyBuffS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveBuffS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActorVisibleNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActorVisibleNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RecoverPropChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveBuffByIdS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ShieldUpdateNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ShieldUpdateNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayerBattleStateChangeNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmCustomBlackboardNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillAddNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillRemoveNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ExecuteQteNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExecuteQteNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ModifyEntityCampNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AddCombineEntitiesRelationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveCombineRelationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TestDamageRecordNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TestDamageRecordNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffDurationNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffDurationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityLivingStatusNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.NewLinkNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewLinkNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ApplyBuffFailedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PackAnimChangedNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PackAnimChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.VisionTriggerNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VisionTriggerNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveBuffByServerIdS2CRequestNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TransformBuffStackNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TransformBuffStackNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorSummonAndRideNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BulletPatternNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BulletPatternNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmMontageDurationNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombatValNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombatValDecayBeginNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SquadPropChangedNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SquadPropChangedNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageShowNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DamageShowNotify);
			}
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatDataMaxNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombatDataMaxNotify);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D78D RID: 120717 RVA: 0x00445858 File Offset: 0x00443A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatNotifyData other)
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
			switch (other.MessageCase)
			{
			case CombatNotifyData.MessageOneofCase.CreateBulletNotify:
				if (this.CreateBulletNotify == null)
				{
					this.CreateBulletNotify = new CreateBulletNotify();
				}
				this.CreateBulletNotify.MergeFrom(other.CreateBulletNotify);
				break;
			case CombatNotifyData.MessageOneofCase.DestroyBulletNotify:
				if (this.DestroyBulletNotify == null)
				{
					this.DestroyBulletNotify = new DestroyBulletNotify();
				}
				this.DestroyBulletNotify.MergeFrom(other.DestroyBulletNotify);
				break;
			case CombatNotifyData.MessageOneofCase.DamageExecuteNotify:
				if (this.DamageExecuteNotify == null)
				{
					this.DamageExecuteNotify = new DamageExecuteNotify();
				}
				this.DamageExecuteNotify.MergeFrom(other.DamageExecuteNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify:
				if (this.ApplyGameplayEffectNotify == null)
				{
					this.ApplyGameplayEffectNotify = new ApplyGameplayEffectNotify();
				}
				this.ApplyGameplayEffectNotify.MergeFrom(other.ApplyGameplayEffectNotify);
				break;
			case CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify:
				if (this.RemoveGameplayEffectNotify == null)
				{
					this.RemoveGameplayEffectNotify = new RemoveGameplayEffectNotify();
				}
				this.RemoveGameplayEffectNotify.MergeFrom(other.RemoveGameplayEffectNotify);
				break;
			case CombatNotifyData.MessageOneofCase.HitNotify:
				if (this.HitNotify == null)
				{
					this.HitNotify = new HitNotify();
				}
				this.HitNotify.MergeFrom(other.HitNotify);
				break;
			case CombatNotifyData.MessageOneofCase.SkillNotify:
				if (this.SkillNotify == null)
				{
					this.SkillNotify = new SkillNotify();
				}
				this.SkillNotify.MergeFrom(other.SkillNotify);
				break;
			case CombatNotifyData.MessageOneofCase.UseSkillNotify:
				if (this.UseSkillNotify == null)
				{
					this.UseSkillNotify = new UseSkillNotify();
				}
				this.UseSkillNotify.MergeFrom(other.UseSkillNotify);
				break;
			case CombatNotifyData.MessageOneofCase.EndSkillNotify:
				if (this.EndSkillNotify == null)
				{
					this.EndSkillNotify = new EndSkillNotify();
				}
				this.EndSkillNotify.MergeFrom(other.EndSkillNotify);
				break;
			case CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify:
				if (this.EntityLoadCompleteNotify == null)
				{
					this.EntityLoadCompleteNotify = new EntityLoadCompleteNotify();
				}
				this.EntityLoadCompleteNotify.MergeFrom(other.EntityLoadCompleteNotify);
				break;
			case CombatNotifyData.MessageOneofCase.PartUpdateNotify:
				if (this.PartUpdateNotify == null)
				{
					this.PartUpdateNotify = new PartUpdateNotify();
				}
				this.PartUpdateNotify.MergeFrom(other.PartUpdateNotify);
				break;
			case CombatNotifyData.MessageOneofCase.PartComponentInitNotify:
				if (this.PartComponentInitNotify == null)
				{
					this.PartComponentInitNotify = new PartComponentInitNotify();
				}
				this.PartComponentInitNotify.MergeFrom(other.PartComponentInitNotify);
				break;
			case CombatNotifyData.MessageOneofCase.MaterialNotify:
				if (this.MaterialNotify == null)
				{
					this.MaterialNotify = new MaterialNotify();
				}
				this.MaterialNotify.MergeFrom(other.MaterialNotify);
				break;
			case CombatNotifyData.MessageOneofCase.GameplayCueNotify:
				if (this.GameplayCueNotify == null)
				{
					this.GameplayCueNotify = new GameplayCueNotify();
				}
				this.GameplayCueNotify.MergeFrom(other.GameplayCueNotify);
				break;
			case CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify:
				if (this.EntityIsVisibleNotify == null)
				{
					this.EntityIsVisibleNotify = new EntityIsVisibleNotify();
				}
				this.EntityIsVisibleNotify.MergeFrom(other.EntityIsVisibleNotify);
				break;
			case CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify:
				if (this.SwitchCharacterStateNotify == null)
				{
					this.SwitchCharacterStateNotify = new SwitchCharacterStateNotify();
				}
				this.SwitchCharacterStateNotify.MergeFrom(other.SwitchCharacterStateNotify);
				break;
			case CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify:
				if (this.PlayerRebackSceneNotify == null)
				{
					this.PlayerRebackSceneNotify = new PlayerRebackSceneNotify();
				}
				this.PlayerRebackSceneNotify.MergeFrom(other.PlayerRebackSceneNotify);
				break;
			case CombatNotifyData.MessageOneofCase.LogicStateInitNotify:
				if (this.LogicStateInitNotify == null)
				{
					this.LogicStateInitNotify = new LogicStateInitNotify();
				}
				this.LogicStateInitNotify.MergeFrom(other.LogicStateInitNotify);
				break;
			case CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify:
				if (this.SwitchLogicStateNotify == null)
				{
					this.SwitchLogicStateNotify = new SwitchLogicStateNotify();
				}
				this.SwitchLogicStateNotify.MergeFrom(other.SwitchLogicStateNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AttributeChangedNotify:
				if (this.AttributeChangedNotify == null)
				{
					this.AttributeChangedNotify = new AttributeChangedNotify();
				}
				this.AttributeChangedNotify.MergeFrom(other.AttributeChangedNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify:
				if (this.AnimationStateChangedNotify == null)
				{
					this.AnimationStateChangedNotify = new AnimationStateChangedNotify();
				}
				this.AnimationStateChangedNotify.MergeFrom(other.AnimationStateChangedNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AnimationStateInitNotify:
				if (this.AnimationStateInitNotify == null)
				{
					this.AnimationStateInitNotify = new AnimationStateInitNotify();
				}
				this.AnimationStateInitNotify.MergeFrom(other.AnimationStateInitNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify:
				if (this.ModifyBulletParamsNotify == null)
				{
					this.ModifyBulletParamsNotify = new ModifyBulletParamsNotify();
				}
				this.ModifyBulletParamsNotify.MergeFrom(other.ModifyBulletParamsNotify);
				break;
			case CombatNotifyData.MessageOneofCase.DrownNotify:
				if (this.DrownNotify == null)
				{
					this.DrownNotify = new DrownNotify();
				}
				this.DrownNotify.MergeFrom(other.DrownNotify);
				break;
			case CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify:
				if (this.OrderApplyBuffNotify == null)
				{
					this.OrderApplyBuffNotify = new OrderApplyBuffNotify();
				}
				this.OrderApplyBuffNotify.MergeFrom(other.OrderApplyBuffNotify);
				break;
			case CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify:
				if (this.OrderRemoveBuffNotify == null)
				{
					this.OrderRemoveBuffNotify = new OrderRemoveBuffNotify();
				}
				this.OrderRemoveBuffNotify.MergeFrom(other.OrderRemoveBuffNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ActivateBuffNotify:
				if (this.ActivateBuffNotify == null)
				{
					this.ActivateBuffNotify = new ActivateBuffNotify();
				}
				this.ActivateBuffNotify.MergeFrom(other.ActivateBuffNotify);
				break;
			case CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify:
				if (this.OrderRemoveBuffByTagsNotify == null)
				{
					this.OrderRemoveBuffByTagsNotify = new OrderRemoveBuffByTagsNotify();
				}
				this.OrderRemoveBuffByTagsNotify.MergeFrom(other.OrderRemoveBuffByTagsNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AiInformationNotify:
				if (this.AiInformationNotify == null)
				{
					this.AiInformationNotify = new AiInformationNotify();
				}
				this.AiInformationNotify.MergeFrom(other.AiInformationNotify);
				break;
			case CombatNotifyData.MessageOneofCase.BattleStateChangeNotify:
				if (this.BattleStateChangeNotify == null)
				{
					this.BattleStateChangeNotify = new BattleStateChangeNotify();
				}
				this.BattleStateChangeNotify.MergeFrom(other.BattleStateChangeNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify:
				if (this.AnimationGameplayTagNotify == null)
				{
					this.AnimationGameplayTagNotify = new AnimationGameplayTagNotify();
				}
				this.AnimationGameplayTagNotify.MergeFrom(other.AnimationGameplayTagNotify);
				break;
			case CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify:
				if (this.BoneVisibleChangeNotify == null)
				{
					this.BoneVisibleChangeNotify = new BoneVisibleChangeNotify();
				}
				this.BoneVisibleChangeNotify.MergeFrom(other.BoneVisibleChangeNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify:
				if (this.AiBlackboardCdNotify == null)
				{
					this.AiBlackboardCdNotify = new AiBlackboardCdNotify();
				}
				this.AiBlackboardCdNotify.MergeFrom(other.AiBlackboardCdNotify);
				break;
			case CombatNotifyData.MessageOneofCase.CaughtNotify:
				if (this.CaughtNotify == null)
				{
					this.CaughtNotify = new CaughtNotify();
				}
				this.CaughtNotify.MergeFrom(other.CaughtNotify);
				break;
			case CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify:
				if (this.EntityStaticHookMoveNotify == null)
				{
					this.EntityStaticHookMoveNotify = new EntityStaticHookMoveNotify();
				}
				this.EntityStaticHookMoveNotify.MergeFrom(other.EntityStaticHookMoveNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ChangeStateNotify:
				if (this.ChangeStateNotify == null)
				{
					this.ChangeStateNotify = new ChangeStateNotify();
				}
				this.ChangeStateNotify.MergeFrom(other.ChangeStateNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify:
				if (this.ChangeStateConfirmNotify == null)
				{
					this.ChangeStateConfirmNotify = new ChangeStateConfirmNotify();
				}
				this.ChangeStateConfirmNotify.MergeFrom(other.ChangeStateConfirmNotify);
				break;
			case CombatNotifyData.MessageOneofCase.BuffStackCountNotify:
				if (this.BuffStackCountNotify == null)
				{
					this.BuffStackCountNotify = new BuffStackCountNotify();
				}
				this.BuffStackCountNotify.MergeFrom(other.BuffStackCountNotify);
				break;
			case CombatNotifyData.MessageOneofCase.MontagePlayNotify:
				if (this.MontagePlayNotify == null)
				{
					this.MontagePlayNotify = new MontagePlayNotify();
				}
				this.MontagePlayNotify.MergeFrom(other.MontagePlayNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ANStartNotify:
				if (this.ANStartNotify == null)
				{
					this.ANStartNotify = new ANStartNotify();
				}
				this.ANStartNotify.MergeFrom(other.ANStartNotify);
				break;
			case CombatNotifyData.MessageOneofCase.FsmResetNotify:
				if (this.FsmResetNotify == null)
				{
					this.FsmResetNotify = new FsmResetNotify();
				}
				this.FsmResetNotify.MergeFrom(other.FsmResetNotify);
				break;
			case CombatNotifyData.MessageOneofCase.DamageRecordNotify:
				if (this.DamageRecordNotify == null)
				{
					this.DamageRecordNotify = new DamageRecordNotify();
				}
				this.DamageRecordNotify.MergeFrom(other.DamageRecordNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AiHateNotify:
				if (this.AiHateNotify == null)
				{
					this.AiHateNotify = new AiHateNotify();
				}
				this.AiHateNotify.MergeFrom(other.AiHateNotify);
				break;
			case CombatNotifyData.MessageOneofCase.FsmBlackboardNotify:
				if (this.FsmBlackboardNotify == null)
				{
					this.FsmBlackboardNotify = new FsmBlackboardNotify();
				}
				this.FsmBlackboardNotify.MergeFrom(other.FsmBlackboardNotify);
				break;
			case CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify:
				if (this.CharacterBattleStateChangeNotify == null)
				{
					this.CharacterBattleStateChangeNotify = new CharacterBattleStateChangeNotify();
				}
				this.CharacterBattleStateChangeNotify.MergeFrom(other.CharacterBattleStateChangeNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify:
				if (this.ApplyBuffS2CRequestNotify == null)
				{
					this.ApplyBuffS2CRequestNotify = new ApplyBuffS2cRequestNotify();
				}
				this.ApplyBuffS2CRequestNotify.MergeFrom(other.ApplyBuffS2CRequestNotify);
				break;
			case CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify:
				if (this.RemoveBuffS2CRequestNotify == null)
				{
					this.RemoveBuffS2CRequestNotify = new RemoveBuffS2cRequestNotify();
				}
				this.RemoveBuffS2CRequestNotify.MergeFrom(other.RemoveBuffS2CRequestNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ActorVisibleNotify:
				if (this.ActorVisibleNotify == null)
				{
					this.ActorVisibleNotify = new ActorVisibleNotify();
				}
				this.ActorVisibleNotify.MergeFrom(other.ActorVisibleNotify);
				break;
			case CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify:
				if (this.RecoverPropChangedNotify == null)
				{
					this.RecoverPropChangedNotify = new RecoverPropChangedNotify();
				}
				this.RecoverPropChangedNotify.MergeFrom(other.RecoverPropChangedNotify);
				break;
			case CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify:
				if (this.RemoveBuffByIdS2CRequestNotify == null)
				{
					this.RemoveBuffByIdS2CRequestNotify = new RemoveBuffByIdS2cRequestNotify();
				}
				this.RemoveBuffByIdS2CRequestNotify.MergeFrom(other.RemoveBuffByIdS2CRequestNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ShieldUpdateNotify:
				if (this.ShieldUpdateNotify == null)
				{
					this.ShieldUpdateNotify = new ShieldUpdateNotify();
				}
				this.ShieldUpdateNotify.MergeFrom(other.ShieldUpdateNotify);
				break;
			case CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify:
				if (this.PlayerBattleStateChangeNotify == null)
				{
					this.PlayerBattleStateChangeNotify = new PlayerBattleStateChangeNotify();
				}
				this.PlayerBattleStateChangeNotify.MergeFrom(other.PlayerBattleStateChangeNotify);
				break;
			case CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify:
				if (this.FsmCustomBlackboardNotify == null)
				{
					this.FsmCustomBlackboardNotify = new FsmCustomBlackboardNotify();
				}
				this.FsmCustomBlackboardNotify.MergeFrom(other.FsmCustomBlackboardNotify);
				break;
			case CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify:
				if (this.PassiveSkillAddNotify == null)
				{
					this.PassiveSkillAddNotify = new PassiveSkillAddNotify();
				}
				this.PassiveSkillAddNotify.MergeFrom(other.PassiveSkillAddNotify);
				break;
			case CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify:
				if (this.PassiveSkillRemoveNotify == null)
				{
					this.PassiveSkillRemoveNotify = new PassiveSkillRemoveNotify();
				}
				this.PassiveSkillRemoveNotify.MergeFrom(other.PassiveSkillRemoveNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ExecuteQteNotify:
				if (this.ExecuteQteNotify == null)
				{
					this.ExecuteQteNotify = new ExecuteQteNotify();
				}
				this.ExecuteQteNotify.MergeFrom(other.ExecuteQteNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify:
				if (this.ModifyEntityCampNotify == null)
				{
					this.ModifyEntityCampNotify = new ModifyEntityCampNotify();
				}
				this.ModifyEntityCampNotify.MergeFrom(other.ModifyEntityCampNotify);
				break;
			case CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify:
				if (this.AddCombineEntitiesRelationNotify == null)
				{
					this.AddCombineEntitiesRelationNotify = new AddCombineEntitiesRelationNotify();
				}
				this.AddCombineEntitiesRelationNotify.MergeFrom(other.AddCombineEntitiesRelationNotify);
				break;
			case CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify:
				if (this.RemoveCombineRelationNotify == null)
				{
					this.RemoveCombineRelationNotify = new RemoveCombineRelationNotify();
				}
				this.RemoveCombineRelationNotify.MergeFrom(other.RemoveCombineRelationNotify);
				break;
			case CombatNotifyData.MessageOneofCase.TestDamageRecordNotify:
				if (this.TestDamageRecordNotify == null)
				{
					this.TestDamageRecordNotify = new TestDamageRecordNotify();
				}
				this.TestDamageRecordNotify.MergeFrom(other.TestDamageRecordNotify);
				break;
			case CombatNotifyData.MessageOneofCase.BuffDurationNotify:
				if (this.BuffDurationNotify == null)
				{
					this.BuffDurationNotify = new BuffDurationNotify();
				}
				this.BuffDurationNotify.MergeFrom(other.BuffDurationNotify);
				break;
			case CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify:
				if (this.EntityLivingStatusNotify == null)
				{
					this.EntityLivingStatusNotify = new EntityLivingStatusNotify();
				}
				this.EntityLivingStatusNotify.MergeFrom(other.EntityLivingStatusNotify);
				break;
			case CombatNotifyData.MessageOneofCase.NewLinkNotify:
				if (this.NewLinkNotify == null)
				{
					this.NewLinkNotify = new NewLinkNotify();
				}
				this.NewLinkNotify.MergeFrom(other.NewLinkNotify);
				break;
			case CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify:
				if (this.ApplyBuffFailedNotify == null)
				{
					this.ApplyBuffFailedNotify = new ApplyBuffFailedNotify();
				}
				this.ApplyBuffFailedNotify.MergeFrom(other.ApplyBuffFailedNotify);
				break;
			case CombatNotifyData.MessageOneofCase.PackAnimChangedNotify:
				if (this.PackAnimChangedNotify == null)
				{
					this.PackAnimChangedNotify = new PackAnimChangedNotify();
				}
				this.PackAnimChangedNotify.MergeFrom(other.PackAnimChangedNotify);
				break;
			case CombatNotifyData.MessageOneofCase.VisionTriggerNotify:
				if (this.VisionTriggerNotify == null)
				{
					this.VisionTriggerNotify = new VisionTriggerNotify();
				}
				this.VisionTriggerNotify.MergeFrom(other.VisionTriggerNotify);
				break;
			case CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify:
				if (this.RemoveBuffByServerIdS2CRequestNotify == null)
				{
					this.RemoveBuffByServerIdS2CRequestNotify = new RemoveBuffByServerIdS2cRequestNotify();
				}
				this.RemoveBuffByServerIdS2CRequestNotify.MergeFrom(other.RemoveBuffByServerIdS2CRequestNotify);
				break;
			case CombatNotifyData.MessageOneofCase.TransformBuffStackNotify:
				if (this.TransformBuffStackNotify == null)
				{
					this.TransformBuffStackNotify = new TransformBuffStackNotify();
				}
				this.TransformBuffStackNotify.MergeFrom(other.TransformBuffStackNotify);
				break;
			case CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify:
				if (this.MotorSummonAndRideNotify == null)
				{
					this.MotorSummonAndRideNotify = new MotorSummonAndRideNotify();
				}
				this.MotorSummonAndRideNotify.MergeFrom(other.MotorSummonAndRideNotify);
				break;
			case CombatNotifyData.MessageOneofCase.BulletPatternNotify:
				if (this.BulletPatternNotify == null)
				{
					this.BulletPatternNotify = new BulletPatternNotify();
				}
				this.BulletPatternNotify.MergeFrom(other.BulletPatternNotify);
				break;
			case CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify:
				if (this.FsmMontageDurationNotify == null)
				{
					this.FsmMontageDurationNotify = new FsmMontageDurationNotify();
				}
				this.FsmMontageDurationNotify.MergeFrom(other.FsmMontageDurationNotify);
				break;
			case CombatNotifyData.MessageOneofCase.CombatValNotify:
				if (this.CombatValNotify == null)
				{
					this.CombatValNotify = new CombatValNotify();
				}
				this.CombatValNotify.MergeFrom(other.CombatValNotify);
				break;
			case CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify:
				if (this.CombatValDecayBeginNotify == null)
				{
					this.CombatValDecayBeginNotify = new CombatValDecayBeginNotify();
				}
				this.CombatValDecayBeginNotify.MergeFrom(other.CombatValDecayBeginNotify);
				break;
			case CombatNotifyData.MessageOneofCase.SquadPropChangedNotify:
				if (this.SquadPropChangedNotify == null)
				{
					this.SquadPropChangedNotify = new SquadPropChangedNotify();
				}
				this.SquadPropChangedNotify.MergeFrom(other.SquadPropChangedNotify);
				break;
			case CombatNotifyData.MessageOneofCase.DamageShowNotify:
				if (this.DamageShowNotify == null)
				{
					this.DamageShowNotify = new DamageShowNotify();
				}
				this.DamageShowNotify.MergeFrom(other.DamageShowNotify);
				break;
			case CombatNotifyData.MessageOneofCase.CombatDataMaxNotify:
				if (this.CombatDataMaxNotify == null)
				{
					this.CombatDataMaxNotify = new CombatDataMaxNotify();
				}
				this.CombatDataMaxNotify.MergeFrom(other.CombatDataMaxNotify);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D78E RID: 120718 RVA: 0x0044666A File Offset: 0x0044486A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D78F RID: 120719 RVA: 0x00446674 File Offset: 0x00444874
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
				if (num <= 322U)
				{
					if (num <= 162U)
					{
						if (num <= 74U)
						{
							if (num <= 34U)
							{
								if (num <= 18U)
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
									if (num == 18U)
									{
										CreateBulletNotify createBulletNotify = new CreateBulletNotify();
										if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CreateBulletNotify)
										{
											createBulletNotify.MergeFrom(this.CreateBulletNotify);
										}
										input.ReadMessage(createBulletNotify);
										this.CreateBulletNotify = createBulletNotify;
										continue;
									}
								}
								else
								{
									if (num == 26U)
									{
										DestroyBulletNotify destroyBulletNotify = new DestroyBulletNotify();
										if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DestroyBulletNotify)
										{
											destroyBulletNotify.MergeFrom(this.DestroyBulletNotify);
										}
										input.ReadMessage(destroyBulletNotify);
										this.DestroyBulletNotify = destroyBulletNotify;
										continue;
									}
									if (num == 34U)
									{
										DamageExecuteNotify damageExecuteNotify = new DamageExecuteNotify();
										if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageExecuteNotify)
										{
											damageExecuteNotify.MergeFrom(this.DamageExecuteNotify);
										}
										input.ReadMessage(damageExecuteNotify);
										this.DamageExecuteNotify = damageExecuteNotify;
										continue;
									}
								}
							}
							else if (num <= 50U)
							{
								if (num == 42U)
								{
									ApplyGameplayEffectNotify applyGameplayEffectNotify = new ApplyGameplayEffectNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyGameplayEffectNotify)
									{
										applyGameplayEffectNotify.MergeFrom(this.ApplyGameplayEffectNotify);
									}
									input.ReadMessage(applyGameplayEffectNotify);
									this.ApplyGameplayEffectNotify = applyGameplayEffectNotify;
									continue;
								}
								if (num == 50U)
								{
									RemoveGameplayEffectNotify removeGameplayEffectNotify = new RemoveGameplayEffectNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveGameplayEffectNotify)
									{
										removeGameplayEffectNotify.MergeFrom(this.RemoveGameplayEffectNotify);
									}
									input.ReadMessage(removeGameplayEffectNotify);
									this.RemoveGameplayEffectNotify = removeGameplayEffectNotify;
									continue;
								}
							}
							else
							{
								if (num == 58U)
								{
									HitNotify hitNotify = new HitNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.HitNotify)
									{
										hitNotify.MergeFrom(this.HitNotify);
									}
									input.ReadMessage(hitNotify);
									this.HitNotify = hitNotify;
									continue;
								}
								if (num == 66U)
								{
									SkillNotify skillNotify = new SkillNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SkillNotify)
									{
										skillNotify.MergeFrom(this.SkillNotify);
									}
									input.ReadMessage(skillNotify);
									this.SkillNotify = skillNotify;
									continue;
								}
								if (num == 74U)
								{
									UseSkillNotify useSkillNotify = new UseSkillNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.UseSkillNotify)
									{
										useSkillNotify.MergeFrom(this.UseSkillNotify);
									}
									input.ReadMessage(useSkillNotify);
									this.UseSkillNotify = useSkillNotify;
									continue;
								}
							}
						}
						else if (num <= 122U)
						{
							if (num <= 90U)
							{
								if (num == 82U)
								{
									EndSkillNotify endSkillNotify = new EndSkillNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EndSkillNotify)
									{
										endSkillNotify.MergeFrom(this.EndSkillNotify);
									}
									input.ReadMessage(endSkillNotify);
									this.EndSkillNotify = endSkillNotify;
									continue;
								}
								if (num == 90U)
								{
									EntityLoadCompleteNotify entityLoadCompleteNotify = new EntityLoadCompleteNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLoadCompleteNotify)
									{
										entityLoadCompleteNotify.MergeFrom(this.EntityLoadCompleteNotify);
									}
									input.ReadMessage(entityLoadCompleteNotify);
									this.EntityLoadCompleteNotify = entityLoadCompleteNotify;
									continue;
								}
							}
							else
							{
								if (num == 98U)
								{
									PartUpdateNotify partUpdateNotify = new PartUpdateNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartUpdateNotify)
									{
										partUpdateNotify.MergeFrom(this.PartUpdateNotify);
									}
									input.ReadMessage(partUpdateNotify);
									this.PartUpdateNotify = partUpdateNotify;
									continue;
								}
								if (num == 114U)
								{
									PartComponentInitNotify partComponentInitNotify = new PartComponentInitNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PartComponentInitNotify)
									{
										partComponentInitNotify.MergeFrom(this.PartComponentInitNotify);
									}
									input.ReadMessage(partComponentInitNotify);
									this.PartComponentInitNotify = partComponentInitNotify;
									continue;
								}
								if (num == 122U)
								{
									MaterialNotify materialNotify = new MaterialNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MaterialNotify)
									{
										materialNotify.MergeFrom(this.MaterialNotify);
									}
									input.ReadMessage(materialNotify);
									this.MaterialNotify = materialNotify;
									continue;
								}
							}
						}
						else if (num <= 138U)
						{
							if (num == 130U)
							{
								GameplayCueNotify gameplayCueNotify = new GameplayCueNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.GameplayCueNotify)
								{
									gameplayCueNotify.MergeFrom(this.GameplayCueNotify);
								}
								input.ReadMessage(gameplayCueNotify);
								this.GameplayCueNotify = gameplayCueNotify;
								continue;
							}
							if (num == 138U)
							{
								EntityIsVisibleNotify entityIsVisibleNotify = new EntityIsVisibleNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityIsVisibleNotify)
								{
									entityIsVisibleNotify.MergeFrom(this.EntityIsVisibleNotify);
								}
								input.ReadMessage(entityIsVisibleNotify);
								this.EntityIsVisibleNotify = entityIsVisibleNotify;
								continue;
							}
						}
						else
						{
							if (num == 146U)
							{
								SwitchCharacterStateNotify switchCharacterStateNotify = new SwitchCharacterStateNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchCharacterStateNotify)
								{
									switchCharacterStateNotify.MergeFrom(this.SwitchCharacterStateNotify);
								}
								input.ReadMessage(switchCharacterStateNotify);
								this.SwitchCharacterStateNotify = switchCharacterStateNotify;
								continue;
							}
							if (num == 154U)
							{
								PlayerRebackSceneNotify playerRebackSceneNotify = new PlayerRebackSceneNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerRebackSceneNotify)
								{
									playerRebackSceneNotify.MergeFrom(this.PlayerRebackSceneNotify);
								}
								input.ReadMessage(playerRebackSceneNotify);
								this.PlayerRebackSceneNotify = playerRebackSceneNotify;
								continue;
							}
							if (num == 162U)
							{
								LogicStateInitNotify logicStateInitNotify = new LogicStateInitNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.LogicStateInitNotify)
								{
									logicStateInitNotify.MergeFrom(this.LogicStateInitNotify);
								}
								input.ReadMessage(logicStateInitNotify);
								this.LogicStateInitNotify = logicStateInitNotify;
								continue;
							}
						}
					}
					else if (num <= 234U)
					{
						if (num <= 194U)
						{
							if (num <= 178U)
							{
								if (num == 170U)
								{
									SwitchLogicStateNotify switchLogicStateNotify = new SwitchLogicStateNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchLogicStateNotify)
									{
										switchLogicStateNotify.MergeFrom(this.SwitchLogicStateNotify);
									}
									input.ReadMessage(switchLogicStateNotify);
									this.SwitchLogicStateNotify = switchLogicStateNotify;
									continue;
								}
								if (num == 178U)
								{
									AttributeChangedNotify attributeChangedNotify = new AttributeChangedNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AttributeChangedNotify)
									{
										attributeChangedNotify.MergeFrom(this.AttributeChangedNotify);
									}
									input.ReadMessage(attributeChangedNotify);
									this.AttributeChangedNotify = attributeChangedNotify;
									continue;
								}
							}
							else
							{
								if (num == 186U)
								{
									AnimationStateChangedNotify animationStateChangedNotify = new AnimationStateChangedNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateChangedNotify)
									{
										animationStateChangedNotify.MergeFrom(this.AnimationStateChangedNotify);
									}
									input.ReadMessage(animationStateChangedNotify);
									this.AnimationStateChangedNotify = animationStateChangedNotify;
									continue;
								}
								if (num == 194U)
								{
									AnimationStateInitNotify animationStateInitNotify = new AnimationStateInitNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationStateInitNotify)
									{
										animationStateInitNotify.MergeFrom(this.AnimationStateInitNotify);
									}
									input.ReadMessage(animationStateInitNotify);
									this.AnimationStateInitNotify = animationStateInitNotify;
									continue;
								}
							}
						}
						else if (num <= 210U)
						{
							if (num == 202U)
							{
								ModifyBulletParamsNotify modifyBulletParamsNotify = new ModifyBulletParamsNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyBulletParamsNotify)
								{
									modifyBulletParamsNotify.MergeFrom(this.ModifyBulletParamsNotify);
								}
								input.ReadMessage(modifyBulletParamsNotify);
								this.ModifyBulletParamsNotify = modifyBulletParamsNotify;
								continue;
							}
							if (num == 210U)
							{
								DrownNotify drownNotify = new DrownNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DrownNotify)
								{
									drownNotify.MergeFrom(this.DrownNotify);
								}
								input.ReadMessage(drownNotify);
								this.DrownNotify = drownNotify;
								continue;
							}
						}
						else
						{
							if (num == 218U)
							{
								OrderApplyBuffNotify orderApplyBuffNotify = new OrderApplyBuffNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderApplyBuffNotify)
								{
									orderApplyBuffNotify.MergeFrom(this.OrderApplyBuffNotify);
								}
								input.ReadMessage(orderApplyBuffNotify);
								this.OrderApplyBuffNotify = orderApplyBuffNotify;
								continue;
							}
							if (num == 226U)
							{
								OrderRemoveBuffNotify orderRemoveBuffNotify = new OrderRemoveBuffNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffNotify)
								{
									orderRemoveBuffNotify.MergeFrom(this.OrderRemoveBuffNotify);
								}
								input.ReadMessage(orderRemoveBuffNotify);
								this.OrderRemoveBuffNotify = orderRemoveBuffNotify;
								continue;
							}
							if (num == 234U)
							{
								ActivateBuffNotify activateBuffNotify = new ActivateBuffNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActivateBuffNotify)
								{
									activateBuffNotify.MergeFrom(this.ActivateBuffNotify);
								}
								input.ReadMessage(activateBuffNotify);
								this.ActivateBuffNotify = activateBuffNotify;
								continue;
							}
						}
					}
					else if (num <= 274U)
					{
						if (num <= 250U)
						{
							if (num == 242U)
							{
								OrderRemoveBuffByTagsNotify orderRemoveBuffByTagsNotify = new OrderRemoveBuffByTagsNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.OrderRemoveBuffByTagsNotify)
								{
									orderRemoveBuffByTagsNotify.MergeFrom(this.OrderRemoveBuffByTagsNotify);
								}
								input.ReadMessage(orderRemoveBuffByTagsNotify);
								this.OrderRemoveBuffByTagsNotify = orderRemoveBuffByTagsNotify;
								continue;
							}
							if (num == 250U)
							{
								AiInformationNotify aiInformationNotify = new AiInformationNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiInformationNotify)
								{
									aiInformationNotify.MergeFrom(this.AiInformationNotify);
								}
								input.ReadMessage(aiInformationNotify);
								this.AiInformationNotify = aiInformationNotify;
								continue;
							}
						}
						else
						{
							if (num == 258U)
							{
								BattleStateChangeNotify battleStateChangeNotify = new BattleStateChangeNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BattleStateChangeNotify)
								{
									battleStateChangeNotify.MergeFrom(this.BattleStateChangeNotify);
								}
								input.ReadMessage(battleStateChangeNotify);
								this.BattleStateChangeNotify = battleStateChangeNotify;
								continue;
							}
							if (num == 266U)
							{
								AnimationGameplayTagNotify animationGameplayTagNotify = new AnimationGameplayTagNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AnimationGameplayTagNotify)
								{
									animationGameplayTagNotify.MergeFrom(this.AnimationGameplayTagNotify);
								}
								input.ReadMessage(animationGameplayTagNotify);
								this.AnimationGameplayTagNotify = animationGameplayTagNotify;
								continue;
							}
							if (num == 274U)
							{
								BoneVisibleChangeNotify boneVisibleChangeNotify = new BoneVisibleChangeNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BoneVisibleChangeNotify)
								{
									boneVisibleChangeNotify.MergeFrom(this.BoneVisibleChangeNotify);
								}
								input.ReadMessage(boneVisibleChangeNotify);
								this.BoneVisibleChangeNotify = boneVisibleChangeNotify;
								continue;
							}
						}
					}
					else if (num <= 290U)
					{
						if (num == 282U)
						{
							AiBlackboardCdNotify aiBlackboardCdNotify = new AiBlackboardCdNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiBlackboardCdNotify)
							{
								aiBlackboardCdNotify.MergeFrom(this.AiBlackboardCdNotify);
							}
							input.ReadMessage(aiBlackboardCdNotify);
							this.AiBlackboardCdNotify = aiBlackboardCdNotify;
							continue;
						}
						if (num == 290U)
						{
							CaughtNotify caughtNotify = new CaughtNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CaughtNotify)
							{
								caughtNotify.MergeFrom(this.CaughtNotify);
							}
							input.ReadMessage(caughtNotify);
							this.CaughtNotify = caughtNotify;
							continue;
						}
					}
					else
					{
						if (num == 298U)
						{
							EntityStaticHookMoveNotify entityStaticHookMoveNotify = new EntityStaticHookMoveNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityStaticHookMoveNotify)
							{
								entityStaticHookMoveNotify.MergeFrom(this.EntityStaticHookMoveNotify);
							}
							input.ReadMessage(entityStaticHookMoveNotify);
							this.EntityStaticHookMoveNotify = entityStaticHookMoveNotify;
							continue;
						}
						if (num == 306U)
						{
							ChangeStateNotify changeStateNotify = new ChangeStateNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateNotify)
							{
								changeStateNotify.MergeFrom(this.ChangeStateNotify);
							}
							input.ReadMessage(changeStateNotify);
							this.ChangeStateNotify = changeStateNotify;
							continue;
						}
						if (num == 322U)
						{
							ChangeStateConfirmNotify changeStateConfirmNotify = new ChangeStateConfirmNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ChangeStateConfirmNotify)
							{
								changeStateConfirmNotify.MergeFrom(this.ChangeStateConfirmNotify);
							}
							input.ReadMessage(changeStateConfirmNotify);
							this.ChangeStateConfirmNotify = changeStateConfirmNotify;
							continue;
						}
					}
				}
				else if (num <= 530U)
				{
					if (num <= 426U)
					{
						if (num <= 354U)
						{
							if (num <= 338U)
							{
								if (num == 330U)
								{
									BuffStackCountNotify buffStackCountNotify = new BuffStackCountNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffStackCountNotify)
									{
										buffStackCountNotify.MergeFrom(this.BuffStackCountNotify);
									}
									input.ReadMessage(buffStackCountNotify);
									this.BuffStackCountNotify = buffStackCountNotify;
									continue;
								}
								if (num == 338U)
								{
									MontagePlayNotify montagePlayNotify = new MontagePlayNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MontagePlayNotify)
									{
										montagePlayNotify.MergeFrom(this.MontagePlayNotify);
									}
									input.ReadMessage(montagePlayNotify);
									this.MontagePlayNotify = montagePlayNotify;
									continue;
								}
							}
							else
							{
								if (num == 346U)
								{
									ANStartNotify anstartNotify = new ANStartNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ANStartNotify)
									{
										anstartNotify.MergeFrom(this.ANStartNotify);
									}
									input.ReadMessage(anstartNotify);
									this.ANStartNotify = anstartNotify;
									continue;
								}
								if (num == 354U)
								{
									FsmResetNotify fsmResetNotify = new FsmResetNotify();
									if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmResetNotify)
									{
										fsmResetNotify.MergeFrom(this.FsmResetNotify);
									}
									input.ReadMessage(fsmResetNotify);
									this.FsmResetNotify = fsmResetNotify;
									continue;
								}
							}
						}
						else if (num <= 370U)
						{
							if (num == 362U)
							{
								DamageRecordNotify damageRecordNotify = new DamageRecordNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageRecordNotify)
								{
									damageRecordNotify.MergeFrom(this.DamageRecordNotify);
								}
								input.ReadMessage(damageRecordNotify);
								this.DamageRecordNotify = damageRecordNotify;
								continue;
							}
							if (num == 370U)
							{
								AiHateNotify aiHateNotify = new AiHateNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AiHateNotify)
								{
									aiHateNotify.MergeFrom(this.AiHateNotify);
								}
								input.ReadMessage(aiHateNotify);
								this.AiHateNotify = aiHateNotify;
								continue;
							}
						}
						else
						{
							if (num == 378U)
							{
								FsmBlackboardNotify fsmBlackboardNotify = new FsmBlackboardNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmBlackboardNotify)
								{
									fsmBlackboardNotify.MergeFrom(this.FsmBlackboardNotify);
								}
								input.ReadMessage(fsmBlackboardNotify);
								this.FsmBlackboardNotify = fsmBlackboardNotify;
								continue;
							}
							if (num == 386U)
							{
								CharacterBattleStateChangeNotify characterBattleStateChangeNotify = new CharacterBattleStateChangeNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CharacterBattleStateChangeNotify)
								{
									characterBattleStateChangeNotify.MergeFrom(this.CharacterBattleStateChangeNotify);
								}
								input.ReadMessage(characterBattleStateChangeNotify);
								this.CharacterBattleStateChangeNotify = characterBattleStateChangeNotify;
								continue;
							}
							if (num == 426U)
							{
								ApplyBuffS2cRequestNotify applyBuffS2cRequestNotify = new ApplyBuffS2cRequestNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffS2CRequestNotify)
								{
									applyBuffS2cRequestNotify.MergeFrom(this.ApplyBuffS2CRequestNotify);
								}
								input.ReadMessage(applyBuffS2cRequestNotify);
								this.ApplyBuffS2CRequestNotify = applyBuffS2cRequestNotify;
								continue;
							}
						}
					}
					else if (num <= 490U)
					{
						if (num <= 458U)
						{
							if (num == 434U)
							{
								RemoveBuffS2cRequestNotify removeBuffS2cRequestNotify = new RemoveBuffS2cRequestNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffS2CRequestNotify)
								{
									removeBuffS2cRequestNotify.MergeFrom(this.RemoveBuffS2CRequestNotify);
								}
								input.ReadMessage(removeBuffS2cRequestNotify);
								this.RemoveBuffS2CRequestNotify = removeBuffS2cRequestNotify;
								continue;
							}
							if (num == 458U)
							{
								ActorVisibleNotify actorVisibleNotify = new ActorVisibleNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ActorVisibleNotify)
								{
									actorVisibleNotify.MergeFrom(this.ActorVisibleNotify);
								}
								input.ReadMessage(actorVisibleNotify);
								this.ActorVisibleNotify = actorVisibleNotify;
								continue;
							}
						}
						else
						{
							if (num == 466U)
							{
								RecoverPropChangedNotify recoverPropChangedNotify = new RecoverPropChangedNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RecoverPropChangedNotify)
								{
									recoverPropChangedNotify.MergeFrom(this.RecoverPropChangedNotify);
								}
								input.ReadMessage(recoverPropChangedNotify);
								this.RecoverPropChangedNotify = recoverPropChangedNotify;
								continue;
							}
							if (num == 474U)
							{
								RemoveBuffByIdS2cRequestNotify removeBuffByIdS2cRequestNotify = new RemoveBuffByIdS2cRequestNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByIdS2CRequestNotify)
								{
									removeBuffByIdS2cRequestNotify.MergeFrom(this.RemoveBuffByIdS2CRequestNotify);
								}
								input.ReadMessage(removeBuffByIdS2cRequestNotify);
								this.RemoveBuffByIdS2CRequestNotify = removeBuffByIdS2cRequestNotify;
								continue;
							}
							if (num == 490U)
							{
								ShieldUpdateNotify shieldUpdateNotify = new ShieldUpdateNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ShieldUpdateNotify)
								{
									shieldUpdateNotify.MergeFrom(this.ShieldUpdateNotify);
								}
								input.ReadMessage(shieldUpdateNotify);
								this.ShieldUpdateNotify = shieldUpdateNotify;
								continue;
							}
						}
					}
					else if (num <= 506U)
					{
						if (num == 498U)
						{
							PlayerBattleStateChangeNotify playerBattleStateChangeNotify = new PlayerBattleStateChangeNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PlayerBattleStateChangeNotify)
							{
								playerBattleStateChangeNotify.MergeFrom(this.PlayerBattleStateChangeNotify);
							}
							input.ReadMessage(playerBattleStateChangeNotify);
							this.PlayerBattleStateChangeNotify = playerBattleStateChangeNotify;
							continue;
						}
						if (num == 506U)
						{
							FsmCustomBlackboardNotify fsmCustomBlackboardNotify = new FsmCustomBlackboardNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmCustomBlackboardNotify)
							{
								fsmCustomBlackboardNotify.MergeFrom(this.FsmCustomBlackboardNotify);
							}
							input.ReadMessage(fsmCustomBlackboardNotify);
							this.FsmCustomBlackboardNotify = fsmCustomBlackboardNotify;
							continue;
						}
					}
					else
					{
						if (num == 514U)
						{
							PassiveSkillAddNotify passiveSkillAddNotify = new PassiveSkillAddNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillAddNotify)
							{
								passiveSkillAddNotify.MergeFrom(this.PassiveSkillAddNotify);
							}
							input.ReadMessage(passiveSkillAddNotify);
							this.PassiveSkillAddNotify = passiveSkillAddNotify;
							continue;
						}
						if (num == 522U)
						{
							PassiveSkillRemoveNotify passiveSkillRemoveNotify = new PassiveSkillRemoveNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PassiveSkillRemoveNotify)
							{
								passiveSkillRemoveNotify.MergeFrom(this.PassiveSkillRemoveNotify);
							}
							input.ReadMessage(passiveSkillRemoveNotify);
							this.PassiveSkillRemoveNotify = passiveSkillRemoveNotify;
							continue;
						}
						if (num == 530U)
						{
							ExecuteQteNotify executeQteNotify = new ExecuteQteNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ExecuteQteNotify)
							{
								executeQteNotify.MergeFrom(this.ExecuteQteNotify);
							}
							input.ReadMessage(executeQteNotify);
							this.ExecuteQteNotify = executeQteNotify;
							continue;
						}
					}
				}
				else if (num <= 626U)
				{
					if (num <= 586U)
					{
						if (num <= 562U)
						{
							if (num == 554U)
							{
								ModifyEntityCampNotify modifyEntityCampNotify = new ModifyEntityCampNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ModifyEntityCampNotify)
								{
									modifyEntityCampNotify.MergeFrom(this.ModifyEntityCampNotify);
								}
								input.ReadMessage(modifyEntityCampNotify);
								this.ModifyEntityCampNotify = modifyEntityCampNotify;
								continue;
							}
							if (num == 562U)
							{
								AddCombineEntitiesRelationNotify addCombineEntitiesRelationNotify = new AddCombineEntitiesRelationNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.AddCombineEntitiesRelationNotify)
								{
									addCombineEntitiesRelationNotify.MergeFrom(this.AddCombineEntitiesRelationNotify);
								}
								input.ReadMessage(addCombineEntitiesRelationNotify);
								this.AddCombineEntitiesRelationNotify = addCombineEntitiesRelationNotify;
								continue;
							}
						}
						else
						{
							if (num == 570U)
							{
								RemoveCombineRelationNotify removeCombineRelationNotify = new RemoveCombineRelationNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveCombineRelationNotify)
								{
									removeCombineRelationNotify.MergeFrom(this.RemoveCombineRelationNotify);
								}
								input.ReadMessage(removeCombineRelationNotify);
								this.RemoveCombineRelationNotify = removeCombineRelationNotify;
								continue;
							}
							if (num == 578U)
							{
								TestDamageRecordNotify testDamageRecordNotify = new TestDamageRecordNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TestDamageRecordNotify)
								{
									testDamageRecordNotify.MergeFrom(this.TestDamageRecordNotify);
								}
								input.ReadMessage(testDamageRecordNotify);
								this.TestDamageRecordNotify = testDamageRecordNotify;
								continue;
							}
							if (num == 586U)
							{
								BuffDurationNotify buffDurationNotify = new BuffDurationNotify();
								if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BuffDurationNotify)
								{
									buffDurationNotify.MergeFrom(this.BuffDurationNotify);
								}
								input.ReadMessage(buffDurationNotify);
								this.BuffDurationNotify = buffDurationNotify;
								continue;
							}
						}
					}
					else if (num <= 602U)
					{
						if (num == 594U)
						{
							EntityLivingStatusNotify entityLivingStatusNotify = new EntityLivingStatusNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.EntityLivingStatusNotify)
							{
								entityLivingStatusNotify.MergeFrom(this.EntityLivingStatusNotify);
							}
							input.ReadMessage(entityLivingStatusNotify);
							this.EntityLivingStatusNotify = entityLivingStatusNotify;
							continue;
						}
						if (num == 602U)
						{
							NewLinkNotify newLinkNotify = new NewLinkNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.NewLinkNotify)
							{
								newLinkNotify.MergeFrom(this.NewLinkNotify);
							}
							input.ReadMessage(newLinkNotify);
							this.NewLinkNotify = newLinkNotify;
							continue;
						}
					}
					else
					{
						if (num == 610U)
						{
							ApplyBuffFailedNotify applyBuffFailedNotify = new ApplyBuffFailedNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.ApplyBuffFailedNotify)
							{
								applyBuffFailedNotify.MergeFrom(this.ApplyBuffFailedNotify);
							}
							input.ReadMessage(applyBuffFailedNotify);
							this.ApplyBuffFailedNotify = applyBuffFailedNotify;
							continue;
						}
						if (num == 618U)
						{
							PackAnimChangedNotify packAnimChangedNotify = new PackAnimChangedNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.PackAnimChangedNotify)
							{
								packAnimChangedNotify.MergeFrom(this.PackAnimChangedNotify);
							}
							input.ReadMessage(packAnimChangedNotify);
							this.PackAnimChangedNotify = packAnimChangedNotify;
							continue;
						}
						if (num == 626U)
						{
							VisionTriggerNotify visionTriggerNotify = new VisionTriggerNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.VisionTriggerNotify)
							{
								visionTriggerNotify.MergeFrom(this.VisionTriggerNotify);
							}
							input.ReadMessage(visionTriggerNotify);
							this.VisionTriggerNotify = visionTriggerNotify;
							continue;
						}
					}
				}
				else if (num <= 666U)
				{
					if (num <= 642U)
					{
						if (num == 634U)
						{
							RemoveBuffByServerIdS2cRequestNotify removeBuffByServerIdS2cRequestNotify = new RemoveBuffByServerIdS2cRequestNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.RemoveBuffByServerIdS2CRequestNotify)
							{
								removeBuffByServerIdS2cRequestNotify.MergeFrom(this.RemoveBuffByServerIdS2CRequestNotify);
							}
							input.ReadMessage(removeBuffByServerIdS2cRequestNotify);
							this.RemoveBuffByServerIdS2CRequestNotify = removeBuffByServerIdS2cRequestNotify;
							continue;
						}
						if (num == 642U)
						{
							TransformBuffStackNotify transformBuffStackNotify = new TransformBuffStackNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.TransformBuffStackNotify)
							{
								transformBuffStackNotify.MergeFrom(this.TransformBuffStackNotify);
							}
							input.ReadMessage(transformBuffStackNotify);
							this.TransformBuffStackNotify = transformBuffStackNotify;
							continue;
						}
					}
					else
					{
						if (num == 650U)
						{
							MotorSummonAndRideNotify motorSummonAndRideNotify = new MotorSummonAndRideNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.MotorSummonAndRideNotify)
							{
								motorSummonAndRideNotify.MergeFrom(this.MotorSummonAndRideNotify);
							}
							input.ReadMessage(motorSummonAndRideNotify);
							this.MotorSummonAndRideNotify = motorSummonAndRideNotify;
							continue;
						}
						if (num == 658U)
						{
							BulletPatternNotify bulletPatternNotify = new BulletPatternNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.BulletPatternNotify)
							{
								bulletPatternNotify.MergeFrom(this.BulletPatternNotify);
							}
							input.ReadMessage(bulletPatternNotify);
							this.BulletPatternNotify = bulletPatternNotify;
							continue;
						}
						if (num == 666U)
						{
							FsmMontageDurationNotify fsmMontageDurationNotify = new FsmMontageDurationNotify();
							if (this.messageCase_ == CombatNotifyData.MessageOneofCase.FsmMontageDurationNotify)
							{
								fsmMontageDurationNotify.MergeFrom(this.FsmMontageDurationNotify);
							}
							input.ReadMessage(fsmMontageDurationNotify);
							this.FsmMontageDurationNotify = fsmMontageDurationNotify;
							continue;
						}
					}
				}
				else if (num <= 690U)
				{
					if (num == 682U)
					{
						CombatValNotify combatValNotify = new CombatValNotify();
						if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValNotify)
						{
							combatValNotify.MergeFrom(this.CombatValNotify);
						}
						input.ReadMessage(combatValNotify);
						this.CombatValNotify = combatValNotify;
						continue;
					}
					if (num == 690U)
					{
						CombatValDecayBeginNotify combatValDecayBeginNotify = new CombatValDecayBeginNotify();
						if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatValDecayBeginNotify)
						{
							combatValDecayBeginNotify.MergeFrom(this.CombatValDecayBeginNotify);
						}
						input.ReadMessage(combatValDecayBeginNotify);
						this.CombatValDecayBeginNotify = combatValDecayBeginNotify;
						continue;
					}
				}
				else
				{
					if (num == 698U)
					{
						SquadPropChangedNotify squadPropChangedNotify = new SquadPropChangedNotify();
						if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SquadPropChangedNotify)
						{
							squadPropChangedNotify.MergeFrom(this.SquadPropChangedNotify);
						}
						input.ReadMessage(squadPropChangedNotify);
						this.SquadPropChangedNotify = squadPropChangedNotify;
						continue;
					}
					if (num == 706U)
					{
						DamageShowNotify damageShowNotify = new DamageShowNotify();
						if (this.messageCase_ == CombatNotifyData.MessageOneofCase.DamageShowNotify)
						{
							damageShowNotify.MergeFrom(this.DamageShowNotify);
						}
						input.ReadMessage(damageShowNotify);
						this.DamageShowNotify = damageShowNotify;
						continue;
					}
					if (num == 802U)
					{
						CombatDataMaxNotify combatDataMaxNotify = new CombatDataMaxNotify();
						if (this.messageCase_ == CombatNotifyData.MessageOneofCase.CombatDataMaxNotify)
						{
							combatDataMaxNotify.MergeFrom(this.CombatDataMaxNotify);
						}
						input.ReadMessage(combatDataMaxNotify);
						this.CombatDataMaxNotify = combatDataMaxNotify;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C743 RID: 51011
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C744 RID: 51012
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C745 RID: 51013
		private CombatCommon combatCommon_;

		// Token: 0x0400C746 RID: 51014
		public const int CreateBulletNotifyFieldNumber = 2;

		// Token: 0x0400C747 RID: 51015
		public const int DestroyBulletNotifyFieldNumber = 3;

		// Token: 0x0400C748 RID: 51016
		public const int DamageExecuteNotifyFieldNumber = 4;

		// Token: 0x0400C749 RID: 51017
		public const int ApplyGameplayEffectNotifyFieldNumber = 5;

		// Token: 0x0400C74A RID: 51018
		public const int RemoveGameplayEffectNotifyFieldNumber = 6;

		// Token: 0x0400C74B RID: 51019
		public const int HitNotifyFieldNumber = 7;

		// Token: 0x0400C74C RID: 51020
		public const int SkillNotifyFieldNumber = 8;

		// Token: 0x0400C74D RID: 51021
		public const int UseSkillNotifyFieldNumber = 9;

		// Token: 0x0400C74E RID: 51022
		public const int EndSkillNotifyFieldNumber = 10;

		// Token: 0x0400C74F RID: 51023
		public const int EntityLoadCompleteNotifyFieldNumber = 11;

		// Token: 0x0400C750 RID: 51024
		public const int PartUpdateNotifyFieldNumber = 12;

		// Token: 0x0400C751 RID: 51025
		public const int PartComponentInitNotifyFieldNumber = 14;

		// Token: 0x0400C752 RID: 51026
		public const int MaterialNotifyFieldNumber = 15;

		// Token: 0x0400C753 RID: 51027
		public const int GameplayCueNotifyFieldNumber = 16;

		// Token: 0x0400C754 RID: 51028
		public const int EntityIsVisibleNotifyFieldNumber = 17;

		// Token: 0x0400C755 RID: 51029
		public const int SwitchCharacterStateNotifyFieldNumber = 18;

		// Token: 0x0400C756 RID: 51030
		public const int PlayerRebackSceneNotifyFieldNumber = 19;

		// Token: 0x0400C757 RID: 51031
		public const int LogicStateInitNotifyFieldNumber = 20;

		// Token: 0x0400C758 RID: 51032
		public const int SwitchLogicStateNotifyFieldNumber = 21;

		// Token: 0x0400C759 RID: 51033
		public const int AttributeChangedNotifyFieldNumber = 22;

		// Token: 0x0400C75A RID: 51034
		public const int AnimationStateChangedNotifyFieldNumber = 23;

		// Token: 0x0400C75B RID: 51035
		public const int AnimationStateInitNotifyFieldNumber = 24;

		// Token: 0x0400C75C RID: 51036
		public const int ModifyBulletParamsNotifyFieldNumber = 25;

		// Token: 0x0400C75D RID: 51037
		public const int DrownNotifyFieldNumber = 26;

		// Token: 0x0400C75E RID: 51038
		public const int OrderApplyBuffNotifyFieldNumber = 27;

		// Token: 0x0400C75F RID: 51039
		public const int OrderRemoveBuffNotifyFieldNumber = 28;

		// Token: 0x0400C760 RID: 51040
		public const int ActivateBuffNotifyFieldNumber = 29;

		// Token: 0x0400C761 RID: 51041
		public const int OrderRemoveBuffByTagsNotifyFieldNumber = 30;

		// Token: 0x0400C762 RID: 51042
		public const int AiInformationNotifyFieldNumber = 31;

		// Token: 0x0400C763 RID: 51043
		public const int BattleStateChangeNotifyFieldNumber = 32;

		// Token: 0x0400C764 RID: 51044
		public const int AnimationGameplayTagNotifyFieldNumber = 33;

		// Token: 0x0400C765 RID: 51045
		public const int BoneVisibleChangeNotifyFieldNumber = 34;

		// Token: 0x0400C766 RID: 51046
		public const int AiBlackboardCdNotifyFieldNumber = 35;

		// Token: 0x0400C767 RID: 51047
		public const int CaughtNotifyFieldNumber = 36;

		// Token: 0x0400C768 RID: 51048
		public const int EntityStaticHookMoveNotifyFieldNumber = 37;

		// Token: 0x0400C769 RID: 51049
		public const int ChangeStateNotifyFieldNumber = 38;

		// Token: 0x0400C76A RID: 51050
		public const int ChangeStateConfirmNotifyFieldNumber = 40;

		// Token: 0x0400C76B RID: 51051
		public const int BuffStackCountNotifyFieldNumber = 41;

		// Token: 0x0400C76C RID: 51052
		public const int MontagePlayNotifyFieldNumber = 42;

		// Token: 0x0400C76D RID: 51053
		public const int ANStartNotifyFieldNumber = 43;

		// Token: 0x0400C76E RID: 51054
		public const int FsmResetNotifyFieldNumber = 44;

		// Token: 0x0400C76F RID: 51055
		public const int DamageRecordNotifyFieldNumber = 45;

		// Token: 0x0400C770 RID: 51056
		public const int AiHateNotifyFieldNumber = 46;

		// Token: 0x0400C771 RID: 51057
		public const int FsmBlackboardNotifyFieldNumber = 47;

		// Token: 0x0400C772 RID: 51058
		public const int CharacterBattleStateChangeNotifyFieldNumber = 48;

		// Token: 0x0400C773 RID: 51059
		public const int ApplyBuffS2CRequestNotifyFieldNumber = 53;

		// Token: 0x0400C774 RID: 51060
		public const int RemoveBuffS2CRequestNotifyFieldNumber = 54;

		// Token: 0x0400C775 RID: 51061
		public const int ActorVisibleNotifyFieldNumber = 57;

		// Token: 0x0400C776 RID: 51062
		public const int RecoverPropChangedNotifyFieldNumber = 58;

		// Token: 0x0400C777 RID: 51063
		public const int RemoveBuffByIdS2CRequestNotifyFieldNumber = 59;

		// Token: 0x0400C778 RID: 51064
		public const int ShieldUpdateNotifyFieldNumber = 61;

		// Token: 0x0400C779 RID: 51065
		public const int PlayerBattleStateChangeNotifyFieldNumber = 62;

		// Token: 0x0400C77A RID: 51066
		public const int FsmCustomBlackboardNotifyFieldNumber = 63;

		// Token: 0x0400C77B RID: 51067
		public const int PassiveSkillAddNotifyFieldNumber = 64;

		// Token: 0x0400C77C RID: 51068
		public const int PassiveSkillRemoveNotifyFieldNumber = 65;

		// Token: 0x0400C77D RID: 51069
		public const int ExecuteQteNotifyFieldNumber = 66;

		// Token: 0x0400C77E RID: 51070
		public const int ModifyEntityCampNotifyFieldNumber = 69;

		// Token: 0x0400C77F RID: 51071
		public const int AddCombineEntitiesRelationNotifyFieldNumber = 70;

		// Token: 0x0400C780 RID: 51072
		public const int RemoveCombineRelationNotifyFieldNumber = 71;

		// Token: 0x0400C781 RID: 51073
		public const int TestDamageRecordNotifyFieldNumber = 72;

		// Token: 0x0400C782 RID: 51074
		public const int BuffDurationNotifyFieldNumber = 73;

		// Token: 0x0400C783 RID: 51075
		public const int EntityLivingStatusNotifyFieldNumber = 74;

		// Token: 0x0400C784 RID: 51076
		public const int NewLinkNotifyFieldNumber = 75;

		// Token: 0x0400C785 RID: 51077
		public const int ApplyBuffFailedNotifyFieldNumber = 76;

		// Token: 0x0400C786 RID: 51078
		public const int PackAnimChangedNotifyFieldNumber = 77;

		// Token: 0x0400C787 RID: 51079
		public const int VisionTriggerNotifyFieldNumber = 78;

		// Token: 0x0400C788 RID: 51080
		public const int RemoveBuffByServerIdS2CRequestNotifyFieldNumber = 79;

		// Token: 0x0400C789 RID: 51081
		public const int TransformBuffStackNotifyFieldNumber = 80;

		// Token: 0x0400C78A RID: 51082
		public const int MotorSummonAndRideNotifyFieldNumber = 81;

		// Token: 0x0400C78B RID: 51083
		public const int BulletPatternNotifyFieldNumber = 82;

		// Token: 0x0400C78C RID: 51084
		public const int FsmMontageDurationNotifyFieldNumber = 83;

		// Token: 0x0400C78D RID: 51085
		public const int CombatValNotifyFieldNumber = 85;

		// Token: 0x0400C78E RID: 51086
		public const int CombatValDecayBeginNotifyFieldNumber = 86;

		// Token: 0x0400C78F RID: 51087
		public const int SquadPropChangedNotifyFieldNumber = 87;

		// Token: 0x0400C790 RID: 51088
		public const int DamageShowNotifyFieldNumber = 88;

		// Token: 0x0400C791 RID: 51089
		public const int CombatDataMaxNotifyFieldNumber = 100;

		// Token: 0x0400C792 RID: 51090
		private object message_;

		// Token: 0x0400C793 RID: 51091
		private CombatNotifyData.MessageOneofCase messageCase_;

		// Token: 0x02001A9F RID: 6815
		public enum MessageOneofCase
		{
			// Token: 0x0400D05C RID: 53340
			None,
			// Token: 0x0400D05D RID: 53341
			CreateBulletNotify = 2,
			// Token: 0x0400D05E RID: 53342
			DestroyBulletNotify,
			// Token: 0x0400D05F RID: 53343
			DamageExecuteNotify,
			// Token: 0x0400D060 RID: 53344
			ApplyGameplayEffectNotify,
			// Token: 0x0400D061 RID: 53345
			RemoveGameplayEffectNotify,
			// Token: 0x0400D062 RID: 53346
			HitNotify,
			// Token: 0x0400D063 RID: 53347
			SkillNotify,
			// Token: 0x0400D064 RID: 53348
			UseSkillNotify,
			// Token: 0x0400D065 RID: 53349
			EndSkillNotify,
			// Token: 0x0400D066 RID: 53350
			EntityLoadCompleteNotify,
			// Token: 0x0400D067 RID: 53351
			PartUpdateNotify,
			// Token: 0x0400D068 RID: 53352
			PartComponentInitNotify = 14,
			// Token: 0x0400D069 RID: 53353
			MaterialNotify,
			// Token: 0x0400D06A RID: 53354
			GameplayCueNotify,
			// Token: 0x0400D06B RID: 53355
			EntityIsVisibleNotify,
			// Token: 0x0400D06C RID: 53356
			SwitchCharacterStateNotify,
			// Token: 0x0400D06D RID: 53357
			PlayerRebackSceneNotify,
			// Token: 0x0400D06E RID: 53358
			LogicStateInitNotify,
			// Token: 0x0400D06F RID: 53359
			SwitchLogicStateNotify,
			// Token: 0x0400D070 RID: 53360
			AttributeChangedNotify,
			// Token: 0x0400D071 RID: 53361
			AnimationStateChangedNotify,
			// Token: 0x0400D072 RID: 53362
			AnimationStateInitNotify,
			// Token: 0x0400D073 RID: 53363
			ModifyBulletParamsNotify,
			// Token: 0x0400D074 RID: 53364
			DrownNotify,
			// Token: 0x0400D075 RID: 53365
			OrderApplyBuffNotify,
			// Token: 0x0400D076 RID: 53366
			OrderRemoveBuffNotify,
			// Token: 0x0400D077 RID: 53367
			ActivateBuffNotify,
			// Token: 0x0400D078 RID: 53368
			OrderRemoveBuffByTagsNotify,
			// Token: 0x0400D079 RID: 53369
			AiInformationNotify,
			// Token: 0x0400D07A RID: 53370
			BattleStateChangeNotify,
			// Token: 0x0400D07B RID: 53371
			AnimationGameplayTagNotify,
			// Token: 0x0400D07C RID: 53372
			BoneVisibleChangeNotify,
			// Token: 0x0400D07D RID: 53373
			AiBlackboardCdNotify,
			// Token: 0x0400D07E RID: 53374
			CaughtNotify,
			// Token: 0x0400D07F RID: 53375
			EntityStaticHookMoveNotify,
			// Token: 0x0400D080 RID: 53376
			ChangeStateNotify,
			// Token: 0x0400D081 RID: 53377
			ChangeStateConfirmNotify = 40,
			// Token: 0x0400D082 RID: 53378
			BuffStackCountNotify,
			// Token: 0x0400D083 RID: 53379
			MontagePlayNotify,
			// Token: 0x0400D084 RID: 53380
			ANStartNotify,
			// Token: 0x0400D085 RID: 53381
			FsmResetNotify,
			// Token: 0x0400D086 RID: 53382
			DamageRecordNotify,
			// Token: 0x0400D087 RID: 53383
			AiHateNotify,
			// Token: 0x0400D088 RID: 53384
			FsmBlackboardNotify,
			// Token: 0x0400D089 RID: 53385
			CharacterBattleStateChangeNotify,
			// Token: 0x0400D08A RID: 53386
			ApplyBuffS2CRequestNotify = 53,
			// Token: 0x0400D08B RID: 53387
			RemoveBuffS2CRequestNotify,
			// Token: 0x0400D08C RID: 53388
			ActorVisibleNotify = 57,
			// Token: 0x0400D08D RID: 53389
			RecoverPropChangedNotify,
			// Token: 0x0400D08E RID: 53390
			RemoveBuffByIdS2CRequestNotify,
			// Token: 0x0400D08F RID: 53391
			ShieldUpdateNotify = 61,
			// Token: 0x0400D090 RID: 53392
			PlayerBattleStateChangeNotify,
			// Token: 0x0400D091 RID: 53393
			FsmCustomBlackboardNotify,
			// Token: 0x0400D092 RID: 53394
			PassiveSkillAddNotify,
			// Token: 0x0400D093 RID: 53395
			PassiveSkillRemoveNotify,
			// Token: 0x0400D094 RID: 53396
			ExecuteQteNotify,
			// Token: 0x0400D095 RID: 53397
			ModifyEntityCampNotify = 69,
			// Token: 0x0400D096 RID: 53398
			AddCombineEntitiesRelationNotify,
			// Token: 0x0400D097 RID: 53399
			RemoveCombineRelationNotify,
			// Token: 0x0400D098 RID: 53400
			TestDamageRecordNotify,
			// Token: 0x0400D099 RID: 53401
			BuffDurationNotify,
			// Token: 0x0400D09A RID: 53402
			EntityLivingStatusNotify,
			// Token: 0x0400D09B RID: 53403
			NewLinkNotify,
			// Token: 0x0400D09C RID: 53404
			ApplyBuffFailedNotify,
			// Token: 0x0400D09D RID: 53405
			PackAnimChangedNotify,
			// Token: 0x0400D09E RID: 53406
			VisionTriggerNotify,
			// Token: 0x0400D09F RID: 53407
			RemoveBuffByServerIdS2CRequestNotify,
			// Token: 0x0400D0A0 RID: 53408
			TransformBuffStackNotify,
			// Token: 0x0400D0A1 RID: 53409
			MotorSummonAndRideNotify,
			// Token: 0x0400D0A2 RID: 53410
			BulletPatternNotify,
			// Token: 0x0400D0A3 RID: 53411
			FsmMontageDurationNotify,
			// Token: 0x0400D0A4 RID: 53412
			CombatValNotify = 85,
			// Token: 0x0400D0A5 RID: 53413
			CombatValDecayBeginNotify,
			// Token: 0x0400D0A6 RID: 53414
			SquadPropChangedNotify,
			// Token: 0x0400D0A7 RID: 53415
			DamageShowNotify,
			// Token: 0x0400D0A8 RID: 53416
			CombatDataMaxNotify = 100
		}
	}
}
