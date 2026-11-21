using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200251A RID: 9498
	public static class EAvgRoleAnimationTypeExtensions
	{
		// Token: 0x0600CE4F RID: 52815 RVA: 0x001DE850 File Offset: 0x001DCA50
		public static string ToEnumString(this EAvgRoleAnimationType value)
		{
			string result;
			switch (value)
			{
			case EAvgRoleAnimationType.Idle:
				result = "Idle";
				break;
			case EAvgRoleAnimationType.Victory:
				result = "Victory";
				break;
			case EAvgRoleAnimationType.TouchFeedback:
				result = "TouchFeedback";
				break;
			case EAvgRoleAnimationType.Skill:
				result = "Skill";
				break;
			case EAvgRoleAnimationType.HumanToBall:
				result = "HumanToBall";
				break;
			case EAvgRoleAnimationType.BallToHuman:
				result = "BallToHuman";
				break;
			case EAvgRoleAnimationType.AvgPlaySkill:
				result = "AvgPlaySkill";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CE50 RID: 52816 RVA: 0x001DE8C8 File Offset: 0x001DCAC8
		public static EAvgRoleAnimationType FromString(string name)
		{
			EAvgRoleAnimationType result;
			if (!EAvgRoleAnimationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgRoleAnimationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE51 RID: 52817 RVA: 0x001DE8F4 File Offset: 0x001DCAF4
		public static bool TryFromString(string name, out EAvgRoleAnimationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAvgRoleAnimationType.Idle;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "Idle")
					{
						value = EAvgRoleAnimationType.Idle;
						return true;
					}
					break;
				case 5:
					if (name == "Skill")
					{
						value = EAvgRoleAnimationType.Skill;
						return true;
					}
					break;
				case 7:
					if (name == "Victory")
					{
						value = EAvgRoleAnimationType.Victory;
						return true;
					}
					break;
				case 11:
				{
					char c = name[0];
					if (c != 'B')
					{
						if (c == 'H')
						{
							if (name == "HumanToBall")
							{
								value = EAvgRoleAnimationType.HumanToBall;
								return true;
							}
						}
					}
					else if (name == "BallToHuman")
					{
						value = EAvgRoleAnimationType.BallToHuman;
						return true;
					}
					break;
				}
				case 12:
					if (name == "AvgPlaySkill")
					{
						value = EAvgRoleAnimationType.AvgPlaySkill;
						return true;
					}
					break;
				case 13:
					if (name == "TouchFeedback")
					{
						value = EAvgRoleAnimationType.TouchFeedback;
						return true;
					}
					break;
				}
			}
			value = EAvgRoleAnimationType.Idle;
			return false;
		}

		// Token: 0x0600CE52 RID: 52818 RVA: 0x001DE9F7 File Offset: 0x001DCBF7
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Idle",
				"Victory",
				"TouchFeedback",
				"Skill",
				"HumanToBall",
				"BallToHuman",
				"AvgPlaySkill"
			};
		}

		// Token: 0x0600CE53 RID: 52819 RVA: 0x001DEA37 File Offset: 0x001DCC37
		public static EAvgRoleAnimationType[] GetValues()
		{
			return new EAvgRoleAnimationType[]
			{
				EAvgRoleAnimationType.Idle,
				EAvgRoleAnimationType.Victory,
				EAvgRoleAnimationType.TouchFeedback,
				EAvgRoleAnimationType.Skill,
				EAvgRoleAnimationType.HumanToBall,
				EAvgRoleAnimationType.BallToHuman,
				EAvgRoleAnimationType.AvgPlaySkill
			};
		}

		// Token: 0x0600CE54 RID: 52820 RVA: 0x001DEA4A File Offset: 0x001DCC4A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Idle",
				"Victory",
				"TouchFeedback",
				"Skill",
				"HumanToBall",
				"BallToHuman",
				"AvgPlaySkill"
			};
		}
	}
}
