using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097E RID: 2430
	public static class EInterruptMontageTypeExtensions
	{
		// Token: 0x06003668 RID: 13928 RVA: 0x0008DD24 File Offset: 0x0008BF24
		public static string ToEnumString(this EInterruptMontageType value)
		{
			string result;
			if (value != EInterruptMontageType.InterruptAtEnd)
			{
				if (value != EInterruptMontageType.InterruptAtLoopEnd)
				{
					result = value.ToString();
				}
				else
				{
					result = "InterruptAtLoopEnd";
				}
			}
			else
			{
				result = "InterruptAtEnd";
			}
			return result;
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0008DD5C File Offset: 0x0008BF5C
		public static EInterruptMontageType FromString(string name)
		{
			EInterruptMontageType result;
			if (!EInterruptMontageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInterruptMontageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0008DD85 File Offset: 0x0008BF85
		public static bool TryFromString(string name, out EInterruptMontageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInterruptMontageType.InterruptAtEnd;
				return false;
			}
			if (name == "InterruptAtEnd")
			{
				value = EInterruptMontageType.InterruptAtEnd;
				return true;
			}
			if (!(name == "InterruptAtLoopEnd"))
			{
				value = EInterruptMontageType.InterruptAtEnd;
				return false;
			}
			value = EInterruptMontageType.InterruptAtLoopEnd;
			return true;
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0008DDBE File Offset: 0x0008BFBE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InterruptAtEnd",
				"InterruptAtLoopEnd"
			};
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x0008DDD6 File Offset: 0x0008BFD6
		public static EInterruptMontageType[] GetValues()
		{
			return new EInterruptMontageType[]
			{
				EInterruptMontageType.InterruptAtEnd,
				EInterruptMontageType.InterruptAtLoopEnd
			};
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x0008DDE2 File Offset: 0x0008BFE2
		public static string[] GetNames()
		{
			return new string[]
			{
				"InterruptAtEnd",
				"InterruptAtLoopEnd"
			};
		}
	}
}
