using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F1 RID: 2545
	public static class EExtraRangeTypeExtensions
	{
		// Token: 0x060038CF RID: 14543 RVA: 0x00093310 File Offset: 0x00091510
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

		// Token: 0x060038D0 RID: 14544 RVA: 0x00093338 File Offset: 0x00091538
		public static EExtraRangeType FromString(string name)
		{
			EExtraRangeType result;
			if (!EExtraRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExtraRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00093361 File Offset: 0x00091561
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

		// Token: 0x060038D2 RID: 14546 RVA: 0x00093386 File Offset: 0x00091586
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SunSpiritBlock"
			};
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00093396 File Offset: 0x00091596
		public static EExtraRangeType[] GetValues()
		{
			return new EExtraRangeType[1];
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0009339E File Offset: 0x0009159E
		public static string[] GetNames()
		{
			return new string[]
			{
				"SunSpiritBlock"
			};
		}
	}
}
