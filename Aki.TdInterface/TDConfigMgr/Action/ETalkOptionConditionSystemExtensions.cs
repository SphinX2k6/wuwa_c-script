using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002459 RID: 9305
	public static class ETalkOptionConditionSystemExtensions
	{
		// Token: 0x0600CA0F RID: 51727 RVA: 0x001DB9A0 File Offset: 0x001D9BA0
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

		// Token: 0x0600CA10 RID: 51728 RVA: 0x001DB9C8 File Offset: 0x001D9BC8
		public static ETalkOptionConditionSystem FromString(string name)
		{
			ETalkOptionConditionSystem result;
			if (!ETalkOptionConditionSystemExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkOptionConditionSystem 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA11 RID: 51729 RVA: 0x001DB9F1 File Offset: 0x001D9BF1
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

		// Token: 0x0600CA12 RID: 51730 RVA: 0x001DBA16 File Offset: 0x001D9C16
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x001DBA26 File Offset: 0x001D9C26
		public static ETalkOptionConditionSystem[] GetValues()
		{
			return new ETalkOptionConditionSystem[1];
		}

		// Token: 0x0600CA14 RID: 51732 RVA: 0x001DBA2E File Offset: 0x001D9C2E
		public static string[] GetNames()
		{
			return new string[]
			{
				"SolarSchool"
			};
		}
	}
}
