using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002341 RID: 9025
	public static class EFontSizeExtensions
	{
		// Token: 0x0600C523 RID: 50467 RVA: 0x001CC618 File Offset: 0x001CA818
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

		// Token: 0x0600C524 RID: 50468 RVA: 0x001CC660 File Offset: 0x001CA860
		public static EFontSize FromString(string name)
		{
			EFontSize result;
			if (!EFontSizeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFontSize 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C525 RID: 50469 RVA: 0x001CC68C File Offset: 0x001CA88C
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

		// Token: 0x0600C526 RID: 50470 RVA: 0x001CC6E2 File Offset: 0x001CA8E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Small",
				"Middle",
				"Big"
			};
		}

		// Token: 0x0600C527 RID: 50471 RVA: 0x001CC702 File Offset: 0x001CA902
		public static EFontSize[] GetValues()
		{
			return new EFontSize[]
			{
				EFontSize.Small,
				EFontSize.Middle,
				EFontSize.Big
			};
		}

		// Token: 0x0600C528 RID: 50472 RVA: 0x001CC712 File Offset: 0x001CA912
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
