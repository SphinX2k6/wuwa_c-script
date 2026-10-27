using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095A RID: 2394
	public static class EGroupAiFormationBasisExtensions
	{
		// Token: 0x060035C6 RID: 13766 RVA: 0x0008C1C0 File Offset: 0x0008A3C0
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

		// Token: 0x060035C7 RID: 13767 RVA: 0x0008C1F8 File Offset: 0x0008A3F8
		public static EGroupAiFormationBasis FromString(string name)
		{
			EGroupAiFormationBasis result;
			if (!EGroupAiFormationBasisExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiFormationBasis 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x0008C221 File Offset: 0x0008A421
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

		// Token: 0x060035C9 RID: 13769 RVA: 0x0008C25A File Offset: 0x0008A45A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline",
				"Default"
			};
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x0008C272 File Offset: 0x0008A472
		public static EGroupAiFormationBasis[] GetValues()
		{
			return new EGroupAiFormationBasis[]
			{
				EGroupAiFormationBasis.Spline,
				EGroupAiFormationBasis.Default
			};
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x0008C27E File Offset: 0x0008A47E
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
