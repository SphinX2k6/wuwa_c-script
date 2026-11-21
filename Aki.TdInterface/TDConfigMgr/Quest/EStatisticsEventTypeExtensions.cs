using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D6 RID: 5078
	public static class EStatisticsEventTypeExtensions
	{
		// Token: 0x0600719D RID: 29085 RVA: 0x0010F4AC File Offset: 0x0010D6AC
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

		// Token: 0x0600719E RID: 29086 RVA: 0x0010F548 File Offset: 0x0010D748
		public static EStatisticsEventType FromString(string name)
		{
			EStatisticsEventType result;
			if (!EStatisticsEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStatisticsEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x0010F574 File Offset: 0x0010D774
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

		// Token: 0x060071A0 RID: 29088 RVA: 0x0010F6D0 File Offset: 0x0010D8D0
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

		// Token: 0x060071A1 RID: 29089 RVA: 0x0010F735 File Offset: 0x0010D935
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

		// Token: 0x060071A2 RID: 29090 RVA: 0x0010F74C File Offset: 0x0010D94C
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
