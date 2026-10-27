using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EF RID: 8943
	public static class EControlTrackingTypeExtensions
	{
		// Token: 0x0600C3B2 RID: 50098 RVA: 0x001C95A0 File Offset: 0x001C77A0
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

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x001C95D8 File Offset: 0x001C77D8
		public static EControlTrackingType FromString(string name)
		{
			EControlTrackingType result;
			if (!EControlTrackingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EControlTrackingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3B4 RID: 50100 RVA: 0x001C9601 File Offset: 0x001C7801
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

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x001C963A File Offset: 0x001C783A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Self",
				"Other"
			};
		}

		// Token: 0x0600C3B6 RID: 50102 RVA: 0x001C9652 File Offset: 0x001C7852
		public static EControlTrackingType[] GetValues()
		{
			return new EControlTrackingType[]
			{
				EControlTrackingType.Self,
				EControlTrackingType.Other
			};
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x001C965E File Offset: 0x001C785E
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
