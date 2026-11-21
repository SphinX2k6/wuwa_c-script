using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200259A RID: 9626
	public static class EExecClientBattleActionTypeExtensions
	{
		// Token: 0x0600D08F RID: 53391 RVA: 0x001E36C4 File Offset: 0x001E18C4
		public static string ToEnumString(this EExecClientBattleActionType value)
		{
			string result;
			switch (value)
			{
			case EExecClientBattleActionType.SendTagEventToControlCharacter:
				result = "SendTagEventToControlCharacter";
				break;
			case EExecClientBattleActionType.TriggerHookPointSkill:
				result = "TriggerHookPointSkill";
				break;
			case EExecClientBattleActionType.TriggerMotorSkill:
				result = "TriggerMotorSkill";
				break;
			case EExecClientBattleActionType.FollowShooterSkill:
				result = "FollowShooterSkill";
				break;
			case EExecClientBattleActionType.GroupAiCommunicate:
				result = "GroupAiCommunicate";
				break;
			case EExecClientBattleActionType.ChangeAnimalEmotionBubble:
				result = "ChangeAnimalEmotionBubble";
				break;
			case EExecClientBattleActionType.MonsterNpcInteract:
				result = "MonsterNpcInteract";
				break;
			case EExecClientBattleActionType.RoboSoldierSpecialHookSkill:
				result = "RoboSoldierSpecialHookSkill";
				break;
			case EExecClientBattleActionType.AssistCharacterMoveToPoint:
				result = "AssistCharacterMoveToPoint";
				break;
			case EExecClientBattleActionType.AssistCharacterStopMoveToPoint:
				result = "AssistCharacterStopMoveToPoint";
				break;
			case EExecClientBattleActionType.MechExecute:
				result = "MechExecute";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D090 RID: 53392 RVA: 0x001E376C File Offset: 0x001E196C
		public static EExecClientBattleActionType FromString(string name)
		{
			EExecClientBattleActionType result;
			if (!EExecClientBattleActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExecClientBattleActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D091 RID: 53393 RVA: 0x001E3798 File Offset: 0x001E1998
		public static bool TryFromString(string name, out EExecClientBattleActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExecClientBattleActionType.SendTagEventToControlCharacter;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length != 11)
				{
					switch (length)
					{
					case 17:
						if (name == "TriggerMotorSkill")
						{
							value = EExecClientBattleActionType.TriggerMotorSkill;
							return true;
						}
						break;
					case 18:
					{
						char c = name[0];
						if (c != 'F')
						{
							if (c != 'G')
							{
								if (c == 'M')
								{
									if (name == "MonsterNpcInteract")
									{
										value = EExecClientBattleActionType.MonsterNpcInteract;
										return true;
									}
								}
							}
							else if (name == "GroupAiCommunicate")
							{
								value = EExecClientBattleActionType.GroupAiCommunicate;
								return true;
							}
						}
						else if (name == "FollowShooterSkill")
						{
							value = EExecClientBattleActionType.FollowShooterSkill;
							return true;
						}
						break;
					}
					case 19:
					case 20:
					case 22:
					case 23:
					case 24:
						break;
					case 21:
						if (name == "TriggerHookPointSkill")
						{
							value = EExecClientBattleActionType.TriggerHookPointSkill;
							return true;
						}
						break;
					case 25:
						if (name == "ChangeAnimalEmotionBubble")
						{
							value = EExecClientBattleActionType.ChangeAnimalEmotionBubble;
							return true;
						}
						break;
					case 26:
						if (name == "AssistCharacterMoveToPoint")
						{
							value = EExecClientBattleActionType.AssistCharacterMoveToPoint;
							return true;
						}
						break;
					case 27:
						if (name == "RoboSoldierSpecialHookSkill")
						{
							value = EExecClientBattleActionType.RoboSoldierSpecialHookSkill;
							return true;
						}
						break;
					default:
						if (length == 30)
						{
							char c = name[0];
							if (c != 'A')
							{
								if (c == 'S')
								{
									if (name == "SendTagEventToControlCharacter")
									{
										value = EExecClientBattleActionType.SendTagEventToControlCharacter;
										return true;
									}
								}
							}
							else if (name == "AssistCharacterStopMoveToPoint")
							{
								value = EExecClientBattleActionType.AssistCharacterStopMoveToPoint;
								return true;
							}
						}
						break;
					}
				}
				else if (name == "MechExecute")
				{
					value = EExecClientBattleActionType.MechExecute;
					return true;
				}
			}
			value = EExecClientBattleActionType.SendTagEventToControlCharacter;
			return false;
		}

		// Token: 0x0600D092 RID: 53394 RVA: 0x001E3934 File Offset: 0x001E1B34
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SendTagEventToControlCharacter",
				"TriggerHookPointSkill",
				"TriggerMotorSkill",
				"FollowShooterSkill",
				"GroupAiCommunicate",
				"ChangeAnimalEmotionBubble",
				"MonsterNpcInteract",
				"RoboSoldierSpecialHookSkill",
				"AssistCharacterMoveToPoint",
				"AssistCharacterStopMoveToPoint",
				"MechExecute"
			};
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x001E39A2 File Offset: 0x001E1BA2
		public static EExecClientBattleActionType[] GetValues()
		{
			return new EExecClientBattleActionType[]
			{
				EExecClientBattleActionType.SendTagEventToControlCharacter,
				EExecClientBattleActionType.TriggerHookPointSkill,
				EExecClientBattleActionType.TriggerMotorSkill,
				EExecClientBattleActionType.FollowShooterSkill,
				EExecClientBattleActionType.GroupAiCommunicate,
				EExecClientBattleActionType.ChangeAnimalEmotionBubble,
				EExecClientBattleActionType.MonsterNpcInteract,
				EExecClientBattleActionType.RoboSoldierSpecialHookSkill,
				EExecClientBattleActionType.AssistCharacterMoveToPoint,
				EExecClientBattleActionType.AssistCharacterStopMoveToPoint,
				EExecClientBattleActionType.MechExecute
			};
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x001E39B8 File Offset: 0x001E1BB8
		public static string[] GetNames()
		{
			return new string[]
			{
				"SendTagEventToControlCharacter",
				"TriggerHookPointSkill",
				"TriggerMotorSkill",
				"FollowShooterSkill",
				"GroupAiCommunicate",
				"ChangeAnimalEmotionBubble",
				"MonsterNpcInteract",
				"RoboSoldierSpecialHookSkill",
				"AssistCharacterMoveToPoint",
				"AssistCharacterStopMoveToPoint",
				"MechExecute"
			};
		}
	}
}
