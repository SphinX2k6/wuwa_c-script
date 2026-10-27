using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002489 RID: 9353
	public static class ETuningStandBubbleTriggerTypeExtensions
	{
		// Token: 0x0600CAE7 RID: 51943 RVA: 0x001DDCE0 File Offset: 0x001DBEE0
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

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x001DDD64 File Offset: 0x001DBF64
		public static ETuningStandBubbleTriggerType FromString(string name)
		{
			ETuningStandBubbleTriggerType result;
			if (!ETuningStandBubbleTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETuningStandBubbleTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x001DDD90 File Offset: 0x001DBF90
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

		// Token: 0x0600CAEA RID: 51946 RVA: 0x001DDEA8 File Offset: 0x001DC0A8
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

		// Token: 0x0600CAEB RID: 51947 RVA: 0x001DDEFB File Offset: 0x001DC0FB
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

		// Token: 0x0600CAEC RID: 51948 RVA: 0x001DDF10 File Offset: 0x001DC110
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
