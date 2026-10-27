using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001294 RID: 4756
	public static class EStatisticsEventTypeExtensions
	{
		// Token: 0x06006B41 RID: 27457 RVA: 0x001016D4 File Offset: 0x000FF8D4
		public static string ToEnumString(this EStatisticsEventType value)
		{
			string result;
			switch (value)
			{
			case EStatisticsEventType.Collect:
				result = "Collect";
				break;
			case EStatisticsEventType.UseSkill:
				result = "UseSkill";
				break;
			case EStatisticsEventType.UseSkillNew:
				result = "UseSkillNew";
				break;
			case EStatisticsEventType.PlayerTriggerMotion:
				result = "PlayerTriggerMotion";
				break;
			case EStatisticsEventType.Timer:
				result = "Timer";
				break;
			case EStatisticsEventType.MonsterPoint:
				result = "MonsterPoint";
				break;
			case EStatisticsEventType.MonsterRemainingHealth:
				result = "MonsterRemainingHealth";
				break;
			case EStatisticsEventType.MonsterHealthScore:
				result = "MonsterHealthScore";
				break;
			case EStatisticsEventType.PlayerHit:
				result = "PlayerHit";
				break;
			case EStatisticsEventType.MechaTrackScore:
				result = "MechaTrackScore";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x00101770 File Offset: 0x000FF970
		public static EStatisticsEventType FromString(string name)
		{
			EStatisticsEventType result;
			if (!EStatisticsEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStatisticsEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x0010179C File Offset: 0x000FF99C
		public static bool TryFromString(string name, out EStatisticsEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EStatisticsEventType.Collect;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 5:
					if (name == "Timer")
					{
						value = EStatisticsEventType.Timer;
						return true;
					}
					break;
				case 7:
					if (name == "Collect")
					{
						value = EStatisticsEventType.Collect;
						return true;
					}
					break;
				case 8:
					if (name == "UseSkill")
					{
						value = EStatisticsEventType.UseSkill;
						return true;
					}
					break;
				case 9:
					if (name == "PlayerHit")
					{
						value = EStatisticsEventType.PlayerHit;
						return true;
					}
					break;
				case 11:
					if (name == "UseSkillNew")
					{
						value = EStatisticsEventType.UseSkillNew;
						return true;
					}
					break;
				case 12:
					if (name == "MonsterPoint")
					{
						value = EStatisticsEventType.MonsterPoint;
						return true;
					}
					break;
				case 15:
					if (name == "MechaTrackScore")
					{
						value = EStatisticsEventType.MechaTrackScore;
						return true;
					}
					break;
				case 18:
					if (name == "MonsterHealthScore")
					{
						value = EStatisticsEventType.MonsterHealthScore;
						return true;
					}
					break;
				case 19:
					if (name == "PlayerTriggerMotion")
					{
						value = EStatisticsEventType.PlayerTriggerMotion;
						return true;
					}
					break;
				case 22:
					if (name == "MonsterRemainingHealth")
					{
						value = EStatisticsEventType.MonsterRemainingHealth;
						return true;
					}
					break;
				}
			}
			value = EStatisticsEventType.Collect;
			return false;
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x001018F8 File Offset: 0x000FFAF8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Collect",
				"UseSkill",
				"UseSkillNew",
				"PlayerTriggerMotion",
				"Timer",
				"MonsterPoint",
				"MonsterRemainingHealth",
				"MonsterHealthScore",
				"PlayerHit",
				"MechaTrackScore"
			};
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x0010195D File Offset: 0x000FFB5D
		public static EStatisticsEventType[] GetValues()
		{
			return new EStatisticsEventType[]
			{
				EStatisticsEventType.Collect,
				EStatisticsEventType.UseSkill,
				EStatisticsEventType.UseSkillNew,
				EStatisticsEventType.PlayerTriggerMotion,
				EStatisticsEventType.Timer,
				EStatisticsEventType.MonsterPoint,
				EStatisticsEventType.MonsterRemainingHealth,
				EStatisticsEventType.MonsterHealthScore,
				EStatisticsEventType.PlayerHit,
				EStatisticsEventType.MechaTrackScore
			};
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x00101974 File Offset: 0x000FFB74
		public static string[] GetNames()
		{
			return new string[]
			{
				"Collect",
				"UseSkill",
				"UseSkillNew",
				"PlayerTriggerMotion",
				"Timer",
				"MonsterPoint",
				"MonsterRemainingHealth",
				"MonsterHealthScore",
				"PlayerHit",
				"MechaTrackScore"
			};
		}
	}
}
