using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200255E RID: 9566
	public static class EControlTrackingTypeExtensions
	{
		// Token: 0x0600CF81 RID: 53121 RVA: 0x001E13EC File Offset: 0x001DF5EC
		public static string ToEnumString(this EControlTrackingType value)
		{
			string result;
			if (value != EControlTrackingType.Self)
			{
				if (value != EControlTrackingType.Other)
				{
					result = value.ToString();
				}
				else
				{
					result = "Other";
				}
			}
			else
			{
				result = "Self";
			}
			return result;
		}

		// Token: 0x0600CF82 RID: 53122 RVA: 0x001E1424 File Offset: 0x001DF624
		public static EControlTrackingType FromString(string name)
		{
			EControlTrackingType result;
			if (!EControlTrackingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EControlTrackingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF83 RID: 53123 RVA: 0x001E144D File Offset: 0x001DF64D
		public static bool TryFromString(string name, out EControlTrackingType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EControlTrackingType.Self;
				return false;
			}
			if (name == "Self")
			{
				value = EControlTrackingType.Self;
				return true;
			}
			if (!(name == "Other"))
			{
				value = EControlTrackingType.Self;
				return false;
			}
			value = EControlTrackingType.Other;
			return true;
		}

		// Token: 0x0600CF84 RID: 53124 RVA: 0x001E1486 File Offset: 0x001DF686
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Self",
				"Other"
			};
		}

		// Token: 0x0600CF85 RID: 53125 RVA: 0x001E149E File Offset: 0x001DF69E
		public static EControlTrackingType[] GetValues()
		{
			return new EControlTrackingType[]
			{
				EControlTrackingType.Self,
				EControlTrackingType.Other
			};
		}

		// Token: 0x0600CF86 RID: 53126 RVA: 0x001E14AA File Offset: 0x001DF6AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Self",
				"Other"
			};
		}
	}
}
