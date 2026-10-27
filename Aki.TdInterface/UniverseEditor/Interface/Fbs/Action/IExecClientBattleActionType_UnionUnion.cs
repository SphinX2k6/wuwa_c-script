using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670C RID: 26380
	public class IExecClientBattleActionType_UnionUnion
	{
		// Token: 0x1700C3F9 RID: 50169
		// (get) Token: 0x0602DE0F RID: 187919 RVA: 0x006461E5 File Offset: 0x006443E5
		// (set) Token: 0x0602DE10 RID: 187920 RVA: 0x006461ED File Offset: 0x006443ED
		public IExecClientBattleActionType_Union Type { get; set; }

		// Token: 0x1700C3FA RID: 50170
		// (get) Token: 0x0602DE11 RID: 187921 RVA: 0x006461F6 File Offset: 0x006443F6
		// (set) Token: 0x0602DE12 RID: 187922 RVA: 0x006461FE File Offset: 0x006443FE
		public object Value { get; set; }

		// Token: 0x0602DE13 RID: 187923 RVA: 0x00646207 File Offset: 0x00644407
		public IExecClientBattleActionType_UnionUnion()
		{
			this.Type = IExecClientBattleActionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DE14 RID: 187924 RVA: 0x0064621D File Offset: 0x0064441D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DE15 RID: 187925 RVA: 0x0064622F File Offset: 0x0064442F
		public IExecClientBattleActionTypeT AsIExecClientBattleActionType()
		{
			return this.As<IExecClientBattleActionTypeT>();
		}

		// Token: 0x0602DE16 RID: 187926 RVA: 0x00646237 File Offset: 0x00644437
		public static IExecClientBattleActionType_UnionUnion FromIExecClientBattleActionType(IExecClientBattleActionTypeT _iexecclientbattleactiontype)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IExecClientBattleActionType,
				Value = _iexecclientbattleactiontype
			};
		}

		// Token: 0x0602DE17 RID: 187927 RVA: 0x0064624C File Offset: 0x0064444C
		public IClientSendTagEventToControlCharacterT AsIClientSendTagEventToControlCharacter()
		{
			return this.As<IClientSendTagEventToControlCharacterT>();
		}

		// Token: 0x0602DE18 RID: 187928 RVA: 0x00646254 File Offset: 0x00644454
		public static IExecClientBattleActionType_UnionUnion FromIClientSendTagEventToControlCharacter(IClientSendTagEventToControlCharacterT _iclientsendtageventtocontrolcharacter)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IClientSendTagEventToControlCharacter,
				Value = _iclientsendtageventtocontrolcharacter
			};
		}

		// Token: 0x0602DE19 RID: 187929 RVA: 0x00646269 File Offset: 0x00644469
		public ITriggerHookPointSkillT AsITriggerHookPointSkill()
		{
			return this.As<ITriggerHookPointSkillT>();
		}

		// Token: 0x0602DE1A RID: 187930 RVA: 0x00646271 File Offset: 0x00644471
		public static IExecClientBattleActionType_UnionUnion FromITriggerHookPointSkill(ITriggerHookPointSkillT _itriggerhookpointskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.ITriggerHookPointSkill,
				Value = _itriggerhookpointskill
			};
		}

		// Token: 0x0602DE1B RID: 187931 RVA: 0x00646286 File Offset: 0x00644486
		public ITriggerMotorSkillT AsITriggerMotorSkill()
		{
			return this.As<ITriggerMotorSkillT>();
		}

		// Token: 0x0602DE1C RID: 187932 RVA: 0x0064628E File Offset: 0x0064448E
		public static IExecClientBattleActionType_UnionUnion FromITriggerMotorSkill(ITriggerMotorSkillT _itriggermotorskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.ITriggerMotorSkill,
				Value = _itriggermotorskill
			};
		}

		// Token: 0x0602DE1D RID: 187933 RVA: 0x006462A3 File Offset: 0x006444A3
		public IFollowShooterSkillSkillT AsIFollowShooterSkillSkill()
		{
			return this.As<IFollowShooterSkillSkillT>();
		}

		// Token: 0x0602DE1E RID: 187934 RVA: 0x006462AB File Offset: 0x006444AB
		public static IExecClientBattleActionType_UnionUnion FromIFollowShooterSkillSkill(IFollowShooterSkillSkillT _ifollowshooterskillskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IFollowShooterSkillSkill,
				Value = _ifollowshooterskillskill
			};
		}

		// Token: 0x0602DE1F RID: 187935 RVA: 0x006462C0 File Offset: 0x006444C0
		public IClientGroupAiCommunicateT AsIClientGroupAiCommunicate()
		{
			return this.As<IClientGroupAiCommunicateT>();
		}

		// Token: 0x0602DE20 RID: 187936 RVA: 0x006462C8 File Offset: 0x006444C8
		public static IExecClientBattleActionType_UnionUnion FromIClientGroupAiCommunicate(IClientGroupAiCommunicateT _iclientgroupaicommunicate)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IClientGroupAiCommunicate,
				Value = _iclientgroupaicommunicate
			};
		}

		// Token: 0x0602DE21 RID: 187937 RVA: 0x006462DD File Offset: 0x006444DD
		public IChangeAnimalEmotionBubbleT AsIChangeAnimalEmotionBubble()
		{
			return this.As<IChangeAnimalEmotionBubbleT>();
		}

		// Token: 0x0602DE22 RID: 187938 RVA: 0x006462E5 File Offset: 0x006444E5
		public static IExecClientBattleActionType_UnionUnion FromIChangeAnimalEmotionBubble(IChangeAnimalEmotionBubbleT _ichangeanimalemotionbubble)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IChangeAnimalEmotionBubble,
				Value = _ichangeanimalemotionbubble
			};
		}

		// Token: 0x0602DE23 RID: 187939 RVA: 0x006462FA File Offset: 0x006444FA
		public IMonsterNpcInteractT AsIMonsterNpcInteract()
		{
			return this.As<IMonsterNpcInteractT>();
		}

		// Token: 0x0602DE24 RID: 187940 RVA: 0x00646302 File Offset: 0x00644502
		public static IExecClientBattleActionType_UnionUnion FromIMonsterNpcInteract(IMonsterNpcInteractT _imonsternpcinteract)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IMonsterNpcInteract,
				Value = _imonsternpcinteract
			};
		}

		// Token: 0x0602DE25 RID: 187941 RVA: 0x00646317 File Offset: 0x00644517
		public IRoboSoldierSpecialTriggerHookSkillT AsIRoboSoldierSpecialTriggerHookSkill()
		{
			return this.As<IRoboSoldierSpecialTriggerHookSkillT>();
		}

		// Token: 0x0602DE26 RID: 187942 RVA: 0x0064631F File Offset: 0x0064451F
		public static IExecClientBattleActionType_UnionUnion FromIRoboSoldierSpecialTriggerHookSkill(IRoboSoldierSpecialTriggerHookSkillT _irobosoldierspecialtriggerhookskill)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IRoboSoldierSpecialTriggerHookSkill,
				Value = _irobosoldierspecialtriggerhookskill
			};
		}

		// Token: 0x0602DE27 RID: 187943 RVA: 0x00646335 File Offset: 0x00644535
		public IAssistCharacterMoveToPointT AsIAssistCharacterMoveToPoint()
		{
			return this.As<IAssistCharacterMoveToPointT>();
		}

		// Token: 0x0602DE28 RID: 187944 RVA: 0x0064633D File Offset: 0x0064453D
		public static IExecClientBattleActionType_UnionUnion FromIAssistCharacterMoveToPoint(IAssistCharacterMoveToPointT _iassistcharactermovetopoint)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IAssistCharacterMoveToPoint,
				Value = _iassistcharactermovetopoint
			};
		}

		// Token: 0x0602DE29 RID: 187945 RVA: 0x00646353 File Offset: 0x00644553
		public IAssistCharacterStopMoveToPointT AsIAssistCharacterStopMoveToPoint()
		{
			return this.As<IAssistCharacterStopMoveToPointT>();
		}

		// Token: 0x0602DE2A RID: 187946 RVA: 0x0064635B File Offset: 0x0064455B
		public static IExecClientBattleActionType_UnionUnion FromIAssistCharacterStopMoveToPoint(IAssistCharacterStopMoveToPointT _iassistcharacterstopmovetopoint)
		{
			return new IExecClientBattleActionType_UnionUnion
			{
				Type = IExecClientBattleActionType_Union.IAssistCharacterStopMoveToPoint,
				Value = _iassistcharacterstopmovetopoint
			};
		}

		// Token: 0x0602DE2B RID: 187947 RVA: 0x00646374 File Offset: 0x00644574
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
			default:
				return 0;
			}
		}
	}
}
