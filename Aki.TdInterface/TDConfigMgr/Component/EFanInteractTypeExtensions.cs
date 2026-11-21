using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F5 RID: 2549
	public static class EFanInteractTypeExtensions
	{
		// Token: 0x060038E1 RID: 14561 RVA: 0x00093500 File Offset: 0x00091700
		public static string ToEnumString(this EFanInteractType value)
		{
			string result;
			if (value != EFanInteractType.Hit)
			{
				if (value != EFanInteractType.FKey)
				{
					result = value.ToString();
				}
				else
				{
					result = "FKey";
				}
			}
			else
			{
				result = "Hit";
			}
			return result;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x00093538 File Offset: 0x00091738
		public static EFanInteractType FromString(string name)
		{
			EFanInteractType result;
			if (!EFanInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFanInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x00093561 File Offset: 0x00091761
		public static bool TryFromString(string name, out EFanInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFanInteractType.Hit;
				return false;
			}
			if (name == "Hit")
			{
				value = EFanInteractType.Hit;
				return true;
			}
			if (!(name == "FKey"))
			{
				value = EFanInteractType.Hit;
				return false;
			}
			value = EFanInteractType.FKey;
			return true;
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0009359A File Offset: 0x0009179A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Hit",
				"FKey"
			};
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x000935B2 File Offset: 0x000917B2
		public static EFanInteractType[] GetValues()
		{
			return new EFanInteractType[]
			{
				EFanInteractType.Hit,
				EFanInteractType.FKey
			};
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x000935BE File Offset: 0x000917BE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Hit",
				"FKey"
			};
		}
	}
}
