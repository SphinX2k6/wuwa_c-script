using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F0 RID: 9968
	public static class ETalkBackgroundTypeExtensions
	{
		// Token: 0x0600D692 RID: 54930 RVA: 0x001F4F9C File Offset: 0x001F319C
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

		// Token: 0x0600D693 RID: 54931 RVA: 0x001F4FFC File Offset: 0x001F31FC
		public static ETalkBackgroundType FromString(string name)
		{
			ETalkBackgroundType result;
			if (!ETalkBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D694 RID: 54932 RVA: 0x001F5028 File Offset: 0x001F3228
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

		// Token: 0x0600D695 RID: 54933 RVA: 0x001F50A2 File Offset: 0x001F32A2
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

		// Token: 0x0600D696 RID: 54934 RVA: 0x001F50D2 File Offset: 0x001F32D2
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

		// Token: 0x0600D697 RID: 54935 RVA: 0x001F50E5 File Offset: 0x001F32E5
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
