using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091A RID: 2330
	public static class ECurveControlTypeExtensions
	{
		// Token: 0x060034A6 RID: 13478 RVA: 0x00089CF8 File Offset: 0x00087EF8
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

		// Token: 0x060034A7 RID: 13479 RVA: 0x00089D20 File Offset: 0x00087F20
		public static ECurveControlType FromString(string name)
		{
			ECurveControlType result;
			if (!ECurveControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECurveControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00089D49 File Offset: 0x00087F49
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

		// Token: 0x060034A9 RID: 13481 RVA: 0x00089D6E File Offset: 0x00087F6E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChargeSlash"
			};
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00089D7E File Offset: 0x00087F7E
		public static ECurveControlType[] GetValues()
		{
			return new ECurveControlType[1];
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00089D86 File Offset: 0x00087F86
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChargeSlash"
			};
		}
	}
}
