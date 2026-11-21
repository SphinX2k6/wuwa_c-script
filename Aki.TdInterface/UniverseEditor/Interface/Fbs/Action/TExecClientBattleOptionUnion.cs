using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ECE RID: 32462
	public class TExecClientBattleOptionUnion
	{
		// Token: 0x1700F257 RID: 62039
		// (get) Token: 0x0603A95D RID: 239965 RVA: 0x007E20EC File Offset: 0x007E02EC
		// (set) Token: 0x0603A95E RID: 239966 RVA: 0x007E20F4 File Offset: 0x007E02F4
		public TExecClientBattleOption Type { get; set; }

		// Token: 0x1700F258 RID: 62040
		// (get) Token: 0x0603A95F RID: 239967 RVA: 0x007E20FD File Offset: 0x007E02FD
		// (set) Token: 0x0603A960 RID: 239968 RVA: 0x007E2105 File Offset: 0x007E0305
		public object Value { get; set; }

		// Token: 0x0603A961 RID: 239969 RVA: 0x007E210E File Offset: 0x007E030E
		public TExecClientBattleOptionUnion()
		{
			this.Type = TExecClientBattleOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603A962 RID: 239970 RVA: 0x007E2124 File Offset: 0x007E0324
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A963 RID: 239971 RVA: 0x007E2136 File Offset: 0x007E0336
		public IAssistCharacterMoveToPointT AsIAssistCharacterMoveToPoint()
		{
			return this.As<IAssistCharacterMoveToPointT>();
		}

		// Token: 0x0603A964 RID: 239972 RVA: 0x007E213E File Offset: 0x007E033E
		public static TExecClientBattleOptionUnion FromIAssistCharacterMoveToPoint(IAssistCharacterMoveToPointT _iassistcharactermovetopoint)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IAssistCharacterMoveToPoint,
				Value = _iassistcharactermovetopoint
			};
		}

		// Token: 0x0603A965 RID: 239973 RVA: 0x007E2153 File Offset: 0x007E0353
		public IAssistCharacterStopMoveToPointT AsIAssistCharacterStopMoveToPoint()
		{
			return this.As<IAssistCharacterStopMoveToPointT>();
		}

		// Token: 0x0603A966 RID: 239974 RVA: 0x007E215B File Offset: 0x007E035B
		public static TExecClientBattleOptionUnion FromIAssistCharacterStopMoveToPoint(IAssistCharacterStopMoveToPointT _iassistcharacterstopmovetopoint)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IAssistCharacterStopMoveToPoint,
				Value = _iassistcharacterstopmovetopoint
			};
		}

		// Token: 0x0603A967 RID: 239975 RVA: 0x007E2170 File Offset: 0x007E0370
		public IChangeAnimalEmotionBubbleT AsIChangeAnimalEmotionBubble()
		{
			return this.As<IChangeAnimalEmotionBubbleT>();
		}

		// Token: 0x0603A968 RID: 239976 RVA: 0x007E2178 File Offset: 0x007E0378
		public static TExecClientBattleOptionUnion FromIChangeAnimalEmotionBubble(IChangeAnimalEmotionBubbleT _ichangeanimalemotionbubble)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IChangeAnimalEmotionBubble,
				Value = _ichangeanimalemotionbubble
			};
		}

		// Token: 0x0603A969 RID: 239977 RVA: 0x007E218D File Offset: 0x007E038D
		public IClientGroupAiCommunicateT AsIClientGroupAiCommunicate()
		{
			return this.As<IClientGroupAiCommunicateT>();
		}

		// Token: 0x0603A96A RID: 239978 RVA: 0x007E2195 File Offset: 0x007E0395
		public static TExecClientBattleOptionUnion FromIClientGroupAiCommunicate(IClientGroupAiCommunicateT _iclientgroupaicommunicate)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IClientGroupAiCommunicate,
				Value = _iclientgroupaicommunicate
			};
		}

		// Token: 0x0603A96B RID: 239979 RVA: 0x007E21AA File Offset: 0x007E03AA
		public IClientSendTagEventToControlCharacterT AsIClientSendTagEventToControlCharacter()
		{
			return this.As<IClientSendTagEventToControlCharacterT>();
		}

		// Token: 0x0603A96C RID: 239980 RVA: 0x007E21B2 File Offset: 0x007E03B2
		public static TExecClientBattleOptionUnion FromIClientSendTagEventToControlCharacter(IClientSendTagEventToControlCharacterT _iclientsendtageventtocontrolcharacter)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IClientSendTagEventToControlCharacter,
				Value = _iclientsendtageventtocontrolcharacter
			};
		}

		// Token: 0x0603A96D RID: 239981 RVA: 0x007E21C7 File Offset: 0x007E03C7
		public IFollowShooterSkillSkillT AsIFollowShooterSkillSkill()
		{
			return this.As<IFollowShooterSkillSkillT>();
		}

		// Token: 0x0603A96E RID: 239982 RVA: 0x007E21CF File Offset: 0x007E03CF
		public static TExecClientBattleOptionUnion FromIFollowShooterSkillSkill(IFollowShooterSkillSkillT _ifollowshooterskillskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IFollowShooterSkillSkill,
				Value = _ifollowshooterskillskill
			};
		}

		// Token: 0x0603A96F RID: 239983 RVA: 0x007E21E4 File Offset: 0x007E03E4
		public IMechExecuteT AsIMechExecute()
		{
			return this.As<IMechExecuteT>();
		}

		// Token: 0x0603A970 RID: 239984 RVA: 0x007E21EC File Offset: 0x007E03EC
		public static TExecClientBattleOptionUnion FromIMechExecute(IMechExecuteT _imechexecute)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IMechExecute,
				Value = _imechexecute
			};
		}

		// Token: 0x0603A971 RID: 239985 RVA: 0x007E2201 File Offset: 0x007E0401
		public IMonsterNpcInteractT AsIMonsterNpcInteract()
		{
			return this.As<IMonsterNpcInteractT>();
		}

		// Token: 0x0603A972 RID: 239986 RVA: 0x007E2209 File Offset: 0x007E0409
		public static TExecClientBattleOptionUnion FromIMonsterNpcInteract(IMonsterNpcInteractT _imonsternpcinteract)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IMonsterNpcInteract,
				Value = _imonsternpcinteract
			};
		}

		// Token: 0x0603A973 RID: 239987 RVA: 0x007E221E File Offset: 0x007E041E
		public IRoboSoldierSpecialTriggerHookSkillT AsIRoboSoldierSpecialTriggerHookSkill()
		{
			return this.As<IRoboSoldierSpecialTriggerHookSkillT>();
		}

		// Token: 0x0603A974 RID: 239988 RVA: 0x007E2226 File Offset: 0x007E0426
		public static TExecClientBattleOptionUnion FromIRoboSoldierSpecialTriggerHookSkill(IRoboSoldierSpecialTriggerHookSkillT _irobosoldierspecialtriggerhookskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IRoboSoldierSpecialTriggerHookSkill,
				Value = _irobosoldierspecialtriggerhookskill
			};
		}

		// Token: 0x0603A975 RID: 239989 RVA: 0x007E223C File Offset: 0x007E043C
		public ITriggerHookPointSkillT AsITriggerHookPointSkill()
		{
			return this.As<ITriggerHookPointSkillT>();
		}

		// Token: 0x0603A976 RID: 239990 RVA: 0x007E2244 File Offset: 0x007E0444
		public static TExecClientBattleOptionUnion FromITriggerHookPointSkill(ITriggerHookPointSkillT _itriggerhookpointskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.ITriggerHookPointSkill,
				Value = _itriggerhookpointskill
			};
		}

		// Token: 0x0603A977 RID: 239991 RVA: 0x007E225A File Offset: 0x007E045A
		public ITriggerMotorSkillT AsITriggerMotorSkill()
		{
			return this.As<ITriggerMotorSkillT>();
		}

		// Token: 0x0603A978 RID: 239992 RVA: 0x007E2262 File Offset: 0x007E0462
		public static TExecClientBattleOptionUnion FromITriggerMotorSkill(ITriggerMotorSkillT _itriggermotorskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.ITriggerMotorSkill,
				Value = _itriggermotorskill
			};
		}

		// Token: 0x0603A979 RID: 239993 RVA: 0x007E2278 File Offset: 0x007E0478
		public static int Pack(FlatBufferBuilder builder, TExecClientBattleOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TExecClientBattleOption.IAssistCharacterMoveToPoint:
				return IAssistCharacterMoveToPoint.Pack(builder, _o.AsIAssistCharacterMoveToPoint()).Value;
			case TExecClientBattleOption.IAssistCharacterStopMoveToPoint:
				return IAssistCharacterStopMoveToPoint.Pack(builder, _o.AsIAssistCharacterStopMoveToPoint()).Value;
			case TExecClientBattleOption.IChangeAnimalEmotionBubble:
				return IChangeAnimalEmotionBubble.Pack(builder, _o.AsIChangeAnimalEmotionBubble()).Value;
			case TExecClientBattleOption.IClientGroupAiCommunicate:
				return IClientGroupAiCommunicate.Pack(builder, _o.AsIClientGroupAiCommunicate()).Value;
			case TExecClientBattleOption.IClientSendTagEventToControlCharacter:
				return IClientSendTagEventToControlCharacter.Pack(builder, _o.AsIClientSendTagEventToControlCharacter()).Value;
			case TExecClientBattleOption.IFollowShooterSkillSkill:
				return IFollowShooterSkillSkill.Pack(builder, _o.AsIFollowShooterSkillSkill()).Value;
			case TExecClientBattleOption.IMechExecute:
				return IMechExecute.Pack(builder, _o.AsIMechExecute()).Value;
			case TExecClientBattleOption.IMonsterNpcInteract:
				return IMonsterNpcInteract.Pack(builder, _o.AsIMonsterNpcInteract()).Value;
			case TExecClientBattleOption.IRoboSoldierSpecialTriggerHookSkill:
				return IRoboSoldierSpecialTriggerHookSkill.Pack(builder, _o.AsIRoboSoldierSpecialTriggerHookSkill()).Value;
			case TExecClientBattleOption.ITriggerHookPointSkill:
				return ITriggerHookPointSkill.Pack(builder, _o.AsITriggerHookPointSkill()).Value;
			case TExecClientBattleOption.ITriggerMotorSkill:
				return ITriggerMotorSkill.Pack(builder, _o.AsITriggerMotorSkill()).Value;
			default:
				return 0;
			}
		}
	}
}
