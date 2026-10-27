using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127E RID: 4734
	public static class ERogueTowerTrialSystemVarTypeExtensions
	{
		// Token: 0x06006ADE RID: 27358 RVA: 0x001003E8 File Offset: 0x000FE5E8
		public static string ToEnumString(this ERogueTowerTrialSystemVarType value)
		{
			string result;
			switch (value)
			{
			case ERogueTowerTrialSystemVarType.KillBoss1:
				result = "KillBoss1";
				break;
			case ERogueTowerTrialSystemVarType.KillBoss2:
				result = "KillBoss2";
				break;
			case ERogueTowerTrialSystemVarType.KillBoss3:
				result = "KillBoss3";
				break;
			case ERogueTowerTrialSystemVarType.KillBoss4:
				result = "KillBoss4";
				break;
			case ERogueTowerTrialSystemVarType.UnlockBoss5:
				result = "UnlockBoss5";
				break;
			case ERogueTowerTrialSystemVarType.LevelPhase:
				result = "LevelPhase";
				break;
			case ERogueTowerTrialSystemVarType.TotalProgress:
				result = "TotalProgress";
				break;
			case ERogueTowerTrialSystemVarType.CurProgress:
				result = "CurProgress";
				break;
			case ERogueTowerTrialSystemVarType.CurChosenBoss:
				result = "CurChosenBoss";
				break;
			case ERogueTowerTrialSystemVarType.IsPlayerDead:
				result = "IsPlayerDead";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x00100484 File Offset: 0x000FE684
		public static ERogueTowerTrialSystemVarType FromString(string name)
		{
			ERogueTowerTrialSystemVarType result;
			if (!ERogueTowerTrialSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERogueTowerTrialSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x001004B0 File Offset: 0x000FE6B0
		public static bool TryFromString(string name, out ERogueTowerTrialSystemVarType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERogueTowerTrialSystemVarType.KillBoss1;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 9:
					switch (name[8])
					{
					case '1':
						if (name == "KillBoss1")
						{
							value = ERogueTowerTrialSystemVarType.KillBoss1;
							return true;
						}
						break;
					case '2':
						if (name == "KillBoss2")
						{
							value = ERogueTowerTrialSystemVarType.KillBoss2;
							return true;
						}
						break;
					case '3':
						if (name == "KillBoss3")
						{
							value = ERogueTowerTrialSystemVarType.KillBoss3;
							return true;
						}
						break;
					case '4':
						if (name == "KillBoss4")
						{
							value = ERogueTowerTrialSystemVarType.KillBoss4;
							return true;
						}
						break;
					}
					break;
				case 10:
					if (name == "LevelPhase")
					{
						value = ERogueTowerTrialSystemVarType.LevelPhase;
						return true;
					}
					break;
				case 11:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'U')
						{
							if (name == "UnlockBoss5")
							{
								value = ERogueTowerTrialSystemVarType.UnlockBoss5;
								return true;
							}
						}
					}
					else if (name == "CurProgress")
					{
						value = ERogueTowerTrialSystemVarType.CurProgress;
						return true;
					}
					break;
				}
				case 12:
					if (name == "IsPlayerDead")
					{
						value = ERogueTowerTrialSystemVarType.IsPlayerDead;
						return true;
					}
					break;
				case 13:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'T')
						{
							if (name == "TotalProgress")
							{
								value = ERogueTowerTrialSystemVarType.TotalProgress;
								return true;
							}
						}
					}
					else if (name == "CurChosenBoss")
					{
						value = ERogueTowerTrialSystemVarType.CurChosenBoss;
						return true;
					}
					break;
				}
				}
			}
			value = ERogueTowerTrialSystemVarType.KillBoss1;
			return false;
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x00100638 File Offset: 0x000FE838
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"KillBoss1",
				"KillBoss2",
				"KillBoss3",
				"KillBoss4",
				"UnlockBoss5",
				"LevelPhase",
				"TotalProgress",
				"CurProgress",
				"CurChosenBoss",
				"IsPlayerDead"
			};
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x0010069D File Offset: 0x000FE89D
		public static ERogueTowerTrialSystemVarType[] GetValues()
		{
			return new ERogueTowerTrialSystemVarType[]
			{
				ERogueTowerTrialSystemVarType.KillBoss1,
				ERogueTowerTrialSystemVarType.KillBoss2,
				ERogueTowerTrialSystemVarType.KillBoss3,
				ERogueTowerTrialSystemVarType.KillBoss4,
				ERogueTowerTrialSystemVarType.UnlockBoss5,
				ERogueTowerTrialSystemVarType.LevelPhase,
				ERogueTowerTrialSystemVarType.TotalProgress,
				ERogueTowerTrialSystemVarType.CurProgress,
				ERogueTowerTrialSystemVarType.CurChosenBoss,
				ERogueTowerTrialSystemVarType.IsPlayerDead
			};
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x001006B4 File Offset: 0x000FE8B4
		public static string[] GetNames()
		{
			return new string[]
			{
				"KillBoss1",
				"KillBoss2",
				"KillBoss3",
				"KillBoss4",
				"UnlockBoss5",
				"LevelPhase",
				"TotalProgress",
				"CurProgress",
				"CurChosenBoss",
				"IsPlayerDead"
			};
		}
	}
}
