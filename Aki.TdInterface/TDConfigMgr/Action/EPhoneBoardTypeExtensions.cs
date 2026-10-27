using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C1 RID: 9153
	public static class EPhoneBoardTypeExtensions
	{
		// Token: 0x0600C763 RID: 51043 RVA: 0x001D3080 File Offset: 0x001D1280
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

		// Token: 0x0600C764 RID: 51044 RVA: 0x001D30A8 File Offset: 0x001D12A8
		public static EPhoneBoardType FromString(string name)
		{
			EPhoneBoardType result;
			if (!EPhoneBoardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneBoardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C765 RID: 51045 RVA: 0x001D30D1 File Offset: 0x001D12D1
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

		// Token: 0x0600C766 RID: 51046 RVA: 0x001D30F6 File Offset: 0x001D12F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MessageBoard"
			};
		}

		// Token: 0x0600C767 RID: 51047 RVA: 0x001D3106 File Offset: 0x001D1306
		public static EPhoneBoardType[] GetValues()
		{
			return new EPhoneBoardType[1];
		}

		// Token: 0x0600C768 RID: 51048 RVA: 0x001D310E File Offset: 0x001D130E
		public static string[] GetNames()
		{
			return new string[]
			{
				"MessageBoard"
			};
		}
	}
}
