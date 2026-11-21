using System;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200027F RID: 639
	public static class EAppTypeExtensions
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x0005C8BC File Offset: 0x0005AABC
		public static string ToEnumString(this EAppType value)
		{
			string result;
			switch (value)
			{
			case EAppType.DEVELOPMENT:
				result = "Development";
				break;
			case EAppType.PREREKEASE:
				result = "Prerelease";
				break;
			case EAppType.PRODUCT:
				result = "Product";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0005C904 File Offset: 0x0005AB04
		public static EAppType FromString(string name)
		{
			EAppType result;
			if (!EAppTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAppType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0005C930 File Offset: 0x0005AB30
		public static bool TryFromString(string name, out EAppType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAppType.DEVELOPMENT;
				return false;
			}
			if (name == "Development")
			{
				value = EAppType.DEVELOPMENT;
				return true;
			}
			if (name == "Prerelease")
			{
				value = EAppType.PREREKEASE;
				return true;
			}
			if (!(name == "Product"))
			{
				value = EAppType.DEVELOPMENT;
				return false;
			}
			value = EAppType.PRODUCT;
			return true;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0005C986 File Offset: 0x0005AB86
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Development",
				"Prerelease",
				"Product"
			};
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0005C9A6 File Offset: 0x0005ABA6
		public static EAppType[] GetValues()
		{
			return new EAppType[]
			{
				EAppType.DEVELOPMENT,
				EAppType.PREREKEASE,
				EAppType.PRODUCT
			};
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0005C9B6 File Offset: 0x0005ABB6
		public static string[] GetNames()
		{
			return new string[]
			{
				"DEVELOPMENT",
				"PREREKEASE",
				"PRODUCT"
			};
		}
	}
}
