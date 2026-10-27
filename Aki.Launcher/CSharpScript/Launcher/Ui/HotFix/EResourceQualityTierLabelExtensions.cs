using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EE RID: 238
	public static class EResourceQualityTierLabelExtensions
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x0003CC54 File Offset: 0x0003AE54
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

		// Token: 0x060007E6 RID: 2022 RVA: 0x0003CC9C File Offset: 0x0003AE9C
		public static EResourceQualityTierLabel FromString(string name)
		{
			EResourceQualityTierLabel result;
			if (!EResourceQualityTierLabelExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResourceQualityTierLabel 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0003CCC8 File Offset: 0x0003AEC8
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

		// Token: 0x060007E8 RID: 2024 RVA: 0x0003CD1E File Offset: 0x0003AF1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SD",
				"HD",
				"UHD"
			};
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0003CD3E File Offset: 0x0003AF3E
		public static EResourceQualityTierLabel[] GetValues()
		{
			return new EResourceQualityTierLabel[]
			{
				EResourceQualityTierLabel.Smooth,
				EResourceQualityTierLabel.HD,
				EResourceQualityTierLabel.Ultimate
			};
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0003CD4E File Offset: 0x0003AF4E
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
