using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094A RID: 2378
	public static class EFillTypeExtensions
	{
		// Token: 0x0600357E RID: 13694 RVA: 0x0008BA38 File Offset: 0x00089C38
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

		// Token: 0x0600357F RID: 13695 RVA: 0x0008BA70 File Offset: 0x00089C70
		public static EFillType FromString(string name)
		{
			EFillType result;
			if (!EFillTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFillType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x0008BA99 File Offset: 0x00089C99
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

		// Token: 0x06003581 RID: 13697 RVA: 0x0008BAD2 File Offset: 0x00089CD2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Fixed",
				"Direction"
			};
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x0008BAEA File Offset: 0x00089CEA
		public static EFillType[] GetValues()
		{
			return new EFillType[]
			{
				EFillType.Fixed,
				EFillType.Direction
			};
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0008BAF6 File Offset: 0x00089CF6
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
