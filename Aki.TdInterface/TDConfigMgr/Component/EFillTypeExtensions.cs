using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F9 RID: 2553
	public static class EFillTypeExtensions
	{
		// Token: 0x060038F3 RID: 14579 RVA: 0x000936F0 File Offset: 0x000918F0
		public static string ToEnumString(this EFillType value)
		{
			string result;
			if (value != EFillType.Fixed)
			{
				if (value != EFillType.Direction)
				{
					result = value.ToString();
				}
				else
				{
					result = "Direction";
				}
			}
			else
			{
				result = "Fixed";
			}
			return result;
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x00093728 File Offset: 0x00091928
		public static EFillType FromString(string name)
		{
			EFillType result;
			if (!EFillTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFillType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x00093751 File Offset: 0x00091951
		public static bool TryFromString(string name, out EFillType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFillType.Fixed;
				return false;
			}
			if (name == "Fixed")
			{
				value = EFillType.Fixed;
				return true;
			}
			if (!(name == "Direction"))
			{
				value = EFillType.Fixed;
				return false;
			}
			value = EFillType.Direction;
			return true;
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0009378A File Offset: 0x0009198A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Fixed",
				"Direction"
			};
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x000937A2 File Offset: 0x000919A2
		public static EFillType[] GetValues()
		{
			return new EFillType[]
			{
				EFillType.Fixed,
				EFillType.Direction
			};
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x000937AE File Offset: 0x000919AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Fixed",
				"Direction"
			};
		}
	}
}
