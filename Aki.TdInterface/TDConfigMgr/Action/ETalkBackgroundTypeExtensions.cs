using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244F RID: 9295
	public static class ETalkBackgroundTypeExtensions
	{
		// Token: 0x0600C9E2 RID: 51682 RVA: 0x001DAF2C File Offset: 0x001D912C
		public static string ToEnumString(this ETalkBackgroundType value)
		{
			string result;
			switch (value)
			{
			case ETalkBackgroundType.Clean:
				result = "Clean";
				break;
			case ETalkBackgroundType.Image:
				result = "Image";
				break;
			case ETalkBackgroundType.ImageByMcGender:
				result = "ImageByMcGender";
				break;
			case ETalkBackgroundType.Icon:
				result = "Icon";
				break;
			case ETalkBackgroundType.SpineImage:
				result = "SpineImage";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C9E3 RID: 51683 RVA: 0x001DAF8C File Offset: 0x001D918C
		public static ETalkBackgroundType FromString(string name)
		{
			ETalkBackgroundType result;
			if (!ETalkBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9E4 RID: 51684 RVA: 0x001DAFB8 File Offset: 0x001D91B8
		public static bool TryFromString(string name, out ETalkBackgroundType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkBackgroundType.Clean;
				return false;
			}
			if (name == "Clean")
			{
				value = ETalkBackgroundType.Clean;
				return true;
			}
			if (name == "Image")
			{
				value = ETalkBackgroundType.Image;
				return true;
			}
			if (name == "ImageByMcGender")
			{
				value = ETalkBackgroundType.ImageByMcGender;
				return true;
			}
			if (name == "Icon")
			{
				value = ETalkBackgroundType.Icon;
				return true;
			}
			if (!(name == "SpineImage"))
			{
				value = ETalkBackgroundType.Clean;
				return false;
			}
			value = ETalkBackgroundType.SpineImage;
			return true;
		}

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x001DB032 File Offset: 0x001D9232
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Clean",
				"Image",
				"ImageByMcGender",
				"Icon",
				"SpineImage"
			};
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x001DB062 File Offset: 0x001D9262
		public static ETalkBackgroundType[] GetValues()
		{
			return new ETalkBackgroundType[]
			{
				ETalkBackgroundType.Clean,
				ETalkBackgroundType.Image,
				ETalkBackgroundType.ImageByMcGender,
				ETalkBackgroundType.Icon,
				ETalkBackgroundType.SpineImage
			};
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x001DB075 File Offset: 0x001D9275
		public static string[] GetNames()
		{
			return new string[]
			{
				"Clean",
				"Image",
				"ImageByMcGender",
				"Icon",
				"SpineImage"
			};
		}
	}
}
