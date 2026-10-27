using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126E RID: 4718
	public static class EQuestOnlineTypeExtensions
	{
		// Token: 0x06006A96 RID: 27286 RVA: 0x000FF808 File Offset: 0x000FDA08
		public static string ToEnumString(this EQuestOnlineType value)
		{
			string result;
			if (value != EQuestOnlineType.SingleHangUpOnline)
			{
				if (value != EQuestOnlineType.SingleNotHangUpOnline)
				{
					result = value.ToString();
				}
				else
				{
					result = "SingleNotHangUpOnline";
				}
			}
			else
			{
				result = "SingleHangUpOnline";
			}
			return result;
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x000FF840 File Offset: 0x000FDA40
		public static EQuestOnlineType FromString(string name)
		{
			EQuestOnlineType result;
			if (!EQuestOnlineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuestOnlineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x000FF869 File Offset: 0x000FDA69
		public static bool TryFromString(string name, out EQuestOnlineType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQuestOnlineType.SingleHangUpOnline;
				return false;
			}
			if (name == "SingleHangUpOnline")
			{
				value = EQuestOnlineType.SingleHangUpOnline;
				return true;
			}
			if (!(name == "SingleNotHangUpOnline"))
			{
				value = EQuestOnlineType.SingleHangUpOnline;
				return false;
			}
			value = EQuestOnlineType.SingleNotHangUpOnline;
			return true;
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x000FF8A2 File Offset: 0x000FDAA2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SingleHangUpOnline",
				"SingleNotHangUpOnline"
			};
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x000FF8BA File Offset: 0x000FDABA
		public static EQuestOnlineType[] GetValues()
		{
			return new EQuestOnlineType[]
			{
				EQuestOnlineType.SingleHangUpOnline,
				EQuestOnlineType.SingleNotHangUpOnline
			};
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x000FF8C6 File Offset: 0x000FDAC6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SingleHangUpOnline",
				"SingleNotHangUpOnline"
			};
		}
	}
}
