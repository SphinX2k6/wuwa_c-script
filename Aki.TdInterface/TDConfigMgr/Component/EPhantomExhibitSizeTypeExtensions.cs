using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A93 RID: 2707
	public static class EPhantomExhibitSizeTypeExtensions
	{
		// Token: 0x06003BA8 RID: 15272 RVA: 0x00099824 File Offset: 0x00097A24
		public static string ToEnumString(this EPhantomExhibitSizeType value)
		{
			string result;
			switch (value)
			{
			case EPhantomExhibitSizeType.Small:
				result = "Small";
				break;
			case EPhantomExhibitSizeType.Big:
				result = "Medium";
				break;
			case EPhantomExhibitSizeType.Huge:
				result = "Huge";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x0009986C File Offset: 0x00097A6C
		public static EPhantomExhibitSizeType FromString(string name)
		{
			EPhantomExhibitSizeType result;
			if (!EPhantomExhibitSizeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhantomExhibitSizeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00099898 File Offset: 0x00097A98
		public static bool TryFromString(string name, out EPhantomExhibitSizeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhantomExhibitSizeType.Small;
				return false;
			}
			if (name == "Small")
			{
				value = EPhantomExhibitSizeType.Small;
				return true;
			}
			if (name == "Medium")
			{
				value = EPhantomExhibitSizeType.Big;
				return true;
			}
			if (!(name == "Huge"))
			{
				value = EPhantomExhibitSizeType.Small;
				return false;
			}
			value = EPhantomExhibitSizeType.Huge;
			return true;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x000998EE File Offset: 0x00097AEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Small",
				"Medium",
				"Huge"
			};
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x0009990E File Offset: 0x00097B0E
		public static EPhantomExhibitSizeType[] GetValues()
		{
			return new EPhantomExhibitSizeType[]
			{
				EPhantomExhibitSizeType.Small,
				EPhantomExhibitSizeType.Big,
				EPhantomExhibitSizeType.Huge
			};
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x0009991E File Offset: 0x00097B1E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Small",
				"Big",
				"Huge"
			};
		}
	}
}
