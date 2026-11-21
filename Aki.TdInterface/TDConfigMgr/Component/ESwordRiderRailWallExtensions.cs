using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AEB RID: 2795
	public static class ESwordRiderRailWallExtensions
	{
		// Token: 0x06003D34 RID: 15668 RVA: 0x0009CC2C File Offset: 0x0009AE2C
		public static string ToEnumString(this ESwordRiderRailWall value)
		{
			string result;
			if (value != ESwordRiderRailWall.Inner)
			{
				if (value != ESwordRiderRailWall.Outer)
				{
					result = value.ToString();
				}
				else
				{
					result = "Outer";
				}
			}
			else
			{
				result = "Inner";
			}
			return result;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0009CC64 File Offset: 0x0009AE64
		public static ESwordRiderRailWall FromString(string name)
		{
			ESwordRiderRailWall result;
			if (!ESwordRiderRailWallExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwordRiderRailWall 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x0009CC8D File Offset: 0x0009AE8D
		public static bool TryFromString(string name, out ESwordRiderRailWall value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESwordRiderRailWall.Inner;
				return false;
			}
			if (name == "Inner")
			{
				value = ESwordRiderRailWall.Inner;
				return true;
			}
			if (!(name == "Outer"))
			{
				value = ESwordRiderRailWall.Inner;
				return false;
			}
			value = ESwordRiderRailWall.Outer;
			return true;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x0009CCC6 File Offset: 0x0009AEC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Inner",
				"Outer"
			};
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x0009CCDE File Offset: 0x0009AEDE
		public static ESwordRiderRailWall[] GetValues()
		{
			return new ESwordRiderRailWall[]
			{
				ESwordRiderRailWall.Inner,
				ESwordRiderRailWall.Outer
			};
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x0009CCEA File Offset: 0x0009AEEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Inner",
				"Outer"
			};
		}
	}
}
