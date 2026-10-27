using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245B RID: 9307
	public static class ETalkOptionParamTypeExtensions
	{
		// Token: 0x0600CA18 RID: 51736 RVA: 0x001DBA7C File Offset: 0x001D9C7C
		public static string ToEnumString(this ETalkOptionParamType value)
		{
			string result;
			switch (value)
			{
			case ETalkOptionParamType.QteSucceed:
				result = "QteSucceed";
				break;
			case ETalkOptionParamType.QteFailed:
				result = "QteFailed";
				break;
			case ETalkOptionParamType.QteSucceedDelayExec:
				result = "QteSucceedDelayExec";
				break;
			case ETalkOptionParamType.QteFailedDelayExec:
				result = "QteFailedDelayExec";
				break;
			case ETalkOptionParamType.RogueRandomEvent:
				result = "RogueRandomEvent";
				break;
			case ETalkOptionParamType.PhoneMessageEmoji:
				result = "PhoneMessageEmoji";
				break;
			case ETalkOptionParamType.VisualNovel:
				result = "VisualNovel";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CA19 RID: 51737 RVA: 0x001DBAF4 File Offset: 0x001D9CF4
		public static ETalkOptionParamType FromString(string name)
		{
			ETalkOptionParamType result;
			if (!ETalkOptionParamTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkOptionParamType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA1A RID: 51738 RVA: 0x001DBB20 File Offset: 0x001D9D20
		public static bool TryFromString(string name, out ETalkOptionParamType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkOptionParamType.QteSucceed;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 9:
					if (name == "QteFailed")
					{
						value = ETalkOptionParamType.QteFailed;
						return true;
					}
					break;
				case 10:
					if (name == "QteSucceed")
					{
						value = ETalkOptionParamType.QteSucceed;
						return true;
					}
					break;
				case 11:
					if (name == "VisualNovel")
					{
						value = ETalkOptionParamType.VisualNovel;
						return true;
					}
					break;
				case 16:
					if (name == "RogueRandomEvent")
					{
						value = ETalkOptionParamType.RogueRandomEvent;
						return true;
					}
					break;
				case 17:
					if (name == "PhoneMessageEmoji")
					{
						value = ETalkOptionParamType.PhoneMessageEmoji;
						return true;
					}
					break;
				case 18:
					if (name == "QteFailedDelayExec")
					{
						value = ETalkOptionParamType.QteFailedDelayExec;
						return true;
					}
					break;
				case 19:
					if (name == "QteSucceedDelayExec")
					{
						value = ETalkOptionParamType.QteSucceedDelayExec;
						return true;
					}
					break;
				}
			}
			value = ETalkOptionParamType.QteSucceed;
			return false;
		}

		// Token: 0x0600CA1B RID: 51739 RVA: 0x001DBC11 File Offset: 0x001D9E11
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"QteSucceed",
				"QteFailed",
				"QteSucceedDelayExec",
				"QteFailedDelayExec",
				"RogueRandomEvent",
				"PhoneMessageEmoji",
				"VisualNovel"
			};
		}

		// Token: 0x0600CA1C RID: 51740 RVA: 0x001DBC51 File Offset: 0x001D9E51
		public static ETalkOptionParamType[] GetValues()
		{
			return new ETalkOptionParamType[]
			{
				ETalkOptionParamType.QteSucceed,
				ETalkOptionParamType.QteFailed,
				ETalkOptionParamType.QteSucceedDelayExec,
				ETalkOptionParamType.QteFailedDelayExec,
				ETalkOptionParamType.RogueRandomEvent,
				ETalkOptionParamType.PhoneMessageEmoji,
				ETalkOptionParamType.VisualNovel
			};
		}

		// Token: 0x0600CA1D RID: 51741 RVA: 0x001DBC64 File Offset: 0x001D9E64
		public static string[] GetNames()
		{
			return new string[]
			{
				"QteSucceed",
				"QteFailed",
				"QteSucceedDelayExec",
				"QteFailedDelayExec",
				"RogueRandomEvent",
				"PhoneMessageEmoji",
				"VisualNovel"
			};
		}
	}
}
