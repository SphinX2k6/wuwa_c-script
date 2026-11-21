using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002598 RID: 9624
	public static class EExecBattleActionTypeExtensions
	{
		// Token: 0x0600D086 RID: 53382 RVA: 0x001E33BC File Offset: 0x001E15BC
		public static string ToEnumString(this EExecBattleActionType value)
		{
			string result;
			switch (value)
			{
			case EExecBattleActionType.SetBattleTags:
				result = "SetBattleTags";
				break;
			case EExecBattleActionType.SendBattleEvents:
				result = "SendBattleEvents";
				break;
			case EExecBattleActionType.SendBattleEventsForMonsterSummon:
				result = "SendBattleEventsForMonsterSummon";
				break;
			case EExecBattleActionType.SetMonsterMoveTarget:
				result = "SetMonsterMoveTarget";
				break;
			case EExecBattleActionType.ExitMonsterMoveTarget:
				result = "ExitMonsterMoveTarget";
				break;
			case EExecBattleActionType.SetMonsterMoveWithSpline:
				result = "SetMonsterMoveWithSpline";
				break;
			case EExecBattleActionType.ExitMonsterMoveWithSpline:
				result = "ExitMonsterMoveWithSpline";
				break;
			case EExecBattleActionType.AssistCharacterMoveToPoint:
				result = "AssistCharacterMoveToPoint";
				break;
			case EExecBattleActionType.AssistCharacterStopMoveToPoint:
				result = "AssistCharacterStopMoveToPoint";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D087 RID: 53383 RVA: 0x001E344C File Offset: 0x001E164C
		public static EExecBattleActionType FromString(string name)
		{
			EExecBattleActionType result;
			if (!EExecBattleActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExecBattleActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D088 RID: 53384 RVA: 0x001E3478 File Offset: 0x001E1678
		public static bool TryFromString(string name, out EExecBattleActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExecBattleActionType.SetBattleTags;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length <= 26)
				{
					if (length != 13)
					{
						switch (length)
						{
						case 16:
							if (name == "SendBattleEvents")
							{
								value = EExecBattleActionType.SendBattleEvents;
								return true;
							}
							break;
						case 20:
							if (name == "SetMonsterMoveTarget")
							{
								value = EExecBattleActionType.SetMonsterMoveTarget;
								return true;
							}
							break;
						case 21:
							if (name == "ExitMonsterMoveTarget")
							{
								value = EExecBattleActionType.ExitMonsterMoveTarget;
								return true;
							}
							break;
						case 24:
							if (name == "SetMonsterMoveWithSpline")
							{
								value = EExecBattleActionType.SetMonsterMoveWithSpline;
								return true;
							}
							break;
						case 25:
							if (name == "ExitMonsterMoveWithSpline")
							{
								value = EExecBattleActionType.ExitMonsterMoveWithSpline;
								return true;
							}
							break;
						case 26:
							if (name == "AssistCharacterMoveToPoint")
							{
								value = EExecBattleActionType.AssistCharacterMoveToPoint;
								return true;
							}
							break;
						}
					}
					else if (name == "SetBattleTags")
					{
						value = EExecBattleActionType.SetBattleTags;
						return true;
					}
				}
				else if (length != 30)
				{
					if (length == 32)
					{
						if (name == "SendBattleEventsForMonsterSummon")
						{
							value = EExecBattleActionType.SendBattleEventsForMonsterSummon;
							return true;
						}
					}
				}
				else if (name == "AssistCharacterStopMoveToPoint")
				{
					value = EExecBattleActionType.AssistCharacterStopMoveToPoint;
					return true;
				}
			}
			value = EExecBattleActionType.SetBattleTags;
			return false;
		}

		// Token: 0x0600D089 RID: 53385 RVA: 0x001E35BC File Offset: 0x001E17BC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SetBattleTags",
				"SendBattleEvents",
				"SendBattleEventsForMonsterSummon",
				"SetMonsterMoveTarget",
				"ExitMonsterMoveTarget",
				"SetMonsterMoveWithSpline",
				"ExitMonsterMoveWithSpline",
				"AssistCharacterMoveToPoint",
				"AssistCharacterStopMoveToPoint"
			};
		}

		// Token: 0x0600D08A RID: 53386 RVA: 0x001E3618 File Offset: 0x001E1818
		public static EExecBattleActionType[] GetValues()
		{
			return new EExecBattleActionType[]
			{
				EExecBattleActionType.SetBattleTags,
				EExecBattleActionType.SendBattleEvents,
				EExecBattleActionType.SendBattleEventsForMonsterSummon,
				EExecBattleActionType.SetMonsterMoveTarget,
				EExecBattleActionType.ExitMonsterMoveTarget,
				EExecBattleActionType.SetMonsterMoveWithSpline,
				EExecBattleActionType.ExitMonsterMoveWithSpline,
				EExecBattleActionType.AssistCharacterMoveToPoint,
				EExecBattleActionType.AssistCharacterStopMoveToPoint
			};
		}

		// Token: 0x0600D08B RID: 53387 RVA: 0x001E362C File Offset: 0x001E182C
		public static string[] GetNames()
		{
			return new string[]
			{
				"SetBattleTags",
				"SendBattleEvents",
				"SendBattleEventsForMonsterSummon",
				"SetMonsterMoveTarget",
				"ExitMonsterMoveTarget",
				"SetMonsterMoveWithSpline",
				"ExitMonsterMoveWithSpline",
				"AssistCharacterMoveToPoint",
				"AssistCharacterStopMoveToPoint"
			};
		}
	}
}
