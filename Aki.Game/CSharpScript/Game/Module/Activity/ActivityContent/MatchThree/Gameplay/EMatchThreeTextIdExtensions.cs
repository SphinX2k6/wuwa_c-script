using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064D1 RID: 25809
	public static class EMatchThreeTextIdExtensions
	{
		// Token: 0x06040C40 RID: 265280 RVA: 0x00FAEF18 File Offset: 0x00FAD118
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

		// Token: 0x06040C41 RID: 265281 RVA: 0x00FAEFB4 File Offset: 0x00FAD1B4
		public static EMatchThreeTextId FromString(string name)
		{
			EMatchThreeTextId result;
			if (!EMatchThreeTextIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeTextId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06040C42 RID: 265282 RVA: 0x00FAEFE0 File Offset: 0x00FAD1E0
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

		// Token: 0x06040C43 RID: 265283 RVA: 0x00FAF13C File Offset: 0x00FAD33C
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

		// Token: 0x06040C44 RID: 265284 RVA: 0x00FAF1A1 File Offset: 0x00FAD3A1
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

		// Token: 0x06040C45 RID: 265285 RVA: 0x00FAF1B8 File Offset: 0x00FAD3B8
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
