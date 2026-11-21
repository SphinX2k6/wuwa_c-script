using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F4 RID: 244
	public static class EResourceQualityTierTextIdExtensions
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x0003F14C File Offset: 0x0003D34C
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

		// Token: 0x06000823 RID: 2083 RVA: 0x0003F194 File Offset: 0x0003D394
		public static EResourceQualityTierTextId FromString(string name)
		{
			EResourceQualityTierTextId result;
			if (!EResourceQualityTierTextIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResourceQualityTierTextId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0003F1C0 File Offset: 0x0003D3C0
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

		// Token: 0x06000825 RID: 2085 RVA: 0x0003F216 File Offset: 0x0003D416
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ResourceQualityTier_Smooth",
				"ResourceQualityTier_HD",
				"ResourceQualityTier_Ultimate"
			};
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0003F236 File Offset: 0x0003D436
		public static EResourceQualityTierTextId[] GetValues()
		{
			return new EResourceQualityTierTextId[]
			{
				EResourceQualityTierTextId.Smooth,
				EResourceQualityTierTextId.HD,
				EResourceQualityTierTextId.Ultimate
			};
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0003F246 File Offset: 0x0003D446
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
