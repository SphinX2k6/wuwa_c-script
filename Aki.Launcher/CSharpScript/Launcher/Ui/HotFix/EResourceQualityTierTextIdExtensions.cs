using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F0 RID: 240
	public static class EResourceQualityTierTextIdExtensions
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		public static string ToEnumString(this EResourceQualityTierTextId value)
		{
			string result;
			switch (value)
			{
			case EResourceQualityTierTextId.Smooth:
				result = "ResourceQualityTier_Smooth";
				break;
			case EResourceQualityTierTextId.HD:
				result = "ResourceQualityTier_HD";
				break;
			case EResourceQualityTierTextId.Ultimate:
				result = "ResourceQualityTier_Ultimate";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
		public static EResourceQualityTierTextId FromString(string name)
		{
			EResourceQualityTierTextId result;
			if (!EResourceQualityTierTextIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResourceQualityTierTextId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0003CE20 File Offset: 0x0003B020
		public static bool TryFromString(string name, out EResourceQualityTierTextId value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResourceQualityTierTextId.Smooth;
				return false;
			}
			if (name == "ResourceQualityTier_Smooth")
			{
				value = EResourceQualityTierTextId.Smooth;
				return true;
			}
			if (name == "ResourceQualityTier_HD")
			{
				value = EResourceQualityTierTextId.HD;
				return true;
			}
			if (!(name == "ResourceQualityTier_Ultimate"))
			{
				value = EResourceQualityTierTextId.Smooth;
				return false;
			}
			value = EResourceQualityTierTextId.Ultimate;
			return true;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0003CE76 File Offset: 0x0003B076
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ResourceQualityTier_Smooth",
				"ResourceQualityTier_HD",
				"ResourceQualityTier_Ultimate"
			};
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0003CE96 File Offset: 0x0003B096
		public static EResourceQualityTierTextId[] GetValues()
		{
			return new EResourceQualityTierTextId[]
			{
				EResourceQualityTierTextId.Smooth,
				EResourceQualityTierTextId.HD,
				EResourceQualityTierTextId.Ultimate
			};
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0003CEA6 File Offset: 0x0003B0A6
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
