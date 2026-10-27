using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001238 RID: 4664
	public static class EDistrubuteTypeExtensions
	{
		// Token: 0x060069A3 RID: 27043 RVA: 0x000FCDDC File Offset: 0x000FAFDC
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

		// Token: 0x060069A4 RID: 27044 RVA: 0x000FCE60 File Offset: 0x000FB060
		public static EDistrubuteType FromString(string name)
		{
			EDistrubuteType result;
			if (!EDistrubuteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDistrubuteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x000FCE8C File Offset: 0x000FB08C
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

		// Token: 0x060069A6 RID: 27046 RVA: 0x000FCFC0 File Offset: 0x000FB1C0
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

		// Token: 0x060069A7 RID: 27047 RVA: 0x000FD013 File Offset: 0x000FB213
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

		// Token: 0x060069A8 RID: 27048 RVA: 0x000FD028 File Offset: 0x000FB228
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
