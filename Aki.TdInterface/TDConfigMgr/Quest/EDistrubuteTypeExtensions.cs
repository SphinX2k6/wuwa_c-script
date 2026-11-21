using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001378 RID: 4984
	public static class EDistrubuteTypeExtensions
	{
		// Token: 0x06006FF6 RID: 28662 RVA: 0x0010A9A8 File Offset: 0x00108BA8
		public static string ToEnumString(this EDistrubuteType value)
		{
			string result;
			switch (value)
			{
			case EDistrubuteType.Interact:
				result = "Interact";
				break;
			case EDistrubuteType.System:
				result = "System";
				break;
			case EDistrubuteType.UseItem:
				result = "UseItem";
				break;
			case EDistrubuteType.InformationViewCheck:
				result = "InformationViewCheck";
				break;
			case EDistrubuteType.Daily:
				result = "Daily";
				break;
			case EDistrubuteType.Passive:
				result = "Passive";
				break;
			case EDistrubuteType.Activity:
				result = "Activity";
				break;
			case EDistrubuteType.PhoneMessage:
				result = "PhoneMessage";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x0010AA2C File Offset: 0x00108C2C
		public static EDistrubuteType FromString(string name)
		{
			EDistrubuteType result;
			if (!EDistrubuteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDistrubuteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x0010AA58 File Offset: 0x00108C58
		public static bool TryFromString(string name, out EDistrubuteType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDistrubuteType.Interact;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 5:
					if (name == "Daily")
					{
						value = EDistrubuteType.Daily;
						return true;
					}
					break;
				case 6:
					if (name == "System")
					{
						value = EDistrubuteType.System;
						return true;
					}
					break;
				case 7:
				{
					char c = name[0];
					if (c != 'P')
					{
						if (c == 'U')
						{
							if (name == "UseItem")
							{
								value = EDistrubuteType.UseItem;
								return true;
							}
						}
					}
					else if (name == "Passive")
					{
						value = EDistrubuteType.Passive;
						return true;
					}
					break;
				}
				case 8:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'I')
						{
							if (name == "Interact")
							{
								value = EDistrubuteType.Interact;
								return true;
							}
						}
					}
					else if (name == "Activity")
					{
						value = EDistrubuteType.Activity;
						return true;
					}
					break;
				}
				case 9:
				case 10:
				case 11:
					break;
				case 12:
					if (name == "PhoneMessage")
					{
						value = EDistrubuteType.PhoneMessage;
						return true;
					}
					break;
				default:
					if (length == 20)
					{
						if (name == "InformationViewCheck")
						{
							value = EDistrubuteType.InformationViewCheck;
							return true;
						}
					}
					break;
				}
			}
			value = EDistrubuteType.Interact;
			return false;
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x0010AB8C File Offset: 0x00108D8C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Interact",
				"System",
				"UseItem",
				"InformationViewCheck",
				"Daily",
				"Passive",
				"Activity",
				"PhoneMessage"
			};
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x0010ABDF File Offset: 0x00108DDF
		public static EDistrubuteType[] GetValues()
		{
			return new EDistrubuteType[]
			{
				EDistrubuteType.Interact,
				EDistrubuteType.System,
				EDistrubuteType.UseItem,
				EDistrubuteType.InformationViewCheck,
				EDistrubuteType.Daily,
				EDistrubuteType.Passive,
				EDistrubuteType.Activity,
				EDistrubuteType.PhoneMessage
			};
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x0010ABF4 File Offset: 0x00108DF4
		public static string[] GetNames()
		{
			return new string[]
			{
				"Interact",
				"System",
				"UseItem",
				"InformationViewCheck",
				"Daily",
				"Passive",
				"Activity",
				"PhoneMessage"
			};
		}
	}
}
