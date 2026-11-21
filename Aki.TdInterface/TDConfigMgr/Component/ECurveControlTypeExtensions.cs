using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C7 RID: 2503
	public static class ECurveControlTypeExtensions
	{
		// Token: 0x06003812 RID: 14354 RVA: 0x00091878 File Offset: 0x0008FA78
		public static string ToEnumString(this ECurveControlType value)
		{
			string result;
			if (value == ECurveControlType.ChargeSlash)
			{
				result = "ChargeSlash";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x000918A0 File Offset: 0x0008FAA0
		public static ECurveControlType FromString(string name)
		{
			ECurveControlType result;
			if (!ECurveControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECurveControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x000918C9 File Offset: 0x0008FAC9
		public static bool TryFromString(string name, out ECurveControlType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECurveControlType.ChargeSlash;
				return false;
			}
			if (name == "ChargeSlash")
			{
				value = ECurveControlType.ChargeSlash;
				return true;
			}
			value = ECurveControlType.ChargeSlash;
			return false;
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x000918EE File Offset: 0x0008FAEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChargeSlash"
			};
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x000918FE File Offset: 0x0008FAFE
		public static ECurveControlType[] GetValues()
		{
			return new ECurveControlType[1];
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00091906 File Offset: 0x0008FB06
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChargeSlash"
			};
		}
	}
}
