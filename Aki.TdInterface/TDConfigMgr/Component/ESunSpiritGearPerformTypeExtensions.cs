using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE9 RID: 2793
	public static class ESunSpiritGearPerformTypeExtensions
	{
		// Token: 0x06003D2B RID: 15659 RVA: 0x0009CB18 File Offset: 0x0009AD18
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

		// Token: 0x06003D2C RID: 15660 RVA: 0x0009CB50 File Offset: 0x0009AD50
		public static ESunSpiritGearPerformType FromString(string name)
		{
			ESunSpiritGearPerformType result;
			if (!ESunSpiritGearPerformTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESunSpiritGearPerformType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x0009CB79 File Offset: 0x0009AD79
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

		// Token: 0x06003D2E RID: 15662 RVA: 0x0009CBB2 File Offset: 0x0009ADB2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ToGearRelativePos",
				"ScaleUp"
			};
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x0009CBCA File Offset: 0x0009ADCA
		public static ESunSpiritGearPerformType[] GetValues()
		{
			return new ESunSpiritGearPerformType[]
			{
				ESunSpiritGearPerformType.ToGearRelativePos,
				ESunSpiritGearPerformType.ScaleUp
			};
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x0009CBD6 File Offset: 0x0009ADD6
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
