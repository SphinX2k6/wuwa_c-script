using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AD RID: 9389
	public static class EVisualNovelOptionGroupTypeExtensions
	{
		// Token: 0x0600CB89 RID: 52105 RVA: 0x001DF588 File Offset: 0x001DD788
		public static string ToEnumString(this EVisualNovelOptionGroupType value)
		{
			string result;
			if (value == EVisualNovelOptionGroupType.SolarSchoolExam)
			{
				result = "SolarSchoolExam";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CB8A RID: 52106 RVA: 0x001DF5B0 File Offset: 0x001DD7B0
		public static EVisualNovelOptionGroupType FromString(string name)
		{
			EVisualNovelOptionGroupType result;
			if (!EVisualNovelOptionGroupTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelOptionGroupType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB8B RID: 52107 RVA: 0x001DF5D9 File Offset: 0x001DD7D9
		public static bool TryFromString(string name, out EVisualNovelOptionGroupType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelOptionGroupType.SolarSchoolExam;
				return false;
			}
			if (name == "SolarSchoolExam")
			{
				value = EVisualNovelOptionGroupType.SolarSchoolExam;
				return true;
			}
			value = EVisualNovelOptionGroupType.SolarSchoolExam;
			return false;
		}

		// Token: 0x0600CB8C RID: 52108 RVA: 0x001DF5FE File Offset: 0x001DD7FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SolarSchoolExam"
			};
		}

		// Token: 0x0600CB8D RID: 52109 RVA: 0x001DF60E File Offset: 0x001DD80E
		public static EVisualNovelOptionGroupType[] GetValues()
		{
			return new EVisualNovelOptionGroupType[1];
		}

		// Token: 0x0600CB8E RID: 52110 RVA: 0x001DF616 File Offset: 0x001DD816
		public static string[] GetNames()
		{
			return new string[]
			{
				"SolarSchoolExam"
			};
		}
	}
}
