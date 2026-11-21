using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0D RID: 2573
	public static class EGroupAiFormationBasisExtensions
	{
		// Token: 0x0600394D RID: 14669 RVA: 0x00094114 File Offset: 0x00092314
		public static string ToEnumString(this EGroupAiFormationBasis value)
		{
			string result;
			if (value != EGroupAiFormationBasis.Spline)
			{
				if (value != EGroupAiFormationBasis.Default)
				{
					result = value.ToString();
				}
				else
				{
					result = "Default";
				}
			}
			else
			{
				result = "Spline";
			}
			return result;
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x0009414C File Offset: 0x0009234C
		public static EGroupAiFormationBasis FromString(string name)
		{
			EGroupAiFormationBasis result;
			if (!EGroupAiFormationBasisExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiFormationBasis 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x00094175 File Offset: 0x00092375
		public static bool TryFromString(string name, out EGroupAiFormationBasis value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupAiFormationBasis.Spline;
				return false;
			}
			if (name == "Spline")
			{
				value = EGroupAiFormationBasis.Spline;
				return true;
			}
			if (!(name == "Default"))
			{
				value = EGroupAiFormationBasis.Spline;
				return false;
			}
			value = EGroupAiFormationBasis.Default;
			return true;
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x000941AE File Offset: 0x000923AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline",
				"Default"
			};
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x000941C6 File Offset: 0x000923C6
		public static EGroupAiFormationBasis[] GetValues()
		{
			return new EGroupAiFormationBasis[]
			{
				EGroupAiFormationBasis.Spline,
				EGroupAiFormationBasis.Default
			};
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x000941D2 File Offset: 0x000923D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spline",
				"Default"
			};
		}
	}
}
