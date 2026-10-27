using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001688 RID: 5768
	public sealed class CombatPushData : IMessage<CombatPushData>, IMessage, IEquatable<CombatPushData>, IDeepCloneable<CombatPushData>, IBufferMessage
	{
		// Token: 0x0601CCC3 RID: 117955 RVA: 0x0042BDCA File Offset: 0x00429FCA
		[NullableContext(1)]
		public static CombatPushData Create()
		{
			return new CombatPushData();
		}

		// Token: 0x17006134 RID: 24884
		// (get) Token: 0x0601CCC4 RID: 117956 RVA: 0x0042BDD1 File Offset: 0x00429FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006135 RID: 24885
		// (get) Token: 0x0601CCC5 RID: 117957 RVA: 0x0042BDD4 File Offset: 0x00429FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatPushData.Descriptor;
			}
		}

		// Token: 0x0601CCC6 RID: 117958 RVA: 0x0042BDDB File Offset: 0x00429FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData()
		{
		}

		// Token: 0x0601CCC7 RID: 117959 RVA: 0x0042BDE4 File Offset: 0x00429FE4
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
			case CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush:
				this.SwitchDarkTideWeaponPush = other.SwitchDarkTideWeaponPush.Clone();
				break;
			case CombatPushData.MessageOneofCase.RoleTrialSceneRollbackPush:
				this.RoleTrialSceneRollbackPush = other.RoleTrialSceneRollbackPush.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CCC8 RID: 117960 RVA: 0x0042C523 File Offset: 0x0042A723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData Clone()
		{
			return new CombatPushData(this);
		}

		// Token: 0x17006136 RID: 24886
		// (get) Token: 0x0601CCC9 RID: 117961 RVA: 0x0042C52B File Offset: 0x0042A72B
		// (set) Token: 0x0601CCCA RID: 117962 RVA: 0x0042C533 File Offset: 0x0042A733
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

		// Token: 0x17006137 RID: 24887
		// (get) Token: 0x0601CCCB RID: 117963 RVA: 0x0042C53C File Offset: 0x0042A73C
		// (set) Token: 0x0601CCCC RID: 117964 RVA: 0x0042C554 File Offset: 0x0042A754
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

		// Token: 0x17006138 RID: 24888
		// (get) Token: 0x0601CCCD RID: 117965 RVA: 0x0042C56A File Offset: 0x0042A76A
		// (set) Token: 0x0601CCCE RID: 117966 RVA: 0x0042C582 File Offset: 0x0042A782
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

		// Token: 0x17006139 RID: 24889
		// (get) Token: 0x0601CCCF RID: 117967 RVA: 0x0042C598 File Offset: 0x0042A798
		// (set) Token: 0x0601CCD0 RID: 117968 RVA: 0x0042C5B0 File Offset: 0x0042A7B0
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

		// Token: 0x1700613A RID: 24890
		// (get) Token: 0x0601CCD1 RID: 117969 RVA: 0x0042C5C6 File Offset: 0x0042A7C6
		// (set) Token: 0x0601CCD2 RID: 117970 RVA: 0x0042C5DE File Offset: 0x0042A7DE
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

		// Token: 0x1700613B RID: 24891
		// (get) Token: 0x0601CCD3 RID: 117971 RVA: 0x0042C5F4 File Offset: 0x0042A7F4
		// (set) Token: 0x0601CCD4 RID: 117972 RVA: 0x0042C60C File Offset: 0x0042A80C
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

		// Token: 0x1700613C RID: 24892
		// (get) Token: 0x0601CCD5 RID: 117973 RVA: 0x0042C622 File Offset: 0x0042A822
		// (set) Token: 0x0601CCD6 RID: 117974 RVA: 0x0042C63B File Offset: 0x0042A83B
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

		// Token: 0x1700613D RID: 24893
		// (get) Token: 0x0601CCD7 RID: 117975 RVA: 0x0042C652 File Offset: 0x0042A852
		// (set) Token: 0x0601CCD8 RID: 117976 RVA: 0x0042C66B File Offset: 0x0042A86B
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

		// Token: 0x1700613E RID: 24894
		// (get) Token: 0x0601CCD9 RID: 117977 RVA: 0x0042C682 File Offset: 0x0042A882
		// (set) Token: 0x0601CCDA RID: 117978 RVA: 0x0042C69B File Offset: 0x0042A89B
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

		// Token: 0x1700613F RID: 24895
		// (get) Token: 0x0601CCDB RID: 117979 RVA: 0x0042C6B2 File Offset: 0x0042A8B2
		// (set) Token: 0x0601CCDC RID: 117980 RVA: 0x0042C6CB File Offset: 0x0042A8CB
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

		// Token: 0x17006140 RID: 24896
		// (get) Token: 0x0601CCDD RID: 117981 RVA: 0x0042C6E2 File Offset: 0x0042A8E2
		// (set) Token: 0x0601CCDE RID: 117982 RVA: 0x0042C6FB File Offset: 0x0042A8FB
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

		// Token: 0x17006141 RID: 24897
		// (get) Token: 0x0601CCDF RID: 117983 RVA: 0x0042C712 File Offset: 0x0042A912
		// (set) Token: 0x0601CCE0 RID: 117984 RVA: 0x0042C72B File Offset: 0x0042A92B
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

		// Token: 0x17006142 RID: 24898
		// (get) Token: 0x0601CCE1 RID: 117985 RVA: 0x0042C742 File Offset: 0x0042A942
		// (set) Token: 0x0601CCE2 RID: 117986 RVA: 0x0042C75B File Offset: 0x0042A95B
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

		// Token: 0x17006143 RID: 24899
		// (get) Token: 0x0601CCE3 RID: 117987 RVA: 0x0042C772 File Offset: 0x0042A972
		// (set) Token: 0x0601CCE4 RID: 117988 RVA: 0x0042C78B File Offset: 0x0042A98B
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

		// Token: 0x17006144 RID: 24900
		// (get) Token: 0x0601CCE5 RID: 117989 RVA: 0x0042C7A2 File Offset: 0x0042A9A2
		// (set) Token: 0x0601CCE6 RID: 117990 RVA: 0x0042C7BB File Offset: 0x0042A9BB
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

		// Token: 0x17006145 RID: 24901
		// (get) Token: 0x0601CCE7 RID: 117991 RVA: 0x0042C7D2 File Offset: 0x0042A9D2
		// (set) Token: 0x0601CCE8 RID: 117992 RVA: 0x0042C7EB File Offset: 0x0042A9EB
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

		// Token: 0x17006146 RID: 24902
		// (get) Token: 0x0601CCE9 RID: 117993 RVA: 0x0042C802 File Offset: 0x0042AA02
		// (set) Token: 0x0601CCEA RID: 117994 RVA: 0x0042C81B File Offset: 0x0042AA1B
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

		// Token: 0x17006147 RID: 24903
		// (get) Token: 0x0601CCEB RID: 117995 RVA: 0x0042C832 File Offset: 0x0042AA32
		// (set) Token: 0x0601CCEC RID: 117996 RVA: 0x0042C84B File Offset: 0x0042AA4B
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

		// Token: 0x17006148 RID: 24904
		// (get) Token: 0x0601CCED RID: 117997 RVA: 0x0042C862 File Offset: 0x0042AA62
		// (set) Token: 0x0601CCEE RID: 117998 RVA: 0x0042C87B File Offset: 0x0042AA7B
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

		// Token: 0x17006149 RID: 24905
		// (get) Token: 0x0601CCEF RID: 117999 RVA: 0x0042C892 File Offset: 0x0042AA92
		// (set) Token: 0x0601CCF0 RID: 118000 RVA: 0x0042C8AB File Offset: 0x0042AAAB
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

		// Token: 0x1700614A RID: 24906
		// (get) Token: 0x0601CCF1 RID: 118001 RVA: 0x0042C8C2 File Offset: 0x0042AAC2
		// (set) Token: 0x0601CCF2 RID: 118002 RVA: 0x0042C8DB File Offset: 0x0042AADB
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

		// Token: 0x1700614B RID: 24907
		// (get) Token: 0x0601CCF3 RID: 118003 RVA: 0x0042C8F2 File Offset: 0x0042AAF2
		// (set) Token: 0x0601CCF4 RID: 118004 RVA: 0x0042C90B File Offset: 0x0042AB0B
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

		// Token: 0x1700614C RID: 24908
		// (get) Token: 0x0601CCF5 RID: 118005 RVA: 0x0042C922 File Offset: 0x0042AB22
		// (set) Token: 0x0601CCF6 RID: 118006 RVA: 0x0042C93B File Offset: 0x0042AB3B
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

		// Token: 0x1700614D RID: 24909
		// (get) Token: 0x0601CCF7 RID: 118007 RVA: 0x0042C952 File Offset: 0x0042AB52
		// (set) Token: 0x0601CCF8 RID: 118008 RVA: 0x0042C96B File Offset: 0x0042AB6B
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

		// Token: 0x1700614E RID: 24910
		// (get) Token: 0x0601CCF9 RID: 118009 RVA: 0x0042C982 File Offset: 0x0042AB82
		// (set) Token: 0x0601CCFA RID: 118010 RVA: 0x0042C99B File Offset: 0x0042AB9B
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

		// Token: 0x1700614F RID: 24911
		// (get) Token: 0x0601CCFB RID: 118011 RVA: 0x0042C9B2 File Offset: 0x0042ABB2
		// (set) Token: 0x0601CCFC RID: 118012 RVA: 0x0042C9CB File Offset: 0x0042ABCB
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

		// Token: 0x17006150 RID: 24912
		// (get) Token: 0x0601CCFD RID: 118013 RVA: 0x0042C9E2 File Offset: 0x0042ABE2
		// (set) Token: 0x0601CCFE RID: 118014 RVA: 0x0042C9FB File Offset: 0x0042ABFB
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

		// Token: 0x17006151 RID: 24913
		// (get) Token: 0x0601CCFF RID: 118015 RVA: 0x0042CA12 File Offset: 0x0042AC12
		// (set) Token: 0x0601CD00 RID: 118016 RVA: 0x0042CA2B File Offset: 0x0042AC2B
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

		// Token: 0x17006152 RID: 24914
		// (get) Token: 0x0601CD01 RID: 118017 RVA: 0x0042CA42 File Offset: 0x0042AC42
		// (set) Token: 0x0601CD02 RID: 118018 RVA: 0x0042CA5B File Offset: 0x0042AC5B
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

		// Token: 0x17006153 RID: 24915
		// (get) Token: 0x0601CD03 RID: 118019 RVA: 0x0042CA72 File Offset: 0x0042AC72
		// (set) Token: 0x0601CD04 RID: 118020 RVA: 0x0042CA8B File Offset: 0x0042AC8B
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

		// Token: 0x17006154 RID: 24916
		// (get) Token: 0x0601CD05 RID: 118021 RVA: 0x0042CAA2 File Offset: 0x0042ACA2
		// (set) Token: 0x0601CD06 RID: 118022 RVA: 0x0042CABB File Offset: 0x0042ACBB
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

		// Token: 0x17006155 RID: 24917
		// (get) Token: 0x0601CD07 RID: 118023 RVA: 0x0042CAD2 File Offset: 0x0042ACD2
		// (set) Token: 0x0601CD08 RID: 118024 RVA: 0x0042CAEB File Offset: 0x0042ACEB
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

		// Token: 0x17006156 RID: 24918
		// (get) Token: 0x0601CD09 RID: 118025 RVA: 0x0042CB02 File Offset: 0x0042AD02
		// (set) Token: 0x0601CD0A RID: 118026 RVA: 0x0042CB1B File Offset: 0x0042AD1B
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

		// Token: 0x17006157 RID: 24919
		// (get) Token: 0x0601CD0B RID: 118027 RVA: 0x0042CB32 File Offset: 0x0042AD32
		// (set) Token: 0x0601CD0C RID: 118028 RVA: 0x0042CB4B File Offset: 0x0042AD4B
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

		// Token: 0x17006158 RID: 24920
		// (get) Token: 0x0601CD0D RID: 118029 RVA: 0x0042CB62 File Offset: 0x0042AD62
		// (set) Token: 0x0601CD0E RID: 118030 RVA: 0x0042CB7B File Offset: 0x0042AD7B
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

		// Token: 0x17006159 RID: 24921
		// (get) Token: 0x0601CD0F RID: 118031 RVA: 0x0042CB92 File Offset: 0x0042AD92
		// (set) Token: 0x0601CD10 RID: 118032 RVA: 0x0042CBAB File Offset: 0x0042ADAB
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

		// Token: 0x1700615A RID: 24922
		// (get) Token: 0x0601CD11 RID: 118033 RVA: 0x0042CBC2 File Offset: 0x0042ADC2
		// (set) Token: 0x0601CD12 RID: 118034 RVA: 0x0042CBDB File Offset: 0x0042ADDB
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

		// Token: 0x1700615B RID: 24923
		// (get) Token: 0x0601CD13 RID: 118035 RVA: 0x0042CBF2 File Offset: 0x0042ADF2
		// (set) Token: 0x0601CD14 RID: 118036 RVA: 0x0042CC0B File Offset: 0x0042AE0B
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

		// Token: 0x1700615C RID: 24924
		// (get) Token: 0x0601CD15 RID: 118037 RVA: 0x0042CC22 File Offset: 0x0042AE22
		// (set) Token: 0x0601CD16 RID: 118038 RVA: 0x0042CC3B File Offset: 0x0042AE3B
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

		// Token: 0x1700615D RID: 24925
		// (get) Token: 0x0601CD17 RID: 118039 RVA: 0x0042CC52 File Offset: 0x0042AE52
		// (set) Token: 0x0601CD18 RID: 118040 RVA: 0x0042CC6B File Offset: 0x0042AE6B
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

		// Token: 0x1700615E RID: 24926
		// (get) Token: 0x0601CD19 RID: 118041 RVA: 0x0042CC82 File Offset: 0x0042AE82
		// (set) Token: 0x0601CD1A RID: 118042 RVA: 0x0042CC9B File Offset: 0x0042AE9B
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

		// Token: 0x1700615F RID: 24927
		// (get) Token: 0x0601CD1B RID: 118043 RVA: 0x0042CCB2 File Offset: 0x0042AEB2
		// (set) Token: 0x0601CD1C RID: 118044 RVA: 0x0042CCCB File Offset: 0x0042AECB
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

		// Token: 0x17006160 RID: 24928
		// (get) Token: 0x0601CD1D RID: 118045 RVA: 0x0042CCE2 File Offset: 0x0042AEE2
		// (set) Token: 0x0601CD1E RID: 118046 RVA: 0x0042CCFB File Offset: 0x0042AEFB
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

		// Token: 0x17006161 RID: 24929
		// (get) Token: 0x0601CD1F RID: 118047 RVA: 0x0042CD12 File Offset: 0x0042AF12
		// (set) Token: 0x0601CD20 RID: 118048 RVA: 0x0042CD2B File Offset: 0x0042AF2B
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

		// Token: 0x17006162 RID: 24930
		// (get) Token: 0x0601CD21 RID: 118049 RVA: 0x0042CD42 File Offset: 0x0042AF42
		// (set) Token: 0x0601CD22 RID: 118050 RVA: 0x0042CD5B File Offset: 0x0042AF5B
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

		// Token: 0x17006163 RID: 24931
		// (get) Token: 0x0601CD23 RID: 118051 RVA: 0x0042CD72 File Offset: 0x0042AF72
		// (set) Token: 0x0601CD24 RID: 118052 RVA: 0x0042CD8B File Offset: 0x0042AF8B
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

		// Token: 0x17006164 RID: 24932
		// (get) Token: 0x0601CD25 RID: 118053 RVA: 0x0042CDA2 File Offset: 0x0042AFA2
		// (set) Token: 0x0601CD26 RID: 118054 RVA: 0x0042CDBB File Offset: 0x0042AFBB
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

		// Token: 0x17006165 RID: 24933
		// (get) Token: 0x0601CD27 RID: 118055 RVA: 0x0042CDD2 File Offset: 0x0042AFD2
		// (set) Token: 0x0601CD28 RID: 118056 RVA: 0x0042CDEB File Offset: 0x0042AFEB
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

		// Token: 0x17006166 RID: 24934
		// (get) Token: 0x0601CD29 RID: 118057 RVA: 0x0042CE02 File Offset: 0x0042B002
		// (set) Token: 0x0601CD2A RID: 118058 RVA: 0x0042CE1B File Offset: 0x0042B01B
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

		// Token: 0x17006167 RID: 24935
		// (get) Token: 0x0601CD2B RID: 118059 RVA: 0x0042CE32 File Offset: 0x0042B032
		// (set) Token: 0x0601CD2C RID: 118060 RVA: 0x0042CE4B File Offset: 0x0042B04B
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

		// Token: 0x17006168 RID: 24936
		// (get) Token: 0x0601CD2D RID: 118061 RVA: 0x0042CE62 File Offset: 0x0042B062
		// (set) Token: 0x0601CD2E RID: 118062 RVA: 0x0042CE7B File Offset: 0x0042B07B
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

		// Token: 0x17006169 RID: 24937
		// (get) Token: 0x0601CD2F RID: 118063 RVA: 0x0042CE92 File Offset: 0x0042B092
		// (set) Token: 0x0601CD30 RID: 118064 RVA: 0x0042CEAB File Offset: 0x0042B0AB
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

		// Token: 0x1700616A RID: 24938
		// (get) Token: 0x0601CD31 RID: 118065 RVA: 0x0042CEC2 File Offset: 0x0042B0C2
		// (set) Token: 0x0601CD32 RID: 118066 RVA: 0x0042CEDB File Offset: 0x0042B0DB
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

		// Token: 0x1700616B RID: 24939
		// (get) Token: 0x0601CD33 RID: 118067 RVA: 0x0042CEF2 File Offset: 0x0042B0F2
		// (set) Token: 0x0601CD34 RID: 118068 RVA: 0x0042CF0B File Offset: 0x0042B10B
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

		// Token: 0x1700616C RID: 24940
		// (get) Token: 0x0601CD35 RID: 118069 RVA: 0x0042CF22 File Offset: 0x0042B122
		// (set) Token: 0x0601CD36 RID: 118070 RVA: 0x0042CF3B File Offset: 0x0042B13B
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

		// Token: 0x1700616D RID: 24941
		// (get) Token: 0x0601CD37 RID: 118071 RVA: 0x0042CF52 File Offset: 0x0042B152
		// (set) Token: 0x0601CD38 RID: 118072 RVA: 0x0042CF6B File Offset: 0x0042B16B
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

		// Token: 0x1700616E RID: 24942
		// (get) Token: 0x0601CD39 RID: 118073 RVA: 0x0042CF82 File Offset: 0x0042B182
		// (set) Token: 0x0601CD3A RID: 118074 RVA: 0x0042CF9B File Offset: 0x0042B19B
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

		// Token: 0x1700616F RID: 24943
		// (get) Token: 0x0601CD3B RID: 118075 RVA: 0x0042CFB2 File Offset: 0x0042B1B2
		// (set) Token: 0x0601CD3C RID: 118076 RVA: 0x0042CFCB File Offset: 0x0042B1CB
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

		// Token: 0x17006170 RID: 24944
		// (get) Token: 0x0601CD3D RID: 118077 RVA: 0x0042CFE2 File Offset: 0x0042B1E2
		// (set) Token: 0x0601CD3E RID: 118078 RVA: 0x0042CFFB File Offset: 0x0042B1FB
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

		// Token: 0x17006171 RID: 24945
		// (get) Token: 0x0601CD3F RID: 118079 RVA: 0x0042D012 File Offset: 0x0042B212
		// (set) Token: 0x0601CD40 RID: 118080 RVA: 0x0042D02B File Offset: 0x0042B22B
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

		// Token: 0x17006172 RID: 24946
		// (get) Token: 0x0601CD41 RID: 118081 RVA: 0x0042D042 File Offset: 0x0042B242
		// (set) Token: 0x0601CD42 RID: 118082 RVA: 0x0042D05B File Offset: 0x0042B25B
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

		// Token: 0x17006173 RID: 24947
		// (get) Token: 0x0601CD43 RID: 118083 RVA: 0x0042D072 File Offset: 0x0042B272
		// (set) Token: 0x0601CD44 RID: 118084 RVA: 0x0042D08B File Offset: 0x0042B28B
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

		// Token: 0x17006174 RID: 24948
		// (get) Token: 0x0601CD45 RID: 118085 RVA: 0x0042D0A2 File Offset: 0x0042B2A2
		// (set) Token: 0x0601CD46 RID: 118086 RVA: 0x0042D0BB File Offset: 0x0042B2BB
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

		// Token: 0x17006175 RID: 24949
		// (get) Token: 0x0601CD47 RID: 118087 RVA: 0x0042D0D2 File Offset: 0x0042B2D2
		// (set) Token: 0x0601CD48 RID: 118088 RVA: 0x0042D0EB File Offset: 0x0042B2EB
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

		// Token: 0x17006176 RID: 24950
		// (get) Token: 0x0601CD49 RID: 118089 RVA: 0x0042D102 File Offset: 0x0042B302
		// (set) Token: 0x0601CD4A RID: 118090 RVA: 0x0042D11B File Offset: 0x0042B31B
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

		// Token: 0x17006177 RID: 24951
		// (get) Token: 0x0601CD4B RID: 118091 RVA: 0x0042D132 File Offset: 0x0042B332
		// (set) Token: 0x0601CD4C RID: 118092 RVA: 0x0042D14B File Offset: 0x0042B34B
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

		// Token: 0x17006178 RID: 24952
		// (get) Token: 0x0601CD4D RID: 118093 RVA: 0x0042D162 File Offset: 0x0042B362
		// (set) Token: 0x0601CD4E RID: 118094 RVA: 0x0042D17B File Offset: 0x0042B37B
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

		// Token: 0x17006179 RID: 24953
		// (get) Token: 0x0601CD4F RID: 118095 RVA: 0x0042D192 File Offset: 0x0042B392
		// (set) Token: 0x0601CD50 RID: 118096 RVA: 0x0042D1AB File Offset: 0x0042B3AB
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

		// Token: 0x1700617A RID: 24954
		// (get) Token: 0x0601CD51 RID: 118097 RVA: 0x0042D1C2 File Offset: 0x0042B3C2
		// (set) Token: 0x0601CD52 RID: 118098 RVA: 0x0042D1DB File Offset: 0x0042B3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponPush SwitchDarkTideWeaponPush
		{
			get
			{
				if (this.messageCase_ != CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush)
				{
					return null;
				}
				return (SwitchDarkTideWeaponPush)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatPushData.MessageOneofCase.None : CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush);
			}
		}

		// Token: 0x1700617B RID: 24955
		// (get) Token: 0x0601CD53 RID: 118099 RVA: 0x0042D1F2 File Offset: 0x0042B3F2
		// (set) Token: 0x0601CD54 RID: 118100 RVA: 0x0042D20B File Offset: 0x0042B40B
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

		// Token: 0x1700617C RID: 24956
		// (get) Token: 0x0601CD55 RID: 118101 RVA: 0x0042D222 File Offset: 0x0042B422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601CD56 RID: 118102 RVA: 0x0042D22A File Offset: 0x0042B42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatPushData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601CD57 RID: 118103 RVA: 0x0042D23A File Offset: 0x0042B43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatPushData);
		}

		// Token: 0x0601CD58 RID: 118104 RVA: 0x0042D248 File Offset: 0x0042B448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatPushData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.ApplyBuffS2CResponsePush, other.ApplyBuffS2CResponsePush) && object.Equals(this.RemoveBuffS2CResponsePush, other.RemoveBuffS2CResponsePush) && object.Equals(this.RemoveBuffByIdS2CResponsePush, other.RemoveBuffByIdS2CResponsePush) && object.Equals(this.CreateBulletPush, other.CreateBulletPush) && object.Equals(this.DestroyBulletPush, other.DestroyBulletPush) && object.Equals(this.ApplyGameplayEffectPush, other.ApplyGameplayEffectPush) && object.Equals(this.RemoveGameplayEffectPush, other.RemoveGameplayEffectPush) && object.Equals(this.HitEndPush, other.HitEndPush) && object.Equals(this.EndSkillPush, other.EndSkillPush) && object.Equals(this.PartUpdatePush, other.PartUpdatePush) && object.Equals(this.MaterialPush, other.MaterialPush) && object.Equals(this.GameplayCuePush, other.GameplayCuePush) && object.Equals(this.EntityIsVisiblePush, other.EntityIsVisiblePush) && object.Equals(this.SwitchCharacterStatePush, other.SwitchCharacterStatePush) && object.Equals(this.LogicStateInitPush, other.LogicStateInitPush) && object.Equals(this.SwitchLogicStatePush, other.SwitchLogicStatePush) && object.Equals(this.AnimationStateChangedPush, other.AnimationStateChangedPush) && object.Equals(this.AnimationStateInitPush, other.AnimationStateInitPush) && object.Equals(this.ModifyBulletParamsPush, other.ModifyBulletParamsPush) && object.Equals(this.DrownPush, other.DrownPush) && object.Equals(this.ActivateBuffPush, other.ActivateBuffPush) && object.Equals(this.AiInformationPush, other.AiInformationPush) && object.Equals(this.ToughCalcExtraRatioChangePush, other.ToughCalcExtraRatioChangePush) && object.Equals(this.BattleStateChangePush, other.BattleStateChangePush) && object.Equals(this.AnimationGameplayTagPush, other.AnimationGameplayTagPush) && object.Equals(this.BoneVisibleChangePush, other.BoneVisibleChangePush) && object.Equals(this.AiBlackboardsPush, other.AiBlackboardsPush) && object.Equals(this.AiBlackboardCdPush, other.AiBlackboardCdPush) && object.Equals(this.AiHatePush, other.AiHatePush) && object.Equals(this.MonsterBoomPush, other.MonsterBoomPush) && object.Equals(this.CaughtPush, other.CaughtPush) && object.Equals(this.EntityStaticHookMovePush, other.EntityStaticHookMovePush) && object.Equals(this.ChangeStateConfirmPush, other.ChangeStateConfirmPush) && object.Equals(this.BuffStackCountPush, other.BuffStackCountPush) && object.Equals(this.ANStartPush, other.ANStartPush) && object.Equals(this.UseSkillFailPush, other.UseSkillFailPush) && object.Equals(this.EnterViewDirectionPush, other.EnterViewDirectionPush) && object.Equals(this.ExitViewDirectionPush, other.ExitViewDirectionPush) && object.Equals(this.PassiveSkillAddPush, other.PassiveSkillAddPush) && object.Equals(this.InterruptSkillInDelayPush, other.InterruptSkillInDelayPush) && object.Equals(this.TriggerExitSkillPush, other.TriggerExitSkillPush) && object.Equals(this.ActorVisiblePush, other.ActorVisiblePush) && object.Equals(this.BuffEffectPush, other.BuffEffectPush) && object.Equals(this.RTimeStopPush, other.RTimeStopPush) && object.Equals(this.DrownEndTeleportPush, other.DrownEndTeleportPush) && object.Equals(this.MonsterDrownPush, other.MonsterDrownPush) && object.Equals(this.PassiveSkillRemovePush, other.PassiveSkillRemovePush) && object.Equals(this.RTimeStopInstPush, other.RTimeStopInstPush) && object.Equals(this.FsmPlayMontagePush, other.FsmPlayMontagePush) && object.Equals(this.RTimeStopAnimPush, other.RTimeStopAnimPush) && object.Equals(this.GameplayTagPush, other.GameplayTagPush) && object.Equals(this.ExecuteQtePush, other.ExecuteQtePush) && object.Equals(this.ClientCurrentRoleReportPush, other.ClientCurrentRoleReportPush) && object.Equals(this.PlayEntityMontagePush, other.PlayEntityMontagePush) && object.Equals(this.BeforeHitPush, other.BeforeHitPush) && object.Equals(this.NewLinkBurstPush, other.NewLinkBurstPush) && object.Equals(this.RefreshBuffDurationPush, other.RefreshBuffDurationPush) && object.Equals(this.RoleGoDownPush, other.RoleGoDownPush) && object.Equals(this.FsmConditionPassPush, other.FsmConditionPassPush) && object.Equals(this.BuffEffectExecutePush, other.BuffEffectExecutePush) && object.Equals(this.VisionTriggerPush, other.VisionTriggerPush) && object.Equals(this.MotorIsEnablePush, other.MotorIsEnablePush) && object.Equals(this.MotorSummonAndRidePush, other.MotorSummonAndRidePush) && object.Equals(this.BulletPatternPush, other.BulletPatternPush) && object.Equals(this.QuickHackRamVerifyPush, other.QuickHackRamVerifyPush) && object.Equals(this.QuickHackOpenPush, other.QuickHackOpenPush) && object.Equals(this.DodgeInfoPush, other.DodgeInfoPush) && object.Equals(this.SwitchDarkTideWeaponPush, other.SwitchDarkTideWeaponPush) && object.Equals(this.RoleTrialSceneRollbackPush, other.RoleTrialSceneRollbackPush) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD59 RID: 118105 RVA: 0x0042D840 File Offset: 0x0042BA40
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
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush)
			{
				num ^= this.SwitchDarkTideWeaponPush.GetHashCode();
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

		// Token: 0x0601CD5A RID: 118106 RVA: 0x0042DEF8 File Offset: 0x0042C0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD5B RID: 118107 RVA: 0x0042DF05 File Offset: 0x0042C105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD5C RID: 118108 RVA: 0x0042DF10 File Offset: 0x0042C110
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
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.SwitchDarkTideWeaponPush);
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

		// Token: 0x0601CD5D RID: 118109 RVA: 0x0042E844 File Offset: 0x0042CA44
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
			if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchDarkTideWeaponPush);
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

		// Token: 0x0601CD5E RID: 118110 RVA: 0x0042EF80 File Offset: 0x0042D180
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
			case CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush:
				if (this.SwitchDarkTideWeaponPush == null)
				{
					this.SwitchDarkTideWeaponPush = new SwitchDarkTideWeaponPush();
				}
				this.SwitchDarkTideWeaponPush.MergeFrom(other.SwitchDarkTideWeaponPush);
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

		// Token: 0x0601CD5F RID: 118111 RVA: 0x0042FBFB File Offset: 0x0042DDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD60 RID: 118112 RVA: 0x0042FC04 File Offset: 0x0042DE04
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
				if (num <= 298U)
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
					else if (num <= 226U)
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
						}
					}
					else if (num <= 258U)
					{
						if (num <= 242U)
						{
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
						}
						else
						{
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
						}
					}
					else if (num <= 274U)
					{
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
					}
					else
					{
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
					}
				}
				else if (num <= 434U)
				{
					if (num <= 362U)
					{
						if (num <= 330U)
						{
							if (num <= 314U)
							{
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
							}
							else
							{
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
							}
						}
						else if (num <= 346U)
						{
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
						}
						else
						{
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
						}
					}
					else if (num <= 394U)
					{
						if (num <= 378U)
						{
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
						}
						else
						{
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
						}
					}
					else if (num <= 410U)
					{
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
					}
					else
					{
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
					}
				}
				else if (num <= 506U)
				{
					if (num <= 466U)
					{
						if (num <= 450U)
						{
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
						}
						else
						{
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
						}
					}
					else if (num <= 482U)
					{
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
					}
					else
					{
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
					}
				}
				else if (num <= 538U)
				{
					if (num <= 522U)
					{
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
					}
					else
					{
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
					}
				}
				else if (num <= 554U)
				{
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
				}
				else
				{
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
					if (num == 570U)
					{
						SwitchDarkTideWeaponPush switchDarkTideWeaponPush = new SwitchDarkTideWeaponPush();
						if (this.messageCase_ == CombatPushData.MessageOneofCase.SwitchDarkTideWeaponPush)
						{
							switchDarkTideWeaponPush.MergeFrom(this.SwitchDarkTideWeaponPush);
						}
						input.ReadMessage(switchDarkTideWeaponPush);
						this.SwitchDarkTideWeaponPush = switchDarkTideWeaponPush;
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

		// Token: 0x0400C268 RID: 49768
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C269 RID: 49769
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C26A RID: 49770
		private CombatCommon combatCommon_;

		// Token: 0x0400C26B RID: 49771
		public const int ApplyBuffS2CResponsePushFieldNumber = 4;

		// Token: 0x0400C26C RID: 49772
		public const int RemoveBuffS2CResponsePushFieldNumber = 5;

		// Token: 0x0400C26D RID: 49773
		public const int RemoveBuffByIdS2CResponsePushFieldNumber = 6;

		// Token: 0x0400C26E RID: 49774
		public const int CreateBulletPushFieldNumber = 7;

		// Token: 0x0400C26F RID: 49775
		public const int DestroyBulletPushFieldNumber = 8;

		// Token: 0x0400C270 RID: 49776
		public const int ApplyGameplayEffectPushFieldNumber = 9;

		// Token: 0x0400C271 RID: 49777
		public const int RemoveGameplayEffectPushFieldNumber = 10;

		// Token: 0x0400C272 RID: 49778
		public const int HitEndPushFieldNumber = 11;

		// Token: 0x0400C273 RID: 49779
		public const int EndSkillPushFieldNumber = 12;

		// Token: 0x0400C274 RID: 49780
		public const int PartUpdatePushFieldNumber = 13;

		// Token: 0x0400C275 RID: 49781
		public const int MaterialPushFieldNumber = 14;

		// Token: 0x0400C276 RID: 49782
		public const int GameplayCuePushFieldNumber = 15;

		// Token: 0x0400C277 RID: 49783
		public const int EntityIsVisiblePushFieldNumber = 16;

		// Token: 0x0400C278 RID: 49784
		public const int SwitchCharacterStatePushFieldNumber = 17;

		// Token: 0x0400C279 RID: 49785
		public const int LogicStateInitPushFieldNumber = 18;

		// Token: 0x0400C27A RID: 49786
		public const int SwitchLogicStatePushFieldNumber = 19;

		// Token: 0x0400C27B RID: 49787
		public const int AnimationStateChangedPushFieldNumber = 20;

		// Token: 0x0400C27C RID: 49788
		public const int AnimationStateInitPushFieldNumber = 21;

		// Token: 0x0400C27D RID: 49789
		public const int ModifyBulletParamsPushFieldNumber = 22;

		// Token: 0x0400C27E RID: 49790
		public const int DrownPushFieldNumber = 23;

		// Token: 0x0400C27F RID: 49791
		public const int ActivateBuffPushFieldNumber = 24;

		// Token: 0x0400C280 RID: 49792
		public const int AiInformationPushFieldNumber = 25;

		// Token: 0x0400C281 RID: 49793
		public const int ToughCalcExtraRatioChangePushFieldNumber = 26;

		// Token: 0x0400C282 RID: 49794
		public const int BattleStateChangePushFieldNumber = 27;

		// Token: 0x0400C283 RID: 49795
		public const int AnimationGameplayTagPushFieldNumber = 28;

		// Token: 0x0400C284 RID: 49796
		public const int BoneVisibleChangePushFieldNumber = 29;

		// Token: 0x0400C285 RID: 49797
		public const int AiBlackboardsPushFieldNumber = 30;

		// Token: 0x0400C286 RID: 49798
		public const int AiBlackboardCdPushFieldNumber = 31;

		// Token: 0x0400C287 RID: 49799
		public const int AiHatePushFieldNumber = 32;

		// Token: 0x0400C288 RID: 49800
		public const int MonsterBoomPushFieldNumber = 33;

		// Token: 0x0400C289 RID: 49801
		public const int CaughtPushFieldNumber = 34;

		// Token: 0x0400C28A RID: 49802
		public const int EntityStaticHookMovePushFieldNumber = 35;

		// Token: 0x0400C28B RID: 49803
		public const int ChangeStateConfirmPushFieldNumber = 36;

		// Token: 0x0400C28C RID: 49804
		public const int BuffStackCountPushFieldNumber = 37;

		// Token: 0x0400C28D RID: 49805
		public const int ANStartPushFieldNumber = 38;

		// Token: 0x0400C28E RID: 49806
		public const int UseSkillFailPushFieldNumber = 39;

		// Token: 0x0400C28F RID: 49807
		public const int EnterViewDirectionPushFieldNumber = 40;

		// Token: 0x0400C290 RID: 49808
		public const int ExitViewDirectionPushFieldNumber = 41;

		// Token: 0x0400C291 RID: 49809
		public const int PassiveSkillAddPushFieldNumber = 42;

		// Token: 0x0400C292 RID: 49810
		public const int InterruptSkillInDelayPushFieldNumber = 43;

		// Token: 0x0400C293 RID: 49811
		public const int TriggerExitSkillPushFieldNumber = 44;

		// Token: 0x0400C294 RID: 49812
		public const int ActorVisiblePushFieldNumber = 45;

		// Token: 0x0400C295 RID: 49813
		public const int BuffEffectPushFieldNumber = 46;

		// Token: 0x0400C296 RID: 49814
		public const int RTimeStopPushFieldNumber = 47;

		// Token: 0x0400C297 RID: 49815
		public const int DrownEndTeleportPushFieldNumber = 48;

		// Token: 0x0400C298 RID: 49816
		public const int MonsterDrownPushFieldNumber = 49;

		// Token: 0x0400C299 RID: 49817
		public const int PassiveSkillRemovePushFieldNumber = 50;

		// Token: 0x0400C29A RID: 49818
		public const int RTimeStopInstPushFieldNumber = 51;

		// Token: 0x0400C29B RID: 49819
		public const int FsmPlayMontagePushFieldNumber = 52;

		// Token: 0x0400C29C RID: 49820
		public const int RTimeStopAnimPushFieldNumber = 53;

		// Token: 0x0400C29D RID: 49821
		public const int GameplayTagPushFieldNumber = 54;

		// Token: 0x0400C29E RID: 49822
		public const int ExecuteQtePushFieldNumber = 55;

		// Token: 0x0400C29F RID: 49823
		public const int ClientCurrentRoleReportPushFieldNumber = 56;

		// Token: 0x0400C2A0 RID: 49824
		public const int PlayEntityMontagePushFieldNumber = 57;

		// Token: 0x0400C2A1 RID: 49825
		public const int BeforeHitPushFieldNumber = 58;

		// Token: 0x0400C2A2 RID: 49826
		public const int NewLinkBurstPushFieldNumber = 59;

		// Token: 0x0400C2A3 RID: 49827
		public const int RefreshBuffDurationPushFieldNumber = 60;

		// Token: 0x0400C2A4 RID: 49828
		public const int RoleGoDownPushFieldNumber = 61;

		// Token: 0x0400C2A5 RID: 49829
		public const int FsmConditionPassPushFieldNumber = 62;

		// Token: 0x0400C2A6 RID: 49830
		public const int BuffEffectExecutePushFieldNumber = 63;

		// Token: 0x0400C2A7 RID: 49831
		public const int VisionTriggerPushFieldNumber = 64;

		// Token: 0x0400C2A8 RID: 49832
		public const int MotorIsEnablePushFieldNumber = 65;

		// Token: 0x0400C2A9 RID: 49833
		public const int MotorSummonAndRidePushFieldNumber = 66;

		// Token: 0x0400C2AA RID: 49834
		public const int BulletPatternPushFieldNumber = 67;

		// Token: 0x0400C2AB RID: 49835
		public const int QuickHackRamVerifyPushFieldNumber = 68;

		// Token: 0x0400C2AC RID: 49836
		public const int QuickHackOpenPushFieldNumber = 69;

		// Token: 0x0400C2AD RID: 49837
		public const int DodgeInfoPushFieldNumber = 70;

		// Token: 0x0400C2AE RID: 49838
		public const int SwitchDarkTideWeaponPushFieldNumber = 71;

		// Token: 0x0400C2AF RID: 49839
		public const int RoleTrialSceneRollbackPushFieldNumber = 72;

		// Token: 0x0400C2B0 RID: 49840
		private object message_;

		// Token: 0x0400C2B1 RID: 49841
		private CombatPushData.MessageOneofCase messageCase_;

		// Token: 0x020019FE RID: 6654
		public enum MessageOneofCase
		{
			// Token: 0x0400CB3F RID: 52031
			None,
			// Token: 0x0400CB40 RID: 52032
			ApplyBuffS2CResponsePush = 4,
			// Token: 0x0400CB41 RID: 52033
			RemoveBuffS2CResponsePush,
			// Token: 0x0400CB42 RID: 52034
			RemoveBuffByIdS2CResponsePush,
			// Token: 0x0400CB43 RID: 52035
			CreateBulletPush,
			// Token: 0x0400CB44 RID: 52036
			DestroyBulletPush,
			// Token: 0x0400CB45 RID: 52037
			ApplyGameplayEffectPush,
			// Token: 0x0400CB46 RID: 52038
			RemoveGameplayEffectPush,
			// Token: 0x0400CB47 RID: 52039
			HitEndPush,
			// Token: 0x0400CB48 RID: 52040
			EndSkillPush,
			// Token: 0x0400CB49 RID: 52041
			PartUpdatePush,
			// Token: 0x0400CB4A RID: 52042
			MaterialPush,
			// Token: 0x0400CB4B RID: 52043
			GameplayCuePush,
			// Token: 0x0400CB4C RID: 52044
			EntityIsVisiblePush,
			// Token: 0x0400CB4D RID: 52045
			SwitchCharacterStatePush,
			// Token: 0x0400CB4E RID: 52046
			LogicStateInitPush,
			// Token: 0x0400CB4F RID: 52047
			SwitchLogicStatePush,
			// Token: 0x0400CB50 RID: 52048
			AnimationStateChangedPush,
			// Token: 0x0400CB51 RID: 52049
			AnimationStateInitPush,
			// Token: 0x0400CB52 RID: 52050
			ModifyBulletParamsPush,
			// Token: 0x0400CB53 RID: 52051
			DrownPush,
			// Token: 0x0400CB54 RID: 52052
			ActivateBuffPush,
			// Token: 0x0400CB55 RID: 52053
			AiInformationPush,
			// Token: 0x0400CB56 RID: 52054
			ToughCalcExtraRatioChangePush,
			// Token: 0x0400CB57 RID: 52055
			BattleStateChangePush,
			// Token: 0x0400CB58 RID: 52056
			AnimationGameplayTagPush,
			// Token: 0x0400CB59 RID: 52057
			BoneVisibleChangePush,
			// Token: 0x0400CB5A RID: 52058
			AiBlackboardsPush,
			// Token: 0x0400CB5B RID: 52059
			AiBlackboardCdPush,
			// Token: 0x0400CB5C RID: 52060
			AiHatePush,
			// Token: 0x0400CB5D RID: 52061
			MonsterBoomPush,
			// Token: 0x0400CB5E RID: 52062
			CaughtPush,
			// Token: 0x0400CB5F RID: 52063
			EntityStaticHookMovePush,
			// Token: 0x0400CB60 RID: 52064
			ChangeStateConfirmPush,
			// Token: 0x0400CB61 RID: 52065
			BuffStackCountPush,
			// Token: 0x0400CB62 RID: 52066
			ANStartPush,
			// Token: 0x0400CB63 RID: 52067
			UseSkillFailPush,
			// Token: 0x0400CB64 RID: 52068
			EnterViewDirectionPush,
			// Token: 0x0400CB65 RID: 52069
			ExitViewDirectionPush,
			// Token: 0x0400CB66 RID: 52070
			PassiveSkillAddPush,
			// Token: 0x0400CB67 RID: 52071
			InterruptSkillInDelayPush,
			// Token: 0x0400CB68 RID: 52072
			TriggerExitSkillPush,
			// Token: 0x0400CB69 RID: 52073
			ActorVisiblePush,
			// Token: 0x0400CB6A RID: 52074
			BuffEffectPush,
			// Token: 0x0400CB6B RID: 52075
			RTimeStopPush,
			// Token: 0x0400CB6C RID: 52076
			DrownEndTeleportPush,
			// Token: 0x0400CB6D RID: 52077
			MonsterDrownPush,
			// Token: 0x0400CB6E RID: 52078
			PassiveSkillRemovePush,
			// Token: 0x0400CB6F RID: 52079
			RTimeStopInstPush,
			// Token: 0x0400CB70 RID: 52080
			FsmPlayMontagePush,
			// Token: 0x0400CB71 RID: 52081
			RTimeStopAnimPush,
			// Token: 0x0400CB72 RID: 52082
			GameplayTagPush,
			// Token: 0x0400CB73 RID: 52083
			ExecuteQtePush,
			// Token: 0x0400CB74 RID: 52084
			ClientCurrentRoleReportPush,
			// Token: 0x0400CB75 RID: 52085
			PlayEntityMontagePush,
			// Token: 0x0400CB76 RID: 52086
			BeforeHitPush,
			// Token: 0x0400CB77 RID: 52087
			NewLinkBurstPush,
			// Token: 0x0400CB78 RID: 52088
			RefreshBuffDurationPush,
			// Token: 0x0400CB79 RID: 52089
			RoleGoDownPush,
			// Token: 0x0400CB7A RID: 52090
			FsmConditionPassPush,
			// Token: 0x0400CB7B RID: 52091
			BuffEffectExecutePush,
			// Token: 0x0400CB7C RID: 52092
			VisionTriggerPush,
			// Token: 0x0400CB7D RID: 52093
			MotorIsEnablePush,
			// Token: 0x0400CB7E RID: 52094
			MotorSummonAndRidePush,
			// Token: 0x0400CB7F RID: 52095
			BulletPatternPush,
			// Token: 0x0400CB80 RID: 52096
			QuickHackRamVerifyPush,
			// Token: 0x0400CB81 RID: 52097
			QuickHackOpenPush,
			// Token: 0x0400CB82 RID: 52098
			DodgeInfoPush,
			// Token: 0x0400CB83 RID: 52099
			SwitchDarkTideWeaponPush,
			// Token: 0x0400CB84 RID: 52100
			RoleTrialSceneRollbackPush
		}
	}
}
