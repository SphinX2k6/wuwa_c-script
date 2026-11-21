using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B0 RID: 9904
	public static class ESetTimeScaleTypeExtensions
	{
		// Token: 0x0600D572 RID: 54642 RVA: 0x001EFC98 File Offset: 0x001EDE98
		public static string ToEnumString(this ESetTimeScaleType value)
		{
			string result;
			if (value != ESetTimeScaleType.Open)
			{
				if (value != ESetTimeScaleType.Close)
				{
					result = value.ToString();
				}
				else
				{
					result = "Close";
				}
			}
			else
			{
				result = "Open";
			}
			return result;
		}

		// Token: 0x0600D573 RID: 54643 RVA: 0x001EFCD0 File Offset: 0x001EDED0
		public static ESetTimeScaleType FromString(string name)
		{
			ESetTimeScaleType result;
			if (!ESetTimeScaleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetTimeScaleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D574 RID: 54644 RVA: 0x001EFCF9 File Offset: 0x001EDEF9
		public static bool TryFromString(string name, out ESetTimeScaleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetTimeScaleType.Open;
				return false;
			}
			if (name == "Open")
			{
				value = ESetTimeScaleType.Open;
				return true;
			}
			if (!(name == "Close"))
			{
				value = ESetTimeScaleType.Open;
				return false;
			}
			value = ESetTimeScaleType.Close;
			return true;
		}

		// Token: 0x0600D575 RID: 54645 RVA: 0x001EFD32 File Offset: 0x001EDF32
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600D576 RID: 54646 RVA: 0x001EFD4A File Offset: 0x001EDF4A
		public static ESetTimeScaleType[] GetValues()
		{
			return new ESetTimeScaleType[]
			{
				ESetTimeScaleType.Open,
				ESetTimeScaleType.Close
			};
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x001EFD56 File Offset: 0x001EDF56
		public static string[] GetNames()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}
	}
}
