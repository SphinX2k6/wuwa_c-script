using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A61 RID: 2657
	public static class ENearbyTrackingTypeExtensions
	{
		// Token: 0x06003AC7 RID: 15047 RVA: 0x00097AEC File Offset: 0x00095CEC
		public static string ToEnumString(this ENearbyTrackingType value)
		{
			string result;
			switch (value)
			{
			case ENearbyTrackingType.Icon:
				result = "Icon";
				break;
			case ENearbyTrackingType.AudioPoint:
				result = "AudioPoint";
				break;
			case ENearbyTrackingType.Compass:
				result = "Compass";
				break;
			case ENearbyTrackingType.DarkTide:
				result = "DarkTide";
				break;
			case ENearbyTrackingType.Stealth:
				result = "Stealth";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x00097B4C File Offset: 0x00095D4C
		public static ENearbyTrackingType FromString(string name)
		{
			ENearbyTrackingType result;
			if (!ENearbyTrackingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENearbyTrackingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00097B78 File Offset: 0x00095D78
		public static bool TryFromString(string name, out ENearbyTrackingType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENearbyTrackingType.Icon;
				return false;
			}
			if (name == "Icon")
			{
				value = ENearbyTrackingType.Icon;
				return true;
			}
			if (name == "AudioPoint")
			{
				value = ENearbyTrackingType.AudioPoint;
				return true;
			}
			if (name == "Compass")
			{
				value = ENearbyTrackingType.Compass;
				return true;
			}
			if (name == "DarkTide")
			{
				value = ENearbyTrackingType.DarkTide;
				return true;
			}
			if (!(name == "Stealth"))
			{
				value = ENearbyTrackingType.Icon;
				return false;
			}
			value = ENearbyTrackingType.Stealth;
			return true;
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00097BF2 File Offset: 0x00095DF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Icon",
				"AudioPoint",
				"Compass",
				"DarkTide",
				"Stealth"
			};
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00097C22 File Offset: 0x00095E22
		public static ENearbyTrackingType[] GetValues()
		{
			return new ENearbyTrackingType[]
			{
				ENearbyTrackingType.Icon,
				ENearbyTrackingType.AudioPoint,
				ENearbyTrackingType.Compass,
				ENearbyTrackingType.DarkTide,
				ENearbyTrackingType.Stealth
			};
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00097C35 File Offset: 0x00095E35
		public static string[] GetNames()
		{
			return new string[]
			{
				"Icon",
				"AudioPoint",
				"Compass",
				"DarkTide",
				"Stealth"
			};
		}
	}
}
