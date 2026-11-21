using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200139E RID: 5022
	public static class EPhoneMessageProgressTypeExtensions
	{
		// Token: 0x060070A1 RID: 28833 RVA: 0x0010C950 File Offset: 0x0010AB50
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

		// Token: 0x060070A2 RID: 28834 RVA: 0x0010C978 File Offset: 0x0010AB78
		public static EPhoneMessageProgressType FromString(string name)
		{
			EPhoneMessageProgressType result;
			if (!EPhoneMessageProgressTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneMessageProgressType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x0010C9A1 File Offset: 0x0010ABA1
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

		// Token: 0x060070A4 RID: 28836 RVA: 0x0010C9C6 File Offset: 0x0010ABC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CompleteMessage"
			};
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x0010C9D6 File Offset: 0x0010ABD6
		public static EPhoneMessageProgressType[] GetValues()
		{
			return new EPhoneMessageProgressType[1];
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x0010C9DE File Offset: 0x0010ABDE
		public static string[] GetNames()
		{
			return new string[]
			{
				"CompleteMessage"
			};
		}
	}
}
