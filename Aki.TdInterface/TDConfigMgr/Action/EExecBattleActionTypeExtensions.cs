using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002327 RID: 8999
	public static class EExecBattleActionTypeExtensions
	{
		// Token: 0x0600C4AE RID: 50350 RVA: 0x001CB3E0 File Offset: 0x001C95E0
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
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x001CB458 File Offset: 0x001C9658
		public static EExecBattleActionType FromString(string name)
		{
			EExecBattleActionType result;
			if (!EExecBattleActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExecBattleActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x001CB484 File Offset: 0x001C9684
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
				if (length <= 16)
				{
					if (length != 13)
					{
						if (length == 16)
						{
							if (name == "SendBattleEvents")
							{
								value = EExecBattleActionType.SendBattleEvents;
								return true;
							}
						}
					}
					else if (name == "SetBattleTags")
					{
						value = EExecBattleActionType.SetBattleTags;
						return true;
					}
				}
				else
				{
					switch (length)
					{
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
					case 22:
					case 23:
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
					default:
						if (length == 32)
						{
							if (name == "SendBattleEventsForMonsterSummon")
							{
								value = EExecBattleActionType.SendBattleEventsForMonsterSummon;
								return true;
							}
						}
						break;
					}
				}
			}
			value = EExecBattleActionType.SetBattleTags;
			return false;
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x001CB57A File Offset: 0x001C977A
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
				"ExitMonsterMoveWithSpline"
			};
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x001CB5BA File Offset: 0x001C97BA
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
				EExecBattleActionType.ExitMonsterMoveWithSpline
			};
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x001CB5CD File Offset: 0x001C97CD
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
				"ExitMonsterMoveWithSpline"
			};
		}
	}
}
