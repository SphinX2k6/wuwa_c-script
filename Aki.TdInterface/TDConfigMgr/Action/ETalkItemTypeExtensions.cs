using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002457 RID: 9303
	public static class ETalkItemTypeExtensions
	{
		// Token: 0x0600CA06 RID: 51718 RVA: 0x001DB3E8 File Offset: 0x001D95E8
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

		// Token: 0x0600CA07 RID: 51719 RVA: 0x001DB4F0 File Offset: 0x001D96F0
		public static ETalkItemType FromString(string name)
		{
			ETalkItemType result;
			if (!ETalkItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x001DB51C File Offset: 0x001D971C
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

		// Token: 0x0600CA09 RID: 51721 RVA: 0x001DB7F0 File Offset: 0x001D99F0
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

		// Token: 0x0600CA0A RID: 51722 RVA: 0x001DB89D File Offset: 0x001D9A9D
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

		// Token: 0x0600CA0B RID: 51723 RVA: 0x001DB8B4 File Offset: 0x001D9AB4
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
