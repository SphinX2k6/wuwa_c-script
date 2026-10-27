using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002329 RID: 9001
	public static class EExecClientBattleActionTypeExtensions
	{
		// Token: 0x0600C4B7 RID: 50359 RVA: 0x001CB64C File Offset: 0x001C984C
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
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x001CB6E8 File Offset: 0x001C98E8
		public static EExecClientBattleActionType FromString(string name)
		{
			EExecClientBattleActionType result;
			if (!EExecClientBattleActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExecClientBattleActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x001CB714 File Offset: 0x001C9914
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
			value = EExecClientBattleActionType.SendTagEventToControlCharacter;
			return false;
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x001CB88C File Offset: 0x001C9A8C
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
				"AssistCharacterStopMoveToPoint"
			};
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x001CB8F1 File Offset: 0x001C9AF1
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
				EExecClientBattleActionType.AssistCharacterStopMoveToPoint
			};
		}

		// Token: 0x0600C4BC RID: 50364 RVA: 0x001CB908 File Offset: 0x001C9B08
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
				"AssistCharacterStopMoveToPoint"
			};
		}
	}
}
