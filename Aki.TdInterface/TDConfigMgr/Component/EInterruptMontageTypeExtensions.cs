using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A31 RID: 2609
	public static class EInterruptMontageTypeExtensions
	{
		// Token: 0x060039EF RID: 14831 RVA: 0x00095C90 File Offset: 0x00093E90
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

		// Token: 0x060039F0 RID: 14832 RVA: 0x00095CC8 File Offset: 0x00093EC8
		public static EInterruptMontageType FromString(string name)
		{
			EInterruptMontageType result;
			if (!EInterruptMontageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInterruptMontageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00095CF1 File Offset: 0x00093EF1
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

		// Token: 0x060039F2 RID: 14834 RVA: 0x00095D2A File Offset: 0x00093F2A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InterruptAtEnd",
				"InterruptAtLoopEnd"
			};
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00095D42 File Offset: 0x00093F42
		public static EInterruptMontageType[] GetValues()
		{
			return new EInterruptMontageType[]
			{
				EInterruptMontageType.InterruptAtEnd,
				EInterruptMontageType.InterruptAtLoopEnd
			};
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00095D4E File Offset: 0x00093F4E
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
