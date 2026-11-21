using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002714 RID: 10004
	public static class ETimeScaleTypeExtensions
	{
		// Token: 0x0600D734 RID: 55092 RVA: 0x001F7134 File Offset: 0x001F5334
		public static string ToEnumString(this ETimeScaleType value)
		{
			string result;
			if (value == ETimeScaleType.Global)
			{
				result = "Global";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x001F715C File Offset: 0x001F535C
		public static ETimeScaleType FromString(string name)
		{
			ETimeScaleType result;
			if (!ETimeScaleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScaleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D736 RID: 55094 RVA: 0x001F7185 File Offset: 0x001F5385
		public static bool TryFromString(string name, out ETimeScaleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeScaleType.Global;
				return false;
			}
			if (name == "Global")
			{
				value = ETimeScaleType.Global;
				return true;
			}
			value = ETimeScaleType.Global;
			return false;
		}

		// Token: 0x0600D737 RID: 55095 RVA: 0x001F71AA File Offset: 0x001F53AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Global"
			};
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x001F71BA File Offset: 0x001F53BA
		public static ETimeScaleType[] GetValues()
		{
			return new ETimeScaleType[1];
		}

		// Token: 0x0600D739 RID: 55097 RVA: 0x001F71C2 File Offset: 0x001F53C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Global"
			};
		}
	}
}
