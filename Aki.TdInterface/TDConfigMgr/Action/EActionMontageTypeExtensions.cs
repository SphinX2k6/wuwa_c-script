using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F4 RID: 9460
	public static class EActionMontageTypeExtensions
	{
		// Token: 0x0600CDA4 RID: 52644 RVA: 0x001DCB50 File Offset: 0x001DAD50
		public static string ToEnumString(this EActionMontageType value)
		{
			string result;
			if (value != EActionMontageType.Normal)
			{
				if (value != EActionMontageType.Sequence)
				{
					result = value.ToString();
				}
				else
				{
					result = "Sequence";
				}
			}
			else
			{
				result = "Normal";
			}
			return result;
		}

		// Token: 0x0600CDA5 RID: 52645 RVA: 0x001DCB88 File Offset: 0x001DAD88
		public static EActionMontageType FromString(string name)
		{
			EActionMontageType result;
			if (!EActionMontageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActionMontageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDA6 RID: 52646 RVA: 0x001DCBB1 File Offset: 0x001DADB1
		public static bool TryFromString(string name, out EActionMontageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActionMontageType.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = EActionMontageType.Normal;
				return true;
			}
			if (!(name == "Sequence"))
			{
				value = EActionMontageType.Normal;
				return false;
			}
			value = EActionMontageType.Sequence;
			return true;
		}

		// Token: 0x0600CDA7 RID: 52647 RVA: 0x001DCBEA File Offset: 0x001DADEA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Sequence"
			};
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x001DCC02 File Offset: 0x001DAE02
		public static EActionMontageType[] GetValues()
		{
			return new EActionMontageType[]
			{
				EActionMontageType.Normal,
				EActionMontageType.Sequence
			};
		}

		// Token: 0x0600CDA9 RID: 52649 RVA: 0x001DCC0E File Offset: 0x001DAE0E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal",
				"Sequence"
			};
		}
	}
}
