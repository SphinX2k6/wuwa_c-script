using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F8 RID: 9976
	public static class ETalkItemTypeExtensions
	{
		// Token: 0x0600D6B6 RID: 54966 RVA: 0x001F549C File Offset: 0x001F369C
		public static string ToEnumString(this ETalkItemType value)
		{
			string result;
			switch (value)
			{
			case ETalkItemType.Talk:
				result = "Talk";
				break;
			case ETalkItemType.Option:
				result = "Option";
				break;
			case ETalkItemType.CenterText:
				result = "CenterText";
				break;
			case ETalkItemType.SystemOption:
				result = "SystemOption";
				break;
			case ETalkItemType.QTE:
				result = "QTE";
				break;
			case ETalkItemType.NoTextItem:
				result = "NoTextItem";
				break;
			case ETalkItemType.PhoneMessage:
				result = "PhoneMessage";
				break;
			case ETalkItemType.AvgTalk:
				result = "AvgTalk";
				break;
			case ETalkItemType.AvgEnter:
				result = "AvgEnter";
				break;
			case ETalkItemType.AvgExit:
				result = "AvgExit";
				break;
			case ETalkItemType.AvgOption:
				result = "AvgOption";
				break;
			case ETalkItemType.AvgNarration:
				result = "AvgNarration";
				break;
			case ETalkItemType.AvgCenterText:
				result = "AvgCenterText";
				break;
			case ETalkItemType.VisualNovelTalk:
				result = "VisualNovelTalk";
				break;
			case ETalkItemType.VisualNovelNoTextItem:
				result = "VisualNovelNoTextItem";
				break;
			case ETalkItemType.VisualNovelNarration:
				result = "VisualNovelNarration";
				break;
			case ETalkItemType.VisualNovelOption:
				result = "VisualNovelOption";
				break;
			case ETalkItemType.VisualNovelCenterText:
				result = "VisualNovelCenterText";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x001F55A4 File Offset: 0x001F37A4
		public static ETalkItemType FromString(string name)
		{
			ETalkItemType result;
			if (!ETalkItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6B8 RID: 54968 RVA: 0x001F55D0 File Offset: 0x001F37D0
		public static bool TryFromString(string name, out ETalkItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkItemType.Talk;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 3:
					if (name == "QTE")
					{
						value = ETalkItemType.QTE;
						return true;
					}
					break;
				case 4:
					if (name == "Talk")
					{
						value = ETalkItemType.Talk;
						return true;
					}
					break;
				case 6:
					if (name == "Option")
					{
						value = ETalkItemType.Option;
						return true;
					}
					break;
				case 7:
				{
					char c = name[3];
					if (c != 'E')
					{
						if (c == 'T')
						{
							if (name == "AvgTalk")
							{
								value = ETalkItemType.AvgTalk;
								return true;
							}
						}
					}
					else if (name == "AvgExit")
					{
						value = ETalkItemType.AvgExit;
						return true;
					}
					break;
				}
				case 8:
					if (name == "AvgEnter")
					{
						value = ETalkItemType.AvgEnter;
						return true;
					}
					break;
				case 9:
					if (name == "AvgOption")
					{
						value = ETalkItemType.AvgOption;
						return true;
					}
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'N')
						{
							if (name == "NoTextItem")
							{
								value = ETalkItemType.NoTextItem;
								return true;
							}
						}
					}
					else if (name == "CenterText")
					{
						value = ETalkItemType.CenterText;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c != 'P')
						{
							if (c == 'S')
							{
								if (name == "SystemOption")
								{
									value = ETalkItemType.SystemOption;
									return true;
								}
							}
						}
						else if (name == "PhoneMessage")
						{
							value = ETalkItemType.PhoneMessage;
							return true;
						}
					}
					else if (name == "AvgNarration")
					{
						value = ETalkItemType.AvgNarration;
						return true;
					}
					break;
				}
				case 13:
					if (name == "AvgCenterText")
					{
						value = ETalkItemType.AvgCenterText;
						return true;
					}
					break;
				case 15:
					if (name == "VisualNovelTalk")
					{
						value = ETalkItemType.VisualNovelTalk;
						return true;
					}
					break;
				case 17:
					if (name == "VisualNovelOption")
					{
						value = ETalkItemType.VisualNovelOption;
						return true;
					}
					break;
				case 20:
					if (name == "VisualNovelNarration")
					{
						value = ETalkItemType.VisualNovelNarration;
						return true;
					}
					break;
				case 21:
				{
					char c = name[11];
					if (c != 'C')
					{
						if (c == 'N')
						{
							if (name == "VisualNovelNoTextItem")
							{
								value = ETalkItemType.VisualNovelNoTextItem;
								return true;
							}
						}
					}
					else if (name == "VisualNovelCenterText")
					{
						value = ETalkItemType.VisualNovelCenterText;
						return true;
					}
					break;
				}
				}
			}
			value = ETalkItemType.Talk;
			return false;
		}

		// Token: 0x0600D6B9 RID: 54969 RVA: 0x001F58A4 File Offset: 0x001F3AA4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Talk",
				"Option",
				"CenterText",
				"SystemOption",
				"QTE",
				"NoTextItem",
				"PhoneMessage",
				"AvgTalk",
				"AvgEnter",
				"AvgExit",
				"AvgOption",
				"AvgNarration",
				"AvgCenterText",
				"VisualNovelTalk",
				"VisualNovelNoTextItem",
				"VisualNovelNarration",
				"VisualNovelOption",
				"VisualNovelCenterText"
			};
		}

		// Token: 0x0600D6BA RID: 54970 RVA: 0x001F5951 File Offset: 0x001F3B51
		public static ETalkItemType[] GetValues()
		{
			return new ETalkItemType[]
			{
				ETalkItemType.Talk,
				ETalkItemType.Option,
				ETalkItemType.CenterText,
				ETalkItemType.SystemOption,
				ETalkItemType.QTE,
				ETalkItemType.NoTextItem,
				ETalkItemType.PhoneMessage,
				ETalkItemType.AvgTalk,
				ETalkItemType.AvgEnter,
				ETalkItemType.AvgExit,
				ETalkItemType.AvgOption,
				ETalkItemType.AvgNarration,
				ETalkItemType.AvgCenterText,
				ETalkItemType.VisualNovelTalk,
				ETalkItemType.VisualNovelNoTextItem,
				ETalkItemType.VisualNovelNarration,
				ETalkItemType.VisualNovelOption,
				ETalkItemType.VisualNovelCenterText
			};
		}

		// Token: 0x0600D6BB RID: 54971 RVA: 0x001F5968 File Offset: 0x001F3B68
		public static string[] GetNames()
		{
			return new string[]
			{
				"Talk",
				"Option",
				"CenterText",
				"SystemOption",
				"QTE",
				"NoTextItem",
				"PhoneMessage",
				"AvgTalk",
				"AvgEnter",
				"AvgExit",
				"AvgOption",
				"AvgNarration",
				"AvgCenterText",
				"VisualNovelTalk",
				"VisualNovelNoTextItem",
				"VisualNovelNarration",
				"VisualNovelOption",
				"VisualNovelCenterText"
			};
		}
	}
}
