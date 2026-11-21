using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE1 RID: 2785
	public static class ESplineLineExtensions
	{
		// Token: 0x06003D07 RID: 15623 RVA: 0x0009C2E4 File Offset: 0x0009A4E4
		public static string ToEnumString(this ESplineLine value)
		{
			string result;
			switch (value)
			{
			case ESplineLine.Linear:
				result = "Linear";
				break;
			case ESplineLine.Curve:
				result = "Curve";
				break;
			case ESplineLine.Constant:
				result = "Constant";
				break;
			case ESplineLine.CurveCustomTangent:
				result = "CurveCustomTangent";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x0009C338 File Offset: 0x0009A538
		public static ESplineLine FromString(string name)
		{
			ESplineLine result;
			if (!ESplineLineExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineLine 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x0009C364 File Offset: 0x0009A564
		public static bool TryFromString(string name, out ESplineLine value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineLine.Linear;
				return false;
			}
			if (name == "Linear")
			{
				value = ESplineLine.Linear;
				return true;
			}
			if (name == "Curve")
			{
				value = ESplineLine.Curve;
				return true;
			}
			if (name == "Constant")
			{
				value = ESplineLine.Constant;
				return true;
			}
			if (!(name == "CurveCustomTangent"))
			{
				value = ESplineLine.Linear;
				return false;
			}
			value = ESplineLine.CurveCustomTangent;
			return true;
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x0009C3CC File Offset: 0x0009A5CC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Linear",
				"Curve",
				"Constant",
				"CurveCustomTangent"
			};
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x0009C3F4 File Offset: 0x0009A5F4
		public static ESplineLine[] GetValues()
		{
			return new ESplineLine[]
			{
				ESplineLine.Linear,
				ESplineLine.Curve,
				ESplineLine.Constant,
				ESplineLine.CurveCustomTangent
			};
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x0009C407 File Offset: 0x0009A607
		public static string[] GetNames()
		{
			return new string[]
			{
				"Linear",
				"Curve",
				"Constant",
				"CurveCustomTangent"
			};
		}
	}
}
