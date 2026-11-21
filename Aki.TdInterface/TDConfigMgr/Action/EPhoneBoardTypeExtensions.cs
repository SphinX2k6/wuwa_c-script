using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002656 RID: 9814
	public static class EPhoneBoardTypeExtensions
	{
		// Token: 0x0600D3DD RID: 54237 RVA: 0x001EC718 File Offset: 0x001EA918
		public static string ToEnumString(this EPhoneBoardType value)
		{
			string result;
			if (value == EPhoneBoardType.MessageBoard)
			{
				result = "MessageBoard";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D3DE RID: 54238 RVA: 0x001EC740 File Offset: 0x001EA940
		public static EPhoneBoardType FromString(string name)
		{
			EPhoneBoardType result;
			if (!EPhoneBoardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneBoardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3DF RID: 54239 RVA: 0x001EC769 File Offset: 0x001EA969
		public static bool TryFromString(string name, out EPhoneBoardType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhoneBoardType.MessageBoard;
				return false;
			}
			if (name == "MessageBoard")
			{
				value = EPhoneBoardType.MessageBoard;
				return true;
			}
			value = EPhoneBoardType.MessageBoard;
			return false;
		}

		// Token: 0x0600D3E0 RID: 54240 RVA: 0x001EC78E File Offset: 0x001EA98E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MessageBoard"
			};
		}

		// Token: 0x0600D3E1 RID: 54241 RVA: 0x001EC79E File Offset: 0x001EA99E
		public static EPhoneBoardType[] GetValues()
		{
			return new EPhoneBoardType[1];
		}

		// Token: 0x0600D3E2 RID: 54242 RVA: 0x001EC7A6 File Offset: 0x001EA9A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"MessageBoard"
			};
		}
	}
}
