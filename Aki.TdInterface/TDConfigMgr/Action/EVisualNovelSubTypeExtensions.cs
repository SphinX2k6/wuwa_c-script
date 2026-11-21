using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200275E RID: 10078
	public static class EVisualNovelSubTypeExtensions
	{
		// Token: 0x0600D881 RID: 55425 RVA: 0x001FA324 File Offset: 0x001F8524
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

		// Token: 0x0600D882 RID: 55426 RVA: 0x001FA34C File Offset: 0x001F854C
		public static EVisualNovelSubType FromString(string name)
		{
			EVisualNovelSubType result;
			if (!EVisualNovelSubTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelSubType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D883 RID: 55427 RVA: 0x001FA375 File Offset: 0x001F8575
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

		// Token: 0x0600D884 RID: 55428 RVA: 0x001FA39A File Offset: 0x001F859A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}

		// Token: 0x0600D885 RID: 55429 RVA: 0x001FA3AA File Offset: 0x001F85AA
		public static EVisualNovelSubType[] GetValues()
		{
			return new EVisualNovelSubType[1];
		}

		// Token: 0x0600D886 RID: 55430 RVA: 0x001FA3B2 File Offset: 0x001F85B2
		public static string[] GetNames()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}
	}
}
