using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A73 RID: 2675
	public static class EPasserbyNpcExitOrderTypeExtensions
	{
		// Token: 0x06003B18 RID: 15128 RVA: 0x000988D0 File Offset: 0x00096AD0
		public static string ToEnumString(this EPasserbyNpcExitOrderType value)
		{
			string result;
			if (value == EPasserbyNpcExitOrderType.NearSplineStartFirst)
			{
				result = "NearSplineStartFirst";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x000988F8 File Offset: 0x00096AF8
		public static EPasserbyNpcExitOrderType FromString(string name)
		{
			EPasserbyNpcExitOrderType result;
			if (!EPasserbyNpcExitOrderTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcExitOrderType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x00098921 File Offset: 0x00096B21
		public static bool TryFromString(string name, out EPasserbyNpcExitOrderType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcExitOrderType.NearSplineStartFirst;
				return false;
			}
			if (name == "NearSplineStartFirst")
			{
				value = EPasserbyNpcExitOrderType.NearSplineStartFirst;
				return true;
			}
			value = EPasserbyNpcExitOrderType.NearSplineStartFirst;
			return false;
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00098946 File Offset: 0x00096B46
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NearSplineStartFirst"
			};
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00098956 File Offset: 0x00096B56
		public static EPasserbyNpcExitOrderType[] GetValues()
		{
			return new EPasserbyNpcExitOrderType[1];
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x0009895E File Offset: 0x00096B5E
		public static string[] GetNames()
		{
			return new string[]
			{
				"NearSplineStartFirst"
			};
		}
	}
}
