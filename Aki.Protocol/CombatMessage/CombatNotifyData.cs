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
	// Token: 0x02001687 RID: 5767
	public sealed class CombatNotifyData : IMessage<CombatNotifyData>, IMessage, IEquatable<CombatNotifyData>, IDeepCloneable<CombatNotifyData>, IBufferMessage
	{
		// Token: 0x0601CC17 RID: 117783 RVA: 0x004264AD File Offset: 0x004246AD
		[NullableContext(1)]
		public static CombatNotifyData Create()
		{
			return new CombatNotifyData();
		}

		// Token: 0x170060E4 RID: 24804
		// (get) Token: 0x0601CC18 RID: 117784 RVA: 0x004264B4 File Offset: 0x004246B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060E5 RID: 24805
		// (get) Token: 0x0601CC19 RID: 117785 RVA: 0x004264B7 File Offset: 0x004246B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatNotifyData.Descriptor;
			}
		}

		// Token: 0x0601CC1A RID: 117786 RVA: 0x004264BE File Offset: 0x004246BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData()
		{
		}

		// Token: 0x0601CC1B RID: 117787 RVA: 0x004264C8 File Offset: 0x004246C8
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
			case CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify:
				this.SwitchDarkTideWeaponSlotNotify = other.SwitchDarkTideWeaponSlotNotify.Clone();
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
			case CombatNotifyData.MessageOneofCase.CombatDataMaxNotify:
				this.CombatDataMaxNotify = other.CombatDataMaxNotify.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC1C RID: 117788 RVA: 0x00426D19 File Offset: 0x00424F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData Clone()
		{
			return new CombatNotifyData(this);
		}

		// Token: 0x170060E6 RID: 24806
		// (get) Token: 0x0601CC1D RID: 117789 RVA: 0x00426D21 File Offset: 0x00424F21
		// (set) Token: 0x0601CC1E RID: 117790 RVA: 0x00426D29 File Offset: 0x00424F29
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

		// Token: 0x170060E7 RID: 24807
		// (get) Token: 0x0601CC1F RID: 117791 RVA: 0x00426D32 File Offset: 0x00424F32
		// (set) Token: 0x0601CC20 RID: 117792 RVA: 0x00426D4A File Offset: 0x00424F4A
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

		// Token: 0x170060E8 RID: 24808
		// (get) Token: 0x0601CC21 RID: 117793 RVA: 0x00426D60 File Offset: 0x00424F60
		// (set) Token: 0x0601CC22 RID: 117794 RVA: 0x00426D78 File Offset: 0x00424F78
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

		// Token: 0x170060E9 RID: 24809
		// (get) Token: 0x0601CC23 RID: 117795 RVA: 0x00426D8E File Offset: 0x00424F8E
		// (set) Token: 0x0601CC24 RID: 117796 RVA: 0x00426DA6 File Offset: 0x00424FA6
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

		// Token: 0x170060EA RID: 24810
		// (get) Token: 0x0601CC25 RID: 117797 RVA: 0x00426DBC File Offset: 0x00424FBC
		// (set) Token: 0x0601CC26 RID: 117798 RVA: 0x00426DD4 File Offset: 0x00424FD4
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

		// Token: 0x170060EB RID: 24811
		// (get) Token: 0x0601CC27 RID: 117799 RVA: 0x00426DEA File Offset: 0x00424FEA
		// (set) Token: 0x0601CC28 RID: 117800 RVA: 0x00426E02 File Offset: 0x00425002
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

		// Token: 0x170060EC RID: 24812
		// (get) Token: 0x0601CC29 RID: 117801 RVA: 0x00426E18 File Offset: 0x00425018
		// (set) Token: 0x0601CC2A RID: 117802 RVA: 0x00426E30 File Offset: 0x00425030
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

		// Token: 0x170060ED RID: 24813
		// (get) Token: 0x0601CC2B RID: 117803 RVA: 0x00426E46 File Offset: 0x00425046
		// (set) Token: 0x0601CC2C RID: 117804 RVA: 0x00426E5E File Offset: 0x0042505E
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

		// Token: 0x170060EE RID: 24814
		// (get) Token: 0x0601CC2D RID: 117805 RVA: 0x00426E74 File Offset: 0x00425074
		// (set) Token: 0x0601CC2E RID: 117806 RVA: 0x00426E8D File Offset: 0x0042508D
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

		// Token: 0x170060EF RID: 24815
		// (get) Token: 0x0601CC2F RID: 117807 RVA: 0x00426EA4 File Offset: 0x004250A4
		// (set) Token: 0x0601CC30 RID: 117808 RVA: 0x00426EBD File Offset: 0x004250BD
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

		// Token: 0x170060F0 RID: 24816
		// (get) Token: 0x0601CC31 RID: 117809 RVA: 0x00426ED4 File Offset: 0x004250D4
		// (set) Token: 0x0601CC32 RID: 117810 RVA: 0x00426EED File Offset: 0x004250ED
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

		// Token: 0x170060F1 RID: 24817
		// (get) Token: 0x0601CC33 RID: 117811 RVA: 0x00426F04 File Offset: 0x00425104
		// (set) Token: 0x0601CC34 RID: 117812 RVA: 0x00426F1D File Offset: 0x0042511D
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

		// Token: 0x170060F2 RID: 24818
		// (get) Token: 0x0601CC35 RID: 117813 RVA: 0x00426F34 File Offset: 0x00425134
		// (set) Token: 0x0601CC36 RID: 117814 RVA: 0x00426F4D File Offset: 0x0042514D
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

		// Token: 0x170060F3 RID: 24819
		// (get) Token: 0x0601CC37 RID: 117815 RVA: 0x00426F64 File Offset: 0x00425164
		// (set) Token: 0x0601CC38 RID: 117816 RVA: 0x00426F7D File Offset: 0x0042517D
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

		// Token: 0x170060F4 RID: 24820
		// (get) Token: 0x0601CC39 RID: 117817 RVA: 0x00426F94 File Offset: 0x00425194
		// (set) Token: 0x0601CC3A RID: 117818 RVA: 0x00426FAD File Offset: 0x004251AD
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

		// Token: 0x170060F5 RID: 24821
		// (get) Token: 0x0601CC3B RID: 117819 RVA: 0x00426FC4 File Offset: 0x004251C4
		// (set) Token: 0x0601CC3C RID: 117820 RVA: 0x00426FDD File Offset: 0x004251DD
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

		// Token: 0x170060F6 RID: 24822
		// (get) Token: 0x0601CC3D RID: 117821 RVA: 0x00426FF4 File Offset: 0x004251F4
		// (set) Token: 0x0601CC3E RID: 117822 RVA: 0x0042700D File Offset: 0x0042520D
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

		// Token: 0x170060F7 RID: 24823
		// (get) Token: 0x0601CC3F RID: 117823 RVA: 0x00427024 File Offset: 0x00425224
		// (set) Token: 0x0601CC40 RID: 117824 RVA: 0x0042703D File Offset: 0x0042523D
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

		// Token: 0x170060F8 RID: 24824
		// (get) Token: 0x0601CC41 RID: 117825 RVA: 0x00427054 File Offset: 0x00425254
		// (set) Token: 0x0601CC42 RID: 117826 RVA: 0x0042706D File Offset: 0x0042526D
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

		// Token: 0x170060F9 RID: 24825
		// (get) Token: 0x0601CC43 RID: 117827 RVA: 0x00427084 File Offset: 0x00425284
		// (set) Token: 0x0601CC44 RID: 117828 RVA: 0x0042709D File Offset: 0x0042529D
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

		// Token: 0x170060FA RID: 24826
		// (get) Token: 0x0601CC45 RID: 117829 RVA: 0x004270B4 File Offset: 0x004252B4
		// (set) Token: 0x0601CC46 RID: 117830 RVA: 0x004270CD File Offset: 0x004252CD
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

		// Token: 0x170060FB RID: 24827
		// (get) Token: 0x0601CC47 RID: 117831 RVA: 0x004270E4 File Offset: 0x004252E4
		// (set) Token: 0x0601CC48 RID: 117832 RVA: 0x004270FD File Offset: 0x004252FD
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

		// Token: 0x170060FC RID: 24828
		// (get) Token: 0x0601CC49 RID: 117833 RVA: 0x00427114 File Offset: 0x00425314
		// (set) Token: 0x0601CC4A RID: 117834 RVA: 0x0042712D File Offset: 0x0042532D
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

		// Token: 0x170060FD RID: 24829
		// (get) Token: 0x0601CC4B RID: 117835 RVA: 0x00427144 File Offset: 0x00425344
		// (set) Token: 0x0601CC4C RID: 117836 RVA: 0x0042715D File Offset: 0x0042535D
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

		// Token: 0x170060FE RID: 24830
		// (get) Token: 0x0601CC4D RID: 117837 RVA: 0x00427174 File Offset: 0x00425374
		// (set) Token: 0x0601CC4E RID: 117838 RVA: 0x0042718D File Offset: 0x0042538D
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

		// Token: 0x170060FF RID: 24831
		// (get) Token: 0x0601CC4F RID: 117839 RVA: 0x004271A4 File Offset: 0x004253A4
		// (set) Token: 0x0601CC50 RID: 117840 RVA: 0x004271BD File Offset: 0x004253BD
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

		// Token: 0x17006100 RID: 24832
		// (get) Token: 0x0601CC51 RID: 117841 RVA: 0x004271D4 File Offset: 0x004253D4
		// (set) Token: 0x0601CC52 RID: 117842 RVA: 0x004271ED File Offset: 0x004253ED
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

		// Token: 0x17006101 RID: 24833
		// (get) Token: 0x0601CC53 RID: 117843 RVA: 0x00427204 File Offset: 0x00425404
		// (set) Token: 0x0601CC54 RID: 117844 RVA: 0x0042721D File Offset: 0x0042541D
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

		// Token: 0x17006102 RID: 24834
		// (get) Token: 0x0601CC55 RID: 117845 RVA: 0x00427234 File Offset: 0x00425434
		// (set) Token: 0x0601CC56 RID: 117846 RVA: 0x0042724D File Offset: 0x0042544D
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

		// Token: 0x17006103 RID: 24835
		// (get) Token: 0x0601CC57 RID: 117847 RVA: 0x00427264 File Offset: 0x00425464
		// (set) Token: 0x0601CC58 RID: 117848 RVA: 0x0042727D File Offset: 0x0042547D
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

		// Token: 0x17006104 RID: 24836
		// (get) Token: 0x0601CC59 RID: 117849 RVA: 0x00427294 File Offset: 0x00425494
		// (set) Token: 0x0601CC5A RID: 117850 RVA: 0x004272AD File Offset: 0x004254AD
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

		// Token: 0x17006105 RID: 24837
		// (get) Token: 0x0601CC5B RID: 117851 RVA: 0x004272C4 File Offset: 0x004254C4
		// (set) Token: 0x0601CC5C RID: 117852 RVA: 0x004272DD File Offset: 0x004254DD
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

		// Token: 0x17006106 RID: 24838
		// (get) Token: 0x0601CC5D RID: 117853 RVA: 0x004272F4 File Offset: 0x004254F4
		// (set) Token: 0x0601CC5E RID: 117854 RVA: 0x0042730D File Offset: 0x0042550D
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

		// Token: 0x17006107 RID: 24839
		// (get) Token: 0x0601CC5F RID: 117855 RVA: 0x00427324 File Offset: 0x00425524
		// (set) Token: 0x0601CC60 RID: 117856 RVA: 0x0042733D File Offset: 0x0042553D
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

		// Token: 0x17006108 RID: 24840
		// (get) Token: 0x0601CC61 RID: 117857 RVA: 0x00427354 File Offset: 0x00425554
		// (set) Token: 0x0601CC62 RID: 117858 RVA: 0x0042736D File Offset: 0x0042556D
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

		// Token: 0x17006109 RID: 24841
		// (get) Token: 0x0601CC63 RID: 117859 RVA: 0x00427384 File Offset: 0x00425584
		// (set) Token: 0x0601CC64 RID: 117860 RVA: 0x0042739D File Offset: 0x0042559D
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

		// Token: 0x1700610A RID: 24842
		// (get) Token: 0x0601CC65 RID: 117861 RVA: 0x004273B4 File Offset: 0x004255B4
		// (set) Token: 0x0601CC66 RID: 117862 RVA: 0x004273CD File Offset: 0x004255CD
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

		// Token: 0x1700610B RID: 24843
		// (get) Token: 0x0601CC67 RID: 117863 RVA: 0x004273E4 File Offset: 0x004255E4
		// (set) Token: 0x0601CC68 RID: 117864 RVA: 0x004273FD File Offset: 0x004255FD
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

		// Token: 0x1700610C RID: 24844
		// (get) Token: 0x0601CC69 RID: 117865 RVA: 0x00427414 File Offset: 0x00425614
		// (set) Token: 0x0601CC6A RID: 117866 RVA: 0x0042742D File Offset: 0x0042562D
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

		// Token: 0x1700610D RID: 24845
		// (get) Token: 0x0601CC6B RID: 117867 RVA: 0x00427444 File Offset: 0x00425644
		// (set) Token: 0x0601CC6C RID: 117868 RVA: 0x0042745D File Offset: 0x0042565D
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

		// Token: 0x1700610E RID: 24846
		// (get) Token: 0x0601CC6D RID: 117869 RVA: 0x00427474 File Offset: 0x00425674
		// (set) Token: 0x0601CC6E RID: 117870 RVA: 0x0042748D File Offset: 0x0042568D
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

		// Token: 0x1700610F RID: 24847
		// (get) Token: 0x0601CC6F RID: 117871 RVA: 0x004274A4 File Offset: 0x004256A4
		// (set) Token: 0x0601CC70 RID: 117872 RVA: 0x004274BD File Offset: 0x004256BD
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

		// Token: 0x17006110 RID: 24848
		// (get) Token: 0x0601CC71 RID: 117873 RVA: 0x004274D4 File Offset: 0x004256D4
		// (set) Token: 0x0601CC72 RID: 117874 RVA: 0x004274ED File Offset: 0x004256ED
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

		// Token: 0x17006111 RID: 24849
		// (get) Token: 0x0601CC73 RID: 117875 RVA: 0x00427504 File Offset: 0x00425704
		// (set) Token: 0x0601CC74 RID: 117876 RVA: 0x0042751D File Offset: 0x0042571D
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

		// Token: 0x17006112 RID: 24850
		// (get) Token: 0x0601CC75 RID: 117877 RVA: 0x00427534 File Offset: 0x00425734
		// (set) Token: 0x0601CC76 RID: 117878 RVA: 0x0042754D File Offset: 0x0042574D
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

		// Token: 0x17006113 RID: 24851
		// (get) Token: 0x0601CC77 RID: 117879 RVA: 0x00427564 File Offset: 0x00425764
		// (set) Token: 0x0601CC78 RID: 117880 RVA: 0x0042757D File Offset: 0x0042577D
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

		// Token: 0x17006114 RID: 24852
		// (get) Token: 0x0601CC79 RID: 117881 RVA: 0x00427594 File Offset: 0x00425794
		// (set) Token: 0x0601CC7A RID: 117882 RVA: 0x004275AD File Offset: 0x004257AD
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

		// Token: 0x17006115 RID: 24853
		// (get) Token: 0x0601CC7B RID: 117883 RVA: 0x004275C4 File Offset: 0x004257C4
		// (set) Token: 0x0601CC7C RID: 117884 RVA: 0x004275DD File Offset: 0x004257DD
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

		// Token: 0x17006116 RID: 24854
		// (get) Token: 0x0601CC7D RID: 117885 RVA: 0x004275F4 File Offset: 0x004257F4
		// (set) Token: 0x0601CC7E RID: 117886 RVA: 0x0042760D File Offset: 0x0042580D
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

		// Token: 0x17006117 RID: 24855
		// (get) Token: 0x0601CC7F RID: 117887 RVA: 0x00427624 File Offset: 0x00425824
		// (set) Token: 0x0601CC80 RID: 117888 RVA: 0x0042763D File Offset: 0x0042583D
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

		// Token: 0x17006118 RID: 24856
		// (get) Token: 0x0601CC81 RID: 117889 RVA: 0x00427654 File Offset: 0x00425854
		// (set) Token: 0x0601CC82 RID: 117890 RVA: 0x0042766D File Offset: 0x0042586D
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

		// Token: 0x17006119 RID: 24857
		// (get) Token: 0x0601CC83 RID: 117891 RVA: 0x00427684 File Offset: 0x00425884
		// (set) Token: 0x0601CC84 RID: 117892 RVA: 0x0042769D File Offset: 0x0042589D
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

		// Token: 0x1700611A RID: 24858
		// (get) Token: 0x0601CC85 RID: 117893 RVA: 0x004276B4 File Offset: 0x004258B4
		// (set) Token: 0x0601CC86 RID: 117894 RVA: 0x004276CD File Offset: 0x004258CD
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

		// Token: 0x1700611B RID: 24859
		// (get) Token: 0x0601CC87 RID: 117895 RVA: 0x004276E4 File Offset: 0x004258E4
		// (set) Token: 0x0601CC88 RID: 117896 RVA: 0x004276FD File Offset: 0x004258FD
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

		// Token: 0x1700611C RID: 24860
		// (get) Token: 0x0601CC89 RID: 117897 RVA: 0x00427714 File Offset: 0x00425914
		// (set) Token: 0x0601CC8A RID: 117898 RVA: 0x0042772D File Offset: 0x0042592D
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

		// Token: 0x1700611D RID: 24861
		// (get) Token: 0x0601CC8B RID: 117899 RVA: 0x00427744 File Offset: 0x00425944
		// (set) Token: 0x0601CC8C RID: 117900 RVA: 0x0042775D File Offset: 0x0042595D
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

		// Token: 0x1700611E RID: 24862
		// (get) Token: 0x0601CC8D RID: 117901 RVA: 0x00427774 File Offset: 0x00425974
		// (set) Token: 0x0601CC8E RID: 117902 RVA: 0x0042778D File Offset: 0x0042598D
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

		// Token: 0x1700611F RID: 24863
		// (get) Token: 0x0601CC8F RID: 117903 RVA: 0x004277A4 File Offset: 0x004259A4
		// (set) Token: 0x0601CC90 RID: 117904 RVA: 0x004277BD File Offset: 0x004259BD
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

		// Token: 0x17006120 RID: 24864
		// (get) Token: 0x0601CC91 RID: 117905 RVA: 0x004277D4 File Offset: 0x004259D4
		// (set) Token: 0x0601CC92 RID: 117906 RVA: 0x004277ED File Offset: 0x004259ED
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

		// Token: 0x17006121 RID: 24865
		// (get) Token: 0x0601CC93 RID: 117907 RVA: 0x00427804 File Offset: 0x00425A04
		// (set) Token: 0x0601CC94 RID: 117908 RVA: 0x0042781D File Offset: 0x00425A1D
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

		// Token: 0x17006122 RID: 24866
		// (get) Token: 0x0601CC95 RID: 117909 RVA: 0x00427834 File Offset: 0x00425A34
		// (set) Token: 0x0601CC96 RID: 117910 RVA: 0x0042784D File Offset: 0x00425A4D
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

		// Token: 0x17006123 RID: 24867
		// (get) Token: 0x0601CC97 RID: 117911 RVA: 0x00427864 File Offset: 0x00425A64
		// (set) Token: 0x0601CC98 RID: 117912 RVA: 0x0042787D File Offset: 0x00425A7D
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

		// Token: 0x17006124 RID: 24868
		// (get) Token: 0x0601CC99 RID: 117913 RVA: 0x00427894 File Offset: 0x00425A94
		// (set) Token: 0x0601CC9A RID: 117914 RVA: 0x004278AD File Offset: 0x00425AAD
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

		// Token: 0x17006125 RID: 24869
		// (get) Token: 0x0601CC9B RID: 117915 RVA: 0x004278C4 File Offset: 0x00425AC4
		// (set) Token: 0x0601CC9C RID: 117916 RVA: 0x004278DD File Offset: 0x00425ADD
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

		// Token: 0x17006126 RID: 24870
		// (get) Token: 0x0601CC9D RID: 117917 RVA: 0x004278F4 File Offset: 0x00425AF4
		// (set) Token: 0x0601CC9E RID: 117918 RVA: 0x0042790D File Offset: 0x00425B0D
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

		// Token: 0x17006127 RID: 24871
		// (get) Token: 0x0601CC9F RID: 117919 RVA: 0x00427924 File Offset: 0x00425B24
		// (set) Token: 0x0601CCA0 RID: 117920 RVA: 0x0042793D File Offset: 0x00425B3D
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

		// Token: 0x17006128 RID: 24872
		// (get) Token: 0x0601CCA1 RID: 117921 RVA: 0x00427954 File Offset: 0x00425B54
		// (set) Token: 0x0601CCA2 RID: 117922 RVA: 0x0042796D File Offset: 0x00425B6D
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

		// Token: 0x17006129 RID: 24873
		// (get) Token: 0x0601CCA3 RID: 117923 RVA: 0x00427984 File Offset: 0x00425B84
		// (set) Token: 0x0601CCA4 RID: 117924 RVA: 0x0042799D File Offset: 0x00425B9D
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

		// Token: 0x1700612A RID: 24874
		// (get) Token: 0x0601CCA5 RID: 117925 RVA: 0x004279B4 File Offset: 0x00425BB4
		// (set) Token: 0x0601CCA6 RID: 117926 RVA: 0x004279CD File Offset: 0x00425BCD
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

		// Token: 0x1700612B RID: 24875
		// (get) Token: 0x0601CCA7 RID: 117927 RVA: 0x004279E4 File Offset: 0x00425BE4
		// (set) Token: 0x0601CCA8 RID: 117928 RVA: 0x004279FD File Offset: 0x00425BFD
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

		// Token: 0x1700612C RID: 24876
		// (get) Token: 0x0601CCA9 RID: 117929 RVA: 0x00427A14 File Offset: 0x00425C14
		// (set) Token: 0x0601CCAA RID: 117930 RVA: 0x00427A2D File Offset: 0x00425C2D
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

		// Token: 0x1700612D RID: 24877
		// (get) Token: 0x0601CCAB RID: 117931 RVA: 0x00427A44 File Offset: 0x00425C44
		// (set) Token: 0x0601CCAC RID: 117932 RVA: 0x00427A5D File Offset: 0x00425C5D
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

		// Token: 0x1700612E RID: 24878
		// (get) Token: 0x0601CCAD RID: 117933 RVA: 0x00427A74 File Offset: 0x00425C74
		// (set) Token: 0x0601CCAE RID: 117934 RVA: 0x00427A8D File Offset: 0x00425C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponSlotNotify SwitchDarkTideWeaponSlotNotify
		{
			get
			{
				if (this.messageCase_ != CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify)
				{
					return null;
				}
				return (SwitchDarkTideWeaponSlotNotify)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatNotifyData.MessageOneofCase.None : CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify);
			}
		}

		// Token: 0x1700612F RID: 24879
		// (get) Token: 0x0601CCAF RID: 117935 RVA: 0x00427AA4 File Offset: 0x00425CA4
		// (set) Token: 0x0601CCB0 RID: 117936 RVA: 0x00427ABD File Offset: 0x00425CBD
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

		// Token: 0x17006130 RID: 24880
		// (get) Token: 0x0601CCB1 RID: 117937 RVA: 0x00427AD4 File Offset: 0x00425CD4
		// (set) Token: 0x0601CCB2 RID: 117938 RVA: 0x00427AED File Offset: 0x00425CED
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

		// Token: 0x17006131 RID: 24881
		// (get) Token: 0x0601CCB3 RID: 117939 RVA: 0x00427B04 File Offset: 0x00425D04
		// (set) Token: 0x0601CCB4 RID: 117940 RVA: 0x00427B1D File Offset: 0x00425D1D
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

		// Token: 0x17006132 RID: 24882
		// (get) Token: 0x0601CCB5 RID: 117941 RVA: 0x00427B34 File Offset: 0x00425D34
		// (set) Token: 0x0601CCB6 RID: 117942 RVA: 0x00427B4D File Offset: 0x00425D4D
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

		// Token: 0x17006133 RID: 24883
		// (get) Token: 0x0601CCB7 RID: 117943 RVA: 0x00427B64 File Offset: 0x00425D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601CCB8 RID: 117944 RVA: 0x00427B6C File Offset: 0x00425D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatNotifyData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601CCB9 RID: 117945 RVA: 0x00427B7C File Offset: 0x00425D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatNotifyData);
		}

		// Token: 0x0601CCBA RID: 117946 RVA: 0x00427B8C File Offset: 0x00425D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatNotifyData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.CreateBulletNotify, other.CreateBulletNotify) && object.Equals(this.DestroyBulletNotify, other.DestroyBulletNotify) && object.Equals(this.DamageExecuteNotify, other.DamageExecuteNotify) && object.Equals(this.ApplyGameplayEffectNotify, other.ApplyGameplayEffectNotify) && object.Equals(this.RemoveGameplayEffectNotify, other.RemoveGameplayEffectNotify) && object.Equals(this.HitNotify, other.HitNotify) && object.Equals(this.SkillNotify, other.SkillNotify) && object.Equals(this.UseSkillNotify, other.UseSkillNotify) && object.Equals(this.EndSkillNotify, other.EndSkillNotify) && object.Equals(this.EntityLoadCompleteNotify, other.EntityLoadCompleteNotify) && object.Equals(this.PartUpdateNotify, other.PartUpdateNotify) && object.Equals(this.PartComponentInitNotify, other.PartComponentInitNotify) && object.Equals(this.MaterialNotify, other.MaterialNotify) && object.Equals(this.GameplayCueNotify, other.GameplayCueNotify) && object.Equals(this.EntityIsVisibleNotify, other.EntityIsVisibleNotify) && object.Equals(this.SwitchCharacterStateNotify, other.SwitchCharacterStateNotify) && object.Equals(this.PlayerRebackSceneNotify, other.PlayerRebackSceneNotify) && object.Equals(this.LogicStateInitNotify, other.LogicStateInitNotify) && object.Equals(this.SwitchLogicStateNotify, other.SwitchLogicStateNotify) && object.Equals(this.AttributeChangedNotify, other.AttributeChangedNotify) && object.Equals(this.AnimationStateChangedNotify, other.AnimationStateChangedNotify) && object.Equals(this.AnimationStateInitNotify, other.AnimationStateInitNotify) && object.Equals(this.ModifyBulletParamsNotify, other.ModifyBulletParamsNotify) && object.Equals(this.DrownNotify, other.DrownNotify) && object.Equals(this.OrderApplyBuffNotify, other.OrderApplyBuffNotify) && object.Equals(this.OrderRemoveBuffNotify, other.OrderRemoveBuffNotify) && object.Equals(this.ActivateBuffNotify, other.ActivateBuffNotify) && object.Equals(this.OrderRemoveBuffByTagsNotify, other.OrderRemoveBuffByTagsNotify) && object.Equals(this.AiInformationNotify, other.AiInformationNotify) && object.Equals(this.BattleStateChangeNotify, other.BattleStateChangeNotify) && object.Equals(this.AnimationGameplayTagNotify, other.AnimationGameplayTagNotify) && object.Equals(this.BoneVisibleChangeNotify, other.BoneVisibleChangeNotify) && object.Equals(this.AiBlackboardCdNotify, other.AiBlackboardCdNotify) && object.Equals(this.CaughtNotify, other.CaughtNotify) && object.Equals(this.EntityStaticHookMoveNotify, other.EntityStaticHookMoveNotify) && object.Equals(this.ChangeStateNotify, other.ChangeStateNotify) && object.Equals(this.ChangeStateConfirmNotify, other.ChangeStateConfirmNotify) && object.Equals(this.BuffStackCountNotify, other.BuffStackCountNotify) && object.Equals(this.MontagePlayNotify, other.MontagePlayNotify) && object.Equals(this.ANStartNotify, other.ANStartNotify) && object.Equals(this.FsmResetNotify, other.FsmResetNotify) && object.Equals(this.DamageRecordNotify, other.DamageRecordNotify) && object.Equals(this.AiHateNotify, other.AiHateNotify) && object.Equals(this.FsmBlackboardNotify, other.FsmBlackboardNotify) && object.Equals(this.CharacterBattleStateChangeNotify, other.CharacterBattleStateChangeNotify) && object.Equals(this.ApplyBuffS2CRequestNotify, other.ApplyBuffS2CRequestNotify) && object.Equals(this.RemoveBuffS2CRequestNotify, other.RemoveBuffS2CRequestNotify) && object.Equals(this.ActorVisibleNotify, other.ActorVisibleNotify) && object.Equals(this.RecoverPropChangedNotify, other.RecoverPropChangedNotify) && object.Equals(this.RemoveBuffByIdS2CRequestNotify, other.RemoveBuffByIdS2CRequestNotify) && object.Equals(this.ShieldUpdateNotify, other.ShieldUpdateNotify) && object.Equals(this.PlayerBattleStateChangeNotify, other.PlayerBattleStateChangeNotify) && object.Equals(this.FsmCustomBlackboardNotify, other.FsmCustomBlackboardNotify) && object.Equals(this.PassiveSkillAddNotify, other.PassiveSkillAddNotify) && object.Equals(this.PassiveSkillRemoveNotify, other.PassiveSkillRemoveNotify) && object.Equals(this.ExecuteQteNotify, other.ExecuteQteNotify) && object.Equals(this.ModifyEntityCampNotify, other.ModifyEntityCampNotify) && object.Equals(this.AddCombineEntitiesRelationNotify, other.AddCombineEntitiesRelationNotify) && object.Equals(this.RemoveCombineRelationNotify, other.RemoveCombineRelationNotify) && object.Equals(this.TestDamageRecordNotify, other.TestDamageRecordNotify) && object.Equals(this.BuffDurationNotify, other.BuffDurationNotify) && object.Equals(this.EntityLivingStatusNotify, other.EntityLivingStatusNotify) && object.Equals(this.NewLinkNotify, other.NewLinkNotify) && object.Equals(this.ApplyBuffFailedNotify, other.ApplyBuffFailedNotify) && object.Equals(this.PackAnimChangedNotify, other.PackAnimChangedNotify) && object.Equals(this.VisionTriggerNotify, other.VisionTriggerNotify) && object.Equals(this.RemoveBuffByServerIdS2CRequestNotify, other.RemoveBuffByServerIdS2CRequestNotify) && object.Equals(this.TransformBuffStackNotify, other.TransformBuffStackNotify) && object.Equals(this.MotorSummonAndRideNotify, other.MotorSummonAndRideNotify) && object.Equals(this.BulletPatternNotify, other.BulletPatternNotify) && object.Equals(this.FsmMontageDurationNotify, other.FsmMontageDurationNotify) && object.Equals(this.SwitchDarkTideWeaponSlotNotify, other.SwitchDarkTideWeaponSlotNotify) && object.Equals(this.CombatValNotify, other.CombatValNotify) && object.Equals(this.CombatValDecayBeginNotify, other.CombatValDecayBeginNotify) && object.Equals(this.SquadPropChangedNotify, other.SquadPropChangedNotify) && object.Equals(this.CombatDataMaxNotify, other.CombatDataMaxNotify) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CCBB RID: 117947 RVA: 0x00428218 File Offset: 0x00426418
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
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify)
			{
				num ^= this.SwitchDarkTideWeaponSlotNotify.GetHashCode();
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

		// Token: 0x0601CCBC RID: 117948 RVA: 0x00428976 File Offset: 0x00426B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CCBD RID: 117949 RVA: 0x00428983 File Offset: 0x00426B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CCBE RID: 117950 RVA: 0x0042898C File Offset: 0x00426B8C
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
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify)
			{
				output.WriteRawTag(162, 5);
				output.WriteMessage(this.SwitchDarkTideWeaponSlotNotify);
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

		// Token: 0x0601CCBF RID: 117951 RVA: 0x004293A8 File Offset: 0x004275A8
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
			if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchDarkTideWeaponSlotNotify);
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

		// Token: 0x0601CCC0 RID: 117952 RVA: 0x00429B98 File Offset: 0x00427D98
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
			case CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify:
				if (this.SwitchDarkTideWeaponSlotNotify == null)
				{
					this.SwitchDarkTideWeaponSlotNotify = new SwitchDarkTideWeaponSlotNotify();
				}
				this.SwitchDarkTideWeaponSlotNotify.MergeFrom(other.SwitchDarkTideWeaponSlotNotify);
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

		// Token: 0x0601CCC1 RID: 117953 RVA: 0x0042A9AA File Offset: 0x00428BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CCC2 RID: 117954 RVA: 0x0042A9B4 File Offset: 0x00428BB4
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
				else if (num <= 682U)
				{
					if (num == 674U)
					{
						SwitchDarkTideWeaponSlotNotify switchDarkTideWeaponSlotNotify = new SwitchDarkTideWeaponSlotNotify();
						if (this.messageCase_ == CombatNotifyData.MessageOneofCase.SwitchDarkTideWeaponSlotNotify)
						{
							switchDarkTideWeaponSlotNotify.MergeFrom(this.SwitchDarkTideWeaponSlotNotify);
						}
						input.ReadMessage(switchDarkTideWeaponSlotNotify);
						this.SwitchDarkTideWeaponSlotNotify = switchDarkTideWeaponSlotNotify;
						continue;
					}
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
				}
				else
				{
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

		// Token: 0x0400C217 RID: 49687
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C218 RID: 49688
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C219 RID: 49689
		private CombatCommon combatCommon_;

		// Token: 0x0400C21A RID: 49690
		public const int CreateBulletNotifyFieldNumber = 2;

		// Token: 0x0400C21B RID: 49691
		public const int DestroyBulletNotifyFieldNumber = 3;

		// Token: 0x0400C21C RID: 49692
		public const int DamageExecuteNotifyFieldNumber = 4;

		// Token: 0x0400C21D RID: 49693
		public const int ApplyGameplayEffectNotifyFieldNumber = 5;

		// Token: 0x0400C21E RID: 49694
		public const int RemoveGameplayEffectNotifyFieldNumber = 6;

		// Token: 0x0400C21F RID: 49695
		public const int HitNotifyFieldNumber = 7;

		// Token: 0x0400C220 RID: 49696
		public const int SkillNotifyFieldNumber = 8;

		// Token: 0x0400C221 RID: 49697
		public const int UseSkillNotifyFieldNumber = 9;

		// Token: 0x0400C222 RID: 49698
		public const int EndSkillNotifyFieldNumber = 10;

		// Token: 0x0400C223 RID: 49699
		public const int EntityLoadCompleteNotifyFieldNumber = 11;

		// Token: 0x0400C224 RID: 49700
		public const int PartUpdateNotifyFieldNumber = 12;

		// Token: 0x0400C225 RID: 49701
		public const int PartComponentInitNotifyFieldNumber = 14;

		// Token: 0x0400C226 RID: 49702
		public const int MaterialNotifyFieldNumber = 15;

		// Token: 0x0400C227 RID: 49703
		public const int GameplayCueNotifyFieldNumber = 16;

		// Token: 0x0400C228 RID: 49704
		public const int EntityIsVisibleNotifyFieldNumber = 17;

		// Token: 0x0400C229 RID: 49705
		public const int SwitchCharacterStateNotifyFieldNumber = 18;

		// Token: 0x0400C22A RID: 49706
		public const int PlayerRebackSceneNotifyFieldNumber = 19;

		// Token: 0x0400C22B RID: 49707
		public const int LogicStateInitNotifyFieldNumber = 20;

		// Token: 0x0400C22C RID: 49708
		public const int SwitchLogicStateNotifyFieldNumber = 21;

		// Token: 0x0400C22D RID: 49709
		public const int AttributeChangedNotifyFieldNumber = 22;

		// Token: 0x0400C22E RID: 49710
		public const int AnimationStateChangedNotifyFieldNumber = 23;

		// Token: 0x0400C22F RID: 49711
		public const int AnimationStateInitNotifyFieldNumber = 24;

		// Token: 0x0400C230 RID: 49712
		public const int ModifyBulletParamsNotifyFieldNumber = 25;

		// Token: 0x0400C231 RID: 49713
		public const int DrownNotifyFieldNumber = 26;

		// Token: 0x0400C232 RID: 49714
		public const int OrderApplyBuffNotifyFieldNumber = 27;

		// Token: 0x0400C233 RID: 49715
		public const int OrderRemoveBuffNotifyFieldNumber = 28;

		// Token: 0x0400C234 RID: 49716
		public const int ActivateBuffNotifyFieldNumber = 29;

		// Token: 0x0400C235 RID: 49717
		public const int OrderRemoveBuffByTagsNotifyFieldNumber = 30;

		// Token: 0x0400C236 RID: 49718
		public const int AiInformationNotifyFieldNumber = 31;

		// Token: 0x0400C237 RID: 49719
		public const int BattleStateChangeNotifyFieldNumber = 32;

		// Token: 0x0400C238 RID: 49720
		public const int AnimationGameplayTagNotifyFieldNumber = 33;

		// Token: 0x0400C239 RID: 49721
		public const int BoneVisibleChangeNotifyFieldNumber = 34;

		// Token: 0x0400C23A RID: 49722
		public const int AiBlackboardCdNotifyFieldNumber = 35;

		// Token: 0x0400C23B RID: 49723
		public const int CaughtNotifyFieldNumber = 36;

		// Token: 0x0400C23C RID: 49724
		public const int EntityStaticHookMoveNotifyFieldNumber = 37;

		// Token: 0x0400C23D RID: 49725
		public const int ChangeStateNotifyFieldNumber = 38;

		// Token: 0x0400C23E RID: 49726
		public const int ChangeStateConfirmNotifyFieldNumber = 40;

		// Token: 0x0400C23F RID: 49727
		public const int BuffStackCountNotifyFieldNumber = 41;

		// Token: 0x0400C240 RID: 49728
		public const int MontagePlayNotifyFieldNumber = 42;

		// Token: 0x0400C241 RID: 49729
		public const int ANStartNotifyFieldNumber = 43;

		// Token: 0x0400C242 RID: 49730
		public const int FsmResetNotifyFieldNumber = 44;

		// Token: 0x0400C243 RID: 49731
		public const int DamageRecordNotifyFieldNumber = 45;

		// Token: 0x0400C244 RID: 49732
		public const int AiHateNotifyFieldNumber = 46;

		// Token: 0x0400C245 RID: 49733
		public const int FsmBlackboardNotifyFieldNumber = 47;

		// Token: 0x0400C246 RID: 49734
		public const int CharacterBattleStateChangeNotifyFieldNumber = 48;

		// Token: 0x0400C247 RID: 49735
		public const int ApplyBuffS2CRequestNotifyFieldNumber = 53;

		// Token: 0x0400C248 RID: 49736
		public const int RemoveBuffS2CRequestNotifyFieldNumber = 54;

		// Token: 0x0400C249 RID: 49737
		public const int ActorVisibleNotifyFieldNumber = 57;

		// Token: 0x0400C24A RID: 49738
		public const int RecoverPropChangedNotifyFieldNumber = 58;

		// Token: 0x0400C24B RID: 49739
		public const int RemoveBuffByIdS2CRequestNotifyFieldNumber = 59;

		// Token: 0x0400C24C RID: 49740
		public const int ShieldUpdateNotifyFieldNumber = 61;

		// Token: 0x0400C24D RID: 49741
		public const int PlayerBattleStateChangeNotifyFieldNumber = 62;

		// Token: 0x0400C24E RID: 49742
		public const int FsmCustomBlackboardNotifyFieldNumber = 63;

		// Token: 0x0400C24F RID: 49743
		public const int PassiveSkillAddNotifyFieldNumber = 64;

		// Token: 0x0400C250 RID: 49744
		public const int PassiveSkillRemoveNotifyFieldNumber = 65;

		// Token: 0x0400C251 RID: 49745
		public const int ExecuteQteNotifyFieldNumber = 66;

		// Token: 0x0400C252 RID: 49746
		public const int ModifyEntityCampNotifyFieldNumber = 69;

		// Token: 0x0400C253 RID: 49747
		public const int AddCombineEntitiesRelationNotifyFieldNumber = 70;

		// Token: 0x0400C254 RID: 49748
		public const int RemoveCombineRelationNotifyFieldNumber = 71;

		// Token: 0x0400C255 RID: 49749
		public const int TestDamageRecordNotifyFieldNumber = 72;

		// Token: 0x0400C256 RID: 49750
		public const int BuffDurationNotifyFieldNumber = 73;

		// Token: 0x0400C257 RID: 49751
		public const int EntityLivingStatusNotifyFieldNumber = 74;

		// Token: 0x0400C258 RID: 49752
		public const int NewLinkNotifyFieldNumber = 75;

		// Token: 0x0400C259 RID: 49753
		public const int ApplyBuffFailedNotifyFieldNumber = 76;

		// Token: 0x0400C25A RID: 49754
		public const int PackAnimChangedNotifyFieldNumber = 77;

		// Token: 0x0400C25B RID: 49755
		public const int VisionTriggerNotifyFieldNumber = 78;

		// Token: 0x0400C25C RID: 49756
		public const int RemoveBuffByServerIdS2CRequestNotifyFieldNumber = 79;

		// Token: 0x0400C25D RID: 49757
		public const int TransformBuffStackNotifyFieldNumber = 80;

		// Token: 0x0400C25E RID: 49758
		public const int MotorSummonAndRideNotifyFieldNumber = 81;

		// Token: 0x0400C25F RID: 49759
		public const int BulletPatternNotifyFieldNumber = 82;

		// Token: 0x0400C260 RID: 49760
		public const int FsmMontageDurationNotifyFieldNumber = 83;

		// Token: 0x0400C261 RID: 49761
		public const int SwitchDarkTideWeaponSlotNotifyFieldNumber = 84;

		// Token: 0x0400C262 RID: 49762
		public const int CombatValNotifyFieldNumber = 85;

		// Token: 0x0400C263 RID: 49763
		public const int CombatValDecayBeginNotifyFieldNumber = 86;

		// Token: 0x0400C264 RID: 49764
		public const int SquadPropChangedNotifyFieldNumber = 87;

		// Token: 0x0400C265 RID: 49765
		public const int CombatDataMaxNotifyFieldNumber = 100;

		// Token: 0x0400C266 RID: 49766
		private object message_;

		// Token: 0x0400C267 RID: 49767
		private CombatNotifyData.MessageOneofCase messageCase_;

		// Token: 0x020019FD RID: 6653
		public enum MessageOneofCase
		{
			// Token: 0x0400CAF1 RID: 51953
			None,
			// Token: 0x0400CAF2 RID: 51954
			CreateBulletNotify = 2,
			// Token: 0x0400CAF3 RID: 51955
			DestroyBulletNotify,
			// Token: 0x0400CAF4 RID: 51956
			DamageExecuteNotify,
			// Token: 0x0400CAF5 RID: 51957
			ApplyGameplayEffectNotify,
			// Token: 0x0400CAF6 RID: 51958
			RemoveGameplayEffectNotify,
			// Token: 0x0400CAF7 RID: 51959
			HitNotify,
			// Token: 0x0400CAF8 RID: 51960
			SkillNotify,
			// Token: 0x0400CAF9 RID: 51961
			UseSkillNotify,
			// Token: 0x0400CAFA RID: 51962
			EndSkillNotify,
			// Token: 0x0400CAFB RID: 51963
			EntityLoadCompleteNotify,
			// Token: 0x0400CAFC RID: 51964
			PartUpdateNotify,
			// Token: 0x0400CAFD RID: 51965
			PartComponentInitNotify = 14,
			// Token: 0x0400CAFE RID: 51966
			MaterialNotify,
			// Token: 0x0400CAFF RID: 51967
			GameplayCueNotify,
			// Token: 0x0400CB00 RID: 51968
			EntityIsVisibleNotify,
			// Token: 0x0400CB01 RID: 51969
			SwitchCharacterStateNotify,
			// Token: 0x0400CB02 RID: 51970
			PlayerRebackSceneNotify,
			// Token: 0x0400CB03 RID: 51971
			LogicStateInitNotify,
			// Token: 0x0400CB04 RID: 51972
			SwitchLogicStateNotify,
			// Token: 0x0400CB05 RID: 51973
			AttributeChangedNotify,
			// Token: 0x0400CB06 RID: 51974
			AnimationStateChangedNotify,
			// Token: 0x0400CB07 RID: 51975
			AnimationStateInitNotify,
			// Token: 0x0400CB08 RID: 51976
			ModifyBulletParamsNotify,
			// Token: 0x0400CB09 RID: 51977
			DrownNotify,
			// Token: 0x0400CB0A RID: 51978
			OrderApplyBuffNotify,
			// Token: 0x0400CB0B RID: 51979
			OrderRemoveBuffNotify,
			// Token: 0x0400CB0C RID: 51980
			ActivateBuffNotify,
			// Token: 0x0400CB0D RID: 51981
			OrderRemoveBuffByTagsNotify,
			// Token: 0x0400CB0E RID: 51982
			AiInformationNotify,
			// Token: 0x0400CB0F RID: 51983
			BattleStateChangeNotify,
			// Token: 0x0400CB10 RID: 51984
			AnimationGameplayTagNotify,
			// Token: 0x0400CB11 RID: 51985
			BoneVisibleChangeNotify,
			// Token: 0x0400CB12 RID: 51986
			AiBlackboardCdNotify,
			// Token: 0x0400CB13 RID: 51987
			CaughtNotify,
			// Token: 0x0400CB14 RID: 51988
			EntityStaticHookMoveNotify,
			// Token: 0x0400CB15 RID: 51989
			ChangeStateNotify,
			// Token: 0x0400CB16 RID: 51990
			ChangeStateConfirmNotify = 40,
			// Token: 0x0400CB17 RID: 51991
			BuffStackCountNotify,
			// Token: 0x0400CB18 RID: 51992
			MontagePlayNotify,
			// Token: 0x0400CB19 RID: 51993
			ANStartNotify,
			// Token: 0x0400CB1A RID: 51994
			FsmResetNotify,
			// Token: 0x0400CB1B RID: 51995
			DamageRecordNotify,
			// Token: 0x0400CB1C RID: 51996
			AiHateNotify,
			// Token: 0x0400CB1D RID: 51997
			FsmBlackboardNotify,
			// Token: 0x0400CB1E RID: 51998
			CharacterBattleStateChangeNotify,
			// Token: 0x0400CB1F RID: 51999
			ApplyBuffS2CRequestNotify = 53,
			// Token: 0x0400CB20 RID: 52000
			RemoveBuffS2CRequestNotify,
			// Token: 0x0400CB21 RID: 52001
			ActorVisibleNotify = 57,
			// Token: 0x0400CB22 RID: 52002
			RecoverPropChangedNotify,
			// Token: 0x0400CB23 RID: 52003
			RemoveBuffByIdS2CRequestNotify,
			// Token: 0x0400CB24 RID: 52004
			ShieldUpdateNotify = 61,
			// Token: 0x0400CB25 RID: 52005
			PlayerBattleStateChangeNotify,
			// Token: 0x0400CB26 RID: 52006
			FsmCustomBlackboardNotify,
			// Token: 0x0400CB27 RID: 52007
			PassiveSkillAddNotify,
			// Token: 0x0400CB28 RID: 52008
			PassiveSkillRemoveNotify,
			// Token: 0x0400CB29 RID: 52009
			ExecuteQteNotify,
			// Token: 0x0400CB2A RID: 52010
			ModifyEntityCampNotify = 69,
			// Token: 0x0400CB2B RID: 52011
			AddCombineEntitiesRelationNotify,
			// Token: 0x0400CB2C RID: 52012
			RemoveCombineRelationNotify,
			// Token: 0x0400CB2D RID: 52013
			TestDamageRecordNotify,
			// Token: 0x0400CB2E RID: 52014
			BuffDurationNotify,
			// Token: 0x0400CB2F RID: 52015
			EntityLivingStatusNotify,
			// Token: 0x0400CB30 RID: 52016
			NewLinkNotify,
			// Token: 0x0400CB31 RID: 52017
			ApplyBuffFailedNotify,
			// Token: 0x0400CB32 RID: 52018
			PackAnimChangedNotify,
			// Token: 0x0400CB33 RID: 52019
			VisionTriggerNotify,
			// Token: 0x0400CB34 RID: 52020
			RemoveBuffByServerIdS2CRequestNotify,
			// Token: 0x0400CB35 RID: 52021
			TransformBuffStackNotify,
			// Token: 0x0400CB36 RID: 52022
			MotorSummonAndRideNotify,
			// Token: 0x0400CB37 RID: 52023
			BulletPatternNotify,
			// Token: 0x0400CB38 RID: 52024
			FsmMontageDurationNotify,
			// Token: 0x0400CB39 RID: 52025
			SwitchDarkTideWeaponSlotNotify,
			// Token: 0x0400CB3A RID: 52026
			CombatValNotify,
			// Token: 0x0400CB3B RID: 52027
			CombatValDecayBeginNotify,
			// Token: 0x0400CB3C RID: 52028
			SquadPropChangedNotify,
			// Token: 0x0400CB3D RID: 52029
			CombatDataMaxNotify = 100
		}
	}
}
