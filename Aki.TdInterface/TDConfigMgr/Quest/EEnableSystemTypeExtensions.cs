using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200137C RID: 4988
	public static class EEnableSystemTypeExtensions
	{
		// Token: 0x06007008 RID: 28680 RVA: 0x0010AD98 File Offset: 0x00108F98
		public static string ToEnumString(this EEnableSystemType value)
		{
			string result;
			switch (value)
			{
			case EEnableSystemType.GradingSystem:
				result = "GradingSystem";
				break;
			case EEnableSystemType.TrapDefense:
				result = "TrapDefense";
				break;
			case EEnableSystemType.SurvivorsRouge:
				result = "SurvivorsRouge";
				break;
			case EEnableSystemType.GameDifficulty:
				result = "GameDifficulty";
				break;
			case EEnableSystemType.LinkSystem:
				result = "LinkSystem";
				break;
			case EEnableSystemType.MotorRacing:
				result = "MotorRacing";
				break;
			case EEnableSystemType.NightmareSettlement:
				result = "NightmareSettlement";
				break;
			case EEnableSystemType.MotorFight:
				result = "MotorFight";
				break;
			case EEnableSystemType.Kurotato:
				result = "Kurotato";
				break;
			case EEnableSystemType.FlagChallenge:
				result = "FlagChallenge";
				break;
			case EEnableSystemType.Flipper:
				result = "Flipper";
				break;
			case EEnableSystemType.RogueTowerTrial:
				result = "RogueTowerTrial";
				break;
			case EEnableSystemType.KuroSimpleCombatKillMonster:
				result = "KuroSimpleCombatKillMonster";
				break;
			case EEnableSystemType.RoleTower:
				result = "RoleTower";
				break;
			case EEnableSystemType.DarkTide:
				result = "DarkTide";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x0010AE70 File Offset: 0x00109070
		public static EEnableSystemType FromString(string name)
		{
			EEnableSystemType result;
			if (!EEnableSystemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableSystemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x0010AE9C File Offset: 0x0010909C
		public static bool TryFromString(string name, out EEnableSystemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEnableSystemType.GradingSystem;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 7:
					if (name == "Flipper")
					{
						value = EEnableSystemType.Flipper;
						return true;
					}
					break;
				case 8:
				{
					char c = name[0];
					if (c != 'D')
					{
						if (c == 'K')
						{
							if (name == "Kurotato")
							{
								value = EEnableSystemType.Kurotato;
								return true;
							}
						}
					}
					else if (name == "DarkTide")
					{
						value = EEnableSystemType.DarkTide;
						return true;
					}
					break;
				}
				case 9:
					if (name == "RoleTower")
					{
						value = EEnableSystemType.RoleTower;
						return true;
					}
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'L')
					{
						if (c == 'M')
						{
							if (name == "MotorFight")
							{
								value = EEnableSystemType.MotorFight;
								return true;
							}
						}
					}
					else if (name == "LinkSystem")
					{
						value = EEnableSystemType.LinkSystem;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[0];
					if (c != 'M')
					{
						if (c == 'T')
						{
							if (name == "TrapDefense")
							{
								value = EEnableSystemType.TrapDefense;
								return true;
							}
						}
					}
					else if (name == "MotorRacing")
					{
						value = EEnableSystemType.MotorRacing;
						return true;
					}
					break;
				}
				case 12:
				case 16:
				case 17:
				case 18:
					break;
				case 13:
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c == 'G')
						{
							if (name == "GradingSystem")
							{
								value = EEnableSystemType.GradingSystem;
								return true;
							}
						}
					}
					else if (name == "FlagChallenge")
					{
						value = EEnableSystemType.FlagChallenge;
						return true;
					}
					break;
				}
				case 14:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c == 'S')
						{
							if (name == "SurvivorsRouge")
							{
								value = EEnableSystemType.SurvivorsRouge;
								return true;
							}
						}
					}
					else if (name == "GameDifficulty")
					{
						value = EEnableSystemType.GameDifficulty;
						return true;
					}
					break;
				}
				case 15:
					if (name == "RogueTowerTrial")
					{
						value = EEnableSystemType.RogueTowerTrial;
						return true;
					}
					break;
				case 19:
					if (name == "NightmareSettlement")
					{
						value = EEnableSystemType.NightmareSettlement;
						return true;
					}
					break;
				default:
					if (length == 27)
					{
						if (name == "KuroSimpleCombatKillMonster")
						{
							value = EEnableSystemType.KuroSimpleCombatKillMonster;
							return true;
						}
					}
					break;
				}
			}
			value = EEnableSystemType.GradingSystem;
			return false;
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x0010B110 File Offset: 0x00109310
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GradingSystem",
				"TrapDefense",
				"SurvivorsRouge",
				"GameDifficulty",
				"LinkSystem",
				"MotorRacing",
				"NightmareSettlement",
				"MotorFight",
				"Kurotato",
				"FlagChallenge",
				"Flipper",
				"RogueTowerTrial",
				"KuroSimpleCombatKillMonster",
				"RoleTower",
				"DarkTide"
			};
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x0010B1A2 File Offset: 0x001093A2
		public static EEnableSystemType[] GetValues()
		{
			return new EEnableSystemType[]
			{
				EEnableSystemType.GradingSystem,
				EEnableSystemType.TrapDefense,
				EEnableSystemType.SurvivorsRouge,
				EEnableSystemType.GameDifficulty,
				EEnableSystemType.LinkSystem,
				EEnableSystemType.MotorRacing,
				EEnableSystemType.NightmareSettlement,
				EEnableSystemType.MotorFight,
				EEnableSystemType.Kurotato,
				EEnableSystemType.FlagChallenge,
				EEnableSystemType.Flipper,
				EEnableSystemType.RogueTowerTrial,
				EEnableSystemType.KuroSimpleCombatKillMonster,
				EEnableSystemType.RoleTower,
				EEnableSystemType.DarkTide
			};
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x0010B1B8 File Offset: 0x001093B8
		public static string[] GetNames()
		{
			return new string[]
			{
				"GradingSystem",
				"TrapDefense",
				"SurvivorsRouge",
				"GameDifficulty",
				"LinkSystem",
				"MotorRacing",
				"NightmareSettlement",
				"MotorFight",
				"Kurotato",
				"FlagChallenge",
				"Flipper",
				"RogueTowerTrial",
				"KuroSimpleCombatKillMonster",
				"RoleTower",
				"DarkTide"
			};
		}
	}
}
