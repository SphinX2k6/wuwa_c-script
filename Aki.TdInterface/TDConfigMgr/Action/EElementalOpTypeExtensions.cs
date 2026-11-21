using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002586 RID: 9606
	public static class EElementalOpTypeExtensions
	{
		// Token: 0x0600D035 RID: 53301 RVA: 0x001E2A6C File Offset: 0x001E0C6C
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

		// Token: 0x0600D036 RID: 53302 RVA: 0x001E2AA4 File Offset: 0x001E0CA4
		public static EElementalOpType FromString(string name)
		{
			EElementalOpType result;
			if (!EElementalOpTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalOpType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D037 RID: 53303 RVA: 0x001E2ACD File Offset: 0x001E0CCD
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

		// Token: 0x0600D038 RID: 53304 RVA: 0x001E2B06 File Offset: 0x001E0D06
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Grant",
				"Remove"
			};
		}

		// Token: 0x0600D039 RID: 53305 RVA: 0x001E2B1E File Offset: 0x001E0D1E
		public static EElementalOpType[] GetValues()
		{
			return new EElementalOpType[]
			{
				EElementalOpType.Grant,
				EElementalOpType.Remove
			};
		}

		// Token: 0x0600D03A RID: 53306 RVA: 0x001E2B2A File Offset: 0x001E0D2A
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
