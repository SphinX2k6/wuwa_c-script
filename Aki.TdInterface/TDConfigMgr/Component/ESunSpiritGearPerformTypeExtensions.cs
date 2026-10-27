using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A24 RID: 2596
	public static class ESunSpiritGearPerformTypeExtensions
	{
		// Token: 0x06003953 RID: 14675 RVA: 0x000941E4 File Offset: 0x000923E4
		public static string ToEnumString(this ESunSpiritGearPerformType value)
		{
			string result;
			if (value != ESunSpiritGearPerformType.ToGearRelativePos)
			{
				if (value != ESunSpiritGearPerformType.ScaleUp)
				{
					result = value.ToString();
				}
				else
				{
					result = "ScaleUp";
				}
			}
			else
			{
				result = "ToGearRelativePos";
			}
			return result;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0009421C File Offset: 0x0009241C
		public static ESunSpiritGearPerformType FromString(string name)
		{
			ESunSpiritGearPerformType result;
			if (!ESunSpiritGearPerformTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESunSpiritGearPerformType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x00094245 File Offset: 0x00092445
		public static bool TryFromString(string name, out ESunSpiritGearPerformType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESunSpiritGearPerformType.ToGearRelativePos;
				return false;
			}
			if (name == "ToGearRelativePos")
			{
				value = ESunSpiritGearPerformType.ToGearRelativePos;
				return true;
			}
			if (!(name == "ScaleUp"))
			{
				value = ESunSpiritGearPerformType.ToGearRelativePos;
				return false;
			}
			value = ESunSpiritGearPerformType.ScaleUp;
			return true;
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x0009427E File Offset: 0x0009247E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ToGearRelativePos",
				"ScaleUp"
			};
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00094296 File Offset: 0x00092496
		public static ESunSpiritGearPerformType[] GetValues()
		{
			return new ESunSpiritGearPerformType[]
			{
				ESunSpiritGearPerformType.ToGearRelativePos,
				ESunSpiritGearPerformType.ScaleUp
			};
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x000942A2 File Offset: 0x000924A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ToGearRelativePos",
				"ScaleUp"
			};
		}
	}
}
