using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B4 RID: 9652
	public static class EFontSizeExtensions
	{
		// Token: 0x0600D104 RID: 53508 RVA: 0x001E47E4 File Offset: 0x001E29E4
		public static string ToEnumString(this EFontSize value)
		{
			string result;
			switch (value)
			{
			case EFontSize.Small:
				result = "Small";
				break;
			case EFontSize.Middle:
				result = "Middle";
				break;
			case EFontSize.Big:
				result = "Big";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D105 RID: 53509 RVA: 0x001E482C File Offset: 0x001E2A2C
		public static EFontSize FromString(string name)
		{
			EFontSize result;
			if (!EFontSizeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFontSize 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D106 RID: 53510 RVA: 0x001E4858 File Offset: 0x001E2A58
		public static bool TryFromString(string name, out EFontSize value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFontSize.Small;
				return false;
			}
			if (name == "Small")
			{
				value = EFontSize.Small;
				return true;
			}
			if (name == "Middle")
			{
				value = EFontSize.Middle;
				return true;
			}
			if (!(name == "Big"))
			{
				value = EFontSize.Small;
				return false;
			}
			value = EFontSize.Big;
			return true;
		}

		// Token: 0x0600D107 RID: 53511 RVA: 0x001E48AE File Offset: 0x001E2AAE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Small",
				"Middle",
				"Big"
			};
		}

		// Token: 0x0600D108 RID: 53512 RVA: 0x001E48CE File Offset: 0x001E2ACE
		public static EFontSize[] GetValues()
		{
			return new EFontSize[]
			{
				EFontSize.Small,
				EFontSize.Middle,
				EFontSize.Big
			};
		}

		// Token: 0x0600D109 RID: 53513 RVA: 0x001E48DE File Offset: 0x001E2ADE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Small",
				"Middle",
				"Big"
			};
		}
	}
}
