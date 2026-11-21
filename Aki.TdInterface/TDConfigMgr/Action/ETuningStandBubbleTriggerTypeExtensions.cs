using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200272C RID: 10028
	public static class ETuningStandBubbleTriggerTypeExtensions
	{
		// Token: 0x0600D7A0 RID: 55200 RVA: 0x001F7EA8 File Offset: 0x001F60A8
		public static string ToEnumString(this ETuningStandBubbleTriggerType value)
		{
			string result;
			switch (value)
			{
			case ETuningStandBubbleTriggerType.Enter:
				result = "Enter";
				break;
			case ETuningStandBubbleTriggerType.StartLink:
				result = "StartLink";
				break;
			case ETuningStandBubbleTriggerType.InvalidLink:
				result = "InvalidLink";
				break;
			case ETuningStandBubbleTriggerType.LinkUp:
				result = "LinkUp";
				break;
			case ETuningStandBubbleTriggerType.LinkMiss:
				result = "LinkMiss";
				break;
			case ETuningStandBubbleTriggerType.LinkComplete:
				result = "LinkComplete";
				break;
			case ETuningStandBubbleTriggerType.Reset:
				result = "Reset";
				break;
			case ETuningStandBubbleTriggerType.TooLong:
				result = "TooLong";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D7A1 RID: 55201 RVA: 0x001F7F2C File Offset: 0x001F612C
		public static ETuningStandBubbleTriggerType FromString(string name)
		{
			ETuningStandBubbleTriggerType result;
			if (!ETuningStandBubbleTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETuningStandBubbleTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7A2 RID: 55202 RVA: 0x001F7F58 File Offset: 0x001F6158
		public static bool TryFromString(string name, out ETuningStandBubbleTriggerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETuningStandBubbleTriggerType.Enter;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 5:
				{
					char c = name[0];
					if (c != 'E')
					{
						if (c == 'R')
						{
							if (name == "Reset")
							{
								value = ETuningStandBubbleTriggerType.Reset;
								return true;
							}
						}
					}
					else if (name == "Enter")
					{
						value = ETuningStandBubbleTriggerType.Enter;
						return true;
					}
					break;
				}
				case 6:
					if (name == "LinkUp")
					{
						value = ETuningStandBubbleTriggerType.LinkUp;
						return true;
					}
					break;
				case 7:
					if (name == "TooLong")
					{
						value = ETuningStandBubbleTriggerType.TooLong;
						return true;
					}
					break;
				case 8:
					if (name == "LinkMiss")
					{
						value = ETuningStandBubbleTriggerType.LinkMiss;
						return true;
					}
					break;
				case 9:
					if (name == "StartLink")
					{
						value = ETuningStandBubbleTriggerType.StartLink;
						return true;
					}
					break;
				case 11:
					if (name == "InvalidLink")
					{
						value = ETuningStandBubbleTriggerType.InvalidLink;
						return true;
					}
					break;
				case 12:
					if (name == "LinkComplete")
					{
						value = ETuningStandBubbleTriggerType.LinkComplete;
						return true;
					}
					break;
				}
			}
			value = ETuningStandBubbleTriggerType.Enter;
			return false;
		}

		// Token: 0x0600D7A3 RID: 55203 RVA: 0x001F8070 File Offset: 0x001F6270
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enter",
				"StartLink",
				"InvalidLink",
				"LinkUp",
				"LinkMiss",
				"LinkComplete",
				"Reset",
				"TooLong"
			};
		}

		// Token: 0x0600D7A4 RID: 55204 RVA: 0x001F80C3 File Offset: 0x001F62C3
		public static ETuningStandBubbleTriggerType[] GetValues()
		{
			return new ETuningStandBubbleTriggerType[]
			{
				ETuningStandBubbleTriggerType.Enter,
				ETuningStandBubbleTriggerType.StartLink,
				ETuningStandBubbleTriggerType.InvalidLink,
				ETuningStandBubbleTriggerType.LinkUp,
				ETuningStandBubbleTriggerType.LinkMiss,
				ETuningStandBubbleTriggerType.LinkComplete,
				ETuningStandBubbleTriggerType.Reset,
				ETuningStandBubbleTriggerType.TooLong
			};
		}

		// Token: 0x0600D7A5 RID: 55205 RVA: 0x001F80D8 File Offset: 0x001F62D8
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enter",
				"StartLink",
				"InvalidLink",
				"LinkUp",
				"LinkMiss",
				"LinkComplete",
				"Reset",
				"TooLong"
			};
		}
	}
}
