using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026CE RID: 9934
	public static class ESportStateTypeExtensions
	{
		// Token: 0x0600D5F9 RID: 54777 RVA: 0x001F17D0 File Offset: 0x001EF9D0
		public static string ToEnumString(this ESportStateType value)
		{
			string result;
			switch (value)
			{
			case ESportStateType.Slide:
				result = "Slide";
				break;
			case ESportStateType.Ski:
				result = "Ski";
				break;
			case ESportStateType.PetalGrab:
				result = "PetalGrab";
				break;
			case ESportStateType.PetalFly:
				result = "PetalFly";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x001F1824 File Offset: 0x001EFA24
		public static ESportStateType FromString(string name)
		{
			ESportStateType result;
			if (!ESportStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESportStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5FB RID: 54779 RVA: 0x001F1850 File Offset: 0x001EFA50
		public static bool TryFromString(string name, out ESportStateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESportStateType.Slide;
				return false;
			}
			if (name == "Slide")
			{
				value = ESportStateType.Slide;
				return true;
			}
			if (name == "Ski")
			{
				value = ESportStateType.Ski;
				return true;
			}
			if (name == "PetalGrab")
			{
				value = ESportStateType.PetalGrab;
				return true;
			}
			if (!(name == "PetalFly"))
			{
				value = ESportStateType.Slide;
				return false;
			}
			value = ESportStateType.PetalFly;
			return true;
		}

		// Token: 0x0600D5FC RID: 54780 RVA: 0x001F18B8 File Offset: 0x001EFAB8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Slide",
				"Ski",
				"PetalGrab",
				"PetalFly"
			};
		}

		// Token: 0x0600D5FD RID: 54781 RVA: 0x001F18E0 File Offset: 0x001EFAE0
		public static ESportStateType[] GetValues()
		{
			return new ESportStateType[]
			{
				ESportStateType.Slide,
				ESportStateType.Ski,
				ESportStateType.PetalGrab,
				ESportStateType.PetalFly
			};
		}

		// Token: 0x0600D5FE RID: 54782 RVA: 0x001F18F3 File Offset: 0x001EFAF3
		public static string[] GetNames()
		{
			return new string[]
			{
				"Slide",
				"Ski",
				"PetalGrab",
				"PetalFly"
			};
		}
	}
}
