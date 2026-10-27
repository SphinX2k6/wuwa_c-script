using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1C RID: 2588
	public static class ESplineLineExtensions
	{
		// Token: 0x0600392F RID: 14639 RVA: 0x000939B0 File Offset: 0x00091BB0
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

		// Token: 0x06003930 RID: 14640 RVA: 0x00093A04 File Offset: 0x00091C04
		public static ESplineLine FromString(string name)
		{
			ESplineLine result;
			if (!ESplineLineExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineLine 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x00093A30 File Offset: 0x00091C30
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

		// Token: 0x06003932 RID: 14642 RVA: 0x00093A98 File Offset: 0x00091C98
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

		// Token: 0x06003933 RID: 14643 RVA: 0x00093AC0 File Offset: 0x00091CC0
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

		// Token: 0x06003934 RID: 14644 RVA: 0x00093AD3 File Offset: 0x00091CD3
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
