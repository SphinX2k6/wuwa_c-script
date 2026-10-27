using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AB RID: 8875
	public static class EAvgRoleAnimationTypeExtensions
	{
		// Token: 0x0600C280 RID: 49792 RVA: 0x001C6A48 File Offset: 0x001C4C48
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

		// Token: 0x0600C281 RID: 49793 RVA: 0x001C6AC0 File Offset: 0x001C4CC0
		public static EAvgRoleAnimationType FromString(string name)
		{
			EAvgRoleAnimationType result;
			if (!EAvgRoleAnimationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgRoleAnimationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C282 RID: 49794 RVA: 0x001C6AEC File Offset: 0x001C4CEC
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

		// Token: 0x0600C283 RID: 49795 RVA: 0x001C6BEF File Offset: 0x001C4DEF
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

		// Token: 0x0600C284 RID: 49796 RVA: 0x001C6C2F File Offset: 0x001C4E2F
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

		// Token: 0x0600C285 RID: 49797 RVA: 0x001C6C42 File Offset: 0x001C4E42
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
