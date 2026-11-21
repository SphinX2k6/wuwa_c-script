using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x0200544F RID: 21583
	public static class EMatchThreeTextIdExtensions
	{
		// Token: 0x06035904 RID: 219396 RVA: 0x00EF5F60 File Offset: 0x00EF4160
		public static string ToEnumString(this EMatchThreeTextId value)
		{
			string result;
			switch (value)
			{
			case EMatchThreeTextId.RemainingTurns:
				result = "RemainingTurns";
				break;
			case EMatchThreeTextId.RemainingTurnsWarning:
				result = "MatchThreeRemainingTurnsWarning";
				break;
			case EMatchThreeTextId.FinalScore:
				result = "MatchThreeFinalScore";
				break;
			case EMatchThreeTextId.GameplayScoreNormal:
				result = "MS_Score_Normal";
				break;
			case EMatchThreeTextId.GameplayScoreEndless:
				result = "MS_Score_Endless";
				break;
			case EMatchThreeTextId.TargetScore:
				result = "MatchThreeTarget_Score";
				break;
			case EMatchThreeTextId.TargetCharger:
				result = "MatchThreeTarget_Charger";
				break;
			case EMatchThreeTextId.TargetHourglass:
				result = "MatchThreeTarget_Hourglass";
				break;
			case EMatchThreeTextId.TargetNone:
				result = "MatchThreeTarget_None";
				break;
			case EMatchThreeTextId.TurnDelta:
				result = "MatchThreeTurnDelta";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06035905 RID: 219397 RVA: 0x00EF5FFC File Offset: 0x00EF41FC
		public static EMatchThreeTextId FromString(string name)
		{
			EMatchThreeTextId result;
			if (!EMatchThreeTextIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeTextId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06035906 RID: 219398 RVA: 0x00EF6028 File Offset: 0x00EF4228
		public static bool TryFromString(string name, out EMatchThreeTextId value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMatchThreeTextId.RemainingTurns;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 14:
					if (name == "RemainingTurns")
					{
						value = EMatchThreeTextId.RemainingTurns;
						return true;
					}
					break;
				case 15:
					if (name == "MS_Score_Normal")
					{
						value = EMatchThreeTextId.GameplayScoreNormal;
						return true;
					}
					break;
				case 16:
					if (name == "MS_Score_Endless")
					{
						value = EMatchThreeTextId.GameplayScoreEndless;
						return true;
					}
					break;
				case 19:
					if (name == "MatchThreeTurnDelta")
					{
						value = EMatchThreeTextId.TurnDelta;
						return true;
					}
					break;
				case 20:
					if (name == "MatchThreeFinalScore")
					{
						value = EMatchThreeTextId.FinalScore;
						return true;
					}
					break;
				case 21:
					if (name == "MatchThreeTarget_None")
					{
						value = EMatchThreeTextId.TargetNone;
						return true;
					}
					break;
				case 22:
					if (name == "MatchThreeTarget_Score")
					{
						value = EMatchThreeTextId.TargetScore;
						return true;
					}
					break;
				case 24:
					if (name == "MatchThreeTarget_Charger")
					{
						value = EMatchThreeTextId.TargetCharger;
						return true;
					}
					break;
				case 26:
					if (name == "MatchThreeTarget_Hourglass")
					{
						value = EMatchThreeTextId.TargetHourglass;
						return true;
					}
					break;
				case 31:
					if (name == "MatchThreeRemainingTurnsWarning")
					{
						value = EMatchThreeTextId.RemainingTurnsWarning;
						return true;
					}
					break;
				}
			}
			value = EMatchThreeTextId.RemainingTurns;
			return false;
		}

		// Token: 0x06035907 RID: 219399 RVA: 0x00EF6184 File Offset: 0x00EF4384
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RemainingTurns",
				"MatchThreeRemainingTurnsWarning",
				"MatchThreeFinalScore",
				"MS_Score_Normal",
				"MS_Score_Endless",
				"MatchThreeTarget_Score",
				"MatchThreeTarget_Charger",
				"MatchThreeTarget_Hourglass",
				"MatchThreeTarget_None",
				"MatchThreeTurnDelta"
			};
		}

		// Token: 0x06035908 RID: 219400 RVA: 0x00EF61E9 File Offset: 0x00EF43E9
		public static EMatchThreeTextId[] GetValues()
		{
			return new EMatchThreeTextId[]
			{
				EMatchThreeTextId.RemainingTurns,
				EMatchThreeTextId.RemainingTurnsWarning,
				EMatchThreeTextId.FinalScore,
				EMatchThreeTextId.GameplayScoreNormal,
				EMatchThreeTextId.GameplayScoreEndless,
				EMatchThreeTextId.TargetScore,
				EMatchThreeTextId.TargetCharger,
				EMatchThreeTextId.TargetHourglass,
				EMatchThreeTextId.TargetNone,
				EMatchThreeTextId.TurnDelta
			};
		}

		// Token: 0x06035909 RID: 219401 RVA: 0x00EF6200 File Offset: 0x00EF4400
		public static string[] GetNames()
		{
			return new string[]
			{
				"RemainingTurns",
				"RemainingTurnsWarning",
				"FinalScore",
				"GameplayScoreNormal",
				"GameplayScoreEndless",
				"TargetScore",
				"TargetCharger",
				"TargetHourglass",
				"TargetNone",
				"TurnDelta"
			};
		}
	}
}
