using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026FC RID: 9980
	public static class ETalkOptionParamTypeExtensions
	{
		// Token: 0x0600D6C8 RID: 54984 RVA: 0x001F5B30 File Offset: 0x001F3D30
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

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x001F5BA8 File Offset: 0x001F3DA8
		public static ETalkOptionParamType FromString(string name)
		{
			ETalkOptionParamType result;
			if (!ETalkOptionParamTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkOptionParamType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x001F5BD4 File Offset: 0x001F3DD4
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

		// Token: 0x0600D6CB RID: 54987 RVA: 0x001F5CC5 File Offset: 0x001F3EC5
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

		// Token: 0x0600D6CC RID: 54988 RVA: 0x001F5D05 File Offset: 0x001F3F05
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

		// Token: 0x0600D6CD RID: 54989 RVA: 0x001F5D18 File Offset: 0x001F3F18
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
