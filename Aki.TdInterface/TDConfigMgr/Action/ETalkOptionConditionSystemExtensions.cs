using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026FA RID: 9978
	public static class ETalkOptionConditionSystemExtensions
	{
		// Token: 0x0600D6BF RID: 54975 RVA: 0x001F5A54 File Offset: 0x001F3C54
		public static string ToEnumString(this ETalkOptionConditionSystem value)
		{
			string result;
			if (value == ETalkOptionConditionSystem.SolarSchool)
			{
				result = "SolarSchool";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D6C0 RID: 54976 RVA: 0x001F5A7C File Offset: 0x001F3C7C
		public static ETalkOptionConditionSystem FromString(string name)
		{
			ETalkOptionConditionSystem result;
			if (!ETalkOptionConditionSystemExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkOptionConditionSystem 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6C1 RID: 54977 RVA: 0x001F5AA5 File Offset: 0x001F3CA5
		public static bool TryFromString(string name, out ETalkOptionConditionSystem value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkOptionConditionSystem.SolarSchool;
				return false;
			}
			if (name == "SolarSchool")
			{
				value = ETalkOptionConditionSystem.SolarSchool;
				return true;
			}
			value = ETalkOptionConditionSystem.SolarSchool;
			return false;
		}

		// Token: 0x0600D6C2 RID: 54978 RVA: 0x001F5ACA File Offset: 0x001F3CCA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x001F5ADA File Offset: 0x001F3CDA
		public static ETalkOptionConditionSystem[] GetValues()
		{
			return new ETalkOptionConditionSystem[1];
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x001F5AE2 File Offset: 0x001F3CE2
		public static string[] GetNames()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}
	}
}
