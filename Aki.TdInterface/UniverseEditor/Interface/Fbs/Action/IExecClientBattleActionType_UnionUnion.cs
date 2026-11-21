using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8C RID: 28044
	public class IExecClientBattleActionType_UnionUnion
	{
		// Token: 0x1700CDAF RID: 52655
		// (get) Token: 0x06030653 RID: 198227 RVA: 0x006938E5 File Offset: 0x00691AE5
		// (set) Token: 0x06030654 RID: 198228 RVA: 0x006938ED File Offset: 0x00691AED
		public IExecClientBattleActionType_Union Type { get; set; }

		// Token: 0x1700CDB0 RID: 52656
		// (get) Token: 0x06030655 RID: 198229 RVA: 0x006938F6 File Offset: 0x00691AF6
		// (set) Token: 0x06030656 RID: 198230 RVA: 0x006938FE File Offset: 0x00691AFE
		public object Value { get; set; }

		// Token: 0x06030657 RID: 198231 RVA: 0x00693907 File Offset: 0x00691B07
		public IExecClientBattleActionType_UnionUnion()
		{
			this.Type = IExecClientBattleActionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030658 RID: 198232 RVA: 0x0069391D File Offset: 0x00691B1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030659 RID: 198233 RVA: 0x0069392F File Offset: 0x00691B2F
		public IExecClientBattleActionTypeT AsIExecClientBattleActionType()
		{
			return this.As<IExecClientBattleActionTypeT>();
		}

		// Token: 0x0603065A RID: 198234 RVA: 0x00693937 File Offset: 0x00691B37
		public static IExecClientBattleActionType_UnionUnion FromIExecClientBattleActionType(IExecClientBattleActionTypeT _iexecclientbattleactiontype)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IExecClientBattleActionType,
				Value = _iexecclientbattleactiontype
			};
		}

		// Token: 0x0603065B RID: 198235 RVA: 0x0069394C File Offset: 0x00691B4C
		public IClientSendTagEventToControlCharacterT AsIClientSendTagEventToControlCharacter()
		{
			return this.As<IClientSendTagEventToControlCharacterT>();
		}

		// Token: 0x0603065C RID: 198236 RVA: 0x00693954 File Offset: 0x00691B54
		public static IExecClientBattleActionType_UnionUnion FromIClientSendTagEventToControlCharacter(IClientSendTagEventToControlCharacterT _iclientsendtageventtocontrolcharacter)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IClientSendTagEventToControlCharacter,
				Value = _iclientsendtageventtocontrolcharacter
			};
		}

		// Token: 0x0603065D RID: 198237 RVA: 0x00693969 File Offset: 0x00691B69
		public ITriggerHookPointSkillT AsITriggerHookPointSkill()
		{
			return this.As<ITriggerHookPointSkillT>();
		}

		// Token: 0x0603065E RID: 198238 RVA: 0x00693971 File Offset: 0x00691B71
		public static IExecClientBattleActionType_UnionUnion FromITriggerHookPointSkill(ITriggerHookPointSkillT _itriggerhookpointskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.ITriggerHookPointSkill,
				Value = _itriggerhookpointskill
			};
		}

		// Token: 0x0603065F RID: 198239 RVA: 0x00693986 File Offset: 0x00691B86
		public ITriggerMotorSkillT AsITriggerMotorSkill()
		{
			return this.As<ITriggerMotorSkillT>();
		}

		// Token: 0x06030660 RID: 198240 RVA: 0x0069398E File Offset: 0x00691B8E
		public static IExecClientBattleActionType_UnionUnion FromITriggerMotorSkill(ITriggerMotorSkillT _itriggermotorskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.ITriggerMotorSkill,
				Value = _itriggermotorskill
			};
		}

		// Token: 0x06030661 RID: 198241 RVA: 0x006939A3 File Offset: 0x00691BA3
		public IFollowShooterSkillSkillT AsIFollowShooterSkillSkill()
		{
			return this.As<IFollowShooterSkillSkillT>();
		}

		// Token: 0x06030662 RID: 198242 RVA: 0x006939AB File Offset: 0x00691BAB
		public static IExecClientBattleActionType_UnionUnion FromIFollowShooterSkillSkill(IFollowShooterSkillSkillT _ifollowshooterskillskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IFollowShooterSkillSkill,
				Value = _ifollowshooterskillskill
			};
		}

		// Token: 0x06030663 RID: 198243 RVA: 0x006939C0 File Offset: 0x00691BC0
		public IClientGroupAiCommunicateT AsIClientGroupAiCommunicate()
		{
			return this.As<IClientGroupAiCommunicateT>();
		}

		// Token: 0x06030664 RID: 198244 RVA: 0x006939C8 File Offset: 0x00691BC8
		public static IExecClientBattleActionType_UnionUnion FromIClientGroupAiCommunicate(IClientGroupAiCommunicateT _iclientgroupaicommunicate)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IClientGroupAiCommunicate,
				Value = _iclientgroupaicommunicate
			};
		}

		// Token: 0x06030665 RID: 198245 RVA: 0x006939DD File Offset: 0x00691BDD
		public IChangeAnimalEmotionBubbleT AsIChangeAnimalEmotionBubble()
		{
			return this.As<IChangeAnimalEmotionBubbleT>();
		}

		// Token: 0x06030666 RID: 198246 RVA: 0x006939E5 File Offset: 0x00691BE5
		public static IExecClientBattleActionType_UnionUnion FromIChangeAnimalEmotionBubble(IChangeAnimalEmotionBubbleT _ichangeanimalemotionbubble)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IChangeAnimalEmotionBubble,
				Value = _ichangeanimalemotionbubble
			};
		}

		// Token: 0x06030667 RID: 198247 RVA: 0x006939FA File Offset: 0x00691BFA
		public IMonsterNpcInteractT AsIMonsterNpcInteract()
		{
			return this.As<IMonsterNpcInteractT>();
		}

		// Token: 0x06030668 RID: 198248 RVA: 0x00693A02 File Offset: 0x00691C02
		public static IExecClientBattleActionType_UnionUnion FromIMonsterNpcInteract(IMonsterNpcInteractT _imonsternpcinteract)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IMonsterNpcInteract,
				Value = _imonsternpcinteract
			};
		}

		// Token: 0x06030669 RID: 198249 RVA: 0x00693A17 File Offset: 0x00691C17
		public IRoboSoldierSpecialTriggerHookSkillT AsIRoboSoldierSpecialTriggerHookSkill()
		{
			return this.As<IRoboSoldierSpecialTriggerHookSkillT>();
		}

		// Token: 0x0603066A RID: 198250 RVA: 0x00693A1F File Offset: 0x00691C1F
		public static IExecClientBattleActionType_UnionUnion FromIRoboSoldierSpecialTriggerHookSkill(IRoboSoldierSpecialTriggerHookSkillT _irobosoldierspecialtriggerhookskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IRoboSoldierSpecialTriggerHookSkill,
				Value = _irobosoldierspecialtriggerhookskill
			};
		}

		// Token: 0x0603066B RID: 198251 RVA: 0x00693A35 File Offset: 0x00691C35
		public IAssistCharacterMoveToPointT AsIAssistCharacterMoveToPoint()
		{
			return this.As<IAssistCharacterMoveToPointT>();
		}

		// Token: 0x0603066C RID: 198252 RVA: 0x00693A3D File Offset: 0x00691C3D
		public static IExecClientBattleActionType_UnionUnion FromIAssistCharacterMoveToPoint(IAssistCharacterMoveToPointT _iassistcharactermovetopoint)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IAssistCharacterMoveToPoint,
				Value = _iassistcharactermovetopoint
			};
		}

		// Token: 0x0603066D RID: 198253 RVA: 0x00693A53 File Offset: 0x00691C53
		public IAssistCharacterStopMoveToPointT AsIAssistCharacterStopMoveToPoint()
		{
			return this.As<IAssistCharacterStopMoveToPointT>();
		}

		// Token: 0x0603066E RID: 198254 RVA: 0x00693A5B File Offset: 0x00691C5B
		public static IExecClientBattleActionType_UnionUnion FromIAssistCharacterStopMoveToPoint(IAssistCharacterStopMoveToPointT _iassistcharacterstopmovetopoint)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IAssistCharacterStopMoveToPoint,
				Value = _iassistcharacterstopmovetopoint
			};
		}

		// Token: 0x0603066F RID: 198255 RVA: 0x00693A71 File Offset: 0x00691C71
		public IMechExecuteT AsIMechExecute()
		{
			return this.As<IMechExecuteT>();
		}

		// Token: 0x06030670 RID: 198256 RVA: 0x00693A79 File Offset: 0x00691C79
		public static IExecClientBattleActionType_UnionUnion FromIMechExecute(IMechExecuteT _imechexecute)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IMechExecute,
				Value = _imechexecute
			};
		}

		// Token: 0x06030671 RID: 198257 RVA: 0x00693A90 File Offset: 0x00691C90
		public static int Pack(FlatBufferBuilder builder, IExecClientBattleActionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IExecClientBattleActionType_Union.IExecClientBattleActionType:
				return IExecClientBattleActionType.Pack(builder, _o.AsIExecClientBattleActionType()).Value;
			case IExecClientBattleActionType_Union.IClientSendTagEventToControlCharacter:
				return IClientSendTagEventToControlCharacter.Pack(builder, _o.AsIClientSendTagEventToControlCharacter()).Value;
			case IExecClientBattleActionType_Union.ITriggerHookPointSkill:
				return ITriggerHookPointSkill.Pack(builder, _o.AsITriggerHookPointSkill()).Value;
			case IExecClientBattleActionType_Union.ITriggerMotorSkill:
				return ITriggerMotorSkill.Pack(builder, _o.AsITriggerMotorSkill()).Value;
			case IExecClientBattleActionType_Union.IFollowShooterSkillSkill:
				return IFollowShooterSkillSkill.Pack(builder, _o.AsIFollowShooterSkillSkill()).Value;
			case IExecClientBattleActionType_Union.IClientGroupAiCommunicate:
				return IClientGroupAiCommunicate.Pack(builder, _o.AsIClientGroupAiCommunicate()).Value;
			case IExecClientBattleActionType_Union.IChangeAnimalEmotionBubble:
				return IChangeAnimalEmotionBubble.Pack(builder, _o.AsIChangeAnimalEmotionBubble()).Value;
			case IExecClientBattleActionType_Union.IMonsterNpcInteract:
				return IMonsterNpcInteract.Pack(builder, _o.AsIMonsterNpcInteract()).Value;
			case IExecClientBattleActionType_Union.IRoboSoldierSpecialTriggerHookSkill:
				return IRoboSoldierSpecialTriggerHookSkill.Pack(builder, _o.AsIRoboSoldierSpecialTriggerHookSkill()).Value;
			case IExecClientBattleActionType_Union.IAssistCharacterMoveToPoint:
				return IAssistCharacterMoveToPoint.Pack(builder, _o.AsIAssistCharacterMoveToPoint()).Value;
			case IExecClientBattleActionType_Union.IAssistCharacterStopMoveToPoint:
				return IAssistCharacterStopMoveToPoint.Pack(builder, _o.AsIAssistCharacterStopMoveToPoint()).Value;
			case IExecClientBattleActionType_Union.IMechExecute:
				return IMechExecute.Pack(builder, _o.AsIMechExecute()).Value;
			default:
				return 0;
			}
		}
	}
}
