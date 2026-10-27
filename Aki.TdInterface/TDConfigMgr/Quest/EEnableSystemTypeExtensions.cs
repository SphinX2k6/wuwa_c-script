using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123C RID: 4668
	public static class EEnableSystemTypeExtensions
	{
		// Token: 0x060069B5 RID: 27061 RVA: 0x000FD1CC File Offset: 0x000FB3CC
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
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x000FD298 File Offset: 0x000FB498
		public static EEnableSystemType FromString(string name)
		{
			EEnableSystemType result;
			if (!EEnableSystemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableSystemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x000FD2C4 File Offset: 0x000FB4C4
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
					if (name == "Kurotato")
					{
						value = EEnableSystemType.Kurotato;
						return true;
					}
					break;
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

		// Token: 0x060069B8 RID: 27064 RVA: 0x000FD4F4 File Offset: 0x000FB6F4
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
				"RoleTower"
			};
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x000FD57D File Offset: 0x000FB77D
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
				EEnableSystemType.RoleTower
			};
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x000FD594 File Offset: 0x000FB794
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
				"RoleTower"
			};
		}
	}
}
