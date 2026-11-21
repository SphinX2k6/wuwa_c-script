using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BD RID: 2493
	public static class EConnectorLogicTypeExtensions
	{
		// Token: 0x060037E5 RID: 14309 RVA: 0x00091384 File Offset: 0x0008F584
		public static string ToEnumString(this EConnectorLogicType value)
		{
			string result;
			if (value != EConnectorLogicType.Range)
			{
				if (value != EConnectorLogicType.PointToPointPathAdvance)
				{
					result = value.ToString();
				}
				else
				{
					result = "PointToPointPathAdvance";
				}
			}
			else
			{
				result = "Range";
			}
			return result;
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x000913BC File Offset: 0x0008F5BC
		public static EConnectorLogicType FromString(string name)
		{
			EConnectorLogicType result;
			if (!EConnectorLogicTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConnectorLogicType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x000913E5 File Offset: 0x0008F5E5
		public static bool TryFromString(string name, out EConnectorLogicType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EConnectorLogicType.Range;
				return false;
			}
			if (name == "Range")
			{
				value = EConnectorLogicType.Range;
				return true;
			}
			if (!(name == "PointToPointPathAdvance"))
			{
				value = EConnectorLogicType.Range;
				return false;
			}
			value = EConnectorLogicType.PointToPointPathAdvance;
			return true;
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x0009141E File Offset: 0x0008F61E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Range",
				"PointToPointPathAdvance"
			};
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00091436 File Offset: 0x0008F636
		public static EConnectorLogicType[] GetValues()
		{
			return new EConnectorLogicType[]
			{
				EConnectorLogicType.Range,
				EConnectorLogicType.PointToPointPathAdvance
			};
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00091442 File Offset: 0x0008F642
		public static string[] GetNames()
		{
			return new string[]
			{
				"Range",
				"PointToPointPathAdvance"
			};
		}
	}
}
