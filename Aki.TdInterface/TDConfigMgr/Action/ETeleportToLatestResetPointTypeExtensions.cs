using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002706 RID: 9990
	public static class ETeleportToLatestResetPointTypeExtensions
	{
		// Token: 0x0600D6F5 RID: 55029 RVA: 0x001F646C File Offset: 0x001F466C
		public static string ToEnumString(this ETeleportToLatestResetPointType value)
		{
			string result;
			if (value == ETeleportToLatestResetPointType.Directly)
			{
				result = "Directly";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D6F6 RID: 55030 RVA: 0x001F6494 File Offset: 0x001F4694
		public static ETeleportToLatestResetPointType FromString(string name)
		{
			ETeleportToLatestResetPointType result;
			if (!ETeleportToLatestResetPointTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleportToLatestResetPointType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6F7 RID: 55031 RVA: 0x001F64BD File Offset: 0x001F46BD
		public static bool TryFromString(string name, out ETeleportToLatestResetPointType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETeleportToLatestResetPointType.Directly;
				return false;
			}
			if (name == "Directly")
			{
				value = ETeleportToLatestResetPointType.Directly;
				return true;
			}
			value = ETeleportToLatestResetPointType.Directly;
			return false;
		}

		// Token: 0x0600D6F8 RID: 55032 RVA: 0x001F64E2 File Offset: 0x001F46E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Directly"
			};
		}

		// Token: 0x0600D6F9 RID: 55033 RVA: 0x001F64F2 File Offset: 0x001F46F2
		public static ETeleportToLatestResetPointType[] GetValues()
		{
			return new ETeleportToLatestResetPointType[1];
		}

		// Token: 0x0600D6FA RID: 55034 RVA: 0x001F64FA File Offset: 0x001F46FA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Directly"
			};
		}
	}
}
