using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002465 RID: 9317
	public static class ETeleportToLatestResetPointTypeExtensions
	{
		// Token: 0x0600CA45 RID: 51781 RVA: 0x001DC3B8 File Offset: 0x001DA5B8
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

		// Token: 0x0600CA46 RID: 51782 RVA: 0x001DC3E0 File Offset: 0x001DA5E0
		public static ETeleportToLatestResetPointType FromString(string name)
		{
			ETeleportToLatestResetPointType result;
			if (!ETeleportToLatestResetPointTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleportToLatestResetPointType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA47 RID: 51783 RVA: 0x001DC409 File Offset: 0x001DA609
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

		// Token: 0x0600CA48 RID: 51784 RVA: 0x001DC42E File Offset: 0x001DA62E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Directly"
			};
		}

		// Token: 0x0600CA49 RID: 51785 RVA: 0x001DC43E File Offset: 0x001DA63E
		public static ETeleportToLatestResetPointType[] GetValues()
		{
			return new ETeleportToLatestResetPointType[1];
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x001DC446 File Offset: 0x001DA646
		public static string[] GetNames()
		{
			return new string[]
			{
				"Directly"
			};
		}
	}
}
