using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242D RID: 9261
	public static class ESportStateTypeExtensions
	{
		// Token: 0x0600C949 RID: 51529 RVA: 0x001D7938 File Offset: 0x001D5B38
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
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C94A RID: 51530 RVA: 0x001D7980 File Offset: 0x001D5B80
		public static ESportStateType FromString(string name)
		{
			ESportStateType result;
			if (!ESportStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESportStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x001D79AC File Offset: 0x001D5BAC
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
			if (!(name == "PetalGrab"))
			{
				value = ESportStateType.Slide;
				return false;
			}
			value = ESportStateType.PetalGrab;
			return true;
		}

		// Token: 0x0600C94C RID: 51532 RVA: 0x001D7A02 File Offset: 0x001D5C02
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Slide",
				"Ski",
				"PetalGrab"
			};
		}

		// Token: 0x0600C94D RID: 51533 RVA: 0x001D7A22 File Offset: 0x001D5C22
		public static ESportStateType[] GetValues()
		{
			return new ESportStateType[]
			{
				ESportStateType.Slide,
				ESportStateType.Ski,
				ESportStateType.PetalGrab
			};
		}

		// Token: 0x0600C94E RID: 51534 RVA: 0x001D7A32 File Offset: 0x001D5C32
		public static string[] GetNames()
		{
			return new string[]
			{
				"Slide",
				"Ski",
				"PetalGrab"
			};
		}
	}
}
