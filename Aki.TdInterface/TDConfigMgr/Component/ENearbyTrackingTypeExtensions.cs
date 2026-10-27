using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AC RID: 2476
	public static class ENearbyTrackingTypeExtensions
	{
		// Token: 0x06003737 RID: 14135 RVA: 0x0008FA28 File Offset: 0x0008DC28
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
			case ENearbyTrackingType.Stealth:
				result = "Stealth";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x0008FA7C File Offset: 0x0008DC7C
		public static ENearbyTrackingType FromString(string name)
		{
			ENearbyTrackingType result;
			if (!ENearbyTrackingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENearbyTrackingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x0008FAA8 File Offset: 0x0008DCA8
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
			if (!(name == "Stealth"))
			{
				value = ENearbyTrackingType.Icon;
				return false;
			}
			value = ENearbyTrackingType.Stealth;
			return true;
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x0008FB10 File Offset: 0x0008DD10
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Icon",
				"AudioPoint",
				"Compass",
				"Stealth"
			};
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0008FB38 File Offset: 0x0008DD38
		public static ENearbyTrackingType[] GetValues()
		{
			return new ENearbyTrackingType[]
			{
				ENearbyTrackingType.Icon,
				ENearbyTrackingType.AudioPoint,
				ENearbyTrackingType.Compass,
				ENearbyTrackingType.Stealth
			};
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x0008FB4B File Offset: 0x0008DD4B
		public static string[] GetNames()
		{
			return new string[]
			{
				"Icon",
				"AudioPoint",
				"Compass",
				"Stealth"
			};
		}
	}
}
