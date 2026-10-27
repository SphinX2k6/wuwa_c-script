using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F5 RID: 8949
	public static class ECustomScreenTypeExtensions
	{
		// Token: 0x0600C3CD RID: 50125 RVA: 0x001C98E8 File Offset: 0x001C7AE8
		public static string ToEnumString(this ECustomScreenType value)
		{
			string result;
			switch (value)
			{
			case ECustomScreenType.Spine:
				result = "Spine";
				break;
			case ECustomScreenType.BackgroundImage:
				result = "BackgroundImage";
				break;
			case ECustomScreenType.Loading:
				result = "Loading";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C3CE RID: 50126 RVA: 0x001C9930 File Offset: 0x001C7B30
		public static ECustomScreenType FromString(string name)
		{
			ECustomScreenType result;
			if (!ECustomScreenTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECustomScreenType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3CF RID: 50127 RVA: 0x001C995C File Offset: 0x001C7B5C
		public static bool TryFromString(string name, out ECustomScreenType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECustomScreenType.Spine;
				return false;
			}
			if (name == "Spine")
			{
				value = ECustomScreenType.Spine;
				return true;
			}
			if (name == "BackgroundImage")
			{
				value = ECustomScreenType.BackgroundImage;
				return true;
			}
			if (!(name == "Loading"))
			{
				value = ECustomScreenType.Spine;
				return false;
			}
			value = ECustomScreenType.Loading;
			return true;
		}

		// Token: 0x0600C3D0 RID: 50128 RVA: 0x001C99B2 File Offset: 0x001C7BB2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spine",
				"BackgroundImage",
				"Loading"
			};
		}

		// Token: 0x0600C3D1 RID: 50129 RVA: 0x001C99D2 File Offset: 0x001C7BD2
		public static ECustomScreenType[] GetValues()
		{
			return new ECustomScreenType[]
			{
				ECustomScreenType.Spine,
				ECustomScreenType.BackgroundImage,
				ECustomScreenType.Loading
			};
		}

		// Token: 0x0600C3D2 RID: 50130 RVA: 0x001C99E2 File Offset: 0x001C7BE2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spine",
				"BackgroundImage",
				"Loading"
			};
		}
	}
}
