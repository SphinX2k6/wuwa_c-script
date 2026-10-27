using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002317 RID: 8983
	public static class EElementalOpTypeExtensions
	{
		// Token: 0x0600C466 RID: 50278 RVA: 0x001CABA4 File Offset: 0x001C8DA4
		public static string ToEnumString(this EElementalOpType value)
		{
			string result;
			if (value != EElementalOpType.Grant)
			{
				if (value != EElementalOpType.Remove)
				{
					result = value.ToString();
				}
				else
				{
					result = "Remove";
				}
			}
			else
			{
				result = "Grant";
			}
			return result;
		}

		// Token: 0x0600C467 RID: 50279 RVA: 0x001CABDC File Offset: 0x001C8DDC
		public static EElementalOpType FromString(string name)
		{
			EElementalOpType result;
			if (!EElementalOpTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalOpType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C468 RID: 50280 RVA: 0x001CAC05 File Offset: 0x001C8E05
		public static bool TryFromString(string name, out EElementalOpType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EElementalOpType.Grant;
				return false;
			}
			if (name == "Grant")
			{
				value = EElementalOpType.Grant;
				return true;
			}
			if (!(name == "Remove"))
			{
				value = EElementalOpType.Grant;
				return false;
			}
			value = EElementalOpType.Remove;
			return true;
		}

		// Token: 0x0600C469 RID: 50281 RVA: 0x001CAC3E File Offset: 0x001C8E3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Grant",
				"Remove"
			};
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x001CAC56 File Offset: 0x001C8E56
		public static EElementalOpType[] GetValues()
		{
			return new EElementalOpType[]
			{
				EElementalOpType.Grant,
				EElementalOpType.Remove
			};
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x001CAC62 File Offset: 0x001C8E62
		public static string[] GetNames()
		{
			return new string[]
			{
				"Grant",
				"Remove"
			};
		}
	}
}
