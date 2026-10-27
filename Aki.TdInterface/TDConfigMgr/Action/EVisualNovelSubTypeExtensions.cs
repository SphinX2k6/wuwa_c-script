using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B7 RID: 9399
	public static class EVisualNovelSubTypeExtensions
	{
		// Token: 0x0600CBB6 RID: 52150 RVA: 0x001DFF38 File Offset: 0x001DE138
		public static string ToEnumString(this EVisualNovelSubType value)
		{
			string result;
			if (value == EVisualNovelSubType.SolarSchool)
			{
				result = "SolarSchool";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CBB7 RID: 52151 RVA: 0x001DFF60 File Offset: 0x001DE160
		public static EVisualNovelSubType FromString(string name)
		{
			EVisualNovelSubType result;
			if (!EVisualNovelSubTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelSubType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x001DFF89 File Offset: 0x001DE189
		public static bool TryFromString(string name, out EVisualNovelSubType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelSubType.SolarSchool;
				return false;
			}
			if (name == "SolarSchool")
			{
				value = EVisualNovelSubType.SolarSchool;
				return true;
			}
			value = EVisualNovelSubType.SolarSchool;
			return false;
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x001DFFAE File Offset: 0x001DE1AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x001DFFBE File Offset: 0x001DE1BE
		public static EVisualNovelSubType[] GetValues()
		{
			return new EVisualNovelSubType[1];
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x001DFFC6 File Offset: 0x001DE1C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}
	}
}
