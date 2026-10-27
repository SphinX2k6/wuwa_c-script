using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C0 RID: 30400
	public class TExecClientBattleOptionUnion
	{
		// Token: 0x1700E619 RID: 58905
		// (get) Token: 0x060374AA RID: 226474 RVA: 0x0077DE18 File Offset: 0x0077C018
		// (set) Token: 0x060374AB RID: 226475 RVA: 0x0077DE20 File Offset: 0x0077C020
		public TExecClientBattleOption Type { get; set; }

		// Token: 0x1700E61A RID: 58906
		// (get) Token: 0x060374AC RID: 226476 RVA: 0x0077DE29 File Offset: 0x0077C029
		// (set) Token: 0x060374AD RID: 226477 RVA: 0x0077DE31 File Offset: 0x0077C031
		public object Value { get; set; }

		// Token: 0x060374AE RID: 226478 RVA: 0x0077DE3A File Offset: 0x0077C03A
		public TExecClientBattleOptionUnion()
		{
			this.Type = TExecClientBattleOption.NONE;
			this.Value = null;
		}

		// Token: 0x060374AF RID: 226479 RVA: 0x0077DE50 File Offset: 0x0077C050
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060374B0 RID: 226480 RVA: 0x0077DE62 File Offset: 0x0077C062
		public IAssistCharacterMoveToPointT AsIAssistCharacterMoveToPoint()
		{
			return this.As<IAssistCharacterMoveToPointT>();
		}

		// Token: 0x060374B1 RID: 226481 RVA: 0x0077DE6A File Offset: 0x0077C06A
		public static TExecClientBattleOptionUnion FromIAssistCharacterMoveToPoint(IAssistCharacterMoveToPointT _iassistcharactermovetopoint)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IAssistCharacterMoveToPoint,
				Value = _iassistcharactermovetopoint
			};
		}

		// Token: 0x060374B2 RID: 226482 RVA: 0x0077DE7F File Offset: 0x0077C07F
		public IAssistCharacterStopMoveToPointT AsIAssistCharacterStopMoveToPoint()
		{
			return this.As<IAssistCharacterStopMoveToPointT>();
		}

		// Token: 0x060374B3 RID: 226483 RVA: 0x0077DE87 File Offset: 0x0077C087
		public static TExecClientBattleOptionUnion FromIAssistCharacterStopMoveToPoint(IAssistCharacterStopMoveToPointT _iassistcharacterstopmovetopoint)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IAssistCharacterStopMoveToPoint,
				Value = _iassistcharacterstopmovetopoint
			};
		}

		// Token: 0x060374B4 RID: 226484 RVA: 0x0077DE9C File Offset: 0x0077C09C
		public IChangeAnimalEmotionBubbleT AsIChangeAnimalEmotionBubble()
		{
			return this.As<IChangeAnimalEmotionBubbleT>();
		}

		// Token: 0x060374B5 RID: 226485 RVA: 0x0077DEA4 File Offset: 0x0077C0A4
		public static TExecClientBattleOptionUnion FromIChangeAnimalEmotionBubble(IChangeAnimalEmotionBubbleT _ichangeanimalemotionbubble)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IChangeAnimalEmotionBubble,
				Value = _ichangeanimalemotionbubble
			};
		}

		// Token: 0x060374B6 RID: 226486 RVA: 0x0077DEB9 File Offset: 0x0077C0B9
		public IClientGroupAiCommunicateT AsIClientGroupAiCommunicate()
		{
			return this.As<IClientGroupAiCommunicateT>();
		}

		// Token: 0x060374B7 RID: 226487 RVA: 0x0077DEC1 File Offset: 0x0077C0C1
		public static TExecClientBattleOptionUnion FromIClientGroupAiCommunicate(IClientGroupAiCommunicateT _iclientgroupaicommunicate)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IClientGroupAiCommunicate,
				Value = _iclientgroupaicommunicate
			};
		}

		// Token: 0x060374B8 RID: 226488 RVA: 0x0077DED6 File Offset: 0x0077C0D6
		public IClientSendTagEventToControlCharacterT AsIClientSendTagEventToControlCharacter()
		{
			return this.As<IClientSendTagEventToControlCharacterT>();
		}

		// Token: 0x060374B9 RID: 226489 RVA: 0x0077DEDE File Offset: 0x0077C0DE
		public static TExecClientBattleOptionUnion FromIClientSendTagEventToControlCharacter(IClientSendTagEventToControlCharacterT _iclientsendtageventtocontrolcharacter)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IClientSendTagEventToControlCharacter,
				Value = _iclientsendtageventtocontrolcharacter
			};
		}

		// Token: 0x060374BA RID: 226490 RVA: 0x0077DEF3 File Offset: 0x0077C0F3
		public IFollowShooterSkillSkillT AsIFollowShooterSkillSkill()
		{
			return this.As<IFollowShooterSkillSkillT>();
		}

		// Token: 0x060374BB RID: 226491 RVA: 0x0077DEFB File Offset: 0x0077C0FB
		public static TExecClientBattleOptionUnion FromIFollowShooterSkillSkill(IFollowShooterSkillSkillT _ifollowshooterskillskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IFollowShooterSkillSkill,
				Value = _ifollowshooterskillskill
			};
		}

		// Token: 0x060374BC RID: 226492 RVA: 0x0077DF10 File Offset: 0x0077C110
		public IMonsterNpcInteractT AsIMonsterNpcInteract()
		{
			return this.As<IMonsterNpcInteractT>();
		}

		// Token: 0x060374BD RID: 226493 RVA: 0x0077DF18 File Offset: 0x0077C118
		public static TExecClientBattleOptionUnion FromIMonsterNpcInteract(IMonsterNpcInteractT _imonsternpcinteract)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IMonsterNpcInteract,
				Value = _imonsternpcinteract
			};
		}

		// Token: 0x060374BE RID: 226494 RVA: 0x0077DF2D File Offset: 0x0077C12D
		public IRoboSoldierSpecialTriggerHookSkillT AsIRoboSoldierSpecialTriggerHookSkill()
		{
			return this.As<IRoboSoldierSpecialTriggerHookSkillT>();
		}

		// Token: 0x060374BF RID: 226495 RVA: 0x0077DF35 File Offset: 0x0077C135
		public static TExecClientBattleOptionUnion FromIRoboSoldierSpecialTriggerHookSkill(IRoboSoldierSpecialTriggerHookSkillT _irobosoldierspecialtriggerhookskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.IRoboSoldierSpecialTriggerHookSkill,
				Value = _irobosoldierspecialtriggerhookskill
			};
		}

		// Token: 0x060374C0 RID: 226496 RVA: 0x0077DF4A File Offset: 0x0077C14A
		public ITriggerHookPointSkillT AsITriggerHookPointSkill()
		{
			return this.As<ITriggerHookPointSkillT>();
		}

		// Token: 0x060374C1 RID: 226497 RVA: 0x0077DF52 File Offset: 0x0077C152
		public static TExecClientBattleOptionUnion FromITriggerHookPointSkill(ITriggerHookPointSkillT _itriggerhookpointskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.ITriggerHookPointSkill,
				Value = _itriggerhookpointskill
			};
		}

		// Token: 0x060374C2 RID: 226498 RVA: 0x0077DF68 File Offset: 0x0077C168
		public ITriggerMotorSkillT AsITriggerMotorSkill()
		{
			return this.As<ITriggerMotorSkillT>();
		}

		// Token: 0x060374C3 RID: 226499 RVA: 0x0077DF70 File Offset: 0x0077C170
		public static TExecClientBattleOptionUnion FromITriggerMotorSkill(ITriggerMotorSkillT _itriggermotorskill)
		{
			return new TExecClientBattleOptionUnion
			{
				Type = TExecClientBattleOption.ITriggerMotorSkill,
				Value = _itriggermotorskill
			};
		}

		// Token: 0x060374C4 RID: 226500 RVA: 0x0077DF88 File Offset: 0x0077C188
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
