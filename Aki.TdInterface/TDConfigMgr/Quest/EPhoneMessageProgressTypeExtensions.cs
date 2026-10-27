using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125E RID: 4702
	public static class EPhoneMessageProgressTypeExtensions
	{
		// Token: 0x06006A4E RID: 27214 RVA: 0x000FED24 File Offset: 0x000FCF24
		public static string ToEnumString(this EPhoneMessageProgressType value)
		{
			string result;
			if (value == EPhoneMessageProgressType.CompleteMessage)
			{
				result = "CompleteMessage";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x000FED4C File Offset: 0x000FCF4C
		public static EPhoneMessageProgressType FromString(string name)
		{
			EPhoneMessageProgressType result;
			if (!EPhoneMessageProgressTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneMessageProgressType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x000FED75 File Offset: 0x000FCF75
		public static bool TryFromString(string name, out EPhoneMessageProgressType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhoneMessageProgressType.CompleteMessage;
				return false;
			}
			if (name == "CompleteMessage")
			{
				value = EPhoneMessageProgressType.CompleteMessage;
				return true;
			}
			value = EPhoneMessageProgressType.CompleteMessage;
			return false;
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x000FED9A File Offset: 0x000FCF9A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CompleteMessage"
			};
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x000FEDAA File Offset: 0x000FCFAA
		public static EPhoneMessageProgressType[] GetValues()
		{
			return new EPhoneMessageProgressType[1];
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x000FEDB2 File Offset: 0x000FCFB2
		public static string[] GetNames()
		{
			return new string[]
			{
				"CompleteMessage"
			};
		}
	}
}
