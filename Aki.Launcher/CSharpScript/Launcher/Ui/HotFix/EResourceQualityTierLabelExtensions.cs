using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F2 RID: 242
	public static class EResourceQualityTierLabelExtensions
	{
		// Token: 0x06000819 RID: 2073 RVA: 0x0003EFF4 File Offset: 0x0003D1F4
		public static string ToEnumString(this EResourceQualityTierLabel value)
		{
			string result;
			switch (value)
			{
			case EResourceQualityTierLabel.Smooth:
				result = "SD";
				break;
			case EResourceQualityTierLabel.HD:
				result = "HD";
				break;
			case EResourceQualityTierLabel.Ultimate:
				result = "UHD";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0003F03C File Offset: 0x0003D23C
		public static EResourceQualityTierLabel FromString(string name)
		{
			EResourceQualityTierLabel result;
			if (!EResourceQualityTierLabelExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResourceQualityTierLabel 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0003F068 File Offset: 0x0003D268
		public static bool TryFromString(string name, out EResourceQualityTierLabel value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResourceQualityTierLabel.Smooth;
				return false;
			}
			if (name == "SD")
			{
				value = EResourceQualityTierLabel.Smooth;
				return true;
			}
			if (name == "HD")
			{
				value = EResourceQualityTierLabel.HD;
				return true;
			}
			if (!(name == "UHD"))
			{
				value = EResourceQualityTierLabel.Smooth;
				return false;
			}
			value = EResourceQualityTierLabel.Ultimate;
			return true;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0003F0BE File Offset: 0x0003D2BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SD",
				"HD",
				"UHD"
			};
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0003F0DE File Offset: 0x0003D2DE
		public static EResourceQualityTierLabel[] GetValues()
		{
			return new EResourceQualityTierLabel[]
			{
				EResourceQualityTierLabel.Smooth,
				EResourceQualityTierLabel.HD,
				EResourceQualityTierLabel.Ultimate
			};
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0003F0EE File Offset: 0x0003D2EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Smooth",
				"HD",
				"Ultimate"
			};
		}
	}
}
