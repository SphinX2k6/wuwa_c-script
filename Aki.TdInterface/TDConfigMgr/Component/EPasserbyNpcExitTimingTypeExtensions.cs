using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A75 RID: 2677
	public static class EPasserbyNpcExitTimingTypeExtensions
	{
		// Token: 0x06003B21 RID: 15137 RVA: 0x000989AC File Offset: 0x00096BAC
		public static string ToEnumString(this EPasserbyNpcExitTimingType value)
		{
			string result;
			if (value == EPasserbyNpcExitTimingType.LiftStop)
			{
				result = "LiftStop";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x000989D4 File Offset: 0x00096BD4
		public static EPasserbyNpcExitTimingType FromString(string name)
		{
			EPasserbyNpcExitTimingType result;
			if (!EPasserbyNpcExitTimingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcExitTimingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x000989FD File Offset: 0x00096BFD
		public static bool TryFromString(string name, out EPasserbyNpcExitTimingType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcExitTimingType.LiftStop;
				return false;
			}
			if (name == "LiftStop")
			{
				value = EPasserbyNpcExitTimingType.LiftStop;
				return true;
			}
			value = EPasserbyNpcExitTimingType.LiftStop;
			return false;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x00098A22 File Offset: 0x00096C22
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LiftStop"
			};
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00098A32 File Offset: 0x00096C32
		public static EPasserbyNpcExitTimingType[] GetValues()
		{
			return new EPasserbyNpcExitTimingType[1];
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00098A3A File Offset: 0x00096C3A
		public static string[] GetNames()
		{
			return new string[]
			{
				"LiftStop"
			};
		}
	}
}
