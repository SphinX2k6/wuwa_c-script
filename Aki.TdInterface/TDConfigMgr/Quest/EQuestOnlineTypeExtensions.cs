using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013AE RID: 5038
	public static class EQuestOnlineTypeExtensions
	{
		// Token: 0x060070E9 RID: 28905 RVA: 0x0010D434 File Offset: 0x0010B634
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

		// Token: 0x060070EA RID: 28906 RVA: 0x0010D46C File Offset: 0x0010B66C
		public static EQuestOnlineType FromString(string name)
		{
			EQuestOnlineType result;
			if (!EQuestOnlineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuestOnlineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x0010D495 File Offset: 0x0010B695
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

		// Token: 0x060070EC RID: 28908 RVA: 0x0010D4CE File Offset: 0x0010B6CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SingleHangUpOnline",
				"SingleNotHangUpOnline"
			};
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x0010D4E6 File Offset: 0x0010B6E6
		public static EQuestOnlineType[] GetValues()
		{
			return new EQuestOnlineType[]
			{
				EQuestOnlineType.SingleHangUpOnline,
				EQuestOnlineType.SingleNotHangUpOnline
			};
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x0010D4F2 File Offset: 0x0010B6F2
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
