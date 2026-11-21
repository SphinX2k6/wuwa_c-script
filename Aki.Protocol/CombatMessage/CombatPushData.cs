using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001704 RID: 5892
	public sealed class CombatPushData : IMessage<CombatPushData>, IMessage, IEquatable<CombatPushData>, IDeepCloneable<CombatPushData>, IBufferMessage
	{
		// Token: 0x0601D790 RID: 120720 RVA: 0x00447A8A File Offset: 0x00445C8A
		[NullableContext(1)]
		public static CombatPushData Create()
		{
			return new CombatPushData();
		}

		// Token: 0x170063D8 RID: 25560
		// (get) Token: 0x0601D791 RID: 120721 RVA: 0x00447A91 File Offset: 0x00445C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170063D9 RID: 25561
		// (get) Token: 0x0601D792 RID: 120722 RVA: 0x00447A94 File Offset: 0x00445C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatPushData.Descriptor;
			}
		}

		// Token: 0x0601D793 RID: 120723 RVA: 0x00447A9B File Offset: 0x00445C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData()
		{
		}

		// Token: 0x0601D794 RID: 120724 RVA: 0x00447AA4 File Offset: 0x00445CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData(CombatPushData other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			switch (other.MessageCase)
			{
			case CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush:
				this.ApplyBuffS2CResponsePush = other.ApplyBuffS2CResponsePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush:
				this.RemoveBuffS2CResponsePush = other.RemoveBuffS2CResponsePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush:
				this.RemoveBuffByIdS2CResponsePush = other.RemoveBuffByIdS2CResponsePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.CreateBulletPush:
				this.CreateBulletPush = other.CreateBulletPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.DestroyBulletPush:
				this.DestroyBulletPush = other.DestroyBulletPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ApplyGameplayEffectPush:
				this.ApplyGameplayEffectPush = other.ApplyGameplayEffectPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RemoveGameplayEffectPush:
				this.RemoveGameplayEffectPush = other.RemoveGameplayEffectPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.HitEndPush:
				this.HitEndPush = other.HitEndPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.EndSkillPush:
				this.EndSkillPush = other.EndSkillPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.PartUpdatePush:
				this.PartUpdatePush = other.PartUpdatePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.MaterialPush:
				this.MaterialPush = other.MaterialPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.GameplayCuePush:
				this.GameplayCuePush = other.GameplayCuePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.EntityIsVisiblePush:
				this.EntityIsVisiblePush = other.EntityIsVisiblePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.SwitchCharacterStatePush:
				this.SwitchCharacterStatePush = other.SwitchCharacterStatePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.LogicStateInitPush:
				this.LogicStateInitPush = other.LogicStateInitPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.SwitchLogicStatePush:
				this.SwitchLogicStatePush = other.SwitchLogicStatePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.AnimationStateChangedPush:
				this.AnimationStateChangedPush = other.AnimationStateChangedPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.AnimationStateInitPush:
				this.AnimationStateInitPush = other.AnimationStateInitPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ModifyBulletParamsPush:
				this.ModifyBulletParamsPush = other.ModifyBulletParamsPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.DrownPush:
				this.DrownPush = other.DrownPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ActivateBuffPush:
				this.ActivateBuffPush = other.ActivateBuffPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.AiInformationPush:
				this.AiInformationPush = other.AiInformationPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush:
				this.ToughCalcExtraRatioChangePush = other.ToughCalcExtraRatioChangePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.BattleStateChangePush:
				this.BattleStateChangePush = other.BattleStateChangePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.AnimationGameplayTagPush:
				this.AnimationGameplayTagPush = other.AnimationGameplayTagPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.BoneVisibleChangePush:
				this.BoneVisibleChangePush = other.BoneVisibleChangePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.AiBlackboardsPush:
				this.AiBlackboardsPush = other.AiBlackboardsPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.AiBlackboardCdPush:
				this.AiBlackboardCdPush = other.AiBlackboardCdPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.AiHatePush:
				this.AiHatePush = other.AiHatePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.MonsterBoomPush:
				this.MonsterBoomPush = other.MonsterBoomPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.CaughtPush:
				this.CaughtPush = other.CaughtPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.EntityStaticHookMovePush:
				this.EntityStaticHookMovePush = other.EntityStaticHookMovePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ChangeStateConfirmPush:
				this.ChangeStateConfirmPush = other.ChangeStateConfirmPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.BuffStackCountPush:
				this.BuffStackCountPush = other.BuffStackCountPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ANStartPush:
				this.ANStartPush = other.ANStartPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.UseSkillFailPush:
				this.UseSkillFailPush = other.UseSkillFailPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.EnterViewDirectionPush:
				this.EnterViewDirectionPush = other.EnterViewDirectionPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ExitViewDirectionPush:
				this.ExitViewDirectionPush = other.ExitViewDirectionPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.PassiveSkillAddPush:
				this.PassiveSkillAddPush = other.PassiveSkillAddPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.InterruptSkillInDelayPush:
				this.InterruptSkillInDelayPush = other.InterruptSkillInDelayPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.TriggerExitSkillPush:
				this.TriggerExitSkillPush = other.TriggerExitSkillPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ActorVisiblePush:
				this.ActorVisiblePush = other.ActorVisiblePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.BuffEffectPush:
				this.BuffEffectPush = other.BuffEffectPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RTimeStopPush:
				this.RTimeStopPush = other.RTimeStopPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.DrownEndTeleportPush:
				this.DrownEndTeleportPush = other.DrownEndTeleportPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.MonsterDrownPush:
				this.MonsterDrownPush = other.MonsterDrownPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.PassiveSkillRemovePush:
				this.PassiveSkillRemovePush = other.PassiveSkillRemovePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RTimeStopInstPush:
				this.RTimeStopInstPush = other.RTimeStopInstPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.FsmPlayMontagePush:
				this.FsmPlayMontagePush = other.FsmPlayMontagePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RTimeStopAnimPush:
				this.RTimeStopAnimPush = other.RTimeStopAnimPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.GameplayTagPush:
				this.GameplayTagPush = other.GameplayTagPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ExecuteQtePush:
				this.ExecuteQtePush = other.ExecuteQtePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush:
				this.ClientCurrentRoleReportPush = other.ClientCurrentRoleReportPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.PlayEntityMontagePush:
				this.PlayEntityMontagePush = other.PlayEntityMontagePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.BeforeHitPush:
				this.BeforeHitPush = other.BeforeHitPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.NewLinkBurstPush:
				this.NewLinkBurstPush = other.NewLinkBurstPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RefreshBuffDurationPush:
				this.RefreshBuffDurationPush = other.RefreshBuffDurationPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RoleGoDownPush:
				this.RoleGoDownPush = other.RoleGoDownPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.FsmConditionPassPush:
				this.FsmConditionPassPush = other.FsmConditionPassPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.BuffEffectExecutePush:
				this.BuffEffectExecutePush = other.BuffEffectExecutePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.VisionTriggerPush:
				this.VisionTriggerPush = other.VisionTriggerPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.MotorIsEnablePush:
				this.MotorIsEnablePush = other.MotorIsEnablePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.MotorSummonAndRidePush:
				this.MotorSummonAndRidePush = other.MotorSummonAndRidePush.Clone();
				break;
			case CombatPushData.MessageOneofCase.BulletPatternPush:
				this.BulletPatternPush = other.BulletPatternPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.QuickHackRamVerifyPush:
				this.QuickHackRamVerifyPush = other.QuickHackRamVerifyPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.QuickHackOpenPush:
				this.QuickHackOpenPush = other.QuickHackOpenPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.DodgeInfoPush:
				this.DodgeInfoPush = other.DodgeInfoPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush:
				this.RoleTrialSceneRollbackPush = other.RoleTrialSceneRollbackPush.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D795 RID: 120725 RVA: 0x004481CD File Offset: 0x004463CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData Clone()
		{
			return new CombatPushData(this);
		}

		// Token: 0x170063DA RID: 25562
		// (get) Token: 0x0601D796 RID: 120726 RVA: 0x004481D5 File Offset: 0x004463D5
		// (set) Token: 0x0601D797 RID: 120727 RVA: 0x004481DD File Offset: 0x004463DD
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

		// Token: 0x170063DB RID: 25563
		// (get) Token: 0x0601D798 RID: 120728 RVA: 0x004481E6 File Offset: 0x004463E6
		// (set) Token: 0x0601D799 RID: 120729 RVA: 0x004481FE File Offset: 0x004463FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cResponsePush ApplyBuffS2CResponsePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush)
				{
					return null;
				}
				return (ApplyBuffS2cResponsePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush);
			}
		}

		// Token: 0x170063DC RID: 25564
		// (get) Token: 0x0601D79A RID: 120730 RVA: 0x00448214 File Offset: 0x00446414
		// (set) Token: 0x0601D79B RID: 120731 RVA: 0x0044822C File Offset: 0x0044642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cResponsePush RemoveBuffS2CResponsePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush)
				{
					return null;
				}
				return (RemoveBuffS2cResponsePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush);
			}
		}

		// Token: 0x170063DD RID: 25565
		// (get) Token: 0x0601D79C RID: 120732 RVA: 0x00448242 File Offset: 0x00446442
		// (set) Token: 0x0601D79D RID: 120733 RVA: 0x0044825A File Offset: 0x0044645A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cResponsePush RemoveBuffByIdS2CResponsePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush)
				{
					return null;
				}
				return (RemoveBuffByIdS2cResponsePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush);
			}
		}

		// Token: 0x170063DE RID: 25566
		// (get) Token: 0x0601D79E RID: 120734 RVA: 0x00448270 File Offset: 0x00446470
		// (set) Token: 0x0601D79F RID: 120735 RVA: 0x00448288 File Offset: 0x00446488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletPush CreateBulletPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.CreateBulletPush)
				{
					return null;
				}
				return (CreateBulletPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.CreateBulletPush);
			}
		}

		// Token: 0x170063DF RID: 25567
		// (get) Token: 0x0601D7A0 RID: 120736 RVA: 0x0044829E File Offset: 0x0044649E
		// (set) Token: 0x0601D7A1 RID: 120737 RVA: 0x004482B6 File Offset: 0x004464B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletPush DestroyBulletPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.DestroyBulletPush)
				{
					return null;
				}
				return (DestroyBulletPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.DestroyBulletPush);
			}
		}

		// Token: 0x170063E0 RID: 25568
		// (get) Token: 0x0601D7A2 RID: 120738 RVA: 0x004482CC File Offset: 0x004464CC
		// (set) Token: 0x0601D7A3 RID: 120739 RVA: 0x004482E5 File Offset: 0x004464E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectPush ApplyGameplayEffectPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ApplyGameplayEffectPush)
				{
					return null;
				}
				return (ApplyGameplayEffectPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ApplyGameplayEffectPush);
			}
		}

		// Token: 0x170063E1 RID: 25569
		// (get) Token: 0x0601D7A4 RID: 120740 RVA: 0x004482FC File Offset: 0x004464FC
		// (set) Token: 0x0601D7A5 RID: 120741 RVA: 0x00448315 File Offset: 0x00446515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectPush RemoveGameplayEffectPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RemoveGameplayEffectPush)
				{
					return null;
				}
				return (RemoveGameplayEffectPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RemoveGameplayEffectPush);
			}
		}

		// Token: 0x170063E2 RID: 25570
		// (get) Token: 0x0601D7A6 RID: 120742 RVA: 0x0044832C File Offset: 0x0044652C
		// (set) Token: 0x0601D7A7 RID: 120743 RVA: 0x00448345 File Offset: 0x00446545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndPush HitEndPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.HitEndPush)
				{
					return null;
				}
				return (HitEndPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.HitEndPush);
			}
		}

		// Token: 0x170063E3 RID: 25571
		// (get) Token: 0x0601D7A8 RID: 120744 RVA: 0x0044835C File Offset: 0x0044655C
		// (set) Token: 0x0601D7A9 RID: 120745 RVA: 0x00448375 File Offset: 0x00446575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillPush EndSkillPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.EndSkillPush)
				{
					return null;
				}
				return (EndSkillPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.EndSkillPush);
			}
		}

		// Token: 0x170063E4 RID: 25572
		// (get) Token: 0x0601D7AA RID: 120746 RVA: 0x0044838C File Offset: 0x0044658C
		// (set) Token: 0x0601D7AB RID: 120747 RVA: 0x004483A5 File Offset: 0x004465A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdatePush PartUpdatePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.PartUpdatePush)
				{
					return null;
				}
				return (PartUpdatePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.PartUpdatePush);
			}
		}

		// Token: 0x170063E5 RID: 25573
		// (get) Token: 0x0601D7AC RID: 120748 RVA: 0x004483BC File Offset: 0x004465BC
		// (set) Token: 0x0601D7AD RID: 120749 RVA: 0x004483D5 File Offset: 0x004465D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialPush MaterialPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.MaterialPush)
				{
					return null;
				}
				return (MaterialPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.MaterialPush);
			}
		}

		// Token: 0x170063E6 RID: 25574
		// (get) Token: 0x0601D7AE RID: 120750 RVA: 0x004483EC File Offset: 0x004465EC
		// (set) Token: 0x0601D7AF RID: 120751 RVA: 0x00448405 File Offset: 0x00446605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCuePush GameplayCuePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.GameplayCuePush)
				{
					return null;
				}
				return (GameplayCuePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.GameplayCuePush);
			}
		}

		// Token: 0x170063E7 RID: 25575
		// (get) Token: 0x0601D7B0 RID: 120752 RVA: 0x0044841C File Offset: 0x0044661C
		// (set) Token: 0x0601D7B1 RID: 120753 RVA: 0x00448435 File Offset: 0x00446635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisiblePush EntityIsVisiblePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.EntityIsVisiblePush)
				{
					return null;
				}
				return (EntityIsVisiblePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.EntityIsVisiblePush);
			}
		}

		// Token: 0x170063E8 RID: 25576
		// (get) Token: 0x0601D7B2 RID: 120754 RVA: 0x0044844C File Offset: 0x0044664C
		// (set) Token: 0x0601D7B3 RID: 120755 RVA: 0x00448465 File Offset: 0x00446665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStatePush SwitchCharacterStatePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.SwitchCharacterStatePush)
				{
					return null;
				}
				return (SwitchCharacterStatePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.SwitchCharacterStatePush);
			}
		}

		// Token: 0x170063E9 RID: 25577
		// (get) Token: 0x0601D7B4 RID: 120756 RVA: 0x0044847C File Offset: 0x0044667C
		// (set) Token: 0x0601D7B5 RID: 120757 RVA: 0x00448495 File Offset: 0x00446695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitPush LogicStateInitPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.LogicStateInitPush)
				{
					return null;
				}
				return (LogicStateInitPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.LogicStateInitPush);
			}
		}

		// Token: 0x170063EA RID: 25578
		// (get) Token: 0x0601D7B6 RID: 120758 RVA: 0x004484AC File Offset: 0x004466AC
		// (set) Token: 0x0601D7B7 RID: 120759 RVA: 0x004484C5 File Offset: 0x004466C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStatePush SwitchLogicStatePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.SwitchLogicStatePush)
				{
					return null;
				}
				return (SwitchLogicStatePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.SwitchLogicStatePush);
			}
		}

		// Token: 0x170063EB RID: 25579
		// (get) Token: 0x0601D7B8 RID: 120760 RVA: 0x004484DC File Offset: 0x004466DC
		// (set) Token: 0x0601D7B9 RID: 120761 RVA: 0x004484F5 File Offset: 0x004466F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedPush AnimationStateChangedPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.AnimationStateChangedPush)
				{
					return null;
				}
				return (AnimationStateChangedPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.AnimationStateChangedPush);
			}
		}

		// Token: 0x170063EC RID: 25580
		// (get) Token: 0x0601D7BA RID: 120762 RVA: 0x0044850C File Offset: 0x0044670C
		// (set) Token: 0x0601D7BB RID: 120763 RVA: 0x00448525 File Offset: 0x00446725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitPush AnimationStateInitPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.AnimationStateInitPush)
				{
					return null;
				}
				return (AnimationStateInitPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.AnimationStateInitPush);
			}
		}

		// Token: 0x170063ED RID: 25581
		// (get) Token: 0x0601D7BC RID: 120764 RVA: 0x0044853C File Offset: 0x0044673C
		// (set) Token: 0x0601D7BD RID: 120765 RVA: 0x00448555 File Offset: 0x00446755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsPush ModifyBulletParamsPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ModifyBulletParamsPush)
				{
					return null;
				}
				return (ModifyBulletParamsPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ModifyBulletParamsPush);
			}
		}

		// Token: 0x170063EE RID: 25582
		// (get) Token: 0x0601D7BE RID: 120766 RVA: 0x0044856C File Offset: 0x0044676C
		// (set) Token: 0x0601D7BF RID: 120767 RVA: 0x00448585 File Offset: 0x00446785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownPush DrownPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.DrownPush)
				{
					return null;
				}
				return (DrownPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.DrownPush);
			}
		}

		// Token: 0x170063EF RID: 25583
		// (get) Token: 0x0601D7C0 RID: 120768 RVA: 0x0044859C File Offset: 0x0044679C
		// (set) Token: 0x0601D7C1 RID: 120769 RVA: 0x004485B5 File Offset: 0x004467B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffPush ActivateBuffPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ActivateBuffPush)
				{
					return null;
				}
				return (ActivateBuffPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ActivateBuffPush);
			}
		}

		// Token: 0x170063F0 RID: 25584
		// (get) Token: 0x0601D7C2 RID: 120770 RVA: 0x004485CC File Offset: 0x004467CC
		// (set) Token: 0x0601D7C3 RID: 120771 RVA: 0x004485E5 File Offset: 0x004467E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationPush AiInformationPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.AiInformationPush)
				{
					return null;
				}
				return (AiInformationPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.AiInformationPush);
			}
		}

		// Token: 0x170063F1 RID: 25585
		// (get) Token: 0x0601D7C4 RID: 120772 RVA: 0x004485FC File Offset: 0x004467FC
		// (set) Token: 0x0601D7C5 RID: 120773 RVA: 0x00448615 File Offset: 0x00446815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangePush ToughCalcExtraRatioChangePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush)
				{
					return null;
				}
				return (ToughCalcExtraRatioChangePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush);
			}
		}

		// Token: 0x170063F2 RID: 25586
		// (get) Token: 0x0601D7C6 RID: 120774 RVA: 0x0044862C File Offset: 0x0044682C
		// (set) Token: 0x0601D7C7 RID: 120775 RVA: 0x00448645 File Offset: 0x00446845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangePush BattleStateChangePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.BattleStateChangePush)
				{
					return null;
				}
				return (BattleStateChangePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.BattleStateChangePush);
			}
		}

		// Token: 0x170063F3 RID: 25587
		// (get) Token: 0x0601D7C8 RID: 120776 RVA: 0x0044865C File Offset: 0x0044685C
		// (set) Token: 0x0601D7C9 RID: 120777 RVA: 0x00448675 File Offset: 0x00446875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagPush AnimationGameplayTagPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.AnimationGameplayTagPush)
				{
					return null;
				}
				return (AnimationGameplayTagPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.AnimationGameplayTagPush);
			}
		}

		// Token: 0x170063F4 RID: 25588
		// (get) Token: 0x0601D7CA RID: 120778 RVA: 0x0044868C File Offset: 0x0044688C
		// (set) Token: 0x0601D7CB RID: 120779 RVA: 0x004486A5 File Offset: 0x004468A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangePush BoneVisibleChangePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.BoneVisibleChangePush)
				{
					return null;
				}
				return (BoneVisibleChangePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.BoneVisibleChangePush);
			}
		}

		// Token: 0x170063F5 RID: 25589
		// (get) Token: 0x0601D7CC RID: 120780 RVA: 0x004486BC File Offset: 0x004468BC
		// (set) Token: 0x0601D7CD RID: 120781 RVA: 0x004486D5 File Offset: 0x004468D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsPush AiBlackboardsPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.AiBlackboardsPush)
				{
					return null;
				}
				return (AiBlackboardsPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.AiBlackboardsPush);
			}
		}

		// Token: 0x170063F6 RID: 25590
		// (get) Token: 0x0601D7CE RID: 120782 RVA: 0x004486EC File Offset: 0x004468EC
		// (set) Token: 0x0601D7CF RID: 120783 RVA: 0x00448705 File Offset: 0x00446905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdPush AiBlackboardCdPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.AiBlackboardCdPush)
				{
					return null;
				}
				return (AiBlackboardCdPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.AiBlackboardCdPush);
			}
		}

		// Token: 0x170063F7 RID: 25591
		// (get) Token: 0x0601D7D0 RID: 120784 RVA: 0x0044871C File Offset: 0x0044691C
		// (set) Token: 0x0601D7D1 RID: 120785 RVA: 0x00448735 File Offset: 0x00446935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHatePush AiHatePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.AiHatePush)
				{
					return null;
				}
				return (AiHatePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.AiHatePush);
			}
		}

		// Token: 0x170063F8 RID: 25592
		// (get) Token: 0x0601D7D2 RID: 120786 RVA: 0x0044874C File Offset: 0x0044694C
		// (set) Token: 0x0601D7D3 RID: 120787 RVA: 0x00448765 File Offset: 0x00446965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomPush MonsterBoomPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.MonsterBoomPush)
				{
					return null;
				}
				return (MonsterBoomPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.MonsterBoomPush);
			}
		}

		// Token: 0x170063F9 RID: 25593
		// (get) Token: 0x0601D7D4 RID: 120788 RVA: 0x0044877C File Offset: 0x0044697C
		// (set) Token: 0x0601D7D5 RID: 120789 RVA: 0x00448795 File Offset: 0x00446995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtPush CaughtPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.CaughtPush)
				{
					return null;
				}
				return (CaughtPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.CaughtPush);
			}
		}

		// Token: 0x170063FA RID: 25594
		// (get) Token: 0x0601D7D6 RID: 120790 RVA: 0x004487AC File Offset: 0x004469AC
		// (set) Token: 0x0601D7D7 RID: 120791 RVA: 0x004487C5 File Offset: 0x004469C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush EntityStaticHookMovePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.EntityStaticHookMovePush)
				{
					return null;
				}
				return (EntityStaticHookMovePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.EntityStaticHookMovePush);
			}
		}

		// Token: 0x170063FB RID: 25595
		// (get) Token: 0x0601D7D8 RID: 120792 RVA: 0x004487DC File Offset: 0x004469DC
		// (set) Token: 0x0601D7D9 RID: 120793 RVA: 0x004487F5 File Offset: 0x004469F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmPush ChangeStateConfirmPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ChangeStateConfirmPush)
				{
					return null;
				}
				return (ChangeStateConfirmPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ChangeStateConfirmPush);
			}
		}

		// Token: 0x170063FC RID: 25596
		// (get) Token: 0x0601D7DA RID: 120794 RVA: 0x0044880C File Offset: 0x00446A0C
		// (set) Token: 0x0601D7DB RID: 120795 RVA: 0x00448825 File Offset: 0x00446A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountPush BuffStackCountPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.BuffStackCountPush)
				{
					return null;
				}
				return (BuffStackCountPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.BuffStackCountPush);
			}
		}

		// Token: 0x170063FD RID: 25597
		// (get) Token: 0x0601D7DC RID: 120796 RVA: 0x0044883C File Offset: 0x00446A3C
		// (set) Token: 0x0601D7DD RID: 120797 RVA: 0x00448855 File Offset: 0x00446A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartPush ANStartPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ANStartPush)
				{
					return null;
				}
				return (ANStartPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ANStartPush);
			}
		}

		// Token: 0x170063FE RID: 25598
		// (get) Token: 0x0601D7DE RID: 120798 RVA: 0x0044886C File Offset: 0x00446A6C
		// (set) Token: 0x0601D7DF RID: 120799 RVA: 0x00448885 File Offset: 0x00446A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailPush UseSkillFailPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.UseSkillFailPush)
				{
					return null;
				}
				return (UseSkillFailPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.UseSkillFailPush);
			}
		}

		// Token: 0x170063FF RID: 25599
		// (get) Token: 0x0601D7E0 RID: 120800 RVA: 0x0044889C File Offset: 0x00446A9C
		// (set) Token: 0x0601D7E1 RID: 120801 RVA: 0x004488B5 File Offset: 0x00446AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionPush EnterViewDirectionPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.EnterViewDirectionPush)
				{
					return null;
				}
				return (EnterViewDirectionPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.EnterViewDirectionPush);
			}
		}

		// Token: 0x17006400 RID: 25600
		// (get) Token: 0x0601D7E2 RID: 120802 RVA: 0x004488CC File Offset: 0x00446ACC
		// (set) Token: 0x0601D7E3 RID: 120803 RVA: 0x004488E5 File Offset: 0x00446AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionPush ExitViewDirectionPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ExitViewDirectionPush)
				{
					return null;
				}
				return (ExitViewDirectionPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ExitViewDirectionPush);
			}
		}

		// Token: 0x17006401 RID: 25601
		// (get) Token: 0x0601D7E4 RID: 120804 RVA: 0x004488FC File Offset: 0x00446AFC
		// (set) Token: 0x0601D7E5 RID: 120805 RVA: 0x00448915 File Offset: 0x00446B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddPush PassiveSkillAddPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.PassiveSkillAddPush)
				{
					return null;
				}
				return (PassiveSkillAddPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.PassiveSkillAddPush);
			}
		}

		// Token: 0x17006402 RID: 25602
		// (get) Token: 0x0601D7E6 RID: 120806 RVA: 0x0044892C File Offset: 0x00446B2C
		// (set) Token: 0x0601D7E7 RID: 120807 RVA: 0x00448945 File Offset: 0x00446B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayPush InterruptSkillInDelayPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.InterruptSkillInDelayPush)
				{
					return null;
				}
				return (InterruptSkillInDelayPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.InterruptSkillInDelayPush);
			}
		}

		// Token: 0x17006403 RID: 25603
		// (get) Token: 0x0601D7E8 RID: 120808 RVA: 0x0044895C File Offset: 0x00446B5C
		// (set) Token: 0x0601D7E9 RID: 120809 RVA: 0x00448975 File Offset: 0x00446B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillPush TriggerExitSkillPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.TriggerExitSkillPush)
				{
					return null;
				}
				return (TriggerExitSkillPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.TriggerExitSkillPush);
			}
		}

		// Token: 0x17006404 RID: 25604
		// (get) Token: 0x0601D7EA RID: 120810 RVA: 0x0044898C File Offset: 0x00446B8C
		// (set) Token: 0x0601D7EB RID: 120811 RVA: 0x004489A5 File Offset: 0x00446BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisiblePush ActorVisiblePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ActorVisiblePush)
				{
					return null;
				}
				return (ActorVisiblePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ActorVisiblePush);
			}
		}

		// Token: 0x17006405 RID: 25605
		// (get) Token: 0x0601D7EC RID: 120812 RVA: 0x004489BC File Offset: 0x00446BBC
		// (set) Token: 0x0601D7ED RID: 120813 RVA: 0x004489D5 File Offset: 0x00446BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectPush BuffEffectPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.BuffEffectPush)
				{
					return null;
				}
				return (BuffEffectPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.BuffEffectPush);
			}
		}

		// Token: 0x17006406 RID: 25606
		// (get) Token: 0x0601D7EE RID: 120814 RVA: 0x004489EC File Offset: 0x00446BEC
		// (set) Token: 0x0601D7EF RID: 120815 RVA: 0x00448A05 File Offset: 0x00446C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopPush RTimeStopPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RTimeStopPush)
				{
					return null;
				}
				return (RTimeStopPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RTimeStopPush);
			}
		}

		// Token: 0x17006407 RID: 25607
		// (get) Token: 0x0601D7F0 RID: 120816 RVA: 0x00448A1C File Offset: 0x00446C1C
		// (set) Token: 0x0601D7F1 RID: 120817 RVA: 0x00448A35 File Offset: 0x00446C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportPush DrownEndTeleportPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.DrownEndTeleportPush)
				{
					return null;
				}
				return (DrownEndTeleportPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.DrownEndTeleportPush);
			}
		}

		// Token: 0x17006408 RID: 25608
		// (get) Token: 0x0601D7F2 RID: 120818 RVA: 0x00448A4C File Offset: 0x00446C4C
		// (set) Token: 0x0601D7F3 RID: 120819 RVA: 0x00448A65 File Offset: 0x00446C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownPush MonsterDrownPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.MonsterDrownPush)
				{
					return null;
				}
				return (MonsterDrownPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.MonsterDrownPush);
			}
		}

		// Token: 0x17006409 RID: 25609
		// (get) Token: 0x0601D7F4 RID: 120820 RVA: 0x00448A7C File Offset: 0x00446C7C
		// (set) Token: 0x0601D7F5 RID: 120821 RVA: 0x00448A95 File Offset: 0x00446C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemovePush PassiveSkillRemovePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.PassiveSkillRemovePush)
				{
					return null;
				}
				return (PassiveSkillRemovePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.PassiveSkillRemovePush);
			}
		}

		// Token: 0x1700640A RID: 25610
		// (get) Token: 0x0601D7F6 RID: 120822 RVA: 0x00448AAC File Offset: 0x00446CAC
		// (set) Token: 0x0601D7F7 RID: 120823 RVA: 0x00448AC5 File Offset: 0x00446CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstPush RTimeStopInstPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RTimeStopInstPush)
				{
					return null;
				}
				return (RTimeStopInstPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RTimeStopInstPush);
			}
		}

		// Token: 0x1700640B RID: 25611
		// (get) Token: 0x0601D7F8 RID: 120824 RVA: 0x00448ADC File Offset: 0x00446CDC
		// (set) Token: 0x0601D7F9 RID: 120825 RVA: 0x00448AF5 File Offset: 0x00446CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontagePush FsmPlayMontagePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.FsmPlayMontagePush)
				{
					return null;
				}
				return (FsmPlayMontagePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.FsmPlayMontagePush);
			}
		}

		// Token: 0x1700640C RID: 25612
		// (get) Token: 0x0601D7FA RID: 120826 RVA: 0x00448B0C File Offset: 0x00446D0C
		// (set) Token: 0x0601D7FB RID: 120827 RVA: 0x00448B25 File Offset: 0x00446D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimPush RTimeStopAnimPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RTimeStopAnimPush)
				{
					return null;
				}
				return (RTimeStopAnimPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RTimeStopAnimPush);
			}
		}

		// Token: 0x1700640D RID: 25613
		// (get) Token: 0x0601D7FC RID: 120828 RVA: 0x00448B3C File Offset: 0x00446D3C
		// (set) Token: 0x0601D7FD RID: 120829 RVA: 0x00448B55 File Offset: 0x00446D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagPush GameplayTagPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.GameplayTagPush)
				{
					return null;
				}
				return (GameplayTagPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.GameplayTagPush);
			}
		}

		// Token: 0x1700640E RID: 25614
		// (get) Token: 0x0601D7FE RID: 120830 RVA: 0x00448B6C File Offset: 0x00446D6C
		// (set) Token: 0x0601D7FF RID: 120831 RVA: 0x00448B85 File Offset: 0x00446D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQtePush ExecuteQtePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ExecuteQtePush)
				{
					return null;
				}
				return (ExecuteQtePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ExecuteQtePush);
			}
		}

		// Token: 0x1700640F RID: 25615
		// (get) Token: 0x0601D800 RID: 120832 RVA: 0x00448B9C File Offset: 0x00446D9C
		// (set) Token: 0x0601D801 RID: 120833 RVA: 0x00448BB5 File Offset: 0x00446DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportPush ClientCurrentRoleReportPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush)
				{
					return null;
				}
				return (ClientCurrentRoleReportPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush);
			}
		}

		// Token: 0x17006410 RID: 25616
		// (get) Token: 0x0601D802 RID: 120834 RVA: 0x00448BCC File Offset: 0x00446DCC
		// (set) Token: 0x0601D803 RID: 120835 RVA: 0x00448BE5 File Offset: 0x00446DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEntityMontagePush PlayEntityMontagePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.PlayEntityMontagePush)
				{
					return null;
				}
				return (PlayEntityMontagePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.PlayEntityMontagePush);
			}
		}

		// Token: 0x17006411 RID: 25617
		// (get) Token: 0x0601D804 RID: 120836 RVA: 0x00448BFC File Offset: 0x00446DFC
		// (set) Token: 0x0601D805 RID: 120837 RVA: 0x00448C15 File Offset: 0x00446E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitPush BeforeHitPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.BeforeHitPush)
				{
					return null;
				}
				return (BeforeHitPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.BeforeHitPush);
			}
		}

		// Token: 0x17006412 RID: 25618
		// (get) Token: 0x0601D806 RID: 120838 RVA: 0x00448C2C File Offset: 0x00446E2C
		// (set) Token: 0x0601D807 RID: 120839 RVA: 0x00448C45 File Offset: 0x00446E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkBurstPush NewLinkBurstPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.NewLinkBurstPush)
				{
					return null;
				}
				return (NewLinkBurstPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.NewLinkBurstPush);
			}
		}

		// Token: 0x17006413 RID: 25619
		// (get) Token: 0x0601D808 RID: 120840 RVA: 0x00448C5C File Offset: 0x00446E5C
		// (set) Token: 0x0601D809 RID: 120841 RVA: 0x00448C75 File Offset: 0x00446E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshBuffDurationPush RefreshBuffDurationPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RefreshBuffDurationPush)
				{
					return null;
				}
				return (RefreshBuffDurationPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RefreshBuffDurationPush);
			}
		}

		// Token: 0x17006414 RID: 25620
		// (get) Token: 0x0601D80A RID: 120842 RVA: 0x00448C8C File Offset: 0x00446E8C
		// (set) Token: 0x0601D80B RID: 120843 RVA: 0x00448CA5 File Offset: 0x00446EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownPush RoleGoDownPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RoleGoDownPush)
				{
					return null;
				}
				return (RoleGoDownPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RoleGoDownPush);
			}
		}

		// Token: 0x17006415 RID: 25621
		// (get) Token: 0x0601D80C RID: 120844 RVA: 0x00448CBC File Offset: 0x00446EBC
		// (set) Token: 0x0601D80D RID: 120845 RVA: 0x00448CD5 File Offset: 0x00446ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassPush FsmConditionPassPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.FsmConditionPassPush)
				{
					return null;
				}
				return (FsmConditionPassPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.FsmConditionPassPush);
			}
		}

		// Token: 0x17006416 RID: 25622
		// (get) Token: 0x0601D80E RID: 120846 RVA: 0x00448CEC File Offset: 0x00446EEC
		// (set) Token: 0x0601D80F RID: 120847 RVA: 0x00448D05 File Offset: 0x00446F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecutePush BuffEffectExecutePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.BuffEffectExecutePush)
				{
					return null;
				}
				return (BuffEffectExecutePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.BuffEffectExecutePush);
			}
		}

		// Token: 0x17006417 RID: 25623
		// (get) Token: 0x0601D810 RID: 120848 RVA: 0x00448D1C File Offset: 0x00446F1C
		// (set) Token: 0x0601D811 RID: 120849 RVA: 0x00448D35 File Offset: 0x00446F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerPush VisionTriggerPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.VisionTriggerPush)
				{
					return null;
				}
				return (VisionTriggerPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.VisionTriggerPush);
			}
		}

		// Token: 0x17006418 RID: 25624
		// (get) Token: 0x0601D812 RID: 120850 RVA: 0x00448D4C File Offset: 0x00446F4C
		// (set) Token: 0x0601D813 RID: 120851 RVA: 0x00448D65 File Offset: 0x00446F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorIsEnablePush MotorIsEnablePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.MotorIsEnablePush)
				{
					return null;
				}
				return (MotorIsEnablePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.MotorIsEnablePush);
			}
		}

		// Token: 0x17006419 RID: 25625
		// (get) Token: 0x0601D814 RID: 120852 RVA: 0x00448D7C File Offset: 0x00446F7C
		// (set) Token: 0x0601D815 RID: 120853 RVA: 0x00448D95 File Offset: 0x00446F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSummonAndRidePush MotorSummonAndRidePush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.MotorSummonAndRidePush)
				{
					return null;
				}
				return (MotorSummonAndRidePush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.MotorSummonAndRidePush);
			}
		}

		// Token: 0x1700641A RID: 25626
		// (get) Token: 0x0601D816 RID: 120854 RVA: 0x00448DAC File Offset: 0x00446FAC
		// (set) Token: 0x0601D817 RID: 120855 RVA: 0x00448DC5 File Offset: 0x00446FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletPatternPush BulletPatternPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.BulletPatternPush)
				{
					return null;
				}
				return (BulletPatternPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.BulletPatternPush);
			}
		}

		// Token: 0x1700641B RID: 25627
		// (get) Token: 0x0601D818 RID: 120856 RVA: 0x00448DDC File Offset: 0x00446FDC
		// (set) Token: 0x0601D819 RID: 120857 RVA: 0x00448DF5 File Offset: 0x00446FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackRamVerifyPush QuickHackRamVerifyPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.QuickHackRamVerifyPush)
				{
					return null;
				}
				return (QuickHackRamVerifyPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.QuickHackRamVerifyPush);
			}
		}

		// Token: 0x1700641C RID: 25628
		// (get) Token: 0x0601D81A RID: 120858 RVA: 0x00448E0C File Offset: 0x0044700C
		// (set) Token: 0x0601D81B RID: 120859 RVA: 0x00448E25 File Offset: 0x00447025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackOpenPush QuickHackOpenPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.QuickHackOpenPush)
				{
					return null;
				}
				return (QuickHackOpenPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.QuickHackOpenPush);
			}
		}

		// Token: 0x1700641D RID: 25629
		// (get) Token: 0x0601D81C RID: 120860 RVA: 0x00448E3C File Offset: 0x0044703C
		// (set) Token: 0x0601D81D RID: 120861 RVA: 0x00448E55 File Offset: 0x00447055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DodgeInfoPush DodgeInfoPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.DodgeInfoPush)
				{
					return null;
				}
				return (DodgeInfoPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.DodgeInfoPush);
			}
		}

		// Token: 0x1700641E RID: 25630
		// (get) Token: 0x0601D81E RID: 120862 RVA: 0x00448E6C File Offset: 0x0044706C
		// (set) Token: 0x0601D81F RID: 120863 RVA: 0x00448E85 File Offset: 0x00447085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSceneRollbackPush RoleTrialSceneRollbackPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush)
				{
					return null;
				}
				return (RoleTrialSceneRollbackPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush);
			}
		}

		// Token: 0x1700641F RID: 25631
		// (get) Token: 0x0601D820 RID: 120864 RVA: 0x00448E9C File Offset: 0x0044709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601D821 RID: 120865 RVA: 0x00448EA4 File Offset: 0x004470A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatPushData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601D822 RID: 120866 RVA: 0x00448EB4 File Offset: 0x004470B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatPushData);
		}

		// Token: 0x0601D823 RID: 120867 RVA: 0x00448EC4 File Offset: 0x004470C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatPushData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.ApplyBuffS2CResponsePush, other.ApplyBuffS2CResponsePush) && object.Equals(this.RemoveBuffS2CResponsePush, other.RemoveBuffS2CResponsePush) && object.Equals(this.RemoveBuffByIdS2CResponsePush, other.RemoveBuffByIdS2CResponsePush) && object.Equals(this.CreateBulletPush, other.CreateBulletPush) && object.Equals(this.DestroyBulletPush, other.DestroyBulletPush) && object.Equals(this.ApplyGameplayEffectPush, other.ApplyGameplayEffectPush) && object.Equals(this.RemoveGameplayEffectPush, other.RemoveGameplayEffectPush) && object.Equals(this.HitEndPush, other.HitEndPush) && object.Equals(this.EndSkillPush, other.EndSkillPush) && object.Equals(this.PartUpdatePush, other.PartUpdatePush) && object.Equals(this.MaterialPush, other.MaterialPush) && object.Equals(this.GameplayCuePush, other.GameplayCuePush) && object.Equals(this.EntityIsVisiblePush, other.EntityIsVisiblePush) && object.Equals(this.SwitchCharacterStatePush, other.SwitchCharacterStatePush) && object.Equals(this.LogicStateInitPush, other.LogicStateInitPush) && object.Equals(this.SwitchLogicStatePush, other.SwitchLogicStatePush) && object.Equals(this.AnimationStateChangedPush, other.AnimationStateChangedPush) && object.Equals(this.AnimationStateInitPush, other.AnimationStateInitPush) && object.Equals(this.ModifyBulletParamsPush, other.ModifyBulletParamsPush) && object.Equals(this.DrownPush, other.DrownPush) && object.Equals(this.ActivateBuffPush, other.ActivateBuffPush) && object.Equals(this.AiInformationPush, other.AiInformationPush) && object.Equals(this.ToughCalcExtraRatioChangePush, other.ToughCalcExtraRatioChangePush) && object.Equals(this.BattleStateChangePush, other.BattleStateChangePush) && object.Equals(this.AnimationGameplayTagPush, other.AnimationGameplayTagPush) && object.Equals(this.BoneVisibleChangePush, other.BoneVisibleChangePush) && object.Equals(this.AiBlackboardsPush, other.AiBlackboardsPush) && object.Equals(this.AiBlackboardCdPush, other.AiBlackboardCdPush) && object.Equals(this.AiHatePush, other.AiHatePush) && object.Equals(this.MonsterBoomPush, other.MonsterBoomPush) && object.Equals(this.CaughtPush, other.CaughtPush) && object.Equals(this.EntityStaticHookMovePush, other.EntityStaticHookMovePush) && object.Equals(this.ChangeStateConfirmPush, other.ChangeStateConfirmPush) && object.Equals(this.BuffStackCountPush, other.BuffStackCountPush) && object.Equals(this.ANStartPush, other.ANStartPush) && object.Equals(this.UseSkillFailPush, other.UseSkillFailPush) && object.Equals(this.EnterViewDirectionPush, other.EnterViewDirectionPush) && object.Equals(this.ExitViewDirectionPush, other.ExitViewDirectionPush) && object.Equals(this.PassiveSkillAddPush, other.PassiveSkillAddPush) && object.Equals(this.InterruptSkillInDelayPush, other.InterruptSkillInDelayPush) && object.Equals(this.TriggerExitSkillPush, other.TriggerExitSkillPush) && object.Equals(this.ActorVisiblePush, other.ActorVisiblePush) && object.Equals(this.BuffEffectPush, other.BuffEffectPush) && object.Equals(this.RTimeStopPush, other.RTimeStopPush) && object.Equals(this.DrownEndTeleportPush, other.DrownEndTeleportPush) && object.Equals(this.MonsterDrownPush, other.MonsterDrownPush) && object.Equals(this.PassiveSkillRemovePush, other.PassiveSkillRemovePush) && object.Equals(this.RTimeStopInstPush, other.RTimeStopInstPush) && object.Equals(this.FsmPlayMontagePush, other.FsmPlayMontagePush) && object.Equals(this.RTimeStopAnimPush, other.RTimeStopAnimPush) && object.Equals(this.GameplayTagPush, other.GameplayTagPush) && object.Equals(this.ExecuteQtePush, other.ExecuteQtePush) && object.Equals(this.ClientCurrentRoleReportPush, other.ClientCurrentRoleReportPush) && object.Equals(this.PlayEntityMontagePush, other.PlayEntityMontagePush) && object.Equals(this.BeforeHitPush, other.BeforeHitPush) && object.Equals(this.NewLinkBurstPush, other.NewLinkBurstPush) && object.Equals(this.RefreshBuffDurationPush, other.RefreshBuffDurationPush) && object.Equals(this.RoleGoDownPush, other.RoleGoDownPush) && object.Equals(this.FsmConditionPassPush, other.FsmConditionPassPush) && object.Equals(this.BuffEffectExecutePush, other.BuffEffectExecutePush) && object.Equals(this.VisionTriggerPush, other.VisionTriggerPush) && object.Equals(this.MotorIsEnablePush, other.MotorIsEnablePush) && object.Equals(this.MotorSummonAndRidePush, other.MotorSummonAndRidePush) && object.Equals(this.BulletPatternPush, other.BulletPatternPush) && object.Equals(this.QuickHackRamVerifyPush, other.QuickHackRamVerifyPush) && object.Equals(this.QuickHackOpenPush, other.QuickHackOpenPush) && object.Equals(this.DodgeInfoPush, other.DodgeInfoPush) && object.Equals(this.RoleTrialSceneRollbackPush, other.RoleTrialSceneRollbackPush) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D824 RID: 120868 RVA: 0x004494A8 File Offset: 0x004476A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush)
			{
				num ^= this.ApplyBuffS2CResponsePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush)
			{
				num ^= this.RemoveBuffS2CResponsePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush)
			{
				num ^= this.RemoveBuffByIdS2CResponsePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.CreateBulletPush)
			{
				num ^= this.CreateBulletPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DestroyBulletPush)
			{
				num ^= this.DestroyBulletPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyGameplayEffectPush)
			{
				num ^= this.ApplyGameplayEffectPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveGameplayEffectPush)
			{
				num ^= this.RemoveGameplayEffectPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.HitEndPush)
			{
				num ^= this.HitEndPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EndSkillPush)
			{
				num ^= this.EndSkillPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PartUpdatePush)
			{
				num ^= this.PartUpdatePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MaterialPush)
			{
				num ^= this.MaterialPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayCuePush)
			{
				num ^= this.GameplayCuePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityIsVisiblePush)
			{
				num ^= this.EntityIsVisiblePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchCharacterStatePush)
			{
				num ^= this.SwitchCharacterStatePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.LogicStateInitPush)
			{
				num ^= this.LogicStateInitPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchLogicStatePush)
			{
				num ^= this.SwitchLogicStatePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateChangedPush)
			{
				num ^= this.AnimationStateChangedPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateInitPush)
			{
				num ^= this.AnimationStateInitPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ModifyBulletParamsPush)
			{
				num ^= this.ModifyBulletParamsPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownPush)
			{
				num ^= this.DrownPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ActivateBuffPush)
			{
				num ^= this.ActivateBuffPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiInformationPush)
			{
				num ^= this.AiInformationPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush)
			{
				num ^= this.ToughCalcExtraRatioChangePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BattleStateChangePush)
			{
				num ^= this.BattleStateChangePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationGameplayTagPush)
			{
				num ^= this.AnimationGameplayTagPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BoneVisibleChangePush)
			{
				num ^= this.BoneVisibleChangePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardsPush)
			{
				num ^= this.AiBlackboardsPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardCdPush)
			{
				num ^= this.AiBlackboardCdPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiHatePush)
			{
				num ^= this.AiHatePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterBoomPush)
			{
				num ^= this.MonsterBoomPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.CaughtPush)
			{
				num ^= this.CaughtPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityStaticHookMovePush)
			{
				num ^= this.EntityStaticHookMovePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ChangeStateConfirmPush)
			{
				num ^= this.ChangeStateConfirmPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffStackCountPush)
			{
				num ^= this.BuffStackCountPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ANStartPush)
			{
				num ^= this.ANStartPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.UseSkillFailPush)
			{
				num ^= this.UseSkillFailPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EnterViewDirectionPush)
			{
				num ^= this.EnterViewDirectionPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ExitViewDirectionPush)
			{
				num ^= this.ExitViewDirectionPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillAddPush)
			{
				num ^= this.PassiveSkillAddPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.InterruptSkillInDelayPush)
			{
				num ^= this.InterruptSkillInDelayPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.TriggerExitSkillPush)
			{
				num ^= this.TriggerExitSkillPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ActorVisiblePush)
			{
				num ^= this.ActorVisiblePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectPush)
			{
				num ^= this.BuffEffectPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopPush)
			{
				num ^= this.RTimeStopPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownEndTeleportPush)
			{
				num ^= this.DrownEndTeleportPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterDrownPush)
			{
				num ^= this.MonsterDrownPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillRemovePush)
			{
				num ^= this.PassiveSkillRemovePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopInstPush)
			{
				num ^= this.RTimeStopInstPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmPlayMontagePush)
			{
				num ^= this.FsmPlayMontagePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopAnimPush)
			{
				num ^= this.RTimeStopAnimPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayTagPush)
			{
				num ^= this.GameplayTagPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ExecuteQtePush)
			{
				num ^= this.ExecuteQtePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush)
			{
				num ^= this.ClientCurrentRoleReportPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PlayEntityMontagePush)
			{
				num ^= this.PlayEntityMontagePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BeforeHitPush)
			{
				num ^= this.BeforeHitPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.NewLinkBurstPush)
			{
				num ^= this.NewLinkBurstPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RefreshBuffDurationPush)
			{
				num ^= this.RefreshBuffDurationPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleGoDownPush)
			{
				num ^= this.RoleGoDownPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmConditionPassPush)
			{
				num ^= this.FsmConditionPassPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectExecutePush)
			{
				num ^= this.BuffEffectExecutePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.VisionTriggerPush)
			{
				num ^= this.VisionTriggerPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorIsEnablePush)
			{
				num ^= this.MotorIsEnablePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorSummonAndRidePush)
			{
				num ^= this.MotorSummonAndRidePush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BulletPatternPush)
			{
				num ^= this.BulletPatternPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackRamVerifyPush)
			{
				num ^= this.QuickHackRamVerifyPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackOpenPush)
			{
				num ^= this.QuickHackOpenPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DodgeInfoPush)
			{
				num ^= this.DodgeInfoPush.GetHashCode();
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush)
			{
				num ^= this.RoleTrialSceneRollbackPush.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D825 RID: 120869 RVA: 0x00449B48 File Offset: 0x00447D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D826 RID: 120870 RVA: 0x00449B55 File Offset: 0x00447D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D827 RID: 120871 RVA: 0x00449B60 File Offset: 0x00447D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ApplyBuffS2CResponsePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RemoveBuffS2CResponsePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RemoveBuffByIdS2CResponsePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.CreateBulletPush)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CreateBulletPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DestroyBulletPush)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.DestroyBulletPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyGameplayEffectPush)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ApplyGameplayEffectPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveGameplayEffectPush)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RemoveGameplayEffectPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.HitEndPush)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.HitEndPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EndSkillPush)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EndSkillPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PartUpdatePush)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PartUpdatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MaterialPush)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MaterialPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayCuePush)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GameplayCuePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityIsVisiblePush)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.EntityIsVisiblePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchCharacterStatePush)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.SwitchCharacterStatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.LogicStateInitPush)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.LogicStateInitPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchLogicStatePush)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.SwitchLogicStatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateChangedPush)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.AnimationStateChangedPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateInitPush)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.AnimationStateInitPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ModifyBulletParamsPush)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.ModifyBulletParamsPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownPush)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.DrownPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ActivateBuffPush)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.ActivateBuffPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiInformationPush)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.AiInformationPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.ToughCalcExtraRatioChangePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BattleStateChangePush)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.BattleStateChangePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationGameplayTagPush)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.AnimationGameplayTagPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BoneVisibleChangePush)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.BoneVisibleChangePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardsPush)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.AiBlackboardsPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardCdPush)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.AiBlackboardCdPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiHatePush)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.AiHatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterBoomPush)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.MonsterBoomPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.CaughtPush)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.CaughtPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityStaticHookMovePush)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.EntityStaticHookMovePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ChangeStateConfirmPush)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.ChangeStateConfirmPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffStackCountPush)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.BuffStackCountPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ANStartPush)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.ANStartPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.UseSkillFailPush)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.UseSkillFailPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EnterViewDirectionPush)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.EnterViewDirectionPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ExitViewDirectionPush)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.ExitViewDirectionPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillAddPush)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.PassiveSkillAddPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.InterruptSkillInDelayPush)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.InterruptSkillInDelayPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.TriggerExitSkillPush)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.TriggerExitSkillPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ActorVisiblePush)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.ActorVisiblePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectPush)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.BuffEffectPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopPush)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.RTimeStopPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownEndTeleportPush)
			{
				output.WriteRawTag(130, 3);
				output.WriteMessage(this.DrownEndTeleportPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterDrownPush)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.MonsterDrownPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillRemovePush)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.PassiveSkillRemovePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopInstPush)
			{
				output.WriteRawTag(154, 3);
				output.WriteMessage(this.RTimeStopInstPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmPlayMontagePush)
			{
				output.WriteRawTag(162, 3);
				output.WriteMessage(this.FsmPlayMontagePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopAnimPush)
			{
				output.WriteRawTag(170, 3);
				output.WriteMessage(this.RTimeStopAnimPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayTagPush)
			{
				output.WriteRawTag(178, 3);
				output.WriteMessage(this.GameplayTagPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ExecuteQtePush)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.ExecuteQtePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.ClientCurrentRoleReportPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PlayEntityMontagePush)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.PlayEntityMontagePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BeforeHitPush)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.BeforeHitPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.NewLinkBurstPush)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.NewLinkBurstPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RefreshBuffDurationPush)
			{
				output.WriteRawTag(226, 3);
				output.WriteMessage(this.RefreshBuffDurationPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleGoDownPush)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.RoleGoDownPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmConditionPassPush)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.FsmConditionPassPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectExecutePush)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.BuffEffectExecutePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.VisionTriggerPush)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.VisionTriggerPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorIsEnablePush)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.MotorIsEnablePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorSummonAndRidePush)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.MotorSummonAndRidePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BulletPatternPush)
			{
				output.WriteRawTag(154, 4);
				output.WriteMessage(this.BulletPatternPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackRamVerifyPush)
			{
				output.WriteRawTag(162, 4);
				output.WriteMessage(this.QuickHackRamVerifyPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackOpenPush)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.QuickHackOpenPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DodgeInfoPush)
			{
				output.WriteRawTag(178, 4);
				output.WriteMessage(this.DodgeInfoPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.RoleTrialSceneRollbackPush);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D828 RID: 120872 RVA: 0x0044A470 File Offset: 0x00448670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApplyBuffS2CResponsePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveBuffS2CResponsePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveBuffByIdS2CResponsePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.CreateBulletPush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CreateBulletPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DestroyBulletPush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DestroyBulletPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyGameplayEffectPush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApplyGameplayEffectPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveGameplayEffectPush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveGameplayEffectPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.HitEndPush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitEndPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EndSkillPush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndSkillPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PartUpdatePush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartUpdatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MaterialPush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MaterialPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayCuePush)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameplayCuePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityIsVisiblePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityIsVisiblePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchCharacterStatePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchCharacterStatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.LogicStateInitPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LogicStateInitPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchLogicStatePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchLogicStatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateChangedPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateChangedPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateInitPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateInitPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ModifyBulletParamsPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParamsPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ActivateBuffPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActivateBuffPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiInformationPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiInformationPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ToughCalcExtraRatioChangePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BattleStateChangePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BattleStateChangePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationGameplayTagPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationGameplayTagPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BoneVisibleChangePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleChangePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardsPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardsPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardCdPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardCdPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.AiHatePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiHatePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterBoomPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterBoomPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.CaughtPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CaughtPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityStaticHookMovePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityStaticHookMovePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ChangeStateConfirmPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateConfirmPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffStackCountPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffStackCountPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ANStartPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ANStartPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.UseSkillFailPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.UseSkillFailPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.EnterViewDirectionPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EnterViewDirectionPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ExitViewDirectionPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExitViewDirectionPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillAddPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillAddPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.InterruptSkillInDelayPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InterruptSkillInDelayPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.TriggerExitSkillPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TriggerExitSkillPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ActorVisiblePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActorVisiblePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffEffectPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownEndTeleportPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownEndTeleportPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterDrownPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterDrownPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillRemovePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillRemovePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopInstPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopInstPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmPlayMontagePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmPlayMontagePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopAnimPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopAnimPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayTagPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GameplayTagPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ExecuteQtePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExecuteQtePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ClientCurrentRoleReportPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.PlayEntityMontagePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayEntityMontagePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BeforeHitPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BeforeHitPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.NewLinkBurstPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewLinkBurstPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RefreshBuffDurationPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RefreshBuffDurationPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleGoDownPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleGoDownPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmConditionPassPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmConditionPassPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectExecutePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffEffectExecutePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.VisionTriggerPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VisionTriggerPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorIsEnablePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorIsEnablePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorSummonAndRidePush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorSummonAndRidePush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.BulletPatternPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BulletPatternPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackRamVerifyPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.QuickHackRamVerifyPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackOpenPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.QuickHackOpenPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.DodgeInfoPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DodgeInfoPush);
			}
			if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleTrialSceneRollbackPush);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D829 RID: 120873 RVA: 0x0044AB94 File Offset: 0x00448D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatPushData other)
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
			case CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush:
				if (this.ApplyBuffS2CResponsePush == null)
				{
					this.ApplyBuffS2CResponsePush = new ApplyBuffS2cResponsePush();
				}
				this.ApplyBuffS2CResponsePush.MergeFrom(other.ApplyBuffS2CResponsePush);
				break;
			case CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush:
				if (this.RemoveBuffS2CResponsePush == null)
				{
					this.RemoveBuffS2CResponsePush = new RemoveBuffS2cResponsePush();
				}
				this.RemoveBuffS2CResponsePush.MergeFrom(other.RemoveBuffS2CResponsePush);
				break;
			case CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush:
				if (this.RemoveBuffByIdS2CResponsePush == null)
				{
					this.RemoveBuffByIdS2CResponsePush = new RemoveBuffByIdS2cResponsePush();
				}
				this.RemoveBuffByIdS2CResponsePush.MergeFrom(other.RemoveBuffByIdS2CResponsePush);
				break;
			case CombatPushData.MessageOneofCase.CreateBulletPush:
				if (this.CreateBulletPush == null)
				{
					this.CreateBulletPush = new CreateBulletPush();
				}
				this.CreateBulletPush.MergeFrom(other.CreateBulletPush);
				break;
			case CombatPushData.MessageOneofCase.DestroyBulletPush:
				if (this.DestroyBulletPush == null)
				{
					this.DestroyBulletPush = new DestroyBulletPush();
				}
				this.DestroyBulletPush.MergeFrom(other.DestroyBulletPush);
				break;
			case CombatPushData.MessageOneofCase.ApplyGameplayEffectPush:
				if (this.ApplyGameplayEffectPush == null)
				{
					this.ApplyGameplayEffectPush = new ApplyGameplayEffectPush();
				}
				this.ApplyGameplayEffectPush.MergeFrom(other.ApplyGameplayEffectPush);
				break;
			case CombatPushData.MessageOneofCase.RemoveGameplayEffectPush:
				if (this.RemoveGameplayEffectPush == null)
				{
					this.RemoveGameplayEffectPush = new RemoveGameplayEffectPush();
				}
				this.RemoveGameplayEffectPush.MergeFrom(other.RemoveGameplayEffectPush);
				break;
			case CombatPushData.MessageOneofCase.HitEndPush:
				if (this.HitEndPush == null)
				{
					this.HitEndPush = new HitEndPush();
				}
				this.HitEndPush.MergeFrom(other.HitEndPush);
				break;
			case CombatPushData.MessageOneofCase.EndSkillPush:
				if (this.EndSkillPush == null)
				{
					this.EndSkillPush = new EndSkillPush();
				}
				this.EndSkillPush.MergeFrom(other.EndSkillPush);
				break;
			case CombatPushData.MessageOneofCase.PartUpdatePush:
				if (this.PartUpdatePush == null)
				{
					this.PartUpdatePush = new PartUpdatePush();
				}
				this.PartUpdatePush.MergeFrom(other.PartUpdatePush);
				break;
			case CombatPushData.MessageOneofCase.MaterialPush:
				if (this.MaterialPush == null)
				{
					this.MaterialPush = new MaterialPush();
				}
				this.MaterialPush.MergeFrom(other.MaterialPush);
				break;
			case CombatPushData.MessageOneofCase.GameplayCuePush:
				if (this.GameplayCuePush == null)
				{
					this.GameplayCuePush = new GameplayCuePush();
				}
				this.GameplayCuePush.MergeFrom(other.GameplayCuePush);
				break;
			case CombatPushData.MessageOneofCase.EntityIsVisiblePush:
				if (this.EntityIsVisiblePush == null)
				{
					this.EntityIsVisiblePush = new EntityIsVisiblePush();
				}
				this.EntityIsVisiblePush.MergeFrom(other.EntityIsVisiblePush);
				break;
			case CombatPushData.MessageOneofCase.SwitchCharacterStatePush:
				if (this.SwitchCharacterStatePush == null)
				{
					this.SwitchCharacterStatePush = new SwitchCharacterStatePush();
				}
				this.SwitchCharacterStatePush.MergeFrom(other.SwitchCharacterStatePush);
				break;
			case CombatPushData.MessageOneofCase.LogicStateInitPush:
				if (this.LogicStateInitPush == null)
				{
					this.LogicStateInitPush = new LogicStateInitPush();
				}
				this.LogicStateInitPush.MergeFrom(other.LogicStateInitPush);
				break;
			case CombatPushData.MessageOneofCase.SwitchLogicStatePush:
				if (this.SwitchLogicStatePush == null)
				{
					this.SwitchLogicStatePush = new SwitchLogicStatePush();
				}
				this.SwitchLogicStatePush.MergeFrom(other.SwitchLogicStatePush);
				break;
			case CombatPushData.MessageOneofCase.AnimationStateChangedPush:
				if (this.AnimationStateChangedPush == null)
				{
					this.AnimationStateChangedPush = new AnimationStateChangedPush();
				}
				this.AnimationStateChangedPush.MergeFrom(other.AnimationStateChangedPush);
				break;
			case CombatPushData.MessageOneofCase.AnimationStateInitPush:
				if (this.AnimationStateInitPush == null)
				{
					this.AnimationStateInitPush = new AnimationStateInitPush();
				}
				this.AnimationStateInitPush.MergeFrom(other.AnimationStateInitPush);
				break;
			case CombatPushData.MessageOneofCase.ModifyBulletParamsPush:
				if (this.ModifyBulletParamsPush == null)
				{
					this.ModifyBulletParamsPush = new ModifyBulletParamsPush();
				}
				this.ModifyBulletParamsPush.MergeFrom(other.ModifyBulletParamsPush);
				break;
			case CombatPushData.MessageOneofCase.DrownPush:
				if (this.DrownPush == null)
				{
					this.DrownPush = new DrownPush();
				}
				this.DrownPush.MergeFrom(other.DrownPush);
				break;
			case CombatPushData.MessageOneofCase.ActivateBuffPush:
				if (this.ActivateBuffPush == null)
				{
					this.ActivateBuffPush = new ActivateBuffPush();
				}
				this.ActivateBuffPush.MergeFrom(other.ActivateBuffPush);
				break;
			case CombatPushData.MessageOneofCase.AiInformationPush:
				if (this.AiInformationPush == null)
				{
					this.AiInformationPush = new AiInformationPush();
				}
				this.AiInformationPush.MergeFrom(other.AiInformationPush);
				break;
			case CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush:
				if (this.ToughCalcExtraRatioChangePush == null)
				{
					this.ToughCalcExtraRatioChangePush = new ToughCalcExtraRatioChangePush();
				}
				this.ToughCalcExtraRatioChangePush.MergeFrom(other.ToughCalcExtraRatioChangePush);
				break;
			case CombatPushData.MessageOneofCase.BattleStateChangePush:
				if (this.BattleStateChangePush == null)
				{
					this.BattleStateChangePush = new BattleStateChangePush();
				}
				this.BattleStateChangePush.MergeFrom(other.BattleStateChangePush);
				break;
			case CombatPushData.MessageOneofCase.AnimationGameplayTagPush:
				if (this.AnimationGameplayTagPush == null)
				{
					this.AnimationGameplayTagPush = new AnimationGameplayTagPush();
				}
				this.AnimationGameplayTagPush.MergeFrom(other.AnimationGameplayTagPush);
				break;
			case CombatPushData.MessageOneofCase.BoneVisibleChangePush:
				if (this.BoneVisibleChangePush == null)
				{
					this.BoneVisibleChangePush = new BoneVisibleChangePush();
				}
				this.BoneVisibleChangePush.MergeFrom(other.BoneVisibleChangePush);
				break;
			case CombatPushData.MessageOneofCase.AiBlackboardsPush:
				if (this.AiBlackboardsPush == null)
				{
					this.AiBlackboardsPush = new AiBlackboardsPush();
				}
				this.AiBlackboardsPush.MergeFrom(other.AiBlackboardsPush);
				break;
			case CombatPushData.MessageOneofCase.AiBlackboardCdPush:
				if (this.AiBlackboardCdPush == null)
				{
					this.AiBlackboardCdPush = new AiBlackboardCdPush();
				}
				this.AiBlackboardCdPush.MergeFrom(other.AiBlackboardCdPush);
				break;
			case CombatPushData.MessageOneofCase.AiHatePush:
				if (this.AiHatePush == null)
				{
					this.AiHatePush = new AiHatePush();
				}
				this.AiHatePush.MergeFrom(other.AiHatePush);
				break;
			case CombatPushData.MessageOneofCase.MonsterBoomPush:
				if (this.MonsterBoomPush == null)
				{
					this.MonsterBoomPush = new MonsterBoomPush();
				}
				this.MonsterBoomPush.MergeFrom(other.MonsterBoomPush);
				break;
			case CombatPushData.MessageOneofCase.CaughtPush:
				if (this.CaughtPush == null)
				{
					this.CaughtPush = new CaughtPush();
				}
				this.CaughtPush.MergeFrom(other.CaughtPush);
				break;
			case CombatPushData.MessageOneofCase.EntityStaticHookMovePush:
				if (this.EntityStaticHookMovePush == null)
				{
					this.EntityStaticHookMovePush = new EntityStaticHookMovePush();
				}
				this.EntityStaticHookMovePush.MergeFrom(other.EntityStaticHookMovePush);
				break;
			case CombatPushData.MessageOneofCase.ChangeStateConfirmPush:
				if (this.ChangeStateConfirmPush == null)
				{
					this.ChangeStateConfirmPush = new ChangeStateConfirmPush();
				}
				this.ChangeStateConfirmPush.MergeFrom(other.ChangeStateConfirmPush);
				break;
			case CombatPushData.MessageOneofCase.BuffStackCountPush:
				if (this.BuffStackCountPush == null)
				{
					this.BuffStackCountPush = new BuffStackCountPush();
				}
				this.BuffStackCountPush.MergeFrom(other.BuffStackCountPush);
				break;
			case CombatPushData.MessageOneofCase.ANStartPush:
				if (this.ANStartPush == null)
				{
					this.ANStartPush = new ANStartPush();
				}
				this.ANStartPush.MergeFrom(other.ANStartPush);
				break;
			case CombatPushData.MessageOneofCase.UseSkillFailPush:
				if (this.UseSkillFailPush == null)
				{
					this.UseSkillFailPush = new UseSkillFailPush();
				}
				this.UseSkillFailPush.MergeFrom(other.UseSkillFailPush);
				break;
			case CombatPushData.MessageOneofCase.EnterViewDirectionPush:
				if (this.EnterViewDirectionPush == null)
				{
					this.EnterViewDirectionPush = new EnterViewDirectionPush();
				}
				this.EnterViewDirectionPush.MergeFrom(other.EnterViewDirectionPush);
				break;
			case CombatPushData.MessageOneofCase.ExitViewDirectionPush:
				if (this.ExitViewDirectionPush == null)
				{
					this.ExitViewDirectionPush = new ExitViewDirectionPush();
				}
				this.ExitViewDirectionPush.MergeFrom(other.ExitViewDirectionPush);
				break;
			case CombatPushData.MessageOneofCase.PassiveSkillAddPush:
				if (this.PassiveSkillAddPush == null)
				{
					this.PassiveSkillAddPush = new PassiveSkillAddPush();
				}
				this.PassiveSkillAddPush.MergeFrom(other.PassiveSkillAddPush);
				break;
			case CombatPushData.MessageOneofCase.InterruptSkillInDelayPush:
				if (this.InterruptSkillInDelayPush == null)
				{
					this.InterruptSkillInDelayPush = new InterruptSkillInDelayPush();
				}
				this.InterruptSkillInDelayPush.MergeFrom(other.InterruptSkillInDelayPush);
				break;
			case CombatPushData.MessageOneofCase.TriggerExitSkillPush:
				if (this.TriggerExitSkillPush == null)
				{
					this.TriggerExitSkillPush = new TriggerExitSkillPush();
				}
				this.TriggerExitSkillPush.MergeFrom(other.TriggerExitSkillPush);
				break;
			case CombatPushData.MessageOneofCase.ActorVisiblePush:
				if (this.ActorVisiblePush == null)
				{
					this.ActorVisiblePush = new ActorVisiblePush();
				}
				this.ActorVisiblePush.MergeFrom(other.ActorVisiblePush);
				break;
			case CombatPushData.MessageOneofCase.BuffEffectPush:
				if (this.BuffEffectPush == null)
				{
					this.BuffEffectPush = new BuffEffectPush();
				}
				this.BuffEffectPush.MergeFrom(other.BuffEffectPush);
				break;
			case CombatPushData.MessageOneofCase.RTimeStopPush:
				if (this.RTimeStopPush == null)
				{
					this.RTimeStopPush = new RTimeStopPush();
				}
				this.RTimeStopPush.MergeFrom(other.RTimeStopPush);
				break;
			case CombatPushData.MessageOneofCase.DrownEndTeleportPush:
				if (this.DrownEndTeleportPush == null)
				{
					this.DrownEndTeleportPush = new DrownEndTeleportPush();
				}
				this.DrownEndTeleportPush.MergeFrom(other.DrownEndTeleportPush);
				break;
			case CombatPushData.MessageOneofCase.MonsterDrownPush:
				if (this.MonsterDrownPush == null)
				{
					this.MonsterDrownPush = new MonsterDrownPush();
				}
				this.MonsterDrownPush.MergeFrom(other.MonsterDrownPush);
				break;
			case CombatPushData.MessageOneofCase.PassiveSkillRemovePush:
				if (this.PassiveSkillRemovePush == null)
				{
					this.PassiveSkillRemovePush = new PassiveSkillRemovePush();
				}
				this.PassiveSkillRemovePush.MergeFrom(other.PassiveSkillRemovePush);
				break;
			case CombatPushData.MessageOneofCase.RTimeStopInstPush:
				if (this.RTimeStopInstPush == null)
				{
					this.RTimeStopInstPush = new RTimeStopInstPush();
				}
				this.RTimeStopInstPush.MergeFrom(other.RTimeStopInstPush);
				break;
			case CombatPushData.MessageOneofCase.FsmPlayMontagePush:
				if (this.FsmPlayMontagePush == null)
				{
					this.FsmPlayMontagePush = new FsmPlayMontagePush();
				}
				this.FsmPlayMontagePush.MergeFrom(other.FsmPlayMontagePush);
				break;
			case CombatPushData.MessageOneofCase.RTimeStopAnimPush:
				if (this.RTimeStopAnimPush == null)
				{
					this.RTimeStopAnimPush = new RTimeStopAnimPush();
				}
				this.RTimeStopAnimPush.MergeFrom(other.RTimeStopAnimPush);
				break;
			case CombatPushData.MessageOneofCase.GameplayTagPush:
				if (this.GameplayTagPush == null)
				{
					this.GameplayTagPush = new GameplayTagPush();
				}
				this.GameplayTagPush.MergeFrom(other.GameplayTagPush);
				break;
			case CombatPushData.MessageOneofCase.ExecuteQtePush:
				if (this.ExecuteQtePush == null)
				{
					this.ExecuteQtePush = new ExecuteQtePush();
				}
				this.ExecuteQtePush.MergeFrom(other.ExecuteQtePush);
				break;
			case CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush:
				if (this.ClientCurrentRoleReportPush == null)
				{
					this.ClientCurrentRoleReportPush = new ClientCurrentRoleReportPush();
				}
				this.ClientCurrentRoleReportPush.MergeFrom(other.ClientCurrentRoleReportPush);
				break;
			case CombatPushData.MessageOneofCase.PlayEntityMontagePush:
				if (this.PlayEntityMontagePush == null)
				{
					this.PlayEntityMontagePush = new PlayEntityMontagePush();
				}
				this.PlayEntityMontagePush.MergeFrom(other.PlayEntityMontagePush);
				break;
			case CombatPushData.MessageOneofCase.BeforeHitPush:
				if (this.BeforeHitPush == null)
				{
					this.BeforeHitPush = new BeforeHitPush();
				}
				this.BeforeHitPush.MergeFrom(other.BeforeHitPush);
				break;
			case CombatPushData.MessageOneofCase.NewLinkBurstPush:
				if (this.NewLinkBurstPush == null)
				{
					this.NewLinkBurstPush = new NewLinkBurstPush();
				}
				this.NewLinkBurstPush.MergeFrom(other.NewLinkBurstPush);
				break;
			case CombatPushData.MessageOneofCase.RefreshBuffDurationPush:
				if (this.RefreshBuffDurationPush == null)
				{
					this.RefreshBuffDurationPush = new RefreshBuffDurationPush();
				}
				this.RefreshBuffDurationPush.MergeFrom(other.RefreshBuffDurationPush);
				break;
			case CombatPushData.MessageOneofCase.RoleGoDownPush:
				if (this.RoleGoDownPush == null)
				{
					this.RoleGoDownPush = new RoleGoDownPush();
				}
				this.RoleGoDownPush.MergeFrom(other.RoleGoDownPush);
				break;
			case CombatPushData.MessageOneofCase.FsmConditionPassPush:
				if (this.FsmConditionPassPush == null)
				{
					this.FsmConditionPassPush = new FsmConditionPassPush();
				}
				this.FsmConditionPassPush.MergeFrom(other.FsmConditionPassPush);
				break;
			case CombatPushData.MessageOneofCase.BuffEffectExecutePush:
				if (this.BuffEffectExecutePush == null)
				{
					this.BuffEffectExecutePush = new BuffEffectExecutePush();
				}
				this.BuffEffectExecutePush.MergeFrom(other.BuffEffectExecutePush);
				break;
			case CombatPushData.MessageOneofCase.VisionTriggerPush:
				if (this.VisionTriggerPush == null)
				{
					this.VisionTriggerPush = new VisionTriggerPush();
				}
				this.VisionTriggerPush.MergeFrom(other.VisionTriggerPush);
				break;
			case CombatPushData.MessageOneofCase.MotorIsEnablePush:
				if (this.MotorIsEnablePush == null)
				{
					this.MotorIsEnablePush = new MotorIsEnablePush();
				}
				this.MotorIsEnablePush.MergeFrom(other.MotorIsEnablePush);
				break;
			case CombatPushData.MessageOneofCase.MotorSummonAndRidePush:
				if (this.MotorSummonAndRidePush == null)
				{
					this.MotorSummonAndRidePush = new MotorSummonAndRidePush();
				}
				this.MotorSummonAndRidePush.MergeFrom(other.MotorSummonAndRidePush);
				break;
			case CombatPushData.MessageOneofCase.BulletPatternPush:
				if (this.BulletPatternPush == null)
				{
					this.BulletPatternPush = new BulletPatternPush();
				}
				this.BulletPatternPush.MergeFrom(other.BulletPatternPush);
				break;
			case CombatPushData.MessageOneofCase.QuickHackRamVerifyPush:
				if (this.QuickHackRamVerifyPush == null)
				{
					this.QuickHackRamVerifyPush = new QuickHackRamVerifyPush();
				}
				this.QuickHackRamVerifyPush.MergeFrom(other.QuickHackRamVerifyPush);
				break;
			case CombatPushData.MessageOneofCase.QuickHackOpenPush:
				if (this.QuickHackOpenPush == null)
				{
					this.QuickHackOpenPush = new QuickHackOpenPush();
				}
				this.QuickHackOpenPush.MergeFrom(other.QuickHackOpenPush);
				break;
			case CombatPushData.MessageOneofCase.DodgeInfoPush:
				if (this.DodgeInfoPush == null)
				{
					this.DodgeInfoPush = new DodgeInfoPush();
				}
				this.DodgeInfoPush.MergeFrom(other.DodgeInfoPush);
				break;
			case CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush:
				if (this.RoleTrialSceneRollbackPush == null)
				{
					this.RoleTrialSceneRollbackPush = new RoleTrialSceneRollbackPush();
				}
				this.RoleTrialSceneRollbackPush.MergeFrom(other.RoleTrialSceneRollbackPush);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D82A RID: 120874 RVA: 0x0044B7E6 File Offset: 0x004499E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D82B RID: 120875 RVA: 0x0044B7F0 File Offset: 0x004499F0
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
					if (num <= 154U)
					{
						if (num <= 82U)
						{
							if (num <= 50U)
							{
								if (num <= 34U)
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
									if (num == 34U)
									{
										ApplyBuffS2cResponsePush applyBuffS2cResponsePush = new ApplyBuffS2cResponsePush();
										if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyBuffS2CResponsePush)
										{
											applyBuffS2cResponsePush.MergeFrom(this.ApplyBuffS2CResponsePush);
										}
										input.ReadMessage(applyBuffS2cResponsePush);
										this.ApplyBuffS2CResponsePush = applyBuffS2cResponsePush;
										continue;
									}
								}
								else
								{
									if (num == 42U)
									{
										RemoveBuffS2cResponsePush removeBuffS2cResponsePush = new RemoveBuffS2cResponsePush();
										if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffS2CResponsePush)
										{
											removeBuffS2cResponsePush.MergeFrom(this.RemoveBuffS2CResponsePush);
										}
										input.ReadMessage(removeBuffS2cResponsePush);
										this.RemoveBuffS2CResponsePush = removeBuffS2cResponsePush;
										continue;
									}
									if (num == 50U)
									{
										RemoveBuffByIdS2cResponsePush removeBuffByIdS2cResponsePush = new RemoveBuffByIdS2cResponsePush();
										if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveBuffByIdS2CResponsePush)
										{
											removeBuffByIdS2cResponsePush.MergeFrom(this.RemoveBuffByIdS2CResponsePush);
										}
										input.ReadMessage(removeBuffByIdS2cResponsePush);
										this.RemoveBuffByIdS2CResponsePush = removeBuffByIdS2cResponsePush;
										continue;
									}
								}
							}
							else if (num <= 66U)
							{
								if (num == 58U)
								{
									CreateBulletPush createBulletPush = new CreateBulletPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.CreateBulletPush)
									{
										createBulletPush.MergeFrom(this.CreateBulletPush);
									}
									input.ReadMessage(createBulletPush);
									this.CreateBulletPush = createBulletPush;
									continue;
								}
								if (num == 66U)
								{
									DestroyBulletPush destroyBulletPush = new DestroyBulletPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.DestroyBulletPush)
									{
										destroyBulletPush.MergeFrom(this.DestroyBulletPush);
									}
									input.ReadMessage(destroyBulletPush);
									this.DestroyBulletPush = destroyBulletPush;
									continue;
								}
							}
							else
							{
								if (num == 74U)
								{
									ApplyGameplayEffectPush applyGameplayEffectPush = new ApplyGameplayEffectPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.ApplyGameplayEffectPush)
									{
										applyGameplayEffectPush.MergeFrom(this.ApplyGameplayEffectPush);
									}
									input.ReadMessage(applyGameplayEffectPush);
									this.ApplyGameplayEffectPush = applyGameplayEffectPush;
									continue;
								}
								if (num == 82U)
								{
									RemoveGameplayEffectPush removeGameplayEffectPush = new RemoveGameplayEffectPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.RemoveGameplayEffectPush)
									{
										removeGameplayEffectPush.MergeFrom(this.RemoveGameplayEffectPush);
									}
									input.ReadMessage(removeGameplayEffectPush);
									this.RemoveGameplayEffectPush = removeGameplayEffectPush;
									continue;
								}
							}
						}
						else if (num <= 114U)
						{
							if (num <= 98U)
							{
								if (num == 90U)
								{
									HitEndPush hitEndPush = new HitEndPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.HitEndPush)
									{
										hitEndPush.MergeFrom(this.HitEndPush);
									}
									input.ReadMessage(hitEndPush);
									this.HitEndPush = hitEndPush;
									continue;
								}
								if (num == 98U)
								{
									EndSkillPush endSkillPush = new EndSkillPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.EndSkillPush)
									{
										endSkillPush.MergeFrom(this.EndSkillPush);
									}
									input.ReadMessage(endSkillPush);
									this.EndSkillPush = endSkillPush;
									continue;
								}
							}
							else
							{
								if (num == 106U)
								{
									PartUpdatePush partUpdatePush = new PartUpdatePush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.PartUpdatePush)
									{
										partUpdatePush.MergeFrom(this.PartUpdatePush);
									}
									input.ReadMessage(partUpdatePush);
									this.PartUpdatePush = partUpdatePush;
									continue;
								}
								if (num == 114U)
								{
									MaterialPush materialPush = new MaterialPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.MaterialPush)
									{
										materialPush.MergeFrom(this.MaterialPush);
									}
									input.ReadMessage(materialPush);
									this.MaterialPush = materialPush;
									continue;
								}
							}
						}
						else if (num <= 130U)
						{
							if (num == 122U)
							{
								GameplayCuePush gameplayCuePush = new GameplayCuePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayCuePush)
								{
									gameplayCuePush.MergeFrom(this.GameplayCuePush);
								}
								input.ReadMessage(gameplayCuePush);
								this.GameplayCuePush = gameplayCuePush;
								continue;
							}
							if (num == 130U)
							{
								EntityIsVisiblePush entityIsVisiblePush = new EntityIsVisiblePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityIsVisiblePush)
								{
									entityIsVisiblePush.MergeFrom(this.EntityIsVisiblePush);
								}
								input.ReadMessage(entityIsVisiblePush);
								this.EntityIsVisiblePush = entityIsVisiblePush;
								continue;
							}
						}
						else
						{
							if (num == 138U)
							{
								SwitchCharacterStatePush switchCharacterStatePush = new SwitchCharacterStatePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchCharacterStatePush)
								{
									switchCharacterStatePush.MergeFrom(this.SwitchCharacterStatePush);
								}
								input.ReadMessage(switchCharacterStatePush);
								this.SwitchCharacterStatePush = switchCharacterStatePush;
								continue;
							}
							if (num == 146U)
							{
								LogicStateInitPush logicStateInitPush = new LogicStateInitPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.LogicStateInitPush)
								{
									logicStateInitPush.MergeFrom(this.LogicStateInitPush);
								}
								input.ReadMessage(logicStateInitPush);
								this.LogicStateInitPush = logicStateInitPush;
								continue;
							}
							if (num == 154U)
							{
								SwitchLogicStatePush switchLogicStatePush = new SwitchLogicStatePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchLogicStatePush)
								{
									switchLogicStatePush.MergeFrom(this.SwitchLogicStatePush);
								}
								input.ReadMessage(switchLogicStatePush);
								this.SwitchLogicStatePush = switchLogicStatePush;
								continue;
							}
						}
					}
					else if (num <= 218U)
					{
						if (num <= 186U)
						{
							if (num <= 170U)
							{
								if (num == 162U)
								{
									AnimationStateChangedPush animationStateChangedPush = new AnimationStateChangedPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateChangedPush)
									{
										animationStateChangedPush.MergeFrom(this.AnimationStateChangedPush);
									}
									input.ReadMessage(animationStateChangedPush);
									this.AnimationStateChangedPush = animationStateChangedPush;
									continue;
								}
								if (num == 170U)
								{
									AnimationStateInitPush animationStateInitPush = new AnimationStateInitPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationStateInitPush)
									{
										animationStateInitPush.MergeFrom(this.AnimationStateInitPush);
									}
									input.ReadMessage(animationStateInitPush);
									this.AnimationStateInitPush = animationStateInitPush;
									continue;
								}
							}
							else
							{
								if (num == 178U)
								{
									ModifyBulletParamsPush modifyBulletParamsPush = new ModifyBulletParamsPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.ModifyBulletParamsPush)
									{
										modifyBulletParamsPush.MergeFrom(this.ModifyBulletParamsPush);
									}
									input.ReadMessage(modifyBulletParamsPush);
									this.ModifyBulletParamsPush = modifyBulletParamsPush;
									continue;
								}
								if (num == 186U)
								{
									DrownPush drownPush = new DrownPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownPush)
									{
										drownPush.MergeFrom(this.DrownPush);
									}
									input.ReadMessage(drownPush);
									this.DrownPush = drownPush;
									continue;
								}
							}
						}
						else if (num <= 202U)
						{
							if (num == 194U)
							{
								ActivateBuffPush activateBuffPush = new ActivateBuffPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.ActivateBuffPush)
								{
									activateBuffPush.MergeFrom(this.ActivateBuffPush);
								}
								input.ReadMessage(activateBuffPush);
								this.ActivateBuffPush = activateBuffPush;
								continue;
							}
							if (num == 202U)
							{
								AiInformationPush aiInformationPush = new AiInformationPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.AiInformationPush)
								{
									aiInformationPush.MergeFrom(this.AiInformationPush);
								}
								input.ReadMessage(aiInformationPush);
								this.AiInformationPush = aiInformationPush;
								continue;
							}
						}
						else
						{
							if (num == 210U)
							{
								ToughCalcExtraRatioChangePush toughCalcExtraRatioChangePush = new ToughCalcExtraRatioChangePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.ToughCalcExtraRatioChangePush)
								{
									toughCalcExtraRatioChangePush.MergeFrom(this.ToughCalcExtraRatioChangePush);
								}
								input.ReadMessage(toughCalcExtraRatioChangePush);
								this.ToughCalcExtraRatioChangePush = toughCalcExtraRatioChangePush;
								continue;
							}
							if (num == 218U)
							{
								BattleStateChangePush battleStateChangePush = new BattleStateChangePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.BattleStateChangePush)
								{
									battleStateChangePush.MergeFrom(this.BattleStateChangePush);
								}
								input.ReadMessage(battleStateChangePush);
								this.BattleStateChangePush = battleStateChangePush;
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
								AnimationGameplayTagPush animationGameplayTagPush = new AnimationGameplayTagPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.AnimationGameplayTagPush)
								{
									animationGameplayTagPush.MergeFrom(this.AnimationGameplayTagPush);
								}
								input.ReadMessage(animationGameplayTagPush);
								this.AnimationGameplayTagPush = animationGameplayTagPush;
								continue;
							}
							if (num == 234U)
							{
								BoneVisibleChangePush boneVisibleChangePush = new BoneVisibleChangePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.BoneVisibleChangePush)
								{
									boneVisibleChangePush.MergeFrom(this.BoneVisibleChangePush);
								}
								input.ReadMessage(boneVisibleChangePush);
								this.BoneVisibleChangePush = boneVisibleChangePush;
								continue;
							}
						}
						else
						{
							if (num == 242U)
							{
								AiBlackboardsPush aiBlackboardsPush = new AiBlackboardsPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardsPush)
								{
									aiBlackboardsPush.MergeFrom(this.AiBlackboardsPush);
								}
								input.ReadMessage(aiBlackboardsPush);
								this.AiBlackboardsPush = aiBlackboardsPush;
								continue;
							}
							if (num == 250U)
							{
								AiBlackboardCdPush aiBlackboardCdPush = new AiBlackboardCdPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.AiBlackboardCdPush)
								{
									aiBlackboardCdPush.MergeFrom(this.AiBlackboardCdPush);
								}
								input.ReadMessage(aiBlackboardCdPush);
								this.AiBlackboardCdPush = aiBlackboardCdPush;
								continue;
							}
						}
					}
					else if (num <= 266U)
					{
						if (num == 258U)
						{
							AiHatePush aiHatePush = new AiHatePush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.AiHatePush)
							{
								aiHatePush.MergeFrom(this.AiHatePush);
							}
							input.ReadMessage(aiHatePush);
							this.AiHatePush = aiHatePush;
							continue;
						}
						if (num == 266U)
						{
							MonsterBoomPush monsterBoomPush = new MonsterBoomPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterBoomPush)
							{
								monsterBoomPush.MergeFrom(this.MonsterBoomPush);
							}
							input.ReadMessage(monsterBoomPush);
							this.MonsterBoomPush = monsterBoomPush;
							continue;
						}
					}
					else
					{
						if (num == 274U)
						{
							CaughtPush caughtPush = new CaughtPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.CaughtPush)
							{
								caughtPush.MergeFrom(this.CaughtPush);
							}
							input.ReadMessage(caughtPush);
							this.CaughtPush = caughtPush;
							continue;
						}
						if (num == 282U)
						{
							EntityStaticHookMovePush entityStaticHookMovePush = new EntityStaticHookMovePush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.EntityStaticHookMovePush)
							{
								entityStaticHookMovePush.MergeFrom(this.EntityStaticHookMovePush);
							}
							input.ReadMessage(entityStaticHookMovePush);
							this.EntityStaticHookMovePush = entityStaticHookMovePush;
							continue;
						}
						if (num == 290U)
						{
							ChangeStateConfirmPush changeStateConfirmPush = new ChangeStateConfirmPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.ChangeStateConfirmPush)
							{
								changeStateConfirmPush.MergeFrom(this.ChangeStateConfirmPush);
							}
							input.ReadMessage(changeStateConfirmPush);
							this.ChangeStateConfirmPush = changeStateConfirmPush;
							continue;
						}
					}
				}
				else if (num <= 426U)
				{
					if (num <= 354U)
					{
						if (num <= 322U)
						{
							if (num <= 306U)
							{
								if (num == 298U)
								{
									BuffStackCountPush buffStackCountPush = new BuffStackCountPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffStackCountPush)
									{
										buffStackCountPush.MergeFrom(this.BuffStackCountPush);
									}
									input.ReadMessage(buffStackCountPush);
									this.BuffStackCountPush = buffStackCountPush;
									continue;
								}
								if (num == 306U)
								{
									ANStartPush anstartPush = new ANStartPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.ANStartPush)
									{
										anstartPush.MergeFrom(this.ANStartPush);
									}
									input.ReadMessage(anstartPush);
									this.ANStartPush = anstartPush;
									continue;
								}
							}
							else
							{
								if (num == 314U)
								{
									UseSkillFailPush useSkillFailPush = new UseSkillFailPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.UseSkillFailPush)
									{
										useSkillFailPush.MergeFrom(this.UseSkillFailPush);
									}
									input.ReadMessage(useSkillFailPush);
									this.UseSkillFailPush = useSkillFailPush;
									continue;
								}
								if (num == 322U)
								{
									EnterViewDirectionPush enterViewDirectionPush = new EnterViewDirectionPush();
									if (this.messageCase_ == CombatPushData.MessageOneofCase.EnterViewDirectionPush)
									{
										enterViewDirectionPush.MergeFrom(this.EnterViewDirectionPush);
									}
									input.ReadMessage(enterViewDirectionPush);
									this.EnterViewDirectionPush = enterViewDirectionPush;
									continue;
								}
							}
						}
						else if (num <= 338U)
						{
							if (num == 330U)
							{
								ExitViewDirectionPush exitViewDirectionPush = new ExitViewDirectionPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.ExitViewDirectionPush)
								{
									exitViewDirectionPush.MergeFrom(this.ExitViewDirectionPush);
								}
								input.ReadMessage(exitViewDirectionPush);
								this.ExitViewDirectionPush = exitViewDirectionPush;
								continue;
							}
							if (num == 338U)
							{
								PassiveSkillAddPush passiveSkillAddPush = new PassiveSkillAddPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillAddPush)
								{
									passiveSkillAddPush.MergeFrom(this.PassiveSkillAddPush);
								}
								input.ReadMessage(passiveSkillAddPush);
								this.PassiveSkillAddPush = passiveSkillAddPush;
								continue;
							}
						}
						else
						{
							if (num == 346U)
							{
								InterruptSkillInDelayPush interruptSkillInDelayPush = new InterruptSkillInDelayPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.InterruptSkillInDelayPush)
								{
									interruptSkillInDelayPush.MergeFrom(this.InterruptSkillInDelayPush);
								}
								input.ReadMessage(interruptSkillInDelayPush);
								this.InterruptSkillInDelayPush = interruptSkillInDelayPush;
								continue;
							}
							if (num == 354U)
							{
								TriggerExitSkillPush triggerExitSkillPush = new TriggerExitSkillPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.TriggerExitSkillPush)
								{
									triggerExitSkillPush.MergeFrom(this.TriggerExitSkillPush);
								}
								input.ReadMessage(triggerExitSkillPush);
								this.TriggerExitSkillPush = triggerExitSkillPush;
								continue;
							}
						}
					}
					else if (num <= 386U)
					{
						if (num <= 370U)
						{
							if (num == 362U)
							{
								ActorVisiblePush actorVisiblePush = new ActorVisiblePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.ActorVisiblePush)
								{
									actorVisiblePush.MergeFrom(this.ActorVisiblePush);
								}
								input.ReadMessage(actorVisiblePush);
								this.ActorVisiblePush = actorVisiblePush;
								continue;
							}
							if (num == 370U)
							{
								BuffEffectPush buffEffectPush = new BuffEffectPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectPush)
								{
									buffEffectPush.MergeFrom(this.BuffEffectPush);
								}
								input.ReadMessage(buffEffectPush);
								this.BuffEffectPush = buffEffectPush;
								continue;
							}
						}
						else
						{
							if (num == 378U)
							{
								RTimeStopPush rtimeStopPush = new RTimeStopPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopPush)
								{
									rtimeStopPush.MergeFrom(this.RTimeStopPush);
								}
								input.ReadMessage(rtimeStopPush);
								this.RTimeStopPush = rtimeStopPush;
								continue;
							}
							if (num == 386U)
							{
								DrownEndTeleportPush drownEndTeleportPush = new DrownEndTeleportPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.DrownEndTeleportPush)
								{
									drownEndTeleportPush.MergeFrom(this.DrownEndTeleportPush);
								}
								input.ReadMessage(drownEndTeleportPush);
								this.DrownEndTeleportPush = drownEndTeleportPush;
								continue;
							}
						}
					}
					else if (num <= 402U)
					{
						if (num == 394U)
						{
							MonsterDrownPush monsterDrownPush = new MonsterDrownPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.MonsterDrownPush)
							{
								monsterDrownPush.MergeFrom(this.MonsterDrownPush);
							}
							input.ReadMessage(monsterDrownPush);
							this.MonsterDrownPush = monsterDrownPush;
							continue;
						}
						if (num == 402U)
						{
							PassiveSkillRemovePush passiveSkillRemovePush = new PassiveSkillRemovePush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.PassiveSkillRemovePush)
							{
								passiveSkillRemovePush.MergeFrom(this.PassiveSkillRemovePush);
							}
							input.ReadMessage(passiveSkillRemovePush);
							this.PassiveSkillRemovePush = passiveSkillRemovePush;
							continue;
						}
					}
					else
					{
						if (num == 410U)
						{
							RTimeStopInstPush rtimeStopInstPush = new RTimeStopInstPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopInstPush)
							{
								rtimeStopInstPush.MergeFrom(this.RTimeStopInstPush);
							}
							input.ReadMessage(rtimeStopInstPush);
							this.RTimeStopInstPush = rtimeStopInstPush;
							continue;
						}
						if (num == 418U)
						{
							FsmPlayMontagePush fsmPlayMontagePush = new FsmPlayMontagePush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmPlayMontagePush)
							{
								fsmPlayMontagePush.MergeFrom(this.FsmPlayMontagePush);
							}
							input.ReadMessage(fsmPlayMontagePush);
							this.FsmPlayMontagePush = fsmPlayMontagePush;
							continue;
						}
						if (num == 426U)
						{
							RTimeStopAnimPush rtimeStopAnimPush = new RTimeStopAnimPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.RTimeStopAnimPush)
							{
								rtimeStopAnimPush.MergeFrom(this.RTimeStopAnimPush);
							}
							input.ReadMessage(rtimeStopAnimPush);
							this.RTimeStopAnimPush = rtimeStopAnimPush;
							continue;
						}
					}
				}
				else if (num <= 498U)
				{
					if (num <= 458U)
					{
						if (num <= 442U)
						{
							if (num == 434U)
							{
								GameplayTagPush gameplayTagPush = new GameplayTagPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.GameplayTagPush)
								{
									gameplayTagPush.MergeFrom(this.GameplayTagPush);
								}
								input.ReadMessage(gameplayTagPush);
								this.GameplayTagPush = gameplayTagPush;
								continue;
							}
							if (num == 442U)
							{
								ExecuteQtePush executeQtePush = new ExecuteQtePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.ExecuteQtePush)
								{
									executeQtePush.MergeFrom(this.ExecuteQtePush);
								}
								input.ReadMessage(executeQtePush);
								this.ExecuteQtePush = executeQtePush;
								continue;
							}
						}
						else
						{
							if (num == 450U)
							{
								ClientCurrentRoleReportPush clientCurrentRoleReportPush = new ClientCurrentRoleReportPush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.ClientCurrentRoleReportPush)
								{
									clientCurrentRoleReportPush.MergeFrom(this.ClientCurrentRoleReportPush);
								}
								input.ReadMessage(clientCurrentRoleReportPush);
								this.ClientCurrentRoleReportPush = clientCurrentRoleReportPush;
								continue;
							}
							if (num == 458U)
							{
								PlayEntityMontagePush playEntityMontagePush = new PlayEntityMontagePush();
								if (this.messageCase_ == CombatPushData.MessageOneofCase.PlayEntityMontagePush)
								{
									playEntityMontagePush.MergeFrom(this.PlayEntityMontagePush);
								}
								input.ReadMessage(playEntityMontagePush);
								this.PlayEntityMontagePush = playEntityMontagePush;
								continue;
							}
						}
					}
					else if (num <= 474U)
					{
						if (num == 466U)
						{
							BeforeHitPush beforeHitPush = new BeforeHitPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.BeforeHitPush)
							{
								beforeHitPush.MergeFrom(this.BeforeHitPush);
							}
							input.ReadMessage(beforeHitPush);
							this.BeforeHitPush = beforeHitPush;
							continue;
						}
						if (num == 474U)
						{
							NewLinkBurstPush newLinkBurstPush = new NewLinkBurstPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.NewLinkBurstPush)
							{
								newLinkBurstPush.MergeFrom(this.NewLinkBurstPush);
							}
							input.ReadMessage(newLinkBurstPush);
							this.NewLinkBurstPush = newLinkBurstPush;
							continue;
						}
					}
					else
					{
						if (num == 482U)
						{
							RefreshBuffDurationPush refreshBuffDurationPush = new RefreshBuffDurationPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.RefreshBuffDurationPush)
							{
								refreshBuffDurationPush.MergeFrom(this.RefreshBuffDurationPush);
							}
							input.ReadMessage(refreshBuffDurationPush);
							this.RefreshBuffDurationPush = refreshBuffDurationPush;
							continue;
						}
						if (num == 490U)
						{
							RoleGoDownPush roleGoDownPush = new RoleGoDownPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleGoDownPush)
							{
								roleGoDownPush.MergeFrom(this.RoleGoDownPush);
							}
							input.ReadMessage(roleGoDownPush);
							this.RoleGoDownPush = roleGoDownPush;
							continue;
						}
						if (num == 498U)
						{
							FsmConditionPassPush fsmConditionPassPush = new FsmConditionPassPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.FsmConditionPassPush)
							{
								fsmConditionPassPush.MergeFrom(this.FsmConditionPassPush);
							}
							input.ReadMessage(fsmConditionPassPush);
							this.FsmConditionPassPush = fsmConditionPassPush;
							continue;
						}
					}
				}
				else if (num <= 530U)
				{
					if (num <= 514U)
					{
						if (num == 506U)
						{
							BuffEffectExecutePush buffEffectExecutePush = new BuffEffectExecutePush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.BuffEffectExecutePush)
							{
								buffEffectExecutePush.MergeFrom(this.BuffEffectExecutePush);
							}
							input.ReadMessage(buffEffectExecutePush);
							this.BuffEffectExecutePush = buffEffectExecutePush;
							continue;
						}
						if (num == 514U)
						{
							VisionTriggerPush visionTriggerPush = new VisionTriggerPush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.VisionTriggerPush)
							{
								visionTriggerPush.MergeFrom(this.VisionTriggerPush);
							}
							input.ReadMessage(visionTriggerPush);
							this.VisionTriggerPush = visionTriggerPush;
							continue;
						}
					}
					else
					{
						if (num == 522U)
						{
							MotorIsEnablePush motorIsEnablePush = new MotorIsEnablePush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorIsEnablePush)
							{
								motorIsEnablePush.MergeFrom(this.MotorIsEnablePush);
							}
							input.ReadMessage(motorIsEnablePush);
							this.MotorIsEnablePush = motorIsEnablePush;
							continue;
						}
						if (num == 530U)
						{
							MotorSummonAndRidePush motorSummonAndRidePush = new MotorSummonAndRidePush();
							if (this.messageCase_ == CombatPushData.MessageOneofCase.MotorSummonAndRidePush)
							{
								motorSummonAndRidePush.MergeFrom(this.MotorSummonAndRidePush);
							}
							input.ReadMessage(motorSummonAndRidePush);
							this.MotorSummonAndRidePush = motorSummonAndRidePush;
							continue;
						}
					}
				}
				else if (num <= 546U)
				{
					if (num == 538U)
					{
						BulletPatternPush bulletPatternPush = new BulletPatternPush();
						if (this.messageCase_ == CombatPushData.MessageOneofCase.BulletPatternPush)
						{
							bulletPatternPush.MergeFrom(this.BulletPatternPush);
						}
						input.ReadMessage(bulletPatternPush);
						this.BulletPatternPush = bulletPatternPush;
						continue;
					}
					if (num == 546U)
					{
						QuickHackRamVerifyPush quickHackRamVerifyPush = new QuickHackRamVerifyPush();
						if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackRamVerifyPush)
						{
							quickHackRamVerifyPush.MergeFrom(this.QuickHackRamVerifyPush);
						}
						input.ReadMessage(quickHackRamVerifyPush);
						this.QuickHackRamVerifyPush = quickHackRamVerifyPush;
						continue;
					}
				}
				else
				{
					if (num == 554U)
					{
						QuickHackOpenPush quickHackOpenPush = new QuickHackOpenPush();
						if (this.messageCase_ == CombatPushData.MessageOneofCase.QuickHackOpenPush)
						{
							quickHackOpenPush.MergeFrom(this.QuickHackOpenPush);
						}
						input.ReadMessage(quickHackOpenPush);
						this.QuickHackOpenPush = quickHackOpenPush;
						continue;
					}
					if (num == 562U)
					{
						DodgeInfoPush dodgeInfoPush = new DodgeInfoPush();
						if (this.messageCase_ == CombatPushData.MessageOneofCase.DodgeInfoPush)
						{
							dodgeInfoPush.MergeFrom(this.DodgeInfoPush);
						}
						input.ReadMessage(dodgeInfoPush);
						this.DodgeInfoPush = dodgeInfoPush;
						continue;
					}
					if (num == 578U)
					{
						RoleTrialSceneRollbackPush roleTrialSceneRollbackPush = new RoleTrialSceneRollbackPush();
						if (this.messageCase_ == CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush)
						{
							roleTrialSceneRollbackPush.MergeFrom(this.RoleTrialSceneRollbackPush);
						}
						input.ReadMessage(roleTrialSceneRollbackPush);
						this.RoleTrialSceneRollbackPush = roleTrialSceneRollbackPush;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C794 RID: 51092
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C795 RID: 51093
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C796 RID: 51094
		private CombatCommon combatCommon_;

		// Token: 0x0400C797 RID: 51095
		public const int ApplyBuffS2CResponsePushFieldNumber = 4;

		// Token: 0x0400C798 RID: 51096
		public const int RemoveBuffS2CResponsePushFieldNumber = 5;

		// Token: 0x0400C799 RID: 51097
		public const int RemoveBuffByIdS2CResponsePushFieldNumber = 6;

		// Token: 0x0400C79A RID: 51098
		public const int CreateBulletPushFieldNumber = 7;

		// Token: 0x0400C79B RID: 51099
		public const int DestroyBulletPushFieldNumber = 8;

		// Token: 0x0400C79C RID: 51100
		public const int ApplyGameplayEffectPushFieldNumber = 9;

		// Token: 0x0400C79D RID: 51101
		public const int RemoveGameplayEffectPushFieldNumber = 10;

		// Token: 0x0400C79E RID: 51102
		public const int HitEndPushFieldNumber = 11;

		// Token: 0x0400C79F RID: 51103
		public const int EndSkillPushFieldNumber = 12;

		// Token: 0x0400C7A0 RID: 51104
		public const int PartUpdatePushFieldNumber = 13;

		// Token: 0x0400C7A1 RID: 51105
		public const int MaterialPushFieldNumber = 14;

		// Token: 0x0400C7A2 RID: 51106
		public const int GameplayCuePushFieldNumber = 15;

		// Token: 0x0400C7A3 RID: 51107
		public const int EntityIsVisiblePushFieldNumber = 16;

		// Token: 0x0400C7A4 RID: 51108
		public const int SwitchCharacterStatePushFieldNumber = 17;

		// Token: 0x0400C7A5 RID: 51109
		public const int LogicStateInitPushFieldNumber = 18;

		// Token: 0x0400C7A6 RID: 51110
		public const int SwitchLogicStatePushFieldNumber = 19;

		// Token: 0x0400C7A7 RID: 51111
		public const int AnimationStateChangedPushFieldNumber = 20;

		// Token: 0x0400C7A8 RID: 51112
		public const int AnimationStateInitPushFieldNumber = 21;

		// Token: 0x0400C7A9 RID: 51113
		public const int ModifyBulletParamsPushFieldNumber = 22;

		// Token: 0x0400C7AA RID: 51114
		public const int DrownPushFieldNumber = 23;

		// Token: 0x0400C7AB RID: 51115
		public const int ActivateBuffPushFieldNumber = 24;

		// Token: 0x0400C7AC RID: 51116
		public const int AiInformationPushFieldNumber = 25;

		// Token: 0x0400C7AD RID: 51117
		public const int ToughCalcExtraRatioChangePushFieldNumber = 26;

		// Token: 0x0400C7AE RID: 51118
		public const int BattleStateChangePushFieldNumber = 27;

		// Token: 0x0400C7AF RID: 51119
		public const int AnimationGameplayTagPushFieldNumber = 28;

		// Token: 0x0400C7B0 RID: 51120
		public const int BoneVisibleChangePushFieldNumber = 29;

		// Token: 0x0400C7B1 RID: 51121
		public const int AiBlackboardsPushFieldNumber = 30;

		// Token: 0x0400C7B2 RID: 51122
		public const int AiBlackboardCdPushFieldNumber = 31;

		// Token: 0x0400C7B3 RID: 51123
		public const int AiHatePushFieldNumber = 32;

		// Token: 0x0400C7B4 RID: 51124
		public const int MonsterBoomPushFieldNumber = 33;

		// Token: 0x0400C7B5 RID: 51125
		public const int CaughtPushFieldNumber = 34;

		// Token: 0x0400C7B6 RID: 51126
		public const int EntityStaticHookMovePushFieldNumber = 35;

		// Token: 0x0400C7B7 RID: 51127
		public const int ChangeStateConfirmPushFieldNumber = 36;

		// Token: 0x0400C7B8 RID: 51128
		public const int BuffStackCountPushFieldNumber = 37;

		// Token: 0x0400C7B9 RID: 51129
		public const int ANStartPushFieldNumber = 38;

		// Token: 0x0400C7BA RID: 51130
		public const int UseSkillFailPushFieldNumber = 39;

		// Token: 0x0400C7BB RID: 51131
		public const int EnterViewDirectionPushFieldNumber = 40;

		// Token: 0x0400C7BC RID: 51132
		public const int ExitViewDirectionPushFieldNumber = 41;

		// Token: 0x0400C7BD RID: 51133
		public const int PassiveSkillAddPushFieldNumber = 42;

		// Token: 0x0400C7BE RID: 51134
		public const int InterruptSkillInDelayPushFieldNumber = 43;

		// Token: 0x0400C7BF RID: 51135
		public const int TriggerExitSkillPushFieldNumber = 44;

		// Token: 0x0400C7C0 RID: 51136
		public const int ActorVisiblePushFieldNumber = 45;

		// Token: 0x0400C7C1 RID: 51137
		public const int BuffEffectPushFieldNumber = 46;

		// Token: 0x0400C7C2 RID: 51138
		public const int RTimeStopPushFieldNumber = 47;

		// Token: 0x0400C7C3 RID: 51139
		public const int DrownEndTeleportPushFieldNumber = 48;

		// Token: 0x0400C7C4 RID: 51140
		public const int MonsterDrownPushFieldNumber = 49;

		// Token: 0x0400C7C5 RID: 51141
		public const int PassiveSkillRemovePushFieldNumber = 50;

		// Token: 0x0400C7C6 RID: 51142
		public const int RTimeStopInstPushFieldNumber = 51;

		// Token: 0x0400C7C7 RID: 51143
		public const int FsmPlayMontagePushFieldNumber = 52;

		// Token: 0x0400C7C8 RID: 51144
		public const int RTimeStopAnimPushFieldNumber = 53;

		// Token: 0x0400C7C9 RID: 51145
		public const int GameplayTagPushFieldNumber = 54;

		// Token: 0x0400C7CA RID: 51146
		public const int ExecuteQtePushFieldNumber = 55;

		// Token: 0x0400C7CB RID: 51147
		public const int ClientCurrentRoleReportPushFieldNumber = 56;

		// Token: 0x0400C7CC RID: 51148
		public const int PlayEntityMontagePushFieldNumber = 57;

		// Token: 0x0400C7CD RID: 51149
		public const int BeforeHitPushFieldNumber = 58;

		// Token: 0x0400C7CE RID: 51150
		public const int NewLinkBurstPushFieldNumber = 59;

		// Token: 0x0400C7CF RID: 51151
		public const int RefreshBuffDurationPushFieldNumber = 60;

		// Token: 0x0400C7D0 RID: 51152
		public const int RoleGoDownPushFieldNumber = 61;

		// Token: 0x0400C7D1 RID: 51153
		public const int FsmConditionPassPushFieldNumber = 62;

		// Token: 0x0400C7D2 RID: 51154
		public const int BuffEffectExecutePushFieldNumber = 63;

		// Token: 0x0400C7D3 RID: 51155
		public const int VisionTriggerPushFieldNumber = 64;

		// Token: 0x0400C7D4 RID: 51156
		public const int MotorIsEnablePushFieldNumber = 65;

		// Token: 0x0400C7D5 RID: 51157
		public const int MotorSummonAndRidePushFieldNumber = 66;

		// Token: 0x0400C7D6 RID: 51158
		public const int BulletPatternPushFieldNumber = 67;

		// Token: 0x0400C7D7 RID: 51159
		public const int QuickHackRamVerifyPushFieldNumber = 68;

		// Token: 0x0400C7D8 RID: 51160
		public const int QuickHackOpenPushFieldNumber = 69;

		// Token: 0x0400C7D9 RID: 51161
		public const int DodgeInfoPushFieldNumber = 70;

		// Token: 0x0400C7DA RID: 51162
		public const int RoleTrialSceneRollbackPushFieldNumber = 72;

		// Token: 0x0400C7DB RID: 51163
		private object message_;

		// Token: 0x0400C7DC RID: 51164
		private CombatPushData.MessageOneofCase messageCase_;

		// Token: 0x02001AA0 RID: 6816
		public enum MessageOneofCase
		{
			// Token: 0x0400D0AA RID: 53418
			None,
			// Token: 0x0400D0AB RID: 53419
			ApplyBuffS2CResponsePush = 4,
			// Token: 0x0400D0AC RID: 53420
			RemoveBuffS2CResponsePush,
			// Token: 0x0400D0AD RID: 53421
			RemoveBuffByIdS2CResponsePush,
			// Token: 0x0400D0AE RID: 53422
			CreateBulletPush,
			// Token: 0x0400D0AF RID: 53423
			DestroyBulletPush,
			// Token: 0x0400D0B0 RID: 53424
			ApplyGameplayEffectPush,
			// Token: 0x0400D0B1 RID: 53425
			RemoveGameplayEffectPush,
			// Token: 0x0400D0B2 RID: 53426
			HitEndPush,
			// Token: 0x0400D0B3 RID: 53427
			EndSkillPush,
			// Token: 0x0400D0B4 RID: 53428
			PartUpdatePush,
			// Token: 0x0400D0B5 RID: 53429
			MaterialPush,
			// Token: 0x0400D0B6 RID: 53430
			GameplayCuePush,
			// Token: 0x0400D0B7 RID: 53431
			EntityIsVisiblePush,
			// Token: 0x0400D0B8 RID: 53432
			SwitchCharacterStatePush,
			// Token: 0x0400D0B9 RID: 53433
			LogicStateInitPush,
			// Token: 0x0400D0BA RID: 53434
			SwitchLogicStatePush,
			// Token: 0x0400D0BB RID: 53435
			AnimationStateChangedPush,
			// Token: 0x0400D0BC RID: 53436
			AnimationStateInitPush,
			// Token: 0x0400D0BD RID: 53437
			ModifyBulletParamsPush,
			// Token: 0x0400D0BE RID: 53438
			DrownPush,
			// Token: 0x0400D0BF RID: 53439
			ActivateBuffPush,
			// Token: 0x0400D0C0 RID: 53440
			AiInformationPush,
			// Token: 0x0400D0C1 RID: 53441
			ToughCalcExtraRatioChangePush,
			// Token: 0x0400D0C2 RID: 53442
			BattleStateChangePush,
			// Token: 0x0400D0C3 RID: 53443
			AnimationGameplayTagPush,
			// Token: 0x0400D0C4 RID: 53444
			BoneVisibleChangePush,
			// Token: 0x0400D0C5 RID: 53445
			AiBlackboardsPush,
			// Token: 0x0400D0C6 RID: 53446
			AiBlackboardCdPush,
			// Token: 0x0400D0C7 RID: 53447
			AiHatePush,
			// Token: 0x0400D0C8 RID: 53448
			MonsterBoomPush,
			// Token: 0x0400D0C9 RID: 53449
			CaughtPush,
			// Token: 0x0400D0CA RID: 53450
			EntityStaticHookMovePush,
			// Token: 0x0400D0CB RID: 53451
			ChangeStateConfirmPush,
			// Token: 0x0400D0CC RID: 53452
			BuffStackCountPush,
			// Token: 0x0400D0CD RID: 53453
			ANStartPush,
			// Token: 0x0400D0CE RID: 53454
			UseSkillFailPush,
			// Token: 0x0400D0CF RID: 53455
			EnterViewDirectionPush,
			// Token: 0x0400D0D0 RID: 53456
			ExitViewDirectionPush,
			// Token: 0x0400D0D1 RID: 53457
			PassiveSkillAddPush,
			// Token: 0x0400D0D2 RID: 53458
			InterruptSkillInDelayPush,
			// Token: 0x0400D0D3 RID: 53459
			TriggerExitSkillPush,
			// Token: 0x0400D0D4 RID: 53460
			ActorVisiblePush,
			// Token: 0x0400D0D5 RID: 53461
			BuffEffectPush,
			// Token: 0x0400D0D6 RID: 53462
			RTimeStopPush,
			// Token: 0x0400D0D7 RID: 53463
			DrownEndTeleportPush,
			// Token: 0x0400D0D8 RID: 53464
			MonsterDrownPush,
			// Token: 0x0400D0D9 RID: 53465
			PassiveSkillRemovePush,
			// Token: 0x0400D0DA RID: 53466
			RTimeStopInstPush,
			// Token: 0x0400D0DB RID: 53467
			FsmPlayMontagePush,
			// Token: 0x0400D0DC RID: 53468
			RTimeStopAnimPush,
			// Token: 0x0400D0DD RID: 53469
			GameplayTagPush,
			// Token: 0x0400D0DE RID: 53470
			ExecuteQtePush,
			// Token: 0x0400D0DF RID: 53471
			ClientCurrentRoleReportPush,
			// Token: 0x0400D0E0 RID: 53472
			PlayEntityMontagePush,
			// Token: 0x0400D0E1 RID: 53473
			BeforeHitPush,
			// Token: 0x0400D0E2 RID: 53474
			NewLinkBurstPush,
			// Token: 0x0400D0E3 RID: 53475
			RefreshBuffDurationPush,
			// Token: 0x0400D0E4 RID: 53476
			RoleGoDownPush,
			// Token: 0x0400D0E5 RID: 53477
			FsmConditionPassPush,
			// Token: 0x0400D0E6 RID: 53478
			BuffEffectExecutePush,
			// Token: 0x0400D0E7 RID: 53479
			VisionTriggerPush,
			// Token: 0x0400D0E8 RID: 53480
			MotorIsEnablePush,
			// Token: 0x0400D0E9 RID: 53481
			MotorSummonAndRidePush,
			// Token: 0x0400D0EA RID: 53482
			BulletPatternPush,
			// Token: 0x0400D0EB RID: 53483
			QuickHackRamVerifyPush,
			// Token: 0x0400D0EC RID: 53484
			QuickHackOpenPush,
			// Token: 0x0400D0ED RID: 53485
			DodgeInfoPush,
			// Token: 0x0400D0EE RID: 53486
			RoleTrialSceneRollbackPush = 72
		}
	}
}
