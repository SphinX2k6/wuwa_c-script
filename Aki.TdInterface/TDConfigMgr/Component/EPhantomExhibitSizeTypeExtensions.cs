using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CE RID: 2510
	public static class EPhantomExhibitSizeTypeExtensions
	{
		// Token: 0x060037D0 RID: 14288 RVA: 0x00090F64 File Offset: 0x0008F164
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

		// Token: 0x060037D1 RID: 14289 RVA: 0x00090FAC File Offset: 0x0008F1AC
		public static EPhantomExhibitSizeType FromString(string name)
		{
			EPhantomExhibitSizeType result;
			if (!EPhantomExhibitSizeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhantomExhibitSizeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00090FD8 File Offset: 0x0008F1D8
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

		// Token: 0x060037D3 RID: 14291 RVA: 0x0009102E File Offset: 0x0008F22E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Small",
				"Medium",
				"Huge"
			};
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x0009104E File Offset: 0x0008F24E
		public static EPhantomExhibitSizeType[] GetValues()
		{
			return new EPhantomExhibitSizeType[]
			{
				EPhantomExhibitSizeType.Small,
				EPhantomExhibitSizeType.Big,
				EPhantomExhibitSizeType.Huge
			};
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x0009105E File Offset: 0x0008F25E
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
