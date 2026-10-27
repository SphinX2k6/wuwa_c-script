using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000942 RID: 2370
	public static class EExtraRangeTypeExtensions
	{
		// Token: 0x0600355A RID: 13658 RVA: 0x0008B658 File Offset: 0x00089858
		public static string ToEnumString(this EExtraRangeType value)
		{
			string result;
			if (value == EExtraRangeType.SunSpiritBlock)
			{
				result = "SunSpiritBlock";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x0008B680 File Offset: 0x00089880
		public static EExtraRangeType FromString(string name)
		{
			EExtraRangeType result;
			if (!EExtraRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExtraRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0008B6A9 File Offset: 0x000898A9
		public static bool TryFromString(string name, out EExtraRangeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExtraRangeType.SunSpiritBlock;
				return false;
			}
			if (name == "SunSpiritBlock")
			{
				value = EExtraRangeType.SunSpiritBlock;
				return true;
			}
			value = EExtraRangeType.SunSpiritBlock;
			return false;
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0008B6CE File Offset: 0x000898CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SunSpiritBlock"
			};
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0008B6DE File Offset: 0x000898DE
		public static EExtraRangeType[] GetValues()
		{
			return new EExtraRangeType[1];
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0008B6E6 File Offset: 0x000898E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SunSpiritBlock"
			};
		}
	}
}
